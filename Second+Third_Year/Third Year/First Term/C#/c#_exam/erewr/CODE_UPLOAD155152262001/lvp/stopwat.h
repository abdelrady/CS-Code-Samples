/*	Lawrenceville Press  March 1998                    */
/* Simple wrapper class to ease use of time facilties */
/*	in dos.h for finding program times.                */

// compiled if Microsoft compiler
#if defined (_MSC_VER)
#include <sys\types.h>
#include <sys\timeb.h>

class StopWatchClass {
	public:
		StopWatchClass(); // Creates and resets watch
		void Reset();  // Resets watch to 0.00
		double Reading(); // Returns current reading on watch
	private:
		struct _timeb MyTime;
	};
//------------------------------------
StopWatchClass::StopWatchClass()
{
	_ftime(&MyTime);
}
//------------------------------------
void StopWatchClass::Reset()
{
	_ftime(&MyTime);
}
//------------------------------------
double StopWatchClass::Reading()
{
	struct _timeb t2;
	_ftime(&t2);
	double diff = (t2.time - MyTime.time)+
		(t2.millitm - MyTime.millitm)/1000.0;
	return diff;
}

#endif

//-------------------------------------------------------------------
// compiled if not Microsoft compiler
#ifndef _MSC_VER
#include <dos.h>

class StopWatchClass {
	public:
		StopWatchClass(); // Creates and resets watch
		void Reset();  // Resets watch to 0.00
		double Reading(); // Returns current reading on watch
	private:
		struct time MyTime;
	};
//------------------------------------
StopWatchClass::StopWatchClass()
{
	gettime(&MyTime);
}
//------------------------------------
void StopWatchClass::Reset()
{
	gettime(&MyTime);
}
//------------------------------------
double StopWatchClass::Reading()
{
	struct time t2;
	gettime(&t2);
	double diff = 3600.0*(t2.ti_hour - MyTime.ti_hour)+
		60.0*(t2.ti_min - MyTime.ti_min)+
		(t2.ti_sec - MyTime.ti_sec)+
		(t2.ti_hund - MyTime.ti_hund)/100.0;
	return diff;
}

#endif



