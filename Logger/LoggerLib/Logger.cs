using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib
{
    internal class Logger : ILogger
    {
        private IWriter writer;

        public Logger(IWriter writer)
        {
            this.writer = writer;
        }

        public void LogError(string errorText)
        {
            throw new NotImplementedException();
        }

        public void LogInfo(string infoText)
        {
            throw new NotImplementedException();
        }

        public void LogWarning(string warningText)
        {
            throw new NotImplementedException();
        }
    }
}
