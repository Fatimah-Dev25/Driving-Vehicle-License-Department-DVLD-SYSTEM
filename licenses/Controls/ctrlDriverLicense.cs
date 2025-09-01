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
using FirstProjectDVLD.licenses.LocalLicenses;

namespace FirstProjectDVLD.licenses.Controls
{
    public partial class ctrlDriverLicense : UserControl
    {
        private int _DriverID = -1;
        private Driver _Driver;
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;
        public ctrlDriverLicense()
        {
            InitializeComponent();
        }

        public void LoadInfo(int driverID)
        {
            _DriverID = driverID;
            _Driver = Driver.FindByID(_DriverID);

            if (_Driver == null)
            {
                MessageBox.Show("There isn't driver with ID " + _DriverID, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();
        }


        public void LoadInfoByPersonID(int personID)
        {

            _Driver = Driver.FindByPersonID(personID);

            if (_Driver == null)
            {
                MessageBox.Show("There isn't driver linked with person ID = " + personID, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _DriverID = _Driver.DriverID;
            _LoadLocalLicenseInfo();
            _LoadInternationalLicenseInfo();
        }

        private void _LoadLocalLicenseInfo()
        {
            _dtDriverLocalLicensesHistory = Driver.GetLicenses(_DriverID);

            dgvLocalLicenses.DataSource = _dtDriverLocalLicensesHistory;
            lblRecordsCount.Text = dgvLocalLicenses.Rows.Count.ToString();

            if (dgvLocalLicenses.Rows.Count > 0)
            {
                dgvLocalLicenses.Columns[0].HeaderText = "Lic.ID";
                dgvLocalLicenses.Columns[0].Width = 80;

                dgvLocalLicenses.Columns[1].HeaderText = "App.ID";
                dgvLocalLicenses.Columns[1].Width = 80;

                dgvLocalLicenses.Columns[2].HeaderText = "Class Name";
                dgvLocalLicenses.Columns[2].Width = 210;

                dgvLocalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvLocalLicenses.Columns[3].Width = 140;

                dgvLocalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvLocalLicenses.Columns[4].Width = 140;

                dgvLocalLicenses.Columns[5].HeaderText = "Is Active";
                dgvLocalLicenses.Columns[5].Width = 80;

            }

            
        }

       private void _LoadInternationalLicenseInfo()
        {
            _dtDriverInternationalLicensesHistory = Driver.GetDriverInternationalLicenses(_DriverID);

            dgvInternationalLicenses.DataSource = _dtDriverInternationalLicensesHistory;
            lblInternationaRecordsCount.Text = dgvInternationalLicenses.Rows.Count.ToString();

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicenses.Columns[0].Width = 110;

                dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[1].Width = 110;
                
                dgvInternationalLicenses.Columns[2].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[2].Width = 100;
                
                dgvInternationalLicenses.Columns[3].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[3].Width = 140;
                
                dgvInternationalLicenses.Columns[4].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[4].Width = 140;
                
                dgvInternationalLicenses.Columns[5].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[5].Width = 80;

            }
        }

        public void Clear()
        {
            _dtDriverLocalLicensesHistory.Clear();
            _dtDriverInternationalLicensesHistory.Clear();
        }
    
        private void showLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo((int)dgvLocalLicenses.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void showLicenseInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
