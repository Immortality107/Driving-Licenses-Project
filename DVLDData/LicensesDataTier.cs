using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDData
{
    public class LicensesDataTier
    {


        public static bool GetLicenseInfo(int appID,ref int licenseID,ref int DriverID, ref int licenseClass, ref DateTime issueDate,
           ref DateTime expDate, ref byte issueReasonID, ref string notes, ref decimal paidFees, ref int createdByUserID,
           ref bool isActive)    
        {
         bool InfoFilled = false;
            SqlConnection connection =new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string Query = @"Select * from Licenses where Licenses.ApplicationID = @appID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@appID", appID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    licenseID = (int)reader["LicenseID"];
                    DriverID = (int)reader["DriverID"];
                    licenseClass = (int)reader["LicenseClass"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expDate = (DateTime)reader["ExpirationDate"];
                    if (reader["Notes"] == DBNull.Value)
                    {
                        notes = "";
                    }
                    else
                        notes = (string)reader["Notes"];
                    paidFees = (decimal)reader["PaidFees"];

                    isActive = (bool)reader["IsActive"];
                    issueReasonID = (byte)reader["IssueReason"];
                    createdByUserID = (int)reader["CreatedByUserID"];

                    InfoFilled = true;
                }
                ClsEventLog.HandleEventLog("Data Base Accessed");

                reader.Close();



            }

            catch (Exception ex) { ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}"); }
            finally { connection.Close(); }


          return InfoFilled;
        }

        public static DataTable GetLicensesForEachDriverID(int DriverID)
        {
            DataTable dt = new DataTable();     
              SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string Query = @"Select LicenseID,ApplicationID,LicenseClass
                             , IssueDate, ExpirationDate, IsActive from Licenses where Licenses.DriverID = @DriverID";
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

            catch (Exception ex) { ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}"); }
            finally { connection.Close(); }


            return dt;
        }


        public static int AddLicense(  int appID ,  int DriverID,  int licenseClass,  DateTime issueDate,
         DateTime expDate,  short issueReasonID,  string notes,  decimal paidFees,  int createdByUserID,
         bool isActive)
        {
            int LicenseID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string Query = @"Insert Into Licenses(ApplicationID, DriverID, LicenseClass,IssueDate,
                             ExpirationDate,Notes,PaidFees, IsActive,IssueReason,CreatedByUserID ) Values(@appID,@DriverID, @licenseClass,  @issueDate,
                         @expDate,   @notes,  @paidFees, @isActive,  @issueReasonID, @createdByUserID ); 
                           select SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@appID", appID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@licenseClass", licenseClass);
            command.Parameters.AddWithValue("@issueDate", issueDate);
            command.Parameters.AddWithValue("@expDate", expDate);
            if (notes == null|| notes == "")
                command.Parameters.AddWithValue("@notes", System.DBNull.Value);
            else
            command.Parameters.AddWithValue("@notes", notes);
            command.Parameters.AddWithValue("@paidFees", paidFees);
            command.Parameters.AddWithValue("@isActive", isActive);

            command.Parameters.AddWithValue("@issueReasonID", issueReasonID);

            command.Parameters.AddWithValue("@createdByUserID", createdByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();               
                if ( result != null && int.TryParse(result.ToString(),out int InsertedID ))
               LicenseID = InsertedID;
                ClsEventLog.HandleEventLog("Data Base Accessed");


            }

            catch (Exception ex) { ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}"); }
            finally { connection.Close(); }


            return LicenseID;
        }
        public static bool GetLicenseInfoByLicenceID(int licenseID, ref int appID, ref int DriverID, ref int licenseClass, ref DateTime issueDate,
       ref DateTime expDate, ref byte issueReasonID, ref string notes, ref decimal paidFees, ref int createdByUserID,
       ref bool isActive)
        {
            bool InfoFilled = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string Query = @"Select * from Licenses where Licenses.licenseID = @licenseID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@licenseID", licenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    appID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    licenseClass = (int)reader["LicenseClass"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expDate = (DateTime)reader["ExpirationDate"];
                    if (reader["Notes"] == DBNull.Value)
                    {
                        notes = "";
                    }
                    else
                        notes = (string)reader["Notes"];
                    paidFees = (decimal)reader["PaidFees"];

                    isActive = (bool)reader["IsActive"];
                    issueReasonID = (byte)reader["IssueReason"];
                    createdByUserID = (int)reader["CreatedByUserID"];

                    InfoFilled = true;
                }
                ClsEventLog.HandleEventLog("Data Base Accessed");

                reader.Close();



            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }


            return InfoFilled;
        }

        public static int UpdateLicenseStatus(int LicenseID)
        {
            int RowsAffected = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string Query = @"Update Licenses set IsActive = case 
                              when IsActive = 0 then 1
                              else 0 end
                              where LicenseID= @LicenseID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
   
            try
            {
                connection.Open();
               RowsAffected = command.ExecuteNonQuery();
                ClsEventLog.HandleEventLog("Data Base Accessed");


            }

            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }


            return RowsAffected;
        }
    }
}

