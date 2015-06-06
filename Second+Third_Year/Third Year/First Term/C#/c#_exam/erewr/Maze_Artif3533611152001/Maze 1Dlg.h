/****************************************************************************
*	Maze A.I.		Assignment 2											*
*	Created By Wade Arnold		Email: c---8@home.com						*
*	October 2001															*
*	Instructor: Ean Bull													*
****************************************************************************/

// Maze 1Dlg.h : header file
//

#if !defined(AFX_MAZE1DLG_H__32B429BA_E127_4FDE_9E4B_0F6D9C7E3830__INCLUDED_)
#define AFX_MAZE1DLG_H__32B429BA_E127_4FDE_9E4B_0F6D9C7E3830__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////
// CMaze1Dlg dialog

class CMaze1Dlg : public CDialog
{
// Construction
public:
	char MAZE[241];
	CMaze1Dlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CMaze1Dlg)
	enum { IDD = IDD_MAZE1_DIALOG };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CMaze1Dlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CMaze1Dlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnLoadMaze();
	afx_msg void OnCreateMaze();
	afx_msg void OnAbout();
	afx_msg void OnHelp();
	afx_msg void OnExit();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_MAZE1DLG_H__32B429BA_E127_4FDE_9E4B_0F6D9C7E3830__INCLUDED_)
