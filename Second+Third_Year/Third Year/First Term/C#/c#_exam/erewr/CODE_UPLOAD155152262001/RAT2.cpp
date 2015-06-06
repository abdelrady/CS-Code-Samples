// Isaac & David 
// Carter's challenge
// 6-2-01
// rat in maze program

#include <iostream.h>
#include <stdlib.h>
#include <conio.h>
//#include <wait.h>
#include <time.h>	 
#include "rick.h"
#include "lvp\matrix.h"	

struct box	
{
	int number; 
	char wall;
	bool visited;
};

void drawrat(matrix <box> &maze, int &s1,int &s2)
{
	int i,j=0;
	setcolor(FOREGROUND_GREEN|FOREGROUND_INTENSITY|BACKGROUND_GREEN|BACKGROUND_RED|BACKGROUND_BLUE);
	setcursor(s2,s1);
	putc(' ',stdout);

	for(i=0;i<=21;i ++)
	{
		for(j=0;j<=79;j++)
		{
			if(maze [i][j].wall==2)
			{
				s1=i;  
				s2=j;
			}
		}
	}
	
	setcursor(s2,s1);
	putc(2,stdout);
}

void loadmatrix(matrix <box> &maze)
{
	int numbers=0;
	int i,j=0;

	setcolor(BACKGROUND_GREEN|BACKGROUND_RED|BACKGROUND_BLUE);

	for( i=0;i<=21;i++)
	{
		for(j=0;j<=79;j++)
		{
			numbers++;
			maze [i][j].number=numbers;
			maze [i][j].visited=false;
			maze [i][j].wall=' ';
		}
	}
}

void loadwall(matrix <box> &maze)
{
	int i,j=0;

	setcolor(FOREGROUND_BLUE|BACKGROUND_GREEN|BACKGROUND_RED|BACKGROUND_BLUE);
	
	for(i=0;i<=21;i++)  //starts basic four walls
	{
		maze [i][0].wall='#';
		maze [i][0].visited=true;
	}

	for(i=0;i<=21;i++)
	{
		maze [i][79].wall='#';
		maze [i][79].visited=true;
	}

	for(j=0;j<=79;j++)
	{
		maze [0][j].wall='#';
		maze [0][j].visited=true;
	}

	for(j=0;j<=75;j++)
	{
		maze [21][j].wall='#';
		maze [21][j].visited=true;
	}

	for(i=0;i<=21;i++)
	{
		maze [i][1].wall='#';
		maze [i][1].visited=true;
	}

	for(i=0;i<=21;i++)
	{
		maze [i][78].wall='#';
		maze [i][78].visited=true;
	}

	for(j=0;j<=79;j++)
	{
		maze [1][j].wall='#';
		maze [1][j].visited=true;
	}

	for(j=0;j<=75;j++)
	{
		maze [20][j].wall='#';
		maze [20][j].visited=true; //ends four walls

	}



	for(i=4;i<=17;i++)
	{
		maze [i] [10].wall='#';
		maze [i] [10].visited=true;
	}

	for(i=4;i<=17;i++)
	{
		maze [i] [20].wall='#';
		maze [i] [20].visited=true;
	}

	for(i=4;i<=17;i++)
	{
		maze [i] [30].wall='#';
		maze [i] [30].visited=true;
	}

	for(i=4;i<=17;i++)
	{
		maze [i] [40].wall='#';
		maze [i] [40].visited=true;
	}

	for(i=4;i<=17;i++)
	{
		maze [i] [50].wall='#';
		maze [i] [50].visited=true;
	}

	for(i=4;i<=17;i++)
	{
		maze [i] [60].wall='#';
		maze [i] [60].visited=true;
	}

	for(i=4;i<=17;i++)
	{
		maze [i] [70].wall='#';
		maze [i] [70].visited=true;
	}

	for(i=4;i<=17;i++)
	{
		maze [i] [9].wall='#';
		maze [i] [9].visited=true;
	}

	for(i=4;i<=17;i++)
	{
		maze [i] [19].wall='#';
		maze [i] [19].visited=true;
	}

	for(i=4;i<=17;i++)
	{
		maze [i] [29].wall='#';
		maze [i] [29].visited=true;
	}

	for(i=4;i<=17;i++)
	{
		maze [i] [39].wall='#';
		maze [i] [39].visited=true;
	}

	for(i=4;i<=17;i++)
	{
		maze [i] [49].wall='#';
		maze [i] [49].visited=true;
	}

	for(i=4;i<=17;i++)
	{
		maze [i] [59].wall='#';
		maze [i] [59].visited=true;
	}

	for(i=4;i<=17;i++)
	{
		maze [i] [69].wall='#';
		maze [i] [69].visited=true;
	}
}
void loadwall3(matrix <box> &maze)
{
		int i,j;
		for(i=0;i<=21;i++)  //starts basic four walls
	{
		maze [i][0].wall='#';
		maze [i][0].visited=true;
	}

	for(i=0;i<=21;i++)
	{
		maze [i][79].wall='#';
		maze [i][79].visited=true;
	}

	for(j=0;j<=79;j++)
	{
		maze [0][j].wall='#';
		maze [0][j].visited=true;
	}

	for(j=0;j<=75;j++)
	{
		maze [21][j].wall='#';
		maze [21][j].visited=true;
	}

	for(i=0;i<=21;i++)
	{
		maze [i][1].wall='#';
		maze [i][1].visited=true;
	}

	for(i=0;i<=21;i++)
	{
		maze [i][78].wall='#';
		maze [i][78].visited=true;
	}

	for(j=0;j<=79;j++)
	{
		maze [1][j].wall='#';
		maze [1][j].visited=true;
	}

	for(j=0;j<=75;j++)
	{
		maze [20][j].wall='#';
		maze [20][j].visited=true; //ends four walls

	}
	for(j=30;j<=50;j++)
	{
		maze [2][j].wall='#';
		maze [2][j].visited=true; 
	}
	for(j=20;j<=65;j++)
	{
		maze[5][j].wall='#';
		maze[5][j].visited=true;
	}
	for(j=10;j<75;j++)
	{
		maze[8][j].wall='#';
		maze[8][j].visited=true;
	}
	for(j=10;j<75;j++)
	{
		maze[11][j].wall='#';
		maze[11][j].visited=true;
	}
	for(j=20;j<=65;j++)
	{
		maze[15][j].wall='#';
		maze[15][j].visited=true;
	}
	for(j=30;j<=50;j++)
	{
		maze [18][j].wall='#';
		maze [18][j].visited=true; 
	}

}
void loadwall2(matrix <box> &maze)
{
	setcolor(FOREGROUND_RED|BACKGROUND_BLUE|BACKGROUND_RED|BACKGROUND_GREEN);
	int i,j;
		for(i=0;i<=21;i++)  //starts basic four walls
	{
		maze [i][0].wall='#';
		maze [i][0].visited=true;
	}

	for(i=0;i<=21;i++)
	{
		maze [i][79].wall='#';
		maze [i][79].visited=true;
	}

	for(j=0;j<=79;j++)
	{
		maze [0][j].wall='#';
		maze [0][j].visited=true;
	}

	for(j=0;j<=75;j++)
	{
		maze [21][j].wall='#';
		maze [21][j].visited=true;
	}

	for(i=0;i<=21;i++)
	{
		maze [i][1].wall='#';
		maze [i][1].visited=true;
	}

	for(i=0;i<=21;i++)
	{
		maze [i][78].wall='#';
		maze [i][78].visited=true;
	}

	for(j=0;j<=79;j++)
	{
		maze [1][j].wall='#';
		maze [1][j].visited=true;
	}

	for(j=0;j<=75;j++)
	{
		maze [20][j].wall='#';
		maze [20][j].visited=true; //ends four walls

	}
}

