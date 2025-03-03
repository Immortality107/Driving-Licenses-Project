using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.CodeDom;
namespace DVLDProject
{
    internal class clsCountryDatacs
    {
        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
 
            string query = "SELECT * FROM Countries order by CountryName";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
            //DataTable dt = new DataTable();
            //SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            //string query = @"select * from Countries order by CountryName";
            //SqlCommand command = new SqlCommand(query, connection);

            //try
            //{
            //    connection.Open();
            //    SqlDataReader reader = command.ExecuteReader();
            //    if (reader.HasRows)
            //    {
            //        dt.Load(reader);
            //    }
            //    else
            //        dt = null;
            //    reader.Close();
            //}
            //catch (Exception ex)
            //{
            //    dt = null;
            //}
            //finally
            //{
            //    connection.Close();
            //}
            //return dt;

        }



        public static bool FindCountryByID(int CountryID, ref string CountryName)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"select * from Countries where CountryID = @CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CountryName = (string)reader["CountryName"];
                    found = true;
                }

                reader.Close();

            }

            catch (Exception ex)
            {
            }

            finally
            {
                connection.Close();
            }

            return found;
        }


        public static int FindCountryByCountryName( ref string CountryName)
        {
            int CountryID = -1;
            SqlConnection connection = new SqlConnection(DataAccessSettings.DVLDDataAccessSettings.ConnectionString);
            string query = @"select * from Countries where CountryName = @CountryName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CountryID = (int)reader["CountryID"];
                }

                reader.Close();

            }

            catch (Exception ex)
            {
            }

            finally
            {
                connection.Close();
            }

            return CountryID;
        }
    }
}
