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

namespace FirstProjectDVLD.Tests.Controls
{
    public partial class ScheduledTestControl : UserControl
    {

        TestType.enTestType _TestType = TestType.enTestType.Vision;
        public TestType.enTestType TestTypeID
        {
            get { return _TestType; }

            set
            {
                _TestType = value;

                switch(value)
                {
                    case TestType.enTestType.Vision:
                        pbTestType.Image = Resources.Vision_512;
                        groupBox1.Text = "Vision Test";
                        break;

                    case TestType.enTestType.WrittenTest:
                        pbTestType.Image = Resources.Written_Test_512;
                        groupBox1.Text = "Written Test";
                        break;

                    case TestType.enTestType.StreetTest:
                        pbTestType.Image = Resources.drivingtest_512;
                        groupBox1.Text = "Street Test";
                        break;

                }
            }
        }

        private int _TestID = -1;

        LocalDrivingLicenseApplication _LocalDLApplication;
        public int TestAppointmentID
        {
            get
            {
                return _TestAppointmentID;
            }
        }
        public int TestID
        {
            get
            {
                return _TestID;
            }
        }

        private int _TestAppointmentID = -1;
        private int _LocalDrivingLicenseApplicationID = -1;
        private TestAppointment _TestAppointment;
        public ScheduledTestControl()
        {
            InitializeComponent();
        }

        public void LoadInfo(int TestAppointmentID)
        {
            _TestAppointmentID = TestAppointmentID;
            _TestAppointment = TestAppointment.Find(_TestAppointmentID);

            if( _TestAppointment == null )
            {
                MessageBox.Show($"Error: No Appointment with ID = {_TestAppointmentID}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _TestAppointmentID = -1;
                return;
            }
           
            _TestID = _TestAppointment.TestID;
            _LocalDrivingLicenseApplicationID = _TestAppointment.LocalDLicenseAppID;
            _LocalDLApplication = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalDrivingLicenseApplicationID);

            lblLocalAppID.Text = _LocalDLApplication.LocalDrivingLicenseAppID.ToString();
            lblPerson.Text = _LocalDLApplication.ApplicantFullName;
            lblTestDate.Text = Format.DateToShort(_TestAppointment.AppointmentDate);
            lblLClass.Text = LicenseClass.Find(_LocalDLApplication.LicenseClassID).LicenseName;
            lblFees.Text = _TestAppointment.PaidFees.ToString();
            lblTrils.Text = _LocalDLApplication.TotalTrialsPerTest(_TestType).ToString();

            lblTestID.Text = _TestAppointment.TestID == -1?"Not Taket Yet!":_TestAppointment.TestID.ToString();

        }
       

       
    }
}
