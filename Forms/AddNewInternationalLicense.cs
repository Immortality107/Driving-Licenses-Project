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
    public partial class AddNewInternationalLicense : Form
    {
        int PersonID = -1;
        int DriverID = -1;

        public AddNewInternationalLicense()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtFilterInput.Text != null && txtFilterInput.Text.Trim() != "")
            {
                clsLicenses license = clsLicenses.GetLicenseInfoUsingLicenseID(Convert.ToInt16(txtFilterInput.Text));

                if (clsInternationalLicenses.IsInternationalLicensesExist(license.DriverID))
                {
                    MessageBox.Show("This Driver with LicenseID= " + txtFilterInput.Text + " Already Has An International License", "Only One License For Each Driver ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    internationalDriverLicenseInfoUC1.LoadDriverInfo(license.LicenseID);
                    llLicenseHistory.Enabled = true;
                    llLicenseInfo.Enabled = true;
                    lblLocalLicenseID.Text = txtFilterInput.Text;

                    return;
                }
                if (license.AppID != -1 && license.LicenseClass == 3)
                {
                    internationalDriverLicenseInfoUC1.LoadDriverInfo(license.LicenseID);
                    llLicenseHistory.Enabled = true;
                    btnIssue.Enabled = true;
                    PersonID = clsDriver.GetPersonIDWithDriverID(license.DriverID);
                    DriverID = license.DriverID;
                    lblLocalLicenseID.Text = txtFilterInput.Text;

                }
                else if (license.LicenseClass != 3)
                {
                    MessageBox.Show("License  " + txtFilterInput.Text, "Not With License Class 3", MessageBoxButtons.OK);


                }
                else
                    MessageBox.Show("No Driver License With Driver ID " + txtFilterInput.Text, "Not Found", MessageBoxButtons.OK);
            }

        }
    
            



        private void llLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenseHistoryFrm historyFrm = new LicenseHistoryFrm(PersonID, DriverID);
            historyFrm.ShowDialog();
        }

        private void AddNewInternationalLicense_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = DateTime.Now.ToString();
            lblInternationalIssueDate.Text = DateTime.Now.ToString();
            lblExpiryDate.Text = (DateTime.Now.AddYears(1).ToString());
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            lblFees.Text = ClsApplicationType.GetApplicationPrice(6).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void llLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DriverInternationalLicenseInfo driverInternationalLicenseInfo = new DriverInternationalLicenseInfo(Convert.ToInt16(txtFilterInput.Text));
            driverInternationalLicenseInfo.ShowDialog();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure, You want To Issue An International License? ", "Issue International License", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                int AppID = (ClsApplication.AddNewApp(PersonID, DateTime.Now, 6, 3,
                                                     DateTime.Now, ClsApplicationType.GetApplicationPrice(2),
                                                     clsGlobal.CurrentUser.UserID));
                if (AppID != -1)
                {
                    int InternationalLicenseID = clsInternationalLicenses.IssueInternationalLicense(DriverID, AppID, Convert.ToInt16(txtFilterInput.Text),
                                                                       Convert.ToDateTime(lblApplicationDate.Text), Convert.ToDateTime(lblExpiryDate.Text),
                                                                      clsGlobal.CurrentUser.UserID, true);
                    if (InternationalLicenseID != -1)
                    {
                        lblInternationalAppID.Text = AppID.ToString();
                        lblInternationalLicenseID.Text = InternationalLicenseID.ToString();
                        MessageBox.Show("International License Issued Successfully With ID = " + InternationalLicenseID.ToString(), "Issued Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        llLicenseInfo.Enabled = true;
                        btnIssue.Enabled = false;
                    }
                }
                else
                    MessageBox.Show("Failed To Issue International License", "Try Again Later", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
    }

