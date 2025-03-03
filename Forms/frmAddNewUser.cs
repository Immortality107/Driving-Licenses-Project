using DVLDProject.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserBusinessTier;

namespace DVLDProject.Forms
{
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }
       
        private void TPpersonalinfo_Click(object sender, EventArgs e)
        {
        }

        private void PBAddPerson_Click(object sender, EventArgs e)
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
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (PeopleBusinessTier.clsPerson.IsPersonExist(personDetailsUserControl1.PersonID) && !clsUser.IsPersonExistInUsers(personDetailsUserControl1.PersonID))
            {
                TPlogininfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages[1];
                btnSave.Enabled = true;
            }
            else if (clsUser.IsPersonExistInUsers(personDetailsUserControl1.PersonID)) {
                MessageBox.Show("This Person Already Is A User", "Each User Can Have Only One Account",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else

                MessageBox.Show("PersonID Not Found");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbConfirmPW.Text != "" && tbConfirmPW.Text == tbPW.Text)
            {
                if (tbUserName.Text.Trim() != "")
                {
                    clsUser user = new clsUser();
                    int UserID = user.AddNewUser(personDetailsUserControl1.PersonID, tbUserName.Text, tbPW.Text, chkIsActive.Checked ? true : false);
                    if (UserID != -1)
                    {
                        lblUserID.Text = UserID.ToString();
                        MessageBox.Show("User Saved Successfully");
                    }
                    else
                        MessageBox.Show("User Is Not Saved, Please Try Again", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                   
            }
            else if (tbConfirmPW.Text != "" && tbPW.Text != "" && tbConfirmPW.Text != tbPW.Text)
            {
                errorProvider1 = new ErrorProvider();
                errorProvider1.SetError(tbConfirmPW, "Passwords Doesn't Match!");

            }

            else
                MessageBox.Show("Can Not Save Now ", "Please Fix Issues", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void PBSearchPerson_Click(object sender, EventArgs e)
        {

            //if (comboBoxFilter.Text == "Person ID" || comboBoxFilter.Text == "User ID")
            //    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (comboBoxFilter.SelectedIndex == 1)
            {
                if (PeopleBusinessTier.clsPerson.Find(Convert.ToInt32(txtFilterInput.Text.Trim())) == null)
                    MessageBox.Show("Person ID " + txtFilterInput.Text + " Is Not Found!","", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void tbConfirmPW_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            TPlogininfo.Enabled = false;
            comboBoxFilter.SelectedIndex = 1;
        }
    }
}
