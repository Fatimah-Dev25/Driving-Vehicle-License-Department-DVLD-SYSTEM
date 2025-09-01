using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataAccess
{
    public class LocalDrivingLicencesApplicationData
    {
        static SqlConnection conn = new SqlConnection(DataAccessSettings.stConnection);
        public static bool GetLocalDrivingLicenseApplicationInfoByID(int LocalDrivingLicenseApplicationID,
            ref int ApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;
            string query = @"select * from LocalDrivingLicenseApplications 
                             where LocalDrivingLicenseApplicationID = @localAppID;";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@localAppID", LocalDrivingLicenseApplicationID);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                }

                reader.Close();
            }catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }

            return isFound;
        }

        public static bool GetLocalDrivingLicenseApplicationInfoByApplicationID(int ApplicationID,
            ref int LocalDrivingLicenseApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;
            string query = @"select * from LocalDrivingLicenseApplications 
                             where ApplicationID = @AppID;";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@AppID", ApplicationID);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                conn.Close();
            }

            return isFound;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications() { 
        
            DataTable dt = new DataTable();

            string query = @"select * from LocalDrivingLicenseApplications_View
                             order by ApplicationDate desc;";
            SqlCommand cmd = new SqlCommand(query, conn);

            try {
            
                conn.Open();
                
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close() ;
            }catch (Exception ex) {
            
            
            } finally { conn.Close(); }

            return dt;
        }

        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            string stCommand = @"insert into LocalDrivingLicenseApplications(ApplicationID, LicenseClassID)
                                 values
                                 (@appID, @licenseClassID);
                                  select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(stCommand, conn);
            command.Parameters.AddWithValue("@appID", ApplicationID);
            command.Parameters.AddWithValue("@licenseClassID", LicenseClassID);

            try { 
                conn.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    return insertedID;
                }

            } catch { 
                
                return -1; 
                    
            } finally
            {
                conn.Close();
            }
            return -1;
        }

        public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseAppID,
            int ApplicationID, int LicenseClassID)
        {
            int rowsAffected = 0;

            string stCommand = @"update LocalDrivingLicenseApplications
                                 set ApplicationID = @appID
                                     LicenseClassID = @LicenseClassID
                                 where LocalDrivingLicenseApplicationID = @LDLAppID;";
            SqlCommand command = new SqlCommand( stCommand, conn);
            command.Parameters.AddWithValue("@appID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@LDLAppID", LocalDrivingLicenseAppID);

            try {

                conn.Open();
                rowsAffected = command.ExecuteNonQuery();
            
            }catch {

                 return false;

            }finally { conn.Close(); }

            return rowsAffected > 0;
        }

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseAppID)
        {
            int rowsAffected = 0;

            string stCommand = @"delete from LocalDrivingLicenseApplications
                                 where LocalDrivingLicenseApplicationID = @LDLAppID;";
            SqlCommand command = new SqlCommand(stCommand, conn);
            command.Parameters.AddWithValue("@LDLAppID", LocalDrivingLicenseAppID);

            try
            {

                conn.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch
            {

                return false;

            }
            finally { conn.Close(); }

            return rowsAffected > 0;
        }

        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)

        {

            bool Result = false;


            string query = @" SELECT top 1 TestResult
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                conn.Open();

                object result = command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool returnedResult))
                {
                    Result = returnedResult;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                conn.Close();
            }

            return Result;

        }

        public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {

            bool IsFound = false;


            string query = @"SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                conn.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    IsFound = true;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                conn.Close();
            }

            return IsFound;

        }

        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            byte TotalTrialsPerTest = 0;

            string query = @"SELECT TotalTrialsPerTest = count(TestID)
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                conn.Open();

                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte Trials))
                {
                    TotalTrialsPerTest = Trials;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                conn.Close();
            }

            return TotalTrialsPerTest;

        }

        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {

            bool Result = false;

            string query = @"SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  
                            AND(TestAppointments.TestTypeID = @TestTypeID) and isLocked=0
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                conn.Open();

                object result = command.ExecuteScalar();


                if (result != null)
                {
                    Result = true;
                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                conn.Close();
            }

            return Result;

        }
    }
}
