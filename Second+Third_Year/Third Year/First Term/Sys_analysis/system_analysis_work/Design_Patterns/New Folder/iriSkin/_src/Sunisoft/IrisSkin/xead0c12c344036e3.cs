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
		
	internal class xead0c12c344036e3 : xbd3f2493841f18a1
	
	{
		
		#region Constructors
		
			public xead0c12c344036e3 (Control control, ISkinEngine engine)
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
		
		#region Methods
		
			protected override void DoInit ()
			
			/*
				// Code Size: 100 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::System.String get_CompanyName()
				L_000b: ldstr "WeifenLuo.WinFormsUI"
				L_0010: call System.String::Boolean op_Equality(System.String, System.String)
				L_0015: brfalse.s L_0018
				L_0017: ret 
				L_0018: ldarg.0 
				L_0019: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Void DoInit()
				L_001e: ldarg.0 
				L_001f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0024: ldarg.0 
				L_0025: ldftn Sunisoft.IrisSkin.xead0c12c344036e3::Void x903997f2d792df23(System.Object, System.EventArgs)
				L_002b: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0030: callvirt System.Windows.Forms.Control::Void add_GotFocus(System.EventHandler)
				L_0035: ldarg.0 
				L_0036: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_003b: ldarg.0 
				L_003c: ldftn Sunisoft.IrisSkin.xead0c12c344036e3::Void xe44877363ebb618d(System.Object, System.EventArgs)
				L_0042: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0047: callvirt System.Windows.Forms.Control::Void add_LostFocus(System.EventHandler)
				L_004c: ldarg.0 
				L_004d: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0052: ldarg.0 
				L_0053: ldftn Sunisoft.IrisSkin.xead0c12c344036e3::Void xbd9410cb429a8e67(System.Object, System.Windows.Forms.PaintEventArgs)
				L_0059: newobj System.Windows.Forms.PaintEventHandler::Void .ctor(System.Object, IntPtr)
				L_005e: callvirt System.Windows.Forms.Control::Void add_Paint(System.Windows.Forms.PaintEventHandler)
				L_0063: ret 
			*/
			
			
			{
				if (base.xcd9cdf30888d2204.CompanyName != "WeifenLuo.WinFormsUI")
				{
					base.DoInit ();
					base.xcd9cdf30888d2204.GotFocus += new EventHandler (this.x903997f2d792df23);
					base.xcd9cdf30888d2204.LostFocus += new EventHandler (this.xe44877363ebb618d);
					base.xcd9cdf30888d2204.Paint += new PaintEventHandler (this.xbd9410cb429a8e67);
				}
			}
			
			protected override void PaintControl ()
			
			/*
				// Code Size: 84 Bytes
				.maxstack 3
				.locals (System.Drawing.Graphics V_0, 
         System.Drawing.Rectangle V_1)
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
				L_0033: brfalse.s L_0053
				L_0035: ldarg.0 
				L_0036: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_003b: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0040: call System.Drawing.Graphics::System.Drawing.Graphics FromHwnd(IntPtr)
				L_0045: stloc.0 
				L_0046: ldarg.0 
				L_0047: ldloc.0 
				L_0048: call Sunisoft.IrisSkin.xead0c12c344036e3::Void x8bc95f030953f87b(System.Drawing.Graphics)
				L_004d: ldloc.0 
				L_004e: callvirt System.Drawing.Graphics::Void Dispose()
				L_0053: ret 
			*/
			
			
			{
				if (((base.xcd9cdf30888d2204.ClientRectangle.Width <= 0) || (base.xcd9cdf30888d2204.ClientRectangle.Height <= 0)) || (! base.xf2140268ef7ddbf7))
				{
					return;
				}
				Graphics graphics1 = Graphics.FromHwnd (base.xcd9cdf30888d2204.Handle);
				this.x8bc95f030953f87b (graphics1);
				graphics1.Dispose ();
			}
			
			private void x6b515e4773b2f185 (Graphics x4b101060f4767186, Bitmap x5ce6bc2fb6fe458d, string x1c2743f354837549, Font x26094932cf7a9139, Rectangle x59dcf7372713ec60)
			
			/*
				// Code Size: 144 Bytes
				.maxstack 6
				.locals (System.Drawing.Brush V_0)
				L_0000: ldnull 
				L_0001: stloc.0 
				L_0002: ldarg.1 
				L_0003: ldarg.2 
				L_0004: ldarg.0 
				L_0005: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_000a: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_000f: ldarg.0 
				L_0010: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0015: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_001a: ldc.i4.2 
				L_001b: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0020: ldarg.3 
				L_0021: brfalse.s L_0079
				L_0023: ldarg.3 
				L_0024: ldstr ""
				L_0029: call System.String::Boolean op_Inequality(System.String, System.String)
				L_002e: brfalse.s L_0079
				L_0030: ldarg.0 
				L_0031: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0036: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_003b: brtrue.s L_0045
				L_003d: call System.Drawing.Brushes::System.Drawing.Brush get_Gray()
				L_0042: stloc.0 
				L_0043: br.s L_0056
				L_0045: ldarg.0 
				L_0046: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_004b: callvirt System.Windows.Forms.Control::System.Drawing.Color get_ForeColor()
				L_0050: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0055: stloc.0 
				L_0056: ldarg.0 
				L_0057: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_005c: ldc.i4.3 
				L_005d: bne.un.s L_0068
				L_005f: ldarga.s x59dcf7372713ec60
				L_0061: ldc.i4.1 
				L_0062: ldc.i4.1 
				L_0063: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x897356c8698a543c(System.Drawing.Rectangle ByRef, Int32, Int32)
				L_0068: ldarg.1 
				L_0069: ldarg.3 
				L_006a: ldarg.s x26094932cf7a9139
				L_006c: ldloc.0 
				L_006d: ldarg.s x59dcf7372713ec60
				L_006f: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_0074: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF)
				L_0079: ldloc.0 
				L_007a: brfalse.s L_008f
				L_007c: ldarg.0 
				L_007d: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0082: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_0087: brfalse.s L_008f
				L_0089: ldloc.0 
				L_008a: callvirt System.Drawing.Brush::Void Dispose()
				L_008f: ret 
			*/
			
			
			{
				Brush brush1 = ((Brush) null);
				x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), base.xcd9cdf30888d2204.ClientRectangle, base.xcd9cdf30888d2204.ClientRectangle, GraphicsUnit.Pixel);
				if ((x1c2743f354837549 != null) && (x1c2743f354837549 != ""))
				{
					if (! base.xcd9cdf30888d2204.Enabled)
					{
						brush1 = Brushes.Gray;
					}
					else
					{
						brush1 = ((Brush) new SolidBrush (base.xcd9cdf30888d2204.ForeColor));
					}
					if (base.xdd938462da9aed37 == xb9506a535e31f22a.x51fcce5a95fca000)
					{
						x448fd9ab43628c71.x897356c8698a543c (ref x59dcf7372713ec60, 1, 1);
					}
					x4b101060f4767186.DrawString (x1c2743f354837549, x26094932cf7a9139, brush1, ((RectangleF) x59dcf7372713ec60));
				}
				if ((brush1 != null) && base.xcd9cdf30888d2204.Enabled)
				{
					brush1.Dispose ();
				}
			}
			
			private void x6b515e4773b2f185 (Graphics x4b101060f4767186, Bitmap x5ce6bc2fb6fe458d)
			
			/*
				// Code Size: 31 Bytes
				.maxstack 9
				L_0000: ldarg.1 
				L_0001: ldarg.2 
				L_0002: ldarg.0 
				L_0003: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0008: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_000d: ldarg.0 
				L_000e: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0013: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0018: ldc.i4.2 
				L_0019: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_001e: ret 
			*/
			
			
			{
				x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), base.xcd9cdf30888d2204.ClientRectangle, base.xcd9cdf30888d2204.ClientRectangle, GraphicsUnit.Pixel);
			}
			
			private void x6f37a3496a324cf4 (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 440 Bytes
				.maxstack 7
				.locals (System.Windows.Forms.Button V_0, 
         System.Drawing.Rectangle V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.StringFormat V_3, 
         System.Drawing.Brush V_4, 
         System.Windows.Forms.Control V_5, 
         System.Single V_6, 
         System.Single V_7, 
         System.Single V_8, 
         System.Single V_9, 
         System.Drawing.Pen V_10, 
         System.Drawing.SizeF V_11)
				.try L_0199 to L_01ab finally L_01ab to L_01b7
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.Button
				L_000b: stloc.0 
				L_000c: ldloc.0 
				L_000d: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_0012: pop 
				L_0013: ldloc.0 
				L_0014: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0019: stloc.1 
				L_001a: ldloc.0 
				L_001b: callvirt System.Windows.Forms.ButtonBase::System.Drawing.ContentAlignment get_TextAlign()
				L_0020: ldloc.1 
				L_0021: ldloc.0 
				L_0022: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_0027: ldloca.s V_2
				L_0029: ldloca.s V_3
				L_002b: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x323b3762dd22c667(System.Drawing.ContentAlignment, System.Drawing.Rectangle, System.Windows.Forms.RightToLeft, System.Drawing.Rectangle ByRef, System.Drawing.StringFormat ByRef)
				L_0030: ldloca.s V_2
				L_0032: call System.Drawing.Rectangle::Int32 get_Width()
				L_0037: ldc.i4.8 
				L_0038: ble.s L_0058
				L_003a: ldloca.s V_2
				L_003c: dup 
				L_003d: call System.Drawing.Rectangle::Int32 get_X()
				L_0042: ldc.i4.2 
				L_0043: add 
				L_0044: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0049: ldloca.s V_2
				L_004b: dup 
				L_004c: call System.Drawing.Rectangle::Int32 get_Width()
				L_0051: ldc.i4.4 
				L_0052: sub 
				L_0053: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0058: ldarg.0 
				L_0059: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_005e: ldc.i4.3 
				L_005f: bne.un.s L_006a
				L_0061: ldloca.s V_2
				L_0063: ldc.i4.1 
				L_0064: ldc.i4.1 
				L_0065: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x897356c8698a543c(System.Drawing.Rectangle ByRef, Int32, Int32)
				L_006a: ldarg.0 
				L_006b: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0070: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_0075: brfalse.s L_0090
				L_0077: ldarg.0 
				L_0078: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_007d: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0082: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0087: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_BUTTONFONTCOLOR()
				L_008c: stloc.s V_4
				L_008e: br.s L_0097
				L_0090: call System.Drawing.Brushes::System.Drawing.Brush get_Gray()
				L_0095: stloc.s V_4
				L_0097: ldarg.1 
				L_0098: ldloc.0 
				L_0099: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_009e: ldloc.0 
				L_009f: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_00a4: ldloc.s V_4
				L_00a6: ldloc.2 
				L_00a7: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_00ac: ldloc.3 
				L_00ad: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_00b2: ldarg.0 
				L_00b3: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_00b8: callvirt System.Windows.Forms.Control::System.Windows.Forms.Control get_TopLevelControl()
				L_00bd: stloc.s V_5
				L_00bf: ldloc.s V_5
				L_00c1: isinst System.Windows.Forms.Form
				L_00c6: brfalse L_01b7
				L_00cb: ldloc.s V_5
				L_00cd: castclass System.Windows.Forms.Form
				L_00d2: callvirt System.Windows.Forms.Form::System.Windows.Forms.IButtonControl get_AcceptButton()
				L_00d7: ldarg.0 
				L_00d8: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_00dd: bne.un L_01b7
				L_00e2: ldarg.0 
				L_00e3: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00e8: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_DrawLineForAcceptButton()
				L_00ed: brfalse L_01b7
				L_00f2: ldarg.1 
				L_00f3: ldloc.0 
				L_00f4: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_00f9: ldloc.0 
				L_00fa: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_00ff: ldloca.s V_2
				L_0101: call System.Drawing.Rectangle::Int32 get_Width()
				L_0106: ldloc.3 
				L_0107: callvirt System.Drawing.Graphics::System.Drawing.SizeF MeasureString(System.String, System.Drawing.Font, Int32, System.Drawing.StringFormat)
				L_010c: stloc.s V_11
				L_010e: ldloca.s V_11
				L_0110: call System.Drawing.SizeF::Single get_Width()
				L_0115: stloc.s V_6
				L_0117: ldloca.s V_2
				L_0119: call System.Drawing.Rectangle::Int32 get_Y()
				L_011e: conv.r4 
				L_011f: ldloca.s V_2
				L_0121: call System.Drawing.Rectangle::Int32 get_Height()
				L_0126: conv.r4 
				L_0127: ldc.r4 2
				L_012c: div 
				L_012d: add 
				L_012e: ldloc.0 
				L_012f: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_0134: callvirt System.Drawing.Font::Int32 get_Height()
				L_0139: conv.r4 
				L_013a: ldc.r4 2
				L_013f: div 
				L_0140: add 
				L_0141: stloc.s V_7
				L_0143: ldloca.s V_2
				L_0145: call System.Drawing.Rectangle::Int32 get_X()
				L_014a: conv.r4 
				L_014b: ldloca.s V_2
				L_014d: call System.Drawing.Rectangle::Int32 get_Width()
				L_0152: conv.r4 
				L_0153: ldc.r4 2
				L_0158: div 
				L_0159: add 
				L_015a: ldloc.s V_6
				L_015c: ldc.r4 2
				L_0161: div 
				L_0162: sub 
				L_0163: ldc.r4 1
				L_0168: sub 
				L_0169: stloc.s V_8
				L_016b: ldloc.s V_8
				L_016d: ldloc.s V_6
				L_016f: add 
				L_0170: ldc.r4 2
				L_0175: add 
				L_0176: stloc.s V_9
				L_0178: ldarg.0 
				L_0179: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_017e: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0183: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0188: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_CONTROLBORDERCOLOR
				L_018d: ldc.r4 1
				L_0192: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color, Single)
				L_0197: stloc.s V_10
				L_0199: ldarg.1 
				L_019a: ldloc.s V_10
				L_019c: ldloc.s V_8
				L_019e: ldloc.s V_7
				L_01a0: ldloc.s V_9
				L_01a2: ldloc.s V_7
				L_01a4: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Single, Single, Single, Single)
				L_01a9: leave.s L_01b7
				L_01ab: ldloc.s V_10
				L_01ad: brfalse.s L_01b6
				L_01af: ldloc.s V_10
				L_01b1: callvirt System.IDisposable::Void Dispose()
				L_01b6: endfinally 
				L_01b7: ret 
			*/
			
			
			{
				Rectangle rectangle2;
				StringFormat stringFormat1;
				Brush brush1;
				Button button1 = ((Button) base.xcd9cdf30888d2204);
				string string1 = button1.Text;
				Rectangle rectangle1 = button1.ClientRectangle;
				x448fd9ab43628c71.x323b3762dd22c667 (button1.TextAlign, rectangle1, button1.RightToLeft, out rectangle2, out stringFormat1);
				if (rectangle2.Width > 8)
				{
					rectangle2.X += 2;
					rectangle2.Width -= 4;
				}
				if (base.xdd938462da9aed37 == xb9506a535e31f22a.x51fcce5a95fca000)
				{
					x448fd9ab43628c71.x897356c8698a543c (ref rectangle2, 1, 1);
				}
				if (base.xcd9cdf30888d2204.Enabled)
				{
					brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_BUTTONFONTCOLOR;
				}
				else
				{
					brush1 = Brushes.Gray;
				}
				x4b101060f4767186.DrawString (button1.Text, button1.Font, brush1, ((RectangleF) rectangle2), stringFormat1);
				Control control1 = base.xcd9cdf30888d2204.TopLevelControl;
				if (((! (control1 is Form)) || (((Form) control1).AcceptButton != base.xcd9cdf30888d2204)) || (! ((SkinEngine) base.xdc87e2b99332cd4a).DrawLineForAcceptButton))
				{
					return;
				}
				SizeF sizeF1 = x4b101060f4767186.MeasureString (button1.Text, button1.Font, rectangle2.Width, stringFormat1);
				float single1 = sizeF1.Width;
				float single2 = ((((float) rectangle2.Y) + (((float) rectangle2.Height) / 2F)) + (((float) button1.Font.Height) / 2F));
				float single3 = (((((float) rectangle2.X) + (((float) rectangle2.Width) / 2F)) - (single1 / 2F)) - 1F);
				float single4 = ((single3 + single1) + 2F);
				using (Pen pen1 = new Pen (((SkinColors) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Colors).SKIN2_CONTROLBORDERCOLOR, 1F))
				{
					x4b101060f4767186.DrawLine (pen1, single3, single2, single4, single2);
				}
			}
			
			private void x8bc95f030953f87b (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 425 Bytes
				.maxstack 6
				.locals (System.Drawing.Rectangle V_0, 
         System.Int32 V_1, 
         System.Drawing.Bitmap V_2, 
         System.Drawing.Bitmap V_3, 
         System.Drawing.Graphics V_4, 
         System.Drawing.Brush V_5, 
         System.Drawing.Rectangle V_6)
				.try L_0075 to L_0190 finally L_0190 to L_019c
				.try L_006d to L_019e finally L_019e to L_01a8
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0006: ldc.i4.2 
				L_0007: bne.un.s L_0032
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_000f: call System.Windows.Forms.Control::System.Drawing.Point get_MousePosition()
				L_0014: callvirt System.Windows.Forms.Control::System.Drawing.Point PointToClient(System.Drawing.Point)
				L_0019: ldarg.0 
				L_001a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001f: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0024: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0029: brtrue.s L_0032
				L_002b: ldarg.0 
				L_002c: ldc.i4.1 
				L_002d: stfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0032: ldarg.0 
				L_0033: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0038: stloc.1 
				L_0039: ldarg.0 
				L_003a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_003f: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0044: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SplitBitmaps get_SplitBitmaps()
				L_0049: callvirt Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] get_SKIN2_BUTTON()
				L_004e: ldloc.1 
				L_004f: ldelem.ref 
				L_0050: stloc.2 
				L_0051: ldarg.0 
				L_0052: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0057: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_005c: ldarg.0 
				L_005d: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0062: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0067: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_006c: stloc.3 
				L_006d: ldloc.3 
				L_006e: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0073: stloc.s V_4
				L_0075: ldarg.0 
				L_0076: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_007b: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0080: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0085: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_008a: stloc.s V_5
				L_008c: ldloc.s V_4
				L_008e: ldloc.s V_5
				L_0090: ldarg.0 
				L_0091: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0096: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_009b: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_00a0: ldloc.2 
				L_00a1: ldloc.s V_4
				L_00a3: ldarg.0 
				L_00a4: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_00a9: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_00ae: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x779038d721b14f75(System.Drawing.Bitmap, System.Drawing.Graphics, System.Drawing.Rectangle)
				L_00b3: ldarg.0 
				L_00b4: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_00b9: castclass System.Windows.Forms.Button
				L_00be: callvirt System.Windows.Forms.ButtonBase::System.Drawing.Image get_Image()
				L_00c3: brfalse.s L_00cd
				L_00c5: ldarg.0 
				L_00c6: ldloc.s V_4
				L_00c8: call Sunisoft.IrisSkin.xead0c12c344036e3::Void xcea9a0eaf0e83f21(System.Drawing.Graphics)
				L_00cd: ldarg.0 
				L_00ce: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_00d3: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_00d8: brfalse.s L_00f9
				L_00da: ldarg.0 
				L_00db: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_00e0: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_00e5: ldstr ""
				L_00ea: call System.String::Boolean op_Inequality(System.String, System.String)
				L_00ef: brfalse.s L_00f9
				L_00f1: ldarg.0 
				L_00f2: ldloc.s V_4
				L_00f4: call Sunisoft.IrisSkin.xead0c12c344036e3::Void x6f37a3496a324cf4(System.Drawing.Graphics)
				L_00f9: ldarg.0 
				L_00fa: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_00ff: callvirt System.Windows.Forms.Control::Boolean get_Focused()
				L_0104: brfalse L_0186
				L_0109: ldarg.0 
				L_010a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_010f: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0114: stloc.s V_6
				L_0116: ldloca.s V_6
				L_0118: call System.Drawing.Rectangle::Int32 get_Left()
				L_011d: ldc.i4.4 
				L_011e: add 
				L_011f: ldarg.0 
				L_0120: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0125: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_012a: stloc.s V_6
				L_012c: ldloca.s V_6
				L_012e: call System.Drawing.Rectangle::Int32 get_Top()
				L_0133: ldc.i4.4 
				L_0134: add 
				L_0135: ldarg.0 
				L_0136: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_013b: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0140: stloc.s V_6
				L_0142: ldloca.s V_6
				L_0144: call System.Drawing.Rectangle::Int32 get_Right()
				L_0149: ldc.i4.5 
				L_014a: sub 
				L_014b: ldarg.0 
				L_014c: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0151: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0156: stloc.s V_6
				L_0158: ldloca.s V_6
				L_015a: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_015f: ldc.i4.5 
				L_0160: sub 
				L_0161: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0166: stloc.0 
				L_0167: ldarg.0 
				L_0168: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_016d: ldc.i4.3 
				L_016e: bne.un.s L_0179
				L_0170: ldloca.s V_0
				L_0172: ldc.i4.1 
				L_0173: ldc.i4.1 
				L_0174: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x897356c8698a543c(System.Drawing.Rectangle ByRef, Int32, Int32)
				L_0179: ldloc.s V_4
				L_017b: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Pen get_x6ee6589d93f80946()
				L_0180: ldloc.0 
				L_0181: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_0186: ldarg.0 
				L_0187: ldarg.1 
				L_0188: ldloc.3 
				L_0189: call Sunisoft.IrisSkin.xead0c12c344036e3::Void x6b515e4773b2f185(System.Drawing.Graphics, System.Drawing.Bitmap)
				L_018e: leave.s L_019c
				L_0190: ldloc.s V_4
				L_0192: brfalse.s L_019b
				L_0194: ldloc.s V_4
				L_0196: callvirt System.IDisposable::Void Dispose()
				L_019b: endfinally 
				L_019c: leave.s L_01a8
				L_019e: ldloc.3 
				L_019f: brfalse.s L_01a7
				L_01a1: ldloc.3 
				L_01a2: callvirt System.IDisposable::Void Dispose()
				L_01a7: endfinally 
				L_01a8: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Brush brush1;
				if ((base.xdd938462da9aed37 == xb9506a535e31f22a.x38f64d20b794f1fc) && (! x448fd9ab43628c71.x9466a6be27202526 (base.xcd9cdf30888d2204.PointToClient (Control.MousePosition), base.xcd9cdf30888d2204.ClientRectangle)))
				{
					base.xdd938462da9aed37 = xb9506a535e31f22a.x4d0b9d4447ba7566;
				}
				int i1 = ((int) base.xdd938462da9aed37);
				Bitmap bitmap1 = ((SplitBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).SplitBitmaps).SKIN2_BUTTON[i1];
				using (Bitmap bitmap2 = new Bitmap (base.xcd9cdf30888d2204.Width, base.xcd9cdf30888d2204.Height))
				{
					using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap2)))
					{
						brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR;
						graphics1.FillRectangle (brush1, base.xcd9cdf30888d2204.ClientRectangle);
						x448fd9ab43628c71.x779038d721b14f75 (bitmap1, graphics1, base.xcd9cdf30888d2204.ClientRectangle);
						if (((Button) base.xcd9cdf30888d2204).Image != null)
						{
							this.xcea9a0eaf0e83f21 (graphics1);
						}
						if ((base.xcd9cdf30888d2204.Text != null) && (base.xcd9cdf30888d2204.Text != ""))
						{
							this.x6f37a3496a324cf4 (graphics1);
						}
						if (base.xcd9cdf30888d2204.Focused)
						{
							rectangle1 = Rectangle.FromLTRB (((int) (base.xcd9cdf30888d2204.ClientRectangle.Left + 4)), ((int) (base.xcd9cdf30888d2204.ClientRectangle.Top + 4)), ((int) (base.xcd9cdf30888d2204.ClientRectangle.Right - 5)), ((int) (base.xcd9cdf30888d2204.ClientRectangle.Bottom - 5)));
							if (base.xdd938462da9aed37 == xb9506a535e31f22a.x51fcce5a95fca000)
							{
								x448fd9ab43628c71.x897356c8698a543c (ref rectangle1, 1, 1);
							}
							graphics1.DrawRectangle (x448fd9ab43628c71.x6ee6589d93f80946, rectangle1);
						}
						this.x6b515e4773b2f185 (x4b101060f4767186, bitmap2);
					}
				}
			}
			
			private void x903997f2d792df23 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 15 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0006: brfalse.s L_000e
				L_0008: ldarg.0 
				L_0009: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_000e: ret 
			*/
			
			
			{
				if (base.xf2140268ef7ddbf7)
				{
					this.PaintControl ();
				}
			}
			
			private void xbd9410cb429a8e67 (object xe0292b9ed559da7d, PaintEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 21 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0006: brfalse.s L_0014
				L_0008: ldarg.0 
				L_0009: ldarg.2 
				L_000a: callvirt System.Windows.Forms.PaintEventArgs::System.Drawing.Graphics get_Graphics()
				L_000f: call Sunisoft.IrisSkin.xead0c12c344036e3::Void x8bc95f030953f87b(System.Drawing.Graphics)
				L_0014: ret 
			*/
			
			
			{
				if (base.xf2140268ef7ddbf7)
				{
					this.x8bc95f030953f87b (xfbf34718e704c6bc.Graphics);
				}
			}
			
			private void xcea9a0eaf0e83f21 (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 129 Bytes
				.maxstack 8
				.locals (System.Windows.Forms.Button V_0, 
         System.Drawing.Image V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Rectangle V_3)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.Button
				L_000b: stloc.0 
				L_000c: ldloc.0 
				L_000d: callvirt System.Windows.Forms.ButtonBase::System.Drawing.Image get_Image()
				L_0012: stloc.1 
				L_0013: ldloc.1 
				L_0014: callvirt System.Drawing.Image::Int32 get_Height()
				L_0019: ldc.i4.0 
				L_001a: ble.s L_0025
				L_001c: ldloc.1 
				L_001d: callvirt System.Drawing.Image::Int32 get_Width()
				L_0022: ldc.i4.0 
				L_0023: bgt.s L_0026
				L_0025: ret 
				L_0026: ldloc.0 
				L_0027: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_002c: stloc.2 
				L_002d: ldloc.0 
				L_002e: callvirt System.Windows.Forms.ButtonBase::System.Drawing.ContentAlignment get_ImageAlign()
				L_0033: ldloc.0 
				L_0034: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_0039: ldloc.2 
				L_003a: ldloc.1 
				L_003b: callvirt System.Drawing.Image::Int32 get_Width()
				L_0040: ldloc.1 
				L_0041: callvirt System.Drawing.Image::Int32 get_Height()
				L_0046: ldc.i4.6 
				L_0047: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Rectangle x323b3762dd22c667(System.Drawing.ContentAlignment, System.Windows.Forms.RightToLeft, System.Drawing.Rectangle, Int32, Int32, Int32)
				L_004c: stloc.3 
				L_004d: ldarg.0 
				L_004e: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0053: ldc.i4.3 
				L_0054: bne.un.s L_005f
				L_0056: ldloca.s V_3
				L_0058: ldc.i4.1 
				L_0059: ldc.i4.1 
				L_005a: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x897356c8698a543c(System.Drawing.Rectangle ByRef, Int32, Int32)
				L_005f: ldarg.1 
				L_0060: ldloc.1 
				L_0061: ldloca.s V_3
				L_0063: call System.Drawing.Rectangle::Int32 get_X()
				L_0068: ldloca.s V_3
				L_006a: call System.Drawing.Rectangle::Int32 get_Y()
				L_006f: ldloc.1 
				L_0070: callvirt System.Drawing.Image::Int32 get_Width()
				L_0075: ldloc.1 
				L_0076: callvirt System.Drawing.Image::Int32 get_Height()
				L_007b: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, Int32, Int32, Int32, Int32)
				L_0080: ret 
			*/
			
			
			{
				Button button1 = ((Button) base.xcd9cdf30888d2204);
				Image image1 = button1.Image;
				if ((image1.Height <= 0) || (image1.Width <= 0))
				{
					return;
				}
				Rectangle rectangle1 = button1.ClientRectangle;
				Rectangle rectangle2 = x448fd9ab43628c71.x323b3762dd22c667 (button1.ImageAlign, button1.RightToLeft, rectangle1, image1.Width, image1.Height, 6);
				if (base.xdd938462da9aed37 == xb9506a535e31f22a.x51fcce5a95fca000)
				{
					x448fd9ab43628c71.x897356c8698a543c (ref rectangle2, 1, 1);
				}
				x4b101060f4767186.DrawImage (image1, rectangle2.X, rectangle2.Y, image1.Width, image1.Height);
			}
			
			private void xe44877363ebb618d (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 15 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0006: brfalse.s L_000e
				L_0008: ldarg.0 
				L_0009: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_000e: ret 
			*/
			
			
			{
				if (base.xf2140268ef7ddbf7)
				{
					this.PaintControl ();
				}
			}
			
		#endregion
	}
	
}

