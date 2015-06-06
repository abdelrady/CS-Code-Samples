
/*    Lawrenceville Press CollegeClass type IMPLEMENTATION */
/*		October 1997                                         */

//-----------------------------------------------------
CollegeClass::CollegeClass()
/* Pre: Database file is in this format:
			Adelphi University
			Garden City
			NY
			Private
			4153    <----Enrollment
			12250   <----Tuition
			6000    <----Room and Board
	Post: Database has been opened, and Current data holds
	the first item in the file.                            */
{
	DBFile.open("colleges.txt",ios::in);
	/* NOTICE: Path may need to be changed depending on environment */

	if (!DBFile) {
		cout << "Error opening College.txt file" << endl;
		abort();
	}
	else {
		GetNext();
		IsValid = true;
	}
}
//-----------------------------------------------------
CollegeClass::~CollegeClass()
/* Pre: CollegeClass object exists
	Post: object destroyed          */
{
	DBFile.close();
}
//-----------------------------------------------
bool CollegeClass::GetNext()
/* Next item becomes Current item
	Post: Values of next item loaded into Current values,
		and true returned. If next item not available,
		false returned and IsValid flag is set to false. */
{
	getline(DBFile, CurrentName);
	if (CurrentName=="END")
		IsValid = false;
	else {
		getline(DBFile, CurrentTown);
		getline(DBFile, CurrentState);
		getline(DBFile, CurrentPubOrPri);
		DBFile >> CurrentEnrollment;
		DBFile.ignore();
		DBFile >> CurrentTuition;
		DBFile.ignore();
		DBFile >> CurrentRoomAndBoard;
		DBFile.ignore();
	}
	return (IsValid);
};
//------------------------------------------------------
bool CollegeClass::CurrentIsValid()
/* Post: true returned iff values are from the file (i.e.
		have not read past the end of the file) */
{
	return(IsValid);
};
//-----------------------------------------------
void CollegeClass::Reset()
/* Moves the current pointer to the start of the file.
	Post: Current values read for first item in database */
{
	DBFile.close();
	DBFile.open("colleges.txt",ios::in);
	/* NOTICE: Path may need to be changed depending on environment */

	if (!DBFile) {
		cout << "Error opening College.txt file" << endl;
		abort();
	}
	else {
		GetNext();
		IsValid = true;
	}
}
//------------------------------------------------------
/* The following access functions  returns  values of
	the current item. If there is no current item (i.e. the
	end of the file has been reached and therefore
	CurrentIsValid() returns false) then they may not be called.
	EXCEPTION: GetName() will return "END".  */
//------------------------------------------------------
String CollegeClass::GetName() const
{
	return (CurrentName);
}
//------------------------------------------------------
String CollegeClass::GetTown() const
{
	return (CurrentTown);
}
//------------------------------------------------------
String CollegeClass::GetState() const
{
	return (CurrentState);
}
//------------------------------------------------------
String CollegeClass::GetPubOrPri() const
{
	return (CurrentPubOrPri);
}
//------------------------------------------------------
long CollegeClass::GetEnrollment() const
{
	return (CurrentEnrollment);
}
//------------------------------------------------------
long CollegeClass::GetTuition() const
{
	return (CurrentTuition);
}
//------------------------------------------------------
long CollegeClass::GetRoomAndBoard() const
{
	return (CurrentRoomAndBoard);
}
//------------------------------------------------------
ostream & operator << (ostream & os, const CollegeClass & C)
/* postcondition: College data inserted in os one per line;
	os returned                                              */
{
	os << C.GetName() << " " <<
			C.GetTown() << " " <<
			C.GetState() << " " <<
			C.GetPubOrPri() << " " <<
			C.GetEnrollment() << " " <<
			C.GetTuition() << " " <<
			C.GetRoomAndBoard() << endl;
	return (os);
}

