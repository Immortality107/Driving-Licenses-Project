using DVLDProject.DVLDBusiness;
using DVLDProject.DVLDData;
using PeopleBusinessTier;
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

namespace DVLDProject.Forms
{
    public partial class IssueDriverLicenseFirstTimeFrm : Form
    {
        bool Completed = false;
        string Nationalno = "";
        int AppID = -1;
        public IssueDriverLicenseFirstTimeFrm()
        {
            InitializeComponent();
        }
        public IssueDriverLicenseFirstTimeFrm(int LDLAppID,ClsApplication applicant, string FullName, string Type, string Status, string NationNo)
        {
            InitializeComponent();

            LoadApplicantBasicInfo(applicant, FullName, Type, Status, NationNo);
            LoadDrivingLicenseAppInfo(LDLAppID);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadApplicantBasicInfo(ClsApplication applicant, string FullName, string Type, string Status, string NationNo)
        {
            lblID.Text = applicant.ApplicationID.ToString();
            lblStatus.Text = Status;
            lblFees.Text = applicant.PaidFees.ToString();
            lblType.Text = Type;
            lblApplicant.Text = FullName;
            lblDate.Text = applicant.ApplicationDate.ToString();
            lblStatusDate.Text = applicant.LastStatusDate.ToString();
            lblCreatedBy.Text = clsUser.GetUserNameByUserID(applicant.CreatedByUserID);
            if (Status == "Completed") { Completed = true; }
            Nationalno = NationNo;
            AppID = applicant.ApplicationID;
        }

        public void LoadDrivingLicenseAppInfo(int LDLAppID)
        {
            lblLDLAppID.Text = LDLAppID.ToString();
            string ClassName = "";
            int PassedTests = -1;
            if (ClsApplication.GetAPplicationsViewInfo(LDLAppID, ref ClassName, ref PassedTests))
            {
                lblPassedTests.Text = PassedTests.ToString() + "/3";
                lblAppliedforLicense.Text = ClassName;
            }

            if (Completed == true && PassedTests == 3) { llblLicenseInfo.Enabled = true; }

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure, You want To Issue A License? ", "Issue A New License", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                
                int DriverID = clsDriver.AddNewDriver(clsPerson.GetPersonID(Nationalno) , clsGlobal.CurrentUser.UserID, DateTime.Now);
                if (DriverID != -1)
                {
                    int LicenseID = clsLicenses.AddNewLicense(Convert.ToInt16(lblID.Text), DriverID, ClsLicenseCategory.GetLicenseClassID(lblAppliedforLicense.Text), DateTime.Now,
                                                 DateTime.Now.AddYears(ClsLicenseCategory.GetLicenseValidityLength(ClsLicenseCategory.GetLicenseClassID(lblAppliedforLicense.Text))), 2, tbNotes.Text, Convert.ToDecimal(lblFees.Text), clsGlobal.CurrentUser.UserID, true);

                    if (LicenseID != -1)
                    {

                            ClsApplication.UpdateStatus(Convert.ToInt16(lblID.Text), true);
                        
                            MessageBox.Show("New License Issued Successfully, LicenseID Is " + LicenseID.ToString(), "Congratulations, You Issued A New License", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            llblLicenseInfo.Enabled = true;
                            btnIssue.Enabled = false;
                        
                    }
                }
                else
                    MessageBox.Show("Something Wrong! ", "License Issue Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llblLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
 
                FrmDriverLicenseInfo frmDriverLicenseInfo = new FrmDriverLicenseInfo(clsPeople.GetPersonID(Nationalno), AppID);
                frmDriverLicenseInfo.ShowDialog();
            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

                frmPersonDetails personDetails = new frmPersonDetails(Nationalno);
                personDetails.ShowDialog();
            }
    }
    }

