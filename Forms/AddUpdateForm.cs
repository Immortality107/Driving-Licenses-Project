using DVLDProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PeopleBusinessTier;
using DVLDProject.DVLDBusiness;
namespace DVLDProject.Forms
{
    public partial class AddUpdateForm : Form
    {

        public delegate void DatabackEventHandler(object sender, int PersonID);
        public event DatabackEventHandler databack;

        private  clsPerson _Person = new clsPerson();
        private int _PersonID = -1;
        public AddUpdateForm()
        {
            InitializeComponent();
            //Mode = enMode.AddNew;
            FillCountriesInComboBox();

            lblPersonID.Hide();
            _Person.Mode = clsPerson.enMode.AddNew;
        }

        public AddUpdateForm(int Id)
        {
            InitializeComponent();
            label14.Text = "Update Person";
            _Person.Mode = clsPerson.enMode.Update;
            FillCountriesInComboBox();

            FillWithPersonData(Id);
            lblPersonID.Text = Id.ToString();
            lblPersonID.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (PersonImage.ImageLocation == "")
            PersonImage.Image = Resources.Female_512;
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (PersonImage.ImageLocation == "")
                PersonImage.Image = Resources.Male_512;

        }

        private void lnkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SelectedImage = openFileDialog1.FileName;
                if (File.Exists(SelectedImage))
                {
                    PersonImage.ImageLocation = SelectedImage;
                    linkLabel1.Visible = true;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Person.Gender == 0)
                PersonImage.Image = Resources.Male_512;
            else
                PersonImage.Image = Resources.Female_512;
        }

        private void FillCountriesInComboBox()
        {
            DataTable dt = clsCountryDatacs.GetAllCountries();
            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row["CountryName"]);
            }
            comboBox1.SelectedIndex = 50;
        }
        private void FillWithPersonData(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);
            txtFirstName.Text = _Person.FirstName;
            txtSecond.Text = _Person.SecondName;
            txtThird.Text = _Person.ThirdName;
            txtLast.Text = _Person.LastName;
            txtEmail.Text = _Person.Email;
            txtNational.Text = _Person.NationalNumber;
            txtPhone.Text = _Person.PhoneNumber;
            if (_Person.Gender == 0) { rbFemale.Checked = true; } else rbMale.Checked = true;
            txtAddress.Text = _Person.Address;
            dateTimePicker1.Text = _Person.DateofBirth.ToShortDateString(); 
            comboBox1.SelectedIndex = comboBox1.FindString(_Person.Country);
            if (_Person.ImagePath == "")
            {
                if (_Person.Gender == 0)
                    PersonImage.Image = Resources.Male_512;
                else
                    PersonImage.Image = Resources.Female_512;
            }
            else
            {
                PersonImage.ImageLocation = _Person.ImagePath;
                linkLabel1.Visible = true;
            }
        }
        private void AddUpdateForm_Load(object sender, EventArgs e)
        {
            
        }
        private void FillclsPersonWithData()
        {
            _Person.Email = txtEmail.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecond.Text.Trim();
            _Person.ThirdName = txtThird.Text.Trim();
            _Person.LastName = txtLast.Text.Trim();
            _Person.NationalNumber = txtNational.Text.Trim();
            _Person.Country = comboBox1.Text;
            _Person.DateofBirth = dateTimePicker1.Value;
            _Person.PhoneNumber = txtPhone.Text.Trim();
            _Person.ImagePath = (PersonImage.Image == Resources.Male_512) || (PersonImage.Image == Resources.Female_512) ?  "" : PersonImage.ImageLocation ;
            _Person.Gender = (rbFemale.Checked) ? (short)1 : (short)0;
          
        }

      
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the errors", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
               
            }
            FillclsPersonWithData();
            if (_Person.save())
            {
                lblPersonID.Visible = true;
                lblPersonID.Text = _Person.PersonId.ToString();
                MessageBox.Show("Person Info Saved Successfully!");
                databack?.Invoke(this, _Person.PersonId);
            }
            else
                MessageBox.Show("Person Info Is Not Saved, Please Try Again!");
            //if (!_HandlePersonImage())
            //    return;

        }
    }
}
