/****************************************************************************
*	Maze A.I.		Assignment 2											*
*	Created By Wade Arnold		Email: c---8@home.com						*
*	October 2001															*
*	Instructor: Ean Bull													*
****************************************************************************/

// Stack.h: interface for the Stack class.
//
//////////////////////////////////////////////////////////////////////

#if !defined(AFX_STACK_H__58254646_59F4_4325_8F06_D454BBC34084__INCLUDED_)
#define AFX_STACK_H__58254646_59F4_4325_8F06_D454BBC34084__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#define Max_Size 241

class Stack  
{
public:

	//Initial variable declarations and function prototypes
	int TheStack[Max_Size];
	int pop();
	bool IsStackFull();
	bool IsStackEmpty();
	void push(int Value);
	bool StackFull;
	bool StackEmpty;
	int Top;
	Stack();
	virtual ~Stack();

};

#endif // !defined(AFX_STACK_H__58254646_59F4_4325_8F06_D454BBC34084__INCLUDED_)
