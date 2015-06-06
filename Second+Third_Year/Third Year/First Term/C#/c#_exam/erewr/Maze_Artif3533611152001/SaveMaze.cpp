// SaveMaze.cpp : implementation file
//

#include "stdafx.h"
#include "Maze 1.h"
#include "SaveMaze.h"
#include <fstream.h>

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// SaveMaze dialog


SaveMaze::SaveMaze(CWnd* pParent /*=NULL*/)
	: CDialog(SaveMaze::IDD, pParent)
{
	//{{AFX_DATA_INIT(SaveMaze)
	m_SaveFileName = _T("");
	//}}AFX_DATA_INIT
}


void SaveMaze::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(SaveMaze)
	DDX_Text(pDX, IDC_EDIT1, m_SaveFileName);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(SaveMaze, CDialog)
	//{{AFX_MSG_MAP(SaveMaze)
	ON_BN_CLICKED(IDC_BUTTON1, OnSaveMaze)
	ON_BN_CLICKED(IDC_BUTTON2, OnCancelSave)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// SaveMaze message handlers

void SaveMaze::OnSaveMaze() 
{
//	char temp[241];
//	strcpy(temp, (LPCTSTR) 
	UpdateData(true);

	ifstream CheckExist(m_SaveFileName, ios::in | ios::nocreate);

	if ( CheckExist ){
		AfxMessageBox("This file already exists please choose another name");
		CheckExist.close();
	}
	else
	{
		ofstream NewMazeFile(m_SaveFileName, ios::out);
		for (int x = 0; x < 241; x++)
			NewMazeFile << NewMaze[x];
		NewMazeFile.close();
		this->EndDialog(true);	
	}
	

}

void SaveMaze::OnCancelSave() 
{
	SaveMaze::OnCancel();	
}
