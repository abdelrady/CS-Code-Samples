//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin

{
		
		#region Namespace Import Declarations
		
			using System.Drawing;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class xcf289f871d952cfd : x5b126f5f998c28e9
	
	{
		
		#region Constructors
		
			public xcf289f871d952cfd (IntPtr handle, ISkinEngine engine)
				 : base (handle, engine)
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.x5b126f5f998c28e9::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ret 
			*/
		#endregion
		
		#region Methods
		
			protected override void AfterWndProc (ref Message m)
			
			/*
				// Code Size: 95 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT V_0, 
         System.UInt32 V_1)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0006: stloc.1 
				L_0007: ldloc.1 
				L_0008: ldc.i4.s 15
				L_000a: bgt.un.s L_0017
				L_000c: ldloc.1 
				L_000d: ldc.i4.s 12
				L_000f: beq.s L_0035
				L_0011: ldloc.1 
				L_0012: ldc.i4.s 15
				L_0014: beq.s L_0035
				L_0016: ret 
				L_0017: ldloc.1 
				L_0018: ldc.i4.s 20
				L_001a: beq.s L_0035
				L_001c: ldloc.1 
				L_001d: ldc.i4 513
				L_0022: sub 
				L_0023: switch (L_0058, L_0058, L_0035)
				L_0034: ret 
				L_0035: ldarg.0 
				L_0036: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_003b: ldloca.s V_0
				L_003d: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr BeginPaint(IntPtr, PAINTSTRUCT ByRef)
				L_0042: pop 
				L_0043: ldarg.0 
				L_0044: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Void PaintControl()
				L_0049: ldarg.0 
				L_004a: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_004f: ldloca.s V_0
				L_0051: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean EndPaint(IntPtr, PAINTSTRUCT ByRef)
				L_0056: pop 
				L_0057: ret 
				L_0058: ldarg.0 
				L_0059: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Void PaintControl()
				L_005e: ret 
			*/
			
			
			{
				x40255b11ef821fa3.PAINTSTRUCT pAINTSTRUCT1;
				uint uInt32_1;
				uInt32_1 = ((uint) m.Msg);
				if (uInt32_1 < 15)
				{
					if ((uInt32_1 != 12) && (uInt32_1 != 15))
					{
						return;
					}
				}
				else if (uInt32_1 != 20)
				{
					switch ((int) uInt32_1)
					{
						case 513:
						case 514:
						
						{
								this.PaintControl ();
								return;
						}
						case 515:
						
						{
								goto L_0035;
						}
					}
					return;
				}
				
			L_0035:
				
				{
				}
				IntPtr intPtr1 = x61467fe65a98f20c.BeginPaint (base.Handle, out pAINTSTRUCT1);
				this.PaintControl ();
				bool b1 = x61467fe65a98f20c.EndPaint (base.Handle, ref pAINTSTRUCT1);
			}
			
			protected override void PaintControl ()
			
			/*
				// Code Size: 350 Bytes
				.maxstack 7
				.locals (System.Int32 V_0, 
         System.Drawing.Bitmap V_1, 
         System.Int32 V_2, 
         System.Int32 V_3, 
         System.Drawing.Rectangle V_4, 
         System.Drawing.Rectangle V_5, 
         System.Drawing.Bitmap V_6, 
         System.Drawing.Graphics V_7, 
         System.IntPtr V_8, 
         System.Drawing.Graphics V_9, 
         System.IntPtr V_10)
				.try L_00a5 to L_00f4 finally L_00f4 to L_0100
				.try L_0116 to L_0135 finally L_0135 to L_0141
				.try L_009c to L_0151 finally L_0151 to L_015d
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0006: ldc.i4 240
				L_000b: ldsfld System.IntPtr::IntPtr Zero
				L_0010: ldsfld System.IntPtr::IntPtr Zero
				L_0015: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SendMessage(IntPtr, UInt32, IntPtr, IntPtr)
				L_001a: stloc.s V_10
				L_001c: ldloca.s V_10
				L_001e: call System.IntPtr::Int32 ToInt32()
				L_0023: conv.i8 
				L_0024: ldc.i4.1 
				L_0025: conv.i8 
				L_0026: and 
				L_0027: ldc.i4.1 
				L_0028: conv.i8 
				L_0029: bne.un.s L_003b
				L_002b: ldarg.0 
				L_002c: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Boolean get_Enabled()
				L_0031: brfalse.s L_0037
				L_0033: ldc.i4.1 
				L_0034: stloc.0 
				L_0035: br.s L_0049
				L_0037: ldc.i4.3 
				L_0038: stloc.0 
				L_0039: br.s L_0049
				L_003b: ldarg.0 
				L_003c: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Boolean get_Enabled()
				L_0041: brfalse.s L_0047
				L_0043: ldc.i4.2 
				L_0044: stloc.0 
				L_0045: br.s L_0049
				L_0047: ldc.i4.4 
				L_0048: stloc.0 
				L_0049: ldarg.0 
				L_004a: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_004f: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0054: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SplitBitmaps get_SplitBitmaps()
				L_0059: callvirt Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] get_SKIN2_RADIOBUTTON()
				L_005e: ldloc.0 
				L_005f: ldelem.ref 
				L_0060: stloc.1 
				L_0061: ldloc.1 
				L_0062: callvirt System.Drawing.Image::Int32 get_Width()
				L_0067: stloc.2 
				L_0068: ldloc.1 
				L_0069: callvirt System.Drawing.Image::Int32 get_Height()
				L_006e: stloc.3 
				L_006f: ldloc.2 
				L_0070: ldc.i4.s 14
				L_0072: bge.s L_0079
				L_0074: ldc.i4.s 14
				L_0076: stloc.2 
				L_0077: br.s L_0081
				L_0079: ldloc.2 
				L_007a: ldc.i4.s 15
				L_007c: ble.s L_0081
				L_007e: ldc.i4.s 15
				L_0080: stloc.2 
				L_0081: ldloc.3 
				L_0082: ldc.i4.s 14
				L_0084: bge.s L_008b
				L_0086: ldc.i4.s 14
				L_0088: stloc.3 
				L_0089: br.s L_0093
				L_008b: ldloc.3 
				L_008c: ldc.i4.s 15
				L_008e: ble.s L_0093
				L_0090: ldc.i4.s 15
				L_0092: stloc.3 
				L_0093: ldloc.2 
				L_0094: ldloc.3 
				L_0095: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_009a: stloc.s V_6
				L_009c: ldloc.s V_6
				L_009e: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_00a3: stloc.s V_7
				L_00a5: ldloca.s V_4
				L_00a7: ldc.i4.0 
				L_00a8: ldc.i4.0 
				L_00a9: ldloc.1 
				L_00aa: callvirt System.Drawing.Image::Int32 get_Width()
				L_00af: ldloc.1 
				L_00b0: callvirt System.Drawing.Image::Int32 get_Height()
				L_00b5: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00ba: ldloca.s V_5
				L_00bc: ldc.i4.0 
				L_00bd: ldc.i4.0 
				L_00be: ldloc.2 
				L_00bf: ldloc.3 
				L_00c0: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00c5: ldloc.s V_7
				L_00c7: ldarg.0 
				L_00c8: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00cd: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00d2: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_00d7: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_00dc: ldc.i4.0 
				L_00dd: ldc.i4.0 
				L_00de: ldloc.2 
				L_00df: ldloc.3 
				L_00e0: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_00e5: ldloc.s V_7
				L_00e7: ldloc.1 
				L_00e8: ldloc.s V_5
				L_00ea: ldloc.s V_4
				L_00ec: ldc.i4.2 
				L_00ed: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_00f2: leave.s L_0100
				L_00f4: ldloc.s V_7
				L_00f6: brfalse.s L_00ff
				L_00f8: ldloc.s V_7
				L_00fa: callvirt System.IDisposable::Void Dispose()
				L_00ff: endfinally 
				L_0100: ldarg.0 
				L_0101: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0106: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindowDC(IntPtr)
				L_010b: stloc.s V_8
				L_010d: ldloc.s V_8
				L_010f: call System.Drawing.Graphics::System.Drawing.Graphics FromHdc(IntPtr)
				L_0114: stloc.s V_9
				L_0116: ldloca.s V_4
				L_0118: ldc.i4.0 
				L_0119: ldc.i4.0 
				L_011a: ldloc.2 
				L_011b: ldloc.3 
				L_011c: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0121: ldloc.s V_4
				L_0123: stloc.s V_5
				L_0125: ldloc.s V_9
				L_0127: ldloc.s V_6
				L_0129: ldloc.s V_5
				L_012b: ldloc.s V_4
				L_012d: ldc.i4.2 
				L_012e: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0133: leave.s L_0141
				L_0135: ldloc.s V_9
				L_0137: brfalse.s L_0140
				L_0139: ldloc.s V_9
				L_013b: callvirt System.IDisposable::Void Dispose()
				L_0140: endfinally 
				L_0141: ldarg.0 
				L_0142: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0147: ldloc.s V_8
				L_0149: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_014e: pop 
				L_014f: leave.s L_015d
				L_0151: ldloc.s V_6
				L_0153: brfalse.s L_015c
				L_0155: ldloc.s V_6
				L_0157: callvirt System.IDisposable::Void Dispose()
				L_015c: endfinally 
				L_015d: ret 
			*/
			
			
			{
				int i1;
				Rectangle rectangle1;
				Rectangle rectangle2;
				IntPtr intPtr1;
				if ((((long) x61467fe65a98f20c.SendMessage (base.Handle, 240, IntPtr.Zero, IntPtr.Zero).ToInt32 ()) & ((long) 1)) == ((long) 1))
				{
					if (this.Enabled)
					{
						i1 = 1;
					}
					else
					{
						i1 = 3;
					}
				}
				else if (this.Enabled)
				{
					i1 = 2;
				}
				else
				{
					i1 = 4;
				}
				Bitmap bitmap1 = ((SplitBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).SplitBitmaps).SKIN2_RADIOBUTTON[i1];
				int i2 = bitmap1.Width;
				int i3 = bitmap1.Height;
				if (i2 < 14)
				{
					i2 = 14;
				}
				else if (i2 > 15)
				{
					i2 = 15;
				}
				if (i3 < 14)
				{
					i3 = 14;
				}
				else if (i3 > 15)
				{
					i3 = 15;
				}
				using (Bitmap bitmap2 = new Bitmap (i2, i3))
				{
					using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap2)))
					{
						rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						rectangle2 = new Rectangle (0, 0, i2, i3);
						graphics1.FillRectangle (((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR, 0, 0, i2, i3);
						graphics1.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
					}
					intPtr1 = x61467fe65a98f20c.GetWindowDC (base.Handle);
					using (Graphics graphics2 = Graphics.FromHdc (intPtr1))
					{
						rectangle1 = new Rectangle (0, 0, i2, i3);
						rectangle2 = rectangle1;
						graphics2.DrawImage (((Image) bitmap2), rectangle2, rectangle1, GraphicsUnit.Pixel);
					}
					int i4 = x61467fe65a98f20c.ReleaseDC (base.Handle, intPtr1);
				}
			}
			
		#endregion
	}
	
}

