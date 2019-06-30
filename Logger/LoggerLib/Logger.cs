
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
        private IDateTimeProvider dateTimeProvider;
        private readonly string info = "Info";
        private readonly string warning = "Warn";
        private readonly string error = "Error";

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        /// <param name="writer"></param>
        public Logger(IWriter writer, IDateTimeProvider dateTimeProvider)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer cannot be null!");
            }

            if (dateTimeProvider == null)
            {
                throw new ArgumentNullException("dateTimeProvider cannot be null!");
            }

            this.writer = writer;
            this.dateTimeProvider = dateTimeProvider;
        }

        public void LogInfo(string infoText, [CallerMemberName] string memberName = "", [CallerFilePath] string callerFilePath = "")
        {
            this.writer.Write(string.Format("{0} {1}:{2} {3} {4}", LogTime, info, infoText, callerFilePath, memberName));
        }

        public void LogWarning(string warningText, [CallerMemberName] string memberName = "", [CallerFilePath] string callerFilePath = "")
        {
            this.writer.Write(string.Format("{0} {1}:{2} {3} {4}", LogTime, warning, warningText, callerFilePath, memberName));
        }

        public void LogError(string errorText, [CallerMemberName] string memberName = "", [CallerFilePath] string callerFilePath = "")
        {
            this.writer.Write(string.Format("{0} {1}:{2} {3} {4}", LogTime, error ,errorText, callerFilePath, memberName));
        }

        private string LogTime => this.dateTimeProvider.CurrentDateTime.ToString();
    }
}
