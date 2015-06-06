// gui_bot.h: implements the Windows function, and starts the
// Windows To support event driven programming
// Lawrenceville Press September 1998

#include <windows.h>
#include <stdio.h>

// Standard prototype for window procedure.
//LRESULT FAR PASCAL _export WndProc(HWND hWnd, UINT message,
//	 WPARAM wParam, LPARAM lParam);
LONG PASCAL WndProc(HWND hWnd, UINT message,
	 WPARAM wParam, LPARAM lParam);
// Class which acts as wrapper for GUI functions
class MyGuiWindow {
	public:
		friend void Circle(int xc,int yc,int r);
		friend void Line(int x1, int y1, int x2, int y2);
		friend int MessageBox(String Text, String Title);
		friend int MessageBoxYN(String Text, String Title);
//		friend int SetTimer(UINT TimerID, UINT Time);  // Not implemented
		friend void SetColor(int R, int G, int B);
		friend void SetFillColor(int R, int G, int B);
		friend void SetColor(COLORREF NewColor);
		friend void SetFillColor(COLORREF NewColor);
		friend void SetThickness(int PixelWidth);
		friend void FloodFill(int x, int y);
		friend void SetPixel(int x, int y);
		friend int GetPixel(int x, int y);
		friend void DrawText(String S);
		friend void DrawText(int N);
		friend void DrawText(long N);
		friend void DrawText(double D);
		friend void DrawCenteredText(String S);
		friend void DrawCenteredText(int N);
		friend void DrawCenteredText(long N);
		friend void DrawCenteredText(double D);
		friend void SetTextColor(COLORREF NewColor);
		friend void SetTextSize(int NewFontSize);
		friend void SetTextFont(String FontName);
		friend void gotoxy(int x, int y);
		friend int wherex();
		friend int wherey();

		friend void FilledCircle(int xc,int yc,int r);
		friend void Rectangle(int x1, int y1, int x2, int y2);
		friend void FilledRectangle(int x1, int y1, int x2, int y2);

		MyGuiWindow();

	private:
		void open(HWND hwnd, HDC win_hdc);
		HDC _hdc;
		HWND _hwnd;
		int _disp_xmax; // the physical window dimension (in pixels)
		int _disp_ymax;
		int RedVal, GreenVal, BlueVal, ThickVal;
		int RedFillVal, GreenFillVal, BlueFillVal;
		int RedTextVal, GreenTextVal, BlueTextVal;
		int FontSize;
		String FontName;
		int FontFamily;

		// The core function should have access to my wrapper data: friend
//		friend LRESULT FAR PASCAL _export WndProc(HWND hWnd, UINT message,
//		 WPARAM wParam, LPARAM lParam);
		friend LRESULT FAR PASCAL WndProc(HWND hWnd, UINT message,
		 WPARAM wParam, LPARAM lParam);

	};

//-------------------------------------------------------
// Global objects
GuiClass GUI;  // "User" defined
MyGuiWindow gui_out; // The actual Window object
HINSTANCE GlobalhInstance;  // Global instance handle
//-------------------------------------------------------
MyGuiWindow::MyGuiWindow():
	RedVal(0),GreenVal(0), BlueVal(0), ThickVal(1),
	RedFillVal(0),GreenFillVal(0), BlueFillVal(0),
	RedTextVal(0),GreenTextVal(0), BlueTextVal(0), FontSize(22),
	FontName("System"), FontFamily(FF_SWISS)
{}
//-------------------------------------------------------
void MyGuiWindow::open(HWND hwnd, HDC win_hdc)
{
	RECT rect;
	GetClientRect(hwnd, &rect);
	_disp_xmax = rect.right - 1;
	_disp_ymax = rect.bottom - 1;

	_hdc = win_hdc;
	_hwnd = hwnd;

	SelectObject(_hdc, GetStockObject(NULL_BRUSH));
	SelectObject(_hdc, GetStockObject(BLACK_PEN));
	SelectObject(_hdc, GetStockObject(SYSTEM_FONT));
}
//-------------------------------------------------------
int GetMaxX()
{
	return GetSystemMetrics(SM_CXSCREEN);
}

//-------------------------------------------------------
int GetMaxY()
{
	return GetSystemMetrics(SM_CYSCREEN);
}

