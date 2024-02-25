using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTMS.UI.Forms.Tours
{
    public partial class formTourDestinations : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False");
        SqlDataAdapter da;
        SqlCommand cmd;


        DataSet ds = new DataSet();

        public formTourDestinations()
        {
            InitializeComponent();
        }

        #region Functions


        #region Functions for Destination
        private void SelectDataForDestination()
        {
            cmd = new SqlCommand("SELECT * FROM TourDestinations", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "TourDestinations");

            dgvTourDestination.DataSource = ds.Tables["TourDestinations"];
        }

        private bool isvalidate()
        {

            //if (lblItineraryId.Text != "")
            //{
            //    return false;
            //}
            //else if (tbDestination.Text != "")
            //{
            //    return false;
            //}
            //else if (tbDayNumber.Text != "")
            //{
            //    return false;
            //}
            //else if (tbActivity.Text != "")
            //{
            //    return false;
            //}

            //else if (dtpStart.Value >= dtpEnd.Value)
            //{
            //    return false;
            //}

            return true;
        }

        private byte[] getImage() //to save the image
        {
            MemoryStream stream = new MemoryStream();
            ImgDestination.Image.Save(stream, ImgDestination.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void InsertDataForDestination()
        {
            //if (isvalidate())
            //{
                try
                {

                    string query = @"INSERT INTO TourDestinations ( DestinationId, DestinationName, Description, DestinationImg, PackageId )VALUES ( @DestinationId, @DestinationName, @Description, @DestinationImg, @PackageId)";

                    SqlCommand command = new SqlCommand(query, con);

                    command.Parameters.AddWithValue("@DestinationId", lblDestinationId.Text);
                    command.Parameters.AddWithValue("@DestinationName", tbDestinationName.Text);
                    command.Parameters.AddWithValue("@Description", dtpEnd.Text);
                    command.Parameters.AddWithValue("@DestinationImg", getImage());
                    command.Parameters.AddWithValue("@PackageId", tbPackageName .Text);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("New Destination Saved Successfully");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            //}
            //else
            //{
            //    MessageBox.Show("Please Enter All the Fields......", "Registeration Failed!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void UpdateDataForDestination()
        {
            try
            {
                string query = @"UPDATE TourDestinations SET DestinationName=@DestinationName, Description=@Description, DestinationImg=@DestinationImg, PackageId=@PackageId WHERE DestinationId=@DestinationId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@DestinationId", lblDestinationId.Text);
                command.Parameters.AddWithValue("@DestinationName", tbDestinationName.Text);
                command.Parameters.AddWithValue("@Description", dtpEnd.Text);
                command.Parameters.AddWithValue("@DestinationImg", getImage());
                command.Parameters.AddWithValue("@PackageId", tbPackageName.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Destination updated Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void DeleteDataForDestination()
        {
            try
            {
                string query = @"DELETE FROM TourDestinations WHERE DestinationId = @DestinationId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@DestinationId", lblDestinationId.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Destination Deleted Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        #endregion

        #region Functions for Itinerary
        private void ItineraryDataSave()
        {
            foreach (DataGridViewRow row in dgvTourItinerary.Rows)
            {
                // Check if the row is not empty
                if (!row.IsNewRow)
                {
                    // Extract data from DataGridView cells
                    string SrNo = row.Cells["clmSRNO"].Value.ToString();
                    string ItineraryName = row.Cells["clmItineraryName"].Value.ToString();
                    string DayNo = row.Cells["clmDayNo"].Value.ToString();
                    string Activity = row.Cells["clmActivity"].Value.ToString();
                    string StartDT = (row.Cells["clmSDT"].ToString());
                    string EndDT = (row.Cells["clmEDT"].ToString());
                    Image image = (Image)row.Cells["clmImage"].Value; 

                    // Convert image to byte array
                    byte[] imageData = ImageToByteArray(image);
                    // Save the data into the itinerary database table
                    SaveItineraryToDB(SrNo, ItineraryName, DayNo, Activity, StartDT, EndDT, imageData);
                }
            }

            // Optionally, show a message indicating successful save
            MessageBox.Show("Itinerary saved successfully!");
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Change format as needed
                return ms.ToArray();
            }
        }

        private void SaveItineraryToDB(string SrNo, string ItineraryName, string DayNo, string Activity, string StartDT, string EndDT, byte[] imageData)
        {
            string connectionString = "ttmsDBConnectionString";

            string query = "INSERT INTO TourItinerary (ItineraryId, SrNo, ItineraryName, DayNumber, Activities, StartDateTime, EndDateTime, ItineraryImg, DestinationId) VALUES (@ItineraryId, @SrNo, @ItineraryName, @DayNumber, @Activities, @StartDateTime, @EndDateTime, @ItineraryImg, @DestinationId)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@SrNo", SrNo);
                    command.Parameters.AddWithValue("@ItineraryName", ItineraryName);
                    command.Parameters.AddWithValue("@DayNumber", DayNo);
                    command.Parameters.AddWithValue("@Activities", Activity);
                    command.Parameters.AddWithValue("@StartDateTime", StartDT);
                    command.Parameters.AddWithValue("@EndDateTime", EndDT);
                    command.Parameters.AddWithValue("@ItineraryImg", imageData);
                    command.Parameters.AddWithValue("@DestinationId", lblDestinationId.Text);

                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
        }

        private void DeleteDataForItinerary()
        {
            try
            {
                string query = @"DELETE FROM TourItinerary WHERE DestinationId = @DestinationId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@ItineraryId", lblDestinationId.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Destination Deleted Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #endregion
        private void dgvTourItinerary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string imageLoc = "";
            int clmActionIndex = dgvTourItinerary.Columns["clmAction"].Index;
            try
            {
                if(e.ColumnIndex == clmActionIndex && e.RowIndex >= 0)
                {
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        imageLoc = dialog.FileName;
                        //clmImage = imageLoc;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void dgvTourItinerary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        if(e.ColumnIndex == dgvTourItinerary.Columns["clmItineraryName"].Index && e.RowIndex >= 0)
        //        {
        //            string name = dgvTourDestination.Rows[e.RowIndex].Cells["clmFirstname"].Value.ToString();
        //            MessageBox.Show($"{name}");
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show($"Error {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        #region Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(DestinationId) FROM TourDestinations");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    lblDestinationId.Text = (a + 1).ToString();
                }
                else
                {
                    lblDestinationId.Text = "1";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertDataForDestination();
            SelectDataForDestination();
            ItineraryDataSave();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDataForDestination();
            SelectDataForDestination();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDataForDestination();
            SelectDataForDestination();
            DeleteDataForItinerary();
            
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    ImgDestination.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddItinerary_Click(object sender, EventArgs e)
        {
            dgvTourItinerary.Rows.Add();
        }

        private void btnDeleteItinerary_Click(object sender, EventArgs e)
        {
            if (dgvTourItinerary.Rows.Count > 0)
            {
                int lastIndex = dgvTourItinerary.Rows.Count - 1;
                dgvTourItinerary.Rows.RemoveAt(lastIndex);
            }
        }

        #endregion

        #region Events

        #endregion
    }
}
