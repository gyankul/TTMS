namespace TTMS.UI.Forms.Vehicle___Driver
{
    partial class frmVehicleDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvVehicleDetails = new System.Windows.Forms.DataGridView();
            this.cbSeatingType = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbDrivername = new System.Windows.Forms.ComboBox();
            this.driverDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverDetailsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverDetailsDataSet = new TTMS.UI.Dataset.DriverDetailsDataSet();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVehicleName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSeatingCapacity = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVehicleLicenceNo = new System.Windows.Forms.TextBox();
            this.tbvehicleId = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.driverDetailsTableAdapter = new TTMS.UI.Dataset.DriverDetailsDataSetTableAdapters.DriverDetailsTableAdapter();
            this.btnLoadItems = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverDetailsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverDetailsDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLoadItems);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.dgvVehicleDetails);
            this.panel1.Controls.Add(this.cbSeatingType);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.cbDrivername);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbVehicleName);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbSeatingCapacity);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbVehicleLicenceNo);
            this.panel1.Controls.Add(this.tbvehicleId);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 488);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(497, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 32);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(373, 420);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(248, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 42;
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
            this.btnAdd.Location = new System.Drawing.Point(122, 420);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 32);
            this.btnAdd.TabIndex = 43;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvVehicleDetails
            // 
            this.dgvVehicleDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleDetails.Location = new System.Drawing.Point(17, 237);
            this.dgvVehicleDetails.Name = "dgvVehicleDetails";
            this.dgvVehicleDetails.RowHeadersWidth = 51;
            this.dgvVehicleDetails.RowTemplate.Height = 24;
            this.dgvVehicleDetails.Size = new System.Drawing.Size(787, 150);
            this.dgvVehicleDetails.TabIndex = 39;
            this.dgvVehicleDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicleDetails_CellClick);
            this.dgvVehicleDetails.SelectionChanged += new System.EventHandler(this.dgvVehicleDetails_SelectionChanged);
            // 
            // cbSeatingType
            // 
            this.cbSeatingType.DisplayMember = "DriverId";
            this.cbSeatingType.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeatingType.FormattingEnabled = true;
            this.cbSeatingType.Items.AddRange(new object[] {
            "Seating/Recliner",
            "Sleeper"});
            this.cbSeatingType.Location = new System.Drawing.Point(179, 121);
            this.cbSeatingType.Name = "cbSeatingType";
            this.cbSeatingType.Size = new System.Drawing.Size(231, 28);
            this.cbSeatingType.TabIndex = 38;
            this.cbSeatingType.ValueMember = "DriverId";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(179, 149);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(231, 3);
            this.panel7.TabIndex = 37;
            // 
            // cbDrivername
            // 
            this.cbDrivername.DataSource = this.driverDetailsBindingSource;
            this.cbDrivername.DisplayMember = "DriverName";
            this.cbDrivername.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDrivername.FormattingEnabled = true;
            this.cbDrivername.Location = new System.Drawing.Point(598, 174);
            this.cbDrivername.Name = "cbDrivername";
            this.cbDrivername.Size = new System.Drawing.Size(206, 28);
            this.cbDrivername.TabIndex = 38;
            this.cbDrivername.ValueMember = "DriverId";
            // 
            // driverDetailsBindingSource
            // 
            this.driverDetailsBindingSource.DataMember = "DriverDetails";
            this.driverDetailsBindingSource.DataSource = this.driverDetailsDataSetBindingSource;
            // 
            // driverDetailsDataSetBindingSource
            // 
            this.driverDetailsDataSetBindingSource.DataSource = this.driverDetailsDataSet;
            this.driverDetailsDataSetBindingSource.Position = 0;
            // 
            // driverDetailsDataSet
            // 
            this.driverDetailsDataSet.DataSetName = "DriverDetailsDataSet";
            this.driverDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(598, 202);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(206, 3);
            this.panel6.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(431, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Driver Name:";
            // 
            // tbVehicleName
            // 
            this.tbVehicleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVehicleName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehicleName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbVehicleName.Location = new System.Drawing.Point(462, 73);
            this.tbVehicleName.Name = "tbVehicleName";
            this.tbVehicleName.Size = new System.Drawing.Size(342, 25);
            this.tbVehicleName.TabIndex = 35;
            this.tbVehicleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(462, 101);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(342, 3);
            this.panel5.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(287, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Vehicle name:";
            // 
            // tbSeatingCapacity
            // 
            this.tbSeatingCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSeatingCapacity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSeatingCapacity.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbSeatingCapacity.Location = new System.Drawing.Point(669, 127);
            this.tbSeatingCapacity.Name = "tbSeatingCapacity";
            this.tbSeatingCapacity.Size = new System.Drawing.Size(135, 25);
            this.tbSeatingCapacity.TabIndex = 32;
            this.tbSeatingCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(669, 154);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(135, 3);
            this.panel4.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(457, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Seating Capacity:";
            // 
            // tbVehicleLicenceNo
            // 
            this.tbVehicleLicenceNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVehicleLicenceNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVehicleLicenceNo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbVehicleLicenceNo.Location = new System.Drawing.Point(224, 174);
            this.tbVehicleLicenceNo.Name = "tbVehicleLicenceNo";
            this.tbVehicleLicenceNo.Size = new System.Drawing.Size(186, 25);
            this.tbVehicleLicenceNo.TabIndex = 29;
            this.tbVehicleLicenceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbvehicleId
            // 
            this.tbvehicleId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbvehicleId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbvehicleId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbvehicleId.Location = new System.Drawing.Point(151, 70);
            this.tbvehicleId.Name = "tbvehicleId";
            this.tbvehicleId.Size = new System.Drawing.Size(93, 25);
            this.tbvehicleId.TabIndex = 29;
            this.tbvehicleId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(224, 202);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(186, 3);
            this.panel8.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(151, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(93, 3);
            this.panel3.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Seating Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(12, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Licence Plate No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Vehicle Id:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 50);
            this.panel2.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(774, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 39);
            this.btnClose.TabIndex = 17;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(178, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(448, 50);
            this.label6.TabIndex = 16;
            this.label6.Text = "VEHICLE DETAILS";
            // 
            // driverDetailsTableAdapter
            // 
            this.driverDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btnLoadItems
            // 
            this.btnLoadItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadItems.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLoadItems.Location = new System.Drawing.Point(619, 420);
            this.btnLoadItems.Name = "btnLoadItems";
            this.btnLoadItems.Size = new System.Drawing.Size(96, 32);
            this.btnLoadItems.TabIndex = 40;
            this.btnLoadItems.Text = "LOAD";
            this.btnLoadItems.UseVisualStyleBackColor = true;
            this.btnLoadItems.Click += new System.EventHandler(this.btnLoadItems_Click);
            // 
            // frmVehicleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 488);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVehicleDetails";
            this.Text = "frmVehicleDetails";
            this.Load += new System.EventHandler(this.frmVehicleDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverDetailsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverDetailsDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbvehicleId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSeatingCapacity;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVehicleName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDrivername;
        private System.Windows.Forms.DataGridView dgvVehicleDetails;
        private System.Windows.Forms.BindingSource driverDetailsDataSetBindingSource;
        private Dataset.DriverDetailsDataSet driverDetailsDataSet;
        private System.Windows.Forms.BindingSource driverDetailsBindingSource;
        private Dataset.DriverDetailsDataSetTableAdapters.DriverDetailsTableAdapter driverDetailsTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSeatingType;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbVehicleLicenceNo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLoadItems;
    }
}