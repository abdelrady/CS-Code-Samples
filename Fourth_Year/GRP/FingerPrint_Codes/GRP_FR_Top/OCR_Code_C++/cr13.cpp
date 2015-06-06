//
//	Character Recognition Written by Dzinleski Jasenko April,2007
//		Copyright (C) 2005-2007 Jasenko Dzinleski 
//
//	This source and Character Recognition apply to GNU General Public License. 
//
//		This program is free software; you can redistribute it
//	and/or modify it under the terms of the GNU General Public License as
//	published by the Free Software Foundation; either version 2 of the
//	License, or (at your option) any later version. 
//
//	This program is distributed in the hope that it will be useful, but
//	WITHOUT ANY WARRANTY; without even the implied warranty of
//	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
//	General Public License for more details. 
//
//	You should have received a copy of the GNU General Public License along
//	with this program; if not, write to the Free Software Foundation, Inc.,
//	51 Franklin Street, Fifth Floor, Boston, MA 02110-1301, USA.

//
// 			24 Bit BMp 100/100 pixels


#include        <stdio.h>
#include        <string.h>
#include        <math.h>

#define		maxp	10000
#define		HLength	55
#define         XRes    100
#define         YRes    100
#define         XOff    10
#define         YOff    10
#define		Step	3
#define         FBits   24
#define         Black   0

bool		df1=false;

