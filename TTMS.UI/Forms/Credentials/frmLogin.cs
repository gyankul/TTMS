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
using TTMS.UI.Forms.Dashboard;

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
                SqlDataAdapter da = new SqlDataAdapter();
                

                SqlCommand cmd = new SqlCommand(sqlStr, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable(sqlStr);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    global.username = dt.Rows[0]["Username"].ToString();
                }

                if (dr.Read())
                {
                    global.username = dt.Rows[0]["Username"].ToString();
                    frmMainForm main = new frmMainForm();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                con.Close();

                
                
              
                
                
               
                //con.Open();
                //SqlDataAdapter da = new SqlDataAdapter();
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                //if (dt.Rows.Count > 0)
                //{
                //    global.username = dt.Rows[0]["Username"].ToString();
                //}
                //con.Close();
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
