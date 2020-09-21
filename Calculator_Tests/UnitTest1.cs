using System;
using dNET;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calculate_3Plus2_5Returnded()
        {
            Assert.AreEqual(Calculator.Calculate(3,"+",2),5);
        }
        [TestMethod]
        public void Calculate_5Minus0_5Returnded()
        {
            Assert.AreEqual(Calculator.Calculate(5,"-",0),5);
        }
        [TestMethod]
        public void Calculate_5divide5_1Returnded()
        {
            Assert.AreEqual(Calculator.Calculate(5,"/",5),1);
        }
        [TestMethod]
        public void Calculate_5mult5_25Returnded()
        {
            Assert.AreEqual(Calculator.Calculate(5,"*",5),25);
        }
        [TestMethod]
        public void Calculate_ArgumaentException_ExceptionReturned()
        {
            Assert.ThrowsException<ArgumentException>(() => Calculator.Calculate(5, "nope", 5), "Invalid operation");
        }
        [TestMethod]
        public void Calculate_5divide0_ExceptionReturned()
        {
            Assert.ThrowsException<Exception>(() => Calculator.Calculate(5, "/", 0), "zero divided");
        }


    }
}