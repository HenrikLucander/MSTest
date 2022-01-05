using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Library;
using System.Diagnostics;

namespace Calculator.Library.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Test_Divide()
        {
            // Arrange
            int expected = 5;
            int numerator = 20;
            int denominatior = 4;

            // Act
            int actual = Calculator.Divide(numerator, denominatior);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}