using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTMS.UI.Forms;
using TTMS.UI.Forms.Tours;

namespace TTMS.UI
{
    public partial class frmTourBooking : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False");
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();

        private bool isDragging = false;
        private int mouseX, mouseY;

        public frmTourBooking()
        {
            InitializeComponent();

            // Assuming your DataGridView is named dgvParticipants
            dgvParticipants.RowsAdded += dgvParticipants_RowsAdded;
            dgvParticipants.RowsRemoved += dgvParticipants_RowsRemoved;

            // Initialize label text
            UpdateParticipantsLabel();
        }

        private void frmTourBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'verificationDetailsDataSet.VerificationDetails' table. You can move, or remove it, as needed.
            this.verificationDetailsTableAdapter.Fill(this.verificationDetailsDataSet.VerificationDetails);
            // TODO: This line of code loads data into the 'tourDataSet.CustomerDetails' table. You can move, or remove it, as needed.
            this.customerDetailsTableAdapter.Fill(this.tourDataSet.CustomerDetails);
            // TODO: This line of code loads data into the 'verificationDetailsDataSet.VerificationDetails' table. You can move, or remove it, as needed.

        }

        #region Form Dragging Event
        private void panelTourBookingTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void panelTourBookingTitlebar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void panelTourBookingTitlebar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }
        #endregion

        #region Functions

        #region Functions for Tour Booking
        private void SelectDataForTravel()
        {
            cmd = new SqlCommand("SELECT * FROM TourBookings", con);

            con.Open();

            ds.Clear();
            da = new SqlDataAdapter(cmd);

            con.Close();

            da.Fill(ds, "TourBookings");

            dgvTourBooking.DataSource = ds.Tables["TourBookings"];
        }

        private void InsertDataForTravel(int packageId)
        {
            try
            {

                string query = @"INSERT INTO TourBookings (BookingId, BookingDate, PackageId, CustomerId, NoOfParticipants)VALUES ( @BookingId, @BookingDate, @PackageId, @CustomerId, @NoOfParticipants)";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@BookingId", tbBookingId.Text);
                command.Parameters.AddWithValue("@BookingDate", dtpBookingDate.Value);
                command.Parameters.AddWithValue("@PackageId", packageId);
                command.Parameters.AddWithValue("@CustomerId", cbCustomer.SelectedValue);
                command.Parameters.AddWithValue("@NoOfParticipants", lblParticipants.Text);

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
            //try
            //{
            //    string query = @"UPDATE TravelDetails SET TravelName=@TravelName, VehicleId=@VehicleId WHERE TravelId=@TravelId";

            //    SqlCommand command = new SqlCommand(query, con);

            //    command.Parameters.AddWithValue("@TravelId", tbTravelId.Text);
            //    command.Parameters.AddWithValue("@TravelName", tbTravelName.Text);
            //    command.Parameters.AddWithValue("@VehicleId", cbVehicleId.SelectedValue);

            //    con.Open();
            //    command.ExecuteNonQuery();
            //    con.Close();

            //    MessageBox.Show("Travel updated Successfully");
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}
        }

        private void DeleteDataForTravel()
        {
            //try
            //{
            //    string query = @"DELETE FROM TravelDetails WHERE TravelId = @TravelId";

            //    SqlCommand command = new SqlCommand(query, con);

            //    command.Parameters.AddWithValue("@TravelId", tbTravelId.Text);

            //    con.Open();
            //    command.ExecuteNonQuery();
            //    con.Close();

            //    MessageBox.Show("Travel Deleted Successfully");
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}
        }
        #endregion

        #region Functions for Tour Participants

        #endregion

        #endregion


        // Method to update tour package textbox
        public void UpdateTourPackageTextbox(string selectedPackage)
        {
            tbPackageName.Text = selectedPackage; // Update the tour package textbox
        }

        public int SelectedPackageId(int selectedPackageId)
        {
            int packageId = selectedPackageId;

            return packageId;
        }

        #region Buttons & Click events

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //int packageId = ;
            //InsertDataForTravel();
            SelectDataForTravel();
            frmTourBilling billing = new frmTourBilling();
            billing.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            frmPackageList tourPackageListForm = new frmPackageList();
            tourPackageListForm.ShowDialog(); // Open TourPackageList form as a dialog

            // Check if a package was selected
            if (!string.IsNullOrEmpty(tourPackageListForm.SelectedPackage))
            {
                // Call the method to update tour package textbox
                UpdateTourPackageTextbox(tourPackageListForm.SelectedPackage);
            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerDetails customerDetails = new frmCustomerDetails();
            customerDetails.Show();
        }

        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            dgvParticipants.Rows.Add();
        }

        private void btnDeleteParticipant_Click(object sender, EventArgs e)
        {
            if(dgvParticipants.Rows.Count > 0)
            {
                int lastIndex = dgvParticipants.Rows.Count - 1;
                dgvParticipants.Rows.RemoveAt(lastIndex);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void dgvParticipants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvParticipants.Columns[e.ColumnIndex].HeaderText == "Action")
            {
                dgvParticipants.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvParticipants_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateParticipantsLabel();
        }

        private void dgvParticipants_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateParticipantsLabel();
        }

        private void UpdateParticipantsLabel()
        {
            // Update lblParticipants with the total number of rows in the DataGridView
            lblParticipants.Text = $"{dgvParticipants.Rows.Count}";
        }

        private void dgvParticipants_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == dgvParticipants.Columns["clmUpdate"].Index && e.RowIndex >= 0)
                {
                    string name = dgvParticipants.Rows[e.RowIndex].Cells["clmName"].Value.ToString();
                    MessageBox.Show($"{name}");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

    
    }
}
