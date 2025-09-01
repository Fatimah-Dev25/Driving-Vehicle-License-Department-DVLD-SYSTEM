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
    public partial class frmFindPerson : Form
    {
        public delegate void DataBackEventHandler(object sender,string FullName, int PersonID);

        public event DataBackEventHandler DataBack;
        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(crtlPersonCardWithFilter.PersonID != -1)
            {
                DataBack?.Invoke(this, crtlPersonCardWithFilter.SelectedPersonInfo.FullName(), crtlPersonCardWithFilter.PersonID);
            }

            this.Close();

        }


    }
}
