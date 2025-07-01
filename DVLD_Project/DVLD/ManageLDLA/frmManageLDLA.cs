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
    public partial class frmManageLDLA : Form
    {

        DataTable src = clsLDLA.LDLATable();
        private void _RefreshDgv()
        {
            src = clsLDLA.LDLATable();
            dgvLDLA.DataSource = src;
            lbRecords.Text = dgvLDLA.RowCount.ToString();
        }

        public frmManageLDLA()
        {
            InitializeComponent();
            _RefreshDgv();
        }

        private void addNewLDLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEdit_LDL_Applications frm = new frmAddEdit_LDL_Applications(-1);
            frm.ShowDialog();
            _RefreshDgv();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAID = Convert.ToInt32(dgvLDLA.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value);
            frmAddEdit_LDL_Applications frm = new frmAddEdit_LDL_Applications(LDLAID);
            frm.ShowDialog();
            _RefreshDgv();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAID = Convert.ToInt32(dgvLDLA.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value);
            if(clsLDLA.Find(LDLAID).Delete())
            {
                MessageBox.Show("LDLA Deleted successfuly", "Deleting result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("LDLA deleting failed", "Deleting result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _RefreshDgv();
        }

        private void cancleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLAID = Convert.ToInt32(dgvLDLA.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value);
            if (clsLDLA.Find(LDLAID).Cancle())
            {
                MessageBox.Show("LDLA Cancled successfuly", "Cancling result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("LDLA cancling failed", "Cancling result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _RefreshDgv();
        }

        private void btnAddLDLA_Click(object sender, EventArgs e)
        {
            frmAddEdit_LDL_Applications frm = new frmAddEdit_LDL_Applications(-1);
            frm.ShowDialog();
            _RefreshDgv();
        }

        private void cbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilter == null || cbFilter.SelectedItem == null)
            {
                return;
            }

            if(cbFilter.SelectedItem.ToString() != "Status")
            {
                return;
            }

            DataView Filter = src.DefaultView;


            switch (cbStatusFilter.SelectedItem)
            {
                case "All":
                    {
                        Filter.RowFilter = "";
                        dgvLDLA.DataSource = Filter;
                        break;
                    }
                case "New":
                    {
                        Filter.RowFilter = "Status = 'New'";
                        dgvLDLA.DataSource = Filter;
                        break;
                    }
                case "Cancelled":
                    {
                        Filter.RowFilter = "Status = 'Cancelled'";
                        dgvLDLA.DataSource = Filter;
                        break;
                    }
                case "Completed":
                    {
                        Filter.RowFilter = "Status = 'Completed'";
                        dgvLDLA.DataSource = Filter;
                        break;
                    }
                default:
                    {
                        _RefreshDgv();
                        break;
                    }
            }
        }

        private void tbFilterString_TextChanged(object sender, EventArgs e)
        {

            string FilterString = tbFilterString.Text;
            if(string.IsNullOrEmpty(FilterString))
            {
                _RefreshDgv();
                return;
            }

            string SelectedStringFilter = cbFilter.SelectedItem.ToString();
            DataView Filter = src.DefaultView;

            switch (SelectedStringFilter)
            {
                case "Class Name":
                    {
                        Filter.RowFilter = $"ClassName LIKE '%{FilterString}%'";
                        dgvLDLA.DataSource = Filter;
                        break;
                    }
                case "National No":
                    {
                        Filter.RowFilter = $"NationalNo LIKE '%{FilterString}%'";
                        dgvLDLA.DataSource = Filter;
                        break;
                    }
                case "Name":
                    {
                        Filter.RowFilter = $"FullName LIKE '%{FilterString}%'";
                        dgvLDLA.DataSource = Filter;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            tbFilterString.Text = "";
            cbStatusFilter.SelectedItem = "All";
            tbDegitFilter.Text = "";
            _RefreshDgv();
            
            if(cbFilter.SelectedItem == null || cbFilter == null)
            {
                return;
            }

            string SelectedItem = cbFilter.SelectedItem.ToString();

            if(SelectedItem == "None")
            {
                tbFilterString.Visible = false;
                cbStatusFilter.Visible = false;
                tbDegitFilter.Visible = false;
                return;
            }

            if (SelectedItem == "Status")
            {
                tbFilterString.Visible = false;
                cbStatusFilter.Visible = true;
                tbDegitFilter.Visible = false;
                return;
            }

            if (SelectedItem == "Class Name" || SelectedItem == "National No" || SelectedItem == "Name")
            {
                tbFilterString.Visible = true;
                cbStatusFilter.Visible = false;
                tbDegitFilter.Visible = false;
                return;
            }

            if(SelectedItem == "L.D.L.A ID")
            {
                tbFilterString.Visible = false;
                cbStatusFilter.Visible = false;
                tbDegitFilter.Visible = true;
                return;
            }

        }

        private void tbDegitFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbDegitFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterDegit = tbDegitFilter.Text;
            if (string.IsNullOrEmpty(FilterDegit))
            {
                _RefreshDgv();
                return;
            }

            if(cbFilter.SelectedItem.ToString() == "L.D.L.A ID")
            {
                DataView Filter = src.DefaultView;
                Filter.RowFilter = $"LocalDrivingLicenseApplicationID = {FilterDegit}";
                dgvLDLA.DataSource = Filter;
                return;
            }
        }

        private void frmManageLDLA_Load(object sender, EventArgs e)
        {

            cbFilter.SelectedIndex = 0;
            cbStatusFilter.SelectedIndex = 0;
        }


        private void ctsLDLA_Opening(object sender, CancelEventArgs e)
        {
            string Status = Convert.ToString(dgvLDLA.SelectedRows[0].Cells["Status"].Value);
            int TestIndex = Convert.ToInt32(dgvLDLA.SelectedRows[0].Cells["PassedTestCount"].Value);
            if (Status == "Cancelled")
            {
                ctsLDLA.Items["tsmiEdit"].Enabled = false;
                ctsLDLA.Items["tsmiDelete"].Enabled = false;
                ctsLDLA.Items["tsmiCancle"].Enabled = false;
                ctsLDLA.Items["tsmiSchedualTest"].Enabled = false;
                ctsLDLA.Items["tsmiIssueDrivingLicenseFirstTime"].Enabled = false;
                ctsLDLA.Items["tsmiShowDrivingLicense"].Enabled = false;
                return;
            }

            if (Status == "Completed")
            {
                ctsLDLA.Items["tsmiEdit"].Enabled = false;
                ctsLDLA.Items["tsmiDelete"].Enabled = false;
                ctsLDLA.Items["tsmiCancle"].Enabled = false;
                ctsLDLA.Items["tsmiSchedualTest"].Enabled = false;
                ctsLDLA.Items["tsmiIssueDrivingLicenseFirstTime"].Enabled = false;
                ctsLDLA.Items["tsmiShowDrivingLicense"].Enabled = true;
                return;
            }

            if (Status == "New")
            {
                ctsLDLA.Items["tsmiEdit"].Enabled = true;
                ctsLDLA.Items["tsmiDelete"].Enabled = true;
                ctsLDLA.Items["tsmiCancle"].Enabled = true;

                tsmiSchedualTest.DropDownItems["tsmiVisionTest"].Enabled = (TestIndex == 0);
                tsmiSchedualTest.DropDownItems["tsmiWrittenTest"].Enabled = (TestIndex == 1);
                tsmiSchedualTest.DropDownItems["tsmiStreetTest"].Enabled = (TestIndex == 2);
                ctsLDLA.Items["tsmiSchedualTest"].Enabled = TestIndex < 3;

                ctsLDLA.Items["tsmiIssueDrivingLicenseFirstTime"].Enabled = !(ctsLDLA.Items["tsmiSchedualTest"].Enabled);
                ctsLDLA.Items["tsmiShowDrivingLicense"].Enabled = false;
                return;
            }
        }

        private void tsmiShowLDLACard_Click(object sender, EventArgs e)
        {

            int LDLAID = Convert.ToInt32(dgvLDLA.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value);

            frmLDLACard LDLACardForm = new frmLDLACard(LDLAID);
            LDLACardForm.ShowDialog();
        }

        private void tsmiVisionTest_Click(object sender, EventArgs e)
        {
            int LDLAID = Convert.ToInt32(dgvLDLA.SelectedRows[0].Cells[0].Value);
            frmTestAppointment VisionTestForm = new frmTestAppointment(LDLAID, frmTestAppointment.enTestMode.VisionTest);
            VisionTestForm.ShowDialog();
            _RefreshDgv();
        }

        private void tsmiWrittenTest_Click(object sender, EventArgs e)
        {
            int LDLAID = Convert.ToInt32(dgvLDLA.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value);
            frmTestAppointment WrittenTestForm = new frmTestAppointment(LDLAID, frmTestAppointment.enTestMode.WrittenTest);
            WrittenTestForm.ShowDialog();
            _RefreshDgv();
        }

        private void tsmiStreetTest_Click(object sender, EventArgs e)
        {
            int LDLAID = Convert.ToInt32(dgvLDLA.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value);
            frmTestAppointment StreetTestForm = new frmTestAppointment(LDLAID, frmTestAppointment.enTestMode.StreetTest);
            StreetTestForm.ShowDialog();
            _RefreshDgv();
        }

        private void tsmiIssueDrivingLicenseFirstTime_Click(object sender, EventArgs e)
        {
            int LDLAID = Convert.ToInt32(dgvLDLA.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value);
            clsLDLA SelectedLDLA = clsLDLA.Find(LDLAID);

            string SelectedNationalNo = Convert.ToString(dgvLDLA.SelectedRows[0].Cells["NationalNo"].Value);
            clsPerson SelectedPerson = clsPerson.Find(SelectedNationalNo);

            frmIssueDLFirstTime IssueDLFirstTimeForm = new frmIssueDLFirstTime(SelectedLDLA, SelectedPerson);
            IssueDLFirstTimeForm.ShowDialog();
            _RefreshDgv();
        }

        private void tsmiShowDrivingLicense_Click(object sender, EventArgs e)
        {
            int LDLAID = Convert.ToInt32(dgvLDLA.SelectedRows[0].Cells["LocalDrivingLicenseApplicationID"].Value);
            clsLDLA SelectedLDLA = clsLDLA.Find(LDLAID);

            frmLicenseCard LicenseCardForm = new frmLicenseCard(SelectedLDLA.ApplicationID);
            LicenseCardForm.ShowDialog();
        }

        private void tsmiShowPersonLicenseHistory_Click(object sender, EventArgs e)
        {
            string SelectedNationalNo = Convert.ToString(dgvLDLA.SelectedRows[0].Cells["NationalNo"].Value);
            frmLicenseHistory LicenseHistoryForm = new frmLicenseHistory(SelectedNationalNo);
            LicenseHistoryForm.ShowDialog();
        }
    }
}
