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

			void LoggerProxy::LogInfo(const string TAG, const string MESSAGE)
			{
				myManagedLogger->LogInfo(ConvertToManagedString(TAG), ConvertToManagedString(MESSAGE));
			}

			void LoggerProxy::LogWarning(const string TAG, const string MESSAGE)
			{
				myManagedLogger->LogWarning(ConvertToManagedString(TAG), ConvertToManagedString(MESSAGE));
			}

			void LoggerProxy::LogError(const string TAG, const string MESSAGE)
			{
				myManagedLogger->LogError(ConvertToManagedString(TAG), ConvertToManagedString(MESSAGE));
			}

			String^ LoggerProxy::ConvertToManagedString(string input)
			{
				return msclr::interop::marshal_as<String^>(input);
			}
		}
	}
}