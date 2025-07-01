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
    public partial class ctrlUserCard : UserControl
    {

        public void LoadUserData(int PersonIDOrUserID)
        {
            clsUser user = clsUser.Find(PersonIDOrUserID);
            ctrlPersonInfo1.LoadPersonInfo(user.PersonID);
            lbUserID.Text = user.UserID.ToString();
            lbUserName.Text = user.UserName;
            lbIsActive.Text = user.IsActive ? "Yes" : "No";
        }

        public ctrlUserCard()
        {
            InitializeComponent();
        }
    }
}
