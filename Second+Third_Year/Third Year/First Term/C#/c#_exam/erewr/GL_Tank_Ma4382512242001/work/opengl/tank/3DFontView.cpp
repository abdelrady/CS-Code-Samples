/*
Authors: David Nishimoto 
Website: http://www.listensoftware.com
Program: Tank Maze
Email: davepamn@relia.net
*/

#include "stdafx.h"
#include "MainFrm.h"
#include "3DFont.h"

#include "3DFontDoc.h"
#include "3DFontView.h"
//#include "help.h"

#include <time.h>
#include <math.h>

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

BOOL gameOver=FALSE;
BOOL pause=FALSE;
#define PI 3.142
#define TRUE 1
#define FALSE 0
#define glRGB(x, y, z)	glColor3ub((GLubyte)x, (GLubyte)y, (GLubyte)z)
#define GRID_SIZE 500
#define dRadToDeg(x) (((float)x)*57.29577951308f)
#define NUMBER_OF_MISSILES 100
#define WALL_TYPE 1
#define EMPTY_TYPE 0
#define OBJECT_LIST_SIZE 100
#define RIGHT_DIRECTION 0
#define LEFT_DIRECTION 1
#define FORWARD_DIRECTION 2
#define PLAYER_TANK 0
#define OPPONENT_TANK 1
#define EXPLOSION_SIZE 10

typedef struct Engine{
	GLfloat x,y,z;
	GLfloat m_displacement;
	long m_time_out;
	GLint angle;
	GLfloat m_angle_radians;
	long m_cpu_seconds;
	clock_t m_movement_interval;
	long m_hit;
	GLint mTurretAngle;
}Engine;

Engine tankEngine[1];
Engine opponentEngine[1];

GLint mTank_Score=0;
GLint mTank_Id=0;
GLint mLevel=1;
GLint mLives=3;


typedef struct OBJECT_STRUCT{
	GLint m_id;
	GLfloat m_x;
	GLfloat m_y;
	GLfloat m_z;
	GLfloat m_t;
	GLfloat m_Vox;
	GLfloat m_Voy;
	GLfloat m_Vo;
	GLfloat m_Xo;
	GLfloat m_Yo;
	GLint m_value;
	GLint m_hit;
	GLfloat m_radsFromEast;
	BOOL m_available_flag;
	BOOL m_active_flag;
} OBJECT_STRUCT_TYPE;

OBJECT_STRUCT_TYPE tankMissile[NUMBER_OF_MISSILES];
OBJECT_STRUCT_TYPE opponentMissile[NUMBER_OF_MISSILES];
OBJECT_STRUCT_TYPE objSphereList[OBJECT_LIST_SIZE];
OBJECT_STRUCT_TYPE objWallList[OBJECT_LIST_SIZE];

int vMap[10][10];


typedef double MATRIX4X4 [4][4];
typedef double MATRIX4X1 [4][1];
typedef double MATRIX1X4 [1][4];

typedef struct VECTOR_STRUCT
{
	GLfloat m_x;
	GLfloat m_y;
	GLfloat m_z;
} VECTOR_STRUCT_TYPE;

typedef struct explosion{
	GLfloat x;
	GLfloat y;
	GLfloat z;
	GLfloat scale_x;
	GLfloat scale_y;
	GLfloat scale_z;
	long m_cpu_seconds;
	BOOL m_available_flag;
	BOOL m_active_flag;
}EXPLOSION_TYPE;

EXPLOSION_TYPE objExplosion[EXPLOSION_SIZE];

void tankTop();
void drawHurstTankTop();
void drawOpponentTankTop();
void tankBarrel();
void drawHurstTankBarrel();
void drawHurstTankBody();
void drawHurstTankWheel();
void drawHurstTankLeftTread();
void drawHurstTankRightTread();
void tankZone();
void hurstTank();
void opponentTank();
long ellaspedTimeOut(Engine *objEngine);
void setTimeOut(Engine *objEngine);
void moveEngine(Engine *objEngine);
void hurstTank_Engine();
void fireTankMissile();
int getAvailableMissile();
void drawTankMissiles();
void missileObject();
void cone(GLfloat radius,GLfloat height);
void cylinder(GLfloat radius,GLfloat height);
void box(GLfloat w,GLfloat h,GLfloat d);
void brassMaterial();
void goldMaterial();
void bronzeMaterial();
void chromeMaterial();
void copperMaterial();
void silverMaterial();
void pewterMaterial();
void blackPlasticMaterial();
void setDiffuseMaterialColor(GLfloat red, GLfloat green, GLfloat blue,GLfloat alpha);
void setAmbientMaterialColor(GLfloat red, GLfloat green, GLfloat blue,GLfloat alpha);
void setSpecularMaterialColor(GLfloat red, GLfloat green, GLfloat blue,GLfloat alpha);
void setMaterialShininess(GLfloat shininess);
void sphere(GLfloat radius);
void drawSphereObjectList();
int getSphereObject();
int getWallObject();
void drawWallObjectList();
void drawSphereObjectList();
void checkSphereCollision(Engine *objEngine);
int checkWallCollision(Engine *objEngine,GLfloat xDelta,GLfloat zDelta);
int insideBoundary(GLfloat tank_x, GLfloat tank_z,
			   	GLfloat wall_x1,GLfloat wall_x2,
				GLfloat wall_z1,GLfloat wall_z2);

double Matrix4X1_1X4(MATRIX4X1 *matrix1, MATRIX1X4 *matrix2);
void Matrix4X1_4X4(MATRIX4X1 *result, MATRIX4X1 *matrix1, MATRIX4X4 *matrix2);
void Matrix1X4_4X4(MATRIX1X4 *result, MATRIX1X4 *matrix1, MATRIX4X4 *matrix2);
VECTOR_STRUCT_TYPE* rotate(GLfloat angle,GLfloat ux,GLfloat uy,GLfloat uz, VECTOR_STRUCT_TYPE *vector);
void opponent_tank_Engine();
void moveOpponentEngine(Engine *objEngine,int direction);
int checkOpponentTankHit(GLfloat x,GLfloat y,GLfloat z);
int getAvailableExplosion();
void drawExplosion();
void calcNormal(GLfloat v[3][3], GLfloat out[3]);
void reduceToUnit(GLfloat vector[3]);
void torus(GLfloat innerRadius,	GLfloat outerRadius);
int getAvailableOpponentMissile();
void fireOpponentMissile();
void drawOpponentMissiles();
int checkTankHit(GLfloat x,GLfloat y,GLfloat z);
int checkTankCollision(Engine *objEngine,GLfloat xDelta,GLfloat zDelta);
void destroyWall(GLfloat x,GLfloat z);

/////////////////////////////////////////////////////////////////////////////
// CMy3DFontView

IMPLEMENT_DYNCREATE(CMy3DFontView, CView)

BEGIN_MESSAGE_MAP(CMy3DFontView, CView)
	//{{AFX_MSG_MAP(CMy3DFontView)
	ON_WM_CREATE()
	ON_WM_DESTROY()
	ON_WM_SIZE()
	ON_WM_TIMER()
	ON_WM_KEYDOWN()
	ON_COMMAND(ID_FILE_PAUSE, OnFilePause)
	ON_COMMAND(ID_FILE_NEW, OnFileNew)
	ON_COMMAND(ID_FILE_RESUME, OnFileResume)
	ON_COMMAND(ID_APP_ABOUT, OnAppAbout)
	//}}AFX_MSG_MAP
	// Standard printing commands
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CMy3DFontView construction/destruction

CMy3DFontView::CMy3DFontView()
{
	int i;

	// TODO: add construction code here
	srand( (unsigned)time(NULL) );
	startGame();
	buildSceneGraph();
	tankEngine[0].m_movement_interval=clock();

	tankEngine[0].x=20.0f;
	tankEngine[0].z=-50.0f;
	tankEngine[0].m_angle_radians=-1.57f;

	opponentEngine[0].x=0.0f;
	opponentEngine[0].y=0.0f;
	opponentEngine[0].z=-300.0f;
	opponentEngine[0].m_hit=0;


	for(i=0; i<NUMBER_OF_MISSILES; i++)
	{
		tankMissile[i].m_available_flag=TRUE;
		tankMissile[i].m_active_flag=FALSE;
	}

	for(i=0; i<NUMBER_OF_MISSILES; i++)
	{
		opponentMissile[i].m_available_flag=TRUE;
		opponentMissile[i].m_active_flag=FALSE;
	}

	for (i=0; i<OBJECT_LIST_SIZE; i++)
	{
		objSphereList[i].m_available_flag=TRUE;
		objWallList[i].m_available_flag=TRUE;
		objWallList[i].m_hit=0;
	}

	for(i=0; i<EXPLOSION_SIZE; i++)
	{
		objExplosion[i].x=0.0f;
		objExplosion[i].y=0.0f;
		objExplosion[i].z=0.0f;
		objExplosion[i].scale_x=2.0f;
		objExplosion[i].scale_y=2.0f;
		objExplosion[i].scale_z=2.0f;
		objExplosion[i].m_cpu_seconds=0;
		objExplosion[i].m_available_flag=TRUE;
		objExplosion[i].m_active_flag=FALSE;
	}

	maze1();

	buildMaze();
	buildSpheres();

}


CMy3DFontView::~CMy3DFontView()
{
	cleanSceneGraph(root);
}

BOOL CMy3DFontView::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: Modify the Window class or styles here by modifying
	//  the CREATESTRUCT cs

	return CView::PreCreateWindow(cs);
}

/////////////////////////////////////////////////////////////////////////////
// CMy3DFontView drawing

void CMy3DFontView::OnDraw(CDC* pDC)
{
	CMy3DFontDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);

	// TODO: add draw code for native data here
	CPalette* oldPalette;

    //Set logic palette
	oldPalette = m_pDC->SelectPalette(&m_Palette, FALSE);
	m_pDC->RealizePalette();
	
	wglMakeCurrent(m_pDC->GetSafeHdc(), m_hRC);
	//DrawGLFont();
	drawWithOpenGL();
	SwapBuffers(m_pDC->GetSafeHdc());
    wglMakeCurrent(m_pDC->GetSafeHdc(), NULL);
	m_pDC->SelectPalette(oldPalette, FALSE);
}
void CMy3DFontView::drawWithOpenGL()
{
	CMainFrame* pFrame; 
	char scorePhrase[200];

	glShadeModel(GL_SMOOTH);
	glEnable(GL_DEPTH_TEST);
	
	//clear color buffer
	glClearColor(1.0f, 1.0f, 1.0f, 1.0f);
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	
	//set light model
	/*
	glLightfv(GL_LIGHT0, GL_AMBIENT, m_Lightambient);//set light ambient
	glLightfv(GL_LIGHT0, GL_DIFFUSE, m_Lightdiffuse);//set light specular
	glLightfv(GL_LIGHT0, GL_SPECULAR, m_Lightspecular);//set light specular
	glLightfv(GL_LIGHT0, GL_POSITION, m_Lightposition);//set light position
	*/

	glEnable(GL_LIGHTING);
    glEnable(GL_LIGHT0);

    glMatrixMode(GL_MODELVIEW);
    glLoadIdentity();

	//gluLookAt(camera.m_x, camera.m_y, camera.m_z,
	//		  0.0f, 0.0f, -12.0f,
	//		  0.0f, 1.0f, 0.0f);

			  gluLookAt(
			  tankEngine[0].x-(20.0f*(GLfloat)cos(tankEngine[0].m_angle_radians)+camera.m_x), 
			  tankEngine[0].y+camera.m_y, 
			  tankEngine[0].z+(20.0f*(GLfloat)sin(tankEngine[0].m_angle_radians)), 
			  tankEngine[0].x+(100.0f*(GLfloat)cos(tankEngine[0].m_angle_radians)+camera.m_z), 
			  tankEngine[0].y-50, 
			  tankEngine[0].z-(100.0f*(GLfloat)sin(tankEngine[0].m_angle_radians)), 
			  0.0f, 
			  1.0f, 
			  0.0f  
			  );


	glPushMatrix();
		glTranslatef(20.0f, 12.0f,0.0f);
		glRotatef(180.0f,0.0f,1.0f,0.0f);
		glRotatef(90.0f,1.0f,0.0f,0.0f);
	    m_FontX.GLDrawText();
	glPopMatrix();

	VERIFY( pFrame = (CMainFrame*)GetParentFrame() ); 

	if (mLives==0)
	{
		gameOver=TRUE;
	}
	else
	{
		sprintf(scorePhrase,"(space)fire(1/2)Turret(3/4)Cam(Score)%i Hit:%i OppHit:%i Lives:%i", mTank_Score,tankEngine[0].m_hit,opponentEngine[0].m_hit,mLives);
	}

	if(gameOver)
	{
		sprintf(scorePhrase,"Game Over Score %i",mTank_Score);
		pFrame->SetWindowText(scorePhrase); 
	}
	else
	{
		pFrame->SetWindowText(scorePhrase); 
	}

	traverseSceneGraph(root);

	//draw the game grid
	drawGrid();

	//draw maze
	drawWallObjectList();
	if(getObjectCount(EMPTY_TYPE)>0)
	{
		drawSphereObjectList();
	}
	else
	{
		buildSpheres();
		mLevel++;
		resetTanks();
	}

}
/////////////////////////////////////////////////////////////////////////////
// CMy3DFontView diagnostics

#ifdef _DEBUG
void CMy3DFontView::AssertValid() const
{
	CView::AssertValid();
}

void CMy3DFontView::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

CMy3DFontDoc* CMy3DFontView::GetDocument() // non-debug version is inline
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CMy3DFontDoc)));
	return (CMy3DFontDoc*)m_pDocument;
}
#endif //_DEBUG

/////////////////////////////////////////////////////////////////////////////
// CMy3DFontView message handlers

