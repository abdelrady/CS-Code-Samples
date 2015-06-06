#include<windows.h>
#include<stdio.h>
#include<commctrl.h>
#include"resource.h"
#include"Project1.h"
#include"Algorithm.h"
const char *ClassName="Graphic",*WinName="Paint Simulation";
HWND hDlg;
LRESULT CALLBACK WndProc(HWND,UINT,WPARAM,LPARAM);
bool    CALLBACK DialogFun(HWND,UINT,WPARAM,LPARAM);
BOOL    CALLBACK Dialog1Fun(HWND,UINT,WPARAM,LPARAM);
BOOL    CALLBACK Dialog2Fun(HWND,UINT,WPARAM,LPARAM);
BOOL    CALLBACK Dialog3Fun(HWND,UINT,WPARAM,LPARAM);
BOOL    CALLBACK Dialog4Fun(HWND,UINT,WPARAM,LPARAM);
BOOL    CALLBACK DialogFunc111(HWND ,UINT,WPARAM,LPARAM);
HINSTANCE pi;
char d='A';
//***************************************************************//
HBITMAP hbit;
HBRUSH hBrush,hBrush1;
HACCEL hAccel;
int maxX,maxY;
HDC memdc;
//******************************************************************//
bool change=false,visible=true,restore=true;
# define NUMBUTTONS 6
///////////////////////////toolbar ////////////////////////
//char d='l';
void InitToolbar();
TBBUTTON tbbuttons[NUMBUTTONS];
HWND tbwnd;
//UINT IDTB_BMP BITMAP toolbar1.bmp
line l;

WNDCLASSEX wcl;
int WINAPI WinMain(HINSTANCE ci,HINSTANCE pi,LPSTR args,int show){
    INITCOMMONCONTROLSEX cc;
	WNDCLASSEX wcl;
	wcl.cbClsExtra = 0;
	wcl.cbSize = sizeof(WNDCLASSEX);
	wcl.cbWndExtra = 0;
	wcl.hbrBackground =(HBRUSH)GetStockObject(WHITE_BRUSH);
	wcl.hCursor = LoadCursor(NULL,IDC_ARROW);
	wcl.hIcon = LoadIcon(NULL,IDI_EXCLAMATION);
	wcl.hIconSm = LoadIcon(NULL,IDI_EXCLAMATION);
	wcl.hInstance = ci;
	wcl.lpfnWndProc = WndProc;
	wcl.lpszClassName = ClassName;
	wcl.lpszMenuName = "IDR_MENU1";
	wcl.style = 0;
    HACCEL haccel;
	haccel=LoadAccelerators(pi,"IDR_MENU1");
	if(!RegisterClassEx(&wcl))
		return 0;

	HWND hwnd=CreateWindow(ClassName,WinName,WS_OVERLAPPEDWINDOW
		,CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT,CW_USEDEFAULT
		,HWND_DESKTOP,NULL,ci,NULL);
   // h=CreateDialog(pi,"IDD_DIALOG111",hwnd,(DLGPROC)DialogFunc111);
/*	if(hwnd)
		MessageBox(hwnd,"Created Succesfully","Creation",0);*/

    //////////////////////toolbar function//////////////
	cc.dwICC=ICC_BAR_CLASSES;
	cc.dwSize=sizeof( INITCOMMONCONTROLSEX);
	InitCommonControlsEx(&cc);
	InitToolbar();
    	tbwnd=CreateToolbarEx(hwnd,WS_VISIBLE|WS_CHILD|WS_BORDER,IDR_TOOLBAR1,NUMBUTTONS,pi,NULL,tbbuttons,NUMBUTTONS,16,16,16,16,sizeof(TBBUTTON));
//    tbwnd=CreateWindowEx(0,TOOLBARCLASSNAME,NULL,WS_CHILD|WS_VISIBLE,0,0,0,0,hwnd,(HMENU)IDR_TOOLBAR1,GetModuleHandle(NULL),NULL);



	
	ShowWindow(hwnd,show);  //WM_CREATE
	UpdateWindow(hwnd);		//WM_PAINT

	MSG msg;

	while(GetMessage(&msg,hwnd,0,0)){
		if(!IsDialogMessage(hDlg,&msg))
		{
           if(!TranslateAccelerator(hwnd,haccel,&msg))
		   {
			   TranslateMessage(&msg);
		        DispatchMessage(&msg);
		   }
		}
	}

	return msg.wParam;
}

