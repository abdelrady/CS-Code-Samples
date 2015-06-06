#include<windows.h>
#include<math.h>
int inc=1,inc1=1,inc2=1,inc3=1;
LRESULT CALLBACK WndProc(HWND,UINT,WPARAM,LPARAM);
static char gsz[]="My window";
static HINSTANCE gh=NULL;
int WINAPI WinMain(HINSTANCE hIn,HINSTANCE hPrevIn,LPSTR lpCmdLine
				   ,int nCmdShow)
{

	WNDCLASSEX WndClass;
	HWND hwnd;
	MSG Msg;
	gh=hIn;
	WndClass.cbSize=sizeof(WNDCLASSEX);
	WndClass.style=NULL;
	WndClass.lpfnWndProc=WndProc;
	WndClass.cbClsExtra=0;
	WndClass.cbWndExtra=0;
	WndClass.hInstance=gh;
	WndClass.hIcon=LoadIcon(NULL,IDI_APPLICATION);
	WndClass.hCursor=LoadCursor(NULL,IDC_ARROW);
	WndClass.hbrBackground=(HBRUSH)(COLOR_WINDOW+1);
	WndClass.lpszMenuName=NULL;
	WndClass.lpszClassName=gsz;
	WndClass.hIconSm=LoadIcon(NULL,IDI_APPLICATION);
	if(!RegisterClassEx(&WndClass))
	{
		MessageBox(0,"Window regester fail","Error!",MB_ICONSTOP|MB_OK);
		return 0;
	}
	hwnd=CreateWindowEx(WS_EX_STATICEDGE,gsz,"Window tittle",
	WS_OVERLAPPEDWINDOW,CW_USEDEFAULT,CW_USEDEFAULT,320,240,
	NULL,NULL,gh,NULL);
	if(hwnd==NULL)
		{
		MessageBox(0,"Window creation fail","Error!",MB_ICONSTOP|MB_OK);
		return 0;
	}
	ShowWindow(hwnd,nCmdShow);
	UpdateWindow(hwnd);
	while(GetMessage(&Msg,NULL,0,0))
	{
		TranslateMessage(&Msg);
		DispatchMessage(&Msg);

	}
	return Msg.wParam;
}
///////////////
BOOL bButton1=FALSE;
int x1=0;
int y3,x2,y2;
COLORREF col1,col2;
int x100,y100;
/////////////////////
void  drawcircle(HDC hdc)
{
	int x=0;
	int y=50;
	int d=3-100;
	while(x<=y)
	{
		SetPixel(hdc,x+x1,y+y3,RGB(255,0,0));
		SetPixel(hdc,y+x1,x+y3,RGB(255,0,0));
		SetPixel(hdc,-y+x1,x+y3,RGB(255,0,0));
		SetPixel(hdc,-x+x1,y+y3,RGB(255,0,0));
		SetPixel(hdc,-x+x1,-y+y3,RGB(255,0,0));
		SetPixel(hdc,-y+x1,-x+y3,RGB(255,0,0));
		SetPixel(hdc,y+x1,-x+y3,RGB(255,0,0));
		SetPixel(hdc,x+x1,-y+y3,RGB(255,0,0));
		if(d<0)
			d+=4*x+6;
		else
		{
			d+=4*(x-y)+10;
			y--;
		}
		x++;

		}
	
inc+=10;
}
void Boundary_Filling(HDC hdc, int x, int y, COLORREF fillColor, COLORREF boundaryColor)
{
	COLORREF color = GetPixel(hdc, x, y);
	if(color != boundaryColor && color != fillColor)
	{
		SetPixel(hdc, x, y, fillColor);
		Boundary_Filling(hdc,x+1,y,fillColor,boundaryColor);
		Boundary_Filling(hdc,x,y+1,fillColor,boundaryColor);
		Boundary_Filling(hdc,x-1,y,fillColor,boundaryColor);
		Boundary_Filling(hdc,x,y-1,fillColor,boundaryColor);
	}
}
void  drawcircleMP(HDC hdc)
{
	int x=0;
	int y=50;
	int p=1-50;
	while(x<=y)
	{
	//SetPixel(hdc,x+10*inc,y+10*inc,RGB(255,0,0));
		SetPixel(hdc,x+300,y+10*inc1,RGB(255,0,0));
		SetPixel(hdc,y+300,x+10*inc1,RGB(255,0,0));
		SetPixel(hdc,-y+300,x+10*inc1,RGB(255,0,0));
		SetPixel(hdc,-x+300,y+10*inc1,RGB(255,0,0));
		SetPixel(hdc,-x+300,-y+10*inc1,RGB(255,0,0));
		SetPixel(hdc,-y+300,-x+10*inc1,RGB(255,0,0));
		SetPixel(hdc,y+300,-x+10*inc1,RGB(255,0,0));
		SetPixel(hdc,x+300,-y+10*inc1,RGB(255,0,0));
		if(p<0)
			p+=2*x+3;
		else
		{
			p+=2*(x-y)+5;
			y--;
		}
		x++;
	}
	inc1+=10;
}
void  drawpol(HDC hdc)
{
	int x=0;
	int r=50;
	int y;
	while(x<r)
	{
		
		y=sqrt(r*r-x*x);
		SetPixel(hdc,x+500,y+10*inc2,RGB(255,0,0));
		SetPixel(hdc,y+500,x+10*inc2,RGB(255,0,0));
		SetPixel(hdc,-y+500,x+10*inc2,RGB(255,0,0));
		SetPixel(hdc,-x+500,y+10*inc2,RGB(255,0,0));
		SetPixel(hdc,-x+500,-y+10*inc2,RGB(255,0,0));
		SetPixel(hdc,-y+500,-x+10*inc2,RGB(255,0,0));
		SetPixel(hdc,y+500,-x+10*inc2,RGB(255,0,0));
		SetPixel(hdc,x+500,-y+10*inc2,RGB(255,0,0));
		x++;
	}
	inc2+=10;
}
void  drawtri(HDC hdc)
{
	int x=0;
	int r=50;
	int y;
	int th=0;
	while(th<360)
	{
		
		x=r*cos(th);
		y=r*sin(th);
		SetPixel(hdc,x+700,y+10*inc3,RGB(255,0,0));
		SetPixel(hdc,y+700,x+10*inc3,RGB(255,0,0));
		SetPixel(hdc,-y+700,x+10*inc3,RGB(255,0,0));
		SetPixel(hdc,-x+700,y+10*inc3,RGB(255,0,0));
		SetPixel(hdc,-x+700,-y+10*inc3,RGB(255,0,0));
		SetPixel(hdc,-y+700,-x+10*inc3,RGB(255,0,0));
		SetPixel(hdc,y+700,-x+10*inc3,RGB(255,0,0));
		SetPixel(hdc,x+700,-y+10*inc3,RGB(255,0,0));
		th++;
	}
	inc3+=10;

}
////////////////////////

