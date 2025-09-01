namespace FirstProjectDVLD.Applications.LocalDrivingLicenses
{
    partial class frmListLocalDrivingLicenseApplication
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAllApplications = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ScheduleTestsMenue = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTesttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writtenTestToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.streetTestToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.shoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbAddApplication = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllApplications)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllApplications
            // 
            this.dgvAllApplications.AllowUserToAddRows = false;
            this.dgvAllApplications.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllApplications.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllApplications.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllApplications.Location = new System.Drawing.Point(12, 309);
            this.dgvAllApplications.Name = "dgvAllApplications";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllApplications.RowHeadersVisible = false;
            this.dgvAllApplications.RowHeadersWidth = 51;
            this.dgvAllApplications.RowTemplate.Height = 24;
            this.dgvAllApplications.Size = new System.Drawing.Size(1324, 359);
            this.dgvAllApplications.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AutoSize = false;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripMenuItem3,
            this.ScheduleTestsMenue,
            this.toolStripMenuItem4,
            this.issueToolStripMenuItem,
            this.toolStripMenuItem5,
            this.shoToolStripMenuItem,
            this.toolStripMenuItem6,
            this.showPersonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(341, 324);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showApplicationDetailToolStripMenuItem
            // 
            this.showApplicationDetailToolStripMenuItem.AutoSize = false;
            this.showApplicationDetailToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.showApplicationDetailToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.PersonDetails_32;
            this.showApplicationDetailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showApplicationDetailToolStripMenuItem.Name = "showApplicationDetailToolStripMenuItem";
            this.showApplicationDetailToolStripMenuItem.Size = new System.Drawing.Size(333, 34);
            this.showApplicationDetailToolStripMenuItem.Text = "Show Application Detail";
            this.showApplicationDetailToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(337, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.AutoSize = false;
            this.editApplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.editApplicationToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.edit_32;
            this.editApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(333, 34);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.AutoSize = false;
            this.deleteApplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteApplicationToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.Delete_32_2;
            this.deleteApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(333, 34);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(337, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.AutoSize = false;
            this.cancelApplicationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cancelApplicationToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.Delete_32;
            this.cancelApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(333, 34);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(337, 6);
            // 
            // ScheduleTestsMenue
            // 
            this.ScheduleTestsMenue.AutoSize = false;
            this.ScheduleTestsMenue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTesttoolStripMenuItem,
            this.writtenTestToolStripMenuItem8,
            this.streetTestToolStripMenuItem9});
            this.ScheduleTestsMenue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ScheduleTestsMenue.Image = global::FirstProjectDVLD.Properties.Resources.Schedule_Test_32;
            this.ScheduleTestsMenue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScheduleTestsMenue.Name = "ScheduleTestsMenue";
            this.ScheduleTestsMenue.Size = new System.Drawing.Size(333, 34);
            this.ScheduleTestsMenue.Text = "Sechdule Tests";
            // 
            // visionTesttoolStripMenuItem
            // 
            this.visionTesttoolStripMenuItem.AutoSize = false;
            this.visionTesttoolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.eye1;
            this.visionTesttoolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.visionTesttoolStripMenuItem.Name = "visionTesttoolStripMenuItem";
            this.visionTesttoolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.visionTesttoolStripMenuItem.Text = "Schedule Vision Test";
            this.visionTesttoolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // writtenTestToolStripMenuItem8
            // 
            this.writtenTestToolStripMenuItem8.AutoSize = false;
            this.writtenTestToolStripMenuItem8.Image = global::FirstProjectDVLD.Properties.Resources.Written_Test_32_Sechdule;
            this.writtenTestToolStripMenuItem8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.writtenTestToolStripMenuItem8.Name = "writtenTestToolStripMenuItem8";
            this.writtenTestToolStripMenuItem8.Size = new System.Drawing.Size(271, 34);
            this.writtenTestToolStripMenuItem8.Text = "Schedule Written Test";
            this.writtenTestToolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // streetTestToolStripMenuItem9
            // 
            this.streetTestToolStripMenuItem9.AutoSize = false;
            this.streetTestToolStripMenuItem9.Image = global::FirstProjectDVLD.Properties.Resources.Street_Test_32;
            this.streetTestToolStripMenuItem9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.streetTestToolStripMenuItem9.Name = "streetTestToolStripMenuItem9";
            this.streetTestToolStripMenuItem9.Size = new System.Drawing.Size(271, 34);
            this.streetTestToolStripMenuItem9.Text = "Schedule Street Test";
            this.streetTestToolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(337, 6);
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.AutoSize = false;
            this.issueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.issueToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.IssueDrivingLicense_32;
            this.issueToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(333, 34);
            this.issueToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.issueToolStripMenuItem.Click += new System.EventHandler(this.issueToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(337, 6);
            // 
            // shoToolStripMenuItem
            // 
            this.shoToolStripMenuItem.AutoSize = false;
            this.shoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.shoToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.License_View_32;
            this.shoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.shoToolStripMenuItem.Name = "shoToolStripMenuItem";
            this.shoToolStripMenuItem.Size = new System.Drawing.Size(333, 34);
            this.shoToolStripMenuItem.Text = "Show License";
            this.shoToolStripMenuItem.Click += new System.EventHandler(this.shoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(337, 6);
            // 
            // showPersonToolStripMenuItem
            // 
            this.showPersonToolStripMenuItem.AutoSize = false;
            this.showPersonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.showPersonToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonToolStripMenuItem.Name = "showPersonToolStripMenuItem";
            this.showPersonToolStripMenuItem.Size = new System.Drawing.Size(333, 34);
            this.showPersonToolStripMenuItem.Text = "Show Person License History";
            this.showPersonToolStripMenuItem.Click += new System.EventHandler(this.showPersonToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 692);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "#Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(110, 692);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(37, 24);
            this.lblRecordsCount.TabIndex = 6;
            this.lblRecordsCount.Text = "???";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "National No.",
            "Full Name",
            "Status"});
            this.cbFilterBy.Location = new System.Drawing.Point(114, 256);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(238, 24);
            this.cbFilterBy.TabIndex = 8;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Location = new System.Drawing.Point(362, 256);
            this.txtFilterBy.Multiline = true;
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(239, 24);
            this.txtFilterBy.TabIndex = 9;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1165, 686);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 38);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbAddApplication
            // 
            this.pbAddApplication.Image = global::FirstProjectDVLD.Properties.Resources.New_Application_64;
            this.pbAddApplication.Location = new System.Drawing.Point(1234, 216);
            this.pbAddApplication.Name = "pbAddApplication";
            this.pbAddApplication.Size = new System.Drawing.Size(102, 81);
            this.pbAddApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddApplication.TabIndex = 2;
            this.pbAddApplication.TabStop = false;
            this.pbAddApplication.Click += new System.EventHandler(this.pbAddApplication_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FirstProjectDVLD.Properties.Resources.Local_32;
            this.pictureBox2.Location = new System.Drawing.Point(743, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstProjectDVLD.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1346, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmListLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1348, 741);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAllApplications);
            this.Controls.Add(this.pbAddApplication);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving Licenses Applications Management";
            this.Load += new System.EventHandler(this.frmListLocalDrivingLicenseApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllApplications)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbAddApplication;
        private System.Windows.Forms.DataGridView dgvAllApplications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTestsMenue;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem shoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem showPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionTesttoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writtenTestToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem streetTestToolStripMenuItem9;
    }
}