
namespace LoggerLib
{
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Logger class.
    /// </summary>
    internal class Logger : ILogger
    {
        private IWriter writer;
        private readonly string logTime = DateTime.Now.ToString();
        private readonly string info = "Info";
        private readonly string warning = "Warn";
        private readonly string error = "Error";

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        /// <param name="writer"></param>
        public Logger(IWriter writer)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer cannot be null!");
            }

            this.writer = writer;
        }

        public void LogInfo(string infoText, [CallerMemberName] string memberName = "", [CallerFilePath] string callerFilePath = "")
        {
            this.writer.Write(string.Format("{0} {1}:{2} {3} {4}", logTime, info, infoText, callerFilePath, memberName));
        }

        public void LogWarning(string warningText, [CallerMemberName] string memberName = "", [CallerFilePath] string callerFilePath = "")
        {
            this.writer.Write(string.Format("{0} {1}:{2} {3} {4}", logTime, warning, warningText, callerFilePath, memberName));
        }

        public void LogError(string errorText, [CallerMemberName] string memberName = "", [CallerFilePath] string callerFilePath = "")
        {
            this.writer.Write(string.Format("{0} {1}:{2} {3} {4}", logTime, error ,errorText, callerFilePath, memberName));
        }
    }
}
