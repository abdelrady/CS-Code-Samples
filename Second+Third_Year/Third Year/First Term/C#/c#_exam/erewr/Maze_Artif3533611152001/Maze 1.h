/****************************************************************************
*	Maze A.I.		Assignment 2											*
*	Created By Wade Arnold		Email: c---8@home.com						*
*	October 2001															*
*	Instructor: Ean Bull													*
****************************************************************************/

// Maze 1.h : main header file for the MAZE 1 application
//
#if !defined(AFX_MAZE1_H__01F409F6_49E0_48B2_8F1B_C876671A0559__INCLUDED_)
#define AFX_MAZE1_H__01F409F6_49E0_48B2_8F1B_C876671A0559__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols



/////////////////////////////////////////////////////////////////////////////
// CMaze1App:
// See Maze 1.cpp for the implementation of this class
//

class CMaze1App : public CWinApp
{
public:
	CMaze1App();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CMaze1App)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CMaze1App)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_MAZE1_H__01F409F6_49E0_48B2_8F1B_C876671A0559__INCLUDED_)
