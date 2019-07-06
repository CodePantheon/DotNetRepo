#include "Logger.h"
#include "ManagedLoggerProvider.h"

using namespace CodePantheon::LogIO;

namespace CodePantheon
{
	namespace Managed
	{
		namespace Logging
		{
			ILogger^ LoggerProvider::GetLogger(String^ loggerType)
			{
				if (myLoggerInstance != nullptr)
				{
					return myLoggerInstance;
				}
				else
				{
					auto logWriter = LogWriterFactory::Create(loggerType);
					myLoggerInstance = gcnew Logger(logWriter);
					return myLoggerInstance;
				}
			}
		}
	}
}