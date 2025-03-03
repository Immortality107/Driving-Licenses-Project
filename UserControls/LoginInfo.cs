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
namespace DVLDProject.UserControls
{
    public partial class LoginInfo : UserControl
    {
        public LoginInfo()
        {
            InitializeComponent();
        }

        private void LoginInfo_Load(object sender, EventArgs e)
        {
            lblUserID.Text = clsGlobal.CurrentUser.UserID.ToString();
            lbUsername.Text = clsGlobal.CurrentUser.UserName.ToString();
            lblIsActive.Text = clsGlobal.CurrentUser.IsActive.ToString();
        }
    }
}
