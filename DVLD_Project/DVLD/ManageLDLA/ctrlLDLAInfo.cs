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
    public partial class ctrlLDLAInfo : UserControl
    {

        clsPerson _Person = null;

        public ctrlLDLAInfo()
        {
            InitializeComponent();
        }

        private string GetStatus(short status)
        {
            switch(status)
            {
                case 1:
                    {

                        return "New";
                    }

                case 2:
                    {
                        return "Cancelled";
                    }

                case 3:
                    {
                        return "Completed";
                    }

                default:
                    {
                        return "Unknown";
                    }
            }
        }

        public bool LoadLDLAInfo(int LDLAID)
        {
            if(!clsLDLA.DoLDLAExist(LDLAID))
            {
                MessageBox.Show("Local Driving license application not found", "Error finding L.D.L.A", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DataRow row = clsLDLA.GetFullLDLARowByID(LDLAID);

            _Person = clsPerson.Find(Convert.ToInt32(row["ApplicantPersonID"]));

            lbLDLAID.Text = LDLAID.ToString();
            lbLicenseClass.Text = clsLicenseClass.GetLicenseClassNameByID(Convert.ToInt32(row["LicenseClassID"]));
            lbPassedTests.Text = Convert.ToString(row["PassedTestCount"]) + " / 3";
            lbApplicationID.Text = Convert.ToString(row["ApplicationID"]);
            lbApplicationStatus.Text = GetStatus(Convert.ToInt16(row["ApplicationStatus"]));
            lbApplicantPersonFullName.Text = _Person.FullName();
            lbApplicationTypeName.Text = clsApplicationType.Find(Convert.ToInt32(row["ApplicationTypeID"])).ApplicationTypeTitle;
            lbPaidFees.Text = Convert.ToString(row["PaidFees"]);
            lbApplicationDate.Text = ((DateTime)row["ApplicationDate"]).ToString("d");
            lbLastStatusDate.Text = ((DateTime)row["LastStatusDate"]).ToString("d");
            lbCreatedByUserName.Text = clsUser.Find(Convert.ToInt32(row["CreatedByUserID"])).UserName;
            liShowPersonInfo.Enabled = true;


            return true;
        }

        private void lbPassedTests_Click(object sender, EventArgs e)
        {

        }

        private void liShowPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_Person != null)
            {
                frmPersonCard frm = new frmPersonCard(_Person.PersonID);
                frm.ShowDialog();
            }

        }
    }
}
