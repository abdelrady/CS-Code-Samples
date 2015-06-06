#include<math.h>

///////////////////////////////LINE ALGORITHM/////////////////////////


///////////////////////////////DIRECT LINE EQUATION AGORITHM/////////
void Direct(HDC hdc,int x1, int x2,int y1,int y2)
{
	int dx=x2-x1;
	int x,y,xend;
	int dy=y2-y1;
	int m=dy/dx;
    int b=y1 - (m*x1); 
	if(dx<0)
	{
		x=x2;
		y=y2,xend=x1;
	}
	else if(dx>=0)
	{
		x=x1;
		y=y1,xend=x2;
	}

	while(x< xend)
	{
      	SetPixel(hdc,x,y,RGB(0,0,0));
		x++;
		y=(m*x)+b;
	}
}
////////////////////////////// DDA 's Algorithm//////////////////////
void DDA(HDC hdc,int x1,int x2, int y1, int y2 , COLORREF col)
{
	float dx=x2-x1;
	float dy=y2-y1;
	float m=dy/dx;
	int x,y,xend,yend;
	if(m<=1)
	{
		x=x1;
		yend=y1;
		while(x<x2)
		{
			y=(int)(yend+0.5);
			SetPixel(hdc,x,y,col);
			x++;
			yend=yend+m;
		}
	}
	else if(m>1)
	{
		y=y1;
		xend=x1;
		while(y<y2)
		{
			x=(int)(xend+0.5);
			SetPixel(hdc,x,y,col);
			y++;
			xend=xend+(1/m);
		}
	}
}
///////////////////////Bresenham 's algorithm ///////////////////////
void BH(HDC hdc, int x1,int x2,int y1,int y2)
{
	int dx=x2-x1;
	int dy=y2-y1;
	int d=2*dy-dx;
	int x=x1,y=y1;
	SetPixel(hdc,x1,y1,RGB(250,0,0));
	while(x<x2)
	{
		x++;
		if(d<0)
		
			d=d+(2*dy);
			
		
		else
		{
				y++;
			d=d+(2*(dy-dx));
			
		}
		SetPixel(hdc,x,y,RGB(250,0,0));
	}
}


//***********************CIRCLE ALGORITHM**************************//


//////////////////////////CARTISION ALGORITHM ///////////////////////

void Cart(HDC hdc, int cx,int cy, int r,COLORREF col)
{
	int x=0;
	int xend=(r/sqrt(2));
	int y;
	SetPixel(hdc,cx,cy,col);
	while(x<xend)
	{
		y=sqrt((r*r) - (x*x));
		SetPixel(hdc,x+cx,y+cy,col);
		SetPixel(hdc,y+cy,x+cx,col);
		SetPixel(hdc,-y+cy,x+cx,col);
		SetPixel(hdc,-x+cx,y+cy,col);
		SetPixel(hdc,-x+cx,-y+cy,col);
		SetPixel(hdc,x+cx,-y+cy,col);
		SetPixel(hdc,y+cy,-x+cx,col);
		SetPixel(hdc,-y+cy,-x+cx,col);
		x++;
	}
}
/////////////////////////////TRIGONOMETIRC ALGORITHM/////////////////
void Trig(HDC hdc,int cx,int cy,int r,COLORREF col)
{
	double Theta=0;
	while(Theta<=22.0/28)
	{
		int x=(int)(r*cos(Theta));
		int y=(int)(r*sin(Theta));
		SetPixel(hdc,x+cx,y+cy,col);
		SetPixel(hdc,y+cy,x+cx,col);
		SetPixel(hdc,-y+cy,x+cx,col);
		SetPixel(hdc,-x+cx,y+cy,col);
		SetPixel(hdc,-x+cx,-y+cy,col);
		SetPixel(hdc,x+cx,-y+cy,col);
		SetPixel(hdc,y+cy,-x+cx,col);
		SetPixel(hdc,-y+cy,-x+cx,col);
        Theta=Theta+(7.0/(2*22.0*r));
	}
}
//////////////////////////MID POINT ALGORITHM/////////////////////////
void MidPoint(HDC hdc,int cx,int cy,int r,COLORREF col)
{
	int d=1-r;
	int x=0,y=r;
 	SetPixel(hdc,cx,cy,col);
	while(x<=y)
	{
	//   SetPixel(hdc,x,y,col);	
		if(d<0)
			d=d+2*x+3;
		else
		{
			d=d+2*(x-y)+5;
			y--;
		}
		x++;
		SetPixel(hdc,x+cx,y+cy,col);
		SetPixel(hdc,y+cy,x+cx,col);
		SetPixel(hdc,-y+cy,x+cx,col);
		SetPixel(hdc,-x+cx,y+cy,col);
		SetPixel(hdc,-x+cx,-y+cy,col);
		SetPixel(hdc,x+cx,-y+cy,col);
		SetPixel(hdc,y+cy,-x+cx,col);
		SetPixel(hdc,-y+cy,-x+cx,col);	
	}
}

