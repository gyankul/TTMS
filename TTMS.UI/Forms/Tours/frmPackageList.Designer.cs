namespace TTMS.UI.Forms.Tours
{
    partial class frmPackageList
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
            this.btnBookPackage = new System.Windows.Forms.Button();
            this.pbPackageImg = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLeft = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRight = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchPackage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChoosePackage = new System.Windows.Forms.ComboBox();
            this.tourPackagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourDataSet = new TTMS.UI.Dataset.TourDataSet();
            this.cbPackageName = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tourPackagesTableAdapter = new TTMS.UI.Dataset.TourDataSetTableAdapters.TourPackagesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPackageImg)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourPackagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDataSet)).BeginInit();
            this.cbPackageName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnBookPackage);
            this.panel1.Controls.Add(this.pbPackageImg);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.cbPackageName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 640);
            this.panel1.TabIndex = 0;
            // 
            // btnBookPackage
            // 
            this.btnBookPackage.BackColor = System.Drawing.Color.Chartreuse;
            this.btnBookPackage.FlatAppearance.BorderSize = 0;
            this.btnBookPackage.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookPackage.Location = new System.Drawing.Point(882, 578);
            this.btnBookPackage.Name = "btnBookPackage";
            this.btnBookPackage.Size = new System.Drawing.Size(105, 50);
            this.btnBookPackage.TabIndex = 7;
            this.btnBookPackage.Text = "Book\r\nPackage";
            this.btnBookPackage.UseVisualStyleBackColor = false;
            this.btnBookPackage.Click += new System.EventHandler(this.btnBookPackage_Click);
            // 
            // pbPackageImg
            // 
            this.pbPackageImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPackageImg.Location = new System.Drawing.Point(35, 93);
            this.pbPackageImg.Name = "pbPackageImg";
            this.pbPackageImg.Size = new System.Drawing.Size(976, 547);
            this.pbPackageImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPackageImg.TabIndex = 6;
            this.pbPackageImg.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.btnLeft);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(35, 547);
            this.panel5.TabIndex = 5;
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Image = global::TTMS.UI.Properties.Resources.icons8_chevron_48;
            this.btnLeft.Location = new System.Drawing.Point(0, 229);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(35, 67);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.btnRight);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1011, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 547);
            this.panel4.TabIndex = 4;
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Image = global::TTMS.UI.Properties.Resources.icons8_chevron_48__1_;
            this.btnRight.Location = new System.Drawing.Point(0, 229);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(35, 67);
            this.btnRight.TabIndex = 1;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.btnSearchPackage);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbChoosePackage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1046, 35);
            this.panel3.TabIndex = 3;
            // 
            // btnSearchPackage
            // 
            this.btnSearchPackage.BackColor = System.Drawing.Color.FloralWhite;
            this.btnSearchPackage.FlatAppearance.BorderSize = 0;
            this.btnSearchPackage.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPackage.Image = global::TTMS.UI.Properties.Resources.icons8_search_28;
            this.btnSearchPackage.Location = new System.Drawing.Point(954, 0);
            this.btnSearchPackage.Name = "btnSearchPackage";
            this.btnSearchPackage.Size = new System.Drawing.Size(57, 35);
            this.btnSearchPackage.TabIndex = 8;
            this.btnSearchPackage.UseVisualStyleBackColor = false;
            this.btnSearchPackage.Click += new System.EventHandler(this.btnSearchPackage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Package:";
            // 
            // cbChoosePackage
            // 
            this.cbChoosePackage.DataSource = this.tourPackagesBindingSource;
            this.cbChoosePackage.DisplayMember = "PackageName";
            this.cbChoosePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChoosePackage.FormattingEnabled = true;
            this.cbChoosePackage.Location = new System.Drawing.Point(192, 3);
            this.cbChoosePackage.Name = "cbChoosePackage";
            this.cbChoosePackage.Size = new System.Drawing.Size(189, 28);
            this.cbChoosePackage.TabIndex = 0;
            this.cbChoosePackage.ValueMember = "PackageId";
            // 
            // tourPackagesBindingSource
            // 
            this.tourPackagesBindingSource.DataMember = "TourPackages";
            this.tourPackagesBindingSource.DataSource = this.tourDataSet;
            // 
            // tourDataSet
            // 
            this.tourDataSet.DataSetName = "TourDataSet";
            this.tourDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbPackageName
            // 
            this.cbPackageName.BackColor = System.Drawing.Color.RoyalBlue;
            this.cbPackageName.Controls.Add(this.btnClose);
            this.cbPackageName.Controls.Add(this.label6);
            this.cbPackageName.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPackageName.Location = new System.Drawing.Point(0, 0);
            this.cbPackageName.Name = "cbPackageName";
            this.cbPackageName.Size = new System.Drawing.Size(1046, 58);
            this.cbPackageName.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TTMS.UI.Properties.Resources.icons8_close_302;
            this.btnClose.Location = new System.Drawing.Point(1001, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 39);
            this.btnClose.TabIndex = 14;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(388, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 50);
            this.label6.TabIndex = 13;
            this.label6.Text = "PACKAGES";
            // 
            // tourPackagesTableAdapter
            // 
            this.tourPackagesTableAdapter.ClearBeforeFill = true;
            // 
            // frmPackageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 640);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPackageList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PackageList";
            this.Load += new System.EventHandler(this.frmPackageList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPackageImg)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tourPackagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDataSet)).EndInit();
            this.cbPackageName.ResumeLayout(false);
            this.cbPackageName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel cbPackageName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pbPackageImg;
        private System.Windows.Forms.Button btnBookPackage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChoosePackage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearchPackage;
        private Dataset.TourDataSet tourDataSet;
        private System.Windows.Forms.BindingSource tourPackagesBindingSource;
        private Dataset.TourDataSetTableAdapters.TourPackagesTableAdapter tourPackagesTableAdapter;
    }
}