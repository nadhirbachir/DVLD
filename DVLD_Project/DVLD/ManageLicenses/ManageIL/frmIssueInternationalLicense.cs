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
    public partial class frmIssueInternationalLicense : Form
    {

        clsLicense SelectedLicense = null;

        clsDriver Driver = null;

        int NewIDLTypeID = 6;

        int TimeToExpireInYear = 1;

        public frmIssueInternationalLicense()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void liDriverHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int SelectedPersonID = clsDriver.Find(SelectedLicense.DriverID).PersonID;
            frmLicenseHistory LicenseHistoryForm = new frmLicenseHistory(SelectedPersonID);
            LicenseHistoryForm.ShowDialog();
        }

        private void FillAppInfo(clsInternationalLicense InterLicense)
        {
            lbFees.Text = clsApplicationType.Find(NewIDLTypeID).ApplicationFees.ToString(); // international license app fees
            if(InterLicense == null)
            {
                lbApplicationDate.Text = DateTime.Now.ToString("d");
                lbIssueDate.Text = DateTime.Today.ToString("d");
                lbExpirationDate.Text = DateTime.Today.AddYears(TimeToExpireInYear).ToString("d");
                lbCreatedBy.Text = clsGlobal.MainUser.UserName;
                lbApplicationID.Text = "[ ??? ]";
                lbIDLID.Text = "[ ??? ]";
                lbLDLID.Text = "[ ??? ]";

            }
            else
            {
                lbApplicationID.Text = InterLicense.ApplicationID.ToString();
                lbApplicationDate.Text = clsApplication.Find(InterLicense.ApplicationID).ApplicationDate.ToString("d");
                lbIssueDate.Text = InterLicense.IssueDate.ToString("d");
                lbExpirationDate.Text = InterLicense.ExpirationDate.ToString("d");
                lbIDLID.Text = InterLicense.InternationalLicenseID.ToString();
                lbLDLID.Text = InterLicense.IssuedUsingLocalLicenseID.ToString();
                lbCreatedBy.Text = clsUser.Find(InterLicense.CreatedByUserID).UserName;
            }
        }

        private bool CheckInputs()
        {
            if (SelectedLicense == null || SelectedLicense.ExpirationDate < DateTime.Today)
            {
                btnIssue.Enabled = false;
                liDriverHistory.Enabled = false;
                liIDL.Enabled = false;
                return false;
            }

            // check if the international license exists or not (if not null means exists)
            clsInternationalLicense tempLicense = clsInternationalLicense.Find(SelectedLicense.LicenseID, clsInternationalLicense.enSearchOption.LLID);
            if(tempLicense != null)
            {
                liIDL.Enabled = true;
                liDriverHistory.Enabled = true;
                // check if there's a I.D.L not expired (deny adding new one) and if expired (allow adding new one)
                return (btnIssue.Enabled = tempLicense.ExpirationDate < DateTime.Today);
            }
            else
            {
                liIDL.Enabled = false;
                btnIssue.Enabled = true;
                liDriverHistory.Enabled = true;
                return true;
            }
            
        }

        private void ctrlLicenseCardFilter1_OnLicenseSelected(int LicenseID)
        {
            SelectedLicense = clsLicense.Find(LicenseID);
            FillAppInfo(clsInternationalLicense.Find(LicenseID, clsInternationalLicense.enSearchOption.LLID));
            if (!CheckInputs())
            {
                return;
            }
            Driver = clsDriver.Find(SelectedLicense.DriverID);
        }


        private clsApplication AddNewApplication()
        {
            clsApplication app = new clsApplication();
            app.ApplicantPersonID = Driver.PersonID;
            app.ApplicationDate = DateTime.Now;
            app.ApplicationTypeID = NewIDLTypeID; // new international driving license type
            app.ApplicationStatus = 1; // new for now and be completed after adding the I.D.L
            app.LastStatusDate = DateTime.Now;
            app.PaidFees = clsApplicationType.Find(NewIDLTypeID).ApplicationFees;
            app.CreatedByUserID = clsGlobal.MainUser.UserID;
            if(app.Save())
            {
                return app;
            }
            else
            {
                return null;
            }
        }

        private bool AddInternationalLicense(clsApplication NewIDLApplication)
        {
            clsInternationalLicense NewIDL = new clsInternationalLicense(NewIDLApplication.ApplicationID);

            NewIDL.DriverID = Driver.DriverID;
            NewIDL.IssuedUsingLocalLicenseID = SelectedLicense.LicenseID;
            NewIDL.IssueDate = DateTime.Now;
            NewIDL.ExpirationDate = DateTime.Now.AddYears(TimeToExpireInYear);
            NewIDL.IsActive = true;
            NewIDL.CreatedByUserID = clsGlobal.MainUser.UserID;

            if(NewIDL.Save())
            {
                NewIDLApplication.ApplicationStatus = 3; // here update it to completed
                if(NewIDLApplication.Save())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void AddApp_IDL()
        {
            clsApplication NewIDLApplication = AddNewApplication();
            if (AddInternationalLicense(NewIDLApplication))
            {
                MessageBox.Show("International License added successfuly", "result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsInternationalLicense addedApplication = clsInternationalLicense.Find(SelectedLicense.LicenseID, clsInternationalLicense.enSearchOption.LLID);
                CheckInputs();
                FillAppInfo(addedApplication);
            }
            else
            {
                MessageBox.Show("International License adding failed", "result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool CheckValidity()
        {
            if (SelectedLicense == null)
            {
                MessageBox.Show("License should be selected", "local license not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (DateTime.Today > SelectedLicense.ExpirationDate)
            {
                MessageBox.Show("the provided license is expired try another", "Expired local license", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            CheckValidity();
            AddApp_IDL();
        }

        private void frmIssueInternationalLicense_Load(object sender, EventArgs e)
        {

        }

        private void liIDL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(SelectedLicense != null)
            {
                frmIDLInfo IDLInfoForm = new frmIDLInfo(SelectedLicense.LicenseID, frmIDLInfo.enSearchOption.LLID);
                IDLInfoForm.ShowDialog();
            }
        }
    }
}
