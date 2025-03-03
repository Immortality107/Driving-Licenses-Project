namespace DVLDProject.UserControls
{
    partial class LoginInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID :";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(95, 53);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(70, 18);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "UserID :";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(564, 54);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(70, 18);
            this.lblIsActive.TabIndex = 2;
            this.lblIsActive.Text = "UserID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(484, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Is Active :";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(347, 54);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(70, 18);
            this.lbUsername.TabIndex = 4;
            this.lbUsername.Text = "UserID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Username :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbUsername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblIsActive);
            this.groupBox1.Controls.Add(this.lblUserID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 96);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Information";
            // 
            // LoginInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginInfo";
            this.Size = new System.Drawing.Size(725, 166);
            this.Load += new System.EventHandler(this.LoginInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