int index(char fn1[],char fn2[])
{

	char		infn[255]="in.bmp";
	char		outfn[255]="vect.txt";

	FILE            *f1,*f2;

        int     i,j,k,l,p;
	int	a,b;
	int	a1,b1,a2,b2;
	int	pmax=0,pc=0,amax,bmax,cmax,dmax,emax,fmax,gmax,hmax;

	char     	pa[FBits/8];
	int		is=0;

	long            fi[XRes][YRes];
	int		imx=0,imy=0;
	int            	ii[XRes][YRes][2];

	int	da[maxp][3];
	int	dai=0;

	int	pra[1000][3];
	int	prai=0;

	long	mca[1000][3];
	int	mcai=0;

        char    fbyte;

        int     fn=0,fc=0,fs=0;


	strcpy(infn,fn1);
	strcpy(outfn,fn2);

        f1=fopen(infn,"rb");

	fbyte=getc(f1);++fc;

	while (!feof(f1)&&fc<HLength)
        {
		//printf(" fc:%d-%d-%c",fc,fbyte,fbyte);

		if(fc==19){printf("xresolution:\t%d\n",fbyte);if(fbyte==100){}else{printf("Resolution not supported...\n");return(0);}}
		if(fc==23){printf("yresolution:\t%d\n",fbyte);if(fbyte==100){}else{printf("Resolution not supported...\n");return(0);}}
		if(fc==29){printf("n colors:\t%d\n",fbyte);if(fbyte==24){}else{printf("Colour depth not supported...\n");return(0);}}

		fbyte=getc(f1);++fc;
	}

	fc=1;
	while (!feof(f1))
        {
		pa[is]=fbyte;++is;

		if(FBits/8==fc) 
		{
			fi[imy][imx]=pa[0]<<16;
			fi[imy][imx]|=pa[1]<<8;
			fi[imy][imx]|=pa[2];
			fc=0;is=0;++imx;
			if(imx==XRes){++imy;imx=0;}
		}
		fbyte=getc(f1);++fc;
        }
	//printf("%d %d\n",imy,imx);
	fclose(f1);

	for (i=0;i<YRes;++i){for (j=0;j<XRes;++j){ii[i][j][0]=0;ii[i][j][1]=0;}}
		
	for (i=YRes-1;i>=0;--i)
	{
		for (j=XRes-1;j>=0;--j)
		{
			if(df1){if(fi[i][j]==Black){printf("X");}else{printf("_");}}
			if (fi[i][j]==Black)
			{
                                ii[i][j][0]=YRes-i;
                                ii[i][j][1]=XRes-j; 
			}
		}
		if(df1){printf("\n");}
	}

	for (a=0;a<YRes-YOff;++a)
	{
		for (b=0;b<XRes-XOff;++b)
		{
			for (i=a;i<a+YOff;++i)
			{
				for (j=b;j<b+XOff;++j)
				{
					if(ii[i][j][0]!=0){++pc;}
				}
				if(pmax==0&&(60>pc&&pc>40)){pmax=pc;amax=a;bmax=b;pc=0;}else{if(pmax<pc&&(60>pc&&pc>40)){pmax=pc;amax=a;bmax=b;pc=0;}}			
			}
			if(pmax!=0)
			{
				//printf("pmax=%d y=%d x=%d\n",pmax,amax,bmax);
				da[dai][0]=pmax;
				da[dai][1]=amax;
				da[dai][2]=bmax;
				++dai;
			}	
			pmax=0;pc=0;		
		}		
	}

	for(i=0;i<dai;++i)
	{
		p=da[i][1];pmax=0;a=0;
		for(j=i+1;da[j][1]==p&&j<dai;++j){++a;}
		if(a>=8)
		{
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if(pmax==0){pmax=da[j][0];amax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];amax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[amax][0];
				pra[prai][1]=da[amax][1];
				pra[prai][2]=da[amax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];bmax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];bmax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[bmax][0];
				pra[prai][1]=da[bmax][1];
				pra[prai][2]=da[bmax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if((j>=bmax&&j<=bmax+Step)||(j<=bmax&&j>=bmax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];cmax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];cmax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[cmax][0];
				pra[prai][1]=da[cmax][1];
				pra[prai][2]=da[cmax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if((j>=bmax&&j<=bmax+Step)||(j<=bmax&&j>=bmax-Step)){continue;}
				if((j>=cmax&&j<=cmax+Step)||(j<=cmax&&j>=cmax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];dmax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];dmax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[dmax][0];
				pra[prai][1]=da[dmax][1];
				pra[prai][2]=da[dmax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if((j>=bmax&&j<=bmax+Step)||(j<=bmax&&j>=bmax-Step)){continue;}
				if((j>=cmax&&j<=cmax+Step)||(j<=cmax&&j>=cmax-Step)){continue;}
				if((j>=dmax&&j<=dmax+Step)||(j<=dmax&&j>=dmax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];emax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];emax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[emax][0];
				pra[prai][1]=da[emax][1];
				pra[prai][2]=da[emax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if((j>=bmax&&j<=bmax+Step)||(j<=bmax&&j>=bmax-Step)){continue;}
				if((j>=cmax&&j<=cmax+Step)||(j<=cmax&&j>=cmax-Step)){continue;}
				if((j>=dmax&&j<=dmax+Step)||(j<=dmax&&j>=dmax-Step)){continue;}
				if((j>=emax&&j<=emax+Step)||(j<=emax&&j>=emax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];fmax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];fmax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[fmax][0];
				pra[prai][1]=da[fmax][1];
				pra[prai][2]=da[fmax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if((j>=bmax&&j<=bmax+Step)||(j<=bmax&&j>=bmax-Step)){continue;}
				if((j>=cmax&&j<=cmax+Step)||(j<=cmax&&j>=cmax-Step)){continue;}
				if((j>=dmax&&j<=dmax+Step)||(j<=dmax&&j>=dmax-Step)){continue;}
				if((j>=emax&&j<=emax+Step)||(j<=emax&&j>=emax-Step)){continue;}
				if((j>=fmax&&j<=fmax+Step)||(j<=fmax&&j>=fmax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];gmax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];gmax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[gmax][0];
				pra[prai][1]=da[gmax][1];
				pra[prai][2]=da[gmax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if((j>=bmax&&j<=bmax+Step)||(j<=bmax&&j>=bmax-Step)){continue;}
				if((j>=cmax&&j<=cmax+Step)||(j<=cmax&&j>=cmax-Step)){continue;}
				if((j>=dmax&&j<=dmax+Step)||(j<=dmax&&j>=dmax-Step)){continue;}
				if((j>=emax&&j<=emax+Step)||(j<=emax&&j>=emax-Step)){continue;}
				if((j>=fmax&&j<=fmax+Step)||(j<=fmax&&j>=fmax-Step)){continue;}
				if((j>=gmax&&j<=gmax+Step)||(j<=gmax&&j>=gmax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];hmax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];hmax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[hmax][0];
				pra[prai][1]=da[hmax][1];
				pra[prai][2]=da[hmax][2];
				++prai;
			}
			i+=a;
		}else{
		if(a>=6)
		{
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if(pmax==0){pmax=da[j][0];amax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];amax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[amax][0];
				pra[prai][1]=da[amax][1];
				pra[prai][2]=da[amax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];bmax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];bmax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[bmax][0];
				pra[prai][1]=da[bmax][1];
				pra[prai][2]=da[bmax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if((j>=bmax&&j<=bmax+Step)||(j<=bmax&&j>=bmax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];cmax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];cmax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[cmax][0];
				pra[prai][1]=da[cmax][1];
				pra[prai][2]=da[cmax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if((j>=bmax&&j<=bmax+Step)||(j<=bmax&&j>=bmax-Step)){continue;}
				if((j>=cmax&&j<=cmax+Step)||(j<=cmax&&j>=cmax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];dmax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];dmax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[dmax][0];
				pra[prai][1]=da[dmax][1];
				pra[prai][2]=da[dmax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if((j>=bmax&&j<=bmax+Step)||(j<=bmax&&j>=bmax-Step)){continue;}
				if((j>=cmax&&j<=cmax+Step)||(j<=cmax&&j>=cmax-Step)){continue;}
				if((j>=dmax&&j<=dmax+Step)||(j<=dmax&&j>=dmax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];emax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];emax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[emax][0];
				pra[prai][1]=da[emax][1];
				pra[prai][2]=da[emax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if((j>=bmax&&j<=bmax+Step)||(j<=bmax&&j>=bmax-Step)){continue;}
				if((j>=cmax&&j<=cmax+Step)||(j<=cmax&&j>=cmax-Step)){continue;}
				if((j>=dmax&&j<=dmax+Step)||(j<=dmax&&j>=dmax-Step)){continue;}
				if((j>=emax&&j<=emax+Step)||(j<=emax&&j>=emax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];fmax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];fmax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[fmax][0];
				pra[prai][1]=da[fmax][1];
				pra[prai][2]=da[fmax][2];
				++prai;
			}
			i+=a;
		}else{
		if(a>=4)
		{
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if(pmax==0){pmax=da[j][0];amax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];amax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[amax][0];
				pra[prai][1]=da[amax][1];
				pra[prai][2]=da[amax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];bmax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];bmax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[bmax][0];
				pra[prai][1]=da[bmax][1];
				pra[prai][2]=da[bmax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if((j>=bmax&&j<=bmax+Step)||(j<=bmax&&j>=bmax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];cmax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];cmax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[cmax][0];
				pra[prai][1]=da[cmax][1];
				pra[prai][2]=da[cmax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if((j>=bmax&&j<=bmax+Step)||(j<=bmax&&j>=bmax-Step)){continue;}
				if((j>=cmax&&j<=cmax+Step)||(j<=cmax&&j>=cmax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];dmax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];dmax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[dmax][0];
				pra[prai][1]=da[dmax][1];
				pra[prai][2]=da[dmax][2];
				++prai;
			}
			i+=a;
		}else{
		if(a>=2)
		{
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if(pmax==0){pmax=da[j][0];amax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];amax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[amax][0];
				pra[prai][1]=da[amax][1];
				pra[prai][2]=da[amax][2];
				++prai;
			}
			pmax=0;
			for(j=i+1;da[j][1]==p&&j<dai;++j)
			{
				if((j>=amax&&j<=amax+Step)||(j<=amax&&j>=amax-Step)){continue;}
				if(pmax==0){pmax=da[j][0];bmax=j;}else{if(pmax<da[j][0]){pmax=da[j][0];bmax=j;}}				
			}	
			if(pmax!=0)
			{
				pra[prai][0]=da[bmax][0];
				pra[prai][1]=da[bmax][1];
				pra[prai][2]=da[bmax][2];
				++prai;
			}
			i+=a;
		}else{
			pra[prai][0]=da[i][0];
			pra[prai][1]=da[i][1];
			pra[prai][2]=da[i][2];
			++prai;
		}
		}
		}
		}
	}

	//for(i=0;i<prai;++i)
	//{
	//	printf("pmax=%d y=%d x=%d\n",pra[i][0],pra[i][1],pra[i][2]);
	//}

	for(i=0;i<prai;++i)
	{
		//	1
		l=0;
		a1=pra[i][1];
		for(b1=pra[i][2];b1<-1+pra[i][2]+XOff;++b1)
		{
			if(ii[a1][b1][0]==0&&ii[a1][b1+1][0]!=0){break;}
		}
		a2=pra[i][1]+YOff;
		for(b2=pra[i][2];b2<-1+pra[i][2]+XOff;++b2)
		{
			if(ii[a2][b2][0]==0&&ii[a2][b2+1][0]!=0){break;}
		}
		if(b1<b2){}else{++l;}		
		
		if(l==0)
		{
			mca[mcai][0]=pra[i][1];
			mca[mcai][1]=pra[i][2];
			mca[mcai][2]=b2-b1;
			++mcai;
			continue;
		}

		//	-1
		l=0;
		a1=pra[i][1];
		for(b1=pra[i][2];b1<-1+pra[i][2]+XOff;++b1)
		{
			if(ii[a1][b1][0]!=0&&ii[a1][b1+1][0]==0){break;}
		}
		a2=pra[i][1]+YOff;
		for(b2=pra[i][2];b2<-1+pra[i][2]+XOff;++b2)
		{
			if(ii[a2][b2][0]!=0&&ii[a2][b2+1][0]==0){break;}
		}
		if(b1<b2){}else{++l;}		
		
		if(l==0)
		{
			mca[mcai][0]=pra[i][1];
			mca[mcai][1]=pra[i][2];
			mca[mcai][2]=b2-b1;
			++mcai;
			continue;
		}

		//	2
		l=0;
		a1=pra[i][1];
		for(b1=pra[i][2];b1<-1+pra[i][2]+XOff;++b1)
		{
			if(ii[a1][b1][0]==0&&ii[a1][b1+1][0]!=0){break;}
		}
		a2=pra[i][1]+YOff;
		for(b2=pra[i][2];b2<-1+pra[i][2]+XOff;++b2)
		{
			if(ii[a2][b2][0]==0&&ii[a2][b2+1][0]!=0){break;}
		}
		if(b1>b2){}else{++l;}
		
		if(l==0)
		{
			mca[mcai][0]=pra[i][1];
			mca[mcai][1]=pra[i][2];
			mca[mcai][2]=b1-b2;
			++mcai;
			continue;
		}

		//	-2
		l=0;
		a1=pra[i][1];
		for(b1=pra[i][2];b1<-1+pra[i][2]+XOff;++b1)
		{
			if(ii[a1][b1][0]!=0&&ii[a1][b1+1][0]==0){break;}
		}
		a2=pra[i][1]+YOff;
		for(b2=pra[i][2];b2<-1+pra[i][2]+XOff;++b2)
		{
			if(ii[a2][b2][0]!=0&&ii[a2][b2+1][0]==0){break;}
		}
		if(b1>b2){}else{++l;}
		
		if(l==0)
		{
			mca[mcai][0]=pra[i][1];
			mca[mcai][1]=pra[i][2];
			mca[mcai][2]=b1-b2;
			++mcai;
			continue;
		}

		if(l!=0)
		{
			mca[mcai][0]=pra[i][1];
			mca[mcai][1]=pra[i][2];
			mca[mcai][2]=0;
			++mcai;
		}
	}

	f2=fopen(outfn,"w");
	for(i=0;i<mcai;++i)
	{
		fprintf(f2,"%02d %02d %d\n",mca[i][0],mca[i][1],mca[i][2]);
	}
	fclose(f2);

	return(0);
}

int compare(char fn1[],char fn2[])
{

	char		infn1[255]="ds1.txt";
	char		infn2[255]="ds2.txt";

	FILE            *fin1,*fin2;


        int     i,j,k,l,p,xmin,mini,minc;
	int	a,b,c,d;

	int	f,s;

	int	ra1[1000][3];
	int	ra1i=0;
	int	ra2[1000][3];
	int	ra2i=0;

	int	oa1[1000][3];
	int	oa1i=0;
	int	oa2[1000][3];
	int	oa2i=0;

	int	ma[100][6];
	int	mai=0;

	double	ang1,ang2;
	double	ang11,ang21;
	double	tm,fm;
	int	mtm=0,mfm=0;


	strcpy(infn1,fn1);
	strcpy(infn2,fn2);

        fin1=fopen(infn1,"r");

	fscanf(fin1,"%d %d %d\n",&a,&b,&c);
	while (!feof(fin1))
        {
		//printf("%d-%d-%d\n",a,b,c);
		ra1[ra1i][0]=a;
		ra1[ra1i][1]=b;
		ra1[ra1i][2]=c;
		++ra1i;
		fscanf(fin1,"%d %d %d\n",&a,&b,&c);
	}
	fclose(fin1);

        fin2=fopen(infn2,"r");

	fscanf(fin2,"%d %d %d\n",&a,&b,&c);
	while (!feof(fin2))
        {
		//printf("%d-%d-%d\n",a,b,c);
		ra2[ra2i][0]=a;
		ra2[ra2i][1]=b;
		ra2[ra2i][2]=c;
		++ra2i;
		fscanf(fin2,"%d %d %d\n",&a,&b,&c);
	}
	fclose(fin2);

	xmin=100;
	for(i=0;i<ra1i;++i){if(ra1[i][1]<xmin){xmin=ra1[i][1];mini=i;}}
	for(i=0;i<ra1i;++i){ra1[i][1]-=ra1[mini][1];}

	p=ra1[0][0];
	for(i=0;i<ra1i;++i)
	{
		a=0;for(j=i;ra1[j][0]==ra1[i][0]&&j<ra1i;++j){++a;}
		if(a>1)
		{
			minc=0;
			while(minc<a)
			{
				xmin=100;
				for(j=i;j<i+a&&j<ra1i;++j)
				{
					if(ra1[j][1]==-1){continue;}
					if(ra1[j][1]<xmin){xmin=ra1[j][1];mini=j;}	
				}
				oa1[oa1i][0]=ra1[mini][0]-p;
				oa1[oa1i][1]=ra1[mini][1];
				oa1[oa1i][2]=ra1[mini][2];
				++oa1i;
				ra1[mini][1]=-1;
				++minc;
			}
			i+=a-1;		
		}else{
			oa1[oa1i][0]=ra1[i][0]-p;
			oa1[oa1i][1]=ra1[i][1];
			oa1[oa1i][2]=ra1[i][2];
			++oa1i;
		}
	}

	xmin=100;
	for(i=0;i<ra2i;++i){if(ra2[i][1]<xmin){xmin=ra2[i][1];mini=i;}}
	for(i=0;i<ra2i;++i){ra2[i][1]-=ra2[mini][1];}

	p=ra2[0][0];
	for(i=0;i<ra2i;++i)
	{
		a=0;for(j=i;ra2[j][0]==ra2[i][0]&&j<ra2i;++j){++a;}
		if(a>1)
		{
			minc=0;
			while(minc<a)
			{
				xmin=100;
				for(j=i;j<i+a&&j<ra2i;++j)
				{
					if(ra2[j][1]==-1){continue;}
					if(ra2[j][1]<xmin){xmin=ra2[j][1];mini=j;}	
				}
				oa2[oa2i][0]=ra2[mini][0]-p;
				oa2[oa2i][1]=ra2[mini][1];
				oa2[oa2i][2]=ra2[mini][2];
				++oa2i;
				ra2[mini][1]=-1;
				++minc;
			}
			i+=a-1;		
		}else{
			oa2[oa2i][0]=ra2[i][0]-p;
			oa2[oa2i][1]=ra2[i][1];
			oa2[oa2i][2]=ra2[i][2];
			++oa2i;
		}
	}

	/*
	for(i=0;i<oa1i;++i)
	{
		printf(" %d-%d-%d ",oa1[i][0],oa1[i][1],oa1[i][2]);
	}

	for(i=0;i<oa2i;++i)
	{
		printf(" %d-%d-%d ",oa2[i][0],oa2[i][1],oa2[i][2]);
	}
	*/

	for(i=YOff;i<YRes;i+=YOff)
	{
		for(j=XOff;j<XRes;j+=XOff)
		{
			l=0;mai=0;
			for(a=0;a<oa1i&&a<oa2i;++a)
			{
				if((oa1[a][0]>=i-YOff&&oa1[a][0]<=i)&&((oa1[a][1]>=j-XOff&&oa1[a][1]<=j)))
				{
					ma[mai][0]=oa1[a][0];ma[mai][1]=oa1[a][1];ma[mai][2]=oa1[a][2];
					ma[mai][3]=oa2[a][0];ma[mai][4]=oa2[a][1];ma[mai][5]=oa2[a][2];
					++l;++mai;
					//printf(" %d %d ",oa1[a][2],oa2[a][2]);
				}
			}
			if(l!=0)
			{
				xmin=100;
				for(c=0;c<mai;++c)
				{
					if(xmin>ma[c][1]){xmin=ma[c][1];mini=c;minc=1;}
					if(xmin>ma[c][4]){xmin=ma[c][4];mini=c;minc=4;}
				}
				for(c=0;c<mai;++c){ma[c][1]-=ma[mini][minc];ma[c][4]-=ma[mini][minc];}

				tm=0;fm=0;
				for(c=0;c<mai;++c)
				{
					if(ma[c][2]==0){ang1=3.141/2;}
					if(ma[c][2]==1){ang1=3.141*0.1/2;}
					if(ma[c][2]==2){ang1=3.141*0.2/2;}
					if(ma[c][2]==3){ang1=3.141*0.3/2;}
					if(ma[c][2]==4){ang1=3.141*0.4/2;}
					if(ma[c][2]==5){ang1=3.141*0.5/2;}
					if(ma[c][2]==6){ang1=3.141*0.6/2;}
					if(ma[c][2]==7){ang1=3.141*0.7/2;}
					if(ma[c][2]==8){ang1=3.141*0.8/2;}
					if(ma[c][2]==9){ang1=3.141*0.9/2;}

					if(ma[c][5]==0){ang2=3.141/2;}
					if(ma[c][5]==1){ang2=3.141*0.1/2;}
					if(ma[c][5]==2){ang2=3.141*0.2/2;}
					if(ma[c][5]==3){ang2=3.141*0.3/2;}
					if(ma[c][5]==4){ang2=3.141*0.4/2;}
					if(ma[c][5]==5){ang2=3.141*0.5/2;}
					if(ma[c][5]==6){ang2=3.141*0.6/2;}
					if(ma[c][5]==7){ang2=3.141*0.7/2;}
					if(ma[c][5]==8){ang2=3.141*0.8/2;}
					if(ma[c][5]==9){ang2=3.141*0.9/2;}

					//printf(" %e %e\n",((double)ma[c][1])*sin(ang1),((double)ma[c][4])*sin(ang2));

					for(d=c;d<mai;++d)
					{
						if((int)(((double)ma[c][1])*sin(ang1))+ma[c][0]>=ma[d][0])
						{
							if(ma[d][2]==0){ang11=3.141/2;}
							if(ma[d][2]==1){ang11=3.141*0.1/2;}
							if(ma[d][2]==2){ang11=3.141*0.2/2;}
							if(ma[d][2]==3){ang11=3.141*0.3/2;}
							if(ma[d][2]==4){ang11=3.141*0.4/2;}
							if(ma[d][2]==5){ang11=3.141*0.5/2;}
							if(ma[d][2]==6){ang11=3.141*0.6/2;}
							if(ma[d][2]==7){ang11=3.141*0.7/2;}
							if(ma[d][2]==8){ang11=3.141*0.8/2;}
							if(ma[d][2]==9){ang11=3.141*0.9/2;}					
							break;
						}
					}
					if(d!=mai)
					{
						for(d=c;d<mai;++d)
						{
							if((int)(((double)ma[c][4])*sin(ang2))+ma[c][3]>=ma[d][3])
							{
								if(ma[d][5]==0){ang21=3.141/2;}
								if(ma[d][5]==1){ang21=3.141*0.1/2;}
								if(ma[d][5]==2){ang21=3.141*0.2/2;}
								if(ma[d][5]==3){ang21=3.141*0.3/2;}
								if(ma[d][5]==4){ang21=3.141*0.4/2;}
								if(ma[d][5]==5){ang21=3.141*0.5/2;}
								if(ma[d][5]==6){ang21=3.141*0.6/2;}
								if(ma[d][5]==7){ang21=3.141*0.7/2;}
								if(ma[d][5]==8){ang21=3.141*0.8/2;}
								if(ma[d][5]==9){ang21=3.141*0.9/2;}
								break;
							}
						}					
						if(d!=mai)
						{
							if(0.3+(ang1+ang11)/2.0>=(ang2+ang21)/2.0&&(ang2+ang21)/2.0>=-0.3+(ang1+ang11)/2.0)
							{
								printf("+");++tm;
							}else{
								printf("-");++fm;
							}
							
						}else{
							printf("-");++fm;
						}

					}else{
						printf("-");++fm;
					}
				}
				if(tm>0&&fm>0&&tm/fm>=0.8){++mtm;}else{if(tm>0&&fm==0){++mtm;}else{++mfm;}}
				//printf("\n");				
			}
		}
	}
	if(mtm>=mfm){printf("\n Match...");}else{printf("\n No Match...\n");}
	return(0);
}

int main(int argc,char *argv[])
{
	int		i,j;
	char		cmd[255];
	char		fn1[255];
	char		fn2[255];

	FILE		*f1;

	printf("\n\nCharacter Recognition Written by Dzinleski Jasenko April,2007\n\n");
	printf("OS Win32 VRM 1.0.1\n\n");

	for(i=1;i<argc;++i)
	{
		if(strlen(argv[i])>0)
		{
			for(j=0;j<255;++j){cmd[j]='\0';}
			strcpy(cmd,argv[i]);

			if(cmd[0]=='-'&&strlen(cmd)==2)
			{
				if(cmd[1]=='i')
				{
					for(j=0;j<255;++j){fn1[j]='\0';}
					for(j=0;j<255;++j){fn2[j]='\0';}

					strcpy(fn1,argv[i+1]);
					strcpy(fn2,argv[i+1+1]);

					f1=fopen(fn1,"rb");
					if(f1!=NULL)
					{
						fclose(f1);
						index(fn1,fn2);

					}else{printf("No file!");}
					break;
				}else{
					if(cmd[1]=='c')
					{
						for(j=0;j<255;++j){fn1[j]='\0';}
						for(j=0;j<255;++j){fn2[j]='\0';}

						strcpy(fn1,argv[i+1]);
						strcpy(fn2,argv[i+1+1]);

						f1=fopen(fn1,"rb");
						if(f1!=NULL)
						{
							fclose(f1);
							f1=fopen(fn2,"rb");
							if(f1!=NULL)
							{
								fclose(f1);
								compare(fn1,fn2);

							}else{printf("No file!");}
						}else{printf("No file!");}
						break;
					}else{
						if(cmd[1]=='h')
						{
							printf("\n\nCharacter Recognition Written by Dzinleski Jasenko April,2007\n\n");
							printf("OS Win32 VRM 1.0.1\n\n");
							printf("\n");
							printf("cr13 -i <character_image_file.bmp> <charcter_index_file.txt>\n");
							printf("cr13 -c <charcter_index_file_1.txt> <charcter_index_file_2.txt>\n");
							printf("\n");
							break;
						}else{
							if(cmd[1]=='l'||cmd[1]=='e')
							{	
								printf("\n\nCharacter Recognition Written by Dzinleski Jasenko April,2007\n\n");
								printf("OS Win32 VRM 1.0.1\n\n");
								printf("\n");
								printf("\tThis source and Character Recognition apply to GNU General Public License. \n");
								printf("\t		Copyright (C) 2007 Jasenko Dzinleski \n");
								printf("\n");
								printf("\t	This program is free software; you can redistribute it\n");
								printf("\tand/or modify it under the terms of the GNU General Public License as\n");
								printf("\tpublished by the Free Software Foundation; either version 2 of the\n");
								printf("\tLicense, or (at your option) any later version.\n");
								printf("\n");
								printf("\tThis program is distributed in the hope that it will be useful, but\n");
								printf("\tWITHOUT ANY WARRANTY; without even the implied warranty of\n");
								printf("\tMERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU\n");
								printf("\tGeneral Public License for more details.\n");
								printf("\n");
								printf("\tYou should have received a copy of the GNU General Public License along\n");
								printf("\twith this program; if not, write to the Free Software Foundation, Inc.,\n");
								printf("\t51 Franklin Street, Fifth Floor, Boston, MA 02110-1301, USA.\n");
								printf("\n");
								break;
							}
						}
					}
				}
			}
		}
	}

	return(0);
}