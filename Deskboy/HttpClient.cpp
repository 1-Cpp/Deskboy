#include "stdafx.h"

#include "HttpClient.h"

//#include <Windows.h>
//#include <WinSock2.h>
#pragma comment(lib,"ws2_32.lib")

std::string s_convert_utf16_to_utf8(const std::wstring&wstrIn)

{
	unsigned int size = WideCharToMultiByte(CP_UTF8, 0,
		wstrIn.c_str(), (int)wstrIn.length(),
		NULL, 0, NULL, NULL);
	std::string buf(size + 1,0);
	size = WideCharToMultiByte(CP_UTF8, 0,
		wstrIn.c_str(), (int)wstrIn.length(),
		(LPSTR)buf.c_str(), (int)buf.length(), NULL, NULL);
	return std::string(buf.c_str(), size);
}
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
		else if (read == -1)
		{
			break;
		}
		else
		{
			buffer[read] = 0;
			OutputDebugStringA(buffer);
			if (!strncmp(buffer, "GET ", 4))
			{
				std::vector<std::wstring>::iterator i ;
				send(socket, buffer, read - 1, 0);
				
				for(i = data.buffer.begin();i != data.buffer.end();i++)
				{
					std::string s;
					s = s_convert_utf16_to_utf8(*i);
					send(socket, (const char*)s.c_str(), s.length(), 0);
				}
				send(socket, "\r\n\r\n",4,0);
			}
		}
		
	}
	return 0;
}


