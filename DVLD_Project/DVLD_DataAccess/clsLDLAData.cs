using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLDLAData
    {
        public static bool GetLDLAByID(int LDLAID, ref int ApplicationID, ref int LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LDLAID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LDLAID", LDLAID);

            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                    LicenseClassID = Convert.ToInt32(reader["LicenseClassID"]);

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

        public static int AddLDLA(int ApplicationID, int LicenseClassID)
        {

            int LocalDrivingLicenseApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO LocalDrivingLicenseApplications VALUES " +
                "( @ApplicationID, @LicenseClassID ); " +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);


            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            


            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int scope_identity))
                {
                    LocalDrivingLicenseApplicationID = scope_identity;
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }

            return LocalDrivingLicenseApplicationID;
        }

        public static bool UpdateLDLA(int LDLAID, int ApplicationID, int LicenseClassID)
        {
            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "UPDATE LocalDrivingLicenseApplications SET " +
               "ApplicationID = @ApplicationID, " +
               "LicenseClassID = @LicenseClassID " +
               "WHERE LocalDrivingLicenseApplicationID = @LDLAID";

            SqlCommand cmd = new SqlCommand(query, connection);



            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            cmd.Parameters.AddWithValue("@LDLAID", LDLAID);



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

        public static bool DeleteLDLA(int LDLAID)
        {
            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LDLAID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LDLAID", LDLAID);

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

        public static bool CancleLDLA(int LDLAID)
        {

            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Applications SET ApplicationStatus = 2 
	                    WHERE ApplicationID = (SELECT ApplicationID FROM LocalDrivingLicenseApplications 
	                    WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLAID);";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@LDLAID", LDLAID);

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

        public static DataTable GetLDLAList()
        {
            DataTable ApplicationsTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications_View";

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

        public static DataTable GetFullLDLAList()
        {
            DataTable ApplicationsTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseFullApplications_View";

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

        public static DataRow GetFullLDLAByID(int LDLAID)
        {

            DataTable FullLDLATableHeader = new DataTable();
            FullLDLATableHeader.Columns.Add("LDLA_ID", typeof(int));
            FullLDLATableHeader.Columns.Add("LicenseClassID", typeof(short));
            FullLDLATableHeader.Columns.Add("PassedTestCount", typeof(short));
            FullLDLATableHeader.Columns.Add("ApplicationID", typeof(int));
            FullLDLATableHeader.Columns.Add("ApplicationStatus", typeof(short));
            FullLDLATableHeader.Columns.Add("PaidFees", typeof(float));
            FullLDLATableHeader.Columns.Add("ApplicationTypeID", typeof(short));
            FullLDLATableHeader.Columns.Add("ApplicantPersonID", typeof(int));
            FullLDLATableHeader.Columns.Add("ApplicationDate", typeof(DateTime));
            FullLDLATableHeader.Columns.Add("LastStatusDate", typeof(DateTime));
            FullLDLATableHeader.Columns.Add("CreatedByUserID", typeof(int));


            DataRow FullLDLARow = FullLDLATableHeader.NewRow();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseFullApplications_View WHERE LocalDrivingLicenseApplicationID = @LDLAID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LDLAID", LDLAID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    FullLDLARow["LDLA_ID"] = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]);
                    FullLDLARow["LicenseClassID"] = Convert.ToInt16(reader["LicenseClassID"]);
                    FullLDLARow["PassedTestCount"] = Convert.ToInt16(reader["PassedTestCount"]);
                    FullLDLARow["ApplicationID"] = Convert.ToInt32(reader["ApplicationID"]);
                    FullLDLARow["ApplicationStatus"] = Convert.ToInt16(reader["ApplicationStatus"]);
                    FullLDLARow["PaidFees"] = Convert.ToSingle(reader["PaidFees"]);
                    FullLDLARow["ApplicationTypeID"] = Convert.ToInt16(reader["ApplicationTypeID"]);
                    FullLDLARow["ApplicantPersonID"] = Convert.ToInt32(reader["ApplicantPersonID"]);
                    FullLDLARow["ApplicationDate"] = Convert.ToDateTime(reader["ApplicationDate"]);
                    FullLDLARow["LastStatusDate"] = Convert.ToDateTime(reader["LastStatusDate"]);
                    FullLDLARow["CreatedByUserID"] = Convert.ToInt32(reader["CreatedByUserID"]);
                }
            }
            catch (Exception) { }
            finally
            {
                connection.Close();
            }
            return FullLDLARow;
        }

        public static bool DoLDLAExists(int LDLAID)
        {
            bool Exists = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT LocalDrivingLicenseApplicationID FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LDLAID;";

            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@LDLAID", LDLAID);

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

        public static int DoLDLAExistsAppID(int ApplicantPersonID, int LicenseClassID)
        {
            int ExistsAppID = -1;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT Applications.ApplicationID
	                        FROM LocalDrivingLicenseApplications INNER JOIN Applications 
	                        ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
	                        WHERE ApplicantPersonID = @ApplicantPersonID AND LicenseClassID = @LicenseClassID AND ApplicationStatus = 1;";

            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                cnc.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ExistsAppID = AppID;
                }
            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return ExistsAppID;
        }


        public static int GetPassedTestCountByLDLAID(int LDLAID)
        {

            string query = @"SELECT COUNT(TestAppointments.TestTypeID) AS PassedTestCount
                              FROM Tests INNER JOIN TestAppointments 
                              ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                              WHERE (TestAppointments.LocalDrivingLicenseApplicationID = @LDLAID)
                              AND (Tests.TestResult = 1)";


            int PassedTestsCount = -1;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);


            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@LDLAID", LDLAID);

            try
            {
                cnc.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    PassedTestsCount = AppID;
                }
            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return PassedTestsCount;


        }

    }
}
