using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTMS.UI.Forms.Driver___Vehicle;
using TTMS.UI.Forms.Vehicle___Driver;

namespace TTMS.UI.Forms.Dashboard
{
    public partial class frmDriverVehicle : Form
    {
        public frmDriverVehicle()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            frmDriverDetails frmDriverDetails = new frmDriverDetails(); 
            frmDriverDetails.ShowDialog();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            frmVehicleDetails frmVehicleDetails = new frmVehicleDetails();  
            frmVehicleDetails.ShowDialog();
        }
    }
}
