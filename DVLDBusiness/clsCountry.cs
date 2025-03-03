using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDProject;
namespace DVLDProject.DVLDBusiness
{
    public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

         public clsCountry()
        {
            CountryID = -1;
            CountryName = "";
        }
         private clsCountry(int countryID, string countryName)
        {
            this.CountryID = countryID;
            this.CountryName = countryName;
        }


        public static DataTable GetAllCountries()
        {
            return clsCountryDatacs.GetAllCountries();
        }

        public static clsCountry Find(int CountryID)
        {

            string CountryName = "";
          if(  clsCountryDatacs.FindCountryByID(CountryID, ref CountryName))
               return new clsCountry(CountryID, CountryName);
          else
                return null;
        }

        public static clsCountry Find(string CountryName)
        {

            int CountryID = clsCountryDatacs.FindCountryByCountryName( ref CountryName);
            if (CountryID != -1)
            return new clsCountry(CountryID, CountryName);
            else 
                return null;
        }
    }
}
