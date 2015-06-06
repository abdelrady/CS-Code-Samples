/*	Lawrenceville Press Random Library                */
/*	October 1997                                      */
/*	The following code works correctly under BOTH     */
/*	Borland and MSC. The library is only compiled if  */
/*	running under MSC                                 */

#include <iostream.h>
#include <stdlib.h>

//--------RANDOM LIBRARY--------------
//------------------------------------
#if defined(_MSC_VER)
#include <stdlib.h>
#include <time.h>
void randomize()
{
	 time_t t;
	 srand((unsigned) time(&t));
}
//------------------------------------
int random(int limit)
{
	 return rand()%limit;
}
#endif
//------------------------------------
//----END OF RANDOM LIBRARY-----------