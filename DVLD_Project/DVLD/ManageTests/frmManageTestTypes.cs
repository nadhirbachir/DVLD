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

    public partial class frmManageTestTypes : Form
    {

        private void Refresh()
        {
            dgvTestTypes.DataSource = clsTestType.TestTypeTable();
            lbRecords.Text = dgvTestTypes.RowCount.ToString();
        }


        public frmManageTestTypes()
        {
            InitializeComponent();
            Refresh();
        }

        private void editTestTypeInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedAppTypeID = Convert.ToInt32(dgvTestTypes.SelectedRows[0].Cells["TestTypeID"].Value);
            frmEditTestTypes frm = new frmEditTestTypes(SelectedAppTypeID);
            frm.ShowDialog();

            Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
