using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Business
{
    public class clsTestType
    {
        enum enMode { eNew = 1, eUpdate = 2 };
        private enMode _Mode;


        public int TestTypeID { get; private set; }

        public string TestTypeTitle { get; set; }

        public string TestTypeDescription { get; set; }

        public float TestFees { get; set; }

        private clsTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, float TestFees)
        {
            _Mode = enMode.eUpdate;
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestFees = TestFees;
            this.TestTypeDescription = TestTypeDescription;
        }

        public clsTestType()
        {
            _Mode = enMode.eNew;
            TestTypeID = -1;
            TestTypeTitle = "";
            TestFees = 0;
            TestTypeDescription = "";
        }

        private bool _Update()
        {
            return clsTestTypeData.UpdateTestType(this.TestTypeID, this.TestTypeDescription, this.TestTypeTitle, this.TestFees);
        }

        public bool Save()
        {
            if (_Mode == enMode.eUpdate)
            {
                return _Update();
            }
            return false;
        }

        public static DataTable TestTypeTable()
        {
            return clsTestTypeData.GetTestTypeList();
        }

        public static clsTestType Find(int TestID)
        {
            string TestTypeName = "";
            string TestTypeDescription = "";
            float TestFees = 0;
            if (clsTestTypeData.GetTestTypeWithID(TestID, ref TestTypeName, ref TestTypeDescription, ref TestFees))
            {
                return new clsTestType(TestID, TestTypeName, TestTypeDescription, TestFees);
            }
            else
            {
                return null;
            }
        }
    }
}
