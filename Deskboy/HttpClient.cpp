#include "stdafx.h"
#include "HttpClient.h"
//#include <Windows.h>
//#include <WinSock2.h>
#pragma comment(lib,"ws2_32.lib")
unsigned long __stdcall HttpClient::threadFunction(void*p)
{
	HttpClient*_this = (HttpClient*)p;
	_this->work();
	return 0;
}
bool HttpClient::work()
{
	int read = 0;
	char buffer[1024];
	while ((read = recv(socket, buffer, sizeof(buffer), 0 )) != -1)
	{
		if (read == 0)
		{

		}
		else
		{
			buffer[read] = 0;
			OutputDebugStringA(buffer);
		}
	}
	return 0;
}


