namespace DVLDProject.Forms
{
    partial class frmAddLicense
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.TPlogininfo = new System.Windows.Forms.TabPage();
            this.comboBoxLicenseClasses = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tbCreatedBy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tbApplicationDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbApplicationFees = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PBAddPerson = new System.Windows.Forms.PictureBox();
            this.PBSearchPerson = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TPpersonalinfo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFilterInput = new System.Windows.Forms.TextBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.personDetailsUserControl1 = new DVLDProject.DVLDBusiness.People.PersonDetailsUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.TPlogininfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSearchPerson)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TPpersonalinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Location = new System.Drawing.Point(952, 819);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 34);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(862, 819);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 34);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(299, 234);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(164, 26);
            this.lblApplicationID.TabIndex = 48;
            this.lblApplicationID.Text = "[ ??? ]";
            // 
            // TPlogininfo
            // 
            this.TPlogininfo.BackColor = System.Drawing.Color.Gainsboro;
            this.TPlogininfo.Controls.Add(this.comboBoxLicenseClasses);
            this.TPlogininfo.Controls.Add(this.pictureBox4);
            this.TPlogininfo.Controls.Add(this.tbCreatedBy);
            this.TPlogininfo.Controls.Add(this.label4);
            this.TPlogininfo.Controls.Add(this.lblApplicationID);
            this.TPlogininfo.Controls.Add(this.pictureBox5);
            this.TPlogininfo.Controls.Add(this.tbApplicationDate);
            this.TPlogininfo.Controls.Add(this.label5);
            this.TPlogininfo.Controls.Add(this.pictureBox3);
            this.TPlogininfo.Controls.Add(this.tbApplicationFees);
            this.TPlogininfo.Controls.Add(this.pictureBox2);
            this.TPlogininfo.Controls.Add(this.pictureBox1);
            this.TPlogininfo.Controls.Add(this.label3);
            this.TPlogininfo.Controls.Add(this.label2);
            this.TPlogininfo.Controls.Add(this.label1);
            this.TPlogininfo.Location = new System.Drawing.Point(4, 27);
            this.TPlogininfo.Name = "TPlogininfo";
            this.TPlogininfo.Padding = new System.Windows.Forms.Padding(3);
            this.TPlogininfo.Size = new System.Drawing.Size(960, 739);
            this.TPlogininfo.TabIndex = 1;
            this.TPlogininfo.Text = "Login Info";
            // 
            // comboBoxLicenseClasses
            // 
            this.comboBoxLicenseClasses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLicenseClasses.FormattingEnabled = true;
            this.comboBoxLicenseClasses.Location = new System.Drawing.Point(294, 348);
            this.comboBoxLicenseClasses.Name = "comboBoxLicenseClasses";
            this.comboBoxLicenseClasses.Size = new System.Drawing.Size(317, 26);
            this.comboBoxLicenseClasses.TabIndex = 52;
            this.comboBoxLicenseClasses.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLDProject.Properties.Resources.User_32__2;
            this.pictureBox4.Location = new System.Drawing.Point(236, 453);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            // 
            // tbCreatedBy
            // 
            this.tbCreatedBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tbCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCreatedBy.ForeColor = System.Drawing.Color.Blue;
            this.tbCreatedBy.Location = new System.Drawing.Point(294, 455);
            this.tbCreatedBy.Name = "tbCreatedBy";
            this.tbCreatedBy.Size = new System.Drawing.Size(176, 24);
            this.tbCreatedBy.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 49;
            this.label4.Text = "Created By :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLDProject.Properties.Resources.Calendar_32;
            this.pictureBox5.Location = new System.Drawing.Point(236, 297);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 46;
            this.pictureBox5.TabStop = false;
            // 
            // tbApplicationDate
            // 
            this.tbApplicationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tbApplicationDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApplicationDate.ForeColor = System.Drawing.Color.Blue;
            this.tbApplicationDate.Location = new System.Drawing.Point(294, 299);
            this.tbApplicationDate.Name = "tbApplicationDate";
            this.tbApplicationDate.Size = new System.Drawing.Size(176, 24);
            this.tbApplicationDate.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Application Date :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLDProject.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(236, 396);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // tbApplicationFees
            // 
            this.tbApplicationFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tbApplicationFees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApplicationFees.ForeColor = System.Drawing.Color.Blue;
            this.tbApplicationFees.Location = new System.Drawing.Point(294, 398);
            this.tbApplicationFees.Name = "tbApplicationFees";
            this.tbApplicationFees.Size = new System.Drawing.Size(176, 24);
            this.tbApplicationFees.TabIndex = 39;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLDProject.Properties.Resources.License_View_32;
            this.pictureBox2.Location = new System.Drawing.Point(236, 348);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(236, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "License Class";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Application Fees";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "D.L. Application ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PBAddPerson
            // 
            this.PBAddPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBAddPerson.Image = global::DVLDProject.Properties.Resources.Add_Person_40;
            this.PBAddPerson.Location = new System.Drawing.Point(818, 188);
            this.PBAddPerson.Name = "PBAddPerson";
            this.PBAddPerson.Size = new System.Drawing.Size(57, 54);
            this.PBAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBAddPerson.TabIndex = 2;
            this.PBAddPerson.TabStop = false;
            // 
            // PBSearchPerson
            // 
            this.PBSearchPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBSearchPerson.Image = global::DVLDProject.Properties.Resources.SearchPerson;
            this.PBSearchPerson.Location = new System.Drawing.Point(752, 188);
            this.PBSearchPerson.Name = "PBSearchPerson";
            this.PBSearchPerson.Size = new System.Drawing.Size(54, 54);
            this.PBSearchPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSearchPerson.TabIndex = 1;
            this.PBSearchPerson.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPpersonalinfo);
            this.tabControl1.Controls.Add(this.TPlogininfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(73, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(968, 770);
            this.tabControl1.TabIndex = 11;
            // 
            // TPpersonalinfo
            // 
            this.TPpersonalinfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TPpersonalinfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPpersonalinfo.Controls.Add(this.button1);
            this.TPpersonalinfo.Controls.Add(this.pictureBox6);
            this.TPpersonalinfo.Controls.Add(this.pictureBox7);
            this.TPpersonalinfo.Controls.Add(this.groupBox1);
            this.TPpersonalinfo.Controls.Add(this.btnNext);
            this.TPpersonalinfo.Controls.Add(this.personDetailsUserControl1);
            this.TPpersonalinfo.Controls.Add(this.PBAddPerson);
            this.TPpersonalinfo.Controls.Add(this.PBSearchPerson);
            this.TPpersonalinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPpersonalinfo.Location = new System.Drawing.Point(4, 27);
            this.TPpersonalinfo.Name = "TPpersonalinfo";
            this.TPpersonalinfo.Padding = new System.Windows.Forms.Padding(3);
            this.TPpersonalinfo.Size = new System.Drawing.Size(960, 739);
            this.TPpersonalinfo.TabIndex = 0;
            this.TPpersonalinfo.Text = "Personal Info";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::DVLDProject.Properties.Resources.Next_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(852, 686);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Next";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = global::DVLDProject.Properties.Resources.Add_Person_40;
            this.pictureBox6.Location = new System.Drawing.Point(828, 66);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(57, 54);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Image = global::DVLDProject.Properties.Resources.SearchPerson;
            this.pictureBox7.Location = new System.Drawing.Point(762, 66);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(54, 54);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txtFilterInput);
            this.groupBox1.Controls.Add(this.comboBoxFilter);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(33, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 101);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // txtFilterInput
            // 
            this.txtFilterInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFilterInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterInput.Location = new System.Drawing.Point(243, 42);
            this.txtFilterInput.Name = "txtFilterInput";
            this.txtFilterInput.Size = new System.Drawing.Size(220, 24);
            this.txtFilterInput.TabIndex = 5;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "National No.",
            "Person ID"});
            this.comboBoxFilter.Location = new System.Drawing.Point(79, 41);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(154, 26);
            this.comboBoxFilter.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Find By : ";
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::DVLDProject.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(874, 808);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 34);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // personDetailsUserControl1
            // 
            this.personDetailsUserControl1.Location = new System.Drawing.Point(33, 129);
            this.personDetailsUserControl1.Name = "personDetailsUserControl1";
            this.personDetailsUserControl1.Size = new System.Drawing.Size(887, 578);
            this.personDetailsUserControl1.TabIndex = 3;
            // 
            // frmAddLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 908);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAddLicense";
            this.Text = "New Local Driving License Application";
            this.Load += new System.EventHandler(this.frmAddLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.TPlogininfo.ResumeLayout(false);
            this.TPlogininfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBAddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSearchPerson)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TPpersonalinfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPpersonalinfo;
        private System.Windows.Forms.Button btnNext;
        private DVLDBusiness.People.PersonDetailsUserControl personDetailsUserControl1;
        private System.Windows.Forms.PictureBox PBAddPerson;
        private System.Windows.Forms.PictureBox PBSearchPerson;
        private System.Windows.Forms.TabPage TPlogininfo;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox tbApplicationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tbApplicationFees;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox tbCreatedBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxLicenseClasses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFilterInput;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button1;
    }
}