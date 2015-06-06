#include<windows.h>
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
BOOL bButton2=FALSE;
int x1,y1,x2,y2;	
/////////////////////
void  draw(HDC hdc)
{
	float m=(y2-y1)/(x2-x1);
	int dx,dy,ds,dt,d;
	int x=x1;
	int y=y1;
	dx=x2-x1;
	dy=y1-y2;
	if(-1*m<1)
	{
	
	dt=2*(dy-dx);
	 ds=2*dy;
	 d=2*dy-dx;
	 SetPixel(hdc,x,y,RGB(255,0,0));
	 while(x<=x2)
	{
		x++;
		if(d<0)
			d=d+ds;
		else
		{
			y--;
			d=d+dt;
		}
	SetPixel(hdc,x,y,RGB(255,0,0));
	}
	}
	else
		if((-1*m)>=1)
		{
			
			dt=2*(dx-dy);
			ds=2*dx;
			d=2*dx-dy;
		

	SetPixel(hdc,x,y,RGB(255,0,0));
    while(y>y2)
	{
		y--;
		if(d<=0)
			d=d+ds;
		else
		{
			x++;
			d=d+dt;
		}
	SetPixel(hdc,x,y,RGB(255,0,0));
	}
		}
}


void  draw1(HDC hdc)
{
	float m=(y2-y1)/(x2-x1);
	int dx,dy,ds,dt,d;
	dx=x2-x1;
	dy=y2-y1;
	int x=x1;
	int y=y1;
	if(m<1)
	{
	 dt=2*(dy-dx);
	 ds=2*dy;
	 d=2*dy-dx;
	 while(x<x2)
	{
		x++;
		if(d<0)
			d=d+ds;
		else
		{
			y++;
			d=d+dt;
		}
	SetPixel(hdc,x,y,RGB(255,0,0));
	}
	}
	else
		if(m>=1)
		{
			
			dt=2*(dx-dy);
			ds=2*dx;
			d=2*dx-dy;
		

	SetPixel(hdc,x,y,RGB(255,0,0));
    while(y<y2)
	{
		y++;
		if(d<0)
			d=d+ds;
		else
		{
			x++;
			d=d+dt;
		}
	SetPixel(hdc,x,y,RGB(255,0,0));
	}
		}
}
void line1(HDC hdc)
{
	int x=x1;
	int y=y1;
	int m;
	while(x<x2)
	{
		x++;
		m=(y2-y)/(x2-x);
		y=m*x+y2;
		SetPixel(hdc,x,y,RGB(255,0,0));
	}

		
}

////////////////////////

LRESULT CALLBACK WndProc(HWND hwnd,UINT Message,WPARAM wParam
						 ,LPARAM lParam)
{
	HDC hdc=GetDC(hwnd);
	int temp,temp1;
	   switch(Message)
	{
	case WM_CLOSE:
			DestroyWindow(hwnd);
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	case WM_LBUTTONDOWN:
		if(!bButton1)
		{
			bButton1=TRUE;
			x1=LOWORD(lParam);
			y1=HIWORD(lParam);
		    
		}
		else
		{
			bButton1=FALSE;
			x2=LOWORD(lParam);
			y2=HIWORD(lParam);
		if(x1>x2&&y1>y2)
			{temp=x1; x1=x2; x2=temp;  
			temp1=y1; y1=y2; y2=temp1;
			}
		else if(x1>x2&&y1<y2)
			{temp=x1; x1=x2; x2=temp;  
			temp1=y1; y1=y2; y2=temp1;
			}
			if((x1<x2&&y1<y2))
			draw1(hdc);
			else
				if((x1<x2&&y1>y2))
					draw(hdc);
		}
		break;
	case WM_RBUTTONDOWN:
		if(!bButton1)
		{
			bButton1=TRUE;
			x1=LOWORD(lParam);
			y1=HIWORD(lParam);
		    
		}
		else
		{
			bButton1=FALSE;
			x2=LOWORD(lParam);
			y2=HIWORD(lParam);
			line1(hdc);
		}break;

	   	default:
		return DefWindowProc(hwnd,Message,wParam,lParam);

	}
	return 0;
}
