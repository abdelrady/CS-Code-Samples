// MCI Play WaveDlg.cpp : implementation file
//

#include "stdafx.h"
#include "MCI Play Wave.h"
#include "MCI Play WaveDlg.h"
#include<Mmsystem.h>
#include <Windows.h>
#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
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
// CMCIPlayWaveDlg dialog

CMCIPlayWaveDlg::CMCIPlayWaveDlg(CWnd* pParent /*=NULL*/)
: CDialog(CMCIPlayWaveDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CMCIPlayWaveDlg)
	m_FileName = _T("");
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CMCIPlayWaveDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CMCIPlayWaveDlg)
	DDX_Text(pDX, IDC_EDIT1, m_FileName);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CMCIPlayWaveDlg, CDialog)
//{{AFX_MSG_MAP(CMCIPlayWaveDlg)
ON_WM_SYSCOMMAND()
ON_WM_PAINT()
ON_WM_QUERYDRAGICON()
ON_BN_CLICKED(IDOK, OnPlay)
ON_BN_CLICKED(IDC_Browse, OnBrowse)
	ON_WM_DROPFILES()
	ON_BN_CLICKED(IDC_BUTTON1, OnStop)
	//}}AFX_MSG_MAP
ON_MESSAGE(MM_MCINOTIFY,OnCatch)
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CMCIPlayWaveDlg message handlers

BOOL CMCIPlayWaveDlg::OnInitDialog()
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
	
	((CButton *)(GetDlgItem(IDC_String)))->SetCheck(1);
	UpdateData(1);
	m_FileName = "C:\\WINDOWS\\Media\\ringin.wav";
	UpdateData(0);
	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CMCIPlayWaveDlg::OnSysCommand(UINT nID, LPARAM lParam)
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

void CMCIPlayWaveDlg::OnPaint() 
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
HCURSOR CMCIPlayWaveDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

void CMCIPlayWaveDlg::OnPlay() 
{
	
	if(((CButton *)(GetDlgItem(IDC_String)))->GetCheck()==1)
	{
		Play_Wav_By_MCISendString(this->m_hWnd,(LPCTSTR)m_FileName);
	}
	else
	{
		Play_Wav_By_MCISendCommand(this->m_hWnd,(LPCTSTR)m_FileName);
	}
}
void CMCIPlayWaveDlg::OnCatch() 
{
		mciSendString("close all", 0, 0, 0);
	if(((CButton *)(GetDlgItem(IDC_Notify)))->GetCheck()==1)
		MessageBox("A message 'MM_MCINOTIFY' has been caught.\n\n     Wav file has been played.        ","Test MCI_NOTIFY Flag ",MB_ICONINFORMATION      );
}

void CMCIPlayWaveDlg:: Play_Wav_By_MCISendCommand(HWND Window_Handel_To_send_Notify,const char* fileName)
{
	unsigned int/*UINT*/  ID;
	unsigned long /*DWORD*/ MCIReturn;
	
	MCI_OPEN_PARMS mciOpenParms;
	MCI_PLAY_PARMS mciPlayParms;
	
	// MCI will choose a device capable of playing the specified file.
	
	//initialize the mciOpenParms struct 
	mciOpenParms.lpstrDeviceType = "waveaudio";
	
	mciOpenParms.lpstrElementName = fileName;
	mciOpenParms.lpstrAlias = "AnyWaveAlais";
	
	
	MCIReturn = mciSendCommand(0, MCI_OPEN, MCI_OPEN_ELEMENT|MCI_OPEN_ALIAS,(unsigned long/*or DWORD*/)(void*)&mciOpenParms);
	
	if (
		MCIReturn==MCIERR_DEVICE_NOT_INSTALLED||
		MCIReturn==MCIERR_DEVICE_NOT_READY||	
		MCIReturn==MCIERR_DEVICE_TYPE_REQUIRED||
		MCIReturn==MCIERR_FILE_NOT_FOUND
		/* Many Errors May Occur And Cought here*/	)
	{
		MessageBox("Can't play Wav file","Error",MB_ICONERROR);
		return;
	}	
	// The device opened successfully; get the device ID.
	ID = mciOpenParms.wDeviceID;   
	
	mciPlayParms.dwCallback = (unsigned long) Window_Handel_To_send_Notify;
	
	MCIReturn = mciSendCommand(ID, MCI_PLAY, MCI_NOTIFY,(unsigned long)(void *) &mciPlayParms);
	
	if (MCIReturn)
	{
		mciSendCommand(ID, MCI_CLOSE, 0, NULL);      
	}
	
}	


void CMCIPlayWaveDlg::Play_Wav_By_MCISendString(HWND Window_Handel_To_send_Notify,const char* fileName)
{
	char Buffer1[128],Buffer2[128]; 

	unsigned long /*DWORD*/ MCIReturn;

	sprintf(Buffer2, "open \"%s\" type waveaudio alias WavExample ", fileName);

	MCIReturn = mciSendString(Buffer2, 0, 0, 0);
	if (
		MCIReturn==MCIERR_DEVICE_NOT_INSTALLED||
		MCIReturn==MCIERR_DEVICE_NOT_READY||
		MCIReturn==MCIERR_DEVICE_OPEN||	
		MCIReturn==MCIERR_FILE_NOT_FOUND
		/* Many Errors May Occur And Cought here*/
		)
	{
		MessageBox("Can't play Wav file","Error",MB_ICONERROR);
		return;
	}

	sprintf(Buffer1, "play %s from 0 ",fileName);  
    mciSendString(Buffer1, NULL, 0, Window_Handel_To_send_Notify);
	

}
void CMCIPlayWaveDlg::OnBrowse() 
{
	UpdateData(1);
	CFileDialog open(TRUE,NULL,NULL,OFN_HIDEREADONLY,"WAV Files (*.wav)|*.wav");
	if(open.DoModal() == IDOK)		
	{	
		m_FileName=open.GetPathName();
	}	
	UpdateData(0);
}

void CMCIPlayWaveDlg::OnDropFiles(HDROP hDropInfo) 
{
	// TODO: Add your message handler code here and/or call default
	char lpszFile[200];
	DragQueryFile (hDropInfo, 0, lpszFile, sizeof (lpszFile));
	UpdateData(1);
	m_FileName = lpszFile;
	CDialog::OnDropFiles(hDropInfo);
	UpdateData(0);
}

void CMCIPlayWaveDlg::OnStop() 
{	
	mciSendString("close all", 0, 0, 0);	
}
