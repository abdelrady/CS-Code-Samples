// this is the maze traversal problem
// Jamie Lutzuver, chapter 5 , 5.25, dietel dietel book.


#include <iostream.h>
#include <iomanip.h>			// "" 
#include <stdlib.h>				// allows use of = clrscreen();
#include <ctime>				// allows use of random number generator
#include <cstring>				// allows manipulation of strings
#include <ctype.h>				// allows isdigit islower isupper isspace iscntrl ispunct
#include <conio.h>
#include "clear.h"			// custom clear screen file

#define TAB '\t'	// define tab character


void title();
int maze(char *mazeone[12][12]);	// function to draw maze
int index=0;
int horiz=0;
int counter=0;



int main()
{
main:char again;


	char *mazeone[12][12] ={//0///1///2///3///4///5///6///7///8///9///10//11///
							 "#","#","#","#","#","#","#","#","#","#","#","#",//0
							 "#",".",".",".","#",".",".",".",".",".",".","#",//1
							 ".",".","#",".","#",".","#","#","#","#",".","#",//2
							 "#","#","#",".","#",".",".",".",".","#",".","#",//3
							 "#",".",".",".",".","#","#","#",".","#",".",".",//4
						     "#","#","#","#",".","#",".","#",".","#",".","#",//5
							 "#","#",".","#",".","#",".","#",".","#",".","#",//6
							 "#","#",".","#",".","#",".","#",".","#",".","#",//7
							 "#",".",".",".",".",".",".",".",".","#",".","#",//8
							 "#","#","#","#","#","#",".","#","#","#",".","#",//9
							 "#",".",".",".",".",".",".","#",".",".",".","#",//10
							 "#","#","#","#","#","#","#","#","#","#","#","#",};//11



//////////////////////////////////////////////////////////
// start /////////////////////////////////////////////////
//////////////////////////////////////////////////////////
			title();
							 
char *player = "X";
char movement;
int coody = 4;
int coodx = 11;
mazeone[coody][coodx] = player;
char ready;				
int never=0;

	   cout << " <make your moves through the maze> \n";
	   cout << " <can you find the exit?> \n";
	   cout << " <North> <South> <East> <West> \n\n";
		cout << "            controls :: n , s , e , w ,\n\n";

		cout << "         -->** are you ready 'y' or 'n' ? **<--  "; cin >> ready;
		if (ready == 'n'){
			goto ending;
		}


//////////////////////////////////////////////////////
////////////////////////////////////////////////MOVEMENT
		do{
			//bclrscreen();
			maze(mazeone);
starting:cin >> movement;
if (movement == 'n'){
	coody--;
	if (mazeone[coody][coodx] == "#"){
		cout << "illegal move\n";
		coody++;
		goto starting;
	} 
	mazeone[coody][coodx] = player;
	//maze(mazeone);
}
if (movement == 's'){
	coody++;
	if (mazeone[coody][coodx] == "#"){
		cout << "illegal move\n";
		coody--;
		goto starting;
	}
	mazeone[coody][coodx] = player;
	//maze(mazeone);
}
if (movement == 'e'){
	coodx++;
	if (mazeone[coody][coodx] == "#"){
		cout << "illegal move\n";
		coodx--;
		goto starting;
	}
	mazeone[coody][coodx] = player;
	//maze(mazeone);
}
if (movement == 'w'){
	coodx--;
	if (mazeone[coody][coodx] == "#"){
		cout << "illegal move\n";
		coodx++;
		goto starting;
	}
	mazeone[coody][coodx] = player;
	//maze(mazeone);
}
if (coodx == 0 && coody ==2){
	//textcolor (LIGHTRED);
	cout << "           -->***********************<--    \n";
	cout << "              *****  exit found *****       \n";
	cout << "           -->***********************<--    \n";
	goto ending;
}

		}while (never != 1 );//coodx != 0 && coody !=2
//////////////////////////////////////////MOVEMENT
		///////////////////////////////////////////

ending:cout << "\n";
cout << "thanks for playing\n";
cout << "  ** do you want to play again 'y' or 'n' **\n";
cin >> again;

		if (again == 'y'){
	goto main;
		}
		else;

return 0;
}
//////////////////////////////////////////////////////////////////////////
// draw maze /////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////
int maze(char *mazeone[12][12])
		{
index=0;
horiz=0;

			start:if (horiz==0){
			cout << TAB << TAB;
			 }

do
	{	
		cout << *mazeone[index][horiz];
		horiz++;
	}while (horiz !=12);
			
			horiz=0; // reinitialize horiz to 0

					if (index==11){
				goto finish;
				}
					else{
		cout << "\n"; index++; goto start;
					}
finish:cout << "\n\n\n\n";

return 0;

}
//////////////////////////////////////////////////////////////////////////
// title /////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////
void title()
{
//textcolor (YELLOW);
	cprintf("\r     ****** **  ** ******      **    **   ***   ****** ******\n");
	cprintf("\r     ****** **  ** ******      ***  ***  *****  ****** ******\n");
	cprintf("\r       **   **  ** **          ******** **   **     ** **\n");
	cprintf("\r       **   ****** ******      ** ** ** *******   **   ******\n");
	cprintf("\r       **   ****** **          **    ** ******* **     **    \n");
	cprintf("\r       **   **  ** ******      **    ** **   ** ****** ******\n");
	cprintf("\r       **   **  ** ******      **    ** **   ** ****** ******\n");
//textcolor (LIGHTRED);
	cout << " \n";
}