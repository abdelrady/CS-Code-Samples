/*
Authors: David Nishimoto and Thomas Lee
Website: http://www.listensoftware.com
Program: Cube Drop
*/

#if !defined(AFX_3DFONT_H__4431AE05_2C62_11D3_955D_8422F5C00000__INCLUDED_)
#define AFX_3DFONT_H__4431AE05_2C62_11D3_955D_8422F5C00000__INCLUDED_

#if _MSC_VER >= 1000
#pragma once
#endif // _MSC_VER >= 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"       // main symbols

/////////////////////////////////////////////////////////////////////////////
// CMy3DFontApp:
// See 3DFont.cpp for the implementation of this class
//

class CMy3DFontApp : public CWinApp
{
public:
	CMy3DFontApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CMy3DFontApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CMy3DFontApp)
	afx_msg void OnAppAbout();
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Developer Studio will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_3DFONT_H__4431AE05_2C62_11D3_955D_8422F5C00000__INCLUDED_)
