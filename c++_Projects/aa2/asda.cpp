#include<String.h>
#include<iostream.h>
void main()
{
	char ch1[40],ch2[40];
	
	for(int j=0;j<40;j++) //initialization of array ch1,ch2 with zero(Ascii 48)
		{
		ch1[j]=ch2[j]=48;
		}

	cout<<"Enter First Number: ";
	cin>>ch1;
	cout<<"Enter Second Number:";
	cin>>ch2;
	
	char temp;
	for(int i=0;i<40/2;i++)//Swapping to inverse inputs
	{
		temp=ch1[i];
		ch1[i]=ch1[4-i];
		ch1[4-i]=temp;

		temp=ch2[i];
		ch2[i]=ch2[4-i];
		ch2[4-i]=temp;
	}
	

	int x,y;
	char mul[40][80];
	for(i=0;i<40;i++)//Multiplication Matrix is initalized to zero
	{
		for(int j=0;j<80;j++)
		{
			mul[i][j]=0;
		}
	}

	int carry=0;int mul2;
	for(i=0;i<40;i++)
	{
		y=static_cast<int>(ch2[i])-48;
		for(int j=0;j<40;j++)
		{
			x=static_cast<int>(ch1[j])-48;
			mul2=(x*y)+carry;
			carry=0;
			while(mul2>9)
			{
				mul2-=10;
				carry+=1;
			}
			mul[i][j+i]=mul2;
			if(j==39)
			{
				mul[i][j+i+1]=carry;
				carry=0;
			}
		}
	}

	carry=0;
	char ch3[81];int mul4=0;
	
	for(j=0;j<81;j++)		//Initialization With zero's
		{
			ch3[j]=0;
		}


	for(i=0;i<80;i++)//Add all results together
	{
		ch3[i]+=carry;
		carry=0;
		for(int j=0;j<5;j++)
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
		
	}

cout<<"Result Is: ";
	for(i=80;i>0;i--)
	{
		cout<<static_cast<char>(ch3[i]+48);//add 48 to number to display number correctly
	}
	cout<<endl;
}