using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;


namespace DVLD_Business
{
    public class clsTestAppointment
    {
        private enum enMode { eAddNew = 1, eUpdate = 2 };

        private enMode _Mode;

        public int TestAppointmentID { get; private set; }
        
        public int TestTypeID { get; set; }
        
        public int LDLAID { get; set; }
        
        public DateTime AppointmentDate { get; set; }
        
        public float PaidFees { get; set; }
        
        public int CreatedByUserID { get; set; }
        
        public bool IsLocked { get; set; }
        
        public int RetakeTestApplicationID { get; set; }

        private clsTestAppointment(int TestAppointmentID, int TestTypeID, int LDLAID, DateTime AppointmentDate, float PaidFees,
            int CreatedByUserID, bool isLocked, int RetakeTestApplicationID)
        {
            _Mode = enMode.eUpdate;
            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LDLAID = LDLAID;
            this.AppointmentDate = AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked = isLocked;
            this.RetakeTestApplicationID = RetakeTestApplicationID;
        }


        private bool _AddTestAppointment()
        {
            return (this.TestAppointmentID = clsTestAppointmentData.AddTestAppointment(TestTypeID, LDLAID, AppointmentDate, PaidFees,
            CreatedByUserID, IsLocked, RetakeTestApplicationID)) != -1;
        }

        private bool _UpdateTestAppointment()
        {
            return clsTestAppointmentData.UpdateTestAppointment(this.TestAppointmentID, TestTypeID, LDLAID, AppointmentDate, PaidFees,
            CreatedByUserID, IsLocked, RetakeTestApplicationID);
        }

        public clsTestAppointment()
        {
            _Mode = enMode.eAddNew;
            this.TestAppointmentID = -1;          
            this.TestTypeID = -1;                 
            this.LDLAID = -1;                     
            this.AppointmentDate = DateTime.MinValue;
            this.PaidFees = 0f;                
            this.CreatedByUserID = -1;            
            this.IsLocked = false;                
            this.RetakeTestApplicationID = -1;    
        }

        public static clsTestAppointment Find(int TestAppointmentID)
        {
            int TestTypeID = -1;
            int LDLAID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            float PaidFees = 0f;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestApplicationID = -1;

            if (clsTestAppointmentData.GetTestAppointmentWithID(TestAppointmentID,ref TestTypeID, ref LDLAID, ref AppointmentDate, ref PaidFees,
            ref CreatedByUserID, ref IsLocked, ref RetakeTestApplicationID))
            {

                return new clsTestAppointment(TestAppointmentID, TestTypeID, LDLAID, AppointmentDate, PaidFees,
                                CreatedByUserID, IsLocked, RetakeTestApplicationID);
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
                        if (this._AddTestAppointment())
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
                        return _UpdateTestAppointment();
                    }
                default:
                    {
                        return false;
                    }
            }

        }

        

        public static DataTable AllTestAppointmentsTable()
        {
            return clsTestAppointmentData.GetTestAppointmentsList();
        }

        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3};

        public static DataTable TestAppointmentsTable(int LDLAID, enTestType TestType)
        {
            return clsTestAppointmentData.GetSpecificTestAppointmentsList(LDLAID , Convert.ToInt32(TestType));
        }

        public static bool OpenTestAppointmentExist(int LDLAID, enTestType TestType)
        {
            return clsTestAppointmentData.IsThereOpenTestAppointments(LDLAID, Convert.ToInt32(TestType));
        }





    }
}
