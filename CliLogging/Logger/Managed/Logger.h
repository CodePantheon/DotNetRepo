#pragma once
#include "ILogger.h"

using namespace CodePantheon::LogIO;

namespace CodePantheon
{
	namespace Managed
	{
		namespace Logging
		{
			public ref class Logger : public ILogger
			{
			public:
				Logger(ILogWriter^ logWriter);
				void LogInfo(String^ TAG, String^ MESSAGE) override;
				void LogWarning(String^ TAG, String^ MESSAGE) override;
				void LogError(String^ TAG, String^ MESSAGE) override;

			private:
				ILogWriter^ myLogWriter;
			};
		}
	}
}