int CMy3DFontView::OnCreate(LPCREATESTRUCT lpCreateStruct) 
{
	if (CView::OnCreate(lpCreateStruct) == -1)
		return -1;
	
	// TODO: Add your specialized creation code here
	PIXELFORMATDESCRIPTOR pfd =
	{
		sizeof(PIXELFORMATDESCRIPTOR),
		1,
		PFD_DRAW_TO_WINDOW|
		PFD_SUPPORT_OPENGL|
		PFD_DOUBLEBUFFER,  
		PFD_TYPE_RGBA,
		24,
		0,0,0,0,0,0,
        0,0,0,0,0,0,0,
		32,
		0,0,
		PFD_MAIN_PLANE,
		0,
		0,0,0
	};
     
    m_pDC = new CClientDC(this);
	int pixelFormat =
		ChoosePixelFormat(m_pDC->GetSafeHdc(), &pfd);
	BOOL success = 
		SetPixelFormat(m_pDC->GetSafeHdc(), pixelFormat, &pfd);

	DescribePixelFormat(m_pDC->GetSafeHdc(), pixelFormat,
		  sizeof(pfd), &pfd);

	if(pfd.dwFlags & PFD_NEED_PALETTE)
         InitPalette();

	m_hRC = wglCreateContext(m_pDC->GetSafeHdc());

	m_FontX.SetXOffset(0.0f);
	m_FontX.SetYOffset(0.1f);
	m_FontX.SetXScale(6.4f);
	m_FontX.SetYScale(6.3f);
	m_FontX.SetZScale(3.8f);
	m_FontX.SetXRotate(-90.0f);
	m_FontX.SetYRotate(0.0f);
	m_FontX.SetZRotate(0.0f);

	InitFontColor();

	wglMakeCurrent(m_pDC->m_hDC,m_hRC);
	m_FontX.CreateFont(m_pDC, "Arial Black");
	m_FontX.SetText("Tank Maze");

	wglMakeCurrent(NULL,NULL);

	setSpeed();

	return 0;
}

void CMy3DFontView::OnDestroy() 
{
	CView::OnDestroy();
	
	// TODO: Add your message handler code here
	wglDeleteContext(m_hRC);
    m_Palette.DeleteObject();
	ReleaseDC(m_pDC);
}

void CMy3DFontView::OnSize(UINT nType, int cx, int cy) 
{
	GLdouble aspect;
	CView::OnSize(nType, cx, cy);

	if (cy==0)
		aspect = (GLdouble)cx;
	else
		aspect = (GLdouble)cx/(GLdouble)cy;

    CClientDC clientDC(this);
	wglMakeCurrent(clientDC.m_hDC, m_hRC);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	//glFrustum(-1.0, 1.0, -1.0, 1.0, 2.0, 7.0);
	//glViewport(0, 0, cx, cy);

	setPerspectiveWindow(60,aspect,5,4000);
	setViewport(0,0,cx,cy);
	
	wglMakeCurrent(NULL, NULL);
}


void CMy3DFontView::InitPalette(void)
{
	PIXELFORMATDESCRIPTOR pfd;  // Pixel Format Descriptor         
	LOGPALETTE *pPal;			// Pointer to memory for logical palette
	int PixelFormat;			// Pixel format index
    int paletteSize;            // Number of entries in palette 
	BYTE RedMask;               // Range for each color entry (7,7,and 3)
	BYTE GreenMask;
	BYTE BlueMask;
    HDC hDC = GetDC()->GetSafeHdc();  //the context device 								

	// Get the pixel format index and retrieve the pixel format description
    PixelFormat = GetPixelFormat(hDC);
    DescribePixelFormat(hDC, PixelFormat, sizeof(PIXELFORMATDESCRIPTOR), &pfd);
    
	
	// Check whether the pixel format and the pixel type
	if (!(pfd.dwFlags & PFD_NEED_PALETTE ||
	  pfd.iPixelType == PFD_TYPE_COLORINDEX))
	    return;

	// Get the number of entries in palette. 256 colors for 8 bits 
    paletteSize = 1 << pfd.cColorBits;
    
	// Allocate for the logical palette
	pPal = (LOGPALETTE*)
	malloc(sizeof(LOGPALETTE) + paletteSize * sizeof(PALETTEENTRY));
    
	
	// Fill the logical palette header information 
	pPal->palVersion = 0x300;            //support Windows3.0
    pPal->palNumEntries = paletteSize;   //number of colors entries

    // Set the 1st entries of logical palette with the current system palette 
    (void) GetSystemPaletteEntries(hDC, 0, paletteSize, &pPal->palPalEntry[0]);

	//Set the RGB mask
	RedMask = (1 << pfd.cRedBits) - 1;
	GreenMask = (1 << pfd.cGreenBits) - 1;
	BlueMask = (1 << pfd.cBlueBits) - 1;

	//Set all entries of the logical palette 
    for (int i=0; i<paletteSize; ++i) 
	{
	    pPal->palPalEntry[i].peRed =
		    (((i >> pfd.cRedShift) & RedMask) * 255) / RedMask;
	    pPal->palPalEntry[i].peGreen =
		    (((i >> pfd.cGreenShift) & GreenMask) * 255) / GreenMask;
	    pPal->palPalEntry[i].peBlue =
		    (((i >> pfd.cBlueShift) & BlueMask) * 255) / BlueMask;
	    pPal->palPalEntry[i].peFlags = 0;
    }

	//Create the palette
    m_Palette.CreatePalette(pPal);

	//Free the memory allocated for the logical palette 
    free(pPal);
}


void CMy3DFontView::DrawGLFont(void)
{
	glShadeModel(GL_SMOOTH);
	glEnable(GL_DEPTH_TEST);
	
	//clear color buffer
	glClearColor(1.0f, 1.0f, 1.0f, 1.0f);
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	
	//set light model
	glEnable(GL_LIGHTING);
    glEnable(GL_LIGHT0);

    glMatrixMode(GL_MODELVIEW);
    glLoadIdentity();

    //glTranslatef(-3.0f, -5.0f, -0.0f);

    m_FontX.GLDrawText();

	glFlush();

}


void CMy3DFontView::InitFontColor()
{
	float fv[4];


	fv[0] = 0.1f;
	fv[1] = 0.1f;
	fv[2] = 0.1f;
	fv[3] = 0.1f;
	m_FontX.SetEmission(fv);

	fv[0] = 0.9f;
	fv[1] = 0.9f;
	fv[2] = 0.9f;
	fv[3] = 1.0f;
	m_FontX.SetSpecular(fv);

	fv[0] = 0.1f;
	fv[1] = 0.1f;
	fv[2] = 1.0f;
	fv[3] = 1.0f;
	m_FontX.SetAmbient(fv);

	fv[0] = 0.1f;
	fv[1] = 0.1f;
	fv[2] = 0.1f;
	fv[3] = 1.0f;
	m_FontX.SetDiffuse(fv);

	m_FontX.SetShininess(0.1f);
	
}


void CMy3DFontView::setPerspectiveWindow(GLdouble fovy, GLdouble aspect,GLdouble zNear,GLdouble zFar)
{
  glMatrixMode(GL_PROJECTION);
  glLoadIdentity();
  gluPerspective(fovy, aspect,zNear,  zFar);
}
void CMy3DFontView::setViewport(GLint iX, GLint iY, GLsizei iWidth, GLsizei iHeight)
{
	glViewport(iX,iY,iWidth,iHeight);
}
void CMy3DFontView::setDepthBuffer()
{
  glEnable(GL_DEPTH_TEST);
  glDepthFunc(GL_LESS);
  glEnable(GL_CULL_FACE);
  glCullFace(GL_BACK);
  glFrontFace(GL_CCW);
}
void CMy3DFontView::startGame()
{
	gameOver = FALSE;
	camera.m_radsFromEast=(float)1.57;
	camera.m_x=0.0f;;
	camera.m_y=14.0f;
	camera.m_z=0.0f;
}


void CMy3DFontView::OnTimer(UINT nIDEvent) 
{
	// TODO: Add your message handler code here and/or call default

	if(pause)
	{
		KillTimer(1);
	}
	else
	{
		setSpeed();
	}

	Invalidate(FALSE);

	CView::OnTimer(nIDEvent);
}

void CMy3DFontView::OnKeyDown(UINT nChar, UINT nRepCnt, UINT nFlags) 
{
	static clock_t current_clicks=clock();

	// TODO: Add your message handler code here and/or call default
		//left
		if (nChar==37)
		{
		tankEngine[0].m_angle_radians +=(GLfloat) PI/20.0f; 
		//if(tankEngine[0].m_angle_radians > (2.0*PI))		
		//	tankEngine[0].m_angle_radians = 0.0f;
		}
		//right
		else if(nChar==39)
		{
		tankEngine[0].m_angle_radians -= (GLfloat) PI/20.0f; 
		//if (tankEngine[0].m_angle_radians <0.0f)		
		//	tankEngine[0].m_angle_radians = (GLfloat)(2.0f*PI);
		}
		//up
		else if(nChar==38)
		{
			if(tankEngine[0].m_displacement<5)
			{
				tankEngine[0].m_displacement+=1.0f;
			}
		}
		//down
		else if(nChar==40)
		{
			if(tankEngine[0].m_displacement>-5.0f)
			{
				tankEngine[0].m_displacement-=1.0f;
			}
		}
		//fire
		else if(nChar==32)
		{
			if((clock()-current_clicks)>1000)
			{
				fireTankMissile();
				current_clicks=clock();
			}
		}
		//1
		else if(nChar==49)
		{
			tankEngine[0].mTurretAngle=(tankEngine[0].mTurretAngle+10)%360;
		}
			//2
		else if(nChar==50)
		{
			tankEngine[0].mTurretAngle=(tankEngine[0].mTurretAngle-10)%360;
		}
			//3
		else if(nChar==51)
		{
			camera.m_y++;
		}
			//4
		else if(nChar==52)
		{
			camera.m_y--;
		}
			//5
		else if(nChar==53)
		{
		}
			//6
		else if(nChar==54)
		{
		}
			//7
		else if(nChar==55)
		{
		}
			//8
		else if (nChar==56)
		{
			
		}

	//Invalidate(FALSE);
	CView::OnKeyDown(nChar, nRepCnt, nFlags);
}
void CMy3DFontView::drawGrid()
{
int r,c;
int nStep = 10;
int size=GRID_SIZE;


  glPushAttrib(GL_LIGHTING);
  glDisable(GL_LIGHTING);
  glRGB(0,255,0);

  glPushMatrix();

	/* Just draw a bunch of horizontal and vertical lines */
	glBegin(GL_LINES);

	for(r = -size; r  <= size; r += nStep)
		{
		glVertex3f((float)r, 0.0f, (float)-size);
		glVertex3f((float)r, 0.0f, (float)size);
		}

	for(c = -size; c <= size; c += nStep)
		{
		glVertex3f((float)size, 0.0f, (float)c);
		glVertex3f((float)-size, 0.0f, (float)c);
		}

	glEnd();

  glPopMatrix();
  glPopAttrib();
}

void CMy3DFontView::OnFilePause() 
{
	// TODO: Add your command handler code here
	pause=TRUE;
}
void CMy3DFontView::setSpeed()
{
	SetTimer(1,100,0);
}

void CMy3DFontView::OnFileNew() 
{
	// TODO: Add your command handler code here
	startGame();
}

