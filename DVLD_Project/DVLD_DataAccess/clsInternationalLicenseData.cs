using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsInternationalLicenseData
    {
        public static bool GetInternationalLicenseByApplicationID(int ApplicationID, ref int InternationalLicenseID, ref int DriverID,
            ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenses.ApplicationID = @ApplicationID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    InternationalLicenseID = Convert.ToInt32(reader["InternationalLicenseID"]);
                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    IssuedUsingLocalLicenseID = Convert.ToInt32(reader["IssuedUsingLocalLicenseID"]);
                    IssueDate = Convert.ToDateTime(reader["IssueDate"]);
                    ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

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

        public static bool GetInternationalLicenseByID(int InternationalLicenseID, ref int ApplicationID, ref int DriverID, ref int IssuedUsingLocalLicenseID,
            ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenses.InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    IssuedUsingLocalLicenseID = Convert.ToInt32(reader["IssuedUsingLocalLicenseID"]);
                    IssueDate = Convert.ToDateTime(reader["IssueDate"]);
                    ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

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

        public static bool GetInternationalLicenseByLicenseID( int IssuedUsingLocalLicenseID, ref int InternationalLicenseID, ref int ApplicationID, 
            ref int DriverID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM InternationalLicenses WHERE IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);

            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    InternationalLicenseID = Convert.ToInt32(reader["InternationalLicenseID"]);
                    IssueDate = Convert.ToDateTime(reader["IssueDate"]);
                    ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    IsActive = Convert.ToBoolean(reader["IsActive"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

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



        public static int AddInternationalLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate,
            bool IsActive, int CreatedByUserID)
        {
            int AddedInternationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID) " +
                "VALUES (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);" +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int scope_identity))
                {
                    AddedInternationalLicenseID = scope_identity;
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }

            return AddedInternationalLicenseID;
        }

        public static bool UpdateInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "UPDATE InternationalLicenses SET " +
               "ApplicationID = @ApplicationID, " +
               "DriverID = @DriverID, " +
               "IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID, " +
               "IssueDate = @IssueDate, " +
               "ExpirationDate = @ExpirationDate, " +
               "IsActive = @IsActive, " +
               "CreatedByUserID = @CreatedByUserID " +
               "WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

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

        public static bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

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

        public static DataTable GetInternationalLicensesList()
        {
            DataTable InternationalLicensesTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM InternationalLicenses;";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    InternationalLicensesTable.Load(reader);
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
            return InternationalLicensesTable;
        }

        public static DataTable GetInternationalLicenseHistoryByDriverID(int DriverID)
        {
            DataTable InternationalLicensesTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM InternationalLicenses WHERE DriverID = @DriverID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    InternationalLicensesTable.Load(reader);
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
            return InternationalLicensesTable;
        }

        public static bool DoInternationalLicenseExists(int ILID_AppID_LLID, short SearchOption)
        {
            if(SearchOption < 1 || SearchOption > 3)
            {
                return false;
            }

            bool Exists = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string[] SearchOptionsString = { "(InternationalLicenseID = @ILID_AppID_LLID)", "(ApplicationID = @ILID_AppID_LLID)", "(IssuedUsingLocalLicenseID = @ILID_AppID_LLID)" };

            string query = "SELECT IsActive FROM InternationalLicenses WHERE " + SearchOptionsString[SearchOption - 1];

            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@ILID_AppID_LLID", ILID_AppID_LLID);

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
