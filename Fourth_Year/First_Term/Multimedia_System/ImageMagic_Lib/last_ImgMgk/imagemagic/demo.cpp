// This may look like C code, but it is really -*- C++ -*-
//
// Copyright Bob Friesenhahn, 1999, 2000, 2001, 2002, 2003
//
// Simple demo program for Magick++
//
// Concept and algorithms lifted from PerlMagick demo script written
// by John Christy.
//
// Max run-time size 60MB (as compared with 95MB for PerlMagick) under SPARC Solaris
//

#include <Magick++.h>
#include <string>
#include <iostream>
#include <list>

using namespace std;

using namespace Magick;

int main( int argc, char * argv[])
{

  // Initialize ImageMagick install location for Windows
  InitializeMagick(*argv);
  
  //Image asd("bar1.bmp");
  //asd.blur();
  //asd.write("bar2.bmp");
  //cout<<"End"<<endl;
  //return 0;
  
  try {

    
    string srcdir("");
    if(getenv("SRCDIR") != 0)
      srcdir = getenv("SRCDIR");
    
    list<Image> montage;
    {
      //
      // Read model & smile image.
      //
	
		Color col("white");
		Image image2(Geometry("500x500!"), col ); 
		//image2.size(Geometry(500,500));
		image2.magick("RGBA");
		//image2.backgroundColor("#ffffff");
		//image2.read( "NULL:white" );

		string strpath="";
        cout << "Read images ..." << endl;
		if(argc>1)strpath= srcdir + argv[1];
		else 
		{
			cout<<"Enter Image Path:";
			cin>>strpath;
		}
      Image model(strpath) /*"model.gif"*/ ;
      model.label( "Magick++" );
      model.borderColor( "black" );
      model.backgroundColor( "black" );
	  //model.resize(Geometry(100,100));
	  
	  //model.write("model-test.gif");

	 string str="img1";
      //
      // Create image stack.
      //
      cout << "Creating thumbnails..." << endl;
    
      // Construct initial list containing five copies of a null image
      Image null;
      null.size( Geometry(100,100) );
      null.read( "NULL:black" );
      list<Image> images( 0, null );
	
      Image example = model;
      // Each of the following follow the pattern
      //  1. obtain reference to (own copy of) image
      //  2. apply label to image
      //  3. apply operation to image
      //  4. append image to container

      cout << "  add noise ..." << endl;
      example.label( "Add Noise" );
      example.addNoise( LaplacianNoise );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,0,0), OverCompositeOp);
      images.push_back( example );
	  //example.write(str+".jpg");
	  //str+="1";

      cout << "  annotate ..." << endl;
      example = model;
      example.label( "Annotate" );
      example.density( "72x72" );
      example.fontPointsize( 18 );
      example.strokeColor( Color() );
      example.fillColor( "goldenrod" );
      example.annotate( "Magick++", "+0+20", NorthGravity );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,100,0), OverCompositeOp);
      images.push_back( example );
	  //example.write(str+".gif");
	  //str+="1";

      cout << "  rotate ..." << endl;
      example = model;
      example.label( "Rotate" );
      example.rotate( 45 );
      example.transparent( "black" );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,200,0), OverCompositeOp);
      images.push_back( example );
	  //example.write(str+".gif");
	  //str+="1";
	  
      cout << "  border ..." << endl;
      example = model;
      example.label( "Border" );
      example.borderColor( "goldenrod" );
      example.border( Geometry(6,6) );
	  //example.resize(Geometry(100,100));
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,300,0), OverCompositeOp);
      images.push_back( example );
	  //example.write(str+".gif");
	  //str+="1";

      cout << "  channel ..." << endl;
      example = model;
      example.label( "Channel" );
      example.channel( RedChannel );
	  //example.resize(Geometry(100,100));
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,400,0), OverCompositeOp);
      images.push_back( example );
