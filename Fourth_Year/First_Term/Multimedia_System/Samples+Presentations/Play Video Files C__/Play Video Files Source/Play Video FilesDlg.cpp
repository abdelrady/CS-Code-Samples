// Play Video FilesDlg.cpp : implementation file
//

#include "stdafx.h"
#include "Play Video Files.h"
#include "Play Video FilesDlg.h"
#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#include<Mmsystem.h>
#include <digitalv.h>
#include<Vfw.h>
#include<Winuser.h>
#include <Windows.h>


#endif


/////////////////////////////////////////////////////////////////////////////
// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();
	
	// Dialog Data
	//{{AFX_DATA(CAboutDlg)
	enum { IDD = IDD_ABOUTBOX };
	//}}AFX_DATA
	
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CAboutDlg)
protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL
	
	// Implementation
protected:
	//{{AFX_MSG(CAboutDlg)
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
	//{{AFX_DATA_INIT(CAboutDlg)
	//}}AFX_DATA_INIT
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CAboutDlg)
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
//{{AFX_MSG_MAP(CAboutDlg)
// No message handlers
//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CPlayVideoFilesDlg dialog

CPlayVideoFilesDlg::CPlayVideoFilesDlg(CWnd* pParent /*=NULL*/)
: CDialog(CPlayVideoFilesDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CPlayVideoFilesDlg)
	m_FileName = _T("");
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CPlayVideoFilesDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CPlayVideoFilesDlg)
	
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CPlayVideoFilesDlg, CDialog)
//{{AFX_MSG_MAP(CPlayVideoFilesDlg)
ON_WM_SYSCOMMAND()
ON_WM_PAINT()
ON_WM_QUERYDRAGICON()
ON_COMMAND(ID_FILE_OPEN, OnFileOpen)
ON_COMMAND(ID_FILE_PLAY, OnFilePlay)
ON_WM_DROPFILES()
ON_COMMAND(ID_FILE_PUSE, OnFilePuse)
	ON_COMMAND(ID_FILE_RESUME, OnFileResume)
	ON_COMMAND(ID_FILE_STOP, OnFileStop)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CPlayVideoFilesDlg message handlers

BOOL CPlayVideoFilesDlg::OnInitDialog()
{
	CDialog::OnInitDialog();
	
	// Add "About..." menu item to system menu.
	
	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);
	
	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}
	
	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon
	
	// TODO: Add extra initialization here
	
	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CPlayVideoFilesDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CPlayVideoFilesDlg::OnPaint() 
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting
		
		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);
		
		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;
		
		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CPlayVideoFilesDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}
void CPlayVideoFilesDlg::OnFileOpen() 
{
	UpdateData(1);
	TCHAR szFilter[]= _T("AVI Files (*.avi)|*.avi|All Files |*.*||");
	CFileDialog MediaFile(TRUE, "AVI Files","*.avi",OFN_FILEMUSTEXIST | OFN_PATHMUSTEXIST | OFN_LONGNAMES,szFilter);
	
	TCHAR szTitle[]=_T("Open File");
	MediaFile.m_ofn.lpstrTitle=szTitle;
	if(MediaFile.DoModal() == IDOK)		
	{	
		m_FileName=MediaFile.GetPathName();
		::SetWindowText(this->m_hWnd ,m_FileName);
	}	



	UpdateData(0);
	
}

void CPlayVideoFilesDlg::OnFilePlay() 
{
	CStatic* Border = (	CStatic*) GetDlgItem(IDC_STATIC);
	
	Border->Invalidate(1);
	
	Open.lpstrElementName =(char* )(LPCTSTR) m_FileName;  // Set the filename. 
	
	Open.hWndParent = Border->m_hWnd;					  // Give a window handle. 
	
	if (mciSendCommand(0, MCI_OPEN,(DWORD)(MCI_OPEN_ELEMENT|MCI_DGV_OPEN_PARENT),(DWORD)(LPSTR)&Open) == 0)
	{ 			
		Window.hWnd = Border->m_hWnd; 
		DeviceID =  Open.wDeviceID;
		mciSendCommand(Open.wDeviceID, MCI_WINDOW, MCI_DGV_WINDOW_HWND,(DWORD)(LPSTR)&Window); 
		
		
		Play.dwFrom = 0;
		mciSendCommand(Open.wDeviceID, MCI_PLAY, 0,(unsigned long)&Play);
		
	} 	
	
}

void CPlayVideoFilesDlg::OnDropFiles(HDROP hDropInfo) 
{
	char lpszFile[600];
	DragQueryFile (hDropInfo, 0, lpszFile, sizeof (lpszFile));
	m_FileName = lpszFile;

	CStatic* Border = (	CStatic*) GetDlgItem(IDC_STATIC);
	
	Border->Invalidate(1);
	
	MCI_DGV_OPEN_PARMS Open; 	
	Open.lpstrElementName =(char* )(LPCTSTR) m_FileName;  // Set the filename.   
	Open.hWndParent = Border->m_hWnd;					  // Give a window handle. 
	
	if (mciSendCommand(0, MCI_OPEN,(DWORD)(MCI_OPEN_ELEMENT|MCI_DGV_OPEN_PARENT),(DWORD)(LPSTR)&Open) == 0)
	{ 
		MCI_DGV_WINDOW_PARMS Window; 		
		Window.hWnd = Border->m_hWnd; 
		DeviceID = Open.wDeviceID;
		mciSendCommand(Open.wDeviceID, MCI_WINDOW, MCI_DGV_WINDOW_HWND,(DWORD)(LPSTR)&Window); 
		MCI_DGV_PLAY_PARMS Play;   
		Play.dwFrom = 0;
		mciSendCommand(Open.wDeviceID, MCI_PLAY, 0,(unsigned long)&Play);
		
	} 	
	CDialog::OnDropFiles(hDropInfo);
}
void CPlayVideoFilesDlg::OnFilePuse() 
{
	UINT RetValue = mciSendCommand(DeviceID,MCI_PAUSE,0,NULL);
	if(RetValue!=0)
	{	
		MessageBox(GetError(RetValue));
	}

}

void CPlayVideoFilesDlg::OnFileResume() 
{
	UINT RetValue =mciSendCommand(DeviceID,MCI_RESUME,0,NULL);	
	if(RetValue!=0)
	{	
		MessageBox(GetError(RetValue));
	}
 
}

char * CPlayVideoFilesDlg::GetError(UINT mciError)
{
	char * Errorstr = new char[600];
	mciGetErrorString(mciError,Errorstr,600);
	return Errorstr;
}

void CPlayVideoFilesDlg::OnFileStop() 
{
 
	UINT RetValue = mciSendCommand( DeviceID, MCI_STOP, 0,NULL);
	if(RetValue!=0)
	{	
		MessageBox(GetError(RetValue));
	} 
	
}
