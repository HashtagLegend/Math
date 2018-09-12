using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math;

namespace Math.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Math m = new Math();

        [TestMethod]
        public void AdditionTest()
        {
            Assert.AreEqual(7, m.Addition(3,4) );
        }

        [TestMethod]
        public void SubtractionTest()
        {
            Assert.AreEqual(7, m.Subtraction(11,4));
        }

        [TestMethod]
        public void MultiplyTest()
        {
            Assert.AreEqual(10, m.Multiply(2,5));
        }

        [TestMethod]
        public void DivisionTest()
        {
            Assert.AreEqual(10, m.Division(40,4));
        }
    }
}
