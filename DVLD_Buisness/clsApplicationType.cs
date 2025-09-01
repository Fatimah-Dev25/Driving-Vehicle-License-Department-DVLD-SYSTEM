using System;
using System.Collections.Generic;
using System.Data;
using DVLD_DataAccess;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class clsApplicationType
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;
        public int AppTypeID { get; set; }
        public string AppTitleType { get; set; }
        public float AppTypeFee { get; set; }

        public clsApplicationType() { 
        
            _Mode = enMode.AddNew;
            AppTypeID = -1;
            AppTitleType = "";
            AppTypeFee = 0;
        }

        private clsApplicationType(int appTypeID, string appTitleType, float appTypeFee)
        {
            _Mode = enMode.Update;
            AppTypeID = appTypeID;
            AppTitleType = appTitleType;
            AppTypeFee = appTypeFee;
        }
        public static DataTable GetAllApplicationTypes()
        {
            return ApplicationTypeData.GetAllAplicationTypes();
        }

        private bool _AddNewApplicationType()
        {
            this.AppTypeID = ApplicationTypeData.AddNewApplicationType(this.AppTitleType, this.AppTypeFee);

            return this.AppTypeID != -1;
        }
        private bool _UpdateApplicationType()
        {
            return ApplicationTypeData.UpdateApplicationType(this.AppTypeID, this.AppTitleType, this.AppTypeFee);
        }

        public bool Save()
        {
            switch(_Mode) { 
            
                case enMode.AddNew:
                    {
                        if (_AddNewApplicationType())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                        
                    }
                case enMode.Update:
                    return _UpdateApplicationType();
            }

            return false;
        }
    
        public static clsApplicationType Find(int AppID)
        {
            string AppTitle = "";
            float appFees = 0;

            if(ApplicationTypeData.GetApplicationTypeInfoByID(AppID, ref AppTitle, ref appFees))
                return new clsApplicationType(AppID, AppTitle, appFees);
            else
                return null;
        }
    }
}
