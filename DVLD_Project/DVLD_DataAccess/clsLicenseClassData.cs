using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLicenseClassData
    {
        public static bool GetLicenseClassByID(int LicenseClassID, ref string ClassName, ref string ClassDescription, 
            ref short MinAge, ref short DefaultValidityLength, ref float ClassFees)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    isFound = true;
                    ClassName = reader["ClassName"].ToString();
                    ClassDescription = reader["ClassDescription"].ToString();
                    MinAge = Convert.ToInt16(reader["MinimumAllowedAge"]);
                    DefaultValidityLength = Convert.ToInt16(reader["DefaultValidityLength"]);
                    ClassFees = Convert.ToSingle(reader["ClassFees"]);
                }
                reader.Close();
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
            return isFound;

        }

        public static int GetLicenseIDByName(string ClassName)
        {
            int LicenseClassID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM LicenseClasses WHERE ClassName = @ClassName";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                connection.Open();
                object scalar = cmd.ExecuteScalar();
                if (scalar != null)
                {
                    LicenseClassID = Convert.ToInt32(scalar);
                }

            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
            return LicenseClassID;
        }

        public static string GetLicenseNameByID(int LicenseClassID)
        {
            string ClassName = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT ClassName FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                object scalar = cmd.ExecuteScalar();
                if (scalar != null)
                {
                    ClassName = Convert.ToString(scalar);
                }

            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
            return ClassName;
        }

        public static DataTable GetLicenseClassesList()
        {
            DataTable LicenseClasses = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM LicenseClasses;";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    LicenseClasses.Load(reader);
                }

            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
            return LicenseClasses;
        }

        public static DataTable GetIDNameClassesList()
        {
            DataTable IDNameClasses = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT LicenseClassID, ClassName FROM LicenseClasses;";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    IDNameClasses.Load(reader);
                }

            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
            return IDNameClasses;
        }



    }
}
