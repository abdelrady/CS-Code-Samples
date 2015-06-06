/* A clock program. */

#include <windows.h>
#include "utilities.h"
#include <string.h>
#include <stdio.h>
#include <time.h>
#include <math.h>

static int second;
int minute;
int hour;

/*double x = (int)( 180*cos((270+6*(second+1))*RAD) );
double y = (int)( 180*sin((270+6*(second+1))*RAD) );
vector c (x,y);*/

//vector c(0,-150);
vector c1(0,-110);
vector c2(0,-70);



LRESULT CALLBACK WindowFunc(HWND, UINT, WPARAM, LPARAM);

char szWinName[] = "WinClock"; /* name of window class */

char str[255] = ""; /* holds output string */

int WINAPI WinMain(HINSTANCE hThisInst, HINSTANCE hPrevInst, 
                   LPSTR lpszArgs, int nWinMode)
{
  HWND hwnd;
  MSG msg;
  WNDCLASSEX wcl;

  /* Define a window class. */
  wcl.cbSize = sizeof(WNDCLASSEX); 

  wcl.hInstance = hThisInst; /* handle to this instance */
  wcl.lpszClassName = szWinName; /* window class name */
  wcl.lpfnWndProc = WindowFunc; /* window function */
  wcl.style = 0; /* default style */

  wcl.hIcon = LoadIcon(NULL, IDI_APPLICATION); /* standard icon */
  wcl.hIconSm = LoadIcon(NULL, IDI_WINLOGO); /* small icon */
  wcl.hCursor = LoadCursor(NULL, IDC_ARROW); /* cursor style */
 
  wcl.lpszMenuName = NULL; /* no menu */
  wcl.cbClsExtra = 0; /* no extra */
  wcl.cbWndExtra = 0;/* information needed */

  /* Make the window white. */
  wcl.hbrBackground = (HBRUSH) GetStockObject(WHITE_BRUSH);


  /* Register the window class. */
  if(!RegisterClassEx(&wcl)) return 0;

  /* Now that a window class has been registered, a window
     can be created. */
  hwnd = CreateWindow(
    szWinName, "CLOCK", WS_OVERLAPPEDWINDOW,CW_USEDEFAULT,CW_USEDEFAULT,200,200,HWND_DESKTOP,NULL, hThisInst,  NULL);

  /* Display the window. */
  ShowWindow(hwnd, nWinMode);

  /* start a timer -- interrupt once per second */
  SetTimer(hwnd, 1, 1000, NULL);

  UpdateWindow(hwnd);

  /* Create the message loop. */
  while(GetMessage(&msg, NULL, 0, 0))
  {
    TranslateMessage(&msg); /* translate keyboard messages */
    DispatchMessage(&msg); /* return control to Windows 98 */
  }

  KillTimer(hwnd, 1); /* stop the timer */

  return msg.wParam;
}

///////////////////////////////////////////////////////
/*circle algorithm*/
void circle(HDC hdc,int cx,int cy,int r,COLORREF rgb)
{
	double theta = 0.0;

	while(theta <= 22.0/28.0)
	{
		int x = (int)(r * cos(theta));
		int y = (int)(r * sin(theta));

		SetPixel(hdc,cx+x,cy+y,rgb);
		SetPixel(hdc,cx-x,cy+y,rgb);
		SetPixel(hdc,cx-x,cy-y,rgb);
		SetPixel(hdc,cx+x,cy-y,rgb);
		SetPixel(hdc,cx+y,cy+x,rgb);
		SetPixel(hdc,cx-y,cy+x,rgb);
		SetPixel(hdc,cx-y,cy-x,rgb);
		SetPixel(hdc,cx+y,cy-x,rgb);

		theta += (7.0/(44*r));
	}
}
void WhitePen(HDC hdc)
{
	HPEN hWhitepen;
	hWhitepen = CreatePen(PS_SOLID, 5, RGB(255,255,255));
    SelectObject(hdc, hWhitepen);

}
void WhitePen2(HDC hdc)
{
	HPEN hWhitepen;
	hWhitepen = CreatePen(PS_SOLID, 9, RGB(255,255,255));
    SelectObject(hdc, hWhitepen);

}
void WhitePen3(HDC hdc)
{
	HPEN hWhitepen;
	hWhitepen = CreatePen(PS_SOLID, 11, RGB(255,255,255));
    SelectObject(hdc, hWhitepen);

}

void RedPen(HDC hdc)
{
	HPEN hWhitepen;
	hWhitepen = CreatePen(PS_SOLID, 11, RGB(255,0,0));
    SelectObject(hdc, hWhitepen);

}

