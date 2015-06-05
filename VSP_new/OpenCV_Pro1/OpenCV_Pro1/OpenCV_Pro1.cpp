// OpenCV_Pro1.cpp : Defines the entry point for the console application.
//
// Usage: warp_affine <image>
//
#include "stdafx.h"
#include <cv.h>
#include <highgui.h>
int main(int argc, char** argv)
{
CvPoint2D32f srcTri[3], dstTri[3];
CvMat* rot_mat = cvCreateMat(2,3,CV_32FC1);
CvMat* warp_mat = cvCreateMat(2,3,CV_32FC1);
IplImage *src, *dst;
src=cvLoadImage("E:\\Affine1.jpg");
{
dst = cvCloneImage( src );
dst->origin = src->origin;
cvZero( dst );
// Compute warp matrix
//
srcTri[0].x = 43; //src Top left
srcTri[0].y = 43;
srcTri[1].x = 138; //src Top right
srcTri[1].y = 43;
srcTri[2].x = 138; //src Bottom left offset
srcTri[2].y = 91;
dstTri[0].x = 43*0.0; //dst Top left
dstTri[0].y = 43*0.33;
dstTri[1].x = 138*0.85; //dst Top right
dstTri[1].y = 43*0.25;
dstTri[2].x = 138*0.15; //dst Bottom left offset
dstTri[2].y = 91*0.7;
cvGetAffineTransform( srcTri, dstTri, warp_mat );
cvWarpAffine( src, dst, warp_mat );
cvNamedWindow( "Affine_Transform1", 1 );
cvShowImage( "Affine_Transform1", dst );

cvCopy( dst, src );
// Compute rotation matrix
//
CvPoint2D32f center = cvPoint2D32f(
src->width/3,
src->height/3
);
double angle = -50.0;
double scale = 0.6;
cv2DRotationMatrix( center, angle, scale, rot_mat );
// Do the transformation
//
cvWarpAffine( src, dst, rot_mat );
cvNamedWindow( "Affine_Transform", 1 );
cvShowImage( "Affine_Transform", dst );
cvWaitKey();
}
cvReleaseImage( &dst );
cvReleaseMat( &rot_mat );
cvReleaseMat( &warp_mat );
return 0;
}

//#include "stdafx.h"
//#include "highgui.h"
//#include "cv.h"
//#include <math.h>

int g_slider_position = 0;
CvCapture* g_capture = NULL;

void onTrackbarSlide(int pos) 
{
	cvSetCaptureProperty(g_capture,CV_CAP_PROP_POS_FRAMES,pos);
}
IplImage* doCanny(IplImage* in,double lowThresh,double highThresh,double aperture)
{
if(in->nChannels != 1)
	return 0; //Canny only handles gray scale images
IplImage* out = cvCreateImage(cvSize( cvGetSize( in ).width , cvGetSize( in ).height),IPL_DEPTH_8U,1);
cvCanny( in, out, lowThresh, highThresh, aperture );
return out;
};
IplImage* doPyrDown(IplImage* in,int filter = IPL_GAUSSIAN_5x5)
{
// Best to make sure input image is divisible by two.
//
assert( in->width%2 == 0 && in->height%2 == 0 );
IplImage* out = cvCreateImage(
cvSize( in->width/2, in->height/2 ),
in->depth,
in->nChannels
);
cvPyrDown( in, out );
return( out );
};
void example2_4( IplImage* image )
{
cvShowImage( "Example4-in", image );
// Create an image to hold the smoothed output
//
IplImage* out = doPyrDown(image); //= cvCreateImage(cvGetSize(image),IPL_DEPTH_8U,3);
IplImage* SmoothOut = cvCreateImage(cvGetSize(image),IPL_DEPTH_8U,3);
//Do the smoothing
//
cvSmooth( image, SmoothOut, CV_GAUSSIAN, 7, 7 );
cvConvertImage(SmoothOut,SmoothOut,CV_CVTIMG_FLIP );
// Show the smoothed image in the output window
//
cvShowImage("Example4-out3" , SmoothOut);
cvConvertImage(out,out,CV_CVTIMG_FLIP );
IplImage* out2 = cvCreateImage(cvGetSize(out),IPL_DEPTH_8U,1);
cvCvtColor(out,out2,CV_RGB2GRAY);
cvShowImage( "Example4-out", out2 );
IplImage* out3 = doCanny( out2, 10, 100, 3 );
cvShowImage( "Example4-out2", out3 );
// Be tidy
//
cvReleaseImage( &out );
cvReleaseImage( &out2 );
cvReleaseImage( &out3 );
cvReleaseImage( &SmoothOut );

// Wait for the user to hit a key, then clean up the windows
//
//cvWaitKey( 0 );

}


