using DVLD_Buisness;
using FirstProjectDVLD.GlobalClasses;
using FirstProjectDVLD.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FirstProjectDVLD.Applications.Controls
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        private BuisnessApplication _Application;
        private int _ApplicationID;

        public int ApplicationID
        {
            get
            {
                return _ApplicationID;
            }
        }
        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        public void ResetApplicationInfo()
        {
            _ApplicationID = -1;

            lblAppDate.Text = "[???]";
            lblAppStatus.Text = "[???]";
            lblAppFees.Text = "[$$$]";
            lblAppType.Text = "[???]";
            lblApplicant.Text = "[????]";
            lblAppDate.Text = "[??/??/????]";
            lblAppStatusDate.Text = "[??/??/????]";
            lblAppUser.Text = "[????]";
               
        }
        public void LoadApplicationInfo(int applicationID)
        {
            _Application = BuisnessApplication.FindBaseApplication(applicationID);

            if(_Application == null)
            {
                ResetApplicationInfo();
                MessageBox.Show("No Application with ID: " + _ApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                _FillApplicationInfo();
        }

        private void _FillApplicationInfo()
        {
            _ApplicationID = _Application.ApplicationID;

            lblApplicationID.Text = _Application.ApplicationID.ToString();
            lblAppStatus.Text = _Application.StatusText;

            lblAppType.Text = _Application.ApplicationType.AppTitleType;
            lblAppFees.Text = _Application.PaidFees.ToString();

            lblAppDate.Text = Format.DateToShort(_Application.ApplicationDate);
            lblAppStatusDate.Text = Format.DateToShort(_Application.LastStatusDate);
            lblAppUser.Text = _Application.CreatedByUserInfo.UserName;
            lblApplicant.Text = _Application.ApplicantFullName;

        }

        private void llblAppViewPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmShowPersonDetail frm = new frmShowPersonDetail(_Application.ApplicantPersonID);
            frm.ShowDialog();

            LoadApplicationInfo(_ApplicationID);
        }

         
    }
}
