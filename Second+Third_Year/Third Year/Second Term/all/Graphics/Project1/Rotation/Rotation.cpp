#include<math.h>
#include"Rotation.h"
#include<windows.h>
#include<stdio.h>
#include<string.h>
#include<time.h>
const char *ClassName="Graphic",*WinName="Doa";
char str[255]="";
vector center(0,60);
LRESULT CALLBACK WndProc(HWND,UINT,WPARAM,LPARAM);

int WINAPI WinMain(HINSTANCE ci,HINSTANCE pi,LPSTR args,int show){

	WNDCLASSEX wcl;
	wcl.cbClsExtra = 0;
	wcl.cbSize = sizeof(WNDCLASSEX);
	wcl.cbWndExtra = 0;
	wcl.hbrBackground =(HBRUSH)GetStockObject(WHITE_BRUSH);
	wcl.hCursor = LoadCursor(NULL,IDC_ARROW);
	wcl.hIcon = LoadIcon(NULL,IDI_APPLICATION);
	wcl.hIconSm = LoadIcon(NULL,IDI_WINLOGO);
	wcl.hInstance = ci;
	wcl.lpfnWndProc = WndProc;
	wcl.lpszClassName = ClassName;
	wcl.lpszMenuName = NULL;
	wcl.style = 0;

	if(!RegisterClassEx(&wcl))
		return 0;

	HWND hwnd=CreateWindow(ClassName,WinName,WS_OVERLAPPEDWINDOW
		,CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT
		,HWND_DESKTOP,NULL,ci,NULL);
    SetTimer(hwnd,1,1000,NULL);
	if(hwnd)
		MessageBox(hwnd,"Created Succesfully","Creation",0);
	
	ShowWindow(hwnd,show);  //WM_CREATE
	UpdateWindow(hwnd);		//WM_PAINT

	MSG msg;

	while(GetMessage(&msg,hwnd,0,0)){

		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}

	return msg.wParam;
}
//----------------------------------------------------
void setpixel2(HDC hdc,int cx,int cy,int x,int y,COLORREF col)
{
	SetPixel(hdc,cx+x,cy+y,col);
	SetPixel(hdc,cx-x,cy+y,col);
	SetPixel(hdc,cx-x,cy-y,col);
	SetPixel(hdc,cx+x,cy-y,col);

	SetPixel(hdc,cx+y,cy+x,col);
	SetPixel(hdc,cx-y,cy+x,col);
	SetPixel(hdc,cx-y,cy-x,col);
	SetPixel(hdc,cx+y,cy-x,col);
}
void Circle(HDC hdc,int cx,int cy,int r,COLORREF col) 
{
	double theta=0.0f;
	int cx1=cx+r;
	while(theta<(float)22/28)
	{
		int x=int(r*cos(theta));
		int y=int(r*sin(theta));
		theta+=(7.0/(2*22.0*r));
        setpixel2(hdc,cx,cy,x,y, col);
		
	}
}

LRESULT CALLBACK WndProc(HWND hwnd,UINT msg,WPARAM wp,LPARAM lp){


	HDC hdc;
     struct tm* newtime;
	 time_t t;
	switch(msg){

/*	case WM_RBUTTONDOWN:
		
		hdc=GetDC(hwnd);
		for(;x1<x2;x1++)
		{
			yy=yy+m*1;
			SetPixel(hdc,x1,(int)yy,RGB(50,50,50));
		}
		dx=x1-x2;
		dy=y1-y2;
		for(;x2<x1;x2++)
		{
			yy=yy+m*1;
			SetPixel(hdc,x2,(int)yy,RGB(125,125,125));
		}
		ReleaseDC(hwnd,hdc);
		break;*/

/*	case WM_LBUTTONDOWN:
		hdc=GetDC(hwnd);
		TextOut(hdc,10,10,strr,strlen(str));
		ReleaseDC(hwnd,hdc);
		break;*/
	case WM_PAINT:
		{
		PAINTSTRUCT ps;
		hdc=BeginPaint(hwnd,&ps);
		TextOut(hdc,1,1,str,strlen(str));
		RECT rect;
		GetClientRect(hwnd,&rect);
		int x=(rect.left+rect.right)/2;
		int y=(rect.bottom+rect.top)/2;
		SetWindowOrgEx(hdc,-x,-y,NULL);
		MoveToEx(hdc,-x,0,NULL);
        LineTo(hdc,0,0);
		LineTo(hdc,x,0);
		MoveToEx(hdc,0,y,NULL);
		LineTo(hdc,0,0);
		LineTo(hdc,0,-y);
		HPEN hgreenpen;
			hgreenpen=CreatePen(PS_SOLID,1,RGB(0,250,0));
			SelectObject(hdc,hgreenpen);
       	MoveToEx(hdc,0,-y,NULL);
		LineTo(hdc,0,0);
		   LineTo(hdc,0,0);
		   LineTo(hdc,0,0);
		   LineTo(hdc,0,0);
	//	Circle(hdc,center[0],center[1],30,RGB(0,0,0));
			Circle(hdc,0,0,100,RGB(0,0,250));
		EndPaint(hwnd,&ps);
	}break;
	/*case WM_TIMER:
		t=time(NULL);
		newtime=localtime(&t);
		strcpy(str,asctime(newtime));
		str[strlen(str)-1]='\0';
		InvalidateRect(hwnd,NULL,0);
		
		break;*/
	case WM_TIMER:
		{
				t=time(NULL);
		newtime=localtime(&t);
		strcpy(str,asctime(newtime));
		str[strlen(str)-1]='\0';
		InvalidateRect(hwnd,NULL,0);


			hdc=GetDC(hwnd);
			RECT rect;
			HPEN hgreenpen;
			hgreenpen=CreatePen(PS_SOLID,1,RGB(0,0,250));
			SelectObject(hdc,hgreenpen);
		   GetClientRect(hwnd,&rect);
		  int x=((rect.left)+(rect.right))/2;
		  int y=(rect.bottom+rect.top)/2;
 		   SetWindowOrgEx(hdc,-x,-y,NULL);
		    LineTo(hdc,center[0],center[1]);
		  Circle(hdc,center[0],center[1],30,RGB(255,255,255));
		   center=Rotation(-22/28)* center;
		  /* MoveToEx(hdc,0,-y,NULL);
		   LineTo(hdc,0,0);
		   LineTo(hdc,0,0);
		   LineTo(hdc,0,0);
		   LineTo(hdc,0,0);*/
		   LineTo(hdc,center[0],center[1]);
		   Circle(hdc,center[0],center[1],30,RGB(0,0,0));
           ReleaseDC(hwnd,hdc);
		}break;

	case WM_DESTROY:

		PostQuitMessage(0);
		exit(0);
		break;

	/*case WM_LBUTTONUP:
		
		REC* lpREC;
		InvalidateRect(hwnd,lpREC,true);
		break;*/

	default:
		return DefWindowProc(hwnd,msg,wp,lp);


	}
	return 0;
}
