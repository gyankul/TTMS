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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTMS.UI;
using TTMS.UI.Forms.Tours;
using TTMS.UI.Tours;

namespace TTMS.UI
{
    public partial class frmMainForm : Form
    {
        private string loggedInUsername;
        private byte[] loggedInUserImage;

        public frmMainForm(string username, byte[] userImage) 
        {  

            
            loggedInUsername = username;
            loggedInUserImage = userImage;
            DisplayUserData();

            this.MouseDown += new MouseEventHandler(MainForm_MouseDown);
            this.MouseUp += new MouseEventHandler(MainForm_MouseUp);
            this.MouseMove += new MouseEventHandler(MainForm_MouseMove);
        }

        public frmMainForm()
        {
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ttmsDB;Integrated Security=True;Encrypt=False");
        }


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

        #region something idk
        private bool isDragging = false;
        private int xOffset;
        private int yOffset;

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int Param);

        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();
        #endregion

        #region min,max,close buttons

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region something idk

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isDragging = true;
                xOffset = e.X;
                yOffset = e.Y;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left = Cursor.Position.X - xOffset;
                this.Top = Cursor.Position.Y - yOffset;
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if(m.Msg == WM_NCLBUTTONDOWN && m.WParam.ToInt32() == HT_CAPTION)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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

        private void btnTourPackage_Click(object sender, EventArgs e)
        {
            frmTourPackages package = new frmTourPackages();
            package.TopLevel = false;
            panelMainformCenterRegion.Controls.Add(package);
            package.BringToFront();
            package.Show(); 
        }
    }

}
