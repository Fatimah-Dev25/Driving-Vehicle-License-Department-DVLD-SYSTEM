using FirstProjectDVLD.licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_Buisness;
using System.Windows.Forms;
using FirstProjectDVLD.People;
using FirstProjectDVLD.licenses.InternationalLicenses;

namespace FirstProjectDVLD.Applications.InternationalLicenses
{
    public partial class frmListInternationalLicenseApplications : Form
    {
        private DataTable _dtInternationalLicenseApplications;

        public frmListInternationalLicenseApplications()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txtFilterBy.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }

            else

            {

                txtFilterBy.Visible = (cbFilterBy.Text != "None");
                cbIsActive.Visible = false;

                if (cbFilterBy.Text == "None")
                {
                    txtFilterBy.Enabled = false;
                    //_dtDetainedLicenses.DefaultView.RowFilter = "";
                    //lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();

                }
                else
                    txtFilterBy.Enabled = true;

                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }
        }




        private void btnAddInterApplication_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicenseApplication frm = new frmNewInternationalLicenseApplication();
            frm.ShowDialog();

            frmListInternationalLicenseApplications_Load(null, null);
        }

        private void cbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txtFilterBy.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }

            else

            {

                txtFilterBy.Visible = (cbFilterBy.Text != "None");
                cbIsActive.Visible = false;

                if (cbFilterBy.Text == "None")
                {
                    txtFilterBy.Enabled = false;
                    //_dtDetainedLicenses.DefaultView.RowFilter = "";
                    //lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();

                }
                else
                    txtFilterBy.Enabled = true;

                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

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
                _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsCount.Text = dgvAllInternatiolLicenses.Rows.Count.ToString();

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {

            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilterBy.Text)
            {
                case "International License ID":
                    FilterColumn = "InternationalLicenseID";
                    break;
                case "Application ID":
                    {
                        FilterColumn = "ApplicationID";
                        break;
                    };

                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;

                case "Local License ID":
                    FilterColumn = "IssuedUsingLocalLicenseID";
                    break;

                case "Is Active":
                    FilterColumn = "IsActive";
                    break;


                default:
                    FilterColumn = "None";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvAllInternatiolLicenses.Rows.Count.ToString();
                return;
            }



            _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());

            lblRecordsCount.Text = dgvAllInternatiolLicenses.Rows.Count.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void showLicenseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseInfo frm = new frmInternationalLicenseInfo((int)dgvAllInternatiolLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();       

        }

        private void dgvAllInternatiolLicenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showPersonDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternationalLicense internationlLicense = InternationalLicense.Find((int)dgvAllInternatiolLicenses.CurrentRow.Cells[0].Value);

            frmShowPersonDetail frm = new frmShowPersonDetail(internationlLicense.DriverInfo.PersonID);
            frm.ShowDialog();

        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            InternationalLicense internationlLicense = InternationalLicense.Find((int)dgvAllInternatiolLicenses.CurrentRow.Cells[0].Value);

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(internationlLicense.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void frmListInternationalLicenseApplications_Load(object sender, EventArgs e)
        {
            _dtInternationalLicenseApplications = InternationalLicense.GetAllInternationalLicenses();
            cbFilterBy.SelectedIndex = 0;

            dgvAllInternatiolLicenses.DataSource = _dtInternationalLicenseApplications;
            lblRecordsCount.Text = dgvAllInternatiolLicenses.Rows.Count.ToString();

            if (dgvAllInternatiolLicenses.Rows.Count > 0)
            {
                dgvAllInternatiolLicenses.Columns[0].HeaderText = "Int.License ID";
                dgvAllInternatiolLicenses.Columns[0].Width = 140;

                dgvAllInternatiolLicenses.Columns[1].HeaderText = "Application ID";
                dgvAllInternatiolLicenses.Columns[1].Width = 110;

                dgvAllInternatiolLicenses.Columns[2].HeaderText = "Driver ID";
                dgvAllInternatiolLicenses.Columns[2].Width = 110;

                dgvAllInternatiolLicenses.Columns[3].HeaderText = "L.License ID";
                dgvAllInternatiolLicenses.Columns[3].Width = 110;

                dgvAllInternatiolLicenses.Columns[4].HeaderText = "Issue Date";
                dgvAllInternatiolLicenses.Columns[4].Width = 140;

                dgvAllInternatiolLicenses.Columns[5].HeaderText = "Expiration Date";
                dgvAllInternatiolLicenses.Columns[5].Width = 140;

                dgvAllInternatiolLicenses.Columns[6].HeaderText = "Is Active";
                dgvAllInternatiolLicenses.Columns[6].Width = 80;

            }
        }
    }
}