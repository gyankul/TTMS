namespace TTMS.UI
{
    partial class frmTourBooking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddPackage = new System.Windows.Forms.Button();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.dgvTourBooking = new System.Windows.Forms.DataGridView();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.customerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourDataSet = new TTMS.UI.Dataset.TourDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblParticipants = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTourAvailability = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpBookingDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvParticipants = new System.Windows.Forms.DataGridView();
            this.clmAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVerificationType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.verificationDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.verificationDetailsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verificationDetailsDataSet = new TTMS.UI.Dataset.VerificationDetailsDataSet();
            this.clmVerificationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteParticipant = new System.Windows.Forms.Button();
            this.btnAddParticipant = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbBookingId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPackageName = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTourBookingTitlebar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.verificationDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDetailsTableAdapter = new TTMS.UI.Dataset.TourDataSetTableAdapters.CustomerDetailsTableAdapter();
            this.verificationDetailsTableAdapter = new TTMS.UI.Dataset.VerificationDetailsDataSetTableAdapters.VerificationDetailsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsDataSet)).BeginInit();
            this.panelTourBookingTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAddPackage);
            this.panel1.Controls.Add(this.btnAddNewCustomer);
            this.panel1.Controls.Add(this.dgvTourBooking);
            this.panel1.Controls.Add(this.cbCustomer);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblParticipants);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblTourAvailability);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpBookingDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.tbBookingId);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tbPackageName);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelTourBookingTitlebar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 715);
            this.panel1.TabIndex = 0;
            // 
            // btnAddPackage
            // 
            this.btnAddPackage.Image = global::TTMS.UI.Properties.Resources.icons8_plus_40;
            this.btnAddPackage.Location = new System.Drawing.Point(496, 106);
            this.btnAddPackage.Name = "btnAddPackage";
            this.btnAddPackage.Size = new System.Drawing.Size(42, 42);
            this.btnAddPackage.TabIndex = 69;
            this.btnAddPackage.UseVisualStyleBackColor = true;
            this.btnAddPackage.Click += new System.EventHandler(this.btnAddPackage_Click);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Image = global::TTMS.UI.Properties.Resources.icons8_plus_40;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(534, 154);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(42, 42);
            this.btnAddNewCustomer.TabIndex = 68;
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // dgvTourBooking
            // 
            this.dgvTourBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTourBooking.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTourBooking.Location = new System.Drawing.Point(17, 444);
            this.dgvTourBooking.Name = "dgvTourBooking";
            this.dgvTourBooking.RowHeadersWidth = 51;
            this.dgvTourBooking.RowTemplate.Height = 24;
            this.dgvTourBooking.Size = new System.Drawing.Size(958, 197);
            this.dgvTourBooking.TabIndex = 67;
            // 
            // cbCustomer
            // 
            this.cbCustomer.DataSource = this.customerDetailsBindingSource;
            this.cbCustomer.DisplayMember = "CustomerName";
            this.cbCustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(216, 158);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(313, 33);
            this.cbCustomer.TabIndex = 66;
            this.cbCustomer.ValueMember = "CustomerId";
            // 
            // customerDetailsBindingSource
            // 
            this.customerDetailsBindingSource.DataMember = "CustomerDetails";
            this.customerDetailsBindingSource.DataSource = this.tourDataSet;
            // 
            // tourDataSet
            // 
            this.tourDataSet.DataSetName = "TourDataSet";
            this.tourDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(767, 657);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 41);
            this.btnDelete.TabIndex = 62;
            this.btnDelete.Text = "DELETE BOOKING";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(505, 657);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(219, 41);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "UPDATE BOOKING";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(262, 657);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 41);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "BOOK THIS TOUR!!!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Location = new System.Drawing.Point(33, 657);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(186, 41);
            this.btnAdd.TabIndex = 65;
            this.btnAdd.Text = "NEW BOOKING";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblParticipants
            // 
            this.lblParticipants.AutoSize = true;
            this.lblParticipants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblParticipants.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblParticipants.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblParticipants.Location = new System.Drawing.Point(846, 163);
            this.lblParticipants.MinimumSize = new System.Drawing.Size(86, 0);
            this.lblParticipants.Name = "lblParticipants";
            this.lblParticipants.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblParticipants.Size = new System.Drawing.Size(86, 25);
            this.lblParticipants.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(618, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 25);
            this.label9.TabIndex = 60;
            this.label9.Text = "No of Participants:";
            // 
            // lblTourAvailability
            // 
            this.lblTourAvailability.AutoSize = true;
            this.lblTourAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTourAvailability.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblTourAvailability.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTourAvailability.Location = new System.Drawing.Point(767, 115);
            this.lblTourAvailability.MinimumSize = new System.Drawing.Size(165, 0);
            this.lblTourAvailability.Name = "lblTourAvailability";
            this.lblTourAvailability.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTourAvailability.Size = new System.Drawing.Size(165, 25);
            this.lblTourAvailability.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(618, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 58;
            this.label7.Text = "Availability:";
            // 
            // dtpBookingDate
            // 
            this.dtpBookingDate.CustomFormat = "dd/MM/yyyy ";
            this.dtpBookingDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.dtpBookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBookingDate.Location = new System.Drawing.Point(645, 68);
            this.dtpBookingDate.Name = "dtpBookingDate";
            this.dtpBookingDate.Size = new System.Drawing.Size(205, 32);
            this.dtpBookingDate.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(479, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Booking Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvParticipants);
            this.groupBox1.Controls.Add(this.btnDeleteParticipant);
            this.groupBox1.Controls.Add(this.btnAddParticipant);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(17, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 225);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Participants";
            // 
            // dgvParticipants
            // 
            this.dgvParticipants.AllowUserToAddRows = false;
            this.dgvParticipants.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvParticipants.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParticipants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAction,
            this.clmSerialNo,
            this.clmName,
            this.clmAge,
            this.clmGender,
            this.clmPhoneNo,
            this.clmVerificationType,
            this.clmVerificationNumber});
            this.dgvParticipants.Location = new System.Drawing.Point(16, 31);
            this.dgvParticipants.Name = "dgvParticipants";
            this.dgvParticipants.RowHeadersVisible = false;
            this.dgvParticipants.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.dgvParticipants.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvParticipants.RowTemplate.Height = 24;
            this.dgvParticipants.Size = new System.Drawing.Size(888, 181);
            this.dgvParticipants.TabIndex = 3;
            this.dgvParticipants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParticipants_CellContentClick_1);
            // 
            // clmAction
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.clmAction.DefaultCellStyle = dataGridViewCellStyle9;
            this.clmAction.HeaderText = "Action";
            this.clmAction.MinimumWidth = 6;
            this.clmAction.Name = "clmAction";
            this.clmAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmAction.Text = "DELETE";
            this.clmAction.UseColumnTextForButtonValue = true;
            this.clmAction.Width = 125;
            // 
            // clmSerialNo
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmSerialNo.DefaultCellStyle = dataGridViewCellStyle10;
            this.clmSerialNo.HeaderText = "Sr. No";
            this.clmSerialNo.MinimumWidth = 6;
            this.clmSerialNo.Name = "clmSerialNo";
            this.clmSerialNo.Width = 50;
            // 
            // clmName
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmName.DefaultCellStyle = dataGridViewCellStyle11;
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
            this.clmGender.MinimumWidth = 6;
            this.clmGender.Name = "clmGender";
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
            this.clmVerificationType.DataSource = this.verificationDetailsBindingSource1;
            this.clmVerificationType.DisplayMember = "VerificationName";
            this.clmVerificationType.HeaderText = "Verification Type";
            this.clmVerificationType.MinimumWidth = 6;
            this.clmVerificationType.Name = "clmVerificationType";
            this.clmVerificationType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmVerificationType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmVerificationType.ValueMember = "VerificationId";
            this.clmVerificationType.Width = 150;
            // 
            // verificationDetailsBindingSource1
            // 
            this.verificationDetailsBindingSource1.DataMember = "VerificationDetails";
            this.verificationDetailsBindingSource1.DataSource = this.verificationDetailsDataSetBindingSource;
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
            // btnDeleteParticipant
            // 
            this.btnDeleteParticipant.Image = global::TTMS.UI.Properties.Resources.icons8_remove_401;
            this.btnDeleteParticipant.Location = new System.Drawing.Point(912, 138);
            this.btnDeleteParticipant.Name = "btnDeleteParticipant";
            this.btnDeleteParticipant.Size = new System.Drawing.Size(42, 42);
            this.btnDeleteParticipant.TabIndex = 2;
            this.btnDeleteParticipant.UseVisualStyleBackColor = true;
            this.btnDeleteParticipant.Click += new System.EventHandler(this.btnDeleteParticipant_Click);
            // 
            // btnAddParticipant
            // 
            this.btnAddParticipant.Image = global::TTMS.UI.Properties.Resources.icons8_plus_40;
            this.btnAddParticipant.Location = new System.Drawing.Point(912, 54);
            this.btnAddParticipant.Name = "btnAddParticipant";
            this.btnAddParticipant.Size = new System.Drawing.Size(42, 42);
            this.btnAddParticipant.TabIndex = 1;
            this.btnAddParticipant.UseVisualStyleBackColor = true;
            this.btnAddParticipant.Click += new System.EventHandler(this.btnAddParticipant_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Customer Name:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(216, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 3);
            this.panel4.TabIndex = 49;
            // 
            // tbBookingId
            // 
            this.tbBookingId.BackColor = System.Drawing.Color.White;
            this.tbBookingId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBookingId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookingId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbBookingId.Location = new System.Drawing.Point(228, 68);
            this.tbBookingId.Name = "tbBookingId";
            this.tbBookingId.Size = new System.Drawing.Size(145, 25);
            this.tbBookingId.TabIndex = 46;
            this.tbBookingId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(228, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 3);
            this.panel2.TabIndex = 45;
            // 
            // tbPackageName
            // 
            this.tbPackageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPackageName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPackageName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPackageName.Location = new System.Drawing.Point(202, 115);
            this.tbPackageName.Name = "tbPackageName";
            this.tbPackageName.Size = new System.Drawing.Size(291, 25);
            this.tbPackageName.TabIndex = 46;
            this.tbPackageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(202, 143);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(291, 3);
            this.panel7.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Package Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(79, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Booking Id:";
            // 
            // panelTourBookingTitlebar
            // 
            this.panelTourBookingTitlebar.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTourBookingTitlebar.Controls.Add(this.pictureBox1);
            this.panelTourBookingTitlebar.Controls.Add(this.btnClose);
            this.panelTourBookingTitlebar.Controls.Add(this.label6);
            this.panelTourBookingTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTourBookingTitlebar.Location = new System.Drawing.Point(0, 0);
            this.panelTourBookingTitlebar.Name = "panelTourBookingTitlebar";
            this.panelTourBookingTitlebar.Size = new System.Drawing.Size(991, 50);
            this.panelTourBookingTitlebar.TabIndex = 0;
            this.panelTourBookingTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTourBookingTitlebar_MouseDown);
            this.panelTourBookingTitlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTourBookingTitlebar_MouseMove);
            this.panelTourBookingTitlebar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTourBookingTitlebar_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TTMS.UI.Properties.Resources.icons8_booking_45;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TTMS.UI.Properties.Resources.icons8_close_302;
            this.btnClose.Location = new System.Drawing.Point(942, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 39);
            this.btnClose.TabIndex = 14;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(277, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(418, 50);
            this.label6.TabIndex = 11;
            this.label6.Text = "TOUR BOOKINGS";
            // 
            // verificationDetailsBindingSource
            // 
            this.verificationDetailsBindingSource.DataMember = "VerificationDetails";
            // 
            // customerDetailsTableAdapter
            // 
            this.customerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // verificationDetailsTableAdapter
            // 
            this.verificationDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frmTourBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 715);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTourBooking";
            this.Text = "frmTourBooking";
            this.Load += new System.EventHandler(this.frmTourBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsDataSet)).EndInit();
            this.panelTourBookingTitlebar.ResumeLayout(false);
            this.panelTourBookingTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTourBookingTitlebar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPackageName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpBookingDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTourAvailability;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblParticipants;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.DataGridView dgvTourBooking;
        private System.Windows.Forms.Button btnAddParticipant;
        private System.Windows.Forms.Button btnDeleteParticipant;
        private System.Windows.Forms.Button btnAddPackage;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource verificationDetailsBindingSource;
        private System.Windows.Forms.DataGridView dgvParticipants;
        private Dataset.TourDataSet tourDataSet;
        private System.Windows.Forms.BindingSource customerDetailsBindingSource;
        private Dataset.TourDataSetTableAdapters.CustomerDetailsTableAdapter customerDetailsTableAdapter;
        private Dataset.VerificationDetailsDataSet verificationDetailsDataSet;
        private System.Windows.Forms.BindingSource verificationDetailsDataSetBindingSource;
        private System.Windows.Forms.BindingSource verificationDetailsBindingSource1;
        private Dataset.VerificationDetailsDataSetTableAdapters.VerificationDetailsTableAdapter verificationDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn clmAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmVerificationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVerificationNumber;
        private System.Windows.Forms.TextBox tbBookingId;
        private System.Windows.Forms.Panel panel2;
    }
}