using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDProject.DVLDData.Global
{
    public class ClsFormat
    {
        public static string DateToShort(DateTime Dt1)
        {

            return Dt1.ToString("dd/MMM/yyyy");
        }
    }
}
