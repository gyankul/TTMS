using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TTMS.UI
{
    public partial class frmSignup : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;

        DataSet ds = new DataSet();
        public frmSignup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'signupDetail.StaffTypes' table. You can move, or remove it, as needed.
            this.staffTypesTableAdapter.Fill(this.signupDetail.StaffTypes);
            // TODO: This line of code loads data into the 'signupDetail.VerificationDetails' table. You can move, or remove it, as needed.
            this.verificationDetailsTableAdapter.Fill(this.signupDetail.VerificationDetails);
            // TODO: This line of code loads data into the 'verificationDetailsDataSet.VerificationDetails' table. You can move, or remove it, as needed.
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True";

            ActiveControl = cbStaffType;
        }

        #region Functions

        #region Functions for User Info
        private void SelectDataForUserInfo()
        {
            cmd = new SqlCommand("SELECT * FROM SignupDetails", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "SignupDetails");
        }

        private void InsertDataForUserInfo()
        {
            // for user info
            try
            {
                string query = @"INSERT INTO SignupDetails (UserId, StaffTypeId, Username, Password, SecurityQuestion, SecurityAnswer, UserImage)VALUES (@UserId, @StaffTypeId, @Username, @Password, @SecurityQuestion, @SecurityAnswer, @UserImage)";

                
                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@UserId", lblUserInfoID.Text);
                command.Parameters.AddWithValue("@StaffTypeId", cbStaffType.SelectedValue);
                command.Parameters.AddWithValue("@Username", tbUsername.Text);
                command.Parameters.AddWithValue("@Password", tbPassword.Text);
                command.Parameters.AddWithValue("@SecurityQuestion", cbSecurityQuestion.Text);
                command.Parameters.AddWithValue("@SecurityAnswer", tbSecurityAnswer.Text);
                command.Parameters.AddWithValue("@UserImage", getImageforUser());
                

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New User's Signup Details are Saved Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private byte[] getImageforUser()
        {
            MemoryStream stream = new MemoryStream();
            cpbUserImage.Image.Save(stream, cpbUserImage.Image.RawFormat);
            return stream.GetBuffer();

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            UpdatePasswordMatchStatus();
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            UpdatePasswordMatchStatus();
        }

        private void UpdatePasswordMatchStatus()
        {
            string password = tbPassword.Text;
            string confirmPassword = tbConfirmPassword.Text;

            if (password == confirmPassword && !string.IsNullOrEmpty(password))
            {
                cpbConfirmPassword.Image = Properties.Resources.icons8_tick_30__1_;

            }
            else
            {
                cpbConfirmPassword.Image = Properties.Resources.icons8_railroad_crossing_30;
            }
        }
        #endregion

        #region Function for Personal Info
        private void SelectDataForPersonalInfo()
        {
            cmd = new SqlCommand("SELECT * FROM UserPersonalInfo", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "UserPersonalInfo");
        }

        private void InsertDataForPersonalInfo()
        {
            // for personal info
            try
            {
                string query = @"INSERT INTO UserPersonalInfo (Id, Name, DOB, Gender, PhoneNo, Email, VerificationId, VerificationImg)VALUES (@Id, @Name, @DOB, @Gender, @PhoneNo, @Email, @VerificationId, @VerificationImg)";


                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@Id", lblPersonalInfoID.Text);
                command.Parameters.AddWithValue("@Name", tbName.Text);
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
                command.Parameters.AddWithValue("@PhoneNo", tbPhoneNo.Text);
                command.Parameters.AddWithValue("@Email", tbEmail.Text);
                command.Parameters.AddWithValue("@VerificationId", cbVerificationType.SelectedValue);
                command.Parameters.AddWithValue("@VerificationImg", getImageforVerification());


                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New User's Info Details are Saved Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private byte[] getImageforVerification()
        {
            MemoryStream stream = new MemoryStream();
            pbVerificationImg.Image.Save(stream, pbVerificationImg.Image.RawFormat);
            return stream.GetBuffer();

        }

        #endregion

        #endregion

        #region Buttons
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
                    cpbUserImage.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddVerificationImg_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pbVerificationImg.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            InsertDataForUserInfo();
            SelectDataForUserInfo();
            InsertDataForPersonalInfo();
            SelectDataForPersonalInfo();
            this.Close();
            new frmLogin().Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        #endregion

        #region Key Events

        private void cbStaffType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbUsername.Focus();
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbName.Focus();
            }
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPassword.Focus();
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbConfirmPassword.Focus();
            }
        }

        private void tbConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbSecurityQuestion.Focus();
            }
        }

        private void cbSecurityQuestion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbSecurityAnswer.Focus();
            }
        }

        private void tbSecurityAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddImg.Focus();
            }
        }




        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AutoIncrement inc = new AutoIncrement();
            AutoIncrement incre = new AutoIncrement();

            int a, b;
            inc.increment("SELECT max(Id) FROM UserPersonalInfo");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    lblPersonalInfoID.Text = (a + 1).ToString();
                }
                else
                {
                    lblPersonalInfoID.Text = "1";
                }
            }
            incre.increment("SELECT max(UserId) FROM SignupDetails");
            if (incre.dr.Read())
            {
                if (incre.dr[0] != System.DBNull.Value)
                {
                    b = Convert.ToInt32(incre.dr[0].ToString());
                    lblUserInfoID.Text = (b + 1).ToString();
                }
                else
                {
                    lblUserInfoID.Text = "1";
                }
            }
        }
    }
}
