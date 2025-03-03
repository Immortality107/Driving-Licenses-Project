using DVLDProject.DVLDData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDBusiness
{
    internal class ClsDetainedLicenses
    {
        int DetainID = -1;
        int LicenseID = -1;
        DateTime DetainDate = DateTime.Now;
        decimal FineFees = 0;
        int CreatedByUserID = -1;
        byte IsReleased = 0;
        DateTime ReleaseDate = DateTime.Now;
        int ReleasedByUserID = -1;
        int ReleaseApplicationID = -1;

        public static DataTable GetAllDetainedLicenses()
        {
            return DetainedLicensesDataTier.GetDetainedLicenses();
        }
        public static bool IsLicenseDetained(int LicenseID)
        {
            return DetainedLicensesDataTier.IsLicenseDetained(LicenseID);
        }
        public static bool IsLicenseReleased(int LicenseID)
        {
            return DetainedLicensesDataTier.IsLicenseReleased(LicenseID);
        }
        public static int AddDetainedLicense(int LicenseID, DateTime DetainDate, decimal FineFees, int createdByUserID)
        {
           
            int DetainID = DetainedLicensesDataTier.AddDetainedLicense(LicenseID, DetainDate, FineFees, createdByUserID);
            return DetainID;
        }
        public static bool IsDetainInfoFilled(int LicenseID, ref int DetainID,ref int CreatedByUserID, ref DateTime DetainDate, ref decimal FineFees)
        {
            return DetainedLicensesDataTier.GetDetainedLicenseInfo(LicenseID, ref DetainID,ref CreatedByUserID, ref DetainDate, ref FineFees);
        }
        public static bool IsReleasedAndReleaseInfoAdded(int LicenseID, DateTime ReleaseDate, int ReleasedByUserID, int AppID) {
        
        return DetainedLicensesDataTier.IsReleasedAndReleaseInfoAdded(LicenseID, ReleaseDate, ReleasedByUserID, AppID);
        }
    }
}
