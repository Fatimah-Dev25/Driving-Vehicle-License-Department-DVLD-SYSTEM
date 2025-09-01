using DVLD_DataAccess;
using System;
using System.Data;


namespace DVLD_Buisness
{
    public class Person
    {
        enum Mode { AddNew = 1, Update = 2}

        private Mode _Mode = Mode.AddNew;
        public int PersonID { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string NationalNum { set; get; } 
        public DateTime DateOfBirth { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string ImagePath { set; get; }
        public byte Gender { set; get; }
        public int NatCountryID { set; get; }
        public Country Nationality;
        public string FullName(){

            return FirstName + " " + SecondName + " " + LastName; 
        }
        public Person() {

            PersonID = -1;
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            Email = "";
            Phone = "";
            Address = "";
            ImagePath = "";
            NatCountryID = -1;
            DateOfBirth = DateTime.Now;
            Gender = 0;
            _Mode = Mode.AddNew;
        }
        private Person(int personID, string firstName, string secondName, string thirdName,
            string lastName, string nationalNum, DateTime dateOfBirth, string phone,
            string email, string address, string imagePath, byte gender, int natCountryID)
        {
            _Mode = Mode.Update;
            PersonID = personID;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            NationalNum = nationalNum;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            Email = email;
            Address = address;
            ImagePath = imagePath;
            Gender = gender;
            NatCountryID = natCountryID;
            Nationality = Country.Find(natCountryID);
        }
        private bool _UpdatePersonInfo()
        {
            return PersonData.UpdatePerson(this.PersonID, this.NationalNum, this.FirstName,
                this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender,
                this.Address, this.Phone, this.Email, this.NatCountryID, this.ImagePath);
        }
        private bool _AddNewPerson()
        {
            this.PersonID = PersonData.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.NationalNum, this.Phone, this.Email, this.Address, this.Gender, this.DateOfBirth,
                this.ImagePath, this.NatCountryID);

            return PersonID != -1;
        }
        public bool Save()
        {

            switch (_Mode) {
                case Mode.Update:
                    return _UpdatePersonInfo();

                case Mode.AddNew:
                    {
                        if(_AddNewPerson())
                        {
                            _Mode = Mode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
            }

            return false;
        }
        public static Person Find(int _ID)
        {
            string FName = "", SecName = "", ThiName = "", LName = "", natNo = "", email = "", phone = "",
                imgPath = "", address = "";
            byte gender = 0;
            DateTime dateTime = DateTime.Now;
            int natCountryId = -1;

            if (PersonData.GetPersonInfoByID(_ID, ref natNo, ref FName, ref SecName, ref ThiName, ref LName,
                ref dateTime, ref gender, ref address, ref phone, ref email, ref natCountryId, ref imgPath))
            
                return new Person(_ID, FName, SecName, ThiName, LName, natNo, dateTime, phone, email,
                    address, imgPath, gender, natCountryId);
            else
                return null;
        }
        public static Person Find(string _NatNO)
        {
            string FName = "", SecName = "", ThiName = "", LName = "", email = "", phone = "",
                imgPath = "", address = "";
            byte gender = 0;
            DateTime dateTime = DateTime.Now;
            int natCountryId = -1, personID = -1;

            if (PersonData.GetPersonInfoByNatNum(_NatNO, ref personID, ref FName, ref SecName, ref ThiName, ref LName,
                ref phone, ref gender, ref dateTime, ref email, ref address, ref imgPath, ref natCountryId))
             
                return new Person(personID, FName, SecName, ThiName, LName, _NatNO, dateTime, phone, email,
                    address, imgPath, gender, natCountryId);
            else
                return null;
        }
        public static DataTable GetAllPeople()
        {
            return PersonData.GetAllPeople();
        }
        public static bool DeletePerson(int _ID)
        {
            return PersonData.DeletePerson(_ID);
        }
        public static bool IsPersonExist(int _ID)
        {
            return PersonData.IsPersonExist(_ID);
        }
        public static bool IsPersonExist(string _NationalNo)
        {
            return PersonData.IsPersonExist(_NationalNo);
        }
    }
}
