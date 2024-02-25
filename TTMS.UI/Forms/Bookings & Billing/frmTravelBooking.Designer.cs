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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTravelBooking));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpJourneyDate = new System.Windows.Forms.DateTimePicker();
            this.cbCustomerName = new System.Windows.Forms.ComboBox();
            this.customerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDetailDataSet = new TTMS.UI.Dataset.TravelDetailDataSet();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.travelStopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.cbTravels = new System.Windows.Forms.ComboBox();
            this.btnSearchTravel = new System.Windows.Forms.Button();
            this.tbBookingId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
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
            this.dgvParticipants = new System.Windows.Forms.DataGridView();
            this.clmAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmSRNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVerificationType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.verificationDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verificationDetailsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verificationDetailsDataSet = new TTMS.UI.Dataset.VerificationDetailsDataSet();
            this.clmVerificationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeletePassenger = new System.Windows.Forms.Button();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.customerDetailsTableAdapter = new TTMS.UI.Dataset.TravelDetailDataSetTableAdapters.CustomerDetailsTableAdapter();
            this.verificationDetailsTableAdapter = new TTMS.UI.Dataset.VerificationDetailsDataSetTableAdapters.VerificationDetailsTableAdapter();
            this.travelStopsTableAdapter = new TTMS.UI.Dataset.TravelDetailDataSetTableAdapters.TravelStopsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDetailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelStopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravelBooking)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 778);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtpBookingDate);
            this.panel3.Controls.Add(this.dtpJourneyDate);
            this.panel3.Controls.Add(this.cbCustomerName);
            this.panel3.Controls.Add(this.cbSource);
            this.panel3.Controls.Add(this.cbDestination);
            this.panel3.Controls.Add(this.cbTravels);
            this.panel3.Controls.Add(this.btnSearchTravel);
            this.panel3.Controls.Add(this.tbBookingId);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.panel11);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dgvTravelBooking);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnAddNewCustomer);
            this.panel3.Controls.Add(this.lblPassengers);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lblFare);
            this.panel3.Controls.Add(this.lblDistance);
            this.panel3.Controls.Add(this.lblTravelAvailability);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1105, 727);
            this.panel3.TabIndex = 1;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBookingDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingDate.Location = new System.Drawing.Point(518, 18);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(170, 28);
            this.dtpBookingDate.TabIndex = 161;
            // 
            // dtpJourneyDate
            // 
            this.dtpJourneyDate.CustomFormat = "dd/MM/yyyy";
            this.dtpJourneyDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJourneyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJourneyDate.Location = new System.Drawing.Point(901, 18);
            this.dtpJourneyDate.Name = "dtpJourneyDate";
            this.dtpJourneyDate.Size = new System.Drawing.Size(170, 28);
            this.dtpJourneyDate.TabIndex = 162;
            // 
            // cbCustomerName
            // 
            this.cbCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCustomerName.DataSource = this.customerDetailsBindingSource;
            this.cbCustomerName.DisplayMember = "CustomerName";
            this.cbCustomerName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomerName.FormattingEnabled = true;
            this.cbCustomerName.Location = new System.Drawing.Point(222, 184);
            this.cbCustomerName.Name = "cbCustomerName";
            this.cbCustomerName.Size = new System.Drawing.Size(264, 28);
            this.cbCustomerName.TabIndex = 160;
            this.cbCustomerName.ValueMember = "CustomerId";
            // 
            // customerDetailsBindingSource
            // 
            this.customerDetailsBindingSource.DataMember = "CustomerDetails";
            this.customerDetailsBindingSource.DataSource = this.travelDetailDataSet;
            // 
            // travelDetailDataSet
            // 
            this.travelDetailDataSet.DataSetName = "TravelDetailDataSet";
            this.travelDetailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbSource
            // 
            this.cbSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSource.DataSource = this.travelStopsBindingSource;
            this.cbSource.DisplayMember = "StopName";
            this.cbSource.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Location = new System.Drawing.Point(186, 64);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(200, 33);
            this.cbSource.TabIndex = 158;
            this.cbSource.ValueMember = "StopId";
            // 
            // travelStopsBindingSource
            // 
            this.travelStopsBindingSource.DataMember = "TravelStops";
            this.travelStopsBindingSource.DataSource = this.travelDetailDataSet;
            // 
            // cbDestination
            // 
            this.cbDestination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDestination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDestination.DataSource = this.travelStopsBindingSource;
            this.cbDestination.DisplayMember = "StopName";
            this.cbDestination.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(586, 64);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(200, 33);
            this.cbDestination.TabIndex = 159;
            this.cbDestination.ValueMember = "StopId";
            // 
            // cbTravels
            // 
            this.cbTravels.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cbTravels.FormattingEnabled = true;
            this.cbTravels.Location = new System.Drawing.Point(233, 124);
            this.cbTravels.Name = "cbTravels";
            this.cbTravels.Size = new System.Drawing.Size(455, 33);
            this.cbTravels.TabIndex = 157;
            // 
            // btnSearchTravel
            // 
            this.btnSearchTravel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchTravel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchTravel.Image = global::TTMS.UI.Properties.Resources.magnifying_glass_30px;
            this.btnSearchTravel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchTravel.Location = new System.Drawing.Point(828, 62);
            this.btnSearchTravel.Name = "btnSearchTravel";
            this.btnSearchTravel.Size = new System.Drawing.Size(243, 38);
            this.btnSearchTravel.TabIndex = 156;
            this.btnSearchTravel.Text = "SEARCH TRAVEL";
            this.btnSearchTravel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchTravel.UseVisualStyleBackColor = true;
            // 
            // tbBookingId
            // 
            this.tbBookingId.BackColor = System.Drawing.Color.White;
            this.tbBookingId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBookingId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookingId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbBookingId.Location = new System.Drawing.Point(167, 18);
            this.tbBookingId.Name = "tbBookingId";
            this.tbBookingId.ReadOnly = true;
            this.tbBookingId.Size = new System.Drawing.Size(108, 25);
            this.tbBookingId.TabIndex = 155;
            this.tbBookingId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(396, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 25);
            this.label8.TabIndex = 153;
            this.label8.Text = "Destination To:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(586, 97);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 3);
            this.panel7.TabIndex = 149;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(222, 212);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(264, 3);
            this.panel8.TabIndex = 148;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(18, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 154;
            this.label1.Text = "Available Travels:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(233, 157);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(455, 3);
            this.panel9.TabIndex = 147;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(343, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 152;
            this.label3.Text = "Booking Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(726, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 151;
            this.label2.Text = "Journey Date:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(167, 46);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(108, 3);
            this.panel10.TabIndex = 145;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(18, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 150;
            this.label7.Text = "Source From:";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(186, 97);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 3);
            this.panel11.TabIndex = 146;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(18, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 144;
            this.label4.Text = "Customer Name:";
            // 
            // dgvTravelBooking
            // 
            this.dgvTravelBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTravelBooking.Location = new System.Drawing.Point(12, 556);
            this.dgvTravelBooking.Name = "dgvTravelBooking";
            this.dgvTravelBooking.RowHeadersWidth = 51;
            this.dgvTravelBooking.RowTemplate.Height = 24;
            this.dgvTravelBooking.Size = new System.Drawing.Size(1081, 159);
            this.dgvTravelBooking.TabIndex = 142;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(783, 511);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 39);
            this.btnDelete.TabIndex = 173;
            this.btnDelete.Text = "DELETE BOOKING";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(544, 511);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(206, 39);
            this.btnUpdate.TabIndex = 174;
            this.btnUpdate.Text = "UPDATE BOOKING";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(306, 511);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(215, 39);
            this.btnSave.TabIndex = 175;
            this.btnSave.Text = "BOOK THIS TRAVEL!!!";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Location = new System.Drawing.Point(125, 511);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 39);
            this.btnAdd.TabIndex = 176;
            this.btnAdd.Text = "NEW BOOKING";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAddNewCustomer.Image = global::TTMS.UI.Properties.Resources.plus_button_40px;
            this.btnAddNewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(505, 176);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(107, 45);
            this.btnAddNewCustomer.TabIndex = 172;
            this.btnAddNewCustomer.Text = "ADD";
            this.btnAddNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            // 
            // lblPassengers
            // 
            this.lblPassengers.AutoSize = true;
            this.lblPassengers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPassengers.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassengers.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPassengers.Location = new System.Drawing.Point(945, 186);
            this.lblPassengers.MinimumSize = new System.Drawing.Size(65, 0);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPassengers.Size = new System.Drawing.Size(65, 25);
            this.lblPassengers.TabIndex = 171;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(726, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 25);
            this.label10.TabIndex = 170;
            this.label10.Text = "No of Passengers:";
            // 
            // lblFare
            // 
            this.lblFare.AutoSize = true;
            this.lblFare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFare.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblFare.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblFare.Location = new System.Drawing.Point(944, 239);
            this.lblFare.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblFare.Name = "lblFare";
            this.lblFare.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFare.Size = new System.Drawing.Size(100, 25);
            this.lblFare.TabIndex = 169;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDistance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblDistance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDistance.Location = new System.Drawing.Point(296, 239);
            this.lblDistance.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDistance.Size = new System.Drawing.Size(100, 25);
            this.lblDistance.TabIndex = 168;
            // 
            // lblTravelAvailability
            // 
            this.lblTravelAvailability.AutoSize = true;
            this.lblTravelAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTravelAvailability.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTravelAvailability.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTravelAvailability.Location = new System.Drawing.Point(875, 132);
            this.lblTravelAvailability.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblTravelAvailability.Name = "lblTravelAvailability";
            this.lblTravelAvailability.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTravelAvailability.Size = new System.Drawing.Size(100, 25);
            this.lblTravelAvailability.TabIndex = 167;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label13.Location = new System.Drawing.Point(671, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(267, 25);
            this.label13.TabIndex = 166;
            this.label13.Text = "Total Fare (inc Taxes):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(18, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 25);
            this.label11.TabIndex = 165;
            this.label11.Text = "Total Distance (in KM):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(726, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 25);
            this.label9.TabIndex = 164;
            this.label9.Text = "Availability:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.dgvParticipants);
            this.groupBox1.Controls.Add(this.btnDeletePassenger);
            this.groupBox1.Controls.Add(this.btnAddPassenger);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 225);
            this.groupBox1.TabIndex = 163;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Passengers";
            // 
            // dgvParticipants
            // 
            this.dgvParticipants.AllowUserToAddRows = false;
            this.dgvParticipants.BackgroundColor = System.Drawing.Color.White;
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
            this.dgvParticipants.Size = new System.Drawing.Size(1013, 181);
            this.dgvParticipants.TabIndex = 4;
            this.dgvParticipants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipants_CellContentClick);
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
            // verificationDetailsBindingSource
            // 
            this.verificationDetailsBindingSource.DataMember = "VerificationDetails";
            this.verificationDetailsBindingSource.DataSource = this.verificationDetailsDataSetBindingSource;
            // 
            // verificationDetailsDataSetBindingSource
            // 
            this.verificationDetailsDataSetBindingSource.DataSource = this.verificationDetailsDataSet;
            this.verificationDetailsDataSetBindingSource.Position = 0;
            // 
            // verificationDetailsDataSet
            // 
            this.verificationDetailsDataSet.DataSetName = "VerificationDetailsDataSet";
            this.verificationDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clmVerificationNumber
            // 
            this.clmVerificationNumber.HeaderText = "Verification No";
            this.clmVerificationNumber.MinimumWidth = 6;
            this.clmVerificationNumber.Name = "clmVerificationNumber";
            this.clmVerificationNumber.Width = 150;
            // 
            // btnDeletePassenger
            // 
            this.btnDeletePassenger.Image = global::TTMS.UI.Properties.Resources.Dustbin_40px;
            this.btnDeletePassenger.Location = new System.Drawing.Point(1030, 140);
            this.btnDeletePassenger.Name = "btnDeletePassenger";
            this.btnDeletePassenger.Size = new System.Drawing.Size(42, 42);
            this.btnDeletePassenger.TabIndex = 2;
            this.btnDeletePassenger.UseVisualStyleBackColor = true;
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.Image = global::TTMS.UI.Properties.Resources.plus_button_40px;
            this.btnAddPassenger.Location = new System.Drawing.Point(1030, 66);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(42, 42);
            this.btnAddPassenger.TabIndex = 1;
            this.btnAddPassenger.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(18, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 143;
            this.label5.Text = "Booking Id:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 722);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1099, 5);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1102, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 727);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 727);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 51);
            this.panel2.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1060, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 39);
            this.btnClose.TabIndex = 15;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            // customerDetailsTableAdapter
            // 
            this.customerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // verificationDetailsTableAdapter
            // 
            this.verificationDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // travelStopsTableAdapter
            // 
            this.travelStopsTableAdapter.ClearBeforeFill = true;
            // 
            // frmTravelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 778);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTravelBooking";
            this.Text = "frmTravelBooking";
            this.Load += new System.EventHandler(this.frmTravelBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDetailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelStopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravelBooking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private Dataset.TravelDetailDataSet travelDetailDataSet;
        private System.Windows.Forms.BindingSource customerDetailsBindingSource;
        private Dataset.TravelDetailDataSetTableAdapters.CustomerDetailsTableAdapter customerDetailsTableAdapter;
        private Dataset.VerificationDetailsDataSet verificationDetailsDataSet;
        private System.Windows.Forms.BindingSource verificationDetailsDataSetBindingSource;
        private System.Windows.Forms.BindingSource verificationDetailsBindingSource;
        private Dataset.VerificationDetailsDataSetTableAdapters.VerificationDetailsTableAdapter verificationDetailsTableAdapter;
        private System.Windows.Forms.BindingSource travelStopsBindingSource;
        private Dataset.TravelDetailDataSetTableAdapters.TravelStopsTableAdapter travelStopsTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.DateTimePicker dtpJourneyDate;
        private System.Windows.Forms.ComboBox cbCustomerName;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.ComboBox cbTravels;
        private System.Windows.Forms.Button btnSearchTravel;
        private System.Windows.Forms.TextBox tbBookingId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel11;
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
        private System.Windows.Forms.DataGridView dgvParticipants;
        private System.Windows.Forms.DataGridViewButtonColumn clmAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSRNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAge;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmVerificationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVerificationNumber;
        private System.Windows.Forms.Button btnDeletePassenger;
        private System.Windows.Forms.Button btnAddPassenger;
        private System.Windows.Forms.Label label5;
    }
}