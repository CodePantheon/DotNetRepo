#pragma once
#include<string>

using namespace std;

namespace CodePantheon
{
	namespace Native
	{
		namespace Logging
		{
			class ILogger abstract
			{
			public:
				virtual void LogInfo(string MESSAGE, string functionName, string callerFilePath) = 0;
				virtual void LogWarning(string MESSAGE, string functionName, string callerFilePath) = 0;
				virtual void LogError(string MESSAGE, string functionName, string callerFilePath) = 0;
			};
		}
	}
}