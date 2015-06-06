/*    Lawrenceville Press TopListClass type IMPLEMENTATION */
/*		September 1998                                         */

//-----------------------------------------------------
TopListClass::TopListClass(String filename, int MaxItemsArg):
	MaxItems(MaxItemsArg), NameList(MaxItemsArg), ScoreList(MaxItemsArg),
	FN(filename)
/* Post: TopListClass object contents have been loaded from file
	if it exists, or loaded with empty items if not.              */
{
	fstream File(FN.c_str(), ios::in | ios::nocreate);

	if (File.fail()) {
		fstream File(FN.c_str(), ios::in);
		for (int i=0; i<MaxItems; i++){
			NameList[i] = "Empty";
			ScoreList[i] = 0;
		}
	}
	else {
		for (int i=0; i<MaxItems; i++){
			getline(File, NameList[i]);
			File >> ScoreList[i];
			File.ignore();
		}
		File.close();
	}
}
//-----------------------------------------------------
TopListClass::~TopListClass()
/* Pre: TopListClass object exists
	Post: object destroyed, and data stored */
{
	fstream File(FN.c_str(), ios::out);

	if (File.fail()) {
		cout << "Error opening file to save!" << FN << endl;
	}
	else {
		for (int i=0; i < MaxItems; i++){
			File << NameList[i] << endl;
			File << ScoreList[i] << endl;
		}
		File.close();
	}
}
//-----------------------------------------------
String TopListClass::GetName(int Rank) const
/* Pre: Rank in range 1..MaxItems
	Post: Name whose score is in given Rank is returned */
{
	return (NameList[Rank-1]);
}
//-----------------------------------------------
long TopListClass::GetScore(int Rank) const
/* Pre: Rank in range 1..MaxItems
	Post: Score in given Rank is returned */
{
	return (ScoreList[Rank-1]);
}
//-----------------------------------------------
void TopListClass::AddItem(long Score, String Name)
/* Post: Score/Name added to TopList object if Score
			is greater than current lowest in list */
{
	if (Score > ScoreList[MaxItems-1]){
		int Pos = 0;
		while (ScoreList[Pos] > Score)
			Pos++;
		for (int NewPos=MaxItems-1; NewPos>Pos; NewPos--){
			ScoreList[NewPos] = ScoreList[NewPos-1];
			NameList[NewPos] = NameList[NewPos-1];
		}
		ScoreList[Pos] = Score;
		NameList[Pos] = Name;
	}
}
//------------------------------------------------------
void TopListClass::Clear()
/* Post: TopListClass object has been cleared back to
	empty items.                                       */
{
	for (int i=0; i<MaxItems; i++){
		NameList[i] = "Empty";
		ScoreList[i] = 0;
	}
}
//-----------------------------------------------------
int TopListClass::GetListSize() const
/* Post: Size of the list returned as specified in the
	constructor default = 10)                           */
{
	return (MaxItems);
}
//-----------------------------------------------------
void TopListClass::Display(ostream & os) const
/* Post: TopList names and scores inserted in os one per line;
	os returned                                                 */
{
	for (int i=0; i<MaxItems; i++)
		os << NameList[i] << " " << ScoreList[i] << endl;
}


