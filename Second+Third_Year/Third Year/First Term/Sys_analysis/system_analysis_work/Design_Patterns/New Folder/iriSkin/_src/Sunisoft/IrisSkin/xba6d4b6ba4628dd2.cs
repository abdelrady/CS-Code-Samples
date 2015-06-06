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
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class xba6d4b6ba4628dd2 : x2edc3f693fe78d2e
	
	{
		
		#region Fields
			private Hashtable x4d8ef95511cad1be;
		#endregion
		
		#region Constructors
		
			public xba6d4b6ba4628dd2 (Control control, ISkinEngine engine)
				 : base (control, engine)
			/*
				// Code Size: 20 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: newobj System.Collections.Hashtable::Void .ctor()
				L_0006: stfld Sunisoft.IrisSkin.xba6d4b6ba4628dd2::System.Collections.Hashtable x4d8ef95511cad1be
				L_000b: ldarg.0 
				L_000c: ldarg.1 
				L_000d: ldarg.2 
				L_000e: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void .ctor(System.Windows.Forms.Control, Sunisoft.IrisSkin.SkinEngine)
				L_0013: ret 
			*/
		#endregion
		
		#region Properties
		
			protected override bool ChangeBackColor
			
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
		
			protected override void DoInit ()
			
			/*
				// Code Size: 43 Bytes
				.maxstack 5
				.locals (System.Windows.Forms.StatusBar V_0)
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.x2edc3f693fe78d2e::Void DoInit()
				L_0006: ldarg.0 
				L_0007: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_000c: castclass System.Windows.Forms.StatusBar
				L_0011: stloc.0 
				L_0012: ldloc.0 
				L_0013: ldarg.0 
				L_0014: ldftn Sunisoft.IrisSkin.xba6d4b6ba4628dd2::Void xfb5158b9af0961d6(System.Object, System.Windows.Forms.StatusBarDrawItemEventArgs)
				L_001a: newobj System.Windows.Forms.StatusBarDrawItemEventHandler::Void .ctor(System.Object, IntPtr)
				L_001f: callvirt System.Windows.Forms.StatusBar::Void add_DrawItem(System.Windows.Forms.StatusBarDrawItemEventHandler)
				L_0024: ldarg.0 
				L_0025: call Sunisoft.IrisSkin.xba6d4b6ba4628dd2::Void x62669b25bbf75a19()
				L_002a: ret 
			*/
			
			
			{
				base.DoInit ();
				StatusBar statusBar1 = ((StatusBar) base.xcd9cdf30888d2204);
				statusBar1.DrawItem += new StatusBarDrawItemEventHandler (this.xfb5158b9af0961d6);
				this.x62669b25bbf75a19 ();
			}
			
			protected override void OnCurrentSkinChanged (object sender, ISkinChangedEventArgs e)
			
			/*
				// Code Size: 15 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.xc56e4251b5681836::Void OnCurrentSkinChanged(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_0008: ldarg.0 
				L_0009: call Sunisoft.IrisSkin.xba6d4b6ba4628dd2::Void x62669b25bbf75a19()
				L_000e: ret 
			*/
			
			
			{
				base.OnCurrentSkinChanged (sender, e);
				this.x62669b25bbf75a19 ();
			}
			
			protected override void PaintControl ()
			
			/*
				// Code Size: 939 Bytes
				.maxstack 8
				.locals (System.Windows.Forms.StatusBar V_0, 
         System.Drawing.Brush V_1, 
         System.Drawing.Bitmap V_2, 
         System.Drawing.Graphics V_3, 
         System.Drawing.Rectangle V_4, 
         System.Drawing.Font V_5, 
         System.Drawing.StringFormat V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         System.Int32 V_9, 
         System.Int32 V_10, 
         System.Drawing.Rectangle V_11, 
         System.Windows.Forms.StatusBarPanel V_12, 
         System.Windows.Forms.ButtonBorderStyle V_13, 
         System.Drawing.StringFormat V_14, 
         System.Drawing.Graphics V_15, 
         System.Drawing.Rectangle V_16, 
         System.Collections.IEnumerator V_17, 
         System.Windows.Forms.HorizontalAlignment V_18, 
         System.IDisposable V_19)
				.try L_0152 to L_0358 finally L_0358 to L_036d
				.try L_0073 to L_036f finally L_036f to L_0379
				.try L_0386 to L_0392 finally L_0392 to L_039e
				.try L_006c to L_03a0 finally L_03a0 to L_03aa
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_000b: stloc.s V_16
				L_000d: ldloca.s V_16
				L_000f: call System.Drawing.Rectangle::Int32 get_Width()
				L_0014: ldc.i4.0 
				L_0015: ble.s L_002e
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_001d: callvirt System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_0022: stloc.s V_16
				L_0024: ldloca.s V_16
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
				L_003e: castclass System.Windows.Forms.StatusBar
				L_0043: stloc.0 
				L_0044: ldarg.0 
				L_0045: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_004a: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_004f: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0054: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_0059: stloc.1 
				L_005a: ldloc.0 
				L_005b: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0060: ldloc.0 
				L_0061: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0066: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_006b: stloc.2 
				L_006c: ldloc.2 
				L_006d: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0072: stloc.3 
				L_0073: ldloca.s V_4
				L_0075: ldc.i4.0 
				L_0076: ldc.i4.0 
				L_0077: ldloc.0 
				L_0078: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_007d: ldloc.0 
				L_007e: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0083: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0088: ldloc.3 
				L_0089: ldloc.1 
				L_008a: ldloc.s V_4
				L_008c: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0091: ldloc.0 
				L_0092: callvirt System.Windows.Forms.StatusBar::Boolean get_SizingGrip()
				L_0097: brfalse.s L_00b0
				L_0099: ldarg.0 
				L_009a: ldloc.3 
				L_009b: call Sunisoft.IrisSkin.xba6d4b6ba4628dd2::Void x3e99179c1c1e8d0c(System.Drawing.Graphics)
				L_00a0: ldloca.s V_4
				L_00a2: dup 
				L_00a3: call System.Drawing.Rectangle::Int32 get_Width()
				L_00a8: ldc.i4.s 17
				L_00aa: sub 
				L_00ab: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_00b0: ldloc.0 
				L_00b1: callvirt System.Windows.Forms.StatusBar::Boolean get_ShowPanels()
				L_00b6: brtrue L_013f
				L_00bb: ldarg.0 
				L_00bc: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00c1: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00c6: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_00cb: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_CONTROLFONTCOLOR()
				L_00d0: stloc.1 
				L_00d1: ldloc.0 
				L_00d2: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_00d7: stloc.s V_5
				L_00d9: ldloca.s V_4
				L_00db: call System.Drawing.Rectangle::Int32 get_Width()
				L_00e0: ldc.i4.0 
				L_00e1: ble L_036d
				L_00e6: newobj System.Drawing.StringFormat::Void .ctor()
				L_00eb: stloc.s V_6
				L_00ed: ldloc.0 
				L_00ee: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_00f3: ldc.i4.1 
				L_00f4: and 
				L_00f5: ldc.i4.1 
				L_00f6: bne.un.s L_0107
				L_00f8: ldloc.s V_6
				L_00fa: dup 
				L_00fb: callvirt System.Drawing.StringFormat::System.Drawing.StringFormatFlags get_FormatFlags()
				L_0100: ldc.i4.1 
				L_0101: or 
				L_0102: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_0107: ldloc.s V_6
				L_0109: ldc.i4.1 
				L_010a: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_010f: ldloc.s V_6
				L_0111: dup 
				L_0112: callvirt System.Drawing.StringFormat::System.Drawing.StringFormatFlags get_FormatFlags()
				L_0117: ldc.i4 4096
				L_011c: or 
				L_011d: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_0122: ldloc.3 
				L_0123: ldloc.0 
				L_0124: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_0129: ldloc.s V_5
				L_012b: ldloc.1 
				L_012c: ldloc.s V_4
				L_012e: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_0133: ldloc.s V_6
				L_0135: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_013a: br L_036d
				L_013f: ldc.i4.0 
				L_0140: stloc.s V_7
				L_0142: ldc.i4.0 
				L_0143: stloc.s V_9
				L_0145: ldloc.0 
				L_0146: callvirt System.Windows.Forms.StatusBar::StatusBarPanelCollection get_Panels()
				L_014b: callvirt System.Windows.Forms.StatusBar+StatusBarPanelCollection::System.Collections.IEnumerator GetEnumerator()
				L_0150: stloc.s V_17
				L_0152: br L_034a
				L_0157: ldloc.s V_17
				L_0159: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_015e: castclass System.Windows.Forms.StatusBarPanel
				L_0163: stloc.s V_12
				L_0165: ldloc.s V_12
				L_0167: callvirt System.Windows.Forms.StatusBarPanel::Int32 get_Width()
				L_016c: stloc.s V_10
				L_016e: ldarg.0 
				L_016f: ldfld Sunisoft.IrisSkin.xba6d4b6ba4628dd2::System.Collections.Hashtable x4d8ef95511cad1be
				L_0174: ldloc.s V_9
				L_0176: box System.Int32
				L_017b: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_0180: brfalse.s L_01b5
				L_0182: ldarg.0 
				L_0183: ldfld Sunisoft.IrisSkin.xba6d4b6ba4628dd2::System.Collections.Hashtable x4d8ef95511cad1be
				L_0188: ldloc.s V_9
				L_018a: box System.Int32
				L_018f: callvirt System.Collections.Hashtable::System.Object get_Item(System.Object)
				L_0194: isinst System.Int32
				L_0199: brfalse.s L_01b5
				L_019b: ldarg.0 
				L_019c: ldfld Sunisoft.IrisSkin.xba6d4b6ba4628dd2::System.Collections.Hashtable x4d8ef95511cad1be
				L_01a1: ldloc.s V_9
				L_01a3: box System.Int32
				L_01a8: callvirt System.Collections.Hashtable::System.Object get_Item(System.Object)
				L_01ad: unbox System.Int32
				L_01b2: ldind.i4 
				L_01b3: stloc.s V_10
				L_01b5: ldarg.0 
				L_01b6: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01bb: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_01c0: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_01c5: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_CONTROLBORDERCOLOR()
				L_01ca: stloc.1 
				L_01cb: ldloc.s V_7
				L_01cd: ldloc.s V_10
				L_01cf: add 
				L_01d0: stloc.s V_8
				L_01d2: ldloc.s V_12
				L_01d4: callvirt System.Windows.Forms.StatusBarPanel::System.Windows.Forms.StatusBarPanelBorderStyle get_BorderStyle()
				L_01d9: ldc.i4.1 
				L_01da: bne.un.s L_01e1
				L_01dc: ldc.i4.0 
				L_01dd: stloc.s V_13
				L_01df: br.s L_01f3
				L_01e1: ldloc.s V_12
				L_01e3: callvirt System.Windows.Forms.StatusBarPanel::System.Windows.Forms.StatusBarPanelBorderStyle get_BorderStyle()
				L_01e8: ldc.i4.2 
				L_01e9: bne.un.s L_01f0
				L_01eb: ldc.i4.5 
				L_01ec: stloc.s V_13
				L_01ee: br.s L_01f3
				L_01f0: ldc.i4.4 
				L_01f1: stloc.s V_13
				L_01f3: ldloc.s V_7
				L_01f5: ldc.i4.1 
				L_01f6: add 
				L_01f7: ldloca.s V_4
				L_01f9: call System.Drawing.Rectangle::Int32 get_Top()
				L_01fe: ldc.i4.1 
				L_01ff: add 
				L_0200: ldloc.s V_8
				L_0202: ldloca.s V_4
				L_0204: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0209: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_020e: stloc.s V_11
				L_0210: ldloc.3 
				L_0211: ldloc.s V_11
				L_0213: ldarg.0 
				L_0214: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0219: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_021e: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0223: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_CONTROLBORDERCOLOR
				L_0228: ldloc.s V_13
				L_022a: call System.Windows.Forms.ControlPaint::Void DrawBorder(System.Drawing.Graphics, System.Drawing.Rectangle, System.Drawing.Color, System.Windows.Forms.ButtonBorderStyle)
				L_022f: ldarg.0 
				L_0230: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0235: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_023a: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_023f: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_CONTROLFONTCOLOR()
				L_0244: stloc.1 
				L_0245: ldloc.s V_12
				L_0247: callvirt System.Windows.Forms.StatusBarPanel::System.Drawing.Icon get_Icon()
				L_024c: brfalse.s L_02ba
				L_024e: ldloc.3 
				L_024f: ldloc.s V_12
				L_0251: callvirt System.Windows.Forms.StatusBarPanel::System.Drawing.Icon get_Icon()
				L_0256: ldloca.s V_11
				L_0258: call System.Drawing.Rectangle::Int32 get_X()
				L_025d: ldc.i4.4 
				L_025e: add 
				L_025f: ldloca.s V_11
				L_0261: call System.Drawing.Rectangle::Int32 get_Top()
				L_0266: ldloca.s V_11
				L_0268: call System.Drawing.Rectangle::Int32 get_Height()
				L_026d: ldloc.s V_12
				L_026f: callvirt System.Windows.Forms.StatusBarPanel::System.Drawing.Icon get_Icon()
				L_0274: callvirt System.Drawing.Icon::Int32 get_Height()
				L_0279: sub 
				L_027a: ldc.i4.2 
				L_027b: div 
				L_027c: add 
				L_027d: callvirt System.Drawing.Graphics::Void DrawIcon(System.Drawing.Icon, Int32, Int32)
				L_0282: ldloca.s V_11
				L_0284: dup 
				L_0285: call System.Drawing.Rectangle::Int32 get_X()
				L_028a: ldc.i4.6 
				L_028b: ldloc.s V_12
				L_028d: callvirt System.Windows.Forms.StatusBarPanel::System.Drawing.Icon get_Icon()
				L_0292: callvirt System.Drawing.Icon::Int32 get_Width()
				L_0297: add 
				L_0298: add 
				L_0299: call System.Drawing.Rectangle::Void set_X(Int32)
				L_029e: ldloca.s V_11
				L_02a0: dup 
				L_02a1: call System.Drawing.Rectangle::Int32 get_Width()
				L_02a6: ldc.i4.6 
				L_02a7: ldloc.s V_12
				L_02a9: callvirt System.Windows.Forms.StatusBarPanel::System.Drawing.Icon get_Icon()
				L_02ae: callvirt System.Drawing.Icon::Int32 get_Width()
				L_02b3: add 
				L_02b4: sub 
				L_02b5: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_02ba: ldloca.s V_11
				L_02bc: call System.Drawing.Rectangle::Int32 get_Width()
				L_02c1: ldc.i4.0 
				L_02c2: ble L_0340
				L_02c7: newobj System.Drawing.StringFormat::Void .ctor()
				L_02cc: stloc.s V_14
				L_02ce: ldloc.s V_14
				L_02d0: ldc.i4.1 
				L_02d1: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_02d6: ldloc.s V_14
				L_02d8: dup 
				L_02d9: callvirt System.Drawing.StringFormat::System.Drawing.StringFormatFlags get_FormatFlags()
				L_02de: ldc.i4 4096
				L_02e3: or 
				L_02e4: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_02e9: ldloc.s V_12
				L_02eb: callvirt System.Windows.Forms.StatusBarPanel::System.Windows.Forms.HorizontalAlignment get_Alignment()
				L_02f0: stloc.s V_18
				L_02f2: ldloc.s V_18
				L_02f4: switch (L_0307, L_031b, L_0311)
				L_0305: br.s L_0323
				L_0307: ldloc.s V_14
				L_0309: ldc.i4.0 
				L_030a: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_030f: br.s L_0323
				L_0311: ldloc.s V_14
				L_0313: ldc.i4.1 
				L_0314: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_0319: br.s L_0323
				L_031b: ldloc.s V_14
				L_031d: ldc.i4.2 
				L_031e: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_0323: ldloc.3 
				L_0324: ldloc.s V_12
				L_0326: callvirt System.Windows.Forms.StatusBarPanel::System.String get_Text()
				L_032b: ldloc.0 
				L_032c: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_0331: ldloc.1 
				L_0332: ldloc.s V_11
				L_0334: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_0339: ldloc.s V_14
				L_033b: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_0340: ldloc.s V_8
				L_0342: stloc.s V_7
				L_0344: ldloc.s V_9
				L_0346: ldc.i4.1 
				L_0347: add 
				L_0348: stloc.s V_9
				L_034a: ldloc.s V_17
				L_034c: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0351: brtrue L_0157
				L_0356: leave.s L_036d
				L_0358: ldloc.s V_17
				L_035a: isinst System.IDisposable
				L_035f: stloc.s V_19
				L_0361: ldloc.s V_19
				L_0363: brfalse.s L_036c
				L_0365: ldloc.s V_19
				L_0367: callvirt System.IDisposable::Void Dispose()
				L_036c: endfinally 
				L_036d: leave.s L_0379
				L_036f: ldloc.3 
				L_0370: brfalse.s L_0378
				L_0372: ldloc.3 
				L_0373: callvirt System.IDisposable::Void Dispose()
				L_0378: endfinally 
				L_0379: ldloc.0 
				L_037a: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_037f: call System.Drawing.Graphics::System.Drawing.Graphics FromHwnd(IntPtr)
				L_0384: stloc.s V_15
				L_0386: ldloc.s V_15
				L_0388: ldloc.2 
				L_0389: ldc.i4.0 
				L_038a: ldc.i4.0 
				L_038b: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_0390: leave.s L_039e
				L_0392: ldloc.s V_15
				L_0394: brfalse.s L_039d
				L_0396: ldloc.s V_15
				L_0398: callvirt System.IDisposable::Void Dispose()
				L_039d: endfinally 
				L_039e: leave.s L_03aa
				L_03a0: ldloc.2 
				L_03a1: brfalse.s L_03a9
				L_03a3: ldloc.2 
				L_03a4: callvirt System.IDisposable::Void Dispose()
				L_03a9: endfinally 
				L_03aa: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Font font1;
				StringFormat stringFormat1;
				int i1;
				int i2;
				int i3;
				int i4;
				Rectangle rectangle2;
				StatusBarPanel statusBarPanel1;
				ButtonBorderStyle buttonBorderStyle1;
				StringFormat stringFormat2;
				IEnumerator iEnumerator1;
				HorizontalAlignment horizontalAlignment1;
				IDisposable iDisposable1;
				if (((base.xcd9cdf30888d2204.ClientRectangle.Width <= 0) || (base.xcd9cdf30888d2204.ClientRectangle.Height <= 0)) || (! base.xf2140268ef7ddbf7))
				{
					return;
				}
				StatusBar statusBar1 = ((StatusBar) base.xcd9cdf30888d2204);
				Brush brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR;
				using (Bitmap bitmap1 = new Bitmap (statusBar1.Width, statusBar1.Height))
				{
					using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap1)))
					{
						rectangle1 = new Rectangle (0, 0, statusBar1.Width, statusBar1.Height);
						graphics1.FillRectangle (brush1, rectangle1);
						if (statusBar1.SizingGrip)
						{
							this.x3e99179c1c1e8d0c (graphics1);
							rectangle1.Width -= 17;
						}
						if (! statusBar1.ShowPanels)
						{
							brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_CONTROLFONTCOLOR;
							font1 = statusBar1.Font;
							if (rectangle1.Width > 0)
							{
								stringFormat1 = new StringFormat ();
								if ((statusBar1.RightToLeft & RightToLeft.Yes) == RightToLeft.Yes)
								{
									stringFormat1.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
								}
								stringFormat1.LineAlignment = StringAlignment.Center;
								stringFormat1.FormatFlags |= StringFormatFlags.NoWrap;
								graphics1.DrawString (statusBar1.Text, font1, brush1, ((RectangleF) rectangle1), stringFormat1);
							}
						}
						else
						{
							i1 = 0;
							i3 = 0;
							iEnumerator1 = statusBar1.Panels.GetEnumerator ();
							try
							{
								goto L_034A;
								
							L_01F3:
								
								{
								}
								rectangle2 = Rectangle.FromLTRB (((int) (i1 + 1)), ((int) (rectangle1.Top + 1)), i2, rectangle1.Bottom);
								ControlPaint.DrawBorder (graphics1, rectangle2, ((SkinColors) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Colors).SKIN2_CONTROLBORDERCOLOR, buttonBorderStyle1);
								brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_CONTROLFONTCOLOR;
								if (statusBarPanel1.Icon != null)
								{
									graphics1.DrawIcon (statusBarPanel1.Icon, ((int) (rectangle2.X + 4)), ((int) (rectangle2.Top + ((rectangle2.Height - statusBarPanel1.Icon.Height) / 2))));
									rectangle2.X += (6 + statusBarPanel1.Icon.Width);
									rectangle2.Width -= (6 + statusBarPanel1.Icon.Width);
								}
								if (rectangle2.Width > 0)
								{
									stringFormat2 = new StringFormat ();
									stringFormat2.LineAlignment = StringAlignment.Center;
									stringFormat2.FormatFlags |= StringFormatFlags.NoWrap;
									horizontalAlignment1 = statusBarPanel1.Alignment;
									switch (horizontalAlignment1)
									{
										case HorizontalAlignment.Left:
										
										{
												stringFormat2.Alignment = StringAlignment.Near;
												break;
										}
										case HorizontalAlignment.Right:
										
										{
												stringFormat2.Alignment = StringAlignment.Far;
												break;
										}
										case HorizontalAlignment.Center:
										
										{
												stringFormat2.Alignment = StringAlignment.Center;
												break;
										}
									}
									graphics1.DrawString (statusBarPanel1.Text, statusBar1.Font, brush1, ((RectangleF) rectangle2), stringFormat2);
								}
								i1 = i2;
								i3++;
								
							L_034A:
								
								{
								}
								while (iEnumerator1.MoveNext ())
								{
									statusBarPanel1 = ((StatusBarPanel) iEnumerator1.Current);
									i4 = statusBarPanel1.Width;
									if (this.x4d8ef95511cad1be.ContainsKey (i3) && (this.x4d8ef95511cad1be[i3] is int))
									{
										i4 = ((int) this.x4d8ef95511cad1be[i3]);
									}
									brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_CONTROLBORDERCOLOR;
									i2 = (i1 + i4);
									if (statusBarPanel1.BorderStyle == StatusBarPanelBorderStyle.None)
									{
										buttonBorderStyle1 = ButtonBorderStyle.None;
										goto L_01F3;
									}
									if (statusBarPanel1.BorderStyle == StatusBarPanelBorderStyle.Raised)
									{
										buttonBorderStyle1 = ButtonBorderStyle.Outset;
										goto L_01F3;
									}
									buttonBorderStyle1 = ButtonBorderStyle.Inset;
									goto L_01F3;
								}
							}
							finally
							{
								iDisposable1 = (iEnumerator1 as IDisposable);
								if (iDisposable1 != null)
								{
									iDisposable1.Dispose ();
								}
							}
						}
					}
					using (Graphics graphics2 = Graphics.FromHwnd (statusBar1.Handle))
					{
						graphics2.DrawImageUnscaled (((Image) bitmap1), 0, 0);
					}
				}
			}
			
			protected void x3e99179c1c1e8d0c (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 358 Bytes
				.maxstack 8
				.locals (System.Windows.Forms.StatusBar V_0, 
         System.Drawing.Rectangle V_1, 
         System.Drawing.Brush V_2, 
         System.Drawing.Pen V_3)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.StatusBar
				L_000b: stloc.0 
				L_000c: ldloc.0 
				L_000d: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0012: ldc.i4.s 16
				L_0014: sub 
				L_0015: ldloc.0 
				L_0016: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_001b: ldc.i4.s 15
				L_001d: sub 
				L_001e: ldloc.0 
				L_001f: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0024: ldc.i4.1 
				L_0025: sub 
				L_0026: ldloc.0 
				L_0027: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_002c: ldc.i4.1 
				L_002d: sub 
				L_002e: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0033: stloc.1 
				L_0034: ldarg.0 
				L_0035: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_003a: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_003f: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0044: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_0049: stloc.2 
				L_004a: ldarg.1 
				L_004b: ldloc.2 
				L_004c: ldloc.1 
				L_004d: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0052: ldc.i4.s 17
				L_0054: call System.Drawing.Color::System.Drawing.Color FromKnownColor(System.Drawing.KnownColor)
				L_0059: ldc.r4 1
				L_005e: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color, Single)
				L_0063: stloc.3 
				L_0064: ldarg.1 
				L_0065: ldloc.3 
				L_0066: ldloca.s V_1
				L_0068: call System.Drawing.Rectangle::Int32 get_Left()
				L_006d: ldc.i4.1 
				L_006e: add 
				L_006f: ldloca.s V_1
				L_0071: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0076: ldloca.s V_1
				L_0078: call System.Drawing.Rectangle::Int32 get_Right()
				L_007d: ldloca.s V_1
				L_007f: call System.Drawing.Rectangle::Int32 get_Top()
				L_0084: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0089: ldarg.1 
				L_008a: ldloc.3 
				L_008b: ldloca.s V_1
				L_008d: call System.Drawing.Rectangle::Int32 get_Left()
				L_0092: ldc.i4.5 
				L_0093: add 
				L_0094: ldloca.s V_1
				L_0096: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_009b: ldloca.s V_1
				L_009d: call System.Drawing.Rectangle::Int32 get_Right()
				L_00a2: ldloca.s V_1
				L_00a4: call System.Drawing.Rectangle::Int32 get_Top()
				L_00a9: ldc.i4.4 
				L_00aa: add 
				L_00ab: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00b0: ldarg.1 
				L_00b1: ldloc.3 
				L_00b2: ldloca.s V_1
				L_00b4: call System.Drawing.Rectangle::Int32 get_Left()
				L_00b9: ldc.i4.s 9
				L_00bb: add 
				L_00bc: ldloca.s V_1
				L_00be: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_00c3: ldloca.s V_1
				L_00c5: call System.Drawing.Rectangle::Int32 get_Right()
				L_00ca: ldloca.s V_1
				L_00cc: call System.Drawing.Rectangle::Int32 get_Top()
				L_00d1: ldc.i4.8 
				L_00d2: add 
				L_00d3: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00d8: ldarg.1 
				L_00d9: ldloc.3 
				L_00da: ldloca.s V_1
				L_00dc: call System.Drawing.Rectangle::Int32 get_Left()
				L_00e1: ldc.i4.s 13
				L_00e3: add 
				L_00e4: ldloca.s V_1
				L_00e6: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_00eb: ldloca.s V_1
				L_00ed: call System.Drawing.Rectangle::Int32 get_Right()
				L_00f2: ldloca.s V_1
				L_00f4: call System.Drawing.Rectangle::Int32 get_Top()
				L_00f9: ldc.i4.s 12
				L_00fb: add 
				L_00fc: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0101: ldloc.0 
				L_0102: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0107: ldc.i4.s 15
				L_0109: sub 
				L_010a: ldc.i4.3 
				L_010b: ble.s L_0136
				L_010d: ldloc.0 
				L_010e: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0113: ldc.i4.s 16
				L_0115: sub 
				L_0116: ldc.i4.3 
				L_0117: ldloc.0 
				L_0118: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_011d: ldc.i4.1 
				L_011e: sub 
				L_011f: ldloc.0 
				L_0120: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_0125: ldc.i4.s 15
				L_0127: sub 
				L_0128: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_012d: stloc.1 
				L_012e: ldarg.1 
				L_012f: ldloc.2 
				L_0130: ldloc.1 
				L_0131: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0136: ldloc.0 
				L_0137: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_013c: ldc.i4.s 20
				L_013e: sub 
				L_013f: ldc.i4.3 
				L_0140: ldloc.0 
				L_0141: callvirt System.Windows.Forms.Control::Int32 get_Width()
				L_0146: ldc.i4.s 16
				L_0148: sub 
				L_0149: ldloc.0 
				L_014a: callvirt System.Windows.Forms.Control::Int32 get_Height()
				L_014f: ldc.i4.1 
				L_0150: sub 
				L_0151: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0156: stloc.1 
				L_0157: ldarg.1 
				L_0158: ldloc.2 
				L_0159: ldloc.1 
				L_015a: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_015f: ldloc.3 
				L_0160: callvirt System.Drawing.Pen::Void Dispose()
				L_0165: ret 
			*/
			
			
			{
				StatusBar statusBar1 = ((StatusBar) base.xcd9cdf30888d2204);
				Rectangle rectangle1 = Rectangle.FromLTRB (((int) (statusBar1.Width - 16)), ((int) (statusBar1.Height - 15)), ((int) (statusBar1.Width - 1)), ((int) (statusBar1.Height - 1)));
				Brush brush1 = ((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR;
				x4b101060f4767186.FillRectangle (brush1, rectangle1);
				Pen pen1 = new Pen (Color.FromKnownColor (KnownColor.InactiveCaption), 1F);
				x4b101060f4767186.DrawLine (pen1, ((int) (rectangle1.Left + 1)), rectangle1.Bottom, rectangle1.Right, rectangle1.Top);
				x4b101060f4767186.DrawLine (pen1, ((int) (rectangle1.Left + 5)), rectangle1.Bottom, rectangle1.Right, ((int) (rectangle1.Top + 4)));
				x4b101060f4767186.DrawLine (pen1, ((int) (rectangle1.Left + 9)), rectangle1.Bottom, rectangle1.Right, ((int) (rectangle1.Top + 8)));
				x4b101060f4767186.DrawLine (pen1, ((int) (rectangle1.Left + 13)), rectangle1.Bottom, rectangle1.Right, ((int) (rectangle1.Top + 12)));
				if ((statusBar1.Height - 15) > 3)
				{
					rectangle1 = Rectangle.FromLTRB (((int) (statusBar1.Width - 16)), 3, ((int) (statusBar1.Width - 1)), ((int) (statusBar1.Height - 15)));
					x4b101060f4767186.FillRectangle (brush1, rectangle1);
				}
				rectangle1 = Rectangle.FromLTRB (((int) (statusBar1.Width - 20)), 3, ((int) (statusBar1.Width - 16)), ((int) (statusBar1.Height - 1)));
				x4b101060f4767186.FillRectangle (brush1, rectangle1);
				pen1.Dispose ();
			}
			
			private void x62669b25bbf75a19 ()
			
			/*
				// Code Size: 147 Bytes
				.maxstack 3
				.locals (System.Windows.Forms.StatusBar V_0, 
         System.Windows.Forms.StatusBarPanel V_1, 
         System.Windows.Forms.StatusBarPanel V_2, 
         System.Collections.IEnumerator V_3, 
         System.IDisposable V_4)
				.try L_0020 to L_003f finally L_003f to L_0053
				.try L_005f to L_007e finally L_007e to L_0092
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xbd3f2493841f18a1::System.Windows.Forms.Control xcd9cdf30888d2204
				L_0006: castclass System.Windows.Forms.StatusBar
				L_000b: stloc.0 
				L_000c: ldarg.0 
				L_000d: call Sunisoft.IrisSkin.xbd3f2493841f18a1::Boolean get_xf2140268ef7ddbf7()
				L_0012: brfalse.s L_0053
				L_0014: ldloc.0 
				L_0015: callvirt System.Windows.Forms.StatusBar::StatusBarPanelCollection get_Panels()
				L_001a: callvirt System.Windows.Forms.StatusBar+StatusBarPanelCollection::System.Collections.IEnumerator GetEnumerator()
				L_001f: stloc.3 
				L_0020: br.s L_0035
				L_0022: ldloc.3 
				L_0023: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0028: castclass System.Windows.Forms.StatusBarPanel
				L_002d: stloc.1 
				L_002e: ldloc.1 
				L_002f: ldc.i4.2 
				L_0030: callvirt System.Windows.Forms.StatusBarPanel::Void set_Style(System.Windows.Forms.StatusBarPanelStyle)
				L_0035: ldloc.3 
				L_0036: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_003b: brtrue.s L_0022
				L_003d: leave.s L_0092
				L_003f: ldloc.3 
				L_0040: isinst System.IDisposable
				L_0045: stloc.s V_4
				L_0047: ldloc.s V_4
				L_0049: brfalse.s L_0052
				L_004b: ldloc.s V_4
				L_004d: callvirt System.IDisposable::Void Dispose()
				L_0052: endfinally 
				L_0053: ldloc.0 
				L_0054: callvirt System.Windows.Forms.StatusBar::StatusBarPanelCollection get_Panels()
				L_0059: callvirt System.Windows.Forms.StatusBar+StatusBarPanelCollection::System.Collections.IEnumerator GetEnumerator()
				L_005e: stloc.3 
				L_005f: br.s L_0074
				L_0061: ldloc.3 
				L_0062: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0067: castclass System.Windows.Forms.StatusBarPanel
				L_006c: stloc.2 
				L_006d: ldloc.2 
				L_006e: ldc.i4.1 
				L_006f: callvirt System.Windows.Forms.StatusBarPanel::Void set_Style(System.Windows.Forms.StatusBarPanelStyle)
				L_0074: ldloc.3 
				L_0075: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_007a: brtrue.s L_0061
				L_007c: leave.s L_0092
				L_007e: ldloc.3 
				L_007f: isinst System.IDisposable
				L_0084: stloc.s V_4
				L_0086: ldloc.s V_4
				L_0088: brfalse.s L_0091
				L_008a: ldloc.s V_4
				L_008c: callvirt System.IDisposable::Void Dispose()
				L_0091: endfinally 
				L_0092: ret 
			*/
			
			
			{
				StatusBar statusBar1 = ((StatusBar) base.xcd9cdf30888d2204);
				if (base.xf2140268ef7ddbf7)
				{
					foreach (StatusBarPanel statusBarPanel1 in statusBar1.Panels)
					{
						statusBarPanel1.Style = StatusBarPanelStyle.OwnerDraw;
					}
				}
				else
				{
					foreach (StatusBarPanel statusBarPanel2 in statusBar1.Panels)
					{
						statusBarPanel2.Style = StatusBarPanelStyle.Text;
					}
				}
			}
			
			private void xfb5158b9af0961d6 (object xe0292b9ed559da7d, StatusBarDrawItemEventArgs xedd3aee327ed365e)
			
			/*
				// Code Size: 108 Bytes
				.maxstack 5
				.locals (System.Drawing.Rectangle V_0)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.xba6d4b6ba4628dd2::System.Collections.Hashtable x4d8ef95511cad1be
				L_0006: ldarg.2 
				L_0007: callvirt System.Windows.Forms.DrawItemEventArgs::Int32 get_Index()
				L_000c: box System.Int32
				L_0011: callvirt System.Collections.Hashtable::Boolean ContainsKey(System.Object)
				L_0016: brfalse.s L_0042
				L_0018: ldarg.0 
				L_0019: ldfld Sunisoft.IrisSkin.xba6d4b6ba4628dd2::System.Collections.Hashtable x4d8ef95511cad1be
				L_001e: ldarg.2 
				L_001f: callvirt System.Windows.Forms.DrawItemEventArgs::Int32 get_Index()
				L_0024: box System.Int32
				L_0029: ldarg.2 
				L_002a: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Rectangle get_Bounds()
				L_002f: stloc.0 
				L_0030: ldloca.s V_0
				L_0032: call System.Drawing.Rectangle::Int32 get_Width()
				L_0037: box System.Int32
				L_003c: callvirt System.Collections.Hashtable::Void set_Item(System.Object, System.Object)
				L_0041: ret 
				L_0042: ldarg.0 
				L_0043: ldfld Sunisoft.IrisSkin.xba6d4b6ba4628dd2::System.Collections.Hashtable x4d8ef95511cad1be
				L_0048: ldarg.2 
				L_0049: callvirt System.Windows.Forms.DrawItemEventArgs::Int32 get_Index()
				L_004e: box System.Int32
				L_0053: ldarg.2 
				L_0054: callvirt System.Windows.Forms.DrawItemEventArgs::System.Drawing.Rectangle get_Bounds()
				L_0059: stloc.0 
				L_005a: ldloca.s V_0
				L_005c: call System.Drawing.Rectangle::Int32 get_Width()
				L_0061: box System.Int32
				L_0066: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_006b: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				if (this.x4d8ef95511cad1be.ContainsKey (xedd3aee327ed365e.Index))
				{
					this.x4d8ef95511cad1be[xedd3aee327ed365e.Index] = (rectangle1 = xedd3aee327ed365e.Bounds).Width;
				}
				else
				{
					rectangle1 = xedd3aee327ed365e.Bounds;
					this.x4d8ef95511cad1be.Add (xedd3aee327ed365e.Index, rectangle1.Width);
				}
			}
			
		#endregion
	}
	
}

