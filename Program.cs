using DVLD_Buisness;
using FirstProjectDVLD;
using FirstProjectDVLD.Applications.RenewLocalLicense;
using FirstProjectDVLD.Login;
using FirstProjectDVLD.People;
using FirstProjectDVLD.Tests;
using FirstProjectDVLD.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
