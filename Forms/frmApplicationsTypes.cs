using DVLDProject.DVLDBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDProject.Forms
{
    public partial class frmApplicationsTypes : Form
    {

      

        private static DataTable _dtApplicationTypes = ClsApplicationType.GetApplicationTypes();
        public frmApplicationsTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmApplicationsTypes_Load(object sender, EventArgs e)
        {
            dgvApplicationTypes.DataSource = _dtApplicationTypes;

            dgvApplicationTypes.Columns[0].HeaderText = "ID";
            dgvApplicationTypes.Columns[0].Width = 110;

            dgvApplicationTypes.Columns[1].HeaderText = "Title";
            dgvApplicationTypes.Columns[1].Width = 440;

            dgvApplicationTypes.Columns[2].HeaderText = "Fees";
            dgvApplicationTypes.Columns[2].Width = 200;

            lblRecords.Text = dgvApplicationTypes.Rows.Count.ToString();
        }
        private void _Refresh(object sender)
        {
            _dtApplicationTypes = ClsApplicationType.GetApplicationTypes();
            dgvApplicationTypes.DataSource = _dtApplicationTypes;

            dgvApplicationTypes.Columns[0].HeaderText = "ID";
            dgvApplicationTypes.Columns[0].Width = 110;

            dgvApplicationTypes.Columns[1].HeaderText = "Title";
            dgvApplicationTypes.Columns[1].Width = 440;

            dgvApplicationTypes.Columns[2].HeaderText = "Fees";
            dgvApplicationTypes.Columns[2].Width = 200;

            lblRecords.Text = dgvApplicationTypes.Rows.Count.ToString();
        }
        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateApplicationType frmUpdateApplicationType = new frmUpdateApplicationType(Convert.ToInt16(dgvApplicationTypes.CurrentRow.Cells[0].Value),
                                                                dgvApplicationTypes.CurrentRow.Cells[1].Value.ToString(),Convert.ToDecimal(dgvApplicationTypes.CurrentRow.Cells[2].Value) );
            frmUpdateApplicationType.Databack += _Refresh;
            
            frmUpdateApplicationType.ShowDialog();
        }
    }
}
