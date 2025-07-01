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
    public partial class frmDetainLicense : Form
    {

        clsLicense SelectedLicense = null;

        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void tbFineFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if(e.KeyChar == '.' && tbFineFees.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayLicenseIsDetained(clsDetainedLicense DetainedLicense)
        {
            liShowLicensesHistory.Enabled = true;
            liDetainedLicenseInfo.Enabled = true;
            btnDetain.Enabled = false;
            gbDetainInfo.Enabled = false;
            lbDetainID.Text = DetainedLicense.DetainID.ToString();
            lbDetainDate.Text = DetainedLicense.DetainDate.ToString("d");
            lbLicenseID.Text = DetainedLicense.LicenseID.ToString();
            lbCreatedBy.Text = clsUser.Find(DetainedLicense.CreatedByUserID).UserName;
            tbFineFees.Text = DetainedLicense.FineFees.ToString();

            MessageBox.Show("This license is already detained and didn't have been released yet",
                "License is detained", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisplayEmptyData()
        {
            liShowLicensesHistory.Enabled = false;
            liDetainedLicenseInfo.Enabled = false;
            btnDetain.Enabled = false;
            gbDetainInfo.Enabled = false;
            lbDetainID.Text = "[ ??? ]";
            lbDetainDate.Text = "[ ??? ]";
            lbLicenseID.Text = "[ ??? ]";
            lbCreatedBy.Text = "[ ??? ]";
            tbFineFees.Text = "";

        }

        private void DisplayDisabledLicense()
        {
            DisplayEmptyData();
            liShowLicensesHistory.Enabled = true;
            MessageBox.Show("Selected License is not active, the license should be active and in use to be detained", "disabled license", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void DisplayLicenseIsDetained(int DetainID)
        {
            DisplayActiveNotDetainedLicense();

            liDetainedLicenseInfo.Enabled = true;
            btnDetain.Enabled = false;
            gbDetainInfo.Enabled = false;
            lbDetainID.Text = DetainID.ToString();
        }

        private void DisplayActiveNotDetainedLicense()
        {
            liShowLicensesHistory.Enabled = true;
            liDetainedLicenseInfo.Enabled = false;
            btnDetain.Enabled = true;
            gbDetainInfo.Enabled = true;

            lbDetainID.Text = "[ ??? ]";
            lbDetainDate.Text = DateTime.Now.ToString("d");
            lbLicenseID.Text = SelectedLicense.LicenseID.ToString();
            lbCreatedBy.Text = clsGlobal.MainUser.UserName;
        }

        private void ctrlLicenseCardFilter1_OnLicenseSelected(int LicenseID)
        {
            DisplayEmptyData();

            SelectedLicense = clsLicense.Find(LicenseID);

            if(SelectedLicense == null)
            {
                DisplayEmptyData();
                return;
            }

            if(SelectedLicense.IsActive == false)
            {
                DisplayDisabledLicense();
                return;
            }

            if(clsDetainedLicense.isDetainedLicense(LicenseID) != -1)
            {
                DisplayLicenseIsDetained(clsDetainedLicense.Find(LicenseID));
                return;
            }

            DisplayActiveNotDetainedLicense();
        }

        private void liShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(SelectedLicense != null)
            {
                frmLicenseHistory LicensesHistoryForm = new frmLicenseHistory(clsDriver.Find(SelectedLicense.DriverID).PersonID);
                LicensesHistoryForm.ShowDialog();
            }
        }

        private void liDetainedLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (SelectedLicense != null)
            {
                frmLicenseCard LicenseCardForm = new frmLicenseCard(SelectedLicense.LicenseID);
                LicenseCardForm.ShowDialog();
            }
        }


        private int DetainSelectedLicense()
        {
            if(SelectedLicense == null || clsDetainedLicense.isDetainedLicense(SelectedLicense.LicenseID) != -1)
            {
                MessageBox.Show("You should select non detained license first to detain it", "non detained license selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            if(string.IsNullOrEmpty(tbFineFees.Text) || Convert.ToSingle(tbFineFees.Text) < 1)
            {
                MessageBox.Show("Fine fees should be bigger than 0", "invalid fine fees", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            //LicenseID, DetainDate, FineFees, CreatedByUserID)
            clsDetainedLicense DetainLicense = new clsDetainedLicense(SelectedLicense.LicenseID);
            DetainLicense.DetainDate = DateTime.Now;
            DetainLicense.FineFees = Convert.ToSingle(tbFineFees.Text);
            DetainLicense.CreatedByUserID = clsGlobal.MainUser.UserID;
            if(DetainLicense.Save())
            {
                return DetainLicense.DetainID;
            }
            else
            {
                return -1;
            }

        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            int DetainID = DetainSelectedLicense();
            if (DetainID == -1)
            {
                MessageBox.Show("License Detaining failed", "License is NOT detained", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("License Detained successfuly", "License is detained", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayLicenseIsDetained(DetainID);
        }

        private void tbFineFees_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbFineFees.Text) || Convert.ToSingle(tbFineFees.Text) < 1)
            {
                errorProvider1.SetError(tbFineFees, "the value should be more or equal to 1$");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
