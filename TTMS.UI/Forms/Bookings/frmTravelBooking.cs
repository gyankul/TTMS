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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace TTMS.UI.Forms.Bookings
{
    public partial class frmTravelBooking : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        public frmTravelBooking()
        {
            InitializeComponent();
        }

        #region Functions

        #region Functions for TravelBooking
        private void SelectDataForTravel()
        {
            cmd = new SqlCommand("SELECT * FROM TravelBookings", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "TravelBookings");

            dgvTravelBooking.DataSource = ds.Tables["TravelBookings"];
        }

        private void InsertDataForTravel()
        {
            try
            {

                string query = "INSERT INTO TravelBookings (BookingId, BookingDate, BookingFrom, BookingTo, TravelId, CustomerId, NoOfPassenger, TotalDistance, TotalFare) VALUES (@BookingId, @BookingDate, @BookingFrom, @BookingTo, @TravelId, @CustomerId, @NoOfPassenger, @TotalDistance, @TotalFare)";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@BookingId", tbBookingId.Text);
                command.Parameters.AddWithValue("@BookingDate", dtpBookingDate.Value);
                command.Parameters.AddWithValue("@BookingFrom", cbSource.SelectedValue);
                command.Parameters.AddWithValue("@BookingTo", cbDestination.SelectedValue);
                command.Parameters.AddWithValue("@TravelId", cbTravels.SelectedValue);
                command.Parameters.AddWithValue("@CustomerId", cbCustomerName.SelectedValue);
                command.Parameters.AddWithValue("@NoOfPassenger", lblPassengers.Text);
                command.Parameters.AddWithValue("@TotalDistance", lblDistance.Text);
                command.Parameters.AddWithValue("@TotalFare", lblFare.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Travel Booking Saved Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void UpdateDataForTravel()
        {
            try
            {
                string query = @"UPDATE TravelBookings SET BookingId=@BookingId, BookingDate=@BookingDate, BookingFrom=@BookingFrom, BookingTo=@BookingTo, TravelId=@TravelId, CustomerId=@CustomerId, NoOfPassenger=@NoOfPassenger, TotalDistance=@TotalDistance, TotalFare=@TotalFare WHERE BookingId=@BookingId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@BookingId", tbBookingId.Text);
                command.Parameters.AddWithValue("@BookingDate", dtpBookingDate.Value);
                command.Parameters.AddWithValue("@BookingFrom", cbSource.SelectedValue);
                command.Parameters.AddWithValue("@BookingTo", cbDestination.SelectedValue);
                command.Parameters.AddWithValue("@TravelId", cbTravels.SelectedValue);
                command.Parameters.AddWithValue("@CustomerId", cbCustomerName.SelectedValue);
                command.Parameters.AddWithValue("@NoOfPassenger", lblPassengers.Text);
                command.Parameters.AddWithValue("@TotalDistance", lblDistance.Text);
                command.Parameters.AddWithValue("@TotalFare", lblFare.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Travel Booking updated Successfully");
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
                string query = @"DELETE FROM TravelBookings WHERE BookingId = @BookingId";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@BookingId", tbBookingId.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Travel Booking Deleted Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region Functions for Passenger
        private void SavePassengersforTravel()
        {
            foreach (DataGridViewRow row in dgvParticipants.Rows)
            {
                // Check if the row is not empty
                if (!row.IsNewRow)
                {
                    // Extract data from DataGridView cells
                    string SrNo = row.Cells["clmSRNO"].Value.ToString();
                    string Name = row.Cells["clmName"].Value.ToString();
                    string Age = row.Cells["clmAge"].Value.ToString();
                    string Gender= row.Cells["clmGender"].Selected.ToString();
                    string PhoneNo = row.Cells["clmPhoneNo"].Value.ToString();
                    string VerificationType = row.Cells["clmVerificationType"].Selected.ToString();
                    string VerificationNo = row.Cells["clmVerificationNo"].Value.ToString();

                    // Save the data into the itinerary database table
                    SavePassengerinDB(SrNo, Name, Age, Gender, PhoneNo, VerificationType, VerificationNo);
                }
            }

            // Optionally, show a message indicating successful save
            MessageBox.Show("Passenger for this travel are saved successfully!");
        }

        private void SavePassengerinDB(string SrNo, string Name, string Age, string Gender, string PhoneNo, string VerificationType, string VerificationNo)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False";

            string query = "INSERT INTO TravelPassengers ( SRNO, CustomerId, Name, Age, Gender, VerificationId, VerificationNo, Contact) VALUES ( @SRNO, @CustomerId, @Name, @Age, @Gender, @VerificationId, @VerificationNo, @Contact)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@SRNO", SrNo);
                    command.Parameters.AddWithValue("@CustomerId", cbCustomerName.SelectedValue);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Age", Age);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@VerificationId", VerificationType);
                    command.Parameters.AddWithValue("@VerificationNo", VerificationNo);
                    command.Parameters.AddWithValue("@Contact", PhoneNo);

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
            inc.increment("SELECT max(BookingId) FROM TravelBookings");
            if (inc.dr.Read())
            {
                if (inc.dr[0] != System.DBNull.Value)
                {
                    a = Convert.ToInt32(inc.dr[0].ToString());
                    tbBookingId.Text = (a + 1).ToString();
                }
                else
                {
                    tbBookingId.Text = "1";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchTravel_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerDetails cusotmer = new frmCustomerDetails();
            cusotmer.ShowDialog();
        }

        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            dgvParticipants.Rows.Add();
        }

        private void btnDeletePassenger_Click(object sender, EventArgs e)
        {
            if (dgvParticipants.Rows.Count > 0)
            {
                int lastIndex = dgvParticipants.Rows.Count - 1;
                dgvParticipants.Rows.RemoveAt(lastIndex);
            }
        }
        #endregion

        private void frmTravelBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDetailDataSet.TravelStops' table. You can move, or remove it, as needed.
            this.travelStopsTableAdapter.Fill(this.travelDetailDataSet.TravelStops);
            // TODO: This line of code loads data into the 'verificationDetailsDataSet.VerificationDetails' table. You can move, or remove it, as needed.
            this.verificationDetailsTableAdapter.Fill(this.verificationDetailsDataSet.VerificationDetails);
            // TODO: This line of code loads data into the 'travelDetailDataSet.CustomerDetails' table. You can move, or remove it, as needed.
            this.customerDetailsTableAdapter.Fill(this.travelDetailDataSet.CustomerDetails);

        }
    }
}
