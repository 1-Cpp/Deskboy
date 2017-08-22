#pragma once
#include <vector>
#include "DeskboyData.h"

class Listener
{

public:
	unsigned int socket = -1;
	DeskboyData & data;
	Listener(DeskboyData&data) : data(data)
	{
		
	}
	~Listener();
	static unsigned long __stdcall threadFunction(void* p);
	bool prepare();
	bool run();
	unsigned long start();
};
