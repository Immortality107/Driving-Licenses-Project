using DVLDProject.DVLDBusiness;
using DVLDProject.DVLDData;
using DVLDProject.Forms;
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
    public partial class DriverLicensesUserControl : UserControl
    {
        int DriverID = 0;

        public DriverLicensesUserControl()
        {
            InitializeComponent();
           
        }
        public void LoadLocalLicensesHistory(int DriverId)
        {
            DriverID = DriverId;
        }

        private void DriverLicensesUserControl_Load(object sender, EventArgs e)
        {
            DataTable LocalLicenses = clsLicenses.GetLicensesForEachDriver(DriverID);
            dgvLocalLicenses.DataSource = LocalLicenses;
            if (dgvLocalLicenses.Rows.Count > 0)
            {
                dgvLocalLicenses.Columns[0].HeaderText = "Lic.ID";
                dgvLocalLicenses.Columns[0].Width = 70;

                dgvLocalLicenses.Columns[1].HeaderText = "App.ID";
                dgvLocalLicenses.Columns[1].Width = 70;

                dgvLocalLicenses.Columns[2].HeaderText = "ClassName";
                dgvLocalLicenses.Columns[2].Width = 170;

                dgvLocalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicenses.Columns[3].Width = 110;

                dgvLocalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicenses.Columns[4].Width = 110;

                dgvLocalLicenses.Columns[5].HeaderText = "Is Active";
                dgvLocalLicenses.Columns[5].Width = 70;
            }
            llRecords.Text = dgvLocalLicenses.Rows.Count.ToString();
        }


        private void TcLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable InternationalLicenses = clsInternationalLicenses.GetInternationalLicensesForEachDriver(DriverID);
            dgvInternationalLicenses.DataSource = InternationalLicenses;
            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "International Lic.ID";
                dgvInternationalLicenses.Columns[0].Width = 70;
                dgvInternationalLicenses.Columns[1].HeaderText = "App.ID";
                dgvInternationalLicenses.Columns[1].Width = 70;
                dgvInternationalLicenses.Columns[2].HeaderText = "Issued Using Local License ID";
                dgvInternationalLicenses.Columns[2].Width = 100;
                dgvInternationalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[3].Width = 110;

                dgvInternationalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[4].Width = 110;

                dgvInternationalLicenses.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[5].Width = 70;
            }

            label5.Text = dgvInternationalLicenses.Rows.Count.ToString();
        }

        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDriverLicenseInfo driverLicenseInfo = new FrmDriverLicenseInfo(clsDriver.GetPersonIDWithDriverID(DriverID),Convert.ToInt16( dgvLocalLicenses.CurrentRow.Cells[1].Value) );
            driverLicenseInfo.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDriverLicenseInfo driverLicenseInfo = new FrmDriverLicenseInfo(clsDriver.GetPersonIDWithDriverID(DriverID), Convert.ToInt16(dgvInternationalLicenses.CurrentRow.Cells[1].Value));
            driverLicenseInfo.ShowDialog();
        }
    }
}
