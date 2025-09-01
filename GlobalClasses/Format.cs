using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectDVLD.GlobalClasses
{
    public class Format
    {
        public static string DateToShort(DateTime date)
        {
            return date.ToString("dd/MMM/yyyy");
        }
    }
}
