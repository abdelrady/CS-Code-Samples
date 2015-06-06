//#include"Line.h"
//float X_min=210, X_max=500,Y_min=150, Y_max=430;
float X_min=50, X_max=700,Y_min=50, Y_max=450;
struct Interserct
{
	float Xi,Yi;
};

void Draw_Window(float x1, float y1, float x2, float y2,COLORREF col,HDC hdc)
{
	DDA(x1,y1,x1,y2,col,hdc);
	DDA(x1,y1,x2,y1,col,hdc);
	DDA(x2,y2,x1,y2,col,hdc);
	DDA(x2,y2,x2,y1,col,hdc);
}
float MAX(float x,float y)
{
	return x>y?x:y;
}

float MIN(float x,float y)
{
	return x<y?x:y;
}
//====================  Liagn Barsky		==============================
//========================================================================
void Liagn_Barsky(float x1, float y1, float x2, float y2,COLORREF Col,HDC hdc)
{
	COLORREF C=RGB(255,0,0);
	float dx=x2-x1,dy=y2-y1;
	float P[4],Q[4];
	float R[4],U1=0,U2=1;
	Interserct  end_P1 , end_P2;//tow intersected points
	//intialize all variables
	
	P[0]=-dx;		Q[0]=x1-X_min;
	P[1]=dx	;		Q[1]=X_max-x1;
	P[2]=-dy;		Q[2]=y1-Y_min;
	P[3]=dy ;		Q[3]=Y_max-y1;

	for(int i=0;i<4;i++)
	{
		if( P[i]==0&&Q[i]<0 )//line completly out side window
				return;	
		if( P[i]<0 )
		{
			R[i]=Q[i]/P[i];
			U1=MAX(R[i],MAX(0,U1));
		}

		else if( P[i]>=0 )
		{
			R[i]=Q[i]/P[i];
			U2=MIN(R[i],MIN(1,U2));
		}
	}//end for
	if( U1>U2 )
		return;
//calculate end points
		end_P1.Xi=x1+dx*U1;				end_P1.Yi=y1+dy*U1;
		end_P2.Xi=x1+dx*U2;				end_P2.Yi=y1+dy*U2;


//DDA_ALGORITHM(x1,y1,end_P1.Xi,end_P1.Yi,C,hdc);
//DDA_ALGORITHM(end_P2.Xi,end_P2.Yi,x2,y2,C,hdc);

DDA(  end_P1.Xi, end_P1.Yi,
				end_P2.Xi,end_P2.Yi,	Col, hdc);

}