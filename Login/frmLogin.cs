using DVLD_Buisness;
using FirstProjectDVLD.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            label1.Text = "WELCOME TO \nDRIVING & VEHICLE \nLICENSE DEPARTMENT \n(DVLD) SYSTEM";

            string Username = "", Password = "";

            if (Global.GetStoredCredential(ref Username, ref Password))
            {
                txtUsername.Text = Username;

                txtPassword.Text = Password;
                txtPassword.UseSystemPasswordChar = true;

                chkRemember.Checked = true;
            }
            else
                chkRemember.Checked = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = User.FindByUserNameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (user != null)
            {
                if (chkRemember.Checked)
                {
                    Global.RememberUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                }
                else
                    Global.RememberUsernameAndPassword("", "");

                if (!user.isActive)
                {
                    txtUsername.Focus();
                    MessageBox.Show("Your account is not active, Contact Admin.","In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Global.CurrentUser = user;
                this.Hide();
                frmMainPage frm = new frmMainPage(this);
                frm.ShowDialog();
            }
            else
            {
                txtUsername.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }
    }
}