//----------------------------------------------------
bool CALLBACK DialogFun(HWND hwnd,UINT msg,WPARAM wp,LPARAM lp)
{
	HDC hdc1;
//	char str[30]="aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
	BOOL success;
//	line l;
	COLORREF col;
	switch(msg)
	{
	case WM_COMMAND:
		switch (LOWORD(wp))
		{
		case IDOK:
			{
			hdc1=GetDC(hwnd);
			l.x1=GetDlgItemInt(hwnd,IDD_X1,&success,false); 
			l.y1=GetDlgItemInt(hwnd,IDD_Y1,&success,false);
			l.x2=GetDlgItemInt(hwnd,IDD_X2,&success,false);
			l.y2=GetDlgItemInt(hwnd,IDD_Y2,&success,false);
			l.color1=GetDlgItemInt(hwnd,IDD_C1,&success,false); 
			l.color2=GetDlgItemInt(hwnd,IDD_C2,&success,false);
			l.color3=GetDlgItemInt(hwnd,IDD_C3,&success,false);
			col=RGB(l.color1,l.color2,l.color3);
			int X=l.x1;
			int x=l.x2;
			int Y=l.y1;
			int y=l.y2;
         //   DDA( hdc1,l.x1,l.x2,l.y1,l.y2,(0,0,250)) ;
			 DDA( hdc1,50,100,200,350,(0,0,250)) ;
            //MessageBox(hwnd,str,"eit",MB_OK);
    		//	GetDlgItemText(hDlg,IDD_X1,str,MB_OK);
	//		d='D';
	//	 EndDialog(hwnd,IDOK);
			 	ReleaseDC(hwnd,hdc1);
			return 1;}break;
		case IDCANCEL:
			//DestroyWindow(hwnd);
			//PostQuitMessage(0);
		  EndDialog(hwnd,IDCANCEL);
			return 1;break;
		}
          break;
	}
	return 0;
};
//******************************************************************//
/*void CPaintView::OnMouseMove(UINT nFlags, line point) 
{
	saved=0;
    CPaintDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	//
	int mode;
	CClientDC*pDC=new CClientDC(this);
	if((nFlags&&MK_LBUTTON)&&flags[3])
	{CClientDC dc(this);
		//pDC->SetROP2(R2_NOT);

		pDC->MoveTo(point1);
		pDC->LineTo(point);
		pDoc->pMetaFile->MoveTo(point1);
		pDoc->pMetaFile->LineTo(point);
	//	pDC->MoveTo(point1);
	//pDC->LineTo(point);
		point1.x=point.x;
		point1.y=point.y;
	//	pDC->SetROP2(mode);
	}*/
