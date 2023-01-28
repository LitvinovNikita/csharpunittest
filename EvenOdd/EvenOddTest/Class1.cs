using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EvenOdd;

namespace EvenOddTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void EvenOdd_Valid_Even()
        {
            String expected = "Even";
            EvenOddSelector e = new EvenOddSelector(10);
            String actual = e.EvenOdd();
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void EvenOdd_Valid_Odd()
        {
            String expected = "Odd";
            EvenOddSelector e = new EvenOddSelector(7);
            String actual = e.EvenOdd();
            Assert.AreEqual(expected, actual);
        }

    }
}
