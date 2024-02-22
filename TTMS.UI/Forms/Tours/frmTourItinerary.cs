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
            // TODO: This line of code loads data into the 'tourDataSet.TourDestinations' table. You can move, or remove it, as needed.
            this.tourDestinationsTableAdapter.Fill(this.tourDataSet.TourDestinations);
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

        private byte[] getImage() //to save the image
        {
            MemoryStream stream = new MemoryStream();
            ImgItinerary.Image.Save(stream, ImgItinerary.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void InsertData()
        {
            
                try
                {

                    string query = @"INSERT INTO TourItinerary (ItineraryId, SrNo, ItineraryName, DestinationId, DayNumber, Activities, StartDateTime, EndDateTime, ItineraryImg, Cost)VALUES (@ItineraryId, @SrNo, @ItineraryName, @DestinationId, @DayNumber, @Activities, @StartDateTime, @EndDateTime, @ItineraryImg, @Cost)";

                    SqlCommand command = new SqlCommand(query, con);

                    command.Parameters.AddWithValue("@ItineraryId", tbItineraryId.Text);
                    command.Parameters.AddWithValue("@SrNo", tbSRNO.Text);
                    command.Parameters.AddWithValue("@ItineraryName", tbItineraryName.Text);
                    command.Parameters.AddWithValue("@DestinationId", cbDestination.SelectedValue);
                    command.Parameters.AddWithValue("@DayNumber", tbDayNumber.Text);
                    command.Parameters.AddWithValue("@Activities", tbActivity.Text);
                    command.Parameters.AddWithValue("@StartDateTime", dtpStart.Value);
                    command.Parameters.AddWithValue("@EndDateTime", dtpEnd.Value);
                    command.Parameters.AddWithValue("@ItineraryImg", getImage());
                    command.Parameters.AddWithValue("@Cost", tbCost.Text);

                con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("New Itinerary Saved Successfully");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
        }

        private void UpdateData()
        {
            try
            {
                string query = @"UPDATE TourItinerary SET SrNo=@SrNo, ItineraryName=@ItineraryName, DestinationId=@DestinationId, DayNumber=@DayNumber, Activities=@Activities, StartDateTime=@StartDateTime, EndDateTime=@EndDateTime, ItineraryImg=@ItineraryImg, Cost=@Cost WHERE ItineraryId=@ItineraryId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@ItineraryId", tbItineraryId.Text);
                command.Parameters.AddWithValue("@SrNo", tbSRNO.Text);
                command.Parameters.AddWithValue("@ItineraryName", tbItineraryName.Text);
                command.Parameters.AddWithValue("@DestinationId", cbDestination.SelectedValue);
                command.Parameters.AddWithValue("@DayNumber", tbDayNumber.Text);
                command.Parameters.AddWithValue("@Activities", tbActivity.Text);
                command.Parameters.AddWithValue("@StartDateTime", dtpStart.Value);
                command.Parameters.AddWithValue("@EndDateTime", dtpEnd.Value);
                command.Parameters.AddWithValue("@ItineraryImg", getImage());
                command.Parameters.AddWithValue("@Cost", tbCost.Text);

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

                command.Parameters.AddWithValue("@ItineraryId", tbItineraryId.Text);

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
                tbItineraryId.Text = row.Cells[0].Value.ToString();
            }
        }
        #endregion

        #region Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbItineraryId.Text = "";
            cbDestination.DisplayMember = "- SELECT -";
            tbDayNumber.Text = "";
            tbActivity.Text = "";
            ImgItinerary.Image = null;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            tbCost.Text = "";

            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(ItineraryId) FROM TourItinerary");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    tbItineraryId.Text = (a + 1).ToString();
                }
                else
                {
                    tbItineraryId.Text = "1";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertData();
            SelectData();
            tbItineraryId.Text = "";
            tbItineraryNo.Text = "";
            tbItineraryName.Text = "";
            cbDestination.DisplayMember = "- SELECT -";
            tbDayNumber.Text = "";
            tbActivity.Text = "";
            ImgItinerary.Image = null;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            tbCost.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
            SelectData();

            tbItineraryId.Text = "";
            tbItineraryNo.Text = "";
            tbItineraryName.Text = "";
            cbDestination.DisplayMember = "- SELECT -";
            tbDayNumber.Text = "";
            tbActivity.Text = "";
            ImgItinerary.Image = null;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            tbCost.Text = "";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            SelectData();
            tbItineraryId.Text = "";
            tbItineraryNo.Text = "";
            tbItineraryName.Text = "";
            cbDestination.DisplayMember = "- SELECT -";
            tbDayNumber.Text = "";
            tbActivity.Text = "";
            ImgItinerary.Image = null;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            btnAdd.Focus();
            tbCost.Text = "";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
