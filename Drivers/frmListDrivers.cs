using DVLD_Buisness;
using FirstProjectDVLD.licenses;
using FirstProjectDVLD.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.Drivers
{
    public partial class frmListDrivers : Form
    {
        DataTable _dtAllDrivers;
        public frmListDrivers()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            _dtAllDrivers = Driver.GetAllDriveres();
            dgvDriversList.DataSource = _dtAllDrivers;
            cbFilterBy.SelectedIndex = 0;

            lblRecordsCount.Text = dgvDriversList.Rows.Count.ToString();

            if (dgvDriversList.Rows.Count > 0 )
            {

                dgvDriversList.Columns[0].HeaderText = "Driver ID";
                dgvDriversList.Columns[0].Width = 90;
                
                dgvDriversList.Columns[1].HeaderText = "Person ID";
                dgvDriversList.Columns[1].Width = 90;
                
                dgvDriversList.Columns[2].HeaderText = "National No.";
                dgvDriversList.Columns[2].Width = 120;
                
                dgvDriversList.Columns[3].HeaderText = "Full Name";
                dgvDriversList.Columns[3].Width = 240;
                
                dgvDriversList.Columns[4].HeaderText = "Date";
                dgvDriversList.Columns[4].Width = 200;    

                dgvDriversList.Columns[5].HeaderText = "Active Licenses";
                dgvDriversList.Columns[5].Width = 120;

            }
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Visible = cbFilterBy.SelectedIndex != 0;

            if (txtFilterBy.Visible)
            {
                txtFilterBy.Text = "";
                txtFilterBy.Focus();
            }
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Driver ID":
                    FilterColumn = "DriverID";
                    break;
            
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
            
                case "National No.":
                    FilterColumn = "NationalNo";
                    break;
            
                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;  
            }

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllDrivers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvDriversList.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "DriverID" || FilterColumn == "PersonID")
            {
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim());
            }
            
            else
            {
                _dtAllDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());
            }

            lblRecordsCount.Text = dgvDriversList.Rows.Count.ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text == "Driver ID" || cbFilterBy.Text == "Person ID")
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void showPersonInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonDetail frm = new frmShowPersonDetail((int)dgvDriversList.CurrentRow.Cells[1].Value);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(
                (int)dgvDriversList.CurrentRow.Cells[1].Value );
        
            frm.ShowDialog();
        }
    }
}
