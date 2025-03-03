using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDProject;
using WindowsFormsApp1;
using DVLDProject.Forms;
using UserBusinessTier;
using MainScreen;




namespace LoginInitial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (clsUser.Find(mtbUsername.Text, mtbPassword.Text) != null )
            {
                if (clsGlobal.CurrentUser.IsActive == false)
                {
                    MessageBox.Show("This User Is InActive!\nPlease Return To Admin.", MessageBoxIcon.Warning.ToString());
                    return;
                }
                this.Hide();
                MainScreen.MainScreen mainscreen = new MainScreen.MainScreen();
                mainscreen.Show();
           
            }
            else
            {
                MessageBox.Show("UserName/Password Is Invalid.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkRemember_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
