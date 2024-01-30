namespace TTMS.UI
{
    partial class frmLoading
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressbar = new System.Windows.Forms.Timer(this.components);
            this.ttmsProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Travel and Tourism Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(322, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Version 1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TTMS.UI.Properties.Resources.logottmswhite;
            this.pictureBox1.Location = new System.Drawing.Point(328, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // progressbar
            // 
            this.progressbar.Interval = 50;
            this.progressbar.Tick += new System.EventHandler(this.progressbar_Tick);
            // 
            // ttmsProgressBar
            // 
            this.ttmsProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ttmsProgressBar.Location = new System.Drawing.Point(0, 361);
            this.ttmsProgressBar.Name = "ttmsProgressBar";
            this.ttmsProgressBar.Size = new System.Drawing.Size(800, 23);
            this.ttmsProgressBar.TabIndex = 3;
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.ttmsProgressBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoading";
            this.Load += new System.EventHandler(this.frmLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer progressbar;
        private System.Windows.Forms.ProgressBar ttmsProgressBar;
    }
}