using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;


namespace DVLD_Business
{
    public class clsDetainedLicense
    {

        public enum enMode { eAddNew = 1, eUpdate = 2 }

        private enMode _Mode;

        public int DetainID { get; private set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public float FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; } 
        public int ReleasedByUserID { get; set; } 
        public int ReleaseApplicationID { get; set; }

        // Constructor for updating a detained license
        private clsDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID, bool IsReleased
            , DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            _Mode = enMode.eUpdate;
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
        }

        // Method to add a detained license
        private bool _AddDetainedLicense()
        {
            return (this.DetainID = clsDetainedLicenseData.AddDetainedLicense(LicenseID, DetainDate, FineFees, CreatedByUserID)) != -1;
        }

        // Method to update a detained license
        private bool _UpdateDetainedLicense()
        {
            return clsDetainedLicenseData.UpdateDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
        }

        // Constructor for creating a new detained license
        public clsDetainedLicense(int LicenseID)
        {
            this._Mode = enMode.eAddNew;
            this.DetainID = -1;
            this.LicenseID = LicenseID;
            this.DetainDate = DateTime.MinValue;
            this.FineFees = 0.0f;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MinValue;
            this.ReleasedByUserID = -1;
            this.ReleaseApplicationID = -1;
        }

        // Method to find a detained license by DetainID
        public static clsDetainedLicense Find(int DetainID_LicenseID)
        {
            int LicenseID = DetainID_LicenseID;
            int DetainID = DetainID_LicenseID;
            DateTime DetainDate = DateTime.MinValue;
            float FineFees = 0.0f;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MinValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clsDetainedLicenseData.GetDetainedLicenseByDetainID(DetainID_LicenseID, ref LicenseID, ref DetainDate, ref FineFees
                , ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))

            {
                return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased
                    , ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            }

            else if(clsDetainedLicenseData.GetDetainedLicenseByLicenseID(DetainID_LicenseID, ref DetainID, ref DetainDate, ref FineFees
                , ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))

            {
                return new clsDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased
                    , ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
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
                        if (this._AddDetainedLicense())
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
                        return _UpdateDetainedLicense();
                    }
                default:
                    {
                        return false;
                    }
            }
        }

        public bool ReleaseLicense(DateTime ReleaseDate, int ReleasedByUserID, int ReleaseApplicationID)
        {
            this.IsReleased = true;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            return this.Save();
        }

        // Method to delete a detained license
        //public bool Delete()
        //{
        //    if (clsDetainedLicenseData.DeleteDetainedLicense(this.DetainID))
        //    {
        //        _Mode = enMode.eAddNew;
        //        this._Mode = enMode.eAddNew;
        //        this.DetainID = -1;
        //        this.LicenseID = -1;
        //        this.DetainDate = DateTime.MinValue;
        //        this.FineFees = 0.0f;
        //        this.CreatedByUserID = -1;
        //        this.IsReleased = false;
        //        this.ReleaseDate = null;
        //        this.ReleasedByUserID = null;
        //        this.ReleaseApplicationID = null;

        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        // Static method to return a DataTable of all detained licenses

        public static DataTable DetainedLicensesTable()
        {
            return clsDetainedLicenseData.GetDetainedLicensesList();
        }

        // Static method to check if a detained license is detained by LicenseID or DetainID
        public static int isDetainedLicense(int LicenseID_DetainID)
        {
            return clsDetainedLicenseData.isDetainedLicense(LicenseID_DetainID);
        }

        // Static method to check if a detained license exists by LicenseID or DetainID
        public static bool DoDetainedLicenseExists(int DetainID_LicenseID)
        {
            return clsDetainedLicenseData.DoDetainedLicenseExists(DetainID_LicenseID);
        }


    }
}
