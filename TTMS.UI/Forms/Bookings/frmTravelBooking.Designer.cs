namespace TTMS.UI.Forms.Bookings
{
    partial class frmTravelBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTravelBooking));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeletePassenger = new System.Windows.Forms.Button();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpJourneyDate = new System.Windows.Forms.DateTimePicker();
            this.cbCustomerName = new System.Windows.Forms.ComboBox();
            this.cbTravels = new System.Windows.Forms.ComboBox();
            this.btnSearchTravel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTravelBooking = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.lblPassengers = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFare = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblTravelAvailability = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvParticipants = new System.Windows.Forms.DataGridView();
            this.travelDetailDataSet = new TTMS.UI.Dataset.TravelDetailDataSet();
            this.customerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDetailsTableAdapter = new TTMS.UI.Dataset.TravelDetailDataSetTableAdapters.CustomerDetailsTableAdapter();
            this.verificationDetailsDataSet = new TTMS.UI.Dataset.VerificationDetailsDataSet();
            this.verificationDetailsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verificationDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verificationDetailsTableAdapter = new TTMS.UI.Dataset.VerificationDetailsDataSetTableAdapters.VerificationDetailsTableAdapter();
            this.clmAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmSRNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVerificationType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmVerificationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbBookingId = new System.Windows.Forms.TextBox();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.travelStopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelStopsTableAdapter = new TTMS.UI.Dataset.TravelDetailDataSetTableAdapters.TravelStopsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravelBooking)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDetailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelStopsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtpBookingDate);
            this.panel1.Controls.Add(this.dtpJourneyDate);
            this.panel1.Controls.Add(this.cbCustomerName);
            this.panel1.Controls.Add(this.cbSource);
            this.panel1.Controls.Add(this.cbDestination);
            this.panel1.Controls.Add(this.cbTravels);
            this.panel1.Controls.Add(this.btnSearchTravel);
            this.panel1.Controls.Add(this.tbBookingId);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvTravelBooking);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnAddNewCustomer);
            this.panel1.Controls.Add(this.lblPassengers);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblFare);
            this.panel1.Controls.Add(this.lblDistance);
            this.panel1.Controls.Add(this.lblTravelAvailability);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 793);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 51);
            this.panel2.TabIndex = 0;
            // 
            // btnDeletePassenger
            // 
            this.btnDeletePassenger.Image = global::TTMS.UI.Properties.Resources.icons8_remove_401;
            this.btnDeletePassenger.Location = new System.Drawing.Point(837, 145);
            this.btnDeletePassenger.Name = "btnDeletePassenger";
            this.btnDeletePassenger.Size = new System.Drawing.Size(42, 42);
            this.btnDeletePassenger.TabIndex = 2;
            this.btnDeletePassenger.UseVisualStyleBackColor = true;
            this.btnDeletePassenger.Click += new System.EventHandler(this.btnDeletePassenger_Click);
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBookingDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingDate.Location = new System.Drawing.Point(607, 63);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(170, 28);
            this.dtpBookingDate.TabIndex = 126;
            // 
            // dtpJourneyDate
            // 
            this.dtpJourneyDate.CustomFormat = "dd/MM/yyyy";
            this.dtpJourneyDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJourneyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJourneyDate.Location = new System.Drawing.Point(232, 152);
            this.dtpJourneyDate.Name = "dtpJourneyDate";
            this.dtpJourneyDate.Size = new System.Drawing.Size(170, 28);
            this.dtpJourneyDate.TabIndex = 127;
            // 
            // cbCustomerName
            // 
            this.cbCustomerName.DataSource = this.customerDetailsBindingSource;
            this.cbCustomerName.DisplayMember = "CustomerName";
            this.cbCustomerName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomerName.FormattingEnabled = true;
            this.cbCustomerName.Location = new System.Drawing.Point(260, 247);
            this.cbCustomerName.Name = "cbCustomerName";
            this.cbCustomerName.Size = new System.Drawing.Size(264, 28);
            this.cbCustomerName.TabIndex = 125;
            this.cbCustomerName.ValueMember = "CustomerId";
            // 
            // cbTravels
            // 
            this.cbTravels.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cbTravels.FormattingEnabled = true;
            this.cbTravels.Location = new System.Drawing.Point(271, 196);
            this.cbTravels.Name = "cbTravels";
            this.cbTravels.Size = new System.Drawing.Size(344, 33);
            this.cbTravels.TabIndex = 124;
            // 
            // btnSearchTravel
            // 
            this.btnSearchTravel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchTravel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchTravel.Image = global::TTMS.UI.Properties.Resources.icons8_magnifying_glass_30;
            this.btnSearchTravel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchTravel.Location = new System.Drawing.Point(624, 148);
            this.btnSearchTravel.Name = "btnSearchTravel";
            this.btnSearchTravel.Size = new System.Drawing.Size(243, 38);
            this.btnSearchTravel.TabIndex = 123;
            this.btnSearchTravel.Text = "SEARCH TRAVEL";
            this.btnSearchTravel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchTravel.UseVisualStyleBackColor = true;
            this.btnSearchTravel.Click += new System.EventHandler(this.btnSearchTravel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(434, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 25);
            this.label8.TabIndex = 119;
            this.label8.Text = "Destination To:";
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.Image = global::TTMS.UI.Properties.Resources.icons8_plus_40;
            this.btnAddPassenger.Location = new System.Drawing.Point(837, 61);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(42, 42);
            this.btnAddPassenger.TabIndex = 1;
            this.btnAddPassenger.UseVisualStyleBackColor = true;
            this.btnAddPassenger.Click += new System.EventHandler(this.btnAddPassenger_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(624, 133);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 3);
            this.panel6.TabIndex = 115;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(260, 275);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 3);
            this.panel4.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(56, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 120;
            this.label1.Text = "Available Travels:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(271, 229);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(344, 3);
            this.panel7.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(432, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 118;
            this.label3.Text = "Booking Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(57, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 117;
            this.label2.Text = "Journey Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(56, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 116;
            this.label7.Text = "Source From:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(224, 133);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 3);
            this.panel5.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(56, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 110;
            this.label4.Text = "Customer Name:";
            // 
            // dgvTravelBooking
            // 
            this.dgvTravelBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTravelBooking.Location = new System.Drawing.Point(27, 620);
            this.dgvTravelBooking.Name = "dgvTravelBooking";
            this.dgvTravelBooking.RowHeadersWidth = 51;
            this.dgvTravelBooking.RowTemplate.Height = 24;
            this.dgvTravelBooking.Size = new System.Drawing.Size(884, 159);
            this.dgvTravelBooking.TabIndex = 108;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(704, 572);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 39);
            this.btnDelete.TabIndex = 138;
            this.btnDelete.Text = "DELETE BOOKING";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(465, 572);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(206, 39);
            this.btnUpdate.TabIndex = 139;
            this.btnUpdate.Text = "UPDATE BOOKING";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(227, 572);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(215, 39);
            this.btnSave.TabIndex = 140;
            this.btnSave.Text = "BOOK THIS TRAVEL!!!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Location = new System.Drawing.Point(46, 572);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 39);
            this.btnAdd.TabIndex = 141;
            this.btnAdd.Text = "NEW BOOKING";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Image = global::TTMS.UI.Properties.Resources.icons8_plus_40;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(530, 241);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(42, 42);
            this.btnAddNewCustomer.TabIndex = 137;
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // lblPassengers
            // 
            this.lblPassengers.AutoSize = true;
            this.lblPassengers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPassengers.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassengers.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPassengers.Location = new System.Drawing.Point(802, 250);
            this.lblPassengers.MinimumSize = new System.Drawing.Size(65, 0);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPassengers.Size = new System.Drawing.Size(65, 25);
            this.lblPassengers.TabIndex = 136;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(583, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 25);
            this.label10.TabIndex = 135;
            this.label10.Text = "No of Passengers:";
            // 
            // lblFare
            // 
            this.lblFare.AutoSize = true;
            this.lblFare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFare.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblFare.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblFare.Location = new System.Drawing.Point(767, 296);
            this.lblFare.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblFare.Name = "lblFare";
            this.lblFare.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFare.Size = new System.Drawing.Size(100, 25);
            this.lblFare.TabIndex = 134;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDistance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblDistance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDistance.Location = new System.Drawing.Point(337, 296);
            this.lblDistance.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDistance.Size = new System.Drawing.Size(100, 25);
            this.lblDistance.TabIndex = 133;
            // 
            // lblTravelAvailability
            // 
            this.lblTravelAvailability.AutoSize = true;
            this.lblTravelAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTravelAvailability.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTravelAvailability.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTravelAvailability.Location = new System.Drawing.Point(767, 204);
            this.lblTravelAvailability.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblTravelAvailability.Name = "lblTravelAvailability";
            this.lblTravelAvailability.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTravelAvailability.Size = new System.Drawing.Size(100, 25);
            this.lblTravelAvailability.TabIndex = 132;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label13.Location = new System.Drawing.Point(494, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(267, 25);
            this.label13.TabIndex = 131;
            this.label13.Text = "Total Fare (inc Taxes):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(59, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 25);
            this.label11.TabIndex = 130;
            this.label11.Text = "Total Distance (in KM):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(618, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 25);
            this.label9.TabIndex = 129;
            this.label9.Text = "Availability:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.dgvParticipants);
            this.groupBox1.Controls.Add(this.btnDeletePassenger);
            this.groupBox1.Controls.Add(this.btnAddPassenger);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(25, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 225);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Passengers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(107, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 109;
            this.label5.Text = "Booking Id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(229, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 50);
            this.label6.TabIndex = 14;
            this.label6.Text = "TRAVEL BOOKING";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(896, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 39);
            this.btnClose.TabIndex = 15;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvParticipants
            // 
            this.dgvParticipants.AllowUserToAddRows = false;
            this.dgvParticipants.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvParticipants.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParticipants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAction,
            this.clmSRNO,
            this.clmName,
            this.clmAge,
            this.clmGender,
            this.clmPhoneNo,
            this.clmVerificationType,
            this.clmVerificationNumber});
            this.dgvParticipants.Location = new System.Drawing.Point(11, 35);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.RowHeadersVisible = false;
            this.dgvParticipants.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.dgvParticipants.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvParticipants.RowTemplate.Height = 24;
            this.dgvParticipants.Size = new System.Drawing.Size(819, 181);
            this.dgvParticipants.TabIndex = 4;
            // 
            // travelDetailDataSet
            // 
            this.travelDetailDataSet.DataSetName = "TravelDetailDataSet";
            this.travelDetailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDetailsBindingSource
            // 
            this.customerDetailsBindingSource.DataMember = "CustomerDetails";
            this.customerDetailsBindingSource.DataSource = this.travelDetailDataSet;
            // 
            // customerDetailsTableAdapter
            // 
            this.customerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // verificationDetailsDataSet
            // 
            this.verificationDetailsDataSet.DataSetName = "VerificationDetailsDataSet";
            this.verificationDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verificationDetailsDataSetBindingSource
            // 
            this.verificationDetailsDataSetBindingSource.DataSource = this.verificationDetailsDataSet;
            this.verificationDetailsDataSetBindingSource.Position = 0;
            // 
            // verificationDetailsBindingSource
            // 
            this.verificationDetailsBindingSource.DataMember = "VerificationDetails";
            this.verificationDetailsBindingSource.DataSource = this.verificationDetailsDataSetBindingSource;
            // 
            // verificationDetailsTableAdapter
            // 
            this.verificationDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // clmAction
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.clmAction.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmAction.HeaderText = "Action";
            this.clmAction.MinimumWidth = 6;
            this.clmAction.Name = "clmAction";
            this.clmAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmAction.Text = "DELETE";
            this.clmAction.UseColumnTextForButtonValue = true;
            this.clmAction.Width = 125;
            // 
            // clmSRNO
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmSRNO.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmSRNO.HeaderText = "Sr. No";
            this.clmSRNO.MinimumWidth = 6;
            this.clmSRNO.Name = "clmSRNO";
            this.clmSRNO.Width = 50;
            // 
            // clmName
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmName.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmName.HeaderText = "Name";
            this.clmName.MinimumWidth = 6;
            this.clmName.Name = "clmName";
            this.clmName.Width = 200;
            // 
            // clmAge
            // 
            this.clmAge.HeaderText = "Age";
            this.clmAge.MinimumWidth = 6;
            this.clmAge.Name = "clmAge";
            this.clmAge.Width = 75;
            // 
            // clmGender
            // 
            this.clmGender.HeaderText = "Gender";
            this.clmGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.clmGender.MinimumWidth = 6;
            this.clmGender.Name = "clmGender";
            this.clmGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmGender.Width = 110;
            // 
            // clmPhoneNo
            // 
            this.clmPhoneNo.HeaderText = "Phone No";
            this.clmPhoneNo.MinimumWidth = 6;
            this.clmPhoneNo.Name = "clmPhoneNo";
            this.clmPhoneNo.Width = 150;
            // 
            // clmVerificationType
            // 
            this.clmVerificationType.DataSource = this.verificationDetailsBindingSource;
            this.clmVerificationType.DisplayMember = "VerificationName";
            this.clmVerificationType.HeaderText = "Verification Type";
            this.clmVerificationType.MinimumWidth = 6;
            this.clmVerificationType.Name = "clmVerificationType";
            this.clmVerificationType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmVerificationType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmVerificationType.ValueMember = "VerificationId";
            this.clmVerificationType.Width = 150;
            // 
            // clmVerificationNumber
            // 
            this.clmVerificationNumber.HeaderText = "Verification No";
            this.clmVerificationNumber.MinimumWidth = 6;
            this.clmVerificationNumber.Name = "clmVerificationNumber";
            this.clmVerificationNumber.Width = 150;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(256, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(108, 3);
            this.panel3.TabIndex = 112;
            // 
            // tbBookingId
            // 
            this.tbBookingId.BackColor = System.Drawing.Color.White;
            this.tbBookingId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBookingId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookingId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbBookingId.Location = new System.Drawing.Point(256, 63);
            this.tbBookingId.Name = "tbBookingId";
            this.tbBookingId.ReadOnly = true;
            this.tbBookingId.Size = new System.Drawing.Size(108, 25);
            this.tbBookingId.TabIndex = 121;
            this.tbBookingId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbDestination
            // 
            this.cbDestination.DataSource = this.travelStopsBindingSource;
            this.cbDestination.DisplayMember = "StopName";
            this.cbDestination.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(624, 100);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(200, 33);
            this.cbDestination.TabIndex = 124;
            this.cbDestination.ValueMember = "StopId";
            // 
            // cbSource
            // 
            this.cbSource.DataSource = this.travelStopsBindingSource;
            this.cbSource.DisplayMember = "StopName";
            this.cbSource.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(224, 100);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(200, 33);
            this.cbSource.TabIndex = 124;
            this.cbSource.ValueMember = "StopId";
            // 
            // travelStopsBindingSource
            // 
            this.travelStopsBindingSource.DataMember = "TravelStops";
            this.travelStopsBindingSource.DataSource = this.travelDetailDataSet;
            // 
            // travelStopsTableAdapter
            // 
            this.travelStopsTableAdapter.ClearBeforeFill = true;
            // 
            // frmTravelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 793);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTravelBooking";
            this.Text = "frmTravelBooking";
            this.Load += new System.EventHandler(this.frmTravelBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravelBooking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDetailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelStopsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.DateTimePicker dtpJourneyDate;
        private System.Windows.Forms.ComboBox cbCustomerName;
        private System.Windows.Forms.ComboBox cbTravels;
        private System.Windows.Forms.Button btnSearchTravel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTravelBooking;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFare;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblTravelAvailability;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeletePassenger;
        private System.Windows.Forms.Button btnAddPassenger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvParticipants;
        private Dataset.TravelDetailDataSet travelDetailDataSet;
        private System.Windows.Forms.BindingSource customerDetailsBindingSource;
        private Dataset.TravelDetailDataSetTableAdapters.CustomerDetailsTableAdapter customerDetailsTableAdapter;
        private Dataset.VerificationDetailsDataSet verificationDetailsDataSet;
        private System.Windows.Forms.BindingSource verificationDetailsDataSetBindingSource;
        private System.Windows.Forms.BindingSource verificationDetailsBindingSource;
        private Dataset.VerificationDetailsDataSetTableAdapters.VerificationDetailsTableAdapter verificationDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn clmAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSRNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAge;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmVerificationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVerificationNumber;
        private System.Windows.Forms.TextBox tbBookingId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.BindingSource travelStopsBindingSource;
        private Dataset.TravelDetailDataSetTableAdapters.TravelStopsTableAdapter travelStopsTableAdapter;
    }
}