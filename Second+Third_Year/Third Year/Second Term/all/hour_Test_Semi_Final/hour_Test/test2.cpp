//#include<windows.h>
//#include<Afx.h>
//#include<stdio.h>
//#include<conio.h>
#include<fstream.h>
//#include<dos.h>					//For Date & Time
//#include<stdlib.h>				//itoa
#include<string>
using namespace std;
#include <stdio.h>

#include <sys/types.h>
#include <sys/timeb.h>
#include<time.h>

#include"math.h"
#include"test.h"
#include"trasformations.h"
///////////////////////////////////////////////////////////////////
char tmpbuf[128], ampm[] = "AM";
    time_t ltime;
    struct _timeb tstruct();
    struct tm *today, *gmt, xmas = { 0, 0, 12, 25, 11, 93 };
	//_tzset();
 //_strtime( tmpbuf );
//   CTime theTime = CTime::GetCurrentTime(); 
	//_ftime( &tstruct );

//int mill=tstruct.miltlim;
BOOL SetNewTime(WORD hour, WORD minutes)
{
    SYSTEMTIME st;
    char *pc;

    GetSystemTime(&st);       // gets current time
    st.wHour = hour;          // adjusts hours 
    st.wMinute = minutes;     // and minutes
    if (!SetSystemTime(&st))  // sets system time
        return FALSE;
    return TRUE;
}

void getTime2(int& h,int& m,int& s)
{
	 SYSTEMTIME st;
    char *pc;

    GetSystemTime(&st); 
	h=st.wHour;
	m=st.wMinute;
	s=st.wSecond;
	//MessageBox(0,(char*)s,"Error" ,MB_ICONSTOP|MB_OK);
	
}

void getTime3(int& h,int& m,int& s)
{
	char tmpbuf[128], ampm[] = "AM";
    time_t ltime;
    struct _timeb tstruct;
    struct tm *today, *gmt, xmas = { 0, 0, 12, 25, 11, 93 };

    /* Set time zone from TZ environment variable. If TZ is not set,
     * the operating system is queried to obtain the default value 
     * for the variable. 
     */
    _tzset();

    /* Display operating system-style date and time. */
    _strtime( tmpbuf );
	char ch[2];
	ch[0]=tmpbuf[0];
	ch[1]=tmpbuf[1];
	h=atoi(ch);
	ch[0]=tmpbuf[3];
	ch[1]=tmpbuf[4];
	m=atoi(ch);
	ch[0]=tmpbuf[6];
	ch[1]=tmpbuf[7];
	s=atoi(ch);
	//return tmpbuf;
}

///////////////////////////////////////////////////////////////////
LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);
static char gszClassName[]  =  "MyWindowClass";
static HINSTANCE ghInstance  =  NULL;

struct vector2
{
	double v[3];
	vector2(int x,int y, int c=1)
	{
		v[0]=x;
		v[1]=y;
		v[2]=c;

	}
	double& operator [] (int a)
	{
		return v[a];
	}
};


//void mul(double a[][],double b[],double c[]);


int WINAPI WinMain(HINSTANCE hInstance , HINSTANCE hprevInstance , LPSTR lpCmdLine ,int nCmdShow)
{
	WNDCLASSEX WndClass;
	HWND hwnd;
	MSG Msg;
	ghInstance  =  hInstance ;
	WndClass.cbSize  =  sizeof(WNDCLASSEX);
	WndClass.style  =  NULL;
	WndClass.lpfnWndProc  =  WndProc ;
	WndClass.cbClsExtra  = 0;
	WndClass.cbWndExtra  =  0;
	WndClass.hInstance  = ghInstance ;
	WndClass.hIcon  =  LoadIcon(NULL,IDI_APPLICATION);
	WndClass.hCursor  = LoadCursor(NULL ,IDC_ARROW);
    WndClass.hbrBackground  =  (HBRUSH)(COLOR_WINDOW+20);
    WndClass.lpszMenuName  =  NULL ;
	WndClass.lpszClassName  =  gszClassName ;
	WndClass.hIconSm  =  LoadIcon(NULL , IDI_APPLICATION);
	if(!RegisterClassEx(&WndClass))
	{
		MessageBox(0, "window registeration failed!!","error",MB_ICONSTOP|MB_OK);
		return 0;
	}

	hwnd  = CreateWindowEx(WS_EX_STATICEDGE , gszClassName ," Transformations",WS_OVERLAPPEDWINDOW ,
		CW_USEDEFAULT ,CW_USEDEFAULT,800,600,NULL,NULL,ghInstance,NULL);
	if(hwnd == NULL)
	{
		MessageBox(0,"windows greated failed!!","Error" ,MB_ICONSTOP|MB_OK);
         return 0;
	}
	ShowWindow(hwnd,nCmdShow);
	
	UpdateWindow(hwnd);

	SetTimer(hwnd, 1, 1000, NULL);

	
	while(GetMessage(&Msg ,NULL ,0,0))
	{
		TranslateMessage(&Msg);
		DispatchMessage(&Msg);
	}

	KillTimer(hwnd, 1); /* stop the timer */

	return Msg.wParam;
}
/////////////////////////////////////////////////////////////////////////////
int TIME[8];
/*void getsystime()
	{
	struct time t;
	gettime(&t);
	TIME[1] = t.ti_hour%10;
	TIME[0] = t.ti_hour/10;
	TIME[2] = 10;
	TIME[4] = t.ti_min%10;
	TIME[3] = t.ti_min/10;
	TIME[5] = 10;
	TIME[7] = t.ti_sec%10;
	TIME[6] = t.ti_sec/10;
	}
*/

