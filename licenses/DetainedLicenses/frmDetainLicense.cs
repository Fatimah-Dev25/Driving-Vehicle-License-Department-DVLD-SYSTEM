using DVLD_Buisness;
using FirstProjectDVLD.GlobalClasses;
using FirstProjectDVLD.licenses.LocalLicenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.licenses.DetainedLicenses
{
    public partial class frmDetainLicense : Form
    {

        private int _DetainedID;
        private int _SelectedLicenseID = -1;
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
            lblDetainDate.Text = Format.DateToShort(DateTime.Now);
            lblUserID.Text = Global.CurrentUser.UserName;
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineFees.Text.Trim()))
            {
                errorProvider1.SetError(txtFineFees, "Fees cannot be empty!");
                e.Cancel = true;
                return;
            }else
            {
                errorProvider1.SetError(txtFineFees, null);
                e.Cancel = false;
            }

          
        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;

            lblLicenseID.Text = _SelectedLicenseID.ToString();
            llShowLicenseHistory.Enabled = _SelectedLicenseID != -1;

            if (_SelectedLicenseID == -1)
                return;

            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show("Selected license is not activated.", "Not Allowed",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.isDetained())
            {
                MessageBox.Show("Selected License is already detained, choose another one.", "Not Allowed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtFineFees.Focus();
            btnDetain.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Are you sure want to detain this license?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                DialogResult.Cancel)
                return;

            _DetainedID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Detain(Convert.ToSingle(txtFineFees.Text.Trim()), Global.CurrentUser.UserID);

            if(_DetainedID == -1)
            {
                MessageBox.Show("Failed to Detain License.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }         
            
            lblDetainID.Text = _DetainedID.ToString();
            MessageBox.Show("License Detained Successfully with ID = " + _DetainedID, "License Detained" , MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnDetain.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.Enabled = false;
            txtFineFees.Enabled = false;
            llShowLicenseInfo.Enabled = true;
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmDetainLicense_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }

        private void llShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }

        private void txtFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
    }
}
