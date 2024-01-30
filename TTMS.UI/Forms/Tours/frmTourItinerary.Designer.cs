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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblItineraryId = new System.Windows.Forms.Label();
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
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourItinerary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgItinerary)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblItineraryId);
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
            this.panel1.Controls.Add(this.tbDestination);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 570);
            this.panel1.TabIndex = 0;
            // 
            // lblItineraryId
            // 
            this.lblItineraryId.AutoSize = true;
            this.lblItineraryId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblItineraryId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblItineraryId.Location = new System.Drawing.Point(169, 88);
            this.lblItineraryId.Name = "lblItineraryId";
            this.lblItineraryId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItineraryId.Size = new System.Drawing.Size(82, 25);
            this.lblItineraryId.TabIndex = 22;
            this.lblItineraryId.Text = "          ";
            // 
            // dgvTourItinerary
            // 
            this.dgvTourItinerary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourItinerary.Location = new System.Drawing.Point(26, 377);
            this.dgvTourItinerary.Name = "dgvTourItinerary";
            this.dgvTourItinerary.RowHeadersWidth = 51;
            this.dgvTourItinerary.RowTemplate.Height = 24;
            this.dgvTourItinerary.Size = new System.Drawing.Size(947, 177);
            this.dgvTourItinerary.TabIndex = 21;
            this.dgvTourItinerary.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTourItinerary_CellMouseClick);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(823, 339);
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
            this.btnUpdate.Location = new System.Drawing.Point(699, 339);
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
            this.btnSave.Location = new System.Drawing.Point(574, 339);
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
            this.btnAddImg.Location = new System.Drawing.Point(26, 320);
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
            this.btnAdd.Location = new System.Drawing.Point(448, 339);
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
            this.tbActivity.Location = new System.Drawing.Point(439, 195);
            this.tbActivity.Name = "tbActivity";
            this.tbActivity.Size = new System.Drawing.Size(493, 138);
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
            this.dtpEnd.Location = new System.Drawing.Point(656, 132);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(276, 28);
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
            this.dtpStart.Location = new System.Drawing.Point(205, 132);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(276, 28);
            this.dtpStart.TabIndex = 18;
            this.dtpStart.Value = new System.DateTime(2024, 1, 28, 13, 17, 18, 0);
            // 
            // ImgItinerary
            // 
            this.ImgItinerary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgItinerary.Location = new System.Drawing.Point(26, 166);
            this.ImgItinerary.Name = "ImgItinerary";
            this.ImgItinerary.Size = new System.Drawing.Size(384, 205);
            this.ImgItinerary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgItinerary.TabIndex = 17;
            this.ImgItinerary.TabStop = false;
            // 
            // tbDayNumber
            // 
            this.tbDayNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDayNumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDayNumber.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbDayNumber.Location = new System.Drawing.Point(885, 85);
            this.tbDayNumber.Name = "tbDayNumber";
            this.tbDayNumber.Size = new System.Drawing.Size(88, 25);
            this.tbDayNumber.TabIndex = 14;
            this.tbDayNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(555, 166);
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
            this.label5.Location = new System.Drawing.Point(524, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "End Event:";
            // 
            // tbDestination
            // 
            this.tbDestination.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDestination.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestination.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbDestination.Location = new System.Drawing.Point(416, 83);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(281, 25);
            this.tbDestination.TabIndex = 14;
            this.tbDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(60, 132);
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
            this.label3.Location = new System.Drawing.Point(720, 89);
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
            this.label2.Location = new System.Drawing.Point(261, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Destination:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(416, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 3);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(885, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(88, 3);
            this.panel5.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(21, 88);
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
            this.panel.Size = new System.Drawing.Size(997, 66);
            this.panel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TTMS.UI.Properties.Resources.icons8_close_302;
            this.btnClose.Location = new System.Drawing.Point(952, 9);
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
            this.label6.Location = new System.Drawing.Point(287, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(430, 50);
            this.label6.TabIndex = 11;
            this.label6.Text = "TOUR ITINERARY";
            // 
            // frmTourItinerary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ImgItinerary;
        private System.Windows.Forms.TextBox tbDayNumber;
        private System.Windows.Forms.TextBox tbDestination;
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
        private System.Windows.Forms.Label lblItineraryId;
        private System.Windows.Forms.Button btnClose;
    }
}