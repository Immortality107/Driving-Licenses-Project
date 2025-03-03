namespace DVLDProject.Forms
{
    partial class DriverInternationalLicenseInfo
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
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.internationalDriverLicenseInfoUC1 = new DVLDProject.UserControls.InternationalDriverLicenseInfoUC();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Firebrick;
            this.label13.Location = new System.Drawing.Point(170, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(538, 39);
            this.label13.TabIndex = 132;
            this.label13.Text = "Driver International License Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.LicenseView_400;
            this.pictureBox1.Location = new System.Drawing.Point(308, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 133;
            this.pictureBox1.TabStop = false;
            // 
            // internationalDriverLicenseInfoUC1
            // 
            this.internationalDriverLicenseInfoUC1.Location = new System.Drawing.Point(12, 212);
            this.internationalDriverLicenseInfoUC1.Name = "internationalDriverLicenseInfoUC1";
            this.internationalDriverLicenseInfoUC1.Size = new System.Drawing.Size(959, 407);
            this.internationalDriverLicenseInfoUC1.TabIndex = 134;
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDProject.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(845, 641);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 36);
            this.btnClose.TabIndex = 153;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DriverInternationalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 698);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.internationalDriverLicenseInfoUC1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label13);
            this.Name = "DriverInternationalLicenseInfo";
            this.Text = "Driver International License Info";
            this.Load += new System.EventHandler(this.DriverInternationalLicenseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.InternationalDriverLicenseInfoUC internationalDriverLicenseInfoUC1;
        private System.Windows.Forms.Button btnClose;
    }
}