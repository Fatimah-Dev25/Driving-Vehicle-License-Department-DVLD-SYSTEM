using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class Test
    {
        enum enMode { AddNew, Update}
        enMode _Mode;
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public TestAppointment TestAppointmentInfo { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUser { get; set; }

        public Test() {

            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = "";
            CreatedByUser = -1;
            _Mode = enMode.AddNew;
        }
        private Test(int testID, int testAppointmentID, bool testResult, string notes, int createdByUser)
        {
            _Mode = enMode.Update;
            TestID = testID;
            TestAppointmentID = testAppointmentID;
            TestResult = testResult;
            Notes = notes;
            CreatedByUser = createdByUser;

            TestAppointmentInfo = TestAppointment.Find(TestAppointmentID);
        }
        public static DataTable GetAllTests()
        {
            return TestData.GetAllTests();
        }
        public static Test Find(int _TestID)
        {
            int testAppointmentID = -1, createdByUser = -1;
            bool testResult = false;
            string notes = "";

            if (TestData.GetTestInfoByID(_TestID, ref testAppointmentID, ref testResult, ref notes, ref createdByUser))
            {
                return new Test(_TestID, testAppointmentID, testResult, notes, createdByUser);
            }
            else
                return null;
        }

        public static Test FindLastTestPerPersonAndLicenseClass(int PersonID, TestType.enTestType TestType, int LicenseClassID)
        {
            int testID = -1, testAppointmentID = -1, createdByUser = -1;
            bool testResult = false;
            string notes = "";

            if (TestData.GetLastTestByPersonAndTestTypeAndLicenseClass(PersonID, (int)TestType, LicenseClassID,
                ref testID, ref testAppointmentID, ref testResult, ref notes, ref createdByUser))
                return new Test(testID, testAppointmentID, testResult, notes, createdByUser);
            else
                return null;

        }

        private bool _AddNewTest()
        {
            this.TestID = TestData.AddNewTest(this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUser);
            return this.TestID != -1;
        }
        private bool _UpdateTestInfo()
        {
            return TestData.UpdateTest(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUser);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateTestInfo();
            }

            return false;
        }

        public static byte GetPassedTestCount(int LocalDLAppID)
        {
            return TestData.GetPassedTestCount(LocalDLAppID);
        }

        public static bool PassedAllTests(int LocalDLAppID)
        {
            return GetPassedTestCount(LocalDLAppID) == 3;
        }
    }
}
