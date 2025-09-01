using DVLD_Buisness;
using FirstProjectDVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.Tests
{
    public partial class frmListTestAppointments : Form
    {
        DataTable dtTestAppoitments;
        private int _LocadDLAppID = -1;
        TestType.enTestType _TestType = TestType.enTestType.Vision;

        public frmListTestAppointments(int localAppId, TestType.enTestType testype)
        {
            InitializeComponent();
            _LocadDLAppID = localAppId; 
            _TestType = testype;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListTestAppointments_Load(object sender, EventArgs e)
        {
            _LoadTestTypeImgAndTitle();

            ctrlLocalLicenseAppInfo1.LoadApplicationInfoByLocalLicenseAppID(_LocadDLAppID);

            dtTestAppoitments = TestAppointment.GetApplicationTestAppointmentsPerTestType(_LocadDLAppID, _TestType);  
            dgvTestAppointments.DataSource = dtTestAppoitments;
            lblRecordsCount.Text = dgvTestAppointments.Rows.Count.ToString();

            if (dgvTestAppointments.Rows.Count > 0)
            {

                dgvTestAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvTestAppointments.Columns[0].Width = 150;

                dgvTestAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvTestAppointments.Columns[1].Width = 180;

                dgvTestAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvTestAppointments.Columns[2].Width = 150;

                dgvTestAppointments.Columns[3].HeaderText = "Is Locked";
                dgvTestAppointments.Columns[3].Width = 150;
            }
        }

        private void _LoadTestTypeImgAndTitle()
        {

            switch (_TestType)
            {
                case TestType.enTestType.Vision:
                    pbTestIMG.Image = Resources.Vision_512;
                    lblTestTitle.Text = "Vision Test Appointments";
                    break;
                    
                case TestType.enTestType.WrittenTest:
                    pbTestIMG.Image = Resources.Written_Test_512;
                    lblTestTitle.Text = "Written Test Appointments";
                    break;
                    
                case TestType.enTestType.StreetTest:
                    pbTestIMG.Image = Resources.drivingtest_512;
                    lblTestTitle.Text = "Street Test Appointments";
                    break;

            }


        }

        private void pbAddNewAppointment_Click(object sender, EventArgs e)
        {

            LocalDrivingLicenseApplication LocalDLApp = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocadDLAppID);

            if (LocalDLApp.IsThereAnActiveScheduledTest(_TestType))
            {
                MessageBox.Show("Person already has an active appointment for this test, you cannot add new appointment", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Test LastTest = LocalDLApp.GetLastTestPerTestType(_TestType);

            if(LastTest == null)
            {
                frmScheduleTest frm = new frmScheduleTest(_LocadDLAppID, _TestType);
                frm.ShowDialog();

                frmListTestAppointments_Load(null, null);
                return;
            }

            if (LastTest.TestResult)
            {
                MessageBox.Show("this Person already passed test befor, you can only retake faild test", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmScheduleTest frm2 = new frmScheduleTest(LastTest.TestAppointmentInfo.LocalDLicenseAppID, _TestType);
            frm2.ShowDialog();
            frmListTestAppointments_Load(null, null);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmScheduleTest frm = new frmScheduleTest(_LocadDLAppID, _TestType, (int)dgvTestAppointments.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmListTestAppointments_Load(null, null);
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeTest frm = new frmTakeTest((int)dgvTestAppointments.CurrentRow.Cells[0].Value, _TestType);
            frm.ShowDialog();

            frmListTestAppointments_Load(null, null);
        }
    }
}
