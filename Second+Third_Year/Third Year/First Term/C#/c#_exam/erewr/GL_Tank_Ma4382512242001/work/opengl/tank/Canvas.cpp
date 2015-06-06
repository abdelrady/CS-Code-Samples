/*
Authors: David Nishimoto and Thomas Lee
Website: http://www.listensoftware.com
Program: Cube Drop
*/

#include "canvas.h"

Canvas::Canvas(GLint x, GLint y, GLint width, GLint height, char *windowTitle)
{
	char * argv[1];
	char dummyString[8];
	argv[0]=dummyString;
	int argc=1;
	int i;

	//game area size attributes
	cubeSize = 5;
	gameWidth = cubeSize * 20;
	gameDepth = cubeSize * 20;
	gameHeight = cubeSize * 10;

	miWidth=width;
	miHeight=height;
	m_CurrDegree=0;

	for(i=0;i<DISPLAY_LIST_SIZE; i++)
	{
		display_list[i].available=YES;
		display_list[i].id=-1;
	}
}

Canvas::~Canvas()
{

}

void Canvas::setWindow(GLfloat fLeft, GLfloat fRight, GLfloat fBottom, GLfloat fTop)
{
	GLfloat zNear=1.0f;
	GLfloat zFar=2000.0f;

	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	//gluOrtho2D(fLeft,fRight,fBottom,fTop);
	glOrtho(fLeft,fRight,fBottom,fTop, zNear, zFar);

}

void Canvas::setPerspectiveWindow(GLdouble fovy, GLdouble aspect,GLdouble zNear,GLdouble zFar)
{
  glMatrixMode(GL_PROJECTION);
  glLoadIdentity();
  gluPerspective(fovy, aspect,zNear,  zFar);
}

void Canvas::setViewport(GLint iX, GLint iY, GLsizei iWidth, GLsizei iHeight)
{
	glViewport(iX,iY,iWidth,iHeight);
}

void Canvas::setBackgroundColor(GLfloat red, GLfloat green, GLfloat blue)
{
	glClearColor(red,green,blue,1);
}

void Canvas::setLighting()
{
  GLfloat light0pos[4]=     {0.7071, 3.0, 5.0, 0.0};
  GLfloat light0ambient[4]= {0.3, 0.3, 0.3, 1.0};
  GLfloat light0diffuse[4]= {0.6, 0.6, 0.6, 1.0};
  GLfloat light0specular[4]={0.8, 0.8, 0.8, 1.0};
  GLfloat lmodel_ambient[]= {0.8f,0.8f,0.8f,1.0f};

  glLightModelfv(GL_LIGHT_MODEL_AMBIENT,lmodel_ambient);

  //glDisable(GL_DITHER);
  glShadeModel(GL_SMOOTH);
  
  glLightfv(GL_LIGHT0, GL_POSITION, light0pos);
  glLightfv(GL_LIGHT0, GL_AMBIENT, light0ambient);
  glLightfv(GL_LIGHT0, GL_DIFFUSE, light0diffuse);
  glLightfv(GL_LIGHT0, GL_SPECULAR, light0specular);
  
  glEnable(GL_LIGHTING);
  glEnable(GL_LIGHT0);
  //glEnable(GL_LIGHT1);
  //glEnable(GL_LIGHT2);
}

void Canvas::setBlending()
{
	glEnable(GL_BLEND);
	/*GL_SRC_ALPHA = Source color multiplied by source alpha
	  GL_ONE_MINUS_SRC_ALPHA =  Destination color is multiplied by 1,1,1,1 - source color)
	*/
	glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);

}

void Canvas::setDepthBuffer()
{
  glEnable(GL_DEPTH_TEST);
  glDepthFunc(GL_LESS);
  glEnable(GL_CULL_FACE);
  glCullFace(GL_BACK);
  glFrontFace(GL_CCW);
}

void Canvas::setDiffuseMaterialColor(GLfloat red, GLfloat green, GLfloat blue,GLfloat alpha)
{
	GLfloat diff[4];
	diff[0]=red;
	diff[1]=green;
	diff[2]=blue;
	diff[3]=alpha;
	glMaterialfv(GL_FRONT, GL_DIFFUSE,diff); 

}

void Canvas::setAmbientMaterialColor(GLfloat red, GLfloat green, GLfloat blue,GLfloat alpha)
{
	GLfloat amb[4];
	amb[0]=red;
	amb[1]=green;
	amb[2]=blue;
	amb[3]=alpha;
	glMaterialfv(GL_FRONT, GL_AMBIENT,amb);
}

void Canvas::setSpecularMaterialColor(GLfloat red, GLfloat green, GLfloat blue,GLfloat alpha)
{
	GLfloat spec[4];
	spec[0]=red;
	spec[1]=green;
	spec[2]=blue;
	spec[3]=alpha;
	glMaterialfv(GL_FRONT, GL_SPECULAR,spec); 

}

void Canvas::setMaterialShininess(GLint shininess)
{
	glMateriali(GL_FRONT, GL_SHININESS, shininess);
}

