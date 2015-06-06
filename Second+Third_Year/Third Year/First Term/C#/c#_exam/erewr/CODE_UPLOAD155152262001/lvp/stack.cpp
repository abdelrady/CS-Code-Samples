/*		Lawrenceville Press stack type IMPLEMENTATION             */
/*    June 1997, updated March 1999  comments updated           */
/*                                                              */
/*		The stack class is based on the class apstack defined     */
/*		for use in the AP Computer Science courses.               */
/*                                                              */
/*		Inclusion of the C++ classes defined for use in the       */
/*		Advanced Placement Computer Science courses does not      */
/*		constitute endorsement of the other material in           */
/*		"A Guide to Programming in C++" (Lawrenceville Press,     */
/*		June 1997) by the College Board, Educational Testing      */
/*		Service, or the AP Computer Science Development Committee.*/


// *******************************************************************
//  Last Revised: 8/14/98  abort changed to exit
//
//  APCS stack class  IMPLEMENTATION
//
//  stack implemented using the APCS vector class
// *******************************************************************

//#include "stack.h"
#include <stdlib.h>

const int SDEFAULT_SIZE = 10;        // default initial stack size

template <class itemType>
stack<itemType>::stack( )
    : myTop(-1),
      myElements(SDEFAULT_SIZE)
     
// postcondition: the stack is empty     
{
    
}

template <class itemType>
stack<itemType>::stack(const stack<itemType> & s)
   : myTop(s.myTop),     
     myElements(s.myElements)

// postcondition: stack is a copy of s     
{
    
}
     
template <class itemType>
stack<itemType>::~stack()
// postcondition: stack is destroyed
{
    // vector destructor frees memory
}

template <class itemType>
const stack<itemType> &
stack<itemType>::operator = (const stack<itemType> & rhs)
// postcondition: normal assignment via copying has been performed
{
    if (this != &rhs)
    {
        myTop = rhs.myTop;
        myElements = rhs.myElements;
    }
    return *this;
}

template <class itemType>
bool
stack<itemType>::isEmpty() const
// postcondition: returns true if stack is empty, false otherwise
{
    return myTop == -1;
}

template <class itemType>
int
stack<itemType>::length() const
// postcondition: returns # of elements currently in stack
{
    return myTop+1;
}

template <class itemType>
void
stack<itemType>::push(const itemType & item)
// precondition: stack is [e1, e2...en] with  n >= 0
// postcondition: stack is [e1, e2, ... en, item]     
{
    if( myTop + 1 >= myElements.length() )   // grow vector if necessary
    {
        myElements.resize(myElements.length() * 2);
    }
    myTop++;                           // new top most element
    myElements[myTop ] = item;
}

template <class itemType>
void
stack<itemType>::pop()
// precondition: stack is [e1,e2,...en] with n >= 1
// postcondition: stack is [e1,e2,...e(n-1)]
{
    if (isEmpty())
    {
        cerr << "error, popping an empty stack" << endl;
        exit(1);
    }
    myTop--;
}

template <class itemType>
void
stack<itemType>::pop(itemType & item)
// precondition: stack is [e1,e2,...en] with n >= 1
// postcondition: stack is [e1,e2,...e(n-1)] and item == en     
{
    if (isEmpty())
    {
        cerr << "error, popping an empty stack" << endl;
        exit(1);
    }
    item = myElements[myTop];
    myTop--;
}

template <class itemType>
const itemType &
stack<itemType>::top() const
// precondition: stack is [e1, e2, ... en] with n >= 1
// postcondition: returns en
{
	 if (isEmpty())
    {
        cerr << "error, popping an empty stack" << endl;
        exit(1);
    }    
    return myElements[myTop];
}

template <class itemType>
void
stack<itemType>::makeEmpty()
// postcondition:  stack is empty     
{
    myTop = -1;    
}
