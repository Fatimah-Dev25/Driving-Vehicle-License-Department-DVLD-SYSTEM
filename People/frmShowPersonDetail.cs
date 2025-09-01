using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.People
{
    public partial class frmShowPersonDetail : Form
    {
        public frmShowPersonDetail(int personID)
        {
            InitializeComponent();
            ctrlPersonInfoCard.LoadPersonInfo(personID);
        }

        public frmShowPersonDetail(string NationalNO)
        {
            InitializeComponent();
            ctrlPersonInfoCard.LoadPersonInfo(NationalNO);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowPersonDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
