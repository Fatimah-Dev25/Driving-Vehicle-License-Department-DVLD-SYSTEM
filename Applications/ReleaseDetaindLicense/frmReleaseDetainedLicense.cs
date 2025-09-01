using DVLD_Buisness;
using FirstProjectDVLD.GlobalClasses;
using FirstProjectDVLD.licenses;
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

namespace FirstProjectDVLD.Applications.ReleaseDetaindLicense
{
    public partial class frmReleaseDetainedLicense : Form
    {
        int _SelectedLicenseID = -1;
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }
        public frmReleaseDetainedLicense(int licenseID)
        {
            InitializeComponent();
            _SelectedLicenseID = licenseID;

            ctrlDriverLicenseInfoWithFilter1.LoadInfo(licenseID);
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }
        private void ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected(int obj)
        {
            _SelectedLicenseID = obj;

            llshowLicHistory.Enabled = _SelectedLicenseID != -1;

            if(_SelectedLicenseID == -1)
            {
                return;
            }

            lblLicID.Text = _SelectedLicenseID.ToString();

            if (!ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.isDetained())
            {
                MessageBox.Show("This License isn't detained, choose another one.", "Not Detain",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDetainId.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainInfo.DetainedID.ToString();
            lbldetainDate.Text = Format.DateToShort(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainInfo.DetainedDate);
            lblcreatedUser.Text = Global.CurrentUser.UserName;
            lblAppFees.Text = clsApplicationType.Find((int)BuisnessApplication.enApplicationType.ReleaseDetainedDrivingLicsense).AppTypeFee.ToString();
            lblFineFees.Text = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DetainInfo.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToSingle(lblFineFees.Text) + Convert.ToSingle(lblAppFees.Text)).ToString();

            btnRelease.Enabled = true;
        }

        private void llshowLicHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are you sure want to release this license?","Confirm", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            int appID = -1;
            bool IsReleased = ctrlDriverLicenseInfoWithFilter1.SelectedLicenseInfo.ReleaseDetainedLicense(Global.CurrentUser.UserID, ref appID);

            lblApplicationID.Text = appID.ToString();

            if (!IsReleased)
            {
                MessageBox.Show("Faild to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
    
            MessageBox.Show("Detained License released Successfully ", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRelease.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            llshowLicInfo.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llshowLicInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_SelectedLicenseID);
            frm.ShowDialog();
        }
    }
}
