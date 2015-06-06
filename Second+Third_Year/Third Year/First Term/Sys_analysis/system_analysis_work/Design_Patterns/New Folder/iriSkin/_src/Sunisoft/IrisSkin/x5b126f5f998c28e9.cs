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
			using System.Text;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class x5b126f5f998c28e9 : NativeWindow
	
	{
		
		#region Fields
			protected ISkinEngine xdc87e2b99332cd4a;
			protected xb9506a535e31f22a xdd938462da9aed37;
		#endregion
		
		#region Constructors
		
			public x5b126f5f998c28e9 (IntPtr handle, ISkinEngine engine)
			/*
				// Code Size: 28 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.1 
				L_0002: stfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0007: ldarg.0 
				L_0008: call System.Windows.Forms.NativeWindow::Void .ctor()
				L_000d: ldarg.0 
				L_000e: ldarg.2 
				L_000f: stfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0014: ldarg.0 
				L_0015: ldarg.1 
				L_0016: call System.Windows.Forms.NativeWindow::Void AssignHandle(IntPtr)
				L_001b: ret 
			*/
		#endregion
		
		#region Properties
		
			protected virtual bool CanPaint
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0006: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_RealActive()
					L_000b: ret 
				*/
				
				{
					return ((SkinEngine) this.xdc87e2b99332cd4a).RealActive;
				}
			}
			
			
			protected virtual Rectangle ClientRectangle
			
			{
				get
				
				/*
					// Code Size: 27 Bytes
					.maxstack 6
					.locals (System.Drawing.Rectangle V_0)
					L_0000: ldloca.s V_0
					L_0002: ldc.i4.0 
					L_0003: ldc.i4.0 
					L_0004: ldc.i4.0 
					L_0005: ldc.i4.0 
					L_0006: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
					L_000b: ldarg.0 
					L_000c: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0011: ldloca.s V_0
					L_0013: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetClientRect(IntPtr, System.Drawing.Rectangle ByRef)
					L_0018: pop 
					L_0019: ldloc.0 
					L_001a: ret 
				*/
				
				{
					Rectangle rectangle1;
					rectangle1 = new Rectangle (0, 0, 0, 0);
					bool b1 = x61467fe65a98f20c.GetClientRect (base.Handle, ref rectangle1);
					return rectangle1;
				}
			}
			
			
			protected virtual bool Enabled
			
			{
				get
				
				/*
					// Code Size: 32 Bytes
					.maxstack 3
					.locals (System.UInt32 V_0)
					L_0000: ldarg.0 
					L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0006: ldc.i4.s -16
					L_0008: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
					L_000d: stloc.0 
					L_000e: ldloc.0 
					L_000f: ldc.i4 134217728
					L_0014: and 
					L_0015: ldc.i4 134217728
					L_001a: ceq 
					L_001c: ldc.i4.0 
					L_001d: ceq 
					L_001f: ret 
				*/
				
				{
					uint uInt32_1 = x61467fe65a98f20c.GetWindowLong (base.Handle, -16);
					return ((((int) uInt32_1) & 134217728) != 134217728);
				}
			}
			
			
			protected virtual bool Focused
			
			{
				get
				
				/*
					// Code Size: 17 Bytes
					.maxstack 9
					L_0000: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetFocus()
					L_0005: ldarg.0 
					L_0006: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_000b: call System.IntPtr::Boolean op_Equality(IntPtr, IntPtr)
					L_0010: ret 
				*/
				
				{
					return (x61467fe65a98f20c.GetFocus () == base.Handle);
				}
			}
			
			
			protected virtual Font Font
			
			{
				get
				
				/*
					// Code Size: 6 Bytes
					.maxstack 9
					L_0000: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Font xfc84e4da153943c2()
					L_0005: ret 
				*/
				
				{
					return x448fd9ab43628c71.xfc84e4da153943c2 ();
				}
			}
			
			
			protected virtual Color ForeColor
			
			{
				get
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldc.i4.s 10
					L_0002: call System.Drawing.Color::System.Drawing.Color FromKnownColor(System.Drawing.KnownColor)
					L_0007: ret 
				*/
				
				{
					return Color.FromKnownColor (KnownColor.ControlText);
				}
			}
			
			
			protected virtual int Height
			
			{
				get
				
				/*
					// Code Size: 30 Bytes
					.maxstack 3
					.locals (Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_0)
					L_0000: ldloca.s V_0
					L_0002: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
					L_0008: ldarg.0 
					L_0009: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_000e: ldloca.s V_0
					L_0010: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetClientRect(IntPtr, RECT ByRef)
					L_0015: pop 
					L_0016: ldloca.s V_0
					L_0018: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
					L_001d: ret 
				*/
				
				{
					xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
					bool b1 = x61467fe65a98f20c.GetClientRect (base.Handle, ref rECT1);
					return rECT1.bottom;
				}
			}
			
			
			protected virtual RightToLeft RightToLeft
			
			{
				get
				
				/*
					// Code Size: 32 Bytes
					.maxstack 3
					.locals (System.UInt32 V_0)
					L_0000: ldarg.0 
					L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0006: ldc.i4.s -20
					L_0008: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
					L_000d: stloc.0 
					L_000e: ldloc.0 
					L_000f: ldc.i4 4096
					L_0014: and 
					L_0015: ldc.i4 4096
					L_001a: beq.s L_001e
					L_001c: ldc.i4.0 
					L_001d: ret 
					L_001e: ldc.i4.1 
					L_001f: ret 
				*/
				
				{
					uint uInt32_1 = x61467fe65a98f20c.GetWindowLong (base.Handle, -20);
					if ((((int) uInt32_1) & 4096) == 4096)
					{
						return System.Windows.Forms.RightToLeft.Yes;
					}
					else
					{
						return System.Windows.Forms.RightToLeft.No;
					}
				}
			}
			
			
			protected virtual string Text
			
			{
				get
				
				/*
					// Code Size: 57 Bytes
					.maxstack 4
					.locals (System.Int32 V_0, 
         System.Text.StringBuilder V_1)
					L_0000: ldarg.0 
					L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0006: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 GetWindowTextLengthA(IntPtr)
					L_000b: stloc.0 
					L_000c: ldloc.0 
					L_000d: ldc.i4.0 
					L_000e: ble.s L_0033
					L_0010: ldloc.0 
					L_0011: ldc.i4.1 
					L_0012: add 
					L_0013: stloc.0 
					L_0014: ldloc.0 
					L_0015: newobj System.Text.StringBuilder::Void .ctor(Int32)
					L_001a: stloc.1 
					L_001b: ldarg.0 
					L_001c: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0021: ldloc.1 
					L_0022: ldloc.0 
					L_0023: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 GetWindowText(IntPtr, System.Text.StringBuilder, Int32)
					L_0028: pop 
					L_0029: ldloc.1 
					L_002a: brfalse.s L_0033
					L_002c: ldloc.1 
					L_002d: callvirt System.Text.StringBuilder::System.String ToString()
					L_0032: ret 
					L_0033: ldstr ""
					L_0038: ret 
				*/
				
				{
					int i1 = x61467fe65a98f20c.GetWindowTextLengthA (base.Handle);
					if (i1 <= 0)
					{
						return "";
					}
					i1++;
					StringBuilder stringBuilder1 = new StringBuilder (i1);
					int i2 = x61467fe65a98f20c.GetWindowText (base.Handle, stringBuilder1, i1);
					if (stringBuilder1 == null)
					{
						return "";
					}
					else
					{
						return stringBuilder1.ToString ();
					}
				}
			}
			
			
			protected virtual int Width
			
			{
				get
				
				/*
					// Code Size: 30 Bytes
					.maxstack 3
					.locals (Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_0)
					L_0000: ldloca.s V_0
					L_0002: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
					L_0008: ldarg.0 
					L_0009: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_000e: ldloca.s V_0
					L_0010: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetClientRect(IntPtr, RECT ByRef)
					L_0015: pop 
					L_0016: ldloca.s V_0
					L_0018: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
					L_001d: ret 
				*/
				
				{
					xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
					bool b1 = x61467fe65a98f20c.GetClientRect (base.Handle, ref rECT1);
					return rECT1.right;
				}
			}
			
		#endregion
		
		#region Methods
		
			protected virtual void AfterWndProc (ref Message m)
			
			/*
				// Code Size: 180 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT V_0, 
         System.UInt32 V_1)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0006: stloc.1 
				L_0007: ldloc.1 
				L_0008: ldc.i4.s 15
				L_000a: bgt.un.s L_0027
				L_000c: ldloc.1 
				L_000d: ldc.i4.s 10
				L_000f: sub 
				L_0010: switch (L_0089, L_00b3, L_0090)
				L_0021: ldloc.1 
				L_0022: ldc.i4.s 15
				L_0024: beq.s L_0090
				L_0026: ret 
				L_0027: ldloc.1 
				L_0028: ldc.i4 512
				L_002d: sub 
				L_002e: switch (L_0056, L_006d, L_007b)
				L_003f: ldloc.1 
				L_0040: ldc.i4 675
				L_0045: beq.s L_0048
				L_0047: ret 
				L_0048: ldarg.0 
				L_0049: ldc.i4.1 
				L_004a: stfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_004f: ldarg.0 
				L_0050: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Void PaintControl()
				L_0055: ret 
				L_0056: ldarg.0 
				L_0057: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_005c: ldc.i4.3 
				L_005d: beq.s L_0066
				L_005f: ldarg.0 
				L_0060: ldc.i4.2 
				L_0061: stfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0066: ldarg.0 
				L_0067: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Void PaintControl()
				L_006c: ret 
				L_006d: ldarg.0 
				L_006e: ldc.i4.3 
				L_006f: stfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0074: ldarg.0 
				L_0075: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Void PaintControl()
				L_007a: ret 
				L_007b: ldarg.0 
				L_007c: ldc.i4.1 
				L_007d: stfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0082: ldarg.0 
				L_0083: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Void PaintControl()
				L_0088: ret 
				L_0089: ldarg.0 
				L_008a: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Void PaintControl()
				L_008f: ret 
				L_0090: ldarg.0 
				L_0091: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0096: ldloca.s V_0
				L_0098: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr BeginPaint(IntPtr, PAINTSTRUCT ByRef)
				L_009d: pop 
				L_009e: ldarg.0 
				L_009f: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Void PaintControl()
				L_00a4: ldarg.0 
				L_00a5: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_00aa: ldloca.s V_0
				L_00ac: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean EndPaint(IntPtr, PAINTSTRUCT ByRef)
				L_00b1: pop 
				L_00b2: ret 
				L_00b3: ret 
			*/
			
			
			{
				x40255b11ef821fa3.PAINTSTRUCT pAINTSTRUCT1;
				uint uInt32_1;
				uInt32_1 = ((uint) m.Msg);
				if (uInt32_1 < 15)
				{
					switch (uInt32_1)
					{
						case 10:
						
						{
								this.PaintControl ();
								return;
						}
						case 11:
						
						{
								return;
						}
						case 12:
						
						{
								goto L_0090;
						}
					}
					if (uInt32_1 != 15)
					{
						return;
					}
					goto L_0090;
				}
				switch ((int) uInt32_1)
				{
					case 512:
					
					{
							if (this.xdd938462da9aed37 == xb9506a535e31f22a.x51fcce5a95fca000)
							{
								goto L_0066;
							}
							this.xdd938462da9aed37 = xb9506a535e31f22a.x38f64d20b794f1fc;
							goto L_0066;
					}
					case 513:
					
					{
							this.xdd938462da9aed37 = xb9506a535e31f22a.x51fcce5a95fca000;
							this.PaintControl ();
							return;
					}
					case 514:
					
					{
							this.xdd938462da9aed37 = xb9506a535e31f22a.x4d0b9d4447ba7566;
							this.PaintControl ();
							return;
					}
				}
				if (uInt32_1 != 675)
				{
					return;
				}
				this.xdd938462da9aed37 = xb9506a535e31f22a.x4d0b9d4447ba7566;
				this.PaintControl ();
				return;
				
			L_0066:
				
				{
				}
				this.PaintControl ();
				return;
				
			L_0090:
				
				{
				}
				IntPtr intPtr1 = x61467fe65a98f20c.BeginPaint (base.Handle, out pAINTSTRUCT1);
				this.PaintControl ();
				bool b1 = x61467fe65a98f20c.EndPaint (base.Handle, ref pAINTSTRUCT1);
				return;
				
				/*
					Unreachable Code
					return;
				*/
			}
			
			protected virtual bool BeforeWndProc (ref Message m)
			
			/*
				// Code Size: 2 Bytes
				.maxstack 9
				L_0000: ldc.i4.1 
				L_0001: ret 
			*/
			
			
			{
				return true;
			}
			
			protected virtual void PaintControl ()
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
			protected override void WndProc (ref Message m)
			
			/*
				// Code Size: 40 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Boolean get_CanPaint()
				L_0006: brfalse.s L_0020
				L_0008: ldarg.0 
				L_0009: ldarg.1 
				L_000a: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_000f: brfalse.s L_0018
				L_0011: ldarg.0 
				L_0012: ldarg.1 
				L_0013: call System.Windows.Forms.NativeWindow::Void WndProc(System.Windows.Forms.Message ByRef)
				L_0018: ldarg.0 
				L_0019: ldarg.1 
				L_001a: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Void AfterWndProc(System.Windows.Forms.Message ByRef)
				L_001f: ret 
				L_0020: ldarg.0 
				L_0021: ldarg.1 
				L_0022: call System.Windows.Forms.NativeWindow::Void WndProc(System.Windows.Forms.Message ByRef)
				L_0027: ret 
			*/
			
			
			{
				if (! this.CanPaint)
				{
					base.WndProc (ref m);
				}
				else
				{
					if (this.BeforeWndProc (ref m))
					{
						base.WndProc (ref m);
					}
					this.AfterWndProc (ref m);
				}
			}
			
		#endregion
	}
	
}

