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
    public partial class frmManageDrivers : Form
    {

        private void _Refresh()
        {
            dgvDrivers.DataSource = clsDriver.DriversTable();
            lbRecords.Text = dgvDrivers.RowCount.ToString();
        }

        public frmManageDrivers()
        {
            InitializeComponent();
        }

        private void frmDriversList_Load(object sender, EventArgs e)
        {
            _Refresh();
            cbFilter.SelectedIndex = 0;
        }

        private void showDriverDrivingLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dgvDrivers.SelectedRows[0].Cells["PersonID"].Value);
            if (clsPerson.isPersonExists(PersonID))
            {
                frmLicenseHistory LicenseHistoryForm = new frmLicenseHistory(PersonID);
                LicenseHistoryForm.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
