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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDProject.Forms
{
    public partial class DetainLicenseFrm : Form
    {
        int PersonID = -1;
        clsLicenses license = new clsLicenses();
        public DetainLicenseFrm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            private void pictureBox1_Click(object sender, EventArgs e)
            {
                if (txtFilterInput.Text.Trim() != " " && txtFilterInput.Text != null)
                {
                    license = clsLicenses.GetLicenseInfoUsingLicenseID(Convert.ToInt16(txtFilterInput.Text));

                    if (license == null)
                    {
                        MessageBox.Show("This License ID Does Not Exist, Please Try Again With A Correct License ID ", "InCorrect License ID",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblDetainedLicenseID.Text = "-1";
                    }

                    else if (license.IsActive == false)
                    {
                        if (ClsDetainedLicenses.IsLicenseDetained(license.LicenseID))
                        {
                            MessageBox.Show("Selected License Is Already Detained ,Choose Another One ", "Not Allowed",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Selected License Is Not Active ", "Not Allowed",
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        LoadLicenseInfo(license);
                        PersonID = clsDriver.GetPersonIDWithDriverID(license.DriverID);
                        LoadPersonInfo(clsPerson.Find(PersonID));
                        lblDetainedLicenseID.Text = txtFilterInput.Text;
                        llLicenseHistory.Enabled = true;
                    }
                    else if (license.IsActive == true)
                    {

                        LoadLicenseInfo(license);
                        PersonID = clsDriver.GetPersonIDWithDriverID(license.DriverID);
                        LoadPersonInfo(clsPerson.Find(PersonID));
                        lblDetainedLicenseID.Text = txtFilterInput.Text;
                        llLicenseHistory.Enabled = true;
                        btnDetain.Enabled = true;
                    }



                }
            }

            private void DetainLicenseFrm_Load(object sender, EventArgs e)
            {
                lblDetainDate.Text = DateTime.Now.ToShortDateString();
                lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            }

            private void btnDetain_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Are You Sure, You want To Detain This License? ", "Detain License", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try {
                        decimal FineFees = Convert.ToDecimal(tbFineFees.Text);
                        if (FineFees >= 50)
                        {
                            clsLicenses.UpdateLicenseStatus(Convert.ToInt16(lblDetainedLicenseID.Text));
                            int DetainID = ClsDetainedLicenses.AddDetainedLicense(Convert.ToInt16(txtFilterInput.Text), DateTime.Now,
                                      FineFees, clsGlobal.CurrentUser.UserID);
                            if (DetainID != -1)
                            {
                                lblLicenseID.Text = DetainID.ToString();
                                llLicenseInfo.Enabled = true;
                                btnDetain.Enabled = false;

                                if (MessageBox.Show("License Detained, Detain ID Is " + DetainID.ToString(), "Detained", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) ;
                                llLicenseInfo.Enabled = true;

                            }
                            else
                            {
                                MessageBox.Show("Something Wrong! ", "Detain Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            } }
                        else if (FineFees < 50)
                            MessageBox.Show("Fine Fees Can Not Be Less Than 50! ", "Add A Valid Fine Fees", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show("Add A Valid Fine Fees! ", "Fine Fees Must Be Added ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                FrmDriverLicenseInfo driverLicenseInfo = new FrmDriverLicenseInfo(PersonID, license.AppID);
                driverLicenseInfo.ShowDialog();
            }

            private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                LicenseHistoryFrm licenseHistoryFrm = new LicenseHistoryFrm(PersonID, license.DriverID);
                licenseHistoryFrm.ShowDialog();
            }
        }
    } 
