using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDData
{
    internal class LicenseCategoryDataTier
    {
        public static DataTable GetLicensesClasses()
        {
            DataTable Classes = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT ClassName FROM LicenseClasses";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    Classes.Load(reader);

                }
                else Classes = null;

                reader.Close();
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); } 
            return Classes;
        }
        public static byte GetLicenseValidityLength(int LicenseClassID)
        {
            byte LicenseValidityLength = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT DefaultValidityLength FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    LicenseValidityLength = (byte) reader ["DefaultValidityLength"];
                }


                reader.Close();
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }
            return LicenseValidityLength;
        }
        public static int GetLicenseClassID(string ClassName)
        {
            int LicenseClassID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT LicenseClassID FROM LicenseClasses WHERE ClassName = @ClassName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    LicenseClassID = (int) reader ["LicenseClassID"];

                }
                

                reader.Close();
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }
            return LicenseClassID;
        }
        public static string GetLicenseClassName(int ClassID)
        {
            string LicenseClassName = "";
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT ClassName FROM LicenseClasses WHERE LicenseClassID = @ClassID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassID", ClassID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    LicenseClassName = (string)reader["ClassName"];

                }

                ClsEventLog.HandleEventLog("Data Base Accessed");

                reader.Close();

            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }
            return LicenseClassName;
        }
    }
}
