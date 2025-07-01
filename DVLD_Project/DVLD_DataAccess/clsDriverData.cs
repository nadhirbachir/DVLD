using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsDriverData
    {

        // PersonID, CreatedByUserID, CreatedDate
        // int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate

        public static bool GetDriverByPersonID(int PersonID, ref int DriverID,ref int CreatedByUserID, ref DateTime CreatedDate)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Drivers WHERE Drivers.PersonID = @PersonID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                    isFound = true;

                }
                else
                {
                    isFound = false;
                }

            }
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static bool GetDriverByDriverID(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Drivers WHERE Drivers.DriverID = @DriverID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);

            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                    isFound = true;

                }
                else
                {
                    isFound = false;
                }

            }
            catch (Exception)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }

        public static int AddDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {

            int AddedDriverID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO Drivers VALUES " +
                "( @PersonID, @CreatedByUserID, @CreatedDate);" +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);


            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);



            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int scope_identity))
                {
                    AddedDriverID = scope_identity;
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }

            return AddedDriverID;
        }

        public static bool UpdateDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "UPDATE Drivers SET " +
               "PersonID = @PersonID, " +
               "CreatedByUserID = @CreatedByUserID, " +
               "CreatedDate = @CreatedDate " +
               "WHERE DriverID = @DriverID";

            SqlCommand cmd = new SqlCommand(query, connection);


            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);



            try
            {
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected >= 1)
                {
                    isUpdated = true;
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }

            return isUpdated;
        }

        public static bool DeleteDriver(int DriverID)
        {
            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Drivers WHERE DriverID = @DriverID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    isDeleted = true;
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
            return isDeleted;
        }

        public static DataTable GetDriversList()
        {
            DataTable PeopleTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Drivers_View;";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    PeopleTable.Load(reader);
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
            return PeopleTable;
        }

        public static bool DoDriverExists(int DriverIDOrPersonID)
        {
            bool Exists = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT DriverID FROM Drivers WHERE (DriverID = @DriverIDOrPersonID) OR (PersonID = @DriverIDOrPersonID);";

            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@DriverIDOrPersonID", DriverIDOrPersonID);

            try
            {
                cnc.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    Exists = true;
                }
            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return Exists;
        }


    }
}
