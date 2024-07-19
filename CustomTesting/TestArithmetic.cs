using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CustomTesting
{
    [TestClass]
    public class TestArithmetic
    {
        [TestMethod]
        public void Test_Add()
        {
            Arithmetic ar= new Arithmetic();
            int actualresult = ar.Add(2, 3);
            Assert.AreEqual(5, actualresult);

        }
        [TestMethod] 
        public void Test_AddWithNull()
        {
            Arithmetic ar=  new Arithmetic();
            Assert.ThrowsException<ArgumentNullException>(()=>ar.Add(2,null));
        }
        [TestMethod]
        public void Test_Substract()
        {
            Arithmetic ar= new Arithmetic();
            int actualresult=ar.substract(4, 3);
            Assert.AreEqual(1, actualresult);
        }
        [TestMethod]
        public void Test_SubstractWithNull()
        {
            Arithmetic ar = new Arithmetic();
            Assert.ThrowsException<ArgumentNullException>(() => ar.substract(2, null));
        }
        [TestMethod]
        public void Test_Multiply()
        {
            Arithmetic ar = new Arithmetic();
            int actualresult = ar.multiply(4, 5);
            Assert.AreEqual(20, actualresult);
        }
        [TestMethod]
        public void Test_MultiplyWithNull()
        {
            Arithmetic ar=new Arithmetic();
            Assert.ThrowsException<ArgumentNullException>(() => ar.multiply(2, null));
        }
        [TestMethod]
        public void Test_Divide()
        {
            Arithmetic ar= new Arithmetic();
            double actualresult = ar.divide(6, 3);
            Assert.AreEqual((double)2, actualresult);
        }
        [TestMethod]
        public void Test_DivideWithNull()
        {
            Arithmetic ar=new Arithmetic();
            Assert.ThrowsException<ArgumentNullException>(() => ar.divide(2, null));
        }
        
    }
}
