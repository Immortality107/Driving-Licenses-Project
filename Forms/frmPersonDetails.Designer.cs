namespace DVLDProject.Forms
{
    partial class frmPersonDetails
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
            this.personDetailsUserControl1 = new DVLDProject.DVLDBusiness.People.PersonDetailsUserControl();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personDetailsUserControl1
            // 
            this.personDetailsUserControl1.Location = new System.Drawing.Point(9, 3);
            this.personDetailsUserControl1.Name = "personDetailsUserControl1";
            this.personDetailsUserControl1.Size = new System.Drawing.Size(741, 503);
            this.personDetailsUserControl1.TabIndex = 0;
            this.personDetailsUserControl1.Load += new System.EventHandler(this.personDetailsUserControl1_Load);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Location = new System.Drawing.Point(640, 497);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 34);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 552);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.personDetailsUserControl1);
            this.Name = "frmPersonDetails";
            this.Text = "frmPersonDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private DVLDBusiness.People.PersonDetailsUserControl personDetailsUserControl1;
        private System.Windows.Forms.Button btnClose;
    }
}