
namespace CalculatorLibTests
{
    using CalculatorLib;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestMethod]
        public void Test_Add_NegativeNumbers()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            double sum = calculator.Add(-5.6, 10.6);

            // Assert
            Assert.AreEqual(5, sum);
        }

        [TestMethod]
        public void Test_Subtract_WholeNumbers()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            double difference = calculator.Subtract(5, 3);

            // Assert
            Assert.AreEqual(2, difference);
        }

        [TestMethod]
        public void Test_Subtract_FractionalNumbers()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            double difference = calculator.Subtract(5.3, 2.3);

            // Assert
            Assert.AreEqual(3, difference);
        }

        [TestMethod]
        public void Test_Subtract_MinuedNegative()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            double difference = calculator.Subtract(-5.3, 2.3);

            // Assert
            Assert.AreEqual(-7.6, difference);
        }

        [TestMethod]
        public void Test_Subtract_BothNegativeNumbers()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            double difference = calculator.Subtract(-5.3, -2.3);

            // Assert
            Assert.AreEqual(-3.0, difference);
        }

        [TestMethod]
        public void Test_Subtract_MinuedLessThanSubtrahend()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            double difference = calculator.Subtract(5.3, 7.3);

            // Assert
            Assert.AreEqual(-2, difference);
        }

    }
}
