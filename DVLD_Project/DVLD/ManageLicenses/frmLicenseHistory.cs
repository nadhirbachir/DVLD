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
    public partial class frmLicenseHistory : Form
    {

        private int SelectedPersonID = -1;

        public void _RefreshDgv(int PersonID)
        {
            dgvLDL.DataSource = clsLicense.PersonLicenseHistory(PersonID);
            dgvIDL.DataSource = clsInternationalLicense.PersonInternationalLicenseHistory(PersonID);
        }

        public frmLicenseHistory(int PersonID)
        {
            InitializeComponent();
            if(clsPerson.isPersonExists(PersonID))
            {
                ctrlPersonInfoFilter1.SelectedPerson(PersonID);
            }
        }

        public frmLicenseHistory(string NationalNo)
        {
            InitializeComponent();
            if (clsPerson.isPersonExists(NationalNo))
            {
                ctrlPersonInfoFilter1.SelectedPerson(NationalNo);
            }
        }

        private void ctrlPersonInfoFilter1_PersonSelected(int obj)
        {
            SelectedPersonID = obj;
            _RefreshDgv(obj);
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedLDL = Convert.ToInt32(dgvLDL.SelectedRows[0].Cells["LicenseID"].Value);
            if(clsLicense.isLicenseExists(SelectedLDL))
            {
                frmLicenseCard LicenseCardForm = new frmLicenseCard(SelectedLDL);
                LicenseCardForm.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showInternationalDrivingLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedLDL = Convert.ToInt32(dgvLDL.SelectedRows[0].Cells["LicenseID"].Value);
            if (clsLicense.isLicenseExists(SelectedLDL))
            {
                frmIDLInfo IDLInfoForm = new frmIDLInfo(SelectedLDL, frmIDLInfo.enSearchOption.LLID);
                IDLInfoForm.ShowDialog();
            }
        }

        private void cmsLDL_Opening(object sender, CancelEventArgs e)
        {
            int SelectedLDL = Convert.ToInt32(dgvLDL.SelectedRows[0].Cells["LicenseID"].Value);

            clsLicense SelectedLicense = clsLicense.Find(SelectedLDL);
            if(SelectedLicense != null)
            {
                if (SelectedLicense.IsActive && SelectedLicense.ExpirationDate < DateTime.Now)
                {
                    renewLicenseToolStripMenuItem.Enabled = true;
                }
                else
                {
                    renewLicenseToolStripMenuItem.Enabled = false;
                }

                if(!SelectedLicense.IsActive || SelectedLicense.ExpirationDate < DateTime.Now)
                {
                    replaceLicenseForLostOrDamagedToolStripMenuItem.Enabled = false;
                }
                else
                {
                    replaceLicenseForLostOrDamagedToolStripMenuItem.Enabled = true;
                }
            }
            
        }

        private void renewLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedLDL = Convert.ToInt32(dgvLDL.SelectedRows[0].Cells["LicenseID"].Value);

            if (clsLicense.isLicenseExists(SelectedLDL))
            {
                frmRenewDrivingLicense RenewLicenseForm = new frmRenewDrivingLicense(SelectedLDL);
                RenewLicenseForm.ShowDialog();
            }
            _RefreshDgv(SelectedPersonID);
        }

        private void replaceLicenseForLostOrDamagedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedLDL = Convert.ToInt32(dgvLDL.SelectedRows[0].Cells["LicenseID"].Value);
            if (clsLicense.isLicenseExists(SelectedLDL))
            {
                frmReplaceLicense ReplaceLicenseForm = new frmReplaceLicense(SelectedLDL);
                ReplaceLicenseForm.ShowDialog();
            }
            
            _RefreshDgv(SelectedPersonID);
        }
    }
}
