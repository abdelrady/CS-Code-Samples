#pragma once
#include "FaceLocator.h"

#pragma managed 

public __gc class clsFaceDetectionWrapper
{
private:
	clsFaceDetectionWrapper(void);
	FaceLocator *faceLocator;
public:
	
	~clsFaceDetectionWrapper(void);
    static clsFaceDetectionWrapper* fwInstance=NULL;
	static clsFaceDetectionWrapper* GetSingletonInstance(void)
		{
			if(fwInstance==NULL)
			{
				fwInstance = new clsFaceDetectionWrapper();
			}
			return fwInstance;
		}	
	
	int WrapDetectFaces(System::Drawing::Bitmap* Image);	
	int WrapGetFaceCordinates(int index, int &lx, int &ly, int &rx, int &ry);	
	int WrapGetEyeCordinates(int index, int &lx, int &ly, int &rx, int &ry);
	void WrapGetCoordinates(int index, int &lx, int &ly, int &rx, int &ry);
};
