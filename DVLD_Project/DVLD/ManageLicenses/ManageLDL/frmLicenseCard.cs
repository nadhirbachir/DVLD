using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmLicenseCard : Form
    {

        private void DisplayData(int LicenseID_ApplicationID)
        {
            switch(ctrlLicenseCard1.LoadData(LicenseID_ApplicationID))
            {
                case ctrlLicenseCard.enLoadResult.LicenseNotFound:
                    {
                        MessageBox.Show("License with the provided ID/ApplicationID not found", "license not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        break;
                    }
                case ctrlLicenseCard.enLoadResult.DriverNotFound:
                    {
                        MessageBox.Show("Driver not found with the provided data", "driver not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        break;
                    }
                case ctrlLicenseCard.enLoadResult.PersonNotFound:
                    {
                        MessageBox.Show("Person with the provided data not found", "Person not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
        }

        public frmLicenseCard(int LicenseID_ApplicationID)
        {
            InitializeComponent();
            DisplayData(LicenseID_ApplicationID);
        }

        private void frmLicenseCard_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
