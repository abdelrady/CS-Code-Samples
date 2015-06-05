#include<string>
#include<iostream>
using namespace std;

class ComplexNumber
{

	
public:
	double realPart,ImagePart;
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
	void Display()
	{
		cout<<"Complex Number is: "<<this.realPart<<"+"<<this.ImagePart<<"*I"<<endl;
	}
};
void main()
{
	ComplexNumber c(1,3);
	ComplexNumber d(5,4);

	ComplexNumber Addition=c.Add(c,d);
	ComplexNumber subtraction=c.Subtract(c,d);

	cout<<"Addition of: "<<c.Display()<<" And "<<d.Display()<<"Is "<<Addition.Display()<<endl;
	cout<<"subtraction of: "<<c.Display()<<" And "<<d.Display()<<"Is "<<subtraction.Display()<<endl;

}
