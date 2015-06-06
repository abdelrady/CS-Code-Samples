struct vector
{
	double v[3];
	vector(double xa,double ya,double nfv=1)
	{
		v[0]=xa;
		v[1]=ya;
		v[2]=nfv;
	}
	vector()
	{
		v[0]=v[1]=0;
		v[2]=1;
	}
	double& operator[](int index)
	{
		return v[index];
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
	mat(0,2)+=tx;
	mat(1,2)+=ty;
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

vector operator*(matrix mat,vector vec)
{
	vector rvec;
	for(double i=0;i<3;i++)
	{
		rvec[i]=0;
		for(double j=0;j<3;j++)
			rvec[i]+=(mat(i,j)*vec[j]);
	}
	return rvec;
}





