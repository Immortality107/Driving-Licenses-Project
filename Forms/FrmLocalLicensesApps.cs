using DVLDProject.DVLDBusiness;
using PeopleBusinessTier;
using PeopleData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDProject.Forms
{

    public partial class FrmLocalLicensesApps : Form
    {
        int ApplicationID= -1;
        ClsApplication application = new ClsApplication();
        private static DataTable LocalLicensesTable = ClsLocalDrivingLicenseApplication.GetAllLocalLicensesApps();

       

        public FrmLocalLicensesApps()
        {
            InitializeComponent();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _RefreshForm()
        {
            comboBoxFilter.SelectedIndex = 0;
            LocalLicensesTable = ClsLocalDrivingLicenseApplication.GetAllLocalLicensesApps();
            dgvLocalLicenseApps.DataSource = LocalLicensesTable;
           lblRecords.Text = dgvLocalLicenseApps.Rows.Count.ToString();
            
        }
        private void FrmLocalLicensesApps_Load(object sender, EventArgs e)
        {
            comboBoxFilter.SelectedIndex = 0;
            dgvLocalLicenseApps.DataSource = LocalLicensesTable  ;
            if (dgvLocalLicenseApps.Rows.Count > 0)
            {
                dgvLocalLicenseApps.Columns[0].HeaderText = "L.D.L AppID";
                dgvLocalLicenseApps.Columns[0].Width = 100;

                dgvLocalLicenseApps.Columns[1].HeaderText = "Driving Class";
                dgvLocalLicenseApps.Columns[1].Width = 200;

                dgvLocalLicenseApps.Columns[2].HeaderText = "National No.";
                dgvLocalLicenseApps.Columns[2].Width = 100;

                dgvLocalLicenseApps.Columns[3].HeaderText = "Full Name";
                dgvLocalLicenseApps.Columns[3].Width = 200;

                dgvLocalLicenseApps.Columns[4].HeaderText = "Application Date";
                dgvLocalLicenseApps.Columns[4].Width = 200;

                dgvLocalLicenseApps.Columns[5].HeaderText = "Passed Tests";
                dgvLocalLicenseApps.Columns[5].Width = 100;

                dgvLocalLicenseApps.Columns[6].HeaderText = "Status";
                dgvLocalLicenseApps.Columns[6].Width = 100;
                lblRecords.Text = dgvLocalLicenseApps.Rows.Count.ToString();
            }
        }

        private void pbAddPerson_Click(object sender, EventArgs e)
        {
            frmAddLicense frmAdd = new frmAddLicense();
            frmAdd.databack+=  Databack ;
            frmAdd.ShowDialog();
            _RefreshForm();
        }
        private void Databack()
        {
 
            _RefreshForm();
        }
        private void txtFilterInput_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (comboBoxFilter.Text)
            {
                case "L.D.L AppID":
                    FilterColumn = "LocalDrivingLicenseApplicationID";
                    break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Status":
                    FilterColumn = "Status";
                    break;

                default:
                    FilterColumn = "";
                    break;

            }

            if (FilterColumn == "" || txtFilterInput.Text.Trim() == "")
            {
                LocalLicensesTable.DefaultView.RowFilter = "";
                return;
            }
            if (FilterColumn == "LocalDrivingLicenseApplicationID")
                LocalLicensesTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterInput.Text.Trim());

            else
                LocalLicensesTable.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterInput.Text.Trim());

            lblRecords.Text = dgvLocalLicenseApps.Rows.Count.ToString();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterInput.Visible = comboBoxFilter.SelectedIndex != 0;

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvLocalLicenseApps.CurrentRow.Cells[5].Value.ToString() == "3" && dgvLocalLicenseApps.CurrentRow.Cells[6].Value.ToString() == "Completed")
            {
                showLicenseToolStripMenuItem.Enabled = true;
                showPersonLicenseHistoryToolStripMenuItem.Enabled = true;
                showApplicationDetailsToolStripMenuItem.Enabled = true;
                editApplicationToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                schedultTestsToolStripMenuItem.Enabled = false;
                issueDrToolStripMenuItem.Enabled = false;
            }
            //---------------------------------
            else if ( dgvLocalLicenseApps.CurrentRow.Cells[6].Value.ToString() == "New")
            {
                showApplicationDetailsToolStripMenuItem.Enabled = true;
                editApplicationToolStripMenuItem.Enabled = true;
                deleteApplicationToolStripMenuItem.Enabled = true;
                cancelApplicationToolStripMenuItem.Enabled = true;
                schedultTestsToolStripMenuItem.Enabled = true;
                if (dgvLocalLicenseApps.CurrentRow.Cells[5].Value.ToString() == "0")
                {
                    scheduleVisionTestToolStripMenuItem.Enabled = true;
                    scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;
                }
                else if (dgvLocalLicenseApps.CurrentRow.Cells[5].Value.ToString() == "1")
                {
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleWrittenTestToolStripMenuItem.Enabled = true;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;
                }
                else if (dgvLocalLicenseApps.CurrentRow.Cells[5].Value.ToString() == "2")
                {
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = true;
                }
                else if (dgvLocalLicenseApps.CurrentRow.Cells[5].Value.ToString() == "3")
                {
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;
                    schedultTestsToolStripMenuItem.Enabled = false;
                    issueDrToolStripMenuItem.Enabled = true;
                }
                showLicenseToolStripMenuItem.Enabled = false;
                showPersonLicenseHistoryToolStripMenuItem.Enabled = false;
            }
            //----------------------------------
            else if (dgvLocalLicenseApps.CurrentRow.Cells[6].Value.ToString() == "Cancelled")
            {
                issueDrToolStripMenuItem.Enabled = false;
                schedultTestsToolStripMenuItem.Enabled = false;
                editApplicationToolStripMenuItem.Enabled = false;
                deleteApplicationToolStripMenuItem.Enabled = false;
                cancelApplicationToolStripMenuItem.Enabled = false;
                showApplicationDetailsToolStripMenuItem.Enabled = true;
                showLicenseToolStripMenuItem.Enabled = true;
                showPersonLicenseHistoryToolStripMenuItem.Enabled= true;
            }
                   
        }

        private void issueDrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationID = ClsLocalDrivingLicenseApplication.GetAppID(Convert.ToInt16(dgvLocalLicenseApps.CurrentRow.Cells[0].Value));
            int ApplicantPersonID = -1, ApplicationTypeID = -1, Status = -1, CreatedByUserID = -1;
            decimal PaidFees = -1;
            DateTime dateTime = DateTime.Now, lastStatusDate = DateTime.Now;
            if (ApplicationID != -1)
            {
                application = ClsApplication.GetAPplicationInfo(ApplicationID, ref ApplicantPersonID, ref dateTime, ref ApplicationTypeID, ref Status, ref lastStatusDate, ref PaidFees, ref CreatedByUserID);
                IssueDriverLicenseFirstTimeFrm issueDriverLicenseFirstTimeFrm = new IssueDriverLicenseFirstTimeFrm(Convert.ToInt16(dgvLocalLicenseApps.CurrentRow.Cells[0].Value),
                    application, dgvLocalLicenseApps.CurrentRow.Cells[3].Value.ToString(), ClsApplicationType.GetApplicationTypeName(ApplicationTypeID),
                     "New", dgvLocalLicenseApps.CurrentRow.Cells[2].Value.ToString());
               issueDriverLicenseFirstTimeFrm.ShowDialog();
               
            }
            _RefreshForm();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddLicense frmUpdate = new frmAddLicense(Convert.ToInt16( dgvLocalLicenseApps.CurrentRow.Cells[0].Value), dgvLocalLicenseApps.CurrentRow.Cells[2].Value.ToString());
            frmUpdate.databack += _RefreshForm;
            frmUpdate.ShowDialog();
        }

      

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationID = ClsLocalDrivingLicenseApplication.GetAppID(Convert.ToInt16(dgvLocalLicenseApps.CurrentRow.Cells[0].Value));
            int ApplicantPersonID = -1, ApplicationTypeID = -1, Status = -1, CreatedByUserID =-1;
            decimal PaidFees = -1;
            DateTime dateTime = DateTime.Now, lastStatusDate = DateTime.Now;
             application = ClsApplication.GetAPplicationInfo(ApplicationID, ref ApplicantPersonID, ref dateTime, ref ApplicationTypeID, ref Status, ref lastStatusDate, ref PaidFees, ref CreatedByUserID);
            FrmLocalDLAppInfo frmLocalDLAppInfo = new FrmLocalDLAppInfo(application, dgvLocalLicenseApps.CurrentRow.Cells[3].Value.ToString(), Convert.ToInt16(dgvLocalLicenseApps.CurrentRow.Cells[0].Value), dgvLocalLicenseApps.CurrentRow.Cells[1].Value.ToString(),
                dgvLocalLicenseApps.CurrentRow.Cells[6].Value.ToString(), dgvLocalLicenseApps.CurrentRow.Cells[2].Value.ToString());
            frmLocalDLAppInfo.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationID = ClsLocalDrivingLicenseApplication.GetAppID(Convert.ToInt16(dgvLocalLicenseApps.CurrentRow.Cells[0].Value));
            FrmDriverLicenseInfo frmDriverLicenseInfo = new FrmDriverLicenseInfo(clsPeople.GetPersonID( dgvLocalLicenseApps.CurrentRow.Cells[2].Value.ToString()),110 );
            frmDriverLicenseInfo.ShowDialog();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("You Are About To Delete This Application, Do You Want To Confirm?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))== DialogResult.Yes)
            {
                if (ClsLocalDrivingLicenseApplication.Delete(Convert.ToInt16(dgvLocalLicenseApps.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Application Deleted Successfully", "Confirm Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshForm();
                }
                else
                    MessageBox.Show("Something wrong, Try Again!", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Deletion Cancelled Successfully", "Application Exists", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationID = ClsLocalDrivingLicenseApplication.GetAppID(Convert.ToInt16(dgvLocalLicenseApps.CurrentRow.Cells[0].Value));

            if ((MessageBox.Show("You Are About To Cancel This Application, Do You Want To Confirm?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                if (ClsApplication.UpdateStatus(ApplicationID))             
                {
                    MessageBox.Show("Application Cancelled Successfully", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshForm();
                }
                else
                    MessageBox.Show("Something wrong, Try Again!", "Cancellation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Cancellation Failed Successfully", "Application Is Active", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void showPersonLicenseHistoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int PersonID = clsPerson.GetPersonID(dgvLocalLicenseApps.CurrentRow.Cells[2].Value.ToString());
            LicenseHistoryFrm licenseHistory = new LicenseHistoryFrm(PersonID, clsDriver.GetDriverIDWithPersonID(PersonID));
            licenseHistory.Show();
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationID = ClsLocalDrivingLicenseApplication.GetAppID(Convert.ToInt16(dgvLocalLicenseApps.CurrentRow.Cells[0].Value));
            int ApplicantPersonID = -1, ApplicationTypeID = -1, Status = -1, CreatedByUserID = -1;
            decimal PaidFees = -1;
            DateTime dateTime = DateTime.Now, lastStatusDate = DateTime.Now;
            application = ClsApplication.GetAPplicationInfo(ApplicationID, ref ApplicantPersonID, ref dateTime, ref ApplicationTypeID, ref Status, ref lastStatusDate, ref PaidFees, ref CreatedByUserID);

            VisionTestfrm visiontest = new VisionTestfrm(Convert.ToInt16(dgvLocalLicenseApps.CurrentRow.Cells[0].Value),
                    application, dgvLocalLicenseApps.CurrentRow.Cells[3].Value.ToString(), ClsApplicationType.GetApplicationTypeName(ApplicationTypeID),
                     "New", dgvLocalLicenseApps.CurrentRow.Cells[2].Value.ToString());
            visiontest.ShowDialog();
            _RefreshForm();

        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationID = ClsLocalDrivingLicenseApplication.GetAppID(Convert.ToInt16(dgvLocalLicenseApps.CurrentRow.Cells[0].Value));
            int ApplicantPersonID = -1, ApplicationTypeID = -1, Status = -1, CreatedByUserID = -1;
            decimal PaidFees = -1;
            DateTime dateTime = DateTime.Now, lastStatusDate = DateTime.Now;
            application = ClsApplication.GetAPplicationInfo(ApplicationID, ref ApplicantPersonID, ref dateTime, ref ApplicationTypeID, ref Status, ref lastStatusDate, ref PaidFees, ref CreatedByUserID);

            WrittenTestFrm writtenTest = new WrittenTestFrm(Convert.ToInt16(dgvLocalLicenseApps.CurrentRow.Cells[0].Value),
                    application, dgvLocalLicenseApps.CurrentRow.Cells[3].Value.ToString(), ClsApplicationType.GetApplicationTypeName(ApplicationTypeID),
                     "New", dgvLocalLicenseApps.CurrentRow.Cells[2].Value.ToString());
            writtenTest.ShowDialog();
            _RefreshForm();

        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationID = ClsLocalDrivingLicenseApplication.GetAppID(Convert.ToInt16(dgvLocalLicenseApps.CurrentRow.Cells[0].Value));
            int ApplicantPersonID = -1, ApplicationTypeID = -1, Status = -1, CreatedByUserID = -1;
            decimal PaidFees = -1;
            DateTime dateTime = DateTime.Now, lastStatusDate = DateTime.Now;
            application = ClsApplication.GetAPplicationInfo(ApplicationID, ref ApplicantPersonID, ref dateTime, ref ApplicationTypeID, ref Status, ref lastStatusDate, ref PaidFees, ref CreatedByUserID);

            StreetTestFrm streetTest = new StreetTestFrm(Convert.ToInt16(dgvLocalLicenseApps.CurrentRow.Cells[0].Value),
                    application, dgvLocalLicenseApps.CurrentRow.Cells[3].Value.ToString(), ClsApplicationType.GetApplicationTypeName(ApplicationTypeID),
                     "New", dgvLocalLicenseApps.CurrentRow.Cells[2].Value.ToString());
            streetTest.ShowDialog();
            _RefreshForm();
        }
    }
}
