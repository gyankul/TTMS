using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTMS.UI.Forms.Vehicle___Driver
{
    public partial class frmVehicleDetails : Form
    {
        public frmVehicleDetails()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmVehicleDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'driverDetailsDataSet.DriverDetails' table. You can move, or remove it, as needed.
            this.driverDetailsTableAdapter.Fill(this.driverDetailsDataSet.DriverDetails);

        }
    }
}
