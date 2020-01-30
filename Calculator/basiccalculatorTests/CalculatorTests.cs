using Microsoft.VisualStudio.TestTools.UnitTesting;
using basiccalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace basiccalculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var c = Calculator.Add(1, 2);
            Assert.AreEqual(3, c);

        }

        [TestMethod()]
        public void SubtractTest()
        {
            var c = Calculator.Subtract(1, 2);
            Assert.AreEqual(-1, c);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            var c = Calculator.Multiply(5, 6);
            Assert.AreEqual(30, c);
        }

        [TestMethod()]
        public void DivideTest()
        {
            var c = Calculator.Divide(99, 11);
            Assert.AreEqual(9, c);
        }
    }
}