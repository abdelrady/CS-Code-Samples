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
		
	internal class x2edc3f693fe78d2e : xc56e4251b5681836
	
	{
		
		#region Constructors
		
			public x2edc3f693fe78d2e (Control control, ISkinEngine engine)
				 : base (control, engine)
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.xc56e4251b5681836::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ret 
			*/
		#endregion
		
		#region Properties
		
			protected virtual int BorderWidth
			
			{
				get
				
				/*
					// Code Size: 2 Bytes
					.maxstack 9
					L_0000: ldc.i4.1 
					L_0001: ret 
				*/
				
				{
					return 1;
				}
			}
			
			
			protected virtual bool EnableState
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
					L_0006: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
					L_000b: ret 
				*/
				
				{
					return base.xcd9cdf30888d2204.Enabled;
				}
			}
			
			
			protected virtual bool PaintBorder
			
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
			
			
			protected virtual bool PaintBorderLine
			
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
		
			protected override void AfterWndProc (ref Message m)
			
			/*
				// Code Size: 31 Bytes
				.maxstack 3
				.locals (System.UInt32 V_0)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0006: stloc.0 
				L_0007: ldloc.0 
				L_0008: ldc.i4.s 15
				L_000a: beq.s L_0011
				L_000c: ldloc.0 
				L_000d: ldc.i4.s 20
				L_000f: bne.un.s L_0017
				L_0011: ldarg.0 
				L_0012: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0017: ldarg.0 
				L_0018: ldarg.1 
				L_0019: call Sunisoft.IrisSkin.xc56e4251b5681836::Void AfterWndProc(System.Windows.Forms.Message ByRef)
				L_001e: ret 
			*/
			
			
			{
				uint uInt32_1 = ((uint) m.Msg);
				if ((uInt32_1 == 15) || (uInt32_1 == 20))
				{
					this.PaintControl ();
				}
				base.AfterWndProc (ref m);
			}
			
			protected override bool BeforeWndProc (ref Message m)
			
			/*
				// Code Size: 8 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: call Sunisoft.IrisSkin.xc56e4251b5681836::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_0007: ret 
			*/
			
			
			{
				return base.BeforeWndProc (ref m);
			}
			
			protected override void DoInit ()
			
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x8917d01b98173f4c::Void DoInit()
				L_0006: ret 
			*/
			
			
			{
				base.DoInit ();
			}
			
			protected override void PaintControl ()
			
			/*
				// Code Size: 183 Bytes
				.maxstack 5
				.locals (System.IntPtr V_0, 
         System.Drawing.Graphics V_1, 
         System.Drawing.Bitmap V_2, 
         System.Drawing.Graphics V_3)
				.try L_0070 to L_0082 finally L_0082 to L_008c
				.try L_0069 to L_008e finally L_008e to L_0098
				.try L_004d to L_00ac finally L_00ac to L_00b6
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_000b: ldc.i4.0 
				L_000c: ble.s L_001c
				L_000e: ldarg.0 
				L_000f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0014: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0019: ldc.i4.0 
				L_001a: bgt.s L_001d
				L_001c: ret 
				L_001d: ldarg.0 
				L_001e: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0023: brtrue.s L_0026
				L_0025: ret 
				L_0026: ldarg.0 
				L_0027: call Sunisoft.IrisSkin.xc56e4251b5681836::Void PaintControl()
				L_002c: ldarg.0 
				L_002d: callvirt Sunisoft.IrisSkin.x2edc3f693fe78d2e::Boolean get_PaintBorderLine()
				L_0032: brtrue.s L_0035
				L_0034: ret 
				L_0035: ldarg.0 
				L_0036: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_003b: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0040: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindowDC(IntPtr)
				L_0045: stloc.0 
				L_0046: ldloc.0 
				L_0047: call System.Drawing.Graphics::System.Drawing.Graphics FromHdc(IntPtr)
				L_004c: stloc.1 
				L_004d: ldarg.0 
				L_004e: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0053: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0058: ldarg.0 
				L_0059: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_005e: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0063: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0068: stloc.2 
				L_0069: ldloc.2 
				L_006a: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_006f: stloc.3 
				L_0070: ldarg.0 
				L_0071: ldloc.3 
				L_0072: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void x8bc95f030953f87b(System.Drawing.Graphics)
				L_0077: ldloc.1 
				L_0078: ldloc.2 
				L_0079: ldc.i4.0 
				L_007a: ldc.i4.0 
				L_007b: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_0080: leave.s L_008c
				L_0082: ldloc.3 
				L_0083: brfalse.s L_008b
				L_0085: ldloc.3 
				L_0086: callvirt System.IDisposable::Void Dispose()
				L_008b: endfinally 
				L_008c: leave.s L_0098
				L_008e: ldloc.2 
				L_008f: brfalse.s L_0097
				L_0091: ldloc.2 
				L_0092: callvirt System.IDisposable::Void Dispose()
				L_0097: endfinally 
				L_0098: ldarg.0 
				L_0099: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_009e: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_00a3: ldloc.0 
				L_00a4: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_00a9: pop 
				L_00aa: leave.s L_00b6
				L_00ac: ldloc.1 
				L_00ad: brfalse.s L_00b5
				L_00af: ldloc.1 
				L_00b0: callvirt System.IDisposable::Void Dispose()
				L_00b5: endfinally 
				L_00b6: ret 
			*/
			
			
			{
				if (((base.xcd9cdf30888d2204.Width <= 0) || (base.xcd9cdf30888d2204.Height <= 0)) || (! base.xf2140268ef7ddbf7))
				{
					return;
				}
				base.PaintControl ();
				if (! this.PaintBorderLine)
				{
					return;
				}
				IntPtr intPtr1 = x61467fe65a98f20c.GetWindowDC (base.xcd9cdf30888d2204.Handle);
				using (Graphics graphics1 = Graphics.FromHdc (intPtr1))
				{
					using (Bitmap bitmap1 = new Bitmap (base.xcd9cdf30888d2204.Width, base.xcd9cdf30888d2204.Height))
					{
						using (Graphics graphics2 = Graphics.FromImage (((Image) bitmap1)))
						{
							this.x8bc95f030953f87b (graphics2);
							graphics1.DrawImageUnscaled (((Image) bitmap1), 0, 0);
						}
					}
					int i1 = x61467fe65a98f20c.ReleaseDC (base.xcd9cdf30888d2204.Handle, intPtr1);
				}
			}
			
			private void x32475e142481d30b (object xe0292b9ed559da7d, PaintEventArgs xfbf34718e704c6bc)
			
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
			
			private void x8bc95f030953f87b (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 379 Bytes
				.maxstack 8
				.locals (System.Drawing.Brush V_0, 
         System.Drawing.Pen V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Pen V_3)
				.try L_003a to L_0095 finally L_0095 to L_009f
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.x2edc3f693fe78d2e::Boolean get_PaintBorder()
				L_0006: brfalse L_017a
				L_000b: ldarg.0 
				L_000c: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0011: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0016: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_001b: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_CONTROLBORDERCOLOR()
				L_0020: stloc.0 
				L_0021: ldloca.s V_2
				L_0023: ldc.i4.0 
				L_0024: ldc.i4.0 
				L_0025: ldc.i4.0 
				L_0026: ldc.i4.0 
				L_0027: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_002c: ldloc.0 
				L_002d: ldc.r4 1
				L_0032: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush, Single)
				L_0037: dup 
				L_0038: stloc.1 
				L_0039: stloc.3 
				L_003a: ldarg.0 
				L_003b: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0040: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0045: ldloca.s V_2
				L_0047: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowRect(IntPtr, System.Drawing.Rectangle ByRef)
				L_004c: pop 
				L_004d: ldloca.s V_2
				L_004f: dup 
				L_0050: call System.Drawing.Rectangle::Int32 get_Width()
				L_0055: ldloca.s V_2
				L_0057: call System.Drawing.Rectangle::Int32 get_X()
				L_005c: ldc.i4.1 
				L_005d: add 
				L_005e: sub 
				L_005f: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0064: ldloca.s V_2
				L_0066: dup 
				L_0067: call System.Drawing.Rectangle::Int32 get_Height()
				L_006c: ldloca.s V_2
				L_006e: call System.Drawing.Rectangle::Int32 get_Y()
				L_0073: ldc.i4.1 
				L_0074: add 
				L_0075: sub 
				L_0076: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_007b: ldloca.s V_2
				L_007d: ldc.i4.0 
				L_007e: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0083: ldloca.s V_2
				L_0085: ldc.i4.0 
				L_0086: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_008b: ldarg.1 
				L_008c: ldloc.1 
				L_008d: ldloc.2 
				L_008e: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_0093: leave.s L_009f
				L_0095: ldloc.3 
				L_0096: brfalse.s L_009e
				L_0098: ldloc.3 
				L_0099: callvirt System.IDisposable::Void Dispose()
				L_009e: endfinally 
				L_009f: ldarg.0 
				L_00a0: callvirt Sunisoft.IrisSkin.x2edc3f693fe78d2e::Int32 get_BorderWidth()
				L_00a5: ldc.i4.0 
				L_00a6: ble L_017a
				L_00ab: ldarg.0 
				L_00ac: callvirt Sunisoft.IrisSkin.x2edc3f693fe78d2e::Boolean get_EnableState()
				L_00b1: brfalse.s L_00cd
				L_00b3: ldarg.0 
				L_00b4: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_00b9: callvirt System.Windows.Forms.Control::System.Drawing.Color get_BackColor()
				L_00be: ldarg.0 
				L_00bf: callvirt Sunisoft.IrisSkin.x2edc3f693fe78d2e::Int32 get_BorderWidth()
				L_00c4: conv.r4 
				L_00c5: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color, Single)
				L_00ca: stloc.1 
				L_00cb: br.s L_00e0
				L_00cd: ldc.i4.5 
				L_00ce: call System.Drawing.Color::System.Drawing.Color FromKnownColor(System.Drawing.KnownColor)
				L_00d3: ldarg.0 
				L_00d4: callvirt Sunisoft.IrisSkin.x2edc3f693fe78d2e::Int32 get_BorderWidth()
				L_00d9: conv.r4 
				L_00da: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color, Single)
				L_00df: stloc.1 
				L_00e0: ldloca.s V_2
				L_00e2: dup 
				L_00e3: call System.Drawing.Rectangle::Int32 get_X()
				L_00e8: ldarg.0 
				L_00e9: callvirt Sunisoft.IrisSkin.x2edc3f693fe78d2e::Int32 get_BorderWidth()
				L_00ee: add 
				L_00ef: call System.Drawing.Rectangle::Void set_X(Int32)
				L_00f4: ldloca.s V_2
				L_00f6: dup 
				L_00f7: call System.Drawing.Rectangle::Int32 get_Y()
				L_00fc: ldarg.0 
				L_00fd: callvirt Sunisoft.IrisSkin.x2edc3f693fe78d2e::Int32 get_BorderWidth()
				L_0102: add 
				L_0103: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_0108: ldloca.s V_2
				L_010a: dup 
				L_010b: call System.Drawing.Rectangle::Int32 get_Width()
				L_0110: ldarg.0 
				L_0111: callvirt Sunisoft.IrisSkin.x2edc3f693fe78d2e::Int32 get_BorderWidth()
				L_0116: ldc.i4.1 
				L_0117: add 
				L_0118: sub 
				L_0119: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_011e: ldloca.s V_2
				L_0120: dup 
				L_0121: call System.Drawing.Rectangle::Int32 get_Height()
				L_0126: ldarg.0 
				L_0127: callvirt Sunisoft.IrisSkin.x2edc3f693fe78d2e::Int32 get_BorderWidth()
				L_012c: ldc.i4.1 
				L_012d: add 
				L_012e: sub 
				L_012f: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_0134: ldarg.1 
				L_0135: ldloc.1 
				L_0136: ldloca.s V_2
				L_0138: call System.Drawing.Rectangle::Int32 get_Left()
				L_013d: ldc.i4.1 
				L_013e: ldloca.s V_2
				L_0140: call System.Drawing.Rectangle::Int32 get_Left()
				L_0145: ldloca.s V_2
				L_0147: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_014c: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0151: ldarg.1 
				L_0152: ldloc.1 
				L_0153: ldloca.s V_2
				L_0155: call System.Drawing.Rectangle::Int32 get_Left()
				L_015a: ldloca.s V_2
				L_015c: call System.Drawing.Rectangle::Int32 get_Top()
				L_0161: ldloca.s V_2
				L_0163: call System.Drawing.Rectangle::Int32 get_Right()
				L_0168: ldloca.s V_2
				L_016a: call System.Drawing.Rectangle::Int32 get_Top()
				L_016f: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0174: ldloc.1 
				L_0175: callvirt System.Drawing.Pen::Void Dispose()
				L_017a: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				if (! this.PaintBorder)
				{
					return;
				}
				Brush brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_CONTROLBORDERCOLOR;
				rectangle1 = new Rectangle (0, 0, 0, 0);
				Pen pen1 = new Pen (brush1, 1F);
				using (Pen pen2 = pen1)
				{
					bool b1 = x61467fe65a98f20c.GetWindowRect (base.xcd9cdf30888d2204.Handle, ref rectangle1);
					rectangle1.Width -= (rectangle1.X + 1);
					rectangle1.Height -= (rectangle1.Y + 1);
					rectangle1.X = 0;
					rectangle1.Y = 0;
					x4b101060f4767186.DrawRectangle (pen1, rectangle1);
				}
				if (this.BorderWidth > 0)
				{
					if (this.EnableState)
					{
						pen1 = new Pen (base.xcd9cdf30888d2204.BackColor, ((float) this.BorderWidth));
					}
					else
					{
						pen1 = new Pen (Color.FromKnownColor (KnownColor.Control), ((float) this.BorderWidth));
					}
					rectangle1.X += this.BorderWidth;
					rectangle1.Y += this.BorderWidth;
					rectangle1.Width -= (this.BorderWidth + 1);
					rectangle1.Height -= (this.BorderWidth + 1);
					x4b101060f4767186.DrawLine (pen1, rectangle1.Left, 1, rectangle1.Left, rectangle1.Bottom);
					x4b101060f4767186.DrawLine (pen1, rectangle1.Left, rectangle1.Top, rectangle1.Right, rectangle1.Top);
					pen1.Dispose ();
				}
			}
			
		#endregion
	}
	
}

