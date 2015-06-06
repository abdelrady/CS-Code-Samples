//main.cpp
//-------------
//////////////
//--------------
#include<windows.h>
#include<string.h>
#include<stdio.h>
#include"math.h"
#include<iostream.h>
class Point
{
protected:
	double x;
	double y;
public:
	// equal = overloaded
	void operator = (Point);

	//put value to the point
	void put(double, double);

	//get value from the point
	void get(double&, double&);
	
	//Draw point
	void draw(HDC, COLORREF);

	//Rotate point
	void rotate(Point, double);

	// TRANSLATE point
	void translate(double, double);

	// SCALE point
	void scale(double, double);

	//Reflect point
	void reflect(char);

	//swap two points
	void swap(Point);

	//compare two points
	int compar(Point);
};
class Line : public Point
{
private:
	//Draw line with DDA algorithm
	void Line_DDA(HDC, COLORREF);
	
//Draw line with Brenes Han's algorithm
void BHA(HDC hdc,COLORREF);

public:
	Point pBegin;
	Point pEnd;
	
	double dy;
	double dx;
	double M;
	
	//Draw line
	void draw(HDC, COLORREF);
	
	//Rotate line
	void rotate(Point, double);

	// TRANSLATE line  
	void translate(double, double);

	// SCALE line 
	void scale(double, double);

	//Clipe line
	void clipe(HDC, Point, Point, COLORREF);

	//Clipe line
    void clipe(HDC, Point[], int, COLORREF);

	//Reflect line
	void reflect(char);
};

class Viewer
{
public:
	Point pMin;
	Point pMax;

	Point temp;

	Line l;
	double xMin, yMin, xMax, yMax;

	void Draw(HDC, COLORREF);

	void Draw(HDC, Point[], int, COLORREF);
};
class Circle
{
private:
	//function to drow circle with BresenHam's method
	void BHA(HDC, COLORREF);

	//draw symetric points
	void drawSymetricPoints(Point, HDC, COLORREF);
protected:
	Point center;
	double radius;
public:
	//function to put center
	void putCenter(double, double);

	//function to get center
	void getCenter(double&, double&);

	//function to put radius
	void putRadius(double);

	//function to put radius
	void getRadius(double&);

	//function to drow circle
	void draw(HDC, COLORREF);
};



//#include"viewing.h"

LRESULT CALLBACK WndProc(HWND , UINT , WPARAM ,LPARAM);
static char gszClassName[] = "MyWindowClass";
static HINSTANCE ghInstance = NULL;
int WINAPI WinMain(HINSTANCE hInstance , HINSTANCE hprevInstance , LPSTR lpCmdLine ,int nCmdShow)
{
	WNDCLASSEX WndClass;
	HWND hwnd;
	MSG Msg;
	ghInstance = hInstance ;
	WndClass.cbSize = sizeof(WNDCLASSEX);
	WndClass.style = NULL;
	WndClass.lpfnWndProc = WndProc ;
	WndClass.cbClsExtra =0;
	WndClass.cbWndExtra = 0;
	WndClass.hInstance =ghInstance ;
	WndClass.hIcon = LoadIcon(NULL,IDI_APPLICATION);
	WndClass.hCursor =LoadCursor(NULL ,IDC_ARROW);
    WndClass.hbrBackground = (HBRUSH)(COLOR_WINDOW+1);
    WndClass.lpszMenuName = NULL ;
	WndClass.lpszClassName = gszClassName ;
	WndClass.hIconSm = LoadIcon(NULL , IDI_APPLICATION);
	if(!RegisterClassEx(&WndClass))
	{
		MessageBox(0, "window registeration failed!!","error",MB_ICONSTOP|MB_OK);
		return 0;
	}

	hwnd =CreateWindowEx(WS_EX_STATICEDGE , gszClassName ," Window Title",WS_OVERLAPPEDWINDOW ,
		CW_USEDEFAULT ,CW_USEDEFAULT,600,600,NULL,NULL,ghInstance,NULL);
	if(hwnd == NULL)
	{
		MessageBox(0,"windows greated failed!!","Error" ,MB_ICONSTOP|MB_OK);
         return 0;
	}
	ShowWindow(hwnd,nCmdShow);
	UpdateWindow(hwnd);
	while(GetMessage(&Msg ,NULL ,0,0))
	{
		TranslateMessage(&Msg);
		DispatchMessage(&Msg);
	}
	return Msg.wParam;
}

