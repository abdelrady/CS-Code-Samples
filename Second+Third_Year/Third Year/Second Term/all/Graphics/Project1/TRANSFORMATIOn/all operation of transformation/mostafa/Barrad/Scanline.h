
//---------------------------------------------------------
struct edge 
{
	float x1,y1,x2,y2;
	double slope,xlast;
};
struct point 
{
	float x,y;
	point()
	{
		x=0,y=0;
	}
	point(float x1,float y1)
	{
		x=x1,y=y1;
	}
};
struct vector
{
	float v[4];
	void operator() (float a,float b,float c)
	{
		v[0]=a;
		v[1]=b;
		v[2]=c;
		v[3]=1;
	}
	vector()
	{
		v[0]=0;
		v[1]=0;
		v[2]=0;
		v[3]=1;
	}
	float& operator[](int a)
	{
		return v[a];
	}
};
//---------------------------------------------------------
const int max1=100;
void sort(edge [],int );		
void scanline(HDC hdc,point ps[],int num,vector color)
{
	ps[num]=ps[0];
	int ymin=ps[0].y,ymax=ps[0].y;
	edge E[max1];
	for(int count=0;count<num;count++)
	{
		if(ps[count].y==ps[count+1].y)
			continue;
		if(ps[count].y<ps[count+1].y)
		{
			if(ps[count+1].y>ymax)
				ymax=ps[count+1].y;
			if(ps[count].y<ymin)
				ymin=ps[count].y;
			E[count].x1=ps[count].x;
			E[count].y1=ps[count].y;
			E[count].x2=ps[count+1].x;
			E[count].y2=ps[count+1].y;
		}
		else
		{
			if(ps[count].y>ymax)
				ymax=ps[count].y;
			if(ps[count+1].y<ymin)
				ymin=ps[count+1].y;
			E[count].x1=ps[count+1].x;
			E[count].y1=ps[count+1].y;
			E[count].x2=ps[count].x;
			E[count].y2=ps[count].y;
		}
		E[count].xlast=E[count].x1;
		E[count].slope=(E[count].x2-E[count].x1)/
			(E[count].y2-E[count].y1);
	}
	edge active[max1];
	int a=0;
	for(int y=ymin;y<ymax;y++)
	{
		for(int i=0;i<=num;i++)
			if(y<=E[i].y2 && y>E[i].y1)
			{
				active[a]=E[i];
				E[i].xlast=E[i].xlast+E[i].slope;
				a++;
			}
			sort(active,a);
		for(int m=0;m<a;m+=2)
		{
			for(int vv=active[m].xlast;
			vv<active[m+1].xlast;vv++)
			{
				SetPixel(hdc,vv,y,RGB(color.v[0],color.v[1],color.v[0]));
			}
		}
		a=0;
	}
}
//---------------------------------------------------------
void sort(edge e[],int n)
{
	edge temp;
	for(int x=0;x<n-1;x++)
		for(int y=x+1;y<n;y++)
			if(e[y].xlast<=e[x].xlast)
			{
				temp=e[y];
				e[y]=e[x];
				e[x]=temp;
			}		
}
//---------------------------------------------------------