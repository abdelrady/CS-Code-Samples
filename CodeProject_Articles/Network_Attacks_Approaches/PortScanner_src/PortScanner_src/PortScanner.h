//////////////////////////////////////////////////////////////////////////////
//
//   PortScanner
//   Efficient TCP port scanner based on TCP half open scanning method.
//
//   Author  : Nagareshwar Y Talekar.
//	 Contact : nsry2002@yahoo.co.in
//	 Date    : 15-6-2004.
//
//   Name :  PortScanner.h
//   Description : Main application 
//
//////////////////////////////////////////////////////////////////////////////


#if !defined(AFX_PORTSCANNER_H__0B6C8884_5499_11D6_888C_000B2B0F84B6__INCLUDED_)
#define AFX_PORTSCANNER_H__0B6C8884_5499_11D6_888C_000B2B0F84B6__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CPortScannerApp:
// See PortScanner.cpp for the implementation of this class
//

class CPortScannerApp : public CWinApp
{
public:
	CPortScannerApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CPortScannerApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CPortScannerApp)
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_PORTSCANNER_H__0B6C8884_5499_11D6_888C_000B2B0F84B6__INCLUDED_)
