using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataAccess
{
    public class clsCountriesData
    {
        public static string GetCountryNameByID(int CountryID)
        {
            string CountryName = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            
            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";
            
            SqlCommand cmd = new SqlCommand(query, connection);
            
            cmd.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows && reader.Read())
                {
                    CountryName = reader["CountryName"].ToString();
                }
                reader.Close();
            }
            catch(Exception) { }
            finally
            {
                connection.Close();
            }
            return CountryName;

        }

        public static int GetCountryIDByName(string CountryName)
        {
            int CountryID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                object scalar = cmd.ExecuteScalar();
                if (scalar != null)
                {
                    CountryID = Convert.ToInt32(scalar);
                }

            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
            return CountryID;
        }

        public static DataTable GetCountriesList()
        {
            DataTable CountriesTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries;";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    CountriesTable.Load(reader);
                }

            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
            return CountriesTable;
        }
    }
}
