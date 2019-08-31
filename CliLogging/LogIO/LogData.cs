using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePantheon.LogIO
{
    /// <summary>
    /// LogData class encapsulating log information.
    /// </summary>
    public class LogData
    {
        public LogData(string dateTime, LogLevel logLevel, string message, string sourceFunction, string sourceFile)
        {
            this.LogDateTime = dateTime;
            this.LogLevel = logLevel;
            this.LogMessage = message;
            this.LogSourceFunction = sourceFunction;
            this.LogSourceFile = sourceFile;
        }

        public string LogDateTime { get; }

        public LogLevel LogLevel { get; }

        public string LogMessage { get; }

        public string LogSourceFunction { get; }

        public string LogSourceFile { get; }

        public override string ToString()
        {
            return ($"{LogDateTime} {LogLevel} {LogMessage} from {LogSourceFile}-{LogSourceFunction}");
        }
    }
}
