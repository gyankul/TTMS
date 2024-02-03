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

namespace TTMS.UI.Forms.Payments
{
    public partial class frmPaymentStatus : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;

        DataSet ds = new DataSet();

        public frmPaymentStatus()
        {
            InitializeComponent();
        }

        private void frmPaymentStatus_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False";

            SelectData();
        }

        #region Functions

        private void SelectData()
        {
            cmd = new SqlCommand("SELECT * FROM PaymentStatus", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "PaymentStatus");

            dgvStaffTypes.DataSource = ds.Tables["PaymentStatus"];
        }
        private void InsertData()
        {
            try
            {
                string query = @"INSERT INTO PaymentStatus (PaymentStatusId, StatusName)VALUES (@PaymentStatusId, @StatusName)";


                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@PaymentStatusId", tbStatusTypeId.Text);
                command.Parameters.AddWithValue("@StatusName", tbStatusTypeName.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Payment Status Type Detail is Saved Successfully");
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
                string query = @"DELETE FROM PaymentStatus WHERE PaymentStatusId = @PaymentStatusId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@PaymentStatusId", tbStatusTypeId.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Payment Status Type is Deleted Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region Buttons
        private void btnADD_Click(object sender, EventArgs e)
        {
            tbStatusTypeId.Focus();
            tbStatusTypeName.Text = "";

            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(PaymentStatusId) FROM PaymentStatus");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    tbStatusTypeId.Text = (a + 1).ToString();
                }
                else
                {
                    tbStatusTypeId.Text = "1";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SelectData();
            DeleteData();
            tbStatusTypeId.Text = "";
            tbStatusTypeName.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertData();
            SelectData();
            tbStatusTypeId.Text = "";
            tbStatusTypeName.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbStatusTypeId.Text = "";
            tbStatusTypeName.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
