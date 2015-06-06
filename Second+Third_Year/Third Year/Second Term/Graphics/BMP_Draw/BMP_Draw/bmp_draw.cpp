#include "stdafx.h"
#include "resource.h"
#include<fstream.h>
#include<process.h>
#define MAX_LOADSTRING 100
//******************************************************
fstream f;
	int start = 0,sign=0,Sbmp=0,r1=0,r2=0,off=0,bitmap=0,w=0,h=0,
		pln=0,ppp=0,comp=0,sdata=0,hr=0,vr=0,clr=0,iclr=0;
	int s_x,s_y;
	const int XDim = 800 , YDim = 600;
//******************************************************
HINSTANCE hInst;
TCHAR szTitle[MAX_LOADSTRING];
TCHAR szWindowClass[MAX_LOADSTRING];
ATOM				MyRegisterClass(HINSTANCE hInstance);
BOOL				InitInstance(HINSTANCE, int);
LRESULT CALLBACK	WndProc(HWND, UINT, WPARAM, LPARAM);
LRESULT CALLBACK	Scale(HWND, UINT, WPARAM, LPARAM);
int APIENTRY WinMain(HINSTANCE hInstance,
                     HINSTANCE hPrevInstance,
                     LPSTR     lpCmdLine,
                     int       nCmdShow)
{
	MSG msg;
	HACCEL hAccelTable;
	LoadString(hInstance, IDS_APP_TITLE, szTitle, MAX_LOADSTRING);
	LoadString(hInstance, IDC_BMP_DRAW, szWindowClass, MAX_LOADSTRING);
	MyRegisterClass(hInstance);
	if (!InitInstance (hInstance, nCmdShow)) 
	{
		return FALSE;
	}
	hAccelTable = LoadAccelerators(hInstance, (LPCTSTR)IDC_BMP_DRAW);
	while (GetMessage(&msg, NULL, 0, 0)) 
	{
		if (!TranslateAccelerator(msg.hwnd, hAccelTable, &msg)) 
		{
			TranslateMessage(&msg);
			DispatchMessage(&msg);
		}
	}
	return msg.wParam;
}
ATOM MyRegisterClass(HINSTANCE hInstance)
{
	WNDCLASSEX wcex;
	wcex.cbSize = sizeof(WNDCLASSEX); 
	wcex.style			= CS_HREDRAW | CS_VREDRAW;
	wcex.lpfnWndProc	= (WNDPROC)WndProc;
	wcex.cbClsExtra		= 0;
	wcex.cbWndExtra		= 0;
	wcex.hInstance		= hInstance;
	wcex.hIcon			= LoadIcon(hInstance, (LPCTSTR)IDI_BMP_DRAW);
	wcex.hCursor		= LoadCursor(NULL, IDC_ARROW);
	wcex.hbrBackground	= (HBRUSH)(COLOR_WINDOW+1);
	wcex.lpszMenuName	= (LPCSTR)IDC_BMP_DRAW;
	wcex.lpszClassName	= szWindowClass;
	wcex.hIconSm		= LoadIcon(wcex.hInstance, (LPCTSTR)IDI_SMALL);

	return RegisterClassEx(&wcex);
}
BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
   HWND hWnd;
   hInst = hInstance; 
   hWnd = CreateWindow(szWindowClass, szTitle, WS_OVERLAPPEDWINDOW,
     0, 0, XDim, YDim-20, NULL, NULL, hInstance, NULL);
   if (!hWnd)
   {
      return FALSE;
   }
   ShowWindow(hWnd, nCmdShow);
   UpdateWindow(hWnd);
   return TRUE;
}
LRESULT CALLBACK WndProc(HWND hWnd, UINT message, WPARAM wParam, LPARAM lParam)
{
	int wmId, wmEvent;
	PAINTSTRUCT ps;
	HDC hdc;
	TCHAR szHello[MAX_LOADSTRING];
	LoadString(hInst, IDS_HELLO, szHello, MAX_LOADSTRING);

	switch (message) 
	{
		case WM_COMMAND:
			wmId    = LOWORD(wParam); 
			wmEvent = HIWORD(wParam); 
			switch (wmId)
			{
case ID_FILE_DRAW:
{
f.open("a.bmp",ios::in);

	f.read((char*)& sign   , 2);
	f.read((char*)& Sbmp   , 4);	
	f.read((char*)& r1     , 2);	
	f.read((char*)& r2     , 2);	
	f.read((char*)& off    , 4);
	f.read((char*)& bitmap , 4);
	f.read((char*)& w      , 4);	
	f.read((char*)& h      , 4);	
	f.read((char*)& pln    , 2);	
	f.read((char*)& ppp    , 2);	
	f.read((char*)& comp   , 4);
	f.read((char*)& sdata  , 4);	
	f.read((char*)& hr     , 4);
	f.read((char*)& vr     , 4);
	f.read((char*)& clr    , 4);
	f.read((char*)& iclr   , 4);
	
char R,G,B;
HDC hdc = GetDC(hWnd);
Rectangle (hdc,-1,-1,XDim,YDim);
int num = ( 3 * w ) % 4 ;
for(int i=s_y * h ; i>0 ; i-=s_y)
{
	for(int j=0 ; j<s_x * w ; j+=s_x)
	{
		f.read((char*)& R , 1);
		f.read((char*)& G , 1);
		f.read((char*)& B , 1);
		for(int x=0 ; x < s_x ; x++)
			for(int y=0 ; y < s_y ; y++)
				SetPixel(hdc,j+x,i+y,RGB(B,G,R));
	}
	if( num != 0 )
		{
			unsigned char c[4];
			f.read( c , 4 - num ) ;
		}
}

f.close();
}
break;
/************************************************************/
case ID_SCALLING:
	DialogBox(hInst,(LPCTSTR)IDD_SCALLING, hWnd, (DLGPROC)Scale);
				   break;
/************************************************************/
				default:
				   return DefWindowProc(hWnd, message, wParam, lParam);
			}
			break;
		case WM_PAINT:
			hdc = BeginPaint(hWnd, &ps);
			RECT rt;
			GetClientRect(hWnd, &rt);
			EndPaint(hWnd, &ps);
			break;
		case WM_DESTROY:
			PostQuitMessage(0);
			break;
		default:
			return DefWindowProc(hWnd, message, wParam, lParam);
   }
   return 0;
}
LRESULT CALLBACK Scale(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
	switch (message)
	{
		case WM_INITDIALOG:
				return TRUE;

		case WM_COMMAND:
			if (LOWORD(wParam) == IDOK) 
			{
				char str[4];
				EndDialog(hDlg, LOWORD(wParam));
				GetDlgItemText(hDlg,IDC_EDIT1,str,2);
				if(strlen(str) > 0)
				s_x = atoi(str);
				GetDlgItemText(hDlg,IDC_EDIT2,str,2);
				if(strlen(str) > 0)
				s_y = atoi(str);
				return TRUE;
			}
			if (LOWORD(wParam) == IDCANCEL) 
			{
				EndDialog(hDlg, LOWORD(wParam));
				return TRUE;
			}
			break;
	}
    return FALSE;
}
