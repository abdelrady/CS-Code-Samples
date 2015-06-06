// FaceDetection.h
#pragma once
#pragma managed 
#include "ObjectLocator.h"
#include <stdio.h>
#include < vcclr.h >
#define MAXEYERAD 100
#define MINEYERAD 10

static int InitFlag = 0;
static int lastHeight, lastWidth;

#pragma managed 
__gc class FaceLocator
	{
		// TODO: Add your methods for this class here.	
	private:		
		ObjectLocator* FaceDetector;
		ObjectLocator* LeftEyeDetector;		
		ObjectLocator* RightEyeDetector;		
	
		static System::String * FaceCascade  = "\\Cascades\\Rect2.xml";//\\Cascades\\haarcascade_frontalface_alt.xml
		static System::String * RightEyeCascade  = "\\Cascades\\ojoD.xml";
		static System::String * LeftEyeCascade  = "\\Cascades\\ojoI.xml";
		void InitCascades();
		int faceMode;
	
	public:	
		FaceLocator(void);	
		~FaceLocator(void);
		
		void getCoordinates(int index, int &lx, int &ly, int &rx, int &ry);
		int DetectFaces(IplImage* ImageData);			
		int GetFaceCordinates(int index, int &lx, int &ly, int &rx, int &ry);	
		int GetEyeCordinates(int index, int &lx, int &ly, int &rx, int &ry);
	};
