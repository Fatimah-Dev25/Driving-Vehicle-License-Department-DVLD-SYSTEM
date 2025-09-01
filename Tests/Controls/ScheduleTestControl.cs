using DVLD_Buisness;
using FirstProjectDVLD.GlobalClasses;
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
using static DVLD_Buisness.TestType;

namespace FirstProjectDVLD.Tests.Controls
{
    public partial class ScheduleTestControl : UserControl
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        enum enCreationMode { FirstTimeSchedule = 0, RetakeTestSchedule = 1 }
        enCreationMode _CreationMode = enCreationMode.FirstTimeSchedule;

        private TestType.enTestType _TestTypeID = TestType.enTestType.Vision;
        public TestType.enTestType TestTypeID
        {
            get { return _TestTypeID; }
            set 
            {
                _TestTypeID = value;

                switch (value)
                {
                    case TestType.enTestType.Vision:
                        pbTestImage.Image = Resources.Vision_512;
                        gbTest.Text = "Vision Test";
                        break;

                    case TestType.enTestType.WrittenTest:
                        pbTestImage.Image = Resources.Written_Test_512;
                        gbTest.Text = "Written Test";
                        break;

                    case TestType.enTestType.StreetTest:
                        pbTestImage.Image = Resources.drivingtest_512;
                        gbTest.Text = "Street Test";
                        break;
                }

            }
        }

        private int _LocalDLAppID = -1;

        private LocalDrivingLicenseApplication _LocalLicenseApplication;

        private TestAppointment _TestAppointment;

        private int _TestAppointmentID = -1;
        public ScheduleTestControl()
        {
            InitializeComponent();
        }
        public void LoadInfo(int localDLAppId, int AppointmentId = -1)
        {

            _Mode = AppointmentId == -1 ? enMode.AddNew : enMode.Update;

            _LocalDLAppID = localDLAppId;
            _TestAppointmentID = AppointmentId;

            _LocalLicenseApplication = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDLAppID);
          
            if(_LocalLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License with ID = " + _LocalDLAppID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            //decide if the createion mode is retake test or not based if the person attended this test before

            _CreationMode = (_LocalLicenseApplication.DoesAttendTestType(_TestTypeID))?enCreationMode.RetakeTestSchedule:enCreationMode.FirstTimeSchedule;
     
            if(_CreationMode == enCreationMode.RetakeTestSchedule)
            {
                gbRetakeTest.Enabled = true;
                lblRetakeTestFees.Text = clsApplicationType.Find((int)BuisnessApplication.enApplicationType.RetakeTest).AppTypeFee.ToString();
                lblTestTitle.Text = "Schedule Retake Test";
                lblRetakeTestAppID.Text = "0"; 
            }
            else 
            {
                gbRetakeTest.Enabled = false;
                lblTestTitle.Text = "Schedule Test";
                lblRetakeTestFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }

            lblLDAppID.Text = _LocalDLAppID.ToString();
            lblLicenseClass.Text = LicenseClass.Find(_LocalLicenseApplication.LicenseClassID).LicenseName;
            lblApplicantName.Text = _LocalLicenseApplication.FullName;
            lblTrialCount.Text = _LocalLicenseApplication.TotalTrialsPerTest(_TestTypeID).ToString();

            if(_Mode == enMode.AddNew)
            {
                _TestAppointment = new TestAppointment();
                lblTestFees.Text = TestType.Find(_TestTypeID).TestTypeFees.ToString();
                lblRetakeTestAppID.Text = "N/A";
                dtpAppointmentDate.MinDate = DateTime.Now;
            }
            else
            {
                if (!_LoadTestAppointmentData())
                    return;
            }

            lblTotalFees.Text = (Convert.ToSingle(lblTestFees.Text) + Convert.ToSingle(lblRetakeTestFees.Text)).ToString();


            if (!_HandleActiveTestAppointmentConstraint())
                return;

            if (!_HandleAppointmentLockedConstraint())
                return;

            if (!_HandlePreviousTestConstraint())
                return;
        }

