using DVLD_Buisness;
using FirstProjectDVLD.licenses.DetainedLicenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using License = DVLD_Buisness.License;
using System.Windows.Forms;
using FirstProjectDVLD.People;
using FirstProjectDVLD.licenses.LocalLicenses;
using FirstProjectDVLD.licenses;

namespace FirstProjectDVLD.Applications.ReleaseDetaindLicense
{
    public partial class frmListDetainedLicenses : Form
    {
        DataTable _dtListDetainedLicenses;
        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(cbFilter.Text == "Is Released")
            {
                txtFilterBy.Visible = false;
                cbIsReleased.Visible = true;
                cbIsReleased.SelectedIndex = 0;
                cbIsReleased.Focus();
            }
            else
            {
                txtFilterBy.Visible = cbFilter.Text != "None";
                cbIsReleased.Visible = false;

                if (cbFilter.SelectedIndex == 0)
                {
                    txtFilterBy.Visible = false;
                }
                else
                    txtFilterBy.Visible = true;

                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }


        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();

            frmListDetainedLicenses_Load(null, null);
        }

        private void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {
            _dtListDetainedLicenses = DetainedLicense.GetAllDetainedLicenses();
            dgvAllDetainedLicenses.DataSource = _dtListDetainedLicenses;
            lblRecordsCount.Text = dgvAllDetainedLicenses.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;


            if (dgvAllDetainedLicenses.Rows.Count > 0)
            {
                dgvAllDetainedLicenses.Columns[0].HeaderText = "D.ID";
                dgvAllDetainedLicenses.Columns[0].Width = 70;

                dgvAllDetainedLicenses.Columns[1].HeaderText = "L.ID";
                dgvAllDetainedLicenses.Columns[1].Width = 70;
            
                dgvAllDetainedLicenses.Columns[2].HeaderText = "Detain Date";
                dgvAllDetainedLicenses.Columns[2].Width = 140;
            
                dgvAllDetainedLicenses.Columns[3].HeaderText = "Is Released";
                dgvAllDetainedLicenses.Columns[3].Width = 80;
            
                dgvAllDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                dgvAllDetainedLicenses.Columns[4].Width = 90;
            
                dgvAllDetainedLicenses.Columns[5].HeaderText = "Release Date";
                dgvAllDetainedLicenses.Columns[5].Width = 140;
            
                dgvAllDetainedLicenses.Columns[6].HeaderText = "N.No";
                dgvAllDetainedLicenses.Columns[6].Width = 80;
            
                dgvAllDetainedLicenses.Columns[7].HeaderText = "Full Name";
                dgvAllDetainedLicenses.Columns[7].Width = 180; 
                
                dgvAllDetainedLicenses.Columns[8].HeaderText = "Release App ID";
                dgvAllDetainedLicenses.Columns[8].Width = 130;
            }

        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();

            frmListDetainedLicenses_Load(null, null);
        }

        private void showPersonDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            License _License = License.Find((int)dgvAllDetainedLicenses.CurrentRow.Cells[1].Value);
            frmShowPersonDetail frm = new frmShowPersonDetail(_License.DriverInfo.PersonID);
            frm.ShowDialog();
        }


        private void showLicenseDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmShowLicenseInfo frm = new frmShowLicenseInfo((int)dgvAllDetainedLicenses.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            License _License = License.Find((int)dgvAllDetainedLicenses.CurrentRow.Cells[1].Value);
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(_License.DriverInfo.PersonID);
            frm.ShowDialog();
        }

        private void releaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            License _License = License.Find((int)dgvAllDetainedLicenses.CurrentRow.Cells[1].Value);
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense(_License.LicenseID);
            frm.ShowDialog();

            frmListDetainedLicenses_Load(null, null);   
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            releaseDetainLicenseToolStripMenuItem.Enabled = !(bool)dgvAllDetainedLicenses.CurrentRow.Cells[3].Value;

        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            //Map Selected Filter to real Column name 
            switch (cbFilter.Text)
            {
                case "Detain ID":
                    FilterColumn = "DetainID";
                    break;
                case "Is Released":
                    {
                        FilterColumn = "IsReleased";
                        break;
                    };

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                case "Release Application ID":
                    FilterColumn = "ReleaseApplicationID";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }


            //Reset the filters in case nothing selected or filter value conains nothing.
            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtListDetainedLicenses.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvAllDetainedLicenses.Rows.Count.ToString();
                return;
            }


            if (FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID")
                //in this case we deal with numbers not string.
                _dtListDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
            else
                _dtListDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());

            lblRecordsCount.Text = _dtListDetainedLicenses.Rows.Count.ToString();
        }

        private void cbIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsReleased";
            string FilterValue = cbIsReleased.Text;

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
                _dtListDetainedLicenses.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtListDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            lblRecordsCount.Text = _dtListDetainedLicenses.Rows.Count.ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "Detain ID" || cbFilter.Text == "Release Application ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
