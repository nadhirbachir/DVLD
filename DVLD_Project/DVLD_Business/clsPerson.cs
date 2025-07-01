using System;
using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsPerson
    {

        enum enMode { eAddNew = 1, eUpdate = 2 }
        private enMode _Mode;

        public int PersonID { get; private set; }

        public string NationalNo { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string ThirdName { get; set; }

        public string LastName { get; set; }

        public string FullName()
        {
            string FullName = FirstName;
            if (!string.IsNullOrWhiteSpace(SecondName))
                FullName += ' ' + SecondName;

            if (!string.IsNullOrWhiteSpace(ThirdName))
                FullName += ' ' + ThirdName;

            FullName += ' ' + LastName;
            return FullName;

        }

        public DateTime DateOfBirth { get; set; }

        public short Gendor { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int NationalityCountryID { get; set; }

        public string ImagePath { get; set; }

        private clsPerson(int PersonID, string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName, DateTime DateOfBirth, short Gendor, string Address,
            string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            _Mode = enMode.eUpdate;
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath;
        }

        private bool _AddPerson()
        {
            return (this.PersonID = clsPersonData.AddPerson(NationalNo, FirstName, SecondName, ThirdName, LastName,
                DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath)) != -1;
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
        }

        // ------------------------------------------------>

        public clsPerson(string NationalNumber)
        {
            _Mode = enMode.eAddNew;
            PersonID = -1;
            NationalNo = NationalNumber;
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateOfBirth = new DateTime();
            Gendor = 0;
            Address = "";
            Phone = "";
            Email = "";
            NationalityCountryID = -1 ;
            ImagePath = "";
        }

        public static clsPerson Find(int PersonID)
        {
            //return new clsPerson(0, "1", "", "", "", "23", DateTime.Now, 1, "", "", "", 5, "");
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = new DateTime();
            short Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            if(clsPersonData.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName, ref SecondName,
            ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address,
            ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {

                return new clsPerson(PersonID, NationalNo, FirstName, SecondName,
                                    ThirdName, LastName, DateOfBirth, Gendor, Address,
                                    Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }

        }

        public static clsPerson Find(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = new DateTime();
            short Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";

            if (clsPersonData.GetPersonInfoByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName,
            ref ThirdName, ref LastName, ref DateOfBirth, ref Gendor, ref Address,
            ref Phone, ref Email, ref NationalityCountryID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName,
                                    ThirdName, LastName, DateOfBirth, Gendor, Address,
                                    Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }

        }

        public bool Save()
        {
            switch(this._Mode)
            {
                case enMode.eAddNew:
                    {
                        if (this._AddPerson())
                        {
                            this._Mode = enMode.eUpdate;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.eUpdate:
                    {
                        return _UpdatePerson();
                    }
                default:
                    {
                        return false;
                    }
            }
                
        }

        public bool Delete()
        {
            if(clsPersonData.DeletePerson(this.PersonID))
            {
                _Mode = enMode.eAddNew;
                PersonID = -1;
                NationalNo = "";
                FirstName = "";
                SecondName = "";
                ThirdName = "";
                LastName = "";
                DateOfBirth = new DateTime();
                Gendor = 0;
                Address = "";
                Phone = "";
                Email = "";
                NationalityCountryID = -1;
                ImagePath = "";
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool DeleteGroupOfPeople(int[] PeopleIDs)
        {
            if(PeopleIDs.Length < 1)
            {
                return false;
            }
            return clsPersonData.DeleteGroupOfPeople(PeopleIDs);
        }

        public static DataTable PeopleTable()
        {
            return clsPersonData.GetPeopleList();
        }


        public static bool isPersonExists(string NationalNo)
        {
            return clsPersonData.DoPersonExists(NationalNo);
        }

        public static bool isPersonExists(int PersonID)
        {
            return clsPersonData.DoPersonExists(PersonID);
        }

    }
}
