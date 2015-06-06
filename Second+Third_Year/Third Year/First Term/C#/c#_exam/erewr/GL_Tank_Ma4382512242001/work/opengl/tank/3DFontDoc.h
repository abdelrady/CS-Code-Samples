/*
Authors: David Nishimoto and Thomas Lee
Website: http://www.listensoftware.com
Program: Cube Drop
*/

#if !defined(AFX_3DFONTDOC_H__4431AE0B_2C62_11D3_955D_8422F5C00000__INCLUDED_)
#define AFX_3DFONTDOC_H__4431AE0B_2C62_11D3_955D_8422F5C00000__INCLUDED_

#if _MSC_VER >= 1000
#pragma once
#endif // _MSC_VER >= 1000


class CMy3DFontDoc : public CDocument
{
protected: // create from serialization only
	CMy3DFontDoc();
	DECLARE_DYNCREATE(CMy3DFontDoc)

// Attributes
public:

// Operations
public:

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CMy3DFontDoc)
	public:
	virtual BOOL OnNewDocument();
	virtual void Serialize(CArchive& ar);
	//}}AFX_VIRTUAL

// Implementation
public:
	virtual ~CMy3DFontDoc();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

// Generated message map functions
protected:
	//{{AFX_MSG(CMy3DFontDoc)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Developer Studio will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_3DFONTDOC_H__4431AE0B_2C62_11D3_955D_8422F5C00000__INCLUDED_)
