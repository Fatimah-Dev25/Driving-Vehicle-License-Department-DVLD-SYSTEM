namespace FirstProjectDVLD
{
    partial class frmMainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementForLostOrDamageLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.replacementForLostOrDamageLicenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.managingApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDrivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicesnswToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.manageApplicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.manageTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12.2F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1922, 72);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicenseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.managingApplicationToolStripMenuItem,
            this.toolStripMenuItem2,
            this.detainLicenseToolStripMenuItem,
            this.toolStripMenuItem3,
            this.manageApplicationTypesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.manageTestToolStripMenuItem});
            this.applicationToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.Application_Types_64;
            this.applicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(196, 68);
            this.applicationToolStripMenuItem.Text = "Applications";
            this.applicationToolStripMenuItem.Click += new System.EventHandler(this.applicationToolStripMenuItem_Click);
            // 
            // drivingLicenseToolStripMenuItem
            // 
            this.drivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.replacementForLostOrDamageLicenseToolStripMenuItem,
            this.replacementForLostOrDamageLicenseToolStripMenuItem1,
            this.toolStripMenuItem5,
            this.releaseDetainLicensesToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.drivingLicenseToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.License1;
            this.drivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.drivingLicenseToolStripMenuItem.Name = "drivingLicenseToolStripMenuItem";
            this.drivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(370, 68);
            this.drivingLicenseToolStripMenuItem.Text = "Driving License Services";
            this.drivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.drivingLicenseToolStripMenuItem_Click);
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.New_Driving_License_32;
            this.newDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(463, 38);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            this.newDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.newDrivingLicenseToolStripMenuItem_Click);
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.Local_32;
            this.localLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(291, 38);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.International_32;
            this.internationalLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(291, 38);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.Renew_Driving_License_32;
            this.renewDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(463, 38);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
            // 
            // replacementForLostOrDamageLicenseToolStripMenuItem
            // 
            this.replacementForLostOrDamageLicenseToolStripMenuItem.Name = "replacementForLostOrDamageLicenseToolStripMenuItem";
            this.replacementForLostOrDamageLicenseToolStripMenuItem.Size = new System.Drawing.Size(460, 6);
            this.replacementForLostOrDamageLicenseToolStripMenuItem.Click += new System.EventHandler(this.replacementForLostOrDamageLicenseToolStripMenuItem_Click);
            // 
            // replacementForLostOrDamageLicenseToolStripMenuItem1
            // 
            this.replacementForLostOrDamageLicenseToolStripMenuItem1.Image = global::FirstProjectDVLD.Properties.Resources.Damaged_Driving_License_32;
            this.replacementForLostOrDamageLicenseToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.replacementForLostOrDamageLicenseToolStripMenuItem1.Name = "replacementForLostOrDamageLicenseToolStripMenuItem1";
            this.replacementForLostOrDamageLicenseToolStripMenuItem1.Size = new System.Drawing.Size(463, 38);
            this.replacementForLostOrDamageLicenseToolStripMenuItem1.Text = "Replacement for Lost or Damage License";
            this.replacementForLostOrDamageLicenseToolStripMenuItem1.Click += new System.EventHandler(this.replacementForLostOrDamageLicenseToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(460, 6);
            // 
            // releaseDetainLicensesToolStripMenuItem
            // 
            this.releaseDetainLicensesToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.Release_Detained_License_32;
            this.releaseDetainLicensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainLicensesToolStripMenuItem.Name = "releaseDetainLicensesToolStripMenuItem";
            this.releaseDetainLicensesToolStripMenuItem.Size = new System.Drawing.Size(463, 38);
            this.releaseDetainLicensesToolStripMenuItem.Text = "Release Detained Driving Licenses";
            this.releaseDetainLicensesToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainLicensesToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.Retake_Test_32;
            this.retakeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(463, 38);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            this.retakeTestToolStripMenuItem.Click += new System.EventHandler(this.retakeTestToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(367, 6);
            // 
            // managingApplicationToolStripMenuItem
            // 
            this.managingApplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationsToolStripMenuItem,
            this.internationalDrivToolStripMenuItem});
            this.managingApplicationToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.appManage2;
            this.managingApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.managingApplicationToolStripMenuItem.Name = "managingApplicationToolStripMenuItem";
            this.managingApplicationToolStripMenuItem.Size = new System.Drawing.Size(370, 68);
            this.managingApplicationToolStripMenuItem.Text = "Managing Applications";
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.localDrivingLicenseApplicationsToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.LocalDriving_License;
            this.localDrivingLicenseApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(402, 38);
            this.localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // internationalDrivToolStripMenuItem
            // 
            this.internationalDrivToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.International_32;
            this.internationalDrivToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalDrivToolStripMenuItem.Name = "internationalDrivToolStripMenuItem";
            this.internationalDrivToolStripMenuItem.Size = new System.Drawing.Size(402, 38);
            this.internationalDrivToolStripMenuItem.Text = "International License Applications";
            this.internationalDrivToolStripMenuItem.Click += new System.EventHandler(this.internationalDrivToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(367, 6);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicesnswToolStripMenuItem,
            this.detainLicenseToolStripMenuItem1,
            this.releaseDetainLicenseToolStripMenuItem});
            this.detainLicenseToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.Detain_64;
            this.detainLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(370, 68);
            this.detainLicenseToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedLicesnswToolStripMenuItem
            // 
            this.manageDetainedLicesnswToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.Detain_32;
            this.manageDetainedLicesnswToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageDetainedLicesnswToolStripMenuItem.Name = "manageDetainedLicesnswToolStripMenuItem";
            this.manageDetainedLicesnswToolStripMenuItem.Size = new System.Drawing.Size(342, 38);
            this.manageDetainedLicesnswToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainedLicesnswToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicesnswToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem1
            // 
            this.detainLicenseToolStripMenuItem1.Image = global::FirstProjectDVLD.Properties.Resources.Detain_32;
            this.detainLicenseToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainLicenseToolStripMenuItem1.Name = "detainLicenseToolStripMenuItem1";
            this.detainLicenseToolStripMenuItem1.Size = new System.Drawing.Size(342, 38);
            this.detainLicenseToolStripMenuItem1.Text = "Detain License";
            this.detainLicenseToolStripMenuItem1.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem1_Click);
            // 
            // releaseDetainLicenseToolStripMenuItem
            // 
            this.releaseDetainLicenseToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.Release_Detained_License_32;
            this.releaseDetainLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainLicenseToolStripMenuItem.Name = "releaseDetainLicenseToolStripMenuItem";
            this.releaseDetainLicenseToolStripMenuItem.Size = new System.Drawing.Size(342, 38);
            this.releaseDetainLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(367, 6);
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            this.manageApplicationTypesToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.appManage;
            this.manageApplicationTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            this.manageApplicationTypesToolStripMenuItem.Size = new System.Drawing.Size(370, 68);
            this.manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            this.manageApplicationTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationTypesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(367, 6);
            // 
            // manageTestToolStripMenuItem
            // 
            this.manageTestToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.testManage;
            this.manageTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageTestToolStripMenuItem.Name = "manageTestToolStripMenuItem";
            this.manageTestToolStripMenuItem.Size = new System.Drawing.Size(370, 68);
            this.manageTestToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestToolStripMenuItem.Click += new System.EventHandler(this.manageTestToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.people;
            this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(134, 68);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.drivers;
            this.driversToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(135, 68);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.users;
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(122, 68);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItem6,
            this.signOutToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.account_settings_64;
            this.accountSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(235, 68);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.PersonDetails_32;
            this.currentUserInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.currentUserInfoToolStripMenuItem.Text = "Current User Info ";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.Password_32;
            this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(262, 6);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.sign_out_32__2;
            this.signOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(265, 38);
            this.signOutToolStripMenuItem.Text = "Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FirstProjectDVLD.Properties.Resources.logo_removebg_preview2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1922, 981);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1922, 1053);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managingApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem manageTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator replacementForLostOrDamageLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostOrDamageLicenseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicesnswToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}