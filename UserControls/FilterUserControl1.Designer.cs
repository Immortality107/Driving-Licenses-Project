namespace DVLDProject
{
    partial class FilterUserControl1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.txtFilterInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By : ";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Items.AddRange(new object[] {
            "None",
            "ID",
            "National No.",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Gendor",
            "Country"});
            this.comboBoxFilter.Location = new System.Drawing.Point(100, 20);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(154, 21);
            this.comboBoxFilter.TabIndex = 1;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtFilterInput
            // 
            this.txtFilterInput.Location = new System.Drawing.Point(265, 21);
            this.txtFilterInput.Name = "txtFilterInput";
            this.txtFilterInput.Size = new System.Drawing.Size(220, 20);
            this.txtFilterInput.TabIndex = 2;
            // 
            // FilterUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtFilterInput);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "FilterUserControl1";
            this.Size = new System.Drawing.Size(504, 75);
            this.Load += new System.EventHandler(this.FilterUserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.TextBox txtFilterInput;
    }
}