//int _tmain(int argc, _TCHAR* argv[])
//{
	/* Program1 Show A picture From File
	IplImage* img = cvLoadImage( "E:\\IQResult.jpg" );//argv[1]
cvNamedWindow( "Example1", 0 );//CV_WINDOW_AUTOSIZE
cvShowImage( "Example1", img );
cvWaitKey(10000);
cvReleaseImage( &img );
cvDestroyWindow( "Example1" );*/

	//
/*	Show Video From File


	cvNamedWindow( "Example2", CV_WINDOW_AUTOSIZE );
	CvCapture* capture = cvCreateFileCapture( "E:\\‘жЁег гегнд\\Bill_Gates.avi" );//argv[1]
	
IplImage* frame;
while(1) {
frame = cvQueryFrame( capture );
if( !frame ) break;
cvShowImage( "Example2", frame );
char c = cvWaitKey(33);
if( c == 27 ) break;//13 For Enter Key And 27 For ESC Key
}
cvReleaseCapture( &capture );
cvDestroyWindow( "Example2" );
*/

/*Program to add a trackbar slider to the basic viewer window*/
//cvNamedWindow( "Example3", CV_WINDOW_AUTOSIZE );
	// Create some windows to show the input
// and output images in.
//
//cvNamedWindow( "Example4-in" );
//cvNamedWindow( "Example4-out" );
//cvNamedWindow( "Example4-out2" );
//cvNamedWindow( "Example4-out3" );
// Create a window to show our input image
//
//g_capture = cvCreateFileCapture( "E:\\‘жЁег гегнд\\Bill_Gates.avi" );
//g_capture = cvCreateCameraCapture(0);
/*int frames = (int) cvGetCaptureProperty(g_capture,CV_CAP_PROP_FRAME_COUNT);
if( frames!= 0 ) {
cvCreateTrackbar("Position","Example4-in",&g_slider_position,frames,onTrackbarSlide);
}*/
//IplImage* frame;

// While loop (as in Example 2) capture & show video
//Е
// Release memory and destroy window 
//Е
/*while(1)
{
frame = cvQueryFrame( g_capture );
//cvSetTrackbarPos("Position","Example4-in", (int) cvGetCaptureProperty(g_capture,CV_CAP_PROP_POS_FRAMES));
if( !frame ) break;
//cvShowImage( "Example3", frame );
example2_4(frame);
//cvShowImage("Example4-in",frame);
char c = cvWaitKey(33);//1000 / (int) cvGetCaptureProperty(g_capture , CV_CAP_PROP_FPS));
if( c == 27 ) break;//13 For Enter Key And 27 For ESC Key
}
cvReleaseCapture( &g_capture );

cvDestroyWindow( "Example4-in" );
cvDestroyWindow( "Example4-out" );
	return 0;
}*/
/*
int _tmain(int argc, _TCHAR* argv[])
{
	
cvNamedWindow( "Example2", CV_WINDOW_AUTOSIZE );
	CvCapture* capture = cvCreateFileCapture( "E:\\Aflam\\Jimmy Neutron\\Jimmy Neutron.avi");//argv[1]
	
IplImage* frame;
while(1) {
frame = cvQueryFrame( capture );
if( !frame )
{
	//assert(frame!=NULL);
	break;
}
cvShowImage( "Example2", frame );
char c = cvWaitKey(33);
if( c == 27 ) break;//13 For Enter Key And 27 For ESC Key
}
cvReleaseCapture( &capture );
cvDestroyWindow( "Example2" );
*/
	//IplImage* src;
	//src=cvLoadImage("E:\\‘жЁег гегнд\\img3gray256.bmp",CV_LOAD_IMAGE_GRAYSCALE);
	/*IplImage* src;
	src=cvLoadImage("E:\\snapshot20090227215137.jpg",1);
	cvFlip(src , src , 1);
	
	cvNamedWindow( "Roi_Add0", 1 );
	cvShowImage( "Roi_Add0", src);
	cvWaitKey();
	*/
	/*
	CvMat* mat1;
	mat1 = cvCreateMat(100,100, CV_8UC3);
	cvSetZero(mat1);
	uchar* ptr = cvPtr2D(mat1,5,10);*/
	/*for(int i=0;i<50;i++)
	{
		for(int j=0;j<50;j++)
		{
			
			ptr[i+j] = 100;
			ptr[i+j+1] = 255;
			ptr[i+j+2] = 100;
		}
	}*//*
	cvDrawLine(mat1, cvPoint(5,10),cvPoint(20,30),CV_RGB(0,255,0));

	IplImage* src = cvCreateImage(cvGetSize(mat1),8,3);
	cvCopyImage(mat1, src);
*/


	//cvNamedWindow( "Roi_Add0", 1 );
	//cvShowImage( "Roi_Add0", src);
	//cvWaitKey();
	/*	IplImage* dst1 = cvCreateImage(cvGetSize(src),8,1);
		IplImage* dst2 = cvCreateImage(cvGetSize(src),8,1);
		IplImage* dst3 = cvCreateImage(cvGetSize(src),8,1);
		IplImage* dst4 = cvCreateImage(cvGetSize(src),8,1);
		cvSplit(src,dst1,dst2,dst3,NULL);

		cvNamedWindow( "Roi_Add1", 1 );
		cvShowImage( "Roi_Add1", dst1);

		cvNamedWindow( "Roi_Add2", 1 );
		cvShowImage( "Roi_Add2", dst2 );
		
		cvNamedWindow( "Roi_Add3", 1 );
		cvShowImage( "Roi_Add3", dst3);
		
		//cvNamedWindow( "Roi_Add4", 1 );
		//cvShowImage( "Roi_Add4", dst4 );

		cvWaitKey();
		*/

