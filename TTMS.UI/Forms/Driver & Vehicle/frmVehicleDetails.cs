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

namespace TTMS.UI.Forms.Vehicle___Driver
{
    public partial class frmVehicleDetails : Form
    {
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        public frmVehicleDetails()
        {
            InitializeComponent();
        }

        private void frmVehicleDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'driverDetailsDataSet.DriverDetails' table. You can move, or remove it, as needed.
            this.driverDetailsTableAdapter.Fill(this.driverDetailsDataSet.DriverDetails);

            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False";
            SelectData();
        }

        #region Function
        private void SelectData()
        {
            cmd = new SqlCommand("SELECT * FROM VehicleDetails", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "VehicleDetails");

            dgvVehicleDetails.DataSource = ds.Tables["VehicleDetails"];
        }

        private void InsertData()
        {

            try
            {

                string query = @"INSERT INTO VehicleDetails (VehicleId, VehicleName, Capacity, DriverId, SeatingType, VehicleLicenceNo)VALUES (@VehicleId, @VehicleName, @Capacity, @DriverId, @SeatingType, @VehicleLicenceNo)";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@VehicleId", tbvehicleId.Text);
                command.Parameters.AddWithValue("@VehicleName", tbVehicleName.Text);
                command.Parameters.AddWithValue("@Capacity", tbSeatingCapacity.Text);
                command.Parameters.AddWithValue("@DriverId", cbDrivername.SelectedValue);
                command.Parameters.AddWithValue("@SeatingType", cbSeatingType.Text);
                command.Parameters.AddWithValue("@VehicleLicenceNo", tbVehicleLicenceNo.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Vehicle Saved Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void UpdateData()
        {
            try
            {
                string query = @"UPDATE VehicleDetails SET VehicleName=@VehicleName, Capacity=@Capacity, DriverId=@DriverId, SeatingType=@SeatingType, VehicleLicenceNo=@VehicleLicenceNo WHERE VehicleId=@VehicleId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@VehicleId", tbvehicleId.Text);
                command.Parameters.AddWithValue("@VehicleName", tbVehicleName.Text);
                command.Parameters.AddWithValue("@Capacity", tbSeatingCapacity.Text);
                command.Parameters.AddWithValue("@DriverId", cbDrivername.SelectedValue);
                command.Parameters.AddWithValue("@SeatingType", cbSeatingType.Text);
                command.Parameters.AddWithValue("@VehicleLicenceNo", tbVehicleLicenceNo.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Vehicle updated Successfully");
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
                string query = @"DELETE FROM VehicleDetails WHERE VehicleId = @VehicleId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@VehicleId", tbvehicleId.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Vehicle Deleted Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void LoadItems()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False"))
                {
                    string query = "SELECT VehicleName,Capacity,DriverId,SeatingType,VehicleLicenceNo FROM VehicleDetails WHERE VehicleId = @VehicleId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@VehicleId", tbvehicleId.Text);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            tbVehicleName.Text = reader["VehicleName"].ToString();
                            tbSeatingCapacity.Text = reader["Capacity"].ToString();
                            cbDrivername.Text = reader["DriverId"].ToString();
                            cbSeatingType.Text = reader["SeatingType"].ToString();
                            tbVehicleLicenceNo.Text = reader["VehicleLicenceNo"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Vehicle with ID " + tbvehicleId.Text + " not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbvehicleId.Text = "";
            tbVehicleName.Text = "";
            cbSeatingType.Text = "- SELECT -";
            tbSeatingCapacity.Text = "";
            tbVehicleLicenceNo.Text = "";
            cbDrivername.Text = "- SELECT -";

            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(VehicleId) FROM VehicleDetails");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    tbvehicleId.Text = (a + 1).ToString();
                }
                else
                {
                    tbvehicleId.Text = "1";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertData();
            SelectData();
            tbvehicleId.Text = "";
            tbVehicleName.Text = "";
            cbSeatingType.Text = "- SELECT -";
            tbSeatingCapacity.Text = "";
            tbVehicleLicenceNo.Text = "";
            cbDrivername.Text = "- SELECT -";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
            SelectData();
            tbvehicleId.Text = "";
            tbVehicleName.Text = "";
            cbSeatingType.Text = "- SELECT -";
            tbSeatingCapacity.Text = "";
            tbVehicleLicenceNo.Text = "";
            cbDrivername.Text = "- SELECT -";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
            SelectData();
            tbvehicleId.Text = "";
            tbVehicleName.Text = "";
            cbSeatingType.Text = "- SELECT -";
            tbSeatingCapacity.Text = "";
            tbVehicleLicenceNo.Text = "";
            cbDrivername.Text = "- SELECT -";
        }

        private void btnLoadItems_Click(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void dgvVehicleDetails_SelectionChanged(object sender, EventArgs e)
        {
            //foreach(DataGridViewRow row in dgvVehicleDetails.SelectedRows)
            //{
            //    tbvehicleId.Text = row.Cells[0].Value.ToString();
            //}
        }

        private void dgvVehicleDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvVehicleDetails.Rows[rowIndex];

                if (!string.IsNullOrEmpty(selectedRow.Cells[0].Value.ToString()))
                {
                    string vehicleId = selectedRow.Cells[0].Value.ToString();
                    tbvehicleId.Text = vehicleId;
                }
            }
        }

    }
}
