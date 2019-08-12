// CppLoggingSample.cpp : Defines the entry point for the console application.
//

#include "..\Logger\Native\LoggerProvider.h"

using namespace CodePantheon::Native::Logging;

int main()
{
	// auto logger = LoggerProvider::GetLogger("Unsupported Logger");

	TEXT_LOG_INFO("CppLogging - In Main function");
    return 0;
}