///////////////////////////////BRESENHAM'S CIRCLE ALGORITHM//////////
void BH_CIRCLE(HDC hdc,int cx,int cy,int r,COLORREF col)
{
	int x=0,y=r,d=3-2*r;
	while(x<=y)
	{
		SetPixel(hdc,x+cx,y+cy,col);
		SetPixel(hdc,y+cy,x+cx,col);
		SetPixel(hdc,-y+cy,x+cx,col);
		SetPixel(hdc,-x+cx,y+cy,col);
		SetPixel(hdc,-x+cx,-y+cy,col);
		SetPixel(hdc,x+cx,-y+cy,col);
		SetPixel(hdc,y+cy,-x+cx,col);
		SetPixel(hdc,-y+cy,-x+cx,col);	
		if(d<0)
			d=d+4*x+6;
		else
		{
			d=d+4*(x-y)+10;
			y--;
		}
		x++;
	}
}

//************************ELLIPSE ALGORITHM*************************//
void Polynomial(HDC hdc,double a, double b,int ex,int ey,COLORREF col )
{
	double x=0,xend=a;double y;
	while(x<xend)
	{
		double y=b*( sqrt( 1- (x*x)/(a*a)  ) );
		SetPixel(hdc,x+ex,y+ey,col);
		SetPixel(hdc,-x+ex,-y+ey,col);
		SetPixel(hdc,-x+ex,y+ey,col);
		SetPixel(hdc,x+ex,-y+ey,col);
		x+=.01;
	}
}

///////////////////////////PARAMETRIC FUNCTION///////////////////////
void Parametric(HDC hdc, int a,int b,int h,int k,COLORREF col)
{
	double theta=0;
	int x,y;
	double theta_end=44/7;
	while(theta<theta_end)
	{
		x=(int)(a*cos(theta));
		y=(int)(b*sin(theta));
		SetPixel(hdc,x+h,y+k,col);
		SetPixel(hdc,-x+h,-y+k,col);
		SetPixel(hdc,-x+h,y+k,col);
		SetPixel(hdc,x+h,-y+k,col);
		theta+=0.05;
	}
}
//*******************************************************************

void plot_fourPoints(double x,double y,double h,double k,COLORREF color,HDC hdc)
{
		SetPixel(hdc, x+h , y+k,  color);
		SetPixel(hdc, -x+h, -y+k, color);
		
		SetPixel(hdc, x+h, -y+k,  color);
		SetPixel(hdc, -x+h, y+k,  color);

}
/*********************************************************************
***************    Polynomial  Algorthim          ********************/
void polynomial_ellipse( double a,double b,COLORREF color,HDC hdc )
{
	int h=200,k=150;			//		ellipse center
	double x=0.0,X_end=a;		// a    major axis,,, b mainor axis
	while(x<=X_end)
	{
		double y=b*( sqrt( 1- (x*x)/(a*a)  ) );
		plot_fourPoints(x,y,h,k,color,hdc);

		x+=.001;
	}
}
//*****************************************************************


void MidPoint_ellipse(HDC hdc, int a, int b, COLORREF col)
{
	int x = 0;
	int y = b;
	int aa = a*a;
	int bb = b*b;
	int aa2= aa*2;
	int bb2= bb*2;
	int h=452,k=150;
	int fx=0;
	int fy=aa2*b;
	
	int p = int (bb - aa*b + 0.25*aa) ;

	while(fx < fy)
		{
		plot_fourPoints(x, y , h, k,col, hdc);

				fx=fx+bb2;

				if(p<0)
					p = p + fx + bb;
				else
				{
					fy = fy - aa2;

					p = p + fx + bb - fy;
					y--;
				}
				x++;
			}

	p = int (bb*(x+0.5)*(x+0.5)+aa*(y-1)*(y-1)-aa*bb);

	while(y>=0)
			{
				SetPixel(hdc, x+h , y+k , col);

				SetPixel(hdc, -x+h , y+k , col);

				SetPixel(hdc, -x+h , -y+k , col);

				SetPixel(hdc, x+h , -y+k , col);

				fy = fy - aa2;

				if(p>=0)
					p = p - fy + aa;
				else
				{
					fx = fx + bb2;

					p = p + fx + aa - fy;
					x++;
				}
				y--;
			}
}

//*******************************************************************//


/*struct matrix
{
	double m[4][4];
	double& operator()(int i,int j)
	{
		return m[i][j];
	}
};
matrix identity()
{
	matrix mat;
	for(double i=0;i<4;i++)
		for(double j=0;j<4;j++)
			mat(i,j)=(i==j);

		return mat;
}
matrix rotation(double theta)
{
	matrix mat=identity();
	mat(0,0)=(double)cos(theta);
	mat(0,1)=-(double)sin(theta);
	mat(1,0)=-mat(0,1);
	mat(1,1)=mat(0,0);
	return mat;
}
line operator*(matrix mat,line vec)
{
	line rvec;
	for(double i=0;i<4;i++)
	{
		rvec[i]=0;
		for(double j=0;j<4;j++)
			rvec[i]+=(mat(i,j)*vec[j]);
	}
	return rvec;
}*/
