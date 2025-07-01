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
    public partial class frmRenewDrivingLicense : Form
    {

        private short RenewLicenseApplicationID = 2;

        private clsLicense SelectedLicense = null;

        private int NewLicenseID = -1;

        

        public frmRenewDrivingLicense(int LicenseID = -1)
        {
            InitializeComponent();
            if(clsLicense.isLicenseExists(LicenseID))
            {
                ctrlLicenseCardFilter1.SelectedLicense(LicenseID);
                SelectedLicense = clsLicense.Find(LicenseID);
            }
        }


        private void DisplayNewLicenseInfo(int RLAppID, int RLicenseID)
        {
            clsLicenseClass SelectedLicenseClass = clsLicenseClass.Find(SelectedLicense.LicenseClassID);
            lbRLAID.Text = RLAppID.ToString();
            lbApplicationDate.Text = DateTime.Now.ToString("d");
            lbIssueDate.Text = DateTime.Now.ToString("d");
            lbApplicationFees.Text = clsApplicationType.Find(RenewLicenseApplicationID).ApplicationFees.ToString();
            lbLicenseFees.Text = SelectedLicenseClass.ClassFees.ToString();
            lbRenewedLicenseID.Text = RLicenseID.ToString();
            lbOldLicenseID.Text = SelectedLicense.LicenseID.ToString();
            lbExpirationDate.Text = DateTime.Now.AddYears(SelectedLicenseClass.DefaultValidityLength).ToString("d");
            lbTotalFees.Text = (Convert.ToSingle(lbApplicationFees.Text) + Convert.ToSingle(lbLicenseFees.Text)).ToString();
            lbCreatedBy.Text = clsUser.Find(SelectedLicense.CreatedByUserID).UserName;
            liShowDrivingLicenseInfo.Enabled = true;
            liShowNewLicenseInfo.Enabled = true;
            btnRenew.Enabled = false;
            tbNotes.Enabled = false;
        }

        private void DisplayEmptyData()
        {
            lbRLAID.Text = "[ ??? ]";
            lbApplicationDate.Text = "[ ??? ]";
            lbIssueDate.Text = "[ ??? ]";
            lbLicenseFees.Text = "0";
            lbApplicationFees.Text = clsApplicationType.Find(RenewLicenseApplicationID).ApplicationFees.ToString();
            tbNotes.Text = "";
            lbRenewedLicenseID.Text = "[ ??? ]";
            lbOldLicenseID.Text = "[ ??? ]";
            lbExpirationDate.Text = "[ ??? ]";
            lbCreatedBy.Text = "[ ??? ]";
            lbApplicationFees.Text = clsApplicationType.Find(RenewLicenseApplicationID).ApplicationFees.ToString();
            lbTotalFees.Text = (Convert.ToSingle(lbApplicationFees.Text) + Convert.ToSingle(lbLicenseFees.Text)).ToString();
            btnRenew.Enabled = false;
            liShowNewLicenseInfo.Enabled = false;
            liShowDrivingLicenseInfo.Enabled = false;
        }

        private void DisplayNotExpiredLicense()
        {
            lbRLAID.Text = "[ ??? ]";
            lbApplicationDate.Text = "[ ??? ]";
            lbIssueDate.Text = "[ ??? ]";
            lbLicenseFees.Text = clsLicenseClass.Find(SelectedLicense.LicenseClassID).ClassFees.ToString();
            lbApplicationFees.Text = clsApplicationType.Find(RenewLicenseApplicationID).ApplicationFees.ToString();
            tbNotes.Text = "";
            lbRenewedLicenseID.Text = "[ ??? ]";
            lbOldLicenseID.Text = SelectedLicense.LicenseID.ToString();
            lbExpirationDate.Text = "[ ??? ]";
            lbTotalFees.Text = (Convert.ToSingle(lbApplicationFees.Text) + Convert.ToSingle(lbLicenseFees.Text)).ToString();
            lbCreatedBy.Text = clsUser.Find(SelectedLicense.CreatedByUserID).UserName;
            liShowDrivingLicenseInfo.Enabled = true;
            liShowNewLicenseInfo.Enabled = false;
            btnRenew.Enabled = false;
            tbNotes.Enabled = false;

            MessageBox.Show($"the selected should be expired, selected license expiration date is {SelectedLicense.ExpirationDate.ToString("d")}",
                "Selected license not expired", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisplayNotActiveLicense()
        {
            lbRLAID.Text = "[ ??? ]";
            lbApplicationDate.Text = "[ ??? ]";
            lbIssueDate.Text = "[ ??? ]";
            lbApplicationFees.Text = clsApplicationType.Find(RenewLicenseApplicationID).ApplicationFees.ToString();
            lbLicenseFees.Text = clsLicenseClass.Find(SelectedLicense.LicenseClassID).ClassFees.ToString();
            tbNotes.Text = "";
            lbRenewedLicenseID.Text = "[ ??? ]";
            lbOldLicenseID.Text = SelectedLicense.LicenseID.ToString();
            lbExpirationDate.Text = "[ ??? ]";
            lbTotalFees.Text = (Convert.ToSingle(lbApplicationFees.Text) + Convert.ToSingle(lbLicenseFees.Text)).ToString();
            lbCreatedBy.Text = clsUser.Find(SelectedLicense.CreatedByUserID).UserName;
            liShowDrivingLicenseInfo.Enabled = true;
            liShowNewLicenseInfo.Enabled = false;
            btnRenew.Enabled = false;
            tbNotes.Enabled = false;

            MessageBox.Show($"the selected should be Active, selected license is not active so it may have been renewed",
                "Selected license Disabled", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisplayRenewLicense()
        {
            clsLicenseClass SelectedLicenseClass = clsLicenseClass.Find(SelectedLicense.LicenseClassID);
            lbRLAID.Text = "[ ??? ]";
            lbApplicationDate.Text = DateTime.Now.ToString("d");
            lbIssueDate.Text = DateTime.Now.ToString("d");
            lbApplicationFees.Text = clsApplicationType.Find(RenewLicenseApplicationID).ApplicationFees.ToString();
            lbLicenseFees.Text = SelectedLicenseClass.ClassFees.ToString();
            tbNotes.Text = "";
            lbRenewedLicenseID.Text = "[ ??? ]";
            lbOldLicenseID.Text = SelectedLicense.LicenseID.ToString();
            lbExpirationDate.Text = DateTime.Now.AddYears(SelectedLicenseClass.DefaultValidityLength).ToString("d");
            lbTotalFees.Text = (Convert.ToSingle(lbApplicationFees.Text) + Convert.ToSingle(lbLicenseFees.Text)).ToString();
            lbCreatedBy.Text = clsUser.Find(SelectedLicense.CreatedByUserID).UserName;
            liShowDrivingLicenseInfo.Enabled = true;
            liShowNewLicenseInfo.Enabled = false;
            btnRenew.Enabled = true;
            tbNotes.Enabled = true;
        }

        private void DisplaySelectedLicenseInfo(clsLicense SelectedLicense)
        {
            if (SelectedLicense != null)
            {
                if (SelectedLicense.ExpirationDate > DateTime.Now)
                {
                    DisplayNotExpiredLicense();
                }
                else if (!SelectedLicense.IsActive)
                {
                    DisplayNotActiveLicense();
                }
                else
                {
                    DisplayRenewLicense();
                }
            }
            else
            {
                DisplayEmptyData();
            }
        }

        private void ctrlLicenseCardFilter1_OnLicenseSelected(int LicenseID)
        {
            SelectedLicense = clsLicense.Find(LicenseID);
            DisplaySelectedLicenseInfo(SelectedLicense);
        }

        private void liShowDrivingLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(SelectedLicense != null)
            {
                frmLicenseCard LicenseCardForm = new frmLicenseCard(SelectedLicense.LicenseID);
                LicenseCardForm.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRenewDrivingLicense_Load(object sender, EventArgs e)
        {
            if(SelectedLicense == null)
            {
                DisplayEmptyData();
            }
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

        private clsApplication RenewApplication()
        {
            clsApplication RenewApplication = new clsApplication();
            RenewApplication.ApplicationStatus = 1; // new for now completed for later
            RenewApplication.ApplicationDate = DateTime.Now;
            RenewApplication.ApplicantPersonID = clsDriver.Find(SelectedLicense.DriverID).PersonID;
            RenewApplication.ApplicationTypeID = RenewLicenseApplicationID;
            RenewApplication.LastStatusDate = DateTime.Now;
            RenewApplication.PaidFees = Convert.ToSingle(lbTotalFees.Text);
            RenewApplication.CreatedByUserID = clsGlobal.MainUser.UserID;
            if(RenewApplication.Save())
            {
                return RenewApplication;
            }

            MessageBox.Show("Creating renew application failed", "Renew application failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

        private clsLicense RenewLicense(clsApplication RenewApplication)
        {
            if(RenewApplication == null)
            {
                return null;
            }

            clsLicense RenewLicense = new clsLicense(RenewApplication.ApplicationID);
            RenewLicense.DriverID = SelectedLicense.DriverID;
            RenewLicense.LicenseClassID = SelectedLicense.LicenseClassID;
            RenewLicense.IssueDate = DateTime.Now;
            RenewLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClass.Find(SelectedLicense.LicenseClassID).DefaultValidityLength);
            RenewLicense.Notes = tbNotes.Text;
            RenewLicense.PaidFees = Convert.ToSingle(lbTotalFees.Text);
            RenewLicense.IsActive = true;
            RenewLicense.IssueReason = 2; // renew
            RenewLicense.CreatedByUserID = clsGlobal.MainUser.UserID;

            RenewApplication.ApplicationStatus = 3; // completed app

            if (RenewApplication.Save())
            {

                if(RenewLicense.Save())
                {
                    NewLicenseID = RenewLicense.LicenseID;
                    return RenewLicense;
                }
                else
                {
                    MessageBox.Show("Failed saving the Renewed license", "Unsaved new license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }


            }
            else
            {
                MessageBox.Show("Failed complete renew application", "Incomplete application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }


        private void btnRenew_Click(object sender, EventArgs e)
        {
            if(SelectedLicense == null || !SelectedLicense.IsActive || SelectedLicense.ExpirationDate > DateTime.Now)
            {
                return;
            }
            
            if(!DisableOldLicense())
            {
                MessageBox.Show("Failed disabling old license", "Disable old license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsApplication RenewLicenseApplication = RenewApplication();
            if(RenewLicenseApplication == null)
            {
                return;
            }

            clsLicense RenewedLicense = RenewLicense(RenewLicenseApplication);
            if (RenewedLicense == null)
            {
                return;
            }

            MessageBox.Show("License was renewed successfuly", "Renew license result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayNewLicenseInfo(RenewLicenseApplication.ApplicationID, RenewedLicense.LicenseID);


        }

        private void liShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (NewLicenseID != -1)
            {
                frmLicenseCard LicenseCardForm = new frmLicenseCard(NewLicenseID);
                LicenseCardForm.ShowDialog();
            }
        }
    }
}
