using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using License = DVLD_Buisness.License;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.licenses.LocalLicenses.Controls
{
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        public event Action<int> OnLicenseSelected;
        protected virtual void LicenseSelected(int licenseId)
        {
            Action<int> handler = OnLicenseSelected;
            if(handler != null)
            {
                handler(licenseId);
            }
        } 
        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        public bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }
            set
            {
                _FilterEnabled = value;
                gbFilter.Enabled = _FilterEnabled;
            }
        }

        int _LicenseId = -1;

        public int LicenseId
        {
            get { return ctrDriverLicenseInfo1.LicenseID; }
        }

        public License SelectedLicenseInfo
        {
            get { return ctrDriverLicenseInfo1.SelectedLicenseInfo; }
        }
        private void txtLicenseFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if(e.KeyChar == (char)13)
                btnFind.PerformClick();
        }

        public void txtLicenseIDFocus()
        {
            txtLicenseFilter.Focus();
        }

       public void LoadInfo(int LicenseID)
        {
            txtLicenseFilter.Text = LicenseID.ToString();
            ctrDriverLicenseInfo1.LoadLicenseInfo(LicenseID);
            _LicenseId = ctrDriverLicenseInfo1.LicenseID;

            if (OnLicenseSelected != null && FilterEnabled)
                OnLicenseSelected(_LicenseId);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicenseFilter.Focus();
                return;
            }

            _LicenseId = int.Parse(txtLicenseFilter.Text);
            LoadInfo(_LicenseId);
        }

        private void txtLicenseFilter_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtLicenseFilter.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLicenseFilter, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLicenseFilter, null);
            }
        }
    }
}
