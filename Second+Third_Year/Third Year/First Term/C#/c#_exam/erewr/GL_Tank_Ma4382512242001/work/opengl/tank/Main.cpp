//Software Engineer:  T. Lee Young
//Class:              CS 4280
//Assignemnt:         Final Project

#ifdef WIN32
#include "windows.h"
#endif

#include <GL/gl.h>
#include <GL/glu.h>
#include <GL/glut.h>
#include <GL/glaux.h>
#include <stdio.h>
#include "canvas.h"
#include "cammera.h"

Canvas cvs(0,0,640,480,"Cube Space               Score: 0");
Camera cam(PI/2.0, 12.0f, 80.0f);
Matrix mat;
bool gameOver = false;
bool pause = false;
bool start = false;
bool autoRotate = false;
bool intro = true;
bool timersSet = false;
GLint delayTime;


void drawCubes()
{
	int color;

	//position the cube in the matrix position given by x, y, and z
	GLfloat w, h, d;
	w = h = d = 5.0;  //cube is 5 x 5 x 5
	for(int i = 0; i<MAT_WIDTH; ++i)
		for(int j = 0; j<MAT_HEIGHT; ++j)
			for(int k = 0; k<MAT_DEPTH; ++k)
				if(color = mat.isSet(i,j,k))
				{
					switch(color)
					{
						case 1: cvs.setAmbientMaterialColor(1,0,0,1);
							break;
						case 2: cvs.setAmbientMaterialColor(0,1,0,1);
							break;
						case 3: cvs.setAmbientMaterialColor(0,0,1,1);
							break;
						case 4: cvs.setAmbientMaterialColor(1,1,0,1);
							break;
						case 5: cvs.setAmbientMaterialColor(0,1,1,1);
							break;
						case 6: cvs.setAmbientMaterialColor(1,0,1,1);
							break;
					}
					glPushMatrix();
						glTranslatef(2.5+i*w, 2.5+j*h, -2.5 - k*h);
						cvs.Box(w,h,d);
					glPopMatrix();
				}
}


void DisplayScore()
{
	

}

void DrawText(char *text, void *font, int x, int y, int z)
{
	int i = 0;

	glRasterPos3d(x, y, z);
	
	while(text[i] != '\0')
	{
		glutBitmapCharacter(font,text[i]);
		++i;
	}

}

void IntroScreen()
{
	int x, y, z;

	x = -14; //column
	y = 60;
	z = -19; //row

	//display game instructions
	cvs.setAmbientMaterialColor(1.0, 0.0, 0.0, 1.0);
	DrawText("Cube Space", GLUT_BITMAP_9_BY_15, x, y, z);

	x = -19;
	++z;
	cvs.setAmbientMaterialColor(0.0, 0.0, 1.0, 1.0);
	DrawText("Game Controls", GLUT_BITMAP_8_BY_13, x, y, ++z );
	x = -14;
	cvs.setAmbientMaterialColor(1.0, 1.0, 1.0, 1.0);
	DrawText("Start:  s", GLUT_BITMAP_8_BY_13, x, y, ++z);
	DrawText("Pause:  p", GLUT_BITMAP_8_BY_13, x, y, ++z);

	++z;
	x = -24;
	cvs.setAmbientMaterialColor(0.0, 0.0, 1.0, 1.0);
	DrawText("Cube Movement Controls", GLUT_BITMAP_8_BY_13, x, y, ++z);
	x = -14;
	cvs.setAmbientMaterialColor(1.0, 1.0, 1.0, 1.0);
	DrawText(" Left:  Left Arrow", GLUT_BITMAP_8_BY_13, x, y, ++z);
	DrawText("Right:  Right Arrow", GLUT_BITMAP_8_BY_13, x, y, ++z);
	DrawText("  Out:  Down Arrow", GLUT_BITMAP_8_BY_13, x, y, ++z);
	DrawText("   In:  Up Arrow", GLUT_BITMAP_8_BY_13, x, y, ++z);

	++z;
	x = -24;
	cvs.setAmbientMaterialColor(0.0, 0.0, 1.0, 1.0);
	DrawText("Change View Controls", GLUT_BITMAP_8_BY_13, x, y, ++z);
	x = -21;
	cvs.setAmbientMaterialColor(1.0, 1.0, 1.0, 1.0);
	DrawText("Rotate Counter Clockwise:  4", GLUT_BITMAP_8_BY_13, x, y, ++z);
	DrawText("        Rotate Clockwise:  6", GLUT_BITMAP_8_BY_13, x, y, ++z);
	DrawText("          Move In Closer:  8", GLUT_BITMAP_8_BY_13, x, y, ++z);
	DrawText("               Move Back:  2", GLUT_BITMAP_8_BY_13, x, y, ++z);
	DrawText("  View From Higher Angle:  +", GLUT_BITMAP_8_BY_13, x, y, ++z);
	DrawText("   View From Lower Angle:  -", GLUT_BITMAP_8_BY_13, x, y, ++z);
	DrawText("             Auto Change:  A", GLUT_BITMAP_8_BY_13, x, y, ++z);
	DrawText("      Toggle This Screen:  I", GLUT_BITMAP_8_BY_13, x, y, ++z);
}


