namespace TTMS.UI.Tours
{
    partial class frmTourItinerary
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
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.tbItineraryName = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbSRNO = new System.Windows.Forms.TextBox();
            this.tbItineraryId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTourItinerary = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbActivity = new System.Windows.Forms.RichTextBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.ImgItinerary = new System.Windows.Forms.PictureBox();
            this.tbDayNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbItineraryNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tourDataSet = new TTMS.UI.Dataset.TourDataSet();
            this.tourDestinationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourDestinationsTableAdapter = new TTMS.UI.Dataset.TourDataSetTableAdapters.TourDestinationsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourItinerary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgItinerary)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDestinationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbDestination);
            this.panel1.Controls.Add(this.tbItineraryName);
            this.panel1.Controls.Add(this.tbCost);
            this.panel1.Controls.Add(this.tbSRNO);
            this.panel1.Controls.Add(this.tbItineraryId);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvTourItinerary);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAddImg);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbActivity);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.ImgItinerary);
            this.panel1.Controls.Add(this.tbDayNumber);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbItineraryNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 642);
            this.panel1.TabIndex = 0;
            // 
            // cbDestination
            // 
            this.cbDestination.DataSource = this.tourDestinationsBindingSource;
            this.cbDestination.DisplayMember = "DestinationName";
            this.cbDestination.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(174, 127);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(274, 28);
            this.cbDestination.TabIndex = 24;
            this.cbDestination.ValueMember = "DestinationId";
            // 
            // tbItineraryName
            // 
            this.tbItineraryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbItineraryName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItineraryName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbItineraryName.Location = new System.Drawing.Point(494, 77);
            this.tbItineraryName.Name = "tbItineraryName";
            this.tbItineraryName.Size = new System.Drawing.Size(314, 25);
            this.tbItineraryName.TabIndex = 23;
            this.tbItineraryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbCost
            // 
            this.tbCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCost.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCost.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbCost.Location = new System.Drawing.Point(686, 364);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(113, 25);
            this.tbCost.TabIndex = 23;
            this.tbCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSRNO
            // 
            this.tbSRNO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSRNO.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSRNO.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbSRNO.Location = new System.Drawing.Point(575, 213);
            this.tbSRNO.Name = "tbSRNO";
            this.tbSRNO.Size = new System.Drawing.Size(50, 25);
            this.tbSRNO.TabIndex = 23;
            this.tbSRNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbItineraryId
            // 
            this.tbItineraryId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbItineraryId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItineraryId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbItineraryId.Location = new System.Drawing.Point(174, 77);
            this.tbItineraryId.Name = "tbItineraryId";
            this.tbItineraryId.Size = new System.Drawing.Size(93, 25);
            this.tbItineraryId.TabIndex = 23;
            this.tbItineraryId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(494, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 3);
            this.panel3.TabIndex = 22;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(686, 392);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(113, 3);
            this.panel7.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(575, 241);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(50, 3);
            this.panel6.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(174, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 3);
            this.panel2.TabIndex = 22;
            // 
            // dgvTourItinerary
            // 
            this.dgvTourItinerary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourItinerary.Location = new System.Drawing.Point(21, 454);
            this.dgvTourItinerary.Name = "dgvTourItinerary";
            this.dgvTourItinerary.RowHeadersWidth = 51;
            this.dgvTourItinerary.RowTemplate.Height = 24;
            this.dgvTourItinerary.Size = new System.Drawing.Size(831, 177);
            this.dgvTourItinerary.TabIndex = 21;
            this.dgvTourItinerary.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTourItinerary_CellMouseClick);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(566, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 32);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(442, 413);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(317, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddImg
            // 
            this.btnAddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImg.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAddImg.Image = global::TTMS.UI.Properties.Resources.icons8_image_plus_48;
            this.btnAddImg.Location = new System.Drawing.Point(21, 347);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(53, 51);
            this.btnAddImg.TabIndex = 20;
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Location = new System.Drawing.Point(191, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 32);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbActivity
            // 
            this.tbActivity.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActivity.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbActivity.Location = new System.Drawing.Point(416, 295);
            this.tbActivity.Name = "tbActivity";
            this.tbActivity.Size = new System.Drawing.Size(424, 54);
            this.tbActivity.TabIndex = 19;
            this.tbActivity.Text = "";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarForeColor = System.Drawing.Color.RoyalBlue;
            this.dtpEnd.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpEnd.CalendarTitleForeColor = System.Drawing.Color.RoyalBlue;
            this.dtpEnd.CustomFormat = "dd/MM/yyyy   hh:mm:ss";
            this.dtpEnd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(600, 168);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(252, 28);
            this.dtpEnd.TabIndex = 18;
            this.dtpEnd.Value = new System.DateTime(2024, 1, 28, 13, 17, 23, 0);
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarForeColor = System.Drawing.Color.RoyalBlue;
            this.dtpStart.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpStart.CalendarTitleForeColor = System.Drawing.Color.RoyalBlue;
            this.dtpStart.CustomFormat = "dd/MM/yyyy   hh:mm:ss";
            this.dtpStart.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(600, 129);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(252, 28);
            this.dtpStart.TabIndex = 18;
            this.dtpStart.Value = new System.DateTime(2024, 1, 28, 13, 17, 18, 0);
            // 
            // ImgItinerary
            // 
            this.ImgItinerary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgItinerary.Location = new System.Drawing.Point(21, 179);
            this.ImgItinerary.Name = "ImgItinerary";
            this.ImgItinerary.Size = new System.Drawing.Size(384, 219);
            this.ImgItinerary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgItinerary.TabIndex = 17;
            this.ImgItinerary.TabStop = false;
            // 
            // tbDayNumber
            // 
            this.tbDayNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDayNumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDayNumber.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbDayNumber.Location = new System.Drawing.Point(796, 214);
            this.tbDayNumber.Name = "tbDayNumber";
            this.tbDayNumber.Size = new System.Drawing.Size(56, 25);
            this.tbDayNumber.TabIndex = 14;
            this.tbDayNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(502, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Activity Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(467, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "End Event:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(454, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Start Event:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(631, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Day Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(19, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Destination:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(174, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 3);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(796, 241);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(56, 3);
            this.panel5.TabIndex = 12;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl.Location = new System.Drawing.Point(297, 82);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(191, 25);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Itinerary Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(459, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cost (Per Person):";
            // 
            // tbItineraryNo
            // 
            this.tbItineraryNo.AutoSize = true;
            this.tbItineraryNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItineraryNo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbItineraryNo.Location = new System.Drawing.Point(411, 218);
            this.tbItineraryNo.Name = "tbItineraryNo";
            this.tbItineraryNo.Size = new System.Drawing.Size(158, 25);
            this.tbItineraryNo.TabIndex = 1;
            this.tbItineraryNo.Text = "Itinerary No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Itinerary Id:";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel.Controls.Add(this.btnClose);
            this.panel.Controls.Add(this.label6);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(867, 66);
            this.panel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TTMS.UI.Properties.Resources.icons8_close_302;
            this.btnClose.Location = new System.Drawing.Point(822, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 39);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(181, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(430, 50);
            this.label6.TabIndex = 11;
            this.label6.Text = "TOUR ITINERARY";
            // 
            // tourDataSet
            // 
            this.tourDataSet.DataSetName = "TourDataSet";
            this.tourDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tourDestinationsBindingSource
            // 
            this.tourDestinationsBindingSource.DataMember = "TourDestinations";
            this.tourDestinationsBindingSource.DataSource = this.tourDataSet;
            // 
            // tourDestinationsTableAdapter
            // 
            this.tourDestinationsTableAdapter.ClearBeforeFill = true;
            // 
            // frmTourItinerary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 642);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTourItinerary";
            this.Text = "TourItinerary";
            this.Load += new System.EventHandler(this.TourItinerary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourItinerary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgItinerary)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDestinationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ImgItinerary;
        private System.Windows.Forms.TextBox tbDayNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tbActivity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvTourItinerary;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbItineraryId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.TextBox tbItineraryName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tbSRNO;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label tbItineraryNo;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private Dataset.TourDataSet tourDataSet;
        private System.Windows.Forms.BindingSource tourDestinationsBindingSource;
        private Dataset.TourDataSetTableAdapters.TourDestinationsTableAdapter tourDestinationsTableAdapter;
    }
}