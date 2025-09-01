using System;
using Microsoft.Win32;
using System.Collections.Generic;
using DVLD_Buisness;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Windows.Forms;

namespace FirstProjectDVLD.GlobalClasses
{
    internal class Global
    {
        private static string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLDLogin";
        private static string key1Name = "Username";
        private static string key2Name = "Password";

        public static User CurrentUser;
        public static bool RememberUsernameAndPassword(string username, string password)
        {
            try
            {
                //this will get the current project directory folder.
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                Registry.SetValue(keyPath, key1Name, username, RegistryValueKind.String);
                Registry.SetValue(keyPath, key2Name, password, RegistryValueKind.String);

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            //this will get the stored username and password and will return true if found and false if not found.
            try
            {

                Username = Registry.GetValue(keyPath, key1Name, null) as string;
                Password = Registry.GetValue(keyPath, key2Name, null) as string;

                if (Username != null && Password != null)
                    return true;

                else
                    return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

        }

    }
}
