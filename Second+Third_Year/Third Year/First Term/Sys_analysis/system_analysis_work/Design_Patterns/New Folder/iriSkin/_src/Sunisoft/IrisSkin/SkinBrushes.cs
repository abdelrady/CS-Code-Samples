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
		
	public class SkinBrushes : ISkinBrushes, IDisposable
	
	{
		
		#region Fields
			private Brush x0ec24abbe3f007a9;
			private Brush x108a88d72176d64b;
			private Brush x2779f044658139cf;
			private Brush x431a8d253ee9ae2a;
			private Brush x47041c294a00e44a;
			private Brush x47682f68a4d343ee;
			private Brush x47c13e104b215481;
			private Brush x4963cd732c460c47;
			private Brush x4b2009aeaa33b456;
			private Brush x57c5b42c96e49948;
			private Brush x672ff51407f239c4;
			private Brush x85d0de4604dd6c57;
			private Brush x8df357d9e62f18a8;
			private Brush x9c009b7699ca3174;
			private Brush x9d63ffb1750c94b5;
			private Brush xa46d28865dc8392f;
			private Brush xb472ac4091ced656;
			private Brush xb85f7d3d03e6b9f7;
			private Brush xcae9d0d91089a0cd;
			private Brush xd1eb12bc9f48cf50;
			private Brush xd2cdef6cd16abdcf;
			private Brush xd6e9f5be471516c0;
			private Brush xd85111f284357d6c;
			private Brush xdc3797dfae6a03cd;
			private ISkinEngine xdc87e2b99332cd4a;
			private Brush xddeb98bf338f58a1;
			private Brush xe0cbb219e9c48289;
			private Brush xe3b1a9eef7553028;
			private Brush xec890831d1a6b167;
			private Brush xedf6bedb1b0069d6;
			private Brush xf157508cf759d2b2;
			private Brush xf3c9ed5a444b1a25;
			private Brush xfa4239d59d055761;
		#endregion
		
		#region Constructors
		
			public SkinBrushes (ISkinEngine engine)
			/*
				// Code Size: 14 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: stfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_000d: ret 
			*/
		#endregion
		
		#region Properties
		
			public Brush SKIN2_BUTTONFONTCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x47c13e104b215481
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_BUTTONFONTCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x47c13e104b215481
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x47c13e104b215481
					L_0024: ret 
				*/
				
				{
					if (this.x47c13e104b215481 == null)
					{
						this.x47c13e104b215481 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_BUTTONFONTCOLOR");
					}
					return this.x47c13e104b215481;
				}
			}
			
			
			public Brush SKIN2_CONTROLBORDERCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xb472ac4091ced656
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_CONTROLBORDERCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xb472ac4091ced656
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xb472ac4091ced656
					L_0024: ret 
				*/
				
				{
					if (this.xb472ac4091ced656 == null)
					{
						this.xb472ac4091ced656 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_CONTROLBORDERCOLOR");
					}
					return this.xb472ac4091ced656;
				}
			}
			
			
			public Brush SKIN2_CONTROLCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x4963cd732c460c47
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_CONTROLCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x4963cd732c460c47
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x4963cd732c460c47
					L_0024: ret 
				*/
				
				{
					if (this.x4963cd732c460c47 == null)
					{
						this.x4963cd732c460c47 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_CONTROLCOLOR");
					}
					return this.x4963cd732c460c47;
				}
			}
			
			
			public Brush SKIN2_CONTROLFONTCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x4b2009aeaa33b456
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_CONTROLFONTCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x4b2009aeaa33b456
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x4b2009aeaa33b456
					L_0024: ret 
				*/
				
				{
					if (this.x4b2009aeaa33b456 == null)
					{
						this.x4b2009aeaa33b456 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_CONTROLFONTCOLOR");
					}
					return this.x4b2009aeaa33b456;
				}
			}
			
			
			public Brush SKIN2_FORMCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x672ff51407f239c4
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_FORMCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x672ff51407f239c4
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x672ff51407f239c4
					L_0024: ret 
				*/
				
				{
					if (this.x672ff51407f239c4 == null)
					{
						this.x672ff51407f239c4 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_FORMCOLOR");
					}
					return this.x672ff51407f239c4;
				}
			}
			
			
			public Brush SKIN2_LEFTBARENDCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x47041c294a00e44a
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_LEFTBARENDCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x47041c294a00e44a
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x47041c294a00e44a
					L_0024: ret 
				*/
				
				{
					if (this.x47041c294a00e44a == null)
					{
						this.x47041c294a00e44a = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_LEFTBARENDCOLOR");
					}
					return this.x47041c294a00e44a;
				}
			}
			
			
			public Brush SKIN2_LEFTBARSTARTCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xddeb98bf338f58a1
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_LEFTBARSTARTCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xddeb98bf338f58a1
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xddeb98bf338f58a1
					L_0024: ret 
				*/
				
				{
					if (this.xddeb98bf338f58a1 == null)
					{
						this.xddeb98bf338f58a1 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_LEFTBARSTARTCOLOR");
					}
					return this.xddeb98bf338f58a1;
				}
			}
			
			
			public Brush SKIN2_MENUBARENDCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xe3b1a9eef7553028
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_MENUBARENDCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xe3b1a9eef7553028
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xe3b1a9eef7553028
					L_0024: ret 
				*/
				
				{
					if (this.xe3b1a9eef7553028 == null)
					{
						this.xe3b1a9eef7553028 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_MENUBARENDCOLOR");
					}
					return this.xe3b1a9eef7553028;
				}
			}
			
			
			public Brush SKIN2_MENUBARSTARTCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x9d63ffb1750c94b5
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_MENUBARSTARTCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x9d63ffb1750c94b5
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x9d63ffb1750c94b5
					L_0024: ret 
				*/
				
				{
					if (this.x9d63ffb1750c94b5 == null)
					{
						this.x9d63ffb1750c94b5 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_MENUBARSTARTCOLOR");
					}
					return this.x9d63ffb1750c94b5;
				}
			}
			
			
			public Brush SKIN2_MENUITEMCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xd1eb12bc9f48cf50
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_MENUITEMCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xd1eb12bc9f48cf50
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xd1eb12bc9f48cf50
					L_0024: ret 
				*/
				
				{
					if (this.xd1eb12bc9f48cf50 == null)
					{
						this.xd1eb12bc9f48cf50 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_MENUITEMCOLOR");
					}
					return this.xd1eb12bc9f48cf50;
				}
			}
			
			
			public Brush SKIN2_MENUITEMFONTCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xdc3797dfae6a03cd
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_MENUITEMFONTCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xdc3797dfae6a03cd
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xdc3797dfae6a03cd
					L_0024: ret 
				*/
				
				{
					if (this.xdc3797dfae6a03cd == null)
					{
						this.xdc3797dfae6a03cd = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_MENUITEMFONTCOLOR");
					}
					return this.xdc3797dfae6a03cd;
				}
			}
			
			
			public Brush SKIN2_SCROLLBARCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x85d0de4604dd6c57
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_SCROLLBARCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x85d0de4604dd6c57
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x85d0de4604dd6c57
					L_0024: ret 
				*/
				
				{
					if (this.x85d0de4604dd6c57 == null)
					{
						this.x85d0de4604dd6c57 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_SCROLLBARCOLOR");
					}
					return this.x85d0de4604dd6c57;
				}
			}
			
			
			public Brush SKIN2_SELECTEDMENUBORDERCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xd6e9f5be471516c0
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_SELECTEDMENUBORDERCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xd6e9f5be471516c0
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xd6e9f5be471516c0
					L_0024: ret 
				*/
				
				{
					if (this.xd6e9f5be471516c0 == null)
					{
						this.xd6e9f5be471516c0 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_SELECTEDMENUBORDERCOLOR");
					}
					return this.xd6e9f5be471516c0;
				}
			}
			
			
			public Brush SKIN2_SELECTEDMENUCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xcae9d0d91089a0cd
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_SELECTEDMENUCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xcae9d0d91089a0cd
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xcae9d0d91089a0cd
					L_0024: ret 
				*/
				
				{
					if (this.xcae9d0d91089a0cd == null)
					{
						this.xcae9d0d91089a0cd = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_SELECTEDMENUCOLOR");
					}
					return this.xcae9d0d91089a0cd;
				}
			}
			
			
			public Brush SKIN2_SELECTEDMENUFONTCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x431a8d253ee9ae2a
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_SELECTEDMENUFONTCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x431a8d253ee9ae2a
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x431a8d253ee9ae2a
					L_0024: ret 
				*/
				
				{
					if (this.x431a8d253ee9ae2a == null)
					{
						this.x431a8d253ee9ae2a = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_SELECTEDMENUFONTCOLOR");
					}
					return this.x431a8d253ee9ae2a;
				}
			}
			
			
			public Brush SKIN2_SIDECHANNELBORDERCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xa46d28865dc8392f
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_SIDECHANNELBORDERCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xa46d28865dc8392f
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xa46d28865dc8392f
					L_0024: ret 
				*/
				
				{
					if (this.xa46d28865dc8392f == null)
					{
						this.xa46d28865dc8392f = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_SIDECHANNELBORDERCOLOR");
					}
					return this.xa46d28865dc8392f;
				}
			}
			
			
			public Brush SKIN2_SIDECHANNELCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xec890831d1a6b167
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_SIDECHANNELCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xec890831d1a6b167
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xec890831d1a6b167
					L_0024: ret 
				*/
				
				{
					if (this.xec890831d1a6b167 == null)
					{
						this.xec890831d1a6b167 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_SIDECHANNELCOLOR");
					}
					return this.xec890831d1a6b167;
				}
			}
			
			
			public Brush SKIN2_TABCONTROLACTIVEFONTCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x0ec24abbe3f007a9
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TABCONTROLACTIVEFONTCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x0ec24abbe3f007a9
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x0ec24abbe3f007a9
					L_0024: ret 
				*/
				
				{
					if (this.x0ec24abbe3f007a9 == null)
					{
						this.x0ec24abbe3f007a9 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TABCONTROLACTIVEFONTCOLOR");
					}
					return this.x0ec24abbe3f007a9;
				}
			}
			
			
			public Brush SKIN2_TABCONTROLBORDERCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xd85111f284357d6c
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TABCONTROLBORDERCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xd85111f284357d6c
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xd85111f284357d6c
					L_0024: ret 
				*/
				
				{
					if (this.xd85111f284357d6c == null)
					{
						this.xd85111f284357d6c = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TABCONTROLBORDERCOLOR");
					}
					return this.xd85111f284357d6c;
				}
			}
			
			
			public Brush SKIN2_TABCONTROLCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xb85f7d3d03e6b9f7
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TABCONTROLCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xb85f7d3d03e6b9f7
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xb85f7d3d03e6b9f7
					L_0024: ret 
				*/
				
				{
					if (this.xb85f7d3d03e6b9f7 == null)
					{
						this.xb85f7d3d03e6b9f7 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TABCONTROLCOLOR");
					}
					return this.xb85f7d3d03e6b9f7;
				}
			}
			
			
			public Brush SKIN2_TABCONTROLINACTIVEFONTCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xf157508cf759d2b2
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TABCONTROLINACTIVEFONTCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xf157508cf759d2b2
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xf157508cf759d2b2
					L_0024: ret 
				*/
				
				{
					if (this.xf157508cf759d2b2 == null)
					{
						this.xf157508cf759d2b2 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TABCONTROLINACTIVEFONTCOLOR");
					}
					return this.xf157508cf759d2b2;
				}
			}
			
			
			public Brush SKIN2_TITLEFONTCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x8df357d9e62f18a8
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TITLEFONTCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x8df357d9e62f18a8
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x8df357d9e62f18a8
					L_0024: ret 
				*/
				
				{
					if (this.x8df357d9e62f18a8 == null)
					{
						this.x8df357d9e62f18a8 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TITLEFONTCOLOR");
					}
					return this.x8df357d9e62f18a8;
				}
			}
			
			
			public Brush SKIN2_TOOLBARBORDERCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x57c5b42c96e49948
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TOOLBARBORDERCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x57c5b42c96e49948
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x57c5b42c96e49948
					L_0024: ret 
				*/
				
				{
					if (this.x57c5b42c96e49948 == null)
					{
						this.x57c5b42c96e49948 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TOOLBARBORDERCOLOR");
					}
					return this.x57c5b42c96e49948;
				}
			}
			
			
			public Brush SKIN2_TOOLBARDOWNCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xe0cbb219e9c48289
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TOOLBARDOWNCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xe0cbb219e9c48289
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xe0cbb219e9c48289
					L_0024: ret 
				*/
				
				{
					if (this.xe0cbb219e9c48289 == null)
					{
						this.xe0cbb219e9c48289 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TOOLBARDOWNCOLOR");
					}
					return this.xe0cbb219e9c48289;
				}
			}
			
			
			public Brush SKIN2_TOOLBARENDCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xf3c9ed5a444b1a25
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TOOLBARENDCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xf3c9ed5a444b1a25
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xf3c9ed5a444b1a25
					L_0024: ret 
				*/
				
				{
					if (this.xf3c9ed5a444b1a25 == null)
					{
						this.xf3c9ed5a444b1a25 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TOOLBARENDCOLOR");
					}
					return this.xf3c9ed5a444b1a25;
				}
			}
			
			
			public Brush SKIN2_TOOLBARONCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x9c009b7699ca3174
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TOOLBARONCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x9c009b7699ca3174
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x9c009b7699ca3174
					L_0024: ret 
				*/
				
				{
					if (this.x9c009b7699ca3174 == null)
					{
						this.x9c009b7699ca3174 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TOOLBARONCOLOR");
					}
					return this.x9c009b7699ca3174;
				}
			}
			
			
			public Brush SKIN2_TOOLBARSTARTCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xd2cdef6cd16abdcf
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TOOLBARSTARTCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xd2cdef6cd16abdcf
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xd2cdef6cd16abdcf
					L_0024: ret 
				*/
				
				{
					if (this.xd2cdef6cd16abdcf == null)
					{
						this.xd2cdef6cd16abdcf = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TOOLBARSTARTCOLOR");
					}
					return this.xd2cdef6cd16abdcf;
				}
			}
			
			
			public Brush SKIN2_TOPMENUFONTCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xfa4239d59d055761
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TOPMENUFONTCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xfa4239d59d055761
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xfa4239d59d055761
					L_0024: ret 
				*/
				
				{
					if (this.xfa4239d59d055761 == null)
					{
						this.xfa4239d59d055761 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TOPMENUFONTCOLOR");
					}
					return this.xfa4239d59d055761;
				}
			}
			
			
			public Brush SKIN2_TOPSELECTEDMENUBORDERCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x108a88d72176d64b
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TOPSELECTEDMENUBORDERCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x108a88d72176d64b
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x108a88d72176d64b
					L_0024: ret 
				*/
				
				{
					if (this.x108a88d72176d64b == null)
					{
						this.x108a88d72176d64b = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TOPSELECTEDMENUBORDERCOLOR");
					}
					return this.x108a88d72176d64b;
				}
			}
			
			
			public Brush SKIN2_TOPSELECTEDMENUCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x2779f044658139cf
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TOPSELECTEDMENUCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x2779f044658139cf
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x2779f044658139cf
					L_0024: ret 
				*/
				
				{
					if (this.x2779f044658139cf == null)
					{
						this.x2779f044658139cf = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TOPSELECTEDMENUCOLOR");
					}
					return this.x2779f044658139cf;
				}
			}
			
			
			public Brush SKIN2_TOPSELECTEDMENUFONTCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xedf6bedb1b0069d6
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TOPSELECTEDMENUFONTCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xedf6bedb1b0069d6
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush xedf6bedb1b0069d6
					L_0024: ret 
				*/
				
				{
					if (this.xedf6bedb1b0069d6 == null)
					{
						this.xedf6bedb1b0069d6 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TOPSELECTEDMENUFONTCOLOR");
					}
					return this.xedf6bedb1b0069d6;
				}
			}
			
			
			public Brush SKIN2_TRANSCOLOR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x47682f68a4d343ee
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBrushes::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TRANSCOLOR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Brush GetBrush(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x47682f68a4d343ee
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush x47682f68a4d343ee
					L_0024: ret 
				*/
				
				{
					if (this.x47682f68a4d343ee == null)
					{
						this.x47682f68a4d343ee = ((SkinEngine) this.xdc87e2b99332cd4a).GetBrush ("SKIN2_TRANSCOLOR");
					}
					return this.x47682f68a4d343ee;
				}
			}
			
		#endregion
		
		#region Methods
		
			public virtual void Dispose ()
			
			/*
				// Code Size: 11 Bytes
				.maxstack 9
				L_0000: ldstr "The method or operation is not implemented."
				L_0005: newobj System.Exception::Void .ctor(System.String)
				L_000a: throw 
			*/
			
			
			{
				throw new Exception ("The method or operation is not implemented.");
			}
			
		#endregion
	}
	
}

