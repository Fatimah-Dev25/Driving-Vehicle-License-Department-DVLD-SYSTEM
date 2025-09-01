using DVLD_Buisness;
using FirstProjectDVLD.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.licenses.LocalLicenses
{
    public partial class frmIssueDriverLicenseFirstTime : Form
    {
        private int _LocalDLAppID = -1;
        private LocalDrivingLicenseApplication _LocalDLApplication;
        public frmIssueDriverLicenseFirstTime(int localAppId)
        {
            _LocalDLAppID = localAppId;
            InitializeComponent();
        }

        private void frmIssueDriverLicenseFirstTime_Load(object sender, EventArgs e)
        { 
            txtNotes.Focus();
            _LocalDLApplication = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDLAppID);

            if (_LocalDLApplication == null)
            {
                MessageBox.Show("Error: No Application with ID = " + _LocalDLAppID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (!_LocalDLApplication.PassedAllTests())
            {
                MessageBox.Show("Person should pass all tests first..", "Not allowed", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            int LicenseID = _LocalDLApplication.GetActiveLicenseID();

            if(LicenseID != -1)
            {
                MessageBox.Show("Person ahready has license before with ID = " + LicenseID, "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlLocalLicenseAppInfo1.LoadApplicationInfoByLocalLicenseAppID(_LocalDLAppID);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIssueLicense_Click(object sender, EventArgs e)
        {
            int LicenseID = _LocalDLApplication.IssueLicenseForTheFirtTime(txtNotes.Text.Trim(), Global.CurrentUser.UserID);

            if(LicenseID != -1)
            {
                MessageBox.Show("License Issued Successfully with License ID = " + LicenseID, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;

            }
            else
            {
                MessageBox.Show("License was not issued !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
