using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class TestAppointmentData
    {

        static SqlConnection connect2DB = new SqlConnection(DataAccessSettings.stConnection);

        public static bool GetTestAppointmentInfoByID(int testAppointmentID, ref int testTypeId, ref int LocalDLAppID,
                                           ref DateTime testAppointmentDate, ref float PaidFees, ref int createdbyUserID,
                                           ref bool isLocked, ref int retakeTestAppID)
        { 
            bool isFound = false;

            string query = @"select * from TestAppointments where TestAppointmentID = @testAppointmentID";
            SqlCommand cmd = new SqlCommand(query, connect2DB);
            cmd.Parameters.AddWithValue("@testAppointmentID", testAppointmentID);

            try {
            
                connect2DB.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    testTypeId = (int)reader["TestTypeID"];
                    LocalDLAppID = (int)reader["LocalDrivingLicenseApplicationID"];
                    testAppointmentDate = Convert.ToDateTime(reader["AppointmentDate"]);
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    createdbyUserID = (int)reader["CreatedByUserID"];
                    isLocked = (bool)reader["IsLocked"];

                    //handle varible is null 
                    retakeTestAppID = (reader["RetakeTestApplicationID"] != DBNull.Value)?(int)reader["RetakeTestApplicationID"]:-1; 

                }
            
                reader.Close();

            }catch(Exception ex) { 
                
                isFound = false;
            
            } finally { connect2DB.Close(); }

            return isFound;
        }

        public static bool GetLastTestAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID,
            ref int TestAppointmentID, ref DateTime AppointmentDate, ref float PaidFees,
            ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {

            bool isFound = false;

            string query = @"select top 1 * from TestAppointments 
                             where TestTypeID = @testTypeId and LocalDrivingLicenseApplicationID = @LocalDLAppID
                             order by TestAppointmentID Desc";

            SqlCommand command = new SqlCommand(query, connect2DB);
            command.Parameters.AddWithValue("@testTypeId", TestTypeID);
            command.Parameters.AddWithValue("@LocalDLAppID", LocalDrivingLicenseApplicationID);


            try
            {
                connect2DB.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    AppointmentDate = Convert.ToDateTime(reader["AppointmentDate"]);
                    IsLocked = (bool)reader["IsLocked"];

                    RetakeTestApplicationID = reader["RetakeTestApplicationID"] != DBNull.Value ? (int)reader["RetakeTestApplicationID"] : -1;
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }

                reader.Close();

            }catch(Exception ex)
            {
                isFound = false;

            }finally { connect2DB.Close(); }

            return isFound;
        }

        public static DataTable GetAllTestAppointments()
        {
            DataTable dt = new DataTable();

            string query = "select * from TestAppointments_View order by TestAppointmentID desc;";
            SqlCommand command = new SqlCommand(query, connect2DB);

            try
            {
                connect2DB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }catch(Exception ex)
            {

            }
            finally { connect2DB.Close(); }

            return dt;
        }

        public static DataTable GetApplicationTestAppointmentsPerTestType(int localDLAppID, int testTypeID)
        {

            DataTable dt = new DataTable();

            string query = @"select TestAppointmentID, AppointmentDate, PaidFees, IsLocked
                             from TestAppointments
                             where TestTypeID = @testTypeId and LocalDrivingLicenseApplicationID = @LocalDLAppID
                             order by TestAppointmentID Desc;";

            SqlCommand command = new SqlCommand(query, connect2DB);
            command.Parameters.AddWithValue("@testTypeId", testTypeID);
            command.Parameters.AddWithValue("@LocalDLAppID", localDLAppID);

            try
            {
                connect2DB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }
            catch (Exception ex)
            {

            }
            finally { connect2DB.Close(); }

            return dt;
        }

        public static int AddNewTestAppointment(int testTypeId, DateTime AppointmentDate, int LocalDLAppID,
               float paidFees, bool isLocked, int createdUser, int retakeAppID)
        {
            int testAppointementID = -1;

            string stCommand = @"insert into TestAppointments(TestTypeID,LocalDrivingLicenseApplicationID,
                                 AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)
                                 Values
                                 (@testTypeID, @localAppId, @AppointmentDate, @paidFees, @createdUser, @isLocked, @retakeAppId);
                                 select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(stCommand, connect2DB);
            command.Parameters.AddWithValue("@testTypeID", testTypeId);
            command.Parameters.AddWithValue("@localAppId", LocalDLAppID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@paidFees", paidFees);
            command.Parameters.AddWithValue("@createdUser", createdUser);
            command.Parameters.AddWithValue("@isLocked", isLocked);
            
            if (retakeAppID != -1)
                command.Parameters.AddWithValue("@retakeAppId", retakeAppID);
            else
                command.Parameters.AddWithValue("@retakeAppId", DBNull.Value);

            try
            {
                connect2DB.Open();
                object obj = command.ExecuteScalar();

                if(obj != null && int.TryParse(obj.ToString(), out int ID)){
                    testAppointementID = ID;
                }

            }
            catch (Exception ex)
            {
                testAppointementID = -1;
            }
            finally { connect2DB.Close(); }

            return testAppointementID;
        }

        public static bool UpdateTestAppointment(int testAppointementID, int testTypeId, DateTime AppointmentDate, int LocalDLAppID,
               float paidFees, bool isLocked, int createdUser, int retakeAppID)
        {
            int rowsAffeccted = 0;

            string stCommand = @"update TestAppointments
                                 set TestTypeID = @testTypeId,
                                     LocalDrivingLicenseApplicationID = @localAppId,
                                     AppointmentDate = @appointementDate,
                                     PaidFees = @paidFees,
                                     CreatedByUserID = @userId,
                                     IsLocked = @isLocked,
                                     RetakeTestApplicationID = @retakeAppId
                                  where TestAppointmentID = @testAppointmentID;";

            SqlCommand command = new SqlCommand(stCommand, connect2DB);
            command.Parameters.AddWithValue("@testTypeId", testTypeId);
            command.Parameters.AddWithValue("@localAppId", LocalDLAppID);
            command.Parameters.AddWithValue("@appointementDate", AppointmentDate);
            command.Parameters.AddWithValue("@paidFees", paidFees);
            command.Parameters.AddWithValue("@userId", createdUser);
            command.Parameters.AddWithValue("@isLocked", isLocked);
            
            if(retakeAppID == -1)
                command.Parameters.AddWithValue("@retakeAppId", DBNull.Value);
            else
                command.Parameters.AddWithValue("@retakeAppId", retakeAppID);

            command.Parameters.AddWithValue("@testAppointmentID", testAppointementID);

            try
            {
                connect2DB.Open();
                rowsAffeccted = command.ExecuteNonQuery();

            }catch (Exception ex)
            {
                rowsAffeccted = 0;
            }
            finally { connect2DB.Close(); }

            return rowsAffeccted > 0;
        }

        public static int GetTestID(int testAppointmentID)
        {
            int TestId = -1;

            string query = "select TestID from Tests where TestAppointmentID = @testAppointmentId;";
            SqlCommand command = new SqlCommand(query, connect2DB);
            command.Parameters.AddWithValue("@testAppointmentId", testAppointmentID);

            try
            {

                connect2DB.Open();
                object result = command.ExecuteScalar();
               
                if(result != null && int.TryParse(result.ToString(), out int id)){
                    TestId = id;
                }
            }catch (Exception ex)
            {

            }
            finally { connect2DB.Close();}

            return TestId;
        }
        
    }
}
