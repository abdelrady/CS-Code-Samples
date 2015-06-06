#include<windows.h>
#include<stdio.h>
#include<string.h>
#include <string.h>
#include <time.h>
#include <math.h>
#include"draw.h"
#include"rotation.h"
point p1,p2;
vector c1(0,-110);
vector c2(0,-70);
char str[100];
static int second;
 int minute;
 int hour;
char szwindowClass[]="cl";
char szTitle[]="pp";
static int cp=0;
LRESULT CALLBACK windowproc(HWND,UINT,WPARAM,LPARAM);
int WINAPI WinMain(HINSTANCE hinstance,HINSTANCE hprevinstance,LPSTR llpcmdline,int nShowCmd)
{
	HWND hwnd;
	MSG msg;
	WNDCLASSEX wcl;
	wcl.cbSize =sizeof(WNDCLASSEX);
	wcl.lpfnWndProc =windowproc;
	wcl.hInstance =hinstance;
	wcl.lpszClassName =szwindowClass;
	wcl.hIcon =LoadIcon(NULL,IDI_APPLICATION);
	wcl.hIconSm=LoadIcon(hinstance,"IDI_ICON1");
	wcl.hCursor=LoadCursor(NULL,IDC_ARROW);
	wcl.hbrBackground =(HBRUSH) GetStockObject(WHITE_BRUSH);
	wcl.cbClsExtra=0;
	wcl.cbWndExtra=0;
	wcl.lpszMenuName=NULL;
	wcl.style =CS_HREDRAW | CS_VREDRAW;
	if(!RegisterClassEx(&wcl))
	return 0;
	hwnd=CreateWindow(szwindowClass,szTitle,WS_OVERLAPPEDWINDOW,CW_USEDEFAULT,0,CW_USEDEFAULT
		,0,NULL,NULL,hinstance,NULL);
	if(hwnd==NULL)
		MessageBox(hwnd,"h","wellcome",0);
	if(ShowWindow(hwnd,nShowCmd))
		MessageBox(hwnd,"h","wellcome",0);
	UpdateWindow(hwnd);
	/* start a timer -- interrupt once per second */
    SetTimer(hwnd, 1, 1000, NULL);
	while(GetMessage(&msg,hwnd,0,0))
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
	KillTimer(hwnd, 1); /* stop the timer */
	return msg.wParam ;
}
LRESULT CALLBACK windowproc(HWND hwnd,UINT msg,WPARAM wp,LPARAM lp)
{
	int tem;
  int um;
  int tem2;
  int um2;
  int tem3;
  int um3;
  char ch[20];  
  PAINTSTRUCT paintstruct;
  struct tm *newtime;
  time_t t;  
	HDC hdc;	
	int px=50,py=50;
	
	InvalidateRect(hwnd,NULL,0);
	const double x = (int)( 180*cos((270+6*(second+1))*RAD) );
    const double y = (int)( 180*sin((270+6*(second+1))*RAD) );
	vector c (x,y);
	
	const double x1 = (int)( 140*cos((270+6*(minute+1))*RAD) );
	const double y1 = (int)( 140*sin((270+6*(minute+1))*RAD) );
	vector c1 (x1,y1);
	
	const double x2 = (int)( 70*cos((270+30*(hour))*RAD) );
    const double y2 = (int)( 70*sin((270+30*(hour))*RAD) );
	vector c2 (x2,y2);
	
	hdc=GetDC(hwnd);
	p1.x=(int)x;p1.y=(int)y;
		
	p2.x=0;p2.y=0;
	switch(msg)
	{
	case WM_PAINT:
		
		{/* process a repaint request */
			
			PAINTSTRUCT ps;
			hdc = BeginPaint(hwnd, &paintstruct); /* get DC */
            TextOut(hdc, 1, 1, str, strlen(str)); /* output string */
             /* release DC */
			 tem=((int)str[17]-48)*10;
			 um=(int)str[18]-48;
			 second=tem+um;

			 tem2=((int)str[14]-48)*10;
			 um2=(int)str[15]-48;
			 minute=tem2+um2;

			 tem3=((int)str[11]-48)*10;
			 um3=(int)str[12]-48;
			 hour=(tem3+um3)%12;

			
			RECT r;
			GetClientRect(hwnd,&r);
			SetWindowOrgEx(hdc,-(r.left+r.right)/2,-(r.top+r.bottom)/2,	NULL);
			
			circle(hdc,0,0,185,RGB(0,0,255));
			circle(hdc,0,0,180,RGB(255,0,255));
			

			for(int i=1;i<=12;i++)
			{
			 sprintf(ch,"%d",i);
			 TextOut(hdc, (int)( 180*cos((270+30*i)*RAD) ),  (int)(180*sin((270+30*i)*RAD)),ch, strlen(ch));
			}
			 
			//hour
			p1.x=0;p1.y=0;p2.x=(int)x2;p2.y=(int)y2;
			DDALine(hdc,p1,p2,RGB(255,255,1));
			if(minute%12 ==0 )
			{
				c2 = Rotation(6) * c2;
				p2.x=(int)c2[0];p2.y=(int)c2[1];
			    DDALine(hdc,p1,p2,RGB(255,255,1));
				
			}
		
		//minutes
			p1.x=0;p1.y=0;p2.x=(int)x1;p2.y=(int)y1;
			DDALine(hdc,p1,p2,RGB(1,255,255));
			if(second == 0)
			{
				c1 = Rotation(6) * c1;
				p2.x=(int)c1[0];p2.y=(int)c1[1];
			    DDALine(hdc,p1,p2,RGB(1,255,255));
			}
			//seconds
			p1.x=0;p1.y=0;p2.x=(int)x;p2.y=(int)y;
			DDALine(hdc,p1,p2,RGB(0,0,0));
			c= Rotation(6)*c;
			p2.x=(int)c[0];p2.y=(int)c[1];			
			DDALine(hdc,p1,p2,RGB(255,1,1));
			EndPaint(hwnd,&ps);
		break;
		}
	case WM_TIMER:
		{
		t = time(NULL);
		RECT r;
		  newtime = localtime(&t);
		  /* display the new time */
		  strcpy(str, asctime(newtime));
		  str[strlen(str)-1] = '\0'; /* remove /r/n */
		  InvalidateRect(hwnd, NULL, 0); /* update screen */
		  hdc = GetDC(hwnd);		  
		  GetClientRect(hwnd,&r);
		  SetWindowOrgEx(hdc,-(r.left+r.right)/2,-(r.top+r.bottom)/2,NULL);
		break;
		}
	case WM_LBUTTONDOWN:
		
		break;
	case WM_LBUTTONUP:
	
	case WM_RBUTTONDOWN:
			
		//MoveToEx(hdc,0,0,NULL);
		//LineTo(hdc,(int)c1[0],(int)c1[1]);
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		exit(0);
		break;
	default:
		return DefWindowProc(hwnd,msg,wp,lp);
	}
	
	return 0;
}
   

