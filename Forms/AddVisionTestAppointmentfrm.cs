using DVLDProject.DVLDBusiness;
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
using static DVLDProject.Forms.VisionTestfrm;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DVLDProject.Forms
{
    public partial class AddVisionTestAppointmentfrm : Form
    {
        int testtype = 0, AppointmentID = 0;
        bool editmode = false;

        public AddVisionTestAppointmentfrm()
        {
            InitializeComponent();
        }

        public AddVisionTestAppointmentfrm(enTestType testType, string Trials, int LDLAppID, string Name, string Class,
            bool edit = false, int AppointmentId=0)
        {
            InitializeComponent();
            gbRetakeTestInfo.Enabled = Convert.ToInt16(Trials) > 0 && !edit;
            LoadApplicantInfo(testType, Trials, LDLAppID, Name, Class);
            editmode = edit;
            AppointmentID = AppointmentId;
        }

        private void LoadApplicantInfo(enTestType testType, string Trials, int LDLAppID, string Name, string Class)
        {
            groupBox1.Text = testType.ToString() + " Test";
            if (testType == enTestType.Vision)
                pbTestImage.Image = Resources.Vision_512;
            else if (testType == enTestType.Written)
                pbTestImage.Image = Resources.Written_Test_512;
            else if (testType == enTestType.Street)
                pbTestImage.Image = Resources.driving_test_512;
            lblTrial.Text = Trials;
            dateTimePicker1.Value = DateTime.Now;
            if (testType == enTestType.Vision) testtype = 1; else if (testType == enTestType.Written) testtype = 2; else testtype = 3;
            lblFees.Text = (clsTestType.GetTestPrice(testtype)).ToString();

            lblLDLAppID.Text = LDLAppID.ToString();
            lblClass.Text = Class;
            lblName.Text = Name;
            if (gbRetakeTestInfo.Enabled)
                lblRAppFees.Text = ClsApplicationType.GetApplicationPrice(7).ToString();

            lblTotalFees.Text = lblFees.Text;
            //if (Convert.ToInt16(Trials) > 0)
            //{
            //    gbRetakeTestInfo.Enabled = true;
            //}
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int TestID = -1;
            if (editmode == true)
            {
              if( ClsTestAppointments.UpdateAppointmentDate(AppointmentID, Convert.ToDateTime(dateTimePicker1.Value)))
                {
                    MessageBox.Show("Appointment Updated Successfully", "Date Updated",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (gbRetakeTestInfo.Enabled)
            {
               int OldApplicationID = ClsLocalDrivingLicenseApplication.GetAppID(Convert.ToInt16(lblLDLAppID.Text));
                int ApplicantPersonID = -1, ApplicationTypeID = -1, Status = -1, CreatedByUserID = -1;
                decimal PaidFees = -1;
                DateTime dateTime = DateTime.Now, lastStatusDate = DateTime.Now;
               ClsApplication application = ClsApplication.GetAPplicationInfo(OldApplicationID, ref ApplicantPersonID, ref dateTime,
                    ref ApplicationTypeID, ref Status, ref lastStatusDate, ref PaidFees, ref CreatedByUserID);
                ApplicationTypeID = 7; Status = 3;
                int RetakeTestApplicationID = ClsApplication.AddNewApp(ApplicantPersonID, dateTime, ApplicationTypeID, Status,
                    lastStatusDate, ClsApplicationType.GetApplicationPrice(ApplicationTypeID), clsGlobal.CurrentUser.UserID);

                ClsTestAppointments.AddRetakeTestApplicationID(TestID, RetakeTestApplicationID);

                lblRTestAppID.Text = RetakeTestApplicationID.ToString();    
            }
             TestID = ClsTestAppointments.AddAppointment(testtype,Convert.ToInt16(lblLDLAppID.Text),Convert.ToDateTime(dateTimePicker1.Value), Convert.ToDecimal(lblFees.Text),
                                                      clsGlobal.CurrentUser.UserID, false);
            if (TestID != -1)
            {
                MessageBox.Show("Appointment Added Successfully", "Get Ready For The Test", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Failed To Save", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            btnSave.Enabled = false;
        }

        private void AddVisionTestAppointmentfrm_Load(object sender, EventArgs e)
        {
            if (gbRetakeTestInfo.Enabled)
            {
                lblTotalFees.Text =(Convert.ToDecimal( lblFees.Text) + Convert.ToDecimal( ClsApplicationType.GetApplicationPrice(7))).ToString();

            }
        }
    }
}
