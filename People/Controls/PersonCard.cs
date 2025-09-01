using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using DVLD_Buisness;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstProjectDVLD.Properties;
using System.IO;

namespace FirstProjectDVLD.People.Controls
{
    public partial class PersonCard : UserControl
    {
        private Person _Person;
        private int _PersonID = -1;
        public int PersonID { 
            get { return _PersonID; } 
        }
        public Person SelectedPersonInfo
        {
            get { return _Person; }
        }
        public PersonCard()
        {
            InitializeComponent();
        }
        public void LoadPersonInfo(int perID)
        {
            _Person = Person.Find(perID);
            _PersonID = perID;

            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with PersonID = " + perID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }
        public void LoadPersonInfo(string PersonNationalNo)
        {
            _Person = Person.Find(PersonNationalNo);
            //_PersonID = _Person.PersonID;

            if (_Person == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National Number = " + PersonNationalNo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }
        private void _FillPersonInfo()
        {
            llEditpersonInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            lblpersonID.Text = _Person.PersonID.ToString();
            lblpersonName.Text = _Person.FullName();
            lblpersonNationalNO.Text = _Person.NationalNum;
            lblpersonEmail.Text = _Person.Email;
            lblpersonPhone.Text = _Person.Phone;
            lblpersonGender.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblpersonBirthDate.Text = _Person.DateOfBirth.ToShortDateString();
            lblpersonAddress.Text = _Person.Address;
            lblpersonCountry.Text = _Person.Nationality.CountryName;
            _LoadPersonImage();
        }
        private void _LoadPersonImage()
        {
            if (_Person.Gender == 0)
                pbpersonIMG.Image = Resources.Male_512;
            else
                pbpersonIMG.Image = Resources.Female_512;

            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
            {
                if (File.Exists(ImagePath))
                    pbpersonIMG.ImageLocation = ImagePath;
                else
                    MessageBox.Show($"Could not find this image: {ImagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblpersonID.Text = "[????]";
            lblpersonNationalNO.Text = "[????]";
            lblpersonName.Text = "[????]";
            lblpersonGender.Text = "[????]";
            lblpersonEmail.Text = "[????]";
            lblpersonPhone.Text = "[????]";
            lblpersonBirthDate.Text = "[????]";
            lblpersonCountry.Text = "[????]";
            lblpersonAddress.Text = "[????]";
            pbpersonIMG.Image = Resources.Male_512;
            llEditpersonInfo.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void llEditpersonInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();

            //Refresh
            LoadPersonInfo(_PersonID);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void lblpersonAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
