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
    public partial class formTourPackages : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;


        DataSet ds = new DataSet();



        public formTourPackages()
        {
            InitializeComponent();
        }
        private void frmTourPackages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'packageDataSet.TourDestinations' table. You can move, or remove it, as needed.
            this.tourDestinationsTableAdapter.Fill(this.packageDataSet.TourDestinations);
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False";

            SelectDataForpackage();
            DestinationDataSave();
        }
        #region Functions

        #region Functions for Package

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

        private void SelectDataForpackage()
        {
            cmd = new SqlCommand("SELECT * FROM TourPackages", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "TourPackages");

            dgvTourPackage.DataSource = ds.Tables["TourPackages"];
        }

        private void InsertDataForPackage()
        {
            if (isvalidate())
            {
                try
                {

                    string query = @"INSERT INTO TourPackages (PackageId, PackageName, Description, PackageImage, Seats, Price)VALUES (@PackageId, @PackageName, @Description, @PackageImage, @Seats, @Price)";

                    SqlCommand command = new SqlCommand(query, con);

                    command.Parameters.AddWithValue("@PackageId", lblPackageId.Text);
                    command.Parameters.AddWithValue("@PackageName", tbPackageName.Text);
                    command.Parameters.AddWithValue("@Description", tbPackageDesc.Text);
                    command.Parameters.AddWithValue("@PackageImage", getImage());
                    command.Parameters.AddWithValue("@Seats", tbTotalSeats.Text);
                    command.Parameters.AddWithValue("@Price", lblPrice.Text);
                    command.Parameters.AddWithValue("@Price", tbPrice.Text);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("New Package Saved Successfully");
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
        private byte[] getImage() //to save the image
        {
            MemoryStream stream = new MemoryStream();
            pbPackageImg.Image.Save(stream, pbPackageImg.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void UpdateDataForPackage()
        {
            try
            {
                string query = @"UPDATE TourPackages SET PackageName=@PackageName, Description=@Description, PackageImage=@PackageImage, Seats=@Seats, Price=@Price WHERE PackageId=@PackageId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@PackageId", lblPackageId.Text);
                command.Parameters.AddWithValue("@PackageName", tbPackageName.Text);
                command.Parameters.AddWithValue("@Description", tbPackageDesc.Text);
                command.Parameters.AddWithValue("@PackageImage", getImage());
                command.Parameters.AddWithValue("@Seats", tbTotalSeats.Text);
                command.Parameters.AddWithValue("@Price", lblPrice.Text);
                command.Parameters.AddWithValue("@Price", tbPrice.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Package updated Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void DeleteDataForPackage()
        {
            try
            {
                string query = @"DELETE FROM TourPackages WHERE PackageId = @PackageId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@PackageId", lblPackageId.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Package Deleted Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        #endregion

        #region Functions for Destination

        private void DestinationDataSave()
        {
            foreach (DataGridViewRow row in dgvDestination.Rows)
            {
                // Check if the row is not empty
                if (!row.IsNewRow)
                {
                    // Extract data from DataGridView cells
                    string DestNo = row.Cells["clmDestNo"].Value.ToString();
                    string DestinationId = row.Cells["clmDestName"].Selected.ToString();

                    SaveDestinationToDB(DestNo, DestinationId);
                }
            }

            // Optionally, show a message indicating successful save
            MessageBox.Show("Itinerary saved successfully!");
        }

        private void SaveDestinationToDB(string DestNo, string DestinationId)
        {
            string connectionString = "ttmsDBConnectionString";

            string query = "INSERT INTO TourPackage (DestinationNo, DestinationId) VALUES (@DestinationNo, @DestinationId)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command

                    command.Parameters.AddWithValue("@DestinationId", DestNo);
                    command.Parameters.AddWithValue("@DestinationId",DestinationId);

                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #endregion


        #region Buttons

        private void lblCreateDestination_Click(object sender, EventArgs e)
        {
            formTourDestinations td = new formTourDestinations();
            td.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblPackageId.Text = "";
            tbPackageName.Text = "";
            tbPackageDesc.Text = "";
            pbPackageImg.Image = null;
            tbTotalSeats.Text = "";
            lblPrice.Text = "";
            tbPrice.Text = "";

            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(PackageId) FROM TourPackages");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    lblPackageId.Text = (a + 1).ToString();
                }
                else
                {
                    lblPackageId.Text = "1";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertDataForPackage();
            SelectDataForpackage();
            DestinationDataSave();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDataForPackage();
            SelectDataForpackage();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDataForPackage();
            SelectDataForpackage();
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
                    pbPackageImg.ImageLocation = imageLocation;
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

        private void btnAddItinerary_Click(object sender, EventArgs e)
        {
            dgvDestination.Rows.Add();
        }

        private void btnDeleteItinerary_Click(object sender, EventArgs e)
        {
            if (dgvDestination.Rows.Count > 0)
            {
                int lastIndex = dgvDestination.Rows.Count - 1;
                dgvDestination.Rows.RemoveAt(lastIndex);
            }
        }

       
    }
}
