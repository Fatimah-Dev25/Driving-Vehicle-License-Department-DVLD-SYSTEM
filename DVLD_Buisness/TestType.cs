using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD_Buisness
{
    public class TestType
    {
        enum enMode { AddNew = 0, Update = 1}
        public enum enTestType { Vision = 1, WrittenTest = 2, StreetTest = 3}
        enMode _Mode;
        public TestType.enTestType TestTypeID    { get; set; } 
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public float TestTypeFees { get; set; }

        public TestType() { 
        
            _Mode = enMode.AddNew;
            this.TestTypeID = enTestType.Vision;
            TestTypeTitle = "";
            TestTypeDescription = "";
            TestTypeFees = 0;
        }

        public TestType(TestType.enTestType testTypeID, string testTypeTitle, string testTypeDescription, float testTypeFees)
        {
            _Mode = enMode.Update;
            TestTypeID = testTypeID;
            TestTypeTitle = testTypeTitle;
            TestTypeDescription = testTypeDescription;
            TestTypeFees = testTypeFees;
        }

        public static DataTable GetAllTestTypes()
        {
            return TestTypeData.GetAllTestTypes();
        }
        public static TestType Find(TestType.enTestType testTypeID)
        {
            string title = "", description = "";
            float fees = 0;

            if (TestTypeData.GetTestTypeInfoByID((int)testTypeID, ref title, ref description, ref fees))
                return new TestType(testTypeID, title, description, fees);
            else
                return null;
        }

        private bool _AddNewTestType()
        {
            this.TestTypeID = (enTestType)TestTypeData.AddNewTestType(this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);

            return this.TestTypeTitle != "";
        }

        private bool _UpdateTestType()
        {
            return TestTypeData.UpdateTestType((int)this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestType())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }else
                        return false;
                case enMode.Update:
                    return _UpdateTestType();
            }
            return false;
        }


    }
}
