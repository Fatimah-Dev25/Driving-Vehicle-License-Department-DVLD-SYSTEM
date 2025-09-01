namespace FirstProjectDVLD.licenses
{
    partial class frmShowPersonLicenseHistory
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlDriverLicense1 = new FirstProjectDVLD.licenses.Controls.ctrlDriverLicense();
            this.personCardWithFilter1 = new FirstProjectDVLD.People.Controls.PersonCardWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Beige;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1070, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "License History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstProjectDVLD.Properties.Resources.PersonLicenseHistory_512;
            this.pictureBox1.Location = new System.Drawing.Point(6, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(870, 860);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(173, 43);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlDriverLicense1
            // 
            this.ctrlDriverLicense1.BackColor = System.Drawing.Color.White;
            this.ctrlDriverLicense1.Location = new System.Drawing.Point(28, 501);
            this.ctrlDriverLicense1.Name = "ctrlDriverLicense1";
            this.ctrlDriverLicense1.Size = new System.Drawing.Size(1026, 353);
            this.ctrlDriverLicense1.TabIndex = 3;
            // 
            // personCardWithFilter1
            // 
            this.personCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.personCardWithFilter1.CausesValidation = false;
            this.personCardWithFilter1.FilterEnabled = true;
            this.personCardWithFilter1.Location = new System.Drawing.Point(213, 74);
            this.personCardWithFilter1.Name = "personCardWithFilter1";
            this.personCardWithFilter1.ShowAddPerson = true;
            this.personCardWithFilter1.Size = new System.Drawing.Size(850, 430);
            this.personCardWithFilter1.TabIndex = 1;
            this.personCardWithFilter1.onPersonSelected += new System.Action<int>(this.personCardWithFilter1_onPersonSelected);
            this.personCardWithFilter1.Load += new System.EventHandler(this.personCardWithFilter1_Load);
            // 
            // frmShowPersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 918);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlDriverLicense1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.personCardWithFilter1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowPersonLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmShowPersonLicenseHistory";
            this.Load += new System.EventHandler(this.frmShowPersonLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private People.Controls.PersonCardWithFilter personCardWithFilter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.ctrlDriverLicense ctrlDriverLicense1;
        private System.Windows.Forms.Button btnClose;
    }
}