void BluePen(HDC hdc)
{
	HPEN hWhitepen;
	hWhitepen = CreatePen(PS_SOLID, 9, RGB(0,0,255));
    SelectObject(hdc, hWhitepen);

}

void GreenPen(HDC hdc)
{
	HPEN hWhitepen;
	hWhitepen = CreatePen(PS_SOLID, 3, RGB(0,255,0));
    SelectObject(hdc, hWhitepen);

}

void YellowPen(HDC hdc)
{
	HPEN hWhitepen;
	hWhitepen = CreatePen(PS_SOLID, 3, RGB(255,250,0));
    SelectObject(hdc, hWhitepen);

}

void LimePen(HDC hdc)
{
	HPEN hWhitepen;
	hWhitepen = CreatePen(PS_SOLID, 3, RGB(0,255,255));
    SelectObject(hdc, hWhitepen);

}


////////////////////////////////////////////////////////

/* This function is called by Windows 98 and is passed 
   messages from the message queue.
*/
LRESULT CALLBACK WindowFunc(HWND hwnd, UINT message,
                            WPARAM wParam, LPARAM lParam)
{

	
  HDC hdc;
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
  COLORREF cr;
  cr = RGB(255,255,255);
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
  switch(message) {
    case WM_PAINT:
		
		{/* process a repaint request */
			
			PAINTSTRUCT ps;
			hdc = BeginPaint(hwnd, &paintstruct); /* get DC */
           // TextOut(hdc, 1, 1, str, strlen(str)); /* output string */
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
			circle(hdc,0,0,200,RGB(0,0,255));
			circle(hdc,0,0,160,RGB(0,255,0));
			circle(hdc,0,0,5,RGB(255,0,255));
			circle(hdc,0,0,195,RGB(0,0,255));
			circle(hdc,0,0,190,RGB(0,0,255));
			circle(hdc,0,0,185,RGB(0,0,255));
			circle(hdc,0,0,180,RGB(255,0,255));
			

			for(int i=1;i<=12;i++)
			{
			 sprintf(ch,"%d",i);
			 TextOut(hdc, (int)( 180*cos((270+30*i)*RAD) ),  (int)(180*sin((270+30*i)*RAD)),ch, strlen(ch));
			}
			 
		
			//hours
			RedPen(hdc);
			MoveToEx(hdc,0,0,NULL);
			LineTo(hdc,(int)c2[0],(int)c2[1]);
			if(minute%12 ==0 )
			{
				c2 = Rotation(-6) * c2;
			    WhitePen3(hdc);
				MoveToEx(hdc,0,0,NULL);
				LineTo(hdc,(int)c2[0],(int)c2[1]);
			}
			
			//minutes
			BluePen(hdc);
			MoveToEx(hdc,0,0,NULL);
			LineTo(hdc,(int)c1[0],(int)c1[1]);
			if(second == 0)
			{
				c1 = Rotation(0) * c1;
				WhitePen2(hdc);
				MoveToEx(hdc,0,0,NULL);
				LineTo(hdc,(int)c1[0],(int)c1[1]);
			}
			//seconds
			YellowPen(hdc);
			MoveToEx(hdc,0,0,NULL);
			LineTo(hdc,(int)c[0],(int)c[1]);
			c= Rotation(-6)*c;
			WhitePen(hdc);
			MoveToEx(hdc,0,0,NULL);
			LineTo(hdc,(int)c[0],(int)c[1]);
			EndPaint(hwnd,&ps);
			break;
		}
		
    case WM_TIMER: 
		{
				hdc=GetDC(hwnd);
		
				
				
				//	TextOut(hdc,20,20,"welcome timer",150);
		//  t = time(NULL);
		  //newtime = localtime(&t);
		  /* display the new time */
		  //strcpy(str, asctime(newtime));
		 // str[strlen(str)-1] = '\0'; /* remove /r/n */
		 // InvalidateRect(hwnd, NULL, 0); /* update screen */
		 // hdc = GetDC(hwnd);
		 // RECT r;
		 // GetClientRect(hwnd,&r);
		 // SetWindowOrgEx(hdc,-(r.left+r.right)/2,-(r.top+r.bottom)/2,NULL);
	
		}
		break;

	  
    case WM_DESTROY: /* terminate the program */
      PostQuitMessage(0);
      break;
    default:
      /* Let Windows 98 process any messages not specified in
         the preceding switch statement. */
      return DefWindowProc(hwnd, message, wParam, lParam);
  }
  return 0;
}