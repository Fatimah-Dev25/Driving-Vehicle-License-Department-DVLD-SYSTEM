namespace FirstProjectDVLD.licenses.Controls
{
    partial class ctrlDriverLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcDriverLicenses = new System.Windows.Forms.TabControl();
            this.tpLocalLicenses = new System.Windows.Forms.TabPage();
            this.dgvLocalLicenses = new System.Windows.Forms.DataGridView();
            this.localLicensesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpInternationalLicenses = new System.Windows.Forms.TabPage();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.internationalLicensesMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInternationaRecordsCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tcDriverLicenses.SuspendLayout();
            this.tpLocalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).BeginInit();
            this.localLicensesMenu.SuspendLayout();
            this.tpInternationalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.internationalLicensesMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tcDriverLicenses);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1017, 341);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // tcDriverLicenses
            // 
            this.tcDriverLicenses.Controls.Add(this.tpLocalLicenses);
            this.tcDriverLicenses.Controls.Add(this.tpInternationalLicenses);
            this.tcDriverLicenses.Location = new System.Drawing.Point(6, 25);
            this.tcDriverLicenses.Name = "tcDriverLicenses";
            this.tcDriverLicenses.SelectedIndex = 0;
            this.tcDriverLicenses.Size = new System.Drawing.Size(1005, 310);
            this.tcDriverLicenses.TabIndex = 0;
            // 
            // tpLocalLicenses
            // 
            this.tpLocalLicenses.Controls.Add(this.dgvLocalLicenses);
            this.tpLocalLicenses.Controls.Add(this.lblRecordsCount);
            this.tpLocalLicenses.Controls.Add(this.label2);
            this.tpLocalLicenses.Controls.Add(this.label1);
            this.tpLocalLicenses.Location = new System.Drawing.Point(4, 29);
            this.tpLocalLicenses.Name = "tpLocalLicenses";
            this.tpLocalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpLocalLicenses.Size = new System.Drawing.Size(997, 277);
            this.tpLocalLicenses.TabIndex = 0;
            this.tpLocalLicenses.Text = "Local";
            this.tpLocalLicenses.UseVisualStyleBackColor = true;
            // 
            // dgvLocalLicenses
            // 
            this.dgvLocalLicenses.AllowUserToAddRows = false;
            this.dgvLocalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenses.ContextMenuStrip = this.localLicensesMenu;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocalLicenses.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocalLicenses.Location = new System.Drawing.Point(14, 50);
            this.dgvLocalLicenses.Name = "dgvLocalLicenses";
            this.dgvLocalLicenses.RowHeadersVisible = false;
            this.dgvLocalLicenses.RowHeadersWidth = 51;
            this.dgvLocalLicenses.RowTemplate.Height = 24;
            this.dgvLocalLicenses.Size = new System.Drawing.Size(971, 177);
            this.dgvLocalLicenses.TabIndex = 3;
            // 
            // localLicensesMenu
            // 
            this.localLicensesMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.localLicensesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.localLicensesMenu.Name = "localLicensesMenu";
            this.localLicensesMenu.Size = new System.Drawing.Size(213, 42);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.License_View_32;
            this.showLicenseInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(212, 38);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(133, 241);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(43, 22);
            this.lblRecordsCount.TabIndex = 2;
            this.lblRecordsCount.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "#Records:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Local Licenses History:";
            // 
            // tpInternationalLicenses
            // 
            this.tpInternationalLicenses.Controls.Add(this.dgvInternationalLicenses);
            this.tpInternationalLicenses.Controls.Add(this.lblInternationaRecordsCount);
            this.tpInternationalLicenses.Controls.Add(this.label4);
            this.tpInternationalLicenses.Controls.Add(this.label3);
            this.tpInternationalLicenses.Location = new System.Drawing.Point(4, 29);
            this.tpInternationalLicenses.Name = "tpInternationalLicenses";
            this.tpInternationalLicenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternationalLicenses.Size = new System.Drawing.Size(997, 277);
            this.tpInternationalLicenses.TabIndex = 1;
            this.tpInternationalLicenses.Text = "International";
            this.tpInternationalLicenses.UseVisualStyleBackColor = true;
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.ContextMenuStrip = this.internationalLicensesMenu;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(15, 47);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.RowHeadersVisible = false;
            this.dgvInternationalLicenses.RowHeadersWidth = 51;
            this.dgvInternationalLicenses.RowTemplate.Height = 24;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(966, 185);
            this.dgvInternationalLicenses.TabIndex = 3;
            // 
            // internationalLicensesMenu
            // 
            this.internationalLicensesMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.internationalLicensesMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem1});
            this.internationalLicensesMenu.Name = "internationalLicensesMenu";
            this.internationalLicensesMenu.Size = new System.Drawing.Size(213, 42);
            // 
            // showLicenseInfoToolStripMenuItem1
            // 
            this.showLicenseInfoToolStripMenuItem1.Image = global::FirstProjectDVLD.Properties.Resources.License_View_32;
            this.showLicenseInfoToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseInfoToolStripMenuItem1.Name = "showLicenseInfoToolStripMenuItem1";
            this.showLicenseInfoToolStripMenuItem1.Size = new System.Drawing.Size(212, 38);
            this.showLicenseInfoToolStripMenuItem1.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem1.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem1_Click);
            // 
            // lblInternationaRecordsCount
            // 
            this.lblInternationaRecordsCount.AutoSize = true;
            this.lblInternationaRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationaRecordsCount.Location = new System.Drawing.Point(132, 241);
            this.lblInternationaRecordsCount.Name = "lblInternationaRecordsCount";
            this.lblInternationaRecordsCount.Size = new System.Drawing.Size(43, 22);
            this.lblInternationaRecordsCount.TabIndex = 2;
            this.lblInternationaRecordsCount.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "#Records:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "International Licenses History:";
            // 
            // ctrlDriverLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlDriverLicense";
            this.Size = new System.Drawing.Size(1034, 359);
            this.groupBox1.ResumeLayout(false);
            this.tcDriverLicenses.ResumeLayout(false);
            this.tpLocalLicenses.ResumeLayout(false);
            this.tpLocalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).EndInit();
            this.localLicensesMenu.ResumeLayout(false);
            this.tpInternationalLicenses.ResumeLayout(false);
            this.tpInternationalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.internationalLicensesMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tcDriverLicenses;
        private System.Windows.Forms.TabPage tpLocalLicenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpInternationalLicenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLocalLicenses;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.Label lblInternationaRecordsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip localLicensesMenu;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip internationalLicensesMenu;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem1;
    }
}
