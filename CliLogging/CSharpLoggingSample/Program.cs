namespace CSharpLoggingSample
{
    using CodePantheon.Managed.Logging;

    class Program
    {
        static void Main(string[] args)
        {
            // var logger = LoggerProvider.GetLogger("Unsupported Logger");
            var logger = LoggerProvider.GetLogger("EventLogger");
            logger.LogInfo("CSharpLogging", "In Main() method");
        }
    }
}