/////////////////////////////
void mulMatrices(float m1[3][3], float m2[3][3], float m3[3][3])
{
	for(int i=0; i<3; i++)
		for(int j=0; j<3; j++)
			for(int k=0; k<3; k++)
			{
				m3[i][j] += m1[i][k] * m2[k][j];
			}
}
/*********************************************************/
				 // Transformations //
/*********************************************************/
void translation(HDC hdc, float x1, float y1, float x2, float y2)
{
	int dx = 20, dy = 20;
	float matrix1[3][3], matrix2[3][3], result[3][3];
	matrix1[0][0] = matrix1[1][1] = matrix1[2][2] = 1;
	matrix1[0][1] = matrix1[1][0] = matrix1[2][0] = matrix1[2][1] = 0;
	matrix1[0][2] = dx;
	matrix1[1][2] = dy;

	matrix2[0][0] = x1;
	matrix2[1][0] = y1;
	matrix2[0][1] = x2;
	matrix2[1][1] = y2;
	matrix2[0][2] = matrix2[1][2] = 0;
	matrix2[2][0] = matrix2[2][1] = matrix2[2][2] = 1;

	for(int i=0; i<3;i++)
		for(int j=0; j<3;j++)
			result[i][j] = 0;
	mulMatrices(matrix1, matrix2, result);

	// original line
	MoveToEx(hdc, int(matrix2[0][0]), int(matrix2[1][0]), NULL);
	LineTo(hdc, int(matrix2[0][1]), int(matrix2[1][1]));

	// resulted line
	MoveToEx(hdc, int(result[0][0]), int(result[1][0]), NULL);
	LineTo(hdc, int(result[0][1]), int(result[1][1]));
}
float mat3[2];
COLORREF white=RGB(255,255,255);
COLORREF green=RGB(0,255,0);
COLORREF red=RGB(255,0,0);
COLORREF blue=RGB(0,0,255);
/////////////////////////////////////////////////
vector2 rotation(HDC hdc,float x2, float y2, float h, float k, float angle)
{
	double v1[3],v2[3];
	double matrix1[3][3];//, result[3][3];
	//vector  matrix2[3];
	v1[0]=x2;
	v1[1]=y2;
	v1[2]=1;

	matrix1[0][0] = matrix1[1][1] = cos(angle*3.14/180);
	matrix1[0][1] = - sin(angle*3.14/180);
	matrix1[1][0] = sin(angle*3.14/180);
	matrix1[0][2] = -h * cos(angle*3.14/180) + k * sin(angle*3.14/180) + h;
	matrix1[1][2] = -h * sin(angle*3.14/180) - k * cos(angle*3.14/180) + k;
	matrix1[2][0] = matrix1[2][1] = 0;
	matrix1[2][2] = 1;

	//matrix2[0]] = x1;
	//matrix2[1][0] = y1;
	//matrix2[0] = x2;
	//matrix2[1] = y2;
	//matrix2[0][2] = matrix2[1][2] = 0;
	//matrix2[2]=1;

	/*for(int i=0; i<3;i++)
		for(int j=0; j<3; j++)
			result[i][j] = 0;
	
	mulMatrices(matrix1, matrix2, result);*/

//mul(matrix1,v1,v1);
for (int i=0;i<3;i++)
	{
		v2[i]=0;
		for(int j=0;j<3;j++)
		{
			v2[i]+=matrix1[i][j]*v1[j];
		}
	}

vector2 vec(v2[0],v2[1],v2[2]);

return vec;
//return v1;
	// original line
	//MoveToEx(hdc, int(matrix2[0][0]), int(matrix2[1][0]), NULL);
	//LineTo(hdc, int(matrix2[0][1]), int(matrix2[1][1]));
	//Sleep(500);
	//BHA_ALGORITHM_Line(hdc,150,120,int(matrix2[0][1]),int(matrix2[1][1]),white);
	

	// resulted line
	//MoveToEx(hdc, int(result[0][0]), int(result[1][0]), NULL);
	//mat3[0]=int(result[0][1]);
	//mat3[1]=int(result[1][1]);
	//LineTo(hdc, int(result[0][1]), int(result[1][1]));
	//Sleep(500);
	//BHA_ALGORITHM_Line(hdc,150,120,int(result[0][1]),int(result[1][1]),white);
}