//-------------------------------------------------------
void Line(int x1, int y1, int x2, int y2)
{
	HPEN hpen = CreatePen(PS_SOLID, gui_out.ThickVal,
						RGB(gui_out.RedVal, gui_out.GreenVal, gui_out.BlueVal));
	HPEN hpenOld = HPEN(SelectObject(gui_out._hdc, hpen));
	//MoveTo(gui_out._hdc, x1, y1);
	MoveToEx(gui_out._hdc, x1, y1, NULL);
	LineTo(gui_out._hdc, x2, y2);
	SelectObject(gui_out._hdc, hpenOld);
	DeleteObject(hpen);
}
//---------------------------------------------------
void Circle(int xc,int yc,int r)
{
	HPEN hpen = CreatePen(PS_INSIDEFRAME, gui_out.ThickVal,
						RGB(gui_out.RedVal, gui_out.GreenVal, gui_out.BlueVal));
	HPEN hpenOld = HPEN(SelectObject(gui_out._hdc, hpen));
	Ellipse(gui_out._hdc,xc-r, yc-r, xc+r, yc+r);
	SelectObject(gui_out._hdc, hpenOld);
	DeleteObject(hpen);
}
//---------------------------------------------------
void Rectangle(int x1, int y1, int x2, int y2)
{
	HPEN hpen = CreatePen(PS_INSIDEFRAME, gui_out.ThickVal,
						RGB(gui_out.RedVal, gui_out.GreenVal, gui_out.BlueVal));
	HPEN hpenOld = HPEN(SelectObject(gui_out._hdc, hpen));
	Rectangle(gui_out._hdc,x1, y1, x2, y2);
	SelectObject(gui_out._hdc, hpenOld);
	DeleteObject(hpen);
}
//---------------------------------------------------
void DrawText(String S)
{
	SetTextColor(gui_out._hdc, RGB(gui_out.RedTextVal, gui_out.GreenTextVal, gui_out.BlueTextVal));
	HFONT hFont = CreateFont(gui_out.FontSize,0,0,0,FW_NORMAL,0,0,0,
			ANSI_CHARSET, OUT_DEFAULT_PRECIS, CLIP_DEFAULT_PRECIS,
			PROOF_QUALITY, gui_out.FontFamily | VARIABLE_PITCH, gui_out.FontName.c_str());
	HFONT hOldFont = HFONT(SelectObject(gui_out._hdc, hFont));
// Below for Visual C++

	POINT P;
	GetCurrentPositionEx(gui_out._hdc, &P);
	SetTextAlign(gui_out._hdc,TA_BASELINE | TA_LEFT | TA_UPDATECP);
	TextOut(gui_out._hdc,P.x,P.x,S.c_str(),S.length());
// Above for Visual C++
//*/
	/*  This for Borland C++
	DWORD P = GetCurrentPosition(gui_out._hdc);
	SetTextAlign(gui_out._hdc,TA_BASELINE | TA_LEFT | TA_UPDATECP);
	TextOut(gui_out._hdc,LOWORD(P),HIWORD(P),S.c_str(),S.length());
	//*/
	SelectObject(gui_out._hdc, hOldFont);
	DeleteObject(hFont);
}
//---------------------------------------------------
void DrawCenteredText(String S)
{
	SetTextColor(gui_out._hdc, RGB(gui_out.RedTextVal, gui_out.GreenTextVal, gui_out.BlueTextVal));
	HFONT hFont = CreateFont(gui_out.FontSize,0,0,0,FW_NORMAL,0,0,0,
			ANSI_CHARSET, OUT_DEFAULT_PRECIS, CLIP_DEFAULT_PRECIS,
			PROOF_QUALITY, gui_out.FontFamily | VARIABLE_PITCH, gui_out.FontName.c_str());
	HFONT hOldFont = HFONT(SelectObject(gui_out._hdc, hFont));
// Below for Visual C++
	POINT P;
	GetCurrentPositionEx(gui_out._hdc, &P);
	SetTextAlign(gui_out._hdc,TA_BASELINE | TA_CENTER | TA_UPDATECP);
	TextOut(gui_out._hdc,P.x,P.x,S.c_str(),S.length());
// Above for Visual C++

	/* This for Borland
	DWORD P = GetCurrentPosition(gui_out._hdc);
	SetTextAlign(gui_out._hdc,TA_BASELINE | TA_CENTER | TA_UPDATECP);
	TextOut(gui_out._hdc,LOWORD(P),HIWORD(P),S.c_str(),S.length());
	*/
	SelectObject(gui_out._hdc, hOldFont);
	DeleteObject(hFont);
}
//---------------------------------------------------
void DrawText(int N)
{
	char buf[80];
	wsprintf(buf,"%i",N);
	String S = buf;
	DrawText(S);
}
//-------------------------------------------------------
void DrawText(long N)
{
	char buf[80];
	wsprintf(buf,"%li",N);
	String S = buf;
	DrawText(S);
}
//---------------------------------------------------
void DrawText(double D)
// Print double in XXX.XX form, with exactly two decimals
{
	char buf[80];
	int whole = int(D);
	int fraction = int((D-whole)*100);
	if (fraction < 0)
		fraction = -fraction;
	wsprintf(buf,"%i.%i",whole,fraction);
	String S = buf;
	DrawText(S);
}
//---------------------------------------------------
void DrawCenteredText(int N)
{
	char buf[80];
	wsprintf(buf,"%i",N);
	String S = buf;
	DrawCenteredText(S);
}
//-------------------------------------------------------
void DrawCenteredText(long N)
{
	char buf[80];
	wsprintf(buf,"%li",N);
	String S = buf;
	DrawCenteredText(S);
}
//---------------------------------------------------
void DrawCenteredText(double D)
// Print double in XXX.XX form, with exactly two decimals
{
	char buf[80];
	int whole = int(D);
	int fraction = int((D-whole)*100);
	if (fraction < 0)
		fraction = -fraction;
	wsprintf(buf,"%i.%i",whole,fraction);
	String S = buf;
	DrawCenteredText(S);
}
//---------------------------------------------------
void SetTextColor(COLORREF NewColor)
{
	gui_out.RedTextVal = GetRValue(NewColor);
	gui_out.GreenTextVal = GetGValue(NewColor);
	gui_out.BlueTextVal = GetBValue(NewColor);
}
//---------------------------------------------------
void SetTextSize(int NewFontSize)
{
	gui_out.FontSize = NewFontSize;
}
//---------------------------------------------------
void SetTextFont(String NewFontName)
{
	if (NewFontName == "Arial"
		|| NewFontName == "System"
		|| NewFontName == "Times New Roman"){
		gui_out.FontName = NewFontName;
		if (NewFontName == "Times New Roman")
			gui_out.FontFamily = FF_ROMAN;
		else
			gui_out.FontFamily = FF_SWISS;
		}
}
//---------------------------------------------------
void SetPixel(int x, int y)
{
SetPixel(gui_out._hdc, x, y,
RGB(gui_out.RedVal, gui_out.GreenVal, gui_out.BlueVal));
RECT rect;
rect.left = x;
rect.top = y;
rect.right = x;
rect.bottom = y;
InvalidateRect(gui_out._hwnd, &rect, TRUE);
}
//---------------------------------------------------
int GetPixel(int x, int y)
/* Returns true iff pixel is not white */
{
return (GetPixel(gui_out._hdc,x,y)!=RGB(255,255,255));
}
//---------------------------------------------------
int wherex()
{
// Below for Visual
	POINT P;
	GetCurrentPositionEx(gui_out._hdc, &P);
	return P.x;
// Above for Visual */
/* Below for Borland:
	DWORD P = GetCurrentPosition(gui_out._hdc);
	return LOWORD(P);
// Above for Borland */
}
//---------------------------------------------------
int wherey()
{
// Below for Visual
	POINT P;
	GetCurrentPositionEx(gui_out._hdc, &P);
	return P.y;
// Above for Visual */
/* Below for Borland
DWORD P = GetCurrentPosition(gui_out._hdc);
return HIWORD(P);
// Above for Borland */
}
//---------------------------------------------------
void gotoxy(int x, int y)
{
	// Borland: 	MoveTo(gui_out._hdc, x, y);
	MoveToEx(gui_out._hdc, x, y, NULL); // Visual
}
//---------------------------------------------------
int MessageBox(String Text, String Title)
{
	return MessageBox(gui_out._hwnd, Text.c_str(), Title.c_str(),
					MB_OK	| MB_ICONINFORMATION);
}
//---------------------------------------------------
int MessageBoxYN(String Text, String Title)
{
	return MessageBox(gui_out._hwnd, Text.c_str(), Title.c_str(),
					MB_YESNO	| MB_ICONQUESTION)==IDYES;
}
//---------------------------------------------------
void SetColor(COLORREF NewColor)
{
	gui_out.RedVal = GetRValue(NewColor);
	gui_out.GreenVal = GetGValue(NewColor);
	gui_out.BlueVal = GetBValue(NewColor);
}
//---------------------------------------------------
void SetFillColor(COLORREF NewColor)
{
	gui_out.RedFillVal = GetRValue(NewColor);
	gui_out.GreenFillVal = GetGValue(NewColor);
	gui_out.BlueFillVal = GetBValue(NewColor);
}
//---------------------------------------------------
void SetColor(int R, int G, int B)
{
	gui_out.RedVal = R;
	gui_out.GreenVal = G;
	gui_out.BlueVal = B;
}
//---------------------------------------------------
void FloodFill(int x, int y)
{
HBRUSH hbr = CreateSolidBrush(
					RGB(gui_out.RedFillVal,
						 gui_out.GreenFillVal,
						 gui_out.BlueFillVal));
HBRUSH hbrOld = HBRUSH(SelectObject(gui_out._hdc, hbr));
ExtFloodFill(gui_out._hdc, x, y,
	GetPixel(gui_out._hdc,x,y), FLOODFILLSURFACE);
SelectObject(gui_out._hdc, hbrOld);
DeleteObject(hbr);
}
//---------------------------------------------------
void SetFillColor(int R, int G, int B)
{
	gui_out.RedFillVal = R;
	gui_out.GreenFillVal = G;
	gui_out.BlueFillVal = B;
}
//---------------------------------------------------
void SetThickness(int PixelWidth)
{
	gui_out.ThickVal = PixelWidth;
}
//---------------------------------------------------
void FilledCircle(int xc,int yc,int r)
{
HPEN hpen = CreatePen(PS_INSIDEFRAME, gui_out.ThickVal,
					RGB(gui_out.RedVal, gui_out.GreenVal, gui_out.BlueVal));
HPEN hpenOld = HPEN(SelectObject(gui_out._hdc, hpen));
HBRUSH hbr = CreateSolidBrush(
					RGB(gui_out.RedFillVal,
						 gui_out.GreenFillVal,
						 gui_out.BlueFillVal));
HBRUSH hbrOld = HBRUSH(SelectObject(gui_out._hdc, hbr));
Ellipse(gui_out._hdc,xc-r, yc-r, xc+r, yc+r);
SelectObject(gui_out._hdc, hbrOld);
DeleteObject(hbr);
SelectObject(gui_out._hdc, hpenOld);
DeleteObject(hpen);
}
//---------------------------------------------------
void FilledRectangle(int x1, int y1, int x2, int y2)
{
HPEN hpen = CreatePen(PS_INSIDEFRAME, gui_out.ThickVal,
					RGB(gui_out.RedVal, gui_out.GreenVal, gui_out.BlueVal));
HPEN hpenOld = HPEN(SelectObject(gui_out._hdc, hpen));
HBRUSH hbr = CreateSolidBrush(
					RGB(gui_out.RedFillVal,
						 gui_out.GreenFillVal,
						 gui_out.BlueFillVal));
HBRUSH hbrOld = HBRUSH(SelectObject(gui_out._hdc, hbr));
Rectangle(gui_out._hdc, x1,y1,x2,y2);
SelectObject(gui_out._hdc, hbrOld);
DeleteObject(hbr);
SelectObject(gui_out._hdc, hpenOld);
DeleteObject(hpen);
}