///////////////////////////////////dialog 2 function/////////////////
BOOL CALLBACK Dialog1Fun(HWND hwnd,UINT msg,WPARAM wp,LPARAM lp)
{
	char str[30]="aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
	switch(msg)
	{
	case WM_COMMAND:
		switch (LOWORD(wp))
		{
		case IDOK:
			MessageBox(hwnd,str,"eit",MB_OK);
		
			//GetDlgItemText(hDlg,IDD_X1,str,MB_OK);
			return 1;break;
		case IDCANCEL:
			//DestroyWindow(hwnd);
			 EndDialog(hwnd,IDCANCEL);
		   //	PostQuitMessage(0);
			return 1;break;
		}
          break;
	}
	return 0;
};
////////////////////////////////DIALOG 3 FUNCTION /////////////////////
BOOL    CALLBACK Dialog2Fun(HWND hwnd,UINT msg,WPARAM wp,LPARAM lp)
{
	char str[30]="aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
	switch(msg)
	{
	case WM_COMMAND:
		switch (LOWORD(wp))
		{
		case IDOK:
			MessageBox(hwnd,str,"eit",MB_OK);
			//GetDlgItemText(hDlg,IDD_X1,str,MB_OK);
			return 1;break;
		case IDCANCEL:
			//DestroyWindow(hwnd);
		//PostQuitMessage(0);
			 EndDialog(hwnd,IDCANCEL);
			return 1;break;
		}
          break;
	}
	return 0;
};
/////////////////////////DIALOG 4 FUNCYION///////////////////////////
BOOL CALLBACK Dialog3Fun(HWND hwnd,UINT msg,WPARAM wp,LPARAM lp)
{
	char str[30]="aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
	switch(msg)
	{
	case WM_COMMAND:
		switch (LOWORD(wp))
		{
		case IDOK:
			MessageBox(hwnd,str,"eit",MB_OK);
			//GetDlgItemText(hDlg,IDD_X1,str,MB_OK);
			return 1;break;
		case IDCANCEL:
			//DestroyWindow(hwnd);
			//PostQuitMessage(0);
			 EndDialog(hwnd,IDCANCEL);
			return 1;break;
		}
          break;
	}
	return 0;
};
//////////////////////////////////dialog 5//////////////////////////
BOOL    CALLBACK Dialog4Fun(HWND hwnd,UINT msg,WPARAM wp,LPARAM lp)
{
	char str[30]="aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
	switch(msg)
	{
	case WM_COMMAND:
		switch (LOWORD(wp))
		{
		case IDOK:
			MessageBox(hwnd,str,"eit",MB_OK);
			//GetDlgItemText(hDlg,IDD_X1,str,MB_OK);
			return 1;break;
		case IDCANCEL:
			//DestroyWindow(hwnd);
			PostQuitMessage(0);
			return 1;break;
		}
          break;
	}
	return 0;
};
//----------------------------------------------------
struct point
{
	int x;
	int y;
};
LRESULT CALLBACK WndProc(HWND hwnd,UINT msg,WPARAM wp,LPARAM lp){
	RECT r4;

    line point1,point2;
	point1.x1=50,point1.y1=280;
	point2.x2=200,point2.y2=80;
	line l1,l2;
	l1.x1=40,l1.y1=80;
	l2.x2=140,l2.y2=250;
	//-------------------circle
	circle c1,c2,c3;
	c1.v[0]=60,c1.v[1]=60,c1.v[2]=60;
	c2.v[0]=80,c2.v[1]=80,c2.v[2]=80;
	c3.v[0]=300,c3.v[1]=300,c3.v[2]=100;
	//-------------------------rectangle
	rectangle r1;
	r1.bottom=100,r1.left=60,r1.right=80,r1.top=120;
	//-----------------------ellipse
	ellipse e1,e2,e3;
	e1.a=40,e1.b=50,e1.x=150,e1.y=200;
	e2.a=40,e2.b=50,e1.x=150,e2.y=200;
	e3.a=40,e3.b=50,e3.x=150,e3.y=200;
	
	//	int x1=85,y1=116;
//	char str[30];

	PAINTSTRUCT paintstruct;
	HDC hdc,hdc10;
	double x=150, y=150;
	int x2=195,y2=150;
	int r=90;
//	int dx=x2-x1;
//	int dy=y2-y1;
//	int d=2*dy-dx;
double a=50,b=50;
	/////////////////

	switch(msg){
/*	case WM_CREATE:
		maxX=GetSystemMetrics(SM_CXSCREEN);
		maxY=GetSystemMetrics(SM_CYSCREEN);
		hdc=GetDC(hwnd);
		memdc=CreateCompatibleDC(hdc);
		hbit=CreateCompatibleBitmap(hdc,maxX,maxY);
		SelectObject(memdc,hbit);
		hBrush=(HBRUSH)GetStockObject(WHITE_BRUSH);
		PatBlt(memdc,0,0,maxX,maxY,PATCOPY);
		ReleaseDC(hwnd,hdc);
		break;*/
//******************************************************************//



	case WM_RBUTTONDOWN:
	/*	hdc=GetDC(hwnd);
		MidPoint_ellipse( hdc,  a,  b, RGB(0,0,0));*/
     //   FillRect(hdc,r4,RGB(255,255,255));
	//	Parametric(hdc, a,  b,x, y ,RGB(0,0,0));
   //   polynomial_ellipse(110,120,RGB(0,0,0),hdc);break;

/*	case WM_LBUTTONDOWN:
		point1.x=LOWORD(lp);
		point1.y=HIWORD(lp);
		break;
	case WM_LBUTTONUP:
		{
			change=true;
		   GetDC(hwnd);
			point2.x=LOWORD(lp);
			point2.y=HIWORD(lp);
       //   	DDA( memdc,point1.x,point2.x,point1.y,point2.y ,RGB(0,0,0));
			switch(d)
			{
			case ('A'):
			//	GetDC(hwnd);
				DDA( memdc,point1.x,point2.x,point1.y,point2.y ,RGB(0,0,0));
				InvalidateRect(hwnd,NULL,1);
				
		        	
			}break;
				ReleaseDC(hwnd,hdc);//break;

		}break;
*/

//-------------------------------------------------------------------
	case WM_COMMAND:
		{
			switch(LOWORD(wp))
			{
			case IDM_EQUATION:
				{
						hdc=GetDC(hwnd);
					Direct(hdc,point1.x1,point2.x2,point1.y1,point2.y2);
				//hDlg=CreateDialog( pi,"IDD_DIALOG1",hwnd,(DLGPROC)DialogFun);
			      //   hDlg=CreateDialog(pi,"IDD_DIALOG1",hwnd,(DLGPROC)DialogFun);
					//	DialogBox(pi,"IDD_DIALOG1",hwnd,(DLGPROC)DialogFun);
						ReleaseDC(hwnd,hdc);
				}
				break;
			case IDM_DDA:
				{
					hdc=GetDC(hwnd);
					 DDA(hdc,point1.x1,point2.x2,point1.y1,point2.y2,RGB(0,0,250));
				      
					DialogBox(pi,"IDD_DIALOG1",hwnd,(DLGPROC)DialogFun);
				//	d='A';
				}
				break;
			case IDM_BH:
				{
				//DialogBox(pi,"IDD_DIALOG1",hwnd,(DLGPROC)DialogFun);
						hdc=GetDC(hwnd);
					 BH(hdc,l1.x1,l2.x2,l1.y1,l2.y2);
				}
				break;
			case IDM_POLY :
				{
                    hdc=GetDC(hwnd);
					Cart(hdc, c1.v[0],c1.v[1],c1.v[2],RGB(0,0,0));
				//	 BH(hdc,l1.x1,l2.x2,l1.y1,l2.y2);
				//	DialogBox(pi,"IDD_DIALOG2",hwnd,(DLGPROC)Dialog1Fun);
				}
				
				break;
			case IDM_POLAR:
				{
					hdc=GetDC(hwnd);
					Trig(hdc, c2.v[0],c2.v[1],c2.v[2],RGB(0,0,0));

				//DialogBox(pi,"IDD_DIALOG2",hwnd,(DLGPROC)Dialog1Fun);
				}
				break;
			case IDM_MIDPOINT :
				{
					hdc=GetDC(hwnd);
					MidPoint(hdc, c3.v[0],c3.v[1],c3.v[2],RGB(0,0,0));
				//DialogBox(pi,"IDD_DIALOG2",hwnd,(DLGPROC)Dialog1Fun);
				}
				break;
			case IDM_RECTANGLE:
				{
					hdc=GetDC(hwnd);
					Rectangle(hdc,r1.bottom,r1.left,r1.right,r1.top);
			     //	DialogBox(pi,"IDD_DIALOG3",hwnd,(DLGPROC)Dialog2Fun);
				}
				break;
			case IDM_POLY1 :
				{
					hdc=GetDC(hwnd);
					polynomial_ellipse( (double)e1.a,(double)e1.b,RGB(0,0,250),hdc );
			//	DialogBox(pi,"IDD_DIALOG4",hwnd,(DLGPROC)Dialog3Fun);
				}
				break;
		case IDM_MIDPOINT1 :
			{
				hdc=GetDC(hwnd);
                MidPoint_ellipse( hdc,e3.a,e3.b, RGB(0,250,0)) ;
			//	DialogBox(pi,"IDD_DIALOG4",hwnd,(DLGPROC)Dialog3Fun);
			}
				break;
		case IDM_BG_GRAY   :
			  hdc=GetDC(hwnd);
            //   HBRUSH bg= CreateSolidBrush(RGB(0,0,0));
               wcl.hbrBackground =(HBRUSH)GetStockObject(HOLLOW_BRUSH);break;

		case IDM_TRIGNOMETRIC :
			{
				hdc=GetDC(hwnd);
				Parametric( hdc,e2.a,e2.b, e2.x,e2.y,RGB(0,0,250));
		//	DialogBox(pi,"IDD_DIALOG4",hwnd,(DLGPROC)Dialog3Fun);
			}	break;
//-----------------------------------------------------------------
/*			IDM_SCALING                     40017
#define IDM_ROTATION                    40018
#define IDM_TRANS                       40019
#define IDM_REFLECT */
		
		case IDM_ROTATION :
			{
			 /* point1=rotation(22/14)*point1;
			  point2=rotation(22/14)*point2;
			  l1    =rotation(22/14)*l1;*/
			  c1    =rotation(22/14)*c1;
			  c2    =rotation(22/14)*c2;
			  c3    =rotation(22/14)*c3;
			/*  r1    =rotation(22/14)*r1;
			  e1    =rotation(22/14)*e1;*/
			  hdc=GetDC(hwnd);
			/*  Direct(hdc,point1.x1,point2.x2,point1.y1,point2.y2);
              DDA(hdc,point1.x1,point2.x2,point1.y1,point2.y2,RGB(0,0,250));
              BH(hdc,l1.x1,l2.x2,l1.y1,l2.y2);*/
             Cart(hdc,  c1.v[0], c1.v[1], c1.v[2],RGB(0,0,0));
              Trig(hdc,  c2.v[0], c2.v[1], c2.v[2],RGB(0,0,0));
               MidPoint(hdc,  c3.v[0], c3.v[1], c3.v[2],RGB(0,0,0));
              /* Rectangle(hdc,r1.bottom,r1.left,r1.right,r1.top);
               polynomial_ellipse( (double)e1.a,(double)e1.b,RGB(0,0,250),hdc );
               MidPoint_ellipse( hdc,e3.a,e3.b, RGB(0,250,0)) ;
               Parametric( hdc,e2.a,e2.b, e2.x,e2.y,RGB(0,0,250));*/
			}break;
		case IDM_TRANS :
			{
				hdc=GetDC(hwnd);
				c1    =Refelsction_X()*c1;
			    c2    =Refelsction_X()*c2;
			    c3    =Refelsction_X()*c3;
				Cart(hdc,  c1.v[0], c1.v[1], c1.v[2],RGB(0,0,0));
                Trig(hdc,  c2.v[0], c2.v[1], c2.v[2],RGB(0,0,0));
                MidPoint(hdc,  c3.v[0], c3.v[1], c3.v[2],RGB(0,0,0));
			}break;



    	case IDM_ABOUT :
		//	DialogBox(pi,"IDD_DIALOG5",hwnd,(DLGPROC)Dialog4Fun);
				break;
		case IDM_EXIT :
			PostQuitMessage(0);
			break;
			}

		}
		break;
/*	case WM_CHAR:
		{
			switch(d)
			{
			case ('D'):
				hdc10=GetDC(hwnd);
				 DDA( hdc10,l.x1,l.x2,l.y1,l.y2,(0,0,250)) ;
				 ReleaseDC(hwnd,hdc10);
					break;
			}
		}break;*/
	case WM_PAINT:
		hdc=BeginPaint(hwnd,&paintstruct);
		BitBlt(hdc,0,0,maxX,maxY,memdc,0,0,SRCCOPY);
		EndPaint(hwnd,&paintstruct);
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
void InitToolbar()
{
	tbbuttons[1].iBitmap=0;
	tbbuttons[0].idCommand=IDM_DDA;
	tbbuttons[0].fsState=TBSTATE_ENABLED;
	tbbuttons[0].fsStyle=TBSTYLE_BUTTON;
	tbbuttons[0].dwData=0L;
	tbbuttons[0].iBitmap=0;
	tbbuttons[0].iString=0;

	tbbuttons[1].iBitmap=1;
	tbbuttons[1].idCommand=IDM_RECTANGLE;
	tbbuttons[1].fsState=TBSTATE_ENABLED;
	tbbuttons[1].fsStyle=TBSTYLE_BUTTON;
	tbbuttons[1].dwData=0L;
	tbbuttons[1].iBitmap=1;
	tbbuttons[1].iString=0;

	tbbuttons[2].iBitmap=2;
	tbbuttons[2].idCommand=IDM_MIDPOINT1;
	tbbuttons[2].fsState=TBSTATE_ENABLED;
	tbbuttons[2].fsStyle=TBSTYLE_BUTTON;
	tbbuttons[2].dwData=0L;
	tbbuttons[1].iBitmap=2;
	tbbuttons[2].iString=0;

	tbbuttons[3].iBitmap=3;
	tbbuttons[3].idCommand=IDM_POLAR;
	tbbuttons[3].fsState=TBSTATE_ENABLED;
	tbbuttons[3].fsStyle=TBSTYLE_BUTTON;
	tbbuttons[3].dwData=0L;
	tbbuttons[1].iBitmap=3;
	tbbuttons[3].iString=0;

	tbbuttons[4].iBitmap=4;
	tbbuttons[4].idCommand=IDM_ABOUT;
	tbbuttons[4].fsState=TBSTATE_ENABLED;
	tbbuttons[4].fsStyle=TBSTYLE_BUTTON;
	tbbuttons[4].dwData=0L;
	tbbuttons[1].iBitmap=4;
	tbbuttons[4].iString=0;
}



	


