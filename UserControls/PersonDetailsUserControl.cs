using DVLDProject.Properties;
using PeopleBusinessTier;
using System.Windows.Forms;
using System.IO;
using DVLDProject.Forms;
namespace DVLDProject.DVLDBusiness.People
{
    public partial class PersonDetailsUserControl : UserControl
    {
        public delegate void databackHandler(object sender, int PersonID);
        public event databackHandler DatabackHandler;


        private clsPerson _Person ; 
        private int _PersonID = -1;
        public int PersonID { get { return _PersonID; } }
        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }
        public PersonDetailsUserControl()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int ID)
        {
            _Person = clsPerson.Find(ID);
            if ( _Person == null )
            {
                ResetPersonInfo();
                MessageBox.Show("No Person Found For ID " + ID);
                return;
            }
           
            _FillPersonInfo();

        }
        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);
            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }
        private void _FillPersonInfo()
        {
            llEditPerson.Enabled = true;
            _PersonID = _Person.PersonId;
            lblPersonID.Text = _PersonID.ToString();
            lblAddress.Text = _Person.Address;
            lblBirthDate.Text = _Person.DateofBirth.ToShortDateString();
            lblNationalNo.Text = _Person.NationalNumber;
            lblPhone.Text = _Person.PhoneNumber;
            lblEmail.Text = _Person.Email;
            lblGendor.Text = (_Person.Gender == 0) ? "Male" : "Female";
            
            lblCountry.Text = _Person.Country;
            lblName.Text = _Person.FullName;
            _LoadPersonImage();
        }
        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
                pictureBox2.Image = Resources.Male_512;
            else
                pictureBox2.Image = Resources.Female_512;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pictureBox2.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblName.Text = "[????]";
            pictureBox1.Image = Resources.Man_32;
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblBirthDate.Text = "[????]";
            lblCountry.Text = "[????]";
            lblAddress.Text = "[????]";
            pictureBox2.Image = Resources.Male_512;

        }
  
        private void llEditPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUpdateForm EditForm = new AddUpdateForm(_PersonID);
            EditForm.databack += DataBackEvent;
            EditForm.ShowDialog();
        }
        public void DataBackEvent(object sender, int PersonID)
        {
            _Person = PeopleBusinessTier.clsPerson.Find(PersonID);
            _FillPersonInfo();
        }
        private void lblPersonID_Click(object sender, System.EventArgs e)
        {
            
        }

        private void lblName_Click(object sender, System.EventArgs e)
        {

        }

        private void lblNationalNo_Click(object sender, System.EventArgs e)
        {

        }

        private void lblGendor_Click(object sender, System.EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, System.EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, System.EventArgs e)
        {

        }

        private void lblBirthDate_Click(object sender, System.EventArgs e)
        {

        }
    }
}
