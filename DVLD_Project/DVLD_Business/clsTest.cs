using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsTest
    {

        // TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID
        // int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID
        // ref int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID
        // ref TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID


        private enum enMode { eAddNew = 1, eUpdate = 2 };

        private enMode _Mode;

        public int TestID { get; private set; }

        public int TestAppointmentID { get; set; }

        public bool TestResult { get; set; }

        public string Notes { get; set; }

        public int CreatedByUserID { get; set; }

        private bool _AddTest()
        {
            return (this.TestID = clsTestData.AddTest(TestAppointmentID, TestResult, Notes, CreatedByUserID)) != -1;
        }

        private bool _UpdateTest()
        {
            return clsTestData.UpdateTest(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
        }

        private clsTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            _Mode = enMode.eUpdate;
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
        }

        public clsTest ()
        {
            _Mode = enMode.eAddNew;
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = string.Empty;
            CreatedByUserID = -1;
        }


        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3};

        public static bool IsPassed(int TestAppointmentID)
        {
            return clsTestData.ExistingPassedTest(TestAppointmentID);
        }

        public static bool IsPassedAll(int LDLAID, enTestType TestType)
        {
            DataTable TestAppointments = clsTestAppointment.TestAppointmentsTable(LDLAID, (clsTestAppointment.enTestType)TestType);
            if(TestAppointments.Rows.Count < 1)
            {
                return false;
            }

            foreach(DataRow row in TestAppointments.Rows)
            {
                if (IsPassed(Convert.ToInt32(row["TestAppointmentID"])))
                {
                    return true;
                }
            }
            return false;
        }

        public static clsTest Find(int TestID_TestAppointmentID)
        {
            bool TestResult = false;
            string Notes = string.Empty;
            int CreatedByUserID = -1;
            if(clsTestData.GetTestWithID(TestID_TestAppointmentID, ref TestID_TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTest(TestID_TestAppointmentID, TestID_TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else if (clsTestData.GetTestWithTestAppointmentID(ref TestID_TestAppointmentID, TestID_TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTest(TestID_TestAppointmentID, TestID_TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.eAddNew:
                    {
                        if(this._AddTest())
                        {
                            this._Mode = enMode.eUpdate;
                            return true;
                        }
                        break;
                    }
                case enMode.eUpdate:
                    {
                        if(this._UpdateTest())
                        {
                            return true;
                        }
                        break;
                    }
            }
            return false;
        }

        public bool Delete()
        {
            return clsTestData.DeleteTest(this.TestID);
        }

    }
}
