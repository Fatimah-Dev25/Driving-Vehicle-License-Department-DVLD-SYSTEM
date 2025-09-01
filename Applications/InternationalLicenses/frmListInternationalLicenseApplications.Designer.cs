namespace FirstProjectDVLD.Applications.InternationalLicenses
{
    partial class frmListInternationalLicenseApplications
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAllInternatiolLicenses = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddInterApplication = new System.Windows.Forms.Button();
            this.cbIsActive = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInternatiolLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstProjectDVLD.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point(2, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1234, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FirstProjectDVLD.Properties.Resources.ntrtnational;
            this.pictureBox2.Location = new System.Drawing.Point(704, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1224, 59);
            this.label2.TabIndex = 3;
            this.label2.Text = "Internationl License Applications";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "International License ID",
            "Application ID",
            "Driver ID",
            "Local License ID",
            "Is Active"});
            this.cbFilterBy.Location = new System.Drawing.Point(125, 318);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(178, 24);
            this.cbFilterBy.TabIndex = 4;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged_1);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Location = new System.Drawing.Point(309, 320);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(208, 22);
            this.txtFilterBy.TabIndex = 5;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Filter By:";
            // 
            // dgvAllInternatiolLicenses
            // 
            this.dgvAllInternatiolLicenses.AllowUserToAddRows = false;
            this.dgvAllInternatiolLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllInternatiolLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllInternatiolLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllInternatiolLicenses.Location = new System.Drawing.Point(12, 359);
            this.dgvAllInternatiolLicenses.Name = "dgvAllInternatiolLicenses";
            this.dgvAllInternatiolLicenses.RowHeadersVisible = false;
            this.dgvAllInternatiolLicenses.RowHeadersWidth = 51;
            this.dgvAllInternatiolLicenses.RowTemplate.Height = 24;
            this.dgvAllInternatiolLicenses.Size = new System.Drawing.Size(1214, 318);
            this.dgvAllInternatiolLicenses.TabIndex = 7;
            this.dgvAllInternatiolLicenses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllInternatiolLicenses_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 697);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "#Records:";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(125, 697);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(37, 24);
            this.lblRecordsCount.TabIndex = 9;
            this.lblRecordsCount.Text = "???";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1071, 688);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 44);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddInterApplication
            // 
            this.btnAddInterApplication.BackgroundImage = global::FirstProjectDVLD.Properties.Resources.New_Application_64;
            this.btnAddInterApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddInterApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInterApplication.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddInterApplication.Location = new System.Drawing.Point(1156, 266);
            this.btnAddInterApplication.Name = "btnAddInterApplication";
            this.btnAddInterApplication.Size = new System.Drawing.Size(70, 76);
            this.btnAddInterApplication.TabIndex = 11;
            this.btnAddInterApplication.UseVisualStyleBackColor = true;
            this.btnAddInterApplication.Click += new System.EventHandler(this.btnAddInterApplication_Click);
            // 
            // cbIsActive
            // 
            this.cbIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsActive.FormattingEnabled = true;
            this.cbIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbIsActive.Location = new System.Drawing.Point(309, 319);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(121, 24);
            this.cbIsActive.TabIndex = 12;
            this.cbIsActive.SelectedIndexChanged += new System.EventHandler(this.cbIsActive_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailToolStripMenuItem,
            this.showLicenseDetailToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(281, 118);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonDetailToolStripMenuItem
            // 
            this.showPersonDetailToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.PersonDetails_32;
            this.showPersonDetailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonDetailToolStripMenuItem.Name = "showPersonDetailToolStripMenuItem";
            this.showPersonDetailToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showPersonDetailToolStripMenuItem.Text = "Show Person Detail";
            this.showPersonDetailToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailToolStripMenuItem_Click);
            // 
            // showLicenseDetailToolStripMenuItem
            // 
            this.showLicenseDetailToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.License_View_32;
            this.showLicenseDetailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseDetailToolStripMenuItem.Name = "showLicenseDetailToolStripMenuItem";
            this.showLicenseDetailToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showLicenseDetailToolStripMenuItem.Text = "Show License Detail";
            this.showLicenseDetailToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.PersonLicenseHistory_321;
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(280, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click_1);
            // 
            // frmListInternationalLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1238, 742);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.btnAddInterApplication);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvAllInternatiolLicenses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListInternationalLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List International License Applications";
            this.Load += new System.EventHandler(this.frmListInternationalLicenseApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllInternatiolLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAllInternatiolLicenses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddInterApplication;
        private System.Windows.Forms.ComboBox cbIsActive;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}