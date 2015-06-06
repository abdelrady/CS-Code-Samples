//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin

{
		
		#region Namespace Import Declarations
		
			using System;
			
			
		#endregion
		
	public class Res : IRes, IDisposable
	
	{
		
		#region Fields
			private ISkinInt x2491a4d79a7b1ed9;
			private TabControlRes x3bf027fb2999c92f;
			private ISkinBools x78ac2e397a838680;
			private ISplitBitmaps x89e66747b11f0a70;
			private ISkinBrushes x91bc7f70f8537c7c;
			private ISkinColors xa70c7ccd3278240f;
			private ScrollBarRes xbf1147be56545845;
			private ISkinEngine xdc87e2b99332cd4a;
			private ISkinBitmaps xfcfb5c1949fe6b20;
		#endregion
		
		#region Constructors
		
			public Res (ISkinEngine engine)
			/*
				// Code Size: 20 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: stfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_000d: ldarg.0 
				L_000e: call Sunisoft.IrisSkin.Res::Void x30b60dadc625bd97()
				L_0013: ret 
			*/
		#endregion
		
		#region Properties
		
			public ISkinBitmaps Bitmaps
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps xfcfb5c1949fe6b20
					L_0006: ret 
				*/
				
				{
					return this.xfcfb5c1949fe6b20;
				}
			}
			
			
			public ISkinBools Bools
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBools x78ac2e397a838680
					L_0006: ret 
				*/
				
				{
					return this.x78ac2e397a838680;
				}
			}
			
			
			public ISkinBrushes Brushes
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes x91bc7f70f8537c7c
					L_0006: ret 
				*/
				
				{
					return this.x91bc7f70f8537c7c;
				}
			}
			
			
			public ISkinColors Colors
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors xa70c7ccd3278240f
					L_0006: ret 
				*/
				
				{
					return this.xa70c7ccd3278240f;
				}
			}
			
			
			public ISkinInt Integers
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinInt x2491a4d79a7b1ed9
					L_0006: ret 
				*/
				
				{
					return this.x2491a4d79a7b1ed9;
				}
			}
			
			
			public ScrollBarRes ScrollBarRes
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes xbf1147be56545845
					L_0006: ret 
				*/
				
				{
					return this.xbf1147be56545845;
				}
			}
			
			
			public ISplitBitmaps SplitBitmaps
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SplitBitmaps x89e66747b11f0a70
					L_0006: ret 
				*/
				
				{
					return this.x89e66747b11f0a70;
				}
			}
			
			
			public TabControlRes TabControlRes
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.TabControlRes x3bf027fb2999c92f
					L_0006: ret 
				*/
				
				{
					return this.x3bf027fb2999c92f;
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
				L_0002: stfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0007: ret 
			*/
			
			
			{
				this.xdc87e2b99332cd4a = ((ISkinEngine) null);
			}
			
			private void x30b60dadc625bd97 ()
			
			/*
				// Code Size: 137 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: ldarg.0 
				L_0002: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0007: newobj Sunisoft.IrisSkin.SkinColors::Void .ctor(Sunisoft.IrisSkin.SkinEngine)
				L_000c: stfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors xa70c7ccd3278240f
				L_0011: ldarg.0 
				L_0012: ldarg.0 
				L_0013: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0018: newobj Sunisoft.IrisSkin.SkinBrushes::Void .ctor(Sunisoft.IrisSkin.SkinEngine)
				L_001d: stfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes x91bc7f70f8537c7c
				L_0022: ldarg.0 
				L_0023: ldarg.0 
				L_0024: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0029: newobj Sunisoft.IrisSkin.SkinInt::Void .ctor(Sunisoft.IrisSkin.SkinEngine)
				L_002e: stfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinInt x2491a4d79a7b1ed9
				L_0033: ldarg.0 
				L_0034: ldarg.0 
				L_0035: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_003a: newobj Sunisoft.IrisSkin.SkinBools::Void .ctor(Sunisoft.IrisSkin.SkinEngine)
				L_003f: stfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBools x78ac2e397a838680
				L_0044: ldarg.0 
				L_0045: ldarg.0 
				L_0046: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_004b: newobj Sunisoft.IrisSkin.SkinBitmaps::Void .ctor(Sunisoft.IrisSkin.SkinEngine)
				L_0050: stfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps xfcfb5c1949fe6b20
				L_0055: ldarg.0 
				L_0056: ldarg.0 
				L_0057: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_005c: newobj Sunisoft.IrisSkin.SplitBitmaps::Void .ctor(Sunisoft.IrisSkin.SkinEngine)
				L_0061: stfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SplitBitmaps x89e66747b11f0a70
				L_0066: ldarg.0 
				L_0067: ldarg.0 
				L_0068: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_006d: newobj Sunisoft.IrisSkin.ScrollBarRes::Void .ctor(Sunisoft.IrisSkin.SkinEngine)
				L_0072: stfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes xbf1147be56545845
				L_0077: ldarg.0 
				L_0078: ldarg.0 
				L_0079: ldfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_007e: newobj Sunisoft.IrisSkin.TabControlRes::Void .ctor(Sunisoft.IrisSkin.SkinEngine)
				L_0083: stfld Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.TabControlRes x3bf027fb2999c92f
				L_0088: ret 
			*/
			
			
			{
				this.xa70c7ccd3278240f = new SkinColors (this.xdc87e2b99332cd4a);
				this.x91bc7f70f8537c7c = new SkinBrushes (this.xdc87e2b99332cd4a);
				this.x2491a4d79a7b1ed9 = new SkinInt (this.xdc87e2b99332cd4a);
				this.x78ac2e397a838680 = new SkinBools (this.xdc87e2b99332cd4a);
				this.xfcfb5c1949fe6b20 = new SkinBitmaps (this.xdc87e2b99332cd4a);
				this.x89e66747b11f0a70 = new Sunisoft.IrisSkin.SplitBitmaps (this.xdc87e2b99332cd4a);
				this.xbf1147be56545845 = new Sunisoft.IrisSkin.ScrollBarRes (this.xdc87e2b99332cd4a);
				this.x3bf027fb2999c92f = new Sunisoft.IrisSkin.TabControlRes (this.xdc87e2b99332cd4a);
			}
			
		#endregion
	}
	
}

