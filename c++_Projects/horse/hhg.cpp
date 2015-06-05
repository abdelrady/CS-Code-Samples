#include<iostream>
#include<cstdlib>
#include<ctime>
#include<msoftcon.h>
using namespace std;
const int cpf=5;int num=0;int xy;
const int maxhorses=11;
HANDLE hconsole;
char fill_char;
class track;
//////////////////////////////////////////////////////////////////////
class horse
{
private:
	const track* ptrtrack;
	const int horse_number;
	float finish_time;
	float distance_run;
public:
	horse(const int n,const track* ptrT):
	  horse_number(n),ptrtrack(ptrT),distance_run(0.0){}
	  ~horse()
	  {}
	  void display_horse(const float elapsed_time);
};
//////////////////////////////////////////////////////////////////////
class track
{
private:
	horse* harray[maxhorses];
	int total_horses;
	int horse_count;
	const float track_length;
	float elapsed_time;
public:
	track(float lenT,int nH);
	~track();
	void display_track();
	void run();
	float get_track_len()const;
};
//....................................................................
void horse::display_horse(float elapsed_time)
{
	set_cursor_pos(1+int(distance_run*cpf),2+horse_number*2);
	set_color(static_cast<color>(cDARK_RED +horse_number+3));
	char horse_char='0'+static_cast<char>(horse_number);
	putch(' ');putch('\xDB');putch(horse_char);putch('\xDB');
	if(distance_run<ptrtrack->get_track_len()+1.0/cpf)
	{
		if(rand()%3)
			distance_run+=0.2F;
		finish_time=elapsed_time;
	}
	else
	{
		num++;
		int mins=int(finish_time)/60;
		int secs=int(finish_time)-mins*60;
		cout<<"time="<<mins<<":"<<secs;
		if(num==1){xy=horse_number+1;}
	}
}
//....................................................................
track::track(float lenT,int nH):
				track_length(lenT),total_horses(nH),
					horse_count(0),elapsed_time(0.0)
	{
		init_graphics();
		total_horses=
			(total_horses>maxhorses)?maxhorses:total_horses;
		for(int j=0;j<total_horses;j++)
			harray[j]=new horse(horse_count++,this);
		time_t atime;
		srand(static_cast<unsigned>(time(&atime)));
		display_track();
	}
