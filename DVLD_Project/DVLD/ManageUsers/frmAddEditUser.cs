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
    public partial class frmAddEditUser : Form
    {
        private enum enMode { eAddNew = 1, eEdit = 2 }

        private enMode _Mode = enMode.eAddNew;

        private clsUser user = null;

        private void _FillCtrl(int UserID)
        {
            if((user = clsUser.Find(UserID)) != null)
            {

                lbAddEdit.Text = "Update User";
                lbUserID.Text = UserID.ToString();
                ctrlPersonInfoFilter1.SelectedPerson(user.PersonID);
                tbUserName.Text = user.UserName;
                tbPassword.Text = user.Password;
                tbConfirmPassword.Text = user.Password;
                chkIsActive.Checked = user.IsActive;
            }
        }

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            if(clsUser.isUserExists(UserID))
            {
                _Mode = enMode.eEdit;
                _FillCtrl(UserID);
                user = clsUser.Find(UserID);
                _UserComponentsIsActive(true, user.PersonID);
            }
            else
            {
                _Mode = enMode.eAddNew;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if(clsUser.isUserExists(tbUserName.Text))
            {
                errorProvider1.SetError((TextBox)sender, "There's another user with the same username");
            }
            else if(string.IsNullOrWhiteSpace(tbUserName.Text))
            {
                errorProvider1.SetError((TextBox)sender, "the username can't be empty or white spaces");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                errorProvider1.SetError((TextBox)sender, "the Password can't be empty or white spaces");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if(tbConfirmPassword.Text != tbPassword.Text)
            {
                errorProvider1.SetError((TextBox)sender, "the Password confirmation don't match the password");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPersonInfoFilter1_PersonSelected(int obj)
        {
            if(obj != -1)
            {
                btnNext.Enabled = true;
                btnNext.Tag = obj.ToString();
            }
            else
            {
                btnNext.Enabled = false;
                btnNext.Tag = null;
                _UserComponentsIsActive(false, -1);
            }
        }

        private void _UserComponentsIsActive(bool isActive, int SelectedPersonID)
        {
            if(_Mode == enMode.eAddNew)
            {
                if (isActive)
                {
                    user = new clsUser(SelectedPersonID);
                    panelUserInformation.Enabled = true;
                    tabCtrlAddEditUser.SelectedTab = tabUser;
                }
                else
                {
                    user = null;
                    panelUserInformation.Enabled = false;
                    tabCtrlAddEditUser.SelectedTab = tabPerson;
                }
            }
            else
            {
                panelUserInformation.Enabled = true;
                tabCtrlAddEditUser.SelectedTab = tabUser;
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if(btnNext.Tag != null)
            {


                int SelectedPersonID = Convert.ToInt32(btnNext.Tag);

                if (clsUser.isUserExists(SelectedPersonID))
                {
                    MessageBox.Show("this person is linked to another user", "Person failed linking", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _UserComponentsIsActive(false, SelectedPersonID);

                    return;

                }

                else if(user != null && user.PersonID != SelectedPersonID)
                {
                    MessageBox.Show("this person is linked to another user", "Person failed linking", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _UserComponentsIsActive(false, SelectedPersonID);

                    return;
                }

                else if (!clsPerson.isPersonExists(SelectedPersonID))
                {
                    MessageBox.Show("Person not found", "Person not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    _UserComponentsIsActive(false, SelectedPersonID);

                    return;

                }
                _UserComponentsIsActive(true, SelectedPersonID);
            }
            else
            {
                MessageBox.Show("you need to select person first", "Person selecting failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _UserComponentsIsActive(false, -1);

                return;
            }
        }

        private bool _CheckCtrls()
        {
            if(user == null)
            {
                return false;
            }

            if(_Mode == enMode.eAddNew)
            {
                if (!clsPerson.isPersonExists(user.PersonID) ||
                string.IsNullOrWhiteSpace(tbPassword.Text) || string.IsNullOrWhiteSpace(tbConfirmPassword.Text)
                || string.IsNullOrWhiteSpace(tbUserName.Text) || (tbPassword.Text != tbConfirmPassword.Text)
                || clsUser.isUserExists(tbUserName.Text) || clsUser.isUserExists(user.PersonID))
                {
                    return false;
                }
            }
            else
            {
                if (!clsPerson.isPersonExists(user.PersonID) ||
                string.IsNullOrWhiteSpace(tbPassword.Text) || string.IsNullOrWhiteSpace(tbConfirmPassword.Text)
                || string.IsNullOrWhiteSpace(tbUserName.Text) || (tbPassword.Text != tbConfirmPassword.Text)
                || (clsUser.isUserExists(tbUserName.Text) && (tbUserName.Text != user.UserName)))
                {
                    return false;
                }
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!_CheckCtrls())
            {
                MessageBox.Show("Some of the inputs are invalid", "Invalid inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            user.UserName = tbUserName.Text;
            user.Password = tbPassword.Text;
            user.IsActive = chkIsActive.Checked;
            if(user.Save())
            {
                DialogResult r1 = (_Mode == enMode.eAddNew) ?
                MessageBox.Show("User was added successfuly", "Success adding user", MessageBoxButtons.OK, MessageBoxIcon.Information)
                : MessageBox.Show("User was updated successfuly", "Success updating user", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.eEdit;
                this._FillCtrl(user.UserID);
                return;
            }
            else
            {
                DialogResult r1 = (_Mode == enMode.eAddNew) ?
                MessageBox.Show("User adding failed", "failed operation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                : MessageBox.Show("User updating failed", "failed operation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

        }
    }
}