void draw(matrix <box> &maze)
{
	for(int i=0;i<=21;i++)
	{
		for(int j=0;j<=79;j++)
		{
			putc(maze [i][j].wall,stdout);
		}
	}
}

bool moverat(matrix <box> &maze,char move,int &s1, int &s2)
{ 
	bool pass;
	int i,j=0; 
	s1,s2=0; 

	for(i=0;i<=21;i ++)
	{
		for(j=0;j<=79;j++)
		{
			if(maze [i][j].wall==2)
			{
				s1=i; 
				s2=j;
			}
		}
	}

	maze [s1][s2].visited=true;

	if((move=='D')||(move=='d'))
	{
		if(maze[(s1+1)][s2].wall==' ')
		{
			maze[s1][s2].wall=' ';
			maze[(s1+1)][s2].wall=2;
			pass=true;
		}

		else if(maze[(s1+1)][s2].wall=='#')
		{
			pass= false;
		}
	}

	if((move=='U')||(move=='u'))
	{
		if(maze[(s1-1)][s2].wall==' ')
		{
			maze[s1][s2].wall=' ';
			maze[(s1-1)][s2].wall=2;
			pass=true;
		}

		else if(maze[(s1-1)][s2].wall=='#')
		{
			pass= false;
		}
	}

	if((move=='L')||(move=='l'))
	{
		if((s2-2)<=0)
		{
			pass=false;
		}

		else if(maze[s1][(s2-2)].wall==' ')
		{
			maze[s1][s2].wall=' ';
			maze[s1][(s2-2)].wall=2;
			pass=true;
		}

		if(((s2-2)<=0))
		{		
			pass=false;
		}

		else if(maze[s1][(s2-2)].wall=='#')
		{
			pass= false;
		}
	}

	if((move=='R')||(move=='r'))
	{
		if(s2+2>=79)
		{
			pass=false;
		}

		else if(maze [s1][(s2+2)].wall==' ')
		{
			maze[s1][s2].wall=' ';
			maze[s1][(s2+2)].wall=2;
			pass= true;
		}

		if(s2+2>=79)
		{
			pass= false;
		}

		else if(maze[s1][(s2+2)].wall=='#')
		{	
			pass= false;
		}
	}

	return(pass);
}
bool check(matrix <box> maze)


