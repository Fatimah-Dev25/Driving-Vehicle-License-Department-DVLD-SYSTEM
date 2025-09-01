using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class LicenseData
    {

        static SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);

        public static DataTable GetAllLicenses()
        {
            DataTable table = new DataTable();

            string query = "select * from Licenses;";
            SqlCommand command = new SqlCommand(query, connectToDB);

            try
            {
                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    table.Load(reader);
                }

                reader.Close();
            }catch (Exception ex)
            {

            }
            finally
            {
                connectToDB.Close();
            }

            return table;
        }

        public static bool GetLicenseInfoByID(int licenseID, ref int applicationID, ref int driverID, ref int licenseClassID, 
            ref DateTime issueDate, ref DateTime expirationDate, ref string notes, ref float paidFees, ref bool isActive, 
            ref byte issueReason, ref int createdByUser)
        {
            bool isFound = false;

            string query = @"select * from Licenses where LicenseID = @licenseID";
            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@licenseID", licenseID);

            try
            {
                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    applicationID = (int)reader["ApplicationID"];
                    driverID = (int)reader["DriverID"];
                    licenseClassID = (int)reader["LicenseClass"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expirationDate = (DateTime)reader["ExpirationDate"];
                    notes = reader["Notes"] == DBNull.Value ? "" : (string)reader["Notes"];
                    paidFees = Convert.ToSingle(reader["PaidFees"]);
                    isActive = (bool)reader["IsActive"];
                    issueReason = (byte)reader["IssueReason"];
                    createdByUser = (int)reader["CreatedByUserID"];
                }

                reader.Close();

            }catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connectToDB.Close();
            }

            return isFound;
        }

        public static int AddNewLicense(int applicationID, int driverID, int licenseClassID,
            DateTime issueDate, DateTime expirationDate, string notes, float paidFees, bool isActive,
            byte issueReason, int createdByUser)
        {
            int _RecordID = -1;

            string stCommand = @"INSERT INTO Licenses
                                  (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, 
                  		          IsActive, IssueReason, CreatedByUserID)
                                  VALUES
                                  (@appID, @driveId, @licenseClassId, @issueDate, @expDate, @notes, @paidFees, @isActive, 
                                   @issueReason, @createdbyUser)
                  		          select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(stCommand, connectToDB);
            command.Parameters.AddWithValue("@appID",applicationID );
            command.Parameters.AddWithValue("@driveId", driverID);
            command.Parameters.AddWithValue("@licenseClassId", licenseClassID);
            command.Parameters.AddWithValue("@issueDate", issueDate);
            command.Parameters.AddWithValue("@expDate", expirationDate);
       
            // handle notes coz in DB allowed null
            if(notes == "")
                command.Parameters.AddWithValue("@notes", DBNull.Value);    
            else
                command.Parameters.AddWithValue("@notes", notes);

            command.Parameters.AddWithValue("@paidFees", paidFees);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@issueReason", issueReason);
            command.Parameters.AddWithValue("@createdbyUser", createdByUser);
     
            try
            {
                connectToDB.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int rowID)) {
                
                    _RecordID = rowID;
                }

            }catch (Exception ex)
            {

            }
            finally
            {
                connectToDB.Close();
            }

            return _RecordID;
        }

        public static bool UpdateLicenseInfo(int licenseId, int applicationID, int driverID, int licenseClassID,
            DateTime issueDate, DateTime expirationDate, string notes, float paidFees, bool isActive,
            byte issueReason, int createdByUser)
        {
            int rowsAffected = 0;

            string stCommand = @"Update Licenses
                                 set ApplicationID = @appID,
                                     DriverID = @driveId,
                                     LicenseClass = @licenseClassId,
                                     IssueDate = @issueDate,
                                     ExpirationDate = @expDate,
                                     Notes = @notes,
                                     PaidFees = @paidFees,
                                     IsActive = @isActive,
                                     IssueReason = @issueReason,
                                     CreatedByUserID = @createdbyUser
                                 
                  		             where LicenseID = @licenseID;";

            SqlCommand command = new SqlCommand(stCommand, connectToDB);
            command.Parameters.AddWithValue("@licenseID", licenseId);
            command.Parameters.AddWithValue("@appID", applicationID);
            command.Parameters.AddWithValue("@driveId", driverID);
            command.Parameters.AddWithValue("@licenseClassId", licenseClassID);
            command.Parameters.AddWithValue("@issueDate", issueDate);
            command.Parameters.AddWithValue("@expDate", expirationDate);

            // handle notes coz in DB allowed null
            if (notes == "")
                command.Parameters.AddWithValue("@notes", DBNull.Value);
            else
                command.Parameters.AddWithValue("@notes", notes);

            command.Parameters.AddWithValue("@paidFees", paidFees);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@issueReason", issueReason);
            command.Parameters.AddWithValue("@createdbyUser", createdByUser);

            try
            {
                connectToDB.Open();

                rowsAffected = command.ExecuteNonQuery();             
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connectToDB.Close();
            }

            return rowsAffected > 0;
        }

        public static DataTable GetDriverLicenses(int driverID)
        {
            DataTable dt = new DataTable();

            string query = @"select Licenses.LicenseID, ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate,
                             Licenses.ExpirationDate, Licenses.IsActive 
	                         from Licenses inner join LicenseClasses on Licenses.LicenseClass = LicenseClasses.LicenseClassID
	                         where DriverID = @driverID
	                         order by IsActive desc, ExpirationDate desc;";
            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@driverID", driverID);

            try
            {
                connectToDB.Open();
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
            finally { connectToDB.Close(); }

            return dt;
        }

        public static int GetActiveLicenseIDByPersonID(int personID, int LicenseClassID)
        {
            int _LicenseID = -1;

            string query = @"select Licenses.LicenseID 
                            from Licenses inner join Drivers on Drivers.DriverID = Licenses.DriverID
                            where Drivers.PersonID  = @personId and IsActive = 1 and LicenseClass = @licenseClassID";

            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@personId", personID);
            command.Parameters.AddWithValue("@licenseClassID", LicenseClassID);

            try
            {
                connectToDB.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int rowID)) {
                
                    _LicenseID = rowID;
                }
            }catch (Exception ex)
            {

            }finally { connectToDB.Close(); }

            return _LicenseID;
        }
        public static bool DeActivateLicense(int licenseID)
        {
            int rowsffected = 0;

            string stCommand = @"Update Licenses
                                 set IsActive = 0
                                 where LicenseID = @licenseID;";

            SqlCommand command = new SqlCommand(stCommand, connectToDB);
            command.Parameters.AddWithValue("@licenseID", licenseID);

            try
            {
                connectToDB.Open();
                rowsffected = command.ExecuteNonQuery();
            }catch (Exception ex)
            {

            }
            finally
            {
                connectToDB.Close();
            }

            return rowsffected > 0;
        }
    }
}
