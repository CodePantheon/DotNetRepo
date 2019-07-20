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
				void LogInfo(String^ MESSAGE, [CallerMemberName][Optional] String^ memberName, [CallerFilePath][Optional] String^ callerFilePath) override;
				void LogWarning(String^ MESSAGE, [CallerMemberName][Optional] String^ memberName, [CallerFilePath][Optional] String^ callerFilePath) override;
				void LogError(String^ MESSAGE, [CallerMemberName][Optional] String^ memberName, [CallerFilePath][Optional] String^ callerFilePath) override;

			private:
				ILogWriter^ myLogWriter;
			};
		}
	}
}