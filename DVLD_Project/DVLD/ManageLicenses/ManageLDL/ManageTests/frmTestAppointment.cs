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
    public partial class frmTestAppointment : Form
    {



        public enum enTestMode { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };

        private enum enTestStatus { eOpen = 1, ePassed = 2, eNatural = 3, eError = 4 };

        enTestStatus _TestStatus;

        enTestMode _TestMode;
        //clsLDLA LDLA = null;
        int _LDLAID = -1;


        private void _Refresh()
        {

            dgvTestAppointments.DataSource = clsTestAppointment.TestAppointmentsTable(this._LDLAID, (clsTestAppointment.enTestType)_TestMode);
            FillTestStatus((clsTestAppointment.enTestType)_TestMode);
        }

        public frmTestAppointment(int LDLAID, enTestMode Mode)
        {
            InitializeComponent();
            if (!clsLDLA.DoLDLAExist(LDLAID))
            {
                MessageBox.Show("There's no Local driving license application with the providen ID", "Error finding LDLA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            _TestMode = Mode;
            _LDLAID = LDLAID;
            //LDLA = clsLDLA.Find(LDLAID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillTestStatus(clsTestAppointment.enTestType testType)
        {
            _TestStatus = clsTest.IsPassedAll(_LDLAID, (clsTest.enTestType)testType) ? enTestStatus.ePassed :
                            clsTestAppointment.OpenTestAppointmentExist(_LDLAID, (clsTestAppointment.enTestType)testType) ? enTestStatus.eOpen :
                            enTestStatus.eNatural;
        }

        private void frmTestAppointment_Load(object sender, EventArgs e)
        {
            ctrlLDLAInfo1.LoadLDLAInfo(_LDLAID);

            _Refresh();

            switch (_TestMode)
            {
                case enTestMode.VisionTest:
                    {
                        lbHeader.Text = "Vision Test Appointment";
                        break;
                    }
                case enTestMode.WrittenTest:
                    {
                        lbHeader.Text = "Written Test Appointment";
                        break;
                    }
                case enTestMode.StreetTest:
                    {
                        lbHeader.Text = "Street Test Appointment";
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Test Type not found", "Error test type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _TestStatus = enTestStatus.eError;
                        this.Close();
                        break;
                    }
            }
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            switch (_TestStatus)
            {
                case enTestStatus.ePassed:
                    {
                        MessageBox.Show("The Test is already passed by this person", "Test have been completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                case enTestStatus.eOpen:
                    {
                        MessageBox.Show("There's infinished test", "Test not been taken", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
            }
            if (_TestStatus == enTestStatus.eNatural && dgvTestAppointments.RowCount > 0)
            {
                frmSchedualTest SchedualRetakeTestForm = new frmSchedualTest(_LDLAID, -1, (clsTest.enTestType)_TestMode, true);
                SchedualRetakeTestForm.ShowDialog();


            }
            if (_TestStatus == enTestStatus.eNatural && dgvTestAppointments.RowCount == 0)
            {
                frmSchedualTest SchedualTestForm = new frmSchedualTest(_LDLAID, -1, (clsTest.enTestType)_TestMode, false);
                SchedualTestForm.ShowDialog();
            }
            _Refresh();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedTestApt = Convert.ToInt32(dgvTestAppointments.SelectedRows[0].Cells[0].Value);
            frmSchedualTest EditTestAptForm = new frmSchedualTest(_LDLAID, SelectedTestApt, (clsTest.enTestType)_TestMode, false);
            EditTestAptForm.ShowDialog();
            _Refresh();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int SelectedTestApt = Convert.ToInt32(dgvTestAppointments.SelectedRows[0].Cells[0].Value);
            frmTakeTest TakeTestForm = new frmTakeTest(_LDLAID, SelectedTestApt);
            TakeTestForm.ShowDialog();
            _Refresh();
        }

    }
}
