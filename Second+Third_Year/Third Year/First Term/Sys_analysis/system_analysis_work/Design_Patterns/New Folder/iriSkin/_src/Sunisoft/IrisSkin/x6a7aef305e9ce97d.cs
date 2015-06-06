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
		
	internal class x6a7aef305e9ce97d : x2edc3f693fe78d2e
	
	{
		
		#region Fields
			private const int xc2b2889221bc8c5e = 21;
		#endregion
		
		#region Constructors
		
			public x6a7aef305e9ce97d (Control control, ISkinEngine engine)
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
		
			protected override void PaintControl ()
			
			/*
				// Code Size: 219 Bytes
				.maxstack 5
				.locals (System.Windows.Forms.DateTimePicker V_0, 
         System.Drawing.Bitmap V_1, 
         System.Drawing.Graphics V_2, 
         System.IntPtr V_3, 
         System.Drawing.Graphics V_4, 
         System.Drawing.Rectangle V_5)
				.try L_0078 to L_0081 finally L_0081 to L_008b
				.try L_00a4 to L_00b0 finally L_00b0 to L_00bc
				.try L_0071 to L_00d0 finally L_00d0 to L_00da
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_000b: stloc.s V_5
				L_000d: ldloca.s V_5
				L_000f: call System.Drawing.Rectangle::Int32 get_Width()
				L_0014: ldc.i4.0 
				L_0015: ble.s L_002e
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001d: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0022: stloc.s V_5
				L_0024: ldloca.s V_5
				L_0026: call System.Drawing.Rectangle::Int32 get_Height()
				L_002b: ldc.i4.0 
				L_002c: bgt.s L_002f
				L_002e: ret 
				L_002f: ldarg.0 
				L_0030: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0035: brtrue.s L_0038
				L_0037: ret 
				L_0038: ldarg.0 
				L_0039: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void PaintControl()
				L_003e: ldarg.0 
				L_003f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0044: castclass System.Windows.Forms.DateTimePicker
				L_0049: stloc.0 
				L_004a: ldloc.0 
				L_004b: callvirt System.Windows.Forms.DateTimePicker::Boolean get_ShowUpDown()
				L_0050: brtrue L_00da
				L_0055: ldarg.0 
				L_0056: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_005b: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0060: ldarg.0 
				L_0061: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0066: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_006b: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0070: stloc.1 
				L_0071: ldloc.1 
				L_0072: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0077: stloc.2 
				L_0078: ldarg.0 
				L_0079: ldloc.2 
				L_007a: call Sunisoft.IrisSkin.x6a7aef305e9ce97d::Void x8bc95f030953f87b(System.Drawing.Graphics)
				L_007f: leave.s L_008b
				L_0081: ldloc.2 
				L_0082: brfalse.s L_008a
				L_0084: ldloc.2 
				L_0085: callvirt System.IDisposable::Void Dispose()
				L_008a: endfinally 
				L_008b: ldarg.0 
				L_008c: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0091: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0096: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindowDC(IntPtr)
				L_009b: stloc.3 
				L_009c: ldloc.3 
				L_009d: call System.Drawing.Graphics::System.Drawing.Graphics FromHdc(IntPtr)
				L_00a2: stloc.s V_4
				L_00a4: ldloc.s V_4
				L_00a6: ldloc.1 
				L_00a7: ldc.i4.0 
				L_00a8: ldc.i4.0 
				L_00a9: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_00ae: leave.s L_00bc
				L_00b0: ldloc.s V_4
				L_00b2: brfalse.s L_00bb
				L_00b4: ldloc.s V_4
				L_00b6: callvirt System.IDisposable::Void Dispose()
				L_00bb: endfinally 
				L_00bc: ldarg.0 
				L_00bd: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_00c2: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_00c7: ldloc.3 
				L_00c8: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_00cd: pop 
				L_00ce: leave.s L_00da
				L_00d0: ldloc.1 
				L_00d1: brfalse.s L_00d9
				L_00d3: ldloc.1 
				L_00d4: callvirt System.IDisposable::Void Dispose()
				L_00d9: endfinally 
				L_00da: ret 
			*/
			
			
			{
				IntPtr intPtr1;
				if (((base.xcd9cdf30888d2204.ClientRectangle.Width <= 0) || (base.xcd9cdf30888d2204.ClientRectangle.Height <= 0)) || (! base.xf2140268ef7ddbf7))
				{
					return;
				}
				base.PaintControl ();
				DateTimePicker dateTimePicker1 = ((DateTimePicker) base.xcd9cdf30888d2204);
				if (! dateTimePicker1.ShowUpDown)
				{
					using (Bitmap bitmap1 = new Bitmap (base.xcd9cdf30888d2204.Width, base.xcd9cdf30888d2204.Height))
					{
						using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap1)))
						{
							this.x8bc95f030953f87b (graphics1);
						}
						intPtr1 = x61467fe65a98f20c.GetWindowDC (base.xcd9cdf30888d2204.Handle);
						using (Graphics graphics2 = Graphics.FromHdc (intPtr1))
						{
							graphics2.DrawImageUnscaled (((Image) bitmap1), 0, 0);
						}
						int i1 = x61467fe65a98f20c.ReleaseDC (base.xcd9cdf30888d2204.Handle, intPtr1);
					}
				}
			}
			
			private void x373a1ceeebad6a15 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
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
				// Code Size: 224 Bytes
				.maxstack 7
				.locals (System.Windows.Forms.DateTimePicker V_0, 
         System.Drawing.Rectangle V_1, 
         System.Drawing.Brush V_2, 
         System.Drawing.Pen V_3)
				.try L_00a1 to L_00ab finally L_00ab to L_00b5
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.DateTimePicker
				L_000b: stloc.0 
				L_000c: ldloca.s V_1
				L_000e: ldloc.0 
				L_000f: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0014: ldc.i4.s 21
				L_0016: sub 
				L_0017: ldc.i4.0 
				L_0018: ldc.i4.s 21
				L_001a: ldloc.0 
				L_001b: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0020: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0025: ldarg.0 
				L_0026: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_002b: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0030: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0035: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_003a: stloc.2 
				L_003b: ldloca.s V_1
				L_003d: dup 
				L_003e: call System.Drawing.Rectangle::Int32 get_X()
				L_0043: ldc.i4.2 
				L_0044: add 
				L_0045: call System.Drawing.Rectangle::Void set_X(Int32)
				L_004a: ldloca.s V_1
				L_004c: dup 
				L_004d: call System.Drawing.Rectangle::Int32 get_Y()
				L_0052: ldc.i4.2 
				L_0053: add 
				L_0054: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_0059: ldloca.s V_1
				L_005b: dup 
				L_005c: call System.Drawing.Rectangle::Int32 get_Width()
				L_0061: ldc.i4.5 
				L_0062: sub 
				L_0063: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0068: ldloca.s V_1
				L_006a: dup 
				L_006b: call System.Drawing.Rectangle::Int32 get_Height()
				L_0070: ldc.i4.5 
				L_0071: sub 
				L_0072: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_0077: ldarg.1 
				L_0078: ldloc.2 
				L_0079: ldloc.1 
				L_007a: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_007f: ldarg.0 
				L_0080: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0085: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_008a: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_008f: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_CONTROLBORDERCOLOR()
				L_0094: stloc.2 
				L_0095: ldloc.2 
				L_0096: ldc.r4 1
				L_009b: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush, Single)
				L_00a0: stloc.3 
				L_00a1: ldarg.1 
				L_00a2: ldloc.3 
				L_00a3: ldloc.1 
				L_00a4: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_00a9: leave.s L_00b5
				L_00ab: ldloc.3 
				L_00ac: brfalse.s L_00b4
				L_00ae: ldloc.3 
				L_00af: callvirt System.IDisposable::Void Dispose()
				L_00b4: endfinally 
				L_00b5: ldarg.1 
				L_00b6: ldloca.s V_1
				L_00b8: call System.Drawing.Rectangle::Int32 get_X()
				L_00bd: ldc.i4.s 10
				L_00bf: add 
				L_00c0: ldc.i4.5 
				L_00c1: sub 
				L_00c2: ldloca.s V_1
				L_00c4: call System.Drawing.Rectangle::Int32 get_Y()
				L_00c9: ldloc.0 
				L_00ca: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_00cf: ldc.i4.2 
				L_00d0: div 
				L_00d1: add 
				L_00d2: ldc.i4.3 
				L_00d3: sub 
				L_00d4: ldloc.0 
				L_00d5: callvirt System.Windows.Forms.Control::Boolean get_Enabled()
				L_00da: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x3fbffc8bcd27b3c0(System.Drawing.Graphics, Int32, Int32, Boolean)
				L_00df: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				DateTimePicker dateTimePicker1 = ((DateTimePicker) base.xcd9cdf30888d2204);
				rectangle1 = new Rectangle (((int) (dateTimePicker1.Width - 21)), 0, 21, dateTimePicker1.Height);
				Brush brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR;
				rectangle1.X += 2;
				rectangle1.Y += 2;
				rectangle1.Width -= 5;
				rectangle1.Height -= 5;
				x4b101060f4767186.FillRectangle (brush1, rectangle1);
				brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_CONTROLBORDERCOLOR;
				using (Pen pen1 = new Pen (brush1, 1F))
				{
					x4b101060f4767186.DrawRectangle (pen1, rectangle1);
				}
				x448fd9ab43628c71.x3fbffc8bcd27b3c0 (x4b101060f4767186, ((int) ((rectangle1.X + 10) - 5)), ((int) ((rectangle1.Y + (dateTimePicker1.Height / 2)) - 3)), dateTimePicker1.Enabled);
			}
			
		#endregion
	}
	
}

