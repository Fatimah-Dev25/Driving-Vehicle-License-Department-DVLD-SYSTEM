using System;
using System.Collections.Generic;
using System.Data;
using DVLD_DataAccess;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class User
    {
        enum enMode { AddNew =0, Update = 1 }
        private enMode _Mode;
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }

        Person _Person;
        public User() { 
        
            _Mode = enMode.AddNew;
            UserID = -1;
            PersonID = -1;
            UserName = "";
            Password = "";
            isActive = true;
        }
        private User(int userID, int personID, string userName, string password, bool isActive)
        {
            _Mode = enMode.Update;
            UserID = userID;
            PersonID = personID;
            UserName = userName;
            Password = password;
            this.isActive = isActive;
            _Person = Person.Find(PersonID);
        }
        public static DataTable GetAllUsers()
        {
            return UserData.GetAllUsers();
        }
        public static bool isUserExist(int _UserID)
        {
            return UserData.IsUserExist(_UserID);
        }
        public static bool isUserExist(string _UserName)
        {
            return UserData.IsUserExist(_UserName);
        }
        public static bool isUserExistForPerson(int _PersonID)
        {
            return UserData.IsUserExistForPersonID(_PersonID);
        }
        public static User FindByUserID(int _UserID)
        {
            string UserName = "", Password = "";
            int PersonID = -1;
            bool isActive = false;

            if(UserData.GetUserInfoByUserID(_UserID, ref PersonID, ref UserName, ref Password, ref isActive))
            {
                return new User(_UserID, PersonID, UserName, Password, isActive);
            }
            else 
                return null;
        }
        public static User FindByPersonID(int _PersonID)
        {
            string UserName = "", Password = "";
            int UserID = -1;
            bool isActive = false;

            if (UserData.GetUserInfoByPersonID(_PersonID, ref UserID, ref UserName, ref Password, ref isActive))
            {
                return new User(UserID, _PersonID, UserName, Password, isActive);
            }
            else
                return null;
        }
        public static User FindByUserNameAndPassword(string _UserName, string _Password)
        {
            int UserID = -1, PersonID = -1;
            bool isActive = false;

            if (UserData.GetUserInfoByUserNameAndPassword(ref PersonID, ref UserID, _UserName, _Password, ref isActive))
            {
                return new User(UserID, PersonID, _UserName, _Password, isActive);
            }
            else
                return null;
        }
        public static bool Delete(int _UserID)
        {
            return UserData.DeleteUser(_UserID);
        }
        private bool _AddNewUser()
        {
            this.UserID = UserData.AddNewUser(this.UserName, this.Password, this.PersonID, this.isActive);

            return this.UserID != -1;
        }
        private bool _UpdateUser()
        {
            return UserData.UpdateUser(this.UserID, this.UserName, this.Password, this.PersonID, this.isActive);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                   if(_AddNewUser())
                    {
                        _Mode = enMode.AddNew;
                        return true;
                    }
                   else
                        return false;
                    

                case enMode.Update:
                    return _UpdateUser();

            }
            return false;
        }

        public bool ChangePassword(string newPassword)
        {
            return UserData.ChangePassword(this.UserID, newPassword);
        }

    }
}
