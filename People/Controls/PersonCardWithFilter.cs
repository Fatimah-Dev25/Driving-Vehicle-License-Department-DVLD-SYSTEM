using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.People.Controls
{
    public partial class PersonCardWithFilter : UserControl
    {
        public PersonCardWithFilter()
        {
            InitializeComponent();
        }

        public event Action<int> onPersonSelected;
        protected virtual void PersonSelected(int personId)
        {
            Action<int> handler = onPersonSelected;
            if (handler != null)
            {
                handler(personId);
            }
        }

        private bool _ShowAddPerson =  true;
        private bool _FilterEnabled = true;
        public bool ShowAddPerson { 
            get { return _ShowAddPerson; } 
            set
            {
                _ShowAddPerson = value;
                btnAddPerson.Visible = _ShowAddPerson;
            }
        }
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }
            set
            {
                _FilterEnabled=value;
                gbFilterPerson.Enabled = _FilterEnabled;
            }
        }
        public int PersonID
        {
            get { return ctrlPersonCard.PersonID; }
        }
        public Person SelectedPersonInfo
        {
            get { return ctrlPersonCard.SelectedPersonInfo; } 
        }
        private void PersonCardWithFilter_Load(object sender, EventArgs e)
        {
            cbPersonFilter.SelectedIndex = 0;
            txtPersonFilter.Focus();
          
        }

        public void LoadPersonInfo(int personID)
        {
            cbPersonFilter.SelectedIndex = 1;
            txtPersonFilter.Text = personID.ToString();

            FindNow();
        }

        private void FindNow()
        {
            switch(cbPersonFilter.Text)
            {
                case "Person ID":
                    ctrlPersonCard.LoadPersonInfo(int.Parse(txtPersonFilter.Text));
                    break;

                case "National No.":
                    ctrlPersonCard.LoadPersonInfo(txtPersonFilter.Text);
                    break;

                default: break;
            }

            if (onPersonSelected != null && FilterEnabled)
                // Raise the event with a parameter
                onPersonSelected(ctrlPersonCard.PersonID);
        }

  

        private void DataBackEvent(object sender, int personID)
        {
            cbPersonFilter.SelectedIndex = 1;
            txtPersonFilter.Text = personID.ToString();
            ctrlPersonCard.LoadPersonInfo(personID);

        }

        private void txtPersonFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                btnFindPerson.PerformClick();
            }

            if(cbPersonFilter.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }

        }

        public void FilterFocus()
        {
            txtPersonFilter.Focus();
        }
        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            FindNow();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }

        private void cbPersonFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPersonFilter.Text = "";
            txtPersonFilter.Focus();
        }

        private void txtPersonFilter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPersonFilter.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPersonFilter, "this field is required!");
            }
            else
                errorProvider1.SetError(txtPersonFilter, null);
        }

    
    }
}
