#include "Logger.h"

namespace CodePantheon
{
	namespace Managed
	{
		namespace Logging
		{
			Logger::Logger(ILogWriter^ logWriter)
			{
				myLogWriter = logWriter;
			}

			void Logger::LogInfo(String^ message, String^ memberName, String^ callerFilePath)
			{
				String^ currentDate = DateTime::Now.ToString("g");
				myLogWriter->WriteLog(gcnew LogData(currentDate, LogLevel::INFO, message, memberName, callerFilePath));
			}

			void Logger::LogWarning(String^ message, String^ memberName, String^ callerFilePath)
			{
				String^ currentDate = DateTime::Now.ToString("g");
				myLogWriter->WriteLog(gcnew LogData(currentDate, LogLevel::WARNING, message, memberName, callerFilePath));
			}

			void Logger::LogError(String^ message, String^ memberName, String^ callerFilePath)
			{
				String^ currentDate = DateTime::Now.ToString("g");
				myLogWriter->WriteLog(gcnew LogData(currentDate, LogLevel::ERROR, message, memberName, callerFilePath));
			}
		}
	}
}