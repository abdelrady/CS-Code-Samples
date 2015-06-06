////////////////////////////////////////////////////////////////////////////
//
//
//    Project     : VideoNet version 1.1.
//    Description : Peer to Peer Video Conferencing over the LAN.
//	  Author      :	Nagareshwar Y Talekar ( nsry2002@yahoo.co.in)
//    Date        : 15-6-2004.
//
//
//    File description : 
//    Name    :  VideoNet.cpp
//    Details :  Main application class
//
//
/////////////////////////////////////////////////////////////////////////////

#include "stdafx.h"
#include "VideoNet.h"
#include "VideoNetDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CVideoNetApp

BEGIN_MESSAGE_MAP(CVideoNetApp, CWinApp)
	//{{AFX_MSG_MAP(CVideoNetApp)
	//}}AFX_MSG
	ON_COMMAND(ID_HELP, CWinApp::OnHelp)
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CVideoNetApp construction

CVideoNetApp::CVideoNetApp()
{
}

/////////////////////////////////////////////////////////////////////////////
// The one and only CVideoNetApp object

CVideoNetApp theApp;

/////////////////////////////////////////////////////////////////////////////
// CVideoNetApp initialization

BOOL CVideoNetApp::InitInstance()
{
	if (!AfxSocketInit())
	{
		AfxMessageBox(IDP_SOCKETS_INIT_FAILED);
		return FALSE;
	}

	// Standard initialization

	CVideoNetDlg dlg;
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
