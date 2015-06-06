// This is the main DLL file.
#pragma managed
#include "stdafx.h"
#include "FaceLocator.h"




FaceLocator::FaceLocator(void)
{
	FaceDetector = new ObjectLocator();
	LeftEyeDetector = new ObjectLocator();
	RightEyeDetector = new ObjectLocator();
}

FaceLocator::~FaceLocator(void)
{	
	delete FaceDetector;	
	delete LeftEyeDetector;	
	delete RightEyeDetector;	
}

char* StringToCharPtr(System::String* str)
{
	const wchar_t __pin* p = PtrToStringChars(str);
	char* ch = (char *)malloc((str -> Length + 1) * 2);
	wcstombs(ch, p, (str -> Length + 1) * 2);
	return ch;
}

void FaceLocator::InitCascades(void)
{
	System::Reflection::Assembly * assm 
		= (System::Reflection::Assembly::GetExecutingAssembly());
	
	System::String * str = assm->Location;
	
	System::String * msg = "Cascade file for face detection not found.\nPlease place the cascades in .\\Cascades\\ folder.";

	str = str->Substring(0,str->LastIndexOf("\\"));
	if( (!System::IO::File::Exists(str->Concat(str,FaceCascade)))
		||(!System::IO::File::Exists(str->Concat(str,LeftEyeCascade)))
		||(!System::IO::File::Exists(str->Concat(str,RightEyeCascade)))
		)
	{
		throw new System::Exception(msg);
	}

	char* face = StringToCharPtr(str->Concat(str,FaceCascade));

	FaceDetector->InitObjectDetect(face);

	char* leye = StringToCharPtr(str->Concat(str,LeftEyeCascade));	
	LeftEyeDetector->InitObjectDetect(leye);
	
	char* reye = StringToCharPtr(str->Concat(str,RightEyeCascade));
	RightEyeDetector->InitObjectDetect(reye);
}

int FaceLocator::DetectFaces(IplImage* inputImage)
{
	if(InitFlag==0) 
	{
		InitFlag++;		
		FaceDetector->InitImageStorage(inputImage->width,inputImage->height, scale);
		InitCascades();	
		lastHeight = inputImage->height;
		lastWidth = inputImage->width;
	}	
	else if((lastHeight!=inputImage->height) || (lastWidth!=inputImage->width))
	{	
		FaceDetector->InitImageStorage(inputImage->width,inputImage->height, scale);
		InitCascades();
		lastHeight = inputImage->height;
		lastWidth = inputImage->width;
	}
	
	FaceDetector->ManagedImagetoUnManagedImage((inputImage));	
	FaceDetector->ImagePreProcessForFaceDetection();
	int FNum = FaceDetector->DetectObjects();
	
	return FNum;
}

int FaceLocator::GetFaceCordinates(int index, int &lx, int &ly, int &rx, int &ry)
{
	int lx1, ly1, rx1, ry1;
	FaceDetector->GetObjectCoordinates(index, lx1, ly1, rx1, ry1);	
	lx = lx1;
	ly = ly1;
	rx = rx1;
	ry = ry1;
	return 0;
}

