#include<windows.h>
#include"math.h"
///////////////////
LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);
static char gszClassName[]  =  "MyWindowClass";
static HINSTANCE ghInstance  =  NULL;
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
	while(GetMessage(&Msg ,NULL ,0,0))
	{
		TranslateMessage(&Msg);
		DispatchMessage(&Msg);
	}
	return Msg.wParam;
}
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
/////////////////////////////////////////////////
void rotation(HDC hdc, float x1, float y1, float x2, float y2, float h, float k, float angle)
{
	float matrix1[3][3], matrix2[3][3], result[3][3];
	matrix1[0][0] = matrix1[1][1] = cos(angle);
	matrix1[0][1] = - sin(angle);
	matrix1[1][0] = sin(angle);
	matrix1[0][2] = -h * cos(angle) + k * sin(angle) + h;
	matrix1[1][2] = -h * sin(angle) - k * cos(angle) + k;
	matrix1[2][0] = matrix1[2][1] = 0;
	matrix1[2][2] = 1;

	matrix2[0][0] = x1;
	matrix2[1][0] = y1;
	matrix2[0][1] = x2;
	matrix2[1][1] = y2;
	matrix2[0][2] = matrix2[1][2] = 0;
	matrix2[2][0] = matrix2[2][1] = matrix2[2][2] = 1;

	for(int i=0; i<3;i++)
		for(int j=0; j<3; j++)
			result[i][j] = 0;
	
	mulMatrices(matrix1, matrix2, result);

	// original line
	MoveToEx(hdc, int(matrix2[0][0]), int(matrix2[1][0]), NULL);
	LineTo(hdc, int(matrix2[0][1]), int(matrix2[1][1]));

	// resulted line
	MoveToEx(hdc, int(result[0][0]), int(result[1][0]), NULL);
	mat3[0]=int(result[0][1]);
	mat3[1]=int(result[1][1]);
	LineTo(hdc, int(result[0][1]), int(result[1][1]));
}
/////////////////////////////////////////////////
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
int i=0;
/***********************************************/
LRESULT CALLBACK WndProc(HWND hwnd ,UINT Message ,WPARAM wparam ,LPARAM
						 lparam)
{
	COLORREF boundaryColor = RGB(100, 0, 100);
	COLORREF fillColor = RGB(125, 120, 0);
	HDC hdc;
	switch(Message)
	{
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
	case WM_LBUTTONUP:
		hdc = GetDC(hwnd);
		xf = LOWORD(lparam);
		yf = HIWORD(lparam);
		mat3[1]=250;
mat3[0]=150;

		for(i=0;i<=360;i+=45)
		{
			rotation(hdc,150,120,mat3[0],mat3[1],150,120,45);
			Sleep(500);
		}
		//translation(hdc, xs, ys, xf, yf);
		break;
	case WM_RBUTTONDOWN:
		hdc = GetDC(hwnd);
		xCenter = LOWORD(lparam);
		yCenter = HIWORD(lparam);
		break;
	case WM_RBUTTONUP:
		hdc = GetDC(hwnd);
		xf = LOWORD(lparam);
		yf = HIWORD(lparam);
		//rotation(hdc, xCenter, yCenter, xf, yf, 200, 200, 45*(3.14)/180);
		scaling(hdc, xCenter, yCenter, xf, yf, 200, 200, 2, 2);
		break;
	default:
		return DefWindowProc(hwnd, Message, wparam, lparam);
	}
	return 0;
}//end of the program
