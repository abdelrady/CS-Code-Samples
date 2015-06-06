
/*		Lawrenceville Press queue type DECLARATION	             */
/*    June 1997, updated March 1999  comments updated           */
/*                                                              */
/*		The queue class is based on the class apqueue defined     */
/*		for use in the AP Computer Science courses.               */
/*                                                              */
/*		Inclusion of the C++ classes defined for use in the       */
/*		Advanced Placement Computer Science courses does not      */
/*		constitute endorsement of the other material in           */
/*		"A Guide to Programming in C++" (Lawrenceville Press,     */
/*		June 1997) by the College Board, Educational Testing      */
/*		Service, or the AP Computer Science Development Committee.*/
/*	  	APCS developed queue class based on Mark Weiss'           */
/*		Algorithms, Data Structures, and Problem Solving with C++ */

#ifndef _QUEUE_H
#define _QUEUE_H

// comment line below if bool is a built-in type
#include <lvp\bool.h>

// *******************************************************************
// Last Revised: 8/14/98
//
// APCS queue class
// *******************************************************************

#include <lvp\vector.h>                     // used to implement queue

template <class itemType>
class queue
{
  public:

  // constructors/destructor

    queue( );                                 // construct empty queue
    queue( const queue & q );                 // copy constructor
    ~queue( );                                // destructor

  // assignment

    const queue & operator = ( const queue & rhs );

  // accessors

    const itemType & front( )   const;        // return front (no dequeue)
    bool             isEmpty( ) const;        // return true if empty else false
    int              length( )  const;        // return number of elements in queue

  // modifiers

    void enqueue( const itemType & item );    // insert item (at rear)
    void dequeue( );                          // remove first element
    void dequeue( itemType & item );          // combine front and dequeue
    void makeEmpty( );                        // make queue empty

   private:
	
    int mySize;                    // # of elts currently in queue
    int myFront;                   // index of first element
    int myBack;                    // index of last element
	 vector<itemType> myElements; // internal storage for elements

        // private helper functions
    void DoubleQueue();              // double storage for myElements
    void Increment(int & val) const; // add one with wraparound 
};

// *******************************************************************
// Specifications for queue functions
//
// Any violation of a function's precondition will result in an error message
// followed by a call to exit.
//
// constructors/destructor
//
//  queue( )
//     postcondition: the queue is empty
//
//  queue( const queue & q )
//     postcondition: queue is a copy of q
//
//  ~queue( )
//     postcondition: queue is destroyed
//
// assignment
//
//  const queue & operator = ( const queue & rhs )
//     postcondition: normal assignment via copying has been performed
//
// accessors
//
//  const itemType & front( ) const
//     precondition: queue is [e1, e2, ..., en] with n >= 1
//     postcondition: returns e1
//
//  bool isEmpty( ) const
//     postcondition: returns true if queue is empty, false otherwise
//
//  int length( ) const
//     precondition: queue is [e1, e2, ..., en] with n >= 0
//     postcondition:  returns n
//
// modifiers:
//
//  void enqueue( const itemType & item )
//     precondition: queue is [e1, e2, ..., en] with n >= 0
//     postcondition: queue is [e1, e2, ..., en, item]
//
//  void dequeue( )
//     precondition: queue is [e1, e2, ..., en] with n >= 1
//     postcondition: queue is [e2, ..., en]
//
//  void dequeue( itemType & item )
//     precondition: queue is [e1, e2, ..., en] with n >= 1
//     postcondition:  queue is [e2, ..., en] and item == e1
//
//  void makeEmpty( )
//     postcondition: queue is empty
//
// Examples for use:
//
//    queue<int> iqueue;             // creates empty queue of integers
//    queue<double> dqueue           // creates empty queue of doubles

#include <lvp\queue.cpp>


#endif


