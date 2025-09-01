using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class LocalDrivingLicenseApplication : BuisnessApplication
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;
        public int LocalDrivingLicenseAppID { set; get; }
        public int LicenseClassID { set; get; }

        public LicenseClass LicenseClassInfo;

        public string FullName
        {
            get
            {
                return base.PersonInfo.FullName();
            }
        }

        public LocalDrivingLicenseApplication()
        {
            LocalDrivingLicenseAppID = -1;
            LicenseClassID = -1;

            _Mode = enMode.AddNew;
        }
        private LocalDrivingLicenseApplication(int LocalLicenseAppID, int LicenseClassID,
            int applicationID, int applicantPersonID, DateTime applicationDate, int applicationTypeId,
            enApplicationStatus applicationStatus, DateTime lastStatusDate, float paidFees,
            int createdByUserID)
        {
            _Mode = enMode.Update;
            this.LocalDrivingLicenseAppID = LocalLicenseAppID;
            this.LicenseClassID = LicenseClassID;

            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            ApplicationDate = applicationDate;
            ApplicationTypeId = applicationTypeId;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;

            LicenseClassInfo = LicenseClass.Find(LicenseClassID);
            this.PersonInfo = Person.Find(ApplicantPersonID);
        }

        public static LocalDrivingLicenseApplication FindByLocalDrivingAppLicenseID(int LocalDrivingLicenseAppID)
        {
            int applicationID = -1, licenseClassId = -1;

            bool isFound = LocalDrivingLicencesApplicationData.GetLocalDrivingLicenseApplicationInfoByID(LocalDrivingLicenseAppID, ref applicationID, ref licenseClassId);

            if (isFound)
            {
                BuisnessApplication application = BuisnessApplication.FindBaseApplication(applicationID);

                return new LocalDrivingLicenseApplication(LocalDrivingLicenseAppID, licenseClassId, application.ApplicationID,
                    application.ApplicantPersonID, application.ApplicationDate, application.ApplicationTypeId, application.ApplicationStatus, application.LastStatusDate,
                     application.PaidFees, application.CreatedByUserID);

            }
            else
                return null;
        }

        public static LocalDrivingLicenseApplication FindByApplicationID(int applicationID)
        {
            int LocalDrivingLicenseAppID = -1, licenseClassId = -1;

            bool isFound = LocalDrivingLicencesApplicationData.GetLocalDrivingLicenseApplicationInfoByApplicationID(applicationID, ref LocalDrivingLicenseAppID, ref licenseClassId);

            if (isFound)
            {
                BuisnessApplication application = BuisnessApplication.FindBaseApplication(applicationID);

                return new LocalDrivingLicenseApplication(LocalDrivingLicenseAppID, licenseClassId,
                    applicationID, application.ApplicantPersonID, application.ApplicationDate,
                    application.ApplicationTypeId, application.ApplicationStatus, application.LastStatusDate,
                    application.PaidFees, application.CreatedByUserID);

            }
            else
                return null;
        }
        private bool _AddNewLocalDrivingLicenseApplication()
        {
            this.LocalDrivingLicenseAppID = LocalDrivingLicencesApplicationData.AddNewLocalDrivingLicenseApplication(this.ApplicationID, this.LicenseClassID);

            return this.LocalDrivingLicenseAppID != -1;
        }

        private bool _UpdateLocalDrivingLicenseApplication()
        {
            return LocalDrivingLicencesApplicationData.UpdateLocalDrivingLicenseApplication(this.LocalDrivingLicenseAppID,
                this.ApplicationID, this.LicenseClassID);
        }

        public bool Save()
        {

            base.Mode = (enBaseMode)_Mode;

            if (!base.Save())
                return false;


            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewLocalDrivingLicenseApplication())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }

                case enMode.Update:
                    return _UpdateLocalDrivingLicenseApplication();


            }

            return false;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return LocalDrivingLicencesApplicationData.GetAllLocalDrivingLicenseApplications();
        }

        public bool Delete()
        {
            bool IsLocalDrivingApplicationDeleted = false;
            bool IsBaseApplicationDeleted = false;
            //First we delete the Local Driving License Application
            IsLocalDrivingApplicationDeleted = LocalDrivingLicencesApplicationData.DeleteLocalDrivingLicenseApplication(this.LocalDrivingLicenseAppID);

            if (!IsLocalDrivingApplicationDeleted)
                return false;
            //Then we delete the base Application
            IsBaseApplicationDeleted = base.Delete();
            return IsBaseApplicationDeleted;
        }
        public static bool Delete(int LocalAppID)
        {
            LocalDrivingLicenseApplication app = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(LocalAppID);

            if (!LocalDrivingLicencesApplicationData.DeleteLocalDrivingLicenseApplication(LocalAppID))
                return false;

            return BuisnessApplication.Delete(app.ApplicationID);

        }

        public bool DoesAttendTestType(TestType.enTestType TestTypeID)
        {
            return LocalDrivingLicencesApplicationData.DoesAttendTestType(this.LocalDrivingLicenseAppID, (int)TestTypeID);
        }

        public byte TotalTrialsPerTest(TestType.enTestType TestTypeID)
        {
            return LocalDrivingLicencesApplicationData.TotalTrialsPerTest(this.LocalDrivingLicenseAppID, (int)TestTypeID);
        }

        public bool IsThereAnActiveScheduledTest(TestType.enTestType TestTypeID)
        {
            return LocalDrivingLicencesApplicationData.IsThereAnActiveScheduledTest(this.LocalDrivingLicenseAppID, (int)TestTypeID);
        }

        public bool DoesPassTestType(TestType.enTestType TestTypeID)
        {
            return LocalDrivingLicencesApplicationData.DoesPassTestType(this.LocalDrivingLicenseAppID, (int)TestTypeID);
        }

        public bool DoesPassPreviousTest(TestType.enTestType CurrentTestType)
        {

            switch(CurrentTestType)
            {
                case TestType.enTestType.Vision:
                    return true;

                case TestType.enTestType.WrittenTest:
                    return this.DoesPassTestType(TestType.enTestType.Vision);

                case TestType.enTestType.StreetTest:
                    return this.DoesPassTestType(TestType.enTestType.WrittenTest);

                default:
                    return false;
            }
        }

        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, TestType.enTestType TestTypeID)

        {
            return LocalDrivingLicencesApplicationData.DoesPassTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, TestType.enTestType TestTypeID)
        {
            return LocalDrivingLicencesApplicationData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }
        public static bool AttendedTest(int LocalDrivingLicenseApplicationID, TestType.enTestType TestTypeID)
        {
            return LocalDrivingLicencesApplicationData.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID) > 0;
        }

        public bool AttendedTest(TestType.enTestType TestTypeID)
        {
            return LocalDrivingLicencesApplicationData.TotalTrialsPerTest(this.LocalDrivingLicenseAppID, (int)TestTypeID) > 0;
        }

        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, TestType.enTestType TestTypeID)
        {

            return LocalDrivingLicencesApplicationData.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public Test GetLastTestPerTestType(TestType.enTestType TestTypeID)
        {
            return Test.FindLastTestPerPersonAndLicenseClass(this.ApplicantPersonID, TestTypeID, this.LicenseClassID);
        }

        public byte GetPassedTestCount()
        {
            return Test.GetPassedTestCount(this.LocalDrivingLicenseAppID);
        }

        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return Test.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        }

        public bool PassedAllTests()
        {
            return Test.PassedAllTests(this.LocalDrivingLicenseAppID);
        }

        public static bool PassedAllTests(int LocalDrivingLicenseApplicationID)
        {
            //if total passed test less than 3 it will return false otherwise will return true
            return Test.PassedAllTests(LocalDrivingLicenseApplicationID);
        }
        public int IssueLicenseForTheFirtTime(string Notes, int CreatedByUserID)
        {
            int DriverID = -1;

            Driver driver = Driver.FindByPersonID(this.ApplicantPersonID);

            if (driver == null)
            {
                //we check if the driver already there for this person.
                driver = new Driver();

                driver.PersonID = this.ApplicantPersonID;
                driver.CreatedByUser = CreatedByUserID;
                if (driver.Save())
                {
                    DriverID = driver.DriverID;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                DriverID = driver.DriverID;
            }
            //now we diver is there, so we add new licesnse

            License license = new License();
            license.ApplicationID = this.ApplicationID;
            license.DriverID = DriverID;
            license.LicenseClassID = this.LicenseClassID;
            license.IssueDate = DateTime.Now;
            license.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidateLength);
            license.Notes = Notes;
            license.PaidFees = this.LicenseClassInfo.PaidFees;
            license.IsActive = true;
            license.IssueReason = License.enIssueReason.FirstTime;
            license.CreatedByUserID = CreatedByUserID;

            if (license.Save())
            {
                //now we should set the application status to complete.
                this.SetComplete();

                return license.LicenseID;
            }

            else
                return -1;
        }

        public bool IsLicenseIssued()
        {
            return (GetActiveLicenseID() != -1);
        }
        public int GetActiveLicenseID()
        {//this will get the license id that belongs to this application
            return License.GetActiveLicenseIDByPersonID(this.ApplicantPersonID, this.LicenseClassID);
        }
  
    }
}
