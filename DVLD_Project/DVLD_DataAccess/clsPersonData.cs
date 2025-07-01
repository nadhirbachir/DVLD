using System;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataAccess
{
    public class clsPersonData
    {
        public static bool GetPersonInfoByID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName,ref DateTime DateOfBirth, ref short Gendor, ref string Address,
            ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE PersonID = @PersonID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    NationalNo = reader["NationalNo"].ToString();
                    FirstName = reader["FirstName"].ToString();

                    if (reader["SecondName"] != DBNull.Value)
                    {
                        SecondName = reader["SecondName"].ToString();
                    }
                    else
                    {
                        SecondName = "";
                    }

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = reader["ThirdName"].ToString();
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = reader["LastName"].ToString();
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = Convert.ToInt16(reader["Gendor"]);
                    Address = reader["Address"].ToString();
                    Phone = reader["Phone"].ToString();

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = reader["Email"].ToString();
                    }
                    else
                    {
                        Email = "";
                    }

                    NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = reader["ImagePath"].ToString();
                    }
                    else
                    {
                        ImagePath = "";
                    }

                    isFound = true;

                }
                else
                {
                    isFound = false;
                }

            }
            catch(Exception)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;

        }


        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FirstName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref short Gendor, ref string Address,
            ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM People WHERE NationalNo = @NationalNo;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);

            bool isFound = false;

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read())
                {
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    FirstName = reader["FirstName"].ToString();

                    if (reader["SecondName"] != DBNull.Value)
                    {
                        SecondName = reader["SecondName"].ToString();
                    }
                    else
                    {
                        SecondName = "";
                    }

                    if (reader["ThirdName"] != DBNull.Value)
                    {
                        ThirdName = reader["ThirdName"].ToString();
                    }
                    else
                    {
                        ThirdName = "";
                    }

                    LastName = reader["LastName"].ToString();
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = Convert.ToInt16(reader["Gendor"]);
                    Address = reader["Address"].ToString();
                    Phone = reader["Phone"].ToString();

                    if (reader["Email"] != DBNull.Value)
                    {
                        Email = reader["Email"].ToString();
                    }
                    else
                    {
                        Email = "";
                    }

                    NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = reader["ImagePath"].ToString();
                    }
                    else
                    {
                        ImagePath = "";
                    }

                    isFound = true;

                }
                else
                {
                    isFound = false;
                }
                reader.Close();
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

        public static int AddPerson(string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, short Gendor, string Address,
            string Phone, string Email, int NationalityCountryID, string ImagePath)
        {

            int AddedPersonID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "INSERT INTO People VALUES " +
                "( @NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor, @Address, " +
                "@Phone, @Email, @NationalityCountryID, @ImagePath );" +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);

            if(string.IsNullOrWhiteSpace(SecondName) || SecondName == "")
            {
                cmd.Parameters.AddWithValue("@SecondName", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@SecondName", SecondName);
            }
            

            if((string.IsNullOrWhiteSpace(ThirdName) || ThirdName == ""))
            {
                cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            }

            
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", Gendor);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);

            if((string.IsNullOrWhiteSpace(Email) || Email == ""))
            {
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", Email);
            }
            
            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if((string.IsNullOrWhiteSpace(ImagePath) || ImagePath == ""))
            {
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            }

            

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(), out int scope_identity))
                {
                    AddedPersonID = scope_identity;
                }
            }
            catch(Exception){ }
            finally
            {
                connection.Close();
            }

            return AddedPersonID;
        }


        public static bool UpdatePerson(int PersonID,  string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, short Gendor, string Address,
            string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "UPDATE People SET " +
               "NationalNo = @NationalNo, " +
               "FirstName = @FirstName, " +
               "SecondName = @SecondName, " +
               "ThirdName = @ThirdName, " +
               "LastName = @LastName, " +
               "DateOfBirth = @DateOfBirth, " +
               "Gendor = @Gendor, " +
               "Address = @Address, " +
               "Phone = @Phone, " +
               "Email = @Email, " +
               "NationalityCountryID = @NationalityCountryID, " +
               "ImagePath = @ImagePath " +
               "WHERE PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);

            if (string.IsNullOrWhiteSpace(SecondName) || SecondName == "")
            {
                cmd.Parameters.AddWithValue("@SecondName", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@SecondName", SecondName);
            }


            if ((string.IsNullOrWhiteSpace(ThirdName) || ThirdName == ""))
            {
                cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            }


            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gendor", Gendor);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);

            if ((string.IsNullOrWhiteSpace(Email) || Email == ""))
            {
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Email", Email);
            }

            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if ((string.IsNullOrWhiteSpace(ImagePath) || ImagePath == ""))
            {
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            }



            try
            {
                connection.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if(rowsAffected >= 1)
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


        public static bool DeletePerson(int PersonID)
        {
            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM People WHERE PersonID = @PersonID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                if(result >= 1)
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

        public static bool DeleteGroupOfPeople(int[] PeopleID)
        {
            if(PeopleID.Length < 1)
            {
                return false;
            }
            string StringPeopleID = string.Join(" , ", PeopleID);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "DELETE FROM People WHERE PersonID IN ( @PeopleID );";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PeopleID", StringPeopleID);

            bool result = false;

            try
            {
                connection.Open();
                int RowsAffected = cmd.ExecuteNonQuery();
                if(RowsAffected > 0)
                {
                    result = true;
                }
            }
            catch(Exception) { }
            finally
            {
                connection.Close();
            }
            return result;

        }

        public static DataTable GetPeopleList()
        {
            DataTable PeopleTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName ,DateOfBirth, " +
                "Gendor = CASE " +
                "WHEN Gendor = 0 THEN 'Male' " +
                "WHEN Gendor = 1 THEN 'Female' END, " +
                "Phone, Email, CountryName " +
                "FROM People INNER JOIN Countries ON NationalityCountryID = Countries.CountryID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
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

        public static bool DoPersonExists(int PersonID)
        {
            bool Exists = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Gendor FROM People WHERE PersonID = @PersonID;";

            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                cnc.Open();
                object result = cmd.ExecuteScalar();
                if(result != null)
                {
                    Exists = true;
                }
            }
            catch(Exception) { }
            finally
            {
                cnc.Close();
            }
            return Exists;
        }

        public static bool DoPersonExists(string NationalNo)
        {
            bool Exists = false;

            SqlConnection cnc = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT Gendor FROM People WHERE NationalNo = @NationalNo;";

            SqlCommand cmd = new SqlCommand(query, cnc);

            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);

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
