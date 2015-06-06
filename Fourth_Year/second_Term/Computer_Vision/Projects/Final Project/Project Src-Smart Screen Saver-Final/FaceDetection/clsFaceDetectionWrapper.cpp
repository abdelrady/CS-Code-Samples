#include ".\clsfacedetectionwrapper.h"
#using <mscorlib.dll>


clsFaceDetectionWrapper::clsFaceDetectionWrapper(void)
{
	faceLocator = new FaceLocator();		
}

clsFaceDetectionWrapper::~clsFaceDetectionWrapper(void)
{
	delete faceLocator;
}

int clsFaceDetectionWrapper::WrapDetectFaces(System::Drawing::Bitmap* Image)
{
	//convert from Managed Image to IplImage
	 
	IplImage* ImageData = cvCreateImage(cvSize(Image->Width,Image->Height),8,1);
	int i=0;
	for (int y=0;y<Image->Height;y++)
	{
		for (int x=0;x<Image->Width;x++)
		{	    
			//ARGB cahnnel
			ImageData->imageData[i++] =(char)Image->GetPixel(x,y).ToArgb();						
		}
	}	

	return faceLocator->DetectFaces(ImageData);
}

int clsFaceDetectionWrapper::WrapGetFaceCordinates(int index, int &lx, int &ly, int &rx, int &ry)
{
	return faceLocator->GetFaceCordinates(index, lx, ly, rx, ry);
}

int clsFaceDetectionWrapper::WrapGetEyeCordinates(int index, int &lx, int &ly, int &rx, int &ry)
{
	return faceLocator->GetEyeCordinates(index, lx, ly, rx, ry);
}
void clsFaceDetectionWrapper::WrapGetCoordinates(int index, int &lx, int &ly, int &rx, int &ry)
{
	faceLocator->getCoordinates(index, lx, ly, rx, ry);
}

