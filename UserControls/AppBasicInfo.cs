using DVLDProject.DVLDBusiness;
using DVLDProject.Forms;
using PeopleData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserBusinessTier;

namespace DVLDProject.UserControls
{
    public partial class AppBasicInfo : UserControl
    {
        bool Completed = false;
        string Nationalno = "";
        int AppID = -1;
        public AppBasicInfo()
        {
            InitializeComponent();
            
        }
          public void LoadApplicantBasicInfo(ClsApplication applicant, string FullName, string Type, string Status, string NationNo)
        {
            lblID.Text     = applicant.ApplicationID.ToString();
            lblStatus.Text = Status;
            lblFees.Text   = applicant.PaidFees.ToString();
            lblType.Text = Type;
            lblApplicant.Text = FullName;
            lblDate.Text   = applicant.ApplicationDate.ToString();
            lblStatusDate.Text = applicant.LastStatusDate.ToString();
            lblCreatedBy.Text = clsUser.GetUserNameByUserID(applicant.CreatedByUserID); 
            if (Status == "Completed") { Completed = true; }
             Nationalno = NationNo;
            AppID = applicant.ApplicationID;
        }

        public void LoadDrivingLicenseAppInfo(int LDLAppID)
        {
            lblLDLAppID .Text = LDLAppID.ToString();
            string ClassName = "";
            int PassedTests = -1;
           if ( ClsApplication.GetAPplicationsViewInfo(LDLAppID,ref ClassName,ref PassedTests))
            {
                lblPassedTests.Text = PassedTests.ToString() + "/3";
                lblAppliedforLicense.Text = ClassName;
            }

           if (Completed == true && PassedTests == 3) { llblLicenseInfo.Enabled = true; }

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails personDetails = new frmPersonDetails(Nationalno);
            personDetails.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDriverLicenseInfo frmDriverLicenseInfo = new FrmDriverLicenseInfo(clsPeople.GetPersonID( Nationalno), AppID);
            frmDriverLicenseInfo.ShowDialog();
        }

        private void AppBasicInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
