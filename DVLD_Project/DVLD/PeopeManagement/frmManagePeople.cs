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
    public partial class frmManagePeople : Form
    {

        private DataTable dtSource = clsPerson.PeopleTable();

        private void _RefreshDgvPeople()
        {
            dtSource = clsPerson.PeopleTable();
            dgvPeople.DataSource = dtSource;
            lbTotalRecords.Text = dgvPeople.RowCount.ToString();
        }

        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _RefreshDgvPeople();
            cbFilter.SelectedIndex = 0;
            cbFilterGender.SelectedIndex = 0;
        }

        private void showPersonCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedPersonID = Convert.ToInt32(dgvPeople.SelectedRows[0].Cells["PersonID"].Value);
            frmPersonCard frm = new frmPersonCard(SelectedPersonID);
            frm.ShowDialog();
            _RefreshDgvPeople();
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.ShowDialog();
            _RefreshDgvPeople();
        }

        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedPersonID = Convert.ToInt32(dgvPeople.SelectedRows[0].Cells["PersonID"].Value);
            frmAddEditPerson frm = new frmAddEditPerson(SelectedPersonID);
            frm.ShowDialog();
            _RefreshDgvPeople();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedPersonID = Convert.ToInt32(dgvPeople.SelectedRows[0].Cells["PersonID"].Value);
            if (MessageBox.Show("Are you sure you want to delete Person with the ID " + SelectedPersonID + "?",
                "Delete person", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if(clsPerson.Find(SelectedPersonID).Delete())
                {
                    MessageBox.Show("Person was deleted successfuly", "Deleting result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Person deleting failed", "Deleting result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _RefreshDgvPeople();
            }
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This option is not available right now", "Send Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void sendSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This option is not available right now", "Send SMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void tbFilterPersonID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbFilterPersonID_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbFilterPersonID.Text))
            {
                string filterExpression = $"PersonID = {Convert.ToInt32(tbFilterPersonID.Text)}";
                //DataView dv = new DataView(dtSource, filterExpression, "", DataViewRowState.CurrentRows);
                //dgvPeople.DataSource = dv;
                DataView dvFilter = dtSource.DefaultView;
                dvFilter.RowFilter = filterExpression;
                dgvPeople.DataSource = dvFilter;
            }
            else
            {
                _RefreshDgvPeople();
            }
        }

        private string StringFilterChoice()
        {
            switch (cbFilter.SelectedItem)
            {
                case "First Name":
                    {
                        return "FirstName";
                    }
                case "Second Name":
                    {
                        return "SecondName";
                    }
                case "Third Name":
                    {
                        return "ThirdName";
                    }
                case "Last Name":
                    {
                        return "LastName";
                    }
                case "Country":
                    {
                        return "CountryName";
                    }
                case "Email":
                    {
                        return "Email";
                    }
                case "NationalNo":
                    {
                        return "NationalNo";
                    }
            }
            return "FirstName";
        }

        private void tbFilterString_TextChanged(object sender, EventArgs e)
        {
            string FilterString = StringFilterChoice(); // get the filter name (first name or second ...etc)

            // check if the text box empty or have data
            if (!string.IsNullOrEmpty(tbFilterString.Text))
            {
                // filter all the names contained the letters in the input
                string filterExpression = $"{FilterString} LIKE '%{tbFilterString.Text}%'";


                DataView dvFilter = dtSource.DefaultView;
                dvFilter.RowFilter = filterExpression;

                // sort the records by the name ascending
                dvFilter.Sort = $"{FilterString} ASC";
                dgvPeople.DataSource = dvFilter;
            }
            else
            {
                _RefreshDgvPeople();
            }
        }

        private void tbFilterPhone_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbFilterPhone.Text))
            {
                string filterExpression = $"Phone LIKE '{tbFilterPhone.Text}%'";
                DataView dvFilter = dtSource.DefaultView;
                dvFilter.RowFilter = filterExpression;
                dgvPeople.DataSource = dvFilter;
            }
            else
            {
                _RefreshDgvPeople();
            }
        }

        private void tbFilterPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbFilterGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterGender.SelectedIndex != 0)
            {
                string FilterExpression = $"Gendor = '{cbFilterGender.SelectedItem}'";
                DataView dvFilter = dtSource.DefaultView;
                dvFilter.RowFilter = FilterExpression;
                dgvPeople.DataSource = dvFilter;
            }
            else
            {
                _RefreshDgvPeople();
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilterPersonID.Text = "";
            tbFilterPhone.Text = "";
            tbFilterString.Text = "";
            cbFilterGender.SelectedItem = "NoFilter";
            // 2 3 4 5 6 8 10
            int[] StringFilterArray = { 2, 3, 4, 5, 6, 8, 10 };
            if(StringFilterArray.Contains(cbFilter.SelectedIndex))
            {
                tbFilterString.Visible = true;
                tbFilterPersonID.Visible = false;
                tbFilterPhone.Visible = false;
                cbFilterGender.Visible = false;
                return;
            }

            
            switch(cbFilter.SelectedIndex)
            {
                case 1: // PersonID
                    {
                        tbFilterString.Visible = false;
                        tbFilterPersonID.Visible = true;
                        tbFilterPhone.Visible = false;
                        cbFilterGender.Visible = false;
                        return;
                    }
                case 7: // Gender
                    {
                        tbFilterString.Visible = false;
                        tbFilterPersonID.Visible = false;
                        tbFilterPhone.Visible = false;
                        cbFilterGender.Visible = true;
                        return;
                    }
                case 9: // Phone
                    {
                        tbFilterString.Visible = false;
                        tbFilterPersonID.Visible = false;
                        tbFilterPhone.Visible = true;
                        cbFilterGender.Visible = false;
                        return;
                    }
                default:
                    {
                        {
                            tbFilterString.Visible = false;
                            tbFilterPersonID.Visible = false;
                            tbFilterPhone.Visible = false;
                            cbFilterGender.Visible = false;
                            return;
                        }
                    }
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.ShowDialog();
            _RefreshDgvPeople();
        }
    }
}
