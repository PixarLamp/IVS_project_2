using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathLibTests
{
    [TestClass]
    public class MathLibTests
    {
        [TestMethod]
        public void addtest()
        {
            Assert.AreEqual(10, add(7, 3));
            Assert.AreEqual(20.35, add(20.3, 0.05));
            Assert.AreEqual(10, add(-10, 20));
        }

        [TestMethod]
        public void subtest()
        {
            Assert.AreEqual(10, sub(15, 5));
            Assert.AreEqual(20.35, sub(20.3, 0.05));
            Assert.AreEqual(-30, sub(-10, 20));
        }

        [TestMethod]
        public void multest()
        {
            Assert.AreEqual(-10, mul(-2, 5));
            Assert.AreEqual(0.265, mul(5.3, 0.05));
            Assert.AreEqual(0.0, mul(5.3, 0));
        }

        [TestMethod]
        public void divtest()
        {
            Assert.AreEqual(-3, div(-15, 5));
            Assert.AreEqual(408, div(20.4, 0.05));
            Assert.ThrowsException<Exception>(() => div(10, 0));
        }

        [TestMethod]
        public void factest()
        {
            Assert.AreEqual(120, fac(5));
            Assert.AreEqual(1, fac(0));
            Assert.ThrowsException<Exception>(() => fac(-5));
        }

        [TestMethod]
        public void exptest()
        {
            Assert.AreEqual(27, exp(3, 3));
            Assert.AreEqual(5.0625, exp(2.25, 2));
            Assert.AreEqual(1, exp(25, 0));
            Assert.AreEqual(-8, exp(-2, 3));
        }

        [TestMethod]
        public void roottest()
        {
            Assert.AreEqual(0.0625, root(0.25, 2));
            Assert.AreEqual(0, root(0, 2));
            Assert.AreEqual(2, root(64, 6));
            Assert.ThrowsException<Exception>(() => root(-9, 2));
        }

        [TestMethod]
        public void logtest()
        {
            Assert.AreEqual(2, log(100));
            Assert.ThrowsException<Exception>(() => log(-5));
            Assert.ThrowsException<Exception>(() => log(0));
        }
    }
}
