using System;
using DVLD_Buisness;
using System.Windows.Forms;

namespace FirstProjectDVLD.Users
{
    public partial class ctrlUserCard : UserControl
    {
        private User _User;
        private int _UserId = -1;
        public ctrlUserCard()
        {
            InitializeComponent();
        }
        public int UserID
        {
            get { return _UserId; }
        }
        public void LoadUserInfo(int userId)
        {
            _UserId = userId;
            _User = User.FindByUserID(_UserId);

            if(_User == null )
            {
                _ResetUserInfo();
                MessageBox.Show($"NO User Found with ID :: {_UserId}!!", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
             
            _FillUserInfo();
            
        }
        private void _FillUserInfo() {

            ctrlPersonCardInfo.LoadPersonInfo(_User.PersonID);

            lblUserId.Text = _UserId.ToString();
            lblUsername.Text = _User.UserName;
            lblIsUserActive.Text = _User.isActive ? "Yes" : "No";
        }
        private void _ResetUserInfo()
        {
            ctrlPersonCardInfo.ResetPersonInfo();

            lblUserId.Text = "???";
            lblUsername.Text = "???";
            lblIsUserActive.Text = "???";
        }

   
    }
}
