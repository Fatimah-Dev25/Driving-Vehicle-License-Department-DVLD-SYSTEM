using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Buisness;
using System.Windows.Forms;
using FirstProjectDVLD.GlobalClasses;
using FirstProjectDVLD.licenses.LocalLicenses;
using FirstProjectDVLD.licenses;
using FirstProjectDVLD.licenses.InternationalLicenses;

namespace FirstProjectDVLD.Applications.InternationalLicenses
{
    public partial class frmNewInternationalLicenseApplication : Form
    {
        int _InternationalLicenseID = -1;
        public frmNewInternationalLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmNewInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            lblAppDate.Text = Format.DateToShort(DateTime.Now);
            lblIssueDate.Text = lblAppDate.Text;
            lblExpirationDate.Text = Format.DateToShort(DateTime.Now.AddYears(1));
            lblFees.Text = clsApplicationType.Find((int)BuisnessApplication.enApplicationType.NewInternationalLicense).AppTypeFee.ToString();
            lblUserID.Text = Global.CurrentUser.UserName;
        }

        private void ctrlDriverLicenseInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {

            _InternationalLicenseID = obj;
            lblLocalLicID.Text = _InternationalLicenseID.ToString();
            llShowLicHistory.Enabled = _InternationalLicenseID != -1;
            
            if (_InternationalLicenseID == -1)
                return;

            if(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassID != 3)
            {
                MessageBox.Show("Selected License Should be Class 3, select another one.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //check if person already have an active international license
            int ActiveInternaionalLicenseID = InternationalLicense.GetActiveInternationalLicenseIDByDriverID(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID);

            if (ActiveInternaionalLicenseID != -1)
            {
                MessageBox.Show("Person already have an active international license with ID = " + ActiveInternaionalLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblShowNewLicInfo.Enabled = true;
                _InternationalLicenseID = ActiveInternaionalLicenseID;
                btnIssue.Enabled = false;
                return;
            }

            btnIssue.Enabled = true;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to issue the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            InternationalLicense internationalLic = new InternationalLicense();

            internationalLic.ApplicantPersonID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID;
            internationalLic.ApplicationDate = DateTime.Now;
            internationalLic.ExpirationDate = DateTime.Now.AddYears(1);
            internationalLic.LastStatusDate = DateTime.Now;
            internationalLic.ApplicationTypeId = (int)BuisnessApplication.enApplicationType.NewInternationalLicense;
            internationalLic.ApplicationStatus = BuisnessApplication.enApplicationStatus.Completed;
            internationalLic.CreatedByUserID = Global.CurrentUser.UserID;

            internationalLic.DriverID = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverID;
            internationalLic.IssuedUsingLocalLicenseID = ctrlDriverLicenseInfoWithFilter1.LicenseId;
            internationalLic.IssueDate = DateTime.Now;

            if (!internationalLic.Save())
            {
                MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }

            lblInternationalAppID.Text = internationalLic.ApplicationID.ToString();
            _InternationalLicenseID = internationalLic.InternationalLicenseID;
            lblInternationalLicID.Text = internationalLic.InternationalLicenseID.ToString();

            MessageBox.Show("International License Issued Successfully with ID=" + internationalLic.InternationalLicenseID.ToString(), "License Issued", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssue.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            lblShowNewLicInfo.Enabled = true;
        }

        private void lblShowNewLicInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo(_InternationalLicenseID);
            frm.ShowDialog();
        }

        private void llShowLicHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
