/************************************************************************
**************************************************************************
--------------------		Graphics Course Algorthims		---------------------- 
**************************************************************************
**************************************************************************/
#include<windows.h>
#include<math.h>
#include"animation_2D.h"
#include"ellipse_circle.h"
#include"Liagn_Cliping.h"
#include"resource.h"
LRESULT CALLBACK WndProc(HWND , UINT , WPARAM ,LPARAM);
static char gszClassName[] = "MyWindowClass";
static HINSTANCE ghInstance = NULL;
float Xmin=50, Xmax=700,Ymin=50, Ymax=450;
float xx1,yy1,xx2,yy2;
int WINAPI WinMain(HINSTANCE hInstance , HINSTANCE hprevInstance , LPSTR lpCmdLine ,int nCmdShow)
{
		WNDCLASSEX WndClass;
		HWND hwnd;
		MSG Msg;
		ghInstance = hInstance ;
		WndClass.cbSize = sizeof(WNDCLASSEX);
		WndClass.style = NULL;
		WndClass.lpfnWndProc = WndProc ;
		WndClass.cbClsExtra =0;
		WndClass.cbWndExtra = 0;
		WndClass.hInstance =ghInstance ;
		WndClass.hIcon = LoadIcon(NULL,IDI_APPLICATION);
		WndClass.hCursor =LoadCursor(NULL ,IDC_ARROW);
		WndClass.hbrBackground = (HBRUSH)(COLOR_WINDOW+12);
		WndClass.lpszMenuName = "IDR_MENU1" ;
		WndClass.lpszClassName = gszClassName ;
		WndClass.hIconSm = LoadIcon(NULL , IDI_APPLICATION);
	if(!RegisterClassEx(&WndClass))
	{
		MessageBox(0, "window registeration failed!!","error",MB_ICONSTOP|MB_OK);
		return 0;
	}

	hwnd =CreateWindowEx(WS_EX_STATICEDGE , gszClassName ,"			  				ÇãÊÍÇä ÇáÚãáí  .... ãÇÏÉ /    ÇáÑÓã ÈÇáÍÇÓÈ",WS_OVERLAPPEDWINDOW ,
		CW_USEDEFAULT ,CW_USEDEFAULT,1320,1240,NULL,NULL,ghInstance,NULL);
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
//====================================================================
LRESULT CALLBACK WndProc(HWND hwnd ,UINT Message ,WPARAM wparam ,LPARAM
						 lparam)
{
	COLORREF C1=RGB(0,0,255),C4=RGB(255,255,255);
	COLORREF C2=RGB(255,0,0),C3=RGB(0,0,0),color1=RGB(180,0,120);;
	bool flg=true;
	HDC      hdc1,hdc2,hdc3,hdc4;
	HDC hdc;
	hdc=GetDC( hwnd );
	COLORREF GRND=GetPixel(hdc,0,0);
	
	float dx=.9,dy=.9;
//	::SelectObject(hdc,wpen);
//	TextOut(hdc,550,10,"ÈÓã Çááå ÇáÑÍãä ÇáÑÍíã ",22);
//	TextOut(hdc,250,20,"Graphics Course Algorthims(ANIMATION)",37);

//	TextOut(hdc,50,470,"Powed By:",9);
	
//	TextOut(hdc,150,485,"ÍÓÇã ÇáÏíä ãÕØÝí ÚÈÏ ÇáÍãíÏ",27);
//	TextOut(hdc,50,485,"Section : 2",11);
	
//	TextOut(hdc,170,500,"ÍãÇÏå ÌÇÈÑ ÚÈÏ Çááå",19);
//	TextOut(hdc,50,500,"Section : 3",11);
	//int h=500,k=120;

//	TextOut(hdc,Xmax-50,Ymax+30,"ÊÍÊ ÅÔÑÇÝ",9);
//	TextOut(hdc,Xmax-70,Ymax+60,"Ç/Ï:ÚÇÏá ÇÈæ ÇáãÌÏ",18);
	TextOut(hdc,Xmax+20,150,"TOOLS",5);
	TextOut(hdc,Xmax+10,170,"a>Animation",11);
	TextOut(hdc,Xmax+10,190,"b>Fan",5);
	TextOut(hdc,Xmax+10,210,"c>new",5);
	TextOut(hdc,Xmax+10,230,"q>Quit",6);

	double val=10.0;int i,s;int response=0;
	for(int a=1;a<10;a+=2)
	{
		Draw_Window(Xmin-a,Ymin-a,Xmax+a,Ymax+a,RGB(45,125,0),hdc);
		//clipping
		Liagn_Barsky(Xmax,Ymax-a*5,Xmax-a*5,Ymax,RGB(45,125,0),hdc);//left bottom
		Liagn_Barsky(Xmax,Ymin+a*5,Xmax-a*5,Ymin,RGB(45,125,0),hdc);//left top
		Liagn_Barsky(Xmin,Ymin+a*5,Xmin+a*5,Ymin,RGB(45,125,0),hdc);//right top
		Liagn_Barsky(Xmin+a*5,Ymax,Xmin,Ymax-a*5,RGB(45,125,0),hdc);//right bottom
	}
	HDC hd=GetDC(hwnd);
//	COLORREF CL=GetPixel(hdc,60,60);
	switch(Message)
	{
	case WM_CLOSE :
		response=MessageBox(hwnd,"Are You Sure You Want To Exit","Exit",MB_ICONEXCLAMATION | MB_YESNO);
			if(response==IDYES)
		DestroyWindow(hwnd);
			else return false;
		break ;
	case WM_DESTROY:
		PostQuitMessage(0);
		break ;
	case WM_RBUTTONDOWN:
		hdc1=GetDC(hwnd);
		//	xx1 = LOWORD(lparam);
		//	yy1 = HIWORD(lparam);
			ReleaseDC(hwnd,hdc1);
	break;
	case WM_LBUTTONDOWN:
		hdc2=GetDC(hwnd);
		xySystem( hdc2, C1, C2);
		//xx2 = LOWORD(lparam);
		//yy2 = HIWORD(lparam);
		//Liagn_Barsky(xx1,yy1,xx2,yy2,C1,hdc2);
		ReleaseDC(hwnd,hdc2);
	break;
//***************************************************************

		case WM_COMMAND:
		{
			switch(LOWORD(wparam))
			{
			case IDM_ROTATE   :
				hdc4=GetDC( hwnd );

					Scaling_animat(dx,dy,hdc4,C1);
					Draw_Window(470,70,670,250,RGB(45,125,0),hdc);
					Sleep(10);
					Draw_Window(460,60,660,240,RGB(45,125,0),hdc);
				
					for(i=1;i<7;i++)
						{
							polynomial_ellipse(val,70, color1, hdc4);
							val=10 * i;
						}
					Sleep(900);
					for(i=1;i<7;i++)
						{
							MidPoint_ellipse(hdc4,val,40 ,RGB(0,250,0));
							val=10 * i;
						}
					ReleaseDC(hwnd,hdc4);
					

			}break;
			case IDM_ROTATE :
				hdc2=GetDC(hwnd);
		xySystem( hdc2, C1, C2);
		//xx2 = LOWORD(lparam);
		//yy2 = HIWORD(lparam);
		//Liagn_Barsky(xx1,yy1,xx2,yy2,C1,hdc2);
		ReleaseDC(hwnd,hdc2);
		break;

		}
		break;

//**************************************************************
//________________________________________________________________________
		case WM_CHAR:
			{
				COLORREF BGc=GetPixel(hdc3,60,60);
				bool clear=false;
				switch (char(wparam))
				{
				case('c'):
						hdc3=GetDC( hwnd );
						for(s=5;s<=10;s++)
						Circle( hdc3,100+s,clear );
						//Boundary_Filling( 200,200, RGB(100,0,100), RGB(0,0,255),hdc3);
						Fan(hdc3,GRND,clear);
						ReleaseDC(hwnd,hdc3);
						break;
				case('a'):
					hdc3=GetDC( hwnd );
					clear=true;
					for(s=5;s<=10;s++)
					Circle( hdc3,100+s ,clear);
					//Boundary_Filling( 200,200, RGB(100,0,100), RGB(0,0,255),hdc3);
					
					Fan(hdc3,GRND,clear);
					clear=false;
					ReleaseDC(hwnd,hdc3);
					break;

			case('b'):
					hdc4=GetDC( hwnd );

					Scaling_animat(dx,dy,hdc4,C1);
					Draw_Window(470,70,670,250,RGB(45,125,0),hdc);
					Sleep(10);
					Draw_Window(460,60,660,240,RGB(45,125,0),hdc);
				
					for(i=1;i<7;i++)
						{
							polynomial_ellipse(val,70, color1, hdc4);
							val=10 * i;
						}
					Sleep(900);
					for(i=1;i<7;i++)
						{
							MidPoint_ellipse(hdc4,val,40 ,RGB(0,250,0));
							val=10 * i;
						}
					ReleaseDC(hwnd,hdc4);
					break;
			case 'd':
				{
					hd=GetDC( hwnd );
					xySystem( hd, GRND,GRND);
					break;
				}
		
				case('q'):
					DestroyWindow(hwnd);
				}
			}//end case keyboard char
	default:
		return DefWindowProc(hwnd,Message,wparam,lparam);
	}
	return 0;
}
