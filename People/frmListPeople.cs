using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.People
{
    public partial class frmListPeople : Form
    {
        private static DataTable _dtAllPeople = Person.GetAllPeople();

        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "Gender", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

        private void _RefreshPeopleList()
        {
            _dtAllPeople = Person.GetAllPeople();
            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "Gender", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

            dgvPeopleList.DataSource = _dtPeople;
            lblRecordsCount.Text = dgvPeopleList.Rows.Count.ToString();

            for (int i = 0; i < dgvPeopleList.Rows.Count; i++)
            {
                if (i % 2 != 0)
                    dgvPeopleList.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }

        }
        public frmListPeople()
        {
            InitializeComponent();
        }
        private void _EditTableStyle()
        {
           

            dgvPeopleList.Columns[0].HeaderText = "Person ID";
            dgvPeopleList.Columns[0].Width = 90;

            dgvPeopleList.Columns[1].HeaderText = "National No";
            dgvPeopleList.Columns[1].Width = 90;

            dgvPeopleList.Columns[2].HeaderText = "First Name";
            dgvPeopleList.Columns[2].Width = 100;

            dgvPeopleList.Columns[3].HeaderText = "Second Name";
            dgvPeopleList.Columns[3].Width = 100;

            dgvPeopleList.Columns[4].HeaderText = "Third Name";
            dgvPeopleList.Columns[4].Width = 100;

            dgvPeopleList.Columns[5].HeaderText = "Last Name";
            dgvPeopleList.Columns[5].Width = 110;

            dgvPeopleList.Columns[6].HeaderText = "Gender";
            dgvPeopleList.Columns[6].Width = 70;

            dgvPeopleList.Columns[7].HeaderText = "Date Of Birth";
            dgvPeopleList.Columns[7].Width = 110;

            dgvPeopleList.Columns[8].HeaderText = "Nationality";
            dgvPeopleList.Columns[8].Width = 110;

            dgvPeopleList.Columns[9].HeaderText = "Phone";
            dgvPeopleList.Columns[9].Width = 110;

            dgvPeopleList.Columns[10].HeaderText = "Email";
            dgvPeopleList.Columns[10].Width = 110;

            for(int i = 0; i<dgvPeopleList.Rows.Count; i++)
            {
                if (i % 2 != 0)
                    dgvPeopleList.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            }

        }
        private void frmListPeople_Load(object sender, EventArgs e)
        {
           dgvPeopleList.DataSource = _dtPeople;
           cbFilterBy.SelectedIndex = 0;
           lblRecordsCount.Text = dgvPeopleList.Rows.Count.ToString();

            if (dgvPeopleList.Rows.Count > 0)
                _EditTableStyle();

        }

        private void SetDefaultFilter()
        {
            _dtPeople.DefaultView.RowFilter = "";
            lblRecordsCount.Text = dgvPeopleList.Rows.Count.ToString();

        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = cbFilterBy.Text != "None";

            if (txtFilterBy.Visible)
            {
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }

            if(cbFilterBy.Text == "None")
            {
                SetDefaultFilter();

            }
        }
        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;

                case "National No":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Gender":
                    FilterColumn = "Gender";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;
                    
                case "Email":
                    FilterColumn = "Email";
                    break;

                case "None":
                    FilterColumn = "None";
                    break;

            }

            if(txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvPeopleList.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
            {
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}",FilterColumn, txtFilterBy.Text.Trim());
            }
            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn,txtFilterBy.Text.Trim());

            lblRecordsCount.Text = dgvPeopleList.Rows.Count.ToString();
        }
        private void showDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frm = new frmShowPersonDetail((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

        }
        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();

            _RefreshPeopleList();
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshPeopleList();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show($"Are you sure want to delete Person with ID :: [{dgvPeopleList.CurrentRow.Cells[0].Value}]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK){

                if (Person.DeletePerson((int)dgvPeopleList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }
                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void callPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Feature Is Not Implemented Yet!", "Not Ready!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();

            _RefreshPeopleList();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvPeopleList_DoubleClick(object sender, EventArgs e)
        {

            Form frm = new frmShowPersonDetail((int)dgvPeopleList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
