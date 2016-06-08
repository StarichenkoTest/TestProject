using System;
using NUnit.Framework;

namespace Test.Tests
{
    [TestFixture()]
    public class ProgramTests
    {

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TriangleAreaThrowsArgumentOutOfRangeException000()
        {
            Program.TriangleArea(0, 0, 0);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TriangleAreaThrowsArgumentOutOfRangeException100()
        {
            Program.TriangleArea(1, 0, 0);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TriangleAreaThrowsArgumentOutOfRangeException110()
        {
            Program.TriangleArea(1, 1, 0);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TriangleAreaThrowsArgumentOutOfRangeException11NaN()
        {
            Program.TriangleArea(1, 1, double.NaN);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TriangleAreaThrowsArgumentOutOfRangeException1NaN1()
        {
            Program.TriangleArea(1, double.NaN, 1);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TriangleAreaThrowsArgumentOutOfRangeExceptionNaN11()
        {
            Program.TriangleArea(double.NaN, 1, 1);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TriangleAreaThrowsArgumentOutOfRangeExceptionInfinite11()
        {
            Program.TriangleArea(double.PositiveInfinity, 1, 1);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TriangleAreaThrowsArgumentOutOfRangeException1MaxValue1()
        {
            Program.TriangleArea(1, double.MaxValue, 1);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TriangleAreaThrowsArgumentOutOfRangeException11Max()
        {
            Program.TriangleArea(1, 1, 1.3407807929942596E+155);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentException))]
        public void TriangleAreaThrowsArgumentException111()
        {
            Program.TriangleArea(1, 1, 1);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentException))]
        public void TriangleAreaThrowsArgumentException122()
        {
            Program.TriangleArea(1, 2, 2);
        }

        [Test()]
        public void TriangleArea345()
        {
            var d = Program.TriangleArea(3, 4, 5);
            Assert.AreEqual(6, d);
        }

        [Test()]
        public void TriangleArea354()
        {
            var d = Program.TriangleArea(3, 5, 4);
            Assert.AreEqual(6, d);
        }

        [Test()]
        public void TriangleArea543()
        {
            var d = Program.TriangleArea(5, 4, 3);
            Assert.AreEqual(6, d);
        }
    }
}