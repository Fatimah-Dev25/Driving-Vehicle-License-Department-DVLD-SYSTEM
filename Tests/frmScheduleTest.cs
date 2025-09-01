using DVLD_Buisness;
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
    public partial class frmScheduleTest : Form
    {
        private TestType.enTestType _TestTypeID = TestType.enTestType.Vision;
        private int _LocalDLAppID = -1;
        private int _AppointmentID = -1;
        public frmScheduleTest(int localDLAppID, TestType.enTestType testTypeID, int appointmentID = -1)
        {
            InitializeComponent();
            _LocalDLAppID = localDLAppID;
            _AppointmentID = appointmentID;
            _TestTypeID = testTypeID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            scheduleTestControl1.TestTypeID = _TestTypeID;
            scheduleTestControl1.LoadInfo(_LocalDLAppID, _AppointmentID);
        }

    
    }
}
