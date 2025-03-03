namespace DVLDProject.UserControls
{
    partial class FindByUserControl
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
            this.txtFilterInput = new System.Windows.Forms.TextBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.lblFindBy = new System.Windows.Forms.Label();
            this.GBfilter = new System.Windows.Forms.GroupBox();
            this.GBfilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilterInput
            // 
            this.txtFilterInput.Location = new System.Drawing.Point(243, 42);
            this.txtFilterInput.Name = "txtFilterInput";
            this.txtFilterInput.Size = new System.Drawing.Size(220, 20);
            this.txtFilterInput.TabIndex = 5;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "National No.",
            "Person ID"});
            this.comboBoxFilter.Location = new System.Drawing.Point(79, 41);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(154, 21);
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
            // GBfilter
            // 
            this.GBfilter.Controls.Add(this.txtFilterInput);
            this.GBfilter.Controls.Add(this.comboBoxFilter);
            this.GBfilter.Controls.Add(this.lblFindBy);
            this.GBfilter.Location = new System.Drawing.Point(3, 3);
            this.GBfilter.Name = "GBfilter";
            this.GBfilter.Size = new System.Drawing.Size(477, 94);
            this.GBfilter.TabIndex = 6;
            this.GBfilter.TabStop = false;
            this.GBfilter.Text = "Filter";
            // 
            // FindByUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GBfilter);
            this.Name = "FindByUserControl";
            this.Size = new System.Drawing.Size(493, 104);
            this.GBfilter.ResumeLayout(false);
            this.GBfilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilterInput;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label lblFindBy;
        private System.Windows.Forms.GroupBox GBfilter;
    }
}
