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
	int h=570,k=150;			//		ellipse center
	double x=0.0,X_end=a;		// a    major axis,,, b mainor axis
	while(x<=X_end)
	{
		double y=b*( sqrt( 1- (x*x)/(a*a)  ) );
		plot_fourPoints(x,y,h,k,color,hdc);

		x+=.001;
	}//end loop
}
/*________________________________________________________________________
				Circle Using Brthenham Algorthim
__________________________________________________________________________
__________________________________________________________________________*/
void Circle(HDC dc ,int r,bool clear )
{
	int x=0;
	int y=r;
	int h=200,k=200;//circle center
	int d=3-2*y;
	COLORREF color1=RGB(0,0,255),color2=RGB(255,0,0),
			 color3=RGB(0,255,0),color4=RGB(255,0,255);
	if(clear)
	{
		//=RGB(255,0,0),
		color1=color2=color3=color4=GetPixel(dc,20,20);
			
	}
	
	while(x<y)
	{
		SetPixel(dc,x+h,y+k,color1);
		SetPixel(dc,y+h,x+k,color2);		
		SetPixel(dc,-y+h,x+k,color3);
		SetPixel(dc,-x+h,y+k,color4);

		SetPixel(dc,-x+h,-y+k,color1);
		SetPixel(dc,-y+h,-x+k,color2);
		SetPixel(dc,y+h,-x+k,color3);
		SetPixel(dc,x+h,-y+k,color4);
		if(d<0)
		{
			d+=4*x+6;
			x++;
		}
		else
		{
			d=d+4*(x-y)+10;
			x++;
			y--;
		}
	}
}
//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
void MidPoint_ellipse(HDC hdc, int a, int b, COLORREF col)
{
	int x = 0;
	int y = b;
	int aa = a*a;
	int bb = b*b;
	int aa2= aa*2;
	int bb2= bb*2;
	int h=570,k=150;
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
