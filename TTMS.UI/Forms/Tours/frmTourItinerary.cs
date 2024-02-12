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

namespace TTMS.UI.Tours
{
    public partial class frmTourItinerary : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;


        DataSet ds = new DataSet();
        public frmTourItinerary()
        {
            InitializeComponent();
        }

        private void TourItinerary_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False";

            SelectData();
        }

        #region Functions

        private void SelectData()
        {
            cmd = new SqlCommand("SELECT * FROM TourItinerary", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "TourItinerary");

            dgvTourItinerary.DataSource = ds.Tables["TourItinerary"];
        }

        //private bool isvalidate()
        //{

        //    if (lblItineraryId.Text != "")
        //    {
        //        return false;
        //    }
        //    else if (tbDestination.Text != "")
        //    {
        //        return false;
        //    }
        //    else if (tbDayNumber.Text != "")
        //    {
        //        return false;
        //    }
        //    else if (tbActivity.Text != "")
        //    {
        //        return false;
        //    }

        //    //else if (dtpStart.Value >= dtpEnd.Value)
        //    //{
        //    //    return false;
        //    //}

        //    return true;
        //}

        private byte[] getImage() //to save the image
        {
            MemoryStream stream = new MemoryStream();
            ImgItinerary.Image.Save(stream, ImgItinerary.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void InsertData()
        {
            //if (isvalidate())
            //{
                try
                {

                    string query = @"INSERT INTO TourItinerary (ItineraryId, DestinationId, DayNumber, Activities, StartDateTime, EndDateTime, ItineraryImg)VALUES (@ItineraryId, @DestinationId, @DayNumber, @Activities, @StartDateTime, @EndDateTime, @ItineraryImg)";

                    SqlCommand command = new SqlCommand(query, con);

                    command.Parameters.AddWithValue("@ItineraryId", lblItineraryId.Text);
                    command.Parameters.AddWithValue("@DestinationId", tbDestination.Text);
                    command.Parameters.AddWithValue("@DayNumber", tbDayNumber.Text);
                    command.Parameters.AddWithValue("@Activities", tbActivity.Text);
                    command.Parameters.AddWithValue("@StartDateTime", dtpStart.Value);
                    command.Parameters.AddWithValue("@EndDateTime", dtpEnd.Value);
                    command.Parameters.AddWithValue("@ItineraryImg", getImage());

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("New Itinerary Saved Successfully");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            
            //else
            //{
            //    MessageBox.Show("Please Enter All the Fields......", "Registeration Failed!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void UpdateData()
        {
            try
            {
                string query = @"UPDATE TourItinerary SET DestinationId=@DestinationId, DayNumber=@DayNumber, Activities=@Activities, StartDateTime=@StartDateTime, EndDateTime=@EndDateTime, ItineraryImg=@ItineraryImg WHERE ItineraryId=@ItineraryId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@ItineraryId", lblItineraryId.Text);
                command.Parameters.AddWithValue("@DestinationId", tbDestination.Text);
                command.Parameters.AddWithValue("@DayNumber", tbDayNumber.Text);
                command.Parameters.AddWithValue("@Activities", tbActivity.Text);
                command.Parameters.AddWithValue("@StartDateTime", dtpStart.Text);
                command.Parameters.AddWithValue("@EndDateTime", panel.Text);
                command.Parameters.AddWithValue("@ItineraryImg", getImage());

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Itinerary updated Successfully");
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
                string query = @"DELETE FROM TourItinerary WHERE ItineraryId = @ItineraryId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@ItineraryId", lblItineraryId.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Itinerary Deleted Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dgvTourItinerary_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTourItinerary.Rows[e.RowIndex];
                lblItineraryId.Text = row.Cells[0].Value.ToString();
            }
        }
        #endregion

        #region Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(ItineraryId) FROM TourItinerary");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    lblItineraryId.Text = (a + 1).ToString();
                }
                else
                {
                    lblItineraryId.Text = "1";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertData();
            SelectData();
            lblItineraryId.Text = "";
            tbDestination.Text = "";
            tbDayNumber.Text = "";
            tbActivity.Text = "";
            ImgItinerary.Image = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
            SelectData();

            lblItineraryId.Text = "";
            tbDestination.Text = "";
            tbDayNumber.Text = "";
            tbActivity.Text = "";
            ImgItinerary.Image = null;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            SelectData();
            lblItineraryId.Text = "";
            tbDestination.Text = "";
            tbDayNumber.Text = "";
            tbActivity.Text = "";
            ImgItinerary.Image = null;
            btnAdd.Focus();
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
                    ImgItinerary.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        
    }
}
