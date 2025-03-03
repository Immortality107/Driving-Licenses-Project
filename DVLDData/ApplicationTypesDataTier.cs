using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDData
{
    internal class ApplicationTypesDataTier
    {
        public static decimal GetApplicationPrice(int ApplicationTypeID )
        {
            decimal ApplicationPrice = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string Query = @" SELECT ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationPrice = (decimal)reader["ApplicationFees"];
                    ClsEventLog.HandleEventLog("Data Base Accessed");

                }
                ClsEventLog.HandleEventLog("Failed To Access DataBase");

                reader.Close();
            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase{ex.Message}");
            }
            finally { connection.Close(); }


            return ApplicationPrice ;
        }

        public static decimal GetApplicationPrice(string ApplicationTypeName)
        {
            decimal ApplicationPrice = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string Query = @" SELECT ApplicationFees FROM ApplicationTypes WHERE ApplicationTypeTitle = @ApplicationTypeName";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationTypeName", ApplicationTypeName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationPrice = (decimal)reader["ApplicationFees"];
                    ClsEventLog.HandleEventLog("Data Base Accessed");
                }
                ClsEventLog.HandleEventLog("Failed To Access DataBase");

                reader.Close();
            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase{ex.Message}");
            }
            finally { connection.Close(); }


            return ApplicationPrice;
        }
        public static DataTable GetApplicationTypes()
        {
            DataTable ApplicationTypes = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string Query = @" SELECT * FROM ApplicationTypes ";
            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    ApplicationTypes.Load(reader);
                    ClsEventLog.HandleEventLog("Data Base Accessed");
                }
                ClsEventLog.HandleEventLog("Failed To Access DataBase");

                reader.Close();
            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase{ex.Message}");
            }
            finally { connection.Close(); }


            return ApplicationTypes;
        }
        public static string GetApplicationTypeName(int AppID)
        {
            string ApplicationTypeName = "";
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT ApplicationTypeTitle FROM ApplicationTypes WHERE ApplicationTypeID = @AppID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppID", AppID);
            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationTypeName = (string)reader["ApplicationTypeTitle"];
                    ClsEventLog.HandleEventLog("Data Base Accessed");
                }
                ClsEventLog.HandleEventLog("Failed To Access DataBase");

                reader.Close();
            }
            catch(Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase{ex.Message}");
            }
            finally { connection.Close(); }

            return ApplicationTypeName ;

        }

        public static bool UpdateApplicationType(int AppID, string ApplicationTypeName, decimal fees)
        {
            bool Updated = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Update ApplicationTypes SET ApplicationTypeTitle = @ApplicationTypeName,
                             ApplicationFees = @fees WHERE ApplicationTypeID = @AppID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppID", AppID);
            command.Parameters.AddWithValue("@ApplicationTypeName", ApplicationTypeName);
            command.Parameters.AddWithValue("@fees", fees);

            try
            {

                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                Updated = (RowsAffected > 0);
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }
            catch(Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase{ex.Message}");
            }
            finally { connection.Close(); }

            return Updated;

        }
    }
}
