namespace FirstProjectDVLD.Tests
{
    partial class frmRetakeTest
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocalAppID = new System.Windows.Forms.TextBox();
            this.cbTestType = new System.Windows.Forms.ComboBox();
            this.btnRetakeTest = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 20.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Retake Test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Local Lic.App ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Test Type:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLocalAppID
            // 
            this.txtLocalAppID.Location = new System.Drawing.Point(193, 94);
            this.txtLocalAppID.Name = "txtLocalAppID";
            this.txtLocalAppID.Size = new System.Drawing.Size(261, 22);
            this.txtLocalAppID.TabIndex = 3;
            this.txtLocalAppID.TextChanged += new System.EventHandler(this.txtLocalAppID_TextChanged);
            this.txtLocalAppID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocalAppID_KeyPress);
            this.txtLocalAppID.Validating += new System.ComponentModel.CancelEventHandler(this.txtLocalAppID_Validating);
            // 
            // cbTestType
            // 
            this.cbTestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTestType.FormattingEnabled = true;
            this.cbTestType.Location = new System.Drawing.Point(193, 136);
            this.cbTestType.Name = "cbTestType";
            this.cbTestType.Size = new System.Drawing.Size(261, 24);
            this.cbTestType.TabIndex = 4;
            this.cbTestType.SelectedIndexChanged += new System.EventHandler(this.cbTestType_SelectedIndexChanged);
            // 
            // btnRetakeTest
            // 
            this.btnRetakeTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetakeTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnRetakeTest.Image = global::FirstProjectDVLD.Properties.Resources.Retake_Test_32;
            this.btnRetakeTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetakeTest.Location = new System.Drawing.Point(304, 195);
            this.btnRetakeTest.Name = "btnRetakeTest";
            this.btnRetakeTest.Size = new System.Drawing.Size(176, 50);
            this.btnRetakeTest.TabIndex = 5;
            this.btnRetakeTest.Text = "Retake Test";
            this.btnRetakeTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRetakeTest.UseVisualStyleBackColor = true;
            this.btnRetakeTest.Click += new System.EventHandler(this.btnRetakeTest_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.btnClose.Image = global::FirstProjectDVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(147, 195);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 50);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmRetakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 268);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRetakeTest);
            this.Controls.Add(this.cbTestType);
            this.Controls.Add(this.txtLocalAppID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRetakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Retake Test";
            this.Load += new System.EventHandler(this.frmRetakeTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocalAppID;
        private System.Windows.Forms.ComboBox cbTestType;
        private System.Windows.Forms.Button btnRetakeTest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}