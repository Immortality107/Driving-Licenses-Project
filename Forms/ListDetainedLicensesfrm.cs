using DVLDProject.DVLDBusiness;
using DVLDProject.DVLDData;
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
using static System.Net.Mime.MediaTypeNames;

namespace DVLDProject.Forms
{
    public partial class ListDetainedLicensesfrm : Form
    {
        private static DataTable _dtDetainedLicenses = ClsDetainedLicenses.GetAllDetainedLicenses();
        public ListDetainedLicensesfrm()
        {
            InitializeComponent();
        }
        private void _RefreshForm()
        {
            comboBoxFilter.SelectedIndex = 0;
            _dtDetainedLicenses = ClsDetainedLicenses.GetAllDetainedLicenses();
            dgvDetainedLicenseApps.DataSource = _dtDetainedLicenses;
            lblRecords.Text = dgvDetainedLicenseApps.Rows.Count.ToString();

        }
        private void ListDetainedLicensesfrm_Load(object sender, EventArgs e)
        {
            comboBoxFilter.SelectedIndex = 0;
            dgvDetainedLicenseApps.DataSource = _dtDetainedLicenses;
            if (dgvDetainedLicenseApps.Rows.Count > 0)
            {
                dgvDetainedLicenseApps.Columns[0].HeaderText = "D.ID";
                dgvDetainedLicenseApps.Columns[0].Width = 50;

                dgvDetainedLicenseApps.Columns[1].HeaderText = "L.ID";
                dgvDetainedLicenseApps.Columns[1].Width = 50;

                dgvDetainedLicenseApps.Columns[2].HeaderText = "D.Date";
                dgvDetainedLicenseApps.Columns[2].Width = 70;

                dgvDetainedLicenseApps.Columns[3].HeaderText = "Is Released";
                dgvDetainedLicenseApps.Columns[3].Width = 70;

                dgvDetainedLicenseApps.Columns[4].HeaderText = "Fine Fees";
                dgvDetainedLicenseApps.Columns[4].Width = 70;

                dgvDetainedLicenseApps.Columns[5].HeaderText = "Release Date";
                dgvDetainedLicenseApps.Columns[5].Width = 70;

                dgvDetainedLicenseApps.Columns[6].HeaderText = "N. Number";
                dgvDetainedLicenseApps.Columns[6].Width = 50;


                dgvDetainedLicenseApps.Columns[7].HeaderText = "Full Name";
                dgvDetainedLicenseApps.Columns[7].Width = 120;


                dgvDetainedLicenseApps.Columns[8].HeaderText = "Release App ID";
                dgvDetainedLicenseApps.Columns[8].Width = 100;

                lblRecords.Text = dgvDetainedLicenseApps.Rows.Count.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbAddPerson_Click(object sender, EventArgs e)
        {
            DetainLicenseFrm detainLicenseFrm = new DetainLicenseFrm();
            detainLicenseFrm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseFrm releaseDetainedLicenseFrm = new ReleaseDetainedLicenseFrm();
            releaseDetainedLicenseFrm.ShowDialog();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonDetails personDetails = new frmPersonDetails((dgvDetainedLicenseApps.CurrentRow.Cells[6].Value).ToString());
            personDetails.Show();
        }

        private void issueInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DriverInternationalLicenseInfo driverInternationalLicenseInfo = new DriverInternationalLicenseInfo();
            driverInternationalLicenseInfo.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsPerson.GetPersonID((dgvDetainedLicenseApps.CurrentRow.Cells[6].Value).ToString());
            LicenseHistoryFrm licenseHistory = new LicenseHistoryFrm(PersonID, clsDriver.GetDriverIDWithPersonID(PersonID));
            licenseHistory.Show();
        }

        private void releaseLisenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseDetainedLicenseFrm releaseDetainedLicenseFrm = new ReleaseDetainedLicenseFrm();
            releaseDetainedLicenseFrm.ShowDialog();
        }

        private void cmsDrivers_Opening(object sender, CancelEventArgs e)
        {
            if (Convert.ToBoolean(dgvDetainedLicenseApps.CurrentRow.Cells[3].Value))
            {
                releaseLisenceToolStripMenuItem.Enabled = false;
            }
            else
            {
                releaseLisenceToolStripMenuItem.Enabled = true;
            }
        }

        private void ShowLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDriverLicenseInfo frmDriverLicenseInfo = new FrmDriverLicenseInfo(Convert.ToInt16( dgvDetainedLicenseApps.CurrentRow.Cells[1].Value));
            frmDriverLicenseInfo.ShowDialog();
        }
    }
}
