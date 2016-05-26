using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;

namespace UnitTestApp
{
    
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void TestMethod1()
        {
            var myMathClass = new Mathmatics();
            myMathClass.Double(10);


        }
        [TestMethod]
        public void TestMethod2()
        {
            var myMathClass = new Mathmatics();
            //Assert.AreEqual(value, Method)
            Assert.AreEqual(20, myMathClass.Double(10));
        }
        [TestMethod]
        public void TestMethod3()
        {
            var myMathClass = new Mathmatics();
            Assert.AreEqual(60, myMathClass.Triple(20));
        }
    }
}
