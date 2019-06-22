using System;
using CalculatorLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorLibTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Test_Add_WholeNumbers()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            double sum = calculator.Add(3, 5);

            // Assert
            Assert.AreEqual(8, sum);
        }

        [TestMethod]
        public void Test_Add_FractionalNumbers()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            double sum = calculator.Add(3.7, 5.3);

            // Assert
            Assert.AreEqual(9, sum);
        }
    }
}
