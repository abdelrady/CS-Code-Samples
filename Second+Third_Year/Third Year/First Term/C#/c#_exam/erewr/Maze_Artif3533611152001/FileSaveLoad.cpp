// FileSaveLoad.cpp : implementation file
//

#include "stdafx.h"
#include "Maze 1.h"
#include "FileSaveLoad.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CFileSaveLoad

IMPLEMENT_DYNAMIC(CFileSaveLoad, CFileDialog)

CFileSaveLoad::CFileSaveLoad(BOOL bOpenFileDialog, LPCTSTR lpszDefExt, LPCTSTR lpszFileName,
		DWORD dwFlags, LPCTSTR lpszFilter, CWnd* pParentWnd) :
		CFileDialog(bOpenFileDialog, lpszDefExt, lpszFileName, dwFlags, lpszFilter, pParentWnd)
{
}


BEGIN_MESSAGE_MAP(CFileSaveLoad, CFileDialog)
	//{{AFX_MSG_MAP(CFileSaveLoad)
		// NOTE - the ClassWizard will add and remove mapping macros here.
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

