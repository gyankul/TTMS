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

namespace TTMS.UI.Forms.Credentials
{
    public partial class frmVerificationType : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        public frmVerificationType()
        {
            InitializeComponent();
        }

        private void frmVerificationType_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False";

            SelectData();
        }

        private void SelectData()
        {
            cmd = new SqlCommand("SELECT * FROM VerificationDetails", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "VerificationDetails");

            dgvVerificationdetails.DataSource = ds.Tables["VerificationDetails"];
        }
        private void InsertData()
        {
            try
            {
                string query = @"INSERT INTO VerificationDetails (VerificationId, VerificationName)VALUES (@VerificationId, @VerificationName)";


                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@VerificationId", tbVerificationId.Text);
                command.Parameters.AddWithValue("@VerificationName", tbVerificationName.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Verification Type Detail is Saved Successfully");
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
                string query = @"DELETE FROM VerificationDetails WHERE VerificationId = @VerificationId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@VerificationId", tbVerificationId.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Verification Type is Deleted Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            tbVerificationId.Focus();
            tbVerificationName.Text = "";

            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(VerificationId) FROM VerificationDetails");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    tbVerificationId.Text = (a + 1).ToString();
                }
                else
                {
                    tbVerificationName.Text = "1";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            SelectData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertData();
            SelectData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
