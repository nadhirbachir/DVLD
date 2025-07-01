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
    public partial class frmPersonCard : Form
    {
        private enum enSearchType { ePersonID = 1, eNationalNo = 2};
        
        enSearchType _Type;
        
        int _PersonID = -1;
        
        string _NationalNo = string.Empty;




        private void ShowPersonData(int PersonID)
        {
            if (ctrlPersonInfo1.LoadPersonInfo(PersonID) != ctrlPersonInfo.enDataResult.Found)
            {
                this.Close();
            }
        }

        private void ShowPersonData(string NationalNo)
        {
            if (ctrlPersonInfo1.LoadPersonInfo(NationalNo) != ctrlPersonInfo.enDataResult.Found)
            {
                this.Close();
            }
        }

        public frmPersonCard(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Type = enSearchType.ePersonID;
            
        }

        public frmPersonCard(string NationalNo)
        {
            InitializeComponent();
            _NationalNo = NationalNo;
            _Type = enSearchType.eNationalNo;

        }

        private void frmPersonCard_Load(object sender, EventArgs e)
        {
            switch(_Type)
            {
                case enSearchType.ePersonID:
                    {
                        ShowPersonData(_PersonID);
                        break;
                    }
                case enSearchType.eNationalNo:
                    {
                        ShowPersonData(_NationalNo);
                        break;
                    }
                default:
                    {
                        this.Close();
                        return;
                    }
            }
        }
    }
}
