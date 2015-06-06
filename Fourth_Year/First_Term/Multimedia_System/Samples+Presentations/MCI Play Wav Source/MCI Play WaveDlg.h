// MCI Play WaveDlg.h : header file
//

#if !defined(AFX_MCIPLAYWAVEDLG_H__AC45C2EB_EE8F_462D_9DB9_B023872DBFF0__INCLUDED_)
#define AFX_MCIPLAYWAVEDLG_H__AC45C2EB_EE8F_462D_9DB9_B023872DBFF0__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////
// CMCIPlayWaveDlg dialog

class CMCIPlayWaveDlg : public CDialog
{
// Construction
public:
	void Play_Wav_By_MCISendString(HWND Window_Handel_To_send_Notify,const char* fileName);
	void Play_Wav_By_MCISendCommand(HWND Window_Handel_To_send_Notify,const char* fileName);
	CMCIPlayWaveDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CMCIPlayWaveDlg)
	enum { IDD = IDD_MCIPLAYWAVE_DIALOG };
	CString	m_FileName;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CMCIPlayWaveDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CMCIPlayWaveDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnPlay();
	afx_msg void OnBrowse();
	afx_msg void OnDropFiles(HDROP hDropInfo);
	afx_msg void OnStop();
	//}}AFX_MSG
	afx_msg void OnCatch();
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_MCIPLAYWAVEDLG_H__AC45C2EB_EE8F_462D_9DB9_B023872DBFF0__INCLUDED_)
