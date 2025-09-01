namespace FirstProjectDVLD.licenses.LocalLicenses
{
    partial class frmIssueDriverLicenseFirstTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnIssueLicense = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlLocalLicenseAppInfo1 = new FirstProjectDVLD.Applications.LocalDrivingLicenses.ctrlLocalLicenseAppInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notes:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstProjectDVLD.Properties.Resources.Notes_32;
            this.pictureBox1.Location = new System.Drawing.Point(95, 350);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(149, 353);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(760, 155);
            this.txtNotes.TabIndex = 3;
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIssueLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnIssueLicense.Image = global::FirstProjectDVLD.Properties.Resources.IssueDrivingLicense_32;
            this.btnIssueLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueLicense.Location = new System.Drawing.Point(747, 525);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(162, 44);
            this.btnIssueLicense.TabIndex = 4;
            this.btnIssueLicense.Text = "Issue";
            this.btnIssueLicense.UseVisualStyleBackColor = true;
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(578, 525);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(162, 44);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlLocalLicenseAppInfo1
            // 
            this.ctrlLocalLicenseAppInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalLicenseAppInfo1.Location = new System.Drawing.Point(7, 12);
            this.ctrlLocalLicenseAppInfo1.Name = "ctrlLocalLicenseAppInfo1";
            this.ctrlLocalLicenseAppInfo1.Size = new System.Drawing.Size(909, 338);
            this.ctrlLocalLicenseAppInfo1.TabIndex = 0;
            // 
            // frmIssueDriverLicenseFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 591);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssueLicense);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlLocalLicenseAppInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIssueDriverLicenseFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmIssueDriverLicenseFirstTime";
            this.Load += new System.EventHandler(this.frmIssueDriverLicenseFirstTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Applications.LocalDrivingLicenses.ctrlLocalLicenseAppInfo ctrlLocalLicenseAppInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnIssueLicense;
        private System.Windows.Forms.Button btnClose;
    }
}