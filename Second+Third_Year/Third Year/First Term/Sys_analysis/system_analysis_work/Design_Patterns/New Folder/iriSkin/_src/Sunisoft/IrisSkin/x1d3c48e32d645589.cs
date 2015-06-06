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
		
	internal class x1d3c48e32d645589 : x2edc3f693fe78d2e
	
	{
		
		#region Fields
			private xa7ba4c69fc1cad79 x6b0ad9f73c48ad53;
			private BorderStyle xacfbd7a08ba56c78;
		#endregion
		
		#region Nested Types
		
			internal class xa7ba4c69fc1cad79 : NativeWindow
			
			{
				
				#region Fields
					private Control x246c0c54671f3f3e;
					private StringFormat x5786461d089b10a0;
					private ISkinEngine xdc87e2b99332cd4a;
				#endregion
				
				#region Constructors
				
					public xa7ba4c69fc1cad79 (ISkinEngine engine, Control host)
					/*
						// Code Size: 107 Bytes
						.maxstack 5
						.locals (System.IntPtr V_0)
						L_0000: ldarg.0 
						L_0001: call System.Windows.Forms.NativeWindow::Void .ctor()
						L_0006: ldarg.0 
						L_0007: ldarg.1 
						L_0008: stfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
						L_000d: ldarg.0 
						L_000e: ldarg.2 
						L_000f: stfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::System.Windows.Forms.Control x246c0c54671f3f3e
						L_0014: ldarg.0 
						L_0015: newobj System.Drawing.StringFormat::Void .ctor()
						L_001a: stfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::System.Drawing.StringFormat x5786461d089b10a0
						L_001f: ldarg.0 
						L_0020: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::System.Drawing.StringFormat x5786461d089b10a0
						L_0025: ldc.i4.1 
						L_0026: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
						L_002b: ldarg.0 
						L_002c: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::System.Drawing.StringFormat x5786461d089b10a0
						L_0031: ldc.i4 4096
						L_0036: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
						L_003b: ldarg.0 
						L_003c: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::System.Windows.Forms.Control x246c0c54671f3f3e
						L_0041: brfalse.s L_006a
						L_0043: ldarg.2 
						L_0044: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
						L_0049: ldc.i4 4127
						L_004e: ldc.i4.0 
						L_004f: ldc.i4.0 
						L_0050: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SendMessage(IntPtr, UInt32, UInt32, UInt32)
						L_0055: stloc.0 
						L_0056: ldloc.0 
						L_0057: ldsfld System.IntPtr::IntPtr Zero
						L_005c: call System.IntPtr::Boolean op_Inequality(IntPtr, IntPtr)
						L_0061: brfalse.s L_006a
						L_0063: ldarg.0 
						L_0064: ldloc.0 
						L_0065: call System.Windows.Forms.NativeWindow::Void AssignHandle(IntPtr)
						L_006a: ret 
					*/
				#endregion
				
				#region Methods
				
					protected unsafe virtual void PaintHeader ()
					
					/*
						// Code Size: 1011 Bytes
						.maxstack 10
						.locals (System.Drawing.Rectangle V_0, 
         System.Drawing.Rectangle V_1, 
         System.Drawing.Point V_2, 
         System.Windows.Forms.ListView V_3, 
         System.IntPtr V_4, 
         System.Drawing.Graphics V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         System.Int32 V_9, 
         System.Windows.Forms.ColumnHeader V_10, 
         System.IntPtr V_11, 
         System.IntPtr V_12, 
         System.Drawing.Rectangle* V_13, 
         System.Drawing.Font V_14, 
         System.String V_15, 
         System.Drawing.Pen V_16, 
         System.Drawing.Pen V_17, 
         System.Windows.Forms.HorizontalAlignment V_18, 
         System.Drawing.SizeF V_19)
						.try L_02af to L_030d finally L_030d to L_0319
						.try L_0382 to L_03ad finally L_03ad to L_03b9
						.try L_00c7 to L_03d3 finally L_03d3 to L_03df
						L_0000: ldloca.s V_1
						L_0002: ldc.i4.0 
						L_0003: ldc.i4.0 
						L_0004: ldc.i4.0 
						L_0005: ldc.i4.0 
						L_0006: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
						L_000b: ldarg.0 
						L_000c: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
						L_0011: ldloca.s V_1
						L_0013: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowRect(IntPtr, System.Drawing.Rectangle ByRef)
						L_0018: pop 
						L_0019: ldloca.s V_2
						L_001b: ldloca.s V_1
						L_001d: call System.Drawing.Rectangle::Int32 get_X()
						L_0022: ldloca.s V_1
						L_0024: call System.Drawing.Rectangle::Int32 get_Y()
						L_0029: call System.Drawing.Point::Void .ctor(Int32, Int32)
						L_002e: ldarg.0 
						L_002f: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::System.Windows.Forms.Control x246c0c54671f3f3e
						L_0034: ldloc.2 
						L_0035: callvirt System.Windows.Forms.Control::System.Drawing.Point PointToClient(System.Drawing.Point)
						L_003a: stloc.2 
						L_003b: ldloca.s V_1
						L_003d: ldloca.s V_2
						L_003f: call System.Drawing.Point::Int32 get_X()
						L_0044: call System.Drawing.Rectangle::Void set_X(Int32)
						L_0049: ldloca.s V_1
						L_004b: ldloca.s V_2
						L_004d: call System.Drawing.Point::Int32 get_Y()
						L_0052: call System.Drawing.Rectangle::Void set_Y(Int32)
						L_0057: ldloca.s V_2
						L_0059: ldloca.s V_1
						L_005b: call System.Drawing.Rectangle::Int32 get_Width()
						L_0060: ldloca.s V_1
						L_0062: call System.Drawing.Rectangle::Int32 get_Height()
						L_0067: call System.Drawing.Point::Void .ctor(Int32, Int32)
						L_006c: ldarg.0 
						L_006d: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::System.Windows.Forms.Control x246c0c54671f3f3e
						L_0072: ldloc.2 
						L_0073: callvirt System.Windows.Forms.Control::System.Drawing.Point PointToClient(System.Drawing.Point)
						L_0078: stloc.2 
						L_0079: ldloca.s V_1
						L_007b: ldloca.s V_2
						L_007d: call System.Drawing.Point::Int32 get_X()
						L_0082: ldloca.s V_1
						L_0084: call System.Drawing.Rectangle::Int32 get_X()
						L_0089: sub 
						L_008a: call System.Drawing.Rectangle::Void set_Width(Int32)
						L_008f: ldloca.s V_1
						L_0091: ldloca.s V_2
						L_0093: call System.Drawing.Point::Int32 get_Y()
						L_0098: ldloca.s V_1
						L_009a: call System.Drawing.Rectangle::Int32 get_Y()
						L_009f: sub 
						L_00a0: call System.Drawing.Rectangle::Void set_Height(Int32)
						L_00a5: ldarg.0 
						L_00a6: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::System.Windows.Forms.Control x246c0c54671f3f3e
						L_00ab: castclass System.Windows.Forms.ListView
						L_00b0: stloc.3 
						L_00b1: ldarg.0 
						L_00b2: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
						L_00b7: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindowDC(IntPtr)
						L_00bc: stloc.s V_4
						L_00be: ldloc.s V_4
						L_00c0: call System.Drawing.Graphics::System.Drawing.Graphics FromHdc(IntPtr)
						L_00c5: stloc.s V_5
						L_00c7: ldc.i4.0 
						L_00c8: stloc.s V_7
						L_00ca: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Font xfc84e4da153943c2()
						L_00cf: stloc.s V_14
						L_00d1: ldc.i4.0 
						L_00d2: stloc.s V_6
						L_00d4: br L_03bf
						L_00d9: ldloca.s V_11
						L_00db: ldloc.s V_6
						L_00dd: call System.IntPtr::Void .ctor(Int32)
						L_00e2: ldloca.s V_0
						L_00e4: ldc.i4.0 
						L_00e5: ldc.i4.0 
						L_00e6: ldc.i4.0 
						L_00e7: ldc.i4.0 
						L_00e8: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
						L_00ed: ldloca.s V_0
						L_00ef: stloc.s V_13
						L_00f1: ldloca.s V_12
						L_00f3: ldloc.s V_13
						L_00f5: call System.IntPtr::Void .ctor(Void*)
						L_00fa: ldarg.0 
						L_00fb: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
						L_0100: ldc.i4 4615
						L_0105: ldloc.s V_11
						L_0107: ldloc.s V_12
						L_0109: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SendMessage(IntPtr, UInt32, IntPtr, IntPtr)
						L_010e: pop 
						L_010f: ldloc.s V_12
						L_0111: ldsfld System.IntPtr::IntPtr Zero
						L_0116: call System.IntPtr::Boolean op_Inequality(IntPtr, IntPtr)
						L_011b: brfalse L_0319
						L_0120: ldloc.s V_12
						L_0122: call System.IntPtr::Void* op_Explicit(IntPtr)
						L_0127: stloc.s V_13
						L_0129: ldloca.s V_0
						L_012b: ldloca.s V_0
						L_012d: call System.Drawing.Rectangle::Int32 get_Width()
						L_0132: ldloca.s V_0
						L_0134: call System.Drawing.Rectangle::Int32 get_X()
						L_0139: sub 
						L_013a: call System.Drawing.Rectangle::Void set_Width(Int32)
						L_013f: ldloca.s V_0
						L_0141: ldloca.s V_0
						L_0143: call System.Drawing.Rectangle::Int32 get_Height()
						L_0148: ldloca.s V_0
						L_014a: call System.Drawing.Rectangle::Int32 get_Y()
						L_014f: sub 
						L_0150: call System.Drawing.Rectangle::Void set_Height(Int32)
						L_0155: ldloc.s V_5
						L_0157: ldarg.0 
						L_0158: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
						L_015d: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
						L_0162: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
						L_0167: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
						L_016c: ldloc.0 
						L_016d: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
						L_0172: ldloc.3 
						L_0173: callvirt System.Windows.Forms.ListView::ColumnHeaderCollection get_Columns()
						L_0178: ldloc.s V_6
						L_017a: callvirt System.Windows.Forms.ListView+ColumnHeaderCollection::System.Windows.Forms.ColumnHeader get_Item(Int32)
						L_017f: stloc.s V_10
						L_0181: ldloc.s V_10
						L_0183: callvirt System.Windows.Forms.ColumnHeader::System.Windows.Forms.HorizontalAlignment get_TextAlign()
						L_0188: stloc.s V_18
						L_018a: ldloc.s V_18
						L_018c: switch (L_019d, L_01b6, L_020c)
						L_019d: ldloca.s V_0
						L_019f: call System.Drawing.Rectangle::Int32 get_Left()
						L_01a4: ldc.i4.4 
						L_01a5: add 
						L_01a6: stloc.s V_9
						L_01a8: ldarg.0 
						L_01a9: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::System.Drawing.StringFormat x5786461d089b10a0
						L_01ae: ldc.i4.0 
						L_01af: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
						L_01b4: br.s L_0223
						L_01b6: ldloca.s V_0
						L_01b8: call System.Drawing.Rectangle::Int32 get_Right()
						L_01bd: ldloca.s V_0
						L_01bf: call System.Drawing.Rectangle::Int32 get_Left()
						L_01c4: sub 
						L_01c5: ldc.i4.6 
						L_01c6: sub 
						L_01c7: stloc.s V_8
						L_01c9: ldloc.s V_8
						L_01cb: ldloc.s V_5
						L_01cd: ldloc.s V_10
						L_01cf: callvirt System.Windows.Forms.ColumnHeader::System.String get_Text()
						L_01d4: ldloc.s V_14
						L_01d6: callvirt System.Drawing.Graphics::System.Drawing.SizeF MeasureString(System.String, System.Drawing.Font)
						L_01db: stloc.s V_19
						L_01dd: ldloca.s V_19
						L_01df: call System.Drawing.SizeF::Single get_Width()
						L_01e4: conv.i4 
						L_01e5: sub 
						L_01e6: ldc.i4.2 
						L_01e7: sub 
						L_01e8: stloc.s V_9
						L_01ea: ldloc.s V_9
						L_01ec: ldc.i4.4 
						L_01ed: bge.s L_01f2
						L_01ef: ldc.i4.4 
						L_01f0: stloc.s V_9
						L_01f2: ldloca.s V_0
						L_01f4: call System.Drawing.Rectangle::Int32 get_Left()
						L_01f9: ldloc.s V_9
						L_01fb: add 
						L_01fc: stloc.s V_9
						L_01fe: ldarg.0 
						L_01ff: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::System.Drawing.StringFormat x5786461d089b10a0
						L_0204: ldc.i4.0 
						L_0205: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
						L_020a: br.s L_0223
						L_020c: ldloca.s V_0
						L_020e: call System.Drawing.Rectangle::Int32 get_Left()
						L_0213: ldc.i4.4 
						L_0214: add 
						L_0215: stloc.s V_9
						L_0217: ldarg.0 
						L_0218: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::System.Drawing.StringFormat x5786461d089b10a0
						L_021d: ldc.i4.1 
						L_021e: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
						L_0223: ldloca.s V_0
						L_0225: call System.Drawing.Rectangle::Int32 get_Right()
						L_022a: ldloca.s V_0
						L_022c: call System.Drawing.Rectangle::Int32 get_Left()
						L_0231: sub 
						L_0232: ldc.i4.2 
						L_0233: sub 
						L_0234: stloc.s V_8
						L_0236: ldloc.s V_5
						L_0238: ldloc.s V_10
						L_023a: callvirt System.Windows.Forms.ColumnHeader::System.String get_Text()
						L_023f: ldloc.s V_14
						L_0241: ldloc.s V_8
						L_0243: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.String xd770c4dc45b3b54f(System.Drawing.Graphics, System.String, System.Drawing.Font, Int32)
						L_0248: stloc.s V_15
						L_024a: ldloc.s V_5
						L_024c: ldloc.s V_15
						L_024e: ldloc.s V_14
						L_0250: ldarg.0 
						L_0251: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
						L_0256: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
						L_025b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
						L_0260: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_CONTROLFONTCOLOR()
						L_0265: ldloc.s V_9
						L_0267: ldloca.s V_0
						L_0269: call System.Drawing.Rectangle::Int32 get_Top()
						L_026e: ldloca.s V_0
						L_0270: call System.Drawing.Rectangle::Int32 get_Right()
						L_0275: ldc.i4.2 
						L_0276: sub 
						L_0277: ldloca.s V_0
						L_0279: call System.Drawing.Rectangle::Int32 get_Bottom()
						L_027e: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
						L_0283: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
						L_0288: ldarg.0 
						L_0289: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::System.Drawing.StringFormat x5786461d089b10a0
						L_028e: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
						L_0293: ldarg.0 
						L_0294: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
						L_0299: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
						L_029e: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
						L_02a3: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_CONTROLBORDERCOLOR()
						L_02a8: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush)
						L_02ad: stloc.s V_16
						L_02af: ldloca.s V_0
						L_02b1: call System.Drawing.Rectangle::Int32 get_Right()
						L_02b6: ldloc.s V_7
						L_02b8: ldc.i4.1 
						L_02b9: add 
						L_02ba: bne.un.s L_02e5
						L_02bc: ldloc.s V_5
						L_02be: ldloc.s V_16
						L_02c0: ldloca.s V_0
						L_02c2: call System.Drawing.Rectangle::Int32 get_Right()
						L_02c7: ldc.i4.2 
						L_02c8: sub 
						L_02c9: ldloca.s V_0
						L_02cb: call System.Drawing.Rectangle::Int32 get_Top()
						L_02d0: ldloca.s V_0
						L_02d2: call System.Drawing.Rectangle::Int32 get_Right()
						L_02d7: ldc.i4.2 
						L_02d8: sub 
						L_02d9: ldloca.s V_0
						L_02db: call System.Drawing.Rectangle::Int32 get_Left()
						L_02e0: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
						L_02e5: ldloca.s V_0
						L_02e7: call System.Drawing.Rectangle::Int32 get_Right()
						L_02ec: ldc.i4.1 
						L_02ed: sub 
						L_02ee: stloc.s V_7
						L_02f0: ldloc.s V_5
						L_02f2: ldloc.s V_16
						L_02f4: ldloc.s V_7
						L_02f6: ldloca.s V_0
						L_02f8: call System.Drawing.Rectangle::Int32 get_Top()
						L_02fd: ldloc.s V_7
						L_02ff: ldloca.s V_0
						L_0301: call System.Drawing.Rectangle::Int32 get_Bottom()
						L_0306: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
						L_030b: leave.s L_0319
						L_030d: ldloc.s V_16
						L_030f: brfalse.s L_0318
						L_0311: ldloc.s V_16
						L_0313: callvirt System.IDisposable::Void Dispose()
						L_0318: endfinally 
						L_0319: ldloca.s V_0
						L_031b: call System.Drawing.Rectangle::Int32 get_Right()
						L_0320: ldloca.s V_1
						L_0322: call System.Drawing.Rectangle::Int32 get_Right()
						L_0327: bge.s L_0366
						L_0329: ldloc.s V_5
						L_032b: ldarg.0 
						L_032c: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
						L_0331: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
						L_0336: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
						L_033b: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
						L_0340: ldloca.s V_0
						L_0342: call System.Drawing.Rectangle::Int32 get_Right()
						L_0347: ldloca.s V_0
						L_0349: call System.Drawing.Rectangle::Int32 get_Top()
						L_034e: ldloca.s V_1
						L_0350: call System.Drawing.Rectangle::Int32 get_Right()
						L_0355: ldloca.s V_0
						L_0357: call System.Drawing.Rectangle::Int32 get_Bottom()
						L_035c: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
						L_0361: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
						L_0366: ldarg.0 
						L_0367: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
						L_036c: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
						L_0371: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
						L_0376: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_CONTROLBORDERCOLOR()
						L_037b: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush)
						L_0380: stloc.s V_17
						L_0382: ldloc.s V_5
						L_0384: ldloc.s V_17
						L_0386: ldloca.s V_1
						L_0388: call System.Drawing.Rectangle::Int32 get_Left()
						L_038d: ldloca.s V_1
						L_038f: call System.Drawing.Rectangle::Int32 get_Bottom()
						L_0394: ldc.i4.1 
						L_0395: sub 
						L_0396: ldloca.s V_0
						L_0398: call System.Drawing.Rectangle::Int32 get_Right()
						L_039d: ldloca.s V_1
						L_039f: call System.Drawing.Rectangle::Int32 get_Bottom()
						L_03a4: ldc.i4.1 
						L_03a5: sub 
						L_03a6: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
						L_03ab: leave.s L_03b9
						L_03ad: ldloc.s V_17
						L_03af: brfalse.s L_03b8
						L_03b1: ldloc.s V_17
						L_03b3: callvirt System.IDisposable::Void Dispose()
						L_03b8: endfinally 
						L_03b9: ldloc.s V_6
						L_03bb: ldc.i4.1 
						L_03bc: add 
						L_03bd: stloc.s V_6
						L_03bf: ldloc.s V_6
						L_03c1: ldloc.3 
						L_03c2: callvirt System.Windows.Forms.ListView::ColumnHeaderCollection get_Columns()
						L_03c7: callvirt System.Windows.Forms.ListView+ColumnHeaderCollection::Int32 get_Count()
						L_03cc: blt L_00d9
						L_03d1: leave.s L_03df
						L_03d3: ldloc.s V_5
						L_03d5: brfalse.s L_03de
						L_03d7: ldloc.s V_5
						L_03d9: callvirt System.IDisposable::Void Dispose()
						L_03de: endfinally 
						L_03df: ldarg.0 
						L_03e0: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::System.Windows.Forms.Control x246c0c54671f3f3e
						L_03e5: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
						L_03ea: ldloc.s V_4
						L_03ec: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
						L_03f1: pop 
						L_03f2: ret 
					*/
					
					
					{
						Rectangle rectangle1;
						Rectangle rectangle2;
						Point point1;
						int i1;
						int i2;
						int i3;
						int i4;
						ColumnHeader columnHeader1;
						IntPtr intPtr2;
						IntPtr intPtr3;
						Rectangle* rectangle_Ptr1;
						Font font1;
						string string1;
						HorizontalAlignment horizontalAlignment1;
						rectangle2 = new Rectangle (0, 0, 0, 0);
						bool b1 = x61467fe65a98f20c.GetWindowRect (base.Handle, ref rectangle2);
						point1 = new Point (rectangle2.X, rectangle2.Y);
						rectangle2.X = (point1 = this.x246c0c54671f3f3e.PointToClient (point1)).X;
						rectangle2.Y = point1.Y;
						point1 = new Point (rectangle2.Width, rectangle2.Height);
						rectangle2.Width = ((point1 = this.x246c0c54671f3f3e.PointToClient (point1)).X - rectangle2.X);
						rectangle2.Height = (point1.Y - rectangle2.Y);
						ListView listView1 = ((ListView) this.x246c0c54671f3f3e);
						IntPtr intPtr1 = x61467fe65a98f20c.GetWindowDC (base.Handle);
						using (Graphics graphics1 = Graphics.FromHdc (intPtr1))
						{
							i2 = 0;
							font1 = x448fd9ab43628c71.xfc84e4da153943c2 ();
							i1 = 0;
							goto L_03BF;
							
						L_01F2:
							
							{
							}
							i4 = (rectangle1.Left + i4);
							this.x5786461d089b10a0.Alignment = StringAlignment.Near;
							
						L_0223:
							
							{
							}
							i3 = ((rectangle1.Right - rectangle1.Left) - 2);
							string1 = x448fd9ab43628c71.xd770c4dc45b3b54f (graphics1, columnHeader1.Text, font1, i3);
							graphics1.DrawString (string1, font1, ((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_CONTROLFONTCOLOR, ((RectangleF) Rectangle.FromLTRB (i4, rectangle1.Top, ((int) (rectangle1.Right - 2)), rectangle1.Bottom)), this.x5786461d089b10a0);
							using (Pen pen1 = new Pen (((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_CONTROLBORDERCOLOR))
							{
								if (rectangle1.Right == (i2 + 1))
								{
									graphics1.DrawLine (pen1, ((int) (rectangle1.Right - 2)), rectangle1.Top, ((int) (rectangle1.Right - 2)), rectangle1.Left);
								}
								i2 = (rectangle1.Right - 1);
								graphics1.DrawLine (pen1, i2, rectangle1.Top, i2, rectangle1.Bottom);
							}
							
						L_0319:
							
							{
							}
							if (rectangle1.Right < rectangle2.Right)
							{
								graphics1.FillRectangle (((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR, Rectangle.FromLTRB (rectangle1.Right, rectangle1.Top, rectangle2.Right, rectangle1.Bottom));
							}
							using (Pen pen2 = new Pen (((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_CONTROLBORDERCOLOR))
							{
								graphics1.DrawLine (pen2, rectangle2.Left, ((int) (rectangle2.Bottom - 1)), rectangle1.Right, ((int) (rectangle2.Bottom - 1)));
							}
							i1++;
							
						L_03BF:
							
							{
							}
							if (i1 < listView1.Columns.Count)
							{
								intPtr2 = new IntPtr (i1);
								rectangle1 = new Rectangle (0, 0, 0, 0);
								rectangle_Ptr1 = & (rectangle1);
								intPtr3 = new IntPtr (((void*) rectangle_Ptr1));
								IntPtr intPtr4 = x61467fe65a98f20c.SendMessage (base.Handle, 4615, intPtr2, intPtr3);
								if (intPtr3 != IntPtr.Zero)
								{
									rectangle_Ptr1 = ((Rectangle*) ((void*) intPtr3));
									rectangle1.Width -= rectangle1.X;
									rectangle1.Height -= rectangle1.Y;
									graphics1.FillRectangle (((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR, rectangle1);
									columnHeader1 = listView1.Columns[i1];
									horizontalAlignment1 = columnHeader1.TextAlign;
									switch (horizontalAlignment1)
									{
										case HorizontalAlignment.Right:
										
										{
												i3 = ((rectangle1.Right - rectangle1.Left) - 6);
												i4 = ((i3 - ((int) graphics1.MeasureString (columnHeader1.Text, font1).Width)) - 2);
												if (i4 >= 4)
												{
													goto L_01F2;
												}
												i4 = 4;
												goto L_01F2;
										}
										case HorizontalAlignment.Center:
										
										{
												i4 = (rectangle1.Left + 4);
												this.x5786461d089b10a0.Alignment = StringAlignment.Center;
												goto L_0223;
										}
									}
									i4 = (rectangle1.Left + 4);
									this.x5786461d089b10a0.Alignment = StringAlignment.Near;
									goto L_0223;
								}
								else
								{
									goto L_0319;
								}
							}
						}
						int i5 = x61467fe65a98f20c.ReleaseDC (this.x246c0c54671f3f3e.Handle, intPtr1);
					}
					
					protected override void WndProc (ref Message m)
					
					/*
						// Code Size: 111 Bytes
						.maxstack 3
						.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT V_0, 
         System.UInt32 V_1)
						L_0000: ldarg.0 
						L_0001: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
						L_0006: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_RealActive()
						L_000b: brfalse.s L_003b
						L_000d: ldarg.1 
						L_000e: call System.Windows.Forms.Message::Int32 get_Msg()
						L_0013: stloc.1 
						L_0014: ldloc.1 
						L_0015: ldc.i4.s 15
						L_0017: bne.un.s L_003b
						L_0019: ldarg.0 
						L_001a: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
						L_001f: ldloca.s V_0
						L_0021: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr BeginPaint(IntPtr, PAINTSTRUCT ByRef)
						L_0026: pop 
						L_0027: ldarg.0 
						L_0028: callvirt Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::Void PaintHeader()
						L_002d: ldarg.0 
						L_002e: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
						L_0033: ldloca.s V_0
						L_0035: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean EndPaint(IntPtr, PAINTSTRUCT ByRef)
						L_003a: pop 
						L_003b: ldarg.0 
						L_003c: ldarg.1 
						L_003d: call System.Windows.Forms.NativeWindow::Void WndProc(System.Windows.Forms.Message ByRef)
						L_0042: ldarg.0 
						L_0043: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
						L_0048: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_RealActive()
						L_004d: brfalse.s L_006e
						L_004f: ldarg.1 
						L_0050: call System.Windows.Forms.Message::Int32 get_Msg()
						L_0055: stloc.1 
						L_0056: ldloc.1 
						L_0057: ldc.i4 4612
						L_005c: beq.s L_0067
						L_005e: ldloc.1 
						L_005f: ldc.i4 4620
						L_0064: beq.s L_0067
						L_0066: ret 
						L_0067: ldarg.0 
						L_0068: callvirt Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::Void PaintHeader()
						L_006d: ret 
						L_006e: ret 
					*/
					
					
					{
						x40255b11ef821fa3.PAINTSTRUCT pAINTSTRUCT1;
						if (((SkinEngine) this.xdc87e2b99332cd4a).RealActive && (((uint) m.Msg) == 15))
						{
							IntPtr intPtr1 = x61467fe65a98f20c.BeginPaint (base.Handle, out pAINTSTRUCT1);
							this.PaintHeader ();
							bool b1 = x61467fe65a98f20c.EndPaint (base.Handle, ref pAINTSTRUCT1);
						}
						base.WndProc (ref m);
						if (! ((SkinEngine) this.xdc87e2b99332cd4a).RealActive)
						{
							return;
						}
						uint uInt32_1 = ((uint) m.Msg);
						if ((uInt32_1 != 4612) && (uInt32_1 != 4620))
						{
						}
						else
						{
							this.PaintHeader ();
							return;
							
							/*
								Unreachable Code
								return;
							*/
						}
					}
					
				#endregion
			}
			
		#endregion
		
		#region Constructors
		
			public x1d3c48e32d645589 (Control control, ISkinEngine engine)
				 : base (control, engine)
			/*
				// Code Size: 22 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ldarg.0 
				L_0009: ldarg.2 
				L_000a: ldarg.1 
				L_000b: newobj Sunisoft.IrisSkin.x1d3c48e32d645589+xa7ba4c69fc1cad79::Void .ctor(Sunisoft.IrisSkin.SkinEngine, System.Windows.Forms.Control)
				L_0010: stfld Sunisoft.IrisSkin.x1d3c48e32d645589::xa7ba4c69fc1cad79 x6b0ad9f73c48ad53
				L_0015: ret 
			*/
		#endregion
		
		#region Properties
		
			protected override int BorderWidth
			
			{
				get
				
				/*
					// Code Size: 2 Bytes
					.maxstack 9
					L_0000: ldc.i4.0 
					L_0001: ret 
				*/
				
				{
					return 0;
				}
			}
			
			
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
			
			
			protected override bool PaintBorder
			
			{
				get
				
				/*
					// Code Size: 24 Bytes
					.maxstack 3
					.locals (System.Windows.Forms.ListView V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
					L_0006: castclass System.Windows.Forms.ListView
					L_000b: stloc.0 
					L_000c: ldloc.0 
					L_000d: callvirt System.Windows.Forms.ListView::System.Windows.Forms.BorderStyle get_BorderStyle()
					L_0012: brtrue.s L_0016
					L_0014: ldc.i4.0 
					L_0015: ret 
					L_0016: ldc.i4.1 
					L_0017: ret 
				*/
				
				{
					ListView listView1 = ((ListView) base.xcd9cdf30888d2204);
					if (listView1.BorderStyle != BorderStyle.None)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
			}
			
		#endregion
		
		#region Methods
		
			protected override void DoInit ()
			
			/*
				// Code Size: 77 Bytes
				.maxstack 5
				.locals (System.Windows.Forms.ListView V_0)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void DoInit()
				L_0006: ldarg.0 
				L_0007: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_000c: ldarg.0 
				L_000d: ldftn Sunisoft.IrisSkin.x1d3c48e32d645589::Void x11d4d6bec891e7ac(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_0013: newobj Sunisoft.IrisSkin.SkinChanged::Void .ctor(System.Object, IntPtr)
				L_0018: callvirt Sunisoft.IrisSkin.SkinEngine::Void add_CurrentSkinChanged(Sunisoft.IrisSkin.SkinChanged)
				L_001d: ldarg.0 
				L_001e: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0023: castclass System.Windows.Forms.ListView
				L_0028: stloc.0 
				L_0029: ldarg.0 
				L_002a: ldloc.0 
				L_002b: callvirt System.Windows.Forms.ListView::System.Windows.Forms.BorderStyle get_BorderStyle()
				L_0030: stfld Sunisoft.IrisSkin.x1d3c48e32d645589::System.Windows.Forms.BorderStyle xacfbd7a08ba56c78
				L_0035: ldarg.0 
				L_0036: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589::System.Windows.Forms.BorderStyle xacfbd7a08ba56c78
				L_003b: brfalse.s L_004c
				L_003d: ldarg.0 
				L_003e: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0043: brfalse.s L_004c
				L_0045: ldloc.0 
				L_0046: ldc.i4.1 
				L_0047: callvirt System.Windows.Forms.ListView::Void set_BorderStyle(System.Windows.Forms.BorderStyle)
				L_004c: ret 
			*/
			
			
			{
				base.DoInit ();
				((SkinEngine) base.xdc87e2b99332cd4a).CurrentSkinChanged += new SkinChanged (this.x11d4d6bec891e7ac);
				ListView listView1 = ((ListView) base.xcd9cdf30888d2204);
				this.xacfbd7a08ba56c78 = listView1.BorderStyle;
				if ((this.xacfbd7a08ba56c78 != BorderStyle.None) && base.xf2140268ef7ddbf7)
				{
					listView1.BorderStyle = BorderStyle.FixedSingle;
				}
			}
			
			protected override void PaintControl ()
			
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void PaintControl()
				L_0006: ret 
			*/
			
			
			{
				base.PaintControl ();
			}
			
			private void x11d4d6bec891e7ac (object xe0292b9ed559da7d, ISkinChangedEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 63 Bytes
				.maxstack 3
				.locals (System.Windows.Forms.ListView V_0)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::Boolean get_IsDisposed()
				L_000b: brfalse.s L_000e
				L_000d: ret 
				L_000e: ldarg.0 
				L_000f: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0014: castclass System.Windows.Forms.ListView
				L_0019: stloc.0 
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589::System.Windows.Forms.BorderStyle xacfbd7a08ba56c78
				L_0020: brfalse.s L_003e
				L_0022: ldarg.0 
				L_0023: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0028: brfalse.s L_0032
				L_002a: ldloc.0 
				L_002b: ldc.i4.1 
				L_002c: callvirt System.Windows.Forms.ListView::Void set_BorderStyle(System.Windows.Forms.BorderStyle)
				L_0031: ret 
				L_0032: ldloc.0 
				L_0033: ldarg.0 
				L_0034: ldfld Sunisoft.IrisSkin.x1d3c48e32d645589::System.Windows.Forms.BorderStyle xacfbd7a08ba56c78
				L_0039: callvirt System.Windows.Forms.ListView::Void set_BorderStyle(System.Windows.Forms.BorderStyle)
				L_003e: ret 
			*/
			
			
			{
				if (base.xcd9cdf30888d2204.IsDisposed)
				{
					return;
				}
				ListView listView1 = ((ListView) base.xcd9cdf30888d2204);
				if (this.xacfbd7a08ba56c78 != BorderStyle.None)
				{
					if (base.xf2140268ef7ddbf7)
					{
						listView1.BorderStyle = BorderStyle.FixedSingle;
					}
					else
					{
						listView1.BorderStyle = this.xacfbd7a08ba56c78;
					}
				}
			}
			
		#endregion
	}
	
}

