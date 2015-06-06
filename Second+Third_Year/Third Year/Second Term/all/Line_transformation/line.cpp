#include<windows.h>
#include"math.h"
///////////////////
LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);
static char gszClassName[]  =  "MyWindowClass";
static HINSTANCE ghInstance  =  NULL;
int WINAPI WinMain(HINSTANCE hInstance , HINSTANCE hprevInstance , LPSTR lpCmdLine ,int nCmdShow)
{
	WNDCLASSEX WndClass;
	HWND hwnd;
	MSG Msg;
	ghInstance  =  hInstance ;
	WndClass.cbSize  =  sizeof(WNDCLASSEX);
	WndClass.style  =  NULL;
	WndClass.lpfnWndProc  =  WndProc ;
	WndClass.cbClsExtra  = 0;
	WndClass.cbWndExtra  =  0;
	WndClass.hInstance  = ghInstance ;
	WndClass.hIcon  =  LoadIcon(NULL,IDI_APPLICATION);
	WndClass.hCursor  = LoadCursor(NULL ,IDC_ARROW);
    WndClass.hbrBackground  =  (HBRUSH)(COLOR_WINDOW+20);
    WndClass.lpszMenuName  =  NULL ;
	WndClass.lpszClassName  =  gszClassName ;
	WndClass.hIconSm  =  LoadIcon(NULL , IDI_APPLICATION);
	if(!RegisterClassEx(&WndClass))
	{
		MessageBox( 0, "window registeration failed!!","error",MB_ICONSTOP|MB_OK);
		return 0;
	}

	hwnd  = CreateWindowEx(WS_EX_STATICEDGE , gszClassName ," ROTATION-SCALING-TRANSLATION LINE",WS_OVERLAPPEDWINDOW ,
		CW_USEDEFAULT ,CW_USEDEFAULT,800,600,NULL,NULL,ghInstance,NULL);
	if(hwnd == NULL)
	{
		MessageBox(0,"windows greated failed!!","Error" ,MB_ICONSTOP|MB_OK);
         return 0;
	}
	ShowWindow(hwnd,nCmdShow);
	UpdateWindow(hwnd);
	while(GetMessage(&Msg ,NULL ,0,0))
	{
		TranslateMessage(&Msg);
		DispatchMessage(&Msg);
	}
	return Msg.wParam;
}
/*******************************************************************/
/***************** drawing line with DDA algorithm *****************/
/*******************************************************************/
void DDA(HDC hdc, float x1, float y1, float x2, float y2, COLORREF col)
{
	float xb=x1;
	float yb=y1;
	float xf=x2;
	float yf=y2;
	float M=(y2-y1)/(x2-x1);
	float MInv=1/M;
	//if 'X' and 'Y' of the begining point are both greater than 
	   //'X' and 'Y' of the ending point we swap them
	if(x1>x2 && y1>y2)
	{
		xb=x2;
	    yb=y2;
	    xf=x1;
	    yf=y1;
	}

	int x=int(xb);
	int y=int(yb);
	if((xb-xf)==0)	//parallel to the Y coordinate
		if(yb<yf)
			while(y<=yf)
			{
				SetPixel(hdc,x,y,col);
				y++;
			}
		else
			while(y>=yf)
			{
				SetPixel(hdc,x,y,col);
				y--;
			}
	else
		if((yb-yf)==0)	//parallel to the X coordinate
		if(xb<xf)
			while(x<=xf)
			{
				SetPixel(hdc,x,y,col);
				x++;
			}
		else
			while(x>=xf)
			{
				SetPixel(hdc,x,y,col);
				x--;
			}
	else
		if(M>=1 || M<=-1)
		{
			if(yf>yb)
				while(y<=yf)
				{
					x=int(xb+0.5);
					xb=xb+MInv;
					SetPixel(hdc,x,y,col);
					y++;
				}
			else  
				while(y>=yf)
				{
					x=int(xb+0.5);
					xb=xb-MInv;
					SetPixel(hdc,x,y,col);
					y--;
				}
		}
		else
			if(xf>xb)
				while(x<=xf)
				{
					y=int(yb+0.5);
					yb=yb+M;
					SetPixel(hdc,x,y,col);
					x++;
				}
			else
				while(x>=xf)
				{
					y=int(yb+0.5);
					yb=yb-M;
					SetPixel(hdc,x,y,col);
					x--;
				}
}
/*******************************************************************/
///////////////////////// ROTATE_ALGORITHM //////////////////////////
/*******************************************************************/
//function 
void ROTATION_ALGORITHM(double xC, double yC, double xBegin, double yBegin, double& xFinal, double& yFinal, double theta)
{
	xFinal = xBegin*cos(theta)-yBegin*sin(theta)-xC*cos(theta)+yC*sin(theta)+xC;

	yFinal = xBegin*sin(theta)+yBegin*cos(theta)-xC*sin(theta)-yC*cos(theta)+yC;
}
/*******************************************************************/
///////////////////////// TRANSLATE_ALGORITHM ///////////////////////
/*******************************************************************/
//function 
void TRANSLATION_ALGORITHM(double xBegin, double yBegin, double& xFinal, double& yFinal, double tx, double ty)
{
	xFinal = xBegin + tx;
	yFinal = yBegin + ty;
}
/*******************************************************************/
///////////////////////// SCALE_ALGORITHM ///////////////////////////
/*******************************************************************/
//function 
void SCALING_ALGORITHM(double xBegin, double yBegin, double& xFinal, double& yFinal, double sx, double sy)
{
	xFinal = xBegin * sx;
	yFinal = yBegin * sy;
}
//******************************************************************
double theta = 60*((22.0/7.0)/180.0);
double tx = 50;
double ty = 50;

