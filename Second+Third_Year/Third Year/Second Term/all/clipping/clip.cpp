#include<windows.h>
#include<math.h>
float xx1,yy1,xx2,yy2;
LRESULT CALLBACK WndProc(HWND , UINT , WPARAM ,LPARAM);
static char gszClassName[] = "MyWindowClass";
static HINSTANCE ghInstance = NULL;
void DDA_ALGORITHM(float , float , float , float , COLORREF ,HDC );
float X_min=210, X_max=500,Y_min=150, Y_max=430;
struct Interserct
{
	float Xi,Yi;
};
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
    WndClass.hbrBackground = (HBRUSH)(COLOR_WINDOW+21);
    WndClass.lpszMenuName = NULL ;
	WndClass.lpszClassName = gszClassName ;
	WndClass.hIconSm = LoadIcon(NULL , IDI_APPLICATION);
	if(!RegisterClassEx(&WndClass))
	{
		MessageBox(0, "window registeration failed!!","error",MB_ICONSTOP|MB_OK);
		return 0;
	}

	hwnd =CreateWindowEx(WS_EX_STATICEDGE , gszClassName ," Ch5 Clipping",WS_OVERLAPPEDWINDOW ,
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
/*//\\//\\\////\\//\\\////\\//\\\////\\//\\\////\\//\\\////\\//\\\//*/
void Draw_Window(float x1, float y1, float x2, float y2,COLORREF col,HDC hdc)
{
	DDA_ALGORITHM( x1, y1, x1, y2, col, hdc );
	DDA_ALGORITHM( x1, y1, x2, y1, col, hdc );
	DDA_ALGORITHM( x2, y2, x1, y2, col, hdc );
	DDA_ALGORITHM( x2, y2, x2, y1, col, hdc );
}
void Encode(bool  arr[4],float X,float Y)
{
	arr[0] = ( Y>Y_max );//top
	arr[1] = ( Y_min>Y );//bottom
	arr[2] = ( X>X_max );//right
	arr[3] = ( X_min>X );//left
}
bool Visable(bool arr1[4],bool arr2[4])
{
	for(int i=0;i<4;i++)
	{
		if(arr1[i]==1||arr2[i]==1)
			return false;
	}
	return true;
}

bool Visable_Point(bool arr[4])
{
	for(int i=0;i<4;i++)
	{
		if(arr[i]==1)
			return false;
	}
	return true;
}
bool Not_Visable( bool arr1[4],bool arr2[4] )
{
	for(int i=0;i<4;i++)
		if( arr1[i]==1&&arr2[i]==1)
			return true;
		return false;
		
}
Interserct Candidate(float X,float Y,bool code[4],float M)
{
	Interserct VR;
	//top
	if(code[0]==1)
	{
		VR.Yi=Y_max;
		VR.Xi=X+(VR.Yi-Y)/M;
	}
	//bottom
	if(code[1]==1)
	{
		VR.Yi=Y_min;
		VR.Xi=X+(VR.Yi-Y)/M;
	}
//right
	if(code[2]==1)
	{
		VR.Xi=X_max;
		VR.Yi=Y+M*(VR.Xi-X);
	}
	//left
	if(code[3]==1)
	{
		VR.Xi=X_min;
		VR.Yi=Y+M*(VR.Xi-X);
	}
return VR;
}
bool InterSect_Out_Of_Window(float x1,float y1,float x2,float y2)
{
		if( x1==X_max && y2==Y_max )//top right
			return true;
		if( x1==X_min && y2==Y_max )//top left
			return true;
		if( x2==X_max && y1==Y_min )//right bootom
			return true;
		if( x2==X_min && y1==Y_min )//left bootom
			return true;
		return false;
}
//===================================================================
void Cohen_Sutherland(float x1,float y1,float x2,float y2,COLORREF col,HDC hdc)
{
	COLORREF C=RGB(0,0,250);
	bool end_P1[4],end_P2[4];
	float M=(y2-y1)/(x2-x1);
	Interserct VI_P1,VI_P2;

	Encode( end_P1, x1, y1 );
	Encode( end_P2, x2, y2 );
	
	//not Visable
	if( Not_Visable(end_P1, end_P2) )
		return;
	
	//Visable line
	if( Visable( end_P1, end_P2  ) )
	{
		DDA_ALGORITHM( x1,y1,x2,y2,col,hdc );
		return;
	}
	//cat 3 . candidate clipping
	// intersect out of boundry
	if( Visable_Point(end_P1) )
	{
		VI_P1.Xi=x1;
		VI_P1.Yi=y1;
	}
	else
		VI_P1=Candidate(x1, y1, end_P1, M);
//_________________________________________	
	if( Visable_Point(end_P2) )
		{
			VI_P2.Xi=x2;
			VI_P2.Yi=y2;
		}
	else
		VI_P2=Candidate(x2, y2, end_P2, M);

DDA_ALGORITHM(x1,y1,VI_P1.Xi,VI_P1.Yi,C,hdc);
DDA_ALGORITHM(VI_P1.Xi,VI_P1.Yi,x2,y2,C,hdc);

  Cohen_Sutherland(VI_P1.Xi, VI_P1.Yi, VI_P2.Xi, VI_P2.Yi, col, hdc) ;
}
//====================================================================
LRESULT CALLBACK WndProc(HWND hwnd ,UINT Message ,WPARAM wparam ,LPARAM
						 lparam)
{
	COLORREF C0=RGB(0,0,250),C1=RGB(250,0,0),C2=RGB(0,0,0);
	
	HDC      hdc;
	hdc=GetDC( hwnd );
//	Draw_Window(X_min,Y_min,X_max,Y_max,C2,hdc);
	switch(Message)
	{
	case WM_CLOSE :
		DestroyWindow(hwnd);
	break ;
	
	case WM_DESTROY:
		PostQuitMessage(0);
	break ;

	case WM_RBUTTONDOWN:
		hdc=GetDC(hwnd);
			xx1 = LOWORD(lparam);
			yy1 = HIWORD(lparam);
			ReleaseDC(hwnd,hdc);
	break;

	case WM_LBUTTONDOWN:
		hdc=GetDC(hwnd);
		xx2 = LOWORD(lparam);
		yy2 = HIWORD(lparam);
Cohen_Sutherland(xx1,yy1,xx2,yy2,C1,hdc);
//Cohen_Sutherland(X_min,Y_min,X_max,Y_max,C2,hdc);
		ReleaseDC(hwnd,hdc);
		break;
	default:
		return DefWindowProc(hwnd,Message,wparam,lparam);
	}
	return 0;
}

/*====================================================================*/
void DDA_ALGORITHM(float x1, float y1, float x2, float y2, COLORREF col,HDC hdc)
{
	float xBegin  =  x1;
	float xFinal  =  x2;
	float yBegin  =  y1;
	float yFinal  =  y2;
	float slope = (y2 - y1) / (x2 - x1);
	float slopeInverse  =  1 / slope;

	if(x1>x2 && y1>y2)
	{
		xBegin  =  x2;
	    xFinal  =  x1;
		yBegin  =  y2;
	    yFinal  =  y1;
	}
	int x = int(xBegin);
	int y = int(yBegin);

	// if the line is parallel to the y coordinate
	if((xBegin - xFinal) == 0)
		if(yBegin < yFinal)	// and y starting point greater than y end
			while(y <= yFinal)
			{
				SetPixel(hdc, x, y, col);
				y ++;	// increment y
			}
		else
			while(y >= yFinal)
			{
				SetPixel(hdc, x, y, col);
				y --;	// decrement y
			}
	// if the line is parallel to the x coordinate
	else
		if((yBegin - yFinal) == 0)
			if(xBegin < xFinal) // and x starting point greater than x end
				while(x <= xFinal)
				{
					SetPixel(hdc, x, y, col);
					x ++;
				}
			else
				while(x >= xFinal)
				{
					SetPixel(hdc, x, y, col);
					x --;
				}
	else
		if(slope >= 1 || slope <= -1) // new case
		{
			if(yFinal > yBegin) // from begin to end
				while(y <= yFinal)
				{
					x = int(xBegin + 0.5);
					xBegin = xBegin + slopeInverse;
					SetPixel(hdc, x, y, col);
					y ++;
				}
			else		// from end to begin
				while(y >= yFinal)
				{
					x = int(xBegin + 0.5);
					xBegin = xBegin - slopeInverse;
					SetPixel(hdc, x, y, col);
					y --;
				}
		}
	else
		if(slopeInverse >= 1 || slopeInverse <= -1) // new case
		{
			if(xFinal > xBegin)	// from begin to end
				while(x <= xFinal)
				{
					y = int(yBegin + 0.5);
					yBegin = yBegin + slope;
					SetPixel(hdc, x, y, col);
					x ++;
				}
			else		// from end to begin
				while(x >= xFinal)
				{
					y = int(yBegin + 0.5);
					yBegin = yBegin - slope;
					SetPixel(hdc, x, y, col);
					x --;
				}
		}//if
}
