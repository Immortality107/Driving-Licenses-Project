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
    public partial class FrmLocalDLAppInfo : Form
    {
        public FrmLocalDLAppInfo(ClsApplication application, string FullName, int LDLAppID, string ClassName, string Status, string NationalNo)
        {
            InitializeComponent();
            CtrlappBasicInfo.LoadApplicantBasicInfo( application, FullName, ClassName, Status, NationalNo);
            CtrlappBasicInfo.LoadDrivingLicenseAppInfo(LDLAppID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CtrlappBasicInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
