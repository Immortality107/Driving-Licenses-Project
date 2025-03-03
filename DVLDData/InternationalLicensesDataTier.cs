using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDData
{
    public class InternationalLicensesDataTier
    {

        public static DataTable GetInternationalLicenses()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string Query = @"Select InternationalLicenseID,ApplicationID,DriverID, IssuedUsingLocalLicenseID
                             , IssueDate, ExpirationDate, IsActive from InternationalLicenses Order by InternationalLicenseID desc";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
                reader.Close();
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }

            catch (Exception ex) { ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}"); }
            finally { connection.Close(); }


            return dt;
        }
        public static DataTable GetInternationalLicenseForEachDriverID(int DriverID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string Query = @"Select InternationalLicenseID,ApplicationID, IssuedUsingLocalLicenseID
                             , IssueDate, ExpirationDate, IsActive from InternationalLicenses where DriverID = @DriverID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dt.Load(reader);
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

        public static int IssueNewInternationalLicense(int DriverID,int AppID, int LocalLicenseID,DateTime IssueDate,
                                                     DateTime ExpDate, int UserID, bool IsActive )
        {
            int InternationalLicenseID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string Query = @"Insert Into InternationalLicenses(ApplicationID,DriverID,IssuedUsingLocalLicenseID,
                              IssueDate, ExpirationDate, IsActive,CreatedByUserID ) Values (@AppID,@DriverID,@LocalLicenseID,
                                  @IssueDate, @ExpDate,@IsActive, @UserID);
                                  SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@AppID", AppID);
            command.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpDate", ExpDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    InternationalLicenseID = insertedID;
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }


            return InternationalLicenseID;
        }

        public static bool IsPersonHasInternationalLicense(int DriverID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Select IsFound=1 FROM InternationalLicenses where DriverID = @DriverID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            bool IsFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
                reader.Close();
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }
            return IsFound;
        }
    }
}
