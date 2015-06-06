#include <windows.h>
#include<math.h>
#include<string.h>
#include<time.h>
#include "Rotet.h"
vector center(0,-100);
vector minute(0,-150);
vector hour(0,-170);
int counter=0;
int count=0;
int cou=0;
bool flag=false;
//SetTimer(hwnd,200,1000,NULL);
const char className[] = "Graphics";
const char winName[] = "Graphics App";
char str[255]="";
HPEN holdpen;
HPEN hblue,hyellow,hgreen;
HDC memdc;
HBRUSH hbrush;
LRESULT CALLBACK WindowProc(HWND,UINT,WPARAM,LPARAM);
void setpixel1(HDC hdc,int cx,int cy,int x,int y);
void setpixel2(HDC hdc,int cx,int cy,int x,int y,COLORREF);
	int x11,y11;
int WINAPI WinMain(HINSTANCE ci,HINSTANCE PrevI,LPSTR args,int show)
{
	HWND hwnd;
	MSG msg;
	WNDCLASSEX wcl; //Registeration forum of the Application

	wcl.cbSize = sizeof(wcl);									
	wcl.lpfnWndProc = WindowProc;								
	wcl.hInstance = ci;											
	wcl.lpszClassName = className;								
	wcl.hIcon = LoadIcon(NULL,IDI_APPLICATION);					
	wcl.hCursor = LoadCursor(NULL,IDC_ARROW);					
	wcl.hIconSm = LoadIcon(NULL,IDI_WINLOGO);					
	wcl.hbrBackground = (HBRUSH) GetStockObject(LTGRAY_BRUSH);	
	wcl.lpszMenuName = NULL;									
	wcl.style = 0;
	wcl.cbClsExtra = 0;											
	wcl.cbWndExtra = 0;											

	if( !RegisterClassEx(&wcl) )
		return 0;

	hwnd = CreateWindow(className,winName,WS_OVERLAPPEDWINDOW,CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT,HWND_DESKTOP,NULL,ci,NULL);
	/*1-Class name
	  2-Window name
	  3-Window style (overlap to tell that other window can overlap this window)
	  4,5,6,7-X,Y,Width,Hight(use default)
	  8-Parent window
	  9-Menu
	  10-Application
	  11-Extra*/
	SetTimer(hwnd,200,1000,NULL);

	ShowWindow(hwnd,show);
	UpdateWindow(hwnd);
	//Display the window

	while( GetMessage(&msg,hwnd,0,0) )
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
	return msg.wParam;
}
/////////////////////////////////////////////
void circle1(HDC hdc,int cx,int cy,int r,COLORREF col) 
{
	double theta=0.0f;
	int cx1=cx+r;
	while(theta<(float)22/28)
	{
		int x=int(r*cos(theta));
		int y=int(r*sin(theta));
		theta+=(7.0/(2*22.0*r));
        setpixel2(hdc,cx,cy,x,y, col);
		//setpixel2(hdc,cx1,cy,x,y);
		
	}
}
/////////////////////////////////////////////////////////
void circle2(HDC hdc,int cx,int cy,int r)
{
	for (int x=0;x<(r/sqrt(2));x++) 
	{
		int y=int(sqrt(r*r-x*x));
		//setpixel2(hdc,cx,cy,x,y);
//		setpixel2(hdc,cx+x,cy,x,y);			
	}		

 }
