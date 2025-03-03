using DVLDProject.DVLDData;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
namespace DVLDProject.DVLDBusiness
{
    public class ClsApplication
    {
      public int ApplicationID = -1;
      public int ApplicantPersonID = -1;
      public DateTime ApplicationDate = DateTime.Now;
      public int ApplicationTypeID = -1;
      public int ApplicationStatus = -1;
      public DateTime LastStatusDate = DateTime.Now;
      public decimal PaidFees = 0;
      public int CreatedByUserID = clsGlobal.CurrentUser.UserID;

       public  ClsApplication()
        {
            ApplicationID     = -1;
            ApplicantPersonID = -1;
             ApplicationDate  = DateTime.Now;
            ApplicationTypeID = -1;
            ApplicationStatus = -1;
             LastStatusDate   = DateTime.Now;
             PaidFees         = 0;
            CreatedByUserID   = clsGlobal.CurrentUser.UserID;
        }

        private ClsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus,
                        DateTime LastStatusDate, decimal PaidFees,int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
         this.ApplicantPersonID = ApplicantPersonID;
         this. ApplicationDate = ApplicationDate;
         this.ApplicationTypeID = ApplicationTypeID;
         this.ApplicationStatus = ApplicationStatus;
         this.LastStatusDate =  LastStatusDate;
         this.PaidFees = PaidFees;
         this.CreatedByUserID = CreatedByUserID;




        }
        public static int AddNewApp(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID, int ApplicationStatus,
                        DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            return ApplicationsDataTier.AddNewApp(ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus,
                         LastStatusDate, PaidFees, CreatedByUserID);
        }

        public static bool UpdateStatus(int ApplicationID,bool Completed= false)
        {
            return ApplicationsDataTier.UpdateStatus(ApplicationID, DateTime.Now, Completed);
          
         
        }

        public static int IsPersonExists(int ApplicantPersonID)
        {
            return ApplicationsDataTier.GetApplicationIDByPerson(ApplicantPersonID);
        }

        public static ClsApplication GetAPplicationInfo(int ApplicationID,ref int ApplicantPersonID,ref DateTime ApplicationDate, 
                                                       ref int ApplicationTypeID,ref int ApplicationStatus ,ref DateTime LastStatusDate, 
                                                       ref decimal PaidFees , ref int CreatedByUserID)
        {
            ClsApplication application = null;
            //application.ApplicationID = ApplicationID;
            if (ApplicationsDataTier.GetApplicationInfo(ApplicationID, ref ApplicantPersonID, ref ApplicationDate,
                                                         ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
               
                application = new ClsApplication(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID
                    , ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID );
                return application;
         
        }

        public static bool GetAPplicationsViewInfo(int LDLApplicationID,ref string classname,ref int PassedTests)
        {
            return ApplicationsDataTier.GetApplicationsViewInfo( LDLApplicationID, ref classname, ref PassedTests );
        }
    }
}
