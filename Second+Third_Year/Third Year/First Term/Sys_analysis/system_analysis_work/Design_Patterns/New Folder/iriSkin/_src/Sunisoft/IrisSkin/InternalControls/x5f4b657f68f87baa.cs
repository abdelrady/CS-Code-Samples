//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin.InternalControls

{
		
		#region Namespace Import Declarations
		
			using System.ComponentModel;
			using System.Drawing;
			using System;
			using System.Windows.Forms;
			
			
		#endregion
		
	[ToolboxItemAttribute(false)]
	internal class x5f4b657f68f87baa : Component
	
	{
		
		#region Fields
			protected bool x0933636ccb6c95f5;
			private x5282b9c42ea1abce x0ad6cb77c00e4e89;
			protected bool x116b6a58ff0ad788;
			private x26569a56dfbc2c6d x1b233dbc8c05d73f;
			private EventHandler x295cb4a1df7a5add;
			protected bool x2fef7d841879a711;
			protected bool x364c1e3b189d47fe;
			private x26569a56dfbc2c6d x3b2905fe94e52614;
			private bool x49b363db01752634;
			private MenuItem x569ad91f8a39fe51;
			protected bool x5cd949e9f24593b6;
			protected ImageList x6ec0d1228599f9ae;
			private EventHandler x98992f4120a73bb9;
			protected xd53b20b7b4b2a08a xa73e17ae29927ab0;
			internal bool xb2504b89d66feca9;
			protected string xb41faee6912a2313;
			internal Form xb7d28b7a6d50662f;
			protected Shortcut xc0de55fd2ca182a4;
			protected string xc2358fbac7da3d45;
			protected int xc931041ff8b5600b;
			protected Image xe058541ca798c059;
			protected bool xf3a4c29d9fe0ddc7;
			protected object xffe521cc76054baf;
		#endregion
		
		#region Nested Types
		
			internal delegate void x5282b9c42ea1abce (x5f4b657f68f87baa item, x5f4b657f68f87baa.x879a106b0501b9dc prop);
			
			internal enum x879a106b0501b9dc
			
			{
				xf9ad6fb78355fe13 = 0, 
				x9f2c0dc847992f03 = 1, 
				xaa7785f730d8dd15 = 2, 
				x7bc501a48fc6524b = 3, 
				xa460a0b649265441 = 4, 
				x24222799309196a8 = 5, 
				x24d4d51879f7605e = 6, 
				xa64d28fad9b3df98 = 7, 
				x5827c4f2314f1346 = 8, 
				x062575979028fd71 = 9, 
				x5c9e4e2dc9b12067 = 10, 
				x3d235fc95c355365 = 11, 
			}
			
		#endregion
		
		#region Constructors
		
			public x5f4b657f68f87baa ()
			/*
				// Code Size: 50 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
				L_0007: ldarg.0 
				L_0008: ldc.i4.0 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xb2504b89d66feca9
				L_000e: ldarg.0 
				L_000f: ldnull 
				L_0010: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Form xb7d28b7a6d50662f
				L_0015: ldarg.0 
				L_0016: ldc.i4.0 
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x49b363db01752634
				L_001c: ldarg.0 
				L_001d: call System.ComponentModel.Component::Void .ctor()
				L_0022: ldarg.0 
				L_0023: ldstr "MenuItem"
				L_0028: ldnull 
				L_0029: ldc.i4.m1 
				L_002a: ldc.i4.0 
				L_002b: ldnull 
				L_002c: call Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void InternalConstruct(System.String, System.Windows.Forms.ImageList, Int32, System.Windows.Forms.Shortcut, System.EventHandler)
				L_0031: ret 
			*/
			
			public x5f4b657f68f87baa (string text)
			/*
				// Code Size: 46 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
				L_0007: ldarg.0 
				L_0008: ldc.i4.0 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xb2504b89d66feca9
				L_000e: ldarg.0 
				L_000f: ldnull 
				L_0010: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Form xb7d28b7a6d50662f
				L_0015: ldarg.0 
				L_0016: ldc.i4.0 
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x49b363db01752634
				L_001c: ldarg.0 
				L_001d: call System.ComponentModel.Component::Void .ctor()
				L_0022: ldarg.0 
				L_0023: ldarg.1 
				L_0024: ldnull 
				L_0025: ldc.i4.m1 
				L_0026: ldc.i4.0 
				L_0027: ldnull 
				L_0028: call Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void InternalConstruct(System.String, System.Windows.Forms.ImageList, Int32, System.Windows.Forms.Shortcut, System.EventHandler)
				L_002d: ret 
			*/
			
			public x5f4b657f68f87baa (string text, EventHandler clickHandler)
			/*
				// Code Size: 46 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
				L_0007: ldarg.0 
				L_0008: ldc.i4.0 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xb2504b89d66feca9
				L_000e: ldarg.0 
				L_000f: ldnull 
				L_0010: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Form xb7d28b7a6d50662f
				L_0015: ldarg.0 
				L_0016: ldc.i4.0 
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x49b363db01752634
				L_001c: ldarg.0 
				L_001d: call System.ComponentModel.Component::Void .ctor()
				L_0022: ldarg.0 
				L_0023: ldarg.1 
				L_0024: ldnull 
				L_0025: ldc.i4.m1 
				L_0026: ldc.i4.0 
				L_0027: ldarg.2 
				L_0028: call Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void InternalConstruct(System.String, System.Windows.Forms.ImageList, Int32, System.Windows.Forms.Shortcut, System.EventHandler)
				L_002d: ret 
			*/
			
			public x5f4b657f68f87baa (string text, System.Windows.Forms.Shortcut shortcut)
			/*
				// Code Size: 46 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
				L_0007: ldarg.0 
				L_0008: ldc.i4.0 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xb2504b89d66feca9
				L_000e: ldarg.0 
				L_000f: ldnull 
				L_0010: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Form xb7d28b7a6d50662f
				L_0015: ldarg.0 
				L_0016: ldc.i4.0 
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x49b363db01752634
				L_001c: ldarg.0 
				L_001d: call System.ComponentModel.Component::Void .ctor()
				L_0022: ldarg.0 
				L_0023: ldarg.1 
				L_0024: ldnull 
				L_0025: ldc.i4.m1 
				L_0026: ldarg.2 
				L_0027: ldnull 
				L_0028: call Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void InternalConstruct(System.String, System.Windows.Forms.ImageList, Int32, System.Windows.Forms.Shortcut, System.EventHandler)
				L_002d: ret 
			*/
			
			public x5f4b657f68f87baa (string text, System.Windows.Forms.Shortcut shortcut, EventHandler clickHandler)
			/*
				// Code Size: 46 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
				L_0007: ldarg.0 
				L_0008: ldc.i4.0 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xb2504b89d66feca9
				L_000e: ldarg.0 
				L_000f: ldnull 
				L_0010: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Form xb7d28b7a6d50662f
				L_0015: ldarg.0 
				L_0016: ldc.i4.0 
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x49b363db01752634
				L_001c: ldarg.0 
				L_001d: call System.ComponentModel.Component::Void .ctor()
				L_0022: ldarg.0 
				L_0023: ldarg.1 
				L_0024: ldnull 
				L_0025: ldc.i4.m1 
				L_0026: ldarg.2 
				L_0027: ldarg.3 
				L_0028: call Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void InternalConstruct(System.String, System.Windows.Forms.ImageList, Int32, System.Windows.Forms.Shortcut, System.EventHandler)
				L_002d: ret 
			*/
			
			public x5f4b657f68f87baa (string text, System.Windows.Forms.ImageList imageList, int imageIndex)
			/*
				// Code Size: 46 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
				L_0007: ldarg.0 
				L_0008: ldc.i4.0 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xb2504b89d66feca9
				L_000e: ldarg.0 
				L_000f: ldnull 
				L_0010: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Form xb7d28b7a6d50662f
				L_0015: ldarg.0 
				L_0016: ldc.i4.0 
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x49b363db01752634
				L_001c: ldarg.0 
				L_001d: call System.ComponentModel.Component::Void .ctor()
				L_0022: ldarg.0 
				L_0023: ldarg.1 
				L_0024: ldarg.2 
				L_0025: ldarg.3 
				L_0026: ldc.i4.0 
				L_0027: ldnull 
				L_0028: call Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void InternalConstruct(System.String, System.Windows.Forms.ImageList, Int32, System.Windows.Forms.Shortcut, System.EventHandler)
				L_002d: ret 
			*/
			
			public x5f4b657f68f87baa (string text, System.Windows.Forms.ImageList imageList, int imageIndex, System.Windows.Forms.Shortcut shortcut)
			/*
				// Code Size: 47 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
				L_0007: ldarg.0 
				L_0008: ldc.i4.0 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xb2504b89d66feca9
				L_000e: ldarg.0 
				L_000f: ldnull 
				L_0010: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Form xb7d28b7a6d50662f
				L_0015: ldarg.0 
				L_0016: ldc.i4.0 
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x49b363db01752634
				L_001c: ldarg.0 
				L_001d: call System.ComponentModel.Component::Void .ctor()
				L_0022: ldarg.0 
				L_0023: ldarg.1 
				L_0024: ldarg.2 
				L_0025: ldarg.3 
				L_0026: ldarg.s shortcut
				L_0028: ldnull 
				L_0029: call Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void InternalConstruct(System.String, System.Windows.Forms.ImageList, Int32, System.Windows.Forms.Shortcut, System.EventHandler)
				L_002e: ret 
			*/
			
			public x5f4b657f68f87baa (string text, System.Windows.Forms.ImageList imageList, int imageIndex, EventHandler clickHandler)
			/*
				// Code Size: 47 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
				L_0007: ldarg.0 
				L_0008: ldc.i4.0 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xb2504b89d66feca9
				L_000e: ldarg.0 
				L_000f: ldnull 
				L_0010: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Form xb7d28b7a6d50662f
				L_0015: ldarg.0 
				L_0016: ldc.i4.0 
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x49b363db01752634
				L_001c: ldarg.0 
				L_001d: call System.ComponentModel.Component::Void .ctor()
				L_0022: ldarg.0 
				L_0023: ldarg.1 
				L_0024: ldarg.2 
				L_0025: ldarg.3 
				L_0026: ldc.i4.0 
				L_0027: ldarg.s clickHandler
				L_0029: call Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void InternalConstruct(System.String, System.Windows.Forms.ImageList, Int32, System.Windows.Forms.Shortcut, System.EventHandler)
				L_002e: ret 
			*/
			
			public x5f4b657f68f87baa (string text, System.Windows.Forms.ImageList imageList, int imageIndex, System.Windows.Forms.Shortcut shortcut, EventHandler clickHandler)
			/*
				// Code Size: 48 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
				L_0007: ldarg.0 
				L_0008: ldc.i4.0 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xb2504b89d66feca9
				L_000e: ldarg.0 
				L_000f: ldnull 
				L_0010: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Form xb7d28b7a6d50662f
				L_0015: ldarg.0 
				L_0016: ldc.i4.0 
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x49b363db01752634
				L_001c: ldarg.0 
				L_001d: call System.ComponentModel.Component::Void .ctor()
				L_0022: ldarg.0 
				L_0023: ldarg.1 
				L_0024: ldarg.2 
				L_0025: ldarg.3 
				L_0026: ldarg.s shortcut
				L_0028: ldarg.s clickHandler
				L_002a: call Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void InternalConstruct(System.String, System.Windows.Forms.ImageList, Int32, System.Windows.Forms.Shortcut, System.EventHandler)
				L_002f: ret 
			*/
		#endregion
		
		#region Properties
		
			public MenuItem AttachedMenuItem
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_0006: ret 
				*/
				
				{
					return this.x569ad91f8a39fe51;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_0007: ret 
				*/
				
				{
					this.x569ad91f8a39fe51 = value;
				}
			}
			
			
			[DefaultValueAttribute(false)]
			public bool Break
			
			{
				get
				
				/*
					// Code Size: 27 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_0006: brfalse.s L_0014
					L_0008: ldarg.0 
					L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_000e: callvirt System.Windows.Forms.MenuItem::Boolean get_Break()
					L_0013: ret 
					L_0014: ldarg.0 
					L_0015: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x0933636ccb6c95f5
					L_001a: ret 
				*/
				
				{
					if (this.x569ad91f8a39fe51 == null)
					{
						return this.x0933636ccb6c95f5;
					}
					else
					{
						return this.x569ad91f8a39fe51.Break;
					}
				}
				set
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x0933636ccb6c95f5
					L_0006: ldarg.1 
					L_0007: beq.s L_0017
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x0933636ccb6c95f5
					L_0010: ldarg.0 
					L_0011: ldc.i4.8 
					L_0012: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnPropertyChanged(x879a106b0501b9dc)
					L_0017: ret 
				*/
				
				{
					if (this.x0933636ccb6c95f5 != value)
					{
						this.x0933636ccb6c95f5 = value;
						this.OnPropertyChanged (x879a106b0501b9dc.x5827c4f2314f1346);
					}
				}
			}
			
			
			[DefaultValueAttribute(false)]
			public bool Checked
			
			{
				get
				
				/*
					// Code Size: 27 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_0006: brfalse.s L_0014
					L_0008: ldarg.0 
					L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_000e: callvirt System.Windows.Forms.MenuItem::Boolean get_Checked()
					L_0013: ret 
					L_0014: ldarg.0 
					L_0015: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x5cd949e9f24593b6
					L_001a: ret 
				*/
				
				{
					if (this.x569ad91f8a39fe51 == null)
					{
						return this.x5cd949e9f24593b6;
					}
					else
					{
						return this.x569ad91f8a39fe51.Checked;
					}
				}
				set
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x5cd949e9f24593b6
					L_0006: ldarg.1 
					L_0007: beq.s L_0017
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x5cd949e9f24593b6
					L_0010: ldarg.0 
					L_0011: ldc.i4.6 
					L_0012: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnPropertyChanged(x879a106b0501b9dc)
					L_0017: ret 
				*/
				
				{
					if (this.x5cd949e9f24593b6 != value)
					{
						this.x5cd949e9f24593b6 = value;
						this.OnPropertyChanged (x879a106b0501b9dc.x24d4d51879f7605e);
					}
				}
			}
			
			
			[LocalizableAttribute(true)]
			[DefaultValueAttribute("")]
			public string Description
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String xc2358fbac7da3d45
					L_0006: ret 
				*/
				
				{
					return this.xc2358fbac7da3d45;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String xc2358fbac7da3d45
					L_0007: ret 
				*/
				
				{
					this.xc2358fbac7da3d45 = value;
				}
			}
			
			
			[DefaultValueAttribute(true)]
			public bool Enabled
			
			{
				get
				
				/*
					// Code Size: 27 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_0006: brfalse.s L_0014
					L_0008: ldarg.0 
					L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_000e: callvirt System.Windows.Forms.MenuItem::Boolean get_Enabled()
					L_0013: ret 
					L_0014: ldarg.0 
					L_0015: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x2fef7d841879a711
					L_001a: ret 
				*/
				
				{
					if (this.x569ad91f8a39fe51 == null)
					{
						return this.x2fef7d841879a711;
					}
					else
					{
						return this.x569ad91f8a39fe51.Enabled;
					}
				}
				set
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x2fef7d841879a711
					L_0006: ldarg.1 
					L_0007: beq.s L_0017
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x2fef7d841879a711
					L_0010: ldarg.0 
					L_0011: ldc.i4.1 
					L_0012: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnPropertyChanged(x879a106b0501b9dc)
					L_0017: ret 
				*/
				
				{
					if (this.x2fef7d841879a711 != value)
					{
						this.x2fef7d841879a711 = value;
						this.OnPropertyChanged (x879a106b0501b9dc.x9f2c0dc847992f03);
					}
				}
			}
			
			
			[DefaultValueAttribute(((String) null))]
			public Image Image
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Drawing.Image xe058541ca798c059
					L_0006: ret 
				*/
				
				{
					return this.xe058541ca798c059;
				}
				set
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Drawing.Image xe058541ca798c059
					L_0006: ldarg.1 
					L_0007: beq.s L_0017
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Drawing.Image xe058541ca798c059
					L_0010: ldarg.0 
					L_0011: ldc.i4.4 
					L_0012: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnPropertyChanged(x879a106b0501b9dc)
					L_0017: ret 
				*/
				
				{
					if (this.xe058541ca798c059 != value)
					{
						this.xe058541ca798c059 = value;
						this.OnPropertyChanged (x879a106b0501b9dc.xa460a0b649265441);
					}
				}
			}
			
			
			[DefaultValueAttribute(FFFFFFFF)]
			public int ImageIndex
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Int32 xc931041ff8b5600b
					L_0006: ret 
				*/
				
				{
					return this.xc931041ff8b5600b;
				}
				set
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Int32 xc931041ff8b5600b
					L_0006: ldarg.1 
					L_0007: beq.s L_0017
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Int32 xc931041ff8b5600b
					L_0010: ldarg.0 
					L_0011: ldc.i4.2 
					L_0012: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnPropertyChanged(x879a106b0501b9dc)
					L_0017: ret 
				*/
				
				{
					if (this.xc931041ff8b5600b != value)
					{
						this.xc931041ff8b5600b = value;
						this.OnPropertyChanged (x879a106b0501b9dc.xaa7785f730d8dd15);
					}
				}
			}
			
			
			[DefaultValueAttribute(((String) null))]
			public ImageList ImageList
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.ImageList x6ec0d1228599f9ae
					L_0006: ret 
				*/
				
				{
					return this.x6ec0d1228599f9ae;
				}
				set
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.ImageList x6ec0d1228599f9ae
					L_0006: ldarg.1 
					L_0007: beq.s L_0017
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.ImageList x6ec0d1228599f9ae
					L_0010: ldarg.0 
					L_0011: ldc.i4.3 
					L_0012: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnPropertyChanged(x879a106b0501b9dc)
					L_0017: ret 
				*/
				
				{
					if (this.x6ec0d1228599f9ae != value)
					{
						this.x6ec0d1228599f9ae = value;
						this.OnPropertyChanged (x879a106b0501b9dc.x7bc501a48fc6524b);
					}
				}
			}
			
			
			[DefaultValueAttribute(false)]
			public bool Infrequent
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x116b6a58ff0ad788
					L_0006: ret 
				*/
				
				{
					return this.x116b6a58ff0ad788;
				}
				set
				
				/*
					// Code Size: 25 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x116b6a58ff0ad788
					L_0006: ldarg.1 
					L_0007: beq.s L_0018
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x116b6a58ff0ad788
					L_0010: ldarg.0 
					L_0011: ldc.i4.s 9
					L_0013: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnPropertyChanged(x879a106b0501b9dc)
					L_0018: ret 
				*/
				
				{
					if (this.x116b6a58ff0ad788 != value)
					{
						this.x116b6a58ff0ad788 = value;
						this.OnPropertyChanged (x879a106b0501b9dc.x062575979028fd71);
					}
				}
			}
			
			
			[BrowsableAttribute(false)]
			public bool IsParent
			
			{
				get
				
				/*
					// Code Size: 15 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xa73e17ae29927ab0
					L_0006: callvirt System.Collections.CollectionBase::Int32 get_Count()
					L_000b: ldc.i4.0 
					L_000c: cgt 
					L_000e: ret 
				*/
				
				{
					return (this.xa73e17ae29927ab0.Count > 0);
				}
			}
			
			
			[DefaultValueAttribute(false)]
			public bool MdiList
			
			{
				get
				
				/*
					// Code Size: 27 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_0006: brfalse.s L_0014
					L_0008: ldarg.0 
					L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_000e: callvirt System.Windows.Forms.MenuItem::Boolean get_MdiList()
					L_0013: ret 
					L_0014: ldarg.0 
					L_0015: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x49b363db01752634
					L_001a: ret 
				*/
				
				{
					if (this.x569ad91f8a39fe51 == null)
					{
						return this.x49b363db01752634;
					}
					else
					{
						return this.x569ad91f8a39fe51.MdiList;
					}
				}
				set
				
				/*
					// Code Size: 17 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x49b363db01752634
					L_0006: ldarg.1 
					L_0007: beq.s L_0010
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x49b363db01752634
					L_0010: ret 
				*/
				
				{
					if (this.x49b363db01752634 != value)
					{
						this.x49b363db01752634 = value;
					}
				}
			}
			
			
			[DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
			public xd53b20b7b4b2a08a MenuCommands
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xa73e17ae29927ab0
					L_0006: ret 
				*/
				
				{
					return this.xa73e17ae29927ab0;
				}
			}
			
			
			[DefaultValueAttribute(false)]
			public bool RadioCheck
			
			{
				get
				
				/*
					// Code Size: 27 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_0006: brfalse.s L_0014
					L_0008: ldarg.0 
					L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_000e: callvirt System.Windows.Forms.MenuItem::Boolean get_RadioCheck()
					L_0013: ret 
					L_0014: ldarg.0 
					L_0015: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xf3a4c29d9fe0ddc7
					L_001a: ret 
				*/
				
				{
					if (this.x569ad91f8a39fe51 == null)
					{
						return this.xf3a4c29d9fe0ddc7;
					}
					else
					{
						return this.x569ad91f8a39fe51.RadioCheck;
					}
				}
				set
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xf3a4c29d9fe0ddc7
					L_0006: ldarg.1 
					L_0007: beq.s L_0017
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xf3a4c29d9fe0ddc7
					L_0010: ldarg.0 
					L_0011: ldc.i4.7 
					L_0012: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnPropertyChanged(x879a106b0501b9dc)
					L_0017: ret 
				*/
				
				{
					if (this.xf3a4c29d9fe0ddc7 != value)
					{
						this.xf3a4c29d9fe0ddc7 = value;
						this.OnPropertyChanged (x879a106b0501b9dc.xa64d28fad9b3df98);
					}
				}
			}
			
			
			[DefaultValueAttribute(((Type) typeof (Shortcut)), "None")]
			public Shortcut Shortcut
			
			{
				get
				
				/*
					// Code Size: 27 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_0006: brfalse.s L_0014
					L_0008: ldarg.0 
					L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_000e: callvirt System.Windows.Forms.MenuItem::System.Windows.Forms.Shortcut get_Shortcut()
					L_0013: ret 
					L_0014: ldarg.0 
					L_0015: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Shortcut xc0de55fd2ca182a4
					L_001a: ret 
				*/
				
				{
					if (this.x569ad91f8a39fe51 == null)
					{
						return this.xc0de55fd2ca182a4;
					}
					else
					{
						return this.x569ad91f8a39fe51.Shortcut;
					}
				}
				set
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Shortcut xc0de55fd2ca182a4
					L_0006: ldarg.1 
					L_0007: beq.s L_0017
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Shortcut xc0de55fd2ca182a4
					L_0010: ldarg.0 
					L_0011: ldc.i4.5 
					L_0012: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnPropertyChanged(x879a106b0501b9dc)
					L_0017: ret 
				*/
				
				{
					if (this.xc0de55fd2ca182a4 != value)
					{
						this.xc0de55fd2ca182a4 = value;
						this.OnPropertyChanged (x879a106b0501b9dc.x24222799309196a8);
					}
				}
			}
			
			
			[DefaultValueAttribute(((String) null))]
			public object Tag
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Object xffe521cc76054baf
					L_0006: ret 
				*/
				
				{
					return this.xffe521cc76054baf;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Object xffe521cc76054baf
					L_0007: ret 
				*/
				
				{
					this.xffe521cc76054baf = value;
				}
			}
			
			
			[DefaultValueAttribute("MenuItem")]
			[LocalizableAttribute(true)]
			public string Text
			
			{
				get
				
				/*
					// Code Size: 27 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_0006: brfalse.s L_0014
					L_0008: ldarg.0 
					L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_000e: callvirt System.Windows.Forms.MenuItem::System.String get_Text()
					L_0013: ret 
					L_0014: ldarg.0 
					L_0015: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String xb41faee6912a2313
					L_001a: ret 
				*/
				
				{
					if (this.x569ad91f8a39fe51 == null)
					{
						return this.xb41faee6912a2313;
					}
					else
					{
						return this.x569ad91f8a39fe51.Text;
					}
				}
				set
				
				/*
					// Code Size: 29 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String xb41faee6912a2313
					L_0006: ldarg.1 
					L_0007: call System.String::Boolean op_Inequality(System.String, System.String)
					L_000c: brfalse.s L_001c
					L_000e: ldarg.0 
					L_000f: ldarg.1 
					L_0010: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String xb41faee6912a2313
					L_0015: ldarg.0 
					L_0016: ldc.i4.0 
					L_0017: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnPropertyChanged(x879a106b0501b9dc)
					L_001c: ret 
				*/
				
				{
					if (this.xb41faee6912a2313 != value)
					{
						this.xb41faee6912a2313 = value;
						this.OnPropertyChanged (x879a106b0501b9dc.xf9ad6fb78355fe13);
					}
				}
			}
			
			
			[DefaultValueAttribute(true)]
			public bool Visible
			
			{
				get
				
				/*
					// Code Size: 27 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_0006: brfalse.s L_0014
					L_0008: ldarg.0 
					L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
					L_000e: callvirt System.Windows.Forms.MenuItem::Boolean get_Visible()
					L_0013: ret 
					L_0014: ldarg.0 
					L_0015: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x364c1e3b189d47fe
					L_001a: ret 
				*/
				
				{
					if (this.x569ad91f8a39fe51 == null)
					{
						return this.x364c1e3b189d47fe;
					}
					else
					{
						return this.x569ad91f8a39fe51.Visible;
					}
				}
				set
				
				/*
					// Code Size: 25 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x364c1e3b189d47fe
					L_0006: ldarg.1 
					L_0007: beq.s L_0018
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x364c1e3b189d47fe
					L_0010: ldarg.0 
					L_0011: ldc.i4.s 10
					L_0013: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnPropertyChanged(x879a106b0501b9dc)
					L_0018: ret 
				*/
				
				{
					if (this.x364c1e3b189d47fe != value)
					{
						this.x364c1e3b189d47fe = value;
						this.OnPropertyChanged (x879a106b0501b9dc.x5c9e4e2dc9b12067);
					}
				}
			}
			
		#endregion
		
		#region Events
		
			public event EventHandler Click
			
			{
				add
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.0 
					L_0002: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.EventHandler x98992f4120a73bb9
					L_0007: ldarg.1 
					L_0008: call System.Delegate::System.Delegate Combine(System.Delegate, System.Delegate)
					L_000d: castclass System.EventHandler
					L_0012: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.EventHandler x98992f4120a73bb9
					L_0017: ret 
				*/
				
				{
					this.x98992f4120a73bb9 = ((EventHandler) Delegate.Combine (((Delegate) this.x98992f4120a73bb9), ((Delegate) value)));
				}
				remove
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.0 
					L_0002: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.EventHandler x98992f4120a73bb9
					L_0007: ldarg.1 
					L_0008: call System.Delegate::System.Delegate Remove(System.Delegate, System.Delegate)
					L_000d: castclass System.EventHandler
					L_0012: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.EventHandler x98992f4120a73bb9
					L_0017: ret 
				*/
				
				{
					this.x98992f4120a73bb9 = ((EventHandler) Delegate.Remove (((Delegate) this.x98992f4120a73bb9), ((Delegate) value)));
				}
			}
			
			
			public event x26569a56dfbc2c6d PopupEnd
			
			{
				add
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.0 
					L_0002: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d x1b233dbc8c05d73f
					L_0007: ldarg.1 
					L_0008: call System.Delegate::System.Delegate Combine(System.Delegate, System.Delegate)
					L_000d: castclass Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d
					L_0012: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d x1b233dbc8c05d73f
					L_0017: ret 
				*/
				
				{
					this.x1b233dbc8c05d73f = ((x26569a56dfbc2c6d) Delegate.Combine (((Delegate) this.x1b233dbc8c05d73f), ((Delegate) value)));
				}
				remove
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.0 
					L_0002: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d x1b233dbc8c05d73f
					L_0007: ldarg.1 
					L_0008: call System.Delegate::System.Delegate Remove(System.Delegate, System.Delegate)
					L_000d: castclass Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d
					L_0012: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d x1b233dbc8c05d73f
					L_0017: ret 
				*/
				
				{
					this.x1b233dbc8c05d73f = ((x26569a56dfbc2c6d) Delegate.Remove (((Delegate) this.x1b233dbc8c05d73f), ((Delegate) value)));
				}
			}
			
			
			public event x26569a56dfbc2c6d PopupStart
			
			{
				add
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.0 
					L_0002: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d x3b2905fe94e52614
					L_0007: ldarg.1 
					L_0008: call System.Delegate::System.Delegate Combine(System.Delegate, System.Delegate)
					L_000d: castclass Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d
					L_0012: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d x3b2905fe94e52614
					L_0017: ret 
				*/
				
				{
					this.x3b2905fe94e52614 = ((x26569a56dfbc2c6d) Delegate.Combine (((Delegate) this.x3b2905fe94e52614), ((Delegate) value)));
				}
				remove
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.0 
					L_0002: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d x3b2905fe94e52614
					L_0007: ldarg.1 
					L_0008: call System.Delegate::System.Delegate Remove(System.Delegate, System.Delegate)
					L_000d: castclass Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d
					L_0012: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d x3b2905fe94e52614
					L_0017: ret 
				*/
				
				{
					this.x3b2905fe94e52614 = ((x26569a56dfbc2c6d) Delegate.Remove (((Delegate) this.x3b2905fe94e52614), ((Delegate) value)));
				}
			}
			
			
			public event x5282b9c42ea1abce PropertyChanged
			
			{
				add
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.0 
					L_0002: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::x5282b9c42ea1abce x0ad6cb77c00e4e89
					L_0007: ldarg.1 
					L_0008: call System.Delegate::System.Delegate Combine(System.Delegate, System.Delegate)
					L_000d: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa+x5282b9c42ea1abce
					L_0012: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::x5282b9c42ea1abce x0ad6cb77c00e4e89
					L_0017: ret 
				*/
				
				{
					this.x0ad6cb77c00e4e89 = ((x5282b9c42ea1abce) Delegate.Combine (((Delegate) this.x0ad6cb77c00e4e89), ((Delegate) value)));
				}
				remove
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.0 
					L_0002: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::x5282b9c42ea1abce x0ad6cb77c00e4e89
					L_0007: ldarg.1 
					L_0008: call System.Delegate::System.Delegate Remove(System.Delegate, System.Delegate)
					L_000d: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa+x5282b9c42ea1abce
					L_0012: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::x5282b9c42ea1abce x0ad6cb77c00e4e89
					L_0017: ret 
				*/
				
				{
					this.x0ad6cb77c00e4e89 = ((x5282b9c42ea1abce) Delegate.Remove (((Delegate) this.x0ad6cb77c00e4e89), ((Delegate) value)));
				}
			}
			
			
			public event EventHandler Update
			
			{
				add
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.0 
					L_0002: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.EventHandler x295cb4a1df7a5add
					L_0007: ldarg.1 
					L_0008: call System.Delegate::System.Delegate Combine(System.Delegate, System.Delegate)
					L_000d: castclass System.EventHandler
					L_0012: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.EventHandler x295cb4a1df7a5add
					L_0017: ret 
				*/
				
				{
					this.x295cb4a1df7a5add = ((EventHandler) Delegate.Combine (((Delegate) this.x295cb4a1df7a5add), ((Delegate) value)));
				}
				remove
				
				/*
					// Code Size: 24 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.0 
					L_0002: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.EventHandler x295cb4a1df7a5add
					L_0007: ldarg.1 
					L_0008: call System.Delegate::System.Delegate Remove(System.Delegate, System.Delegate)
					L_000d: castclass System.EventHandler
					L_0012: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.EventHandler x295cb4a1df7a5add
					L_0017: ret 
				*/
				
				{
					this.x295cb4a1df7a5add = ((EventHandler) Delegate.Remove (((Delegate) this.x295cb4a1df7a5add), ((Delegate) value)));
				}
			}
			
		#endregion
		
		#region Methods
		
			protected void InternalConstruct (string text, System.Windows.Forms.ImageList imageList, int imageIndex, System.Windows.Forms.Shortcut shortcut, EventHandler clickHandler)
			
			/*
				// Code Size: 132 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String xb41faee6912a2313
				L_0007: ldarg.0 
				L_0008: ldarg.2 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.ImageList x6ec0d1228599f9ae
				L_000e: ldarg.0 
				L_000f: ldarg.3 
				L_0010: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Int32 xc931041ff8b5600b
				L_0015: ldarg.0 
				L_0016: ldarg.s shortcut
				L_0018: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Shortcut xc0de55fd2ca182a4
				L_001d: ldarg.0 
				L_001e: ldarg.1 
				L_001f: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String xc2358fbac7da3d45
				L_0024: ldarg.s clickHandler
				L_0026: brfalse.s L_0040
				L_0028: ldarg.0 
				L_0029: dup 
				L_002a: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.EventHandler x98992f4120a73bb9
				L_002f: ldarg.s clickHandler
				L_0031: call System.Delegate::System.Delegate Combine(System.Delegate, System.Delegate)
				L_0036: castclass System.EventHandler
				L_003b: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.EventHandler x98992f4120a73bb9
				L_0040: ldarg.0 
				L_0041: ldc.i4.1 
				L_0042: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x2fef7d841879a711
				L_0047: ldarg.0 
				L_0048: ldc.i4.0 
				L_0049: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x5cd949e9f24593b6
				L_004e: ldarg.0 
				L_004f: ldc.i4.0 
				L_0050: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xf3a4c29d9fe0ddc7
				L_0055: ldarg.0 
				L_0056: ldc.i4.0 
				L_0057: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x0933636ccb6c95f5
				L_005c: ldarg.0 
				L_005d: ldnull 
				L_005e: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Object xffe521cc76054baf
				L_0063: ldarg.0 
				L_0064: ldc.i4.1 
				L_0065: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x364c1e3b189d47fe
				L_006a: ldarg.0 
				L_006b: ldc.i4.0 
				L_006c: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean x116b6a58ff0ad788
				L_0071: ldarg.0 
				L_0072: ldnull 
				L_0073: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Drawing.Image xe058541ca798c059
				L_0078: ldarg.0 
				L_0079: newobj Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Void .ctor()
				L_007e: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xa73e17ae29927ab0
				L_0083: ret 
			*/
			
			
			{
				this.xb41faee6912a2313 = text;
				this.x6ec0d1228599f9ae = imageList;
				this.xc931041ff8b5600b = imageIndex;
				this.xc0de55fd2ca182a4 = shortcut;
				this.xc2358fbac7da3d45 = text;
				if (clickHandler != null)
				{
					this.x98992f4120a73bb9 = ((EventHandler) Delegate.Combine (((Delegate) this.x98992f4120a73bb9), ((Delegate) clickHandler)));
				}
				this.x2fef7d841879a711 = true;
				this.x5cd949e9f24593b6 = false;
				this.xf3a4c29d9fe0ddc7 = false;
				this.x0933636ccb6c95f5 = false;
				this.xffe521cc76054baf = null;
				this.x364c1e3b189d47fe = true;
				this.x116b6a58ff0ad788 = false;
				this.xe058541ca798c059 = ((System.Drawing.Image) null);
				this.xa73e17ae29927ab0 = new xd53b20b7b4b2a08a ();
			}
			
			public virtual void OnClick (EventArgs e)
			
			/*
				// Code Size: 22 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.EventHandler x98992f4120a73bb9
				L_0006: brfalse.s L_0015
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.EventHandler x98992f4120a73bb9
				L_000e: ldarg.0 
				L_000f: ldarg.1 
				L_0010: callvirt System.EventHandler::Void Invoke(System.Object, System.EventArgs)
				L_0015: ret 
			*/
			
			
			{
				if (this.x98992f4120a73bb9 != null)
				{
					this.x98992f4120a73bb9 (this, e);
				}
			}
			
			public virtual void OnPopupEnd ()
			
			/*
				// Code Size: 21 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d x1b233dbc8c05d73f
				L_0006: brfalse.s L_0014
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d x1b233dbc8c05d73f
				L_000e: ldarg.0 
				L_000f: callvirt Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d::Void Invoke(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0014: ret 
			*/
			
			
			{
				if (this.x1b233dbc8c05d73f != null)
				{
					this.x1b233dbc8c05d73f (this);
				}
			}
			
			public virtual void OnPopupStart ()
			
			/*
				// Code Size: 21 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d x3b2905fe94e52614
				L_0006: brfalse.s L_0014
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d x3b2905fe94e52614
				L_000e: ldarg.0 
				L_000f: callvirt Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d::Void Invoke(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0014: ret 
			*/
			
			
			{
				if (this.x3b2905fe94e52614 != null)
				{
					this.x3b2905fe94e52614 (this);
				}
			}
			
			public virtual void OnPropertyChanged (x879a106b0501b9dc prop)
			
			/*
				// Code Size: 22 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::x5282b9c42ea1abce x0ad6cb77c00e4e89
				L_0006: brfalse.s L_0015
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::x5282b9c42ea1abce x0ad6cb77c00e4e89
				L_000e: ldarg.0 
				L_000f: ldarg.1 
				L_0010: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa+x5282b9c42ea1abce::Void Invoke(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa, x879a106b0501b9dc)
				L_0015: ret 
			*/
			
			
			{
				if (this.x0ad6cb77c00e4e89 != null)
				{
					this.x0ad6cb77c00e4e89 (this, prop);
				}
			}
			
			public virtual void OnUpdate (EventArgs e)
			
			/*
				// Code Size: 22 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.EventHandler x295cb4a1df7a5add
				L_0006: brfalse.s L_0015
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.EventHandler x295cb4a1df7a5add
				L_000e: ldarg.0 
				L_000f: ldarg.1 
				L_0010: callvirt System.EventHandler::Void Invoke(System.Object, System.EventArgs)
				L_0015: ret 
			*/
			
			
			{
				if (this.x295cb4a1df7a5add != null)
				{
					this.x295cb4a1df7a5add (this, e);
				}
			}
			
			public void PerformClick ()
			
			/*
				// Code Size: 43 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
				L_0006: brfalse.s L_0014
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.MenuItem x569ad91f8a39fe51
				L_000e: callvirt System.Windows.Forms.MenuItem::Void PerformClick()
				L_0013: ret 
				L_0014: ldarg.0 
				L_0015: ldsfld System.EventArgs::System.EventArgs Empty
				L_001a: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnUpdate(System.EventArgs)
				L_001f: ldarg.0 
				L_0020: ldsfld System.EventArgs::System.EventArgs Empty
				L_0025: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnClick(System.EventArgs)
				L_002a: ret 
			*/
			
			
			{
				if (this.x569ad91f8a39fe51 != null)
				{
					this.x569ad91f8a39fe51.PerformClick ();
				}
				else
				{
					this.OnUpdate (EventArgs.Empty);
					this.OnClick (EventArgs.Empty);
				}
			}
			
		#endregion
	}
	
}

