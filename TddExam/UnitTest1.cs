using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TddExam
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TaxiFare taxiFare = new TaxiFare();
            Assert.AreEqual(taxiFare.Calculate(1.0, 0), 6);
            Assert.AreEqual(taxiFare.Calculate(3.0, 0), 7);
            Assert.AreEqual(taxiFare.Calculate(10.0, 0), 13);
            Assert.AreEqual(taxiFare.Calculate(2.0, 3), 7);
        }
    }
}