/////////////////////////////////////////////////

/*double[] mul(double a[][],double b[],double v[])
{
	//	vector v;
	//double v[3];
	for (int i=0;i<3;i++)
	{
		v[i]=0;
		for(int j=0;j<3;j++)
		{
			v[i]+=a[i][j]*b[j];
		}
	}
	return v;

}


*/



void scaling(HDC hdc, float x1, float y1, float x2, float y2, float h, float k,float sx, float sy)
{
	float matrix1[3][3], matrix2[3][3], result[3][3];
	matrix1[0][0] = sx;
	matrix1[1][1] = sy;
	matrix1[0][1] = matrix1[1][0] = matrix1[2][0] = matrix1[2][1] = 0;
	matrix1[2][2] = 1;
	matrix1[2][2] = -sx * h + h;
	matrix1[2][2] = -sy * k + k;

	matrix2[0][0] = x1;
	matrix2[1][0] = y1;
	matrix2[0][1] = x2;
	matrix2[1][1] = y2;
	matrix2[0][2] = matrix2[1][2] = 0;
	matrix2[2][0] = matrix2[2][1] = matrix2[2][2] = 1;

	for(int i=0; i<3;i++)
		for(int j=0; j<3;j++)
			result[i][j] = 0;
	mulMatrices(matrix1, matrix2, result);

	// original line
	MoveToEx(hdc, int(matrix2[0][0]), int(matrix2[1][0]), NULL);
	LineTo(hdc, int(matrix2[0][1]), int(matrix2[1][1]));

	// resulted line
	MoveToEx(hdc, int(result[0][0]), int(result[1][0]), NULL);
	LineTo(hdc, int(result[0][1]), int(result[1][1]));
}
//==============================================/
float h = 0, k = 0, xCenter = 0, yCenter = 0, xs, ys, xf, yf;
int i2,z2,z,z3=1;
vector2 vec1(500,45,1),vec2(500,45,1),vec3(500,45,1),text_w(500,30,1);
float hour=6.0/360.0;
float min=0.1;
//CTime s;
//struct time t;
int hh,mm,ss,inum,xx;
string str;
//ofstream fout;
	//_tzset();
