using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsApplicationTypeData
    {

        public static bool GetApplicationTypeWithID(int applicationTypeID, ref string applicationTypeTitle, ref float applicationFees)
        {
            bool isFound = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ApplicationTypes WHERE applicationTypeID = @applicationTypeID";

            SqlCommand cmd = new SqlCommand(query, cnc);
            cmd.Parameters.AddWithValue("@applicationTypeID", applicationTypeID);

            try
            {
                cnc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    isFound = true;
                    applicationTypeTitle = Convert.ToString(reader["applicationTypeTitle"]);
                    applicationFees = Convert.ToSingle(reader["applicationFees"]);
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

        public static DataTable GetApplicationTypeList()
        {
            DataTable ApplicationTypeTable = new DataTable();
            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ApplicationTypes";
            SqlCommand cmd = new SqlCommand(query, cnc);
            try
            {
                cnc.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    ApplicationTypeTable.Load(reader);
                }
                reader.Close();
            }
            catch(Exception) { }
            finally
            {
                cnc.Close();
            }
            return ApplicationTypeTable;
        }

        public static bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, float ApplicationFees)
        {
            bool updateResult = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "UPDATE ApplicationTypes SET " +
                "ApplicationFees = @ApplicationFees, " +
                "ApplicationTypeTitle = @ApplicationTypeTitle " +
                "WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand cmd = new SqlCommand(query, cnc);
            cmd.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            cmd.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);


            try
            {
                cnc.Open();
                int result = cmd.ExecuteNonQuery();
                if(result > 0)
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
