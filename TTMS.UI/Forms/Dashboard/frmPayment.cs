using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTMS.UI.Forms.Payments;

namespace TTMS.UI.Forms.Dashboard
{
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void btnPaymentStatus_Click(object sender, EventArgs e)
        {
            frmPaymentStatus ps = new frmPaymentStatus();
            ps.Show();
        }

        private void btnPaymentMethod_Click(object sender, EventArgs e)
        {
            frmPaymentMethod pm = new frmPaymentMethod();
            pm.Show();
        }
    }
}
