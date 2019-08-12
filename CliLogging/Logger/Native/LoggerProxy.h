// Logger.h

#pragma once
#include <vcclr.h>
#include "ILogger.h"
#include "Managed\Logger.h"

using namespace System;
using namespace CodePantheon::Managed::Logging;

namespace CodePantheon
{
	namespace Native
	{
		namespace Logging
		{
			public class LoggerProxy : public ILogger
			{
			public:
				LoggerProxy(string loggerType);
				void LogInfo(string MESSAGE, string functionName, string callerFilePath) override;
				void LogWarning(string MESSAGE, string functionName, string callerFilePath) override;
				void LogError(string MESSAGE, string functionName, string callerFilePath) override;
			private:
				static String^ ConvertToManagedString(string input);

			private:
				gcroot<Managed::Logging::ILogger^> myManagedLogger;
			};
		}
	}
}