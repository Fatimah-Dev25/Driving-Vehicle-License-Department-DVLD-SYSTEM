using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using License = DVLD_Buisness.License;
using System.Runtime.InteropServices;
using FirstProjectDVLD.GlobalClasses;
using FirstProjectDVLD.People.Controls;

namespace FirstProjectDVLD.Applications.LocalDrivingLicenses
{
    public partial class frmAddUpdateLocalDrivingLicenseApplication : Form
    {
        enum enMode { AddNew , Update}
        enMode _Mode;
        private int _LocalLicenseAppID = -1;
        private LocalDrivingLicenseApplication _LocalLicenseApplication;
        private int _SelectedPersonId = -1;
        public frmAddUpdateLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateLocalDrivingLicenseApplication(int localLicAppID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _LocalLicenseAppID = localLicAppID;
        }

        private void frmAddUpdateLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _ResetDefaultValues()
        {
            _FillLicenseClassesInComboBox();

            if(_Mode == enMode.AddNew)
            {
                this.Text = "Add New Local License Application";
                lblFormTitle.Text = "Add New Local License Application";

                _LocalLicenseApplication = new LocalDrivingLicenseApplication();
                personCardWithFilter1.Focus();
                btnSave.Enabled = false;
                tpApplicationInfo.Enabled = false;

                lblAppDate.Text = DateTime.Now.ToShortDateString();
                lblAppFees.Text = clsApplicationType.Find((int)(BuisnessApplication.enApplicationType.NewLocalDrivingLicense)).AppTypeFee.ToString();
                cbAppLicenseClass.SelectedIndex = 2;
                lblAppUser.Text = Global.CurrentUser.UserName;
               
            }

            else
            {

                this.Text = "Update Local License Application";
                lblFormTitle.Text = "Update Local License Application";

                btnSave.Enabled = true;
            }
        }
        private void _LoadData()
        {
            personCardWithFilter1.FilterEnabled = false;
            _LocalLicenseApplication = LocalDrivingLicenseApplication.FindByLocalDrivingAppLicenseID(_LocalLicenseAppID);
           
            if(_LocalLicenseApplication == null)
            {
                MessageBox.Show("No Application with ID = " + _LocalLicenseAppID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            _SelectedPersonId = _LocalLicenseApplication.ApplicantPersonID;

            personCardWithFilter1.LoadPersonInfo(_LocalLicenseApplication.ApplicantPersonID);
            lblDLAppID.Text = _LocalLicenseApplication.LocalDrivingLicenseAppID.ToString();
                
            lblAppDate.Text = Format.DateToShort(_LocalLicenseApplication.ApplicationDate);

            cbAppLicenseClass.SelectedIndex = cbAppLicenseClass.FindString(LicenseClass.Find(_LocalLicenseApplication.LicenseClassID).LicenseName);
              
            lblAppFees.Text = _LocalLicenseApplication.PaidFees.ToString();
            lblAppUser.Text = User.FindByUserID(_LocalLicenseApplication.CreatedByUserID).UserName;
        }
        private void _FillLicenseClassesInComboBox()
        {

            DataTable dtAllLicenseClasses = LicenseClass.GetAllLicenseClasses();

            foreach (DataRow dr in dtAllLicenseClasses.Rows)
            {
                cbAppLicenseClass.Items.Add(dr["ClassName"]);
            }
        }
        private void frmAddUpdateLocalDrivingLicenseApplication_Activated(object sender, EventArgs e)
        {
            personCardWithFilter1.Focus();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            var autoValidate = this.AutoValidate;
            this.AutoValidate = AutoValidate.Disable;
            this.Close();
        }

        private void personCardWithFilter1_onPersonSelected(int obj)
        {
            _SelectedPersonId = obj;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int LicenseClassID = LicenseClass.Find(cbAppLicenseClass.Text).LicenseClassID;

            int ActiveApplicationID = LocalDrivingLicenseApplication.GetActiveApplicationIDForLicenseClass(_SelectedPersonId, BuisnessApplication.enApplicationType.NewLocalDrivingLicense, LicenseClassID);

            if (ActiveApplicationID != -1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbAppLicenseClass.Focus();
                return;
            }

            
           if( License.IsLicenseExistByPersonID(personCardWithFilter1.PersonID, LicenseClassID))
            {
                MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             

            _LocalLicenseApplication.LicenseClassID = LicenseClassID;
            _LocalLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalLicenseApplication.ApplicantPersonID = personCardWithFilter1.PersonID;
            _LocalLicenseApplication.ApplicationTypeId = 1;
            _LocalLicenseApplication.ApplicationStatus = BuisnessApplication.enApplicationStatus.New;
            _LocalLicenseApplication.PaidFees = Convert.ToSingle(lblAppFees.Text);
            _LocalLicenseApplication.CreatedByUserID = Global.CurrentUser.UserID;

            if (_LocalLicenseApplication.Save())
            {
                lblDLAppID.Text = _LocalLicenseApplication.LocalDrivingLicenseAppID.ToString();
                lblFormTitle.Text = "Update Local Driving License Application";

                _Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DataBackEvent(object sender, int PersonID)
        {
            _SelectedPersonId = PersonID;
            personCardWithFilter1.LoadPersonInfo(PersonID);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if(_Mode == enMode.Update)
            {
                tpApplicationInfo.Enabled = true;
                btnSave.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tpApplicationInfo"];
                return;
            }

            if(personCardWithFilter1.PersonID != -1)
            {
                btnSave.Enabled = true;
                tpApplicationInfo.Enabled = true;
                tabControl1.SelectedTab = tabControl1.TabPages["tpApplicationInfo"];

                return;
            }
            else
            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                personCardWithFilter1.FilterFocus();
            }
        }
    }
}
