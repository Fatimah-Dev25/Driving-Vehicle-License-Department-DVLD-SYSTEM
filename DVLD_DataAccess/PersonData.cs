using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccess
{
    public class PersonData
    {
        public static bool GetPersonInfoByID(int personID, ref string NatNum, ref string FName, ref string SecondName,
            ref string ThirdName, ref string LName, ref DateTime BirthDate, ref byte Gender, ref string Address, 
            ref string Phone, ref string Email, ref int NatCountryID, ref string ImgPath)
        {
            bool isFound = false;
            SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);
            
            string query = "select * from People where PersonID = @personID";
            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    NatNum = reader["NationalNo"].ToString();
                    FName = reader["FirstName"].ToString();
                    SecondName = reader["SecondName"].ToString();

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = reader["ThirdName"].ToString();
                    }
                    else
                        ThirdName = "";

                    LName = reader["LastName"].ToString();
                    Phone = reader["Phone"].ToString();
                    BirthDate = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    NatCountryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                        ImgPath = (string)reader["ImagePath"];
                    else
                        ImgPath = "";
                    
                }
                else { isFound = false; }

                reader.Close();

            }catch (Exception ex)
            {
                isFound = false;
            }
            finally { connectToDB.Close(); }

            return isFound;

        }

        public static bool GetPersonInfoByNatNum(string NationalNo, ref int PersonID, ref string FirstName,
            ref string SecondName, ref string ThirdName, ref string LastName, ref string Phone,  
            ref byte Gender, ref DateTime DateOfBirth, ref string Email, ref string Address,
            ref string ImagePath, ref int NationalCountryNo)
        {

            bool isFound = false;
            SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);

            string query = "select * from People where NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connectToDB);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try { 

                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];

                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["ThirdName"];
                    else
                        ThirdName = "";

                    Phone = (string)reader["Phone"];
                    Address = (string)reader["Address"];
                    Gender = (byte)reader["Gendor"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";

                    NationalCountryNo = (int)reader["NationalityCountryID"];

                }
                else { isFound = false; }

                reader.Close();

            }catch (Exception ex) { 

                isFound = false;

            } finally { connectToDB.Close(); }

            return isFound;
        }
        public static int AddNewPerson(string Fname, string Sname, string Thname, string Lname,
            string NationalNo, string phone, string Email, string Address, byte Gender, DateTime DateOfBirth,
            string ImagePath, int natCountryID)
        {
            int newPersonID = -1;

            SqlConnection connectoDB = new SqlConnection(DataAccessSettings.stConnection);

            string stCommand = @"INSERT INTO People
                                 (NationalNo, FirstName, SecondName, ThirdName,LastName, DateOfBirth,
                                  Gendor, Address,Phone,Email, NationalityCountryID, ImagePath)
                                 VALUES
                                 (@NationalNo, @Fname, @Sname, @Thname, @Lname, @DateOfBirth,
                                  @Gender, @Address, @phone, @Email, @natCountryID, @ImagePath);
	                             select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(stCommand, connectoDB);
            command.Parameters.AddWithValue("@NationalNo",NationalNo);
            command.Parameters.AddWithValue("@Fname", Fname);
            command.Parameters.AddWithValue("@Sname", Sname);
            command.Parameters.AddWithValue("@Lname", Lname);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@phone", phone);
            command.Parameters.AddWithValue("@natCountryID", natCountryID);
            command.Parameters.AddWithValue("@Gender", Gender);

            if(Thname != "" && Thname != null)
                command.Parameters.AddWithValue("@Thname", Thname);
            else
                command.Parameters.AddWithValue("@Thname", System.DBNull.Value);


            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try { 

                connectoDB.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    newPersonID = insertedID;
                }

            }
            catch (Exception ex) {

                newPersonID = -1;

            } finally {
                connectoDB.Close();
            }

            return newPersonID;
        }

        public static bool UpdatePerson(int personID, string NationalNo, string FirstName, string SecondName,
                                  string ThirdName, string LastName, DateTime DateOfBirth, byte Gendor,
                                  string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int rowAffected = 0;

            SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);

            string stCommand = @"UPDATE People
                                 SET 
                                  NationalNo = @NationalNo
                                 ,FirstName = @FirstName
                                 ,SecondName = @SecondName
                                 ,ThirdName = @ThirdName
                                 ,LastName = @LastName
                                 ,DateOfBirth = @DateOfBirth
                                 ,Gendor = @Gendor
                                 ,Address = @Address
                                 ,Phone = @Phone
                                 ,Email = @Email
                                 ,NationalityCountryID = @NationalityCountryID
                                 ,ImagePath = @ImagePath
                                 WHERE PersonID = @personID";
            
            SqlCommand command = new SqlCommand(stCommand, connectToDB);
            command.Parameters.AddWithValue("@personID", personID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != "" && ThirdName != null)
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
           
            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value); command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
          
            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            { 
            
                connectToDB.Open();

                rowAffected = command.ExecuteNonQuery();

            
            }catch (Exception ex) {

                return false;
            
            }finally { connectToDB.Close(); }
            

            return rowAffected > 0;
        }
   
        public static bool DeletePerson(int PersonID)
        {
            int rowAffected = 0;

            SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);

            string stCommand = "delete People where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(stCommand, connectToDB);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try {

                connectToDB.Open();
                rowAffected = command.ExecuteNonQuery();
            
            }catch (Exception ex) {
                
                return false;
            
            } finally { 
                
                connectToDB.Close(); }


            return (rowAffected > 0);
        }

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connectToDB = new SqlConnection( DataAccessSettings.stConnection);

            string stCommand = "select isFound = 1 from People where PersonID = @PersonID";
            SqlCommand command = new SqlCommand( stCommand, connectToDB);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try {

                connectToDB.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound  = reader.HasRows;
            
                reader.Close();
            }catch (Exception ex) {

                isFound = false;

            } finally {
                
                connectToDB.Close(); }
       
            return isFound;
        }

        public static bool IsPersonExist(string NationalNo)
        {
            bool isFound = false;

            SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);

            string stCommand = "select isFound = 1 from People where NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(stCommand, connectToDB);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

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

        public static DataTable GetAllPeople()
        {
            DataTable dataResult = new DataTable();
            SqlConnection connectToDB = new SqlConnection(DataAccessSettings.stConnection);

            string stCommand = @"select PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, 
                                 Case
                                    when Gendor = 0 then 'Male'
                                    else 'Female' 
                                    end as Gender
                                 ,DateOfBirth, Phone, Email,Address, ImagePath,
                                 NationalityCountryID, Countries.CountryName 
                                 from People inner join Countries on People.NationalityCountryID = Countries.CountryID;";
                               
            SqlCommand command = new SqlCommand( stCommand, connectToDB);

            try {

                connectToDB.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataResult.Load(reader);

                }

                reader.Close();
            
            } catch (Exception ex) { 


            }finally {
                connectToDB.Close(); 
            }

            return dataResult;
        }

    }
}
