using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccess;
using System.Data;

namespace DVLD_Business
{
    public class clsCountry
    {
        public static string GetCountryNameByID(int CountryID)
        {
            return clsCountriesData.GetCountryNameByID(CountryID);
        }

        public static DataTable GetCountriesList()
        {
            return clsCountriesData.GetCountriesList();
        }

    }
}
