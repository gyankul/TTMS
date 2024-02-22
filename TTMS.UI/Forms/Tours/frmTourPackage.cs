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
    public partial class frmTourPackage : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        public frmTourPackage()
        {
            InitializeComponent();
        }


        private void frmTourPackage_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False";

            SelectData();
        }

        #region Functions
        private void SelectData()
        {
            cmd = new SqlCommand("SELECT * FROM TourPackages", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "TourPackages");

            dgvTourPackage.DataSource = ds.Tables["TourPackages"];
        }

        private byte[] getImage() //to save the image
        {
            MemoryStream stream = new MemoryStream();
            ImgPackage.Image.Save(stream, ImgPackage.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void InsertData()
        {

            try
            {

                string query = @"INSERT INTO TourPackages (PackageId, PackageName, TotalSeats, Duration, DepartureDate, Description, PackageImage)VALUES (@PackageId, @PackageName, @TotalSeats, @Duration, @DepartureDate, @Description, @PackageImage)";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@PackageId", tbPackageId.Text);
                command.Parameters.AddWithValue("@PackageName", tbPackageName.Text);
                command.Parameters.AddWithValue("@TotalSeats", tbSeats.Text);
                command.Parameters.AddWithValue("@Duration", tbDuration.Text);
                command.Parameters.AddWithValue("@DepartureDate", dtpDeparture.Value);
                command.Parameters.AddWithValue("@Description", tbPackageDescription.Text);
                command.Parameters.AddWithValue("@PackageImage", getImage());

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

        private void UpdateData()
        {
            try
            {
                string query = @"UPDATE TourPackages SET PackageName=@PackageName, TotalSeats=@TotalSeats, Duration=@Duration, DepartureDate=@DepartureDate, Description=@Description, PackageImage=@PackageImage WHERE PackageId=@PackageId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@PackageId", tbPackageId.Text);
                command.Parameters.AddWithValue("@PackageName", tbPackageName.Text);
                command.Parameters.AddWithValue("@TotalSeats", tbSeats.Text);
                command.Parameters.AddWithValue("@Duration", tbDuration.Text);
                command.Parameters.AddWithValue("@DepartureDate", dtpDeparture.Value);
                command.Parameters.AddWithValue("@Description", tbPackageDescription.Text);
                command.Parameters.AddWithValue("@PackageImage", getImage());

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

        private void DeleteData()
        {
            try
            {
                string query = @"DELETE FROM TourPackages WHERE PackageId = @PackageId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@PackageId", tbPackageId.Text);

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

        #region Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbPackageId.Text = "";
            tbPackageName.Text = "";
            tbSeats.Text = "";
            tbDuration.Text = "";
            dtpDeparture.Value = DateTime.Now;
            tbPackageDescription.Text = "";
            ImgPackage.Image = null;

            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(PackageId) FROM TourPackages");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    tbPackageId.Text = (a + 1).ToString();
                }
                else
                {
                    tbPackageId.Text = "1";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertData();
            SelectData();
            tbPackageId.Text = "";
            tbPackageName.Text = "";
            tbSeats.Text = "";
            tbDuration.Text = "";
            dtpDeparture.Value = DateTime.Now;
            tbPackageDescription.Text = "";
            ImgPackage.Image = null;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
            SelectData();
            tbPackageId.Text = "";
            tbPackageName.Text = "";
            tbSeats.Text = "";
            tbDuration.Text = "";
            dtpDeparture.Value = DateTime.Now;
            tbPackageDescription.Text = "";
            ImgPackage.Image = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            SelectData();
            tbPackageId.Text = "";
            tbPackageName.Text = "";
            tbSeats.Text = "";
            tbDuration.Text = "";
            dtpDeparture.Value = DateTime.Now;
            tbPackageDescription.Text = "";
            ImgPackage.Image = null;
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
                    ImgPackage.ImageLocation = imageLocation;
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
