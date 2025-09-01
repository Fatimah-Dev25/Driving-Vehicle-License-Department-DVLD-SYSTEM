namespace FirstProjectDVLD.Applications.LocalDrivingLicenses
{
    partial class frmAddUpdateLocalDrivingLicenseApplication
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tpApplicationInfo = new System.Windows.Forms.TabPage();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.lblAppUser = new System.Windows.Forms.Label();
            this.lblAppFees = new System.Windows.Forms.Label();
            this.cbAppLicenseClass = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDLAppID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.personCardWithFilter1 = new FirstProjectDVLD.People.Controls.PersonCardWithFilter();
            this.tabControl1.SuspendLayout();
            this.tpPersonInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.BackColor = System.Drawing.Color.Lavender;
            this.lblFormTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.Location = new System.Drawing.Point(-3, -1);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(889, 100);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "label1";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPersonInfo);
            this.tabControl1.Controls.Add(this.tpApplicationInfo);
            this.tabControl1.Location = new System.Drawing.Point(4, 121);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(875, 549);
            this.tabControl1.TabIndex = 1;
            // 
            // tpPersonInfo
            // 
            this.tpPersonInfo.Controls.Add(this.btnNext);
            this.tpPersonInfo.Controls.Add(this.panel1);
            this.tpPersonInfo.Location = new System.Drawing.Point(4, 25);
            this.tpPersonInfo.Name = "tpPersonInfo";
            this.tpPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonInfo.Size = new System.Drawing.Size(867, 520);
            this.tpPersonInfo.TabIndex = 0;
            this.tpPersonInfo.Text = "Personal Info";
            this.tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnNext.Image = global::FirstProjectDVLD.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(675, 461);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(172, 42);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.personCardWithFilter1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 443);
            this.panel1.TabIndex = 0;
            // 
            // tpApplicationInfo
            // 
            this.tpApplicationInfo.Controls.Add(this.lblAppDate);
            this.tpApplicationInfo.Controls.Add(this.lblAppUser);
            this.tpApplicationInfo.Controls.Add(this.lblAppFees);
            this.tpApplicationInfo.Controls.Add(this.cbAppLicenseClass);
            this.tpApplicationInfo.Controls.Add(this.pictureBox5);
            this.tpApplicationInfo.Controls.Add(this.pictureBox4);
            this.tpApplicationInfo.Controls.Add(this.pictureBox3);
            this.tpApplicationInfo.Controls.Add(this.pictureBox2);
            this.tpApplicationInfo.Controls.Add(this.pictureBox1);
            this.tpApplicationInfo.Controls.Add(this.lblDLAppID);
            this.tpApplicationInfo.Controls.Add(this.label5);
            this.tpApplicationInfo.Controls.Add(this.label4);
            this.tpApplicationInfo.Controls.Add(this.label3);
            this.tpApplicationInfo.Controls.Add(this.label2);
            this.tpApplicationInfo.Controls.Add(this.label1);
            this.tpApplicationInfo.Location = new System.Drawing.Point(4, 25);
            this.tpApplicationInfo.Name = "tpApplicationInfo";
            this.tpApplicationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpApplicationInfo.Size = new System.Drawing.Size(867, 520);
            this.tpApplicationInfo.TabIndex = 1;
            this.tpApplicationInfo.Text = "Application Info";
            this.tpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Calibri", 12.4F, System.Drawing.FontStyle.Bold);
            this.lblAppDate.Location = new System.Drawing.Point(281, 133);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(124, 26);
            this.lblAppDate.TabIndex = 15;
            this.lblAppDate.Text = "[??/??/????]";
            // 
            // lblAppUser
            // 
            this.lblAppUser.AutoSize = true;
            this.lblAppUser.Font = new System.Drawing.Font("Calibri", 12.4F, System.Drawing.FontStyle.Bold);
            this.lblAppUser.Location = new System.Drawing.Point(281, 339);
            this.lblAppUser.Name = "lblAppUser";
            this.lblAppUser.Size = new System.Drawing.Size(76, 26);
            this.lblAppUser.TabIndex = 14;
            this.lblAppUser.Text = "[?????]";
            // 
            // lblAppFees
            // 
            this.lblAppFees.AutoSize = true;
            this.lblAppFees.Font = new System.Drawing.Font("Calibri", 12.4F, System.Drawing.FontStyle.Bold);
            this.lblAppFees.Location = new System.Drawing.Point(281, 269);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(59, 26);
            this.lblAppFees.TabIndex = 13;
            this.lblAppFees.Text = "[$$$]";
            // 
            // cbAppLicenseClass
            // 
            this.cbAppLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppLicenseClass.FormattingEnabled = true;
            this.cbAppLicenseClass.Location = new System.Drawing.Point(281, 201);
            this.cbAppLicenseClass.Name = "cbAppLicenseClass";
            this.cbAppLicenseClass.Size = new System.Drawing.Size(384, 24);
            this.cbAppLicenseClass.TabIndex = 12;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FirstProjectDVLD.Properties.Resources.User_32__2;
            this.pictureBox5.Location = new System.Drawing.Point(222, 337);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 28);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FirstProjectDVLD.Properties.Resources.money_32;
            this.pictureBox4.Location = new System.Drawing.Point(222, 267);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FirstProjectDVLD.Properties.Resources.license3;
            this.pictureBox3.Location = new System.Drawing.Point(222, 199);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FirstProjectDVLD.Properties.Resources.Calendar_32;
            this.pictureBox2.Location = new System.Drawing.Point(222, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstProjectDVLD.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(222, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblDLAppID
            // 
            this.lblDLAppID.AutoSize = true;
            this.lblDLAppID.Font = new System.Drawing.Font("Calibri", 12.4F, System.Drawing.FontStyle.Bold);
            this.lblDLAppID.Location = new System.Drawing.Point(281, 65);
            this.lblDLAppID.Name = "lblDLAppID";
            this.lblDLAppID.Size = new System.Drawing.Size(56, 26);
            this.lblDLAppID.TabIndex = 5;
            this.lblDLAppID.Text = "[???]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12.4F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(34, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Created By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12.4F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(34, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Application Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12.4F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(34, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "License Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.4F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Application Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.4F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.L. Application ID:";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnSave.Image = global::FirstProjectDVLD.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(683, 678);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(172, 50);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(496, 678);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(172, 50);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // personCardWithFilter1
            // 
            this.personCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.personCardWithFilter1.FilterEnabled = true;
            this.personCardWithFilter1.Location = new System.Drawing.Point(3, 5);
            this.personCardWithFilter1.Name = "personCardWithFilter1";
            this.personCardWithFilter1.ShowAddPerson = true;
            this.personCardWithFilter1.Size = new System.Drawing.Size(850, 430);
            this.personCardWithFilter1.TabIndex = 0;
            this.personCardWithFilter1.onPersonSelected += new System.Action<int>(this.personCardWithFilter1_onPersonSelected);
            // 
            // frmAddUpdateLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(884, 749);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddUpdateLocalDrivingLicenseApplication";
            this.Activated += new System.EventHandler(this.frmAddUpdateLocalDrivingLicenseApplication_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdateLocalDrivingLicenseApplication_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpPersonInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tpApplicationInfo.ResumeLayout(false);
            this.tpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPersonInfo;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private People.Controls.PersonCardWithFilter personCardWithFilter1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDLAppID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAppUser;
        private System.Windows.Forms.Label lblAppFees;
        private System.Windows.Forms.ComboBox cbAppLicenseClass;
        private System.Windows.Forms.Label lblAppDate;
    }
}