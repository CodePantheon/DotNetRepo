
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
        private Logger logger;

        [TestInitialize]
        public void TestInit()
        {
            mockWriter = new Mock<IWriter>();
            logger = new Logger(mockWriter.Object);
        }

        [TestMethod]
        public void ConstructorTest()
        {
            // Assert
            Assert.IsNotNull(logger); ;
        }

        [TestMethod]
        public void Test_LogInfo()
        {
            // Arrange
            string textToLog = "SampleTestLog";
            string memberName = new StackTrace().GetFrame(0).GetMethod().Name;
            string callerFilePath = new StackFrame(2, true).GetFileName();
            string expectedLogText = string.Format("{0} {1}:{2} {3} {4}", DateTime.Now.ToString(), "Info", textToLog, callerFilePath, memberName);

            // Act
            logger.LogInfo(textToLog);

            // Assert
            mockWriter.Verify(m => m.Write(expectedLogText), Times.Once);
        }
    }
}
