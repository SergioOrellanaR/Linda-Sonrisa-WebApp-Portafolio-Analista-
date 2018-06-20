using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortafolioNet.Business;

namespace PortafolioTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Commune commune = new Commune()
            {
                Name = "El Bosque"
            };
            Assert.AreEqual(commune.getIdByName(), 8);
        }
    }
}
