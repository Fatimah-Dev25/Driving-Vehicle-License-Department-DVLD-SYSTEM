using System;
using DVLD_Buisness;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirstProjectDVLD.Applications.ApplicationType;

namespace FirstProjectDVLD.Applications
{
    public partial class frmApplicationType : Form
    {
        DataTable dtApplicationTypes;
        public frmApplicationType()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmApplicationType_Load(object sender, EventArgs e)
        {
            dtApplicationTypes = clsApplicationType.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = dtApplicationTypes;
            lblRecordsCount.Text = dgvApplicationTypes.Rows.Count.ToString();

            dgvApplicationTypes.Columns[0].HeaderText = "ID";
            dgvApplicationTypes.Columns[0].Width = 90;

            dgvApplicationTypes.Columns[1].HeaderText = "Title";
            dgvApplicationTypes.Columns[1].Width = 380;

            dgvApplicationTypes.Columns[2].HeaderText = "Fees";
            dgvApplicationTypes.Columns[2].Width = 90;
        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditApplicationType frm = new frmEditApplicationType((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmApplicationType_Load(null, null);
        }

        private void dgvApplicationTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
