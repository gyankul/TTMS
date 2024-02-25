namespace TTMS.UI.Forms.Driver___Vehicle
{
    partial class frmDriverDetails
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
            this.btnUploadImg = new System.Windows.Forms.Button();
            this.ImgVerification = new System.Windows.Forms.PictureBox();
            this.dgvDriverDetails = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbExperience = new System.Windows.Forms.ComboBox();
            this.cbVerificationType = new System.Windows.Forms.ComboBox();
            this.verificationDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verificationDetailsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verificationDetailsDataSet = new TTMS.UI.Dataset.VerificationDetailsDataSet();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpDOJ = new System.Windows.Forms.DateTimePicker();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tbPhoneNo = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbDriverId = new System.Windows.Forms.TextBox();
            this.tbDriverName = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.verificationDetailsTableAdapter = new TTMS.UI.Dataset.VerificationDetailsDataSetTableAdapters.VerificationDetailsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgVerification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnUploadImg);
            this.panel1.Controls.Add(this.ImgVerification);
            this.panel1.Controls.Add(this.dgvDriverDetails);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cbExperience);
            this.panel1.Controls.Add(this.cbVerificationType);
            this.panel1.Controls.Add(this.rbOther);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.dtpDOJ);
            this.panel1.Controls.Add(this.dtpDOB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.tbPhoneNo);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tbDriverId);
            this.panel1.Controls.Add(this.tbDriverName);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 532);
            this.panel1.TabIndex = 0;
            // 
            // btnUploadImg
            // 
            this.btnUploadImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUploadImg.Image = global::TTMS.UI.Properties.Resources.plus20px;
            this.btnUploadImg.Location = new System.Drawing.Point(686, 223);
            this.btnUploadImg.Name = "btnUploadImg";
            this.btnUploadImg.Size = new System.Drawing.Size(45, 32);
            this.btnUploadImg.TabIndex = 47;
            this.btnUploadImg.UseVisualStyleBackColor = true;
            this.btnUploadImg.Click += new System.EventHandler(this.btnUploadImg_Click);
            this.btnUploadImg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnUploadImg_KeyDown);
            // 
            // ImgVerification
            // 
            this.ImgVerification.Location = new System.Drawing.Point(686, 223);
            this.ImgVerification.Name = "ImgVerification";
            this.ImgVerification.Size = new System.Drawing.Size(45, 33);
            this.ImgVerification.TabIndex = 53;
            this.ImgVerification.TabStop = false;
            // 
            // dgvDriverDetails
            // 
            this.dgvDriverDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDriverDetails.Location = new System.Drawing.Point(28, 324);
            this.dgvDriverDetails.Name = "dgvDriverDetails";
            this.dgvDriverDetails.RowHeadersWidth = 51;
            this.dgvDriverDetails.RowTemplate.Height = 24;
            this.dgvDriverDetails.Size = new System.Drawing.Size(734, 150);
            this.dgvDriverDetails.TabIndex = 52;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(535, 490);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 32);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(411, 490);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(286, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Location = new System.Drawing.Point(160, 490);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 32);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbExperience
            // 
            this.cbExperience.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbExperience.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbExperience.DisplayMember = "VerificationName";
            this.cbExperience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbExperience.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cbExperience.FormattingEnabled = true;
            this.cbExperience.Items.AddRange(new object[] {
            "> 0.5 Year",
            "0.5 - 1 Year",
            "1 - 2 Years",
            "2 - 4 Years",
            "4 - 6 Years",
            "6 Years <",
            "2",
            "23",
            "2223"});
            this.cbExperience.Location = new System.Drawing.Point(172, 272);
            this.cbExperience.Name = "cbExperience";
            this.cbExperience.Size = new System.Drawing.Size(227, 33);
            this.cbExperience.TabIndex = 46;
            this.cbExperience.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbExperience_KeyDown);
            // 
            // cbVerificationType
            // 
            this.cbVerificationType.DataSource = this.verificationDetailsBindingSource;
            this.cbVerificationType.DisplayMember = "VerificationName";
            this.cbVerificationType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVerificationType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cbVerificationType.FormattingEnabled = true;
            this.cbVerificationType.Location = new System.Drawing.Point(239, 221);
            this.cbVerificationType.Name = "cbVerificationType";
            this.cbVerificationType.Size = new System.Drawing.Size(268, 33);
            this.cbVerificationType.TabIndex = 46;
            this.cbVerificationType.ValueMember = "VerificationId";
            this.cbVerificationType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbVerificationType_KeyDown);
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
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOther.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbOther.Location = new System.Drawing.Point(676, 128);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(86, 22);
            this.rbOther.TabIndex = 45;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "OTHER";
            this.rbOther.UseVisualStyleBackColor = true;
            this.rbOther.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbOther_KeyDown);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbFemale.Location = new System.Drawing.Point(577, 128);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(95, 22);
            this.rbFemale.TabIndex = 44;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "FEMALE";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbFemale_KeyDown);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbMale.Location = new System.Drawing.Point(496, 128);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(75, 22);
            this.rbMale.TabIndex = 43;
            this.rbMale.Text = "MALE";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbMale_KeyDown);
            // 
            // dtpDOJ
            // 
            this.dtpDOJ.CustomFormat = "dd/MM/yyyy";
            this.dtpDOJ.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpDOJ.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOJ.Location = new System.Drawing.Point(603, 278);
            this.dtpDOJ.Name = "dtpDOJ";
            this.dtpDOJ.Size = new System.Drawing.Size(160, 28);
            this.dtpDOJ.TabIndex = 42;
            this.dtpDOJ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDOJ_KeyDown);
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(194, 122);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(187, 28);
            this.dtpDOB.TabIndex = 42;
            this.dtpDOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDOB_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(405, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Date Of Joining:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(23, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Date Of Birth:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(390, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(23, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Experience:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label13.Location = new System.Drawing.Point(23, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(210, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Verification Type:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label14.Location = new System.Drawing.Point(530, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "Upload Img:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(390, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 25);
            this.label12.TabIndex = 33;
            this.label12.Text = "E-mail:";
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.tbEmail.ForeColor = System.Drawing.Color.Silver;
            this.tbEmail.Location = new System.Drawing.Point(488, 172);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(273, 25);
            this.tbEmail.TabIndex = 37;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEmail_KeyDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(172, 306);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 3);
            this.panel5.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(23, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 25);
            this.label11.TabIndex = 34;
            this.label11.Text = "Phone No:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(240, 254);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(267, 3);
            this.panel10.TabIndex = 40;
            // 
            // tbPhoneNo
            // 
            this.tbPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPhoneNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.tbPhoneNo.ForeColor = System.Drawing.Color.Silver;
            this.tbPhoneNo.Location = new System.Drawing.Point(158, 172);
            this.tbPhoneNo.Name = "tbPhoneNo";
            this.tbPhoneNo.Size = new System.Drawing.Size(223, 25);
            this.tbPhoneNo.TabIndex = 35;
            this.tbPhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPhoneNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPhoneNo_KeyDown);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(489, 199);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(273, 3);
            this.panel9.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(159, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 3);
            this.panel3.TabIndex = 38;
            // 
            // tbDriverId
            // 
            this.tbDriverId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDriverId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDriverId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbDriverId.Location = new System.Drawing.Point(151, 69);
            this.tbDriverId.Name = "tbDriverId";
            this.tbDriverId.Size = new System.Drawing.Size(105, 25);
            this.tbDriverId.TabIndex = 26;
            this.tbDriverId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDriverId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDriverId_KeyDown);
            // 
            // tbDriverName
            // 
            this.tbDriverName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDriverName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDriverName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbDriverName.Location = new System.Drawing.Point(435, 69);
            this.tbDriverName.Name = "tbDriverName";
            this.tbDriverName.Size = new System.Drawing.Size(293, 25);
            this.tbDriverName.TabIndex = 26;
            this.tbDriverName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDriverName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDriverName_KeyDown);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(151, 97);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(105, 3);
            this.panel6.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(268, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Driver Name:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(435, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 3);
            this.panel4.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Driver Id:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 50);
            this.panel2.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(736, 1);
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
            this.label6.Location = new System.Drawing.Point(239, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "DRIVER DETAILS";
            // 
            // verificationDetailsTableAdapter
            // 
            this.verificationDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frmDriverDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 532);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDriverDetails";
            this.Text = "frmDriverDetails";
            this.Load += new System.EventHandler(this.frmDriverDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgVerification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDriverDetails)).EndInit();
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
        private System.Windows.Forms.Button btnUploadImg;
        private System.Windows.Forms.ComboBox cbVerificationType;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox tbPhoneNo;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbDriverName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDriverDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpDOJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbExperience;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox ImgVerification;
        private System.Windows.Forms.BindingSource verificationDetailsDataSetBindingSource;
        private Dataset.VerificationDetailsDataSet verificationDetailsDataSet;
        private System.Windows.Forms.BindingSource verificationDetailsBindingSource;
        private Dataset.VerificationDetailsDataSetTableAdapters.VerificationDetailsTableAdapter verificationDetailsTableAdapter;
        private System.Windows.Forms.TextBox tbDriverId;
        private System.Windows.Forms.Panel panel6;
    }
}