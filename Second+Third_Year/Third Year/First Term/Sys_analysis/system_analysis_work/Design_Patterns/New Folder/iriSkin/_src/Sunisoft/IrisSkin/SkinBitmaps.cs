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
		
	public class SkinBitmaps : ISkinBitmaps, IDisposable
	
	{
		
		#region Fields
			private Bitmap x048862aee2fbb7b6;
			private Bitmap x079230832986b773;
			private Bitmap x0f026a1d86e2cfd4;
			private Bitmap x114f6663353c562b;
			private Bitmap x1c886665a6136e76;
			private Bitmap x24802ac43d9b7af5;
			private Bitmap x3c2a21d8d15d9bb1;
			private Bitmap x3d2e024a784598d5;
			private Bitmap x4021106c9f5f9916;
			private Bitmap x421416c7bdb1c8c0;
			private Bitmap x4944f3253ed604fe;
			private Bitmap x4d29203e30529d37;
			private Bitmap x4fa1c7e9a378ce7d;
			private Bitmap x4fb141915a72323d;
			private Bitmap x53cf9ae365fc6750;
			private Bitmap x5b254bbb9048a52a;
			private Bitmap x5c533cd8e6e5c871;
			private Bitmap x625a780534399c56;
			private Bitmap x6b5200b8cb0badbb;
			private Bitmap x73408b9bae28f1c0;
			private Bitmap x842bba7c67d596f0;
			private Bitmap x842f8dce891d0e49;
			private Bitmap x8ca5df93d87e7601;
			private Bitmap x8d596e2df0e45028;
			private Bitmap x8e6b08364c633852;
			private Bitmap x95993ff743c4d716;
			private Bitmap x9c3e20a6f8d01e7a;
			private Bitmap xaca54acdfac1b158;
			private Bitmap xb593b0b67850f120;
			private Bitmap xd17a79780ea48cc0;
			private ISkinEngine xdc87e2b99332cd4a;
			private Bitmap xdfda3855394bd512;
			private Bitmap xe317167b65b20e4f;
			private Bitmap xeb68386b8c78c07a;
			private Bitmap xf15b36cdcfff527e;
			private Bitmap xf33008181c845518;
		#endregion
		
		#region Constructors
		
			public SkinBitmaps (ISkinEngine engine)
			/*
				// Code Size: 14 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: stfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_000d: ret 
			*/
		#endregion
		
		#region Properties
		
			public Bitmap SKIN2_BUTTON
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x3d2e024a784598d5
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_BUTTON"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x3d2e024a784598d5
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x3d2e024a784598d5
					L_0024: ret 
				*/
				
				{
					if (this.x3d2e024a784598d5 == null)
					{
						this.x3d2e024a784598d5 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_BUTTON");
					}
					return this.x3d2e024a784598d5;
				}
			}
			
			
			public Bitmap SKIN2_CHECKBOX
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x842bba7c67d596f0
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_CHECKBOX"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x842bba7c67d596f0
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x842bba7c67d596f0
					L_0024: ret 
				*/
				
				{
					if (this.x842bba7c67d596f0 == null)
					{
						this.x842bba7c67d596f0 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_CHECKBOX");
					}
					return this.x842bba7c67d596f0;
				}
			}
			
			
			public Bitmap SKIN2_CHECKBOXLIST
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x4d29203e30529d37
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_CHECKBOXLIST"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x4d29203e30529d37
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x4d29203e30529d37
					L_0024: ret 
				*/
				
				{
					if (this.x4d29203e30529d37 == null)
					{
						this.x4d29203e30529d37 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_CHECKBOXLIST");
					}
					return this.x4d29203e30529d37;
				}
			}
			
			
			public Bitmap SKIN2_CHECKEDMENUICON
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xdfda3855394bd512
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_CHECKEDMENUICON"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xdfda3855394bd512
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xdfda3855394bd512
					L_0024: ret 
				*/
				
				{
					if (this.xdfda3855394bd512 == null)
					{
						this.xdfda3855394bd512 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_CHECKEDMENUICON");
					}
					return this.xdfda3855394bd512;
				}
			}
			
			
			public Bitmap SKIN2_FORMBOTTOMBORDER1
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x5b254bbb9048a52a
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_FORMBOTTOMBORDER1"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x5b254bbb9048a52a
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x5b254bbb9048a52a
					L_0024: ret 
				*/
				
				{
					if (this.x5b254bbb9048a52a == null)
					{
						this.x5b254bbb9048a52a = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_FORMBOTTOMBORDER1");
					}
					return this.x5b254bbb9048a52a;
				}
			}
			
			
			public Bitmap SKIN2_FORMBOTTOMBORDER2
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x4021106c9f5f9916
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_FORMBOTTOMBORDER2"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x4021106c9f5f9916
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x4021106c9f5f9916
					L_0024: ret 
				*/
				
				{
					if (this.x4021106c9f5f9916 == null)
					{
						this.x4021106c9f5f9916 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_FORMBOTTOMBORDER2");
					}
					return this.x4021106c9f5f9916;
				}
			}
			
			
			public Bitmap SKIN2_FORMBOTTOMBORDER3
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x73408b9bae28f1c0
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_FORMBOTTOMBORDER3"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x73408b9bae28f1c0
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x73408b9bae28f1c0
					L_0024: ret 
				*/
				
				{
					if (this.x73408b9bae28f1c0 == null)
					{
						this.x73408b9bae28f1c0 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_FORMBOTTOMBORDER3");
					}
					return this.x73408b9bae28f1c0;
				}
			}
			
			
			public Bitmap SKIN2_FORMLEFTBORDER
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x5c533cd8e6e5c871
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_FORMLEFTBORDER"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x5c533cd8e6e5c871
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x5c533cd8e6e5c871
					L_0024: ret 
				*/
				
				{
					if (this.x5c533cd8e6e5c871 == null)
					{
						this.x5c533cd8e6e5c871 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_FORMLEFTBORDER");
					}
					return this.x5c533cd8e6e5c871;
				}
			}
			
			
			public Bitmap SKIN2_FORMRIGHTBORDER
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x0f026a1d86e2cfd4
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_FORMRIGHTBORDER"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x0f026a1d86e2cfd4
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x0f026a1d86e2cfd4
					L_0024: ret 
				*/
				
				{
					if (this.x0f026a1d86e2cfd4 == null)
					{
						this.x0f026a1d86e2cfd4 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_FORMRIGHTBORDER");
					}
					return this.x0f026a1d86e2cfd4;
				}
			}
			
			
			public Bitmap SKIN2_MENUBAR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xaca54acdfac1b158
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_MENUBAR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xaca54acdfac1b158
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xaca54acdfac1b158
					L_0024: ret 
				*/
				
				{
					if (this.xaca54acdfac1b158 == null)
					{
						this.xaca54acdfac1b158 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_MENUBAR");
					}
					return this.xaca54acdfac1b158;
				}
			}
			
			
			public Bitmap SKIN2_MINIMIZEDTITLE
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x079230832986b773
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_MINIMIZEDTITLE"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x079230832986b773
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x079230832986b773
					L_0024: ret 
				*/
				
				{
					if (this.x079230832986b773 == null)
					{
						this.x079230832986b773 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_MINIMIZEDTITLE");
					}
					return this.x079230832986b773;
				}
			}
			
			
			public Bitmap SKIN2_PROGRESSBAR1
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x4fa1c7e9a378ce7d
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_PROGRESSBAR1"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x4fa1c7e9a378ce7d
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x4fa1c7e9a378ce7d
					L_0024: ret 
				*/
				
				{
					if (this.x4fa1c7e9a378ce7d == null)
					{
						this.x4fa1c7e9a378ce7d = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_PROGRESSBAR1");
					}
					return this.x4fa1c7e9a378ce7d;
				}
			}
			
			
			public Bitmap SKIN2_PROGRESSBAR2
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x95993ff743c4d716
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_PROGRESSBAR2"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x95993ff743c4d716
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x95993ff743c4d716
					L_0024: ret 
				*/
				
				{
					if (this.x95993ff743c4d716 == null)
					{
						this.x95993ff743c4d716 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_PROGRESSBAR2");
					}
					return this.x95993ff743c4d716;
				}
			}
			
			
			public Bitmap SKIN2_PROGRESSBAR3
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x4fb141915a72323d
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_PROGRESSBAR3"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x4fb141915a72323d
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x4fb141915a72323d
					L_0024: ret 
				*/
				
				{
					if (this.x4fb141915a72323d == null)
					{
						this.x4fb141915a72323d = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_PROGRESSBAR3");
					}
					return this.x4fb141915a72323d;
				}
			}
			
			
			public Bitmap SKIN2_PROGRESSBAR4
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x8ca5df93d87e7601
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_PROGRESSBAR4"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x8ca5df93d87e7601
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x8ca5df93d87e7601
					L_0024: ret 
				*/
				
				{
					if (this.x8ca5df93d87e7601 == null)
					{
						this.x8ca5df93d87e7601 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_PROGRESSBAR4");
					}
					return this.x8ca5df93d87e7601;
				}
			}
			
			
			public Bitmap SKIN2_RADIOBUTTON
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x4944f3253ed604fe
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_RADIOBUTTON"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x4944f3253ed604fe
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x4944f3253ed604fe
					L_0024: ret 
				*/
				
				{
					if (this.x4944f3253ed604fe == null)
					{
						this.x4944f3253ed604fe = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_RADIOBUTTON");
					}
					return this.x4944f3253ed604fe;
				}
			}
			
			
			public Bitmap SKIN2_SCROLLBAR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xe317167b65b20e4f
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_SCROLLBAR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xe317167b65b20e4f
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xe317167b65b20e4f
					L_0024: ret 
				*/
				
				{
					if (this.xe317167b65b20e4f == null)
					{
						this.xe317167b65b20e4f = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_SCROLLBAR");
					}
					return this.xe317167b65b20e4f;
				}
			}
			
			
			public Bitmap SKIN2_SCROLLBARDOWNBUTTON
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x9c3e20a6f8d01e7a
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_SCROLLBARDOWNBUTTON"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x9c3e20a6f8d01e7a
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x9c3e20a6f8d01e7a
					L_0024: ret 
				*/
				
				{
					if (this.x9c3e20a6f8d01e7a == null)
					{
						this.x9c3e20a6f8d01e7a = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_SCROLLBARDOWNBUTTON");
					}
					return this.x9c3e20a6f8d01e7a;
				}
			}
			
			
			public Bitmap SKIN2_SCROLLBARUPBUTTON
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xf15b36cdcfff527e
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_SCROLLBARUPBUTTON"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xf15b36cdcfff527e
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xf15b36cdcfff527e
					L_0024: ret 
				*/
				
				{
					if (this.xf15b36cdcfff527e == null)
					{
						this.xf15b36cdcfff527e = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_SCROLLBARUPBUTTON");
					}
					return this.xf15b36cdcfff527e;
				}
			}
			
			
			public Bitmap SKIN2_SCROLLBUTTON
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x53cf9ae365fc6750
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_SCROLLBUTTON"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x53cf9ae365fc6750
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x53cf9ae365fc6750
					L_0024: ret 
				*/
				
				{
					if (this.x53cf9ae365fc6750 == null)
					{
						this.x53cf9ae365fc6750 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_SCROLLBUTTON");
					}
					return this.x53cf9ae365fc6750;
				}
			}
			
			
			public Bitmap SKIN2_SIDECHANNELBAR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x625a780534399c56
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_SIDECHANNELBAR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x625a780534399c56
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x625a780534399c56
					L_0024: ret 
				*/
				
				{
					if (this.x625a780534399c56 == null)
					{
						this.x625a780534399c56 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_SIDECHANNELBAR");
					}
					return this.x625a780534399c56;
				}
			}
			
			
			public Bitmap SKIN2_SIDECHANNELTITLE
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xf33008181c845518
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_SIDECHANNELTITLE"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xf33008181c845518
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xf33008181c845518
					L_0024: ret 
				*/
				
				{
					if (this.xf33008181c845518 == null)
					{
						this.xf33008181c845518 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_SIDECHANNELTITLE");
					}
					return this.xf33008181c845518;
				}
			}
			
			
			public Bitmap SKIN2_TABCONTROL
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x048862aee2fbb7b6
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TABCONTROL"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x048862aee2fbb7b6
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x048862aee2fbb7b6
					L_0024: ret 
				*/
				
				{
					if (this.x048862aee2fbb7b6 == null)
					{
						this.x048862aee2fbb7b6 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TABCONTROL");
					}
					return this.x048862aee2fbb7b6;
				}
			}
			
			
			public Bitmap SKIN2_TABCONTROLLINE
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x24802ac43d9b7af5
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TABCONTROLLINE"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x24802ac43d9b7af5
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x24802ac43d9b7af5
					L_0024: ret 
				*/
				
				{
					if (this.x24802ac43d9b7af5 == null)
					{
						this.x24802ac43d9b7af5 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TABCONTROLLINE");
					}
					return this.x24802ac43d9b7af5;
				}
			}
			
			
			public Bitmap SKIN2_TITLEBAR1
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x3c2a21d8d15d9bb1
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TITLEBAR1"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x3c2a21d8d15d9bb1
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x3c2a21d8d15d9bb1
					L_0024: ret 
				*/
				
				{
					if (this.x3c2a21d8d15d9bb1 == null)
					{
						this.x3c2a21d8d15d9bb1 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TITLEBAR1");
					}
					return this.x3c2a21d8d15d9bb1;
				}
			}
			
			
			public Bitmap SKIN2_TITLEBAR2
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x6b5200b8cb0badbb
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TITLEBAR2"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x6b5200b8cb0badbb
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x6b5200b8cb0badbb
					L_0024: ret 
				*/
				
				{
					if (this.x6b5200b8cb0badbb == null)
					{
						this.x6b5200b8cb0badbb = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TITLEBAR2");
					}
					return this.x6b5200b8cb0badbb;
				}
			}
			
			
			public Bitmap SKIN2_TITLEBAR3
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x114f6663353c562b
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TITLEBAR3"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x114f6663353c562b
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x114f6663353c562b
					L_0024: ret 
				*/
				
				{
					if (this.x114f6663353c562b == null)
					{
						this.x114f6663353c562b = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TITLEBAR3");
					}
					return this.x114f6663353c562b;
				}
			}
			
			
			public Bitmap SKIN2_TITLEBAR4
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xb593b0b67850f120
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TITLEBAR4"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xb593b0b67850f120
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xb593b0b67850f120
					L_0024: ret 
				*/
				
				{
					if (this.xb593b0b67850f120 == null)
					{
						this.xb593b0b67850f120 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TITLEBAR4");
					}
					return this.xb593b0b67850f120;
				}
			}
			
			
			public Bitmap SKIN2_TITLEBAR5
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x421416c7bdb1c8c0
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TITLEBAR5"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x421416c7bdb1c8c0
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x421416c7bdb1c8c0
					L_0024: ret 
				*/
				
				{
					if (this.x421416c7bdb1c8c0 == null)
					{
						this.x421416c7bdb1c8c0 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TITLEBAR5");
					}
					return this.x421416c7bdb1c8c0;
				}
			}
			
			
			public Bitmap SKIN2_TITLEBUTTONS
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x842f8dce891d0e49
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TITLEBUTTONS"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x842f8dce891d0e49
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x842f8dce891d0e49
					L_0024: ret 
				*/
				
				{
					if (this.x842f8dce891d0e49 == null)
					{
						this.x842f8dce891d0e49 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TITLEBUTTONS");
					}
					return this.x842f8dce891d0e49;
				}
			}
			
			
			public Bitmap SKIN2_TOOLBAR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xd17a79780ea48cc0
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TOOLBAR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xd17a79780ea48cc0
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xd17a79780ea48cc0
					L_0024: ret 
				*/
				
				{
					if (this.xd17a79780ea48cc0 == null)
					{
						this.xd17a79780ea48cc0 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TOOLBAR");
					}
					return this.xd17a79780ea48cc0;
				}
			}
			
			
			public Bitmap SKIN2_TRACKBAR
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x8e6b08364c633852
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TRACKBAR"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x8e6b08364c633852
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x8e6b08364c633852
					L_0024: ret 
				*/
				
				{
					if (this.x8e6b08364c633852 == null)
					{
						this.x8e6b08364c633852 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TRACKBAR");
					}
					return this.x8e6b08364c633852;
				}
			}
			
			
			public Bitmap SKIN2_TRACKBARSLIDER
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xeb68386b8c78c07a
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TRACKBARSLIDER"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xeb68386b8c78c07a
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap xeb68386b8c78c07a
					L_0024: ret 
				*/
				
				{
					if (this.xeb68386b8c78c07a == null)
					{
						this.xeb68386b8c78c07a = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TRACKBARSLIDER");
					}
					return this.xeb68386b8c78c07a;
				}
			}
			
			
			public Bitmap SKIN2_TRACKBARSLIDER_180
			
			{
				get
				
				/*
					// Code Size: 57 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x8d596e2df0e45028
					L_0006: brtrue.s L_0032
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TRACKBARSLIDER"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x8d596e2df0e45028
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x8d596e2df0e45028
					L_0024: brfalse.s L_0032
					L_0026: ldarg.0 
					L_0027: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x8d596e2df0e45028
					L_002c: ldc.i4.2 
					L_002d: callvirt System.Drawing.Image::Void RotateFlip(System.Drawing.RotateFlipType)
					L_0032: ldarg.0 
					L_0033: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x8d596e2df0e45028
					L_0038: ret 
				*/
				
				{
					if (this.x8d596e2df0e45028 == null)
					{
						this.x8d596e2df0e45028 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TRACKBARSLIDER");
						if (this.x8d596e2df0e45028 != null)
						{
							this.x8d596e2df0e45028.RotateFlip (RotateFlipType.Rotate180FlipNone);
						}
					}
					return this.x8d596e2df0e45028;
				}
			}
			
			
			public Bitmap SKIN2_TRACKBARVSLIDER
			
			{
				get
				
				/*
					// Code Size: 37 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x1c886665a6136e76
					L_0006: brtrue.s L_001e
					L_0008: ldarg.0 
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
					L_000f: ldstr "SKIN2_TRACKBARVSLIDER"
					L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Bitmap GetBitmap(System.String)
					L_0019: stfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x1c886665a6136e76
					L_001e: ldarg.0 
					L_001f: ldfld Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap x1c886665a6136e76
					L_0024: ret 
				*/
				
				{
					if (this.x1c886665a6136e76 == null)
					{
						this.x1c886665a6136e76 = ((SkinEngine) this.xdc87e2b99332cd4a).GetBitmap ("SKIN2_TRACKBARVSLIDER");
					}
					return this.x1c886665a6136e76;
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
				L_0002: stfld Sunisoft.IrisSkin.SkinBitmaps::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0007: ret 
			*/
			
			
			{
				this.xdc87e2b99332cd4a = ((ISkinEngine) null);
			}
			
		#endregion
	}
	
}

