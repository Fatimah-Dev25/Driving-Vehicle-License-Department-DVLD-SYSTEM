using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Buisness;
using FirstProjectDVLD.GlobalClasses;
using FirstProjectDVLD.Properties;

namespace FirstProjectDVLD.licenses.InternationalLicenses.Controls
{
    public partial class ctrlDriverInternationalLicenseIndfo : UserControl
    {
        private int _InternationalLicenseID = -1;
        private InternationalLicense _InternationalLicense;
        public ctrlDriverInternationalLicenseIndfo()
        {
            InitializeComponent();
        }

        public int LicenseID { get { return _InternationalLicenseID; } }
        public InternationalLicense SelectedInternationalLicenseInfo { get { return _InternationalLicense; } }


        public void LoadLicenseInfo(int InternationalLicenseID)
        {
            _InternationalLicenseID = InternationalLicenseID;
            _InternationalLicense = InternationalLicense.Find(_InternationalLicenseID);

            if (_InternationalLicense == null)
            {
                MessageBox.Show("Could not International License with ID = " + _InternationalLicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _InternationalLicenseID = -1;
                return;
            }

            _FillLicenseInfo();

        }


        private void _LoadPersonImage()
        {
            if (_InternationalLicense.DriverInfo.PersonInfo.Gender == 0)
                pbPersonImg.Image = Resources.Male_512;
            else
                pbPersonImg.Image = Resources.Female_512;

            string ImagePath = _InternationalLicense.DriverInfo.PersonInfo.ImagePath;

            if (ImagePath != "")
            {
                if (File.Exists(ImagePath))
                    pbPersonImg.Load(ImagePath);
                else
                    MessageBox.Show("Couldn't Find this image  " + ImagePath, "Not Found", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
        private void _FillLicenseInfo()
        {

            lblInternationalLicID.Text = _InternationalLicense.InternationalLicenseID.ToString();
            lblPersonName.Text = _InternationalLicense.DriverInfo.PersonInfo.FullName();
            lblGender.Text = _InternationalLicense.DriverInfo.PersonInfo.Gender == 0 ? "Male" : "Female";
            lblNationalNo.Text = _InternationalLicense.DriverInfo.PersonInfo.NationalNum;
            lblIssueDate.Text = Format.DateToShort(_InternationalLicense.IssueDate);
            lblIsActive.Text = _InternationalLicense.IsActive ? "Yes" : "No";
            lblDateOfBirth.Text = Format.DateToShort(_InternationalLicense.DriverInfo.PersonInfo.DateOfBirth);
            lblDriverId.Text = _InternationalLicense.DriverID.ToString();
            lblExpirationDate.Text = Format.DateToShort(_InternationalLicense.ExpirationDate);
            lblLocalLicenseID.Text = _InternationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblAppID.Text = _InternationalLicense.ApplicationID.ToString();
            _LoadPersonImage();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblLicenseClass_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void ctrlDriverInternationalLicenseIndfo_Load(object sender, EventArgs e)
        {

        }

        private void lblAppID_Click(object sender, EventArgs e)
        {

        }

        private void pbPersonImg_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void lblIssueDate_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lblDriverId_Click(object sender, EventArgs e)
        {

        }

        private void lblExpirationDate_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
