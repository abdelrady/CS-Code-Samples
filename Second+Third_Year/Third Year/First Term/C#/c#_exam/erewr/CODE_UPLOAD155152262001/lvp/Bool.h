/* Lawrenceville Press bool type DECLARATION    */
/*	September 1998                                */

// Avoid compiling if Borland 5.x since it pre-defines bool
#if defined(__BORLANDC__)
	#if __BORLANDC__ >= 0x500
		#define _BOOL_
	#endif
#endif

// Avoid compiling if Visual C++ 5 since it pre-defines bool
#if defined(_MSC_VER)
	#if (_MSC_VER==1100)
		#define _BOOL_
	#endif
#endif

// Avoid compiling if Visual C++ 6 since it pre-defines bool
#if defined(_MSC_VER)
	#if (_MSC_VER==1200)
		#define _BOOL_
	#endif
#endif

#ifndef _BOOL_
#define _BOOL_

#include <iostream.h>

enum boolconst {false, true};  // Must use this order so that false is zero

class bool
{
	public:
		bool ();
		bool (int i);
		friend ostream & operator << (ostream &, const bool &);
		friend istream & operator >> (istream &, bool &);
		operator = (const int intval);
		operator int() const; // const required to allow constant bool
									// to be promoted to integer

		// Note that ||, && etc. work because of automatic
		// promotion to integer

	private:
		boolconst value;
};

#include <lvp\bool.cpp>
#endif


