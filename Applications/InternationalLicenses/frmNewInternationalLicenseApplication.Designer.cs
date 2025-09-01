namespace FirstProjectDVLD.Applications.InternationalLicenses
{
    partial class frmNewInternationalLicenseApplication
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.lblShowNewLicInfo = new System.Windows.Forms.LinkLabel();
            this.llShowLicHistory = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLocalLicID = new System.Windows.Forms.Label();
            this.lblInternationalLicID = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.lblInternationalAppID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ctrlDriverLicenseInfoWithFilter1 = new FirstProjectDVLD.licenses.LocalLicenses.Controls.ctrlDriverLicenseInfoWithFilter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(927, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "International License Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(584, 762);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(156, 44);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Enabled = false;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Image = global::FirstProjectDVLD.Properties.Resources.International_32;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(748, 762);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(164, 44);
            this.btnIssue.TabIndex = 16;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // lblShowNewLicInfo
            // 
            this.lblShowNewLicInfo.AutoSize = true;
            this.lblShowNewLicInfo.Enabled = false;
            this.lblShowNewLicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblShowNewLicInfo.Location = new System.Drawing.Point(216, 770);
            this.lblShowNewLicInfo.Name = "lblShowNewLicInfo";
            this.lblShowNewLicInfo.Size = new System.Drawing.Size(208, 24);
            this.lblShowNewLicInfo.TabIndex = 15;
            this.lblShowNewLicInfo.TabStop = true;
            this.lblShowNewLicInfo.Text = "Show New License Info";
            this.lblShowNewLicInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowNewLicInfo_LinkClicked);
            // 
            // llShowLicHistory
            // 
            this.llShowLicHistory.AutoSize = true;
            this.llShowLicHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.llShowLicHistory.Location = new System.Drawing.Point(8, 770);
            this.llShowLicHistory.Name = "llShowLicHistory";
            this.llShowLicHistory.Size = new System.Drawing.Size(191, 24);
            this.llShowLicHistory.TabIndex = 14;
            this.llShowLicHistory.TabStop = true;
            this.llShowLicHistory.Text = "Show License History";
            this.llShowLicHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicHistory_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblExpirationDate);
            this.groupBox2.Controls.Add(this.lblIssueDate);
            this.groupBox2.Controls.Add(this.lblUserID);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblFees);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblLocalLicID);
            this.groupBox2.Controls.Add(this.lblInternationalLicID);
            this.groupBox2.Controls.Add(this.pictureBox9);
            this.groupBox2.Controls.Add(this.pictureBox10);
            this.groupBox2.Controls.Add(this.pictureBox11);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblAppDate);
            this.groupBox2.Controls.Add(this.lblInternationalAppID);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.6F);
            this.groupBox2.Location = new System.Drawing.Point(12, 555);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 186);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Info";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.ForeColor = System.Drawing.Color.Black;
            this.lblExpirationDate.Location = new System.Drawing.Point(685, 115);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(114, 24);
            this.lblExpirationDate.TabIndex = 71;
            this.lblExpirationDate.Text = "[??/??/????]";
            this.lblExpirationDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.ForeColor = System.Drawing.Color.Black;
            this.lblIssueDate.Location = new System.Drawing.Point(236, 114);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(114, 24);
            this.lblIssueDate.TabIndex = 70;
            this.lblIssueDate.Text = "[??/??/????]";
            this.lblIssueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(685, 154);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(60, 24);
            this.lblUserID.TabIndex = 69;
            this.lblUserID.Text = "[????]";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstProjectDVLD.Properties.Resources.User_32__2;
            this.pictureBox1.Location = new System.Drawing.Point(640, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(479, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 67;
            this.label5.Text = "Created By:";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(236, 154);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(54, 24);
            this.lblFees.TabIndex = 66;
            this.lblFees.Text = "[$$$]";
            this.lblFees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FirstProjectDVLD.Properties.Resources.money_32;
            this.pictureBox5.Location = new System.Drawing.Point(188, 152);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 65;
            this.pictureBox5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 24);
            this.label8.TabIndex = 64;
            this.label8.Text = "Fees:";
            // 
            // lblLocalLicID
            // 
            this.lblLocalLicID.AutoSize = true;
            this.lblLocalLicID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicID.ForeColor = System.Drawing.Color.Black;
            this.lblLocalLicID.Location = new System.Drawing.Point(685, 73);
            this.lblLocalLicID.Name = "lblLocalLicID";
            this.lblLocalLicID.Size = new System.Drawing.Size(51, 24);
            this.lblLocalLicID.TabIndex = 62;
            this.lblLocalLicID.Text = "[???]";
            this.lblLocalLicID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInternationalLicID
            // 
            this.lblInternationalLicID.AutoSize = true;
            this.lblInternationalLicID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalLicID.Location = new System.Drawing.Point(685, 32);
            this.lblInternationalLicID.Name = "lblInternationalLicID";
            this.lblInternationalLicID.Size = new System.Drawing.Size(51, 24);
            this.lblInternationalLicID.TabIndex = 61;
            this.lblInternationalLicID.Text = "[???]";
            this.lblInternationalLicID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::FirstProjectDVLD.Properties.Resources.Calendar_32;
            this.pictureBox9.Location = new System.Drawing.Point(640, 112);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(36, 30);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 58;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::FirstProjectDVLD.Properties.Resources.License1;
            this.pictureBox10.Location = new System.Drawing.Point(640, 71);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(36, 30);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 57;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::FirstProjectDVLD.Properties.Resources.International_32;
            this.pictureBox11.Location = new System.Drawing.Point(640, 30);
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
            this.label15.Location = new System.Drawing.Point(479, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 24);
            this.label15.TabIndex = 53;
            this.label15.Text = "Expiration Date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(479, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 24);
            this.label16.TabIndex = 52;
            this.label16.Text = "Local License ID:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(479, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 24);
            this.label17.TabIndex = 51;
            this.label17.Text = "I.L. License ID:";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.ForeColor = System.Drawing.Color.Black;
            this.lblAppDate.Location = new System.Drawing.Point(236, 73);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(114, 24);
            this.lblAppDate.TabIndex = 46;
            this.lblAppDate.Text = "[??/??/????]";
            this.lblAppDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInternationalAppID
            // 
            this.lblInternationalAppID.AutoSize = true;
            this.lblInternationalAppID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalAppID.Location = new System.Drawing.Point(236, 32);
            this.lblInternationalAppID.Name = "lblInternationalAppID";
            this.lblInternationalAppID.Size = new System.Drawing.Size(51, 24);
            this.lblInternationalAppID.TabIndex = 45;
            this.lblInternationalAppID.Text = "[???]";
            this.lblInternationalAppID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FirstProjectDVLD.Properties.Resources.Calendar_32;
            this.pictureBox4.Location = new System.Drawing.Point(188, 112);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FirstProjectDVLD.Properties.Resources.Calendar_32;
            this.pictureBox3.Location = new System.Drawing.Point(188, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 40;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FirstProjectDVLD.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(188, 29);
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
            this.label3.Location = new System.Drawing.Point(19, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Issue Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Application Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 24);
            this.label7.TabIndex = 33;
            this.label7.Text = "I.L. Application ID:";
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            this.ctrlDriverLicenseInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            this.ctrlDriverLicenseInfoWithFilter1.Location = new System.Drawing.Point(4, 61);
            this.ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            this.ctrlDriverLicenseInfoWithFilter1.Size = new System.Drawing.Size(917, 496);
            this.ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            this.ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected);
            this.ctrlDriverLicenseInfoWithFilter1.Load += new System.EventHandler(this.ctrlDriverLicenseInfoWithFilter1_Load);
            // 
            // frmNewInternationalLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 819);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.lblShowNewLicInfo);
            this.Controls.Add(this.llShowLicHistory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlDriverLicenseInfoWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewInternationalLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "International License Application";
            this.Load += new System.EventHandler(this.frmNewInternationalLicenseApplication_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
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

        private licenses.LocalLicenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.LinkLabel lblShowNewLicInfo;
        private System.Windows.Forms.LinkLabel llShowLicHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLocalLicID;
        private System.Windows.Forms.Label lblInternationalLicID;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label lblInternationalAppID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblExpirationDate;
    }
}