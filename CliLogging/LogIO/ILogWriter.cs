namespace CodePantheon.LogIO
{
    public enum LogLevel
    {
        INFO,
        WARNING,
        ERROR
    }

    /// <summary>
    /// 
    /// </summary>
    public interface ILogWriter
    {
        void WriteLog(LogData logData);
    }
}