using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class DriverData
    {

        static SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);

        public static bool GetDriverInfoByID(int driverID, ref int personID, ref int createdByUser, ref DateTime createdDate)
        {
            bool isFound = false;

            string query = "select * from Drivers where DriverID = @driverId;";
            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@driverId", driverID);

            try
            {

                connectToDB.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    personID = (int)reader["PersonID"];
                    createdByUser = (int)reader["CreatedByUserID"];
                    createdDate = (DateTime)reader["CreatedDate"];
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

        public static bool GetDriverInfoByPersonID(int personID, ref int driverID, ref int createdByUser, ref DateTime createdDate)
        {
            bool isFound = false;

            string query = "select * from Drivers where PersonID = @personID;";
            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@personID", personID);

            try
            {

                connectToDB.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;
                    driverID = (int)reader["DriverID"];
                    createdByUser = (int)reader["CreatedByUserID"];
                    createdDate = (DateTime)reader["CreatedDate"];
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

        public static DataTable GetAllDrivers()
        {
            DataTable result = new DataTable();

            string query = "select * from Drivers_View order by FullName;";
            SqlCommand command = new SqlCommand(query, connectToDB);

            try
            {
                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    result.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally { connectToDB.Close(); }

            return result;
        }

        public static int AddNewDriver(int _PersonID, int _CreatedByUser)
        {
            int _RecordId = -1;

            string stCommand = @"INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                                 VALUES
                                 (@personId, @userId, @createdDate)
	                             select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(stCommand, connectToDB);
            command.Parameters.AddWithValue("@personId", _PersonID);
            command.Parameters.AddWithValue("@userId", _CreatedByUser);
            command.Parameters.AddWithValue("@createdDate", DateTime.Now);

            try
            {

                connectToDB.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    _RecordId = insertedID;
                }

            }catch (Exception ex)
            {

            }
            finally
            {
                connectToDB.Close();
            }

            return _RecordId;
        }

        public static bool UpdateDriverInfo(int driverId, int personId, int createdUserId, DateTime createdDate)
        {
            int rowsAffected = 0;

            string stCommand = @"update Drivers
                                 set PersonID = @personId
                                     CreatedByUserID = @userId
                                     CreatedDate = @createdDate
                                  where DriverID = @driverId;";
            SqlCommand command = new SqlCommand( stCommand, connectToDB);
            command.Parameters.AddWithValue("@personId", personId);
            command.Parameters.AddWithValue("@userId", createdUserId);
            command.Parameters.AddWithValue("@createdDate", createdDate);

            try
            {
                connectToDB.Open();
                rowsAffected = command.ExecuteNonQuery();

            }catch (Exception ex)
            {

            }finally { connectToDB.Close(); }

            return rowsAffected > 0;
        }

    }
}
