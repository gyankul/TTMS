namespace TTMS.UI
{
    partial class frmSignup
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
            this.panel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cpbUserImage = new TTMS.CustomControls.CircularPicturebox();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cpbConfirmPassword = new TTMS.CustomControls.CircularPicturebox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbStaffType = new System.Windows.Forms.ComboBox();
            this.staffTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.signupDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.signupDetail = new TTMS.UI.Dataset.SignupDetail();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbSecurityAnswer = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddVerificationImg = new System.Windows.Forms.Button();
            this.pbVerificationImg = new System.Windows.Forms.PictureBox();
            this.cbVerificationType = new System.Windows.Forms.ComboBox();
            this.verificationDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tbPhoneNo = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.verificationDetailsTableAdapter = new TTMS.UI.Dataset.SignupDetailTableAdapters.VerificationDetailsTableAdapter();
            this.staffTypesTableAdapter = new TTMS.UI.Dataset.SignupDetailTableAdapters.StaffTypesTableAdapter();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbUserImage)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerificationImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel.Controls.Add(this.btnClose);
            this.panel.Controls.Add(this.label6);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1047, 50);
            this.panel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TTMS.UI.Properties.Resources.close_button_white;
            this.btnClose.Location = new System.Drawing.Point(1002, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 39);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(441, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "SIGNUP";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cpbUserImage);
            this.groupBox3.Controls.Add(this.btnAddImg);
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(392, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 296);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add User Image";
            // 
            // cpbUserImage
            // 
            this.cpbUserImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cpbUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpbUserImage.Location = new System.Drawing.Point(11, 33);
            this.cpbUserImage.Name = "cpbUserImage";
            this.cpbUserImage.Size = new System.Drawing.Size(200, 200);
            this.cpbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cpbUserImage.TabIndex = 17;
            this.cpbUserImage.TabStop = false;
            // 
            // btnAddImg
            // 
            this.btnAddImg.BackColor = System.Drawing.Color.White;
            this.btnAddImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImg.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAddImg.Location = new System.Drawing.Point(50, 246);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(124, 40);
            this.btnAddImg.TabIndex = 18;
            this.btnAddImg.Text = "Add Image";
            this.btnAddImg.UseVisualStyleBackColor = false;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            this.btnAddImg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAddImg_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.cpbConfirmPassword);
            this.groupBox2.Controls.Add(this.panel8);
            this.groupBox2.Controls.Add(this.cbStaffType);
            this.groupBox2.Controls.Add(this.tbConfirmPassword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbUsername);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.tbSecurityAnswer);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbPassword);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbSecurityQuestion);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Location = new System.Drawing.Point(408, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 335);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff  Type:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(139, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 3);
            this.panel3.TabIndex = 13;
            // 
            // cpbConfirmPassword
            // 
            this.cpbConfirmPassword.Location = new System.Drawing.Point(352, 273);
            this.cpbConfirmPassword.Name = "cpbConfirmPassword";
            this.cpbConfirmPassword.Size = new System.Drawing.Size(30, 30);
            this.cpbConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cpbConfirmPassword.TabIndex = 25;
            this.cpbConfirmPassword.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(162, 300);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(184, 3);
            this.panel8.TabIndex = 24;
            // 
            // cbStaffType
            // 
            this.cbStaffType.DataSource = this.staffTypesBindingSource;
            this.cbStaffType.DisplayMember = "StaffTypeName";
            this.cbStaffType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStaffType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStaffType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaffType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbStaffType.FormattingEnabled = true;
            this.cbStaffType.Location = new System.Drawing.Point(139, 49);
            this.cbStaffType.Name = "cbStaffType";
            this.cbStaffType.Size = new System.Drawing.Size(219, 28);
            this.cbStaffType.TabIndex = 26;
            this.cbStaffType.ValueMember = "StaffTypeId";
            // 
            // staffTypesBindingSource
            // 
            this.staffTypesBindingSource.DataMember = "StaffTypes";
            this.staffTypesBindingSource.DataSource = this.signupDetailBindingSource;
            // 
            // signupDetailBindingSource
            // 
            this.signupDetailBindingSource.DataSource = this.signupDetail;
            this.signupDetailBindingSource.Position = 0;
            // 
            // signupDetail
            // 
            this.signupDetail.DataSetName = "SignupDetail";
            this.signupDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbConfirmPassword.Location = new System.Drawing.Point(162, 278);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.Size = new System.Drawing.Size(184, 20);
            this.tbConfirmPassword.TabIndex = 23;
            this.tbConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(11, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Cnf Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbUsername.Location = new System.Drawing.Point(139, 99);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(218, 20);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(139, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 3);
            this.panel2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(11, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Question:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(128, 255);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 3);
            this.panel4.TabIndex = 14;
            // 
            // tbSecurityAnswer
            // 
            this.tbSecurityAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSecurityAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSecurityAnswer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbSecurityAnswer.Location = new System.Drawing.Point(106, 185);
            this.tbSecurityAnswer.Name = "tbSecurityAnswer";
            this.tbSecurityAnswer.Size = new System.Drawing.Size(250, 20);
            this.tbSecurityAnswer.TabIndex = 1;
            this.tbSecurityAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(106, 207);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 3);
            this.panel6.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(13, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Answer:";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPassword.Location = new System.Drawing.Point(128, 233);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(218, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(118, 165);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 3);
            this.panel5.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(13, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // cbSecurityQuestion
            // 
            this.cbSecurityQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecurityQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSecurityQuestion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbSecurityQuestion.FormattingEnabled = true;
            this.cbSecurityQuestion.Items.AddRange(new object[] {
            "Your Father Name",
            "Your Mother Name",
            "Your Friend Name",
            "Your School Name",
            "Place Of Birth",
            "Your Phone Number",
            "GirlFriend/Boyfriend Name",
            "Favourite place"});
            this.cbSecurityQuestion.Location = new System.Drawing.Point(118, 137);
            this.cbSecurityQuestion.Name = "cbSecurityQuestion";
            this.cbSecurityQuestion.Size = new System.Drawing.Size(240, 26);
            this.cbSecurityQuestion.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddVerificationImg);
            this.groupBox1.Controls.Add(this.pbVerificationImg);
            this.groupBox1.Controls.Add(this.cbVerificationType);
            this.groupBox1.Controls.Add(this.rbOther);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Controls.Add(this.tbPhoneNo);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 387);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Info";
            // 
            // btnAddVerificationImg
            // 
            this.btnAddVerificationImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddVerificationImg.Image = global::TTMS.UI.Properties.Resources.plus20px;
            this.btnAddVerificationImg.Location = new System.Drawing.Point(252, 335);
            this.btnAddVerificationImg.Name = "btnAddVerificationImg";
            this.btnAddVerificationImg.Size = new System.Drawing.Size(45, 32);
            this.btnAddVerificationImg.TabIndex = 25;
            this.btnAddVerificationImg.UseVisualStyleBackColor = true;
            this.btnAddVerificationImg.Click += new System.EventHandler(this.btnAddVerificationImg_Click);
            this.btnAddVerificationImg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAddVerificationImg_KeyDown);
            // 
            // pbVerificationImg
            // 
            this.pbVerificationImg.Location = new System.Drawing.Point(201, 335);
            this.pbVerificationImg.Name = "pbVerificationImg";
            this.pbVerificationImg.Size = new System.Drawing.Size(45, 32);
            this.pbVerificationImg.TabIndex = 26;
            this.pbVerificationImg.TabStop = false;
            // 
            // cbVerificationType
            // 
            this.cbVerificationType.DataSource = this.verificationDetailsBindingSource;
            this.cbVerificationType.DisplayMember = "VerificationName";
            this.cbVerificationType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVerificationType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.cbVerificationType.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbVerificationType.FormattingEnabled = true;
            this.cbVerificationType.Location = new System.Drawing.Point(201, 287);
            this.cbVerificationType.Name = "cbVerificationType";
            this.cbVerificationType.Size = new System.Drawing.Size(172, 26);
            this.cbVerificationType.TabIndex = 24;
            this.cbVerificationType.ValueMember = "VerificationId";
            this.cbVerificationType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbVerificationType_KeyDown);
            // 
            // verificationDetailsBindingSource
            // 
            this.verificationDetailsBindingSource.DataMember = "VerificationDetails";
            this.verificationDetailsBindingSource.DataSource = this.signupDetailBindingSource;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOther.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rbOther.Location = new System.Drawing.Point(287, 146);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(86, 22);
            this.rbOther.TabIndex = 23;
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
            this.rbFemale.Location = new System.Drawing.Point(188, 146);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(95, 22);
            this.rbFemale.TabIndex = 23;
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
            this.rbMale.Location = new System.Drawing.Point(107, 146);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(75, 22);
            this.rbMale.TabIndex = 23;
            this.rbMale.Text = "MALE";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbMale_KeyDown);
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(172, 93);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(187, 28);
            this.dtpDOB.TabIndex = 22;
            this.dtpDOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDOB_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(20, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Date Of Birth:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(17, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Gender:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label13.Location = new System.Drawing.Point(17, 295);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Verification Type:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label14.Location = new System.Drawing.Point(17, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(171, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Verification Img:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(17, 245);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "E-mail:";
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbEmail.Location = new System.Drawing.Point(100, 240);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(273, 20);
            this.tbEmail.TabIndex = 20;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEmail_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(17, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Phone No:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(202, 315);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(172, 3);
            this.panel10.TabIndex = 21;
            // 
            // tbPhoneNo
            // 
            this.tbPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPhoneNo.Location = new System.Drawing.Point(130, 190);
            this.tbPhoneNo.Name = "tbPhoneNo";
            this.tbPhoneNo.Size = new System.Drawing.Size(243, 20);
            this.tbPhoneNo.TabIndex = 20;
            this.tbPhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPhoneNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPhoneNo_KeyDown);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(101, 262);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(273, 3);
            this.panel9.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(17, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(131, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 3);
            this.panel1.TabIndex = 21;
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbName.Location = new System.Drawing.Point(94, 46);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(280, 20);
            this.tbName.TabIndex = 20;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(94, 69);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 3);
            this.panel7.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.Location = new System.Drawing.Point(906, 407);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 46);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(560, 407);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(328, 46);
            this.btnCreate.TabIndex = 31;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // verificationDetailsTableAdapter
            // 
            this.verificationDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // staffTypesTableAdapter
            // 
            this.staffTypesTableAdapter.ClearBeforeFill = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Location = new System.Drawing.Point(408, 407);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 46);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "NEW USER";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 465);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpbUserImage)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signupDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerificationImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verificationDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox3;
        private CustomControls.CircularPicturebox cpbUserImage;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.CircularPicturebox cpbConfirmPassword;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cbStaffType;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbSecurityAnswer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSecurityQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddVerificationImg;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.BindingSource signupDetailBindingSource;
        private Dataset.SignupDetail signupDetail;
        private System.Windows.Forms.BindingSource verificationDetailsBindingSource;
        private Dataset.SignupDetailTableAdapters.VerificationDetailsTableAdapter verificationDetailsTableAdapter;
        private System.Windows.Forms.BindingSource staffTypesBindingSource;
        private Dataset.SignupDetailTableAdapters.StaffTypesTableAdapter staffTypesTableAdapter;
        private System.Windows.Forms.PictureBox pbVerificationImg;
        private System.Windows.Forms.Button btnAdd;
    }
}