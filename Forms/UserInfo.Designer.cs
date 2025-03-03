namespace DVLDProject.Forms
{
    partial class UserInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.loginInfo1 = new DVLDProject.UserControls.LoginInfo();
            this.personDetailsUserControl1 = new DVLDProject.DVLDBusiness.People.PersonDetailsUserControl();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Location = new System.Drawing.Point(581, 573);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 34);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // loginInfo1
            // 
            this.loginInfo1.Location = new System.Drawing.Point(-10, 431);
            this.loginInfo1.Name = "loginInfo1";
            this.loginInfo1.Size = new System.Drawing.Size(728, 142);
            this.loginInfo1.TabIndex = 19;
            // 
            // personDetailsUserControl1
            // 
            this.personDetailsUserControl1.Location = new System.Drawing.Point(12, 12);
            this.personDetailsUserControl1.Name = "personDetailsUserControl1";
            this.personDetailsUserControl1.Size = new System.Drawing.Size(706, 426);
            this.personDetailsUserControl1.TabIndex = 0;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 622);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.personDetailsUserControl1);
            this.Controls.Add(this.loginInfo1);
            this.Name = "UserInfo";
            this.Text = "UserInfo";
            this.Load += new System.EventHandler(this.UserInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DVLDBusiness.People.PersonDetailsUserControl personDetailsUserControl1;
        private System.Windows.Forms.Button btnClose;
        private UserControls.LoginInfo loginInfo1;
    }
}