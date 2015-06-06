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
			using System.Drawing.Imaging;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class xc3d08931d227ebfe : x8917d01b98173f4c
	
	{
		
		#region Constructors
		
			public xc3d08931d227ebfe (Control control, ISkinEngine engine)
				 : base (control, engine)
			/*
				// Code Size: 68 Bytes
				.maxstack 4
				.locals (System.UInt32 V_0)
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.x8917d01b98173f4c::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ldarg.0 
				L_0009: call Sunisoft.IrisSkin.xc3d08931d227ebfe::Boolean get_x0e7ffd184973f9bc()
				L_000e: brfalse.s L_0043
				L_0010: ldarg.0 
				L_0011: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0016: ldc.i4.s -20
				L_0018: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
				L_001d: stloc.0 
				L_001e: ldloc.0 
				L_001f: ldc.i4 4194304
				L_0024: and 
				L_0025: ldc.i4 4194304
				L_002a: bne.un.s L_0034
				L_002c: ldloc.0 
				L_002d: ldc.i4 4194304
				L_0032: sub 
				L_0033: stloc.0 
				L_0034: ldarg.0 
				L_0035: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_003a: ldc.i4.s -20
				L_003c: ldloc.0 
				L_003d: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 SetWindowLong(IntPtr, Int32, UInt32)
				L_0042: pop 
				L_0043: ret 
			*/
		#endregion
		
		#region Properties
		
			private bool x0e7ffd184973f9bc
			
			{
				get
				
				/*
					// Code Size: 2 Bytes
					.maxstack 9
					L_0000: ldc.i4.0 
					L_0001: ret 
				*/
				
				{
					return false;
				}
			}
			
		#endregion
		
		#region Methods
		
			protected override bool BeforeWndProc (ref Message m)
			
			/*
				// Code Size: 101 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT V_0, 
         System.UInt32 V_1)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0006: stloc.1 
				L_0007: ldloc.1 
				L_0008: ldc.i4.s 15
				L_000a: beq.s L_001c
				L_000c: ldloc.1 
				L_000d: ldc.i4 1026
				L_0012: bne.un.s L_005d
				L_0014: ldarg.0 
				L_0015: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_001a: br.s L_005d
				L_001c: ldloca.s V_0
				L_001e: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT
				L_0024: ldarg.0 
				L_0025: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_002a: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_002f: ldloca.s V_0
				L_0031: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr BeginPaint(IntPtr, PAINTSTRUCT ByRef)
				L_0036: pop 
				L_0037: ldarg.0 
				L_0038: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_003d: ldarg.0 
				L_003e: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0043: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0048: ldloca.s V_0
				L_004a: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean EndPaint(IntPtr, PAINTSTRUCT ByRef)
				L_004f: pop 
				L_0050: ldarg.1 
				L_0051: ldsfld System.IntPtr::IntPtr Zero
				L_0056: call System.Windows.Forms.Message::Void set_Result(IntPtr)
				L_005b: ldc.i4.0 
				L_005c: ret 
				L_005d: ldarg.0 
				L_005e: ldarg.1 
				L_005f: call Sunisoft.IrisSkin.x8917d01b98173f4c::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_0064: ret 
			*/
			
			
			{
				uint uInt32_1 = ((uint) m.Msg);
				if (uInt32_1 != 15)
				{
					if (uInt32_1 == 1026)
					{
						this.PaintControl ();
					}
					return base.BeforeWndProc (ref m);
				}
				x40255b11ef821fa3.PAINTSTRUCT pAINTSTRUCT1 = new x40255b11ef821fa3.PAINTSTRUCT ();
				IntPtr intPtr1 = x61467fe65a98f20c.BeginPaint (base.xcd9cdf30888d2204.Handle, out pAINTSTRUCT1);
				this.PaintControl ();
				bool b1 = x61467fe65a98f20c.EndPaint (base.xcd9cdf30888d2204.Handle, ref pAINTSTRUCT1);
				m.Result = IntPtr.Zero;
				return false;
			}
			
			protected override void OnCurrentSkinChanged (object sender, ISkinChangedEventArgs e)
			
			/*
				// Code Size: 122 Bytes
				.maxstack 4
				.locals (System.UInt32 V_0, 
         System.UInt32 V_1)
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Void OnCurrentSkinChanged(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_0008: ldarg.0 
				L_0009: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_000e: brtrue.s L_003e
				L_0010: ldarg.0 
				L_0011: call Sunisoft.IrisSkin.xc3d08931d227ebfe::Boolean get_x0e7ffd184973f9bc()
				L_0016: brfalse.s L_0079
				L_0018: ldarg.0 
				L_0019: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_001e: ldc.i4.s -20
				L_0020: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
				L_0025: stloc.0 
				L_0026: ldloc.0 
				L_0027: ldc.i4 4194304
				L_002c: and 
				L_002d: stloc.0 
				L_002e: ldarg.0 
				L_002f: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0034: ldc.i4.s -20
				L_0036: ldloc.0 
				L_0037: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 SetWindowLong(IntPtr, Int32, UInt32)
				L_003c: pop 
				L_003d: ret 
				L_003e: ldarg.0 
				L_003f: call Sunisoft.IrisSkin.xc3d08931d227ebfe::Boolean get_x0e7ffd184973f9bc()
				L_0044: brfalse.s L_0079
				L_0046: ldarg.0 
				L_0047: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_004c: ldc.i4.s -20
				L_004e: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
				L_0053: stloc.1 
				L_0054: ldloc.1 
				L_0055: ldc.i4 4194304
				L_005a: and 
				L_005b: ldc.i4 4194304
				L_0060: bne.un.s L_006a
				L_0062: ldloc.1 
				L_0063: ldc.i4 4194304
				L_0068: sub 
				L_0069: stloc.1 
				L_006a: ldarg.0 
				L_006b: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0070: ldc.i4.s -20
				L_0072: ldloc.1 
				L_0073: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 SetWindowLong(IntPtr, Int32, UInt32)
				L_0078: pop 
				L_0079: ret 
			*/
			
			
			{
				uint uInt32_1;
				base.OnCurrentSkinChanged (sender, e);
				if (! base.xf2140268ef7ddbf7)
				{
					if (this.x0e7ffd184973f9bc)
					{
						uInt32_1 = x61467fe65a98f20c.GetWindowLong (base.Handle, -20);
						uInt32_1 = ((uint) (((int) uInt32_1) & 4194304));
						uint uInt32_3 = x61467fe65a98f20c.SetWindowLong (base.Handle, -20, uInt32_1);
					}
					return;
				}
				if (! this.x0e7ffd184973f9bc)
				{
					return;
				}
				uint uInt32_2 = x61467fe65a98f20c.GetWindowLong (base.Handle, -20);
				if ((((int) uInt32_2) & 4194304) == 4194304)
				{
					uInt32_2 = ((uint) (((int) uInt32_2) - 4194304));
				}
				uint uInt32_4 = x61467fe65a98f20c.SetWindowLong (base.Handle, -20, uInt32_2);
			}
			
			protected override void PaintControl ()
			
			/*
				// Code Size: 192 Bytes
				.maxstack 5
				.locals (System.Drawing.Bitmap V_0, 
         System.Drawing.Graphics V_1, 
         System.Drawing.Graphics V_2, 
         System.Drawing.Rectangle V_3)
				.try L_0065 to L_006e finally L_006e to L_0078
				.try L_0084 to L_00a9 finally L_00a9 to L_00b3
				.try L_005e to L_00b5 finally L_00b5 to L_00bf
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_000b: stloc.3 
				L_000c: ldloca.s V_3
				L_000e: call System.Drawing.Rectangle::Int32 get_Width()
				L_0013: ldc.i4.0 
				L_0014: ble.s L_002c
				L_0016: ldarg.0 
				L_0017: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001c: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0021: stloc.3 
				L_0022: ldloca.s V_3
				L_0024: call System.Drawing.Rectangle::Int32 get_Height()
				L_0029: ldc.i4.0 
				L_002a: bgt.s L_002d
				L_002c: ret 
				L_002d: ldarg.0 
				L_002e: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0033: brtrue.s L_0036
				L_0035: ret 
				L_0036: ldarg.0 
				L_0037: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_003c: castclass System.Windows.Forms.ProgressBar
				L_0041: pop 
				L_0042: ldarg.0 
				L_0043: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0048: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_004d: ldarg.0 
				L_004e: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0053: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0058: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_005d: stloc.0 
				L_005e: ldloc.0 
				L_005f: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0064: stloc.1 
				L_0065: ldarg.0 
				L_0066: ldloc.1 
				L_0067: call Sunisoft.IrisSkin.xc3d08931d227ebfe::Void x8bc95f030953f87b(System.Drawing.Graphics)
				L_006c: leave.s L_0078
				L_006e: ldloc.1 
				L_006f: brfalse.s L_0077
				L_0071: ldloc.1 
				L_0072: callvirt System.IDisposable::Void Dispose()
				L_0077: endfinally 
				L_0078: ldarg.0 
				L_0079: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_007e: call System.Drawing.Graphics::System.Drawing.Graphics FromHwnd(IntPtr)
				L_0083: stloc.2 
				L_0084: ldarg.0 
				L_0085: call Sunisoft.IrisSkin.xc3d08931d227ebfe::Boolean get_x0e7ffd184973f9bc()
				L_008a: brfalse.s L_009e
				L_008c: ldloc.0 
				L_008d: ldc.i4.4 
				L_008e: callvirt System.Drawing.Image::Void RotateFlip(System.Drawing.RotateFlipType)
				L_0093: ldloc.2 
				L_0094: ldloc.0 
				L_0095: ldc.i4.0 
				L_0096: ldc.i4.0 
				L_0097: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_009c: br.s L_00a7
				L_009e: ldloc.2 
				L_009f: ldloc.0 
				L_00a0: ldc.i4.0 
				L_00a1: ldc.i4.0 
				L_00a2: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_00a7: leave.s L_00b3
				L_00a9: ldloc.2 
				L_00aa: brfalse.s L_00b2
				L_00ac: ldloc.2 
				L_00ad: callvirt System.IDisposable::Void Dispose()
				L_00b2: endfinally 
				L_00b3: leave.s L_00bf
				L_00b5: ldloc.0 
				L_00b6: brfalse.s L_00be
				L_00b8: ldloc.0 
				L_00b9: callvirt System.IDisposable::Void Dispose()
				L_00be: endfinally 
				L_00bf: ret 
			*/
			
			
			{
				if (((base.xcd9cdf30888d2204.ClientRectangle.Width > 0) && (base.xcd9cdf30888d2204.ClientRectangle.Height > 0)) && base.xf2140268ef7ddbf7)
				{
					using (Bitmap bitmap1 = new Bitmap (base.xcd9cdf30888d2204.Width, base.xcd9cdf30888d2204.Height))
					{
						using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap1)))
						{
							this.x8bc95f030953f87b (graphics1);
						}
						using (Graphics graphics2 = Graphics.FromHwnd (base.Handle))
						{
							if (this.x0e7ffd184973f9bc)
							{
								bitmap1.RotateFlip (RotateFlipType.RotateNoneFlipX);
								graphics2.DrawImageUnscaled (((Image) bitmap1), 0, 0);
							}
							else
							{
								graphics2.DrawImageUnscaled (((Image) bitmap1), 0, 0);
							}
						}
					}
				}
			}
			
			private void x8bc95f030953f87b (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 1181 Bytes
				.maxstack 10
				.locals (System.Windows.Forms.ProgressBar V_0, 
         System.Drawing.Rectangle V_1, 
         System.Drawing.Bitmap V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Drawing.Rectangle V_5, 
         System.Drawing.Rectangle V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         System.Int32 V_9)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.ProgressBar
				L_000b: stloc.0 
				L_000c: ldloc.0 
				L_000d: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0012: stloc.1 
				L_0013: ldloc.0 
				L_0014: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0019: stloc.3 
				L_001a: ldloc.0 
				L_001b: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0020: stloc.s V_4
				L_0022: ldc.i4.2 
				L_0023: stloc.s V_9
				L_0025: ldarg.0 
				L_0026: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_002b: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0030: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0035: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_PROGRESSBAR1()
				L_003a: stloc.2 
				L_003b: ldloc.2 
				L_003c: callvirt System.Drawing.Image::Int32 get_Width()
				L_0041: stloc.s V_7
				L_0043: ldloca.s V_5
				L_0045: ldc.i4.0 
				L_0046: ldc.i4.0 
				L_0047: ldloc.2 
				L_0048: callvirt System.Drawing.Image::Int32 get_Width()
				L_004d: ldloc.s V_9
				L_004f: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0054: ldloc.s V_5
				L_0056: stloc.s V_6
				L_0058: ldarg.1 
				L_0059: ldloc.2 
				L_005a: ldloc.s V_6
				L_005c: ldloc.s V_5
				L_005e: ldc.i4.2 
				L_005f: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0064: ldloca.s V_5
				L_0066: ldc.i4.0 
				L_0067: ldloc.2 
				L_0068: callvirt System.Drawing.Image::Int32 get_Height()
				L_006d: ldloc.s V_9
				L_006f: sub 
				L_0070: ldloc.2 
				L_0071: callvirt System.Drawing.Image::Int32 get_Width()
				L_0076: ldloc.s V_9
				L_0078: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_007d: ldloca.s V_6
				L_007f: ldc.i4.0 
				L_0080: ldloc.s V_4
				L_0082: ldloc.s V_9
				L_0084: sub 
				L_0085: ldloc.2 
				L_0086: callvirt System.Drawing.Image::Int32 get_Width()
				L_008b: ldloc.s V_9
				L_008d: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0092: ldarg.1 
				L_0093: ldloc.2 
				L_0094: ldloc.s V_6
				L_0096: ldloc.s V_5
				L_0098: ldc.i4.2 
				L_0099: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_009e: ldc.i4.0 
				L_009f: ldloc.s V_9
				L_00a1: ldloc.2 
				L_00a2: callvirt System.Drawing.Image::Int32 get_Width()
				L_00a7: ldloc.2 
				L_00a8: callvirt System.Drawing.Image::Int32 get_Height()
				L_00ad: ldloc.s V_9
				L_00af: sub 
				L_00b0: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_00b5: stloc.s V_5
				L_00b7: ldloca.s V_6
				L_00b9: ldc.i4.0 
				L_00ba: ldloc.s V_9
				L_00bc: ldloc.2 
				L_00bd: callvirt System.Drawing.Image::Int32 get_Width()
				L_00c2: ldloc.s V_4
				L_00c4: ldloc.s V_9
				L_00c6: sub 
				L_00c7: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00cc: ldarg.1 
				L_00cd: ldloc.2 
				L_00ce: ldloc.s V_6
				L_00d0: ldloc.s V_5
				L_00d2: ldc.i4.2 
				L_00d3: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_00d8: ldarg.0 
				L_00d9: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00de: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00e3: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_00e8: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_PROGRESSBAR4()
				L_00ed: stloc.2 
				L_00ee: ldloc.3 
				L_00ef: ldloc.2 
				L_00f0: callvirt System.Drawing.Image::Int32 get_Width()
				L_00f5: sub 
				L_00f6: stloc.s V_8
				L_00f8: ldloca.s V_5
				L_00fa: ldc.i4.0 
				L_00fb: ldc.i4.0 
				L_00fc: ldloc.2 
				L_00fd: callvirt System.Drawing.Image::Int32 get_Width()
				L_0102: ldloc.s V_9
				L_0104: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0109: ldloca.s V_6
				L_010b: ldloc.3 
				L_010c: ldloc.2 
				L_010d: callvirt System.Drawing.Image::Int32 get_Width()
				L_0112: sub 
				L_0113: ldc.i4.0 
				L_0114: ldloc.2 
				L_0115: callvirt System.Drawing.Image::Int32 get_Width()
				L_011a: ldloc.s V_9
				L_011c: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0121: ldarg.1 
				L_0122: ldloc.2 
				L_0123: ldloc.s V_6
				L_0125: ldloc.s V_5
				L_0127: ldc.i4.2 
				L_0128: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_012d: ldloca.s V_5
				L_012f: ldc.i4.0 
				L_0130: ldloc.2 
				L_0131: callvirt System.Drawing.Image::Int32 get_Height()
				L_0136: ldloc.s V_9
				L_0138: sub 
				L_0139: ldloc.2 
				L_013a: callvirt System.Drawing.Image::Int32 get_Width()
				L_013f: ldloc.s V_9
				L_0141: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0146: ldloca.s V_6
				L_0148: ldloc.3 
				L_0149: ldloc.2 
				L_014a: callvirt System.Drawing.Image::Int32 get_Width()
				L_014f: sub 
				L_0150: ldloc.s V_4
				L_0152: ldloc.s V_9
				L_0154: sub 
				L_0155: ldloc.2 
				L_0156: callvirt System.Drawing.Image::Int32 get_Width()
				L_015b: ldloc.s V_9
				L_015d: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0162: ldarg.1 
				L_0163: ldloc.2 
				L_0164: ldloc.s V_6
				L_0166: ldloc.s V_5
				L_0168: ldc.i4.2 
				L_0169: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_016e: ldc.i4.0 
				L_016f: ldloc.s V_9
				L_0171: ldloc.2 
				L_0172: callvirt System.Drawing.Image::Int32 get_Width()
				L_0177: ldloc.2 
				L_0178: callvirt System.Drawing.Image::Int32 get_Height()
				L_017d: ldloc.s V_9
				L_017f: sub 
				L_0180: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0185: stloc.s V_5
				L_0187: ldloca.s V_6
				L_0189: ldloc.3 
				L_018a: ldloc.2 
				L_018b: callvirt System.Drawing.Image::Int32 get_Width()
				L_0190: sub 
				L_0191: ldloc.s V_9
				L_0193: ldloc.2 
				L_0194: callvirt System.Drawing.Image::Int32 get_Width()
				L_0199: ldloc.s V_4
				L_019b: ldloc.s V_9
				L_019d: sub 
				L_019e: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01a3: ldarg.1 
				L_01a4: ldloc.2 
				L_01a5: ldloc.s V_6
				L_01a7: ldloc.s V_5
				L_01a9: ldc.i4.2 
				L_01aa: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_01af: ldloc.0 
				L_01b0: callvirt System.Windows.Forms.ProgressBar::Int32 get_Maximum()
				L_01b5: ldloc.0 
				L_01b6: callvirt System.Windows.Forms.ProgressBar::Int32 get_Minimum()
				L_01bb: beq L_049c
				L_01c0: ldloca.s V_1
				L_01c2: ldloc.s V_7
				L_01c4: ldc.i4.0 
				L_01c5: ldloc.0 
				L_01c6: callvirt System.Windows.Forms.ProgressBar::Int32 get_Value()
				L_01cb: ldloc.0 
				L_01cc: callvirt System.Windows.Forms.ProgressBar::Int32 get_Minimum()
				L_01d1: sub 
				L_01d2: ldloc.s V_8
				L_01d4: ldloc.s V_7
				L_01d6: sub 
				L_01d7: mul 
				L_01d8: ldloc.0 
				L_01d9: callvirt System.Windows.Forms.ProgressBar::Int32 get_Maximum()
				L_01de: ldloc.0 
				L_01df: callvirt System.Windows.Forms.ProgressBar::Int32 get_Minimum()
				L_01e4: sub 
				L_01e5: div 
				L_01e6: ldloc.0 
				L_01e7: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_01ec: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01f1: ldarg.0 
				L_01f2: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01f7: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_01fc: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0201: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_PROGRESSBAR2()
				L_0206: stloc.2 
				L_0207: ldloca.s V_5
				L_0209: ldc.i4.0 
				L_020a: ldc.i4.0 
				L_020b: ldloc.2 
				L_020c: callvirt System.Drawing.Image::Int32 get_Width()
				L_0211: ldloc.s V_9
				L_0213: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0218: ldloca.s V_1
				L_021a: call System.Drawing.Rectangle::Int32 get_Left()
				L_021f: ldloca.s V_1
				L_0221: call System.Drawing.Rectangle::Int32 get_Top()
				L_0226: ldloca.s V_1
				L_0228: call System.Drawing.Rectangle::Int32 get_Right()
				L_022d: ldloc.s V_9
				L_022f: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0234: stloc.s V_6
				L_0236: ldarg.1 
				L_0237: ldloc.2 
				L_0238: ldloc.s V_6
				L_023a: ldloca.s V_5
				L_023c: call System.Drawing.Rectangle::Int32 get_X()
				L_0241: ldloca.s V_5
				L_0243: call System.Drawing.Rectangle::Int32 get_Y()
				L_0248: ldloca.s V_5
				L_024a: call System.Drawing.Rectangle::Int32 get_Width()
				L_024f: ldloca.s V_5
				L_0251: call System.Drawing.Rectangle::Int32 get_Height()
				L_0256: ldc.i4.2 
				L_0257: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x8da407ebcbbfe204()
				L_025c: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_0261: ldloca.s V_5
				L_0263: ldc.i4.0 
				L_0264: ldloc.2 
				L_0265: callvirt System.Drawing.Image::Int32 get_Height()
				L_026a: ldloc.s V_9
				L_026c: sub 
				L_026d: ldloc.2 
				L_026e: callvirt System.Drawing.Image::Int32 get_Width()
				L_0273: ldloc.s V_9
				L_0275: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_027a: ldloca.s V_1
				L_027c: call System.Drawing.Rectangle::Int32 get_Left()
				L_0281: ldloca.s V_1
				L_0283: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0288: ldloc.s V_9
				L_028a: sub 
				L_028b: ldloca.s V_1
				L_028d: call System.Drawing.Rectangle::Int32 get_Right()
				L_0292: ldloca.s V_1
				L_0294: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0299: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_029e: stloc.s V_6
				L_02a0: ldarg.1 
				L_02a1: ldloc.2 
				L_02a2: ldloc.s V_6
				L_02a4: ldloca.s V_5
				L_02a6: call System.Drawing.Rectangle::Int32 get_X()
				L_02ab: ldloca.s V_5
				L_02ad: call System.Drawing.Rectangle::Int32 get_Y()
				L_02b2: ldloca.s V_5
				L_02b4: call System.Drawing.Rectangle::Int32 get_Width()
				L_02b9: ldloca.s V_5
				L_02bb: call System.Drawing.Rectangle::Int32 get_Height()
				L_02c0: ldc.i4.2 
				L_02c1: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x8da407ebcbbfe204()
				L_02c6: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_02cb: ldc.i4.0 
				L_02cc: ldloc.s V_9
				L_02ce: ldloc.2 
				L_02cf: callvirt System.Drawing.Image::Int32 get_Width()
				L_02d4: ldloc.2 
				L_02d5: callvirt System.Drawing.Image::Int32 get_Height()
				L_02da: ldloc.s V_9
				L_02dc: sub 
				L_02dd: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_02e2: stloc.s V_5
				L_02e4: ldloca.s V_1
				L_02e6: call System.Drawing.Rectangle::Int32 get_Left()
				L_02eb: ldloca.s V_1
				L_02ed: call System.Drawing.Rectangle::Int32 get_Top()
				L_02f2: ldloc.s V_9
				L_02f4: add 
				L_02f5: ldloca.s V_1
				L_02f7: call System.Drawing.Rectangle::Int32 get_Right()
				L_02fc: ldloca.s V_1
				L_02fe: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0303: ldloc.s V_9
				L_0305: sub 
				L_0306: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_030b: stloc.s V_6
				L_030d: ldarg.1 
				L_030e: ldloc.2 
				L_030f: ldloc.s V_6
				L_0311: ldloca.s V_5
				L_0313: call System.Drawing.Rectangle::Int32 get_X()
				L_0318: ldloca.s V_5
				L_031a: call System.Drawing.Rectangle::Int32 get_Y()
				L_031f: ldloca.s V_5
				L_0321: call System.Drawing.Rectangle::Int32 get_Width()
				L_0326: ldloca.s V_5
				L_0328: call System.Drawing.Rectangle::Int32 get_Height()
				L_032d: ldc.i4.2 
				L_032e: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x8da407ebcbbfe204()
				L_0333: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_0338: ldloca.s V_1
				L_033a: call System.Drawing.Rectangle::Int32 get_Right()
				L_033f: ldloca.s V_1
				L_0341: call System.Drawing.Rectangle::Int32 get_Top()
				L_0346: ldloc.s V_8
				L_0348: ldloca.s V_1
				L_034a: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_034f: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0354: stloc.1 
				L_0355: ldarg.0 
				L_0356: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_035b: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0360: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0365: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_PROGRESSBAR3()
				L_036a: stloc.2 
				L_036b: ldloca.s V_5
				L_036d: ldc.i4.0 
				L_036e: ldc.i4.0 
				L_036f: ldloc.2 
				L_0370: callvirt System.Drawing.Image::Int32 get_Width()
				L_0375: ldloc.s V_9
				L_0377: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_037c: ldloca.s V_1
				L_037e: call System.Drawing.Rectangle::Int32 get_Left()
				L_0383: ldloca.s V_1
				L_0385: call System.Drawing.Rectangle::Int32 get_Top()
				L_038a: ldloca.s V_1
				L_038c: call System.Drawing.Rectangle::Int32 get_Right()
				L_0391: ldloc.s V_9
				L_0393: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0398: stloc.s V_6
				L_039a: ldarg.1 
				L_039b: ldloc.2 
				L_039c: ldloc.s V_6
				L_039e: ldloca.s V_5
				L_03a0: call System.Drawing.Rectangle::Int32 get_X()
				L_03a5: ldloca.s V_5
				L_03a7: call System.Drawing.Rectangle::Int32 get_Y()
				L_03ac: ldloca.s V_5
				L_03ae: call System.Drawing.Rectangle::Int32 get_Width()
				L_03b3: ldloca.s V_5
				L_03b5: call System.Drawing.Rectangle::Int32 get_Height()
				L_03ba: ldc.i4.2 
				L_03bb: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x8da407ebcbbfe204()
				L_03c0: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_03c5: ldloca.s V_5
				L_03c7: ldc.i4.0 
				L_03c8: ldloc.2 
				L_03c9: callvirt System.Drawing.Image::Int32 get_Height()
				L_03ce: ldloc.s V_9
				L_03d0: sub 
				L_03d1: ldloc.2 
				L_03d2: callvirt System.Drawing.Image::Int32 get_Width()
				L_03d7: ldloc.s V_9
				L_03d9: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_03de: ldloca.s V_1
				L_03e0: call System.Drawing.Rectangle::Int32 get_Left()
				L_03e5: ldloca.s V_1
				L_03e7: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_03ec: ldloc.s V_9
				L_03ee: sub 
				L_03ef: ldloca.s V_1
				L_03f1: call System.Drawing.Rectangle::Int32 get_Right()
				L_03f6: ldloca.s V_1
				L_03f8: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_03fd: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0402: stloc.s V_6
				L_0404: ldarg.1 
				L_0405: ldloc.2 
				L_0406: ldloc.s V_6
				L_0408: ldloca.s V_5
				L_040a: call System.Drawing.Rectangle::Int32 get_X()
				L_040f: ldloca.s V_5
				L_0411: call System.Drawing.Rectangle::Int32 get_Y()
				L_0416: ldloca.s V_5
				L_0418: call System.Drawing.Rectangle::Int32 get_Width()
				L_041d: ldloca.s V_5
				L_041f: call System.Drawing.Rectangle::Int32 get_Height()
				L_0424: ldc.i4.2 
				L_0425: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x8da407ebcbbfe204()
				L_042a: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_042f: ldc.i4.0 
				L_0430: ldloc.s V_9
				L_0432: ldloc.2 
				L_0433: callvirt System.Drawing.Image::Int32 get_Width()
				L_0438: ldloc.2 
				L_0439: callvirt System.Drawing.Image::Int32 get_Height()
				L_043e: ldloc.s V_9
				L_0440: sub 
				L_0441: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0446: stloc.s V_5
				L_0448: ldloca.s V_1
				L_044a: call System.Drawing.Rectangle::Int32 get_Left()
				L_044f: ldloca.s V_1
				L_0451: call System.Drawing.Rectangle::Int32 get_Top()
				L_0456: ldloc.s V_9
				L_0458: add 
				L_0459: ldloca.s V_1
				L_045b: call System.Drawing.Rectangle::Int32 get_Right()
				L_0460: ldloca.s V_1
				L_0462: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0467: ldloc.s V_9
				L_0469: sub 
				L_046a: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_046f: stloc.s V_6
				L_0471: ldarg.1 
				L_0472: ldloc.2 
				L_0473: ldloc.s V_6
				L_0475: ldloca.s V_5
				L_0477: call System.Drawing.Rectangle::Int32 get_X()
				L_047c: ldloca.s V_5
				L_047e: call System.Drawing.Rectangle::Int32 get_Y()
				L_0483: ldloca.s V_5
				L_0485: call System.Drawing.Rectangle::Int32 get_Width()
				L_048a: ldloca.s V_5
				L_048c: call System.Drawing.Rectangle::Int32 get_Height()
				L_0491: ldc.i4.2 
				L_0492: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x8da407ebcbbfe204()
				L_0497: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_049c: ret 
			*/
			
			
			{
				Rectangle rectangle2;
				ProgressBar progressBar1 = ((ProgressBar) base.xcd9cdf30888d2204);
				Rectangle rectangle1 = progressBar1.ClientRectangle;
				int i1 = progressBar1.Width;
				int i2 = progressBar1.Height;
				int i5 = 2;
				Bitmap bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_PROGRESSBAR1;
				int i3 = bitmap1.Width;
				rectangle2 = new Rectangle (0, 0, bitmap1.Width, i5);
				Rectangle rectangle3 = rectangle2;
				x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle3, rectangle2, GraphicsUnit.Pixel);
				rectangle2 = new Rectangle (0, ((int) (bitmap1.Height - i5)), bitmap1.Width, i5);
				rectangle3 = new Rectangle (0, ((int) (i2 - i5)), bitmap1.Width, i5);
				x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle3, rectangle2, GraphicsUnit.Pixel);
				rectangle2 = Rectangle.FromLTRB (0, i5, bitmap1.Width, ((int) (bitmap1.Height - i5)));
				rectangle3 = new Rectangle (0, i5, bitmap1.Width, ((int) (i2 - i5)));
				x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle3, rectangle2, GraphicsUnit.Pixel);
				bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_PROGRESSBAR4;
				int i4 = (i1 - bitmap1.Width);
				rectangle2 = new Rectangle (0, 0, bitmap1.Width, i5);
				rectangle3 = new Rectangle (((int) (i1 - bitmap1.Width)), 0, bitmap1.Width, i5);
				x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle3, rectangle2, GraphicsUnit.Pixel);
				rectangle2 = new Rectangle (0, ((int) (bitmap1.Height - i5)), bitmap1.Width, i5);
				rectangle3 = new Rectangle (((int) (i1 - bitmap1.Width)), ((int) (i2 - i5)), bitmap1.Width, i5);
				x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle3, rectangle2, GraphicsUnit.Pixel);
				rectangle2 = Rectangle.FromLTRB (0, i5, bitmap1.Width, ((int) (bitmap1.Height - i5)));
				rectangle3 = new Rectangle (((int) (i1 - bitmap1.Width)), i5, bitmap1.Width, ((int) (i2 - i5)));
				x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle3, rectangle2, GraphicsUnit.Pixel);
				if (progressBar1.Maximum != progressBar1.Minimum)
				{
					rectangle1 = new Rectangle (i3, 0, ((int) (((progressBar1.Value - progressBar1.Minimum) * (i4 - i3)) / (progressBar1.Maximum - progressBar1.Minimum))), progressBar1.Height);
					bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_PROGRESSBAR2;
					rectangle2 = new Rectangle (0, 0, bitmap1.Width, i5);
					rectangle3 = Rectangle.FromLTRB (rectangle1.Left, rectangle1.Top, rectangle1.Right, i5);
					x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle3, rectangle2.X, rectangle2.Y, rectangle2.Width, rectangle2.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x8da407ebcbbfe204);
					rectangle2 = new Rectangle (0, ((int) (bitmap1.Height - i5)), bitmap1.Width, i5);
					rectangle3 = Rectangle.FromLTRB (rectangle1.Left, ((int) (rectangle1.Bottom - i5)), rectangle1.Right, rectangle1.Bottom);
					x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle3, rectangle2.X, rectangle2.Y, rectangle2.Width, rectangle2.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x8da407ebcbbfe204);
					rectangle2 = Rectangle.FromLTRB (0, i5, bitmap1.Width, ((int) (bitmap1.Height - i5)));
					rectangle3 = Rectangle.FromLTRB (rectangle1.Left, ((int) (rectangle1.Top + i5)), rectangle1.Right, ((int) (rectangle1.Bottom - i5)));
					x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle3, rectangle2.X, rectangle2.Y, rectangle2.Width, rectangle2.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x8da407ebcbbfe204);
					rectangle1 = Rectangle.FromLTRB (rectangle1.Right, rectangle1.Top, i4, rectangle1.Bottom);
					bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_PROGRESSBAR3;
					rectangle2 = new Rectangle (0, 0, bitmap1.Width, i5);
					rectangle3 = Rectangle.FromLTRB (rectangle1.Left, rectangle1.Top, rectangle1.Right, i5);
					x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle3, rectangle2.X, rectangle2.Y, rectangle2.Width, rectangle2.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x8da407ebcbbfe204);
					rectangle2 = new Rectangle (0, ((int) (bitmap1.Height - i5)), bitmap1.Width, i5);
					rectangle3 = Rectangle.FromLTRB (rectangle1.Left, ((int) (rectangle1.Bottom - i5)), rectangle1.Right, rectangle1.Bottom);
					x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle3, rectangle2.X, rectangle2.Y, rectangle2.Width, rectangle2.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x8da407ebcbbfe204);
					rectangle2 = Rectangle.FromLTRB (0, i5, bitmap1.Width, ((int) (bitmap1.Height - i5)));
					rectangle3 = Rectangle.FromLTRB (rectangle1.Left, ((int) (rectangle1.Top + i5)), rectangle1.Right, ((int) (rectangle1.Bottom - i5)));
					x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle3, rectangle2.X, rectangle2.Y, rectangle2.Width, rectangle2.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x8da407ebcbbfe204);
				}
			}
			
		#endregion
	}
	
}

