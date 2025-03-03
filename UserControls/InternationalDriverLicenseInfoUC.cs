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

namespace DVLDProject.UserControls
{
    public partial class InternationalDriverLicenseInfoUC : UserControl
    {
        int PersonID = -1, DriverID = -1;
        public InternationalDriverLicenseInfoUC()
        {
            InitializeComponent();
        }

        private void InternationalDriverLicenseInfoUC_Load(object sender, EventArgs e)
        {

        }

        private void GBDriverLicenseInfo_Enter(object sender, EventArgs e)
        {

        }

        public void LoadDriverInfo(int LicenseID)
        {
            clsLicenses DriverLicense = clsLicenses.GetLicenseInfoUsingLicenseID(LicenseID);
            lblDriverID.Text = DriverLicense.DriverID.ToString();
            lblExpDate.Text = DriverLicense.ExpDate.ToString();
            lblIssueDate.Text = DriverLicense.IssueDate.ToString();
            if (DriverLicense.Notes.ToString() == null || DriverLicense.Notes.ToString() == "")
                lblNotes.Text = "No Notes";
            else
                lblNotes.Text = DriverLicense.Notes.ToString();
            lblLicenseID.Text = DriverLicense.LicenseID.ToString();
            lblIsActive.Text = (DriverLicense.IsActive == true) ? "Yes" : "No";
            lblIssueReason.Text = ClsApplicationType.GetApplicationTypeName(DriverLicense.IssueReasonID);
            DriverID = DriverLicense.DriverID;
            PersonID = clsDriver.GetPersonIDWithDriverID(DriverID);
            clsPerson person = clsPerson.Find(PersonID);
            lblName.Text = person.FullName;
            if (person.Gender == 0) lblGender.Text = "Male";
            else lblGender.Text = "Female";
            if (lblGender.Text == "Male") pbGender.Image = Resources.Man_32; else pbGender.Image = Resources.Woman_32;
            lblDateOfBirth.Text = person.DateofBirth.ToString();
            if (person.ImagePath != "") PersonImage.ImageLocation = person.ImagePath;
            lblNationalID.Text = person.NationalNumber;
            lblClass.Text = ClsLicenseCategory.GetLicenseClassName(DriverLicense.LicenseClass);
            if (ClsDetainedLicenses.IsLicenseDetained(DriverLicense.LicenseID))
            {
                if (!(ClsDetainedLicenses.IsLicenseReleased(DriverLicense.LicenseID)))
                    lblIsDetained.Text = "Yes";
            }
            else
                lblIsDetained.Text = "No";

        
    }
    }
}
