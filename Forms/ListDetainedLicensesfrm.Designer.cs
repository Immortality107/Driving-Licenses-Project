namespace DVLDProject.Forms
{
    partial class ListDetainedLicensesfrm
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmDetainedLicenses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseLisenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDetainedLicenseApps = new System.Windows.Forms.DataGridView();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.txtFilterInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbAddPerson = new System.Windows.Forms.PictureBox();
            this.pbDriverImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmDetainedLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenseApps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // cmDetainedLicenses
            // 
            this.cmDetainedLicenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.ShowLicenseDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.releaseLisenceToolStripMenuItem});
            this.cmDetainedLicenses.Name = "contextMenuStrip1";
            this.cmDetainedLicenses.Size = new System.Drawing.Size(242, 190);
            this.cmDetainedLicenses.Opening += new System.ComponentModel.CancelEventHandler(this.cmsDrivers_Opening);
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
            // ShowLicenseDetailsToolStripMenuItem
            // 
            this.ShowLicenseDetailsToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.IssueDrivingLicense_32;
            this.ShowLicenseDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowLicenseDetailsToolStripMenuItem.Name = "ShowLicenseDetailsToolStripMenuItem";
            this.ShowLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.ShowLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.ShowLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.ShowLicenseDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(238, 6);
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
            // releaseLisenceToolStripMenuItem
            // 
            this.releaseLisenceToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.Release_Detained_License_32;
            this.releaseLisenceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseLisenceToolStripMenuItem.Name = "releaseLisenceToolStripMenuItem";
            this.releaseLisenceToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.releaseLisenceToolStripMenuItem.Text = "Release Lisence";
            this.releaseLisenceToolStripMenuItem.Click += new System.EventHandler(this.releaseLisenceToolStripMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(416, 227);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(614, 39);
            this.lblTitle.TabIndex = 162;
            this.lblTitle.Text = "List Detained Licenses";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(299, 730);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(19, 13);
            this.lblRecords.TabIndex = 160;
            this.lblRecords.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 730);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 159;
            this.label2.Text = "# Records:";
            // 
            // dgvDetainedLicenseApps
            // 
            this.dgvDetainedLicenseApps.AllowUserToAddRows = false;
            this.dgvDetainedLicenseApps.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenseApps.AllowUserToResizeRows = false;
            this.dgvDetainedLicenseApps.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetainedLicenseApps.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicenseApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetainedLicenseApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicenseApps.ContextMenuStrip = this.cmDetainedLicenses;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetainedLicenseApps.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetainedLicenseApps.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetainedLicenseApps.Location = new System.Drawing.Point(193, 361);
            this.dgvDetainedLicenseApps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDetainedLicenseApps.MultiSelect = false;
            this.dgvDetainedLicenseApps.Name = "dgvDetainedLicenseApps";
            this.dgvDetainedLicenseApps.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetainedLicenseApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetainedLicenseApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetainedLicenseApps.Size = new System.Drawing.Size(1097, 354);
            this.dgvDetainedLicenseApps.TabIndex = 158;
            this.dgvDetainedLicenseApps.TabStop = false;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "Is Released",
            "National No",
            "Full Name",
            "Release Application ID"});
            this.comboBoxFilter.Location = new System.Drawing.Point(276, 324);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(210, 21);
            this.comboBoxFilter.TabIndex = 165;
            // 
            // txtFilterInput
            // 
            this.txtFilterInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterInput.Location = new System.Drawing.Point(493, 324);
            this.txtFilterInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterInput.Name = "txtFilterInput";
            this.txtFilterInput.Size = new System.Drawing.Size(256, 20);
            this.txtFilterInput.TabIndex = 164;
            this.txtFilterInput.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 163;
            this.label1.Text = "Filter By:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.Release_Detained_License_64;
            this.pictureBox1.Location = new System.Drawing.Point(1081, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 167;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbAddPerson
            // 
            this.pbAddPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAddPerson.Image = global::DVLDProject.Properties.Resources.Detain_64;
            this.pbAddPerson.Location = new System.Drawing.Point(1194, 270);
            this.pbAddPerson.Name = "pbAddPerson";
            this.pbAddPerson.Size = new System.Drawing.Size(96, 77);
            this.pbAddPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddPerson.TabIndex = 166;
            this.pbAddPerson.TabStop = false;
            this.pbAddPerson.Click += new System.EventHandler(this.pbAddPerson_Click);
            // 
            // pbDriverImage
            // 
            this.pbDriverImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDriverImage.Image = global::DVLDProject.Properties.Resources.Detain_512;
            this.pbDriverImage.InitialImage = null;
            this.pbDriverImage.Location = new System.Drawing.Point(584, 4);
            this.pbDriverImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbDriverImage.Name = "pbDriverImage";
            this.pbDriverImage.Size = new System.Drawing.Size(308, 218);
            this.pbDriverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDriverImage.TabIndex = 161;
            this.pbDriverImage.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDProject.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1193, 723);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 36);
            this.btnClose.TabIndex = 157;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ListDetainedLicensesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 785);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbAddPerson);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDetainedLicenseApps);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.txtFilterInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbDriverImage);
            this.Controls.Add(this.btnClose);
            this.Name = "ListDetainedLicensesfrm";
            this.Text = "List Detained Licenses";
            this.Load += new System.EventHandler(this.ListDetainedLicensesfrm_Load);
            this.cmDetainedLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenseApps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmDetainedLicenses;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pbAddPerson;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDetainedLicenseApps;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.TextBox txtFilterInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbDriverImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem releaseLisenceToolStripMenuItem;
    }
}