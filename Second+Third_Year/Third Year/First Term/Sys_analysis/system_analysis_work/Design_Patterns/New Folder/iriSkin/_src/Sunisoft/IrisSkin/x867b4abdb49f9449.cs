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
		
	internal class x867b4abdb49f9449 : Control
	
	{
		
		#region Fields
			private Control x246c0c54671f3f3e;
			private bool x71ee84dfc52c8c16;
			private ISkinEngine xdc87e2b99332cd4a;
		#endregion
		
		#region Constructors
		
			public x867b4abdb49f9449 (Control host, ISkinEngine engine, bool hScroll)
			/*
				// Code Size: 71 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: stfld Sunisoft.IrisSkin.x867b4abdb49f9449::System.Windows.Forms.Control x246c0c54671f3f3e
				L_000d: ldarg.0 
				L_000e: ldarg.2 
				L_000f: stfld Sunisoft.IrisSkin.x867b4abdb49f9449::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0014: ldarg.0 
				L_0015: ldarg.3 
				L_0016: stfld Sunisoft.IrisSkin.x867b4abdb49f9449::Boolean x71ee84dfc52c8c16
				L_001b: ldarg.1 
				L_001c: callvirt System.Windows.Forms.Control::System.Windows.Forms.Control get_Parent()
				L_0021: brfalse.s L_0034
				L_0023: ldarg.1 
				L_0024: callvirt System.Windows.Forms.Control::System.Windows.Forms.Control get_Parent()
				L_0029: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_002e: ldarg.0 
				L_002f: callvirt System.Windows.Forms.Control+ControlCollection::Void Add(System.Windows.Forms.Control)
				L_0034: ldarg.0 
				L_0035: ldarg.1 
				L_0036: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_Bounds()
				L_003b: call System.Windows.Forms.Control::Void set_Bounds(System.Drawing.Rectangle)
				L_0040: ldarg.0 
				L_0041: call System.Windows.Forms.Control::Void BringToFront()
				L_0046: ret 
			*/
		#endregion
		
		#region Methods
		
			protected override void WndProc (ref Message m)
			
			/*
				// Code Size: 274 Bytes
				.maxstack 6
				.locals (System.Int32 V_0, 
         System.UInt32 V_1, 
         Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT V_2, 
         System.UInt32 V_3)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::System.Windows.Forms.Control x246c0c54671f3f3e
				L_0006: brfalse L_00d6
				L_000b: ldarg.1 
				L_000c: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0011: stloc.3 
				L_0012: ldloc.3 
				L_0013: ldc.i4 513
				L_0018: sub 
				L_0019: switch (L_0036, L_0074)
				L_0026: ldloc.3 
				L_0027: ldc.i4 522
				L_002c: beq L_00b2
				L_0031: br L_00d6
				L_0036: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 GetMessagePos()
				L_003b: stloc.0 
				L_003c: ldarg.0 
				L_003d: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::Boolean x71ee84dfc52c8c16
				L_0042: brfalse.s L_0048
				L_0044: ldc.i4.6 
				L_0045: stloc.1 
				L_0046: br.s L_004a
				L_0048: ldc.i4.7 
				L_0049: stloc.1 
				L_004a: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean ReleaseCapture()
				L_004f: pop 
				L_0050: ldarg.0 
				L_0051: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::System.Windows.Forms.Control x246c0c54671f3f3e
				L_0056: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_005b: ldc.i4 161
				L_0060: ldloc.1 
				L_0061: conv.u8 
				L_0062: newobj System.IntPtr::Void .ctor(Int64)
				L_0067: ldloc.0 
				L_0068: newobj System.IntPtr::Void .ctor(Int32)
				L_006d: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SendMessage(IntPtr, UInt32, IntPtr, IntPtr)
				L_0072: pop 
				L_0073: ret 
				L_0074: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 GetMessagePos()
				L_0079: stloc.0 
				L_007a: ldarg.0 
				L_007b: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::Boolean x71ee84dfc52c8c16
				L_0080: brfalse.s L_0086
				L_0082: ldc.i4.6 
				L_0083: stloc.1 
				L_0084: br.s L_0088
				L_0086: ldc.i4.7 
				L_0087: stloc.1 
				L_0088: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean ReleaseCapture()
				L_008d: pop 
				L_008e: ldarg.0 
				L_008f: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::System.Windows.Forms.Control x246c0c54671f3f3e
				L_0094: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0099: ldc.i4 162
				L_009e: ldloc.1 
				L_009f: conv.u8 
				L_00a0: newobj System.IntPtr::Void .ctor(Int64)
				L_00a5: ldloc.0 
				L_00a6: newobj System.IntPtr::Void .ctor(Int32)
				L_00ab: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SendMessage(IntPtr, UInt32, IntPtr, IntPtr)
				L_00b0: pop 
				L_00b1: ret 
				L_00b2: ldarg.0 
				L_00b3: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::System.Windows.Forms.Control x246c0c54671f3f3e
				L_00b8: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_00bd: ldarg.1 
				L_00be: call System.Windows.Forms.Message::Int32 get_Msg()
				L_00c3: ldarg.1 
				L_00c4: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_00c9: ldarg.1 
				L_00ca: call System.Windows.Forms.Message::IntPtr get_LParam()
				L_00cf: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, IntPtr, IntPtr)
				L_00d4: pop 
				L_00d5: ret 
				L_00d6: ldarg.0 
				L_00d7: ldarg.1 
				L_00d8: call System.Windows.Forms.Control::Void WndProc(System.Windows.Forms.Message ByRef)
				L_00dd: ldarg.1 
				L_00de: call System.Windows.Forms.Message::Int32 get_Msg()
				L_00e3: stloc.3 
				L_00e4: ldloc.3 
				L_00e5: ldc.i4.s 15
				L_00e7: beq.s L_00ef
				L_00e9: ldloc.3 
				L_00ea: ldc.i4.s 20
				L_00ec: beq.s L_00ef
				L_00ee: ret 
				L_00ef: ldarg.0 
				L_00f0: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_00f5: ldloca.s V_2
				L_00f7: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr BeginPaint(IntPtr, PAINTSTRUCT ByRef)
				L_00fc: pop 
				L_00fd: ldarg.0 
				L_00fe: call Sunisoft.IrisSkin.x867b4abdb49f9449::Void x8bc95f030953f87b()
				L_0103: ldarg.0 
				L_0104: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_0109: ldloca.s V_2
				L_010b: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean EndPaint(IntPtr, PAINTSTRUCT ByRef)
				L_0110: pop 
				L_0111: ret 
			*/
			
			
			{
				int i1;
				uint uInt32_1;
				x40255b11ef821fa3.PAINTSTRUCT pAINTSTRUCT1;
				uint uInt32_2;
				if (this.x246c0c54671f3f3e != null)
				{
					uInt32_2 = ((uint) m.Msg);
					switch ((int) uInt32_2)
					{
						case 513:
						
						{
								i1 = x61467fe65a98f20c.GetMessagePos ();
								if (! this.x71ee84dfc52c8c16)
								{
									uInt32_1 = 7;
									goto L_004A;
								}
								uInt32_1 = 6;
								goto L_004A;
						}
						case 514:
						
						{
								i1 = x61467fe65a98f20c.GetMessagePos ();
								if (! this.x71ee84dfc52c8c16)
								{
									uInt32_1 = 7;
									goto L_0088;
								}
								uInt32_1 = 6;
								goto L_0088;
						}
					}
					if (uInt32_2 == 522)
					{
						bool b3 = x61467fe65a98f20c.PostMessage (this.x246c0c54671f3f3e.Handle, ((uint) m.Msg), m.WParam, m.LParam);
						return;
					}
				}
				base.WndProc (ref m);
				uInt32_2 = ((uint) m.Msg);
				if ((uInt32_2 == 15) || (uInt32_2 == 20))
				{
					IntPtr intPtr3 = x61467fe65a98f20c.BeginPaint (base.Handle, out pAINTSTRUCT1);
					this.x8bc95f030953f87b ();
					bool b4 = x61467fe65a98f20c.EndPaint (base.Handle, ref pAINTSTRUCT1);
					return;
				}
				return;
				
			L_004A:
				
				{
				}
				bool b1 = x61467fe65a98f20c.ReleaseCapture ();
				IntPtr intPtr1 = x61467fe65a98f20c.SendMessage (this.x246c0c54671f3f3e.Handle, 161, new IntPtr (((long) uInt32_1)), new IntPtr (i1));
				return;
				
			L_0088:
				
				{
				}
				bool b2 = x61467fe65a98f20c.ReleaseCapture ();
				IntPtr intPtr2 = x61467fe65a98f20c.SendMessage (this.x246c0c54671f3f3e.Handle, 162, new IntPtr (((long) uInt32_1)), new IntPtr (i1));
			}
			
			protected void x8bc95f030953f87b ()
			
			/*
				// Code Size: 402 Bytes
				.maxstack 7
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO V_0, 
         Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_1, 
         System.Drawing.Rectangle V_2)
				L_0000: ldloca.s V_0
				L_0002: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO
				L_0008: ldloca.s V_0
				L_000a: ldc.i4.s 60
				L_000c: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::UInt32 cbSize
				L_0011: ldloca.s V_1
				L_0013: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
				L_0019: ldarg.0 
				L_001a: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::System.Windows.Forms.Control x246c0c54671f3f3e
				L_001f: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0024: ldloca.s V_1
				L_0026: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowRect(IntPtr, RECT ByRef)
				L_002b: pop 
				L_002c: ldarg.0 
				L_002d: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::Boolean x71ee84dfc52c8c16
				L_0032: brfalse L_00ed
				L_0037: ldarg.0 
				L_0038: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::System.Windows.Forms.Control x246c0c54671f3f3e
				L_003d: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0042: ldc.i4.s -6
				L_0044: ldloca.s V_0
				L_0046: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollBarInfo(IntPtr, UInt32, SCROLLBARINFO ByRef)
				L_004b: brfalse L_0191
				L_0050: ldloca.s V_2
				L_0052: ldloca.s V_0
				L_0054: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0059: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_005e: ldloca.s V_1
				L_0060: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0065: sub 
				L_0066: ldloca.s V_0
				L_0068: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_006d: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0072: ldloca.s V_1
				L_0074: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0079: sub 
				L_007a: ldloca.s V_0
				L_007c: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0081: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0086: ldloca.s V_0
				L_0088: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_008d: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0092: sub 
				L_0093: ldloca.s V_0
				L_0095: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_009a: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_009f: ldloca.s V_0
				L_00a1: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00a6: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_00ab: sub 
				L_00ac: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00b1: ldloca.s V_2
				L_00b3: call System.Drawing.Rectangle::Int32 get_X()
				L_00b8: ldc.i4.0 
				L_00b9: blt L_0191
				L_00be: ldloca.s V_2
				L_00c0: call System.Drawing.Rectangle::Int32 get_Y()
				L_00c5: ldc.i4.0 
				L_00c6: blt L_0191
				L_00cb: ldloca.s V_2
				L_00cd: call System.Drawing.Rectangle::Int32 get_Width()
				L_00d2: ldc.i4.0 
				L_00d3: ble L_0191
				L_00d8: ldloca.s V_2
				L_00da: call System.Drawing.Rectangle::Int32 get_Height()
				L_00df: ldc.i4.0 
				L_00e0: ble L_0191
				L_00e5: ldarg.0 
				L_00e6: ldloc.0 
				L_00e7: call Sunisoft.IrisSkin.x867b4abdb49f9449::Void x9b8f9735fbcfbe34(SCROLLBARINFO)
				L_00ec: ret 
				L_00ed: ldarg.0 
				L_00ee: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_00f3: ldc.i4.s -5
				L_00f5: ldloca.s V_0
				L_00f7: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollBarInfo(IntPtr, UInt32, SCROLLBARINFO ByRef)
				L_00fc: brfalse L_0191
				L_0101: ldloca.s V_2
				L_0103: ldloca.s V_0
				L_0105: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_010a: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_010f: ldloca.s V_1
				L_0111: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0116: sub 
				L_0117: ldloca.s V_0
				L_0119: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_011e: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0123: ldloca.s V_1
				L_0125: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_012a: sub 
				L_012b: ldloca.s V_0
				L_012d: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0132: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0137: ldloca.s V_0
				L_0139: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_013e: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0143: sub 
				L_0144: ldloca.s V_0
				L_0146: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_014b: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0150: ldloca.s V_0
				L_0152: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0157: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_015c: sub 
				L_015d: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0162: ldloca.s V_2
				L_0164: call System.Drawing.Rectangle::Int32 get_X()
				L_0169: ldc.i4.0 
				L_016a: blt.s L_0191
				L_016c: ldloca.s V_2
				L_016e: call System.Drawing.Rectangle::Int32 get_Y()
				L_0173: ldc.i4.0 
				L_0174: blt.s L_0191
				L_0176: ldloca.s V_2
				L_0178: call System.Drawing.Rectangle::Int32 get_Width()
				L_017d: ldc.i4.0 
				L_017e: ble.s L_0191
				L_0180: ldloca.s V_2
				L_0182: call System.Drawing.Rectangle::Int32 get_Height()
				L_0187: ldc.i4.0 
				L_0188: ble.s L_0191
				L_018a: ldarg.0 
				L_018b: ldloc.0 
				L_018c: call Sunisoft.IrisSkin.x867b4abdb49f9449::Void x9b8f9735fbcfbe34(SCROLLBARINFO)
				L_0191: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				x40255b11ef821fa3.SCROLLBARINFO sCROLLBARINFO1 = new x40255b11ef821fa3.SCROLLBARINFO ();
				sCROLLBARINFO1.cbSize = 60;
				xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
				bool b1 = x61467fe65a98f20c.GetWindowRect (this.x246c0c54671f3f3e.Handle, ref rECT1);
				if (this.x71ee84dfc52c8c16)
				{
					if (x61467fe65a98f20c.GetScrollBarInfo (this.x246c0c54671f3f3e.Handle, ((uint) 0x00FA), ref sCROLLBARINFO1))
					{
						rectangle1 = new Rectangle (((int) (sCROLLBARINFO1.rcScrollBar.left - rECT1.left)), ((int) (sCROLLBARINFO1.rcScrollBar.top - rECT1.top)), ((int) (sCROLLBARINFO1.rcScrollBar.right - sCROLLBARINFO1.rcScrollBar.left)), ((int) (sCROLLBARINFO1.rcScrollBar.bottom - sCROLLBARINFO1.rcScrollBar.top)));
						if ((((rectangle1.X >= 0) && (rectangle1.Y >= 0)) && (rectangle1.Width > 0)) && (rectangle1.Height > 0))
						{
							this.x9b8f9735fbcfbe34 (sCROLLBARINFO1);
						}
					}
				}
				else if (x61467fe65a98f20c.GetScrollBarInfo (base.Handle, ((uint) 0x00FB), ref sCROLLBARINFO1))
				{
					rectangle1 = new Rectangle (((int) (sCROLLBARINFO1.rcScrollBar.left - rECT1.left)), ((int) (sCROLLBARINFO1.rcScrollBar.top - rECT1.top)), ((int) (sCROLLBARINFO1.rcScrollBar.right - sCROLLBARINFO1.rcScrollBar.left)), ((int) (sCROLLBARINFO1.rcScrollBar.bottom - sCROLLBARINFO1.rcScrollBar.top)));
					if ((((rectangle1.X >= 0) && (rectangle1.Y >= 0)) && (rectangle1.Width > 0)) && (rectangle1.Height > 0))
					{
						this.x9b8f9735fbcfbe34 (sCROLLBARINFO1);
					}
				}
			}
			
			public void x9b8f9735fbcfbe34 (x40255b11ef821fa3.SCROLLBARINFO x8d3f74e5f925679c)
			
			/*
				// Code Size: 972 Bytes
				.maxstack 7
				.locals (System.Drawing.Bitmap V_0, 
         System.Drawing.Bitmap V_1, 
         System.Drawing.Brush V_2, 
         System.Drawing.Rectangle V_3, 
         System.Drawing.Rectangle V_4, 
         System.Drawing.Rectangle V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         System.Drawing.Graphics V_8, 
         System.Drawing.Graphics V_9, 
         System.Drawing.Point V_10)
				.try L_0030 to L_038e finally L_038e to L_039a
				.try L_03a7 to L_03b3 finally L_03b3 to L_03bf
				.try L_0025 to L_03c1 finally L_03c1 to L_03cb
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::Int32 get_Width()
				L_0006: ldc.i4.0 
				L_0007: ble.s L_0012
				L_0009: ldarg.0 
				L_000a: call System.Windows.Forms.Control::Int32 get_Height()
				L_000f: ldc.i4.0 
				L_0010: bgt.s L_0013
				L_0012: ret 
				L_0013: ldarg.0 
				L_0014: call System.Windows.Forms.Control::Int32 get_Width()
				L_0019: ldarg.0 
				L_001a: call System.Windows.Forms.Control::Int32 get_Height()
				L_001f: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0024: stloc.0 
				L_0025: ldc.i4.0 
				L_0026: stloc.s V_7
				L_0028: ldloc.0 
				L_0029: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_002e: stloc.s V_8
				L_0030: ldarg.0 
				L_0031: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0036: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_003b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0040: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Brush get_BackColorBrush()
				L_0045: stloc.2 
				L_0046: ldloca.s V_3
				L_0048: ldc.i4.0 
				L_0049: ldc.i4.0 
				L_004a: ldarg.0 
				L_004b: call System.Windows.Forms.Control::Int32 get_Width()
				L_0050: ldarg.0 
				L_0051: call System.Windows.Forms.Control::Int32 get_Height()
				L_0056: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_005b: ldloc.s V_8
				L_005d: ldloc.2 
				L_005e: ldloc.3 
				L_005f: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0064: ldloca.s V_5
				L_0066: ldc.i4.0 
				L_0067: ldc.i4.0 
				L_0068: ldarg.0 
				L_0069: call System.Windows.Forms.Control::Int32 get_Width()
				L_006e: ldarg.0 
				L_006f: call System.Windows.Forms.Control::Int32 get_Height()
				L_0074: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0079: ldarg.0 
				L_007a: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::Boolean x71ee84dfc52c8c16
				L_007f: brfalse L_0243
				L_0084: ldloca.s V_5
				L_0086: ldarga.s x8d3f74e5f925679c
				L_0088: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_008d: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0092: ldarga.s x8d3f74e5f925679c
				L_0094: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0099: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_009e: sub 
				L_009f: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_00a4: ldarg.0 
				L_00a5: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::System.Windows.Forms.Control x246c0c54671f3f3e
				L_00aa: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_00af: ldc.i4.1 
				L_00b0: and 
				L_00b1: ldc.i4.1 
				L_00b2: bne.un.s L_00e3
				L_00b4: ldloca.s V_5
				L_00b6: dup 
				L_00b7: call System.Drawing.Rectangle::Int32 get_X()
				L_00bc: ldarg.0 
				L_00bd: ldarga.s x8d3f74e5f925679c
				L_00bf: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00c4: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_00c9: ldc.i4.0 
				L_00ca: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_00cf: call System.Windows.Forms.Control::System.Drawing.Point PointToClient(System.Drawing.Point)
				L_00d4: stloc.s V_10
				L_00d6: ldloca.s V_10
				L_00d8: call System.Drawing.Point::Int32 get_X()
				L_00dd: add 
				L_00de: call System.Drawing.Rectangle::Void set_X(Int32)
				L_00e3: ldc.i4.s 16
				L_00e5: ldloca.s V_5
				L_00e7: call System.Drawing.Rectangle::Int32 get_Width()
				L_00ec: ldc.i4.2 
				L_00ed: div 
				L_00ee: call System.Math::Int32 Min(Int32, Int32)
				L_00f3: stloc.s V_6
				L_00f5: ldarg.0 
				L_00f6: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00fb: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0100: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0105: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_UpButton()
				L_010a: ldc.i4.1 
				L_010b: ldloc.s V_7
				L_010d: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_0112: stloc.1 
				L_0113: ldloca.s V_4
				L_0115: ldc.i4.0 
				L_0116: ldc.i4.0 
				L_0117: ldloc.1 
				L_0118: callvirt System.Drawing.Image::Int32 get_Width()
				L_011d: ldloc.1 
				L_011e: callvirt System.Drawing.Image::Int32 get_Height()
				L_0123: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0128: ldloca.s V_3
				L_012a: ldloca.s V_5
				L_012c: call System.Drawing.Rectangle::Int32 get_X()
				L_0131: ldloca.s V_5
				L_0133: call System.Drawing.Rectangle::Int32 get_Y()
				L_0138: ldloc.s V_6
				L_013a: ldloca.s V_5
				L_013c: call System.Drawing.Rectangle::Int32 get_Height()
				L_0141: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0146: ldloc.s V_8
				L_0148: ldloc.1 
				L_0149: ldloc.3 
				L_014a: ldloc.s V_4
				L_014c: ldc.i4.2 
				L_014d: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0152: ldarg.0 
				L_0153: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0158: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_015d: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0162: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_DownButton()
				L_0167: ldc.i4.1 
				L_0168: ldloc.s V_7
				L_016a: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_016f: stloc.1 
				L_0170: ldloca.s V_4
				L_0172: ldc.i4.0 
				L_0173: ldc.i4.0 
				L_0174: ldloc.1 
				L_0175: callvirt System.Drawing.Image::Int32 get_Width()
				L_017a: ldloc.1 
				L_017b: callvirt System.Drawing.Image::Int32 get_Height()
				L_0180: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0185: ldloca.s V_3
				L_0187: ldloca.s V_5
				L_0189: call System.Drawing.Rectangle::Int32 get_Right()
				L_018e: ldloc.s V_6
				L_0190: sub 
				L_0191: ldloca.s V_5
				L_0193: call System.Drawing.Rectangle::Int32 get_Y()
				L_0198: ldloc.s V_6
				L_019a: ldloca.s V_5
				L_019c: call System.Drawing.Rectangle::Int32 get_Height()
				L_01a1: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01a6: ldloc.s V_8
				L_01a8: ldloc.1 
				L_01a9: ldloc.3 
				L_01aa: ldloc.s V_4
				L_01ac: ldc.i4.2 
				L_01ad: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_01b2: ldarga.s x8d3f74e5f925679c
				L_01b4: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::UInt32[] rgstate
				L_01b9: ldc.i4.0 
				L_01ba: ldelem.u4 
				L_01bb: ldc.i4 32768
				L_01c0: and 
				L_01c1: ldc.i4 32768
				L_01c6: beq L_038c
				L_01cb: ldarga.s x8d3f74e5f925679c
				L_01cd: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::UInt32[] rgstate
				L_01d2: ldc.i4.0 
				L_01d3: ldelem.u4 
				L_01d4: ldc.i4.1 
				L_01d5: and 
				L_01d6: ldc.i4.1 
				L_01d7: beq L_038c
				L_01dc: ldarga.s x8d3f74e5f925679c
				L_01de: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_01e3: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_01e8: ldarga.s x8d3f74e5f925679c
				L_01ea: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_01ef: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_01f4: sub 
				L_01f5: ldc.i4.s 38
				L_01f7: ble L_038c
				L_01fc: ldloca.s V_3
				L_01fe: ldarga.s x8d3f74e5f925679c
				L_0200: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbTop
				L_0205: ldloca.s V_5
				L_0207: call System.Drawing.Rectangle::Int32 get_Left()
				L_020c: add 
				L_020d: ldloca.s V_5
				L_020f: call System.Drawing.Rectangle::Int32 get_Top()
				L_0214: ldarga.s x8d3f74e5f925679c
				L_0216: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbBottom
				L_021b: ldarga.s x8d3f74e5f925679c
				L_021d: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbTop
				L_0222: sub 
				L_0223: ldloca.s V_5
				L_0225: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_022a: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_022f: ldarg.0 
				L_0230: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0235: ldloc.s V_8
				L_0237: ldloc.3 
				L_0238: ldc.i4.0 
				L_0239: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x9b7cda8516f8644e(Sunisoft.IrisSkin.SkinEngine, System.Drawing.Graphics, System.Drawing.Rectangle, Boolean)
				L_023e: br L_038c
				L_0243: ldc.i4.s 16
				L_0245: ldarg.0 
				L_0246: call System.Windows.Forms.Control::Int32 get_Height()
				L_024b: ldc.i4.2 
				L_024c: div 
				L_024d: call System.Math::Int32 Min(Int32, Int32)
				L_0252: stloc.s V_6
				L_0254: ldarg.0 
				L_0255: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_025a: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_025f: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0264: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_UpButton()
				L_0269: ldc.i4.0 
				L_026a: ldloc.s V_7
				L_026c: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_0271: stloc.1 
				L_0272: ldloca.s V_4
				L_0274: ldc.i4.0 
				L_0275: ldc.i4.0 
				L_0276: ldloc.1 
				L_0277: callvirt System.Drawing.Image::Int32 get_Width()
				L_027c: ldloc.1 
				L_027d: callvirt System.Drawing.Image::Int32 get_Height()
				L_0282: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0287: ldloca.s V_3
				L_0289: ldloca.s V_5
				L_028b: call System.Drawing.Rectangle::Int32 get_X()
				L_0290: ldloca.s V_5
				L_0292: call System.Drawing.Rectangle::Int32 get_Y()
				L_0297: ldloca.s V_5
				L_0299: call System.Drawing.Rectangle::Int32 get_Width()
				L_029e: ldloc.s V_6
				L_02a0: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_02a5: ldloc.s V_8
				L_02a7: ldloc.1 
				L_02a8: ldloc.3 
				L_02a9: ldloc.s V_4
				L_02ab: ldc.i4.2 
				L_02ac: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_02b1: ldarg.0 
				L_02b2: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_02b7: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_02bc: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_02c1: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_DownButton()
				L_02c6: ldc.i4.0 
				L_02c7: ldloc.s V_7
				L_02c9: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_02ce: stloc.1 
				L_02cf: ldloca.s V_4
				L_02d1: ldc.i4.0 
				L_02d2: ldc.i4.0 
				L_02d3: ldloc.1 
				L_02d4: callvirt System.Drawing.Image::Int32 get_Width()
				L_02d9: ldloc.1 
				L_02da: callvirt System.Drawing.Image::Int32 get_Height()
				L_02df: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_02e4: ldloca.s V_3
				L_02e6: ldloca.s V_5
				L_02e8: call System.Drawing.Rectangle::Int32 get_X()
				L_02ed: ldloca.s V_5
				L_02ef: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_02f4: ldloc.s V_6
				L_02f6: sub 
				L_02f7: ldloca.s V_5
				L_02f9: call System.Drawing.Rectangle::Int32 get_Width()
				L_02fe: ldloc.s V_6
				L_0300: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0305: ldloc.s V_8
				L_0307: ldloc.1 
				L_0308: ldloc.3 
				L_0309: ldloc.s V_4
				L_030b: ldc.i4.2 
				L_030c: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0311: ldarga.s x8d3f74e5f925679c
				L_0313: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::UInt32[] rgstate
				L_0318: ldc.i4.0 
				L_0319: ldelem.u4 
				L_031a: ldc.i4 32768
				L_031f: and 
				L_0320: ldc.i4 32768
				L_0325: beq.s L_038c
				L_0327: ldarga.s x8d3f74e5f925679c
				L_0329: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::UInt32[] rgstate
				L_032e: ldc.i4.0 
				L_032f: ldelem.u4 
				L_0330: ldc.i4.1 
				L_0331: and 
				L_0332: ldc.i4.1 
				L_0333: beq.s L_038c
				L_0335: ldarga.s x8d3f74e5f925679c
				L_0337: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_033c: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0341: ldarga.s x8d3f74e5f925679c
				L_0343: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0348: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_034d: sub 
				L_034e: ldc.i4.s 38
				L_0350: ble.s L_038c
				L_0352: ldloca.s V_3
				L_0354: ldloca.s V_5
				L_0356: call System.Drawing.Rectangle::Int32 get_Left()
				L_035b: ldarga.s x8d3f74e5f925679c
				L_035d: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbTop
				L_0362: ldloca.s V_5
				L_0364: call System.Drawing.Rectangle::Int32 get_Right()
				L_0369: ldarga.s x8d3f74e5f925679c
				L_036b: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbBottom
				L_0370: ldarga.s x8d3f74e5f925679c
				L_0372: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbTop
				L_0377: sub 
				L_0378: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_037d: ldarg.0 
				L_037e: ldfld Sunisoft.IrisSkin.x867b4abdb49f9449::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0383: ldloc.s V_8
				L_0385: ldloc.3 
				L_0386: ldc.i4.1 
				L_0387: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x9b7cda8516f8644e(Sunisoft.IrisSkin.SkinEngine, System.Drawing.Graphics, System.Drawing.Rectangle, Boolean)
				L_038c: leave.s L_039a
				L_038e: ldloc.s V_8
				L_0390: brfalse.s L_0399
				L_0392: ldloc.s V_8
				L_0394: callvirt System.IDisposable::Void Dispose()
				L_0399: endfinally 
				L_039a: ldarg.0 
				L_039b: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_03a0: call System.Drawing.Graphics::System.Drawing.Graphics FromHwnd(IntPtr)
				L_03a5: stloc.s V_9
				L_03a7: ldloc.s V_9
				L_03a9: ldloc.0 
				L_03aa: ldc.i4.0 
				L_03ab: ldc.i4.0 
				L_03ac: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_03b1: leave.s L_03bf
				L_03b3: ldloc.s V_9
				L_03b5: brfalse.s L_03be
				L_03b7: ldloc.s V_9
				L_03b9: callvirt System.IDisposable::Void Dispose()
				L_03be: endfinally 
				L_03bf: leave.s L_03cb
				L_03c1: ldloc.0 
				L_03c2: brfalse.s L_03ca
				L_03c4: ldloc.0 
				L_03c5: callvirt System.IDisposable::Void Dispose()
				L_03ca: endfinally 
				L_03cb: ret 
			*/
			
			
			{
				Bitmap bitmap2;
				Brush brush1;
				Rectangle rectangle1;
				Rectangle rectangle2;
				Rectangle rectangle3;
				int i1;
				int i2;
				if ((base.Width > 0) && (base.Height > 0))
				{
					using (Bitmap bitmap1 = new Bitmap (base.Width, base.Height))
					{
						i2 = 0;
						using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap1)))
						{
							brush1 = ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).ScrollBarRes.BackColorBrush;
							rectangle1 = new Rectangle (0, 0, base.Width, base.Height);
							graphics1.FillRectangle (brush1, rectangle1);
							rectangle3 = new Rectangle (0, 0, base.Width, base.Height);
							if (this.x71ee84dfc52c8c16)
							{
								rectangle3.Width = (x8d3f74e5f925679c.rcScrollBar.right - x8d3f74e5f925679c.rcScrollBar.left);
								if ((this.x246c0c54671f3f3e.RightToLeft & System.Windows.Forms.RightToLeft.Yes) == System.Windows.Forms.RightToLeft.Yes)
								{
									rectangle3.X += base.PointToClient (new Point (x8d3f74e5f925679c.rcScrollBar.left, 0)).X;
								}
								i1 = Math.Min (16, ((int) (rectangle3.Width / 2)));
								bitmap2 = ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).ScrollBarRes.UpButton[1, i2];
								rectangle2 = new Rectangle (0, 0, bitmap2.Width, bitmap2.Height);
								rectangle1 = new Rectangle (rectangle3.X, rectangle3.Y, i1, rectangle3.Height);
								graphics1.DrawImage (((Image) bitmap2), rectangle1, rectangle2, GraphicsUnit.Pixel);
								bitmap2 = ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).ScrollBarRes.DownButton[1, i2];
								rectangle2 = new Rectangle (0, 0, bitmap2.Width, bitmap2.Height);
								rectangle1 = new Rectangle (((int) (rectangle3.Right - i1)), rectangle3.Y, i1, rectangle3.Height);
								graphics1.DrawImage (((Image) bitmap2), rectangle1, rectangle2, GraphicsUnit.Pixel);
								if ((((((int) x8d3f74e5f925679c.rgstate[0]) & 32768) != 32768) && ((((int) x8d3f74e5f925679c.rgstate[0]) & 1) != 1)) && ((x8d3f74e5f925679c.rcScrollBar.right - x8d3f74e5f925679c.rcScrollBar.left) > 38))
								{
									rectangle1 = new Rectangle (((int) (x8d3f74e5f925679c.xyThumbTop + rectangle3.Left)), rectangle3.Top, ((int) (x8d3f74e5f925679c.xyThumbBottom - x8d3f74e5f925679c.xyThumbTop)), rectangle3.Bottom);
									x448fd9ab43628c71.x9b7cda8516f8644e (this.xdc87e2b99332cd4a, graphics1, rectangle1, false);
								}
							}
							else
							{
								i1 = Math.Min (16, ((int) (base.Height / 2)));
								bitmap2 = ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).ScrollBarRes.UpButton[0, i2];
								rectangle2 = new Rectangle (0, 0, bitmap2.Width, bitmap2.Height);
								rectangle1 = new Rectangle (rectangle3.X, rectangle3.Y, rectangle3.Width, i1);
								graphics1.DrawImage (((Image) bitmap2), rectangle1, rectangle2, GraphicsUnit.Pixel);
								bitmap2 = ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).ScrollBarRes.DownButton[0, i2];
								rectangle2 = new Rectangle (0, 0, bitmap2.Width, bitmap2.Height);
								rectangle1 = new Rectangle (rectangle3.X, ((int) (rectangle3.Bottom - i1)), rectangle3.Width, i1);
								graphics1.DrawImage (((Image) bitmap2), rectangle1, rectangle2, GraphicsUnit.Pixel);
								if ((((((int) x8d3f74e5f925679c.rgstate[0]) & 32768) != 32768) && ((((int) x8d3f74e5f925679c.rgstate[0]) & 1) != 1)) && ((x8d3f74e5f925679c.rcScrollBar.bottom - x8d3f74e5f925679c.rcScrollBar.top) > 38))
								{
									rectangle1 = new Rectangle (rectangle3.Left, x8d3f74e5f925679c.xyThumbTop, rectangle3.Right, ((int) (x8d3f74e5f925679c.xyThumbBottom - x8d3f74e5f925679c.xyThumbTop)));
									x448fd9ab43628c71.x9b7cda8516f8644e (this.xdc87e2b99332cd4a, graphics1, rectangle1, true);
								}
							}
						}
						using (Graphics graphics2 = Graphics.FromHwnd (base.Handle))
						{
							graphics2.DrawImageUnscaled (((Image) bitmap1), 0, 0);
						}
					}
				}
			}
			
		#endregion
	}
	
}

