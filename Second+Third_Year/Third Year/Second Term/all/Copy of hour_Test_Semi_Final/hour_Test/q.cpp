#include <stdio.h>

#include <sys/types.h>
#include <sys/timeb.h>
#include<time.h>
vector2 rotation(HDC hdc,float x2, float y2, float h, float k, float angle)
{
	double v1[3],v2[3];
	double matrix1[3][3];//, result[3][3];
	//vector  matrix2[3];
	v1[0]=x2;
	v1[1]=y2;
	v1[2]=1;

	matrix1[0][0] = matrix1[1][1] = cos(angle*3.14/180);
	matrix1[0][1] = - sin(angle*3.14/180);
	matrix1[1][0] = sin(angle*3.14/180);
	matrix1[0][2] = -h * cos(angle*3.14/180) + k * sin(angle*3.14/180) + h;
	matrix1[1][2] = -h * sin(angle*3.14/180) - k * cos(angle*3.14/180) + k;
	matrix1[2][0] = matrix1[2][1] = 0;
	matrix1[2][2] = 1;

	//matrix2[0]] = x1;
	//matrix2[1][0] = y1;
	//matrix2[0] = x2;
	//matrix2[1] = y2;
	//matrix2[0][2] = matrix2[1][2] = 0;
	//matrix2[2]=1;

	/*for(int i=0; i<3;i++)
		for(int j=0; j<3; j++)
			result[i][j] = 0;
	
	mulMatrices(matrix1, matrix2, result);*/

//mul(matrix1,v1,v1);
for (int i=0;i<3;i++)
	{
		v2[i]=0;
		for(int j=0;j<3;j++)
		{
			v2[i]+=matrix1[i][j]*v1[j];
		}
	}

vector2 vec(v2[0],v2[1],v2[2]);

return vec;
//return v1;
	// original line
	//MoveToEx(hdc, int(matrix2[0][0]), int(matrix2[1][0]), NULL);
	//LineTo(hdc, int(matrix2[0][1]), int(matrix2[1][1]));
	//Sleep(500);
	//BHA_ALGORITHM_Line(hdc,150,120,int(matrix2[0][1]),int(matrix2[1][1]),white);
	

	// resulted line
	//MoveToEx(hdc, int(result[0][0]), int(result[1][0]), NULL);
	//mat3[0]=int(result[0][1]);
	//mat3[1]=int(result[1][1]);
	//LineTo(hdc, int(result[0][1]), int(result[1][1]));
	//Sleep(500);
	//BHA_ALGORITHM_Line(hdc,150,120,int(result[0][1]),int(result[1][1]),white);
}