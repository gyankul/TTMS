using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTMS.UI.Tours;

namespace TTMS.UI
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();

            this.MouseDown += new MouseEventHandler(MainForm_MouseDown);
            this.MouseUp += new MouseEventHandler(MainForm_MouseUp);
            this.MouseMove += new MouseEventHandler(MainForm_MouseMove);
        }

        private bool isDragging = false;
        private int xOffset;
        private int yOffset;

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int Param);

        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();


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



        bool SidebarExpand;
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

        //bool btnToolsExpand;

        //private void btnToolClick_Tick(object sender, EventArgs e)
        //{
        //    if (btnToolsExpand)
        //    {
        //        if (panel8.Height == panel8.MinimumSize.Height)
        //        {
        //            btnToolsExpand = false;
        //            btnToolClick.Stop();
        //        }
        //        else
        //        {
        //            panel8.Height -= 10;
        //        }
        //    }
        //    else
        //    {
        //        if (panel8.Height == panel8.MaximumSize.Height)
        //        {
        //            btnToolsExpand = true;
        //            btnToolClick.Stop();
        //        }
        //        else
        //        {
        //            panel8.Height += 10;
        //        }
        //    }
        //}

        private void pbHamburger_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        private void btnMaster_Click(object sender, EventArgs e)
        {
            new frmTravelBooking().Show();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            TourPackage tp = new TourPackage();
            tp.TopLevel = false;
            panel3.Controls.Add(tp);
            tp.BringToFront();
            tp.Show();
        }

        //private void btnTools_Click(object sender, EventArgs e)
        //{
        //    btnToolClick.Start();
        //}
    }
    
}
