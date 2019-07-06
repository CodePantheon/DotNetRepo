#pragma once

using namespace System;

namespace CodePantheon
{
	namespace Managed
	{
		namespace Logging
		{
			public ref class ILogger abstract
			{
			public:
				virtual void LogInfo(String^ TAG, String^ MESSAGE) = 0;
				virtual void LogWarning(String^ TAG, String^ MESSAGE) = 0;
				virtual void LogError(String^ TAG, String^ MESSAGE) = 0;
			};
		}
	}
}