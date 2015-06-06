/*		Lawrenceville Press vector type IMPLEMENTATION            */
/*    June 1997, updated March 1999  comments updated           */
/*                                                              */
/*		The vector class is based on the class apvector defined   */
/*		for use in the AP Computer Science courses.               */
/*                                                              */
/*		Inclusion of the C++ classes defined for use in the       */
/*		Advanced Placement Computer Science courses does not      */
/*		constitute endorsement of the other material in           */
/*		"A Guide to Programming in C++" (Lawrenceville Press,     */
/*		June 1997) by the College Board, Educational Testing      */
/*		Service, or the AP Computer Science Development Committee.*/
/*                                                              */
/*  	vector class consistent with a subset of the standard C++ */
/*		vector class as defined in the draft ANSI standard        */

// *******************************************************************
//  Revised: January 13,1998
//  Revised: 8/14/98  abort changed to exit
//
//  APCS vector class  IMPLEMENTATION
//
//  see vector.h for complete documentation of functions
//
//  vector class consistent with a subset of the standard C++ vector class
//  as defined in the draft ANSI standard (part of standard template library)
// *******************************************************************


#include <stdlib.h>
#include <assert.h>
#include <iostream.h>
//#include "vector.h"

template <class itemType>
vector<itemType>::vector()
//postcondition: vector has a capacity of 0 items, and therefore it will
//               need to be resized
    : mySize(0),
      myList(0)
{

}

template <class itemType>
vector<itemType>::vector(int size)
// precondition: size >= 0
// postcondition: vector has a capacity of size items
   : mySize(size),
     myList(new itemType[size])
{

}

template <class itemType>
vector<itemType>::vector(int size, const itemType & fillValue)
// precondition: size >= 0
// postcondition: vector has a capacity of size items, all of which are set
//                by assignment to fillValue after default construction
    : mySize(size),
      myList(new itemType[size])
{
    int k;
    for(k = 0; k < size; k++)
    {
        myList[k] = fillValue;
    }
}

template <class itemType>
vector<itemType>::vector(const vector<itemType> & vec)
// postcondition: vector is a copy of vec
    : mySize(vec.length()),
      myList(new itemType[mySize])
{
    int k;
        // copy elements
    for(k = 0; k < mySize; k++){
        myList[k] = vec.myList[k];
    }
}

template <class itemType>
vector<itemType>::~vector ()
// postcondition: vector is destroyed
{
    delete [] myList;
}

template <class itemType>
const vector<itemType> &
vector<itemType>::operator = (const vector<itemType> & rhs)
// postcondition: normal assignment via copying has been performed;
//                if vector and rhs were different sizes, vector
//                has been resized to  match the size of rhs
{
    if (this != &rhs)                           // don't assign to self!
    {
        delete [] myList;                       // get rid of old storage
        mySize = rhs.length();
        myList = new itemType [mySize];         // allocate new storage

            // copy rhs
        int k;
        for(k=0; k < mySize; k++)
        {
            myList[k] = rhs.myList[k];
        }
    }
    return *this;                               // permit a = b = c = d
}

template <class itemType>
int vector<itemType>::length() const
// postcondition: returns vector's size (number of memory cells
//                allocated for vector)
{
    return mySize;
}

template <class itemType>
itemType & vector<itemType>::operator [] (int k)
// description: range-checked indexing, returning kth item
// precondition: 0 <= k < length()
// postcondition: returns the kth item
{

    if (k < 0 || mySize <= k)
    {
        cerr << "Illegal vector index: " << k << " max index = ";
        cerr << (mySize-1) << endl;
        exit(1);
    }
    return myList[k];
}

template <class itemType>
const itemType & vector<itemType>::operator [] (int k) const
// safe indexing, returning const reference to avoid modification
// precondition: 0 <= index < length
// postcondition: return index-th item
// exception: aborts if index is out-of-bounds
{
    if (k < 0 || mySize <= k)
    {
        cerr << "Illegal vector index: " << k << " max index = ";
        cerr << (mySize-1) << endl;
        exit(1);
    }
	 return myList[k];
}

template <class itemType>
void vector<itemType>::resize(int newSize)
// description:  resizes the vector to newSize elements
// precondition: the current capacity of vector is length(); newSize >= 0
// postcondition: the current capacity of vector is newSize; for each k
//                such that 0 <= k <= min(length, newSize), vector[k]
//                is a copy of the original; other elements of vector are
//                initialized using the 0-argument itemType constructor
//                Note: if newSize < length, elements may be lost
{
    int k;
    int numToCopy = newSize < mySize ? newSize : mySize;

         // allocate new storage and copy element into new storage

    itemType * newList = new itemType[newSize];
    for(k=0; k < numToCopy; k++)
    {
        newList[k] = myList[k];
    }
    delete [] myList;                      // de-allocate old storage
    mySize = newSize;                      // assign new storage/size
    myList = newList;
}
