#include "LoggerProxy.h"
#include "LoggerProvider.h"

namespace CodePantheon
{
	namespace Native
	{
		namespace Logging
		{
			ILogger* LoggerProvider::myLoggerInstance;

			ILogger* LoggerProvider::GetLogger(const string loggerType)
			{
				if (myLoggerInstance != nullptr)
				{
					return myLoggerInstance;
				}
				else
				{
					myLoggerInstance = new LoggerProxy(loggerType);
					return myLoggerInstance;
				}
			}
		}
	}
}