namespace FirstProjectDVLD.Applications.LocalDrivingLicenses
{
    partial class frmLocalDrivingLicenseApplicationInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlLocalLicenseAppInfo1 = new FirstProjectDVLD.Applications.LocalDrivingLicenses.ctrlLocalLicenseAppInfo();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(728, 364);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(174, 46);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlLocalLicenseAppInfo1
            // 
            this.ctrlLocalLicenseAppInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalLicenseAppInfo1.Location = new System.Drawing.Point(3, 20);
            this.ctrlLocalLicenseAppInfo1.Name = "ctrlLocalLicenseAppInfo1";
            this.ctrlLocalLicenseAppInfo1.Size = new System.Drawing.Size(909, 338);
            this.ctrlLocalLicenseAppInfo1.TabIndex = 0;
            // 
            // frmLocalDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 444);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlLocalLicenseAppInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLocalDrivingLicenseApplicationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Local Driving License Application Info";
            this.Load += new System.EventHandler(this.frmLocalDrivingLicenseApplicationInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLocalLicenseAppInfo ctrlLocalLicenseAppInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}