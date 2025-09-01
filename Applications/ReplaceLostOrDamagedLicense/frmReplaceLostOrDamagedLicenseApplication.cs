using DVLD_Buisness;
using FirstProjectDVLD.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using License = DVLD_Buisness.License;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstProjectDVLD.licenses.LocalLicenses;
using FirstProjectDVLD.licenses;

namespace FirstProjectDVLD.Applications.ReplaceLostOrDamagedLicense
{
    public partial class frmReplaceLostOrDamagedLicenseApplication : Form
    {
        int _newLicenseID = -1;
        public frmReplaceLostOrDamagedLicenseApplication()
        {
            InitializeComponent();
        }
        private int _GetApplicationTypeID()
        {
            if (rbDamagedLicense.Checked)
                return (int)BuisnessApplication.enApplicationType.ReplaceDamagedDrivingLicense;
            else
                return (int)BuisnessApplication.enApplicationType.ReplaceLostDrivingLicense;
        }
        private License.enIssueReason _GetIssueReason()
        {
            if (rbDamagedLicense.Checked)
                return License.enIssueReason.DamagedReplacement;
            else
                return License.enIssueReason.LostReplacement;
        }
        private void frmReplaceLostOrDamagedLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();

            lblReplaceAppDate.Text = Format.DateToShort(DateTime.Now);
            lblCreatedBy.Text = Global.CurrentUser.UserName;

            rbDamagedLicense.Checked = true;
        }

        private void frmReplaceLostOrDamagedLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }

        private void ctrlDriverLicenseInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {

            int SelectedLicenseId = obj;
            lblOldLicID.Text = SelectedLicenseId.ToString();
            llShowLicenseHistory.Enabled = SelectedLicenseId != -1;

            if (SelectedLicenseId == -1)
            {
                return;
            }

            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show($"Selected License is not active, choose an active License.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnReplace.Enabled = false;
                return;
            }
         
            btnReplace.Enabled = true;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Issue a Replacement for the License?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            License newLicense= ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Replace(_GetIssueReason(), 
                Global.CurrentUser.UserID);

            if(newLicense == null)
            {
                MessageBox.Show("Faild to Issue a replacemnet for this  License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblReplaceAppID.Text = newLicense.ApplicationID.ToString();
            lblReplaceID.Text = newLicense.LicenseID.ToString();
            _newLicenseID = newLicense.LicenseID;
            MessageBox.Show("Licensed Replaced Successfully with ID=" + _newLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            llShowNewLicenseInfo.Enabled = true;
            btnReplace.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            gbRplacementReason.Enabled = false;
        }

        private void lblExpirationDate_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmShowLicenseInfo frm = new frmShowLicenseInfo(_newLicenseID);
            frm.ShowDialog();
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement For Damaged License";
            this.Text = lblTitle.Text;
            lblReplaceAppFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).AppTypeFee.ToString();
        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Replacement For Lost License";
            this.Text = lblTitle.Text;
            lblReplaceAppFees.Text = clsApplicationType.Find(_GetApplicationTypeID()).AppTypeFee.ToString();
        }

        private void llShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }
    }
}
