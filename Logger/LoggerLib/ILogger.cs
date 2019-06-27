using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib
{
    public interface ILogger
    {
        void LogInfo(string infoText);

        void LogWarning(string warningText);

        void LogError(string errorText);
    }
}
