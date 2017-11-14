using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CalculatorTests
{    
    [TestClass]
    public class CalculatorTestSuite
    {
        HelloNew.Calculator calc;
         
        [TestInitialize]
        public void TestInit()
        {
            calc = new HelloNew.Calculator();
        }


        [TestMethod]
        public void testValidDiv()
        {
            double x = 100;
            double y = 200;
            double div = calc.division(x, y);
            Assert.AreEqual(0.5, div);
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void testDivByZero()
        {
            double x = 100;
            double y = 0;
            double div = calc.division(x, y);            
        }
    }
}
