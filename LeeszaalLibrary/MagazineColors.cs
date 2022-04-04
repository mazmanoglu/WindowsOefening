using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeszaalLib
{
    public static class MagazineColors
    {
        public static List<string> ColorNames { get; set; }
        public static string Colors(int index)
        {
            ColorNames = new List<string>();

            ColorNames.Add("Geel");
            ColorNames.Add("Oranje");
            ColorNames.Add("Groen");
            ColorNames.Add("Blauw");
            ColorNames.Add("Rood");

            return ColorNames[index];
        }
    }
}
