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
	addr.sin_port = MAKEWORD(0, 8088);
	socket = ::socket(AF_INET, SOCK_STREAM,IPPROTO_TCP );
	
	bind(socket, (sockaddr*)&addr,sizeof(addr));
	listen(socket, 4);
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
		HttpClient * client = new HttpClient(s);
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
