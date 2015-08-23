#pragma once

class Listener
{

public:
	unsigned int socket = -1;
	~Listener();
	static unsigned long __stdcall threadFunction(void* p);
	bool prepare();
	bool run();
	unsigned long start();
};
