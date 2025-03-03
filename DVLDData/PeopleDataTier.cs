using System;
using DataAccessSettings;
using System.Data.SqlClient;
using System.Data;
using System.Linq.Expressions;
using System.CodeDom;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Diagnostics.Eventing.Reader;

namespace PeopleData
{
    public class clsPeople
    {
    
        public static DataTable GetPeople() {
            SqlConnection Connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"SELECT People.PersonID, People.NationalNo,
              People.FirstName, People.SecondName, People.ThirdName, People.LastName,
			  People.DateOfBirth, People.Gendor,  
				  CASE
                  WHEN People.Gendor = 1 THEN 'Female'

                  ELSE 'Male'

                  END as GendorCaption ,
			  People.Address, People.Phone, People.Email, 
              People.NationalityCountryID, Countries.CountryName, People.ImagePath
              FROM            People INNER JOIN
                         Countries ON People.NationalityCountryID = Countries.CountryID
                ORDER BY People.FirstName";
            
            SqlCommand Command = new SqlCommand(query, Connection);
            DataTable dtPeople = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)

                    dtPeople.Load(Reader);
                      Reader.Close();
                ClsEventLog.HandleEventLog("Data Base Accessed");
            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");

            }


            finally
            {
                Connection.Close();
            }
            return dtPeople;


        }




        public static bool FindFillPersonByID(int PersonID, ref string FirstName, ref string SecondName,
  ref string ThirdName, ref string LastName, ref string NationalNo, ref DateTime DateOfBirth,
   ref short Gendor, ref string Address, ref string Phone, ref string Email,
   ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    //ThirdName: allows null in database so we should handle null
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = (string)reader["LastName"];
                    NationalNo = (string)reader["NationalNo"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];


                    //Email: allows null in database so we should handle null
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }
                ClsEventLog.HandleEventLog("Data Base Accessed");
                reader.Close();
            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");

                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool FindFillPersonByNationalNumber(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName,
         ref string ThirdName, ref string LastName, ref DateTime DateOfBirth,
          ref short Gendor, ref string Address, ref string Phone, ref string Email,
          ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];

                    //ThirdName: allows null in database so we should handle null
                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = (string)reader["ThirdName"];
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (byte)reader["Gendor"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];

                    //Email: allows null in database so we should handle null
                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = (string)reader["Email"];
                    }
                    else
                    {
                        Email = "";
                    }

                    NationalityCountryID = (int)reader["NationalityCountryID"];

                    //ImagePath: allows null in database so we should handle null
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }
                ClsEventLog.HandleEventLog("Data Base Accessed");
                reader.Close();


            }
            catch (Exception ex)
            {
                ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}");
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static int AddNewPerson(string FirstName, string SecondName,
           string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth,
           short Gendor, string Address, string Phone, string Email
            , string ImagePath, int NationalityCountryID)
        {
            //this function will return the new person id if succeeded and - 1 if not.
            int PersonID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO People(FirstName, SecondName,
                                                ThirdName,LastName,NationalNo,
                                                   DateOfBirth,Gendor,Address,
                                                   Phone, Email, NationalityCountryID,ImagePath)

                                                   VALUES (@FirstName, @SecondName,
                                                   @ThirdName, @LastName, @NationalNo,
                                                     @DateOfBirth,@Gendor,
                                                    @Address,@Phone, @Email,
                                                   @NationalityCountryID,@ImagePath);
                                                   SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            if (ThirdName != "" && ThirdName != null)
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != "" && Email != null)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);

            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != "" && ImagePath != null)
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

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

            finally
            {
                connection.Close();
            }

            return PersonID;
        }


        public static bool Update(int PersonID, string FirstName, string SecondName,
           string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth,
           short Gendor, string Address, string Phone, string Email
            , string ImagePath, int NationalityCountryID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"UPDATE People SET FirstName = @FirstName,
                             SecondName= @SecondName ,
                             ThirdName = @ThirdName,
                             LastName = @LastName ,
                             NationalNo = @NationalNo,
                             DateOfBirth = @DateOfBirth,
                             Gendor = @Gendor,
                             Address = @Address,
                             Phone = @Phone,
                             Email = @Email,
                             ImagePath = @ImagePath,
                             NationalityCountryID= @NationalityCountryID

                             where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@SecondName", SecondName);
            if (ThirdName != null && ThirdName != "")
            {
                Command.Parameters.AddWithValue("@ThirdName", ThirdName);

            }
            else
                Command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);

            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@NationalNo", NationalNo);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@Gendor", Gendor);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Phone", Phone);

            if (Email != null && Email != "")
            {
                Command.Parameters.AddWithValue("@Email", Email);

            }
            else
                Command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            Command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (ImagePath != null && ImagePath != "")
            {
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);

            }
            else
                Command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


            try
            {

                connection.Open();
                rowsAffected = Command.ExecuteNonQuery();
                ClsEventLog.HandleEventLog("Data Base Accessed");

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

        public static bool DeletePersonByPersonID(int PersonID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Delete FROM People where PersonID = @PersonID";
            SqlCommand Command = new SqlCommand(query, connection);
            Command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                rowsAffected = Command.ExecuteNonQuery();
                ClsEventLog.HandleEventLog("Data Base Accessed");
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

        public static bool IsPersonExist(int PersonID)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Select IsFound=1 FROM People where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            bool IsFound = false;
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
                reader.Close();
                ClsEventLog.HandleEventLog("Data Base Accessed");
            }

            catch (Exception ex) { ClsEventLog.HandleEventLog($"Failed To Access DataBase {ex.Message}"); }
            finally { connection.Close(); }
                return IsFound;
        }

        public static bool IsPersonExist(string NationalNo)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Select IsFound=1 FROM People where NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
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

        public static int GetPersonID(string NationalNo)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"Select PersonID From People where NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            try
            {    connection.Open();
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
    }
}