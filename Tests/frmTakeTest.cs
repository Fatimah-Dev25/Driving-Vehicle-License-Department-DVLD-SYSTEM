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

namespace FirstProjectDVLD
{
    public partial class frmTakeTest : Form
    {

        private int _AppointmentID = -1;
        private TestType.enTestType testType;
        private int _TestID = -1;
        private Test _Test;

        public frmTakeTest(int appointmentID, TestType.enTestType _testTypeID)
        {
            InitializeComponent();
            _AppointmentID = appointmentID;
            testType = _testTypeID;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            scheduledTestControl1.TestTypeID = testType;
            scheduledTestControl1.LoadInfo(_AppointmentID);

            if(scheduledTestControl1.TestAppointmentID == -1) {
            
                btnSave.Enabled = false;
            }

            _TestID = scheduledTestControl1.TestID;

            if(_TestID != -1)
            {
                _Test = Test.Find(_TestID);

                if (_Test.TestResult)
                    rbPassed.Checked = true;
                else
                    rbFailed.Checked = true;

                lblMessage.Visible = true;
                rbPassed.Enabled = false;
                rbFailed.Enabled =false;

                _Test.Notes = txtNotes.Text;
            }
            else
                _Test = new Test();

           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

           if(MessageBox.Show(" you sure you want to save? After that you cannot change the Pass/Fail results after you save?.","Confirm",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            _Test.TestAppointmentID = scheduledTestControl1.TestAppointmentID;
            _Test.TestResult = rbPassed.Checked;
            _Test.Notes = txtNotes.Text.Trim();
            _Test.CreatedByUser = Global.CurrentUser.UserID;

            if (_Test.Save())
            {
                btnSave.Enabled = false;
                MessageBox.Show("Data Saved Successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmTakeTest_Load(null, null);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        

        
    }
}
