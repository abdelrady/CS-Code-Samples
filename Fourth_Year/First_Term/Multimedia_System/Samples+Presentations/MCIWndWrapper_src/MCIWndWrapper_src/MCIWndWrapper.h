// MCIWndWrapper.h : main header file for the MCIWNDWRAPPER application
//

#if !defined(AFX_MCIWNDWRAPPER_H__4CDF5D90_8036_4B1D_936C_E8221914140C__INCLUDED_)
#define AFX_MCIWNDWRAPPER_H__4CDF5D90_8036_4B1D_936C_E8221914140C__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CWrapperApp:
// See MCIWndWrapper.cpp for the implementation of this class
//

class CWrapperApp : public CWinApp
{
public:
	CWrapperApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CWrapperApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CWrapperApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_MCIWNDWRAPPER_H__4CDF5D90_8036_4B1D_936C_E8221914140C__INCLUDED_)
