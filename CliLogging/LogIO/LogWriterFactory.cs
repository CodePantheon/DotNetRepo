namespace CodePantheon.LogIO
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Remoting;
    using Newtonsoft.Json;

    /// <summary>
    /// 
    /// </summary>
    public static class LogWriterFactory
    {
        private const string LOG_WRITERS_CONFIG = @"config\LogWriters.json";

        private static readonly IDictionary<string, ILogWriter> LogWriters = new Dictionary<string, ILogWriter>();

        static LogWriterFactory()
        {
            EnumerateLogWriters();
        }

        public static ILogWriter Create(LoggerType loggerType)
        {
            return Create(loggerType.ToString());
        }

        public static ILogWriter Create(string loggerType)
        {
            if (LogWriters.ContainsKey(loggerType))
            {
                return LogWriters[loggerType];
            }
            else
            {
                return new NullLogWriter();
            }
        }

        private static void EnumerateLogWriters()
        {
            foreach (var logWriterInfo in JsonConfigParser.Parse(LOG_WRITERS_CONFIG))
            {
                var logWriter = CreateLogWriter(logWriterInfo);
                LogWriters[logWriterInfo.LoggerType] = logWriter;
            }
        }

        private static ILogWriter CreateLogWriter(LogWriterInfo logWriterInfo)
        {
            string className = logWriterInfo.LogWriterClassName;
            string assemblyName = logWriterInfo.LogWriterAssemblyName;
            
            ObjectHandle handle = Activator.CreateInstance(assemblyName, className);
            object logWriter = handle.Unwrap();

            return logWriter as ILogWriter ?? new NullLogWriter();
        }

        /// <summary>
        /// 
        /// </summary>
        private static class JsonConfigParser
        {
            public static IEnumerable<LogWriterInfo> Parse(string fileName)
            {
                string jsonString = File.ReadAllText(fileName);
                return JsonConvert.DeserializeObject<IList<LogWriterInfo>>(jsonString);
            }
        }
    }
}