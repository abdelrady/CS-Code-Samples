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
			using System.Runtime.InteropServices;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class x2ada8799c851d3c1 : x2edc3f693fe78d2e
	
	{
		
		#region Fields
			private int x01b557925841ae51;
			private Control x256c9720723a7c14;
		#endregion
		
		#region Constructors
		
			public x2ada8799c851d3c1 (Control control, ISkinEngine engine)
				 : base (control, engine)
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ret 
			*/
		#endregion
		
		#region Properties
		
			protected override bool ChangeBackColor
			
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
		
			protected override void DoInit ()
			
			/*
				// Code Size: 118 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void DoInit()
				L_0006: ldarg.0 
				L_0007: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_000c: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0011: callvirt System.Windows.Forms.Layout.ArrangedElementCollection::Int32 get_Count()
				L_0016: ldc.i4.0 
				L_0017: ble.s L_0047
				L_0019: ldarg.0 
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0020: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0025: ldc.i4.0 
				L_0026: callvirt System.Windows.Forms.Control+ControlCollection::System.Windows.Forms.Control get_Item(Int32)
				L_002b: stfld Sunisoft.IrisSkin.x2ada8799c851d3c1::System.Windows.Forms.Control x256c9720723a7c14
				L_0030: ldarg.0 
				L_0031: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::System.Windows.Forms.Control x256c9720723a7c14
				L_0036: ldarg.0 
				L_0037: ldftn Sunisoft.IrisSkin.x2ada8799c851d3c1::Void x36ba227d26d9f4d3(System.Object, System.Windows.Forms.PaintEventArgs)
				L_003d: newobj System.Windows.Forms.PaintEventHandler::Void .ctor(System.Object, IntPtr)
				L_0042: callvirt System.Windows.Forms.Control::Void add_Paint(System.Windows.Forms.PaintEventHandler)
				L_0047: ldarg.0 
				L_0048: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_004d: ldarg.0 
				L_004e: ldftn Sunisoft.IrisSkin.x2ada8799c851d3c1::Void x2c376bc5808866ab(System.Object, System.Windows.Forms.MouseEventArgs)
				L_0054: newobj System.Windows.Forms.MouseEventHandler::Void .ctor(System.Object, IntPtr)
				L_0059: callvirt System.Windows.Forms.Control::Void add_MouseDown(System.Windows.Forms.MouseEventHandler)
				L_005e: ldarg.0 
				L_005f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0064: ldarg.0 
				L_0065: ldftn Sunisoft.IrisSkin.x2ada8799c851d3c1::Void x311c106b70013575(System.Object, System.Windows.Forms.MouseEventArgs)
				L_006b: newobj System.Windows.Forms.MouseEventHandler::Void .ctor(System.Object, IntPtr)
				L_0070: callvirt System.Windows.Forms.Control::Void add_MouseUp(System.Windows.Forms.MouseEventHandler)
				L_0075: ret 
			*/
			
			
			{
				base.DoInit ();
				if (base.xcd9cdf30888d2204.Controls.Count > 0)
				{
					this.x256c9720723a7c14 = base.xcd9cdf30888d2204.Controls[0];
					this.x256c9720723a7c14.Paint += new PaintEventHandler (this.x36ba227d26d9f4d3);
				}
				base.xcd9cdf30888d2204.MouseDown += new MouseEventHandler (this.x2c376bc5808866ab);
				base.xcd9cdf30888d2204.MouseUp += new MouseEventHandler (this.x311c106b70013575);
			}
			
			private void x2c376bc5808866ab (object xe0292b9ed559da7d, MouseEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 84 Bytes
				.maxstack 5
				.locals (System.Drawing.Rectangle V_0, 
         System.Drawing.Rectangle V_1, 
         System.Drawing.Point V_2)
				L_0000: ldarg.2 
				L_0001: callvirt System.Windows.Forms.MouseEventArgs::System.Windows.Forms.MouseButtons get_Button()
				L_0006: ldc.i4 1048576
				L_000b: bne.un.s L_0053
				L_000d: ldarg.0 
				L_000e: ldloca.s V_0
				L_0010: ldloca.s V_1
				L_0012: call Sunisoft.IrisSkin.x2ada8799c851d3c1::Void x9c2d0a8c2d93d7c6(System.Drawing.Rectangle ByRef, System.Drawing.Rectangle ByRef)
				L_0017: ldloca.s V_2
				L_0019: ldarg.2 
				L_001a: callvirt System.Windows.Forms.MouseEventArgs::Int32 get_X()
				L_001f: ldarg.2 
				L_0020: callvirt System.Windows.Forms.MouseEventArgs::Int32 get_Y()
				L_0025: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_002a: ldloc.2 
				L_002b: ldloc.0 
				L_002c: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0031: brfalse.s L_003b
				L_0033: ldarg.0 
				L_0034: ldc.i4.m1 
				L_0035: stfld Sunisoft.IrisSkin.x2ada8799c851d3c1::Int32 x01b557925841ae51
				L_003a: ret 
				L_003b: ldloc.2 
				L_003c: ldloc.1 
				L_003d: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0042: brfalse.s L_004c
				L_0044: ldarg.0 
				L_0045: ldc.i4.1 
				L_0046: stfld Sunisoft.IrisSkin.x2ada8799c851d3c1::Int32 x01b557925841ae51
				L_004b: ret 
				L_004c: ldarg.0 
				L_004d: ldc.i4.0 
				L_004e: stfld Sunisoft.IrisSkin.x2ada8799c851d3c1::Int32 x01b557925841ae51
				L_0053: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Rectangle rectangle2;
				Point point1;
				if (xfbf34718e704c6bc.Button == MouseButtons.Left)
				{
					this.x9c2d0a8c2d93d7c6 (out rectangle1, out rectangle2);
					point1 = new Point (xfbf34718e704c6bc.X, xfbf34718e704c6bc.Y);
					if (x448fd9ab43628c71.x9466a6be27202526 (point1, rectangle1))
					{
						this.x01b557925841ae51 = -1;
					}
					else if (x448fd9ab43628c71.x9466a6be27202526 (point1, rectangle2))
					{
						this.x01b557925841ae51 = 1;
					}
					else
					{
						this.x01b557925841ae51 = 0;
					}
				}
			}
			
			private void x311c106b70013575 (object xe0292b9ed559da7d, MouseEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 8 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.0 
				L_0002: stfld Sunisoft.IrisSkin.x2ada8799c851d3c1::Int32 x01b557925841ae51
				L_0007: ret 
			*/
			
			
			{
				this.x01b557925841ae51 = 0;
			}
			
			private void x36ba227d26d9f4d3 (object xe0292b9ed559da7d, PaintEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 509 Bytes
				.maxstack 7
				.locals (System.Drawing.Graphics V_0, 
         System.Int32 V_1, 
         System.Int32 V_2, 
         System.Drawing.Rectangle V_3, 
         System.Drawing.Bitmap V_4, 
         System.Drawing.Rectangle V_5, 
         System.Drawing.Rectangle V_6, 
         System.Drawing.Graphics V_7, 
         System.Drawing.Brush V_8, 
         System.Int32 V_9, 
         System.Int32 V_10)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0006: brtrue.s L_0009
				L_0008: ret 
				L_0009: ldarg.2 
				L_000a: callvirt System.Windows.Forms.PaintEventArgs::System.Drawing.Graphics get_Graphics()
				L_000f: stloc.0 
				L_0010: ldarg.0 
				L_0011: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::System.Windows.Forms.Control x256c9720723a7c14
				L_0016: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_001b: stloc.1 
				L_001c: ldarg.0 
				L_001d: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::System.Windows.Forms.Control x256c9720723a7c14
				L_0022: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0027: stloc.2 
				L_0028: ldloca.s V_3
				L_002a: ldc.i4.0 
				L_002b: ldc.i4.0 
				L_002c: ldloc.1 
				L_002d: ldloc.2 
				L_002e: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0033: ldloc.1 
				L_0034: ldloc.2 
				L_0035: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_003a: stloc.s V_4
				L_003c: ldloca.s V_5
				L_003e: ldc.i4.0 
				L_003f: ldc.i4.0 
				L_0040: ldarg.0 
				L_0041: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::System.Windows.Forms.Control x256c9720723a7c14
				L_0046: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_004b: ldarg.0 
				L_004c: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::System.Windows.Forms.Control x256c9720723a7c14
				L_0051: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0056: ldc.i4.2 
				L_0057: div 
				L_0058: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_005d: ldloca.s V_6
				L_005f: ldc.i4.0 
				L_0060: ldarg.0 
				L_0061: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::System.Windows.Forms.Control x256c9720723a7c14
				L_0066: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_006b: ldc.i4.2 
				L_006c: div 
				L_006d: ldarg.0 
				L_006e: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::System.Windows.Forms.Control x256c9720723a7c14
				L_0073: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0078: ldarg.0 
				L_0079: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::System.Windows.Forms.Control x256c9720723a7c14
				L_007e: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0083: ldc.i4.2 
				L_0084: div 
				L_0085: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_008a: ldloc.s V_4
				L_008c: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0091: stloc.s V_7
				L_0093: ldarg.0 
				L_0094: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::Int32 x01b557925841ae51
				L_0099: ldc.i4.m1 
				L_009a: bne.un.s L_00b5
				L_009c: ldarg.0 
				L_009d: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00a2: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00a7: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_00ac: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOOLBARDOWNCOLOR()
				L_00b1: stloc.s V_8
				L_00b3: br.s L_00cc
				L_00b5: ldarg.0 
				L_00b6: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00bb: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00c0: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_00c5: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_00ca: stloc.s V_8
				L_00cc: ldloc.s V_7
				L_00ce: ldloc.s V_8
				L_00d0: ldloc.s V_5
				L_00d2: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_00d7: ldarg.0 
				L_00d8: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::Int32 x01b557925841ae51
				L_00dd: ldc.i4.1 
				L_00de: bne.un.s L_00f9
				L_00e0: ldarg.0 
				L_00e1: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00e6: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00eb: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_00f0: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOOLBARDOWNCOLOR()
				L_00f5: stloc.s V_8
				L_00f7: br.s L_0110
				L_00f9: ldarg.0 
				L_00fa: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00ff: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0104: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0109: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_010e: stloc.s V_8
				L_0110: ldloc.s V_7
				L_0112: ldloc.s V_8
				L_0114: ldloc.s V_6
				L_0116: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_011b: ldloca.s V_5
				L_011d: call System.Drawing.Rectangle::Int32 get_Right()
				L_0122: ldloca.s V_5
				L_0124: call System.Drawing.Rectangle::Int32 get_Left()
				L_0129: sub 
				L_012a: ldc.i4.6 
				L_012b: sub 
				L_012c: ldc.i4.2 
				L_012d: div 
				L_012e: ldloca.s V_5
				L_0130: call System.Drawing.Rectangle::Int32 get_Left()
				L_0135: add 
				L_0136: stloc.s V_9
				L_0138: ldloca.s V_5
				L_013a: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_013f: ldloca.s V_5
				L_0141: call System.Drawing.Rectangle::Int32 get_Top()
				L_0146: sub 
				L_0147: ldc.i4.3 
				L_0148: add 
				L_0149: ldc.i4.2 
				L_014a: div 
				L_014b: ldloca.s V_5
				L_014d: call System.Drawing.Rectangle::Int32 get_Top()
				L_0152: add 
				L_0153: stloc.s V_10
				L_0155: ldarg.0 
				L_0156: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::Int32 x01b557925841ae51
				L_015b: ldc.i4.m1 
				L_015c: bne.un.s L_016a
				L_015e: ldloc.s V_9
				L_0160: ldc.i4.1 
				L_0161: add 
				L_0162: stloc.s V_9
				L_0164: ldloc.s V_10
				L_0166: ldc.i4.1 
				L_0167: add 
				L_0168: stloc.s V_10
				L_016a: ldloc.s V_7
				L_016c: ldloc.s V_9
				L_016e: ldloc.s V_10
				L_0170: ldarg.0 
				L_0171: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0176: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_017b: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x0f9835bacc0cb58b(System.Drawing.Graphics, Int32, Int32, Boolean)
				L_0180: ldloca.s V_6
				L_0182: call System.Drawing.Rectangle::Int32 get_Right()
				L_0187: ldloca.s V_6
				L_0189: call System.Drawing.Rectangle::Int32 get_Left()
				L_018e: sub 
				L_018f: ldc.i4.6 
				L_0190: sub 
				L_0191: ldc.i4.2 
				L_0192: div 
				L_0193: ldloca.s V_6
				L_0195: call System.Drawing.Rectangle::Int32 get_Left()
				L_019a: add 
				L_019b: stloc.s V_9
				L_019d: ldloca.s V_6
				L_019f: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_01a4: ldloca.s V_6
				L_01a6: call System.Drawing.Rectangle::Int32 get_Top()
				L_01ab: sub 
				L_01ac: ldc.i4.3 
				L_01ad: sub 
				L_01ae: ldc.i4.2 
				L_01af: div 
				L_01b0: ldloca.s V_6
				L_01b2: call System.Drawing.Rectangle::Int32 get_Top()
				L_01b7: add 
				L_01b8: stloc.s V_10
				L_01ba: ldarg.0 
				L_01bb: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::Int32 x01b557925841ae51
				L_01c0: ldc.i4.1 
				L_01c1: bne.un.s L_01cf
				L_01c3: ldloc.s V_9
				L_01c5: ldc.i4.1 
				L_01c6: add 
				L_01c7: stloc.s V_9
				L_01c9: ldloc.s V_10
				L_01cb: ldc.i4.1 
				L_01cc: add 
				L_01cd: stloc.s V_10
				L_01cf: ldloc.s V_7
				L_01d1: ldloc.s V_9
				L_01d3: ldloc.s V_10
				L_01d5: ldarg.0 
				L_01d6: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_01db: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_01e0: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x3fbffc8bcd27b3c0(System.Drawing.Graphics, Int32, Int32, Boolean)
				L_01e5: ldloc.0 
				L_01e6: ldloc.s V_4
				L_01e8: ldloc.3 
				L_01e9: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, System.Drawing.Rectangle)
				L_01ee: ldloc.s V_7
				L_01f0: callvirt System.Drawing.Graphics::Void Dispose()
				L_01f5: ldloc.s V_4
				L_01f7: callvirt System.Drawing.Image::Void Dispose()
				L_01fc: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Rectangle rectangle2;
				Rectangle rectangle3;
				Brush brush1;
				if (! base.xf2140268ef7ddbf7)
				{
					return;
				}
				Graphics graphics1 = xfbf34718e704c6bc.Graphics;
				int i1 = this.x256c9720723a7c14.Width;
				int i2 = this.x256c9720723a7c14.Height;
				rectangle1 = new Rectangle (0, 0, i1, i2);
				Bitmap bitmap1 = new Bitmap (i1, i2);
				rectangle2 = new Rectangle (0, 0, this.x256c9720723a7c14.Width, ((int) (this.x256c9720723a7c14.Height / 2)));
				rectangle3 = new Rectangle (0, ((int) (this.x256c9720723a7c14.Height / 2)), this.x256c9720723a7c14.Width, ((int) (this.x256c9720723a7c14.Height / 2)));
				Graphics graphics2 = Graphics.FromImage (((Image) bitmap1));
				if (this.x01b557925841ae51 == -1)
				{
					brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOOLBARDOWNCOLOR;
				}
				else
				{
					brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR;
				}
				graphics2.FillRectangle (brush1, rectangle2);
				if (this.x01b557925841ae51 == 1)
				{
					brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOOLBARDOWNCOLOR;
				}
				else
				{
					brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR;
				}
				graphics2.FillRectangle (brush1, rectangle3);
				int i3 = ((((rectangle2.Right - rectangle2.Left) - 6) / 2) + rectangle2.Left);
				int i4 = ((((rectangle2.Bottom - rectangle2.Top) + 3) / 2) + rectangle2.Top);
				if (this.x01b557925841ae51 == -1)
				{
					i3++;
					i4++;
				}
				x448fd9ab43628c71.x0f9835bacc0cb58b (graphics2, i3, i4, base.xcd9cdf30888d2204.Enabled);
				i3 = ((((rectangle3.Right - rectangle3.Left) - 6) / 2) + rectangle3.Left);
				i4 = ((((rectangle3.Bottom - rectangle3.Top) - 3) / 2) + rectangle3.Top);
				if (this.x01b557925841ae51 == 1)
				{
					i3++;
					i4++;
				}
				x448fd9ab43628c71.x3fbffc8bcd27b3c0 (graphics2, i3, i4, base.xcd9cdf30888d2204.Enabled);
				graphics1.DrawImageUnscaled (((Image) bitmap1), rectangle1);
				graphics2.Dispose ();
				bitmap1.Dispose ();
			}
			
			private void x6e1c0299f4a4ec84 (object xe0292b9ed559da7d, MouseEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 8 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.0 
				L_0002: stfld Sunisoft.IrisSkin.x2ada8799c851d3c1::Int32 x01b557925841ae51
				L_0007: ret 
			*/
			
			
			{
				this.x01b557925841ae51 = 0;
			}
			
			private void x9c2d0a8c2d93d7c6 (out Rectangle x704d5d75fd559aed, out Rectangle x68123086ccad0951)
			
			/*
				// Code Size: 79 Bytes
				.maxstack 7
				.locals (System.Int32 V_0)
				L_0000: ldc.i4.0 
				L_0001: stloc.0 
				L_0002: ldarg.1 
				L_0003: ldloc.0 
				L_0004: ldc.i4.0 
				L_0005: ldarg.0 
				L_0006: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::System.Windows.Forms.Control x256c9720723a7c14
				L_000b: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0010: ldarg.0 
				L_0011: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::System.Windows.Forms.Control x256c9720723a7c14
				L_0016: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_001b: ldc.i4.2 
				L_001c: div 
				L_001d: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0022: ldarg.2 
				L_0023: ldloc.0 
				L_0024: ldarg.0 
				L_0025: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::System.Windows.Forms.Control x256c9720723a7c14
				L_002a: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_002f: ldc.i4.2 
				L_0030: div 
				L_0031: ldarg.0 
				L_0032: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::System.Windows.Forms.Control x256c9720723a7c14
				L_0037: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_003c: ldarg.0 
				L_003d: ldfld Sunisoft.IrisSkin.x2ada8799c851d3c1::System.Windows.Forms.Control x256c9720723a7c14
				L_0042: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0047: ldc.i4.2 
				L_0048: div 
				L_0049: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_004e: ret 
			*/
			
			
			{
				int i1 = 0;
				x704d5d75fd559aed = new Rectangle (i1, 0, this.x256c9720723a7c14.Width, ((int) (this.x256c9720723a7c14.Height / 2)));
				x68123086ccad0951 = new Rectangle (i1, ((int) (this.x256c9720723a7c14.Height / 2)), this.x256c9720723a7c14.Width, ((int) (this.x256c9720723a7c14.Height / 2)));
			}
			
		#endregion
	}
	
}

