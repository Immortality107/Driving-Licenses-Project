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
    public partial class FrmDriverLicenseInfo : Form
    {
        int LicenseID = -1;
        int PersonID = -1;
        int AppID = -1;
        public FrmDriverLicenseInfo(int personID, int AppId)
        {
            InitializeComponent();
            PersonID = personID;
            AppID = AppId;
        }
        public FrmDriverLicenseInfo(int LicenseId)
        {
            InitializeComponent();
            LicenseID = LicenseId;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadPersonInfo(clsPerson person) {
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
                lblNotes.Text = DriverLicense.Notes.ToString();
            lblLicenseID.Text = DriverLicense.LicenseID.ToString();
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
            else
                lblIsDetained.Text = "No";
              
        }
        private void FrmDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            clsLicenses DriverLicense = new clsLicenses();
            clsPerson clsPerson = new clsPerson();
            if (AppID != -1)
            {
                 
                DriverLicense = clsLicenses.GetLicenseInfo(AppID);

            }

            else
            {

                DriverLicense = clsLicenses.GetLicenseInfoUsingLicenseID(LicenseID);  
                PersonID = clsDriver.GetPersonIDWithDriverID(DriverLicense.DriverID);

            }
            clsPerson = PeopleBusinessTier.clsPerson.Find(PersonID);
            LoadPersonInfo(clsPerson);
            LoadLicenseInfo(DriverLicense);
        }
    }
}
