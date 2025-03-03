namespace DVLDProject.UserControls
{
    partial class DriverLicensesUserControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TcLocal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvLocalLicenses = new System.Windows.Forms.DataGridView();
            this.llRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TcInternational = new System.Windows.Forms.TabPage();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDriverLicenses = new System.Windows.Forms.GroupBox();
            this.CMShowLicenseInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMShowLicenseInfoInternational = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TcLocal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).BeginInit();
            this.TcInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.gbDriverLicenses.SuspendLayout();
            this.CMShowLicenseInfo.SuspendLayout();
            this.CMShowLicenseInfoInternational.SuspendLayout();
            this.SuspendLayout();
            // 
            // TcLocal
            // 
            this.TcLocal.Controls.Add(this.tabPage1);
            this.TcLocal.Controls.Add(this.TcInternational);
            this.TcLocal.Location = new System.Drawing.Point(23, 11);
            this.TcLocal.Name = "TcLocal";
            this.TcLocal.SelectedIndex = 0;
            this.TcLocal.Size = new System.Drawing.Size(783, 292);
            this.TcLocal.TabIndex = 0;
            this.TcLocal.SelectedIndexChanged += new System.EventHandler(this.TcLocal_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvLocalLicenses);
            this.tabPage1.Controls.Add(this.llRecords);
            this.tabPage1.Controls.Add(this.lblRecords);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvLocalLicenses
            // 
            this.dgvLocalLicenses.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLocalLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalLicenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLocalLicenses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenses.ContextMenuStrip = this.CMShowLicenseInfo;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocalLicenses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLocalLicenses.Location = new System.Drawing.Point(6, 51);
            this.dgvLocalLicenses.Name = "dgvLocalLicenses";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLocalLicenses.Size = new System.Drawing.Size(763, 171);
            this.dgvLocalLicenses.TabIndex = 5;
            // 
            // llRecords
            // 
            this.llRecords.AutoSize = true;
            this.llRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRecords.Location = new System.Drawing.Point(141, 227);
            this.llRecords.Name = "llRecords";
            this.llRecords.Size = new System.Drawing.Size(21, 24);
            this.llRecords.TabIndex = 4;
            this.llRecords.Text = "0";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(130, 227);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(0, 24);
            this.lblRecords.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "# Records : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local Licenses History :";
            // 
            // TcInternational
            // 
            this.TcInternational.Controls.Add(this.dgvInternationalLicenses);
            this.TcInternational.Controls.Add(this.label5);
            this.TcInternational.Controls.Add(this.label3);
            this.TcInternational.Controls.Add(this.label4);
            this.TcInternational.Location = new System.Drawing.Point(4, 22);
            this.TcInternational.Name = "TcInternational";
            this.TcInternational.Padding = new System.Windows.Forms.Padding(3);
            this.TcInternational.Size = new System.Drawing.Size(775, 266);
            this.TcInternational.TabIndex = 1;
            this.TcInternational.Text = "International";
            this.TcInternational.UseVisualStyleBackColor = true;
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInternationalLicenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInternationalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternationalLicenses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.ContextMenuStrip = this.CMShowLicenseInfoInternational;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternationalLicenses.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(6, 48);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(763, 171);
            this.dgvInternationalLicenses.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(144, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "# Records : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "International Licenses History :";
            // 
            // gbDriverLicenses
            // 
            this.gbDriverLicenses.Controls.Add(this.TcLocal);
            this.gbDriverLicenses.Location = new System.Drawing.Point(18, 26);
            this.gbDriverLicenses.Name = "gbDriverLicenses";
            this.gbDriverLicenses.Size = new System.Drawing.Size(812, 309);
            this.gbDriverLicenses.TabIndex = 1;
            this.gbDriverLicenses.TabStop = false;
            this.gbDriverLicenses.Text = "Driver Licenses";
            // 
            // CMShowLicenseInfo
            // 
            this.CMShowLicenseInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.CMShowLicenseInfo.Name = "CMShowLicenseInfo";
            this.CMShowLicenseInfo.Size = new System.Drawing.Size(231, 42);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLicenseInfoToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.License_View_32;
            this.showLicenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(230, 38);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // CMShowLicenseInfoInternational
            // 
            this.CMShowLicenseInfoInternational.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.CMShowLicenseInfoInternational.Name = "CMShowLicenseInfo";
            this.CMShowLicenseInfoInternational.Size = new System.Drawing.Size(231, 64);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = global::DVLDProject.Properties.Resources.License_View_32;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(230, 38);
            this.toolStripMenuItem1.Text = "Show License Info";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // DriverLicensesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDriverLicenses);
            this.Name = "DriverLicensesUserControl";
            this.Size = new System.Drawing.Size(857, 351);
            this.Load += new System.EventHandler(this.DriverLicensesUserControl_Load);
            this.TcLocal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).EndInit();
            this.TcInternational.ResumeLayout(false);
            this.TcInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.gbDriverLicenses.ResumeLayout(false);
            this.CMShowLicenseInfo.ResumeLayout(false);
            this.CMShowLicenseInfoInternational.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TcLocal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TcInternational;
        private System.Windows.Forms.GroupBox gbDriverLicenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label llRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvLocalLicenses;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.ContextMenuStrip CMShowLicenseInfo;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMShowLicenseInfoInternational;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}
