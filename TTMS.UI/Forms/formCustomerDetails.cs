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
    public partial class formCustomerDetails : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;
       

        DataSet ds = new DataSet();
        public formCustomerDetails()
        {
            InitializeComponent();


        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True";
            
            SelectData();

            btnAdd.PerformClick();

            this.KeyDown += frmCustomerDetails_KeyDown;

        }

        private void SelectData()
        {
            cmd = new SqlCommand("SELECT * FROM CustomerDetails", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "CustomerDetails");

            dgvCustomerDetails.DataSource = ds.Tables["CustomerDetails"];
        }

        private void InsertData()
        {
            if (isvalidate())
            {
                try
                {
                    string query = @"INSERT INTO CustomerDetails (CustomerId, CustomerName, CustomerAge, CustomerAddress, ContactInfo, Email)VALUES (@CustomerId, @CustomerName, @CustomerAge, @CustomerAddress, @ContactInfo, @Email)";

                    SqlCommand command = new SqlCommand(query, con);

                    command.Parameters.AddWithValue("@CustomerId", txtCustomerid.Text);
                    command.Parameters.AddWithValue("@CustomerName", txtCustomername.Text);
                    command.Parameters.AddWithValue("@CustomerAge", txtCustomerage.Text);
                    command.Parameters.AddWithValue("@CustomerAddress", txtCustomeraddress.Text);
                    command.Parameters.AddWithValue("@ContactInfo", txtContact.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);

                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Customer Details Saved Successfully");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Enter All the Fields......","Registeration Failed!!!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isvalidate()
        {
            if(txtCustomername.Text != " "){
                return false;
            }
            else if (txtCustomerage.Text != " ")
            {
                return false;
            }
            else if (txtEmail.Text != " ")
            {
                return false;
            }
            else if (txtContact.Text != " ")
            {
                return false;
            }
            else if (txtCustomeraddress.Text != " ")
            {
                return false;
            }
            return true;
        }

        private void DeleteData()
        {
            try
            {
                string query = @"DELETE FROM CustomerDetails WHERE CustomerId = @CustomerId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@CustomerId", txtCustomerid.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customer Details Deleted Successfully");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void UpdateData()
        {
            try
            {
                string query = @"UPDATE CustomerDetails SET CustomerName=@CustomerName, CustomerAge=@CustomerAge, CustomerAddress=@CustomerAddress, ContactInfo=@ContactInfo, Email=@Email WHERE CustomerId=@CustomerId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@CustomerId", txtCustomerid.Text);
                command.Parameters.AddWithValue("@CustomerName", txtCustomername.Text);
                command.Parameters.AddWithValue("@CustomerAge", txtCustomerage.Text);
                command.Parameters.AddWithValue("@CustomerAddress", txtCustomeraddress.Text);
                command.Parameters.AddWithValue("@ContactInfo", txtContact.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customer Details updated Successfully");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtCustomername.Focus();

            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(CustomerId) FROM CustomerDetails");
            if (inc.dr.Read())
            {
                if(inc.dr[0]!= System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    txtCustomerid.Text = (a + 1).ToString();
                }
                else
                {
                    txtCustomerid.Text = "1";
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            UpdateData();
            SelectData();

            txtCustomername.Text = "";
            txtCustomerage.Text = "";
            txtCustomeraddress.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            btnAdd.PerformClick();
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            SelectData();
            txtCustomerid.Text = "";
            txtCustomername.Text = "";
            txtCustomerage.Text = "";
            txtCustomeraddress.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            btnAdd.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertData();
            SelectData();
            txtCustomerid.Text = "";
            txtCustomername.Text = "";
            txtCustomerage.Text = "";
            txtCustomeraddress.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            btnAdd.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustomername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtCustomerage.Focus();
            }
        }

        private void txtCustomerage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCustomeraddress.Focus();
            }
        }

        private void txtCustomeraddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContact.Focus();
            }
        }

        private void txtContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        private void frmCustomerDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvCustomerDetails_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomerDetails.Rows[e.RowIndex];
                txtCustomerid.Text = row.Cells[0].Value.ToString();
            }
        }
    }
}
