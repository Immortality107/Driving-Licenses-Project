using DVLDProject.DVLDData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDBusiness
{
    internal class ClsLocalDrivingLicenseApplication
    {

        int LocalDrivingLicenseAppID = -1;
      int   ApplicationId = -1;
        int LicenseClassID = -1;


        ClsLocalDrivingLicenseApplication(int LocalDrivingLicenseAppID, int ApplicationId, int LicenseClassID) {
            this.LocalDrivingLicenseAppID = LocalDrivingLicenseAppID;
            this.ApplicationId = ApplicationId;
            this.LicenseClassID = LicenseClassID;
        }
            public static int AddNew(int ApplicationId,int LicenseClassID)
            {
            return LocalDrivingLicenseApplicationDataTier.AddNewLocalLicense(ApplicationId, LicenseClassID);  

            }
        public static bool IsThereNewApplicationForSameLicenseCategory(int ApplicantPersonID, int LicenseClassID)
        {
            return LocalDrivingLicenseApplicationDataTier.IsThereNewApplicationForSameLicenseCategory(ApplicantPersonID, LicenseClassID);
        }
            public static DataTable GetAllLocalLicensesApps()
        {
            return LocalDrivingLicenseApplicationDataTier.GetAllLocalLicenseApps_View();

        }

        public static bool Update(int LocalDLAppID, int ClassID)
        {
            return LocalDrivingLicenseApplicationDataTier.Update(LocalDLAppID, ClassID);

        }
        //public static bool Update_View(int AppID, string DrivingClass, string NationNo, string FullName,
        //                           DateTime ApplicationDate, int PassedTests, string Status)
        //{
        //    return LocalDrivingLicenseApplicationDataTier.Update_View(AppID,DrivingClass, NationNo, FullName,
        //        ApplicationDate,PassedTests, Status);

        //}
        public static int GetLDLAppID( int AppID, int ClassID)
        {
            return LocalDrivingLicenseApplicationDataTier.GetLDLAppID( AppID, ClassID);

        }

        public static int GetAppID(int LDLAppID)
        {
            return LocalDrivingLicenseApplicationDataTier.GetAppID(LDLAppID);

        }
        public static bool Delete(int LDLAppID)
        {
            return LocalDrivingLicenseApplicationDataTier.Delete(LDLAppID);

        }

    }
    }

