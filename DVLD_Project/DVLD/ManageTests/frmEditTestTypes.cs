using DVLD_Business;
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
    public partial class frmEditTestTypes : Form
    {

        clsTestType Test = null;

        public frmEditTestTypes(int TestTypeID)
        {
            InitializeComponent();
            if ((Test = clsTestType.Find(TestTypeID)) != null)
            {

            }
            else
            {
                this.Close();
            }
        }

        private void tbTestFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && tbTestFees.Text.Contains("."))
            {
                e.Handled = true;
            }
        }


        private void tbTestName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbTestName.Text))
            {
                errorProvider1.SetError((TextBox)sender, "this field can't be empty or white spaces");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbTestDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTestDescription.Text))
            {
                errorProvider1.SetError((TextBox)sender, "this field can't be empty or white spaces");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CheckCtrls()
        {
            if(string.IsNullOrWhiteSpace(tbTestDescription.Text)
                || string.IsNullOrWhiteSpace(tbTestName.Text)
                || string.IsNullOrEmpty(tbTestDescription.Text))
            {
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!CheckCtrls())
            {
                MessageBox.Show("Some inputs are invalid", "saving error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Test.TestTypeTitle = tbTestName.Text;
            Test.TestTypeDescription = tbTestDescription.Text;
            Test.TestFees = Convert.ToSingle(tbTestFees.Text);

            if (Test.Save())
            {
                MessageBox.Show("Application updated successfuly", "Updating result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Application updating failed", "Updating result", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void tbTestFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTestDescription.Text))
            {
                errorProvider1.SetError((TextBox)sender, "this field can't be empty or white spaces");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void frmEditTestTypes_Load(object sender, EventArgs e)
        {
            lbTestTypeID.Text = Convert.ToString(Test.TestTypeID);
            tbTestName.Text = Test.TestTypeTitle;
            tbTestDescription.Text = Test.TestTypeDescription;
            tbTestFees.Text = Test.TestFees.ToString();
        }
    }
}
