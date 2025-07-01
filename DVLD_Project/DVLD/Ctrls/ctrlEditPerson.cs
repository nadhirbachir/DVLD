using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLD
{
    public partial class ctrlEditPerson : UserControl
    {

        public delegate void dClose(object sender);

        public dClose CloseForm;

        public delegate void PersonIDBack(object sender, int PersonID);

        public PersonIDBack IDBack;

        string _ProfilePictureFolder = "C:\\Users\\Nadir\\source\\repos\\DVLD\\ProfilePictures";

        clsPerson person = new clsPerson(Convert.ToString(Guid.NewGuid()));
        enum enMode { eAddNew = 0, eUpdate = 1 };
        enMode _Mode;

        private string[] _EmailsSupported = { "@gmail", "@hotmail", "@yahoo" };

        private string[] _TopLevelDomainsSupported = { ".com", ".net", ".org", ".gov", ".mil", ".edu" };

        private bool _CheckEmailUsername(string Email)
        {
            if (Email.StartsWith("@"))
            {
                return false;
            }

            short AtCount = 0;
            char DotValidating = '.';
            for(short i = 0; i < Email.Length; i++)
            {
                if ((Email[i] == DotValidating && DotValidating == '.') || AtCount > 1)
                {
                    return false;
                }
                else
                {
                    DotValidating = Email[i];
                }
                if(Email[i] == '@')
                {
                    AtCount++;
                }
            }
            if (AtCount == 0)
            {
                return false;
            }

            return true;
        }

        private bool _CheckEmailSupported(string Email)
        {
            if (!_CheckEmailUsername(Email))
            {
                return false;
            }

            string ContainedEmail = "";
            for(short i = 0; i < _EmailsSupported.Count(); i++)
            {
                if (Email.Contains(_EmailsSupported[i]))
                {
                    ContainedEmail = _EmailsSupported[i];
                    break;
                }
            }
            if(ContainedEmail == "")
            {
                return false;
            }

            string EmailEndsWith = "";
            for (short j = 0; j < _TopLevelDomainsSupported.Count(); j++)
            {
                EmailEndsWith = ContainedEmail + _TopLevelDomainsSupported[j];
                if (Email.EndsWith(EmailEndsWith))
                {
                    return true;
                }
                    
            }
            return false;
        }

        private void _LoadCountries()
        {
            cbCountries.DataSource = clsCountry.GetCountriesList();
            cbCountries.DisplayMember = "CountryName";
            cbCountries.ValueMember = "CountryID";

            if (person.NationalityCountryID != -1)
            {
                cbCountries.SelectedValue = person.NationalityCountryID;
            }

        }

        private void _RefreshMaleFemalePicture()
        {
            if(pbProfilePicture.Tag == null)
            {
                if (rdMale.Checked)
                {
                    pbProfilePicture.Image = Properties.Resources.male;
                }
                else if(rdFemale.Checked)
                {
                    pbProfilePicture.Image = Properties.Resources.female;
                }
            }
            btnRemovePicture.Visible = (pbProfilePicture.Tag != null);
        }

        private bool _CheckAllControls()
        {
            if(string.IsNullOrWhiteSpace(tbNationalNo.Text) || ((tbNationalNo.Text != person.NationalNo) && clsPerson.isPersonExists(tbNationalNo.Text)))
            {
                return false;
            }

            if(string.IsNullOrWhiteSpace(tbFirstName.Text)|| string.IsNullOrWhiteSpace(tbLastName.Text) ||
                string.IsNullOrWhiteSpace(tbAddress.Text) || string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                return false;
            }
            if(!_CheckEmailSupported(tbEmail.Text) && tbEmail.Text.Length > 0)
            {
                return false;
            }
            return true;
        }

        private string _CopyProfilePictures()
        {
            string oldImagePath = "";

            // Check if person.ImagePath exists and get its filename without extension
            if (!string.IsNullOrEmpty(person.ImagePath) && File.Exists(person.ImagePath))
            {
                oldImagePath = person.ImagePath; ;
            }

            if (!string.IsNullOrEmpty(pbProfilePicture.Tag.ToString()) && File.Exists(pbProfilePicture.Tag.ToString()))
            {
                string src = pbProfilePicture.Tag.ToString();
                string Ext = Path.GetExtension(src);
                string destFile = Path.Combine(_ProfilePictureFolder, Guid.NewGuid().ToString() + Ext);

                try
                {
                    File.Copy(src, destFile, true);

                    /* you need to delete the old image later
                        if (File.Exists(oldImagePath))
                        {
                            File.Delete(oldImagePath);
                        }
                    */

                    return destFile;
                }
                catch (Exception ex)
                {
                    // Log the exception or handle it accordingly
                    MessageBox.Show("Error copying file: " + ex.Message);
                }
            }

            

            return "";
        }

        public ctrlEditPerson()
        {
            InitializeComponent();
            
        }

        public void LoadPersonInfo(int PersonID)
        {
            if (clsPerson.isPersonExists(PersonID))
            {
                person = clsPerson.Find(PersonID);
                _Mode = enMode.eUpdate;
                labelPerson.Text = "Update Person";
                lbPersonID.Text = PersonID.ToString();
                tbNationalNo.Text = person.NationalNo;
                tbFirstName.Text = person.FirstName;
                tbSecondName.Text = person.SecondName;
                tbThirdName.Text = person.ThirdName;
                tbLastName.Text = person.LastName;
                if (person.Gendor == 0)
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = true;
                }
                dtpBirthDate.Value = person.DateOfBirth;
                tbAddress.Text = person.Address;
                tbPhone.Text = person.Phone;
                tbEmail.Text = person.Email;
                if(File.Exists(person.ImagePath))
                {
                    pbProfilePicture.Image = Image.FromFile(person.ImagePath);
                    pbProfilePicture.Tag = person.ImagePath;
                }
                cbCountries.SelectedValue = person.NationalityCountryID;
                

            }
            else
            {
                _Mode = enMode.eAddNew;
                labelPerson.Text = "Add New Person";
                lbPersonID.Text = "???";
            }
        }

        private void ctrlEditPerson_Load(object sender, EventArgs e)
        {
            _LoadCountries();
            _RefreshMaleFemalePicture();
            dtpBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            dtpBirthDate.Value = DateTime.Now.AddYears(-18).AddHours(-1);
            
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            SelectProfilePictureDialog.Filter = "All Files (*.*)|*.*|PNG Files (*.png)|*.png" +
                "|JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|BMP Files (*.bmp)|*.bmp" +
                "|TIFF Files (*.tiff)|*.tiff|WEBP Files (*.webp)|*.webp";

            if (SelectProfilePictureDialog.ShowDialog() == DialogResult.OK)
            {
                pbProfilePicture.Tag = SelectProfilePictureDialog.FileName;
                pbProfilePicture.Image = Image.FromFile(SelectProfilePictureDialog.FileName);
                _RefreshMaleFemalePicture();
            }
        }

        private void btnRemovePicture_Click(object sender, EventArgs e)
        {
            pbProfilePicture.Image = null;
            pbProfilePicture.Tag = null;
            _RefreshMaleFemalePicture();
        }

        private void rdGender_CheckedChanged(object sender, EventArgs e)
        {
            _RefreshMaleFemalePicture();
        }

        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
             if(clsPerson.isPersonExists(tbNationalNo.Text) && tbNationalNo.Text != person.NationalNo)
            {
                errorProvider1.SetError(tbNationalNo, "There's another person with the same national number!");

            }
             else if(string.IsNullOrWhiteSpace(tbNationalNo.Text))
            {
                errorProvider1.SetError(tbNationalNo, "You can't have empty national number!");
            }
             else
            {
                errorProvider1.Clear();
            }
        }

        private void EmptyField_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                errorProvider1.SetError((Control)sender, "this field can't be empty!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if(tbEmail.Text.Length > 0)
            {
                if (!_CheckEmailSupported(tbEmail.Text))
                {
                    errorProvider1.SetError(tbEmail, "Email is invalid or not supported");
                }
                else
                {
                    errorProvider1.Clear();
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!_CheckAllControls())
            {
                MessageBox.Show("There's some invalid inputs!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string destFilePath = "";
            if (pbProfilePicture.Tag != null)
            {
                destFilePath = _CopyProfilePictures();
            }

            if (_Mode == enMode.eUpdate)
            {
                person.NationalNo = tbNationalNo.Text;

            }
            else if (_Mode == enMode.eAddNew)
            {
                person = new clsPerson(tbNationalNo.Text);
            }

            person.FirstName = tbFirstName.Text;
            person.SecondName = tbSecondName.Text;
            person.ThirdName = tbThirdName.Text;
            person.LastName = tbLastName.Text;
            person.DateOfBirth = dtpBirthDate.Value;
            person.Gendor = rdMale.Checked ? Convert.ToInt16(0) : Convert.ToInt16(1);
            person.Address = tbAddress.Text;
            person.Phone = tbPhone.Text;
            person.Email = tbEmail.Text;
            person.NationalityCountryID = Convert.ToInt32(cbCountries.SelectedValue);
            person.ImagePath = pbProfilePicture.Tag != null ? destFilePath : "";
            if(person.Save())
            {
                MessageBox.Show("Person saved successfuly :)", "Save result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPersonInfo(person.PersonID);
            }
            else
            {
                MessageBox.Show("Person saving failed ", "Save result", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            // get the ID back in closing the ctrl
            IDBack?.Invoke(this, person.PersonID);
            // Close form invoke (press the button of close so the form that include this ctrl have to be closed after that)
            CloseForm?.Invoke(this);
        }
    }
}
