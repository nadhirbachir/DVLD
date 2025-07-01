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
using System.IO;

namespace DVLD
{
    public partial class ctrlIDLInfo : UserControl
    {

        private void FillILInfo(clsInternationalLicense ILInfo)
        {
            lbILID.Text = ILInfo.InternationalLicenseID.ToString();
            lbLicenseID.Text = ILInfo.IssuedUsingLocalLicenseID.ToString();
            lbDriverID.Text = ILInfo.DriverID.ToString();
            lbApplicationID.Text = ILInfo.ApplicationID.ToString();
            lbIssueDate.Text = ILInfo.IssueDate.ToString("d");
            lbExpirationDate.Text = ILInfo.ExpirationDate.ToString("d");
            lbIsActive.Text = ILInfo.IsActive ? "Yes" : "No";
        }

        private void FillPersonInfo(clsPerson PersonInfo)
        {
            lbFullName.Text = PersonInfo.FullName();
            lbNationalNo.Text = PersonInfo.NationalNo;
            lbGender.Text = PersonInfo.Gendor == 0 ? "Male" : "Female";
            lbBirthDate.Text = PersonInfo.DateOfBirth.ToString("d");
            if(File.Exists(PersonInfo.ImagePath))
            {
                pbProfilePicture.Image = Image.FromFile(PersonInfo.ImagePath);
            }
            else
            {
                pbProfilePicture.Image = PersonInfo.Gendor == 0 ? Properties.Resources.male : Properties.Resources.female;
            }
        }


        public enum enLoadingResult { Succeed = 1, ILNotFound = 2, PersonNotFound = 3, DriverNotFound = 4};

        public enLoadingResult LoadILDataILID(int ILID_AppID_LLID, enSearchOption option)
        {
            clsInternationalLicense ILicense = clsInternationalLicense.Find(ILID_AppID_LLID, (clsInternationalLicense.enSearchOption)option);
            if (ILicense == null)
            {
                return enLoadingResult.ILNotFound;
            }

            clsDriver driver = clsDriver.Find(ILicense.DriverID);
            if (ILicense == null)
            {
                return enLoadingResult.DriverNotFound;
            }

            clsPerson person = clsPerson.Find(driver.PersonID);
            if(person == null)
            {
                return enLoadingResult.PersonNotFound;
            }

            FillILInfo(ILicense);
            FillPersonInfo(person);
            return enLoadingResult.Succeed;

        }

        public enum enSearchOption { ILID = 1, AppID = 2, LLID = 3 };

        public ctrlIDLInfo()
        {
            InitializeComponent();
        }
    }
}