void GameOver()
{
	char scorePhrase[50];
	int i = 0;

	cvs.setAmbientMaterialColor(1.0, 1.0, 1.0, 1.0);
	DrawText("Game Over", GLUT_BITMAP_8_BY_13, -3, 55, -13);

	sprintf(scorePhrase, "Score: %i", mat.GetScore());
	DrawText(scorePhrase, GLUT_BITMAP_8_BY_13, -3, 50, -8);
	timersSet = false;
}

void AutoRotateDisplay()
{
	static int movement = 0;
	static int count = 0;

//	srand( (unsigned)time(NULL) );//seed the rand num generator

	//only change the direction of change
	//on even multiples of 125
	if(count%125 == 0)
	{
		movement = rand()%6+1;
	}

	//only change the view when count is an even multiple of 2
	//if the graphics card is very slow, decrease this
	if(count%1 == 0)
	{
		switch(movement)
		{
			case 1: cam.Up(); break;
			case 2: cam.Down(); break;
			case 3: cam.RotateCC(); break;
			case 4: cam.RotateC(); break;
			case 5: cam.In(); break;
			case 6: cam.Out(); break;
		}
	}

	++count;

//	printf("Movement: %i\n", movement);
}


void ProcessGeometry()
{
	glLoadIdentity();	

	if(start && !intro)
	{
		gluLookAt(cam.getX(), cam.getY(), cam.getZ(),
			  12.0f, 0.0f, -12.0f,
			  0.0f, 1.0f, 0.0f);

		drawCubes();
		DisplayScore();

		if(gameOver)
			GameOver();			

		if(autoRotate)
			AutoRotateDisplay();
	}
	else
	{
		gluLookAt(0.0, 100.0, 0.1,
				  0.0, 0.0, -15.0,
//			 	  0.0, 0.0, 0.0,
				  0.0, 1.0, 0.0);
		IntroScreen();

		drawCubes();
		DisplayScore();

		if(gameOver)
		{
			GameOver();
			autoRotate = true;
		}

		if(autoRotate)
			AutoRotateDisplay();
	}	

	//draw the game grid
	cvs.setAmbientMaterialColor(0,1,0,1);
	glCallList(cvs.FindDisplayListId("Grid"));

	glutPostRedisplay();
	glutSwapBuffers();
}

void init()
{
	cvs.setPerspectiveWindow(60,cvs.miWidth/cvs.miHeight,5,2000);
	cvs.setViewport(0,0,cvs.miWidth,cvs.miHeight);
	cvs.setBackgroundColor(0,0,0);
	cvs.setLighting();
	//cvs.setBlending();
	cvs.setDepthBuffer();
	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();

	cvs.buildGrid("Grid");

	//seed the rand number generator
	srand( (unsigned)time(NULL) );
}


void TimerFunction(int i)
{
	bool successful;

	if(pause)
	{
		glutTimerFunc(delayTime,TimerFunction, delayTime);
	}
	else
	{
		successful = mat.moveDown();
		if(!successful)
		{
			gameOver = true;
			autoRotate = true;
		}
		else
			glutTimerFunc(delayTime, TimerFunction, delayTime);

		printf("Delay Time: %i\n", delayTime);
	}

	glutPostRedisplay();
}


void IncreaseSpeed(int _time)
{
	if(delayTime >= 25)
		delayTime -= 25;

	glutTimerFunc(_time, IncreaseSpeed, _time);

//	printf("2nd Timer's time has expired");
}


void StartGame()
{
	gameOver = false;
	autoRotate = false;
	intro = false;
	cam.SetCamera(PI/2.0, 12.0f, 80.0f);
	delayTime = 500;
	mat.SetScore(0);
	mat.SetTitleBar();
	mat.ZeroMatrix();		
	mat.set(3,10,3);
	start = true;
	
	//prevent two sets of timers from running if the game is reset
	if(!timersSet)
	{
		glutTimerFunc(delayTime,TimerFunction, delayTime);
		glutTimerFunc(10000, IncreaseSpeed, 10000);
		timersSet = true;
	}	
}


static void key (unsigned char k, int x, int y)
{
	k = toupper(k);

	switch(k) {
	case '8': cam.In();  break;
	case '2': cam.Out(); break;
	case '4': cam.RotateC();break;
	case '6': cam.RotateCC(); break;
	case '+': cam.Up(); break;
	case '-': cam.Down(); break;
	case 27:  exit(0); break;
	case ' ': mat.drop(); break;
	case 'S': StartGame(); break;
	case 'P': if(start) pause = !pause;	break;
	case 'A': autoRotate = !autoRotate; break;
	case 'I': intro = !intro; break;
	}
}

static void special (int k, int x, int y)
{
  switch (k)
  {
	  case GLUT_KEY_UP: if(!pause) mat.moveIn();  break;
	  case GLUT_KEY_DOWN: if(!pause) mat.moveOut();	break;
	  case GLUT_KEY_LEFT: if(!pause) mat.moveLeft(); break;
	  case GLUT_KEY_RIGHT: if(!pause) mat.moveRight(); break;
  }
}

void myReshape(GLsizei W, GLsizei H)
{
	cvs.setViewport(0,0,W,H);
}

static void draw(GLvoid)
{
	glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
	ProcessGeometry();
	glutSwapBuffers();
}


int main(int argc, char **argv) 
{
	init();
	glutKeyboardFunc(key);
	glutSpecialFunc(special);
	glutDisplayFunc(draw);
	glutReshapeFunc(myReshape);
	//glutIdleFunc(draw);
	glutMainLoop();

	return(0);
}
