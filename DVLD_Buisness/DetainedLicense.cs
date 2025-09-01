using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class DetainedLicense
    {
        enum enMode { AddNew, Update}
        enMode _Mode = enMode.AddNew;
    
        public int DetainedID { get; set; }
        public int LicenseID { get; set; }

        public DateTime DetainedDate { get; set; }

        public float FineFees { get; set; }

        public bool IsReleased { get; set; }    

        public int CreatedByUserID { get; set; }

        public DateTime ReleasedDate { get; set; }

        public int ReleasedByUserID { get; set; }

        public int ReleaseadApplicationID { get; set; }
       
        public DetainedLicense()
        {
            _Mode = enMode.AddNew;
            DetainedID = -1;
            LicenseID = -1;
            DetainedDate = DateTime.Now;
            CreatedByUserID = -1;
            ReleasedDate = DateTime.Now;
            IsReleased = false;
            FineFees = 0;
            ReleasedByUserID = -1;
            ReleaseadApplicationID = -1;
        }
        private DetainedLicense(int detainedID, int licenseID, DateTime detainedDate, float fineFees, bool isReleased, int createdByUserID, DateTime releasedDate, int releasedByUserID, int releaseadApplicationID)
        {
            _Mode = enMode.Update;
            DetainedID = detainedID;
            LicenseID = licenseID;
            DetainedDate = detainedDate;
            FineFees = fineFees;
            IsReleased = isReleased;
            CreatedByUserID = createdByUserID;
            ReleasedDate = releasedDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseadApplicationID = releaseadApplicationID;
        }
        private bool _AddNewDetainedLicense()
        {
            this.DetainedID = DetainedLicenseData.AddNewDetainedLicense(this.LicenseID, this.DetainedDate, this.FineFees,
                this.CreatedByUserID);

            return this.DetainedID != -1;
        }
        private bool _UpdateDetainedLicense()
        {
            return DetainedLicenseData.UpdateDetainedLicense(this.DetainedID, this.LicenseID, this.DetainedDate,
                this.FineFees, this.CreatedByUserID);
        }
        public bool Save()
        {

            switch(_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewDetainedLicense())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.Update:
                    return _UpdateDetainedLicense();

            }

            return false;
        }

        public static DataTable GetAllDetainedLicenses()
        {

            return DetainedLicenseData.GetAllDetainedLicenses();
        }

        public static DetainedLicense Find(int DetainedID)
        {
            int licenseId = -1, createdByUser = -1, releasedUserId = -1, releasedAppID = -1;
            DateTime detainedDate = DateTime.Now, ReleasedDate = DateTime.Now;
            bool isReleased = false;
            float fineFees = 0;

            if (DetainedLicenseData.GetDetainedLicenseInfoByID(DetainedID, ref licenseId, ref detainedDate, ref fineFees,
                ref createdByUser, ref isReleased, ref ReleasedDate, ref releasedUserId, ref releasedAppID))
                return new DetainedLicense(DetainedID, licenseId, detainedDate, fineFees, isReleased, createdByUser,
                    ReleasedDate, releasedUserId, releasedAppID);
            else
                return null;
        }
        public static DetainedLicense FindByLicenseID(int LicenseID)
        {
            int detainedID = -1, createdByUser = -1, releasedUserId = -1, releasedAppID = -1;
            DateTime detainedDate = DateTime.Now, ReleasedDate = DateTime.Now;
            bool isReleased = false;
            float fineFees = 0;

            if (DetainedLicenseData.GetDetainedLicenseInfoByLicenseID(LicenseID, ref detainedID, ref detainedDate, ref fineFees,
                ref createdByUser, ref isReleased, ref ReleasedDate, ref releasedUserId, ref releasedAppID))
                return new DetainedLicense(detainedID, LicenseID, detainedDate, fineFees, isReleased, createdByUser,
                    ReleasedDate, releasedUserId, releasedAppID);
            else
                return null;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return DetainedLicenseData.IsLicenseDetained(LicenseID);
        }

        public bool ReleaseDetainedLicense(int releasedByUserID, int releasedAppID)
        {
            return DetainedLicenseData.ReleaseDetainedLicense(this.DetainedID, releasedByUserID, releasedAppID);
        }
    }
}
