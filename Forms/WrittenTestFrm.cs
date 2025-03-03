using DVLDProject.DVLDBusiness;
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
    public partial class WrittenTestFrm : Form
    {
        private static DataTable _dtTestAppointments;
       VisionTestfrm.enTestType testType =  VisionTestfrm.enTestType.Written;
        int LDLAppId = -1;
        string Fullname = "";
        string Class = "", status = "", Nationalno = "";
        ClsApplication Applicant;
        int TestTypeID = 2;

        public WrittenTestFrm(int LDLAppID, ClsApplication applicant, string FullName, string Type, string Status, string NationNo)
        {
            InitializeComponent();
            appBasicInfo1.LoadApplicantBasicInfo(applicant, FullName, Type, Status, NationNo);
            appBasicInfo1.LoadDrivingLicenseAppInfo(LDLAppID);
            LDLAppId = LDLAppID;
            Fullname = FullName;
            Class = Type;
            status = Status; Nationalno = NationNo;
            Applicant = applicant;
            _dtTestAppointments = ClsTestAppointments.GetAppointmentsWithLDLAppID(LDLAppID, TestTypeID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _Refresh()
        {
            _dtTestAppointments = ClsTestAppointments.GetAppointmentsWithLDLAppID(LDLAppId, TestTypeID);
            dgvAppointments.DataSource = _dtTestAppointments;
            lblRecords.Text = dgvAppointments.Rows.Count.ToString();
            CMAppointments.Enabled = dgvAppointments.Rows.Count > 0;
            appBasicInfo1.LoadDrivingLicenseAppInfo(LDLAppId);

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(lblRecords.Text) > 0 && !Convert.ToBoolean(dgvAppointments.CurrentRow.Cells[3].Value))
            {
                MessageBox.Show("Can not Add Another Appointment", "You Have An Active Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else if (Convert.ToInt16(lblRecords.Text) > 0 && Convert.ToBoolean(dgvAppointments.CurrentRow.Cells[3].Value))
            {
                if (ClsTests.PassedTest(Convert.ToInt16(dgvAppointments.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("You Passed This Test Successfully", "Not Allowed To Add Another Test", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }
            AddVisionTestAppointmentfrm scheduleTest = new AddVisionTestAppointmentfrm(testType, lblRecords.Text, LDLAppId, Fullname, Class);
            scheduleTest.ShowDialog();
            _Refresh();
        }

        private void WrittenTestFrm_Load(object sender, EventArgs e)
        {
            _dtTestAppointments = ClsTestAppointments.GetAppointmentsWithLDLAppID(LDLAppId, TestTypeID);
            dgvAppointments.DataSource = _dtTestAppointments;
            if (dgvAppointments.Rows.Count > 0)
            {
                dgvAppointments.Columns[0].HeaderText = "Appointment ID";
                dgvAppointments.Columns[0].Width = 100;

                dgvAppointments.Columns[1].HeaderText = "Appointment Date";
                dgvAppointments.Columns[1].Width = 150;

                dgvAppointments.Columns[2].HeaderText = "Paid Fees";
                dgvAppointments.Columns[2].Width = 100;

                dgvAppointments.Columns[3].HeaderText = "Is Locked";
                dgvAppointments.Columns[3].Width = 100;

                dgvAppointments.Rows[0].Selected = true;
                lblRecords.Text = dgvAppointments.Rows.Count.ToString();

            }
                CMAppointments.Enabled = dgvAppointments.Rows.Count > 0;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(dgvAppointments.CurrentRow.Cells[3].Value))
            {
                MessageBox.Show("Can Not Edit This Appointment", "Test Done And Appointment Is Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            bool edit = true;

            AddVisionTestAppointmentfrm scheduleTest = new AddVisionTestAppointmentfrm(testType, lblRecords.Text, LDLAppId, 
                Fullname, Class, edit, Convert.ToInt16(dgvAppointments.CurrentRow.Cells[0].Value));
            scheduleTest.ShowDialog();
            _Refresh();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(dgvAppointments.CurrentRow.Cells[3].Value))
            {
                TakeTestFrm takeTest = new TakeTestFrm(Convert.ToDateTime(dgvAppointments.CurrentRow.Cells[1].Value),
          Convert.ToDecimal(dgvAppointments.CurrentRow.Cells[2].Value), lblRecords.Text, LDLAppId, Fullname,
          Class, Convert.ToInt16(dgvAppointments.CurrentRow.Cells[0].Value), true);
                takeTest.ShowDialog();

            }
            else
            {
                TakeTestFrm takeTest = new TakeTestFrm(Convert.ToDateTime(dgvAppointments.CurrentRow.Cells[1].Value),
                 Convert.ToDecimal(dgvAppointments.CurrentRow.Cells[2].Value), lblRecords.Text, LDLAppId, Fullname,
                 Class, Convert.ToInt16(dgvAppointments.CurrentRow.Cells[0].Value));
                takeTest.ShowDialog();
            }
            _Refresh();
        }
    }
}
