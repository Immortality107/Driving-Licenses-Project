using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLDProject.DVLDData
{
    internal class ApplicationsDataTier
    {
        public static int AddNewApp(int PersonID, DateTime date, int ApplicationType, int ApplicationStatus,
                                    DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID) {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Insert Into Applications(ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                           ApplicationStatus, LastStatusDate, PaidFees , CreatedByUserID ) VALUES
                           (@PersonID, @date, @ApplicationType, @ApplicationStatus,
                             @LastStatusDate, @PaidFees, @CreatedByUserID);
                                SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID",PersonID );
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@ApplicationType", ApplicationType);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    ApplicationID = insertedID;
                ClsEventLog.HandleEventLog("Data Base Accessed To Add New Application");
            }
            catch (Exception ex) {
                ClsEventLog.HandleEventLog($"Failed To Add New Application {ex.Message}");
            }
            finally { connection.Close(); }


            return ApplicationID;
        }

        public static bool UpdateStatus(int AppID, DateTime date, bool Completed=false)
        {
            int rowsAffected = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"UPDATE Applications set 
                           LastStatusDate = @date,
                           ApplicationStatus = case 
                           when @Completed = 0 then 2
                            else 3 end
                           where ApplicationID = @AppID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AppID", AppID);
            command.Parameters.AddWithValue("@Completed", Completed);
            command.Parameters.AddWithValue("@date", date);

            try
            {

                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
                ClsEventLog.HandleEventLog("Data Base Accessed To Update Status");

            }
            catch (Exception ex) { ClsEventLog.HandleEventLog($"Failed To Update Status {ex.Message}"); }
            finally { connection.Close(); }


            return rowsAffected > 0;
        }

       
        public static int GetApplicationIDByPerson(int PersonID)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT ApplicationID FROM Applications WHERE ApplicantPersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) { 
                    ApplicationID = (int)reader ["ApplicationID"] ; }
                reader.Close();
                ClsEventLog.HandleEventLog("Data Retrieved From DataBase");
            }
            catch (Exception ex) {
                ClsEventLog.HandleEventLog($"Failed To Retrieve Data From DataBase{ex.Message}");

            }
            finally { connection.Close(); }


            return ApplicationID;
        }
      
        public static bool GetApplicationInfo(int ApplicationID  , ref int ApplicantPersonID, ref DateTime ApplicationDate,
                                              ref int ApplicationTypeID, ref int ApplicationStatus, ref DateTime LastStatusDate,
                                               ref decimal PaidFees , ref int CreatedByUserID)
        {
            bool ReceivedInfo = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM Applications WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ReceivedInfo = true;
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];

                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    ApplicationStatus = (int)reader["ApplicationStatus"];

                    ClsEventLog.HandleEventLog("Data Retrieved From DataBase");
                }
                reader.Close();
                ClsEventLog.HandleEventLog("Failed To Retrieve Data From DataBase");

            }
            catch (Exception ex) {
                ClsEventLog.HandleEventLog($"Failed To Retrieve Data From DataBase{ex.Message}");
            }
            finally { connection.Close(); }


            return ReceivedInfo;
        }

        public static bool GetApplicationsViewInfo(int LDLApplicationID,ref string ClassName,ref int PassedTestsCount)
        {
            bool ReceivedInfo = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT ClassName, PassedTestCount FROM LocalDrivingLicenseApplications_View WHERE LocalDrivingLicenseApplicationID = @LDLApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ReceivedInfo = true;
                    ClassName = (string)reader["ClassName"];
                    PassedTestsCount = (int)reader["PassedTestCount"];


                    ClsEventLog.HandleEventLog("Data Retrieved From DataBase");



                }
                ClsEventLog.HandleEventLog("Failed To Retrieve Data From DataBase");

                reader.Close();
            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Retrieve Data From DataBase{ex.Message}");
            }
            finally { connection.Close(); }

            return ReceivedInfo;
        }

    }
}
