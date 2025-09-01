using DVLD_Buisness;
using FirstProjectDVLD.licenses;
using FirstProjectDVLD.licenses.LocalLicenses;
using FirstProjectDVLD.Tests;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace FirstProjectDVLD.Applications.LocalDrivingLicenses
{
    public partial class frmListLocalDrivingLicenseApplication : Form
    {

        private DataTable _dtAllLocalApplications;
        public frmListLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void pbAddApplication_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication();
            frm.ShowDialog();

            frmListLocalDrivingLicenseApplication_Load(null, null);
        }
        private void frmListLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _dtAllLocalApplications = LocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            dgvAllApplications.DataSource = _dtAllLocalApplications;
            lblRecordsCount.Text = dgvAllApplications.Rows.Count.ToString();

            if (dgvAllApplications.Rows.Count > 0)
            {
                dgvAllApplications.Columns[0].HeaderText = "L.D.L.AppID";
                dgvAllApplications.Columns[0].Width = 90;

                dgvAllApplications.Columns[1].HeaderText = "Driving Class";
                dgvAllApplications.Columns[1].Width = 200;

                dgvAllApplications.Columns[2].HeaderText = "National No.";
                dgvAllApplications.Columns[2].Width = 100;

                dgvAllApplications.Columns[3].HeaderText = "Full Name";
                dgvAllApplications.Columns[3].Width = 240;

                dgvAllApplications.Columns[4].HeaderText = "Application Date";
                dgvAllApplications.Columns[4].Width = 160;

                dgvAllApplications.Columns[5].HeaderText = "Passed Tests";
                dgvAllApplications.Columns[5].Width = 100;

                dgvAllApplications.Columns[6].HeaderText = "Status";
                dgvAllApplications.Columns[6].Width = 90;

            }

            cbFilterBy.SelectedIndex = 0;

        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtFilterBy.Visible = cbFilterBy.Text != "None";

            if (cbFilterBy.Text == "None")
                DefaultFilter();

            if (txtFilterBy.Visible)
            {
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }

        }
        private void DefaultFilter()
        {
            _dtAllLocalApplications.DefaultView.RowFilter = "";
            lblRecordsCount.Text = _dtAllLocalApplications.Rows.Count.ToString();
        }
        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "L.D.L.AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Status":
                    FilterColumn = "Status";
                    break;

                case "None":
                    FilterColumn = "None";
                    break;
            }


            if (txtFilterBy.Text.Trim() == "" || cbFilterBy.Text == "None")
            {
                DefaultFilter();
                return;
            }

            if (cbFilterBy.Text == "L.D.L.AppID")
            {
                _dtAllLocalApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
            }
            else
                _dtAllLocalApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());

            lblRecordsCount.Text = dgvAllApplications.Rows.Count.ToString();

        }
        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "L.D.L.AppID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
        private void showApplicationDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalDrivingLicenseApplicationInfo frm = new
                frmLocalDrivingLicenseApplicationInfo((int)dgvAllApplications.CurrentRow.Cells[0].Value); ;

            frm.ShowDialog();
        }
        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenseApplication frm = new frmAddUpdateLocalDrivingLicenseApplication((int)dgvAllApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmListLocalDrivingLicenseApplication_Load(null, null);
        }
        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure do want to delete this application?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;

            LocalDrivingLicenseApplication selectedApp = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID((int)dgvAllApplications.CurrentRow.Cells[0].Value);

            if (selectedApp != null)
            {
                if (selectedApp.Delete())
                {
                    MessageBox.Show("Application Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmListLocalDrivingLicenseApplication_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could not delete applicatoin, other data depends on it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                return;
            LocalDrivingLicenseApplication localApp = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID((int)dgvAllApplications.CurrentRow.Cells[0].Value);

            if (localApp != null)
            {
                if (localApp.Cancel())
                {
                    MessageBox.Show("Application Cancelled Successfully.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmListLocalDrivingLicenseApplication_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Could not cancel applicatoin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalDrivingLicenseApplication localApp = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(
                (int)dgvAllApplications.CurrentRow.Cells[0].Value);
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(localApp.ApplicantPersonID);
            frm.ShowDialog();

        }
        private void shoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int licenseID = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID((int)dgvAllApplications.CurrentRow.Cells[0].Value).GetActiveLicenseID();

            frmShowLicenseInfo frm = new frmShowLicenseInfo(licenseID);
            frm.ShowDialog();

            frmListLocalDrivingLicenseApplication_Load(null, null);
        }
        private void issueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueDriverLicenseFirstTime frm = new frmIssueDriverLicenseFirstTime((int)dgvAllApplications.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmListLocalDrivingLicenseApplication_Load(null, null);
        }
        private void _ScheduleTest(TestType.enTestType TestType)
        {
            frmListTestAppointments frm = new frmListTestAppointments((int)dgvAllApplications.CurrentRow.Cells[0].Value, TestType);
            frm.ShowDialog();

            frmListLocalDrivingLicenseApplication_Load(null, null);
        }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            _ScheduleTest(TestType.enTestType.Vision);
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            _ScheduleTest(TestType.enTestType.WrittenTest);
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            _ScheduleTest(TestType.enTestType.StreetTest);

        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            LocalDrivingLicenseApplication _LocalDLApplication = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID((int)dgvAllApplications.CurrentRow.Cells[0].Value);

            int PassedTests = (int)dgvAllApplications.CurrentRow.Cells[5].Value;

            //postponed
            bool LicenseExists = _LocalDLApplication.IsLicenseIssued();

            issueToolStripMenuItem.Enabled = PassedTests == 3 && !LicenseExists;

            shoToolStripMenuItem.Enabled = LicenseExists;
            editApplicationToolStripMenuItem.Enabled = !LicenseExists && (_LocalDLApplication.ApplicationStatus == BuisnessApplication.enApplicationStatus.New);
            ScheduleTestsMenue.Enabled = !LicenseExists && PassedTests < 3;

            //Enable/Disable Cancel Menue Item
            //We only canel the applications with status=new.
            cancelApplicationToolStripMenuItem.Enabled = (_LocalDLApplication.ApplicationStatus == BuisnessApplication.enApplicationStatus.New);

            //Enable/Disable Delete Menue Item
            //We only allow delete incase the application status is new not complete or Cancelled.
            deleteApplicationToolStripMenuItem.Enabled =
                (_LocalDLApplication.ApplicationStatus == BuisnessApplication.enApplicationStatus.New);



            bool PassedVisionTest = _LocalDLApplication.DoesPassTestType(TestType.enTestType.Vision);
            bool PassedWrittenTest = _LocalDLApplication.DoesPassTestType(TestType.enTestType.WrittenTest);
            bool PassedStreetTest = _LocalDLApplication.DoesPassTestType(TestType.enTestType.StreetTest);

            if (ScheduleTestsMenue.Enabled)
            {
                visionTesttoolStripMenuItem.Enabled = !PassedVisionTest;
                writtenTestToolStripMenuItem8.Enabled = !PassedWrittenTest && PassedVisionTest;
                streetTestToolStripMenuItem9.Enabled = !PassedStreetTest && PassedWrittenTest;
            }
        }

    }
}
