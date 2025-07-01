using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsInternationalLicense
    {
        enum enMode { eAddNew = 1, eUpdate = 2 }
        private enMode _Mode;

        public int InternationalLicenseID { get; private set; }

        public int ApplicationID { get; private set; }

        public int DriverID { get; set; }

        public int IssuedUsingLocalLicenseID { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool IsActive { get; set; }

        public int CreatedByUserID { get; set; }

        // Constructor for updating an international license
        private clsInternationalLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            _Mode = enMode.eUpdate;
            this.InternationalLicenseID = InternationalLicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;
        }

        // Method to add an international license
        private bool _AddInternationalLicense()
        {
            return (this.InternationalLicenseID = clsInternationalLicenseData.AddInternationalLicense(ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)) != -1;
        }

        // Method to update an international license
        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicenseData.UpdateInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
        }

        // Constructor for creating a new international license
        public clsInternationalLicense(int ApplicationID)
        {
            this._Mode = enMode.eAddNew;
            this.InternationalLicenseID = -1;
            this.ApplicationID = ApplicationID;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.MinValue;
            this.ExpirationDate = DateTime.MinValue;
            this.IsActive = false;
            this.CreatedByUserID = -1;
        }

        // Method to find an international license by InternationalLicenseID or ApplicationID
        public enum enSearchOption { ILID = 1, AppID = 2, LLID = 3};

        public static clsInternationalLicense Find(int ILID_AppID_LLID, enSearchOption SearchOption)
        {
            int InternationalLicenseID = ILID_AppID_LLID;
            int ApplicationID = ILID_AppID_LLID;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = ILID_AppID_LLID;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            bool IsActive = false;
            int CreatedByUserID = -1;

            switch(SearchOption)
            {
                case enSearchOption.ILID:
                    {
                        if (clsInternationalLicenseData.GetInternationalLicenseByID(InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
                        {
                            return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
                        }
                        return null;
                    }
                case enSearchOption.AppID:
                    {
                        if (clsInternationalLicenseData.GetInternationalLicenseByApplicationID(ApplicationID, ref InternationalLicenseID, ref DriverID, ref IssuedUsingLocalLicenseID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
                        {
                            return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
                        }
                        return null;
                    }
                case enSearchOption.LLID:
                    {
                        if(clsInternationalLicenseData.GetInternationalLicenseByLicenseID(ILID_AppID_LLID, ref InternationalLicenseID, ref ApplicationID, ref DriverID, ref IssueDate, ref ExpirationDate, ref IsActive, ref CreatedByUserID))
                        {
                            return new clsInternationalLicense(InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID);
                        }
                        return null;
                    }
            }
            return null;
        }

        // Save method (Add or Update)
        public bool Save()
        {
            switch (this._Mode)
            {
                case enMode.eAddNew:
                    {
                        if (this._AddInternationalLicense())
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
                        return _UpdateInternationalLicense();
                    }
                default:
                    {
                        return false;
                    }
            }
        }

        // Method to delete an international license
        public bool Delete()
        {
            if (clsInternationalLicenseData.DeleteInternationalLicense(this.InternationalLicenseID))
            {
                _Mode = enMode.eAddNew;
                this._Mode = enMode.eAddNew;
                this.InternationalLicenseID = -1;
                this.ApplicationID = -1;
                this.DriverID = -1;
                this.IssuedUsingLocalLicenseID = -1;
                this.IssueDate = DateTime.MinValue;
                this.ExpirationDate = DateTime.MinValue;
                this.IsActive = false;
                this.CreatedByUserID = -1;

                return true;
            }
            else
            {
                return false;
            }
        }

        // Static method to return a DataTable of all international licenses
        public static DataTable InternationalLicensesTable()
        {
            return clsInternationalLicenseData.GetInternationalLicensesList();
        }

        // Static method to check if an international license exists by InternationalLicenseID or ApplicationID


        public static bool isInternationalLicenseExists(int ILID_AppID_LLID, enSearchOption SearchOption)
        {
            return clsInternationalLicenseData.DoInternationalLicenseExists(ILID_AppID_LLID, Convert.ToInt16(SearchOption));
        }

        // Static method to check if an international license exists by DriverID and LicenseClassID
        public static bool isInternationalLicenseExists(int DriverID, int LicenseClassID)
        {
            DataTable DriverInternationalLicenses = clsInternationalLicenseData.GetInternationalLicenseHistoryByDriverID(DriverID);

            clsLicense localLicense = null;

            foreach(DataRow License in DriverInternationalLicenses.Rows)
            {
                localLicense = clsLicense.Find(Convert.ToInt32(License["IssuedUsingLocalLicenseID"]));
                if (localLicense.LicenseClassID == LicenseClassID) // check if driver have the same international license class
                {
                    return true;
                }
            }
            return false;
        }

        // Static method to return a driver's international license history by PersonID
        public static DataTable PersonInternationalLicenseHistory(int PersonID)
        {
            int PersonDriverID = clsDriver.Find(PersonID).DriverID; // get the DriverID from personID and search using it

            return clsInternationalLicenseData.GetInternationalLicenseHistoryByDriverID(PersonDriverID);
        }

        // Static method to return a driver's international license history by DriverID
        public static DataTable DriverInternationalLicenseHistory(int DriverID)
        {
            return clsInternationalLicenseData.GetInternationalLicenseHistoryByDriverID(DriverID);
        }

    }
}
