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

namespace DVLDProject.Forms
{ 
    public partial class ReplaceLicenseFrm : Form
    {
        int PersonID = -1 ,AppID=-1;
        clsLicenses license = new clsLicenses();
        public ReplaceLicenseFrm()
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
        private void ReplaceLicenseFrm_Load(object sender, EventArgs e)
        {
            rbDamagedLicense.Checked = true;
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblFees.Text = ClsApplicationType.GetApplicationPrice(4).ToString();
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            rbDamagedLicense.Checked = true;
        }

        private void rbDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblFees.Text = ClsApplicationType.GetApplicationPrice(4).ToString();

        }

        private void rbLostLicense_CheckedChanged(object sender, EventArgs e)
        {
            lblFees.Text = ClsApplicationType.GetApplicationPrice(3).ToString();

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
                    lblOldLicenseID.Text = "-1";
                }

               else if (license.IsActive == false)
                {
                    MessageBox.Show("License ID Is Not Active, Choose an Active License " , "Not Allowed",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadLicenseInfo(license);
                    PersonID = clsDriver.GetPersonIDWithDriverID(license.DriverID);
                    LoadPersonInfo(clsPerson.Find(PersonID));
                    lblOldLicenseID.Text = txtFilterInput.Text;
                    llLicenseHistory.Enabled = true;
                }
               else if (license.IsActive == true)
                {
                  
                    LoadLicenseInfo(license);
                    PersonID = clsDriver.GetPersonIDWithDriverID(license.DriverID);
                    LoadPersonInfo(clsPerson.Find(PersonID));
                    lblOldLicenseID.Text = txtFilterInput.Text;
                    llLicenseHistory.Enabled = true;
                    btnIssue.Enabled = true;
                }

            }
        }

        private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryFrm licenseHistoryFrm = new LicenseHistoryFrm(PersonID, license.DriverID);
            licenseHistoryFrm.ShowDialog();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure, You want To Issue A Replacement For This License? ", "Replace License", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                short ApplicationType = 4;

                if (rbLostLicense.Checked)
                    ApplicationType = 3;
                AppID = ClsApplication.AddNewApp(PersonID, DateTime.Now, ApplicationType, 3, DateTime.Now, Convert.ToDecimal(lblFees.Text), clsGlobal.CurrentUser.UserID);
                lblLRAppID.Text = AppID.ToString();
                clsLicenses.UpdateLicenseStatus(Convert.ToInt16(lblOldLicenseID.Text));
                int LicenseID = clsLicenses.AddNewLicense(AppID, license.DriverID, license.LicenseClass, DateTime.Now,
                                                 DateTime.Now.AddYears(10), ApplicationType, license.Notes, Convert.ToDecimal(lblFees.Text), clsGlobal.CurrentUser.UserID, true);
                if (LicenseID != -1)
                {
                    lblLicenseID.Text = LicenseID.ToString();
                    llLicenseInfo.Enabled = true;
                    btnIssue.Enabled = false;

                   MessageBox.Show("License Replaced Successfully,New License ID Is " + LicenseID.ToString(),"Replaced" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    llLicenseInfo.Enabled = true;
                    lblReplacedLicenseID.Text = LicenseID.ToString();
                }
                else
                {
                    MessageBox.Show("Something Wrong! ", "Replacement Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDriverLicenseInfo driverLicenseInfo = new FrmDriverLicenseInfo(PersonID, AppID);
            driverLicenseInfo.ShowDialog();
        }
    }
}
