using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class License
    {
        enum enMode { AddNew, Update}
        enMode _Mode;

        public enum enIssueReason
        {
            FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4
        }

        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public float PaidFees { get; set; }
        public bool IsActive { get; set; }
        public enIssueReason IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public Driver DriverInfo;
        public DetainedLicense DetainInfo { get; set; }

        public LicenseClass LicenseClassInfo;
        public string IssueReasonText
        {
            get
            {
                return GetIssueReasonText(this.IssueReason);
            }
        }

        private string GetIssueReasonText(enIssueReason reason)
        {
            switch (reason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";

                case enIssueReason.Renew:
                    return "Renew";

                case enIssueReason.DamagedReplacement:
                    return "Replacement for Damaged";

                case enIssueReason.LostReplacement:
                    return "Replacement for Lost";

                default:
                    return "First Time";
            }
        }
        public License()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClassID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = "";
            PaidFees = 0;
            IsActive = false;
            IssueReason = enIssueReason.FirstTime;
            CreatedByUserID = -1;


            _Mode = enMode.AddNew;
        }

        private License(int licenseID, int applicationID, int driverID, int licenseClassID, DateTime issueDate, DateTime expirationDate, string notes, float paidFees, bool isActive, enIssueReason issueReason, int createdByUserID)
        {
            _Mode = enMode.Update;

            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClassID = licenseClassID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
            DriverInfo = Driver.FindByID(DriverID);
            LicenseClassInfo = LicenseClass.Find(LicenseClassID);
            DetainInfo = DetainedLicense.FindByLicenseID(this.LicenseID);
        }

        public static DataTable GetAllLicenses()
        {
            return LicenseData.GetAllLicenses();
        }

        public static License Find(int licenseID)
        {
            int applicationID = -1, driverID = -1, licenseClassID = -1, createdByUser = -1;
            DateTime issueDate = DateTime.Now, expirationDate = DateTime.Now;
            string notes = "";
            float paidFees = 0;
            bool isActive = false;
            byte issueReason = 0;

            if(LicenseData.GetLicenseInfoByID(licenseID, ref applicationID, ref driverID, ref licenseClassID,
                ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref issueReason,ref createdByUser))
            {
                return new License(licenseID,applicationID, driverID, licenseClassID, issueDate, expirationDate, notes,
                    paidFees, isActive, (enIssueReason)issueReason, createdByUser);
            }
            else
                return null;
        }

        public static bool DeActiveLicense(int licenseID)
        {
            return LicenseData.DeActivateLicense(licenseID);

        }
        public bool DeActiveCurrentLicense()
        {
            return LicenseData.DeActivateLicense(this.LicenseID);
        }

        private bool _AddLicense()
        {
            this.LicenseID =  LicenseData.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate,
                this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);
        
            return this.LicenseID != -1;
        }

        private bool _UpdateLicense()
        {
            return LicenseData.UpdateLicenseInfo(this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClassID, this.IssueDate,
                 this.ExpirationDate, this.Notes, this.PaidFees, this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);

        }

        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if(_AddLicense())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else { return false; }
                    }

                case enMode.Update:
                    return _UpdateLicense();
            }

            return false;
        }

        public static DataTable GetDriverLicenses(int DriverID)
        {
            return LicenseData.GetDriverLicenses(DriverID);
        }

        public static int GetActiveLicenseIDByPersonID(int PersonId, int LicenseClassID)
        {
            return LicenseData.GetActiveLicenseIDByPersonID(PersonId, LicenseClassID);
        }

        public static bool IsLicenseExistByPersonID(int personId, int licenseClassId)
        {
            return GetActiveLicenseIDByPersonID(personId,licenseClassId) != -1;
        }

        public bool IsLicenseExpired()
        {
            return this.ExpirationDate < DateTime.Now;

        }

        public bool DeactivateCurrentLicense()
        {
            return DeActiveLicense(this.LicenseID);
        }
        public License RenewLicense(string Notes, int CreatedByUserID)
        {

            //First Create Applicaiton 
            BuisnessApplication renewApplication = new BuisnessApplication();
            renewApplication.ApplicantPersonID = this.DriverInfo.PersonID;
            renewApplication.ApplicationTypeId = (int)BuisnessApplication.enApplicationType.RenewDrivingLicense;
            renewApplication.ApplicationStatus = BuisnessApplication.enApplicationStatus.Completed;
            renewApplication.LastStatusDate = DateTime.Now;
            renewApplication.PaidFees = clsApplicationType.Find(renewApplication.ApplicationTypeId).AppTypeFee;
            renewApplication.CreatedByUserID = CreatedByUserID;

            if (!renewApplication.Save())
            {
                return null;
            }

            License newLicense = new License();

            newLicense.ApplicationID = renewApplication.ApplicationID;
            newLicense.DriverID = this.DriverID;
            newLicense.LicenseClassID = this.LicenseClassID;
            newLicense.IssueDate = DateTime.Now;
            newLicense.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidateLength);
            newLicense.Notes = Notes;
            newLicense.PaidFees = this.LicenseClassInfo.PaidFees;
            newLicense.IsActive = true;
            newLicense.IssueReason = enIssueReason.Renew;
            newLicense.CreatedByUserID = CreatedByUserID;

            if (!newLicense.Save())
            {
                return null;
            }

            DeactivateCurrentLicense();

            return newLicense;
        }

        public License Replace(enIssueReason issueReason, int createdUserBy)
        {

            BuisnessApplication application = new BuisnessApplication();

            application.ApplicantPersonID = this.DriverInfo.PersonID;
            application.ApplicationDate = DateTime.Now;
            application.LastStatusDate = DateTime.Now;
            application.ApplicationStatus = BuisnessApplication.enApplicationStatus.Completed;
            application.ApplicationTypeId = issueReason == enIssueReason.DamagedReplacement ? (int)BuisnessApplication.enApplicationType.ReplaceDamagedDrivingLicense : (int)BuisnessApplication.enApplicationType.ReplaceLostDrivingLicense;
            application.CreatedByUserID = createdUserBy;
            application.PaidFees = clsApplicationType.Find(application.ApplicationTypeId).AppTypeFee;

            if (!application.Save())
            {
                return null;
            }

            License newLicense = new License();
            newLicense.ApplicationID = application.ApplicationID;
            newLicense.DriverID = this.DriverID;
            newLicense.LicenseClassID = this.LicenseClassID;
            newLicense.IssueDate = DateTime.Now;
            newLicense.ExpirationDate = this.ExpirationDate;
            newLicense.IssueReason = issueReason;
            newLicense.IsActive = true;
            newLicense.CreatedByUserID = createdUserBy;
            newLicense.Notes = this.Notes;
            newLicense.PaidFees = 0;

            if (!newLicense.Save())
            {
                return null;
            }

            DeactivateCurrentLicense();

            return newLicense;

        }

        public bool isDetained()
        {
            return DetainedLicense.IsLicenseDetained(this.LicenseID);
        }

        public int Detain(float FineFees, int CreatedByUserID)
        {
            DetainedLicense detainLicense = new DetainedLicense();

            detainLicense.DetainedDate = DateTime.Now;
            detainLicense.CreatedByUserID = CreatedByUserID;
            detainLicense.FineFees = FineFees;
            detainLicense.LicenseID = this.LicenseID;

            if (!detainLicense.Save())
            {
                return -1;
            }

            return detainLicense.DetainedID;
        }

        public bool ReleaseDetainedLicense(int releasedByUserID, ref int applicationId)
        {

            //First Create Applicaiton 
            BuisnessApplication Application = new BuisnessApplication();

            Application.ApplicantPersonID = this.DriverInfo.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeId = (int)BuisnessApplication.enApplicationType.ReleaseDetainedDrivingLicsense;
            Application.ApplicationStatus = BuisnessApplication.enApplicationStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType.Find((int)BuisnessApplication.enApplicationType.ReleaseDetainedDrivingLicsense).AppTypeFee;
            Application.CreatedByUserID = releasedByUserID;

            if (!Application.Save())
            {
                applicationId = -1;
                return false;
            }

            applicationId = Application.ApplicationID;


            return this.DetainInfo.ReleaseDetainedLicense(releasedByUserID, Application.ApplicationID);

        }
    }
}
