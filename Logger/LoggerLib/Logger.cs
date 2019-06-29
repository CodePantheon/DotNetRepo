
namespace LoggerLib
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Logger class.
    /// </summary>
    public class Logger : ILogger
    {
        private IWriter writer;
        private readonly string logTime = DateTime.Now.ToString();

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        /// <param name="writer"></param>
        public Logger(IWriter writer)
        {
            this.writer = writer;
        }

        public void LogInfo(string infoText, [CallerMemberName] string memberName = "", [CallerFilePath] string callerFilePath = "")
        {
            this.writer.Write(string.Format("{0} {1} {2} {3}", logTime, infoText, callerFilePath, memberName));
        }

        public void LogWarning(string warningText, [CallerMemberName] string memberName = "", [CallerFilePath] string callerFilePath = "")
        {
            this.writer.Write(string.Format("{0} {1} {2} {3}", logTime, warningText, callerFilePath, memberName));
        }

        public void LogError(string errorText, [CallerMemberName] string memberName = "", [CallerFilePath] string callerFilePath = "")
        {
            this.writer.Write(string.Format("{0} {1} {2} {3}", logTime, errorText, callerFilePath, memberName));
        }
    }
}
