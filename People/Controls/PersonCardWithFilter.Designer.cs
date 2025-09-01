namespace FirstProjectDVLD.People.Controls
{
    partial class PersonCardWithFilter
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
            this.gbFilterPerson = new System.Windows.Forms.GroupBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.cbPersonFilter = new System.Windows.Forms.ComboBox();
            this.txtPersonFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCard = new FirstProjectDVLD.People.Controls.PersonCard();
            this.gbFilterPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilterPerson
            // 
            this.gbFilterPerson.BackColor = System.Drawing.Color.White;
            this.gbFilterPerson.Controls.Add(this.btnAddPerson);
            this.gbFilterPerson.Controls.Add(this.btnFindPerson);
            this.gbFilterPerson.Controls.Add(this.cbPersonFilter);
            this.gbFilterPerson.Controls.Add(this.txtPersonFilter);
            this.gbFilterPerson.Controls.Add(this.label1);
            this.gbFilterPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gbFilterPerson.Location = new System.Drawing.Point(8, 9);
            this.gbFilterPerson.Name = "gbFilterPerson";
            this.gbFilterPerson.Size = new System.Drawing.Size(834, 79);
            this.gbFilterPerson.TabIndex = 8;
            this.gbFilterPerson.TabStop = false;
            this.gbFilterPerson.Text = "Filter";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.CausesValidation = false;
            this.btnAddPerson.FlatAppearance.BorderSize = 0;
            this.btnAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPerson.Image = global::FirstProjectDVLD.Properties.Resources.AddPerson_32;
            this.btnAddPerson.Location = new System.Drawing.Point(621, 15);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(47, 53);
            this.btnAddPerson.TabIndex = 6;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.FlatAppearance.BorderSize = 0;
            this.btnFindPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPerson.Image = global::FirstProjectDVLD.Properties.Resources.SearchPerson;
            this.btnFindPerson.Location = new System.Drawing.Point(568, 15);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(47, 53);
            this.btnFindPerson.TabIndex = 5;
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // cbPersonFilter
            // 
            this.cbPersonFilter.BackColor = System.Drawing.SystemColors.Window;
            this.cbPersonFilter.CausesValidation = false;
            this.cbPersonFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersonFilter.FormattingEnabled = true;
            this.cbPersonFilter.Items.AddRange(new object[] {
            "National No.",
            "Person ID"});
            this.cbPersonFilter.Location = new System.Drawing.Point(114, 31);
            this.cbPersonFilter.Name = "cbPersonFilter";
            this.cbPersonFilter.Size = new System.Drawing.Size(210, 26);
            this.cbPersonFilter.TabIndex = 2;
            this.cbPersonFilter.SelectedIndexChanged += new System.EventHandler(this.cbPersonFilter_SelectedIndexChanged);
            // 
            // txtPersonFilter
            // 
            this.txtPersonFilter.Location = new System.Drawing.Point(330, 32);
            this.txtPersonFilter.Name = "txtPersonFilter";
            this.txtPersonFilter.Size = new System.Drawing.Size(219, 24);
            this.txtPersonFilter.TabIndex = 1;
            this.txtPersonFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonFilter_KeyPress);
            this.txtPersonFilter.Validating += new System.ComponentModel.CancelEventHandler(this.txtPersonFilter_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCard
            // 
            this.ctrlPersonCard.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard.Location = new System.Drawing.Point(8, 89);
            this.ctrlPersonCard.Name = "ctrlPersonCard";
            this.ctrlPersonCard.Size = new System.Drawing.Size(842, 341);
            this.ctrlPersonCard.TabIndex = 9;
            // 
            // PersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.Controls.Add(this.ctrlPersonCard);
            this.Controls.Add(this.gbFilterPerson);
            this.Name = "PersonCardWithFilter";
            this.Size = new System.Drawing.Size(850, 430);
            this.Load += new System.EventHandler(this.PersonCardWithFilter_Load);
            this.gbFilterPerson.ResumeLayout(false);
            this.gbFilterPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilterPerson;
        private System.Windows.Forms.ComboBox cbPersonFilter;
        private System.Windows.Forms.TextBox txtPersonFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private PersonCard ctrlPersonCard;
    }
}