        private bool _HandleActiveTestAppointmentConstraint()
        {

            if(_Mode == enMode.AddNew && _LocalLicenseApplication.IsThereAnActiveScheduledTest(_TestTypeID))
            {
                lblMessageForUser.Text = "Person already have active appointment for this test";
                btnSave.Enabled = false;
                dtpAppointmentDate.Enabled = false;
                return false;
            }

            return true;

        }
        private bool _LoadTestAppointmentData()
        {
            _TestAppointment = TestAppointment.Find(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No Test Appointment with ID = " + _TestAppointmentID, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnSave.Enabled = false;    
                return false;

            }

            lblTestFees.Text = _TestAppointment.PaidFees.ToString();

            if (DateTime.Compare(DateTime.Now, _TestAppointment.AppointmentDate) < 0)
                dtpAppointmentDate.MinDate = DateTime.Now;
            else
                dtpAppointmentDate.MinDate = _TestAppointment.AppointmentDate;

            dtpAppointmentDate.Value = _TestAppointment.AppointmentDate;

            if(_TestAppointment.RetakeTestAppID == -1)
            {
                lblRetakeTestFees.Text = "0";
                lblRetakeTestAppID.Text = "N/A";
            }
            else
            {
                gbRetakeTest.Enabled = true;
                lblRetakeTestFees.Text = _TestAppointment.RetakeTestAppInfo.PaidFees.ToString();
                lblTestTitle.Text = "Schedule Retake Test";
                lblRetakeTestAppID.Text = _TestAppointment.RetakeTestAppID.ToString();
            }

            return true;

        }

        private bool _HandleAppointmentLockedConstraint()
        {
            if (_TestAppointment.isAppointmentLocked)
            {
                lblMessageForUser.Visible = true;
                lblMessageForUser.Text = "Person already sat this test, Appointment Locked";
                btnSave.Enabled = false;
                dtpAppointmentDate.Enabled = false;
                return false;
            }
            else
                lblMessageForUser.Visible = false;

            return true;

        }
    
        private bool _HandlePreviousTestConstraint()
        {

            switch (_TestTypeID)
            {
                case enTestType.Vision:
                    lblMessageForUser.Visible = false;
                    return true;

                case enTestType.WrittenTest:
                  
                    if (!_LocalLicenseApplication.DoesPassTestType(enTestType.Vision))
                    {
                        lblMessageForUser.Visible = true;
                        lblMessageForUser.Text = "Cannot Schedule, Vision Test Should be Passed First";
                        btnSave.Enabled = false;
                        dtpAppointmentDate.Enabled = false;

                        return false;
                    }
                    else
                    {
                        lblMessageForUser.Visible = false;
                        btnSave.Enabled = true;
                        dtpAppointmentDate.Enabled = true;
                    }

                    return true;


                case enTestType.StreetTest:
                    if (!_LocalLicenseApplication.DoesPassTestType(enTestType.WrittenTest))
                    {
                        lblMessageForUser.Visible = true;
                        lblMessageForUser.Text = "Cannot Schedule, Written Test Should be Passed First";
                        btnSave.Enabled = false;
                        dtpAppointmentDate.Enabled = false;
                        return false;
                    }
                    else
                    {
                        lblMessageForUser.Visible = false;
                        btnSave.Enabled = true;
                        dtpAppointmentDate.Enabled = true;
                    }
                    
                    return true;
            }

            return true;
        }

        private bool _HandleRetakeApplication()
        {
            if(_Mode == enMode.AddNew && _CreationMode == enCreationMode.RetakeTestSchedule)
            {
                BuisnessApplication retakeApplication = new BuisnessApplication();

                retakeApplication.ApplicantPersonID = _LocalLicenseApplication.ApplicantPersonID;
                retakeApplication.ApplicationDate = DateTime.Now;
                retakeApplication.LastStatusDate = DateTime.Now;
                retakeApplication.ApplicationStatus = BuisnessApplication.enApplicationStatus.Completed;
                retakeApplication.ApplicationTypeId = (int)BuisnessApplication.enApplicationType.RetakeTest;
                retakeApplication.PaidFees = clsApplicationType.Find(retakeApplication.ApplicationTypeId).AppTypeFee;
                retakeApplication.CreatedByUserID = Global.CurrentUser.UserID;
                
                if(!retakeApplication.Save())
                {
                    _TestAppointment.RetakeTestAppID = -1;
                    MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
                 _TestAppointment.RetakeTestAppID = retakeApplication.ApplicationID;
                
            }

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_HandleRetakeApplication())
                return;

            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.LocalDLicenseAppID = _LocalLicenseApplication.LocalDrivingLicenseAppID;
            _TestAppointment.AppointmentDate = dtpAppointmentDate.Value;
            _TestAppointment.PaidFees = Convert.ToSingle(lblTestFees.Text);
            _TestAppointment.CreatedByUser = Global.CurrentUser.UserID;

            if (_TestAppointment.Save())
            {
                _Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

}
