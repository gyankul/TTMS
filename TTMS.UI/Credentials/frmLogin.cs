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
        #region Login Button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "";
                sqlStr = "Select * from SignupDetails where Username='" + txtUsername.Text + "'and Password='" + txtPassword.Text + "'";

                con.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, con);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    frmMainForm main = new frmMainForm();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        #endregion


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


        #region Buttons
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
