using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Example;

namespace Tutorial_UnitTest
{

    public delegate bool TestTemperature(double t);

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

        [TestMethod]
        public void TestLambdaExpressions()
        {
#pragma warning disable IDE0039 // Use local function
            Func<Temperature, bool> isTemperatureModerate = t => t.Temp > 50.00 && t.Temp < 90.00;
#pragma warning restore IDE0039 // Use local function

            Temperature myTemp = new Temperature(80.05d);

            bool myResult = isTemperatureModerate(myTemp); // should return true

            Assert.AreEqual(true, myResult);
        }

        [TestMethod]
        public void TestLambdaExpressions2()
        {
#pragma warning disable IDE0039 // Use local function
            Func<int, int, int> Sum = (x, y) => x + y;
#pragma warning restore IDE0039 // Use local function
            int myResult = Sum(10,20);

            Assert.AreEqual(30, myResult);
        }

    }
}
