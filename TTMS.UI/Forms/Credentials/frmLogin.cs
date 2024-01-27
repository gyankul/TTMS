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
using System.Configuration;


namespace TTMS.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True");

        #region Load Event

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsername;

            con.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from SignupDetails",con);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            sqlCommand.ExecuteNonQuery();
            con.Close();

            cbRole.Items.Add(new {Text = "-Select-",Value = -1});
            cbRole.DataSource = ds.Tables[0];
            cbRole.DisplayMember = "Role";

            cbRole.DisplayMember = Text;
            

        }

        #endregion

        #region KeyEvents

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e); ;
            }
        }

        #endregion

        #region Buttons

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "";

                string username = RetrieveUsernameFromDatabase();
                byte[] userImage = RetrieveUserImageFromDatabase();

                frmMainForm dashboardForm = new frmMainForm(username, userImage);

                sqlStr = "Select * from SignupDetails where Username='" + txtUsername.Text + "'and Password='" + txtPassword.Text + "'";

                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();


                SqlCommand cmd = new SqlCommand(sqlStr, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dashboardForm.Show();
                    
                }
                else
                {
                    MessageBox.Show("Wrong");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private string RetrieveUsernameFromDatabase()
        {
            string username = null;

            using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True"))
            {
                connection.Open();

                // Adjust the query based on your table structure and login criteria
                string query = "SELECT username FROM SignupDetails WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username",txtUsername.Text);
                    command.Parameters.AddWithValue("@Password", txtPassword.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            username = reader["Username"].ToString();
                        }
                    }
                }
            }

            return username;
        }

        private byte[] RetrieveUserImageFromDatabase()
        {
            byte[] userImage = null;

            using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True"))
            {
                connection.Open();

                // Adjust the query based on your table structure and login criteria
                string query = "SELECT UserImage FROM SignupDetails WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", txtUsername.Text);
                    command.Parameters.AddWithValue("@Password", txtPassword.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming the 'userimage' column is of type varbinary
                            userImage = (byte[])reader["UserImage"];
                        }
                    }
                }
            }

            return userImage;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmSignup().Show();
        }

        private void btnForgotpassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmForgotPassword().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Show and Hide Password
        private void btnShowpass_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '*')
            {
                btnHidepass.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHidepass_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '\0')
            {
                btnShowpass.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }
        #endregion

        
    }
}
