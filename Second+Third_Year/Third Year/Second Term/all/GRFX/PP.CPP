#include <windows.h>
#include <math.h>
#include <stdio.h>
//#include "commdlg.h"
//#include "resource.h"
#include<fstream.h>
void openDialog(HDC hdc);
void saveDialog(HDC hdc);
void openFile(HDC hdc,char * ch);
void saveFile(HDC hdc,char * ch); 
void chooseColor(HDC hdc);
void DDA(int xs,int ys,int xe,int ye,HDC hdc,COLORREF color);
void Circle(int x,int y,int r,HDC hdc);
void ellipse(int a,int b,HDC hdc);
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
		"Paint Brush",
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
	hAccel=LoadAccelerators(hThisInst,"MYMENU");
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
		CheckMenuRadioItem(hMenu,IDM_COLOR_RED,IDM_COLOR_CHOOSE,IDM_COLOR_BLACK,MF_BYCOMMAND);
		CheckMenuRadioItem(hMenu,IDM_DRAW_LINE,IDM_DRAW_FILL,IDM_DRAW_LINE,MF_BYCOMMAND);
		CheckMenuItem(hMenu,IDM_VIEW_TOOLBOX,MF_BYCOMMAND|MF_CHECKED);
		ReleaseDC(hwnd,hdc);
		break;
	case WM_COMMAND:
		switch(LOWORD(wParam))
		{
			case IDM_FILE_NEW:
				if(change)
				{
					change=false;
					response=MessageBox(hwnd,"Do You Want To Save Changes","SAVE",MB_ICONEXCLAMATION | MB_YESNO);
						if(response==IDYES)
							saveDialog(hdc);
				
					PatBlt(memdc,0,0,maxX,maxY,PATCOPY);		
					InvalidateRect(hwnd,NULL,1);	
				}
				break;
			case IDM_FILE_OPEN:
					//HDC hdc=GetDC(hwnd);
					openDialog(hdc);
					//ReleaseDC(hwnd,hdc);
				break;
			case IDM_FILE_SAVE:
					//HDC hdc=GetDC(hwnd);
					saveDialog(hdc);
					//ReleaseDC(hwnd,hdc);
				break;
			case IDM_FILE_EXIT:
				//response=MessageBox(hwnd,"Quit the program?","Exit",MB_YESNO);
				//if(response==IDYES)	
				if(change)
					{
						response=MessageBox(hwnd,"Do You Want Save Changes ?","PAINT BRUSH",MB_ICONEXCLAMATION|MB_YESNOCANCEL);
						if(response==IDYES)
						{
							PostQuitMessage(0);
							saveDialog(hdc);
						}
						else if(response==IDNO)
							PostQuitMessage(0);
					}
				break;
//////////////////////////////////////////////////////////////////////
			case IDM_COLOR_CHOOSE:
				GetDC(hwnd);
				CheckMenuRadioItem(hMenu,IDM_COLOR_RED,IDM_COLOR_CHOOSE,IDM_COLOR_CHOOSE,MF_BYCOMMAND);
				chooseColor(hdc);
				ReleaseDC(hwnd,hdc);
				break;
			case IDM_COLOR_RED:
				CheckMenuRadioItem(hMenu,IDM_COLOR_RED,IDM_COLOR_CHOOSE,IDM_COLOR_RED,MF_BYCOMMAND);
				GColor=RGB(255,0,0);
				break;
			case IDM_COLOR_GREEN:
				CheckMenuRadioItem(hMenu,IDM_COLOR_RED,IDM_COLOR_CHOOSE,IDM_COLOR_GREEN,MF_BYCOMMAND);
				GColor=RGB(0,255,0);
				break;
			case IDM_COLOR_BLUE:
				CheckMenuRadioItem(hMenu,IDM_COLOR_RED,IDM_COLOR_CHOOSE,IDM_COLOR_BLUE,MF_BYCOMMAND);
				GColor=RGB(0,0,255);
				break;
			case IDM_COLOR_BLACK:
				CheckMenuRadioItem(hMenu,IDM_COLOR_RED,IDM_COLOR_CHOOSE,IDM_COLOR_BLACK,MF_BYCOMMAND);
				GColor=RGB(0,0,0);
				break;
///////////////////////////////////////////////////////////////////////////
			case IDM_DRAW_LINE:
				CheckMenuRadioItem(hMenu,IDM_DRAW_LINE,IDM_DRAW_FILL,IDM_DRAW_LINE,MF_BYCOMMAND);
				d='l';
				break;
			case IDM_DRAW_CIRCLE:
				CheckMenuRadioItem(hMenu,IDM_DRAW_LINE,IDM_DRAW_FILL,IDM_DRAW_CIRCLE,MF_BYCOMMAND);
				d='c';
				break;
			case IDM_DRAW_ELLIPSE:
				CheckMenuRadioItem(hMenu,IDM_DRAW_LINE,IDM_DRAW_FILL,IDM_DRAW_ELLIPSE,MF_BYCOMMAND);
				d='e';
				break;
			case IDM_DRAW_SQUARE:
				CheckMenuRadioItem(hMenu,IDM_DRAW_LINE,IDM_DRAW_FILL,IDM_DRAW_SQUARE,MF_BYCOMMAND);
				d='s';
				break;
			case IDM_DRAW_RECTANGLE:
				CheckMenuRadioItem(hMenu,IDM_DRAW_LINE,IDM_DRAW_FILL,IDM_DRAW_RECTANGLE,MF_BYCOMMAND);
				d='r';
				break;
			case IDM_DRAW_FILL:
				LoadCursor(NULL,"cursor1.cur");
				CheckMenuRadioItem(hMenu,IDM_DRAW_LINE,IDM_DRAW_FILL,IDM_DRAW_FILL,MF_BYCOMMAND);
				d='f';
				break;
///////////////////////////////////////////////////////////////////////////
			case IDM_VIEW_TOOLBOX:
				if(visible)
				{
					CheckMenuItem(hMenu,IDM_VIEW_TOOLBOX,MF_BYCOMMAND|MF_UNCHECKED);
					DestroyWindow(hdlg);
					visible=false;
				}
				else
				{
					CheckMenuItem(hMenu,IDM_VIEW_TOOLBOX,MF_BYCOMMAND|MF_CHECKED);
					hdlg=CreateDialog(Inst,"MYDIALOG",hwnd,(DLGPROC)DialogFunc);
					visible=true;
				}
				break;
////////////////////////////////////////////////////////////////
			case IDM_HELP_ABOUT:
				MessageBox(hwnd,"Paint Program \n\nVersion 1.0","About",MB_ICONINFORMATION|MB_OK);
				break;
			case IDM_HELP_CONTENT:
				WinHelp(hwnd,"PAINTHELP.hlp",HELP_CONTENTS,0);
				break;
		}
		break;
