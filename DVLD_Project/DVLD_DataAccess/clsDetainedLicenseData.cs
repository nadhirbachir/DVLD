using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsDetainedLicenseData
    {

        public static bool GetDetainedLicenseByDetainID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref float FineFees,
        ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@DetainID", DetainID);

            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    LicenseID = Convert.ToInt32(reader["LicenseID"]);
                    DetainDate = Convert.ToDateTime(reader["DetainDate"]);
                    FineFees = Convert.ToSingle(reader["FineFees"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    IsReleased = Convert.ToBoolean(reader["IsReleased"]);

                    if(reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = (DateTime)reader["ReleaseDate"];

                    if(reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = Convert.ToInt32(reader["ReleasedByUserID"]);

                    if(reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = Convert.ToInt32(reader["ReleaseApplicationID"]);

                    isFound = true;
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

        public static bool GetDetainedLicenseByLicenseID(int LicenseID, ref int DetainID, ref DateTime DetainDate, ref float FineFees,
            ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    DetainID = Convert.ToInt32(reader["DetainID"]);
                    DetainDate = Convert.ToDateTime(reader["DetainDate"]);
                    FineFees = Convert.ToSingle(reader["FineFees"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    IsReleased = Convert.ToBoolean(reader["IsReleased"]);

                    if(reader["ReleaseDate"] != DBNull.Value)
                        ReleaseDate = (DateTime)reader["ReleaseDate"];

                    if(reader["ReleasedByUserID"] != DBNull.Value)
                        ReleasedByUserID = Convert.ToInt32(reader["ReleasedByUserID"]);
                    if(reader["ReleaseApplicationID"] != DBNull.Value)
                        ReleaseApplicationID = Convert.ToInt32(reader["ReleaseApplicationID"]);

                    isFound = true;
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

        public static int AddDetainedLicense(int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID)
        {
            int AddedDetainID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID) " +
                "VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, 0, NULL, NULL, NULL); " +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int scope_identity))
                {
                    AddedDetainID = scope_identity;
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }

            return AddedDetainID;
        }

        public static bool UpdateDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID, bool IsReleased,
            DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "UPDATE DetainedLicenses SET " +
               "LicenseID = @LicenseID, " +
               "DetainDate = @DetainDate, " +
               "FineFees = @FineFees, " +
               "CreatedByUserID = @CreatedByUserID, " +
               "IsReleased = @IsReleased, " +
               "ReleaseDate = @ReleaseDate, " +
               "ReleasedByUserID = @ReleasedByUserID, " +
               "ReleaseApplicationID = @ReleaseApplicationID " +
               "WHERE DetainID = @DetainID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
            cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            cmd.Parameters.AddWithValue("@DetainID", DetainID);

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

        //public static bool DeleteDetainedLicense(int DetainID)
        //{
        //    bool isDeleted = false;

        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string query = "DELETE FROM DetainedLicenses WHERE DetainID = @DetainID;";

        //    SqlCommand cmd = new SqlCommand(query, connection);
        //    cmd.Parameters.AddWithValue("@DetainID", DetainID);

        //    try
        //    {
        //        connection.Open();
        //        int result = cmd.ExecuteNonQuery();
        //        if (result >= 1)
        //        {
        //            isDeleted = true;
        //        }
        //    }
        //    catch (Exception) { }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return isDeleted;
        //}

        public static DataTable GetDetainedLicensesList()
        {
            DataTable DetainedLicensesTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicenses_View;";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DetainedLicensesTable.Load(reader);
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
            return DetainedLicensesTable;
        }

        public static bool DoDetainedLicenseExists(int DetainIDOrLicenseID)
        {
            bool Exists = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT IsReleased FROM DetainedLicenses WHERE (DetainID = @DetainIDOrLicenseID) OR (LicenseID = @DetainIDOrLicenseID);";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@DetainIDOrLicenseID", DetainIDOrLicenseID);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    Exists = true;
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
            return Exists;
        }


        public static int isDetainedLicense(int DetainID_LicenseID)
        {
            {
                int DetainID = -1;

                SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

                string query = "SELECT DetainID FROM DetainedLicenses WHERE ((DetainID = @DetainIDOrLicenseID) OR (LicenseID = @DetainIDOrLicenseID)) AND IsReleased = 0;";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DetainIDOrLicenseID", DetainID_LicenseID);

                try
                {
                    connection.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int ifDetainedDetainID))
                    {

                        DetainID = ifDetainedDetainID;
                    
                    }
                }
                catch (Exception) { }
                finally
                {
                    connection.Close();
                }
                return DetainID;
            }
        }

    }
}
