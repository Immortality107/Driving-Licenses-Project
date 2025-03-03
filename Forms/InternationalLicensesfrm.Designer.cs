namespace DVLDProject.Forms
{
    partial class InternationalLicensesfrm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvInternationalicenseApps = new System.Windows.Forms.DataGridView();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.txtFilterInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmsDrivers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbAddPerson = new System.Windows.Forms.PictureBox();
            this.pbDriverImage = new System.Windows.Forms.PictureBox();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueInternationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalicenseApps)).BeginInit();
            this.cmsDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(276, 234);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(614, 39);
            this.lblTitle.TabIndex = 151;
            this.lblTitle.Text = "International License Applications";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(125, 739);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(19, 13);
            this.lblRecords.TabIndex = 149;
            this.lblRecords.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 739);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 148;
            this.label2.Text = "# Records:";
            // 
            // dgvInternationalicenseApps
            // 
            this.dgvInternationalicenseApps.AllowUserToAddRows = false;
            this.dgvInternationalicenseApps.AllowUserToDeleteRows = false;
            this.dgvInternationalicenseApps.AllowUserToResizeRows = false;
            this.dgvInternationalicenseApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternationalicenseApps.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternationalicenseApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternationalicenseApps.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInternationalicenseApps.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInternationalicenseApps.Location = new System.Drawing.Point(19, 370);
            this.dgvInternationalicenseApps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInternationalicenseApps.MultiSelect = false;
            this.dgvInternationalicenseApps.Name = "dgvInternationalicenseApps";
            this.dgvInternationalicenseApps.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalicenseApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInternationalicenseApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalicenseApps.Size = new System.Drawing.Size(1097, 354);
            this.dgvInternationalicenseApps.TabIndex = 147;
            this.dgvInternationalicenseApps.TabStop = false;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "None",
            "International License ID",
            "Application ID",
            "Driver ID",
            "Local License ID",
            "Is Active"});
            this.comboBoxFilter.Location = new System.Drawing.Point(102, 333);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(210, 21);
            this.comboBoxFilter.TabIndex = 154;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // txtFilterInput
            // 
            this.txtFilterInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterInput.Location = new System.Drawing.Point(319, 333);
            this.txtFilterInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterInput.Name = "txtFilterInput";
            this.txtFilterInput.Size = new System.Drawing.Size(256, 20);
            this.txtFilterInput.TabIndex = 153;
            this.txtFilterInput.Visible = false;
            this.txtFilterInput.TextChanged += new System.EventHandler(this.txtFilterInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 152;
            this.label1.Text = "Filter By:";
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(982, 734);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 146;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // cmsDrivers
            // 
            this.cmsDrivers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.issueInternationalLicenseToolStripMenuItem,
            this.toolStripSeparator1,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmsDrivers.Name = "contextMenuStrip1";
            this.cmsDrivers.Size = new System.Drawing.Size(242, 130);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.International_32;
            this.pictureBox1.Location = new System.Drawing.Point(608, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 156;
            this.pictureBox1.TabStop = false;
            // 
            // pbAddPerson
            // 
            this.pbAddPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAddPerson.Image = global::DVLDProject.Properties.Resources.New_Application_64;
            this.pbAddPerson.Location = new System.Drawing.Point(1020, 279);
            this.pbAddPerson.Name = "pbAddPerson";
            this.pbAddPerson.Size = new System.Drawing.Size(96, 77);
            this.pbAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddPerson.TabIndex = 155;
            this.pbAddPerson.TabStop = false;
            this.pbAddPerson.Click += new System.EventHandler(this.pbAddPerson_Click);
            // 
            // pbDriverImage
            // 
            this.pbDriverImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDriverImage.Image = global::DVLDProject.Properties.Resources.Applications;
            this.pbDriverImage.InitialImage = null;
            this.pbDriverImage.Location = new System.Drawing.Point(410, 13);
            this.pbDriverImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbDriverImage.Name = "pbDriverImage";
            this.pbDriverImage.Size = new System.Drawing.Size(308, 218);
            this.pbDriverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDriverImage.TabIndex = 150;
            this.pbDriverImage.TabStop = false;
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.showDetailsToolStripMenuItem.Text = "&Show Person Info";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // issueInternationalLicenseToolStripMenuItem
            // 
            this.issueInternationalLicenseToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.IssueDrivingLicense_32;
            this.issueInternationalLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueInternationalLicenseToolStripMenuItem.Name = "issueInternationalLicenseToolStripMenuItem";
            this.issueInternationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.issueInternationalLicenseToolStripMenuItem.Text = "Issue International License";
            this.issueInternationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.issueInternationalLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.License_View_32;
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // InternationalLicensesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 791);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbAddPerson);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInternationalicenseApps);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.txtFilterInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbDriverImage);
            this.Controls.Add(this.btnClose);
            this.Name = "InternationalLicensesfrm";
            this.Text = "List International License Applications";
            this.Load += new System.EventHandler(this.InternationalLicensesfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalicenseApps)).EndInit();
            this.cmsDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAddPerson;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInternationalicenseApps;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.TextBox txtFilterInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbDriverImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmsDrivers;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem issueInternationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}