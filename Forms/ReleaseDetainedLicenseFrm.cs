using DVLDProject.DVLDBusiness;
using DVLDProject.DVLDData;
using DVLDProject.Properties;
using PeopleBusinessTier;
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
    public partial class ReleaseDetainedLicenseFrm : Form
    { 
        int PersonID = -1 , ApplicationType = 5;
        clsLicenses license = new clsLicenses();
        public ReleaseDetainedLicenseFrm()
        {
            InitializeComponent();
        }
        private void LoadPersonInfo(clsPerson person)
        {
            lblName.Text = person.FullName;
            if (person.Gender == 0) lblGender.Text = "Male";
            else lblGender.Text = "Female";
            if (lblGender.Text == "Male") pbGender.Image = Resources.Man_32; else pbGender.Image = Resources.Woman_32;
            lblDateOfBirth.Text = person.DateofBirth.ToString();
            if (person.ImagePath != "") PersonImage.ImageLocation = person.ImagePath;
            lblNationalID.Text = person.NationalNumber;
        }

        private void LoadLicenseInfo(clsLicenses DriverLicense)
        {
            lblDriverID.Text = DriverLicense.DriverID.ToString();
            lblExpDate.Text = DriverLicense.ExpDate.ToShortDateString();
            lblIssueDate.Text = DriverLicense.IssueDate.ToShortDateString();
            if (DriverLicense.Notes.ToString().Trim() == "")
                lblNotes.Text = "No Notes";
            else
                lblNotes.Text = DriverLicense.Notes.ToString(); lblLicenseID.Text = DriverLicense.LicenseID.ToString();
            lblIsActive.Text = (DriverLicense.IsActive == true) ? "Yes" : "No";
            lblIssueReason.Text = ClsApplicationType.GetApplicationTypeName(DriverLicense.IssueReasonID);
            lblClass.Text = ClsLicenseCategory.GetLicenseClassName(DriverLicense.LicenseClass);


            if (ClsDetainedLicenses.IsLicenseDetained(DriverLicense.LicenseID))
            {
                if (!(ClsDetainedLicenses.IsLicenseReleased(DriverLicense.LicenseID)))
                    lblIsDetained.Text = "Yes";

                else
                    lblIsDetained.Text = "No";
            }
        }
        private void LoadDetainInfo(int DetainID, DateTime DetainDate, int CreatedByUserID, decimal FineFees)
        {
            lblDetainID.Text = DetainID.ToString();
            lblDetainDate.Text = DetainDate.ToString();
            lblFineFees.Text = FineFees.ToString();
            lblCreatedBy.Text = clsUser.GetUserNameByUserID(CreatedByUserID);
            llLicenseHistory.Enabled = true;
            btnRelease.Enabled = true;
            lblAppFees.Text = ClsApplicationType.GetApplicationPrice(ApplicationType).ToString();
            lblTotalFees.Text = (ClsApplicationType.GetApplicationPrice(ApplicationType) + FineFees) .ToString();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure, You want To Release This License? ", "Release License", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int AppID = ClsApplication.AddNewApp(PersonID, DateTime.Now, ApplicationType, 3, DateTime.Now,
                                                     Convert.ToDecimal(lblAppFees.Text), clsGlobal.CurrentUser.UserID);
                if (AppID != -1)
                {
                    clsLicenses.UpdateLicenseStatus(license.LicenseID);
                    if (ClsDetainedLicenses.IsReleasedAndReleaseInfoAdded(license.LicenseID, DateTime.Now, 
                                                                  clsGlobal.CurrentUser.UserID, AppID))
                    {
                        lblAppID.Text = AppID.ToString();
                        MessageBox.Show("License Released Successfully " , "License Activateed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llLicenseInfo.Enabled = true;
                        btnRelease.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong! ", "Release Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }




            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryFrm licenseHistoryFrm = new LicenseHistoryFrm(PersonID, license.DriverID);
            licenseHistoryFrm.ShowDialog();
        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDriverLicenseInfo driverLicenseInfo = new FrmDriverLicenseInfo(PersonID, license.AppID);
            driverLicenseInfo.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtFilterInput.Text.Trim() != " " && txtFilterInput.Text != null)
            {
                license = clsLicenses.GetLicenseInfoUsingLicenseID(Convert.ToInt16(txtFilterInput.Text));

                if (license == null)
                {
                    MessageBox.Show("This License ID Does Not Exist, Please Try Again With A Correct License ID ", "InCorrect License ID",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblLicenseID.Text = "-1";
                }

                else if ( license.IsActive == true )
                {
                    MessageBox.Show("Selected License Is Not Detained ", "Not Allowed",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadLicenseInfo(license);
                    PersonID = clsDriver.GetPersonIDWithDriverID(license.DriverID);
                    LoadPersonInfo(clsPerson.Find(PersonID));
                    lblLicenseID.Text = txtFilterInput.Text;
                    llLicenseHistory.Enabled = true;

                }
                else if (license.IsActive == false)
                {
                    lblLicenseID.Text = txtFilterInput.Text;
                    if (ClsDetainedLicenses.IsLicenseDetained(license.LicenseID))
                    {
                        DateTime DetainDate = DateTime.MinValue;
                        int DetainID = -1, CreatedByUserID=-1;
                        decimal FineFees = 0;
                    LoadLicenseInfo(license);
                    PersonID = clsDriver.GetPersonIDWithDriverID(license.DriverID);
                    LoadPersonInfo(clsPerson.Find(PersonID));
                        lblLicenseID.Text = txtFilterInput.Text;

                        if (ClsDetainedLicenses.IsDetainInfoFilled(license.LicenseID,ref DetainID,ref CreatedByUserID, ref DetainDate, ref FineFees))
                        {
                            LoadDetainInfo(DetainID, DetainDate, CreatedByUserID, FineFees);
                        }

                    
                }
                
                }
 



            }
        }
    }
}
