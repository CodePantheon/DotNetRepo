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
				virtual void LogInfo(string MESSAGE) = 0;
				virtual void LogWarning(string MESSAGE) = 0;
				virtual void LogError(string MESSAGE) = 0;
			};
		}
	}
}