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
			using System.Drawing.Imaging;
			using System.Drawing.Text;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class x97d171718e5c7e7f : x8917d01b98173f4c
	
	{
		
		#region Constructors
		
			public x97d171718e5c7e7f (Control control, ISkinEngine engine)
				 : base (control, engine)
			/*
				// Code Size: 68 Bytes
				.maxstack 4
				.locals (System.UInt32 V_0)
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.x8917d01b98173f4c::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ldarg.0 
				L_0009: call Sunisoft.IrisSkin.x97d171718e5c7e7f::Boolean get_x0e7ffd184973f9bc()
				L_000e: brfalse.s L_0043
				L_0010: ldarg.0 
				L_0011: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0016: ldc.i4.s -20
				L_0018: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
				L_001d: stloc.0 
				L_001e: ldloc.0 
				L_001f: ldc.i4 4194304
				L_0024: and 
				L_0025: ldc.i4 4194304
				L_002a: bne.un.s L_0034
				L_002c: ldloc.0 
				L_002d: ldc.i4 4194304
				L_0032: sub 
				L_0033: stloc.0 
				L_0034: ldarg.0 
				L_0035: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_003a: ldc.i4.s -20
				L_003c: ldloc.0 
				L_003d: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 SetWindowLong(IntPtr, Int32, UInt32)
				L_0042: pop 
				L_0043: ret 
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
			
			
			private bool x0e7ffd184973f9bc
			
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
		
			protected override bool BeforeWndProc (ref Message m)
			
			/*
				// Code Size: 74 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT V_0, 
         System.UInt32 V_1)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0006: stloc.1 
				L_0007: ldloc.1 
				L_0008: ldc.i4.s 15
				L_000a: bne.un.s L_0042
				L_000c: ldloca.s V_0
				L_000e: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT
				L_0014: ldarg.0 
				L_0015: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001a: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_001f: ldloca.s V_0
				L_0021: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr BeginPaint(IntPtr, PAINTSTRUCT ByRef)
				L_0026: pop 
				L_0027: ldarg.0 
				L_0028: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_002d: ldarg.0 
				L_002e: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0033: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0038: ldloca.s V_0
				L_003a: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean EndPaint(IntPtr, PAINTSTRUCT ByRef)
				L_003f: pop 
				L_0040: ldc.i4.0 
				L_0041: ret 
				L_0042: ldarg.0 
				L_0043: ldarg.1 
				L_0044: call Sunisoft.IrisSkin.x8917d01b98173f4c::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_0049: ret 
			*/
			
			
			{
				if (((uint) m.Msg) != 15)
				{
					return base.BeforeWndProc (ref m);
				}
				x40255b11ef821fa3.PAINTSTRUCT pAINTSTRUCT1 = new x40255b11ef821fa3.PAINTSTRUCT ();
				IntPtr intPtr1 = x61467fe65a98f20c.BeginPaint (base.xcd9cdf30888d2204.Handle, out pAINTSTRUCT1);
				this.PaintControl ();
				bool b1 = x61467fe65a98f20c.EndPaint (base.xcd9cdf30888d2204.Handle, ref pAINTSTRUCT1);
				return false;
			}
			
			protected override void OnCurrentSkinChanged (object sender, ISkinChangedEventArgs e)
			
			/*
				// Code Size: 122 Bytes
				.maxstack 4
				.locals (System.UInt32 V_0, 
         System.UInt32 V_1)
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Void OnCurrentSkinChanged(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_0008: ldarg.0 
				L_0009: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_000e: brtrue.s L_003e
				L_0010: ldarg.0 
				L_0011: call Sunisoft.IrisSkin.x97d171718e5c7e7f::Boolean get_x0e7ffd184973f9bc()
				L_0016: brfalse.s L_0079
				L_0018: ldarg.0 
				L_0019: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_001e: ldc.i4.s -20
				L_0020: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
				L_0025: stloc.0 
				L_0026: ldloc.0 
				L_0027: ldc.i4 4194304
				L_002c: and 
				L_002d: stloc.0 
				L_002e: ldarg.0 
				L_002f: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0034: ldc.i4.s -20
				L_0036: ldloc.0 
				L_0037: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 SetWindowLong(IntPtr, Int32, UInt32)
				L_003c: pop 
				L_003d: ret 
				L_003e: ldarg.0 
				L_003f: call Sunisoft.IrisSkin.x97d171718e5c7e7f::Boolean get_x0e7ffd184973f9bc()
				L_0044: brfalse.s L_0079
				L_0046: ldarg.0 
				L_0047: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_004c: ldc.i4.s -20
				L_004e: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 GetWindowLong(IntPtr, Int32)
				L_0053: stloc.1 
				L_0054: ldloc.1 
				L_0055: ldc.i4 4194304
				L_005a: and 
				L_005b: ldc.i4 4194304
				L_0060: bne.un.s L_006a
				L_0062: ldloc.1 
				L_0063: ldc.i4 4194304
				L_0068: sub 
				L_0069: stloc.1 
				L_006a: ldarg.0 
				L_006b: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0070: ldc.i4.s -20
				L_0072: ldloc.1 
				L_0073: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt32 SetWindowLong(IntPtr, Int32, UInt32)
				L_0078: pop 
				L_0079: ret 
			*/
			
			
			{
				uint uInt32_1;
				base.OnCurrentSkinChanged (sender, e);
				if (! base.xf2140268ef7ddbf7)
				{
					if (this.x0e7ffd184973f9bc)
					{
						uInt32_1 = x61467fe65a98f20c.GetWindowLong (base.Handle, -20);
						uInt32_1 = ((uint) (((int) uInt32_1) & 4194304));
						uint uInt32_3 = x61467fe65a98f20c.SetWindowLong (base.Handle, -20, uInt32_1);
					}
					return;
				}
				if (! this.x0e7ffd184973f9bc)
				{
					return;
				}
				uint uInt32_2 = x61467fe65a98f20c.GetWindowLong (base.Handle, -20);
				if ((((int) uInt32_2) & 4194304) == 4194304)
				{
					uInt32_2 = ((uint) (((int) uInt32_2) - 4194304));
				}
				uint uInt32_4 = x61467fe65a98f20c.SetWindowLong (base.Handle, -20, uInt32_2);
			}
			
			protected override void PaintControl ()
			
			/*
				// Code Size: 197 Bytes
				.maxstack 5
				.locals (System.Drawing.Bitmap V_0, 
         System.Drawing.Graphics V_1, 
         System.Drawing.Graphics V_2, 
         System.Drawing.Graphics V_3, 
         System.Drawing.Rectangle V_4)
				.try L_005b to L_0064 finally L_0064 to L_006e
				.try L_0084 to L_008d finally L_008d to L_0097
				.try L_00a3 to L_00ae finally L_00ae to L_00b8
				.try L_0054 to L_00ba finally L_00ba to L_00c4
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_000b: stloc.s V_4
				L_000d: ldloca.s V_4
				L_000f: call System.Drawing.Rectangle::Int32 get_Width()
				L_0014: ldc.i4.0 
				L_0015: ble.s L_002e
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001d: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0022: stloc.s V_4
				L_0024: ldloca.s V_4
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
				L_003e: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0043: ldarg.0 
				L_0044: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0049: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_004e: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0053: stloc.0 
				L_0054: ldloc.0 
				L_0055: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_005a: stloc.1 
				L_005b: ldarg.0 
				L_005c: ldloc.1 
				L_005d: call Sunisoft.IrisSkin.x97d171718e5c7e7f::Void x8bc95f030953f87b(System.Drawing.Graphics)
				L_0062: leave.s L_006e
				L_0064: ldloc.1 
				L_0065: brfalse.s L_006d
				L_0067: ldloc.1 
				L_0068: callvirt System.IDisposable::Void Dispose()
				L_006d: endfinally 
				L_006e: ldarg.0 
				L_006f: call Sunisoft.IrisSkin.x97d171718e5c7e7f::Boolean get_x0e7ffd184973f9bc()
				L_0074: brfalse.s L_007d
				L_0076: ldloc.0 
				L_0077: ldc.i4.4 
				L_0078: callvirt System.Drawing.Image::Void RotateFlip(System.Drawing.RotateFlipType)
				L_007d: ldloc.0 
				L_007e: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0083: stloc.2 
				L_0084: ldarg.0 
				L_0085: ldloc.2 
				L_0086: call Sunisoft.IrisSkin.x97d171718e5c7e7f::Void x3bf72114458d67b7(System.Drawing.Graphics)
				L_008b: leave.s L_0097
				L_008d: ldloc.2 
				L_008e: brfalse.s L_0096
				L_0090: ldloc.2 
				L_0091: callvirt System.IDisposable::Void Dispose()
				L_0096: endfinally 
				L_0097: ldarg.0 
				L_0098: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_009d: call System.Drawing.Graphics::System.Drawing.Graphics FromHwnd(IntPtr)
				L_00a2: stloc.3 
				L_00a3: ldloc.3 
				L_00a4: ldloc.0 
				L_00a5: ldc.i4.0 
				L_00a6: ldc.i4.0 
				L_00a7: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_00ac: leave.s L_00b8
				L_00ae: ldloc.3 
				L_00af: brfalse.s L_00b7
				L_00b1: ldloc.3 
				L_00b2: callvirt System.IDisposable::Void Dispose()
				L_00b7: endfinally 
				L_00b8: leave.s L_00c4
				L_00ba: ldloc.0 
				L_00bb: brfalse.s L_00c3
				L_00bd: ldloc.0 
				L_00be: callvirt System.IDisposable::Void Dispose()
				L_00c3: endfinally 
				L_00c4: ret 
			*/
			
			
			{
				if (((base.xcd9cdf30888d2204.ClientRectangle.Width > 0) && (base.xcd9cdf30888d2204.ClientRectangle.Height > 0)) && base.xf2140268ef7ddbf7)
				{
					using (Bitmap bitmap1 = new Bitmap (base.xcd9cdf30888d2204.Width, base.xcd9cdf30888d2204.Height))
					{
						using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap1)))
						{
							this.x8bc95f030953f87b (graphics1);
						}
						if (this.x0e7ffd184973f9bc)
						{
							bitmap1.RotateFlip (RotateFlipType.RotateNoneFlipX);
						}
						using (Graphics graphics2 = Graphics.FromImage (((Image) bitmap1)))
						{
							this.x3bf72114458d67b7 (graphics2);
						}
						using (Graphics graphics3 = Graphics.FromHwnd (base.Handle))
						{
							graphics3.DrawImageUnscaled (((Image) bitmap1), 0, 0);
						}
					}
				}
			}
			
			private void x3bf72114458d67b7 (Graphics x41347a961b838962)
			
			/*
				// Code Size: 1112 Bytes
				.maxstack 7
				.locals (System.Windows.Forms.TabControl V_0, 
         System.Drawing.StringFormat V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Bitmap V_3, 
         System.Int32 V_4, 
         System.Drawing.Image V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         System.Drawing.Brush V_9, 
         System.Windows.Forms.TabAlignment V_10)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.TabControl
				L_000b: stloc.0 
				L_000c: newobj System.Drawing.StringFormat::Void .ctor()
				L_0011: stloc.1 
				L_0012: ldloc.1 
				L_0013: ldc.i4 4096
				L_0018: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_001d: ldloc.1 
				L_001e: ldc.i4.0 
				L_001f: callvirt System.Drawing.StringFormat::Void set_HotkeyPrefix(System.Drawing.Text.HotkeyPrefix)
				L_0024: ldloc.1 
				L_0025: ldc.i4.1 
				L_0026: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_002b: ldloc.1 
				L_002c: ldc.i4.1 
				L_002d: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_0032: ldarg.0 
				L_0033: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0038: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_003d: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.TabControlRes get_TabControlRes()
				L_0042: callvirt Sunisoft.IrisSkin.TabControlRes::System.Drawing.Bitmap get_TabLine()
				L_0047: stloc.3 
				L_0048: ldloc.3 
				L_0049: callvirt System.Drawing.Image::Int32 get_Height()
				L_004e: stloc.s V_4
				L_0050: ldloc.0 
				L_0051: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0056: stloc.s V_6
				L_0058: ldc.i4.0 
				L_0059: stloc.s V_7
				L_005b: br L_0445
				L_0060: ldnull 
				L_0061: stloc.s V_5
				L_0063: ldloc.0 
				L_0064: callvirt System.Windows.Forms.TabControl::System.Windows.Forms.ImageList get_ImageList()
				L_0069: brfalse L_00f4
				L_006e: ldloc.0 
				L_006f: callvirt System.Windows.Forms.TabControl::TabPageCollection get_TabPages()
				L_0074: brfalse L_00f4
				L_0079: ldloc.0 
				L_007a: callvirt System.Windows.Forms.TabControl::TabPageCollection get_TabPages()
				L_007f: callvirt System.Windows.Forms.TabControl+TabPageCollection::Int32 get_Count()
				L_0084: ldloc.s V_7
				L_0086: ble.s L_00f4
				L_0088: ldloc.0 
				L_0089: callvirt System.Windows.Forms.TabControl::TabPageCollection get_TabPages()
				L_008e: ldloc.s V_7
				L_0090: callvirt System.Windows.Forms.TabControl+TabPageCollection::System.Windows.Forms.TabPage get_Item(Int32)
				L_0095: brfalse.s L_00f4
				L_0097: ldloc.0 
				L_0098: callvirt System.Windows.Forms.TabControl::TabPageCollection get_TabPages()
				L_009d: ldloc.s V_7
				L_009f: callvirt System.Windows.Forms.TabControl+TabPageCollection::System.Windows.Forms.TabPage get_Item(Int32)
				L_00a4: callvirt System.Windows.Forms.TabPage::Int32 get_ImageIndex()
				L_00a9: ldc.i4.0 
				L_00aa: blt.s L_00f4
				L_00ac: ldloc.0 
				L_00ad: callvirt System.Windows.Forms.TabControl::System.Windows.Forms.ImageList get_ImageList()
				L_00b2: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_00b7: callvirt System.Windows.Forms.ImageList+ImageCollection::Int32 get_Count()
				L_00bc: ldloc.0 
				L_00bd: callvirt System.Windows.Forms.TabControl::TabPageCollection get_TabPages()
				L_00c2: ldloc.s V_7
				L_00c4: callvirt System.Windows.Forms.TabControl+TabPageCollection::System.Windows.Forms.TabPage get_Item(Int32)
				L_00c9: callvirt System.Windows.Forms.TabPage::Int32 get_ImageIndex()
				L_00ce: ble.s L_00f4
				L_00d0: ldloc.0 
				L_00d1: callvirt System.Windows.Forms.TabControl::System.Windows.Forms.ImageList get_ImageList()
				L_00d6: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_00db: ldloc.0 
				L_00dc: callvirt System.Windows.Forms.TabControl::TabPageCollection get_TabPages()
				L_00e1: ldloc.s V_7
				L_00e3: callvirt System.Windows.Forms.TabControl+TabPageCollection::System.Windows.Forms.TabPage get_Item(Int32)
				L_00e8: callvirt System.Windows.Forms.TabPage::Int32 get_ImageIndex()
				L_00ed: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_00f2: stloc.s V_5
				L_00f4: ldloc.0 
				L_00f5: ldloc.s V_7
				L_00f7: callvirt System.Windows.Forms.TabControl::System.Drawing.Rectangle GetTabRect(Int32)
				L_00fc: stloc.2 
				L_00fd: ldc.i4.1 
				L_00fe: stloc.s V_8
				L_0100: ldloc.0 
				L_0101: callvirt System.Windows.Forms.TabControl::System.Windows.Forms.TabAlignment get_Alignment()
				L_0106: stloc.s V_10
				L_0108: ldloc.s V_10
				L_010a: switch (L_011f, L_01be, L_0255, L_02f4)
				L_011f: ldloca.s V_2
				L_0121: dup 
				L_0122: call System.Drawing.Rectangle::Int32 get_Y()
				L_0127: ldloc.s V_8
				L_0129: add 
				L_012a: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_012f: ldloca.s V_2
				L_0131: dup 
				L_0132: call System.Drawing.Rectangle::Int32 get_Height()
				L_0137: ldloc.s V_4
				L_0139: sub 
				L_013a: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_013f: ldloc.s V_5
				L_0141: brfalse L_03b2
				L_0146: ldarg.0 
				L_0147: call Sunisoft.IrisSkin.x97d171718e5c7e7f::Boolean get_x0e7ffd184973f9bc()
				L_014c: brfalse.s L_0173
				L_014e: ldarg.1 
				L_014f: ldloc.s V_5
				L_0151: ldloc.s V_6
				L_0153: ldloc.s V_5
				L_0155: callvirt System.Drawing.Image::Int32 get_Width()
				L_015a: sub 
				L_015b: ldloca.s V_2
				L_015d: call System.Drawing.Rectangle::Int32 get_X()
				L_0162: ldc.i4.2 
				L_0163: add 
				L_0164: sub 
				L_0165: ldloca.s V_2
				L_0167: call System.Drawing.Rectangle::Int32 get_Y()
				L_016c: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_0171: br.s L_018b
				L_0173: ldarg.1 
				L_0174: ldloc.s V_5
				L_0176: ldloca.s V_2
				L_0178: call System.Drawing.Rectangle::Int32 get_X()
				L_017d: ldc.i4.2 
				L_017e: add 
				L_017f: ldloca.s V_2
				L_0181: call System.Drawing.Rectangle::Int32 get_Y()
				L_0186: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_018b: ldloca.s V_2
				L_018d: dup 
				L_018e: call System.Drawing.Rectangle::Int32 get_X()
				L_0193: ldloc.s V_5
				L_0195: callvirt System.Drawing.Image::Int32 get_Width()
				L_019a: ldc.i4.3 
				L_019b: add 
				L_019c: add 
				L_019d: call System.Drawing.Rectangle::Void set_X(Int32)
				L_01a2: ldloca.s V_2
				L_01a4: dup 
				L_01a5: call System.Drawing.Rectangle::Int32 get_Width()
				L_01aa: ldloc.s V_5
				L_01ac: callvirt System.Drawing.Image::Int32 get_Width()
				L_01b1: ldc.i4.3 
				L_01b2: add 
				L_01b3: sub 
				L_01b4: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_01b9: br L_03b2
				L_01be: ldloca.s V_2
				L_01c0: dup 
				L_01c1: call System.Drawing.Rectangle::Int32 get_Y()
				L_01c6: ldloc.s V_4
				L_01c8: add 
				L_01c9: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_01ce: ldloca.s V_2
				L_01d0: dup 
				L_01d1: call System.Drawing.Rectangle::Int32 get_Height()
				L_01d6: ldloc.s V_4
				L_01d8: sub 
				L_01d9: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_01de: ldloc.s V_5
				L_01e0: brfalse L_03b2
				L_01e5: ldarg.0 
				L_01e6: call Sunisoft.IrisSkin.x97d171718e5c7e7f::Boolean get_x0e7ffd184973f9bc()
				L_01eb: brfalse.s L_0210
				L_01ed: ldarg.1 
				L_01ee: ldloc.s V_5
				L_01f0: ldloc.s V_6
				L_01f2: ldloc.s V_5
				L_01f4: callvirt System.Drawing.Image::Int32 get_Width()
				L_01f9: sub 
				L_01fa: ldloca.s V_2
				L_01fc: call System.Drawing.Rectangle::Int32 get_X()
				L_0201: sub 
				L_0202: ldloca.s V_2
				L_0204: call System.Drawing.Rectangle::Int32 get_Y()
				L_0209: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_020e: br.s L_0226
				L_0210: ldarg.1 
				L_0211: ldloc.s V_5
				L_0213: ldloca.s V_2
				L_0215: call System.Drawing.Rectangle::Int32 get_X()
				L_021a: ldloca.s V_2
				L_021c: call System.Drawing.Rectangle::Int32 get_Y()
				L_0221: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_0226: ldloca.s V_2
				L_0228: dup 
				L_0229: call System.Drawing.Rectangle::Int32 get_X()
				L_022e: ldloc.s V_5
				L_0230: callvirt System.Drawing.Image::Int32 get_Width()
				L_0235: add 
				L_0236: call System.Drawing.Rectangle::Void set_X(Int32)
				L_023b: ldloca.s V_2
				L_023d: dup 
				L_023e: call System.Drawing.Rectangle::Int32 get_Width()
				L_0243: ldloc.s V_5
				L_0245: callvirt System.Drawing.Image::Int32 get_Width()
				L_024a: sub 
				L_024b: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0250: br L_03b2
				L_0255: ldloca.s V_2
				L_0257: dup 
				L_0258: call System.Drawing.Rectangle::Int32 get_X()
				L_025d: ldloc.s V_8
				L_025f: add 
				L_0260: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0265: ldloc.1 
				L_0266: ldc.i4.2 
				L_0267: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_026c: ldloca.s V_2
				L_026e: dup 
				L_026f: call System.Drawing.Rectangle::Int32 get_Width()
				L_0274: ldloc.s V_4
				L_0276: sub 
				L_0277: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_027c: ldloc.s V_5
				L_027e: brfalse L_03b2
				L_0283: ldarg.0 
				L_0284: call Sunisoft.IrisSkin.x97d171718e5c7e7f::Boolean get_x0e7ffd184973f9bc()
				L_0289: brfalse.s L_02b8
				L_028b: ldarg.1 
				L_028c: ldloc.s V_5
				L_028e: ldloc.s V_6
				L_0290: ldloc.s V_5
				L_0292: callvirt System.Drawing.Image::Int32 get_Width()
				L_0297: sub 
				L_0298: ldloca.s V_2
				L_029a: call System.Drawing.Rectangle::Int32 get_X()
				L_029f: sub 
				L_02a0: ldloca.s V_2
				L_02a2: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_02a7: ldloc.s V_5
				L_02a9: callvirt System.Drawing.Image::Int32 get_Height()
				L_02ae: sub 
				L_02af: ldc.i4.3 
				L_02b0: sub 
				L_02b1: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_02b6: br.s L_02d8
				L_02b8: ldarg.1 
				L_02b9: ldloc.s V_5
				L_02bb: ldloca.s V_2
				L_02bd: call System.Drawing.Rectangle::Int32 get_X()
				L_02c2: ldloca.s V_2
				L_02c4: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_02c9: ldloc.s V_5
				L_02cb: callvirt System.Drawing.Image::Int32 get_Height()
				L_02d0: sub 
				L_02d1: ldc.i4.3 
				L_02d2: sub 
				L_02d3: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_02d8: ldloca.s V_2
				L_02da: dup 
				L_02db: call System.Drawing.Rectangle::Int32 get_Height()
				L_02e0: ldloc.s V_5
				L_02e2: callvirt System.Drawing.Image::Int32 get_Height()
				L_02e7: ldc.i4.3 
				L_02e8: add 
				L_02e9: sub 
				L_02ea: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_02ef: br L_03b2
				L_02f4: ldloca.s V_2
				L_02f6: dup 
				L_02f7: call System.Drawing.Rectangle::Int32 get_X()
				L_02fc: ldloc.s V_8
				L_02fe: sub 
				L_02ff: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0304: ldloca.s V_2
				L_0306: dup 
				L_0307: call System.Drawing.Rectangle::Int32 get_X()
				L_030c: ldloc.s V_4
				L_030e: add 
				L_030f: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0314: ldloca.s V_2
				L_0316: dup 
				L_0317: call System.Drawing.Rectangle::Int32 get_Width()
				L_031c: ldloc.s V_4
				L_031e: sub 
				L_031f: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0324: ldloc.1 
				L_0325: ldc.i4.2 
				L_0326: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_032b: ldloca.s V_2
				L_032d: dup 
				L_032e: call System.Drawing.Rectangle::Int32 get_Width()
				L_0333: ldloc.s V_4
				L_0335: sub 
				L_0336: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_033b: ldloc.s V_5
				L_033d: brfalse.s L_03b2
				L_033f: ldarg.0 
				L_0340: call Sunisoft.IrisSkin.x97d171718e5c7e7f::Boolean get_x0e7ffd184973f9bc()
				L_0345: brfalse.s L_036c
				L_0347: ldarg.1 
				L_0348: ldloc.s V_5
				L_034a: ldloc.s V_6
				L_034c: ldloc.s V_5
				L_034e: callvirt System.Drawing.Image::Int32 get_Width()
				L_0353: sub 
				L_0354: ldloca.s V_2
				L_0356: call System.Drawing.Rectangle::Int32 get_X()
				L_035b: sub 
				L_035c: ldloca.s V_2
				L_035e: call System.Drawing.Rectangle::Int32 get_Y()
				L_0363: ldc.i4.3 
				L_0364: add 
				L_0365: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_036a: br.s L_0384
				L_036c: ldarg.1 
				L_036d: ldloc.s V_5
				L_036f: ldloca.s V_2
				L_0371: call System.Drawing.Rectangle::Int32 get_X()
				L_0376: ldloca.s V_2
				L_0378: call System.Drawing.Rectangle::Int32 get_Y()
				L_037d: ldc.i4.3 
				L_037e: add 
				L_037f: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_0384: ldloca.s V_2
				L_0386: dup 
				L_0387: call System.Drawing.Rectangle::Int32 get_Y()
				L_038c: ldloc.s V_5
				L_038e: callvirt System.Drawing.Image::Int32 get_Height()
				L_0393: ldc.i4.3 
				L_0394: add 
				L_0395: add 
				L_0396: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_039b: ldloca.s V_2
				L_039d: dup 
				L_039e: call System.Drawing.Rectangle::Int32 get_Height()
				L_03a3: ldloc.s V_5
				L_03a5: callvirt System.Drawing.Image::Int32 get_Height()
				L_03aa: ldc.i4.3 
				L_03ab: add 
				L_03ac: sub 
				L_03ad: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_03b2: ldloc.0 
				L_03b3: callvirt System.Windows.Forms.TabControl::Int32 get_SelectedIndex()
				L_03b8: ldloc.s V_7
				L_03ba: bne.un.s L_03d5
				L_03bc: ldarg.0 
				L_03bd: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_03c2: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_03c7: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_03cc: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TABCONTROLACTIVEFONTCOLOR()
				L_03d1: stloc.s V_9
				L_03d3: br.s L_03ec
				L_03d5: ldarg.0 
				L_03d6: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_03db: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_03e0: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_03e5: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TABCONTROLINACTIVEFONTCOLOR()
				L_03ea: stloc.s V_9
				L_03ec: ldarg.0 
				L_03ed: call Sunisoft.IrisSkin.x97d171718e5c7e7f::Boolean get_x0e7ffd184973f9bc()
				L_03f2: brfalse.s L_040d
				L_03f4: ldloca.s V_2
				L_03f6: ldloc.s V_6
				L_03f8: ldloca.s V_2
				L_03fa: call System.Drawing.Rectangle::Int32 get_X()
				L_03ff: sub 
				L_0400: ldloca.s V_2
				L_0402: call System.Drawing.Rectangle::Int32 get_Width()
				L_0407: sub 
				L_0408: call System.Drawing.Rectangle::Void set_X(Int32)
				L_040d: ldarg.1 
				L_040e: ldloc.0 
				L_040f: callvirt System.Windows.Forms.TabControl::TabPageCollection get_TabPages()
				L_0414: ldloc.s V_7
				L_0416: callvirt System.Windows.Forms.TabControl+TabPageCollection::System.Windows.Forms.TabPage get_Item(Int32)
				L_041b: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_0420: ldloc.0 
				L_0421: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_0426: ldloc.s V_9
				L_0428: ldloc.2 
				L_0429: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_042e: ldloc.1 
				L_042f: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_0434: ldloc.1 
				L_0435: ldc.i4 4096
				L_043a: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_043f: ldloc.s V_7
				L_0441: ldc.i4.1 
				L_0442: add 
				L_0443: stloc.s V_7
				L_0445: ldloc.s V_7
				L_0447: ldloc.0 
				L_0448: callvirt System.Windows.Forms.TabControl::TabPageCollection get_TabPages()
				L_044d: callvirt System.Windows.Forms.TabControl+TabPageCollection::Int32 get_Count()
				L_0452: blt L_0060
				L_0457: ret 
			*/
			
			
			{
				TabControl tabControl1;
				StringFormat stringFormat1;
				Rectangle rectangle1;
				Bitmap bitmap1;
				int i1;
				Image image1;
				int i2;
				int i3;
				int i4;
				Brush brush1;
				TabAlignment tabAlignment1;
				tabControl1 = ((TabControl) base.xcd9cdf30888d2204);
				stringFormat1 = new StringFormat ();
				stringFormat1.FormatFlags = StringFormatFlags.NoWrap;
				stringFormat1.HotkeyPrefix = HotkeyPrefix.None;
				stringFormat1.LineAlignment = StringAlignment.Center;
				stringFormat1.Alignment = StringAlignment.Center;
				bitmap1 = ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).TabControlRes.TabLine;
				i1 = bitmap1.Height;
				i2 = tabControl1.Width;
				i3 = 0;
				goto L_0445;
				
			L_0226:
				
				{
				}
				rectangle1.X += image1.Width;
				rectangle1.Width -= image1.Width;
				goto L_03B2;
				
			L_02D8:
				
				{
				}
				rectangle1.Height -= (image1.Height + 3);
				goto L_03B2;
				
			L_0384:
				
				{
				}
				rectangle1.Y += (image1.Height + 3);
				rectangle1.Height -= (image1.Height + 3);
				
			L_03B2:
				
				{
				}
				if (tabControl1.SelectedIndex == i3)
				{
					brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TABCONTROLACTIVEFONTCOLOR;
				}
				else
				{
					brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TABCONTROLINACTIVEFONTCOLOR;
				}
				if (this.x0e7ffd184973f9bc)
				{
					rectangle1.X = ((i2 - rectangle1.X) - rectangle1.Width);
				}
				x41347a961b838962.DrawString (tabControl1.TabPages[i3].Text, tabControl1.Font, brush1, ((RectangleF) rectangle1), stringFormat1);
				stringFormat1.FormatFlags = StringFormatFlags.NoWrap;
				i3++;
				
			L_0445:
				
				{
				}
				if (i3 >= tabControl1.TabPages.Count)
				{
					return;
				}
				image1 = ((Image) null);
				if ((((((tabControl1.ImageList != null) && (tabControl1.TabPages != null)) && (tabControl1.TabPages.Count > i3)) && (tabControl1.TabPages[i3] != null)) && (tabControl1.TabPages[i3].ImageIndex >= 0)) && (tabControl1.ImageList.Images.Count > tabControl1.TabPages[i3].ImageIndex))
				{
					image1 = tabControl1.ImageList.Images[tabControl1.TabPages[i3].ImageIndex];
				}
				rectangle1 = tabControl1.GetTabRect (i3);
				i4 = 1;
				tabAlignment1 = tabControl1.Alignment;
				switch (tabAlignment1)
				{
					case TabAlignment.Bottom:
					
					{
							rectangle1.Y += i1;
							rectangle1.Height -= i1;
							if (image1 == null)
							{
								goto L_03B2;
							}
							if (! this.x0e7ffd184973f9bc)
							{
								x41347a961b838962.DrawImageUnscaled (image1, rectangle1.X, rectangle1.Y);
								goto L_0226;
							}
							x41347a961b838962.DrawImageUnscaled (image1, ((int) ((i2 - image1.Width) - rectangle1.X)), rectangle1.Y);
							goto L_0226;
					}
					case TabAlignment.Left:
					
					{
							rectangle1.X += i4;
							stringFormat1.FormatFlags = StringFormatFlags.DirectionVertical;
							rectangle1.Width -= i1;
							if (image1 == null)
							{
								goto L_03B2;
							}
							if (! this.x0e7ffd184973f9bc)
							{
								x41347a961b838962.DrawImageUnscaled (image1, rectangle1.X, ((int) ((rectangle1.Bottom - image1.Height) - 3)));
								goto L_02D8;
							}
							x41347a961b838962.DrawImageUnscaled (image1, ((int) ((i2 - image1.Width) - rectangle1.X)), ((int) ((rectangle1.Bottom - image1.Height) - 3)));
							goto L_02D8;
					}
					case TabAlignment.Right:
					
					{
							rectangle1.X -= i4;
							rectangle1.X += i1;
							rectangle1.Width -= i1;
							stringFormat1.FormatFlags = StringFormatFlags.DirectionVertical;
							rectangle1.Width -= i1;
							if (image1 == null)
							{
								goto L_03B2;
							}
							if (! this.x0e7ffd184973f9bc)
							{
								x41347a961b838962.DrawImageUnscaled (image1, rectangle1.X, ((int) (rectangle1.Y + 3)));
								goto L_0384;
							}
							x41347a961b838962.DrawImageUnscaled (image1, ((int) ((i2 - image1.Width) - rectangle1.X)), ((int) (rectangle1.Y + 3)));
							goto L_0384;
					}
				}
				rectangle1.Y += i4;
				rectangle1.Height -= i1;
				if (image1 != null)
				{
					if (this.x0e7ffd184973f9bc)
					{
						x41347a961b838962.DrawImageUnscaled (image1, ((int) ((i2 - image1.Width) - (rectangle1.X + 2))), rectangle1.Y);
					}
					else
					{
						x41347a961b838962.DrawImageUnscaled (image1, ((int) (rectangle1.X + 2)), rectangle1.Y);
					}
					rectangle1.X += (image1.Width + 3);
					rectangle1.Width -= (image1.Width + 3);
				}
				goto L_03B2;
			}
			
			private void x8bc95f030953f87b (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 85 Bytes
				.maxstack 5
				.locals (System.Windows.Forms.TabControl V_0, 
         System.Drawing.Brush V_1, 
         System.Int32 V_2)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.TabControl
				L_000b: stloc.0 
				L_000c: ldarg.0 
				L_000d: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0012: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0017: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_001c: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_0021: stloc.1 
				L_0022: ldarg.1 
				L_0023: ldloc.1 
				L_0024: ldloc.0 
				L_0025: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_002a: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_002f: ldarg.0 
				L_0030: ldarg.1 
				L_0031: call Sunisoft.IrisSkin.x97d171718e5c7e7f::Void xa7a441e9d4de36b0(System.Drawing.Graphics)
				L_0036: ldc.i4.0 
				L_0037: stloc.2 
				L_0038: br.s L_0046
				L_003a: ldarg.0 
				L_003b: ldarg.1 
				L_003c: ldloc.2 
				L_003d: call Sunisoft.IrisSkin.x97d171718e5c7e7f::Void xc33f5f7a18a754cb(System.Drawing.Graphics, Int32)
				L_0042: ldloc.2 
				L_0043: ldc.i4.1 
				L_0044: add 
				L_0045: stloc.2 
				L_0046: ldloc.2 
				L_0047: ldloc.0 
				L_0048: callvirt System.Windows.Forms.TabControl::TabPageCollection get_TabPages()
				L_004d: callvirt System.Windows.Forms.TabControl+TabPageCollection::Int32 get_Count()
				L_0052: blt.s L_003a
				L_0054: ret 
			*/
			
			
			{
				int i1;
				TabControl tabControl1 = ((TabControl) base.xcd9cdf30888d2204);
				Brush brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR;
				x4b101060f4767186.FillRectangle (brush1, tabControl1.ClientRectangle);
				this.xa7a441e9d4de36b0 (x4b101060f4767186);
				for (i1 = 0; (i1 < tabControl1.TabPages.Count); i1++)
				{
					this.xc33f5f7a18a754cb (x4b101060f4767186, i1);
				}
			}
			
			private void xa7a441e9d4de36b0 (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 903 Bytes
				.maxstack 10
				.locals (System.Windows.Forms.TabControl V_0, 
         System.Drawing.Bitmap V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Bitmap V_3, 
         System.Drawing.Graphics V_4, 
         System.Drawing.Pen V_5, 
         System.Windows.Forms.TabAlignment V_6, 
         System.Drawing.Rectangle V_7)
				.try L_013c to L_016d finally L_016d to L_0179
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.TabControl
				L_000b: stloc.0 
				L_000c: ldarg.0 
				L_000d: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0012: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0017: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.TabControlRes get_TabControlRes()
				L_001c: callvirt Sunisoft.IrisSkin.TabControlRes::System.Drawing.Bitmap get_TabLine()
				L_0021: stloc.1 
				L_0022: ldloc.0 
				L_0023: callvirt System.Windows.Forms.TabControl::System.Windows.Forms.TabAlignment get_Alignment()
				L_0028: stloc.s V_6
				L_002a: ldloc.s V_6
				L_002c: switch (L_0041, L_00fd, L_0084, L_00c4)
				L_0041: ldloca.s V_2
				L_0043: ldc.i4.0 
				L_0044: ldloc.0 
				L_0045: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_DisplayRectangle()
				L_004a: stloc.s V_7
				L_004c: ldloca.s V_7
				L_004e: call System.Drawing.Rectangle::Int32 get_Y()
				L_0053: ldc.i4.2 
				L_0054: sub 
				L_0055: ldloc.1 
				L_0056: callvirt System.Drawing.Image::Int32 get_Height()
				L_005b: sub 
				L_005c: ldloc.0 
				L_005d: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0062: ldloc.1 
				L_0063: callvirt System.Drawing.Image::Int32 get_Height()
				L_0068: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_006d: ldloc.0 
				L_006e: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0073: ldloc.1 
				L_0074: callvirt System.Drawing.Image::Int32 get_Height()
				L_0079: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_007e: stloc.3 
				L_007f: br L_0134
				L_0084: ldloca.s V_2
				L_0086: ldloc.0 
				L_0087: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_DisplayRectangle()
				L_008c: stloc.s V_7
				L_008e: ldloca.s V_7
				L_0090: call System.Drawing.Rectangle::Int32 get_X()
				L_0095: ldc.i4.2 
				L_0096: sub 
				L_0097: ldloc.1 
				L_0098: callvirt System.Drawing.Image::Int32 get_Height()
				L_009d: sub 
				L_009e: ldc.i4.0 
				L_009f: ldloc.1 
				L_00a0: callvirt System.Drawing.Image::Int32 get_Height()
				L_00a5: ldloc.0 
				L_00a6: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_00ab: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00b0: ldloc.0 
				L_00b1: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_00b6: ldloc.1 
				L_00b7: callvirt System.Drawing.Image::Int32 get_Height()
				L_00bc: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_00c1: stloc.3 
				L_00c2: br.s L_0134
				L_00c4: ldloca.s V_2
				L_00c6: ldloc.0 
				L_00c7: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_DisplayRectangle()
				L_00cc: stloc.s V_7
				L_00ce: ldloca.s V_7
				L_00d0: call System.Drawing.Rectangle::Int32 get_Right()
				L_00d5: ldc.i4.2 
				L_00d6: add 
				L_00d7: ldc.i4.0 
				L_00d8: ldloc.1 
				L_00d9: callvirt System.Drawing.Image::Int32 get_Height()
				L_00de: ldloc.0 
				L_00df: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_00e4: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00e9: ldloc.0 
				L_00ea: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_00ef: ldloc.1 
				L_00f0: callvirt System.Drawing.Image::Int32 get_Height()
				L_00f5: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_00fa: stloc.3 
				L_00fb: br.s L_0134
				L_00fd: ldloca.s V_2
				L_00ff: ldc.i4.0 
				L_0100: ldloc.0 
				L_0101: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_DisplayRectangle()
				L_0106: stloc.s V_7
				L_0108: ldloca.s V_7
				L_010a: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_010f: ldc.i4.2 
				L_0110: add 
				L_0111: ldloc.0 
				L_0112: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0117: ldloc.1 
				L_0118: callvirt System.Drawing.Image::Int32 get_Height()
				L_011d: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0122: ldloc.0 
				L_0123: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0128: ldloc.1 
				L_0129: callvirt System.Drawing.Image::Int32 get_Height()
				L_012e: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0133: stloc.3 
				L_0134: ldloc.3 
				L_0135: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_013a: stloc.s V_4
				L_013c: ldloc.s V_4
				L_013e: ldloc.1 
				L_013f: ldc.i4.0 
				L_0140: ldc.i4.0 
				L_0141: ldloc.3 
				L_0142: callvirt System.Drawing.Image::Int32 get_Width()
				L_0147: ldloc.3 
				L_0148: callvirt System.Drawing.Image::Int32 get_Height()
				L_014d: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0152: ldc.i4.0 
				L_0153: ldc.i4.0 
				L_0154: ldloc.1 
				L_0155: callvirt System.Drawing.Image::Int32 get_Width()
				L_015a: ldloc.1 
				L_015b: callvirt System.Drawing.Image::Int32 get_Height()
				L_0160: ldc.i4.2 
				L_0161: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x8da407ebcbbfe204()
				L_0166: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_016b: leave.s L_0179
				L_016d: ldloc.s V_4
				L_016f: brfalse.s L_0178
				L_0171: ldloc.s V_4
				L_0173: callvirt System.IDisposable::Void Dispose()
				L_0178: endfinally 
				L_0179: ldloc.0 
				L_017a: callvirt System.Windows.Forms.TabControl::System.Windows.Forms.TabAlignment get_Alignment()
				L_017f: stloc.s V_6
				L_0181: ldloc.s V_6
				L_0183: switch (L_01b3, L_019a, L_01ac, L_01a3)
				L_0198: br.s L_01b3
				L_019a: ldloc.3 
				L_019b: ldc.i4.2 
				L_019c: callvirt System.Drawing.Image::Void RotateFlip(System.Drawing.RotateFlipType)
				L_01a1: br.s L_01b3
				L_01a3: ldloc.3 
				L_01a4: ldc.i4.1 
				L_01a5: callvirt System.Drawing.Image::Void RotateFlip(System.Drawing.RotateFlipType)
				L_01aa: br.s L_01b3
				L_01ac: ldloc.3 
				L_01ad: ldc.i4.3 
				L_01ae: callvirt System.Drawing.Image::Void RotateFlip(System.Drawing.RotateFlipType)
				L_01b3: ldarg.1 
				L_01b4: ldloc.3 
				L_01b5: ldloc.2 
				L_01b6: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, System.Drawing.Rectangle)
				L_01bb: ldloc.3 
				L_01bc: callvirt System.Drawing.Image::Void Dispose()
				L_01c1: ldarg.0 
				L_01c2: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01c7: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_01cc: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.TabControlRes get_TabControlRes()
				L_01d1: callvirt Sunisoft.IrisSkin.TabControlRes::System.Drawing.Pen get_BorderPen()
				L_01d6: stloc.s V_5
				L_01d8: ldloc.0 
				L_01d9: callvirt System.Windows.Forms.TabControl::System.Windows.Forms.TabAlignment get_Alignment()
				L_01de: stloc.s V_6
				L_01e0: ldloc.s V_6
				L_01e2: switch (L_01f7, L_0267, L_0317, L_02bf)
				L_01f7: ldarg.1 
				L_01f8: ldloc.s V_5
				L_01fa: ldc.i4.0 
				L_01fb: ldloc.0 
				L_01fc: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_DisplayRectangle()
				L_0201: stloc.s V_7
				L_0203: ldloca.s V_7
				L_0205: call System.Drawing.Rectangle::Int32 get_Y()
				L_020a: ldc.i4.2 
				L_020b: sub 
				L_020c: ldc.i4.0 
				L_020d: ldloc.0 
				L_020e: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0213: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0218: ldarg.1 
				L_0219: ldloc.s V_5
				L_021b: ldc.i4.0 
				L_021c: ldloc.0 
				L_021d: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0222: ldc.i4.1 
				L_0223: sub 
				L_0224: ldloc.0 
				L_0225: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_022a: ldloc.0 
				L_022b: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0230: ldc.i4.1 
				L_0231: sub 
				L_0232: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0237: ldarg.1 
				L_0238: ldloc.s V_5
				L_023a: ldloc.0 
				L_023b: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0240: ldc.i4.1 
				L_0241: sub 
				L_0242: ldloc.0 
				L_0243: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_DisplayRectangle()
				L_0248: stloc.s V_7
				L_024a: ldloca.s V_7
				L_024c: call System.Drawing.Rectangle::Int32 get_Y()
				L_0251: ldc.i4.2 
				L_0252: sub 
				L_0253: ldloc.0 
				L_0254: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0259: ldc.i4.1 
				L_025a: sub 
				L_025b: ldloc.0 
				L_025c: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0261: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0266: ret 
				L_0267: ldarg.1 
				L_0268: ldloc.s V_5
				L_026a: ldc.i4.0 
				L_026b: ldc.i4.0 
				L_026c: ldc.i4.0 
				L_026d: ldloc.0 
				L_026e: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_DisplayRectangle()
				L_0273: stloc.s V_7
				L_0275: ldloca.s V_7
				L_0277: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_027c: ldc.i4.2 
				L_027d: add 
				L_027e: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0283: ldarg.1 
				L_0284: ldloc.s V_5
				L_0286: ldc.i4.0 
				L_0287: ldc.i4.0 
				L_0288: ldloc.0 
				L_0289: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_028e: ldc.i4.0 
				L_028f: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0294: ldarg.1 
				L_0295: ldloc.s V_5
				L_0297: ldloc.0 
				L_0298: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_029d: ldc.i4.1 
				L_029e: sub 
				L_029f: ldc.i4.0 
				L_02a0: ldloc.0 
				L_02a1: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_02a6: ldc.i4.1 
				L_02a7: sub 
				L_02a8: ldloc.0 
				L_02a9: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_DisplayRectangle()
				L_02ae: stloc.s V_7
				L_02b0: ldloca.s V_7
				L_02b2: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_02b7: ldc.i4.2 
				L_02b8: add 
				L_02b9: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_02be: ret 
				L_02bf: ldarg.1 
				L_02c0: ldloc.s V_5
				L_02c2: ldc.i4.0 
				L_02c3: ldc.i4.0 
				L_02c4: ldc.i4.0 
				L_02c5: ldloc.0 
				L_02c6: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_02cb: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_02d0: ldarg.1 
				L_02d1: ldloc.s V_5
				L_02d3: ldc.i4.0 
				L_02d4: ldc.i4.0 
				L_02d5: ldloc.0 
				L_02d6: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_DisplayRectangle()
				L_02db: stloc.s V_7
				L_02dd: ldloca.s V_7
				L_02df: call System.Drawing.Rectangle::Int32 get_Right()
				L_02e4: ldc.i4.2 
				L_02e5: add 
				L_02e6: ldc.i4.0 
				L_02e7: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_02ec: ldarg.1 
				L_02ed: ldloc.s V_5
				L_02ef: ldc.i4.0 
				L_02f0: ldloc.0 
				L_02f1: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_02f6: ldc.i4.1 
				L_02f7: sub 
				L_02f8: ldloc.0 
				L_02f9: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_DisplayRectangle()
				L_02fe: stloc.s V_7
				L_0300: ldloca.s V_7
				L_0302: call System.Drawing.Rectangle::Int32 get_Right()
				L_0307: ldc.i4.2 
				L_0308: add 
				L_0309: ldloc.0 
				L_030a: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_030f: ldc.i4.1 
				L_0310: sub 
				L_0311: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0316: ret 
				L_0317: ldarg.1 
				L_0318: ldloc.s V_5
				L_031a: ldloc.0 
				L_031b: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_DisplayRectangle()
				L_0320: stloc.s V_7
				L_0322: ldloca.s V_7
				L_0324: call System.Drawing.Rectangle::Int32 get_X()
				L_0329: ldc.i4.2 
				L_032a: sub 
				L_032b: ldc.i4.0 
				L_032c: ldloc.0 
				L_032d: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0332: ldc.i4.0 
				L_0333: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0338: ldarg.1 
				L_0339: ldloc.s V_5
				L_033b: ldloc.0 
				L_033c: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_DisplayRectangle()
				L_0341: stloc.s V_7
				L_0343: ldloca.s V_7
				L_0345: call System.Drawing.Rectangle::Int32 get_X()
				L_034a: ldc.i4.2 
				L_034b: sub 
				L_034c: ldloc.0 
				L_034d: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0352: ldc.i4.1 
				L_0353: sub 
				L_0354: ldloc.0 
				L_0355: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_035a: ldloc.0 
				L_035b: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0360: ldc.i4.1 
				L_0361: sub 
				L_0362: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0367: ldarg.1 
				L_0368: ldloc.s V_5
				L_036a: ldloc.0 
				L_036b: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0370: ldc.i4.1 
				L_0371: sub 
				L_0372: ldc.i4.0 
				L_0373: ldloc.0 
				L_0374: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0379: ldc.i4.1 
				L_037a: sub 
				L_037b: ldloc.0 
				L_037c: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0381: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0386: ret 
			*/
			
			
			{
				TabControl tabControl1;
				Bitmap bitmap1;
				Rectangle rectangle1;
				Bitmap bitmap2;
				Pen pen1;
				TabAlignment tabAlignment1;
				tabControl1 = ((TabControl) base.xcd9cdf30888d2204);
				bitmap1 = ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).TabControlRes.TabLine;
				tabAlignment1 = tabControl1.Alignment;
				switch (tabAlignment1)
				{
					case TabAlignment.Bottom:
					
					{
							rectangle1 = new Rectangle (0, ((int) (tabControl1.DisplayRectangle.Bottom + 2)), tabControl1.Width, bitmap1.Height);
							bitmap2 = new Bitmap (tabControl1.Width, bitmap1.Height);
							goto L_0134;
					}
					case TabAlignment.Left:
					
					{
							rectangle1 = new Rectangle (((int) ((tabControl1.DisplayRectangle.X - 2) - bitmap1.Height)), 0, bitmap1.Height, tabControl1.Height);
							bitmap2 = new Bitmap (tabControl1.Height, bitmap1.Height);
							goto L_0134;
					}
					case TabAlignment.Right:
					
					{
							rectangle1 = new Rectangle (((int) (tabControl1.DisplayRectangle.Right + 2)), 0, bitmap1.Height, tabControl1.Height);
							bitmap2 = new Bitmap (tabControl1.Height, bitmap1.Height);
							goto L_0134;
					}
				}
				rectangle1 = new Rectangle (0, ((int) ((tabControl1.DisplayRectangle.Y - 2) - bitmap1.Height)), tabControl1.Width, bitmap1.Height);
				bitmap2 = new Bitmap (tabControl1.Width, bitmap1.Height);
				
			L_0134:
				
				{
				}
				using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap2)))
				{
					graphics1.DrawImage (((Image) bitmap1), new Rectangle (0, 0, bitmap2.Width, bitmap2.Height), 0, 0, bitmap1.Width, bitmap1.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x8da407ebcbbfe204);
				}
				tabAlignment1 = tabControl1.Alignment;
				switch (tabAlignment1)
				{
					case TabAlignment.Bottom:
					
					{
							bitmap2.RotateFlip (RotateFlipType.Rotate180FlipNone);
							break;
					}
					case TabAlignment.Left:
					
					{
							bitmap2.RotateFlip (RotateFlipType.Rotate270FlipNone);
							break;
					}
					case TabAlignment.Right:
					
					{
							bitmap2.RotateFlip (RotateFlipType.Rotate90FlipNone);
							break;
					}
				}
				x4b101060f4767186.DrawImageUnscaled (((Image) bitmap2), rectangle1);
				bitmap2.Dispose ();
				pen1 = ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).TabControlRes.BorderPen;
				switch (tabControl1.Alignment)
				{
					case TabAlignment.Bottom:
					
					{
							x4b101060f4767186.DrawLine (pen1, 0, 0, 0, ((int) (tabControl1.DisplayRectangle.Bottom + 2)));
							x4b101060f4767186.DrawLine (pen1, 0, 0, tabControl1.Width, 0);
							x4b101060f4767186.DrawLine (pen1, ((int) (tabControl1.Width - 1)), 0, ((int) (tabControl1.Width - 1)), ((int) (tabControl1.DisplayRectangle.Bottom + 2)));
							return;
					}
					case TabAlignment.Left:
					
					{
							x4b101060f4767186.DrawLine (pen1, ((int) (tabControl1.DisplayRectangle.X - 2)), 0, tabControl1.Width, 0);
							x4b101060f4767186.DrawLine (pen1, ((int) (tabControl1.DisplayRectangle.X - 2)), ((int) (tabControl1.Height - 1)), tabControl1.Width, ((int) (tabControl1.Height - 1)));
							x4b101060f4767186.DrawLine (pen1, ((int) (tabControl1.Width - 1)), 0, ((int) (tabControl1.Width - 1)), tabControl1.Height);
							return;
					}
					case TabAlignment.Right:
					
					{
							x4b101060f4767186.DrawLine (pen1, 0, 0, 0, tabControl1.Height);
							x4b101060f4767186.DrawLine (pen1, 0, 0, ((int) (tabControl1.DisplayRectangle.Right + 2)), 0);
							x4b101060f4767186.DrawLine (pen1, 0, ((int) (tabControl1.Height - 1)), ((int) (tabControl1.DisplayRectangle.Right + 2)), ((int) (tabControl1.Height - 1)));
							return;
					}
				}
				x4b101060f4767186.DrawLine (pen1, 0, ((int) (tabControl1.DisplayRectangle.Y - 2)), 0, tabControl1.Height);
				x4b101060f4767186.DrawLine (pen1, 0, ((int) (tabControl1.Height - 1)), tabControl1.Width, ((int) (tabControl1.Height - 1)));
				x4b101060f4767186.DrawLine (pen1, ((int) (tabControl1.Width - 1)), ((int) (tabControl1.DisplayRectangle.Y - 2)), ((int) (tabControl1.Width - 1)), tabControl1.Height);
			}
			
			private void xc33f5f7a18a754cb (Graphics x41347a961b838962, int x067d6ddeefb41622)
			
			/*
				// Code Size: 646 Bytes
				.maxstack 10
				.locals (System.Windows.Forms.TabControl V_0, 
         System.Drawing.Rectangle V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Rectangle V_3, 
         System.Drawing.Bitmap V_4, 
         System.Drawing.Bitmap V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         System.Drawing.Graphics V_9, 
         System.Windows.Forms.TabAlignment V_10)
				.try L_0079 to L_021f finally L_021f to L_022b
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.TabControl
				L_000b: stloc.0 
				L_000c: ldloc.0 
				L_000d: ldarg.2 
				L_000e: callvirt System.Windows.Forms.TabControl::System.Drawing.Rectangle GetTabRect(Int32)
				L_0013: stloc.1 
				L_0014: ldloc.0 
				L_0015: callvirt System.Windows.Forms.TabControl::Int32 get_SelectedIndex()
				L_001a: ldarg.2 
				L_001b: bne.un.s L_0022
				L_001d: ldc.i4.0 
				L_001e: stloc.s V_8
				L_0020: br.s L_0025
				L_0022: ldc.i4.1 
				L_0023: stloc.s V_8
				L_0025: ldloc.0 
				L_0026: callvirt System.Windows.Forms.TabControl::System.Windows.Forms.TabAlignment get_Alignment()
				L_002b: stloc.s V_10
				L_002d: ldloc.s V_10
				L_002f: switch (L_0044, L_0044, L_005b, L_005b)
				L_0044: ldloca.s V_1
				L_0046: call System.Drawing.Rectangle::Int32 get_Width()
				L_004b: ldloca.s V_1
				L_004d: call System.Drawing.Rectangle::Int32 get_Height()
				L_0052: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0057: stloc.s V_5
				L_0059: br.s L_0070
				L_005b: ldloca.s V_1
				L_005d: call System.Drawing.Rectangle::Int32 get_Height()
				L_0062: ldloca.s V_1
				L_0064: call System.Drawing.Rectangle::Int32 get_Width()
				L_0069: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_006e: stloc.s V_5
				L_0070: ldloc.s V_5
				L_0072: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0077: stloc.s V_9
				L_0079: ldarg.0 
				L_007a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_007f: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0084: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.TabControlRes get_TabControlRes()
				L_0089: callvirt Sunisoft.IrisSkin.TabControlRes::System.Drawing.Bitmap[,] get_TabImage()
				L_008e: ldloc.s V_8
				L_0090: ldc.i4.0 
				L_0091: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_0096: stloc.s V_4
				L_0098: ldloca.s V_3
				L_009a: ldc.i4.0 
				L_009b: ldc.i4.0 
				L_009c: ldloc.s V_4
				L_009e: callvirt System.Drawing.Image::Int32 get_Width()
				L_00a3: ldloc.s V_5
				L_00a5: callvirt System.Drawing.Image::Int32 get_Height()
				L_00aa: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00af: ldloca.s V_3
				L_00b1: call System.Drawing.Rectangle::Int32 get_Right()
				L_00b6: stloc.s V_6
				L_00b8: ldloc.s V_9
				L_00ba: ldloc.s V_4
				L_00bc: ldloc.3 
				L_00bd: ldc.i4.0 
				L_00be: ldc.i4.0 
				L_00bf: ldloc.s V_4
				L_00c1: callvirt System.Drawing.Image::Int32 get_Width()
				L_00c6: ldloc.s V_4
				L_00c8: callvirt System.Drawing.Image::Int32 get_Height()
				L_00cd: ldc.i4.2 
				L_00ce: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x349935d524988797()
				L_00d3: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_00d8: ldarg.0 
				L_00d9: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00de: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00e3: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.TabControlRes get_TabControlRes()
				L_00e8: callvirt Sunisoft.IrisSkin.TabControlRes::System.Drawing.Bitmap[,] get_TabImage()
				L_00ed: ldloc.s V_8
				L_00ef: ldc.i4.2 
				L_00f0: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_00f5: stloc.s V_4
				L_00f7: ldloca.s V_3
				L_00f9: ldloc.s V_5
				L_00fb: callvirt System.Drawing.Image::Int32 get_Width()
				L_0100: ldloc.s V_4
				L_0102: callvirt System.Drawing.Image::Int32 get_Width()
				L_0107: sub 
				L_0108: ldc.i4.0 
				L_0109: ldloc.s V_4
				L_010b: callvirt System.Drawing.Image::Int32 get_Width()
				L_0110: ldloc.s V_5
				L_0112: callvirt System.Drawing.Image::Int32 get_Height()
				L_0117: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_011c: ldloca.s V_3
				L_011e: call System.Drawing.Rectangle::Int32 get_Left()
				L_0123: stloc.s V_7
				L_0125: ldloc.s V_9
				L_0127: ldloc.s V_4
				L_0129: ldloc.3 
				L_012a: ldc.i4.0 
				L_012b: ldc.i4.0 
				L_012c: ldloc.s V_4
				L_012e: callvirt System.Drawing.Image::Int32 get_Width()
				L_0133: ldloc.s V_4
				L_0135: callvirt System.Drawing.Image::Int32 get_Height()
				L_013a: ldc.i4.2 
				L_013b: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x349935d524988797()
				L_0140: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_0145: ldarg.0 
				L_0146: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_014b: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0150: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.TabControlRes get_TabControlRes()
				L_0155: callvirt Sunisoft.IrisSkin.TabControlRes::System.Drawing.Bitmap[,] get_TabImage()
				L_015a: ldloc.s V_8
				L_015c: ldc.i4.1 
				L_015d: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_0162: stloc.s V_4
				L_0164: ldloc.s V_6
				L_0166: ldc.i4.0 
				L_0167: ldloc.s V_7
				L_0169: ldloc.s V_5
				L_016b: callvirt System.Drawing.Image::Int32 get_Height()
				L_0170: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0175: stloc.3 
				L_0176: ldloc.s V_9
				L_0178: ldloc.s V_4
				L_017a: ldloc.3 
				L_017b: ldc.i4.0 
				L_017c: ldc.i4.0 
				L_017d: ldloc.s V_4
				L_017f: callvirt System.Drawing.Image::Int32 get_Width()
				L_0184: ldloc.s V_4
				L_0186: callvirt System.Drawing.Image::Int32 get_Height()
				L_018b: ldc.i4.2 
				L_018c: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x349935d524988797()
				L_0191: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_0196: ldarg.0 
				L_0197: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_019c: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_01a1: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.TabControlRes get_TabControlRes()
				L_01a6: callvirt Sunisoft.IrisSkin.TabControlRes::System.Drawing.Bitmap get_TabLine()
				L_01ab: stloc.s V_4
				L_01ad: ldloc.s V_4
				L_01af: callvirt System.Drawing.Image::Int32 get_Height()
				L_01b4: pop 
				L_01b5: ldloca.s V_2
				L_01b7: ldc.i4.0 
				L_01b8: ldc.i4.0 
				L_01b9: ldloc.s V_4
				L_01bb: callvirt System.Drawing.Image::Int32 get_Width()
				L_01c0: ldloc.s V_4
				L_01c2: callvirt System.Drawing.Image::Int32 get_Height()
				L_01c7: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01cc: ldloca.s V_3
				L_01ce: ldc.i4.0 
				L_01cf: ldloc.s V_5
				L_01d1: callvirt System.Drawing.Image::Int32 get_Height()
				L_01d6: ldloc.s V_4
				L_01d8: callvirt System.Drawing.Image::Int32 get_Height()
				L_01dd: sub 
				L_01de: ldloc.s V_5
				L_01e0: callvirt System.Drawing.Image::Int32 get_Width()
				L_01e5: ldloc.s V_4
				L_01e7: callvirt System.Drawing.Image::Int32 get_Height()
				L_01ec: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01f1: ldloc.s V_9
				L_01f3: ldloc.s V_4
				L_01f5: ldloc.3 
				L_01f6: ldloca.s V_2
				L_01f8: call System.Drawing.Rectangle::Int32 get_X()
				L_01fd: ldloca.s V_2
				L_01ff: call System.Drawing.Rectangle::Int32 get_Y()
				L_0204: ldloca.s V_2
				L_0206: call System.Drawing.Rectangle::Int32 get_Width()
				L_020b: ldloca.s V_2
				L_020d: call System.Drawing.Rectangle::Int32 get_Height()
				L_0212: ldc.i4.2 
				L_0213: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x8da407ebcbbfe204()
				L_0218: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_021d: leave.s L_022b
				L_021f: ldloc.s V_9
				L_0221: brfalse.s L_022a
				L_0223: ldloc.s V_9
				L_0225: callvirt System.IDisposable::Void Dispose()
				L_022a: endfinally 
				L_022b: ldloc.0 
				L_022c: callvirt System.Windows.Forms.TabControl::System.Windows.Forms.TabAlignment get_Alignment()
				L_0231: stloc.s V_10
				L_0233: ldloc.s V_10
				L_0235: switch (L_0268, L_024c, L_0260, L_0256)
				L_024a: br.s L_0268
				L_024c: ldloc.s V_5
				L_024e: ldc.i4.2 
				L_024f: callvirt System.Drawing.Image::Void RotateFlip(System.Drawing.RotateFlipType)
				L_0254: br.s L_0268
				L_0256: ldloc.s V_5
				L_0258: ldc.i4.1 
				L_0259: callvirt System.Drawing.Image::Void RotateFlip(System.Drawing.RotateFlipType)
				L_025e: br.s L_0268
				L_0260: ldloc.s V_5
				L_0262: ldc.i4.3 
				L_0263: callvirt System.Drawing.Image::Void RotateFlip(System.Drawing.RotateFlipType)
				L_0268: ldarg.1 
				L_0269: ldloc.s V_5
				L_026b: ldloca.s V_1
				L_026d: call System.Drawing.Rectangle::Int32 get_X()
				L_0272: ldloca.s V_1
				L_0274: call System.Drawing.Rectangle::Int32 get_Y()
				L_0279: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_027e: ldloc.s V_5
				L_0280: callvirt System.Drawing.Image::Void Dispose()
				L_0285: ret 
			*/
			
			
			{
				TabControl tabControl1;
				Rectangle rectangle1;
				Rectangle rectangle2;
				Rectangle rectangle3;
				Bitmap bitmap1;
				Bitmap bitmap2;
				int i1;
				int i2;
				int i3;
				TabAlignment tabAlignment1;
				tabControl1 = ((TabControl) base.xcd9cdf30888d2204);
				rectangle1 = tabControl1.GetTabRect (x067d6ddeefb41622);
				if (tabControl1.SelectedIndex == x067d6ddeefb41622)
				{
					i3 = 0;
				}
				else
				{
					i3 = 1;
				}
				tabAlignment1 = tabControl1.Alignment;
				switch (tabAlignment1)
				{
					case TabAlignment.Left:
					case TabAlignment.Right:
					
					{
							bitmap2 = new Bitmap (rectangle1.Height, rectangle1.Width);
							goto L_0070;
					}
				}
				bitmap2 = new Bitmap (rectangle1.Width, rectangle1.Height);
				
			L_0070:
				
				{
				}
				using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap2)))
				{
					bitmap1 = ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).TabControlRes.TabImage[i3, 0];
					rectangle3 = new Rectangle (0, 0, bitmap1.Width, bitmap2.Height);
					i1 = rectangle3.Right;
					graphics1.DrawImage (((Image) bitmap1), rectangle3, 0, 0, bitmap1.Width, bitmap1.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x349935d524988797);
					bitmap1 = ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).TabControlRes.TabImage[i3, 2];
					rectangle3 = new Rectangle (((int) (bitmap2.Width - bitmap1.Width)), 0, bitmap1.Width, bitmap2.Height);
					i2 = rectangle3.Left;
					graphics1.DrawImage (((Image) bitmap1), rectangle3, 0, 0, bitmap1.Width, bitmap1.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x349935d524988797);
					bitmap1 = ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).TabControlRes.TabImage[i3, 1];
					rectangle3 = Rectangle.FromLTRB (i1, 0, i2, bitmap2.Height);
					graphics1.DrawImage (((Image) bitmap1), rectangle3, 0, 0, bitmap1.Width, bitmap1.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x349935d524988797);
					bitmap1 = ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).TabControlRes.TabLine;
					int i4 = bitmap1.Height;
					rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
					rectangle3 = new Rectangle (0, ((int) (bitmap2.Height - bitmap1.Height)), bitmap2.Width, bitmap1.Height);
					graphics1.DrawImage (((Image) bitmap1), rectangle3, rectangle2.X, rectangle2.Y, rectangle2.Width, rectangle2.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x8da407ebcbbfe204);
				}
				tabAlignment1 = tabControl1.Alignment;
				switch (tabAlignment1)
				{
					case TabAlignment.Bottom:
					
					{
							bitmap2.RotateFlip (RotateFlipType.Rotate180FlipNone);
							break;
					}
					case TabAlignment.Left:
					
					{
							bitmap2.RotateFlip (RotateFlipType.Rotate270FlipNone);
							break;
					}
					case TabAlignment.Right:
					
					{
							bitmap2.RotateFlip (RotateFlipType.Rotate90FlipNone);
							break;
					}
				}
				x41347a961b838962.DrawImageUnscaled (((Image) bitmap2), rectangle1.X, rectangle1.Y);
				bitmap2.Dispose ();
			}
			
		#endregion
	}
	
}

