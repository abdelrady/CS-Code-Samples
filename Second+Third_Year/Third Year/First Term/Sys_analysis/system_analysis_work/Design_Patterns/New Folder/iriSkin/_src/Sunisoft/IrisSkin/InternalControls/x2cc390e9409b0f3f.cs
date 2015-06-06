//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin.InternalControls

{
		
		#region Namespace Import Declarations
		
			using System.Drawing;
			using System;
			
			
		#endregion
		
	internal class x2cc390e9409b0f3f
	
	{
		
		#region Fields
			protected bool x09ab4af3120e4a2a;
			protected bool x116b6a58ff0ad788;
			protected bool x1d75da4dbf7e9da6;
			protected bool x2fef7d841879a711;
			protected bool x39d4d9d592924ac5;
			protected bool x3de314ab70bbd9bf;
			protected bool x88767e8bf75c08ee;
			protected char x8a8e9efa9f366dea;
			protected Rectangle xa5ca28a5d40a87c1;
			protected int xa806b754814b9ae0;
			protected bool xd1516a9a5bb6b163;
			protected int xf0476e906b9d9af4;
			protected bool xf13a675fdb7b229b;
			protected Rectangle xf78cf2936de01d72;
			protected x5f4b657f68f87baa xfd6dd6e53b1a26d5;
		#endregion
		
		#region Constructors
		
			public x2cc390e9409b0f3f (Rectangle drawRect, bool expansion)
			/*
				// Code Size: 119 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldc.i4.m1 
				L_0008: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 xa806b754814b9ae0
				L_000d: ldarg.0 
				L_000e: ldc.i4.m1 
				L_000f: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 xf0476e906b9d9af4
				L_0014: ldarg.0 
				L_0015: ldc.i4.s 48
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Char x8a8e9efa9f366dea
				L_001c: ldarg.0 
				L_001d: ldc.i4.1 
				L_001e: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x2fef7d841879a711
				L_0023: ldarg.0 
				L_0024: ldc.i4.0 
				L_0025: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean xf13a675fdb7b229b
				L_002a: ldarg.0 
				L_002b: ldarg.2 
				L_002c: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x1d75da4dbf7e9da6
				L_0031: ldarg.0 
				L_0032: ldarg.2 
				L_0033: ldc.i4.0 
				L_0034: ceq 
				L_0036: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x3de314ab70bbd9bf
				L_003b: ldarg.0 
				L_003c: ldarg.2 
				L_003d: ldc.i4.0 
				L_003e: ceq 
				L_0040: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x09ab4af3120e4a2a
				L_0045: ldarg.0 
				L_0046: ldc.i4.0 
				L_0047: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x39d4d9d592924ac5
				L_004c: ldarg.0 
				L_004d: ldc.i4.0 
				L_004e: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean xd1516a9a5bb6b163
				L_0053: ldarg.0 
				L_0054: ldc.i4.0 
				L_0055: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x116b6a58ff0ad788
				L_005a: ldarg.0 
				L_005b: ldc.i4.0 
				L_005c: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x88767e8bf75c08ee
				L_0061: ldarg.0 
				L_0062: ldarg.1 
				L_0063: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle xf78cf2936de01d72
				L_0068: ldarg.0 
				L_0069: ldarg.1 
				L_006a: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle xa5ca28a5d40a87c1
				L_006f: ldarg.0 
				L_0070: ldnull 
				L_0071: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xfd6dd6e53b1a26d5
				L_0076: ret 
			*/
			
			public x2cc390e9409b0f3f (Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa command, Rectangle drawRect, int row, int col)
			/*
				// Code Size: 19 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: ldarg.2 
				L_0009: ldarg.2 
				L_000a: ldarg.3 
				L_000b: ldarg.s col
				L_000d: call Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void xe8347ded66542b74(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa, System.Drawing.Rectangle, System.Drawing.Rectangle, Int32, Int32)
				L_0012: ret 
			*/
			
			public x2cc390e9409b0f3f (Rectangle drawRect)
			/*
				// Code Size: 113 Bytes
				.maxstack 3
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldc.i4.m1 
				L_0008: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 xa806b754814b9ae0
				L_000d: ldarg.0 
				L_000e: ldc.i4.m1 
				L_000f: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 xf0476e906b9d9af4
				L_0014: ldarg.0 
				L_0015: ldc.i4.s 48
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Char x8a8e9efa9f366dea
				L_001c: ldarg.0 
				L_001d: ldc.i4.1 
				L_001e: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x2fef7d841879a711
				L_0023: ldarg.0 
				L_0024: ldc.i4.0 
				L_0025: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean xf13a675fdb7b229b
				L_002a: ldarg.0 
				L_002b: ldc.i4.0 
				L_002c: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x1d75da4dbf7e9da6
				L_0031: ldarg.0 
				L_0032: ldc.i4.0 
				L_0033: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x3de314ab70bbd9bf
				L_0038: ldarg.0 
				L_0039: ldc.i4.0 
				L_003a: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x09ab4af3120e4a2a
				L_003f: ldarg.0 
				L_0040: ldc.i4.0 
				L_0041: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x39d4d9d592924ac5
				L_0046: ldarg.0 
				L_0047: ldc.i4.0 
				L_0048: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean xd1516a9a5bb6b163
				L_004d: ldarg.0 
				L_004e: ldc.i4.0 
				L_004f: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x116b6a58ff0ad788
				L_0054: ldarg.0 
				L_0055: ldc.i4.1 
				L_0056: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x88767e8bf75c08ee
				L_005b: ldarg.0 
				L_005c: ldarg.1 
				L_005d: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle xf78cf2936de01d72
				L_0062: ldarg.0 
				L_0063: ldarg.1 
				L_0064: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle xa5ca28a5d40a87c1
				L_0069: ldarg.0 
				L_006a: ldnull 
				L_006b: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xfd6dd6e53b1a26d5
				L_0070: ret 
			*/
			
			public x2cc390e9409b0f3f (Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa command, Rectangle drawRect, Rectangle selectRect)
			/*
				// Code Size: 18 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: ldarg.2 
				L_0009: ldarg.3 
				L_000a: ldc.i4.m1 
				L_000b: ldc.i4.m1 
				L_000c: call Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void xe8347ded66542b74(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa, System.Drawing.Rectangle, System.Drawing.Rectangle, Int32, Int32)
				L_0011: ret 
			*/
			
			public x2cc390e9409b0f3f (Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa command, Rectangle drawRect)
			/*
				// Code Size: 18 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ldarg.0 
				L_0007: ldarg.1 
				L_0008: ldarg.2 
				L_0009: ldarg.2 
				L_000a: ldc.i4.m1 
				L_000b: ldc.i4.m1 
				L_000c: call Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void xe8347ded66542b74(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa, System.Drawing.Rectangle, System.Drawing.Rectangle, Int32, Int32)
				L_0011: ret 
			*/
		#endregion
		
		#region Properties
		
			public bool x062575979028fd71
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x116b6a58ff0ad788
					L_0006: ret 
				*/
				
				{
					return this.x116b6a58ff0ad788;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x116b6a58ff0ad788
					L_0007: ret 
				*/
				
				{
					this.x116b6a58ff0ad788 = value;
				}
			}
			
			
			public int x2f00dc9f5cd11802
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 xf0476e906b9d9af4
					L_0006: ret 
				*/
				
				{
					return this.xf0476e906b9d9af4;
				}
			}
			
			
			public bool x3903fbc9023c861c
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean xd1516a9a5bb6b163
					L_0006: ret 
				*/
				
				{
					return this.xd1516a9a5bb6b163;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean xd1516a9a5bb6b163
					L_0007: ret 
				*/
				
				{
					this.xd1516a9a5bb6b163 = value;
				}
			}
			
			
			public bool x43604484a3deae4f
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x3de314ab70bbd9bf
					L_0006: ret 
				*/
				
				{
					return this.x3de314ab70bbd9bf;
				}
			}
			
			
			public char x4f86e73709b68aaf
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Char x8a8e9efa9f366dea
					L_0006: ret 
				*/
				
				{
					return this.x8a8e9efa9f366dea;
				}
			}
			
			
			public x5f4b657f68f87baa x5f4b657f68f87baa
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xfd6dd6e53b1a26d5
					L_0006: ret 
				*/
				
				{
					return this.xfd6dd6e53b1a26d5;
				}
			}
			
			
			public bool x649e2ad374251b5f
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean xf13a675fdb7b229b
					L_0006: ret 
				*/
				
				{
					return this.xf13a675fdb7b229b;
				}
			}
			
			
			public bool x9d329a00f2c534a8
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x39d4d9d592924ac5
					L_0006: ret 
				*/
				
				{
					return this.x39d4d9d592924ac5;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x39d4d9d592924ac5
					L_0007: ret 
				*/
				
				{
					this.x39d4d9d592924ac5 = value;
				}
			}
			
			
			public bool x9f2c0dc847992f03
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x2fef7d841879a711
					L_0006: ret 
				*/
				
				{
					return this.x2fef7d841879a711;
				}
			}
			
			
			public int xa19781cfbe8b4961
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 xa806b754814b9ae0
					L_0006: ret 
				*/
				
				{
					return this.xa806b754814b9ae0;
				}
			}
			
			
			public bool xaa08ea3ba2fe9514
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x88767e8bf75c08ee
					L_0006: ret 
				*/
				
				{
					return this.x88767e8bf75c08ee;
				}
			}
			
			
			public Rectangle xb26619e061f1a4b4
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle xa5ca28a5d40a87c1
					L_0006: ret 
				*/
				
				{
					return this.xa5ca28a5d40a87c1;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle xa5ca28a5d40a87c1
					L_0007: ret 
				*/
				
				{
					this.xa5ca28a5d40a87c1 = value;
				}
			}
			
			
			public bool xc1facdb08ad4967a
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x1d75da4dbf7e9da6
					L_0006: ret 
				*/
				
				{
					return this.x1d75da4dbf7e9da6;
				}
			}
			
			
			public bool xc8dbe008de6aee9e
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x09ab4af3120e4a2a
					L_0006: ret 
				*/
				
				{
					return this.x09ab4af3120e4a2a;
				}
			}
			
			
			public Rectangle xee63d905da8ff550
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle xf78cf2936de01d72
					L_0006: ret 
				*/
				
				{
					return this.xf78cf2936de01d72;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle xf78cf2936de01d72
					L_0007: ret 
				*/
				
				{
					this.xf78cf2936de01d72 = value;
				}
			}
			
		#endregion
		
		#region Methods
		
			public void xe8347ded66542b74 (Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xfd6dd6e53b1a26d5, Rectangle xf78cf2936de01d72, Rectangle xa5ca28a5d40a87c1, int xa806b754814b9ae0, int xf0476e906b9d9af4)
			
			/*
				// Code Size: 218 Bytes
				.maxstack 5
				.locals (System.Int32 V_0)
				L_0000: ldarg.0 
				L_0001: ldarg.s xa806b754814b9ae0
				L_0003: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 xa806b754814b9ae0
				L_0008: ldarg.0 
				L_0009: ldarg.s xf0476e906b9d9af4
				L_000b: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 xf0476e906b9d9af4
				L_0010: ldarg.0 
				L_0011: ldarg.1 
				L_0012: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Enabled()
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x2fef7d841879a711
				L_001c: ldarg.0 
				L_001d: ldc.i4.0 
				L_001e: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x1d75da4dbf7e9da6
				L_0023: ldarg.0 
				L_0024: ldc.i4.0 
				L_0025: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x09ab4af3120e4a2a
				L_002a: ldarg.0 
				L_002b: ldarg.2 
				L_002c: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle xf78cf2936de01d72
				L_0031: ldarg.0 
				L_0032: ldarg.3 
				L_0033: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle xa5ca28a5d40a87c1
				L_0038: ldarg.0 
				L_0039: ldarg.1 
				L_003a: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xfd6dd6e53b1a26d5
				L_003f: ldarg.0 
				L_0040: ldc.i4.0 
				L_0041: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x39d4d9d592924ac5
				L_0046: ldarg.0 
				L_0047: ldc.i4.0 
				L_0048: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean xd1516a9a5bb6b163
				L_004d: ldarg.0 
				L_004e: ldarg.1 
				L_004f: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Infrequent()
				L_0054: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x116b6a58ff0ad788
				L_0059: ldarg.0 
				L_005a: ldc.i4.0 
				L_005b: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x88767e8bf75c08ee
				L_0060: ldarg.0 
				L_0061: ldarg.0 
				L_0062: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xfd6dd6e53b1a26d5
				L_0067: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_006c: ldstr "-"
				L_0071: call System.String::Boolean op_Equality(System.String, System.String)
				L_0076: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean x3de314ab70bbd9bf
				L_007b: ldarg.0 
				L_007c: ldarg.0 
				L_007d: ldfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xfd6dd6e53b1a26d5
				L_0082: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0087: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_008c: ldc.i4.0 
				L_008d: cgt 
				L_008f: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean xf13a675fdb7b229b
				L_0094: ldc.i4.m1 
				L_0095: stloc.0 
				L_0096: ldarg.1 
				L_0097: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_009c: brfalse.s L_00ac
				L_009e: ldarg.1 
				L_009f: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_00a4: ldc.i4.s 38
				L_00a6: callvirt System.String::Int32 IndexOf(Char)
				L_00ab: stloc.0 
				L_00ac: ldloc.0 
				L_00ad: ldc.i4.m1 
				L_00ae: beq.s L_00d9
				L_00b0: ldloc.0 
				L_00b1: ldarg.1 
				L_00b2: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_00b7: callvirt System.String::Int32 get_Length()
				L_00bc: ldc.i4.1 
				L_00bd: sub 
				L_00be: bge.s L_00d9
				L_00c0: ldarg.0 
				L_00c1: ldarg.1 
				L_00c2: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_00c7: ldloc.0 
				L_00c8: ldc.i4.1 
				L_00c9: add 
				L_00ca: callvirt System.String::Char get_Chars(Int32)
				L_00cf: call System.Char::Char ToUpper(Char)
				L_00d4: stfld Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Char x8a8e9efa9f366dea
				L_00d9: ret 
			*/
			
			
			{
				this.xa806b754814b9ae0 = xa806b754814b9ae0;
				this.xf0476e906b9d9af4 = xf0476e906b9d9af4;
				this.x2fef7d841879a711 = xfd6dd6e53b1a26d5.Enabled;
				this.x1d75da4dbf7e9da6 = false;
				this.x09ab4af3120e4a2a = false;
				this.xf78cf2936de01d72 = xf78cf2936de01d72;
				this.xa5ca28a5d40a87c1 = xa5ca28a5d40a87c1;
				this.xfd6dd6e53b1a26d5 = xfd6dd6e53b1a26d5;
				this.x39d4d9d592924ac5 = false;
				this.xd1516a9a5bb6b163 = false;
				this.x116b6a58ff0ad788 = xfd6dd6e53b1a26d5.Infrequent;
				this.x88767e8bf75c08ee = false;
				this.x3de314ab70bbd9bf = (this.xfd6dd6e53b1a26d5.Text == "-");
				this.xf13a675fdb7b229b = (this.xfd6dd6e53b1a26d5.MenuCommands.Count > 0);
				int i1 = -1;
				if (xfd6dd6e53b1a26d5.Text != null)
				{
					i1 = xfd6dd6e53b1a26d5.Text.IndexOf ('\u0026');
				}
				if ((i1 != -1) && (i1 < (xfd6dd6e53b1a26d5.Text.Length - 1)))
				{
					this.x8a8e9efa9f366dea = char.ToUpper (xfd6dd6e53b1a26d5.Text[((int) (i1 + 1))]);
				}
			}
			
		#endregion
	}
	
}

