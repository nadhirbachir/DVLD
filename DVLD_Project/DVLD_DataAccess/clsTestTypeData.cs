using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsTestTypeData
    {
        public static bool GetTestTypeWithID(int TestTypeID, ref string TestTypeTitle,ref string TestTypeDescription, ref float TestTypeFees)
        {
            bool isFound = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";

            SqlCommand cmd = new SqlCommand(query, cnc);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                cnc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    isFound = true;
                    TestTypeTitle = Convert.ToString(reader["TestTypeTitle"]);
                    TestTypeFees = Convert.ToSingle(reader["TestTypeFees"]);
                    TestTypeDescription = Convert.ToString(reader["TestTypeDescription"]);
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

        public static DataTable GetTestTypeList()
        {
            DataTable TestTypeTable = new DataTable();
            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM TestTypes";
            SqlCommand cmd = new SqlCommand(query, cnc);
            try
            {
                cnc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    TestTypeTable.Load(reader);
                }
                reader.Close();
            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return TestTypeTable;
        }

        public static bool UpdateTestType(int TestTypeID, string TestTypeDescription, string TestTypeTitle, float TestTypeFees)
        {
            bool updateResult = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "UPDATE TestTypes SET " +
                "TestTypeFees = @TestTypeFees, " +
                "TestTypeTitle = @TestTypeTitle, " +
                "TestTypeDescription = @TestTypeDescription " +
                "WHERE TestTypeID = @TestTypeID;";

            SqlCommand cmd = new SqlCommand(query, cnc);
            cmd.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
            cmd.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);


            try
            {
                cnc.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    updateResult = true;
                }
            }
            catch (Exception) { }
            finally
            {
                cnc.Close();
            }
            return updateResult;
        }
    }
}
