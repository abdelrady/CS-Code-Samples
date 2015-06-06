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
			using System.Drawing.Drawing2D;
			using System.Drawing.Imaging;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class xac9a4b8f6325d7e3 : x8917d01b98173f4c
	
	{
		
		#region Fields
			private const int x4aac5d4d05a8fbe8 = 2;
			private Hashtable x6d04a76446187b96;
			private const int x7a64d9f3c21462d5 = 13;
			private static StringFormat xae3b2752a89e7464;
			private const int xaeefdaeb2a720f7d = 2;
		#endregion
		
		#region Constructors
		
			static xac9a4b8f6325d7e3 ()
			/*
				// Code Size: 44 Bytes
				.maxstack 9
				L_0000: newobj System.Drawing.StringFormat::Void .ctor()
				L_0005: stsfld Sunisoft.IrisSkin.xac9a4b8f6325d7e3::System.Drawing.StringFormat xae3b2752a89e7464
				L_000a: ldsfld Sunisoft.IrisSkin.xac9a4b8f6325d7e3::System.Drawing.StringFormat xae3b2752a89e7464
				L_000f: ldc.i4.1 
				L_0010: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_0015: ldsfld Sunisoft.IrisSkin.xac9a4b8f6325d7e3::System.Drawing.StringFormat xae3b2752a89e7464
				L_001a: ldc.i4.1 
				L_001b: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_0020: ldsfld Sunisoft.IrisSkin.xac9a4b8f6325d7e3::System.Drawing.StringFormat xae3b2752a89e7464
				L_0025: ldc.i4.1 
				L_0026: callvirt System.Drawing.StringFormat::Void set_HotkeyPrefix(System.Drawing.Text.HotkeyPrefix)
				L_002b: ret 
			*/
			
			public xac9a4b8f6325d7e3 (Control control, ISkinEngine engine)
				 : base (control, engine)
			/*
				// Code Size: 20 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.x8917d01b98173f4c::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ldarg.0 
				L_0009: newobj System.Collections.Hashtable::Void .ctor()
				L_000e: stfld Sunisoft.IrisSkin.xac9a4b8f6325d7e3::System.Collections.Hashtable x6d04a76446187b96
				L_0013: ret 
			*/
		#endregion
		
		#region Methods
		
			protected override bool BeforeWndProc (ref Message m)
			
			/*
				// Code Size: 76 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT V_0, 
         System.UInt32 V_1)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0006: stloc.1 
				L_0007: ldloc.1 
				L_0008: ldc.i4.5 
				L_0009: beq.s L_003e
				L_000b: ldloc.1 
				L_000c: ldc.i4.s 15
				L_000e: bne.un.s L_0044
				L_0010: ldarg.0 
				L_0011: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0016: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_001b: ldloca.s V_0
				L_001d: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr BeginPaint(IntPtr, PAINTSTRUCT ByRef)
				L_0022: pop 
				L_0023: ldarg.0 
				L_0024: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0029: ldarg.0 
				L_002a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_002f: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0034: ldloca.s V_0
				L_0036: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean EndPaint(IntPtr, PAINTSTRUCT ByRef)
				L_003b: pop 
				L_003c: br.s L_0044
				L_003e: ldarg.0 
				L_003f: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0044: ldarg.0 
				L_0045: ldarg.1 
				L_0046: call Sunisoft.IrisSkin.x8917d01b98173f4c::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_004b: ret 
			*/
			
			
			{
				x40255b11ef821fa3.PAINTSTRUCT pAINTSTRUCT1;
				uint uInt32_1 = ((uint) m.Msg);
				if (uInt32_1 == 5)
				{
					this.PaintControl ();
				}
				else if (uInt32_1 == 15)
				{
					IntPtr intPtr1 = x61467fe65a98f20c.BeginPaint (base.xcd9cdf30888d2204.Handle, out pAINTSTRUCT1);
					this.PaintControl ();
					bool b1 = x61467fe65a98f20c.EndPaint (base.xcd9cdf30888d2204.Handle, ref pAINTSTRUCT1);
				}
				return base.BeforeWndProc (ref m);
			}
			
			protected override void DoInit ()
			
			/*
				// Code Size: 55 Bytes
				.maxstack 5
				.locals (System.Windows.Forms.ToolBar V_0)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x8917d01b98173f4c::Void DoInit()
				L_0006: ldarg.0 
				L_0007: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_000c: castclass System.Windows.Forms.ToolBar
				L_0011: stloc.0 
				L_0012: ldloc.0 
				L_0013: ldarg.0 
				L_0014: ldftn Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void x92735afcf18b3c70(System.Object, System.Windows.Forms.MouseEventArgs)
				L_001a: newobj System.Windows.Forms.MouseEventHandler::Void .ctor(System.Object, IntPtr)
				L_001f: callvirt System.Windows.Forms.Control::Void add_MouseMove(System.Windows.Forms.MouseEventHandler)
				L_0024: ldloc.0 
				L_0025: ldarg.0 
				L_0026: ldftn Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void x7f302ba563726f8f(System.Object, System.Windows.Forms.ToolBarButtonClickEventArgs)
				L_002c: newobj System.Windows.Forms.ToolBarButtonClickEventHandler::Void .ctor(System.Object, IntPtr)
				L_0031: callvirt System.Windows.Forms.ToolBar::Void add_ButtonDropDown(System.Windows.Forms.ToolBarButtonClickEventHandler)
				L_0036: ret 
			*/
			
			
			{
				base.DoInit ();
				ToolBar toolBar1 = ((ToolBar) base.xcd9cdf30888d2204);
				toolBar1.MouseMove += new MouseEventHandler (this.x92735afcf18b3c70);
				toolBar1.ButtonDropDown += new ToolBarButtonClickEventHandler (this.x7f302ba563726f8f);
			}
			
			protected override void PaintControl ()
			
			/*
				// Code Size: 800 Bytes
				.maxstack 10
				.locals (System.Windows.Forms.ToolBar V_0, 
         System.IntPtr V_1, 
         System.Drawing.Bitmap V_2, 
         System.Drawing.Graphics V_3, 
         System.Drawing.Bitmap V_4, 
         System.Drawing.Graphics V_5, 
         System.Drawing.Drawing2D.LinearGradientBrush V_6, 
         System.Drawing.Rectangle V_7, 
         System.Windows.Forms.ToolBarButton V_8, 
         System.Drawing.Rectangle V_9, 
         System.Collections.IEnumerator V_10, 
         Sunisoft.IrisSkin.xb9506a535e31f22a V_11, 
         System.IDisposable V_12)
				.try L_0107 to L_0120 finally L_0120 to L_012c
				.try L_0139 to L_02cb finally L_02cb to L_02e0
				.try L_008e to L_02e2 finally L_02e2 to L_02ee
				.try L_0085 to L_02fa finally L_02fa to L_0306
				.try L_0072 to L_0315 finally L_0315 to L_031f
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_000b: stloc.s V_9
				L_000d: ldloca.s V_9
				L_000f: call System.Drawing.Rectangle::Int32 get_Width()
				L_0014: ldc.i4.0 
				L_0015: ble.s L_002e
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001d: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0022: stloc.s V_9
				L_0024: ldloca.s V_9
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
				L_003e: castclass System.Windows.Forms.ToolBar
				L_0043: stloc.0 
				L_0044: ldarg.0 
				L_0045: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_004a: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindowDC(IntPtr)
				L_004f: stloc.1 
				L_0050: ldarg.0 
				L_0051: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0056: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_005b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0060: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_TOOLBAR()
				L_0065: stloc.2 
				L_0066: ldarg.0 
				L_0067: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_006c: call System.Drawing.Graphics::System.Drawing.Graphics FromHwnd(IntPtr)
				L_0071: stloc.3 
				L_0072: ldloc.0 
				L_0073: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0078: ldloc.0 
				L_0079: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_007e: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0083: stloc.s V_4
				L_0085: ldloc.s V_4
				L_0087: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_008c: stloc.s V_5
				L_008e: ldloc.2 
				L_008f: brfalse.s L_00c2
				L_0091: ldloc.s V_5
				L_0093: ldloc.2 
				L_0094: ldc.i4.0 
				L_0095: ldc.i4.0 
				L_0096: ldloc.0 
				L_0097: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_009c: ldloc.0 
				L_009d: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_00a2: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00a7: ldc.i4.0 
				L_00a8: ldc.i4.0 
				L_00a9: ldloc.2 
				L_00aa: callvirt System.Drawing.Image::Int32 get_Width()
				L_00af: ldloc.2 
				L_00b0: callvirt System.Drawing.Image::Int32 get_Height()
				L_00b5: ldc.i4.2 
				L_00b6: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x349935d524988797()
				L_00bb: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_00c0: br.s L_012c
				L_00c2: ldc.i4.0 
				L_00c3: ldc.i4.0 
				L_00c4: ldloc.0 
				L_00c5: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_00ca: ldloc.0 
				L_00cb: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_00d0: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00d5: ldarg.0 
				L_00d6: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00db: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00e0: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_00e5: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TOOLBARSTARTCOLOR
				L_00ea: ldarg.0 
				L_00eb: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00f0: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00f5: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_00fa: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TOOLBARENDCOLOR
				L_00ff: ldc.i4.1 
				L_0100: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Rectangle, System.Drawing.Color, System.Drawing.Color, System.Drawing.Drawing2D.LinearGradientMode)
				L_0105: stloc.s V_6
				L_0107: ldloc.s V_5
				L_0109: ldloc.s V_6
				L_010b: ldc.i4.0 
				L_010c: ldc.i4.0 
				L_010d: ldloc.0 
				L_010e: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0113: ldloc.0 
				L_0114: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0119: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_011e: leave.s L_012c
				L_0120: ldloc.s V_6
				L_0122: brfalse.s L_012b
				L_0124: ldloc.s V_6
				L_0126: callvirt System.IDisposable::Void Dispose()
				L_012b: endfinally 
				L_012c: ldloc.0 
				L_012d: callvirt System.Windows.Forms.ToolBar::ToolBarButtonCollection get_Buttons()
				L_0132: callvirt System.Windows.Forms.ToolBar+ToolBarButtonCollection::System.Collections.IEnumerator GetEnumerator()
				L_0137: stloc.s V_10
				L_0139: br L_02bd
				L_013e: ldloc.s V_10
				L_0140: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0145: castclass System.Windows.Forms.ToolBarButton
				L_014a: stloc.s V_8
				L_014c: ldloc.s V_8
				L_014e: callvirt System.Windows.Forms.ToolBarButton::Boolean get_Visible()
				L_0153: brfalse L_02bd
				L_0158: ldloc.s V_8
				L_015a: callvirt System.Windows.Forms.ToolBarButton::System.Drawing.Rectangle get_Rectangle()
				L_015f: stloc.s V_7
				L_0161: ldloc.s V_8
				L_0163: callvirt System.Windows.Forms.ToolBarButton::System.Windows.Forms.ToolBarButtonStyle get_Style()
				L_0168: ldc.i4.3 
				L_0169: bne.un.s L_017c
				L_016b: ldarg.0 
				L_016c: ldloc.s V_5
				L_016e: ldloc.s V_7
				L_0170: ldloc.s V_8
				L_0172: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xa8d12864a9092939(System.Drawing.Graphics, System.Drawing.Rectangle, System.Windows.Forms.ToolBarButton)
				L_0177: br L_02bd
				L_017c: ldloc.s V_8
				L_017e: callvirt System.Windows.Forms.ToolBarButton::System.Windows.Forms.ToolBarButtonStyle get_Style()
				L_0183: ldc.i4.2 
				L_0184: bne.un L_0232
				L_0189: ldloc.s V_8
				L_018b: callvirt System.Windows.Forms.ToolBarButton::Boolean get_Pushed()
				L_0190: brfalse.s L_01a3
				L_0192: ldarg.0 
				L_0193: ldloc.s V_5
				L_0195: ldloc.s V_7
				L_0197: ldloc.s V_8
				L_0199: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xa8337c38d02b5c00(System.Drawing.Graphics, System.Drawing.Rectangle, System.Windows.Forms.ToolBarButton)
				L_019e: br L_02bd
				L_01a3: ldarg.0 
				L_01a4: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_01a9: ldc.i4.2 
				L_01aa: bne.un.s L_01e2
				L_01ac: ldloc.0 
				L_01ad: call System.Windows.Forms.Control::System.Drawing.Point get_MousePosition()
				L_01b2: callvirt System.Windows.Forms.Control::System.Drawing.Point PointToClient(System.Drawing.Point)
				L_01b7: ldloc.s V_7
				L_01b9: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_01be: brfalse.s L_01d1
				L_01c0: ldarg.0 
				L_01c1: ldloc.s V_5
				L_01c3: ldloc.s V_7
				L_01c5: ldloc.s V_8
				L_01c7: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void x721082aab66b93c4(System.Drawing.Graphics, System.Drawing.Rectangle, System.Windows.Forms.ToolBarButton)
				L_01cc: br L_02bd
				L_01d1: ldarg.0 
				L_01d2: ldloc.s V_5
				L_01d4: ldloc.s V_7
				L_01d6: ldloc.s V_8
				L_01d8: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xb30ec7cfdf3e5c19(System.Drawing.Graphics, System.Drawing.Rectangle, System.Windows.Forms.ToolBarButton)
				L_01dd: br L_02bd
				L_01e2: ldarg.0 
				L_01e3: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_01e8: ldc.i4.3 
				L_01e9: bne.un.s L_0221
				L_01eb: ldloc.0 
				L_01ec: call System.Windows.Forms.Control::System.Drawing.Point get_MousePosition()
				L_01f1: callvirt System.Windows.Forms.Control::System.Drawing.Point PointToClient(System.Drawing.Point)
				L_01f6: ldloc.s V_7
				L_01f8: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_01fd: brfalse.s L_0210
				L_01ff: ldarg.0 
				L_0200: ldloc.s V_5
				L_0202: ldloc.s V_7
				L_0204: ldloc.s V_8
				L_0206: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xa8337c38d02b5c00(System.Drawing.Graphics, System.Drawing.Rectangle, System.Windows.Forms.ToolBarButton)
				L_020b: br L_02bd
				L_0210: ldarg.0 
				L_0211: ldloc.s V_5
				L_0213: ldloc.s V_7
				L_0215: ldloc.s V_8
				L_0217: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xb30ec7cfdf3e5c19(System.Drawing.Graphics, System.Drawing.Rectangle, System.Windows.Forms.ToolBarButton)
				L_021c: br L_02bd
				L_0221: ldarg.0 
				L_0222: ldloc.s V_5
				L_0224: ldloc.s V_7
				L_0226: ldloc.s V_8
				L_0228: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xb30ec7cfdf3e5c19(System.Drawing.Graphics, System.Drawing.Rectangle, System.Windows.Forms.ToolBarButton)
				L_022d: br L_02bd
				L_0232: ldarg.0 
				L_0233: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.xb9506a535e31f22a xdd938462da9aed37
				L_0238: stloc.s V_11
				L_023a: ldloc.s V_11
				L_023c: ldc.i4.1 
				L_023d: sub 
				L_023e: switch (L_02b1, L_0281, L_0251)
				L_024f: br.s L_02b1
				L_0251: ldloc.0 
				L_0252: call System.Windows.Forms.Control::System.Drawing.Point get_MousePosition()
				L_0257: callvirt System.Windows.Forms.Control::System.Drawing.Point PointToClient(System.Drawing.Point)
				L_025c: ldloc.s V_7
				L_025e: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0263: brfalse.s L_0273
				L_0265: ldarg.0 
				L_0266: ldloc.s V_5
				L_0268: ldloc.s V_7
				L_026a: ldloc.s V_8
				L_026c: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xa8337c38d02b5c00(System.Drawing.Graphics, System.Drawing.Rectangle, System.Windows.Forms.ToolBarButton)
				L_0271: br.s L_02bd
				L_0273: ldarg.0 
				L_0274: ldloc.s V_5
				L_0276: ldloc.s V_7
				L_0278: ldloc.s V_8
				L_027a: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xb30ec7cfdf3e5c19(System.Drawing.Graphics, System.Drawing.Rectangle, System.Windows.Forms.ToolBarButton)
				L_027f: br.s L_02bd
				L_0281: ldloc.0 
				L_0282: call System.Windows.Forms.Control::System.Drawing.Point get_MousePosition()
				L_0287: callvirt System.Windows.Forms.Control::System.Drawing.Point PointToClient(System.Drawing.Point)
				L_028c: ldloc.s V_7
				L_028e: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0293: brfalse.s L_02a3
				L_0295: ldarg.0 
				L_0296: ldloc.s V_5
				L_0298: ldloc.s V_7
				L_029a: ldloc.s V_8
				L_029c: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void x721082aab66b93c4(System.Drawing.Graphics, System.Drawing.Rectangle, System.Windows.Forms.ToolBarButton)
				L_02a1: br.s L_02bd
				L_02a3: ldarg.0 
				L_02a4: ldloc.s V_5
				L_02a6: ldloc.s V_7
				L_02a8: ldloc.s V_8
				L_02aa: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xb30ec7cfdf3e5c19(System.Drawing.Graphics, System.Drawing.Rectangle, System.Windows.Forms.ToolBarButton)
				L_02af: br.s L_02bd
				L_02b1: ldarg.0 
				L_02b2: ldloc.s V_5
				L_02b4: ldloc.s V_7
				L_02b6: ldloc.s V_8
				L_02b8: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xb30ec7cfdf3e5c19(System.Drawing.Graphics, System.Drawing.Rectangle, System.Windows.Forms.ToolBarButton)
				L_02bd: ldloc.s V_10
				L_02bf: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_02c4: brtrue L_013e
				L_02c9: leave.s L_02e0
				L_02cb: ldloc.s V_10
				L_02cd: isinst System.IDisposable
				L_02d2: stloc.s V_12
				L_02d4: ldloc.s V_12
				L_02d6: brfalse.s L_02df
				L_02d8: ldloc.s V_12
				L_02da: callvirt System.IDisposable::Void Dispose()
				L_02df: endfinally 
				L_02e0: leave.s L_02ee
				L_02e2: ldloc.s V_5
				L_02e4: brfalse.s L_02ed
				L_02e6: ldloc.s V_5
				L_02e8: callvirt System.IDisposable::Void Dispose()
				L_02ed: endfinally 
				L_02ee: ldloc.3 
				L_02ef: ldloc.s V_4
				L_02f1: ldc.i4.0 
				L_02f2: ldc.i4.0 
				L_02f3: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_02f8: leave.s L_0306
				L_02fa: ldloc.s V_4
				L_02fc: brfalse.s L_0305
				L_02fe: ldloc.s V_4
				L_0300: callvirt System.IDisposable::Void Dispose()
				L_0305: endfinally 
				L_0306: ldarg.0 
				L_0307: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_030c: ldloc.1 
				L_030d: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_0312: pop 
				L_0313: leave.s L_031f
				L_0315: ldloc.3 
				L_0316: brfalse.s L_031e
				L_0318: ldloc.3 
				L_0319: callvirt System.IDisposable::Void Dispose()
				L_031e: endfinally 
				L_031f: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				if (((base.xcd9cdf30888d2204.ClientRectangle.Width <= 0) || (base.xcd9cdf30888d2204.ClientRectangle.Height <= 0)) || (! base.xf2140268ef7ddbf7))
				{
					return;
				}
				ToolBar toolBar1 = ((ToolBar) base.xcd9cdf30888d2204);
				IntPtr intPtr1 = x61467fe65a98f20c.GetWindowDC (base.Handle);
				Bitmap bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_TOOLBAR;
				using (Graphics graphics1 = Graphics.FromHwnd (base.Handle))
				{
					using (Bitmap bitmap2 = new Bitmap (toolBar1.Width, toolBar1.Height))
					{
						using (Graphics graphics2 = Graphics.FromImage (((Image) bitmap2)))
						{
							if (bitmap1 != null)
							{
								graphics2.DrawImage (((Image) bitmap1), new Rectangle (0, 0, toolBar1.Width, toolBar1.Height), 0, 0, bitmap1.Width, bitmap1.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x349935d524988797);
							}
							else
							{
								using (LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush (new Rectangle (0, 0, toolBar1.Width, toolBar1.Height), ((SkinColors) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Colors).SKIN2_TOOLBARSTARTCOLOR, ((SkinColors) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Colors).SKIN2_TOOLBARENDCOLOR, LinearGradientMode.Vertical))
								{
									graphics2.FillRectangle (((Brush) linearGradientBrush1), 0, 0, toolBar1.Width, toolBar1.Height);
								}
							}
							foreach (ToolBarButton toolBarButton1 in toolBar1.Buttons)
							{
								if (toolBarButton1.Visible)
								{
									rectangle1 = toolBarButton1.Rectangle;
									if (toolBarButton1.Style == ToolBarButtonStyle.Separator)
									{
										this.xa8d12864a9092939 (graphics2, rectangle1, toolBarButton1);
									}
									else
									{
										if (toolBarButton1.Style != ToolBarButtonStyle.ToggleButton)
										{
											switch (base.xdd938462da9aed37)
											{
												case xb9506a535e31f22a.x38f64d20b794f1fc:
												
												{
														if (! x448fd9ab43628c71.x9466a6be27202526 (toolBar1.PointToClient (Control.MousePosition), rectangle1))
														{
															this.xb30ec7cfdf3e5c19 (graphics2, rectangle1, toolBarButton1);
															continue;
														}
														this.x721082aab66b93c4 (graphics2, rectangle1, toolBarButton1);
														continue;
												}
												case xb9506a535e31f22a.x51fcce5a95fca000:
												
												{
														if (! x448fd9ab43628c71.x9466a6be27202526 (toolBar1.PointToClient (Control.MousePosition), rectangle1))
														{
															this.xb30ec7cfdf3e5c19 (graphics2, rectangle1, toolBarButton1);
															continue;
														}
														this.xa8337c38d02b5c00 (graphics2, rectangle1, toolBarButton1);
														continue;
												}
											}
											this.xb30ec7cfdf3e5c19 (graphics2, rectangle1, toolBarButton1);
											continue;
										}
										if (! toolBarButton1.Pushed)
										{
											if (base.xdd938462da9aed37 != xb9506a535e31f22a.x38f64d20b794f1fc)
											{
												if (base.xdd938462da9aed37 != xb9506a535e31f22a.x51fcce5a95fca000)
												{
													this.xb30ec7cfdf3e5c19 (graphics2, rectangle1, toolBarButton1);
													continue;
												}
												if (! x448fd9ab43628c71.x9466a6be27202526 (toolBar1.PointToClient (Control.MousePosition), rectangle1))
												{
													this.xb30ec7cfdf3e5c19 (graphics2, rectangle1, toolBarButton1);
													continue;
												}
												this.xa8337c38d02b5c00 (graphics2, rectangle1, toolBarButton1);
												continue;
											}
											if (! x448fd9ab43628c71.x9466a6be27202526 (toolBar1.PointToClient (Control.MousePosition), rectangle1))
											{
												this.xb30ec7cfdf3e5c19 (graphics2, rectangle1, toolBarButton1);
												continue;
											}
											this.x721082aab66b93c4 (graphics2, rectangle1, toolBarButton1);
											continue;
										}
										this.xa8337c38d02b5c00 (graphics2, rectangle1, toolBarButton1);
										continue;
									}
								}
							}
						}
						graphics1.DrawImageUnscaled (((Image) bitmap2), 0, 0);
					}
					int i1 = x61467fe65a98f20c.ReleaseDC (base.Handle, intPtr1);
				}
			}
			
			private void x721082aab66b93c4 (Graphics x4b101060f4767186, Rectangle xb55b340ae3a3e4e0, ToolBarButton x128517d7ded59312)
			
			/*
				// Code Size: 119 Bytes
				.maxstack 10
				L_0000: ldarg.3 
				L_0001: callvirt System.Windows.Forms.ToolBarButton::System.Windows.Forms.ToolBarButtonStyle get_Style()
				L_0006: ldc.i4.4 
				L_0007: bne.un.s L_0040
				L_0009: ldarg.0 
				L_000a: ldarg.1 
				L_000b: ldarg.2 
				L_000c: ldarg.0 
				L_000d: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0012: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0017: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_001c: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOOLBARONCOLOR()
				L_0021: ldarg.0 
				L_0022: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0027: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_002c: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0031: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOOLBARDOWNCOLOR()
				L_0036: ldc.i4.1 
				L_0037: ldc.i4.1 
				L_0038: ldc.i4.1 
				L_0039: ldarg.3 
				L_003a: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xc05dfbfc3f35bad9(System.Drawing.Graphics, System.Drawing.Rectangle, System.Drawing.Brush, System.Drawing.Brush, Boolean, Boolean, Boolean, System.Windows.Forms.ToolBarButton)
				L_003f: ret 
				L_0040: ldarg.0 
				L_0041: ldarg.1 
				L_0042: ldarg.2 
				L_0043: ldarg.0 
				L_0044: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0049: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_004e: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0053: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOOLBARONCOLOR()
				L_0058: ldarg.0 
				L_0059: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_005e: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0063: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0068: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOOLBARDOWNCOLOR()
				L_006d: ldc.i4.1 
				L_006e: ldc.i4.0 
				L_006f: ldc.i4.1 
				L_0070: ldarg.3 
				L_0071: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xc05dfbfc3f35bad9(System.Drawing.Graphics, System.Drawing.Rectangle, System.Drawing.Brush, System.Drawing.Brush, Boolean, Boolean, Boolean, System.Windows.Forms.ToolBarButton)
				L_0076: ret 
			*/
			
			
			{
				if (x128517d7ded59312.Style == ToolBarButtonStyle.DropDownButton)
				{
					this.xc05dfbfc3f35bad9 (x4b101060f4767186, xb55b340ae3a3e4e0, ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOOLBARONCOLOR, ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOOLBARDOWNCOLOR, true, true, true, x128517d7ded59312);
				}
				else
				{
					this.xc05dfbfc3f35bad9 (x4b101060f4767186, xb55b340ae3a3e4e0, ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOOLBARONCOLOR, ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOOLBARDOWNCOLOR, true, false, true, x128517d7ded59312);
				}
			}
			
			private void x7f302ba563726f8f (object xe0292b9ed559da7d, ToolBarButtonClickEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 104 Bytes
				.maxstack 4
				.locals (Sunisoft.IrisSkin.xa1883d0b59b7005b V_0)
				L_0000: ldarg.2 
				L_0001: callvirt System.Windows.Forms.ToolBarButtonClickEventArgs::System.Windows.Forms.ToolBarButton get_Button()
				L_0006: callvirt System.Windows.Forms.ToolBarButton::System.Windows.Forms.Menu get_DropDownMenu()
				L_000b: brfalse.s L_0067
				L_000d: ldarg.0 
				L_000e: ldfld Sunisoft.IrisSkin.xac9a4b8f6325d7e3::System.Collections.Hashtable x6d04a76446187b96
				L_0013: ldarg.2 
				L_0014: callvirt System.Windows.Forms.ToolBarButtonClickEventArgs::System.Windows.Forms.ToolBarButton get_Button()
				L_0019: callvirt System.Windows.Forms.ToolBarButton::System.Windows.Forms.Menu get_DropDownMenu()
				L_001e: callvirt System.Windows.Forms.Menu::IntPtr get_Handle()
				L_0023: box System.IntPtr
				L_0028: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_002d: brtrue.s L_0067
				L_002f: ldarg.0 
				L_0030: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0035: ldarg.2 
				L_0036: callvirt System.Windows.Forms.ToolBarButtonClickEventArgs::System.Windows.Forms.ToolBarButton get_Button()
				L_003b: callvirt System.Windows.Forms.ToolBarButton::System.Windows.Forms.Menu get_DropDownMenu()
				L_0040: newobj Sunisoft.IrisSkin.xa1883d0b59b7005b::Void .ctor(Sunisoft.IrisSkin.SkinEngine, System.Windows.Forms.Menu)
				L_0045: stloc.0 
				L_0046: ldarg.0 
				L_0047: ldfld Sunisoft.IrisSkin.xac9a4b8f6325d7e3::System.Collections.Hashtable x6d04a76446187b96
				L_004c: ldarg.2 
				L_004d: callvirt System.Windows.Forms.ToolBarButtonClickEventArgs::System.Windows.Forms.ToolBarButton get_Button()
				L_0052: callvirt System.Windows.Forms.ToolBarButton::System.Windows.Forms.Menu get_DropDownMenu()
				L_0057: callvirt System.Windows.Forms.Menu::IntPtr get_Handle()
				L_005c: box System.IntPtr
				L_0061: ldloc.0 
				L_0062: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_0067: ret 
			*/
			
			
			{
				if ((xfbf34718e704c6bc.Button.DropDownMenu == null) || this.x6d04a76446187b96.ContainsKey (xfbf34718e704c6bc.Button.DropDownMenu.Handle))
				{
					return;
				}
				xa1883d0b59b7005b xa1883d0b59b7005b1 = new xa1883d0b59b7005b (base.xdc87e2b99332cd4a, xfbf34718e704c6bc.Button.DropDownMenu);
				this.x6d04a76446187b96.Add (xfbf34718e704c6bc.Button.DropDownMenu.Handle, xa1883d0b59b7005b1);
			}
			
			private void x92735afcf18b3c70 (object xe0292b9ed559da7d, MouseEventArgs xfbf34718e704c6bc)
			
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
			
			private void xa8337c38d02b5c00 (Graphics x4b101060f4767186, Rectangle xb55b340ae3a3e4e0, ToolBarButton x128517d7ded59312)
			
			/*
				// Code Size: 119 Bytes
				.maxstack 10
				L_0000: ldarg.3 
				L_0001: callvirt System.Windows.Forms.ToolBarButton::System.Windows.Forms.ToolBarButtonStyle get_Style()
				L_0006: ldc.i4.4 
				L_0007: bne.un.s L_0040
				L_0009: ldarg.0 
				L_000a: ldarg.1 
				L_000b: ldarg.2 
				L_000c: ldarg.0 
				L_000d: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0012: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0017: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_001c: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOOLBARDOWNCOLOR()
				L_0021: ldarg.0 
				L_0022: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0027: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_002c: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0031: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOOLBARDOWNCOLOR()
				L_0036: ldc.i4.1 
				L_0037: ldc.i4.1 
				L_0038: ldc.i4.1 
				L_0039: ldarg.3 
				L_003a: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xc05dfbfc3f35bad9(System.Drawing.Graphics, System.Drawing.Rectangle, System.Drawing.Brush, System.Drawing.Brush, Boolean, Boolean, Boolean, System.Windows.Forms.ToolBarButton)
				L_003f: ret 
				L_0040: ldarg.0 
				L_0041: ldarg.1 
				L_0042: ldarg.2 
				L_0043: ldarg.0 
				L_0044: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0049: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_004e: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0053: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOOLBARDOWNCOLOR()
				L_0058: ldarg.0 
				L_0059: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_005e: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0063: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0068: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOOLBARDOWNCOLOR()
				L_006d: ldc.i4.1 
				L_006e: ldc.i4.0 
				L_006f: ldc.i4.1 
				L_0070: ldarg.3 
				L_0071: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xc05dfbfc3f35bad9(System.Drawing.Graphics, System.Drawing.Rectangle, System.Drawing.Brush, System.Drawing.Brush, Boolean, Boolean, Boolean, System.Windows.Forms.ToolBarButton)
				L_0076: ret 
			*/
			
			
			{
				if (x128517d7ded59312.Style == ToolBarButtonStyle.DropDownButton)
				{
					this.xc05dfbfc3f35bad9 (x4b101060f4767186, xb55b340ae3a3e4e0, ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOOLBARDOWNCOLOR, ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOOLBARDOWNCOLOR, true, true, true, x128517d7ded59312);
				}
				else
				{
					this.xc05dfbfc3f35bad9 (x4b101060f4767186, xb55b340ae3a3e4e0, ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOOLBARDOWNCOLOR, ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOOLBARDOWNCOLOR, true, false, true, x128517d7ded59312);
				}
			}
			
			private void xa8d12864a9092939 (Graphics x4b101060f4767186, Rectangle xb55b340ae3a3e4e0, ToolBarButton x128517d7ded59312)
			
			/*
				// Code Size: 105 Bytes
				.maxstack 5
				.locals (System.Drawing.Point V_0, 
         System.Drawing.Point V_1, 
         System.Drawing.Pen V_2)
				.try L_0053 to L_005e finally L_005e to L_0068
				L_0000: ldloca.s V_0
				L_0002: ldarga.s xb55b340ae3a3e4e0
				L_0004: call System.Drawing.Rectangle::Int32 get_X()
				L_0009: ldarga.s xb55b340ae3a3e4e0
				L_000b: call System.Drawing.Rectangle::Int32 get_Width()
				L_0010: ldc.i4.2 
				L_0011: div 
				L_0012: add 
				L_0013: ldarga.s xb55b340ae3a3e4e0
				L_0015: call System.Drawing.Rectangle::Int32 get_Top()
				L_001a: ldc.i4.1 
				L_001b: add 
				L_001c: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0021: ldloca.s V_1
				L_0023: ldarga.s xb55b340ae3a3e4e0
				L_0025: call System.Drawing.Rectangle::Int32 get_X()
				L_002a: ldarga.s xb55b340ae3a3e4e0
				L_002c: call System.Drawing.Rectangle::Int32 get_Width()
				L_0031: ldc.i4.2 
				L_0032: div 
				L_0033: add 
				L_0034: ldarga.s xb55b340ae3a3e4e0
				L_0036: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_003b: ldc.i4.1 
				L_003c: sub 
				L_003d: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0042: ldc.i4.6 
				L_0043: call System.Drawing.Color::System.Drawing.Color FromKnownColor(System.Drawing.KnownColor)
				L_0048: ldc.r4 1
				L_004d: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color, Single)
				L_0052: stloc.2 
				L_0053: ldarg.1 
				L_0054: ldloc.2 
				L_0055: ldloc.0 
				L_0056: ldloc.1 
				L_0057: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, System.Drawing.Point, System.Drawing.Point)
				L_005c: leave.s L_0068
				L_005e: ldloc.2 
				L_005f: brfalse.s L_0067
				L_0061: ldloc.2 
				L_0062: callvirt System.IDisposable::Void Dispose()
				L_0067: endfinally 
				L_0068: ret 
			*/
			
			
			{
				Point point1;
				Point point2;
				point1 = new Point (((int) (xb55b340ae3a3e4e0.X + (xb55b340ae3a3e4e0.Width / 2))), ((int) (xb55b340ae3a3e4e0.Top + 1)));
				point2 = new Point (((int) (xb55b340ae3a3e4e0.X + (xb55b340ae3a3e4e0.Width / 2))), ((int) (xb55b340ae3a3e4e0.Bottom - 1)));
				using (Pen pen1 = new Pen (Color.FromKnownColor (KnownColor.ControlDark), 1F))
				{
					x4b101060f4767186.DrawLine (pen1, point1, point2);
				}
			}
			
			private void xb30ec7cfdf3e5c19 (Graphics x4b101060f4767186, Rectangle xb55b340ae3a3e4e0, ToolBarButton x128517d7ded59312)
			
			/*
				// Code Size: 39 Bytes
				.maxstack 10
				L_0000: ldarg.3 
				L_0001: callvirt System.Windows.Forms.ToolBarButton::System.Windows.Forms.ToolBarButtonStyle get_Style()
				L_0006: ldc.i4.4 
				L_0007: bne.un.s L_0018
				L_0009: ldarg.0 
				L_000a: ldarg.1 
				L_000b: ldarg.2 
				L_000c: ldnull 
				L_000d: ldnull 
				L_000e: ldc.i4.0 
				L_000f: ldc.i4.1 
				L_0010: ldc.i4.0 
				L_0011: ldarg.3 
				L_0012: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xc05dfbfc3f35bad9(System.Drawing.Graphics, System.Drawing.Rectangle, System.Drawing.Brush, System.Drawing.Brush, Boolean, Boolean, Boolean, System.Windows.Forms.ToolBarButton)
				L_0017: ret 
				L_0018: ldarg.0 
				L_0019: ldarg.1 
				L_001a: ldarg.2 
				L_001b: ldnull 
				L_001c: ldnull 
				L_001d: ldc.i4.0 
				L_001e: ldc.i4.0 
				L_001f: ldc.i4.0 
				L_0020: ldarg.3 
				L_0021: call Sunisoft.IrisSkin.xac9a4b8f6325d7e3::Void xc05dfbfc3f35bad9(System.Drawing.Graphics, System.Drawing.Rectangle, System.Drawing.Brush, System.Drawing.Brush, Boolean, Boolean, Boolean, System.Windows.Forms.ToolBarButton)
				L_0026: ret 
			*/
			
			
			{
				if (x128517d7ded59312.Style == ToolBarButtonStyle.DropDownButton)
				{
					this.xc05dfbfc3f35bad9 (x4b101060f4767186, xb55b340ae3a3e4e0, ((Brush) null), ((Brush) null), false, true, false, x128517d7ded59312);
				}
				else
				{
					this.xc05dfbfc3f35bad9 (x4b101060f4767186, xb55b340ae3a3e4e0, ((Brush) null), ((Brush) null), false, false, false, x128517d7ded59312);
				}
			}
			
			private void xc05dfbfc3f35bad9 (Graphics x4b101060f4767186, Rectangle xb55b340ae3a3e4e0, Brush x4a36d7ee5781ce75, Brush x35feaa6e77973c81, bool x96554d34fd74b02c, bool xb223465a379c4c80, bool x5afff747d2706456, ToolBarButton x128517d7ded59312)
			
			/*
				// Code Size: 1196 Bytes
				.maxstack 8
				.locals (System.Drawing.Rectangle V_0, 
         System.Drawing.Rectangle V_1, 
         System.Windows.Forms.ToolBar V_2, 
         System.Drawing.Image V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Drawing.Pen V_6, 
         System.Drawing.Brush V_7, 
         System.Drawing.Pen V_8, 
         System.Drawing.Size V_9)
				.try L_00d8 to L_0102 finally L_0102 to L_010e
				.try L_0442 to L_046c finally L_046c to L_0478
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.ToolBar
				L_000b: stloc.2 
				L_000c: ldnull 
				L_000d: stloc.3 
				L_000e: ldc.i4.0 
				L_000f: stloc.s V_4
				L_0011: ldc.i4.0 
				L_0012: stloc.s V_5
				L_0014: ldloc.2 
				L_0015: callvirt System.Windows.Forms.ToolBar::System.Windows.Forms.ImageList get_ImageList()
				L_001a: brfalse.s L_0085
				L_001c: ldloc.2 
				L_001d: callvirt System.Windows.Forms.ToolBar::System.Windows.Forms.ImageList get_ImageList()
				L_0022: callvirt System.Windows.Forms.ImageList::System.Drawing.Size get_ImageSize()
				L_0027: stloc.s V_9
				L_0029: ldloca.s V_9
				L_002b: call System.Drawing.Size::Int32 get_Width()
				L_0030: stloc.s V_4
				L_0032: ldloc.2 
				L_0033: callvirt System.Windows.Forms.ToolBar::System.Windows.Forms.ImageList get_ImageList()
				L_0038: callvirt System.Windows.Forms.ImageList::System.Drawing.Size get_ImageSize()
				L_003d: stloc.s V_9
				L_003f: ldloca.s V_9
				L_0041: call System.Drawing.Size::Int32 get_Height()
				L_0046: stloc.s V_5
				L_0048: ldloc.2 
				L_0049: callvirt System.Windows.Forms.ToolBar::System.Windows.Forms.ImageList get_ImageList()
				L_004e: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_0053: callvirt System.Windows.Forms.ImageList+ImageCollection::Int32 get_Count()
				L_0058: ldarg.s x128517d7ded59312
				L_005a: callvirt System.Windows.Forms.ToolBarButton::Int32 get_ImageIndex()
				L_005f: ldc.i4.1 
				L_0060: add 
				L_0061: blt.s L_0085
				L_0063: ldarg.s x128517d7ded59312
				L_0065: callvirt System.Windows.Forms.ToolBarButton::Int32 get_ImageIndex()
				L_006a: ldc.i4.m1 
				L_006b: beq.s L_0085
				L_006d: ldloc.2 
				L_006e: callvirt System.Windows.Forms.ToolBar::System.Windows.Forms.ImageList get_ImageList()
				L_0073: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_0078: ldarg.s x128517d7ded59312
				L_007a: callvirt System.Windows.Forms.ToolBarButton::Int32 get_ImageIndex()
				L_007f: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_0084: stloc.3 
				L_0085: ldarg.s x96554d34fd74b02c
				L_0087: brfalse.s L_009a
				L_0089: ldarg.s x128517d7ded59312
				L_008b: callvirt System.Windows.Forms.ToolBarButton::Boolean get_Enabled()
				L_0090: brfalse.s L_009a
				L_0092: ldarg.1 
				L_0093: ldarg.3 
				L_0094: ldarg.2 
				L_0095: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_009a: ldarg.s x128517d7ded59312
				L_009c: callvirt System.Windows.Forms.ToolBarButton::Boolean get_PartialPush()
				L_00a1: brfalse.s L_00af
				L_00a3: ldarg.1 
				L_00a4: call System.Drawing.Brushes::System.Drawing.Brush get_WhiteSmoke()
				L_00a9: ldarg.2 
				L_00aa: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_00af: ldarg.s x5afff747d2706456
				L_00b1: brfalse.s L_010e
				L_00b3: ldarg.s x128517d7ded59312
				L_00b5: callvirt System.Windows.Forms.ToolBarButton::Boolean get_Enabled()
				L_00ba: brfalse.s L_010e
				L_00bc: ldarg.0 
				L_00bd: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00c2: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00c7: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_00cc: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TOOLBARBORDERCOLOR
				L_00d1: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_00d6: stloc.s V_6
				L_00d8: ldarg.1 
				L_00d9: ldloc.s V_6
				L_00db: ldarga.s xb55b340ae3a3e4e0
				L_00dd: call System.Drawing.Rectangle::Int32 get_X()
				L_00e2: ldarga.s xb55b340ae3a3e4e0
				L_00e4: call System.Drawing.Rectangle::Int32 get_Y()
				L_00e9: ldarga.s xb55b340ae3a3e4e0
				L_00eb: call System.Drawing.Rectangle::Int32 get_Width()
				L_00f0: ldc.i4.2 
				L_00f1: sub 
				L_00f2: ldarga.s xb55b340ae3a3e4e0
				L_00f4: call System.Drawing.Rectangle::Int32 get_Height()
				L_00f9: ldc.i4.2 
				L_00fa: sub 
				L_00fb: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0100: leave.s L_010e
				L_0102: ldloc.s V_6
				L_0104: brfalse.s L_010d
				L_0106: ldloc.s V_6
				L_0108: callvirt System.IDisposable::Void Dispose()
				L_010d: endfinally 
				L_010e: ldloc.3 
				L_010f: brfalse L_025b
				L_0114: ldloc.2 
				L_0115: callvirt System.Windows.Forms.ToolBar::System.Windows.Forms.ToolBarTextAlign get_TextAlign()
				L_011a: ldc.i4.1 
				L_011b: bne.un L_01c3
				L_0120: ldarg.s x128517d7ded59312
				L_0122: callvirt System.Windows.Forms.ToolBarButton::Boolean get_Enabled()
				L_0127: brfalse.s L_0156
				L_0129: ldarg.1 
				L_012a: ldloc.3 
				L_012b: ldc.i4.2 
				L_012c: ldarga.s xb55b340ae3a3e4e0
				L_012e: call System.Drawing.Rectangle::Int32 get_X()
				L_0133: add 
				L_0134: ldarga.s xb55b340ae3a3e4e0
				L_0136: call System.Drawing.Rectangle::Int32 get_Y()
				L_013b: ldarga.s xb55b340ae3a3e4e0
				L_013d: call System.Drawing.Rectangle::Int32 get_Height()
				L_0142: ldloc.3 
				L_0143: callvirt System.Drawing.Image::Int32 get_Height()
				L_0148: sub 
				L_0149: ldc.i4.2 
				L_014a: div 
				L_014b: add 
				L_014c: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_0151: br L_025b
				L_0156: ldarg.s x128517d7ded59312
				L_0158: callvirt System.Windows.Forms.ToolBarButton::Boolean get_PartialPush()
				L_015d: brfalse.s L_0191
				L_015f: ldarg.1 
				L_0160: ldloc.3 
				L_0161: ldc.i4.2 
				L_0162: ldarga.s xb55b340ae3a3e4e0
				L_0164: call System.Drawing.Rectangle::Int32 get_X()
				L_0169: add 
				L_016a: ldarga.s xb55b340ae3a3e4e0
				L_016c: call System.Drawing.Rectangle::Int32 get_Y()
				L_0171: ldarga.s xb55b340ae3a3e4e0
				L_0173: call System.Drawing.Rectangle::Int32 get_Height()
				L_0178: ldloc.3 
				L_0179: callvirt System.Drawing.Image::Int32 get_Height()
				L_017e: sub 
				L_017f: ldc.i4.2 
				L_0180: div 
				L_0181: add 
				L_0182: call System.Drawing.Color::System.Drawing.Color get_WhiteSmoke()
				L_0187: call System.Windows.Forms.ControlPaint::Void DrawImageDisabled(System.Drawing.Graphics, System.Drawing.Image, Int32, Int32, System.Drawing.Color)
				L_018c: br L_025b
				L_0191: ldarg.1 
				L_0192: ldloc.3 
				L_0193: ldc.i4.2 
				L_0194: ldarga.s xb55b340ae3a3e4e0
				L_0196: call System.Drawing.Rectangle::Int32 get_X()
				L_019b: add 
				L_019c: ldarga.s xb55b340ae3a3e4e0
				L_019e: call System.Drawing.Rectangle::Int32 get_Y()
				L_01a3: ldarga.s xb55b340ae3a3e4e0
				L_01a5: call System.Drawing.Rectangle::Int32 get_Height()
				L_01aa: ldloc.3 
				L_01ab: callvirt System.Drawing.Image::Int32 get_Height()
				L_01b0: sub 
				L_01b1: ldc.i4.2 
				L_01b2: div 
				L_01b3: add 
				L_01b4: call System.Drawing.Color::System.Drawing.Color get_Gray()
				L_01b9: call System.Windows.Forms.ControlPaint::Void DrawImageDisabled(System.Drawing.Graphics, System.Drawing.Image, Int32, Int32, System.Drawing.Color)
				L_01be: br L_025b
				L_01c3: ldarg.s x128517d7ded59312
				L_01c5: callvirt System.Windows.Forms.ToolBarButton::Boolean get_Enabled()
				L_01ca: brfalse.s L_01f6
				L_01cc: ldarg.1 
				L_01cd: ldloc.3 
				L_01ce: ldarga.s xb55b340ae3a3e4e0
				L_01d0: call System.Drawing.Rectangle::Int32 get_X()
				L_01d5: ldarga.s xb55b340ae3a3e4e0
				L_01d7: call System.Drawing.Rectangle::Int32 get_Width()
				L_01dc: ldloc.3 
				L_01dd: callvirt System.Drawing.Image::Int32 get_Width()
				L_01e2: sub 
				L_01e3: ldc.i4.2 
				L_01e4: div 
				L_01e5: add 
				L_01e6: ldc.i4.2 
				L_01e7: ldarga.s xb55b340ae3a3e4e0
				L_01e9: call System.Drawing.Rectangle::Int32 get_Y()
				L_01ee: add 
				L_01ef: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_01f4: br.s L_025b
				L_01f6: ldarg.s x128517d7ded59312
				L_01f8: callvirt System.Windows.Forms.ToolBarButton::Boolean get_PartialPush()
				L_01fd: brfalse.s L_022e
				L_01ff: ldarg.1 
				L_0200: ldloc.3 
				L_0201: ldarga.s xb55b340ae3a3e4e0
				L_0203: call System.Drawing.Rectangle::Int32 get_X()
				L_0208: ldarga.s xb55b340ae3a3e4e0
				L_020a: call System.Drawing.Rectangle::Int32 get_Width()
				L_020f: ldloc.3 
				L_0210: callvirt System.Drawing.Image::Int32 get_Width()
				L_0215: sub 
				L_0216: ldc.i4.2 
				L_0217: div 
				L_0218: add 
				L_0219: ldc.i4.2 
				L_021a: ldarga.s xb55b340ae3a3e4e0
				L_021c: call System.Drawing.Rectangle::Int32 get_Y()
				L_0221: add 
				L_0222: call System.Drawing.Color::System.Drawing.Color get_WhiteSmoke()
				L_0227: call System.Windows.Forms.ControlPaint::Void DrawImageDisabled(System.Drawing.Graphics, System.Drawing.Image, Int32, Int32, System.Drawing.Color)
				L_022c: br.s L_025b
				L_022e: ldarg.1 
				L_022f: ldloc.3 
				L_0230: ldarga.s xb55b340ae3a3e4e0
				L_0232: call System.Drawing.Rectangle::Int32 get_X()
				L_0237: ldarga.s xb55b340ae3a3e4e0
				L_0239: call System.Drawing.Rectangle::Int32 get_Width()
				L_023e: ldloc.3 
				L_023f: callvirt System.Drawing.Image::Int32 get_Width()
				L_0244: sub 
				L_0245: ldc.i4.2 
				L_0246: div 
				L_0247: add 
				L_0248: ldc.i4.2 
				L_0249: ldarga.s xb55b340ae3a3e4e0
				L_024b: call System.Drawing.Rectangle::Int32 get_Y()
				L_0250: add 
				L_0251: call System.Drawing.Color::System.Drawing.Color get_Gray()
				L_0256: call System.Windows.Forms.ControlPaint::Void DrawImageDisabled(System.Drawing.Graphics, System.Drawing.Image, Int32, Int32, System.Drawing.Color)
				L_025b: ldarg.s x128517d7ded59312
				L_025d: callvirt System.Windows.Forms.ToolBarButton::System.String get_Text()
				L_0262: brfalse L_03ad
				L_0267: ldarg.s x128517d7ded59312
				L_0269: callvirt System.Windows.Forms.ToolBarButton::System.String get_Text()
				L_026e: ldstr ""
				L_0273: call System.String::Boolean op_Inequality(System.String, System.String)
				L_0278: brfalse L_03ad
				L_027d: ldloc.2 
				L_027e: callvirt System.Windows.Forms.ToolBar::System.Windows.Forms.ToolBarTextAlign get_TextAlign()
				L_0283: ldc.i4.1 
				L_0284: bne.un.s L_02f0
				L_0286: ldarg.s x128517d7ded59312
				L_0288: callvirt System.Windows.Forms.ToolBarButton::System.Windows.Forms.ToolBarButtonStyle get_Style()
				L_028d: ldc.i4.4 
				L_028e: beq.s L_02c0
				L_0290: ldarga.s xb55b340ae3a3e4e0
				L_0292: call System.Drawing.Rectangle::Int32 get_X()
				L_0297: ldloc.s V_4
				L_0299: add 
				L_029a: ldc.i4.2 
				L_029b: add 
				L_029c: ldc.i4.1 
				L_029d: add 
				L_029e: ldarga.s xb55b340ae3a3e4e0
				L_02a0: call System.Drawing.Rectangle::Int32 get_Y()
				L_02a5: ldarga.s xb55b340ae3a3e4e0
				L_02a7: call System.Drawing.Rectangle::Int32 get_Right()
				L_02ac: ldc.i4.1 
				L_02ad: sub 
				L_02ae: ldarga.s xb55b340ae3a3e4e0
				L_02b0: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_02b5: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_02ba: stloc.0 
				L_02bb: br L_0353
				L_02c0: ldarga.s xb55b340ae3a3e4e0
				L_02c2: call System.Drawing.Rectangle::Int32 get_X()
				L_02c7: ldloc.s V_4
				L_02c9: add 
				L_02ca: ldc.i4.2 
				L_02cb: add 
				L_02cc: ldc.i4.1 
				L_02cd: add 
				L_02ce: ldarga.s xb55b340ae3a3e4e0
				L_02d0: call System.Drawing.Rectangle::Int32 get_Y()
				L_02d5: ldarga.s xb55b340ae3a3e4e0
				L_02d7: call System.Drawing.Rectangle::Int32 get_Right()
				L_02dc: ldc.i4.1 
				L_02dd: sub 
				L_02de: ldc.i4.s 13
				L_02e0: sub 
				L_02e1: ldarga.s xb55b340ae3a3e4e0
				L_02e3: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_02e8: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_02ed: stloc.0 
				L_02ee: br.s L_0353
				L_02f0: ldarg.s x128517d7ded59312
				L_02f2: callvirt System.Windows.Forms.ToolBarButton::System.Windows.Forms.ToolBarButtonStyle get_Style()
				L_02f7: ldc.i4.4 
				L_02f8: beq.s L_0325
				L_02fa: ldarga.s xb55b340ae3a3e4e0
				L_02fc: call System.Drawing.Rectangle::Int32 get_X()
				L_0301: ldarga.s xb55b340ae3a3e4e0
				L_0303: call System.Drawing.Rectangle::Int32 get_Y()
				L_0308: ldloc.s V_5
				L_030a: add 
				L_030b: ldc.i4.2 
				L_030c: add 
				L_030d: ldc.i4.1 
				L_030e: add 
				L_030f: ldarga.s xb55b340ae3a3e4e0
				L_0311: call System.Drawing.Rectangle::Int32 get_Right()
				L_0316: ldarga.s xb55b340ae3a3e4e0
				L_0318: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_031d: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0322: stloc.0 
				L_0323: br.s L_0353
				L_0325: ldarga.s xb55b340ae3a3e4e0
				L_0327: call System.Drawing.Rectangle::Int32 get_X()
				L_032c: ldarga.s xb55b340ae3a3e4e0
				L_032e: call System.Drawing.Rectangle::Int32 get_Y()
				L_0333: ldloc.s V_5
				L_0335: add 
				L_0336: ldc.i4.2 
				L_0337: add 
				L_0338: ldc.i4.1 
				L_0339: add 
				L_033a: ldarga.s xb55b340ae3a3e4e0
				L_033c: call System.Drawing.Rectangle::Int32 get_Right()
				L_0341: ldc.i4.1 
				L_0342: sub 
				L_0343: ldc.i4.s 13
				L_0345: sub 
				L_0346: ldarga.s xb55b340ae3a3e4e0
				L_0348: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_034d: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0352: stloc.0 
				L_0353: ldarg.s x128517d7ded59312
				L_0355: callvirt System.Windows.Forms.ToolBarButton::Boolean get_Enabled()
				L_035a: brfalse.s L_038a
				L_035c: ldarg.s x128517d7ded59312
				L_035e: callvirt System.Windows.Forms.ToolBarButton::Boolean get_PartialPush()
				L_0363: brtrue.s L_038a
				L_0365: ldarg.1 
				L_0366: ldarg.s x128517d7ded59312
				L_0368: callvirt System.Windows.Forms.ToolBarButton::System.String get_Text()
				L_036d: ldloc.2 
				L_036e: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_0373: call System.Drawing.Brushes::System.Drawing.Brush get_Black()
				L_0378: ldloc.0 
				L_0379: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_037e: ldsfld Sunisoft.IrisSkin.xac9a4b8f6325d7e3::System.Drawing.StringFormat xae3b2752a89e7464
				L_0383: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_0388: br.s L_03ad
				L_038a: ldarg.1 
				L_038b: ldarg.s x128517d7ded59312
				L_038d: callvirt System.Windows.Forms.ToolBarButton::System.String get_Text()
				L_0392: ldloc.2 
				L_0393: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_0398: call System.Drawing.Brushes::System.Drawing.Brush get_Gray()
				L_039d: ldloc.0 
				L_039e: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_03a3: ldsfld Sunisoft.IrisSkin.xac9a4b8f6325d7e3::System.Drawing.StringFormat xae3b2752a89e7464
				L_03a8: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_03ad: ldarg.s xb223465a379c4c80
				L_03af: brfalse L_04ab
				L_03b4: ldarga.s xb55b340ae3a3e4e0
				L_03b6: call System.Drawing.Rectangle::Int32 get_Right()
				L_03bb: ldc.i4.s 13
				L_03bd: sub 
				L_03be: ldarga.s xb55b340ae3a3e4e0
				L_03c0: call System.Drawing.Rectangle::Int32 get_Y()
				L_03c5: ldarga.s xb55b340ae3a3e4e0
				L_03c7: call System.Drawing.Rectangle::Int32 get_Right()
				L_03cc: ldarga.s xb55b340ae3a3e4e0
				L_03ce: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_03d3: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_03d8: stloc.1 
				L_03d9: ldarg.s x96554d34fd74b02c
				L_03db: brfalse.s L_0410
				L_03dd: ldarg.s x128517d7ded59312
				L_03df: callvirt System.Windows.Forms.ToolBarButton::Boolean get_Enabled()
				L_03e4: brfalse.s L_0410
				L_03e6: ldarg.1 
				L_03e7: ldarg.s x35feaa6e77973c81
				L_03e9: ldloca.s V_1
				L_03eb: call System.Drawing.Rectangle::Int32 get_X()
				L_03f0: ldloca.s V_1
				L_03f2: call System.Drawing.Rectangle::Int32 get_Y()
				L_03f7: ldc.i4.1 
				L_03f8: add 
				L_03f9: ldloca.s V_1
				L_03fb: call System.Drawing.Rectangle::Int32 get_Width()
				L_0400: ldc.i4.1 
				L_0401: sub 
				L_0402: ldloca.s V_1
				L_0404: call System.Drawing.Rectangle::Int32 get_Height()
				L_0409: ldc.i4.2 
				L_040a: sub 
				L_040b: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_0410: ldarg.0 
				L_0411: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0416: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_041b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0420: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOOLBARBORDERCOLOR()
				L_0425: stloc.s V_7
				L_0427: ldarg.s x96554d34fd74b02c
				L_0429: brfalse.s L_0478
				L_042b: ldarg.s x128517d7ded59312
				L_042d: callvirt System.Windows.Forms.ToolBarButton::Boolean get_Enabled()
				L_0432: brfalse.s L_0478
				L_0434: ldloc.s V_7
				L_0436: ldc.r4 1
				L_043b: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush, Single)
				L_0440: stloc.s V_8
				L_0442: ldarg.1 
				L_0443: ldloc.s V_8
				L_0445: ldloca.s V_1
				L_0447: call System.Drawing.Rectangle::Int32 get_X()
				L_044c: ldloca.s V_1
				L_044e: call System.Drawing.Rectangle::Int32 get_Y()
				L_0453: ldloca.s V_1
				L_0455: call System.Drawing.Rectangle::Int32 get_Width()
				L_045a: ldc.i4.2 
				L_045b: sub 
				L_045c: ldloca.s V_1
				L_045e: call System.Drawing.Rectangle::Int32 get_Height()
				L_0463: ldc.i4.2 
				L_0464: sub 
				L_0465: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_046a: leave.s L_0478
				L_046c: ldloc.s V_8
				L_046e: brfalse.s L_0477
				L_0470: ldloc.s V_8
				L_0472: callvirt System.IDisposable::Void Dispose()
				L_0477: endfinally 
				L_0478: ldarg.1 
				L_0479: ldloca.s V_1
				L_047b: call System.Drawing.Rectangle::Int32 get_X()
				L_0480: ldloca.s V_1
				L_0482: call System.Drawing.Rectangle::Int32 get_Width()
				L_0487: ldc.i4.2 
				L_0488: div 
				L_0489: add 
				L_048a: ldc.i4.4 
				L_048b: sub 
				L_048c: ldloca.s V_1
				L_048e: call System.Drawing.Rectangle::Int32 get_Y()
				L_0493: ldloca.s V_1
				L_0495: call System.Drawing.Rectangle::Int32 get_Height()
				L_049a: ldc.i4.2 
				L_049b: div 
				L_049c: add 
				L_049d: ldc.i4.2 
				L_049e: sub 
				L_049f: ldarg.s x128517d7ded59312
				L_04a1: callvirt System.Windows.Forms.ToolBarButton::Boolean get_Enabled()
				L_04a6: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x3fbffc8bcd27b3c0(System.Drawing.Graphics, Int32, Int32, Boolean)
				L_04ab: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Size size1;
				ToolBar toolBar1 = ((ToolBar) base.xcd9cdf30888d2204);
				Image image1 = ((Image) null);
				int i1 = 0;
				int i2 = 0;
				if (toolBar1.ImageList != null)
				{
					size1 = toolBar1.ImageList.ImageSize;
					i1 = size1.Width;
					size1 = toolBar1.ImageList.ImageSize;
					i2 = size1.Height;
					if ((toolBar1.ImageList.Images.Count >= (x128517d7ded59312.ImageIndex + 1)) && (x128517d7ded59312.ImageIndex != -1))
					{
						image1 = toolBar1.ImageList.Images[x128517d7ded59312.ImageIndex];
					}
				}
				if (x96554d34fd74b02c && x128517d7ded59312.Enabled)
				{
					x4b101060f4767186.FillRectangle (x4a36d7ee5781ce75, xb55b340ae3a3e4e0);
				}
				if (x128517d7ded59312.PartialPush)
				{
					x4b101060f4767186.FillRectangle (Brushes.WhiteSmoke, xb55b340ae3a3e4e0);
				}
				if (x5afff747d2706456 && x128517d7ded59312.Enabled)
				{
					using (Pen pen1 = new Pen (((SkinColors) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Colors).SKIN2_TOOLBARBORDERCOLOR))
					{
						x4b101060f4767186.DrawRectangle (pen1, xb55b340ae3a3e4e0.X, xb55b340ae3a3e4e0.Y, ((int) (xb55b340ae3a3e4e0.Width - 2)), ((int) (xb55b340ae3a3e4e0.Height - 2)));
					}
				}
				if (image1 != null)
				{
					if (toolBar1.TextAlign != ToolBarTextAlign.Right)
					{
						if (x128517d7ded59312.Enabled)
						{
							x4b101060f4767186.DrawImageUnscaled (image1, ((int) (xb55b340ae3a3e4e0.X + ((xb55b340ae3a3e4e0.Width - image1.Width) / 2))), ((int) (2 + xb55b340ae3a3e4e0.Y)));
						}
						else if (! x128517d7ded59312.PartialPush)
						{
							ControlPaint.DrawImageDisabled (x4b101060f4767186, image1, ((int) (xb55b340ae3a3e4e0.X + ((xb55b340ae3a3e4e0.Width - image1.Width) / 2))), ((int) (2 + xb55b340ae3a3e4e0.Y)), Color.Gray);
						}
						else
						{
							ControlPaint.DrawImageDisabled (x4b101060f4767186, image1, ((int) (xb55b340ae3a3e4e0.X + ((xb55b340ae3a3e4e0.Width - image1.Width) / 2))), ((int) (2 + xb55b340ae3a3e4e0.Y)), Color.WhiteSmoke);
						}
					}
					else if (x128517d7ded59312.Enabled)
					{
						x4b101060f4767186.DrawImageUnscaled (image1, ((int) (2 + xb55b340ae3a3e4e0.X)), ((int) (xb55b340ae3a3e4e0.Y + ((xb55b340ae3a3e4e0.Height - image1.Height) / 2))));
					}
					else if (! x128517d7ded59312.PartialPush)
					{
						ControlPaint.DrawImageDisabled (x4b101060f4767186, image1, ((int) (2 + xb55b340ae3a3e4e0.X)), ((int) (xb55b340ae3a3e4e0.Y + ((xb55b340ae3a3e4e0.Height - image1.Height) / 2))), Color.Gray);
					}
					else
					{
						ControlPaint.DrawImageDisabled (x4b101060f4767186, image1, ((int) (2 + xb55b340ae3a3e4e0.X)), ((int) (xb55b340ae3a3e4e0.Y + ((xb55b340ae3a3e4e0.Height - image1.Height) / 2))), Color.WhiteSmoke);
					}
				}
				if ((x128517d7ded59312.Text != null) && (x128517d7ded59312.Text != ""))
				{
					if (toolBar1.TextAlign == ToolBarTextAlign.Right)
					{
						if (x128517d7ded59312.Style != ToolBarButtonStyle.DropDownButton)
						{
							rectangle1 = Rectangle.FromLTRB (((int) (((xb55b340ae3a3e4e0.X + i1) + 2) + 1)), xb55b340ae3a3e4e0.Y, ((int) (xb55b340ae3a3e4e0.Right - 1)), xb55b340ae3a3e4e0.Bottom);
						}
						else
						{
							rectangle1 = Rectangle.FromLTRB (((int) (((xb55b340ae3a3e4e0.X + i1) + 2) + 1)), xb55b340ae3a3e4e0.Y, ((int) ((xb55b340ae3a3e4e0.Right - 1) - 13)), xb55b340ae3a3e4e0.Bottom);
						}
					}
					else if (x128517d7ded59312.Style != ToolBarButtonStyle.DropDownButton)
					{
						rectangle1 = Rectangle.FromLTRB (xb55b340ae3a3e4e0.X, ((int) (((xb55b340ae3a3e4e0.Y + i2) + 2) + 1)), xb55b340ae3a3e4e0.Right, xb55b340ae3a3e4e0.Bottom);
					}
					else
					{
						rectangle1 = Rectangle.FromLTRB (xb55b340ae3a3e4e0.X, ((int) (((xb55b340ae3a3e4e0.Y + i2) + 2) + 1)), ((int) ((xb55b340ae3a3e4e0.Right - 1) - 13)), xb55b340ae3a3e4e0.Bottom);
					}
					if (x128517d7ded59312.Enabled && (! x128517d7ded59312.PartialPush))
					{
						x4b101060f4767186.DrawString (x128517d7ded59312.Text, toolBar1.Font, Brushes.Black, ((RectangleF) rectangle1), xac9a4b8f6325d7e3.xae3b2752a89e7464);
					}
					else
					{
						x4b101060f4767186.DrawString (x128517d7ded59312.Text, toolBar1.Font, Brushes.Gray, ((RectangleF) rectangle1), xac9a4b8f6325d7e3.xae3b2752a89e7464);
					}
				}
				if (! xb223465a379c4c80)
				{
					return;
				}
				Rectangle rectangle2 = Rectangle.FromLTRB (((int) (xb55b340ae3a3e4e0.Right - 13)), xb55b340ae3a3e4e0.Y, xb55b340ae3a3e4e0.Right, xb55b340ae3a3e4e0.Bottom);
				if (x96554d34fd74b02c && x128517d7ded59312.Enabled)
				{
					x4b101060f4767186.FillRectangle (x35feaa6e77973c81, rectangle2.X, ((int) (rectangle2.Y + 1)), ((int) (rectangle2.Width - 1)), ((int) (rectangle2.Height - 2)));
				}
				Brush brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOOLBARBORDERCOLOR;
				if (x96554d34fd74b02c && x128517d7ded59312.Enabled)
				{
					using (Pen pen2 = new Pen (brush1, 1F))
					{
						x4b101060f4767186.DrawRectangle (pen2, rectangle2.X, rectangle2.Y, ((int) (rectangle2.Width - 2)), ((int) (rectangle2.Height - 2)));
					}
				}
				x448fd9ab43628c71.x3fbffc8bcd27b3c0 (x4b101060f4767186, ((int) ((rectangle2.X + (rectangle2.Width / 2)) - 4)), ((int) ((rectangle2.Y + (rectangle2.Height / 2)) - 2)), x128517d7ded59312.Enabled);
			}
			
		#endregion
	}
	
}

