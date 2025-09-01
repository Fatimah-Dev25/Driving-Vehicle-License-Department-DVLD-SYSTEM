using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class TestData
    {
        static SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);
        public static bool GetTestInfoByID(int testID, ref int testAppointmentID, ref bool testResult,
            ref string notes, ref int createdByUser)
        {
            bool isFound = false;

            string query = @"select * from Tests where TestID = @testId;";
            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@testId", testID);

            try
            {
                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) {
                
                    isFound = true;
                    testAppointmentID = (int)reader["TestAppointmentID"];
                    testResult = (bool)reader["TestResult"];
                    notes = reader["Notes"] == DBNull.Value ? "" : reader["Notes"].ToString();
                    createdByUser = (int)reader["CreatedByUserID"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally { connectToDB.Close(); }

            return isFound;
        }

        public static bool GetTestInfoByAppointmentID(int testAppointmentID, ref int testID, ref bool testResult,
            ref string notes, ref int createdByUser)
        {
            bool isFound = false;

            string query = @"select * from Tests where TestAppointmentID = @testAppointmentId;";
            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@testAppointmentId", testAppointmentID);

            try
            {
                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    testID = (int)reader["TestID"];
                    testResult = (bool)reader["TestResult"];
                    notes = reader["Notes"] == DBNull.Value ? "" : reader["Notes"].ToString();
                    createdByUser = (int)reader["CreatedByUserID"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally { connectToDB.Close(); }

            return isFound;
        }

        public static DataTable GetAllTests()
        {
            DataTable dt = new DataTable();

            string query = "select * from Tests order by TestID;";
            SqlCommand command = new SqlCommand(query, connectToDB);

            try
            {
                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            }catch (Exception ex)
            {

            }
            finally
            {
                connectToDB.Close();
            }

            return dt;

        }

        public static int AddNewTest(int testAppointmentID, bool testResult, string notes, int createdByUser)
        {
            int RecordID = -1;

            string stCommand = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                                 VALUES     
                                 (@appointmentID, @result, @notes, @user);

                                 Update TestAppointments
                                 set IsLocked = 1 where TestAppointmentID = @appointmentID;

		                         select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(stCommand, connectToDB);
            command.Parameters.AddWithValue("@appointmentID", testAppointmentID);
            command.Parameters.AddWithValue("@result", testResult);
            command.Parameters.AddWithValue("@user", createdByUser);

            if(notes == "")
                command.Parameters.AddWithValue("@notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@notes", notes);

            try
            {
                connectToDB.Open();

                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    RecordID = insertedID;
                }


            }catch (Exception ex)
            {

            }
            finally
            {
                connectToDB.Close();
            }

            return RecordID;
        }

        public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUser)
        {
            int rowsAffeccted = 0;

            string stCommand = @"update Tests
                                 set TestAppointmentID = @testAppointmentID
                                     TestResult = @result
                                     Notes = @notes
                                     CreatedByUserID = @user
                                  where TestID = @testID;";

            SqlCommand command = new SqlCommand(stCommand, connectToDB);
            command.Parameters.AddWithValue("@testAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@result", TestResult);
            command.Parameters.AddWithValue("@user", CreatedByUser);


            if (Notes == "")
                command.Parameters.AddWithValue("@notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@notes", Notes);
           
            try
            {
                connectToDB.Open();
                rowsAffeccted = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowsAffeccted = 0;
            }
            finally { connectToDB.Close(); }

            return rowsAffeccted > 0;
        }
    
        public static byte GetPassedTestCount(int LocalDLAppID)
        {
            byte PassedTestCount = 0;

            string query = @"select PassedTestCount = count(TestID) from Tests inner join TestAppointments on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                             where LocalDrivingLicenseApplicationID = @LocalDLAppID and TestResult = 1;";
            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@LocalDLAppID", LocalDLAppID);

            try
            {
                connectToDB.Open();

                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte passedTests))
                {
                    PassedTestCount = passedTests;
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connectToDB.Close();
            }
            
            return PassedTestCount;
        }
    
        public static bool GetLastTestByPersonAndTestTypeAndLicenseClass(int PersonID, int TestType, int LicenseClassID,
            ref int TestID, ref int TestAppointmentId, ref bool TestResult, ref string Notes, ref int createdByUser)
        {
            bool isFound = false;

            string query = @"select top 1 Tests.TestID, Tests.TestAppointmentID, Tests.TestResult, Tests.Notes, Tests.CreatedByUserID from Tests inner join TestAppointments on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                             inner join LocalDrivingLicenseApplications on LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID
                             inner join Applications on Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                             where ApplicantPersonID = @PersonId and TestTypeID = @testTypeID and LocalDrivingLicenseApplications.LicenseClassID = @licenseClassID
                             order by TestAppointmentID desc;";

            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@PersonId", PersonID);
            command.Parameters.AddWithValue("@testTypeID", TestType);
            command.Parameters.AddWithValue("@licenseClassID", LicenseClassID);
            try
            {
                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();
               
                if (reader.Read())
                {
                    isFound = true;
                    TestID = (int)reader["TestID"];
                    TestAppointmentId = (int)reader["TestAppointmentID"];
                    TestResult = (bool)reader["TestResult"];
                    Notes = reader["Notes"] == DBNull.Value?"": (string)reader["Notes"];
                    createdByUser = (int)reader["CreatedByUserID"];
                }else
                    isFound = false;

                reader.Close();

            }catch (Exception ex)
            {

            }finally { connectToDB.Close(); }

            return isFound;
        }
    }
}
