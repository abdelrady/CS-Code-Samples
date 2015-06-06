// facedetect.h : main header file for the FACEDETECT DLL
//
#pragma warning(disable : 4793)
#pragma once
#include <cv.h>
#pragma managed 

#define scale 1.3
#define MAXOBJECTCOUNT 50
#define MaxValue 32000

#pragma  


/////////////////////////////////////////////////////////////////////////////
// CFacedetectApp
// See facedetect.cpp for the implementation of this class
//
#pragma managed 
__gc class ObjectLocator 
{
private:
	int width,height;             //dimensions of the scene bitmap	  
	CvHaarClassifierCascade* cascade;
	CvMemStorage* storage ;		
	
	//int object_location __gc[MAXOBJECTCOUNT][4];  //stores the locations of detected objects	
	
	/* finds sequence element by its index */
	char* Helper( const CvSeq *seq, int index )
	{
		CvSeqBlock block;
		int count, total = seq->total;

		if( (unsigned)index >= (unsigned)total )
		{
			index += index < 0 ? total : 0;
			index -= index >= total ? total : 0;
			if( (unsigned)index >= (unsigned)total )
				return 0;
		}

		block = *seq->first;
		if( index + index <= total )
		{
			while( index >= (count = block.count) )
			{
				block = *block.next;
				index -= count;
			}
		}
		else
		{
			do
			{
				block = *block.prev;
				total -= block.count;
			}
			while( index < total );
			index -= total;
		}

		return block.data + index * seq->elem_size;
	}

public:
	int object_location __gc[,];

	void SetFaceROI(int index);
	void UnSetFaceROI();

	void UnInitImageStorage();
	void InitImageStorage(int img_width, int img_height, double img_scale);
	
	void ImagePreProcessForFaceDetection();
		
	void ManagedImagetoUnManagedImage(IplImage* Src);
	//void PrepareSmallImage();		
	int NoOfObjects;            //number of faces detected	
	void GetObjectCoordinates(int oNum, int &tx, int &ty, int &bx, int &by);
	int DetectObjects();
	int InitObjectDetect(char* cascadename);	
	ObjectLocator();
	~ObjectLocator();
};

