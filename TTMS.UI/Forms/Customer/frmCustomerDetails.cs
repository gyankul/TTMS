using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTMS.UI.Forms
{
    public partial class frmCustomerDetails : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ttmsDBConnectionString"].ConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        public frmCustomerDetails()
        {
            InitializeComponent();
        }

        #region Functions

        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDetailDataSet.VerificationDetails' table. You can move, or remove it, as needed.
            this.verificationDetailsTableAdapter.Fill(this.customerDetailDataSet.VerificationDetails);
            // TODO: This line of code loads data into the 'customerDetailDataSet.CountryDetails' table. You can move, or remove it, as needed.
            this.countryDetailsTableAdapter.Fill(this.customerDetailDataSet.CountryDetails);
            // TODO: This line of code loads data into the 'ttmsDBDataSet1.CountryDetails' table. You can move, or remove it, as needed.

            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True";
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True";

            SelectData();

            ActiveControl = btnAdd;

        }

        private void SelectData()
        {
            cmd = new SqlCommand("SELECT * FROM CustomerDetails", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "CustomerDetails");

            dgvCustomer.DataSource = ds.Tables["CustomerDetails"];
        }

        private void InsertData()
        {
            //if (isvalidate())
            //{
            try
            {

                string query = @"INSERT INTO CustomerDetails (CustomerId, CustomerName, DOB, Gender, Contact, Email, Address, NationalityId, VerificationId, VerificationNo)VALUES (@CustomerId, @CustomerName, @DOB, @Gender, @Contact, @Email, @Address, @NationalityId, @VerificationId, @VerificationNo)";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@CustomerId", tbCustomerId.Text);
                command.Parameters.AddWithValue("@CustomerName", tbCustomerName.Text);
                command.Parameters.AddWithValue("@DOB", dtpDOB.Value);
                if (rbMale.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Male");
                }
                else if (rbFemale.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Female");
                }
                else if (rbOther.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Other");
                }
                command.Parameters.AddWithValue("@NationalityId", cbNationality.SelectedValue);
                command.Parameters.AddWithValue("@Address", tbAddress.Text);
                command.Parameters.AddWithValue("@Contact", tbPhoneNo.Text);
                command.Parameters.AddWithValue("@Email", tbEmail.Text);
                command.Parameters.AddWithValue("@VerificationId", cbVerificationType.SelectedValue);
                command.Parameters.AddWithValue("@VerificationNo", tbVerificationNo.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Customer Saved Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //else
            //{
            //    MessageBox.Show("Please Enter All the Fields......", "Registeration Failed!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void UpdateData()
        {
            try
            {
                string query = @"UPDATE CustomerDetails SET CustomerName=@CustomerName, DOB=@DOB, Gender=@Gender, NationalityId=@NationalityId, Address=@Address, Contact=@Contact, Email=@Email, VerificationId=@VerificationId, VerificationNo=@VerificationNo WHERE CustomerId=@CustomerId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@CustomerId", tbCustomerId.Text);
                command.Parameters.AddWithValue("@CustomerName", tbCustomerName.Text);
                command.Parameters.AddWithValue("@DOB", dtpDOB.Value);
                if (rbMale.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Male");
                }
                else if (rbFemale.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Female");
                }
                else if (rbOther.Checked)
                {
                    command.Parameters.AddWithValue("@Gender", "Other");
                }
                command.Parameters.AddWithValue("@NationalityId", cbNationality.SelectedValue);
                command.Parameters.AddWithValue("@Address", tbAddress.Text);
                command.Parameters.AddWithValue("@Contact", tbPhoneNo.Text);
                command.Parameters.AddWithValue("@Email", tbEmail.Text);
                command.Parameters.AddWithValue("@VerificationId", cbVerificationType.SelectedValue);
                command.Parameters.AddWithValue("@VerificationNo", tbVerificationNo.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customer Detail updated Successfully");
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
                string query = @"DELETE FROM CustomerDetails WHERE CustomerId = @CustomerId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@CustomerId", tbCustomerId.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customer Deleted Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        #endregion

        #region Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbCustomerId.Text = "";
            tbCustomerName.Text = "";
            dtpDOB.Value = DateTime.Now;
            tbAddress.Text = "";
            cbNationality.Text = "- SELECT -";
            tbPhoneNo.Text = "";
            tbEmail.Text = "";
            cbVerificationType.Text = "- SELECT -";
            tbVerificationNo.Text = "";

            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(CustomerId) FROM CustomerDetails");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    tbCustomerId.Text = (a + 1).ToString();
                }
                else
                {
                    tbCustomerId.Text = "1";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            SelectData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
            SelectData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertData();
            SelectData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Events

        private void tbCustomerId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbCustomerName.Focus();
            }
        }

        private void tbCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpDOB.Focus();
            }
        }

        private void dtpDOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rbMale.Focus();
            }
        }

        private void rbMale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                rbFemale.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                rbMale.Checked = true;
                cbNationality.Focus();
            }
        }

        private void rbFemale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                rbOther.Focus();
            }
            if (e.KeyCode == Keys.Left)
            {
                rbMale.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                rbFemale.Checked = true;
                cbNationality.Focus();
            }
        }

        private void rbOther_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                rbFemale.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                rbOther.Checked = true;
                cbNationality.Focus();
            }
        }

        private void cbNationality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbAddress.Focus();
            }
        }

        private void tbAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbPhoneNo.Focus();
            }
        }

        private void tbPhoneNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbEmail.Focus();
            }
        }

        private void tbEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbVerificationType.Focus();
            }
        }

        private void cbVerificationType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbVerificationNo.Focus();
            }
        }

        private void tbVerificationNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        #endregion

    }
}
