#pragma once
#include "ILogger.h"

namespace CodePantheon
{
	namespace Managed
	{
		namespace Logging
		{
			public ref class LoggerProvider
			{
			public:
				static ILogger^ GetLogger(String^ loggerType);
			private:
				LoggerProvider(){}

			private:
				static ILogger^ myLoggerInstance;
			};
		}
	}
}