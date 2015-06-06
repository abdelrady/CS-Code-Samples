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
		
	internal class x60982e1b4eef090a : Control
	
	{
		
		#region Fields
			private ScrollBar x246c0c54671f3f3e;
			private bool x8875b8c88ca272fe;
			private ISkinEngine xdc87e2b99332cd4a;
		#endregion
		
		#region Constructors
		
			public x60982e1b4eef090a (ScrollBar host, ISkinEngine engine, bool hScroll)
			/*
				// Code Size: 75 Bytes
				.maxstack 3
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: stfld Sunisoft.IrisSkin.x60982e1b4eef090a::System.Windows.Forms.ScrollBar x246c0c54671f3f3e
				L_000d: ldarg.0 
				L_000e: ldarg.2 
				L_000f: stfld Sunisoft.IrisSkin.x60982e1b4eef090a::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0014: ldarg.0 
				L_0015: ldarg.3 
				L_0016: stfld Sunisoft.IrisSkin.x60982e1b4eef090a::Boolean x8875b8c88ca272fe
				L_001b: ldarg.1 
				L_001c: callvirt System.Windows.Forms.Control::System.Windows.Forms.Control get_Parent()
				L_0021: brfalse.s L_004a
				L_0023: ldarg.1 
				L_0024: callvirt System.Windows.Forms.Control::System.Windows.Forms.Control get_Parent()
				L_0029: callvirt System.Windows.Forms.Control::Void SuspendLayout()
				L_002e: ldarg.1 
				L_002f: callvirt System.Windows.Forms.Control::System.Windows.Forms.Control get_Parent()
				L_0034: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0039: ldarg.0 
				L_003a: callvirt System.Windows.Forms.Control+ControlCollection::Void Add(System.Windows.Forms.Control)
				L_003f: ldarg.1 
				L_0040: callvirt System.Windows.Forms.Control::System.Windows.Forms.Control get_Parent()
				L_0045: callvirt System.Windows.Forms.Control::Void ResumeLayout()
				L_004a: ret 
			*/
		#endregion
		
		#region Methods
		
			protected override void OnPaint (PaintEventArgs e)
			
			/*
				// Code Size: 13 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: callvirt System.Windows.Forms.PaintEventArgs::System.Drawing.Graphics get_Graphics()
				L_0007: call Sunisoft.IrisSkin.x60982e1b4eef090a::Void x8bc95f030953f87b(System.Drawing.Graphics)
				L_000c: ret 
			*/
			
			
			{
				this.x8bc95f030953f87b (e.Graphics);
			}
			
			protected override void WndProc (ref Message m)
			
			/*
				// Code Size: 99 Bytes
				.maxstack 6
				.locals (System.UInt32 V_0)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.x60982e1b4eef090a::System.Windows.Forms.ScrollBar x246c0c54671f3f3e
				L_0006: brfalse.s L_005b
				L_0008: ldarg.1 
				L_0009: call System.Windows.Forms.Message::Int32 get_Msg()
				L_000e: stloc.0 
				L_000f: ldloc.0 
				L_0010: ldc.i4 512
				L_0015: sub 
				L_0016: switch (L_0037, L_0037, L_005b, L_005b, L_0037)
				L_002f: ldloc.0 
				L_0030: ldc.i4 522
				L_0035: bne.un.s L_005b
				L_0037: ldarg.0 
				L_0038: ldfld Sunisoft.IrisSkin.x60982e1b4eef090a::System.Windows.Forms.ScrollBar x246c0c54671f3f3e
				L_003d: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0042: ldarg.1 
				L_0043: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0048: ldarg.1 
				L_0049: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_004e: ldarg.1 
				L_004f: call System.Windows.Forms.Message::IntPtr get_LParam()
				L_0054: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, IntPtr, IntPtr)
				L_0059: pop 
				L_005a: ret 
				L_005b: ldarg.0 
				L_005c: ldarg.1 
				L_005d: call System.Windows.Forms.Control::Void WndProc(System.Windows.Forms.Message ByRef)
				L_0062: ret 
			*/
			
			
			{
				uint uInt32_1;
				if (this.x246c0c54671f3f3e == null)
				{
					goto L_005B;
				}
				uInt32_1 = ((uint) m.Msg);
				switch ((int) uInt32_1)
				{
					case 512:
					case 513:
					case 516:
					
					{
							goto L_0037;
					}
					case 514:
					case 515:
					
					{
							goto L_005B;
					}
				}
				if (uInt32_1 != 522)
				{
					goto L_005B;
				}
				
			L_0037:
				
				{
				}
				bool b1 = x61467fe65a98f20c.PostMessage (this.x246c0c54671f3f3e.Handle, ((uint) m.Msg), m.WParam, m.LParam);
				return;
				
			L_005B:
				
				{
				}
				base.WndProc (ref m);
			}
			
			private void x3a329aff8c7e9df4 (Graphics x4b101060f4767186, ScrollBar x2ee8392f53a01b93, Rectangle x382bb49d8f914534)
			
			/*
				// Code Size: 453 Bytes
				.maxstack 7
				.locals (System.Drawing.Brush V_0, 
         System.Drawing.Bitmap V_1, 
         System.Int32 V_2, 
         System.Int32 V_3, 
         System.Drawing.Rectangle V_4, 
         System.Drawing.Rectangle V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         System.Int32 V_9, 
         System.Int32 V_10)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.x60982e1b4eef090a::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0006: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_000b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0010: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_SCROLLBARCOLOR()
				L_0015: stloc.0 
				L_0016: ldarg.1 
				L_0017: ldloc.0 
				L_0018: ldarg.3 
				L_0019: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_001e: ldc.i4.0 
				L_001f: stloc.2 
				L_0020: ldc.i4.0 
				L_0021: stloc.3 
				L_0022: ldc.i4.s 16
				L_0024: ldarg.0 
				L_0025: call System.Windows.Forms.Control::Int32 get_Height()
				L_002a: ldc.i4.2 
				L_002b: div 
				L_002c: call System.Math::Int32 Min(Int32, Int32)
				L_0031: stloc.2 
				L_0032: ldarg.0 
				L_0033: ldfld Sunisoft.IrisSkin.x60982e1b4eef090a::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0038: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_003d: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0042: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_UpButton()
				L_0047: ldc.i4.0 
				L_0048: ldloc.3 
				L_0049: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_004e: stloc.1 
				L_004f: ldloca.s V_5
				L_0051: ldc.i4.0 
				L_0052: ldc.i4.0 
				L_0053: ldloc.1 
				L_0054: callvirt System.Drawing.Image::Int32 get_Width()
				L_0059: ldloc.1 
				L_005a: callvirt System.Drawing.Image::Int32 get_Height()
				L_005f: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0064: ldloca.s V_4
				L_0066: ldarga.s x382bb49d8f914534
				L_0068: call System.Drawing.Rectangle::Int32 get_X()
				L_006d: ldarga.s x382bb49d8f914534
				L_006f: call System.Drawing.Rectangle::Int32 get_Y()
				L_0074: ldarga.s x382bb49d8f914534
				L_0076: call System.Drawing.Rectangle::Int32 get_Width()
				L_007b: ldloc.2 
				L_007c: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0081: ldarg.1 
				L_0082: ldloc.1 
				L_0083: ldloc.s V_4
				L_0085: ldloc.s V_5
				L_0087: ldc.i4.2 
				L_0088: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_008d: ldarg.0 
				L_008e: ldfld Sunisoft.IrisSkin.x60982e1b4eef090a::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0093: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0098: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_009d: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_DownButton()
				L_00a2: ldc.i4.0 
				L_00a3: ldloc.3 
				L_00a4: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_00a9: stloc.1 
				L_00aa: ldloca.s V_5
				L_00ac: ldc.i4.0 
				L_00ad: ldc.i4.0 
				L_00ae: ldloc.1 
				L_00af: callvirt System.Drawing.Image::Int32 get_Width()
				L_00b4: ldloc.1 
				L_00b5: callvirt System.Drawing.Image::Int32 get_Height()
				L_00ba: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00bf: ldloca.s V_4
				L_00c1: ldarga.s x382bb49d8f914534
				L_00c3: call System.Drawing.Rectangle::Int32 get_X()
				L_00c8: ldarga.s x382bb49d8f914534
				L_00ca: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_00cf: ldloc.2 
				L_00d0: sub 
				L_00d1: ldarga.s x382bb49d8f914534
				L_00d3: call System.Drawing.Rectangle::Int32 get_Width()
				L_00d8: ldloc.2 
				L_00d9: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00de: ldarg.1 
				L_00df: ldloc.1 
				L_00e0: ldloc.s V_4
				L_00e2: ldloc.s V_5
				L_00e4: ldc.i4.2 
				L_00e5: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_00ea: ldarg.2 
				L_00eb: callvirt System.Windows.Forms.ScrollBar::Int32 get_Value()
				L_00f0: stloc.s V_6
				L_00f2: ldarg.2 
				L_00f3: callvirt System.Windows.Forms.ScrollBar::Int32 get_LargeChange()
				L_00f8: stloc.s V_7
				L_00fa: ldloc.s V_7
				L_00fc: brtrue.s L_0101
				L_00fe: ldc.i4.1 
				L_00ff: stloc.s V_7
				L_0101: ldarga.s x382bb49d8f914534
				L_0103: call System.Drawing.Rectangle::Int32 get_Height()
				L_0108: ldloc.2 
				L_0109: ldc.i4.2 
				L_010a: mul 
				L_010b: sub 
				L_010c: stloc.s V_8
				L_010e: ldloc.s V_8
				L_0110: ldloc.s V_7
				L_0112: mul 
				L_0113: ldarg.2 
				L_0114: callvirt System.Windows.Forms.ScrollBar::Int32 get_Maximum()
				L_0119: ldarg.2 
				L_011a: callvirt System.Windows.Forms.ScrollBar::Int32 get_Minimum()
				L_011f: sub 
				L_0120: ldc.i4.1 
				L_0121: add 
				L_0122: div 
				L_0123: stloc.s V_9
				L_0125: ldloc.s V_9
				L_0127: ldc.i4.s 10
				L_0129: bge.s L_0135
				L_012b: ldloc.s V_8
				L_012d: ldc.i4.s 10
				L_012f: blt.s L_0135
				L_0131: ldc.i4.s 10
				L_0133: stloc.s V_9
				L_0135: ldc.i4.0 
				L_0136: stloc.s V_10
				L_0138: ldloc.s V_7
				L_013a: ldarg.2 
				L_013b: callvirt System.Windows.Forms.ScrollBar::Int32 get_Maximum()
				L_0140: ldarg.2 
				L_0141: callvirt System.Windows.Forms.ScrollBar::Int32 get_Minimum()
				L_0146: sub 
				L_0147: ldc.i4.1 
				L_0148: add 
				L_0149: bne.un.s L_0150
				L_014b: ldc.i4.0 
				L_014c: stloc.s V_10
				L_014e: br.s L_0174
				L_0150: ldloc.s V_8
				L_0152: ldloc.s V_9
				L_0154: sub 
				L_0155: ldloc.s V_6
				L_0157: ldarg.2 
				L_0158: callvirt System.Windows.Forms.ScrollBar::Int32 get_Minimum()
				L_015d: sub 
				L_015e: mul 
				L_015f: ldarg.2 
				L_0160: callvirt System.Windows.Forms.ScrollBar::Int32 get_Maximum()
				L_0165: ldarg.2 
				L_0166: callvirt System.Windows.Forms.ScrollBar::Int32 get_Minimum()
				L_016b: sub 
				L_016c: ldc.i4.1 
				L_016d: add 
				L_016e: ldloc.s V_7
				L_0170: sub 
				L_0171: div 
				L_0172: stloc.s V_10
				L_0174: ldloc.s V_10
				L_0176: ldc.i4.0 
				L_0177: bge.s L_017c
				L_0179: ldc.i4.0 
				L_017a: stloc.s V_10
				L_017c: ldloc.s V_10
				L_017e: ldloc.s V_8
				L_0180: ldloc.s V_9
				L_0182: sub 
				L_0183: ble.s L_018c
				L_0185: ldloc.s V_8
				L_0187: ldloc.s V_9
				L_0189: sub 
				L_018a: stloc.s V_10
				L_018c: ldloc.s V_8
				L_018e: ldc.i4.s 10
				L_0190: blt.s L_01c4
				L_0192: ldloca.s V_4
				L_0194: ldarga.s x382bb49d8f914534
				L_0196: call System.Drawing.Rectangle::Int32 get_Left()
				L_019b: ldarga.s x382bb49d8f914534
				L_019d: call System.Drawing.Rectangle::Int32 get_Top()
				L_01a2: ldloc.2 
				L_01a3: add 
				L_01a4: ldloc.s V_10
				L_01a6: add 
				L_01a7: ldarga.s x382bb49d8f914534
				L_01a9: call System.Drawing.Rectangle::Int32 get_Width()
				L_01ae: ldloc.s V_9
				L_01b0: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01b5: ldarg.0 
				L_01b6: ldfld Sunisoft.IrisSkin.x60982e1b4eef090a::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01bb: ldarg.1 
				L_01bc: ldloc.s V_4
				L_01be: ldc.i4.1 
				L_01bf: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x9b7cda8516f8644e(Sunisoft.IrisSkin.SkinEngine, System.Drawing.Graphics, System.Drawing.Rectangle, Boolean)
				L_01c4: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Rectangle rectangle2;
				int i7;
				Brush brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_SCROLLBARCOLOR;
				x4b101060f4767186.FillRectangle (brush1, x382bb49d8f914534);
				int i2 = 0;
				int i1 = Math.Min (16, ((int) (base.Height / 2)));
				Bitmap bitmap1 = ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).ScrollBarRes.UpButton[0, i2];
				rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
				rectangle1 = new Rectangle (x382bb49d8f914534.X, x382bb49d8f914534.Y, x382bb49d8f914534.Width, i1);
				x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
				bitmap1 = ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).ScrollBarRes.DownButton[0, i2];
				rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
				rectangle1 = new Rectangle (x382bb49d8f914534.X, ((int) (x382bb49d8f914534.Bottom - i1)), x382bb49d8f914534.Width, i1);
				x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
				int i3 = x2ee8392f53a01b93.Value;
				int i4 = x2ee8392f53a01b93.LargeChange;
				if (i4 == 0)
				{
					i4 = 1;
				}
				int i5 = (x382bb49d8f914534.Height - (i1 * 2));
				int i6 = ((i5 * i4) / ((x2ee8392f53a01b93.Maximum - x2ee8392f53a01b93.Minimum) + 1));
				if ((i6 < 10) && (i5 >= 10))
				{
					i6 = 10;
				}
				if (i4 == ((x2ee8392f53a01b93.Maximum - x2ee8392f53a01b93.Minimum) + 1))
				{
					i7 = 0;
				}
				else
				{
					i7 = (((i5 - i6) * (i3 - x2ee8392f53a01b93.Minimum)) / (((x2ee8392f53a01b93.Maximum - x2ee8392f53a01b93.Minimum) + 1) - i4));
				}
				if (i7 < 0)
				{
					i7 = 0;
				}
				if (i7 > (i5 - i6))
				{
					i7 = (i5 - i6);
				}
				if (i5 >= 10)
				{
					rectangle1 = new Rectangle (x382bb49d8f914534.Left, ((int) ((x382bb49d8f914534.Top + i1) + i7)), x382bb49d8f914534.Width, i6);
					x448fd9ab43628c71.x9b7cda8516f8644e (this.xdc87e2b99332cd4a, x4b101060f4767186, rectangle1, true);
				}
			}
			
			private void x8bc95f030953f87b (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 200 Bytes
				.maxstack 6
				.locals (System.Drawing.Bitmap V_0, 
         System.Drawing.Graphics V_1, 
         System.Drawing.Bitmap V_2, 
         System.Drawing.Graphics V_3, 
         System.Drawing.Rectangle V_4)
				.try L_0046 to L_005b finally L_005b to L_0065
				.try L_003f to L_0070 finally L_0070 to L_007a
				.try L_0093 to L_00a8 finally L_00a8 to L_00b2
				.try L_008c to L_00bd finally L_00bd to L_00c7
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0006: stloc.s V_4
				L_0008: ldloca.s V_4
				L_000a: call System.Drawing.Rectangle::Int32 get_Width()
				L_000f: ldc.i4.0 
				L_0010: ble.s L_0024
				L_0012: ldarg.0 
				L_0013: call System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0018: stloc.s V_4
				L_001a: ldloca.s V_4
				L_001c: call System.Drawing.Rectangle::Int32 get_Height()
				L_0021: ldc.i4.0 
				L_0022: bgt.s L_0025
				L_0024: ret 
				L_0025: ldarg.0 
				L_0026: ldfld Sunisoft.IrisSkin.x60982e1b4eef090a::Boolean x8875b8c88ca272fe
				L_002b: brfalse.s L_007a
				L_002d: ldarg.0 
				L_002e: call System.Windows.Forms.Control::Int32 get_Width()
				L_0033: ldarg.0 
				L_0034: call System.Windows.Forms.Control::Int32 get_Height()
				L_0039: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_003e: stloc.0 
				L_003f: ldloc.0 
				L_0040: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0045: stloc.1 
				L_0046: ldarg.0 
				L_0047: ldloc.1 
				L_0048: ldarg.0 
				L_0049: ldfld Sunisoft.IrisSkin.x60982e1b4eef090a::System.Windows.Forms.ScrollBar x246c0c54671f3f3e
				L_004e: ldarg.0 
				L_004f: call System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0054: call Sunisoft.IrisSkin.x60982e1b4eef090a::Void xb16feaabcbd204bd(System.Drawing.Graphics, System.Windows.Forms.ScrollBar, System.Drawing.Rectangle)
				L_0059: leave.s L_0065
				L_005b: ldloc.1 
				L_005c: brfalse.s L_0064
				L_005e: ldloc.1 
				L_005f: callvirt System.IDisposable::Void Dispose()
				L_0064: endfinally 
				L_0065: ldarg.1 
				L_0066: ldloc.0 
				L_0067: ldc.i4.0 
				L_0068: ldc.i4.0 
				L_0069: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_006e: leave.s L_00c7
				L_0070: ldloc.0 
				L_0071: brfalse.s L_0079
				L_0073: ldloc.0 
				L_0074: callvirt System.IDisposable::Void Dispose()
				L_0079: endfinally 
				L_007a: ldarg.0 
				L_007b: call System.Windows.Forms.Control::Int32 get_Width()
				L_0080: ldarg.0 
				L_0081: call System.Windows.Forms.Control::Int32 get_Height()
				L_0086: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_008b: stloc.2 
				L_008c: ldloc.2 
				L_008d: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0092: stloc.3 
				L_0093: ldarg.0 
				L_0094: ldarg.1 
				L_0095: ldarg.0 
				L_0096: ldfld Sunisoft.IrisSkin.x60982e1b4eef090a::System.Windows.Forms.ScrollBar x246c0c54671f3f3e
				L_009b: ldarg.0 
				L_009c: call System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_00a1: call Sunisoft.IrisSkin.x60982e1b4eef090a::Void x3a329aff8c7e9df4(System.Drawing.Graphics, System.Windows.Forms.ScrollBar, System.Drawing.Rectangle)
				L_00a6: leave.s L_00b2
				L_00a8: ldloc.3 
				L_00a9: brfalse.s L_00b1
				L_00ab: ldloc.3 
				L_00ac: callvirt System.IDisposable::Void Dispose()
				L_00b1: endfinally 
				L_00b2: ldarg.1 
				L_00b3: ldloc.2 
				L_00b4: ldc.i4.0 
				L_00b5: ldc.i4.0 
				L_00b6: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_00bb: leave.s L_00c7
				L_00bd: ldloc.2 
				L_00be: brfalse.s L_00c6
				L_00c0: ldloc.2 
				L_00c1: callvirt System.IDisposable::Void Dispose()
				L_00c6: endfinally 
				L_00c7: ret 
			*/
			
			
			{
				if ((base.ClientRectangle.Width <= 0) || (base.ClientRectangle.Height <= 0))
				{
				}
				else if (this.x8875b8c88ca272fe)
				{
					using (Bitmap bitmap1 = new Bitmap (base.Width, base.Height))
					{
						using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap1)))
						{
							this.xb16feaabcbd204bd (graphics1, this.x246c0c54671f3f3e, base.ClientRectangle);
						}
						x4b101060f4767186.DrawImageUnscaled (((Image) bitmap1), 0, 0);
						return;
					}
				}
				else
				{
					using (Bitmap bitmap2 = new Bitmap (base.Width, base.Height))
					{
						using (Graphics graphics2 = Graphics.FromImage (((Image) bitmap2)))
						{
							this.x3a329aff8c7e9df4 (x4b101060f4767186, this.x246c0c54671f3f3e, base.ClientRectangle);
						}
						x4b101060f4767186.DrawImageUnscaled (((Image) bitmap2), 0, 0);
					}
				}
			}
			
			public void x9b8f9735fbcfbe34 ()
			
			/*
				// Code Size: 32 Bytes
				.maxstack 3
				.locals (System.Drawing.Graphics V_0)
				.try L_000c to L_0015 finally L_0015 to L_001f
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_0006: call System.Drawing.Graphics::System.Drawing.Graphics FromHwnd(IntPtr)
				L_000b: stloc.0 
				L_000c: ldarg.0 
				L_000d: ldloc.0 
				L_000e: call Sunisoft.IrisSkin.x60982e1b4eef090a::Void x8bc95f030953f87b(System.Drawing.Graphics)
				L_0013: leave.s L_001f
				L_0015: ldloc.0 
				L_0016: brfalse.s L_001e
				L_0018: ldloc.0 
				L_0019: callvirt System.IDisposable::Void Dispose()
				L_001e: endfinally 
				L_001f: ret 
			*/
			
			
			{
				using (Graphics graphics1 = Graphics.FromHwnd (base.Handle))
				{
					this.x8bc95f030953f87b (graphics1);
				}
			}
			
			private void xb16feaabcbd204bd (Graphics x4b101060f4767186, ScrollBar x2ee8392f53a01b93, Rectangle x382bb49d8f914534)
			
			/*
				// Code Size: 509 Bytes
				.maxstack 7
				.locals (System.Drawing.Brush V_0, 
         System.Drawing.Bitmap V_1, 
         System.Int32 V_2, 
         System.Int32 V_3, 
         System.Drawing.Rectangle V_4, 
         System.Drawing.Rectangle V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         System.Int32 V_9, 
         System.Int32 V_10)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.x60982e1b4eef090a::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0006: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_000b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0010: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Brush get_BackColorBrush()
				L_0015: stloc.0 
				L_0016: ldarg.1 
				L_0017: ldloc.0 
				L_0018: ldarg.3 
				L_0019: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_001e: ldc.i4.0 
				L_001f: stloc.2 
				L_0020: ldc.i4.0 
				L_0021: stloc.3 
				L_0022: ldc.i4.s 16
				L_0024: ldarg.0 
				L_0025: call System.Windows.Forms.Control::Int32 get_Width()
				L_002a: ldc.i4.2 
				L_002b: div 
				L_002c: call System.Math::Int32 Min(Int32, Int32)
				L_0031: stloc.2 
				L_0032: ldarg.0 
				L_0033: ldfld Sunisoft.IrisSkin.x60982e1b4eef090a::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0038: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_003d: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0042: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_UpButton()
				L_0047: ldc.i4.1 
				L_0048: ldloc.3 
				L_0049: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_004e: stloc.1 
				L_004f: ldloca.s V_5
				L_0051: ldc.i4.0 
				L_0052: ldc.i4.0 
				L_0053: ldloc.1 
				L_0054: callvirt System.Drawing.Image::Int32 get_Width()
				L_0059: ldloc.1 
				L_005a: callvirt System.Drawing.Image::Int32 get_Height()
				L_005f: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0064: ldloca.s V_4
				L_0066: ldarga.s x382bb49d8f914534
				L_0068: call System.Drawing.Rectangle::Int32 get_X()
				L_006d: ldarga.s x382bb49d8f914534
				L_006f: call System.Drawing.Rectangle::Int32 get_Y()
				L_0074: ldloc.2 
				L_0075: ldarga.s x382bb49d8f914534
				L_0077: call System.Drawing.Rectangle::Int32 get_Height()
				L_007c: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0081: ldarg.1 
				L_0082: ldloc.1 
				L_0083: ldloc.s V_4
				L_0085: ldloc.s V_5
				L_0087: ldc.i4.2 
				L_0088: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_008d: ldarg.0 
				L_008e: ldfld Sunisoft.IrisSkin.x60982e1b4eef090a::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0093: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0098: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_009d: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_DownButton()
				L_00a2: ldc.i4.1 
				L_00a3: ldloc.3 
				L_00a4: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_00a9: stloc.1 
				L_00aa: ldloca.s V_5
				L_00ac: ldc.i4.0 
				L_00ad: ldc.i4.0 
				L_00ae: ldloc.1 
				L_00af: callvirt System.Drawing.Image::Int32 get_Width()
				L_00b4: ldloc.1 
				L_00b5: callvirt System.Drawing.Image::Int32 get_Height()
				L_00ba: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00bf: ldloca.s V_4
				L_00c1: ldarga.s x382bb49d8f914534
				L_00c3: call System.Drawing.Rectangle::Int32 get_Right()
				L_00c8: ldloc.2 
				L_00c9: sub 
				L_00ca: ldarga.s x382bb49d8f914534
				L_00cc: call System.Drawing.Rectangle::Int32 get_Y()
				L_00d1: ldloc.2 
				L_00d2: ldarga.s x382bb49d8f914534
				L_00d4: call System.Drawing.Rectangle::Int32 get_Height()
				L_00d9: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00de: ldarg.1 
				L_00df: ldloc.1 
				L_00e0: ldloc.s V_4
				L_00e2: ldloc.s V_5
				L_00e4: ldc.i4.2 
				L_00e5: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_00ea: ldarg.2 
				L_00eb: callvirt System.Windows.Forms.ScrollBar::Int32 get_Value()
				L_00f0: stloc.s V_6
				L_00f2: ldarg.2 
				L_00f3: callvirt System.Windows.Forms.ScrollBar::Int32 get_LargeChange()
				L_00f8: stloc.s V_7
				L_00fa: ldloc.s V_7
				L_00fc: brtrue.s L_0101
				L_00fe: ldc.i4.1 
				L_00ff: stloc.s V_7
				L_0101: ldarga.s x382bb49d8f914534
				L_0103: call System.Drawing.Rectangle::Int32 get_Width()
				L_0108: ldloc.2 
				L_0109: ldc.i4.2 
				L_010a: mul 
				L_010b: sub 
				L_010c: stloc.s V_8
				L_010e: ldloc.s V_8
				L_0110: ldloc.s V_7
				L_0112: mul 
				L_0113: ldarg.2 
				L_0114: callvirt System.Windows.Forms.ScrollBar::Int32 get_Maximum()
				L_0119: ldarg.2 
				L_011a: callvirt System.Windows.Forms.ScrollBar::Int32 get_Minimum()
				L_011f: sub 
				L_0120: ldc.i4.1 
				L_0121: add 
				L_0122: div 
				L_0123: stloc.s V_9
				L_0125: ldloc.s V_9
				L_0127: ldc.i4.s 10
				L_0129: bge.s L_0135
				L_012b: ldloc.s V_8
				L_012d: ldc.i4.s 10
				L_012f: blt.s L_0135
				L_0131: ldc.i4.s 10
				L_0133: stloc.s V_9
				L_0135: ldc.i4.0 
				L_0136: stloc.s V_10
				L_0138: ldloc.s V_7
				L_013a: ldarg.2 
				L_013b: callvirt System.Windows.Forms.ScrollBar::Int32 get_Maximum()
				L_0140: ldarg.2 
				L_0141: callvirt System.Windows.Forms.ScrollBar::Int32 get_Minimum()
				L_0146: sub 
				L_0147: ldc.i4.1 
				L_0148: add 
				L_0149: bne.un.s L_0150
				L_014b: ldc.i4.0 
				L_014c: stloc.s V_10
				L_014e: br.s L_0174
				L_0150: ldloc.s V_8
				L_0152: ldloc.s V_9
				L_0154: sub 
				L_0155: ldloc.s V_6
				L_0157: ldarg.2 
				L_0158: callvirt System.Windows.Forms.ScrollBar::Int32 get_Minimum()
				L_015d: sub 
				L_015e: mul 
				L_015f: ldarg.2 
				L_0160: callvirt System.Windows.Forms.ScrollBar::Int32 get_Maximum()
				L_0165: ldarg.2 
				L_0166: callvirt System.Windows.Forms.ScrollBar::Int32 get_Minimum()
				L_016b: sub 
				L_016c: ldc.i4.1 
				L_016d: add 
				L_016e: ldloc.s V_7
				L_0170: sub 
				L_0171: div 
				L_0172: stloc.s V_10
				L_0174: ldloc.s V_10
				L_0176: ldc.i4.0 
				L_0177: bge.s L_017c
				L_0179: ldc.i4.0 
				L_017a: stloc.s V_10
				L_017c: ldloc.s V_10
				L_017e: ldloc.s V_8
				L_0180: ldloc.s V_9
				L_0182: sub 
				L_0183: ble.s L_018c
				L_0185: ldloc.s V_8
				L_0187: ldloc.s V_9
				L_0189: sub 
				L_018a: stloc.s V_10
				L_018c: ldloc.s V_8
				L_018e: ldc.i4.s 10
				L_0190: blt.s L_01fc
				L_0192: ldarg.0 
				L_0193: ldfld Sunisoft.IrisSkin.x60982e1b4eef090a::System.Windows.Forms.ScrollBar x246c0c54671f3f3e
				L_0198: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_019d: ldc.i4.1 
				L_019e: and 
				L_019f: ldc.i4.1 
				L_01a0: bne.un.s L_01ca
				L_01a2: ldloca.s V_4
				L_01a4: ldarga.s x382bb49d8f914534
				L_01a6: call System.Drawing.Rectangle::Int32 get_Right()
				L_01ab: ldloc.2 
				L_01ac: sub 
				L_01ad: ldloc.s V_10
				L_01af: sub 
				L_01b0: ldloc.s V_9
				L_01b2: sub 
				L_01b3: ldarga.s x382bb49d8f914534
				L_01b5: call System.Drawing.Rectangle::Int32 get_Top()
				L_01ba: ldloc.s V_9
				L_01bc: ldarga.s x382bb49d8f914534
				L_01be: call System.Drawing.Rectangle::Int32 get_Height()
				L_01c3: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01c8: br.s L_01ed
				L_01ca: ldloca.s V_4
				L_01cc: ldarga.s x382bb49d8f914534
				L_01ce: call System.Drawing.Rectangle::Int32 get_Left()
				L_01d3: ldloc.2 
				L_01d4: add 
				L_01d5: ldloc.s V_10
				L_01d7: add 
				L_01d8: ldarga.s x382bb49d8f914534
				L_01da: call System.Drawing.Rectangle::Int32 get_Top()
				L_01df: ldloc.s V_9
				L_01e1: ldarga.s x382bb49d8f914534
				L_01e3: call System.Drawing.Rectangle::Int32 get_Height()
				L_01e8: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01ed: ldarg.0 
				L_01ee: ldfld Sunisoft.IrisSkin.x60982e1b4eef090a::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01f3: ldarg.1 
				L_01f4: ldloc.s V_4
				L_01f6: ldc.i4.0 
				L_01f7: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x9b7cda8516f8644e(Sunisoft.IrisSkin.SkinEngine, System.Drawing.Graphics, System.Drawing.Rectangle, Boolean)
				L_01fc: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Rectangle rectangle2;
				int i7;
				Brush brush1 = ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).ScrollBarRes.BackColorBrush;
				x4b101060f4767186.FillRectangle (brush1, x382bb49d8f914534);
				int i2 = 0;
				int i1 = Math.Min (16, ((int) (base.Width / 2)));
				Bitmap bitmap1 = ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).ScrollBarRes.UpButton[1, i2];
				rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
				rectangle1 = new Rectangle (x382bb49d8f914534.X, x382bb49d8f914534.Y, i1, x382bb49d8f914534.Height);
				x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
				bitmap1 = ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).ScrollBarRes.DownButton[1, i2];
				rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
				rectangle1 = new Rectangle (((int) (x382bb49d8f914534.Right - i1)), x382bb49d8f914534.Y, i1, x382bb49d8f914534.Height);
				x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
				int i3 = x2ee8392f53a01b93.Value;
				int i4 = x2ee8392f53a01b93.LargeChange;
				if (i4 == 0)
				{
					i4 = 1;
				}
				int i5 = (x382bb49d8f914534.Width - (i1 * 2));
				int i6 = ((i5 * i4) / ((x2ee8392f53a01b93.Maximum - x2ee8392f53a01b93.Minimum) + 1));
				if ((i6 < 10) && (i5 >= 10))
				{
					i6 = 10;
				}
				if (i4 == ((x2ee8392f53a01b93.Maximum - x2ee8392f53a01b93.Minimum) + 1))
				{
					i7 = 0;
				}
				else
				{
					i7 = (((i5 - i6) * (i3 - x2ee8392f53a01b93.Minimum)) / (((x2ee8392f53a01b93.Maximum - x2ee8392f53a01b93.Minimum) + 1) - i4));
				}
				if (i7 < 0)
				{
					i7 = 0;
				}
				if (i7 > (i5 - i6))
				{
					i7 = (i5 - i6);
				}
				if (i5 >= 10)
				{
					if ((this.x246c0c54671f3f3e.RightToLeft & System.Windows.Forms.RightToLeft.Yes) == System.Windows.Forms.RightToLeft.Yes)
					{
						rectangle1 = new Rectangle (((int) (((x382bb49d8f914534.Right - i1) - i7) - i6)), x382bb49d8f914534.Top, i6, x382bb49d8f914534.Height);
					}
					else
					{
						rectangle1 = new Rectangle (((int) ((x382bb49d8f914534.Left + i1) + i7)), x382bb49d8f914534.Top, i6, x382bb49d8f914534.Height);
					}
					x448fd9ab43628c71.x9b7cda8516f8644e (this.xdc87e2b99332cd4a, x4b101060f4767186, rectangle1, false);
				}
			}
			
		#endregion
	}
	
}

