using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class Driver
    {
        enum enMode { AddNew, Update }
        enMode _Mode = enMode.AddNew;
        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByUser { get; set; }
        public DateTime CreatedDate { get; set; }

        public Person PersonInfo;
        public Driver()
        {
            _Mode = enMode.AddNew;
            DriverID = -1;
            PersonID = -1;
            CreatedByUser = -1;
            CreatedDate = DateTime.Now;
        }
        private Driver(int driverID, int personID, int createdByUser, DateTime createdDate)
        {
            _Mode = enMode.Update;
            DriverID = driverID;
            PersonID = personID;
            CreatedByUser = createdByUser;
            CreatedDate = createdDate;

            PersonInfo = Person.Find(personID);
        }

        public static Driver FindByID(int driverID)
        {
            int personId = -1, userID = -1;
            DateTime createdDate = DateTime.Now;

            if (DriverData.GetDriverInfoByID(driverID, ref personId, ref userID, ref createdDate))
            {
                return new Driver(driverID, personId, userID, createdDate);
            }
            else
                return null;
        }

        public static Driver FindByPersonID(int personID)
        {
            int driverId = -1, userID = -1;
            DateTime createdDate = DateTime.Now;

            if (DriverData.GetDriverInfoByPersonID(personID, ref driverId, ref userID, ref createdDate))
            {
                return new Driver(driverId, personID, userID, createdDate);
            }
            else
                return null;
        }

        public static DataTable GetAllDriveres()
        {
            return DriverData.GetAllDrivers();
        }

        private bool _AddNewDriver()
        {
            this.DriverID = DriverData.AddNewDriver(this.PersonID, this.CreatedByUser);
            return this.DriverID != -1;
        }

        private bool _UpdateDriverInfo()
        {
            return DriverData.UpdateDriverInfo(this.DriverID, this.PersonID, this.CreatedByUser, this.CreatedDate);
        }
        public bool Save()
        {

            switch (_Mode)
            {

                case enMode.AddNew:
                    {
                        if (_AddNewDriver())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.Update:
                    return _UpdateDriverInfo();
            }

            return false;
        }

        public static DataTable GetLicenses(int DriverID)
        {
            return License.GetDriverLicenses(DriverID);
        }

        public static DataTable GetDriverInternationalLicenses(int driverId)
        {
            return InternationalLicense.GetDriverInternationalLicenses(driverId);
        }

    }
}
