using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeeszaalLibrary
{
    public class ReadingRoom
    {
        public List<Reader> ReadersList { get; set; }

        readonly Random random;

        public ReadingRoom()
        {
            ReadersList = new List<Reader>();
            random = new Random();
        }

        public void AddReader(int number)
        {
            if (number.GetType() == typeof(int) && number <= 10)
            {
                for (int i = 0; i < number; i++)
                {
                    Reader reader = new Reader(random);
                    reader.ReferenceNumber = ReadersList.Count;
                    ReadersList.Add(reader);
                }
            }
        }

        public Reader SelectReader(int index)
        {
            return ReadersList[index];
        }

        public int NumberOfReaderByHoofdeksel(string hat)
        {
            var readers =  ReadersList.Where(s => s.ReaderHat.Equals(hat));
            return readers.Count(); 
        }
        public int NumberOfReaderByMagColor(string color)
        {
            var readers = ReadersList.Where(s => s.Magazine.Color.Equals(color));
            return readers.Count();
        }
        public IEnumerable<Reader> ShowReaderByKleurTijdSchrift(string color)
        {
            return ReadersList.Where(s => s.Magazine.Color.Equals(color));
        }
    }
}
