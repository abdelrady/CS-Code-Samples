struct point
{
	int x;
	int y;
};
void SetPixel2(HDC hdc,int x,int y,COLORREF color)
{
	COLORREF color1=GetPixel(hdc,x,y);
	SetPixel(hdc,x,y,color^color1);
}

void DDALine(HDC hdc,point p1,point p2,COLORREF color)
{
	float m,y=(float)p1.y,x=(float)p1.x;
	int dx=p2.x-p1.x;
	int dy=p2.y-p1.y;
	int i=0;
	SetPixel2(hdc,p1.x,p1.y,color);
	if(abs(dx)>abs(dy))
	{
		m=(float)dy/dx;
		dx=(dx>=0)?1:-1;
		m*=dx;
		for(i=p1.x;i!=p2.x;i+=dx)
		{
			y=y+m;
			SetPixel2(hdc,i,(int)y,color);
		}
	}
	else
	{
		m=(float)dx/dy;
		dy=(dy>=0)?1:-1;
		m*=dy;
		for(i=p1.y;i!=p2.y;i+=dy)
		{
			x=x+m;
			SetPixel2(hdc,(int)x,i,color);
		}
}
}

//*************************************************************
//*************** Circle*********************
void circle(HDC hdc,int xCenter,int yCenter,int radius,COLORREF Color)
{
	int x=0;
	int y=radius;
	int p=1-radius;
	void circlePlotPoints(HDC,int,int,int,int,COLORREF );
	circlePlotPoints(hdc,xCenter,yCenter,x,y,Color);
	while(x<y)
	{
		x++;
		if(p<0)
			p+=2*x+1;
		else
		{
			y--;
			p+=2*(x-y)+1;
		}
		circlePlotPoints(hdc,xCenter,yCenter,x,y,Color);
	}

}

void circlePlotPoints(HDC hdc,int xCenter,int yCenter,int x,int y,COLORREF Color)
{		
		SetPixel2(hdc,xCenter+x,yCenter+y,Color);
		SetPixel2(hdc,xCenter-x,yCenter+y,Color);
		SetPixel2(hdc,xCenter+x,yCenter-y,Color);
		SetPixel2(hdc,xCenter-x,yCenter-y,Color);		
		SetPixel2(hdc,xCenter+y,yCenter+x,Color);
		SetPixel2(hdc,xCenter-y,yCenter+x,Color);
		SetPixel2(hdc,xCenter+y,yCenter-x,Color);
		SetPixel2(hdc,xCenter-y,yCenter-x,Color);
			
}

