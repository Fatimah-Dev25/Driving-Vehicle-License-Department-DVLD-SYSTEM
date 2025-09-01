using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class TestTypeData
    {
        public static bool GetTestTypeInfoByID(int TestTypeId, ref string TestTypeTitle, 
                                          ref string TestDescription, ref float TestFees)
        {
            bool isFound = false;
            SqlConnection conn = new SqlConnection(DataAccessSettings.stConnection);

            string stCommand = "select * from TestTypes where TestTypeID = @TestTypeID;";
            SqlCommand command = new SqlCommand(stCommand, conn);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeId);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;
                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestDescription = (string)reader["TestTypeDescription"];
                    TestFees = Convert.ToSingle(reader["TestTypeFees"]);
                }
                reader.Close();

            }catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isFound;
        }
   
        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(DataAccessSettings.stConnection);

            string query = "select * from TestTypes";
            SqlCommand command = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }catch(Exception ex)
            {

            }finally { conn.Close(); }

            return dt;
        }

        public static int AddNewTestType(string Title, string Description, float Fees)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.stConnection);
            string stCommand = @"INSERT INTO TestTypes
                                 (TestTypeTitle,TestTypeDescription, TestTypeFees)
                                 VALUES
                                 (@TestTitle, @TestDescribtion, @TestFees);
		                         select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(stCommand, connection);
            command.Parameters.AddWithValue("@TestTitle", Title);
            command.Parameters.AddWithValue("@TestDescribtion", Description);
            command.Parameters.AddWithValue("@TestFees", Fees);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestID = insertedID;
                }

            }catch(Exception ex)
            {

            }
            finally { connection.Close(); }

            return TestID;
        }
  
        public static bool UpdateTestType(int TestID,  string Title, string Description, float Fees)
        {
            int rowsAffeccted = 0; 
            SqlConnection connection = new SqlConnection(DataAccessSettings.stConnection);

            string stCommand = @"update TestTypes
                                 set TestTypeTitle = @testTitle ,
                                     TestTypeDescription = @testDescribtion ,
                                     TestTypeFees = @testFees
                                 where TestTypeID = @testID";

            SqlCommand command = new SqlCommand(stCommand, connection);
            command.Parameters.AddWithValue("@testTitle", Title);
            command.Parameters.AddWithValue("@testDescribtion", Description);
            command.Parameters.AddWithValue("@testFees", Fees);
            command.Parameters.AddWithValue("@testID", TestID);

            try
            {
                connection.Open();
                rowsAffeccted = command.ExecuteNonQuery();
            }catch(Exception ex)
            {

            }finally { connection.Close(); }

            return rowsAffeccted > 0;
        }
    }
}
