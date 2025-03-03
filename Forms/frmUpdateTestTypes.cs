using DVLDProject.DVLDBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDProject.Forms
{
    public partial class frmUpdateTestTypes : Form
    {
        clsTestType clsTestType = new clsTestType();
        public frmUpdateTestTypes()
        {
            InitializeComponent();
        }
        public frmUpdateTestTypes(int TestID, string TestTitle, string TestDescription, decimal TestFees)
        {
            InitializeComponent();
            clsTestType.TestTypeID= TestID;
            clsTestType.TestTypeTitle= TestTitle;
            clsTestType.TestTypeDescription= TestDescription;
            clsTestType.TestTypeFees = TestFees;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateTestTypes_Load(object sender, EventArgs e)
        {
            lblID.Text = clsTestType.TestTypeID.ToString();
            tbTitle.Text = clsTestType.TestTypeTitle.ToString();
            tbTestDescription.Text = clsTestType.TestTypeDescription.ToString();    
            tbFees.Text = clsTestType.TestTypeFees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Confirm Update?", "Update Test Test", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsTestType.UpdateTestType(Convert.ToInt16(lblID.Text), tbTitle.Text, tbTestDescription.Text, Convert.ToDecimal(tbFees.Text)) == true)
                {
                    MessageBox.Show("Test Type Updated Successfully", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Test Type Update Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
