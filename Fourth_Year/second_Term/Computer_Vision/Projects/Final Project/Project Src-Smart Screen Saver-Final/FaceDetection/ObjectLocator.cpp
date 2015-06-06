// facedetect.cpp : Defines the initialization routines for the DLL.
//
#include "./ObjectLocator.h"

/////////////////////////////////////////////////////////////////////////////
// CFacedetectApp construction


static IplImage *big_image;
static IplImage *small_image;

ObjectLocator::ObjectLocator()
{
	int i,j;

	storage = NULL;
	cascade = NULL; 
	NoOfObjects=0;     	

object_location = new int __gc[MAXOBJECTCOUNT,4];
for (i=0;i<MAXOBJECTCOUNT;i++)
   for (j=0;j<4;j++)
	  object_location[i,j] = 0;

}

ObjectLocator::~ObjectLocator()
{	
	cvFree(&storage);
	cvFree(&cascade);
	UnInitImageStorage();
}

//csuimage to iplimage
void ObjectLocator::ManagedImagetoUnManagedImage(IplImage* Src)
{
	//use double buffering for higher frame rate
	//convert from csuImage to IplImage

	int i=0;

	/*for (int y=0;y<Src->height;y++)
	{
		for (int x=0;x<Src->width;x++)
		{	    
			//ARGB cahnnel
			big_image->imageData[i] = Src->imageData[i];
			i++;
		}
	}*/		
			big_image->imageData = Src->imageData;
}

//resize and perform histogram equilization
void ObjectLocator::ImagePreProcessForFaceDetection()
{	    
    cvResize( big_image, small_image, CV_INTER_LINEAR );
    cvEqualizeHist( small_image, small_image );    
}

void ObjectLocator::UnInitImageStorage()
{
	if(small_image!=NULL) 
	{
		cvReleaseImage(&small_image);
		small_image = NULL;
	}

	if(big_image!=NULL) 
	{
		cvReleaseImage(&big_image);
		big_image = NULL;
	}
}

void ObjectLocator::InitImageStorage(int img_width, int img_height, double img_scale)
{
	UnInitImageStorage();
	
	int t1,t2;
	t1 = cvRound((img_width)/img_scale);
	t2 = cvRound((img_height)/img_scale);
	
	if(small_image==NULL)   small_image = cvCreateImage( cvSize(t1,t2), 8, 1 );
	if(big_image==NULL) 	big_image   = cvCreateImage( cvSize(img_width , img_height ), 8, 1 );
}

int ObjectLocator::InitObjectDetect(char* cascadename)
{
  int retval=1;
	
  storage = cvCreateMemStorage();
  cascade = (CvHaarClassifierCascade*)cvLoad( cascadename, 0, 0, 0 );

  if( !cascade ) return 0;

 

  return(retval);
}

void ObjectLocator::GetObjectCoordinates(int oNum, int &tx, int &ty, int &bx, int &by)
{	
	if(oNum<NoOfObjects)
	{
		tx = object_location[oNum,0];
		ty = object_location[oNum,1];
		bx = object_location[oNum,2];
		by = object_location[oNum,3];
	}
	else
	{
		tx=ty=bx=by=0;
	}
}

void ObjectLocator::SetFaceROI(int index)
{
	CvRect rect;
	rect.x = ((object_location[index,0]/scale)-20)>0?(int)((object_location[index,0]/scale)-20):0;
	rect.y = ((object_location[index,1]/scale)-20)>0?(int)((object_location[index,1]/scale)-20):0;
	rect.width = ((object_location[index,2]/scale)+20)>0?(int)((object_location[index,2]/scale)+20):small_image->width;
	rect.height = ((object_location[index,3]/scale)+20)>0?(int)((object_location[index,3]/scale)+20):small_image->height;

	cvSetImageROI(small_image, rect); 	
}

void ObjectLocator::UnSetFaceROI()
{
	small_image->roi = NULL;
}


int ObjectLocator::DetectObjects()
{    
	int i;
    cvClearMemStorage( storage );	
	
	NoOfObjects = 0;
    if( cascade )
    {
        //double t = (double)cvGetTickCount();
        CvSeq* objects = cvHaarDetectObjects( small_image, cascade, storage,
                                            1.1, 2, 0/*CV_HAAR_DO_CANNY_PRUNING*/,
                                            cvSize(30, 30) );
        //t = (double)cvGetTickCount() - t;
        //printf( "detection time = %gms\n", t/((double)cvGetTickFrequency()*1000.) );
		
		NoOfObjects = objects->total;
		CvRect r;
        for( i = 0; i < (objects ? objects->total : 0); i++ )
        {	
			if (i<MAXOBJECTCOUNT)
			{
				r = *(CvRect*)cvGetSeqElem( objects, i );
				
				//out put these :)						           
				object_location[i,0] = (int)(r.x*scale);
				object_location[i,1] = (int)(r.y*scale);
				object_location[i,2] = (int)(r.width*scale);
				object_location[i,3] = (int)(r.height*scale);
			}		  
		}
		//cvFree(&r);
		//cvFree(&objects);
    }

  
	return (NoOfObjects>MAXOBJECTCOUNT)?MAXOBJECTCOUNT:NoOfObjects;
}

