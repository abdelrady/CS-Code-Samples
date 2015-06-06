#include<math.h>
struct line
{
	int x1,y1,x2,y2;
	int color1,color2,color3;
	line()
	{
		x1=y1=x2=y2=0;
		color1=color2=color3=0;
	}
/*	double& operator[](int index)
	{
		return v[index];
	}*/
};
struct circle
{
 //	int x,y,r;
	double v[3];
	int color1,color2,color3;
	circle()
	{
		for(int y=0;y<3;y++)
			v[y]=0;

	//	x=y=r=0;
		color1=color2=color3=0;
	}

	double& operator[](int index)
	{
		return v[index];
	}
};
struct ellipse
{
	int x,y,a,b,theta;
	int color1,color2,color3;
	ellipse()
	{
		x=y=a=b=theta=0;
		color1=color2=color3=0;
	}
};
struct rectangle
{
	int top,bottom,left,right;
	int color1,color2,color3;
	rectangle()
	{
		top=bottom=left=right=0;
		color1=color2=color3=0;
	}
};
struct matrix
{
	double m[3][3];
	double& operator()(int i,int j)
	{
		return m[i][j];
	}
};
/////////////********************************//////////////////////
matrix identity()
{
	matrix mat;
	for(double i=0;i<3;i++)
		for(double j=0;j<3;j++)
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
circle operator*(matrix mat,circle vec)
{
	circle rvec;
	for(double i=0;i<3;i++)
	{
		rvec[i]=0;
		for(double j=0;j<3;j++)
			rvec[i]+=(mat(i,j)*vec[j]);
	}
	return rvec;
}
matrix scalar(int sx,int sy)
{
	matrix mat=identity();
	mat(0,0)*=sx;
	mat(1,1)*=sy;
	return mat;
}
matrix translation(int tx,int ty)
{
	matrix mat=identity();
	mat(0,2)=tx;
	mat(1,2)=ty;
	return mat;
}

matrix Refelsction_X()
{
	matrix mat=identity();
	mat(0,0)=1;
	mat(1,1)=-1;
	return mat;
}

matrix Refelsction_Y()
{
	matrix mat=identity();
	mat(0,0)=-1;
	mat(1,1)=1;
	return mat;
}