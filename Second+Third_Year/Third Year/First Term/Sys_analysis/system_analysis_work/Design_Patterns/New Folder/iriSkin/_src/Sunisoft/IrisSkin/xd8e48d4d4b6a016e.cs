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
			using System.Drawing.Drawing2D;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class xd8e48d4d4b6a016e : x2edc3f693fe78d2e
	
	{
		
		#region Fields
			private StringFormat x5786461d089b10a0;
			private const int xc2b2889221bc8c5e = 20;
		#endregion
		
		#region Constructors
		
			public xd8e48d4d4b6a016e (Control control, ISkinEngine engine)
				 : base (control, engine)
			/*
				// Code Size: 48 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ldarg.0 
				L_0009: newobj System.Drawing.StringFormat::Void .ctor()
				L_000e: stfld Sunisoft.IrisSkin.xd8e48d4d4b6a016e::System.Drawing.StringFormat x5786461d089b10a0
				L_0013: ldarg.0 
				L_0014: ldfld Sunisoft.IrisSkin.xd8e48d4d4b6a016e::System.Drawing.StringFormat x5786461d089b10a0
				L_0019: ldc.i4.1 
				L_001a: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_001f: ldarg.0 
				L_0020: ldfld Sunisoft.IrisSkin.xd8e48d4d4b6a016e::System.Drawing.StringFormat x5786461d089b10a0
				L_0025: ldc.i4 8192
				L_002a: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_002f: ret 
			*/
		#endregion
		
		#region Properties
		
			protected override bool CanScroll
			
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
		
			protected override bool BeforeWndProc (ref Message m)
			
			/*
				// Code Size: 75 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT V_0, 
         System.UInt32 V_1)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0006: stloc.1 
				L_0007: ldloc.1 
				L_0008: ldc.i4.s 15
				L_000a: beq.s L_0013
				L_000c: ldloc.1 
				L_000d: ldc.i4.s 20
				L_000f: beq.s L_0041
				L_0011: br.s L_0043
				L_0013: ldarg.0 
				L_0014: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0019: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_001e: ldloca.s V_0
				L_0020: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr BeginPaint(IntPtr, PAINTSTRUCT ByRef)
				L_0025: pop 
				L_0026: ldarg.0 
				L_0027: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_002c: ldarg.0 
				L_002d: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0032: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0037: ldloca.s V_0
				L_0039: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean EndPaint(IntPtr, PAINTSTRUCT ByRef)
				L_003e: pop 
				L_003f: br.s L_0043
				L_0041: ldc.i4.0 
				L_0042: ret 
				L_0043: ldarg.0 
				L_0044: ldarg.1 
				L_0045: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_004a: ret 
			*/
			
			
			{
				x40255b11ef821fa3.PAINTSTRUCT pAINTSTRUCT1;
				uint uInt32_1 = ((uint) m.Msg);
				if (uInt32_1 != 15)
				{
					if (uInt32_1 == 20)
					{
						return false;
					}
					else
					{
						return base.BeforeWndProc (ref m);
					}
				}
				IntPtr intPtr1 = x61467fe65a98f20c.BeginPaint (base.xcd9cdf30888d2204.Handle, out pAINTSTRUCT1);
				this.PaintControl ();
				bool b1 = x61467fe65a98f20c.EndPaint (base.xcd9cdf30888d2204.Handle, ref pAINTSTRUCT1);
				return base.BeforeWndProc (ref m);
			}
			
			protected override void PaintControl ()
			
			/*
				// Code Size: 1199 Bytes
				.maxstack 8
				.locals (System.Windows.Forms.ComboBox V_0, 
         System.Drawing.Rectangle V_1, 
         System.IntPtr V_2, 
         System.Drawing.Graphics V_3, 
         System.Drawing.Brush V_4, 
         System.Drawing.Brush V_5, 
         System.Drawing.Brush V_6, 
         System.Drawing.Pen V_7, 
         System.Drawing.Brush V_8, 
         System.Drawing.Pen V_9, 
         System.Drawing.Bitmap V_10, 
         System.Drawing.Graphics V_11, 
         System.Drawing.StringFormat V_12, 
         System.Drawing.Rectangle V_13, 
         System.Drawing.Brush V_14, 
         System.Drawing.Pen V_15, 
         System.Drawing.Brush V_16, 
         System.Drawing.Brush V_17, 
         System.Drawing.Rectangle V_18)
				.try L_00a3 to L_00b1 finally L_00b1 to L_00bd
				.try L_00ca to L_00d8 finally L_00d8 to L_00e4
				.try L_014b to L_01bf finally L_01bf to L_01cb
				.try L_013d to L_01d0 finally L_01d0 to L_01dc
				.try L_01f7 to L_026b finally L_026b to L_0277
				.try L_01e9 to L_0279 finally L_0279 to L_0285
				.try L_02ab to L_02b5 finally L_02b5 to L_02c1
				.try L_02a2 to L_02cd finally L_02cd to L_02d9
				.try L_03c4 to L_03d0 finally L_03d0 to L_03dc
				.try L_03e8 to L_041a finally L_041a to L_0426
				.try L_0434 to L_0452 finally L_0452 to L_045e
				.try L_046b to L_0489 finally L_0489 to L_0495
				.try L_0080 to L_0497 finally L_0497 to L_04a1
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_000b: stloc.s V_18
				L_000d: ldloca.s V_18
				L_000f: call System.Drawing.Rectangle::Int32 get_Width()
				L_0014: ldc.i4.0 
				L_0015: ble.s L_002e
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001d: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0022: stloc.s V_18
				L_0024: ldloca.s V_18
				L_0026: call System.Drawing.Rectangle::Int32 get_Height()
				L_002b: ldc.i4.0 
				L_002c: bgt.s L_002f
				L_002e: ret 
				L_002f: ldarg.0 
				L_0030: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0035: brtrue.s L_0038
				L_0037: ret 
				L_0038: ldarg.0 
				L_0039: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_003e: castclass System.Windows.Forms.ComboBox
				L_0043: stloc.0 
				L_0044: ldloca.s V_1
				L_0046: ldc.i4.0 
				L_0047: ldc.i4.0 
				L_0048: ldloc.0 
				L_0049: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_004e: ldloc.0 
				L_004f: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0054: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0059: ldloc.0 
				L_005a: callvirt System.Windows.Forms.ComboBox::System.Windows.Forms.ComboBoxStyle get_DropDownStyle()
				L_005f: brtrue.s L_0068
				L_0061: ldarg.0 
				L_0062: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void PaintControl()
				L_0067: ret 
				L_0068: ldarg.0 
				L_0069: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_006e: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0073: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindowDC(IntPtr)
				L_0078: stloc.2 
				L_0079: ldloc.2 
				L_007a: call System.Drawing.Graphics::System.Drawing.Graphics FromHdc(IntPtr)
				L_007f: stloc.3 
				L_0080: ldloc.0 
				L_0081: callvirt System.Windows.Forms.ComboBox::System.Windows.Forms.ComboBoxStyle get_DropDownStyle()
				L_0086: ldc.i4.2 
				L_0087: bne.un.s L_00e4
				L_0089: ldloc.0 
				L_008a: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_008f: brfalse.s L_00bd
				L_0091: ldarg.0 
				L_0092: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0097: callvirt System.Windows.Forms.Control::System.Drawing.Color get_BackColor()
				L_009c: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_00a1: stloc.s V_4
				L_00a3: ldloc.3 
				L_00a4: ldloc.s V_4
				L_00a6: ldloc.1 
				L_00a7: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_00ac: leave L_0285
				L_00b1: ldloc.s V_4
				L_00b3: brfalse.s L_00bc
				L_00b5: ldloc.s V_4
				L_00b7: callvirt System.IDisposable::Void Dispose()
				L_00bc: endfinally 
				L_00bd: ldc.i4.5 
				L_00be: call System.Drawing.Color::System.Drawing.Color FromKnownColor(System.Drawing.KnownColor)
				L_00c3: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_00c8: stloc.s V_5
				L_00ca: ldloc.3 
				L_00cb: ldloc.s V_5
				L_00cd: ldloc.1 
				L_00ce: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_00d3: leave L_0285
				L_00d8: ldloc.s V_5
				L_00da: brfalse.s L_00e3
				L_00dc: ldloc.s V_5
				L_00de: callvirt System.IDisposable::Void Dispose()
				L_00e3: endfinally 
				L_00e4: ldloca.s V_1
				L_00e6: dup 
				L_00e7: call System.Drawing.Rectangle::Int32 get_Height()
				L_00ec: ldc.i4.4 
				L_00ed: sub 
				L_00ee: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_00f3: ldloca.s V_1
				L_00f5: dup 
				L_00f6: call System.Drawing.Rectangle::Int32 get_Width()
				L_00fb: ldc.i4.4 
				L_00fc: sub 
				L_00fd: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0102: ldloca.s V_1
				L_0104: dup 
				L_0105: call System.Drawing.Rectangle::Int32 get_X()
				L_010a: ldc.i4.2 
				L_010b: add 
				L_010c: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0111: ldloca.s V_1
				L_0113: dup 
				L_0114: call System.Drawing.Rectangle::Int32 get_Y()
				L_0119: ldc.i4.2 
				L_011a: add 
				L_011b: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_0120: ldloc.0 
				L_0121: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_0126: brfalse L_01dc
				L_012b: ldarg.0 
				L_012c: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0131: callvirt System.Windows.Forms.Control::System.Drawing.Color get_BackColor()
				L_0136: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_013b: stloc.s V_6
				L_013d: ldloc.s V_6
				L_013f: ldc.r4 2
				L_0144: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush, Single)
				L_0149: stloc.s V_7
				L_014b: ldloc.3 
				L_014c: ldloc.s V_7
				L_014e: ldloc.1 
				L_014f: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_0154: ldloc.0 
				L_0155: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_015a: ldc.i4.1 
				L_015b: and 
				L_015c: ldc.i4.1 
				L_015d: bne.un.s L_018f
				L_015f: ldloc.3 
				L_0160: ldloc.s V_7
				L_0162: ldloca.s V_1
				L_0164: call System.Drawing.Rectangle::Int32 get_Left()
				L_0169: ldc.i4.s 20
				L_016b: add 
				L_016c: ldc.i4.3 
				L_016d: sub 
				L_016e: ldloca.s V_1
				L_0170: call System.Drawing.Rectangle::Int32 get_Top()
				L_0175: ldloca.s V_1
				L_0177: call System.Drawing.Rectangle::Int32 get_Left()
				L_017c: ldc.i4.s 20
				L_017e: add 
				L_017f: ldc.i4.3 
				L_0180: sub 
				L_0181: ldloca.s V_1
				L_0183: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0188: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_018d: br.s L_01bd
				L_018f: ldloc.3 
				L_0190: ldloc.s V_7
				L_0192: ldloca.s V_1
				L_0194: call System.Drawing.Rectangle::Int32 get_Right()
				L_0199: ldc.i4.s 20
				L_019b: sub 
				L_019c: ldc.i4.3 
				L_019d: add 
				L_019e: ldloca.s V_1
				L_01a0: call System.Drawing.Rectangle::Int32 get_Top()
				L_01a5: ldloca.s V_1
				L_01a7: call System.Drawing.Rectangle::Int32 get_Right()
				L_01ac: ldc.i4.s 20
				L_01ae: sub 
				L_01af: ldc.i4.3 
				L_01b0: add 
				L_01b1: ldloca.s V_1
				L_01b3: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_01b8: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_01bd: leave.s L_01cb
				L_01bf: ldloc.s V_7
				L_01c1: brfalse.s L_01ca
				L_01c3: ldloc.s V_7
				L_01c5: callvirt System.IDisposable::Void Dispose()
				L_01ca: endfinally 
				L_01cb: leave L_0285
				L_01d0: ldloc.s V_6
				L_01d2: brfalse.s L_01db
				L_01d4: ldloc.s V_6
				L_01d6: callvirt System.IDisposable::Void Dispose()
				L_01db: endfinally 
				L_01dc: ldc.i4.5 
				L_01dd: call System.Drawing.Color::System.Drawing.Color FromKnownColor(System.Drawing.KnownColor)
				L_01e2: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_01e7: stloc.s V_8
				L_01e9: ldloc.s V_8
				L_01eb: ldc.r4 2
				L_01f0: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush, Single)
				L_01f5: stloc.s V_9
				L_01f7: ldloc.3 
				L_01f8: ldloc.s V_9
				L_01fa: ldloc.1 
				L_01fb: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_0200: ldloc.0 
				L_0201: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_0206: ldc.i4.1 
				L_0207: and 
				L_0208: ldc.i4.1 
				L_0209: bne.un.s L_023b
				L_020b: ldloc.3 
				L_020c: ldloc.s V_9
				L_020e: ldloca.s V_1
				L_0210: call System.Drawing.Rectangle::Int32 get_Left()
				L_0215: ldc.i4.s 20
				L_0217: add 
				L_0218: ldc.i4.3 
				L_0219: sub 
				L_021a: ldloca.s V_1
				L_021c: call System.Drawing.Rectangle::Int32 get_Top()
				L_0221: ldloca.s V_1
				L_0223: call System.Drawing.Rectangle::Int32 get_Left()
				L_0228: ldc.i4.s 20
				L_022a: add 
				L_022b: ldc.i4.3 
				L_022c: sub 
				L_022d: ldloca.s V_1
				L_022f: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0234: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0239: br.s L_0269
				L_023b: ldloc.3 
				L_023c: ldloc.s V_9
				L_023e: ldloca.s V_1
				L_0240: call System.Drawing.Rectangle::Int32 get_Right()
				L_0245: ldc.i4.s 20
				L_0247: sub 
				L_0248: ldc.i4.3 
				L_0249: add 
				L_024a: ldloca.s V_1
				L_024c: call System.Drawing.Rectangle::Int32 get_Top()
				L_0251: ldloca.s V_1
				L_0253: call System.Drawing.Rectangle::Int32 get_Right()
				L_0258: ldc.i4.s 20
				L_025a: sub 
				L_025b: ldc.i4.3 
				L_025c: add 
				L_025d: ldloca.s V_1
				L_025f: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0264: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0269: leave.s L_0277
				L_026b: ldloc.s V_9
				L_026d: brfalse.s L_0276
				L_026f: ldloc.s V_9
				L_0271: callvirt System.IDisposable::Void Dispose()
				L_0276: endfinally 
				L_0277: leave.s L_0285
				L_0279: ldloc.s V_8
				L_027b: brfalse.s L_0284
				L_027d: ldloc.s V_8
				L_027f: callvirt System.IDisposable::Void Dispose()
				L_0284: endfinally 
				L_0285: ldarg.0 
				L_0286: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_028b: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0290: ldarg.0 
				L_0291: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0296: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_029b: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_02a0: stloc.s V_10
				L_02a2: ldloc.s V_10
				L_02a4: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_02a9: stloc.s V_11
				L_02ab: ldarg.0 
				L_02ac: ldloc.s V_11
				L_02ae: call Sunisoft.IrisSkin.xd8e48d4d4b6a016e::Void x8bc95f030953f87b(System.Drawing.Graphics)
				L_02b3: leave.s L_02c1
				L_02b5: ldloc.s V_11
				L_02b7: brfalse.s L_02c0
				L_02b9: ldloc.s V_11
				L_02bb: callvirt System.IDisposable::Void Dispose()
				L_02c0: endfinally 
				L_02c1: ldloc.3 
				L_02c2: ldloc.s V_10
				L_02c4: ldc.i4.0 
				L_02c5: ldc.i4.0 
				L_02c6: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_02cb: leave.s L_02d9
				L_02cd: ldloc.s V_10
				L_02cf: brfalse.s L_02d8
				L_02d1: ldloc.s V_10
				L_02d3: callvirt System.IDisposable::Void Dispose()
				L_02d8: endfinally 
				L_02d9: ldloc.0 
				L_02da: callvirt System.Windows.Forms.ComboBox::System.Windows.Forms.ComboBoxStyle get_DropDownStyle()
				L_02df: ldc.i4.2 
				L_02e0: bne.un L_0495
				L_02e5: newobj System.Drawing.StringFormat::Void .ctor()
				L_02ea: stloc.s V_12
				L_02ec: ldloc.s V_12
				L_02ee: ldc.i4.0 
				L_02ef: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_02f4: ldloc.0 
				L_02f5: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_02fa: ldc.i4.1 
				L_02fb: and 
				L_02fc: ldc.i4.1 
				L_02fd: bne.un.s L_032d
				L_02ff: ldloc.s V_12
				L_0301: ldc.i4 8193
				L_0306: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_030b: ldloca.s V_1
				L_030d: dup 
				L_030e: call System.Drawing.Rectangle::Int32 get_X()
				L_0313: ldc.i4.s 20
				L_0315: add 
				L_0316: call System.Drawing.Rectangle::Void set_X(Int32)
				L_031b: ldloca.s V_1
				L_031d: dup 
				L_031e: call System.Drawing.Rectangle::Int32 get_Width()
				L_0323: ldc.i4.s 20
				L_0325: sub 
				L_0326: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_032b: br.s L_0358
				L_032d: ldloc.s V_12
				L_032f: ldc.i4 8192
				L_0334: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_0339: ldloca.s V_1
				L_033b: dup 
				L_033c: call System.Drawing.Rectangle::Int32 get_X()
				L_0341: ldc.i4.2 
				L_0342: add 
				L_0343: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0348: ldloca.s V_1
				L_034a: dup 
				L_034b: call System.Drawing.Rectangle::Int32 get_Width()
				L_0350: ldc.i4.s 20
				L_0352: sub 
				L_0353: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0358: ldloc.s V_12
				L_035a: ldc.i4.1 
				L_035b: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_0360: ldloc.0 
				L_0361: callvirt System.Windows.Forms.Control::Boolean get_Focused()
				L_0366: brfalse L_045e
				L_036b: ldloc.0 
				L_036c: callvirt System.Windows.Forms.ListControl::Int32 get_SelectedIndex()
				L_0371: ldc.i4.m1 
				L_0372: beq L_045e
				L_0377: ldloc.1 
				L_0378: stloc.s V_13
				L_037a: ldloca.s V_13
				L_037c: dup 
				L_037d: call System.Drawing.Rectangle::Int32 get_X()
				L_0382: ldc.i4.1 
				L_0383: add 
				L_0384: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0389: ldloca.s V_13
				L_038b: dup 
				L_038c: call System.Drawing.Rectangle::Int32 get_Width()
				L_0391: ldc.i4.3 
				L_0392: sub 
				L_0393: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0398: ldloca.s V_13
				L_039a: dup 
				L_039b: call System.Drawing.Rectangle::Int32 get_Y()
				L_03a0: ldc.i4.3 
				L_03a1: add 
				L_03a2: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_03a7: ldloca.s V_13
				L_03a9: dup 
				L_03aa: call System.Drawing.Rectangle::Int32 get_Height()
				L_03af: ldc.i4.6 
				L_03b0: sub 
				L_03b1: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_03b6: ldc.i4.s 13
				L_03b8: call System.Drawing.Color::System.Drawing.Color FromKnownColor(System.Drawing.KnownColor)
				L_03bd: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_03c2: stloc.s V_14
				L_03c4: ldloc.3 
				L_03c5: ldloc.s V_14
				L_03c7: ldloc.s V_13
				L_03c9: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_03ce: leave.s L_03dc
				L_03d0: ldloc.s V_14
				L_03d2: brfalse.s L_03db
				L_03d4: ldloc.s V_14
				L_03d6: callvirt System.IDisposable::Void Dispose()
				L_03db: endfinally 
				L_03dc: call System.Drawing.Color::System.Drawing.Color get_Black()
				L_03e1: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_03e6: stloc.s V_15
				L_03e8: ldloca.s V_13
				L_03ea: dup 
				L_03eb: call System.Drawing.Rectangle::Int32 get_Width()
				L_03f0: ldc.i4.1 
				L_03f1: sub 
				L_03f2: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_03f7: ldloca.s V_13
				L_03f9: dup 
				L_03fa: call System.Drawing.Rectangle::Int32 get_Height()
				L_03ff: ldc.i4.1 
				L_0400: sub 
				L_0401: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_0406: ldloc.s V_15
				L_0408: ldc.i4.2 
				L_0409: callvirt System.Drawing.Pen::Void set_DashStyle(System.Drawing.Drawing2D.DashStyle)
				L_040e: ldloc.3 
				L_040f: ldloc.s V_15
				L_0411: ldloc.s V_13
				L_0413: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_0418: leave.s L_0426
				L_041a: ldloc.s V_15
				L_041c: brfalse.s L_0425
				L_041e: ldloc.s V_15
				L_0420: callvirt System.IDisposable::Void Dispose()
				L_0425: endfinally 
				L_0426: ldc.i4.s 14
				L_0428: call System.Drawing.Color::System.Drawing.Color FromKnownColor(System.Drawing.KnownColor)
				L_042d: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0432: stloc.s V_16
				L_0434: ldloc.3 
				L_0435: ldloc.0 
				L_0436: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_043b: ldloc.0 
				L_043c: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_0441: ldloc.s V_16
				L_0443: ldloc.1 
				L_0444: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_0449: ldloc.s V_12
				L_044b: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_0450: leave.s L_0495
				L_0452: ldloc.s V_16
				L_0454: brfalse.s L_045d
				L_0456: ldloc.s V_16
				L_0458: callvirt System.IDisposable::Void Dispose()
				L_045d: endfinally 
				L_045e: ldloc.0 
				L_045f: callvirt System.Windows.Forms.Control::System.Drawing.Color get_ForeColor()
				L_0464: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0469: stloc.s V_17
				L_046b: ldloc.3 
				L_046c: ldloc.0 
				L_046d: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_0472: ldloc.0 
				L_0473: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_0478: ldloc.s V_17
				L_047a: ldloc.1 
				L_047b: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_0480: ldloc.s V_12
				L_0482: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_0487: leave.s L_0495
				L_0489: ldloc.s V_17
				L_048b: brfalse.s L_0494
				L_048d: ldloc.s V_17
				L_048f: callvirt System.IDisposable::Void Dispose()
				L_0494: endfinally 
				L_0495: leave.s L_04a1
				L_0497: ldloc.3 
				L_0498: brfalse.s L_04a0
				L_049a: ldloc.3 
				L_049b: callvirt System.IDisposable::Void Dispose()
				L_04a0: endfinally 
				L_04a1: ldarg.0 
				L_04a2: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_04a7: ldloc.2 
				L_04a8: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_04ad: pop 
				L_04ae: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				StringFormat stringFormat1;
				Rectangle rectangle2;
				if (((base.xcd9cdf30888d2204.ClientRectangle.Width <= 0) || (base.xcd9cdf30888d2204.ClientRectangle.Height <= 0)) || (! base.xf2140268ef7ddbf7))
				{
					return;
				}
				ComboBox comboBox1 = ((ComboBox) base.xcd9cdf30888d2204);
				rectangle1 = new Rectangle (0, 0, comboBox1.Width, comboBox1.Height);
				if (comboBox1.DropDownStyle == ComboBoxStyle.Simple)
				{
					base.PaintControl ();
					return;
				}
				IntPtr intPtr1 = x61467fe65a98f20c.GetWindowDC (base.xcd9cdf30888d2204.Handle);
				using (Graphics graphics1 = Graphics.FromHdc (intPtr1))
				{
					if (comboBox1.DropDownStyle == ComboBoxStyle.DropDownList)
					{
						if (comboBox1.Enabled)
						{
							using (Brush brush1 = ((Brush) new SolidBrush (base.xcd9cdf30888d2204.BackColor)))
							{
								graphics1.FillRectangle (brush1, rectangle1);
								goto L_0285;
							}
						}
						else
						{
							using (Brush brush2 = ((Brush) new SolidBrush (Color.FromKnownColor (KnownColor.Control))))
							{
								graphics1.FillRectangle (brush2, rectangle1);
								goto L_0285;
							}
						}
					}
					rectangle1.Height -= 4;
					rectangle1.Width -= 4;
					rectangle1.X += 2;
					rectangle1.Y += 2;
					if (comboBox1.Enabled)
					{
						using (Brush brush3 = ((Brush) new SolidBrush (base.xcd9cdf30888d2204.BackColor)))
						{
							using (Pen pen1 = new Pen (brush3, 2F))
							{
								graphics1.DrawRectangle (pen1, rectangle1);
								if ((comboBox1.RightToLeft & RightToLeft.Yes) == RightToLeft.Yes)
								{
									graphics1.DrawLine (pen1, ((int) ((rectangle1.Left + 20) - 3)), rectangle1.Top, ((int) ((rectangle1.Left + 20) - 3)), rectangle1.Bottom);
								}
								else
								{
									graphics1.DrawLine (pen1, ((int) ((rectangle1.Right - 20) + 3)), rectangle1.Top, ((int) ((rectangle1.Right - 20) + 3)), rectangle1.Bottom);
								}
							}
							goto L_0285;
						}
					}
					using (Brush brush4 = ((Brush) new SolidBrush (Color.FromKnownColor (KnownColor.Control))))
					{
						using (Pen pen2 = new Pen (brush4, 2F))
						{
							graphics1.DrawRectangle (pen2, rectangle1);
							if ((comboBox1.RightToLeft & RightToLeft.Yes) == RightToLeft.Yes)
							{
								graphics1.DrawLine (pen2, ((int) ((rectangle1.Left + 20) - 3)), rectangle1.Top, ((int) ((rectangle1.Left + 20) - 3)), rectangle1.Bottom);
							}
							else
							{
								graphics1.DrawLine (pen2, ((int) ((rectangle1.Right - 20) + 3)), rectangle1.Top, ((int) ((rectangle1.Right - 20) + 3)), rectangle1.Bottom);
							}
						}
					}
					
				L_0285:
					
					{
					}
					using (Bitmap bitmap1 = new Bitmap (base.xcd9cdf30888d2204.Width, base.xcd9cdf30888d2204.Height))
					{
						using (Graphics graphics2 = Graphics.FromImage (((Image) bitmap1)))
						{
							this.x8bc95f030953f87b (graphics2);
						}
						graphics1.DrawImageUnscaled (((Image) bitmap1), 0, 0);
					}
					if (comboBox1.DropDownStyle == ComboBoxStyle.DropDownList)
					{
						stringFormat1 = new StringFormat ();
						stringFormat1.Alignment = StringAlignment.Near;
						if ((comboBox1.RightToLeft & RightToLeft.Yes) == RightToLeft.Yes)
						{
							stringFormat1.FormatFlags = (StringFormatFlags.DirectionRightToLeft | StringFormatFlags.LineLimit);
							rectangle1.X += 20;
							rectangle1.Width -= 20;
						}
						else
						{
							stringFormat1.FormatFlags = StringFormatFlags.LineLimit;
							rectangle1.X += 2;
							rectangle1.Width -= 20;
						}
						stringFormat1.LineAlignment = StringAlignment.Center;
						if (comboBox1.Focused && (comboBox1.SelectedIndex != -1))
						{
							rectangle2 = rectangle1;
							rectangle2.X++;
							rectangle2.Width -= 3;
							rectangle2.Y += 3;
							rectangle2.Height -= 6;
							using (Brush brush5 = ((Brush) new SolidBrush (Color.FromKnownColor (KnownColor.Highlight))))
							{
								graphics1.FillRectangle (brush5, rectangle2);
							}
							using (Pen pen3 = new Pen (Color.Black))
							{
								rectangle2.Width--;
								rectangle2.Height--;
								pen3.DashStyle = DashStyle.Dot;
								graphics1.DrawRectangle (pen3, rectangle2);
							}
							using (Brush brush6 = ((Brush) new SolidBrush (Color.FromKnownColor (KnownColor.HighlightText))))
							{
								graphics1.DrawString (comboBox1.Text, comboBox1.Font, brush6, ((RectangleF) rectangle1), stringFormat1);
								goto L_0495;
							}
						}
						else
						{
							using (Brush brush7 = ((Brush) new SolidBrush (comboBox1.ForeColor)))
							{
								graphics1.DrawString (comboBox1.Text, comboBox1.Font, brush7, ((RectangleF) rectangle1), stringFormat1);
							}
						}
					}
					
				L_0495:
					
					{
					}
				}
				int i1 = x61467fe65a98f20c.ReleaseDC (base.Handle, intPtr1);
			}
			
			private void x7be4a5b4e2519d4d ()
			
			/*
				// Code Size: 621 Bytes
				.maxstack 7
				.locals (System.Windows.Forms.ComboBox V_0, 
         System.IntPtr V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Graphics V_3, 
         System.Drawing.Brush V_4, 
         System.Drawing.Brush V_5, 
         System.Drawing.Brush V_6, 
         System.Drawing.Pen V_7, 
         System.Drawing.Brush V_8, 
         System.Drawing.Pen V_9, 
         System.Drawing.StringFormat V_10, 
         System.Drawing.Brush V_11, 
         System.Drawing.Rectangle V_12)
				.try L_0094 to L_00a2 finally L_00a2 to L_00ae
				.try L_00bb to L_00c9 finally L_00c9 to L_00d5
				.try L_0139 to L_0147 finally L_0147 to L_0153
				.try L_012b to L_0155 finally L_0155 to L_0161
				.try L_017c to L_018a finally L_018a to L_0196
				.try L_016e to L_0198 finally L_0198 to L_01a4
				.try L_0229 to L_0247 finally L_0247 to L_0253
				.try L_0071 to L_0255 finally L_0255 to L_025f
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_000b: stloc.s V_12
				L_000d: ldloca.s V_12
				L_000f: call System.Drawing.Rectangle::Int32 get_Width()
				L_0014: ldc.i4.0 
				L_0015: ble.s L_002e
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001d: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0022: stloc.s V_12
				L_0024: ldloca.s V_12
				L_0026: call System.Drawing.Rectangle::Int32 get_Height()
				L_002b: ldc.i4.0 
				L_002c: bgt.s L_002f
				L_002e: ret 
				L_002f: ldarg.0 
				L_0030: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0035: castclass System.Windows.Forms.ComboBox
				L_003a: stloc.0 
				L_003b: ldloc.0 
				L_003c: callvirt System.Windows.Forms.ComboBox::System.Windows.Forms.ComboBoxStyle get_DropDownStyle()
				L_0041: brtrue.s L_0044
				L_0043: ret 
				L_0044: ldarg.0 
				L_0045: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_004a: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_004f: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindowDC(IntPtr)
				L_0054: stloc.1 
				L_0055: ldloca.s V_2
				L_0057: ldc.i4.0 
				L_0058: ldc.i4.0 
				L_0059: ldloc.0 
				L_005a: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_005f: ldloc.0 
				L_0060: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0065: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_006a: ldloc.1 
				L_006b: call System.Drawing.Graphics::System.Drawing.Graphics FromHdc(IntPtr)
				L_0070: stloc.3 
				L_0071: ldloc.0 
				L_0072: callvirt System.Windows.Forms.ComboBox::System.Windows.Forms.ComboBoxStyle get_DropDownStyle()
				L_0077: ldc.i4.2 
				L_0078: bne.un.s L_00d5
				L_007a: ldloc.0 
				L_007b: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_0080: brfalse.s L_00ae
				L_0082: ldarg.0 
				L_0083: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0088: callvirt System.Windows.Forms.Control::System.Drawing.Color get_BackColor()
				L_008d: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0092: stloc.s V_4
				L_0094: ldloc.3 
				L_0095: ldloc.s V_4
				L_0097: ldloc.2 
				L_0098: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_009d: leave L_01a4
				L_00a2: ldloc.s V_4
				L_00a4: brfalse.s L_00ad
				L_00a6: ldloc.s V_4
				L_00a8: callvirt System.IDisposable::Void Dispose()
				L_00ad: endfinally 
				L_00ae: ldc.i4.5 
				L_00af: call System.Drawing.Color::System.Drawing.Color FromKnownColor(System.Drawing.KnownColor)
				L_00b4: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_00b9: stloc.s V_5
				L_00bb: ldloc.3 
				L_00bc: ldloc.s V_5
				L_00be: ldloc.2 
				L_00bf: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_00c4: leave L_01a4
				L_00c9: ldloc.s V_5
				L_00cb: brfalse.s L_00d4
				L_00cd: ldloc.s V_5
				L_00cf: callvirt System.IDisposable::Void Dispose()
				L_00d4: endfinally 
				L_00d5: ldloca.s V_2
				L_00d7: dup 
				L_00d8: call System.Drawing.Rectangle::Int32 get_Height()
				L_00dd: ldc.i4.4 
				L_00de: sub 
				L_00df: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_00e4: ldloca.s V_2
				L_00e6: dup 
				L_00e7: call System.Drawing.Rectangle::Int32 get_Width()
				L_00ec: ldc.i4.4 
				L_00ed: sub 
				L_00ee: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_00f3: ldloca.s V_2
				L_00f5: dup 
				L_00f6: call System.Drawing.Rectangle::Int32 get_X()
				L_00fb: ldc.i4.2 
				L_00fc: add 
				L_00fd: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0102: ldloca.s V_2
				L_0104: dup 
				L_0105: call System.Drawing.Rectangle::Int32 get_Y()
				L_010a: ldc.i4.2 
				L_010b: add 
				L_010c: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_0111: ldloc.0 
				L_0112: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_0117: brfalse.s L_0161
				L_0119: ldarg.0 
				L_011a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_011f: callvirt System.Windows.Forms.Control::System.Drawing.Color get_BackColor()
				L_0124: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0129: stloc.s V_6
				L_012b: ldloc.s V_6
				L_012d: ldc.r4 2
				L_0132: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush, Single)
				L_0137: stloc.s V_7
				L_0139: ldloc.3 
				L_013a: call System.Drawing.Pens::System.Drawing.Pen get_Red()
				L_013f: ldloc.2 
				L_0140: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_0145: leave.s L_0153
				L_0147: ldloc.s V_7
				L_0149: brfalse.s L_0152
				L_014b: ldloc.s V_7
				L_014d: callvirt System.IDisposable::Void Dispose()
				L_0152: endfinally 
				L_0153: leave.s L_01a4
				L_0155: ldloc.s V_6
				L_0157: brfalse.s L_0160
				L_0159: ldloc.s V_6
				L_015b: callvirt System.IDisposable::Void Dispose()
				L_0160: endfinally 
				L_0161: ldc.i4.5 
				L_0162: call System.Drawing.Color::System.Drawing.Color FromKnownColor(System.Drawing.KnownColor)
				L_0167: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_016c: stloc.s V_8
				L_016e: ldloc.s V_8
				L_0170: ldc.r4 2
				L_0175: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush, Single)
				L_017a: stloc.s V_9
				L_017c: ldloc.3 
				L_017d: call System.Drawing.Pens::System.Drawing.Pen get_Red()
				L_0182: ldloc.2 
				L_0183: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_0188: leave.s L_0196
				L_018a: ldloc.s V_9
				L_018c: brfalse.s L_0195
				L_018e: ldloc.s V_9
				L_0190: callvirt System.IDisposable::Void Dispose()
				L_0195: endfinally 
				L_0196: leave.s L_01a4
				L_0198: ldloc.s V_8
				L_019a: brfalse.s L_01a3
				L_019c: ldloc.s V_8
				L_019e: callvirt System.IDisposable::Void Dispose()
				L_01a3: endfinally 
				L_01a4: ldloc.0 
				L_01a5: callvirt System.Windows.Forms.ComboBox::System.Windows.Forms.ComboBoxStyle get_DropDownStyle()
				L_01aa: ldc.i4.2 
				L_01ab: bne.un L_0253
				L_01b0: newobj System.Drawing.StringFormat::Void .ctor()
				L_01b5: stloc.s V_10
				L_01b7: ldloc.s V_10
				L_01b9: ldc.i4.0 
				L_01ba: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_01bf: ldloc.0 
				L_01c0: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_01c5: ldc.i4.1 
				L_01c6: and 
				L_01c7: ldc.i4.1 
				L_01c8: bne.un.s L_01f0
				L_01ca: ldloc.s V_10
				L_01cc: ldc.i4 8193
				L_01d1: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_01d6: ldloc.0 
				L_01d7: callvirt System.Windows.Forms.ComboBox::System.Windows.Forms.ComboBoxStyle get_DropDownStyle()
				L_01dc: ldc.i4.2 
				L_01dd: bne.un.s L_0214
				L_01df: ldloca.s V_2
				L_01e1: dup 
				L_01e2: call System.Drawing.Rectangle::Int32 get_Width()
				L_01e7: ldc.i4.1 
				L_01e8: sub 
				L_01e9: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_01ee: br.s L_0214
				L_01f0: ldloc.s V_10
				L_01f2: ldc.i4 8192
				L_01f7: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_01fc: ldloc.0 
				L_01fd: callvirt System.Windows.Forms.ComboBox::System.Windows.Forms.ComboBoxStyle get_DropDownStyle()
				L_0202: ldc.i4.2 
				L_0203: bne.un.s L_0214
				L_0205: ldloca.s V_2
				L_0207: dup 
				L_0208: call System.Drawing.Rectangle::Int32 get_X()
				L_020d: ldc.i4.1 
				L_020e: add 
				L_020f: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0214: ldloc.s V_10
				L_0216: ldc.i4.1 
				L_0217: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_021c: ldloc.0 
				L_021d: callvirt System.Windows.Forms.Control::System.Drawing.Color get_ForeColor()
				L_0222: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0227: stloc.s V_11
				L_0229: ldloc.3 
				L_022a: ldloc.0 
				L_022b: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_0230: ldloc.0 
				L_0231: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_0236: ldloc.s V_11
				L_0238: ldloc.2 
				L_0239: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_023e: ldloc.s V_10
				L_0240: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_0245: leave.s L_0253
				L_0247: ldloc.s V_11
				L_0249: brfalse.s L_0252
				L_024b: ldloc.s V_11
				L_024d: callvirt System.IDisposable::Void Dispose()
				L_0252: endfinally 
				L_0253: leave.s L_025f
				L_0255: ldloc.3 
				L_0256: brfalse.s L_025e
				L_0258: ldloc.3 
				L_0259: callvirt System.IDisposable::Void Dispose()
				L_025e: endfinally 
				L_025f: ldarg.0 
				L_0260: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0265: ldloc.1 
				L_0266: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_026b: pop 
				L_026c: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				StringFormat stringFormat1;
				if ((base.xcd9cdf30888d2204.ClientRectangle.Width <= 0) || (base.xcd9cdf30888d2204.ClientRectangle.Height <= 0))
				{
					return;
				}
				ComboBox comboBox1 = ((ComboBox) base.xcd9cdf30888d2204);
				if (comboBox1.DropDownStyle == ComboBoxStyle.Simple)
				{
					return;
				}
				IntPtr intPtr1 = x61467fe65a98f20c.GetWindowDC (base.xcd9cdf30888d2204.Handle);
				rectangle1 = new Rectangle (0, 0, comboBox1.Width, comboBox1.Height);
				using (Graphics graphics1 = Graphics.FromHdc (intPtr1))
				{
					if (comboBox1.DropDownStyle == ComboBoxStyle.DropDownList)
					{
						if (comboBox1.Enabled)
						{
							using (Brush brush1 = ((Brush) new SolidBrush (base.xcd9cdf30888d2204.BackColor)))
							{
								graphics1.FillRectangle (brush1, rectangle1);
								goto L_01A4;
							}
						}
						else
						{
							using (Brush brush2 = ((Brush) new SolidBrush (Color.FromKnownColor (KnownColor.Control))))
							{
								graphics1.FillRectangle (brush2, rectangle1);
								goto L_01A4;
							}
						}
					}
					rectangle1.Height -= 4;
					rectangle1.Width -= 4;
					rectangle1.X += 2;
					rectangle1.Y += 2;
					if (comboBox1.Enabled)
					{
						using (Brush brush3 = ((Brush) new SolidBrush (base.xcd9cdf30888d2204.BackColor)))
						{
							using (Pen pen1 = new Pen (brush3, 2F))
							{
								graphics1.DrawRectangle (Pens.Red, rectangle1);
							}
							goto L_01A4;
						}
					}
					using (Brush brush4 = ((Brush) new SolidBrush (Color.FromKnownColor (KnownColor.Control))))
					{
						using (Pen pen2 = new Pen (brush4, 2F))
						{
							graphics1.DrawRectangle (Pens.Red, rectangle1);
						}
					}
					
				L_01A4:
					
					{
					}
					if (comboBox1.DropDownStyle == ComboBoxStyle.DropDownList)
					{
						stringFormat1 = new StringFormat ();
						stringFormat1.Alignment = StringAlignment.Near;
						if ((comboBox1.RightToLeft & RightToLeft.Yes) == RightToLeft.Yes)
						{
							stringFormat1.FormatFlags = (StringFormatFlags.DirectionRightToLeft | StringFormatFlags.LineLimit);
							if (comboBox1.DropDownStyle == ComboBoxStyle.DropDownList)
							{
								rectangle1.Width--;
							}
						}
						else
						{
							stringFormat1.FormatFlags = StringFormatFlags.LineLimit;
							if (comboBox1.DropDownStyle == ComboBoxStyle.DropDownList)
							{
								rectangle1.X++;
							}
						}
						stringFormat1.LineAlignment = StringAlignment.Center;
						using (Brush brush5 = ((Brush) new SolidBrush (comboBox1.ForeColor)))
						{
							graphics1.DrawString (comboBox1.Text, comboBox1.Font, brush5, ((RectangleF) rectangle1), stringFormat1);
						}
					}
				}
				int i1 = x61467fe65a98f20c.ReleaseDC (base.Handle, intPtr1);
			}
			
			private void x8bc95f030953f87b (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 349 Bytes
				.maxstack 7
				.locals (System.Windows.Forms.ComboBox V_0, 
         System.Drawing.Brush V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Pen V_3, 
         System.Drawing.Pen V_4)
				.try L_002e to L_005d finally L_005d to L_0067
				.try L_011b to L_0126 finally L_0126 to L_0132
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.ComboBox
				L_000b: stloc.0 
				L_000c: ldarg.0 
				L_000d: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0012: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0017: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_001c: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_CONTROLBORDERCOLOR()
				L_0021: stloc.1 
				L_0022: ldloc.1 
				L_0023: ldc.r4 1
				L_0028: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush, Single)
				L_002d: stloc.3 
				L_002e: ldloc.0 
				L_002f: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0034: stloc.2 
				L_0035: ldloca.s V_2
				L_0037: dup 
				L_0038: call System.Drawing.Rectangle::Int32 get_Width()
				L_003d: ldc.i4.1 
				L_003e: sub 
				L_003f: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0044: ldloca.s V_2
				L_0046: dup 
				L_0047: call System.Drawing.Rectangle::Int32 get_Height()
				L_004c: ldc.i4.1 
				L_004d: sub 
				L_004e: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_0053: ldarg.1 
				L_0054: ldloc.3 
				L_0055: ldloc.2 
				L_0056: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_005b: leave.s L_0067
				L_005d: ldloc.3 
				L_005e: brfalse.s L_0066
				L_0060: ldloc.3 
				L_0061: callvirt System.IDisposable::Void Dispose()
				L_0066: endfinally 
				L_0067: ldloc.0 
				L_0068: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_006d: ldc.i4.1 
				L_006e: and 
				L_006f: ldc.i4.1 
				L_0070: bne.un.s L_0085
				L_0072: ldloca.s V_2
				L_0074: ldc.i4.0 
				L_0075: ldc.i4.0 
				L_0076: ldc.i4.s 20
				L_0078: ldloc.0 
				L_0079: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_007e: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0083: br.s L_009e
				L_0085: ldloca.s V_2
				L_0087: ldloc.0 
				L_0088: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_008d: ldc.i4.s 20
				L_008f: sub 
				L_0090: ldc.i4.0 
				L_0091: ldc.i4.s 20
				L_0093: ldloc.0 
				L_0094: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0099: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_009e: ldloca.s V_2
				L_00a0: dup 
				L_00a1: call System.Drawing.Rectangle::Int32 get_X()
				L_00a6: ldc.i4.2 
				L_00a7: add 
				L_00a8: call System.Drawing.Rectangle::Void set_X(Int32)
				L_00ad: ldloca.s V_2
				L_00af: dup 
				L_00b0: call System.Drawing.Rectangle::Int32 get_Y()
				L_00b5: ldc.i4.2 
				L_00b6: add 
				L_00b7: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_00bc: ldloca.s V_2
				L_00be: dup 
				L_00bf: call System.Drawing.Rectangle::Int32 get_Width()
				L_00c4: ldc.i4.5 
				L_00c5: sub 
				L_00c6: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_00cb: ldloca.s V_2
				L_00cd: dup 
				L_00ce: call System.Drawing.Rectangle::Int32 get_Height()
				L_00d3: ldc.i4.5 
				L_00d4: sub 
				L_00d5: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_00da: ldarg.0 
				L_00db: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00e0: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00e5: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_00ea: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_00ef: stloc.1 
				L_00f0: ldarg.1 
				L_00f1: ldloc.1 
				L_00f2: ldloc.2 
				L_00f3: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_00f8: ldarg.0 
				L_00f9: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00fe: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0103: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0108: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_CONTROLBORDERCOLOR()
				L_010d: stloc.1 
				L_010e: ldloc.1 
				L_010f: ldc.r4 1
				L_0114: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush, Single)
				L_0119: stloc.s V_4
				L_011b: ldarg.1 
				L_011c: ldloc.s V_4
				L_011e: ldloc.2 
				L_011f: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_0124: leave.s L_0132
				L_0126: ldloc.s V_4
				L_0128: brfalse.s L_0131
				L_012a: ldloc.s V_4
				L_012c: callvirt System.IDisposable::Void Dispose()
				L_0131: endfinally 
				L_0132: ldarg.1 
				L_0133: ldloca.s V_2
				L_0135: call System.Drawing.Rectangle::Int32 get_X()
				L_013a: ldc.i4.s 10
				L_013c: add 
				L_013d: ldc.i4.5 
				L_013e: sub 
				L_013f: ldloca.s V_2
				L_0141: call System.Drawing.Rectangle::Int32 get_Y()
				L_0146: ldloc.0 
				L_0147: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_014c: ldc.i4.2 
				L_014d: div 
				L_014e: add 
				L_014f: ldc.i4.3 
				L_0150: sub 
				L_0151: ldloc.0 
				L_0152: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_0157: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x3fbffc8bcd27b3c0(System.Drawing.Graphics, Int32, Int32, Boolean)
				L_015c: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				ComboBox comboBox1 = ((ComboBox) base.xcd9cdf30888d2204);
				Brush brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_CONTROLBORDERCOLOR;
				using (Pen pen1 = new Pen (brush1, 1F))
				{
					rectangle1 = comboBox1.ClientRectangle;
					rectangle1.Width--;
					rectangle1.Height--;
					x4b101060f4767186.DrawRectangle (pen1, rectangle1);
				}
				if ((comboBox1.RightToLeft & RightToLeft.Yes) == RightToLeft.Yes)
				{
					rectangle1 = new Rectangle (0, 0, 20, comboBox1.Height);
				}
				else
				{
					rectangle1 = new Rectangle (((int) (comboBox1.Width - 20)), 0, 20, comboBox1.Height);
				}
				rectangle1.X += 2;
				rectangle1.Y += 2;
				rectangle1.Width -= 5;
				rectangle1.Height -= 5;
				brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR;
				x4b101060f4767186.FillRectangle (brush1, rectangle1);
				brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_CONTROLBORDERCOLOR;
				using (Pen pen2 = new Pen (brush1, 1F))
				{
					x4b101060f4767186.DrawRectangle (pen2, rectangle1);
				}
				x448fd9ab43628c71.x3fbffc8bcd27b3c0 (x4b101060f4767186, ((int) ((rectangle1.X + 10) - 5)), ((int) ((rectangle1.Y + (comboBox1.Height / 2)) - 3)), comboBox1.Enabled);
			}
			
		#endregion
	}
	
}

