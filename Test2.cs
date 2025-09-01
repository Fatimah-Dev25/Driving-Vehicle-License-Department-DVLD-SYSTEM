using FirstProjectDVLD.Applications;
using FirstProjectDVLD.Users;
using System;
using DVLD_Buisness;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstProjectDVLD.Applications.LocalDrivingLicenses;

namespace FirstProjectDVLD
{
    public partial class Test2 : Form
    {
        public Test2()
        {
            InitializeComponent();
        }
        DataTable appTypes = clsApplicationType.GetAllApplicationTypes();

        private void Test2_Load(object sender, EventArgs e)
        {
            foreach(DataRow row in appTypes.Rows)
            {
                comboBox1.Items.Add(row["ApplicationTypeTitle"]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
