namespace FirstProjectDVLD.Applications.ReplaceLostOrDamagedLicense
{
    partial class frmReplaceLostOrDamagedLicenseApplication
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbRplacementReason = new System.Windows.Forms.GroupBox();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.llShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblOldLicID = new System.Windows.Forms.Label();
            this.lblReplaceID = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblReplaceAppFees = new System.Windows.Forms.Label();
            this.lblReplaceAppDate = new System.Windows.Forms.Label();
            this.lblReplaceAppID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfoWithFilter1 = new FirstProjectDVLD.licenses.LocalLicenses.Controls.ctrlDriverLicenseInfoWithFilter();
            this.gbRplacementReason.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Lavender;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblTitle.Location = new System.Drawing.Point(-1, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(925, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "License Replacement";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbRplacementReason
            // 
            this.gbRplacementReason.Controls.Add(this.rbLostLicense);
            this.gbRplacementReason.Controls.Add(this.rbDamagedLicense);
            this.gbRplacementReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.gbRplacementReason.Location = new System.Drawing.Point(606, 70);
            this.gbRplacementReason.Name = "gbRplacementReason";
            this.gbRplacementReason.Size = new System.Drawing.Size(309, 91);
            this.gbRplacementReason.TabIndex = 2;
            this.gbRplacementReason.TabStop = false;
            this.gbRplacementReason.Text = "Replacement For:";
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Location = new System.Drawing.Point(24, 58);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(132, 26);
            this.rbLostLicense.TabIndex = 1;
            this.rbLostLicense.TabStop = true;
            this.rbLostLicense.Text = "Lost License";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            this.rbLostLicense.CheckedChanged += new System.EventHandler(this.rbLostLicense_CheckedChanged);
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Location = new System.Drawing.Point(24, 26);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(175, 26);
            this.rbDamagedLicense.TabIndex = 0;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "Damaged License";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(505, 739);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 44);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.Image = global::FirstProjectDVLD.Properties.Resources.IssueDrivingLicense_32;
            this.btnReplace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplace.Location = new System.Drawing.Point(675, 739);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(237, 44);
            this.btnReplace.TabIndex = 11;
            this.btnReplace.Text = "Issue Replacement";
            this.btnReplace.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // llShowNewLicenseInfo
            // 
            this.llShowNewLicenseInfo.AutoSize = true;
            this.llShowNewLicenseInfo.Enabled = false;
            this.llShowNewLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.llShowNewLicenseInfo.Location = new System.Drawing.Point(216, 747);
            this.llShowNewLicenseInfo.Name = "llShowNewLicenseInfo";
            this.llShowNewLicenseInfo.Size = new System.Drawing.Size(208, 24);
            this.llShowNewLicenseInfo.TabIndex = 10;
            this.llShowNewLicenseInfo.TabStop = true;
            this.llShowNewLicenseInfo.Text = "Show New License Info";
            this.llShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowNewLicenseInfo_LinkClicked);
            // 
            // llShowLicenseHistory
            // 
            this.llShowLicenseHistory.AutoSize = true;
            this.llShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.llShowLicenseHistory.Location = new System.Drawing.Point(8, 747);
            this.llShowLicenseHistory.Name = "llShowLicenseHistory";
            this.llShowLicenseHistory.Size = new System.Drawing.Size(191, 24);
            this.llShowLicenseHistory.TabIndex = 9;
            this.llShowLicenseHistory.TabStop = true;
            this.llShowLicenseHistory.Text = "Show License History";
            this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCreatedBy);
            this.groupBox2.Controls.Add(this.lblOldLicID);
            this.groupBox2.Controls.Add(this.lblReplaceID);
            this.groupBox2.Controls.Add(this.pictureBox9);
            this.groupBox2.Controls.Add(this.pictureBox10);
            this.groupBox2.Controls.Add(this.pictureBox11);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblReplaceAppFees);
            this.groupBox2.Controls.Add(this.lblReplaceAppDate);
            this.groupBox2.Controls.Add(this.lblReplaceAppID);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.6F);
            this.groupBox2.Location = new System.Drawing.Point(12, 544);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 174);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Info for License Replacement";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(732, 126);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(60, 24);
            this.lblCreatedBy.TabIndex = 63;
            this.lblCreatedBy.Text = "[????]";
            this.lblCreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCreatedBy.Click += new System.EventHandler(this.lblExpirationDate_Click);
            // 
            // lblOldLicID
            // 
            this.lblOldLicID.AutoSize = true;
            this.lblOldLicID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicID.ForeColor = System.Drawing.Color.Black;
            this.lblOldLicID.Location = new System.Drawing.Point(732, 85);
            this.lblOldLicID.Name = "lblOldLicID";
            this.lblOldLicID.Size = new System.Drawing.Size(51, 24);
            this.lblOldLicID.TabIndex = 62;
            this.lblOldLicID.Text = "[???]";
            this.lblOldLicID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReplaceID
            // 
            this.lblReplaceID.AutoSize = true;
            this.lblReplaceID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplaceID.Location = new System.Drawing.Point(732, 44);
            this.lblReplaceID.Name = "lblReplaceID";
            this.lblReplaceID.Size = new System.Drawing.Size(51, 24);
            this.lblReplaceID.TabIndex = 61;
            this.lblReplaceID.Text = "[???]";
            this.lblReplaceID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::FirstProjectDVLD.Properties.Resources.User_32__2;
            this.pictureBox9.Location = new System.Drawing.Point(687, 126);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(36, 30);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 58;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::FirstProjectDVLD.Properties.Resources.License1;
            this.pictureBox10.Location = new System.Drawing.Point(687, 85);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(36, 30);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 57;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::FirstProjectDVLD.Properties.Resources.License1;
            this.pictureBox11.Location = new System.Drawing.Point(687, 44);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(36, 30);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 56;
            this.pictureBox11.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(499, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 24);
            this.label15.TabIndex = 53;
            this.label15.Text = "Created By:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(499, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 24);
            this.label16.TabIndex = 52;
            this.label16.Text = "Old License ID:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(499, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(180, 24);
            this.label17.TabIndex = 51;
            this.label17.Text = "Replaced License ID:";
            // 
            // lblReplaceAppFees
            // 
            this.lblReplaceAppFees.AutoSize = true;
            this.lblReplaceAppFees.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplaceAppFees.Location = new System.Drawing.Point(244, 126);
            this.lblReplaceAppFees.Name = "lblReplaceAppFees";
            this.lblReplaceAppFees.Size = new System.Drawing.Size(54, 24);
            this.lblReplaceAppFees.TabIndex = 47;
            this.lblReplaceAppFees.Text = "[$$$]";
            this.lblReplaceAppFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReplaceAppDate
            // 
            this.lblReplaceAppDate.AutoSize = true;
            this.lblReplaceAppDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplaceAppDate.ForeColor = System.Drawing.Color.Black;
            this.lblReplaceAppDate.Location = new System.Drawing.Point(244, 85);
            this.lblReplaceAppDate.Name = "lblReplaceAppDate";
            this.lblReplaceAppDate.Size = new System.Drawing.Size(114, 24);
            this.lblReplaceAppDate.TabIndex = 46;
            this.lblReplaceAppDate.Text = "[??/??/????]";
            this.lblReplaceAppDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReplaceAppID
            // 
            this.lblReplaceAppID.AutoSize = true;
            this.lblReplaceAppID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplaceAppID.Location = new System.Drawing.Point(244, 44);
            this.lblReplaceAppID.Name = "lblReplaceAppID";
            this.lblReplaceAppID.Size = new System.Drawing.Size(51, 24);
            this.lblReplaceAppID.TabIndex = 45;
            this.lblReplaceAppID.Text = "[???]";
            this.lblReplaceAppID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FirstProjectDVLD.Properties.Resources.money_32;
            this.pictureBox4.Location = new System.Drawing.Point(196, 126);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FirstProjectDVLD.Properties.Resources.Calendar_32;
            this.pictureBox3.Location = new System.Drawing.Point(196, 85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FirstProjectDVLD.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(196, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Application Fees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Application Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "R.L. Application ID:";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(7, 54);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(908, 496);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 1;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            this.ctrlDriverLicenseInfoWithFilter1.Load += new System.EventHandler(this.ctrlDriverLicenseInfoWithFilter1_Load);
            // 
            // frmReplaceLostOrDamagedLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 799);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.llShowNewLicenseInfo);
            this.Controls.Add(this.llShowLicenseHistory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbRplacementReason);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReplaceLostOrDamagedLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReplaceLostOrDamagedLicenseApplication";
            this.Activated += new System.EventHandler(this.frmReplaceLostOrDamagedLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.frmReplaceLostOrDamagedLicenseApplication_Load);
            this.gbRplacementReason.ResumeLayout(false);
            this.gbRplacementReason.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private licenses.LocalLicenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.GroupBox gbRplacementReason;
        private System.Windows.Forms.RadioButton rbLostLicense;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.LinkLabel llShowNewLicenseInfo;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblOldLicID;
        private System.Windows.Forms.Label lblReplaceID;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblReplaceAppFees;
        private System.Windows.Forms.Label lblReplaceAppDate;
        private System.Windows.Forms.Label lblReplaceAppID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
    }
}