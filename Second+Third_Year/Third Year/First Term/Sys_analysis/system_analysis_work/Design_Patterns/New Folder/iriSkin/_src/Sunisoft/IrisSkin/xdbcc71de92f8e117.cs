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
			
			
		#endregion
		
	internal class xdbcc71de92f8e117 : x5b126f5f998c28e9
	
	{
		
		#region Constructors
		
			public xdbcc71de92f8e117 (IntPtr handle, ISkinEngine engine)
				 : base (handle, engine)
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: call Sunisoft.IrisSkin.x5b126f5f998c28e9::Void .ctor(IntPtr, Sunisoft.IrisSkin.SkinEngine)
				L_0008: ret 
			*/
		#endregion
		
		#region Methods
		
			protected override void PaintControl ()
			
			/*
				// Code Size: 374 Bytes
				.maxstack 7
				.locals (System.Int32 V_0, 
         System.UInt32 V_1, 
         System.Drawing.Bitmap V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Drawing.Rectangle V_5, 
         System.Drawing.Rectangle V_6, 
         System.Drawing.Bitmap V_7, 
         System.Drawing.Graphics V_8, 
         System.IntPtr V_9, 
         System.Drawing.Graphics V_10)
				.try L_00ba to L_010b finally L_010b to L_0117
				.try L_012d to L_014d finally L_014d to L_0159
				.try L_00b1 to L_0169 finally L_0169 to L_0175
				L_0000: ldc.i4.1 
				L_0001: stloc.0 
				L_0002: ldarg.0 
				L_0003: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0008: ldc.i4 240
				L_000d: ldsfld System.IntPtr::IntPtr Zero
				L_0012: ldsfld System.IntPtr::IntPtr Zero
				L_0017: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SendMessage(IntPtr, UInt32, IntPtr, IntPtr)
				L_001c: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_0021: stloc.1 
				L_0022: ldloc.1 
				L_0023: ldc.i4.1 
				L_0024: bne.un.s L_0036
				L_0026: ldarg.0 
				L_0027: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Boolean get_Enabled()
				L_002c: brfalse.s L_0032
				L_002e: ldc.i4.1 
				L_002f: stloc.0 
				L_0030: br.s L_0058
				L_0032: ldc.i4.4 
				L_0033: stloc.0 
				L_0034: br.s L_0058
				L_0036: ldloc.1 
				L_0037: ldc.i4.2 
				L_0038: bne.un.s L_004a
				L_003a: ldarg.0 
				L_003b: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Boolean get_Enabled()
				L_0040: brfalse.s L_0046
				L_0042: ldc.i4.2 
				L_0043: stloc.0 
				L_0044: br.s L_0058
				L_0046: ldc.i4.5 
				L_0047: stloc.0 
				L_0048: br.s L_0058
				L_004a: ldarg.0 
				L_004b: callvirt Sunisoft.IrisSkin.x5b126f5f998c28e9::Boolean get_Enabled()
				L_0050: brfalse.s L_0056
				L_0052: ldc.i4.3 
				L_0053: stloc.0 
				L_0054: br.s L_0058
				L_0056: ldc.i4.6 
				L_0057: stloc.0 
				L_0058: ldarg.0 
				L_0059: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_005e: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0063: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SplitBitmaps get_SplitBitmaps()
				L_0068: callvirt Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] get_SKIN2_CHECKBOX()
				L_006d: ldloc.0 
				L_006e: ldelem.ref 
				L_006f: stloc.2 
				L_0070: ldloc.2 
				L_0071: callvirt System.Drawing.Image::Int32 get_Width()
				L_0076: stloc.3 
				L_0077: ldloc.2 
				L_0078: callvirt System.Drawing.Image::Int32 get_Height()
				L_007d: stloc.s V_4
				L_007f: ldloc.3 
				L_0080: ldc.i4.s 14
				L_0082: bge.s L_0089
				L_0084: ldc.i4.s 14
				L_0086: stloc.3 
				L_0087: br.s L_0091
				L_0089: ldloc.3 
				L_008a: ldc.i4.s 15
				L_008c: ble.s L_0091
				L_008e: ldc.i4.s 15
				L_0090: stloc.3 
				L_0091: ldloc.s V_4
				L_0093: ldc.i4.s 14
				L_0095: bge.s L_009d
				L_0097: ldc.i4.s 14
				L_0099: stloc.s V_4
				L_009b: br.s L_00a7
				L_009d: ldloc.s V_4
				L_009f: ldc.i4.s 15
				L_00a1: ble.s L_00a7
				L_00a3: ldc.i4.s 15
				L_00a5: stloc.s V_4
				L_00a7: ldloc.3 
				L_00a8: ldloc.s V_4
				L_00aa: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_00af: stloc.s V_7
				L_00b1: ldloc.s V_7
				L_00b3: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_00b8: stloc.s V_8
				L_00ba: ldloc.s V_8
				L_00bc: ldarg.0 
				L_00bd: ldfld Sunisoft.IrisSkin.x5b126f5f998c28e9::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00c2: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00c7: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_00cc: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_FORMCOLOR()
				L_00d1: ldc.i4.0 
				L_00d2: ldc.i4.0 
				L_00d3: ldloc.3 
				L_00d4: ldloc.s V_4
				L_00d6: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_00db: ldloca.s V_5
				L_00dd: ldc.i4.0 
				L_00de: ldc.i4.0 
				L_00df: ldloc.3 
				L_00e0: ldloc.s V_4
				L_00e2: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00e7: ldloca.s V_6
				L_00e9: ldc.i4.0 
				L_00ea: ldc.i4.0 
				L_00eb: ldloc.2 
				L_00ec: callvirt System.Drawing.Image::Int32 get_Width()
				L_00f1: ldloc.2 
				L_00f2: callvirt System.Drawing.Image::Int32 get_Height()
				L_00f7: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00fc: ldloc.s V_8
				L_00fe: ldloc.2 
				L_00ff: ldloc.s V_5
				L_0101: ldloc.s V_6
				L_0103: ldc.i4.2 
				L_0104: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0109: leave.s L_0117
				L_010b: ldloc.s V_8
				L_010d: brfalse.s L_0116
				L_010f: ldloc.s V_8
				L_0111: callvirt System.IDisposable::Void Dispose()
				L_0116: endfinally 
				L_0117: ldarg.0 
				L_0118: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_011d: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetWindowDC(IntPtr)
				L_0122: stloc.s V_9
				L_0124: ldloc.s V_9
				L_0126: call System.Drawing.Graphics::System.Drawing.Graphics FromHdc(IntPtr)
				L_012b: stloc.s V_10
				L_012d: ldloca.s V_6
				L_012f: ldc.i4.0 
				L_0130: ldc.i4.0 
				L_0131: ldloc.3 
				L_0132: ldloc.s V_4
				L_0134: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0139: ldloc.s V_6
				L_013b: stloc.s V_5
				L_013d: ldloc.s V_10
				L_013f: ldloc.s V_7
				L_0141: ldloc.s V_5
				L_0143: ldloc.s V_6
				L_0145: ldc.i4.2 
				L_0146: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_014b: leave.s L_0159
				L_014d: ldloc.s V_10
				L_014f: brfalse.s L_0158
				L_0151: ldloc.s V_10
				L_0153: callvirt System.IDisposable::Void Dispose()
				L_0158: endfinally 
				L_0159: ldarg.0 
				L_015a: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_015f: ldloc.s V_9
				L_0161: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_0166: pop 
				L_0167: leave.s L_0175
				L_0169: ldloc.s V_7
				L_016b: brfalse.s L_0174
				L_016d: ldloc.s V_7
				L_016f: callvirt System.IDisposable::Void Dispose()
				L_0174: endfinally 
				L_0175: ret 
			*/
			
			
			{
				uint uInt32_1;
				Rectangle rectangle1;
				Rectangle rectangle2;
				IntPtr intPtr1;
				int i1 = 1;
				if ((uInt32_1 = ((uint) ((int) x61467fe65a98f20c.SendMessage (base.Handle, 240, IntPtr.Zero, IntPtr.Zero)))) == 1)
				{
					if (this.Enabled)
					{
						i1 = 1;
					}
					else
					{
						i1 = 4;
					}
				}
				else if (uInt32_1 == 2)
				{
					if (this.Enabled)
					{
						i1 = 2;
					}
					else
					{
						i1 = 5;
					}
				}
				else if (this.Enabled)
				{
					i1 = 3;
				}
				else
				{
					i1 = 6;
				}
				Bitmap bitmap1 = ((SplitBitmaps) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).SplitBitmaps).SKIN2_CHECKBOX[i1];
				int i2 = bitmap1.Width;
				int i3 = bitmap1.Height;
				if (i2 < 14)
				{
					i2 = 14;
				}
				else if (i2 > 15)
				{
					i2 = 15;
				}
				if (i3 < 14)
				{
					i3 = 14;
				}
				else if (i3 > 15)
				{
					i3 = 15;
				}
				using (Bitmap bitmap2 = new Bitmap (i2, i3))
				{
					using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap2)))
					{
						graphics1.FillRectangle (((SkinBrushes) ((Res) ((SkinEngine) base.xdc87e2b99332cd4a).Res).Brushes).SKIN2_FORMCOLOR, 0, 0, i2, i3);
						rectangle1 = new Rectangle (0, 0, i2, i3);
						rectangle2 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						graphics1.DrawImage (((Image) bitmap1), rectangle1, rectangle2, GraphicsUnit.Pixel);
					}
					intPtr1 = x61467fe65a98f20c.GetWindowDC (base.Handle);
					using (Graphics graphics2 = Graphics.FromHdc (intPtr1))
					{
						rectangle2 = new Rectangle (0, 0, i2, i3);
						rectangle1 = rectangle2;
						graphics2.DrawImage (((Image) bitmap2), rectangle1, rectangle2, GraphicsUnit.Pixel);
					}
					int i4 = x61467fe65a98f20c.ReleaseDC (base.Handle, intPtr1);
				}
			}
			
		#endregion
	}
	
}

