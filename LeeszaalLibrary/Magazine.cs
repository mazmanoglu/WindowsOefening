using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeszaalLibrary
{
    public class Magazine
    {
        public string Color { get; set; }

        public Magazine(Random random)
        {

            Color = MagazineColors.Colors(random.Next(0,5));
        }
    }
}
