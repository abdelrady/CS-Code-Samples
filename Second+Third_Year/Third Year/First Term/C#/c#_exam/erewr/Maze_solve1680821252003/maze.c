#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define SIZE 10

typedef enum{FALSE,TRUE}boolean;
int FillMaze(int [SIZE][SIZE]);
boolean SolveMaze(int [SIZE][SIZE],int,int);
void printmatrix(int  [SIZE][SIZE],int);

int main()
{
	int Maze[SIZE][SIZE]={0},result;
	result = FillMaze(Maze);
	if(result==-1)
	{
		puts("Could not fill maze");
		return 0;
	}
	printf("Processing possibilites..... please wait! ");
	if(SolveMaze(Maze,0,0))
	{
		printf("done.\n");
		printmatrix(Maze,10);
	}
	else
	{
		printf("done.\n");
		puts("No solution is found");
	}
	return 0;
}

boolean SolveMaze(int Maze[SIZE][SIZE],int x,int y)
{
	
	/*If the cursor is at position [9][9], then a solution is found			*/
	if(x==9 && y==9)
		return TRUE;
	/*If there is a wall or the path has been visited, then no solution		*/
	if(Maze[x][y]!=0)
		return FALSE;
	/*Else mark the current square											*/
	Maze[x][y]='#';
	/*Try all the directions from the current marked square					*/
	if((x+1)<=9 && Maze[x+1][y]==0)
		if(SolveMaze(Maze,x+1,y))
			return TRUE;
	if((y+1)<=9 && Maze[x][y+1]==0)
		if(SolveMaze(Maze,x,y+1))
			return TRUE;
	if((x-1)>=0 && Maze[x-1][y]==0)
		if(SolveMaze(Maze,x-1,y))
			return TRUE;
	if((y-1)>=0 && Maze[x][y-1]==0)
		if(SolveMaze(Maze,x,y-1))
			return TRUE;
	/*Unmark the square, and return false to indicate that none of the 
	   directions led to a solution											*/
	Maze[x][y]=0;
	return FALSE;
		
}
			
int FillMaze(int Maze[SIZE][SIZE])
{
	FILE *fname;
	int x,y;
	char *endptr=NULL,*startptr=NULL,line[16];
	fname = fopen("data.txt","r");
	if(!fname)
	{
		puts("Could not open file");
		return -1;
	}
	while(fgets(line,sizeof line,fname))
	{
	x = strtol(line,&endptr,10);
	startptr = endptr;
	y = strtol(startptr,&endptr,10);
	Maze[x][y]=1;
	}
	return 0;		
}

void printmatrix(int matrix[SIZE][SIZE],int size)
{
	int i,n,m;
    printf("%c",201);
    for(i=1;i<=size;i++)
	{
        printf("%c%c%c%c%c",205,205,205,205,205);
        if(i==size)
            printf("%c\n",187);
        else
            printf("%c",203);
	}
    for(n=0;n<size;n++)
	{
        if(n==size-1)
		{
            for(m=0;m<size;m++)
                if(m==0)
                    if(matrix[n][m]>1)
						printf("%c%5c",186,matrix[n][m]);
					else
                    printf("%c%5d",186,matrix[n][m]);
				else
                    if(matrix[n][m]>1)
						printf("%c%5c",186,matrix[n][m]);
					else
                    printf("%c%5d",186,matrix[n][m]);
                printf("%c\n",186);
                printf("%c",200);
                for(i=1;i<size;i++)
                    printf("%c%c%c%c%c%c",205,205,205,205,205,202);
                printf("%c%c%c%c%c%c\n",205,205,205,205,205,188);
		}
		else
            {
                for(m=0;m<size;m++)
                    if(m==0)
                        if(matrix[n][m]>1)
						printf("%c%5c",186,matrix[n][m]);
					else
                    printf("%c%5d",186,matrix[n][m]);
					else
                        if(matrix[n][m]>1)
						printf("%c%5c",186,matrix[n][m]);
					else
                    printf("%c%5d",186,matrix[n][m]);
                    printf("%c\n",186);
                    printf("%c",204);
                    for(i=1;i<size;i++)
                        printf("%c%c%c%c%c%c",205,205,205,205,205,206);
                    printf("%c%c%c%c%c%c\n",205,205,205,205,205,185);
			}
	}
}