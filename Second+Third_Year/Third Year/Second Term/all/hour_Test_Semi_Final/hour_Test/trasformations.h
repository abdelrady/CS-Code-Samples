/*struct vector
{
	double v[3];
	vector(double x,double y,double c=1)
	{
		v[0]=x;
		v[1]=y;
		v[2]=c;
	}
	double& operator [] (int a)
	{
		return v[a];
	}
	vector()
	{
		v[0]=v[1]=0;
		v[2]=1;
	}
vector operator *(float& a,vector b)
{
	vector v;
	for (int i=0;i<3;i++)
	{
		v[i]=0;
		for(int j=0;j<3;j++)
		{
			v[i]+=a[i,j]*b[j];
		}
	}
	return v;
}

};

////////////////////////////////////////////////////mul matrix///////////////////////////////////////////
struct matrix
{
	double m[3][3];
	double& operator () (int a,int b)
	{
		return m[a][b];
	}
};

	matrix identity()
	{
		matrix m;
		for (int i32=0;i32<3;i32++)
			for(int j=0;j<3;j++)
			m(i,j)=(i==j);

			return m;
	}
//////////////////////////////////////////////////test matrix/////////////////////////////////////

matrix rotate(double the)
{
	matrix m=identity();
	m(0,0)=cos(the*3.14/180);
	m(0,1)=-sin(the*3.14/180);
	m(1,0)=sin(the*3.14/180);
	m(1,1)=cos(the*3.14/180);
	return m;

}

double[] mul(double a[][],double b[])
{
	//	vector v;
	double v[3];
	for (int i=0;i<3;i++)
	{
		v[i]=0;
		for(int j=0;j<3;j++)
		{
			v[i]+=a[i][j]*b[j];
		}
	}
	return v;

}
*/