#include"Line.h"
/*************************************************************************
--------------	 Translation , Rotation , Scaling , Animation	-------------------- 
**************************************************************************
**************************************************************************/
struct Matrix
{
	float elm[3][3];
};
struct Vector
{
	float elm[3];	

};
//----------------
struct Scal_Matrix 
{
	float elm[2][2];
};

struct Scal_Vector
{
	float elm[2];
};

void identy(Matrix &M)
{
	for(int i=0;i<3;i++)
		for(int j=0;j<3;j++)
			M.elm[i][j]=(i==j);
}
/*==================================*/
Matrix trans_matrix(float dx,float dy)
{
	Matrix mat;
	identy(mat);
	mat.elm[0][2]=dx;
	mat.elm[1][2]=dy;
	return mat;
}
//**************************
Vector MUL(Matrix M,Vector GV)
{
	Vector RV;
	for(int i=0;i<3;i++)
	{
		RV.elm[i]=0;
		for(int j=0;j<3;j++)
			RV.elm[i]+=M.elm[i][j]*GV.elm[j];
	}
	return RV;
}
Vector translation(float X,float Y,float dx,float dy)
{
		Vector V;
		V.elm[0]=X, V.elm[1]=Y, V.elm[2]=1;
		Matrix M=trans_matrix(dx,dy);
		return Vector(MUL(M,V));
}
//===================================
Vector Rotate(float O,float x,float y)
{
	Matrix Rm;
	float h=200,k=200;
	identy(Rm);
	Rm.elm[0][0]=cos( O );
	Rm.elm[0][1]=-sin( O );
	Rm.elm[0][2]=(-h*cos(O)+k*sin(O)+h);
	Rm.elm[1][1]=cos(O);
	Rm.elm[1][0]=sin(O);
	Rm.elm[1][2]=(-h*sin(O)-k*cos(O)+k);
	
	Vector vec;
	vec.elm[0]=x;
	vec.elm[1]=y;
	vec.elm[2]=1;
    return	Vector (MUL(Rm,vec) );
}
Scal_Vector  MUl_scal(Scal_Matrix  SM,Scal_Vector SV)
{
	Scal_Vector RV;
	RV.elm[0]=SM.elm[0][0]*SV.elm[0];
	RV.elm[1]=SM.elm[1][1]*SV.elm[1];
	return RV;
}
Scal_Vector scaling(float X,float Y,float Sx,float Sy)
{
	Scal_Matrix M;
	Scal_Vector V;
	M.elm[0][0]=Sx;		M.elm[0][1]=0;
	M.elm[0][1]=0;		M.elm[1][1]=Sy;
	V.elm[0]=X;			V.elm[1]=Y;
	return Scal_Vector( MUl_scal(M,V) );
}
struct Point
{
	float x,y;
	Point()
	{}
	Point(float a,float b)
	{
		x=a;y=b;
	}

};
void Boundary_Filling(int x, int y, COLORREF fillColor, COLORREF boundaryColor,HDC hdc)
{
	COLORREF color = GetPixel(hdc, x, y);
	if(color == boundaryColor || color == fillColor || x<0 || y<0)
		return;
	else
	{
		SetPixel(hdc, x, y, fillColor);
		Boundary_Filling( x-1, y, fillColor, boundaryColor,hdc);
		Boundary_Filling( x, y-1, fillColor, boundaryColor,hdc);
		Boundary_Filling( x+1, y, fillColor, boundaryColor,hdc);
		Boundary_Filling( x, y+1, fillColor, boundaryColor,hdc);
	}
}
//------------------------------------------------------
void Draw_Rec(Point a,Point b,Point c,HDC hdc,COLORREF C)
{
		DDA(a.x,a.y,b.x,b.y,C,hdc);
		//MoveToEx(hdc, WXmin, WYmin, NULL);
		//LineTo(hdc, WXmax, WYmin);
		DDA(b.x,b.y,c.x,c.y,C,hdc);
		DDA(a.x,a.y,c.x,c.y,C,hdc);
}
//---------------------------------
void Scaling_animat(float Sx,float Sy,HDC hdc,COLORREF C1)
{
		Point a(650,350),b(600,440), c(700,440);
		Draw_Rec(a,b,c,hdc,C1);
		Scal_Vector A,B,C;
		for(int i=0;i<=10;i++)
		{
		A=scaling(Sx,Sy,a.x,a.y);
		B=scaling(Sx,Sy,b.x,b.y);
		C=scaling(Sx,Sy,c.x,c.y);
		Point AA(A.elm[0],A.elm[1]);
		Point BB(B.elm[0],B.elm[1]);
		Point CC(C.elm[0],C.elm[1]);
		Sleep(250);
		Draw_Rec(AA,BB,CC,hdc,C1);
		Sx-=.01;
		Sy-=.01;
		a.x=A.elm[0];a.y=A.elm[1];
		b.x=B.elm[0];b.y=B.elm[1];
		c.x=C.elm[0];c.y=C.elm[1];
		}
}
void Fan(HDC hdc,COLORREF C2,bool change)
{
		float O=10*3.14/180;//rotate angle
		float O2=120*3.14/180;//angle between=60,,Or =120
		float h=200,k=200;
		Point top(h,k);
		//Triangle  1
		Point P1(h+20,k+100);
		if(change)
		{
			Point temp(h+2,k+20);
			P1=temp;
		}

		Point P2(h,k+100);
		Vector V1,V2;
		Draw_Rec(top,P1,P2,hdc,C2);
		//Triangle  2
		Vector V3=Rotate(O2,P1.x,P1.y);
		Vector V4=Rotate(O2,P2.x,P2.y);
		Point P3(V3.elm[0],V3.elm[1]);
		Point P4(V4.elm[0],V4.elm[1]);
		Draw_Rec(top,P3,P4,hdc,C2);
		
		//Triangle  3
		Vector V5=Rotate(O2,P3.x,P3.y);
		Vector V6=Rotate(O2,P4.x,P4.y);
		Point P5(V5.elm[0],V5.elm[1]);
		Point P6(V6.elm[0],V6.elm[1]);
		Draw_Rec(top,P5,P6,hdc,C2);
/*__________________________________________________________________________
__________________________________________________________________________*/	
		int i=1;
	COLORREF GRND=GetPixel(hdc,0,0);
	while(i<50)
		{
		Sleep(100);
			//draw with ground
			Draw_Rec(top,P1,P2,hdc,GRND);
			Draw_Rec(top,P3,P4,hdc,GRND);
			Draw_Rec(top,P5,P6,hdc,GRND);
			
			//tri 1
			V1=Rotate(O,P1.x,P1.y);
			V2=Rotate(O,P2.x,P2.y);
			P1.x=V1.elm[0];P1.y=V1.elm[1];
			P2.x=V2.elm[0];P2.y=V2.elm[1];
			//tri 2
			V3=Rotate(O,P3.x,P3.y);
			V4=Rotate(O,P4.x,P4.y);
			P3.x=V3.elm[0];P3.y=V3.elm[1];
			P4.x=V4.elm[0];P4.y=V4.elm[1];
			//tri 3
			V5=Rotate(O,P5.x,P5.y);
			V6=Rotate(O,P6.x,P6.y);
			P5.x=V5.elm[0];P5.y=V5.elm[1];
			P6.x=V6.elm[0];P6.y=V6.elm[1];
			//draw next triangles
			Draw_Rec(top,P1,P2,hdc,RGB(P1.x+P2.x,P2.x+P1.y,0) );
			Draw_Rec(top,P3,P4,hdc,RGB(P3.x+P4.x,P3.x+P4.y,0) );
			Draw_Rec(top,P5,P6,hdc,RGB(P5.x+P6.x,P5.x+P6.y,0) );

			i++;
		}
}
//***********************************************************************/
//***********************************************************************/
void xySystem(HDC hdc,COLORREF C1,COLORREF C2)
	{
	float dx=100,dy=100;
	//original points
	Point	P1(320,100),P2(315,105),P3(325,395),P4(150,240),
			 P5(500,400),P6(155,235),P7(495,245);

// coordinate sys
		DDA_Line(P1.x,P1.y,P1.x,P5.y,C1,hdc);
		
		DDA_Line(P2.x,P2.y,P1.x,P1.y,C1,hdc);
		DDA_Line(P1.x,P1.y,P3.x,P2.y,C1,hdc);

		DDA_Line(P2.x,P3.y,P1.x,P5.y,C1,hdc);
		DDA_Line(P1.x,P5.y,P3.x,P3.y,C1,hdc);

		DDA_Line(P4.x,P4.y,P5.x,P4.y,C1,hdc);

		DDA_Line(P4.x,P4.y,P6.x,P6.y,C1,hdc);
		DDA_Line(P4.x,P4.y,P6.x,P7.y,C1,hdc);

		DDA_Line(P5.x,P4.y,P7.x,P6.y,C1,hdc);
		DDA_Line(P5.x,P4.y,P7.x,P7.y,C1,hdc);
		//after translation
		Vector V1,V2,V3,V4,V5,V6,V7;
		V1=translation(P1.x,P1.y,dx,dy);
		V2=translation(P2.x,P2.y,dx,dy);
		V3=translation(P3.x,P3.y,dx,dy);
		V4=translation(P4.x,P4.y,dx,dy);
		V5=translation(P5.x,P5.y,dx,dy);
		V6=translation(P6.x,P6.y,dx,dy);
		V7=translation(P7.x,P7.y,dx,dy);
///_______________________________________________________________________

		Dashed_line(V1.elm[0],V1.elm[1],V1.elm[0],V5.elm[1],1,C2,hdc);
		
		Dashed_line(V2.elm[0],V2.elm[1],V1.elm[0],V1.elm[1],1,C2,hdc);
		Dashed_line(V1.elm[0],V1.elm[1],V3.elm[0],V2.elm[1],1,C2,hdc);

		Dashed_line(V2.elm[0],V3.elm[1],V1.elm[0],V5.elm[1],1,C2,hdc);
		Dashed_line(V1.elm[0],V5.elm[1],V3.elm[0],V3.elm[1],1,C2,hdc);

		Dashed_line(V4.elm[0],V4.elm[1],V5.elm[0],V4.elm[1],1,C2,hdc);

		Dashed_line(V4.elm[0],V4.elm[1],V6.elm[0],V6.elm[1],1,C2,hdc);
		Dashed_line(V4.elm[0],V4.elm[1],V6.elm[0],V7.elm[1],1,C2,hdc);

		Dashed_line(V5.elm[0],V4.elm[1],V7.elm[0],V6.elm[1],1,C2,hdc);
		Dashed_line(V5.elm[0],V4.elm[1],V7.elm[0],V7.elm[1],1,C2,hdc);

	}
//>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> 
