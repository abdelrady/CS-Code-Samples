
#include<String.h>
//using namespace std;
#include<iostream.h>
void main()
{
	char ch1[40],ch2[40];
	//string str1 ,str2;

	cin>>ch1;
	cin>>ch2;

	//cout<<str1<<endl<<str2;
	cout<<static_cast<int>(ch1[0])<<static_cast<int>(ch1[1])<<static_cast<int>(ch1[2]);
int x,y;
	char mul[40][80];
int carry=0;int mul2;
	for(int i=0;i<40;i++)
	{
		y=static_cast<int>(ch2[i])-48;
		for(int j=i;j<40+i;j++)
		{
			x=static_cast<int>(ch1[j])-48;
			mul2=(x*y)+carry;
			carry=0;
			while(mul2>9)
			{
				mul2-=10;
				carry+=1;
			}
			mul[i][j]=mul2;
			if(j==39+i)mul[i][j+1]=carry;
		}
	}
	carry=0;
	char ch3[81];int mul4=0;
	for(i=0;i<80;i++)
	{
		ch3[i]+=carry;
		carry=0;
		for(int j=0;j<40;j++)
		{
			ch3[i]+=(static_cast<int> (mul[j][i]));
			mul4=(static_cast<int>(ch3[i]));
			while(mul4>9)
			{
				mul4-=10;
				carry+=1;
			}
			ch3[i]=mul4;
		}
		cout<<(ch3[i]+48);
	}



}