using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class ApplicationData
    {
        public static DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(DataAccessSettings.stConnection);
            string stCommand = @"select ApplicationID, ApplicantPersonID, FullName = People.FirstName + ' ' + People.SecondName + ' ' + People.LastName,
                                 ApplicationDate, ApplicationTypes.ApplicationTypeTitle, 
	                             case 
	                               when ApplicationStatus = 1 then 'New'
		                           when ApplicationStatus = 2 then 'Cancelled'
		                           when ApplicationStatus = 3 then 'Complited'
	                             end as Status, LastStatusDate, PaidFees, CreatedByUserID
                                 from Applications inner join People on Applications.ApplicantPersonID = People.PersonID 
                                 inner join ApplicationTypes on Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID;";

            SqlCommand command = new SqlCommand(stCommand, conn);

            try {

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();

            } catch (Exception ex) {


            }
            finally { conn.Close(); }

            return dt;
        }
        public static bool GetApplicationInfoByID(int appId, ref int appPersonId,
            ref DateTime appDate, ref DateTime appLastSatusDate, ref int appTypeId, ref byte appStatus,
                 ref float PaidFees, ref int appUser)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(DataAccessSettings.stConnection);

            string stCommand = "select * from Applications where ApplicationID = @appId";
            SqlCommand command = new SqlCommand(stCommand, conn);
            command.Parameters.AddWithValue("@appId", appId);

            try {

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    appPersonId = (int)reader["ApplicantPersonID"];
                    appDate = (DateTime)reader["ApplicationDate"];
                    appTypeId = (int)reader["ApplicationTypeID"];
                    appStatus = (byte)reader["ApplicationStatus"];
                    appLastSatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    appUser = (int)reader["CreatedByUserID"];
                }

                reader.Close();

            } catch (Exception ex) {

                isFound = false;
            }
            finally { conn.Close(); }

            return isFound;
        }

        public static bool isApplicationExists(int appID)
        {

            SqlConnection conn = new SqlConnection(DataAccessSettings.stConnection);

            string stCommand = "select isFound = 1 from Applications where ApplicationID = @AppID";
            SqlCommand command = new SqlCommand(stCommand, conn);
            command.Parameters.AddWithValue("@AppID", appID);

            try {

                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
            } catch (Exception ex)
            {
                return false;

            } finally { conn.Close(); }

            return false;

        }

        public static int AddNewApplication(int appPersonId, DateTime appDate, int appTypeId, byte appStatus,
                                 DateTime appLastStatus,float PaidFees, int appUser)
        {
            int appID = -1;
            SqlConnection conn = new SqlConnection(DataAccessSettings.stConnection);

            string stCommand = @"INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                                  ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                                 VALUES(@personID, @appDate, @appTypeID, @appStatus, @appLastDate, @appPaidFees, @appUser);
                                 select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(stCommand, conn);
            command.Parameters.AddWithValue("@personID", appPersonId);
            command.Parameters.AddWithValue("@appDate", appDate);
            command.Parameters.AddWithValue("@appTypeID", appTypeId);
            command.Parameters.AddWithValue("@appStatus", appStatus);
            command.Parameters.AddWithValue("@appLastDate", appLastStatus);
            command.Parameters.AddWithValue("@appPaidFees", PaidFees);
            command.Parameters.AddWithValue("@appUser", appUser);

            try {
                conn.Open();
                object resutl = command.ExecuteScalar();
                if (resutl != null && int.TryParse(resutl.ToString(), out int insertedID))
                {
                    appID = insertedID;
                }

            } catch (Exception ex) {

                appID = -1;
            } finally { conn.Close(); }

            return appID;
        }

        public static bool UpdateApplicationStatus(int appID, byte appNewStatus)
        {
            int rowAffected = 0;
            SqlConnection conn = new SqlConnection(DataAccessSettings.stConnection);

            string stCommand = @"Update  Applications  
                                 set 
                                  ApplicationStatus = @NewStatus, 
                                  LastStatusDate = @LastStatusDate
                                 where ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(stCommand, conn);
            command.Parameters.AddWithValue("@ApplicationID", appID);
            command.Parameters.AddWithValue("@NewStatus", appNewStatus);
            command.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);

            try
            {
                conn.Open();
                rowAffected = command.ExecuteNonQuery();

            } catch (Exception ex) {

                rowAffected = 0;
            }
            finally
            {
                conn.Close();
            }

            return rowAffected > 0;

        }
        public static bool DeleteApplication(int appID)
        {

            SqlConnection conn = new SqlConnection(DataAccessSettings.stConnection);

            string stCommand = "delete from Applications where ApplicationID = @appID";
            SqlCommand command = new SqlCommand(stCommand, conn);
            command.Parameters.AddWithValue("@appID", appID);

            try
            {
                conn.Open();

                return (command.ExecuteNonQuery()) > 0;

            } catch (Exception ex)
            {
                return false;

            } finally { conn.Close(); }


        }
        public static bool UpdateApplication(int appId, int appPersonId, DateTime appDate,
            DateTime appLastSatusDate, int appTypeId, byte appStatus, float PaidFees, int appUser)
        {

            int rowsAffeccted = -1;
           
            SqlConnection conn = new SqlConnection(DataAccessSettings.stConnection);

            string stCommand = @"update Applications
                                 set ApplicantPersonID = @personId
                                     ApplicationDate = @appDate 
                                     ApplicationTypeID = @appTypeID
                                     ApplicationStatus = @appStatus
                                     LastStatusDate = @lastStatusDate
                                     PaidFees = @paidFees
                                     CreatedByUserID = @appUser
                                 where ApplicationID = @appID;";

            SqlCommand command = new SqlCommand(stCommand, conn);
            command.Parameters.AddWithValue("@personId", appPersonId);
            command.Parameters.AddWithValue("@appDate", appDate);
            command.Parameters.AddWithValue("@appTypeID", appTypeId);
            command.Parameters.AddWithValue("@appStatus", appStatus);
            command.Parameters.AddWithValue("@lastStatusDate", appLastSatusDate);
            command.Parameters.AddWithValue("@paidFees", PaidFees);
            command.Parameters.AddWithValue("@appUser", appUser);
            command.Parameters.AddWithValue("@appID", appId);

            try
            {
                conn.Open();
                rowsAffeccted = command.ExecuteNonQuery();

            }catch (Exception ex)
            {
                rowsAffeccted = -1;

            }finally { conn.Close(); }

            return rowsAffeccted > 0;
        }

        public static int GetActiveApplicationID(int personID, int applicationTypeID)
        {
            SqlConnection conn = new SqlConnection(DataAccessSettings.stConnection);

            string query = @"select ActiveApplication = ApplicationID from Applications
                             where ApplicantPersonID = @perID and ApplicationTypeID = @appTypeId and ApplicationStatus = 1;";

            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@perID", personID);
            command.Parameters.AddWithValue("@appTypeId", applicationTypeID);

            try
            {
                conn.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    return AppID;
                }

            }catch (Exception ex)
            {
                return -1;
            }
            finally { conn.Close(); }

            return -1;
        }

        public static bool DoesPersonHaveActiveApplication(int PersonId, int applicationTypeID)
        {
            return GetActiveApplicationID(PersonId, applicationTypeID) != -1;
        }
        public static int GetActiveApplicationIDForLicenseClass(int PersonID, int ApplicationTypeID, int LicenseClassID)
        {
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.stConnection);

            string query = @"SELECT ActiveApplicationID=Applications.ApplicationID  
                            From
                            Applications INNER JOIN
                            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE ApplicantPersonID = @ApplicantPersonID 
                            and ApplicationTypeID=@ApplicationTypeID 
							and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                            and ApplicationStatus=1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return ActiveApplicationID;
            }
            finally
            {
                connection.Close();
            }

            return ActiveApplicationID;
        }

    }
}