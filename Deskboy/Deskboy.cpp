// Deskboy.cpp : Defines the entry point for the application.
//

#include "stdafx.h"
#include "Deskboy.h"
#include <stdio.h>
#include <string>
#include <vector>
//#include <map>

#define MAX_BUFFERS 128
#define MAX_SIZE 4096*1024

#define MAX_LOADSTRING 100

// Global Variables:
HINSTANCE hInst;                                // current instance
WCHAR szTitle[MAX_LOADSTRING];                  // The title bar text
WCHAR szWindowClass[MAX_LOADSTRING];            // the main window class name
std::vector<std::wstring> buffer;

std::wstring current;

// Forward declarations of functions included in this code module:
ATOM                MyRegisterClass(HINSTANCE hInstance);
BOOL                InitInstance(HINSTANCE, int);
LRESULT CALLBACK    WndProc(HWND, UINT, WPARAM, LPARAM);
INT_PTR CALLBACK    About(HWND, UINT, WPARAM, LPARAM);
typedef LRESULT (CALLBACK   *TDefProc)(HWND, UINT, WPARAM, LPARAM) ;
LRESULT(CALLBACK   *DefProc)(HWND, UINT, WPARAM, LPARAM) = nullptr;
int APIENTRY wWinMain(_In_ HINSTANCE hInstance,
                     _In_opt_ HINSTANCE hPrevInstance,
                     _In_ LPWSTR    lpCmdLine,
                     _In_ int       nCmdShow)
{
    UNREFERENCED_PARAMETER(hPrevInstance);
    UNREFERENCED_PARAMETER(lpCmdLine);

    // TODO: Place code here.

    // Initialize global strings
    LoadStringW(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
    LoadStringW(hInstance, IDC_DESKBOY, szWindowClass, MAX_LOADSTRING);
    MyRegisterClass(hInstance);

    // Perform application initialization:
    if (!InitInstance (hInstance, nCmdShow))
    {
        return FALSE;
    }

    HACCEL hAccelTable = LoadAccelerators(hInstance, MAKEINTRESOURCE(IDC_DESKBOY));

    MSG msg;

    // Main message loop:
    while (GetMessage(&msg, nullptr, 0, 0))
    {
        if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg))
        {
            TranslateMessage(&msg);
            DispatchMessage(&msg);
        }
    }

    return (int) msg.wParam;
}



