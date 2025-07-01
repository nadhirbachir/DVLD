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
    public partial class frmManageDetainedLicenses : Form
    {

        private void RefreshDgv()
        {
            dgvDetainedLicenses.DataSource = clsDetainedLicense.DetainedLicensesTable();
            lbRecords.Text = dgvDetainedLicenses.RowCount.ToString();
        }

        public frmManageDetainedLicenses()
        {
            InitializeComponent();
        }

        private void frmManageDetainedLicenses_Load(object sender, EventArgs e)
        {
            RefreshDgv();
            cbFilter.SelectedIndex = 0;
        }

        private void cmsDetainedLicense_Opening(object sender, CancelEventArgs e)
        {
            int DetainID = Convert.ToInt32(dgvDetainedLicenses.SelectedRows[0].Cells["DetainID"].Value);
            if (clsDetainedLicense.isDetainedLicense(DetainID) == -1)
            {
                releaseLicenseToolStripMenuItem.Enabled = false;
            }
            else
            {
                releaseLicenseToolStripMenuItem.Enabled = true;
            }
        }


        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DetainedLicenseID = Convert.ToInt32(dgvDetainedLicenses.SelectedRows[0].Cells["LicenseID"].Value);
            frmReleaseDetainedLicense releaseForm = new frmReleaseDetainedLicense(DetainedLicenseID);
            releaseForm.ShowDialog();
            RefreshDgv();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(dgvDetainedLicenses.SelectedRows[0].Cells["LicenseID"].Value);
            clsLicense SelectedLicense = clsLicense.Find(LicenseID);

            int SelectedPersonID = clsDriver.Find(SelectedLicense.DriverID).PersonID;

            frmPersonCard PersonCardForm = new frmPersonCard(SelectedPersonID);
            PersonCardForm.ShowDialog();

        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int LicenseID = Convert.ToInt32(dgvDetainedLicenses.SelectedRows[0].Cells["LicenseID"].Value);
            frmLicenseCard LicenseCardForm = new frmLicenseCard(LicenseID);
            LicenseCardForm.ShowDialog();
        }

        private void showLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = Convert.ToInt32(dgvDetainedLicenses.SelectedRows[0].Cells["LicenseID"].Value);
            clsLicense SelectedLicense = clsLicense.Find(LicenseID);

            int SelectedPersonID = clsDriver.Find(SelectedLicense.DriverID).PersonID;

            frmLicenseHistory LicenseHistoryForm = new frmLicenseHistory(SelectedPersonID);
            LicenseHistoryForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense DetainLicenseForm = new frmDetainLicense();
            DetainLicenseForm.ShowDialog();
            RefreshDgv();
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense ReleaseDetainedLicenseForm = new frmReleaseDetainedLicense();
            ReleaseDetainedLicenseForm.ShowDialog();
            RefreshDgv();
        }
    }
}
