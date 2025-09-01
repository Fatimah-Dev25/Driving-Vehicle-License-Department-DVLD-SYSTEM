namespace FirstProjectDVLD.Applications.ReleaseDetaindLicense
{
    partial class frmListDetainedLicenses
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDetainLicense = new System.Windows.Forms.Button();
            this.btnReleaseLicense = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.cbIsReleased = new System.Windows.Forms.ComboBox();
            this.dgvAllDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDetainedLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstProjectDVLD.Properties.Resources.Detain_512;
            this.pictureBox1.Location = new System.Drawing.Point(9, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1298, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(9, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1298, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Detained Licenses";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDetainLicense
            // 
            this.btnDetainLicense.BackgroundImage = global::FirstProjectDVLD.Properties.Resources.Detain_64;
            this.btnDetainLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDetainLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetainLicense.Location = new System.Drawing.Point(1224, 266);
            this.btnDetainLicense.Name = "btnDetainLicense";
            this.btnDetainLicense.Size = new System.Drawing.Size(80, 64);
            this.btnDetainLicense.TabIndex = 2;
            this.btnDetainLicense.UseVisualStyleBackColor = true;
            this.btnDetainLicense.Click += new System.EventHandler(this.btnDetainLicense_Click);
            // 
            // btnReleaseLicense
            // 
            this.btnReleaseLicense.BackgroundImage = global::FirstProjectDVLD.Properties.Resources.Release_Detained_License_64;
            this.btnReleaseLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReleaseLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReleaseLicense.Location = new System.Drawing.Point(1138, 266);
            this.btnReleaseLicense.Name = "btnReleaseLicense";
            this.btnReleaseLicense.Size = new System.Drawing.Size(76, 64);
            this.btnReleaseLicense.TabIndex = 3;
            this.btnReleaseLicense.UseVisualStyleBackColor = true;
            this.btnReleaseLicense.Click += new System.EventHandler(this.btnReleaseLicense_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter By:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "Is Released",
            "National No.",
            "Full Name",
            "Release Application ID"});
            this.cbFilter.Location = new System.Drawing.Point(111, 294);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(215, 24);
            this.cbFilter.TabIndex = 5;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Location = new System.Drawing.Point(332, 296);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(246, 22);
            this.txtFilterBy.TabIndex = 6;
            this.txtFilterBy.Visible = false;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // cbIsReleased
            // 
            this.cbIsReleased.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsReleased.FormattingEnabled = true;
            this.cbIsReleased.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsReleased.Location = new System.Drawing.Point(332, 294);
            this.cbIsReleased.Name = "cbIsReleased";
            this.cbIsReleased.Size = new System.Drawing.Size(126, 24);
            this.cbIsReleased.TabIndex = 7;
            this.cbIsReleased.Visible = false;
            this.cbIsReleased.SelectedIndexChanged += new System.EventHandler(this.cbIsReleased_SelectedIndexChanged);
            // 
            // dgvAllDetainedLicenses
            // 
            this.dgvAllDetainedLicenses.AllowUserToAddRows = false;
            this.dgvAllDetainedLicenses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllDetainedLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllDetainedLicenses.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllDetainedLicenses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllDetainedLicenses.Location = new System.Drawing.Point(9, 340);
            this.dgvAllDetainedLicenses.Name = "dgvAllDetainedLicenses";
            this.dgvAllDetainedLicenses.RowHeadersVisible = false;
            this.dgvAllDetainedLicenses.RowHeadersWidth = 51;
            this.dgvAllDetainedLicenses.RowTemplate.Height = 24;
            this.dgvAllDetainedLicenses.Size = new System.Drawing.Size(1298, 358);
            this.dgvAllDetainedLicenses.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailToolStripMenuItem,
            this.showLicenseDetailToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.releaseDetainLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(281, 162);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonDetailToolStripMenuItem
            // 
            this.showPersonDetailToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.PersonDetails_32;
            this.showPersonDetailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonDetailToolStripMenuItem.Name = "showPersonDetailToolStripMenuItem";
            this.showPersonDetailToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showPersonDetailToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailToolStripMenuItem_Click);
            // 
            // showLicenseDetailToolStripMenuItem
            // 
            this.showLicenseDetailToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.License_View_32;
            this.showLicenseDetailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseDetailToolStripMenuItem.Name = "showLicenseDetailToolStripMenuItem";
            this.showLicenseDetailToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showLicenseDetailToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.PersonLicenseHistory_321;
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(277, 6);
            // 
            // releaseDetainLicenseToolStripMenuItem
            // 
            this.releaseDetainLicenseToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.Release_Detained_License_32;
            this.releaseDetainLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainLicenseToolStripMenuItem.Name = "releaseDetainLicenseToolStripMenuItem";
            this.releaseDetainLicenseToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.releaseDetainLicenseToolStripMenuItem.Text = "Release Detain License";
            this.releaseDetainLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainLicenseToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 719);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "#Records:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblRecordsCount.ForeColor = System.Drawing.Color.Black;
            this.lblRecordsCount.Location = new System.Drawing.Point(121, 719);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(42, 27);
            this.lblRecordsCount.TabIndex = 10;
            this.lblRecordsCount.Text = "???";
            this.lblRecordsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1158, 711);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(149, 45);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmListDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1316, 775);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAllDetainedLicenses);
            this.Controls.Add(this.cbIsReleased);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReleaseLicense);
            this.Controls.Add(this.btnDetainLicense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListDetainedLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmListDetainedLicenses";
            this.Load += new System.EventHandler(this.frmListDetainedLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllDetainedLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDetainLicense;
        private System.Windows.Forms.Button btnReleaseLicense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.ComboBox cbIsReleased;
        private System.Windows.Forms.DataGridView dgvAllDetainedLicenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainLicenseToolStripMenuItem;
    }
}