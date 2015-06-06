#include <windows.h>
#include <math.h>
#include "commdlg.h"
#include "resource.h"
void DDA(int xs,int ys,int xe,int ye,HDC hdc,COLORREF color);
void Circle(int x,int y,int r,HDC hdc);
void Square(HDC hdc);
void Rect(HDC hdc);
void boundary(HDC hdc,int x,int y);
LRESULT CALLBACK WindowFunc(HWND,UINT,WPARAM,LPARAM);
bool CALLBACK DialogFunc(HWND ,UINT,WPARAM,LPARAM);
HWND hwnd,hdlg;
HDC hdc;
HDC memdc;
HBITMAP hbit;
HBRUSH hBrush,hBrush1;
char d='l';
POINT point1;
POINT point2;
COLORREF GColor;
HACCEL hAccel;
int maxX,maxY;
HMENU hMenu;
bool change=false,visible=true,restore=true;
char szWinName[]="PAINT";
HINSTANCE hThisInst1,Inst;
int WINAPI WinMain(HINSTANCE hThisInst,HINSTANCE hPevInst,LPSTR lpszArgs,int nWinMode)
{
	
	MSG msg;
	WNDCLASSEX wcl;
	wcl.cbSize=sizeof(WNDCLASSEX);
	wcl.hInstance=hThisInst=hThisInst; 
	wcl.lpszClassName=szWinName;
	wcl.lpfnWndProc=WindowFunc;
	wcl.style=0;
	wcl.hIcon=LoadIcon(hThisInst,"icon1");
	wcl.hIconSm=LoadIcon(hThisInst,"icon1.ico");
	wcl.hCursor=LoadCursor(hThisInst1,"cursor1.cur");
	wcl.hCursor=LoadCursor(NULL,IDC_CROSS);
	wcl.lpszMenuName="MyMenu";
	wcl.cbWndExtra=0;
	wcl.cbClsExtra=0;
	wcl.hbrBackground=(HBRUSH) GetStockObject(LTGRAY_BRUSH);
	if(!RegisterClassEx(&wcl))return 0;
	hwnd=CreateWindow(szWinName,
		"H<->H PAINT",
		WS_OVERLAPPEDWINDOW,
		CW_USEDEFAULT,
		CW_USEDEFAULT,
		CW_USEDEFAULT,
		CW_USEDEFAULT,
		HWND_DESKTOP,
		NULL,
		hThisInst,
		NULL);
	Inst=hThisInst;

	ShowWindow(hwnd,nWinMode);
	UpdateWindow(hwnd);
	hdlg=CreateDialog(Inst,"MYDIALOG",hwnd,(DLGPROC)DialogFunc);
	while(GetMessage(&msg,NULL,0,0))
	{
		if(!TranslateAccelerator(hwnd,hAccel,&msg))
		{
			TranslateMessage(&msg);
			DispatchMessage(&msg);
		}
	}
	return msg.wParam;
}
LRESULT CALLBACK WindowFunc(HWND hwnd,UINT message,WPARAM wParam,LPARAM lParam)
{
	HDC hdc;
	PAINTSTRUCT paintstruct;
	hMenu=GetMenu(hwnd);
	static char fn[256];
	int response=0;
	hdc=GetDC(hwnd);
	switch(message)
	{
	case WM_CREATE:
		maxX=GetSystemMetrics(SM_CXSCREEN);
		maxY=GetSystemMetrics(SM_CYSCREEN);
		hdc=GetDC(hwnd);
		memdc=CreateCompatibleDC(hdc);
		hbit=CreateCompatibleBitmap(hdc,maxX,maxY);
		SelectObject(memdc,hbit);
		hBrush=(HBRUSH)GetStockObject(WHITE_BRUSH);
		PatBlt(memdc,0,0,maxX,maxY,PATCOPY);
		ReleaseDC(hwnd,hdc);
		break;


///////////////////////////////////////////////////////////////////
	case WM_LBUTTONDOWN:
		point1.x=LOWORD(lParam);
		point1.y=HIWORD(lParam);
		break;
	case WM_LBUTTONUP:
		{
			change=true;
			GetDC(hwnd);
			point2.x=LOWORD(lParam);
			point2.y=HIWORD(lParam);
			switch(d)
			{
			case 'l':
				DDA(point1.x,point1.y,point2.x,point2.y,memdc,GColor); 
				InvalidateRect(hwnd,NULL,1);	
				break;
			case 's':
				Square(memdc);
				InvalidateRect(hwnd,NULL,1);	
				break;
			case 'r':
				Rect(memdc); 
				InvalidateRect(hwnd,NULL,1);	
				break;
			case 'c':
				{
					int XMin,YMin,dx,dy,r;
					dx=(int)fabs(point2.x-point1.x);
					dy=(int)fabs(point2.y-point1.y);
					if(dx>dy)
						r=dx;
					else 
						r=dy;
					if(point1.x >=point2.x)
						XMin=point2.x;
					else 
						XMin=point1.x;
					if(point1.y >=point2.y)
						YMin=point2.y;
					else
						YMin=point1.y;
					Circle(dx/2+XMin,dy/2+YMin,r/2,memdc);
					InvalidateRect(hwnd,NULL,1);
					break;
				}

			case 'f':
				boundary(memdc,point2.x,point2.y);
				InvalidateRect(hwnd,NULL,1);	
				break;
			}
			ReleaseDC(hwnd,hdc);
			break;
		}
	case WM_PAINT:
		hdc=BeginPaint(hwnd,&paintstruct);
		BitBlt(hdc,0,0,maxX,maxY,memdc,0,0,SRCCOPY);
		EndPaint(hwnd,&paintstruct);
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	default:
		return DefWindowProc(hwnd,message,wParam,lParam);
	}
	return 0;
}
//***********************************************************
////////////////////////////////////////////////////////////
void chooseColor(HDC hdc)
{
	COLORREF clRef[256];
	CHOOSECOLOR color;
	color.hwndOwner=hwnd;
	color.lStructSize=sizeof(CHOOSECOLOR);
	color.rgbResult=0;
	color.Flags=CC_RGBINIT;
	color.lpCustColors=clRef;
	int result=ChooseColor(&color);
	if(result)
		GColor=color.rgbResult;
}
//***********************************************************
void DDA(int xs,int ys,int xe,int ye,HDC hdc,COLORREF color)
{
	int in=1;
	int x,y;
	if(ye<ys)
	{
		int temp;
		temp=xs;
		xs=xe;
		xe=temp;
		temp=ys;
		ys=ye;
		ye=temp;	
	}
	y=ys;x=xs;
	int dx=xe-x;
	int dy=ye-y;
	if(dx<0)
		in=-1;
	float d=(float)(dy-.5*dx);
	if(fabs(dy)<fabs(dx))
	{
				
				while(fabs(x-xe)>0)
				{
					SetPixel(hdc,x,y,color);
					x+=in;
					if(d<0)d+=dy;
					else{
						d+=(float)(dy-fabs(dx));
						y++;
					}
				}
	}else
	{
			while(y<=ye){
				SetPixel(hdc,x,y,color);
				++y;
				if(d<0)
				{
					d+=(float)(dy-fabs(dx));
					x+=in;
				}
				else
					d-=(float)fabs(dx);
			}
	}
}
/////////////////////////////////////////////////////////////////
void Circle(int h,int v,int r,HDC hdc)
{
	int x =0;
	int y= r;
	int d= 3-2*r;
	
	while(x<=y)
	{
		SetPixel(hdc,h+x,v-y,GColor);
		SetPixel(hdc,h+x,v+y,GColor);
		SetPixel(hdc,h-x,v+y,GColor);
		SetPixel(hdc,h-x,v-y,GColor);
		SetPixel(hdc,h+y,v-x,GColor);
		SetPixel(hdc,h+y,v+x,GColor);
		SetPixel(hdc,h-y,v-x,GColor);
		SetPixel(hdc,h-y,v+x,GColor);
		
		if(d<0)
			d = d+4*x+6;
		else{
			d= d+4*(x-y)+10;
			y--;
		}
		x++;
	}
}

