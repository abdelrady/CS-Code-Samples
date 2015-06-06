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
		
	internal class x9c946c69c1315c4d : x8917d01b98173f4c
	
	{
		
		#region Fields
			private uint x1f25abf5fb75e795;
			private Rectangle x26545669838eb36e;
			private Point x2aa5114a5da7d6c8;
			private uint x30cc7819189f11b6;
			private bool x34ce871902cf4acd;
			private Timer x420067493d7ebb36;
		#endregion
		
		#region Constructors
		
			public x9c946c69c1315c4d (Control control, ISkinEngine engine)
				 : base (control, engine)
			/*
				// Code Size: 72 Bytes
				.maxstack 6
				L_0000: ldarg.0 
				L_0001: newobj System.Windows.Forms.Timer::Void .ctor()
				L_0006: stfld Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Windows.Forms.Timer x420067493d7ebb36
				L_000b: ldarg.0 
				L_000c: ldc.i4 277
				L_0011: stfld Sunisoft.IrisSkin.x9c946c69c1315c4d::UInt32 x1f25abf5fb75e795
				L_0016: ldarg.0 
				L_0017: ldc.i4.0 
				L_0018: stfld Sunisoft.IrisSkin.x9c946c69c1315c4d::UInt32 x30cc7819189f11b6
				L_001d: ldarg.0 
				L_001e: ldflda Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Drawing.Rectangle x26545669838eb36e
				L_0023: ldc.i4.0 
				L_0024: ldc.i4.0 
				L_0025: ldc.i4.0 
				L_0026: ldc.i4.0 
				L_0027: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_002c: ldarg.0 
				L_002d: ldc.i4.0 
				L_002e: stfld Sunisoft.IrisSkin.x9c946c69c1315c4d::Boolean x34ce871902cf4acd
				L_0033: ldarg.0 
				L_0034: ldflda Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Drawing.Point x2aa5114a5da7d6c8
				L_0039: ldc.i4.0 
				L_003a: call System.Drawing.Point::Void .ctor(Int32)
				L_003f: ldarg.0 
				L_0040: ldarg.1 
				L_0041: ldarg.2 
				L_0042: call Sunisoft.IrisSkin.x8917d01b98173f4c::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0047: ret 
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
			
		#endregion
		
		#region Methods
		
			protected override void AfterWndProc (ref Message m)
			
			/*
				// Code Size: 157 Bytes
				.maxstack 4
				.locals (System.Int32 V_0, 
         Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT V_1, 
         System.UInt32 V_2, 
         System.IntPtr V_3)
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
				L_0018: callvirt Sunisoft.IrisSkin.x9c946c69c1315c4d::Boolean get_CanScroll()
				L_001d: brtrue.s L_0020
				L_001f: ret 
				L_0020: ldarg.1 
				L_0021: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0026: stloc.2 
				L_0027: ldloc.2 
				L_0028: ldc.i4.s 15
				L_002a: beq.s L_0073
				L_002c: ldloc.2 
				L_002d: ldc.i4 132
				L_0032: bne.un.s L_0095
				L_0034: ldarg.1 
				L_0035: call System.Windows.Forms.Message::IntPtr get_Result()
				L_003a: stloc.3 
				L_003b: ldloca.s V_3
				L_003d: call System.IntPtr::Int32 ToInt32()
				L_0042: stloc.0 
				L_0043: ldloc.0 
				L_0044: ldc.i4.7 
				L_0045: bne.un.s L_005b
				L_0047: ldarg.1 
				L_0048: ldloc.0 
				L_0049: ldc.i4 256
				L_004e: add 
				L_004f: newobj System.IntPtr::Void .ctor(Int32)
				L_0054: call System.Windows.Forms.Message::Void set_Result(IntPtr)
				L_0059: br.s L_0095
				L_005b: ldloc.0 
				L_005c: ldc.i4.6 
				L_005d: bne.un.s L_0095
				L_005f: ldarg.1 
				L_0060: ldloc.0 
				L_0061: ldc.i4 256
				L_0066: add 
				L_0067: newobj System.IntPtr::Void .ctor(Int32)
				L_006c: call System.Windows.Forms.Message::Void set_Result(IntPtr)
				L_0071: br.s L_0095
				L_0073: ldarg.0 
				L_0074: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0079: ldloca.s V_1
				L_007b: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr BeginPaint(IntPtr, PAINTSTRUCT ByRef)
				L_0080: pop 
				L_0081: ldarg.0 
				L_0082: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_0087: ldarg.0 
				L_0088: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_008d: ldloca.s V_1
				L_008f: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean EndPaint(IntPtr, PAINTSTRUCT ByRef)
				L_0094: pop 
				L_0095: ldarg.0 
				L_0096: ldarg.1 
				L_0097: call Sunisoft.IrisSkin.x8917d01b98173f4c::Void AfterWndProc(System.Windows.Forms.Message ByRef)
				L_009c: ret 
			*/
			
			
			{
				int i1;
				x40255b11ef821fa3.PAINTSTRUCT pAINTSTRUCT1;
				IntPtr intPtr1;
				if (((! base.xf2140268ef7ddbf7) || (! ((SkinEngine) base.xdc87e2b99332cd4a).SkinScrollBar)) || (! this.CanScroll))
				{
					return;
				}
				uint uInt32_1 = ((uint) m.Msg);
				if (uInt32_1 == 15)
				{
					IntPtr intPtr2 = x61467fe65a98f20c.BeginPaint (base.Handle, out pAINTSTRUCT1);
					this.PaintControl ();
					bool b1 = x61467fe65a98f20c.EndPaint (base.Handle, ref pAINTSTRUCT1);
				}
				else if (uInt32_1 == 132)
				{
					intPtr1 = m.Result;
					i1 = intPtr1.ToInt32 ();
					if (i1 == 7)
					{
						m.Result = new IntPtr (((int) (i1 + 256)));
					}
					else if (i1 == 6)
					{
						m.Result = new IntPtr (((int) (i1 + 256)));
					}
				}
				base.AfterWndProc (ref m);
			}
			
			protected override bool BeforeWndProc (ref Message m)
			
			/*
				// Code Size: 2930 Bytes
				.maxstack 6
				.locals (System.Int32 V_0, 
         Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO V_1, 
         Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Drawing.Point V_7, 
         System.Drawing.Rectangle V_8, 
         System.UInt32 V_9, 
         System.Drawing.Point V_10, 
         System.IntPtr V_11)
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
				L_0026: callvirt Sunisoft.IrisSkin.x9c946c69c1315c4d::Boolean get_CanScroll()
				L_002b: brtrue.s L_0035
				L_002d: ldarg.0 
				L_002e: ldarg.1 
				L_002f: call Sunisoft.IrisSkin.x8917d01b98173f4c::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_0034: ret 
				L_0035: ldarg.1 
				L_0036: call System.Windows.Forms.Message::Int32 get_Msg()
				L_003b: stloc.s V_9
				L_003d: ldloc.s V_9
				L_003f: ldc.i4 277
				L_0044: bgt.un.s L_007f
				L_0046: ldloc.s V_9
				L_0048: ldc.i4.s 43
				L_004a: beq.s L_00b5
				L_004c: ldloc.s V_9
				L_004e: ldc.i4 160
				L_0053: sub 
				L_0054: switch (L_09f2, L_04e4, L_09f0)
				L_0065: ldloc.s V_9
				L_0067: ldc.i4 276
				L_006c: sub 
				L_006d: switch (L_0ad5, L_0a37)
				L_007a: br L_0b6a
				L_007f: ldloc.s V_9
				L_0081: ldc.i4 512
				L_0086: sub 
				L_0087: switch (L_00d5, L_04a0, L_04ad)
				L_0098: ldloc.s V_9
				L_009a: ldc.i4 522
				L_009f: beq L_09f4
				L_00a4: ldloc.s V_9
				L_00a6: ldc.i4 533
				L_00ab: beq L_04c3
				L_00b0: br L_0b6a
				L_00b5: ldarg.1 
				L_00b6: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_00bb: ldsfld System.IntPtr::IntPtr Zero
				L_00c0: call System.IntPtr::Boolean op_Inequality(IntPtr, IntPtr)
				L_00c5: brfalse L_0b6a
				L_00ca: ldarg.0 
				L_00cb: callvirt Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
				L_00d0: br L_0b6a
				L_00d5: ldarg.0 
				L_00d6: ldfld Sunisoft.IrisSkin.x9c946c69c1315c4d::Boolean x34ce871902cf4acd
				L_00db: brfalse L_0b6a
				L_00e0: ldc.i4.0 
				L_00e1: stloc.3 
				L_00e2: ldc.i4.0 
				L_00e3: stloc.s V_4
				L_00e5: ldc.i4.0 
				L_00e6: stloc.s V_5
				L_00e8: ldc.i4.0 
				L_00e9: stloc.s V_6
				L_00eb: ldloca.s V_2
				L_00ed: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO
				L_00f3: ldloca.s V_2
				L_00f5: ldc.i4.s 60
				L_00f7: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::UInt32 cbSize
				L_00fc: ldloca.s V_1
				L_00fe: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO
				L_0104: ldloca.s V_1
				L_0106: ldc.i4.s 28
				L_0108: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::UInt32 cbSize
				L_010d: ldloca.s V_1
				L_010f: ldc.i4.s 31
				L_0111: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::UInt32 fMask
				L_0116: ldc.i4.0 
				L_0117: ldc.i4.0 
				L_0118: ldc.i4.0 
				L_0119: ldc.i4.0 
				L_011a: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_011f: pop 
				L_0120: ldarg.0 
				L_0121: ldfld Sunisoft.IrisSkin.x9c946c69c1315c4d::UInt32 x1f25abf5fb75e795
				L_0126: ldc.i4 277
				L_012b: bne.un L_02df
				L_0130: ldarg.0 
				L_0131: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0136: ldc.i4.s -5
				L_0138: ldloca.s V_2
				L_013a: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollBarInfo(IntPtr, UInt32, SCROLLBARINFO ByRef)
				L_013f: brfalse L_0493
				L_0144: ldloca.s V_2
				L_0146: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_014b: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0150: ldloca.s V_2
				L_0152: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0157: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_015c: sub 
				L_015d: ldloca.s V_2
				L_015f: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 dxyLineButton
				L_0164: ldc.i4.2 
				L_0165: mul 
				L_0166: sub 
				L_0167: stloc.3 
				L_0168: ldloc.3 
				L_0169: ldc.i4.0 
				L_016a: ble L_0b6a
				L_016f: ldarg.0 
				L_0170: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0175: ldc.i4.1 
				L_0176: ldloca.s V_1
				L_0178: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollInfo(IntPtr, Int32, SCROLLINFO ByRef)
				L_017d: pop 
				L_017e: ldloca.s V_1
				L_0180: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMax
				L_0185: ldloca.s V_1
				L_0187: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMin
				L_018c: sub 
				L_018d: ldloca.s V_1
				L_018f: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::UInt32 nPage
				L_0194: sub 
				L_0195: ldc.i4.1 
				L_0196: add 
				L_0197: stloc.s V_4
				L_0199: call System.Windows.Forms.Control::System.Drawing.Point get_MousePosition()
				L_019e: stloc.s V_10
				L_01a0: ldloca.s V_10
				L_01a2: call System.Drawing.Point::Int32 get_Y()
				L_01a7: ldloca.s V_2
				L_01a9: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_01ae: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_01b3: sub 
				L_01b4: ldloca.s V_2
				L_01b6: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 dxyLineButton
				L_01bb: sub 
				L_01bc: ldloc.s V_4
				L_01be: mul 
				L_01bf: ldloc.3 
				L_01c0: div 
				L_01c1: ldloca.s V_1
				L_01c3: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMin
				L_01c8: add 
				L_01c9: stloc.s V_5
				L_01cb: ldloc.s V_5
				L_01cd: ldloca.s V_1
				L_01cf: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMin
				L_01d4: bge.s L_01df
				L_01d6: ldloca.s V_1
				L_01d8: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMin
				L_01dd: stloc.s V_5
				L_01df: ldloc.s V_5
				L_01e1: ldloc.s V_4
				L_01e3: ble.s L_01e9
				L_01e5: ldloc.s V_4
				L_01e7: stloc.s V_5
				L_01e9: ldarg.0 
				L_01ea: ldflda Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Drawing.Point x2aa5114a5da7d6c8
				L_01ef: call System.Drawing.Point::Int32 get_Y()
				L_01f4: ldloca.s V_2
				L_01f6: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_01fb: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0200: sub 
				L_0201: ldloca.s V_2
				L_0203: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 dxyLineButton
				L_0208: sub 
				L_0209: ldloc.s V_4
				L_020b: mul 
				L_020c: ldloc.3 
				L_020d: div 
				L_020e: pop 
				L_020f: ldloca.s V_1
				L_0211: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_0216: stloc.s V_6
				L_0218: ldarg.0 
				L_0219: ldflda Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Drawing.Point x2aa5114a5da7d6c8
				L_021e: call System.Drawing.Point::Int32 get_Y()
				L_0223: call System.Windows.Forms.Control::System.Drawing.Point get_MousePosition()
				L_0228: stloc.s V_10
				L_022a: ldloca.s V_10
				L_022c: call System.Drawing.Point::Int32 get_Y()
				L_0231: ble.s L_0276
				L_0233: br.s L_026b
				L_0235: ldarg.0 
				L_0236: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_023b: ldc.i4 277
				L_0240: ldc.i4.0 
				L_0241: ldc.i4.0 
				L_0242: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SendMessage(IntPtr, UInt32, UInt32, UInt32)
				L_0247: pop 
				L_0248: ldarg.0 
				L_0249: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_024e: ldc.i4.1 
				L_024f: ldloca.s V_1
				L_0251: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollInfo(IntPtr, Int32, SCROLLINFO ByRef)
				L_0256: pop 
				L_0257: ldloc.s V_6
				L_0259: ldloca.s V_1
				L_025b: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_0260: beq.s L_0276
				L_0262: ldloca.s V_1
				L_0264: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_0269: stloc.s V_6
				L_026b: ldloca.s V_1
				L_026d: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_0272: ldloc.s V_5
				L_0274: bgt.s L_0235
				L_0276: ldarg.0 
				L_0277: ldflda Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Drawing.Point x2aa5114a5da7d6c8
				L_027c: call System.Drawing.Point::Int32 get_Y()
				L_0281: call System.Windows.Forms.Control::System.Drawing.Point get_MousePosition()
				L_0286: stloc.s V_10
				L_0288: ldloca.s V_10
				L_028a: call System.Drawing.Point::Int32 get_Y()
				L_028f: bge L_0493
				L_0294: br.s L_02cf
				L_0296: ldarg.0 
				L_0297: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_029c: ldc.i4 277
				L_02a1: ldc.i4.1 
				L_02a2: ldc.i4.0 
				L_02a3: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SendMessage(IntPtr, UInt32, UInt32, UInt32)
				L_02a8: pop 
				L_02a9: ldarg.0 
				L_02aa: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_02af: ldc.i4.1 
				L_02b0: ldloca.s V_1
				L_02b2: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollInfo(IntPtr, Int32, SCROLLINFO ByRef)
				L_02b7: pop 
				L_02b8: ldloc.s V_6
				L_02ba: ldloca.s V_1
				L_02bc: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_02c1: beq L_0493
				L_02c6: ldloca.s V_1
				L_02c8: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_02cd: stloc.s V_6
				L_02cf: ldloca.s V_1
				L_02d1: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_02d6: ldloc.s V_5
				L_02d8: blt.s L_0296
				L_02da: br L_0493
				L_02df: ldarg.0 
				L_02e0: ldfld Sunisoft.IrisSkin.x9c946c69c1315c4d::UInt32 x1f25abf5fb75e795
				L_02e5: ldc.i4 276
				L_02ea: bne.un L_0493
				L_02ef: ldarg.0 
				L_02f0: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_02f5: ldc.i4.s -6
				L_02f7: ldloca.s V_2
				L_02f9: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollBarInfo(IntPtr, UInt32, SCROLLBARINFO ByRef)
				L_02fe: brfalse L_0493
				L_0303: ldloca.s V_2
				L_0305: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_030a: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_030f: ldloca.s V_2
				L_0311: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0316: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_031b: sub 
				L_031c: ldloca.s V_2
				L_031e: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 dxyLineButton
				L_0323: ldc.i4.2 
				L_0324: mul 
				L_0325: sub 
				L_0326: stloc.3 
				L_0327: ldloc.3 
				L_0328: ldc.i4.0 
				L_0329: ble L_0b6a
				L_032e: ldarg.0 
				L_032f: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0334: ldc.i4.0 
				L_0335: ldloca.s V_1
				L_0337: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollInfo(IntPtr, Int32, SCROLLINFO ByRef)
				L_033c: pop 
				L_033d: ldloca.s V_1
				L_033f: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMax
				L_0344: ldloca.s V_1
				L_0346: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMin
				L_034b: sub 
				L_034c: ldloca.s V_1
				L_034e: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::UInt32 nPage
				L_0353: sub 
				L_0354: ldc.i4.1 
				L_0355: add 
				L_0356: stloc.s V_4
				L_0358: call System.Windows.Forms.Control::System.Drawing.Point get_MousePosition()
				L_035d: stloc.s V_10
				L_035f: ldloca.s V_10
				L_0361: call System.Drawing.Point::Int32 get_X()
				L_0366: ldloca.s V_2
				L_0368: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_036d: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0372: sub 
				L_0373: ldloca.s V_2
				L_0375: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 dxyLineButton
				L_037a: sub 
				L_037b: ldloc.s V_4
				L_037d: mul 
				L_037e: ldloc.3 
				L_037f: div 
				L_0380: ldloca.s V_1
				L_0382: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMin
				L_0387: add 
				L_0388: stloc.s V_5
				L_038a: ldloc.s V_5
				L_038c: ldloca.s V_1
				L_038e: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMin
				L_0393: bge.s L_039e
				L_0395: ldloca.s V_1
				L_0397: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMin
				L_039c: stloc.s V_5
				L_039e: ldloc.s V_5
				L_03a0: ldloc.s V_4
				L_03a2: ble.s L_03a8
				L_03a4: ldloc.s V_4
				L_03a6: stloc.s V_5
				L_03a8: ldarg.0 
				L_03a9: ldflda Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Drawing.Point x2aa5114a5da7d6c8
				L_03ae: call System.Drawing.Point::Int32 get_X()
				L_03b3: ldloca.s V_2
				L_03b5: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_03ba: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_03bf: sub 
				L_03c0: ldloca.s V_2
				L_03c2: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 dxyLineButton
				L_03c7: sub 
				L_03c8: ldloc.s V_4
				L_03ca: mul 
				L_03cb: ldloc.3 
				L_03cc: div 
				L_03cd: pop 
				L_03ce: ldloca.s V_1
				L_03d0: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_03d5: stloc.s V_6
				L_03d7: ldarg.0 
				L_03d8: ldflda Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Drawing.Point x2aa5114a5da7d6c8
				L_03dd: call System.Drawing.Point::Int32 get_X()
				L_03e2: call System.Windows.Forms.Control::System.Drawing.Point get_MousePosition()
				L_03e7: stloc.s V_10
				L_03e9: ldloca.s V_10
				L_03eb: call System.Drawing.Point::Int32 get_X()
				L_03f0: ble.s L_0435
				L_03f2: br.s L_042a
				L_03f4: ldarg.0 
				L_03f5: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_03fa: ldc.i4 276
				L_03ff: ldc.i4.0 
				L_0400: ldc.i4.0 
				L_0401: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SendMessage(IntPtr, UInt32, UInt32, UInt32)
				L_0406: pop 
				L_0407: ldarg.0 
				L_0408: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_040d: ldc.i4.0 
				L_040e: ldloca.s V_1
				L_0410: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollInfo(IntPtr, Int32, SCROLLINFO ByRef)
				L_0415: pop 
				L_0416: ldloc.s V_6
				L_0418: ldloca.s V_1
				L_041a: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_041f: beq.s L_0435
				L_0421: ldloca.s V_1
				L_0423: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_0428: stloc.s V_6
				L_042a: ldloca.s V_1
				L_042c: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_0431: ldloc.s V_5
				L_0433: bgt.s L_03f4
				L_0435: ldarg.0 
				L_0436: ldflda Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Drawing.Point x2aa5114a5da7d6c8
				L_043b: call System.Drawing.Point::Int32 get_X()
				L_0440: call System.Windows.Forms.Control::System.Drawing.Point get_MousePosition()
				L_0445: stloc.s V_10
				L_0447: ldloca.s V_10
				L_0449: call System.Drawing.Point::Int32 get_X()
				L_044e: bge.s L_0493
				L_0450: br.s L_0488
				L_0452: ldarg.0 
				L_0453: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0458: ldc.i4 276
				L_045d: ldc.i4.1 
				L_045e: ldc.i4.0 
				L_045f: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SendMessage(IntPtr, UInt32, UInt32, UInt32)
				L_0464: pop 
				L_0465: ldarg.0 
				L_0466: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_046b: ldc.i4.0 
				L_046c: ldloca.s V_1
				L_046e: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollInfo(IntPtr, Int32, SCROLLINFO ByRef)
				L_0473: pop 
				L_0474: ldloc.s V_6
				L_0476: ldloca.s V_1
				L_0478: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_047d: beq.s L_0493
				L_047f: ldloca.s V_1
				L_0481: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_0486: stloc.s V_6
				L_0488: ldloca.s V_1
				L_048a: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_048f: ldloc.s V_5
				L_0491: blt.s L_0452
				L_0493: ldarg.0 
				L_0494: call System.Windows.Forms.Control::System.Drawing.Point get_MousePosition()
				L_0499: stfld Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Drawing.Point x2aa5114a5da7d6c8
				L_049e: ldc.i4.0 
				L_049f: ret 
				L_04a0: ldarg.0 
				L_04a1: ldfld Sunisoft.IrisSkin.x9c946c69c1315c4d::Boolean x34ce871902cf4acd
				L_04a6: brfalse L_0b6a
				L_04ab: ldc.i4.0 
				L_04ac: ret 
				L_04ad: ldarg.0 
				L_04ae: ldfld Sunisoft.IrisSkin.x9c946c69c1315c4d::Boolean x34ce871902cf4acd
				L_04b3: brfalse L_0b6a
				L_04b8: ldarg.0 
				L_04b9: call Sunisoft.IrisSkin.x9c946c69c1315c4d::Void x6139c418c50df34e()
				L_04be: br L_0b6a
				L_04c3: ldarg.1 
				L_04c4: call System.Windows.Forms.Message::IntPtr get_LParam()
				L_04c9: ldarg.0 
				L_04ca: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_04cf: call System.IntPtr::Boolean op_Inequality(IntPtr, IntPtr)
				L_04d4: brfalse L_0b6a
				L_04d9: ldarg.0 
				L_04da: call Sunisoft.IrisSkin.x9c946c69c1315c4d::Void x6139c418c50df34e()
				L_04df: br L_0b6a
				L_04e4: ldarg.1 
				L_04e5: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_04ea: stloc.s V_11
				L_04ec: ldloca.s V_11
				L_04ee: call System.IntPtr::Int32 ToInt32()
				L_04f3: stloc.0 
				L_04f4: ldloc.0 
				L_04f5: ldc.i4 256
				L_04fa: ble.s L_0504
				L_04fc: ldloc.0 
				L_04fd: ldc.i4 256
				L_0502: sub 
				L_0503: stloc.0 
				L_0504: ldloca.s V_8
				L_0506: ldc.i4.0 
				L_0507: ldc.i4.0 
				L_0508: ldc.i4.0 
				L_0509: ldc.i4.0 
				L_050a: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_050f: ldloc.0 
				L_0510: ldc.i4.7 
				L_0511: bne.un L_0780
				L_0516: ldarg.0 
				L_0517: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_051c: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SetCapture(IntPtr)
				L_0521: pop 
				L_0522: ldloca.s V_7
				L_0524: ldc.i4.0 
				L_0525: call System.Drawing.Point::Void .ctor(Int32)
				L_052a: ldloca.s V_2
				L_052c: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO
				L_0532: ldloca.s V_2
				L_0534: ldc.i4.s 60
				L_0536: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::UInt32 cbSize
				L_053b: ldloca.s V_7
				L_053d: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetCursorPos(System.Drawing.Point ByRef)
				L_0542: pop 
				L_0543: ldarg.0 
				L_0544: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0549: ldc.i4.s -5
				L_054b: ldloca.s V_2
				L_054d: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollBarInfo(IntPtr, UInt32, SCROLLBARINFO ByRef)
				L_0552: brfalse L_09ee
				L_0557: ldloca.s V_2
				L_0559: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_055e: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0563: ldloca.s V_2
				L_0565: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_056a: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_056f: ldloca.s V_2
				L_0571: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0576: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_057b: ldloca.s V_2
				L_057d: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0582: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0587: ldloca.s V_2
				L_0589: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 dxyLineButton
				L_058e: add 
				L_058f: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0594: stloc.s V_8
				L_0596: ldloc.s V_7
				L_0598: ldloc.s V_8
				L_059a: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_059f: brfalse.s L_05c4
				L_05a1: ldarg.0 
				L_05a2: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_05a7: ldc.i4 277
				L_05ac: ldc.i4.0 
				L_05ad: ldc.i4.0 
				L_05ae: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_05b3: pop 
				L_05b4: ldarg.0 
				L_05b5: ldc.i4 277
				L_05ba: ldc.i4.0 
				L_05bb: ldloc.s V_8
				L_05bd: call Sunisoft.IrisSkin.x9c946c69c1315c4d::Void x5319e78a3425ad41(UInt32, UInt32, System.Drawing.Rectangle)
				L_05c2: ldc.i4.0 
				L_05c3: ret 
				L_05c4: ldloca.s V_2
				L_05c6: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_05cb: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_05d0: ldloca.s V_2
				L_05d2: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_05d7: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_05dc: ldloca.s V_2
				L_05de: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 dxyLineButton
				L_05e3: add 
				L_05e4: ldloca.s V_2
				L_05e6: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_05eb: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_05f0: ldloca.s V_2
				L_05f2: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_05f7: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_05fc: ldloca.s V_2
				L_05fe: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbTop
				L_0603: add 
				L_0604: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0609: stloc.s V_8
				L_060b: ldloc.s V_7
				L_060d: ldloc.s V_8
				L_060f: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0614: brfalse.s L_0639
				L_0616: ldarg.0 
				L_0617: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_061c: ldc.i4 277
				L_0621: ldc.i4.2 
				L_0622: ldc.i4.0 
				L_0623: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_0628: pop 
				L_0629: ldarg.0 
				L_062a: ldc.i4 277
				L_062f: ldc.i4.2 
				L_0630: ldloc.s V_8
				L_0632: call Sunisoft.IrisSkin.x9c946c69c1315c4d::Void x5319e78a3425ad41(UInt32, UInt32, System.Drawing.Rectangle)
				L_0637: ldc.i4.0 
				L_0638: ret 
				L_0639: ldloca.s V_2
				L_063b: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0640: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0645: ldloca.s V_2
				L_0647: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_064c: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0651: ldloca.s V_2
				L_0653: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbBottom
				L_0658: add 
				L_0659: ldloca.s V_2
				L_065b: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0660: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0665: ldloca.s V_2
				L_0667: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_066c: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0671: ldloca.s V_2
				L_0673: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 dxyLineButton
				L_0678: sub 
				L_0679: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_067e: stloc.s V_8
				L_0680: ldloc.s V_7
				L_0682: ldloc.s V_8
				L_0684: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0689: brfalse.s L_06ae
				L_068b: ldarg.0 
				L_068c: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0691: ldc.i4 277
				L_0696: ldc.i4.3 
				L_0697: ldc.i4.0 
				L_0698: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_069d: pop 
				L_069e: ldarg.0 
				L_069f: ldc.i4 277
				L_06a4: ldc.i4.3 
				L_06a5: ldloc.s V_8
				L_06a7: call Sunisoft.IrisSkin.x9c946c69c1315c4d::Void x5319e78a3425ad41(UInt32, UInt32, System.Drawing.Rectangle)
				L_06ac: ldc.i4.0 
				L_06ad: ret 
				L_06ae: ldloca.s V_2
				L_06b0: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_06b5: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_06ba: ldloca.s V_2
				L_06bc: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_06c1: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_06c6: ldloca.s V_2
				L_06c8: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 dxyLineButton
				L_06cd: sub 
				L_06ce: ldloca.s V_2
				L_06d0: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_06d5: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_06da: ldloca.s V_2
				L_06dc: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_06e1: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_06e6: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_06eb: stloc.s V_8
				L_06ed: ldloc.s V_7
				L_06ef: ldloc.s V_8
				L_06f1: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_06f6: brfalse.s L_071b
				L_06f8: ldarg.0 
				L_06f9: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_06fe: ldc.i4 277
				L_0703: ldc.i4.1 
				L_0704: ldc.i4.0 
				L_0705: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_070a: pop 
				L_070b: ldarg.0 
				L_070c: ldc.i4 277
				L_0711: ldc.i4.1 
				L_0712: ldloc.s V_8
				L_0714: call Sunisoft.IrisSkin.x9c946c69c1315c4d::Void x5319e78a3425ad41(UInt32, UInt32, System.Drawing.Rectangle)
				L_0719: ldc.i4.0 
				L_071a: ret 
				L_071b: ldloca.s V_2
				L_071d: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0722: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0727: ldloca.s V_2
				L_0729: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_072e: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0733: ldloca.s V_2
				L_0735: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbTop
				L_073a: add 
				L_073b: ldloca.s V_2
				L_073d: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0742: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0747: ldloca.s V_2
				L_0749: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_074e: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0753: ldloca.s V_2
				L_0755: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbBottom
				L_075a: add 
				L_075b: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0760: stloc.s V_8
				L_0762: ldloc.s V_7
				L_0764: ldloc.s V_8
				L_0766: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_076b: brfalse L_09ee
				L_0770: ldarg.0 
				L_0771: ldc.i4 277
				L_0776: ldc.i4.5 
				L_0777: ldloc.s V_8
				L_0779: call Sunisoft.IrisSkin.x9c946c69c1315c4d::Void x5319e78a3425ad41(UInt32, UInt32, System.Drawing.Rectangle)
				L_077e: ldc.i4.0 
				L_077f: ret 
				L_0780: ldloc.0 
				L_0781: ldc.i4.6 
				L_0782: bne.un L_09ee
				L_0787: ldarg.0 
				L_0788: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_078d: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SetCapture(IntPtr)
				L_0792: pop 
				L_0793: ldloca.s V_2
				L_0795: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO
				L_079b: ldloca.s V_2
				L_079d: ldc.i4.s 60
				L_079f: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::UInt32 cbSize
				L_07a4: ldloca.s V_7
				L_07a6: ldc.i4.0 
				L_07a7: call System.Drawing.Point::Void .ctor(Int32)
				L_07ac: ldloca.s V_7
				L_07ae: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetCursorPos(System.Drawing.Point ByRef)
				L_07b3: pop 
				L_07b4: ldarg.0 
				L_07b5: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_07ba: ldc.i4.s -6
				L_07bc: ldloca.s V_2
				L_07be: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollBarInfo(IntPtr, UInt32, SCROLLBARINFO ByRef)
				L_07c3: brfalse L_09ee
				L_07c8: ldloca.s V_2
				L_07ca: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_07cf: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_07d4: ldloca.s V_2
				L_07d6: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_07db: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_07e0: ldloca.s V_2
				L_07e2: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_07e7: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_07ec: ldloca.s V_2
				L_07ee: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 dxyLineButton
				L_07f3: add 
				L_07f4: ldloca.s V_2
				L_07f6: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_07fb: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0800: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0805: stloc.s V_8
				L_0807: ldloc.s V_7
				L_0809: ldloc.s V_8
				L_080b: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0810: brfalse.s L_0835
				L_0812: ldarg.0 
				L_0813: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0818: ldc.i4 276
				L_081d: ldc.i4.0 
				L_081e: ldc.i4.0 
				L_081f: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_0824: pop 
				L_0825: ldarg.0 
				L_0826: ldc.i4 276
				L_082b: ldc.i4.0 
				L_082c: ldloc.s V_8
				L_082e: call Sunisoft.IrisSkin.x9c946c69c1315c4d::Void x5319e78a3425ad41(UInt32, UInt32, System.Drawing.Rectangle)
				L_0833: ldc.i4.0 
				L_0834: ret 
				L_0835: ldloca.s V_2
				L_0837: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_083c: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0841: ldloca.s V_2
				L_0843: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 dxyLineButton
				L_0848: add 
				L_0849: ldloca.s V_2
				L_084b: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0850: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0855: ldloca.s V_2
				L_0857: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_085c: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0861: ldloca.s V_2
				L_0863: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbTop
				L_0868: add 
				L_0869: ldloca.s V_2
				L_086b: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0870: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0875: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_087a: stloc.s V_8
				L_087c: ldloc.s V_7
				L_087e: ldloc.s V_8
				L_0880: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0885: brfalse.s L_08aa
				L_0887: ldarg.0 
				L_0888: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_088d: ldc.i4 276
				L_0892: ldc.i4.2 
				L_0893: ldc.i4.0 
				L_0894: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_0899: pop 
				L_089a: ldarg.0 
				L_089b: ldc.i4 276
				L_08a0: ldc.i4.2 
				L_08a1: ldloc.s V_8
				L_08a3: call Sunisoft.IrisSkin.x9c946c69c1315c4d::Void x5319e78a3425ad41(UInt32, UInt32, System.Drawing.Rectangle)
				L_08a8: ldc.i4.0 
				L_08a9: ret 
				L_08aa: ldloca.s V_2
				L_08ac: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_08b1: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_08b6: ldloca.s V_2
				L_08b8: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbBottom
				L_08bd: add 
				L_08be: ldloca.s V_2
				L_08c0: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_08c5: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_08ca: ldloca.s V_2
				L_08cc: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_08d1: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_08d6: ldloca.s V_2
				L_08d8: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 dxyLineButton
				L_08dd: sub 
				L_08de: ldloca.s V_2
				L_08e0: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_08e5: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_08ea: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_08ef: stloc.s V_8
				L_08f1: ldloc.s V_7
				L_08f3: ldloc.s V_8
				L_08f5: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_08fa: brfalse.s L_091f
				L_08fc: ldarg.0 
				L_08fd: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0902: ldc.i4 276
				L_0907: ldc.i4.3 
				L_0908: ldc.i4.0 
				L_0909: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_090e: pop 
				L_090f: ldarg.0 
				L_0910: ldc.i4 276
				L_0915: ldc.i4.3 
				L_0916: ldloc.s V_8
				L_0918: call Sunisoft.IrisSkin.x9c946c69c1315c4d::Void x5319e78a3425ad41(UInt32, UInt32, System.Drawing.Rectangle)
				L_091d: ldc.i4.0 
				L_091e: ret 
				L_091f: ldloca.s V_2
				L_0921: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0926: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_092b: ldloca.s V_2
				L_092d: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 dxyLineButton
				L_0932: sub 
				L_0933: ldloca.s V_2
				L_0935: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_093a: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_093f: ldloca.s V_2
				L_0941: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0946: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_094b: ldloca.s V_2
				L_094d: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0952: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0957: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_095c: stloc.s V_8
				L_095e: ldloc.s V_7
				L_0960: ldloc.s V_8
				L_0962: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0967: brfalse.s L_098c
				L_0969: ldarg.0 
				L_096a: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_096f: ldc.i4 276
				L_0974: ldc.i4.1 
				L_0975: ldc.i4.0 
				L_0976: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_097b: pop 
				L_097c: ldarg.0 
				L_097d: ldc.i4 276
				L_0982: ldc.i4.1 
				L_0983: ldloc.s V_8
				L_0985: call Sunisoft.IrisSkin.x9c946c69c1315c4d::Void x5319e78a3425ad41(UInt32, UInt32, System.Drawing.Rectangle)
				L_098a: ldc.i4.0 
				L_098b: ret 
				L_098c: ldloca.s V_2
				L_098e: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0993: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0998: ldloca.s V_2
				L_099a: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbTop
				L_099f: add 
				L_09a0: ldloca.s V_2
				L_09a2: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_09a7: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_09ac: ldloca.s V_2
				L_09ae: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_09b3: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_09b8: ldloca.s V_2
				L_09ba: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbBottom
				L_09bf: add 
				L_09c0: ldloca.s V_2
				L_09c2: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_09c7: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_09cc: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_09d1: stloc.s V_8
				L_09d3: ldloc.s V_7
				L_09d5: ldloc.s V_8
				L_09d7: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_09dc: brfalse.s L_09ee
				L_09de: ldarg.0 
				L_09df: ldc.i4 276
				L_09e4: ldc.i4.5 
				L_09e5: ldloc.s V_8
				L_09e7: call Sunisoft.IrisSkin.x9c946c69c1315c4d::Void x5319e78a3425ad41(UInt32, UInt32, System.Drawing.Rectangle)
				L_09ec: ldc.i4.0 
				L_09ed: ret 
				L_09ee: ldc.i4.0 
				L_09ef: ret 
				L_09f0: ldc.i4.0 
				L_09f1: ret 
				L_09f2: ldc.i4.0 
				L_09f3: ret 
				L_09f4: ldarg.1 
				L_09f5: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_09fa: stloc.s V_11
				L_09fc: ldloca.s V_11
				L_09fe: call System.IntPtr::Int32 ToInt32()
				L_0a03: stloc.0 
				L_0a04: ldloc.0 
				L_0a05: ldc.i4.s 16
				L_0a07: shr 
				L_0a08: stloc.0 
				L_0a09: ldloc.0 
				L_0a0a: ldc.i4.0 
				L_0a0b: ble.s L_0a22
				L_0a0d: ldarg.0 
				L_0a0e: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0a13: ldc.i4 277
				L_0a18: ldc.i4.2 
				L_0a19: ldc.i4.0 
				L_0a1a: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_0a1f: pop 
				L_0a20: br.s L_0a35
				L_0a22: ldarg.0 
				L_0a23: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0a28: ldc.i4 277
				L_0a2d: ldc.i4.3 
				L_0a2e: ldc.i4.0 
				L_0a2f: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_0a34: pop 
				L_0a35: ldc.i4.0 
				L_0a36: ret 
				L_0a37: ldarg.1 
				L_0a38: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_0a3d: stloc.s V_11
				L_0a3f: ldloca.s V_11
				L_0a41: call System.IntPtr::Int32 ToInt32()
				L_0a46: stloc.0 
				L_0a47: ldloc.0 
				L_0a48: conv.i8 
				L_0a49: ldc.i4.5 
				L_0a4a: conv.i8 
				L_0a4b: and 
				L_0a4c: ldc.i4.5 
				L_0a4d: conv.i8 
				L_0a4e: beq L_0b6a
				L_0a53: ldloca.s V_1
				L_0a55: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO
				L_0a5b: ldloca.s V_1
				L_0a5d: ldc.i4.s 28
				L_0a5f: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::UInt32 cbSize
				L_0a64: ldloca.s V_1
				L_0a66: ldc.i4.s 31
				L_0a68: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::UInt32 fMask
				L_0a6d: ldarg.0 
				L_0a6e: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0a73: ldc.i4.1 
				L_0a74: ldloca.s V_1
				L_0a76: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollInfo(IntPtr, Int32, SCROLLINFO ByRef)
				L_0a7b: pop 
				L_0a7c: ldloc.0 
				L_0a7d: conv.i8 
				L_0a7e: ldc.i4.0 
				L_0a7f: conv.i8 
				L_0a80: beq.s L_0a88
				L_0a82: ldloc.0 
				L_0a83: conv.i8 
				L_0a84: ldc.i4.2 
				L_0a85: conv.i8 
				L_0a86: bne.un.s L_0a9d
				L_0a88: ldloca.s V_1
				L_0a8a: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_0a8f: ldloca.s V_1
				L_0a91: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMin
				L_0a96: bgt L_0b6a
				L_0a9b: ldc.i4.0 
				L_0a9c: ret 
				L_0a9d: ldloc.0 
				L_0a9e: conv.i8 
				L_0a9f: ldc.i4.1 
				L_0aa0: conv.i8 
				L_0aa1: beq.s L_0aac
				L_0aa3: ldloc.0 
				L_0aa4: conv.i8 
				L_0aa5: ldc.i4.3 
				L_0aa6: conv.i8 
				L_0aa7: bne.un L_0b6a
				L_0aac: ldloca.s V_1
				L_0aae: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_0ab3: conv.i8 
				L_0ab4: ldloca.s V_1
				L_0ab6: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMax
				L_0abb: conv.i8 
				L_0abc: ldloca.s V_1
				L_0abe: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::UInt32 nPage
				L_0ac3: conv.u8 
				L_0ac4: sub 
				L_0ac5: ldloca.s V_1
				L_0ac7: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMin
				L_0acc: conv.i8 
				L_0acd: sub 
				L_0ace: ble L_0b6a
				L_0ad3: ldc.i4.0 
				L_0ad4: ret 
				L_0ad5: ldarg.1 
				L_0ad6: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_0adb: stloc.s V_11
				L_0add: ldloca.s V_11
				L_0adf: call System.IntPtr::Int32 ToInt32()
				L_0ae4: stloc.0 
				L_0ae5: ldloc.0 
				L_0ae6: conv.i8 
				L_0ae7: ldc.i4.5 
				L_0ae8: conv.i8 
				L_0ae9: and 
				L_0aea: ldc.i4.5 
				L_0aeb: conv.i8 
				L_0aec: beq L_0b6a
				L_0af1: ldloca.s V_1
				L_0af3: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO
				L_0af9: ldloca.s V_1
				L_0afb: ldc.i4.s 28
				L_0afd: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::UInt32 cbSize
				L_0b02: ldloca.s V_1
				L_0b04: ldc.i4.s 31
				L_0b06: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::UInt32 fMask
				L_0b0b: ldarg.0 
				L_0b0c: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0b11: ldc.i4.0 
				L_0b12: ldloca.s V_1
				L_0b14: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollInfo(IntPtr, Int32, SCROLLINFO ByRef)
				L_0b19: pop 
				L_0b1a: ldloc.0 
				L_0b1b: conv.i8 
				L_0b1c: ldc.i4.0 
				L_0b1d: conv.i8 
				L_0b1e: beq.s L_0b26
				L_0b20: ldloc.0 
				L_0b21: conv.i8 
				L_0b22: ldc.i4.2 
				L_0b23: conv.i8 
				L_0b24: bne.un.s L_0b38
				L_0b26: ldloca.s V_1
				L_0b28: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_0b2d: ldloca.s V_1
				L_0b2f: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMin
				L_0b34: bgt.s L_0b6a
				L_0b36: ldc.i4.0 
				L_0b37: ret 
				L_0b38: ldloc.0 
				L_0b39: conv.i8 
				L_0b3a: ldc.i4.1 
				L_0b3b: conv.i8 
				L_0b3c: beq.s L_0b44
				L_0b3e: ldloc.0 
				L_0b3f: conv.i8 
				L_0b40: ldc.i4.3 
				L_0b41: conv.i8 
				L_0b42: bne.un.s L_0b6a
				L_0b44: ldloca.s V_1
				L_0b46: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nPos
				L_0b4b: conv.i8 
				L_0b4c: ldloca.s V_1
				L_0b4e: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMax
				L_0b53: conv.i8 
				L_0b54: ldloca.s V_1
				L_0b56: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::UInt32 nPage
				L_0b5b: conv.u8 
				L_0b5c: sub 
				L_0b5d: ldloca.s V_1
				L_0b5f: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLINFO::Int32 nMin
				L_0b64: conv.i8 
				L_0b65: sub 
				L_0b66: ble.s L_0b6a
				L_0b68: ldc.i4.0 
				L_0b69: ret 
				L_0b6a: ldarg.0 
				L_0b6b: ldarg.1 
				L_0b6c: call Sunisoft.IrisSkin.x8917d01b98173f4c::Boolean BeforeWndProc(System.Windows.Forms.Message ByRef)
				L_0b71: ret 
			*/
			
			
			{
				int i1;
				x40255b11ef821fa3.SCROLLINFO sCROLLINFO1;
				x40255b11ef821fa3.SCROLLBARINFO sCROLLBARINFO1;
				int i2;
				int i3;
				int i4;
				int i5;
				Point point1;
				Rectangle rectangle1;
				uint uInt32_1;
				IntPtr intPtr1;
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
				uInt32_1 = ((uint) m.Msg);
				if (uInt32_1 < 277)
				{
					if (uInt32_1 != 43)
					{
						switch ((int) uInt32_1)
						{
							case 160:
							
							{
									return false;
							}
							case 161:
							
							{
									intPtr1 = m.WParam;
									i1 = intPtr1.ToInt32 ();
									if (i1 <= 256)
									{
										goto L_0504;
									}
									i1 -= 256;
									goto L_0504;
							}
							case 162:
							
							{
									return false;
							}
							case 276:
							
							{
									intPtr1 = m.WParam;
									i1 = intPtr1.ToInt32 ();
									if ((((long) i1) & ((long) 5)) == ((long) 5))
									{
										return base.BeforeWndProc (ref m);
									}
									sCROLLINFO1 = new x40255b11ef821fa3.SCROLLINFO ();
									sCROLLINFO1.cbSize = 28;
									sCROLLINFO1.fMask = 31;
									bool b20 = x61467fe65a98f20c.GetScrollInfo (base.Handle, 0, ref sCROLLINFO1);
									if ((((long) i1) != ((long) 0)) && (((long) i1) != ((long) 2)))
									{
										if ((((long) i1) != ((long) 1)) && (((long) i1) != ((long) 3)))
										{
											return base.BeforeWndProc (ref m);
										}
										else if (((long) sCROLLINFO1.nPos) <= ((((long) sCROLLINFO1.nMax) - ((long) sCROLLINFO1.nPage)) - ((long) sCROLLINFO1.nMin)))
										{
											return base.BeforeWndProc (ref m);
										}
										else
										{
											return false;
										}
									}
									if (sCROLLINFO1.nPos > sCROLLINFO1.nMin)
									{
										return base.BeforeWndProc (ref m);
									}
									else
									{
										return false;
									}
							}
							case 277:
							
							{
									intPtr1 = m.WParam;
									i1 = intPtr1.ToInt32 ();
									if ((((long) i1) & ((long) 5)) == ((long) 5))
									{
										return base.BeforeWndProc (ref m);
									}
									sCROLLINFO1 = new x40255b11ef821fa3.SCROLLINFO ();
									sCROLLINFO1.cbSize = 28;
									sCROLLINFO1.fMask = 31;
									bool b19 = x61467fe65a98f20c.GetScrollInfo (base.Handle, 1, ref sCROLLINFO1);
									if ((((long) i1) != ((long) 0)) && (((long) i1) != ((long) 2)))
									{
										if ((((long) i1) != ((long) 1)) && (((long) i1) != ((long) 3)))
										{
											return base.BeforeWndProc (ref m);
										}
										else if (((long) sCROLLINFO1.nPos) <= ((((long) sCROLLINFO1.nMax) - ((long) sCROLLINFO1.nPage)) - ((long) sCROLLINFO1.nMin)))
										{
											return base.BeforeWndProc (ref m);
										}
										else
										{
											return false;
										}
									}
									if (sCROLLINFO1.nPos > sCROLLINFO1.nMin)
									{
										return base.BeforeWndProc (ref m);
									}
									else
									{
										return false;
									}
							}
						}
					}
					else if (m.WParam != IntPtr.Zero)
					{
						this.PaintControl ();
					}
					return base.BeforeWndProc (ref m);
				}
				switch ((int) uInt32_1)
				{
					case 512:
					
					{
							if (! this.x34ce871902cf4acd)
							{
								return base.BeforeWndProc (ref m);
							}
							i2 = 0;
							i3 = 0;
							i4 = 0;
							i5 = 0;
							sCROLLBARINFO1 = new x40255b11ef821fa3.SCROLLBARINFO ();
							sCROLLBARINFO1.cbSize = 60;
							sCROLLINFO1 = new x40255b11ef821fa3.SCROLLINFO ();
							sCROLLINFO1.cbSize = 28;
							sCROLLINFO1.fMask = 31;
							Rectangle rectangle2 = new Rectangle (0, 0, 0, 0);
							if (this.x1f25abf5fb75e795 != 277)
							{
								if ((this.x1f25abf5fb75e795 != 276) || (! x61467fe65a98f20c.GetScrollBarInfo (base.Handle, ((uint) 0x00FA), ref sCROLLBARINFO1)))
								{
									goto L_0493;
								}
								i2 = ((sCROLLBARINFO1.rcScrollBar.right - sCROLLBARINFO1.rcScrollBar.left) - (sCROLLBARINFO1.dxyLineButton * 2));
								if (i2 <= 0)
								{
									return base.BeforeWndProc (ref m);
								}
								bool b4 = x61467fe65a98f20c.GetScrollInfo (base.Handle, 0, ref sCROLLINFO1);
								i3 = (((sCROLLINFO1.nMax - sCROLLINFO1.nMin) - ((int) sCROLLINFO1.nPage)) + 1);
								i4 = (((((Control.MousePosition.X - sCROLLBARINFO1.rcScrollBar.left) - sCROLLBARINFO1.dxyLineButton) * i3) / i2) + sCROLLINFO1.nMin);
								if (i4 >= sCROLLINFO1.nMin)
								{
									goto L_039E;
								}
								i4 = sCROLLINFO1.nMin;
								goto L_039E;
							}
							if (! x61467fe65a98f20c.GetScrollBarInfo (base.Handle, ((uint) 0x00FB), ref sCROLLBARINFO1))
							{
								goto L_0493;
							}
							i2 = ((sCROLLBARINFO1.rcScrollBar.bottom - sCROLLBARINFO1.rcScrollBar.top) - (sCROLLBARINFO1.dxyLineButton * 2));
							if (i2 <= 0)
							{
								return base.BeforeWndProc (ref m);
							}
							bool b1 = x61467fe65a98f20c.GetScrollInfo (base.Handle, 1, ref sCROLLINFO1);
							i3 = (((sCROLLINFO1.nMax - sCROLLINFO1.nMin) - ((int) sCROLLINFO1.nPage)) + 1);
							i4 = (((((Control.MousePosition.Y - sCROLLBARINFO1.rcScrollBar.top) - sCROLLBARINFO1.dxyLineButton) * i3) / i2) + sCROLLINFO1.nMin);
							if (i4 >= sCROLLINFO1.nMin)
							{
								goto L_01DF;
							}
							i4 = sCROLLINFO1.nMin;
							goto L_01DF;
					}
					case 513:
					
					{
							if (! this.x34ce871902cf4acd)
							{
								return base.BeforeWndProc (ref m);
							}
							else
							{
								return false;
							}
					}
					case 514:
					
					{
							if (this.x34ce871902cf4acd)
							{
								this.x6139c418c50df34e ();
							}
							return base.BeforeWndProc (ref m);
					}
				}
				if (uInt32_1 == 522)
				{
					intPtr1 = m.WParam;
					i1 = intPtr1.ToInt32 ();
					i1 = ((int) (i1 >> 16));
					if (i1 <= 0)
					{
						bool b18 = x61467fe65a98f20c.PostMessage (base.Handle, 277, 3, uint.MinValue);
					}
					else
					{
						bool b17 = x61467fe65a98f20c.PostMessage (base.Handle, 277, 2, uint.MinValue);
					}
					return false;
				}
				if (uInt32_1 == 533)
				{
					if (m.LParam != base.Handle)
					{
						this.x6139c418c50df34e ();
					}
					return base.BeforeWndProc (ref m);
				}
				return base.BeforeWndProc (ref m);
				
			L_01DF:
				
				{
				}
				if (i4 > i3)
				{
					i4 = i3;
				}
				int i6 = ((((this.x2aa5114a5da7d6c8.Y - sCROLLBARINFO1.rcScrollBar.top) - sCROLLBARINFO1.dxyLineButton) * i3) / i2);
				i5 = sCROLLINFO1.nPos;
				if (this.x2aa5114a5da7d6c8.Y > Control.MousePosition.Y)
				{
					while (sCROLLINFO1.nPos > i4)
					{
						IntPtr intPtr2 = x61467fe65a98f20c.SendMessage (base.Handle, 277, uint.MinValue, uint.MinValue);
						bool b2 = x61467fe65a98f20c.GetScrollInfo (base.Handle, 1, ref sCROLLINFO1);
						if (i5 == sCROLLINFO1.nPos)
						{
							break;
						}
						i5 = sCROLLINFO1.nPos;
					}
				}
				if (this.x2aa5114a5da7d6c8.Y < Control.MousePosition.Y)
				{
					while (sCROLLINFO1.nPos < i4)
					{
						IntPtr intPtr3 = x61467fe65a98f20c.SendMessage (base.Handle, 277, 1, uint.MinValue);
						bool b3 = x61467fe65a98f20c.GetScrollInfo (base.Handle, 1, ref sCROLLINFO1);
						if (i5 == sCROLLINFO1.nPos)
						{
							break;
						}
						i5 = sCROLLINFO1.nPos;
					}
				}
				goto L_0493;
				
			L_039E:
				
				{
				}
				if (i4 > i3)
				{
					i4 = i3;
				}
				int i7 = ((((this.x2aa5114a5da7d6c8.X - sCROLLBARINFO1.rcScrollBar.left) - sCROLLBARINFO1.dxyLineButton) * i3) / i2);
				i5 = sCROLLINFO1.nPos;
				if (this.x2aa5114a5da7d6c8.X > Control.MousePosition.X)
				{
					while (sCROLLINFO1.nPos > i4)
					{
						IntPtr intPtr4 = x61467fe65a98f20c.SendMessage (base.Handle, 276, uint.MinValue, uint.MinValue);
						bool b5 = x61467fe65a98f20c.GetScrollInfo (base.Handle, 0, ref sCROLLINFO1);
						if (i5 == sCROLLINFO1.nPos)
						{
							break;
						}
						i5 = sCROLLINFO1.nPos;
					}
				}
				if (this.x2aa5114a5da7d6c8.X < Control.MousePosition.X)
				{
					while (sCROLLINFO1.nPos < i4)
					{
						IntPtr intPtr5 = x61467fe65a98f20c.SendMessage (base.Handle, 276, 1, uint.MinValue);
						bool b6 = x61467fe65a98f20c.GetScrollInfo (base.Handle, 0, ref sCROLLINFO1);
						if (i5 == sCROLLINFO1.nPos)
						{
							break;
						}
						i5 = sCROLLINFO1.nPos;
					}
				}
				
			L_0493:
				
				{
				}
				this.x2aa5114a5da7d6c8 = Control.MousePosition;
				return false;
				
			L_0504:
				
				{
				}
				rectangle1 = new Rectangle (0, 0, 0, 0);
				if (i1 == 7)
				{
					IntPtr intPtr6 = x61467fe65a98f20c.SetCapture (base.Handle);
					point1 = new Point (0);
					sCROLLBARINFO1 = new x40255b11ef821fa3.SCROLLBARINFO ();
					sCROLLBARINFO1.cbSize = 60;
					bool b7 = x61467fe65a98f20c.GetCursorPos (ref point1);
					if (! x61467fe65a98f20c.GetScrollBarInfo (base.Handle, ((uint) 0x00FB), ref sCROLLBARINFO1))
					{
						return false;
					}
					else
					{
						rectangle1 = Rectangle.FromLTRB (sCROLLBARINFO1.rcScrollBar.left, sCROLLBARINFO1.rcScrollBar.top, sCROLLBARINFO1.rcScrollBar.right, ((int) (sCROLLBARINFO1.rcScrollBar.top + sCROLLBARINFO1.dxyLineButton)));
						if (x448fd9ab43628c71.x9466a6be27202526 (point1, rectangle1))
						{
							bool b8 = x61467fe65a98f20c.PostMessage (base.Handle, 277, uint.MinValue, uint.MinValue);
							this.x5319e78a3425ad41 (277, uint.MinValue, rectangle1);
							return false;
						}
						else
						{
							rectangle1 = Rectangle.FromLTRB (sCROLLBARINFO1.rcScrollBar.left, ((int) (sCROLLBARINFO1.rcScrollBar.top + sCROLLBARINFO1.dxyLineButton)), sCROLLBARINFO1.rcScrollBar.right, ((int) (sCROLLBARINFO1.rcScrollBar.top + sCROLLBARINFO1.xyThumbTop)));
							if (x448fd9ab43628c71.x9466a6be27202526 (point1, rectangle1))
							{
								bool b9 = x61467fe65a98f20c.PostMessage (base.Handle, 277, 2, uint.MinValue);
								this.x5319e78a3425ad41 (277, 2, rectangle1);
								return false;
							}
							else
							{
								rectangle1 = Rectangle.FromLTRB (sCROLLBARINFO1.rcScrollBar.left, ((int) (sCROLLBARINFO1.rcScrollBar.top + sCROLLBARINFO1.xyThumbBottom)), sCROLLBARINFO1.rcScrollBar.right, ((int) (sCROLLBARINFO1.rcScrollBar.bottom - sCROLLBARINFO1.dxyLineButton)));
								if (x448fd9ab43628c71.x9466a6be27202526 (point1, rectangle1))
								{
									bool b10 = x61467fe65a98f20c.PostMessage (base.Handle, 277, 3, uint.MinValue);
									this.x5319e78a3425ad41 (277, 3, rectangle1);
									return false;
								}
								else
								{
									rectangle1 = Rectangle.FromLTRB (sCROLLBARINFO1.rcScrollBar.left, ((int) (sCROLLBARINFO1.rcScrollBar.bottom - sCROLLBARINFO1.dxyLineButton)), sCROLLBARINFO1.rcScrollBar.right, sCROLLBARINFO1.rcScrollBar.bottom);
									if (x448fd9ab43628c71.x9466a6be27202526 (point1, rectangle1))
									{
										bool b11 = x61467fe65a98f20c.PostMessage (base.Handle, 277, 1, uint.MinValue);
										this.x5319e78a3425ad41 (277, 1, rectangle1);
										return false;
									}
									else
									{
										rectangle1 = Rectangle.FromLTRB (sCROLLBARINFO1.rcScrollBar.left, ((int) (sCROLLBARINFO1.rcScrollBar.top + sCROLLBARINFO1.xyThumbTop)), sCROLLBARINFO1.rcScrollBar.right, ((int) (sCROLLBARINFO1.rcScrollBar.top + sCROLLBARINFO1.xyThumbBottom)));
										if (! x448fd9ab43628c71.x9466a6be27202526 (point1, rectangle1))
										{
											return false;
										}
										else
										{
											this.x5319e78a3425ad41 (277, 5, rectangle1);
											return false;
										}
									}
								}
							}
						}
					}
				}
				if (i1 != 6)
				{
					return false;
				}
				else
				{
					IntPtr intPtr7 = x61467fe65a98f20c.SetCapture (base.Handle);
					sCROLLBARINFO1 = new x40255b11ef821fa3.SCROLLBARINFO ();
					sCROLLBARINFO1.cbSize = 60;
					point1 = new Point (0);
					bool b12 = x61467fe65a98f20c.GetCursorPos (ref point1);
					if (! x61467fe65a98f20c.GetScrollBarInfo (base.Handle, ((uint) 0x00FA), ref sCROLLBARINFO1))
					{
						return false;
					}
					else
					{
						rectangle1 = Rectangle.FromLTRB (sCROLLBARINFO1.rcScrollBar.left, sCROLLBARINFO1.rcScrollBar.top, ((int) (sCROLLBARINFO1.rcScrollBar.left + sCROLLBARINFO1.dxyLineButton)), sCROLLBARINFO1.rcScrollBar.bottom);
						if (x448fd9ab43628c71.x9466a6be27202526 (point1, rectangle1))
						{
							bool b13 = x61467fe65a98f20c.PostMessage (base.Handle, 276, uint.MinValue, uint.MinValue);
							this.x5319e78a3425ad41 (276, uint.MinValue, rectangle1);
							return false;
						}
						else
						{
							rectangle1 = Rectangle.FromLTRB (((int) (sCROLLBARINFO1.rcScrollBar.left + sCROLLBARINFO1.dxyLineButton)), sCROLLBARINFO1.rcScrollBar.top, ((int) (sCROLLBARINFO1.rcScrollBar.left + sCROLLBARINFO1.xyThumbTop)), sCROLLBARINFO1.rcScrollBar.bottom);
							if (x448fd9ab43628c71.x9466a6be27202526 (point1, rectangle1))
							{
								bool b14 = x61467fe65a98f20c.PostMessage (base.Handle, 276, 2, uint.MinValue);
								this.x5319e78a3425ad41 (276, 2, rectangle1);
								return false;
							}
							else
							{
								rectangle1 = Rectangle.FromLTRB (((int) (sCROLLBARINFO1.rcScrollBar.left + sCROLLBARINFO1.xyThumbBottom)), sCROLLBARINFO1.rcScrollBar.top, ((int) (sCROLLBARINFO1.rcScrollBar.right - sCROLLBARINFO1.dxyLineButton)), sCROLLBARINFO1.rcScrollBar.bottom);
								if (x448fd9ab43628c71.x9466a6be27202526 (point1, rectangle1))
								{
									bool b15 = x61467fe65a98f20c.PostMessage (base.Handle, 276, 3, uint.MinValue);
									this.x5319e78a3425ad41 (276, 3, rectangle1);
									return false;
								}
								else
								{
									rectangle1 = Rectangle.FromLTRB (((int) (sCROLLBARINFO1.rcScrollBar.right - sCROLLBARINFO1.dxyLineButton)), sCROLLBARINFO1.rcScrollBar.top, sCROLLBARINFO1.rcScrollBar.right, sCROLLBARINFO1.rcScrollBar.bottom);
									if (x448fd9ab43628c71.x9466a6be27202526 (point1, rectangle1))
									{
										bool b16 = x61467fe65a98f20c.PostMessage (base.Handle, 276, 1, uint.MinValue);
										this.x5319e78a3425ad41 (276, 1, rectangle1);
										return false;
									}
									else
									{
										rectangle1 = Rectangle.FromLTRB (((int) (sCROLLBARINFO1.rcScrollBar.left + sCROLLBARINFO1.xyThumbTop)), sCROLLBARINFO1.rcScrollBar.top, ((int) (sCROLLBARINFO1.rcScrollBar.left + sCROLLBARINFO1.xyThumbBottom)), sCROLLBARINFO1.rcScrollBar.bottom);
										if (! x448fd9ab43628c71.x9466a6be27202526 (point1, rectangle1))
										{
											return false;
										}
										else
										{
											this.x5319e78a3425ad41 (276, 5, rectangle1);
											return false;
										}
									}
								}
							}
						}
					}
				}
			}
			
			protected override void DoInit ()
			
			/*
				// Code Size: 54 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x8917d01b98173f4c::Void DoInit()
				L_0006: ldarg.0 
				L_0007: ldfld Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Windows.Forms.Timer x420067493d7ebb36
				L_000c: ldc.i4.s 100
				L_000e: callvirt System.Windows.Forms.Timer::Void set_Interval(Int32)
				L_0013: ldarg.0 
				L_0014: ldfld Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Windows.Forms.Timer x420067493d7ebb36
				L_0019: callvirt System.Windows.Forms.Timer::Void Stop()
				L_001e: ldarg.0 
				L_001f: ldfld Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Windows.Forms.Timer x420067493d7ebb36
				L_0024: ldarg.0 
				L_0025: ldftn Sunisoft.IrisSkin.x9c946c69c1315c4d::Void x8605d09b86ce01b1(System.Object, System.EventArgs)
				L_002b: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0030: callvirt System.Windows.Forms.Timer::Void add_Tick(System.EventHandler)
				L_0035: ret 
			*/
			
			
			{
				base.DoInit ();
				this.x420067493d7ebb36.Interval = 100;
				this.x420067493d7ebb36.Stop ();
				this.x420067493d7ebb36.Tick += new EventHandler (this.x8605d09b86ce01b1);
			}
			
			protected override void PaintControl ()
			
			/*
				// Code Size: 818 Bytes
				.maxstack 9
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO V_0, 
         System.IntPtr V_1, 
         Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_2, 
         System.Drawing.Rectangle V_3, 
         System.Int32 V_4, 
         System.Drawing.Bitmap V_5, 
         System.Drawing.Graphics V_6, 
         System.Drawing.Graphics V_7, 
         System.Drawing.Bitmap V_8, 
         System.Drawing.Graphics V_9, 
         System.Drawing.Graphics V_10, 
         System.Drawing.Rectangle V_11)
				.try L_015f to L_01ad finally L_01ad to L_01b9
				.try L_01c1 to L_01da finally L_01da to L_01e6
				.try L_0156 to L_01e8 finally L_01e8 to L_01f4
				.try L_02bb to L_02dd finally L_02dd to L_02e9
				.try L_02f1 to L_030a finally L_030a to L_0316
				.try L_02b2 to L_0318 finally L_0318 to L_0324
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_000b: stloc.s V_11
				L_000d: ldloca.s V_11
				L_000f: call System.Drawing.Rectangle::Int32 get_Width()
				L_0014: ldc.i4.0 
				L_0015: ble.s L_002e
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001d: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0022: stloc.s V_11
				L_0024: ldloca.s V_11
				L_0026: call System.Drawing.Rectangle::Int32 get_Height()
				L_002b: ldc.i4.0 
				L_002c: bgt.s L_002f
				L_002e: ret 
				L_002f: ldarg.0 
				L_0030: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0035: brtrue.s L_0038
				L_0037: ret 
				L_0038: ldarg.0 
				L_0039: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_003e: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_SkinScrollBar()
				L_0043: brtrue.s L_0046
				L_0045: ret 
				L_0046: ldarg.0 
				L_0047: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Void PaintControl()
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
				L_0082: ldarg.0 
				L_0083: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0088: ldc.i4.s -5
				L_008a: ldloca.s V_0
				L_008c: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollBarInfo(IntPtr, UInt32, SCROLLBARINFO ByRef)
				L_0091: brfalse L_01f4
				L_0096: ldloca.s V_3
				L_0098: ldloca.s V_0
				L_009a: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_009f: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_00a4: ldloca.s V_2
				L_00a6: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_00ab: sub 
				L_00ac: ldloca.s V_0
				L_00ae: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00b3: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_00b8: ldloca.s V_2
				L_00ba: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_00bf: sub 
				L_00c0: ldloca.s V_0
				L_00c2: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00c7: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_00cc: ldloca.s V_0
				L_00ce: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00d3: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_00d8: sub 
				L_00d9: ldloca.s V_0
				L_00db: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00e0: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_00e5: ldloca.s V_0
				L_00e7: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00ec: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_00f1: sub 
				L_00f2: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00f7: ldloca.s V_3
				L_00f9: call System.Drawing.Rectangle::Int32 get_X()
				L_00fe: ldc.i4.0 
				L_00ff: blt L_01f4
				L_0104: ldloca.s V_3
				L_0106: call System.Drawing.Rectangle::Int32 get_Y()
				L_010b: ldc.i4.0 
				L_010c: blt L_01f4
				L_0111: ldloca.s V_3
				L_0113: call System.Drawing.Rectangle::Int32 get_Width()
				L_0118: ldc.i4.0 
				L_0119: ble L_01f4
				L_011e: ldloca.s V_3
				L_0120: call System.Drawing.Rectangle::Int32 get_Height()
				L_0125: ldc.i4.0 
				L_0126: ble L_01f4
				L_012b: ldloca.s V_3
				L_012d: call System.Drawing.Rectangle::Int32 get_Width()
				L_0132: ldloca.s V_3
				L_0134: call System.Drawing.Rectangle::Int32 get_Height()
				L_0139: ldarg.0 
				L_013a: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_013f: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0144: add 
				L_0145: ldloca.s V_3
				L_0147: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_014c: sub 
				L_014d: ldc.i4.1 
				L_014e: sub 
				L_014f: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0154: stloc.s V_5
				L_0156: ldloc.s V_5
				L_0158: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_015d: stloc.s V_6
				L_015f: ldloc.s V_6
				L_0161: ldarg.0 
				L_0162: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0167: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_016c: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0171: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_0176: ldc.i4.0 
				L_0177: ldc.i4.0 
				L_0178: ldloc.s V_5
				L_017a: callvirt System.Drawing.Image::Int32 get_Width()
				L_017f: ldloc.s V_5
				L_0181: callvirt System.Drawing.Image::Int32 get_Height()
				L_0186: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_018b: ldarg.0 
				L_018c: ldloc.s V_6
				L_018e: ldloc.0 
				L_018f: ldc.i4.0 
				L_0190: ldc.i4.0 
				L_0191: ldloca.s V_3
				L_0193: call System.Drawing.Rectangle::Int32 get_Width()
				L_0198: ldloca.s V_3
				L_019a: call System.Drawing.Rectangle::Int32 get_Height()
				L_019f: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01a4: ldloc.s V_4
				L_01a6: call Sunisoft.IrisSkin.x9c946c69c1315c4d::Void x3a329aff8c7e9df4(System.Drawing.Graphics, SCROLLBARINFO, System.Drawing.Rectangle, Int32)
				L_01ab: leave.s L_01b9
				L_01ad: ldloc.s V_6
				L_01af: brfalse.s L_01b8
				L_01b1: ldloc.s V_6
				L_01b3: callvirt System.IDisposable::Void Dispose()
				L_01b8: endfinally 
				L_01b9: ldloc.1 
				L_01ba: call System.Drawing.Graphics::System.Drawing.Graphics FromHdc(IntPtr)
				L_01bf: stloc.s V_7
				L_01c1: ldloc.s V_7
				L_01c3: ldloc.s V_5
				L_01c5: ldloca.s V_3
				L_01c7: call System.Drawing.Rectangle::Int32 get_X()
				L_01cc: ldloca.s V_3
				L_01ce: call System.Drawing.Rectangle::Int32 get_Y()
				L_01d3: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_01d8: leave.s L_01e6
				L_01da: ldloc.s V_7
				L_01dc: brfalse.s L_01e5
				L_01de: ldloc.s V_7
				L_01e0: callvirt System.IDisposable::Void Dispose()
				L_01e5: endfinally 
				L_01e6: leave.s L_01f4
				L_01e8: ldloc.s V_5
				L_01ea: brfalse.s L_01f3
				L_01ec: ldloc.s V_5
				L_01ee: callvirt System.IDisposable::Void Dispose()
				L_01f3: endfinally 
				L_01f4: ldarg.0 
				L_01f5: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_01fa: ldc.i4.s -6
				L_01fc: ldloca.s V_0
				L_01fe: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollBarInfo(IntPtr, UInt32, SCROLLBARINFO ByRef)
				L_0203: brfalse L_0324
				L_0208: ldloca.s V_3
				L_020a: ldloca.s V_0
				L_020c: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0211: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0216: ldloca.s V_2
				L_0218: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_021d: sub 
				L_021e: ldloca.s V_0
				L_0220: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0225: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_022a: ldloca.s V_2
				L_022c: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0231: sub 
				L_0232: ldloca.s V_0
				L_0234: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0239: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_023e: ldloca.s V_0
				L_0240: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0245: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_024a: sub 
				L_024b: ldloca.s V_0
				L_024d: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0252: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0257: ldloca.s V_0
				L_0259: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_025e: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0263: sub 
				L_0264: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0269: ldloca.s V_3
				L_026b: call System.Drawing.Rectangle::Int32 get_X()
				L_0270: ldc.i4.0 
				L_0271: blt L_0324
				L_0276: ldloca.s V_3
				L_0278: call System.Drawing.Rectangle::Int32 get_Y()
				L_027d: ldc.i4.0 
				L_027e: blt L_0324
				L_0283: ldloca.s V_3
				L_0285: call System.Drawing.Rectangle::Int32 get_Width()
				L_028a: ldc.i4.0 
				L_028b: ble L_0324
				L_0290: ldloca.s V_3
				L_0292: call System.Drawing.Rectangle::Int32 get_Height()
				L_0297: ldc.i4.0 
				L_0298: ble L_0324
				L_029d: ldloca.s V_3
				L_029f: call System.Drawing.Rectangle::Int32 get_Width()
				L_02a4: ldloca.s V_3
				L_02a6: call System.Drawing.Rectangle::Int32 get_Height()
				L_02ab: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_02b0: stloc.s V_8
				L_02b2: ldloc.s V_8
				L_02b4: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_02b9: stloc.s V_9
				L_02bb: ldarg.0 
				L_02bc: ldloc.s V_9
				L_02be: ldloc.0 
				L_02bf: ldc.i4.0 
				L_02c0: ldc.i4.0 
				L_02c1: ldloca.s V_3
				L_02c3: call System.Drawing.Rectangle::Int32 get_Width()
				L_02c8: ldloca.s V_3
				L_02ca: call System.Drawing.Rectangle::Int32 get_Height()
				L_02cf: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_02d4: ldloc.s V_4
				L_02d6: call Sunisoft.IrisSkin.x9c946c69c1315c4d::Void xb16feaabcbd204bd(System.Drawing.Graphics, SCROLLBARINFO, System.Drawing.Rectangle, Int32)
				L_02db: leave.s L_02e9
				L_02dd: ldloc.s V_9
				L_02df: brfalse.s L_02e8
				L_02e1: ldloc.s V_9
				L_02e3: callvirt System.IDisposable::Void Dispose()
				L_02e8: endfinally 
				L_02e9: ldloc.1 
				L_02ea: call System.Drawing.Graphics::System.Drawing.Graphics FromHdc(IntPtr)
				L_02ef: stloc.s V_10
				L_02f1: ldloc.s V_10
				L_02f3: ldloc.s V_8
				L_02f5: ldloca.s V_3
				L_02f7: call System.Drawing.Rectangle::Int32 get_X()
				L_02fc: ldloca.s V_3
				L_02fe: call System.Drawing.Rectangle::Int32 get_Y()
				L_0303: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_0308: leave.s L_0316
				L_030a: ldloc.s V_10
				L_030c: brfalse.s L_0315
				L_030e: ldloc.s V_10
				L_0310: callvirt System.IDisposable::Void Dispose()
				L_0315: endfinally 
				L_0316: leave.s L_0324
				L_0318: ldloc.s V_8
				L_031a: brfalse.s L_0323
				L_031c: ldloc.s V_8
				L_031e: callvirt System.IDisposable::Void Dispose()
				L_0323: endfinally 
				L_0324: ldarg.0 
				L_0325: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_032a: ldloc.1 
				L_032b: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_0330: pop 
				L_0331: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				if ((((base.xcd9cdf30888d2204.ClientRectangle.Width <= 0) || (base.xcd9cdf30888d2204.ClientRectangle.Height <= 0)) || (! base.xf2140268ef7ddbf7)) || (! ((SkinEngine) base.xdc87e2b99332cd4a).SkinScrollBar))
				{
					return;
				}
				base.PaintControl ();
				x40255b11ef821fa3.SCROLLBARINFO sCROLLBARINFO1 = new x40255b11ef821fa3.SCROLLBARINFO ();
				sCROLLBARINFO1.cbSize = 60;
				IntPtr intPtr1 = x61467fe65a98f20c.GetWindowDC (base.Handle);
				xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
				bool b1 = x61467fe65a98f20c.GetWindowRect (base.Handle, ref rECT1);
				int i1 = 0;
				if (x61467fe65a98f20c.GetScrollBarInfo (base.Handle, ((uint) 0x00FB), ref sCROLLBARINFO1))
				{
					rectangle1 = new Rectangle (((int) (sCROLLBARINFO1.rcScrollBar.left - rECT1.left)), ((int) (sCROLLBARINFO1.rcScrollBar.top - rECT1.top)), ((int) (sCROLLBARINFO1.rcScrollBar.right - sCROLLBARINFO1.rcScrollBar.left)), ((int) (sCROLLBARINFO1.rcScrollBar.bottom - sCROLLBARINFO1.rcScrollBar.top)));
					if ((((rectangle1.X >= 0) && (rectangle1.Y >= 0)) && (rectangle1.Width > 0)) && (rectangle1.Height > 0))
					{
						using (Bitmap bitmap1 = new Bitmap (rectangle1.Width, ((int) (((rectangle1.Height + base.xcd9cdf30888d2204.Height) - rectangle1.Bottom) - 1))))
						{
							using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap1)))
							{
								graphics1.FillRectangle (((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR, 0, 0, bitmap1.Width, bitmap1.Height);
								this.x3a329aff8c7e9df4 (graphics1, sCROLLBARINFO1, new Rectangle (0, 0, rectangle1.Width, rectangle1.Height), i1);
							}
							using (Graphics graphics2 = Graphics.FromHdc (intPtr1))
							{
								graphics2.DrawImageUnscaled (((Image) bitmap1), rectangle1.X, rectangle1.Y);
							}
						}
					}
				}
				if (x61467fe65a98f20c.GetScrollBarInfo (base.Handle, ((uint) 0x00FA), ref sCROLLBARINFO1))
				{
					rectangle1 = new Rectangle (((int) (sCROLLBARINFO1.rcScrollBar.left - rECT1.left)), ((int) (sCROLLBARINFO1.rcScrollBar.top - rECT1.top)), ((int) (sCROLLBARINFO1.rcScrollBar.right - sCROLLBARINFO1.rcScrollBar.left)), ((int) (sCROLLBARINFO1.rcScrollBar.bottom - sCROLLBARINFO1.rcScrollBar.top)));
					if ((((rectangle1.X >= 0) && (rectangle1.Y >= 0)) && (rectangle1.Width > 0)) && (rectangle1.Height > 0))
					{
						using (Bitmap bitmap2 = new Bitmap (rectangle1.Width, rectangle1.Height))
						{
							using (Graphics graphics3 = Graphics.FromImage (((Image) bitmap2)))
							{
								this.xb16feaabcbd204bd (graphics3, sCROLLBARINFO1, new Rectangle (0, 0, rectangle1.Width, rectangle1.Height), i1);
							}
							using (Graphics graphics4 = Graphics.FromHdc (intPtr1))
							{
								graphics4.DrawImageUnscaled (((Image) bitmap2), rectangle1.X, rectangle1.Y);
							}
						}
					}
				}
				int i2 = x61467fe65a98f20c.ReleaseDC (base.Handle, intPtr1);
			}
			
			private void x3a329aff8c7e9df4 (Graphics x4b101060f4767186, x40255b11ef821fa3.SCROLLBARINFO x8d3f74e5f925679c, Rectangle x382bb49d8f914534, int xd5d613d57fc5703b)
			
			/*
				// Code Size: 311 Bytes
				.maxstack 7
				.locals (System.Drawing.Brush V_0, 
         System.Drawing.Bitmap V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Rectangle V_3, 
         System.Int32 V_4)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0006: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_000b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0010: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Brush get_BackColorBrush()
				L_0015: stloc.0 
				L_0016: ldarg.1 
				L_0017: ldloc.0 
				L_0018: ldarg.3 
				L_0019: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_001e: ldc.i4.s 16
				L_0020: ldarga.s x382bb49d8f914534
				L_0022: call System.Drawing.Rectangle::Int32 get_Height()
				L_0027: ldc.i4.1 
				L_0028: sub 
				L_0029: ldc.i4.2 
				L_002a: div 
				L_002b: call System.Math::Int32 Min(Int32, Int32)
				L_0030: stloc.s V_4
				L_0032: ldarg.0 
				L_0033: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0038: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_003d: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0042: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_UpButton()
				L_0047: ldc.i4.0 
				L_0048: ldarg.s xd5d613d57fc5703b
				L_004a: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_004f: stloc.1 
				L_0050: ldloca.s V_3
				L_0052: ldc.i4.0 
				L_0053: ldc.i4.0 
				L_0054: ldloc.1 
				L_0055: callvirt System.Drawing.Image::Int32 get_Width()
				L_005a: ldloc.1 
				L_005b: callvirt System.Drawing.Image::Int32 get_Height()
				L_0060: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0065: ldloca.s V_2
				L_0067: ldarga.s x382bb49d8f914534
				L_0069: call System.Drawing.Rectangle::Int32 get_X()
				L_006e: ldarga.s x382bb49d8f914534
				L_0070: call System.Drawing.Rectangle::Int32 get_Y()
				L_0075: ldarga.s x382bb49d8f914534
				L_0077: call System.Drawing.Rectangle::Int32 get_Width()
				L_007c: ldloc.s V_4
				L_007e: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0083: ldarg.1 
				L_0084: ldloc.1 
				L_0085: ldloc.2 
				L_0086: ldloc.3 
				L_0087: ldc.i4.2 
				L_0088: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_008d: ldarg.0 
				L_008e: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0093: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0098: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_009d: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_DownButton()
				L_00a2: ldc.i4.0 
				L_00a3: ldarg.s xd5d613d57fc5703b
				L_00a5: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_00aa: stloc.1 
				L_00ab: ldloca.s V_3
				L_00ad: ldc.i4.0 
				L_00ae: ldc.i4.0 
				L_00af: ldloc.1 
				L_00b0: callvirt System.Drawing.Image::Int32 get_Width()
				L_00b5: ldloc.1 
				L_00b6: callvirt System.Drawing.Image::Int32 get_Height()
				L_00bb: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00c0: ldloca.s V_2
				L_00c2: ldarga.s x382bb49d8f914534
				L_00c4: call System.Drawing.Rectangle::Int32 get_X()
				L_00c9: ldarga.s x382bb49d8f914534
				L_00cb: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_00d0: ldloc.s V_4
				L_00d2: sub 
				L_00d3: ldarga.s x382bb49d8f914534
				L_00d5: call System.Drawing.Rectangle::Int32 get_Width()
				L_00da: ldloc.s V_4
				L_00dc: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00e1: ldarg.1 
				L_00e2: ldloc.1 
				L_00e3: ldloc.2 
				L_00e4: ldloc.3 
				L_00e5: ldc.i4.2 
				L_00e6: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_00eb: ldloca.s V_2
				L_00ed: ldarga.s x382bb49d8f914534
				L_00ef: call System.Drawing.Rectangle::Int32 get_Left()
				L_00f4: ldarga.s x382bb49d8f914534
				L_00f6: call System.Drawing.Rectangle::Int32 get_Top()
				L_00fb: ldarga.s x8d3f74e5f925679c
				L_00fd: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbTop
				L_0102: add 
				L_0103: ldarga.s x382bb49d8f914534
				L_0105: call System.Drawing.Rectangle::Int32 get_Width()
				L_010a: ldarga.s x8d3f74e5f925679c
				L_010c: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbBottom
				L_0111: ldarga.s x8d3f74e5f925679c
				L_0113: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbTop
				L_0118: sub 
				L_0119: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_011e: ldloca.s V_2
				L_0120: call System.Drawing.Rectangle::Int32 get_Height()
				L_0125: ldc.i4.8 
				L_0126: ble.s L_0136
				L_0128: ldarg.0 
				L_0129: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_012e: ldarg.1 
				L_012f: ldloc.2 
				L_0130: ldc.i4.1 
				L_0131: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x9b7cda8516f8644e(Sunisoft.IrisSkin.SkinEngine, System.Drawing.Graphics, System.Drawing.Rectangle, Boolean)
				L_0136: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Rectangle rectangle2;
				Brush brush1 = ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).ScrollBarRes.BackColorBrush;
				x4b101060f4767186.FillRectangle (brush1, x382bb49d8f914534);
				int i1 = Math.Min (16, ((int) ((x382bb49d8f914534.Height - 1) / 2)));
				Bitmap bitmap1 = ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).ScrollBarRes.UpButton[0, xd5d613d57fc5703b];
				rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
				rectangle1 = new Rectangle (x382bb49d8f914534.X, x382bb49d8f914534.Y, x382bb49d8f914534.Width, i1);
				x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
				bitmap1 = ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).ScrollBarRes.DownButton[0, xd5d613d57fc5703b];
				rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
				rectangle1 = new Rectangle (x382bb49d8f914534.X, ((int) (x382bb49d8f914534.Bottom - i1)), x382bb49d8f914534.Width, i1);
				x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
				rectangle1 = new Rectangle (x382bb49d8f914534.Left, ((int) (x382bb49d8f914534.Top + x8d3f74e5f925679c.xyThumbTop)), x382bb49d8f914534.Width, ((int) (x8d3f74e5f925679c.xyThumbBottom - x8d3f74e5f925679c.xyThumbTop)));
				if (rectangle1.Height > 8)
				{
					x448fd9ab43628c71.x9b7cda8516f8644e (base.xdc87e2b99332cd4a, x4b101060f4767186, rectangle1, true);
				}
			}
			
			private void x5319e78a3425ad41 (uint x1f25abf5fb75e795, uint x30cc7819189f11b6, Rectangle xb55b340ae3a3e4e0)
			
			/*
				// Code Size: 55 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: stfld Sunisoft.IrisSkin.x9c946c69c1315c4d::UInt32 x1f25abf5fb75e795
				L_0007: ldarg.0 
				L_0008: ldarg.2 
				L_0009: stfld Sunisoft.IrisSkin.x9c946c69c1315c4d::UInt32 x30cc7819189f11b6
				L_000e: ldarg.0 
				L_000f: ldarg.3 
				L_0010: stfld Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Drawing.Rectangle x26545669838eb36e
				L_0015: ldarg.2 
				L_0016: ldc.i4.5 
				L_0017: bne.un.s L_002b
				L_0019: ldarg.0 
				L_001a: ldc.i4.1 
				L_001b: stfld Sunisoft.IrisSkin.x9c946c69c1315c4d::Boolean x34ce871902cf4acd
				L_0020: ldarg.0 
				L_0021: call System.Windows.Forms.Control::System.Drawing.Point get_MousePosition()
				L_0026: stfld Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Drawing.Point x2aa5114a5da7d6c8
				L_002b: ldarg.0 
				L_002c: ldfld Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Windows.Forms.Timer x420067493d7ebb36
				L_0031: callvirt System.Windows.Forms.Timer::Void Start()
				L_0036: ret 
			*/
			
			
			{
				this.x1f25abf5fb75e795 = x1f25abf5fb75e795;
				this.x30cc7819189f11b6 = x30cc7819189f11b6;
				this.x26545669838eb36e = xb55b340ae3a3e4e0;
				if (x30cc7819189f11b6 == 5)
				{
					this.x34ce871902cf4acd = true;
					this.x2aa5114a5da7d6c8 = Control.MousePosition;
				}
				this.x420067493d7ebb36.Start ();
			}
			
			private void x6139c418c50df34e ()
			
			/*
				// Code Size: 19 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.0 
				L_0002: stfld Sunisoft.IrisSkin.x9c946c69c1315c4d::Boolean x34ce871902cf4acd
				L_0007: ldarg.0 
				L_0008: ldfld Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Windows.Forms.Timer x420067493d7ebb36
				L_000d: callvirt System.Windows.Forms.Timer::Void Stop()
				L_0012: ret 
			*/
			
			
			{
				this.x34ce871902cf4acd = false;
				this.x420067493d7ebb36.Stop ();
			}
			
			private void x8605d09b86ce01b1 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 288 Bytes
				.maxstack 6
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO V_0, 
         System.Drawing.Point V_1, 
         System.Drawing.Rectangle V_2)
				L_0000: ldloca.s V_0
				L_0002: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO
				L_0008: ldloca.s V_0
				L_000a: ldc.i4.s 60
				L_000c: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::UInt32 cbSize
				L_0011: call System.Windows.Forms.Control::System.Drawing.Point get_MousePosition()
				L_0016: stloc.1 
				L_0017: ldloca.s V_2
				L_0019: ldc.i4.0 
				L_001a: ldc.i4.0 
				L_001b: ldc.i4.0 
				L_001c: ldc.i4.0 
				L_001d: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0022: ldarg.0 
				L_0023: ldfld Sunisoft.IrisSkin.x9c946c69c1315c4d::UInt32 x1f25abf5fb75e795
				L_0028: ldc.i4 277
				L_002d: bne.un.s L_008b
				L_002f: ldarg.0 
				L_0030: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0035: ldc.i4.s -5
				L_0037: ldloca.s V_0
				L_0039: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollBarInfo(IntPtr, UInt32, SCROLLBARINFO ByRef)
				L_003e: brfalse L_00ef
				L_0043: ldloca.s V_0
				L_0045: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_004a: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_004f: ldloca.s V_0
				L_0051: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0056: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_005b: ldloca.s V_0
				L_005d: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbTop
				L_0062: add 
				L_0063: ldloca.s V_0
				L_0065: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_006a: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_006f: ldloca.s V_0
				L_0071: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_0076: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_007b: ldloca.s V_0
				L_007d: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbBottom
				L_0082: add 
				L_0083: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0088: stloc.2 
				L_0089: br.s L_00ef
				L_008b: ldarg.0 
				L_008c: ldfld Sunisoft.IrisSkin.x9c946c69c1315c4d::UInt32 x1f25abf5fb75e795
				L_0091: ldc.i4 276
				L_0096: bne.un.s L_00ef
				L_0098: ldarg.0 
				L_0099: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_009e: ldc.i4.s -6
				L_00a0: ldloca.s V_0
				L_00a2: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetScrollBarInfo(IntPtr, UInt32, SCROLLBARINFO ByRef)
				L_00a7: brfalse.s L_00ef
				L_00a9: ldloca.s V_0
				L_00ab: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00b0: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_00b5: ldloca.s V_0
				L_00b7: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbTop
				L_00bc: add 
				L_00bd: ldloca.s V_0
				L_00bf: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00c4: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_00c9: ldloca.s V_0
				L_00cb: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00d0: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_00d5: ldloca.s V_0
				L_00d7: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbBottom
				L_00dc: add 
				L_00dd: ldloca.s V_0
				L_00df: ldflda Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::RECT rcScrollBar
				L_00e4: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_00e9: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_00ee: stloc.2 
				L_00ef: ldloc.1 
				L_00f0: ldarg.0 
				L_00f1: ldfld Sunisoft.IrisSkin.x9c946c69c1315c4d::System.Drawing.Rectangle x26545669838eb36e
				L_00f6: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_00fb: brfalse.s L_011f
				L_00fd: ldloc.1 
				L_00fe: ldloc.2 
				L_00ff: call Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x9466a6be27202526(System.Drawing.Point, System.Drawing.Rectangle)
				L_0104: brtrue.s L_011f
				L_0106: ldarg.0 
				L_0107: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_010c: ldarg.0 
				L_010d: ldfld Sunisoft.IrisSkin.x9c946c69c1315c4d::UInt32 x1f25abf5fb75e795
				L_0112: ldarg.0 
				L_0113: ldfld Sunisoft.IrisSkin.x9c946c69c1315c4d::UInt32 x30cc7819189f11b6
				L_0118: ldc.i4.0 
				L_0119: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_011e: pop 
				L_011f: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				x40255b11ef821fa3.SCROLLBARINFO sCROLLBARINFO1 = new x40255b11ef821fa3.SCROLLBARINFO ();
				sCROLLBARINFO1.cbSize = 60;
				Point point1 = Control.MousePosition;
				rectangle1 = new Rectangle (0, 0, 0, 0);
				if (this.x1f25abf5fb75e795 == 277)
				{
					if (x61467fe65a98f20c.GetScrollBarInfo (base.Handle, ((uint) 0x00FB), ref sCROLLBARINFO1))
					{
						rectangle1 = Rectangle.FromLTRB (sCROLLBARINFO1.rcScrollBar.left, ((int) (sCROLLBARINFO1.rcScrollBar.top + sCROLLBARINFO1.xyThumbTop)), sCROLLBARINFO1.rcScrollBar.right, ((int) (sCROLLBARINFO1.rcScrollBar.top + sCROLLBARINFO1.xyThumbBottom)));
					}
				}
				else if ((this.x1f25abf5fb75e795 == 276) && x61467fe65a98f20c.GetScrollBarInfo (base.Handle, ((uint) 0x00FA), ref sCROLLBARINFO1))
				{
					rectangle1 = Rectangle.FromLTRB (((int) (sCROLLBARINFO1.rcScrollBar.left + sCROLLBARINFO1.xyThumbTop)), sCROLLBARINFO1.rcScrollBar.top, ((int) (sCROLLBARINFO1.rcScrollBar.left + sCROLLBARINFO1.xyThumbBottom)), sCROLLBARINFO1.rcScrollBar.bottom);
				}
				if (x448fd9ab43628c71.x9466a6be27202526 (point1, this.x26545669838eb36e) && (! x448fd9ab43628c71.x9466a6be27202526 (point1, rectangle1)))
				{
					bool b1 = x61467fe65a98f20c.PostMessage (base.Handle, this.x1f25abf5fb75e795, this.x30cc7819189f11b6, uint.MinValue);
				}
			}
			
			private void xb16feaabcbd204bd (Graphics x4b101060f4767186, x40255b11ef821fa3.SCROLLBARINFO x8d3f74e5f925679c, Rectangle x382bb49d8f914534, int xd5d613d57fc5703b)
			
			/*
				// Code Size: 326 Bytes
				.maxstack 7
				.locals (System.Drawing.Brush V_0, 
         System.Drawing.Bitmap V_1, 
         System.Int32 V_2, 
         System.Drawing.Rectangle V_3, 
         System.Drawing.Rectangle V_4)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0006: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_000b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0010: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Brush get_BackColorBrush()
				L_0015: stloc.0 
				L_0016: ldarg.1 
				L_0017: ldloc.0 
				L_0018: ldarg.3 
				L_0019: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_001e: ldarg.0 
				L_001f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0024: call System.Windows.Forms.Control::System.Drawing.Point get_MousePosition()
				L_0029: callvirt System.Windows.Forms.Control::System.Drawing.Point PointToClient(System.Drawing.Point)
				L_002e: pop 
				L_002f: ldc.i4.s 16
				L_0031: ldarga.s x382bb49d8f914534
				L_0033: call System.Drawing.Rectangle::Int32 get_Width()
				L_0038: ldc.i4.1 
				L_0039: sub 
				L_003a: ldc.i4.2 
				L_003b: div 
				L_003c: call System.Math::Int32 Min(Int32, Int32)
				L_0041: stloc.2 
				L_0042: ldarg.0 
				L_0043: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0048: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_004d: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0052: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_UpButton()
				L_0057: ldc.i4.1 
				L_0058: ldarg.s xd5d613d57fc5703b
				L_005a: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_005f: stloc.1 
				L_0060: ldloca.s V_4
				L_0062: ldc.i4.0 
				L_0063: ldc.i4.0 
				L_0064: ldloc.1 
				L_0065: callvirt System.Drawing.Image::Int32 get_Width()
				L_006a: ldloc.1 
				L_006b: callvirt System.Drawing.Image::Int32 get_Height()
				L_0070: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0075: ldloca.s V_3
				L_0077: ldarga.s x382bb49d8f914534
				L_0079: call System.Drawing.Rectangle::Int32 get_X()
				L_007e: ldarga.s x382bb49d8f914534
				L_0080: call System.Drawing.Rectangle::Int32 get_Y()
				L_0085: ldloc.2 
				L_0086: ldarga.s x382bb49d8f914534
				L_0088: call System.Drawing.Rectangle::Int32 get_Height()
				L_008d: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0092: ldarg.1 
				L_0093: ldloc.1 
				L_0094: ldloc.3 
				L_0095: ldloc.s V_4
				L_0097: ldc.i4.2 
				L_0098: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_009d: ldarg.0 
				L_009e: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00a3: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00a8: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_00ad: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_DownButton()
				L_00b2: ldc.i4.1 
				L_00b3: ldarg.s xd5d613d57fc5703b
				L_00b5: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_00ba: stloc.1 
				L_00bb: ldloca.s V_4
				L_00bd: ldc.i4.0 
				L_00be: ldc.i4.0 
				L_00bf: ldloc.1 
				L_00c0: callvirt System.Drawing.Image::Int32 get_Width()
				L_00c5: ldloc.1 
				L_00c6: callvirt System.Drawing.Image::Int32 get_Height()
				L_00cb: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00d0: ldloca.s V_3
				L_00d2: ldarga.s x382bb49d8f914534
				L_00d4: call System.Drawing.Rectangle::Int32 get_Right()
				L_00d9: ldloc.2 
				L_00da: sub 
				L_00db: ldarga.s x382bb49d8f914534
				L_00dd: call System.Drawing.Rectangle::Int32 get_Y()
				L_00e2: ldloc.2 
				L_00e3: ldarga.s x382bb49d8f914534
				L_00e5: call System.Drawing.Rectangle::Int32 get_Height()
				L_00ea: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00ef: ldarg.1 
				L_00f0: ldloc.1 
				L_00f1: ldloc.3 
				L_00f2: ldloc.s V_4
				L_00f4: ldc.i4.2 
				L_00f5: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_00fa: ldloca.s V_3
				L_00fc: ldarga.s x382bb49d8f914534
				L_00fe: call System.Drawing.Rectangle::Int32 get_Left()
				L_0103: ldarga.s x8d3f74e5f925679c
				L_0105: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbTop
				L_010a: add 
				L_010b: ldarga.s x382bb49d8f914534
				L_010d: call System.Drawing.Rectangle::Int32 get_Top()
				L_0112: ldarga.s x8d3f74e5f925679c
				L_0114: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbBottom
				L_0119: ldarga.s x8d3f74e5f925679c
				L_011b: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+SCROLLBARINFO::Int32 xyThumbTop
				L_0120: sub 
				L_0121: ldarga.s x382bb49d8f914534
				L_0123: call System.Drawing.Rectangle::Int32 get_Height()
				L_0128: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_012d: ldloca.s V_3
				L_012f: call System.Drawing.Rectangle::Int32 get_Width()
				L_0134: ldc.i4.8 
				L_0135: ble.s L_0145
				L_0137: ldarg.0 
				L_0138: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_013d: ldarg.1 
				L_013e: ldloc.3 
				L_013f: ldc.i4.0 
				L_0140: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x9b7cda8516f8644e(Sunisoft.IrisSkin.SkinEngine, System.Drawing.Graphics, System.Drawing.Rectangle, Boolean)
				L_0145: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Rectangle rectangle2;
				Brush brush1 = ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).ScrollBarRes.BackColorBrush;
				x4b101060f4767186.FillRectangle (brush1, x382bb49d8f914534);
				Point point1 = base.xcd9cdf30888d2204.PointToClient (Control.MousePosition);
				int i1 = Math.Min (16, ((int) ((x382bb49d8f914534.Width - 1) / 2)));
				Bitmap bitmap1 = ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).ScrollBarRes.UpButton[1, xd5d613d57fc5703b];
				rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
				rectangle1 = new Rectangle (x382bb49d8f914534.X, x382bb49d8f914534.Y, i1, x382bb49d8f914534.Height);
				x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
				bitmap1 = ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).ScrollBarRes.DownButton[1, xd5d613d57fc5703b];
				rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
				rectangle1 = new Rectangle (((int) (x382bb49d8f914534.Right - i1)), x382bb49d8f914534.Y, i1, x382bb49d8f914534.Height);
				x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
				rectangle1 = new Rectangle (((int) (x382bb49d8f914534.Left + x8d3f74e5f925679c.xyThumbTop)), x382bb49d8f914534.Top, ((int) (x8d3f74e5f925679c.xyThumbBottom - x8d3f74e5f925679c.xyThumbTop)), x382bb49d8f914534.Height);
				if (rectangle1.Width > 8)
				{
					x448fd9ab43628c71.x9b7cda8516f8644e (base.xdc87e2b99332cd4a, x4b101060f4767186, rectangle1, false);
				}
			}
			
		#endregion
	}
	
}

