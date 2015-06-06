//RICK.H Originally written December 12, 2000
//All of these functions are for use in vc++ win32 console windows
//and are written using API calls.

//Availible Functions:

//clrscr();
//-Clears the screen

//setcolor(color);
//-Sets the default output color. Use | to combine the following constants:
//FOREGROUND_BLUE, FOREGROUND_GREEN, FOREGROUND_RED, FOREGROUND_INTENSITY,
//BACKGROUND_BLUE, BACKGROUND_GREEN, BACKGROUND_RED, BACKGROUND_INTENSITY
//Example:
//setcolor(FOREGROUND_BLUE|BACKGROUND_RED);
//Note: the colors combine. All 3 is grey, none is black.

//cputsxy(const char *input_string, int x, int y, WORD textcolor);
//-Places a string of text onto the screen, at location x,y, in color textcolor
//(Does not move the current location of the cursor)
//Uses the same color system as setcolor(color);

//setcursor(int x, int y);
//Moves the cursor to a specified location

//Written by Rick Mansfield (gwreddragon@hotmail.com)

#ifndef WINDOWS_H
	#include <windows.h>
#endif

#ifndef STDIO_H
	#include <stdio.h>
#endif

#ifndef STDLIB_H
	#include <stdlib.h>
#endif

#ifndef RICK_H

#define RICK_H

/* Standard error macro for reporting API errors */ 
#define PERR(bSuccess, api){if(!(bSuccess)) printf("%s:Error %d from %s on line %d\n", __FILE__, GetLastError(), api, __LINE__);}

void cls( HANDLE hConsole )
{
    COORD coordScreen = { 0, 0 };    /* here's where we'll home the
                                        cursor */ 
    BOOL bSuccess;
    DWORD cCharsWritten;
    CONSOLE_SCREEN_BUFFER_INFO csbi; /* to get buffer info */ 
    DWORD dwConSize;                 /* number of character cells in
                                        the current buffer */ 

    /* get the number of character cells in the current buffer */ 

    bSuccess = GetConsoleScreenBufferInfo( hConsole, &csbi );
    PERR( bSuccess, "GetConsoleScreenBufferInfo" );
    dwConSize = csbi.dwSize.X * csbi.dwSize.Y;

    /* fill the entire screen with blanks */ 

    bSuccess = FillConsoleOutputCharacter( hConsole, (TCHAR) ' ',
       dwConSize, coordScreen, &cCharsWritten );
    PERR( bSuccess, "FillConsoleOutputCharacter" );

    /* get the current text attribute */ 

    bSuccess = GetConsoleScreenBufferInfo( hConsole, &csbi );
    PERR( bSuccess, "ConsoleScreenBufferInfo" );

    /* now set the buffer's attributes accordingly */ 

    bSuccess = FillConsoleOutputAttribute( hConsole, csbi.wAttributes,
       dwConSize, coordScreen, &cCharsWritten );
    PERR( bSuccess, "FillConsoleOutputAttribute" );

    /* put the cursor at (0, 0) */ 

	bSuccess = SetConsoleCursorPosition( hConsole, coordScreen );
	PERR( bSuccess, "SetConsoleCursorPosition" );
	return;
}

//Clears the screen
void clrscr()
{
	cls(GetStdHandle(STD_OUTPUT_HANDLE));
	return;
}

//Sets the next N characters' foreground and background colors
void setcolor(WORD color)
{
	BOOL b=SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE),color);
	PERR( b, "SetConsoleTextAttribute" );
	return;
}

void cputsxy(const char *inputstr, int x, int y, WORD color)
{
	LPDWORD res=NULL;
	COORD mycoord;
	mycoord.X=x;
	mycoord.Y=y;
	PCONSOLE_SCREEN_BUFFER_INFO sbi;
	sbi=NULL;
	WORD *pcolor;
	pcolor=(WORD*)malloc(sizeof(WORD)*(strlen(inputstr)));
	for (unsigned int i=0;i<=(strlen(inputstr)-1);i++) pcolor[i]=color;
	//Get the old console color
	//GetConsoleScreenBufferInfo(GetStdHandle(STD_OUTPUT_HANDLE),sbi);
	//oldcolor=sbi->wAttributes;
	//Set the new color
	WriteConsoleOutputAttribute(GetStdHandle(STD_OUTPUT_HANDLE),pcolor,strlen(inputstr),mycoord,res);
	//Write the string
	WriteConsoleOutputCharacter(GetStdHandle(STD_OUTPUT_HANDLE),inputstr,strlen(inputstr),mycoord,res);
	//Reset the old color
	//SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE),sbi->wAttributes);
	free(pcolor);
}

void clrln(int y)
{
	LPDWORD res=NULL;
	COORD mycoord;
	mycoord.X=0;
	mycoord.Y=y;
	_CONSOLE_SCREEN_BUFFER_INFO sbi;
	WORD *pcolor;
	char *inputstr;
	int i;
	GetConsoleScreenBufferInfo( GetStdHandle(STD_OUTPUT_HANDLE), &sbi );
	pcolor=(WORD*)malloc(sizeof(WORD)*(sbi.dwSize.X));
	inputstr=(char*)malloc(sizeof(char)*(sbi.dwSize.X));
	for (i=0;i<=(sbi.dwSize.X-1);i++) pcolor[i]=0;
	for (i=0;i<=(sbi.dwSize.X-1);i++) inputstr[i]=' ';
	WriteConsoleOutputAttribute(GetStdHandle(STD_OUTPUT_HANDLE),pcolor,sbi.dwSize.X,mycoord,res);
	WriteConsoleOutputCharacter(GetStdHandle(STD_OUTPUT_HANDLE),inputstr,sbi.dwSize.X,mycoord,res);
	free(pcolor);
	free(inputstr);
}

void setcursor(int x, int y)
{
	COORD mycoord;
	mycoord.X=x;
	mycoord.Y=y;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),mycoord);
}


#endif
