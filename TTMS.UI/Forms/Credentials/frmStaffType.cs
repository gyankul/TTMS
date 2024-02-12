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
    public partial class frmStaffType : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;

        DataSet ds = new DataSet();

        public frmStaffType()
        {
            InitializeComponent();
            this.ActiveControl = btnADD;
        }

        private void frmStaffType_Load(object sender, EventArgs e)
        {
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False";

            SelectData();

            btnADD.Focus();
        }

        #region Functions

        private void SelectData()
        {
            cmd = new SqlCommand("SELECT * FROM StaffTypes", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "StaffTypes");

            dgvStaffTypes.DataSource = ds.Tables["StaffTypes"];
        }
        private void InsertData()
        {
            try
            {
                string query = @"INSERT INTO StaffTypes (StaffTypeId, StaffTypeName)VALUES (@StaffTypeId, @StaffTypeName)";


                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@StaffTypeId", tbStaffTypeId.Text);
                command.Parameters.AddWithValue("@StaffTypeName", tbStaffTypeName.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Staff Type Detail is Saved Successfully");
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
                string query = @"DELETE FROM StaffTypes WHERE StaffTypeId = @StaffTypeId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@StaffTypeId", tbStaffTypeId.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Staff Detail is Deleted Successfully");
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
            tbStaffTypeName.Focus();
            tbStaffTypeName.Text = "";

            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(StaffTypeId) FROM StaffTypes");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    tbStaffTypeId.Text = (a + 1).ToString();
                }
                else
                {
                    tbStaffTypeId.Text = "1";
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SelectData();
            DeleteData();
            tbStaffTypeId.Text = "";
            tbStaffTypeName.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertData();
            SelectData();
            tbStaffTypeId.Text = "";
            tbStaffTypeName.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbStaffTypeId.Text = "";
            tbStaffTypeName.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Key Event



        #endregion

        private void tbStaffTypeId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbStaffTypeName.Focus();
            }
        }

        private void tbStaffTypeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }
    }
}
