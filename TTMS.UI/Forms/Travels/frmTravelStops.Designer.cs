namespace TTMS.UI.Forms.Travels
{
    partial class frmTravelStops
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbStopName = new System.Windows.Forms.ComboBox();
            this.cbTravelName = new System.Windows.Forms.ComboBox();
            this.tbPackageName = new System.Windows.Forms.TextBox();
            this.tbSeats = new System.Windows.Forms.TextBox();
            this.tbStopNo = new System.Windows.Forms.TextBox();
            this.tbStopId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvTourPackage = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbItineraryName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourPackage)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 610);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.cbStopName);
            this.panel7.Controls.Add(this.cbTravelName);
            this.panel7.Controls.Add(this.tbPackageName);
            this.panel7.Controls.Add(this.tbSeats);
            this.panel7.Controls.Add(this.tbStopNo);
            this.panel7.Controls.Add(this.tbStopId);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.dgvTourPackage);
            this.panel7.Controls.Add(this.btnDelete);
            this.panel7.Controls.Add(this.btnUpdate);
            this.panel7.Controls.Add(this.btnSave);
            this.panel7.Controls.Add(this.btnAdd);
            this.panel7.Controls.Add(this.tbItineraryName);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.panel);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1071, 610);
            this.panel7.TabIndex = 3;
            // 
            // cbStopName
            // 
            this.cbStopName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStopName.FormattingEnabled = true;
            this.cbStopName.Items.AddRange(new object[] {
            "Ahmednagar  ",
            "Akluj  ",
            "Akola  ",
            "Alibag  ",
            "Amravati  ",
            "Ambajogai  ",
            "Aurangabad  ",
            "Bhiwandi  ",
            "Bhusawal  ",
            "Beed  ",
            "Barsi  ",
            "Buldhana  ",
            "Chalisgaon  ",
            "Chandrapur  ",
            "Chiplun  ",
            "Deolali  ",
            "Dhulia  ",
            "Dhule  ",
            "Dombivli  ",
            "Gadhinglaj  ",
            "Gadchiroli  ",
            "Gondia  ",
            "Gondiya  ",
            "Hingoli  ",
            "Ichalkaranji  ",
            "Jalgaon  ",
            "Jalgaon Jamod  ",
            "Jalna  ",
            "Junnar  ",
            "Karad  ",
            "Kalyan  ",
            "Karanja  ",
            "Kolhapur  ",
            "Latur  ",
            "Lonavala  ",
            "Mahad  ",
            "Mahadula  ",
            "Manmad  ",
            "Malkapur  ",
            "Mira-Bhayandar  ",
            "Mumbai  ",
            "Nagpur  ",
            "Nanded  ",
            "Nashik  ",
            "Navi Mumbai  ",
            "Osmanabad  ",
            "Palghar  ",
            "Panvel  ",
            "Parbhani  ",
            "Parli  ",
            "Pen  ",
            "Phaltan  ",
            "Pimpri-Chinchwad  ",
            "Pune  ",
            "Raigad  ",
            "Ratnagiri  ",
            "Satara  ",
            "Sangamner  ",
            "Sangli  ",
            "Shahada  ",
            "Shirpur  ",
            "Shirur  ",
            "Solapur  ",
            "Thane  ",
            "Uran  ",
            "Wardha  ",
            "Washim  ",
            "Yavatmal"});
            this.cbStopName.Location = new System.Drawing.Point(578, 77);
            this.cbStopName.Name = "cbStopName";
            this.cbStopName.Size = new System.Drawing.Size(238, 28);
            this.cbStopName.TabIndex = 25;
            // 
            // cbTravelName
            // 
            this.cbTravelName.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTravelName.FormattingEnabled = true;
            this.cbTravelName.Location = new System.Drawing.Point(183, 131);
            this.cbTravelName.Name = "cbTravelName";
            this.cbTravelName.Size = new System.Drawing.Size(251, 28);
            this.cbTravelName.TabIndex = 25;
            // 
            // tbPackageName
            // 
            this.tbPackageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPackageName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPackageName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPackageName.Location = new System.Drawing.Point(578, 77);
            this.tbPackageName.Name = "tbPackageName";
            this.tbPackageName.Size = new System.Drawing.Size(238, 25);
            this.tbPackageName.TabIndex = 23;
            this.tbPackageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSeats
            // 
            this.tbSeats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSeats.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSeats.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbSeats.Location = new System.Drawing.Point(183, 131);
            this.tbSeats.Name = "tbSeats";
            this.tbSeats.Size = new System.Drawing.Size(251, 25);
            this.tbSeats.TabIndex = 23;
            this.tbSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbStopNo
            // 
            this.tbStopNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStopNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStopNo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbStopNo.Location = new System.Drawing.Point(334, 77);
            this.tbStopNo.Name = "tbStopNo";
            this.tbStopNo.Size = new System.Drawing.Size(81, 25);
            this.tbStopNo.TabIndex = 23;
            this.tbStopNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbStopId
            // 
            this.tbStopId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStopId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStopId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbStopId.Location = new System.Drawing.Point(125, 77);
            this.tbStopId.Name = "tbStopId";
            this.tbStopId.Size = new System.Drawing.Size(81, 25);
            this.tbStopId.TabIndex = 23;
            this.tbStopId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(578, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 3);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(183, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 3);
            this.panel4.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(334, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 3);
            this.panel2.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(125, 105);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(81, 3);
            this.panel6.TabIndex = 22;
            // 
            // dgvTourPackage
            // 
            this.dgvTourPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourPackage.Location = new System.Drawing.Point(21, 390);
            this.dgvTourPackage.Name = "dgvTourPackage";
            this.dgvTourPackage.RowHeadersWidth = 51;
            this.dgvTourPackage.RowTemplate.Height = 24;
            this.dgvTourPackage.Size = new System.Drawing.Size(831, 177);
            this.dgvTourPackage.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(721, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 32);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(609, 336);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(497, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.Location = new System.Drawing.Point(387, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 32);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbItineraryName
            // 
            this.tbItineraryName.AutoSize = true;
            this.tbItineraryName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItineraryName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbItineraryName.Location = new System.Drawing.Point(430, 82);
            this.tbItineraryName.Name = "tbItineraryName";
            this.tbItineraryName.Size = new System.Drawing.Size(142, 25);
            this.tbItineraryName.TabIndex = 1;
            this.tbItineraryName.Text = "Stop Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(16, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Travel Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(221, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Stop No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stop Id:";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel.Controls.Add(this.btnClose);
            this.panel.Controls.Add(this.label6);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1071, 66);
            this.panel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TTMS.UI.Properties.Resources.close_button_white;
            this.btnClose.Location = new System.Drawing.Point(825, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 39);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(236, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 50);
            this.label6.TabIndex = 11;
            this.label6.Text = "TRAVEL STOPS";
            // 
            // frmTravelStops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 610);
            this.Controls.Add(this.panel1);
            this.Name = "frmTravelStops";
            this.Text = "frmTravelStops";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourPackage)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbPackageName;
        private System.Windows.Forms.TextBox tbSeats;
        private System.Windows.Forms.TextBox tbStopNo;
        private System.Windows.Forms.TextBox tbStopId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvTourPackage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label tbItineraryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTravelName;
        private System.Windows.Forms.ComboBox cbStopName;
    }
}