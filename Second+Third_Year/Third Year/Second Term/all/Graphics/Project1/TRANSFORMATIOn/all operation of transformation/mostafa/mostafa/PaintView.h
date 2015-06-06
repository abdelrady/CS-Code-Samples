// PaintView.h : interface of the CPaintView class
//
/////////////////////////////////////////////////////////////////////////////

#if !defined(AFX_PAINTVIEW_H__62AE0E39_1F0B_41B5_AF20_6E5FE8875961__INCLUDED_)
#define AFX_PAINTVIEW_H__62AE0E39_1F0B_41B5_AF20_6E5FE8875961__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000


class CPaintView : public CView
{
protected: // create from serialization only
	CPaintView();
	DECLARE_DYNCREATE(CPaintView)

// Attributes
public:
	COLORREF color;
	CPoint point1,point2,oldpoint;
	bool flags[6];
	CPaintDoc* GetDocument();
	CString s;
	bool saved;

// Operations
public:

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CPaintView)
	public:
	virtual void OnDraw(CDC* pDC);  // overridden to draw this view
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
	protected:
	virtual BOOL OnPreparePrinting(CPrintInfo* pInfo);
	virtual void OnBeginPrinting(CDC* pDC, CPrintInfo* pInfo);
	virtual void OnEndPrinting(CDC* pDC, CPrintInfo* pInfo);
	//}}AFX_VIRTUAL

// Implementation
public:
	virtual ~CPaintView();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Generated message map functions
protected:
	//{{AFX_MSG(CPaintView)
	afx_msg void OnDrawCircle();
	afx_msg void OnDrawLine();
	afx_msg void OnLButtonDown(UINT nFlags, CPoint point);
	afx_msg void OnLButtonUp(UINT nFlags, CPoint point);
	afx_msg void OnDrawRect();
	afx_msg void OnDrawFree();
	afx_msg void OnMouseMove(UINT nFlags, CPoint point);
	afx_msg void OnDrawFillRect();
	afx_msg void OnDrawFillCircle();
	afx_msg void OnFileSave();
	afx_msg void OnFileOpen();
	afx_msg void OnFileNew();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

#ifndef _DEBUG  // debug version in PaintView.cpp
inline CPaintDoc* CPaintView::GetDocument()
   { return (CPaintDoc*)m_pDocument; }
#endif

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_PAINTVIEW_H__62AE0E39_1F0B_41B5_AF20_6E5FE8875961__INCLUDED_)
