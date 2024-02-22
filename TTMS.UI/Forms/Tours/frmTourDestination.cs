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
    public partial class frmTourDestination : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        public frmTourDestination()
        {
            InitializeComponent();
        }



        private void frmTourDestination_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourDataSet.TourPackages' table. You can move, or remove it, as needed.
            this.tourPackagesTableAdapter.Fill(this.tourDataSet.TourPackages);

            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False";

            SelectData();
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

            dgvTourItinerary.DataSource = ds.Tables["TourDestinations"];
        }

        private byte[] getImage() //to save the image
        {
            MemoryStream stream = new MemoryStream();
            ImgDestination.Image.Save(stream, ImgDestination.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void InsertData()
        {

            try
            {

                string query = @"INSERT INTO TourDestinations (DestinationId, DestinationName, SrNo, Description, DestinationImg, PackageId)VALUES (@DestinationId, @DestinationName, @SrNo, @Description, @DestinationImg, @PackageId)";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@DestinationId", tbDestinationId.Text);
                command.Parameters.AddWithValue("@DestinationName", tbDestinationName.Text);
                command.Parameters.AddWithValue("@SrNo", tbSrNo.Text);
                command.Parameters.AddWithValue("@Description", tbDestinationDescription.Text);
                command.Parameters.AddWithValue("@DestinationImg", getImage());
                command.Parameters.AddWithValue("@PackageId", cbPackage.SelectedValue);
                

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

        private void UpdateData()
        {
            try
            {
                string query = @"UPDATE TourDestinations SET DestinationName=@DestinationName, SrNo=@SrNo, Description=@Description, DestinationImg=@DestinationImg, PackageId=@PackageId WHERE DestinationId=@DestinationId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@DestinationId", tbDestinationId.Text);
                command.Parameters.AddWithValue("@DestinationName", tbDestinationName.Text);
                command.Parameters.AddWithValue("@SrNo", tbSrNo.Text);
                command.Parameters.AddWithValue("@Description", tbDestinationDescription.Text);
                command.Parameters.AddWithValue("@DestinationImg", getImage());
                command.Parameters.AddWithValue("@PackageId", cbPackage.SelectedValue);

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

                command.Parameters.AddWithValue("@DestinationId", tbDestinationId.Text);

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
            tbDestinationId.Text = "";
            tbDestinationName.Text = "";
            tbDestinationDescription.Text = "";
            tbSrNo.Text = "";
            cbPackage.DisplayMember = "- SELECT -";
            ImgDestination.Image = null;

            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(DestinationId) FROM TourDestinations");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    tbDestinationId.Text = (a + 1).ToString();
                }
                else
                {
                    tbDestinationId.Text = "1";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertData();
            SelectData();
            tbDestinationId.Text = "";
            tbDestinationName.Text = "";
            tbDestinationDescription.Text = "";
            tbSrNo.Text = "";
            cbPackage.DisplayMember = "- SELECT -";
            ImgDestination.Image = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
            SelectData();

            tbDestinationId.Text = "";
            tbDestinationName.Text = "";
            tbDestinationDescription.Text = "";
            tbSrNo.Text = "";
            cbPackage.DisplayMember = "- SELECT -";
            ImgDestination.Image = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            SelectData();

            tbDestinationId.Text = "";
            tbDestinationName.Text = "";
            tbDestinationDescription.Text = "";
            tbSrNo.Text = "";
            cbPackage.DisplayMember = "- SELECT -";
            ImgDestination.Image = null;
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
    }
}
