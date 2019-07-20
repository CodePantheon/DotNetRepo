#pragma once

using namespace System;
using namespace System::Runtime::CompilerServices;
using namespace System::Runtime::InteropServices;

namespace CodePantheon
{
	namespace Managed
	{
		namespace Logging
		{
			public ref class ILogger abstract
			{
			public:
				virtual void LogInfo(String^ MESSAGE, [CallerMemberName][Optional] String^ memberName, [CallerFilePath][Optional] String^ callerFilePath) = 0;
				virtual void LogWarning(String^ MESSAGE, [CallerMemberName][Optional] String^ memberName, [CallerFilePath][Optional] String^ callerFilePath) = 0;
				virtual void LogError(String^ MESSAGE, [CallerMemberName][Optional] String^ memberName, [CallerFilePath][Optional] String^ callerFilePath) = 0;
			};
		}
	}
}