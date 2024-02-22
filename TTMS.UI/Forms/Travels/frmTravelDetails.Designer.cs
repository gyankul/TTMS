namespace TTMS.UI.Forms.Travels
{
    partial class frmTravelDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTravelDetails = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteStops = new System.Windows.Forms.Button();
            this.btnAddStops = new System.Windows.Forms.Button();
            this.dgvStops = new System.Windows.Forms.DataGridView();
            this.clmStopNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStopName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbVehicleId = new System.Windows.Forms.ComboBox();
            this.vehicleDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDetailDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelDetailDataSet = new TTMS.UI.Dataset.TravelDetailDataSet();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTravelName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbTravelId = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.vehicleDetailsTableAdapter = new TTMS.UI.Dataset.TravelDetailDataSetTableAdapters.VehicleDetailsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravelDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDetailDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDetailDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvTravelDetails);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cbVehicleId);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbTravelName);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.tbTravelId);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 633);
            this.panel1.TabIndex = 0;
            // 
            // dgvTravelDetails
            // 
            this.dgvTravelDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTravelDetails.Location = new System.Drawing.Point(26, 465);
            this.dgvTravelDetails.Name = "dgvTravelDetails";
            this.dgvTravelDetails.RowHeadersWidth = 51;
            this.dgvTravelDetails.RowTemplate.Height = 24;
            this.dgvTravelDetails.Size = new System.Drawing.Size(747, 150);
            this.dgvTravelDetails.TabIndex = 41;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(631, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 32);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(631, 343);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(631, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 39;
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
            this.btnAdd.Location = new System.Drawing.Point(631, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 32);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnDeleteStops);
            this.groupBox1.Controls.Add(this.btnAddStops);
            this.groupBox1.Controls.Add(this.dgvStops);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(43, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 251);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Stops";
            // 
            // btnDeleteStops
            // 
            this.btnDeleteStops.Image = global::TTMS.UI.Properties.Resources.icons8_remove_401;
            this.btnDeleteStops.Location = new System.Drawing.Point(454, 147);
            this.btnDeleteStops.Name = "btnDeleteStops";
            this.btnDeleteStops.Size = new System.Drawing.Size(54, 56);
            this.btnDeleteStops.TabIndex = 30;
            this.btnDeleteStops.UseVisualStyleBackColor = true;
            this.btnDeleteStops.Click += new System.EventHandler(this.btnDeleteStops_Click);
            // 
            // btnAddStops
            // 
            this.btnAddStops.Image = global::TTMS.UI.Properties.Resources.icons8_plus_40;
            this.btnAddStops.Location = new System.Drawing.Point(454, 65);
            this.btnAddStops.Name = "btnAddStops";
            this.btnAddStops.Size = new System.Drawing.Size(54, 57);
            this.btnAddStops.TabIndex = 29;
            this.btnAddStops.UseVisualStyleBackColor = true;
            this.btnAddStops.Click += new System.EventHandler(this.btnAddStops_Click);
            // 
            // dgvStops
            // 
            this.dgvStops.AllowUserToAddRows = false;
            this.dgvStops.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStops.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStopNo,
            this.clmStopName,
            this.clmDistance});
            this.dgvStops.Location = new System.Drawing.Point(15, 33);
            this.dgvStops.Name = "dgvStops";
            this.dgvStops.RowHeadersVisible = false;
            this.dgvStops.RowHeadersWidth = 51;
            this.dgvStops.RowTemplate.Height = 40;
            this.dgvStops.Size = new System.Drawing.Size(433, 203);
            this.dgvStops.TabIndex = 0;
            // 
            // clmStopNo
            // 
            this.clmStopNo.HeaderText = "Stop No.";
            this.clmStopNo.MinimumWidth = 6;
            this.clmStopNo.Name = "clmStopNo";
            this.clmStopNo.Width = 80;
            // 
            // clmStopName
            // 
            this.clmStopName.HeaderText = "Stop Name";
            this.clmStopName.Items.AddRange(new object[] {
            "Sure! Here\'s the extended list with 151 important cities in Maharashtra, arranged" +
                " in alphabetical order, each in its own row:",
            "",
            "Ahmednagar  ",
            "Akluj  ",
            "Akola  ",
            "Akot  ",
            "Alibag  ",
            "Amalner  ",
            "Ambajogai  ",
            "Ambarnath  ",
            "Ambejogai  ",
            "Amravati  ",
            "Arvi  ",
            "Athni  ",
            "Aurangabad  ",
            "Ausa  ",
            "Ballarpur  ",
            "Baramati  ",
            "Barshi  ",
            "Basmat  ",
            "Bhandara  ",
            "Bhadravati  ",
            "Bhivandi  ",
            "Bhor  ",
            "Bhusaval  ",
            "Bhusawal  ",
            "Beed  ",
            "Bhokar  ",
            "Borivli  ",
            "Chalisgaon  ",
            "Chandrapur  ",
            "Chandvad  ",
            "Chikhli  ",
            "Chiplun  ",
            "Chopda  ",
            "Daund  ",
            "Dahanu  ",
            "Dapoli  ",
            "Daryapur  ",
            "Dharmabad  ",
            "Dhule  ",
            "Dombivli  ",
            "Gadhinglaj  ",
            "Gadchiroli  ",
            "Gangakhed  ",
            "Ghatanji  ",
            "Gokak  ",
            "Gondia  ",
            "Gondiya  ",
            "Goregaon  ",
            "Harnai  ",
            "Hinganghat  ",
            "Hingoli  ",
            "Ichalkaranji  ",
            "Igatpuri  ",
            "Islampur  ",
            "Jalgaon  ",
            "Jalgaon Jamod  ",
            "Jalna  ",
            "Jamkhed  ",
            "Jamner  ",
            "Jath  ",
            "Jejuri  ",
            "Junnar  ",
            "Kaij  ",
            "Kalamb  ",
            "Kallam  ",
            "Kalyan  ",
            "Kamthi  ",
            "Kannad  ",
            "Karad  ",
            "Karmala  ",
            "Kavathe Mahankal  ",
            "Kinwat  ",
            "Kolhapur  ",
            "Kopargaon  ",
            "Kudal  ",
            "Kudal  ",
            "Kurduvadi  ",
            "Kusumba  ",
            "Lasalgaon  ",
            "Latur  ",
            "Lonar  ",
            "Lonavala  ",
            "Lote  ",
            "Mahad  ",
            "Mahu  ",
            "Malvan  ",
            "Manchar  ",
            "Mangalvedhe  ",
            "Mangrulpir  ",
            "Manjlegaon  ",
            "Mhaswad  ",
            "Mira-Bhayandar  ",
            "Miraj  ",
            "Morshi  ",
            "Mudkhed  ",
            "Mukhed  ",
            "Mumbai  ",
            "Murtijapur  ",
            "Murud  ",
            "Nagardeole  ",
            "Nagbhir  ",
            "Nagpur  ",
            "Naldurg  ",
            "Nanded  ",
            "Nandgaon  ",
            "Nandurbar  ",
            "Narkhed  ",
            "Naigaon  ",
            "Nalasopara  ",
            "Nashik  ",
            "Navapur  ",
            "Navi Mumbai  ",
            "Nawapur  ",
            "Nevasa  ",
            "Nilanga  ",
            "Osmanabad  ",
            "Paithan  ",
            "Palghar  ",
            "Pandharkaoda  ",
            "Pandharpur  ",
            "Pandhurna  ",
            "Panvel  ",
            "Parbhani  ",
            "Parli  ",
            "Pathardi  ",
            "Pathri  ",
            "Patur  ",
            "Pen  ",
            "Phaltan  ",
            "Pimpri-Chinchwad  ",
            "Pune  ",
            "Pulgaon  ",
            "Pusad  ",
            "Raigad  ",
            "Rahuri  ",
            "Rajgurunagar  ",
            "Rajura  ",
            "Ramtek  ",
            "Ratnagiri  ",
            "Raver  ",
            "Sailu  ",
            "Sakoli  ",
            "Sakri  ",
            "Sandur  ",
            "Sangamner  ",
            "Sangli  ",
            "Sangole  ",
            "Saoner  ",
            "Saundatti-Yellamma  ",
            "Savner  ",
            "Sawantwadi  ",
            "Shahada  ",
            "Shendurjana  ",
            "Shevgaon  ",
            "Shiggaon  ",
            "Shrigonda  ",
            "Shrirampur  ",
            "Sillod  ",
            "Sinnar  ",
            "Solapur  ",
            "Soyagaon  ",
            "Talegaon Dabhade  ",
            "Talode  ",
            "Tasgaon  ",
            "Thane  ",
            "Tirora  ",
            "Tuljapur  ",
            "Tumsar  ",
            "Uchgaon  ",
            "Udgir  ",
            "Ulhasnagar  ",
            "Umarga  ",
            "Umarkhed  ",
            "Umred  ",
            "Uran  ",
            "Uran Islampur  ",
            "Urun-Islampur  ",
            "Uthiramerur  ",
            "Vaduj  ",
            "Vaijapur  ",
            "Vasai-Virar  ",
            "Vita  ",
            "Wadgaon Road  ",
            "Wai  ",
            "Wani  ",
            "Wardha  ",
            "Washim  ",
            "Yawal  ",
            "Yawal  ",
            "Yevla  ",
            "Yeola  "});
            this.clmStopName.MinimumWidth = 6;
            this.clmStopName.Name = "clmStopName";
            this.clmStopName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmStopName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmStopName.Width = 200;
            // 
            // clmDistance
            // 
            this.clmDistance.HeaderText = "Distance from SRC (in Km)";
            this.clmDistance.MinimumWidth = 6;
            this.clmDistance.Name = "clmDistance";
            this.clmDistance.Width = 150;
            // 
            // cbVehicleId
            // 
            this.cbVehicleId.DataSource = this.vehicleDetailsBindingSource;
            this.cbVehicleId.DisplayMember = "VehicleName";
            this.cbVehicleId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cbVehicleId.FormattingEnabled = true;
            this.cbVehicleId.Location = new System.Drawing.Point(189, 133);
            this.cbVehicleId.Name = "cbVehicleId";
            this.cbVehicleId.Size = new System.Drawing.Size(285, 33);
            this.cbVehicleId.TabIndex = 35;
            this.cbVehicleId.ValueMember = "VehicleId";
            // 
            // vehicleDetailsBindingSource
            // 
            this.vehicleDetailsBindingSource.DataMember = "VehicleDetails";
            this.vehicleDetailsBindingSource.DataSource = this.travelDetailDataSetBindingSource;
            // 
            // travelDetailDataSetBindingSource
            // 
            this.travelDetailDataSetBindingSource.DataSource = this.travelDetailDataSet;
            this.travelDetailDataSetBindingSource.Position = 0;
            // 
            // travelDetailDataSet
            // 
            this.travelDetailDataSet.DataSetName = "TravelDetailDataSet";
            this.travelDetailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(189, 166);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(285, 3);
            this.panel5.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(15, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Vehicle Name:";
            // 
            // tbTravelName
            // 
            this.tbTravelName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTravelName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTravelName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbTravelName.Location = new System.Drawing.Point(441, 69);
            this.tbTravelName.Name = "tbTravelName";
            this.tbTravelName.Size = new System.Drawing.Size(332, 25);
            this.tbTravelName.TabIndex = 29;
            this.tbTravelName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(441, 97);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 3);
            this.panel4.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(274, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Travel Name:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.textBox3.Location = new System.Drawing.Point(649, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(93, 25);
            this.textBox3.TabIndex = 26;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTravelId
            // 
            this.tbTravelId.BackColor = System.Drawing.Color.White;
            this.tbTravelId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTravelId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTravelId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbTravelId.Location = new System.Drawing.Point(149, 69);
            this.tbTravelId.Name = "tbTravelId";
            this.tbTravelId.ReadOnly = true;
            this.tbTravelId.Size = new System.Drawing.Size(93, 25);
            this.tbTravelId.TabIndex = 26;
            this.tbTravelId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(649, 162);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(93, 3);
            this.panel6.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(149, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(93, 3);
            this.panel3.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(498, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Total Seats:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Travel Id:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TTMS.UI.Properties.Resources.icons8_close_302;
            this.btnClose.Location = new System.Drawing.Point(755, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 39);
            this.btnClose.TabIndex = 16;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(180, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(431, 50);
            this.label6.TabIndex = 15;
            this.label6.Text = "TRAVEL DETAILS";
            // 
            // vehicleDetailsTableAdapter
            // 
            this.vehicleDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frmTravelDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTravelDetails";
            this.Text = "frmTravelDetails";
            this.Load += new System.EventHandler(this.formTravelDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravelDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDetailDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelDetailDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTravelId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTravelName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbVehicleId;
        private System.Windows.Forms.DataGridView dgvStops;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteStops;
        private System.Windows.Forms.Button btnAddStops;
        private System.Windows.Forms.BindingSource travelDetailDataSetBindingSource;
        private Dataset.TravelDetailDataSet travelDetailDataSet;
        private System.Windows.Forms.BindingSource vehicleDetailsBindingSource;
        private Dataset.TravelDetailDataSetTableAdapters.VehicleDetailsTableAdapter vehicleDetailsTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTravelDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStopNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmStopName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDistance;
    }
}