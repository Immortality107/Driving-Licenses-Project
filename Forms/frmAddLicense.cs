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
    public partial class frmAddLicense : Form
    {

        public delegate void databackEventHandler();
        public event databackEventHandler databack;

        int ApplicationType = 1;
        private enum Mode {EnAddNew=1, EnUpdate=2};
        int ApplicationID = -1;

        Mode mode = Mode.EnAddNew;
        
        public frmAddLicense()
        {
            InitializeComponent();
            mode = Mode.EnAddNew;
        }

        public frmAddLicense(int LDLAppID, string NationalNo)
        {
            InitializeComponent();
            mode = Mode.EnUpdate;
            lblApplicationID.Text = LDLAppID.ToString();
            personDetailsUserControl1.LoadPersonInfo(NationalNo);
            groupBox1.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedIndex == 1)
            {
                if (PeopleBusinessTier.clsPerson.Find(Convert.ToInt32(txtFilterInput.Text.Trim())) == null)
                    MessageBox.Show("Person ID " + txtFilterInput.Text + " Is Not Found!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    personDetailsUserControl1.LoadPersonInfo(Convert.ToInt32(txtFilterInput.Text.Trim()));
            }

            else if (comboBoxFilter.SelectedIndex == 0)
            {
                if (PeopleBusinessTier.clsPerson.Find(txtFilterInput.Text.Trim()) == null)
                    MessageBox.Show("National No. " + txtFilterInput.Text + " Is Not Found!");
                else
                    personDetailsUserControl1.LoadPersonInfo(txtFilterInput.Text);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AddUpdateForm addPersonForm1 = new AddUpdateForm();
            addPersonForm1.databack += DataBackEvent;
            addPersonForm1.ShowDialog();
        }

        private void DataBackEvent(object sender, int PersonID)
        {
            // Handle the data received

            comboBoxFilter.SelectedIndex = 1;
            txtFilterInput.Text = PersonID.ToString();
            personDetailsUserControl1.LoadPersonInfo(PersonID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PeopleBusinessTier.clsPerson.IsPersonExist(personDetailsUserControl1.PersonID))
            {
                TPlogininfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages[1];
                btnSave.Enabled = true;
                DataTable classes = ClsLicenseCategory.GetAllClasses();
                foreach(DataRow row in classes.Rows)
                    comboBoxLicenseClasses.Items.Add(row[0].ToString());
                comboBoxLicenseClasses.SelectedIndex = 2;
                tbCreatedBy.Text = clsGlobal.CurrentUser.UserName;
                tbApplicationDate.Text = DateTime.Now.ToString();
                tbApplicationFees.Text = ClsApplicationType.GetApplicationPrice(ApplicationType).ToString();
            }

            else

                MessageBox.Show("PersonID Not Found");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mode == Mode.EnUpdate) //if There Is ANother APplication ?? Same personID but diff Application Service... Needs To SOlve
            {
                ClsLocalDrivingLicenseApplication.Update(Convert.ToInt32(lblApplicationID.Text), ClsLicenseCategory.GetLicenseClassID(comboBoxLicenseClasses.Text));
                MessageBox.Show("Data Saved Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information );
                btnSave.Enabled=false;
                databack?.Invoke(); 
                return;
            }
            if (ClsLocalDrivingLicenseApplication.IsThereNewApplicationForSameLicenseCategory(personDetailsUserControl1.PersonID, ClsLicenseCategory.GetLicenseClassID(comboBoxLicenseClasses.Text)))
            {
                MessageBox.Show("This Person Already Have A License With Same Class", "Not Allowed To Have Two Licenses With Same Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                ApplicationID = ClsApplication.AddNewApp(personDetailsUserControl1.PersonID, Convert.ToDateTime(tbApplicationDate.Text), ApplicationType, 1, DateTime.Now,
                                       Convert.ToDecimal(tbApplicationFees.Text), clsGlobal.CurrentUser.UserID);

                if (ApplicationID != -1)
                {
                    lblApplicationID.Text = ClsLocalDrivingLicenseApplication.AddNew(ApplicationID, ClsLicenseCategory.GetLicenseClassID(comboBoxLicenseClasses.Text)).ToString();
                    MessageBox.Show("Data Saved Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    databack?.Invoke();
                }
                else
                    MessageBox.Show("License Is Not Saved, Feel Free To Try Again!", "Something Wrong");
            }
            btnSave.Enabled = false;
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void frmAddLicense_Load(object sender, EventArgs e)
        {
            comboBoxFilter.SelectedIndex = 0;
        }
    }
}
