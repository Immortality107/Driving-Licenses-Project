namespace DVLDProject.Forms
{
    partial class FrmLocalDLAppInfo
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
            this.CtrlappBasicInfo = new DVLDProject.UserControls.AppBasicInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CtrlappBasicInfo
            // 
            this.CtrlappBasicInfo.Location = new System.Drawing.Point(4, 15);
            this.CtrlappBasicInfo.Name = "CtrlappBasicInfo";
            this.CtrlappBasicInfo.Size = new System.Drawing.Size(873, 427);
            this.CtrlappBasicInfo.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.AutoEllipsis = true;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDProject.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(774, 412);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 36);
            this.btnClose.TabIndex = 138;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmLocalDLAppInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 483);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.CtrlappBasicInfo);
            this.Name = "FrmLocalDLAppInfo";
            this.Text = "FrmLocalDLAppInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.AppBasicInfo CtrlappBasicInfo;
        private System.Windows.Forms.Button btnClose;
    }
}