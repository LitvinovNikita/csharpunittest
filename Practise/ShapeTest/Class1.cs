using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Practise;

namespace ShapeTest
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Rectangle_Area_Valid()
        {
            double expected = 200;
            Rectangle r1 = new Rectangle(20, 10);

            double actual = r1.Area();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Rectangle_Area_Double_Valid()
        {
            double expected = 313.1;
            Rectangle r1 = new Rectangle(15.5, 20.2);

            double actual = r1.Area();
            Assert.AreEqual(expected, actual, 0.1);
            //method to test if two doubles are equal within
            //a certain tolerance. The method takes three arguments:
            //the expected value, the actual value, and the tolerance.
            //For example, to test if the value of a variable x is equal to 0.5 within a tolerance of 0.001
        }


        [Test]
        public void Rectangle_Area_Invalid()
        {
            double expected = 200;
            Rectangle r1 = new Rectangle(-20, -10);

            double actual = r1.Area();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Rectangle_Perimeter_Valid() 
        {
            double expected = 60;
            Rectangle r2 = new Rectangle(20, 10);

            double actual = r2.Perimeter();
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Rectangle_Perimeter_Invalid()
        {
            double expected = 60;
            Rectangle r2 = new Rectangle(-20, 10);

            double actual = r2.Perimeter();
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Rectangle_Perimeter_Double_Valid()
        {
            double expected = 17;
            Rectangle r1 = new Rectangle(5.1, 3.4);

            double actual = r1.Perimeter();
            Assert.AreEqual(expected, actual, 0.1);
            //method to test if two doubles are equal within
            //a certain tolerance. The method takes three arguments:
            //the expected value, the actual value, and the tolerance.
            //For example, to test if the value of a variable x is equal to 0.5 within a tolerance of 0.001
        }
    }
}