//
//  FUNCTION: MyRegisterClass()
//
//  PURPOSE: Registers the window class.
//
ATOM MyRegisterClass(HINSTANCE hInstance)
{
    WNDCLASSEXW wcex;

    wcex.cbSize = sizeof(WNDCLASSEX);

    wcex.style          = CS_HREDRAW | CS_VREDRAW;
    wcex.lpfnWndProc    = WndProc;
    wcex.cbClsExtra     = 0;
    wcex.cbWndExtra     = 0;
    wcex.hInstance      = hInstance;
    wcex.hIcon          = LoadIcon(hInstance, MAKEINTRESOURCE(IDI_DESKBOY));
    wcex.hCursor        = LoadCursor(nullptr, IDC_ARROW);
    wcex.hbrBackground  = (HBRUSH)(COLOR_WINDOW+1);
    wcex.lpszMenuName   = MAKEINTRESOURCEW(IDC_DESKBOY);
    wcex.lpszClassName  = szWindowClass;
    wcex.hIconSm        = LoadIcon(wcex.hInstance, MAKEINTRESOURCE(IDI_SMALL));

    return RegisterClassExW(&wcex);
}
void save(LPCWSTR lp)
{

	wchar_t key[51];
	int len = wcslen(lp);
	if (len > 50)
	{
		wcsncpy_s(key, 51,lp, 50);
		key[50] = 0;
	}
	else
		wcscpy_s(key, 50, lp);
	FILE * fp;
	int magic = 0xfedec0de;
	int end = 0xeeddeedd;

	if (!_wfopen_s(&fp, L"Clipboard.clp", L"ab"))
	{
		len <<= 1;
		fwrite(&magic, sizeof(int), 1, fp);
		fwrite(&len, sizeof(int), 1, fp);
		fwrite(lp, len, 1, fp);
		fwrite(&end, sizeof(int), 1, fp);
		fclose(fp);
	}
}
//
//   FUNCTION: InitInstance(HINSTANCE, int)
//
//   PURPOSE: Saves instance handle and creates main window
//
//   COMMENTS:
//
//        In this function, we save the instance handle in a global variable and
//        create and display the main program window.
//
BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
   hInst = hInstance; // Store instance handle in our global variable
	// WS_OVERLAPPEDWINDOW
   HWND hWnd = CreateWindowW(szWindowClass, szTitle, WS_OVERLAPPED,
      CW_USEDEFAULT, 0, 610, 610, nullptr, nullptr, hInstance, nullptr);
	
   if (!hWnd)
   {
      return FALSE;
   }

	ShowWindow(hWnd, SW_HIDE); // nCmdShow);
   UpdateWindow(hWnd);

   return TRUE;
}
UINT uFormat = 0;
HWND hwndNextViewer = NULL;
bool ignore = true;
HWND hList = nullptr;
#define ID_LIST 12 
//
//  FUNCTION: WndProc(HWND, UINT, WPARAM, LPARAM)
//
//  PURPOSE:  Processes messages for the main window.
//
//  WM_COMMAND  - process the application menu
//  WM_PAINT    - Paint the main window
//  WM_DESTROY  - post a quit message and return
//
//
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
    switch (message)
    {
	 case WM_PARENTNOTIFY:
	 case WM_NOTIFY:
		 break;
    case WM_COMMAND:
        {
            int wmId = LOWORD(wParam);
				int high = HIWORD(wParam);
				int index = 0;
				switch (high)
				{
				case LBN_DBLCLK:
				case LBN_SELCHANGE:
					index = SendMessage(hList, LB_GETCURSEL, 0, 0);
					if (index >= 0 && index < (int)buffer.size())
					{
						current = buffer[index];
						HGLOBAL hGlobal = GlobalAlloc(GHND, (current.size() + 1) << 1);
						void * p = GlobalLock(hGlobal);
						wmemcpy((wchar_t*)p, current.c_str(), current.size() + 1);
						ignore = true;
						OpenClipboard(hWnd);
						HANDLE hClip = SetClipboardData(CF_UNICODETEXT, hGlobal);
						GlobalUnlock(hGlobal);

						CloseClipboard();

					}
					break;
				}

				switch (wmId)
            {
				case ID_LIST:
					switch (high)
					{
					case LBN_DBLCLK:
					case LBN_SELCHANGE:
					default:
						break;
					//default:
						
					}
					break;
            case IDM_ABOUT:
                DialogBox(hInst, MAKEINTRESOURCE(IDD_ABOUTBOX), hWnd, About);
                break;
            case IDM_EXIT:
                DestroyWindow(hWnd);
                break;
            default:
                return DefWindowProc(hWnd, message, wParam, lParam);
            }
        }
        break;
    case WM_PAINT:
	 {
		 PAINTSTRUCT ps;
		 HDC hdc = BeginPaint(hWnd, &ps);
		if (OpenClipboard(hWnd))
		{
			HGLOBAL hglb = GetClipboardData(CF_UNICODETEXT);
			LPCTSTR lpstr = (LPCWSTR)GlobalLock(hglb);
			RECT rc;
			GetClientRect(hWnd, &rc);
			DrawTextW(hdc, lpstr, -1, &rc, DT_LEFT);

			GlobalUnlock(hglb);
			CloseClipboard();
		}
		EndPaint(hWnd, &ps);
		 break;
	 }
	 case WM_HOTKEY:
		 if (wParam == 1)
		 {
			 if (!IsWindowVisible(hWnd))
			 {
				 ShowWindow(hWnd, SW_SHOW);
				 ShowWindow(hList, SW_SHOW);
				 BringWindowToTop(hWnd);

			 }
			 else
			 {
				 ShowWindow(hWnd, SW_HIDE);
				 ShowWindow(hList, SW_HIDE);
			 }
		 }
		 Beep(440, 100);
		 break;
	 case WM_CREATE:

		 // Add the window to the clipboard viewer chain. 
		 RegisterHotKey(hWnd, 1, MOD_CONTROL | MOD_ALT,VK_RETURN );
		 RegisterHotKey(hWnd, 2, MOD_CONTROL | MOD_ALT, VK_RSHIFT);

		 hwndNextViewer = SetClipboardViewer(hWnd);
		 hList = CreateWindowW(L"ListBox", L"Listbox", WS_CHILD|LBS_NOTIFY, 
				CW_USEDEFAULT, 0, 600, 600, hWnd, (HMENU)ID_LIST, hInst, NULL);
		 //SendMessage(hList, LB_ADDSTRING, 0, (LPARAM)L"Text");
		 //DefProc = (TDefProc)SetWindowLongPtr(hList, GWLP_WNDPROC, (LONG)&WndProc);
		 ShowWindow(hList, SW_HIDE);
		 //ShowWindow(hWnd, SW_HIDE);
		 break;

	 case WM_CHANGECBCHAIN:

		 // If the next window is closing, repair the chain. 

		 if ((HWND)wParam == hwndNextViewer)
			 hwndNextViewer = (HWND)lParam;

		 // Otherwise, pass the message to the next link. 

		 else if (hwndNextViewer != NULL)
			 SendMessage(hwndNextViewer, message, wParam, lParam);

		 break;

	 case WM_DESTROY:
		 ChangeClipboardChain(hWnd, hwndNextViewer);
		 PostQuitMessage(0);
		 break;

	 case WM_DRAWCLIPBOARD:  // clipboard contents changed. 

									 // Update the window by using Auto clipboard format. 
		 if (ignore)
		 {
			 ignore = false;

		 }
		 else if (OpenClipboard(hWnd))
		 {
			 HGLOBAL hglb = GetClipboardData(CF_UNICODETEXT);
			 LPWSTR lpstr = (LPWSTR)GlobalLock(hglb);
			 save(lpstr);
			 std::wstring str = lpstr;
			 buffer.push_back(str);
			 if (wcslen(lpstr) > 50)
				 lpstr[50] = 0;
			 wchar_t * p = nullptr;
			 do
			 {
				 p = wcschr(lpstr, '\n');
				 if (p)
				 {
					 *p = L'§';
					 p++;
				 }
			 } while (p);
			 SendMessage(hList, LB_ADDSTRING, 0, (LPARAM)lpstr);

			 GlobalUnlock(hglb);
			 CloseClipboard();
		 }

		 // Pass the message to the next window in clipboard 
		 // viewer chain. 
		 //InvalidateRect(hWnd, NULL, TRUE);
		 //UpdateWindow(hWnd);
		 SendMessage(hwndNextViewer, message, wParam, lParam);
		 break;
    default:
        return DefWindowProc(hWnd, message, wParam, lParam);
    }
    return 0;
}

// Message handler for about box.
INT_PTR CALLBACK About(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
    UNREFERENCED_PARAMETER(lParam);
    switch (message)
    {
    case WM_INITDIALOG:
        return (INT_PTR)TRUE;

    case WM_COMMAND:
        if (LOWORD(wParam) == IDOK || LOWORD(wParam) == IDCANCEL)
        {
            EndDialog(hDlg, LOWORD(wParam));
            return (INT_PTR)TRUE;
        }
        break;
    }
    return (INT_PTR)FALSE;
}