int i, num;
const MAX = 20;
double xB,yB ,xE,yE;
Point vMax, vMin;
bool  draw = false;
Point polygonPoint[MAX];

LRESULT CALLBACK WndProc(HWND hwnd ,UINT Message ,WPARAM wparam ,LPARAM
						 lparam)
{
	Viewer v;
	Line l;

	COLORREF col1=RGB(255,0,0);
	COLORREF col2=RGB(0,0,255);
	COLORREF col3=RGB(0,255,0);
	HDC hdc;

	polygonPoint[0].put(0, 100);
	polygonPoint[1].put(0, 200);
	polygonPoint[2].put(100, 300);
	polygonPoint[3].put(200, 300);
	polygonPoint[4].put(300, 200);
	polygonPoint[5].put(300, 100);
	polygonPoint[6].put(200, 0);
	polygonPoint[7].put(100, 0);

	num= 8;

	switch(Message)
	{
	case WM_CLOSE :
		DestroyWindow(hwnd);
		break ;
	case WM_DESTROY:
		PostQuitMessage(0);
		break ;

	case WM_LBUTTONDOWN:
		hdc=GetDC(hwnd);
		draw = true;
		yB=HIWORD(lparam);
		xB=LOWORD(lparam);

		v.Draw(hdc, polygonPoint, num, col1);
		break;

	case WM_MOUSEMOVE:
		hdc=GetDC(hwnd);
		yE=HIWORD(lparam);
		xE=LOWORD(lparam);

		l.pBegin.put(xB, yB);
		l.pEnd.put(xE, yE);
		if(draw)
		l.clipe(hdc, polygonPoint, num, RGB(xE+xB, xE+yB, xE+yE));
		break;

	case WM_LBUTTONUP:
		hdc=GetDC(hwnd);
		draw = false;
		yE=HIWORD(lparam);
		xE=LOWORD(lparam);
		l.clipe(hdc, polygonPoint, num, RGB(xE+xB, xE+yB, xE+yE));
	default:
		return DefWindowProc(hwnd,Message,wparam,lparam);
	}
	return 0;
}

//#include"circle.h"
//function to put center
void Circle::putCenter(double h, double k)
{
	center.put(h, k);
}

//function to get center
void Circle::getCenter(double& h, double& k)
{
	center.get(h ,k);
}

//function to put radius
void Circle::putRadius(double r)
{ radius = r; }

//function to put radius
void Circle::getRadius(double& r)
{ r = radius; }

//draw symetric points
void Circle::drawSymetricPoints(Point pixel, HDC hdc, COLORREF col)
{
	double xInner, yInner, h, k;

	center.get(h, k);

	pixel.get(xInner, yInner);

	pixel.put(xInner+h, yInner+k);
	pixel.draw(hdc, col);
	
	pixel.put(yInner+h, xInner+k);
	pixel.draw(hdc, col);
	
	pixel.put(-yInner+h, xInner+k);
	pixel.draw(hdc, col);
	
	pixel.put(-xInner+h, yInner+k);
	pixel.draw(hdc, col);

	pixel.put(-xInner+h, -yInner+k);
	pixel.draw(hdc, col);

	pixel.put(-yInner+h, -xInner+k);
	pixel.draw(hdc, col);

	pixel.put(yInner+h, -xInner+k);
	pixel.draw(hdc, col);

	pixel.put(xInner+h, -yInner+k);
	pixel.draw(hdc, col);
}

//function to drow circle with BresenHam's method
void Circle::BHA(HDC hdc, COLORREF col)
{
	Point pixel;

	double xInner = 0;
	double yInner = radius;
	double d = 3-2*radius;

	while(xInner <= yInner)
	{
		pixel.put(xInner, yInner);
		drawSymetricPoints(pixel, hdc, col);

		if(d<0)
			d = d + 4*xInner+6;
		else
		{
			d = d + 4 * (xInner-yInner) + 10;
			yInner--;
		}
		xInner++;
	}
}

//function draw
void Circle::draw(HDC hdc, COLORREF col)
{
	BHA(hdc, col);
}