{
	if((maze[21][76].wall==2)||(maze[21][77].wall==2)||(maze[21][78].wall==2))
	{
		return(false);
	}

	else
	{
		return(true);
	}
}

void getmove(char &move, matrix <box> & maze)
{
	int mr,s1,i,j,s2=0;
	bool test;

	do{
		mr=rand()%4+1;

		switch(mr)
		{
		case 1: 
			move='U';
			break;
		case 2:
			move='D';
			break;
		case 3:
			move='L';
			break;
		case 4:
			move='R';
			break;
		}
		
		for(i=0;i<=21;i ++)
		{
			for(j=0;j<=79;j++)
			{
				if(maze [i][j].wall==2)
				{
					s1=i;
					s2=j;
				}
			}
		}

		if(move=='U')
		{
			if(maze[(s1-1)][s2].visited==true)
			{
				test=true;
			}

			else
			{
				test=false;
			}
		}

		if(move=='D')
		{
			if(maze[(s1+1)][s2].visited==true)
			{
				test=true;
			}

			else
			{
				test=false;
			}
		}

		if(move=='L')
		{
			if(maze[(s1)][s2-2].visited==true)
			{
				test=true;
			}

			else
			{
				test=false;
			}
		}

		if(move=='R')
		{
			if(maze[(s1)][s2+2].visited==true)
			{
				test=true;
			}

			else
			{
				test=false;
			}
		}

		if((maze[(s1)][s2+2].visited==true)&&(maze[(s1)][s2-2].visited==true)&&(maze[(s1+1)][s2].visited==true)&&(maze[(s1-1)][s2].visited==true))
		{
			test=false;
		}

	}while(test==true);
}

int main()
{
	srand((unsigned)time(NULL));

	bool cont=true; 
	
	bool pass;
	
	unsigned long time=0;
	
	int s1,s2=0;
	
	int lag;
	
	char move,ans,ans2;
	
	char another;
	
	matrix <box> maze(23,81); 
	
	do{
	
		system("cls");
	
		setcolor(FOREGROUND_BLUE|FOREGROUND_INTENSITY);

		cout.width(48);
	
		cout << "`~~~~~~~~~~~~~~~`" << endl;
	
		cout.width(48);
	
		cout << "| Rat in a Maze |" << endl;
	
		cout.width(48);
	
		cout << "`~~~~~~~~~~~~~~~`" << endl;
	
		cout << endl;
	
		cout << "\t\tWould you like the rat to move fast or slow (F/S)? ";
	
		cin >> ans;
	
		cout << "\t\tWhich Maze Would you like "<<endl;
		cout<< "\tV-Vertical Bars"<<endl;
		cout<< "\tH-Horzintal Bars"<<endl;
		cout<<"\t E-Empty Maze"<<endl;
	
		cin>>ans2;

	
		system("cls");
	
		if(ans=='F')
	
		{
	
			lag=0;
	
		}
	
		else
	
		{
	
			lag=100;
	
		}
	

		loadmatrix(maze);
	
		if((ans2=='V')||(ans2=='v'))
	
		{
     
			loadwall(maze);
	}
	else if((ans2=='H')||(ans=='h'))
	{
		loadwall3(maze);
	}
	if(((ans2!='V')||(ans2!='v'))&&((ans2!='H')||(ans!='h')))
	{
		loadwall2(maze);
	}
	maze [2][3].wall=2;
	
	if((ans2=='V')||(ans=='v'))
	{
		setcolor(FOREGROUND_BLUE|BACKGROUND_GREEN|BACKGROUND_BLUE|BACKGROUND_RED);
	}
	else if((ans2=='H')||(ans2=='h'))
	{
		setcolor(FOREGROUND_GREEN|BACKGROUND_GREEN|BACKGROUND_BLUE|BACKGROUND_RED);
	}
	else if((ans2=='E')||(ans2=='e'))
	{
		setcolor(FOREGROUND_RED|BACKGROUND_GREEN|BACKGROUND_BLUE|BACKGROUND_RED);
	}

	draw(maze);
	         
	do{	      
		drawrat(maze,s1,s2);

		do{
	
			getmove(move,maze);
			pass=moverat(maze,move,s1,s2);
		
		}while(pass==false);

		time++;
		cont=check(maze);

		//wait(lag);
		

	}while(cont==true);
	
	setcolor(FOREGROUND_BLUE|BACKGROUND_GREEN|BACKGROUND_RED|BACKGROUND_BLUE);
	cout << endl;
	cout << endl;
	cout << endl;
	cout << "\t\t\t" << time << " trys to get out!" << endl;
	cout << "\t\t Would You Like To See Another One?"<<endl;
	cin>>another;

	}while((another=='Y')||(another=='y'));


	return(0);
}
