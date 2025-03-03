using DVLDProject.DVLDBusiness;
using DVLDProject.DVLDData;
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
    public partial class InternationalLicensesfrm : Form
    {
        int ApplicationID = -1;
        ClsApplication application = new ClsApplication();
        private static DataTable InternationalLicensesTable = clsInternationalLicenses.GetInternationalLicenses();
        public InternationalLicensesfrm()
        {
            InitializeComponent();
        }
        private void _RefreshForm()
        {
            comboBoxFilter.SelectedIndex = 0;
            InternationalLicensesTable = clsInternationalLicenses.GetInternationalLicenses();
            dgvInternationalicenseApps.DataSource = InternationalLicensesTable;
            lblRecords.Text = dgvInternationalicenseApps.Rows.Count.ToString();

        }
    

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InternationalLicensesfrm_Load(object sender, EventArgs e)
        {
            comboBoxFilter.SelectedIndex = 0;
            dgvInternationalicenseApps.DataSource = InternationalLicensesTable;
            if (dgvInternationalicenseApps.Rows.Count > 0)
            {
                dgvInternationalicenseApps.Columns[0].HeaderText = "Int. License ID";
                dgvInternationalicenseApps.Columns[0].Width = 100;

                dgvInternationalicenseApps.Columns[1].HeaderText = "Application ID";
                dgvInternationalicenseApps.Columns[1].Width = 100;

                dgvInternationalicenseApps.Columns[2].HeaderText = "Driver ID";
                dgvInternationalicenseApps.Columns[2].Width = 100;

                dgvInternationalicenseApps.Columns[3].HeaderText = "L.License ID";
                dgvInternationalicenseApps.Columns[3].Width = 100;

                dgvInternationalicenseApps.Columns[4].HeaderText = "Issue Date";
                dgvInternationalicenseApps.Columns[4].Width = 200;

                dgvInternationalicenseApps.Columns[5].HeaderText = "Expiriation Date";
                dgvInternationalicenseApps.Columns[5].Width = 200;

                dgvInternationalicenseApps.Columns[6].HeaderText = "Is Active";
                dgvInternationalicenseApps.Columns[6].Width = 100;
                lblRecords.Text = dgvInternationalicenseApps.Rows.Count.ToString();
            }
        }

        private void pbAddPerson_Click(object sender, EventArgs e)
        {
            AddNewInternationalLicense addNew = new AddNewInternationalLicense();
            addNew.ShowDialog();
            _RefreshForm();
        }


        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterInput.Visible = comboBoxFilter.SelectedIndex != 0;

        }

        private void txtFilterInput_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (comboBoxFilter.Text)
            {
                case "International License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;

                case "Application ID":
                    FilterColumn = "ApplicationID";
                    break;

                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Local License ID":
                    FilterColumn = "ApplicationID";
                    break;
                case "Is Active":
                    FilterColumn = "IsActive";
                    break;
                default:
                    FilterColumn = "";
                    break;

            }

            if (FilterColumn == "" || txtFilterInput.Text.Trim() == "")
            {
                InternationalLicensesTable.DefaultView.RowFilter = "";
                return;
            }
            if (FilterColumn == "InternationalLicenseID" || FilterColumn == "ApplicationID"
                || FilterColumn == "DriverID" || FilterColumn == "ApplicationID")
                InternationalLicensesTable.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterInput.Text.Trim());

            else
                InternationalLicensesTable.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterInput.Text.Trim());
            
            lblRecords.Text = dgvInternationalicenseApps.Rows.Count.ToString();

        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails personDetails = new frmPersonDetails(clsDriver.GetPersonIDWithDriverID(Convert.ToInt16(dgvInternationalicenseApps.CurrentRow.Cells[2].Value)));
            personDetails.Show();
        }

        private void issueInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverInternationalLicenseInfo driverInternationalLicenseInfo = new DriverInternationalLicenseInfo();
            driverInternationalLicenseInfo.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsDriver.GetPersonIDWithDriverID(Convert.ToInt16(dgvInternationalicenseApps.CurrentRow.Cells[2].Value));
            LicenseHistoryFrm licenseHistory = new LicenseHistoryFrm(PersonID, Convert.ToInt16(dgvInternationalicenseApps.CurrentRow.Cells[2].Value));
            licenseHistory.Show();
        }
    }
}