//....................................................................
track::~track()
{
	for(int j=0;j<total_horses;j++)
		delete harray[j];
}
//....................................................................
void track::display_track()
{
	clear_screen();
	for(int f=0;f<track_length;f++)
		for(int r=1;r<=total_horses*2+1;r++)
		{
			set_cursor_pos(f*cpf+5,r);
			if(f==0||f==track_length)
				cout<<'\xDE';
			else
				cout<<'\xB3';
		}
}
//....................................................................
void track::run()
{
	while(!kbhit())
	{
		elapsed_time+=1.75;
		for(int j=0;j<total_horses;j++)
		harray[j]->display_horse(elapsed_time);
		wait(500);
	}
	getch();
	cout<<endl;
}
//....................................................................
float track::get_track_len()const
{return track_length;}
//////////////////////////////////////////////////////////////////////
int main()
{
	float length;
	int total;
	cout<<"Enter track length(furlong;1 to 12):";
	cin>>length;
	cout<<"Enter number of horses(1 to 7):";
	cin>>total;
	track thetrack(length,total);
	thetrack.run();
	for(int k=0;k<=xy;k++)
	{
		wait(500);cout<<"Track "<<xy<<" is the winner.\n";
		wait(1000);clear_screen();
	}
	return 0;
}
//////////////////////////////////////////////////////////////////////
void init_graphics()
{
	COORD console_size={80,25};
	hconsole=CreateFile("CONOUT$",GENERIC_WRITE | GENERIC_READ,
		FILE_SHARE_READ | FILE_SHARE_WRITE,
		0L,OPEN_EXISTING,FILE_ATTRIBUTE_NORMAL,0L);
	SetConsoleScreenBufferSize(hconsole,console_size);
	SetConsoleTextAttribute(hconsole,(WORD)((0<<4)|15));
	fill_char='\xDB';
	clear_screen();
}
//....................................................................
void set_color(color foreground,color background)
{
	SetConsoleTextAttribute(hconsole,(WORD)((background<<4)|foreground));
}
//....................................................................
void set_cursor_pos(int x,int y)
{
	COORD cursor_pos;
	cursor_pos.X=x-1;
	cursor_pos.Y=y-1;
	SetConsoleCursorPosition(hconsole,cursor_pos);
}
//....................................................................
void clear_screen()
{
	set_cursor_pos(1,25);
	for(int j=0;j<25;j++)
		putch('\n');
	set_cursor_pos(1,1);
}
//....................................................................
void draw_circle(int xC,int yC,int radius)
{
	double theta,increment,xF,pi=3.14159;
	int x,xN,yN;
	increment=0.8/static_cast<double>(radius);
	for (theta=0;theta<=pi/2;theta+=increment)
	{
		xF=radius*cos(theta);
		xN=static_cast<int>(xF*2/1);
		yN=static_cast<int>(radius*sin(theta)+0.5);
		x=xC-xN;
		while(x<=xC+xN)
		{
			set_cursor_pos(x,  yC-yN);putch(fill_char);
			set_cursor_pos(x++,yC+yN);putch(fill_char);
		}
	}
}
//....................................................................
void set_fill_style(fstyle fs)
{
	switch(fs)
	{
	case SOLID_FILL:fill_char='\xDB';break;
	case DARK_FILL:fill_char='\xB0';break;
	case MEDIUM_FILL:fill_char='\xB1';break;
	case LIGHT_FILL:fill_char='\xB2';break;
	case X_FILL:	fill_char='x';break;
	case O_FILL:	fill_char='o';break;
	}
}
//....................................................................
void wait(int milliseconds)
{
	Sleep(milliseconds);
}
//.....................................................................
void clear_line()
{
	cputs("                                        ");
	cputs("                                        ");
}
//....................................................................
void draw_rectangle(int left,int top,int right,int bottom)
{
	char temp[80];int j;
	int width=right-left+1;
	for(j=0;j<width;j++)
		temp[j]=fill_char;
	temp[j]=0;
	for(int y=top;y<=bottom;y++)
	{
		set_cursor_pos(left,y);
		cputs(temp);
	}
}
//....................................................................
void draw_line(int x1,int y1,int x2,int y2)
{
	int w,z,t,w1,w2,z1,z2;
	double xdelta=x1=x1-x2,ydelta=y1-y2,slope;
	bool ismorehoriz;
	if(fabs(xdelta)>fabs(ydelta))
	{
		ismorehoriz=true;
		slope=ydelta/xdelta;
		w1=x1;z1=y1;w2=x2;z2=y2;
	}
	else
	{
		ismorehoriz=false;
		slope=xdelta/ydelta;
		w1=y1;z1=x1;w2=y2;z2=x2;
	}
	if(w1>w2)
	{
		t=w1;w1=w2;w2=t;
		t=z1;z1=z2;z2=t;
	}
	for(w=w1;w<=w2;w++)
	{
		z=static_cast<int>(z1+slope*(w-w1));
		if(!(w==80&&z==25))
		{
			if(ismorehoriz)
				set_cursor_pos(w,z);
			else
				set_cursor_pos(z,w);
			putch(fill_char);
		}
	}
}
//....................................................................
void draw_pyramid(int x1,int y1,int height)
{
	int x,y;
	for(y=y1;y<y1+height;y++)
	{
		int incr=y-y1;
		for(x=x1-incr;x<x1+incr;x++)
		{
			set_cursor_pos(x,y);
			putch(fill_char);
		}
	}
}
//....................................................................