double sx = 2;
double sy = 2;

double currentx = 0;
double currenty = 0;
/////////////////////////////
void DRAW_SHAPES(HDC hdc, double xa, double ya, double xb , double yb)
{
	double xar = 0;
	double yar = 0;
	double xbr;
	double ybr;
	
	MoveToEx(hdc, int(xa), int(ya), NULL);
	LineTo(hdc, int(xb), int(yb));

	/*rotation and draw the line*/
	currentx = 0;
	while(currentx <= theta)
	{
		ROTATION_ALGORITHM(xa, ya, xa, ya, xar, yar, currentx);
	ROTATION_ALGORITHM(xa, ya, xb, yb, xbr, ybr, currentx);
	DDA(hdc,float(xar), float(yar), float(xbr), float(ybr), RGB(255, 255, 255));
	DDA(hdc,float(xa), float(ya), float(xb), float(yb), RGB(0,0,0));
	currentx += 0.001;
	}
	DDA(hdc,float(xar), float(yar), float(xbr), float(ybr), RGB(255,0,0));
	
	/*Scaling and draw the line*/
	currentx = currenty = 1;
	while(currentx <= sx || currenty <= sy)
	{
	SCALING_ALGORITHM(xa, ya, xar, yar, currentx, currenty);
	SCALING_ALGORITHM(xb, yb, xbr, ybr, currentx, currenty);
	DDA(hdc,float(xar), float(yar), float(xbr), float(ybr), RGB(0, 255, 255));
	DDA(hdc,float(xa), float(ya), float(xb), float(yb), RGB(0,0,0));
	currentx += 0.001;
	currenty += 0.001;
	}
	DDA(hdc,float(xar), float(yar), float(xbr), float(ybr), RGB(0,255,0));

	/*translation and draw the line*/
	currentx = currenty = 0;
	while(currentx <= tx || currenty <= ty)
	{
	TRANSLATION_ALGORITHM(xa, ya, xar, yar, currentx, currenty);
	TRANSLATION_ALGORITHM(xb, yb, xbr, ybr, currentx, currenty);
	DDA(hdc,float(xar), float(yar), float(xbr), float(ybr), RGB(200, 200, 0));
	DDA(hdc,float(xa), float(ya), float(xb), float(yb), RGB(0,0,0));
	currentx += 0.1;
	currenty += 0.1;
	}
	DDA(hdc,float(xar), float(yar), float(xbr), float(ybr), RGB(0,255,0));
}
//******************************************************************
double xa = 0;
double ya = 0;
double xb = 0;
double yb = 0;
COLORREF color=RGB(0,255,0);
		double x=190,y=50;
		/*************************************/
LRESULT CALLBACK WndProc(HWND hwnd ,UINT Message ,WPARAM wparam ,LPARAM lparam)
{
	COLORREF boundaryColor = RGB(100, 0, 100);
	COLORREF fillColor = RGB(0, 120, 0);
	HDC hdc;
	int i;
	switch(Message)
	{
	case WM_PAINT:
		//for(i=0;i<=180;i+=10)
		{
		//	DDA(hdc,190,190,x,y,color);
		//	ROTATION_ALGORITHM(190,190,x,y,x,y,i);
		//	DDA(hdc,30,30,x+i,y-i,color);
		}
		break;
	case WM_CLOSE:
		DestroyWindow(hwnd);
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	case WM_RBUTTONDOWN:
		hdc = GetDC(hwnd);
		xa = LOWORD(lparam);
		ya = HIWORD(lparam);
		break;
	case WM_LBUTTONDOWN:
		hdc = GetDC(hwnd);
/*		xb = LOWORD(lparam);
		yb = HIWORD(lparam);
		//DRAW_SHAPES(hdc, xa, ya, xb, yb);
		DDA(hdc,xa,ya,xb,yb,color);
		ROTATION_ALGORITHM(xb,yb,xa,ya,x,y,45);
		DDA(hdc,xa,ya,x,y,color);
		SCALING_ALGORITHM(xa,ya,x,y,5,0);
		DDA(hdc,xa,ya,x,y,color);
*/
		int ox,oy;
		for(i=360;i>=0;i-=6)
		{
			ox=x;oy=y;
			
			TRANSLATION_ALGORITHM(x,y,x,y,x,y);
			ROTATION_ALGORITHM(190,190,x,y,x,y,6);
			TRANSLATION_ALGORITHM(x,y,x,y,-ox,-oy);
			DDA(hdc,190,190,x,y,color);
		//	DDA(hdc,30,30,x+i,y-i,color);
		}
		break;
	default:
		return DefWindowProc(hwnd, Message, wparam, lparam);
	}
	return 0;
}//end of the program
