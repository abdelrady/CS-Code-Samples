#include<windows.h>
LRESULT CALLBACK WndProc(HWND,UINT,WPARAM,LPARAM);
static char gsz[]="My window";
static HINSTANCE gh=NULL;
int points[10][2];
static int i=0;
bool win=false;
struct flag
{
	int top;
	int buttom;
	int right;
	int left;
};
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
flag f,f2;
/////////////////////
flag sure (int x1,int y1)
{
	flag f;
	f.buttom=f.left=f.right=f.top=0;
	if(y1<200)
		f.top=1;
	 if(y1>400)
		f.buttom=1;
	 if(x1<200)
		f.left=1;
	 if(x1>400)
		f.right=1;
	 return f;
	
}
bool in(flag &f1,flag &f2)
{
	if(f1.buttom&&f1.left&&f1.right&&f1.top&&f2.buttom&&f2.left&&f2.right&&f2.top)
		return true;
	else return false;
}
bool out(flag f1,flag f2)
{
	if((f1.buttom&&f2.buttom==1)||(f1.left&&f2.left==1)||(f1.right&&f2.right==1)||(f1.top&&f2.top==1))
		return true;
	else
		return false;
}

void cut(int &x1,int &y1,int &x2,int &y2,flag &f,flag &f2)
{
	float m=float(y2-y1)/float(x2-x1);
	if(f.top==1)
	{
		
		x1=x1+(200-y1)/m;
		y1=200;
		f.top=0;
		return;
	}
		if(f.buttom==1)
	{
		
		x1=x1+(400-y1)/m;
		y1=400;
			f.buttom=0;
		return;
	
	}
			if(f.left==1)
	{
		
		y1=y1+(200-x1)*m;
		x1=200;
		f.left=0;
		return;
	}
				if(f.right==1)
	{
		
		y1=y1+(400-x1)*m;
		x1=400;
		f2.right=0;
		return;
	}
				if(f2.top==1)
	{
		
		x2=x2+(200-y2)/m;
		y2=200;
		f2.top=0;
		return;
	}
		if(f2.buttom==1)
	{
		
		x2=x2+(400-y2)/m;
		y2=400;
			f2.buttom=0;
		return;
	
	}
			if(f2.left==1)
	{
		
		y2=y2+(200-x2)*m;
		x2=200;
		f2.left=0;
		return;
	}
				if(f2.right==1)
	{
		
		y2=y2+(400-x2)*m;
		x2=400;
		f2.right=0;
		return;
	}


}
void  draw(HDC hdc,int x1,int y1,int x2,int y2)
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


void  draw1(HDC hdc,int x1,int y1,int x2,int y2)
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
init()
{
	for(int i=0;i<10;i++)
		points[i][0]=-1;
}
void mywindow(HDC hdc)
{
	int x1=200;   int x2=400;
	int y1=200;   int y2=400;
	for(int i=x1;i<x2;i++)
		SetPixel(hdc,i,y1,RGB(0,0,255));
	for( i=x1;i<x2;i++)
		SetPixel(hdc,i,y2,RGB(0,0,255));
	for(i=y1;i<y2;i++)
		SetPixel(hdc,x1,i,RGB(0,0,255));
	for(i=y1;i<y2;i++)
		SetPixel(hdc,x2,i,RGB(0,0,255));
	init();
}
bool fl(flag f)
{
	if(f.buttom==0&&f.left==0&&f.right==0&&f.top==0)
		return true;
	return false;
}
void drowver(HDC hdc,int x1,int y1,int x2,int y2)
{
	for(int i=y1;i<y2;i++)
		SetPixel(hdc,x1,i,RGB(255,0,0));
}
void drowhor(HDC hdc,int x1,int y1,int x2,int y2)
{
	for(int i=x1;i<x2;i++)
		SetPixel(hdc,i,y1,RGB(255,0,0));
}


////////////////////////

LRESULT CALLBACK WndProc(HWND hwnd,UINT Message,WPARAM wParam
						 ,LPARAM lParam)
{
	HDC hdc=GetDC(hwnd);
	int temp,temp1,ss,len,k;
	f.buttom=f.left=f.right=f2.top=f2.buttom=f2.left=f2.right=f2.top=0;
	   switch(Message)
	{
	case WM_CLOSE:
			DestroyWindow(hwnd);
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
			case WM_MBUTTONDOWN:
				mywindow(hdc);
				break;
					
	case WM_LBUTTONDOWN:
	
		
		points[i][0]=LOWORD(lParam);
		points[i][1]=HIWORD(lParam);
		i++;
		
		break;
	case WM_RBUTTONDOWN:
		{
		for(k=0;k<10;k++)
			if(points[k][0]<0)
			{
				
				break;
			}
			len=k;
			points[k][0]=points[0][0];
			points[k][1]=points[0][1];
			///////////////////////
			////////////////////
			for(k=0;k<len;k++)
		{
				x1=points[k+1][0];
				y1=points[k+1][1];
		
				if(points[k][0]>points[k+1][0]&&points[k][1]>points[k+1][1])
			{temp=points[k][0]; points[k][0]=points[k+1][0]; points[k+1][0]=temp;  
			temp1=points[k][1]; points[k][1]=points[k+1][1]; points[k+1][1]=temp1;
			}
		else if(points[k][0]>points[k+1][0]&&points[k][1]<points[k+1][1])
			{temp=points[k][0]; points[k][0]=points[k+1][0]; points[k+1][0]=temp;  
			temp1=points[k][1]; points[k][1]=points[k+1][1]; points[k+1][1]=temp1;
			}
		f=sure(points[k][0],points[k][1]);
		f2=sure(points[k+1][0],points[k+1][1]);
		if(out(f,f2))
		{	points[k][0]=0; points[k+1][0]=0; points[k+1][0]=0; points[k+1][1]=0;}
		else if(!in(f,f2))
		{
			while(!(fl(f)&&fl(f2)))
			
			cut(points[k][0],points[k][1],points[k+1][0],points[k+1][1],f,f2);
		}
				
			if((points[k][0]<points[k+1][0]&&points[k][1]<points[k+1][1]))
			{
				draw1(hdc,points[k][0],points[k][1],points[k+1][0],points[k+1][1]);
			}
			else
				if(points[k][0]<points[k+1][0]&&points[k][1]>points[k+1][1])
				{
				draw(hdc,points[k][0],points[k][1],points[k+1][0],points[k+1][1]);
				}
				if(points[k][0]==points[k+1][0])
				{
					drowver(hdc,points[k][0],points[k][1],points[k+1][0],points[k+1][1]);
				}
				if(points[k][1]==points[k+1][1])
				{
					drowhor(hdc,points[k][0],points[k][1],points[k+1][0],points[k+1][1]);
				}
				points[k+1][0]=x1;
				points[k+1][1]=y1;
		}
			/////////////////////////////////
			////////////////////////////

			}
					
		init();
		i=0;
	
		break;

	   	default:
		return DefWindowProc(hwnd,Message,wParam,lParam);

	}
	return 0;
}
