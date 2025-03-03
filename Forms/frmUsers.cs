using DVLDProject.DVLDBusiness.People;
using PeopleData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
//using DVLDProject.Forms;
namespace DVLDProject.Forms
{
    public partial class frmUsers : Form
    {

        private static DataTable _dtAllUsers = UserBusinessTier.clsUser.GetAllUsers();
        private DataTable _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID", "PersonID","FullName", "UserName", "IsActive");
        public frmUsers()
        {
            InitializeComponent();
        }
        private void _RefreshForm()
        {
            _dtAllUsers = UserBusinessTier.clsUser.GetAllUsers();
            _dtUsers = _dtAllUsers.DefaultView.ToTable(false, "UserID", "PersonID","FullName", "UserName",  "IsActive");
            dgvUsers.DataSource = _dtUsers;
            lblRecords.Text = dgvUsers.Rows.Count.ToString();
            txtFilterInput.Visible = (comboBoxFilter.SelectedIndex != 0 && comboBoxFilter.SelectedIndex != 5);

        }

    
        private void frmUsers_Load(object sender, EventArgs e)
        {
             _RefreshForm();
            comboBoxFilter.SelectedIndex = 0;
            txtFilterInput.Visible = (comboBoxFilter.SelectedIndex != 0 && comboBoxFilter.SelectedIndex != 5);

            dgvUsers.DataSource = _dtUsers;
            if (dgvUsers.Rows.Count > 0)
            {

                dgvUsers.Columns[0].HeaderText = "UserID";
                dgvUsers.Columns[0].Width = 110;

                dgvUsers.Columns[1].HeaderText = "Person ID";
                dgvUsers.Columns[1].Width = 120;


                dgvUsers.Columns[2].HeaderText = "FullName";
                dgvUsers.Columns[2].Width = 250;

                dgvUsers.Columns[3].HeaderText = "UserName";
                dgvUsers.Columns[3].Width = 120;


                dgvUsers.Columns[4].HeaderText = "IsActive";
                dgvUsers.Columns[4].Width = 120;


            }
        }
        private void pbAddPerson_Click(object sender, EventArgs e)
        {




            _RefreshForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfo userfrm = new UserInfo();
            userfrm.ShowDialog();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChangePasswordcs frm = new frmChangePasswordcs();
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateForm frm = new AddUpdateForm(Convert.ToInt32( dgvUsers.CurrentRow.Cells[1].Value));
            frm.ShowDialog();
            _RefreshForm();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email Will Be Sent Soon ISA", "Email");

        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone Call Will Be Called Soon ISA", "Call");

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Delete This User?", "Confirm User Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Convert.ToInt32(dgvUsers.CurrentRow.Cells[1].Value) == clsGlobal.CurrentUser.PersonID)
                {
                    MessageBox.Show("User Is Connected, Can Not Be Deleted!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (UserBusinessTier.clsUser.Delete(Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("User Deleted Successfully!", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                _RefreshForm();
            }
            else
                MessageBox.Show("User Deletion Cancelled!", "User Not Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void pbAddUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser frmAddNewUser = new frmAddNewUser();
            frmAddNewUser.ShowDialog();
            _RefreshForm();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _RefreshForm();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxFilter.SelectedIndex == 5)
            {
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;
            }

            else
            {
                txtFilterInput.Visible = true;
                cbIsActive.Visible = false;

            }
            _RefreshForm();
        }

        private void txtFilterInput_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";

            switch (comboBoxFilter.Text)
            {
                case "UserID":
                    FilterColumn = "UserID";
                    break;

                case "PersonID":
                    FilterColumn = "PersonID";
                    break;

                case "FullName":
                    FilterColumn = "FullName";
                    break;

                case "UserName":
                    FilterColumn = "UserName";
                    break;

                case "Is Active":
                    FilterColumn = "None";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if (FilterColumn == "None" || txtFilterInput.Text.Trim() == "")
            {
                _dtUsers.DefaultView.RowFilter = "";
                return;
            }

         else if (FilterColumn == "PersonID" || FilterColumn == "UserID")
            {
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterInput.Text.Trim());
            }
       
            else

                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, txtFilterInput.Text.Trim());

            lblRecords.Text = _dtUsers.Rows.Count.ToString();

        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;
            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtUsers.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecords.Text = _dtUsers.Rows.Count.ToString();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblRecords_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void peopleBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
