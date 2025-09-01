using System;
using System.Collections.Generic;
using DVLD_DataAccess;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class BuisnessApplication
    {

        public enum enBaseMode { AddNew = 0, Update = 1 }
        public enum enApplicationType {
    
            NewLocalDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5,
            NewInternationalLicense = 6, RetakeTest = 7

        }

        public enApplicationType AppType;
        public enum enApplicationStatus
        {
            New = 1, Cancelled = 2, Completed = 3
        }

        public enBaseMode Mode;
        public int ApplicationID { set; get; }
        public int ApplicantPersonID { set; get; }

        public Person PersonInfo;
        public string ApplicantFullName
        {
            get { return PersonInfo?.FullName(); }
        }
        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeId { set; get; }

        public clsApplicationType ApplicationType;
        public enApplicationStatus ApplicationStatus { set; get; }
        public string StatusText
        {
            get
            {
                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";

                    case enApplicationStatus.Cancelled:
                        return "Cancelled";

                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }
        }
        public DateTime LastStatusDate { set; get; }
        public float PaidFees { set; get; }
        public int CreatedByUserID { set; get; }

        public User CreatedByUserInfo;

        public BuisnessApplication()
        {
            Mode = enBaseMode.AddNew;
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationTypeId = -1;
            ApplicationStatus = enApplicationStatus.New;
            ApplicationDate = DateTime.Now;
            LastStatusDate = DateTime.Now;
            CreatedByUserID = -1;
            PaidFees = 0;

        }
    
        private BuisnessApplication(int applicationID, int applicantPersonID, DateTime applicationDate,
            int applicationTypeId, enApplicationStatus applicationStatus, DateTime lastStatusDate,
            float paidFees, int createdByUserID)
        {
            Mode = enBaseMode.Update;
            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            PersonInfo = Person.Find(applicantPersonID);
            ApplicationDate = applicationDate;
            ApplicationTypeId = applicationTypeId;
            ApplicationType = clsApplicationType.Find(applicationTypeId);
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            CreatedByUserInfo = User.FindByUserID(createdByUserID);
        }

        public static BuisnessApplication FindBaseApplication(int AppID)
        {
            int appPersonId = -1, appTypeID = -1, appUser = -1;
            byte appStatus = 0;
            float paidFees = 0;
            DateTime appDate = DateTime.Now, appLastStatusDate = DateTime.Now;

            if(ApplicationData.GetApplicationInfoByID(AppID, ref appPersonId, ref appDate,
                 ref appLastStatusDate, ref appTypeID, ref appStatus, ref paidFees, ref appUser))
            {
                return new BuisnessApplication(AppID, appPersonId, appDate, appTypeID, (enApplicationStatus)appStatus, appLastStatusDate, paidFees, appUser);
            }
            else
                return null;
        }

        private bool _AddNewApplication()
        {
            this.ApplicationID = ApplicationData.AddNewApplication(this.ApplicantPersonID,
                this.ApplicationDate, this.ApplicationTypeId, (byte)this.ApplicationStatus,
                this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return this.ApplicationID != -1;
        }

        private bool _UpdateApplicationInfo() {

            return ApplicationData.UpdateApplication(this.ApplicationID, this.ApplicantPersonID,
                this.ApplicationDate, this.LastStatusDate, this.ApplicationTypeId, (byte)this.ApplicationStatus,
                this.PaidFees, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enBaseMode.AddNew:
                    {
                        if (_AddNewApplication())
                        {
                            Mode = enBaseMode.Update;
                            return true;
                        }
                        else
                        { return false; }
                    }
                 case enBaseMode.Update:
                    {
                        return _UpdateApplicationInfo();
                    }

            }

            return false;
        }
        public bool Cancel()
        {
            return ApplicationData.UpdateApplicationStatus(this.ApplicationID, 2);
        }

        public bool SetComplete()
        {
            return ApplicationData.UpdateApplicationStatus(this.ApplicationID, 3);
        }

        public bool Delete()
        {
            return ApplicationData.DeleteApplication(this.ApplicationID);
        }

        public static bool Delete(int AppID)
        {
            return ApplicationData.DeleteApplication(AppID);

        }
        public static bool isApplicationExists(int AppID)
        {
            return ApplicationData.isApplicationExists(AppID);
        }

        public static bool DoesPersonHaveActiveApplication(int appPersonID, int appTypeID)
        {
            return ApplicationData.DoesPersonHaveActiveApplication(appPersonID, appTypeID);
        }

        public bool DoesPersonHaveActiveApplication(int AppTypeID)
        {
            return ApplicationData.DoesPersonHaveActiveApplication(this.ApplicantPersonID, AppTypeID);
        }

        public static int GetActiveApplicationID(int appPersonID, BuisnessApplication.enApplicationType appType)
        {
            return ApplicationData.GetActiveApplicationID(appPersonID, (int)appType);
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonId, BuisnessApplication.enApplicationType appType, int appLicenseClass)
        {
            return ApplicationData.GetActiveApplicationIDForLicenseClass(PersonId, (int)appType, appLicenseClass);
        }

        public int GetActiveApplicationID(BuisnessApplication.enApplicationType appType)
        {
            return GetActiveApplicationID(this.ApplicantPersonID, appType);
        } 
    }
}