//#include"viewing.h"
//#include"Line.h"

//const int MAX = 10;

// ROTATE line
void Line::rotate(Point Center, double theta)
{
	pBegin.rotate(Center, theta);

	pEnd.rotate(Center, theta);
}

// TRANSLATE line 
void Line::translate(double tx, double ty)
{
	pBegin.translate(tx, ty);

	pEnd.translate(tx, ty);
}

// SCALE line
void Line::scale(double sx, double sy)
{
	pBegin.scale(sx, sy);
	pEnd.scale(sx, sy);
}

//reflect line
void Line::reflect(char ch)
{
	pBegin.reflect(ch);
	pEnd.reflect(ch);
}

//Draw line with DDA algorithm
void Line::Line_DDA(HDC hdc, COLORREF col)
{
	Point pixel;

	char axis1='n';
	char axis2='n';

	double xb;
	double yb;
	pBegin.get(xb, yb);

	double xf;
	double yf;
	pEnd.get(xf, yf);

	double x;
	double y;

	M = (yf-yb)/(xf-xb);//calculate slope 
	
	if(M>=1)
		axis1='d';

	if(M>=-1 && M<0)
		axis1='x';

	if(M<-1)
	{
		axis1='x';
		axis2='d';
	}

	reflect(axis1);
	reflect(axis2); 

	pEnd.get(xf, yf);
	pBegin.get(xb, yb);

	if(xb>xf)
	{
		pEnd.put(xb, yb);
		pBegin.put(xf, yf);
	}

	pEnd.get(xf, yf);
	pBegin.get(xb, yb);

	pBegin.get(x, y);
	
	M = (yf-yb)/(xf-xb);//calculate slope

	while(x<xf)
	{
		yb=yb+M;
		y = floor(yb+0.5);
	
		pixel.put(x, y);

		pixel.reflect(axis2);
		pixel.reflect(axis1);

		pixel.draw(hdc, col);

		x++;
	}
}

//Draw line with Brenes Han's algorithm
void Line::BHA(HDC hdc, COLORREF col)
{
	Point pixel;

	char axis1='n';
	char axis2='n';

	double xb;
	double yb;
	pBegin.get(xb, yb);

	double xf;
	double yf;
	pEnd.get(xf, yf);

	double x;
	double y;

	M = (yf-yb)/(xf-xb);//calculate slope 
	
	if(M>=1)
		axis1='d';

	if(M>=-1 && M<0)
		axis1='x';

	if(M<-1)
	{
		axis1='x';
		axis2='d';
	}

	reflect(axis1);
	reflect(axis2); 

	pBegin.get(xb, yb);
	pEnd.get(xf, yf);

	if(xb>xf)
	{
		pEnd.put(xb, yb);
		pBegin.put(xf, yf);
	}

	pBegin.get(x, y);

	pBegin.get(xb, yb);
	pEnd.get(xf, yf);
	
	dy=yf-yb;
	dx=xf-xb;

	double inc1=2*dy;//calculate inc1 which equal 2*dy
	double inc2=2*(dy-dx);
	double d=inc1-dx;//calculate d1

		   while(x<xf)
		   {
				x++;
			   if(d<0)
				   d=d+inc1;
			   else
			   {
				   d=d+inc2;
				   y++;
			   }
			   
			   pixel.put(x, y);
			   pixel.reflect(axis2);
			   pixel.reflect(axis1);

			   pixel.draw(hdc, col);
		   }
}

//Draw line 
void Line::draw(HDC hdc, COLORREF col)
{	
	Line_DDA(hdc, col);
	//BHA(hdc, col);
}

//***********
//clipping//
//***********
//return max
double Max(double a[4])
{
	double max=0;
	
	for(int i=0; i<4; i++)
		if(a[i]>max)
			max = a[i];
		return max;
}

//return min
double Min(double a[4])
{
	double min=1;
	
	for(int i=0; i<4; i++)
		if(a[i]<min)
			min=a[i];

		return min;
}

