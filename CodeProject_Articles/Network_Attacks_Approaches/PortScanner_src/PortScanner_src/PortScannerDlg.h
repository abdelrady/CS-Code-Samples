//////////////////////////////////////////////////////////////////////////////
//
//   PortScanner
//   Efficient TCP port scanner based on TCP half open scanning method.
//
//   Author  : Nagareshwar Y Talekar.
//	 Contact : nsry2002@yahoo.co.in
//	 Date    : 15-6-2004.
//
//   Name :  PortScannerDlg.h
//   Description : 
//
//////////////////////////////////////////////////////////////////////////////



#if !defined(AFX_PORTSCANNERDLG_H__0B6C8886_5499_11D6_888C_000B2B0F84B6__INCLUDED_)
#define AFX_PORTSCANNERDLG_H__0B6C8886_5499_11D6_888C_000B2B0F84B6__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#include<afxwin.h>
#include"packet.h"
#include "resource.h"


/////////////////////////////////////////////////////////////////////////////
// CPortScannerDlg dialog

class CPortScannerDlg : public CDialog
{
// Construction
public:
	CPortScannerDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CPortScannerDlg)
	enum { IDD = IDD_PORTSCANNER_DIALOG };
		// NOTE: the ClassWizard will add data members here
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CPortScannerDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
	public :
	HICON m_hIcon;
	CListCtrl *list;
	CEdit *port1,*port2;
	CButton *butstart,*butstop;
	CComboBox *devlist;
	Packet *packet;
	
	// Generated message map functions
	//{{AFX_MSG(CPortScannerDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnButton2();
	afx_msg void OnButton1();
	BOOL GetMacAddress();
	virtual void OnCancel();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_PORTSCANNERDLG_H__0B6C8886_5499_11D6_888C_000B2B0F84B6__INCLUDED_)
