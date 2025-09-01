namespace FirstProjectDVLD.Tests
{
    partial class frmScheduleTest
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
            this.scheduleTestControl1 = new FirstProjectDVLD.Tests.Controls.ScheduleTestControl();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scheduleTestControl1
            // 
            this.scheduleTestControl1.BackColor = System.Drawing.Color.White;
            this.scheduleTestControl1.Location = new System.Drawing.Point(8, 3);
            this.scheduleTestControl1.Name = "scheduleTestControl1";
            this.scheduleTestControl1.Size = new System.Drawing.Size(533, 763);
            this.scheduleTestControl1.TabIndex = 0;
            this.scheduleTestControl1.TestTypeID = DVLD_Buisness.TestType.enTestType.Vision;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(191, 772);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 42);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmScheduleTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 826);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.scheduleTestControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmScheduleTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmScheduleTest";
            this.Load += new System.EventHandler(this.frmScheduleTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ScheduleTestControl scheduleTestControl1;
        private System.Windows.Forms.Button btnClose;
    }
}