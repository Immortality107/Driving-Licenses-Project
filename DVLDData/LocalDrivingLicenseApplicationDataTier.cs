using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDData
{
    internal class LocalDrivingLicenseApplicationDataTier
    {

        public static int AddNewLocalLicense( int ApplicationID, int LicenseClassID) {

            int LocalDrivingLicenseAppID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO LocalDrivingLicenseApplications(ApplicationID, LicenseClassID) VALUES 
                             (@ApplicationID, @LicenseClassID);
                              SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                    LocalDrivingLicenseAppID = InsertedID;

                ClsEventLog.HandleEventLog("Data Base Accessed");
            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }

            return LocalDrivingLicenseAppID;
        }
        public static bool IsThereNewApplicationForSameLicenseCategory(int ApplicantPersonID, int LicenseClassID)
        {
            bool Found = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Select Found=1 from LocalDrivingLicenseFullApplications_View where 
                           ApplicantPersonID = @ApplicantPersonID and LicenseClassID = @LicenseClassID and ApplicationStatus = 1";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Found = reader.HasRows;
                ClsEventLog.HandleEventLog("Data Base Accessed");
            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }

            return Found;
        }
        //public static bool Update_View(int AppID, string DrivingClass , string NationNo, string FullName,
        //                           DateTime ApplicationDate, int PassedTests, string Status)
        //{
        //    int rowsAffected = 0;
        //    SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
        //    string query = @"Update LocalDrivingLicenseApplications set LocalDrivingLicenseApplicationID = @AppID
        //                   , ClassName = @DrivingClass, NationalNo = @NationNo, FullName= @FullName, 
        //                        ,ApplicationDate = @ApplicationDate, PassedTestCount = @PassedTests, Status = @Status";


        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@AppID", AppID);
        //    command.Parameters.AddWithValue("@DrivingClass", DrivingClass);
        //    command.Parameters.AddWithValue("@NationNo", NationNo);
        //    command.Parameters.AddWithValue("@FullName", FullName);
        //    command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
        //    command.Parameters.AddWithValue("@PassedTests", PassedTests);
        //    command.Parameters.AddWithValue("@Status", Status);

        //    try
        //    {

        //        connection.Open();
        //       rowsAffected = command.ExecuteNonQuery();
        //    }
        //    catch (Exception ex) { }
        //    finally { connection.Close(); }


        //    return rowsAffected > 0 ;
        //}

        public static int GetLDLAppID(int ApplicationID, int LicenseClassID)
        {

            int LocalDrivingLicenseAppID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT LocalDrivingLicenseApplicationID FROM LocalDrivingLicenseApplications WHERE
                              ApplicationID = @ApplicationID, 
                             LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    LocalDrivingLicenseAppID = (int)reader["LocalDrivingLicenseApplicationID"];
                }
                reader.Close();
                ClsEventLog.HandleEventLog("Data Base Accessed");
            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }

            return LocalDrivingLicenseAppID;
        }

        public static DataTable GetAllLocalLicenseApps_View()
        {

            DataTable LocalLicenseAppsTable = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM LocalDrivingLicenseApplications_View";

            SqlCommand command = new SqlCommand(query, connection);
   

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                    LocalLicenseAppsTable.Load(reader);
                ClsEventLog.HandleEventLog("Data Base Accessed");
                reader.Close();
            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }

            return LocalLicenseAppsTable;
        }


        public static bool Update(int LocalDrivingLicenseAppID, int LicenseClassID)
        {
            bool UPDATED = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"UPDATE LocalDrivingLicenseApplications SET  
                             LicenseClassID = @LicenseClassID WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseAppID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseAppID", LocalDrivingLicenseAppID);
            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                UPDATED = (RowsAffected > 0);
                ClsEventLog.HandleEventLog("Data Base Accessed");
            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }

            return UPDATED;
        }
        public static int GetAppID(int LDLAppID)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT ApplicationID FROM LocalDrivingLicenseApplications WHERE
                              LocalDrivingLicenseApplicationID = @LDLAppID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLAppID", LDLAppID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationID"];
                }
                reader.Close();
                ClsEventLog.HandleEventLog("Data Base Accessed");
            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }

            return ApplicationID;
        }

        public static bool Delete(int LocalDrivingLicenseAppID)
        {
            bool Deleted = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Delete from LocalDrivingLicenseApplications   
                              WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseAppID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseAppID", LocalDrivingLicenseAppID);
            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();
                Deleted = (RowsAffected > 0);
                ClsEventLog.HandleEventLog("Data Base Accessed");
            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }

            return Deleted;
        }
    }
}
