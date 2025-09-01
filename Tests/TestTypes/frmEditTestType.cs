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
using FirstProjectDVLD.GlobalClasses;

namespace FirstProjectDVLD.Applications.TestTypes
{
    public partial class frmEditTestType : Form
    {
        private TestType.enTestType _TestTypeID;
        private TestType _TestType;
        public frmEditTestType(TestType.enTestType testType)
        {
            InitializeComponent();
            _TestTypeID = testType;
        }

        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            _TestType = TestType.Find(_TestTypeID);

            if(_TestType != null)
            {
                lblTestTypeID.Text = ((int)_TestTypeID).ToString();
                txtTestTitle.Text = _TestType.TestTypeTitle;
                txtTestDiscription.Text = _TestType.TestTypeDescription;
                txtTestFees.Text = _TestType.TestTypeFees.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTestTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTestTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTestTitle, "Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txtTestTitle, null);
            };
        }

        private void txtTestDiscription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTestDiscription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTestDiscription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTestDiscription, "Description cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(txtTestDiscription, null);
            };
        }

        private void txtTestFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTestFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTestFees, "Fees cannot be empty!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtTestFees, null);

            };


            if (!Validation.isNumber(txtTestFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTestFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(txtTestFees, null);
            };
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren()) {

                MessageBox.Show("Some Fields are not Validate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _TestType.TestTypeTitle = txtTestTitle.Text;
            _TestType.TestTypeDescription =txtTestDiscription.Text;
            _TestType.TestTypeFees = Convert.ToSingle(txtTestFees.Text.Trim());

            if (_TestType.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data is not Saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
