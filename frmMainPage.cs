using FirstProjectDVLD.Applications;
using FirstProjectDVLD.Applications.InternationalLicenses;
using FirstProjectDVLD.Applications.LocalDrivingLicenses;
using FirstProjectDVLD.Applications.ReleaseDetaindLicense;
using FirstProjectDVLD.Applications.RenewLocalLicense;
using FirstProjectDVLD.Applications.ReplaceLostOrDamagedLicense;
using FirstProjectDVLD.Applications.TestTypes;
using FirstProjectDVLD.Drivers;
using FirstProjectDVLD.GlobalClasses;
using FirstProjectDVLD.licenses.DetainedLicenses;
using FirstProjectDVLD.Login;
using FirstProjectDVLD.People;
using FirstProjectDVLD.Tests;
using FirstProjectDVLD.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD
{
    public partial class frmMainPage : Form
    {
        frmLogin _FrmLogin;
        public frmMainPage(frmLogin frm)
        {
            InitializeComponent();
            _FrmLogin = frm;
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDrivers frm = new frmListDrivers();
            frm.ShowDialog();
        }

        private void replacementForLostOrDamageLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListPeople frm = new frmListPeople();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersList frm = new frmUsersList();
            frm.ShowDialog();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(Global.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLocalLicenseApplication frm = new frmRenewLocalLicenseApplication();
            frm.ShowDialog();
        }

        private void replacementForLostOrDamageLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReplaceLostOrDamagedLicenseApplication frm = new frmReplaceLostOrDamagedLicenseApplication();
            frm.ShowDialog();   
        }

        private void releaseDetainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRetakeTest frm = new frmRetakeTest();
            frm.ShowDialog();
        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicenseApplication frm = new frmListLocalDrivingLicenseApplication();
            frm.ShowDialog();
        }

        private void manageDetainedLicesnswToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDetainedLicenses frm = new frmListDetainedLicenses();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void releaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplicationType frm = new frmApplicationType();
            frm.ShowDialog();
        }

        private void manageTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestTypes frm = new frmManageTestTypes();
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(Global.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.CurrentUser = null;
            _FrmLogin.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void drivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication frm = new frmNewInternationalLicenseApplication();
            frm.ShowDialog();
        }

        private void internationalDrivToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInternationalLicenseApplications frm = new frmListInternationalLicenseApplications();
            frm.ShowDialog();
        }
    }
}
