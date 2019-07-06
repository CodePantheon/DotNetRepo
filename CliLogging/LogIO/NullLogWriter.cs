namespace CodePantheon.LogIO
{
    /// <summary>
    /// 
    /// </summary>
    internal class NullLogWriter : ILogWriter
    {
        public void WriteLog(LogType logType, string date, string tag, string message)
        {
            // TODO
        }
    }
}