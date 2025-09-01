using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public Country() { 
        
            CountryID = -1;
            CountryName = "";
        }
        private Country(int countryId, string countryName)
        {
            CountryID = countryId;
            CountryName = countryName;
        }
        public static Country Find(int CountryId)
        {
            string CountryName = "";

            if (CountryData.GetCountryInfoByID(CountryId, ref CountryName))
                return new Country(CountryId, CountryName);
            else 
                return null;
        }

        public static Country Find(string CountryName)
        {
            int CountryID = -1;

            if (CountryData.GetCountryInfoByName(CountryName, ref CountryID))
                return new Country(CountryID, CountryName);
            else
                return null;
        }

        public static DataTable GetAllCountries()
        {
            return CountryData.GetAllCountries();
        }
    }
}
