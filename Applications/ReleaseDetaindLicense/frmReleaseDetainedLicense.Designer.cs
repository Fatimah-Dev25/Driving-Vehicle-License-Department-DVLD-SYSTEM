namespace FirstProjectDVLD.Applications.ReleaseDetaindLicense
{
    partial class frmReleaseDetainedLicense
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
            this.ctrlDriverLicenseInfoWithFilter1 = new FirstProjectDVLD.licenses.LocalLicenses.Controls.ctrlDriverLicenseInfoWithFilter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFineFees = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.lblcreatedUser = new System.Windows.Forms.Label();
            this.lblLicID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbldetainDate = new System.Windows.Forms.Label();
            this.lblDetainId = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llshowLicInfo = new System.Windows.Forms.LinkLabel();
            this.llshowLicHistory = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(5, 54);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(917, 496);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(-3, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(933, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Release Detained Licenese";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblApplicationID);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblTotalFees);
            this.groupBox1.Controls.Add(this.pictureBox8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblFineFees);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblAppFees);
            this.groupBox1.Controls.Add(this.lblcreatedUser);
            this.groupBox1.Controls.Add(this.lblLicID);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbldetainDate);
            this.groupBox1.Controls.Add(this.lblDetainId);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.groupBox1.Location = new System.Drawing.Point(14, 540);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 204);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detain Info";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(659, 154);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(46, 22);
            this.lblApplicationID.TabIndex = 23;
            this.lblApplicationID.Text = "[???]";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::FirstProjectDVLD.Properties.Resources.Number_32;
            this.pictureBox7.Location = new System.Drawing.Point(597, 147);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(46, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 22;
            this.pictureBox7.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(465, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 22);
            this.label11.TabIndex = 21;
            this.label11.Text = "Application ID:";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.Location = new System.Drawing.Point(212, 154);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(49, 22);
            this.lblTotalFees.TabIndex = 20;
            this.lblTotalFees.Text = "[$$$]";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::FirstProjectDVLD.Properties.Resources.money_32;
            this.pictureBox8.Location = new System.Drawing.Point(150, 147);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(46, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 22);
            this.label13.TabIndex = 18;
            this.label13.Text = "Total Fees:";
            // 
            // lblFineFees
            // 
            this.lblFineFees.AutoSize = true;
            this.lblFineFees.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.Location = new System.Drawing.Point(659, 116);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(49, 22);
            this.lblFineFees.TabIndex = 17;
            this.lblFineFees.Text = "[$$$]";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::FirstProjectDVLD.Properties.Resources.money_32;
            this.pictureBox6.Location = new System.Drawing.Point(597, 109);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(46, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(465, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "Fine Fees:";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.Location = new System.Drawing.Point(212, 116);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(49, 22);
            this.lblAppFees.TabIndex = 14;
            this.lblAppFees.Text = "[$$$]";
            // 
            // lblcreatedUser
            // 
            this.lblcreatedUser.AutoSize = true;
            this.lblcreatedUser.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreatedUser.Location = new System.Drawing.Point(659, 77);
            this.lblcreatedUser.Name = "lblcreatedUser";
            this.lblcreatedUser.Size = new System.Drawing.Size(54, 22);
            this.lblcreatedUser.TabIndex = 13;
            this.lblcreatedUser.Text = "[????]";
            // 
            // lblLicID
            // 
            this.lblLicID.AutoSize = true;
            this.lblLicID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicID.Location = new System.Drawing.Point(659, 38);
            this.lblLicID.Name = "lblLicID";
            this.lblLicID.Size = new System.Drawing.Size(46, 22);
            this.lblLicID.TabIndex = 12;
            this.lblLicID.Text = "[???]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FirstProjectDVLD.Properties.Resources.User_32__2;
            this.pictureBox4.Location = new System.Drawing.Point(597, 71);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FirstProjectDVLD.Properties.Resources.License1;
            this.pictureBox5.Location = new System.Drawing.Point(597, 33);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(465, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Created By:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(465, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "License ID:";
            // 
            // lbldetainDate
            // 
            this.lbldetainDate.AutoSize = true;
            this.lbldetainDate.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetainDate.Location = new System.Drawing.Point(212, 77);
            this.lbldetainDate.Name = "lbldetainDate";
            this.lbldetainDate.Size = new System.Drawing.Size(102, 22);
            this.lbldetainDate.TabIndex = 7;
            this.lbldetainDate.Text = "[??/??/????]";
            // 
            // lblDetainId
            // 
            this.lblDetainId.AutoSize = true;
            this.lblDetainId.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainId.Location = new System.Drawing.Point(212, 38);
            this.lblDetainId.Name = "lblDetainId";
            this.lblDetainId.Size = new System.Drawing.Size(46, 22);
            this.lblDetainId.TabIndex = 6;
            this.lblDetainId.Text = "[???]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FirstProjectDVLD.Properties.Resources.money_32;
            this.pictureBox3.Location = new System.Drawing.Point(150, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FirstProjectDVLD.Properties.Resources.Calendar_32;
            this.pictureBox2.Location = new System.Drawing.Point(150, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstProjectDVLD.Properties.Resources.Number_321;
            this.pictureBox1.Location = new System.Drawing.Point(150, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Application Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Detain Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detain ID:";
            // 
            // llshowLicInfo
            // 
            this.llshowLicInfo.AutoSize = true;
            this.llshowLicInfo.Enabled = false;
            this.llshowLicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.llshowLicInfo.Location = new System.Drawing.Point(236, 772);
            this.llshowLicInfo.Name = "llshowLicInfo";
            this.llshowLicInfo.Size = new System.Drawing.Size(156, 22);
            this.llshowLicInfo.TabIndex = 10;
            this.llshowLicInfo.TabStop = true;
            this.llshowLicInfo.Text = "Show License Info";
            this.llshowLicInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llshowLicInfo_LinkClicked);
            // 
            // llshowLicHistory
            // 
            this.llshowLicHistory.AutoSize = true;
            this.llshowLicHistory.Enabled = false;
            this.llshowLicHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.llshowLicHistory.Location = new System.Drawing.Point(29, 772);
            this.llshowLicHistory.Name = "llshowLicHistory";
            this.llshowLicHistory.Size = new System.Drawing.Size(183, 22);
            this.llshowLicHistory.TabIndex = 9;
            this.llshowLicHistory.TabStop = true;
            this.llshowLicHistory.Text = "Show License History";
            this.llshowLicHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llshowLicHistory_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(581, 760);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 44);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.Enabled = false;
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnRelease.Image = global::FirstProjectDVLD.Properties.Resources.Release_Detained_License_32;
            this.btnRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelease.Location = new System.Drawing.Point(751, 760);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(164, 44);
            this.btnRelease.TabIndex = 7;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // frmReleaseDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 829);
            this.Controls.Add(this.llshowLicInfo);
            this.Controls.Add(this.llshowLicHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReleaseDetainedLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmReleaseDetainedLicense";
            this.Load += new System.EventHandler(this.frmReleaseDetainedLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private licenses.LocalLicenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFineFees;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.Label lblcreatedUser;
        private System.Windows.Forms.Label lblLicID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbldetainDate;
        private System.Windows.Forms.Label lblDetainId;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel llshowLicInfo;
        private System.Windows.Forms.LinkLabel llshowLicHistory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRelease;
    }
}