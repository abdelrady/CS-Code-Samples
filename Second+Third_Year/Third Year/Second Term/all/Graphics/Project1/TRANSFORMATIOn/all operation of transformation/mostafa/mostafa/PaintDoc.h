// PaintDoc.h : interface of the CPaintDoc class
//
/////////////////////////////////////////////////////////////////////////////

#if !defined(AFX_PAINTDOC_H__27278F3A_7429_4D34_9296_9E2A8AD68D43__INCLUDED_)
#define AFX_PAINTDOC_H__27278F3A_7429_4D34_9296_9E2A8AD68D43__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000


class CPaintDoc : public CDocument
{
protected: // create from serialization only
	CPaintDoc();
	DECLARE_DYNCREATE(CPaintDoc)

// Attributes
public:

// Operations
public:

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CPaintDoc)
	public:
	virtual BOOL OnNewDocument();
	virtual void Serialize(CArchive& ar);
	//}}AFX_VIRTUAL

// Implementation
public:
	virtual ~CPaintDoc();
	CMetaFileDC * pMetaFile;
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Generated message map functions
protected:
	//{{AFX_MSG(CPaintDoc)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_PAINTDOC_H__27278F3A_7429_4D34_9296_9E2A8AD68D43__INCLUDED_)
