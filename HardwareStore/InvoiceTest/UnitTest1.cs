using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HardwareStore;

namespace InvoiceTest
{
    [TestClass]
    public class InvoiceTests
    {
        [TestMethod]
        public void TestGetInoviceAmount()
        {
            Invoice invoice1 = new Invoice("1234", "Hammer", 2, 15.95M);
            Assert.AreEqual(31.90M, invoice1.GetInvoiceAmount());
        }
        [TestMethod]
        public void TestPartNumberProperty()
        {
            Invoice invoice1 = new Invoice("1234", "Hammer", 2, 15.95M);
            Assert.AreEqual("1234", invoice1.PartNumber);

        }
        [TestMethod]
        public void TestQuanityProperty()
        {
            Invoice invoice1 = new Invoice("1234", "Hammer", 2, 15.95M);
            Assert.AreEqual(2, invoice1.Quantity);

        }
        [TestMethod]
        public void TestPriceProperty()
        {
            Invoice invoice1 = new Invoice("1234", "Hammer", 2, -15.95M);
            Assert.AreEqual(0, invoice1.Price);

        }
    }
}
