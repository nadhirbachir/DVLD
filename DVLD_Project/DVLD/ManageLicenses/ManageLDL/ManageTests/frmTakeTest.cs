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
    public partial class frmTakeTest : Form
    {

        private enum enMode { eAddNew = 1, eUpdate = 2 };

        clsLDLA _LDLA = null;

        clsTestAppointment TestApt = null;

        private void CheckData(int LDLAID, int testAptID)
        {
            if ((_LDLA = clsLDLA.Find(LDLAID)) == null)
            {
                MessageBox.Show("Local driving license application with the Provided ID not found", "LDLA Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if ((TestApt = clsTestAppointment.Find(testAptID)) == null)
            {
                MessageBox.Show("Test Appointment with the Provided ID not found", "TEST APT Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void SetMode(int TestAptID)
        {
            clsTest tempTest = clsTest.Find(TestAptID);
            if(tempTest != null || TestApt.IsLocked)
            {

                rbPassed.Enabled = false;
                rbFailed.Enabled = false;
                tbNotes.Enabled = false;
                btnSave.Enabled = false;
                if(tempTest != null)
                {
                    lbTestID.Text = tempTest.TestID.ToString();

                    if (tempTest.TestResult)
                    {
                        rbPassed.Checked = true;
                    }
                    else
                    {
                        rbFailed.Checked = true;
                    }
                    tbNotes.Text = tempTest.Notes;
                }

            }
            else
            {
                rbPassed.Enabled = true;
                rbFailed.Enabled = true;
                tbNotes.Enabled = true;
                btnSave.Enabled = true;
            }
        }

        public frmTakeTest(int LDLAID, int testAptID)
        {
            InitializeComponent();
            CheckData(LDLAID, testAptID);
            SetMode(testAptID);
        }

        private void DisplayData()
        {
            lbLDLAID.Text = _LDLA.LDLAID.ToString();
            lbClassName.Text = clsLicenseClass.GetLicenseClassNameByID(_LDLA.LicenseClassID);
            lbFullName.Text = clsPerson.Find(clsApplication.Find(_LDLA.ApplicationID).ApplicantPersonID).FullName();
            if(TestApt != null)
            {
                lbTestAptID.Text = TestApt.TestAppointmentID.ToString();
                lbAptDate.Text = TestApt.AppointmentDate.ToString("d");
                lbTestFees.Text = TestApt.PaidFees.ToString();
            }
            clsTest tempTest =  clsTest.Find(Convert.ToInt32(TestApt.TestAppointmentID));
            lbTestID.Text = (tempTest != null)? tempTest.TestID.ToString() : "not taken yet";
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool SetRetakeTestApplication(int RetakeTestApplicationID)
        {
            clsApplication app = clsApplication.Find(RetakeTestApplicationID);
            app.ApplicationStatus = rbPassed.Checked ? Convert.ToInt16(3) : Convert.ToInt16(2); // if passed the test then application status 
                                                                                                // completed otherwise status cancelled
            if (!app.Save())
            {
                MessageBox.Show("Retake test application status updating failed", "Error updating retake test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool SetTestAppointment()
        {
            TestApt.IsLocked = true;
            if (TestApt.RetakeTestApplicationID > 0)
            {
                if(!SetRetakeTestApplication(TestApt.RetakeTestApplicationID))
                {
                    return false;
                }
            }
            if (!TestApt.Save())
            {
                MessageBox.Show("Test appointment updating failed", "Error updating Test appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void AddTest()
        {
            if(!SetTestAppointment())
            {
                return;
            }

            clsTest NewTest = new clsTest();
            NewTest.TestAppointmentID = TestApt.TestAppointmentID;
            NewTest.Notes = tbNotes.Text;
            NewTest.TestResult = rbPassed.Checked;
            NewTest.CreatedByUserID = clsGlobal.MainUser.UserID;
            if (!NewTest.Save())
            {
                MessageBox.Show("Test Saving failed", "Error saving test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Test saved successfuly", "saving test result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to save the test result?, You can't change the result later", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.No)
            {
                return;
            }
            AddTest();
            btnSave.Enabled = false;
            this.Close();
        }
    }
}
