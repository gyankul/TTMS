namespace TTMS.UI
{
    partial class formTravelBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTravelBooking));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.lblPassengers = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFare = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTravelAvailability = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTourItinerary = new System.Windows.Forms.DataGridView();
            this.clmItineraryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDayNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDeletePassenger = new System.Windows.Forms.Button();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.dtpJourneyDate = new System.Windows.Forms.DateTimePicker();
            this.cbCustomerName = new System.Windows.Forms.ComboBox();
            this.cbTravels = new System.Windows.Forms.ComboBox();
            this.btnSearchTravel = new System.Windows.Forms.Button();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbSource = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDestinationId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelVehicleLayout = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.lblTotal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourItinerary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1265, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 39);
            this.btnClose.TabIndex = 14;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(423, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 50);
            this.label6.TabIndex = 13;
            this.label6.Text = "TRAVEL BOOKING";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.panelVehicleLayout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1308, 750);
            this.panel2.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Controls.Add(this.btnDelete);
            this.lblTotal.Controls.Add(this.btnUpdate);
            this.lblTotal.Controls.Add(this.btnSave);
            this.lblTotal.Controls.Add(this.btnAdd);
            this.lblTotal.Controls.Add(this.btnAddNewCustomer);
            this.lblTotal.Controls.Add(this.lblPassengers);
            this.lblTotal.Controls.Add(this.label10);
            this.lblTotal.Controls.Add(this.lblFare);
            this.lblTotal.Controls.Add(this.label12);
            this.lblTotal.Controls.Add(this.lblTravelAvailability);
            this.lblTotal.Controls.Add(this.label13);
            this.lblTotal.Controls.Add(this.label11);
            this.lblTotal.Controls.Add(this.label9);
            this.lblTotal.Controls.Add(this.groupBox1);
            this.lblTotal.Controls.Add(this.dtpBookingDate);
            this.lblTotal.Controls.Add(this.dtpJourneyDate);
            this.lblTotal.Controls.Add(this.cbCustomerName);
            this.lblTotal.Controls.Add(this.cbTravels);
            this.lblTotal.Controls.Add(this.btnSearchTravel);
            this.lblTotal.Controls.Add(this.tbDestination);
            this.lblTotal.Controls.Add(this.tbSource);
            this.lblTotal.Controls.Add(this.label8);
            this.lblTotal.Controls.Add(this.panel6);
            this.lblTotal.Controls.Add(this.panel4);
            this.lblTotal.Controls.Add(this.label1);
            this.lblTotal.Controls.Add(this.panel7);
            this.lblTotal.Controls.Add(this.label3);
            this.lblTotal.Controls.Add(this.label2);
            this.lblTotal.Controls.Add(this.label7);
            this.lblTotal.Controls.Add(this.panel5);
            this.lblTotal.Controls.Add(this.lblDestinationId);
            this.lblTotal.Controls.Add(this.label4);
            this.lblTotal.Controls.Add(this.label5);
            this.lblTotal.Controls.Add(this.dataGridView1);
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Location = new System.Drawing.Point(400, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(908, 750);
            this.lblTotal.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(687, 516);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 39);
            this.btnDelete.TabIndex = 70;
            this.btnDelete.Text = "DELETE BOOKING";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(448, 516);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(206, 39);
            this.btnUpdate.TabIndex = 71;
            this.btnUpdate.Text = "UPDATE BOOKING";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(210, 516);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(215, 39);
            this.btnSave.TabIndex = 72;
            this.btnSave.Text = "BOOK THIS TRAVEL!!!";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Location = new System.Drawing.Point(29, 516);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 39);
            this.btnAdd.TabIndex = 73;
            this.btnAdd.Text = "NEW BOOKING";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Location = new System.Drawing.Point(480, 192);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(42, 42);
            this.btnAddNewCustomer.TabIndex = 69;
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            // 
            // lblPassengers
            // 
            this.lblPassengers.AutoSize = true;
            this.lblPassengers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPassengers.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassengers.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPassengers.Location = new System.Drawing.Point(752, 201);
            this.lblPassengers.MinimumSize = new System.Drawing.Size(65, 0);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPassengers.Size = new System.Drawing.Size(65, 25);
            this.lblPassengers.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(533, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(215, 25);
            this.label10.TabIndex = 62;
            this.label10.Text = "No of Passengers:";
            // 
            // lblFare
            // 
            this.lblFare.AutoSize = true;
            this.lblFare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFare.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblFare.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblFare.Location = new System.Drawing.Point(717, 247);
            this.lblFare.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblFare.Name = "lblFare";
            this.lblFare.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFare.Size = new System.Drawing.Size(100, 25);
            this.lblFare.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(287, 247);
            this.label12.MinimumSize = new System.Drawing.Size(100, 0);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(100, 25);
            this.label12.TabIndex = 61;
            // 
            // lblTravelAvailability
            // 
            this.lblTravelAvailability.AutoSize = true;
            this.lblTravelAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTravelAvailability.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTravelAvailability.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTravelAvailability.Location = new System.Drawing.Point(717, 155);
            this.lblTravelAvailability.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblTravelAvailability.Name = "lblTravelAvailability";
            this.lblTravelAvailability.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTravelAvailability.Size = new System.Drawing.Size(100, 25);
            this.lblTravelAvailability.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label13.Location = new System.Drawing.Point(444, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(267, 25);
            this.label13.TabIndex = 60;
            this.label13.Text = "Total Fare (inc Taxes):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(9, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 25);
            this.label11.TabIndex = 60;
            this.label11.Text = "Total Distance (in KM):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(568, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 25);
            this.label9.TabIndex = 60;
            this.label9.Text = "Availability:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.dgvTourItinerary);
            this.groupBox1.Controls.Add(this.btnDeletePassenger);
            this.groupBox1.Controls.Add(this.btnAddPassenger);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(8, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 225);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Passengers";
            // 
            // dgvTourItinerary
            // 
            this.dgvTourItinerary.BackgroundColor = System.Drawing.Color.White;
            this.dgvTourItinerary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTourItinerary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTourItinerary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourItinerary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmItineraryName,
            this.clmDayNo,
            this.clmActivity,
            this.clmSDT,
            this.clmEDT,
            this.clmImage,
            this.Column5});
            this.dgvTourItinerary.Location = new System.Drawing.Point(6, 31);
            this.dgvTourItinerary.Name = "dgvTourItinerary";
            this.dgvTourItinerary.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.dgvTourItinerary.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTourItinerary.RowTemplate.Height = 24;
            this.dgvTourItinerary.Size = new System.Drawing.Size(830, 188);
            this.dgvTourItinerary.TabIndex = 24;
            // 
            // clmItineraryName
            // 
            this.clmItineraryName.HeaderText = "Itinerary Name";
            this.clmItineraryName.MinimumWidth = 6;
            this.clmItineraryName.Name = "clmItineraryName";
            this.clmItineraryName.Width = 190;
            // 
            // clmDayNo
            // 
            this.clmDayNo.HeaderText = "Day No";
            this.clmDayNo.MinimumWidth = 6;
            this.clmDayNo.Name = "clmDayNo";
            this.clmDayNo.Width = 50;
            // 
            // clmActivity
            // 
            this.clmActivity.HeaderText = "Activities";
            this.clmActivity.MinimumWidth = 6;
            this.clmActivity.Name = "clmActivity";
            this.clmActivity.Width = 250;
            // 
            // clmSDT
            // 
            this.clmSDT.HeaderText = "StartDateTime";
            this.clmSDT.MinimumWidth = 6;
            this.clmSDT.Name = "clmSDT";
            this.clmSDT.Width = 155;
            // 
            // clmEDT
            // 
            this.clmEDT.HeaderText = "EndDateTime";
            this.clmEDT.MinimumWidth = 6;
            this.clmEDT.Name = "clmEDT";
            this.clmEDT.Width = 155;
            // 
            // clmImage
            // 
            this.clmImage.HeaderText = "Image";
            this.clmImage.MinimumWidth = 6;
            this.clmImage.Name = "clmImage";
            this.clmImage.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Action";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // btnDeletePassenger
            // 
            this.btnDeletePassenger.Location = new System.Drawing.Point(842, 145);
            this.btnDeletePassenger.Name = "btnDeletePassenger";
            this.btnDeletePassenger.Size = new System.Drawing.Size(42, 42);
            this.btnDeletePassenger.TabIndex = 2;
            this.btnDeletePassenger.UseVisualStyleBackColor = true;
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.Location = new System.Drawing.Point(842, 61);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(42, 42);
            this.btnAddPassenger.TabIndex = 1;
            this.btnAddPassenger.UseVisualStyleBackColor = true;
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBookingDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingDate.Location = new System.Drawing.Point(506, 14);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(170, 28);
            this.dtpBookingDate.TabIndex = 33;
            // 
            // dtpJourneyDate
            // 
            this.dtpJourneyDate.CustomFormat = "dd/MM/yyyy";
            this.dtpJourneyDate.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpJourneyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJourneyDate.Location = new System.Drawing.Point(182, 103);
            this.dtpJourneyDate.Name = "dtpJourneyDate";
            this.dtpJourneyDate.Size = new System.Drawing.Size(170, 28);
            this.dtpJourneyDate.TabIndex = 33;
            // 
            // cbCustomerName
            // 
            this.cbCustomerName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomerName.FormattingEnabled = true;
            this.cbCustomerName.Location = new System.Drawing.Point(210, 198);
            this.cbCustomerName.Name = "cbCustomerName";
            this.cbCustomerName.Size = new System.Drawing.Size(264, 28);
            this.cbCustomerName.TabIndex = 32;
            // 
            // cbTravels
            // 
            this.cbTravels.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cbTravels.FormattingEnabled = true;
            this.cbTravels.Location = new System.Drawing.Point(221, 147);
            this.cbTravels.Name = "cbTravels";
            this.cbTravels.Size = new System.Drawing.Size(344, 33);
            this.cbTravels.TabIndex = 32;
            this.cbTravels.SelectedIndexChanged += new System.EventHandler(this.cbTravels_SelectedIndexChanged);
            // 
            // btnSearchTravel
            // 
            this.btnSearchTravel.Location = new System.Drawing.Point(775, 94);
            this.btnSearchTravel.Name = "btnSearchTravel";
            this.btnSearchTravel.Size = new System.Drawing.Size(42, 38);
            this.btnSearchTravel.TabIndex = 31;
            this.btnSearchTravel.UseVisualStyleBackColor = true;
            // 
            // tbDestination
            // 
            this.tbDestination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDestination.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestination.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbDestination.Location = new System.Drawing.Point(574, 56);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(200, 25);
            this.tbDestination.TabIndex = 30;
            this.tbDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSource
            // 
            this.tbSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSource.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSource.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbSource.Location = new System.Drawing.Point(174, 56);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(200, 25);
            this.tbSource.TabIndex = 30;
            this.tbSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(384, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Destination To:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(574, 84);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 3);
            this.panel6.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(210, 226);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 3);
            this.panel4.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(6, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Available Travels:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(221, 180);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(344, 3);
            this.panel7.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(331, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Booking Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(7, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Journey Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(6, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Source From:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(174, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 3);
            this.panel5.TabIndex = 28;
            // 
            // lblDestinationId
            // 
            this.lblDestinationId.AutoSize = true;
            this.lblDestinationId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDestinationId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblDestinationId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDestinationId.Location = new System.Drawing.Point(155, 16);
            this.lblDestinationId.Name = "lblDestinationId";
            this.lblDestinationId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDestinationId.Size = new System.Drawing.Size(82, 25);
            this.lblDestinationId.TabIndex = 27;
            this.lblDestinationId.Text = "          ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(6, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Customer Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Booking Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 571);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(884, 159);
            this.dataGridView1.TabIndex = 22;
            // 
            // panelVehicleLayout
            // 
            this.panelVehicleLayout.BackColor = System.Drawing.Color.Gainsboro;
            this.panelVehicleLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVehicleLayout.Location = new System.Drawing.Point(0, 0);
            this.panelVehicleLayout.Name = "panelVehicleLayout";
            this.panelVehicleLayout.Size = new System.Drawing.Size(400, 750);
            this.panelVehicleLayout.TabIndex = 5;
            // 
            // frmTravelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1308, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTravelBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelBooking";
            this.Load += new System.EventHandler(this.TravelBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.lblTotal.ResumeLayout(false);
            this.lblTotal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourItinerary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel lblTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelVehicleLayout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDestinationId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSearchTravel;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker dtpJourneyDate;
        private System.Windows.Forms.ComboBox cbTravels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeletePassenger;
        private System.Windows.Forms.Button btnAddPassenger;
        private System.Windows.Forms.DataGridView dgvTourItinerary;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItineraryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDayNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImage;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTravelAvailability;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCustomerName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblFare;
        private System.Windows.Forms.Label label13;
    }
}