void Canvas::Box(int w, int h, int d)
{	
	glBegin(GL_POLYGON);
		glBegin(GL_POLYGON);
		glNormal3f(0,0,1);
		glVertex3f(0.5f*w,	0.5f*h,	0.5f*d);
		glVertex3f(-0.5f*w,	0.5f*h,	0.5f*d);
		glVertex3f(-0.5f*w,	-0.5f*h,	0.5f*d);
		glVertex3f(0.5f*w,	-0.5f*h,	0.5f*d);
	glEnd();

	glBegin(GL_POLYGON);
		glNormal3f(0,0,-1);
		glVertex3f(0.5f*w,	0.5f*h,	-0.5f*d);
		glVertex3f(0.5f*w,	-0.5f*h,	-0.5f*d);
		glVertex3f(-0.5f*w,	-0.5f*h,	-0.5f*d);
		glVertex3f(-0.5f*w,	0.5f*h,	-0.5f*d);
	glEnd();

	glBegin(GL_POLYGON);
		glNormal3f(-1,0,0);
		glVertex3f(-0.5f*w,	0.5f*h,	0.5f*d);
		glVertex3f(-0.5f*w,	0.5f*h,	-0.5f*d);
		glVertex3f(-0.5f*w,	-0.5f*h,	-0.5f*d);
		glVertex3f(-0.5f*w,	-0.5f*h,	0.5f*d);
	glEnd();

	glBegin(GL_POLYGON);
		glNormal3f(1,0,0);
		glVertex3f(0.5f*w,	0.5f*h,	0.5f*d);
		glVertex3f(0.5f*w,	-0.5f*h,	0.5f*d);
		glVertex3f(0.5f*w,	-0.5f*h,	-0.5f*d);
		glVertex3f(0.5f*w,	0.5f*h,	-0.5f*d);
	glEnd();

	glBegin(GL_POLYGON);
		glNormal3f(0,1,0);
		glVertex3f(-0.5f*w,	0.5f*h,	-0.5f*d);
		glVertex3f(-0.5f*w,	0.5f*h,	0.5f*d);
		glVertex3f(0.5f*w,	0.5f*h,	0.5f*d);
		glVertex3f(0.5f*w,	0.5f*h,	-0.5f*d);
	glEnd();

	glBegin(GL_POLYGON);
		glNormal3f(0,-1,0);
		glVertex3f(-0.5f*w,	-0.5f*h,	-0.5f*d);
		glVertex3f(0.5f*w,	-0.5f*h,	-0.5f*d);
		glVertex3f(0.5f*w,	-0.5f*h,	0.5f*d);
		glVertex3f(-0.5f*w,	-0.5f*h,	0.5f*d);
	glEnd();

}

GLint Canvas::ReserveDisplayListId(char *name)
{
	int i;
	
	for(i=0;i<DISPLAY_LIST_SIZE; i++)
	{
		if(display_list[i].available==YES)
		{
			display_list[i].available=NO;
			strcpy(display_list[i].name,name);
			display_list[i].id=glGenLists(1);
			return(display_list[i].id);
		}
	}
	return(-1);
}

GLint Canvas::FindDisplayListId(char *name)
{
	int i;
	
	for(i=0;i<DISPLAY_LIST_SIZE; i++)
	{
		if(strcmp(display_list[i].name,name)==0)
		{
			return(display_list[i].id);
		}
	}
	return(-1);
}


void Canvas::buildGrid(char *Name)
{
	int r,c,d = 0;
	int nStep = 5;
	int width = gameWidth;
	int depth = gameDepth;
	int height = gameHeight;
	GLint iGrid_Id;


	glPushAttrib(GL_LIGHTING_BIT);
	glDisable(GL_LIGHTING);

	glPushMatrix();

	iGrid_Id=ReserveDisplayListId(Name);

	glNewList(iGrid_Id,GL_COMPILE_AND_EXECUTE);
	
	glBegin(GL_LINES);

	//draw transverse grid lines
	for(r = 0; r  <= width; r += nStep)
	{
		glVertex3d(r, height, 0);
		glVertex3d(r, 0, 0);

//		for(d = 0; d <= height; d += nStep)
		{
			glVertex3d(r, d, 0);
			glVertex3d(r, d, -depth);
		}

		glVertex3d(r, 0, -depth);
		glVertex3d(r, height, -depth);
	}

	//draw lateral grid lines
	for(c = 0; c <= depth; c += nStep)
	{
		glVertex3d(0, height, -c);
		glVertex3d(0, 0, -c);

//		for(d = 0; d <= height; d += nStep)
		{
			glVertex3d(0, d, -c);
			glVertex3d(width, d, -c);
		}

		glVertex3d(width, 0, -c);
		glVertex3d(width, height, -c);
	}

	//draw grid lines up the y axis
	for(d=0; d<=height; d+=nStep)
	{
		glVertex3d(0,d,0);
		glVertex3d(width,d,0);

		glVertex3d(width,d,0);
		glVertex3d(width,d,-depth);

		glVertex3d(width,d,-depth);
		glVertex3d(0,d,-depth);

		glVertex3d(0,d,-depth);
		glVertex3d(0,d,0);
	}

	glEnd();

	glEndList();

  glPopMatrix();
  glPopAttrib();
  glEnable(GL_LIGHTING);
}
