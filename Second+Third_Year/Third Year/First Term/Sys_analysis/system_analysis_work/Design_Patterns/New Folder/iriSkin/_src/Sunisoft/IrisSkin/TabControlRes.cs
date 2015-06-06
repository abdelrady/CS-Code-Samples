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
		
	public class TabControlRes : IDisposable
	
	{
		
		#region Fields
			private Pen x4e3bc09d0766bdda;
			private Bitmap[,] x564c6c527905c683;
			private Bitmap x711921dd2712f496;
			private Brush x9646b37d9a66d008;
			private ISkinEngine xdc87e2b99332cd4a;
		#endregion
		
		#region Constructors
		
			public TabControlRes (ISkinEngine engine)
			/*
				// Code Size: 20 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: stfld Sunisoft.IrisSkin.TabControlRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_000d: ldarg.0 
				L_000e: call Sunisoft.IrisSkin.TabControlRes::Void x03f66216ed8e1afe()
				L_0013: ret 
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
					L_0001: ldfld Sunisoft.IrisSkin.TabControlRes::System.Drawing.Brush x9646b37d9a66d008
					L_0006: ret 
				*/
				
				{
					return this.x9646b37d9a66d008;
				}
			}
			
			
			public Pen BorderPen
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.TabControlRes::System.Drawing.Pen x4e3bc09d0766bdda
					L_0006: ret 
				*/
				
				{
					return this.x4e3bc09d0766bdda;
				}
			}
			
			
			public Bitmap[,] TabImage
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.TabControlRes::System.Drawing.Bitmap[,] x564c6c527905c683
					L_0006: ret 
				*/
				
				{
					return this.x564c6c527905c683;
				}
			}
			
			
			public Bitmap TabLine
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.TabControlRes::System.Drawing.Bitmap x711921dd2712f496
					L_0006: ret 
				*/
				
				{
					return this.x711921dd2712f496;
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
				L_0002: stfld Sunisoft.IrisSkin.TabControlRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0007: ret 
			*/
			
			
			{
				this.xdc87e2b99332cd4a = ((ISkinEngine) null);
			}
			
			private void x03f66216ed8e1afe ()
			
			/*
				// Code Size: 168 Bytes
				.maxstack 9
				.locals (System.Int32 V_0)
				L_0000: ldarg.0 
				L_0001: ldarg.0 
				L_0002: ldfld Sunisoft.IrisSkin.TabControlRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0007: ldstr "SKIN2_TABCONTROLCOLOR"
				L_000c: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
				L_0011: stfld Sunisoft.IrisSkin.TabControlRes::System.Drawing.Brush x9646b37d9a66d008
				L_0016: ldarg.0 
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.TabControlRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_001d: ldstr "SKIN2_TABCONTROLBORDERCOLOR"
				L_0022: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
				L_0027: ldc.r4 1
				L_002c: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush, Single)
				L_0031: stfld Sunisoft.IrisSkin.TabControlRes::System.Drawing.Pen x4e3bc09d0766bdda
				L_0036: ldarg.0 
				L_0037: ldc.i4.2 
				L_0038: ldc.i4.3 
				L_0039: newobj System.Drawing.Bitmap[,]::Void .ctor(Int32, Int32)
				L_003e: stfld Sunisoft.IrisSkin.TabControlRes::System.Drawing.Bitmap[,] x564c6c527905c683
				L_0043: ldc.i4.0 
				L_0044: stloc.0 
				L_0045: br.s L_008d
				L_0047: ldarg.0 
				L_0048: ldfld Sunisoft.IrisSkin.TabControlRes::System.Drawing.Bitmap[,] x564c6c527905c683
				L_004d: ldc.i4.0 
				L_004e: ldloc.0 
				L_004f: ldarg.0 
				L_0050: ldfld Sunisoft.IrisSkin.TabControlRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0055: ldstr "SKIN2_TABCONTROL"
				L_005a: ldc.i4.6 
				L_005b: ldloc.0 
				L_005c: ldc.i4.1 
				L_005d: add 
				L_005e: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String, Int32, Int32)
				L_0063: call System.Drawing.Bitmap[,]::Void Set(Int32, Int32, System.Drawing.Bitmap)
				L_0068: ldarg.0 
				L_0069: ldfld Sunisoft.IrisSkin.TabControlRes::System.Drawing.Bitmap[,] x564c6c527905c683
				L_006e: ldc.i4.1 
				L_006f: ldloc.0 
				L_0070: ldarg.0 
				L_0071: ldfld Sunisoft.IrisSkin.TabControlRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0076: ldstr "SKIN2_TABCONTROL"
				L_007b: ldc.i4.6 
				L_007c: ldloc.0 
				L_007d: ldc.i4.4 
				L_007e: add 
				L_007f: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String, Int32, Int32)
				L_0084: call System.Drawing.Bitmap[,]::Void Set(Int32, Int32, System.Drawing.Bitmap)
				L_0089: ldloc.0 
				L_008a: ldc.i4.1 
				L_008b: add 
				L_008c: stloc.0 
				L_008d: ldloc.0 
				L_008e: ldc.i4.3 
				L_008f: blt.s L_0047
				L_0091: ldarg.0 
				L_0092: ldarg.0 
				L_0093: ldfld Sunisoft.IrisSkin.TabControlRes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0098: ldstr "SKIN2_TABCONTROLLINE"
				L_009d: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
				L_00a2: stfld Sunisoft.IrisSkin.TabControlRes::System.Drawing.Bitmap x711921dd2712f496
				L_00a7: ret 
			*/
			
			
			{
				int i1;
				this.x9646b37d9a66d008 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TABCONTROLCOLOR");
				this.x4e3bc09d0766bdda = new Pen (((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TABCONTROLBORDERCOLOR"), 1F);
				this.x564c6c527905c683 = new Bitmap [2, 3];
				for (i1 = 0; (i1 < 3); i1++)
				{
					this.x564c6c527905c683[0, i1] = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TABCONTROL", 6, ((int) (i1 + 1)));
					this.x564c6c527905c683[1, i1] = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TABCONTROL", 6, ((int) (i1 + 4)));
				}
				this.x711921dd2712f496 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TABCONTROLLINE");
			}
			
		#endregion
	}
	
}

