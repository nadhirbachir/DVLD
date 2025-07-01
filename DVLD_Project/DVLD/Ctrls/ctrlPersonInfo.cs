using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using DVLD_Business;


namespace DVLD
{
    public partial class ctrlPersonInfo : UserControl
    {

        private clsPerson _Person = null;

        public event Action<clsPerson> WhenPersonFound;

        protected void _PersonFound(clsPerson Person)
        {
            if(_Person != null)
            {
                WhenPersonFound?.Invoke(Person);
            }
        }

        private void _FillCtrl()
        {
            lbPersonID.Text = Convert.ToString(_Person.PersonID);
            lbNationalNo.Text = _Person.NationalNo;
            lbFullName.Text = _Person.FullName();

            lbNationalityCountry.Text = clsCountry.GetCountryNameByID(_Person.NationalityCountryID);
            lbDateOfBirth.Text = _Person.DateOfBirth.ToString("dd / MMM / yyyy");

            lbGendor.Text = _Person.Gendor == 0 ? "Male" : "Female";
            lbAddress.Text = _Person.Address;
            lbPhone.Text = _Person.Phone;
            lbEmail.Text = _Person.Email;
            if(_Person.ImagePath != "" && File.Exists(_Person.ImagePath))
            {
                pbPersonImage.Image = Image.FromFile(_Person.ImagePath);
            }
            else
            {
                pbPersonImage.Image = _Person.Gendor == 0 ? Properties.Resources.male : Properties.Resources.female;
            }

        }

        private void _EmptyCtrl()
        {
            lbPersonID.Text = "[???]";
            lbNationalNo.Text = "[???]";
            lbFullName.Text = "[???]";
            lbNationalityCountry.Text = "[???]";
            lbDateOfBirth.Text = "[???]";
            lbGendor.Text = "[???]";
            lbAddress.Text = "[???]";
            lbPhone.Text = "[???]";
            lbEmail.Text = "[???]";
            pbPersonImage.Image = null;
            
        }

        public enum enDataResult { Found = 1 , InvalidPersonID = 2, InvalidNationalNo = 3};

        public enDataResult LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            if(_Person == null)
            {
                _EmptyCtrl();
                _Person = null;
                ilbEdit.Visible = (_Person != null);
                MessageBox.Show("There's no Person with that ID", "Person was not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return enDataResult.InvalidPersonID;
            }
            else
            {
                _FillCtrl();
                ilbEdit.Visible = (_Person != null);
                _PersonFound(_Person);
                return enDataResult.Found;
            }
        }

        public enDataResult LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
                _EmptyCtrl();
                _Person = null;
                ilbEdit.Visible = (_Person != null);
                MessageBox.Show("There's no Person with that NationalNo", "Person was not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return enDataResult.InvalidNationalNo;
            }
            else
            {
                _FillCtrl();
                ilbEdit.Visible = (_Person != null);
                _PersonFound(_Person);
                return enDataResult.Found;
            }
        }

        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        private void LoadDataFromPersonEdit(object sender, int PersonID)
        {
            this.LoadPersonInfo(PersonID);

        }

        private void ctrlPersonInfo_Load(object sender, EventArgs e)
        {
            ilbEdit.Visible = (_Person != null);
        }

        private void ilbEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Person != null)
            {
                frmAddEditPerson frm = new frmAddEditPerson(_Person.PersonID);
                //frm.DataBack += LoadDataFromPersonEdit;
                frm.ShowDialog();
                this.LoadPersonInfo(_Person.PersonID);
            }
        }
    }
}
