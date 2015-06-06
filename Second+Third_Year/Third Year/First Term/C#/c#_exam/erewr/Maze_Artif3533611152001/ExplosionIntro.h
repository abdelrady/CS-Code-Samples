/****************************************************************************
*	Maze A.I.		Assignment 2											*
*	Created By Wade Arnold		Email: c---8@home.com						*
*	October 2001															*
*	Instructor: Ean Bull													*
****************************************************************************/

#if !defined(AFX_EXPLOSIONINTRO_H__69F378BB_1E29_432C_BFC5_104C0FC03ED9__INCLUDED_)
#define AFX_EXPLOSIONINTRO_H__69F378BB_1E29_432C_BFC5_104C0FC03ED9__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// ExplosionIntro.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// ExplosionIntro dialog

class ExplosionIntro : public CDialog
{
// Construction
public:
	ExplosionIntro(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(ExplosionIntro)
	enum { IDD = IDD_EXPLOSIONINTRO_DIALOG };
	CAnimateCtrl	m_ani;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(ExplosionIntro)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(ExplosionIntro)
	virtual BOOL OnInitDialog();
	afx_msg void OnPlay();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_EXPLOSIONINTRO_H__69F378BB_1E29_432C_BFC5_104C0FC03ED9__INCLUDED_)
