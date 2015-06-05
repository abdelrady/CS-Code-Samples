#include<string>
#include<iostream>
using namespace std;

class ComplexNumber
{

private:
	double realPart,ImagePart;
public:
	
	ComplexNumber()
	{
		realPart=0.0;
		ImagePart=0.0;
	}
	ComplexNumber(double a,double b)
	{
		realPart=a;
		ImagePart=b;
	}
	ComplexNumber Add(ComplexNumber c,ComplexNumber d)
	{
		ComplexNumber e(c.realPart + d.realPart , c.ImagePart + d.ImagePart);
		return e;
	}
	ComplexNumber Subtract(ComplexNumber c,ComplexNumber d)
	{
		ComplexNumber e(c.realPart-d.realPart,c.ImagePart-d.ImagePart);
		return e;
	}
	void Display(ComplexNumber c)
	{
		cout<<" ("<<c.realPart<<")+("<<c.ImagePart<<")*I";
	}
};
void main()
{
	ComplexNumber c(1,3);
	ComplexNumber d(5,4);

	ComplexNumber Addition=c.Add(c,d);
	ComplexNumber subtraction=c.Subtract(c,d);

	cout<<"Addition of: ";
	c.Display(c);
	cout<<" And ";
	d.Display(d);
	cout<<" Is ";
	Addition.Display(Addition);
	cout<<endl;

	cout<<"subtraction of: ";
	c.Display(c);
	cout<<" And ";
	d.Display(d);
	cout<<" Is ";
	subtraction.Display(subtraction);
	cout<<endl;


}