//Clipe line
void Line::clipe(HDC hdc, Point vMin, Point vMax, COLORREF col)
{
	double x1,y1, x2,y2, xMax,yMax, xMin,yMin;
	
	pBegin.get(x1, y1);
	pEnd.get(x2, y2);
	
	if(x1>x2)
	{
		pBegin.put(x2, y2);
		pEnd.put(x1, y1);
	}

	pBegin.get(x1, y1);
	pEnd.get(x2, y2);

	vMax.get(xMax, yMax);
	vMin.get(xMin, yMin);

	double p[4], q[4];

	double rMax[4] = {0, 0, 0, 0}, rMin[4] = {1, 1, 1, 1}, u1, u2;

	double dx = x2-x1;
	double dy = y2-y1;

	p[0] = -dx;
	q[0] = x1-xMin;

	p[1] = dx;
	q[1] = xMax-x1;

	p[2] = -dy;
	q[2] = y1-yMin;

	p[3] = dy;
	q[3] = yMax-y1;

	for(int i=0; i<4; i++)
	{
		if(p[i] == 0 && q[i] < 0)
			return;
		else 
			if( p[i]<0 ) 
				rMax[i] =q[i]/p[i];
			else 
				rMin[i] = q[i]/p[i];
	}

	u1 = Max(rMax);
	u2 = Min(rMin);

	if(u1 < u2)
	{
		pBegin.put(x1 + dx*u1, y1 + dy*u1);
		
		pEnd.put(x1 + dx*u2, y1 + dy*u2);
	}
	else 
		return;
	draw(hdc, col);
}

