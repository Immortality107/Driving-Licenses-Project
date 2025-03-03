using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDData
{
    internal class DetainedLicensesDataTier
    {
        public static DataTable GetDetainedLicenses()
        {
            DataTable dtDetainedLicenses = new DataTable();

            SqlConnection Connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM DetainedLicenses_View Order by DetainID desc";

            SqlCommand Command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {

                    dtDetainedLicenses.Load(Reader);
                }
                ClsEventLog.HandleEventLog("Data Base Accessed");

                Reader.Close();

            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }


            finally
            {
                Connection.Close();
            }
            return dtDetainedLicenses;

        }
        public static bool IsLicenseDetained(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Select IsFound=1 FROM DetainedLicenses where LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            bool IsFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
                ClsEventLog.HandleEventLog("Data Base Accessed");
                reader.Close();
            }

            catch (Exception ex) { ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}"); }
            finally { connection.Close(); }
            return IsFound;
        }
        public static bool IsLicenseReleased(int LicenseID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Select Released=1 FROM DetainedLicenses where LicenseID = @LicenseID And IsReleased='True'";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            bool IsReleased = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsReleased = reader.HasRows;
                reader.Close();
                ClsEventLog.HandleEventLog("Data Base Accessed");
            }

            catch (Exception ex) { ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}"); }
            finally { connection.Close(); }
            return IsReleased;
        }

        public static int AddDetainedLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int createdByUserID,byte IsReleased=0)
         
        {
            int DetainID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string Query = @"Insert Into DetainedLicenses(LicenseID, DetainDate, FineFees,createdByUserID,
                             IsReleased) Values(@LicenseID,@DetainDate, @FineFees
                           , @createdByUserID,  @IsReleased); 
                           select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@createdByUserID", createdByUserID);
            command.Parameters.AddWithValue("@IsReleased", IsReleased);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                    DetainID = InsertedID;

                ClsEventLog.HandleEventLog("Data Base Accessed");
            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }
            return DetainID;
        }
        public static bool GetDetainedLicenseInfo(int LicenseID, ref int DetainID,ref int DetainCreatedbyUserID, ref DateTime DetainDate, ref decimal FineFees)

        {
            bool GotInfo = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string Query = @"Select DetainID, DetainDate,CreatedByUserID, FineFees from DetainedLicenses Where LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    DetainCreatedbyUserID = (int)reader["CreatedByUserID"];
                    FineFees = (decimal)reader["FineFees"];
                    GotInfo = true;
                    
                }
                ClsEventLog.HandleEventLog("Data Base Accessed");


            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }
            return GotInfo;
        }

        public static bool IsReleasedAndReleaseInfoAdded(int LicenseID, DateTime ReleaseDate, int ReleasedByUserID, int AppID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Update DetainedLicenses set IsReleased=1, ReleaseDate=@ReleaseDate, ReleasedByUserID =@ReleasedByUserID, 
                            ReleaseApplicationID = @AppID where LicenseID = @LicenseID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@AppID", AppID);

            bool IsReleased = false;
            try
            {
                connection.Open();
               int rowsAffected = command.ExecuteNonQuery();
               IsReleased = rowsAffected > 0;
                ClsEventLog.HandleEventLog("Data Base Accessed");
            }

            catch(Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }
            return IsReleased;
        }
    }
    }
