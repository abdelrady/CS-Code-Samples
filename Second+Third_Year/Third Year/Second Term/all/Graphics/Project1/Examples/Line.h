void DDA_Line(float x1, float y1, float x2, float y2, COLORREF col,HDC hdc)
{
	float xBegin  =  x1;
	float xFinal  =  x2;
	float yBegin  =  y1;
	float yFinal  =  y2;
	float slope = (y2 - y1) / (x2 - x1);
	float slopeInverse  =  1 / slope;

	if(x1>x2 && y1>y2)
	{
		xBegin  =  x2;
	    xFinal  =  x1;
		yBegin  =  y2;
	    yFinal  =  y1;
	}
	int x = int(xBegin);
	int y = int(yBegin);

	// if the line is parallel to the y coordinate
	if((xBegin - xFinal) == 0)
		if(yBegin < yFinal)	// and y starting point greater than y end
			while(y <= yFinal)
			{
				SetPixel(hdc, x, y, col);
				y ++;	// increment y
			}
		else
			while(y >= yFinal)
			{
				SetPixel(hdc, x, y, col);
				y --;	// decrement y
			}
	// if the line is parallel to the x coordinate
	else
		if((yBegin - yFinal) == 0)
			if(xBegin < xFinal) // and x starting point greater than x end
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
		if(slope >= 1 || slope <= -1) // new case
		{
			if(yFinal > yBegin) // from begin to end
				while(y <= yFinal)
				{
					x = int(xBegin + 0.5);
					xBegin = xBegin + slopeInverse;
					SetPixel(hdc, x, y, col);
					y ++;
				}
			else		// from end to begin
				while(y >= yFinal)
				{
					x = int(xBegin + 0.5);
					xBegin = xBegin - slopeInverse;
					SetPixel(hdc, x, y, col);
					y --;
				}
		}
	else
		if(slopeInverse >= 1 || slopeInverse <= -1) // new case
		{
			if(xFinal > xBegin)	// from begin to end
				while(x <= xFinal)
				{
					y = int(yBegin + 0.5);
					yBegin = yBegin + slope;
					SetPixel(hdc, x, y, col);
					x ++;
				}
			else		// from end to begin
				while(x >= xFinal)
				{
					y = int(yBegin + 0.5);
					yBegin = yBegin - slope;
					SetPixel(hdc, x, y, col);
					x --;
				}
		}//if
}
/*>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>*/									 
/*void DDA(const int x_1,const int y_1,const int x_2,const int y_2,COLORREF color ,HDC hdc)
    {
  //     int color=getcolor( );

       int x1=x_1;
       int y1=y_1;

       int x2=x_2;
       int y2=y_2;
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

	     SetPixel(hdc, x, y, color);

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

		   SetPixel(hdc, x, y, color);
		}
	  }

       else
	  {
	     int two_dx=(2*dx);
	     int two_dx_dy=(2*(dx-dy));
	     int p=((2*dx)-dy);

	     int x=x1;
	     int y=y1;

	     SetPixel(hdc, x, y, color);

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

		   SetPixel(hdc, x, y, color);
		}
	  }
    }*/
//******************************************************************
void DDA(int xs,int ys,int xe,int ye,COLORREF color,HDC hdc)
{
	int in=1;
	int x,y;
	if(ye<ys)
	{
		int temp;
		temp=xs;
		xs=xe;
		xe=temp;
		temp=ys;
		ys=ye;
		ye=temp;	
	}
	y=ys;x=xs;
	int dx=xe-x;
	int dy=ye-y;
	if(dx<0)
		in=-1;
	float d=(float)(dy-.5*dx);
	if(fabs(dy)<fabs(dx))
	{
				
				while(fabs(x-xe)>0)
				{
					SetPixel(hdc,x,y,color);
					x+=in;
					if(d<0)d+=dy;
					else{
						d+=(float)(dy-fabs(dx));
						y++;
					}
				}
	}else
	{
			while(y<=ye){
				SetPixel(hdc,x,y,color);
				++y;
				if(d<0)
				{
					d+=(float)(dy-fabs(dx));
					x+=in;
				}
				else
					d-=(float)fabs(dx);
			}
	}
}
//***********************************************************************
void Dashed_line(const float x_1,const float y_1,const float x_2,
					  const float y_2,const float line_type,COLORREF color,HDC hdc)
    {
       int count=0;
       int x1=x_1;
       int y1=y_1;

       int x2=x_2;
       int y2=y_2;

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
		 SetPixel(hdc,x,y,color);
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
			  SetPixel(hdc,x,y,color);
		   else if((count%5)!=4 && line_type==1)
		      SetPixel(hdc,x,y,color);

		   else if((count%10)!=8 && (count%10)!=9 && line_type==2)
			   SetPixel(hdc,x,y,color);

		   else if((count%20)!=18 && (count%20)!=19 && line_type==3)
		      SetPixel(hdc,x,y,color);

		   else if((count%12)!=7 && (count%12)!=8 &&
			    (count%12)!=10 && (count%12)!=11 && line_type==4)
		      SetPixel(hdc,x,y,color);

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

	     SetPixel(hdc,x,y,color);

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
		     SetPixel(hdc,x,y,color);
		   else if((count%5)!=4 && line_type==1)
		      SetPixel(hdc,x,y,color);
		   else if((count%10)!=8 && (count%10)!=9 && line_type==2)
		     SetPixel(hdc,x,y,color);

		   else if((count%20)!=18 && (count%20)!=19 && line_type==3)
		     SetPixel(hdc,x,y,color);

		   else if((count%12)!=7 && (count%12)!=8 &&
			    (count%12)!=10 && (count%12)!=11 && line_type==4)
		      SetPixel(hdc,x,y,color);

		   count++;
		}
	  }
    }