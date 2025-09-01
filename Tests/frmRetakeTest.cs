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

namespace FirstProjectDVLD.Tests
{
    public partial class frmRetakeTest : Form
    {
        TestType.enTestType _TestTypeID = TestType.enTestType.Vision;
        LocalDrivingLicenseApplication _LocalApp;
        public frmRetakeTest()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLocalAppID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmRetakeTest_Load(object sender, EventArgs e)
        {
            _FillTestTypesInComboBox();
            cbTestType.SelectedIndex = 0;
        }

        private void _FillTestTypesInComboBox()
        {
            DataTable dtTestTypes = TestType.GetAllTestTypes();

            foreach(DataRow row in dtTestTypes.Rows)
            {
                cbTestType.Items.Add(row["TestTypeTitle"]);
            }

        }

        private bool HandlePassedTest()
        {
            if (_LocalApp.DoesPassTestType(_TestTypeID))
            {
                MessageBox.Show("this person already pass at Test", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRetakeTest.Enabled = false;
                return false;

            }
            return true;

        }

        private bool HandlePassedPreviousTest()
        {
            if(!_LocalApp.DoesPassPreviousTest(_TestTypeID))
            {
                MessageBox.Show("This person doesn't pass previous test @_@", "Not Allowed", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRetakeTest.Enabled = false;
                return false;

            }
            return true;
        }

        private bool HandleAttendTest()
        {
            if (!_LocalApp.DoesAttendTestType(_TestTypeID) )
            {
                MessageBox.Show("This person didn't take this test yet!!!", "Not Allowed",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRetakeTest.Enabled = false;
                return false;
            }

            return true;
        }
        private void btnRetakeTest_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Fileds are not valide!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int localAppId = int.Parse(txtLocalAppID.Text);
             _LocalApp = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(localAppId);
    
            if(_LocalApp == null) {

                MessageBox.Show("there no local application with ID = " + localAppId, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!HandleAttendTest())
                return;

            if (!HandlePassedTest())
                return;


            if (!HandlePassedPreviousTest())
                return;

            frmListTestAppointments frm = new frmListTestAppointments(_LocalApp.LocalDrivingLicenseAppID, _TestTypeID);
            frm.ShowDialog();   
            
            this.Close();

        }

        private void txtLocalAppID_Validating(object sender, CancelEventArgs e)
        {
            if (Validation.isNotTextBoxEmpty((TextBox)sender))
                errorProvider1.SetError(txtLocalAppID, null);
            else
            {
                errorProvider1.SetError(txtLocalAppID, "this field required!");
            }
        }

        private void cbTestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRetakeTest.Enabled = true;
            switch(cbTestType.Text)
            {
                case "Vision Test":
                    _TestTypeID = TestType.enTestType.Vision; break;
                case "Written (Theory) Test":
                    _TestTypeID = TestType.enTestType.WrittenTest; break;   
                case "Practical (Street) Test":
                    _TestTypeID = TestType.enTestType.StreetTest; break;

            }
        }

        private void txtLocalAppID_TextChanged(object sender, EventArgs e)
        {
            btnRetakeTest.Enabled = true;
        }
    }
}
