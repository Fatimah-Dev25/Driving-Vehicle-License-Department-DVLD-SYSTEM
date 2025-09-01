using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class LicenseClassData
    {

        static SqlConnection connect2DB = new SqlConnection(DataAccessSettings.stConnection);

        public static DataTable GetAllLicenseClasses()
        {
            DataTable dt = new DataTable();

            string query = "select * from LicenseClasses;";
            SqlCommand command = new SqlCommand(query, connect2DB);

            try {
            
                connect2DB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
            
                reader.Close();
            } catch (Exception ex)
            {

            }
            finally
            {
                connect2DB.Close();
            }

            return dt;
        }

        public static bool GetLicenseClassInfoByID(int ClassID, ref string ClassName, ref string ClassDes,
            ref byte MinAllowedAge, ref byte ValidateLength, ref float PaidFees)
        {
            bool isFound = false;

            string query = "select * from LicenseClasses where LicenseClassID = @licenseClassId;";
            SqlCommand command = new SqlCommand(query, connect2DB);
            command.Parameters.AddWithValue("@licenseClassId", ClassID);

            try
            {

                connect2DB.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read()) {
                
                    isFound = true;
                    ClassName = (string)reader["ClassName"];
                    ClassDes = (string)reader["ClassDescription"];
                    MinAllowedAge = (byte)reader["MinimumAllowedAge"];
                    ValidateLength = (byte)reader["DefaultValidityLength"];
                    PaidFees = Convert.ToSingle(reader["ClassFees"]);
                }
                reader.Close();

            }catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connect2DB.Close();
            }

            return isFound;
        }

        public static bool GetLicenseClassInfoByName(string ClassName, ref int ClassID, ref string ClassDes,
           ref byte MinAllowedAge, ref byte ValidateLength, ref float PaidFees)
        {
            bool isFound = false;

            string query = "select * from LicenseClasses where ClassName = @licenseClassName;";
            SqlCommand command = new SqlCommand(query, connect2DB);
            command.Parameters.AddWithValue("@licenseClassName", ClassName);

            try
            {

                connect2DB.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    ClassID = (int)reader["LicenseClassID"];
                    ClassDes = (string)reader["ClassDescription"];
                    MinAllowedAge = (byte)reader["MinimumAllowedAge"];
                    ValidateLength = (byte)reader["DefaultValidityLength"];
                    PaidFees = Convert.ToSingle(reader["ClassFees"]);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connect2DB.Close();
            }

            return isFound;
        }

    }
}
