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
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True";
            this.ActiveControl = tbRole;
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
                string query = @"INSERT INTO SignupDetails (Role, Username, Password, SecurityQuestion, SecurityAnswer)VALUES (@Role, @Username, @Password, @SecurityQuestion, @SecurityAnswer)";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@Role", tbRole.Text);
                command.Parameters.AddWithValue("@Username", tbUsername.Text);
                command.Parameters.AddWithValue("@Password", tbPassword.Text);
                command.Parameters.AddWithValue("@SecurityQuestion", cbSecurityQuestion.Text);
                command.Parameters.AddWithValue("@SecurityAnswer", tbSecurityAnswer.Text);

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
        #endregion

        #region Buttons
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
