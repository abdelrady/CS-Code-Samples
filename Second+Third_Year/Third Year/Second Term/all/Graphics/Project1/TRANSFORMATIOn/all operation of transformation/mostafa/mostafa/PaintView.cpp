// PaintView.cpp : implementation of the CPaintView class
//

#include "stdafx.h"
#include "Paint.h"

#include "PaintDoc.h"
#include "PaintView.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CPaintView

IMPLEMENT_DYNCREATE(CPaintView, CView)

BEGIN_MESSAGE_MAP(CPaintView, CView)
	//{{AFX_MSG_MAP(CPaintView)
	ON_COMMAND(ID_DRAW_CIRCLE, OnDrawCircle)
	ON_COMMAND(ID_DRAW_LINE, OnDrawLine)
	ON_WM_LBUTTONDOWN()
	ON_WM_LBUTTONUP()
	ON_COMMAND(ID_DRAW_RECT, OnDrawRect)
	ON_COMMAND(ID_DRAW_FREE, OnDrawFree)
	ON_WM_MOUSEMOVE()
	ON_COMMAND(ID_DRAW_FILL_CIRCLE, OnDrawFillCircle)
	ON_COMMAND(ID_FILE_SAVE, OnFileSave)
	ON_COMMAND(ID_FILE_OPEN, OnFileOpen)
	ON_COMMAND(ID_FILE_NEW, OnFileNew)
	//}}AFX_MSG_MAP
	// Standard printing commands
	ON_COMMAND(ID_FILE_PRINT, CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, CView::OnFilePrintPreview)
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CPaintView construction/destruction

CPaintView::CPaintView()
{
	point1.x=point1.y=point2.x=point2.y=0;
	for(int i=0;i<6;i++)
		flags[i]=0;
	flags[3]=1;
	saved=0;

}

CPaintView::~CPaintView()
{
}

BOOL CPaintView::PreCreateWindow(CREATESTRUCT& cs)
{
	
	cs.lpszClass=AfxRegisterWndClass(CS_DBLCLKS,AfxGetApp()->LoadStandardCursor(IDC_CROSS),(HBRUSH)(COLOR_WINDOW+1),AfxGetApp()->LoadIcon(IDR_MAINFRAME));

	return CView::PreCreateWindow(cs);
}

/////////////////////////////////////////////////////////////////////////////
// CPaintView drawing

void CPaintView::OnDraw(CDC* pDC)
{
	CPaintDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	saved=0;
	HMETAFILE MetaFileHandle=pDoc->pMetaFile->Close();
	pDC->PlayMetaFile(MetaFileHandle);
	CMetaFileDC *ReplacementMetaFile=new CMetaFileDC();
	ReplacementMetaFile->Create();
	ReplacementMetaFile->PlayMetaFile(MetaFileHandle);
	DeleteMetaFile(MetaFileHandle);
	delete pDoc->pMetaFile;
	pDoc->pMetaFile=ReplacementMetaFile;
	/*if(flags[0])
	{
    pDC->MoveTo(point1);
	pDC->LineTo(point2);
	}
	if(flags[1])
	{
	//	CRect rect;
		pDC->SelectStockObject(NULL_BRUSH);
		pDC->Ellipse(point1.x,point1.y,point2.x,point2.y);
	}
	if(flags[2])
	{
			pDC->SelectStockObject(NULL_BRUSH);
           pDC->Rectangle(point1.x,point1.y,point2.x,point2.y);
	}*/

}

/////////////////////////////////////////////////////////////////////////////
// CPaintView printing

BOOL CPaintView::OnPreparePrinting(CPrintInfo* pInfo)
{
	// default preparation
	return DoPreparePrinting(pInfo);
}

void CPaintView::OnBeginPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add extra initialization before printing
}

void CPaintView::OnEndPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: add cleanup after printing
}

/////////////////////////////////////////////////////////////////////////////
// CPaintView diagnostics

#ifdef _DEBUG
void CPaintView::AssertValid() const
{
	CView::AssertValid();
}

