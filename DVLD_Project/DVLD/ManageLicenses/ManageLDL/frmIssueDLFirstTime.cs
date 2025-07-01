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
    public partial class frmIssueDLFirstTime : Form
    {

        clsLDLA _LDLA = null;

        clsPerson _Person = null;



        public frmIssueDLFirstTime(clsLDLA LDLA, clsPerson Person)
        {
            InitializeComponent();
            if(clsPerson.Find(Person.PersonID) == null)
            {
                MessageBox.Show("the provided person not found", "person Not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if(clsLDLA.Find(LDLA.LDLAID) == null)
            {
                MessageBox.Show("the provided local driving license application not found", "LDLA Not valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _LDLA = LDLA;
            _Person = Person;
            ctrlLDLAInfo1.LoadLDLAInfo(_LDLA.LDLAID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int AddNewDriver()
        {
            clsDriver NewDriver = new clsDriver(_Person.PersonID);
            NewDriver.CreatedByUserID = clsGlobal.MainUser.UserID;
            NewDriver.CreatedDate = DateTime.Now;
            if (NewDriver.Save())
            {
                return NewDriver.DriverID;
            }
            return -1;
        }

        private int AddNewLicense(int NewDriverID,clsLicenseClass SelectedLicenseClass)
        {
            clsLicense NewLicense = new clsLicense(_LDLA.ApplicationID);
            NewLicense.DriverID = NewDriverID;
            NewLicense.LicenseClassID = _LDLA.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(SelectedLicenseClass.DefaultValidityLength);
            NewLicense.Notes = tbNotes.Text;
            NewLicense.PaidFees = SelectedLicenseClass.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = 1; // Issue first time
            NewLicense.CreatedByUserID = clsGlobal.MainUser.UserID;
            if(NewLicense.Save())
            {
                return NewLicense.LicenseID;
            }
            return -1;
        }

        private void UpdateApplicationStatus()
        {
            clsApplication app = clsApplication.Find(_LDLA.ApplicationID);
            app.ApplicationStatus = 3;
            app.Save();
        }

        private void AddNewDriverNewLicense(clsLicenseClass SelectedLicenseClass)
        {
            int NewDriverID = AddNewDriver();

            // check if the driver adding failed
            if (NewDriverID == -1)
            {
                MessageBox.Show("Adding new driving license failed", "issue result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if the person have already another same license with the same class type
            if (clsLicense.isLicenseExists(NewDriverID, _LDLA.LicenseClassID))
            {
                MessageBox.Show("the person have already the same type of this license", "issue result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if adding license failed
            if (AddNewLicense(NewDriverID, SelectedLicenseClass) == -1)
            {
                MessageBox.Show("adding license failed", "issue result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Driving license issued succeed", "issue result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateApplicationStatus();
            this.Close();
            return;
        }

        private void AddToOldDriverNewLicense(int OldDriverID, clsLicenseClass SelectedLicenseClass)
        {
            // check if the person have already another same license with the same class type
            if (clsLicense.isLicenseExists(OldDriverID, _LDLA.LicenseClassID))
            {
                MessageBox.Show("the person have already the same type of this license", "issue result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if adding license failed
            if (AddNewLicense(OldDriverID, SelectedLicenseClass) == -1)
            {
                MessageBox.Show("adding license failed", "issue result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Driving license issued succeed", "issue result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateApplicationStatus();
            this.Close();
            return;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            clsLicenseClass SelectedLicenseClass = clsLicenseClass.Find(_LDLA.LicenseClassID);
            if ((DateTime.Now.Year - _Person.DateOfBirth.Year) < SelectedLicenseClass.MinAge)
            {
                MessageBox.Show("Your age is under the min age to get this License", "Age invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // check driver existance
            if (!clsDriver.isDriverExists(_Person.PersonID)) 
            {
                AddNewDriverNewLicense(SelectedLicenseClass);
            }
            else
            {
                int OldDriverID = clsDriver.Find(_Person.PersonID).DriverID;
                AddToOldDriverNewLicense(OldDriverID, SelectedLicenseClass);
            }
        }
    }
}
