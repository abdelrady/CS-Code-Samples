#include<iostream>
//            //for time for srand()
//
#include <ctime>
//#include<ostream>
using namespace std;
//#include<fstream.h>
//#include<stdio.h>

#include<windows.h>


int totalarr[2000][26];
int  fitness[2000];
bool shouldExit;

	char* cities[26]={"assiut","cairo","Alex","mounofieh","luxor","suhag","Alminea","qena","Aswan","bani swef","Ala'riesh","bour sai'd","siena","gharbia","sharqia","giza","ismaielia","Matrouh","faioum","new vally","dagahlieh","red sea ","kafr elshiekh","domiat","banha","sharm Elshiekh"};
	/*1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26};*/

int arr[26][26]={{0,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,1200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
			{100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200},
		{1200,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200,300,400,100,200}};
	
class gene
{

public:
gene()
{
		/*for(int i=1;i<26;i++)
			cities[i-1]=i;*/
for(int x=0;x<1000;x++)
	fitness[x]=10000;

		for(int i=0;i<26;i++)
			{
			for(int j=i+1;j<26;j++)
				arr[j][i]=arr[i][j];
			
			arr[i][i]=0;
			}
/*		fstream::ofstream fout;
		fout.open("tsp.txt",ios::out);

		for(i=0;i<26;i++)
			{
			for(int j=i+1;j<26;j++)
			{
				fout<<arr[i][j]<<" ";
			}
			fout<<endl;
		}
		fout.close();
*/
	/*	for(i=0;i<6;i++)
		{
			for(int j=0;j<26;j++)
			{
				cout<<arr[i][j]<<ends;
			}
			cout<<endl;
		}
	*/	

}
/*bool find_All(int a[])
{
	for(int i=0;i<26;i++)
		for(int j=0;j<26;j++)
		{
			if(a[i]==cities[j])break;
			return false;
		}
}*/

int fitness_calc(int a[])
{
		int total=0;
		for(int i=0;i<25;i++)
			total+=arr[a[i]][a[i+1]];
		return total;
}


bool show_dup(int a[])
{
	for(int i=0;i<26;i++)
		for(int j=i+1;j<25;j++)
			if(a[i]==a[j])return true;

			return false;
}

void print_arr(int a[])
{
	for(int i=0;i<26;i++)
		cout<<a[i]<<ends;
	cout<<endl;
}
void insert_arr(int arr[],int a[])
{
	for(int i=0;i<26;i++)
	{
		arr[i]=a[i];
	}
}
void crossover(int a[],int b[],int c[],int d[])
{

		srand(time(NULL));
	//	int cutpoint;//=rand()%23+1;
		int temp,j=0;
		int should=0;
		
		int cutpoint[501],qq=0;
		for(int k=0;k<501;k++)
			cutpoint[k]=rand()%23+1;

		while(should<500)
		{
		//	Sleep(200);
			should++;

			/*if(shouldExit)
			{
				if((fitness[0]==fitness[1])||(fitness[0]<fitness[1]))
					break;
			}
			
			if(fitness[0]==fitness[1] )
				shouldExit=true;
			*/
		
			insert_arr(totalarr[j++],a);
			//totalarr[j++]=a;
			fitness[j-1]= fitness_calc(a);
			insert_arr(totalarr[j++],b);
			//totalarr[j++]=b;
			fitness[j-1]= fitness_calc(b);
			insert_arr(totalarr[j++],c);
			//totalarr[j++]=c;
			fitness[j-1]= fitness_calc(c);
			insert_arr(totalarr[j++],d);
			//totalarr[j++]=d;
			fitness[j-1]= fitness_calc(d);

			for(int q=0;q<1000;q++)
			{
				if(show_dup(totalarr[q])) fitness[q]=10000;
			}
			//if(show_dup(totalarr[j-3])) fitness[j-3]=10000;
			//if(show_dup(totalarr[j-2])) fitness[j-2]=10000;
			//if(show_dup(totalarr[j-1])) fitness[j-1]=10000;
			
			/*for(int p=0;p<26;p++)
				cout<<fitness[p]<<ends;
			cout<<endl;
			Sleep(1000);*/
			

			int temp2;
			for(int a1=0;a1<1000;a1++)
				for(int b=a1+1;b<1000;b++)
				{
					if(fitness[b]<fitness[a1])
					{
						/*for(int z=0;z<26;z++)
						{
							temp2=totalarr[a1][z];
							totalarr[a1][z]=totalarr[b][z];
							totalarr[b][z]=temp2;
						}*/
						a=totalarr[a1];
						insert_arr(totalarr[a1],totalarr[b]);
						insert_arr(totalarr[b],a);
						

						temp2=fitness[b];
						fitness[b]=fitness[a1];
						fitness[a1]=temp2;
					}
				}

				a=totalarr[0];
				//print_arr(a);
				b=totalarr[1];
				//print_arr(b);
				c=totalarr[2];
				//print_arr(c);
				d=totalarr[3];

		for(int i=cutpoint[qq];i<26;i++)
		{
			temp=b[i];
			b[i]=a[i];
			a[i]=temp;
			/*temp=fitness[j-4];
			fitness[j-4]=fitness[j-3];
			fitness[j-3]=temp;
*/
			temp=d[i];
			d[i]=c[i];
			c[i]=temp;
/*			temp=fitness[j-2];
			fitness[j-2]=fitness[j-1];
			fitness[j-1]=temp;
*/				qq++;
		}
		
		
		//	cout<<endl<<fitness[0];
		//	Sleep(200);
	  	}
		//	for(int f=0;f<501;f++)
		//		cout<<cutpoint[f]<<ends;
	

		for(int s=0;s<26;s++)
			cout<<cities[totalarr[0][s]-1]<<" ";
	//for(s=0;s<100;s++)
	{//		if(show_dup(totalarr[s]))cout<<endl<<"error";
		cout<<endl<<fitness[s];
	}
}
};

void main()
{

	gene g;
	int a[26]={1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26};
	int b[26]={1,9,8,7,6,5,4,3,2,22,21,15,19,20,10,11,12,13,14,16,17,18,23,24,25,26};
	//if(gene.show_dup(b))cout<<"error"<<endl;
	int c[26]={1,2,22,3,4,21,5,6,7,8,9,20,10,11,12,13,14,19,15,16,17,18,23,24,25,26};
	//if(gene.show_dup(c))cout<<"error"<<endl;
	int d[26]={1,9,8,7,6,5,11,4,3,2,10,22,21,15,19,13,20,14,16,17,18,23,24,12,25,26};
	//if(gene.show_dup(d))cout<<"error"<<endl;
	g.crossover(a,b,c,d);
}