void CPaintView::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

CPaintDoc* CPaintView::GetDocument() // non-debug version is inline
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CPaintDoc)));
	return (CPaintDoc*)m_pDocument;
}
#endif //_DEBUG

/////////////////////////////////////////////////////////////////////////////
// CPaintView message handlers

void CPaintView::OnDrawCircle() 
{

	for(int i=0;i<6;i++)
		flags[i]=0;
	flags[1]=1;
//	Invalidate();
	
}

void CPaintView::OnDrawLine() 
{

	for(int i=0;i<6;i++)
		flags[i]=0;
   flags[0]=1;
  // Invalidate();
	
}

void CPaintView::OnLButtonDown(UINT nFlags, CPoint point) 
{
	//if(flags[0])
	//{
	saved=0;
	   CPaintDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	//
       point1=point;
	   oldpoint=point1;
	  // OnDrawLine();
	//}
	
	CView::OnLButtonDown(nFlags, point);
}

void CPaintView::OnLButtonUp(UINT nFlags, CPoint point) 
{
	saved=0;
		CPaintDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	//
	   point2=point;
	   CClientDC * pDC=new CClientDC(this);

	if(flags[0])
	{
        pDC->MoveTo(point1);
		pDC->LineTo(point2);
		pDoc->pMetaFile->MoveTo(point1);
		pDoc->pMetaFile->LineTo(point2);
	 	   	//Invalidate();
	}
	if(flags[1])
	{
       	   	pDC->SelectStockObject(NULL_BRUSH);
		pDC->Ellipse(point1.x,point1.y,point2.x,point2.y);
		pDoc->pMetaFile->SelectStockObject(NULL_BRUSH);
		pDoc->pMetaFile->Ellipse(point1.x,point1.y,point2.x,point2.y);
	}
	if(flags[2])
	{
      		pDC->SelectStockObject(NULL_BRUSH);
		pDC->Rectangle(point1.x,point1.y,point2.x,point2.y);
		pDoc->pMetaFile->SelectStockObject(NULL_BRUSH);
		pDoc->pMetaFile->Rectangle(point1.x,point1.y,point2.x,point2.y);   	
	}
	
	if(flags[4])
	{
      	pDC->SelectStockObject(BLACK_BRUSH);
		pDC->FloodFill(point1.x,point1.y,RGB(0,0,0));
		pDoc->pMetaFile->SelectStockObject(BLACK_BRUSH);
		pDoc->pMetaFile->FloodFill(point1.x,point1.y,RGB(0,0,0));
	}
	if(flags[4])
	{
      pDC->SelectStockObject(BLACK_BRUSH);
	  pDC->FloodFill(point1.x,point1.y,RGB(0,0,0));
	}
	CView::OnLButtonUp(nFlags, point);
}

void CPaintView::OnDrawRect() 
{
		for(int i=0;i<6;i++)
		flags[i]=0;
   flags[2]=1;
}

void CPaintView::OnDrawFree() 
{
	for(int i=0;i<6;i++)
		flags[i]=0;
   flags[3]=1;
	
}

