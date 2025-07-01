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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD
{
    public partial class frmAddEdit_LDL_Applications : Form
    {

        enum enMode { eAddNew = 1, eUpdate = 2 };
        private enMode _Mode = enMode.eAddNew;

        private int _ApplicationTypeID = 1;

        private int _ApplicationID = -1;

        private int _SelectedPersonID = -1;

        private clsLDLA _MainLDLA = null;




        private void FillControls()
        {
            lbDLApplicationID.Text = (_MainLDLA == null)? "[???]" : _MainLDLA.LDLAID.ToString();
            labelAddEdit.Text = (_Mode == enMode.eAddNew) ? "Add new local driving license application" : "Update local driving license application";
            lbApplicationDate.Text = DateTime.Now.ToString("d");
            lbApplicationFees.Text = clsApplicationType.Find(1).ApplicationFees.ToString(); // find the new LDLA 
            lbCreatedBy.Text = clsGlobal.MainUser.UserName;
            if(_Mode == enMode.eUpdate)
            {
                ctrlPersonInfoFilter1.SelectedPerson(clsApplication.Find(_ApplicationID).ApplicantPersonID);

                cbLicenseClass.SelectedValue = _MainLDLA.LicenseClassID;
            }
        }

        private void FillCbClasses()
        {
            cbLicenseClass.DataSource = clsLicenseClass.IDNameClassesTable();
            cbLicenseClass.DisplayMember = "ClassName";
            cbLicenseClass.ValueMember = "LicenseClassID";
            cbLicenseClass.SelectedIndex = 2;
        }

        public frmAddEdit_LDL_Applications(int LDLAID)
        {
            InitializeComponent();
            FillCbClasses();

            if(clsLDLA.DoLDLAExist(LDLAID))
            {
                _MainLDLA = clsLDLA.Find(LDLAID);
                _ApplicationID = _MainLDLA.ApplicationID;
                _Mode = enMode.eUpdate;
            }
            FillControls();


        }

        private void frmAddEdit_LDL_Applications_Load(object sender, EventArgs e)
        {
            
        }

        private void ctrlPersonInfoFilter1_PersonSelected(int SelectedPersonID)
        {
            if(SelectedPersonID != -1)
            {
                btnNext.Enabled = true;
                _SelectedPersonID = SelectedPersonID;
            }
            else
            {
                btnNext.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcLDLApplication.SelectedTab = tabSelectLicenseClass;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckLicenseClass(int SelectedLicenseClassID)
        {
            if ((DateTime.Now.Year - clsPerson.Find(_SelectedPersonID).DateOfBirth.Year) < clsLicenseClass.Find(SelectedLicenseClassID).MinAge)
            {
                MessageBox.Show($"Person age is under the minimum allowed age for this license"
                    , "error completing operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        
        private bool CheckDriver(int SelectedLicenseClassID)
        {
            clsDriver driver = clsDriver.Find(_SelectedPersonID);
            int DriverID = driver != null ? driver.DriverID : -1;

            if (clsLicense.isLicenseExists(DriverID, SelectedLicenseClassID))
            {
                MessageBox.Show($"This person already have a license with the same license class"
                    , "error completing operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private bool CheckApplicationNotExisting(int SelectedLicenseClassID)
        {
            int AppIDIfExists = clsLDLA.DoLDLAExist(_SelectedPersonID, SelectedLicenseClassID);

            bool condition = _Mode == enMode.eAddNew ? (AppIDIfExists == -1) : (AppIDIfExists == -1 && (SelectedLicenseClassID != _MainLDLA.LicenseClassID));

            if (condition)
            {
                return true;
            }
            MessageBox.Show($"There's another incompleted/unclosed application for the same person in the same class type, it's ID = {AppIDIfExists}"
                    , "error completing operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private bool CheckInputs()
        {


            int SelectedLicenseClassID = Convert.ToInt32(cbLicenseClass.SelectedValue);

            if (_SelectedPersonID != -1)
            {
                if(CheckLicenseClass(SelectedLicenseClassID) || CheckDriver(SelectedLicenseClassID))
                {
                    return false;
                }

                if(CheckApplicationNotExisting(SelectedLicenseClassID))
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
                MessageBox.Show("You need to select person at first", "Selected person invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



        }

        private void AddNewLDLA()
        {
            clsApplication app = new clsApplication();
            app.ApplicantPersonID = _SelectedPersonID;
            app.ApplicationDate = DateTime.Now;
            app.ApplicationTypeID = _ApplicationTypeID;
            app.ApplicationStatus = 1; // new
            app.LastStatusDate = DateTime.Now;
            app.PaidFees = clsApplicationType.Find(1).ApplicationFees;
            app.CreatedByUserID = clsGlobal.MainUser.UserID;
            if (app.Save())
            {
                _MainLDLA = new clsLDLA();
                _MainLDLA.ApplicationID = app.ApplicationID;
                _MainLDLA.LicenseClassID = Convert.ToInt32(cbLicenseClass.SelectedValue);
                _ApplicationID = app.ApplicationID;
                if (_MainLDLA.Save())
                {
                    MessageBox.Show("LDLA added successfuly", "adding result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _Mode = enMode.eUpdate;
                    FillControls();
                    return;
                }
            }
            MessageBox.Show("LDLA adding failed", "adding result", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateLDLA()
        {
            clsApplication UpdateApp = clsApplication.Find(_ApplicationID);
            UpdateApp.ApplicantPersonID = _SelectedPersonID;
            UpdateApp.ApplicationTypeID = _ApplicationTypeID;

            _MainLDLA.LicenseClassID = Convert.ToInt32(cbLicenseClass.SelectedValue);

            if (UpdateApp.Save() && _MainLDLA.Save())
            {
                MessageBox.Show("LDLA updated successfuly", "saving result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _Mode = enMode.eUpdate;
                FillControls();
                return;
            }
            else
            {
                MessageBox.Show("LDLA updating failed", "saving result", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!CheckInputs())
            {
                return;
            }

            switch(_Mode)
            {
                case enMode.eAddNew:
                    {
                        AddNewLDLA();
                        return;
                    }
                case enMode.eUpdate:
                    {
                        UpdateLDLA();
                        return;
                    }
            }

        }
    }
}
