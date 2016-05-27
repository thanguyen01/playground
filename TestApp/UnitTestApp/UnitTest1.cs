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
            Mathmatics myMathClass = new Mathmatics();

            int answer = myMathClass.Double(10);
            Console.WriteLine(answer);


        }
        [TestMethod]
        public void TestMethod2()
        {
            var myMathClass = new Mathmatics();
            Assert.AreEqual(20, myMathClass.Double(10));
            Console.WriteLine("Pass");
        }
        [TestMethod]
        public void TestMethod3()
        {
            var myMathClass = new Mathmatics();
            Assert.AreEqual(60, myMathClass.Triple(20));
            Console.WriteLine("Pass");
        }
    }
}
