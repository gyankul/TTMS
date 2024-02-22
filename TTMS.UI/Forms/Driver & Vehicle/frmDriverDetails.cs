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

namespace TTMS.UI.Forms.Driver___Vehicle
{
    public partial class frmDriverDetails : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        public frmDriverDetails()
        {
            InitializeComponent();
        }

        #region Functions
        private void frmDriverDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'verificationDetailsDataSet.VerificationDetails' table. You can move, or remove it, as needed.
            this.verificationDetailsTableAdapter.Fill(this.verificationDetailsDataSet.VerificationDetails);
            con.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = ttmsDB; Integrated Security = True";

            SelectData();
            cbVerificationType.Text = "- SELECT -";
        }

        private void SelectData()
        {
            cmd = new SqlCommand("SELECT * FROM DriverDetails", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "DriverDetails");

            dgvDriverDetails.DataSource = ds.Tables["DriverDetails"];
        }

        private byte[] getImage() //to save the image
        {
            MemoryStream stream = new MemoryStream();
            ImgVerification.Image.Save(stream, ImgVerification.Image.RawFormat);
            return stream.GetBuffer();
        }

        private void InsertData()
        {
            //if (isvalidate())
            //{
            try
            {

                string query = @"INSERT INTO DriverDetails (DriverId, DriverName, DOB, Gender, ContactNo, Email, VerificationId, VerificationImage, Experience, JoiningDate)VALUES (@DriverId, @DriverName, @DOB, @Gender, @ContactNo, @Email, @VerificationId, @VerificationImage, @Experience, @JoiningDate)";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@DriverId",tbDriverId.Text);
                command.Parameters.AddWithValue("@DriverName", tbDriverName.Text);
                command.Parameters.AddWithValue("@DOB", dtpDOB.Value);
                if (rbMale.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Male");
                }
                else if (rbFemale.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Female");
                }
                else if (rbOther.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Other");
                }
                command.Parameters.AddWithValue("@ContactNo", tbPhoneNo.Text);
                command.Parameters.AddWithValue("@Email", tbEmail.Text);
                command.Parameters.AddWithValue("@VerificationId", cbVerificationType.SelectedValue);
                command.Parameters.AddWithValue("@VerificationImage", getImage());
                command.Parameters.AddWithValue("@Experience", cbExperience.SelectedItem);
                command.Parameters.AddWithValue("@JoiningDate", dtpDOJ.Value);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Driver Saved Successfully");
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
                string query = @"UPDATE DriverDetails SET DriverName=@DriverName, DriverName=@DriverName, DOB=@DOB, Gender=@Gender, ContactNo=@ContactNo, Email=@Email, VerificationId=@VerificationId, VerificationImage=@VerificationImage, Experience=@Experience, JoiningDate=@JoiningDate WHERE DriverId=@DriverId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@DriverId", tbDriverId.Text);
                command.Parameters.AddWithValue("@DriverName", tbDriverName.Text);
                command.Parameters.AddWithValue("@DOB", dtpDOB.Value);
                if (rbMale.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Male");
                }
                else if (rbFemale.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Female");
                }
                else if (rbOther.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Other");
                }
                command.Parameters.AddWithValue("@ContactNo", tbPhoneNo.Text);
                command.Parameters.AddWithValue("@Email", tbEmail.Text);
                command.Parameters.AddWithValue("@VerificationId", cbVerificationType.ValueMember);
                command.Parameters.AddWithValue("@VerificationImage", getImage());
                command.Parameters.AddWithValue("@Experience", cbExperience.SelectedItem);
                command.Parameters.AddWithValue("@JoiningDate", dtpDOJ.Value);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Driver Detail updated Successfully");
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
                string query = @"DELETE FROM DriverDetails WHERE DriverId = @DriverId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@ItineraryId", tbDriverId.Text);

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

        #endregion

        #region Buttons
        private void btnUploadImg_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    ImgVerification.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbDriverId.Text = "";
            tbDriverName.Text = "";
            dtpDOB.Value = DateTime.Now;
            tbPhoneNo.Text = "";
            tbEmail.Text = "";
            cbVerificationType.Text = "- SELECT -";
            cbExperience.DisplayMember  = null;
            dtpDOJ.Value = DateTime.Now;

            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(ItineraryId) FROM TourItinerary");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    tbDriverId.Text = (a + 1).ToString();
                }
                else
                {
                    tbDriverId.Text = "1";
                }
            }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Events

        private void tbDriverId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbDriverName.Focus();
            }
        }

        private void tbDriverName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbDriverName.Focus();
            }
        }

        private void dtpDOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbDriverName.Focus();
            }
        }

        private void rbMale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbDriverName.Focus();
            }
        }

        private void rbFemale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbDriverName.Focus();
            }
        }

        private void rbOther_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbDriverName.Focus();
            }
        }

        private void tbPhoneNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbDriverName.Focus();
            }
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbDriverName.Focus();
            }
        }

        private void cbVerificationType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbDriverName.Focus();
            }
        }

        private void btnUploadImg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbDriverName.Focus();
            }
        }

        private void cbExperience_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbDriverName.Focus();
            }
        }

        private void dtpDOJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbDriverName.Focus();
            }
        }
        #endregion

    }
}
