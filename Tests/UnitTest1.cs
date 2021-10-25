using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Third_Lab;

namespace Tests
{
    [TestClass]
    public class LogicTests
    {
        [TestMethod]
        public void TestSum()
        {
            var firstVector = new Vector(10d, 10d, 10d);
            var secondVector = new Vector(15d, 2d, 3d);

            var resultVector = firstVector + secondVector;
            Assert.AreEqual(25, resultVector.X);
            Assert.AreEqual(12, resultVector.Y);
            Assert.AreEqual(13, resultVector.Z);
        }

        [TestMethod]
        public void TestDifference()
        {
            var firstVector = new Vector(10d, 10d, 10d);
            var secondVector = new Vector(15d, 2d, 3d);

            var resultVector = firstVector - secondVector;
            Assert.AreEqual(-5, resultVector.X);
            Assert.AreEqual(8, resultVector.Y);
            Assert.AreEqual(7, resultVector.Z);
        }

        [TestMethod]
        public void TestVectorProduct()
        {
            var firstVector = new Vector(3d, 8d, 12d);
            var secondVector = new Vector(5d, 2d, 3d);

            var resultVector = firstVector ^ secondVector;
            Assert.AreEqual(0, resultVector.X);
            Assert.AreEqual(24, resultVector.Y);
            Assert.AreEqual(-34, resultVector.Z);
        }

        [TestMethod]
        public void TestScalarProduct()
        {
            var firstVector = new Vector(3d, 8d, 12d);
            var secondVector = new Vector(5d, 2d, 3d);

            Assert.AreEqual(67, firstVector * secondVector);
        }

        [TestMethod]
        public void TestLength()
        {
            var vector = new Vector(1d, 3d, 5d);

            Assert.AreEqual(5, vector.Length);
        }
    }
}
