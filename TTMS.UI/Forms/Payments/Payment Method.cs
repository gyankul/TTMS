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
    public partial class Payment_Method : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;

        DataSet ds = new DataSet();
        public Payment_Method()
        {
            InitializeComponent();
        }
        private void Payment_Method_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False";

            SelectData();
        }

        #region Functions

        private void SelectData()
        {
            cmd = new SqlCommand("SELECT * FROM PaymentMethod", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "PaymentMethod");

            dgvPaymentMethodTypes.DataSource = ds.Tables["PaymentMethod"];
        }
        private void InsertData()
        {
            try
            {
                string query = @"INSERT INTO PaymentMethod (PaymentMethodId, MethodName)VALUES (@PaymentMethodId, @MethodName)";


                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@PaymentMethodId", tbMethodTypeId.Text);
                command.Parameters.AddWithValue("@MethodName", tbMethodTypeName.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Payment Method Type Detail is Saved Successfully");
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
                string query = @"DELETE FROM PaymentMethod WHERE PaymentMethodId = @PaymentMethodId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@PaymentMethodId", tbMethodTypeId.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Payment Method Type is Deleted Successfully");
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
            tbMethodTypeId.Focus();
            tbMethodTypeName.Text = "";

            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(PaymentStatusId) FROM PaymentStatus");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    tbMethodTypeId.Text = (a + 1).ToString();
                }
                else
                {
                    tbMethodTypeId.Text = "1";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SelectData();
            DeleteData();
            tbMethodTypeId.Text = "";
            tbMethodTypeName.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertData();
            SelectData();
            tbMethodTypeId.Text = "";
            tbMethodTypeName.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbMethodTypeId.Text = "";
            tbMethodTypeName.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
      
    }
}
