using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DVLDProject.DVLDData
{
    internal class clsLicenses
    {
     public int DriverID = -1;
     public int LicenseID = -1;
     public int AppID = -1;
     public int LicenseClass = -1;
     public DateTime IssueDate = DateTime.MinValue;
     public DateTime ExpDate = DateTime.MaxValue;
     public byte IssueReasonID = 0;
     public string Notes = "";
     public decimal PaidFees = 0;
     public int CreatedByUserID = -1;
     public bool IsActive = false;
     public bool IsDetained = false;


       public clsLicenses()
        {
        this.DriverID = -1;
        this.LicenseID = -1;
        this.AppID = -1;
        this.LicenseClass = -1;
        this.IssueDate = DateTime.MinValue;
        this.ExpDate = DateTime.MaxValue;
        this.IssueReasonID = 0;
        this.Notes = "";
        this.PaidFees = 0;
        this.CreatedByUserID = -1;
        this.IsActive = false;
        this.IsDetained = false;

        }

        private clsLicenses(int driverID, int licenseID, int appID, int licenseClass, DateTime issueDate, DateTime expDate, byte issueReasonID, string notes, decimal paidFees, int createdByUserID, bool isactive, bool isdetained)
        {
            DriverID = driverID;
            LicenseID = licenseID;
            AppID = appID;
            LicenseClass = licenseClass;
            IssueDate = issueDate;
            ExpDate = expDate;
            IssueReasonID = issueReasonID;
            Notes = notes;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsActive = isactive;
            IsDetained = isdetained;
        }
        public static clsLicenses  GetLicenseInfo(int appID)
        {
            clsLicenses cls = new clsLicenses();
            cls.AppID = appID;
             if (LicensesDataTier.GetLicenseInfo(cls.AppID, ref cls.LicenseID, ref cls.DriverID,ref cls.LicenseClass, ref cls.IssueDate,
                ref cls.ExpDate, ref cls.IssueReasonID, ref cls.Notes, ref cls.PaidFees, ref cls.CreatedByUserID, ref cls.IsActive))
                return cls;
            return new clsLicenses();
        }


        public static DataTable GetLicensesForEachDriver(int DriverID) { 
            return LicensesDataTier.GetLicensesForEachDriverID(DriverID);
        }

        public static clsLicenses GetLicenseInfoUsingLicenseID(int LicenseID)
        {
            clsLicenses cls = new clsLicenses();
            cls.LicenseID = LicenseID;
            if (LicensesDataTier.GetLicenseInfoByLicenceID(cls.LicenseID, ref cls.AppID, ref cls.DriverID, ref cls.LicenseClass, ref cls.IssueDate,
               ref cls.ExpDate, ref cls.IssueReasonID, ref cls.Notes, ref cls.PaidFees, ref cls.CreatedByUserID, ref cls.IsActive))
                return cls;
            return null;
        }

        public static int AddNewLicense(int AppID,  int DriverID, int LicenseClass, DateTime IssueDate,
                DateTime ExpDate, short IssueReasonID, string Notes, decimal PaidFees, int CreatedByUserID, bool IsActive)
        {
            int LicenseID = LicensesDataTier.AddLicense(AppID, DriverID, LicenseClass, IssueDate,
                ExpDate, IssueReasonID, Notes, PaidFees, CreatedByUserID, IsActive);
            return LicenseID;
        }
        public static int  UpdateLicenseStatus(int LicenseID)
        {
            return LicensesDataTier.UpdateLicenseStatus(LicenseID);
        }
    }
}
