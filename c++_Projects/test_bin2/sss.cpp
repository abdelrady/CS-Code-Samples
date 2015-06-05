#include<iostream.h>
#include<fstream.h>
void main()
{
	char arrch[2];

	ofstream of;
	of.open("test1.txt",ios::out);
	ofstream of2;
	of2.open("test3.txt",ios::out);
	ifstream iff;
	iff.open("E:\\back1.bmp",ios::in | ios::binary);
	
	iff.seekg(1079);
	iff.read(reinterpret_cast<char*>(arrch),sizeof(char));
	
	//for(int i=0;i<10;i++)
	{
		of<<arrch[0];
		of2<<(int)arrch[0]<<endl;
	}
	iff.close();
	of.close();
	of2.close();
}