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
    public partial class ctrlLicenseCardFilter : UserControl
    {

        public event Action<int> OnLicenseSelected;

        public void SelectedLicense(int LicenseID)
        {
            if(!clsLicense.isLicenseExists(LicenseID))
            {
                MessageBox.Show("License with the provided License ID not found", "License not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(LoadLicenseCardCtrl(LicenseID))
            {
                tbLicenseID.Text = LicenseID.ToString();
                gbFilter.Enabled = false;
                OnLicenseSelected?.Invoke(LicenseID);
            }


        }

        public ctrlLicenseCardFilter()
        {
            InitializeComponent();
        }

        private void tbLicenseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool LoadLicenseCardCtrl(int LicenseID)
        {
            switch (ctrlLicenseCard1.LoadData(LicenseID))
            {
                case ctrlLicenseCard.enLoadResult.LicenseNotFound:
                    {
                        MessageBox.Show("License Not found", "Searching result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                case ctrlLicenseCard.enLoadResult.PersonNotFound:
                    {
                        MessageBox.Show("Person Not found", "Searching result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                case ctrlLicenseCard.enLoadResult.DriverNotFound:
                    {
                        MessageBox.Show("Driver Not found", "Searching result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                case ctrlLicenseCard.enLoadResult.Succeed:
                    {
                        return true;
                    }
                default:
                    {
                        return false;
                    }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbLicenseID.Text))
            {
                MessageBox.Show("License ID field can't be empty", "invalid inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int LicenseID = Convert.ToInt32(tbLicenseID.Text);
            LoadLicenseCardCtrl(LicenseID);
        }

        private void ctrlLicenseCard1_WhenLicenseFound(DVLD_Business.clsLicense obj)
        {
            OnLicenseSelected?.Invoke(obj?.LicenseID ?? -1);
        }
    }
}
