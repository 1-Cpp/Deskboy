#include "stdafx.h"
#include "Listener.h"
#include "HttpClient.h"
//#include <Windows.h>
Listener::~Listener()
{
	WSACleanup();
}
unsigned long __stdcall Listener::threadFunction(void* p)
{
	Listener * _this = (Listener *)p;
	_this->run();
	return 0;
}
bool Listener::prepare()
{
	sockaddr_in addr;
	WSADATA wsaData;
	memset(&wsaData, 0, sizeof(wsaData));
	WORD word = 0x0101;
	WSAStartup(word, &wsaData);
	memset(&addr, 0, sizeof(addr));
	addr.sin_family = PF_INET;
	addr.sin_port = htons(8088);
	socket = ::socket(AF_INET, SOCK_STREAM,IPPROTO_TCP );
	if (socket == SOCKET_ERROR)
	{
		OutputDebugStringA("socket error\n");
		return false;
	}
	int ret = bind(socket, (sockaddr*)&addr,sizeof(addr));
	if (ret == SOCKET_ERROR)
	{
		OutputDebugStringA("bind error\n");
		return false;
	}
	listen(socket, 4);
	OutputDebugStringA("listen success\n");
	return true;
}

bool Listener::run()
{
	SOCKET s = 0;
	sockaddr sender;
	memset(&sender, 0, sizeof(sender));
	sender.sa_family = AF_INET;
	int size = sizeof(sender);
	while ( (s = accept(socket, &sender, &size)) != SOCKET_ERROR)
	{
		unsigned long threadId = 0;
		HttpClient * client = new HttpClient(data,s);
		CreateThread(NULL, 0, &HttpClient::threadFunction, client, 0, &threadId);
	}
	DWORD dwErr = WSAGetLastError();

	return true;
}
unsigned long Listener::start()
{
	unsigned long threadId = 0;
	CreateThread(NULL, 0, &threadFunction, this, 0, &threadId);
	return 0;
}
