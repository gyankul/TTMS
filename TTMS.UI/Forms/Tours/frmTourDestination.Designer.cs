namespace TTMS.UI.Forms.Tours
{
    partial class frmTourDestination
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
            this.cbPackage = new System.Windows.Forms.ComboBox();
            this.tbDestinationName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbSrNo = new System.Windows.Forms.TextBox();
            this.tbDestinationId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTourItinerary = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbDestinationDescription = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbItineraryName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImgDestination = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbItineraryNo = new System.Windows.Forms.Label();
            this.tourDataSet = new TTMS.UI.Dataset.TourDataSet();
            this.tourDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourPackagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tourPackagesTableAdapter = new TTMS.UI.Dataset.TourDataSetTableAdapters.TourPackagesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourItinerary)).BeginInit();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourPackagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPackage
            // 
            this.cbPackage.DataSource = this.tourPackagesBindingSource;
            this.cbPackage.DisplayMember = "PackageName";
            this.cbPackage.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPackage.FormattingEnabled = true;
            this.cbPackage.Location = new System.Drawing.Point(137, 132);
            this.cbPackage.Name = "cbPackage";
            this.cbPackage.Size = new System.Drawing.Size(287, 28);
            this.cbPackage.TabIndex = 24;
            this.cbPackage.ValueMember = "PackageId";
            // 
            // tbDestinationName
            // 
            this.tbDestinationName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDestinationName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestinationName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbDestinationName.Location = new System.Drawing.Point(528, 77);
            this.tbDestinationName.Name = "tbDestinationName";
            this.tbDestinationName.Size = new System.Drawing.Size(311, 25);
            this.tbDestinationName.TabIndex = 23;
            this.tbDestinationName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // tbSrNo
            // 
            this.tbSrNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSrNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSrNo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbSrNo.Location = new System.Drawing.Point(669, 131);
            this.tbSrNo.Name = "tbSrNo";
            this.tbSrNo.Size = new System.Drawing.Size(50, 25);
            this.tbSrNo.TabIndex = 23;
            this.tbSrNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbDestinationId
            // 
            this.tbDestinationId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDestinationId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestinationId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbDestinationId.Location = new System.Drawing.Point(203, 77);
            this.tbDestinationId.Name = "tbDestinationId";
            this.tbDestinationId.Size = new System.Drawing.Size(93, 25);
            this.tbDestinationId.TabIndex = 23;
            this.tbDestinationId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(528, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 3);
            this.panel3.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(669, 159);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(50, 3);
            this.panel6.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(203, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 3);
            this.panel2.TabIndex = 22;
            // 
            // dgvTourItinerary
            // 
            this.dgvTourItinerary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourItinerary.Location = new System.Drawing.Point(21, 426);
            this.dgvTourItinerary.Name = "dgvTourItinerary";
            this.dgvTourItinerary.RowHeadersWidth = 51;
            this.dgvTourItinerary.RowTemplate.Height = 24;
            this.dgvTourItinerary.Size = new System.Drawing.Size(831, 177);
            this.dgvTourItinerary.TabIndex = 21;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(514, 362);
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
            this.btnSave.Location = new System.Drawing.Point(640, 311);
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
            this.btnAddImg.Location = new System.Drawing.Point(23, 343);
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
            this.btnAdd.Location = new System.Drawing.Point(514, 311);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 32);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbDestinationDescription
            // 
            this.tbDestinationDescription.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestinationDescription.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbDestinationDescription.Location = new System.Drawing.Point(438, 218);
            this.tbDestinationDescription.Name = "tbDestinationDescription";
            this.tbDestinationDescription.Size = new System.Drawing.Size(372, 65);
            this.tbDestinationDescription.TabIndex = 19;
            this.tbDestinationDescription.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(181, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(493, 50);
            this.label6.TabIndex = 11;
            this.label6.Text = "TOUR DESTINATION";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(638, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 32);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(18, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Package:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(137, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 3);
            this.panel4.TabIndex = 12;
            // 
            // tbItineraryName
            // 
            this.tbItineraryName.AutoSize = true;
            this.tbItineraryName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItineraryName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbItineraryName.Location = new System.Drawing.Point(307, 82);
            this.tbItineraryName.Name = "tbItineraryName";
            this.tbItineraryName.Size = new System.Drawing.Size(220, 25);
            this.tbItineraryName.TabIndex = 1;
            this.tbItineraryName.Text = "Destination Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destination Id:";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel.Controls.Add(this.btnClose);
            this.panel.Controls.Add(this.label6);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(871, 66);
            this.panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbPackage);
            this.panel1.Controls.Add(this.tbDestinationName);
            this.panel1.Controls.Add(this.tbSrNo);
            this.panel1.Controls.Add(this.tbDestinationId);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvTourItinerary);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAddImg);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.tbDestinationDescription);
            this.panel1.Controls.Add(this.ImgDestination);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.tbItineraryName);
            this.panel1.Controls.Add(this.tbItineraryNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 617);
            this.panel1.TabIndex = 1;
            // 
            // ImgDestination
            // 
            this.ImgDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgDestination.Location = new System.Drawing.Point(23, 189);
            this.ImgDestination.Name = "ImgDestination";
            this.ImgDestination.Size = new System.Drawing.Size(384, 205);
            this.ImgDestination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgDestination.TabIndex = 17;
            this.ImgDestination.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(471, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Destination Description:";
            // 
            // tbItineraryNo
            // 
            this.tbItineraryNo.AutoSize = true;
            this.tbItineraryNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbItineraryNo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbItineraryNo.Location = new System.Drawing.Point(472, 135);
            this.tbItineraryNo.Name = "tbItineraryNo";
            this.tbItineraryNo.Size = new System.Drawing.Size(187, 25);
            this.tbItineraryNo.TabIndex = 1;
            this.tbItineraryNo.Text = "Destination No:";
            // 
            // tourDataSet
            // 
            this.tourDataSet.DataSetName = "TourDataSet";
            this.tourDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tourDataSetBindingSource
            // 
            this.tourDataSetBindingSource.DataSource = this.tourDataSet;
            this.tourDataSetBindingSource.Position = 0;
            // 
            // tourPackagesBindingSource
            // 
            this.tourPackagesBindingSource.DataMember = "TourPackages";
            this.tourPackagesBindingSource.DataSource = this.tourDataSetBindingSource;
            // 
            // tourPackagesTableAdapter
            // 
            this.tourPackagesTableAdapter.ClearBeforeFill = true;
            // 
            // frmTourDestination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 617);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTourDestination";
            this.Text = "frmTourDestination";
            this.Load += new System.EventHandler(this.frmTourDestination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourItinerary)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tourPackagesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPackage;
        private System.Windows.Forms.TextBox tbDestinationName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbSrNo;
        private System.Windows.Forms.TextBox tbDestinationId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTourItinerary;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox tbDestinationDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label tbItineraryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ImgDestination;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tbItineraryNo;
        private System.Windows.Forms.BindingSource tourDataSetBindingSource;
        private Dataset.TourDataSet tourDataSet;
        private System.Windows.Forms.BindingSource tourPackagesBindingSource;
        private Dataset.TourDataSetTableAdapters.TourPackagesTableAdapter tourPackagesTableAdapter;
    }
}