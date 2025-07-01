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
    public partial class frmMain : Form
    {
        clsUser _MainUser = null;

        frmLogin LoginForm;

        private frmManagePeople ManagePeopleForm = new frmManagePeople();
        private frmUserInfo UserInformation = new frmUserInfo(clsGlobal.MainUser.UserID);
        private frmUpdatePassword UpdateUserPassword = new frmUpdatePassword(clsGlobal.MainUser.UserID);
        private frmManageUsers ManageUsersForm = new frmManageUsers();
        private frmManageApplicationType ManageApplicationTypesForm = new frmManageApplicationType();
        private frmManageTestTypes ManageTestTypesForm = new frmManageTestTypes();
        private frmAddEdit_LDL_Applications AddEditLDLAForm = new frmAddEdit_LDL_Applications(-1);
        private frmManageLDLA ManageLDLAForm = new frmManageLDLA();
        private frmManageDrivers ManageDriversForm = new frmManageDrivers();
        private frmIssueInternationalLicense IssueInternationalLicenseForm = new frmIssueInternationalLicense();
        private frmManageInternationalLicenses ManageILsForm = new frmManageInternationalLicenses();
        private frmRenewDrivingLicense RenewDrivingLicenseForm = new frmRenewDrivingLicense();
        private frmReplaceLicense ReplaceLicenseForm = new frmReplaceLicense();
        private frmDetainLicense DetainLicenseForm = new frmDetainLicense();
        private frmReleaseDetainedLicense ReleaseDetainedLicenseForm = new frmReleaseDetainedLicense();
        private frmManageDetainedLicenses ManageDetainedLicensesForm = new frmManageDetainedLicenses();



        public frmMain(frmLogin loginForm)
        {
            InitializeComponent();
            if (clsUser.isUserExists(clsGlobal.MainUser.UserID))
            {
                _MainUser = clsGlobal.MainUser;
            }
            else
            {
                this.Close();
            }

            LoginForm = loginForm;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ManagePeopleForm.IsDisposed)
            {
                ManagePeopleForm = new frmManagePeople();
            }

            ManagePeopleForm.MdiParent = this;
            ManagePeopleForm.Show();
        }

        private void showLoginUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserInformation.IsDisposed)
            {
                UserInformation = new frmUserInfo(clsGlobal.MainUser.UserID);
            }

            UserInformation.MdiParent = this;
            UserInformation.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UpdateUserPassword.IsDisposed)
            {
                UpdateUserPassword = new frmUpdatePassword(clsGlobal.MainUser.UserID);
            }

            UpdateUserPassword.MdiParent = this;
            UpdateUserPassword.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormClosing -= frmMain_FormClosing;
            this.Close();
            this.FormClosing += frmMain_FormClosing;

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManageUsersForm.IsDisposed)
            {
                ManageUsersForm = new frmManageUsers();
            }

            ManageUsersForm.MdiParent = this;
            ManageUsersForm.Show();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManageApplicationTypesForm.IsDisposed)
            {
                ManageApplicationTypesForm = new frmManageApplicationType();
            }

            ManageApplicationTypesForm.MdiParent = this;
            ManageApplicationTypesForm.Show();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManageTestTypesForm.IsDisposed)
            {
                ManageTestTypesForm = new frmManageTestTypes();
            }

            ManageTestTypesForm.MdiParent = this;
            ManageTestTypesForm.Show();
        }

        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (AddEditLDLAForm.IsDisposed)
            {
                AddEditLDLAForm = new frmAddEdit_LDL_Applications(-1);
            }

            AddEditLDLAForm.MdiParent = this;
            AddEditLDLAForm.Show();
        }

        private void newLocalDLApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManageLDLAForm.IsDisposed)
            {
                ManageLDLAForm = new frmManageLDLA();
            }

            ManageLDLAForm.MdiParent = this;
            ManageLDLAForm.Show();

        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManageDriversForm.IsDisposed)
            {
                ManageDriversForm = new frmManageDrivers();
            }

            ManageDriversForm.MdiParent = this;
            ManageDriversForm.Show();


        }

        private void internationalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IssueInternationalLicenseForm.IsDisposed)
            {
                IssueInternationalLicenseForm = new frmIssueInternationalLicense();
            }

            IssueInternationalLicenseForm.MdiParent = this;
            IssueInternationalLicenseForm.Show();
        }

        private void manageInternationalDLApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManageILsForm.IsDisposed)
            {
                ManageILsForm = new frmManageInternationalLicenses();
            }

            ManageILsForm.MdiParent = this;
            ManageILsForm.Show();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RenewDrivingLicenseForm.IsDisposed)
            {
                RenewDrivingLicenseForm = new frmRenewDrivingLicense();
            }

            RenewDrivingLicenseForm.MdiParent = this;
            RenewDrivingLicenseForm.Show();
        }

        private void replacementForLostOrDamagedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ReplaceLicenseForm.IsDisposed)
            {
                ReplaceLicenseForm = new frmReplaceLicense();
            }

            ReplaceLicenseForm.MdiParent = this;
            ReplaceLicenseForm.Show();
        }

        private void detainALicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DetainLicenseForm.IsDisposed)
            {
                DetainLicenseForm = new frmDetainLicense();
            }

            DetainLicenseForm.MdiParent = this;
            DetainLicenseForm.Show();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ReleaseDetainedLicenseForm.IsDisposed)
            {
                ReleaseDetainedLicenseForm = new frmReleaseDetainedLicense();
            }

            ReleaseDetainedLicenseForm.MdiParent = this;
            ReleaseDetainedLicenseForm.Show();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ReleaseDetainedLicenseForm.IsDisposed)
            {
                ReleaseDetainedLicenseForm = new frmReleaseDetainedLicense();
            }

            ReleaseDetainedLicenseForm.MdiParent = this;
            ReleaseDetainedLicenseForm.Show();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManageDetainedLicensesForm.IsDisposed)
            {
                ManageDetainedLicensesForm = new frmManageDetainedLicenses();
            }

            ManageDetainedLicensesForm.MdiParent = this;
            ManageDetainedLicensesForm.Show();
        }

        private void msMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.Close();
        }
    }
}
