namespace FirstProjectDVLD.People
{
    partial class frmShowPersonDetail
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
            this.ctrlPersonInfoCard = new FirstProjectDVLD.People.Controls.PersonCard();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSlateGray;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(854, 90);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show Person Detail";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(665, 463);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(172, 47);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlPersonInfoCard
            // 
            this.ctrlPersonInfoCard.BackColor = System.Drawing.Color.White;
            this.ctrlPersonInfoCard.Location = new System.Drawing.Point(8, 100);
            this.ctrlPersonInfoCard.Name = "ctrlPersonInfoCard";
            this.ctrlPersonInfoCard.Size = new System.Drawing.Size(845, 358);
            this.ctrlPersonInfoCard.TabIndex = 2;
            // 
            // frmShowPersonDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(853, 540);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlPersonInfoCard);
            this.Controls.Add(this.label1);
            this.Name = "frmShowPersonDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmShowPersonDetail";
            this.Load += new System.EventHandler(this.frmShowPersonDetail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.PersonCard ctrlPersonInfoCard;
        private System.Windows.Forms.Button btnClose;
    }
}