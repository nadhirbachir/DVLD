using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;
using System.Security.Cryptography;

namespace DVLD_Business
{
    public class clsUser
    {
        enum enMode { eAddNew = 1, eUpdate = 2 }
        private enMode _Mode;

        public int UserID { get; private set; }

        public int PersonID { get; private set; }

        public string UserName { get; set; }

        private string _Password;

        public string Password 
        {
            get { return _Password; }
            
            set
            {
                _Password = encrypt(value);
            }
        
        }

        public bool IsActive { get; set; }

        private clsUser(int UserID, int PersonID, string UserName, string Password, bool IsActive)
        {
            _Mode = enMode.eUpdate;
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
        }

        private static string encrypt(string param)
        {
            using (SHA512 sha2 = SHA512.Create())
            {
                byte[] hashedBytes = sha2.ComputeHash(Encoding.UTF8.GetBytes(param));

                return (BitConverter.ToString(hashedBytes).Replace("-", string.Empty).ToLower());
            }
        }

        private bool _AddUser()
        {
            return (this.UserID = clsUserData.AddUser(PersonID, UserName, Password, IsActive)) != -1;
        }

        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, UserName, Password, IsActive);
        }

        // ------------------------------------------------>

        public clsUser(int PersonID)
        {
            this._Mode = enMode.eAddNew;
            this.UserID = -1;
            this.PersonID = PersonID;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
        }

        public static clsUser Find(int UserIDOrPersonID)
        {
            //return new clsUser(0, "1", "", "", "", "23", DateTime.Now, 1, "", "", "", 5, "");
            int UserID = UserIDOrPersonID;
            int PersonID = UserIDOrPersonID;
            string UserName = "";
            string Password = "";
            bool IsActive = false;

            if (clsUserData.GetUserByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive))
            {

                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else if(clsUserData.GetUserByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }

        }



        public static clsUser Find(string UserName, string Password)
        {
            if(UserName == string.Empty || Password == string.Empty)
            {
                return null;
            }

            int UserID = -1;
            int PersonID = -1;
            bool IsActive = false;
            Password = encrypt(Password);

            if (clsUserData.GetUserByUserNameAndPassword(ref UserID, ref PersonID, UserName, Password, ref IsActive))
            {

                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            }
            else
            {
                return null;
            }
        }


        public bool Save()
        {
            switch (this._Mode)
            {
                case enMode.eAddNew:
                    {
                        if (this._AddUser())
                        {
                            this._Mode = enMode.eUpdate;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.eUpdate:
                    {
                        return _UpdateUser ();
                    }
                default:
                    {
                        return false;
                    }
            }

        }

        public bool Delete()
        {
            if (clsUserData.DeleteUser(this.UserID))
            {
                _Mode = enMode.eAddNew;
                UserID = -1;
                PersonID = -1;
                UserName = "";
                Password = "";
                IsActive = false;

                return true;
            }
            else
            {
                return false;
            }

        }

        public static DataTable UsersTable()
        {
            return clsUserData.GetUsersList();
        }

        public static bool isUserExists(int UserIDOrPersonID)
        {
            return clsUserData.DoUserExists(UserIDOrPersonID);
        }


        public static bool isUserExists(string UserName)
        {
            return clsUserData.DoUserExists(UserName);
        }


    }
}
