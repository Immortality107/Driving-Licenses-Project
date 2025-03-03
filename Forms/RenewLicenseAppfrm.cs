using DVLDProject.DVLDBusiness;
using DVLDProject.DVLDData;
using DVLDProject.Properties;
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

namespace DVLDProject.Forms
{
    public partial class RenewLicenseAppfrm : Form
    {
        int PersonID = -1; clsLicenses license = new clsLicenses();
        public RenewLicenseAppfrm()
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
            label3.Text = DriverLicense.IssueDate.ToShortDateString();
            if (DriverLicense.Notes.ToString().Trim() == "")
                lblNotes.Text = "No Notes";
            else
                lblNotes.Text = DriverLicense.Notes.ToString();
            lblLicenseID.Text = DriverLicense.LicenseID.ToString();
            lblIsActive.Text = (DriverLicense.IsActive == true) ? "Yes" : "No";
            lblIssueReason.Text = ClsApplicationType.GetApplicationTypeName(DriverLicense.IssueReasonID);
            lblClass.Text = ClsLicenseCategory.GetLicenseClassName(DriverLicense.LicenseClass);


            if (ClsDetainedLicenses.IsLicenseDetained(DriverLicense.LicenseID))
            {
                if (!(ClsDetainedLicenses.IsLicenseReleased(DriverLicense.LicenseID)))
                    lblIsDetained.Text = "Yes";
            }
            else
                lblIsDetained.Text = "No";
        
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtFilterInput.Text != null && txtFilterInput.Text.Trim() != "")
            {
                 license = clsLicenses.GetLicenseInfoUsingLicenseID(Convert.ToInt16(txtFilterInput.Text));
                
                if (DateTime.Now <= license.ExpDate)
                {
                    MessageBox.Show("License Has Not Expired Yet, You Can Renew After : " + license.ExpDate.ToShortDateString() , "Not Allowed",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadLicenseInfo(license);
                    LoadPersonInfo(clsPerson.Find( clsDriver.GetPersonIDWithDriverID(license.DriverID)));
                    llLicenseHistory.Enabled= true;

                }
                else if (DateTime.Now > license.ExpDate) {

                    LoadLicenseInfo(license);
                    LoadPersonInfo(clsPerson.Find(clsDriver.GetPersonIDWithDriverID(license.DriverID)));
                    llLicenseHistory.Enabled = true;
                    btnRenew.Enabled = true;
                    PersonID = clsDriver.GetPersonIDWithDriverID(license.DriverID);
                    lblOldLicenseID.Text = txtFilterInput.Text;
                    lblLicenseFees.Text = "20";
                    lblTotalFees.Text = (Convert.ToDecimal(lblAppFees.Text) + Convert.ToDecimal(lblLicenseFees.Text)).ToString();

                }

            }
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void RenewLicenseAppfrm_Load(object sender, EventArgs e)
        {
            lblOldLicenseID.Text = txtFilterInput.Text;
            lblApplicationDate.Text = DateTime.Now.ToString();
            lblIssueDate.Text = DateTime.Now.ToString();
            lblExpiryDate.Text = (DateTime.Now.AddYears(10).ToString());
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            lblAppFees.Text = ClsApplicationType.GetApplicationPrice(2).ToString();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure, You want To Renew This License? ", "Renew License", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int AppID = ClsApplication.AddNewApp(PersonID, DateTime.Now, 2, 3,
                                                     DateTime.Now, ClsApplicationType.GetApplicationPrice(2),
                                                     clsGlobal.CurrentUser.UserID);
                license.AppID = AppID;
                int LicenseID = clsLicenses.AddNewLicense(AppID, license.DriverID, license.LicenseClass, DateTime.Now,
                                             DateTime.Now.AddYears(ClsLicenseCategory.GetLicenseValidityLength(license.LicenseClass)), 2, tbNotes.Text, Convert.ToDecimal(lblTotalFees.Text), clsGlobal.CurrentUser.UserID, true);
                if (LicenseID != -1 && license.IsActive == true)
                {

                    lblRenewAppID.Text = AppID.ToString();
                    MessageBox.Show("License Renewed Successfully With ID " + LicenseID.ToString(), "Renewed Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblRenewedLicenseID.Text = LicenseID.ToString();
                    llLicenseInfo.Enabled = true;
                    btnRenew.Enabled = false;
                }
             else if (LicenseID != -1 && license.IsActive == false)
                    MessageBox.Show("License Is Not Active,You Need To Activate License First " ,"Renew Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else
                    MessageBox.Show("Something Wrong! ", "Expiriration Date Renew Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDriverLicenseInfo  driverLicenseInfo = new FrmDriverLicenseInfo(PersonID,license.AppID );
            driverLicenseInfo.ShowDialog();
        }

        private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryFrm historyFrm = new LicenseHistoryFrm(PersonID, license.DriverID);
            historyFrm.ShowDialog();
        }
    }
}