// Play Video Files.h : main header file for the PLAY VIDEO FILES application
//

#if !defined(AFX_PLAYVIDEOFILES_H__0232864D_4166_417D_A8DA_0957032A5253__INCLUDED_)
#define AFX_PLAYVIDEOFILES_H__0232864D_4166_417D_A8DA_0957032A5253__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CPlayVideoFilesApp:
// See Play Video Files.cpp for the implementation of this class
//

class CPlayVideoFilesApp : public CWinApp
{
public:
	CPlayVideoFilesApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CPlayVideoFilesApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CPlayVideoFilesApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_PLAYVIDEOFILES_H__0232864D_4166_417D_A8DA_0957032A5253__INCLUDED_)
