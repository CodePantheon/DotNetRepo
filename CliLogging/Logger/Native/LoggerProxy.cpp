#include "msclr\marshal_cppstd.h"
#include "LoggerProxy.h"
#include "Managed\ManagedLoggerProvider.h"

namespace CodePantheon
{
	namespace Native
	{
		namespace Logging
		{
			LoggerProxy::LoggerProxy(string loggerType)
			{
				myManagedLogger = LoggerProvider::GetLogger(ConvertToManagedString(loggerType));
			}

			void LoggerProxy::LogInfo(const string MESSAGE, const string functionName, const string callerFilePath)
			{
				myManagedLogger->LogInfo(ConvertToManagedString(MESSAGE), ConvertToManagedString(functionName), ConvertToManagedString(callerFilePath));
			}

			void LoggerProxy::LogWarning(const string MESSAGE, const string functionName, const string callerFilePath)
			{
				myManagedLogger->LogWarning(ConvertToManagedString(MESSAGE), ConvertToManagedString(functionName), ConvertToManagedString(callerFilePath));
			}

			void LoggerProxy::LogError(const string MESSAGE, const string functionName, const string callerFilePath)
			{
				myManagedLogger->LogError(ConvertToManagedString(MESSAGE), ConvertToManagedString(functionName), ConvertToManagedString(callerFilePath));
			}

			String^ LoggerProxy::ConvertToManagedString(string input)
			{
				return msclr::interop::marshal_as<String^>(input);
			}
		}
	}
}