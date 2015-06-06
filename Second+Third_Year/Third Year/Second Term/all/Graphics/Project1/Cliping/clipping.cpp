#include<windows.h>
#include<math.h>
LRESULT CALLBACK WndProc(HWND,UINT,WPARAM,LPARAM);
static char gsz[]="My window";
static HINSTANCE gh=NULL;
int xMin=50;
int xMax=150;
int yMin=50;
int yMax=150;
int x1,yy,x2,y2;
struct RCode
{
	int arr[4];
};
RCode Point1,Point2;
RCode GetCode(int x,int y);
int FindCategory(RCode r1,RCode r2);
int FindIntersectiony(int x1,int x2,int y1,int y2,int x);
int FindIntersectionx(int x1,int x2,int y1,int y2,int y);
void DrawWindow(HDC hdc,int x1,int x2,int y1,int y2);
void DrawLine(HDC hdc,int x1,int x2,int yy,int y2,double m);
void DrawLine1(HDC hdc,int x1,int x2,int yy,int y2,double m);
void DrawLineX(HDC hdc,int x1,int x2,int yy,int y2);
void DrawLineY(HDC hdc,int x1,int x2,int yy,int y2);
void Draw(HDC hdc,int x1,int y1,int x2,int y2);
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
////////////////////////
double m;
///////////////////////
LRESULT CALLBACK WndProc(HWND hwnd,UINT Message,WPARAM wParam
						 ,LPARAM lParam)
{
	HDC hdc=GetDC(hwnd);
	
	DrawWindow(hdc,xMin,xMax,yMin,yMax);
	   switch(Message)
	{
	case WM_CLOSE:
			DestroyWindow(hwnd);
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	case WM_LBUTTONDOWN:
			x1=LOWORD(lParam);
			yy=HIWORD(lParam);
		break;
	case WM_LBUTTONUP:
			x2=LOWORD(lParam);
			y2=HIWORD(lParam);
			Point1=GetCode(x1,yy);
			Point2=GetCode(x2,y2);
			m=double(y2-yy)/double(x2-x1);
			if(FindCategory(Point1,Point2)==1)
				Draw(hdc,x1,yy,x2,y2);
			else if(FindCategory(Point1,Point2)==3)
			{
				if(Point1.arr[0])
				{
					if(m==0)
					{
						yy=yMax;
					}
					else 
					{
						x1=x1+(yMax-yy)/m;
					yy=yMax;
					}
				}
				if(Point1.arr[1])
				{
					if(m==0)
					{
						yy=yMin;
					}
					else
					{
						x1=x1+(yMin-yy)/m;
					yy=yMin;
					}
				}
				if(Point1.arr[2])
				{
					if(m==0)
					{
						x1=xMax;
					}
					else
					{
						yy=yy+(xMax-x1)*m;
					x1=xMax;
					}
				}
				if(Point1.arr[3])
				{
					if(m==0)
					{
						x1=xMin;
					}
					else
					{
						yy=yy+(xMin-x1)*m;
					x1=xMin;
					}
				}
				if(Point2.arr[0])
				{
					if(m==0)
					{
						y2=yMax;
					}
					else
					{
						x2=x2+(yMax-y2)/m;
					y2=yMax;
					}
				}
				if(Point2.arr[1])
				{
					if(m==0)
					{
						y2=yMin;
					}
					else
					{
						x2=x2+(yMin-y2)/m;
					y2=yMin;
					}
				}
				if(Point2.arr[2])
				{
					if(m==0)
					{
						x2=xMax;
					}
					else
					{
						y2=y2+(xMax-x2)*m;
					x2=xMax;
					}
				}
				if(Point2.arr[3])
				{
					if(m==0)
					{
						x2=xMin;
					}
					else
					{
						y2=y2+(xMin-x2)*m;
					x2=xMin;
					}
				}
				Draw(hdc,x1,yy,x2,y2);
			}
				break;
	   	default:
		return DefWindowProc(hwnd,Message,wParam,lParam);

	}
	return 0;
}
///////////////////////////////////
void DrawLine(HDC hdc,int x1,int x2,int yy,int y2,double m)
{
	int temp;
	if(x2<x1)
	{
		temp=x2;
		x2=x1;
		x1=temp;
	}
	if(y2<yy)
	{
	temp=y2;
	y2=yy;
	yy=temp;
	}
	int ds,dt,dx,dy,d;
	int x=x1;
	int y=yy;
	dx=x2-x1;
	dy=y2-yy;
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
	else if(m>1)
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
///////////////////////////////////////////////
void DrawLine1(HDC hdc,int x1,int x2,int yy,int y2,double m)
{
	int temp;
		if(x1<x2)
		{
	    	temp=x1;
			x1=x2;
			x2=temp;
		}
		if(y2<yy)
		{
			temp=y2;
			y2=yy;
			yy=temp;
		}
		int ds,dt,dx,dy,d;
	int x=x1;
	int y=yy;
	dx=x2-x1;
	dy=y2-yy;
	if((-1*m)<=1&&(x2<x1))
	{
	 dt=2*(dy+dx);
	 ds=2*dy;
	 d=2*dy+dx;
	 SetPixel(hdc,x,y,RGB(255,0,0));
	 while(x>x2)
	 {
		x--;
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
	else if((-1*m)>1)
		{
			
			dt=2*(dx-dy);
			ds=2*-dx;
			d=2*dx+dy;
		

	SetPixel(hdc,x,y,RGB(255,0,0));
    while(y<y2)
	{
		y++;
		if(d<=0)
			d=d+ds;
		else
		{
			x--;
			d=d+dt;
		}
	SetPixel(hdc,x,y,RGB(255,0,0));
	}
		}
}
////////////////////////
/////////////////////////////////////////////////
void DrawWindow(HDC hdc,int x1,int x2,int y1,int y2)
{
	for(int i=x1;i<x2;i++)
	{
		SetPixel(hdc,i,y1,RGB(0,0,255));
		SetPixel(hdc,i,y2,RGB(0,0,255));
	}
	for( i=y1;i<y2;i++)
	{
		SetPixel(hdc,x1,i,RGB(0,0,255));
		SetPixel(hdc,x2,i,RGB(0,0,255));
	}
}
/////////////////////////////////////////////////////////
//////////////////////////////////////////
int FindIntersectiony(int x1,int x2,int y1,int y2,int x)
{
	double diffx=x2-x1;
	double diffy=y2-y1;
	if(diffx==0)
		return y1;
	double m=double(y2-y1)/double(x2-x1);
	double b=y1-m*x1;
	int y=m*x+b;
	return y;

}
////////////////////////////////////////////
int FindIntersectionx(int x1,int x2,int y1,int y2,int y)
{
	double diffx=x2-x1;
	double diffy=y2-y1;
	if(diffx==0)
		return x1;
	double m=double(y2-y1)/double(x2-x1);
	double b=y1-m*x1;
	int x=(y-b)/m;
	return x;

}
////////////////////////////////////////////////
void DrawLineX(HDC hdc,int x1,int x2,int yy,int y2)
{
   	for(int i=yy;i<y2;i++)
	{
		SetPixel(hdc,x1,i,RGB(255,0,0));
		//SetPixel(hdc,x2,i,RGB(0,0,255));
	}
}
//////////////////////////////////////////////////
void DrawLineY(HDC hdc,int x1,int x2,int yy,int y2)
{
   	for(int i=x1;i<x2;i++)
	{
		SetPixel(hdc,i,yy,RGB(255,0,0));
		SetPixel(hdc,i,y2,RGB(255,0,0));
	}
}
/////////////////////////////////////////////
RCode GetCode(int x,int y)
{
	RCode result;
	for(int i=0;i<4;i++)
		result.arr[i]=0;
	if(x<xMin)
		result.arr[3]=1;
	if(x>xMax)
		result.arr[2]=1;
	if(y<yMin)
		result.arr[1]=1;
	if(y>xMax)
		result.arr[0]=1;
	return result;
}
int FindCategory(RCode r1,RCode r2)
{
	if(r1.arr[0]==0&&r1.arr[1]==0&&r1.arr[2]==0&&r1.arr[3]==0&&r2.arr[0]==0&&r2.arr[1]==0&&r2.arr[2]==0&&r2.arr[3]==0)
		return 1;
	for(int i=0;i<4;i++)
		if(r1.arr[i]&&r2.arr[i])
			return 2;
		return 3;
}
/////////////////////////////////////////////
void Draw(HDC hdc,int x1,int y1,int x2,int y2)
{
	double diff=x2-x1;
	if(diff==0)
       DrawLineX(hdc,x1,x2,y1,y2);
	else
	{
	double m=double(y2-y1)/double(x2-x1);
	if(m>0&&m<=1)
		DrawLine(hdc,x1,x2,y1,y2,m);
	else if(m<0)
		DrawLine1(hdc,x1,x2,y1,y2,m);
	}
}