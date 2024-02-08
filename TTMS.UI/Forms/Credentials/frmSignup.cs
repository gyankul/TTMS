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
            // TODO: This line of code loads data into the 'ttmsDBDataSet.StaffTypes' table. You can move, or remove it, as needed.
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True";
            //this.ActiveControl = tbRole;
        }

        #region Functions
        private void SelectData()
        {
            cmd = new SqlCommand("SELECT * FROM SignupDetails", con);
        

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "SignupDetails");
        }
        private void InsertData()
        {
            try
            {
                string query = @"INSERT INTO SignupDetails (StaffTypeId, Username, Password, SecurityQuestion, SecurityAnswer, UserImage)VALUES (@StaffTypeId, @Username, @Password, @SecurityQuestion, @SecurityAnswer, @UserImage)";

                
                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@StaffTypeId", cbStaffType.Text);
                command.Parameters.AddWithValue("@Username", tbUsername.Text);
                command.Parameters.AddWithValue("@Password", tbPassword.Text);
                command.Parameters.AddWithValue("@SecurityQuestion", cbSecurityQuestion.Text);
                command.Parameters.AddWithValue("@SecurityAnswer", tbSecurityAnswer.Text);
                command.Parameters.AddWithValue("@UserImage", getImage());
                

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

        private byte[] getImage()
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
        private void btnCreate_Click(object sender, EventArgs e)
        {
            InsertData();
            SelectData();
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

        
    }
}
