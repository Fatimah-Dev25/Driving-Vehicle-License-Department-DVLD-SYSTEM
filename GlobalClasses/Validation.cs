using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProjectDVLD.GlobalClasses
{
    internal class Validation
    {

        public static bool ValidateEmail(string _Email)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var regex = new Regex(pattern);

            return regex.IsMatch(_Email);
        }

        public static bool ValidateInteger(string Number)
        {
            var pattern = @"^[0-9]*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }

        public static bool ValidateFloat(string Number)
        {
            var pattern = @"^[0-9]*(?:\.[0-9]*)?$";

            var regex = new Regex(pattern);

            return regex.IsMatch(Number);
        }
        public static bool isNumber(string _Number)
        {
            return (ValidateInteger(_Number) || ValidateFloat(_Number)); ;
        }

        public static bool isNotTextBoxEmpty(TextBox textBox)
        {
            if(string.IsNullOrEmpty(textBox.Text.Trim())) 
                return false;
            else
                return true;
        }
    }
}
