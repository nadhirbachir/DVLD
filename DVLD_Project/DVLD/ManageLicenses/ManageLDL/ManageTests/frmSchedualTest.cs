using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD
{
    public partial class frmSchedualTest : Form
    {

        private enum enMode { eAddNew = 1, eUpdate = 2, eRetakeTest = 3};

        clsTest.enTestType _TestType;

        enMode _Mode;

        clsTestAppointment _TestApt = null;

        clsLDLA _LDLA = null;


        private void FillForm(int LDLAID, int TestAppointmentID, clsTest.enTestType TestType, bool RetakeTest = false)
        {
            // if the LDLA not found then close this form
            if ((_LDLA = clsLDLA.Find(LDLAID)) == null)
            {
                MessageBox.Show("There's no Local driving license with the provided ID", "LDLA not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _TestType = TestType;

            // 
            if ((_TestApt = clsTestAppointment.Find(TestAppointmentID)) == null)
            {
                _Mode = RetakeTest ? enMode.eRetakeTest : enMode.eAddNew;
                return;
            }

            _Mode = enMode.eUpdate;
            

        }

        public frmSchedualTest(int LDLAID, int TestAppointmentID, clsTest.enTestType TestType, bool RetakeTest = false)
        {
            InitializeComponent();
            FillForm(LDLAID, TestAppointmentID, TestType, RetakeTest);

        }

        private void DisplaySchedualInformations()
        {
            dtpTestAppointmentDate.Value = _TestApt != null ? _TestApt.AppointmentDate : DateTime.Now;

            dtpTestAppointmentDate.MinDate = DateTime.Now;
            
            lbLDLAID.Text = _LDLA.LDLAID.ToString();
            
            lbClassName.Text = clsLicenseClass.GetLicenseClassNameByID(_LDLA.LicenseClassID);
            
            lbPersonName.Text = clsPerson.Find(clsApplication.Find(_LDLA.ApplicationID).ApplicantPersonID).FullName();
            
            
        }

        private void SetupUpdateMode()
        {
            if (_TestApt.IsLocked)
            {
                dtpTestAppointmentDate.Enabled = false;
                btnSave.Enabled = false;
                tbWarning.Visible = true;
                lbTrials.Text = "0";
            }
            lbTrials.Text = "1";
            if(_TestApt.RetakeTestApplicationID != -1)
            {
                lbRetakeTestID.Text = _TestApt.RetakeTestApplicationID.ToString();
                lbRTAFees.Text = clsApplicationType.Find(7).ApplicationFees.ToString();
            }
           
        }

        private void SetupRetakeTestMode()
        {
            gbRetakeTest.Enabled = true;
            lbTrials.Text = "0";
            lbRTAFees.Text = clsApplicationType.Find(7).ApplicationFees.ToString();
            lbRetakeTestID.Text = _TestApt == null ? "N/A" : _TestApt.RetakeTestApplicationID.ToString();
        }

        private void SetupDefaultMode()
        {
            gbRetakeTest.Enabled = false;
            lbTrials.Text = "1";
            lbRTAFees.Text = "0";
        }

        private void SetupFormBasedOnMode()
        {
            if (_Mode == enMode.eRetakeTest)
            {
                SetupRetakeTestMode();
            }
            else if (_Mode == enMode.eUpdate)
            {
                SetupUpdateMode();
            }
            else
            {
                SetupDefaultMode();
            }
        }

        private void CalculateFees()
        {
            float testFees = clsTestType.Find(Convert.ToInt32(_TestType)).TestFees;
            lbTestFees.Text = testFees.ToString();

            lbTotalFees.Text = (Convert.ToSingle(lbRTAFees.Text) + testFees).ToString();
        }

        private void frmSchedualTest_Load(object sender, EventArgs e)
        {
            DisplaySchedualInformations();
            SetupFormBasedOnMode();
            CalculateFees();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewTestAppointment()
        {
            _TestApt = new clsTestAppointment();
            _TestApt.TestTypeID = Convert.ToInt16(_TestType);
            _TestApt.LDLAID = _LDLA.LDLAID;
            _TestApt.AppointmentDate = dtpTestAppointmentDate.Value;
            _TestApt.PaidFees = Convert.ToSingle(lbTotalFees.Text);
            _TestApt.CreatedByUserID = clsGlobal.MainUser.UserID;
            _TestApt.IsLocked = false;
            _TestApt.RetakeTestApplicationID = -1;
            if (_TestApt.Save())
            {
                MessageBox.Show("Test Appointment Added succesfully", "Adding Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Test Appointment Adding failed", "Adding Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdateTestAppointment()
        {
            _TestApt.AppointmentDate = dtpTestAppointmentDate.Value;
            if (_TestApt.Save())
            {
                MessageBox.Show("Test Appointment updated succesfully", "Updating Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("Test Appointment updating failed", "Updating Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void RetakeTestAppointment()
        {
            clsApplication RTA = new clsApplication();
            RTA.ApplicantPersonID = clsApplication.Find(_LDLA.ApplicationID).ApplicantPersonID;
            RTA.ApplicationDate = DateTime.Now;
            RTA.ApplicationTypeID = 7; // retake test application type ID
            RTA.ApplicationStatus = 1; // now it's new status, if person failed turn it to cancelled, if he passed so it's completed
            RTA.LastStatusDate = DateTime.Now;
            RTA.CreatedByUserID = clsGlobal.MainUser.UserID;
            RTA.PaidFees = clsApplicationType.Find(7).ApplicationFees;

            if(RTA.Save())
            {
                _TestApt = new clsTestAppointment();
                _TestApt.TestTypeID = Convert.ToInt16(_TestType);
                _TestApt.LDLAID = _LDLA.LDLAID;
                _TestApt.AppointmentDate = dtpTestAppointmentDate.Value;
                _TestApt.PaidFees = Convert.ToSingle(lbTotalFees.Text);
                _TestApt.CreatedByUserID = clsGlobal.MainUser.UserID;
                _TestApt.IsLocked = false;
                _TestApt.RetakeTestApplicationID = RTA.ApplicationID;

                if (_TestApt.Save())
                {
                    MessageBox.Show("Test Appointment Added succesfully", "Adding Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Test Appointment Adding failed", "Adding Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Retake test application saving failed", "Failed saving application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch(_Mode)
            {
                case enMode.eAddNew:
                    {
                        AddNewTestAppointment();
                        _Mode = enMode.eUpdate;
                        break;
                    }
                case enMode.eUpdate:
                    {
                        UpdateTestAppointment();
                        break;
                    }
                case enMode.eRetakeTest:
                    {
                        RetakeTestAppointment();
                        break;
                    }
            }
        }
    }
}
