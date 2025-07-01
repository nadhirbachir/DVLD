using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Business;

namespace DVLD_Business
{
    public class clsLDLA
    {
        enum enMode { eAddNew = 1, eUpdate = 2 };
        private enMode _Mode;

        public int LDLAID { get; private set; }

        public int ApplicationID { get; set; }

        public int LicenseClassID { get; set; }


        private clsLDLA(int LDLAID, int ApplicationID, int LicenseClassID)
        {
            _Mode = enMode.eUpdate;
            this.LDLAID = LDLAID;
            this.ApplicationID = ApplicationID;
            this.LicenseClassID = LicenseClassID;
        }

        private bool _AddLDLA()
        {
            return (this.LDLAID = clsLDLAData.AddLDLA(this.ApplicationID, this.LicenseClassID)) != -1;
        }

        private bool _UpdateLDLA()
        {
            return clsLDLAData.UpdateLDLA(this.LDLAID, this.ApplicationID, this.LicenseClassID);
        }

        // ------------------------------------------------>

        public clsLDLA()
        {
            _Mode = enMode.eAddNew;
            this.LDLAID = -1;
            this.ApplicationID = -1;
            this.LicenseClassID = -1;
        }

        public static clsLDLA Find(int LDLAID)
        {
            int ApplicationID = -1;
            int LicenseClassID = -1;

            if (clsLDLAData.GetLDLAByID(LDLAID, ref ApplicationID, ref LicenseClassID))
            {

                return new clsLDLA(LDLAID, ApplicationID, LicenseClassID);
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
                        if (this._AddLDLA())
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
                        return _UpdateLDLA();
                    }
                default:
                    {
                        return false;
                    }
            }

        }

        public bool Delete()
        {
            if (clsLDLAData.DeleteLDLA(this.LDLAID))
            {
                _Mode = enMode.eAddNew;
                this.LDLAID = -1;
                this.ApplicationID = -1;
                this.LicenseClassID = -1;

                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Cancle()
        {
            return clsLDLAData.CancleLDLA(this.LDLAID);
        }

        public static DataTable LDLATable()
        {
            return clsLDLAData.GetLDLAList();
        }

        public static DataTable FullLDLATable()
        {
            return clsLDLAData.GetFullLDLAList();
        }

        public static DataRow GetFullLDLARowByID(int LDLAID)
        {
            return clsLDLAData.GetFullLDLAByID(LDLAID);
        }

        public static bool DoLDLAExist(int LDLAID)
        {
            return clsLDLAData.DoLDLAExists(LDLAID);
        }

        public static int DoLDLAExist(int ApplicantPersonID, int LicenseClassID)
        {
            return clsLDLAData.DoLDLAExistsAppID(ApplicantPersonID, LicenseClassID);
        }

        public int PassedTestsCount()
        {
            return clsLDLAData.GetPassedTestCountByLDLAID(this.LDLAID);
        }

    }
}
