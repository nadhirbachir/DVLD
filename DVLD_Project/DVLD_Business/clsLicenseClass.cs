using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsLicenseClass
    {

        enum enMode { eEmpty = 1, eUpdate = 2 }

        private enMode _Mode;

        public int LicenseClassID { get; private set; }

        public string ClassName { get; private set; }

        public string ClassDescription { get; private set; }

        public short MinAge { get; private set; }

        public short DefaultValidityLength { get; private set; }

        public float ClassFees { get; private set; }

        public static DataTable IDNameClassesTable()
        {
            return clsLicenseClassData.GetIDNameClassesList();
        }

        private clsLicenseClass(int LicenseClassID, string ClassName, string ClassDescription,
            short MinAge, short DefaultValidityLength, float ClassFees)
        {
            this._Mode = enMode.eUpdate;
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinAge = MinAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
        }

        public clsLicenseClass()
        {
            _Mode = enMode.eEmpty;
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.MinAge = 255;
            this.DefaultValidityLength = -1;
            this.ClassFees = -1;
        }

        public static clsLicenseClass Find(int LicenseClassID)
        {
            string ClassName = "";
            string ClassDescription = "";
            short MinAge = 255;
            short DefaultValidityLength = -1;
            float ClassFees = -1;
            if(clsLicenseClassData.GetLicenseClassByID(LicenseClassID, ref ClassName, ref ClassDescription,
            ref MinAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClassID, ClassName, ClassDescription,
                                    MinAge, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }

        public static string GetLicenseClassNameByID(int LicenseClassID)
        {
            return clsLicenseClassData.GetLicenseNameByID(LicenseClassID);
        }



    }
}
