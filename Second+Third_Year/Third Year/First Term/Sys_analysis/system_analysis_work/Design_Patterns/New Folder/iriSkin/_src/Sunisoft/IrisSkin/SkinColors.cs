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
		
	public class SkinColors : ISkinColors, IDisposable
	
	{
		
		#region Fields
			public Color SKIN2_BUTTONFONTCOLOR;
			public Color SKIN2_CONTROLBORDERCOLOR;
			public Color SKIN2_CONTROLCOLOR;
			public Color SKIN2_CONTROLFONTCOLOR;
			public Color SKIN2_FORMCOLOR;
			public Color SKIN2_LEFTBARENDCOLOR;
			public Color SKIN2_LEFTBARSTARTCOLOR;
			public Color SKIN2_MENUBARENDCOLOR;
			public Color SKIN2_MENUBARSTARTCOLOR;
			public Color SKIN2_MENUITEMCOLOR;
			public Color SKIN2_MENUITEMFONTCOLOR;
			public Color SKIN2_SCROLLBARCOLOR;
			public Color SKIN2_SELECTEDMENUBORDERCOLOR;
			public Color SKIN2_SELECTEDMENUCOLOR;
			public Color SKIN2_SELECTEDMENUFONTCOLOR;
			public Color SKIN2_SIDECHANNELBORDERCOLOR;
			public Color SKIN2_SIDECHANNELCOLOR;
			public Color SKIN2_TABCONTROLACTIVEFONTCOLOR;
			public Color SKIN2_TABCONTROLBORDERCOLOR;
			public Color SKIN2_TABCONTROLCOLOR;
			public Color SKIN2_TABCONTROLINACTIVEFONTCOLOR;
			public Color SKIN2_TITLEFONTCOLOR;
			public Color SKIN2_TOOLBARBORDERCOLOR;
			public Color SKIN2_TOOLBARDOWNCOLOR;
			public Color SKIN2_TOOLBARENDCOLOR;
			public Color SKIN2_TOOLBARONCOLOR;
			public Color SKIN2_TOOLBARSTARTCOLOR;
			public Color SKIN2_TOPMENUFONTCOLOR;
			public Color SKIN2_TOPSELECTEDMENUBORDERCOLOR;
			public Color SKIN2_TOPSELECTEDMENUCOLOR;
			public Color SKIN2_TOPSELECTEDMENUFONTCOLOR;
			public Color SKIN2_TRANSCOLOR;
			private ISkinEngine xdc87e2b99332cd4a;
		#endregion
		
		#region Constructors
		
			public SkinColors (ISkinEngine engine)
			/*
				// Code Size: 20 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: stfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_000d: ldarg.0 
				L_000e: call Sunisoft.IrisSkin.SkinColors::Void xcfa0ea892200e949()
				L_0013: ret 
			*/
		#endregion
		
		#region Generated Properties
		
			public Color SKIN2_BUTTONFONTCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_BUTTONFONTCOLOR;
				}
				set
				
				{
					this.SKIN2_BUTTONFONTCOLOR = value;
				}
			}
			
			
			public Color SKIN2_CONTROLBORDERCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_CONTROLBORDERCOLOR;
				}
				set
				
				{
					this.SKIN2_CONTROLBORDERCOLOR = value;
				}
			}
			
			
			public Color SKIN2_CONTROLCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_CONTROLCOLOR;
				}
				set
				
				{
					this.SKIN2_CONTROLCOLOR = value;
				}
			}
			
			
			public Color SKIN2_CONTROLFONTCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_CONTROLFONTCOLOR;
				}
				set
				
				{
					this.SKIN2_CONTROLFONTCOLOR = value;
				}
			}
			
			
			public Color SKIN2_FORMCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_FORMCOLOR;
				}
				set
				
				{
					this.SKIN2_FORMCOLOR = value;
				}
			}
			
			
			public Color SKIN2_LEFTBARENDCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_LEFTBARENDCOLOR;
				}
				set
				
				{
					this.SKIN2_LEFTBARENDCOLOR = value;
				}
			}
			
			
			public Color SKIN2_LEFTBARSTARTCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_LEFTBARSTARTCOLOR;
				}
				set
				
				{
					this.SKIN2_LEFTBARSTARTCOLOR = value;
				}
			}
			
			
			public Color SKIN2_MENUBARENDCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_MENUBARENDCOLOR;
				}
				set
				
				{
					this.SKIN2_MENUBARENDCOLOR = value;
				}
			}
			
			
			public Color SKIN2_MENUBARSTARTCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_MENUBARSTARTCOLOR;
				}
				set
				
				{
					this.SKIN2_MENUBARSTARTCOLOR = value;
				}
			}
			
			
			public Color SKIN2_MENUITEMCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_MENUITEMCOLOR;
				}
				set
				
				{
					this.SKIN2_MENUITEMCOLOR = value;
				}
			}
			
			
			public Color SKIN2_MENUITEMFONTCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_MENUITEMFONTCOLOR;
				}
				set
				
				{
					this.SKIN2_MENUITEMFONTCOLOR = value;
				}
			}
			
			
			public Color SKIN2_SCROLLBARCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_SCROLLBARCOLOR;
				}
				set
				
				{
					this.SKIN2_SCROLLBARCOLOR = value;
				}
			}
			
			
			public Color SKIN2_SELECTEDMENUBORDERCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_SELECTEDMENUBORDERCOLOR;
				}
				set
				
				{
					this.SKIN2_SELECTEDMENUBORDERCOLOR = value;
				}
			}
			
			
			public Color SKIN2_SELECTEDMENUCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_SELECTEDMENUCOLOR;
				}
				set
				
				{
					this.SKIN2_SELECTEDMENUCOLOR = value;
				}
			}
			
			
			public Color SKIN2_SELECTEDMENUFONTCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_SELECTEDMENUFONTCOLOR;
				}
				set
				
				{
					this.SKIN2_SELECTEDMENUFONTCOLOR = value;
				}
			}
			
			
			public Color SKIN2_SIDECHANNELBORDERCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_SIDECHANNELBORDERCOLOR;
				}
				set
				
				{
					this.SKIN2_SIDECHANNELBORDERCOLOR = value;
				}
			}
			
			
			public Color SKIN2_SIDECHANNELCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_SIDECHANNELCOLOR;
				}
				set
				
				{
					this.SKIN2_SIDECHANNELCOLOR = value;
				}
			}
			
			
			public Color SKIN2_TABCONTROLACTIVEFONTCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_TABCONTROLACTIVEFONTCOLOR;
				}
				set
				
				{
					this.SKIN2_TABCONTROLACTIVEFONTCOLOR = value;
				}
			}
			
			
			public Color SKIN2_TABCONTROLBORDERCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_TABCONTROLBORDERCOLOR;
				}
				set
				
				{
					this.SKIN2_TABCONTROLBORDERCOLOR = value;
				}
			}
			
			
			public Color SKIN2_TABCONTROLCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_TABCONTROLCOLOR;
				}
				set
				
				{
					this.SKIN2_TABCONTROLCOLOR = value;
				}
			}
			
			
			public Color SKIN2_TABCONTROLINACTIVEFONTCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_TABCONTROLINACTIVEFONTCOLOR;
				}
				set
				
				{
					this.SKIN2_TABCONTROLINACTIVEFONTCOLOR = value;
				}
			}
			
			
			public Color SKIN2_TITLEFONTCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_TITLEFONTCOLOR;
				}
				set
				
				{
					this.SKIN2_TITLEFONTCOLOR = value;
				}
			}
			
			
			public Color SKIN2_TOOLBARBORDERCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_TOOLBARBORDERCOLOR;
				}
				set
				
				{
					this.SKIN2_TOOLBARBORDERCOLOR = value;
				}
			}
			
			
			public Color SKIN2_TOOLBARDOWNCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_TOOLBARDOWNCOLOR;
				}
				set
				
				{
					this.SKIN2_TOOLBARDOWNCOLOR = value;
				}
			}
			
			
			public Color SKIN2_TOOLBARENDCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_TOOLBARENDCOLOR;
				}
				set
				
				{
					this.SKIN2_TOOLBARENDCOLOR = value;
				}
			}
			
			
			public Color SKIN2_TOOLBARONCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_TOOLBARONCOLOR;
				}
				set
				
				{
					this.SKIN2_TOOLBARONCOLOR = value;
				}
			}
			
			
			public Color SKIN2_TOOLBARSTARTCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_TOOLBARSTARTCOLOR;
				}
				set
				
				{
					this.SKIN2_TOOLBARSTARTCOLOR = value;
				}
			}
			
			
			public Color SKIN2_TOPMENUFONTCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_TOPMENUFONTCOLOR;
				}
				set
				
				{
					this.SKIN2_TOPMENUFONTCOLOR = value;
				}
			}
			
			
			public Color SKIN2_TOPSELECTEDMENUBORDERCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_TOPSELECTEDMENUBORDERCOLOR;
				}
				set
				
				{
					this.SKIN2_TOPSELECTEDMENUBORDERCOLOR = value;
				}
			}
			
			
			public Color SKIN2_TOPSELECTEDMENUCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_TOPSELECTEDMENUCOLOR;
				}
				set
				
				{
					this.SKIN2_TOPSELECTEDMENUCOLOR = value;
				}
			}
			
			
			public Color SKIN2_TOPSELECTEDMENUFONTCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_TOPSELECTEDMENUFONTCOLOR;
				}
				set
				
				{
					this.SKIN2_TOPSELECTEDMENUFONTCOLOR = value;
				}
			}
			
			
			public Color SKIN2_TRANSCOLOR1
			
			{
				get
				
				{
					return this.SKIN2_TRANSCOLOR;
				}
				set
				
				{
					this.SKIN2_TRANSCOLOR = value;
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
				L_0002: stfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0007: ret 
			*/
			
			
			{
				this.xdc87e2b99332cd4a = ((ISkinEngine) null);
			}
			
			private void xcfa0ea892200e949 ()
			
			/*
				// Code Size: 705 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: ldarg.0 
				L_0002: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0007: ldstr "SKIN2_TRANSCOLOR"
				L_000c: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_0011: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TRANSCOLOR
				L_0016: ldarg.0 
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_001d: ldstr "SKIN2_TITLEFONTCOLOR"
				L_0022: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_0027: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TITLEFONTCOLOR
				L_002c: ldarg.0 
				L_002d: ldarg.0 
				L_002e: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0033: ldstr "SKIN2_FORMCOLOR"
				L_0038: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_003d: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_FORMCOLOR
				L_0042: ldarg.0 
				L_0043: ldarg.0 
				L_0044: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0049: ldstr "SKIN2_MENUBARSTARTCOLOR"
				L_004e: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_0053: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARSTARTCOLOR
				L_0058: ldarg.0 
				L_0059: ldarg.0 
				L_005a: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_005f: ldstr "SKIN2_MENUBARENDCOLOR"
				L_0064: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_0069: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARENDCOLOR
				L_006e: ldarg.0 
				L_006f: ldarg.0 
				L_0070: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0075: ldstr "SKIN2_TOPSELECTEDMENUCOLOR"
				L_007a: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_007f: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TOPSELECTEDMENUCOLOR
				L_0084: ldarg.0 
				L_0085: ldarg.0 
				L_0086: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_008b: ldstr "SKIN2_TOPSELECTEDMENUBORDERCOLOR"
				L_0090: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_0095: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TOPSELECTEDMENUBORDERCOLOR
				L_009a: ldarg.0 
				L_009b: ldarg.0 
				L_009c: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00a1: ldstr "SKIN2_TOPSELECTEDMENUFONTCOLOR"
				L_00a6: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_00ab: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TOPSELECTEDMENUFONTCOLOR
				L_00b0: ldarg.0 
				L_00b1: ldarg.0 
				L_00b2: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00b7: ldstr "SKIN2_TOPMENUFONTCOLOR"
				L_00bc: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_00c1: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TOPMENUFONTCOLOR
				L_00c6: ldarg.0 
				L_00c7: ldarg.0 
				L_00c8: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00cd: ldstr "SKIN2_LEFTBARSTARTCOLOR"
				L_00d2: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_00d7: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARSTARTCOLOR
				L_00dc: ldarg.0 
				L_00dd: ldarg.0 
				L_00de: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00e3: ldstr "SKIN2_LEFTBARENDCOLOR"
				L_00e8: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_00ed: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARENDCOLOR
				L_00f2: ldarg.0 
				L_00f3: ldarg.0 
				L_00f4: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_00f9: ldstr "SKIN2_MENUITEMCOLOR"
				L_00fe: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_0103: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUITEMCOLOR
				L_0108: ldarg.0 
				L_0109: ldarg.0 
				L_010a: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_010f: ldstr "SKIN2_MENUITEMFONTCOLOR"
				L_0114: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_0119: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUITEMFONTCOLOR
				L_011e: ldarg.0 
				L_011f: ldarg.0 
				L_0120: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0125: ldstr "SKIN2_SELECTEDMENUCOLOR"
				L_012a: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_012f: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_SELECTEDMENUCOLOR
				L_0134: ldarg.0 
				L_0135: ldarg.0 
				L_0136: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_013b: ldstr "SKIN2_SELECTEDMENUBORDERCOLOR"
				L_0140: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_0145: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_SELECTEDMENUBORDERCOLOR
				L_014a: ldarg.0 
				L_014b: ldarg.0 
				L_014c: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0151: ldstr "SKIN2_SELECTEDMENUFONTCOLOR"
				L_0156: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_015b: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_SELECTEDMENUFONTCOLOR
				L_0160: ldarg.0 
				L_0161: ldarg.0 
				L_0162: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0167: ldstr "SKIN2_TOOLBARSTARTCOLOR"
				L_016c: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_0171: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TOOLBARSTARTCOLOR
				L_0176: ldarg.0 
				L_0177: ldarg.0 
				L_0178: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_017d: ldstr "SKIN2_TOOLBARENDCOLOR"
				L_0182: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_0187: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TOOLBARENDCOLOR
				L_018c: ldarg.0 
				L_018d: ldarg.0 
				L_018e: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0193: ldstr "SKIN2_TOOLBARONCOLOR"
				L_0198: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_019d: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TOOLBARONCOLOR
				L_01a2: ldarg.0 
				L_01a3: ldarg.0 
				L_01a4: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01a9: ldstr "SKIN2_TOOLBARBORDERCOLOR"
				L_01ae: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_01b3: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TOOLBARBORDERCOLOR
				L_01b8: ldarg.0 
				L_01b9: ldarg.0 
				L_01ba: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01bf: ldstr "SKIN2_TOOLBARDOWNCOLOR"
				L_01c4: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_01c9: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TOOLBARDOWNCOLOR
				L_01ce: ldarg.0 
				L_01cf: ldarg.0 
				L_01d0: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01d5: ldstr "SKIN2_CONTROLCOLOR"
				L_01da: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_01df: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_CONTROLCOLOR
				L_01e4: ldarg.0 
				L_01e5: ldarg.0 
				L_01e6: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_01eb: ldstr "SKIN2_CONTROLBORDERCOLOR"
				L_01f0: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_01f5: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_CONTROLBORDERCOLOR
				L_01fa: ldarg.0 
				L_01fb: ldarg.0 
				L_01fc: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0201: ldstr "SKIN2_CONTROLFONTCOLOR"
				L_0206: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_020b: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_CONTROLFONTCOLOR
				L_0210: ldarg.0 
				L_0211: ldarg.0 
				L_0212: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0217: ldstr "SKIN2_BUTTONFONTCOLOR"
				L_021c: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_0221: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_BUTTONFONTCOLOR
				L_0226: ldarg.0 
				L_0227: ldarg.0 
				L_0228: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_022d: ldstr "SKIN2_SCROLLBARCOLOR"
				L_0232: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_0237: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_SCROLLBARCOLOR
				L_023c: ldarg.0 
				L_023d: ldarg.0 
				L_023e: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0243: ldstr "SKIN2_TABCONTROLCOLOR"
				L_0248: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_024d: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TABCONTROLCOLOR
				L_0252: ldarg.0 
				L_0253: ldarg.0 
				L_0254: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0259: ldstr "SKIN2_TABCONTROLBORDERCOLOR"
				L_025e: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_0263: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TABCONTROLBORDERCOLOR
				L_0268: ldarg.0 
				L_0269: ldarg.0 
				L_026a: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_026f: ldstr "SKIN2_TABCONTROLACTIVEFONTCOLOR"
				L_0274: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_0279: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TABCONTROLACTIVEFONTCOLOR
				L_027e: ldarg.0 
				L_027f: ldarg.0 
				L_0280: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_0285: ldstr "SKIN2_TABCONTROLINACTIVEFONTCOLOR"
				L_028a: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_028f: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TABCONTROLINACTIVEFONTCOLOR
				L_0294: ldarg.0 
				L_0295: ldarg.0 
				L_0296: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_029b: ldstr "SKIN2_SIDECHANNELCOLOR"
				L_02a0: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_02a5: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_SIDECHANNELCOLOR
				L_02aa: ldarg.0 
				L_02ab: ldarg.0 
				L_02ac: ldfld Sunisoft.IrisSkin.SkinColors::Sunisoft.IrisSkin.SkinEngine xdc87e2b99332cd4a
				L_02b1: ldstr "SKIN2_SIDECHANNELBORDERCOLOR"
				L_02b6: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Color GetColor(System.String)
				L_02bb: stfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_SIDECHANNELBORDERCOLOR
				L_02c0: ret 
			*/
			
			
			{
				this.SKIN2_TRANSCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_TRANSCOLOR");
				this.SKIN2_TITLEFONTCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_TITLEFONTCOLOR");
				this.SKIN2_FORMCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_FORMCOLOR");
				this.SKIN2_MENUBARSTARTCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_MENUBARSTARTCOLOR");
				this.SKIN2_MENUBARENDCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_MENUBARENDCOLOR");
				this.SKIN2_TOPSELECTEDMENUCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_TOPSELECTEDMENUCOLOR");
				this.SKIN2_TOPSELECTEDMENUBORDERCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_TOPSELECTEDMENUBORDERCOLOR");
				this.SKIN2_TOPSELECTEDMENUFONTCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_TOPSELECTEDMENUFONTCOLOR");
				this.SKIN2_TOPMENUFONTCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_TOPMENUFONTCOLOR");
				this.SKIN2_LEFTBARSTARTCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_LEFTBARSTARTCOLOR");
				this.SKIN2_LEFTBARENDCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_LEFTBARENDCOLOR");
				this.SKIN2_MENUITEMCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_MENUITEMCOLOR");
				this.SKIN2_MENUITEMFONTCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_MENUITEMFONTCOLOR");
				this.SKIN2_SELECTEDMENUCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_SELECTEDMENUCOLOR");
				this.SKIN2_SELECTEDMENUBORDERCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_SELECTEDMENUBORDERCOLOR");
				this.SKIN2_SELECTEDMENUFONTCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_SELECTEDMENUFONTCOLOR");
				this.SKIN2_TOOLBARSTARTCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_TOOLBARSTARTCOLOR");
				this.SKIN2_TOOLBARENDCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_TOOLBARENDCOLOR");
				this.SKIN2_TOOLBARONCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_TOOLBARONCOLOR");
				this.SKIN2_TOOLBARBORDERCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_TOOLBARBORDERCOLOR");
				this.SKIN2_TOOLBARDOWNCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_TOOLBARDOWNCOLOR");
				this.SKIN2_CONTROLCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_CONTROLCOLOR");
				this.SKIN2_CONTROLBORDERCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_CONTROLBORDERCOLOR");
				this.SKIN2_CONTROLFONTCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_CONTROLFONTCOLOR");
				this.SKIN2_BUTTONFONTCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_BUTTONFONTCOLOR");
				this.SKIN2_SCROLLBARCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_SCROLLBARCOLOR");
				this.SKIN2_TABCONTROLCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_TABCONTROLCOLOR");
				this.SKIN2_TABCONTROLBORDERCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_TABCONTROLBORDERCOLOR");
				this.SKIN2_TABCONTROLACTIVEFONTCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_TABCONTROLACTIVEFONTCOLOR");
				this.SKIN2_TABCONTROLINACTIVEFONTCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_TABCONTROLINACTIVEFONTCOLOR");
				this.SKIN2_SIDECHANNELCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_SIDECHANNELCOLOR");
				this.SKIN2_SIDECHANNELBORDERCOLOR = ((SkinEngine) this.xdc87e2b99332cd4a).GetColor ("SKIN2_SIDECHANNELBORDERCOLOR");
			}
			
		#endregion
	}
	
}

