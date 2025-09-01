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
    public partial class frmUsersList : Form
    {
        private static DataTable _dtAllUsers;
        public frmUsersList()
        {
            InitializeComponent();
        }
 
        private void frmUsersList_Load(object sender, EventArgs e)
        {
            _dtAllUsers = User.GetAllUsers();
            dgvAllUsers.DataSource = _dtAllUsers;
            cbFilterBy.SelectedIndex = 0;

            lblRecordsCount.Text = dgvAllUsers.Rows.Count.ToString();

            dgvAllUsers.Columns[0].HeaderText = "User ID";
            dgvAllUsers.Columns[0].Width = 90;

            dgvAllUsers.Columns[1].HeaderText = "Person ID";
            dgvAllUsers.Columns[1].Width = 90;

            dgvAllUsers.Columns[2].HeaderText = "Full Name";
            dgvAllUsers.Columns[2].Width = 360;

            dgvAllUsers.Columns[3].HeaderText = "UserName";
            dgvAllUsers.Columns[3].Width = 140;

            dgvAllUsers.Columns[4].HeaderText = "Is Active";
            dgvAllUsers.Columns[4].Width = 90;
        }
        private void pbAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();

            frmUsersList_Load(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if(cbFilterBy.Text == "Is Active")
            {
                cbIsUserActive.Visible = true;
                txtFilterBy.Visible = false;
                cbIsUserActive.Focus();
                cbIsUserActive.SelectedIndex = 0;
            }
            else
            {
                cbIsUserActive.Visible = false;
                txtFilterBy.Visible = cbFilterBy.Text != "None";

                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }


        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditUser();
            frm.ShowDialog();
            frmUsersList_Load(null, null);
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditUser((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmUsersList_Load(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int UserId = (int)dgvAllUsers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show($"Are you sure want to delete User with ID :: [{UserId}]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                if (User.Delete(UserId))
                {
                    MessageBox.Show("User Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmUsersList_Load(null, null);
                }
                else
                    MessageBox.Show("User was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void cbIsUserActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterColumn = "IsActive";
            string FilterValue = cbIsUserActive.Text;

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
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}",FilterColumn,FilterValue);

            lblRecordsCount.Text = dgvAllUsers.Rows.Count.ToString();

        }

        private void txtFilterBy_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Person ID" || cbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFilterBy_TextChanged_1(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "UserName":
                    FilterColumn = "UserName";
                    break;

                case "Is Active":
                    FilterColumn = "IsActive";
                    break;


                default:
                    FilterColumn = "None";
                    break;

            }

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvAllUsers.Rows.Count.ToString();
                return;
            }


            if (FilterColumn != "FullName" && FilterColumn != "UserName")
                //in this case we deal with numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());

            lblRecordsCount.Text = dgvAllUsers.Rows.Count.ToString();


        }
    }
}
