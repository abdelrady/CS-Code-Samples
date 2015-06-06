/*    Lawrenceville Press CollegeClass type DECLARATION    */
/*		October 1997                                         */

#ifndef _College_
#define _College_
#include <lvp\bool.h>
#include <lvp\string.h>
#include <iostream.h>
#include <fstream.h>
#include <stdlib.h>

class CollegeClass
{
	public:
		CollegeClass();
		~CollegeClass();

		bool GetNext();        // Move to next college; returns false if fails
		bool CurrentIsValid(); // Returns true only if current item is valid
		void Reset();          // Moves back to the start of the database

		// These functions obtain the information of the current item
		String GetName() const;
		String GetTown() const;
		String GetState() const;
		String GetPubOrPri() const;
		long GetEnrollment() const;
		long GetTuition() const;
		long GetRoomAndBoard() const;

		// Dislays information of the current item (for debugging)
		friend ostream & operator << (ostream &, const CollegeClass &);

	private:
		String CurrentName;
		String CurrentTown;
		String CurrentState;
		String CurrentPubOrPri;
		long CurrentEnrollment;
		long CurrentTuition;
		long CurrentRoomAndBoard;
		fstream DBFile;
		bool IsValid;
};

#include <lvp\college.cpp>
#endif

