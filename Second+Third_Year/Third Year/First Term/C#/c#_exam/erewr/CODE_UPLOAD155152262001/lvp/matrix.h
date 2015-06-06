#ifndef _MATRIX_H
#define _MATRIX_H

/*		Lawrenceville Press string type DECLARATION               */
/*    June 1997, updated March 1999  comments updated           */
/*                                                              */
/*		extends apvector.h to two dimensional "safe"              */
/*		(range-checked) matrices                                  */
/*                                                              */
/*		The matrix class is based on the class apmatrix defined   */
/*		for use in the AP Computer Science courses.               */
/*                                                              */
/*		Inclusion of the C++ classes defined for use in the       */
/*		Advanced Placement Computer Science courses does not      */
/*		constitute endorsement of the other material in           */
/*		"A Guide to Programming in C++" (Lawrenceville Press,     */
/*		June 1997) by the College Board, Educational Testing      */
/*		Service, or the AP Computer Science Development Committee.*/


#include "lvp\vector.h"

// *******************************************************************
// Revised: September 1, 1997
// Revised: 8/14/98  abort changed to exit
//
// APCS matrix class
//
// extends vector.h to two dimensional "safe" (range-checked) matrices
// examples are given at the end of this file
// *******************************************************************

template <class itemType>
class matrix
{
  public:

  // constructors/destructor
    matrix( );                                      // default size 0 x 0
    matrix( int rows, int cols );                   // size rows x cols
    matrix( int rows, int cols,
            const itemType & fillValue );           // all entries == fillValue
    matrix( const matrix & mat );                   // copy constructor
    ~matrix( );                                     // destructor

  // assignment
    const matrix & operator = ( const matrix & rhs );

  // accessors
    int numrows( ) const;                             // number of rows
    int numcols( ) const;                             // number of columns

  // indexing
    const vector<itemType> & operator [ ] ( int k ) const;  // range-checked indexing
    vector<itemType> & operator [ ] ( int k );              // range-checked indexing

  // modifiers
    void resize( int newRows, int newCols );   // resizes matrix to newRows x newCols
                                               // (can result in losing values)
  private:

    int myRows;                             // # of rows (capacity)
    int myCols;                             // # of cols (capacity)
    vector<vector<itemType> > myMatrix; // the matrix of items
};


// *******************************************************************
// Specifications for matrix functions
//
// To use this class, itemType must satisfy the same constraints
// as forvector class.
//
// Any violation of a function's precondition will result in an error  message
// followed by a call to exit.
//
// constructors/destructor
//
//  matrix( );
//     postcondition: matrix of size 0x0 is constructed, and therefore
//                    will need to be resized later
//
//  matrix( int rows, int cols );
//     precondition: 0 <= rows and 0 <= cols
//     postcondition: matrix of size rows x cols is constructed
//
//  matrix( int rows, int cols, const itemType & fillValue );
//     precondition: 0 <= rows and 0 <= cols
//     postcondition: matrix of size rows x cols is constructed
//                    all entries are set by assignment to fillValue after
//                    default construction
//
//  matrix( const matrix<itemType> & mat );
//     postcondition: matrix is a copy of mat
//
//  ~matrix( );
//     postcondition: matrix is destroyed
//
// assignment
//
//  const matrix & operator = ( const matrix & rhs );
//     postcondition: normal assignment via copying has been performed
//                    (if matrix and rhs were different sizes, matrix has 
//                    been resized to match the size of rhs)
//
// accessors
//
//  int numrows( ) const;
//     postcondition: returns number of rows
//
//  int numcols( ) const;
//     postcondition: returns number of columns
//
// indexing
//
//  const vector<itemType> & operator [ ] ( int k ) const;
//     precondition: 0 <= k < number of rows
//     postcondition: returns k-th row
//
//  vector<itemType> & operator [ ] ( int k );
//     precondition: 0 <= k < number of rows
//     postcondition: returns k-th row
//
// modifiers
//
//  void resize( int newRows, int newCols );
//     precondition: matrix size is rows X cols,
//                   0 <= newRows and 0 <= newCols
//     postcondition: matrix size is newRows X newCols;
//                    for each 0 <= j <= min(rows,newRows) and
//                    for each 0 <= k <= min(cols,newCols), matrix[j][k] is
//                    a copy of the original; other elements of matrix are
//                    initialized using the default constructor for itemType
//                    Note: if newRows < rows or newCols < cols,
//                          elements may be lost
//
//  Examples of use:
//
//     matrix<double> dmat( 100, 80 );       // 100 x 80 matrix of doubles
//     matrix<double> dzmat( 100, 80, 0.0 ); // initialized to 0.0
//     matrix<apstring> smat( 300, 1 );      // 300 strings
//     matrix<int> imat;                     // has room for 0 ints

#include "lvp\matrix.cpp"
#endif


