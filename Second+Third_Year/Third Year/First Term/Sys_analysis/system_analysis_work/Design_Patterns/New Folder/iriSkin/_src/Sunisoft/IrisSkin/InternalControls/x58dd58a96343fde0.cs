//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin.InternalControls

{
		
		#region Namespace Import Declarations
		
			using System.Drawing;
			using System.IO;
			using System.Reflection;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class x58dd58a96343fde0
	
	{
		
		#region Constructors
		
			public x58dd58a96343fde0 ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ret 
			*/
		#endregion
		
		#region Methods
		
			public static Bitmap x3a15a33740cd7ff9 (Type xeaa6eb5f09df2be8, string xe11224e032957d06)
			
			/*
				// Code Size: 16 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldc.i4.0 
				L_0003: ldc.i4.0 
				L_0004: ldc.i4.0 
				L_0005: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_000a: call Sunisoft.IrisSkin.InternalControls.x58dd58a96343fde0::System.Drawing.Bitmap x3a15a33740cd7ff9(System.Type, System.String, Boolean, System.Drawing.Point)
				L_000f: ret 
			*/
			
			
			{
				return x58dd58a96343fde0.x3a15a33740cd7ff9 (xeaa6eb5f09df2be8, xe11224e032957d06, false, new Point (0, 0));
			}
			
			public static Bitmap x3a15a33740cd7ff9 (Type xeaa6eb5f09df2be8, string xe11224e032957d06, Point xc8f338823ae9b184)
			
			/*
				// Code Size: 10 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldc.i4.1 
				L_0003: ldarg.2 
				L_0004: call Sunisoft.IrisSkin.InternalControls.x58dd58a96343fde0::System.Drawing.Bitmap x3a15a33740cd7ff9(System.Type, System.String, Boolean, System.Drawing.Point)
				L_0009: ret 
			*/
			
			
			{
				return x58dd58a96343fde0.x3a15a33740cd7ff9 (xeaa6eb5f09df2be8, xe11224e032957d06, true, xc8f338823ae9b184);
			}
			
			protected static Bitmap x3a15a33740cd7ff9 (Type xeaa6eb5f09df2be8, string xe11224e032957d06, bool x4cf1847391b87d80, Point xc8f338823ae9b184)
			
			/*
				// Code Size: 55 Bytes
				.maxstack 5
				.locals (System.Reflection.Assembly V_0, 
         System.IO.Stream V_1, 
         System.Drawing.Bitmap V_2, 
         System.Drawing.Color V_3)
				L_0000: ldarg.0 
				L_0001: call System.Reflection.Assembly::System.Reflection.Assembly GetAssembly(System.Type)
				L_0006: stloc.0 
				L_0007: ldloc.0 
				L_0008: ldarg.1 
				L_0009: callvirt System.Reflection.Assembly::System.IO.Stream GetManifestResourceStream(System.String)
				L_000e: stloc.1 
				L_000f: ldloc.1 
				L_0010: newobj System.Drawing.Bitmap::Void .ctor(System.IO.Stream)
				L_0015: stloc.2 
				L_0016: ldarg.2 
				L_0017: brfalse.s L_0035
				L_0019: ldloc.2 
				L_001a: ldarga.s xc8f338823ae9b184
				L_001c: call System.Drawing.Point::Int32 get_X()
				L_0021: ldarga.s xc8f338823ae9b184
				L_0023: call System.Drawing.Point::Int32 get_Y()
				L_0028: callvirt System.Drawing.Bitmap::System.Drawing.Color GetPixel(Int32, Int32)
				L_002d: stloc.3 
				L_002e: ldloc.2 
				L_002f: ldloc.3 
				L_0030: callvirt System.Drawing.Bitmap::Void MakeTransparent(System.Drawing.Color)
				L_0035: ldloc.2 
				L_0036: ret 
			*/
			
			
			{
				Assembly assembly1 = Assembly.GetAssembly (xeaa6eb5f09df2be8);
				Stream stream1 = assembly1.GetManifestResourceStream (xe11224e032957d06);
				Bitmap bitmap1 = new Bitmap (stream1);
				if (! x4cf1847391b87d80)
				{
					return bitmap1;
				}
				Color color1 = bitmap1.GetPixel (xc8f338823ae9b184.X, xc8f338823ae9b184.Y);
				bitmap1.MakeTransparent (color1);
				return bitmap1;
			}
			
			public static Icon x8416bef470546b99 (Type xeaa6eb5f09df2be8, string x97faed849ce4bc37, Size x10bfbd9ec25bb113)
			
			/*
				// Code Size: 16 Bytes
				.maxstack 4
				.locals (System.Drawing.Icon V_0)
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: call Sunisoft.IrisSkin.InternalControls.x58dd58a96343fde0::System.Drawing.Icon x8416bef470546b99(System.Type, System.String)
				L_0007: stloc.0 
				L_0008: ldloc.0 
				L_0009: ldarg.2 
				L_000a: newobj System.Drawing.Icon::Void .ctor(System.Drawing.Icon, System.Drawing.Size)
				L_000f: ret 
			*/
			
			
			{
				Icon icon1 = x58dd58a96343fde0.x8416bef470546b99 (xeaa6eb5f09df2be8, x97faed849ce4bc37);
				return new Icon (icon1, x10bfbd9ec25bb113);
			}
			
			public static Icon x8416bef470546b99 (Type xeaa6eb5f09df2be8, string x97faed849ce4bc37)
			
			/*
				// Code Size: 22 Bytes
				.maxstack 3
				.locals (System.Reflection.Assembly V_0, 
         System.IO.Stream V_1)
				L_0000: ldarg.0 
				L_0001: call System.Reflection.Assembly::System.Reflection.Assembly GetAssembly(System.Type)
				L_0006: stloc.0 
				L_0007: ldloc.0 
				L_0008: ldarg.1 
				L_0009: callvirt System.Reflection.Assembly::System.IO.Stream GetManifestResourceStream(System.String)
				L_000e: stloc.1 
				L_000f: ldloc.1 
				L_0010: newobj System.Drawing.Icon::Void .ctor(System.IO.Stream)
				L_0015: ret 
			*/
			
			
			{
				Assembly assembly1 = Assembly.GetAssembly (xeaa6eb5f09df2be8);
				Stream stream1 = assembly1.GetManifestResourceStream (x97faed849ce4bc37);
				return new Icon (stream1);
			}
			
			public static Cursor xcf51636dcaab3d17 (Type xeaa6eb5f09df2be8, string x0b86337216eb3199)
			
			/*
				// Code Size: 22 Bytes
				.maxstack 3
				.locals (System.Reflection.Assembly V_0, 
         System.IO.Stream V_1)
				L_0000: ldarg.0 
				L_0001: call System.Reflection.Assembly::System.Reflection.Assembly GetAssembly(System.Type)
				L_0006: stloc.0 
				L_0007: ldloc.0 
				L_0008: ldarg.1 
				L_0009: callvirt System.Reflection.Assembly::System.IO.Stream GetManifestResourceStream(System.String)
				L_000e: stloc.1 
				L_000f: ldloc.1 
				L_0010: newobj System.Windows.Forms.Cursor::Void .ctor(System.IO.Stream)
				L_0015: ret 
			*/
			
			
			{
				Assembly assembly1 = Assembly.GetAssembly (xeaa6eb5f09df2be8);
				Stream stream1 = assembly1.GetManifestResourceStream (x0b86337216eb3199);
				return new Cursor (stream1);
			}
			
			protected static ImageList xd1601e45c3cc2056 (Type xeaa6eb5f09df2be8, string xe11224e032957d06, Size x95dac044246123ac, bool x4cf1847391b87d80, Point xc8f338823ae9b184)
			
			/*
				// Code Size: 83 Bytes
				.maxstack 5
				.locals (System.Windows.Forms.ImageList V_0, 
         System.Reflection.Assembly V_1, 
         System.IO.Stream V_2, 
         System.Drawing.Bitmap V_3, 
         System.Drawing.Color V_4)
				L_0000: newobj System.Windows.Forms.ImageList::Void .ctor()
				L_0005: stloc.0 
				L_0006: ldloc.0 
				L_0007: ldarg.2 
				L_0008: callvirt System.Windows.Forms.ImageList::Void set_ImageSize(System.Drawing.Size)
				L_000d: ldarg.0 
				L_000e: call System.Reflection.Assembly::System.Reflection.Assembly GetAssembly(System.Type)
				L_0013: stloc.1 
				L_0014: ldloc.1 
				L_0015: ldarg.1 
				L_0016: callvirt System.Reflection.Assembly::System.IO.Stream GetManifestResourceStream(System.String)
				L_001b: stloc.2 
				L_001c: ldloc.2 
				L_001d: newobj System.Drawing.Bitmap::Void .ctor(System.IO.Stream)
				L_0022: stloc.3 
				L_0023: ldarg.3 
				L_0024: brfalse.s L_0044
				L_0026: ldloc.3 
				L_0027: ldarga.s xc8f338823ae9b184
				L_0029: call System.Drawing.Point::Int32 get_X()
				L_002e: ldarga.s xc8f338823ae9b184
				L_0030: call System.Drawing.Point::Int32 get_Y()
				L_0035: callvirt System.Drawing.Bitmap::System.Drawing.Color GetPixel(Int32, Int32)
				L_003a: stloc.s V_4
				L_003c: ldloc.3 
				L_003d: ldloc.s V_4
				L_003f: callvirt System.Drawing.Bitmap::Void MakeTransparent(System.Drawing.Color)
				L_0044: ldloc.0 
				L_0045: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_004a: ldloc.3 
				L_004b: callvirt System.Windows.Forms.ImageList+ImageCollection::Int32 AddStrip(System.Drawing.Image)
				L_0050: pop 
				L_0051: ldloc.0 
				L_0052: ret 
			*/
			
			
			{
				Color color1;
				ImageList imageList1 = new ImageList ();
				imageList1.ImageSize = x95dac044246123ac;
				Assembly assembly1 = Assembly.GetAssembly (xeaa6eb5f09df2be8);
				Stream stream1 = assembly1.GetManifestResourceStream (xe11224e032957d06);
				Bitmap bitmap1 = new Bitmap (stream1);
				if (x4cf1847391b87d80)
				{
					color1 = bitmap1.GetPixel (xc8f338823ae9b184.X, xc8f338823ae9b184.Y);
					bitmap1.MakeTransparent (color1);
				}
				int i1 = imageList1.Images.AddStrip (((Image) bitmap1));
				return imageList1;
			}
			
			public static ImageList xd1601e45c3cc2056 (Type xeaa6eb5f09df2be8, string xe11224e032957d06, Size x95dac044246123ac)
			
			/*
				// Code Size: 17 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: ldc.i4.0 
				L_0004: ldc.i4.0 
				L_0005: ldc.i4.0 
				L_0006: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_000b: call Sunisoft.IrisSkin.InternalControls.x58dd58a96343fde0::System.Windows.Forms.ImageList xd1601e45c3cc2056(System.Type, System.String, System.Drawing.Size, Boolean, System.Drawing.Point)
				L_0010: ret 
			*/
			
			
			{
				return x58dd58a96343fde0.xd1601e45c3cc2056 (xeaa6eb5f09df2be8, xe11224e032957d06, x95dac044246123ac, false, new Point (0, 0));
			}
			
			public static ImageList xd1601e45c3cc2056 (Type xeaa6eb5f09df2be8, string xe11224e032957d06, Size x95dac044246123ac, Point xc8f338823ae9b184)
			
			/*
				// Code Size: 11 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: ldc.i4.1 
				L_0004: ldarg.3 
				L_0005: call Sunisoft.IrisSkin.InternalControls.x58dd58a96343fde0::System.Windows.Forms.ImageList xd1601e45c3cc2056(System.Type, System.String, System.Drawing.Size, Boolean, System.Drawing.Point)
				L_000a: ret 
			*/
			
			
			{
				return x58dd58a96343fde0.xd1601e45c3cc2056 (xeaa6eb5f09df2be8, xe11224e032957d06, x95dac044246123ac, true, xc8f338823ae9b184);
			}
			
		#endregion
	}
	
}

