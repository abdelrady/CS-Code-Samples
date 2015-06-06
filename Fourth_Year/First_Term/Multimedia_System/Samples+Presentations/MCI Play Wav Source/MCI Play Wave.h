// MCI Play Wave.h : main header file for the MCI PLAY WAVE application
//

#if !defined(AFX_MCIPLAYWAVE_H__4114DD9E_02B6_4E15_978B_E740DF0E6845__INCLUDED_)
#define AFX_MCIPLAYWAVE_H__4114DD9E_02B6_4E15_978B_E740DF0E6845__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CMCIPlayWaveApp:
// See MCI Play Wave.cpp for the implementation of this class
//

class CMCIPlayWaveApp : public CWinApp
{
public:
	CMCIPlayWaveApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CMCIPlayWaveApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CMCIPlayWaveApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_MCIPLAYWAVE_H__4114DD9E_02B6_4E15_978B_E740DF0E6845__INCLUDED_)
