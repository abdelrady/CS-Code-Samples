#include<iostream.h>
#include<fstream.h>

void ReadImage(char* fileName)
{
	ofstream fw;
	fw.open("Test.txt",0,ios::out);
	//fw.seekp(0,ios::beg);
	

	fstream fs;
	fs.open(fileName,ios::in | ios::binary );
	fs.seekg(0,ios::beg);
	char ch;
	fs>>ch;
	//fs.read(reinterpret_cast<char*>(ch),1);
	//fs>>ch;
	//fs.flush();
	cout<<ch<<endl;
	fw<<ch;
	fw.flush();
	
	//	fw<<"Right";

		fw.flush();
	//	fw.write(reinterpret_cast<char*>('Q'),2);

	char str[10];
	//strcpy(str,((int)ch[0]));
	if((int)ch==66)
	{
		cout<<"Right";
	
	}
	fs.close();
	fw.close();

	//TextOut(hdc,30,30,ch,0);
//	TextOut(hdc,10,30,"Welcome Back",0);
//	MessageBox(hwnd,ch,"gggggg",0);

//	fs.close();
	
}

void main()
{
		ReadImage("E:\\untitled.bmp");
}