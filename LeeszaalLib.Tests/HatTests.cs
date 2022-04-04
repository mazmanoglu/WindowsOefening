using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LeeszaalLib;

namespace LeeszaalLib.Tests
{
    [TestFixture]
    public class HatTests
    {
        [Test]
        [TestCase(0, "Pet")]
        [TestCase(1, "Bolhoed")]
        [TestCase(2, "Pruik")]
        [TestCase(3, "Niets")]
        public void Hat_Hats_Return(int index, string hat)
        {
            Assert.AreEqual(Hat.Hats(index), hat );
        }
    }
}