///////////////////////////////////////////////////////////
// WinMain
///////////////////////////////////////////////////////////
//int PASCAL WinMain(HINSTANCE hCurrentInst,
int WINAPI WinMain(HINSTANCE hCurrentInst,
	 HINSTANCE hPreviousInst, LPSTR /*lpszCmdLine */,
	 int nCmdShow)
{
	 WNDCLASS wndClass;
	 HWND hWnd;
	 MSG msg;

	 // If there's no previous instance of this application,
	 // define and register the window class.
	 if (hPreviousInst == NULL)
	 {
		  wndClass.style = CS_HREDRAW | CS_VREDRAW;
		  wndClass.lpfnWndProc = WndProc;
		  wndClass.cbClsExtra = 0;
		  wndClass.cbWndExtra = 0;
		  wndClass.hInstance = hCurrentInst;
		  wndClass.hIcon = LoadIcon(NULL, IDI_APPLICATION);
		  wndClass.hCursor = LoadCursor(NULL, IDC_ARROW);
		  wndClass.hbrBackground = HBRUSH(GetStockObject(WHITE_BRUSH));
		  wndClass.lpszMenuName = NULL;
		  wndClass.lpszClassName = "MyGui";

		  RegisterClass(&wndClass);
	 }

//  The following line will open a console window also
//	 _InitEasyWin();	 cout << "Hello" << endl;

	 // Get the size of the screen.
	 UINT width = GetSystemMetrics(SM_CXSCREEN);
	 UINT height = GetSystemMetrics(SM_CYSCREEN);
	 GlobalhInstance = hCurrentInst;

	 // Create a window of the previously defined class.
	 hWnd = CreateWindow(
					"MyGui",             // Window class's name.
					GUI.Title().c_str(), // Title bar text.
					WS_OVERLAPPEDWINDOW,  // The window's style.
					0,                   // X position.
					0,                   // Y position.
					width,                // Width.
					height,               // Height.
					NULL,                 // Parent window's handle.
					NULL,                 // Menu handle.
					hCurrentInst,         // Instance handle.
					NULL);                // No additional data.

	 // Display the window on the screen.
	 ShowWindow(hWnd, nCmdShow);

	 // Force the window to repaint itself.
	 UpdateWindow(hWnd);

	 // Start the message loop.
	 while (GetMessage(&msg, NULL, NULL, NULL))
	 {
		  TranslateMessage(&msg);
		  DispatchMessage(&msg);
	 }

	 return msg.wParam;
}

