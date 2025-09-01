using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.licenses
{
    public partial class frmShowPersonLicenseHistory : Form
    {
        private int _PersonID = -1;
        public frmShowPersonLicenseHistory(int personID)
        {
            _PersonID = personID;
            InitializeComponent();
        }

        public frmShowPersonLicenseHistory()
        {
            
            InitializeComponent();
        }

        private void frmShowPersonLicenseHistory_Load(object sender, EventArgs e)
        {
            if(_PersonID != -1)
            {
                personCardWithFilter1.LoadPersonInfo(_PersonID);
                personCardWithFilter1.FilterEnabled = false;
                ctrlDriverLicense1.LoadInfoByPersonID(_PersonID);
            }
            else
            {
                personCardWithFilter1.FilterEnabled = true;
                personCardWithFilter1.FilterFocus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personCardWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void personCardWithFilter1_onPersonSelected(int obj)
        {
            _PersonID = obj;

            if(_PersonID == -1) { 
            
                ctrlDriverLicense1.Clear();
            }
            else
            {
                ctrlDriverLicense1.LoadInfoByPersonID(_PersonID);
            }
        }
    }
}
