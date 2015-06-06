#include <iostream.h>
#include <fstream.h>
#include <stdio.h>

void main()
{
	//fstream f;
	//f.open(
	/*FILE* fp1;
	fp1=fopen("text.txt","a");
	for (int i=0;i<3;i++)
	{
		scanf("%d",fp1);
		
	}
	fprintf(fp1,"welcome");
	fclose(fp1);*/
//char* ch;
//int h;
	int a[5][5];

	ofstream fout;
	fout.open("test.txt",ios::out);
	for(int i=1;i<4;i++)
	{
		for(int j=1;j<4;j++)
				fout<<i*j<<" ";	
		fout<<"\n";
	}
	fout.close();

	
	ifstream fin;
	fin.open ("test.txt");
	for( i=1;i<4;i++)
		for(int j=1;j<4;j++)
				fin>>a[i][j];	

for(i=1;i<4;i++)
{
	for(int j=1;j<4;j++)
	{
		cout<<a[i][j]<<" ";
	}
	cout<<endl;
}
	

		//if((i%3)==0)cout<<endl;
	//	f.read(ch,20);
	//	cout<<ch<<ends;
	

		//f.read(ch,1);
		//cout<<h<<ends;
		
	//}
	cout<<endl;
	fin.close();

}