///////////////////////////////////////////////////////////
// WndProc()
//
// This is the main window procedure, which is called by
// Windows.
///////////////////////////////////////////////////////////
//LRESULT FAR PASCAL _export WndProc(HWND hWnd, UINT message,
LONG PASCAL WndProc(HWND hWnd, UINT message,
	 WPARAM wParam, LPARAM lParam)
{
	 HDC hDC;
	 PAINTSTRUCT paintStruct;
//	 UINT width = GetSystemMetrics(SM_CXSCREEN);
//	 UINT height = GetSystemMetrics(SM_CYSCREEN);

	 // Handle message
	 switch(message)
	 {
		  case WM_PAINT:
				hDC = BeginPaint(hWnd, &paintStruct);
				gui_out.open(hWnd, hDC);
				GUI.GuiPaint();
				EndPaint(hWnd, &paintStruct);
				return 0;

		  case WM_LBUTTONUP:
// Following lines not needed since use default for Invalidate
//				RECT rect;
//				rect.left = 1;
//				rect.top = 1;
//				rect.right = width;
//				rect.bottom = height;
				GUI.GuiMouseClick(LOWORD(lParam),HIWORD(lParam));
//				InvalidateRect(hWnd, &rect, TRUE);
//				GUI.GuiPaint();

// The following line causes a repaint of the entire window if the
// on a mouse-click.  This causes flicker, but makes it easier for the
// client programmer.
				InvalidateRect(hWnd, NULL, TRUE);
				return 0;

/*  Dialog boxes require a resource file, which we avoid
	case WM_RBUTTONUP:
				FARPROC lpfnAboutDialogProc;
				lpfnAboutDialogProc = MakeProcInstance(
					 (FARPROC)AboutDialogProc, GlobalhInstance);
				DialogBox(GlobalhInstance, MAKEINTRESOURCE(DIALOG_1),
					 hWnd, lpfnAboutDialogProc);
				FreeProcInstance(lpfnAboutDialogProc);
				//if (x == -1)
				//	MessageBox("error creating dbox","error");
				return 0;
  */

// Timer not yet implemented
//		  case WM_TIMER:
//			  	GUI.EvTimer(wParam);
//		  		InvalidateRect(hWnd, &rect, TRUE);
//			  	return 0;

		  case WM_DESTROY:
				PostQuitMessage(0);
				return 0;
	 }

	 // Make sure all unhandled messages get returned to Windows.
	 return DefWindowProc(hWnd, message, wParam, lParam);
}