void CMy3DFontView::OnFileResume() 
{
	// TODO: Add your command handler code here

		pause=FALSE;
		setSpeed();
}
void CMy3DFontView::traverseSceneGraph(treenode *root)
{
	if(root==NULL)
		return;
	//count++;
	//printf("PushMatrix %d\n",count);
	//printf("%s\n",root->node_key);
	glPushMatrix();
		//glMultMatrix(root->m);
		root->f();
		if (root->engine!=NULL)
		{
			root->engine();
		}
		if(root->child!=NULL)
		{
			traverseSceneGraph(root->child);
		}
	//count--;
	//printf("PopMatrix %d\n",count);

	glPopMatrix();
	
	if(root->sibling!=NULL)
			traverseSceneGraph(root->sibling);
}
treenode* CMy3DFontView::node(char *node_key)
{
	treenode *retNode;

	retNode=(treenode *) malloc (sizeof(treenode));
	retNode->child=NULL;
	retNode->sibling=NULL;
	retNode->engine=NULL;
	retNode->most_recent_child=NULL;
	strcpy(retNode->node_key,node_key);

	return(retNode);

}
void CMy3DFontView::addChild(treenode *parentNode, treenode *childNode)
{
	/*
	Observations
	1) addChild rules:
	a) A parent has only one child
	b) If another child is associated to the parent it becomes a sibling of the parents first child.  That child becomes the parent's most_recent_child.  Any additional children are associated to the parent's most_recent_child sibling link.
	c) The parents first child sibling link is traverse to find all remaining children.  This is the key for the algorithm to work correctly.
	*/

	treenode *most_recent_child;
	//walk down the tree from the topmost child
	//connect the sibling link from the most recent child
	most_recent_child=parentNode->most_recent_child;
	
	strcpy(childNode->parent_key,parentNode->node_key);

	if (most_recent_child!=NULL)
	{
		most_recent_child->sibling=childNode;
		parentNode->most_recent_child=childNode;
	}
	//first child
	else
	{
		parentNode->child=childNode;
		parentNode->most_recent_child=childNode;
	}
}
void CMy3DFontView::cleanSceneGraph(treenode *root)
{
	if(root->child!=NULL)
		cleanSceneGraph(root->child);
	
	if(root->sibling!=NULL)
		cleanSceneGraph(root->sibling);

	free(root);
}
void CMy3DFontView::buildSceneGraph()
{
	//treenode *objRobot, *objRobotBody, *objRobotLeftArm, *objRobotRightArm;
	treenode *objHurstTank,*objHurstTankBody;
	//treenode *objHurstTankRightTread,*objHurstTankLeftTread;
	treenode *objHurstTankTop,*objHurstTankBarrel;


	//Helicopter

	root=node("root");
	root->f=tankZone;

	//Robot 1
	/*
	objRobot=node("robot 1");
	objRobot->f=drop_zone_robot;
	objRobot->engine=drop_zone_robot1_engine;
	addChild(cvs.root,objRobot);

	objRobotBody=node("robot1 body");
	objRobotBody->f=drawDropZoneRobot;
	objRobotBody->engine=empty;
	addChild(objRobot,objRobotBody);

	objRobotLeftArm=node("robot1 left arm");
	objRobotLeftArm->f=drawDropZoneRobotLeftArm;
	objRobotLeftArm->engine=empty;
	addChild(objRobot,objRobotLeftArm);

	objRobotRightArm=node("robot1 right arm");
	objRobotRightArm->f=drawDropZoneRobotRightArm;
	objRobotRightArm->engine=empty;
	addChild(objRobot,objRobotRightArm);
	*/

	//Hurst Tank

	objHurstTank=node("Hurst Tank");
	objHurstTank->f=hurstTank;
	objHurstTank->engine=hurstTank_Engine;
	addChild(root,objHurstTank);

	objHurstTankBody=node("Tank Body");
	objHurstTankBody->f=drawHurstTankBody;
	objHurstTankBody->engine=NULL;
	addChild(objHurstTank,objHurstTankBody);

	/*
	objHurstTankRightTread=node("Tank Right Tread");
	objHurstTankRightTread->f=drawHurstTankRightTread;
	objHurstTankRightTread->engine=NULL;
	addChild(objHurstTank,objHurstTankRightTread);

	objHurstTankLeftTread=node("Tank Left Tread");
	objHurstTankLeftTread->f=drawHurstTankLeftTread;
	objHurstTankLeftTread->engine=NULL;
	addChild(objHurstTank,objHurstTankLeftTread);
	*/

	objHurstTankTop=node("Tank Top");
	objHurstTankTop->f=drawHurstTankTop;
	objHurstTankTop->engine=NULL;
	addChild(objHurstTank,objHurstTankTop);

	objHurstTankBarrel=node("Tank Barrel");
	objHurstTankBarrel->f=drawHurstTankBarrel;
	objHurstTankBarrel->engine=NULL;
	addChild(objHurstTankTop,objHurstTankBarrel);

	//Opponent Tank

	objHurstTank=node("Opponent Tank");
	objHurstTank->f=opponentTank;
	objHurstTank->engine=opponent_tank_Engine;
	addChild(root,objHurstTank);

	objHurstTankBody=node("Opponent Tank Body");
	objHurstTankBody->f=drawHurstTankBody;
	objHurstTankBody->engine=NULL;
	addChild(objHurstTank,objHurstTankBody);

	objHurstTankTop=node("Opponent Tank Top");
	objHurstTankTop->f=drawOpponentTankTop;
	objHurstTankTop->engine=NULL;
	addChild(objHurstTank,objHurstTankTop);

	objHurstTankBarrel=node("Opponent Tank Barrel");
	objHurstTankBarrel->f=drawHurstTankBarrel;
	objHurstTankBarrel->engine=NULL;
	addChild(objHurstTankTop,objHurstTankBarrel);

}
void CMy3DFontView::maze1()
{
	//Row 1
    vMap[0][0] = 1;
    vMap[0][1] = 0;
    vMap[0][2] = 0;
    vMap[0][3] = 0;
    vMap[0][4] = 1;
    vMap[0][5] = 1;
    vMap[0][6] = 0;
    vMap[0][7] = 1;
    vMap[0][8] = 0;
    vMap[0][9] = 1;
    //Row 2
    vMap[1][0] = 1;
    vMap[1][1] = 0;
    vMap[1][2] = 1;
    vMap[1][3] = 1;
    vMap[1][4] = 1;
    vMap[1][5] = 1;
    vMap[1][6] = 0;
    vMap[1][7] = 0;
    vMap[1][8] = 0;
    vMap[1][9] = 1;
    //Row 3
    vMap[2][0] = 1;
    vMap[2][1] = 0;
    vMap[2][2] = 0;
    vMap[2][3] = 0;
    vMap[2][4] = 0;
    vMap[2][5] = 1;
    vMap[2][6] = 1;
    vMap[2][7] = 1;
    vMap[2][8] = 1;
    vMap[2][9] = 1;
    //Row 4
    vMap[3][0] = 1;
    vMap[3][1] = 0;
    vMap[3][2] = 1;
    vMap[3][3] = 1;
    vMap[3][4] = 0;
    vMap[3][5] = 1;
    vMap[3][6] = 1;
    vMap[3][7] = 1;
    vMap[3][8] = 0;
    vMap[3][9] = 1;
    //Row 5
    vMap[4][0] = 1;
    vMap[4][1] = 0;
    vMap[4][2] = 1;
    vMap[4][3] = 1;
    vMap[4][4] = 0;
    vMap[4][5] = 1;
    vMap[4][6] = 1;
    vMap[4][7] = 1;
    vMap[4][8] = 0;
    vMap[4][9] = 1;
    //Row 6
    vMap[5][0] = 1;
    vMap[5][1] = 0;
    vMap[5][2] = 1;
    vMap[5][3] = 0;
    vMap[5][4] = 0;
    vMap[5][5] = 0;
    vMap[5][6] = 0;
    vMap[5][7] = 0;
    vMap[5][8] = 0;
    vMap[5][9] = 1;
    //Row 7
    vMap[6][0] = 1;
    vMap[6][1] = 0;
    vMap[6][2] = 1;
    vMap[6][3] = 0;
    vMap[6][4] = 1;
    vMap[6][5] = 1;
    vMap[6][6] = 1;
    vMap[6][7] = 1;
    vMap[6][8] = 1;
    vMap[6][9] = 1;
    //Row 8
    vMap[7][0] = 1;
    vMap[7][1] = 0;
    vMap[7][2] = 1;
    vMap[7][3] = 0;
    vMap[7][4] = 0;
    vMap[7][5] = 0;
    vMap[7][6] = 0;
    vMap[7][7] = 1;
    vMap[7][8] = 1;
    vMap[7][9] = 1;
    //Row 9
    vMap[8][0] = 1;
    vMap[8][1] = 0;
    vMap[8][2] = 1;
    vMap[8][3] = 1;
    vMap[8][4] = 1;
    vMap[8][5] = 1;
    vMap[8][6] = 0;
    vMap[8][7] = 0;
    vMap[8][8] = 0;
    vMap[8][9] = 1;
    //Row 10
    vMap[9][0] = 1;
    vMap[9][1] = 1;
    vMap[9][2] = 1;
    vMap[9][3] = 1;
    vMap[9][4] = 1;
    vMap[9][5] = 1;
    vMap[9][6] = 1;
    vMap[9][7] = 1;
    vMap[9][8] = 1;
    vMap[9][9] = 1;

}
void CMy3DFontView::buildMaze()
{
 int i;
 int j;
 int index;

 GLfloat x;
 GLfloat z;

    z = -45.0f;
	for(i=0; i<=9; i++)
	{
        x = -45.0f;

		for(j=0; j<=9; j++)
		{
            if (vMap[i][j] == WALL_TYPE)
			{
				index=getWallObject();
				objWallList[index].m_available_flag=FALSE;
				objWallList[index].m_active_flag=TRUE;
				objWallList[index].m_x=x;
				objWallList[index].m_y=10.0f;
				objWallList[index].m_z=z;
				objWallList[index].m_hit=0;
			}
	        x = x + 60;
		}
        z = z + 60;
	}    

}
void CMy3DFontView::buildSpheres()
{
 int i;
 int j;
 int index;

 GLfloat x;
 GLfloat z;

    z = -45.0f;
	for(i=0; i<=9; i++)
	{
        x = -45.0f;

		for(j=0; j<=9; j++)
		{
			if(vMap[i][j] == EMPTY_TYPE)
			{
				index=getSphereObject();
				objSphereList[index].m_available_flag=FALSE;
				objSphereList[index].m_active_flag=TRUE;
				objSphereList[index].m_x=x;
				objSphereList[index].m_y=1.5f;
				objSphereList[index].m_z=z;
			}
	        x = x + 60;
		}
        z = z + 60;
	}    

}
void CMy3DFontView::resetTanks()
{
	tankEngine[0].x=20.0f;
	tankEngine[0].z=0.0f;
	tankEngine[0].m_angle_radians=1.57f;

	opponentEngine[0].x=0.0f;
	opponentEngine[0].z=-300.0f;
	opponentEngine[0].m_angle_radians=1.57f;

	buildMaze();
	buildSpheres();

	mLives+=3;

}
int CMy3DFontView::getObjectCount(int type)
{
	int i;
	int retval=0;

	if (type==WALL_TYPE)
	{
		for (i=0; i<OBJECT_LIST_SIZE; i++)
		{
			if(objWallList[i].m_active_flag==TRUE)
			{
				retval++;
			}
		}
	}
	else if(type==EMPTY_TYPE)
	{
		for (i=0; i<OBJECT_LIST_SIZE; i++)
		{
			if(objSphereList[i].m_active_flag==TRUE)
			{
				retval++;
			}
		}
	}
	return(retval);
}
void tankZone()
{
}
void hurstTank()
{
	mTank_Id=PLAYER_TANK;
	drawTankMissiles();
	drawExplosion();
}
void opponentTank()
{
	mTank_Id=OPPONENT_TANK;
	drawOpponentMissiles();
	drawExplosion();
}
void tankTop()
{
		GLfloat points[20][3] = {{-3.5f, -0.5f, 2.5f},
							{-3.5f, 0.5f, 2.5f},
							{2.5f, -0.5f, 2.5f},
							{2.0f, 0.5f, 2.5f},
							{3.5f, -0.5f, 0.5f},
							{3.0f, 0.5f, 0.5f},
							{2.5f, -0.5f, 0.5f},
							{2.5f, 0.5f, 0.5f},
							{2.5f, -0.5f, -0.5f},
							{2.50f, 0.5f, -0.5f},
							{3.5f, -0.5f, -0.5f},
							{3.0f, 0.5f, -0.5f},
							{2.5f, -0.5f, -2.5f},
							{2.0f, 0.5f, -2.5f},
							{-3.5f, -0.5f, -2.5f},
							{-3.5f, 0.5f, -2.5f},
							{2.0f, 0.5f, 0.5f},
							{2.0f, 0.5f, -0.5f},
							{-1.5f, -0.5f, 2.5f},
							{-1.5f, -0.5f, -2.5f}};

	GLUquadricObj *obj;
	GLfloat l;
	GLfloat w;
			
	obj = gluNewQuadric();

	if(mTank_Id==PLAYER_TANK)
	{
		goldMaterial();
	}
	else if(mTank_Id==OPPONENT_TANK)
	{
		blackPlasticMaterial();	
	}
	//glColor3ub(255, 255, 255);
	//glBindTexture(GL_TEXTURE_2D, TextureTwo);
	//glEnable(GL_TEXTURE_2D);

	// right
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 0.0f, 1.0f);
		glTexCoord2f(0.1f, 0.0f);
		glVertex3fv(points[0]);
		glTexCoord2f(0.7f, 0.0f);
		glVertex3fv(points[2]);
		glTexCoord2f(0.65f, 0.1f);
		glVertex3fv(points[3]);
		glTexCoord2f(0.1f, 0.1f);
		glVertex3fv(points[1]);
	glEnd();
	
	// front right
	glBegin(GL_QUADS);
		glNormal3f(0.8164965809277261f,0.4082482904638631f,0.4082482904638631f);
		glTexCoord2f(0.7f, 0.0f);
		glVertex3fv(points[2]);
		glTexCoord2f(0.875f, 0.275f);
		glVertex3fv(points[4]);
		glTexCoord2f(0.8f, 0.3f);
		glVertex3fv(points[5]);
		glTexCoord2f(0.65f, 0.1f);
		glVertex3fv(points[3]);
	glEnd();

	//glDisable(GL_TEXTURE_2D);
	//glColor3ub(220, 192, 156);

	// right cut out
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 0.0f, -1.0f);
		glVertex3fv(points[4]);
		glVertex3fv(points[6]);
		glVertex3fv(points[7]);
		glVertex3fv(points[5]);
	glEnd();

	// back cut out
	glBegin(GL_QUADS);
		glNormal3f(1.0f, 0.0f, 0.0f);
		glVertex3fv(points[6]);
		glVertex3fv(points[8]);
		glVertex3fv(points[9]);
		glVertex3fv(points[7]);
	glEnd();

	// left cut out
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 0.0f, 1.0f);
		glVertex3fv(points[8]);
		glVertex3fv(points[10]);
		glVertex3fv(points[11]);
		glVertex3fv(points[9]);
	glEnd();

	//glColor3ub(255, 255, 255);
	//glEnable(GL_TEXTURE_2D);

	// front left
	glBegin(GL_QUADS);
		glNormal3f(0.8164965809277261f,0.4082482904638631f,-0.4082482904638631f);
		glTexCoord2f(0.875f, 0.425f);
		glVertex3fv(points[10]);
		glTexCoord2f(0.775f, 0.625f);
		glVertex3fv(points[12]);
		glTexCoord2f(0.65f, 0.6f);
		glVertex3fv(points[13]);
		glTexCoord2f(0.8f, 0.4f);
		glVertex3fv(points[11]);
	glEnd();

	// left
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 0.0f, -1.0f);
		glTexCoord2f(0.65f, 0.7f);
		glVertex3fv(points[12]);
		glTexCoord2f(0.1f, 0.7f);
		glVertex3fv(points[14]);
		glTexCoord2f(0.1f, 0.6f);
		glVertex3fv(points[15]);
		glTexCoord2f(0.65f, 0.6f);
		glVertex3fv(points[13]);
	glEnd();

	// back
	glBegin(GL_QUADS);
		glNormal3f(-1.0f, 0.0f, 0.0f);
		glTexCoord2f(0.0f, 0.6f);
		glVertex3fv(points[14]);
		glTexCoord2f(0.0f, 0.1f);
		glVertex3fv(points[0]);
		glTexCoord2f(0.1f, 0.1f);
		glVertex3fv(points[1]);
		glTexCoord2f(0.1f, 0.6f);
		glVertex3fv(points[15]);
	glEnd();

	// top
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 1.0f, 0.0f);
		glTexCoord2f(0.1f, 0.1f);
		glVertex3fv(points[1]);
		glTexCoord2f(0.65f, 0.1f);
		glVertex3fv(points[3]);
		glTexCoord2f(0.65f, 0.6f);
		glVertex3fv(points[13]);
		glTexCoord2f(0.1f, 0.6f);
		glVertex3fv(points[15]);
	glEnd();

	// top front left
	glBegin(GL_TRIANGLES);
		glNormal3f(0.0f, 1.0f, 0.0f);
		glTexCoord2f(0.65f, 0.1f);
		glVertex3fv(points[3]);
		glTexCoord2f(0.8f, 0.3f);
		glVertex3fv(points[5]);
		glTexCoord2f(0.65f, 0.3f);
		glVertex3fv(points[16]);
	glEnd();

	// top front right
	glBegin(GL_TRIANGLES);
		glNormal3f(0.0f, 1.0f, 0.0f);
		glTexCoord2f(0.8f, 0.4f);
		glVertex3fv(points[11]);
		glTexCoord2f(0.65f, 0.6f);
		glVertex3fv(points[13]);
		glTexCoord2f(0.65f, 0.4f);
		glVertex3fv(points[17]);
	glEnd();

	// top front middle
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 1.0f, 0.0f);
		glTexCoord2f(0.7f, 0.3f);
		glVertex3fv(points[7]);
		glTexCoord2f(0.7f, 0.4f);
		glVertex3fv(points[9]);
		glTexCoord2f(0.65f, 0.4f);
		glVertex3fv(points[17]);
		glTexCoord2f(0.65f, 0.3f);
		glVertex3fv(points[16]);
	glEnd();

	//glDisable(GL_TEXTURE_2D);
	//glColor3ub(220, 192, 156);

	// bottom
	glBegin(GL_QUADS);
		glNormal3f(0.0f, -1.0f, 0.0f);
		glVertex3fv(points[14]);
		glVertex3fv(points[12]);
		glVertex3fv(points[2]);
		glVertex3fv(points[0]);
	glEnd();

	// bottom front right
	glBegin(GL_TRIANGLES);
		glNormal3f(0.0f, -1.0f, 0.0f);
		glVertex3fv(points[4]);
		glVertex3fv(points[2]);
		glVertex3fv(points[6]);
	glEnd();

	// bottom front right
	glBegin(GL_TRIANGLES);
		glNormal3f(0.0f, -1.0f, 0.0f);
		glVertex3fv(points[12]);
		glVertex3fv(points[10]);
		glVertex3fv(points[8]);
	glEnd();



	// door
	glPushMatrix();
		glTranslatef(0.0f, 0.0f, 0.5f);
		glRotatef(-90.0f, 1.0f, 0.0f, 0.0f);
		gluCylinder(obj, 0.75f, 0.75f, 0.75f, 20, 1);
		glTranslatef(0.0f, 0.0f, 0.75f);
		gluDisk(obj, 0.0, 0.75, 20, 1);
	glPopMatrix();

	// gun
	glTranslatef(1.0f, 0.0f, 0.5f);
	glRotatef(-90.f, 1.0f, 0.0f, 0.0f);
	gluCylinder(obj, 0.075f, 0.075f, 1.0f, 20, 1);
	glRotatef(90.0f, 1.0f, 0.0f, 0.0f);
	glTranslatef(0.0f, 1.0f, 0.0f);
	
	l = 0.25f;
	w = 0.125f;
	
	// bottom
	glBegin(GL_QUADS);
		glNormal3f(0.0f, -1.0f, 0.0f);
		glVertex3f(-l, -w, -w);
		glVertex3f(l, -w, -w);
		glVertex3f(l, -w, w);
		glVertex3f(-l, -w, w);
	glEnd();

	// top
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 1.0f, 0.0f);
		glVertex3f(-l, w, w);
		glVertex3f(l, w, w);
		glVertex3f(l, w, -w);
		glVertex3f(-l, w, -w);
	glEnd();

	// front
	glBegin(GL_QUADS);
		glNormal3f(1.0f, 0.0f, 0.0f);
		glVertex3f(l, -w, w);
		glVertex3f(l, -w, -w);
		glVertex3f(l, w, -w);
		glVertex3f(l, w, w);
	glEnd();

	// back
	glBegin(GL_QUADS);
		glNormal3f(-1.0f, 0.0f, 0.0f);
		glVertex3f(-l, -w, -w);
		glVertex3f(-l, -w, w);
		glVertex3f(-l, w, w);
		glVertex3f(-l, w, -w);
	glEnd();

	// right
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 0.0f, 1.0f);
		glVertex3f(-l, -w, w);
		glVertex3f(l, -w, w);
		glVertex3f(l, w, w);
		glVertex3f(-l, w, w);
	glEnd();

	// left
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 0.0f, -1.0f);
		glVertex3f(l, -w, -w);
		glVertex3f(-l, -w, -w);
		glVertex3f(-l, w, -w);
		glVertex3f(l, w, -w);
	glEnd();

	glTranslatef(l, 0.0f, 0.0f);
	glRotatef(90.f, 0.0f, 1.0f, 0.0f);
	gluCylinder(obj, 0.125f, 0.05f, 0.25f, 20, 1); 
	gluCylinder(obj, 0.05f, 0.05f, 1.5f, 20, 1.5);

	gluDeleteQuadric(obj);

}
void drawHurstTankTop()
{

	glTranslatef(0.0f, 2.2f, 0.0f);
	glRotatef((GLfloat) tankEngine[0].mTurretAngle, 0.0f, 1.0f, 0.0f);

	tankTop();
}
void drawOpponentTankTop()
{

	glTranslatef(0.0f, 2.2f, 0.0f);
	glRotatef((GLfloat) opponentEngine[0].mTurretAngle, 0.0f, 1.0f, 0.0f);

	tankTop();
}
void tankBarrel()
{
	GLUquadricObj *obj;

	obj = gluNewQuadric();

	if(mTank_Id==PLAYER_TANK)
	{
		bronzeMaterial();
	}
	else if(mTank_Id==OPPONENT_TANK)
	{
		pewterMaterial();
	}

	// right block
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 0.0f, 1.0f);
		glVertex3f(-0.4f, -0.4f, 0.4f);
		glVertex3f(0.4f, -0.4f, 0.4f);
		glVertex3f(0.4f, 0.4f, 0.4f);
		glVertex3f(-0.4f, 0.4f, 0.4f);
	glEnd();

	// left block
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 0.0f, -1.0f);
		glVertex3f(0.4f, -0.4f, -0.4f);
		glVertex3f(-0.4f, -0.4f, -0.4f);
		glVertex3f(-0.4f, 0.4f, -0.4f);
		glVertex3f(0.4f, 0.4f, -0.4f);
	glEnd();

	// top block
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 1.0f, 0.0f);
		glVertex3f(-0.4f, 0.4f, 0.4f);
		glVertex3f(0.4f, 0.4f, 0.4f);
		glVertex3f(0.4f, 0.4f, -0.4f);
		glVertex3f(-0.4f, 0.4f, -0.4f);
	glEnd();

	// bottom block
	glBegin(GL_QUADS);
		glNormal3f(0.0f, -1.0f, 0.0f);
		glVertex3f(-0.4f, -0.4f, -0.4f);
		glVertex3f(0.4f, -0.4f, -0.4f);
		glVertex3f(0.4f, -0.4f, 0.4f);
		glVertex3f(-0.4f, -0.4f, 0.4f);
	glEnd();

	// front block
	glBegin(GL_QUADS);
		glNormal3f(1.0f, 0.0f, 0.0f);
		glVertex3f(0.4f, -0.4f, 0.4f);
		glVertex3f(0.4f, -0.4f, -0.4f);
		glVertex3f(0.4f, 0.4f, -0.4f);
		glVertex3f(0.4f, 0.4f, 0.4f);
	glEnd();

	// front block
	glBegin(GL_QUADS);
		glNormal3f(-1.0f, 0.0f, 0.0f);
		glVertex3f(-0.4f, -0.4f, -0.4f);
		glVertex3f(-0.4f, -0.4f, 0.4f);
		glVertex3f(-0.4f, 0.4f, 0.4f);
		glVertex3f(-0.4f, 0.4f, -0.4f);
	glEnd();
	
	// barrel
	glTranslatef(0.4f, 0.0f, 0.0f);
	glRotatef(90.0f, 0.0f, 1.0f, 0.0f);
	gluCylinder(obj, 0.3f, 0.3f, 2.0f, 10, 2);
	glTranslatef(0.0f, 0.0f, 2.0f);
	gluDisk(obj, 0.3f, 0.4f, 20, 2);
	gluCylinder(obj, 0.4f, 0.4f, 1.0f, 10, 1);
	glTranslatef(0.0f, 0.0f, 1.0f);
	gluDisk(obj, 0.2f, 0.4f, 20, 2);
	
	glColor3ub(0, 0, 0);
	gluDisk(obj, .0, .2, 10, 1);
	glColor3ub(220, 192, 156);

	gluCylinder(obj, 0.2f, 0.2f, 3.0f, 10, 3);
	glTranslatef(0.0f, 0.0f, 3.0f);
	gluDisk(obj, .16, .2, 20, 2);

	gluDeleteQuadric(obj);

}
void drawHurstTankBarrel()
{
	static float mAngleT=-90.0f;
	static float mAngleB=0.0f;

	glPushMatrix();
		glTranslatef(0.5f,-1.0f,1.5f);
		//glTranslatef(3.0f, 2.2f, 0.0f);
		glRotatef(mAngleT, 0.0f, 1.0f, 0.0f);
		glRotatef(mAngleB, 0.0f, 0.0f, 1.0f);
		tankBarrel();	
	glPopMatrix();
}

