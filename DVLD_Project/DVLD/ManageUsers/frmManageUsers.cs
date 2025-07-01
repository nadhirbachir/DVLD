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
    public partial class frmManageUsers : Form
    {
        private DataTable UsersTable = clsUser.UsersTable();
        private void _RefreshDgvUsers()
        {
            UsersTable = clsUser.UsersTable();
            dgvUsers.DataSource = UsersTable;
            lbRecords.Text = dgvUsers.RowCount.ToString();
        }

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            cbActiveFilter.SelectedIndex = 0;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(-1);
            frm.ShowDialog();
            _RefreshDgvUsers();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbActiveFilter.SelectedIndex = 0;
            tbStringFilter.Text = string.Empty;
            tbDigitFilter.Text = string.Empty;


            if (cbFilter.SelectedIndex == 0 || cbFilter.SelectedIndex == 1)
            {
                cbActiveFilter.Visible = false;
                tbStringFilter.Visible = false;
                tbDigitFilter.Visible = true;
            }
            if(cbFilter.SelectedIndex == 2 || cbFilter.SelectedIndex == 3)
            {
                cbActiveFilter.Visible = false;
                tbStringFilter.Visible = true;
                tbDigitFilter.Visible = false;
            }
            if(cbFilter.SelectedIndex == 4)
            {
                cbActiveFilter.Visible = true;
                tbStringFilter.Visible = false;
                tbDigitFilter.Visible = false;
            }
        }

        private void cbActiveFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView FilterView = UsersTable.DefaultView;
            
            if(cbActiveFilter.SelectedItem != null)
            {
                switch(cbActiveFilter.SelectedItem)
                {
                    case "All":
                        {
                            _RefreshDgvUsers();
                            break;
                        }
                    case "Active":
                        {
                            FilterView.RowFilter = "IsActive = true";
                            dgvUsers.DataSource = FilterView;
                            break;
                        }
                    case "Disabled":
                        {
                            FilterView.RowFilter = "IsActive = false";
                            dgvUsers.DataSource = FilterView;
                            break;
                        }
                }
            }
            else
            {
                _RefreshDgvUsers();
            }
        }

        private void tbStringFilter_TextChanged(object sender, EventArgs e)
        {
            DataView FilterView = UsersTable.DefaultView;
            string textContent = tbStringFilter.Text;
            if (!string.IsNullOrWhiteSpace(textContent))
            {
                switch (cbFilter.SelectedItem)
                {
                    case "Full Name":
                        {
                            FilterView.RowFilter = $"FullName LIKE '%{textContent}%'";
                            dgvUsers.DataSource = FilterView;
                            break;
                        }
                    case "User Name":
                        {
                            FilterView.RowFilter = $"UserName LIKE '%{textContent}%'";
                            dgvUsers.DataSource = FilterView;
                            break;
                        }
                }
            }
            else
            {
                _RefreshDgvUsers();
            }
        }

        private void tbDigitFilter_TextChanged(object sender, EventArgs e)
        {
            DataView FilterView = UsersTable.DefaultView;
            if (tbDigitFilter.Text != "")
            {
                int NumberContent = Convert.ToInt32(tbDigitFilter.Text);
                switch (cbFilter.SelectedItem)
                {
                    case "Person ID":
                        {
                            FilterView.RowFilter = $"PersonID = {NumberContent}";
                            dgvUsers.DataSource = FilterView;
                            break;
                        }
                    case "User ID":
                        {
                            FilterView.RowFilter = $"UserID = {NumberContent}";
                            dgvUsers.DataSource = FilterView;
                            break;
                        }
                }
            }
            else
            {
                _RefreshDgvUsers();
            }
        }

        private void tbDigitFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void showUserCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
            frmUserInfo frm = new frmUserInfo(UserID);
            frm.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(-1);
            frm.ShowDialog();
            _RefreshDgvUsers();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
            frmAddEditUser frm = new frmAddEditUser(UserID);
            frm.ShowDialog();
            _RefreshDgvUsers();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
            if(UserID == clsGlobal.MainUser.UserID)
            {
                MessageBox.Show("You can't delete this user from this page because it's the main user", "Can't delete loged in user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(MessageBox.Show($"Are you sure do you want to delete the user with ID {UserID}?", "Deleting user", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                == DialogResult.Yes)
            {
                if (clsUser.Find(UserID).Delete())
                {
                    MessageBox.Show("User Deleted successfuly", "Deleting result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("User Deletion failed because user are linked with other data", "Deleting result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _RefreshDgvUsers();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
            frmUpdatePassword frm = new frmUpdatePassword(UserID);
            frm.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not available now", "Sending Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void sendSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not available now", "Sending SMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
