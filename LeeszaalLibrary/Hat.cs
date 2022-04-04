using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeszaalLibrary
{
    public static class Hat
    {
        public static List<string> HatNames { get; set; }
        public static string Hats(int index)
        {
            HatNames = new List<string>();

            HatNames.Add("Pet");
            HatNames.Add("Bolhoed");
            HatNames.Add("Pruik");
            HatNames.Add("Niets");

            return HatNames[index];
        }
    }
}