//	_strtime( tmpbuf );
//string charr[12];
//char ch4=(char)(48);
//char* ch3=reinterpret_cast<char*>(ch4);
char* ch3;
char ch[10];
bool go=false,round2;
/***********************************************/
LRESULT CALLBACK WndProc(HWND hwnd ,UINT Message ,WPARAM wparam ,LPARAM
						 lparam)
{
	COLORREF boundaryColor = RGB(100, 0, 100);
	COLORREF fillColor = RGB(125, 120, 0);
	HDC hdc;
	switch(Message)
	{
	//case WM_PAINT:
	//	break;
	case WM_CLOSE:
		DestroyWindow(hwnd);
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	case WM_LBUTTONDOWN:
		hdc = GetDC(hwnd);
		xs = LOWORD(lparam);
		ys = HIWORD(lparam);
		break;

			case WM_TIMER: 
		if(go)
		{
			hdc=GetDC(hwnd);
		//	TextOut(hdc,20,20,"welcome timer",150);
			
			if(round2)
			{
				DDA_Line(hdc,500,400,vec1[0],vec1[1],white);
				vec1=rotation(hdc,vec1[0],vec1[1],500,400,6);
				round2=false;
			}

			z2=z%6;
			DDA_Line(hdc,500,400,vec1[0],vec1[1],green);
			DDA_Line(hdc,500,400,vec3[0],vec3[1],blue);
			
			
			
			
			if(z==1)DDA_Line(hdc,500,400,vec2[0],vec2[1],red);
			//
			
			if(z2==0)
			{
				DDA_Line(hdc,500,400,vec2[0],vec2[1],white);
				vec2=rotation(hdc,vec2[0],vec2[1],500,400,0.5/*5*min*/);
				DDA_Line(hdc,500,400,vec2[0],vec2[1],red);
				z3++;
			}
			if(z3%6==0)
			{
				DDA_Line(hdc,500,400,vec3[0],vec3[1],white);
				vec3=rotation(hdc,vec3[0],vec3[1],500,400,0.5);
				DDA_Line(hdc,500,400,vec3[0],vec3[1],blue);
				z3=1;
			}
			z++;
			if(!round2)round2=true;
		}
			
			break;
	


	case WM_LBUTTONUP:
		hdc = GetDC(hwnd);
		xf = LOWORD(lparam);
		yf = HIWORD(lparam);
//v2[1]=250;
//v2[0]=150;
/*
gettime (&t);//Load system time into structure t
	ss   = t.ti_sec;	//Store seconds
	mm   = t.ti_min;	//Store minutes
	hh    = t.ti_hour;	//Store hours
*/
		
//	hh=s.GetHour();
//	mm=s.GetMinute();
//	ss=s.GetSecond();

//		stringconcat
getTime3(hh,mm,ss);

/*fout.open("text.txt",ios::out);
fout<<hh<<" "<<mm<<" "<<ss<<endl;
fout.close();
//str.append(itoa(hh,);//+":"+mm+":"+ss;*/
//TextOut(hdc,10,10,getTime3(),120);


	//tmpbuf	
		

BHA_ALGORITHM_Circle(hdc,500,400,355,blue);
hdc = GetDC(hwnd);
		
		for(inum=1;inum<=12;inum++)
		//for(ch3=charr;ch3<"12";ch3++)
		{
			sprintf(ch,"%d",((inum+10)%12)+1);
			 TextOut(hdc, text_w[0], text_w[1],ch, strlen(ch));
			 /*
			switch(inum)
			{
			case 1:
				ch3="12";
				break;
				case 2:
				ch3="1";
				break;
				case 3:
				ch3="2";
				break;
				case 4:
				ch3="3";
				break;
				case 5:
				ch3="4";
				break;
				case 6:
				ch3="5";
				break;
				case 7:
				ch3="6";
				break;
				case 8:
				ch3="7";
				break;
				case 9:
				ch3="8";
				break;
				case 10:
				ch3="9";
				break;
				case 11:
				ch3="10";
				break;
				case 12:
				ch3="11";
				break;

			}
			TextOut(hdc,text_w[0],text_w[1],ch3,strlen(ch3));*/
			//ReleaseDC(hwnd,hdc);
			text_w=rotation(hdc,text_w[0],text_w[1],500,400,30);
		}
		

vec1=rotation(hdc,vec1[0],vec1[1],500,400,6*ss);
vec2=rotation(hdc,vec2[0],vec2[1],500,400,(6*ss/60)+(6*mm)/*5*min*/);
vec3=rotation(hdc,vec3[0],vec3[1],500,400,(30*mm/60)+(30*hh));
DDA_Line(hdc,500,400,vec3[0],vec3[1],blue);
DDA_Line(hdc,500,400,vec1[0],vec1[1],green);
DDA_Line(hdc,500,400,vec2[0],vec2[1],red);						
z=1;
go=true;

	/*	for(z=1;z>=0;z++)
		{
			z2=z%6;
			DDA_Line(hdc,500,400,vec1[0],vec1[1],green);
			
			DDA_Line(hdc,500,400,vec3[0],vec3[1],blue);
			Sleep(1000);
			DDA_Line(hdc,500,400,vec1[0],vec1[1],white);
			if(z==1)DDA_Line(hdc,500,400,vec2[0],vec2[1],red);
			//
			vec1=rotation(hdc,vec1[0],vec1[1],500,400,6);
			if(z2==0)
			{
				DDA_Line(hdc,500,400,vec2[0],vec2[1],white);*/
				//vec2=rotation(hdc,vec2[0],vec2[1],500,400,0.5/*5*min*/);
				/*DDA_Line(hdc,500,400,vec2[0],vec2[1],red);
				z3++;
			}
			if(z3%6==0)
			{
				DDA_Line(hdc,500,400,vec3[0],vec3[1],white);
				vec3=rotation(hdc,vec3[0],vec3[1],500,400,0.5);
				DDA_Line(hdc,500,400,vec3[0],vec3[1],blue);
				z3=1;
			}
			//
			//Sleep(1000);
		}*/
		//translation(hdc, xs, ys, xf, yf);
		break;
	case WM_RBUTTONDOWN:
		hdc = GetDC(hwnd);
		xCenter = LOWORD(lparam);
		yCenter = HIWORD(lparam);
		break;
	case WM_RBUTTONUP:
		//hdc = GetDC(hwnd);
		//xf = LOWORD(lparam);
		//yf = HIWORD(lparam);

		//rotation(hdc, xCenter, yCenter, xf, yf, 200, 200, 45*(3.14)/180);
//		scaling(hdc, xCenter, yCenter, xf, yf, 200, 200, 2, 2);
		break;
	default:
		return DefWindowProc(hwnd, Message, wparam, lparam);
	}
	return 0;
}//end of the program
