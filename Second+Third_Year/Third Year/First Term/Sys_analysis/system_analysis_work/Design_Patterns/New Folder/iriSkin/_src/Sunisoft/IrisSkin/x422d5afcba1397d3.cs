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
		
	internal class x422d5afcba1397d3 : x8917d01b98173f4c
	
	{
		
		#region Constructors
		
			public x422d5afcba1397d3 (Control control, ISkinEngine engine)
				 : base (control, engine)
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.x8917d01b98173f4c::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ret 
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
				// Code Size: 142 Bytes
				.maxstack 4
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT V_0, 
         System.UInt32 V_1)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::IntPtr get_HWnd()
				L_0006: ldarg.0 
				L_0007: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_000c: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0011: call System.IntPtr::Boolean op_Inequality(IntPtr, IntPtr)
				L_0016: brfalse.s L_001a
				L_0018: ldc.i4.1 
				L_0019: ret 
				L_001a: ldarg.1 
				L_001b: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0020: stloc.1 
				L_0021: ldloc.1 
				L_0022: ldc.i4.8 
				L_0023: beq.s L_007e
				L_0025: ldloc.1 
				L_0026: ldc.i4.s 15
				L_0028: beq.s L_0043
				L_002a: ldloc.1 
				L_002b: ldc.i4.s 20
				L_002d: bne.un.s L_0086
				L_002f: ldarg.1 
				L_0030: ldc.i4.1 
				L_0031: newobj System.IntPtr::Void .ctor(Int32)
				L_0036: call System.Windows.Forms.Message::Void set_Result(IntPtr)
				L_003b: ldarg.0 
				L_003c: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0041: ldc.i4.0 
				L_0042: ret 
				L_0043: ldloca.s V_0
				L_0045: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT
				L_004b: ldarg.0 
				L_004c: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0051: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0056: ldloca.s V_0
				L_0058: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr BeginPaint(IntPtr, PAINTSTRUCT ByRef)
				L_005d: pop 
				L_005e: ldarg.0 
				L_005f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0064: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0069: ldloca.s V_0
				L_006b: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean EndPaint(IntPtr, PAINTSTRUCT ByRef)
				L_0070: pop 
				L_0071: ldarg.1 
				L_0072: ldsfld System.IntPtr::IntPtr Zero
				L_0077: call System.Windows.Forms.Message::Void set_Result(IntPtr)
				L_007c: ldc.i4.0 
				L_007d: ret 
				L_007e: ldarg.0 
				L_007f: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0084: ldc.i4.0 
				L_0085: ret 
				L_0086: ldarg.0 
				L_0087: ldarg.1 
				L_0088: call Sunisoft.IrisSkin.x8917d01b98173f4c::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_008d: ret 
			*/
			
			
			{
				if (m.HWnd != base.xcd9cdf30888d2204.Handle)
				{
					return true;
				}
				uint uInt32_1 = ((uint) m.Msg);
				if (uInt32_1 == 8)
				{
					this.PaintControl ();
					return false;
				}
				if (uInt32_1 != 15)
				{
					if (uInt32_1 != 20)
					{
						return base.BeforeWndProc (ref m);
					}
					else
					{
						m.Result = new IntPtr (1);
						this.PaintControl ();
						return false;
					}
				}
				x40255b11ef821fa3.PAINTSTRUCT pAINTSTRUCT1 = new x40255b11ef821fa3.PAINTSTRUCT ();
				IntPtr intPtr1 = x61467fe65a98f20c.BeginPaint (base.xcd9cdf30888d2204.Handle, out pAINTSTRUCT1);
				bool b1 = x61467fe65a98f20c.EndPaint (base.xcd9cdf30888d2204.Handle, ref pAINTSTRUCT1);
				m.Result = IntPtr.Zero;
				return false;
			}
			
			protected override void DoInit ()
			
			/*
				// Code Size: 37 Bytes
				.maxstack 5
				.locals (System.Windows.Forms.TrackBar V_0)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x8917d01b98173f4c::Void DoInit()
				L_0006: ldarg.0 
				L_0007: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_000c: castclass System.Windows.Forms.TrackBar
				L_0011: stloc.0 
				L_0012: ldloc.0 
				L_0013: ldarg.0 
				L_0014: ldftn Sunisoft.IrisSkin.x422d5afcba1397d3::Void xf51466e2b7549167(System.Object, System.EventArgs)
				L_001a: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_001f: callvirt System.Windows.Forms.TrackBar::Void add_ValueChanged(System.EventHandler)
				L_0024: ret 
			*/
			
			
			{
				base.DoInit ();
				TrackBar trackBar1 = ((TrackBar) base.xcd9cdf30888d2204);
				trackBar1.ValueChanged += new EventHandler (this.xf51466e2b7549167);
			}
			
			protected override void PaintControl ()
			
			/*
				// Code Size: 171 Bytes
				.maxstack 5
				.locals (System.Drawing.Bitmap V_0, 
         System.Drawing.Graphics V_1, 
         System.Drawing.Graphics V_2, 
         System.Drawing.Rectangle V_3)
				.try L_005b to L_0064 finally L_0064 to L_006e
				.try L_007a to L_0094 finally L_0094 to L_009e
				.try L_0054 to L_00a0 finally L_00a0 to L_00aa
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
				L_0033: brfalse L_00aa
				L_0038: ldarg.0 
				L_0039: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_003e: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0043: ldarg.0 
				L_0044: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0049: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_004e: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0053: stloc.0 
				L_0054: ldloc.0 
				L_0055: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_005a: stloc.1 
				L_005b: ldarg.0 
				L_005c: ldloc.1 
				L_005d: call Sunisoft.IrisSkin.x422d5afcba1397d3::Void x8bc95f030953f87b(System.Drawing.Graphics)
				L_0062: leave.s L_006e
				L_0064: ldloc.1 
				L_0065: brfalse.s L_006d
				L_0067: ldloc.1 
				L_0068: callvirt System.IDisposable::Void Dispose()
				L_006d: endfinally 
				L_006e: ldarg.0 
				L_006f: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0074: call System.Drawing.Graphics::System.Drawing.Graphics FromHwnd(IntPtr)
				L_0079: stloc.2 
				L_007a: ldarg.0 
				L_007b: call Sunisoft.IrisSkin.x422d5afcba1397d3::Boolean get_x0e7ffd184973f9bc()
				L_0080: brfalse.s L_0089
				L_0082: ldloc.0 
				L_0083: ldc.i4.4 
				L_0084: callvirt System.Drawing.Image::Void RotateFlip(System.Drawing.RotateFlipType)
				L_0089: ldloc.2 
				L_008a: ldloc.0 
				L_008b: ldc.i4.0 
				L_008c: ldc.i4.0 
				L_008d: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_0092: leave.s L_009e
				L_0094: ldloc.2 
				L_0095: brfalse.s L_009d
				L_0097: ldloc.2 
				L_0098: callvirt System.IDisposable::Void Dispose()
				L_009d: endfinally 
				L_009e: leave.s L_00aa
				L_00a0: ldloc.0 
				L_00a1: brfalse.s L_00a9
				L_00a3: ldloc.0 
				L_00a4: callvirt System.IDisposable::Void Dispose()
				L_00a9: endfinally 
				L_00aa: ret 
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
							}
							graphics2.DrawImageUnscaled (((Image) bitmap1), 0, 0);
						}
					}
				}
			}
			
			private void x86a0b6ee5f4b48be (Graphics x4b101060f4767186, Pen x90279591611601bc, float xc941868c59399d3e, float xaf9a0436a70689de, float x10aaa7cdfa38f254, float xca09b6c2b5b18485, float x0b5a48bb98ab819f)
			
			/*
				// Code Size: 50 Bytes
				.maxstack 9
				L_0000: br.s L_002b
				L_0002: ldarg.1 
				L_0003: ldarg.2 
				L_0004: ldarg.s x10aaa7cdfa38f254
				L_0006: ldarg.3 
				L_0007: ldarg.s x10aaa7cdfa38f254
				L_0009: ldarg.s xaf9a0436a70689de
				L_000b: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Single, Single, Single, Single)
				L_0010: ldarg.s x10aaa7cdfa38f254
				L_0012: ldarg.s x0b5a48bb98ab819f
				L_0014: add 
				L_0015: starg.s x10aaa7cdfa38f254
				L_0017: ldarg.s x10aaa7cdfa38f254
				L_0019: ldarg.s xca09b6c2b5b18485
				L_001b: blt.un.s L_002b
				L_001d: ldarg.1 
				L_001e: ldarg.2 
				L_001f: ldarg.s xca09b6c2b5b18485
				L_0021: ldarg.3 
				L_0022: ldarg.s xca09b6c2b5b18485
				L_0024: ldarg.s xaf9a0436a70689de
				L_0026: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Single, Single, Single, Single)
				L_002b: ldarg.s x10aaa7cdfa38f254
				L_002d: ldarg.s xca09b6c2b5b18485
				L_002f: blt.s L_0002
				L_0031: ret 
			*/
			
			
			{
				while (x10aaa7cdfa38f254 < xca09b6c2b5b18485)
				{
					x4b101060f4767186.DrawLine (x90279591611601bc, x10aaa7cdfa38f254, xc941868c59399d3e, x10aaa7cdfa38f254, xaf9a0436a70689de);
					x10aaa7cdfa38f254 += x0b5a48bb98ab819f;
					if (x10aaa7cdfa38f254 >= xca09b6c2b5b18485)
					{
						x4b101060f4767186.DrawLine (x90279591611601bc, xca09b6c2b5b18485, xc941868c59399d3e, xca09b6c2b5b18485, xaf9a0436a70689de);
					}
				}
			}
			
			private void x8bc95f030953f87b (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 1367 Bytes
				.maxstack 9
				.locals (System.Windows.Forms.TrackBar V_0, 
         System.Drawing.Rectangle V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Rectangle V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         System.Int32 V_9, 
         System.Int32 V_10, 
         System.Drawing.Bitmap V_11, 
         System.Drawing.Bitmap V_12, 
         System.Int32 V_13, 
         System.Drawing.Graphics V_14, 
         System.Drawing.Brush V_15, 
         System.Drawing.Pen V_16, 
         System.Single V_17, 
         System.Single V_18, 
         System.Single V_19, 
         System.Windows.Forms.TickStyle V_20, 
         System.Drawing.Rectangle V_21)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0006: brtrue.s L_0009
				L_0008: ret 
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_000f: castclass System.Windows.Forms.TrackBar
				L_0014: stloc.0 
				L_0015: ldc.i4.s 10
				L_0017: stloc.s V_4
				L_0019: ldc.i4.6 
				L_001a: stloc.s V_5
				L_001c: ldc.i4.7 
				L_001d: stloc.s V_6
				L_001f: ldc.i4.s 15
				L_0021: stloc.s V_7
				L_0023: ldloc.0 
				L_0024: callvirt System.Windows.Forms.TrackBar::Int32 get_Value()
				L_0029: stloc.s V_13
				L_002b: ldloc.0 
				L_002c: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_0031: ldc.i4.1 
				L_0032: and 
				L_0033: ldc.i4.1 
				L_0034: bne.un.s L_0045
				L_0036: ldloc.0 
				L_0037: callvirt System.Windows.Forms.TrackBar::Int32 get_Maximum()
				L_003c: ldloc.0 
				L_003d: callvirt System.Windows.Forms.TrackBar::Int32 get_Value()
				L_0042: sub 
				L_0043: stloc.s V_13
				L_0045: ldloc.0 
				L_0046: callvirt System.Windows.Forms.TrackBar::System.Windows.Forms.Orientation get_Orientation()
				L_004b: brtrue.s L_005f
				L_004d: ldloc.0 
				L_004e: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0053: stloc.s V_8
				L_0055: ldloc.0 
				L_0056: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_005b: stloc.s V_9
				L_005d: br.s L_006f
				L_005f: ldloc.0 
				L_0060: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0065: stloc.s V_8
				L_0067: ldloc.0 
				L_0068: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_006d: stloc.s V_9
				L_006f: ldloc.s V_8
				L_0071: ldloc.s V_9
				L_0073: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0078: stloc.s V_12
				L_007a: ldloca.s V_1
				L_007c: ldc.i4.0 
				L_007d: ldc.i4.0 
				L_007e: ldloc.s V_8
				L_0080: ldloc.s V_9
				L_0082: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0087: ldloc.s V_12
				L_0089: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_008e: stloc.s V_14
				L_0090: ldarg.0 
				L_0091: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0096: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_009b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_00a0: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_00a5: stloc.s V_15
				L_00a7: ldloc.s V_14
				L_00a9: ldloc.s V_15
				L_00ab: ldloc.1 
				L_00ac: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_00b1: ldarg.0 
				L_00b2: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00b7: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00bc: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_00c1: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TRACKBAR()
				L_00c6: stloc.s V_11
				L_00c8: ldloc.0 
				L_00c9: callvirt System.Windows.Forms.TrackBar::System.Windows.Forms.TickStyle get_TickStyle()
				L_00ce: stloc.s V_20
				L_00d0: ldloc.s V_20
				L_00d2: switch (L_00f2, L_0102, L_00fa, L_00e7)
				L_00e7: ldloc.s V_4
				L_00e9: ldloc.s V_7
				L_00eb: ldc.i4.2 
				L_00ec: div 
				L_00ed: add 
				L_00ee: stloc.s V_10
				L_00f0: br.s L_010b
				L_00f2: ldloc.s V_7
				L_00f4: ldc.i4.2 
				L_00f5: div 
				L_00f6: stloc.s V_10
				L_00f8: br.s L_010b
				L_00fa: ldloc.s V_7
				L_00fc: ldc.i4.2 
				L_00fd: div 
				L_00fe: stloc.s V_10
				L_0100: br.s L_010b
				L_0102: ldloc.s V_4
				L_0104: ldloc.s V_7
				L_0106: ldc.i4.2 
				L_0107: div 
				L_0108: add 
				L_0109: stloc.s V_10
				L_010b: ldloca.s V_1
				L_010d: ldloc.s V_5
				L_010f: ldloc.s V_10
				L_0111: ldloc.s V_8
				L_0113: ldc.i4.2 
				L_0114: ldloc.s V_5
				L_0116: mul 
				L_0117: sub 
				L_0118: ldloc.s V_11
				L_011a: callvirt System.Drawing.Image::Int32 get_Height()
				L_011f: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0124: ldloca.s V_3
				L_0126: ldloca.s V_1
				L_0128: call System.Drawing.Rectangle::Int32 get_Left()
				L_012d: ldloca.s V_1
				L_012f: call System.Drawing.Rectangle::Int32 get_Top()
				L_0134: ldloc.s V_11
				L_0136: callvirt System.Drawing.Image::Int32 get_Width()
				L_013b: ldc.i4.3 
				L_013c: div 
				L_013d: ldloc.s V_11
				L_013f: callvirt System.Drawing.Image::Int32 get_Height()
				L_0144: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0149: ldloca.s V_2
				L_014b: ldc.i4.0 
				L_014c: ldc.i4.0 
				L_014d: ldloc.s V_11
				L_014f: callvirt System.Drawing.Image::Int32 get_Width()
				L_0154: ldc.i4.3 
				L_0155: div 
				L_0156: ldloc.s V_11
				L_0158: callvirt System.Drawing.Image::Int32 get_Height()
				L_015d: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0162: ldloc.s V_14
				L_0164: ldloc.s V_11
				L_0166: ldloc.3 
				L_0167: ldloc.2 
				L_0168: ldc.i4.2 
				L_0169: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_016e: ldloca.s V_1
				L_0170: call System.Drawing.Rectangle::Int32 get_Right()
				L_0175: ldloc.s V_11
				L_0177: callvirt System.Drawing.Image::Int32 get_Width()
				L_017c: ldc.i4.3 
				L_017d: div 
				L_017e: sub 
				L_017f: ldloca.s V_1
				L_0181: call System.Drawing.Rectangle::Int32 get_Top()
				L_0186: ldloca.s V_1
				L_0188: call System.Drawing.Rectangle::Int32 get_Right()
				L_018d: ldloca.s V_1
				L_018f: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0194: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0199: stloc.3 
				L_019a: ldloca.s V_2
				L_019c: ldloc.s V_11
				L_019e: callvirt System.Drawing.Image::Int32 get_Width()
				L_01a3: ldloc.s V_11
				L_01a5: callvirt System.Drawing.Image::Int32 get_Width()
				L_01aa: ldc.i4.3 
				L_01ab: div 
				L_01ac: sub 
				L_01ad: ldc.i4.0 
				L_01ae: ldloc.s V_11
				L_01b0: callvirt System.Drawing.Image::Int32 get_Width()
				L_01b5: ldc.i4.3 
				L_01b6: div 
				L_01b7: ldloc.s V_11
				L_01b9: callvirt System.Drawing.Image::Int32 get_Height()
				L_01be: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01c3: ldloc.s V_14
				L_01c5: ldloc.s V_11
				L_01c7: ldloc.3 
				L_01c8: ldloc.2 
				L_01c9: ldc.i4.2 
				L_01ca: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_01cf: ldloca.s V_1
				L_01d1: call System.Drawing.Rectangle::Int32 get_Left()
				L_01d6: ldloc.s V_11
				L_01d8: callvirt System.Drawing.Image::Int32 get_Width()
				L_01dd: ldc.i4.3 
				L_01de: div 
				L_01df: add 
				L_01e0: ldloca.s V_1
				L_01e2: call System.Drawing.Rectangle::Int32 get_Top()
				L_01e7: ldloca.s V_1
				L_01e9: call System.Drawing.Rectangle::Int32 get_Right()
				L_01ee: ldloc.s V_11
				L_01f0: callvirt System.Drawing.Image::Int32 get_Width()
				L_01f5: ldc.i4.3 
				L_01f6: div 
				L_01f7: sub 
				L_01f8: ldloca.s V_1
				L_01fa: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_01ff: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0204: stloc.3 
				L_0205: ldloc.s V_11
				L_0207: callvirt System.Drawing.Image::Int32 get_Width()
				L_020c: ldc.i4.3 
				L_020d: div 
				L_020e: ldc.i4.0 
				L_020f: ldloc.s V_11
				L_0211: callvirt System.Drawing.Image::Int32 get_Width()
				L_0216: ldloc.s V_11
				L_0218: callvirt System.Drawing.Image::Int32 get_Width()
				L_021d: ldc.i4.3 
				L_021e: div 
				L_021f: sub 
				L_0220: ldloc.s V_11
				L_0222: callvirt System.Drawing.Image::Int32 get_Height()
				L_0227: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_022c: stloc.2 
				L_022d: ldloc.s V_14
				L_022f: ldloc.s V_11
				L_0231: ldloc.3 
				L_0232: ldloc.2 
				L_0233: ldc.i4.2 
				L_0234: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0239: ldloc.0 
				L_023a: callvirt System.Windows.Forms.TrackBar::System.Windows.Forms.TickStyle get_TickStyle()
				L_023f: stloc.s V_20
				L_0241: ldloc.s V_20
				L_0243: switch (L_0275, L_02ad, L_0291, L_0258)
				L_0258: ldarg.0 
				L_0259: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_025e: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0263: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0268: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TRACKBARSLIDER()
				L_026d: stloc.s V_11
				L_026f: ldloc.s V_4
				L_0271: stloc.s V_10
				L_0273: br.s L_02c8
				L_0275: ldarg.0 
				L_0276: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_027b: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0280: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0285: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TRACKBARSLIDER()
				L_028a: stloc.s V_11
				L_028c: ldc.i4.0 
				L_028d: stloc.s V_10
				L_028f: br.s L_02c8
				L_0291: ldarg.0 
				L_0292: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0297: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_029c: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_02a1: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TRACKBARSLIDER()
				L_02a6: stloc.s V_11
				L_02a8: ldc.i4.0 
				L_02a9: stloc.s V_10
				L_02ab: br.s L_02c8
				L_02ad: ldarg.0 
				L_02ae: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_02b3: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_02b8: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_02bd: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TRACKBARSLIDER_180()
				L_02c2: stloc.s V_11
				L_02c4: ldloc.s V_4
				L_02c6: stloc.s V_10
				L_02c8: ldloc.0 
				L_02c9: callvirt System.Windows.Forms.TrackBar::Int32 get_Maximum()
				L_02ce: ldloc.0 
				L_02cf: callvirt System.Windows.Forms.TrackBar::Int32 get_Minimum()
				L_02d4: beq L_04d0
				L_02d9: ldloca.s V_3
				L_02db: ldloc.s V_8
				L_02dd: ldc.i4.2 
				L_02de: ldloc.s V_5
				L_02e0: mul 
				L_02e1: sub 
				L_02e2: ldc.i4.2 
				L_02e3: ldloc.s V_6
				L_02e5: mul 
				L_02e6: sub 
				L_02e7: conv.r4 
				L_02e8: ldloc.s V_13
				L_02ea: ldloc.0 
				L_02eb: callvirt System.Windows.Forms.TrackBar::Int32 get_Minimum()
				L_02f0: sub 
				L_02f1: conv.r4 
				L_02f2: mul 
				L_02f3: ldloc.0 
				L_02f4: callvirt System.Windows.Forms.TrackBar::Int32 get_Maximum()
				L_02f9: ldloc.0 
				L_02fa: callvirt System.Windows.Forms.TrackBar::Int32 get_Minimum()
				L_02ff: sub 
				L_0300: conv.r4 
				L_0301: div 
				L_0302: conv.i4 
				L_0303: ldloc.s V_11
				L_0305: callvirt System.Drawing.Image::Int32 get_Width()
				L_030a: ldc.i4.2 
				L_030b: div 
				L_030c: sub 
				L_030d: ldloc.s V_5
				L_030f: add 
				L_0310: ldloc.s V_6
				L_0312: add 
				L_0313: ldloc.s V_10
				L_0315: ldloc.s V_11
				L_0317: callvirt System.Drawing.Image::Int32 get_Width()
				L_031c: ldloc.s V_11
				L_031e: callvirt System.Drawing.Image::Int32 get_Height()
				L_0323: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0328: ldloca.s V_2
				L_032a: ldc.i4.0 
				L_032b: ldc.i4.0 
				L_032c: ldloc.s V_11
				L_032e: callvirt System.Drawing.Image::Int32 get_Width()
				L_0333: ldloc.s V_11
				L_0335: callvirt System.Drawing.Image::Int32 get_Height()
				L_033a: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_033f: ldloc.s V_14
				L_0341: ldloc.s V_11
				L_0343: ldloc.3 
				L_0344: ldloc.2 
				L_0345: ldc.i4.2 
				L_0346: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_034b: call System.Drawing.Color::System.Drawing.Color get_Black()
				L_0350: ldc.r4 1
				L_0355: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color, Single)
				L_035a: stloc.s V_16
				L_035c: ldloc.s V_5
				L_035e: ldloc.s V_6
				L_0360: add 
				L_0361: conv.r4 
				L_0362: stloc.s V_17
				L_0364: ldloc.s V_8
				L_0366: ldloc.s V_5
				L_0368: sub 
				L_0369: ldloc.s V_6
				L_036b: sub 
				L_036c: conv.r4 
				L_036d: stloc.s V_18
				L_036f: ldloc.s V_18
				L_0371: ldloc.s V_17
				L_0373: sub 
				L_0374: ldloc.0 
				L_0375: callvirt System.Windows.Forms.TrackBar::Int32 get_TickFrequency()
				L_037a: conv.r4 
				L_037b: mul 
				L_037c: ldloc.0 
				L_037d: callvirt System.Windows.Forms.TrackBar::Int32 get_Maximum()
				L_0382: ldloc.0 
				L_0383: callvirt System.Windows.Forms.TrackBar::Int32 get_Minimum()
				L_0388: sub 
				L_0389: conv.r4 
				L_038a: div 
				L_038b: stloc.s V_19
				L_038d: ldloc.s V_19
				L_038f: ldc.r4 0
				L_0394: ble.un L_04c9
				L_0399: ldloc.0 
				L_039a: callvirt System.Windows.Forms.TrackBar::System.Windows.Forms.TickStyle get_TickStyle()
				L_039f: stloc.s V_20
				L_03a1: ldloc.s V_20
				L_03a3: switch (L_04c9, L_0488, L_0445, L_03b8)
				L_03b8: ldloc.s V_4
				L_03ba: ldc.i4.4 
				L_03bb: sub 
				L_03bc: stloc.s V_10
				L_03be: ldloc.0 
				L_03bf: callvirt System.Windows.Forms.TrackBar::System.Windows.Forms.Orientation get_Orientation()
				L_03c4: ldc.i4.1 
				L_03c5: bne.un.s L_03e1
				L_03c7: ldarg.0 
				L_03c8: ldloc.s V_14
				L_03ca: ldloc.s V_16
				L_03cc: ldloc.s V_10
				L_03ce: conv.r4 
				L_03cf: ldloc.s V_10
				L_03d1: ldc.i4.3 
				L_03d2: add 
				L_03d3: conv.r4 
				L_03d4: ldloc.s V_17
				L_03d6: ldloc.s V_18
				L_03d8: ldloc.s V_19
				L_03da: call Sunisoft.IrisSkin.x422d5afcba1397d3::Void xa5b17a677db5a5eb(System.Drawing.Graphics, System.Drawing.Pen, Single, Single, Single, Single, Single)
				L_03df: br.s L_03f9
				L_03e1: ldarg.0 
				L_03e2: ldloc.s V_14
				L_03e4: ldloc.s V_16
				L_03e6: ldloc.s V_10
				L_03e8: conv.r4 
				L_03e9: ldloc.s V_10
				L_03eb: ldc.i4.3 
				L_03ec: add 
				L_03ed: conv.r4 
				L_03ee: ldloc.s V_17
				L_03f0: ldloc.s V_18
				L_03f2: ldloc.s V_19
				L_03f4: call Sunisoft.IrisSkin.x422d5afcba1397d3::Void x86a0b6ee5f4b48be(System.Drawing.Graphics, System.Drawing.Pen, Single, Single, Single, Single, Single)
				L_03f9: ldloc.s V_4
				L_03fb: ldloc.s V_7
				L_03fd: add 
				L_03fe: ldc.i4.7 
				L_03ff: add 
				L_0400: stloc.s V_10
				L_0402: ldloc.0 
				L_0403: callvirt System.Windows.Forms.TrackBar::System.Windows.Forms.Orientation get_Orientation()
				L_0408: ldc.i4.1 
				L_0409: bne.un.s L_0428
				L_040b: ldarg.0 
				L_040c: ldloc.s V_14
				L_040e: ldloc.s V_16
				L_0410: ldloc.s V_10
				L_0412: conv.r4 
				L_0413: ldloc.s V_10
				L_0415: ldc.i4.3 
				L_0416: add 
				L_0417: conv.r4 
				L_0418: ldloc.s V_17
				L_041a: ldloc.s V_18
				L_041c: ldloc.s V_19
				L_041e: call Sunisoft.IrisSkin.x422d5afcba1397d3::Void xa5b17a677db5a5eb(System.Drawing.Graphics, System.Drawing.Pen, Single, Single, Single, Single, Single)
				L_0423: br L_04c9
				L_0428: ldarg.0 
				L_0429: ldloc.s V_14
				L_042b: ldloc.s V_16
				L_042d: ldloc.s V_10
				L_042f: conv.r4 
				L_0430: ldloc.s V_10
				L_0432: ldc.i4.3 
				L_0433: add 
				L_0434: conv.r4 
				L_0435: ldloc.s V_17
				L_0437: ldloc.s V_18
				L_0439: ldloc.s V_19
				L_043b: call Sunisoft.IrisSkin.x422d5afcba1397d3::Void x86a0b6ee5f4b48be(System.Drawing.Graphics, System.Drawing.Pen, Single, Single, Single, Single, Single)
				L_0440: br L_04c9
				L_0445: ldloc.s V_7
				L_0447: ldc.i4.7 
				L_0448: add 
				L_0449: stloc.s V_10
				L_044b: ldloc.0 
				L_044c: callvirt System.Windows.Forms.TrackBar::System.Windows.Forms.Orientation get_Orientation()
				L_0451: ldc.i4.1 
				L_0452: bne.un.s L_046e
				L_0454: ldarg.0 
				L_0455: ldloc.s V_14
				L_0457: ldloc.s V_16
				L_0459: ldloc.s V_10
				L_045b: conv.r4 
				L_045c: ldloc.s V_10
				L_045e: ldc.i4.3 
				L_045f: add 
				L_0460: conv.r4 
				L_0461: ldloc.s V_17
				L_0463: ldloc.s V_18
				L_0465: ldloc.s V_19
				L_0467: call Sunisoft.IrisSkin.x422d5afcba1397d3::Void xa5b17a677db5a5eb(System.Drawing.Graphics, System.Drawing.Pen, Single, Single, Single, Single, Single)
				L_046c: br.s L_04c9
				L_046e: ldarg.0 
				L_046f: ldloc.s V_14
				L_0471: ldloc.s V_16
				L_0473: ldloc.s V_10
				L_0475: conv.r4 
				L_0476: ldloc.s V_10
				L_0478: ldc.i4.3 
				L_0479: add 
				L_047a: conv.r4 
				L_047b: ldloc.s V_17
				L_047d: ldloc.s V_18
				L_047f: ldloc.s V_19
				L_0481: call Sunisoft.IrisSkin.x422d5afcba1397d3::Void x86a0b6ee5f4b48be(System.Drawing.Graphics, System.Drawing.Pen, Single, Single, Single, Single, Single)
				L_0486: br.s L_04c9
				L_0488: ldloc.s V_4
				L_048a: ldc.i4.4 
				L_048b: sub 
				L_048c: stloc.s V_10
				L_048e: ldloc.0 
				L_048f: callvirt System.Windows.Forms.TrackBar::System.Windows.Forms.Orientation get_Orientation()
				L_0494: ldc.i4.1 
				L_0495: bne.un.s L_04b1
				L_0497: ldarg.0 
				L_0498: ldloc.s V_14
				L_049a: ldloc.s V_16
				L_049c: ldloc.s V_10
				L_049e: conv.r4 
				L_049f: ldloc.s V_10
				L_04a1: ldc.i4.3 
				L_04a2: add 
				L_04a3: conv.r4 
				L_04a4: ldloc.s V_17
				L_04a6: ldloc.s V_18
				L_04a8: ldloc.s V_19
				L_04aa: call Sunisoft.IrisSkin.x422d5afcba1397d3::Void xa5b17a677db5a5eb(System.Drawing.Graphics, System.Drawing.Pen, Single, Single, Single, Single, Single)
				L_04af: br.s L_04c9
				L_04b1: ldarg.0 
				L_04b2: ldloc.s V_14
				L_04b4: ldloc.s V_16
				L_04b6: ldloc.s V_10
				L_04b8: conv.r4 
				L_04b9: ldloc.s V_10
				L_04bb: ldc.i4.3 
				L_04bc: add 
				L_04bd: conv.r4 
				L_04be: ldloc.s V_17
				L_04c0: ldloc.s V_18
				L_04c2: ldloc.s V_19
				L_04c4: call Sunisoft.IrisSkin.x422d5afcba1397d3::Void x86a0b6ee5f4b48be(System.Drawing.Graphics, System.Drawing.Pen, Single, Single, Single, Single, Single)
				L_04c9: ldloc.s V_16
				L_04cb: callvirt System.Drawing.Pen::Void Dispose()
				L_04d0: ldloc.0 
				L_04d1: callvirt System.Windows.Forms.Control::Boolean get_Focused()
				L_04d6: brfalse.s L_052d
				L_04d8: ldloc.0 
				L_04d9: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_04de: stloc.s V_21
				L_04e0: ldloca.s V_21
				L_04e2: call System.Drawing.Rectangle::Int32 get_X()
				L_04e7: ldc.i4.5 
				L_04e8: add 
				L_04e9: ldloc.0 
				L_04ea: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_04ef: stloc.s V_21
				L_04f1: ldloca.s V_21
				L_04f3: call System.Drawing.Rectangle::Int32 get_Y()
				L_04f8: ldloc.0 
				L_04f9: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_04fe: stloc.s V_21
				L_0500: ldloca.s V_21
				L_0502: call System.Drawing.Rectangle::Int32 get_Right()
				L_0507: ldc.i4.5 
				L_0508: sub 
				L_0509: ldloc.0 
				L_050a: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_050f: stloc.s V_21
				L_0511: ldloca.s V_21
				L_0513: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0518: ldc.i4.5 
				L_0519: sub 
				L_051a: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_051f: stloc.1 
				L_0520: ldloc.s V_14
				L_0522: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Pen get_x6ee6589d93f80946()
				L_0527: ldloc.1 
				L_0528: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_052d: ldloc.0 
				L_052e: callvirt System.Windows.Forms.TrackBar::System.Windows.Forms.Orientation get_Orientation()
				L_0533: ldc.i4.1 
				L_0534: bne.un.s L_053e
				L_0536: ldloc.s V_12
				L_0538: ldc.i4.3 
				L_0539: callvirt System.Drawing.Image::Void RotateFlip(System.Drawing.RotateFlipType)
				L_053e: ldarg.1 
				L_053f: ldloc.s V_12
				L_0541: ldc.i4.0 
				L_0542: ldc.i4.0 
				L_0543: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, Int32, Int32)
				L_0548: ldloc.s V_14
				L_054a: callvirt System.Drawing.Graphics::Void Dispose()
				L_054f: ldloc.s V_12
				L_0551: callvirt System.Drawing.Image::Void Dispose()
				L_0556: ret 
			*/
			
			
			{
				TrackBar trackBar1;
				Rectangle rectangle1;
				Rectangle rectangle2;
				Rectangle rectangle3;
				int i1;
				int i2;
				int i3;
				int i4;
				int i5;
				int i6;
				int i7;
				Bitmap bitmap1;
				Bitmap bitmap2;
				int i8;
				Graphics graphics1;
				Brush brush1;
				Pen pen1;
				float single1;
				float single2;
				float single3;
				TickStyle tickStyle1;
				if (! base.xf2140268ef7ddbf7)
				{
					return;
				}
				trackBar1 = ((TrackBar) base.xcd9cdf30888d2204);
				i1 = 10;
				i2 = 6;
				i3 = 7;
				i4 = 15;
				i8 = trackBar1.Value;
				if ((trackBar1.RightToLeft & RightToLeft.Yes) == RightToLeft.Yes)
				{
					i8 = (trackBar1.Maximum - trackBar1.Value);
				}
				if (trackBar1.Orientation == Orientation.Horizontal)
				{
					i5 = trackBar1.Width;
					i6 = trackBar1.Height;
				}
				else
				{
					i5 = trackBar1.Height;
					i6 = trackBar1.Width;
				}
				bitmap2 = new Bitmap (i5, i6);
				rectangle1 = new Rectangle (0, 0, i5, i6);
				graphics1 = Graphics.FromImage (((Image) bitmap2));
				brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR;
				graphics1.FillRectangle (brush1, rectangle1);
				bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TRACKBAR;
				tickStyle1 = trackBar1.TickStyle;
				switch (tickStyle1)
				{
					case TickStyle.None:
					
					{
							i7 = (i4 / 2);
							goto L_010B;
					}
					case TickStyle.TopLeft:
					
					{
							i7 = (i1 + (i4 / 2));
							goto L_010B;
					}
					case TickStyle.BottomRight:
					
					{
							i7 = (i4 / 2);
							goto L_010B;
					}
				}
				i7 = (i1 + (i4 / 2));
				
			L_010B:
				
				{
				}
				rectangle1 = new Rectangle (i2, i7, ((int) (i5 - (2 * i2))), bitmap1.Height);
				rectangle3 = new Rectangle (rectangle1.Left, rectangle1.Top, ((int) (bitmap1.Width / 3)), bitmap1.Height);
				rectangle2 = new Rectangle (0, 0, ((int) (bitmap1.Width / 3)), bitmap1.Height);
				graphics1.DrawImage (((Image) bitmap1), rectangle3, rectangle2, GraphicsUnit.Pixel);
				rectangle3 = Rectangle.FromLTRB (((int) (rectangle1.Right - (bitmap1.Width / 3))), rectangle1.Top, rectangle1.Right, rectangle1.Bottom);
				rectangle2 = new Rectangle (((int) (bitmap1.Width - (bitmap1.Width / 3))), 0, ((int) (bitmap1.Width / 3)), bitmap1.Height);
				graphics1.DrawImage (((Image) bitmap1), rectangle3, rectangle2, GraphicsUnit.Pixel);
				rectangle3 = Rectangle.FromLTRB (((int) (rectangle1.Left + (bitmap1.Width / 3))), rectangle1.Top, ((int) (rectangle1.Right - (bitmap1.Width / 3))), rectangle1.Bottom);
				rectangle2 = Rectangle.FromLTRB (((int) (bitmap1.Width / 3)), 0, ((int) (bitmap1.Width - (bitmap1.Width / 3))), bitmap1.Height);
				graphics1.DrawImage (((Image) bitmap1), rectangle3, rectangle2, GraphicsUnit.Pixel);
				tickStyle1 = trackBar1.TickStyle;
				switch (tickStyle1)
				{
					case TickStyle.None:
					
					{
							bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TRACKBARSLIDER;
							i7 = 0;
							goto L_02C8;
					}
					case TickStyle.TopLeft:
					
					{
							bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TRACKBARSLIDER_180;
							i7 = i1;
							goto L_02C8;
					}
					case TickStyle.BottomRight:
					
					{
							bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TRACKBARSLIDER;
							i7 = 0;
							goto L_02C8;
					}
				}
				bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TRACKBARSLIDER;
				i7 = i1;
				
			L_02C8:
				
				{
				}
				if (trackBar1.Maximum == trackBar1.Minimum)
				{
					goto L_04D0;
				}
				rectangle3 = new Rectangle (((int) (((((int) ((((float) ((i5 - (2 * i2)) - (2 * i3))) * ((float) (i8 - trackBar1.Minimum))) / ((float) (trackBar1.Maximum - trackBar1.Minimum)))) - (bitmap1.Width / 2)) + i2) + i3)), i7, bitmap1.Width, bitmap1.Height);
				rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
				graphics1.DrawImage (((Image) bitmap1), rectangle3, rectangle2, GraphicsUnit.Pixel);
				pen1 = new Pen (Color.Black, 1F);
				single1 = ((float) (i2 + i3));
				single2 = ((float) ((i5 - i2) - i3));
				single3 = (((single2 - single1) * ((float) trackBar1.TickFrequency)) / ((float) (trackBar1.Maximum - trackBar1.Minimum)));
				if (single3 > 0F)
				{
					tickStyle1 = trackBar1.TickStyle;
					switch (tickStyle1)
					{
						case TickStyle.None:
						
						{
								goto L_04C9;
						}
						case TickStyle.TopLeft:
						
						{
								i7 = (i1 - 4);
								if (trackBar1.Orientation != Orientation.Vertical)
								{
									this.x86a0b6ee5f4b48be (graphics1, pen1, ((float) i7), ((float) (i7 + 3)), single1, single2, single3);
									goto L_04C9;
								}
								this.xa5b17a677db5a5eb (graphics1, pen1, ((float) i7), ((float) (i7 + 3)), single1, single2, single3);
								goto L_04C9;
						}
						case TickStyle.BottomRight:
						
						{
								i7 = (i4 + 7);
								if (trackBar1.Orientation != Orientation.Vertical)
								{
									this.x86a0b6ee5f4b48be (graphics1, pen1, ((float) i7), ((float) (i7 + 3)), single1, single2, single3);
									goto L_04C9;
								}
								this.xa5b17a677db5a5eb (graphics1, pen1, ((float) i7), ((float) (i7 + 3)), single1, single2, single3);
								goto L_04C9;
						}
					}
					i7 = (i1 - 4);
					if (trackBar1.Orientation == Orientation.Vertical)
					{
						this.xa5b17a677db5a5eb (graphics1, pen1, ((float) i7), ((float) (i7 + 3)), single1, single2, single3);
					}
					else
					{
						this.x86a0b6ee5f4b48be (graphics1, pen1, ((float) i7), ((float) (i7 + 3)), single1, single2, single3);
					}
					i7 = ((i1 + i4) + 7);
					if (trackBar1.Orientation == Orientation.Vertical)
					{
						this.xa5b17a677db5a5eb (graphics1, pen1, ((float) i7), ((float) (i7 + 3)), single1, single2, single3);
					}
					else
					{
						this.x86a0b6ee5f4b48be (graphics1, pen1, ((float) i7), ((float) (i7 + 3)), single1, single2, single3);
					}
				}
				
			L_04C9:
				
				{
				}
				pen1.Dispose ();
				
			L_04D0:
				
				{
				}
				if (trackBar1.Focused)
				{
					rectangle1 = Rectangle.FromLTRB (((int) (trackBar1.ClientRectangle.X + 5)), trackBar1.ClientRectangle.Y, ((int) (trackBar1.ClientRectangle.Right - 5)), ((int) (trackBar1.ClientRectangle.Bottom - 5)));
					graphics1.DrawRectangle (x448fd9ab43628c71.x6ee6589d93f80946, rectangle1);
				}
				if (trackBar1.Orientation == Orientation.Vertical)
				{
					bitmap2.RotateFlip (RotateFlipType.Rotate270FlipNone);
				}
				x4b101060f4767186.DrawImage (((Image) bitmap2), 0, 0);
				graphics1.Dispose ();
				bitmap2.Dispose ();
			}
			
			private void xa5b17a677db5a5eb (Graphics x4b101060f4767186, Pen x90279591611601bc, float xc941868c59399d3e, float xaf9a0436a70689de, float x10aaa7cdfa38f254, float xca09b6c2b5b18485, float x0b5a48bb98ab819f)
			
			/*
				// Code Size: 50 Bytes
				.maxstack 9
				L_0000: br.s L_002b
				L_0002: ldarg.1 
				L_0003: ldarg.2 
				L_0004: ldarg.s xca09b6c2b5b18485
				L_0006: ldarg.3 
				L_0007: ldarg.s xca09b6c2b5b18485
				L_0009: ldarg.s xaf9a0436a70689de
				L_000b: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Single, Single, Single, Single)
				L_0010: ldarg.s xca09b6c2b5b18485
				L_0012: ldarg.s x0b5a48bb98ab819f
				L_0014: sub 
				L_0015: starg.s xca09b6c2b5b18485
				L_0017: ldarg.s xca09b6c2b5b18485
				L_0019: ldarg.s x10aaa7cdfa38f254
				L_001b: bgt.un.s L_002b
				L_001d: ldarg.1 
				L_001e: ldarg.2 
				L_001f: ldarg.s x10aaa7cdfa38f254
				L_0021: ldarg.3 
				L_0022: ldarg.s x10aaa7cdfa38f254
				L_0024: ldarg.s xaf9a0436a70689de
				L_0026: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Single, Single, Single, Single)
				L_002b: ldarg.s xca09b6c2b5b18485
				L_002d: ldarg.s x10aaa7cdfa38f254
				L_002f: bgt.s L_0002
				L_0031: ret 
			*/
			
			
			{
				while (xca09b6c2b5b18485 > x10aaa7cdfa38f254)
				{
					x4b101060f4767186.DrawLine (x90279591611601bc, xca09b6c2b5b18485, xc941868c59399d3e, xca09b6c2b5b18485, xaf9a0436a70689de);
					xca09b6c2b5b18485 -= x0b5a48bb98ab819f;
					if (xca09b6c2b5b18485 < x10aaa7cdfa38f254)
					{
						x4b101060f4767186.DrawLine (x90279591611601bc, x10aaa7cdfa38f254, xc941868c59399d3e, x10aaa7cdfa38f254, xaf9a0436a70689de);
					}
				}
			}
			
			private void xf51466e2b7549167 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0006: ret 
			*/
			
			
			{
				this.PaintControl ();
			}
			
		#endregion
	}
	
}

