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
			using System.Drawing.Text;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class x77a19d75b4e98e57 : xbd3f2493841f18a1
	
	{
		
		#region Fields
			private const int xfa432a34de1585b8 = 6;
		#endregion
		
		#region Constructors
		
			public x77a19d75b4e98e57 (Control control, ISkinEngine engine)
				 : base (control, engine)
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ret 
			*/
		#endregion
		
		#region Properties
		
			protected override bool ChangeFontColor
			
			{
				get
				
				/*
					// Code Size: 2 Bytes
					.maxstack 9
					L_0000: ldc.i4.1 
					L_0001: ret 
				*/
				
				{
					return true;
				}
			}
			
		#endregion
		
		#region Methods
		
			protected override void PaintControl ()
			
			/*
				// Code Size: 91 Bytes
				.maxstack 3
				.locals (System.Drawing.Graphics V_0, 
         System.Drawing.Rectangle V_1)
				.try L_0047 to L_0050 finally L_0050 to L_005a
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_000b: stloc.1 
				L_000c: ldloca.s V_1
				L_000e: call System.Drawing.Rectangle::Int32 get_Width()
				L_0013: ldc.i4.0 
				L_0014: ble.s L_002c
				L_0016: ldarg.0 
				L_0017: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001c: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0021: stloc.1 
				L_0022: ldloca.s V_1
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
				L_003c: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0041: call System.Drawing.Graphics::System.Drawing.Graphics FromHwnd(IntPtr)
				L_0046: stloc.0 
				L_0047: ldarg.0 
				L_0048: ldloc.0 
				L_0049: call Sunisoft.IrisSkin.x77a19d75b4e98e57::Void x8bc95f030953f87b(System.Drawing.Graphics)
				L_004e: leave.s L_005a
				L_0050: ldloc.0 
				L_0051: brfalse.s L_0059
				L_0053: ldloc.0 
				L_0054: callvirt System.IDisposable::Void Dispose()
				L_0059: endfinally 
				L_005a: ret 
			*/
			
			
			{
				if (((base.xcd9cdf30888d2204.ClientRectangle.Width > 0) && (base.xcd9cdf30888d2204.ClientRectangle.Height > 0)) && base.xf2140268ef7ddbf7)
				{
					using (Graphics graphics1 = Graphics.FromHwnd (base.xcd9cdf30888d2204.Handle))
					{
						this.x8bc95f030953f87b (graphics1);
					}
				}
			}
			
			private void x8bc95f030953f87b (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 772 Bytes
				.maxstack 10
				.locals (System.Windows.Forms.GroupBox V_0, 
         System.Drawing.StringFormat V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Brush V_3, 
         System.Drawing.Brush V_4, 
         System.Drawing.Pen V_5, 
         System.Drawing.SizeF V_6)
				.try L_00d7 to L_02f7 finally L_02f7 to L_0303
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.GroupBox
				L_000b: stloc.0 
				L_000c: newobj System.Drawing.StringFormat::Void .ctor()
				L_0011: stloc.1 
				L_0012: ldloc.1 
				L_0013: ldc.i4.0 
				L_0014: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_0019: ldloc.1 
				L_001a: ldc.i4.0 
				L_001b: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_0020: ldloc.1 
				L_0021: ldc.i4.1 
				L_0022: callvirt System.Drawing.StringFormat::Void set_HotkeyPrefix(System.Drawing.Text.HotkeyPrefix)
				L_0027: ldloca.s V_2
				L_0029: ldc.i4.0 
				L_002a: ldc.i4.0 
				L_002b: ldc.i4.0 
				L_002c: ldc.i4.0 
				L_002d: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0032: ldarg.0 
				L_0033: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0038: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_003d: ldloca.s V_2
				L_003f: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowRect(IntPtr, System.Drawing.Rectangle ByRef)
				L_0044: pop 
				L_0045: ldloca.s V_2
				L_0047: dup 
				L_0048: call System.Drawing.Rectangle::Int32 get_Width()
				L_004d: ldloca.s V_2
				L_004f: call System.Drawing.Rectangle::Int32 get_X()
				L_0054: sub 
				L_0055: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_005a: ldloca.s V_2
				L_005c: dup 
				L_005d: call System.Drawing.Rectangle::Int32 get_Height()
				L_0062: ldloca.s V_2
				L_0064: call System.Drawing.Rectangle::Int32 get_Y()
				L_0069: sub 
				L_006a: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_006f: ldloca.s V_2
				L_0071: ldc.i4.0 
				L_0072: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0077: ldloca.s V_2
				L_0079: ldc.i4.0 
				L_007a: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_007f: ldarg.0 
				L_0080: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0085: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_008a: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_008f: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_0094: stloc.3 
				L_0095: ldarg.0 
				L_0096: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_009b: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00a0: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_00a5: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_CONTROLFONTCOLOR()
				L_00aa: stloc.s V_4
				L_00ac: ldarg.1 
				L_00ad: ldloc.3 
				L_00ae: ldloc.2 
				L_00af: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_00b4: ldarg.0 
				L_00b5: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00ba: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00bf: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_00c4: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_CONTROLBORDERCOLOR()
				L_00c9: stloc.3 
				L_00ca: ldloc.3 
				L_00cb: ldc.r4 1
				L_00d0: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush, Single)
				L_00d5: stloc.s V_5
				L_00d7: ldloc.0 
				L_00d8: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_00dd: ldc.i4.1 
				L_00de: and 
				L_00df: ldc.i4.1 
				L_00e0: bne.un.s L_00f9
				L_00e2: ldloc.1 
				L_00e3: ldc.i4.2 
				L_00e4: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00e9: ldloc.1 
				L_00ea: dup 
				L_00eb: callvirt System.Drawing.StringFormat::System.Drawing.StringFormatFlags get_FormatFlags()
				L_00f0: ldc.i4.1 
				L_00f1: or 
				L_00f2: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_00f7: br.s L_0100
				L_00f9: ldloc.1 
				L_00fa: ldc.i4.0 
				L_00fb: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_0100: ldarg.1 
				L_0101: ldloc.0 
				L_0102: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_0107: ldloc.0 
				L_0108: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_010d: ldloc.0 
				L_010e: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0113: ldc.i4.s 12
				L_0115: sub 
				L_0116: ldloc.1 
				L_0117: callvirt System.Drawing.Graphics::System.Drawing.SizeF MeasureString(System.String, System.Drawing.Font, Int32, System.Drawing.StringFormat)
				L_011c: stloc.s V_6
				L_011e: ldloc.0 
				L_011f: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_0124: ldc.i4.1 
				L_0125: and 
				L_0126: ldc.i4.1 
				L_0127: bne.un L_01d7
				L_012c: ldarg.1 
				L_012d: ldloc.s V_5
				L_012f: ldloca.s V_2
				L_0131: call System.Drawing.Rectangle::Int32 get_X()
				L_0136: conv.r4 
				L_0137: ldloca.s V_2
				L_0139: call System.Drawing.Rectangle::Int32 get_Y()
				L_013e: ldc.i4.6 
				L_013f: add 
				L_0140: conv.r4 
				L_0141: ldloca.s V_2
				L_0143: call System.Drawing.Rectangle::Int32 get_Right()
				L_0148: ldc.i4.6 
				L_0149: sub 
				L_014a: conv.r4 
				L_014b: ldloca.s V_6
				L_014d: call System.Drawing.SizeF::Single get_Width()
				L_0152: sub 
				L_0153: ldloca.s V_2
				L_0155: call System.Drawing.Rectangle::Int32 get_Y()
				L_015a: ldc.i4.6 
				L_015b: add 
				L_015c: conv.r4 
				L_015d: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Single, Single, Single, Single)
				L_0162: ldarg.1 
				L_0163: ldloc.s V_5
				L_0165: ldloca.s V_2
				L_0167: call System.Drawing.Rectangle::Int32 get_Right()
				L_016c: ldc.i4.6 
				L_016d: sub 
				L_016e: ldc.i4.1 
				L_016f: sub 
				L_0170: ldloca.s V_2
				L_0172: call System.Drawing.Rectangle::Int32 get_Y()
				L_0177: ldc.i4.6 
				L_0178: add 
				L_0179: ldloca.s V_2
				L_017b: call System.Drawing.Rectangle::Int32 get_Width()
				L_0180: ldc.i4.1 
				L_0181: sub 
				L_0182: ldloca.s V_2
				L_0184: call System.Drawing.Rectangle::Int32 get_Y()
				L_0189: ldc.i4.6 
				L_018a: add 
				L_018b: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0190: ldarg.1 
				L_0191: ldloc.0 
				L_0192: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_0197: ldloc.0 
				L_0198: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_019d: ldloc.s V_4
				L_019f: ldloca.s V_2
				L_01a1: call System.Drawing.Rectangle::Int32 get_Right()
				L_01a6: ldc.i4.6 
				L_01a7: sub 
				L_01a8: conv.r4 
				L_01a9: ldloca.s V_6
				L_01ab: call System.Drawing.SizeF::Single get_Width()
				L_01b0: sub 
				L_01b1: ldloca.s V_2
				L_01b3: call System.Drawing.Rectangle::Int32 get_Top()
				L_01b8: conv.r4 
				L_01b9: ldloca.s V_6
				L_01bb: call System.Drawing.SizeF::Single get_Width()
				L_01c0: ldloca.s V_6
				L_01c2: call System.Drawing.SizeF::Single get_Height()
				L_01c7: newobj System.Drawing.RectangleF::Void .ctor(Single, Single, Single, Single)
				L_01cc: ldloc.1 
				L_01cd: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_01d2: br L_0277
				L_01d7: ldarg.1 
				L_01d8: ldloc.s V_5
				L_01da: ldloca.s V_2
				L_01dc: call System.Drawing.Rectangle::Int32 get_X()
				L_01e1: ldloca.s V_2
				L_01e3: call System.Drawing.Rectangle::Int32 get_Y()
				L_01e8: ldc.i4.6 
				L_01e9: add 
				L_01ea: ldloca.s V_2
				L_01ec: call System.Drawing.Rectangle::Int32 get_X()
				L_01f1: ldc.i4.6 
				L_01f2: add 
				L_01f3: ldc.i4.1 
				L_01f4: add 
				L_01f5: ldloca.s V_2
				L_01f7: call System.Drawing.Rectangle::Int32 get_Y()
				L_01fc: ldc.i4.6 
				L_01fd: add 
				L_01fe: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0203: ldarg.1 
				L_0204: ldloc.s V_5
				L_0206: ldloca.s V_2
				L_0208: call System.Drawing.Rectangle::Int32 get_Left()
				L_020d: ldc.i4.6 
				L_020e: add 
				L_020f: conv.r4 
				L_0210: ldloca.s V_6
				L_0212: call System.Drawing.SizeF::Single get_Width()
				L_0217: add 
				L_0218: ldloca.s V_2
				L_021a: call System.Drawing.Rectangle::Int32 get_Y()
				L_021f: ldc.i4.6 
				L_0220: add 
				L_0221: conv.r4 
				L_0222: ldloca.s V_2
				L_0224: call System.Drawing.Rectangle::Int32 get_Width()
				L_0229: ldc.i4.1 
				L_022a: sub 
				L_022b: conv.r4 
				L_022c: ldloca.s V_2
				L_022e: call System.Drawing.Rectangle::Int32 get_Y()
				L_0233: ldc.i4.6 
				L_0234: add 
				L_0235: conv.r4 
				L_0236: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Single, Single, Single, Single)
				L_023b: ldarg.1 
				L_023c: ldloc.0 
				L_023d: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_0242: ldloc.0 
				L_0243: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_0248: ldloc.s V_4
				L_024a: ldloca.s V_2
				L_024c: call System.Drawing.Rectangle::Int32 get_X()
				L_0251: ldc.i4.6 
				L_0252: add 
				L_0253: ldc.i4.1 
				L_0254: add 
				L_0255: conv.r4 
				L_0256: ldloca.s V_2
				L_0258: call System.Drawing.Rectangle::Int32 get_Top()
				L_025d: conv.r4 
				L_025e: ldloca.s V_6
				L_0260: call System.Drawing.SizeF::Single get_Width()
				L_0265: ldloca.s V_6
				L_0267: call System.Drawing.SizeF::Single get_Height()
				L_026c: newobj System.Drawing.RectangleF::Void .ctor(Single, Single, Single, Single)
				L_0271: ldloc.1 
				L_0272: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_0277: ldarg.1 
				L_0278: ldloc.s V_5
				L_027a: ldloca.s V_2
				L_027c: call System.Drawing.Rectangle::Int32 get_X()
				L_0281: ldloca.s V_2
				L_0283: call System.Drawing.Rectangle::Int32 get_Y()
				L_0288: ldc.i4.6 
				L_0289: add 
				L_028a: ldloca.s V_2
				L_028c: call System.Drawing.Rectangle::Int32 get_X()
				L_0291: ldloca.s V_2
				L_0293: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0298: ldc.i4.1 
				L_0299: sub 
				L_029a: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_029f: ldarg.1 
				L_02a0: ldloc.s V_5
				L_02a2: ldloca.s V_2
				L_02a4: call System.Drawing.Rectangle::Int32 get_X()
				L_02a9: ldloca.s V_2
				L_02ab: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_02b0: ldc.i4.1 
				L_02b1: sub 
				L_02b2: ldloca.s V_2
				L_02b4: call System.Drawing.Rectangle::Int32 get_Right()
				L_02b9: ldc.i4.1 
				L_02ba: sub 
				L_02bb: ldloca.s V_2
				L_02bd: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_02c2: ldc.i4.1 
				L_02c3: sub 
				L_02c4: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_02c9: ldarg.1 
				L_02ca: ldloc.s V_5
				L_02cc: ldloca.s V_2
				L_02ce: call System.Drawing.Rectangle::Int32 get_Right()
				L_02d3: ldc.i4.1 
				L_02d4: sub 
				L_02d5: ldloca.s V_2
				L_02d7: call System.Drawing.Rectangle::Int32 get_Y()
				L_02dc: ldc.i4.6 
				L_02dd: add 
				L_02de: ldloca.s V_2
				L_02e0: call System.Drawing.Rectangle::Int32 get_Right()
				L_02e5: ldc.i4.1 
				L_02e6: sub 
				L_02e7: ldloca.s V_2
				L_02e9: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_02ee: ldc.i4.1 
				L_02ef: sub 
				L_02f0: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_02f5: leave.s L_0303
				L_02f7: ldloc.s V_5
				L_02f9: brfalse.s L_0302
				L_02fb: ldloc.s V_5
				L_02fd: callvirt System.IDisposable::Void Dispose()
				L_0302: endfinally 
				L_0303: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				SizeF sizeF1;
				GroupBox groupBox1 = ((GroupBox) base.xcd9cdf30888d2204);
				StringFormat stringFormat1 = new StringFormat ();
				stringFormat1.Alignment = StringAlignment.Near;
				stringFormat1.LineAlignment = StringAlignment.Near;
				stringFormat1.HotkeyPrefix = HotkeyPrefix.Show;
				rectangle1 = new Rectangle (0, 0, 0, 0);
				bool b1 = x61467fe65a98f20c.GetWindowRect (base.xcd9cdf30888d2204.Handle, ref rectangle1);
				rectangle1.Width -= rectangle1.X;
				rectangle1.Height -= rectangle1.Y;
				rectangle1.X = 0;
				rectangle1.Y = 0;
				Brush brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR;
				Brush brush2 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_CONTROLFONTCOLOR;
				x4b101060f4767186.FillRectangle (brush1, rectangle1);
				brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_CONTROLBORDERCOLOR;
				using (Pen pen1 = new Pen (brush1, 1F))
				{
					if ((groupBox1.RightToLeft & RightToLeft.Yes) == RightToLeft.Yes)
					{
						stringFormat1.Alignment = StringAlignment.Far;
						stringFormat1.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
					}
					else
					{
						stringFormat1.Alignment = StringAlignment.Near;
					}
					sizeF1 = x4b101060f4767186.MeasureString (groupBox1.Text, groupBox1.Font, ((int) (groupBox1.Width - 12)), stringFormat1);
					if ((groupBox1.RightToLeft & RightToLeft.Yes) == RightToLeft.Yes)
					{
						x4b101060f4767186.DrawLine (pen1, ((float) rectangle1.X), ((float) (rectangle1.Y + 6)), (((float) (rectangle1.Right - 6)) - sizeF1.Width), ((float) (rectangle1.Y + 6)));
						x4b101060f4767186.DrawLine (pen1, ((int) ((rectangle1.Right - 6) - 1)), ((int) (rectangle1.Y + 6)), ((int) (rectangle1.Width - 1)), ((int) (rectangle1.Y + 6)));
						x4b101060f4767186.DrawString (groupBox1.Text, groupBox1.Font, brush2, new RectangleF ((((float) (rectangle1.Right - 6)) - sizeF1.Width), ((float) rectangle1.Top), sizeF1.Width, sizeF1.Height), stringFormat1);
					}
					else
					{
						x4b101060f4767186.DrawLine (pen1, rectangle1.X, ((int) (rectangle1.Y + 6)), ((int) ((rectangle1.X + 6) + 1)), ((int) (rectangle1.Y + 6)));
						x4b101060f4767186.DrawLine (pen1, (((float) (rectangle1.Left + 6)) + sizeF1.Width), ((float) (rectangle1.Y + 6)), ((float) (rectangle1.Width - 1)), ((float) (rectangle1.Y + 6)));
						x4b101060f4767186.DrawString (groupBox1.Text, groupBox1.Font, brush2, new RectangleF (((float) ((rectangle1.X + 6) + 1)), ((float) rectangle1.Top), sizeF1.Width, sizeF1.Height), stringFormat1);
					}
					x4b101060f4767186.DrawLine (pen1, rectangle1.X, ((int) (rectangle1.Y + 6)), rectangle1.X, ((int) (rectangle1.Bottom - 1)));
					x4b101060f4767186.DrawLine (pen1, rectangle1.X, ((int) (rectangle1.Bottom - 1)), ((int) (rectangle1.Right - 1)), ((int) (rectangle1.Bottom - 1)));
					x4b101060f4767186.DrawLine (pen1, ((int) (rectangle1.Right - 1)), ((int) (rectangle1.Y + 6)), ((int) (rectangle1.Right - 1)), ((int) (rectangle1.Bottom - 1)));
				}
			}
			
		#endregion
	}
	
}