void drawHurstTankBody()
{
		GLfloat points[8][3] = {{-5.5f, -0.5f, 2.0f},
							{-5.5f, 0.5f, 2.0f},
							{4.5f, -0.5f, 2.0f},
							{5.5f, 0.5f, 2.0f},
							{4.5f, -0.5f, -2.0f},
							{5.5f, 0.5f, -2.0f},
							{-5.5f, -0.5f, -2.0f},
							{-5.5f, 0.5f, -2.0f}};

	GLUquadricObj *obj;
	
	obj = gluNewQuadric();

	if(mTank_Id==PLAYER_TANK)
	{
		copperMaterial();
	}
	else if(mTank_Id==OPPONENT_TANK)
	{
		pewterMaterial();
	}

	// inner right
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 0.0f, 1.0f);
		glVertex3fv(points[0]);
		glVertex3fv(points[2]);
		glVertex3fv(points[3]);
		glVertex3fv(points[1]);
	glEnd();

	// innner left
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 0.0f, -1.0f);
		glVertex3fv(points[4]);
		glVertex3fv(points[6]);
		glVertex3fv(points[7]);
		glVertex3fv(points[5]);
	glEnd();

	//glColor3ub(255, 255, 255);
	//glBindTexture(GL_TEXTURE_2D, TextureThree);
	//glEnable(GL_TEXTURE_2D);

	// top
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 1.0f, 0.0f);
		glTexCoord2f(0.1f, 0.2f);
		glVertex3fv(points[1]);
		glTexCoord2f(0.9f, 0.2f);
		glVertex3fv(points[3]);
		glTexCoord2f(0.9f, 0.8f);
		glVertex3fv(points[5]);
		glTexCoord2f(0.1f, 0.8f);
		glVertex3fv(points[7]);
	glEnd();

	// front
	glBegin(GL_QUADS);
		glNormal3f(0.7071067811865475f,-0.7071067811865475f,0.0f);
		glTexCoord2f(1.0f, 0.2f);
		glVertex3fv(points[2]);
		glTexCoord2f(1.0f, 0.8f);
		glVertex3fv(points[4]);
		glTexCoord2f(0.9f, 0.8f);
		glVertex3fv(points[5]);
		glTexCoord2f(0.9f, 0.2f);
		glVertex3fv(points[3]);
	glEnd();

	// back
	glBegin(GL_QUADS);
		glNormal3f(-1.0f, 0.0f, 0.0f);
		glTexCoord2f(0.0f, 0.8f);
		glVertex3fv(points[6]);
		glTexCoord2f(0.0f, 0.2f);
		glVertex3fv(points[0]);
		glTexCoord2f(0.1f, 0.2f);
		glVertex3fv(points[1]);
		glTexCoord2f(0.1f, 0.8f);
		glVertex3fv(points[7]);
	glEnd();

	//glDisable(GL_TEXTURE_2D);
	//glColor3ub(220, 192, 156);

	// bottom
	glBegin(GL_QUADS);
		glNormal3f(0.0f, -1.0f, 0.0f);
		glVertex3fv(points[6]);
		glVertex3fv(points[4]);
		glVertex3fv(points[2]);
		glVertex3fv(points[0]);
	glEnd();

	// right shield
	//glColor3ub(255, 255, 255);
	//glEnable(GL_TEXTURE_2D);

	// right top y1
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 1.0f, 0.0f);
		glTexCoord2f(0.1f, 0.1f);
		glVertex3f(-5.5f, 0.5f, 3.3f);
		glTexCoord2f(0.825f, 0.1f);
		glVertex3f(4.5f, 0.5f, 3.3f);
		glTexCoord2f(0.825f, 0.2f);
		glVertex3f(4.5f, 0.5f, 2.0f);
		glTexCoord2f(0.1f, 0.2f);
		glVertex3f(-5.5f, 0.5f, 2.0f);
	glEnd();

	//glDisable(GL_TEXTURE_2D);
	//glColor3ub(220, 192, 156);

	// right top y2
	glBegin(GL_QUADS);
		glNormal3f(0.0f, -1.0f, 0.0f);
		glVertex3f(-5.5f, 0.4f, 3.3f);
		glVertex3f(4.5f, 0.4f, 3.3f);
		glVertex3f(4.5f, 0.4f, 2.0f);
		glVertex3f(-5.5f, 0.4f, 2.0f);
	glEnd();

	// right top front
	glBegin(GL_QUADS);
		glNormal3f(1.0f, 0.0f, 0.0f);
		glVertex3f(4.5f, 0.4f, 3.3f);
		glVertex3f(4.5f, 0.4f, 2.0f);
		glVertex3f(4.5f, 0.5f, 2.0f);
		glVertex3f(4.5f, 0.5f, 3.3f);
	glEnd();

	// right top back
	glBegin(GL_QUADS);
		glNormal3f(-1.0f, 0.0f, 0.0f);
		glVertex3f(-5.5f, 0.4f, 2.0f);
		glVertex3f(-5.5f, 0.4f, 3.3f);
		glVertex3f(-5.5f, 0.5f, 3.3f);
		glVertex3f(-5.5f, 0.5f, 2.0f);
	glEnd();

	//glColor3ub(255, 255, 255);
	//glEnable(GL_TEXTURE_2D);
	
	// right side z1
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 0.0f, 1.0f);
		glTexCoord2f(0.1f, 0.0f);
		glVertex3f(-5.5f, -0.5f, 3.3f);
		glTexCoord2f(0.9f, 0.0f);
		glVertex3f(5.0f, -0.5f, 3.3f);
		glTexCoord2f(0.9f, 0.1f);
		glVertex3f(5.5f, 0.5f, 3.3f);
		glTexCoord2f(0.1f, 0.1f);
		glVertex3f(-5.5f, 0.5f, 3.3f);
	glEnd();

	//glDisable(GL_TEXTURE_2D);
	//glColor3ub(220, 192, 156);

	// right side z2
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 0.0f, -1.0f);
		glVertex3f(5.0f, -0.5f, 3.2f);
		glVertex3f(-5.5f, -0.5f, 3.2f);
		glVertex3f(-5.5f, 0.5f, 3.2f);
		glVertex3f(5.5f, 0.5f, 3.2f);
	glEnd();

	// right side front
	glBegin(GL_QUADS);
		glNormal3f(0.7071067811865475f,-0.7071067811865475f,0.0f);
		glVertex3f(5.0f, -0.5f, 3.3f);
		glVertex3f(5.0f, -0.5f, 3.2f);
		glVertex3f(5.5f, 0.5f, 3.2f);
		glVertex3f(5.5f, 0.5f, 3.3f);
	glEnd();

	// right side back
	glBegin(GL_QUADS);
		glNormal3f(-1.0f, 0.0f, 0.0f);
		glVertex3f(-5.5f, -0.5f, 3.2f);
		glVertex3f(-5.5f, -0.5f, 3.3f);
		glVertex3f(-5.5f, 0.5f, 3.3f);
		glVertex3f(-5.5f, 0.5f, 3.2f);
	glEnd();

	// right side bottom
	glBegin(GL_QUADS);
		glNormal3f(0.0f, -1.0f, 0.0f);
		glVertex3f(-5.5f, -0.5f, 3.2f);
		glVertex3f(5.0f, -0.5f, 3.2f);
		glVertex3f(5.0f, -0.5f, 3.3f);
		glVertex3f(-5.5f, -0.5f, 3.3f);
	glEnd();

	// right side top
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 1.0f, 0.0f);
		glVertex3f(4.5f, 0.5f, 3.3f);
		glVertex3f(5.5f, 0.5f, 3.3f);
		glVertex3f(5.5f, 0.5f, 3.2f);
		glVertex3f(4.5f, 0.5f, 3.2f);
	glEnd();

	// left shield

	//glColor3ub(255, 255, 255);
	//glEnable(GL_TEXTURE_2D);

	// left top y1
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 1.0f, 0.0f);
		glTexCoord2f(0.1f, 0.8f);
		glVertex3f(-5.5f, 0.5f, -2.0f);
		glTexCoord2f(0.825f, 0.8f);
		glVertex3f(4.5f, 0.5f, -2.0f);
		glTexCoord2f(0.825f, 0.9f);
		glVertex3f(4.5f, 0.5f, -3.3f);
		glTexCoord2f(0.1f, 0.9f);
		glVertex3f(-5.5f, 0.5f, -3.3f);
	glEnd();

	//glDisable(GL_TEXTURE_2D);
	//glColor3ub(220, 192, 156);

	// left top y2
	glBegin(GL_QUADS);
		glNormal3f(0.0f, -1.0f, 0.0f);
		glVertex3f(-5.5f, 0.4f, -2.0f);
		glVertex3f(4.5f, 0.4f, -2.0f);
		glVertex3f(4.5f, 0.4f, -3.3f);
		glVertex3f(-5.5f, 0.4f, -3.3f);
	glEnd();

	// left top front
	glBegin(GL_QUADS);
		glNormal3f(1.0f, 0.0f, 0.0f);
		glVertex3f(4.5f, 0.4f, -2.0f);
		glVertex3f(4.5f, 0.4f, -3.3f);
		glVertex3f(4.5f, 0.5f, -3.3f);
		glVertex3f(4.5f, 0.5f, -2.0f);
	glEnd();

	// left top back
	glBegin(GL_QUADS);
		glNormal3f(-1.0f, 0.0f, 0.0f);
		glVertex3f(-5.5f, 0.4f, -3.3f);
		glVertex3f(-5.5f, 0.4f, -2.0f);
		glVertex3f(-5.5f, 0.5f, -2.0f);
		glVertex3f(-5.5f, 0.5f, -3.3f);
	glEnd();

	//glColor3ub(255, 255, 255);
	//glEnable(GL_TEXTURE_2D);

	// left side z1
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 0.0f, -1.0f);
		glTexCoord2f(0.9f, 1.0f);
		glVertex3f(5.0f, -0.5f, -3.3f);
		glTexCoord2f(0.1f, 1.0f);
		glVertex3f(-5.5f, -0.5f, -3.3f);
		glTexCoord2f(0.1f, 0.9f);
		glVertex3f(-5.5f, 0.5f, -3.3f);
		glTexCoord2f(0.9f, 0.9f);
		glVertex3f(5.5f, 0.5f, -3.3f);
	glEnd();

	//glDisable(GL_TEXTURE_2D);
	//glColor3ub(220, 192, 156);

	// left side z2
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 0.0f, 1.0f);
		glVertex3f(-5.5f, -0.5f, -3.2f);
		glVertex3f(5.0f, -0.5f, -3.2f);
		glVertex3f(5.5f, 0.5f, -3.2f);
		glVertex3f(-5.5f, 0.5f, -3.2f);
	glEnd();

	// left side front
	glBegin(GL_QUADS);
		glNormal3f(0.7071067811865475f,-0.7071067811865475f,0.0f);
		glVertex3f(5.0f, -0.5f, -3.2f);
		glVertex3f(5.0f, -0.5f, -3.3f);
		glVertex3f(5.5f, 0.5f, -3.3f);
		glVertex3f(5.5f, 0.5f, -3.2f);
	glEnd();

	// left side back
	glBegin(GL_QUADS);
		glNormal3f(-1.0f, 0.0f, 0.0f);
		glVertex3f(-5.5f, -0.5f, -3.3f);
		glVertex3f(-5.5f, -0.5f, -3.2f);
		glVertex3f(-5.5f, 0.5f, -3.2f);
		glVertex3f(-5.5f, 0.5f, -3.3f);
	glEnd();

	// left side bottom
	glBegin(GL_QUADS);
		glNormal3f(0.0f, -1.0f, 0.0f);
		glVertex3f(-5.5f, -0.5f, -3.3f);
		glVertex3f(5.0f, -0.5f, -3.3f);
		glVertex3f(5.0f, -0.5f, -3.2f);
		glVertex3f(-5.5f, -0.5f, -3.2f);
	glEnd();

	// left side top
	glBegin(GL_QUADS);
		glNormal3f(0.0f, 1.0f, 0.0f);
		glVertex3f(4.5f, 0.5f, -3.2f);
		glVertex3f(5.5f, 0.5f, -3.2f);
		glVertex3f(5.5f, 0.5f, -3.3f);
		glVertex3f(4.5f, 0.5f, -3.3f);
	glEnd();

	// door
	glPushMatrix();
		glTranslatef(4.5f, 0.4f, 0.0f);
		glRotatef(-90.0f, 1.0f, 0.0f, 0.0f);
		gluCylinder(obj, 0.75f, 0.75f, 0.25f, 20, 1);
		glTranslatef(0.0f, 0.0f, 0.25f);
		gluDisk(obj, 0.0, 0.75, 20, 1);
	glPopMatrix();

	gluDeleteQuadric(obj);

}
void drawHurstTankWheel()
{
	GLUquadricObj *obj;

	bronzeMaterial();

	obj= gluNewQuadric();

	glPushMatrix();
		// outer wheel
		gluCylinder(obj, 0.5f, 0.5f, 1.0f, 10, 1);
		// inner wheel
		gluCylinder(obj, 0.4f, 0.4f, 1.0f, 10, 1);
		// axle
		gluCylinder(obj, 0.1f, 0.1f, 1.0f, 10, 1);
		
		glTranslatef(0.0f, 0.0f, 0.5f);
		// hub
		gluDisk(obj, 0.0, 0.4, 10, 1);

		glTranslatef(0.0f, 0.0f, 0.5f);
		// wheel cap
		gluDisk(obj, 0.4, 0.5, 10, 2);
		// axle cap
		gluDisk(obj, 0.0, 0.15, 10, 1);
	glPopMatrix();

	gluDeleteQuadric(obj);
}
void drawHurstTankLeftTread()
{
	glPushMatrix();
	//glRotatef(180.0f, 0.0f, 1.0f, 0.0f);

	glTranslatef(-10.0f, 0.0f, 0.0f);
	// wheel 1
	drawHurstTankWheel();

	glTranslatef(-1.5f, -0.5f, 0.0f);
	// wheel 2
	drawHurstTankWheel();

	glTranslatef(-1.25f, 0.0f, 0.0f);
	// wheel 3
	drawHurstTankWheel();

	glTranslatef(-1.25f, 0.0f, 0.0f);
	// wheel 4
	drawHurstTankWheel();

	glTranslatef(-1.25f, 0.0f, 0.0f);
	// wheel 5
	drawHurstTankWheel();

	glTranslatef(-1.25f, 0.0f, 0.0f);
	// wheel 6
	drawHurstTankWheel();

	glTranslatef(-1.25f, 0.0f, 0.0f);
	// wheel 7
	drawHurstTankWheel();

	glTranslatef(-1.25f, 0.0f, 0.0f);
	// wheel 8
	drawHurstTankWheel();

	glTranslatef(-1.0f, 0.5f, 0.0f);
	// wheel 9
	drawHurstTankWheel();

	glPopMatrix();
}

