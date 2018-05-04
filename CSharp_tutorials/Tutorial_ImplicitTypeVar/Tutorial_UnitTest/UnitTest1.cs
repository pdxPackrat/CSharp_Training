using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tutorial_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForInt32()
        {
            var i = 100;

            Assert.AreEqual(true, i.GetType().ToString().Equals("System.Int32"));
        }

        [TestMethod]
        public void TestForString()
        {
            var str = "Hello World!!";

            Assert.AreEqual(true, str.GetType().ToString().Equals("System.String"));
        }

        [TestMethod]
        public void TestForDouble()
        {
            var d = 100.55d;

            Assert.AreEqual(true, d.GetType().ToString().Equals("System.Double"));
        }

        [TestMethod]
        public void TestForBoolean()
        {
            var b = true;

            Assert.AreEqual(true, b.GetType().ToString().Equals("System.Boolean"));
        }
    }
}
