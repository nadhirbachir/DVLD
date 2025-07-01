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
    public partial class frmReplaceLicense : Form
    {

        clsLicense SelectedLicense = null;
        int ReplaceLicenseID = -1;

        short ReplaceForLostID = 3;
        short ReplaceForDamagedID = 4;

        short ApplicationTypeID = -1;

        private void RefreshReplace()
        {
            if(rbLost.Checked)
            {
                lbApplicationFees.Text = clsApplicationType.Find(ReplaceForLostID).ApplicationFees.ToString();
                ApplicationTypeID = ReplaceForLostID;
                return;
            }

            if(rbDamaged.Checked)
            {
                lbApplicationFees.Text = clsApplicationType.Find(ReplaceForDamagedID).ApplicationFees.ToString();
                ApplicationTypeID = ReplaceForDamagedID;
                return;
            }
            
        }

        public frmReplaceLicense(int LicenseID = -1)
        {
            InitializeComponent();
            if(LicenseID != -1)
            {
                ctrlLicenseCardFilter1.SelectedLicense(LicenseID);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayNotActiveLicense()
        {
            btnReplace.Enabled = false;
            liShowLicensesHistory.Enabled = true;
            gbReplaceChoice.Enabled = false;
            liNewLicenseInfo.Enabled = false;

            lbLRAID.Text = "[ ??? ]";
            lbApplicationDate.Text = "[ ??? ]";
            lbApplicationFees.Text = "0";
            lbReplacedLicenseID.Text = "[ ??? ]";
            lbOldLicenseID.Text = "[ ??? ]";
            lbCreatedBy.Text = "[ ??? ]";

            MessageBox.Show("Selected License is not active, the license should be active to replace",
                "Not active license", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void DisplayExpiredLicense()
        {
            btnReplace.Enabled = false;
            liShowLicensesHistory.Enabled = true;
            gbReplaceChoice.Enabled = false;
            liNewLicenseInfo.Enabled = false;

            lbLRAID.Text = "[ ??? ]";
            lbApplicationDate.Text = "[ ??? ]";
            lbApplicationFees.Text = "0";
            lbReplacedLicenseID.Text = "[ ??? ]";
            lbOldLicenseID.Text = "[ ??? ]";
            lbCreatedBy.Text = "[ ??? ]";

            MessageBox.Show("Selected License is Expired, it needs to be renewed not replaced",
                "expired license", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisplayReplaceLicense()
        {
            btnReplace.Enabled = true;
            liShowLicensesHistory.Enabled = true;
            gbReplaceChoice.Enabled = true;
            liNewLicenseInfo.Enabled = false;

            lbLRAID.Text = "[ ??? ]";
            lbApplicationDate.Text = DateTime.Now.ToString("d");
            RefreshReplace();
            lbReplacedLicenseID.Text = "[ ??? ]";
            lbOldLicenseID.Text = SelectedLicense.LicenseID.ToString();
            lbCreatedBy.Text = clsGlobal.MainUser.UserName;
        }

        private void DisplayReplaceLicenseInfo(int ReplaceAppID, int ReplaceLicenseID)
        {
            btnReplace.Enabled = false;
            liShowLicensesHistory.Enabled = true;
            gbReplaceChoice.Enabled = false;
            liNewLicenseInfo.Enabled = true;

            lbLRAID.Text = ReplaceAppID.ToString();
            lbApplicationDate.Text = DateTime.Now.ToString("d");
            RefreshReplace();
            lbReplacedLicenseID.Text = ReplaceLicenseID.ToString();
            lbOldLicenseID.Text = SelectedLicense.LicenseID.ToString();
            lbCreatedBy.Text = clsGlobal.MainUser.UserName;


        }

        private void DisplayEmptyData()
        {
            btnReplace.Enabled = false;
            liShowLicensesHistory.Enabled = false;
            gbReplaceChoice.Enabled = false;
            liNewLicenseInfo.Enabled = false;

            lbLRAID.Text = "[ ??? ]";
            lbApplicationDate.Text = "[ ??? ]";
            lbApplicationFees.Text = "0";
            lbReplacedLicenseID.Text = "[ ??? ]";
            lbOldLicenseID.Text = "[ ??? ]";
            lbCreatedBy.Text = "[ ??? ]";

        }

        private void DisplaySelectedChoice()
        {
            if(SelectedLicense != null)
            {

                if(!SelectedLicense.IsActive)
                {
                    DisplayNotActiveLicense();
                    return;
                }

                if(SelectedLicense.ExpirationDate < DateTime.Now)
                {
                    DisplayExpiredLicense();
                    return;
                }

                DisplayReplaceLicense();

            }
            else
            {
                DisplayEmptyData();
                return;
            }
        }

        private void ctrlLicenseCardFilter1_OnLicenseSelected(int LicenseID)
        {
            SelectedLicense = clsLicense.Find(LicenseID);
            DisplaySelectedChoice();
        }

        private void liShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(SelectedLicense != null)
            {
                frmLicenseHistory LicenseHistoryForm = new frmLicenseHistory(clsDriver.Find(SelectedLicense.DriverID).PersonID);
                LicenseHistoryForm.ShowDialog();
            }
        }

        private void frmReplaceLicense_Load(object sender, EventArgs e)
        {

        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            RefreshReplace();
        }

        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            RefreshReplace();
        }

        private bool DisableOldLicense()
        {
            SelectedLicense.IsActive = false;
            if (SelectedLicense.Save())
            {
                return true;
            }
            return false;
        }

        private clsApplication ReplaceApplication()
        {
            clsApplication RenewApplication = new clsApplication();
            RenewApplication.ApplicationStatus = 1; // new for now completed for later
            RenewApplication.ApplicationDate = DateTime.Now;
            RenewApplication.ApplicantPersonID = clsDriver.Find(SelectedLicense.DriverID).PersonID;
            RenewApplication.ApplicationTypeID = ApplicationTypeID;
            RenewApplication.LastStatusDate = DateTime.Now;
            RenewApplication.PaidFees = Convert.ToSingle(lbApplicationFees.Text);
            RenewApplication.CreatedByUserID = clsGlobal.MainUser.UserID;
            if (RenewApplication.Save())
            {
                return RenewApplication;
            }

            MessageBox.Show("Creating replace application failed", "Replace application failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        private clsLicense ReplaceLicense(clsApplication ReplaceApplication)
        {
            if (ReplaceApplication == null)
            {
                return null;
            }

            clsLicense ReplaceLicense = new clsLicense(ReplaceApplication.ApplicationID);
            ReplaceLicense.DriverID = SelectedLicense.DriverID;
            ReplaceLicense.LicenseClassID = SelectedLicense.LicenseClassID;
            ReplaceLicense.IssueDate = DateTime.Now;
            ReplaceLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.Find(SelectedLicense.LicenseClassID).DefaultValidityLength);
            ReplaceLicense.Notes = SelectedLicense.Notes;
            ReplaceLicense.PaidFees = Convert.ToSingle(lbApplicationFees.Text);
            ReplaceLicense.IsActive = true;
            ReplaceLicense.IssueReason = ApplicationTypeID; // renew
            ReplaceLicense.CreatedByUserID = clsGlobal.MainUser.UserID;

            ReplaceApplication.ApplicationStatus = 3; // completed app

            if (ReplaceApplication.Save())
            {

                if (ReplaceLicense.Save())
                {
                    ReplaceLicenseID = ReplaceLicense.LicenseID;
                    return ReplaceLicense;
                }
                else
                {
                    MessageBox.Show("Failed saving the Replaced license", "Unsaved new license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }


            }
            else
            {
                MessageBox.Show("Failed complete Replace application", "Incomplete application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if(SelectedLicense == null || ApplicationTypeID == -1)
            {
                return;
            }

            if(MessageBox.Show("Are you sure do you want to replace this license?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if(!DisableOldLicense())
            {
                MessageBox.Show("Disabling old license failed", "old license not disabled", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsApplication ReplaceLicenseApplication = ReplaceApplication();
            if (ReplaceLicenseApplication == null)
            {
                return;
            }

            clsLicense ReplacedLicense = ReplaceLicense(ReplaceLicenseApplication);
            if (ReplacedLicense == null)
            {
                return;
            }

            MessageBox.Show("License was renewed successfuly", "Renew license result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayReplaceLicenseInfo(ReplaceLicenseApplication.ApplicationID, ReplacedLicense.LicenseID);


        }

        private void liNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(ReplaceLicenseID != -1)
            {
                frmLicenseCard ReplaceLicenseCard = new frmLicenseCard(ReplaceLicenseID);
                ReplaceLicenseCard.ShowDialog();
            }
        }
    }
}
