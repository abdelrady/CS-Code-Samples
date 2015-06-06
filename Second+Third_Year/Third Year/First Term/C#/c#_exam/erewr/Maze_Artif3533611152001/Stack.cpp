// Stack.cpp: implementation of the Stack class.
//
//////////////////////////////////////////////////////////////////////

#include "stdafx.h"
#include "Maze 1.h"
#include "Stack.h"

#ifdef _DEBUG
#undef THIS_FILE
static char THIS_FILE[]=__FILE__;
#define new DEBUG_NEW
#endif


//////////////////////////////////////////////////////////////////////
// Construction/Destruction
//////////////////////////////////////////////////////////////////////

Stack::Stack()
{
	Top = -1;
	StackFull = false;
	StackEmpty = true;
	for (int x = 0; x < Max_Size; x++)
		TheStack[x] = 0;
}

Stack::~Stack()
{

}

//Function to push values onto the stack
void Stack::push(int Value)
{
	//Increment the top of the stack up
	Top++;

	//Place the value at the new top of the stack
	TheStack[Top] = Value;
}

//Checks if the stack is empty and returns a boolean
bool Stack::IsStackEmpty()
{
	//If the stack is empty return true
	return Top == -1;
		//return true;

	//If it is not empty return false
	//else
		//return false;
}

bool Stack::IsStackFull()
{
	return Top == Max_Size;
		//return true;
	//else
		//return false;
}


//This function pops of and returns the top stack value
int Stack::pop()
{
	//Temporary holder variable
	int temp;

	//Set temp to the value at the top of the stack
	temp = TheStack[Top];

	//Set the top of the stack to 0
	TheStack[Top] = 0;

	//Lower the top of the stack
	Top--;

	//Return what was the top of the stack
	return temp;
		
	
}

