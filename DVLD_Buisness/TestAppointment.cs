using System;
using System.Collections.Generic;
using System.Linq;
using DVLD_DataAccess;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Data;

namespace DVLD_Buisness
{
    public class TestAppointment
    {
        enum enMode { AddNew, Update}
        enMode _Mode;
        public int TestAppointmentID
        {
            set; get;
        }
        public TestType.enTestType TestTypeID
        {
            set; get;
        }

        public DateTime AppointmentDate { set; get; }
        public float PaidFees { set; get; }
        public bool isAppointmentLocked { set; get; }
        public int LocalDLicenseAppID { set; get; }
        public int CreatedByUser { set; get; }
        public int RetakeTestAppID { set;get; }
        public BuisnessApplication RetakeTestAppInfo { set;get; }
        
        public int TestID
        {
            get { return _GetTestID(); }
        }
        public TestAppointment()
        {
            _Mode = enMode.AddNew;
            TestAppointmentID = -1;
            TestTypeID = TestType.enTestType.Vision;
            AppointmentDate = DateTime.Now;
            PaidFees = 0;
            CreatedByUser = -1;
            RetakeTestAppID = -1;
        }
        private TestAppointment(int testAppointmentID, TestType.enTestType testTypeID, DateTime appointmentDate, float paidFees, bool isAppointmentLocked, int localDLicenseAppID, int createdByUser, int retakeTestAppID)
        {
            _Mode = enMode.Update;
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            this.isAppointmentLocked = isAppointmentLocked;
            LocalDLicenseAppID = localDLicenseAppID;
            CreatedByUser = createdByUser;
            RetakeTestAppID = retakeTestAppID;

            RetakeTestAppInfo = BuisnessApplication.FindBaseApplication(RetakeTestAppID);           
        }
        private bool _AddNewAppointement()
        {
            this.TestAppointmentID = TestAppointmentData.AddNewTestAppointment((int)this.TestTypeID, this.AppointmentDate, this.LocalDLicenseAppID,
                this.PaidFees, this.isAppointmentLocked, this.CreatedByUser, this.RetakeTestAppID);

            return this.TestAppointmentID != -1;
        }
        private bool _UpdateAppointment()
        {
            return TestAppointmentData.UpdateTestAppointment(this.TestAppointmentID, (int)this.TestTypeID, this.AppointmentDate,
                this.LocalDLicenseAppID, this.PaidFees, this.isAppointmentLocked, this.CreatedByUser, this.RetakeTestAppID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAppointement())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }else
                        return false;

                    
                case enMode.Update:
                    return _UpdateAppointment();
            }

            return false;
        }
        public static TestAppointment Find(int testAppointmentID)
        {
            int testTypeId = -1, createdUser = -1, LocalAppId = -1, retakeTestAppID = -1;
            float paidFees = 0;
            bool isLocked = false;
            DateTime appointmentDate = DateTime.Now;

            if (TestAppointmentData.GetTestAppointmentInfoByID(testAppointmentID, ref testTypeId, ref LocalAppId, ref appointmentDate,
                ref paidFees, ref createdUser, ref isLocked, ref retakeTestAppID))
            {
                return new TestAppointment(testAppointmentID, (TestType.enTestType)testTypeId, appointmentDate, paidFees, isLocked, LocalAppId, createdUser, retakeTestAppID);
            }
            else
                return null;
        }
        public static TestAppointment GetLastTestAppointment(int LocalAppId, int testTypeID)
        {
            int testappointmentID = -1, createdUser = -1, retakeTestAppID = -1;
            float paidFees = 0;
            bool isLocked = false;
            DateTime appointmentDate = DateTime.Now;

            if (TestAppointmentData.GetLastTestAppointment(LocalAppId, testTypeID, ref testappointmentID, ref appointmentDate,
                ref paidFees, ref createdUser, ref isLocked, ref retakeTestAppID))
            {
                return new TestAppointment(testappointmentID, (TestType.enTestType)testTypeID, appointmentDate, paidFees, isLocked, LocalAppId, createdUser, retakeTestAppID);
            }
            else
                return null;
        }
        public static DataTable GetAllTestAppointments()
        {
            return TestAppointment.GetAllTestAppointments();
        }
        public static DataTable GetApplicationTestAppointmentsPerTestType(int LocalDLAppID, TestType.enTestType testTypeID)
        {
            return TestAppointmentData.GetApplicationTestAppointmentsPerTestType(LocalDLAppID, (int)testTypeID);
        }
        public DataTable GetApplicationTestAppointmentsPerTestType(TestType.enTestType TestTypeID)
        {
            return TestAppointmentData.GetApplicationTestAppointmentsPerTestType(this.LocalDLicenseAppID, (int)TestTypeID);
        }
        private int _GetTestID()
        {
            return TestAppointmentData.GetTestID(this.TestAppointmentID);
        }

    }
}
