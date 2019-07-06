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

			void Logger::LogInfo(String^ tag, String^ message)
			{
				String^ currentDate = DateTime::Now.ToString("g");
				myLogWriter->WriteLog(LogType::INFO, currentDate, tag, message);
			}

			void Logger::LogWarning(String^ tag, String^ message)
			{
				String^ currentDate = DateTime::Now.ToString("g");
				myLogWriter->WriteLog(LogType::WARNING, currentDate, tag, message);
			}

			void Logger::LogError(String^ tag, String^ message)
			{
				String^ currentDate = DateTime::Now.ToString("g");
				myLogWriter->WriteLog(LogType::ERROR, currentDate, tag, message);
			}
		}
	}
}