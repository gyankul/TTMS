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
using TTMS.UI.Forms;
using TTMS.UI.Forms.Tours;

namespace TTMS.UI
{
    public partial class frmTourBooking : Form
    {
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

        #region Buttons & Click events

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmTourBilling billing = new frmTourBilling();
            billing.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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

        private void btnAddPackage_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerDetails customerDetails = new frmCustomerDetails();
            customerDetails.Show();
        }

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

        private void frmTourBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'verificationDetailsDataSet.VerificationDetails' table. You can move, or remove it, as needed.

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    
    }
}
