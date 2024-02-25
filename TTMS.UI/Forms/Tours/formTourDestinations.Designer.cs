namespace TTMS.UI.Forms.Tours
{
    partial class formTourDestinations
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
        // </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.er = new System.Windows.Forms.Label();
            this.tbDestinationName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPackageName = new System.Windows.Forms.TextBox();
            this.tbDestinationCost = new System.Windows.Forms.TextBox();
            this.ImgDestination = new System.Windows.Forms.PictureBox();
            this.dtpEnd = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTourDestination = new System.Windows.Forms.DataGridView();
            this.lblDestinationId = new System.Windows.Forms.Label();
            this.btnAddItinerary = new System.Windows.Forms.Button();
            this.dgvTourItinerary = new System.Windows.Forms.DataGridView();
            this.clmAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDayNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmItineraryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSRNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteItinerary = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourItinerary)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(384, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(349, 35);
            this.label6.TabIndex = 11;
            this.label6.Text = "TOUR DESTINATION";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel.Controls.Add(this.btnClose);
            this.panel.Controls.Add(this.label6);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1128, 50);
            this.panel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TTMS.UI.Properties.Resources.close_button_white;
            this.btnClose.Location = new System.Drawing.Point(1085, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 39);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDeleteItinerary);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnAddItinerary);
            this.panel1.Controls.Add(this.lblDestinationId);
            this.panel1.Controls.Add(this.dgvTourDestination);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAddImg);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.ImgDestination);
            this.panel1.Controls.Add(this.tbDestinationCost);
            this.panel1.Controls.Add(this.tbPackageName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbDestinationName);
            this.panel1.Controls.Add(this.er);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 764);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(21, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destination Id:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(915, 110);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(191, 3);
            this.panel5.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(451, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 3);
            this.panel4.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(696, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 3);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(296, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Destination:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(720, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Package Name:";
            // 
            // er
            // 
            this.er.AutoSize = true;
            this.er.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.er.ForeColor = System.Drawing.Color.RoyalBlue;
            this.er.Location = new System.Drawing.Point(483, 278);
            this.er.Name = "er";
            this.er.Size = new System.Drawing.Size(205, 25);
            this.er.TabIndex = 13;
            this.er.Text = "Destination Cost:";
            // 
            // tbDestinationName
            // 
            this.tbDestinationName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDestinationName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestinationName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbDestinationName.Location = new System.Drawing.Point(451, 83);
            this.tbDestinationName.Name = "tbDestinationName";
            this.tbDestinationName.Size = new System.Drawing.Size(258, 25);
            this.tbDestinationName.TabIndex = 14;
            this.tbDestinationName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(455, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Description:";
            // 
            // tbPackageName
            // 
            this.tbPackageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPackageName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPackageName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPackageName.Location = new System.Drawing.Point(915, 83);
            this.tbPackageName.Name = "tbPackageName";
            this.tbPackageName.Size = new System.Drawing.Size(191, 25);
            this.tbPackageName.TabIndex = 14;
            this.tbPackageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDestinationCost
            // 
            this.tbDestinationCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDestinationCost.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestinationCost.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbDestinationCost.Location = new System.Drawing.Point(696, 275);
            this.tbDestinationCost.Name = "tbDestinationCost";
            this.tbDestinationCost.Size = new System.Drawing.Size(191, 25);
            this.tbDestinationCost.TabIndex = 14;
            this.tbDestinationCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ImgDestination
            // 
            this.ImgDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgDestination.Location = new System.Drawing.Point(26, 127);
            this.ImgDestination.Name = "ImgDestination";
            this.ImgDestination.Size = new System.Drawing.Size(407, 205);
            this.ImgDestination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgDestination.TabIndex = 17;
            this.ImgDestination.TabStop = false;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.dtpEnd.Location = new System.Drawing.Point(623, 127);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(401, 76);
            this.dtpEnd.TabIndex = 19;
            this.dtpEnd.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Location = new System.Drawing.Point(589, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 32);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddImg
            // 
            this.btnAddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImg.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAddImg.Image = global::TTMS.UI.Properties.Resources.plus_button_40px;
            this.btnAddImg.Location = new System.Drawing.Point(26, 281);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(53, 51);
            this.btnAddImg.TabIndex = 20;
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(715, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(840, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(964, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 32);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvTourDestination
            // 
            this.dgvTourDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourDestination.Location = new System.Drawing.Point(26, 589);
            this.dgvTourDestination.Name = "dgvTourDestination";
            this.dgvTourDestination.RowHeadersWidth = 51;
            this.dgvTourDestination.RowTemplate.Height = 24;
            this.dgvTourDestination.Size = new System.Drawing.Size(1080, 160);
            this.dgvTourDestination.TabIndex = 21;
            // 
            // lblDestinationId
            // 
            this.lblDestinationId.AutoSize = true;
            this.lblDestinationId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDestinationId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblDestinationId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDestinationId.Location = new System.Drawing.Point(208, 88);
            this.lblDestinationId.Name = "lblDestinationId";
            this.lblDestinationId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDestinationId.Size = new System.Drawing.Size(82, 25);
            this.lblDestinationId.TabIndex = 22;
            this.lblDestinationId.Text = "          ";
            // 
            // btnAddItinerary
            // 
            this.btnAddItinerary.Image = global::TTMS.UI.Properties.Resources.plus_button_40px;
            this.btnAddItinerary.Location = new System.Drawing.Point(982, 294);
            this.btnAddItinerary.Name = "btnAddItinerary";
            this.btnAddItinerary.Size = new System.Drawing.Size(42, 42);
            this.btnAddItinerary.TabIndex = 27;
            this.btnAddItinerary.UseVisualStyleBackColor = true;
            this.btnAddItinerary.Click += new System.EventHandler(this.btnAddItinerary_Click);
            // 
            // dgvTourItinerary
            // 
            this.dgvTourItinerary.AllowUserToAddRows = false;
            this.dgvTourItinerary.BackgroundColor = System.Drawing.Color.White;
            this.dgvTourItinerary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTourItinerary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTourItinerary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourItinerary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSRNO,
            this.clmItineraryName,
            this.clmDayNo,
            this.clmActivity,
            this.clmSDT,
            this.clmEDT,
            this.clmImage,
            this.clmAction});
            this.dgvTourItinerary.Location = new System.Drawing.Point(10, 48);
            this.dgvTourItinerary.Name = "dgvTourItinerary";
            this.dgvTourItinerary.RowHeadersVisible = false;
            this.dgvTourItinerary.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.dgvTourItinerary.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTourItinerary.RowTemplate.Height = 24;
            this.dgvTourItinerary.Size = new System.Drawing.Size(1058, 162);
            this.dgvTourItinerary.TabIndex = 23;
            this.dgvTourItinerary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTourItinerary_CellContentClick);
            // 
            // clmAction
            // 
            this.clmAction.HeaderText = "Action";
            this.clmAction.MinimumWidth = 6;
            this.clmAction.Name = "clmAction";
            this.clmAction.UseColumnTextForButtonValue = true;
            this.clmAction.Width = 80;
            // 
            // clmImage
            // 
            this.clmImage.HeaderText = "Image";
            this.clmImage.MinimumWidth = 6;
            this.clmImage.Name = "clmImage";
            this.clmImage.Width = 125;
            // 
            // clmEDT
            // 
            this.clmEDT.HeaderText = "EndDateTime";
            this.clmEDT.MinimumWidth = 6;
            this.clmEDT.Name = "clmEDT";
            this.clmEDT.Width = 155;
            // 
            // clmSDT
            // 
            this.clmSDT.HeaderText = "StartDateTime";
            this.clmSDT.MinimumWidth = 6;
            this.clmSDT.Name = "clmSDT";
            this.clmSDT.Width = 155;
            // 
            // clmActivity
            // 
            this.clmActivity.HeaderText = "Activities";
            this.clmActivity.MinimumWidth = 6;
            this.clmActivity.Name = "clmActivity";
            this.clmActivity.Width = 250;
            // 
            // clmDayNo
            // 
            this.clmDayNo.HeaderText = "Day No";
            this.clmDayNo.MinimumWidth = 6;
            this.clmDayNo.Name = "clmDayNo";
            this.clmDayNo.Width = 50;
            // 
            // clmItineraryName
            // 
            this.clmItineraryName.HeaderText = "Itinerary Name";
            this.clmItineraryName.MinimumWidth = 6;
            this.clmItineraryName.Name = "clmItineraryName";
            this.clmItineraryName.Width = 190;
            // 
            // clmSRNO
            // 
            this.clmSRNO.HeaderText = "Sr. No.";
            this.clmSRNO.MinimumWidth = 6;
            this.clmSRNO.Name = "clmSRNO";
            this.clmSRNO.Width = 50;
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.CalendarForeColor = System.Drawing.Color.RoyalBlue;
            this.dtpStart.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpStart.CalendarTitleForeColor = System.Drawing.Color.RoyalBlue;
            this.dtpStart.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtpStart.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(548, 15);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(180, 27);
            this.dtpStart.TabIndex = 25;
            this.dtpStart.Value = new System.DateTime(2024, 1, 28, 13, 17, 18, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.dgvTourItinerary);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(26, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1080, 223);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add  Itineraries";
            // 
            // btnDeleteItinerary
            // 
            this.btnDeleteItinerary.Image = global::TTMS.UI.Properties.Resources.Dustbin_40px;
            this.btnDeleteItinerary.Location = new System.Drawing.Point(1040, 294);
            this.btnDeleteItinerary.Name = "btnDeleteItinerary";
            this.btnDeleteItinerary.Size = new System.Drawing.Size(42, 42);
            this.btnDeleteItinerary.TabIndex = 28;
            this.btnDeleteItinerary.UseVisualStyleBackColor = true;
            this.btnDeleteItinerary.Click += new System.EventHandler(this.btnDeleteItinerary_Click);
            // 
            // formTourDestinations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 764);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTourDestinations";
            this.Text = "TourDestinations";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourItinerary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteItinerary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DataGridView dgvTourItinerary;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSRNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItineraryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDayNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImage;
        private System.Windows.Forms.DataGridViewButtonColumn clmAction;
        private System.Windows.Forms.Button btnAddItinerary;
        private System.Windows.Forms.Label lblDestinationId;
        private System.Windows.Forms.DataGridView dgvTourDestination;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox dtpEnd;
        private System.Windows.Forms.PictureBox ImgDestination;
        private System.Windows.Forms.TextBox tbDestinationCost;
        private System.Windows.Forms.TextBox tbPackageName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDestinationName;
        private System.Windows.Forms.Label er;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
    }
}