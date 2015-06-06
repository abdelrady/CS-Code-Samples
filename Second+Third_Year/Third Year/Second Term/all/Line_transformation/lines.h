#include<windows.h>
#include <conio.h>
#include <stdlib.h>
#include<stdio.h>
#include<string.h>
#include <time.h>



void equation_Line(HDC hdc,int x1,int y1,int x2,int y2,COLORREF color)
{
	int dx=x2-x1,dy=y2-y1,incX,incY;
	incX=(dx<0)?-1:1;
	incY=(dy<0)?-1:1;
	SetPixel(hdc,x1,y1,color);
	if(abs(dx)>abs(dy))
	{
		double b=y1-x1*dy/dx;
		while(x1!=x2)
		{
			x1+=incX;
			y1=(int)(x1*dy/dx+b);
			SetPixel(hdc,x1,y1,color);
		}
	}
	else if (abs(dy)>=abs(dx) && dy )
	{
		double b=x1-y1*dx/dy;
		while(y1!=y2)
		{
			y1+=incY;
			x1=(int)(y1*dx/dy+b);
			SetPixel(hdc,x1,y1,color);
		}
	}
}
 int i=0;
//////////////////////////////////////////////////////////////////////////
void DDA_Line(HDC hdc,int x1,int y1,int x2,int y2,COLORREF color)
{
	int dx=x2-x1,dy=y2-y1,i=0;
	float m,y=(float)y1,x=(float)x1;
	SetPixel(hdc,x1,y1,color);
	if(abs(dx)>abs(dy))
	{
		m=(float)dy/dx;
		dx=(dx>0)?1:-1;
		m*=dx;
		for(i=x1;i!=x2;i+=dx)
		{
			y+=m;
			SetPixel(hdc,i,(int)y,color);
		}
	}
	else 
	{
		m=(float)dx/dy;
		dy=(dy>0)?1:-1;
		m*=dy;
		for(i=y1;i!=y2;i+=dy)
		{
			x+=m;
			SetPixel(hdc,(int)x,i,color);
		}
	}
	
}

