#pragma once

#include "DeskboyData.h"
class HttpClient
{
public:
	unsigned int socket;
	DeskboyData & data;
	HttpClient(DeskboyData& data): data(data)
	{

	}
	HttpClient(DeskboyData& data,unsigned int socket) : socket(socket),data(data)
	{

	}
	static unsigned long __stdcall threadFunction(void*p);
	bool work();
};
