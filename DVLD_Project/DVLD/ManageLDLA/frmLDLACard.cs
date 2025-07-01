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
    public partial class frmLDLACard : Form
    {
        private int _LDLAID = -1;
        public frmLDLACard(int LDLAID)
        {
            InitializeComponent();
            if(!clsLDLA.DoLDLAExist(LDLAID))
            {
                MessageBox.Show("There's no Local driving license application with that ID", "error finding LDLA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            _LDLAID = LDLAID;
        }

        private void frmLDLACard_Load(object sender, EventArgs e)
        {
            ctrlLDLAInfo1.LoadLDLAInfo(_LDLAID);
        }
    }
}
