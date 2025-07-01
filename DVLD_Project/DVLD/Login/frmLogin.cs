using DVLD_Business;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace DVLD
{
    public partial class frmLogin : Form
    {
        private string RememberMeFileName = "RememberMe.txt";

        private string Delim = "#@@#";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void ShowMainScreen()
        {
            this.Visible = false;
            frmMain frm = new frmMain(this);
            frm.ShowDialog();
            clsGlobal.MainUser = null;
            this.Visible = true;
            tbUserName.Focus();
        }

        private bool _CheckAndLogin()
        {
            if (!string.IsNullOrWhiteSpace(tbUserName.Text) && !string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                clsUser LoginUser = clsUser.Find(tbUserName.Text, tbPassword.Text);
                if(LoginUser == null)
                {
                    MessageBox.Show("User with those informations do not exist", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if(LoginUser.IsActive == false)
                {
                    MessageBox.Show("Your account is not active", "User not Active", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                if(LoginUser != null && LoginUser.IsActive == true)
                {
                    clsGlobal.MainUser = LoginUser;
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Some information are invalid", "Invalid inputs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }

        private string _GetParentDirectory(string PathText, int LevelsUp = 0)
        {
            if(PathText == null || LevelsUp <= 0)
            {
                return PathText;
            }

            string result = PathText;
            for(short i = 0; i < LevelsUp; i++)
            {
                if (result == null)
                    break;
                result = Path.GetDirectoryName(result);
            }
            return result;
        }

        enum enInfoType { eUserName = 1, ePassword = 2};

        private bool SaveUserInfo(enInfoType type, bool EmptySave = false)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            string ValueName = type == enInfoType.eUserName? "UserName": "UserPassword";
            string Value = EmptySave? string.Empty: (type == enInfoType.eUserName? tbUserName.Text : tbPassword.Text);

            try 
            {
                Registry.SetValue(KeyPath, ValueName, Value, RegistryValueKind.String);
                return true;
            }
            catch(Exception)
            {
                return false;
            }

        }

        private string ReadUserInfo(enInfoType type)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
            string ValueName = type == enInfoType.eUserName ? "UserName" : "UserPassword";

            string Value = Registry.GetValue(KeyPath, ValueName, null) as string;

            if (Value != null)
            {
                return Value;
            }

            return string.Empty;

        }

        private bool _RememberMe()
        {
            /*string StartUpPath = AppDomain.CurrentDomain.BaseDirectory;
            string ProjectDirectory = _GetParentDirectory(StartUpPath, LevelsUp: 3);
            string FilePath = Path.Combine(ProjectDirectory, RememberMeFileName);

            if(!File.Exists(FilePath))
            {
                // this way so you won't get run time error because the file will be closed after the operation
                using (FileStream fs = File.Create(FilePath))
                {

                }
            }

            if (chkRememberMe.Checked == true)
            {
                using (StreamWriter writer = new StreamWriter(FilePath, false))
                {
                    writer.Write(tbUserName.Text + Delim + tbPassword.Text);
                }
                return true;
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(FilePath, false))
                {
                    writer.Write(string.Empty);
                }
                return false;
            }*/

            

            if(chkRememberMe.Checked)
            {
                if(SaveUserInfo(enInfoType.eUserName) && SaveUserInfo(enInfoType.ePassword))
                {
                    return true;
                }
                return false;
            }
            else
            {
                SaveUserInfo(enInfoType.eUserName, EmptySave: true);
                SaveUserInfo(enInfoType.ePassword, EmptySave: true);
                return false;
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(_CheckAndLogin())
            {
                if(_RememberMe())
                {

                }
                else
                {
                    tbUserName.Text = string.Empty;
                    tbPassword.Text = string.Empty;
                }
                ShowMainScreen();
            }
        }

        private void FillLogin()
        {
            tbUserName.Text = ReadUserInfo(enInfoType.eUserName);
            tbPassword.Text = ReadUserInfo(enInfoType.ePassword);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbUserName.Focus();
            FillLogin();
        }

        private void tbUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                errorProvider1.SetError((TextBox)sender, "this field can't be empty");

            }
        }
    }
}