void drawHurstTankRightTread()
{
	glPushMatrix();
	// rotate tank 180 (forward is now left)
	//glRotatef(180.0f, 0.0f, 1.0f, 0.0f);

	glTranslatef(10.0f, 0.0f, 0.0f);
	// wheel 1
	drawHurstTankWheel();

	glTranslatef(1.5f, -0.5f, 0.0f);
	// wheel 2
	drawHurstTankWheel();

	glTranslatef(1.25f, 0.0f, 0.0f);
	// wheel 3
	drawHurstTankWheel();

	glTranslatef(1.25f, 0.0f, 0.0f);
	// wheel 4
	drawHurstTankWheel();

	glTranslatef(1.25f, 0.0f, 0.0f);
	// wheel 5
	drawHurstTankWheel();

	glTranslatef(1.25f, 0.0f, 0.0f);
	// wheel 6
	drawHurstTankWheel();

	glTranslatef(1.25f, 0.0f, 0.0f);
	// wheel 7
	drawHurstTankWheel();

	glTranslatef(1.25f, 0.0f, 0.0f);
	// wheel 8
	drawHurstTankWheel();

	glTranslatef(1.0f, 0.5f, 0.0f);
	// wheel 9
	drawHurstTankWheel();
	glPopMatrix();
}
void opponent_tank_Engine()
{
	GLfloat x,y,z,x2,z2;
	GLfloat distance1,distance2,distance3;
	int direction;
	GLfloat angle;
	static long current_clicks=clock();

	x=tankEngine[0].x;
	z=tankEngine[0].z;

	angle=opponentEngine[0].m_angle_radians;

	//straight line displacement
	x2 = (GLfloat) (opponentEngine[0].m_displacement*cos(angle)+opponentEngine[0].x);
	z2 = (GLfloat) (-opponentEngine[0].m_displacement*sin(angle)+opponentEngine[0].z);

	distance1=(GLfloat) sqrt((x-x2)*(x-x2)+(z-z2)*(z-z2));

	//left of center displacement
	x2 = (GLfloat) (opponentEngine[0].m_displacement*cos(angle+(1.57f/4.0f))+opponentEngine[0].x);
	z2 = (GLfloat) (-opponentEngine[0].m_displacement*sin(angle+(1.57f/4.0f))+opponentEngine[0].z);

	distance2=(GLfloat) sqrt((x-x2)*(x-x2)+(z-z2)*(z-z2));

	//right of center displacement
	x2 = (GLfloat) (opponentEngine[0].m_displacement*cos(angle-(1.57f/4.0f))+opponentEngine[0].x);
	z2 = (GLfloat) (-opponentEngine[0].m_displacement*sin(angle-(1.57f/4.0f))+opponentEngine[0].z);

	distance3=(GLfloat) sqrt((x-x2)*(x-x2)+(z-z2)*(z-z2));

	if(distance1>90)
	{

		if (
			(distance2<distance1) &&
			(distance2<distance3)
			)
			
		{
			//right
			direction=RIGHT_DIRECTION;
			opponentEngine[0].m_displacement=1.0f;
		}
		else if(
			(distance3<distance1) &&
			(distance3<distance2)
			)
		{
			//left
			direction=LEFT_DIRECTION;
			opponentEngine[0].m_displacement=1.0f;
		}
		else
		{
			direction=FORWARD_DIRECTION;
			opponentEngine[0].m_displacement=3.0f+mLevel;
		}
		
		moveOpponentEngine(&opponentEngine[0],direction);
	}
	else
	{
		if((clock()-current_clicks)>(2000/mLevel))
		{
			if (
				(distance2<distance1) &&
				(distance2<distance3)
				)
				
			{
				//right
				direction=RIGHT_DIRECTION;
				opponentEngine[0].m_displacement=0.1f;
			}
			else if(
				(distance3<distance1) &&
				(distance3<distance2)
				)
			{
				//left
				direction=LEFT_DIRECTION;
				opponentEngine[0].m_displacement=0.1f;
			}
			else
			{
				direction=FORWARD_DIRECTION;
				opponentEngine[0].m_displacement=0.2f;
			}

			
			moveOpponentEngine(&opponentEngine[0],direction);

					//add levels later
			fireOpponentMissile();

			current_clicks=clock();
		}
	}

	x=opponentEngine[0].x;
	z=opponentEngine[0].z;
	y=0.0f;

	glTranslatef(x,0.0f,z);
	glRotatef(dRadToDeg(opponentEngine[0].m_angle_radians), 0.0f, 1.0f, 0.0f);


	glScalef(2.0f,2.0f,2.0f);
}
int checkTankCollision(Engine *objEngine,GLfloat xDelta,GLfloat zDelta)
{
	GLfloat opponent_tank_x1,opponent_tank_x2;
	GLfloat opponent_tank_z1,opponent_tank_z2;

	GLfloat tank_x1,tank_x2;
	GLfloat tank_z1,tank_z2;

	tank_x1=objEngine->x+xDelta-8;
	tank_x2=objEngine->x+xDelta+8;

	tank_z1=objEngine->z+zDelta-8;
	tank_z2=objEngine->z+zDelta+8;

	opponent_tank_x1=opponentEngine[0].x-6;
	opponent_tank_x2=opponentEngine[0].x+6;

	opponent_tank_z1=opponentEngine[0].z-6;
	opponent_tank_z2=opponentEngine[0].z+6;

	/*
	glPushMatrix();
		glBegin(GL_LINE_LOOP);
			glVertex3f(opponent_tank_x1,5.0f,opponent_tank_z1);
			glVertex3f(opponent_tank_x2,5.0f,opponent_tank_z1);
			glVertex3f(opponent_tank_x2,5.0f,opponent_tank_z2);
			glVertex3f(opponent_tank_x1,5.0f,opponent_tank_z2);
		glEnd();
		glBegin(GL_LINE_LOOP);
			glVertex3f(tank_x1,5.0f,tank_z1);
			glVertex3f(tank_x2,5.0f,tank_z1);
			glVertex3f(tank_x2,5.0f,tank_z2);
			glVertex3f(tank_x1,5.0f,tank_z2);
		glEnd();
	glPopMatrix();
	*/

	if(

			insideBoundary(tank_x1, tank_z1,
			opponent_tank_x1,opponent_tank_x2,
			opponent_tank_z1,opponent_tank_z2)
			||
			insideBoundary(tank_x2, tank_z1,
			opponent_tank_x1,opponent_tank_x2,
			opponent_tank_z1,opponent_tank_z2)
			||
			insideBoundary(tank_x1, tank_z2,
			opponent_tank_x1,opponent_tank_x2,
			opponent_tank_z1,opponent_tank_z2)
			||
			insideBoundary(tank_x2, tank_z2,
			opponent_tank_x1,opponent_tank_x2,
			opponent_tank_z1,opponent_tank_z2)
		)
		{
			return(1);
		}

		return(0);
}
void hurstTank_Engine()
{
	//GLfloat pitch,roll;
	GLfloat x,y,z;

	moveEngine(&tankEngine[0]);

	x=tankEngine[0].x;
	z=tankEngine[0].z;
	y=0.0f;

	/*
	if(bTerrain_Flag==1)
	{
		y=getTerrainHeight(x,z,&pitch,&roll);

		glTranslatef(x,y,z);
		glRotatef(pitch, 1.0f, 0.0f, 0.0f);
		glRotatef(roll, 0.0f, 0.0f, 1.0f);
	}
	else
	{
	*/
		glTranslatef(x,3.0f,z);
	//}

	glRotatef(dRadToDeg(tankEngine[0].m_angle_radians+((float)PI/2.0f))-90, 0.0f, 1.0f, 0.0f);

	glScalef(2.0f,2.0f,2.0f);
}
void moveEngine(Engine *objEngine)
{
	GLfloat xDelta,zDelta;

	checkSphereCollision(objEngine);

	xDelta = objEngine->m_displacement*(float) cos(objEngine->m_angle_radians);
	zDelta = -objEngine->m_displacement*(float) sin(objEngine->m_angle_radians);

	if(checkTankCollision(objEngine,xDelta,zDelta)==0)
	{
		if(checkWallCollision(objEngine,xDelta,zDelta)==0)
		{
		objEngine->x += xDelta;
		objEngine->z += zDelta;
		}
	}

	if(objEngine->x > GRID_SIZE)
		objEngine->x = (float) GRID_SIZE;

	if(objEngine->x < -GRID_SIZE)
		objEngine->x = (float) -GRID_SIZE;
	
	if(objEngine->z > GRID_SIZE)
	   objEngine->z = (float) GRID_SIZE;

	if(objEngine->z < -GRID_SIZE)
	   objEngine->z = (float) -GRID_SIZE;


}
void moveOpponentEngine(Engine *objEngine,int direction)
{
	GLfloat xDelta,zDelta;
	//clock_t current_clicks;
	//clock_t interval_clicks;

	//current_clicks=clock();

	//interval_clicks=current_clicks - objEngine->m_movement_interval;

	//if (interval_clicks>100)
	//{
		xDelta = objEngine->m_displacement*(float) cos(objEngine->m_angle_radians);
		zDelta = -objEngine->m_displacement*(float) sin(objEngine->m_angle_radians);

		if(checkWallCollision(objEngine,xDelta,zDelta)==0)
		{
			objEngine->x += xDelta;
			objEngine->z += zDelta;
			if(direction==RIGHT_DIRECTION)
			{
				objEngine->m_angle_radians+=1.57f/8.0f;
			}
			else if(direction==LEFT_DIRECTION)
			{
				objEngine->m_angle_radians-=1.57f/8.0f;
			}
		}
		else
		{
			//collision occurred with wall
			objEngine->m_angle_radians+=1.57f/8.0f;
			fireOpponentMissile();
		}
//		objEngine->m_movement_interval=clock();
//	}

	if(objEngine->x > GRID_SIZE)
		objEngine->x = (float) GRID_SIZE;

	if(objEngine->x < -GRID_SIZE)
		objEngine->x = (float) -GRID_SIZE;

	
	if(objEngine->z > GRID_SIZE)
	   objEngine->z = (float) GRID_SIZE;

	if(objEngine->z < -GRID_SIZE)
	   objEngine->z = (float) -GRID_SIZE;


}