//		example.write(str+".gif");
//		str+="1";

      cout << "  charcoal ..." << endl;
      example = model;
      example.label( "Charcoal" );
      example.charcoal( );
	  //example.resize(Geometry(100,100));
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,0,100), OverCompositeOp);
      images.push_back( example );


      cout << "  contrast ..." << endl;
      example = model;
      example.label( "Contrast" );
      example.contrast( false );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,100,100), OverCompositeOp);
      images.push_back( example );

      cout << "  convolve ..." << endl;
      example = model;
      example.label( "Convolve" );
      {
        // 3x3 matrix
        const double kernel[] = { 1, 1, 1, 1, 4, 1, 1, 1, 1 };
        example.convolve( 3, kernel );
      }
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,200,100), OverCompositeOp);
      images.push_back( example );

	  cout << "  flip ..." << endl;
      example = model;
      example.label( "Flip" );
      example.flip( );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,300,100), OverCompositeOp);
      images.push_back( example );

      cout << "  flop ..." << endl;
      example = model;
      example.label( "Flop" );
      example.flop();
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,400,100), OverCompositeOp);
      images.push_back( example );


	  //////////////////////////////////////////////////////////////////////////////////////////////////
	  cout << "  swirl ..." << endl;
      example = model;
      example.backgroundColor( "#000000FF" );
      example.label( "Swirl" );
      example.swirl( 90 );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,0,200), OverCompositeOp);
      images.push_back( example );

      cout << "  draw ..." << endl;
      example = model;
      example.label( "Draw" );
      example.fillColor(Color());
      example.strokeColor( "goldenrod" );
      example.strokeWidth( 2 );
      example.draw( DrawableCircle( 60,90, 60,100 ) );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,100,200), OverCompositeOp);
      images.push_back( example );

      cout << "  edge ..." << endl;
      example = model;
      example.label( "Detect Edges" );
      example.edge( );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,200,200), OverCompositeOp);
      images.push_back( example );

      cout << "  emboss ..." << endl;
      example = model;
      example.label( "Emboss" );
      example.emboss( );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,300,200), OverCompositeOp);
      images.push_back( example );

      cout << "  equalize ..." << endl;
      example = model;
      example.label( "Equalize" );
      example.equalize( );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,400,200), OverCompositeOp);
      images.push_back( example );
    
      cout << "  explode ..." << endl;
      example = model;
      example.label( "Explode" );
      example.backgroundColor( "#000000FF" );
      example.implode( -1 );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,0,300), OverCompositeOp);
      images.push_back( example );

      

      cout << "  frame ..." << endl;
      example = model;
      example.label( "Frame" );
      example.frame( );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,100,300), OverCompositeOp);
      images.push_back( example );

      cout << "  wave ..." << endl;
      example = model;
      example.label( "Wave" );
      example.matte( true );
      example.backgroundColor( "#000000FF" );
      example.wave( 25, 150 );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,200,300), OverCompositeOp);
      images.push_back( example );

      cout << "  shear ..." << endl;
      example = model;
      example.label( "Shear" );
      example.shear( 45, 45 );
      example.transparent( "black" );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,300,300), OverCompositeOp);
      images.push_back( example );
    
	  cout << "  monochrome ..." << endl;
      example = model;
      example.label( "Monochrome" );
      example.quantizeColorSpace( GRAYColorspace );
      example.quantizeColors( 2 );
      example.quantizeDither( false );
      example.quantize( );
      example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,400,300), OverCompositeOp);
      images.push_back( example );

      cout << "  grayscale ..." << endl;
      example = model;
      example.label( "Grayscale" );
      example.quantizeColorSpace( GRAYColorspace );
      example.quantize( );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,0,400), OverCompositeOp);
      images.push_back( example );

	  cout << "  implode ..." << endl;
      example = model;
      example.label( "Implode" );
      example.implode( 0.5 );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,100,400), OverCompositeOp);
      images.push_back( example );

      cout << "  negate ..." << endl;
      example = model;
      example.label( "Negate" );
      example.negate( );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,200,400), OverCompositeOp);
      images.push_back( example );

      cout << "  level red channel ..." << endl;
      example = model;
      example.label( "Level Red" );
      example.levelChannel( RedChannel, 0.20*QuantumRange, 0.90*QuantumRange, 1.20 );
	  example.resize("100x100!");
	  image2.composite(example,Geometry(0,0,300,400), OverCompositeOp);
      images.push_back( example );

      cout << "  plasma ..." << endl;
      Image plasma;
      plasma.size( "130x194" );
      plasma.read( "plasma:fractal" );
      plasma.label( "Plasma" );
	  plasma.resize("100x100!");
	  image2.composite(plasma,Geometry(0,0,400,400), OverCompositeOp);
      images.push_back(plasma  );


      //
      // Create image montage.
      //
	  cout <<  "Montage images..." << endl;

      image2.write("test2.gif");
      
	  for_each( images.begin(), images.end(), strokeColorImage( Color("#600") ) );

      MontageFramed montageOpts;
      //montageOpts.geometry( "130x194+10+5>" );
	  montageOpts.geometry( "100x100+0+0" );
      montageOpts.gravity(CenterGravity );/*NorthWestGravity /*/
      montageOpts.borderColor( "green" );
      montageOpts.borderWidth( 0 );
	  //montageOpts.( 0 );
      montageOpts.tile( "5x5!" );
      //montageOpts.compose( OverCompositeOp );
      montageOpts.backgroundColor( "#ffffff" );
      montageOpts.pointSize( 1 /*18*/ );
      montageOpts.fillColor( "#600" );
      montageOpts.strokeColor( Color() );
      //montageOpts.compose(OverCompositeOp);
      montageOpts.fileName( "Magick++ Demo" );
      montageImages( &montage, images.begin(), images.end(), montageOpts );
    }

    Image& montage_image = montage.front();

    cout << "Writing image \"demo_out.*\" ..." << endl;
	montage_image.resize("500x500!");
    montage_image.matte( false );
    montage_image.compressType( RLECompression );
    montage_image.write( "demo_out.gif" );

    // Uncomment following lines to display image to screen
    //    cout <<  "Display image..." << endl;
    //    montage_image.display();

  }
  catch( exception &error_ )
    {
      cout << "Caught exception: " << error_.what() << endl;
      return 1;
    }

  return 0;
}
