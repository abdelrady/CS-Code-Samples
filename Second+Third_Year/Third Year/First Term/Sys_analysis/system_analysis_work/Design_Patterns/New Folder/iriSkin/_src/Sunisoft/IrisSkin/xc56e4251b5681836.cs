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
		
	internal class xc56e4251b5681836 : x8917d01b98173f4c
	
	{
		
		#region Fields
			private x867b4abdb49f9449 x6092b63e9c2b4ce6;
			private x867b4abdb49f9449 xa1f39a0e58651210;
		#endregion
		
		#region Constructors
		
			public xc56e4251b5681836 (Control control, ISkinEngine engine)
				 : base (control, engine)
			/*
				// Code Size: 125 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.x8917d01b98173f4c::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ldarg.0 
				L_0009: call Sunisoft.IrisSkin.xc56e4251b5681836::Void xf149df02f1aa3d56()
				L_000e: ldarg.1 
				L_000f: isinst System.Windows.Forms.CheckedListBox
				L_0014: brfalse.s L_0022
				L_0016: ldarg.0 
				L_0017: call Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 get_x641297c2f10f25b0()
				L_001c: ldc.i4.0 
				L_001d: callvirt System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_0022: ldarg.1 
				L_0023: ldarg.0 
				L_0024: ldftn Sunisoft.IrisSkin.xc56e4251b5681836::Void xbad904bdcc347055(System.Object, System.EventArgs)
				L_002a: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_002f: callvirt System.Windows.Forms.Control::Void add_VisibleChanged(System.EventHandler)
				L_0034: ldarg.1 
				L_0035: ldarg.0 
				L_0036: ldftn Sunisoft.IrisSkin.xc56e4251b5681836::Void xe8a173d72f8f3729(System.Object, System.EventArgs)
				L_003c: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0041: callvirt System.Windows.Forms.Control::Void add_SizeChanged(System.EventHandler)
				L_0046: ldarg.1 
				L_0047: ldarg.0 
				L_0048: ldftn Sunisoft.IrisSkin.xc56e4251b5681836::Void x9fca9353a2d2087c(System.Object, System.EventArgs)
				L_004e: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0053: callvirt System.Windows.Forms.Control::Void add_LocationChanged(System.EventHandler)
				L_0058: ldarg.1 
				L_0059: ldarg.0 
				L_005a: ldftn Sunisoft.IrisSkin.xc56e4251b5681836::Void xb82f209246987e7a(System.Object, System.EventArgs)
				L_0060: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0065: callvirt System.Windows.Forms.Control::Void add_Resize(System.EventHandler)
				L_006a: ldarg.1 
				L_006b: ldarg.0 
				L_006c: ldftn Sunisoft.IrisSkin.xc56e4251b5681836::Void xc68edf742e725d77(System.Object, System.EventArgs)
				L_0072: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0077: callvirt System.Windows.Forms.Control::Void add_EnabledChanged(System.EventHandler)
				L_007c: ret 
			*/
		#endregion
		
		#region Properties
		
			protected virtual bool CanScroll
			
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
			
			
			private x867b4abdb49f9449 x17ac55c3881d8810
			
			{
				get
				
				/*
					// Code Size: 39 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 x6092b63e9c2b4ce6
					L_0006: brtrue.s L_0020
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
					L_000f: ldarg.0 
					L_0010: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0015: ldc.i4.1 
					L_0016: newobj Sunisoft.IrisSkin.x867b4abdb49f9449::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine, Boolean)
					L_001b: stfld Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 x6092b63e9c2b4ce6
					L_0020: ldarg.0 
					L_0021: ldfld Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 x6092b63e9c2b4ce6
					L_0026: ret 
				*/
				
				{
					if (this.x6092b63e9c2b4ce6 == null)
					{
						this.x6092b63e9c2b4ce6 = new x867b4abdb49f9449 (base.xcd9cdf30888d2204, base.xdc87e2b99332cd4a, true);
					}
					return this.x6092b63e9c2b4ce6;
				}
			}
			
			
			private x867b4abdb49f9449 x641297c2f10f25b0
			
			{
				get
				
				/*
					// Code Size: 39 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 xa1f39a0e58651210
					L_0006: brtrue.s L_0020
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
					L_000f: ldarg.0 
					L_0010: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0015: ldc.i4.0 
					L_0016: newobj Sunisoft.IrisSkin.x867b4abdb49f9449::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine, Boolean)
					L_001b: stfld Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 xa1f39a0e58651210
					L_0020: ldarg.0 
					L_0021: ldfld Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 xa1f39a0e58651210
					L_0026: ret 
				*/
				
				{
					if (this.xa1f39a0e58651210 == null)
					{
						this.xa1f39a0e58651210 = new x867b4abdb49f9449 (base.xcd9cdf30888d2204, base.xdc87e2b99332cd4a, false);
					}
					return this.xa1f39a0e58651210;
				}
			}
			
		#endregion
		
		#region Methods
		
			protected override void AfterWndProc (ref Message m)
			
			/*
				// Code Size: 86 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT V_0, 
         System.UInt32 V_1)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0006: brtrue.s L_0009
				L_0008: ret 
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_000f: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_SkinScrollBar()
				L_0014: brtrue.s L_0017
				L_0016: ret 
				L_0017: ldarg.0 
				L_0018: callvirt Sunisoft.IrisSkin.xc56e4251b5681836::Boolean get_CanScroll()
				L_001d: brtrue.s L_0020
				L_001f: ret 
				L_0020: ldarg.1 
				L_0021: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0026: stloc.1 
				L_0027: ldloc.1 
				L_0028: ldc.i4.s 15
				L_002a: bne.un.s L_004e
				L_002c: ldarg.0 
				L_002d: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0032: ldloca.s V_0
				L_0034: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr BeginPaint(IntPtr, PAINTSTRUCT ByRef)
				L_0039: pop 
				L_003a: ldarg.0 
				L_003b: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0040: ldarg.0 
				L_0041: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0046: ldloca.s V_0
				L_0048: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean EndPaint(IntPtr, PAINTSTRUCT ByRef)
				L_004d: pop 
				L_004e: ldarg.0 
				L_004f: ldarg.1 
				L_0050: call Sunisoft.IrisSkin.x8917d01b98173f4c::Void AfterWndProc(System.Windows.Forms.Message ByRef)
				L_0055: ret 
			*/
			
			
			{
				x40255b11ef821fa3.PAINTSTRUCT pAINTSTRUCT1;
				if ((base.xf2140268ef7ddbf7 && ((SkinEngine) base.xdc87e2b99332cd4a).SkinScrollBar) && this.CanScroll)
				{
					if (((uint) m.Msg) == 15)
					{
						IntPtr intPtr1 = x61467fe65a98f20c.BeginPaint (base.Handle, out pAINTSTRUCT1);
						this.PaintControl ();
						bool b1 = x61467fe65a98f20c.EndPaint (base.Handle, ref pAINTSTRUCT1);
					}
					base.AfterWndProc (ref m);
				}
			}
			
			protected override bool BeforeWndProc (ref Message m)
			
			/*
				// Code Size: 104 Bytes
				.maxstack 3
				.locals (System.UInt32 V_0)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0006: brtrue.s L_0010
				L_0008: ldarg.0 
				L_0009: ldarg.1 
				L_000a: call Sunisoft.IrisSkin.x8917d01b98173f4c::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_000f: ret 
				L_0010: ldarg.0 
				L_0011: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0016: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_SkinScrollBar()
				L_001b: brtrue.s L_0025
				L_001d: ldarg.0 
				L_001e: ldarg.1 
				L_001f: call Sunisoft.IrisSkin.x8917d01b98173f4c::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_0024: ret 
				L_0025: ldarg.0 
				L_0026: callvirt Sunisoft.IrisSkin.xc56e4251b5681836::Boolean get_CanScroll()
				L_002b: brtrue.s L_0035
				L_002d: ldarg.0 
				L_002e: ldarg.1 
				L_002f: call Sunisoft.IrisSkin.x8917d01b98173f4c::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_0034: ret 
				L_0035: ldarg.1 
				L_0036: call System.Windows.Forms.Message::Int32 get_Msg()
				L_003b: stloc.0 
				L_003c: ldloc.0 
				L_003d: ldc.i4 276
				L_0042: sub 
				L_0043: switch (L_005a, L_005a)
				L_0050: ldloc.0 
				L_0051: ldc.i4 512
				L_0056: beq.s L_0060
				L_0058: br.s L_0060
				L_005a: ldarg.0 
				L_005b: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0060: ldarg.0 
				L_0061: ldarg.1 
				L_0062: call Sunisoft.IrisSkin.x8917d01b98173f4c::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_0067: ret 
			*/
			
			
			{
				if (! base.xf2140268ef7ddbf7)
				{
					return base.BeforeWndProc (ref m);
				}
				if (! ((SkinEngine) base.xdc87e2b99332cd4a).SkinScrollBar)
				{
					return base.BeforeWndProc (ref m);
				}
				if (! this.CanScroll)
				{
					return base.BeforeWndProc (ref m);
				}
				uint uInt32_1 = ((uint) m.Msg);
				switch ((int) uInt32_1)
				{
					case 276:
					case 277:
					
					{
							this.PaintControl ();
							return base.BeforeWndProc (ref m);
					}
				}
				return base.BeforeWndProc (ref m);
			}
			
			protected override void OnCurrentSkinChanged (object sender, ISkinChangedEventArgs e)
			
			/*
				// Code Size: 15 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Void OnCurrentSkinChanged(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_0008: ldarg.0 
				L_0009: call Sunisoft.IrisSkin.xc56e4251b5681836::Void xf149df02f1aa3d56()
				L_000e: ret 
			*/
			
			
			{
				base.OnCurrentSkinChanged (sender, e);
				this.xf149df02f1aa3d56 ();
			}
			
			protected override void PaintControl ()
			
			/*
				// Code Size: 1044 Bytes
				.maxstack 7
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO V_0, 
         System.IntPtr V_1, 
         Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_2, 
         System.Drawing.Rectangle V_3, 
         System.Int32 V_4, 
         System.Boolean V_5, 
         System.UInt32 V_6, 
         System.Drawing.Rectangle V_7)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0006: ldarg.0 
				L_0007: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_000c: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0011: stloc.s V_7
				L_0013: ldloca.s V_7
				L_0015: call System.Drawing.Rectangle::Int32 get_Width()
				L_001a: ldc.i4.0 
				L_001b: ble.s L_0034
				L_001d: ldarg.0 
				L_001e: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0023: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0028: stloc.s V_7
				L_002a: ldloca.s V_7
				L_002c: call System.Drawing.Rectangle::Int32 get_Height()
				L_0031: ldc.i4.0 
				L_0032: bgt.s L_0035
				L_0034: ret 
				L_0035: ldarg.0 
				L_0036: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_003b: brtrue.s L_003e
				L_003d: ret 
				L_003e: ldarg.0 
				L_003f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0044: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_SkinScrollBar()
				L_0049: brtrue.s L_004c
				L_004b: ret 
				L_004c: ldloca.s V_0
				L_004e: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO
				L_0054: ldloca.s V_0
				L_0056: ldc.i4.s 60
				L_0058: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::UInt32 cbSize
				L_005d: ldarg.0 
				L_005e: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0063: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindowDC(IntPtr)
				L_0068: stloc.1 
				L_0069: ldloca.s V_2
				L_006b: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
				L_0071: ldarg.0 
				L_0072: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0077: ldloca.s V_2
				L_0079: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowRect(IntPtr, RECT ByRef)
				L_007e: pop 
				L_007f: ldc.i4.0 
				L_0080: stloc.s V_4
				L_0082: ldc.i4.0 
				L_0083: stloc.s V_5
				L_0085: ldarg.0 
				L_0086: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_008b: ldc.i4.s -5
				L_008d: ldloca.s V_0
				L_008f: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollBarInfo(IntPtr, UInt32, SCROLLBARINFO ByRef)
				L_0094: brfalse L_024a
				L_0099: ldloca.s V_3
				L_009b: ldloca.s V_0
				L_009d: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00a2: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_00a7: ldloca.s V_2
				L_00a9: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_00ae: sub 
				L_00af: ldloca.s V_0
				L_00b1: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00b6: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_00bb: ldloca.s V_2
				L_00bd: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_00c2: sub 
				L_00c3: ldloca.s V_0
				L_00c5: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00ca: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_00cf: ldloca.s V_0
				L_00d1: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00d6: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_00db: sub 
				L_00dc: ldloca.s V_0
				L_00de: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00e3: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_00e8: ldloca.s V_0
				L_00ea: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00ef: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_00f4: sub 
				L_00f5: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00fa: ldloca.s V_3
				L_00fc: call System.Drawing.Rectangle::Int32 get_X()
				L_0101: ldc.i4.0 
				L_0102: blt L_0234
				L_0107: ldloca.s V_3
				L_0109: call System.Drawing.Rectangle::Int32 get_Y()
				L_010e: ldc.i4.0 
				L_010f: blt L_0234
				L_0114: ldloca.s V_3
				L_0116: call System.Drawing.Rectangle::Int32 get_Width()
				L_011b: ldc.i4.0 
				L_011c: ble L_0234
				L_0121: ldloca.s V_3
				L_0123: call System.Drawing.Rectangle::Int32 get_Height()
				L_0128: ldc.i4.0 
				L_0129: ble L_0234
				L_012e: ldloca.s V_3
				L_0130: dup 
				L_0131: call System.Drawing.Rectangle::Int32 get_X()
				L_0136: ldarg.0 
				L_0137: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_013c: callvirt System.Windows.Forms.Control::Int32 get_Left()
				L_0141: add 
				L_0142: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0147: ldloca.s V_3
				L_0149: dup 
				L_014a: call System.Drawing.Rectangle::Int32 get_Y()
				L_014f: ldarg.0 
				L_0150: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0155: callvirt System.Windows.Forms.Control::Int32 get_Top()
				L_015a: add 
				L_015b: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_0160: ldarg.0 
				L_0161: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0166: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_016b: ldc.i4.1 
				L_016c: and 
				L_016d: ldc.i4.1 
				L_016e: bne.un L_01fe
				L_0173: ldarg.0 
				L_0174: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0179: callvirt System.Windows.Forms.Control::System.Windows.Forms.Control get_Parent()
				L_017e: brfalse.s L_01f3
				L_0180: ldarg.0 
				L_0181: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0186: callvirt System.Windows.Forms.Control::System.Windows.Forms.Control get_Parent()
				L_018b: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0190: ldc.i4.s -20
				L_0192: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
				L_0197: stloc.s V_6
				L_0199: ldloc.s V_6
				L_019b: ldc.i4 4194304
				L_01a0: and 
				L_01a1: ldc.i4 4194304
				L_01a6: bne.un.s L_0207
				L_01a8: ldloc.s V_6
				L_01aa: ldc.i4 1048576
				L_01af: and 
				L_01b0: ldc.i4 1048576
				L_01b5: bne.un.s L_0207
				L_01b7: ldc.i4.1 
				L_01b8: stloc.s V_5
				L_01ba: ldloca.s V_3
				L_01bc: ldarg.0 
				L_01bd: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_01c2: callvirt System.Windows.Forms.Control::Int32 get_Right()
				L_01c7: ldloca.s V_3
				L_01c9: call System.Drawing.Rectangle::Int32 get_Width()
				L_01ce: sub 
				L_01cf: ldarg.0 
				L_01d0: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_01d5: callvirt System.Windows.Forms.Control::Int32 get_Left()
				L_01da: ldloca.s V_3
				L_01dc: call System.Drawing.Rectangle::Int32 get_Left()
				L_01e1: sub 
				L_01e2: add 
				L_01e3: call System.Drawing.Rectangle::Void set_X(Int32)
				L_01e8: ldloca.s V_3
				L_01ea: call System.Drawing.Rectangle::Int32 get_Left()
				L_01ef: stloc.s V_4
				L_01f1: br.s L_0207
				L_01f3: ldloca.s V_3
				L_01f5: call System.Drawing.Rectangle::Int32 get_Left()
				L_01fa: stloc.s V_4
				L_01fc: br.s L_0207
				L_01fe: ldloca.s V_3
				L_0200: call System.Drawing.Rectangle::Int32 get_Right()
				L_0205: stloc.s V_4
				L_0207: ldarg.0 
				L_0208: call Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 get_x641297c2f10f25b0()
				L_020d: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_Bounds()
				L_0212: ldloc.3 
				L_0213: call System.Drawing.Rectangle::Boolean op_Inequality(System.Drawing.Rectangle, System.Drawing.Rectangle)
				L_0218: brfalse.s L_0226
				L_021a: ldarg.0 
				L_021b: call Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 get_x641297c2f10f25b0()
				L_0220: ldloc.3 
				L_0221: callvirt System.Windows.Forms.Control::Void set_Bounds(System.Drawing.Rectangle)
				L_0226: ldarg.0 
				L_0227: call Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 get_x641297c2f10f25b0()
				L_022c: ldloc.0 
				L_022d: callvirt Sunisoft.IrisSkin.x867b4abdb49f9449::Void x9b8f9735fbcfbe34(SCROLLBARINFO)
				L_0232: br.s L_025e
				L_0234: ldarg.0 
				L_0235: ldfld Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 xa1f39a0e58651210
				L_023a: brfalse.s L_025e
				L_023c: ldarg.0 
				L_023d: call Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 get_x641297c2f10f25b0()
				L_0242: ldc.i4.0 
				L_0243: callvirt System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_0248: br.s L_025e
				L_024a: ldarg.0 
				L_024b: ldfld Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 xa1f39a0e58651210
				L_0250: brfalse.s L_025e
				L_0252: ldarg.0 
				L_0253: call Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 get_x641297c2f10f25b0()
				L_0258: ldc.i4.0 
				L_0259: callvirt System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_025e: ldarg.0 
				L_025f: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0264: ldc.i4.s -6
				L_0266: ldloca.s V_0
				L_0268: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollBarInfo(IntPtr, UInt32, SCROLLBARINFO ByRef)
				L_026d: brfalse L_03f2
				L_0272: ldloca.s V_3
				L_0274: ldloca.s V_0
				L_0276: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_027b: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0280: ldloca.s V_2
				L_0282: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0287: sub 
				L_0288: ldloca.s V_0
				L_028a: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_028f: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0294: ldloca.s V_2
				L_0296: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_029b: sub 
				L_029c: ldloca.s V_0
				L_029e: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_02a3: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_02a8: ldloca.s V_0
				L_02aa: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_02af: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_02b4: sub 
				L_02b5: ldloca.s V_0
				L_02b7: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_02bc: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_02c1: ldloca.s V_0
				L_02c3: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_02c8: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_02cd: sub 
				L_02ce: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_02d3: ldloca.s V_3
				L_02d5: call System.Drawing.Rectangle::Int32 get_X()
				L_02da: ldc.i4.0 
				L_02db: blt L_03dc
				L_02e0: ldloca.s V_3
				L_02e2: call System.Drawing.Rectangle::Int32 get_Y()
				L_02e7: ldc.i4.0 
				L_02e8: blt L_03dc
				L_02ed: ldloca.s V_3
				L_02ef: call System.Drawing.Rectangle::Int32 get_Width()
				L_02f4: ldc.i4.0 
				L_02f5: ble L_03dc
				L_02fa: ldloca.s V_3
				L_02fc: call System.Drawing.Rectangle::Int32 get_Height()
				L_0301: ldc.i4.0 
				L_0302: ble L_03dc
				L_0307: ldloca.s V_3
				L_0309: dup 
				L_030a: call System.Drawing.Rectangle::Int32 get_X()
				L_030f: ldarg.0 
				L_0310: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0315: callvirt System.Windows.Forms.Control::Int32 get_Left()
				L_031a: add 
				L_031b: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0320: ldloca.s V_3
				L_0322: dup 
				L_0323: call System.Drawing.Rectangle::Int32 get_Y()
				L_0328: ldarg.0 
				L_0329: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_032e: callvirt System.Windows.Forms.Control::Int32 get_Top()
				L_0333: add 
				L_0334: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_0339: ldloc.s V_4
				L_033b: brfalse.s L_03af
				L_033d: ldarg.0 
				L_033e: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0343: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_0348: ldc.i4.1 
				L_0349: and 
				L_034a: ldc.i4.1 
				L_034b: bne.un.s L_0392
				L_034d: ldloc.s V_5
				L_034f: brfalse.s L_0373
				L_0351: ldloc.s V_4
				L_0353: ldloca.s V_3
				L_0355: call System.Drawing.Rectangle::Int32 get_Width()
				L_035a: sub 
				L_035b: ldloca.s V_3
				L_035d: call System.Drawing.Rectangle::Int32 get_Top()
				L_0362: ldloc.s V_4
				L_0364: ldloca.s V_3
				L_0366: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_036b: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0370: stloc.3 
				L_0371: br.s L_03af
				L_0373: ldloc.s V_4
				L_0375: ldloca.s V_3
				L_0377: call System.Drawing.Rectangle::Int32 get_Top()
				L_037c: ldloca.s V_3
				L_037e: call System.Drawing.Rectangle::Int32 get_Right()
				L_0383: ldloca.s V_3
				L_0385: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_038a: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_038f: stloc.3 
				L_0390: br.s L_03af
				L_0392: ldloca.s V_3
				L_0394: call System.Drawing.Rectangle::Int32 get_Left()
				L_0399: ldloca.s V_3
				L_039b: call System.Drawing.Rectangle::Int32 get_Top()
				L_03a0: ldloc.s V_4
				L_03a2: ldloca.s V_3
				L_03a4: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_03a9: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_03ae: stloc.3 
				L_03af: ldarg.0 
				L_03b0: call Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 get_x17ac55c3881d8810()
				L_03b5: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_Bounds()
				L_03ba: ldloc.3 
				L_03bb: call System.Drawing.Rectangle::Boolean op_Inequality(System.Drawing.Rectangle, System.Drawing.Rectangle)
				L_03c0: brfalse.s L_03ce
				L_03c2: ldarg.0 
				L_03c3: call Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 get_x17ac55c3881d8810()
				L_03c8: ldloc.3 
				L_03c9: callvirt System.Windows.Forms.Control::Void set_Bounds(System.Drawing.Rectangle)
				L_03ce: ldarg.0 
				L_03cf: call Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 get_x17ac55c3881d8810()
				L_03d4: ldloc.0 
				L_03d5: callvirt Sunisoft.IrisSkin.x867b4abdb49f9449::Void x9b8f9735fbcfbe34(SCROLLBARINFO)
				L_03da: br.s L_0406
				L_03dc: ldarg.0 
				L_03dd: ldfld Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 x6092b63e9c2b4ce6
				L_03e2: brfalse.s L_0406
				L_03e4: ldarg.0 
				L_03e5: call Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 get_x17ac55c3881d8810()
				L_03ea: ldc.i4.0 
				L_03eb: callvirt System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_03f0: br.s L_0406
				L_03f2: ldarg.0 
				L_03f3: ldfld Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 x6092b63e9c2b4ce6
				L_03f8: brfalse.s L_0406
				L_03fa: ldarg.0 
				L_03fb: call Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 get_x17ac55c3881d8810()
				L_0400: ldc.i4.0 
				L_0401: callvirt System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_0406: ldarg.0 
				L_0407: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_040c: ldloc.1 
				L_040d: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_0412: pop 
				L_0413: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				uint uInt32_1;
				base.PaintControl ();
				if ((((base.xcd9cdf30888d2204.ClientRectangle.Width <= 0) || (base.xcd9cdf30888d2204.ClientRectangle.Height <= 0)) || (! base.xf2140268ef7ddbf7)) || (! ((SkinEngine) base.xdc87e2b99332cd4a).SkinScrollBar))
				{
					return;
				}
				x40255b11ef821fa3.SCROLLBARINFO sCROLLBARINFO1 = new x40255b11ef821fa3.SCROLLBARINFO ();
				sCROLLBARINFO1.cbSize = 60;
				IntPtr intPtr1 = x61467fe65a98f20c.GetWindowDC (base.Handle);
				xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
				bool b2 = x61467fe65a98f20c.GetWindowRect (base.Handle, ref rECT1);
				int i1 = 0;
				bool b1 = false;
				if (x61467fe65a98f20c.GetScrollBarInfo (base.Handle, ((uint) 0x00FB), ref sCROLLBARINFO1))
				{
					rectangle1 = new Rectangle (((int) (sCROLLBARINFO1.rcScrollBar.left - rECT1.left)), ((int) (sCROLLBARINFO1.rcScrollBar.top - rECT1.top)), ((int) (sCROLLBARINFO1.rcScrollBar.right - sCROLLBARINFO1.rcScrollBar.left)), ((int) (sCROLLBARINFO1.rcScrollBar.bottom - sCROLLBARINFO1.rcScrollBar.top)));
					if ((((rectangle1.X >= 0) && (rectangle1.Y >= 0)) && (rectangle1.Width > 0)) && (rectangle1.Height > 0))
					{
						rectangle1.X += base.xcd9cdf30888d2204.Left;
						rectangle1.Y += base.xcd9cdf30888d2204.Top;
						if ((base.xcd9cdf30888d2204.RightToLeft & RightToLeft.Yes) != RightToLeft.Yes)
						{
							i1 = rectangle1.Right;
						}
						else if (base.xcd9cdf30888d2204.Parent != null)
						{
							uInt32_1 = x61467fe65a98f20c.GetWindowLong (base.xcd9cdf30888d2204.Parent.Handle, -20);
							if (((((int) uInt32_1) & 4194304) == 4194304) && ((((int) uInt32_1) & 1048576) == 1048576))
							{
								b1 = true;
								rectangle1.X = ((base.xcd9cdf30888d2204.Right - rectangle1.Width) + (base.xcd9cdf30888d2204.Left - rectangle1.Left));
								i1 = rectangle1.Left;
							}
						}
						else
						{
							i1 = rectangle1.Left;
						}
						if (this.x641297c2f10f25b0.Bounds != rectangle1)
						{
							this.x641297c2f10f25b0.Bounds = rectangle1;
						}
						this.x641297c2f10f25b0.x9b8f9735fbcfbe34 (sCROLLBARINFO1);
					}
					else if (this.xa1f39a0e58651210 != null)
					{
						this.x641297c2f10f25b0.Visible = false;
					}
				}
				else if (this.xa1f39a0e58651210 != null)
				{
					this.x641297c2f10f25b0.Visible = false;
				}
				if (x61467fe65a98f20c.GetScrollBarInfo (base.Handle, ((uint) 0x00FA), ref sCROLLBARINFO1))
				{
					rectangle1 = new Rectangle (((int) (sCROLLBARINFO1.rcScrollBar.left - rECT1.left)), ((int) (sCROLLBARINFO1.rcScrollBar.top - rECT1.top)), ((int) (sCROLLBARINFO1.rcScrollBar.right - sCROLLBARINFO1.rcScrollBar.left)), ((int) (sCROLLBARINFO1.rcScrollBar.bottom - sCROLLBARINFO1.rcScrollBar.top)));
					if ((((rectangle1.X >= 0) && (rectangle1.Y >= 0)) && (rectangle1.Width > 0)) && (rectangle1.Height > 0))
					{
						rectangle1.X += base.xcd9cdf30888d2204.Left;
						rectangle1.Y += base.xcd9cdf30888d2204.Top;
						if (i1 != 0)
						{
							if ((base.xcd9cdf30888d2204.RightToLeft & RightToLeft.Yes) != RightToLeft.Yes)
							{
								rectangle1 = Rectangle.FromLTRB (rectangle1.Left, rectangle1.Top, i1, rectangle1.Bottom);
							}
							else if (! b1)
							{
								rectangle1 = Rectangle.FromLTRB (i1, rectangle1.Top, rectangle1.Right, rectangle1.Bottom);
							}
							else
							{
								rectangle1 = Rectangle.FromLTRB (((int) (i1 - rectangle1.Width)), rectangle1.Top, i1, rectangle1.Bottom);
							}
						}
						if (this.x17ac55c3881d8810.Bounds != rectangle1)
						{
							this.x17ac55c3881d8810.Bounds = rectangle1;
						}
						this.x17ac55c3881d8810.x9b8f9735fbcfbe34 (sCROLLBARINFO1);
					}
					else if (this.x6092b63e9c2b4ce6 != null)
					{
						this.x17ac55c3881d8810.Visible = false;
					}
				}
				else if (this.x6092b63e9c2b4ce6 != null)
				{
					this.x17ac55c3881d8810.Visible = false;
				}
				int i2 = x61467fe65a98f20c.ReleaseDC (base.Handle, intPtr1);
			}
			
			private void x9fca9353a2d2087c (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xc56e4251b5681836::Void xf149df02f1aa3d56()
				L_0006: ret 
			*/
			
			
			{
				this.xf149df02f1aa3d56 ();
			}
			
			private void xb82f209246987e7a (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xc56e4251b5681836::Void xf149df02f1aa3d56()
				L_0006: ret 
			*/
			
			
			{
				this.xf149df02f1aa3d56 ();
			}
			
			private void xbad904bdcc347055 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xc56e4251b5681836::Void xf149df02f1aa3d56()
				L_0006: ret 
			*/
			
			
			{
				this.xf149df02f1aa3d56 ();
			}
			
			private void xc68edf742e725d77 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
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
			
			private void xdf8f78b46a8ed400 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
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
			
			private void xe8a173d72f8f3729 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 13 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.xc56e4251b5681836::Void xf149df02f1aa3d56()
				L_0006: ldarg.0 
				L_0007: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_000c: ret 
			*/
			
			
			{
				this.xf149df02f1aa3d56 ();
				this.PaintControl ();
			}
			
			private void xf149df02f1aa3d56 ()
			
			/*
				// Code Size: 113 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 x6092b63e9c2b4ce6
				L_0006: brfalse.s L_0038
				L_0008: ldarg.0 
				L_0009: call Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 get_x17ac55c3881d8810()
				L_000e: ldarg.0 
				L_000f: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0014: ldarg.0 
				L_0015: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001a: callvirt System.Windows.Forms.Control::Boolean get_Visible()
				L_001f: and 
				L_0020: ldarg.0 
				L_0021: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0026: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_SkinScrollBar()
				L_002b: and 
				L_002c: ldarg.0 
				L_002d: callvirt Sunisoft.IrisSkin.xc56e4251b5681836::Boolean get_CanScroll()
				L_0032: and 
				L_0033: callvirt System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_0038: ldarg.0 
				L_0039: ldfld Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 xa1f39a0e58651210
				L_003e: brfalse.s L_0070
				L_0040: ldarg.0 
				L_0041: call Sunisoft.IrisSkin.xc56e4251b5681836::Sunisoft.IrisSkin.x867b4abdb49f9449 get_x641297c2f10f25b0()
				L_0046: ldarg.0 
				L_0047: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_004c: ldarg.0 
				L_004d: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0052: callvirt System.Windows.Forms.Control::Boolean get_Visible()
				L_0057: and 
				L_0058: ldarg.0 
				L_0059: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_005e: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_SkinScrollBar()
				L_0063: and 
				L_0064: ldarg.0 
				L_0065: callvirt Sunisoft.IrisSkin.xc56e4251b5681836::Boolean get_CanScroll()
				L_006a: and 
				L_006b: callvirt System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_0070: ret 
			*/
			
			
			{
				if (this.x6092b63e9c2b4ce6 != null)
				{
					this.x17ac55c3881d8810.Visible = (((base.xf2140268ef7ddbf7 && base.xcd9cdf30888d2204.Visible) && ((SkinEngine) base.xdc87e2b99332cd4a).SkinScrollBar) && this.CanScroll);
				}
				if (this.xa1f39a0e58651210 != null)
				{
					this.x641297c2f10f25b0.Visible = (((base.xf2140268ef7ddbf7 && base.xcd9cdf30888d2204.Visible) && ((SkinEngine) base.xdc87e2b99332cd4a).SkinScrollBar) && this.CanScroll);
				}
			}
			
		#endregion
	}
	
}

