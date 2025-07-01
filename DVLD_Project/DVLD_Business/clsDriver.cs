using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsDriver
    {

        enum enMode { eAddNew = 1, eUpdate = 2 }
        private enMode _Mode;

        public int DriverID { get; private set; }

        public int PersonID { get; private set; }

        public int CreatedByUserID { get; set; }

        public DateTime CreatedDate { get; set; }



        private clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            _Mode = enMode.eUpdate;
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedDate = CreatedDate;
        }

        private bool _AddDriver()
        {
            return (this.DriverID = clsDriverData.AddDriver(PersonID, CreatedByUserID, CreatedDate)) != -1;
        }

        private bool _UpdateDriver()
        {
            return clsDriverData.UpdateDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
        }

        // ------------------------------------------------>

        public clsDriver(int PersonID)
        {
            this._Mode = enMode.eAddNew;
            this.DriverID = -1;
            this.PersonID = PersonID;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.MinValue;
        }

        public static clsDriver Find(int DriverID_PersonID)
        {
            int DriverID = DriverID_PersonID;
            int PersonID = DriverID_PersonID;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;

            if (clsDriverData.GetDriverByDriverID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {

                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else if (clsDriverData.GetDriverByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
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
                        if (this._AddDriver())
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
                        return _UpdateDriver();
                    }
                default:
                    {
                        return false;
                    }
            }

        }

        public bool Delete()
        {
            if (clsDriverData.DeleteDriver(this.DriverID))
            {
                _Mode = enMode.eAddNew;
                this._Mode = enMode.eAddNew;
                this.DriverID = -1;
                this.PersonID = -1;
                this.CreatedByUserID = -1;
                this.CreatedDate = DateTime.MinValue;

                return true;
            }
            else
            {
                return false;
            }

        }

        public static DataTable DriversTable()
        {
            return clsDriverData.GetDriversList();
        }

        public static bool isDriverExists(int DriverID_PersonID)
        {
            return clsDriverData.DoDriverExists(DriverID_PersonID);
        }


    }
}
