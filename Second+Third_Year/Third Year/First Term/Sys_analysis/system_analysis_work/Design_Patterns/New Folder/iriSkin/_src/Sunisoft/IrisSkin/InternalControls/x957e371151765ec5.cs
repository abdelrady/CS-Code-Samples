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
			using System.Drawing.Drawing2D;
			using System.Drawing.Imaging;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	internal class x957e371151765ec5
	
	{
		
		#region Fields
			protected static IntPtr xd31bf1dadb599901;
		#endregion
		
		#region Constructors
		
			static x957e371151765ec5 ()
			/*
				// Code Size: 11 Bytes
				.maxstack 9
				L_0000: ldsfld System.IntPtr::IntPtr Zero
				L_0005: stsfld Sunisoft.IrisSkin.InternalControls.x957e371151765ec5::IntPtr xd31bf1dadb599901
				L_000a: ret 
			*/
			
			public x957e371151765ec5 ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ret 
			*/
		#endregion
		
		#region Methods
		
			public static void x00fe3cf832df63e0 (Graphics x4b101060f4767186, xdbfa333b4cd503e0 x23e85093ba3a7d1d, Rectangle xf78cf2936de01d72, x44fcc2f4d57dc4d8 x01b557925841ae51, Color x6f860ed2fc55db9e, Color x7770c6d75dbb1a79, Color x313e500082f76496)
			
			/*
				// Code Size: 159 Bytes
				.maxstack 7
				.locals (System.Drawing.Rectangle V_0, 
         System.Drawing.SolidBrush V_1, 
         System.Drawing.SolidBrush V_2, 
         System.Drawing.Pen V_3, 
         Sunisoft.IrisSkin.x44fcc2f4d57dc4d8 V_4)
				.try L_0046 to L_0050 finally L_0050 to L_005a
				.try L_006e to L_0078 finally L_0078 to L_0082
				.try L_008a to L_0094 finally L_0094 to L_009e
				L_0000: ldloca.s V_0
				L_0002: ldarga.s xf78cf2936de01d72
				L_0004: call System.Drawing.Rectangle::Int32 get_Left()
				L_0009: ldarga.s xf78cf2936de01d72
				L_000b: call System.Drawing.Rectangle::Int32 get_Top()
				L_0010: ldarga.s xf78cf2936de01d72
				L_0012: call System.Drawing.Rectangle::Int32 get_Width()
				L_0017: ldc.i4.1 
				L_0018: sub 
				L_0019: ldarga.s xf78cf2936de01d72
				L_001b: call System.Drawing.Rectangle::Int32 get_Height()
				L_0020: ldc.i4.1 
				L_0021: sub 
				L_0022: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0027: ldarg.3 
				L_0028: stloc.s V_4
				L_002a: ldloc.s V_4
				L_002c: switch (L_003e, L_005a, L_009e)
				L_003d: ret 
				L_003e: ldarg.s x6f860ed2fc55db9e
				L_0040: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0045: stloc.1 
				L_0046: ldarg.0 
				L_0047: ldloc.1 
				L_0048: ldloc.0 
				L_0049: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_004e: leave.s L_009e
				L_0050: ldloc.1 
				L_0051: brfalse.s L_0059
				L_0053: ldloc.1 
				L_0054: callvirt System.IDisposable::Void Dispose()
				L_0059: endfinally 
				L_005a: ldarg.0 
				L_005b: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_0060: ldloc.0 
				L_0061: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0066: ldarg.s x7770c6d75dbb1a79
				L_0068: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_006d: stloc.2 
				L_006e: ldarg.0 
				L_006f: ldloc.2 
				L_0070: ldloc.0 
				L_0071: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0076: leave.s L_0082
				L_0078: ldloc.2 
				L_0079: brfalse.s L_0081
				L_007b: ldloc.2 
				L_007c: callvirt System.IDisposable::Void Dispose()
				L_0081: endfinally 
				L_0082: ldarg.s x313e500082f76496
				L_0084: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0089: stloc.3 
				L_008a: ldarg.0 
				L_008b: ldloc.3 
				L_008c: ldloc.0 
				L_008d: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_0092: leave.s L_009e
				L_0094: ldloc.3 
				L_0095: brfalse.s L_009d
				L_0097: ldloc.3 
				L_0098: callvirt System.IDisposable::Void Dispose()
				L_009d: endfinally 
				L_009e: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				rectangle1 = new Rectangle (xf78cf2936de01d72.Left, xf78cf2936de01d72.Top, ((int) (xf78cf2936de01d72.Width - 1)), ((int) (xf78cf2936de01d72.Height - 1)));
				switch (x01b557925841ae51)
				{
					case x44fcc2f4d57dc4d8.xe9e531d1a6725226:
					
					{
							using (SolidBrush solidBrush1 = new SolidBrush (x6f860ed2fc55db9e))
							{
								x4b101060f4767186.FillRectangle (((Brush) solidBrush1), rectangle1);
								return;
							}
					}
					case x44fcc2f4d57dc4d8.xab312eebbbeecf84:
					
					{
							x4b101060f4767186.FillRectangle (Brushes.White, rectangle1);
							using (SolidBrush solidBrush2 = new SolidBrush (x7770c6d75dbb1a79))
							{
								x4b101060f4767186.FillRectangle (((Brush) solidBrush2), rectangle1);
							}
							using (Pen pen1 = new Pen (x313e500082f76496))
							{
								x4b101060f4767186.DrawRectangle (pen1, rectangle1);
							}
							return;
					}
					case x44fcc2f4d57dc4d8.xe24085eac971e032:
					
					{
							return;
					}
				}
				return;
				
				/*
					Unreachable Code
					return;
				*/
			}
			
			public static void x0b3d5231480b19ac (Graphics x4b101060f4767186, Rectangle x26545669838eb36e, Color xa7bf5f1d8010ffbc, Color x6f860ed2fc55db9e, Color x2a874aaea1ef79cd, Color x203ed3379fa39cc5)
			
			/*
				// Code Size: 403 Bytes
				.maxstack 8
				.locals (System.Drawing.Pen V_0, 
         System.Drawing.Pen V_1, 
         System.Drawing.Pen V_2, 
         System.Drawing.Pen V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Int32 V_7)
				.try L_0038 to L_0164 finally L_0164 to L_016e
				.try L_0030 to L_0170 finally L_0170 to L_017a
				.try L_0028 to L_017c finally L_017c to L_0186
				.try L_0021 to L_0188 finally L_0188 to L_0192
				L_0000: ldarga.s x26545669838eb36e
				L_0002: call System.Drawing.Rectangle::Int32 get_Width()
				L_0007: ldc.i4.2 
				L_0008: ble L_0192
				L_000d: ldarga.s x26545669838eb36e
				L_000f: call System.Drawing.Rectangle::Int32 get_Height()
				L_0014: ldc.i4.2 
				L_0015: ble L_0192
				L_001a: ldarg.2 
				L_001b: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0020: stloc.0 
				L_0021: ldarg.3 
				L_0022: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0027: stloc.1 
				L_0028: ldarg.s x2a874aaea1ef79cd
				L_002a: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_002f: stloc.2 
				L_0030: ldarg.s x203ed3379fa39cc5
				L_0032: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0037: stloc.3 
				L_0038: ldarga.s x26545669838eb36e
				L_003a: call System.Drawing.Rectangle::Int32 get_Left()
				L_003f: stloc.s V_4
				L_0041: ldarga.s x26545669838eb36e
				L_0043: call System.Drawing.Rectangle::Int32 get_Top()
				L_0048: stloc.s V_5
				L_004a: ldarga.s x26545669838eb36e
				L_004c: call System.Drawing.Rectangle::Int32 get_Right()
				L_0051: stloc.s V_6
				L_0053: ldarga.s x26545669838eb36e
				L_0055: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_005a: stloc.s V_7
				L_005c: ldarg.0 
				L_005d: ldloc.1 
				L_005e: ldloc.s V_6
				L_0060: ldc.i4.1 
				L_0061: sub 
				L_0062: ldloc.s V_5
				L_0064: ldloc.s V_4
				L_0066: ldloc.s V_5
				L_0068: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_006d: ldarg.0 
				L_006e: ldloc.0 
				L_006f: ldloc.s V_6
				L_0071: ldc.i4.2 
				L_0072: sub 
				L_0073: ldloc.s V_5
				L_0075: ldc.i4.1 
				L_0076: add 
				L_0077: ldloc.s V_4
				L_0079: ldc.i4.1 
				L_007a: add 
				L_007b: ldloc.s V_5
				L_007d: ldc.i4.1 
				L_007e: add 
				L_007f: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0084: ldarg.0 
				L_0085: ldloc.1 
				L_0086: ldloc.s V_6
				L_0088: ldc.i4.3 
				L_0089: sub 
				L_008a: ldloc.s V_5
				L_008c: ldc.i4.2 
				L_008d: add 
				L_008e: ldloc.s V_4
				L_0090: ldc.i4.2 
				L_0091: add 
				L_0092: ldloc.s V_5
				L_0094: ldc.i4.2 
				L_0095: add 
				L_0096: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_009b: ldarg.0 
				L_009c: ldloc.1 
				L_009d: ldloc.s V_4
				L_009f: ldloc.s V_5
				L_00a1: ldloc.s V_4
				L_00a3: ldloc.s V_7
				L_00a5: ldc.i4.1 
				L_00a6: sub 
				L_00a7: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00ac: ldarg.0 
				L_00ad: ldloc.0 
				L_00ae: ldloc.s V_4
				L_00b0: ldc.i4.1 
				L_00b1: add 
				L_00b2: ldloc.s V_5
				L_00b4: ldc.i4.1 
				L_00b5: add 
				L_00b6: ldloc.s V_4
				L_00b8: ldc.i4.1 
				L_00b9: add 
				L_00ba: ldloc.s V_7
				L_00bc: ldc.i4.2 
				L_00bd: sub 
				L_00be: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00c3: ldarg.0 
				L_00c4: ldloc.1 
				L_00c5: ldloc.s V_4
				L_00c7: ldc.i4.2 
				L_00c8: add 
				L_00c9: ldloc.s V_5
				L_00cb: ldc.i4.2 
				L_00cc: add 
				L_00cd: ldloc.s V_4
				L_00cf: ldc.i4.2 
				L_00d0: add 
				L_00d1: ldloc.s V_7
				L_00d3: ldc.i4.3 
				L_00d4: sub 
				L_00d5: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00da: ldarg.0 
				L_00db: ldloc.3 
				L_00dc: ldloc.s V_6
				L_00de: ldc.i4.1 
				L_00df: sub 
				L_00e0: ldloc.s V_5
				L_00e2: ldc.i4.1 
				L_00e3: add 
				L_00e4: ldloc.s V_6
				L_00e6: ldc.i4.1 
				L_00e7: sub 
				L_00e8: ldloc.s V_7
				L_00ea: ldc.i4.1 
				L_00eb: sub 
				L_00ec: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00f1: ldarg.0 
				L_00f2: ldloc.2 
				L_00f3: ldloc.s V_6
				L_00f5: ldc.i4.2 
				L_00f6: sub 
				L_00f7: ldloc.s V_5
				L_00f9: ldc.i4.2 
				L_00fa: add 
				L_00fb: ldloc.s V_6
				L_00fd: ldc.i4.2 
				L_00fe: sub 
				L_00ff: ldloc.s V_7
				L_0101: ldc.i4.2 
				L_0102: sub 
				L_0103: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0108: ldarg.0 
				L_0109: ldloc.1 
				L_010a: ldloc.s V_6
				L_010c: ldc.i4.3 
				L_010d: sub 
				L_010e: ldloc.s V_5
				L_0110: ldc.i4.3 
				L_0111: add 
				L_0112: ldloc.s V_6
				L_0114: ldc.i4.3 
				L_0115: sub 
				L_0116: ldloc.s V_7
				L_0118: ldc.i4.3 
				L_0119: sub 
				L_011a: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_011f: ldarg.0 
				L_0120: ldloc.3 
				L_0121: ldloc.s V_6
				L_0123: ldc.i4.1 
				L_0124: sub 
				L_0125: ldloc.s V_7
				L_0127: ldc.i4.1 
				L_0128: sub 
				L_0129: ldloc.s V_4
				L_012b: ldloc.s V_7
				L_012d: ldc.i4.1 
				L_012e: sub 
				L_012f: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0134: ldarg.0 
				L_0135: ldloc.2 
				L_0136: ldloc.s V_6
				L_0138: ldc.i4.2 
				L_0139: sub 
				L_013a: ldloc.s V_7
				L_013c: ldc.i4.2 
				L_013d: sub 
				L_013e: ldloc.s V_4
				L_0140: ldc.i4.1 
				L_0141: add 
				L_0142: ldloc.s V_7
				L_0144: ldc.i4.2 
				L_0145: sub 
				L_0146: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_014b: ldarg.0 
				L_014c: ldloc.1 
				L_014d: ldloc.s V_6
				L_014f: ldc.i4.3 
				L_0150: sub 
				L_0151: ldloc.s V_7
				L_0153: ldc.i4.3 
				L_0154: sub 
				L_0155: ldloc.s V_4
				L_0157: ldc.i4.2 
				L_0158: add 
				L_0159: ldloc.s V_7
				L_015b: ldc.i4.3 
				L_015c: sub 
				L_015d: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0162: leave.s L_016e
				L_0164: ldloc.3 
				L_0165: brfalse.s L_016d
				L_0167: ldloc.3 
				L_0168: callvirt System.IDisposable::Void Dispose()
				L_016d: endfinally 
				L_016e: leave.s L_017a
				L_0170: ldloc.2 
				L_0171: brfalse.s L_0179
				L_0173: ldloc.2 
				L_0174: callvirt System.IDisposable::Void Dispose()
				L_0179: endfinally 
				L_017a: leave.s L_0186
				L_017c: ldloc.1 
				L_017d: brfalse.s L_0185
				L_017f: ldloc.1 
				L_0180: callvirt System.IDisposable::Void Dispose()
				L_0185: endfinally 
				L_0186: leave.s L_0192
				L_0188: ldloc.0 
				L_0189: brfalse.s L_0191
				L_018b: ldloc.0 
				L_018c: callvirt System.IDisposable::Void Dispose()
				L_0191: endfinally 
				L_0192: ret 
			*/
			
			
			{
				int i1;
				int i2;
				int i3;
				int i4;
				if ((x26545669838eb36e.Width > 2) && (x26545669838eb36e.Height > 2))
				{
					using (Pen pen1 = new Pen (xa7bf5f1d8010ffbc))
					{
						using (Pen pen2 = new Pen (x6f860ed2fc55db9e))
						{
							using (Pen pen3 = new Pen (x2a874aaea1ef79cd))
							{
								using (Pen pen4 = new Pen (x203ed3379fa39cc5))
								{
									i1 = x26545669838eb36e.Left;
									i2 = x26545669838eb36e.Top;
									i3 = x26545669838eb36e.Right;
									i4 = x26545669838eb36e.Bottom;
									x4b101060f4767186.DrawLine (pen2, ((int) (i3 - 1)), i2, i1, i2);
									x4b101060f4767186.DrawLine (pen1, ((int) (i3 - 2)), ((int) (i2 + 1)), ((int) (i1 + 1)), ((int) (i2 + 1)));
									x4b101060f4767186.DrawLine (pen2, ((int) (i3 - 3)), ((int) (i2 + 2)), ((int) (i1 + 2)), ((int) (i2 + 2)));
									x4b101060f4767186.DrawLine (pen2, i1, i2, i1, ((int) (i4 - 1)));
									x4b101060f4767186.DrawLine (pen1, ((int) (i1 + 1)), ((int) (i2 + 1)), ((int) (i1 + 1)), ((int) (i4 - 2)));
									x4b101060f4767186.DrawLine (pen2, ((int) (i1 + 2)), ((int) (i2 + 2)), ((int) (i1 + 2)), ((int) (i4 - 3)));
									x4b101060f4767186.DrawLine (pen4, ((int) (i3 - 1)), ((int) (i2 + 1)), ((int) (i3 - 1)), ((int) (i4 - 1)));
									x4b101060f4767186.DrawLine (pen3, ((int) (i3 - 2)), ((int) (i2 + 2)), ((int) (i3 - 2)), ((int) (i4 - 2)));
									x4b101060f4767186.DrawLine (pen2, ((int) (i3 - 3)), ((int) (i2 + 3)), ((int) (i3 - 3)), ((int) (i4 - 3)));
									x4b101060f4767186.DrawLine (pen4, ((int) (i3 - 1)), ((int) (i4 - 1)), i1, ((int) (i4 - 1)));
									x4b101060f4767186.DrawLine (pen3, ((int) (i3 - 2)), ((int) (i4 - 2)), ((int) (i1 + 1)), ((int) (i4 - 2)));
									x4b101060f4767186.DrawLine (pen2, ((int) (i3 - 3)), ((int) (i4 - 3)), ((int) (i1 + 2)), ((int) (i4 - 3)));
								}
							}
						}
					}
				}
			}
			
			public static void x5db90b01347ffd02 (Graphics x4b101060f4767186, Rectangle x26545669838eb36e, Color xa7bf5f1d8010ffbc, Color x6f860ed2fc55db9e, Color x2a874aaea1ef79cd, Color x203ed3379fa39cc5, bool x536732fdaf78aef7)
			
			/*
				// Code Size: 269 Bytes
				.maxstack 8
				.locals (System.Drawing.Pen V_0, 
         System.Drawing.Pen V_1, 
         System.Drawing.Pen V_2, 
         System.Drawing.Pen V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Int32 V_7)
				.try L_0038 to L_00de finally L_00de to L_00e8
				.try L_0030 to L_00ea finally L_00ea to L_00f4
				.try L_0028 to L_00f6 finally L_00f6 to L_0100
				.try L_0021 to L_0102 finally L_0102 to L_010c
				L_0000: ldarga.s x26545669838eb36e
				L_0002: call System.Drawing.Rectangle::Int32 get_Width()
				L_0007: ldc.i4.2 
				L_0008: ble L_010c
				L_000d: ldarga.s x26545669838eb36e
				L_000f: call System.Drawing.Rectangle::Int32 get_Height()
				L_0014: ldc.i4.2 
				L_0015: ble L_010c
				L_001a: ldarg.2 
				L_001b: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0020: stloc.0 
				L_0021: ldarg.3 
				L_0022: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0027: stloc.1 
				L_0028: ldarg.s x2a874aaea1ef79cd
				L_002a: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_002f: stloc.2 
				L_0030: ldarg.s x203ed3379fa39cc5
				L_0032: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0037: stloc.3 
				L_0038: ldarga.s x26545669838eb36e
				L_003a: call System.Drawing.Rectangle::Int32 get_Left()
				L_003f: stloc.s V_4
				L_0041: ldarga.s x26545669838eb36e
				L_0043: call System.Drawing.Rectangle::Int32 get_Top()
				L_0048: stloc.s V_5
				L_004a: ldarga.s x26545669838eb36e
				L_004c: call System.Drawing.Rectangle::Int32 get_Right()
				L_0051: stloc.s V_6
				L_0053: ldarga.s x26545669838eb36e
				L_0055: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_005a: stloc.s V_7
				L_005c: ldarg.s x536732fdaf78aef7
				L_005e: brfalse.s L_009d
				L_0060: ldarg.0 
				L_0061: ldloc.2 
				L_0062: ldloc.s V_6
				L_0064: ldc.i4.1 
				L_0065: sub 
				L_0066: ldloc.s V_5
				L_0068: ldloc.s V_4
				L_006a: ldloc.s V_5
				L_006c: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0071: ldarg.0 
				L_0072: ldloc.3 
				L_0073: ldloc.s V_6
				L_0075: ldc.i4.1 
				L_0076: sub 
				L_0077: ldloc.s V_5
				L_0079: ldc.i4.1 
				L_007a: add 
				L_007b: ldloc.s V_4
				L_007d: ldloc.s V_5
				L_007f: ldc.i4.1 
				L_0080: add 
				L_0081: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0086: ldarg.0 
				L_0087: ldloc.1 
				L_0088: ldloc.s V_6
				L_008a: ldc.i4.1 
				L_008b: sub 
				L_008c: ldloc.s V_5
				L_008e: ldc.i4.2 
				L_008f: add 
				L_0090: ldloc.s V_4
				L_0092: ldloc.s V_5
				L_0094: ldc.i4.2 
				L_0095: add 
				L_0096: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_009b: br.s L_00dc
				L_009d: ldarg.0 
				L_009e: ldloc.0 
				L_009f: ldloc.s V_6
				L_00a1: ldc.i4.1 
				L_00a2: sub 
				L_00a3: ldloc.s V_7
				L_00a5: ldc.i4.1 
				L_00a6: sub 
				L_00a7: ldloc.s V_4
				L_00a9: ldloc.s V_7
				L_00ab: ldc.i4.1 
				L_00ac: sub 
				L_00ad: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00b2: ldarg.0 
				L_00b3: ldloc.1 
				L_00b4: ldloc.s V_6
				L_00b6: ldc.i4.1 
				L_00b7: sub 
				L_00b8: ldloc.s V_7
				L_00ba: ldc.i4.2 
				L_00bb: sub 
				L_00bc: ldloc.s V_4
				L_00be: ldloc.s V_7
				L_00c0: ldc.i4.2 
				L_00c1: sub 
				L_00c2: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00c7: ldarg.0 
				L_00c8: ldloc.1 
				L_00c9: ldloc.s V_6
				L_00cb: ldc.i4.1 
				L_00cc: sub 
				L_00cd: ldloc.s V_7
				L_00cf: ldc.i4.3 
				L_00d0: sub 
				L_00d1: ldloc.s V_4
				L_00d3: ldloc.s V_7
				L_00d5: ldc.i4.3 
				L_00d6: sub 
				L_00d7: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00dc: leave.s L_00e8
				L_00de: ldloc.3 
				L_00df: brfalse.s L_00e7
				L_00e1: ldloc.3 
				L_00e2: callvirt System.IDisposable::Void Dispose()
				L_00e7: endfinally 
				L_00e8: leave.s L_00f4
				L_00ea: ldloc.2 
				L_00eb: brfalse.s L_00f3
				L_00ed: ldloc.2 
				L_00ee: callvirt System.IDisposable::Void Dispose()
				L_00f3: endfinally 
				L_00f4: leave.s L_0100
				L_00f6: ldloc.1 
				L_00f7: brfalse.s L_00ff
				L_00f9: ldloc.1 
				L_00fa: callvirt System.IDisposable::Void Dispose()
				L_00ff: endfinally 
				L_0100: leave.s L_010c
				L_0102: ldloc.0 
				L_0103: brfalse.s L_010b
				L_0105: ldloc.0 
				L_0106: callvirt System.IDisposable::Void Dispose()
				L_010b: endfinally 
				L_010c: ret 
			*/
			
			
			{
				int i1;
				int i2;
				int i3;
				int i4;
				if ((x26545669838eb36e.Width > 2) && (x26545669838eb36e.Height > 2))
				{
					using (Pen pen1 = new Pen (xa7bf5f1d8010ffbc))
					{
						using (Pen pen2 = new Pen (x6f860ed2fc55db9e))
						{
							using (Pen pen3 = new Pen (x2a874aaea1ef79cd))
							{
								using (Pen pen4 = new Pen (x203ed3379fa39cc5))
								{
									i1 = x26545669838eb36e.Left;
									i2 = x26545669838eb36e.Top;
									i3 = x26545669838eb36e.Right;
									i4 = x26545669838eb36e.Bottom;
									if (x536732fdaf78aef7)
									{
										x4b101060f4767186.DrawLine (pen3, ((int) (i3 - 1)), i2, i1, i2);
										x4b101060f4767186.DrawLine (pen4, ((int) (i3 - 1)), ((int) (i2 + 1)), i1, ((int) (i2 + 1)));
										x4b101060f4767186.DrawLine (pen2, ((int) (i3 - 1)), ((int) (i2 + 2)), i1, ((int) (i2 + 2)));
									}
									else
									{
										x4b101060f4767186.DrawLine (pen1, ((int) (i3 - 1)), ((int) (i4 - 1)), i1, ((int) (i4 - 1)));
										x4b101060f4767186.DrawLine (pen2, ((int) (i3 - 1)), ((int) (i4 - 2)), i1, ((int) (i4 - 2)));
										x4b101060f4767186.DrawLine (pen2, ((int) (i3 - 1)), ((int) (i4 - 3)), i1, ((int) (i4 - 3)));
									}
								}
							}
						}
					}
				}
			}
			
			public static void x75fdcaf0a26d82ea (Graphics x4b101060f4767186, Rectangle x26545669838eb36e, Color xa7bf5f1d8010ffbc, Color x6f860ed2fc55db9e, Color x2a874aaea1ef79cd, Color x203ed3379fa39cc5, bool x536732fdaf78aef7)
			
			/*
				// Code Size: 269 Bytes
				.maxstack 8
				.locals (System.Drawing.Pen V_0, 
         System.Drawing.Pen V_1, 
         System.Drawing.Pen V_2, 
         System.Drawing.Pen V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Int32 V_7)
				.try L_0038 to L_00de finally L_00de to L_00e8
				.try L_0030 to L_00ea finally L_00ea to L_00f4
				.try L_0028 to L_00f6 finally L_00f6 to L_0100
				.try L_0021 to L_0102 finally L_0102 to L_010c
				L_0000: ldarga.s x26545669838eb36e
				L_0002: call System.Drawing.Rectangle::Int32 get_Width()
				L_0007: ldc.i4.2 
				L_0008: ble L_010c
				L_000d: ldarga.s x26545669838eb36e
				L_000f: call System.Drawing.Rectangle::Int32 get_Height()
				L_0014: ldc.i4.2 
				L_0015: ble L_010c
				L_001a: ldarg.2 
				L_001b: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0020: stloc.0 
				L_0021: ldarg.3 
				L_0022: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0027: stloc.1 
				L_0028: ldarg.s x2a874aaea1ef79cd
				L_002a: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_002f: stloc.2 
				L_0030: ldarg.s x203ed3379fa39cc5
				L_0032: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0037: stloc.3 
				L_0038: ldarga.s x26545669838eb36e
				L_003a: call System.Drawing.Rectangle::Int32 get_Left()
				L_003f: stloc.s V_4
				L_0041: ldarga.s x26545669838eb36e
				L_0043: call System.Drawing.Rectangle::Int32 get_Top()
				L_0048: stloc.s V_5
				L_004a: ldarga.s x26545669838eb36e
				L_004c: call System.Drawing.Rectangle::Int32 get_Right()
				L_0051: stloc.s V_6
				L_0053: ldarga.s x26545669838eb36e
				L_0055: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_005a: stloc.s V_7
				L_005c: ldarg.s x536732fdaf78aef7
				L_005e: brfalse.s L_009d
				L_0060: ldarg.0 
				L_0061: ldloc.1 
				L_0062: ldloc.s V_6
				L_0064: ldc.i4.1 
				L_0065: sub 
				L_0066: ldloc.s V_5
				L_0068: ldloc.s V_4
				L_006a: ldloc.s V_5
				L_006c: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0071: ldarg.0 
				L_0072: ldloc.0 
				L_0073: ldloc.s V_6
				L_0075: ldc.i4.1 
				L_0076: sub 
				L_0077: ldloc.s V_5
				L_0079: ldc.i4.1 
				L_007a: add 
				L_007b: ldloc.s V_4
				L_007d: ldloc.s V_5
				L_007f: ldc.i4.1 
				L_0080: add 
				L_0081: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0086: ldarg.0 
				L_0087: ldloc.1 
				L_0088: ldloc.s V_6
				L_008a: ldc.i4.1 
				L_008b: sub 
				L_008c: ldloc.s V_5
				L_008e: ldc.i4.2 
				L_008f: add 
				L_0090: ldloc.s V_4
				L_0092: ldloc.s V_5
				L_0094: ldc.i4.2 
				L_0095: add 
				L_0096: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_009b: br.s L_00dc
				L_009d: ldarg.0 
				L_009e: ldloc.3 
				L_009f: ldloc.s V_6
				L_00a1: ldc.i4.1 
				L_00a2: sub 
				L_00a3: ldloc.s V_7
				L_00a5: ldc.i4.1 
				L_00a6: sub 
				L_00a7: ldloc.s V_4
				L_00a9: ldloc.s V_7
				L_00ab: ldc.i4.1 
				L_00ac: sub 
				L_00ad: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00b2: ldarg.0 
				L_00b3: ldloc.2 
				L_00b4: ldloc.s V_6
				L_00b6: ldc.i4.1 
				L_00b7: sub 
				L_00b8: ldloc.s V_7
				L_00ba: ldc.i4.2 
				L_00bb: sub 
				L_00bc: ldloc.s V_4
				L_00be: ldloc.s V_7
				L_00c0: ldc.i4.2 
				L_00c1: sub 
				L_00c2: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00c7: ldarg.0 
				L_00c8: ldloc.1 
				L_00c9: ldloc.s V_6
				L_00cb: ldc.i4.1 
				L_00cc: sub 
				L_00cd: ldloc.s V_7
				L_00cf: ldc.i4.3 
				L_00d0: sub 
				L_00d1: ldloc.s V_4
				L_00d3: ldloc.s V_7
				L_00d5: ldc.i4.3 
				L_00d6: sub 
				L_00d7: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00dc: leave.s L_00e8
				L_00de: ldloc.3 
				L_00df: brfalse.s L_00e7
				L_00e1: ldloc.3 
				L_00e2: callvirt System.IDisposable::Void Dispose()
				L_00e7: endfinally 
				L_00e8: leave.s L_00f4
				L_00ea: ldloc.2 
				L_00eb: brfalse.s L_00f3
				L_00ed: ldloc.2 
				L_00ee: callvirt System.IDisposable::Void Dispose()
				L_00f3: endfinally 
				L_00f4: leave.s L_0100
				L_00f6: ldloc.1 
				L_00f7: brfalse.s L_00ff
				L_00f9: ldloc.1 
				L_00fa: callvirt System.IDisposable::Void Dispose()
				L_00ff: endfinally 
				L_0100: leave.s L_010c
				L_0102: ldloc.0 
				L_0103: brfalse.s L_010b
				L_0105: ldloc.0 
				L_0106: callvirt System.IDisposable::Void Dispose()
				L_010b: endfinally 
				L_010c: ret 
			*/
			
			
			{
				int i1;
				int i2;
				int i3;
				int i4;
				if ((x26545669838eb36e.Width > 2) && (x26545669838eb36e.Height > 2))
				{
					using (Pen pen1 = new Pen (xa7bf5f1d8010ffbc))
					{
						using (Pen pen2 = new Pen (x6f860ed2fc55db9e))
						{
							using (Pen pen3 = new Pen (x2a874aaea1ef79cd))
							{
								using (Pen pen4 = new Pen (x203ed3379fa39cc5))
								{
									i1 = x26545669838eb36e.Left;
									i2 = x26545669838eb36e.Top;
									i3 = x26545669838eb36e.Right;
									i4 = x26545669838eb36e.Bottom;
									if (x536732fdaf78aef7)
									{
										x4b101060f4767186.DrawLine (pen2, ((int) (i3 - 1)), i2, i1, i2);
										x4b101060f4767186.DrawLine (pen1, ((int) (i3 - 1)), ((int) (i2 + 1)), i1, ((int) (i2 + 1)));
										x4b101060f4767186.DrawLine (pen2, ((int) (i3 - 1)), ((int) (i2 + 2)), i1, ((int) (i2 + 2)));
									}
									else
									{
										x4b101060f4767186.DrawLine (pen4, ((int) (i3 - 1)), ((int) (i4 - 1)), i1, ((int) (i4 - 1)));
										x4b101060f4767186.DrawLine (pen3, ((int) (i3 - 1)), ((int) (i4 - 2)), i1, ((int) (i4 - 2)));
										x4b101060f4767186.DrawLine (pen2, ((int) (i3 - 1)), ((int) (i4 - 3)), i1, ((int) (i4 - 3)));
									}
								}
							}
						}
					}
				}
			}
			
			public static void x78fabc70e1eb6bd8 (Graphics x4b101060f4767186, string xa4b5d355cbf01a80, Font x7860e70995ecb6a4, Rectangle xf78cf2936de01d72, Brush x31c43b9780d2a960, StringFormat x3b54e1dc571f7d3e)
			
			/*
				// Code Size: 86 Bytes
				.maxstack 7
				.locals (System.Drawing.Drawing2D.GraphicsContainer V_0)
				L_0000: ldarg.0 
				L_0001: callvirt System.Drawing.Graphics::System.Drawing.Drawing2D.GraphicsContainer BeginContainer()
				L_0006: stloc.0 
				L_0007: ldarg.0 
				L_0008: ldarga.s xf78cf2936de01d72
				L_000a: call System.Drawing.Rectangle::Int32 get_Left()
				L_000f: ldc.i4.2 
				L_0010: mul 
				L_0011: ldarga.s xf78cf2936de01d72
				L_0013: call System.Drawing.Rectangle::Int32 get_Width()
				L_0018: add 
				L_0019: conv.r4 
				L_001a: ldarga.s xf78cf2936de01d72
				L_001c: call System.Drawing.Rectangle::Int32 get_Top()
				L_0021: ldc.i4.2 
				L_0022: mul 
				L_0023: ldarga.s xf78cf2936de01d72
				L_0025: call System.Drawing.Rectangle::Int32 get_Height()
				L_002a: add 
				L_002b: conv.r4 
				L_002c: callvirt System.Drawing.Graphics::Void TranslateTransform(Single, Single)
				L_0031: ldarg.0 
				L_0032: ldc.r4 180
				L_0037: callvirt System.Drawing.Graphics::Void RotateTransform(Single)
				L_003c: ldarg.0 
				L_003d: ldarg.1 
				L_003e: ldarg.2 
				L_003f: ldarg.s x31c43b9780d2a960
				L_0041: ldarg.3 
				L_0042: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_0047: ldarg.s x3b54e1dc571f7d3e
				L_0049: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_004e: ldarg.0 
				L_004f: ldloc.0 
				L_0050: callvirt System.Drawing.Graphics::Void EndContainer(System.Drawing.Drawing2D.GraphicsContainer)
				L_0055: ret 
			*/
			
			
			{
				GraphicsContainer graphicsContainer1 = x4b101060f4767186.BeginContainer ();
				x4b101060f4767186.TranslateTransform (((float) ((xf78cf2936de01d72.Left * 2) + xf78cf2936de01d72.Width)), ((float) ((xf78cf2936de01d72.Top * 2) + xf78cf2936de01d72.Height)));
				x4b101060f4767186.RotateTransform (180F);
				x4b101060f4767186.DrawString (xa4b5d355cbf01a80, x7860e70995ecb6a4, x31c43b9780d2a960, ((RectangleF) xf78cf2936de01d72), x3b54e1dc571f7d3e);
				x4b101060f4767186.EndContainer (graphicsContainer1);
			}
			
			public static void x79fd5e048d8f9428 (Rectangle[] x2b4fa5919e007321, int x94e516b5d3c734eb)
			
			/*
				// Code Size: 228 Bytes
				.maxstack 7
				.locals (System.IntPtr V_0, 
         System.Int32 V_1, 
         System.IntPtr V_2, 
         System.IntPtr V_3, 
         Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_4, 
         System.IntPtr V_5, 
         System.IntPtr V_6)
				L_0000: ldarg.0 
				L_0001: ldlen 
				L_0002: conv.i4 
				L_0003: ldc.i4.0 
				L_0004: ble L_00e3
				L_0009: ldarg.0 
				L_000a: ldc.i4.0 
				L_000b: ldelema System.Drawing.Rectangle
				L_0010: ldobj System.Drawing.Rectangle
				L_0015: ldarg.1 
				L_0016: call Sunisoft.IrisSkin.InternalControls.x957e371151765ec5::IntPtr xa941746b2e12e6c1(System.Drawing.Rectangle, Int32)
				L_001b: stloc.0 
				L_001c: ldc.i4.1 
				L_001d: stloc.1 
				L_001e: br.s L_0048
				L_0020: ldarg.0 
				L_0021: ldloc.1 
				L_0022: ldelema System.Drawing.Rectangle
				L_0027: ldobj System.Drawing.Rectangle
				L_002c: ldarg.1 
				L_002d: call Sunisoft.IrisSkin.InternalControls.x957e371151765ec5::IntPtr xa941746b2e12e6c1(System.Drawing.Rectangle, Int32)
				L_0032: stloc.2 
				L_0033: ldloc.0 
				L_0034: ldloc.0 
				L_0035: ldloc.2 
				L_0036: ldc.i4.3 
				L_0037: call Sunisoft.IrisSkin.x31775329b2a4ff52::Int32 CombineRgn(IntPtr, IntPtr, IntPtr, Int32)
				L_003c: pop 
				L_003d: ldloc.2 
				L_003e: call Sunisoft.IrisSkin.x31775329b2a4ff52::Boolean DeleteObject(IntPtr)
				L_0043: pop 
				L_0044: ldloc.1 
				L_0045: ldc.i4.1 
				L_0046: add 
				L_0047: stloc.1 
				L_0048: ldloc.1 
				L_0049: ldarg.0 
				L_004a: ldlen 
				L_004b: conv.i4 
				L_004c: blt.s L_0020
				L_004e: ldsfld System.IntPtr::IntPtr Zero
				L_0053: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetDC(IntPtr)
				L_0058: stloc.3 
				L_0059: ldloc.3 
				L_005a: ldloc.0 
				L_005b: call Sunisoft.IrisSkin.x31775329b2a4ff52::Int32 SelectClipRgn(IntPtr, IntPtr)
				L_0060: pop 
				L_0061: ldloca.s V_4
				L_0063: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
				L_0069: ldloc.3 
				L_006a: ldloca.s V_4
				L_006c: call Sunisoft.IrisSkin.x31775329b2a4ff52::Int32 GetClipBox(IntPtr, RECT ByRef)
				L_0071: pop 
				L_0072: call Sunisoft.IrisSkin.InternalControls.x957e371151765ec5::IntPtr xc51886532d6aac02()
				L_0077: stloc.s V_5
				L_0079: ldloc.3 
				L_007a: ldloc.s V_5
				L_007c: call Sunisoft.IrisSkin.x31775329b2a4ff52::IntPtr SelectObject(IntPtr, IntPtr)
				L_0081: stloc.s V_6
				L_0083: ldloc.3 
				L_0084: ldloca.s V_4
				L_0086: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_008b: ldloca.s V_4
				L_008d: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0092: ldloca.s V_4
				L_0094: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0099: ldloca.s V_4
				L_009b: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_00a0: sub 
				L_00a1: ldloca.s V_4
				L_00a3: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_00a8: ldloca.s V_4
				L_00aa: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_00af: sub 
				L_00b0: ldc.i4 5898313
				L_00b5: call Sunisoft.IrisSkin.x31775329b2a4ff52::Boolean PatBlt(IntPtr, Int32, Int32, Int32, Int32, UInt32)
				L_00ba: pop 
				L_00bb: ldloc.3 
				L_00bc: ldloc.s V_6
				L_00be: call Sunisoft.IrisSkin.x31775329b2a4ff52::IntPtr SelectObject(IntPtr, IntPtr)
				L_00c3: pop 
				L_00c4: ldloc.3 
				L_00c5: ldsfld System.IntPtr::IntPtr Zero
				L_00ca: call Sunisoft.IrisSkin.x31775329b2a4ff52::Int32 SelectClipRgn(IntPtr, IntPtr)
				L_00cf: pop 
				L_00d0: ldloc.0 
				L_00d1: call Sunisoft.IrisSkin.x31775329b2a4ff52::Boolean DeleteObject(IntPtr)
				L_00d6: pop 
				L_00d7: ldsfld System.IntPtr::IntPtr Zero
				L_00dc: ldloc.3 
				L_00dd: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_00e2: pop 
				L_00e3: ret 
			*/
			
			
			{
				int i1;
				IntPtr intPtr2;
				if (x2b4fa5919e007321.Length <= 0)
				{
					return;
				}
				IntPtr intPtr1 = x957e371151765ec5.xa941746b2e12e6c1 (x2b4fa5919e007321[0], x94e516b5d3c734eb);
				for (i1 = 1; (i1 < x2b4fa5919e007321.Length); i1++)
				{
					intPtr2 = x957e371151765ec5.xa941746b2e12e6c1 (x2b4fa5919e007321[i1], x94e516b5d3c734eb);
					int i2 = x31775329b2a4ff52.CombineRgn (intPtr1, intPtr1, intPtr2, 3);
					bool b1 = x31775329b2a4ff52.DeleteObject (intPtr2);
				}
				IntPtr intPtr3 = x61467fe65a98f20c.GetDC (IntPtr.Zero);
				int i3 = x31775329b2a4ff52.SelectClipRgn (intPtr3, intPtr1);
				xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
				int i4 = x31775329b2a4ff52.GetClipBox (intPtr3, ref rECT1);
				IntPtr intPtr4 = x957e371151765ec5.xc51886532d6aac02 ();
				IntPtr intPtr5 = x31775329b2a4ff52.SelectObject (intPtr3, intPtr4);
				bool b2 = x31775329b2a4ff52.PatBlt (intPtr3, rECT1.left, rECT1.top, ((int) (rECT1.right - rECT1.left)), ((int) (rECT1.bottom - rECT1.top)), 5898313);
				IntPtr intPtr6 = x31775329b2a4ff52.SelectObject (intPtr3, intPtr5);
				int i5 = x31775329b2a4ff52.SelectClipRgn (intPtr3, IntPtr.Zero);
				bool b3 = x31775329b2a4ff52.DeleteObject (intPtr1);
				int i6 = x61467fe65a98f20c.ReleaseDC (IntPtr.Zero, intPtr3);
			}
			
			public static void x8a7515bec9143425 (Graphics x4b101060f4767186, xdbfa333b4cd503e0 x23e85093ba3a7d1d, Rectangle xf78cf2936de01d72, Color x6f860ed2fc55db9e)
			
			/*
				// Code Size: 105 Bytes
				.maxstack 8
				.locals (System.Drawing.Pen V_0)
				.try L_000c to L_005e finally L_005e to L_0068
				L_0000: ldarg.3 
				L_0001: call System.Windows.Forms.ControlPaint::System.Drawing.Color Dark(System.Drawing.Color)
				L_0006: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_000b: stloc.0 
				L_000c: ldarg.1 
				L_000d: ldc.i4.1 
				L_000e: bne.un.s L_0037
				L_0010: ldarg.0 
				L_0011: ldloc.0 
				L_0012: ldarga.s xf78cf2936de01d72
				L_0014: call System.Drawing.Rectangle::Int32 get_Left()
				L_0019: ldarga.s xf78cf2936de01d72
				L_001b: call System.Drawing.Rectangle::Int32 get_Top()
				L_0020: ldarga.s xf78cf2936de01d72
				L_0022: call System.Drawing.Rectangle::Int32 get_Left()
				L_0027: ldarga.s xf78cf2936de01d72
				L_0029: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_002e: ldc.i4.1 
				L_002f: sub 
				L_0030: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0035: br.s L_005c
				L_0037: ldarg.0 
				L_0038: ldloc.0 
				L_0039: ldarga.s xf78cf2936de01d72
				L_003b: call System.Drawing.Rectangle::Int32 get_Left()
				L_0040: ldarga.s xf78cf2936de01d72
				L_0042: call System.Drawing.Rectangle::Int32 get_Top()
				L_0047: ldarga.s xf78cf2936de01d72
				L_0049: call System.Drawing.Rectangle::Int32 get_Right()
				L_004e: ldc.i4.1 
				L_004f: sub 
				L_0050: ldarga.s xf78cf2936de01d72
				L_0052: call System.Drawing.Rectangle::Int32 get_Top()
				L_0057: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_005c: leave.s L_0068
				L_005e: ldloc.0 
				L_005f: brfalse.s L_0067
				L_0061: ldloc.0 
				L_0062: callvirt System.IDisposable::Void Dispose()
				L_0067: endfinally 
				L_0068: ret 
			*/
			
			
			{
				using (Pen pen1 = new Pen (ControlPaint.Dark (x6f860ed2fc55db9e)))
				{
					if (x23e85093ba3a7d1d == xdbfa333b4cd503e0.x3bce7c87328df8da)
					{
						x4b101060f4767186.DrawLine (pen1, xf78cf2936de01d72.Left, xf78cf2936de01d72.Top, xf78cf2936de01d72.Left, ((int) (xf78cf2936de01d72.Bottom - 1)));
					}
					else
					{
						x4b101060f4767186.DrawLine (pen1, xf78cf2936de01d72.Left, xf78cf2936de01d72.Top, ((int) (xf78cf2936de01d72.Right - 1)), xf78cf2936de01d72.Top);
					}
				}
			}
			
			protected static IntPtr xa941746b2e12e6c1 (Rectangle x26545669838eb36e, int x94e516b5d3c734eb)
			
			/*
				// Code Size: 243 Bytes
				.maxstack 5
				.locals (Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_0, 
         System.IntPtr V_1, 
         System.IntPtr V_2, 
         Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_3, 
         System.IntPtr V_4)
				L_0000: ldloca.s V_0
				L_0002: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
				L_0008: ldloca.s V_0
				L_000a: ldarga.s x26545669838eb36e
				L_000c: call System.Drawing.Rectangle::Int32 get_Left()
				L_0011: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0016: ldloca.s V_0
				L_0018: ldarga.s x26545669838eb36e
				L_001a: call System.Drawing.Rectangle::Int32 get_Top()
				L_001f: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0024: ldloca.s V_0
				L_0026: ldarga.s x26545669838eb36e
				L_0028: call System.Drawing.Rectangle::Int32 get_Right()
				L_002d: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0032: ldloca.s V_0
				L_0034: ldarga.s x26545669838eb36e
				L_0036: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_003b: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0040: ldloca.s V_0
				L_0042: call Sunisoft.IrisSkin.x31775329b2a4ff52::IntPtr CreateRectRgnIndirect(RECT ByRef)
				L_0047: stloc.1 
				L_0048: ldarg.1 
				L_0049: ldc.i4.0 
				L_004a: ble.s L_0060
				L_004c: ldarga.s x26545669838eb36e
				L_004e: call System.Drawing.Rectangle::Int32 get_Width()
				L_0053: ldarg.1 
				L_0054: ble.s L_0060
				L_0056: ldarga.s x26545669838eb36e
				L_0058: call System.Drawing.Rectangle::Int32 get_Height()
				L_005d: ldarg.1 
				L_005e: bgt.s L_0062
				L_0060: ldloc.1 
				L_0061: ret 
				L_0062: ldloca.s V_0
				L_0064: dup 
				L_0065: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_006a: ldarg.1 
				L_006b: add 
				L_006c: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0071: ldloca.s V_0
				L_0073: dup 
				L_0074: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0079: ldarg.1 
				L_007a: add 
				L_007b: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0080: ldloca.s V_0
				L_0082: dup 
				L_0083: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0088: ldarg.1 
				L_0089: sub 
				L_008a: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_008f: ldloca.s V_0
				L_0091: dup 
				L_0092: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0097: ldarg.1 
				L_0098: sub 
				L_0099: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_009e: ldloca.s V_0
				L_00a0: call Sunisoft.IrisSkin.x31775329b2a4ff52::IntPtr CreateRectRgnIndirect(RECT ByRef)
				L_00a5: stloc.2 
				L_00a6: ldloca.s V_3
				L_00a8: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
				L_00ae: ldloca.s V_3
				L_00b0: ldc.i4.0 
				L_00b1: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_00b6: ldloca.s V_3
				L_00b8: ldc.i4.0 
				L_00b9: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_00be: ldloca.s V_3
				L_00c0: ldc.i4.0 
				L_00c1: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_00c6: ldloca.s V_3
				L_00c8: ldc.i4.0 
				L_00c9: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_00ce: ldloca.s V_3
				L_00d0: call Sunisoft.IrisSkin.x31775329b2a4ff52::IntPtr CreateRectRgnIndirect(RECT ByRef)
				L_00d5: stloc.s V_4
				L_00d7: ldloc.s V_4
				L_00d9: ldloc.1 
				L_00da: ldloc.2 
				L_00db: ldc.i4.3 
				L_00dc: call Sunisoft.IrisSkin.x31775329b2a4ff52::Int32 CombineRgn(IntPtr, IntPtr, IntPtr, Int32)
				L_00e1: pop 
				L_00e2: ldloc.1 
				L_00e3: call Sunisoft.IrisSkin.x31775329b2a4ff52::Boolean DeleteObject(IntPtr)
				L_00e8: pop 
				L_00e9: ldloc.2 
				L_00ea: call Sunisoft.IrisSkin.x31775329b2a4ff52::Boolean DeleteObject(IntPtr)
				L_00ef: pop 
				L_00f0: ldloc.s V_4
				L_00f2: ret 
			*/
			
			
			{
				xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
				rECT1.left = x26545669838eb36e.Left;
				rECT1.top = x26545669838eb36e.Top;
				rECT1.right = x26545669838eb36e.Right;
				rECT1.bottom = x26545669838eb36e.Bottom;
				IntPtr intPtr1 = x31775329b2a4ff52.CreateRectRgnIndirect (ref rECT1);
				if (x94e516b5d3c734eb <= 0)
				{
					return intPtr1;
				}
				if (x26545669838eb36e.Width <= x94e516b5d3c734eb)
				{
					return intPtr1;
				}
				if (x26545669838eb36e.Height <= x94e516b5d3c734eb)
				{
					return intPtr1;
				}
				rECT1.left += x94e516b5d3c734eb;
				rECT1.top += x94e516b5d3c734eb;
				rECT1.right -= x94e516b5d3c734eb;
				rECT1.bottom -= x94e516b5d3c734eb;
				IntPtr intPtr2 = x31775329b2a4ff52.CreateRectRgnIndirect (ref rECT1);
				xae4dd1cafd2eb77c.RECT rECT2 = new xae4dd1cafd2eb77c.RECT ();
				rECT2.left = 0;
				rECT2.top = 0;
				rECT2.right = 0;
				rECT2.bottom = 0;
				IntPtr intPtr3 = x31775329b2a4ff52.CreateRectRgnIndirect (ref rECT2);
				int i1 = x31775329b2a4ff52.CombineRgn (intPtr3, intPtr1, intPtr2, 3);
				bool b1 = x31775329b2a4ff52.DeleteObject (intPtr1);
				bool b2 = x31775329b2a4ff52.DeleteObject (intPtr2);
				return intPtr3;
			}
			
			public static void xb13de6936feafb2d (Graphics x4b101060f4767186, Rectangle xd731596a5255980e, Color x6f860ed2fc55db9e)
			
			/*
				// Code Size: 189 Bytes
				.maxstack 8
				.locals (System.Drawing.Pen V_0, 
         System.Drawing.Pen V_1)
				.try L_0018 to L_00a6 finally L_00a6 to L_00b0
				.try L_000c to L_00b2 finally L_00b2 to L_00bc
				L_0000: ldarg.2 
				L_0001: call System.Windows.Forms.ControlPaint::System.Drawing.Color LightLight(System.Drawing.Color)
				L_0006: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_000b: stloc.0 
				L_000c: ldarg.2 
				L_000d: call System.Windows.Forms.ControlPaint::System.Drawing.Color DarkDark(System.Drawing.Color)
				L_0012: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0017: stloc.1 
				L_0018: ldarg.0 
				L_0019: ldloc.0 
				L_001a: ldarga.s xd731596a5255980e
				L_001c: call System.Drawing.Rectangle::Int32 get_Left()
				L_0021: ldarga.s xd731596a5255980e
				L_0023: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0028: ldarga.s xd731596a5255980e
				L_002a: call System.Drawing.Rectangle::Int32 get_Left()
				L_002f: ldarga.s xd731596a5255980e
				L_0031: call System.Drawing.Rectangle::Int32 get_Top()
				L_0036: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_003b: ldarg.0 
				L_003c: ldloc.0 
				L_003d: ldarga.s xd731596a5255980e
				L_003f: call System.Drawing.Rectangle::Int32 get_Left()
				L_0044: ldarga.s xd731596a5255980e
				L_0046: call System.Drawing.Rectangle::Int32 get_Top()
				L_004b: ldarga.s xd731596a5255980e
				L_004d: call System.Drawing.Rectangle::Int32 get_Right()
				L_0052: ldarga.s xd731596a5255980e
				L_0054: call System.Drawing.Rectangle::Int32 get_Top()
				L_0059: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_005e: ldarg.0 
				L_005f: ldloc.1 
				L_0060: ldarga.s xd731596a5255980e
				L_0062: call System.Drawing.Rectangle::Int32 get_Right()
				L_0067: ldarga.s xd731596a5255980e
				L_0069: call System.Drawing.Rectangle::Int32 get_Top()
				L_006e: ldarga.s xd731596a5255980e
				L_0070: call System.Drawing.Rectangle::Int32 get_Right()
				L_0075: ldarga.s xd731596a5255980e
				L_0077: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_007c: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0081: ldarg.0 
				L_0082: ldloc.1 
				L_0083: ldarga.s xd731596a5255980e
				L_0085: call System.Drawing.Rectangle::Int32 get_Right()
				L_008a: ldarga.s xd731596a5255980e
				L_008c: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0091: ldarga.s xd731596a5255980e
				L_0093: call System.Drawing.Rectangle::Int32 get_Left()
				L_0098: ldarga.s xd731596a5255980e
				L_009a: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_009f: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00a4: leave.s L_00b0
				L_00a6: ldloc.1 
				L_00a7: brfalse.s L_00af
				L_00a9: ldloc.1 
				L_00aa: callvirt System.IDisposable::Void Dispose()
				L_00af: endfinally 
				L_00b0: leave.s L_00bc
				L_00b2: ldloc.0 
				L_00b3: brfalse.s L_00bb
				L_00b5: ldloc.0 
				L_00b6: callvirt System.IDisposable::Void Dispose()
				L_00bb: endfinally 
				L_00bc: ret 
			*/
			
			
			{
				using (Pen pen1 = new Pen (ControlPaint.LightLight (x6f860ed2fc55db9e)))
				{
					using (Pen pen2 = new Pen (ControlPaint.DarkDark (x6f860ed2fc55db9e)))
					{
						x4b101060f4767186.DrawLine (pen1, xd731596a5255980e.Left, xd731596a5255980e.Bottom, xd731596a5255980e.Left, xd731596a5255980e.Top);
						x4b101060f4767186.DrawLine (pen1, xd731596a5255980e.Left, xd731596a5255980e.Top, xd731596a5255980e.Right, xd731596a5255980e.Top);
						x4b101060f4767186.DrawLine (pen2, xd731596a5255980e.Right, xd731596a5255980e.Top, xd731596a5255980e.Right, xd731596a5255980e.Bottom);
						x4b101060f4767186.DrawLine (pen2, xd731596a5255980e.Right, xd731596a5255980e.Bottom, xd731596a5255980e.Left, xd731596a5255980e.Bottom);
					}
				}
			}
			
			protected static IntPtr xc51886532d6aac02 ()
			
			/*
				// Code Size: 190 Bytes
				.maxstack 6
				.locals (System.Drawing.Bitmap V_0, 
         System.Drawing.Color V_1, 
         System.Drawing.Color V_2, 
         System.Boolean V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.IntPtr V_6, 
         Sunisoft.IrisSkin.x1439a41cfa24189f+LOGBRUSH V_7)
				L_0000: ldsfld Sunisoft.IrisSkin.InternalControls.x957e371151765ec5::IntPtr xd31bf1dadb599901
				L_0005: ldsfld System.IntPtr::IntPtr Zero
				L_000a: call System.IntPtr::Boolean op_Equality(IntPtr, IntPtr)
				L_000f: brfalse L_00b8
				L_0014: ldc.i4.8 
				L_0015: ldc.i4.8 
				L_0016: ldc.i4 2498570
				L_001b: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32, System.Drawing.Imaging.PixelFormat)
				L_0020: stloc.0 
				L_0021: ldc.i4 255
				L_0026: ldc.i4 255
				L_002b: ldc.i4 255
				L_0030: ldc.i4 255
				L_0035: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_003a: stloc.1 
				L_003b: ldc.i4 255
				L_0040: ldc.i4.0 
				L_0041: ldc.i4.0 
				L_0042: ldc.i4.0 
				L_0043: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_0048: stloc.2 
				L_0049: ldc.i4.1 
				L_004a: stloc.3 
				L_004b: ldc.i4.0 
				L_004c: stloc.s V_4
				L_004e: br.s L_0081
				L_0050: ldc.i4.0 
				L_0051: stloc.s V_5
				L_0053: br.s L_0071
				L_0055: ldloc.0 
				L_0056: ldloc.s V_4
				L_0058: ldloc.s V_5
				L_005a: ldloc.3 
				L_005b: brtrue.s L_0060
				L_005d: ldloc.2 
				L_005e: br.s L_0061
				L_0060: ldloc.1 
				L_0061: callvirt System.Drawing.Bitmap::Void SetPixel(Int32, Int32, System.Drawing.Color)
				L_0066: ldloc.s V_5
				L_0068: ldc.i4.1 
				L_0069: add 
				L_006a: stloc.s V_5
				L_006c: ldloc.3 
				L_006d: ldc.i4.0 
				L_006e: ceq 
				L_0070: stloc.3 
				L_0071: ldloc.s V_5
				L_0073: ldc.i4.8 
				L_0074: blt.s L_0055
				L_0076: ldloc.s V_4
				L_0078: ldc.i4.1 
				L_0079: add 
				L_007a: stloc.s V_4
				L_007c: ldloc.3 
				L_007d: ldc.i4.0 
				L_007e: ceq 
				L_0080: stloc.3 
				L_0081: ldloc.s V_4
				L_0083: ldc.i4.8 
				L_0084: blt.s L_0050
				L_0086: ldloc.0 
				L_0087: callvirt System.Drawing.Bitmap::IntPtr GetHbitmap()
				L_008c: stloc.s V_6
				L_008e: ldloca.s V_7
				L_0090: initobj Sunisoft.IrisSkin.x1439a41cfa24189f+LOGBRUSH
				L_0096: ldloca.s V_7
				L_0098: ldc.i4.3 
				L_0099: stfld Sunisoft.IrisSkin.x1439a41cfa24189f+LOGBRUSH::UInt32 lbStyle
				L_009e: ldloca.s V_7
				L_00a0: ldloc.s V_6
				L_00a2: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_00a7: stfld Sunisoft.IrisSkin.x1439a41cfa24189f+LOGBRUSH::UInt32 lbHatch
				L_00ac: ldloca.s V_7
				L_00ae: call Sunisoft.IrisSkin.x31775329b2a4ff52::IntPtr CreateBrushIndirect(LOGBRUSH ByRef)
				L_00b3: stsfld Sunisoft.IrisSkin.InternalControls.x957e371151765ec5::IntPtr xd31bf1dadb599901
				L_00b8: ldsfld Sunisoft.IrisSkin.InternalControls.x957e371151765ec5::IntPtr xd31bf1dadb599901
				L_00bd: ret 
			*/
			
			
			{
				int i2;
				if (x957e371151765ec5.xd31bf1dadb599901 != IntPtr.Zero)
				{
					return x957e371151765ec5.xd31bf1dadb599901;
				}
				Bitmap bitmap1 = new Bitmap (8, 8, PixelFormat.Format32bppArgb);
				Color color1 = Color.FromArgb (255, 255, 255, 255);
				Color color2 = Color.FromArgb (255, 0, 0, 0);
				bool b1 = true;
				int i1 = 0;
				while (i1 < 8)
				{
					i2 = 0;
					while (i2 < 8)
					{
						bitmap1.SetPixel (i1, i2, (b1 ? color1 : color2));
						i2++;
						b1 = (! b1);
					}
					i1++;
					b1 = (! b1);
				}
				IntPtr intPtr1 = bitmap1.GetHbitmap ();
				x1439a41cfa24189f.LOGBRUSH lOGBRUSH1 = new x1439a41cfa24189f.LOGBRUSH ();
				lOGBRUSH1.lbStyle = 3;
				lOGBRUSH1.lbHatch = ((uint) ((int) intPtr1));
				x957e371151765ec5.xd31bf1dadb599901 = x31775329b2a4ff52.CreateBrushIndirect (ref lOGBRUSH1);
				return x957e371151765ec5.xd31bf1dadb599901;
			}
			
			public static void xccf782e2fd562a4e (Rectangle xa58d85c0621406fb, int x94e516b5d3c734eb)
			
			/*
				// Code Size: 28 Bytes
				.maxstack 3
				.locals (System.Drawing.Rectangle[] V_0)
				L_0000: ldc.i4.1 
				L_0001: newarr System.Drawing.Rectangle
				L_0006: stloc.0 
				L_0007: ldloc.0 
				L_0008: ldc.i4.0 
				L_0009: ldelema System.Drawing.Rectangle
				L_000e: ldarg.0 
				L_000f: stobj System.Drawing.Rectangle
				L_0014: ldloc.0 
				L_0015: ldarg.1 
				L_0016: call Sunisoft.IrisSkin.InternalControls.x957e371151765ec5::Void x79fd5e048d8f9428(System.Drawing.Rectangle[], Int32)
				L_001b: ret 
			*/
			
			
			{
				Rectangle[] rectangleArray1 = new Rectangle[] { xa58d85c0621406fb };
				x957e371151765ec5.x79fd5e048d8f9428 (rectangleArray1, x94e516b5d3c734eb);
			}
			
			public static void xe071fbccd71b214e (Graphics x4b101060f4767186, Rectangle xd731596a5255980e, Color x6f860ed2fc55db9e)
			
			/*
				// Code Size: 189 Bytes
				.maxstack 8
				.locals (System.Drawing.Pen V_0, 
         System.Drawing.Pen V_1)
				.try L_0018 to L_00a6 finally L_00a6 to L_00b0
				.try L_000c to L_00b2 finally L_00b2 to L_00bc
				L_0000: ldarg.2 
				L_0001: call System.Windows.Forms.ControlPaint::System.Drawing.Color LightLight(System.Drawing.Color)
				L_0006: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_000b: stloc.0 
				L_000c: ldarg.2 
				L_000d: call System.Windows.Forms.ControlPaint::System.Drawing.Color DarkDark(System.Drawing.Color)
				L_0012: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0017: stloc.1 
				L_0018: ldarg.0 
				L_0019: ldloc.1 
				L_001a: ldarga.s xd731596a5255980e
				L_001c: call System.Drawing.Rectangle::Int32 get_Left()
				L_0021: ldarga.s xd731596a5255980e
				L_0023: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0028: ldarga.s xd731596a5255980e
				L_002a: call System.Drawing.Rectangle::Int32 get_Left()
				L_002f: ldarga.s xd731596a5255980e
				L_0031: call System.Drawing.Rectangle::Int32 get_Top()
				L_0036: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_003b: ldarg.0 
				L_003c: ldloc.1 
				L_003d: ldarga.s xd731596a5255980e
				L_003f: call System.Drawing.Rectangle::Int32 get_Left()
				L_0044: ldarga.s xd731596a5255980e
				L_0046: call System.Drawing.Rectangle::Int32 get_Top()
				L_004b: ldarga.s xd731596a5255980e
				L_004d: call System.Drawing.Rectangle::Int32 get_Right()
				L_0052: ldarga.s xd731596a5255980e
				L_0054: call System.Drawing.Rectangle::Int32 get_Top()
				L_0059: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_005e: ldarg.0 
				L_005f: ldloc.0 
				L_0060: ldarga.s xd731596a5255980e
				L_0062: call System.Drawing.Rectangle::Int32 get_Right()
				L_0067: ldarga.s xd731596a5255980e
				L_0069: call System.Drawing.Rectangle::Int32 get_Top()
				L_006e: ldarga.s xd731596a5255980e
				L_0070: call System.Drawing.Rectangle::Int32 get_Right()
				L_0075: ldarga.s xd731596a5255980e
				L_0077: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_007c: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0081: ldarg.0 
				L_0082: ldloc.0 
				L_0083: ldarga.s xd731596a5255980e
				L_0085: call System.Drawing.Rectangle::Int32 get_Right()
				L_008a: ldarga.s xd731596a5255980e
				L_008c: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0091: ldarga.s xd731596a5255980e
				L_0093: call System.Drawing.Rectangle::Int32 get_Left()
				L_0098: ldarga.s xd731596a5255980e
				L_009a: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_009f: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00a4: leave.s L_00b0
				L_00a6: ldloc.1 
				L_00a7: brfalse.s L_00af
				L_00a9: ldloc.1 
				L_00aa: callvirt System.IDisposable::Void Dispose()
				L_00af: endfinally 
				L_00b0: leave.s L_00bc
				L_00b2: ldloc.0 
				L_00b3: brfalse.s L_00bb
				L_00b5: ldloc.0 
				L_00b6: callvirt System.IDisposable::Void Dispose()
				L_00bb: endfinally 
				L_00bc: ret 
			*/
			
			
			{
				using (Pen pen1 = new Pen (ControlPaint.LightLight (x6f860ed2fc55db9e)))
				{
					using (Pen pen2 = new Pen (ControlPaint.DarkDark (x6f860ed2fc55db9e)))
					{
						x4b101060f4767186.DrawLine (pen2, xd731596a5255980e.Left, xd731596a5255980e.Bottom, xd731596a5255980e.Left, xd731596a5255980e.Top);
						x4b101060f4767186.DrawLine (pen2, xd731596a5255980e.Left, xd731596a5255980e.Top, xd731596a5255980e.Right, xd731596a5255980e.Top);
						x4b101060f4767186.DrawLine (pen1, xd731596a5255980e.Right, xd731596a5255980e.Top, xd731596a5255980e.Right, xd731596a5255980e.Bottom);
						x4b101060f4767186.DrawLine (pen1, xd731596a5255980e.Right, xd731596a5255980e.Bottom, xd731596a5255980e.Left, xd731596a5255980e.Bottom);
					}
				}
			}
			
			public static void xfaf9f2f63453efb7 (Graphics x4b101060f4767186, Rectangle x26545669838eb36e, Color xa7bf5f1d8010ffbc, Color x6f860ed2fc55db9e, Color x2a874aaea1ef79cd, Color x203ed3379fa39cc5)
			
			/*
				// Code Size: 403 Bytes
				.maxstack 8
				.locals (System.Drawing.Pen V_0, 
         System.Drawing.Pen V_1, 
         System.Drawing.Pen V_2, 
         System.Drawing.Pen V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Int32 V_7)
				.try L_0038 to L_0164 finally L_0164 to L_016e
				.try L_0030 to L_0170 finally L_0170 to L_017a
				.try L_0028 to L_017c finally L_017c to L_0186
				.try L_0021 to L_0188 finally L_0188 to L_0192
				L_0000: ldarga.s x26545669838eb36e
				L_0002: call System.Drawing.Rectangle::Int32 get_Width()
				L_0007: ldc.i4.2 
				L_0008: ble L_0192
				L_000d: ldarga.s x26545669838eb36e
				L_000f: call System.Drawing.Rectangle::Int32 get_Height()
				L_0014: ldc.i4.2 
				L_0015: ble L_0192
				L_001a: ldarg.2 
				L_001b: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0020: stloc.0 
				L_0021: ldarg.3 
				L_0022: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0027: stloc.1 
				L_0028: ldarg.s x2a874aaea1ef79cd
				L_002a: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_002f: stloc.2 
				L_0030: ldarg.s x203ed3379fa39cc5
				L_0032: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0037: stloc.3 
				L_0038: ldarga.s x26545669838eb36e
				L_003a: call System.Drawing.Rectangle::Int32 get_Left()
				L_003f: stloc.s V_4
				L_0041: ldarga.s x26545669838eb36e
				L_0043: call System.Drawing.Rectangle::Int32 get_Top()
				L_0048: stloc.s V_5
				L_004a: ldarga.s x26545669838eb36e
				L_004c: call System.Drawing.Rectangle::Int32 get_Right()
				L_0051: stloc.s V_6
				L_0053: ldarga.s x26545669838eb36e
				L_0055: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_005a: stloc.s V_7
				L_005c: ldarg.0 
				L_005d: ldloc.2 
				L_005e: ldloc.s V_6
				L_0060: ldc.i4.1 
				L_0061: sub 
				L_0062: ldloc.s V_5
				L_0064: ldloc.s V_4
				L_0066: ldloc.s V_5
				L_0068: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_006d: ldarg.0 
				L_006e: ldloc.3 
				L_006f: ldloc.s V_6
				L_0071: ldc.i4.2 
				L_0072: sub 
				L_0073: ldloc.s V_5
				L_0075: ldc.i4.1 
				L_0076: add 
				L_0077: ldloc.s V_4
				L_0079: ldc.i4.1 
				L_007a: add 
				L_007b: ldloc.s V_5
				L_007d: ldc.i4.1 
				L_007e: add 
				L_007f: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0084: ldarg.0 
				L_0085: ldloc.1 
				L_0086: ldloc.s V_6
				L_0088: ldc.i4.3 
				L_0089: sub 
				L_008a: ldloc.s V_5
				L_008c: ldc.i4.2 
				L_008d: add 
				L_008e: ldloc.s V_4
				L_0090: ldc.i4.2 
				L_0091: add 
				L_0092: ldloc.s V_5
				L_0094: ldc.i4.2 
				L_0095: add 
				L_0096: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_009b: ldarg.0 
				L_009c: ldloc.2 
				L_009d: ldloc.s V_4
				L_009f: ldloc.s V_5
				L_00a1: ldloc.s V_4
				L_00a3: ldloc.s V_7
				L_00a5: ldc.i4.1 
				L_00a6: sub 
				L_00a7: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00ac: ldarg.0 
				L_00ad: ldloc.3 
				L_00ae: ldloc.s V_4
				L_00b0: ldc.i4.1 
				L_00b1: add 
				L_00b2: ldloc.s V_5
				L_00b4: ldc.i4.1 
				L_00b5: add 
				L_00b6: ldloc.s V_4
				L_00b8: ldc.i4.1 
				L_00b9: add 
				L_00ba: ldloc.s V_7
				L_00bc: ldc.i4.2 
				L_00bd: sub 
				L_00be: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00c3: ldarg.0 
				L_00c4: ldloc.1 
				L_00c5: ldloc.s V_4
				L_00c7: ldc.i4.2 
				L_00c8: add 
				L_00c9: ldloc.s V_5
				L_00cb: ldc.i4.2 
				L_00cc: add 
				L_00cd: ldloc.s V_4
				L_00cf: ldc.i4.2 
				L_00d0: add 
				L_00d1: ldloc.s V_7
				L_00d3: ldc.i4.3 
				L_00d4: sub 
				L_00d5: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00da: ldarg.0 
				L_00db: ldloc.0 
				L_00dc: ldloc.s V_6
				L_00de: ldc.i4.1 
				L_00df: sub 
				L_00e0: ldloc.s V_5
				L_00e2: ldc.i4.1 
				L_00e3: add 
				L_00e4: ldloc.s V_6
				L_00e6: ldc.i4.1 
				L_00e7: sub 
				L_00e8: ldloc.s V_7
				L_00ea: ldc.i4.1 
				L_00eb: sub 
				L_00ec: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_00f1: ldarg.0 
				L_00f2: ldloc.1 
				L_00f3: ldloc.s V_6
				L_00f5: ldc.i4.2 
				L_00f6: sub 
				L_00f7: ldloc.s V_5
				L_00f9: ldc.i4.2 
				L_00fa: add 
				L_00fb: ldloc.s V_6
				L_00fd: ldc.i4.2 
				L_00fe: sub 
				L_00ff: ldloc.s V_7
				L_0101: ldc.i4.2 
				L_0102: sub 
				L_0103: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0108: ldarg.0 
				L_0109: ldloc.1 
				L_010a: ldloc.s V_6
				L_010c: ldc.i4.3 
				L_010d: sub 
				L_010e: ldloc.s V_5
				L_0110: ldc.i4.3 
				L_0111: add 
				L_0112: ldloc.s V_6
				L_0114: ldc.i4.3 
				L_0115: sub 
				L_0116: ldloc.s V_7
				L_0118: ldc.i4.3 
				L_0119: sub 
				L_011a: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_011f: ldarg.0 
				L_0120: ldloc.0 
				L_0121: ldloc.s V_6
				L_0123: ldc.i4.1 
				L_0124: sub 
				L_0125: ldloc.s V_7
				L_0127: ldc.i4.1 
				L_0128: sub 
				L_0129: ldloc.s V_4
				L_012b: ldloc.s V_7
				L_012d: ldc.i4.1 
				L_012e: sub 
				L_012f: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0134: ldarg.0 
				L_0135: ldloc.1 
				L_0136: ldloc.s V_6
				L_0138: ldc.i4.2 
				L_0139: sub 
				L_013a: ldloc.s V_7
				L_013c: ldc.i4.2 
				L_013d: sub 
				L_013e: ldloc.s V_4
				L_0140: ldc.i4.1 
				L_0141: add 
				L_0142: ldloc.s V_7
				L_0144: ldc.i4.2 
				L_0145: sub 
				L_0146: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_014b: ldarg.0 
				L_014c: ldloc.1 
				L_014d: ldloc.s V_6
				L_014f: ldc.i4.3 
				L_0150: sub 
				L_0151: ldloc.s V_7
				L_0153: ldc.i4.3 
				L_0154: sub 
				L_0155: ldloc.s V_4
				L_0157: ldc.i4.2 
				L_0158: add 
				L_0159: ldloc.s V_7
				L_015b: ldc.i4.3 
				L_015c: sub 
				L_015d: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0162: leave.s L_016e
				L_0164: ldloc.3 
				L_0165: brfalse.s L_016d
				L_0167: ldloc.3 
				L_0168: callvirt System.IDisposable::Void Dispose()
				L_016d: endfinally 
				L_016e: leave.s L_017a
				L_0170: ldloc.2 
				L_0171: brfalse.s L_0179
				L_0173: ldloc.2 
				L_0174: callvirt System.IDisposable::Void Dispose()
				L_0179: endfinally 
				L_017a: leave.s L_0186
				L_017c: ldloc.1 
				L_017d: brfalse.s L_0185
				L_017f: ldloc.1 
				L_0180: callvirt System.IDisposable::Void Dispose()
				L_0185: endfinally 
				L_0186: leave.s L_0192
				L_0188: ldloc.0 
				L_0189: brfalse.s L_0191
				L_018b: ldloc.0 
				L_018c: callvirt System.IDisposable::Void Dispose()
				L_0191: endfinally 
				L_0192: ret 
			*/
			
			
			{
				int i1;
				int i2;
				int i3;
				int i4;
				if ((x26545669838eb36e.Width > 2) && (x26545669838eb36e.Height > 2))
				{
					using (Pen pen1 = new Pen (xa7bf5f1d8010ffbc))
					{
						using (Pen pen2 = new Pen (x6f860ed2fc55db9e))
						{
							using (Pen pen3 = new Pen (x2a874aaea1ef79cd))
							{
								using (Pen pen4 = new Pen (x203ed3379fa39cc5))
								{
									i1 = x26545669838eb36e.Left;
									i2 = x26545669838eb36e.Top;
									i3 = x26545669838eb36e.Right;
									i4 = x26545669838eb36e.Bottom;
									x4b101060f4767186.DrawLine (pen3, ((int) (i3 - 1)), i2, i1, i2);
									x4b101060f4767186.DrawLine (pen4, ((int) (i3 - 2)), ((int) (i2 + 1)), ((int) (i1 + 1)), ((int) (i2 + 1)));
									x4b101060f4767186.DrawLine (pen2, ((int) (i3 - 3)), ((int) (i2 + 2)), ((int) (i1 + 2)), ((int) (i2 + 2)));
									x4b101060f4767186.DrawLine (pen3, i1, i2, i1, ((int) (i4 - 1)));
									x4b101060f4767186.DrawLine (pen4, ((int) (i1 + 1)), ((int) (i2 + 1)), ((int) (i1 + 1)), ((int) (i4 - 2)));
									x4b101060f4767186.DrawLine (pen2, ((int) (i1 + 2)), ((int) (i2 + 2)), ((int) (i1 + 2)), ((int) (i4 - 3)));
									x4b101060f4767186.DrawLine (pen1, ((int) (i3 - 1)), ((int) (i2 + 1)), ((int) (i3 - 1)), ((int) (i4 - 1)));
									x4b101060f4767186.DrawLine (pen2, ((int) (i3 - 2)), ((int) (i2 + 2)), ((int) (i3 - 2)), ((int) (i4 - 2)));
									x4b101060f4767186.DrawLine (pen2, ((int) (i3 - 3)), ((int) (i2 + 3)), ((int) (i3 - 3)), ((int) (i4 - 3)));
									x4b101060f4767186.DrawLine (pen1, ((int) (i3 - 1)), ((int) (i4 - 1)), i1, ((int) (i4 - 1)));
									x4b101060f4767186.DrawLine (pen2, ((int) (i3 - 2)), ((int) (i4 - 2)), ((int) (i1 + 1)), ((int) (i4 - 2)));
									x4b101060f4767186.DrawLine (pen2, ((int) (i3 - 3)), ((int) (i4 - 3)), ((int) (i1 + 2)), ((int) (i4 - 3)));
								}
							}
						}
					}
				}
			}
			
		#endregion
	}
	
}

