using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeszaalLib
{
    public class Reader
    {
        public int ReferenceNumber { get; set; }
        public string ReaderHat { get; set; }
        public Person Person { get; set; }
        public Magazine Magazine { get; set; }

        private readonly Random random;

        public Reader(Random random)
        {
            ReaderHat = Hat.Hats(random.Next(0,4));   
            Magazine = new Magazine(random);
            Person = new Person(random);
        }

        public override string ToString()
        {
            return $"{ReferenceNumber}";
        }

    }
}
