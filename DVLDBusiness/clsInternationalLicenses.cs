using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DVLDProject.DVLDData
{
    internal class clsInternationalLicenses
    {
        public int DriverID = -1;
        public int InternationalLicenseID = -1;
        public int AppID = -1;
        public DateTime IssueDate = DateTime.MinValue;
        public DateTime ExpDate = DateTime.MaxValue;
        public int CreatedByUserID = -1;
        public bool IsActive = false;
  
        public int IssuedUsingLocalLicense = -1;

        public clsInternationalLicenses()
        {
            this.DriverID = -1;
            this.InternationalLicenseID = -1;
            this.IssuedUsingLocalLicense = -1;
            this.AppID = -1;
            this.IssueDate = DateTime.MinValue;
            this.ExpDate = DateTime.MaxValue;
            this.CreatedByUserID = -1;
            this.IsActive = false;

        }

        private clsInternationalLicenses(int driverID, int InternationallicenseID,int issuedUsingLocalLicense, int appID, DateTime issueDate, DateTime expDate, int createdByUserID, bool isactive)
        {
            DriverID = driverID;
            InternationalLicenseID = InternationallicenseID;
            AppID = appID;
            IssueDate = issueDate;
            ExpDate = expDate;
            CreatedByUserID = createdByUserID;
            IsActive = isactive;
            IssuedUsingLocalLicense = issuedUsingLocalLicense;
        }
        //public static clsLicenses GetLicenseInfo(int appID)
        //{
        //    clsLicenses cls = new clsLicenses();
        //    cls.AppID = 110;
        //    if (LicensesDataTier.GetLicenseInfo(cls.AppID, ref cls.LicenseID, ref cls.DriverID, ref cls.LicenseClass, ref cls.IssueDate,
        //       ref cls.ExpDate, ref cls.IssueReasonID, ref cls.Notes, ref cls.PaidFees, ref cls.CreatedByUserID, ref cls.IsActive))
        //        return cls;
        //    return new clsLicenses();
        //}
        public static DataTable GetInternationalLicensesForEachDriver(int DriverID)
        {
            return InternationalLicensesDataTier.GetInternationalLicenseForEachDriverID(DriverID);
        }

        public static DataTable GetInternationalLicenses()
        {
            return InternationalLicensesDataTier.GetInternationalLicenses();
        }


        public static int IssueInternationalLicense(int DriverID, int AppID, int LicenseID, DateTime IssueDate, 
                                                     DateTime expirydate, int UserID, bool IsActive)
        {
            return InternationalLicensesDataTier.IssueNewInternationalLicense(DriverID,AppID, LicenseID, IssueDate, 
                                              expirydate, UserID, IsActive);
        }
        public static bool IsInternationalLicensesExist(int DriverID)
        {
            return InternationalLicensesDataTier.IsPersonHasInternationalLicense(DriverID);
        }

    }
}
