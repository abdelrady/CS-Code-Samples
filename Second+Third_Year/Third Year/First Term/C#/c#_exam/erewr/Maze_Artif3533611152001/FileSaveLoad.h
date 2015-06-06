/****************************************************************************
*	Maze A.I.		Assignment 2											*
*	Created By Wade Arnold		Email: c---8@home.com						*
*	October 2001															*
*	Instructor: Ean Bull													*
****************************************************************************/

#if !defined(AFX_FILESAVELOAD_H__27D6B5B0_B289_464D_869A_C0626F2860F7__INCLUDED_)
#define AFX_FILESAVELOAD_H__27D6B5B0_B289_464D_869A_C0626F2860F7__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// FileSaveLoad.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CFileSaveLoad dialog

class CFileSaveLoad : public CFileDialog
{
	DECLARE_DYNAMIC(CFileSaveLoad)

public:
	CFileSaveLoad(BOOL bOpenFileDialog, // TRUE for FileOpen, FALSE for FileSaveAs
		LPCTSTR lpszDefExt = NULL,
		LPCTSTR lpszFileName = NULL,
		DWORD dwFlags = OFN_HIDEREADONLY | OFN_OVERWRITEPROMPT,
		LPCTSTR lpszFilter = NULL,
		CWnd* pParentWnd = NULL);

protected:
	//{{AFX_MSG(CFileSaveLoad)
		// NOTE - the ClassWizard will add and remove member functions here.
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_FILESAVELOAD_H__27D6B5B0_B289_464D_869A_C0626F2860F7__INCLUDED_)
