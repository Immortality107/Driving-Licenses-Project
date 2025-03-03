﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDData
{
    internal class TestsDataTier
    {
        public static int AddTest(int TestAppointmentID, bool TestResult,
                               string Notes, int CreatedByUserID)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Insert Into Tests(TestAppointmentID,TestResult, Notes,CreatedByUserID )Values (
                          @TestAppointmentID,@TestResult, @Notes,@CreatedByUserID    );
                                SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    TestID = insertedID;
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }


            return TestID;
        }
        public static bool GetTestIDAndTestResult(int TestAppointmentID, ref int TestID, ref bool Passed)
        {
             bool gotInfo= false;   
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT TestID, TestResult From Tests where TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
          

            try
            {

                connection.Open();
              SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TestID = (int)reader["TestID"];
                    Passed   = (bool)reader["TestResult"];
                    gotInfo = true;
                }
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }


            return gotInfo;
        }
        public static bool PassedTest( int TestAppointmentID)
        {
            bool Passed = false; 
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT Found=1 From Tests where TestAppointmentID = @TestAppointmentID and TestResult=1";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                Passed = reader.HasRows;
                ClsEventLog.HandleEventLog("Data Base Accessed");

            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }


            return Passed;
        }
    }
}
