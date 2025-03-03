namespace DVLDProject.Forms
{
    partial class frmAddNewUser
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TPpersonalinfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.GBfilter = new System.Windows.Forms.GroupBox();
            this.txtFilterInput = new System.Windows.Forms.TextBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.lblFindBy = new System.Windows.Forms.Label();
            this.personDetailsUserControl1 = new DVLDProject.DVLDBusiness.People.PersonDetailsUserControl();
            this.PBAddPerson = new System.Windows.Forms.PictureBox();
            this.PBSearchPerson = new System.Windows.Forms.PictureBox();
            this.TPlogininfo = new System.Windows.Forms.TabPage();
            this.lblUserID = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbConfirmPW = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.TPpersonalinfo.SuspendLayout();
            this.GBfilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBAddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSearchPerson)).BeginInit();
            this.TPlogininfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPpersonalinfo);
            this.tabControl1.Controls.Add(this.TPlogininfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(14, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(968, 770);
            this.tabControl1.TabIndex = 0;
            // 
            // TPpersonalinfo
            // 
            this.TPpersonalinfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TPpersonalinfo.Controls.Add(this.btnNext);
            this.TPpersonalinfo.Controls.Add(this.GBfilter);
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
            // btnNext
            // 
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Image = global::DVLDProject.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(874, 669);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(80, 34);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // GBfilter
            // 
            this.GBfilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GBfilter.Controls.Add(this.txtFilterInput);
            this.GBfilter.Controls.Add(this.comboBoxFilter);
            this.GBfilter.Controls.Add(this.lblFindBy);
            this.GBfilter.Location = new System.Drawing.Point(20, 26);
            this.GBfilter.Name = "GBfilter";
            this.GBfilter.Size = new System.Drawing.Size(710, 101);
            this.GBfilter.TabIndex = 8;
            this.GBfilter.TabStop = false;
            this.GBfilter.Text = "Filter";
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
            // lblFindBy
            // 
            this.lblFindBy.AutoSize = true;
            this.lblFindBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindBy.Location = new System.Drawing.Point(6, 43);
            this.lblFindBy.Name = "lblFindBy";
            this.lblFindBy.Size = new System.Drawing.Size(71, 16);
            this.lblFindBy.TabIndex = 3;
            this.lblFindBy.Text = "Find By : ";
            // 
            // personDetailsUserControl1
            // 
            this.personDetailsUserControl1.Location = new System.Drawing.Point(10, 151);
            this.personDetailsUserControl1.Name = "personDetailsUserControl1";
            this.personDetailsUserControl1.Size = new System.Drawing.Size(887, 620);
            this.personDetailsUserControl1.TabIndex = 3;
            // 
            // PBAddPerson
            // 
            this.PBAddPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBAddPerson.Image = global::DVLDProject.Properties.Resources.Add_Person_40;
            this.PBAddPerson.Location = new System.Drawing.Point(818, 49);
            this.PBAddPerson.Name = "PBAddPerson";
            this.PBAddPerson.Size = new System.Drawing.Size(57, 54);
            this.PBAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBAddPerson.TabIndex = 2;
            this.PBAddPerson.TabStop = false;
            this.PBAddPerson.Click += new System.EventHandler(this.PBAddPerson_Click);
            // 
            // PBSearchPerson
            // 
            this.PBSearchPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBSearchPerson.Image = global::DVLDProject.Properties.Resources.SearchPerson;
            this.PBSearchPerson.Location = new System.Drawing.Point(752, 49);
            this.PBSearchPerson.Name = "PBSearchPerson";
            this.PBSearchPerson.Size = new System.Drawing.Size(54, 54);
            this.PBSearchPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSearchPerson.TabIndex = 1;
            this.PBSearchPerson.TabStop = false;
            this.PBSearchPerson.Click += new System.EventHandler(this.PBSearchPerson_Click);
            // 
            // TPlogininfo
            // 
            this.TPlogininfo.BackColor = System.Drawing.Color.Gainsboro;
            this.TPlogininfo.Controls.Add(this.lblUserID);
            this.TPlogininfo.Controls.Add(this.chkIsActive);
            this.TPlogininfo.Controls.Add(this.pictureBox5);
            this.TPlogininfo.Controls.Add(this.tbUserName);
            this.TPlogininfo.Controls.Add(this.label5);
            this.TPlogininfo.Controls.Add(this.pictureBox3);
            this.TPlogininfo.Controls.Add(this.tbConfirmPW);
            this.TPlogininfo.Controls.Add(this.pictureBox2);
            this.TPlogininfo.Controls.Add(this.tbPW);
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
            // lblUserID
            // 
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(299, 95);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(164, 26);
            this.lblUserID.TabIndex = 48;
            this.lblUserID.Text = "???";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsActive.Location = new System.Drawing.Point(294, 315);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(88, 24);
            this.chkIsActive.TabIndex = 47;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DVLDProject.Properties.Resources.Person_32;
            this.pictureBox5.Location = new System.Drawing.Point(248, 158);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 46;
            this.pictureBox5.TabStop = false;
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserName.ForeColor = System.Drawing.Color.Blue;
            this.tbUserName.Location = new System.Drawing.Point(294, 160);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(176, 24);
            this.tbUserName.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "UserName : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLDProject.Properties.Resources.Password_32;
            this.pictureBox3.Location = new System.Drawing.Point(248, 257);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // tbConfirmPW
            // 
            this.tbConfirmPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tbConfirmPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbConfirmPW.ForeColor = System.Drawing.Color.Blue;
            this.tbConfirmPW.Location = new System.Drawing.Point(294, 259);
            this.tbConfirmPW.Name = "tbConfirmPW";
            this.tbConfirmPW.Size = new System.Drawing.Size(176, 24);
            this.tbConfirmPW.TabIndex = 39;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLDProject.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(248, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // tbPW
            // 
            this.tbPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.tbPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPW.ForeColor = System.Drawing.Color.Blue;
            this.tbPW.Location = new System.Drawing.Point(294, 211);
            this.tbPW.Name = "tbPW";
            this.tbPW.Size = new System.Drawing.Size(176, 24);
            this.tbPW.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(248, 97);
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
            this.label3.Location = new System.Drawing.Point(147, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Password : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Confirm Password : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "User ID :";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(803, 822);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 34);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Location = new System.Drawing.Point(893, 822);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 34);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(996, 984);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddNewUser";
            this.ShowIcon = false;
            this.Text = "Add New User";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.tabControl1.ResumeLayout(false);
            this.TPpersonalinfo.ResumeLayout(false);
            this.GBfilter.ResumeLayout(false);
            this.GBfilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBAddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSearchPerson)).EndInit();
            this.TPlogininfo.ResumeLayout(false);
            this.TPlogininfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPpersonalinfo;
        private System.Windows.Forms.TabPage TPlogininfo;
        private System.Windows.Forms.PictureBox PBAddPerson;
        private System.Windows.Forms.PictureBox PBSearchPerson;
        private DVLDBusiness.People.PersonDetailsUserControl personDetailsUserControl1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox GBfilter;
        private System.Windows.Forms.TextBox txtFilterInput;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label lblFindBy;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tbConfirmPW;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblUserID;
    }
}