/**
 * @file MathlibTests.cs
 * @author Zuzana Hrk¾ová
 * @date 4-20-2020
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathLibTests
{

    [TestClass]
    public class MathLibTests
    {
        library.basic mathLab = new library.basic();
        /**
         * @brief Tests addition function
         */
        [TestMethod]
        public void Addtest()
        {
            Assert.AreEqual(10, mathLab.add(7, 3));
            Assert.AreEqual(20.35, mathLab.add(20.3, 0.05));
            Assert.AreEqual(10, mathLab.add(-10, 20));
        }
        /**
         * @brief Tests substitution function
         */
        [TestMethod]
        public void Subtest()
        {
            Assert.AreEqual(10, mathLab.sub(15, 5));
            Assert.AreEqual(20.25, mathLab.sub(20.3, 0.05));
            Assert.AreEqual(-30, mathLab.sub(-10, 20));
        }
        /**
         * @brief Tests multiplication function
         */
        [TestMethod]
        public void Multest()
        {
            Assert.AreEqual(-10, mathLab.mul(-2, 5));
            Assert.AreEqual(0.265, mathLab.mul(5.3, 0.05));
            Assert.AreEqual(0.0, mathLab.mul(5.3, 0));
        }
        /**
         * @brief Tests division function
         */
        [TestMethod]
        public void Divtest()
        {
            Assert.AreEqual(-3, mathLab.div(-15, 5));
            Assert.AreEqual(100, mathLab.div(5.0, 0.05));
            Assert.ThrowsException<DivideByZeroException>(() => mathLab.div(10, 0));
        }
        /**
         * @brief Tests factorial function
         */
        [TestMethod]
        public void Factest()
        {
            Assert.AreEqual(120, mathLab.fac(5));
            Assert.AreEqual(1, mathLab.fac(0));
            Assert.ThrowsException<NotFiniteNumberException>(() => mathLab.fac(-5));
        }
        /**
         * @brief Tests exponent function
         */
        [TestMethod]
        public void Exptest()
        {
            Assert.AreEqual(27, mathLab.exp(3, 3));
            Assert.AreEqual(5.0625, mathLab.exp(2.25, 2));
            Assert.AreEqual(1, mathLab.exp(25, 0));
            Assert.AreEqual(-8, mathLab.exp(-2, 3));
        }
        /**
         * @brief Tests root function
         */
        [TestMethod]
        public void Roottest()
        {
            Assert.AreEqual(0.5, mathLab.root(0.25, 2));
            Assert.AreEqual(0, mathLab.root(0, 2));
            Assert.AreEqual(2, mathLab.root(64, 6));
            Assert.ThrowsException<Exception>(() => mathLab.root(-9, 2));
        }
        /**
         * @brief Tests logarithm function
         */
        [TestMethod]
        public void Logtest()
        {
            Assert.AreEqual(4, mathLab.log(2, 100));
            Assert.AreEqual(0, mathLab.log(0, 100));
            Assert.ThrowsException<NotFiniteNumberException>(() => mathLab.log(2, -5));
            Assert.ThrowsException<NotFiniteNumberException>(() => mathLab.log(2, 0));
        }
    }
}