void checkSphereCollision(Engine *objEngine)
{
	GLfloat distance;
	GLfloat x,y,z;
	int i;

		for(i=0; i<OBJECT_LIST_SIZE; i++)
		{
			if(objSphereList[i].m_active_flag==TRUE)
			{

				x=objEngine->x-objSphereList[i].m_x;
				y=objEngine->y-objSphereList[i].m_y;
				z=objEngine->z-objSphereList[i].m_z;

				distance=(GLfloat)sqrt(x*x+y*y+z*z);

				if (distance<10)
				{
					objSphereList[i].m_available_flag=TRUE;
					objSphereList[i].m_active_flag=FALSE;
					mTank_Score++;
					break;
				}

			}
		}

}
void setTimeOut(Engine *objEngine)
{
	objEngine->m_time_out=clock();
}
long ellaspedTimeOut(Engine *objEngine)
{
	return((long) (clock()-objEngine->m_time_out));
}
void fireTankMissile()
{
	GLint i;
	GLfloat turretRadian;

	i=getAvailableMissile();

	if(i>-1)
	{
		tankMissile[i].m_x=tankEngine[0].x;
		tankMissile[i].m_y=tankEngine[0].y;
		tankMissile[i].m_z=tankEngine[0].z;
		tankMissile[i].m_Vo=10.0f;
		turretRadian=(tankEngine[0].mTurretAngle/180.0f*3.142f);
		tankMissile[i].m_radsFromEast=tankEngine[0].m_angle_radians+turretRadian;
		tankMissile[i].m_available_flag=FALSE;
		tankMissile[i].m_active_flag=TRUE;
	}
}
void fireOpponentMissile()
{
	GLint i;
	GLfloat turretRadian;

	i=getAvailableOpponentMissile();

	if(i>-1)
	{
		opponentMissile[i].m_x=opponentEngine[0].x;
		opponentMissile[i].m_y=opponentEngine[0].y;
		opponentMissile[i].m_z=opponentEngine[0].z;
		opponentMissile[i].m_Vo=10.0f;
		turretRadian=(opponentEngine[0].mTurretAngle/180.0f*3.142f);
		opponentMissile[i].m_radsFromEast=opponentEngine[0].m_angle_radians+turretRadian;
		opponentMissile[i].m_available_flag=FALSE;
		opponentMissile[i].m_active_flag=TRUE;
	}
}
int getAvailableOpponentMissile()
{
	int i;
	for(i=0; i<NUMBER_OF_MISSILES; i++)
	{
		if (opponentMissile[i].m_available_flag==TRUE)
		{
			return(i);
		}
	}
	return(-1);
}
int getAvailableMissile()
{
	int i;
	for(i=0; i<NUMBER_OF_MISSILES; i++)
	{
		if (tankMissile[i].m_available_flag==TRUE)
		{
			return(i);
		}
	}
	return(-1);
}
void drawTankMissiles()
{
	GLint i=0;
	GLfloat x,z;
	GLfloat distance;
	GLint retVal;

	//checkMissileCollision(i,cvs.objBall[i].m_x,0,cvs.objBall[i].m_z);

	for(i=0; i<NUMBER_OF_MISSILES; i++)
	{
		if(tankMissile[i].m_available_flag==FALSE)
		{
			x=(tankMissile[i].m_Vo)*(float)cos(tankMissile[i].m_radsFromEast);
			z=-(tankMissile[i].m_Vo)*(float)sin(tankMissile[i].m_radsFromEast);

			tankMissile[i].m_x += x;
			tankMissile[i].m_z += z;

			destroyWall(tankMissile[i].m_x,tankMissile[i].m_z);

			retVal=checkOpponentTankHit(tankMissile[i].m_x,5.0f,tankMissile[i].m_z);

			if (retVal==1)
			{
				tankMissile[i].m_available_flag=TRUE;
				tankMissile[i].m_active_flag=FALSE;
				break;
			}
			else
			{
				glPushMatrix();
					glTranslatef(tankMissile[i].m_x,tankMissile[i].m_y,tankMissile[i].m_z);
					glScalef(0.5f,0.5f,0.5f);

					glPushMatrix();
						glRotatef(dRadToDeg(tankMissile[i].m_radsFromEast),0.0f,1.0f,0.0f);
						glTranslatef(45.0f,10.0f,0.0f);
						missileObject();
					glPopMatrix();

				glPopMatrix();
			}

			x=tankEngine[0].x-tankMissile[i].m_x;
			z=tankEngine[0].z-tankMissile[i].m_z;

			distance=(float) sqrt(x*x+tankMissile[i].m_y*tankMissile[i].m_y+z*z);
			if (distance>100)
			{
				tankMissile[i].m_available_flag=TRUE;
				tankMissile[i].m_active_flag=FALSE;
			}
		}
	}

	if(tankEngine[0].m_hit==3)
	{
		tankEngine[0].m_hit=0;
		opponentEngine[0].x=0.0f;
		opponentEngine[0].z=-300.0f;
		opponentEngine[0].m_angle_radians=1.57f;
		mTank_Score+=100;
	}

}
void destroyWall(GLfloat x,GLfloat z)
{
	int i;
	GLfloat wall_x1,wall_x2;
	GLfloat wall_z1,wall_z2;

	for(i=0; i<OBJECT_LIST_SIZE; i++)
	{
		if(objWallList[i].m_active_flag==TRUE)
		{
			wall_x1=objWallList[i].m_x-30; //left
			wall_x2=objWallList[i].m_x+30; //right
			wall_z1=objWallList[i].m_z-30; //forward
			wall_z2=objWallList[i].m_z+30; //backward
		}

		/*
		glPushMatrix();
			glBegin(GL_LINE_LOOP);
				glVertex3f(wall_x1,5.0f,wall_z1);
				glVertex3f(wall_x2,5.0f,wall_z1);
				glVertex3f(wall_x2,5.0f,wall_z2);
				glVertex3f(wall_x1,5.0f,wall_z2);
			glEnd();
		glPopMatrix();
		*/

		if(

				insideBoundary(x, z,
			   	wall_x1,wall_x2,
				wall_z1,wall_z2)
				||
				insideBoundary(x, z,
			   	wall_x1,wall_x2,
				wall_z1,wall_z2)
				||
				insideBoundary(x, z,
			   	wall_x1,wall_x2,
				wall_z1,wall_z2)
				||
				insideBoundary(x, z,
			   	wall_x1,wall_x2,
				wall_z1,wall_z2)
			)
			{
				objWallList[i].m_hit++;
				if(objWallList[i].m_hit>3)
				{
					objWallList[i].m_active_flag=FALSE;
				}
				break;
			}
	}

}
void drawOpponentMissiles()
{
	GLint i=0;
	GLfloat x,z;
	GLfloat distance;
	GLint retVal;

	//checkMissileCollision(i,cvs.objBall[i].m_x,0,cvs.objBall[i].m_z);

	for(i=0; i<NUMBER_OF_MISSILES; i++)
	{
		if(opponentMissile[i].m_available_flag==FALSE)
		{
			x=(opponentMissile[i].m_Vo)*(float)cos(opponentMissile[i].m_radsFromEast);
			z=-(opponentMissile[i].m_Vo)*(float)sin(opponentMissile[i].m_radsFromEast);

			opponentMissile[i].m_x += x;
			opponentMissile[i].m_z += z;

			destroyWall(opponentMissile[i].m_x,opponentMissile[i].m_z);

			retVal=checkTankHit(opponentMissile[i].m_x,5.0f,opponentMissile[i].m_z);

			if (retVal==1)
			{
				opponentMissile[i].m_available_flag=TRUE;
				opponentMissile[i].m_active_flag=FALSE;
				break;
			}
			else
			{
			
				glPushMatrix();
					glTranslatef(opponentMissile[i].m_x,opponentMissile[i].m_y,opponentMissile[i].m_z);
					glScalef(0.5f,0.5f,0.5f);

					glPushMatrix();
						glRotatef(dRadToDeg(opponentMissile[i].m_radsFromEast),0.0f,1.0f,0.0f);
						glTranslatef(45.0f,10.0f,0.0f);
						missileObject();
					glPopMatrix();

					//Sphere(5,10,10);
				glPopMatrix();
			}

			x=opponentEngine[0].x-opponentMissile[i].m_x;
			z=opponentEngine[0].z-opponentMissile[i].m_z;

			distance=(float) sqrt(x*x+opponentMissile[i].m_y*opponentMissile[i].m_y+z*z);
			if (distance>100)
			{
				opponentMissile[i].m_available_flag=TRUE;
				opponentMissile[i].m_active_flag=FALSE;
			}
		}
	}

	if(opponentEngine[0].m_hit==3)
	{
		opponentEngine[0].m_hit=0;
		tankEngine[0].x=20.0f;
		tankEngine[0].z=-50.0f;
		tankEngine[0].m_angle_radians=-1.57f;
		mLives--;
	}

}
int checkTankHit(GLfloat x,GLfloat y,GLfloat z)
{
int retval;
GLfloat tank_x,tank_y,tank_z;
GLfloat vector_x,vector_y,vector_z;
GLfloat distance;
int index;

	retval=0;

	tank_x=tankEngine[0].x;
	tank_y=tankEngine[0].y;
	tank_z=tankEngine[0].z;

	vector_x=tank_x-x;
	vector_y=tank_y-y;
	vector_z=tank_z-z;

	distance=(GLfloat) sqrt(vector_x*vector_x+vector_y*vector_y+vector_z*vector_z);

	if(distance<=10)
	{
		opponentEngine[0].m_hit++;

		index=getAvailableExplosion();
		if(index>-1)
		{
			objExplosion[index].x=x;
			objExplosion[index].y=y;
			objExplosion[index].z=z;
			objExplosion[index].m_cpu_seconds=clock();
		}

		//sound("hit.wav");
		retval=1;

		return(retval);
	}

	return(retval);
}

