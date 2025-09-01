namespace FirstProjectDVLD.People
{
    partial class frmListPeople
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.dgvPeopleList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1485, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage People";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filter by:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No",
            "First Name",
            "Second Name",
            "Third Name",
            "Last Name",
            "Gender",
            "Nationality",
            "Phone",
            "Email"});
            this.cbFilterBy.Location = new System.Drawing.Point(110, 277);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(188, 24);
            this.cbFilterBy.TabIndex = 3;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // dgvPeopleList
            // 
            this.dgvPeopleList.AllowUserToAddRows = false;
            this.dgvPeopleList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeopleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeopleList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPeopleList.Location = new System.Drawing.Point(12, 349);
            this.dgvPeopleList.Name = "dgvPeopleList";
            this.dgvPeopleList.RowHeadersVisible = false;
            this.dgvPeopleList.RowHeadersWidth = 51;
            this.dgvPeopleList.RowTemplate.Height = 24;
            this.dgvPeopleList.Size = new System.Drawing.Size(1474, 402);
            this.dgvPeopleList.TabIndex = 5;
            this.dgvPeopleList.DoubleClick += new System.EventHandler(this.dgvPeopleList_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sendEmailToolStripMenuItem,
            this.callPhoneToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 208);
            // 
            // showDetailToolStripMenuItem
            // 
            this.showDetailToolStripMenuItem.AutoSize = false;
            this.showDetailToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.PersonDetails_32;
            this.showDetailToolStripMenuItem.Name = "showDetailToolStripMenuItem";
            this.showDetailToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.showDetailToolStripMenuItem.Text = "Show Detail";
            this.showDetailToolStripMenuItem.Click += new System.EventHandler(this.showDetailToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.AutoSize = false;
            this.addNewPersonToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.AddPerson_32;
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.AutoSize = false;
            this.editToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.AutoSize = false;
            this.deleteToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(207, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.AutoSize = false;
            this.sendEmailToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // callPhoneToolStripMenuItem
            // 
            this.callPhoneToolStripMenuItem.AutoSize = false;
            this.callPhoneToolStripMenuItem.Image = global::FirstProjectDVLD.Properties.Resources.call_32;
            this.callPhoneToolStripMenuItem.Name = "callPhoneToolStripMenuItem";
            this.callPhoneToolStripMenuItem.Size = new System.Drawing.Size(214, 32);
            this.callPhoneToolStripMenuItem.Text = "Call Phone";
            this.callPhoneToolStripMenuItem.Click += new System.EventHandler(this.callPhoneToolStripMenuItem_Click);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Location = new System.Drawing.Point(304, 277);
            this.txtFilterBy.Multiline = true;
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(254, 24);
            this.txtFilterBy.TabIndex = 6;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 779);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "#Records: ";
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(123, 779);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(28, 24);
            this.lblRecordsCount.TabIndex = 8;
            this.lblRecordsCount.Text = "??";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.FlatAppearance.BorderSize = 0;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPerson.Image = global::FirstProjectDVLD.Properties.Resources.Add_Person_40;
            this.btnAddPerson.Location = new System.Drawing.Point(1406, 251);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(80, 50);
            this.btnAddPerson.TabIndex = 4;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FirstProjectDVLD.Properties.Resources.People_400;
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1485, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1304, 763);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(182, 46);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmListPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1498, 835);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.dgvPeopleList);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.frmListPeople_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeopleList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.DataGridView dgvPeopleList;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callPhoneToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
    }
}