/*if(((src=cvLoadImage("E:\\snapshot20090227215137.jpg",1)) != 0 ))
{
int x = atoi("250");
int y = atoi("250");
int width = 800;
int height = 800;
int add = -100;
cvSetImageROI(src, cvRect(x,y,width,height));
cvAddS(src, cvScalar(add),src);
cvResetImageROI(src);
cvNamedWindow( "Roi_Add", 1 );
cvShowImage( "Roi_Add", src );
cvWaitKey();
}*/
//return 0;
	/*
	IplImage* img = cvLoadImage("E:\\snapshot20090227215137.jpg");
	for( int y=0; y<img->height; y++ ) {
uchar* ptr = (uchar*) (
img->imageData + y * img->widthStep
);
for( int x=0; x<img->width; x++ ) {
ptr[3*x+1] = 255;
ptr[3*x+2] = 255;
}
}
	cvNamedWindow("Wnd1");
	cvShowImage("Wnd1",img);
	cvWaitKey(0);*/
	/*
CvCapture* capture = 0;
capture = cvCreateCameraCapture(0);
if(!capture){
return -1;
}
IplImage *bgr_frame=cvQueryFrame(capture);//Init the video read
//cvReleaseData(bgr_frame); //Error You Can't Release a byRef Copy of frame from the structe
double fps = 30.0;//cvGetCaptureProperty (capture,CV_CAP_PROP_FPS);
CvSize size = cvSize(800 , 600);//((int)cvGetCaptureProperty( capture, CV_CAP_PROP_FRAME_WIDTH),(int)cvGetCaptureProperty( capture, CV_CAP_PROP_FRAME_HEIGHT));
*/
	//CvVideoWriter *writer = cvCreateVideoWriter("E:\\Bill_Gates2.avi",-1 /*CV_FOURCC('M','P','E','G')*/,fps,size);
/*IplImage* logpolar_frame = cvCreateImage(size,IPL_DEPTH_8U,3);
int count = 0 ;
while( (bgr_frame=cvQueryFrame(capture)) != NULL && count<500)
{
cvLogPolar( bgr_frame, logpolar_frame,cvPoint2D32f(bgr_frame->width/2,bgr_frame->height/2),40, CV_INTER_LINEAR);//+CV_WARP_FILL_OUTLIERS
cvWriteFrame( writer, logpolar_frame );
count++;
char key = cvWaitKey(33);
//if(key == 27) break;
}
cvReleaseVideoWriter( &writer );
cvReleaseImage( &logpolar_frame );
cvReleaseCapture( &capture );*/

//return 0;
//}


//#include <cv.h>
//#include <highgui.h>
//#include <math.h>
/*
int main(int argc, char** argv) {
IplImage* image = cvLoadImage(
"E:\\Circles.jpg" ,//argv[1],
CV_LOAD_IMAGE_GRAYSCALE
);
CvMemStorage* storage = cvCreateMemStorage(0);
cvSmooth(image, image, CV_GAUSSIAN, 5, 5 );
CvSeq* results = cvHoughCircles(
image,
storage,
CV_HOUGH_GRADIENT,
2,
image->width/10
);
for( int i = 0; i < results->total; i++ ) {
float* p = (float*) cvGetSeqElem( results, i );
CvPoint pt = cvPoint( cvRound( p[0] ), cvRound( p[1] ) );
cvCircle(
image,
pt,
cvRound( p[2] ),
CV_RGB(0xff,0x00,0x00)
);
}
cvNamedWindow( "cvHoughCircles", 1 );
cvShowImage( "cvHoughCircles", image);
cvWaitKey(0);
}*/