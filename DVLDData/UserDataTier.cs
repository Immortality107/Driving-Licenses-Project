using System;
using DataAccessSettings;
using System.Data.SqlClient;
using System.Data;
using System.Linq.Expressions;
using System.CodeDom;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using DVLDProject;

namespace UserData
{
    public class clsUser
    {

        public static DataTable GetUsers() {
            SqlConnection Connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT Users.UserID, Users.PersonID,
                            FullName = 
                            People.FirstName + ' ' + People.SecondName + ' ' +
                            People.ThirdName + ' ' + People.LastName , 
                           Users.UserName, Users.IsActive  from Users 
                             join People on 
                            Users.PersonID = People.PersonID 
                             ORDER BY UserID";
            SqlCommand Command = new SqlCommand(query, Connection);
            DataTable dtUsers = null;

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)

                {
                    dtUsers = new DataTable();
                    dtUsers.Load(Reader);
                }
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
            return dtUsers;


        }
        //public static bool GetUserInfoByUserID(int UserID, ref int PersonID, ref string UserName,
        //    ref string Password, ref bool IsActive)
        //{
        //    bool isFound = false;

        //    SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);

        //    string query = "SELECT * FROM Users WHERE UserID = @UserID";

        //    SqlCommand command = new SqlCommand(query, connection);

        //    command.Parameters.AddWithValue("@UserID", UserID);

        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            // The record was found
        //            isFound = true;

        //            PersonID = (int)reader["PersonID"];
        //            UserName = (string)reader["UserName"];
        //            Password =  (string)reader["Password"];
        //            IsActive = (bool)reader["IsActive"];


        //        }
        //        else
        //        {
        //            // The record was not found
        //            isFound = false;
        //        }

        //        reader.Close();


        //    }
        //    catch (Exception ex)
        //    {
        //        //Console.WriteLine("Error: " + ex.Message);
        //        ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");

        //        isFound = false;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return isFound;
        //}

        public static int AddNewUser(int PersonID, string UserName,
             string Password, bool IsActive)
        {
            //this function will return the new person id if succeeded and -1 if not.
            int UserID = -1;
            string HashedPassword= ClsHashing.ComputeHash(Password);
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Users (PersonID,UserName,Password,IsActive)
                             VALUES (@PersonID, @UserName,@Password,
                              @IsActive);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", HashedPassword);
            command.Parameters.AddWithValue("@IsActive", IsActive);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");

            }

            finally
            {
                connection.Close();
            }

            return UserID;
        }

        //public static bool GetUserInfoByPersonID(int PersonID, ref int UserID, ref string UserName,
        //  ref string Password, ref bool IsActive)
        //{
        //    bool isFound = false;

        //    SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);

        //    string query = "SELECT * FROM Users WHERE PersonID = @PersonID";

        //    SqlCommand command = new SqlCommand(query, connection);

        //    command.Parameters.AddWithValue("@PersonID", PersonID);

        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            // The record was found
        //            isFound = true;

        //            UserID = (int)reader["UserID"];
        //            UserName = (string)reader["UserName"];
        //            Password = (string)reader["Password"];
        //            IsActive = (bool)reader["IsActive"];


        //        }
        //        else
        //        {
        //            // The record was not found
        //            isFound = false;
        //        }

        //        reader.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        //Console.WriteLine("Error: " + ex.Message);
        //        ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");

        //        isFound = false;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return isFound;
        //}
        public static string GetUserNameByUserID( int UserID)
        {
            string UserName = "";

            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);

            string query = "SELECT Username FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    UserName = (string)reader["UserName"];


                }

                reader.Close();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");

            }
            finally
            {
                connection.Close();
            }

            return UserName;
        }

        public static bool FindUserByUserNameAndPassword(
            string UserName, string Password,
            ref int UserID, ref int PersonID, ref bool IsActive)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE Username = @Username and Password=@Password;";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@Username", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                Connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                    UserID = (int)Reader["UserID"];
                    PersonID = (int)Reader["PersonID"];
                    IsActive = (bool)Reader["IsActive"];
                }
                Reader.Close();


            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");

            }

            finally {
                Connection.Close();
            }

            return IsFound;
        }




        //public static bool Update(int PersonID, int UserID, string UserName,
        //     string Password, bool IsActive)
        //{

        //    int rowsAffected = 0;
        //    SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
        //    string query = @"UPDATE Users SET PersonID = @PersonID,
        //                     Password= @Password,
        //                     Username = @UserName,
        //                     IsActive = @IsActive 
        //                     where UserID = @UserID";
        //    SqlCommand Command = new SqlCommand(query, connection);
        //    Command.Parameters.AddWithValue("@PersonID", PersonID);
        //    Command.Parameters.AddWithValue("@Password", Password);
        //    Command.Parameters.AddWithValue("@UserName", UserName);
        //    Command.Parameters.AddWithValue("@IsActve", IsActive);
        //    Command.Parameters.AddWithValue("@UserID", UserID);

        //    try {

        //        connection.Open();
        //        rowsAffected = Command.ExecuteNonQuery();


        //    }
        //    catch (Exception ex)
        //    {
        //        ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");


        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }


        //    return rowsAffected > 0;
        //}




        public static bool ChangePassword(int UserID, string Password)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"UPDATE Users SET 
                             Password= @Password 
                             where UserID = @UserID";
            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@UserID", UserID);


            try
            {

                connection.Open();
                rowsAffected = Command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");


            }
            finally
            {
                connection.Close();
            }


            return rowsAffected > 0;
        }
    

        public static bool IsUserIDExists(int UserID)
        {
            bool found = false;
         SqlConnection connection = new SqlConnection (DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @" SELECT * FROM Users  WHERE Users.UserID = @UserID";
            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try{
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
               if (reader.Read()) { found= true; }  

                reader.Close();
            }
            catch(Exception ex) { found= false; ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
            }
            finally { connection.Close(); }

            return found;
        }

        public static bool IsPersonIDExists(int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM Users  WHERE PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                if (reader.Read()) { IsFound = true; }

                reader.Close();
            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");

            }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool DeleteUserByUserID(int UserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Delete FROM Users 
                             where UserID = @UserID";
            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {

                connection.Open();
                rowsAffected = Command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");

            }
            finally
            {
                connection.Close();
            }


            return rowsAffected > 0;
        }
    }
}