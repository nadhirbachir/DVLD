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
    public partial class frmIDLInfo : Form
    {

        public enum enSearchOption { ILID = 1, AppID = 2, LLID = 3 };

        private void LoadData(int ILID_AppID_LLID, enSearchOption option)
        {
            if (ctrlIDLInfo1.LoadILDataILID(ILID_AppID_LLID, (ctrlIDLInfo.enSearchOption)option) != ctrlIDLInfo.enLoadingResult.Succeed)
            {
                MessageBox.Show("International license not found", "result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public frmIDLInfo(int ILID_AppID_LLID, enSearchOption option)
        {
            InitializeComponent();
            LoadData(ILID_AppID_LLID, option);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIDLInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
