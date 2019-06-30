
namespace LoggerLibTests
{
    using LoggerLib;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using System;
    using System.Diagnostics;

    [TestClass]
    public class LoggerTest
    {
        private Mock<IWriter> mockWriter;
        private Mock<IDateTimeProvider> mockDateTimeProvider;
        private Logger logger;

        [TestInitialize]
        public void TestInit()
        {
            mockWriter = new Mock<IWriter>();
            mockDateTimeProvider = new Mock<IDateTimeProvider>();
            logger = new Logger(mockWriter.Object, mockDateTimeProvider.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructor_WriterNull_ArgumentNullException()
        {
            // Arrange
            logger = new Logger(null, mockDateTimeProvider.Object);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructor_DateTimeProviderNull_ArgumentNullException()
        {
            // Arrange
            logger = new Logger(mockWriter.Object, null);
        }

        [TestMethod]
        public void ConstructorTest()
        {
            // Assert
            Assert.IsNotNull(logger);
        }

        [TestMethod]
        public void Test_LogInfo()
        {
            // Arrange
            string textToLog = "SampleTestLog";
            string memberName = new StackTrace().GetFrame(0).GetMethod().Name;
            string callerFilePath = new StackFrame(0, true).GetFileName();
            DateTime dateTimeNow = DateTime.Now;
            this.mockDateTimeProvider.Setup(m => m.CurrentDateTime).Returns(dateTimeNow);
            string expectedLogText = string.Format("{0} {1}:{2} {3} {4}", dateTimeNow.ToString(), "Info", textToLog, callerFilePath, memberName);

            // Act
            logger.LogInfo(textToLog);

            // Assert
            mockWriter.Verify(m => m.Write(expectedLogText), Times.Once);
        }

        [TestMethod]
        public void Test_LogWarning()
        {
            // Arrange
            string textToLog = "SampleTestLog";
            string memberName = new StackTrace().GetFrame(0).GetMethod().Name;
            string callerFilePath = new StackFrame(0, true).GetFileName();
            DateTime dateTimeNow = DateTime.Now;
            this.mockDateTimeProvider.Setup(m => m.CurrentDateTime).Returns(dateTimeNow);
            string expectedLogText = string.Format("{0} {1}:{2} {3} {4}", dateTimeNow.ToString(), "Warn", textToLog, callerFilePath, memberName);

            // Act
            logger.LogWarning(textToLog);

            // Assert
            mockWriter.Verify(m => m.Write(expectedLogText), Times.Once);
        }

        [TestMethod]
        public void Test_LogError()
        {
            // Arrange
            string textToLog = "SampleTestLog";
            string memberName = new StackTrace().GetFrame(0).GetMethod().Name;
            string callerFilePath = new StackFrame(0, true).GetFileName();
            DateTime dateTimeNow = DateTime.Now;
            this.mockDateTimeProvider.Setup(m => m.CurrentDateTime).Returns(dateTimeNow);
            string expectedLogText = string.Format("{0} {1}:{2} {3} {4}", dateTimeNow.ToString(), "Error", textToLog, callerFilePath, memberName);

            // Act
            logger.LogError(textToLog);

            // Assert
            mockWriter.Verify(m => m.Write(expectedLogText), Times.Once);
        }
    }
}
