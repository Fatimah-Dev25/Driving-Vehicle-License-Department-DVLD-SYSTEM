using DVLD_Buisness;
using FirstProjectDVLD.Applications.LocalDrivingLicenses;
using FirstProjectDVLD.Login;
using FirstProjectDVLD.People;
using FirstProjectDVLD.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using License = DVLD_Buisness.License;

namespace FirstProjectDVLD
{
    public partial class TestForm : Form
    {
        
        
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

            License Obj = License.Find(34);

            label1.Text = Obj.DriverInfo.PersonInfo.FullName();

        }
    }
}