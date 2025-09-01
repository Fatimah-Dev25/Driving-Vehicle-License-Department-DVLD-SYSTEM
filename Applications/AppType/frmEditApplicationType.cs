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

namespace FirstProjectDVLD.Applications.ApplicationType
{
    public partial class frmEditApplicationType : Form
    {
        int _APPID = -1;
        clsApplicationType _AppType;
        public frmEditApplicationType(int appID)
        {
            InitializeComponent();
            _APPID = appID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            lblAppID.Text = _APPID.ToString();

            _AppType = clsApplicationType.Find(_APPID);

            if(_AppType != null)
            {
                txtAppTitle.Text = _AppType.AppTitleType.ToString();
                txtAppFees.Text = _AppType.AppTypeFee.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not Validate...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _AppType.AppTitleType = txtAppTitle.Text.Trim();
            _AppType.AppTypeFee = Convert.ToSingle(txtAppFees.Text.Trim());

            if (_AppType.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data is not Saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtAppTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAppTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAppTitle, "Title Cannot be empty!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAppTitle, null);
            }
        }

        private void txtAppFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAppFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAppFees, "Fees cannot be empty!!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtAppFees, null);
            }

            if (!Validation.isNumber(txtAppFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAppFees, "Invalid Number!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAppFees, null);
            }
        }
    }
}
