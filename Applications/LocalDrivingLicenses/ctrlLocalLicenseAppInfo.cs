using DVLD_Buisness;
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

namespace FirstProjectDVLD.Applications.LocalDrivingLicenses
{
    public partial class ctrlLocalLicenseAppInfo : UserControl
    {
        private LocalDrivingLicenseApplication _LocalLicenseApp;
        private int _LocalDAppID;
        private int _LicenseID = -1;
        public int LocalDrivingLicenseAppID
        {
            get { return _LocalDAppID; }
        }
        public ctrlLocalLicenseAppInfo()
        {
            InitializeComponent();
        }

        private void _ResetLocalDrivingLicenseApplicationInfo()
        {
            _LocalDAppID = -1;

            lblDLAppID.Text = "[???]";
            lblLicenseClass.Text = "???";
            lblAppPassedTests.Text = "0";
            ctrlApplicationBasicInfo1.ResetApplicationInfo();
        }

        public void LoadApplicationInfoByApplicationID(int applicationId)
        {
            _LocalLicenseApp = LocalDrivingLicenseApplication.FindByApplicationID(applicationId);

            if (_LocalLicenseApp == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();
                MessageBox.Show("No Application with ID: " + _LocalDAppID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                _FillLocalDrivingLicenseApplicationInfo();
        }
        public void LoadApplicationInfoByLocalLicenseAppID(int localAppID)
        {
            _LocalLicenseApp = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(localAppID);

            if(_LocalLicenseApp == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();
                MessageBox.Show("No Application with ID: " + _LocalDAppID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillLocalDrivingLicenseApplicationInfo();
        }

        private void _FillLocalDrivingLicenseApplicationInfo()
        {
            _LocalDAppID = _LocalLicenseApp.LocalDrivingLicenseAppID;
            _LicenseID = _LocalLicenseApp.GetActiveLicenseID();

            llblShowLicense.Enabled = _LicenseID != -1;

            lblDLAppID.Text = _LocalLicenseApp.LocalDrivingLicenseAppID.ToString();
            lblLicenseClass.Text = _LocalLicenseApp.LicenseClassInfo.LicenseName;
            ctrlApplicationBasicInfo1.LoadApplicationInfo(_LocalLicenseApp.ApplicationID);

            lblAppPassedTests.Text = _LocalLicenseApp.GetPassedTestCount().ToString() +"/3" ;
        }

        private void llblShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
             frmShowLicenseInfo frm = new frmShowLicenseInfo(_LocalLicenseApp.GetActiveLicenseID());
             frm.ShowDialog();
            
        }

        private void ctrlLocalLicenseAppInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
