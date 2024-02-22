namespace TTMS.UI.Forms
{
    partial class frmCustomerDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.cbNationality = new System.Windows.Forms.ComboBox();
            this.countryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDetailDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerDetailDataSet = new TTMS.UI.Dataset.CustomerDetailDataSet();
            this.cbVerificationType = new System.Windows.Forms.ComboBox();
            this.verificationDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbVerificationNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbCustomerId = new System.Windows.Forms.TextBox();
            this.tbPhoneNo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.countryDetailsTableAdapter = new TTMS.UI.Dataset.CustomerDetailDataSetTableAdapters.CountryDetailsTableAdapter();
            this.verificationDetailsTableAdapter = new TTMS.UI.Dataset.CustomerDetailDataSetTableAdapters.VerificationDetailsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtpDOB);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.dgvCustomer);
            this.panel1.Controls.Add(this.cbNationality);
            this.panel1.Controls.Add(this.cbVerificationType);
            this.panel1.Controls.Add(this.tbVerificationNo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.tbCustomerId);
            this.panel1.Controls.Add(this.tbPhoneNo);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.rbOther);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbCustomerName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 598);
            this.panel1.TabIndex = 0;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(206, 121);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 32);
            this.dtpDOB.TabIndex = 61;
            this.dtpDOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDOB_KeyDown);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(731, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(204, 32);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "DELETE CUSTOMER";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(477, 337);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(207, 32);
            this.btnUpdate.TabIndex = 58;
            this.btnUpdate.Text = "UPDATE CUSTOMER";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(255, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 32);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "SAVE CUSTOMER";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Location = new System.Drawing.Point(30, 337);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 32);
            this.btnAdd.TabIndex = 60;
            this.btnAdd.Text = "ADD CUSTOMER";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(25, 385);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(929, 198);
            this.dgvCustomer.TabIndex = 56;
            // 
            // cbNationality
            // 
            this.cbNationality.DataSource = this.countryDetailsBindingSource;
            this.cbNationality.DisplayMember = "CountryName";
            this.cbNationality.DropDownHeight = 100;
            this.cbNationality.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.IntegralHeight = false;
            this.cbNationality.ItemHeight = 25;
            this.cbNationality.Location = new System.Drawing.Point(206, 172);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(242, 33);
            this.cbNationality.TabIndex = 55;
            this.cbNationality.ValueMember = "CountryId";
            this.cbNationality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbNationality_KeyDown);
            // 
            // countryDetailsBindingSource
            // 
            this.countryDetailsBindingSource.DataMember = "CountryDetails";
            this.countryDetailsBindingSource.DataSource = this.customerDetailDataSetBindingSource;
            // 
            // customerDetailDataSetBindingSource
            // 
            this.customerDetailDataSetBindingSource.DataSource = this.customerDetailDataSet;
            this.customerDetailDataSetBindingSource.Position = 0;
            // 
            // customerDetailDataSet
            // 
            this.customerDetailDataSet.DataSetName = "CustomerDetailDataSet";
            this.customerDetailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbVerificationType
            // 
            this.cbVerificationType.DataSource = this.verificationDetailsBindingSource;
            this.cbVerificationType.DisplayMember = "VerificationName";
            this.cbVerificationType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cbVerificationType.FormattingEnabled = true;
            this.cbVerificationType.Location = new System.Drawing.Point(235, 270);
            this.cbVerificationType.Name = "cbVerificationType";
            this.cbVerificationType.Size = new System.Drawing.Size(214, 33);
            this.cbVerificationType.TabIndex = 54;
            this.cbVerificationType.ValueMember = "VerificationId";
            this.cbVerificationType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbVerificationType_KeyDown);
            // 
            // verificationDetailsBindingSource
            // 
            this.verificationDetailsBindingSource.DataMember = "VerificationDetails";
            this.verificationDetailsBindingSource.DataSource = this.customerDetailDataSetBindingSource;
            // 
            // tbVerificationNo
            // 
            this.tbVerificationNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVerificationNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVerificationNo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbVerificationNo.Location = new System.Drawing.Point(665, 275);
            this.tbVerificationNo.Name = "tbVerificationNo";
            this.tbVerificationNo.Size = new System.Drawing.Size(281, 25);
            this.tbVerificationNo.TabIndex = 53;
            this.tbVerificationNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbVerificationNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbVerificationNo_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(472, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 25);
            this.label11.TabIndex = 52;
            this.label11.Text = "Verification No:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(665, 303);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(281, 3);
            this.panel10.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(23, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 25);
            this.label10.TabIndex = 49;
            this.label10.Text = "Verification Type:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(235, 303);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(214, 3);
            this.panel9.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(57, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "Nationality:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(206, 205);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(242, 3);
            this.panel8.TabIndex = 45;
            // 
            // tbAddress
            // 
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAddress.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbAddress.Location = new System.Drawing.Point(589, 173);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(357, 25);
            this.tbAddress.TabIndex = 44;
            this.tbAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddress_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(472, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 43;
            this.label8.Text = "Address:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(589, 201);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(357, 3);
            this.panel7.TabIndex = 42;
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbEmail.Location = new System.Drawing.Point(560, 224);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(357, 25);
            this.tbEmail.TabIndex = 41;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEmail_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(472, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Email:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(560, 252);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(357, 3);
            this.panel6.TabIndex = 39;
            // 
            // tbCustomerId
            // 
            this.tbCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCustomerId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbCustomerId.Location = new System.Drawing.Point(211, 73);
            this.tbCustomerId.Name = "tbCustomerId";
            this.tbCustomerId.Size = new System.Drawing.Size(118, 25);
            this.tbCustomerId.TabIndex = 38;
            this.tbCustomerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCustomerId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCustomerId_KeyDown);
            // 
            // tbPhoneNo
            // 
            this.tbPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPhoneNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPhoneNo.Location = new System.Drawing.Point(211, 225);
            this.tbPhoneNo.Name = "tbPhoneNo";
            this.tbPhoneNo.Size = new System.Drawing.Size(237, 25);
            this.tbPhoneNo.TabIndex = 38;
            this.tbPhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPhoneNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPhoneNo_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(211, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 3);
            this.panel3.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(62, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 37;
            this.label5.Text = "Contact No:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(211, 253);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 3);
            this.panel5.TabIndex = 36;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.rbOther.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbOther.Location = new System.Drawing.Point(783, 124);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(96, 29);
            this.rbOther.TabIndex = 35;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            this.rbOther.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbOther_KeyDown);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.rbFemale.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbFemale.Location = new System.Drawing.Point(669, 124);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(108, 29);
            this.rbFemale.TabIndex = 34;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbFemale_KeyDown);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.rbMale.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbMale.Location = new System.Drawing.Point(578, 124);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(85, 29);
            this.rbMale.TabIndex = 33;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbMale_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(472, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(38, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Date Of Birth:";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCustomerName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbCustomerName.Location = new System.Drawing.Point(603, 73);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(343, 25);
            this.tbCustomerName.TabIndex = 27;
            this.tbCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCustomerName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(399, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Customer Name:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(603, 101);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(343, 3);
            this.panel4.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(46, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer Id:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 50);
            this.panel2.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TTMS.UI.Properties.Resources.close_button_white;
            this.btnClose.Location = new System.Drawing.Point(937, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 39);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(304, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(355, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "CUSTOMER DETAILS";
            // 
            // countryDetailsTableAdapter
            // 
            this.countryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // verificationDetailsTableAdapter
            // 
            this.verificationDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frmCustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(982, 598);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomerDetails";
            this.Load += new System.EventHandler(this.frmCustomerDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDetailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox tbPhoneNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbVerificationType;
        private System.Windows.Forms.ComboBox cbNationality;
        private System.Windows.Forms.TextBox tbVerificationNo;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource customerDetailDataSetBindingSource;
        private Dataset.CustomerDetailDataSet customerDetailDataSet;
        private System.Windows.Forms.BindingSource countryDetailsBindingSource;
        private Dataset.CustomerDetailDataSetTableAdapters.CountryDetailsTableAdapter countryDetailsTableAdapter;
        private System.Windows.Forms.BindingSource verificationDetailsBindingSource;
        private Dataset.CustomerDetailDataSetTableAdapters.VerificationDetailsTableAdapter verificationDetailsTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox tbCustomerId;
        private System.Windows.Forms.Panel panel3;
    }
}