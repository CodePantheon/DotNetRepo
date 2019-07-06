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
				void LogInfo(string TAG, string MESSAGE) override;
				void LogWarning(string TAG, string MESSAGE) override;
				void LogError(string TAG, string MESSAGE) override;
			private:
				static String^ ConvertToManagedString(string input);

			private:
				gcroot<Managed::Logging::ILogger^> myManagedLogger;
			};
		}
	}
}