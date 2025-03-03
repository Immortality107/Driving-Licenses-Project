using DVLDProject.DVLDBusiness.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDProject.Forms
{
    public partial class frmPersonDetails : Form
    {
        public frmPersonDetails(int ID )
        {
            InitializeComponent();
            personDetailsUserControl1.LoadPersonInfo(ID);
        }
        public frmPersonDetails(string NationalNo)
        {
            InitializeComponent();
            personDetailsUserControl1.LoadPersonInfo(NationalNo);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personDetailsUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
