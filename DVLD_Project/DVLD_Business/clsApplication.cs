using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsApplication
    {
        enum enMode { eAddNew = 1, eUpdate = 2 };
        private enMode _Mode;

        public int ApplicationID { get; private set; }

        public int ApplicantPersonID { get; set; }

        public DateTime ApplicationDate { get; set; }

        public int ApplicationTypeID { get; set; }

        public short ApplicationStatus { get; set; }

        public DateTime LastStatusDate { get; set; }

        public float PaidFees { get; set; }

        public int CreatedByUserID { get; set; }



        private clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
            int ApplicationTypeID, short ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            _Mode = enMode.eUpdate;
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
        }

        private bool _AddApplication()
        {
            return (this.ApplicationID = clsApplicationData.AddApplication(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID)) != -1;
        }

        private bool _UpdateApplication()
        {
            return clsApplicationData.UpdateApplication(ApplicationID, ApplicantPersonID, ApplicationDate,
            ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
        }

        // ------------------------------------------------>

        public clsApplication()
        {
            _Mode = enMode.eAddNew;
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = -1;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;
        }

        public static clsApplication Find(int ApplicationID)
        {
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            short ApplicationStatus = -1;
            DateTime LastStatusDate = DateTime.Now;
            float PaidFees = -1;
            int CreatedByUserID = -1;

            if (clsApplicationData.GetApplicationByID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate,
            ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
            {

                return new clsApplication(ApplicationID, ApplicantPersonID, ApplicationDate,
                        ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
            }
            else
            {
                return null;
            }

        }

        public static int OpenedApplicationID(int ApplicantPersonID, int ApplicationTypeID)
        {
            return clsApplicationData.IsThereAnotherOpenApplication(ApplicantPersonID, ApplicationTypeID);
        }


        public bool Save()
        {
            switch (this._Mode)
            {
                case enMode.eAddNew:
                    {
                        if (this._AddApplication())
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
                        return _UpdateApplication();
                    }
                default:
                    {
                        return false;
                    }
            }

        }

        public bool Delete()
        {
            if (clsApplicationData.DeleteApplication(this.ApplicationID))
            {
                _Mode = enMode.eAddNew;
                this.ApplicationID = -1;
                this.ApplicantPersonID = -1;
                this.ApplicationDate = DateTime.Now;
                this.ApplicationTypeID = -1;
                this.ApplicationStatus = -1;
                this.LastStatusDate = DateTime.Now;
                this.PaidFees = -1;
                this.CreatedByUserID = -1;

                return true;
            }
            else
            {
                return false;
            }

        }

        public static DataTable ApplicationsTable()
        {
            return clsApplicationData.GetApplicationsList();
        }

        public static bool isApplicationExists(int ApplicationID)
        {
            return clsApplicationData.DoApplicationExists(ApplicationID);
        }




    }
}
