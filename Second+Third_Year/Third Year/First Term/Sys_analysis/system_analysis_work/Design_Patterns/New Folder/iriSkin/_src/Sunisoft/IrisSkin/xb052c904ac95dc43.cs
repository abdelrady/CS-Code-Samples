//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin

{
		
		#region Namespace Import Declarations
		
			using System.Collections;
			using System.Drawing;
			using System.Text;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class xb052c904ac95dc43 : xd24df615efe9450e
	
	{
		
		#region Fields
			private bool x66bf3eedd0ff9957;
			private bool xa8a1d8725b684fc0;
			private bool xc670990170293979;
			private bool xdfdb4d7af566dc92;
		#endregion
		
		#region Constructors
		
			public xb052c904ac95dc43 (IntPtr handle, ISkinEngine engine)
				 : base (handle, engine)
			/*
				// Code Size: 37 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.0 
				L_0002: stfld Sunisoft.IrisSkin.xb052c904ac95dc43::Boolean xa8a1d8725b684fc0
				L_0007: ldarg.0 
				L_0008: ldc.i4.1 
				L_0009: stfld Sunisoft.IrisSkin.xb052c904ac95dc43::Boolean x66bf3eedd0ff9957
				L_000e: ldarg.0 
				L_000f: ldc.i4.1 
				L_0010: stfld Sunisoft.IrisSkin.xb052c904ac95dc43::Boolean xc670990170293979
				L_0015: ldarg.0 
				L_0016: ldc.i4.0 
				L_0017: stfld Sunisoft.IrisSkin.xb052c904ac95dc43::Boolean xdfdb4d7af566dc92
				L_001c: ldarg.0 
				L_001d: ldarg.1 
				L_001e: ldarg.2 
				L_001f: call Sunisoft.IrisSkin.xd24df615efe9450e::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_0024: ret 
			*/
		#endregion
		
		#region Properties
		
			protected override FormBorderStyle BorderStyle
			
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
					L_000f: ldc.i4 262144
					L_0014: and 
					L_0015: ldc.i4 262144
					L_001a: bne.un.s L_001e
					L_001c: ldc.i4.4 
					L_001d: ret 
					L_001e: ldc.i4.3 
					L_001f: ret 
				*/
				
				{
					uint uInt32_1 = x61467fe65a98f20c.GetWindowLong (base.Handle, -16);
					if ((((int) uInt32_1) & 262144) != 262144)
					{
						return FormBorderStyle.FixedDialog;
					}
					else
					{
						return FormBorderStyle.Sizable;
					}
				}
			}
			
			
			protected override Rectangle ClientRectangle
			
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
			
			
			protected override bool ControlBox
			
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
			
			
			protected override int Height
			
			{
				get
				
				/*
					// Code Size: 38 Bytes
					.maxstack 3
					.locals (Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_0)
					L_0000: ldloca.s V_0
					L_0002: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
					L_0008: ldarg.0 
					L_0009: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_000e: ldloca.s V_0
					L_0010: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowRect(IntPtr, RECT ByRef)
					L_0015: pop 
					L_0016: ldloca.s V_0
					L_0018: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
					L_001d: ldloca.s V_0
					L_001f: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
					L_0024: sub 
					L_0025: ret 
				*/
				
				{
					xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
					bool b1 = x61467fe65a98f20c.GetWindowRect (base.Handle, ref rECT1);
					return (rECT1.bottom - rECT1.top);
				}
			}
			
			
			protected override bool HelpButton
			
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
			
			
			protected override Icon Icon
			
			{
				get
				
				/*
					// Code Size: 2 Bytes
					.maxstack 9
					L_0000: ldnull 
					L_0001: ret 
				*/
				
				{
					return null;
				}
			}
			
			
			protected override bool IsDisposed
			
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
			
			
			protected override bool IsMdiChild
			
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
			
			
			protected override bool IsMdiContainer
			
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
			
			
			protected override bool MaximizeBox
			
			{
				get
				
				/*
					// Code Size: 35 Bytes
					.maxstack 3
					.locals (System.UInt64 V_0)
					L_0000: ldarg.0 
					L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0006: ldc.i4.s -16
					L_0008: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
					L_000d: conv.u8 
					L_000e: stloc.0 
					L_000f: ldloc.0 
					L_0010: ldc.i4 65536
					L_0015: conv.i8 
					L_0016: and 
					L_0017: ldc.i4 65536
					L_001c: conv.i8 
					L_001d: bne.un.s L_0021
					L_001f: ldc.i4.1 
					L_0020: ret 
					L_0021: ldc.i4.0 
					L_0022: ret 
				*/
				
				{
					ulong uInt64_1 = ((ulong) x61467fe65a98f20c.GetWindowLong (base.Handle, -16));
					if ((((long) uInt64_1) & ((long) 65536)) != ((long) 65536))
					{
						return false;
					}
					else
					{
						return true;
					}
				}
			}
			
			
			protected override bool MinimizeBox
			
			{
				get
				
				/*
					// Code Size: 35 Bytes
					.maxstack 3
					.locals (System.UInt64 V_0)
					L_0000: ldarg.0 
					L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0006: ldc.i4.s -16
					L_0008: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
					L_000d: conv.u8 
					L_000e: stloc.0 
					L_000f: ldloc.0 
					L_0010: ldc.i4 131072
					L_0015: conv.i8 
					L_0016: and 
					L_0017: ldc.i4 131072
					L_001c: conv.i8 
					L_001d: bne.un.s L_0021
					L_001f: ldc.i4.1 
					L_0020: ret 
					L_0021: ldc.i4.0 
					L_0022: ret 
				*/
				
				{
					ulong uInt64_1 = ((ulong) x61467fe65a98f20c.GetWindowLong (base.Handle, -16));
					if ((((long) uInt64_1) & ((long) 131072)) != ((long) 131072))
					{
						return false;
					}
					else
					{
						return true;
					}
				}
			}
			
			
			protected override Region Region
			
			{
				get
				
				/*
					// Code Size: 2 Bytes
					.maxstack 9
					L_0000: ldnull 
					L_0001: ret 
				*/
				
				{
					return null;
				}
				set
				
				/*
					// Code Size: 97 Bytes
					.maxstack 4
					.locals (System.IntPtr V_0, 
         System.IntPtr V_1, 
         System.Drawing.Graphics V_2)
					.try L_0013 to L_0049 finally L_0049 to L_0053
					L_0000: ldarg.0 
					L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0006: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindowDC(IntPtr)
					L_000b: stloc.1 
					L_000c: ldloc.1 
					L_000d: call System.Drawing.Graphics::System.Drawing.Graphics FromHdc(IntPtr)
					L_0012: stloc.2 
					L_0013: ldarg.1 
					L_0014: brfalse.s L_0035
					L_0016: ldarg.1 
					L_0017: ldloc.2 
					L_0018: callvirt System.Drawing.Region::IntPtr GetHrgn(System.Drawing.Graphics)
					L_001d: stloc.0 
					L_001e: ldarg.0 
					L_001f: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0024: ldloc.0 
					L_0025: ldc.i4.1 
					L_0026: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 SetWindowRgn(IntPtr, IntPtr, Boolean)
					L_002b: pop 
					L_002c: ldloc.0 
					L_002d: call Sunisoft.IrisSkin.x31775329b2a4ff52::Boolean DeleteObject(IntPtr)
					L_0032: pop 
					L_0033: br.s L_0047
					L_0035: ldarg.0 
					L_0036: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_003b: ldsfld System.IntPtr::IntPtr Zero
					L_0040: ldc.i4.1 
					L_0041: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 SetWindowRgn(IntPtr, IntPtr, Boolean)
					L_0046: pop 
					L_0047: leave.s L_0053
					L_0049: ldloc.2 
					L_004a: brfalse.s L_0052
					L_004c: ldloc.2 
					L_004d: callvirt System.IDisposable::Void Dispose()
					L_0052: endfinally 
					L_0053: ldarg.0 
					L_0054: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0059: ldloc.1 
					L_005a: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
					L_005f: pop 
					L_0060: ret 
				*/
				
				{
					IntPtr intPtr1;
					IntPtr intPtr2 = x61467fe65a98f20c.GetWindowDC (base.Handle);
					using (Graphics graphics1 = Graphics.FromHdc (intPtr2))
					{
						if (value != null)
						{
							intPtr1 = value.GetHrgn (graphics1);
							int i1 = x61467fe65a98f20c.SetWindowRgn (base.Handle, intPtr1, true);
							bool b1 = x31775329b2a4ff52.DeleteObject (intPtr1);
						}
						else
						{
							int i2 = x61467fe65a98f20c.SetWindowRgn (base.Handle, IntPtr.Zero, true);
						}
					}
					int i3 = x61467fe65a98f20c.ReleaseDC (base.Handle, intPtr2);
				}
			}
			
			
			protected override RightToLeft RightToLeft
			
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
			
			
			protected override bool RightToLeftLayout
			
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
			
			
			protected override object Tag
			
			{
				get
				
				/*
					// Code Size: 6 Bytes
					.maxstack 9
					L_0000: newobj System.Object::Void .ctor()
					L_0005: ret 
				*/
				
				{
					return new object ();
				}
			}
			
			
			protected override string Text
			
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
			
			
			protected override int Width
			
			{
				get
				
				/*
					// Code Size: 38 Bytes
					.maxstack 3
					.locals (Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_0)
					L_0000: ldloca.s V_0
					L_0002: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
					L_0008: ldarg.0 
					L_0009: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_000e: ldloca.s V_0
					L_0010: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowRect(IntPtr, RECT ByRef)
					L_0015: pop 
					L_0016: ldloca.s V_0
					L_0018: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
					L_001d: ldloca.s V_0
					L_001f: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
					L_0024: sub 
					L_0025: ret 
				*/
				
				{
					xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
					bool b1 = x61467fe65a98f20c.GetWindowRect (base.Handle, ref rECT1);
					return (rECT1.right - rECT1.left);
				}
			}
			
		#endregion
		
		#region Methods
		
			protected override void AfterWndProc (ref Message m)
			
			/*
				// Code Size: 216 Bytes
				.maxstack 8
				.locals (Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_0, 
         System.UInt32 V_1)
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: call Sunisoft.IrisSkin.xd24df615efe9450e::Void AfterWndProc(System.Windows.Forms.Message ByRef)
				L_0007: ldarg.1 
				L_0008: call System.Windows.Forms.Message::Int32 get_Msg()
				L_000d: stloc.1 
				L_000e: ldloc.1 
				L_000f: ldc.i4.5 
				L_0010: beq.s L_001b
				L_0012: ldloc.1 
				L_0013: ldc.i4.s 15
				L_0015: beq L_00c8
				L_001a: ret 
				L_001b: ldloca.s V_0
				L_001d: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
				L_0023: ldarg.0 
				L_0024: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0029: ldloca.s V_0
				L_002b: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowRect(IntPtr, RECT ByRef)
				L_0030: brfalse L_00c1
				L_0035: ldarg.0 
				L_0036: ldfld Sunisoft.IrisSkin.xb052c904ac95dc43::Boolean xdfdb4d7af566dc92
				L_003b: brtrue L_00c1
				L_0040: ldarg.0 
				L_0041: ldfld Sunisoft.IrisSkin.xb052c904ac95dc43::Boolean x66bf3eedd0ff9957
				L_0046: brtrue.s L_00c1
				L_0048: ldarg.0 
				L_0049: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Boolean xa8de7f7b9ee88efe
				L_004e: brtrue.s L_00c1
				L_0050: ldarg.0 
				L_0051: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Windows.Forms.FormBorderStyle get_BorderStyle()
				L_0056: ldc.i4.3 
				L_0057: bne.un.s L_00c1
				L_0059: ldarg.0 
				L_005a: ldc.i4.1 
				L_005b: stfld Sunisoft.IrisSkin.xb052c904ac95dc43::Boolean xdfdb4d7af566dc92
				L_0060: ldarg.0 
				L_0061: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void ApplySkin()
				L_0066: ldarg.0 
				L_0067: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_006c: ldloca.s V_0
				L_006e: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0073: ldloca.s V_0
				L_0075: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_007a: ldloca.s V_0
				L_007c: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0081: ldloca.s V_0
				L_0083: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0088: sub 
				L_0089: ldloca.s V_0
				L_008b: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0090: ldloca.s V_0
				L_0092: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0097: sub 
				L_0098: ldarg.0 
				L_0099: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_TitleHeight()
				L_009e: add 
				L_009f: ldarg.0 
				L_00a0: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_MenuHeight()
				L_00a5: add 
				L_00a6: call System.Windows.Forms.SystemInformation::Int32 get_CaptionHeight()
				L_00ab: sub 
				L_00ac: ldarg.0 
				L_00ad: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00b2: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_BottomBorderHeight()
				L_00b7: add 
				L_00b8: ldc.i4.4 
				L_00b9: sub 
				L_00ba: ldc.i4.1 
				L_00bb: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean MoveWindow(IntPtr, Int32, Int32, Int32, Int32, Boolean)
				L_00c0: pop 
				L_00c1: ldarg.0 
				L_00c2: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void RegionWindow()
				L_00c7: ret 
				L_00c8: ldarg.0 
				L_00c9: ldfld Sunisoft.IrisSkin.xb052c904ac95dc43::Boolean xa8a1d8725b684fc0
				L_00ce: brtrue.s L_00d7
				L_00d0: ldarg.0 
				L_00d1: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Void RegionWindow()
				L_00d6: ret 
				L_00d7: ret 
			*/
			
			
			{
				base.AfterWndProc (ref m);
				uint uInt32_1 = ((uint) m.Msg);
				if (uInt32_1 != 5)
				{
					if ((uInt32_1 == 15) && (! this.xa8a1d8725b684fc0))
					{
						this.RegionWindow ();
					}
					return;
				}
				xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
				if ((((x61467fe65a98f20c.GetWindowRect (base.Handle, ref rECT1) && (! this.xdfdb4d7af566dc92)) && (! this.x66bf3eedd0ff9957)) && (! base.xa8de7f7b9ee88efe)) && (this.BorderStyle == FormBorderStyle.FixedDialog))
				{
					this.xdfdb4d7af566dc92 = true;
					this.ApplySkin ();
					bool b1 = x61467fe65a98f20c.MoveWindow (base.Handle, rECT1.left, rECT1.top, ((int) (rECT1.right - rECT1.left)), ((int) ((((((rECT1.bottom - rECT1.top) + this.TitleHeight) + this.MenuHeight) - SystemInformation.CaptionHeight) + ((SkinEngine) base.xdc87e2b99332cd4a).BottomBorderHeight) - 4)), true);
				}
				this.RegionWindow ();
				return;
				
				/*
					Unreachable Code
					return;
				*/
			}
			
			protected override void ApplySkin ()
			
			/*
				// Code Size: 188 Bytes
				.maxstack 8
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Int32 V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Drawing.Rectangle V_5)
				L_0000: ldarg.0 
				L_0001: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Boolean get_CanPaint()
				L_0006: brfalse L_00bb
				L_000b: ldc.i4.0 
				L_000c: stloc.0 
				L_000d: ldc.i4.0 
				L_000e: stloc.1 
				L_000f: ldc.i4.4 
				L_0010: stloc.2 
				L_0011: ldc.i4.4 
				L_0012: stloc.3 
				L_0013: ldc.i4.4 
				L_0014: stloc.s V_4
				L_0016: ldarg.0 
				L_0017: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_001c: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_LeftBorderWidth()
				L_0021: ldarg.0 
				L_0022: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_0027: call System.Math::Int32 Max(Int32, Int32)
				L_002c: stloc.2 
				L_002d: ldarg.0 
				L_002e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0033: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_RightBorderWidth()
				L_0038: ldarg.0 
				L_0039: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xdab5261f2cc3422d
				L_003e: call System.Math::Int32 Max(Int32, Int32)
				L_0043: stloc.3 
				L_0044: ldarg.0 
				L_0045: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_004a: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_BottomBorderHeight()
				L_004f: ldarg.0 
				L_0050: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Int32 xef9eb32e7f1d1f23
				L_0055: call System.Math::Int32 Max(Int32, Int32)
				L_005a: stloc.s V_4
				L_005c: ldarg.0 
				L_005d: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle get_ClientRectangle()
				L_0062: stloc.s V_5
				L_0064: ldloca.s V_5
				L_0066: call System.Drawing.Rectangle::Int32 get_Height()
				L_006b: ldarg.0 
				L_006c: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0071: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 get_TitleHeight()
				L_0076: add 
				L_0077: ldarg.0 
				L_0078: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::Int32 get_MenuHeight()
				L_007d: add 
				L_007e: ldloc.s V_4
				L_0080: add 
				L_0081: stloc.1 
				L_0082: ldarg.0 
				L_0083: callvirt Sunisoft.IrisSkin.xd24df615efe9450e::System.Drawing.Rectangle get_ClientRectangle()
				L_0088: stloc.s V_5
				L_008a: ldloca.s V_5
				L_008c: call System.Drawing.Rectangle::Int32 get_Width()
				L_0091: ldloc.2 
				L_0092: add 
				L_0093: ldloc.3 
				L_0094: add 
				L_0095: stloc.0 
				L_0096: ldarg.0 
				L_0097: ldc.i4.1 
				L_0098: stfld Sunisoft.IrisSkin.xb052c904ac95dc43::Boolean x66bf3eedd0ff9957
				L_009d: ldarg.0 
				L_009e: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_00a3: ldsfld System.IntPtr::IntPtr Zero
				L_00a8: ldc.i4.0 
				L_00a9: ldc.i4.0 
				L_00aa: ldloc.0 
				L_00ab: ldloc.1 
				L_00ac: ldc.i4.s 22
				L_00ae: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean SetWindowPos(IntPtr, IntPtr, Int32, Int32, Int32, Int32, UInt32)
				L_00b3: pop 
				L_00b4: ldarg.0 
				L_00b5: ldc.i4.0 
				L_00b6: stfld Sunisoft.IrisSkin.xb052c904ac95dc43::Boolean x66bf3eedd0ff9957
				L_00bb: ret 
			*/
			
			
			{
				if (! this.CanPaint)
				{
					return;
				}
				int i3 = Math.Max (((SkinEngine) base.xdc87e2b99332cd4a).LeftBorderWidth, base.xdab5261f2cc3422d);
				int i4 = Math.Max (((SkinEngine) base.xdc87e2b99332cd4a).RightBorderWidth, base.xdab5261f2cc3422d);
				int i5 = Math.Max (((SkinEngine) base.xdc87e2b99332cd4a).BottomBorderHeight, base.xef9eb32e7f1d1f23);
				int i2 = (((this.ClientRectangle.Height + ((SkinEngine) base.xdc87e2b99332cd4a).TitleHeight) + this.MenuHeight) + i5);
				int i1 = ((this.ClientRectangle.Width + i3) + i4);
				this.x66bf3eedd0ff9957 = true;
				bool b1 = x61467fe65a98f20c.SetWindowPos (base.Handle, IntPtr.Zero, 0, 0, i1, i2, 22);
				this.x66bf3eedd0ff9957 = false;
			}
			
			protected override bool BeforeWndProc (ref Message m)
			
			/*
				// Code Size: 79 Bytes
				.maxstack 4
				.locals (System.UInt32 V_0)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0006: stloc.0 
				L_0007: ldloc.0 
				L_0008: ldc.i4.5 
				L_0009: beq.s L_001d
				L_000b: ldloc.0 
				L_000c: ldc.i4 309
				L_0011: beq.s L_0027
				L_0013: ldloc.0 
				L_0014: ldc.i4 312
				L_0019: beq.s L_0027
				L_001b: br.s L_0047
				L_001d: ldarg.0 
				L_001e: ldfld Sunisoft.IrisSkin.xb052c904ac95dc43::Boolean xc670990170293979
				L_0023: brfalse.s L_0047
				L_0025: ldc.i4.0 
				L_0026: ret 
				L_0027: ldarg.1 
				L_0028: ldarg.0 
				L_0029: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_002e: callvirt Sunisoft.IrisSkin.SkinEngine::IntPtr get_BackColorBrush()
				L_0033: call System.Windows.Forms.Message::Void set_Result(IntPtr)
				L_0038: ldarg.1 
				L_0039: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_003e: ldc.i4.1 
				L_003f: call Sunisoft.IrisSkin.x31775329b2a4ff52::Int32 SetBkMode(IntPtr, Int32)
				L_0044: pop 
				L_0045: ldc.i4.0 
				L_0046: ret 
				L_0047: ldarg.0 
				L_0048: ldarg.1 
				L_0049: call Sunisoft.IrisSkin.xd24df615efe9450e::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_004e: ret 
			*/
			
			
			{
				uint uInt32_1 = ((uint) m.Msg);
				if (uInt32_1 != 5)
				{
					if ((uInt32_1 != 309) && (uInt32_1 != 312))
					{
						return base.BeforeWndProc (ref m);
					}
					else
					{
						m.Result = ((SkinEngine) base.xdc87e2b99332cd4a).BackColorBrush;
						int i1 = x31775329b2a4ff52.SetBkMode (m.WParam, 1);
						return false;
					}
				}
				if (! this.xc670990170293979)
				{
					return base.BeforeWndProc (ref m);
				}
				else
				{
					return false;
				}
			}
			
			protected override void DoSysMenu ()
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
			protected override void DoSysMenu (Point p)
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
			protected override Point PointToScreen (Point point)
			
			/*
				// Code Size: 16 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0006: ldarga.s point
				L_0008: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean ClientToScreen(IntPtr, System.Drawing.Point ByRef)
				L_000d: pop 
				L_000e: ldarg.1 
				L_000f: ret 
			*/
			
			
			{
				bool b1 = x61467fe65a98f20c.ClientToScreen (base.Handle, ref point);
				return point;
			}
			
			protected override void RegionWindow ()
			
			/*
				// Code Size: 14 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xd24df615efe9450e::Void RegionWindow()
				L_0006: ldarg.0 
				L_0007: ldc.i4.1 
				L_0008: stfld Sunisoft.IrisSkin.xb052c904ac95dc43::Boolean xa8a1d8725b684fc0
				L_000d: ret 
			*/
			
			
			{
				base.RegionWindow ();
				this.xa8a1d8725b684fc0 = true;
			}
			
			protected override void SkinControls ()
			
			/*
				// Code Size: 382 Bytes
				.maxstack 4
				.locals (System.IntPtr V_0, 
         System.IntPtr V_1, 
         System.UInt64 V_2, 
         System.Text.StringBuilder V_3, 
         System.String V_4, 
         Sunisoft.IrisSkin.x5b126f5f998c28e9 V_5)
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0006: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetTopWindow(IntPtr)
				L_000b: stloc.0 
				L_000c: ldc.i4.0 
				L_000d: conv.i8 
				L_000e: stloc.2 
				L_000f: br L_016d
				L_0014: ldarg.0 
				L_0015: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable x84603c7eff1953af
				L_001a: ldloc.0 
				L_001b: box System.IntPtr
				L_0020: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_0025: brfalse.s L_0034
				L_0027: ldloc.0 
				L_0028: ldc.i4.2 
				L_0029: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindow(IntPtr, UInt32)
				L_002e: stloc.0 
				L_002f: br L_016d
				L_0034: ldc.i4 260
				L_0039: newobj System.Text.StringBuilder::Void .ctor(Int32)
				L_003e: stloc.3 
				L_003f: ldloc.0 
				L_0040: ldc.i4.s -16
				L_0042: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
				L_0047: conv.u8 
				L_0048: stloc.2 
				L_0049: ldloc.0 
				L_004a: ldloc.3 
				L_004b: ldc.i4 260
				L_0050: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 GetClassName(IntPtr, System.Text.StringBuilder, Int32)
				L_0055: pop 
				L_0056: ldloc.2 
				L_0057: ldc.i4 1073741824
				L_005c: conv.i8 
				L_005d: and 
				L_005e: ldc.i4 1073741824
				L_0063: conv.i8 
				L_0064: beq.s L_0073
				L_0066: ldloc.0 
				L_0067: ldc.i4.2 
				L_0068: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindow(IntPtr, UInt32)
				L_006d: stloc.0 
				L_006e: br L_016d
				L_0073: ldloc.3 
				L_0074: callvirt System.Text.StringBuilder::System.String ToString()
				L_0079: callvirt System.String::System.String ToUpper()
				L_007e: stloc.s V_4
				L_0080: ldloc.s V_4
				L_0082: ldstr "BUTTON"
				L_0087: call System.String::Boolean op_Equality(System.String, System.String)
				L_008c: brfalse.s L_00f0
				L_008e: ldloc.2 
				L_008f: ldc.i4.7 
				L_0090: conv.i8 
				L_0091: and 
				L_0092: ldc.i4.7 
				L_0093: conv.i8 
				L_0094: bne.un.s L_00a3
				L_0096: ldloc.0 
				L_0097: ldc.i4.2 
				L_0098: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindow(IntPtr, UInt32)
				L_009d: stloc.0 
				L_009e: br L_016d
				L_00a3: ldloc.2 
				L_00a4: ldc.i4.3 
				L_00a5: conv.i8 
				L_00a6: and 
				L_00a7: ldc.i4.3 
				L_00a8: conv.i8 
				L_00a9: beq.s L_00bb
				L_00ab: ldloc.2 
				L_00ac: ldc.i4.2 
				L_00ad: conv.i8 
				L_00ae: and 
				L_00af: ldc.i4.2 
				L_00b0: conv.i8 
				L_00b1: beq.s L_00bb
				L_00b3: ldloc.2 
				L_00b4: ldc.i4.5 
				L_00b5: conv.i8 
				L_00b6: and 
				L_00b7: ldc.i4.5 
				L_00b8: conv.i8 
				L_00b9: bne.un.s L_00ce
				L_00bb: ldloc.s V_4
				L_00bd: ldstr "_CHECKBOX"
				L_00c2: call System.String::System.String Concat(System.String, System.String)
				L_00c7: stloc.s V_4
				L_00c9: br L_014a
				L_00ce: ldloc.2 
				L_00cf: ldc.i4.s 9
				L_00d1: conv.i8 
				L_00d2: and 
				L_00d3: ldc.i4.s 9
				L_00d5: conv.i8 
				L_00d6: beq.s L_00e0
				L_00d8: ldloc.2 
				L_00d9: ldc.i4.4 
				L_00da: conv.i8 
				L_00db: and 
				L_00dc: ldc.i4.4 
				L_00dd: conv.i8 
				L_00de: bne.un.s L_014a
				L_00e0: ldloc.s V_4
				L_00e2: ldstr "_RADIOBUTTON"
				L_00e7: call System.String::System.String Concat(System.String, System.String)
				L_00ec: stloc.s V_4
				L_00ee: br.s L_014a
				L_00f0: ldloc.s V_4
				L_00f2: ldstr "COMBOBOX"
				L_00f7: call System.String::Boolean op_Equality(System.String, System.String)
				L_00fc: brfalse.s L_0110
				L_00fe: ldloc.2 
				L_00ff: ldc.i4.3 
				L_0100: conv.i8 
				L_0101: and 
				L_0102: ldc.i4.1 
				L_0103: conv.i8 
				L_0104: bne.un.s L_014a
				L_0106: ldloc.0 
				L_0107: ldc.i4.2 
				L_0108: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindow(IntPtr, UInt32)
				L_010d: stloc.0 
				L_010e: br.s L_016d
				L_0110: ldloc.s V_4
				L_0112: ldstr "COMBOBOXEX32"
				L_0117: call System.String::Boolean op_Equality(System.String, System.String)
				L_011c: brfalse.s L_014a
				L_011e: ldloc.0 
				L_011f: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetTopWindow(IntPtr)
				L_0124: stloc.1 
				L_0125: ldloc.1 
				L_0126: ldloc.s V_4
				L_0128: ldarg.0 
				L_0129: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_012e: call Sunisoft.IrisSkin.x735ffd864c9f9835::Sunisoft.IrisSkin.x5b126f5f998c28e9 xebcf83b00134300b(IntPtr, System.String, Sunisoft.IrisSkin.SkinEngine)
				L_0133: stloc.s V_5
				L_0135: ldarg.0 
				L_0136: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable x84603c7eff1953af
				L_013b: ldloc.0 
				L_013c: box System.IntPtr
				L_0141: ldloc.s V_5
				L_0143: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_0148: br.s L_016d
				L_014a: ldloc.0 
				L_014b: ldloc.s V_4
				L_014d: ldarg.0 
				L_014e: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0153: call Sunisoft.IrisSkin.x735ffd864c9f9835::Sunisoft.IrisSkin.x5b126f5f998c28e9 xebcf83b00134300b(IntPtr, System.String, Sunisoft.IrisSkin.SkinEngine)
				L_0158: stloc.s V_5
				L_015a: ldarg.0 
				L_015b: ldfld Sunisoft.IrisSkin.xd24df615efe9450e::System.Collections.Hashtable x84603c7eff1953af
				L_0160: ldloc.0 
				L_0161: box System.IntPtr
				L_0166: ldloc.s V_5
				L_0168: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_016d: ldloc.0 
				L_016e: ldsfld System.IntPtr::IntPtr Zero
				L_0173: call System.IntPtr::Boolean op_Inequality(IntPtr, IntPtr)
				L_0178: brtrue L_0014
				L_017d: ret 
			*/
			
			
			{
				IntPtr intPtr1;
				IntPtr intPtr2;
				ulong uInt64_1;
				StringBuilder stringBuilder1;
				string string1;
				x5b126f5f998c28e9 x5b126f5f998c28e9_1;
				intPtr1 = x61467fe65a98f20c.GetTopWindow (base.Handle);
				uInt64_1 = ulong.MinValue;
				goto L_016D;
				
			L_014A:
				
				{
				}
				x5b126f5f998c28e9_1 = x735ffd864c9f9835.xebcf83b00134300b (intPtr1, string1, base.xdc87e2b99332cd4a);
				base.x84603c7eff1953af.Add (intPtr1, x5b126f5f998c28e9_1);
				
			L_016D:
				
				{
				}
				while (intPtr1 != IntPtr.Zero)
				{
					if (! base.x84603c7eff1953af.ContainsKey (intPtr1))
					{
						stringBuilder1 = new StringBuilder (260);
						uInt64_1 = ((ulong) x61467fe65a98f20c.GetWindowLong (intPtr1, -16));
						int i1 = x61467fe65a98f20c.GetClassName (intPtr1, stringBuilder1, 260);
						if ((((long) uInt64_1) & ((long) 1073741824)) == ((long) 1073741824))
						{
							string1 = stringBuilder1.ToString ().ToUpper ();
							if (string1 != "BUTTON")
							{
								if (string1 != "COMBOBOX")
								{
									if (string1 != "COMBOBOXEX32")
									{
										goto L_014A;
									}
									intPtr2 = x61467fe65a98f20c.GetTopWindow (intPtr1);
									x5b126f5f998c28e9_1 = x735ffd864c9f9835.xebcf83b00134300b (intPtr2, string1, base.xdc87e2b99332cd4a);
									base.x84603c7eff1953af.Add (intPtr1, x5b126f5f998c28e9_1);
									continue;
								}
								if ((((long) uInt64_1) & ((long) 3)) != ((long) 1))
								{
									goto L_014A;
								}
								intPtr1 = x61467fe65a98f20c.GetWindow (intPtr1, 2);
								continue;
							}
							if ((((long) uInt64_1) & ((long) 7)) != ((long) 7))
							{
								if (((((long) uInt64_1) & ((long) 3)) != ((long) 3)) && (((((long) uInt64_1) & ((long) 2)) != ((long) 2)) && ((((long) uInt64_1) & ((long) 5)) != ((long) 5))))
								{
									if (((((long) uInt64_1) & ((long) 9)) == ((long) 9)) || ((((long) uInt64_1) & ((long) 4)) == ((long) 4)))
									{
										string1 = (string1 + "_RADIOBUTTON");
									}
									goto L_014A;
								}
								string1 = (string1 + "_CHECKBOX");
								goto L_014A;
							}
							intPtr1 = x61467fe65a98f20c.GetWindow (intPtr1, 2);
							continue;
						}
						intPtr1 = x61467fe65a98f20c.GetWindow (intPtr1, 2);
						continue;
					}
					intPtr1 = x61467fe65a98f20c.GetWindow (intPtr1, 2);
				}
			}
			
		#endregion
	}
	
}

