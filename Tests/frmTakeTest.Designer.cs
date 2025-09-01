namespace FirstProjectDVLD
{
    partial class frmTakeTest
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbPassed = new System.Windows.Forms.RadioButton();
            this.rbFailed = new System.Windows.Forms.RadioButton();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.scheduledTestControl1 = new FirstProjectDVLD.Tests.Controls.ScheduledTestControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 653);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Notes:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FirstProjectDVLD.Properties.Resources.Notes_32;
            this.pictureBox2.Location = new System.Drawing.Point(102, 653);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstProjectDVLD.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(104, 610);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rbPassed
            // 
            this.rbPassed.AutoSize = true;
            this.rbPassed.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPassed.Location = new System.Drawing.Point(153, 614);
            this.rbPassed.Name = "rbPassed";
            this.rbPassed.Size = new System.Drawing.Size(64, 26);
            this.rbPassed.TabIndex = 5;
            this.rbPassed.Text = "Pass";
            this.rbPassed.UseVisualStyleBackColor = true;
            // 
            // rbFailed
            // 
            this.rbFailed.AutoSize = true;
            this.rbFailed.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFailed.Location = new System.Drawing.Point(222, 614);
            this.rbFailed.Name = "rbFailed";
            this.rbFailed.Size = new System.Drawing.Size(56, 26);
            this.rbFailed.TabIndex = 6;
            this.rbFailed.Text = "Fail";
            this.rbFailed.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(153, 653);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(424, 88);
            this.txtNotes.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnSave.Image = global::FirstProjectDVLD.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(410, 762);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 39);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(249, 762);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 39);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(287, 610);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(291, 33);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "You cannot change the Results";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessage.Visible = false;
            // 
            // scheduledTestControl1
            // 
            this.scheduledTestControl1.BackColor = System.Drawing.Color.White;
            this.scheduledTestControl1.Location = new System.Drawing.Point(3, 7);
            this.scheduledTestControl1.Name = "scheduledTestControl1";
            this.scheduledTestControl1.Size = new System.Drawing.Size(583, 594);
            this.scheduledTestControl1.TabIndex = 0;
            this.scheduledTestControl1.TestTypeID = DVLD_Buisness.TestType.enTestType.Vision;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(589, 821);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.rbFailed);
            this.Controls.Add(this.rbPassed);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scheduledTestControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTakeTest";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tests.Controls.ScheduledTestControl scheduledTestControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rbPassed;
        private System.Windows.Forms.RadioButton rbFailed;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMessage;
    }
}