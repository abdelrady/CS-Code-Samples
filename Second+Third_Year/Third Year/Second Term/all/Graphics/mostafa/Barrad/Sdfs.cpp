
#include<fstream>
using namespace std;
#include<math.h>
#include<windows.h>
# include "scanline.h"
int counter=0,hid=0;
HWND hwnd;

void interpolx(HDC hdc,int ymin,int ymax);
COLORREF I,kk=RGB(255,255,255);
//float zb[550][800];
float c1=0.1,c2=0.00001,c3=0.0003,ns=80;
float z_buff[550][2];
void dda(HDC,float,float,float,float,COLORREF);
//---------------ok

///

struct matrix
{
	float m[4][4];
	float & operator()(int a,int b)
	{
		return m[a][b];
	}
};

vector operator*(vector &a,matrix &b)
{
	vector mul;
	for(int i=0;i<4;i++)
	{
		mul[i]=0;
		for(int j=0;j<4;j++)
			mul[i]+=b(j,i)*a[j];
	}
	return mul;
}
vector operator*(matrix &a,vector &b)
{
	vector mul;
	for(int i=0;i<4;i++)
	{
		mul[i]=0;
		for(int j=0;j<4;j++)
			mul[i]+=a(i,j)*b[j];
	}
	return mul;
}
matrix operator*(matrix & a,matrix & b)
{
	matrix mul;
	for(int i=0;i<4;i++)
		for(int j=0;j<4;j++)
		{
			mul(i,j)=0;
			for(int k=0;k<4;k++)
				mul(i,j)+=a(i,k)*b(k,j);
		}
	return mul;
}
//--------ok
vector operator*(vector& a,vector& b)
{
	vector s;
	s[0]=a[0]*b[0];
	s[1]=a[1]*b[1];
	s[2]=a[2]*b[2];
	s[3]=a[3]*b[3];
	return s;
}
//--------ok
vector operator*(vector& a,float b)
{
	vector s;
	s[0]=a[0]*b;
	s[1]=a[1]*b;
	s[2]=a[2]*b;
	s[3]=a[3]*b;
	return s;
}
//--------ok
vector operator/(vector& a,float b)
{
	vector s;
	if(b==0)
		return s;
	s[0]=a[0]/b;
	s[1]=a[1]/b;
	s[2]=a[2]/b;
	s[3]=a[3]/b;
	return s;
}
//--------ok
void stand (vector &a)
{
	if(a[3]==0)
		return;
	a=a/a[3];
}
//-------------- ok                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
matrix idn()
{
	matrix m;
	for(int i=0;i<4;i++)
		for(int j=0;j<4;j++)
			m(i,j)=(i==j);
	return m;
}
//------------ok
matrix transys(vector &u,vector &v,vector &w)
{
	matrix m=idn();
	for(int g=0;g<3;g++)
	{
		m(0,g)=u[g];	
		m(1,g)=v[g];	
		m(2,g)=w[g];	
	}
	return m;
}
//------------ok
void normalize(vector &a)
{
	float s=sqrt(a[0]*a[0]+a[1]*a[1]+a[2]*a[2]);
	if(s==0)
		return;
	a=a/s;
}
///-----------ok
matrix shearing(float a,float b)
{
	matrix m=idn();
	m(0,2)=a;
	m(1,2)=b;
	return m;
}
//------------ok
matrix trans(float a,float b,float c)
{
	matrix m=idn();
	m(0,3)=a;
	m(1,3)=b;
	m(2,3)=c;
	return m;
}
//--------ok
	matrix pp=idn();
	matrix T=idn();
	matrix Ts=idn();
	matrix sh=idn();
	matrix pr=idn();
	matrix R=idn();
	
