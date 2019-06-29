
namespace LoggerLib
{
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Interface for Logger types.
    /// </summary>
    public interface ILogger
    {
        void LogInfo(string infoText, [CallerMemberName] string memberName = "", [CallerFilePath] string callerFilePath = "");

        void LogWarning(string warningText, [CallerMemberName] string memberName = "", [CallerFilePath] string callerFilePath = "");

        void LogError(string errorText, [CallerMemberName] string memberName = "", [CallerFilePath] string callerFilePath = "");
    }
}
