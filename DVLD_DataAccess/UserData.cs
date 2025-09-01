using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class UserData
    { 
        public static DataTable GetAllUsers()
        {
            DataTable dtAllUsers = new DataTable();

            SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);
            string query = @"select Users.UserID, Users.PersonID , FullName = People.FirstName + ' ' + People.SecondName + People.LastName, Users.UserName, Users.IsActive
                             from Users inner join People on Users.PersonID = People.PersonID;";
          
            SqlCommand command = new SqlCommand(query, connectToDB);

            try { 
                
                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                    dtAllUsers.Load(reader);

                reader.Close();
            }catch(Exception ex) {


            } finally
            {
                connectToDB.Close();
            }

            return dtAllUsers;
        }
        public static bool IsUserExist(int _UserID)
        {
            bool isFound = false;

            SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);
            
            string query = "select isFound = 1 from Users where UserID = @UID;";
            SqlCommand command = new SqlCommand(query,connectToDB);
            command.Parameters.AddWithValue("@UID", _UserID);

            try
            {
                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
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
        public static bool IsUserExist(string _UserName)
        {
            bool isFound = false;

            SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);

            string query = "select isFound = 1 from Users where UserName = @UName;";
            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@UName", _UserName);

            try
            {
                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connectToDB.Close();
            }

            return isFound;

        }
        public static bool IsUserExistForPersonID(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.stConnection);

            string query = "SELECT Found=1 FROM Users WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool GetUserInfoByUserID(int UID, ref int _PersonID, ref string _UserName, ref string _Password,ref bool isActive)
        {
            bool flag = false;

            SqlConnection connectToDB = new SqlConnection( DataAccessSettings.stConnection);
            
            string query = "select * from Users where UserID = @uID;";
            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@uID", UID);

            try
            {
                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    flag = true;
                    _PersonID = (int)reader["PersonID"];
                    _UserName = (string)reader["UserName"];
                    _Password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];

                }
                reader.Close();
            }catch (Exception ex)
            {
                flag = false;
            }
            finally { connectToDB.Close(); }

            return flag;
        }
        public static bool GetUserInfoByPersonID(int personID, ref int _UserID, ref string _UserName, ref string _Password, ref bool isActive)
        {
            bool flag = false;

            SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);

            string query = "select * from Users where PersonID = @personID;";
            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    flag = true;
                  
                    _UserID = (int)reader["UserID"];
                    _UserName = (string)reader["UserName"];
                    _Password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                flag = false;
            }
            finally { connectToDB.Close(); }

            return flag;
        }
        public static bool GetUserInfoByUserNameAndPassword(ref int _PersonID, ref int _UserID, string _UserName, string _Password, ref bool isActive)
        {
            bool flag = false;

            SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);

            string query = "select * from Users where UserName = @UserName and Password = @Password;";
            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@UserName", _UserName);
            command.Parameters.AddWithValue("@Password", _Password);

            try
            {
                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    flag = true;

                    _UserID = (int)reader["UserID"];
                    _PersonID = (int)reader["PersonID"];
                    isActive = (bool)reader["IsActive"];

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                flag = false;
            }
            finally { connectToDB.Close(); }

            return flag;
        }

        public static bool DeleteUser(int UserID)
        {
            int rowsAffected = 0;

            SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);

            string stCommand = "DELETE FROM Users WHERE UserID = @_UID";
            SqlCommand command = new SqlCommand(stCommand, connectToDB);
            command.Parameters.AddWithValue("_UID", UserID);

            try
            {
                connectToDB.Open();
                rowsAffected = command.ExecuteNonQuery();
            }catch(Exception ex)
            {

            }
            finally { connectToDB.Close(); }

            return rowsAffected > 0;
        }

        public static int AddNewUser(string _UserName, string _Password, int _PersonID, bool _IsActive)
        {
            int UserId = -1;

            SqlConnection connectToDB = new SqlConnection( DataAccessSettings.stConnection);

            string stCommand = @"INSERT INTO Users (PersonID, UserName, Password, IsActive)
                                 VALUES
                                 (@personId, @userName, @password, @isActive);
                                 select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand( stCommand, connectToDB);
            command.Parameters.AddWithValue("@personId", _PersonID);
            command.Parameters.AddWithValue("@userName", _UserName);
            command.Parameters.AddWithValue("@password", _Password);
            command.Parameters.AddWithValue("@isActive", _IsActive);

            try
            {
                connectToDB.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int userIdentity)) {

                    UserId = userIdentity;
                }
            }catch(Exception ex)
            {
                UserId=-1;

            }finally { connectToDB.Close(); }

            return UserId;
        }
        public static bool UpdateUser(int _UserID, string _UserName, string _Password, int _PersonID, bool _IsActive)
        {
            int rowsAffected = 0;

            SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);
          
            string stCommand = @"UPDATE Users
                                SET PersonID = @PersonID,
                                    UserName = @UserName,
                                    Password = @Password,
                                    IsActive = @IsActive
                                    WHERE UserID = @UserId;";

            SqlCommand command = new SqlCommand(stCommand, connectToDB);
            command.Parameters.AddWithValue("@PersonID", _PersonID);
            command.Parameters.AddWithValue("@UserName", _UserName);
            command.Parameters.AddWithValue("@Password", _Password);
            command.Parameters.AddWithValue("@IsActive", _IsActive);
            command.Parameters.AddWithValue("@UserId", _UserID);

            try
            {
                connectToDB.Open();
                rowsAffected = command.ExecuteNonQuery();

            }catch(Exception ex)
            {
                return false;
            }
            finally { connectToDB.Close(); }

            return rowsAffected > 0;

        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.stConnection);

            string query = @"Update  Users  
                             set Password = @Password
                             where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

    }
}
