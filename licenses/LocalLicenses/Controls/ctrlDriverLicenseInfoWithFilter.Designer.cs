namespace FirstProjectDVLD.licenses.LocalLicenses.Controls
{
    partial class ctrlDriverLicenseInfoWithFilter
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtLicenseFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrDriverLicenseInfo1 = new FirstProjectDVLD.licenses.LocalLicenses.Controls.ctrDriverLicenseInfo();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.txtLicenseFilter);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.gbFilter.Location = new System.Drawing.Point(7, 16);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(580, 91);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = global::FirstProjectDVLD.Properties.Resources.id_search;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnFind.Location = new System.Drawing.Point(451, 29);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(63, 44);
            this.btnFind.TabIndex = 1;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtLicenseFilter
            // 
            this.txtLicenseFilter.Location = new System.Drawing.Point(135, 38);
            this.txtLicenseFilter.Name = "txtLicenseFilter";
            this.txtLicenseFilter.Size = new System.Drawing.Size(304, 28);
            this.txtLicenseFilter.TabIndex = 1;
            this.txtLicenseFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicenseFilter_KeyPress);
            this.txtLicenseFilter.Validating += new System.ComponentModel.CancelEventHandler(this.txtLicenseFilter_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LicenseID:";
            // 
            // ctrDriverLicenseInfo1
            // 
            this.ctrDriverLicenseInfo1.BackColor = System.Drawing.Color.White;
            this.ctrDriverLicenseInfo1.Location = new System.Drawing.Point(1, 109);
            this.ctrDriverLicenseInfo1.Name = "ctrDriverLicenseInfo1";
            this.ctrDriverLicenseInfo1.Size = new System.Drawing.Size(908, 382);
            this.ctrDriverLicenseInfo1.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlDriverLicenseInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrDriverLicenseInfo1);
            this.Controls.Add(this.gbFilter);
            this.Name = "ctrlDriverLicenseInfoWithFilter";
            this.Size = new System.Drawing.Size(917, 496);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.TextBox txtLicenseFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private ctrDriverLicenseInfo ctrDriverLicenseInfo1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
