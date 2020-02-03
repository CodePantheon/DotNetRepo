namespace CSharpLoggingSample
{
    using CodePantheon.Managed.Logging;

    class Program
    {
        static void Main(string[] args)
        {
            // var logger = LoggerProvider.GetLogger("Unsupported Logger");
            var logger = LoggerProvider.GetLogger("TextLogger");
            logger.LogInfo("CSharpLoggingSample - In Main() method");
        }
    }
}
