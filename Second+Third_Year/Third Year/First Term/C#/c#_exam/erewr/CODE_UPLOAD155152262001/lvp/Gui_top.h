// Lawrenceville Press  October 1997

#include <windows.h>
#include <lvp\string.h>

void FilledCircle(int xc,int yc,int r);
/* Draws a filled circle with the given center and radius */
/* Color constants that may be used in calling SetColor,
	SetTextColor, SetFillColor */
const COLORREF GRAY = RGB(128,128,128);
const COLORREF BLACK = RGB(0,0,0);
const COLORREF WHITE = RGB(255,255,255);
const COLORREF RED = RGB(255,0,0);
const COLORREF GREEN = RGB(0,255,0);
const COLORREF BLUE = RGB(0,0,255);
const COLORREF YELLOW = RGB(255,255,0);
const COLORREF ORANGE = RGB(255,128,0);
const COLORREF VIOLET = RGB(128,0,255);

void Circle(int xc,int yc,int r);
/* Draws a circle with the given center and radius */
void FilledCircle(int xc,int yc,int r);
/* Draws a filled circle with the given center and radius */
void Line(int x1, int y1, int x2, int y2);
/* Draws a line from the point x1,y1 to x2,y2 */
void Rectangle(int x1, int y1, int x2, int y2);
/* Draws a rectangle with upper left corner at x1,y1 and
	lower right corner at x2,y2 */
void FilledRectangle(int x1, int y1, int x2, int y2);
/* Draws a filled rectangle with upper left corner at x1,y1
	and lower right corner at x2,y2 */
void SetPixel(int x, int y);
/* Plots the indicated pixel using the current pen color */


void SetColor(COLORREF NewColor);
/* Sets pen to the color indicated by the R/G/B values */
void SetFillColor(COLORREF NewColor);
/* Sets filling to the color indicated by the R/G/B values */
void SetColor(int R, int G, int B);
/* Sets pen to the color indicated by the R/G/B values */
void SetFillColor(int R, int G, int B);
/* Sets filling to the color indicated by the R/G/B values */
void SetThickness(int PixelWidth);
/* Sets pen thickness to the number of pixels specified */
void FloodFill(int x, int y);
/* Fills all connected pixels of the same color as the one at
	x,y with the current fill color */


void DrawText(String S);
//void DrawTextF(String S);
void DrawText(int N);
void DrawText(long N);
void DrawText(double N);
/* Each draws its argument as text on the graphics display
	starting at the "output cursor" position. */
void DrawCenteredText(String S);
void DrawCenteredText(int N);
void DrawCenteredText(long N);
void DrawCenteredText(double N);
/* Each draws its argument as text on the graphics display
	centered at the "output cursor" position. */
void SetTextColor(COLORREF NewColor);
void SetTextSize(int NewFontSize);
void SetTextFont(String FontName);
/* Controls the output of text.  Valid font names are:
		Arial
		System
		Times New Roman
If names other than these are sent, the font is left unchanged.
Note that the "System" font cannot be changed in size */


void gotoxy(int x, int y);
/* Moves the implicit "output cursor" to the indicated
	position for subsequent text output */
int wherex();
int wherey();
/* Returns the current coordinates of the output cursor */
int GetMaxX();
int GetMaxY();
/* Returns the x and y dimensions of the entire screen */

int MessageBox(String Text, String Title);
/* Generates a message box with an OK button */
int MessageBoxYN(String Text, String Title);
/* Generates a message box with YES and NO buttons.
	Returns 1 if user hits YES button; 0 if hits NO button */

//void MessageBeep(int);  // Predefined
/*
-1	Produces a standard beep sound by using the computer speaker.
MB_ICONASTERISK	Plays the sound identified by the SystemAsterisk entry
 in the [sounds] section of WIN.INI.
MB_ICONEXCLAMATION	Plays the sound identified by the SystemExclamation entry
 in the [sounds] section of WIN.INI.
MB_ICONHAND	Plays the sound identified by the SystemHand entry
 in the [sounds] section of WIN.INI.
MB_ICONQUESTION	Plays the sound identified by the SystemQuestion entry
 in the [sounds] section of WIN.INI.
MB_OK	Plays the sound identified by the SystemDefault entry
 in the [sounds] section of WIN.INI.
*/

// PostQuitMessage(0);  // Predefined
/* Terminates program execution */

int GetPixel(int x, int y);  // Not documented in text

/* To add more functions, put prototype here, then
	put prototype as friend in MyGuiWindow, then put body
	at end of gui_bot.h                       */


