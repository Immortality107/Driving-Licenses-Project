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
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            personDetailsUserControl1.LoadPersonInfo(clsGlobal.CurrentUser.PersonID);
        }
    }
}
