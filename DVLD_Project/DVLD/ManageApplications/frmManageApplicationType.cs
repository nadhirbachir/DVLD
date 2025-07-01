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
    public partial class frmManageApplicationType : Form
    {

        private void _Refresh()
        {
            dgvApplicationType.DataSource = clsApplicationType.ApplicationTypeTable();
            lbRecords.Text = dgvApplicationType.RowCount.ToString();
        }

        public frmManageApplicationType()
        {
            InitializeComponent();
        }

        private void frmManageApplicationType_Load(object sender, EventArgs e)
        {
            _Refresh();
        }

        private void editApplToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SelectedAppTypeID = Convert.ToInt32(dgvApplicationType.SelectedRows[0].Cells["ApplicationTypeID"].Value);
            frmEditApplicationType frm = new frmEditApplicationType(SelectedAppTypeID);
            frm.ShowDialog();

            _Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
