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
    public partial class frmUpdateApplicationType : Form
    {
        public delegate void DataBackEventHandler(object sender);
        public event DataBackEventHandler Databack;

        public frmUpdateApplicationType(int ApplicationTypeID, string ApplicationTypeName, decimal ApplicationFees)
        {
            InitializeComponent();
            lblID.Text = ApplicationTypeID.ToString();
            tbTitle.Text = ApplicationTypeName.ToString();
            tbFees.Text = ApplicationFees.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ClsApplicationType.UpdateApplicationType(Convert.ToInt16(lblID.Text), tbTitle.Text, Convert.ToDecimal(tbFees.Text)))
            {
                MessageBox.Show("Saved Succerssfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Databack?.Invoke(this);
            }
            else
                MessageBox.Show("Saving Failed", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void frmUpdateApplicationType_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
