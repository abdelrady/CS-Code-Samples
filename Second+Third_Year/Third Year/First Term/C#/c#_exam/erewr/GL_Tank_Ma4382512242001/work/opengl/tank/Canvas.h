#ifdef WIN32
#include "windows.h"
#endif

#ifndef CANVAS_H
#define CANVAS_H

#include <GL/gl.h>
#include <GL/glu.h>
#include <GL/glut.h>
#include <GL/glaux.h>
#include <math.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

#define DISPLAY_LIST_SIZE 10
#define TRUE 1
#define FALSE 0
#define YES 1
#define NO 0
#define glRGB(x, y, z)	glColor3ub((GLubyte)x, (GLubyte)y, (GLubyte)z)

typedef struct DISPLAY_LIST_STRUCT
{
	char name[40];
	GLint id;
	GLint available;
} DISPLAY_LIST_TYPE;

class Canvas{
public:
	GLint miWidth;
	GLint miHeight;
	GLint m_CurrDegree;

	DISPLAY_LIST_TYPE display_list[DISPLAY_LIST_SIZE];
		
	Canvas(GLint x, GLint y, GLint width, GLint height, char *windowTitle);
	~Canvas();
	void setPerspectiveWindow(GLdouble fovy, GLdouble aspect,GLdouble zNear,GLdouble zFar);
	void setWindow(GLfloat fLeft, GLfloat fRight, GLfloat fBottom, GLfloat fTop);
	void setViewport(GLint iX, GLint iY, GLsizei iWidth, GLsizei iHeight);
	void setBackgroundColor(GLfloat red, GLfloat green, GLfloat blue);
	void setLighting();
	void setBlending();
	void setDepthBuffer();
	void setDiffuseMaterialColor(GLfloat red, GLfloat green, GLfloat blue,GLfloat alpha);
	void setAmbientMaterialColor(GLfloat red, GLfloat green, GLfloat blue,GLfloat alpha);
	void setMaterialShininess(GLint intensity);
	void setSpecularMaterialColor(GLfloat red, GLfloat green, GLfloat blue,GLfloat alpha);
	void Box(int, int, int);
	GLint ReserveDisplayListId(char *name);
	GLint FindDisplayListId(char *name);
	void buildGrid(char *Name);
	GLint cubeSize;
	GLfloat gameWidth;
	GLfloat gameDepth;
	GLfloat gameHeight;
};



#endif