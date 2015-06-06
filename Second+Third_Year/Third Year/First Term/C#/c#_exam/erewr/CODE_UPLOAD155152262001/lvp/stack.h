#ifndef _STACK_H
#define _STACK_H

/*		Lawrenceville Press stack type DECLARATION                */
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


// comment line below if bool is a built-in type
#include <lvp\bool.h>

// *******************************************************************
//  Last Revised: 8/14/98
//
// APCS stack class
// *******************************************************************

#include <lvp\vector.h>               // used for stack implementation

template <class itemType>
class stack
{
  public:
    
  // constructors/destructor

    stack( );                            // construct empty stack
    stack( const stack & s );          // copy constructor
    ~stack( );                           // destructor

  // assignment

    const stack & operator = ( const stack & rhs );

  // accessors

    const itemType & top( )      const;   // return top element (NO pop)
    bool             isEmpty( )  const;   // return true if empty, else false
    int              length( )   const;   // return number of elements in stack

  // modifiers

    void push( const itemType & item );   // push item onto top of stack
    void pop( );                          // pop top element
    void pop( itemType & item );          // combines pop and top
    void makeEmpty( );                    // make stack empty (no elements)

  private:

    int myTop;                            // index of top element
	 vector<itemType> myElements;        // storage for stack
};

  // **********************************************************************
  //
  // Specifications for stack functions
  //
  // Any violation of a function's precondition will result in an error message
  // followed by a call to exit.
  //
  //
  // constructors/destructor
  //
  //  stack( )
  //    postcondition: the stack is empty
  //
  //  stack( const stack & s )
  //    postcondition: stack is a copy of s
  //
  //  ~stack( )
  //    postcondition: stack is destroyed
  //
  // assignment
  //
  //  const stack & operator = ( const stack & rhs )
  //    postcondition: normal assignment via copying has been performed
  //
  // accessors
  //
  //  const itemType & top( ) const
  //    precondition: stack is [e1, e2, ... en] with n >= 1
  //    postcondition: returns en
  //
  //  bool isEmpty( ) const
  //     postcondition: returns true if stack is empty, false otherwise
  //
  //  int length( ) const
  //     postcondition: returns # of elements currently in stack
  //
  // modifiers
  //
  //  void push( const itemType & item )
  //     precondition: stack is [e1, e2...en] with  n >= 0
  //     postcondition: stack is [e1, e2, ... en, item]
  //
  //  void pop( )
  //     precondition: stack is [e1, e2, ... en] with n >= 1
  //     postcondition: stack is [e1, e2, ... e(n-1)]
  //
  //
  //  void pop(itemType & item )
  //     precondition: stack is [e1,e2,...en] with n >= 1
  //     postcondition: stack is [e1,e2,...e(n-1)] and item == en
  //
  //  void makeEmpty( )
  //     postcondition:  stack is empty
  //
  //  Examples of variable definition
  //
  //    stack<int> istack;                    // creates empty stack of integers
  //    stack<double> dstack;                 // creates empty stack of doubles
  //

#include <lvp\stack.cpp>

#endif 


