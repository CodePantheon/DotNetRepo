namespace CodePantheon.LogIO
{
    public enum LogType
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
        void WriteLog(LogType logType, string date, string tag, string message);
    }
}