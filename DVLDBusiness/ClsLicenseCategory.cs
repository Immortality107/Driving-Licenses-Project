using DVLDProject.DVLDData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDBusiness
{
    internal  class ClsLicenseCategory
    {
        int LicenseClassID = -1;
        string ClassName = "";
        int MinimumAge = -1;
        int DefaultLength = -1;
        float fees = 0;
        ClsLicenseCategory licenseCategory = new ClsLicenseCategory();

        public static DataTable GetAllClasses()
        {

            return LicenseCategoryDataTier.GetLicensesClasses();
        }

        public static int GetLicenseClassID(string ClassName)
        {

            return LicenseCategoryDataTier.GetLicenseClassID(ClassName);
        }
        public static int GetLicenseValidityLength(int LicenseClassID)
        {
            return LicenseCategoryDataTier.GetLicenseValidityLength(LicenseClassID);
        }
            public static string GetLicenseClassName(int ClassID)
        {

            return LicenseCategoryDataTier.GetLicenseClassName(ClassID);
        }
    }
}
