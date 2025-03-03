namespace DVLDProject.Forms
{
    partial class FrmLocalLicensesApps
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLocalLicenseApps = new System.Windows.Forms.DataGridView();
            this.LDLAppsMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.txtFilterInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbAddPerson = new System.Windows.Forms.PictureBox();
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedultTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbDriverImage = new System.Windows.Forms.PictureBox();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueInternationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseApps)).BeginInit();
            this.LDLAppsMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(498, 255);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(614, 39);
            this.lblTitle.TabIndex = 141;
            this.lblTitle.Text = "Local Driving License Applications";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(307, 760);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(19, 13);
            this.lblRecords.TabIndex = 139;
            this.lblRecords.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 760);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 138;
            this.label2.Text = "# Records:";
            // 
            // dgvLocalLicenseApps
            // 
            this.dgvLocalLicenseApps.AllowUserToAddRows = false;
            this.dgvLocalLicenseApps.AllowUserToDeleteRows = false;
            this.dgvLocalLicenseApps.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLocalLicenseApps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocalLicenseApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalLicenseApps.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicenseApps.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalLicenseApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocalLicenseApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenseApps.ContextMenuStrip = this.LDLAppsMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocalLicenseApps.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLocalLicenseApps.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLocalLicenseApps.Location = new System.Drawing.Point(24, 391);
            this.dgvLocalLicenseApps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLocalLicenseApps.MultiSelect = false;
            this.dgvLocalLicenseApps.Name = "dgvLocalLicenseApps";
            this.dgvLocalLicenseApps.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalLicenseApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLocalLicenseApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalLicenseApps.Size = new System.Drawing.Size(1454, 354);
            this.dgvLocalLicenseApps.TabIndex = 137;
            this.dgvLocalLicenseApps.TabStop = false;
            // 
            // LDLAppsMenuStrip1
            // 
            this.LDLAppsMenuStrip1.AutoSize = false;
            this.LDLAppsMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.schedultTestsToolStripMenuItem,
            this.issueDrToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem1});
            this.LDLAppsMenuStrip1.Name = "contextMenuStrip1";
            this.LDLAppsMenuStrip1.Size = new System.Drawing.Size(250, 330);
            this.LDLAppsMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(238, 6);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "None",
            "L.D.L AppID",
            "National No.",
            "Full Name",
            "Status"});
            this.comboBoxFilter.Location = new System.Drawing.Point(288, 354);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(210, 21);
            this.comboBoxFilter.TabIndex = 144;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // txtFilterInput
            // 
            this.txtFilterInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterInput.Location = new System.Drawing.Point(505, 354);
            this.txtFilterInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterInput.Name = "txtFilterInput";
            this.txtFilterInput.Size = new System.Drawing.Size(256, 20);
            this.txtFilterInput.TabIndex = 143;
            this.txtFilterInput.Visible = false;
            this.txtFilterInput.TextChanged += new System.EventHandler(this.txtFilterInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 142;
            this.label1.Text = "Filter By:";
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1165, 753);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 136;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbAddPerson
            // 
            this.pbAddPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAddPerson.Image = global::DVLDProject.Properties.Resources.New_Application_64;
            this.pbAddPerson.Location = new System.Drawing.Point(1414, 313);
            this.pbAddPerson.Name = "pbAddPerson";
            this.pbAddPerson.Size = new System.Drawing.Size(64, 61);
            this.pbAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddPerson.TabIndex = 145;
            this.pbAddPerson.TabStop = false;
            this.pbAddPerson.Click += new System.EventHandler(this.pbAddPerson_Click);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.PersonDetails_32;
            this.showApplicationDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(258, 38);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Enabled = false;
            this.editApplicationToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.edit_32;
            this.editApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(258, 38);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Enabled = false;
            this.deleteApplicationToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.Delete_32_2;
            this.deleteApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(258, 38);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Enabled = false;
            this.cancelApplicationToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.Delete_32;
            this.cancelApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(258, 38);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // schedultTestsToolStripMenuItem
            // 
            this.schedultTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.schedultTestsToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.Schedule_Test_32;
            this.schedultTestsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.schedultTestsToolStripMenuItem.Name = "schedultTestsToolStripMenuItem";
            this.schedultTestsToolStripMenuItem.Size = new System.Drawing.Size(258, 38);
            this.schedultTestsToolStripMenuItem.Text = "Schedule Tests";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.Enabled = false;
            this.scheduleVisionTestToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.Vision_Test_32;
            this.scheduleVisionTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.Enabled = false;
            this.scheduleWrittenTestToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.Written_Test_32;
            this.scheduleWrittenTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Enabled = false;
            this.scheduleStreetTestToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.Street_Test_32;
            this.scheduleStreetTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(203, 38);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // issueDrToolStripMenuItem
            // 
            this.issueDrToolStripMenuItem.Enabled = false;
            this.issueDrToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.IssueDrivingLicense_32;
            this.issueDrToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueDrToolStripMenuItem.Name = "issueDrToolStripMenuItem";
            this.issueDrToolStripMenuItem.Size = new System.Drawing.Size(258, 38);
            this.issueDrToolStripMenuItem.Text = "Issue Driving License(First Time)";
            this.issueDrToolStripMenuItem.Click += new System.EventHandler(this.issueDrToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Enabled = false;
            this.showLicenseToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.License_View_32;
            this.showLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(258, 38);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem1
            // 
            this.showPersonLicenseHistoryToolStripMenuItem1.Image = global::DVLDProject.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonLicenseHistoryToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem1.Name = "showPersonLicenseHistoryToolStripMenuItem1";
            this.showPersonLicenseHistoryToolStripMenuItem1.Size = new System.Drawing.Size(258, 38);
            this.showPersonLicenseHistoryToolStripMenuItem1.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem1.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem1_Click);
            // 
            // pbDriverImage
            // 
            this.pbDriverImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDriverImage.Image = global::DVLDProject.Properties.Resources.Applications;
            this.pbDriverImage.InitialImage = null;
            this.pbDriverImage.Location = new System.Drawing.Point(632, 34);
            this.pbDriverImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbDriverImage.Name = "pbDriverImage";
            this.pbDriverImage.Size = new System.Drawing.Size(308, 218);
            this.pbDriverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDriverImage.TabIndex = 140;
            this.pbDriverImage.TabStop = false;
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.showDetailsToolStripMenuItem.Text = "&Show Person Info";
            // 
            // issueInternationalLicenseToolStripMenuItem
            // 
            this.issueInternationalLicenseToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.IssueDrivingLicense_32;
            this.issueInternationalLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueInternationalLicenseToolStripMenuItem.Name = "issueInternationalLicenseToolStripMenuItem";
            this.issueInternationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.issueInternationalLicenseToolStripMenuItem.Text = "Issue International License";
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.License_View_32;
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // FrmLocalLicensesApps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 852);
            this.Controls.Add(this.pbAddPerson);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLocalLicenseApps);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.txtFilterInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbDriverImage);
            this.Controls.Add(this.btnClose);
            this.Name = "FrmLocalLicensesApps";
            this.Text = "Local Driving License Applications";
            this.Load += new System.EventHandler(this.FrmLocalLicensesApps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenseApps)).EndInit();
            this.LDLAppsMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLocalLicenseApps;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem issueInternationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.TextBox txtFilterInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbDriverImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbAddPerson;
        private System.Windows.Forms.ContextMenuStrip LDLAppsMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedultTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem1;
    }
}