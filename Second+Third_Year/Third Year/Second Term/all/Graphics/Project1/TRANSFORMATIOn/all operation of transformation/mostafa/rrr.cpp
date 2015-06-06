//breswnham aldorithm with m<1
#include <windows.h>
#include<math.h>
int width =500,hight=500;
LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);
static char gszClassName[] = "MyWindowClass";
HDC hdc;
COLORREF color=RGB(255,255,255);
void translation_line(HDC,float,float,float,float );
void translation_triangle(HDC,float ,float ,float,float ,float, float);
static HINSTANCE ghInstance = NULL;

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow) 
{
	WNDCLASSEX WndClass;
    HWND hwnd;
    MSG Msg;
	ghInstance = hInstance;
	WndClass.cbSize = sizeof(WNDCLASSEX);
	WndClass.style = NULL;
	WndClass.lpfnWndProc = WndProc;
	WndClass.cbClsExtra = 0;
	WndClass.cbWndExtra = 0;
	WndClass.hInstance = ghInstance;
	WndClass.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	WndClass.hCursor = LoadCursor(NULL, IDC_ARROW);
	WndClass.hbrBackground = (HBRUSH)(COLOR_WINDOW+8);
	WndClass.lpszMenuName = NULL;
	WndClass.lpszClassName = gszClassName;
	WndClass.hIconSm = LoadIcon(NULL, IDI_APPLICATION);
	
	if(!RegisterClassEx(&WndClass)) {MessageBox(0, "Window Registration Failed!", "Error!", MB_ICONSTOP | MB_OK);	return 0;}

    hwnd = CreateWindowEx(WS_EX_STATICEDGE,gszClassName,"Windows Title",WS_OVERLAPPEDWINDOW,CW_USEDEFAULT, CW_USEDEFAULT,width, hight,NULL, NULL,ghInstance,NULL);

    if(hwnd == NULL) { MessageBox(0, "Window Creation Failed!", "Error!", MB_ICONSTOP | MB_OK); return 0; }

	ShowWindow(hwnd, nCmdShow);
	UpdateWindow(hwnd);
	while(GetMessage(&Msg, NULL, 0, 0)) {TranslateMessage(&Msg);DispatchMessage(&Msg);}
	return Msg.wParam;
}
LRESULT CALLBACK WndProc(HWND hwnd, UINT Message, WPARAM wParam, LPARAM lParam) {
			
	
switch(Message) {
	case WM_CLOSE:
	DestroyWindow(hwnd);
		break;
	case WM_DESTROY:
	PostQuitMessage(0);
		break;

	
    case  WM_MOUSEMOVE:
		hdc=GetDC(hwnd);
		MoveToEx(hdc,10,400,NULL);
		LineTo(hdc,10,-400);

		MoveToEx(hdc,400,10,NULL);
		LineTo(hdc,-400,10);
		Sleep(1000);
		break;
    case  WM_LBUTTONDOWN:
		hdc=GetDC(hwnd);
	    translation_line(hdc,30,30,90,90);
		Sleep(1000);
		translation_triangle(hdc,150,40,180,80,210,40);

		ReleaseDC(hwnd, hdc);
		break;
	default:
		return DefWindowProc(hwnd, Message, wParam, lParam);
}
	return 0;
}//end the program
////////////////
struct matrix
{
	float m[3][3];
};
////////
struct vector
{
	float v[3];
};
//////
void iden(matrix & t)
{
	for(int i=0;i<3;i++)
		for(int j=0;j<3;j++)
			(t.m[i][j]=(i==j))?  1 : 0;
}
///////////
matrix translate(float dx,float dy)
{
	matrix t;
	iden(t);
	t.m[0][2]=dx;
	t.m[1][2]=dy;
	return t;
}

vector mult(matrix as ,vector bs)
{
	vector r;
	for(int i=0;i<3;i++)
	{
		r.v[i]=0;
		for(int j=0;j<3;j++)
			r.v[i] += as.m[i][j]*bs.v[j];
	}
	return r;
}

void translation_line(HDC dc ,float x1,float y1 ,float x2,float y2 )
{
	MoveToEx(hdc,x1,y1,NULL);
	LineTo(hdc,x2,y2);
    matrix t=translate(60,6);
    vector a,b;
    a.v[0]=x1; a.v[1]=y1; a.v[2]=1;
    b.v[0]=x2; b.v[1]=y2; b.v[2]=1;
    vector aa=mult(t,a);
    vector bb=mult(t,b);
	MoveToEx(hdc,aa.v[0],aa.v[1],NULL);
	LineTo(hdc,bb.v[0],bb.v[1]);
}
void translation_triangle(HDC dc ,float x1,float y1 ,float x2,float y2 ,float x3, float y3)
{

    MoveToEx(hdc,x1,y1,NULL);
	LineTo(hdc,x2,y2);

    MoveToEx(hdc,x1,y1,NULL);
	LineTo(hdc,x3,y3);

	MoveToEx(hdc,x2,y2,NULL);
	LineTo(hdc,x3,y3);

    matrix t=translate(55,40);
	matrix tt=translate(55,40);
	matrix ttt=translate(85,0);
    vector a,b,c;
    a.v[0]=x1; a.v[1]=y1; a.v[2]=1;
    b.v[0]=x2; b.v[1]=y2; b.v[2]=1;
	c.v[0]=x2; c.v[1]=y2; c.v[2]=1;
    vector aa=mult(t,a);
    vector bb=mult(tt,b);
	vector cc=mult(ttt,c);

   MoveToEx(hdc,aa.v[0],aa.v[1],NULL);
	LineTo(hdc,bb.v[0],bb.v[1]);

	 MoveToEx(hdc,cc.v[0],cc.v[1],NULL);
	LineTo(hdc,aa.v[0],aa.v[1]);

	 MoveToEx(hdc,bb.v[0],bb.v[1],NULL);
   	LineTo(hdc,cc.v[0],cc.v[1]);
}