//***********
//clipping through polygon//
//***********
Point point[MAX];
int n;
//return true if the point inside the polygon
bool inside(Point p)
{
	double xP,yP, x[MAX],y[MAX], test[MAX];
	p.get(xP, yP);

	for(int i=1; i<n; i++)
	{
		point[i].get(x[i], y[i]);
		point[i-1].get(x[i-1], y[i-1]);
	
		test[i-1] = (x[i] - x[i-1])*(yP-y[i-1])-
					(y[i] - y[i-1])*(xP-x[i-1]);
	}

	test[n-1] = (x[0] - x[n-1])*(yP-y[n-1])-
					(y[0] - y[n-1])*(xP-x[n-1]);
	
	for(i=0; i<n; i++)
		if(test[i]>0)
			return false;
		return true;
}
//Clipe line
void Line::clipe(HDC hdc, Point points[], int m, COLORREF col)
{
	//number of polygon points
	n = m;

	//set the passing points to global points
	for(int i = 0; i<n; i++)
		point[i] = points[i];

	//the base case if the two line points inside the polygon
	if(inside(pBegin) && inside(pEnd))
	{
		draw(hdc, col);
		return;
	}

	//decleration for variables which will use in the loop
	//to draw the sub lines
	Line l;
	//th endpoints of the sublines
	Point pBInner, pEInner;
	Point pMid;
	double xBegin,yBegin, xEnd,yEnd, xMid,yMid;

	pBInner = pBegin;
	pEInner = pEnd;

	//while loop to divide the line to suplines by midpoint
	while(!inside(pBInner) || !inside(pEInner))
	{
		pBInner.get(xBegin, yBegin);
		pEInner.get(xEnd, yEnd);

		xMid=(xBegin+xEnd)/2;
		yMid=(yBegin+yEnd)/2;
		pMid.put(xMid, yMid);

		//if the two endpoints are cloosly equal break
		if(int(xBegin - xEnd)==0 && int(yBegin - yEnd)==0)
			break;

		//if the pegin point inside the polygon
		if(inside(pBInner))
		{
			if(!inside(pMid) && !inside(pEInner))
				pEInner = pMid;
			//if the mid point inside the polygon draw this subline
			else if(inside(pMid))
			{
				l.pBegin = pBegin;
				l.pEnd = pMid;
				l.draw(hdc, col);
				pBInner = pMid;
			}
		}
		//if the End point inside the polygon
		else if(inside(pEInner))
		{
			if(!inside(pMid) && !inside(pBInner))
				pBInner = pMid;
			//if the mid point inside the polygon draw this subline
			else if(inside(pMid))
			{
				l.pBegin = pMid;
				l.pEnd = pEnd;
				l.draw(hdc, col);
				pEInner = pMid;
			}
		}
		//if the two endpoints outside the polygon divide and clipe this subline
		else
		{
			l.pBegin = pBInner;
			l.pEnd = pMid;
			l.clipe(hdc, point, m, col);

			l.pBegin = pMid;
			l.pEnd = pEInner;
			l.clipe(hdc, point, m, col);

			break;
		}
	}
}
//#include"point.h"
/*******************************************************************/
///////////////////////// MIDPOINT_ALGORITHM Algorithm /////////////////////////////
/*******************************************************************/
//function to drow ellips with BresenHam's method
void MIDPOINT_ALGORITHM(HDC hdc, int h, int k, int a, int b, COLORREF col)
{
	int x = 0;
	int y = b;
	
	int aa = a*a;
	int bb = b*b;
	int aa2= aa*2;
	int bb2= bb*2;

	int fx=0;
	int fy=aa2*b;
	
	int p = int (bb - aa*b + 0.25*aa) ;

	while(fx < fy)
			{
				SetPixel(hdc, x+h , y+k , col);

				SetPixel(hdc, -x+h , y+k , col);

				SetPixel(hdc, -x+h , -y+k , col);

				SetPixel(hdc, x+h , -y+k , col);

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
/*******************************************************************/
///////////////////////// POLYNOMIAL_ALGORITHM //////////////////////
/*******************************************************************/
//function to drow ellips with Polynomial method
void POLYNOMIAL_ALGORITHM(HDC hdc, int h, int k, int a, int b, COLORREF col)
{
	double x = 0;
	double y;
	
	double aa = a*a;
	
	while(x <= a)
	{
		y = b*sqrt(1-x*x/aa);
		SetPixel(hdc, int(x+h) , int(y+k) , col);
		SetPixel(hdc, int(-x+h) , int(y+k) , col);
		SetPixel(hdc, int(-x+h) , int(-y+k) , col);
		SetPixel(hdc, int(x+h) , int(-y+k) , col);
		x+=0.01;
	}
}
/*******************************************************************/
/////////////////////////TRIGONOMETRIC_ALGORITHM //////////////////////
/*******************************************************************/
//function to drow ellips with TRIGONOMETRIC method
void TRIGONOMETRIC_ALGORITHM(HDC hdc, int h, int k, int a, int b, COLORREF col)
{
	double x;
	double y;
	
	double theta=0;
		
	while(theta <= 45)
	{
		x = a*cos(theta);
		y = b*sin(theta);
		SetPixel(hdc, int(x+h) , int(y+k) , col);
		SetPixel(hdc, int(-x+h) , int(y+k) , col);
		SetPixel(hdc, int(-x+h) , int(-y+k) , col);
		SetPixel(hdc, int(x+h) , int(-y+k) , col);
		theta+=0.01;
	}
}
//#include"circle.h"
class Ellipse
{
private:
	double a, b;
	void plot_fourPoints(HDC hdc, COLORREF color)
	{
		SetPixel(hdc, x+h , y+k,  color);
		SetPixel(hdc, -x+h, -y+k, color);
		
		SetPixel(hdc, x+h, -y+k,  color);
		SetPixel(hdc, -x+h, y+k,  color);	
	}
/*********************************************************************
***************    Polynomial  Algorthim          ********************/
void polynomial_ellipse( int a,int b,COLORREF color,HDC hdc )
{
	int h=150,k=100;			//		ellipse center
	int x=0,X_end=a;		// a    major axis,,, b mainor axis
	while(x<=X_end)
	{
		int y=b*( sqrt( 1- (x*x)/(a*a)  ) );
		plot_fourPoints(x,y,h,k,color,hdc);

		x++;
	}//end loop
}
/*********************************************************************
***************    trigonmetric  Algorthim          ********************/
void trigonmetric_ellipse(double a,double b,COLORREF color,HDC hdc)
{
	int h=150,k=100;			//		ellipse center
	double O=0.0,y=0.0,x=0.0;	// a    major axis,,, b mainor axis
	while(O<=45)
	{
		if(chooser==0)
		{
		x=a*cos( O );
		y=b*sin( O );
		}
//***************************************
		// Rotating  ellipse
	//	else
		{
			int R_angle=30;
			//rotatational angle= 90
		//	x=b*cos( O );
		//	y=a*sin( O );
			//x=(a*cos(O))-(b*sin(O+R_angle))+h;
			//y=(b*sin(O))+(a*cos(O+R_angle))+k;

		}

		plot_fourPoints(x,y,h,k,color,hdc);
		O+=.001;
	}//end loop
}

//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//
LRESULT CALLBACK WndProc(HWND hwnd ,UINT Message ,WPARAM wparam ,LPARAM
						 lparam)
{
	COLORREF color=RGB(25,255,250);
	COLORREF color1=RGB(180,0,120);

	HDC hdc;
	hdc=GetDC( hwnd );
	double val=10.0;int i;
	switch( Message )
	{
	case WM_CLOSE :
		DestroyWindow(hwnd);
		break ;
	case WM_DESTROY:
		PostQuitMessage(0);
		break ;

	case WM_LBUTTONDOWN:
		for(i=1;i<10;i++)
		{
		polynomial_ellipse(val,50, color1, hdc);
			val=10 * i;
		}
		ReleaseDC(hwnd,hdc);
		break ;

	case WM_RBUTTONDOWN:
		for(i=1;i<10;i++)
		{
			trigonmetric_ellipse(val,30 ,color, hdc);
			val=10 * i;
		}
		ReleaseDC(hwnd,hdc);
			//chooser++;
		break ;

	default:
		return DefWindowProc(hwnd,Message,wparam,lparam);
	}
	return 0;
}

//#include"point.h"

//x, y temporary use for make swap inside the needed function
double xInner;
double yInner;

// equal = overloaded
void Point::operator = (Point p)
{
	p.get(xInner, yInner);
	
	x = xInner;
	y = yInner;
}

void Point::put(double xPut, double yPut)
{
	x = xPut;
	y = yPut;
}

void Point::get(double& xPut, double& yPut)
{
	xPut = x;
	yPut = y;
}
//Draw point
void Point::draw(HDC hdc, COLORREF col)
{
	SetPixel(hdc, int(x), int(y), col);
}

//Rotate point
void Point::rotate(Point C, double theta)
{
	xInner=x;
    yInner=y;

	x = xInner*cos(theta)-yInner*sin(theta)-C.x*cos(theta)+C.y*sin(theta)+C.x;

	y = xInner*sin(theta)+yInner*cos(theta)-C.x*sin(theta)-C.y*cos(theta)+C.y;
}

// TRANSLATE point
void Point::translate(double tx, double ty)
{
	xInner=x;
    yInner=y;
    
	x = xInner + tx;
	y = yInner + ty;
}

// SCALE point 
void Point::scale(double sx, double sy)
{
	xInner=x;
    yInner=y;

	x = xInner * sx;
	y = yInner * sy;
}

//reflect point
void Point::reflect(char ch /*about which('x','y','d')*/)
{
	if(ch=='x' || ch=='X')
		y=-y;

	if(ch=='y' || ch=='Y')
		x=-x;

	if(ch=='d' || ch=='D')
	{
		xInner=x;
		yInner=y;

		y=xInner;
		x=yInner;	
	}
}

//swap two points
void Point::swap(Point point)
{
	point.get(xInner, yInner);
	point.put(x, y);
	put(xInner, yInner);
}

//compare two points
int Point::compar(Point point)
{
	point.get(xInner, yInner);
	
	if(x == xInner)
		return 0;

	else if(x > xInner)
		 return 1;
	else
		return -1;
}
//#include"viewing.h"

void Viewer::Draw(HDC hdc, COLORREF col)
{
	pMin.get(xMin, yMin);

	pMax.get(xMax, yMax);

	l.pBegin=pMin;
    l.pEnd.put(xMin, yMax);
	l.draw(hdc, col);

	l.pBegin=pMin;
    l.pEnd.put(xMax, yMin);
	l.draw(hdc, col);
	
	l.pBegin=pMax;
    l.pEnd.put(xMax, yMin);
	l.draw(hdc, col);

	l.pBegin=pMax;
    l.pEnd.put(xMin, yMax);
	l.draw(hdc, col);
}

void Viewer::Draw(HDC hdc, Point point[], int n, COLORREF col)
{
	for(int i=1; i<n; i++)
	{
		l.pBegin=point[i-1];
		l.pEnd=point[i];
		l.draw(hdc, col);
	}

	l.pBegin=point[0];
	l.pEnd=point[n-1];
	l.draw(hdc, col);
}



