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
    public partial class frmEditApplicationType : Form
    {

        clsApplicationType app = null;

        public frmEditApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            if((app = clsApplicationType.Find(ApplicationTypeID)) != null)
            {
                
            }
            else
            {
                this.Close();
            }
        }

        private void tbAppTypeFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if((e.KeyChar == '.') && tbAppTypeFees.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void tbAppTypeFees_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbAppTypeFees.Text) || Convert.ToSingle(tbAppTypeFees.Text) < 0 )
            {
                errorProvider1.SetError((TextBox)sender, "this field can't be empty or less than 0");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private bool CheckInputs()
        {
            if(string.IsNullOrEmpty(tbAppTypeFees.Text) || Convert.ToSingle(tbAppTypeFees.Text) < 0 
                || string.IsNullOrWhiteSpace(tbAppTypeFees.Text))
            {
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!CheckInputs())
            {
                MessageBox.Show("Some inputs are invalid", "Error inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            app.ApplicationTypeTitle = tbAppTypeTitle.Text;
            app.ApplicationFees = Convert.ToSingle(tbAppTypeFees.Text);
            if(app.Save())
            {
                MessageBox.Show("Application updated successfuly", "Updating result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Application updating failed", "Updating result", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tbAppTypeTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAppTypeFees.Text))
            {
                errorProvider1.SetError((TextBox)sender, "this field can't be empty or white space");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            tbAppTypeTitle.Text = app.ApplicationTypeTitle;
            tbAppTypeFees.Text = app.ApplicationFees.ToString();
            lbApplicationTypeID.Text = app.ApplicationTypeID.ToString();
        }
    }
}
