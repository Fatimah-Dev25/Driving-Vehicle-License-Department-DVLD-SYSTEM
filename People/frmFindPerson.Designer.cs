namespace FirstProjectDVLD.People
{
    partial class frmFindPerson
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
            this.crtlPersonCardWithFilter = new FirstProjectDVLD.People.Controls.PersonCardWithFilter();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(850, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find Person";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crtlPersonCardWithFilter
            // 
            this.crtlPersonCardWithFilter.BackColor = System.Drawing.Color.White;
            this.crtlPersonCardWithFilter.CausesValidation = false;
            this.crtlPersonCardWithFilter.FilterEnabled = true;
            this.crtlPersonCardWithFilter.Location = new System.Drawing.Point(4, 76);
            this.crtlPersonCardWithFilter.Name = "crtlPersonCardWithFilter";
            this.crtlPersonCardWithFilter.ShowAddPerson = true;
            this.crtlPersonCardWithFilter.Size = new System.Drawing.Size(846, 441);
            this.crtlPersonCardWithFilter.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(683, 514);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(159, 47);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 583);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.crtlPersonCardWithFilter);
            this.Controls.Add(this.label1);
            this.Name = "frmFindPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FindPerson";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.PersonCardWithFilter crtlPersonCardWithFilter;
        private System.Windows.Forms.Button btnClose;
    }
}