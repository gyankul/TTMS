namespace TTMS.UI
{
    partial class frmForgotPassword
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFPUsername = new System.Windows.Forms.TextBox();
            this.txtFPSecurityQuestion = new System.Windows.Forms.TextBox();
            this.txtFPAnswer = new System.Windows.Forms.TextBox();
            this.txtFPPassword = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.panelConfirmPassword = new System.Windows.Forms.Panel();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtCnfPassword = new System.Windows.Forms.TextBox();
            this.panelCreateNewPassword = new System.Windows.Forms.Panel();
            this.lblCreateNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtCPAnswer = new System.Windows.Forms.TextBox();
            this.btnCPSearchUsername = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCPUsername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFPSearchAnswer = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.cpbConfirmPassword = new TTMS.CustomControls.CircularPicturebox();
            this.btnFPSearchUserName = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(75, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(559, 35);
            this.label6.TabIndex = 11;
            this.label6.Text = "FORGOT OR CHANGE PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Your Security Question:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(20, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter Your Answer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(20, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Current Password:";
            // 
            // txtFPUsername
            // 
            this.txtFPUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFPUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtFPUsername.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtFPUsername.Location = new System.Drawing.Point(22, 79);
            this.txtFPUsername.Name = "txtFPUsername";
            this.txtFPUsername.Size = new System.Drawing.Size(221, 20);
            this.txtFPUsername.TabIndex = 1;
            this.txtFPUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFPUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFPUsername_KeyDown);
            // 
            // txtFPSecurityQuestion
            // 
            this.txtFPSecurityQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFPSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtFPSecurityQuestion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtFPSecurityQuestion.Location = new System.Drawing.Point(23, 152);
            this.txtFPSecurityQuestion.Name = "txtFPSecurityQuestion";
            this.txtFPSecurityQuestion.Size = new System.Drawing.Size(272, 20);
            this.txtFPSecurityQuestion.TabIndex = 1;
            this.txtFPSecurityQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFPAnswer
            // 
            this.txtFPAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFPAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtFPAnswer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtFPAnswer.Location = new System.Drawing.Point(23, 223);
            this.txtFPAnswer.Name = "txtFPAnswer";
            this.txtFPAnswer.Size = new System.Drawing.Size(221, 20);
            this.txtFPAnswer.TabIndex = 1;
            this.txtFPAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFPAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFPAnswer_KeyDown);
            // 
            // txtFPPassword
            // 
            this.txtFPPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFPPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtFPPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtFPPassword.Location = new System.Drawing.Point(22, 293);
            this.txtFPPassword.Name = "txtFPPassword";
            this.txtFPPassword.Size = new System.Drawing.Size(272, 20);
            this.txtFPPassword.TabIndex = 1;
            this.txtFPPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 384);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(319, 45);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(365, 384);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(345, 45);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(23, 102);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(221, 3);
            this.panel6.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 444);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSecurityQuestion);
            this.groupBox2.Controls.Add(this.cpbConfirmPassword);
            this.groupBox2.Controls.Add(this.panelConfirmPassword);
            this.groupBox2.Controls.Add(this.lblConfirmPassword);
            this.groupBox2.Controls.Add(this.txtCnfPassword);
            this.groupBox2.Controls.Add(this.panelCreateNewPassword);
            this.groupBox2.Controls.Add(this.lblCreateNewPassword);
            this.groupBox2.Controls.Add(this.txtNewPassword);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.txtCPAnswer);
            this.groupBox2.Controls.Add(this.btnCPSearchUsername);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.txtCPUsername);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Location = new System.Drawing.Point(365, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 353);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Password";
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestion.ForeColor = System.Drawing.Color.SlateGray;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(11, 98);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(305, 16);
            this.lblSecurityQuestion.TabIndex = 19;
            this.lblSecurityQuestion.Text = "Your Security Question Will Appear Here!";
            // 
            // panelConfirmPassword
            // 
            this.panelConfirmPassword.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelConfirmPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelConfirmPassword.Location = new System.Drawing.Point(25, 314);
            this.panelConfirmPassword.Name = "panelConfirmPassword";
            this.panelConfirmPassword.Size = new System.Drawing.Size(266, 3);
            this.panelConfirmPassword.TabIndex = 28;
            this.panelConfirmPassword.Visible = false;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblConfirmPassword.Location = new System.Drawing.Point(22, 264);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(189, 20);
            this.lblConfirmPassword.TabIndex = 26;
            this.lblConfirmPassword.Text = "Confirm Password:";
            this.lblConfirmPassword.Visible = false;
            // 
            // txtCnfPassword
            // 
            this.txtCnfPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCnfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtCnfPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtCnfPassword.Location = new System.Drawing.Point(24, 292);
            this.txtCnfPassword.Name = "txtCnfPassword";
            this.txtCnfPassword.Size = new System.Drawing.Size(266, 20);
            this.txtCnfPassword.TabIndex = 27;
            this.txtCnfPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCnfPassword.Visible = false;
            this.txtCnfPassword.TextChanged += new System.EventHandler(this.txtCnfPassword_TextChanged);
            this.txtCnfPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCnfPassword_KeyDown);
            // 
            // panelCreateNewPassword
            // 
            this.panelCreateNewPassword.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelCreateNewPassword.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCreateNewPassword.Location = new System.Drawing.Point(27, 243);
            this.panelCreateNewPassword.Name = "panelCreateNewPassword";
            this.panelCreateNewPassword.Size = new System.Drawing.Size(264, 3);
            this.panelCreateNewPassword.TabIndex = 25;
            this.panelCreateNewPassword.Visible = false;
            // 
            // lblCreateNewPassword
            // 
            this.lblCreateNewPassword.AutoSize = true;
            this.lblCreateNewPassword.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCreateNewPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCreateNewPassword.Location = new System.Drawing.Point(24, 193);
            this.lblCreateNewPassword.Name = "lblCreateNewPassword";
            this.lblCreateNewPassword.Size = new System.Drawing.Size(223, 20);
            this.lblCreateNewPassword.TabIndex = 23;
            this.lblCreateNewPassword.Text = "Create New Password:";
            this.lblCreateNewPassword.Visible = false;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtNewPassword.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtNewPassword.Location = new System.Drawing.Point(26, 221);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(264, 20);
            this.txtNewPassword.TabIndex = 24;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewPassword.Visible = false;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            this.txtNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewPassword_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(20, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Answer:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(25, 175);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(266, 3);
            this.panel7.TabIndex = 22;
            // 
            // txtCPAnswer
            // 
            this.txtCPAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtCPAnswer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtCPAnswer.Location = new System.Drawing.Point(24, 152);
            this.txtCPAnswer.Name = "txtCPAnswer";
            this.txtCPAnswer.Size = new System.Drawing.Size(266, 20);
            this.txtCPAnswer.TabIndex = 21;
            this.txtCPAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPAnswer_KeyDown);
            // 
            // btnCPSearchUsername
            // 
            this.btnCPSearchUsername.BackColor = System.Drawing.Color.White;
            this.btnCPSearchUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCPSearchUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPSearchUsername.Image = global::TTMS.UI.Properties.Resources.magnifying_glass_30px;
            this.btnCPSearchUsername.Location = new System.Drawing.Point(280, 47);
            this.btnCPSearchUsername.Name = "btnCPSearchUsername";
            this.btnCPSearchUsername.Size = new System.Drawing.Size(37, 37);
            this.btnCPSearchUsername.TabIndex = 18;
            this.btnCPSearchUsername.UseVisualStyleBackColor = false;
            this.btnCPSearchUsername.Click += new System.EventHandler(this.btnCPSearchUsername_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(23, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "User Name:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(28, 88);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 3);
            this.panel5.TabIndex = 17;
            // 
            // txtCPUsername
            // 
            this.txtCPUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtCPUsername.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtCPUsername.Location = new System.Drawing.Point(27, 65);
            this.txtCPUsername.Name = "txtCPUsername";
            this.txtCPUsername.Size = new System.Drawing.Size(234, 20);
            this.txtCPUsername.TabIndex = 16;
            this.txtCPUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCPUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPUsername_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnFPSearchAnswer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.txtFPUsername);
            this.groupBox1.Controls.Add(this.txtFPSecurityQuestion);
            this.groupBox1.Controls.Add(this.btnFPSearchUserName);
            this.groupBox1.Controls.Add(this.txtFPAnswer);
            this.groupBox1.Controls.Add(this.txtFPPassword);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 353);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forgot Password";
            // 
            // btnFPSearchAnswer
            // 
            this.btnFPSearchAnswer.BackColor = System.Drawing.Color.White;
            this.btnFPSearchAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFPSearchAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFPSearchAnswer.Image = global::TTMS.UI.Properties.Resources.magnifying_glass_30px;
            this.btnFPSearchAnswer.Location = new System.Drawing.Point(259, 208);
            this.btnFPSearchAnswer.Name = "btnFPSearchAnswer";
            this.btnFPSearchAnswer.Size = new System.Drawing.Size(37, 37);
            this.btnFPSearchAnswer.TabIndex = 18;
            this.btnFPSearchAnswer.UseVisualStyleBackColor = false;
            this.btnFPSearchAnswer.Click += new System.EventHandler(this.btnFPSearchAnswer_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(23, 314);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 3);
            this.panel4.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(24, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 3);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(24, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 3);
            this.panel2.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TTMS.UI.Properties.Resources.close_button_white;
            this.btnClose.Location = new System.Drawing.Point(685, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 39);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cpbConfirmPassword
            // 
            this.cpbConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpbConfirmPassword.Location = new System.Drawing.Point(296, 282);
            this.cpbConfirmPassword.Name = "cpbConfirmPassword";
            this.cpbConfirmPassword.Size = new System.Drawing.Size(30, 30);
            this.cpbConfirmPassword.TabIndex = 29;
            this.cpbConfirmPassword.TabStop = false;
            // 
            // btnFPSearchUserName
            // 
            this.btnFPSearchUserName.BackColor = System.Drawing.Color.White;
            this.btnFPSearchUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFPSearchUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFPSearchUserName.Image = global::TTMS.UI.Properties.Resources.magnifying_glass_30px;
            this.btnFPSearchUserName.Location = new System.Drawing.Point(259, 61);
            this.btnFPSearchUserName.Name = "btnFPSearchUserName";
            this.btnFPSearchUserName.Size = new System.Drawing.Size(37, 37);
            this.btnFPSearchUserName.TabIndex = 3;
            this.btnFPSearchUserName.UseVisualStyleBackColor = false;
            this.btnFPSearchUserName.Click += new System.EventHandler(this.btnFPSearchUserName_Click);
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(727, 501);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbConfirmPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFPUsername;
        private System.Windows.Forms.TextBox txtFPSecurityQuestion;
        private System.Windows.Forms.TextBox txtFPAnswer;
        private System.Windows.Forms.TextBox txtFPPassword;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnFPSearchUserName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFPSearchAnswer;
        private System.Windows.Forms.Panel panelCreateNewPassword;
        private System.Windows.Forms.Label lblCreateNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtCPAnswer;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.Button btnCPSearchUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtCPUsername;
        private System.Windows.Forms.Panel panelConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtCnfPassword;
        private CustomControls.CircularPicturebox cpbConfirmPassword;
    }
}