int FaceLocator::GetEyeCordinates(int index, int &lx, int &ly, int &rx, int &ry)
{
	int leftEyeIndex=-1, rightEyeIndex=-1;
	double minArea=MaxValue, minArea2=MaxValue;
	int minRX, minRY, minRWidth, minRHeight;
	int minLX, minLY, minLWidth, minLHeight;
	
	int xVal1=-1, xVal2=-1;
	
	int LeftPossibleEyes[MAXOBJECTCOUNT];
	int RightPossibleEyes[MAXOBJECTCOUNT];
	int REyeCounter=0,LEyeCounter=0;

	int faceX, faceY, faceWidth, faceHeight;
	int faceMidy;

	int currX, currY, currWidth, currHeight;
	int currMidy, currMidx;
	
	FaceDetector->GetObjectCoordinates(index, faceX, faceY, faceWidth, faceHeight);	
	faceMidy = faceY + (faceHeight/2);
	
	//if(FaceDetector->NoOfObjects==1)
	{	
		//compute a sub image for seraching withing face region
		//ManagedImagetoSubCVImage(managed_image, faceX, faceY, faceWidth, faceHeight);
		int LENum = LeftEyeDetector->DetectObjects();
		int RENum = RightEyeDetector->DetectObjects();
		
		//prune according to size limits
		for(int i=0; i<LENum;i++)
		{
			LeftEyeDetector->GetObjectCoordinates( i, currX, currY, currWidth, currHeight);			
			currMidy = currY + (currHeight/2);
			currMidx = currX + (currWidth/2);

			int ERadius = (currWidth + currHeight) / 2;

			//should be in upper and lower limit
			if((ERadius<=MAXEYERAD && ERadius>=MINEYERAD)
				//center of object should be in upper half of face region
				&& (currMidy <= faceMidy)
				&& (currMidy >= (faceMidy/2))
				&& (currMidx < faceX+(int)((float)faceWidth*(float)0.5))
				&& (currMidx > faceX))
			{
				LeftPossibleEyes[LEyeCounter++] = i;
			}			
		}

		//prune according to size limits
		for(int i=0; i<RENum;i++)
		{
			RightEyeDetector->GetObjectCoordinates( i, currX, currY, currWidth, currHeight);			
			currMidy = currY + (currHeight/2);
			currMidx = currX + (currWidth/2);

			int ERadius = (currWidth + currHeight) / 2;

			//should be in upper and lower limit
			if((ERadius<=MAXEYERAD && ERadius>=MINEYERAD)
				//center of object should be in upper half of face region
				&& (currMidy <= faceMidy)
				&& (currMidy >= (faceMidy/2))
				&& (currMidx < faceX+faceWidth)
				&& (currMidx > faceX+(int)((float)faceWidth*(float)0.5)))
			{
				RightPossibleEyes[REyeCounter++] = i;
			}			
		}

		//i could no detect 2 eyes
		if(LEyeCounter<=0 || REyeCounter<=0) return -1;

		//doing this we wil get the smallest two objects 
		for(int j=0; j<LEyeCounter;j++)
		{
			LeftEyeDetector->GetObjectCoordinates( LeftPossibleEyes[j], currX, currY, currWidth, currHeight);
			
			//get two objects with smallest areas
			int currArea = currWidth * currHeight;
			if(minArea > currArea)
			{
				//new best minimum
				minArea = currArea;
				leftEyeIndex = LeftPossibleEyes[j];				
			}
		}

		for(int j=0; j<REyeCounter;j++)
		{
			RightEyeDetector->GetObjectCoordinates( RightPossibleEyes[j], currX, currY, currWidth, currHeight);
			
			//get two objects with smallest areas
			int currArea = currWidth * currHeight;
			if(minArea2 > currArea)
			{
				//new best minimum
				minArea2 = currArea;
				rightEyeIndex = RightPossibleEyes[j];				
			}
		}


		//now compute centers of eyes
		RightEyeDetector->GetObjectCoordinates( rightEyeIndex, minRX, minRY, minRWidth, minRHeight);
		LeftEyeDetector->GetObjectCoordinates( leftEyeIndex, minLX, minLY, minLWidth, minLHeight);

		//assign value to by address variables
		rx = minRX + (minRWidth/2);
		ry = minRY + (minRHeight/2);

		lx = minLX + (minLWidth/2);
		ly = minLY + (minLHeight/2);

		// i detected 2 eyes
		return 2;
	}

	//number of faces!=1
	//else
	//	return -1;
}

void FaceLocator::getCoordinates(int index, int &lx, int &ly, int &rx, int &ry)
{
	FaceDetector->GetObjectCoordinates(index, lx, ly, rx, ry);	
	/*lx = FaceDetector->object_location[index,0];
	ly = FaceDetector->object_location[index,1];
	rx = FaceDetector->object_location[index,2];
	ry = FaceDetector->object_location[index,3];
	*/
} 
