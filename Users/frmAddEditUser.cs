using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.Users
{
    public partial class frmAddEditUser : Form
    {
        enum enMode { AddNew = 0, Update = 1}
        
        enMode _Mode;
        private int _UserID = -1;
        User _User;
        public frmAddEditUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;
        }

        private void _ResetDefualtValues()
        {
            if(_Mode == enMode.AddNew)
            {
                this.Text = "Add User";
                lblFormTitle.Text = "Add New User";
                _User = new User();

                tpLoginInfo.Enabled = false;

                ctrlPersonCardWithFilter.FilterFocus();
            }
            else
            {
                this.Text = "Update User";
                lblFormTitle.Text = "Update User";

                tpLoginInfo.Enabled = true;
                btnSave.Enabled = true;
            }

            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            ckIsActive.Checked = true;

        }
        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _LoadData()
        {
            _User = User.FindByUserID(_UserID);
            ctrlPersonCardWithFilter.FilterEnabled = false;
            //ctrlPersonCardWithFilter.LoadPersonInfo(_User.PersonID);

            if(_User == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            lblUserId.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            ckIsActive.Checked = _User.isActive;
            ctrlPersonCardWithFilter.LoadPersonInfo(_User.PersonID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
  
            }

            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;
            _User.PersonID = ctrlPersonCardWithFilter.PersonID;
            _User.isActive = ckIsActive.Checked;

            if (_User.Save())
            {
                lblUserId.Text = _User.UserID.ToString();
                _Mode = enMode.Update;

                this.Text = "Update User";
                lblFormTitle.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Username cannot be blank!");
                return;
            }
            else
                errorProvider1.SetError(txtUserName, null);

            
            if(_Mode == enMode.AddNew || (_Mode == enMode.Update && _User.UserName != txtUserName.Text.Trim())) {
            
                if(User.isUserExist(txtUserName.Text))
                {
                    errorProvider1.SetError(txtUserName, "username used by another user!");
                    return;

                }
                else
                    errorProvider1.SetError(txtUserName, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
                return;
            }
            else
                errorProvider1.SetError(txtConfirmPassword, null);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Password cannot be blank!");
                return;
            }
            else
                errorProvider1.SetError(txtUserName, null);
        }

        private void btnPersonInfoNext_Click(object sender, EventArgs e)
        {
            if(_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tpLoginInfo.Enabled = true;
                tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                return;
            }

            if(ctrlPersonCardWithFilter.PersonID != -1)
            {
                if (User.isUserExistForPerson(ctrlPersonCardWithFilter.PersonID))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonCardWithFilter.FilterFocus();
                }
                else
                {
                    btnSave.Enabled = true;
                    tpLoginInfo.Enabled = true;
                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
                }  
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilter.FilterFocus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditUser_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilter.FilterFocus();
        }

        private void ctrlPersonCardWithFilter_onPersonSelected(int obj)
        {
            _User.PersonID = obj;
        }
    }
}
