
struct vector
{
	double v[3];
	vector()
	{
		v[0]=0;
		v[1]=0;
		v[2]=1;
	}
	vector(double x,double y, double Nfactor=1)
	{
		v[0]=x;
		v[1]=y;
		v[2]=Nfactor;
	}
	double & operator[](int index)
	{
		return v[index];
	}

};
struct Matrix
{
    double m[3][3];
	double &operator()(int i, int j)
	{
		return m[i][j];
	}
};
Matrix identity()
{
	Matrix M;
	for(double i=0;i<3;i++)
		for(double j=0;j<3;j++)

	
			M(i,j)=(i==j);
		

		return M;
	
}
Matrix Rotation(double Theta)
{
	Matrix M=identity();
	M(0,0)=(double)cos(Theta);
	M(0,1)=-(double)sin(Theta);
	M(1,0)=-M(0,1);
	M(1,1)=M(0,0);
	return M;
}
vector operator *(Matrix M, vector v)
{
	vector temp;
	for(double i=0;i<3;i++)
	{
		temp[i]=0;
		for(double j=0;j<3;j++)
			temp[i]+=(M(i,j)*v[j]);
	}
	return temp;
}


