using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.licenses.InternationalLicenses
{
    public partial class frmInternationalLicenseInfo : Form
    {
        int _InternationalLicenseId = -1;
        public frmInternationalLicenseInfo(int internationalLicenseId)
        {
            InitializeComponent();
            _InternationalLicenseId = internationalLicenseId;
        }

        private void frmInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDriverInternationalLicenseIndfo1.LoadLicenseInfo(_InternationalLicenseId);
        }

        private void ctrDriverLicenseInfo1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ctrlDriverInternationalLicenseIndfo1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
