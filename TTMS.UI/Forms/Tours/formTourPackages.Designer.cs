namespace TTMS.UI.Forms.Tours
{
    partial class formTourPackages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTourPackages));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteItinerary = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDestination = new System.Windows.Forms.DataGridView();
            this.clmDestName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tourDestinationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packageDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packageDataSet = new TTMS.UI.Dataset.PackageDataSet();
            this.btnAddItinerary = new System.Windows.Forms.Button();
            this.lblCreateDestination = new System.Windows.Forms.Label();
            this.tbTotalSeats = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvTourPackage = new System.Windows.Forms.DataGridView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPackageDesc = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.pbPackageImg = new System.Windows.Forms.PictureBox();
            this.lblPackageId = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbPackageName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tourDestinationsTableAdapter = new TTMS.UI.Dataset.PackageDataSetTableAdapters.TourDestinationsTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDestinationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPackageImg)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tbTotalSeats);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.dgvTourPackage);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbPackageDesc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAddImg);
            this.panel1.Controls.Add(this.pbPackageImg);
            this.panel1.Controls.Add(this.lblPackageId);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.tbPackageName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1345, 710);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(690, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnDeleteItinerary);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvDestination);
            this.groupBox1.Controls.Add(this.btnAddItinerary);
            this.groupBox1.Controls.Add(this.lblCreateDestination);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(426, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 252);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Destinations";
            // 
            // btnDeleteItinerary
            // 
            this.btnDeleteItinerary.Location = new System.Drawing.Point(407, 135);
            this.btnDeleteItinerary.Name = "btnDeleteItinerary";
            this.btnDeleteItinerary.Size = new System.Drawing.Size(42, 42);
            this.btnDeleteItinerary.TabIndex = 48;
            this.btnDeleteItinerary.UseVisualStyleBackColor = true;
            this.btnDeleteItinerary.Click += new System.EventHandler(this.btnDeleteItinerary_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(204, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "OR";
            // 
            // dgvDestination
            // 
            this.dgvDestination.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDestination.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDestName});
            this.dgvDestination.Location = new System.Drawing.Point(11, 33);
            this.dgvDestination.Name = "dgvDestination";
            this.dgvDestination.RowHeadersVisible = false;
            this.dgvDestination.RowHeadersWidth = 51;
            this.dgvDestination.RowTemplate.Height = 24;
            this.dgvDestination.Size = new System.Drawing.Size(389, 166);
            this.dgvDestination.TabIndex = 42;
            // 
            // clmDestName
            // 
            this.clmDestName.DataSource = this.tourDestinationsBindingSource;
            this.clmDestName.DisplayMember = "DestinationName";
            this.clmDestName.HeaderText = "Destination Name";
            this.clmDestName.MinimumWidth = 6;
            this.clmDestName.Name = "clmDestName";
            this.clmDestName.ValueMember = "DestinationId";
            this.clmDestName.Width = 250;
            // 
            // tourDestinationsBindingSource
            // 
            this.tourDestinationsBindingSource.DataMember = "TourDestinations";
            this.tourDestinationsBindingSource.DataSource = this.packageDataSetBindingSource;
            // 
            // packageDataSetBindingSource
            // 
            this.packageDataSetBindingSource.DataSource = this.packageDataSet;
            this.packageDataSetBindingSource.Position = 0;
            // 
            // packageDataSet
            // 
            this.packageDataSet.DataSetName = "PackageDataSet";
            this.packageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddItinerary
            // 
            this.btnAddItinerary.Location = new System.Drawing.Point(407, 51);
            this.btnAddItinerary.Name = "btnAddItinerary";
            this.btnAddItinerary.Size = new System.Drawing.Size(42, 42);
            this.btnAddItinerary.TabIndex = 47;
            this.btnAddItinerary.UseVisualStyleBackColor = true;
            this.btnAddItinerary.Click += new System.EventHandler(this.btnAddItinerary_Click);
            // 
            // lblCreateDestination
            // 
            this.lblCreateDestination.AutoSize = true;
            this.lblCreateDestination.Font = new System.Drawing.Font("Sylfaen", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDestination.ForeColor = System.Drawing.Color.Black;
            this.lblCreateDestination.Location = new System.Drawing.Point(131, 224);
            this.lblCreateDestination.Name = "lblCreateDestination";
            this.lblCreateDestination.Size = new System.Drawing.Size(193, 22);
            this.lblCreateDestination.TabIndex = 45;
            this.lblCreateDestination.Text = "Create New Destination !";
            this.lblCreateDestination.Click += new System.EventHandler(this.lblCreateDestination_Click);
            // 
            // tbTotalSeats
            // 
            this.tbTotalSeats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTotalSeats.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalSeats.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbTotalSeats.Location = new System.Drawing.Point(748, 388);
            this.tbTotalSeats.Name = "tbTotalSeats";
            this.tbTotalSeats.Size = new System.Drawing.Size(63, 25);
            this.tbTotalSeats.TabIndex = 48;
            this.tbTotalSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(493, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Total Seats Allocated:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(748, 413);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(63, 3);
            this.panel5.TabIndex = 46;
            // 
            // dgvTourPackage
            // 
            this.dgvTourPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourPackage.Location = new System.Drawing.Point(29, 527);
            this.dgvTourPackage.Name = "dgvTourPackage";
            this.dgvTourPackage.RowHeadersWidth = 51;
            this.dgvTourPackage.RowTemplate.Height = 24;
            this.dgvTourPackage.Size = new System.Drawing.Size(852, 167);
            this.dgvTourPackage.TabIndex = 44;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPrice.Location = new System.Drawing.Point(714, 434);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(117, 25);
            this.lblPrice.TabIndex = 43;
            this.lblPrice.Text = "               ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(484, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "~Price Per Person:";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(561, 480);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 32);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(437, 480);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(312, 480);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 37;
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
            this.btnAdd.Location = new System.Drawing.Point(186, 480);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 32);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbPackageDesc
            // 
            this.tbPackageDesc.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPackageDesc.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPackageDesc.Location = new System.Drawing.Point(29, 135);
            this.tbPackageDesc.Name = "tbPackageDesc";
            this.tbPackageDesc.Size = new System.Drawing.Size(384, 79);
            this.tbPackageDesc.TabIndex = 34;
            this.tbPackageDesc.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(32, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Package Description:";
            // 
            // btnAddImg
            // 
            this.btnAddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImg.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAddImg.Image = ((System.Drawing.Image)(resources.GetObject("btnAddImg.Image")));
            this.btnAddImg.Location = new System.Drawing.Point(29, 408);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(53, 51);
            this.btnAddImg.TabIndex = 32;
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // pbPackageImg
            // 
            this.pbPackageImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPackageImg.Location = new System.Drawing.Point(29, 231);
            this.pbPackageImg.Name = "pbPackageImg";
            this.pbPackageImg.Size = new System.Drawing.Size(384, 228);
            this.pbPackageImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPackageImg.TabIndex = 31;
            this.pbPackageImg.TabStop = false;
            // 
            // lblPackageId
            // 
            this.lblPackageId.AutoSize = true;
            this.lblPackageId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPackageId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblPackageId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPackageId.Location = new System.Drawing.Point(175, 70);
            this.lblPackageId.Name = "lblPackageId";
            this.lblPackageId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPackageId.Size = new System.Drawing.Size(82, 25);
            this.lblPackageId.TabIndex = 30;
            this.lblPackageId.Text = "          ";
            // 
            // tbPrice
            // 
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPrice.Location = new System.Drawing.Point(832, 434);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(77, 25);
            this.tbPrice.TabIndex = 29;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPackageName
            // 
            this.tbPackageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPackageName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPackageName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPackageName.Location = new System.Drawing.Point(464, 70);
            this.tbPackageName.Name = "tbPackageName";
            this.tbPackageName.Size = new System.Drawing.Size(404, 25);
            this.tbPackageName.TabIndex = 29;
            this.tbPackageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(832, 459);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(77, 3);
            this.panel3.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(274, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Package Name:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(464, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(404, 3);
            this.panel4.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(24, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Package Id:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1345, 50);
            this.panel2.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1301, 1);
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
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(223, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(423, 50);
            this.label6.TabIndex = 12;
            this.label6.Text = "TOUR PACKAGES";
            // 
            // tourDestinationsTableAdapter
            // 
            this.tourDestinationsTableAdapter.ClearBeforeFill = true;
            // 
            // formTourPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 710);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formTourPackages";
            this.Text = "TourPackages";
            this.Load += new System.EventHandler(this.frmTourPackages_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDestinationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPackageImg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox tbPackageDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.PictureBox pbPackageImg;
        private System.Windows.Forms.Label lblPackageId;
        private System.Windows.Forms.TextBox tbPackageName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTourPackage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCreateDestination;
        private System.Windows.Forms.TextBox tbTotalSeats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private Dataset.PackageDataSet packageDataSet;
        private System.Windows.Forms.BindingSource packageDataSetBindingSource;
        private System.Windows.Forms.BindingSource tourDestinationsBindingSource;
        private Dataset.PackageDataSetTableAdapters.TourDestinationsTableAdapter tourDestinationsTableAdapter;
        private System.Windows.Forms.Button btnDeleteItinerary;
        private System.Windows.Forms.Button btnAddItinerary;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmDestName;
    }
}