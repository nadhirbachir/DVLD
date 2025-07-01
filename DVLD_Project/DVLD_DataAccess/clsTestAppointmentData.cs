using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestAppointmentData
    {


        public static bool GetTestAppointmentWithID(int TestAppointmentID, ref int TestTypeID, ref int LDLAID,
            ref DateTime AppointmentDate, ref float PaidFees, ref int CreatedByUserID, ref bool isLocked, ref int RetakeTestApplicationID)
        {
            bool isFound = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand cmd = new SqlCommand(query, cnc);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


            try
            {
                cnc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    isFound = true;
                    TestTypeID = Convert.ToInt32(reader["TestTypeID"]);
                    LDLAID = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]);
                    AppointmentDate = Convert.ToDateTime(reader["AppointmentDate"]);
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    isLocked = Convert.ToBoolean(reader["IsLocked"]);
                    RetakeTestApplicationID = Convert.ToInt32(reader["RetakeTestApplicationID"]);
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

        public static DataTable GetTestAppointmentsList()
        {
            DataTable TestAppointmentsView = new DataTable();
            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM TestAppointments_View";
            SqlCommand cmd = new SqlCommand(query, cnc);
            try
            {
                cnc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    TestAppointmentsView.Load(reader);
                }
                reader.Close();
            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return TestAppointmentsView;
        }

        public static DataTable GetSpecificTestAppointmentsList(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            DataTable TestAppointmentsView = new DataTable();
            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT TestAppointmentID, LocalDrivingLicenseApplicationID," +
                            "PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID" +
                            " FROM TestAppointments WHERE TestTypeID = @TestTypeID AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";
            SqlCommand cmd = new SqlCommand(query, cnc);


            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                cnc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    TestAppointmentsView.Load(reader);
                }
                reader.Close();
            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return TestAppointmentsView;
        }

        public static bool IsThereOpenTestAppointments(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool IsOpen = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT TestAppointmentID FROM TestAppointments 
                            WHERE TestTypeID = @TestTypeID AND IsLocked = 0 AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

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



        public static bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID, int LDLAID, DateTime AppointmentDate, float PaidFees,
            int CreatedByUserID, bool isLocked, int RetakeTestApplicationID)
        {
            bool isUpdated = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE TestAppointments SET 
                            TestTypeID = @TestTypeID,
                            LocalDrivingLicenseApplicationID = @LDLAID,
                            AppointmentDate = @AppointmentDate,
                            PaidFees = @PaidFees,
                            CreatedByUserID = @CreatedByUserID,
                            IsLocked = @isLocked,
                            RetakeTestApplicationID = @RetakeTestApplicationID
                            WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LDLAID", LDLAID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@isLocked", isLocked);

            if (RetakeTestApplicationID == -1)
            {
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);


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


        public static int AddTestAppointment(int TestTypeID, int LDLAID, DateTime AppointmentDate, float PaidFees,
            int CreatedByUserID, bool isLocked, int RetakeTestApplicationID)
        {

            int TestAppointmentID = -1;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO TestAppointments VALUES
                        (@TestTypeID, @LDLAID, @AppointmentDate, @PaidFees, @CreatedByUserID, @isLocked, @RetakeTestApplicationID);
                              SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, cnc);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LDLAID", LDLAID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@isLocked", isLocked);

            if(RetakeTestApplicationID < 0)
            {
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }


            try
            {
                cnc.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int scope_identity))
                {
                    TestAppointmentID = scope_identity;
                }
            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return TestAppointmentID;


        }

    }
}
