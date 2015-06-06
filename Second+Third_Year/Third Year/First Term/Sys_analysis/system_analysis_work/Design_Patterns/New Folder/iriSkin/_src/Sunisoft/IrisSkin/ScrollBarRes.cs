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
		
	public class ScrollBarRes : IDisposable
	
	{
		
		#region Fields
			private Bitmap[,] x804214fd8fadc2a7;
			private Brush x9646b37d9a66d008;
			private bool xa605cad12563f03c;
			private Bitmap[,] xc088a3c732c3a72e;
			private ISkinEngine xdc87e2b99332cd4a;
			private Bitmap[,] xe26e029a72589589;
		#endregion
		
		#region Constructors
		
			public ScrollBarRes (ISkinEngine engine)
			/*
				// Code Size: 27 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.0 
				L_0002: stfld Sunisoft.IrisSkin.ScrollBarRes::Boolean xa605cad12563f03c
				L_0007: ldarg.0 
				L_0008: call System.Object::Void .ctor()
				L_000d: ldarg.0 
				L_000e: ldarg.1 
				L_000f: stfld Sunisoft.IrisSkin.ScrollBarRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0014: ldarg.0 
				L_0015: call Sunisoft.IrisSkin.ScrollBarRes::Void x89aa76148c30a93b()
				L_001a: ret 
			*/
		#endregion
		
		#region Properties
		
			public Brush BackColorBrush
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Brush x9646b37d9a66d008
					L_0006: ret 
				*/
				
				{
					return this.x9646b37d9a66d008;
				}
			}
			
			
			public Bitmap[,] DownButton
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] xe26e029a72589589
					L_0006: ret 
				*/
				
				{
					return this.xe26e029a72589589;
				}
			}
			
			
			public bool IsMacOS
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.ScrollBarRes::Boolean xa605cad12563f03c
					L_0006: ret 
				*/
				
				{
					return this.xa605cad12563f03c;
				}
			}
			
			
			public Bitmap[,] Slider
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] xc088a3c732c3a72e
					L_0006: ret 
				*/
				
				{
					return this.xc088a3c732c3a72e;
				}
			}
			
			
			public Bitmap[,] UpButton
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] x804214fd8fadc2a7
					L_0006: ret 
				*/
				
				{
					return this.x804214fd8fadc2a7;
				}
			}
			
		#endregion
		
		#region Methods
		
			public virtual void Dispose ()
			
			/*
				// Code Size: 8 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.ScrollBarRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0007: ret 
			*/
			
			
			{
				this.xdc87e2b99332cd4a = ((ISkinEngine) null);
			}
			
			private void x89aa76148c30a93b ()
			
			/*
				// Code Size: 739 Bytes
				.maxstack 8
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Drawing.Bitmap V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Drawing.Graphics V_7)
				.try L_0182 to L_01e7 catch System.Object L_01e7 to L_01ea
				.try L_0267 to L_028a finally L_028a to L_0296
				L_0000: ldarg.0 
				L_0001: ldarg.0 
				L_0002: ldfld Sunisoft.IrisSkin.ScrollBarRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0007: ldstr "SKIN2_SCROLLBARCOLOR"
				L_000c: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
				L_0011: stfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Brush x9646b37d9a66d008
				L_0016: ldarg.0 
				L_0017: ldc.i4.2 
				L_0018: ldc.i4.3 
				L_0019: newobj System.Drawing.Bitmap[,]::Void .ctor(Int32, Int32)
				L_001e: stfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] x804214fd8fadc2a7
				L_0023: ldarg.0 
				L_0024: ldc.i4.2 
				L_0025: ldc.i4.3 
				L_0026: newobj System.Drawing.Bitmap[,]::Void .ctor(Int32, Int32)
				L_002b: stfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] xe26e029a72589589
				L_0030: ldarg.0 
				L_0031: ldc.i4.2 
				L_0032: ldc.i4.5 
				L_0033: newobj System.Drawing.Bitmap[,]::Void .ctor(Int32, Int32)
				L_0038: stfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] xc088a3c732c3a72e
				L_003d: ldarg.0 
				L_003e: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] x804214fd8fadc2a7
				L_0043: ldc.i4.0 
				L_0044: ldc.i4.0 
				L_0045: ldarg.0 
				L_0046: ldfld Sunisoft.IrisSkin.ScrollBarRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_004b: ldstr "SKIN2_SCROLLBARUPBUTTON"
				L_0050: ldc.i4.3 
				L_0051: ldc.i4.1 
				L_0052: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String, Int32, Int32)
				L_0057: call System.Drawing.Bitmap[,]::Void Set(Int32, Int32, System.Drawing.Bitmap)
				L_005c: ldarg.0 
				L_005d: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] x804214fd8fadc2a7
				L_0062: ldc.i4.0 
				L_0063: ldc.i4.1 
				L_0064: ldarg.0 
				L_0065: ldfld Sunisoft.IrisSkin.ScrollBarRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_006a: ldstr "SKIN2_SCROLLBARUPBUTTON"
				L_006f: ldc.i4.3 
				L_0070: ldc.i4.2 
				L_0071: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String, Int32, Int32)
				L_0076: call System.Drawing.Bitmap[,]::Void Set(Int32, Int32, System.Drawing.Bitmap)
				L_007b: ldarg.0 
				L_007c: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] x804214fd8fadc2a7
				L_0081: ldc.i4.0 
				L_0082: ldc.i4.2 
				L_0083: ldarg.0 
				L_0084: ldfld Sunisoft.IrisSkin.ScrollBarRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0089: ldstr "SKIN2_SCROLLBARUPBUTTON"
				L_008e: ldc.i4.3 
				L_008f: ldc.i4.3 
				L_0090: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String, Int32, Int32)
				L_0095: call System.Drawing.Bitmap[,]::Void Set(Int32, Int32, System.Drawing.Bitmap)
				L_009a: ldarg.0 
				L_009b: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] xe26e029a72589589
				L_00a0: ldc.i4.0 
				L_00a1: ldc.i4.0 
				L_00a2: ldarg.0 
				L_00a3: ldfld Sunisoft.IrisSkin.ScrollBarRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00a8: ldstr "SKIN2_SCROLLBARDOWNBUTTON"
				L_00ad: ldc.i4.3 
				L_00ae: ldc.i4.1 
				L_00af: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String, Int32, Int32)
				L_00b4: call System.Drawing.Bitmap[,]::Void Set(Int32, Int32, System.Drawing.Bitmap)
				L_00b9: ldarg.0 
				L_00ba: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] xe26e029a72589589
				L_00bf: ldc.i4.0 
				L_00c0: ldc.i4.1 
				L_00c1: ldarg.0 
				L_00c2: ldfld Sunisoft.IrisSkin.ScrollBarRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00c7: ldstr "SKIN2_SCROLLBARDOWNBUTTON"
				L_00cc: ldc.i4.3 
				L_00cd: ldc.i4.2 
				L_00ce: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String, Int32, Int32)
				L_00d3: call System.Drawing.Bitmap[,]::Void Set(Int32, Int32, System.Drawing.Bitmap)
				L_00d8: ldarg.0 
				L_00d9: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] xe26e029a72589589
				L_00de: ldc.i4.0 
				L_00df: ldc.i4.2 
				L_00e0: ldarg.0 
				L_00e1: ldfld Sunisoft.IrisSkin.ScrollBarRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00e6: ldstr "SKIN2_SCROLLBARDOWNBUTTON"
				L_00eb: ldc.i4.3 
				L_00ec: ldc.i4.3 
				L_00ed: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String, Int32, Int32)
				L_00f2: call System.Drawing.Bitmap[,]::Void Set(Int32, Int32, System.Drawing.Bitmap)
				L_00f7: ldc.i4.0 
				L_00f8: stloc.3 
				L_00f9: br.s L_016d
				L_00fb: ldarg.0 
				L_00fc: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] x804214fd8fadc2a7
				L_0101: ldc.i4.1 
				L_0102: ldloc.3 
				L_0103: ldarg.0 
				L_0104: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] x804214fd8fadc2a7
				L_0109: ldc.i4.0 
				L_010a: ldloc.3 
				L_010b: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_0110: callvirt System.Drawing.Image::System.Object Clone()
				L_0115: castclass System.Drawing.Bitmap
				L_011a: call System.Drawing.Bitmap[,]::Void Set(Int32, Int32, System.Drawing.Bitmap)
				L_011f: ldarg.0 
				L_0120: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] x804214fd8fadc2a7
				L_0125: ldc.i4.1 
				L_0126: ldloc.3 
				L_0127: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_012c: ldc.i4.3 
				L_012d: callvirt System.Drawing.Image::Void RotateFlip(System.Drawing.RotateFlipType)
				L_0132: ldarg.0 
				L_0133: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] xe26e029a72589589
				L_0138: ldc.i4.1 
				L_0139: ldloc.3 
				L_013a: ldarg.0 
				L_013b: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] xe26e029a72589589
				L_0140: ldc.i4.0 
				L_0141: ldloc.3 
				L_0142: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_0147: callvirt System.Drawing.Image::System.Object Clone()
				L_014c: castclass System.Drawing.Bitmap
				L_0151: call System.Drawing.Bitmap[,]::Void Set(Int32, Int32, System.Drawing.Bitmap)
				L_0156: ldarg.0 
				L_0157: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] xe26e029a72589589
				L_015c: ldc.i4.1 
				L_015d: ldloc.3 
				L_015e: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_0163: ldc.i4.3 
				L_0164: callvirt System.Drawing.Image::Void RotateFlip(System.Drawing.RotateFlipType)
				L_0169: ldloc.3 
				L_016a: ldc.i4.1 
				L_016b: add 
				L_016c: stloc.3 
				L_016d: ldloc.3 
				L_016e: ldc.i4.3 
				L_016f: blt.s L_00fb
				L_0171: ldarg.0 
				L_0172: ldfld Sunisoft.IrisSkin.ScrollBarRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0177: ldstr "SKIN2_SCROLLBAR"
				L_017c: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
				L_0181: stloc.2 
				L_0182: ldloc.2 
				L_0183: callvirt System.Drawing.Image::Int32 get_Height()
				L_0188: ldc.i4.s 33
				L_018a: bne.un.s L_01e5
				L_018c: ldarg.0 
				L_018d: ldfld Sunisoft.IrisSkin.ScrollBarRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0192: ldstr "SKIN2_SCROLLBARCOLOR"
				L_0197: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_019c: ldc.i4 255
				L_01a1: ldc.i4 203
				L_01a6: ldc.i4 203
				L_01ab: ldc.i4 203
				L_01b0: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_01b5: call System.Drawing.Color::Boolean op_Equality(System.Drawing.Color, System.Drawing.Color)
				L_01ba: brfalse.s L_01e5
				L_01bc: ldloc.2 
				L_01bd: ldc.i4.1 
				L_01be: ldc.i4.s 10
				L_01c0: callvirt System.Drawing.Bitmap::System.Drawing.Color GetPixel(Int32, Int32)
				L_01c5: ldc.i4 255
				L_01ca: ldc.i4.1 
				L_01cb: ldc.i4.s 57
				L_01cd: ldc.i4 178
				L_01d2: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_01d7: call System.Drawing.Color::Boolean op_Equality(System.Drawing.Color, System.Drawing.Color)
				L_01dc: brfalse.s L_01e5
				L_01de: ldarg.0 
				L_01df: ldc.i4.1 
				L_01e0: stfld Sunisoft.IrisSkin.ScrollBarRes::Boolean xa605cad12563f03c
				L_01e5: leave.s L_01ea
				L_01e7: pop 
				L_01e8: leave.s L_01ea
				L_01ea: ldloc.2 
				L_01eb: callvirt System.Drawing.Image::Int32 get_Height()
				L_01f0: ldc.i4.6 
				L_01f1: sub 
				L_01f2: ldc.i4.3 
				L_01f3: div 
				L_01f4: stloc.1 
				L_01f5: ldloc.2 
				L_01f6: callvirt System.Drawing.Image::Int32 get_Width()
				L_01fb: stloc.0 
				L_01fc: ldc.i4.0 
				L_01fd: stloc.s V_4
				L_01ff: ldc.i4.0 
				L_0200: stloc.s V_5
				L_0202: ldc.i4.0 
				L_0203: stloc.s V_6
				L_0205: br L_02da
				L_020a: ldloc.s V_6
				L_020c: brfalse.s L_0213
				L_020e: ldloc.s V_6
				L_0210: ldc.i4.4 
				L_0211: bne.un.s L_021b
				L_0213: ldloc.s V_5
				L_0215: ldc.i4.3 
				L_0216: add 
				L_0217: stloc.s V_5
				L_0219: br.s L_0239
				L_021b: ldloc.s V_6
				L_021d: ldc.i4.2 
				L_021e: bne.un.s L_0233
				L_0220: ldloc.s V_5
				L_0222: ldloc.1 
				L_0223: ldloc.2 
				L_0224: callvirt System.Drawing.Image::Int32 get_Height()
				L_0229: ldc.i4.6 
				L_022a: sub 
				L_022b: ldc.i4.3 
				L_022c: rem 
				L_022d: add 
				L_022e: add 
				L_022f: stloc.s V_5
				L_0231: br.s L_0239
				L_0233: ldloc.s V_5
				L_0235: ldloc.1 
				L_0236: add 
				L_0237: stloc.s V_5
				L_0239: ldarg.0 
				L_023a: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] xc088a3c732c3a72e
				L_023f: ldc.i4.0 
				L_0240: ldloc.s V_6
				L_0242: ldloc.0 
				L_0243: ldloc.s V_5
				L_0245: ldloc.s V_4
				L_0247: sub 
				L_0248: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_024d: call System.Drawing.Bitmap[,]::Void Set(Int32, Int32, System.Drawing.Bitmap)
				L_0252: ldarg.0 
				L_0253: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] xc088a3c732c3a72e
				L_0258: ldc.i4.0 
				L_0259: ldloc.s V_6
				L_025b: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_0260: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0265: stloc.s V_7
				L_0267: ldloc.s V_7
				L_0269: ldloc.2 
				L_026a: ldc.i4.0 
				L_026b: ldc.i4.0 
				L_026c: ldloc.0 
				L_026d: ldloc.s V_5
				L_026f: ldloc.s V_4
				L_0271: sub 
				L_0272: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0277: ldc.i4.0 
				L_0278: ldloc.s V_4
				L_027a: ldloc.0 
				L_027b: ldloc.s V_5
				L_027d: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0282: ldc.i4.2 
				L_0283: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0288: leave.s L_0296
				L_028a: ldloc.s V_7
				L_028c: brfalse.s L_0295
				L_028e: ldloc.s V_7
				L_0290: callvirt System.IDisposable::Void Dispose()
				L_0295: endfinally 
				L_0296: ldarg.0 
				L_0297: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] xc088a3c732c3a72e
				L_029c: ldc.i4.1 
				L_029d: ldloc.s V_6
				L_029f: ldarg.0 
				L_02a0: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] xc088a3c732c3a72e
				L_02a5: ldc.i4.0 
				L_02a6: ldloc.s V_6
				L_02a8: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_02ad: callvirt System.Drawing.Image::System.Object Clone()
				L_02b2: castclass System.Drawing.Bitmap
				L_02b7: call System.Drawing.Bitmap[,]::Void Set(Int32, Int32, System.Drawing.Bitmap)
				L_02bc: ldarg.0 
				L_02bd: ldfld Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] xc088a3c732c3a72e
				L_02c2: ldc.i4.1 
				L_02c3: ldloc.s V_6
				L_02c5: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_02ca: ldc.i4.3 
				L_02cb: callvirt System.Drawing.Image::Void RotateFlip(System.Drawing.RotateFlipType)
				L_02d0: ldloc.s V_5
				L_02d2: stloc.s V_4
				L_02d4: ldloc.s V_6
				L_02d6: ldc.i4.1 
				L_02d7: add 
				L_02d8: stloc.s V_6
				L_02da: ldloc.s V_6
				L_02dc: ldc.i4.5 
				L_02dd: blt L_020a
				L_02e2: ret 
			*/
			
			
			{
				int i3;
				this.x9646b37d9a66d008 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_SCROLLBARCOLOR");
				this.x804214fd8fadc2a7 = new Bitmap [2, 3];
				this.xe26e029a72589589 = new Bitmap [2, 3];
				this.xc088a3c732c3a72e = new Bitmap [2, 5];
				this.x804214fd8fadc2a7[0, 0] = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_SCROLLBARUPBUTTON", 3, 1);
				this.x804214fd8fadc2a7[0, 1] = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_SCROLLBARUPBUTTON", 3, 2);
				this.x804214fd8fadc2a7[0, 2] = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_SCROLLBARUPBUTTON", 3, 3);
				this.xe26e029a72589589[0, 0] = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_SCROLLBARDOWNBUTTON", 3, 1);
				this.xe26e029a72589589[0, 1] = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_SCROLLBARDOWNBUTTON", 3, 2);
				this.xe26e029a72589589[0, 2] = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_SCROLLBARDOWNBUTTON", 3, 3);
				for (i3 = 0; (i3 < 3); i3++)
				{
					this.x804214fd8fadc2a7[1, i3] = ((Bitmap) this.x804214fd8fadc2a7[0, i3].Clone ());
					this.x804214fd8fadc2a7[1, i3].RotateFlip (RotateFlipType.Rotate270FlipNone);
					this.xe26e029a72589589[1, i3] = ((Bitmap) this.xe26e029a72589589[0, i3].Clone ());
					this.xe26e029a72589589[1, i3].RotateFlip (RotateFlipType.Rotate270FlipNone);
				}
				Bitmap bitmap1 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_SCROLLBAR");
				try
				{
					if (((bitmap1.Height == 33) && (((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_SCROLLBARCOLOR") == Color.FromArgb (255, 203, 203, 203))) && (bitmap1.GetPixel (1, 10) == Color.FromArgb (255, 1, 57, 178)))
					{
						this.xa605cad12563f03c = true;
					}
				}
				catch
				{
				}
				int i2 = ((bitmap1.Height - 6) / 3);
				int i1 = bitmap1.Width;
				int i4 = 0;
				int i5 = 0;
				for (int i6 = 0; (i6 < 5); i6++)
				{
					if ((i6 == 0) || (i6 == 4))
					{
						i5 += 3;
					}
					else if (i6 != 2)
					{
						i5 += i2;
					}
					else
					{
						i5 += (i2 + ((bitmap1.Height - 6) % 3));
					}
					this.xc088a3c732c3a72e[0, i6] = new Bitmap (i1, ((int) (i5 - i4)));
					using (Graphics graphics1 = Graphics.FromImage (((Image) this.xc088a3c732c3a72e[0, i6])))
					{
						graphics1.DrawImage (((Image) bitmap1), new Rectangle (0, 0, i1, ((int) (i5 - i4))), Rectangle.FromLTRB (0, i4, i1, i5), GraphicsUnit.Pixel);
					}
					this.xc088a3c732c3a72e[1, i6] = ((Bitmap) this.xc088a3c732c3a72e[0, i6].Clone ());
					this.xc088a3c732c3a72e[1, i6].RotateFlip (RotateFlipType.Rotate270FlipNone);
					i4 = i5;
				}
			}
			
		#endregion
	}
	
}

