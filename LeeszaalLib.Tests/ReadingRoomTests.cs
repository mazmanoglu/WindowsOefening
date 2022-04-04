using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeeszaalLib;
using NUnit.Framework;

namespace LeeszaalLib.Tests
{
    [TestFixture]
    public class ReadingRoomTests
    {

        private ReadingRoom readingRoom;
        private Random random;
        private Reader reader;
        [SetUp]
        public void Setup()
        {
            readingRoom = new ReadingRoom();
            random = new Random();
            reader = new Reader(random);
            readingRoom.AddReader(10);
        }

        [Test]
        public void ReadingRoom_AddReader_ReturnNewReader()
        {
            int before = readingRoom.ReadersList.Count;
            readingRoom.AddReader(10);
            int after = readingRoom.ReadersList.Count;
            Assert.AreEqual(before +10, after);
        }

        [Test]

        public void ReadingRoom_SelectReader_ReturnIndex()
        {
            var result = readingRoom.SelectReader(1);
            Assert.AreEqual(result.ReferenceNumber, readingRoom.ReadersList[1].ReferenceNumber) ;
        }

        [Test]
        public void ReadingRoom_NumberOfReaderByHoofdeksel_Returnxx()
        {
            bool isHat = Hat.HatNames.Contains(reader.ReaderHat);
            Assert.IsTrue(isHat);
        }
    }
}