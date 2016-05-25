using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //(Referenced Project.Class.Method(Value))
            TestApp.MathOperations.Double(10);

        }
        [TestMethod]
        public void TestMethod2()
        {
            //Assert.AreEqual(value, Method)
            Assert.AreEqual(20, TestApp.MathOperations.Double(10));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(60, TestApp.MathOperations.Triple(20));
        }
    }
}