//////////////////////////////////////////////////////////////////////
void BHA_ALGORITHM_Line(HDC hdc, int xPoint1, int yPoint1, int xPoint2, int yPoint2, COLORREF col)
{
	int x = xPoint1;
	int y = yPoint1;
	int xBegin = xPoint1;
	int yBegin = yPoint1;
	int yFinal = yPoint2;
	int xFinal = xPoint2;
	
	// exchange the start and the end points according to values of x
	if(xBegin > xFinal)
	{
		x = xPoint2;
		y = yPoint2;
		xBegin = xPoint2;
		yBegin = yPoint2;
		yFinal = yPoint1;
		xFinal = xPoint1;
	}
	
	int dx = xFinal - xBegin;	//calculate dx
	int dy = yFinal - yBegin;	//calculate dy
	int inc1 = 2 * dy;		//calculate inc1
	int inc2 = 2 * (dy - dx);	//calculate inc2
	int d = inc1 - dx;		//calculate d1

	float slope;
	if(dx != 0)
		slope = float(dy / dx);

	SetPixel(hdc, x, y, col);
	if(dx == 0)	// start and final points of x refelected
		if(yBegin < yFinal)
			while(y <= yFinal)
			{
				SetPixel(hdc, x, y, col);
				y ++;
			}
			else
				while(y >= yFinal)
				{
					SetPixel(hdc, x, y, col);
					y --;
				}
	else
		if(dy == 0) // start and final points of y refelected
		if(xBegin < xFinal)
			while(x <= xFinal)
			{
				SetPixel(hdc, x, y, col);
				x ++;
			}
			else
				while(x >= xFinal)
				{
					SetPixel(hdc, x, y, col);
					x --;
				}
   else	
	   if(dy > 0 && slope <= 1)	//between (0 and 1)
		   while(x < xFinal)
		   {
			   x ++;
			   if(d < 0)
				   d = d + inc1;
			   else
			   {
				   d = d + inc2;
				   y ++;
			   }
			   SetPixel(hdc, x, y, col);
		   }
	else
	   if(dy < 0 && slope >= -1) //between (-1 and 0)
	   {
		   inc2 = 2 * (dy + dx);
		   inc1 = 2 * dy;
	       d = inc1 + dx;

		   while(x < xFinal)
		   {
			   x ++;
			   if(d > 0)
				   d = d + inc1;
			   else
			   {
				   d = d + inc2;
				   y --;
			   }
			   SetPixel(hdc, x, y, col);
		   }
	   }

	else
		if(slope < -1)	// slope less than -1
		{
			inc1 = -2 * dx;
			inc2 = -2 * (dy + dx);
		    d = inc1 - dy;

			while(y > yFinal)
			{
				y --;
				if(d < 0)
					d = d - inc1;
				else
				{
					d = d - inc2;
					x ++;
				}
				SetPixel(hdc, x, y, col);
			}
		}

	else
		if(slope > 1)	// slope greater than 1
		{
		   inc1 = 2 * dx;
		   inc2 = 2 * (dx - dy);
	       d = inc1 - dy;
		   while(y < yFinal)
		   {
			   y ++;
			   if(d < 0)
				   d = d + inc1;
			   else
			   {
				   d = d + inc2;
				   x ++;
			   }//else
			   SetPixel(hdc, x, y, col);
		   }//while
	   }//else
}
/*******************************************************************/
////////////////////////// DDA Algorithm ////////////////////////////
/*******************************************************************/
void Dashed_line(const float x_1,const float y_1,const float x_2,
					  const float y_2,const float line_type,HDC hdc)
    {
       int count=0;
 	   int color=RGB(255,0,0);	
       int x1=(int)x_1;
       int y1=(int)y_1;

       int x2=(int)x_2;
       int y2=(int)y_2;

       if(x_1>x_2)
	  {
	     x1=x_2;
	     y1=y_2;

	     x2=x_1;
	     y2=y_1;
	  }

       int dx=abs(x2-x1);
       int dy=abs(y2-y1);
       int inc_dec=((y2>=y1)?1:-1);

       if(dx>dy)
	  {
	     int two_dy=(2*dy);
	     int two_dy_dx=(2*(dy-dx));
	     int p=((2*dy)-dx);

	     int x=x1;
	     int y=y1;
		 SetPixel(hdc,x,y,RGB(255,0,0));
	    while(x<x2)
		{
		   x++;

		   if(p<0)
		      p+=two_dy;

		   else
		      {
			 y+=inc_dec;
			 p+=two_dy_dx;
		      }

		   if((count%2)!=0 && line_type==0)
			  SetPixel(hdc,x,y,RGB(255,0,0));
		   else if((count%5)!=4 && line_type==1)
		      SetPixel(hdc,x,y,RGB(255,0,0));

		   else if((count%10)!=8 && (count%10)!=9 && line_type==2)
			   SetPixel(hdc,x,y,RGB(255,0,0));

		   else if((count%20)!=18 && (count%20)!=19 && line_type==3)
		      SetPixel(hdc,x,y,RGB(255,0,0));

		   else if((count%12)!=7 && (count%12)!=8 &&
			    (count%12)!=10 && (count%12)!=11 && line_type==4)
		      SetPixel(hdc,x,y,RGB(255,0,0));

		   count++;
		}
	  }

       else
	  {
	     int two_dx=(2*dx);
	     int two_dx_dy=(2*(dx-dy));
	     int p=((2*dx)-dy);

	     int x=x1;
	     int y=y1;

	     SetPixel(hdc,x,y,RGB(255,0,0));

	     while(y!=y2)
		{
		   y+=inc_dec;

		   if(p<0)
		      p+=two_dx;

		   else
		      {
			 x++;
			 p+=two_dx_dy;
		      }

		   if((count%2)!=0 && line_type==0)
		     SetPixel(hdc,x,y,RGB(255,0,0));
		   else if((count%5)!=4 && line_type==1)
		      SetPixel(hdc,x,y,RGB(255,0,0));
		   else if((count%10)!=8 && (count%10)!=9 && line_type==2)
		     SetPixel(hdc,x,y,RGB(255,0,0));

		   else if((count%20)!=18 && (count%20)!=19 && line_type==3)
		     SetPixel(hdc,x,y,RGB(255,0,0));

		   else if((count%12)!=7 && (count%12)!=8 &&
			    (count%12)!=10 && (count%12)!=11 && line_type==4)
		      SetPixel(hdc,x,y,RGB(255,0,0));

		   count++;
		}
	  }
    }
//////////////////////////////////////////////////////////////////////
