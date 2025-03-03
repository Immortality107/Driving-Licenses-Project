namespace DVLDProject.Forms
{
    partial class frmApplicationsTypes
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
            this.dgvApplicationTypes = new System.Windows.Forms.DataGridView();
            this.cmAppTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbDriverImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).BeginInit();
            this.cmAppTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(316, 228);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(446, 39);
            this.lblTitle.TabIndex = 141;
            this.lblTitle.Text = "Manage Application Types";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(248, 659);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(19, 13);
            this.lblRecords.TabIndex = 139;
            this.lblRecords.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 654);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 138;
            this.label2.Text = "# Records:";
            // 
            // dgvApplicationTypes
            // 
            this.dgvApplicationTypes.AllowUserToAddRows = false;
            this.dgvApplicationTypes.AllowUserToDeleteRows = false;
            this.dgvApplicationTypes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvApplicationTypes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvApplicationTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgvApplicationTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicationTypes.ContextMenuStrip = this.cmAppTypes;
            this.dgvApplicationTypes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvApplicationTypes.Location = new System.Drawing.Point(150, 273);
            this.dgvApplicationTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvApplicationTypes.MultiSelect = false;
            this.dgvApplicationTypes.Name = "dgvApplicationTypes";
            this.dgvApplicationTypes.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApplicationTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvApplicationTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicationTypes.Size = new System.Drawing.Size(810, 354);
            this.dgvApplicationTypes.TabIndex = 137;
            this.dgvApplicationTypes.TabStop = false;
            // 
            // cmAppTypes
            // 
            this.cmAppTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem});
            this.cmAppTypes.Name = "contextMenuStrip1";
            this.cmAppTypes.Size = new System.Drawing.Size(202, 42);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.edit_32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(201, 38);
            this.showDetailsToolStripMenuItem.Text = "Edit Application Type";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // pbDriverImage
            // 
            this.pbDriverImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbDriverImage.Image = global::DVLDProject.Properties.Resources.Application_Types_512;
            this.pbDriverImage.InitialImage = null;
            this.pbDriverImage.Location = new System.Drawing.Point(384, 5);
            this.pbDriverImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbDriverImage.Name = "pbDriverImage";
            this.pbDriverImage.Size = new System.Drawing.Size(308, 218);
            this.pbDriverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDriverImage.TabIndex = 140;
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
            this.btnClose.Location = new System.Drawing.Point(826, 647);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 136;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmApplicationsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 726);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvApplicationTypes);
            this.Controls.Add(this.pbDriverImage);
            this.Controls.Add(this.btnClose);
            this.Name = "frmApplicationsTypes";
            this.Text = "frmApplicationsTypes";
            this.Load += new System.EventHandler(this.frmApplicationsTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicationTypes)).EndInit();
            this.cmAppTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDriverImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvApplicationTypes;
        private System.Windows.Forms.ContextMenuStrip cmAppTypes;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbDriverImage;
        private System.Windows.Forms.Button btnClose;
    }
}