using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace TTMS.UI
{
    public partial class frmForgotPassword : Form
    {
        //SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;
        //SqlConnection con;
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False";

        DataSet ds = new DataSet();
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        #region Function

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtFPUsername;

            //con.SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True");
        }

            #region Forgot Password Functions

                private void ForgotPasswordSearchUsername()
                {

                    // SQL query to retrieve security question based on username
                    string query = "SELECT SecurityQuestion FROM SignupDetails WHERE Username = @Username";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Add username as parameter to prevent SQL injection
                                command.Parameters.AddWithValue("@Username", txtFPUsername.Text);

                                // Execute the query
                                object result = command.ExecuteScalar();

                                if (result != null)
                                {
                                    // Security question found
                                    string securityQuestion = result.ToString();
                                    txtFPSecurityQuestion.Text = securityQuestion;
                                }
                                else
                                {
                                    // Username not found
                                    MessageBox.Show("Username not found. Please check and try again.");
                                    txtFPUsername.Text = "";
                                    txtFPSecurityQuestion.Text = "";
                                    txtFPAnswer.Text = "";
                                    txtFPAnswer.Text = "";
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        txtFPUsername.Text = "";
                        txtFPSecurityQuestion.Text = "";
                        txtFPAnswer.Text = "";
                        txtFPAnswer.Text = "";
                    }
                }

                private void ForgotPasswordSearchAnswer()
                {
                    // SQL query to retrieve security question based on username
                    string query = "SELECT Password FROM SignupDetails WHERE SecurityAnswer = @SecurityAnswer";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                // Add username as parameter to prevent SQL injection
                                command.Parameters.AddWithValue("@SecurityAnswer", txtFPAnswer.Text);

                                // Execute the query
                                object result = command.ExecuteScalar();

                                if (result != null)
                                {
                                    // Security question found
                                    string password = result.ToString();
                                    txtFPPassword.Text = password;
                                }
                                else
                                {
                                    // Username not found
                                    MessageBox.Show("Username not found. Please check and try again.");
                                    txtFPUsername.Text = "";
                                    txtFPSecurityQuestion.Text = "";
                                    txtFPAnswer.Text = "";
                                    txtFPAnswer.Text = "";
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                        txtFPUsername.Text = "";
                        txtFPSecurityQuestion.Text = "";
                        txtFPAnswer.Text = "";
                        txtFPAnswer.Text = "";
                    }
                }
    

            #endregion

            #region Change Password Functions

            private void txtNewPassword_TextChanged(object sender, EventArgs e)
            {
                UpdatePasswordMatchStatus();
            }
            private void txtCnfPassword_TextChanged(object sender, EventArgs e)
            {
                UpdatePasswordMatchStatus();
            }
            private void UpdatePasswordMatchStatus()
            {
                string password = txtNewPassword.Text;
                string confirmPassword = txtCnfPassword.Text;

                if (password == confirmPassword && !string.IsNullOrEmpty(password))
                {
                    cpbConfirmPassword.Image = Properties.Resources.tick;

                }
                else
                {
                    cpbConfirmPassword.Image = Properties.Resources.cross;
                }
            }

            private void ChangePasswordSearchUsername()
        {
            // SQL query to retrieve security question based on username
            string query = "SELECT SecurityQuestion FROM SignupDetails WHERE Username = @Username";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add username as parameter to prevent SQL injection
                        command.Parameters.AddWithValue("@Username", txtCPUsername.Text);

                        // Execute the query
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            // Security question found
                            string securityQuestion = result.ToString();
                            lblSecurityQuestion.Text = securityQuestion;
                        }
                        else
                        {
                            // Username not found
                            MessageBox.Show("Username not found. Please check and try again.");
                            txtCPUsername.Text = "";
                            lblSecurityQuestion.Text = lblSecurityQuestion.Text;
                            txtNewPassword.Text = "";
                            txtCnfPassword.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                txtFPUsername.Text = "";
                txtFPSecurityQuestion.Text = "";
                txtFPAnswer.Text = "";
                txtFPAnswer.Text = "";
            }
        }

            private void ChangePasswordSearchAnswer()
        {

            // SQL query to retrieve security question based on username
            string query = "SELECT SecurityAnswer, Password FROM SignupDetails WHERE Username = @Username";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add username as parameter to prevent SQL injection
                        command.Parameters.AddWithValue("@Username", txtCPUsername.Text);

                        // Execute the query
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            // Retrieve the stored answer from the database
                            string storedAnswer = reader["SecurityAnswer"].ToString();

                            if (txtCPAnswer.Text.Equals(storedAnswer, StringComparison.OrdinalIgnoreCase))
                            {
                                panelCreateNewPassword.Visible = true;
                                panelConfirmPassword.Visible = true;
                                lblCreateNewPassword.Visible = true;
                                lblConfirmPassword.Visible = true;
                                txtNewPassword.Visible = true;
                                txtCnfPassword.Visible = true;
                            }
                        }
                        else
                        {
                            // Username not found
                            Console.WriteLine("Wrong Answer. Please try again.");
                            txtNewPassword.Visible = false;
                            txtCnfPassword.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

            private void ChangePassword()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Update the password in the database
                string updateQuery = "UPDATE SignupDetails SET Password = @NewPassword WHERE Username = @Username";
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    // Add parameters for the new password and username
                    updateCommand.Parameters.AddWithValue("@NewPassword", txtNewPassword.Text);
                    updateCommand.Parameters.AddWithValue("@Username", txtCPUsername.Text);

                    // Execute the update query
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    // Check if update was successful
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password.");
                    }
                }
            }
        }

            #endregion

        #endregion

        #region Buttons

            private void btnFPSearchUserName_Click(object sender, EventArgs e)
            {
                ForgotPasswordSearchUsername();
            }

            private void btnFPSearchAnswer_Click(object sender, EventArgs e)
            {
                ForgotPasswordSearchAnswer();
            }

            private void btnCPSearchUsername_Click(object sender, EventArgs e)
            {
                ChangePasswordSearchUsername();
            }

            private void btnBack_Click(object sender, EventArgs e)
            {
                this.Hide();
                new frmLogin().Show();
            }

            private void btnChangePass_Click(object sender, EventArgs e)
            {
                ChangePassword();
            }

            private void btnClose_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

        #endregion

        #region Key Events

            #region Forgot Password Events

                private void txtFPUsername_KeyDown(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        ForgotPasswordSearchUsername();
                        txtFPAnswer.Focus();
                    }
                }

                private void txtFPAnswer_KeyDown(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        ForgotPasswordSearchAnswer();
                        btnBack.Focus();
                    }
                }

        #endregion

            #region Change Password Events

                private void txtCPUsername_KeyDown(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        ChangePasswordSearchUsername();
                        txtCPAnswer.Focus();
                    }
                }
                private void txtCPAnswer_KeyDown(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        ChangePasswordSearchAnswer();
                        txtNewPassword.Focus();
                    }
                }
                private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        txtCnfPassword.Focus();
                    }
                }

                private void txtCnfPassword_KeyDown(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        btnChangePassword.Focus();
                    }
                }

        #endregion

        #endregion

    }
}
