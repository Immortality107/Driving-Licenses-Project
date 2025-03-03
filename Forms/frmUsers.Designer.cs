namespace DVLDProject.Forms
{
    partial class frmUsers
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
            this.txtFilterInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsersMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.pbAddUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsersMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterInput
            // 
            this.txtFilterInput.Location = new System.Drawing.Point(305, 259);
            this.txtFilterInput.Name = "txtFilterInput";
            this.txtFilterInput.Size = new System.Drawing.Size(220, 20);
            this.txtFilterInput.TabIndex = 21;
            this.txtFilterInput.Visible = false;
            this.txtFilterInput.TextChanged += new System.EventHandler(this.txtFilterInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Filter By : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Location = new System.Drawing.Point(776, 511);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 34);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(153, 525);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(18, 20);
            this.lblRecords.TabIndex = 16;
            this.lblRecords.Text = "0";
            this.lblRecords.Click += new System.EventHandler(this.lblRecords_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Records :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(293, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 42);
            this.label1.TabIndex = 14;
            this.label1.Text = "Manage Users";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UsersMenuStrip1
            // 
            this.UsersMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.UsersMenuStrip1.Name = "contextMenuStrip1";
            this.UsersMenuStrip1.Size = new System.Drawing.Size(192, 172);
            this.UsersMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "None",
            "UserID",
            "PersonID",
            "FullName",
            "UserName",
            "Is Active"});
            this.comboBoxFilter.Location = new System.Drawing.Point(145, 258);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(154, 21);
            this.comboBoxFilter.TabIndex = 20;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToOrderColumns = true;
            this.dgvUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.UsersMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.Location = new System.Drawing.Point(67, 296);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.ShowEditingIcon = false;
            this.dgvUsers.Size = new System.Drawing.Size(794, 198);
            this.dgvUsers.TabIndex = 12;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // cbIsActive
            // 
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(305, 257);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(80, 21);
            this.cbIsActive.TabIndex = 22;
            this.cbIsActive.Visible = false;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // pbAddUser
            // 
            this.pbAddUser.Image = global::DVLDProject.Properties.Resources.Add_New_User_72;
            this.pbAddUser.Location = new System.Drawing.Point(782, 209);
            this.pbAddUser.Name = "pbAddUser";
            this.pbAddUser.Padding = new System.Windows.Forms.Padding(5);
            this.pbAddUser.Size = new System.Drawing.Size(79, 70);
            this.pbAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddUser.TabIndex = 18;
            this.pbAddUser.TabStop = false;
            this.pbAddUser.Click += new System.EventHandler(this.pbAddUser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDProject.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(348, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDetailsToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.monitor;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPersonToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.Add_New_User_32;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.Edit_User_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.Delete_User_32;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = global::DVLDProject.Properties.Resources.Password_32;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 24);
            this.toolStripMenuItem1.Text = "Change Password";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.Email_32;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneCallToolStripMenuItem.Image = global::DVLDProject.Properties.Resources.call_32;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.CurrentChanged += new System.EventHandler(this.peopleBindingSource_CurrentChanged);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 602);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.txtFilterInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbAddUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.dgvUsers);
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.UsersMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilterInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbAddUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip UsersMenuStrip1;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ComboBox cbIsActive;
    }
}