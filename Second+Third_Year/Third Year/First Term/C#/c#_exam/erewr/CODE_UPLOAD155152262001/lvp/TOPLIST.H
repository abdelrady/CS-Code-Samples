/*    Lawrenceville Press TopListClass type DECLARATION */
/*		October 1997                                      */

#ifndef _TOPLIST_
#define _TOPLIST_

#include <iostream.h>
#include <fstream.h>
#include <lvp\bool.h>
#include <lvp\string.h>
#include <lvp\vector.h>

class TopListClass
{
	public:
		TopListClass(String Filename, int MaxItemsArg=10);
		~TopListClass();

		String GetName(int Rank) const;
		long GetScore(int Rank) const;
		void AddItem(long Score, String Name);
		void TopListClass::Clear();
		int GetListSize() const;
		void Display (ostream & os) const;

	private:
		vector<String> NameList;
		vector<long> ScoreList;
		String FN;  // File name to store data
		int MaxItems;

		// Following are made private to prevent copying of objects
		TopListClass(const TopListClass &T);
		operator=(const TopListClass &T);
};

#include <lvp\toplist.cpp>
#endif
