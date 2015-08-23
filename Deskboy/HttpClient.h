#pragma once


class HttpClient
{
public:
	unsigned int socket;
	HttpClient()
	{

	}
	HttpClient(unsigned int socket) : socket(socket)
	{

	}
	static unsigned long __stdcall threadFunction(void*p);
	bool work();
};
