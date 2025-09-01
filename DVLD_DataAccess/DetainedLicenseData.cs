using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class DetainedLicenseData
    {
        static SqlConnection connect2DB = new SqlConnection(DataAccessSettings.stConnection);
        public static DataTable GetAllDetainedLicenses()
        {
            DataTable table = new DataTable();

            string query = @"select * from DetainedLicenses_View
                              order by IsReleased ,DetainID;";
            SqlCommand command = new SqlCommand(query, connect2DB);

            try
            {
                connect2DB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    table.Load(reader);
                reader.Close();
            }catch (Exception ex)
            {

            }finally { connect2DB.Close(); }

            return table;
        }

        public static bool GetDetainedLicenseInfoByID(int detainedId, ref int licenseID, ref DateTime detainedDate, ref float fineFees,
            ref int createdByUser, ref bool isReleased, ref DateTime releasedDate, ref int releasedByUserID,
            ref int releaseAppID)
        {

            bool isFound = false;

            string query = "select * from DetainedLicenses where DetainID = @DetainedID;";
            SqlCommand command = new SqlCommand(query, connect2DB);
            command.Parameters.AddWithValue("@DetainedID", detainedId);

            try
            {
                connect2DB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    licenseID = (int)reader["LicenseID"];
                    detainedDate = (DateTime)reader["DetainDate"];
                    fineFees = Convert.ToSingle(reader["FineFees"]);
                    createdByUser = (int)reader["CreatedByUserID"];
                    isReleased = (bool)reader["IsReleased"];

                    if (reader["ReleasedByUserID"] == DBNull.Value)
                        releasedByUserID = -1;
                    else
                        releasedByUserID = (int)reader["ReleasedByUserID"];

                    if (reader["ReleaseApplicationID"] == DBNull.Value)
                        releaseAppID = -1;
                    else
                        releaseAppID = (int)reader["ReleaseApplicationID"];

                    if (reader["ReleaseDate"] == DBNull.Value)
                        releasedDate = DateTime.MaxValue;
                    else
                        releasedDate = (DateTime)reader["ReleaseDate"];
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {

            }
            return isFound;
        }

        public static bool GetDetainedLicenseInfoByLicenseID(int LicenseID,
         ref int DetainID, ref DateTime DetainDate,
         ref float FineFees, ref int CreatedByUserID,
         ref bool IsReleased, ref DateTime ReleaseDate,
         ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            
            bool isFound = false;
            string query = "SELECT top 1 * FROM DetainedLicenses WHERE LicenseID = @LicenseID order by DetainID desc";

            SqlCommand command = new SqlCommand(query, connect2DB);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connect2DB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = Convert.ToSingle(reader["FineFees"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    IsReleased = (bool)reader["IsReleased"];

                    if (reader["ReleaseDate"] == DBNull.Value)

                        ReleaseDate = DateTime.MaxValue;
                    else
                        ReleaseDate = (DateTime)reader["ReleaseDate"];


                    if (reader["ReleasedByUserID"] == DBNull.Value)

                        ReleasedByUserID = -1;
                    else
                        ReleasedByUserID = (int)reader["ReleasedByUserID"];

                    if (reader["ReleaseApplicationID"] == DBNull.Value)

                        ReleaseApplicationID = -1;
                    else
                        ReleaseApplicationID = (int)reader["ReleaseApplicationID"];

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connect2DB.Close();
            }

            return isFound;
        }


        public static int AddNewDetainedLicense(
            int LicenseID, DateTime DetainDate,
            float FineFees, int CreatedByUserID)
        {
            int DetainID = -1;

            string query = @"INSERT INTO dbo.DetainedLicenses
                               (LicenseID,
                               DetainDate,
                               FineFees,
                               CreatedByUserID,
                               IsReleased
                               )
                            VALUES
                               (@LicenseID,
                               @DetainDate, 
                               @FineFees, 
                               @CreatedByUserID,
                               0
                             );
                            
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connect2DB);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connect2DB.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DetainID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connect2DB.Close();
            }


            return DetainID;

        }
        public static bool UpdateDetainedLicense(int DetainID,
            int LicenseID, DateTime DetainDate,
            float FineFees, int CreatedByUserID)
        {

            int rowsAffected = 0;

            string query = @"UPDATE dbo.DetainedLicenses
                              SET LicenseID = @LicenseID, 
                              DetainDate = @DetainDate, 
                              FineFees = @FineFees,
                              CreatedByUserID = @CreatedByUserID,   
                              WHERE DetainID=@DetainID;";

            SqlCommand command = new SqlCommand(query, connect2DB);

            command.Parameters.AddWithValue("@DetainedLicenseID", DetainID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connect2DB.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connect2DB.Close();
            }

            return (rowsAffected > 0);
        }


        public static bool ReleaseDetainedLicense(int DetainID,
                 int ReleasedByUserID, int ReleaseApplicationID)
        {

            int rowsAffected = 0;

            string query = @"UPDATE dbo.DetainedLicenses
                              SET IsReleased = 1, 
                              ReleaseDate = @ReleaseDate, 
                              ReleasedByUserID = @ReleasedByUserID,
                              ReleaseApplicationID = @ReleaseApplicationID   
                              WHERE DetainID=@DetainID;";

            SqlCommand command = new SqlCommand(query, connect2DB);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);
            try
            {
                connect2DB.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connect2DB.Close();
            }

            return (rowsAffected > 0);
        }


        public static bool IsLicenseDetained(int LicenseID)
        {
            bool IsDetained = false;

            string query = @"select IsDetained=1 
                            from detainedLicenses 
                            where 
                            LicenseID=@LicenseID 
                            and IsReleased=0;";

            SqlCommand command = new SqlCommand(query, connect2DB);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connect2DB.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    IsDetained = Convert.ToBoolean(result);
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connect2DB.Close();
            }


            return IsDetained;
            
        }
    }
}
