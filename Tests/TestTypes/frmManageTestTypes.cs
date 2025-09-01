using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DVLD_Buisness;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.Applications.TestTypes
{
    public partial class frmManageTestTypes : Form
    {
        DataTable dtTestTypes;
        public frmManageTestTypes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            dtTestTypes = TestType.GetAllTestTypes();

            dgvTestTypes.DataSource = dtTestTypes;
            lblRecordsCount.Text = dgvTestTypes.Rows.Count.ToString();
          
            if(dgvTestTypes.Rows.Count > 0 )
            {
                dgvTestTypes.Columns[0].HeaderText = "ID";
                dgvTestTypes.Columns[0].Width = 75;

                dgvTestTypes.Columns[1].HeaderText = "Title";
                dgvTestTypes.Columns[1].Width = 140;

                dgvTestTypes.Columns[2].HeaderText = "Description";
                dgvTestTypes.Columns[2].Width = 420;

                dgvTestTypes.Columns[3].HeaderText = "Fees";
                dgvTestTypes.Columns[3].Width = 75;
            }
            
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditTestType frm = new frmEditTestType((TestType.enTestType)dgvTestTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmManageTestTypes_Load(null, null);
        }
    }
}