//////////////////////////////////////////////////////////////////
	case WM_SIZE:
		//DestroyWindow(hdlg);
		//hdlg=CreateDialog(Inst,"MYDIALOG",hwnd,(DLGPROC)DialogFunc);
		break;
	case WM_MOVE:
		//DestroyWindow(hdlg);
		//hdlg=CreateDialog(Inst,"MYDIALOG",hwnd,(DLGPROC)DialogFunc);
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
			case 'e':
				{
				int a=(int)(fabs(point2.x-point1.x)/2);
				int b=(int)(fabs(point2.y-point1.y)/2);
				ellipse(a,b,memdc); 
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
//*************************************************************//
////////////////////////////////////////////////////////////
void openDialog(HDC hdc)
{
	OPENFILENAME fname;
	char  filename[64];
	static char fn[256];
	fname.lStructSize=sizeof(OPENFILENAME);
	fname.hwndOwner=hwnd;
	fname.lpstrFilter="Image \0*.img";
	fname.nFilterIndex=1;
	fname.lpstrFile=fn;
	fname.nMaxFile=sizeof(fn);
	fname.lpstrFileTitle=filename;
	fname.nMaxFileTitle=sizeof(filename)-1;
	fname.Flags=OFN_HIDEREADONLY;
	fname.lpstrCustomFilter=NULL;
	fname.lpstrInitialDir=NULL;
	fname.lpstrTitle=NULL;
	fname.lpstrDefExt=NULL;
	fname.lCustData=0;
	int result=GetOpenFileName(&fname);
	if(!result)
		MessageBox(hwnd,"Invalid File Name","Error",MB_ICONERROR|MB_OK);
	else
		openFile(memdc,fname.lpstrFile);
	InvalidateRect(hwnd,NULL,1);
}
////////////////////////////////////////////////////////////////////
void openFile(HDC hdc,char * fileName)
{
	RECT win;
	unsigned long color=0;
	GetClientRect(hwnd,& win);
	ifstream inFile(fileName);
	for(int i=0;i<win.right;i++)
		for(int j=0;j<win.bottom;j++)
		{
			inFile>>color;
			inFile>>i;
			inFile>>j;
			if(!inFile.eof() )
				color=SetPixel(hdc,i,j,color);
			else break;
		}

}
//////////////////////////////////////////////////////////////////
void saveDialog(HDC hdc)
{
	OPENFILENAME fname;
	char  filename[64];
	static char fn[256];
	fname.lStructSize=sizeof(OPENFILENAME);
	fname.hwndOwner=hwnd;
	fname.lpstrFilter="Image \0*.img";
	fname.nFilterIndex=1;
	fname.lpstrFile=fn;
	fname.nMaxFile=sizeof(fn);
	fname.lpstrFileTitle=filename;
	fname.nMaxFileTitle=sizeof(filename)-1;
	fname.Flags=OFN_HIDEREADONLY;
	fname.lpstrCustomFilter=NULL;
	fname.lpstrInitialDir=NULL;
	fname.lpstrTitle=NULL;
	fname.lpstrDefExt=NULL;
	fname.lCustData=0;
	int result=GetSaveFileName(&fname);
	if(!result)
		MessageBox(hwnd,"Save File Cancelled","Error",MB_ICONERROR|MB_OK);
	else
		saveFile(memdc,fname.lpstrFile);
}
///////////////////////////////////////////////////////////////////
void saveFile(HDC hdc,char * fileName)
{
	ofstream output(fileName);
	RECT win;
	unsigned long color=0;
	GetClientRect(hwnd,& win);
	for(int i=0;i<win.right;i++)
		for(int j=0;j<win.bottom;j++)
		{
			color=GetPixel(hdc,i,j);
			if(color!=GetBkColor(hdc))
			{	
				output<<GetPixel(hdc,i,j);
				output<<' ';
				output<<i;
				output<<' ';
				output<<j;
				output<<' ';
			}
		}

		output.close();
	ReleaseDC(hwnd,hdc);
}
//////////////////////////////////////////////////////////////////
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
/////////////////////////////////////////////////////////////////
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
	//SetPixel(hdc,h,v,GColor);	
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
////////////////////////////////////////////////////////////////
void ellipse(int a,int b,HDC hdc)
{
	int x=0,y=b;
	int aa=a*a,bb=b*b,aa2=aa*2,bb2=bb*2;
	int fx=0,fy=aa2*b;
	int p=(int)(bb-aa*b+0.25*aa);
	while(fx<fy)
	{
		SetPixel(hdc,x+point1.x,y+point1.y,GColor);
		x++;
		fx=fx+bb2;
		if(p<0)
			p=p+fx+bb;
		else
		{
			y--;
			fy=fy-aa2;
			p=p+fx+bb-fy;
		}
	}
	SetPixel(hdc,x+point1.x,y+point1.y,GColor);
	p=(int)(bb*(x+0.5)*(x+0.5)+aa*(y-1)*(y-1)-aa*bb);
	while(y>0)
	{
		y--;
		fy=fy-aa2;
		if(p>=0)
			p=p-fy+aa;
		else
		{
			x++;
			fx=fx+bb2;
			p=p+fx-fy+aa;
		}
		SetPixel(hdc,x+point1.x,y+point1.y,GColor);
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
	COLORREF bc=GetBkColor(hdc);
	bc=RGB(255,255,255);
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
	x++;
	while(col==bc && col!=fc)
	{
		SetPixel(hdc,x,y,fc);
		++x;
		col=GetPixel(hdc,x,y);
	}
	x--;
	count1=x-xs;
	x=xs;
	col=GetPixel(hdc,xs-1,y);
	x--;
	while(col==bc && col!=fc)
	{
		SetPixel(hdc,x,y,fc);
		x--;
		col=GetPixel(hdc,x,y);
	}
	x++;
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
	y--;
	count3=y-ys;
	y=ys;
	col=col=GetPixel(hdc,xs,ys-1);
	y--;
	while(col==bc && col!=fc)
	{
		SetPixel(hdc,x,y,fc);
		y--;
		col=GetPixel(hdc,x,y);
	}
	y++;
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
	case WM_SIZE:
		
	case WM_COMMAND:
		switch(LOWORD(wParam))
		{
		case IDC_LINE:
			CheckMenuRadioItem(hMenu,IDM_DRAW_LINE,IDM_DRAW_FILL,IDM_DRAW_LINE,MF_BYCOMMAND);
			d='l';
			break;
		case IDC_CIRCLE:
			CheckMenuRadioItem(hMenu,IDM_DRAW_LINE,IDM_DRAW_FILL,IDM_DRAW_CIRCLE,MF_BYCOMMAND);
			d='c';
			break;
		case IDC_SQUARE:
			CheckMenuRadioItem(hMenu,IDM_DRAW_LINE,IDM_DRAW_FILL,IDM_DRAW_SQUARE,MF_BYCOMMAND);
			d='s';
			break;
		case IDC_RECT:
			CheckMenuRadioItem(hMenu,IDM_DRAW_LINE,IDM_DRAW_FILL,IDM_DRAW_RECTANGLE,MF_BYCOMMAND);
			d='r';
			break;
		case IDC_ELLIPSE:
			CheckMenuRadioItem(hMenu,IDM_DRAW_LINE,IDM_DRAW_FILL,IDM_DRAW_ELLIPSE,MF_BYCOMMAND);
			d='e';
			break;
		case IDC_FILL:
			CheckMenuRadioItem(hMenu,IDM_DRAW_LINE,IDM_DRAW_FILL,IDM_DRAW_FILL,MF_BYCOMMAND);
			d='f';
			break;
		case IDC_COLOR:
			CheckMenuRadioItem(hMenu,IDM_COLOR_RED,IDM_COLOR_CHOOSE,IDM_COLOR_CHOOSE,MF_BYCOMMAND);
			chooseColor(hdc);
			break;

		}
	}
	return 0;
}