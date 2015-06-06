/*    Lawrenceville Press PegClass type IMPLEMENTATION    */
/*		October 1997                                        */
/*    Revised: March 1999  TopRing calls abort() if there */
/*                         are no rings on the peg        */

// Must initialize static members here
vector<PegClass::PegData> PegClass::PegList;
int PegClass::MaxRingSize = 7;

const PegClass & PegClass::operator = ( const PegClass & P ) // Assignment
{
	PegList[MySpot].PegStack = PegList[P.MySpot].PegStack;
	PegList[MySpot].Hgt = PegList[P.MySpot].Hgt;
	PegList[MySpot].NumRings = PegList[P.MySpot].NumRings;
	PegList[MySpot].Configured = PegList[P.MySpot].Configured;
	return *this;
}
//-------------------------------------------
PegClass::~PegClass()
/* Deletes the peg (by flagging)  */
{
	PegList.resize(PegList.length()-1);
}
//-------------------------------------------
PegClass::PegClass(int Height)
/* Creates a PegClass object with given height.
	Pre:  Height > 0
	Post: Peg is created with given height*/
{
	int spot = PegList.length();
	PegList.resize(PegList.length()+1);
	PegList[spot].PegStack.resize(Height);
	PegList[spot].Hgt = Height;
	PegList[spot].NumRings = 0;
	PegList[spot].Configured = true;
	MySpot = spot;
}
//-------------------------------------------
PegClass::PegClass()
/* Creates an unconfigured PegClass object
	Post: Peg is created */
{
	int spot = PegList.length();
	PegList.resize(PegList.length()+1);
	PegList[spot].Configured = false;
	MySpot = spot;
}
//-------------------------------------------
void PegClass::SetPeg(int Height)
/* Sets the height of a previously unconfigured peg
	Pre:  Height > 0
	Post: Peg is configured with given height */
{
	PegList[MySpot].PegStack.resize(Height);
	PegList[MySpot].Hgt = Height;
	PegList[MySpot].NumRings = 0;
	PegList[MySpot].Configured = true;
}
//-------------------------------------------
int PegClass::RingsOnPeg() const
/* Returns number of rings on peg
	Post: Number of rings on peg returned */
{
	if (!PegList[MySpot].Configured) {
		cout << "Peg not configured!" << endl;
		abort();
		}
	return(PegList[MySpot].NumRings);
}
//-------------------------------------------
void PegClass::AddRing(int Size)
/* Adds a ring of given size to top of peg.
	Pre: 1 <= Size <= MaxRingSize
	Post: Ring has been added to top of peg */
{
	if (!PegList[MySpot].Configured) {
		cout << "Peg not configured!" << endl;
		abort();
		}
	if (PegList[MySpot].NumRings < PegList[MySpot].Hgt &&
			Size <= MaxRingSize &&
			Size > 0) {
		PegList[MySpot].PegStack[PegList[MySpot].NumRings] = Size;
		PegList[MySpot].NumRings++;
		}
	else abort();
}
//-------------------------------------------
int PegClass::RemoveRing()
/* Removes top ring from the peg and returns its size.
	Pre: Peg is not empty
	Post: Top ring removed, and size returned. */
{
	if (!PegList[MySpot].Configured) {
		cout << "Peg not configured!" << endl;
		abort();
		}
	if (PegList[MySpot].NumRings > 0) {
		PegList[MySpot].NumRings--;
		}
	else
		abort();
	return(PegList[MySpot].PegStack[PegList[MySpot].NumRings]);
}
//-------------------------------------------
int PegClass::TopRing() const
/* Returns size of top ring.
	Pre: Peg is not empty
	Post: Size of top ring on peg returned. */
{
	if (!PegList[MySpot].Configured) {
		cout << "Peg not configured!" << endl;
		abort();
		}
	if (PegList[MySpot].NumRings > 0)
		return(PegList[MySpot].PegStack[PegList[MySpot].NumRings-1]);
	else
		abort();
}
//-------------------------------------------
void PegClass::DrawBlanks(int N) const
/* Draws N blanks
	Pre: N >= 0
	Post: N blanks have been drawn */
{
	for (int i=1; i <= N; i++)
		cout << " ";
}
//-------------------------------------------
void PegClass::ShowAll() const
/* Shows all declared and configured pegs
	Post: All configured pegs have been displayed */
{
	int i;
	int PegCount = 0;
	int MaxHgt = 0;
	for (i=0; i < PegList.length() ; i++) {
		if (PegList[i].Configured) {
			PegCount++;
			if (PegList[i].Hgt > MaxHgt)
				MaxHgt = PegList[i].Hgt;
			}
		}
	for (int Row = MaxHgt-1; Row >= 0; Row--) {
		// do a Row
		for (i=0; i < PegList.length() ; i++)

			// Do Peg i in this Row
			if (!PegList[i].Configured)
				; // Do nothing
			else
				if (PegList[i].Hgt > Row) {
					if (PegList[i].NumRings > Row) { // If a Ring on this row
						// Draw a Ring (possibly empty)
						int Col;
						for (Col=(-MaxRingSize); Col <= (-1); Col++)
							if ( PegList[i].PegStack[Row] >= (-Col) )
								cout << "X";
							else
								cout << " ";
						cout << "|";
						for (Col=1; Col <= MaxRingSize; Col++)
							if (PegList[i].PegStack[Row] >= Col)
								cout << "X";
							else
								cout << " ";
						}
					else {
						DrawBlanks(MaxRingSize);
						cout << "|";
						DrawBlanks(MaxRingSize);
						}
					}
				else {
					DrawBlanks(MaxRingSize);
					cout << " ";
					DrawBlanks(MaxRingSize);
					}
			cout << endl;
	}
	for (int Col = 1; Col <= (2*MaxRingSize+1)*PegCount; Col++)
		cout <<"-";
	 cout << endl;
}


