using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using DVLD_Buisness;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using License = DVLD_Buisness.License;
using FirstProjectDVLD.GlobalClasses;
using FirstProjectDVLD.Properties;
using System.IO;

namespace FirstProjectDVLD.licenses.LocalLicenses.Controls
{
    public partial class ctrDriverLicenseInfo : UserControl
    {

        private int _LicenseID = -1;
        private License _License;
        public int LicenseID { get { return _LicenseID; } }
        public License SelectedLicenseInfo { get {  return _License; } }
        public ctrDriverLicenseInfo()
        {
            InitializeComponent();
        }


        public void LoadLicenseInfo(int licenseID)
        {
            _LicenseID = licenseID;
            _License = License.Find(_LicenseID);

            if (_License == null)
            {
                MessageBox.Show("Could not find License ID = " + _LicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _LicenseID = -1;
                return;
            }

            _FillLicenseInfo();

        }


        private void _LoadPersonImage()
        {
            if (_License.DriverInfo.PersonInfo.Gender == 0)
                pbPersonImg.Image = Resources.Male_512;
            else
                pbPersonImg.Image = Resources.Female_512;

            string ImagePath = _License.DriverInfo.PersonInfo.ImagePath;

            if(ImagePath != "")
            {
                if(File.Exists(ImagePath))
                    pbPersonImg.Load(ImagePath);
                else
                    MessageBox.Show("Couldn't Find this image  " + ImagePath, "Not Found", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void _FillLicenseInfo()
        {

            lblLicenseClass.Text = _License.LicenseClassInfo.LicenseName;
            lblPersonName.Text = _License.DriverInfo.PersonInfo.FullName();
            lblLicenseID.Text = _License.LicenseID.ToString();
            lblGender.Text = _License.DriverInfo.PersonInfo.Gender == 0 ? "Male" : "Female";
            lblNationalNo.Text = _License.DriverInfo.PersonInfo.NationalNum;
            lblIssueDate.Text = Format.DateToShort(_License.IssueDate);
            lblIssueReason.Text = _License.IssueReasonText;
            lblNotes.Text = _License.Notes == "" ? "No Notes" : _License.Notes;
            lblIsActive.Text = _License.IsActive ? "Yes" : "No";
            lblDateOfBirth.Text = Format.DateToShort(_License.DriverInfo.PersonInfo.DateOfBirth);
            lblDriverId.Text = _License.DriverID.ToString();
            lblExpirationDate.Text = Format.DateToShort(_License.ExpirationDate);
            lblIsDetained.Text = _License.isDetained() ? "Yes" : "No";
            _LoadPersonImage();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
