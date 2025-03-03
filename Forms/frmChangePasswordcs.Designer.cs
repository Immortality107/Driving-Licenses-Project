namespace DVLDProject.Forms
{
    partial class frmChangePasswordcs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCurrentPW = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbNewPW = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbConfirmPW = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.personDetailsUserControl1 = new DVLDProject.DVLDBusiness.People.PersonDetailsUserControl();
            this.loginInfo1 = new DVLDProject.UserControls.LoginInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Image = global::DVLDProject.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(736, 752);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(85, 43);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Current Password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 733);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Confirm Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 681);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "New Password : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // tbCurrentPW
            // 
            this.tbCurrentPW.ForeColor = System.Drawing.Color.Blue;
            this.tbCurrentPW.Location = new System.Drawing.Point(305, 634);
            this.tbCurrentPW.Name = "tbCurrentPW";
            this.tbCurrentPW.PasswordChar = '*';
            this.tbCurrentPW.Size = new System.Drawing.Size(176, 20);
            this.tbCurrentPW.TabIndex = 26;
            this.tbCurrentPW.Validating += new System.ComponentModel.CancelEventHandler(this.tbCurrentPW_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.Password_32;
            this.pictureBox1.Location = new System.Drawing.Point(259, 632);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLDProject.Properties.Resources.Password_32;
            this.pictureBox2.Location = new System.Drawing.Point(259, 681);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // tbNewPW
            // 
            this.tbNewPW.ForeColor = System.Drawing.Color.Blue;
            this.tbNewPW.Location = new System.Drawing.Point(305, 683);
            this.tbNewPW.Name = "tbNewPW";
            this.tbNewPW.PasswordChar = '*';
            this.tbNewPW.Size = new System.Drawing.Size(176, 20);
            this.tbNewPW.TabIndex = 28;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLDProject.Properties.Resources.Password_32;
            this.pictureBox3.Location = new System.Drawing.Point(259, 729);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // tbConfirmPW
            // 
            this.tbConfirmPW.ForeColor = System.Drawing.Color.Blue;
            this.tbConfirmPW.Location = new System.Drawing.Point(305, 731);
            this.tbConfirmPW.Name = "tbConfirmPW";
            this.tbConfirmPW.PasswordChar = '*';
            this.tbConfirmPW.Size = new System.Drawing.Size(176, 20);
            this.tbConfirmPW.TabIndex = 30;
            this.tbConfirmPW.Validating += new System.ComponentModel.CancelEventHandler(this.tbConfirmPW_Validating);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Image = global::DVLDProject.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(855, 752);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(85, 43);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // personDetailsUserControl1
            // 
            this.personDetailsUserControl1.Location = new System.Drawing.Point(85, 12);
            this.personDetailsUserControl1.Name = "personDetailsUserControl1";
            this.personDetailsUserControl1.Size = new System.Drawing.Size(706, 471);
            this.personDetailsUserControl1.TabIndex = 20;
            // 
            // loginInfo1
            // 
            this.loginInfo1.Location = new System.Drawing.Point(74, 453);
            this.loginInfo1.Name = "loginInfo1";
            this.loginInfo1.Size = new System.Drawing.Size(728, 142);
            this.loginInfo1.TabIndex = 22;
            // 
            // frmChangePasswordcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 798);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tbConfirmPW);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbNewPW);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbCurrentPW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.personDetailsUserControl1);
            this.Controls.Add(this.loginInfo1);
            this.Name = "frmChangePasswordcs";
            this.Text = "frmChangePasswordcs";
            this.Load += new System.EventHandler(this.frmChangePasswordcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private DVLDBusiness.People.PersonDetailsUserControl personDetailsUserControl1;
        private UserControls.LoginInfo loginInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCurrentPW;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbNewPW;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tbConfirmPW;
        private System.Windows.Forms.Button btnSave;
    }
}