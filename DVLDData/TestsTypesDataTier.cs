using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDData
{
    public class TestsTypesDataTier
    { 
        public static decimal GetTestTypePrice(int TestTypeID)
        {
            decimal TestPrice = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string Query = @" SELECT TestTypeFees FROM TestTypes WHERE TestTypeID = @TestTypeID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                    TestPrice = (decimal)reader["TestTypeFees"];
                ClsEventLog.HandleEventLog("Data Base Accessed");

                reader.Close();
            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }


            return TestPrice;
        }

        //public static decimal GetApplicationPrice(string ApplicationTypeName)
        //{
        //    decimal ApplicationPrice = 0;
        //    SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
        //    string Query = @" SELECT ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeTitle = @ApplicationTypeName";
        //    SqlCommand command = new SqlCommand(Query, connection);
        //    command.Parameters.AddWithValue("@ApplicationTypeName", ApplicationTypeName);
        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.Read())
        //            ApplicationPrice = (decimal)reader["ApplicationFees"];

        //        reader.Close();
        //    }

        //    catch (Exception ex) { }
        //    finally { connection.Close(); }


        //    return ApplicationPrice;
        //}
        public static DataTable GetApplicationTypes()
        {
            DataTable TestTypes = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string Query = @" SELECT * FROM TestTypes";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    TestTypes.Load(reader);
                ClsEventLog.HandleEventLog("Data Base Accessed");

                reader.Close();
            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }


            return TestTypes;
        }
        //public static string GetApplicationTypeName(int AppID)
        //{
        //    string ApplicationTypeName = "";
        //    SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
        //    string query = @"SELECT ApplicationTypeTitle FROM ApplicationTypes WHERE ApplicationTypeID = @AppID";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@AppID", AppID);
        //    try
        //    {

        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.Read())
        //            ApplicationTypeName = (string)reader["ApplicationTypeTitle"];

        //        reader.Close();
        //    }
        //    catch { }
        //    finally { connection.Close(); }

        //    return ApplicationTypeName;

        //}
        public static bool UpdateTestType(int TestID, string TestTypeName, string TestDescription, decimal fees)
        {
            bool Updated = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Update TestTypes SET TestTypeTitle = @TestTypeName, TestTypeDescription = @TestDescription,
                             TestTypeFees = @fees WHERE TestTypeID = @TestID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@TestTypeName", TestTypeName);
            command.Parameters.AddWithValue("@fees", fees);
            command.Parameters.AddWithValue("@TestDescription", TestDescription);

            try
            {

                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                Updated = (RowsAffected > 0);
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }

            return Updated;

        }
    }
}
