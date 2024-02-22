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

namespace TTMS.UI.Forms.Travels
{
    public partial class frmTravelDetails : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        public frmTravelDetails()
        {
            InitializeComponent();
        }

        private void formTravelDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDetailDataSet.VehicleDetails' table. You can move, or remove it, as needed.
            this.vehicleDetailsTableAdapter.Fill(this.travelDetailDataSet.VehicleDetails);

        }

        #region Functions

        #region Functions for Travel Details
        private void SelectDataForTravel()
        {
            cmd = new SqlCommand("SELECT * FROM TravelDetails", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "TravelDetails");

            dgvTravelDetails.DataSource = ds.Tables["TravelDetails"];
        }

        private void InsertDataForTravel()
        {
            try
            {

                string query = @"INSERT INTO TravelDetails ( TravelId, TravelName, VehicleId)VALUES ( @TravelId, @TravelName, @VehicleId)";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@TravelId", tbTravelId.Text);
                command.Parameters.AddWithValue("@TravelName", tbTravelName.Text);
                command.Parameters.AddWithValue("@VehicleId", cbVehicleId.SelectedValue);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Travel Saved Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void UpdateDataForTraavel()
        {
            try
            {
                string query = @"UPDATE TravelDetails SET TravelName=@TravelName, VehicleId=@VehicleId WHERE TravelId=@TravelId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@TravelId", tbTravelId.Text);
                command.Parameters.AddWithValue("@TravelName", tbTravelName.Text);
                command.Parameters.AddWithValue("@VehicleId", cbVehicleId.SelectedValue);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Travel updated Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void DeleteDataForTravel()
        {
            try
            {
                string query = @"DELETE FROM TravelDetails WHERE TravelId = @TravelId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@TravelId", tbTravelId.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Travel Deleted Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region Functions for Stops


        private void SaveStopsforTravel()
        {
            foreach (DataGridViewRow row in dgvStops.Rows)
            {
                // Check if the row is not empty
                if (!row.IsNewRow)
                {
                    // Extract data from DataGridView cells
                    string StopNo = row.Cells["clmStopNo"].Value.ToString();
                    string StopName = row.Cells["clmStopName"].Value.ToString();
                    string Distance = row.Cells["clmDistance"].Value.ToString();

                    // Save the data into the itinerary database table
                    SaveStopsinDB( StopNo, StopName, Distance);
                }
            }

            // Optionally, show a message indicating successful save
            MessageBox.Show("Stops for this travel are saved successfully!");
        }

        private void SaveStopsinDB( string stopNo, string stopName, string distance)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False";

            string query = "INSERT INTO TravelStops (TravelId, StopNumber, StopName, Distance) VALUES (@TravelId, @StopNumber, @StopName, @Distance)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@TravelId", tbTravelId.Text);
                    command.Parameters.AddWithValue("@StopNumber", stopNo);
                    command.Parameters.AddWithValue("@StopName", stopName);
                    command.Parameters.AddWithValue("@Distance", distance);

                    // Execute the command
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #endregion
        #region Buttons
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AutoIncrement inc = new AutoIncrement();
            int a;
            inc.increment("SELECT max(TravelId) FROM TravelDetails");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    tbTravelId.Text = (a + 1).ToString();
                }
                else
                {
                    tbTravelId.Text = "1";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertDataForTravel();
            SelectDataForTravel();
            SaveStopsforTravel();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDataForTraavel();
            SelectDataForTravel();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDataForTravel();
            SelectDataForTravel();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStops_Click(object sender, EventArgs e)
        {
            dgvStops.Rows.Add();
        }

        private void btnDeleteStops_Click(object sender, EventArgs e)
        {
            if (dgvStops.Rows.Count > 0)
            {
                int lastIndex = dgvStops.Rows.Count - 1;
                dgvStops.Rows.RemoveAt(lastIndex);
            }
        }
        #endregion
    }
}
