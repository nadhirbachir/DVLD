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
    public partial class frmManageInternationalLicenses : Form
    {

        private void _RefreshDgv()
        {
            dgvIL.DataSource = clsInternationalLicense.InternationalLicensesTable();
            lbRecord.Text = dgvIL.RowCount.ToString();
        }

        public frmManageInternationalLicenses()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = Convert.ToInt32(dgvIL.SelectedRows[0].Cells["DriverID"].Value);
            int PersonID = clsDriver.Find(DriverID).PersonID;
            frmPersonCard PersonCardForm = new frmPersonCard(PersonID);
            PersonCardForm.ShowDialog();
        }

        private void showInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ILID = Convert.ToInt32(dgvIL.SelectedRows[0].Cells["InternationalLicenseID"].Value);
            frmIDLInfo ILInfoForm = new frmIDLInfo(ILID, frmIDLInfo.enSearchOption.ILID);
            ILInfoForm.ShowDialog();
        }

        private void shoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = Convert.ToInt32(dgvIL.SelectedRows[0].Cells["DriverID"].Value);
            int PersonID = clsDriver.Find(DriverID).PersonID;
            frmLicenseHistory LicenseHistoryForm = new frmLicenseHistory(PersonID);
            LicenseHistoryForm.ShowDialog();
        }

        private void frmManageInternationalLicenses_Load(object sender, EventArgs e)
        {
            _RefreshDgv();
            cbFilter.SelectedIndex = 0;
        }

        private void btnAddIL_Click(object sender, EventArgs e)
        {
            frmIssueInternationalLicense IssueInternationalLicenseForm = new frmIssueInternationalLicense();
            IssueInternationalLicenseForm.ShowDialog();
            _RefreshDgv();
            cbFilter.SelectedIndex = 0;
        }
    }
}
