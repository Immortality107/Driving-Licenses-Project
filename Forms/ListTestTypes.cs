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
    public partial class ListTestTypes : Form
    {
        private static DataTable _dtTestTypes = clsTestType.GetTestTypes();
        public ListTestTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _Refresh()
        {
            _dtTestTypes = clsTestType.GetTestTypes();
            dgvTestTypes.DataSource = _dtTestTypes;


            dgvTestTypes.Columns[0].HeaderText = "ID";
            dgvTestTypes.Columns[0].Width = 50;

            dgvTestTypes.Columns[1].HeaderText = "Title";
            dgvTestTypes.Columns[1].Width = 100;

            dgvTestTypes.Columns[2].HeaderText = "Description";
            dgvTestTypes.Columns[2].Width = 600;

            dgvTestTypes.Columns[3].HeaderText = "Fees";
            dgvTestTypes.Columns[3].Width = 100;


            lblRecords.Text = dgvTestTypes.Rows.Count.ToString();
        }
        private void ListTestTypes_Load(object sender, EventArgs e)
        {
            dgvTestTypes.DataSource = _dtTestTypes;

            dgvTestTypes.Columns[0].HeaderText = "ID";
            dgvTestTypes.Columns[0].Width = 50;

            dgvTestTypes.Columns[1].HeaderText = "Title";
            dgvTestTypes.Columns[1].Width = 100;

            dgvTestTypes.Columns[2].HeaderText = "Description";
            dgvTestTypes.Columns[2].Width = 600;

            dgvTestTypes.Columns[3].HeaderText = "Fees";
            dgvTestTypes.Columns[3].Width = 100;

            lblRecords.Text = dgvTestTypes.Rows.Count.ToString();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestTypes frmUpdateTestTypes = new frmUpdateTestTypes(Convert.ToInt16(dgvTestTypes.CurrentRow.Cells[0].Value),
                                                                         dgvTestTypes.CurrentRow.Cells[1].Value.ToString(),
                                                                         dgvTestTypes.CurrentRow.Cells[2].Value.ToString(),
                                                                         Convert.ToDecimal(dgvTestTypes.CurrentRow.Cells[3].Value));
            frmUpdateTestTypes.ShowDialog();
            _Refresh();
        }
    }
}
