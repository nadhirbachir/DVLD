using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Business;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsApplicationType
    {

        enum enMode { eNew = 1, eUpdate = 2 };
        private enMode _Mode;


        public int ApplicationTypeID { get; private set; }

        public string ApplicationTypeTitle { get; set; }

        public float ApplicationFees { get; set; }

        private clsApplicationType(int applicationTypeID, string applicationTypeTitle, float applicationFees )
        {
            _Mode = enMode.eUpdate;
            ApplicationTypeID = applicationTypeID;
            ApplicationTypeTitle = applicationTypeTitle;
            ApplicationFees = applicationFees;
        }

        public clsApplicationType()
        {
            _Mode = enMode.eNew;
            ApplicationTypeID = -1;
            ApplicationTypeTitle = "";
            ApplicationFees = 0;
        }

        private bool _Update()
        {
            return clsApplicationTypeData.UpdateApplicationType(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
        }

        public bool Save()
        {
            if(_Mode == enMode.eUpdate)
            {
                return _Update(); 
            }
            return false;
        }

        public static DataTable ApplicationTypeTable()
        {
            return clsApplicationTypeData.GetApplicationTypeList();
        }

        public static clsApplicationType Find(int ApplicationID)
        {
            string ApplicationTypeName = "";
            float ApplicationFees = 0;
            if(clsApplicationTypeData.GetApplicationTypeWithID(ApplicationID,ref ApplicationTypeName,ref ApplicationFees))
            {
                return new clsApplicationType(ApplicationID, ApplicationTypeName, ApplicationFees);
            }
            else
            {
                return null;
            }
        }

    }
}
