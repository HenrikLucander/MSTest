using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Library;
using System.Diagnostics;

namespace Calculator.Library.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Security")]
        [Owner("Henrik")]
        [Priority(2)]
        public void Divide_PositiveNumbers_ReturnsPositiveQuotient()
        {
            // Arrange
            int expected = 5;
            int numerator = 20;
            int denominatior = 4;

            // Act
            int actual = Calculator.Divide(numerator, denominatior);

            // Assert
            Assert.AreEqual(expected, actual);
            TestContext.WriteLine(TestContext.FullyQualifiedTestClassName);
            TestContext.WriteLine(TestContext.TestName);
        }

        // Runs after each unit test
        // Only one method can be decorated with [TestCleanup]
        [TestCleanup]
        public void CleanUp()
        {
            TestContext.WriteLine(TestContext.CurrentTestOutcome.ToString());
        }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Security")]
        [Owner("Henrik")]
        [Priority(2)]
        public void Divide_PositiveNumeratorAndNegativeDenominator_ReturnsNegativeQuotient()
        {
            // Arrange
            int expected = -5;
            int numerator = 20;
            int denominatior = -4;

            // Act
            int actual = Calculator.Divide(numerator, denominatior);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("Calculator")]
        [TestProperty("Test Group", "Performance")]
        [Owner("Lucander")]
        [Priority(1)]
        public void Divide_NegativeNumbers_ReturnsPositiveQuotient()
        {
            // Arrange
            int expected = 5;
            int numerator = -20;
            int denominatior = -4;

            // Act
            int actual = Calculator.Divide(numerator, denominatior);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_DenominatorIsZero_ThrowDivideByZeroException()
        {
            // Arrange
            int numerator = 20;
            int denominatior = 0;

            // Act
            try
            {
                Calculator.Divide(numerator, denominatior);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("Denominator can not be zero", ex.Message);
                throw;
            };
        }

        // Testing private class IsPositive()
        [TestMethod]
        public void IsPositive_PositiveNumber_ReturnsTrue()
        {
            // If private class is static
            PrivateType p = new PrivateType(typeof(Calculator));
            bool actual = (bool)p.InvokeStatic("IsPositive", 10);
            Assert.IsTrue(actual);

            // If private class is not static
            //PrivateObject p = new PrivateObject(typeof(Calculator));
            //bool actual = (bool)p.Invoke("IsPositive", -10);
            //Assert.IsFalse(actual);



        }
    }
}