using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDData
{
    public class DriverDataTier
    {

        public static DataTable GetAllDrivers()
        {
            SqlConnection connection = new SqlConnection( DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            DataTable dataTable = new DataTable();
            string query = @"SELECT * From Drivers_View Order By FullName";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);


                }
                ClsEventLog.HandleEventLog("Data Base Accessed");
                reader.Close();

            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }

            return dataTable;    

        }

        public static int GetDriverIDWithPersonID(int PersonID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            int DriverID = -1;
            string query = @"SELECT DriverID From Drivers WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DriverID = insertedID;
                }
                ClsEventLog.HandleEventLog("Data Base Accessed");
            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }

            return DriverID ;

        }

        public static int GetPersonIDWithDriverID(int DriverID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            int PersonID = -1;
            string query = @"SELECT PersonID From Drivers WHERE DriverID = @DriverID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
                ClsEventLog.HandleEventLog("Data Base Accessed");
            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }

            return PersonID;

        }

        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            int DriverID = -1;
            string query = @"Insert into Drivers(PersonID,CreatedByUserID, CreatedDate)
                               Values(@PersonID,@CreatedByUserID, @CreatedDate);
                                  SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                     DriverID = insertedID;
                }
                ClsEventLog.HandleEventLog("Data Base Accessed");
            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }

            return  DriverID;

        }
    }
}
