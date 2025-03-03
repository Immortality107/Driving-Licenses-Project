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
using static DVLDProject.Forms.VisionTestfrm;

namespace DVLDProject.Forms
{
    public partial class TakeTestFrm : Form
    { int AppointmentID = -1;bool Tested = false, Retake = false;
        public TakeTestFrm()
        {
            InitializeComponent();
        }
        public TakeTestFrm(DateTime Testdate, decimal fees, string Trials, int LDLAppID, string Name,
            string Class, int AppointmentId, bool tested=false)
        {
            InitializeComponent();
            lblLDLAppID.Text = LDLAppID.ToString();
            lblClass.Text = Class;
            lblName.Text = Name;
            lblTrial.Text = Trials;
            lblDate.Text = Testdate.ToString();
            lblFees.Text = fees.ToString();
            AppointmentID = AppointmentId;
            Tested=tested;
 
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure, You Want To Apply These Results? - Results are UnChangeable -", "Validate Results"
                 , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int TestID = ClsTests.AddTest(AppointmentID , rbPass.Checked, tbNotes.Text, clsGlobal.CurrentUser.UserID);
                lblTestID.Text = TestID.ToString();

              if (TestID!=-1 && ClsTestAppointments.LockTestAppointment(Convert.ToInt16(lblLDLAppID.Text)))
                {
                    MessageBox.Show("Results Saved Succesfully", "Test Results Validated"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else MessageBox.Show("Failed To Save Results", "Try Again Later"
                      , MessageBoxButtons.OK, MessageBoxIcon.Information);
              btnSave.Enabled = false;
            }
            else
            {
                MessageBox.Show("Results Not Saved", "Results Validation Cancelled"
                 , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TakeTestFrm_Load(object sender, EventArgs e)
        {
            rbPass.Checked = true;
            if (Tested==true)
            {
                bool Passed = false;  int TestID = -1;
              if(  ClsTests.GetTestIDAndTestResult(AppointmentID, ref TestID, ref Passed))
                {
                    lblTestID.Text= TestID.ToString();
                    rbFail.Checked = !Passed;
                    rbPass.Checked = Passed;
                }
                groupBox2.Enabled=false;
                lblChangeNotAllowedNote.Visible = true;
                btnSave.Enabled = false;
            }
        }
    }
}
