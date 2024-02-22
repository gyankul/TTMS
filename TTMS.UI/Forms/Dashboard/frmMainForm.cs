using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTMS.UI;
using TTMS.UI.Forms;
using TTMS.UI.Forms.Bookings;
using TTMS.UI.Forms.Dashboard;
using TTMS.UI.Forms.Tours;
using TTMS.UI.Forms.Travels;
using TTMS.UI.Tours;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TTMS.UI
{
    public partial class frmMainForm : Form
    {
        public string username;
        private string loggedInUsername;
        private byte[] loggedInUserImage;

        public frmMainForm(string username, byte[] userImage) 
        {  
            loggedInUsername = username;
            loggedInUserImage = userImage;
            DisplayUserData();
            InitializeComponent();
        }

        public frmMainForm()
        {
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False");

        }

        #region Function for Button Click Validation
        //private string GetUserStaffType(string username)
        //{
        //    string staffType = "";
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False"))
        //        {
        //            connection.Open();
        //            string query = "SELECT st.StaffTypeName " +
        //                           "FROM SignupDetails sd " +
        //                           "INNER JOIN StaffTypeName st ON sd.StaffTypeId = st.StaffTypeId " +
        //                           "WHERE sd.Username = @Username";
        //            SqlCommand command = new SqlCommand(query, connection);
        //            command.Parameters.AddWithValue("@Username", username);
        //            staffType = (string)command.ExecuteScalar();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error retrieving user details: " + ex.Message);
        //    }
        //    return staffType;
        //}


        #endregion

        #region Function for Displaying Name&Image after login
        private void DisplayUserData()
        {
            lblUserName.Text = $"{loggedInUsername}";
            cpbUserImg.Image = ByteArrayToImage(loggedInUserImage);

        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
            {
                // Handle empty or null byte array, return a default image or null as needed.
                return null;
            }

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                try
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
                catch (Exception ex)
                {
                    // Handle image conversion errors, log the exception, etc.
                    Console.WriteLine("Error converting byte array to Image: " + ex.Message);
                    return null;
                }
            }
        }
        #endregion

        #region all expanding panels and their button controls

        bool SidebarExpand;
        bool btnMasterExpand;
        bool btnToursExpand;
        bool btnTravelsExpand;
        bool btnBookingsExpand;
        bool btnReportsExpand;
        bool btnToolsExpand;
        bool UserProfileExpand;

        private void SidebarTransition_Tick(object sender, EventArgs e)
        {
            if (SidebarExpand)
            {
                if(panelSidebar.Width == panelSidebar.MinimumSize.Width)
                {
                    SidebarExpand = false;
                    SidebarTransition.Stop();
                }
                else
                {
                    panelSidebar.Width -= 10;
                }
            }
            else
            {
                if(panelSidebar.Width == panelSidebar.MaximumSize.Width)
                {
                    SidebarExpand = true;
                    SidebarTransition.Stop();
                }
                else
                {
                    panelSidebar.Width += 10;
                }
            }
        }

        private void btnMasterClick_Tick(object sender, EventArgs e)
        {
            if (btnMasterExpand)
            {
                if (panelMaster.Height == panelMaster.MinimumSize.Height)
                {
                    btnMasterExpand = false;
                    btnMasterClick.Stop();
                }
                else
                {
                    panelMaster.Height -= 10;
                }
            }
            else
            {
                if (panelMaster.Height == panelMaster.MaximumSize.Height)
                {
                    btnMasterExpand = true;
                    btnMasterClick.Stop();
                }
                else
                {
                    panelMaster.Height += 10;
                }
            }
        }

        private void btnToursClick_Tick(object sender, EventArgs e)
        {
            if (btnToursExpand)
            {
                if (panelTours.Height == panelTours.MinimumSize.Height)
                {
                    btnToursExpand = false;
                    btnToursClick.Stop();
                }
                else
                {
                    panelTours.Height -= 10;
                }
            }
            else
            {
                if (panelTours.Height == panelTours.MaximumSize.Height)
                {
                    btnToursExpand = true;
                    btnToursClick.Stop();
                }
                else
                {
                    panelTours.Height += 10;
                }
            }
        }

        private void btnTravelsClick_Tick(object sender, EventArgs e)
        {
            if (btnTravelsExpand)
            {
                if (panelTravels.Height == panelTravels.MinimumSize.Height)
                {
                    btnTravelsExpand = false;
                    btnTravelsClick.Stop();
                }
                else
                {
                    panelTravels.Height -= 10;
                }
            }
            else
            {
                if (panelTravels.Height == panelTravels.MaximumSize.Height)
                {
                    btnTravelsExpand = true;
                    btnTravelsClick.Stop();
                }
                else
                {
                    panelTravels.Height += 10;
                }
            }
        }

        private void btnBookingsClick_Tick(object sender, EventArgs e)
        {
            if (btnBookingsExpand)
            {
                if (panelBookings.Height == panelBookings.MinimumSize.Height)
                {
                    btnBookingsExpand = false;
                    btnBookingsClick.Stop();
                }
                else
                {
                    panelBookings.Height -= 10;
                }
            }
            else
            {
                if (panelBookings.Height == panelBookings.MaximumSize.Height)
                {
                    btnBookingsExpand = true;
                    btnBookingsClick.Stop();
                }
                else
                {
                    panelBookings.Height += 10;
                }
            }
        }

        private void btnReportsClick_Tick(object sender, EventArgs e)
        {
            if (btnReportsExpand)
            {
                if (panelReports.Height == panelReports.MinimumSize.Height)
                {
                    btnReportsExpand = false;
                    btnReportsClick.Stop();
                }
                else
                {
                    panelReports.Height -= 10;
                }
            }
            else
            {
                if (panelReports.Height == panelReports.MaximumSize.Height)
                {
                    btnReportsExpand = true;
                    btnReportsClick.Stop();
                }
                else
                {
                    panelReports.Height += 10;
                }
            }
        }

        private void btnToolClick_Tick(object sender, EventArgs e)
        {
            if (btnToolsExpand)
            {
                if (panelTools.Height == panelTools.MinimumSize.Height)
                {
                    btnToolsExpand = false;
                    btnToolClick.Stop();
                }
                else
                {
                    panelTools.Height -= 10;
                }
            }
            else
            {
                if (panelTools.Height == panelTools.MaximumSize.Height)
                {
                    btnToolsExpand = true;
                    btnToolClick.Stop();
                }
                else
                {
                    panelTools.Height += 10;
                }
            }
        }

        private void UserProfileClick_Tick(object sender, EventArgs e)
        {
            if (UserProfileExpand)
            {
                if (panelUserProfile.Height == panelUserProfile.MinimumSize.Height)
                {
                    UserProfileExpand = false;
                    UserProfileClick.Stop();
                }
                else
                {
                    panelUserProfile.Height -= 10;
                }
            }
            else
            {
                if (panelUserProfile.Height == panelUserProfile.MaximumSize.Height)
                {
                    UserProfileExpand = true;
                    UserProfileClick.Stop();
                }
                else
                {
                    panelUserProfile.Height += 10;
                }
            }
        }


        private void pbHamburger_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }        
        private void btnMaster_Click(object sender, EventArgs e)
        {
            btnMasterClick.Start();
            //new frmTravelBooking().Show();
        }
        private void btnTours_Click(object sender, EventArgs e)
        {
            btnToursClick.Start();
        }
        private void btnTravels_Click(object sender, EventArgs e)
        {
            btnTravelsClick.Start();
        }
        private void btnBookings_Click(object sender, EventArgs e)
        {
            btnBookingsClick.Start();
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            btnReportsClick.Start();
        }
        private void btnTools_Click(object sender, EventArgs e)
        {
            //TourPackage tp = new TourPackage();
            //tp.TopLevel = false;
            //panel3.Controls.Add(tp);
            //tp.BringToFront();
            //tp.Show();
            btnToolClick.Start();
        }
        private void cpbUserImg_Click(object sender, EventArgs e)
        {
            UserProfileClick.Start();
        }







        #endregion

        #region Buttons for Sidebar

        #region Button Master
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerDetails customer= new frmCustomerDetails();
            customer.TopLevel = false;
            panelMainformCenterRegion.Controls.Add(customer);
            customer.BringToFront();
            customer.Show();
            // Check if the user is authorized to perform the action
            //string staffType = GetUserStaffType(username);
            //if (staffType != "Admin")
            //{
            //    MessageBox.Show("You are not authorized to perform this action.");
            //    return;
            //}

            // Proceed with the action if the user is authorized
            // Add your button click logic here
        }

        private void btnDriverVehicle_Click(object sender, EventArgs e)
        {
            frmDriverVehicle dv = new frmDriverVehicle();
            dv.TopLevel = false;
            panelMainformCenterRegion.Controls.Add(dv);
            dv.BringToFront();
            dv.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            frmPayment pay = new frmPayment();
            pay.TopLevel = false;
            panelMainformCenterRegion.Controls.Add(pay);
            pay.BringToFront();
            pay.Show();
        }


        #endregion

        #region Button Tour
        private void btnTourPackage_Click(object sender, EventArgs e)
        {
            frmTourPackage package = new frmTourPackage();
            package.TopLevel = false;
            panelMainformCenterRegion.Controls.Add(package);
            package.BringToFront();
            package.Show(); 
        }

        private void btnTourDestinations_Click(object sender, EventArgs e)
        {
            frmTourDestination destination = new frmTourDestination();
            destination.TopLevel = false;
            panelMainformCenterRegion.Controls.Add(destination);
            destination.BringToFront();
            destination.Show();
        }

        private void btnTourItinerary_Click(object sender, EventArgs e)
        {
            frmTourItinerary package = new frmTourItinerary();
            package.TopLevel = false;
            panelMainformCenterRegion.Controls.Add(package);
            package.BringToFront();
            package.Show();
        }
        #endregion

        #region Button Travel
        private void btnTravelDetails_Click(object sender, EventArgs e)
        {
            frmTravelDetails td = new frmTravelDetails();
            td.TopLevel = false;
            panelMainformCenterRegion.Controls.Add(td);
            td.BringToFront();
            td.Show();
        }
        #endregion

        #region Button Booking
        private void btnTourBkg_Click(object sender, EventArgs e)
        {
            frmTourBooking tb = new frmTourBooking();
            tb.TopLevel = false;
            panelMainformCenterRegion.Controls.Add(tb);
            tb.BringToFront();
            tb.Show();
        }

        private void btnTravelBkg_Click(object sender, EventArgs e)
        {
            frmTravelBooking tb = new frmTravelBooking();
            tb.TopLevel = false;
            panelMainformCenterRegion.Controls.Add(tb);
            tb.BringToFront();
            tb.Show();
        }
        #endregion

        #region Button Reports

        #endregion

        #region Button Tools

        #endregion

        #endregion

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().Show();
        }

        private void btnCredentials_Click(object sender, EventArgs e)
        {

        }

    }

}
