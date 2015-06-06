/****************************************************************************
*	Maze A.I.		Assignment 2											*
*	Created By Wade Arnold		Email: c---8@home.com						*
*	October 2001															*
*	Instructor: Ean Bull													*
****************************************************************************/

// Maze 1Dlg.cpp : implementation file
//

#include "stdafx.h"
#include "Maze 1.h"
#include "Maze 1Dlg.h"
#include "ExplosionIntro.h"
#include "MazeCreator.h"
#include "FileSaveLoad.h"
#include "MazeWindow.h"
#include "Help.h"

//Used when loading a maze into the MazeWindow Class
#include <fstream.h>

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
	CAnimateCtrl	m_aboutAVI;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CAboutDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	//{{AFX_MSG(CAboutDlg)
	virtual BOOL OnInitDialog();
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
	DDX_Control(pDX, IDC_ANIMATE1, m_aboutAVI);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
	//{{AFX_MSG_MAP(CAboutDlg)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CMaze1Dlg dialog

CMaze1Dlg::CMaze1Dlg(CWnd* pParent /*=NULL*/)
	: CDialog(CMaze1Dlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CMaze1Dlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CMaze1Dlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CMaze1Dlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CMaze1Dlg, CDialog)
	//{{AFX_MSG_MAP(CMaze1Dlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BUTTON1, OnLoadMaze)
	ON_BN_CLICKED(IDC_BUTTON2, OnCreateMaze)
	ON_BN_CLICKED(IDC_BUTTON3, OnAbout)
	ON_BN_CLICKED(IDC_BUTTON5, OnExit)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CMaze1Dlg message handlers

BOOL CMaze1Dlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	//Creates an instance of the Display Intro Window
	ExplosionIntro Display;

	//Displays the window
	Display.DoModal();

//	sndPlaySound("temple.wav", SND_ASYNC | SND_LOOP);

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

void CMaze1Dlg::OnSysCommand(UINT nID, LPARAM lParam)
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

void CMaze1Dlg::OnPaint() 
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
HCURSOR CMaze1Dlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}


/****************************************************
*	This function is used when loading a new maze   *
*	for the computer to solve                       *
****************************************************/
void CMaze1Dlg::OnLoadMaze() 
{
	//Creates an instance of CFileSaveLoad which has a base class of CFileDialog
	//This is to load any maze files
	CFileSaveLoad LoadWin(true, NULL, NULL, NULL, "Maze Files (*.maz)|*.maz|All Files (*.*)|*.*|");

	//Display the file load window
	LoadWin.DoModal();
	
	//Create an instance of ifstream to create a file to load the new maze from
	ifstream InputFile(LoadWin.GetFileName(), ios::in | ios::nocreate);

	if ( InputFile ){//If the file was created properly

		//Load it into MAZE
		while (InputFile >> MAZE);

		//Create an Instance of MazeWindow called Grid
		MazeWindow Grid;

		//Copy the newly loaded MAZE into TheMaze variable in the Grid instance
		strcpy(Grid.TheMaze, MAZE);

		//Display the Maze screen
		Grid.DoModal();
	}
	else//ELSE IF the file was NOT opened properly

		//Display a message saying so to the user
		AfxMessageBox("File could not be opened!");
}

/*****************************************
*	This function is used when the user  *
*	decides to create their own maze     *
*****************************************/
void CMaze1Dlg::OnCreateMaze() 
{
	//Creates an instance of the Maze Creator Class
	MazeCreator Create;

	//Displays the Maze Creator Window
	Create.DoModal();
}

/****************************************
*	This function is used when the user *
*	clicks on the About button to       *
*	display the About information window*
****************************************/
void CMaze1Dlg::OnAbout() 
{
	//Create An instance of the dialog box
	CAboutDlg About;

	//Display it
	About.DoModal();
	
}

/*************************************************
*	As soon as the About Dialog box is launced *
*	(ie at execution)  This function is the first*
*	to be called								 *
*************************************************/
BOOL CAboutDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	//Opens the about AVI clip inside of the Animation Object using the Animation Control
//	m_aboutAVI.Open("About.avi");

	//Centers the animation within the entire window
//	m_aboutAVI.CenterWindow();

	//Plays the AVI from frame 1, to end frame, one time
//	m_aboutAVI.Play(1, -1, 1);

	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}


void CMaze1Dlg::OnExit() 
{
	this->EndDialog(true);	
}