/////////////////////////////////////////////////////////
void setpixel1(HDC hdc,int cx,int cy,int x,int y)
{
	SetPixel(hdc,cx+x,cy+y,RGB(0,0,0));
	SetPixel(hdc,cx+(2*x),cy+y,RGB(0,0,0));
	SetPixel(hdc,cx-x,cy-y,RGB(0,0,0));
	SetPixel(hdc,cx+(2*x),cy-y,RGB(0,0,0));

	SetPixel(hdc,cx+y,cy+x,RGB(0,0,0));
	SetPixel(hdc,cx-y,cy+(2*x),RGB(0,0,0));
	SetPixel(hdc,cx-y,cy-x,RGB(0,0,0));
	SetPixel(hdc,cx+y,cy+(2*x),RGB(0,0,0));
}

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
///////////////////////////////////////////////////
/*void BH(HDC hdc, int x1,int x2,int y1,int y2,COLORREF col)
{
	int dx=x2-x1;
	int dy=y2-y1;
	int d=2*dy-dx;
	SetPixel(hdc,x1,y1,col);
	while(x1>x2)
	{
		x1--;
		if(d<0)
		
			d=d+(2*dy);
			
		
		else
		{
				y1--;
			d=d+(2*(dy-dx));
			
		}
		SetPixel(hdc,x1,y1,col);
	}
}*/
////////////////////////////////////////////////////
LRESULT CALLBACK WindowProc(HWND hwnd,UINT msg,WPARAM wp,LPARAM lp)
{
	HDC hdc,hdc3,hdc4,hdc5,hdc6;
	
	 struct tm* newtime;
	 time_t t;
	/*memdc=CreateCompatibleDC(hdc);
	hgreen=CreatePen(PS_SOLID,1,RGB(0,255,0));
	hblue=CreatePen(PS_SOLID,1,RGB(0,0,255));
	hyellow=CreatePen(PS_SOLID,1,RGB(255,255,255));
	holdpen=(HPEN)SelectObject(hdc,hgreen);
	SelectObject(hdc,holdpen);*/

	switch(msg)
	{
		case WM_RBUTTONDOWN:
		{
			hdc = GetDC(hwnd);
			PAINTSTRUCT ps;
		TextOut(hdc,1,1,str,strlen(str));
		RECT r;
		hdc=BeginPaint(hwnd,&ps);
		GetClientRect(hwnd,&r);
		 x11=(r.left+r.right)/2;
		 y11=(r.top+r.bottom)/2;
		 SetWindowOrgEx(hdc,-x11,-y11,NULL);
   		 center=translation(-450,-450) * center;
		 circle1(hdc,0,0,120,RGB(0,0,250));
         circle1(hdc,0,0,100,RGB(0,0,250));
		 circle1(hdc,0,0,5,RGB(0,0,250));
		 circle1(hdc,0,0,4,RGB(0,0,250));
		 circle1(hdc,0,0,3,RGB(0,0,250));
		 circle1(hdc,0,0,2,RGB(0,0,250));
		 circle1(hdc,0,0,1,RGB(0,0,250));
         LineTo(hdc,center[0],center[1]);
		 holdpen=(HPEN)SelectObject(hdc,hyellow);
	      SelectObject(memdc,holdpen);
		LineTo(hdc,center[0],center[1]);
		LineTo(hdc,center[0],center[1]);
		LineTo(hdc,center[0],center[1]);
		LineTo(hdc,center[0],center[1]);
		ReleaseDC(hwnd,hdc);
		}break;
	case WM_LBUTTONDOWN:
		{
			hdc = GetDC(hwnd);
			PAINTSTRUCT ps;
		TextOut(hdc,1,1,str,strlen(str));
		RECT r;
		hdc=BeginPaint(hwnd,&ps);
		GetClientRect(hwnd,&r);
		 x11=(r.left+r.right)/2;
		 y11=(r.top+r.bottom)/2;
		SetWindowOrgEx(hdc,-x11,-y11,NULL);
			center=scalar(10,20) * center;
		 circle1(hdc,0,0,120,RGB(0,0,250));
         circle1(hdc,0,0,100,RGB(0,0,250));
		 circle1(hdc,0,0,5,RGB(0,0,250));
		 circle1(hdc,0,0,4,RGB(0,0,250));
		 circle1(hdc,0,0,3,RGB(0,0,250));
		 circle1(hdc,0,0,2,RGB(0,0,250));
		 circle1(hdc,0,0,1,RGB(0,0,250));
        //LineTo(hdc,center[0],center[1]);
		 holdpen=(HPEN)SelectObject(hdc,hyellow);
	      SelectObject(memdc,holdpen);
		LineTo(hdc,center[0],center[1]);
		LineTo(hdc,center[0],center[1]);
		LineTo(hdc,center[0],center[1]);
		LineTo(hdc,center[0],center[1]);
		ReleaseDC(hwnd,hdc);
		}break;




	case WM_CREATE:
		{
	       hdc = GetDC(hwnd);
	       memdc=CreateCompatibleDC(hdc);
     		hbrush   = (HBRUSH) GetStockObject(WHITE_BRUSH);
             SelectObject(memdc,hbrush);

	       hgreen=CreatePen(PS_SOLID,1,RGB(0,255,0));
	       hblue=CreatePen(PS_SOLID,1,RGB(0,0,255));
	       hyellow=CreatePen(PS_SOLID,1,RGB(0,0,0));
	       holdpen=(HPEN)SelectObject(memdc,hgreen);
	       SelectObject(memdc,holdpen);
	       ReleaseDC(hwnd,hdc);
		}
	break;


	case WM_PAINT:
		{
		PAINTSTRUCT ps;
		TextOut(hdc,1,1,str,strlen(str));
		RECT r;
		hdc=BeginPaint(hwnd,&ps);
		GetClientRect(hwnd,&r);
		 x11=(r.left+r.right)/2;
		 y11=(r.top+r.bottom)/2;
		SetWindowOrgEx(hdc,-x11,-y11,NULL);
		circle1(hdc,0,0,120,RGB(0,0,250));
         circle1(hdc,0,0,100,RGB(0,0,250));
		 circle1(hdc,0,0,5,RGB(0,0,250));
		 circle1(hdc,0,0,4,RGB(0,0,250));
		 circle1(hdc,0,0,3,RGB(0,0,250));
		 circle1(hdc,0,0,2,RGB(0,0,250));
		 circle1(hdc,0,0,1,RGB(0,0,250));
		 holdpen=(HPEN)SelectObject(hdc,hyellow);
	      SelectObject(memdc,holdpen);
		LineTo(hdc,center[0],center[1]);
		LineTo(hdc,center[0],center[1]);
		LineTo(hdc,center[0],center[1]);
		LineTo(hdc,center[0],center[1]);
		if (counter%60==0 )
		{
		  
	        SelectObject(memdc,holdpen);
				minute=rotation((22.0/210))*minute;
				holdpen=(HPEN)SelectObject(hdc,hblue);
	        SelectObject(hdc,holdpen);
			 SetWindowOrgEx(hdc,-x11,-y11,NULL);
			 LineTo(hdc,minute[0],minute[1]);
            	 SelectObject(memdc,holdpen);
		}
		EndPaint(hwnd,&ps);
		}
		break;
	case WM_CHAR:
		{
			switch (char(wp))
				{
			case ('x'):
				hdc3=GetDC( hwnd );
				center=Refelsction_X()* center;
				ReleaseDC(hwnd,hdc3);
						break;
			case('y'):
				hdc4=GetDC( hwnd );
				center=Refelsction_Y()* center;
				ReleaseDC(hwnd,hdc4);
						break;
			case('t'):
				hdc5=GetDC( hwnd );
				center=translation(-450,-450) * center;
				ReleaseDC(hwnd,hdc5);
						break;
			case('s'):
				hdc6=GetDC( hwnd );
					center=scalar(10,20) * center;
				ReleaseDC(hwnd,hdc6);
				

			}
		}break;

	case WM_TIMER:
		{
			 t=time(NULL);
		newtime=localtime(&t);
		strcpy(str,asctime(newtime));
		str[strlen(str)-1]='\0';
		InvalidateRect(hwnd,NULL,1);
		counter++;
		hdc=GetDC(hwnd);
	       RECT r;
		   GetClientRect(hwnd,&r);
		   int x=(r.left+r.right)/2;
		   int y=(r.top+r.bottom)/2;
		   SetWindowOrgEx(hdc,-x,-y,NULL);
	      SelectObject(memdc,holdpen);
    	   LineTo(hdc,center[0],center[1]);
           
		   center=rotation(22.0/210) * center;
		
		   holdpen=(HPEN)SelectObject(hdc,hblue);
	      SelectObject(hdc,holdpen);
		LineTo(memdc,center[0],center[1]);
       ReleaseDC(hwnd,hdc);
	}
		break;

	case WM_DESTROY:
		KillTimer(hwnd,200);

	    DeleteObject(hgreen);
		DeleteObject(hblue);
		DeleteObject(hyellow);
		DeleteDC(memdc);
		PostQuitMessage(0);
		exit(0);
	default:
		return DefWindowProc(hwnd, msg, wp, lp);
	}
	return 0;
}
