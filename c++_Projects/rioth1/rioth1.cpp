#include<string>
#include<iostream>
using namespace std;

string nonrioth(int x)
{
	string str="";
	while(x!=0)
	{
		str+=(x%16)<10?(x%16)+48:(x%16)+55;
		x/=16;
	}
	//cout<<str;
	
	return str;
}
string rioth(int x)
{
	string s=((x%16)<10?(x%16)+48:(x%16)+55);
	if(x==0)return "";
	else
		return rioth(x/16)+s;
}
void main()
{
 cout<<rioth(20)<<endl;
}