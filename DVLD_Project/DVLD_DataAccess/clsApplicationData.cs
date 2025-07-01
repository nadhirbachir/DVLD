using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsApplicationData
    {
        public static bool GetApplicationByID(int ApplicationID, ref int ApplicantPersonID, ref DateTime ApplicationDate,
            ref int ApplicationTypeID, ref short ApplicationStatus, ref DateTime LastStatusDate, ref float PaidFees, ref int CreatedByUserID)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Applications WHERE ApplicationID = @ApplicationID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    ApplicantPersonID = Convert.ToInt32(reader["ApplicantPersonID"]);
                    ApplicationDate = Convert.ToDateTime(reader["ApplicationDate"]);
                    ApplicationTypeID = Convert.ToInt32(reader["ApplicationTypeID"]);
                    ApplicationStatus = Convert.ToInt16(reader["ApplicationStatus"]);
                    LastStatusDate = Convert.ToDateTime(reader["LastStatusDate"]);
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
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

        public static int AddApplication(int ApplicantPersonID, DateTime ApplicationDate,
            int ApplicationTypeID, short ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {

            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO Applications VALUES " +
                "( @ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, " +
                "@PaidFees, @CreatedByUserID); " +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);


            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int scope_identity))
                {
                    ApplicationID = scope_identity;
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }

            return ApplicationID;
        }

        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
            int ApplicationTypeID, short ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "UPDATE Applications SET " +
               "ApplicantPersonID = @ApplicantPersonID, " +
               "ApplicationDate = @ApplicationDate, " +
               "ApplicationTypeID = @ApplicationTypeID, " +
               "ApplicationStatus = @ApplicationStatus, " +
               "LastStatusDate = @LastStatusDate, " +
               "PaidFees = @PaidFees, " +
               "CreatedByUserID = @CreatedByUserID " +
               "WHERE ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, connection);


            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);



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

        public static bool DeleteApplication(int ApplicantPersonID)
        {
            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM Applications WHERE ApplicantPersonID = @ApplicantPersonID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);

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

        public static DataTable GetApplicationsList()
        {
            DataTable ApplicationsTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT ApplicationID , ApplicantPersonID, ApplicationDate, ApplicationTypes.ApplicationTypeTitle, ApplicationStatus = 
	                         CASE
	                         	WHEN ApplicationStatus = 1 THEN 'New'
	                         	WHEN ApplicationStatus = 2 THEN 'Cancled'
	                         	WHEN ApplicationStatus = 3 THEN 'Completed'
	                         	WHEN ApplicationStatus = 4 THEN 'Pending'
	                         	ELSE 'Unknown'
	                         END, 
	                         LastStatusDate, PaidFees, Users.UserName as CreatedBy
	                         FROM Applications INNER JOIN ApplicationTypes ON Applications.ApplicationTypeID = ApplicationTypes.ApplicationTypeID
	                         INNER JOIN Users ON Applications.CreatedByUserID = Users.UserID ;";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    ApplicationsTable.Load(reader);
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
            return ApplicationsTable;
        }

        public static bool DoApplicationExists(int ApplicationID)
        {
            bool Exists = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT ApplicationID FROM Applications WHERE ApplicationID = @ApplicationID;"; 

            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        public static int IsThereAnotherOpenApplication(int ApplicantPersonID, int ApplicationTypeID)
        {
            int isOpenApplication = -1;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT ApplicationID FROM Applications " +
                "WHERE ApplicantPersonID = @ApplicantPersonID AND Applications.ApplicationTypeID = @ApplicationTypeID AND ApplicationStatus = 1;";

            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                cnc.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int ApplicationID))
                {
                    isOpenApplication = ApplicationID;
                }
            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return isOpenApplication;
        }

    }
}
