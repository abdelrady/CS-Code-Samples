#include<windows.h>
#include<stdio.h>
#include<math.h>
const char *ClassName="Graphic",*WinName="Paint Simulation";

LRESULT CALLBACK WndProc(HWND,UINT,WPARAM,LPARAM);

int WINAPI WinMain(HINSTANCE ci,HINSTANCE pi,LPSTR args,int show){

	WNDCLASSEX wcl;
	wcl.cbClsExtra = 0;
	wcl.cbSize = sizeof(WNDCLASSEX);
	wcl.cbWndExtra = 0;
	wcl.hbrBackground =(HBRUSH)GetStockObject(LTGRAY_BRUSH);
	wcl.hCursor = LoadCursor(NULL,IDC_ARROW);
	wcl.hIcon = LoadIcon(NULL,IDI_EXCLAMATION);
	wcl.hIconSm = LoadIcon(NULL,IDI_EXCLAMATION);
	wcl.hInstance = ci;
	wcl.lpfnWndProc = WndProc;
	wcl.lpszClassName = ClassName;
	wcl.lpszMenuName = "IDR_MENU1";
	wcl.style = 0;

	if(!RegisterClassEx(&wcl))
		return 0;

	HWND hwnd=CreateWindow(ClassName,WinName,WS_OVERLAPPEDWINDOW
		,CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT
		,HWND_DESKTOP,NULL,ci,NULL);

/*	if(hwnd)
		MessageBox(hwnd,"Created Succesfully","Creation",0);*/
	
	ShowWindow(hwnd,show);  //WM_CREATE
	UpdateWindow(hwnd);		//WM_PAINT

	MSG msg;

	while(GetMessage(&msg,hwnd,0,0)){

		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}

	return msg.wParam;
}
/////////////////////////////direct equation//////////////////////////

///////////////////////////PARAMETRIC FUNCTION///////////////////////
void plot_fourPoints(double x,double y,double h,double k,COLORREF color,HDC hdc)
{
		SetPixel(hdc, x+h , y+k,  color);
		SetPixel(hdc, -x+h, -y+k, color);
		
		SetPixel(hdc, x+h, -y+k,  color);
		SetPixel(hdc, -x+h, y+k,  color);

}


void polynomial_ellipse( double a,double b,COLORREF color,HDC hdc )
{
	int h=570,k=150;			//		ellipse center
	double x=0.0,X_end=a;		// a    major axis,,, b mainor axis
	while(x<=X_end)
	{
		double y=b*( sqrt( 1- (x*x)/(a*a)  ) );
		plot_fourPoints(x,y,h,k,color,hdc);

		x+=.001;
	}//end loop
}//----------------------------------------------------
LRESULT CALLBACK WndProc(HWND hwnd,UINT msg,WPARAM wp,LPARAM lp){

	int x=150,y=150;
	int r=100;
	HDC hdc;
	int x2=200,y2=300;
//	int dx=x2-x1;
//	int dy=y2-y1;
//	int d=2*dy-dx;
	/////////////////

	switch(msg){
	case WM_RBUTTONDOWN:
		hdc=GetDC(hwnd);
		polynomial_ellipse(50,40,RGB(0,0,0),hdc );break;

	/*case WM_LBUTTONDOWN:

		x1=LOWORD(lp);
		y1=HIWORD(lp);
		sprintf(str,"(%d,%d)",x1,y1);
		hdc=GetDC(hwnd);
		TextOut(hdc,x1,y1,str,strlen(str));
		SetPixel(hdc,x1,y1,RGB(0,0,0));
		while(x1<x2)
		{
			x1++;
			if(d>0)
			{
				d=d+2*dy-2*dx;
				y1++;
			}
			else
			{
				d=d+2*dy;
			}
			SetPixel(hdc,x1,y1,RGB(0,0,0));
		}
		ReleaseDC(hwnd,hdc);
		break;*/

	case WM_DESTROY:

		PostQuitMessage(0);
		exit(0);
		break;


	default:
		return DefWindowProc(hwnd,msg,wp,lp);


	}
	return 0;
}
