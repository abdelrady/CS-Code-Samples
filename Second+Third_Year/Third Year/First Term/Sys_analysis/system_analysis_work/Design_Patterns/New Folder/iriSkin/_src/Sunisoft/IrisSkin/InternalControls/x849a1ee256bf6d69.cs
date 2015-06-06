//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin.InternalControls

{
		
		#region Namespace Import Declarations
		
			using Sunisoft.IrisSkin;
			using System.Drawing;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class x849a1ee256bf6d69 : NativeWindow
	
	{
		
		#region Fields
			protected int x3146d638ec378671;
			protected IntPtr xac0491862bcb1329;
			protected Control xcd9cdf30888d2204;
			protected ISkinEngine xdc87e2b99332cd4a;
		#endregion
		
		#region Constructors
		
			public x849a1ee256bf6d69 (ISkinEngine engine, Control control, int type)
			/*
				// Code Size: 46 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.NativeWindow::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.3 
				L_0008: stfld Sunisoft.IrisSkin.InternalControls.x849a1ee256bf6d69::Int32 x3146d638ec378671
				L_000d: ldarg.0 
				L_000e: ldarg.1 
				L_000f: stfld Sunisoft.IrisSkin.InternalControls.x849a1ee256bf6d69::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0014: ldarg.0 
				L_0015: ldarg.2 
				L_0016: stfld Sunisoft.IrisSkin.InternalControls.x849a1ee256bf6d69::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001b: ldarg.0 
				L_001c: ldarg.2 
				L_001d: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0022: stfld Sunisoft.IrisSkin.InternalControls.x849a1ee256bf6d69::IntPtr xac0491862bcb1329
				L_0027: ldarg.0 
				L_0028: call Sunisoft.IrisSkin.InternalControls.x849a1ee256bf6d69::Void x63eb955995a0f242()
				L_002d: ret 
			*/
		#endregion
		
		#region Properties
		
			public Rectangle x2c98ac6c95db0c04
			
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
			
			
			public bool x5c9e4e2dc9b12067
			
			{
				get
				
				/*
					// Code Size: 12 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0006: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean IsWindowVisible(IntPtr)
					L_000b: ret 
				*/
				
				{
					return x61467fe65a98f20c.IsWindowVisible (base.Handle);
				}
				set
				
				/*
					// Code Size: 31 Bytes
					.maxstack 9
					L_0000: ldarg.1 
					L_0001: brfalse.s L_0011
					L_0003: ldarg.0 
					L_0004: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0009: ldc.i4.5 
					L_000a: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ShowWindow(IntPtr, Int16)
					L_000f: pop 
					L_0010: ret 
					L_0011: ldarg.0 
					L_0012: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0017: ldc.i4.0 
					L_0018: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ShowWindow(IntPtr, Int16)
					L_001d: pop 
					L_001e: ret 
				*/
				
				{
					if (value)
					{
						int i1 = x61467fe65a98f20c.ShowWindow (base.Handle, 5);
					}
					else
					{
						int i2 = x61467fe65a98f20c.ShowWindow (base.Handle, 0);
					}
				}
			}
			
			
			public Rectangle x6ae4612a8469678e
			
			{
				get
				
				/*
					// Code Size: 100 Bytes
					.maxstack 5
					.locals (Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_0, 
         System.Drawing.Point V_1)
					L_0000: ldloca.s V_0
					L_0002: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
					L_0008: ldarg.0 
					L_0009: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_000e: ldloca.s V_0
					L_0010: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowRect(IntPtr, RECT ByRef)
					L_0015: pop 
					L_0016: ldarg.0 
					L_0017: ldfld Sunisoft.IrisSkin.InternalControls.x849a1ee256bf6d69::System.Windows.Forms.Control xcd9cdf30888d2204
					L_001c: callvirt System.Windows.Forms.Control::System.Windows.Forms.Control get_Parent()
					L_0021: ldloca.s V_0
					L_0023: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
					L_0028: ldloca.s V_0
					L_002a: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
					L_002f: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
					L_0034: callvirt System.Windows.Forms.Control::System.Drawing.Point PointToClient(System.Drawing.Point)
					L_0039: stloc.1 
					L_003a: ldloc.1 
					L_003b: ldloca.s V_0
					L_003d: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
					L_0042: ldloca.s V_0
					L_0044: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
					L_0049: sub 
					L_004a: ldloca.s V_0
					L_004c: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
					L_0051: ldloca.s V_0
					L_0053: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
					L_0058: sub 
					L_0059: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
					L_005e: newobj System.Drawing.Rectangle::Void .ctor(System.Drawing.Point, System.Drawing.Size)
					L_0063: ret 
				*/
				
				{
					xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
					bool b1 = x61467fe65a98f20c.GetWindowRect (base.Handle, ref rECT1);
					Point point1 = this.xcd9cdf30888d2204.Parent.PointToClient (new Point (rECT1.left, rECT1.top));
					return new Rectangle (point1, new Size (((int) (rECT1.right - rECT1.left)), ((int) (rECT1.bottom - rECT1.top))));
				}
				set
				
				/*
					// Code Size: 49 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
					L_0006: ldarg.0 
					L_0007: ldfld Sunisoft.IrisSkin.InternalControls.x849a1ee256bf6d69::IntPtr xac0491862bcb1329
					L_000c: ldarga.s xbcea506a33cf9111
					L_000e: call System.Drawing.Rectangle::Int32 get_X()
					L_0013: ldarga.s xbcea506a33cf9111
					L_0015: call System.Drawing.Rectangle::Int32 get_Y()
					L_001a: ldarga.s xbcea506a33cf9111
					L_001c: call System.Drawing.Rectangle::Int32 get_Width()
					L_0021: ldarga.s xbcea506a33cf9111
					L_0023: call System.Drawing.Rectangle::Int32 get_Height()
					L_0028: ldc.i4.s 64
					L_002a: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean SetWindowPos(IntPtr, IntPtr, Int32, Int32, Int32, Int32, UInt32)
					L_002f: pop 
					L_0030: ret 
				*/
				
				{
					bool b1 = x61467fe65a98f20c.SetWindowPos (base.Handle, this.xac0491862bcb1329, value.X, value.Y, value.Width, value.Height, 64);
				}
			}
			
		#endregion
		
		#region Methods
		
			protected override void WndProc (ref Message m)
			
			/*
				// Code Size: 48 Bytes
				.maxstack 6
				.locals (System.IntPtr V_0, 
         System.UInt32 V_1)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x849a1ee256bf6d69::IntPtr xac0491862bcb1329
				L_0006: stloc.0 
				L_0007: ldarg.1 
				L_0008: call System.Windows.Forms.Message::Int32 get_Msg()
				L_000d: stloc.1 
				L_000e: ldloc.1 
				L_000f: ldc.i4.s 15
				L_0011: bne.un.s L_0028
				L_0013: ldloc.0 
				L_0014: ldc.i4.s 15
				L_0016: ldarg.1 
				L_0017: call System.Windows.Forms.Message::IntPtr get_LParam()
				L_001c: ldarg.1 
				L_001d: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_0022: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, IntPtr, IntPtr)
				L_0027: pop 
				L_0028: ldarg.0 
				L_0029: ldarg.1 
				L_002a: call System.Windows.Forms.NativeWindow::Void WndProc(System.Windows.Forms.Message ByRef)
				L_002f: ret 
			*/
			
			
			{
				IntPtr intPtr1 = this.xac0491862bcb1329;
				if (((uint) m.Msg) == 15)
				{
					bool b1 = x61467fe65a98f20c.PostMessage (intPtr1, 15, m.LParam, m.WParam);
				}
				base.WndProc (ref m);
			}
			
			private void x63eb955995a0f242 ()
			
			/*
				// Code Size: 142 Bytes
				.maxstack 4
				.locals (System.Windows.Forms.CreateParams V_0)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x849a1ee256bf6d69::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::System.Windows.Forms.Control get_Parent()
				L_000b: brfalse.s L_001f
				L_000d: ldarg.0 
				L_000e: ldfld Sunisoft.IrisSkin.InternalControls.x849a1ee256bf6d69::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0013: callvirt System.Windows.Forms.Control::System.Windows.Forms.Control get_Parent()
				L_0018: callvirt System.Windows.Forms.Control::Boolean get_IsDisposed()
				L_001d: brfalse.s L_0020
				L_001f: ret 
				L_0020: newobj System.Windows.Forms.CreateParams::Void .ctor()
				L_0025: stloc.0 
				L_0026: ldloc.0 
				L_0027: ldstr "STATIC"
				L_002c: callvirt System.Windows.Forms.CreateParams::Void set_ClassName(System.String)
				L_0031: ldloc.0 
				L_0032: ldstr ""
				L_0037: callvirt System.Windows.Forms.CreateParams::Void set_Caption(System.String)
				L_003c: ldloc.0 
				L_003d: ldarg.0 
				L_003e: ldfld Sunisoft.IrisSkin.InternalControls.x849a1ee256bf6d69::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0043: callvirt System.Windows.Forms.Control::System.Windows.Forms.Control get_Parent()
				L_0048: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_004d: callvirt System.Windows.Forms.CreateParams::Void set_Parent(IntPtr)
				L_0052: ldloc.0 
				L_0053: ldc.i4.0 
				L_0054: callvirt System.Windows.Forms.CreateParams::Void set_X(Int32)
				L_0059: ldloc.0 
				L_005a: ldc.i4.0 
				L_005b: callvirt System.Windows.Forms.CreateParams::Void set_Y(Int32)
				L_0060: ldloc.0 
				L_0061: ldc.i4.0 
				L_0062: callvirt System.Windows.Forms.CreateParams::Void set_Width(Int32)
				L_0067: ldloc.0 
				L_0068: ldc.i4.0 
				L_0069: callvirt System.Windows.Forms.CreateParams::Void set_Height(Int32)
				L_006e: ldloc.0 
				L_006f: ldc.i4 1073741824
				L_0074: callvirt System.Windows.Forms.CreateParams::Void set_Style(Int32)
				L_0079: ldarg.0 
				L_007a: ldloc.0 
				L_007b: callvirt System.Windows.Forms.NativeWindow::Void CreateHandle(System.Windows.Forms.CreateParams)
				L_0080: ldarg.0 
				L_0081: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0086: ldc.i4.5 
				L_0087: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ShowWindow(IntPtr, Int16)
				L_008c: pop 
				L_008d: ret 
			*/
			
			
			{
				if ((this.xcd9cdf30888d2204.Parent == null) || this.xcd9cdf30888d2204.Parent.IsDisposed)
				{
					return;
				}
				CreateParams createParams1 = new CreateParams ();
				createParams1.ClassName = "STATIC";
				createParams1.Caption = "";
				createParams1.Parent = this.xcd9cdf30888d2204.Parent.Handle;
				createParams1.X = 0;
				createParams1.Y = 0;
				createParams1.Width = 0;
				createParams1.Height = 0;
				createParams1.Style = 1073741824;
				this.CreateHandle (createParams1);
				int i1 = x61467fe65a98f20c.ShowWindow (base.Handle, 5);
			}
			
		#endregion
	}
	
}

