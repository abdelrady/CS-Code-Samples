#include <math.h>
double RAD=22.0/(7*180);
//******************************************
//
struct vector
{
	double v[3];

	//-------------------------------------
	//constructor
	vector(double x, double y, double c=1.0)
	{
		v[0] = x;
		v[1] = y;
		v[2] = c;
	}
	//--------------------------------------
	//constructor
	vector()
	{
		v[0] = 0;
		v[1] = 0;
		v[2] = 1;
	}

	
	//---------------------------------------
	//
	double& operator[](int index)
	{return v[index];}
};
//*******************************************
//matrix
struct matrix
{
	double m[3][3];
	//----------------------------------------
	//
	double& operator()(int x, int y)
	{return m[x][y];}
};
//*******************************************
matrix Identity()
{
	matrix m;
	for(int i=0;i<3;i++)
		for(int j=0;j<3;j++)
			m(i,j) = (i == j);

	return m;
}
//**********************************************
matrix Rotation(double theta)
{
	matrix m;

	m = Identity();
	theta = (theta*22.0)/(7.0*180.0);

	m(0,0) = cos(theta);
	m(0,1) = -sin(theta);
	m(1,0) = -m(0,1);
	m(1,1) = m(0,0);

	return m;
}
//***********************************************
//
vector operator*(matrix& m,vector& v)
{
	vector vr;

	for(int i=0;i<3;i++)
	{
		vr[i] = 0;
		for(int j=0;j<3;j++)
		{
			vr[i] += (m(i,j)*v[j]);
		}
	}

	return vr;
}