void CPaintView::OnMouseMove(UINT nFlags, CPoint point) 
{
	saved=0;
    CPaintDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	//
	int mode;
	CClientDC*pDC=new CClientDC(this);
	if((nFlags&&MK_LBUTTON)&&flags[3])
	{CClientDC dc(this);
		//pDC->SetROP2(R2_NOT);

		pDC->MoveTo(point1);
		pDC->LineTo(point);
		pDoc->pMetaFile->MoveTo(point1);
		pDoc->pMetaFile->LineTo(point);
	//	pDC->MoveTo(point1);
	//pDC->LineTo(point);
		point1.x=point.x;
		point1.y=point.y;
	//	pDC->SetROP2(mode);
	}

	
	
	if((nFlags&&MK_LBUTTON)&&flags[0])
	{
		CClientDC dc(this);
		mode=pDC->GetROP2();
		pDC->SetROP2(R2_NOT);

		pDC->MoveTo(point1);
		pDC->LineTo(oldpoint);
		pDC->MoveTo(point1);
		pDC->LineTo(point);
		oldpoint.x=point.x;
		oldpoint.y=point.y;
		pDC->SetROP2(mode);
	}
	if((nFlags&&MK_LBUTTON)&&flags[1])
	{
		CClientDC dc(this);
		mode=pDC->GetROP2();
		pDC->SetROP2(R2_NOT);
		pDC->SelectStockObject(NULL_BRUSH);
		pDC->Ellipse(oldpoint.x,oldpoint.y,point1.x,point1.y);
		pDC->Ellipse(point1.x,point1.y,point.x,point.y);
		oldpoint.x=point.x;
		oldpoint.y=point.y;
		pDC->SetROP2(mode);
	}
	if((nFlags&&MK_LBUTTON)&&flags[2])
	{
		CClientDC dc(this);
		mode=pDC->GetROP2();
		pDC->SetROP2(R2_NOT);
		pDC->SelectStockObject(NULL_BRUSH);
		pDC->Rectangle(oldpoint.x,oldpoint.y,point1.x,point1.y);
		pDC->Rectangle(point1.x,point1.y,point.x,point.y);
		oldpoint.x=point.x;
		oldpoint.y=point.y;
		pDC->SetROP2(mode);
	}
		
	delete(pDC);
	CView::OnMouseMove(nFlags, point);
}

void CPaintView::OnDrawFillRect() 
{
	// TODO: Add your command handler code here
	
}

void CPaintView::OnDrawFillCircle() 
{
	for(int i=0;i<6;i++)
		flags[i]=0;
flags[4]=1;	
	
}

void CPaintView::OnFileSave() 
{
	int k;
	CFileDialog save(false);
	if(save.DoModal()==IDOK)
	{
		
	s=save.GetPathName();
	s=save.GetFileName();
	//MessageBox(s);
	}
	if(!(s.Find('.')&&s.Find('w')))
	{
		k=s.Find('.');
		s.Delete('.wmf');
	}
   CPaintDoc* pDoc=GetDocument();
   ASSERT_VALID(pDoc);
   HMETAFILE MetaFileHandle=pDoc->pMetaFile->Close();
   CopyMetaFile(MetaFileHandle,s+".wmf");
   CMetaFileDC *ReplacementMetaFile=new CMetaFileDC();	
	ReplacementMetaFile->Create();
	ReplacementMetaFile->PlayMetaFile(MetaFileHandle);
	DeleteMetaFile(MetaFileHandle);
	delete pDoc->pMetaFile;
	pDoc->pMetaFile=ReplacementMetaFile;
	saved=1;
}

void CPaintView::OnFileOpen() 
{
	int k;
    CFileDialog open(true);
	if(open.DoModal()==IDOK)
	{
		
	s=open.GetPathName();
	//s=open.GetFileName();
	//MessageBox(s);
	}
	k=s.Find('.');
	s.Delete('.wmf');
  CPaintDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	//int k=s.Find('.');
//	s.Delete('.wmf');
   HMETAFILE MetaFileHandle=GetMetaFile(s);
   CMetaFileDC *ReplacementMetaFile=new CMetaFileDC();
	ReplacementMetaFile->Create();
	ReplacementMetaFile->PlayMetaFile(MetaFileHandle);
	DeleteMetaFile(MetaFileHandle);
	delete pDoc->pMetaFile;
	pDoc->pMetaFile=ReplacementMetaFile;
	Invalidate();
	saved=0;
}

void CPaintView::OnFileNew() 
{
 	CPaintDoc* pDoc=GetDocument();
   ASSERT_VALID(pDoc);
   if(!saved)
	   OnFileSave();
   CMetaFileDC *ReplacementMetaFile=new CMetaFileDC();	
	ReplacementMetaFile->Create();
	delete pDoc->pMetaFile;
	pDoc->pMetaFile=ReplacementMetaFile;
	saved=0;
	Invalidate();
}
