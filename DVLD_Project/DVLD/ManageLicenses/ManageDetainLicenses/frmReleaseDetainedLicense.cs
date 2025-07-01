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
    public partial class frmReleaseDetainedLicense : Form
    {

        clsLicense SelectedLicense = null;

        private static int AppTypeID = 5; // release detained driving license application type
        float AppTypeFees = clsApplicationType.Find(AppTypeID).ApplicationFees;


        private void SelectLicense(int DetainedLicenseID)
        {
            if (DetainedLicenseID != -1)
            {
                ctrlLicenseCardFilter1.SelectedLicense(DetainedLicenseID);
            }
        }

        public frmReleaseDetainedLicense(int DetainedLicenseID = -1)
        {
            InitializeComponent();
            SelectLicense(DetainedLicenseID);
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void liShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(SelectedLicense != null)
            {
                frmLicenseHistory LicenseHistoryForm = new frmLicenseHistory(clsDriver.Find(SelectedLicense.DriverID).PersonID);
                LicenseHistoryForm.ShowDialog();
            }
        }

        private void liReleasedLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(SelectedLicense == null)
            {
                MessageBox.Show("License should be selected and not detained at first", "License not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(clsDetainedLicense.isDetainedLicense(SelectedLicense.LicenseID) != -1)
            {
                MessageBox.Show("License should Released, but the selected license is still detained", "License is detained", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmLicenseCard LicenseCardForm = new frmLicenseCard(SelectedLicense.LicenseID);
            LicenseCardForm.ShowDialog();
            
        }

        private void DisplayEmptyData()
        {
            liShowLicensesHistory.Enabled = false;
            liReleasedLicenseInfo.Enabled = false;
            btnRelease.Enabled = false;
            gbDetainInfo.Enabled = false;
            lbDetainID.Text = "[ ??? ]";
            lbDetainDate.Text = "[ ??? ]";
            lbLicenseID.Text = "[ ??? ]";
            lbCreatedBy.Text = "[ ??? ]";
            lbFineFees.Text = "0";
            lbApplicationFees.Text = AppTypeFees.ToString();
            lbTotalFees.Text = (Convert.ToSingle(lbFineFees.Text) + Convert.ToSingle(lbApplicationFees.Text)).ToString();
        }

        private void DisplayInActiveLicense()
        {
            DisplayEmptyData();
            liShowLicensesHistory.Enabled = true;

        }

        private void DisplayNotDetainedLicense()
        {
            DisplayEmptyData();
            liShowLicensesHistory.Enabled = true;
            liReleasedLicenseInfo.Enabled = true;
        }

        private void DisplayReleaseLicense()
        {
            int DetainedLicenseID = clsDetainedLicense.isDetainedLicense(SelectedLicense.LicenseID);
            clsDetainedLicense DetainedLicense = clsDetainedLicense.Find(DetainedLicenseID);
            if(DetainedLicense == null)
            {
                MessageBox.Show("Error finding detained license", "detained license not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisplayEmptyData();
                return;
            }

            liShowLicensesHistory.Enabled = true;
            liReleasedLicenseInfo.Enabled = false;
            btnRelease.Enabled = true;
            gbDetainInfo.Enabled = true;
            lbDetainID.Text = DetainedLicense.DetainID.ToString();
            lbDetainDate.Text = DetainedLicense.DetainDate.ToString("d");
            lbLicenseID.Text = SelectedLicense.LicenseID.ToString();
            lbCreatedBy.Text = clsUser.Find(DetainedLicense.CreatedByUserID).UserName;
            lbFineFees.Text = DetainedLicense.FineFees.ToString();
            lbApplicationFees.Text = AppTypeFees.ToString();
            lbTotalFees.Text = (Convert.ToSingle(lbFineFees.Text) + Convert.ToSingle(lbApplicationFees.Text)).ToString();
        }

        private void SetLabels()
        {
            if(SelectedLicense == null)
            {
                DisplayEmptyData();
                return;
            }

            if(!SelectedLicense.IsActive)
            {
                MessageBox.Show("Selected license is not active, it should be renewed and can't be released", "Inactive license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisplayInActiveLicense();
                return;
            }

            if(clsDetainedLicense.isDetainedLicense(SelectedLicense.LicenseID) == -1)
            {
                MessageBox.Show("Selected license is not Detained, you can't release it", "Not detained license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DisplayNotDetainedLicense();
                return;
            }

            DisplayReleaseLicense();

        }

        private void ctrlLicenseCardFilter1_OnLicenseSelected(int SelectedLicenseID)
        {
            DisplayEmptyData(); 
            SelectedLicense = clsLicense.Find(SelectedLicenseID);
            SetLabels();
        }

        clsApplication SetReleaseLicenseApplication()
        {
            clsApplication ReleaseLicenseApplication = new clsApplication();
            ReleaseLicenseApplication.ApplicantPersonID = clsDriver.Find(SelectedLicense.DriverID).PersonID;
            ReleaseLicenseApplication.ApplicationDate = DateTime.Now;
            ReleaseLicenseApplication.ApplicationTypeID = AppTypeID;
            ReleaseLicenseApplication.ApplicationStatus = 1; // new for now completed for later
            ReleaseLicenseApplication.LastStatusDate = DateTime.Now;
            ReleaseLicenseApplication.PaidFees = Convert.ToSingle(lbTotalFees.Text);
            ReleaseLicenseApplication.CreatedByUserID = clsGlobal.MainUser.UserID;
            
            if(ReleaseLicenseApplication.Save())
            {
                return ReleaseLicenseApplication;
            }
            return null;
        }

        bool ReleaseLicense(clsApplication ReleaseApplication)
        {

            int DetainedLicenseID = clsDetainedLicense.isDetainedLicense(SelectedLicense.LicenseID);
            clsDetainedLicense DetainedLicense = clsDetainedLicense.Find(DetainedLicenseID);

            if (!DetainedLicense.ReleaseLicense(DateTime.Now, clsGlobal.MainUser.UserID, ReleaseApplication.ApplicationID))
            {
                MessageBox.Show("Detained license did not get updated successfuly", "Error updating detained license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            ReleaseApplication.ApplicationStatus = 3; // complete the release application

            if(!ReleaseApplication.Save())
            {
                MessageBox.Show("Release application did not completed", "Error completing release application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            MessageBox.Show("License was released succesfully", "finished releasing license", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }


        private void btnRelease_Click(object sender, EventArgs e)
        {

            clsApplication ReleaseApplication = SetReleaseLicenseApplication();

            if (ReleaseApplication == null)
            {
                MessageBox.Show("Release application did not set correctly", "Error setting release application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ReleaseLicense(ReleaseApplication))
            {
                return;
            }

            btnRelease.Enabled = false;
            lbAppID.Text = ReleaseApplication.ApplicationID.ToString();
            liShowLicensesHistory.Enabled = true;
            liReleasedLicenseInfo.Enabled = true;
            gbDetainInfo.Enabled = true;

        }
    }
}
