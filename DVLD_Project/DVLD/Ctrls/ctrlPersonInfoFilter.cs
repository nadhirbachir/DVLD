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
    public partial class ctrlPersonInfoFilter : UserControl
    {

        public event Action<int> PersonSelected;


        public void SelectedPerson(string NationalNo)
        {
            if (!clsPerson.isPersonExists(NationalNo))
            {
                MessageBox.Show("Selected person do not exist", "Selected person error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            gbFilter.Enabled = false;
            txbFilter.Text = NationalNo;
            ctrlPersonInfo1.LoadPersonInfo(NationalNo);
        }


        public void SelectedPerson(int PersonID)
        {
            if(!clsPerson.isPersonExists(PersonID))
            {
                MessageBox.Show("Selected person do not exist", "Selected person error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            gbFilter.Enabled = false;
            txbFilter.Text = PersonID.ToString();
            ctrlPersonInfo1.LoadPersonInfo(PersonID);

        }


        public ctrlPersonInfoFilter()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txbFilter.Text))
            {
                switch(cbOption.SelectedItem)
                {
                    case "National No":
                        {
                            ctrlPersonInfo1.LoadPersonInfo(txbFilter.Text);
                            ctrlPersonInfo1_WhenPersonFound(clsPerson.Find(txbFilter.Text));
                            break;
                        }
                    case "Person ID":
                        {
                            ctrlPersonInfo1.LoadPersonInfo(Convert.ToInt32(txbFilter.Text));
                            ctrlPersonInfo1_WhenPersonFound(clsPerson.Find(Convert.ToInt32(txbFilter.Text)));
                            break;
                        }
                }
                
            }
        }

        private void ctrlPersonInfoFilter_Load(object sender, EventArgs e)
        {
            cbOption.SelectedIndex = 1;
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm = new frmAddEditPerson(-1);
            frm.DataBack += _LoadPersonInfoCtrlAfterAdding;
            frm.ShowDialog();
        }

        private void _LoadPersonInfoCtrlAfterAdding(object sender, int PersonID)
        {
            ctrlPersonInfo1.LoadPersonInfo(PersonID);
            txbFilter.Text = PersonID.ToString();
        }

        private void txbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbOption.SelectedItem != null && cbOption.SelectedItem == "Person ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cbOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbFilter.Text = string.Empty;
        }

        private void ctrlPersonInfo1_WhenPersonFound(DVLD_Business.clsPerson obj)
        {
            // if PersonSelected not null
            // if object not null
            // ?? and if it's null -> do that
            PersonSelected?.Invoke(obj?.PersonID ?? -1);

        }
    }
}
