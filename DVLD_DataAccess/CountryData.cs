using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class CountryData
    {
        public static bool GetCountryInfoByID(int CountryID, ref string CountryName) {
        
            bool isFound = false;
            SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);

            string query = "select CountryName from Countries where CountryID = @CountryID";
            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try {
            
                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;
                    CountryName = reader["CountryName"].ToString();
                }
                reader.Close();

            }catch (Exception ex) {
            
                isFound = false;
            
            } finally { connectToDB.Close(); }

            return isFound;
        }
        public static bool GetCountryInfoByName(string CountryName, ref int CountryID) {

            bool isFound = false;
            SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);

            string query = "select * from Countries where CountryName = @CountryName";
            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {

                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    CountryID = (int)reader["CountryID"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {

                isFound = false;

            }
            finally { connectToDB.Close(); }

            return isFound;
        }
        public static DataTable GetAllCountries() { 
        
            DataTable AllCountries = new DataTable();

            SqlConnection connect2DB = new SqlConnection(DataAccessSettings.stConnection);

            string query = "select * from Countries order by CountryName;";
            SqlCommand command = new SqlCommand(query, connect2DB);

            try {
            
                connect2DB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    AllCountries.Load(reader);
                }
                reader.Close();

            }catch (Exception ex) { 
            
            } finally { connect2DB.Close(); }

            return AllCountries;
        }
    }
}