int checkOpponentTankHit(GLfloat x,GLfloat y,GLfloat z)
{
int retval;
GLfloat opponent_tank_x,opponent_tank_y,opponent_tank_z;
GLfloat vector_x,vector_y,vector_z;
GLfloat distance;
int index;

	retval=0;

	opponent_tank_x=opponentEngine[0].x;
	opponent_tank_y=opponentEngine[0].y;
	opponent_tank_z=opponentEngine[0].z;

	vector_x=opponent_tank_x-x;
	vector_y=opponent_tank_y-y;
	vector_z=opponent_tank_z-z;

	distance=(GLfloat) sqrt(vector_x*vector_x+vector_y*vector_y+vector_z*vector_z);

	if(distance<=10)
	{
		tankEngine[0].m_hit++;

		index=getAvailableExplosion();
		if(index>-1)
		{
			objExplosion[index].x=x;
			objExplosion[index].y=y;
			objExplosion[index].z=z;
			objExplosion[index].m_cpu_seconds=clock();
		}


		//sound("hit.wav");
		retval=1;

		return(retval);
	}

	return(retval);
}


void missileObject()
{
	glPushMatrix();
	copperMaterial();
	glScalef(0.5f,0.5f,0.5f);
	glRotatef(180.0f,0.0f,1.0f,0.0f);
	glRotatef(90.0f,0.0f,0.0f,1.0f);
	glPushMatrix();
		glPushMatrix();
			glTranslatef(0.0f,3.0f,0.0f);
			cone(1.5f,3.0f);
		glPopMatrix();

		cylinder(1.5f,10.0f);

		glPushMatrix();
			glTranslatef(0.0f,-5.0f,0.0f);
			glBegin(GL_POLYGON);
				glNormal3f(0.0f,1.0f,0.0f);
				glVertex3f(0.0f,0.0f,0.0f);
				glVertex3f(0.0f,-5.0f,0.0f);
				glVertex3f(-3.6f,-5.0f,0.0f);
				glVertex3f(-3.5f,-5.0f,0.0f);
			glEnd();

			glBegin(GL_POLYGON);
				glNormal3f(0.0f,1.0f,0.0f);
				glVertex3f(0.0f,0.0f,0.0f);
				glVertex3f(5.1f,-5.0f,0.0f);
				glVertex3f(5.0f,-5.0f,0.0f);
				glVertex3f(0.0f,-3.0f,0.0f);
			glEnd();
			
			glBegin(GL_POLYGON);
				glNormal3f(0.0f,1.0f,0.0f);
				glVertex3f(0.0f,0.0f,0.0f);
				glVertex3f(0.0f,-5.0f,0.0f);
				glVertex3f(5.0f,-5.0f,3.0f);
				glVertex3f(0.0f,-5.0f,0.0f);
			glEnd();

			glBegin(GL_POLYGON);
				glNormal3f(0.0f,1.0f,0.0f);
				glVertex3f(0.0f,0.0f,0.0f);
				glVertex3f(0.0f,-5.0f,0.0f);
				glVertex3f(5.0f,-5.0f,-3.0f);
				glVertex3f(0.0f,-5.0f,0.0f);
			glEnd();

		glPopMatrix();

	glPopMatrix();
glPopMatrix();
}
void cylinder(GLfloat radius,GLfloat height)
{
GLUquadricObj *obj = gluNewQuadric();
gluQuadricDrawStyle(obj,GLU_FILL);
gluQuadricNormals(obj,GLU_SMOOTH);
gluQuadricOrientation(obj,GLU_OUTSIDE);
gluQuadricTexture(obj, GL_TRUE);

/*Base Cylinder*/
glPushMatrix();
	/* Rotate about the X axis */
	glRotatef(90.0f,1.0f,0.0f,0.0f);
	/* qobj = quadric object
	baseRadius
	topRadius
	height,
	slices (Subdivisions around the Z axis)
	stacks (Subdivisions around the Z axis)
	*/
	gluCylinder(obj,radius,radius,height,10,10);
glPopMatrix(); 
/* Lid*/
glPushMatrix(); 
	glRotatef(-90.0f,1.0f,0.0f,0.0f);
	/* qobj = quadric object
	innerRadius = Inner radius of the disk
	outerRadius = Outer radius of the disk
	slices = number of subdivisions around the Z axis
	loops = number of concentric rings about the origin
	*/
	gluDisk(obj,0.0f,radius,10,10);
glPopMatrix();
	/*Bottom*/
glPushMatrix(); 
	glTranslatef(0.0f,-height,0.0f);
	glRotatef(90.0f,1.0f,0.0f,0.0f);
	/* qobj = quadric object
	innerRadius = Inner radius of the disk
	outerRadius = Outer radius of the disk
	slices = number of subdivisions around the Z axis
	loops = number of concentric rings about the origin
	*/
	gluDisk(obj,0.0f,radius,10,10);
glPopMatrix();

gluDeleteQuadric(obj);
}
void cone(GLfloat radius,GLfloat height)
{
GLUquadricObj *obj = gluNewQuadric();
gluQuadricDrawStyle(obj,GLU_FILL);
gluQuadricNormals(obj,GLU_SMOOTH);
gluQuadricOrientation(obj,GLU_OUTSIDE);
gluQuadricTexture(obj, GL_TRUE);

/*Base Cylinder*/
glPushMatrix();
	/* Rotate about the X axis */
	glRotatef(90.0f,1.0f,0.0f,0.0f);
	/* qobj = quadric object
	baseRadius
	topRadius
	height,
	slices (Subdivisions around the Z axis)
	stacks (Subdivisions around the Z axis)
	*/
	gluCylinder(obj,0,radius,height,20,10);
glPopMatrix(); 

/*Bottom*/
glPushMatrix(); 
	glTranslatef(0.0f,-height,0.0f);
	glRotatef(90.0f,1.0f,0.0f,0.0f);
	/* qobj = quadric object
	innerRadius = Inner radius of the disk
	outerRadius = Outer radius of the disk
	slices = number of subdivisions around the Z axis
	loops = number of concentric rings about the origin
	*/
	gluDisk(obj,0.0f,radius,20,20);
glPopMatrix();
gluDeleteQuadric(obj);
}
void box(GLfloat w,GLfloat h,GLfloat d)
{
	glBegin(GL_POLYGON);
		glNormal3f(0.0f,0.0f,1.0f);
		glTexCoord2f(0.0f, 1.0f);
		glVertex3f(1.0f*w,	1.0f*h,	1.0f*d);
		glTexCoord2f(0.0f, 0.0f);
		glVertex3f(-1.0f*w,	1.0f*h,	1.0f*d);
		glTexCoord2f(1.0f, 0.0f);
		glVertex3f(-1.0f*w,	-1.0f*h,	1.0f*d);
		glTexCoord2f(1.0f, 1.0f);
		glVertex3f(1.0f*w,	-1.0f*h,	1.0f*d);
	glEnd();

	glBegin(GL_POLYGON);
		glNormal3f(0.0f,0.0f,-1.0f);
		glTexCoord2f(0.0f, 1.0f);
		glVertex3f(1.0f*w,	1.0f*h,	-1.0f*d);
		glTexCoord2f(0.0f, 0.0f);
		glVertex3f(1.0f*w,	-1.0f*h,	-1.0f*d);
		glTexCoord2f(1.0f, 0.0f);
		glVertex3f(-1.0f*w,	-1.0f*h,	-1.0f*d);
		glTexCoord2f(1.0f, 1.0f);
		glVertex3f(-1.0f*w,	1.0f*h,	-1.0f*d);
	glEnd();

	glBegin(GL_POLYGON);
		glNormal3f(-1.0f,0.0f,0.0f);
		glTexCoord2f(0.0f, 1.0f);
		glVertex3f(-1.0f*w,	1.0f*h,	1.0f*d);
		glTexCoord2f(0.0f, 0.0f);
		glVertex3f(-1.0f*w,	1.0f*h,	-1.0f*d);
		glTexCoord2f(1.0f, 0.0f);
		glVertex3f(-1.0f*w,	-1.0f*h,	-1.0f*d);
		glTexCoord2f(1.0f, 1.0f);
		glVertex3f(-1.0f*w,	-1.0f*h,	1.0f*d);
	glEnd();

	glBegin(GL_POLYGON);
		glNormal3f(1.0f,0.0f,0.0f);
		glTexCoord2f(0.0f, 1.0f);
		glVertex3f(1.0f*w,	1.0f*h,	1.0f*d);
		glTexCoord2f(0.0f, 0.0f);
		glVertex3f(1.0f*w,	-1.0f*h,	1.0f*d);
		glTexCoord2f(1.0f, 0.0f);
		glVertex3f(1.0f*w,	-1.0f*h,	-1.0f*d);
		glTexCoord2f(1.0f, 1.0f);
		glVertex3f(1.0f*w,	1.0f*h,	-1.0f*d);
	glEnd();

	glBegin(GL_POLYGON);
		glNormal3f(0.0f,1.0f,0.0f);
		glTexCoord2f(0.0f, 1.0f);
		glVertex3f(-1.0f*w,	1.0f*h,	-1.0f*d);
		glTexCoord2f(0.0f, 0.0f);
		glVertex3f(-1.0f*w,	1.0f*h,	1.0f*d);
		glTexCoord2f(1.0f, 0.0f);
		glVertex3f(1.0f*w,	1.0f*h,	1.0f*d);
		glTexCoord2f(1.0f, 1.0f);
		glVertex3f(1.0f*w,	1.0f*h,	-1.0f*d);
	glEnd();

	glBegin(GL_POLYGON);
		glNormal3f(0.0f,-1.0f,0.0f);
		glTexCoord2f(0.0f, 1.0f);
		glVertex3f(-1.0f*w,	-1.0f*h,	-1.0f*d);
		glTexCoord2f(0.0f, 0.0f);
		glVertex3f(1.0f*w,	-1.0f*h,	-1.0f*d);
		glTexCoord2f(1.0f, 0.0f);
		glVertex3f(1.0f*w,	-1.0f*h,	1.0f*d);
		glTexCoord2f(1.0f, 1.0f);
		glVertex3f(-1.0f*w,	-1.0f*h,	1.0f*d);
	glEnd();

}
void brassMaterial()
{
	  setAmbientMaterialColor(0.329412f,0.223529f,0.027451f,1.0f);
	  setDiffuseMaterialColor(0.780392f,0.568627f,0.113725f,1.0f);
	  setSpecularMaterialColor(0.992157f,0.941176f,0.807843f,1.0f);
      setMaterialShininess(27.8974f);
}
void pewterMaterial()
{
	setAmbientMaterialColor(0.10588f,0.058824f,0.113725f,1.0f);
	setDiffuseMaterialColor(0.427451f,0.470588f,0.541176f,1.0f);
	setSpecularMaterialColor(0.3333f,0.3333f,0.521569f,1.0f);
	setMaterialShininess(9.84615f);
}
void blackPlasticMaterial()
{
	setAmbientMaterialColor(0.0f,0.0f,0.0f,1.0f);
	setDiffuseMaterialColor(0.01f,0.01f,0.01f,1.0f);
	setSpecularMaterialColor(0.50f,0.50f,0.50f,1.0f);
	//setMaterialShininess(32);
	setMaterialShininess(64.0f);
}
void goldMaterial()
{
	setAmbientMaterialColor(0.24725f,0.1995f,0.0745f,1.0f);
	setDiffuseMaterialColor(0.75164f,0.60648f,0.22648f,1.0f);
	setSpecularMaterialColor(0.628281f,0.555802f,0.366065f,1.0f);
	setMaterialShininess(100.0f);
}
void bronzeMaterial()
{
	setAmbientMaterialColor(0.2125f,0.1275f,0.054f,1.0f);
	setDiffuseMaterialColor(0.714f,0.4284f,0.18144f,1.0f);
	setSpecularMaterialColor(0.393548f,0.271906f,0.166721f,1.0f);
	setMaterialShininess(25.6f);
}
void chromeMaterial()
{
	setAmbientMaterialColor(0.25f,0.25f,0.25f,1.0f);
	setDiffuseMaterialColor(0.4f,0.4f,0.4f,1.0f);
	setSpecularMaterialColor(0.774597f,0.774597f,0.774597f,1.0f);
	setMaterialShininess(76.8f);
}
void copperMaterial()
{
	setAmbientMaterialColor(0.19125f,0.0735f,0.0225f,1.0f);
	setDiffuseMaterialColor(0.7038f,0.27048f,0.0828f,1.0f);
	setSpecularMaterialColor(0.256777f,0.137622f,0.086014f,1.0f);
	setMaterialShininess(12.8f);
}
void silverMaterial()
{
	setAmbientMaterialColor(0.19125f,0.19225f,0.19225f,1.0f);
	setDiffuseMaterialColor(0.50754f,0.50754f,0.50754f,1.0f);
	setSpecularMaterialColor(0.508273f,0.508273f,0.508273f,1.0f);
	setMaterialShininess(51.2f);
}
void setDiffuseMaterialColor(GLfloat red, GLfloat green, GLfloat blue,GLfloat alpha)
{
	GLfloat diff[4];
	diff[0]=red;
	diff[1]=green;
	diff[2]=blue;
	diff[3]=alpha;
	glMaterialfv(GL_FRONT, GL_DIFFUSE,diff); 

}
void setAmbientMaterialColor(GLfloat red, GLfloat green, GLfloat blue,GLfloat alpha)
{
	GLfloat amb[4];
	amb[0]=red;
	amb[1]=green;
	amb[2]=blue;
	amb[3]=alpha;
	glMaterialfv(GL_FRONT, GL_AMBIENT,amb); 

}
void setSpecularMaterialColor(GLfloat red, GLfloat green, GLfloat blue,GLfloat alpha)
{
	GLfloat spec[4];
	spec[0]=red;
	spec[1]=green;
	spec[2]=blue;
	spec[3]=alpha;
	glMaterialfv(GL_FRONT, GL_SPECULAR,spec); 

}
void setMaterialShininess(GLfloat shininess)
{
	glMateriali(GL_FRONT, GL_SHININESS, (GLint) shininess);
}
void sphere(GLfloat radius)
{
	GLUquadricObj *obj = gluNewQuadric();
	gluQuadricDrawStyle(obj,GLU_FILL);
	gluQuadricNormals(obj,GLU_SMOOTH);
	gluQuadricOrientation(obj,GLU_OUTSIDE);
	gluQuadricTexture(obj, GL_TRUE);

	gluSphere(obj, radius, 10, 10);
	gluDeleteQuadric(obj);
}

