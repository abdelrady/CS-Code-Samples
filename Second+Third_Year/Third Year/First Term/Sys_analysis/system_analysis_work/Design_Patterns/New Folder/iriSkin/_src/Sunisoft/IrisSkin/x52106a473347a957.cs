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
		
	internal class x52106a473347a957 : x5b126f5f998c28e9
	
	{
		
		#region Fields
			private int x01b557925841ae51;
			private Timer x420067493d7ebb36;
			private bool x5e45bc5ff748c78c;
		#endregion
		
		#region Constructors
		
			public x52106a473347a957 (IntPtr handle, ISkinEngine engine)
				 : base (handle, engine)
			/*
				// Code Size: 84 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: newobj System.Windows.Forms.Timer::Void .ctor()
				L_0006: stfld Sunisoft.IrisSkin.x52106a473347a957::System.Windows.Forms.Timer x420067493d7ebb36
				L_000b: ldarg.0 
				L_000c: ldc.i4.0 
				L_000d: stfld Sunisoft.IrisSkin.x52106a473347a957::Boolean x5e45bc5ff748c78c
				L_0012: ldarg.0 
				L_0013: ldc.i4.0 
				L_0014: stfld Sunisoft.IrisSkin.x52106a473347a957::Int32 x01b557925841ae51
				L_0019: ldarg.0 
				L_001a: ldarg.1 
				L_001b: ldarg.2 
				L_001c: call Sunisoft.IrisSkin.x5b126f5f998c28e9::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_0021: ldarg.0 
				L_0022: ldfld Sunisoft.IrisSkin.x52106a473347a957::System.Windows.Forms.Timer x420067493d7ebb36
				L_0027: ldc.i4 138
				L_002c: callvirt System.Windows.Forms.Timer::Void set_Interval(Int32)
				L_0031: ldarg.0 
				L_0032: ldfld Sunisoft.IrisSkin.x52106a473347a957::System.Windows.Forms.Timer x420067493d7ebb36
				L_0037: ldarg.0 
				L_0038: ldftn Sunisoft.IrisSkin.x52106a473347a957::Void x0f7fdae17d8cfcb5(System.Object, System.EventArgs)
				L_003e: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0043: callvirt System.Windows.Forms.Timer::Void add_Tick(System.EventHandler)
				L_0048: ldarg.0 
				L_0049: ldfld Sunisoft.IrisSkin.x52106a473347a957::System.Windows.Forms.Timer x420067493d7ebb36
				L_004e: callvirt System.Windows.Forms.Timer::Void Start()
				L_0053: ret 
			*/
		#endregion
		
		#region Methods
		
			protected override bool BeforeWndProc (ref Message m)
			
			/*
				// Code Size: 192 Bytes
				.maxstack 6
				.locals (System.UInt32 V_0, 
         System.IntPtr V_1)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0006: stloc.0 
				L_0007: ldloc.0 
				L_0008: ldc.i4 243
				L_000d: beq.s L_0024
				L_000f: ldloc.0 
				L_0010: ldc.i4 257
				L_0015: beq.s L_0071
				L_0017: ldloc.0 
				L_0018: ldc.i4 514
				L_001d: beq.s L_003a
				L_001f: br L_00b8
				L_0024: ldarg.0 
				L_0025: ldarg.1 
				L_0026: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_002b: stloc.1 
				L_002c: ldloca.s V_1
				L_002e: call System.IntPtr::Int32 ToInt32()
				L_0033: stfld Sunisoft.IrisSkin.x52106a473347a957::Int32 x01b557925841ae51
				L_0038: ldc.i4.0 
				L_0039: ret 
				L_003a: ldarg.0 
				L_003b: ldfld Sunisoft.IrisSkin.x52106a473347a957::Int32 x01b557925841ae51
				L_0040: ldc.i4.1 
				L_0041: bne.un.s L_00b8
				L_0043: ldarg.0 
				L_0044: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0049: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetParent(IntPtr)
				L_004e: ldc.i4 273
				L_0053: ldarg.0 
				L_0054: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0059: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 GetDlgCtrlID(IntPtr)
				L_005e: newobj System.IntPtr::Void .ctor(Int32)
				L_0063: ldarg.0 
				L_0064: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0069: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, IntPtr, IntPtr)
				L_006e: pop 
				L_006f: br.s L_00b8
				L_0071: ldarg.0 
				L_0072: ldfld Sunisoft.IrisSkin.x52106a473347a957::Int32 x01b557925841ae51
				L_0077: ldc.i4.1 
				L_0078: bne.un.s L_00b8
				L_007a: ldarg.1 
				L_007b: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_0080: stloc.1 
				L_0081: ldloca.s V_1
				L_0083: call System.IntPtr::Int32 ToInt32()
				L_0088: ldc.i4.s 32
				L_008a: bne.un.s L_00b8
				L_008c: ldarg.0 
				L_008d: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0092: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetParent(IntPtr)
				L_0097: ldc.i4 273
				L_009c: ldarg.0 
				L_009d: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_00a2: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 GetDlgCtrlID(IntPtr)
				L_00a7: newobj System.IntPtr::Void .ctor(Int32)
				L_00ac: ldarg.0 
				L_00ad: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_00b2: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, IntPtr, IntPtr)
				L_00b7: pop 
				L_00b8: ldarg.0 
				L_00b9: ldarg.1 
				L_00ba: call Sunisoft.IrisSkin.x5b126f5f998c28e9::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_00bf: ret 
			*/
			
			
			{
				uint uInt32_1 = ((uint) m.Msg);
				if (uInt32_1 == 243)
				{
					this.x01b557925841ae51 = m.WParam.ToInt32 ();
					return false;
				}
				else
				{
					if (uInt32_1 == 257)
					{
						if ((this.x01b557925841ae51 == 1) && (m.WParam.ToInt32 () == 32))
						{
							bool b2 = x61467fe65a98f20c.PostMessage (x61467fe65a98f20c.GetParent (base.Handle), 273, new IntPtr (x61467fe65a98f20c.GetDlgCtrlID (base.Handle)), base.Handle);
						}
					}
					else if ((uInt32_1 == 514) && (this.x01b557925841ae51 == 1))
					{
						bool b1 = x61467fe65a98f20c.PostMessage (x61467fe65a98f20c.GetParent (base.Handle), 273, new IntPtr (x61467fe65a98f20c.GetDlgCtrlID (base.Handle)), base.Handle);
					}
					return base.BeforeWndProc (ref m);
				}
			}
			
			protected override void PaintControl ()
			
			/*
				// Code Size: 60 Bytes
				.maxstack 3
				.locals (System.Drawing.Graphics V_0)
				.try L_0028 to L_0031 finally L_0031 to L_003b
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Boolean get_CanPaint()
				L_0006: brtrue.s L_0009
				L_0008: ret 
				L_0009: ldarg.0 
				L_000a: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Int32 get_Width()
				L_000f: ldc.i4.0 
				L_0010: ble.s L_001b
				L_0012: ldarg.0 
				L_0013: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Int32 get_Height()
				L_0018: ldc.i4.0 
				L_0019: bgt.s L_001c
				L_001b: ret 
				L_001c: ldarg.0 
				L_001d: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0022: call System.Drawing.Graphics::System.Drawing.Graphics FromHwnd(IntPtr)
				L_0027: stloc.0 
				L_0028: ldarg.0 
				L_0029: ldloc.0 
				L_002a: call Sunisoft.IrisSkin.x52106a473347a957::Void x8bc95f030953f87b(System.Drawing.Graphics)
				L_002f: leave.s L_003b
				L_0031: ldloc.0 
				L_0032: brfalse.s L_003a
				L_0034: ldloc.0 
				L_0035: callvirt System.IDisposable::Void Dispose()
				L_003a: endfinally 
				L_003b: ret 
			*/
			
			
			{
				if ((this.CanPaint && (this.Width > 0)) && (this.Height > 0))
				{
					using (Graphics graphics1 = Graphics.FromHwnd (base.Handle))
					{
						this.x8bc95f030953f87b (graphics1);
					}
				}
			}
			
			private void x0f7fdae17d8cfcb5 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 149 Bytes
				.maxstack 7
				.locals (Sunisoft.IrisSkin.xb9506a535e31f22a V_0, 
         System.Drawing.Point V_1, 
         Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_2)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.x52106a473347a957::Boolean x5e45bc5ff748c78c
				L_0006: brtrue.s L_0015
				L_0008: ldarg.0 
				L_0009: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Void PaintControl()
				L_000e: ldarg.0 
				L_000f: ldc.i4.1 
				L_0010: stfld Sunisoft.IrisSkin.x52106a473347a957::Boolean x5e45bc5ff748c78c
				L_0015: ldc.i4.1 
				L_0016: stloc.0 
				L_0017: ldloca.s V_1
				L_0019: ldc.i4.0 
				L_001a: ldc.i4.0 
				L_001b: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0020: ldloca.s V_2
				L_0022: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
				L_0028: ldloca.s V_1
				L_002a: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetCursorPos(System.Drawing.Point ByRef)
				L_002f: brfalse.s L_0094
				L_0031: ldarg.0 
				L_0032: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0037: ldloca.s V_2
				L_0039: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowRect(IntPtr, RECT ByRef)
				L_003e: pop 
				L_003f: ldloc.1 
				L_0040: ldloca.s V_2
				L_0042: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0047: ldloca.s V_2
				L_0049: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_004e: ldloca.s V_2
				L_0050: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0055: ldloca.s V_2
				L_0057: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_005c: sub 
				L_005d: ldloca.s V_2
				L_005f: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0064: ldloca.s V_2
				L_0066: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_006b: sub 
				L_006c: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0071: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0076: brfalse.s L_007c
				L_0078: ldc.i4.2 
				L_0079: stloc.0 
				L_007a: br.s L_007e
				L_007c: ldc.i4.1 
				L_007d: stloc.0 
				L_007e: ldarg.0 
				L_007f: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0084: ldloc.0 
				L_0085: beq.s L_0094
				L_0087: ldarg.0 
				L_0088: ldloc.0 
				L_0089: stfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_008e: ldarg.0 
				L_008f: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Void PaintControl()
				L_0094: ret 
			*/
			
			
			{
				xb9506a535e31f22a xb9506a535e31f22a1;
				Point point1;
				if (! this.x5e45bc5ff748c78c)
				{
					this.PaintControl ();
					this.x5e45bc5ff748c78c = true;
				}
				point1 = new Point (0, 0);
				xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
				if (x61467fe65a98f20c.GetCursorPos (ref point1))
				{
					bool b1 = x61467fe65a98f20c.GetWindowRect (base.Handle, ref rECT1);
					if (x448fd9ab43628c71.x9466a6be27202526 (point1, new Rectangle (rECT1.left, rECT1.top, ((int) (rECT1.right - rECT1.left)), ((int) (rECT1.bottom - rECT1.top)))))
					{
						xb9506a535e31f22a1 = xb9506a535e31f22a.x38f64d20b794f1fc;
					}
					else
					{
						xb9506a535e31f22a1 = xb9506a535e31f22a.x4d0b9d4447ba7566;
					}
					if (base.xdd938462da9aed37 != xb9506a535e31f22a1)
					{
						base.xdd938462da9aed37 = xb9506a535e31f22a1;
						this.PaintControl ();
					}
				}
			}
			
			private void x6b515e4773b2f185 (Graphics x4b101060f4767186, Bitmap x5ce6bc2fb6fe458d, string x1c2743f354837549, System.Drawing.Font x26094932cf7a9139, Rectangle x59dcf7372713ec60)
			
			/*
				// Code Size: 119 Bytes
				.maxstack 6
				.locals (System.Drawing.Brush V_0)
				L_0000: ldnull 
				L_0001: stloc.0 
				L_0002: ldarg.1 
				L_0003: ldarg.2 
				L_0004: ldarg.0 
				L_0005: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::System.Drawing.Rectangle get_ClientRectangle()
				L_000a: ldarg.0 
				L_000b: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::System.Drawing.Rectangle get_ClientRectangle()
				L_0010: ldc.i4.2 
				L_0011: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0016: ldarg.3 
				L_0017: brfalse.s L_0065
				L_0019: ldarg.3 
				L_001a: ldstr ""
				L_001f: call System.String::Boolean op_Inequality(System.String, System.String)
				L_0024: brfalse.s L_0065
				L_0026: ldarg.0 
				L_0027: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Boolean get_Enabled()
				L_002c: brtrue.s L_0036
				L_002e: call System.Drawing.Brushes::System.Drawing.Brush get_Gray()
				L_0033: stloc.0 
				L_0034: br.s L_0042
				L_0036: ldarg.0 
				L_0037: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::System.Drawing.Color get_ForeColor()
				L_003c: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0041: stloc.0 
				L_0042: ldarg.0 
				L_0043: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0048: ldc.i4.3 
				L_0049: bne.un.s L_0054
				L_004b: ldarga.s x59dcf7372713ec60
				L_004d: ldc.i4.1 
				L_004e: ldc.i4.1 
				L_004f: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x897356c8698a543c(System.Drawing.Rectangle ByRef, Int32, Int32)
				L_0054: ldarg.1 
				L_0055: ldarg.3 
				L_0056: ldarg.s x26094932cf7a9139
				L_0058: ldloc.0 
				L_0059: ldarg.s x59dcf7372713ec60
				L_005b: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_0060: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF)
				L_0065: ldloc.0 
				L_0066: brfalse.s L_0076
				L_0068: ldarg.0 
				L_0069: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Boolean get_Enabled()
				L_006e: brfalse.s L_0076
				L_0070: ldloc.0 
				L_0071: callvirt System.Drawing.Brush::Void Dispose()
				L_0076: ret 
			*/
			
			
			{
				Brush brush1 = ((Brush) null);
				x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), this.ClientRectangle, this.ClientRectangle, GraphicsUnit.Pixel);
				if ((x1c2743f354837549 != null) && (x1c2743f354837549 != ""))
				{
					if (! this.Enabled)
					{
						brush1 = Brushes.Gray;
					}
					else
					{
						brush1 = ((Brush) new SolidBrush (this.ForeColor));
					}
					if (base.xdd938462da9aed37 == xb9506a535e31f22a.x51fcce5a95fca000)
					{
						x448fd9ab43628c71.x897356c8698a543c (ref x59dcf7372713ec60, 1, 1);
					}
					x4b101060f4767186.DrawString (x1c2743f354837549, x26094932cf7a9139, brush1, ((RectangleF) x59dcf7372713ec60));
				}
				if ((brush1 != null) && this.Enabled)
				{
					brush1.Dispose ();
				}
			}
			
			private void x6b515e4773b2f185 (Graphics x4b101060f4767186, Bitmap x5ce6bc2fb6fe458d)
			
			/*
				// Code Size: 21 Bytes
				.maxstack 9
				L_0000: ldarg.1 
				L_0001: ldarg.2 
				L_0002: ldarg.0 
				L_0003: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::System.Drawing.Rectangle get_ClientRectangle()
				L_0008: ldarg.0 
				L_0009: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::System.Drawing.Rectangle get_ClientRectangle()
				L_000e: ldc.i4.2 
				L_000f: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0014: ret 
			*/
			
			
			{
				x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), this.ClientRectangle, this.ClientRectangle, GraphicsUnit.Pixel);
			}
			
			private void x6f37a3496a324cf4 (Graphics x4b101060f4767186, string xb41faee6912a2313)
			
			/*
				// Code Size: 111 Bytes
				.maxstack 7
				.locals (System.Drawing.Rectangle V_0, 
         System.Drawing.StringFormat V_1, 
         System.Drawing.Brush V_2)
				L_0000: ldc.i4.s 32
				L_0002: ldarg.0 
				L_0003: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::System.Drawing.Rectangle get_ClientRectangle()
				L_0008: ldarg.0 
				L_0009: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_000e: ldloca.s V_0
				L_0010: ldloca.s V_1
				L_0012: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x323b3762dd22c667(System.Drawing.ContentAlignment, System.Drawing.Rectangle, System.Windows.Forms.RightToLeft, System.Drawing.Rectangle ByRef, System.Drawing.StringFormat ByRef)
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.x52106a473347a957::Int32 x01b557925841ae51
				L_001d: ldc.i4.1 
				L_001e: bne.un.s L_0033
				L_0020: ldloca.s V_0
				L_0022: ldarg.0 
				L_0023: ldfld Sunisoft.IrisSkin.x52106a473347a957::Int32 x01b557925841ae51
				L_0028: ldarg.0 
				L_0029: ldfld Sunisoft.IrisSkin.x52106a473347a957::Int32 x01b557925841ae51
				L_002e: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x897356c8698a543c(System.Drawing.Rectangle ByRef, Int32, Int32)
				L_0033: ldarg.0 
				L_0034: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Boolean get_Enabled()
				L_0039: brfalse.s L_0053
				L_003b: ldarg.0 
				L_003c: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0041: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0046: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_004b: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_BUTTONFONTCOLOR()
				L_0050: stloc.2 
				L_0051: br.s L_0059
				L_0053: call System.Drawing.Brushes::System.Drawing.Brush get_Gray()
				L_0058: stloc.2 
				L_0059: ldarg.1 
				L_005a: ldarg.2 
				L_005b: ldarg.0 
				L_005c: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::System.Drawing.Font get_Font()
				L_0061: ldloc.2 
				L_0062: ldloc.0 
				L_0063: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_0068: ldloc.1 
				L_0069: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_006e: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				StringFormat stringFormat1;
				Brush brush1;
				x448fd9ab43628c71.x323b3762dd22c667 (ContentAlignment.MiddleCenter, this.ClientRectangle, this.RightToLeft, out rectangle1, out stringFormat1);
				if (this.x01b557925841ae51 == 1)
				{
					x448fd9ab43628c71.x897356c8698a543c (ref rectangle1, this.x01b557925841ae51, this.x01b557925841ae51);
				}
				if (this.Enabled)
				{
					brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_BUTTONFONTCOLOR;
				}
				else
				{
					brush1 = Brushes.Gray;
				}
				x4b101060f4767186.DrawString (xb41faee6912a2313, this.Font, brush1, ((RectangleF) rectangle1), stringFormat1);
			}
			
			private void x8bc95f030953f87b (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 314 Bytes
				.maxstack 6
				.locals (System.Drawing.Rectangle V_0, 
         System.Int32 V_1, 
         System.Drawing.Bitmap V_2, 
         System.Drawing.Bitmap V_3, 
         System.Drawing.Graphics V_4, 
         System.Drawing.Brush V_5, 
         System.String V_6, 
         System.Drawing.Rectangle V_7)
				.try L_004e to L_0121 finally L_0121 to L_012d
				.try L_0046 to L_012f finally L_012f to L_0139
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0006: stloc.1 
				L_0007: ldarg.0 
				L_0008: ldfld Sunisoft.IrisSkin.x52106a473347a957::Int32 x01b557925841ae51
				L_000d: ldc.i4.1 
				L_000e: bne.un.s L_0012
				L_0010: ldc.i4.3 
				L_0011: stloc.1 
				L_0012: ldarg.0 
				L_0013: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Boolean get_Enabled()
				L_0018: brtrue.s L_001c
				L_001a: ldc.i4.1 
				L_001b: stloc.1 
				L_001c: ldarg.0 
				L_001d: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0022: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0027: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SplitBitmaps get_SplitBitmaps()
				L_002c: callvirt Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] get_SKIN2_BUTTON()
				L_0031: ldloc.1 
				L_0032: ldelem.ref 
				L_0033: stloc.2 
				L_0034: ldarg.0 
				L_0035: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Int32 get_Width()
				L_003a: ldarg.0 
				L_003b: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Int32 get_Height()
				L_0040: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0045: stloc.3 
				L_0046: ldloc.3 
				L_0047: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_004c: stloc.s V_4
				L_004e: ldarg.0 
				L_004f: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0054: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0059: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_005e: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_0063: stloc.s V_5
				L_0065: ldloc.s V_4
				L_0067: ldloc.s V_5
				L_0069: ldarg.0 
				L_006a: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::System.Drawing.Rectangle get_ClientRectangle()
				L_006f: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0074: ldloc.2 
				L_0075: ldloc.s V_4
				L_0077: ldarg.0 
				L_0078: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::System.Drawing.Rectangle get_ClientRectangle()
				L_007d: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x779038d721b14f75(System.Drawing.Bitmap, System.Drawing.Graphics, System.Drawing.Rectangle)
				L_0082: ldarg.0 
				L_0083: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::System.String get_Text()
				L_0088: stloc.s V_6
				L_008a: ldloc.s V_6
				L_008c: brfalse.s L_00a6
				L_008e: ldloc.s V_6
				L_0090: ldstr ""
				L_0095: call System.String::Boolean op_Inequality(System.String, System.String)
				L_009a: brfalse.s L_00a6
				L_009c: ldarg.0 
				L_009d: ldloc.s V_4
				L_009f: ldloc.s V_6
				L_00a1: call Sunisoft.IrisSkin.x52106a473347a957::Void x6f37a3496a324cf4(System.Drawing.Graphics, System.String)
				L_00a6: ldarg.0 
				L_00a7: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Boolean get_Focused()
				L_00ac: brfalse.s L_0117
				L_00ae: ldarg.0 
				L_00af: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::System.Drawing.Rectangle get_ClientRectangle()
				L_00b4: stloc.s V_7
				L_00b6: ldloca.s V_7
				L_00b8: call System.Drawing.Rectangle::Int32 get_Left()
				L_00bd: ldc.i4.4 
				L_00be: add 
				L_00bf: ldarg.0 
				L_00c0: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::System.Drawing.Rectangle get_ClientRectangle()
				L_00c5: stloc.s V_7
				L_00c7: ldloca.s V_7
				L_00c9: call System.Drawing.Rectangle::Int32 get_Top()
				L_00ce: ldc.i4.4 
				L_00cf: add 
				L_00d0: ldarg.0 
				L_00d1: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::System.Drawing.Rectangle get_ClientRectangle()
				L_00d6: stloc.s V_7
				L_00d8: ldloca.s V_7
				L_00da: call System.Drawing.Rectangle::Int32 get_Right()
				L_00df: ldc.i4.5 
				L_00e0: sub 
				L_00e1: ldarg.0 
				L_00e2: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::System.Drawing.Rectangle get_ClientRectangle()
				L_00e7: stloc.s V_7
				L_00e9: ldloca.s V_7
				L_00eb: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_00f0: ldc.i4.5 
				L_00f1: sub 
				L_00f2: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_00f7: stloc.0 
				L_00f8: ldarg.0 
				L_00f9: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_00fe: ldc.i4.3 
				L_00ff: bne.un.s L_010a
				L_0101: ldloca.s V_0
				L_0103: ldc.i4.1 
				L_0104: ldc.i4.1 
				L_0105: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x897356c8698a543c(System.Drawing.Rectangle ByRef, Int32, Int32)
				L_010a: ldloc.s V_4
				L_010c: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Pen get_x6ee6589d93f80946()
				L_0111: ldloc.0 
				L_0112: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_0117: ldarg.0 
				L_0118: ldarg.1 
				L_0119: ldloc.3 
				L_011a: call Sunisoft.IrisSkin.x52106a473347a957::Void x6b515e4773b2f185(System.Drawing.Graphics, System.Drawing.Bitmap)
				L_011f: leave.s L_012d
				L_0121: ldloc.s V_4
				L_0123: brfalse.s L_012c
				L_0125: ldloc.s V_4
				L_0127: callvirt System.IDisposable::Void Dispose()
				L_012c: endfinally 
				L_012d: leave.s L_0139
				L_012f: ldloc.3 
				L_0130: brfalse.s L_0138
				L_0132: ldloc.3 
				L_0133: callvirt System.IDisposable::Void Dispose()
				L_0138: endfinally 
				L_0139: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Brush brush1;
				string string1;
				int i1 = ((int) base.xdd938462da9aed37);
				if (this.x01b557925841ae51 == 1)
				{
					i1 = 3;
				}
				if (! this.Enabled)
				{
					i1 = 1;
				}
				Bitmap bitmap1 = ((SplitBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).SplitBitmaps).SKIN2_BUTTON[i1];
				using (Bitmap bitmap2 = new Bitmap (this.Width, this.Height))
				{
					using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap2)))
					{
						brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR;
						graphics1.FillRectangle (brush1, this.ClientRectangle);
						x448fd9ab43628c71.x779038d721b14f75 (bitmap1, graphics1, this.ClientRectangle);
						string1 = this.Text;
						if ((string1 != null) && (string1 != ""))
						{
							this.x6f37a3496a324cf4 (graphics1, string1);
						}
						if (this.Focused)
						{
							rectangle1 = Rectangle.FromLTRB (((int) (this.ClientRectangle.Left + 4)), ((int) (this.ClientRectangle.Top + 4)), ((int) (this.ClientRectangle.Right - 5)), ((int) (this.ClientRectangle.Bottom - 5)));
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
			
		#endregion
	}
	
}

