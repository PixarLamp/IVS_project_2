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
        }

        [TestMethod]
        public void subtest()
        {
            Assert.AreEqual(10, subtaction(15, 5))
        }
    }
}
