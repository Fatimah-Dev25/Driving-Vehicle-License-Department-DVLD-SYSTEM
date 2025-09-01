namespace FirstProjectDVLD.Tests
{
    partial class frmListTestAppointments
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
            this.lblTestTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTestAppointments = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbAddNewAppointment = new System.Windows.Forms.PictureBox();
            this.pbTestIMG = new System.Windows.Forms.PictureBox();
            this.ctrlLocalLicenseAppInfo1 = new FirstProjectDVLD.Applications.LocalDrivingLicenses.ctrlLocalLicenseAppInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNewAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTestTitle
            // 
            this.lblTestTitle.Font = new System.Drawing.Font("Calibri", 20.2F, System.Drawing.FontStyle.Bold);
            this.lblTestTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTestTitle.Location = new System.Drawing.Point(6, 132);
            this.lblTestTitle.Name = "lblTestTitle";
            this.lblTestTitle.Size = new System.Drawing.Size(909, 41);
            this.lblTestTitle.TabIndex = 1;
            this.lblTestTitle.Text = "Vision Test Appointments";
            this.lblTestTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Appointments:";
            // 
            // dgvTestAppointments
            // 
            this.dgvTestAppointments.AllowUserToAddRows = false;
            this.dgvTestAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestAppointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTestAppointments.Location = new System.Drawing.Point(13, 579);
            this.dgvTestAppointments.Name = "dgvTestAppointments";
            this.dgvTestAppointments.RowHeadersVisible = false;
            this.dgvTestAppointments.RowHeadersWidth = 51;
            this.dgvTestAppointments.RowTemplate.Height = 24;
            this.dgvTestAppointments.Size = new System.Drawing.Size(902, 175);
            this.dgvTestAppointments.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(20, 769);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "#Records: ";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, System.Drawing.FontStyle.Bold);
            this.lblRecordsCount.Location = new System.Drawing.Point(142, 769);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(43, 24);
            this.lblRecordsCount.TabIndex = 8;
            this.lblRecordsCount.Text = "???";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 108);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(153, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(753, 765);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(159, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbAddNewAppointment
            // 
            this.pbAddNewAppointment.Image = global::FirstProjectDVLD.Properties.Resources.AddAppointment_32;
            this.pbAddNewAppointment.Location = new System.Drawing.Point(838, 525);
            this.pbAddNewAppointment.Name = "pbAddNewAppointment";
            this.pbAddNewAppointment.Size = new System.Drawing.Size(62, 41);
            this.pbAddNewAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddNewAppointment.TabIndex = 5;
            this.pbAddNewAppointment.TabStop = false;
            this.pbAddNewAppointment.Click += new System.EventHandler(this.pbAddNewAppointment_Click);
            // 
            // pbTestIMG
            // 
            this.pbTestIMG.Image = global::FirstProjectDVLD.Properties.Resources.Vision_512;
            this.pbTestIMG.Location = new System.Drawing.Point(6, 12);
            this.pbTestIMG.Name = "pbTestIMG";
            this.pbTestIMG.Size = new System.Drawing.Size(909, 114);
            this.pbTestIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTestIMG.TabIndex = 0;
            this.pbTestIMG.TabStop = false;
            // 
            // ctrlLocalLicenseAppInfo1
            // 
            this.ctrlLocalLicenseAppInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalLicenseAppInfo1.Location = new System.Drawing.Point(6, 186);
            this.ctrlLocalLicenseAppInfo1.Name = "ctrlLocalLicenseAppInfo1";
            this.ctrlLocalLicenseAppInfo1.Size = new System.Drawing.Size(909, 338);
            this.ctrlLocalLicenseAppInfo1.TabIndex = 10;
            // 
            // frmListTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 820);
            this.Controls.Add(this.ctrlLocalLicenseAppInfo1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTestAppointments);
            this.Controls.Add(this.pbAddNewAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTestTitle);
            this.Controls.Add(this.pbTestIMG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListTestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListTestAppointments";
            this.Load += new System.EventHandler(this.frmListTestAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNewAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTestIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTestIMG;
        private System.Windows.Forms.Label lblTestTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAddNewAppointment;
        private System.Windows.Forms.DataGridView dgvTestAppointments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Button btnClose;
        private Applications.LocalDrivingLicenses.ctrlLocalLicenseAppInfo ctrlLocalLicenseAppInfo1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}