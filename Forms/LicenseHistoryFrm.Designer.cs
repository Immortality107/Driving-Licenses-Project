namespace DVLDProject.Forms
{
    partial class LicenseHistoryFrm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PBAddPerson = new System.Windows.Forms.PictureBox();
            this.PBSearchPerson = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.driverLicensesUserControl1 = new DVLDProject.UserControls.DriverLicensesUserControl();
            this.personDetailsUserControl1 = new DVLDProject.DVLDBusiness.People.PersonDetailsUserControl();
            this.findByUserControl1 = new DVLDProject.UserControls.FindByUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSearchPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(14, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 464);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // PBAddPerson
            // 
            this.PBAddPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBAddPerson.Enabled = false;
            this.PBAddPerson.Image = global::DVLDProject.Properties.Resources.Add_Person_40;
            this.PBAddPerson.Location = new System.Drawing.Point(791, 40);
            this.PBAddPerson.Name = "PBAddPerson";
            this.PBAddPerson.Size = new System.Drawing.Size(57, 54);
            this.PBAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBAddPerson.TabIndex = 5;
            this.PBAddPerson.TabStop = false;
            // 
            // PBSearchPerson
            // 
            this.PBSearchPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBSearchPerson.Enabled = false;
            this.PBSearchPerson.Image = global::DVLDProject.Properties.Resources.SearchPerson;
            this.PBSearchPerson.Location = new System.Drawing.Point(730, 40);
            this.PBSearchPerson.Name = "PBSearchPerson";
            this.PBSearchPerson.Size = new System.Drawing.Size(54, 54);
            this.PBSearchPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSearchPerson.TabIndex = 4;
            this.PBSearchPerson.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDProject.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(730, 893);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 36);
            this.btnClose.TabIndex = 168;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // driverLicensesUserControl1
            // 
            this.driverLicensesUserControl1.Location = new System.Drawing.Point(12, 605);
            this.driverLicensesUserControl1.Name = "driverLicensesUserControl1";
            this.driverLicensesUserControl1.Size = new System.Drawing.Size(857, 351);
            this.driverLicensesUserControl1.TabIndex = 2;
            // 
            // personDetailsUserControl1
            // 
            this.personDetailsUserControl1.Location = new System.Drawing.Point(233, 145);
            this.personDetailsUserControl1.Name = "personDetailsUserControl1";
            this.personDetailsUserControl1.Size = new System.Drawing.Size(601, 432);
            this.personDetailsUserControl1.TabIndex = 1;
            // 
            // findByUserControl1
            // 
            this.findByUserControl1.Enabled = false;
            this.findByUserControl1.Location = new System.Drawing.Point(242, 12);
            this.findByUserControl1.Name = "findByUserControl1";
            this.findByUserControl1.Size = new System.Drawing.Size(485, 104);
            this.findByUserControl1.TabIndex = 0;
            // 
            // LicenseHistoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 968);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.driverLicensesUserControl1);
            this.Controls.Add(this.PBAddPerson);
            this.Controls.Add(this.PBSearchPerson);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.personDetailsUserControl1);
            this.Controls.Add(this.findByUserControl1);
            this.Name = "LicenseHistoryFrm";
            this.Text = "LicenseHistoryFrm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSearchPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.FindByUserControl findByUserControl1;
        private DVLDBusiness.People.PersonDetailsUserControl personDetailsUserControl1;
        private UserControls.DriverLicensesUserControl driverLicensesUserControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PBAddPerson;
        private System.Windows.Forms.PictureBox PBSearchPerson;
        private System.Windows.Forms.Button btnClose;
    }
}