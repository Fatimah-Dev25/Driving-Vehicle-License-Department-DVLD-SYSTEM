using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class ApplicationTypeData
    {
        public static DataTable GetAllAplicationTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataAccessSettings.stConnection);
            
            string query = "select * from ApplicationTypes order by ApplicationTypeTitle;";
            SqlCommand command = new SqlCommand(query, conn);

            try { 
            
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }catch(Exception ex) {
            
            } finally { conn.Close(); }

            return dt;
        }

        public static bool GetApplicationTypeInfoByID(int AppID, ref string AppTypeTitle, ref float AppFees)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(DataAccessSettings.stConnection);

            string cmd = "select * from ApplicationTypes where ApplicationTypeID = @AppId;";
            SqlCommand command = new SqlCommand(cmd, conn);
            command.Parameters.AddWithValue("@AppId", AppID);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    AppTypeTitle = (string)reader["ApplicationTypeTitle"];
                    AppFees = Convert.ToSingle(reader["ApplicationFees"]);
                }
                else
                    isFound = false;

                reader.Close();
            }catch (Exception ex)
            {

            }finally { conn.Close(); }


            return isFound;
        }
   
        public static int AddNewApplicationType(string AppTypeTitle, float AppFees)
        {
            int AppID = -1;

            SqlConnection conn = new SqlConnection(DataAccessSettings.stConnection);
            string stCommand = @"INSERT INTO ApplicationTypes
                                 (ApplicationTypeTitle, ApplicationFees)
                                 VALUES
                                 (@appTitle, @appFees);
                                 select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(stCommand, conn);
            command.Parameters.AddWithValue("@appTitle", AppTypeTitle);
            command.Parameters.AddWithValue("@appFees", AppFees);

            try
            {
                conn.Open();

                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID)) {
                
                    AppID = insertedID;
                }
            }catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return AppID;
        }

        public static bool UpdateApplicationType(int AppID, string AppTypeTitle, float AppFees)
        {
            int rowsAffected = 0;

            SqlConnection conn = new SqlConnection(DataAccessSettings.stConnection);
            string stCommand = @"update ApplicationTypes
                               set ApplicationTypeTitle = @appTitle,
                                   ApplicationFees = @appFees
                               where ApplicationTypeID = @appId;";
            SqlCommand command = new SqlCommand(stCommand, conn);
            command.Parameters.AddWithValue("@appId", AppID);
            command.Parameters.AddWithValue("@appTitle", AppTypeTitle);
            command.Parameters.AddWithValue("@appFees", AppFees);

            try
            {
                conn.Open();
                rowsAffected = command.ExecuteNonQuery();

            }catch (Exception ex)
            {
                return false;
            }finally { conn.Close(); }

            return rowsAffected > 0;
        }
    }
}
