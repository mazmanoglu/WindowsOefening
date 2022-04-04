using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeszaalLib
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(Random random)
        {
            Age = random.Next(12, 71);
        }
    }
}
