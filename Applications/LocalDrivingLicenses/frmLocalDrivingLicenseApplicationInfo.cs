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
    public partial class frmLocalDrivingLicenseApplicationInfo : Form
    {
        private int _LocalDLAppID = -1;
        public frmLocalDrivingLicenseApplicationInfo(int LocalDLAppId)
        {
            InitializeComponent();
            _LocalDLAppID = LocalDLAppId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e)
        {
            ctrlLocalLicenseAppInfo1.LoadApplicationInfoByLocalLicenseAppID(_LocalDLAppID);
        }
    }
}
