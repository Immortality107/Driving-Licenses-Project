using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDProject.DVLDBusiness;
using DVLDProject.DVLDBusiness.People;
using PeopleBusinessTier;
namespace DVLDProject.Forms
{
    public partial class frmDrivers : Form
    {

        private static DataTable _AllDrivers = DVLDBusiness.clsDriver.GetAllDrivers();

        public frmDrivers()
        {
            InitializeComponent();
        }
        private void _RefreshForm()
        {
            _AllDrivers = DVLDBusiness.clsDriver.GetAllDrivers();
            _AllDrivers = _AllDrivers.DefaultView.ToTable(false, "DriverID", "PersonID", "NationalNo", "FullName", "CreatedDate", "NumberOfActiveLicenses");
            comboBoxFilter.SelectedIndex = 0;
            lblRecords.Text = _AllDrivers.Rows.Count.ToString();
            txtFilterInput.Visible = (comboBoxFilter.SelectedIndex != 0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDrivers_Load(object sender, EventArgs e)
        {
            _RefreshForm();
            dgvDrivers.DataSource = _AllDrivers;
            if (dgvDrivers.Rows.Count > 0)
            {
                dgvDrivers.Columns[0].HeaderText = "Driver ID";
                dgvDrivers.Columns[0].Width = 100;

                dgvDrivers.Columns[1].HeaderText = "Person ID";
                dgvDrivers.Columns[1].Width = 100;

                dgvDrivers.Columns[2].HeaderText = "National Number";
                dgvDrivers.Columns[2].Width = 100;

                dgvDrivers.Columns[3].HeaderText = "FullName";
                dgvDrivers.Columns[3].Width = 200;

                dgvDrivers.Columns[4].HeaderText = "Creation Date";
                dgvDrivers.Columns[4].Width = 150;

                dgvDrivers.Columns[5].HeaderText = "IsActive";
                dgvDrivers.Columns[5].Width = 100;
            }


        }

        private void comboBoxFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtFilterInput.Visible = (comboBoxFilter.SelectedIndex != 0);

        }

        private void txtFilterInput_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (comboBoxFilter.SelectedIndex)
            {
                case 1:
                    FilterColumn = "DriverID";
                    break;
                case 2: FilterColumn = "PersonID";
                    break;
                case 3:
                    FilterColumn = "NationalNo";
                    break;
                case 4:
                    FilterColumn = "FullName";
                    break;
                default:
                    FilterColumn = "";
                    break;

            }

            if (txtFilterInput.Text.Trim() == "" || FilterColumn == "")
            {
                _AllDrivers.DefaultView.RowFilter = "";
                return;
            }
             if (FilterColumn != "NationalNo" && FilterColumn != "FullName")
                _AllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterInput.Text.Trim());
            else
                _AllDrivers.DefaultView.RowFilter = string.Format("[{0}] like '{1}%'", FilterColumn, txtFilterInput.Text.Trim());
            lblRecords.Text = _AllDrivers.Rows.Count.ToString();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails personDetails = new frmPersonDetails(Convert.ToInt16(dgvDrivers.CurrentRow.Cells[1].Value));
            personDetails.Show();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgvDrivers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void issueInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverInternationalLicenseInfo driverInternationalLicenseInfo = new DriverInternationalLicenseInfo();
            driverInternationalLicenseInfo.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsPerson.GetPersonID(dgvDrivers.CurrentRow.Cells[2].Value.ToString());
            LicenseHistoryFrm licenseHistory = new LicenseHistoryFrm(PersonID, clsDriver.GetDriverIDWithPersonID(PersonID));
            licenseHistory.Show();
        }

    }
}
