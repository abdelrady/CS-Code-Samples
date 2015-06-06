
/* Lawrenceville Press bool type IMPLEMENTATION */
/*	October 1997                                 */

#include <lvp\string.h>

//-----------------------------------------------------
bool::bool()
{
	value = false;
}

//-----------------------------------------------------
bool::bool (int i)
{
	if (i == 0)
		value = false;
	else
		value = true;
}

//-----------------------------------------------------
bool::operator = (const int intval)
{
	if (intval == 0)
		value = false;
	else
		value = true;
	return (value);
}

//-----------------------------------------------------
bool::operator int() const
{
	return (value);
}

//-----------------------------------------------------
ostream & operator << (ostream & os, const bool & b)
// postcondition: bool b written to os
{
	 if (b.value==true)
		 os << "true";
	 else
		 os << "false";
	 return (os);
}

//-----------------------------------------------------
istream & operator >> (istream & is, bool & b)
// postcondition: bool b read from is and stored in b
{
	 String Bchar;
	 is >> Bchar;
	 if ((Bchar == "false") || (Bchar == "FALSE"))
		b.value = false;
	 else
		b.value = true;
	 return (is);
}
