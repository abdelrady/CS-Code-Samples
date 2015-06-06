
/*    Lawrenceville Press CircleClass type DECLARATION  */
/*		October 1997                                      */


#ifndef _CIRCLE_
#define _CIRCLE_

class CircleClass
{
	public:
   	CircleClass();
		void SetRadius(double R);
		double Area() const;
		double Circumference() const;

	private:
		const double PI;
		double Radius;
};

#include <lvp\circle.cpp>
#endif

