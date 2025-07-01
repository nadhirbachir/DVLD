using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD
{
    public partial class ctrlLicenseCard : UserControl
    {
        
        public event Action<clsLicense> WhenLicenseFound;

        private void _LicenseFound(clsLicense license)
        {
            if(license != null)
            {
                WhenLicenseFound?.Invoke(license);
            }
            else
            {
                WhenLicenseFound?.Invoke(null);
            }
        }

        public ctrlLicenseCard()
        {
            InitializeComponent();
        }
        
        private void EmptyData()
        {
            // empty license info
            lbClassName.Text = "[ ??? ]";
            lbLicenseID.Text = "[ ??? ]";
            lbIssueDate.Text = "[ ??? ]";
            lbExpirationDate.Text = "[ ??? ]";
            lbIssueReason.Text = "[ ??? ]";
            lbIsDetained.Text = "[ ??? ]";
            lbIsActive.Text = "[ ??? ]";
            lbNotes.Text = "[ ??? ]";

            // empty person info
            lbPersonFullName.Text = "[ ??? ]";
            lbNationalNo.Text = "[ ??? ]";
            lbGender.Text = "[ ??? ]";
            lbDateOfBirth.Text = "[ ??? ]";
            pbProfilePicture.Image = null;

            // empty driver info
            lbDriverID.Text = "[ ??? ]";

        }

        private string GetIssueReason(int licenseIssueReasonNumber)
        {
            switch (licenseIssueReasonNumber)
            {
                case 1:
                    {
                        return "First Time";
                    }
                case 2:
                    {
                        return "Renew";
                    }
                case 3:
                    {
                        return "Lost Replacement";
                    }
                case 4:
                    {
                        return "Damaged Replacement";
                    }
                default:
                    {
                        return "Unknown";
                    }
            }
            return "Unknown";
        }

        private void DisplayDataFromLicense(clsLicense license)
        {
            lbClassName.Text = clsLicenseClass.GetLicenseClassNameByID(license.LicenseClassID);
            lbLicenseID.Text = license.LicenseID.ToString();
            lbIssueDate.Text = license.IssueDate.ToString("d");
            lbExpirationDate.Text = license.ExpirationDate.ToString("d");
            lbIssueReason.Text = GetIssueReason(license.IssueReason);
            lbIsDetained.Text = (clsDetainedLicense.isDetainedLicense(license.LicenseID) != -1) ? "Yes" : "No" ; 
            lbIsActive.Text = license.IsActive ? "Yes" : "No";
            lbNotes.Text = license.Notes.Length < 40? license.Notes : (license.Notes.Substring(0, 37) + " (...)");

        }

        private void DisplayDataFromPerson(clsPerson person)
        {
            lbPersonFullName.Text = person.FullName();
            lbNationalNo.Text = person.NationalNo;
            lbGender.Text = person.Gendor == 0 ? "Male" : "Female";
            lbDateOfBirth.Text = person.DateOfBirth.ToString("d");
            if(File.Exists(person.ImagePath))
            {
                pbProfilePicture.Image = Image.FromFile(person.ImagePath);
            }
            else
            {
                pbProfilePicture.Image = person.Gendor == 0? Properties.Resources.male: Properties.Resources.female;
            }
        }

        private void DisplayDataFromDriver(clsDriver driver)
        {
            lbDriverID.Text = driver.DriverID.ToString() ;
        }

        public enum enLoadResult { Succeed = 1, LicenseNotFound = 2, DriverNotFound = 4, PersonNotFound = 5};

        public enLoadResult LoadData(int LicenseID_ApplicationID)
        {
            clsLicense license;
            if((license = clsLicense.Find(LicenseID_ApplicationID)) == null)
            {
                EmptyData();
                _LicenseFound(license);
                return enLoadResult.LicenseNotFound;
            }
            clsDriver driver;
            if((driver = clsDriver.Find(license.DriverID)) == null)
            {
                EmptyData();
                _LicenseFound(license);
                return enLoadResult.DriverNotFound;
            }
            clsPerson person;
            if((person = clsPerson.Find(driver.PersonID)) == null)
            {
                EmptyData();
                _LicenseFound(license);
                return enLoadResult.PersonNotFound;
            }

            DisplayDataFromLicense(license);
            DisplayDataFromDriver(driver); 
            DisplayDataFromPerson(person);

            _LicenseFound(license); // fire WhenLicenseFound event (action)

            return enLoadResult.Succeed;
        }

        private void ctrlLicenseCard_Load(object sender, EventArgs e)
        {

        }

        private void liPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonCard PersonCardForm = new frmPersonCard(lbNationalNo.Text);
            PersonCardForm.ShowDialog();
        }
    }
}
