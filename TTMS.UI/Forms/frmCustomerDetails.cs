using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTMS.UI.Forms
{
    public partial class frmCustomerDetails : Form
    {
        public frmCustomerDetails()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCustomerDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ttmsDBDataSet1.CountryDetails' table. You can move, or remove it, as needed.
            this.countryDetailsTableAdapter.Fill(this.ttmsDBDataSet1.CountryDetails);

        }
    }
}
