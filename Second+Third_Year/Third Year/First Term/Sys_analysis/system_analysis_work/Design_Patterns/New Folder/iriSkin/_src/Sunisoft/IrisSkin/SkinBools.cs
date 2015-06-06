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
		
	public class SkinBools : ISkinBools, IDisposable
	
	{
		
		#region Fields
			public bool SKIN2_BOTTOMBORDERNEEDREGION;
			public bool SKIN2_BOTTOMBORDERTHREESECT;
			public bool SKIN2_TITLEBARNEEDREGION;
			public bool SKIN2_TITLEFIVESECT;
			private ISkinEngine xdc87e2b99332cd4a;
		#endregion
		
		#region Constructors
		
			public SkinBools (ISkinEngine engine)
			/*
				// Code Size: 20 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: stfld Sunisoft.IrisSkin.SkinBools::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_000d: ldarg.0 
				L_000e: call Sunisoft.IrisSkin.SkinBools::Void x225b462871340e0d()
				L_0013: ret 
			*/
		#endregion
		
		#region Generated Properties
		
			public bool SKIN2_BOTTOMBORDERNEEDREGION1
			
			{
				get
				
				{
					return this.SKIN2_BOTTOMBORDERNEEDREGION;
				}
				set
				
				{
					this.SKIN2_BOTTOMBORDERNEEDREGION = value;
				}
			}
			
			
			public bool SKIN2_BOTTOMBORDERTHREESECT1
			
			{
				get
				
				{
					return this.SKIN2_BOTTOMBORDERTHREESECT;
				}
				set
				
				{
					this.SKIN2_BOTTOMBORDERTHREESECT = value;
				}
			}
			
			
			public bool SKIN2_TITLEBARNEEDREGION1
			
			{
				get
				
				{
					return this.SKIN2_TITLEBARNEEDREGION;
				}
				set
				
				{
					this.SKIN2_TITLEBARNEEDREGION = value;
				}
			}
			
			
			public bool SKIN2_TITLEFIVESECT1
			
			{
				get
				
				{
					return this.SKIN2_TITLEFIVESECT;
				}
				set
				
				{
					this.SKIN2_TITLEFIVESECT = value;
				}
			}
			
		#endregion
		
		#region Original Properties
		
		#endregion
		
		#region Methods
		
			public virtual void Dispose ()
			
			/*
				// Code Size: 8 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.SkinBools::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0007: ret 
			*/
			
			
			{
				this.xdc87e2b99332cd4a = ((ISkinEngine) null);
			}
			
			private void x225b462871340e0d ()
			
			/*
				// Code Size: 89 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: ldarg.0 
				L_0002: ldfld Sunisoft.IrisSkin.SkinBools::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0007: ldstr "SKIN2_TITLEFIVESECT"
				L_000c: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean GetBool(System.String)
				L_0011: stfld Sunisoft.IrisSkin.SkinBools::Boolean SKIN2_TITLEFIVESECT
				L_0016: ldarg.0 
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.SkinBools::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_001d: ldstr "SKIN2_BOTTOMBORDERTHREESECT"
				L_0022: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean GetBool(System.String)
				L_0027: stfld Sunisoft.IrisSkin.SkinBools::Boolean SKIN2_BOTTOMBORDERTHREESECT
				L_002c: ldarg.0 
				L_002d: ldarg.0 
				L_002e: ldfld Sunisoft.IrisSkin.SkinBools::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0033: ldstr "SKIN2_TITLEBARNEEDREGION"
				L_0038: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean GetBool(System.String)
				L_003d: stfld Sunisoft.IrisSkin.SkinBools::Boolean SKIN2_TITLEBARNEEDREGION
				L_0042: ldarg.0 
				L_0043: ldarg.0 
				L_0044: ldfld Sunisoft.IrisSkin.SkinBools::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0049: ldstr "SKIN2_BOTTOMBORDERNEEDREGION"
				L_004e: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean GetBool(System.String)
				L_0053: stfld Sunisoft.IrisSkin.SkinBools::Boolean SKIN2_BOTTOMBORDERNEEDREGION
				L_0058: ret 
			*/
			
			
			{
				this.SKIN2_TITLEFIVESECT = ((SkinEngine) this.xdc87e2b99332cd4a).GetBool ("SKIN2_TITLEFIVESECT");
				this.SKIN2_BOTTOMBORDERTHREESECT = ((SkinEngine) this.xdc87e2b99332cd4a).GetBool ("SKIN2_BOTTOMBORDERTHREESECT");
				this.SKIN2_TITLEBARNEEDREGION = ((SkinEngine) this.xdc87e2b99332cd4a).GetBool ("SKIN2_TITLEBARNEEDREGION");
				this.SKIN2_BOTTOMBORDERNEEDREGION = ((SkinEngine) this.xdc87e2b99332cd4a).GetBool ("SKIN2_BOTTOMBORDERNEEDREGION");
			}
			
		#endregion
	}
	
}