//////////////////////////////////////////////////////////////////
void Square(HDC hdc)
{
	DDA(point1.x,point1.y,point2.x,point1.y,hdc,GColor);
	DDA(point1.x,point1.y,point1.x,(int)fabs(point2.x-point1.x)+point1.y,hdc,GColor);
	DDA(point1.x,(int)fabs(point2.x-point1.x)+point1.y,point2.x,(int)fabs(point2.x-point1.x)+point1.y,hdc,GColor);
	DDA(point2.x,(int)fabs(point2.x-point1.x)+point1.y,point2.x,point1.y,hdc,GColor);
}
///////////////////////////////////////////////////////////////////
void Rect(HDC hdc)
{
	DDA(point1.x,point1.y,point2.x,point1.y,hdc,GColor);
	DDA(point1.x,point1.y,point1.x,point2.y,hdc,GColor);
	DDA(point2.x,point1.y,point2.x,point2.y,hdc,GColor);
	DDA(point1.x,point2.y,point2.x,point2.y,hdc,GColor);
}
///////////////////////////////////////////////////////////////////
void boundary(HDC hdc,int x,int y)
{
	
	COLORREF bc=RGB(255,255,255);
	COLORREF fc=GColor;
	COLORREF col=GetPixel(hdc,x,y);
	if(col!=bc || col==fc)
		return;
	SetPixel(hdc,x,y,fc);

	int xs=x;
	int ys=y;
	int i;
	int count1=0;
	int count2=0;
	int count3=0;
	int count4=0;
	col=GetPixel(hdc,xs+1,y);

	while(col==bc && col!=fc)
	{
		SetPixel(hdc,x,y,fc);
		++x;
		col=GetPixel(hdc,x,y);
	}

	count1=x-xs; // end - begin of the horzintal line
	x=xs;
	col=GetPixel(hdc,xs-1,y);

	while(col==bc && col!=fc)
	{
		SetPixel(hdc,x,y,fc);
		x--;
		col=GetPixel(hdc,x,y);
	}

	count2=xs-x;
	x=xs;
	col=GetPixel(hdc,xs,ys+1);
	y++;
	while(col==bc && col!=fc)
	{
		SetPixel(hdc,x,y,fc);
		y++;
		col=GetPixel(hdc,x,y);
	}

	count3=y-ys;
	y=ys;
	col=GetPixel(hdc,xs,ys-1);

	while(col==bc && col!=fc)
	{
		SetPixel(hdc,x,y,fc);
		y--;
		col=GetPixel(hdc,x,y);
	}

	count4=ys-y;

	if(count1!=0 || count3!=0)
		boundary(hdc,xs+1,ys+1);
	for(i=2;i<count1;i++)
		boundary(hdc,xs+i,ys+1);
	for(i=2;i<count3;i++)
		boundary(hdc,xs+1,ys+i);

	if(count2!=0||count3!=0)
		boundary(hdc,xs-1,ys+1);
	for(i=2;i<count2;i++)
		boundary(hdc,xs-i,ys+1);
	for(i=2;i<count3;i++)
		boundary(hdc,xs-1,ys+i);

	if(count1!=0||count4!=0)
		boundary(hdc,xs+1,ys-1);
	for(i=2;i<count1;i++)
		boundary(hdc,xs+i,ys-1);
	for(i=2;i<count4;i++)
		boundary(hdc,xs+1,ys-i);

	if(count2!=0||count4!=0)
		boundary(hdc,xs-1,ys-1);
	for(i=2;i<count2;i++)
		boundary(hdc,xs-i,ys-1);
	for(i=2;i<count4;i++)
		boundary(hdc,xs-1,ys-i);
}
/////////////////////////////////////////////////////////
bool CALLBACK DialogFunc(HWND hwnd,UINT message,WPARAM wParam,LPARAM lParam)
{
	switch(message)
	{

		
	case WM_COMMAND:
		switch(LOWORD(wParam))
		{
		case IDC_LINE:
			d='l';
			break;
		case IDC_CIRCLE:
			d='c';
			break;
		case IDC_SQUARE:
			d='s';
			break;
		case IDC_RECT:
			d='r';
			break;
		case IDC_FILL:
			d='f';
			break;
		case IDC_COLOR:
			chooseColor(hdc);
			break;

		}
	}
	return 0;
}