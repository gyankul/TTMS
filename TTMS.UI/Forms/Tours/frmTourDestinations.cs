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
    public partial class frmTourDestinations : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;


        DataSet ds = new DataSet();

        public frmTourDestinations()
        {
            InitializeComponent();
        }

        #region Functions

        private void SelectData()
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

        private void InsertData()
        {
            if (isvalidate())
            {
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
            }
            else
            {
                MessageBox.Show("Please Enter All the Fields......", "Registeration Failed!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateData()
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

        private void DeleteData()
        {
            try
            {
                string query = @"DELETE FROM TourDestinations WHERE DestinationId = @DestinationId";

                SqlCommand command = new SqlCommand(query, con);

                //command.Parameters.AddWithValue("@ItineraryId", lblItineraryId.Text);

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

        #region Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertData();
            SelectData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
            SelectData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            SelectData();
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

        #endregion

        private void dgvTourItinerary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == dgvTourItinerary.Columns["clmItineraryName"].Index && e.RowIndex >= 0)
                {
                    string name = dgvTourDestination.Rows[e.RowIndex].Cells["clmFirstname"].Value.ToString();
                    MessageBox.Show($"{name}");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
