namespace TTMS.UI.Tours
{
    partial class frmTourPackage
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTourPackage = new System.Windows.Forms.DataGridView();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.pbTourPackage = new System.Windows.Forms.PictureBox();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbPackageName = new System.Windows.Forms.TextBox();
            this.tbPackageId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ttmsDBDataSet = new TTMS.UI.ttmsDBDataSet();
            this.destinationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.destinationTableAdapter = new TTMS.UI.ttmsDBDataSetTableAdapters.DestinationTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTourPackage)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttmsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.dgvTourPackage);
            this.panel1.Controls.Add(this.btnAddImg);
            this.panel1.Controls.Add(this.pbTourPackage);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbDuration);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.tbPackageName);
            this.panel1.Controls.Add(this.tbPackageId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 668);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.Location = new System.Drawing.Point(902, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 32);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdate.Location = new System.Drawing.Point(900, 322);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(911, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 26;
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
            this.btnAdd.Location = new System.Drawing.Point(911, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTourPackage
            // 
            this.dgvTourPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourPackage.Location = new System.Drawing.Point(49, 497);
            this.dgvTourPackage.Name = "dgvTourPackage";
            this.dgvTourPackage.RowHeadersWidth = 51;
            this.dgvTourPackage.RowTemplate.Height = 24;
            this.dgvTourPackage.Size = new System.Drawing.Size(947, 150);
            this.dgvTourPackage.TabIndex = 23;
            // 
            // btnAddImg
            // 
            this.btnAddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImg.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAddImg.Image = global::TTMS.UI.Properties.Resources.icons8_image_plus_48;
            this.btnAddImg.Location = new System.Drawing.Point(477, 413);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(61, 53);
            this.btnAddImg.TabIndex = 22;
            this.btnAddImg.UseVisualStyleBackColor = true;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // pbTourPackage
            // 
            this.pbTourPackage.Location = new System.Drawing.Point(477, 160);
            this.pbTourPackage.Name = "pbTourPackage";
            this.pbTourPackage.Size = new System.Drawing.Size(416, 306);
            this.pbTourPackage.TabIndex = 21;
            this.pbTourPackage.TabStop = false;
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescription.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbDescription.Location = new System.Drawing.Point(49, 310);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(401, 156);
            this.tbDescription.TabIndex = 19;
            this.tbDescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(44, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Package Description:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(127, 238);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(181, 3);
            this.panel6.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(169, 187);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(139, 3);
            this.panel5.TabIndex = 17;
            // 
            // tbPrice
            // 
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPrice.Location = new System.Drawing.Point(127, 211);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(181, 25);
            this.tbPrice.TabIndex = 16;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(44, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price:";
            // 
            // tbDuration
            // 
            this.tbDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDuration.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuration.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbDuration.Location = new System.Drawing.Point(169, 160);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(139, 25);
            this.tbDuration.TabIndex = 16;
            this.tbDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(44, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Duration:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(525, 141);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(51, 3);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(195, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 3);
            this.panel3.TabIndex = 14;
            // 
            // tbPackageName
            // 
            this.tbPackageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPackageName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPackageName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPackageName.Location = new System.Drawing.Point(525, 114);
            this.tbPackageName.Name = "tbPackageName";
            this.tbPackageName.Size = new System.Drawing.Size(51, 25);
            this.tbPackageName.TabIndex = 13;
            this.tbPackageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPackageId
            // 
            this.tbPackageId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPackageId.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPackageId.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbPackageId.Location = new System.Drawing.Point(195, 114);
            this.tbPackageId.Name = "tbPackageId";
            this.tbPackageId.Size = new System.Drawing.Size(113, 25);
            this.tbPackageId.TabIndex = 13;
            this.tbPackageId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(335, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Package Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(44, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Package Id:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 84);
            this.panel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(289, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(423, 50);
            this.label6.TabIndex = 13;
            this.label6.Text = "TOUR PACKAGES";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.destinationBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(665, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(321, 24);
            this.comboBox1.TabIndex = 28;
            // 
            // ttmsDBDataSet
            // 
            this.ttmsDBDataSet.DataSetName = "ttmsDBDataSet";
            this.ttmsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // destinationBindingSource
            // 
            this.destinationBindingSource.DataMember = "Destination";
            this.destinationBindingSource.DataSource = this.ttmsDBDataSet;
            // 
            // destinationTableAdapter
            // 
            this.destinationTableAdapter.ClearBeforeFill = true;
            // 
            // frmTourPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 668);
            this.Controls.Add(this.panel1);
            this.Name = "frmTourPackage";
            this.Text = "TourPackage";
            this.Load += new System.EventHandler(this.frmTourPackage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTourPackage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ttmsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbPackageName;
        private System.Windows.Forms.TextBox tbPackageId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.DataGridView dgvTourPackage;
        private System.Windows.Forms.Button btnAddImg;
        private System.Windows.Forms.PictureBox pbTourPackage;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBox1;
        private ttmsDBDataSet ttmsDBDataSet;
        private System.Windows.Forms.BindingSource destinationBindingSource;
        private ttmsDBDataSetTableAdapters.DestinationTableAdapter destinationTableAdapter;
    }
}