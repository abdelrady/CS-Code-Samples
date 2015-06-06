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
		
	public class SplitBitmaps : ISplitBitmaps, IDisposable
	
	{
		
		#region Fields
			private Bitmap[] x3d2e024a784598d5;
			private Bitmap[] x4944f3253ed604fe;
			private Bitmap[] x842bba7c67d596f0;
			private Bitmap[] x842f8dce891d0e49;
			private ISkinEngine xdc87e2b99332cd4a;
		#endregion
		
		#region Constructors
		
			public SplitBitmaps (ISkinEngine engine)
			/*
				// Code Size: 20 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: stfld Sunisoft.IrisSkin.SplitBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_000d: ldarg.0 
				L_000e: call Sunisoft.IrisSkin.SplitBitmaps::Void x25a256ec885d930e()
				L_0013: ret 
			*/
		#endregion
		
		#region Properties
		
			public Bitmap[] SKIN2_BUTTON
			
			{
				get
				
				/*
					// Code Size: 65 Bytes
					.maxstack 7
					.locals (System.Int32 V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x3d2e024a784598d5
					L_0006: brtrue.s L_003a
					L_0008: ldarg.0 
					L_0009: ldc.i4.4 
					L_000a: newarr System.Drawing.Bitmap
					L_000f: stfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x3d2e024a784598d5
					L_0014: ldc.i4.1 
					L_0015: stloc.0 
					L_0016: br.s L_0036
					L_0018: ldarg.0 
					L_0019: ldfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x3d2e024a784598d5
					L_001e: ldloc.0 
					L_001f: ldarg.0 
					L_0020: ldfld Sunisoft.IrisSkin.SplitBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0025: ldstr "SKIN2_BUTTON"
					L_002a: ldc.i4.3 
					L_002b: ldloc.0 
					L_002c: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String, Int32, Int32)
					L_0031: stelem.ref 
					L_0032: ldloc.0 
					L_0033: ldc.i4.1 
					L_0034: add 
					L_0035: stloc.0 
					L_0036: ldloc.0 
					L_0037: ldc.i4.4 
					L_0038: blt.s L_0018
					L_003a: ldarg.0 
					L_003b: ldfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x3d2e024a784598d5
					L_0040: ret 
				*/
				
				{
					int i1;
					if (this.x3d2e024a784598d5 == null)
					{
						this.x3d2e024a784598d5 = new Bitmap[4];
						for (i1 = 1; (i1 < 4); i1++)
						{
							this.x3d2e024a784598d5[i1] = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_BUTTON", 3, i1);
						}
					}
					return this.x3d2e024a784598d5;
				}
			}
			
			
			public Bitmap[] SKIN2_CHECKBOX
			
			{
				get
				
				/*
					// Code Size: 65 Bytes
					.maxstack 7
					.locals (System.Int32 V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x842bba7c67d596f0
					L_0006: brtrue.s L_003a
					L_0008: ldarg.0 
					L_0009: ldc.i4.7 
					L_000a: newarr System.Drawing.Bitmap
					L_000f: stfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x842bba7c67d596f0
					L_0014: ldc.i4.1 
					L_0015: stloc.0 
					L_0016: br.s L_0036
					L_0018: ldarg.0 
					L_0019: ldfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x842bba7c67d596f0
					L_001e: ldloc.0 
					L_001f: ldarg.0 
					L_0020: ldfld Sunisoft.IrisSkin.SplitBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0025: ldstr "SKIN2_CHECKBOX"
					L_002a: ldc.i4.6 
					L_002b: ldloc.0 
					L_002c: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String, Int32, Int32)
					L_0031: stelem.ref 
					L_0032: ldloc.0 
					L_0033: ldc.i4.1 
					L_0034: add 
					L_0035: stloc.0 
					L_0036: ldloc.0 
					L_0037: ldc.i4.7 
					L_0038: blt.s L_0018
					L_003a: ldarg.0 
					L_003b: ldfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x842bba7c67d596f0
					L_0040: ret 
				*/
				
				{
					int i1;
					if (this.x842bba7c67d596f0 == null)
					{
						this.x842bba7c67d596f0 = new Bitmap[7];
						for (i1 = 1; (i1 < 7); i1++)
						{
							this.x842bba7c67d596f0[i1] = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_CHECKBOX", 6, i1);
						}
					}
					return this.x842bba7c67d596f0;
				}
			}
			
			
			public Bitmap[] SKIN2_RADIOBUTTON
			
			{
				get
				
				/*
					// Code Size: 65 Bytes
					.maxstack 7
					.locals (System.Int32 V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x4944f3253ed604fe
					L_0006: brtrue.s L_003a
					L_0008: ldarg.0 
					L_0009: ldc.i4.5 
					L_000a: newarr System.Drawing.Bitmap
					L_000f: stfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x4944f3253ed604fe
					L_0014: ldc.i4.1 
					L_0015: stloc.0 
					L_0016: br.s L_0036
					L_0018: ldarg.0 
					L_0019: ldfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x4944f3253ed604fe
					L_001e: ldloc.0 
					L_001f: ldarg.0 
					L_0020: ldfld Sunisoft.IrisSkin.SplitBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0025: ldstr "SKIN2_RADIOBUTTON"
					L_002a: ldc.i4.4 
					L_002b: ldloc.0 
					L_002c: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String, Int32, Int32)
					L_0031: stelem.ref 
					L_0032: ldloc.0 
					L_0033: ldc.i4.1 
					L_0034: add 
					L_0035: stloc.0 
					L_0036: ldloc.0 
					L_0037: ldc.i4.5 
					L_0038: blt.s L_0018
					L_003a: ldarg.0 
					L_003b: ldfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x4944f3253ed604fe
					L_0040: ret 
				*/
				
				{
					int i1;
					if (this.x4944f3253ed604fe == null)
					{
						this.x4944f3253ed604fe = new Bitmap[5];
						for (i1 = 1; (i1 < 5); i1++)
						{
							this.x4944f3253ed604fe[i1] = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_RADIOBUTTON", 4, i1);
						}
					}
					return this.x4944f3253ed604fe;
				}
			}
			
			
			public Bitmap[] SKIN2_TITLEBUTTONS
			
			{
				get
				
				/*
					// Code Size: 68 Bytes
					.maxstack 7
					.locals (System.Int32 V_0)
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x842f8dce891d0e49
					L_0006: brtrue.s L_003d
					L_0008: ldarg.0 
					L_0009: ldc.i4.s 19
					L_000b: newarr System.Drawing.Bitmap
					L_0010: stfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x842f8dce891d0e49
					L_0015: ldc.i4.1 
					L_0016: stloc.0 
					L_0017: br.s L_0038
					L_0019: ldarg.0 
					L_001a: ldfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x842f8dce891d0e49
					L_001f: ldloc.0 
					L_0020: ldarg.0 
					L_0021: ldfld Sunisoft.IrisSkin.SplitBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_0026: ldstr "SKIN2_TITLEBUTTONS"
					L_002b: ldc.i4.s 18
					L_002d: ldloc.0 
					L_002e: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String, Int32, Int32)
					L_0033: stelem.ref 
					L_0034: ldloc.0 
					L_0035: ldc.i4.1 
					L_0036: add 
					L_0037: stloc.0 
					L_0038: ldloc.0 
					L_0039: ldc.i4.s 19
					L_003b: blt.s L_0019
					L_003d: ldarg.0 
					L_003e: ldfld Sunisoft.IrisSkin.SplitBitmaps::System.Drawing.Bitmap[] x842f8dce891d0e49
					L_0043: ret 
				*/
				
				{
					int i1;
					if (this.x842f8dce891d0e49 == null)
					{
						this.x842f8dce891d0e49 = new Bitmap[19];
						for (i1 = 1; (i1 < 19); i1++)
						{
							this.x842f8dce891d0e49[i1] = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TITLEBUTTONS", 18, i1);
						}
					}
					return this.x842f8dce891d0e49;
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
				L_0002: stfld Sunisoft.IrisSkin.SplitBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0007: ret 
			*/
			
			
			{
				this.xdc87e2b99332cd4a = ((ISkinEngine) null);
			}
			
			private void x25a256ec885d930e ()
			
			/*
				// Code Size: 1 Bytes
				.maxstack 9
				L_0000: ret 
			*/
			
			
			{
			}
			
		#endregion
	}
	
}

