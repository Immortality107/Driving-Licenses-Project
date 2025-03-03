using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDData
{
    internal class TestAppointmentsDataTier
    {
        public static int AddNewTestAppointment(int TestTypeID,int LDLAppID, DateTime AppointmentDate,
                                    decimal PaidFees, int CreatedByUserID, bool IsLocked)
        {
            int AppointmentID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Insert Into TestAppointments(TestTypeID,LocalDrivingLicenseApplicationID, AppointmentDate,
                           PaidFees,CreatedByUserID,IsLocked) VALUES
                           (@TestTypeID,@LDLAppID, @AppointmentDate,
                           @PaidFees,@CreatedByUserID,@IsLocked);
                                SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);


            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    AppointmentID = insertedID;
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }


            return AppointmentID;
        }
        public static DataTable GetAppointmentsWithLDLAppID(int LDLAppID, int TestTypeID)
        {
;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"select TestAppointmentID, AppointmentDate,
                           PaidFees, IsLocked from TestAppointments where LocalDrivingLicenseApplicationID = @LDLAppID and
                              TestTypeID = @TestTypeID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }


            return dt;
        }

        public static bool LockTestAppointmentAfterTest(int LDLAppID)
        {
            bool Locked=false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Update TestAppointments set IsLocked = 1 where LocalDrivingLicenseApplicationID = @LDLAppID and
                             IsLocked = 0;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
            try
            {
                connection.Open();
                int rowsaffected = command.ExecuteNonQuery();
                Locked= rowsaffected > 0;
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }


            return Locked;
        }
        public static bool UpdateAppointmentDate(int TestAppointmentID, DateTime NewDate)
        {
            bool AppointmentDateUpdated = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Update TestAppointments set AppointmentDate = @NewDate where TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@NewDate", NewDate);

            try
            {
                connection.Open();
                int rowsaffected = command.ExecuteNonQuery();
                AppointmentDateUpdated = rowsaffected > 0;
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }


            return AppointmentDateUpdated;
        }
        public static bool AddRetakeTestApplicationID(int TestAppointmentID, int RetakeTestApplicationID)
        {
            bool Added = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Update TestAppointments set RetakeTestApplicationID = @RetakeTestApplicationID 
                           where TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                connection.Open();
                int rowsaffected = command.ExecuteNonQuery();
                Added = rowsaffected > 0;
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }


            return Added;
        }
    }
}
