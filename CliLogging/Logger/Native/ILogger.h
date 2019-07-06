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
				virtual void LogInfo(string TAG, string MESSAGE) = 0;
				virtual void LogWarning(string TAG, string MESSAGE) = 0;
				virtual void LogError(string TAG, string MESSAGE) = 0;
			};
		}
	}
}