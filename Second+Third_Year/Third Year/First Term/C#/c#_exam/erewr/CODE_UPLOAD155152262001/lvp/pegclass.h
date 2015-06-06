/*    Lawrenceville Press PegClass type DECLARATION   */
/*    October 1997                                    */

#ifndef _PEGCLASS_
#define _PEGCLASS_

#include <iostream.h>
#include <lvp\vector.h>
#include <lvp\bool.h>

class PegClass {
	public:
		PegClass(); // Not configured; must call SetPeg() later
		PegClass(int Height);
		~PegClass();
		void SetPeg(int Height);
		void AddRing(int Size);
		int RemoveRing();
		int TopRing() const; // Returns size of top Ring
		int RingsOnPeg() const;  // Returns number of Rings on peg
		void ShowAll() const; // Shows _all_ declared and configured pegs
		const PegClass & operator = ( const PegClass & P ); // Assignment

	private:
		struct PegData {  // Data needed for a single Peg
			vector<int> PegStack;  // An array representing the rings
			bool Configured;  //False, if init'ed by default,
									// parameterless constructor
			int NumRings; // Number of rings currently on peg
			int Hgt;   	  // Height of peg
			};

		static vector<PegData> PegList; // List of all Pegs constructed
		static int MaxRingSize; // Used in spacing the pegs
		int MySpot;  // Location of _this_ peg in PegList

		// Copy constructor "hidden" by private definition.
		PegClass(const PegClass &PegClass); // Copy constructor

		void DrawBlanks(int N) const; // Utility function for spacing the Pegs
};

#include <lvp\pegclass.cpp>
#endif

