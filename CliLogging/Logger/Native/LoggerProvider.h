#pragma once
#include<string>
#include "ILogger.h"
#include <sstream>

using namespace std;

#ifdef LOGGER_PROVIDER_EXPORT
#define LOGGER_PROVIDER_API _declspec(dllexport)
#else
#define LOGGER_PROVIDER_API _declspec(dllimport)
#endif

#define TEXT_LOG_INFO(message) \
{ auto logger = LoggerProvider::GetLogger("TextLogger"); logger->LogInfo(message, __FUNCTION__, __FILE__); }

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