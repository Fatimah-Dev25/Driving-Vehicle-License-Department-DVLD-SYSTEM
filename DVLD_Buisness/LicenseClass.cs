using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DVLD_DataAccess;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DVLD_Buisness
{
    public class LicenseClass
    {
        public int LicenseClassID { set; get; }
        public string LicenseName { set; get; }
        public string LicenseDescription { set; get; }
        public byte LicenseMinAllowedAge { set; get; }
        public byte DefaultValidateLength { set; get; }
        public float PaidFees { set; get; }

        public static DataTable GetAllLicenseClasses()
        {
            return LicenseClassData.GetAllLicenseClasses();
        }

        public LicenseClass()
        {
            LicenseClassID = -1;
            LicenseName = "";
            LicenseDescription = "";
            LicenseMinAllowedAge = 0;
            DefaultValidateLength = 0;
            PaidFees = 0;
        }

        private LicenseClass(int licenseClassID, string licenseName, string licenseDescription, byte licenseMinAllowedAge,
            byte defaultValidateLength, float paidFees)
        {
            LicenseClassID = licenseClassID;
            LicenseName = licenseName;
            LicenseDescription = licenseDescription;
            LicenseMinAllowedAge = licenseMinAllowedAge;
            DefaultValidateLength = defaultValidateLength;
            PaidFees = paidFees;
        }

        public static LicenseClass Find(int LicenseClassID)
        {
            string licName = "", licDes = "";
            byte licMinAge = 0, licValidateLength = 0;
            float paidFees = 0;

            if (LicenseClassData.GetLicenseClassInfoByID(LicenseClassID, ref licName, ref licDes,
                 ref licMinAge, ref licValidateLength, ref paidFees))
            {
                return new LicenseClass(LicenseClassID, licName, licDes, licMinAge, licValidateLength, paidFees);
            }
            else
                return null;
        }

        public static LicenseClass Find(string LicenseClassName)
        {
            int LicenseClassID = -1;
            string licDes = "";
            byte licMinAge = 0, licValidateLength = 0;
            float paidFees = 0;

            if (LicenseClassData.GetLicenseClassInfoByName(LicenseClassName, ref LicenseClassID, ref licDes,
                 ref licMinAge, ref licValidateLength, ref paidFees))
            {
                return new LicenseClass(LicenseClassID, LicenseClassName, licDes, licMinAge, licValidateLength, paidFees);
            }
            else
                return null;
        }

    }


}
