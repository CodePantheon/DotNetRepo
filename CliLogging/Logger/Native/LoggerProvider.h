#pragma once
#include<string>
#include "ILogger.h"

using namespace std;

#ifdef LOGGER_PROVIDER_EXPORT
#define LOGGER_PROVIDER_API _declspec(dllexport)
#else
#define LOGGER_PROVIDER_API _declspec(dllimport)
#endif

namespace CodePantheon
{
	namespace Native
	{
		namespace Logging
		{
			class LOGGER_PROVIDER_API LoggerProvider
			{
			public:
				static ILogger* GetLogger(const string loggerType);

			private:
				static ILogger* myLoggerInstance;
			};
		}
	}
}