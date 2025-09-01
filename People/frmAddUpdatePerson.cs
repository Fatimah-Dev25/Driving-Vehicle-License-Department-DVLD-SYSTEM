using DVLD_Buisness;
using FirstProjectDVLD.GlobalClasses;
using FirstProjectDVLD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;

using System.Windows.Forms;

namespace FirstProjectDVLD.People
{
    public partial class frmAddUpdatePerson : Form
    {
        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);
        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        enum enMode { AddNew = 0, Update = 1 }
        enum enGender { Male = 0,  Female = 1 }

        private enMode _Mode;
        private int _PersonID = -1;
        Person _Person;
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdatePerson(int personId)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = personId;
        }
        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }
        private void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();

            if ( _Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new Person();
            }
            else
            {
                lblTitle.Text = "Update Person";
            }

            if (rbMale.Checked)
               pbPersonImg.Image = Resources.Male_512;
            else 
                pbPersonImg.Image = Resources.Female_512;

            dtBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            dtBirthDate.MinDate = DateTime.Now.AddYears(-100);
            dtBirthDate.Value = dtBirthDate.MaxDate;

            llRemoveImg.Visible = pbPersonImg.ImageLocation != null;

            cbCountry.SelectedIndex = cbCountry.FindString("Jordan");

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }
        private void _LoadData()
        {

            _Person = Person.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show($"No Person with ID = {_PersonID}", "Person not found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                return;
            }

            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text= _Person.SecondName;
            txtThirdName.Text= _Person.ThirdName;    
            txtLastName.Text= _Person.LastName;
            txtPhone.Text= _Person.Phone;
            txtEmail.Text= _Person.Email;
            txtAddress.Text= _Person.Address;
            cbCountry.SelectedIndex = cbCountry.FindString(_Person.Nationality.CountryName);
            txtNational.Text = _Person.NationalNum;
           
            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            if(_Person.ImagePath != null)
            {
                pbPersonImg.ImageLocation = _Person.ImagePath;
            }

            dtBirthDate.Value = _Person.DateOfBirth;

            llRemoveImg.Visible = _Person.ImagePath != "";
            
        }
        private void _FillCountriesInComboBox()
        {
            DataTable AllCountries = Country.GetAllCountries();

            foreach (DataRow row in AllCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }
        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(pbPersonImg.ImageLocation == null)
            {
                pbPersonImg.Image = Resources.Female_512;
            }
        }
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImg.ImageLocation == null)
            {
                pbPersonImg.Image = Resources.Male_512;
            }
        }
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (txtEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!Validation.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, null);
            };

        }
        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtNational.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNational, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNational, null);
            }

            //Make sure the national number is not used by another person
                
            if (txtNational.Text.Trim() != _Person.NationalNum && Person.IsPersonExist(txtNational.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNational, "National Number is used for another person!");

            }
           else
            {
                errorProvider1.SetError(txtNational, null);
            }
        }
        private void llSetImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbPersonImg.ImageLocation = selectedFilePath;
                llRemoveImg.Visible = true;
                // ...
            }
        }
        private void llRemoveImg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbPersonImg.ImageLocation = null;

            if (rbMale.Checked)
                pbPersonImg.Image = Resources.Male_512;
            else
                pbPersonImg.Image = Resources.Female_512;

            llRemoveImg.Visible= false;
        }   
        private bool _HandlePersonImg()
        {
            if(_Person.ImagePath != pbPersonImg.ImageLocation)
            {
                if(_Person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                        
                    }
                    catch (IOException)
                    {

                    }
                        
                }

                if (pbPersonImg.ImageLocation != null)
                {
                    string sourceImageFile = pbPersonImg.ImageLocation.ToString();

                    if (Util.copyImageToProjectImagesFolder(ref sourceImageFile))
                    {
                        pbPersonImg.ImageLocation = sourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
 

            return true;
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some Fileds are not valide!, put mouse over red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (!_HandlePersonImg())
               return;

            int NationalityCountryID = Country.Find(cbCountry.Text).CountryID;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();
            _Person.NationalNum = txtNational.Text.Trim();
            _Person.DateOfBirth = dtBirthDate.Value;
            _Person.NatCountryID = NationalityCountryID;

            if (rbMale.Checked)
                _Person.Gender = (byte)enGender.Male;
            else
                _Person.Gender = (byte)enGender.Female;

            if (pbPersonImg != null)
                _Person.ImagePath = pbPersonImg.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                lblTitle.Text = "Update Person";
                _Mode = enMode.Update;

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBack?.Invoke(this, _Person.PersonID);
            }

            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

      
    }
}
