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


namespace TTMS.UI
{
    public partial class frmForgotPassword : Form
    {
        //SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;
        //SqlConnection con;

        DataSet ds = new DataSet();
        public frmForgotPassword()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True");
        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsername;
           
            //con.SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //con.Open();
            //    //cmd = new SqlCommand("SELECT Username FROM SignupDetails WHERE Username = '" + txtUsername + "'", con);
            //    //SqlDataReader reader;
            //    //reader = cmd.ExecuteReader();
            //    //while (reader.Read())
            //    //{
            //    //    txtSecurityQuestion.Text = reader.GetValue(3).ToString();
            //    //}
            //    //con.Close();
            //    string str = "";
            //    str = "SELECT * FROM SignupDetails WHERE Username='" + txtUsername + "'";
                

            //    con.Open();
            //    SqlCommand cmd = new SqlCommand(str, con);
            //    SqlDataReader dr = cmd.ExecuteReader();

            //    if(dr.Read())
            //    {
            //        txtSecurityQuestion.Text = dr.GetValue(3).ToString();
            //    }
            //    else{
            //        MessageBox.Show("Error");
            //    }
            //    con.Close();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            string searchTerm = txtUsername.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                string query = "SELECT * FROM SignupDetails WHERE Username = @Username";

                con.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, con))
                {
                    sqlCommand.Parameters.AddWithValue("@Username", searchTerm);

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string resultData = reader["SecurityQuestion"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No result found.");
                    }
                    reader.Close();
                }
                con.Close();

               
            }
            else
            {
                MessageBox.Show("Please enter valid username");
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