vector cross(vector &a,vector &b)
{
	vector v;
	v[0]= (a[1]*b[2])-(a[2]*b[1]);
	v[1]= -(a[0]*b[2])+(a[2]*b[0]);
	v[2]= (a[0]*b[1])-(a[1]*b[0]);
	v[3]=1;
	return v;
}
//---------ok
vector operator -(vector &v1,vector &v2)
{
	vector v3;
	v3[0]=v2[0]-v1[0];
	v3[1]=v2[1]-v1[1];
	v3[2]=v2[2]-v1[2];
	v3[3]=1;
	return v3;
}
//---------ok
vector operator +(vector &a,vector &b)
{
	vector v3;
	v3[0]=b[0]+a[0];
	v3[1]=b[1]+a[1];
	v3[2]=b[2]+a[2];
	v3[3]=1;
	return v3;
}
//------------ok
float dotproduct(vector &v1,vector &v2)
{
	float f=v1[0]*v2[0]+v1[1]*v2[1]+v1[2]*v2[2];
	return f;
}
matrix rot(float th)
{
	matrix r=idn();
	r(0,0)=r(1,1)=cos(th);
	r(1,0)=sin(th);
	r(0,1)=-r(1,0);
	return r;
}
//---------ok
matrix pres (float d)
{
	matrix r=idn();
	r(3,2)=1/d;
	r(3,3)=0;
	return r;
}
//-------------ok
COLORREF Tcolor(vector a)
{
	COLORREF b=RGB(0,0,255);
	return b;
}
//=============defininitions===============================
//-------------ok
vector *vec,kamb,kspec,Ia,*comm,kdiff,l,Is;
vector ed[480][2],rr,cop;
const int mmmm=3783;
int am[3213];
int numc[mmmm];
//----------
struct poly
{
	int count;
	int *p;
};
fstream file;
poly *polygon;
int nver,npol;
matrix p,p11,p12;
bool ishedden(poly f);
//--------------
//=========================================================
vector calcI(vector n,float x,float y,float z)
{
	vector Iamb=Ia*kamb,cv;	//ambient 
	float d,ft,c,cc;
	vector lo;
	d=sqrt((x-l[0])*(x-l[0])+(y-l[1])*(y-l[1])+(z-l[2])*(z-l[2]));
	ft=1/(c1+c2*d+c3*d*d);
	matrix k=trans(-x,-y,-z);
	lo=l*k;
	normalize(lo);
	normalize(n);
	c=2.0000;
	cv=(n*c);
	c=dotproduct(cv,lo);
	cv=n*c;
	rr=(cv-lo);
	c=dotproduct(lo,n);
	if(c<0)
	{
		c=0;
		ft=0;
	}
	cop=cop*k;
	normalize(cop);
	normalize(rr);
	cc=dotproduct(rr,cop);
	cc=pow(cc,ns);
	vector Isp=Is*kspec*cc*ft;
	vector Iss=Is*kdiff*c*ft;
	vector I=Iamb+Iss+Isp;
	return I;
}
//-----------
vector getnorm(poly j)
{
	vector v1,v2,v3;
	v1=vec[j.p[1]]-vec[j.p[0]];
	v2=vec[j.p[2]]-vec[j.p[1]];
	v3=cross(v1,v2);
	return v3;
}
//-----------
void initialize()
{
	for(int i=0;i<550;i++)
		{
			z_buff[i][0]=1000;
			z_buff[i][1]=-1000;
		}
}
//-----------
void interpoly(HDC hdc,float xs,float ys,float xe,float ye,vector Is,vector Ie)
{
	float t,dy,dx;
	COLORREF nn;
	vector Ii;
	if(ye<ys)
	{
		t=xs;	xs=xe;	xe=t;
		t=ys;	ys=ye;	ye=t;
		Ii=Is;	Is=Ie;	Ie=Ii;
	}
	float x=xs,y=ys,k;
	dy=ye-ys;
	dx=xe-xs;
	t=dx/dy;
	float bb;
	while(y<=ye)
	{
		k=(ye-y)/(ye-ys);
		bb=Ie[0]-Is[0];
		Ii[0]=Ie[0]-bb*k;
		bb=Ie[1]-Is[1];
		Ii[1]=Ie[1]-bb*k;
		bb=Ie[2]-Is[2];
		Ii[2]=Ie[2]-bb*k;
		I=Tcolor(Ii);
		////////////mmmm////////////

		//////mmmm//////////////////
		SetPixel(hdc,x+400,y+200,RGB(255,0,0));
		if(x < z_buff[(int)y][0])
		{
			z_buff[(int)y][0]=x;
			ed[(int)y][0]=Ii;
		}
		if(x > z_buff[(int)y][1])
		{
			z_buff[(int)y][1]=x;
			ed[(int)y][1]=Ii;
		}
		x+=t;
		y++;
		
	}
}
//----------
void interpolx(HDC hdc,int ymin,int ymax)
{
	float k,bb;
	vector Is,Ie,Ii;
	float xs,xe,x;
	for(int r=ymin;r<ymax;r++)
		if(z_buff[r][1]>z_buff[r][0])
		{
			x=z_buff[r][0];
			xs=z_buff[r][0];
			xe=z_buff[r][1];
			Is=ed[r][0];
			Ie=ed[r][1];
			Ii=Is;

			while(z_buff[r][1]>x)
			{
				k=(xe-x)/(xe-xs);
				bb=Ie[0]-Is[0];
				Ii[0]=Ie[0]-bb*k;
				bb=Ie[1]-Is[1];
				Ii[1]=Ie[1]-bb*k;
				bb=Ie[2]-Is[2];
				Ii[2]=Ie[2]-bb*k;
				I=Tcolor(Ii);
				int color=RGB(255,255,255);
				if(GetPixel(hdc,x+400,r+400)==color)
				{
					SetPixel(hdc,x+400,r+400,I);
				}
				//SetPixel(hdc,x+400,r+400,I);
				x++;
			}
		}
	
}
//----------ok
matrix getcamera(vector &cop,vector &vrp,
				 vector &vpn,vector &vup,int umax,
				 int umin,int vmax ,int vmin)
{

	vector v1,u,v,w;
	float cx ,cy;
	T=trans(-cop[0],-cop[1],-cop[2]);
	w=vpn;
	normalize(w);
	u=cross(w,vup);
	normalize(u);
	v=cross(u,w);
	R=transys(u,v,w);
	vector vrp1=(vrp*T)*R;
	cx=vrp1[0]+(umax+umin)/2;
	cy=vrp1[1]+(vmax+vmin)/2;
	sh=shearing(-cx/vrp1[2],-cy/vrp1[2]);
	pr=pres(vrp1[2]);
	pp=T*(R*(sh*pr));
	return pp;
}

