using DVLDProject.DVLDData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDBusiness
{
    internal class clsTestType
    {
     public  int TestTypeID = -1;
     public  string TestTypeTitle = "";
     public  string TestTypeDescription = "";
     public  decimal TestTypeFees = 0;
        public static decimal GetTestPrice(int TestTypeID)
        {
            return TestsTypesDataTier.GetTestTypePrice(TestTypeID);
        }

        //public static decimal GetApplicationPrice(string ApplicationTypeName)
        //{
        //    return ApplicationTypesDataTier.GetApplicationPrice(ApplicationTypeName);
        //}
        public static DataTable GetTestTypes()
        {
            return TestsTypesDataTier.GetApplicationTypes();
        }
        //public static string GetApplicationTypeName(int ApplicationTypeID)
        //{
        //    return ApplicationTypesDataTier.GetApplicationTypeName(ApplicationTypeID);
        //}

        public static bool UpdateTestType(int TestTypeID, string TestTypeTitle,string TestDescription, decimal TestTypeFees)
        {
           return TestsTypesDataTier.UpdateTestType(TestTypeID, TestTypeTitle, TestDescription, TestTypeFees);
        }
    }
}
