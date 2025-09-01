using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DVLD_Buisness;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.Users
{
    public partial class frmChangePassword : Form
    {
        private int _UserID;
        private User _User;
        public frmChangePassword(int userId)
        {
            InitializeComponent();
            _UserID = userId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fields not Valid...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _User.Password = txtNewPassword.Text;
            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.",
                   "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefaultValues();
            }
            else
            {
                MessageBox.Show("An Erro Occured, Password did not change.",
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _ResetDefaultValues()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            _User = User.FindByUserID(_UserID);

            if(_User == null )
            {
                MessageBox.Show($"No User Found with ID {_UserID}!!", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            }

            cuUserCard.LoadUserInfo(_UserID);
        }
        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {

            if(string.IsNullOrEmpty(txtCurrentPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "this field is required!!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }

            if(txtCurrentPassword.Text.Trim() != _User.Password)
            {
                e.Cancel=true;
                errorProvider1.SetError(txtCurrentPassword, "Current Password is wrong!");
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword , null);
            }
        }
        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "this field is required!!");
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, null);
            }
        }
        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "this field is required!!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
            
            if(txtNewPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match New Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword, null);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtCurrentPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            txtNewPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = false;
        }
    }
}