//-------------ok
void readme(HWND hWnd,HDC hdc,COLORREF color,matrix cam)
{
	float x,y,z;
	vector temp;
	file.open("BlueTea.txt",ios::in);
	if(!file.good())
		MessageBox(hWnd,"filee not open","BlueTea",2);
	file>>nver;
	file.ignore();
	vec=new vector [nver];
	comm=new vector [nver];
	for(int i=0;i<nver;i++)
	{
		file>>x;
		x*=100;
		file.ignore();
		file>>y;
		y*=100;
		file.ignore();
		file>>z;
		z*=100;
		file.ignore();
		file.ignore();
		temp(x,y,z);
		temp=temp*cam;
		vec[i]=temp;
	}
	poly hh;
	file>>npol;
	file.ignore();
	polygon=new poly[npol];
	for(int j=0;j<npol;j++)
	{
		file>>hh.count;
		file.ignore();
		hh.p=new int[hh.count];
		for(int e=0;e<hh.count;e++)
		{
			file>>hh.p[e];
			file.ignore();
		}
		file.ignore();
		polygon[j]=hh;
	}
	file.close();
}
//----------
void getnv()
{
	poly in;
	for(int i=0;i<npol;i++)
	{
		in=polygon[i];
		vector n=cross(vec[in.p[1]]-vec[in.p[0]],vec[in.p[2]]-vec[in.p[1]]);  
		for(int hh=0;hh<in.count;hh++)
		{
			comm[in.p[hh]]=comm[in.p[hh]]+n;
			numc[in.p[hh]]++;
		}
	}
	for(i=0;i<nver;i++)
	{
		comm[i]=comm[i]/numc[i];
	}
	
}
//----------
bool ishedden(poly f)
{
	vector n;
	n=cross(vec[f.p[1]]-vec[f.p[0]],vec[f.p[2]]-vec[f.p[1]]);
	float d=dotproduct(vec[f.p[0]],n);
	if(d>0)
		return true;
	else 
		return false;
}
//------------
void dis (HDC hdc,int color)
{
	poly curr;
	float ww;
	vector Is,Ie;
	COLORREF s,e;
	vector nn,nnn;
	for(int x=0;x<nver;x++)
	{
		comm[x][0]=0;
		comm[x][1]=0;
		comm[x][2]=0;
		numc[x]=0;
	}
	getnv();
	//point pp[10];
	int i=0,ymin,ymax;
	while(i<npol)
	{ 
		ymin=100000;
		ymax=-100000;
		curr=polygon[i];
		i++;
		if(ishedden(curr))
		{
			hid++;
			continue;
		}
		initialize();
		counter++;
		if(counter>260&&counter<1000)
		{
			//MessageBox(hwnd,">260","BlueTea",2);
			counter=1001;
		}
		for(int j=0;j<curr.count-1;j++)
		{
			if(color==1)
			{
				Is=calcI(comm[curr.p[j]],vec[curr.p[j]][0],vec[curr.p[j]][1],vec[curr.p[j]][2]);
			}
			else
				Is(1,1,1);
			s=Tcolor(Is);
			
			stand(vec[curr.p[j]]);
			if(GetPixel(hdc,(int)vec[curr.p[j]][0]+400,(int)vec[curr.p[j]][1]+400)==color)
			{
				SetPixel(hdc,(int)vec[curr.p[j]][0]+400,(int)vec[curr.p[j]][1]+400,s);
			}
			if(color==1)
			{
				Ie=calcI(comm[curr.p[j+1]],vec[curr.p[j+1]][0],vec[curr.p[j+1]][1],vec[curr.p[j+1]][2]);
			}
			else
			Ie(1,1,1);
			e=Tcolor(Ie);	

			SetPixel(hdc,(int)vec[curr.p[j+1]][0]+400,(int)vec[curr.p[j+1]][1]+400,e);
			if(vec[curr.p[j]][1]<ymin)
				ymin=vec[curr.p[j]][1];
			if(vec[curr.p[j]][1]>ymax)
				ymax=vec[curr.p[j]][1];
			if(vec[curr.p[j+1]][1]<ymin)
				ymin=vec[curr.p[j+1]][1];
			if(vec[curr.p[j+1]][1]>ymax)
				ymax=vec[curr.p[j+1]][1];
			interpoly(hdc,vec[curr.p[j]][0],vec[curr.p[j]][1],vec[curr.p[j+1]][0],vec[curr.p[j+1]][1],Is,Ie);
		}
		if(color)
		{
			Is=calcI(comm[curr.p[j]],vec[curr.p[j]][0],vec[curr.p[j]][1],vec[curr.p[j]][2]);
		}
		else 
			Is(1,1,1);
		stand(vec[curr.p[j]]);
		s=Tcolor(Is);
		SetPixel(hdc,(int)vec[curr.p[j]][0]+400,(int)vec[curr.p[j]][1]+400,s);
		if(color)
		{
   			Ie=calcI(comm[curr.p[0]],vec[curr.p[0]][0],vec[curr.p[0]][1],vec[curr.p[0]][2]);
		}
		else
			Ie(1,1,1);
		e=Tcolor(Ie);
		stand(vec[curr.p[0]]);
		SetPixel(hdc,(int)vec[curr.p[0]][0]+400,(int)vec[curr.p[0]][1]+400,e);
		interpoly(hdc,vec[curr.p[j]][0],vec[curr.p[j]][1],
			vec[curr.p[0]][0],vec[curr.p[0]][1],Is,Ie);
		interpolx(hdc,ymin,ymax); 
	
	
	}
//	if(hid>860)
	//	MessageBox(hwnd,"íáááÇ ÕÈ ÇáÔÇí","Graphic Group",0);
}
//-----------------
LRESULT WINAPI WndProc(HWND,UINT,WPARAM,LPARAM);
int WINAPI WinMain(HINSTANCE hi,HINSTANCE pi,LPSTR,int ncmd)
{
	WNDCLASS wc;
	if(!pi)
	{
		wc.lpszClassName ="BlueTea";
		wc.lpfnWndProc =WndProc;
		wc.lpszMenuName ="NULL";
        wc.style =CS_HREDRAW|CS_VREDRAW;
		wc.hbrBackground =(HBRUSH)GetStockObject(0);//LTGRAY_BRUSH);
		wc.hIcon=LoadIcon(NULL,IDI_WINLOGO);
		wc.hCursor=LoadCursor(NULL,IDC_ARROW);
		wc.cbClsExtra =0;
		wc.cbWndExtra =0;
		wc.hInstance=hi;
		if(!RegisterClass(&wc))return FALSE;
	}
	hwnd=CreateWindow( "BlueTea","ÔÇí ÇáÈÑÇÏ ÇáÃÒÑÞ",
				WS_OVERLAPPEDWINDOW,00,00,
				800,550,NULL,NULL,hi,0);
    ShowWindow(hwnd,ncmd);
	UpdateWindow(hwnd);
	MSG msg;
	while(GetMessage(&msg,hwnd,0,0)>0)
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
	return TRUE;
}
//--------------
LRESULT WINAPI WndProc(HWND hwnd,UINT umsg,WPARAM wp,LPARAM lp)
{
	HDC hdc;
	int h,y;
	COLORREF color=RGB(0,0,250);
	vector a,b,s,d,ss,f,vrp,vpn,vup;
	cop(250,194,200);
	vup(0,-1,0);
	vpn(0,0,1);
	vrp(110,150,-40);
	/*kamb(1,0,0);*/kamb(0.4,0.4,0.4);
	/*Ia(1,0,0);*/Ia(0.8,0.8,0.8);
	l(10,80,300);
	kdiff(0.7,0.7,0.7);
	kspec(0.4,0.4,0.4);
	Is(0.7,0.1,0.7);
	p11=trans(140,170,0);
	p=getcamera(cop,vrp,vpn,vup,0,80,0,80);
	//p=p11*p;
	switch(umsg)
	{

	case WM_LBUTTONDOWN:
		{
			hdc=GetDC(hwnd);
			//p=getcamera(cop,vrp,vpn,vup,-40,40,-40,40);
			readme(hwnd,hdc,color,p);
			dis(hdc,1);
			ReleaseDC(hwnd,hdc);

		}

	break;
	case WM_DESTROY:
		PostQuitMessage(0);break;
	default:
		return DefWindowProc(hwnd,umsg,wp,lp);
	}
return 0l;
}
//==================================
float myabs(float x)
{
	return (x>=0)?x:-x;
}
void swaping(float& x,float& y)
{
	float temp;
	temp=x;
	x=y;
	y=temp;
}
//===================================
void dda(HDC hdc,float x1,float y1,float x2,float y2,COLORREF color)
{
	float x=x1,y=y1;
	float dx=x2-x1;
	float dy=y2-y1;
	float m=dy/dx;
	float absm=myabs(m);
	if(absm<=1)
	{
		if(x2<x1)
		{
			swaping(x1,x2);
			swaping(y1,y2);
			x=x1;
			y=y1;
		}
		SetPixel(hdc,x,y,color);
		while(x<x2)
		{
			y=y+m;
			x++;
			SetPixel(hdc,x,y,color);
		}
	}
	else
	{
		if(y2<y1)
		{
			swaping(y1,y2);
			swaping(x1,x2);
			y=y1;
			x=x1;
		}
		SetPixel(hdc,x,y,color);
		while(y<y2)
		{
			x=x+1/m;
			y++;
			SetPixel(hdc,x,y,color);
		}
	}
}
