using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDProject
{
    public partial class FilterUserControl1 : UserControl
    {
        public FilterUserControl1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FilterUserControl1_Load(object sender, EventArgs e)
        {
            comboBoxFilter.SelectedIndex = 0;
        }
    }
}
