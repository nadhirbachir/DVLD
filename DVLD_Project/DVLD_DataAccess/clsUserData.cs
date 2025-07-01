using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsUserData
    {

        public static bool GetUserByPersonID(int PersonID, ref int UserID, ref string UserName, ref string Password, ref bool IsActive)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE Users.PersonID = @PersonID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    UserID = Convert.ToInt32(reader["UserID"]);
                    UserName = Convert.ToString(reader["UserName"]);
                    Password = Convert.ToString(reader["Password"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);

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

        public static bool GetUserByUserID(int UserID, ref int PersonID,  ref string UserName, ref string Password, ref bool IsActive)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE Users.UserID = @UserID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);

            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    UserName = Convert.ToString(reader["UserName"]);
                    Password = Convert.ToString(reader["Password"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);

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

        public static bool GetUserByUserName(ref int UserID, ref int PersonID, string UserName, string Password, ref bool IsActive)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE Users.UserName = @UserName AND Users.Password = @Password;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);

            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    UserID = Convert.ToInt32(reader["UserID"]);

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

        public static bool GetUserByUserNameAndPassword(ref int UserID, ref int PersonID, string UserName, string Password, ref bool IsActive)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE UserName = @UserName AND Users.Password = @Password;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);

            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    UserID = Convert.ToInt32(reader["UserID"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);

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

        public static int AddUser(int PersonID, string UserName, string Password, bool IsActive)
        {

            int AddedUserID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO Users VALUES " +
                "( @PersonID, @UserName, @Password, @IsActive);" +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);


            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);


            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int scope_identity))
                {
                    AddedUserID = scope_identity;
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }

            return AddedUserID;
        }

        public static bool UpdateUser(int UserID, string UserName, string Password, bool IsActive)
        {
            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "UPDATE Users SET " +
               "UserName = @UserName, " +
               "Password = @Password, " +
               "IsActive = @IsActive " +
               "WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, connection);


            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@UserID", UserID);



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

        public static bool DeleteUser(int UserID)
        {
            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Users WHERE UserID = @UserID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);

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

        public static DataTable GetUsersList()
        {
            DataTable PeopleTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT UserID, Users.PersonID, 
                FullName = (People.FirstName +
                CASE
                    WHEN People.SecondName IS NOT NULL THEN ' ' + People.SecondName
                    ELSE ''
                END +
                CASE
                    WHEN People.ThirdName IS NOT NULL THEN ' ' + People.ThirdName
                    ELSE ''
                END +
                CASE
                    WHEN People.LastName IS NOT NULL THEN ' ' + People.LastName
                    ELSE ''
                END)
                , UserName, IsActive FROM Users INNER JOIN People ON Users.PersonID = People.PersonID; ";

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

        public static bool DoUserExists(int UserIDOrPersonID)
        {
            bool Exists = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT IsActive FROM Users WHERE (UserID = @UserIDOrPersonID) OR (PersonID = @UserIDOrPersonID);";

            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@UserIDOrPersonID", UserIDOrPersonID);

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

        public static bool DoUserExists(string UserName)
        {
            bool Exists = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT IsActive FROM Users WHERE UserName = @UserName;";

            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@UserName", UserName);

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
