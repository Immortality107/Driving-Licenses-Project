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
using UserBusinessTier;

namespace DVLDProject.Forms
{
    public partial class frmChangePasswordcs : Form
    {
        public frmChangePasswordcs()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePasswordcs_Load(object sender, EventArgs e)
        {
            personDetailsUserControl1.LoadPersonInfo(clsGlobal.CurrentUser.PersonID);
        }

        private void tbCurrentPW_Leave(object sender, EventArgs e)
        {
            //if (tbCurrentPW.Text != Global.Global.Password)
            //{
               
            //}
        }

        private void tbCurrentPW_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            if (tbCurrentPW.Text != clsGlobal.CurrentUser.Password)
            {

                tbCurrentPW.Select();
                errorProvider.SetError(ActiveControl, "Password Is InValid");
                errorProvider.BlinkRate = 3;
            }
            errorProvider.Clear();
        }

        private void tbConfirmPW_Validating(object sender, CancelEventArgs e)
        {

            ErrorProvider errorProvider1 = new ErrorProvider();
            ErrorProvider errorProvider2 = new ErrorProvider();

            if (tbConfirmPW.Text != tbNewPW.Text)
            {

                tbConfirmPW.Select();
                errorProvider1.SetError(ActiveControl, "Password Doesn't Match");
                errorProvider1.BlinkRate = 3;
                tbNewPW.Select();
                errorProvider2.SetError(ActiveControl, "Password Doesn't Match");
                errorProvider2.BlinkRate = 3;

            }
             if (tbConfirmPW.Text == null || tbConfirmPW.Text.Trim() == " ")
            {

                tbConfirmPW.Select();
                errorProvider1.SetError(ActiveControl, "Please Add  Value");
                errorProvider1.BlinkRate = 3;
                tbNewPW.Select();
                errorProvider2.SetError(ActiveControl, "Password Add Value");
                errorProvider2.BlinkRate = 3;

            }
             if (tbNewPW.Text == tbCurrentPW.Text)
            {

                tbConfirmPW.Select();
                errorProvider1.SetError(ActiveControl, "Please Add  New Password");
                errorProvider1.BlinkRate = 3;
                tbNewPW.Select();
                errorProvider2.SetError(ActiveControl, "Password Add New Password");
                errorProvider2.BlinkRate = 3;

            }
            //errorProvider1.Clear(); errorProvider2.Clear();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser.Password = tbNewPW.Text;
            if (clsUser.PasswordChanged(clsGlobal.CurrentUser.UserID, clsGlobal.CurrentUser.Password) == true)
                MessageBox.Show("Password Changed Successfully!");
            else
                MessageBox.Show("Password Not Saved, Please Try Again!");

        }
    }
}
