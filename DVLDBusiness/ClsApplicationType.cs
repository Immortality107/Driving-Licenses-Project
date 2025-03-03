using DVLDProject.DVLDData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDBusiness
{
    internal class ClsApplicationType
    {
        int ApplicationTypeID = -1;
        string ApplicationTypeName = "";
        float ApplicationTypeFees = 0;
        public static decimal GetApplicationPrice(int ApplicationTypeID)
        {
            return ApplicationTypesDataTier.GetApplicationPrice(ApplicationTypeID);
        }

        public static decimal GetApplicationPrice(string ApplicationTypeName)
        {
            return ApplicationTypesDataTier.GetApplicationPrice(ApplicationTypeName);
        }
        public static DataTable GetApplicationTypes()
        {
            return ApplicationTypesDataTier.GetApplicationTypes();
        }
        public static string GetApplicationTypeName(int ApplicationTypeID)
        {
            return ApplicationTypesDataTier.GetApplicationTypeName(ApplicationTypeID);
        }

        public static bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationTypeFees)
        {
            return ApplicationTypesDataTier.UpdateApplicationType(ApplicationTypeID, ApplicationTypeTitle, ApplicationTypeFees);
        }
    }
}
