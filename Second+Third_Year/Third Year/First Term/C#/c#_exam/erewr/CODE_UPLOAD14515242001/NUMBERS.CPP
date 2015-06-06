#include<time.h>
#define BORDER 5
#include<iostream.h>
#include<conio.h>
//#include<graphics.h>
#include<stdlib.h>
//#include<bios.h>
#define BLOCK 40
#define X 200
#define Y 100
class Picture;
const char number[15][3] = {"3","1","6","2","5","7","15","13","4","11","8","9","14","10","12"};
class Picture{
private:
char *buff;
unsigned int size;
public:
	Picture();
	~Picture();
	friend class Board;
	void draw_picture();
	void put_picture(int,int);
};
Picture Pic;
Picture::Picture()
{
}
Picture::~Picture()
{
//delete [] buff;
size=0;
}
void Picture::put_picture(int a,int b)
{
 putimage(a,b,buff,2);
}
class Board{
int extra_x,extra_y;
Picture extra;
int bx,by;
public:
	Board();
	~Board();
	void move(int);
	void draw_board();
};
Board::Board()
{
 bx= X;
 by= Y;
cleardevice();
}
Board::~Board()
{
 bx=0;
 by=0;
}

void Board::move(int dir)
{
int a=extra_x;
int b=extra_y;
switch(dir)
{
 case 2:
	 if(a == X)
	    return;
	 a=extra_x - BLOCK;
	break;
 case 4:
	  if(a == X+3*BLOCK)
	     return;
	  a=extra_x + BLOCK;
	break;
 case 1:
	  if(b == Y+3*BLOCK)
	     return;
	  b=extra_y + BLOCK;
	  break;
 case 3:
	  if(b == Y)
	      return;
	  b=extra_y - BLOCK;
	  break;
 default : break;

}
extra.size = imagesize(a,b,a+BLOCK,b+BLOCK);
extra.buff = new char[extra.size];
getimage(a,b,a+BLOCK,b+BLOCK,extra.buff);
putimage(a,b,extra.buff,1);
putimage(extra_x,extra_y,extra.buff,0);
extra_x = a;
extra_y = b;
delete extra.buff;
return;
}

void start_play();
void main()
{
time_t begin,end;
begin = time(NULL);
	int gdriver=VGA,gmode=VGAHI;
//	registerbgidriver(EGAVGA_driver);
//	registerbgifont(small_font);
//	registerbgifont(triplex_font);
	initgraph(&gdriver,&gmode,"e:\\tcc");
settextstyle(TRIPLEX_FONT,0,2);
start_play();
getch();
end = time(NULL);
closegraph();
cout<<"\nThe Time Taken  =  "<<difftime(end,begin)<<" secs";
//getch();
}

void start_play(void)
{
Board b1;
 b1.draw_board();
 while(1)
  {
   switch(bioskey(0))
    {
//up
case 0x4800 : b1.move(1);
		       break;
//right
case 0x4d00 : b1.move(2);
		       break;
//down
case 0x5000 : b1.move(3);
		       break;
//left
case 0x4b00 : b1.move(4);
		       break;
case 0x1071 : return;
case 0x11b  : return;
    }
  }
}

void Picture::draw_picture(void)
{
setcolor(BORDER);
 rectangle(2,2,BLOCK-2,BLOCK-2);
 rectangle(4,4,BLOCK-4,BLOCK-4);
setfillstyle(CLOSE_DOT_FILL,LIGHTBLUE);
 floodfill(3,3,BORDER);
 setfillstyle(SOLID_FILL,4);
 floodfill(5,5,BORDER);
 size = imagesize(0,0,BLOCK,BLOCK);
 buff = new char[size];
 getimage(0,0,BLOCK,BLOCK,buff);
cleardevice();
}

void Board::draw_board(void)
{
 bx=X;
 by=Y;
int a=bx,b=by;
setcolor(8);
Pic.draw_picture();
rectangle(bx-2,by-2,bx+4*BLOCK+2,by+4*BLOCK+2);
/*for(int i=0;i<3;i++)
    {
     line(bx,b+BLOCK,bx+4*BLOCK,b+BLOCK);
      b+=BLOCK;
    }
for(i=0;i<3;i++)
    {
     line(a+BLOCK,by,a+BLOCK,by+4*BLOCK);
     a+=BLOCK;
    }*/
/*displaying the numbers*/
setcolor(14);
int ex;
a=bx,b=by;
for(int i=0;i<15;i++)
 {
  Pic.put_picture(a,b);
  if(atoi(number[i])<10) ex = 15;
  else ex=7;
  outtextxy(a+ex,b+5,number[i]);
  a=a+BLOCK;
  if(a==bx+4*BLOCK)
    {
      a=bx;
      b+=BLOCK;
    }
 }
//must change later//
extra_x =bx+3*BLOCK;
extra_y =by+3*BLOCK;
}

