using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;


namespace DVLD_Business
{
    public class clsLicense
    {

        enum enMode { eAddNew = 1, eUpdate = 2 }
        private enMode _Mode;

        public int LicenseID { get; private set; }

        public int ApplicationID { get; private set; }

        public int DriverID { get; set; }

        public int LicenseClassID { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string Notes { get; set; }

        public float PaidFees { get; set; }

        public bool IsActive { get; set; }

        public short IssueReason { get; set; }

        public int CreatedByUserID { get; set; }

        // Constructor for updating a license
        private clsLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees, bool IsActive, short IssueReason, int CreatedByUserID)
        {
            _Mode = enMode.eUpdate;
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClassID = LicenseClassID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
        }

        // Method to add a license
        private bool _AddLicense()
        {
            return (this.LicenseID = clsLicenseData.AddLicense(ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)) != -1;
        }

        // Method to update a license
        private bool _UpdateLicense()
        {
            return clsLicenseData.UpdateLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
        }

        // Constructor for creating a new license
        public clsLicense(int ApplicationID)
        {
            this._Mode = enMode.eAddNew;
            this.LicenseID = -1;
            this.ApplicationID = ApplicationID;
            this.DriverID = -1;
            this.LicenseClassID = -1;
            this.IssueDate = DateTime.MinValue;
            this.ExpirationDate = DateTime.MinValue;
            this.Notes = string.Empty;
            this.PaidFees = 0.0f;
            this.IsActive = false;
            this.IssueReason = 0;
            this.CreatedByUserID = -1;
        }

        // Method to find a license by LicenseID or ApplicationID
        public static clsLicense Find(int LicenseID_ApplicationID)
        {
            int LicenseID = LicenseID_ApplicationID;
            int ApplicationID = LicenseID_ApplicationID;
            int DriverID = -1;
            int LicenseClassID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = string.Empty;
            float PaidFees = 0.0f;
            bool IsActive = false;
            short IssueReason = 0;
            int CreatedByUserID = -1;

            if (clsLicenseData.GetLicenseByLicenseID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClassID, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            else if (clsLicenseData.GetLicenseByApplicationID(ApplicationID, ref LicenseID, ref DriverID, ref LicenseClassID, ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        // Save method (Add or Update)
        public bool Save()
        {
            switch (this._Mode)
            {
                case enMode.eAddNew:
                    {
                        if (this._AddLicense())
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
                        return _UpdateLicense();
                    }
                default:
                    {
                        return false;
                    }
            }
        }

        // Method to delete a license
        public bool Delete()
        {
            if (clsLicenseData.DeleteLicense(this.LicenseID))
            {
                _Mode = enMode.eAddNew;
                this._Mode = enMode.eAddNew;
                this.LicenseID = -1;
                this.ApplicationID = -1;
                this.DriverID = -1;
                this.LicenseClassID = -1;
                this.IssueDate = DateTime.MinValue;
                this.ExpirationDate = DateTime.MinValue;
                this.Notes = string.Empty;
                this.PaidFees = 0.0f;
                this.IsActive = false;
                this.IssueReason = 0;
                this.CreatedByUserID = -1;

                return true;
            }
            else
            {
                return false;
            }
        }

        // Static method to return a DataTable of all licenses
        public static DataTable LicensesTable()
        {
            return clsLicenseData.GetLicensesList();
        }

        // Static method to check if a license exists by LicenseID or ApplicationID
        public static bool isLicenseExists(int LicenseID_ApplicationID)
        {
            return clsLicenseData.DoLicenseExists(LicenseID_ApplicationID);
        }

        // Static method to check if a license exists by DriverID and LicenseClassID
        public static bool isLicenseExists(int DriverID, int LicenseClassID)
        {
            return clsLicenseData.DoLicenseExists(DriverID, LicenseClassID);
        }

        public static DataTable PersonLicenseHistory(int PersonID)
        {
            return clsLicenseData.GetLicenseHistoryByPersonID(PersonID);            
        }

        public static DataTable DriverLicenseHistory(int DriverID)
        {
            return clsLicenseData.GetLicenseHistoryByDriverID(DriverID);
        }

    }
}