void drawSphereObjectList()
{
	int i;
	int color;

		setSpecularMaterialColor(1.0f,1.0f,1.0f,0.6f);
		setMaterialShininess(128.0f);

		
		setAmbientMaterialColor(0.2f,0.0f,0.0f,0.6f);

		for(i=0; i<OBJECT_LIST_SIZE; i++)
		{
			if(objSphereList[i].m_available_flag==FALSE)
			{
				color=rand()%3;
				switch(color)
				{
				case 0:
					setDiffuseMaterialColor(0.8f,0.0f,0.0f,0.1f);
					break;
				case 1:
					setDiffuseMaterialColor(0.0f,0.8f,0.0f,0.1f);
					break;
				case 2:
					setDiffuseMaterialColor(0.0f,0.0f,0.8f,0.1f);
					break;
				case 3:
					setDiffuseMaterialColor(0.8f,0.8f,0.0f,0.1f);
					break;
				}

				glPushMatrix();
					glTranslatef(objSphereList[i].m_x,objSphereList[i].m_y,objSphereList[i].m_z);
 					sphere(2.0f);
				glPopMatrix();
			}
		}

}
int insideBoundary(GLfloat tank_x, GLfloat tank_z,
			   	GLfloat wall_x1,GLfloat wall_x2,
				GLfloat wall_z1,GLfloat wall_z2)
{
	if ((tank_x>wall_x1) && (tank_x<wall_x2)
		&& (tank_z>wall_z1) && (tank_z<wall_z2))
		return (1);

	return(0);

}
int checkWallCollision(Engine *objEngine,GLfloat xDelta,GLfloat zDelta)
{
	int i;

	GLfloat wall_x1,wall_x2;
	GLfloat wall_z1,wall_z2;

	GLfloat tank_x1,tank_x2;
	GLfloat tank_z1,tank_z2;

	tank_x1=objEngine->x+xDelta-6;
	tank_x2=objEngine->x+xDelta+6;

	tank_z1=objEngine->z+zDelta-6;
	tank_z2=objEngine->z+zDelta+6;

	for(i=0; i<OBJECT_LIST_SIZE; i++)
	{
		if(objWallList[i].m_active_flag==TRUE)
		{
			wall_x1=objWallList[i].m_x-30; //left
			wall_x2=objWallList[i].m_x+30; //right
			wall_z1=objWallList[i].m_z-30; //forward
			wall_z2=objWallList[i].m_z+30; //backward
		}
		/*
		glPushMatrix();
			glBegin(GL_LINE_LOOP);
				glVertex3f(wall_x1,5.0f,wall_z1);
				glVertex3f(wall_x2,5.0f,wall_z1);
				glVertex3f(wall_x2,5.0f,wall_z2);
				glVertex3f(wall_x1,5.0f,wall_z2);
			glEnd();
			glBegin(GL_LINE_LOOP);
				glVertex3f(tank_x1,5.0f,tank_z1);
				glVertex3f(tank_x2,5.0f,tank_z1);
				glVertex3f(tank_x2,5.0f,tank_z2);
				glVertex3f(tank_x1,5.0f,tank_z2);
			glEnd();
		glPopMatrix();
		*/

		if(

				insideBoundary(tank_x1, tank_z1,
			   	wall_x1,wall_x2,
				wall_z1,wall_z2)
				||
				insideBoundary(tank_x2, tank_z1,
			   	wall_x1,wall_x2,
				wall_z1,wall_z2)
				||
				insideBoundary(tank_x1, tank_z2,
			   	wall_x1,wall_x2,
				wall_z1,wall_z2)
				||
				insideBoundary(tank_x2, tank_z2,
			   	wall_x1,wall_x2,
				wall_z1,wall_z2)
			)
			{
				return(1);
			}

	}
	return(0);
}
void drawWallObjectList()
{
	int i;

	bronzeMaterial();

	for(i=0; i<OBJECT_LIST_SIZE; i++)
	{
		if(objWallList[i].m_active_flag==TRUE)
		{
		glPushMatrix();
			glTranslatef(objWallList[i].m_x,objWallList[i].m_y,objWallList[i].m_z);
			box( 30.0f, 10.0f, 30.0f);
		glPopMatrix();
		}
	}
}

int getWallObject()
{
	int i;
	for (i=0; i<OBJECT_LIST_SIZE; i++)
	{
		if (objWallList[i].m_available_flag==TRUE)
		{
			return(i);
		}
	}
	return(-1);
}
int getSphereObject()
{
	int i;
	for (i=0; i<OBJECT_LIST_SIZE; i++)
	{
		if (objSphereList[i].m_available_flag==TRUE)
		{
			return(i);
		}
	}
	return(-1);
}

VECTOR_STRUCT_TYPE* rotate(GLfloat angle,GLfloat ux,GLfloat uy,GLfloat uz, VECTOR_STRUCT_TYPE *vector)
{
MATRIX4X4 Mt;
MATRIX1X4 Mp;
MATRIX1X4 Mr;

float sinTheta;
float cosTheta;
VECTOR_STRUCT_TYPE *ret_vector;

ret_vector= (VECTOR_STRUCT_TYPE *) malloc (sizeof(VECTOR_STRUCT_TYPE));

sinTheta=(float)sin(angle/180.0f*3.142);
cosTheta=(float)cos(angle/180.0f*3.142);

Mt[0][0]= cosTheta+(1-cosTheta)*pow(ux,2);
Mt[0][1]= (1-cosTheta)*uy*ux-sinTheta*uz; 
Mt[0][2]= (1-cosTheta)*uz*ux+sinTheta*uy;
Mt[0][3]= 0.0f;  

Mt[1][0]= (1-cosTheta)*ux*uy+sinTheta*uz;
Mt[1][1]= cosTheta+(1-cosTheta)*pow(uy,2);
Mt[1][2]= (1-cosTheta)*uz*uy-sinTheta*ux;
Mt[1][3]= 0.0f; 

Mt[2][0]= (1-cosTheta)*ux*uz-sinTheta*uy;
Mt[2][1]= (1-cosTheta)*uy*uz+sinTheta*ux;
Mt[2][2]= cosTheta+(1-cosTheta)*pow(uz,2);
Mt[2][3]= 0.0f;

Mt[3][0]=0;
Mt[3][1]=0;
Mt[3][2]=0;
Mt[3][3]=1;

Mp[0][0]=vector->m_x;
Mp[0][1]=vector->m_y;
Mp[0][2]=vector->m_z;
Mp[0][3]=1;


Matrix1X4_4X4(&Mr,&Mp,&Mt); 

ret_vector->m_x=(float)Mr[0][0];
ret_vector->m_y=(float)Mr[0][1];
ret_vector->m_z=(float)Mr[0][2];
return(ret_vector);

}

double Matrix4X1_1X4(MATRIX4X1 *matrix1, MATRIX1X4 *matrix2)
{
register int k;
double result=0.0;
	for (k = 0 ; k < 4 ; k++)
		result += (*matrix1)[k][0] * (*matrix2)[0][k];
	return(result);
}
void Matrix4X1_4X4(MATRIX4X1 *result, MATRIX4X1 *matrix1, MATRIX4X4 *matrix2)
{
register int i, k;
MATRIX4X1 temp_matrix;
	for (i = 0 ; i < 4 ; i++)
	{
	temp_matrix[i][0] = 0.0;
		for (k = 0 ; k < 4 ; k++)
		{
			temp_matrix[i][0] += (*matrix1)[k][0] * (*matrix2)[i][k];
		}
	}
	for (i = 0 ; i < 4 ; i++)
		(*result)[i][0] = temp_matrix[i][0];
}
void Matrix1X4_4X4(MATRIX1X4 *result, MATRIX1X4 *matrix1, MATRIX4X4 *matrix2)
{
register int i, k;
MATRIX4X1 temp_matrix;
	for (i = 0 ; i < 4 ; i++)
	{
		temp_matrix[i][0] = 0.0;
			for (k = 0 ; k < 4 ; k++)
			{
				temp_matrix[i][0] += (*matrix1)[0][k] * (*matrix2)[i][k];
			}
	}
	for (i = 0 ; i < 4 ; i++)
		(*result)[0][i] = temp_matrix[i][0];
}
void drawExplosion()
{
	int i;

	for(i=0; i<EXPLOSION_SIZE; i++)
	{
		if(objExplosion[i].m_active_flag==TRUE)
		{
			if((clock()-objExplosion[i].m_cpu_seconds)>200)
			{
				objExplosion[i].m_available_flag=TRUE;
				objExplosion[i].m_active_flag=FALSE;
				objExplosion[i].scale_x=2.0f;
				objExplosion[i].scale_y=2.0f;
				objExplosion[i].scale_z=2.0f;
				break;
			}
			glPushMatrix();
				glTranslatef(objExplosion[i].x,objExplosion[i].y,objExplosion[i].z);
				glScalef(objExplosion[i].scale_x,objExplosion[i].scale_y,objExplosion[i].scale_z);
				objExplosion[i].scale_x+=1.0f;
				objExplosion[i].scale_y+=1.0f;
				objExplosion[i].scale_z+=1.0f;
				glRotatef(90.0f,1.0f,0.0f,0.0f);
				setDiffuseMaterialColor(1.0f,1.0f,0.0f,1.0f);
				torus(1.0f,3.0f);
			glPopMatrix();
		}
		
	}
}
int getAvailableExplosion()
{
	int i;
	for(i=0; i<EXPLOSION_SIZE; i++)
	{
		if (objExplosion[i].m_available_flag==TRUE)
			objExplosion[i].m_active_flag=TRUE;
			objExplosion[i].m_available_flag=FALSE;
			return(i);
	}
	return(-1);

}
void torus(GLfloat innerRadius,	GLfloat outerRadius)
{
	GLfloat vertexes[4][3];
	GLfloat normal[3];
	GLfloat x;
	GLfloat y;
	GLfloat z;
	GLfloat phi;
	GLfloat theta;
	GLfloat CosPhi;
	GLfloat SinPhi;
	GLfloat SinTheta;
	GLfloat CosTheta;

	for(phi=0.0f; phi <= 360.0f; phi+=20.0f)
	{
		for(theta=0.0f; theta<=360.0f; theta+=20.0f)
		{
		CosPhi=(GLfloat)cos(phi/180.0*3.142);
		SinPhi=(GLfloat)sin(phi/180.0*3.142);
		CosTheta=(GLfloat)cos(theta/180.0*3.142);
		SinTheta=(GLfloat)sin(theta/180.0*3.142);
		/*Vertex 1*/
		x= CosTheta * (CosPhi * innerRadius+outerRadius);
		y= SinTheta * (CosPhi * innerRadius+outerRadius);
		z= (SinPhi) * innerRadius;
		vertexes[0][0]=x;
		vertexes[0][1]=y;
		vertexes[0][2]=z;
		/*Vertex 2*/
		CosPhi=(GLfloat)cos(phi/180.0*3.142);
		SinPhi=(GLfloat)sin(phi/180.0*3.142);
		CosTheta=(GLfloat)cos((theta+20)/180.0*3.142);
		SinTheta=(GLfloat)sin((theta+20)/180.0*3.142);
		x= CosTheta * (CosPhi * innerRadius+outerRadius);
		y= SinTheta * (CosPhi * innerRadius+outerRadius);
		z= (SinPhi) * innerRadius;
		vertexes[1][0]=x;
		vertexes[1][1]=y;
		vertexes[1][2]=z;
		/*Vertex 3*/
		CosPhi=(GLfloat)cos((phi+20)/180.0*3.142);
		SinPhi=(GLfloat)sin((phi+20)/180.0*3.142);
		CosTheta=(GLfloat)cos((theta+20)/180.0*3.142);
		SinTheta=(GLfloat)sin((theta+20)/180.0*3.142);
		x= CosTheta * (CosPhi * innerRadius+outerRadius);
		y= SinTheta * (CosPhi * innerRadius+outerRadius);
		z= (SinPhi) * innerRadius;
		vertexes[2][0]=x;
		vertexes[2][1]=y;
		vertexes[2][2]=z;
		/*Vertex 4*/
		CosPhi=(GLfloat)cos((phi+20)/180.0*3.142);
		SinPhi=(GLfloat)sin((phi+20)/180.0*3.142);
		CosTheta=(GLfloat)cos((theta)/180.0*3.142);
		SinTheta=(GLfloat)sin((theta)/180.0*3.142);
		x= CosTheta * (CosPhi * innerRadius+outerRadius);
		y= SinTheta * (CosPhi * innerRadius+outerRadius);
		z= (SinPhi) * innerRadius;
		vertexes[3][0]=x;
		vertexes[3][1]=y;
		vertexes[3][2]=z;
		calcNormal(vertexes,normal);
		glBegin(GL_POLYGON);
			glNormal3f(normal[0],normal[1],normal[2]);
			glVertex3f(vertexes[0][0],vertexes[0][1],vertexes[0][2]);
			glVertex3f(vertexes[1][0],vertexes[1][1],vertexes[1][2]);
			glVertex3f(vertexes[2][0],vertexes[2][1],vertexes[2][2]);
			glVertex3f(vertexes[3][0],vertexes[3][1],vertexes[3][2]);
		glEnd();
		}
	}
}

void reduceToUnit(GLfloat vector[3])
{
float length;
length = (float)sqrt((vector[0]*vector[0]) + 
(vector[1]*vector[1]) +
(vector[2]*vector[2]));
if(length == 0.0f)
	length = 1.0f;
	vector[0] /= length;
	vector[1] /= length;
	vector[2] /= length;
}
void calcNormal(GLfloat v[3][3], GLfloat out[3])
{
float v1[3],v2[3];
static const int x = 0;
static const int y = 1;
static const int z = 2;
v1[x] = v[0][x] - v[1][x];
v1[y] = v[0][y] - v[1][y];
v1[z] = v[0][z] - v[1][z];
v2[x] = v[1][x] - v[2][x];
v2[y] = v[1][y] - v[2][y];
v2[z] = v[1][z] - v[2][z];
/*Cross Product*/
out[x] = v1[y]*v2[z] - v1[z]*v2[y];
out[y] = v1[z]*v2[x] - v1[x]*v2[z];
out[z] = v1[x]*v2[y] - v1[y]*v2[x];
reduceToUnit(out);
}

void CMy3DFontView::OnAppAbout() 
{
	// TODO: Add your command handler code here

	CHelp dlg;

	KillTimer(1);
	
	int response=dlg.DoModal();

	if(response==IDOK)
	{
		setSpeed();
	}
	Invalidate();
}
