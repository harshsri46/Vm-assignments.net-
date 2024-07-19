using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestArithmetic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Test()
        {
            Arithmetic ar=  new Arithmetic(); 
            Assert.AreEqual(ar.add(2, 3),5);
        }
        [TestMethod]
        public void Substract_Test()
        {
            Arithmetic ar = new Arithmetic();
            int actualresult = ar.subtract(5, 4);
            int expectedresult = 1;
            Assert.AreEqual(actualresult,expectedresult);
        }
    }
}
