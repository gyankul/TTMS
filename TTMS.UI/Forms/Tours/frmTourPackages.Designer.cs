namespace TTMS.UI.Forms.Tours
{
    partial class frmTourPackages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTourPackages));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCreateDestination = new System.Windows.Forms.Label();
            this.dgvTourPackage = new System.Windows.Forms.DataGridView();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbChooseDestination = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbPackageDesc = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.ImgPackage = new System.Windows.Forms.PictureBox();
            this.lblPackageId = new System.Windows.Forms.Label();
            this.tbPackageName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPackage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblCreateDestination);
            this.panel1.Controls.Add(this.dgvTourPackage);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbChooseDestination);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbPackageDesc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnAddImg);
            this.panel1.Controls.Add(this.ImgPackage);
            this.panel1.Controls.Add(this.lblPackageId);
            this.panel1.Controls.Add(this.tbPackageName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 589);
            this.panel1.TabIndex = 0;
            // 
            // lblCreateDestination
            // 
            this.lblCreateDestination.AutoSize = true;
            this.lblCreateDestination.Font = new System.Drawing.Font("Sylfaen", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDestination.ForeColor = System.Drawing.Color.Black;
            this.lblCreateDestination.Location = new System.Drawing.Point(449, 160);
            this.lblCreateDestination.Name = "lblCreateDestination";
            this.lblCreateDestination.Size = new System.Drawing.Size(184, 22);
            this.lblCreateDestination.TabIndex = 45;
            this.lblCreateDestination.Text = "Create New Destination";
            this.lblCreateDestination.Click += new System.EventHandler(this.lblCreateDestination_Click);
            // 
            // dgvTourPackage
            // 
            this.dgvTourPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourPackage.Location = new System.Drawing.Point(29, 412);
            this.dgvTourPackage.Name = "dgvTourPackage";
            this.dgvTourPackage.RowHeadersWidth = 51;
            this.dgvTourPackage.RowTemplate.Height = 24;
            this.dgvTourPackage.Size = new System.Drawing.Size(824, 167);
            this.dgvTourPackage.TabIndex = 44;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPrice.Location = new System.Drawing.Point(698, 163);
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
            this.label5.Location = new System.Drawing.Point(693, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Price:";
            // 
            // cbChooseDestination
            // 
            this.cbChooseDestination.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cbChooseDestination.FormattingEnabled = true;
            this.cbChooseDestination.Location = new System.Drawing.Point(279, 121);
            this.cbChooseDestination.Name = "cbChooseDestination";
            this.cbChooseDestination.Size = new System.Drawing.Size(354, 33);
            this.cbChooseDestination.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(24, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Choose Destinations:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(279, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 3);
            this.panel3.TabIndex = 39;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(559, 374);
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
            this.btnUpdate.Location = new System.Drawing.Point(435, 374);
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
            this.btnSave.Location = new System.Drawing.Point(310, 374);
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
            this.btnAdd.Location = new System.Drawing.Point(184, 374);
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
            this.tbPackageDesc.Location = new System.Drawing.Point(420, 227);
            this.tbPackageDesc.Name = "tbPackageDesc";
            this.tbPackageDesc.Size = new System.Drawing.Size(433, 141);
            this.tbPackageDesc.TabIndex = 34;
            this.tbPackageDesc.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(521, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "Package Description:";
            // 
            // btnAddImg
            // 
            this.btnAddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImg.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAddImg.Image = ((System.Drawing.Image)(resources.GetObject("btnAddImg.Image")));
            this.btnAddImg.Location = new System.Drawing.Point(29, 317);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(53, 51);
            this.btnAddImg.TabIndex = 32;
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // ImgPackage
            // 
            this.ImgPackage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgPackage.Location = new System.Drawing.Point(29, 163);
            this.ImgPackage.Name = "ImgPackage";
            this.ImgPackage.Size = new System.Drawing.Size(384, 205);
            this.ImgPackage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgPackage.TabIndex = 31;
            this.ImgPackage.TabStop = false;
            // 
            // lblPackageId
            // 
            this.lblPackageId.AutoSize = true;
            this.lblPackageId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPackageId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblPackageId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPackageId.Location = new System.Drawing.Point(175, 89);
            this.lblPackageId.Name = "lblPackageId";
            this.lblPackageId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPackageId.Size = new System.Drawing.Size(82, 25);
            this.lblPackageId.TabIndex = 30;
            this.lblPackageId.Text = "          ";
            // 
            // tbPackageName
            // 
            this.tbPackageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPackageName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPackageName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPackageName.Location = new System.Drawing.Point(495, 89);
            this.tbPackageName.Name = "tbPackageName";
            this.tbPackageName.Size = new System.Drawing.Size(334, 25);
            this.tbPackageName.TabIndex = 29;
            this.tbPackageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(305, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Package Name:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(495, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 3);
            this.panel4.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(24, 89);
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
            this.panel2.Size = new System.Drawing.Size(884, 64);
            this.panel2.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(825, 12);
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
            this.label6.Location = new System.Drawing.Point(210, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(423, 50);
            this.label6.TabIndex = 12;
            this.label6.Text = "TOUR PACKAGES";
            // 
            // frmTourPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 589);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTourPackages";
            this.Text = "TourPackages";
            this.Load += new System.EventHandler(this.frmTourPackages_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPackage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox tbPackageDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.PictureBox ImgPackage;
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
        private System.Windows.Forms.ComboBox cbChooseDestination;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvTourPackage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCreateDestination;
    }
}