/*
Authors: David Nishimoto and Thomas Lee
Website: http://www.listensoftware.com
Program: Cube Drop
*/

#if !defined(AFX_3DFONTVIEW_H__4431AE0D_2C62_11D3_955D_8422F5C00000__INCLUDED_)
#define AFX_3DFONTVIEW_H__4431AE0D_2C62_11D3_955D_8422F5C00000__INCLUDED_

#if _MSC_VER >= 1000
#pragma once
#endif // _MSC_VER >= 1000
#include <gl/gl.h>
#include "GLFont.h"

typedef struct Camera
{
GLfloat m_x;
GLfloat m_y;
GLfloat	m_z;

GLfloat m_TranslationUnit;
GLfloat m_radsFromEast;
GLfloat m_height_y;
}Camera;

typedef struct treenode
{
	GLfloat m[16];
	char parent_key[30];
	char node_key[30];
	void (*f)();
	void (*engine)();
	struct treenode *sibling;
	struct treenode *child;
	struct treenode *most_recent_child;
}treenode;


class CMy3DFontView : public CView
{
protected: // create from serialization only
	CMy3DFontView();
	DECLARE_DYNCREATE(CMy3DFontView)

// Attributes
public:
	CMy3DFontDoc* GetDocument();

// Operations
public:
	Camera camera;
	treenode *root;

	void drawWithOpenGL();
	void setPerspectiveWindow(GLdouble fovy, GLdouble aspect,GLdouble zNear,GLdouble zFar);
	void setViewport(GLint iX, GLint iY, GLsizei iWidth, GLsizei iHeight);
	void setDepthBuffer();
	void setSpeed();
	void drawGrid();
	void startGame();
	void buildSceneGraph();
	void maze1();
	void buildMaze();
	void buildSpheres();
	void resetTanks();
	int getObjectCount(int type);

	void traverseSceneGraph(treenode *root);
	treenode * node(char *node_key);
	void addChild(treenode *parentNode, treenode *childNode);
	void cleanSceneGraph(treenode *root);

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CMy3DFontView)
	public:
	virtual void OnDraw(CDC* pDC);  // overridden to draw this view
	virtual BOOL PreCreateWindow(CREATESTRUCT& cs);
	protected:
	//}}AFX_VIRTUAL

// Implementation
public:
	virtual ~CMy3DFontView();
#ifdef _DEBUG
	virtual void AssertValid() const;
	virtual void Dump(CDumpContext& dc) const;
#endif

protected:

	
	CPalette m_Palette; //the logic palette
	HGLRC    m_hRC;
    CDC*     m_pDC;

	CGLFont  m_FontX;


	void InitPalette(void);
	void DrawGLFont(void);
	void InitFontColor(void);

// Generated message map functions
protected:
	//{{AFX_MSG(CMy3DFontView)
	afx_msg int OnCreate(LPCREATESTRUCT lpCreateStruct);
	afx_msg void OnDestroy();
	afx_msg void OnSize(UINT nType, int cx, int cy);
	afx_msg void OnTimer(UINT nIDEvent);
	afx_msg void OnKeyDown(UINT nChar, UINT nRepCnt, UINT nFlags);
	afx_msg void OnFilePause();
	afx_msg void OnFileNew();
	afx_msg void OnFileResume();
	afx_msg void OnAppAbout();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

#ifndef _DEBUG  // debug version in 3DFontView.cpp
inline CMy3DFontDoc* CMy3DFontView::GetDocument()
   { return (CMy3DFontDoc*)m_pDocument; }
#endif

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Developer Studio will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_3DFONTVIEW_H__4431AE0D_2C62_11D3_955D_8422F5C00000__INCLUDED_)
