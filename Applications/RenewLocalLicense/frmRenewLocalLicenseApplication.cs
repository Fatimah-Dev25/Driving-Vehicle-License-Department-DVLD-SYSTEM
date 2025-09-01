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

namespace FirstProjectDVLD.Applications.RenewLocalLicense
{
    public partial class frmRenewLocalLicenseApplication : Form
    {
        private int _NewLicenseID = -1;
        public frmRenewLocalLicenseApplication()
        {
            InitializeComponent();
        }
        private void frmRenewLocalLicense_Load(object sender, EventArgs e)
        {

            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();

            lblAppDate.Text = Format.DateToShort(DateTime.Now);
            lblIssueLicenseDate.Text = lblAppDate.Text;

            lblAppFees.Text = clsApplicationType.Find((int)BuisnessApplication.enApplicationType.RenewDrivingLicense).AppTypeFee.ToString();
            lblCreatedByUser.Text = Global.CurrentUser.UserName;    

        }

        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            int SelectedLicenseID = obj;

            lblOldLicenseID.Text = SelectedLicenseID.ToString();
            llblShowLicenseHistory.Enabled = SelectedLicenseID != -1;

            if(SelectedLicenseID == -1)
            {
                return;
            }

            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsLicenseExpired())
            {
                MessageBox.Show($"Selected License is not expired yet, it will expire on : {ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ExpirationDate}",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.IsActive)
            {
                MessageBox.Show($"Selected License is not active, choose an active License.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            int DefaultValidityLength = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.DefaultValidateLength;
            lblExpirationDate.Text = Format.DateToShort(DateTime.Now.AddYears(DefaultValidityLength));
            lblLicenseFees.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.LicenseClassInfo.PaidFees.ToString(); ;
            lblTotalFees.Text = (Convert.ToSingle(lblAppFees.Text) + Convert.ToSingle(lblLicenseFees.Text)).ToString();
            txtNotes.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.Notes; 
       
            btnRenew.Enabled = true;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are you sure want to renew this License?", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            License newLicense = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.RenewLicense(txtNotes.Text.Trim(), Global.CurrentUser.UserID);

            if(newLicense == null)
            {
                MessageBox.Show("Faild to renew this License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblRenewAppID.Text = newLicense.ApplicationID.ToString();
            lblRenewLicenseID.Text = newLicense.LicenseID.ToString();
            _NewLicenseID = newLicense.LicenseID;

            btnRenew.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llblShowNewLicenseInfo.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_NewLicenseID);
            frm.ShowDialog();
        }
        private void frmRenewLocalLicenseApplication_Activated(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.txtLicenseIDFocus();
        }
        private void llblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }
    }
}
