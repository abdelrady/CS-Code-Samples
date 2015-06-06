// MCIWndWrapperDlg.h : header file
//

#if !defined(AFX_MCIWNDWRAPPERDLG_H__61AA735F_A9CF_4DC8_ADCD_EB74F99A1D99__INCLUDED_)
#define AFX_MCIWNDWRAPPERDLG_H__61AA735F_A9CF_4DC8_ADCD_EB74F99A1D99__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000


// For CMCIWnd.
#include "MCIWnd.h"


/////////////////////////////////////////////////////////////////////////////
// CWrapperDlg dialog

class CWrapperDlg : public CDialog
{
// Construction
public:
	CWrapperDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CWrapperDlg)
	enum { IDD = IDD_MCIWNDWRAPPER_DIALOG };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CWrapperDlg)
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;
	CMCIWnd m_mciWnd;

	// Generated message map functions
	//{{AFX_MSG(CWrapperDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnPlayAVI();
	afx_msg LRESULT OnMCIWnd_NotifyError(WPARAM, LPARAM);
	afx_msg LRESULT OnMCIWnd_NotifyMedia(WPARAM, LPARAM);
	afx_msg LRESULT OnMCIWnd_NotifyMode(WPARAM, LPARAM);
	afx_msg LRESULT OnMCIWnd_NotifyPos(WPARAM, LPARAM);
	afx_msg LRESULT OnMCIWnd_NotifySize(WPARAM, LPARAM);
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()

	CString MakePathToInstalledFile(CString strFileName);

};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_MCIWNDWRAPPERDLG_H__61AA735F_A9CF_4DC8_ADCD_EB74F99A1D99__INCLUDED_)
