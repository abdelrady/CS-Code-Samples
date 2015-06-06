// Play Video FilesDlg.h : header file
//

#if !defined(AFX_PLAYVIDEOFILESDLG_H__21901EF0_7C71_49DC_BB17_FD99E843817E__INCLUDED_)
#define AFX_PLAYVIDEOFILESDLG_H__21901EF0_7C71_49DC_BB17_FD99E843817E__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
#include<Mmsystem.h>
#include <digitalv.h>
/////////////////////////////////////////////////////////////////////////////
// CPlayVideoFilesDlg dialog

class CPlayVideoFilesDlg : public CDialog
{
// Construction
public:
	char * GetError(UINT mciError );
	MCIDEVICEID DeviceID;
	MCI_DGV_PAUSE_PARMS pause;
	MCI_DGV_PLAY_PARMS Play;
	MCI_DGV_WINDOW_PARMS Window;
	MCI_DGV_OPEN_PARMS Open;
	CString m_FileName;
	CPlayVideoFilesDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CPlayVideoFilesDlg)
	enum { IDD = IDD_PLAYVIDEOFILES_DIALOG };
	//}}AFX_DATA
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CPlayVideoFilesDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CPlayVideoFilesDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnFileOpen();
	afx_msg void OnFilePlay();
	afx_msg void OnDropFiles(HDROP hDropInfo);
	afx_msg void OnFilePuse();
	afx_msg void OnFileResume();
	afx_msg void OnFileStop();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_PLAYVIDEOFILESDLG_H__21901EF0_7C71_49DC_BB17_FD99E843817E__INCLUDED_)
