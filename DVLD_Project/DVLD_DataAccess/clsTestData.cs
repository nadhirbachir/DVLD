using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestData
    {

        public static bool GetTestWithID(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Tests WHERE TestID = @TestID";

            SqlCommand cmd = new SqlCommand(query, cnc);
            cmd.Parameters.AddWithValue("@TestID", TestID);


            try
            {
                cnc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    isFound = true;
                    TestAppointmentID = Convert.ToInt32(reader["TestAppointmentID"]);
                    TestResult = Convert.ToBoolean(reader["TestResult"]);
                    Notes = Convert.ToString(reader["Notes"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

                }
                reader.Close();
            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return isFound;
        }

        public static bool GetTestWithTestAppointmentID(ref int TestID, int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Tests WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand cmd = new SqlCommand(query, cnc);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


            try
            {
                cnc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    isFound = true;
                    TestID = Convert.ToInt32(reader["TestID"]);
                    TestResult = Convert.ToBoolean(reader["TestResult"]);
                    Notes = Convert.ToString(reader["Notes"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

                }
                reader.Close();
            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return isFound;
        }

        public static DataTable GetTestsList()
        {
            DataTable TestsView = new DataTable();
            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Tests";
            SqlCommand cmd = new SqlCommand(query, cnc);
            try
            {
                cnc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    TestsView.Load(reader);
                }
                reader.Close();
            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return TestsView;
        }

        public static bool ExistingPassedTest(int TestAppointmentID)
        {
            bool IsFound = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT TestID FROM Tests WHERE TestAppointmentID = @TestAppointmentID AND TestResult = 1";

            SqlCommand cmd = new SqlCommand(query, cnc);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


            try
            {
                cnc.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    IsFound = true;
                }

            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return IsFound;
        }

        public static bool IsThereOpenTests(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool IsOpen = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT TestID FROM Tests 
                            WHERE TestTypeID = 1 AND IsLocked = 0 AND LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID";

            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                cnc.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out LocalDrivingLicenseApplicationID))
                {
                    IsOpen = true;
                }

            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return IsOpen;
        }

        public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            bool isUpdated = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE Tests SET 
                            TestAppointmentID = @TestAppointmentID,
                            TestResult = @TestResult,
                            Notes = @Notes,
                            CreatedByUserID = @CreatedByUserID
                            WHERE TestID = @TestID;";

            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            if (string.IsNullOrEmpty(Notes))
            {
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Notes", Notes);
            }

            cmd.Parameters.AddWithValue("@TestID", TestID);


            try
            {
                cnc.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    isUpdated = true;
                }
            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return isUpdated;
        }

        public static int AddTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {

            int TestID = -1;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO Tests VALUES
                        (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                              SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            if (string.IsNullOrEmpty(Notes))
            {
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Notes", Notes);
            }


            try
            {
                cnc.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int scope_identity))
                {
                    TestID = scope_identity;
                }
            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return TestID;


        }

        public static bool DeleteTest(int TestID)
        {
            bool isDeleted = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM Tests WHERE TestID = @TestID";

            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@TestID", TestID);


            try
            {
                cnc.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    isDeleted = true;
                }
            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return isDeleted;
        }


    }
}