LRESULT CALLBACK WndProc(HWND hwnd,UINT Message,WPARAM wParam
						 ,LPARAM lParam)
{
	HDC hdc=GetDC(hwnd);
	   switch(Message)
	{
	case WM_CLOSE:
			DestroyWindow(hwnd);
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	case WM_LBUTTONDOWN:
	/*x1=LOWORD(lParam);
			y3=HIWORD(lParam);
			x100=x1;    y100=y3;*/
			if(!bButton1)
		{
			bButton1=TRUE;
			x1=LOWORD(lParam);
			y3=HIWORD(lParam);
		    	drawcircle(hdc);
		}
		else
		{
			bButton1=FALSE;
			x2=LOWORD(lParam);
			y2=HIWORD(lParam);
			col1=RGB(255,0,0);
			col1=RGB(255,0,0);
			 Boundary_Filling(hdc,x1,y3,col1,col2);
		}
		
		//x1=LOWORD(lParam);
		//	y3=HIWORD(lParam);
		    
		/*if(!bButton1)
		{
			bButton1=TRUE;
			x1=LOWORD(lParam);
			y3=HIWORD(lParam);
		    
		}
		else
		{
			bButton1=FALSE;
			x2=LOWORD(lParam);
			y2=HIWORD(lParam);
			draw(hdc);
		}*/
		/*if(x1%4==0)
		{
			//essageBox(hwnd,"the first method","circle",0);
			drawcircle(hdc);
			x1++;
		}
		else if(x1%4==1)
		{
			//MessageBox(hwnd,"the second method","circle",0);
			drawcircleMP(hdc);
			x1++;
		}
		else if(x1%4==2)
		{
		//	MessageBox(hwnd,"the third method","circle",0);
			drawpol(hdc);
			x1++;
		}
		else if(x1%4==3)
		{
			//MessageBox(hwnd,"the forth method","circle",0);
			drawtri(hdc);
			x1++;
		}*/
	
		break;
		/*case WM_RBUTTONDOWN:
			col1=RGB(255,0,0);
			col1=RGB(255,0,0);
			 Boundary_Filling(hdc,x1,y3,col1,col2);*/

	   	default:
		return DefWindowProc(hwnd,Message,wParam,lParam);

	}
	return 0;
}
