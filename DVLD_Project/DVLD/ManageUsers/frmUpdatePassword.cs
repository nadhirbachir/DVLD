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
    public partial class frmUpdatePassword : Form
    {
        private clsUser user = new clsUser(-1);


        public frmUpdatePassword(int UserID)
        {
            InitializeComponent();
            ctrlUserCard1.LoadUserData(UserID);
            user = clsUser.Find(UserID);
        }

        private void tbOldPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbOldPassword.Text))
            {
                errorProvider1.SetError((TextBox)sender, "old password input can't be blank");
                return;
            }

            if(tbOldPassword.Text != user.Password)
            {
                errorProvider1.SetError((TextBox)sender, "the current password don't match the old password");
                return;
            }

            errorProvider1.Clear();
            
        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNewPassword.Text))
            {
                errorProvider1.SetError((TextBox)sender, "new password input can't be blank");
                return;
            }

            errorProvider1.Clear();

        }

        private void tbConfirmNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbConfirmNewPassword.Text))
            {
                errorProvider1.SetError((TextBox)sender, "confirm password input can't be blank");
                return;
            }

            if (tbConfirmNewPassword.Text != tbNewPassword.Text)
            {
                errorProvider1.SetError((TextBox)sender, "the confirmation of the new password don't match the new password");
                return;
            }

            errorProvider1.Clear();
        }

        private bool _CheckInputs()
        {
            if(tbOldPassword.Text != user.Password || string.IsNullOrEmpty(tbNewPassword.Text)
                || tbConfirmNewPassword.Text != tbNewPassword.Text)
            {
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!_CheckInputs())
            {
                MessageBox.Show("some inputs are invalid", "invalid inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            user.Password = tbNewPassword.Text;
            if(user.Save())
            {
                MessageBox.Show("User password updated successfuly", "Password updating result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User password updating failed", "Password updating result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ctrlUserCard1.LoadUserData(user.UserID);
            user = clsUser.Find(user.UserID);
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
