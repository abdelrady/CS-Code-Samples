//////////////////////////////////////////////////////////////////////////////
//
//   PortScanner
//   Efficient TCP port scanner based on TCP half open scanning method.
//
//   Author  : Nagareshwar Y Talekar.
//	 Contact : nsry2002@yahoo.co.in
//	 Date    : 15-6-2004.
//
//   Name :  PortScanner.cpp
//   Description :  Main Application
//
//////////////////////////////////////////////////////////////////////////////




#include "stdafx.h"

#include "PortScanner.h"
#include "PortScannerDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CPortScannerApp

BEGIN_MESSAGE_MAP(CPortScannerApp, CWinApp)
	//{{AFX_MSG_MAP(CPortScannerApp)
	//}}AFX_MSG
	ON_COMMAND(ID_HELP, CWinApp::OnHelp)
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CPortScannerApp construction

CPortScannerApp::CPortScannerApp()
{
}

/////////////////////////////////////////////////////////////////////////////
// The one and only CPortScannerApp object

CPortScannerApp theApp;

/////////////////////////////////////////////////////////////////////////////
// CPortScannerApp initialization

BOOL CPortScannerApp::InitInstance()
{
	// Standard initialization

	
	CPortScannerDlg dlg;
	m_pMainWnd = &dlg;
	int nResponse = dlg.DoModal();
	if (nResponse == IDOK)
	{
	}
	else if (nResponse == IDCANCEL)
	{
	}

	// Since the dialog has been closed, return FALSE so that we exit the
	//  application, rather than start the application's message pump.
	return FALSE;
}
