/*
Authors: David Nishimoto and Thomas Lee
Website: http://www.listensoftware.com
Program: Cube Drop
*/

#include "stdafx.h"
#include "3DFont.h"

#include "3DFontDoc.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CMy3DFontDoc

IMPLEMENT_DYNCREATE(CMy3DFontDoc, CDocument)

BEGIN_MESSAGE_MAP(CMy3DFontDoc, CDocument)
	//{{AFX_MSG_MAP(CMy3DFontDoc)
		// NOTE - the ClassWizard will add and remove mapping macros here.
		//    DO NOT EDIT what you see in these blocks of generated code!
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CMy3DFontDoc construction/destruction

CMy3DFontDoc::CMy3DFontDoc()
{
	// TODO: add one-time construction code here

}

CMy3DFontDoc::~CMy3DFontDoc()
{
}

BOOL CMy3DFontDoc::OnNewDocument()
{
	if (!CDocument::OnNewDocument())
		return FALSE;

	// TODO: add reinitialization code here
	// (SDI documents will reuse this document)

	return TRUE;
}



/////////////////////////////////////////////////////////////////////////////
// CMy3DFontDoc serialization

void CMy3DFontDoc::Serialize(CArchive& ar)
{
	if (ar.IsStoring())
	{
		// TODO: add storing code here
	}
	else
	{
		// TODO: add loading code here
	}
}

/////////////////////////////////////////////////////////////////////////////
// CMy3DFontDoc diagnostics

#ifdef _DEBUG
void CMy3DFontDoc::AssertValid() const
{
	CDocument::AssertValid();
}

void CMy3DFontDoc::Dump(CDumpContext& dc) const
{
	CDocument::Dump(dc);
}
#endif //_DEBUG

/////////////////////////////////////////////////////////////////////////////
// CMy3DFontDoc commands
