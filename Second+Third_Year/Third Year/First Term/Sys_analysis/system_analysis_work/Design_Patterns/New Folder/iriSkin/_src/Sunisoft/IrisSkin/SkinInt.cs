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
		
	public class SkinInt : ISkinInt, IDisposable
	
	{
		
		#region Fields
			public int SKIN2_BOTTOMREGIONMAXY;
			public int SKIN2_BOTTOMREGIONMINY;
			public int SKIN2_TITLEBARBUTTONPOSX;
			public int SKIN2_TITLEBARBUTTONPOSY;
			public int SKIN2_TITLEBARCAPTIONTOP;
			public int SKIN2_TITLEBARICONPOSX;
			public int SKIN2_TITLEBARICONPOSY;
			public int SKIN2_TITLEBARREGIONMAXY;
			public int SKIN2_TITLEBARREGIONMINY;
			private ISkinEngine xdc87e2b99332cd4a;
		#endregion
		
		#region Constructors
		
			public SkinInt (ISkinEngine engine)
			/*
				// Code Size: 20 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: stfld Sunisoft.IrisSkin.SkinInt::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_000d: ldarg.0 
				L_000e: call Sunisoft.IrisSkin.SkinInt::Void xe098eb5fc84e11fd()
				L_0013: ret 
			*/
		#endregion
		
		#region Generated Properties
		
			public int SKIN2_BOTTOMREGIONMAXY1
			
			{
				get
				
				{
					return this.SKIN2_BOTTOMREGIONMAXY;
				}
				set
				
				{
					this.SKIN2_BOTTOMREGIONMAXY = value;
				}
			}
			
			
			public int SKIN2_BOTTOMREGIONMINY1
			
			{
				get
				
				{
					return this.SKIN2_BOTTOMREGIONMINY;
				}
				set
				
				{
					this.SKIN2_BOTTOMREGIONMINY = value;
				}
			}
			
			
			public int SKIN2_TITLEBARBUTTONPOSX1
			
			{
				get
				
				{
					return this.SKIN2_TITLEBARBUTTONPOSX;
				}
				set
				
				{
					this.SKIN2_TITLEBARBUTTONPOSX = value;
				}
			}
			
			
			public int SKIN2_TITLEBARBUTTONPOSY1
			
			{
				get
				
				{
					return this.SKIN2_TITLEBARBUTTONPOSY;
				}
				set
				
				{
					this.SKIN2_TITLEBARBUTTONPOSY = value;
				}
			}
			
			
			public int SKIN2_TITLEBARCAPTIONTOP1
			
			{
				get
				
				{
					return this.SKIN2_TITLEBARCAPTIONTOP;
				}
				set
				
				{
					this.SKIN2_TITLEBARCAPTIONTOP = value;
				}
			}
			
			
			public int SKIN2_TITLEBARICONPOSX1
			
			{
				get
				
				{
					return this.SKIN2_TITLEBARICONPOSX;
				}
				set
				
				{
					this.SKIN2_TITLEBARICONPOSX = value;
				}
			}
			
			
			public int SKIN2_TITLEBARICONPOSY1
			
			{
				get
				
				{
					return this.SKIN2_TITLEBARICONPOSY;
				}
				set
				
				{
					this.SKIN2_TITLEBARICONPOSY = value;
				}
			}
			
			
			public int SKIN2_TITLEBARREGIONMAXY1
			
			{
				get
				
				{
					return this.SKIN2_TITLEBARREGIONMAXY;
				}
				set
				
				{
					this.SKIN2_TITLEBARREGIONMAXY = value;
				}
			}
			
			
			public int SKIN2_TITLEBARREGIONMINY1
			
			{
				get
				
				{
					return this.SKIN2_TITLEBARREGIONMINY;
				}
				set
				
				{
					this.SKIN2_TITLEBARREGIONMINY = value;
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
				L_0002: stfld Sunisoft.IrisSkin.SkinInt::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0007: ret 
			*/
			
			
			{
				this.xdc87e2b99332cd4a = ((ISkinEngine) null);
			}
			
			private void xe098eb5fc84e11fd ()
			
			/*
				// Code Size: 199 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: ldarg.0 
				L_0002: ldfld Sunisoft.IrisSkin.SkinInt::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0007: ldstr "SKIN2_TITLEBARICONPOSX"
				L_000c: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 GetInt(System.String)
				L_0011: stfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_TITLEBARICONPOSX
				L_0016: ldarg.0 
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.SkinInt::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_001d: ldstr "SKIN2_TITLEBARICONPOSY"
				L_0022: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 GetInt(System.String)
				L_0027: stfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_TITLEBARICONPOSY
				L_002c: ldarg.0 
				L_002d: ldarg.0 
				L_002e: ldfld Sunisoft.IrisSkin.SkinInt::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0033: ldstr "SKIN2_TITLEBARCAPTIONTOP"
				L_0038: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 GetInt(System.String)
				L_003d: stfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_TITLEBARCAPTIONTOP
				L_0042: ldarg.0 
				L_0043: ldarg.0 
				L_0044: ldfld Sunisoft.IrisSkin.SkinInt::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0049: ldstr "SKIN2_TITLEBARBUTTONPOSX"
				L_004e: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 GetInt(System.String)
				L_0053: stfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_TITLEBARBUTTONPOSX
				L_0058: ldarg.0 
				L_0059: ldarg.0 
				L_005a: ldfld Sunisoft.IrisSkin.SkinInt::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_005f: ldstr "SKIN2_TITLEBARBUTTONPOSY"
				L_0064: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 GetInt(System.String)
				L_0069: stfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_TITLEBARBUTTONPOSY
				L_006e: ldarg.0 
				L_006f: ldarg.0 
				L_0070: ldfld Sunisoft.IrisSkin.SkinInt::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0075: ldstr "SKIN2_TITLEBARREGIONMINY"
				L_007a: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 GetInt(System.String)
				L_007f: stfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_TITLEBARREGIONMINY
				L_0084: ldarg.0 
				L_0085: ldarg.0 
				L_0086: ldfld Sunisoft.IrisSkin.SkinInt::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_008b: ldstr "SKIN2_TITLEBARREGIONMAXY"
				L_0090: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 GetInt(System.String)
				L_0095: stfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_TITLEBARREGIONMAXY
				L_009a: ldarg.0 
				L_009b: ldarg.0 
				L_009c: ldfld Sunisoft.IrisSkin.SkinInt::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00a1: ldstr "SKIN2_BOTTOMREGIONMINY"
				L_00a6: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 GetInt(System.String)
				L_00ab: stfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_BOTTOMREGIONMINY
				L_00b0: ldarg.0 
				L_00b1: ldarg.0 
				L_00b2: ldfld Sunisoft.IrisSkin.SkinInt::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00b7: ldstr "SKIN2_BOTTOMREGIONMAXY"
				L_00bc: callvirt Sunisoft.IrisSkin.SkinEngine::Int32 GetInt(System.String)
				L_00c1: stfld Sunisoft.IrisSkin.SkinInt::Int32 SKIN2_BOTTOMREGIONMAXY
				L_00c6: ret 
			*/
			
			
			{
				this.SKIN2_TITLEBARICONPOSX = ((SkinEngine) this.xdc87e2b99332cd4a).GetInt ("SKIN2_TITLEBARICONPOSX");
				this.SKIN2_TITLEBARICONPOSY = ((SkinEngine) this.xdc87e2b99332cd4a).GetInt ("SKIN2_TITLEBARICONPOSY");
				this.SKIN2_TITLEBARCAPTIONTOP = ((SkinEngine) this.xdc87e2b99332cd4a).GetInt ("SKIN2_TITLEBARCAPTIONTOP");
				this.SKIN2_TITLEBARBUTTONPOSX = ((SkinEngine) this.xdc87e2b99332cd4a).GetInt ("SKIN2_TITLEBARBUTTONPOSX");
				this.SKIN2_TITLEBARBUTTONPOSY = ((SkinEngine) this.xdc87e2b99332cd4a).GetInt ("SKIN2_TITLEBARBUTTONPOSY");
				this.SKIN2_TITLEBARREGIONMINY = ((SkinEngine) this.xdc87e2b99332cd4a).GetInt ("SKIN2_TITLEBARREGIONMINY");
				this.SKIN2_TITLEBARREGIONMAXY = ((SkinEngine) this.xdc87e2b99332cd4a).GetInt ("SKIN2_TITLEBARREGIONMAXY");
				this.SKIN2_BOTTOMREGIONMINY = ((SkinEngine) this.xdc87e2b99332cd4a).GetInt ("SKIN2_BOTTOMREGIONMINY");
				this.SKIN2_BOTTOMREGIONMAXY = ((SkinEngine) this.xdc87e2b99332cd4a).GetInt ("SKIN2_BOTTOMREGIONMAXY");
			}
			
		#endregion
	}
	
}

