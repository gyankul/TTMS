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
            // TODO: This line of code loads data into the 'ttmsDBDataSet.Destination' table. You can move, or remove it, as needed.
            this.destinationTableAdapter.Fill(this.ttmsDBDataSet.Destination);
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True";

            SelectData();
        }

        private void SelectData()
        {
            cmd = new SqlCommand("SELECT * FROM Package", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "Package");

            dgvTourPackage.DataSource = ds.Tables["Package"];
        }

        private void InsertData()
        {
            if (isvalidate())
            {
                try
                {
                    string query = @"INSERT INTO Package (PackageId, PackageName, PackageDescription, Duration, Price, PackageImg)VALUES (@PackageId, @PackageName, @PackageDescription, @Duration, @Price, @PackageImg)";

                    SqlCommand command = new SqlCommand(query, con);

                    command.Parameters.AddWithValue("@PackageId", tbPackageId.Text);
                    command.Parameters.AddWithValue("@PackageName", tbPackageName.Text);
                    command.Parameters.AddWithValue("@Duration", tbDuration.Text);
                    command.Parameters.AddWithValue("@Price", tbPrice.Text);
                    command.Parameters.AddWithValue("@PackageDescription", tbDescription.Text);
                    command.Parameters.AddWithValue("@PackageImg", getImage());

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("New Package Details Saved Successfully");
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

        private bool isvalidate()
        {
            if (tbPackageId.Text != " ")
            {
                return false;
            }
            else if (tbPackageName.Text != " ")
            {
                return false;
            }
            else if (tbDuration.Text != " ")
            {
                return false;
            }
            else if (tbPrice.Text != " ")
            {
                return false;
            }
            else if (tbDescription.Text != " ")
            {
                return false;
            }
            return true;
        }

        private byte[] getImage()
        {
            MemoryStream stream = new MemoryStream();
            pbTourPackage.Image.Save(stream, pbTourPackage.Image.RawFormat);
            return stream.GetBuffer();

        }

        private void DeleteData()
        {
            try
            {
                string query = @"DELETE FROM Package WHERE PackageId = @PackageId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@PackageId", tbPackageId.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Package Details Deleted Successfully");
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
                string query = @"UPDATE Package SET PackageName=@PackageName, PackageDescription=@PackageDescription, Duration=@Duration, Price=@Price, PackageImg=@PackageImg WHERE PackageId=@PackageId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@PackageId", tbPackageId.Text);
                command.Parameters.AddWithValue("@PackageName", tbPackageName.Text);
                command.Parameters.AddWithValue("@PackageDescription", tbDuration.Text);
                command.Parameters.AddWithValue("@Duration", tbPrice.Text);
                command.Parameters.AddWithValue("@Price", tbDescription.Text);
                command.Parameters.AddWithValue("@PackageImg",getImage());

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customer Details updated Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbPackageId.Focus();

            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(CustomerId) FROM CustomerDetails");
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
            tbDuration.Text = "";
            tbPrice.Text = "";
            tbDescription.Text = "";
            pbTourPackage.Image = null;
            btnAdd.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
            SelectData();

            tbPackageName.Text = "";
            tbDuration.Text = "";
            tbPrice.Text = "";
            tbDescription.Text = "";
            pbTourPackage.Image = null;
            btnAdd.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            SelectData();
            tbPackageId.Text = "";
            tbPackageName.Text = "";
            tbDuration.Text = "";
            tbPrice.Text = "";
            tbDescription.Text = "";
            pbTourPackage.Image = null;
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
                    pbTourPackage.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
