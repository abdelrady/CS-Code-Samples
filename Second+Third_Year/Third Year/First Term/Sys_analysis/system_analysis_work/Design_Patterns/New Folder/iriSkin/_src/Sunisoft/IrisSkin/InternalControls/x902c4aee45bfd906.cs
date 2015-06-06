//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin.InternalControls

{
		
		#region Namespace Import Declarations
		
			using Sunisoft.IrisSkin;
			using System.Collections;
			using System.ComponentModel;
			using System.Drawing;
			using System.Drawing.Drawing2D;
			using System.Drawing.Imaging;
			using System.Drawing.Text;
			using System.Threading;
			using System;
			using System.Windows.Forms;
			
			// Warning -- Type: System.Windows.Forms.Timer conflicts with a another imported type or namespace name,  Disabled Using Ref --> using Timer = System.Windows.Forms.Timer;
			
		#endregion
		
	[ToolboxItemAttribute(false)]
	internal class x902c4aee45bfd906 : NativeWindow
	
	{
		
		#region Fields
			protected static readonly int[,] _x13d4cb8d1bd20347;
			protected Point x07658cf2bdd49693;
			protected bool x0a7391c99fcdc469;
			protected int x0cd2bb383a46f073;
			protected x6fd23f8bad2f3ced x1cb292d12d9bf68e;
			protected Point x1ee5f8430343bccd;
			protected bool x20ad2840ee62b6a4;
			protected xdbfa333b4cd503e0 x23e85093ba3a7d1d;
			protected int x3012c20deea55334;
			protected readonly uint x325954b88ff83482;
			protected static int x36404b43d7b678c8;
			protected x3c41176af7e54b01 x37f2fc2a7f30f790;
			protected System.Windows.Forms.Timer x420067493d7ebb36;
			protected x5f4b657f68f87baa x4547ebd0fd2a7079;
			protected static int x4a8f256947767652;
			protected Point x50d4e184d788ac8c;
			protected x902c4aee45bfd906 x5142fa1a3d9591c8;
			protected bool x604ddcdfda178b5a;
			protected static int x65b69cc23d1d4c9e;
			protected Point x6941e4b46c92846d;
			protected bool x753f06f9b5cd6e0d;
			protected readonly uint x7a0e8e68a2ddb7d3;
			protected bool x86c6e3905608c757;
			protected Size x86ef051842f1ae49;
			protected int x8d677ea3c0d5a202;
			protected bool x8e0eb9fe60b28fae;
			internal RightToLeft x94975a4c4f1d71c4;
			protected bool x9a75ed38d1972c87;
			protected static bool x9c8c46cd7553cd2b;
			protected x1f5697535eab37b9 xa89034e65472167c;
			public event x26569a56dfbc2c6d xaa7558c320af04eb;
			protected x902c4aee45bfd906 xb13f2de377f27597;
			protected int xb266b78561d63b52;
			protected static int xb28e4e0b2e9dba92;
			protected int xb2c6baf52a3ff3eb;
			protected Font xb86af11733e6a799;
			protected static int xc00c540f7c5833fc;
			protected static int xc08a10dac990c769;
			protected bool xc1dccd328eafa426;
			protected bool xc316f3c6d490f56e;
			protected bool xc8609d9b3214b3e7;
			protected static Bitmap xca1a18e48751e941;
			private ISkinEngine xcab6a0e662ada486;
			protected Point xcbbe945601aff7c8;
			protected static int xd046a8db53f32448;
			protected static int xd2611dcb50ae5373;
			public event x26569a56dfbc2c6d xd42ce0324cbc114a;
			protected bool xdb6050a2030517f4;
			protected int xec9ddb74d7a61c81;
			protected static int xf26876fa09ed817e;
			protected xd53b20b7b4b2a08a xf4f555905eaa2330;
			protected int xf624f8e86c5ae5f1;
			protected ArrayList xfb5697071ce83988;
			protected static ImageList xfeae2ed797ae6fbc;
		#endregion
		
		#region Nested Types
		
			internal enum xaa7785f730d8dd15
			
			{
				xc8193c7d23acd6b5 = 0, 
				xc6b7ef030eabf3de = 1, 
				x649e2ad374251b5f = 2, 
				xb28a67863a680df2 = 3, 
				x0d744ab7e0897ef4 = 4, 
				xb01b2270d993e118 = 5, 
				xc1facdb08ad4967a = 6, 
				x90093f1fe3f4e055 = 7, 
			}
			
			
			internal enum xd1ffc28f5c092301
			
			{
				xa8c2637cc4888928 = 0, 
				xaea087ab32102492 = 1, 
				x79d902473861f242 = 2, 
				xd7a21e27974f626c = 3, 
				xe146aafa9a5d43a7 = 4, 
				xf449f2fd74fc17c0 = 5, 
				x8c7ce3720fbb3d3c = 6, 
				xadf3b60de56517aa = 7, 
				x0d61070bce01bfeb = 8, 
				xfe5834ce8fcb6cd3 = 9, 
				x1ba2342a92802df3 = 10, 
				xc747bfd68a2aed16 = 11, 
				x7925f2c407f6579d = 12, 
				x4314dddcd79108ff = 13, 
				xfd183ee3cea1c2de = 14, 
				x52757a7a80432bc1 = 15, 
				x90bca3df68ad3c58 = 16, 
				x7ec063672af83a2b = 17, 
				xa595d34369df14ff = 18, 
				x1304d6eba5a30020 = 19, 
				xbd4743e497c1ab76 = 20, 
				x9737c0b0ab515713 = 21, 
			}
			
			
			internal enum xf398ffaf32ffe055
			
			{
				x72d92bd1aff02e37 = 0, 
				x419ba17a5322627b = 1, 
				x95c57ee794bc0aec = 2, 
			}
			
		#endregion
		
		#region Constructors
		
			static x902c4aee45bfd906 ()
			/*
				// Code Size: 174 Bytes
				.maxstack 7
				L_0000: ldc.i4.2 
				L_0001: ldc.i4.s 22
				L_0003: newobj System.Int32[,]::Void .ctor(Int32, Int32)
				L_0008: dup 
				L_0009: ldtoken x19d54ee1f3e0c943::x80ac5cf0eba94243 x03577c027c4f46b2
				L_000e: call System.Runtime.CompilerServices.RuntimeHelpers::Void InitializeArray(System.Array, System.RuntimeFieldHandle)
				L_0013: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0018: ldc.i4 400
				L_001d: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xf26876fa09ed817e
				L_0022: ldc.i4 1100
				L_0027: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xd046a8db53f32448
				L_002c: ldc.i4.s 16
				L_002e: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb28e4e0b2e9dba92
				L_0033: ldc.i4.s 16
				L_0035: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xd2611dcb50ae5373
				L_003a: ldc.i4.4 
				L_003b: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_0040: ldc.i4.2 
				L_0041: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xc00c540f7c5833fc
				L_0046: ldc.i4.6 
				L_0047: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x65b69cc23d1d4c9e
				L_004c: ldnull 
				L_004d: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Bitmap xca1a18e48751e941
				L_0052: ldc.i4.0 
				L_0053: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xc08a10dac990c769
				L_0058: ldc.i4.0 
				L_0059: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x4a8f256947767652
				L_005e: ldnull 
				L_005f: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.ImageList xfeae2ed797ae6fbc
				L_0064: ldc.i4.0 
				L_0065: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9c8c46cd7553cd2b
				L_006a: ldstr "Sunisoft.IrisSkin.SkinEngine"
				L_006f: call System.Type::System.Type GetType(System.String)
				L_0074: ldstr "Sunisoft.IrisSkin.ImagesPopupMenu.bmp"
				L_0079: ldc.i4.s 16
				L_007b: ldc.i4.s 16
				L_007d: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_0082: ldc.i4.0 
				L_0083: ldc.i4.0 
				L_0084: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0089: call Sunisoft.IrisSkin.InternalControls.x58dd58a96343fde0::System.Windows.Forms.ImageList xd1601e45c3cc2056(System.Type, System.String, System.Drawing.Size, System.Drawing.Point)
				L_008e: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.ImageList xfeae2ed797ae6fbc
				L_0093: call System.Windows.Forms.OSFeature::System.Windows.Forms.OSFeature get_Feature()
				L_0098: ldsfld System.Windows.Forms.OSFeature::System.Object LayeredWindows
				L_009d: callvirt System.Windows.Forms.FeatureSupport::System.Version GetVersionPresent(System.Object)
				L_00a2: ldnull 
				L_00a3: call System.Version::Boolean op_Inequality(System.Version, System.Version)
				L_00a8: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9c8c46cd7553cd2b
				L_00ad: ret 
			*/
			
			public x902c4aee45bfd906 (ISkinEngine engine)
			/*
				// Code Size: 312 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: ldc.i4 1025
				L_0006: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::UInt32 x325954b88ff83482
				L_000b: ldarg.0 
				L_000c: ldc.i4 1026
				L_0011: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::UInt32 x7a0e8e68a2ddb7d3
				L_0016: ldarg.0 
				L_0017: ldc.i4.0 
				L_0018: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.RightToLeft x94975a4c4f1d71c4
				L_001d: ldarg.0 
				L_001e: call System.Windows.Forms.NativeWindow::Void .ctor()
				L_0023: ldarg.0 
				L_0024: ldarg.1 
				L_0025: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void set_xdc87e2b99332cd4a(Sunisoft.IrisSkin.SkinEngine)
				L_002a: ldarg.0 
				L_002b: newobj System.Collections.ArrayList::Void .ctor()
				L_0030: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0035: ldarg.0 
				L_0036: newobj Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Void .ctor()
				L_003b: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0040: ldarg.0 
				L_0041: ldc.i4.0 
				L_0042: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x0cd2bb383a46f073
				L_0047: ldarg.0 
				L_0048: ldc.i4.0 
				L_0049: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x3012c20deea55334
				L_004e: ldarg.0 
				L_004f: ldc.i4.0 
				L_0050: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_0055: ldarg.0 
				L_0056: ldc.i4.m1 
				L_0057: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xf624f8e86c5ae5f1
				L_005c: ldarg.0 
				L_005d: ldc.i4.m1 
				L_005e: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0063: ldarg.0 
				L_0064: ldnull 
				L_0065: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_006a: ldarg.0 
				L_006b: ldc.i4.0 
				L_006c: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_0071: ldarg.0 
				L_0072: ldc.i4.1 
				L_0073: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x8e0eb9fe60b28fae
				L_0078: ldarg.0 
				L_0079: ldc.i4.0 
				L_007a: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x753f06f9b5cd6e0d
				L_007f: ldarg.0 
				L_0080: ldc.i4.1 
				L_0081: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc1dccd328eafa426
				L_0086: ldarg.0 
				L_0087: ldc.i4.1 
				L_0088: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc8609d9b3214b3e7
				L_008d: ldarg.0 
				L_008e: ldnull 
				L_008f: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0094: ldarg.0 
				L_0095: ldc.i4.0 
				L_0096: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xec9ddb74d7a61c81
				L_009b: ldarg.0 
				L_009c: ldnull 
				L_009d: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_00a2: ldarg.0 
				L_00a3: ldnull 
				L_00a4: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_00a9: ldarg.0 
				L_00aa: ldc.i4.0 
				L_00ab: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x604ddcdfda178b5a
				L_00b0: ldarg.0 
				L_00b1: ldc.i4.0 
				L_00b2: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x86c6e3905608c757
				L_00b7: ldarg.0 
				L_00b8: ldc.i4.1 
				L_00b9: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc316f3c6d490f56e
				L_00be: ldarg.0 
				L_00bf: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x50d4e184d788ac8c
				L_00c4: ldc.i4.m1 
				L_00c5: ldc.i4.m1 
				L_00c6: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_00cb: ldarg.0 
				L_00cc: ldc.i4.1 
				L_00cd: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_00d2: ldarg.0 
				L_00d3: call System.Windows.Forms.SystemInformation::System.Drawing.Font get_MenuFont()
				L_00d8: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Font xb86af11733e6a799
				L_00dd: ldarg.0 
				L_00de: ldc.i4.s 100
				L_00e0: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x8d677ea3c0d5a202
				L_00e5: ldarg.0 
				L_00e6: ldc.i4.2 
				L_00e7: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced x1cb292d12d9bf68e
				L_00ec: ldarg.0 
				L_00ed: ldc.i4 1048576
				L_00f2: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x1f5697535eab37b9 xa89034e65472167c
				L_00f7: ldarg.0 
				L_00f8: ldc.i4.1 
				L_00f9: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x20ad2840ee62b6a4
				L_00fe: ldarg.0 
				L_00ff: ldc.i4.1 
				L_0100: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x0a7391c99fcdc469
				L_0105: ldarg.0 
				L_0106: newobj System.Windows.Forms.Timer::Void .ctor()
				L_010b: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_0110: ldarg.0 
				L_0111: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_0116: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xf26876fa09ed817e
				L_011b: callvirt System.Windows.Forms.Timer::Void set_Interval(Int32)
				L_0120: ldarg.0 
				L_0121: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_0126: ldarg.0 
				L_0127: ldftn Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x07cc1c177f7b41bd(System.Object, System.EventArgs)
				L_012d: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0132: callvirt System.Windows.Forms.Timer::Void add_Tick(System.EventHandler)
				L_0137: ret 
			*/
		#endregion
		
		#region Properties
		
			public bool x1f045c9de3a60a02
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x604ddcdfda178b5a
					L_0006: ret 
				*/
				
				{
					return this.x604ddcdfda178b5a;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x604ddcdfda178b5a
					L_0007: ret 
				*/
				
				{
					this.x604ddcdfda178b5a = value;
				}
			}
			
			
			public bool x2f5f5a028825ce32
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc316f3c6d490f56e
					L_0006: ret 
				*/
				
				{
					return this.xc316f3c6d490f56e;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc316f3c6d490f56e
					L_0007: ret 
				*/
				
				{
					this.xc316f3c6d490f56e = value;
				}
			}
			
			
			public xd53b20b7b4b2a08a x6ef5a4a9a9587cfd
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
					L_0006: ret 
				*/
				
				{
					return this.xf4f555905eaa2330;
				}
			}
			
			
			public bool x6f72c846c7dcb042
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x86c6e3905608c757
					L_0006: ret 
				*/
				
				{
					return this.x86c6e3905608c757;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x86c6e3905608c757
					L_0007: ret 
				*/
				
				{
					this.x86c6e3905608c757 = value;
				}
			}
			
			
			public x6fd23f8bad2f3ced x6fd23f8bad2f3ced
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced x1cb292d12d9bf68e
					L_0006: ret 
				*/
				
				{
					return this.x1cb292d12d9bf68e;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced x1cb292d12d9bf68e
					L_0007: ret 
				*/
				
				{
					this.x1cb292d12d9bf68e = value;
				}
			}
			
			
			public int x742a8c15ee195ce2
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x8d677ea3c0d5a202
					L_0006: ret 
				*/
				
				{
					return this.x8d677ea3c0d5a202;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x8d677ea3c0d5a202
					L_0007: ret 
				*/
				
				{
					this.x8d677ea3c0d5a202 = value;
				}
			}
			
			
			public x1f5697535eab37b9 xa743c350e27e50b4
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x1f5697535eab37b9 xa89034e65472167c
					L_0006: ret 
				*/
				
				{
					return this.xa89034e65472167c;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x1f5697535eab37b9 xa89034e65472167c
					L_0007: ret 
				*/
				
				{
					this.xa89034e65472167c = value;
				}
			}
			
			
			public Font xc2d4efc42998d87b
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Font xb86af11733e6a799
					L_0006: ret 
				*/
				
				{
					return this.xb86af11733e6a799;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Font xb86af11733e6a799
					L_0007: ret 
				*/
				
				{
					this.xb86af11733e6a799 = value;
				}
			}
			
			
			public ISkinEngine xdc87e2b99332cd4a
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
					L_0006: ret 
				*/
				
				{
					return this.xcab6a0e662ada486;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
					L_0007: ret 
				*/
				
				{
					this.xcab6a0e662ada486 = value;
				}
			}
			
		#endregion
		
		#region Methods
		
			public virtual void OnDeselected (x5f4b657f68f87baa mc)
			
			/*
				// Code Size: 63 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_0006: brfalse.s L_0015
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_000e: ldarg.1 
				L_000f: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void OnDeselected(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0014: ret 
				L_0015: ldarg.0 
				L_0016: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d xd42ce0324cbc114a
				L_001b: brfalse.s L_002a
				L_001d: ldarg.0 
				L_001e: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d xd42ce0324cbc114a
				L_0023: ldarg.1 
				L_0024: callvirt Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d::Void Invoke(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0029: ret 
				L_002a: ldarg.0 
				L_002b: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0030: brfalse.s L_003e
				L_0032: ldarg.0 
				L_0033: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0038: ldarg.1 
				L_0039: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void OnDeselected(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_003e: ret 
			*/
			
			
			{
				if (this.x37f2fc2a7f30f790 != null)
				{
					this.x37f2fc2a7f30f790.OnDeselected (mc);
				}
				else if (this.xd42ce0324cbc114a != null)
				{
					this.xd42ce0324cbc114a (mc);
				}
				else if (this.xb13f2de377f27597 != null)
				{
					this.xb13f2de377f27597.OnDeselected (mc);
				}
			}
			
			public virtual void OnSelected (x5f4b657f68f87baa mc)
			
			/*
				// Code Size: 63 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_0006: brfalse.s L_0015
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_000e: ldarg.1 
				L_000f: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void OnSelected(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0014: ret 
				L_0015: ldarg.0 
				L_0016: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d xaa7558c320af04eb
				L_001b: brfalse.s L_002a
				L_001d: ldarg.0 
				L_001e: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d xaa7558c320af04eb
				L_0023: ldarg.1 
				L_0024: callvirt Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d::Void Invoke(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0029: ret 
				L_002a: ldarg.0 
				L_002b: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0030: brfalse.s L_003e
				L_0032: ldarg.0 
				L_0033: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0038: ldarg.1 
				L_0039: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void OnSelected(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_003e: ret 
			*/
			
			
			{
				if (this.x37f2fc2a7f30f790 != null)
				{
					this.x37f2fc2a7f30f790.OnSelected (mc);
				}
				else if (this.xaa7558c320af04eb != null)
				{
					this.xaa7558c320af04eb (mc);
				}
				else if (this.xb13f2de377f27597 != null)
				{
					this.xb13f2de377f27597.OnSelected (mc);
				}
			}
			
			protected override void WndProc (ref Message m)
			
			/*
				// Code Size: 155 Bytes
				.maxstack 3
				.locals (System.UInt32 V_0)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0006: conv.i8 
				L_0007: ldarg.0 
				L_0008: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::UInt32 x325954b88ff83482
				L_000d: conv.u8 
				L_000e: bne.un.s L_0017
				L_0010: ldarg.0 
				L_0011: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xb97e8a8020dddaac()
				L_0016: ret 
				L_0017: ldarg.1 
				L_0018: call System.Windows.Forms.Message::Int32 get_Msg()
				L_001d: conv.i8 
				L_001e: ldarg.0 
				L_001f: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::UInt32 x7a0e8e68a2ddb7d3
				L_0024: conv.u8 
				L_0025: bne.un.s L_002f
				L_0027: ldarg.0 
				L_0028: ldarg.1 
				L_0029: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xbcf8eb07b7e76a62(System.Windows.Forms.Message ByRef)
				L_002e: ret 
				L_002f: ldarg.1 
				L_0030: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0035: stloc.0 
				L_0036: ldloc.0 
				L_0037: ldc.i4.s 28
				L_0039: bgt.un.s L_0047
				L_003b: ldloc.0 
				L_003c: ldc.i4.s 15
				L_003e: beq.s L_0072
				L_0040: ldloc.0 
				L_0041: ldc.i4.s 28
				L_0043: beq.s L_0062
				L_0045: br.s L_0092
				L_0047: ldloc.0 
				L_0048: ldc.i4.s 32
				L_004a: sub 
				L_004b: switch (L_007a, L_006a)
				L_0058: ldloc.0 
				L_0059: ldc.i4 132
				L_005e: beq.s L_0081
				L_0060: br.s L_0092
				L_0062: ldarg.0 
				L_0063: ldarg.1 
				L_0064: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xa68b9c37c0ff7fc5(System.Windows.Forms.Message ByRef)
				L_0069: ret 
				L_006a: ldarg.0 
				L_006b: ldarg.1 
				L_006c: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x20a824d899eb6cd8(System.Windows.Forms.Message ByRef)
				L_0071: ret 
				L_0072: ldarg.0 
				L_0073: ldarg.1 
				L_0074: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x038e1503810e39c7(System.Windows.Forms.Message ByRef)
				L_0079: ret 
				L_007a: ldarg.0 
				L_007b: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x773209141f430902()
				L_0080: ret 
				L_0081: ldarg.0 
				L_0082: ldarg.1 
				L_0083: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xddec9c21ef58186c(System.Windows.Forms.Message ByRef)
				L_0088: brtrue.s L_009a
				L_008a: ldarg.0 
				L_008b: ldarg.1 
				L_008c: call System.Windows.Forms.NativeWindow::Void WndProc(System.Windows.Forms.Message ByRef)
				L_0091: ret 
				L_0092: ldarg.0 
				L_0093: ldarg.1 
				L_0094: call System.Windows.Forms.NativeWindow::Void WndProc(System.Windows.Forms.Message ByRef)
				L_0099: ret 
				L_009a: ret 
			*/
			
			
			{
				if (((long) m.Msg) == ((long) this.x325954b88ff83482))
				{
					this.xb97e8a8020dddaac ();
					return;
				}
				if (((long) m.Msg) == ((long) this.x7a0e8e68a2ddb7d3))
				{
					this.xbcf8eb07b7e76a62 (ref m);
					return;
				}
				uint uInt32_1 = ((uint) m.Msg);
				if (uInt32_1 >= 28)
				{
					switch (uInt32_1)
					{
						case 32:
						
						{
								this.x773209141f430902 ();
								return;
						}
						case 33:
						
						{
								this.x20a824d899eb6cd8 (ref m);
								return;
						}
					}
					if (uInt32_1 == 132)
					{
						if (! this.xddec9c21ef58186c (ref m))
						{
							base.WndProc (ref m);
						}
						return;
					}
				}
				else if (uInt32_1 == 15)
				{
					this.x038e1503810e39c7 (ref m);
					return;
				}
				else if (uInt32_1 == 28)
				{
					this.xa68b9c37c0ff7fc5 (ref m);
					return;
				}
				base.WndProc (ref m);
				return;
				
				/*
					Unreachable Code
					return;
				*/
			}
			
			protected void x038e1503810e39c7 (ref Message x6088325dec1baa2a)
			
			/*
				// Code Size: 192 Bytes
				.maxstack 7
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT V_0, 
         System.IntPtr V_1, 
         Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_2, 
         System.Drawing.Rectangle V_3, 
         System.Drawing.Graphics V_4, 
         System.Drawing.Bitmap V_5, 
         System.Drawing.Graphics V_6)
				.try L_0079 to L_008c finally L_008c to L_0098
				.try L_005b to L_00a5 finally L_00a5 to L_00b1
				L_0000: ldloca.s V_0
				L_0002: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+PAINTSTRUCT
				L_0008: ldarg.1 
				L_0009: call System.Windows.Forms.Message::IntPtr get_HWnd()
				L_000e: ldloca.s V_0
				L_0010: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr BeginPaint(IntPtr, PAINTSTRUCT ByRef)
				L_0015: stloc.1 
				L_0016: ldloca.s V_2
				L_0018: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
				L_001e: ldarg.0 
				L_001f: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0024: ldloca.s V_2
				L_0026: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowRect(IntPtr, RECT ByRef)
				L_002b: pop 
				L_002c: ldloca.s V_3
				L_002e: ldc.i4.0 
				L_002f: ldc.i4.0 
				L_0030: ldloca.s V_2
				L_0032: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0037: ldloca.s V_2
				L_0039: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_003e: sub 
				L_003f: ldloca.s V_2
				L_0041: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0046: ldloca.s V_2
				L_0048: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_004d: sub 
				L_004e: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0053: ldloc.1 
				L_0054: call System.Drawing.Graphics::System.Drawing.Graphics FromHdc(IntPtr)
				L_0059: stloc.s V_4
				L_005b: ldloca.s V_3
				L_005d: call System.Drawing.Rectangle::Int32 get_Width()
				L_0062: ldloca.s V_3
				L_0064: call System.Drawing.Rectangle::Int32 get_Height()
				L_0069: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_006e: stloc.s V_5
				L_0070: ldloc.s V_5
				L_0072: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0077: stloc.s V_6
				L_0079: ldarg.0 
				L_007a: ldloc.s V_6
				L_007c: ldloc.3 
				L_007d: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x4af0f9e5d7ac184a(System.Drawing.Graphics, System.Drawing.Rectangle)
				L_0082: ldarg.0 
				L_0083: ldloc.s V_6
				L_0085: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x05a10b378cdf8119(System.Drawing.Graphics)
				L_008a: leave.s L_0098
				L_008c: ldloc.s V_6
				L_008e: brfalse.s L_0097
				L_0090: ldloc.s V_6
				L_0092: callvirt System.IDisposable::Void Dispose()
				L_0097: endfinally 
				L_0098: ldloc.s V_4
				L_009a: ldloc.s V_5
				L_009c: ldc.i4.0 
				L_009d: ldc.i4.0 
				L_009e: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_00a3: leave.s L_00b1
				L_00a5: ldloc.s V_4
				L_00a7: brfalse.s L_00b0
				L_00a9: ldloc.s V_4
				L_00ab: callvirt System.IDisposable::Void Dispose()
				L_00b0: endfinally 
				L_00b1: ldarg.1 
				L_00b2: call System.Windows.Forms.Message::IntPtr get_HWnd()
				L_00b7: ldloca.s V_0
				L_00b9: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean EndPaint(IntPtr, PAINTSTRUCT ByRef)
				L_00be: pop 
				L_00bf: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Bitmap bitmap1;
				x40255b11ef821fa3.PAINTSTRUCT pAINTSTRUCT1 = new x40255b11ef821fa3.PAINTSTRUCT ();
				IntPtr intPtr1 = x61467fe65a98f20c.BeginPaint (x6088325dec1baa2a.HWnd, out pAINTSTRUCT1);
				xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
				bool b1 = x61467fe65a98f20c.GetWindowRect (base.Handle, ref rECT1);
				rectangle1 = new Rectangle (0, 0, ((int) (rECT1.right - rECT1.left)), ((int) (rECT1.bottom - rECT1.top)));
				using (Graphics graphics1 = Graphics.FromHdc (intPtr1))
				{
					bitmap1 = new Bitmap (rectangle1.Width, rectangle1.Height);
					using (Graphics graphics2 = Graphics.FromImage (((Image) bitmap1)))
					{
						this.x4af0f9e5d7ac184a (graphics2, rectangle1);
						this.x05a10b378cdf8119 (graphics2);
					}
					graphics1.DrawImageUnscaled (((Image) bitmap1), 0, 0);
				}
				bool b2 = x61467fe65a98f20c.EndPaint (x6088325dec1baa2a.HWnd, ref pAINTSTRUCT1);
			}
			
			protected void x057464a452da34b7 ()
			
			/*
				// Code Size: 204 Bytes
				.maxstack 7
				.locals (System.Drawing.Size V_0, 
         System.Drawing.Point V_1, 
         Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_2)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0006: callvirt System.Collections.ArrayList::Void Clear()
				L_000b: ldarg.0 
				L_000c: ldc.i4.1 
				L_000d: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x86c6e3905608c757
				L_0012: ldarg.0 
				L_0013: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc316f3c6d490f56e
				L_0018: brfalse.s L_0026
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0020: ldc.i4.1 
				L_0021: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Void set_x6f72c846c7dcb042(Boolean)
				L_0026: ldarg.0 
				L_0027: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Size x4e2849ed170f5bc2()
				L_002c: stloc.0 
				L_002d: ldarg.0 
				L_002e: ldloc.0 
				L_002f: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6e375ee3ca34b13b(System.Drawing.Size)
				L_0034: stloc.1 
				L_0035: ldarg.0 
				L_0036: ldloc.1 
				L_0037: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_003c: ldarg.0 
				L_003d: ldloc.0 
				L_003e: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Size x86ef051842f1ae49
				L_0043: ldarg.0 
				L_0044: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xdb6050a2030517f4
				L_0049: brtrue.s L_00bf
				L_004b: ldarg.0 
				L_004c: ldloc.0 
				L_004d: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x1803d70928e3ae9b(System.Drawing.Size)
				L_0052: ldarg.0 
				L_0053: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0058: ldloca.s V_1
				L_005a: call System.Drawing.Point::Int32 get_X()
				L_005f: ldloca.s V_1
				L_0061: call System.Drawing.Point::Int32 get_Y()
				L_0066: ldloca.s V_0
				L_0068: call System.Drawing.Size::Int32 get_Width()
				L_006d: ldloca.s V_0
				L_006f: call System.Drawing.Size::Int32 get_Height()
				L_0074: ldc.i4.1 
				L_0075: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean MoveWindow(IntPtr, Int32, Int32, Int32, Int32, Boolean)
				L_007a: pop 
				L_007b: ldloca.s V_2
				L_007d: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
				L_0083: ldloca.s V_2
				L_0085: ldc.i4.0 
				L_0086: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_008b: ldloca.s V_2
				L_008d: ldc.i4.0 
				L_008e: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0093: ldloca.s V_2
				L_0095: ldloca.s V_0
				L_0097: call System.Drawing.Size::Int32 get_Width()
				L_009c: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_00a1: ldloca.s V_2
				L_00a3: ldloca.s V_0
				L_00a5: call System.Drawing.Size::Int32 get_Height()
				L_00aa: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_00af: ldarg.0 
				L_00b0: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_00b5: ldloca.s V_2
				L_00b7: ldc.i4.1 
				L_00b8: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean InvalidateRect(IntPtr, RECT ByRef, Boolean)
				L_00bd: pop 
				L_00be: ret 
				L_00bf: ldarg.0 
				L_00c0: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x9119fce83e4631ad()
				L_00c5: ldarg.0 
				L_00c6: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x95f5f55ee201fb8f()
				L_00cb: ret 
			*/
			
			
			{
				xae4dd1cafd2eb77c.RECT rECT1;
				this.xfb5697071ce83988.Clear ();
				this.x86c6e3905608c757 = true;
				if (this.xc316f3c6d490f56e)
				{
					this.xf4f555905eaa2330.x6f72c846c7dcb042 = true;
				}
				Size size1 = this.x4e2849ed170f5bc2 ();
				Point point1 = this.x6e375ee3ca34b13b (size1);
				this.x6941e4b46c92846d = point1;
				this.x86ef051842f1ae49 = size1;
				if (! this.xdb6050a2030517f4)
				{
					this.x1803d70928e3ae9b (size1);
					bool b1 = x61467fe65a98f20c.MoveWindow (base.Handle, point1.X, point1.Y, size1.Width, size1.Height, true);
					rECT1 = new xae4dd1cafd2eb77c.RECT ();
					rECT1.left = 0;
					rECT1.top = 0;
					rECT1.right = size1.Width;
					rECT1.bottom = size1.Height;
					bool b2 = x61467fe65a98f20c.InvalidateRect (base.Handle, ref rECT1, true);
				}
				else
				{
					this.x9119fce83e4631ad ();
					this.x95f5f55ee201fb8f ();
				}
			}
			
			protected void x05a10b378cdf8119 (Graphics x4b101060f4767186)
			
			/*
				// Code Size: 58 Bytes
				.maxstack 6
				.locals (System.Int32 V_0, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_1)
				L_0000: ldc.i4.0 
				L_0001: stloc.0 
				L_0002: br.s L_002b
				L_0004: ldarg.0 
				L_0005: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_000a: ldloc.0 
				L_000b: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0010: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0015: stloc.1 
				L_0016: ldarg.0 
				L_0017: ldarg.1 
				L_0018: ldloc.1 
				L_0019: ldloc.0 
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0020: ceq 
				L_0022: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xb5a5bdae3ba8936b(System.Drawing.Graphics, Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f, Boolean)
				L_0027: ldloc.0 
				L_0028: ldc.i4.1 
				L_0029: add 
				L_002a: stloc.0 
				L_002b: ldloc.0 
				L_002c: ldarg.0 
				L_002d: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0032: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_0037: blt.s L_0004
				L_0039: ret 
			*/
			
			
			{
				int i1;
				x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				for (i1 = 0; (i1 < this.xfb5697071ce83988.Count); i1++)
				{
					x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[i1] as x2cc390e9409b0f3f);
					this.xb5a5bdae3ba8936b (x4b101060f4767186, x2cc390e9409b0f3f1, (i1 == this.xb266b78561d63b52));
				}
			}
			
			protected void x0760506d6abf77a2 (int xf624f8e86c5ae5f1, bool xacc37ebdd71fcc44)
			
			/*
				// Code Size: 27 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0006: ldarg.0 
				L_0007: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::UInt32 x7a0e8e68a2ddb7d3
				L_000c: ldarg.1 
				L_000d: ldarg.2 
				L_000e: brtrue.s L_0013
				L_0010: ldc.i4.0 
				L_0011: br.s L_0014
				L_0013: ldc.i4.1 
				L_0014: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_0019: pop 
				L_001a: ret 
			*/
			
			
			{
				bool b1 = x61467fe65a98f20c.PostMessage (base.Handle, this.x7a0e8e68a2ddb7d3, ((uint) xf624f8e86c5ae5f1), ((uint) (xacc37ebdd71fcc44 ? 1 : 0)));
			}
			
			protected void x07cc1c177f7b41bd (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 136 Bytes
				.maxstack 5
				.locals (System.Boolean V_0, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_1)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_0006: callvirt System.Windows.Forms.Timer::Void Stop()
				L_000b: ldc.i4.1 
				L_000c: stloc.0 
				L_000d: ldarg.0 
				L_000e: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_0013: brfalse.s L_0040
				L_0015: ldarg.0 
				L_0016: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xf624f8e86c5ae5f1
				L_001b: ldarg.0 
				L_001c: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0021: beq.s L_003e
				L_0023: ldarg.0 
				L_0024: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_0029: callvirt System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_002e: ldarg.0 
				L_002f: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::UInt32 x325954b88ff83482
				L_0034: ldc.i4.0 
				L_0035: ldc.i4.0 
				L_0036: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_003b: pop 
				L_003c: br.s L_0040
				L_003e: ldc.i4.0 
				L_003f: stloc.0 
				L_0040: ldloc.0 
				L_0041: brfalse.s L_0087
				L_0043: ldarg.0 
				L_0044: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0049: ldc.i4.m1 
				L_004a: beq.s L_0087
				L_004c: ldarg.0 
				L_004d: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0052: ldarg.0 
				L_0053: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0058: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_005d: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0062: stloc.1 
				L_0063: ldloc.1 
				L_0064: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x649e2ad374251b5f()
				L_0069: brfalse.s L_0079
				L_006b: ldarg.0 
				L_006c: ldarg.0 
				L_006d: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0072: ldc.i4.0 
				L_0073: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x0760506d6abf77a2(Int32, Boolean)
				L_0078: ret 
				L_0079: ldloc.1 
				L_007a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xc1facdb08ad4967a()
				L_007f: brfalse.s L_0087
				L_0081: ldarg.0 
				L_0082: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x057464a452da34b7()
				L_0087: ret 
			*/
			
			
			{
				this.x420067493d7ebb36.Stop ();
				bool b1 = true;
				if (this.x5142fa1a3d9591c8 != null)
				{
					if (this.xf624f8e86c5ae5f1 == this.xb266b78561d63b52)
					{
						b1 = false;
					}
					else
					{
						bool b2 = x61467fe65a98f20c.PostMessage (this.x5142fa1a3d9591c8.Handle, this.x325954b88ff83482, uint.MinValue, uint.MinValue);
					}
				}
				if ((! b1) || (this.xb266b78561d63b52 == -1))
				{
					return;
				}
				x2cc390e9409b0f3f x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[this.xb266b78561d63b52] as x2cc390e9409b0f3f);
				if (x2cc390e9409b0f3f1.x649e2ad374251b5f)
				{
					this.x0760506d6abf77a2 (this.xb266b78561d63b52, false);
				}
				else if (x2cc390e9409b0f3f1.xc1facdb08ad4967a)
				{
					this.x057464a452da34b7 ();
				}
			}
			
			protected void x0e37e200024f43ba ()
			
			/*
				// Code Size: 310 Bytes
				.maxstack 6
				.locals (System.Boolean V_0, 
         System.Boolean V_1, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_8, 
         System.Int32 V_9, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_10)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0006: brtrue.s L_0016
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_000e: ldnull 
				L_000f: ceq 
				L_0011: ldc.i4.0 
				L_0012: ceq 
				L_0014: br.s L_0017
				L_0016: ldc.i4.1 
				L_0017: stloc.0 
				L_0018: ldc.i4.0 
				L_0019: stloc.1 
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0020: ldc.i4.m1 
				L_0021: beq L_00f1
				L_0026: ldarg.0 
				L_0027: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_002c: ldarg.0 
				L_002d: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0032: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0037: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_003c: stloc.2 
				L_003d: ldloc.2 
				L_003e: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 get_x2f00dc9f5cd11802()
				L_0043: stloc.3 
				L_0044: ldloc.2 
				L_0045: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 get_xa19781cfbe8b4961()
				L_004a: stloc.s V_4
				L_004c: ldloc.3 
				L_004d: ldc.i4.0 
				L_004e: ble L_00ed
				L_0053: ldc.i4.m1 
				L_0054: stloc.s V_5
				L_0056: ldc.i4.m1 
				L_0057: stloc.s V_6
				L_0059: ldloc.3 
				L_005a: ldc.i4.1 
				L_005b: sub 
				L_005c: stloc.s V_7
				L_005e: ldnull 
				L_005f: stloc.s V_8
				L_0061: ldc.i4.0 
				L_0062: stloc.s V_9
				L_0064: br.s L_00c4
				L_0066: ldarg.0 
				L_0067: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_006c: ldloc.s V_9
				L_006e: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0073: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0078: stloc.s V_10
				L_007a: ldloc.s V_10
				L_007c: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 get_x2f00dc9f5cd11802()
				L_0081: ldloc.s V_7
				L_0083: bne.un.s L_00be
				L_0085: ldloc.s V_10
				L_0087: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 get_xa19781cfbe8b4961()
				L_008c: ldloc.s V_4
				L_008e: bgt.s L_00be
				L_0090: ldloc.s V_10
				L_0092: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 get_xa19781cfbe8b4961()
				L_0097: ldloc.s V_6
				L_0099: ble.s L_00be
				L_009b: ldloc.s V_10
				L_009d: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x43604484a3deae4f()
				L_00a2: brtrue.s L_00be
				L_00a4: ldloc.s V_10
				L_00a6: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x9f2c0dc847992f03()
				L_00ab: brfalse.s L_00be
				L_00ad: ldloc.s V_10
				L_00af: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 get_xa19781cfbe8b4961()
				L_00b4: stloc.s V_6
				L_00b6: ldloc.s V_10
				L_00b8: stloc.s V_8
				L_00ba: ldloc.s V_9
				L_00bc: stloc.s V_5
				L_00be: ldloc.s V_9
				L_00c0: ldc.i4.1 
				L_00c1: add 
				L_00c2: stloc.s V_9
				L_00c4: ldloc.s V_9
				L_00c6: ldarg.0 
				L_00c7: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_00cc: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_00d1: blt.s L_0066
				L_00d3: ldloc.s V_8
				L_00d5: brfalse.s L_00e9
				L_00d7: ldarg.0 
				L_00d8: ldarg.0 
				L_00d9: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_00de: ldloc.s V_5
				L_00e0: ldc.i4.0 
				L_00e1: ldc.i4.0 
				L_00e2: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xeb515a5b77846afe(Int32, Int32, Boolean, Boolean)
				L_00e7: br.s L_0107
				L_00e9: ldc.i4.1 
				L_00ea: stloc.1 
				L_00eb: br.s L_0107
				L_00ed: ldc.i4.1 
				L_00ee: stloc.1 
				L_00ef: br.s L_0107
				L_00f1: ldarg.0 
				L_00f2: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_00f7: brfalse.s L_0105
				L_00f9: ldarg.0 
				L_00fa: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x5437d760e9a6340b()
				L_00ff: brtrue.s L_0107
				L_0101: ldc.i4.1 
				L_0102: stloc.1 
				L_0103: br.s L_0107
				L_0105: ldc.i4.1 
				L_0106: stloc.1 
				L_0107: ldloc.0 
				L_0108: brfalse.s L_0135
				L_010a: ldloc.1 
				L_010b: brfalse.s L_0135
				L_010d: ldarg.0 
				L_010e: ldnull 
				L_010f: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_0114: ldarg.0 
				L_0115: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_011a: callvirt System.Windows.Forms.Timer::Void Stop()
				L_011f: ldarg.0 
				L_0120: ldc.i4.1 
				L_0121: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_0126: ldarg.0 
				L_0127: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_012c: brtrue.s L_0135
				L_012e: ldarg.0 
				L_012f: ldc.i4.m1 
				L_0130: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x0cd2bb383a46f073
				L_0135: ret 
			*/
			
			
			{
				x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				int i1;
				int i2;
				int i3;
				int i4;
				int i5;
				x2cc390e9409b0f3f x2cc390e9409b0f3f2;
				int i6;
				x2cc390e9409b0f3f x2cc390e9409b0f3f3;
				bool b1 = ((this.xb13f2de377f27597 != null) || (this.x37f2fc2a7f30f790 != null));
				bool b2 = false;
				if (this.xb266b78561d63b52 != -1)
				{
					x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[this.xb266b78561d63b52] as x2cc390e9409b0f3f);
					i1 = x2cc390e9409b0f3f1.x2f00dc9f5cd11802;
					i2 = x2cc390e9409b0f3f1.xa19781cfbe8b4961;
					if (i1 > 0)
					{
						i3 = -1;
						i4 = -1;
						i5 = (i1 - 1);
						x2cc390e9409b0f3f2 = ((x2cc390e9409b0f3f) null);
						for (i6 = 0; (i6 < this.xfb5697071ce83988.Count); i6++)
						{
							x2cc390e9409b0f3f3 = (this.xfb5697071ce83988[i6] as x2cc390e9409b0f3f);
							if (((((x2cc390e9409b0f3f3.x2f00dc9f5cd11802 == i5) && (x2cc390e9409b0f3f3.xa19781cfbe8b4961 <= i2)) && (x2cc390e9409b0f3f3.xa19781cfbe8b4961 > i4)) && (! x2cc390e9409b0f3f3.x43604484a3deae4f)) && x2cc390e9409b0f3f3.x9f2c0dc847992f03)
							{
								i4 = x2cc390e9409b0f3f3.xa19781cfbe8b4961;
								x2cc390e9409b0f3f2 = x2cc390e9409b0f3f3;
								i3 = i6;
							}
						}
						if (x2cc390e9409b0f3f2 != null)
						{
							this.xeb515a5b77846afe (this.xb266b78561d63b52, i3, false, false);
						}
						else
						{
							b2 = true;
						}
					}
					else
					{
						b2 = true;
					}
				}
				else if (this.xb13f2de377f27597 == null)
				{
					b2 = true;
				}
				else
				{
					b2 |= (! this.x5437d760e9a6340b ());
				}
				if (b1 && b2)
				{
					this.x4547ebd0fd2a7079 = ((x5f4b657f68f87baa) null);
					this.x420067493d7ebb36.Stop ();
					this.x9a75ed38d1972c87 = true;
					if (this.xb13f2de377f27597 == null)
					{
						this.x0cd2bb383a46f073 = -1;
					}
				}
			}
			
			protected Point x1339f634e34e0e03 (Size x001544edc57babc2)
			
			/*
				// Code Size: 86 Bytes
				.maxstack 6
				.locals (System.Drawing.Point V_0)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x07658cf2bdd49693
				L_0006: call System.Windows.Forms.Screen::System.Drawing.Rectangle GetWorkingArea(System.Drawing.Point)
				L_000b: pop 
				L_000c: ldarg.0 
				L_000d: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x07658cf2bdd49693
				L_0012: stloc.0 
				L_0013: ldarg.0 
				L_0014: ldc.i4.1 
				L_0015: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc1dccd328eafa426
				L_001a: ldarg.0 
				L_001b: ldc.i4.0 
				L_001c: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xec9ddb74d7a61c81
				L_0021: ldarga.s x001544edc57babc2
				L_0023: dup 
				L_0024: call System.Drawing.Size::Int32 get_Width()
				L_0029: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_002e: ldc.i4.0 
				L_002f: ldc.i4.s 16
				L_0031: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0036: sub 
				L_0037: call System.Drawing.Size::Void set_Width(Int32)
				L_003c: ldloca.s V_0
				L_003e: ldloca.s V_0
				L_0040: call System.Drawing.Point::Int32 get_Y()
				L_0045: ldarga.s x001544edc57babc2
				L_0047: call System.Drawing.Size::Int32 get_Height()
				L_004c: sub 
				L_004d: ldc.i4.3 
				L_004e: add 
				L_004f: call System.Drawing.Point::Void set_Y(Int32)
				L_0054: ldloc.0 
				L_0055: ret 
			*/
			
			
			{
				Rectangle rectangle1 = Screen.GetWorkingArea (this.x07658cf2bdd49693);
				Point point1 = this.x07658cf2bdd49693;
				this.xc1dccd328eafa426 = true;
				this.xec9ddb74d7a61c81 = 0;
				x001544edc57babc2.Width -= x902c4aee45bfd906._x13d4cb8d1bd20347[0, 16];
				point1.Y = ((point1.Y - x001544edc57babc2.Height) + 3);
				return point1;
			}
			
			protected void x136735fdfe6d04ea (int x75cf7df8c59ffa4d, int xc13ed6de98262a2d)
			
			/*
				// Code Size: 168 Bytes
				.maxstack 6
				.locals (System.Drawing.Point V_0, 
         System.Int32 V_1, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_2, 
         System.Drawing.Rectangle V_3)
				L_0000: ldarg.1 
				L_0001: ldarg.0 
				L_0002: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0007: call System.Drawing.Point::Int32 get_X()
				L_000c: sub 
				L_000d: starg.s x75cf7df8c59ffa4d
				L_000f: ldarg.2 
				L_0010: ldarg.0 
				L_0011: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0016: call System.Drawing.Point::Int32 get_Y()
				L_001b: sub 
				L_001c: starg.s xc13ed6de98262a2d
				L_001e: ldarg.0 
				L_001f: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0024: brfalse.s L_0031
				L_0026: ldarg.0 
				L_0027: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_002c: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x76a103c0a87eb01c()
				L_0031: ldarg.0 
				L_0032: ldc.i4.1 
				L_0033: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x753f06f9b5cd6e0d
				L_0038: ldloca.s V_0
				L_003a: ldarg.1 
				L_003b: ldarg.2 
				L_003c: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0041: ldarg.0 
				L_0042: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x50d4e184d788ac8c
				L_0047: ldloc.0 
				L_0048: call System.Drawing.Point::Boolean op_Inequality(System.Drawing.Point, System.Drawing.Point)
				L_004d: brfalse.s L_00a7
				L_004f: ldc.i4.0 
				L_0050: stloc.1 
				L_0051: br.s L_0092
				L_0053: ldarg.0 
				L_0054: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0059: ldloc.1 
				L_005a: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_005f: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0064: stloc.2 
				L_0065: ldloc.2 
				L_0066: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_006b: stloc.3 
				L_006c: ldloca.s V_3
				L_006e: ldloc.0 
				L_006f: call System.Drawing.Rectangle::Boolean Contains(System.Drawing.Point)
				L_0074: brfalse.s L_008e
				L_0076: ldarg.0 
				L_0077: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_007c: ldloc.1 
				L_007d: beq.s L_008e
				L_007f: ldarg.0 
				L_0080: ldarg.0 
				L_0081: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0086: ldloc.1 
				L_0087: ldc.i4.1 
				L_0088: ldc.i4.0 
				L_0089: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xeb515a5b77846afe(Int32, Int32, Boolean, Boolean)
				L_008e: ldloc.1 
				L_008f: ldc.i4.1 
				L_0090: add 
				L_0091: stloc.1 
				L_0092: ldloc.1 
				L_0093: ldarg.0 
				L_0094: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0099: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_009e: blt.s L_0053
				L_00a0: ldarg.0 
				L_00a1: ldloc.0 
				L_00a2: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x50d4e184d788ac8c
				L_00a7: ret 
			*/
			
			
			{
				Point point1;
				int i1;
				x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				x75cf7df8c59ffa4d -= this.x6941e4b46c92846d.X;
				xc13ed6de98262a2d -= this.x6941e4b46c92846d.Y;
				if (this.xb13f2de377f27597 != null)
				{
					this.xb13f2de377f27597.x76a103c0a87eb01c ();
				}
				this.x753f06f9b5cd6e0d = true;
				point1 = new Point (x75cf7df8c59ffa4d, xc13ed6de98262a2d);
				if (this.x50d4e184d788ac8c != point1)
				{
					for (i1 = 0; (i1 < this.xfb5697071ce83988.Count); i1++)
					{
						x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[i1] as x2cc390e9409b0f3f);
						if (x2cc390e9409b0f3f1.xee63d905da8ff550.Contains (point1) && (this.xb266b78561d63b52 != i1))
						{
							this.xeb515a5b77846afe (this.xb266b78561d63b52, i1, true, false);
						}
					}
					this.x50d4e184d788ac8c = point1;
				}
			}
			
			protected void x1803d70928e3ae9b (Size x001544edc57babc2)
			
			/*
				// Code Size: 147 Bytes
				.maxstack 7
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Drawing.Region V_2, 
         System.Drawing.Graphics V_3)
				.try L_0072 to L_0088 finally L_0088 to L_0092
				L_0000: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0005: ldc.i4.0 
				L_0006: ldc.i4.s 17
				L_0008: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_000d: stloc.0 
				L_000e: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0013: ldc.i4.0 
				L_0014: ldc.i4.s 16
				L_0016: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_001b: stloc.1 
				L_001c: newobj System.Drawing.Region::Void .ctor()
				L_0021: stloc.2 
				L_0022: ldloc.2 
				L_0023: callvirt System.Drawing.Region::Void MakeInfinite()
				L_0028: ldloc.2 
				L_0029: ldarga.s x001544edc57babc2
				L_002b: call System.Drawing.Size::Int32 get_Width()
				L_0030: ldloc.1 
				L_0031: sub 
				L_0032: ldc.i4.0 
				L_0033: ldloc.1 
				L_0034: ldloc.0 
				L_0035: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_003a: callvirt System.Drawing.Region::Void Xor(System.Drawing.Rectangle)
				L_003f: ldarg.0 
				L_0040: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_0045: brtrue.s L_004f
				L_0047: ldarg.0 
				L_0048: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc1dccd328eafa426
				L_004d: brfalse.s L_0066
				L_004f: ldloc.2 
				L_0050: ldc.i4.0 
				L_0051: ldarga.s x001544edc57babc2
				L_0053: call System.Drawing.Size::Int32 get_Height()
				L_0058: ldloc.0 
				L_0059: sub 
				L_005a: ldloc.1 
				L_005b: ldloc.0 
				L_005c: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0061: callvirt System.Drawing.Region::Void Xor(System.Drawing.Rectangle)
				L_0066: ldarg.0 
				L_0067: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_006c: call System.Drawing.Graphics::System.Drawing.Graphics FromHwnd(IntPtr)
				L_0071: stloc.3 
				L_0072: ldarg.0 
				L_0073: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0078: ldloc.2 
				L_0079: ldloc.3 
				L_007a: callvirt System.Drawing.Region::IntPtr GetHrgn(System.Drawing.Graphics)
				L_007f: ldc.i4.0 
				L_0080: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 SetWindowRgn(IntPtr, IntPtr, Boolean)
				L_0085: pop 
				L_0086: leave.s L_0092
				L_0088: ldloc.3 
				L_0089: brfalse.s L_0091
				L_008b: ldloc.3 
				L_008c: callvirt System.IDisposable::Void Dispose()
				L_0091: endfinally 
				L_0092: ret 
			*/
			
			
			{
				int i1 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 17];
				int i2 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 16];
				Region region1 = new Region ();
				region1.MakeInfinite ();
				region1.Xor (new Rectangle (((int) (x001544edc57babc2.Width - i2)), 0, i2, i1));
				if ((this.x23e85093ba3a7d1d != xdbfa333b4cd503e0.x61c108cc44ef385a) || this.xc1dccd328eafa426)
				{
					region1.Xor (new Rectangle (0, ((int) (x001544edc57babc2.Height - i1)), i2, i1));
				}
				using (Graphics graphics1 = Graphics.FromHwnd (base.Handle))
				{
					int i3 = x61467fe65a98f20c.SetWindowRgn (base.Handle, region1.GetHrgn (graphics1), false);
				}
			}
			
			protected void x20a824d899eb6cd8 (ref Message x6088325dec1baa2a)
			
			/*
				// Code Size: 13 Bytes
				.maxstack 9
				L_0000: ldarg.1 
				L_0001: ldc.i4.3 
				L_0002: call System.IntPtr::IntPtr op_Explicit(Int32)
				L_0007: call System.Windows.Forms.Message::Void set_Result(IntPtr)
				L_000c: ret 
			*/
			
			
			{
				x6088325dec1baa2a.Result = ((IntPtr) 3);
			}
			
			protected bool x277ff37e12aff68b (x555516122dcc901e.POINT x0ce73f6cbd7d5515, ref x40255b11ef821fa3.MSG x8a41fbc87a3fb305)
			
			/*
				// Code Size: 116 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_0)
				L_0000: ldarg.2 
				L_0001: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0006: ldc.i4 512
				L_000b: bne.un.s L_0072
				L_000d: ldarg.0 
				L_000e: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_0013: brfalse.s L_0072
				L_0015: ldloca.s V_0
				L_0017: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
				L_001d: ldarg.0 
				L_001e: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_0023: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_0028: ldloca.s V_0
				L_002a: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowRect(IntPtr, RECT ByRef)
				L_002f: pop 
				L_0030: ldarga.s x0ce73f6cbd7d5515
				L_0032: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0037: ldloca.s V_0
				L_0039: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_003e: blt.s L_0072
				L_0040: ldarga.s x0ce73f6cbd7d5515
				L_0042: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0047: ldloca.s V_0
				L_0049: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_004e: bgt.s L_0072
				L_0050: ldarga.s x0ce73f6cbd7d5515
				L_0052: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_0057: ldloca.s V_0
				L_0059: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_005e: blt.s L_0072
				L_0060: ldarga.s x0ce73f6cbd7d5515
				L_0062: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_0067: ldloca.s V_0
				L_0069: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_006e: bgt.s L_0072
				L_0070: ldc.i4.1 
				L_0071: ret 
				L_0072: ldc.i4.0 
				L_0073: ret 
			*/
			
			
			{
				if (x8a41fbc87a3fb305.message != 512)
				{
					return false;
				}
				if (this.x37f2fc2a7f30f790 == null)
				{
					return false;
				}
				xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
				bool b1 = x61467fe65a98f20c.GetWindowRect (this.x37f2fc2a7f30f790.Handle, ref rECT1);
				if (x0ce73f6cbd7d5515.x < rECT1.left)
				{
					return false;
				}
				else if (x0ce73f6cbd7d5515.x > rECT1.right)
				{
					return false;
				}
				else if (x0ce73f6cbd7d5515.y < rECT1.top)
				{
					return false;
				}
				else if (x0ce73f6cbd7d5515.y > rECT1.bottom)
				{
					return false;
				}
				else
				{
					return true;
				}
			}
			
			internal x902c4aee45bfd906 x3c6f7570c20e3f7d (x555516122dcc901e.POINT x0ce73f6cbd7d5515, ref x40255b11ef821fa3.MSG x8a41fbc87a3fb305)
			
			/*
				// Code Size: 23 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0006: brfalse.s L_0015
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_000e: ldarg.1 
				L_000f: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xcb534454d6825379(POINT)
				L_0014: ret 
				L_0015: ldnull 
				L_0016: ret 
			*/
			
			
			{
				if (this.xb13f2de377f27597 == null)
				{
					return null;
				}
				else
				{
					return this.xb13f2de377f27597.xcb534454d6825379 (x0ce73f6cbd7d5515);
				}
			}
			
			protected void x4139e66e6dfaac52 ()
			
			/*
				// Code Size: 14 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0006: ldc.i4.0 
				L_0007: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ShowWindow(IntPtr, Int16)
				L_000c: pop 
				L_000d: ret 
			*/
			
			
			{
				int i1 = x61467fe65a98f20c.ShowWindow (base.Handle, 0);
			}
			
			protected void x4af0f9e5d7ac184a (Graphics x4b101060f4767186, Rectangle x3821770539095b42)
			
			/*
				// Code Size: 1204 Bytes
				.maxstack 9
				.locals (System.Drawing.Brush V_0, 
         System.Drawing.Rectangle V_1, 
         System.Int32 V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Drawing.Pen V_6, 
         System.Drawing.Rectangle V_7, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_8, 
         System.Int32 V_9, 
         System.Int32 V_10, 
         System.Int32 V_11, 
         System.Int32 V_12, 
         System.Int32 V_13, 
         System.Int32 V_14, 
         System.Int32 V_15, 
         System.Collections.IEnumerator V_16, 
         System.Drawing.Rectangle V_17, 
         System.IDisposable V_18)
				.try L_00e2 to L_02c8 finally L_02c8 to L_02d4
				.try L_0304 to L_035e finally L_035e to L_0373
				L_0000: ldloca.s V_1
				L_0002: ldc.i4.0 
				L_0003: ldc.i4.0 
				L_0004: ldarga.s x3821770539095b42
				L_0006: call System.Drawing.Rectangle::Int32 get_Width()
				L_000b: ldc.i4.1 
				L_000c: sub 
				L_000d: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0012: ldc.i4.0 
				L_0013: ldc.i4.s 16
				L_0015: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_001a: sub 
				L_001b: ldarga.s x3821770539095b42
				L_001d: call System.Drawing.Rectangle::Int32 get_Height()
				L_0022: ldc.i4.1 
				L_0023: sub 
				L_0024: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0029: ldc.i4.0 
				L_002a: ldc.i4.s 17
				L_002c: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0031: sub 
				L_0032: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0037: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_003c: ldc.i4.0 
				L_003d: ldc.i4.5 
				L_003e: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0043: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb28e4e0b2e9dba92
				L_0048: add 
				L_0049: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_004e: ldc.i4.0 
				L_004f: ldc.i4.7 
				L_0050: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0055: add 
				L_0056: stloc.2 
				L_0057: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_005c: ldc.i4.0 
				L_005d: ldc.i4.1 
				L_005e: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0063: stloc.3 
				L_0064: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0069: ldc.i4.0 
				L_006a: ldc.i4.0 
				L_006b: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0070: stloc.s V_4
				L_0072: ldloca.s V_1
				L_0074: call System.Drawing.Rectangle::Int32 get_Height()
				L_0079: ldloc.s V_4
				L_007b: sub 
				L_007c: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0081: ldc.i4.0 
				L_0082: ldc.i4.2 
				L_0083: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0088: sub 
				L_0089: ldc.i4.1 
				L_008a: sub 
				L_008b: stloc.s V_5
				L_008d: ldarg.0 
				L_008e: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0093: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0098: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_009d: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_MENUITEMCOLOR()
				L_00a2: stloc.0 
				L_00a3: ldarg.1 
				L_00a4: ldloc.0 
				L_00a5: ldloc.1 
				L_00a6: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_00ab: ldarg.0 
				L_00ac: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_00b1: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00b6: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_00bb: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_LEFTBARSTARTCOLOR()
				L_00c0: stloc.0 
				L_00c1: ldarg.0 
				L_00c2: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_00c7: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00cc: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_00d1: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUITEMCOLOR
				L_00d6: call System.Windows.Forms.ControlPaint::System.Drawing.Color Dark(System.Drawing.Color)
				L_00db: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_00e0: stloc.s V_6
				L_00e2: ldarg.1 
				L_00e3: ldloc.s V_6
				L_00e5: ldloc.1 
				L_00e6: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_00eb: ldarg.0 
				L_00ec: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_00f1: ldc.i4.0 
				L_00f2: ble L_02c6
				L_00f7: ldarg.0 
				L_00f8: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_00fd: ldc.i4.1 
				L_00fe: bne.un L_01b9
				L_0103: ldarg.0 
				L_0104: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc1dccd328eafa426
				L_0109: brfalse.s L_0162
				L_010b: ldarg.1 
				L_010c: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_0111: ldloca.s V_1
				L_0113: call System.Drawing.Rectangle::Int32 get_Left()
				L_0118: ldc.i4.1 
				L_0119: add 
				L_011a: ldarg.0 
				L_011b: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xec9ddb74d7a61c81
				L_0120: add 
				L_0121: ldloca.s V_1
				L_0123: call System.Drawing.Rectangle::Int32 get_Top()
				L_0128: ldarg.0 
				L_0129: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_012e: ldc.i4.1 
				L_012f: sub 
				L_0130: ldc.i4.1 
				L_0131: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_0136: ldarg.1 
				L_0137: ldloc.0 
				L_0138: ldloca.s V_1
				L_013a: call System.Drawing.Rectangle::Int32 get_Left()
				L_013f: ldc.i4.1 
				L_0140: add 
				L_0141: ldarg.0 
				L_0142: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xec9ddb74d7a61c81
				L_0147: add 
				L_0148: ldloca.s V_1
				L_014a: call System.Drawing.Rectangle::Int32 get_Top()
				L_014f: ldarg.0 
				L_0150: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_0155: ldc.i4.1 
				L_0156: sub 
				L_0157: ldc.i4.1 
				L_0158: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_015d: br L_02c6
				L_0162: ldarg.1 
				L_0163: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_0168: ldloca.s V_1
				L_016a: call System.Drawing.Rectangle::Int32 get_Left()
				L_016f: ldc.i4.1 
				L_0170: add 
				L_0171: ldarg.0 
				L_0172: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xec9ddb74d7a61c81
				L_0177: add 
				L_0178: ldloca.s V_1
				L_017a: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_017f: ldarg.0 
				L_0180: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_0185: ldc.i4.1 
				L_0186: sub 
				L_0187: ldc.i4.1 
				L_0188: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_018d: ldarg.1 
				L_018e: ldloc.0 
				L_018f: ldloca.s V_1
				L_0191: call System.Drawing.Rectangle::Int32 get_Left()
				L_0196: ldc.i4.1 
				L_0197: add 
				L_0198: ldarg.0 
				L_0199: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xec9ddb74d7a61c81
				L_019e: add 
				L_019f: ldloca.s V_1
				L_01a1: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_01a6: ldarg.0 
				L_01a7: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_01ac: ldc.i4.1 
				L_01ad: sub 
				L_01ae: ldc.i4.1 
				L_01af: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_01b4: br L_02c6
				L_01b9: ldarg.0 
				L_01ba: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc1dccd328eafa426
				L_01bf: brfalse.s L_0218
				L_01c1: ldarg.1 
				L_01c2: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_01c7: ldloca.s V_1
				L_01c9: call System.Drawing.Rectangle::Int32 get_Left()
				L_01ce: ldloca.s V_1
				L_01d0: call System.Drawing.Rectangle::Int32 get_Top()
				L_01d5: ldc.i4.1 
				L_01d6: add 
				L_01d7: ldarg.0 
				L_01d8: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xec9ddb74d7a61c81
				L_01dd: add 
				L_01de: ldc.i4.1 
				L_01df: ldarg.0 
				L_01e0: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_01e5: ldc.i4.1 
				L_01e6: sub 
				L_01e7: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_01ec: ldarg.1 
				L_01ed: ldloc.0 
				L_01ee: ldloca.s V_1
				L_01f0: call System.Drawing.Rectangle::Int32 get_Left()
				L_01f5: ldloca.s V_1
				L_01f7: call System.Drawing.Rectangle::Int32 get_Top()
				L_01fc: ldc.i4.1 
				L_01fd: add 
				L_01fe: ldarg.0 
				L_01ff: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xec9ddb74d7a61c81
				L_0204: add 
				L_0205: ldc.i4.1 
				L_0206: ldarg.0 
				L_0207: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_020c: ldc.i4.1 
				L_020d: sub 
				L_020e: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_0213: br L_02c6
				L_0218: ldarg.0 
				L_0219: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x8e0eb9fe60b28fae
				L_021e: brfalse.s L_0274
				L_0220: ldarg.1 
				L_0221: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_0226: ldloca.s V_1
				L_0228: call System.Drawing.Rectangle::Int32 get_Left()
				L_022d: ldloca.s V_1
				L_022f: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0234: ldc.i4.1 
				L_0235: sub 
				L_0236: ldarg.0 
				L_0237: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xec9ddb74d7a61c81
				L_023c: sub 
				L_023d: ldc.i4.1 
				L_023e: ldarg.0 
				L_023f: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_0244: ldc.i4.1 
				L_0245: sub 
				L_0246: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_024b: ldarg.1 
				L_024c: ldloc.0 
				L_024d: ldloca.s V_1
				L_024f: call System.Drawing.Rectangle::Int32 get_Left()
				L_0254: ldloca.s V_1
				L_0256: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_025b: ldc.i4.1 
				L_025c: sub 
				L_025d: ldarg.0 
				L_025e: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xec9ddb74d7a61c81
				L_0263: sub 
				L_0264: ldc.i4.1 
				L_0265: ldarg.0 
				L_0266: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_026b: ldc.i4.1 
				L_026c: sub 
				L_026d: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_0272: br.s L_02c6
				L_0274: ldarg.1 
				L_0275: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_027a: ldloca.s V_1
				L_027c: call System.Drawing.Rectangle::Int32 get_Left()
				L_0281: ldloca.s V_1
				L_0283: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0288: ldarg.0 
				L_0289: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_028e: sub 
				L_028f: ldc.i4.1 
				L_0290: add 
				L_0291: ldc.i4.1 
				L_0292: ldarg.0 
				L_0293: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_0298: ldc.i4.1 
				L_0299: sub 
				L_029a: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_029f: ldarg.1 
				L_02a0: ldloc.0 
				L_02a1: ldloca.s V_1
				L_02a3: call System.Drawing.Rectangle::Int32 get_Left()
				L_02a8: ldloca.s V_1
				L_02aa: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_02af: ldarg.0 
				L_02b0: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_02b5: sub 
				L_02b6: ldc.i4.1 
				L_02b7: add 
				L_02b8: ldc.i4.1 
				L_02b9: ldarg.0 
				L_02ba: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_02bf: ldc.i4.1 
				L_02c0: sub 
				L_02c1: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_02c6: leave.s L_02d4
				L_02c8: ldloc.s V_6
				L_02ca: brfalse.s L_02d3
				L_02cc: ldloc.s V_6
				L_02ce: callvirt System.IDisposable::Void Dispose()
				L_02d3: endfinally 
				L_02d4: ldloca.s V_7
				L_02d6: ldloc.3 
				L_02d7: ldloc.s V_4
				L_02d9: ldloc.2 
				L_02da: ldloc.s V_5
				L_02dc: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_02e1: ldarg.1 
				L_02e2: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_02e7: ldloc.s V_7
				L_02e9: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_02ee: ldarg.1 
				L_02ef: ldloc.0 
				L_02f0: ldloc.s V_7
				L_02f2: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_02f7: ldarg.0 
				L_02f8: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_02fd: callvirt System.Collections.ArrayList::System.Collections.IEnumerator GetEnumerator()
				L_0302: stloc.s V_16
				L_0304: br.s L_0353
				L_0306: ldloc.s V_16
				L_0308: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_030d: castclass Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0312: stloc.s V_8
				L_0314: ldloc.s V_8
				L_0316: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x43604484a3deae4f()
				L_031b: brfalse.s L_0353
				L_031d: ldloc.s V_8
				L_031f: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xc8dbe008de6aee9e()
				L_0324: brfalse.s L_0353
				L_0326: ldloca.s V_7
				L_0328: ldloc.s V_8
				L_032a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_032f: stloc.s V_17
				L_0331: ldloca.s V_17
				L_0333: call System.Drawing.Rectangle::Int32 get_Right()
				L_0338: call System.Drawing.Rectangle::Void set_X(Int32)
				L_033d: ldarg.1 
				L_033e: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_0343: ldloc.s V_7
				L_0345: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_034a: ldarg.1 
				L_034b: ldloc.0 
				L_034c: ldloc.s V_7
				L_034e: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0353: ldloc.s V_16
				L_0355: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_035a: brtrue.s L_0306
				L_035c: leave.s L_0373
				L_035e: ldloc.s V_16
				L_0360: isinst System.IDisposable
				L_0365: stloc.s V_18
				L_0367: ldloc.s V_18
				L_0369: brfalse.s L_0372
				L_036b: ldloc.s V_18
				L_036d: callvirt System.IDisposable::Void Dispose()
				L_0372: endfinally 
				L_0373: ldloca.s V_1
				L_0375: call System.Drawing.Rectangle::Int32 get_Right()
				L_037a: ldc.i4.1 
				L_037b: add 
				L_037c: stloc.s V_9
				L_037e: ldloca.s V_1
				L_0380: call System.Drawing.Rectangle::Int32 get_Top()
				L_0385: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_038a: ldc.i4.0 
				L_038b: ldc.i4.s 17
				L_038d: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0392: add 
				L_0393: stloc.s V_10
				L_0395: ldloca.s V_1
				L_0397: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_039c: ldc.i4.1 
				L_039d: add 
				L_039e: stloc.s V_11
				L_03a0: ldloca.s V_1
				L_03a2: call System.Drawing.Rectangle::Int32 get_Left()
				L_03a7: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_03ac: ldc.i4.0 
				L_03ad: ldc.i4.s 16
				L_03af: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_03b4: add 
				L_03b5: stloc.s V_12
				L_03b7: ldloca.s V_1
				L_03b9: call System.Drawing.Rectangle::Int32 get_Left()
				L_03be: ldarg.0 
				L_03bf: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xec9ddb74d7a61c81
				L_03c4: add 
				L_03c5: stloc.s V_13
				L_03c7: ldloca.s V_1
				L_03c9: call System.Drawing.Rectangle::Int32 get_Left()
				L_03ce: ldarg.0 
				L_03cf: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xec9ddb74d7a61c81
				L_03d4: add 
				L_03d5: ldarg.0 
				L_03d6: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_03db: add 
				L_03dc: stloc.s V_14
				L_03de: ldarg.0 
				L_03df: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_03e4: ldc.i4.0 
				L_03e5: ble.s L_044b
				L_03e7: ldarg.0 
				L_03e8: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc1dccd328eafa426
				L_03ed: brtrue.s L_044b
				L_03ef: ldarg.0 
				L_03f0: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_03f5: ldc.i4.1 
				L_03f6: bne.un.s L_044b
				L_03f8: ldarga.s x3821770539095b42
				L_03fa: call System.Drawing.Rectangle::Int32 get_Width()
				L_03ff: stloc.s V_15
				L_0401: ldloc.s V_13
				L_0403: ldloc.s V_12
				L_0405: blt.s L_0425
				L_0407: ldarg.0 
				L_0408: ldarg.1 
				L_0409: ldloc.s V_12
				L_040b: ldloc.s V_11
				L_040d: ldloc.s V_13
				L_040f: ldloc.s V_12
				L_0411: sub 
				L_0412: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0417: ldc.i4.0 
				L_0418: ldc.i4.s 17
				L_041a: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_041f: ldc.i4.0 
				L_0420: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xcea282a46787878f(System.Drawing.Graphics, Int32, Int32, Int32, Int32, xf398ffaf32ffe055)
				L_0425: ldloc.s V_14
				L_0427: ldloc.s V_15
				L_0429: bgt.s L_0479
				L_042b: ldarg.0 
				L_042c: ldarg.1 
				L_042d: ldloc.s V_14
				L_042f: ldloc.s V_11
				L_0431: ldloc.s V_15
				L_0433: ldloc.s V_14
				L_0435: sub 
				L_0436: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_043b: ldc.i4.0 
				L_043c: ldc.i4.s 17
				L_043e: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0443: ldc.i4.1 
				L_0444: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xcea282a46787878f(System.Drawing.Graphics, Int32, Int32, Int32, Int32, xf398ffaf32ffe055)
				L_0449: br.s L_0479
				L_044b: ldarg.0 
				L_044c: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_0451: brtrue.s L_045e
				L_0453: ldarg.0 
				L_0454: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc1dccd328eafa426
				L_0459: brtrue.s L_045e
				L_045b: ldc.i4.0 
				L_045c: stloc.s V_12
				L_045e: ldarg.0 
				L_045f: ldarg.1 
				L_0460: ldloc.s V_12
				L_0462: ldloc.s V_11
				L_0464: ldloc.s V_9
				L_0466: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_046b: ldc.i4.0 
				L_046c: ldc.i4.s 17
				L_046e: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0473: ldc.i4.2 
				L_0474: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xcea282a46787878f(System.Drawing.Graphics, Int32, Int32, Int32, Int32, xf398ffaf32ffe055)
				L_0479: ldarg.0 
				L_047a: ldarg.1 
				L_047b: ldloc.s V_9
				L_047d: ldloc.s V_10
				L_047f: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0484: ldc.i4.0 
				L_0485: ldc.i4.s 16
				L_0487: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_048c: ldloc.s V_11
				L_048e: ldloc.s V_10
				L_0490: sub 
				L_0491: ldc.i4.1 
				L_0492: sub 
				L_0493: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xe75f29bc258e83bf(System.Drawing.Graphics, Int32, Int32, Int32, Int32)
				L_0498: ldarg.0 
				L_0499: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_049e: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.String get_x95e21d0daad2a69e()
				L_04a3: callvirt System.String::Int32 get_Length()
				L_04a8: ldc.i4.0 
				L_04a9: ble.s L_04b3
				L_04ab: ldarg.0 
				L_04ac: ldarg.1 
				L_04ad: ldloc.1 
				L_04ae: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xe145f7beb24da7f5(System.Drawing.Graphics, System.Drawing.Rectangle)
				L_04b3: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Rectangle rectangle2;
				int i11;
				rectangle1 = new Rectangle (0, 0, ((int) ((x3821770539095b42.Width - 1) - x902c4aee45bfd906._x13d4cb8d1bd20347[0, 16])), ((int) ((x3821770539095b42.Height - 1) - x902c4aee45bfd906._x13d4cb8d1bd20347[0, 17])));
				int i1 = ((x902c4aee45bfd906._x13d4cb8d1bd20347[0, 5] + x902c4aee45bfd906.xb28e4e0b2e9dba92) + x902c4aee45bfd906._x13d4cb8d1bd20347[0, 7]);
				int i2 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 1];
				int i3 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 0];
				int i4 = (((rectangle1.Height - i3) - x902c4aee45bfd906._x13d4cb8d1bd20347[0, 2]) - 1);
				Brush brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_MENUITEMCOLOR;
				x4b101060f4767186.FillRectangle (brush1, rectangle1);
				brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_LEFTBARSTARTCOLOR;
				using (Pen pen1 = new Pen (ControlPaint.Dark (((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUITEMCOLOR)))
				{
					x4b101060f4767186.DrawRectangle (pen1, rectangle1);
					if (this.xb2c6baf52a3ff3eb > 0)
					{
						if (this.x23e85093ba3a7d1d != xdbfa333b4cd503e0.x3bce7c87328df8da)
						{
							if (this.xc1dccd328eafa426)
							{
								x4b101060f4767186.FillRectangle (Brushes.White, rectangle1.Left, ((int) ((rectangle1.Top + 1) + this.xec9ddb74d7a61c81)), 1, ((int) (this.xb2c6baf52a3ff3eb - 1)));
								x4b101060f4767186.FillRectangle (brush1, rectangle1.Left, ((int) ((rectangle1.Top + 1) + this.xec9ddb74d7a61c81)), 1, ((int) (this.xb2c6baf52a3ff3eb - 1)));
							}
							else if (! this.x8e0eb9fe60b28fae)
							{
								x4b101060f4767186.FillRectangle (Brushes.White, rectangle1.Left, ((int) ((rectangle1.Bottom - this.xb2c6baf52a3ff3eb) + 1)), 1, ((int) (this.xb2c6baf52a3ff3eb - 1)));
								x4b101060f4767186.FillRectangle (brush1, rectangle1.Left, ((int) ((rectangle1.Bottom - this.xb2c6baf52a3ff3eb) + 1)), 1, ((int) (this.xb2c6baf52a3ff3eb - 1)));
							}
							else
							{
								x4b101060f4767186.FillRectangle (Brushes.White, rectangle1.Left, ((int) ((rectangle1.Bottom - 1) - this.xec9ddb74d7a61c81)), 1, ((int) (this.xb2c6baf52a3ff3eb - 1)));
								x4b101060f4767186.FillRectangle (brush1, rectangle1.Left, ((int) ((rectangle1.Bottom - 1) - this.xec9ddb74d7a61c81)), 1, ((int) (this.xb2c6baf52a3ff3eb - 1)));
							}
						}
						else if (! this.xc1dccd328eafa426)
						{
							x4b101060f4767186.FillRectangle (Brushes.White, ((int) ((rectangle1.Left + 1) + this.xec9ddb74d7a61c81)), rectangle1.Bottom, ((int) (this.xb2c6baf52a3ff3eb - 1)), 1);
							x4b101060f4767186.FillRectangle (brush1, ((int) ((rectangle1.Left + 1) + this.xec9ddb74d7a61c81)), rectangle1.Bottom, ((int) (this.xb2c6baf52a3ff3eb - 1)), 1);
						}
						else
						{
							x4b101060f4767186.FillRectangle (Brushes.White, ((int) ((rectangle1.Left + 1) + this.xec9ddb74d7a61c81)), rectangle1.Top, ((int) (this.xb2c6baf52a3ff3eb - 1)), 1);
							x4b101060f4767186.FillRectangle (brush1, ((int) ((rectangle1.Left + 1) + this.xec9ddb74d7a61c81)), rectangle1.Top, ((int) (this.xb2c6baf52a3ff3eb - 1)), 1);
						}
					}
				}
				rectangle2 = new Rectangle (i2, i3, i1, i4);
				x4b101060f4767186.FillRectangle (Brushes.White, rectangle2);
				x4b101060f4767186.FillRectangle (brush1, rectangle2);
				foreach (x2cc390e9409b0f3f x2cc390e9409b0f3f1 in this.xfb5697071ce83988)
				{
					if (x2cc390e9409b0f3f1.x43604484a3deae4f && x2cc390e9409b0f3f1.xc8dbe008de6aee9e)
					{
						rectangle2.X = x2cc390e9409b0f3f1.xee63d905da8ff550.Right;
						x4b101060f4767186.FillRectangle (Brushes.White, rectangle2);
						x4b101060f4767186.FillRectangle (brush1, rectangle2);
					}
				}
				int i5 = (rectangle1.Right + 1);
				int i6 = (rectangle1.Top + x902c4aee45bfd906._x13d4cb8d1bd20347[0, 17]);
				int i7 = (rectangle1.Bottom + 1);
				int i8 = (rectangle1.Left + x902c4aee45bfd906._x13d4cb8d1bd20347[0, 16]);
				int i9 = (rectangle1.Left + this.xec9ddb74d7a61c81);
				int i10 = ((rectangle1.Left + this.xec9ddb74d7a61c81) + this.xb2c6baf52a3ff3eb);
				if (((this.xb2c6baf52a3ff3eb > 0) && (! this.xc1dccd328eafa426)) && (this.x23e85093ba3a7d1d == xdbfa333b4cd503e0.x3bce7c87328df8da))
				{
					i11 = x3821770539095b42.Width;
					if (i9 >= i8)
					{
						this.xcea282a46787878f (x4b101060f4767186, i8, i7, ((int) (i9 - i8)), x902c4aee45bfd906._x13d4cb8d1bd20347[0, 17], xf398ffaf32ffe055.x72d92bd1aff02e37);
					}
					if (i10 <= i11)
					{
						this.xcea282a46787878f (x4b101060f4767186, i10, i7, ((int) (i11 - i10)), x902c4aee45bfd906._x13d4cb8d1bd20347[0, 17], xf398ffaf32ffe055.x419ba17a5322627b);
					}
				}
				else
				{
					if ((this.x23e85093ba3a7d1d == xdbfa333b4cd503e0.x61c108cc44ef385a) && (! this.xc1dccd328eafa426))
					{
						i8 = 0;
					}
					this.xcea282a46787878f (x4b101060f4767186, i8, i7, i5, x902c4aee45bfd906._x13d4cb8d1bd20347[0, 17], xf398ffaf32ffe055.x95c57ee794bc0aec);
				}
				this.xe75f29bc258e83bf (x4b101060f4767186, i5, i6, x902c4aee45bfd906._x13d4cb8d1bd20347[0, 16], ((int) ((i7 - i6) - 1)));
				if (this.xf4f555905eaa2330.x95e21d0daad2a69e.Length > 0)
				{
					this.xe145f7beb24da7f5 (x4b101060f4767186, rectangle1);
				}
			}
			
			protected x555516122dcc901e.POINT x4b688849d80162f6 (x40255b11ef821fa3.MSG x8a41fbc87a3fb305)
			
			/*
				// Code Size: 187 Bytes
				.maxstack 4
				.locals (Sunisoft.IrisSkin.x555516122dcc901e+POINT V_0)
				L_0000: ldloca.s V_0
				L_0002: ldarga.s x8a41fbc87a3fb305
				L_0004: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr lParam
				L_0009: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_000e: ldc.i4 65535
				L_0013: and 
				L_0014: conv.i2 
				L_0015: stfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_001a: ldloca.s V_0
				L_001c: ldarga.s x8a41fbc87a3fb305
				L_001e: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr lParam
				L_0023: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_0028: ldc.i4 -65536
				L_002d: and 
				L_002e: ldc.i4.s 16
				L_0030: shr.un 
				L_0031: conv.i2 
				L_0032: stfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_0037: ldarga.s x8a41fbc87a3fb305
				L_0039: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_003e: ldc.i4 162
				L_0043: beq L_00b9
				L_0048: ldarga.s x8a41fbc87a3fb305
				L_004a: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_004f: ldc.i4 168
				L_0054: beq.s L_00b9
				L_0056: ldarga.s x8a41fbc87a3fb305
				L_0058: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_005d: ldc.i4 165
				L_0062: beq.s L_00b9
				L_0064: ldarga.s x8a41fbc87a3fb305
				L_0066: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_006b: ldc.i4 172
				L_0070: beq.s L_00b9
				L_0072: ldarga.s x8a41fbc87a3fb305
				L_0074: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0079: ldc.i4 161
				L_007e: beq.s L_00b9
				L_0080: ldarga.s x8a41fbc87a3fb305
				L_0082: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0087: ldc.i4 167
				L_008c: beq.s L_00b9
				L_008e: ldarga.s x8a41fbc87a3fb305
				L_0090: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0095: ldc.i4 164
				L_009a: beq.s L_00b9
				L_009c: ldarga.s x8a41fbc87a3fb305
				L_009e: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_00a3: ldc.i4 171
				L_00a8: beq.s L_00b9
				L_00aa: ldarga.s x8a41fbc87a3fb305
				L_00ac: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr hwnd
				L_00b1: ldloca.s V_0
				L_00b3: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean ClientToScreen(IntPtr, POINT ByRef)
				L_00b8: pop 
				L_00b9: ldloc.0 
				L_00ba: ret 
			*/
			
			
			{
				x555516122dcc901e.POINT pOINT1;
				pOINT1.x = (((int) x8a41fbc87a3fb305.lParam) & 65535);
				pOINT1.y = ((((int) x8a41fbc87a3fb305.lParam) & -65536) >> 16);
				if ((x8a41fbc87a3fb305.message != 162) && ((x8a41fbc87a3fb305.message != 168) && ((x8a41fbc87a3fb305.message != 165) && ((x8a41fbc87a3fb305.message != 172) && ((x8a41fbc87a3fb305.message != 161) && ((x8a41fbc87a3fb305.message != 167) && ((x8a41fbc87a3fb305.message != 164) && (x8a41fbc87a3fb305.message != 171))))))))
				{
					bool b1 = x61467fe65a98f20c.ClientToScreen (x8a41fbc87a3fb305.hwnd, ref pOINT1);
				}
				return pOINT1;
			}
			
			protected Size x4e2849ed170f5bc2 ()
			
			/*
				// Code Size: 1350 Bytes
				.maxstack 6
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Int32 V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         System.Int32 V_9, 
         System.Int32 V_10, 
         System.Int32 V_11, 
         System.Boolean V_12, 
         System.Boolean V_13, 
         System.IntPtr V_14, 
         System.Collections.ArrayList V_15, 
         System.Drawing.Graphics V_16, 
         System.Drawing.SizeF V_17, 
         System.Int32 V_18, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_19, 
         System.Int32 V_20, 
         System.Int32 V_21, 
         System.Int32 V_22, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_23, 
         System.Drawing.SizeF V_24, 
         System.Int32 V_25, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_26, 
         System.Drawing.Rectangle V_27, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_28, 
         System.Int32 V_29, 
         System.Drawing.Rectangle V_30, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_31, 
         System.Int32 V_32, 
         System.Int32 V_33, 
         System.Int32 V_34, 
         System.Int32 V_35, 
         System.Drawing.Rectangle V_36, 
         System.Collections.IEnumerator V_37, 
         System.IDisposable V_38)
				.try L_0186 to L_0454 finally L_0454 to L_0469
				.try L_0102 to L_04b8 finally L_04b8 to L_04c4
				L_0000: ldarg.0 
				L_0001: newobj System.Collections.ArrayList::Void .ctor()
				L_0006: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_000b: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0010: ldc.i4.0 
				L_0011: ldc.i4.4 
				L_0012: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0017: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xd2611dcb50ae5373
				L_001c: add 
				L_001d: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0022: ldc.i4.0 
				L_0023: ldc.i4.6 
				L_0024: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0029: add 
				L_002a: stloc.0 
				L_002b: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0030: ldc.i4.0 
				L_0031: ldc.i4.5 
				L_0032: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0037: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb28e4e0b2e9dba92
				L_003c: add 
				L_003d: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0042: ldc.i4.0 
				L_0043: ldc.i4.7 
				L_0044: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0049: add 
				L_004a: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_004f: ldc.i4.0 
				L_0050: ldc.i4.8 
				L_0051: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0056: add 
				L_0057: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_005c: ldc.i4.0 
				L_005d: ldc.i4.s 9
				L_005f: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0064: add 
				L_0065: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_006a: ldc.i4.0 
				L_006b: ldc.i4.s 10
				L_006d: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0072: add 
				L_0073: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0078: ldc.i4.0 
				L_0079: ldc.i4.s 11
				L_007b: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0080: add 
				L_0081: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0086: ldc.i4.0 
				L_0087: ldc.i4.s 12
				L_0089: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_008e: add 
				L_008f: stloc.1 
				L_0090: ldarg.0 
				L_0091: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Font xb86af11733e6a799
				L_0096: callvirt System.Drawing.Font::Int32 get_Height()
				L_009b: stloc.2 
				L_009c: ldloc.2 
				L_009d: ldloc.0 
				L_009e: bge.s L_00a2
				L_00a0: ldloc.0 
				L_00a1: stloc.2 
				L_00a2: call System.Windows.Forms.SystemInformation::System.Drawing.Rectangle get_WorkingArea()
				L_00a7: stloc.s V_36
				L_00a9: ldloca.s V_36
				L_00ab: call System.Drawing.Rectangle::Int32 get_Height()
				L_00b0: stloc.3 
				L_00b1: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_00b6: ldc.i4.0 
				L_00b7: ldc.i4.1 
				L_00b8: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_00bd: stloc.s V_4
				L_00bf: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_00c4: ldc.i4.0 
				L_00c5: ldc.i4.0 
				L_00c6: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_00cb: stloc.s V_5
				L_00cd: ldloc.s V_5
				L_00cf: stloc.s V_6
				L_00d1: ldloc.1 
				L_00d2: stloc.s V_7
				L_00d4: ldc.i4.0 
				L_00d5: stloc.s V_8
				L_00d7: ldc.i4.0 
				L_00d8: stloc.s V_9
				L_00da: ldc.i4.0 
				L_00db: stloc.s V_10
				L_00dd: ldc.i4.0 
				L_00de: stloc.s V_11
				L_00e0: ldc.i4.0 
				L_00e1: stloc.s V_12
				L_00e3: ldc.i4.0 
				L_00e4: stloc.s V_13
				L_00e6: ldsfld System.IntPtr::IntPtr Zero
				L_00eb: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetDC(IntPtr)
				L_00f0: stloc.s V_14
				L_00f2: newobj System.Collections.ArrayList::Void .ctor()
				L_00f7: stloc.s V_15
				L_00f9: ldloc.s V_14
				L_00fb: call System.Drawing.Graphics::System.Drawing.Graphics FromHdc(IntPtr)
				L_0100: stloc.s V_16
				L_0102: ldarg.0 
				L_0103: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0108: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.String get_x95e21d0daad2a69e()
				L_010d: callvirt System.String::Int32 get_Length()
				L_0112: ldc.i4.0 
				L_0113: ble.s L_0179
				L_0115: ldloc.s V_16
				L_0117: ldarg.0 
				L_0118: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_011d: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.String get_x95e21d0daad2a69e()
				L_0122: ldarg.0 
				L_0123: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0128: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Font get_x5af2f9fd52bb2f28()
				L_012d: callvirt System.Drawing.Graphics::System.Drawing.SizeF MeasureString(System.String, System.Drawing.Font)
				L_0132: stloc.s V_17
				L_0134: ldloca.s V_17
				L_0136: call System.Drawing.SizeF::Single get_Height()
				L_013b: conv.i4 
				L_013c: ldc.i4.1 
				L_013d: add 
				L_013e: stloc.s V_18
				L_0140: ldarg.0 
				L_0141: ldloc.s V_18
				L_0143: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0148: ldc.i4.0 
				L_0149: ldc.i4.s 20
				L_014b: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0150: add 
				L_0151: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0156: ldc.i4.0 
				L_0157: ldc.i4.s 18
				L_0159: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_015e: ldc.i4.2 
				L_015f: mul 
				L_0160: add 
				L_0161: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x3012c20deea55334
				L_0166: ldloc.s V_4
				L_0168: ldarg.0 
				L_0169: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x3012c20deea55334
				L_016e: add 
				L_016f: stloc.s V_4
				L_0171: ldarg.0 
				L_0172: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x3012c20deea55334
				L_0177: stloc.s V_8
				L_0179: ldarg.0 
				L_017a: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_017f: callvirt System.Collections.CollectionBase::System.Collections.IEnumerator GetEnumerator()
				L_0184: stloc.s V_37
				L_0186: br L_0446
				L_018b: ldloc.s V_37
				L_018d: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0192: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0197: stloc.s V_19
				L_0199: ldloc.s V_19
				L_019b: ldsfld System.EventArgs::System.EventArgs Empty
				L_01a0: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnUpdate(System.EventArgs)
				L_01a5: ldloc.s V_19
				L_01a7: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Visible()
				L_01ac: brfalse L_0446
				L_01b1: ldloc.s V_19
				L_01b3: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_01b8: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_01bd: ldc.i4.0 
				L_01be: ble.s L_01d1
				L_01c0: ldloc.s V_19
				L_01c2: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_01c7: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Boolean xb7b226d9e2df0fa0()
				L_01cc: brfalse L_0446
				L_01d1: ldloc.s V_19
				L_01d3: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Infrequent()
				L_01d8: brfalse.s L_01ea
				L_01da: ldarg.0 
				L_01db: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x86c6e3905608c757
				L_01e0: brtrue.s L_01ea
				L_01e2: ldc.i4.1 
				L_01e3: stloc.s V_12
				L_01e5: br L_0446
				L_01ea: ldc.i4.0 
				L_01eb: stloc.s V_20
				L_01ed: ldc.i4.0 
				L_01ee: stloc.s V_21
				L_01f0: ldloc.s V_19
				L_01f2: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Break()
				L_01f7: brfalse.s L_025b
				L_01f9: ldc.i4.0 
				L_01fa: stloc.s V_10
				L_01fc: ldloc.s V_11
				L_01fe: ldc.i4.1 
				L_01ff: add 
				L_0200: stloc.s V_11
				L_0202: ldarg.0 
				L_0203: ldloc.s V_15
				L_0205: ldloc.s V_7
				L_0207: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xfbe050c2d5b2be39(System.Collections.ArrayList, Int32)
				L_020c: ldloc.s V_4
				L_020e: ldloc.s V_7
				L_0210: add 
				L_0211: stloc.s V_4
				L_0213: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0218: ldc.i4.0 
				L_0219: ldc.i4.s 14
				L_021b: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0220: stloc.s V_22
				L_0222: ldloc.s V_4
				L_0224: ldc.i4.0 
				L_0225: ldloc.s V_22
				L_0227: ldc.i4.0 
				L_0228: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_022d: ldc.i4.0 
				L_022e: newobj Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void .ctor(System.Drawing.Rectangle, Boolean)
				L_0233: stloc.s V_23
				L_0235: ldarg.0 
				L_0236: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_023b: ldloc.s V_23
				L_023d: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0242: pop 
				L_0243: ldloc.s V_4
				L_0245: ldloc.s V_22
				L_0247: add 
				L_0248: stloc.s V_4
				L_024a: ldloc.s V_5
				L_024c: stloc.s V_6
				L_024e: ldloc.s V_8
				L_0250: ldloc.s V_7
				L_0252: ldloc.s V_22
				L_0254: add 
				L_0255: add 
				L_0256: stloc.s V_8
				L_0258: ldloc.1 
				L_0259: stloc.s V_7
				L_025b: ldloc.s V_19
				L_025d: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_0262: ldstr "-"
				L_0267: call System.String::Boolean op_Equality(System.String, System.String)
				L_026c: brfalse.s L_0282
				L_026e: ldloc.1 
				L_026f: stloc.s V_20
				L_0271: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0276: ldc.i4.0 
				L_0277: ldc.i4.s 13
				L_0279: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_027e: stloc.s V_21
				L_0280: br.s L_02eb
				L_0282: ldloc.2 
				L_0283: stloc.s V_21
				L_0285: ldloc.s V_16
				L_0287: ldloc.s V_19
				L_0289: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_028e: ldarg.0 
				L_028f: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Font xb86af11733e6a799
				L_0294: callvirt System.Drawing.Graphics::System.Drawing.SizeF MeasureString(System.String, System.Drawing.Font)
				L_0299: stloc.s V_24
				L_029b: ldloc.1 
				L_029c: ldloca.s V_24
				L_029e: call System.Drawing.SizeF::Single get_Width()
				L_02a3: conv.i4 
				L_02a4: add 
				L_02a5: ldc.i4.1 
				L_02a6: add 
				L_02a7: stloc.s V_20
				L_02a9: ldloc.s V_19
				L_02ab: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Shortcut get_Shortcut()
				L_02b0: brfalse.s L_02eb
				L_02b2: ldloc.s V_16
				L_02b4: ldarg.0 
				L_02b5: ldloc.s V_19
				L_02b7: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Shortcut get_Shortcut()
				L_02bc: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.String x8cf43133d25d686a(System.Windows.Forms.Shortcut)
				L_02c1: ldarg.0 
				L_02c2: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Font xb86af11733e6a799
				L_02c7: callvirt System.Drawing.Graphics::System.Drawing.SizeF MeasureString(System.String, System.Drawing.Font)
				L_02cc: stloc.s V_24
				L_02ce: ldloc.s V_20
				L_02d0: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_02d5: ldc.i4.0 
				L_02d6: ldc.i4.s 15
				L_02d8: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_02dd: ldloca.s V_24
				L_02df: call System.Drawing.SizeF::Single get_Width()
				L_02e4: conv.i4 
				L_02e5: add 
				L_02e6: ldc.i4.1 
				L_02e7: add 
				L_02e8: add 
				L_02e9: stloc.s V_20
				L_02eb: ldloc.s V_6
				L_02ed: ldloc.s V_21
				L_02ef: add 
				L_02f0: ldloc.3 
				L_02f1: blt.s L_035f
				L_02f3: ldc.i4.0 
				L_02f4: stloc.s V_10
				L_02f6: ldloc.s V_11
				L_02f8: ldc.i4.1 
				L_02f9: add 
				L_02fa: stloc.s V_11
				L_02fc: ldarg.0 
				L_02fd: ldloc.s V_15
				L_02ff: ldloc.s V_7
				L_0301: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xfbe050c2d5b2be39(System.Collections.ArrayList, Int32)
				L_0306: ldloc.s V_4
				L_0308: ldloc.s V_7
				L_030a: add 
				L_030b: stloc.s V_4
				L_030d: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0312: ldc.i4.0 
				L_0313: ldc.i4.s 14
				L_0315: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_031a: stloc.s V_25
				L_031c: ldloc.s V_4
				L_031e: ldloc.s V_5
				L_0320: ldloc.s V_25
				L_0322: ldc.i4.0 
				L_0323: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0328: ldc.i4.0 
				L_0329: newobj Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void .ctor(System.Drawing.Rectangle, Boolean)
				L_032e: stloc.s V_26
				L_0330: ldarg.0 
				L_0331: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0336: ldloc.s V_26
				L_0338: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_033d: pop 
				L_033e: ldloc.s V_4
				L_0340: ldloc.s V_25
				L_0342: add 
				L_0343: stloc.s V_4
				L_0345: ldloc.s V_5
				L_0347: stloc.s V_6
				L_0349: ldloc.s V_8
				L_034b: ldloc.s V_7
				L_034d: ldloc.s V_25
				L_034f: add 
				L_0350: add 
				L_0351: stloc.s V_8
				L_0353: ldloc.1 
				L_0354: stloc.s V_7
				L_0356: ldloc.s V_26
				L_0358: ldloc.s V_13
				L_035a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void set_x062575979028fd71(Boolean)
				L_035f: ldloca.s V_27
				L_0361: ldloc.s V_4
				L_0363: ldloc.s V_6
				L_0365: ldloc.s V_20
				L_0367: ldloc.s V_21
				L_0369: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_036e: ldloc.s V_19
				L_0370: ldloc.s V_27
				L_0372: ldloc.s V_10
				L_0374: ldloc.s V_11
				L_0376: newobj Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void .ctor(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa, System.Drawing.Rectangle, Int32, Int32)
				L_037b: stloc.s V_28
				L_037d: ldloc.s V_13
				L_037f: ldloc.s V_19
				L_0381: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Infrequent()
				L_0386: beq L_03fb
				L_038b: ldloc.s V_19
				L_038d: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Infrequent()
				L_0392: brfalse.s L_039e
				L_0394: ldloc.s V_28
				L_0396: ldc.i4.1 
				L_0397: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void set_x9d329a00f2c534a8(Boolean)
				L_039c: br.s L_03fb
				L_039e: ldarg.0 
				L_039f: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_03a4: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_03a9: ldc.i4.0 
				L_03aa: ble.s L_03fb
				L_03ac: ldarg.0 
				L_03ad: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_03b2: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_03b7: ldc.i4.1 
				L_03b8: sub 
				L_03b9: stloc.s V_29
				L_03bb: br.s L_03f6
				L_03bd: ldarg.0 
				L_03be: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_03c3: ldloc.s V_29
				L_03c5: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_03ca: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_03cf: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x43604484a3deae4f()
				L_03d4: brtrue.s L_03f0
				L_03d6: ldarg.0 
				L_03d7: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_03dc: ldloc.s V_29
				L_03de: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_03e3: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_03e8: ldc.i4.1 
				L_03e9: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void set_x3903fbc9023c861c(Boolean)
				L_03ee: br.s L_03fb
				L_03f0: ldloc.s V_29
				L_03f2: ldc.i4.1 
				L_03f3: sub 
				L_03f4: stloc.s V_29
				L_03f6: ldloc.s V_29
				L_03f8: ldc.i4.0 
				L_03f9: bge.s L_03bd
				L_03fb: ldloc.s V_28
				L_03fd: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x43604484a3deae4f()
				L_0402: brtrue.s L_040d
				L_0404: ldloc.s V_19
				L_0406: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Infrequent()
				L_040b: stloc.s V_13
				L_040d: ldarg.0 
				L_040e: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0413: ldloc.s V_28
				L_0415: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_041a: pop 
				L_041b: ldloc.s V_15
				L_041d: ldloc.s V_28
				L_041f: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0424: pop 
				L_0425: ldloc.s V_20
				L_0427: ldloc.s V_7
				L_0429: ble.s L_042f
				L_042b: ldloc.s V_20
				L_042d: stloc.s V_7
				L_042f: ldloc.s V_6
				L_0431: ldloc.s V_21
				L_0433: add 
				L_0434: stloc.s V_6
				L_0436: ldloc.s V_6
				L_0438: ldloc.s V_9
				L_043a: ble.s L_0440
				L_043c: ldloc.s V_6
				L_043e: stloc.s V_9
				L_0440: ldloc.s V_10
				L_0442: ldc.i4.1 
				L_0443: add 
				L_0444: stloc.s V_10
				L_0446: ldloc.s V_37
				L_0448: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_044d: brtrue L_018b
				L_0452: leave.s L_0469
				L_0454: ldloc.s V_37
				L_0456: isinst System.IDisposable
				L_045b: stloc.s V_38
				L_045d: ldloc.s V_38
				L_045f: brfalse.s L_0468
				L_0461: ldloc.s V_38
				L_0463: callvirt System.IDisposable::Void Dispose()
				L_0468: endfinally 
				L_0469: ldloc.s V_12
				L_046b: brfalse.s L_04ac
				L_046d: ldloca.s V_30
				L_046f: ldloc.s V_4
				L_0471: ldloc.s V_6
				L_0473: ldloc.1 
				L_0474: ldloc.0 
				L_0475: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_047a: ldloc.s V_30
				L_047c: ldc.i4.1 
				L_047d: newobj Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void .ctor(System.Drawing.Rectangle, Boolean)
				L_0482: stloc.s V_31
				L_0484: ldarg.0 
				L_0485: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_048a: ldloc.s V_31
				L_048c: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0491: pop 
				L_0492: ldloc.s V_15
				L_0494: ldloc.s V_31
				L_0496: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_049b: pop 
				L_049c: ldloc.s V_6
				L_049e: ldloc.0 
				L_049f: add 
				L_04a0: stloc.s V_6
				L_04a2: ldloc.s V_6
				L_04a4: ldloc.s V_9
				L_04a6: ble.s L_04ac
				L_04a8: ldloc.s V_6
				L_04aa: stloc.s V_9
				L_04ac: ldarg.0 
				L_04ad: ldloc.s V_15
				L_04af: ldloc.s V_7
				L_04b1: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xfbe050c2d5b2be39(System.Collections.ArrayList, Int32)
				L_04b6: leave.s L_04c4
				L_04b8: ldloc.s V_16
				L_04ba: brfalse.s L_04c3
				L_04bc: ldloc.s V_16
				L_04be: callvirt System.IDisposable::Void Dispose()
				L_04c3: endfinally 
				L_04c4: ldsfld System.IntPtr::IntPtr Zero
				L_04c9: ldloc.s V_14
				L_04cb: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_04d0: pop 
				L_04d1: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_04d6: ldc.i4.0 
				L_04d7: ldc.i4.1 
				L_04d8: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_04dd: ldloc.s V_8
				L_04df: add 
				L_04e0: ldloc.s V_7
				L_04e2: add 
				L_04e3: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_04e8: ldc.i4.0 
				L_04e9: ldc.i4.3 
				L_04ea: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_04ef: add 
				L_04f0: stloc.s V_32
				L_04f2: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_04f7: ldc.i4.0 
				L_04f8: ldc.i4.0 
				L_04f9: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_04fe: ldloc.s V_9
				L_0500: add 
				L_0501: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0506: ldc.i4.0 
				L_0507: ldc.i4.2 
				L_0508: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_050d: add 
				L_050e: stloc.s V_33
				L_0510: ldarg.0 
				L_0511: ldloc.s V_9
				L_0513: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x5796c1a518d308ac(Int32)
				L_0518: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_051d: ldc.i4.0 
				L_051e: ldc.i4.s 17
				L_0520: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0525: stloc.s V_34
				L_0527: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_052c: ldc.i4.0 
				L_052d: ldc.i4.s 16
				L_052f: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0534: stloc.s V_35
				L_0536: ldloc.s V_32
				L_0538: ldloc.s V_34
				L_053a: add 
				L_053b: ldloc.s V_33
				L_053d: ldloc.s V_35
				L_053f: add 
				L_0540: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_0545: ret 
			*/
			
			
			{
				int i13;
				x5f4b657f68f87baa x5f4b657f68f87baa1;
				int i14;
				int i15;
				int i16;
				x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				int i17;
				x2cc390e9409b0f3f x2cc390e9409b0f3f2;
				Rectangle rectangle1;
				x2cc390e9409b0f3f x2cc390e9409b0f3f3;
				int i18;
				Rectangle rectangle2;
				x2cc390e9409b0f3f x2cc390e9409b0f3f4;
				IEnumerator iEnumerator1;
				IDisposable iDisposable1;
				this.xfb5697071ce83988 = new ArrayList ();
				int i1 = ((x902c4aee45bfd906._x13d4cb8d1bd20347[0, 4] + x902c4aee45bfd906.xd2611dcb50ae5373) + x902c4aee45bfd906._x13d4cb8d1bd20347[0, 6]);
				int i2 = (((((((x902c4aee45bfd906._x13d4cb8d1bd20347[0, 5] + x902c4aee45bfd906.xb28e4e0b2e9dba92) + x902c4aee45bfd906._x13d4cb8d1bd20347[0, 7]) + x902c4aee45bfd906._x13d4cb8d1bd20347[0, 8]) + x902c4aee45bfd906._x13d4cb8d1bd20347[0, 9]) + x902c4aee45bfd906._x13d4cb8d1bd20347[0, 10]) + x902c4aee45bfd906._x13d4cb8d1bd20347[0, 11]) + x902c4aee45bfd906._x13d4cb8d1bd20347[0, 12]);
				int i3 = this.xb86af11733e6a799.Height;
				if (i3 < i1)
				{
					i3 = i1;
				}
				Rectangle rectangle3 = SystemInformation.WorkingArea;
				int i4 = rectangle3.Height;
				int i5 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 1];
				int i6 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 0];
				int i7 = i6;
				int i8 = i2;
				int i9 = 0;
				int i10 = 0;
				int i11 = 0;
				int i12 = 0;
				bool b1 = false;
				bool b2 = false;
				IntPtr intPtr1 = x61467fe65a98f20c.GetDC (IntPtr.Zero);
				ArrayList arrayList1 = new ArrayList ();
				using (Graphics graphics1 = Graphics.FromHdc (intPtr1))
				{
					if (this.xf4f555905eaa2330.x95e21d0daad2a69e.Length > 0)
					{
						i13 = (((int) graphics1.MeasureString (this.xf4f555905eaa2330.x95e21d0daad2a69e, this.xf4f555905eaa2330.x5af2f9fd52bb2f28).Height) + 1);
						this.x3012c20deea55334 = ((i13 + x902c4aee45bfd906._x13d4cb8d1bd20347[0, 20]) + (x902c4aee45bfd906._x13d4cb8d1bd20347[0, 18] * 2));
						i5 += this.x3012c20deea55334;
						i9 = this.x3012c20deea55334;
					}
					iEnumerator1 = this.xf4f555905eaa2330.GetEnumerator ();
					try
					{
						goto L_0446;
						
					L_02EB:
						
						{
						}
						if ((i7 + i15) >= i4)
						{
							i11 = 0;
							i12++;
							this.xfbe050c2d5b2be39 (arrayList1, i8);
							i5 += i8;
							i17 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 14];
							x2cc390e9409b0f3f2 = new x2cc390e9409b0f3f (new Rectangle (i5, i6, i17, 0), false);
							int i24 = this.xfb5697071ce83988.Add (x2cc390e9409b0f3f2);
							i5 += i17;
							i7 = i6;
							i9 += (i8 + i17);
							i8 = i2;
							x2cc390e9409b0f3f2.x062575979028fd71 = b2;
						}
						rectangle1 = new Rectangle (i5, i7, i14, i15);
						x2cc390e9409b0f3f3 = new x2cc390e9409b0f3f (x5f4b657f68f87baa1, rectangle1, i11, i12);
						if (b2 != x5f4b657f68f87baa1.Infrequent)
						{
							if (x5f4b657f68f87baa1.Infrequent)
							{
								x2cc390e9409b0f3f3.x9d329a00f2c534a8 = true;
							}
							else if (this.xfb5697071ce83988.Count > 0)
							{
								i18 = (this.xfb5697071ce83988.Count - 1);
								while (i18 >= 0)
								{
									if ((this.xfb5697071ce83988[i18] as x2cc390e9409b0f3f).x43604484a3deae4f)
									{
										i18--;
										continue;
									}
									(this.xfb5697071ce83988[i18] as x2cc390e9409b0f3f).x3903fbc9023c861c = true;
									break;
								}
							}
						}
						if (! x2cc390e9409b0f3f3.x43604484a3deae4f)
						{
							b2 = x5f4b657f68f87baa1.Infrequent;
						}
						int i25 = this.xfb5697071ce83988.Add (x2cc390e9409b0f3f3);
						int i26 = arrayList1.Add (x2cc390e9409b0f3f3);
						if (i14 > i8)
						{
							i8 = i14;
						}
						i7 += i15;
						if (i7 > i10)
						{
							i10 = i7;
						}
						i11++;
						
					L_0446:
						
						{
						}
						while (iEnumerator1.MoveNext ())
						{
							x5f4b657f68f87baa1 = ((x5f4b657f68f87baa) iEnumerator1.Current);
							x5f4b657f68f87baa1.OnUpdate (EventArgs.Empty);
							if (x5f4b657f68f87baa1.Visible && ((x5f4b657f68f87baa1.MenuCommands.Count <= 0) || x5f4b657f68f87baa1.MenuCommands.xb7b226d9e2df0fa0 ()))
							{
								if ((! x5f4b657f68f87baa1.Infrequent) || this.x86c6e3905608c757)
								{
									i14 = 0;
									if (x5f4b657f68f87baa1.Break)
									{
										i11 = 0;
										i12++;
										this.xfbe050c2d5b2be39 (arrayList1, i8);
										i5 += i8;
										i16 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 14];
										x2cc390e9409b0f3f1 = new x2cc390e9409b0f3f (new Rectangle (i5, 0, i16, 0), false);
										int i23 = this.xfb5697071ce83988.Add (x2cc390e9409b0f3f1);
										i5 += i16;
										i7 = i6;
										i9 += (i8 + i16);
										i8 = i2;
									}
									if (x5f4b657f68f87baa1.Text == "-")
									{
										i14 = i2;
										i15 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 13];
										goto L_02EB;
									}
									i15 = i3;
									i14 = ((i2 + ((int) graphics1.MeasureString (x5f4b657f68f87baa1.Text, this.xb86af11733e6a799).Width)) + 1);
									if (x5f4b657f68f87baa1.Shortcut != Shortcut.None)
									{
										i14 += ((x902c4aee45bfd906._x13d4cb8d1bd20347[0, 15] + ((int) graphics1.MeasureString (this.x8cf43133d25d686a (x5f4b657f68f87baa1.Shortcut), this.xb86af11733e6a799).Width)) + 1);
									}
									goto L_02EB;
								}
								b1 = true;
							}
						}
					}
					finally
					{
						iDisposable1 = (iEnumerator1 as IDisposable);
						if (iDisposable1 != null)
						{
							iDisposable1.Dispose ();
						}
					}
					if (b1)
					{
						rectangle2 = new Rectangle (i5, i7, i2, i1);
						x2cc390e9409b0f3f4 = new x2cc390e9409b0f3f (rectangle2, true);
						int i27 = this.xfb5697071ce83988.Add (x2cc390e9409b0f3f4);
						int i28 = arrayList1.Add (x2cc390e9409b0f3f4);
						i7 += i1;
						if (i7 > i10)
						{
							i10 = i7;
						}
					}
					this.xfbe050c2d5b2be39 (arrayList1, i8);
				}
				int i29 = x61467fe65a98f20c.ReleaseDC (IntPtr.Zero, intPtr1);
				int i19 = (((x902c4aee45bfd906._x13d4cb8d1bd20347[0, 1] + i9) + i8) + x902c4aee45bfd906._x13d4cb8d1bd20347[0, 3]);
				int i20 = ((x902c4aee45bfd906._x13d4cb8d1bd20347[0, 0] + i10) + x902c4aee45bfd906._x13d4cb8d1bd20347[0, 2]);
				this.x5796c1a518d308ac (i10);
				int i21 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 17];
				int i22 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 16];
				return new Size (((int) (i19 + i21)), ((int) (i20 + i22)));
			}
			
			protected bool x5437d760e9a6340b ()
			
			/*
				// Code Size: 121 Bytes
				.maxstack 6
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Int32 V_2, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_3)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0006: stloc.0 
				L_0007: ldloc.0 
				L_0008: stloc.1 
				L_0009: ldc.i4.0 
				L_000a: stloc.2 
				L_000b: br.s L_0069
				L_000d: ldloc.0 
				L_000e: ldc.i4.1 
				L_000f: sub 
				L_0010: stloc.0 
				L_0011: ldloc.0 
				L_0012: ldloc.1 
				L_0013: bne.un.s L_0017
				L_0015: ldc.i4.0 
				L_0016: ret 
				L_0017: ldloc.0 
				L_0018: ldc.i4.0 
				L_0019: bge.s L_0029
				L_001b: ldarg.0 
				L_001c: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0021: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_0026: ldc.i4.1 
				L_0027: sub 
				L_0028: stloc.0 
				L_0029: ldarg.0 
				L_002a: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_002f: ldloc.0 
				L_0030: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0035: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_003a: stloc.3 
				L_003b: ldloc.3 
				L_003c: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x43604484a3deae4f()
				L_0041: brtrue.s L_0065
				L_0043: ldloc.3 
				L_0044: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x9f2c0dc847992f03()
				L_0049: brfalse.s L_0065
				L_004b: ldloc.0 
				L_004c: ldarg.0 
				L_004d: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0052: beq.s L_0065
				L_0054: ldarg.0 
				L_0055: ldarg.0 
				L_0056: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_005b: ldloc.0 
				L_005c: ldc.i4.0 
				L_005d: ldc.i4.0 
				L_005e: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xeb515a5b77846afe(Int32, Int32, Boolean, Boolean)
				L_0063: ldc.i4.1 
				L_0064: ret 
				L_0065: ldloc.2 
				L_0066: ldc.i4.1 
				L_0067: add 
				L_0068: stloc.2 
				L_0069: ldloc.2 
				L_006a: ldarg.0 
				L_006b: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0070: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_0075: blt.s L_000d
				L_0077: ldc.i4.0 
				L_0078: ret 
			*/
			
			
			{
				int i3;
				x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				int i1 = this.xb266b78561d63b52;
				int i2 = i1;
				for (i3 = 0; (i3 < this.xfb5697071ce83988.Count); i3++)
				{
					i1--;
					if (i1 == i2)
					{
						return false;
					}
					if (i1 < 0)
					{
						i1 = (this.xfb5697071ce83988.Count - 1);
					}
					x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[i1] as x2cc390e9409b0f3f);
					if (((! x2cc390e9409b0f3f1.x43604484a3deae4f) && x2cc390e9409b0f3f1.x9f2c0dc847992f03) && (i1 != this.xb266b78561d63b52))
					{
						this.xeb515a5b77846afe (this.xb266b78561d63b52, i1, false, false);
						return true;
					}
				}
				return false;
			}
			
			protected void x5796c1a518d308ac (int x3b2a52f70523c25a)
			
			/*
				// Code Size: 102 Bytes
				.maxstack 7
				.locals (Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_0, 
         System.Drawing.Rectangle V_1, 
         System.Collections.IEnumerator V_2, 
         System.IDisposable V_3)
				.try L_000c to L_0054 finally L_0054 to L_0065
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0006: callvirt System.Collections.ArrayList::System.Collections.IEnumerator GetEnumerator()
				L_000b: stloc.2 
				L_000c: br.s L_004a
				L_000e: ldloc.2 
				L_000f: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0014: castclass Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0019: stloc.0 
				L_001a: ldloc.0 
				L_001b: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xc8dbe008de6aee9e()
				L_0020: brfalse.s L_004a
				L_0022: ldloc.0 
				L_0023: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_0028: stloc.1 
				L_0029: ldloc.0 
				L_002a: ldloca.s V_1
				L_002c: call System.Drawing.Rectangle::Int32 get_Left()
				L_0031: ldloca.s V_1
				L_0033: call System.Drawing.Rectangle::Int32 get_Top()
				L_0038: ldloca.s V_1
				L_003a: call System.Drawing.Rectangle::Int32 get_Width()
				L_003f: ldarg.1 
				L_0040: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0045: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void set_xee63d905da8ff550(System.Drawing.Rectangle)
				L_004a: ldloc.2 
				L_004b: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0050: brtrue.s L_000e
				L_0052: leave.s L_0065
				L_0054: ldloc.2 
				L_0055: isinst System.IDisposable
				L_005a: stloc.3 
				L_005b: ldloc.3 
				L_005c: brfalse.s L_0064
				L_005e: ldloc.3 
				L_005f: callvirt System.IDisposable::Void Dispose()
				L_0064: endfinally 
				L_0065: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				foreach (x2cc390e9409b0f3f x2cc390e9409b0f3f1 in this.xfb5697071ce83988)
				{
					if (x2cc390e9409b0f3f1.xc8dbe008de6aee9e)
					{
						x2cc390e9409b0f3f1.xee63d905da8ff550 = new Rectangle ((rectangle1 = x2cc390e9409b0f3f1.xee63d905da8ff550).Left, rectangle1.Top, rectangle1.Width, x3b2a52f70523c25a);
					}
				}
			}
			
			protected bool x5b2e42a68d835b31 ()
			
			/*
				// Code Size: 111 Bytes
				.maxstack 6
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_2)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0006: stloc.0 
				L_0007: ldc.i4.0 
				L_0008: stloc.1 
				L_0009: br.s L_005f
				L_000b: ldloc.0 
				L_000c: ldc.i4.1 
				L_000d: add 
				L_000e: stloc.0 
				L_000f: ldloc.0 
				L_0010: ldarg.0 
				L_0011: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0016: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_001b: blt.s L_001f
				L_001d: ldc.i4.0 
				L_001e: stloc.0 
				L_001f: ldarg.0 
				L_0020: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0025: ldloc.0 
				L_0026: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_002b: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0030: stloc.2 
				L_0031: ldloc.2 
				L_0032: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x43604484a3deae4f()
				L_0037: brtrue.s L_005b
				L_0039: ldloc.2 
				L_003a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x9f2c0dc847992f03()
				L_003f: brfalse.s L_005b
				L_0041: ldloc.0 
				L_0042: ldarg.0 
				L_0043: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0048: beq.s L_005b
				L_004a: ldarg.0 
				L_004b: ldarg.0 
				L_004c: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0051: ldloc.0 
				L_0052: ldc.i4.0 
				L_0053: ldc.i4.0 
				L_0054: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xeb515a5b77846afe(Int32, Int32, Boolean, Boolean)
				L_0059: ldc.i4.1 
				L_005a: ret 
				L_005b: ldloc.1 
				L_005c: ldc.i4.1 
				L_005d: add 
				L_005e: stloc.1 
				L_005f: ldloc.1 
				L_0060: ldarg.0 
				L_0061: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0066: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_006b: blt.s L_000b
				L_006d: ldc.i4.0 
				L_006e: ret 
			*/
			
			
			{
				int i2;
				x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				int i1 = this.xb266b78561d63b52;
				for (i2 = 0; (i2 < this.xfb5697071ce83988.Count); i2++)
				{
					i1++;
					if (i1 >= this.xfb5697071ce83988.Count)
					{
						i1 = 0;
					}
					x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[i1] as x2cc390e9409b0f3f);
					if (((! x2cc390e9409b0f3f1.x43604484a3deae4f) && x2cc390e9409b0f3f1.x9f2c0dc847992f03) && (i1 != this.xb266b78561d63b52))
					{
						this.xeb515a5b77846afe (this.xb266b78561d63b52, i1, false, false);
						return true;
					}
				}
				return false;
			}
			
			public x5f4b657f68f87baa x6192996f26aa9421 (Point x0ce73f6cbd7d5515, bool xacc37ebdd71fcc44)
			
			/*
				// Code Size: 51 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0006: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Boolean xb7b226d9e2df0fa0()
				L_000b: brfalse.s L_0031
				L_000d: ldarg.0 
				L_000e: ldc.i4.1 
				L_000f: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_0014: ldarg.0 
				L_0015: ldarg.1 
				L_0016: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x07658cf2bdd49693
				L_001b: ldarg.0 
				L_001c: ldarg.1 
				L_001d: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x1ee5f8430343bccd
				L_0022: ldarg.0 
				L_0023: ldarg.1 
				L_0024: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point xcbbe945601aff7c8
				L_0029: ldarg.0 
				L_002a: ldarg.2 
				L_002b: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x6e4244e25732db7d(Boolean)
				L_0030: ret 
				L_0031: ldnull 
				L_0032: ret 
			*/
			
			
			{
				if (! this.xf4f555905eaa2330.xb7b226d9e2df0fa0 ())
				{
					return null;
				}
				else
				{
					this.x23e85093ba3a7d1d = xdbfa333b4cd503e0.x3bce7c87328df8da;
					this.x07658cf2bdd49693 = x0ce73f6cbd7d5515;
					this.x1ee5f8430343bccd = x0ce73f6cbd7d5515;
					this.xcbbe945601aff7c8 = x0ce73f6cbd7d5515;
					return this.x6e4244e25732db7d (xacc37ebdd71fcc44);
				}
			}
			
			internal x5f4b657f68f87baa x6192996f26aa9421 (Point x0ce73f6cbd7d5515, Point xd682fa060330cf55, xdbfa333b4cd503e0 x23e85093ba3a7d1d, xd53b20b7b4b2a08a x2ac8fd3ce3986cdc, int xb2c6baf52a3ff3eb, bool xacc37ebdd71fcc44, x3c41176af7e54b01 x37f2fc2a7f30f790, bool x0a7391c99fcdc469, ref int x0cd2bb383a46f073)
			
			/*
				// Code Size: 101 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a V_0, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_1)
				L_0000: ldarg.0 
				L_0001: ldarg.3 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_0007: ldarg.0 
				L_0008: ldarg.s x37f2fc2a7f30f790
				L_000a: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_000f: ldarg.0 
				L_0010: ldarg.s xb2c6baf52a3ff3eb
				L_0012: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb2c6baf52a3ff3eb
				L_0017: ldarg.0 
				L_0018: ldarg.s x0a7391c99fcdc469
				L_001a: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x0a7391c99fcdc469
				L_001f: ldarg.0 
				L_0020: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0025: stloc.0 
				L_0026: ldarg.0 
				L_0027: ldarg.s x2ac8fd3ce3986cdc
				L_0029: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_002e: ldarg.0 
				L_002f: ldarg.1 
				L_0030: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x07658cf2bdd49693
				L_0035: ldarg.0 
				L_0036: ldarg.2 
				L_0037: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x1ee5f8430343bccd
				L_003c: ldarg.0 
				L_003d: ldarg.1 
				L_003e: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point xcbbe945601aff7c8
				L_0043: ldarg.0 
				L_0044: ldarg.s xacc37ebdd71fcc44
				L_0046: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x6e4244e25732db7d(Boolean)
				L_004b: stloc.1 
				L_004c: ldarg.0 
				L_004d: ldloc.0 
				L_004e: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0053: ldarg.0 
				L_0054: ldnull 
				L_0055: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_005a: ldarg.0 
				L_005b: ldarg.s x0cd2bb383a46f073
				L_005d: ldind.i4 
				L_005e: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x0cd2bb383a46f073
				L_0063: ldloc.1 
				L_0064: ret 
			*/
			
			
			{
				this.x23e85093ba3a7d1d = x23e85093ba3a7d1d;
				this.x37f2fc2a7f30f790 = x37f2fc2a7f30f790;
				this.xb2c6baf52a3ff3eb = xb2c6baf52a3ff3eb;
				this.x0a7391c99fcdc469 = x0a7391c99fcdc469;
				xd53b20b7b4b2a08a xd53b20b7b4b2a08a1 = this.xf4f555905eaa2330;
				this.xf4f555905eaa2330 = x2ac8fd3ce3986cdc;
				this.x07658cf2bdd49693 = x0ce73f6cbd7d5515;
				this.x1ee5f8430343bccd = xd682fa060330cf55;
				this.xcbbe945601aff7c8 = x0ce73f6cbd7d5515;
				x5f4b657f68f87baa x5f4b657f68f87baa1 = this.x6e4244e25732db7d (xacc37ebdd71fcc44);
				this.xf4f555905eaa2330 = xd53b20b7b4b2a08a1;
				this.x37f2fc2a7f30f790 = ((x3c41176af7e54b01) null);
				this.x0cd2bb383a46f073 = x0cd2bb383a46f073;
				return x5f4b657f68f87baa1;
			}
			
			public x5f4b657f68f87baa x6192996f26aa9421 (Point x0ce73f6cbd7d5515)
			
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldc.i4.0 
				L_0003: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x6192996f26aa9421(System.Drawing.Point, Boolean)
				L_0008: ret 
			*/
			
			
			{
				return this.x6192996f26aa9421 (x0ce73f6cbd7d5515, false);
			}
			
			protected int x65c1cc54cc8b0e75 (char xba08ce632055a1d9)
			
			/*
				// Code Size: 95 Bytes
				.maxstack 6
				.locals (System.Int32 V_0, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_1)
				L_0000: ldc.i4.0 
				L_0001: stloc.0 
				L_0002: br.s L_004f
				L_0004: ldarg.0 
				L_0005: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_000a: ldloc.0 
				L_000b: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0010: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0015: stloc.1 
				L_0016: ldloc.1 
				L_0017: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x9f2c0dc847992f03()
				L_001c: brfalse.s L_004b
				L_001e: ldarg.1 
				L_001f: ldloc.1 
				L_0020: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Char get_x4f86e73709b68aaf()
				L_0025: bne.un.s L_004b
				L_0027: ldloc.1 
				L_0028: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x649e2ad374251b5f()
				L_002d: brfalse.s L_0049
				L_002f: ldarg.0 
				L_0030: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0035: ldloc.0 
				L_0036: beq.s L_0047
				L_0038: ldarg.0 
				L_0039: ldarg.0 
				L_003a: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_003f: ldloc.0 
				L_0040: ldc.i4.1 
				L_0041: ldc.i4.0 
				L_0042: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xeb515a5b77846afe(Int32, Int32, Boolean, Boolean)
				L_0047: ldc.i4.m1 
				L_0048: ret 
				L_0049: ldloc.0 
				L_004a: ret 
				L_004b: ldloc.0 
				L_004c: ldc.i4.1 
				L_004d: add 
				L_004e: stloc.0 
				L_004f: ldloc.0 
				L_0050: ldarg.0 
				L_0051: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0056: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_005b: blt.s L_0004
				L_005d: ldc.i4.m1 
				L_005e: ret 
			*/
			
			
			{
				x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				int i1 = 0;
				while (i1 < this.xfb5697071ce83988.Count)
				{
					x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[i1] as x2cc390e9409b0f3f);
					if ((! x2cc390e9409b0f3f1.x9f2c0dc847992f03) || (xba08ce632055a1d9 != x2cc390e9409b0f3f1.x4f86e73709b68aaf))
					{
						i1++;
						continue;
					}
					else if (! x2cc390e9409b0f3f1.x649e2ad374251b5f)
					{
						return i1;
					}
					else
					{
						if (this.xb266b78561d63b52 != i1)
						{
							this.xeb515a5b77846afe (this.xb266b78561d63b52, i1, true, false);
						}
						return -1;
					}
				}
				return -1;
			}
			
			protected Point x6e375ee3ca34b13b (Size x001544edc57babc2)
			
			/*
				// Code Size: 713 Bytes
				.maxstack 6
				.locals (System.Drawing.Rectangle V_0, 
         System.Drawing.Point V_1, 
         System.Int32 V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x07658cf2bdd49693
				L_0006: call System.Windows.Forms.Screen::System.Drawing.Rectangle GetWorkingArea(System.Drawing.Point)
				L_000b: stloc.0 
				L_000c: ldarg.0 
				L_000d: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x07658cf2bdd49693
				L_0012: stloc.1 
				L_0013: ldloca.s V_0
				L_0015: call System.Drawing.Rectangle::Int32 get_Width()
				L_001a: pop 
				L_001b: ldloca.s V_0
				L_001d: call System.Drawing.Rectangle::Int32 get_Left()
				L_0022: stloc.2 
				L_0023: ldloca.s V_0
				L_0025: call System.Drawing.Rectangle::Int32 get_Right()
				L_002a: stloc.3 
				L_002b: ldloca.s V_0
				L_002d: call System.Drawing.Rectangle::Int32 get_Height()
				L_0032: pop 
				L_0033: ldloca.s V_0
				L_0035: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_003a: stloc.s V_4
				L_003c: ldloca.s V_0
				L_003e: call System.Drawing.Rectangle::Int32 get_Top()
				L_0043: stloc.s V_5
				L_0045: ldarg.0 
				L_0046: ldc.i4.1 
				L_0047: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc1dccd328eafa426
				L_004c: ldarg.0 
				L_004d: ldc.i4.0 
				L_004e: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xec9ddb74d7a61c81
				L_0053: ldarga.s x001544edc57babc2
				L_0055: dup 
				L_0056: call System.Drawing.Size::Int32 get_Width()
				L_005b: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0060: ldc.i4.0 
				L_0061: ldc.i4.s 16
				L_0063: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0068: sub 
				L_0069: call System.Drawing.Size::Void set_Width(Int32)
				L_006e: ldarg.0 
				L_006f: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x8e0eb9fe60b28fae
				L_0074: brfalse L_0164
				L_0079: ldloca.s V_1
				L_007b: call System.Drawing.Point::Int32 get_Y()
				L_0080: ldarga.s x001544edc57babc2
				L_0082: call System.Drawing.Size::Int32 get_Height()
				L_0087: add 
				L_0088: ldloc.s V_4
				L_008a: ble L_01bb
				L_008f: ldarg.0 
				L_0090: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_0095: brfalse.s L_00e9
				L_0097: ldarg.0 
				L_0098: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_009d: brtrue.s L_00e9
				L_009f: ldarg.0 
				L_00a0: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x1ee5f8430343bccd
				L_00a5: call System.Drawing.Point::Int32 get_Y()
				L_00aa: ldarga.s x001544edc57babc2
				L_00ac: call System.Drawing.Size::Int32 get_Height()
				L_00b1: sub 
				L_00b2: ldloc.s V_5
				L_00b4: ble.s L_00e9
				L_00b6: ldloca.s V_1
				L_00b8: ldarg.0 
				L_00b9: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x1ee5f8430343bccd
				L_00be: call System.Drawing.Point::Int32 get_Y()
				L_00c3: ldarga.s x001544edc57babc2
				L_00c5: call System.Drawing.Size::Int32 get_Height()
				L_00ca: sub 
				L_00cb: call System.Drawing.Point::Void set_Y(Int32)
				L_00d0: ldarg.0 
				L_00d1: ldc.i4.0 
				L_00d2: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x8e0eb9fe60b28fae
				L_00d7: ldarg.0 
				L_00d8: ldc.i4.0 
				L_00d9: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc1dccd328eafa426
				L_00de: ldarg.0 
				L_00df: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_00e4: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xd502a472a14a9c04()
				L_00e9: ldloca.s V_1
				L_00eb: call System.Drawing.Point::Int32 get_Y()
				L_00f0: ldarga.s x001544edc57babc2
				L_00f2: call System.Drawing.Size::Int32 get_Height()
				L_00f7: add 
				L_00f8: ldloc.s V_4
				L_00fa: ble L_01bb
				L_00ff: ldarg.0 
				L_0100: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0105: brfalse.s L_014f
				L_0107: ldarg.0 
				L_0108: ldc.i4.0 
				L_0109: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x8e0eb9fe60b28fae
				L_010e: ldarg.0 
				L_010f: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x1ee5f8430343bccd
				L_0114: call System.Drawing.Point::Int32 get_Y()
				L_0119: ldarga.s x001544edc57babc2
				L_011b: call System.Drawing.Size::Int32 get_Height()
				L_0120: sub 
				L_0121: ldloc.s V_5
				L_0123: ble.s L_0144
				L_0125: ldloca.s V_1
				L_0127: ldarg.0 
				L_0128: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x1ee5f8430343bccd
				L_012d: call System.Drawing.Point::Int32 get_Y()
				L_0132: ldarga.s x001544edc57babc2
				L_0134: call System.Drawing.Size::Int32 get_Height()
				L_0139: sub 
				L_013a: call System.Drawing.Point::Void set_Y(Int32)
				L_013f: br L_01bb
				L_0144: ldloca.s V_1
				L_0146: ldloc.s V_5
				L_0148: call System.Drawing.Point::Void set_Y(Int32)
				L_014d: br.s L_01bb
				L_014f: ldloca.s V_1
				L_0151: ldloc.s V_4
				L_0153: ldarga.s x001544edc57babc2
				L_0155: call System.Drawing.Size::Int32 get_Height()
				L_015a: sub 
				L_015b: ldc.i4.1 
				L_015c: sub 
				L_015d: call System.Drawing.Point::Void set_Y(Int32)
				L_0162: br.s L_01bb
				L_0164: ldloca.s V_1
				L_0166: call System.Drawing.Point::Int32 get_Y()
				L_016b: ldarga.s x001544edc57babc2
				L_016d: call System.Drawing.Size::Int32 get_Height()
				L_0172: sub 
				L_0173: ldloc.s V_5
				L_0175: bge.s L_01a6
				L_0177: ldarg.0 
				L_0178: ldc.i4.1 
				L_0179: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x8e0eb9fe60b28fae
				L_017e: ldloca.s V_1
				L_0180: call System.Drawing.Point::Int32 get_Y()
				L_0185: ldarga.s x001544edc57babc2
				L_0187: call System.Drawing.Size::Int32 get_Height()
				L_018c: add 
				L_018d: ldloc.s V_4
				L_018f: ble.s L_01bb
				L_0191: ldloca.s V_1
				L_0193: ldloc.s V_4
				L_0195: ldarga.s x001544edc57babc2
				L_0197: call System.Drawing.Size::Int32 get_Height()
				L_019c: sub 
				L_019d: ldc.i4.1 
				L_019e: sub 
				L_019f: call System.Drawing.Point::Void set_Y(Int32)
				L_01a4: br.s L_01bb
				L_01a6: ldloca.s V_1
				L_01a8: dup 
				L_01a9: call System.Drawing.Point::Int32 get_Y()
				L_01ae: ldarga.s x001544edc57babc2
				L_01b0: call System.Drawing.Size::Int32 get_Height()
				L_01b5: sub 
				L_01b6: call System.Drawing.Point::Void set_Y(Int32)
				L_01bb: ldarg.0 
				L_01bc: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc8609d9b3214b3e7
				L_01c1: brfalse L_0249
				L_01c6: ldloca.s V_1
				L_01c8: call System.Drawing.Point::Int32 get_X()
				L_01cd: ldarga.s x001544edc57babc2
				L_01cf: call System.Drawing.Size::Int32 get_Width()
				L_01d4: add 
				L_01d5: ldloc.3 
				L_01d6: ble L_02c7
				L_01db: ldarg.0 
				L_01dc: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_01e1: brfalse.s L_021e
				L_01e3: ldarg.0 
				L_01e4: ldc.i4.0 
				L_01e5: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc8609d9b3214b3e7
				L_01ea: ldloca.s V_1
				L_01ec: ldarg.0 
				L_01ed: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point xcbbe945601aff7c8
				L_01f2: call System.Drawing.Point::Int32 get_X()
				L_01f7: ldarga.s x001544edc57babc2
				L_01f9: call System.Drawing.Size::Int32 get_Width()
				L_01fe: sub 
				L_01ff: call System.Drawing.Point::Void set_X(Int32)
				L_0204: ldloca.s V_1
				L_0206: call System.Drawing.Point::Int32 get_X()
				L_020b: ldloc.2 
				L_020c: bge L_02c7
				L_0211: ldloca.s V_1
				L_0213: ldloc.2 
				L_0214: call System.Drawing.Point::Void set_X(Int32)
				L_0219: br L_02c7
				L_021e: ldloc.3 
				L_021f: ldarga.s x001544edc57babc2
				L_0221: call System.Drawing.Size::Int32 get_Width()
				L_0226: sub 
				L_0227: ldc.i4.1 
				L_0228: sub 
				L_0229: stloc.s V_6
				L_022b: ldarg.0 
				L_022c: ldloca.s V_1
				L_022e: call System.Drawing.Point::Int32 get_X()
				L_0233: ldloc.s V_6
				L_0235: sub 
				L_0236: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xec9ddb74d7a61c81
				L_023b: ldloca.s V_1
				L_023d: ldloc.s V_6
				L_023f: call System.Drawing.Point::Void set_X(Int32)
				L_0244: br L_02c7
				L_0249: ldloca.s V_1
				L_024b: ldarg.0 
				L_024c: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point xcbbe945601aff7c8
				L_0251: call System.Drawing.Point::Int32 get_X()
				L_0256: call System.Drawing.Point::Void set_X(Int32)
				L_025b: ldloca.s V_1
				L_025d: call System.Drawing.Point::Int32 get_X()
				L_0262: ldarga.s x001544edc57babc2
				L_0264: call System.Drawing.Size::Int32 get_Width()
				L_0269: sub 
				L_026a: ldloc.2 
				L_026b: bge.s L_02b2
				L_026d: ldarg.0 
				L_026e: ldc.i4.1 
				L_026f: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc8609d9b3214b3e7
				L_0274: ldarg.0 
				L_0275: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x07658cf2bdd49693
				L_027a: call System.Drawing.Point::Int32 get_X()
				L_027f: ldarga.s x001544edc57babc2
				L_0281: call System.Drawing.Size::Int32 get_Width()
				L_0286: add 
				L_0287: ldloc.3 
				L_0288: ble.s L_029e
				L_028a: ldloca.s V_1
				L_028c: ldloc.3 
				L_028d: ldarga.s x001544edc57babc2
				L_028f: call System.Drawing.Size::Int32 get_Width()
				L_0294: sub 
				L_0295: ldc.i4.1 
				L_0296: sub 
				L_0297: call System.Drawing.Point::Void set_X(Int32)
				L_029c: br.s L_02c7
				L_029e: ldloca.s V_1
				L_02a0: ldarg.0 
				L_02a1: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x07658cf2bdd49693
				L_02a6: call System.Drawing.Point::Int32 get_X()
				L_02ab: call System.Drawing.Point::Void set_X(Int32)
				L_02b0: br.s L_02c7
				L_02b2: ldloca.s V_1
				L_02b4: dup 
				L_02b5: call System.Drawing.Point::Int32 get_X()
				L_02ba: ldarga.s x001544edc57babc2
				L_02bc: call System.Drawing.Size::Int32 get_Width()
				L_02c1: sub 
				L_02c2: call System.Drawing.Point::Void set_X(Int32)
				L_02c7: ldloc.1 
				L_02c8: ret 
			*/
			
			
			{
				int i5;
				Rectangle rectangle1 = Screen.GetWorkingArea (this.x07658cf2bdd49693);
				Point point1 = this.x07658cf2bdd49693;
				int i6 = rectangle1.Width;
				int i1 = rectangle1.Left;
				int i2 = rectangle1.Right;
				int i7 = rectangle1.Height;
				int i3 = rectangle1.Bottom;
				int i4 = rectangle1.Top;
				this.xc1dccd328eafa426 = true;
				this.xec9ddb74d7a61c81 = 0;
				x001544edc57babc2.Width -= x902c4aee45bfd906._x13d4cb8d1bd20347[0, 16];
				if (this.x8e0eb9fe60b28fae)
				{
					if ((point1.Y + x001544edc57babc2.Height) > i3)
					{
						if (((this.x37f2fc2a7f30f790 != null) && (this.xb13f2de377f27597 == null)) && ((this.x1ee5f8430343bccd.Y - x001544edc57babc2.Height) > i4))
						{
							point1.Y = (this.x1ee5f8430343bccd.Y - x001544edc57babc2.Height);
							this.x8e0eb9fe60b28fae = false;
							this.xc1dccd328eafa426 = false;
							this.x37f2fc2a7f30f790.xd502a472a14a9c04 ();
						}
						if ((point1.Y + x001544edc57babc2.Height) > i3)
						{
							if (this.xb13f2de377f27597 == null)
							{
								point1.Y = ((i3 - x001544edc57babc2.Height) - 1);
							}
							else
							{
								this.x8e0eb9fe60b28fae = false;
								if ((this.x1ee5f8430343bccd.Y - x001544edc57babc2.Height) <= i4)
								{
									point1.Y = i4;
								}
								else
								{
									point1.Y = (this.x1ee5f8430343bccd.Y - x001544edc57babc2.Height);
								}
							}
						}
					}
				}
				else if ((point1.Y - x001544edc57babc2.Height) < i4)
				{
					this.x8e0eb9fe60b28fae = true;
					if ((point1.Y + x001544edc57babc2.Height) > i3)
					{
						point1.Y = ((i3 - x001544edc57babc2.Height) - 1);
					}
				}
				else
				{
					point1.Y -= x001544edc57babc2.Height;
				}
				if (! this.xc8609d9b3214b3e7)
				{
					point1.X = this.xcbbe945601aff7c8.X;
					if ((point1.X - x001544edc57babc2.Width) < i1)
					{
						this.xc8609d9b3214b3e7 = true;
						if ((this.x07658cf2bdd49693.X + x001544edc57babc2.Width) > i2)
						{
							point1.X = ((i2 - x001544edc57babc2.Width) - 1);
						}
						else
						{
							point1.X = this.x07658cf2bdd49693.X;
						}
					}
					else
					{
						point1.X -= x001544edc57babc2.Width;
					}
				}
				else if ((point1.X + x001544edc57babc2.Width) > i2)
				{
					if (this.xb13f2de377f27597 != null)
					{
						this.xc8609d9b3214b3e7 = false;
						point1.X = (this.xcbbe945601aff7c8.X - x001544edc57babc2.Width);
						if (point1.X < i1)
						{
							point1.X = i1;
						}
					}
					else
					{
						i5 = ((i2 - x001544edc57babc2.Width) - 1);
						this.xec9ddb74d7a61c81 = (point1.X - i5);
						point1.X = i5;
					}
				}
				return point1;
			}
			
			protected x5f4b657f68f87baa x6e4244e25732db7d (Point x9348d50e682f780a, Point xf361a72b1913ee9f, xd53b20b7b4b2a08a x2ac8fd3ce3986cdc, x902c4aee45bfd906 xb13f2de377f27597, bool xacc37ebdd71fcc44, x3c41176af7e54b01 x37f2fc2a7f30f790, bool xc8609d9b3214b3e7, bool x8e0eb9fe60b28fae, bool x0a7391c99fcdc469, ref int x0cd2bb383a46f073)
			
			/*
				// Code Size: 123 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a V_0, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_1)
				L_0000: ldarg.0 
				L_0001: ldc.i4.1 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_0007: ldarg.0 
				L_0008: ldarg.s x37f2fc2a7f30f790
				L_000a: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_000f: ldarg.0 
				L_0010: ldarg.s xb13f2de377f27597
				L_0012: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0017: ldarg.0 
				L_0018: ldarg.s x0a7391c99fcdc469
				L_001a: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x0a7391c99fcdc469
				L_001f: ldarg.0 
				L_0020: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0025: stloc.0 
				L_0026: ldarg.0 
				L_0027: ldarg.3 
				L_0028: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_002d: ldarg.0 
				L_002e: ldarg.1 
				L_002f: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x07658cf2bdd49693
				L_0034: ldarg.0 
				L_0035: ldarg.1 
				L_0036: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x1ee5f8430343bccd
				L_003b: ldarg.0 
				L_003c: ldarg.2 
				L_003d: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point xcbbe945601aff7c8
				L_0042: ldarg.0 
				L_0043: ldarg.s xc8609d9b3214b3e7
				L_0045: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc8609d9b3214b3e7
				L_004a: ldarg.0 
				L_004b: ldarg.s x8e0eb9fe60b28fae
				L_004d: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x8e0eb9fe60b28fae
				L_0052: ldarg.0 
				L_0053: ldarg.s xacc37ebdd71fcc44
				L_0055: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x6e4244e25732db7d(Boolean)
				L_005a: stloc.1 
				L_005b: ldarg.0 
				L_005c: ldloc.0 
				L_005d: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0062: ldarg.0 
				L_0063: ldnull 
				L_0064: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_0069: ldarg.0 
				L_006a: ldnull 
				L_006b: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0070: ldarg.0 
				L_0071: ldarg.s x0cd2bb383a46f073
				L_0073: ldind.i4 
				L_0074: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x0cd2bb383a46f073
				L_0079: ldloc.1 
				L_007a: ret 
			*/
			
			
			{
				this.x23e85093ba3a7d1d = xdbfa333b4cd503e0.x3bce7c87328df8da;
				this.x37f2fc2a7f30f790 = x37f2fc2a7f30f790;
				this.xb13f2de377f27597 = xb13f2de377f27597;
				this.x0a7391c99fcdc469 = x0a7391c99fcdc469;
				xd53b20b7b4b2a08a xd53b20b7b4b2a08a1 = this.xf4f555905eaa2330;
				this.xf4f555905eaa2330 = x2ac8fd3ce3986cdc;
				this.x07658cf2bdd49693 = x9348d50e682f780a;
				this.x1ee5f8430343bccd = x9348d50e682f780a;
				this.xcbbe945601aff7c8 = xf361a72b1913ee9f;
				this.xc8609d9b3214b3e7 = xc8609d9b3214b3e7;
				this.x8e0eb9fe60b28fae = x8e0eb9fe60b28fae;
				x5f4b657f68f87baa x5f4b657f68f87baa1 = this.x6e4244e25732db7d (xacc37ebdd71fcc44);
				this.xf4f555905eaa2330 = xd53b20b7b4b2a08a1;
				this.x37f2fc2a7f30f790 = ((x3c41176af7e54b01) null);
				this.xb13f2de377f27597 = ((x902c4aee45bfd906) null);
				this.x0cd2bb383a46f073 = x0cd2bb383a46f073;
				return x5f4b657f68f87baa1;
			}
			
			protected x5f4b657f68f87baa x6e4244e25732db7d (bool xacc37ebdd71fcc44)
			
			/*
				// Code Size: 1607 Bytes
				.maxstack 6
				.locals (System.Boolean V_0, 
         Sunisoft.IrisSkin.x40255b11ef821fa3+MSG V_1, 
         System.Boolean V_2, 
         System.Boolean V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         Sunisoft.IrisSkin.x555516122dcc901e+POINT V_6, 
         Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 V_7, 
         Sunisoft.IrisSkin.x555516122dcc901e+POINT V_8, 
         Sunisoft.IrisSkin.x555516122dcc901e+POINT V_9, 
         Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 V_10, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_11, 
         System.Int32 V_12, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_13, 
         Sunisoft.IrisSkin.x40255b11ef821fa3+MSG V_14, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_15, 
         System.Int32 V_16)
				.try L_0000 to L_063e catch System.Exception L_063e to L_0644
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_0007: ldarg.0 
				L_0008: ldc.i4.m1 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_000e: ldarg.0 
				L_000f: ldc.i4.0 
				L_0010: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_0015: ldarg.0 
				L_0016: ldc.i4.0 
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x753f06f9b5cd6e0d
				L_001c: ldarg.0 
				L_001d: ldc.i4.0 
				L_001e: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x0cd2bb383a46f073
				L_0023: ldc.i4.0 
				L_0024: stloc.0 
				L_0025: ldarg.0 
				L_0026: ldc.i4.1 
				L_0027: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x20ad2840ee62b6a4
				L_002c: ldarg.0 
				L_002d: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xb3525a0e7d2fd376()
				L_0032: ldloca.s V_1
				L_0034: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+MSG
				L_003a: ldarg.1 
				L_003b: brfalse.s L_0044
				L_003d: ldarg.0 
				L_003e: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x5b2e42a68d835b31()
				L_0043: pop 
				L_0044: ldsfld System.IntPtr::IntPtr Zero
				L_0049: ldc.i4 32512
				L_004e: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr LoadCursor(IntPtr, UInt32)
				L_0053: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SetCursor(IntPtr)
				L_0058: pop 
				L_0059: ldsfld System.IntPtr::IntPtr Zero
				L_005e: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean HideCaret(IntPtr)
				L_0063: stloc.2 
				L_0064: br L_05d8
				L_0069: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean WaitMessage()
				L_006e: brfalse L_05d8
				L_0073: br L_05c0
				L_0078: ldc.i4.0 
				L_0079: stloc.3 
				L_007a: ldarg.0 
				L_007b: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Size x86ef051842f1ae49
				L_0080: call System.Drawing.Size::Int32 get_Width()
				L_0085: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_008a: ldc.i4.0 
				L_008b: ldc.i4.s 16
				L_008d: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0092: sub 
				L_0093: stloc.s V_4
				L_0095: ldarg.0 
				L_0096: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Size x86ef051842f1ae49
				L_009b: call System.Drawing.Size::Int32 get_Height()
				L_00a0: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_00a5: ldc.i4.0 
				L_00a6: ldc.i4.s 17
				L_00a8: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_00ad: sub 
				L_00ae: stloc.s V_5
				L_00b0: ldloca.s V_1
				L_00b2: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_00b7: ldc.i4 514
				L_00bc: beq.s L_0123
				L_00be: ldloca.s V_1
				L_00c0: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_00c5: ldc.i4 520
				L_00ca: beq.s L_0123
				L_00cc: ldloca.s V_1
				L_00ce: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_00d3: ldc.i4 517
				L_00d8: beq.s L_0123
				L_00da: ldloca.s V_1
				L_00dc: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_00e1: ldc.i4 524
				L_00e6: beq.s L_0123
				L_00e8: ldloca.s V_1
				L_00ea: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_00ef: ldc.i4 162
				L_00f4: beq.s L_0123
				L_00f6: ldloca.s V_1
				L_00f8: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_00fd: ldc.i4 168
				L_0102: beq.s L_0123
				L_0104: ldloca.s V_1
				L_0106: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_010b: ldc.i4 165
				L_0110: beq.s L_0123
				L_0112: ldloca.s V_1
				L_0114: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0119: ldc.i4 172
				L_011e: bne.un L_01c1
				L_0123: ldarg.0 
				L_0124: ldloc.1 
				L_0125: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::POINT x4b688849d80162f6(MSG)
				L_012a: stloc.s V_6
				L_012c: ldloca.s V_6
				L_012e: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0133: ldarg.0 
				L_0134: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0139: call System.Drawing.Point::Int32 get_X()
				L_013e: blt.s L_019a
				L_0140: ldloca.s V_6
				L_0142: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0147: ldarg.0 
				L_0148: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_014d: call System.Drawing.Point::Int32 get_X()
				L_0152: ldloc.s V_4
				L_0154: add 
				L_0155: bgt.s L_019a
				L_0157: ldloca.s V_6
				L_0159: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_015e: ldarg.0 
				L_015f: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0164: call System.Drawing.Point::Int32 get_Y()
				L_0169: blt.s L_019a
				L_016b: ldloca.s V_6
				L_016d: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_0172: ldarg.0 
				L_0173: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0178: call System.Drawing.Point::Int32 get_Y()
				L_017d: ldloc.s V_5
				L_017f: add 
				L_0180: bgt.s L_019a
				L_0182: ldarg.0 
				L_0183: ldloca.s V_6
				L_0185: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_018a: ldloca.s V_6
				L_018c: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_0191: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xd6cfa3f3f3125e82(Int32, Int32)
				L_0196: ldc.i4.1 
				L_0197: stloc.3 
				L_0198: br.s L_01c1
				L_019a: ldarg.0 
				L_019b: ldloc.s V_6
				L_019d: ldloca.s V_1
				L_019f: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x3c6f7570c20e3f7d(POINT, MSG ByRef)
				L_01a4: stloc.s V_7
				L_01a6: ldloc.s V_7
				L_01a8: brfalse.s L_01c1
				L_01aa: ldloc.s V_7
				L_01ac: ldloca.s V_6
				L_01ae: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_01b3: ldloca.s V_6
				L_01b5: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_01ba: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xd6cfa3f3f3125e82(Int32, Int32)
				L_01bf: ldc.i4.1 
				L_01c0: stloc.3 
				L_01c1: ldloca.s V_1
				L_01c3: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_01c8: ldc.i4 513
				L_01cd: beq.s L_0234
				L_01cf: ldloca.s V_1
				L_01d1: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_01d6: ldc.i4 519
				L_01db: beq.s L_0234
				L_01dd: ldloca.s V_1
				L_01df: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_01e4: ldc.i4 516
				L_01e9: beq.s L_0234
				L_01eb: ldloca.s V_1
				L_01ed: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_01f2: ldc.i4 523
				L_01f7: beq.s L_0234
				L_01f9: ldloca.s V_1
				L_01fb: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0200: ldc.i4 161
				L_0205: beq.s L_0234
				L_0207: ldloca.s V_1
				L_0209: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_020e: ldc.i4 167
				L_0213: beq.s L_0234
				L_0215: ldloca.s V_1
				L_0217: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_021c: ldc.i4 164
				L_0221: beq.s L_0234
				L_0223: ldloca.s V_1
				L_0225: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_022a: ldc.i4 171
				L_022f: bne.un L_02f0
				L_0234: ldarg.0 
				L_0235: ldloc.1 
				L_0236: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::POINT x4b688849d80162f6(MSG)
				L_023b: stloc.s V_8
				L_023d: ldloca.s V_8
				L_023f: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0244: ldarg.0 
				L_0245: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_024a: call System.Drawing.Point::Int32 get_X()
				L_024f: blt.s L_0297
				L_0251: ldloca.s V_8
				L_0253: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0258: ldarg.0 
				L_0259: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_025e: call System.Drawing.Point::Int32 get_X()
				L_0263: ldloc.s V_4
				L_0265: add 
				L_0266: bgt.s L_0297
				L_0268: ldloca.s V_8
				L_026a: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_026f: ldarg.0 
				L_0270: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0275: call System.Drawing.Point::Int32 get_Y()
				L_027a: blt.s L_0297
				L_027c: ldloca.s V_8
				L_027e: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_0283: ldarg.0 
				L_0284: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0289: call System.Drawing.Point::Int32 get_Y()
				L_028e: ldloc.s V_5
				L_0290: add 
				L_0291: bgt.s L_0297
				L_0293: ldc.i4.1 
				L_0294: stloc.3 
				L_0295: br.s L_02f0
				L_0297: ldarg.0 
				L_0298: ldloc.s V_8
				L_029a: ldloca.s V_1
				L_029c: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x3c6f7570c20e3f7d(POINT, MSG ByRef)
				L_02a1: brtrue.s L_02ee
				L_02a3: ldarg.0 
				L_02a4: ldloc.s V_8
				L_02a6: ldloca.s V_1
				L_02a8: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x277ff37e12aff68b(POINT, MSG ByRef)
				L_02ad: brfalse.s L_02c0
				L_02af: ldarg.0 
				L_02b0: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_02b5: ldloc.s V_8
				L_02b7: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x2ea07c3ab5d970d4(POINT)
				L_02bc: ldc.i4.1 
				L_02bd: stloc.3 
				L_02be: br.s L_02f0
				L_02c0: ldarg.0 
				L_02c1: ldc.i4.1 
				L_02c2: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_02c7: ldc.i4.1 
				L_02c8: stloc.0 
				L_02c9: ldarg.0 
				L_02ca: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_02cf: brfalse.s L_02f0
				L_02d1: ldloca.s V_1
				L_02d3: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr hwnd
				L_02d8: ldarg.0 
				L_02d9: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_02de: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_02e3: call System.IntPtr::Boolean op_Equality(IntPtr, IntPtr)
				L_02e8: brfalse.s L_02f0
				L_02ea: ldc.i4.0 
				L_02eb: stloc.0 
				L_02ec: br.s L_02f0
				L_02ee: ldc.i4.1 
				L_02ef: stloc.3 
				L_02f0: ldloca.s V_1
				L_02f2: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_02f7: ldc.i4 512
				L_02fc: bne.un L_03c6
				L_0301: ldarg.0 
				L_0302: ldloc.1 
				L_0303: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::POINT x4b688849d80162f6(MSG)
				L_0308: stloc.s V_9
				L_030a: ldloca.s V_9
				L_030c: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0311: ldarg.0 
				L_0312: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0317: call System.Drawing.Point::Int32 get_X()
				L_031c: blt.s L_0376
				L_031e: ldloca.s V_9
				L_0320: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0325: ldarg.0 
				L_0326: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_032b: call System.Drawing.Point::Int32 get_X()
				L_0330: ldloc.s V_4
				L_0332: add 
				L_0333: bgt.s L_0376
				L_0335: ldloca.s V_9
				L_0337: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_033c: ldarg.0 
				L_033d: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0342: call System.Drawing.Point::Int32 get_Y()
				L_0347: blt.s L_0376
				L_0349: ldloca.s V_9
				L_034b: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_0350: ldarg.0 
				L_0351: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0356: call System.Drawing.Point::Int32 get_Y()
				L_035b: ldloc.s V_5
				L_035d: add 
				L_035e: bgt.s L_0376
				L_0360: ldarg.0 
				L_0361: ldloca.s V_9
				L_0363: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0368: ldloca.s V_9
				L_036a: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_036f: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x136735fdfe6d04ea(Int32, Int32)
				L_0374: br.s L_03c4
				L_0376: ldarg.0 
				L_0377: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x753f06f9b5cd6e0d
				L_037c: brfalse.s L_0384
				L_037e: ldarg.0 
				L_037f: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xa84c74b103039157()
				L_0384: ldarg.0 
				L_0385: ldloc.s V_9
				L_0387: ldloca.s V_1
				L_0389: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x3c6f7570c20e3f7d(POINT, MSG ByRef)
				L_038e: stloc.s V_10
				L_0390: ldloc.s V_10
				L_0392: brfalse.s L_03ab
				L_0394: ldloc.s V_10
				L_0396: ldloca.s V_9
				L_0398: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_039d: ldloca.s V_9
				L_039f: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_03a4: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x136735fdfe6d04ea(Int32, Int32)
				L_03a9: br.s L_03c4
				L_03ab: ldarg.0 
				L_03ac: ldloc.s V_9
				L_03ae: ldloca.s V_1
				L_03b0: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x277ff37e12aff68b(POINT, MSG ByRef)
				L_03b5: brfalse.s L_03c4
				L_03b7: ldarg.0 
				L_03b8: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_03bd: ldloc.s V_9
				L_03bf: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x136735fdfe6d04ea(POINT)
				L_03c4: ldc.i4.1 
				L_03c5: stloc.3 
				L_03c6: ldloca.s V_1
				L_03c8: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_03cd: ldc.i4.s 32
				L_03cf: bne.un.s L_03d9
				L_03d1: ldarg.0 
				L_03d2: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x773209141f430902()
				L_03d7: ldc.i4.1 
				L_03d8: stloc.3 
				L_03d9: ldloca.s V_1
				L_03db: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_03e0: ldc.i4 260
				L_03e5: bne.un.s L_040c
				L_03e7: ldloca.s V_1
				L_03e9: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr wParam
				L_03ee: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_03f3: ldc.i4.s 18
				L_03f5: bne.un.s L_0400
				L_03f7: ldarg.0 
				L_03f8: ldc.i4.1 
				L_03f9: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_03fe: br.s L_040c
				L_0400: ldloca.s V_1
				L_0402: ldc.i4 256
				L_0407: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_040c: ldloca.s V_1
				L_040e: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0413: ldc.i4 256
				L_0418: bne.un L_0543
				L_041d: ldloca.s V_1
				L_041f: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr wParam
				L_0424: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_0429: stloc.s V_16
				L_042b: ldloc.s V_16
				L_042d: ldc.i4.s 13
				L_042f: beq.s L_048e
				L_0431: ldloc.s V_16
				L_0433: ldc.i4.s 27
				L_0435: beq L_04f6
				L_043a: ldloc.s V_16
				L_043c: ldc.i4.s 37
				L_043e: sub 
				L_043f: switch (L_0471, L_0459, L_047c, L_0465)
				L_0454: br L_04ff
				L_0459: ldarg.0 
				L_045a: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x5437d760e9a6340b()
				L_045f: pop 
				L_0460: br L_0543
				L_0465: ldarg.0 
				L_0466: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x5b2e42a68d835b31()
				L_046b: pop 
				L_046c: br L_0543
				L_0471: ldarg.0 
				L_0472: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x0e37e200024f43ba()
				L_0477: br L_0543
				L_047c: ldarg.0 
				L_047d: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xb2aa7fc859b3d5b7()
				L_0482: brfalse L_0543
				L_0487: ldc.i4.1 
				L_0488: stloc.0 
				L_0489: br L_0543
				L_048e: ldarg.0 
				L_048f: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0494: ldc.i4.m1 
				L_0495: beq L_0543
				L_049a: ldarg.0 
				L_049b: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_04a0: ldarg.0 
				L_04a1: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_04a6: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_04ab: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_04b0: stloc.s V_11
				L_04b2: ldloc.s V_11
				L_04b4: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x649e2ad374251b5f()
				L_04b9: brfalse.s L_04cf
				L_04bb: ldarg.0 
				L_04bc: ldarg.0 
				L_04bd: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_04c2: ldc.i4.0 
				L_04c3: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x0760506d6abf77a2(Int32, Boolean)
				L_04c8: ldc.i4.1 
				L_04c9: stloc.0 
				L_04ca: br L_0543
				L_04cf: ldloc.s V_11
				L_04d1: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xc1facdb08ad4967a()
				L_04d6: brfalse.s L_04e0
				L_04d8: ldarg.0 
				L_04d9: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x057464a452da34b7()
				L_04de: br.s L_0543
				L_04e0: ldarg.0 
				L_04e1: ldloc.s V_11
				L_04e3: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_04e8: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_04ed: ldarg.0 
				L_04ee: ldc.i4.1 
				L_04ef: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_04f4: br.s L_0543
				L_04f6: ldarg.0 
				L_04f7: ldc.i4.1 
				L_04f8: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_04fd: br.s L_0543
				L_04ff: ldarg.0 
				L_0500: ldloca.s V_1
				L_0502: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr wParam
				L_0507: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_050c: conv.u2 
				L_050d: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x65c1cc54cc8b0e75(Char)
				L_0512: stloc.s V_12
				L_0514: ldloc.s V_12
				L_0516: ldc.i4.m1 
				L_0517: beq.s L_0543
				L_0519: ldarg.0 
				L_051a: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_051f: ldloc.s V_12
				L_0521: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0526: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_052b: stloc.s V_13
				L_052d: ldarg.0 
				L_052e: ldloc.s V_13
				L_0530: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0535: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_053a: ldarg.0 
				L_053b: ldc.i4.1 
				L_053c: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_0541: ldc.i4.1 
				L_0542: stloc.0 
				L_0543: ldloca.s V_1
				L_0545: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_054a: ldc.i4 256
				L_054f: beq.s L_057b
				L_0551: ldloca.s V_1
				L_0553: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0558: ldc.i4 257
				L_055d: beq.s L_057b
				L_055f: ldloca.s V_1
				L_0561: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0566: ldc.i4 260
				L_056b: beq.s L_057b
				L_056d: ldloca.s V_1
				L_056f: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0574: ldc.i4 261
				L_0579: bne.un.s L_057d
				L_057b: ldc.i4.1 
				L_057c: stloc.3 
				L_057d: ldloc.3 
				L_057e: brfalse.s L_0599
				L_0580: ldloca.s V_14
				L_0582: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+MSG
				L_0588: ldloca.s V_14
				L_058a: ldsfld System.IntPtr::IntPtr Zero
				L_058f: ldc.i4.0 
				L_0590: ldc.i4.0 
				L_0591: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetMessage(MSG ByRef, IntPtr, UInt32, UInt32)
				L_0596: pop 
				L_0597: br.s L_05c0
				L_0599: ldloc.0 
				L_059a: brtrue.s L_05be
				L_059c: ldloca.s V_1
				L_059e: ldsfld System.IntPtr::IntPtr Zero
				L_05a3: ldc.i4.0 
				L_05a4: ldc.i4.0 
				L_05a5: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetMessage(MSG ByRef, IntPtr, UInt32, UInt32)
				L_05aa: brfalse.s L_05c0
				L_05ac: ldloca.s V_1
				L_05ae: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean TranslateMessage(MSG ByRef)
				L_05b3: pop 
				L_05b4: ldloca.s V_1
				L_05b6: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr DispatchMessage(MSG ByRef)
				L_05bb: pop 
				L_05bc: br.s L_05c0
				L_05be: ldc.i4.0 
				L_05bf: stloc.0 
				L_05c0: ldarg.0 
				L_05c1: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_05c6: brtrue.s L_05d8
				L_05c8: ldloca.s V_1
				L_05ca: ldc.i4.0 
				L_05cb: ldc.i4.0 
				L_05cc: ldc.i4.0 
				L_05cd: ldc.i4.0 
				L_05ce: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PeekMessage(MSG ByRef, Int32, UInt32, UInt32, UInt32)
				L_05d3: brtrue L_0078
				L_05d8: ldarg.0 
				L_05d9: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_05de: brfalse L_0069
				L_05e3: ldloc.2 
				L_05e4: brfalse.s L_05f1
				L_05e6: ldsfld System.IntPtr::IntPtr Zero
				L_05eb: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean ShowCaret(IntPtr)
				L_05f0: pop 
				L_05f1: ldarg.0 
				L_05f2: ldarg.0 
				L_05f3: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_05f8: ldc.i4.m1 
				L_05f9: ldc.i4.0 
				L_05fa: ldc.i4.0 
				L_05fb: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xeb515a5b77846afe(Int32, Int32, Boolean, Boolean)
				L_0600: ldarg.0 
				L_0601: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x4139e66e6dfaac52()
				L_0606: ldarg.0 
				L_0607: callvirt System.Windows.Forms.NativeWindow::Void DestroyHandle()
				L_060c: ldarg.0 
				L_060d: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0612: brtrue.s L_0634
				L_0614: ldarg.0 
				L_0615: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_061a: brfalse.s L_0634
				L_061c: ldarg.0 
				L_061d: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_0622: brtrue.s L_0634
				L_0624: ldarg.0 
				L_0625: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_062a: ldsfld System.EventArgs::System.EventArgs Empty
				L_062f: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnClick(System.EventArgs)
				L_0634: ldarg.0 
				L_0635: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_063a: stloc.s V_15
				L_063c: leave.s L_0644
				L_063e: pop 
				L_063f: ldnull 
				L_0640: stloc.s V_15
				L_0642: leave.s L_0644
				L_0644: ldloc.s V_15
				L_0646: ret 
			*/
			
			
			{
				bool b1;
				x40255b11ef821fa3.MSG mSG1;
				bool b2;
				bool b3;
				int i1;
				int i2;
				x555516122dcc901e.POINT pOINT1;
				x902c4aee45bfd906 x902c4aee45bfd906_1;
				x555516122dcc901e.POINT pOINT2;
				x555516122dcc901e.POINT pOINT3;
				x902c4aee45bfd906 x902c4aee45bfd906_2;
				x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				int i3;
				x2cc390e9409b0f3f x2cc390e9409b0f3f2;
				x40255b11ef821fa3.MSG mSG2;
				x5f4b657f68f87baa x5f4b657f68f87baa1;
				int i4;
				try
				{
					this.x4547ebd0fd2a7079 = ((x5f4b657f68f87baa) null);
					this.xb266b78561d63b52 = -1;
					this.x9a75ed38d1972c87 = false;
					this.x753f06f9b5cd6e0d = false;
					this.x0cd2bb383a46f073 = 0;
					b1 = false;
					this.x20ad2840ee62b6a4 = true;
					this.xb3525a0e7d2fd376 ();
					mSG1 = new x40255b11ef821fa3.MSG ();
					if (xacc37ebdd71fcc44)
					{
						bool b4 = this.x5b2e42a68d835b31 ();
					}
					IntPtr intPtr1 = x61467fe65a98f20c.SetCursor (x61467fe65a98f20c.LoadCursor (IntPtr.Zero, 32512));
					b2 = x61467fe65a98f20c.HideCaret (IntPtr.Zero);
					goto L_05D8;
					
				L_0543:
					
					{
					}
					if ((mSG1.message == 256) || ((mSG1.message == 257) || ((mSG1.message == 260) || (mSG1.message == 261))))
					{
						b3 = true;
					}
					if (b3)
					{
						mSG2 = new x40255b11ef821fa3.MSG ();
						bool b7 = x61467fe65a98f20c.GetMessage (ref mSG2, IntPtr.Zero, uint.MinValue, uint.MinValue);
					}
					else if (b1)
					{
						b1 = false;
					}
					else if (x61467fe65a98f20c.GetMessage (ref mSG1, IntPtr.Zero, uint.MinValue, uint.MinValue))
					{
						bool b8 = x61467fe65a98f20c.TranslateMessage (ref mSG1);
						IntPtr intPtr2 = x61467fe65a98f20c.DispatchMessage (ref mSG1);
					}
					
				L_05C0:
					
					{
					}
					if ((! this.x9a75ed38d1972c87) && x61467fe65a98f20c.PeekMessage (ref mSG1, 0, uint.MinValue, uint.MinValue, uint.MinValue))
					{
						b3 = false;
						i1 = (this.x86ef051842f1ae49.Width - x902c4aee45bfd906._x13d4cb8d1bd20347[0, 16]);
						i2 = (this.x86ef051842f1ae49.Height - x902c4aee45bfd906._x13d4cb8d1bd20347[0, 17]);
						if ((mSG1.message == 514) || ((mSG1.message == 520) || ((mSG1.message == 517) || ((mSG1.message == 524) || ((mSG1.message == 162) || ((mSG1.message == 168) || ((mSG1.message == 165) || (mSG1.message == 172))))))))
						{
							if (((((pOINT1 = this.x4b688849d80162f6 (mSG1)).x < this.x6941e4b46c92846d.X) || (pOINT1.x > (this.x6941e4b46c92846d.X + i1))) || (pOINT1.y < this.x6941e4b46c92846d.Y)) || (pOINT1.y > (this.x6941e4b46c92846d.Y + i2)))
							{
								x902c4aee45bfd906_1 = this.x3c6f7570c20e3f7d (pOINT1, ref mSG1);
								if (x902c4aee45bfd906_1 != null)
								{
									x902c4aee45bfd906_1.xd6cfa3f3f3125e82 (pOINT1.x, pOINT1.y);
									b3 = true;
								}
							}
							else
							{
								this.xd6cfa3f3f3125e82 (pOINT1.x, pOINT1.y);
								b3 = true;
							}
						}
						if ((mSG1.message == 513) || ((mSG1.message == 519) || ((mSG1.message == 516) || ((mSG1.message == 523) || ((mSG1.message == 161) || ((mSG1.message == 167) || ((mSG1.message == 164) || (mSG1.message == 171))))))))
						{
							if (((((pOINT2 = this.x4b688849d80162f6 (mSG1)).x >= this.x6941e4b46c92846d.X) && (pOINT2.x <= (this.x6941e4b46c92846d.X + i1))) && (pOINT2.y >= this.x6941e4b46c92846d.Y)) && (pOINT2.y <= (this.x6941e4b46c92846d.Y + i2)))
							{
								b3 = true;
							}
							else if (this.x3c6f7570c20e3f7d (pOINT2, ref mSG1) != null)
							{
								b3 = true;
							}
							else if (! this.x277ff37e12aff68b (pOINT2, ref mSG1))
							{
								this.x9a75ed38d1972c87 = true;
								b1 = true;
								if ((this.x37f2fc2a7f30f790 != null) && (mSG1.hwnd == this.x37f2fc2a7f30f790.Handle))
								{
									b1 = false;
								}
							}
							else
							{
								this.x37f2fc2a7f30f790.x2ea07c3ab5d970d4 (pOINT2);
								b3 = true;
							}
						}
						if (mSG1.message == 512)
						{
							if (((((pOINT3 = this.x4b688849d80162f6 (mSG1)).x >= this.x6941e4b46c92846d.X) && (pOINT3.x <= (this.x6941e4b46c92846d.X + i1))) && (pOINT3.y >= this.x6941e4b46c92846d.Y)) && (pOINT3.y <= (this.x6941e4b46c92846d.Y + i2)))
							{
								this.x136735fdfe6d04ea (pOINT3.x, pOINT3.y);
							}
							else
							{
								if (this.x753f06f9b5cd6e0d)
								{
									this.xa84c74b103039157 ();
								}
								x902c4aee45bfd906_2 = this.x3c6f7570c20e3f7d (pOINT3, ref mSG1);
								if (x902c4aee45bfd906_2 != null)
								{
									x902c4aee45bfd906_2.x136735fdfe6d04ea (pOINT3.x, pOINT3.y);
								}
								else if (this.x277ff37e12aff68b (pOINT3, ref mSG1))
								{
									this.x37f2fc2a7f30f790.x136735fdfe6d04ea (pOINT3);
								}
							}
							b3 = true;
						}
						if (mSG1.message == 32)
						{
							this.x773209141f430902 ();
							b3 = true;
						}
						if (mSG1.message == 260)
						{
							if (((int) mSG1.wParam) != 18)
							{
								mSG1.message = 256;
							}
							else
							{
								this.x9a75ed38d1972c87 = true;
							}
						}
						if (mSG1.message == 256)
						{
							i4 = ((int) mSG1.wParam);
							if (i4 != 13)
							{
								if (i4 == 27)
								{
									this.x9a75ed38d1972c87 = true;
								}
								else
								{
									switch (i4)
									{
										case 37:
										
										{
												this.x0e37e200024f43ba ();
												goto L_0543;
										}
										case 38:
										
										{
												bool b5 = this.x5437d760e9a6340b ();
												goto L_0543;
										}
										case 39:
										
										{
												if (! this.xb2aa7fc859b3d5b7 ())
												{
													goto L_0543;
												}
												b1 = true;
												goto L_0543;
										}
										case 40:
										
										{
												bool b6 = this.x5b2e42a68d835b31 ();
												goto L_0543;
										}
									}
									i3 = this.x65c1cc54cc8b0e75 (((char) ((UInt16) ((int) mSG1.wParam))));
									if (i3 != -1)
									{
										x2cc390e9409b0f3f2 = (this.xfb5697071ce83988[i3] as x2cc390e9409b0f3f);
										this.x4547ebd0fd2a7079 = x2cc390e9409b0f3f2.x5f4b657f68f87baa;
										this.x9a75ed38d1972c87 = true;
										b1 = true;
									}
								}
							}
							else if (this.xb266b78561d63b52 != -1)
							{
								x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[this.xb266b78561d63b52] as x2cc390e9409b0f3f);
								if (x2cc390e9409b0f3f1.x649e2ad374251b5f)
								{
									this.x0760506d6abf77a2 (this.xb266b78561d63b52, false);
									b1 = true;
								}
								else if (! x2cc390e9409b0f3f1.xc1facdb08ad4967a)
								{
									this.x4547ebd0fd2a7079 = x2cc390e9409b0f3f1.x5f4b657f68f87baa;
									this.x9a75ed38d1972c87 = true;
								}
								else
								{
									this.x057464a452da34b7 ();
								}
							}
						}
						goto L_0543;
					}
					
				L_05D8:
					
					{
					}
					while (! this.x9a75ed38d1972c87)
					{
						if (! x61467fe65a98f20c.WaitMessage ())
						{
							continue;
						}
						goto L_05C0;
					}
					if (b2)
					{
						bool b9 = x61467fe65a98f20c.ShowCaret (IntPtr.Zero);
					}
					this.xeb515a5b77846afe (this.xb266b78561d63b52, -1, false, false);
					this.x4139e66e6dfaac52 ();
					this.DestroyHandle ();
					if (((this.xb13f2de377f27597 == null) && (this.x4547ebd0fd2a7079 != null)) && (this.x37f2fc2a7f30f790 == null))
					{
						this.x4547ebd0fd2a7079.OnClick (EventArgs.Empty);
					}
					x5f4b657f68f87baa1 = this.x4547ebd0fd2a7079;
				}
				catch (Exception)
				{
					x5f4b657f68f87baa1 = ((x5f4b657f68f87baa) null);
				}
				return x5f4b657f68f87baa1;
			}
			
			protected void x76a103c0a87eb01c ()
			
			/*
				// Code Size: 65 Bytes
				.maxstack 6
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_0006: callvirt System.Windows.Forms.Timer::Void Stop()
				L_000b: ldarg.0 
				L_000c: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xf624f8e86c5ae5f1
				L_0011: ldarg.0 
				L_0012: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0017: beq.s L_002d
				L_0019: ldarg.0 
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0020: ldarg.0 
				L_0021: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xf624f8e86c5ae5f1
				L_0026: ldc.i4.0 
				L_0027: ldc.i4.1 
				L_0028: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xeb515a5b77846afe(Int32, Int32, Boolean, Boolean)
				L_002d: ldarg.0 
				L_002e: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0033: brfalse.s L_0040
				L_0035: ldarg.0 
				L_0036: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_003b: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x76a103c0a87eb01c()
				L_0040: ret 
			*/
			
			
			{
				this.x420067493d7ebb36.Stop ();
				if (this.xf624f8e86c5ae5f1 != this.xb266b78561d63b52)
				{
					this.xeb515a5b77846afe (this.xb266b78561d63b52, this.xf624f8e86c5ae5f1, false, true);
				}
				if (this.xb13f2de377f27597 != null)
				{
					this.xb13f2de377f27597.x76a103c0a87eb01c ();
				}
			}
			
			protected void x773209141f430902 ()
			
			/*
				// Code Size: 22 Bytes
				.maxstack 9
				L_0000: ldsfld System.IntPtr::IntPtr Zero
				L_0005: ldc.i4 32512
				L_000a: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr LoadCursor(IntPtr, UInt32)
				L_000f: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SetCursor(IntPtr)
				L_0014: pop 
				L_0015: ret 
			*/
			
			
			{
				IntPtr intPtr1 = x61467fe65a98f20c.SetCursor (x61467fe65a98f20c.LoadCursor (IntPtr.Zero, 32512));
			}
			
			protected static unsafe Bitmap x7ca9c34ba153ef81 (int x9b0739496f8b5475, int x4d5aabc7a55b12ba)
			
			/*
				// Code Size: 204 Bytes
				.maxstack 7
				.locals (System.Drawing.Bitmap V_0, 
         System.Drawing.Imaging.BitmapData V_1, 
         System.UInt32* V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Int32 V_7)
				L_0000: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xc08a10dac990c769
				L_0005: ldarg.0 
				L_0006: bne.un.s L_001d
				L_0008: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x4a8f256947767652
				L_000d: ldarg.1 
				L_000e: bne.un.s L_001d
				L_0010: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Bitmap xca1a18e48751e941
				L_0015: brfalse.s L_001d
				L_0017: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Bitmap xca1a18e48751e941
				L_001c: ret 
				L_001d: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Bitmap xca1a18e48751e941
				L_0022: brfalse.s L_002e
				L_0024: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Bitmap xca1a18e48751e941
				L_0029: callvirt System.Drawing.Image::Void Dispose()
				L_002e: ldarg.0 
				L_002f: ldarg.1 
				L_0030: ldc.i4 2498570
				L_0035: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32, System.Drawing.Imaging.PixelFormat)
				L_003a: stloc.0 
				L_003b: ldloc.0 
				L_003c: ldc.i4.0 
				L_003d: ldc.i4.0 
				L_003e: ldarg.0 
				L_003f: ldarg.1 
				L_0040: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0045: ldc.i4.2 
				L_0046: ldc.i4 2498570
				L_004b: callvirt System.Drawing.Bitmap::System.Drawing.Imaging.BitmapData LockBits(System.Drawing.Rectangle, System.Drawing.Imaging.ImageLockMode, System.Drawing.Imaging.PixelFormat)
				L_0050: stloc.1 
				L_0051: ldloc.1 
				L_0052: callvirt System.Drawing.Imaging.BitmapData::IntPtr get_Scan0()
				L_0057: call System.IntPtr::Void* op_Explicit(IntPtr)
				L_005c: stloc.2 
				L_005d: ldc.i4.0 
				L_005e: stloc.3 
				L_005f: br.s L_00a9
				L_0061: ldloc.1 
				L_0062: callvirt System.Drawing.Imaging.BitmapData::Int32 get_Stride()
				L_0067: ldloc.3 
				L_0068: mul 
				L_0069: ldc.i4.4 
				L_006a: div 
				L_006b: stloc.s V_4
				L_006d: ldc.i4.s 64
				L_006f: ldarg.1 
				L_0070: ldloc.3 
				L_0071: sub 
				L_0072: mul 
				L_0073: ldarg.1 
				L_0074: ldc.i4.1 
				L_0075: add 
				L_0076: div 
				L_0077: stloc.s V_5
				L_0079: ldc.i4.0 
				L_007a: stloc.s V_6
				L_007c: br.s L_00a0
				L_007e: ldloc.s V_5
				L_0080: ldarg.0 
				L_0081: ldloc.s V_6
				L_0083: sub 
				L_0084: mul 
				L_0085: ldarg.0 
				L_0086: ldc.i4.1 
				L_0087: add 
				L_0088: div 
				L_0089: stloc.s V_7
				L_008b: ldloc.2 
				L_008c: ldc.i4.4 
				L_008d: ldloc.s V_4
				L_008f: ldloc.s V_6
				L_0091: add 
				L_0092: mul 
				L_0093: add 
				L_0094: ldloc.s V_7
				L_0096: ldc.i4.s 24
				L_0098: shl 
				L_0099: stind.i4 
				L_009a: ldloc.s V_6
				L_009c: ldc.i4.1 
				L_009d: add 
				L_009e: stloc.s V_6
				L_00a0: ldloc.s V_6
				L_00a2: ldarg.0 
				L_00a3: blt.s L_007e
				L_00a5: ldloc.3 
				L_00a6: ldc.i4.1 
				L_00a7: add 
				L_00a8: stloc.3 
				L_00a9: ldloc.3 
				L_00aa: ldarg.1 
				L_00ab: blt.s L_0061
				L_00ad: ldloc.0 
				L_00ae: ldloc.1 
				L_00af: callvirt System.Drawing.Bitmap::Void UnlockBits(System.Drawing.Imaging.BitmapData)
				L_00b4: ldloc.0 
				L_00b5: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Bitmap xca1a18e48751e941
				L_00ba: ldarg.0 
				L_00bb: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xc08a10dac990c769
				L_00c0: ldarg.1 
				L_00c1: stsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x4a8f256947767652
				L_00c6: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Bitmap xca1a18e48751e941
				L_00cb: ret 
			*/
			
			
			{
				int i1;
				int i2;
				int i3;
				int i4;
				int i5;
				if (((x902c4aee45bfd906.xc08a10dac990c769 == x9b0739496f8b5475) && (x902c4aee45bfd906.x4a8f256947767652 == x4d5aabc7a55b12ba)) && (x902c4aee45bfd906.xca1a18e48751e941 != null))
				{
					return x902c4aee45bfd906.xca1a18e48751e941;
				}
				if (x902c4aee45bfd906.xca1a18e48751e941 != null)
				{
					x902c4aee45bfd906.xca1a18e48751e941.Dispose ();
				}
				Bitmap bitmap1 = new Bitmap (x9b0739496f8b5475, x4d5aabc7a55b12ba, PixelFormat.Format32bppArgb);
				BitmapData bitmapData1 = bitmap1.LockBits (new Rectangle (0, 0, x9b0739496f8b5475, x4d5aabc7a55b12ba), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
				uint* uInt32_Ptr1 = ((uint*) ((void*) bitmapData1.Scan0));
				for (i1 = 0; (i1 < x4d5aabc7a55b12ba); i1++)
				{
					i2 = ((bitmapData1.Stride * i1) / 4);
					i3 = ((int) ((64 * (x4d5aabc7a55b12ba - i1)) / (x4d5aabc7a55b12ba + 1)));
					for (i4 = 0; (i4 < x9b0739496f8b5475); i4++)
					{
						i5 = ((i3 * (x9b0739496f8b5475 - i4)) / (x9b0739496f8b5475 + 1));
						(* ((int*) (uInt32_Ptr1 + (i2 + i4)))) = ((int) (i5 << 24));
					}
				}
				bitmap1.UnlockBits (bitmapData1);
				x902c4aee45bfd906.xca1a18e48751e941 = bitmap1;
				x902c4aee45bfd906.xc08a10dac990c769 = x9b0739496f8b5475;
				x902c4aee45bfd906.x4a8f256947767652 = x4d5aabc7a55b12ba;
				return x902c4aee45bfd906.xca1a18e48751e941;
			}
			
			protected Color x898c3842f8dd56e5 (Color xfe9df16f7e7c346d, Color x753506715ee62862, int x6ad505c7ef981b0e)
			
			/*
				// Code Size: 205 Bytes
				.maxstack 5
				.locals (System.Drawing.Color V_0, 
         System.Drawing.Color V_1, 
         System.Single V_2, 
         System.Single V_3, 
         System.Single V_4, 
         System.Single V_5, 
         System.Single V_6, 
         System.Single V_7, 
         System.Single V_8, 
         System.Single V_9, 
         System.Single V_10, 
         System.Byte V_11, 
         System.Byte V_12, 
         System.Byte V_13)
				L_0000: ldc.i4 255
				L_0005: ldarg.1 
				L_0006: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, System.Drawing.Color)
				L_000b: stloc.0 
				L_000c: ldc.i4 255
				L_0011: ldarg.2 
				L_0012: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, System.Drawing.Color)
				L_0017: stloc.1 
				L_0018: ldloca.s V_0
				L_001a: call System.Drawing.Color::Byte get_R()
				L_001f: conv.r4 
				L_0020: stloc.2 
				L_0021: ldloca.s V_0
				L_0023: call System.Drawing.Color::Byte get_G()
				L_0028: conv.r4 
				L_0029: stloc.3 
				L_002a: ldloca.s V_0
				L_002c: call System.Drawing.Color::Byte get_B()
				L_0031: conv.r4 
				L_0032: stloc.s V_4
				L_0034: ldloca.s V_1
				L_0036: call System.Drawing.Color::Byte get_R()
				L_003b: conv.r4 
				L_003c: stloc.s V_5
				L_003e: ldloca.s V_1
				L_0040: call System.Drawing.Color::Byte get_G()
				L_0045: conv.r4 
				L_0046: stloc.s V_6
				L_0048: ldloca.s V_1
				L_004a: call System.Drawing.Color::Byte get_B()
				L_004f: conv.r4 
				L_0050: stloc.s V_7
				L_0052: ldloc.2 
				L_0053: ldarg.3 
				L_0054: conv.r4 
				L_0055: mul 
				L_0056: ldc.r4 255
				L_005b: div 
				L_005c: ldloc.s V_5
				L_005e: ldc.i4 255
				L_0063: ldarg.3 
				L_0064: sub 
				L_0065: conv.r4 
				L_0066: ldc.r4 255
				L_006b: div 
				L_006c: mul 
				L_006d: add 
				L_006e: stloc.s V_8
				L_0070: ldloc.3 
				L_0071: ldarg.3 
				L_0072: conv.r4 
				L_0073: mul 
				L_0074: ldc.r4 255
				L_0079: div 
				L_007a: ldloc.s V_6
				L_007c: ldc.i4 255
				L_0081: ldarg.3 
				L_0082: sub 
				L_0083: conv.r4 
				L_0084: ldc.r4 255
				L_0089: div 
				L_008a: mul 
				L_008b: add 
				L_008c: stloc.s V_9
				L_008e: ldloc.s V_4
				L_0090: ldarg.3 
				L_0091: conv.r4 
				L_0092: mul 
				L_0093: ldc.r4 255
				L_0098: div 
				L_0099: ldloc.s V_7
				L_009b: ldc.i4 255
				L_00a0: ldarg.3 
				L_00a1: sub 
				L_00a2: conv.r4 
				L_00a3: ldc.r4 255
				L_00a8: div 
				L_00a9: mul 
				L_00aa: add 
				L_00ab: stloc.s V_10
				L_00ad: ldloc.s V_8
				L_00af: conv.u1 
				L_00b0: stloc.s V_11
				L_00b2: ldloc.s V_9
				L_00b4: conv.u1 
				L_00b5: stloc.s V_12
				L_00b7: ldloc.s V_10
				L_00b9: conv.u1 
				L_00ba: stloc.s V_13
				L_00bc: ldc.i4 255
				L_00c1: ldloc.s V_11
				L_00c3: ldloc.s V_12
				L_00c5: ldloc.s V_13
				L_00c7: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_00cc: ret 
			*/
			
			
			{
				Color color1 = Color.FromArgb (255, xfe9df16f7e7c346d);
				Color color2 = Color.FromArgb (255, x753506715ee62862);
				float single1 = ((float) color1.R);
				float single2 = ((float) color1.G);
				float single3 = ((float) color1.B);
				float single4 = ((float) color2.R);
				float single5 = ((float) color2.G);
				float single6 = ((float) color2.B);
				float single7 = (((single1 * ((float) x6ad505c7ef981b0e)) / 255F) + (single4 * (((float) (255 - x6ad505c7ef981b0e)) / 255F)));
				float single8 = (((single2 * ((float) x6ad505c7ef981b0e)) / 255F) + (single5 * (((float) (255 - x6ad505c7ef981b0e)) / 255F)));
				float single9 = (((single3 * ((float) x6ad505c7ef981b0e)) / 255F) + (single6 * (((float) (255 - x6ad505c7ef981b0e)) / 255F)));
				byte byte1 = ((byte) single7);
				byte byte2 = ((byte) single8);
				byte byte3 = ((byte) single9);
				return Color.FromArgb (255, ((int) byte1), ((int) byte2), ((int) byte3));
			}
			
			protected string x8cf43133d25d686a (Shortcut xc0de55fd2ca182a4)
			
			/*
				// Code Size: 141 Bytes
				.maxstack 3
				.locals (System.Char V_0, 
         System.String V_1, 
         System.Int32 V_2)
				L_0000: ldarg.1 
				L_0001: ldc.i4 65535
				L_0006: and 
				L_0007: conv.u2 
				L_0008: stloc.0 
				L_0009: ldloc.0 
				L_000a: ldc.i4.s 48
				L_000c: blt.s L_0072
				L_000e: ldloc.0 
				L_000f: ldc.i4.s 57
				L_0011: bgt.s L_0072
				L_0013: ldstr ""
				L_0018: stloc.1 
				L_0019: ldarg.1 
				L_001a: conv.i8 
				L_001b: ldc.i4 -65536
				L_0020: conv.u8 
				L_0021: and 
				L_0022: conv.i4 
				L_0023: stloc.2 
				L_0024: ldloc.2 
				L_0025: ldc.i4 65536
				L_002a: and 
				L_002b: brfalse.s L_0039
				L_002d: ldloc.1 
				L_002e: ldstr "Shift+"
				L_0033: call System.String::System.String Concat(System.String, System.String)
				L_0038: stloc.1 
				L_0039: ldloc.2 
				L_003a: ldc.i4 131072
				L_003f: and 
				L_0040: brfalse.s L_004e
				L_0042: ldloc.1 
				L_0043: ldstr "Ctrl+"
				L_0048: call System.String::System.String Concat(System.String, System.String)
				L_004d: stloc.1 
				L_004e: ldloc.2 
				L_004f: ldc.i4 262144
				L_0054: and 
				L_0055: brfalse.s L_0063
				L_0057: ldloc.1 
				L_0058: ldstr "Alt+"
				L_005d: call System.String::System.String Concat(System.String, System.String)
				L_0062: stloc.1 
				L_0063: ldloc.1 
				L_0064: ldloc.0 
				L_0065: box System.Char
				L_006a: call System.String::System.String Concat(System.Object, System.Object)
				L_006f: stloc.1 
				L_0070: ldloc.1 
				L_0071: ret 
				L_0072: ldtoken System.Windows.Forms.Keys
				L_0077: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_007c: call System.ComponentModel.TypeDescriptor::System.ComponentModel.TypeConverter GetConverter(System.Type)
				L_0081: ldarg.1 
				L_0082: box System.Windows.Forms.Keys
				L_0087: callvirt System.ComponentModel.TypeConverter::System.String ConvertToString(System.Object)
				L_008c: ret 
			*/
			
			
			{
				char char1;
				if ((char1 = ((char) ((UInt16) (xc0de55fd2ca182a4 &  ((Shortcut) 65535))))) < '0')
				{
					return TypeDescriptor.GetConverter (typeof (Keys)).ConvertToString (((Keys) xc0de55fd2ca182a4));
				}
				if (char1 > '9')
				{
					return TypeDescriptor.GetConverter (typeof (Keys)).ConvertToString (((Keys) xc0de55fd2ca182a4));
				}
				string string1 = "";
				int i1 = ((int) (((long) xc0de55fd2ca182a4) & ((long) (-65536))));
				if ((i1 & 65536) != 0)
				{
					string1 = (string1 + "Shift+");
				}
				if ((i1 & 131072) != 0)
				{
					string1 = (string1 + "Ctrl+");
				}
				if ((i1 & 262144) != 0)
				{
					string1 = (string1 + "Alt+");
				}
				return (string1 + char1.ToString ());
			}
			
			public x5f4b657f68f87baa x8fff3e0fa3d68bb2 (Point x0ce73f6cbd7d5515)
			
			/*
				// Code Size: 51 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0006: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Boolean xb7b226d9e2df0fa0()
				L_000b: brfalse.s L_0031
				L_000d: ldarg.0 
				L_000e: ldc.i4.1 
				L_000f: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_0014: ldarg.0 
				L_0015: ldarg.1 
				L_0016: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x07658cf2bdd49693
				L_001b: ldarg.0 
				L_001c: ldarg.1 
				L_001d: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x1ee5f8430343bccd
				L_0022: ldarg.0 
				L_0023: ldarg.1 
				L_0024: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point xcbbe945601aff7c8
				L_0029: ldarg.0 
				L_002a: ldc.i4.0 
				L_002b: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xf1c4e2176aec0ad6(Boolean)
				L_0030: ret 
				L_0031: ldnull 
				L_0032: ret 
			*/
			
			
			{
				if (! this.xf4f555905eaa2330.xb7b226d9e2df0fa0 ())
				{
					return null;
				}
				else
				{
					this.x23e85093ba3a7d1d = xdbfa333b4cd503e0.x3bce7c87328df8da;
					this.x07658cf2bdd49693 = x0ce73f6cbd7d5515;
					this.x1ee5f8430343bccd = x0ce73f6cbd7d5515;
					this.xcbbe945601aff7c8 = x0ce73f6cbd7d5515;
					return this.xf1c4e2176aec0ad6 (false);
				}
			}
			
			protected void x9119fce83e4631ad ()
			
			/*
				// Code Size: 24 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.0 
				L_0002: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0007: ldarg.0 
				L_0008: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Size x86ef051842f1ae49
				L_000d: ldc.i4 255
				L_0012: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x9119fce83e4631ad(System.Drawing.Point, System.Drawing.Size, Byte)
				L_0017: ret 
			*/
			
			
			{
				this.x9119fce83e4631ad (this.x6941e4b46c92846d, this.x86ef051842f1ae49, byte.MaxValue);
			}
			
			protected void x9119fce83e4631ad (byte x6ad505c7ef981b0e)
			
			/*
				// Code Size: 20 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.0 
				L_0002: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0007: ldarg.0 
				L_0008: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Size x86ef051842f1ae49
				L_000d: ldarg.1 
				L_000e: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x9119fce83e4631ad(System.Drawing.Point, System.Drawing.Size, Byte)
				L_0013: ret 
			*/
			
			
			{
				this.x9119fce83e4631ad (this.x6941e4b46c92846d, this.x86ef051842f1ae49, x6ad505c7ef981b0e);
			}
			
			protected void x9119fce83e4631ad (Point x2f7096dac971d6ec, Size x0ceec69a97f73617, byte x6ad505c7ef981b0e)
			
			/*
				// Code Size: 302 Bytes
				.maxstack 10
				.locals (System.Drawing.Bitmap V_0, 
         System.Drawing.Graphics V_1, 
         System.Drawing.Rectangle V_2, 
         System.IntPtr V_3, 
         System.IntPtr V_4, 
         System.IntPtr V_5, 
         System.IntPtr V_6, 
         Sunisoft.IrisSkin.x555516122dcc901e+SIZE V_7, 
         Sunisoft.IrisSkin.x555516122dcc901e+POINT V_8, 
         Sunisoft.IrisSkin.x555516122dcc901e+POINT V_9, 
         Sunisoft.IrisSkin.x1439a41cfa24189f+BLENDFUNCTION V_10)
				.try L_0020 to L_0123 finally L_0123 to L_012d
				L_0000: ldarga.s x0ceec69a97f73617
				L_0002: call System.Drawing.Size::Int32 get_Width()
				L_0007: ldarga.s x0ceec69a97f73617
				L_0009: call System.Drawing.Size::Int32 get_Height()
				L_000e: ldc.i4 2498570
				L_0013: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32, System.Drawing.Imaging.PixelFormat)
				L_0018: stloc.0 
				L_0019: ldloc.0 
				L_001a: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_001f: stloc.1 
				L_0020: ldloca.s V_2
				L_0022: ldc.i4.0 
				L_0023: ldc.i4.0 
				L_0024: ldarga.s x0ceec69a97f73617
				L_0026: call System.Drawing.Size::Int32 get_Width()
				L_002b: ldarga.s x0ceec69a97f73617
				L_002d: call System.Drawing.Size::Int32 get_Height()
				L_0032: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0037: ldarg.0 
				L_0038: ldloc.1 
				L_0039: ldloc.2 
				L_003a: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x4af0f9e5d7ac184a(System.Drawing.Graphics, System.Drawing.Rectangle)
				L_003f: ldarg.0 
				L_0040: ldloc.1 
				L_0041: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x05a10b378cdf8119(System.Drawing.Graphics)
				L_0046: ldsfld System.IntPtr::IntPtr Zero
				L_004b: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr GetDC(IntPtr)
				L_0050: stloc.3 
				L_0051: ldloc.3 
				L_0052: call Sunisoft.IrisSkin.x31775329b2a4ff52::IntPtr CreateCompatibleDC(IntPtr)
				L_0057: stloc.s V_4
				L_0059: ldloc.0 
				L_005a: ldc.i4.0 
				L_005b: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32)
				L_0060: callvirt System.Drawing.Bitmap::IntPtr GetHbitmap(System.Drawing.Color)
				L_0065: stloc.s V_5
				L_0067: ldloc.s V_4
				L_0069: ldloc.s V_5
				L_006b: call Sunisoft.IrisSkin.x31775329b2a4ff52::IntPtr SelectObject(IntPtr, IntPtr)
				L_0070: stloc.s V_6
				L_0072: ldloca.s V_7
				L_0074: ldarga.s x0ceec69a97f73617
				L_0076: call System.Drawing.Size::Int32 get_Width()
				L_007b: stfld Sunisoft.IrisSkin.x555516122dcc901e+SIZE::Int32 cx
				L_0080: ldloca.s V_7
				L_0082: ldarga.s x0ceec69a97f73617
				L_0084: call System.Drawing.Size::Int32 get_Height()
				L_0089: stfld Sunisoft.IrisSkin.x555516122dcc901e+SIZE::Int32 cy
				L_008e: ldloca.s V_8
				L_0090: ldarga.s x2f7096dac971d6ec
				L_0092: call System.Drawing.Point::Int32 get_X()
				L_0097: stfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_009c: ldloca.s V_8
				L_009e: ldarga.s x2f7096dac971d6ec
				L_00a0: call System.Drawing.Point::Int32 get_Y()
				L_00a5: stfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_00aa: ldloca.s V_9
				L_00ac: ldc.i4.0 
				L_00ad: stfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_00b2: ldloca.s V_9
				L_00b4: ldc.i4.0 
				L_00b5: stfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_00ba: ldloca.s V_10
				L_00bc: initobj Sunisoft.IrisSkin.x1439a41cfa24189f+BLENDFUNCTION
				L_00c2: ldloca.s V_10
				L_00c4: ldc.i4.0 
				L_00c5: stfld Sunisoft.IrisSkin.x1439a41cfa24189f+BLENDFUNCTION::Byte BlendOp
				L_00ca: ldloca.s V_10
				L_00cc: ldc.i4.0 
				L_00cd: stfld Sunisoft.IrisSkin.x1439a41cfa24189f+BLENDFUNCTION::Byte BlendFlags
				L_00d2: ldloca.s V_10
				L_00d4: ldarg.3 
				L_00d5: stfld Sunisoft.IrisSkin.x1439a41cfa24189f+BLENDFUNCTION::Byte SourceConstantAlpha
				L_00da: ldloca.s V_10
				L_00dc: ldc.i4.1 
				L_00dd: stfld Sunisoft.IrisSkin.x1439a41cfa24189f+BLENDFUNCTION::Byte AlphaFormat
				L_00e2: ldarg.0 
				L_00e3: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_00e8: ldloc.3 
				L_00e9: ldloca.s V_8
				L_00eb: ldloca.s V_7
				L_00ed: ldloc.s V_4
				L_00ef: ldloca.s V_9
				L_00f1: ldc.i4.0 
				L_00f2: ldloca.s V_10
				L_00f4: ldc.i4.2 
				L_00f5: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean UpdateLayeredWindow(IntPtr, IntPtr, POINT ByRef, SIZE ByRef, IntPtr, POINT ByRef, Int32, BLENDFUNCTION ByRef, Int32)
				L_00fa: pop 
				L_00fb: ldloc.s V_4
				L_00fd: ldloc.s V_6
				L_00ff: call Sunisoft.IrisSkin.x31775329b2a4ff52::IntPtr SelectObject(IntPtr, IntPtr)
				L_0104: pop 
				L_0105: ldsfld System.IntPtr::IntPtr Zero
				L_010a: ldloc.3 
				L_010b: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ReleaseDC(IntPtr, IntPtr)
				L_0110: pop 
				L_0111: ldloc.s V_5
				L_0113: call Sunisoft.IrisSkin.x31775329b2a4ff52::Boolean DeleteObject(IntPtr)
				L_0118: pop 
				L_0119: ldloc.s V_4
				L_011b: call Sunisoft.IrisSkin.x31775329b2a4ff52::Boolean DeleteDC(IntPtr)
				L_0120: pop 
				L_0121: leave.s L_012d
				L_0123: ldloc.1 
				L_0124: brfalse.s L_012c
				L_0126: ldloc.1 
				L_0127: callvirt System.IDisposable::Void Dispose()
				L_012c: endfinally 
				L_012d: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				IntPtr intPtr1;
				IntPtr intPtr2;
				IntPtr intPtr3;
				IntPtr intPtr4;
				x555516122dcc901e.SIZE sIZE1;
				x555516122dcc901e.POINT pOINT1;
				x555516122dcc901e.POINT pOINT2;
				x1439a41cfa24189f.BLENDFUNCTION bLENDFUNCTION1;
				Bitmap bitmap1 = new Bitmap (x0ceec69a97f73617.Width, x0ceec69a97f73617.Height, PixelFormat.Format32bppArgb);
				using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap1)))
				{
					rectangle1 = new Rectangle (0, 0, x0ceec69a97f73617.Width, x0ceec69a97f73617.Height);
					this.x4af0f9e5d7ac184a (graphics1, rectangle1);
					this.x05a10b378cdf8119 (graphics1);
					intPtr1 = x61467fe65a98f20c.GetDC (IntPtr.Zero);
					intPtr2 = x31775329b2a4ff52.CreateCompatibleDC (intPtr1);
					intPtr3 = bitmap1.GetHbitmap (Color.FromArgb (0));
					intPtr4 = x31775329b2a4ff52.SelectObject (intPtr2, intPtr3);
					sIZE1.cx = x0ceec69a97f73617.Width;
					sIZE1.cy = x0ceec69a97f73617.Height;
					pOINT1.x = x2f7096dac971d6ec.X;
					pOINT1.y = x2f7096dac971d6ec.Y;
					pOINT2.x = 0;
					pOINT2.y = 0;
					bLENDFUNCTION1 = new x1439a41cfa24189f.BLENDFUNCTION ();
					bLENDFUNCTION1.BlendOp = byte.MinValue;
					bLENDFUNCTION1.BlendFlags = byte.MinValue;
					bLENDFUNCTION1.SourceConstantAlpha = x6ad505c7ef981b0e;
					bLENDFUNCTION1.AlphaFormat = 1;
					bool b1 = x61467fe65a98f20c.UpdateLayeredWindow (base.Handle, intPtr1, ref pOINT1, ref sIZE1, intPtr2, ref pOINT2, 0, ref bLENDFUNCTION1, 2);
					IntPtr intPtr5 = x31775329b2a4ff52.SelectObject (intPtr2, intPtr4);
					int i1 = x61467fe65a98f20c.ReleaseDC (IntPtr.Zero, intPtr1);
					bool b2 = x31775329b2a4ff52.DeleteObject (intPtr3);
					bool b3 = x31775329b2a4ff52.DeleteDC (intPtr2);
				}
			}
			
			protected void x95f5f55ee201fb8f ()
			
			/*
				// Code Size: 101 Bytes
				.maxstack 7
				.locals (Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_0, 
         System.Drawing.Rectangle V_1, 
         System.Drawing.Graphics V_2)
				.try L_0049 to L_005a finally L_005a to L_0064
				L_0000: ldloca.s V_0
				L_0002: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
				L_0008: ldarg.0 
				L_0009: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_000e: ldloca.s V_0
				L_0010: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowRect(IntPtr, RECT ByRef)
				L_0015: pop 
				L_0016: ldloca.s V_1
				L_0018: ldc.i4.0 
				L_0019: ldc.i4.0 
				L_001a: ldloca.s V_0
				L_001c: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0021: ldloca.s V_0
				L_0023: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0028: sub 
				L_0029: ldloca.s V_0
				L_002b: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0030: ldloca.s V_0
				L_0032: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0037: sub 
				L_0038: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_003d: ldarg.0 
				L_003e: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0043: call System.Drawing.Graphics::System.Drawing.Graphics FromHwnd(IntPtr)
				L_0048: stloc.2 
				L_0049: ldarg.0 
				L_004a: ldloc.2 
				L_004b: ldloc.1 
				L_004c: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x4af0f9e5d7ac184a(System.Drawing.Graphics, System.Drawing.Rectangle)
				L_0051: ldarg.0 
				L_0052: ldloc.2 
				L_0053: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x05a10b378cdf8119(System.Drawing.Graphics)
				L_0058: leave.s L_0064
				L_005a: ldloc.2 
				L_005b: brfalse.s L_0063
				L_005d: ldloc.2 
				L_005e: callvirt System.IDisposable::Void Dispose()
				L_0063: endfinally 
				L_0064: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
				bool b1 = x61467fe65a98f20c.GetWindowRect (base.Handle, ref rECT1);
				rectangle1 = new Rectangle (0, 0, ((int) (rECT1.right - rECT1.left)), ((int) (rECT1.bottom - rECT1.top)));
				using (Graphics graphics1 = Graphics.FromHwnd (base.Handle))
				{
					this.x4af0f9e5d7ac184a (graphics1, rectangle1);
					this.x05a10b378cdf8119 (graphics1);
				}
			}
			
			protected void xa1715c5212ff8a33 ()
			
			/*
				// Code Size: 430 Bytes
				.maxstack 5
				.locals (System.Drawing.Size V_0, 
         System.Drawing.Point V_1, 
         System.Windows.Forms.CreateParams V_2, 
         System.Boolean V_3, 
         System.Boolean V_4, 
         System.Int32 V_5, 
         System.UInt32 V_6, 
         System.Int32 V_7, 
         Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced V_8)
				L_0000: ldarg.0 
				L_0001: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9c8c46cd7553cd2b
				L_0006: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xdb6050a2030517f4
				L_000b: ldarg.0 
				L_000c: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Size x4e2849ed170f5bc2()
				L_0011: stloc.0 
				L_0012: ldarg.0 
				L_0013: ldloc.0 
				L_0014: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x1339f634e34e0e03(System.Drawing.Size)
				L_0019: stloc.1 
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0020: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_0025: brtrue.s L_0030
				L_0027: ldloca.s V_0
				L_0029: ldc.i4.0 
				L_002a: ldc.i4.0 
				L_002b: call System.Drawing.Size::Void .ctor(Int32, Int32)
				L_0030: newobj System.Windows.Forms.CreateParams::Void .ctor()
				L_0035: stloc.2 
				L_0036: ldloc.2 
				L_0037: ldstr "NativeSkinContextMenu"
				L_003c: callvirt System.Windows.Forms.CreateParams::Void set_Caption(System.String)
				L_0041: ldloc.2 
				L_0042: ldloca.s V_1
				L_0044: call System.Drawing.Point::Int32 get_X()
				L_0049: callvirt System.Windows.Forms.CreateParams::Void set_X(Int32)
				L_004e: ldloc.2 
				L_004f: ldloca.s V_1
				L_0051: call System.Drawing.Point::Int32 get_Y()
				L_0056: callvirt System.Windows.Forms.CreateParams::Void set_Y(Int32)
				L_005b: ldloc.2 
				L_005c: ldloca.s V_0
				L_005e: call System.Drawing.Size::Int32 get_Height()
				L_0063: callvirt System.Windows.Forms.CreateParams::Void set_Height(Int32)
				L_0068: ldloc.2 
				L_0069: ldloca.s V_0
				L_006b: call System.Drawing.Size::Int32 get_Width()
				L_0070: callvirt System.Windows.Forms.CreateParams::Void set_Width(Int32)
				L_0075: ldloc.2 
				L_0076: ldsfld System.IntPtr::IntPtr Zero
				L_007b: callvirt System.Windows.Forms.CreateParams::Void set_Parent(IntPtr)
				L_0080: ldloc.2 
				L_0081: ldc.i4 -2147483648
				L_0086: callvirt System.Windows.Forms.CreateParams::Void set_Style(Int32)
				L_008b: ldloc.2 
				L_008c: ldc.i4 136
				L_0091: callvirt System.Windows.Forms.CreateParams::Void set_ExStyle(Int32)
				L_0096: ldarg.0 
				L_0097: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xdb6050a2030517f4
				L_009c: brfalse.s L_00b0
				L_009e: ldloc.2 
				L_009f: dup 
				L_00a0: callvirt System.Windows.Forms.CreateParams::Int32 get_ExStyle()
				L_00a5: ldc.i4 524288
				L_00aa: add 
				L_00ab: callvirt System.Windows.Forms.CreateParams::Void set_ExStyle(Int32)
				L_00b0: ldarg.0 
				L_00b1: ldloc.2 
				L_00b2: callvirt System.Windows.Forms.NativeWindow::Void CreateHandle(System.Windows.Forms.CreateParams)
				L_00b7: ldarg.0 
				L_00b8: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xdb6050a2030517f4
				L_00bd: brtrue.s L_00c6
				L_00bf: ldarg.0 
				L_00c0: ldloc.0 
				L_00c1: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x1803d70928e3ae9b(System.Drawing.Size)
				L_00c6: ldarg.0 
				L_00c7: ldloc.0 
				L_00c8: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Size x86ef051842f1ae49
				L_00cd: ldarg.0 
				L_00ce: ldloc.1 
				L_00cf: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_00d4: ldc.i4.0 
				L_00d5: stloc.3 
				L_00d6: ldarg.0 
				L_00d7: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xdb6050a2030517f4
				L_00dc: brfalse L_019d
				L_00e1: ldarg.0 
				L_00e2: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x9119fce83e4631ad()
				L_00e7: ldc.i4.0 
				L_00e8: stloc.s V_4
				L_00ea: ldarg.0 
				L_00eb: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced x1cb292d12d9bf68e
				L_00f0: stloc.s V_8
				L_00f2: ldloc.s V_8
				L_00f4: switch (L_0107, L_010c, L_0111)
				L_0105: br.s L_012d
				L_0107: ldc.i4.0 
				L_0108: stloc.s V_4
				L_010a: br.s L_012d
				L_010c: ldc.i4.1 
				L_010d: stloc.s V_4
				L_010f: br.s L_012d
				L_0111: ldc.i4.0 
				L_0112: stloc.s V_5
				L_0114: ldc.i4 4098
				L_0119: ldc.i4.0 
				L_011a: ldloca.s V_5
				L_011c: ldc.i4.0 
				L_011d: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean SystemParametersInfoA(UInt32, UInt32, Int32 ByRef, UInt32)
				L_0122: pop 
				L_0123: ldloc.s V_5
				L_0125: ldc.i4.0 
				L_0126: ceq 
				L_0128: ldc.i4.0 
				L_0129: ceq 
				L_012b: stloc.s V_4
				L_012d: ldloc.s V_4
				L_012f: brfalse.s L_019d
				L_0131: ldarg.0 
				L_0132: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x0a7391c99fcdc469
				L_0137: brfalse.s L_019d
				L_0139: ldarg.0 
				L_013a: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x1f5697535eab37b9 xa89034e65472167c
				L_013f: stloc.s V_6
				L_0141: ldarg.0 
				L_0142: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x1f5697535eab37b9 xa89034e65472167c
				L_0147: ldc.i4 1048576
				L_014c: bne.un.s L_0174
				L_014e: ldc.i4.0 
				L_014f: stloc.s V_7
				L_0151: ldc.i4 4114
				L_0156: ldc.i4.0 
				L_0157: ldloca.s V_7
				L_0159: ldc.i4.0 
				L_015a: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean SystemParametersInfoA(UInt32, UInt32, Int32 ByRef, UInt32)
				L_015f: pop 
				L_0160: ldloc.s V_7
				L_0162: brfalse.s L_016d
				L_0164: ldc.i4 524288
				L_0169: stloc.s V_6
				L_016b: br.s L_0174
				L_016d: ldc.i4 262149
				L_0172: stloc.s V_6
				L_0174: ldloc.s V_6
				L_0176: ldc.i4 524288
				L_017b: and 
				L_017c: brfalse.s L_0187
				L_017e: ldarg.0 
				L_017f: ldc.i4.1 
				L_0180: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xf1420593eaecc724(Boolean)
				L_0185: br.s L_019b
				L_0187: ldarg.0 
				L_0188: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_018d: ldarg.0 
				L_018e: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x8d677ea3c0d5a202
				L_0193: ldloc.s V_6
				L_0195: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean AnimateWindow(IntPtr, UInt32, UInt32)
				L_019a: pop 
				L_019b: ldc.i4.1 
				L_019c: stloc.3 
				L_019d: ldloc.3 
				L_019e: brtrue.s L_01ad
				L_01a0: ldarg.0 
				L_01a1: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_01a6: ldc.i4.4 
				L_01a7: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ShowWindow(IntPtr, Int16)
				L_01ac: pop 
				L_01ad: ret 
			*/
			
			
			{
				bool b2;
				int i1;
				uint uInt32_1;
				int i2;
				Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced x6fd23f8bad2f3ced1;
				this.xdb6050a2030517f4 = x902c4aee45bfd906.x9c8c46cd7553cd2b;
				Size size1 = this.x4e2849ed170f5bc2 ();
				Point point1 = this.x1339f634e34e0e03 (size1);
				if (this.xf4f555905eaa2330.Count == 0)
				{
					size1 = new Size (0, 0);
				}
				CreateParams createParams1 = new CreateParams ();
				createParams1.Caption = "NativeSkinContextMenu";
				createParams1.X = point1.X;
				createParams1.Y = point1.Y;
				createParams1.Height = size1.Height;
				createParams1.Width = size1.Width;
				createParams1.Parent = IntPtr.Zero;
				createParams1.Style = int.MinValue;
				createParams1.ExStyle = 136;
				if (this.xdb6050a2030517f4)
				{
					createParams1.ExStyle += 524288;
				}
				this.CreateHandle (createParams1);
				if (! this.xdb6050a2030517f4)
				{
					this.x1803d70928e3ae9b (size1);
				}
				this.x86ef051842f1ae49 = size1;
				this.x6941e4b46c92846d = point1;
				bool b1 = false;
				if (this.xdb6050a2030517f4)
				{
					this.x9119fce83e4631ad ();
					b2 = false;
					x6fd23f8bad2f3ced1 = this.x1cb292d12d9bf68e;
					switch (x6fd23f8bad2f3ced1)
					{
						case Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced.xa0950aeff247b5e2:
						
						{
								b2 = false;
								break;
						}
						case Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced.xbdc78d778d82071f:
						
						{
								b2 = true;
								break;
						}
						case Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced.xfcb094606adb402c:
						
						{
								i1 = 0;
								bool b3 = x61467fe65a98f20c.SystemParametersInfoA (4098, uint.MinValue, ref i1, uint.MinValue);
								b2 = (i1 != 0);
								break;
						}
					}
					if (b2 && this.x0a7391c99fcdc469)
					{
						uInt32_1 = ((uint) this.xa89034e65472167c);
						if (this.xa89034e65472167c == x1f5697535eab37b9.xfcb094606adb402c)
						{
							i2 = 0;
							bool b4 = x61467fe65a98f20c.SystemParametersInfoA (4114, uint.MinValue, ref i2, uint.MinValue);
							if (i2 == 0)
							{
								uInt32_1 = 262149;
							}
							else
							{
								uInt32_1 = 524288;
							}
						}
						if ((((int) uInt32_1) & 524288) != 0)
						{
							this.xf1420593eaecc724 (true);
						}
						else
						{
							bool b5 = x61467fe65a98f20c.AnimateWindow (base.Handle, ((uint) this.x8d677ea3c0d5a202), uInt32_1);
						}
						b1 = true;
					}
				}
				if (! b1)
				{
					int i3 = x61467fe65a98f20c.ShowWindow (base.Handle, 4);
				}
			}
			
			protected void xa68b9c37c0ff7fc5 (ref Message x6088325dec1baa2a)
			
			/*
				// Code Size: 19 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_0006: callvirt System.Windows.Forms.Timer::Void Stop()
				L_000b: ldarg.0 
				L_000c: ldc.i4.1 
				L_000d: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_0012: ret 
			*/
			
			
			{
				this.x420067493d7ebb36.Stop ();
				this.x9a75ed38d1972c87 = true;
			}
			
			protected void xa84c74b103039157 ()
			
			/*
				// Code Size: 53 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0006: ldc.i4.m1 
				L_0007: beq.s L_0020
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_000f: brtrue.s L_0020
				L_0011: ldarg.0 
				L_0012: ldarg.0 
				L_0013: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0018: ldc.i4.m1 
				L_0019: ldc.i4.0 
				L_001a: ldc.i4.0 
				L_001b: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xeb515a5b77846afe(Int32, Int32, Boolean, Boolean)
				L_0020: ldarg.0 
				L_0021: ldc.i4.0 
				L_0022: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x753f06f9b5cd6e0d
				L_0027: ldarg.0 
				L_0028: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x50d4e184d788ac8c
				L_002d: ldc.i4.m1 
				L_002e: ldc.i4.m1 
				L_002f: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0034: ret 
			*/
			
			
			{
				if ((this.xb266b78561d63b52 != -1) && (this.x5142fa1a3d9591c8 == null))
				{
					this.xeb515a5b77846afe (this.xb266b78561d63b52, -1, false, false);
				}
				this.x753f06f9b5cd6e0d = false;
				this.x50d4e184d788ac8c = new Point (-1, -1);
			}
			
			protected bool xb2aa7fc859b3d5b7 ()
			
			/*
				// Code Size: 313 Bytes
				.maxstack 6
				.locals (System.Boolean V_0, 
         System.Boolean V_1, 
         System.Boolean V_2, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_9, 
         System.Int32 V_10, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_11)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_0006: ldnull 
				L_0007: ceq 
				L_0009: ldc.i4.0 
				L_000a: ceq 
				L_000c: stloc.0 
				L_000d: ldc.i4.0 
				L_000e: stloc.1 
				L_000f: ldc.i4.0 
				L_0010: stloc.2 
				L_0011: ldarg.0 
				L_0012: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0017: ldc.i4.m1 
				L_0018: beq L_00fb
				L_001d: ldarg.0 
				L_001e: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0023: ldarg.0 
				L_0024: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0029: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_002e: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0033: stloc.3 
				L_0034: ldloc.3 
				L_0035: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x649e2ad374251b5f()
				L_003a: brfalse.s L_0050
				L_003c: ldarg.0 
				L_003d: ldarg.0 
				L_003e: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0043: ldc.i4.1 
				L_0044: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x0760506d6abf77a2(Int32, Boolean)
				L_0049: ldc.i4.1 
				L_004a: stloc.2 
				L_004b: br L_0111
				L_0050: ldloc.3 
				L_0051: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 get_x2f00dc9f5cd11802()
				L_0056: stloc.s V_4
				L_0058: ldloc.3 
				L_0059: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 get_xa19781cfbe8b4961()
				L_005e: stloc.s V_5
				L_0060: ldc.i4.m1 
				L_0061: stloc.s V_6
				L_0063: ldc.i4.m1 
				L_0064: stloc.s V_7
				L_0066: ldloc.s V_4
				L_0068: ldc.i4.1 
				L_0069: add 
				L_006a: stloc.s V_8
				L_006c: ldnull 
				L_006d: stloc.s V_9
				L_006f: ldc.i4.0 
				L_0070: stloc.s V_10
				L_0072: br.s L_00d2
				L_0074: ldarg.0 
				L_0075: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_007a: ldloc.s V_10
				L_007c: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0081: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0086: stloc.s V_11
				L_0088: ldloc.s V_11
				L_008a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 get_x2f00dc9f5cd11802()
				L_008f: ldloc.s V_8
				L_0091: bne.un.s L_00cc
				L_0093: ldloc.s V_11
				L_0095: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 get_xa19781cfbe8b4961()
				L_009a: ldloc.s V_5
				L_009c: bgt.s L_00cc
				L_009e: ldloc.s V_11
				L_00a0: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 get_xa19781cfbe8b4961()
				L_00a5: ldloc.s V_7
				L_00a7: ble.s L_00cc
				L_00a9: ldloc.s V_11
				L_00ab: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x43604484a3deae4f()
				L_00b0: brtrue.s L_00cc
				L_00b2: ldloc.s V_11
				L_00b4: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x9f2c0dc847992f03()
				L_00b9: brfalse.s L_00cc
				L_00bb: ldloc.s V_11
				L_00bd: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Int32 get_xa19781cfbe8b4961()
				L_00c2: stloc.s V_7
				L_00c4: ldloc.s V_11
				L_00c6: stloc.s V_9
				L_00c8: ldloc.s V_10
				L_00ca: stloc.s V_6
				L_00cc: ldloc.s V_10
				L_00ce: ldc.i4.1 
				L_00cf: add 
				L_00d0: stloc.s V_10
				L_00d2: ldloc.s V_10
				L_00d4: ldarg.0 
				L_00d5: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_00da: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_00df: blt.s L_0074
				L_00e1: ldloc.s V_9
				L_00e3: brfalse.s L_00f7
				L_00e5: ldarg.0 
				L_00e6: ldarg.0 
				L_00e7: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_00ec: ldloc.s V_6
				L_00ee: ldc.i4.0 
				L_00ef: ldc.i4.0 
				L_00f0: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xeb515a5b77846afe(Int32, Int32, Boolean, Boolean)
				L_00f5: br.s L_0111
				L_00f7: ldc.i4.1 
				L_00f8: stloc.1 
				L_00f9: br.s L_0111
				L_00fb: ldarg.0 
				L_00fc: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0101: brfalse.s L_010f
				L_0103: ldarg.0 
				L_0104: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x5b2e42a68d835b31()
				L_0109: brtrue.s L_0111
				L_010b: ldc.i4.1 
				L_010c: stloc.1 
				L_010d: br.s L_0111
				L_010f: ldc.i4.1 
				L_0110: stloc.1 
				L_0111: ldloc.0 
				L_0112: brfalse.s L_0137
				L_0114: ldloc.1 
				L_0115: brfalse.s L_0137
				L_0117: ldarg.0 
				L_0118: ldnull 
				L_0119: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_011e: ldarg.0 
				L_011f: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_0124: callvirt System.Windows.Forms.Timer::Void Stop()
				L_0129: ldarg.0 
				L_012a: ldc.i4.1 
				L_012b: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_0130: ldarg.0 
				L_0131: ldc.i4.1 
				L_0132: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x0cd2bb383a46f073
				L_0137: ldloc.2 
				L_0138: ret 
			*/
			
			
			{
				x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				int i1;
				int i2;
				int i3;
				int i4;
				int i5;
				x2cc390e9409b0f3f x2cc390e9409b0f3f2;
				int i6;
				x2cc390e9409b0f3f x2cc390e9409b0f3f3;
				bool b1 = (this.x37f2fc2a7f30f790 != null);
				bool b2 = false;
				bool b3 = false;
				if (this.xb266b78561d63b52 != -1)
				{
					x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[this.xb266b78561d63b52] as x2cc390e9409b0f3f);
					if (x2cc390e9409b0f3f1.x649e2ad374251b5f)
					{
						this.x0760506d6abf77a2 (this.xb266b78561d63b52, true);
						b3 = true;
					}
					else
					{
						i1 = x2cc390e9409b0f3f1.x2f00dc9f5cd11802;
						i2 = x2cc390e9409b0f3f1.xa19781cfbe8b4961;
						i3 = -1;
						i4 = -1;
						i5 = (i1 + 1);
						x2cc390e9409b0f3f2 = ((x2cc390e9409b0f3f) null);
						for (i6 = 0; (i6 < this.xfb5697071ce83988.Count); i6++)
						{
							x2cc390e9409b0f3f3 = (this.xfb5697071ce83988[i6] as x2cc390e9409b0f3f);
							if (((((x2cc390e9409b0f3f3.x2f00dc9f5cd11802 == i5) && (x2cc390e9409b0f3f3.xa19781cfbe8b4961 <= i2)) && (x2cc390e9409b0f3f3.xa19781cfbe8b4961 > i4)) && (! x2cc390e9409b0f3f3.x43604484a3deae4f)) && x2cc390e9409b0f3f3.x9f2c0dc847992f03)
							{
								i4 = x2cc390e9409b0f3f3.xa19781cfbe8b4961;
								x2cc390e9409b0f3f2 = x2cc390e9409b0f3f3;
								i3 = i6;
							}
						}
						if (x2cc390e9409b0f3f2 != null)
						{
							this.xeb515a5b77846afe (this.xb266b78561d63b52, i3, false, false);
						}
						else
						{
							b2 = true;
						}
					}
				}
				else if (this.xb13f2de377f27597 == null)
				{
					b2 = true;
				}
				else
				{
					b2 |= (! this.x5b2e42a68d835b31 ());
				}
				if (b1 && b2)
				{
					this.x4547ebd0fd2a7079 = ((x5f4b657f68f87baa) null);
					this.x420067493d7ebb36.Stop ();
					this.x9a75ed38d1972c87 = true;
					this.x0cd2bb383a46f073 = 1;
				}
				return b3;
			}
			
			protected void xb3525a0e7d2fd376 ()
			
			/*
				// Code Size: 430 Bytes
				.maxstack 5
				.locals (System.Drawing.Size V_0, 
         System.Drawing.Point V_1, 
         System.Windows.Forms.CreateParams V_2, 
         System.Boolean V_3, 
         System.Boolean V_4, 
         System.Int32 V_5, 
         System.UInt32 V_6, 
         System.Int32 V_7, 
         Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced V_8)
				L_0000: ldarg.0 
				L_0001: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9c8c46cd7553cd2b
				L_0006: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xdb6050a2030517f4
				L_000b: ldarg.0 
				L_000c: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Size x4e2849ed170f5bc2()
				L_0011: stloc.0 
				L_0012: ldarg.0 
				L_0013: ldloc.0 
				L_0014: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6e375ee3ca34b13b(System.Drawing.Size)
				L_0019: stloc.1 
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0020: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_0025: brtrue.s L_0030
				L_0027: ldloca.s V_0
				L_0029: ldc.i4.0 
				L_002a: ldc.i4.0 
				L_002b: call System.Drawing.Size::Void .ctor(Int32, Int32)
				L_0030: newobj System.Windows.Forms.CreateParams::Void .ctor()
				L_0035: stloc.2 
				L_0036: ldloc.2 
				L_0037: ldstr "NativeSkinContextMenu"
				L_003c: callvirt System.Windows.Forms.CreateParams::Void set_Caption(System.String)
				L_0041: ldloc.2 
				L_0042: ldloca.s V_1
				L_0044: call System.Drawing.Point::Int32 get_X()
				L_0049: callvirt System.Windows.Forms.CreateParams::Void set_X(Int32)
				L_004e: ldloc.2 
				L_004f: ldloca.s V_1
				L_0051: call System.Drawing.Point::Int32 get_Y()
				L_0056: callvirt System.Windows.Forms.CreateParams::Void set_Y(Int32)
				L_005b: ldloc.2 
				L_005c: ldloca.s V_0
				L_005e: call System.Drawing.Size::Int32 get_Height()
				L_0063: callvirt System.Windows.Forms.CreateParams::Void set_Height(Int32)
				L_0068: ldloc.2 
				L_0069: ldloca.s V_0
				L_006b: call System.Drawing.Size::Int32 get_Width()
				L_0070: callvirt System.Windows.Forms.CreateParams::Void set_Width(Int32)
				L_0075: ldloc.2 
				L_0076: ldsfld System.IntPtr::IntPtr Zero
				L_007b: callvirt System.Windows.Forms.CreateParams::Void set_Parent(IntPtr)
				L_0080: ldloc.2 
				L_0081: ldc.i4 -2147483648
				L_0086: callvirt System.Windows.Forms.CreateParams::Void set_Style(Int32)
				L_008b: ldloc.2 
				L_008c: ldc.i4 136
				L_0091: callvirt System.Windows.Forms.CreateParams::Void set_ExStyle(Int32)
				L_0096: ldarg.0 
				L_0097: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xdb6050a2030517f4
				L_009c: brfalse.s L_00b0
				L_009e: ldloc.2 
				L_009f: dup 
				L_00a0: callvirt System.Windows.Forms.CreateParams::Int32 get_ExStyle()
				L_00a5: ldc.i4 524288
				L_00aa: add 
				L_00ab: callvirt System.Windows.Forms.CreateParams::Void set_ExStyle(Int32)
				L_00b0: ldarg.0 
				L_00b1: ldloc.2 
				L_00b2: callvirt System.Windows.Forms.NativeWindow::Void CreateHandle(System.Windows.Forms.CreateParams)
				L_00b7: ldarg.0 
				L_00b8: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xdb6050a2030517f4
				L_00bd: brtrue.s L_00c6
				L_00bf: ldarg.0 
				L_00c0: ldloc.0 
				L_00c1: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x1803d70928e3ae9b(System.Drawing.Size)
				L_00c6: ldarg.0 
				L_00c7: ldloc.0 
				L_00c8: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Size x86ef051842f1ae49
				L_00cd: ldarg.0 
				L_00ce: ldloc.1 
				L_00cf: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_00d4: ldc.i4.0 
				L_00d5: stloc.3 
				L_00d6: ldarg.0 
				L_00d7: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xdb6050a2030517f4
				L_00dc: brfalse L_019d
				L_00e1: ldarg.0 
				L_00e2: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x9119fce83e4631ad()
				L_00e7: ldc.i4.0 
				L_00e8: stloc.s V_4
				L_00ea: ldarg.0 
				L_00eb: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced x1cb292d12d9bf68e
				L_00f0: stloc.s V_8
				L_00f2: ldloc.s V_8
				L_00f4: switch (L_0107, L_010c, L_0111)
				L_0105: br.s L_012d
				L_0107: ldc.i4.0 
				L_0108: stloc.s V_4
				L_010a: br.s L_012d
				L_010c: ldc.i4.1 
				L_010d: stloc.s V_4
				L_010f: br.s L_012d
				L_0111: ldc.i4.0 
				L_0112: stloc.s V_5
				L_0114: ldc.i4 4098
				L_0119: ldc.i4.0 
				L_011a: ldloca.s V_5
				L_011c: ldc.i4.0 
				L_011d: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean SystemParametersInfoA(UInt32, UInt32, Int32 ByRef, UInt32)
				L_0122: pop 
				L_0123: ldloc.s V_5
				L_0125: ldc.i4.0 
				L_0126: ceq 
				L_0128: ldc.i4.0 
				L_0129: ceq 
				L_012b: stloc.s V_4
				L_012d: ldloc.s V_4
				L_012f: brfalse.s L_019d
				L_0131: ldarg.0 
				L_0132: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x0a7391c99fcdc469
				L_0137: brfalse.s L_019d
				L_0139: ldarg.0 
				L_013a: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x1f5697535eab37b9 xa89034e65472167c
				L_013f: stloc.s V_6
				L_0141: ldarg.0 
				L_0142: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x1f5697535eab37b9 xa89034e65472167c
				L_0147: ldc.i4 1048576
				L_014c: bne.un.s L_0174
				L_014e: ldc.i4.0 
				L_014f: stloc.s V_7
				L_0151: ldc.i4 4114
				L_0156: ldc.i4.0 
				L_0157: ldloca.s V_7
				L_0159: ldc.i4.0 
				L_015a: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean SystemParametersInfoA(UInt32, UInt32, Int32 ByRef, UInt32)
				L_015f: pop 
				L_0160: ldloc.s V_7
				L_0162: brfalse.s L_016d
				L_0164: ldc.i4 524288
				L_0169: stloc.s V_6
				L_016b: br.s L_0174
				L_016d: ldc.i4 262149
				L_0172: stloc.s V_6
				L_0174: ldloc.s V_6
				L_0176: ldc.i4 524288
				L_017b: and 
				L_017c: brfalse.s L_0187
				L_017e: ldarg.0 
				L_017f: ldc.i4.1 
				L_0180: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xf1420593eaecc724(Boolean)
				L_0185: br.s L_019b
				L_0187: ldarg.0 
				L_0188: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_018d: ldarg.0 
				L_018e: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x8d677ea3c0d5a202
				L_0193: ldloc.s V_6
				L_0195: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean AnimateWindow(IntPtr, UInt32, UInt32)
				L_019a: pop 
				L_019b: ldc.i4.1 
				L_019c: stloc.3 
				L_019d: ldloc.3 
				L_019e: brtrue.s L_01ad
				L_01a0: ldarg.0 
				L_01a1: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_01a6: ldc.i4.4 
				L_01a7: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ShowWindow(IntPtr, Int16)
				L_01ac: pop 
				L_01ad: ret 
			*/
			
			
			{
				bool b2;
				int i1;
				uint uInt32_1;
				int i2;
				Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced x6fd23f8bad2f3ced1;
				this.xdb6050a2030517f4 = x902c4aee45bfd906.x9c8c46cd7553cd2b;
				Size size1 = this.x4e2849ed170f5bc2 ();
				Point point1 = this.x6e375ee3ca34b13b (size1);
				if (this.xf4f555905eaa2330.Count == 0)
				{
					size1 = new Size (0, 0);
				}
				CreateParams createParams1 = new CreateParams ();
				createParams1.Caption = "NativeSkinContextMenu";
				createParams1.X = point1.X;
				createParams1.Y = point1.Y;
				createParams1.Height = size1.Height;
				createParams1.Width = size1.Width;
				createParams1.Parent = IntPtr.Zero;
				createParams1.Style = int.MinValue;
				createParams1.ExStyle = 136;
				if (this.xdb6050a2030517f4)
				{
					createParams1.ExStyle += 524288;
				}
				this.CreateHandle (createParams1);
				if (! this.xdb6050a2030517f4)
				{
					this.x1803d70928e3ae9b (size1);
				}
				this.x86ef051842f1ae49 = size1;
				this.x6941e4b46c92846d = point1;
				bool b1 = false;
				if (this.xdb6050a2030517f4)
				{
					this.x9119fce83e4631ad ();
					b2 = false;
					x6fd23f8bad2f3ced1 = this.x1cb292d12d9bf68e;
					switch (x6fd23f8bad2f3ced1)
					{
						case Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced.xa0950aeff247b5e2:
						
						{
								b2 = false;
								break;
						}
						case Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced.xbdc78d778d82071f:
						
						{
								b2 = true;
								break;
						}
						case Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced.xfcb094606adb402c:
						
						{
								i1 = 0;
								bool b3 = x61467fe65a98f20c.SystemParametersInfoA (4098, uint.MinValue, ref i1, uint.MinValue);
								b2 = (i1 != 0);
								break;
						}
					}
					if (b2 && this.x0a7391c99fcdc469)
					{
						uInt32_1 = ((uint) this.xa89034e65472167c);
						if (this.xa89034e65472167c == x1f5697535eab37b9.xfcb094606adb402c)
						{
							i2 = 0;
							bool b4 = x61467fe65a98f20c.SystemParametersInfoA (4114, uint.MinValue, ref i2, uint.MinValue);
							if (i2 == 0)
							{
								uInt32_1 = 262149;
							}
							else
							{
								uInt32_1 = 524288;
							}
						}
						if ((((int) uInt32_1) & 524288) != 0)
						{
							this.xf1420593eaecc724 (true);
						}
						else
						{
							bool b5 = x61467fe65a98f20c.AnimateWindow (base.Handle, ((uint) this.x8d677ea3c0d5a202), uInt32_1);
						}
						b1 = true;
					}
				}
				if (! b1)
				{
					int i3 = x61467fe65a98f20c.ShowWindow (base.Handle, 4);
				}
			}
			
			internal void xb5a5bdae3ba8936b (Graphics x4b101060f4767186, x2cc390e9409b0f3f xd2a8bb4342ab4ef6, bool x15a0329046fb799f)
			
			/*
				// Code Size: 2898 Bytes
				.maxstack 8
				.locals (System.Drawing.Brush V_0, 
         System.Drawing.Rectangle V_1, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_2, 
         System.Drawing.Color V_3, 
         System.Drawing.Color V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         System.Int32 V_9, 
         System.Int32 V_10, 
         System.Int32 V_11, 
         System.Drawing.Rectangle V_12, 
         System.Int32 V_13, 
         System.Int32 V_14, 
         System.Drawing.Rectangle V_15, 
         System.Drawing.Pen V_16, 
         System.Drawing.SolidBrush V_17, 
         System.Drawing.SolidBrush V_18, 
         System.Drawing.Pen V_19, 
         System.Drawing.Rectangle V_20, 
         System.Drawing.Drawing2D.LinearGradientBrush V_21, 
         System.Drawing.Pen V_22, 
         System.Int32 V_23, 
         System.Drawing.Rectangle V_24, 
         System.Drawing.Pen V_25, 
         System.Drawing.SolidBrush V_26, 
         System.Drawing.SolidBrush V_27, 
         System.Drawing.Brush V_28, 
         System.Drawing.Rectangle V_29, 
         System.Drawing.Drawing2D.LinearGradientBrush V_30, 
         System.Drawing.Rectangle V_31, 
         System.Drawing.StringFormat V_32, 
         System.Drawing.SolidBrush V_33, 
         System.Drawing.Rectangle V_34, 
         System.Int32 V_35, 
         System.Drawing.Image V_36, 
         System.Drawing.Pen V_37, 
         System.Drawing.Brush V_38, 
         System.Drawing.Rectangle V_39, 
         System.Drawing.Bitmap V_40, 
         System.Drawing.Color V_41, 
         System.Drawing.Color V_42, 
         System.Int32 V_43, 
         System.Int32 V_44, 
         System.Drawing.Bitmap V_45, 
         System.Drawing.Color V_46, 
         System.Int32 V_47, 
         System.Int32 V_48, 
         System.Drawing.Color V_49, 
         System.Drawing.Color V_50, 
         System.Int32 V_51)
				.try L_01a6 to L_01b2 finally L_01b2 to L_01be
				.try L_01c7 to L_01dd finally L_01dd to L_01e9
				.try L_019a to L_01ee finally L_01ee to L_01fa
				.try L_02eb to L_0314 finally L_0314 to L_0320
				.try L_03b0 to L_03bc finally L_03bc to L_03c8
				.try L_040a to L_043d finally L_043d to L_0449
				.try L_049b to L_04a7 finally L_04a7 to L_04b3
				.try L_04bc to L_04d2 finally L_04d2 to L_04de
				.try L_048f to L_04e3 finally L_04e3 to L_04ef
				.try L_059f to L_05cb finally L_05cb to L_05d7
				.try L_0667 to L_0673 finally L_0673 to L_067f
				.try L_08f5 to L_0932 catch System.Exception L_0932 to L_0947
				L_0000: ldarg.2 
				L_0001: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_0006: stloc.1 
				L_0007: ldarg.2 
				L_0008: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_000d: stloc.2 
				L_000e: ldarg.0 
				L_000f: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0014: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0019: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_001e: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_SELECTEDMENUCOLOR
				L_0023: pop 
				L_0024: ldarg.0 
				L_0025: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_002a: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_002f: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0034: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_SELECTEDMENUBORDERCOLOR
				L_0039: stloc.3 
				L_003a: ldarg.0 
				L_003b: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0040: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0045: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_004a: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_SELECTEDMENUCOLOR
				L_004f: stloc.s V_4
				L_0051: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0056: ldc.i4.0 
				L_0057: ldc.i4.8 
				L_0058: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_005d: stloc.s V_5
				L_005f: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0064: ldc.i4.0 
				L_0065: ldc.i4.5 
				L_0066: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_006b: stloc.s V_6
				L_006d: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0072: ldc.i4.0 
				L_0073: ldc.i4.7 
				L_0074: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0079: stloc.s V_7
				L_007b: ldloca.s V_1
				L_007d: call System.Drawing.Rectangle::Int32 get_Left()
				L_0082: ldloc.s V_6
				L_0084: add 
				L_0085: stloc.s V_8
				L_0087: ldloc.s V_6
				L_0089: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb28e4e0b2e9dba92
				L_008e: add 
				L_008f: ldloc.s V_7
				L_0091: add 
				L_0092: stloc.s V_9
				L_0094: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0099: ldc.i4.0 
				L_009a: ldc.i4.s 10
				L_009c: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_00a1: pop 
				L_00a2: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_00a7: ldc.i4.0 
				L_00a8: ldc.i4.s 11
				L_00aa: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_00af: pop 
				L_00b0: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_00b5: ldc.i4.0 
				L_00b6: ldc.i4.s 12
				L_00b8: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_00bd: pop 
				L_00be: ldloca.s V_1
				L_00c0: call System.Drawing.Rectangle::Int32 get_Right()
				L_00c5: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_00ca: ldc.i4.0 
				L_00cb: ldc.i4.s 12
				L_00cd: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_00d2: sub 
				L_00d3: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_00d8: ldc.i4.0 
				L_00d9: ldc.i4.s 11
				L_00db: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_00e0: sub 
				L_00e1: stloc.s V_10
				L_00e3: ldloc.s V_10
				L_00e5: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_00ea: ldc.i4.0 
				L_00eb: ldc.i4.s 10
				L_00ed: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_00f2: sub 
				L_00f3: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_00f8: ldc.i4.0 
				L_00f9: ldc.i4.s 9
				L_00fb: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0100: sub 
				L_0101: stloc.s V_11
				L_0103: ldarg.2 
				L_0104: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xc1facdb08ad4967a()
				L_0109: brfalse L_02b7
				L_010e: ldloc.1 
				L_010f: stloc.s V_12
				L_0111: ldloca.s V_12
				L_0113: dup 
				L_0114: call System.Drawing.Rectangle::Int32 get_X()
				L_0119: ldloc.s V_9
				L_011b: add 
				L_011c: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0121: ldloca.s V_12
				L_0123: dup 
				L_0124: call System.Drawing.Rectangle::Int32 get_Width()
				L_0129: ldloc.s V_9
				L_012b: sub 
				L_012c: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0131: ldloca.s V_12
				L_0133: call System.Drawing.Rectangle::Int32 get_Left()
				L_0138: ldloca.s V_12
				L_013a: call System.Drawing.Rectangle::Int32 get_Width()
				L_013f: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xd2611dcb50ae5373
				L_0144: sub 
				L_0145: ldc.i4.2 
				L_0146: div 
				L_0147: add 
				L_0148: stloc.s V_13
				L_014a: ldloca.s V_12
				L_014c: call System.Drawing.Rectangle::Int32 get_Top()
				L_0151: ldloca.s V_12
				L_0153: call System.Drawing.Rectangle::Int32 get_Height()
				L_0158: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xd2611dcb50ae5373
				L_015d: sub 
				L_015e: ldc.i4.2 
				L_015f: div 
				L_0160: add 
				L_0161: stloc.s V_14
				L_0163: ldarg.3 
				L_0164: brfalse L_01fa
				L_0169: ldloca.s V_15
				L_016b: ldloca.s V_1
				L_016d: call System.Drawing.Rectangle::Int32 get_Left()
				L_0172: ldc.i4.1 
				L_0173: add 
				L_0174: ldloca.s V_1
				L_0176: call System.Drawing.Rectangle::Int32 get_Top()
				L_017b: ldloca.s V_1
				L_017d: call System.Drawing.Rectangle::Int32 get_Width()
				L_0182: ldc.i4.3 
				L_0183: sub 
				L_0184: ldloca.s V_1
				L_0186: call System.Drawing.Rectangle::Int32 get_Height()
				L_018b: ldc.i4.1 
				L_018c: sub 
				L_018d: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0192: ldloc.3 
				L_0193: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0198: stloc.s V_16
				L_019a: call System.Drawing.Color::System.Drawing.Color get_White()
				L_019f: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_01a4: stloc.s V_17
				L_01a6: ldarg.1 
				L_01a7: ldloc.s V_17
				L_01a9: ldloc.s V_15
				L_01ab: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_01b0: leave.s L_01be
				L_01b2: ldloc.s V_17
				L_01b4: brfalse.s L_01bd
				L_01b6: ldloc.s V_17
				L_01b8: callvirt System.IDisposable::Void Dispose()
				L_01bd: endfinally 
				L_01be: ldloc.s V_4
				L_01c0: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_01c5: stloc.s V_18
				L_01c7: ldarg.1 
				L_01c8: ldloc.s V_18
				L_01ca: ldloc.s V_15
				L_01cc: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_01d1: ldarg.1 
				L_01d2: ldloc.s V_16
				L_01d4: ldloc.s V_15
				L_01d6: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_01db: leave.s L_01e9
				L_01dd: ldloc.s V_18
				L_01df: brfalse.s L_01e8
				L_01e1: ldloc.s V_18
				L_01e3: callvirt System.IDisposable::Void Dispose()
				L_01e8: endfinally 
				L_01e9: leave L_029c
				L_01ee: ldloc.s V_16
				L_01f0: brfalse.s L_01f9
				L_01f2: ldloc.s V_16
				L_01f4: callvirt System.IDisposable::Void Dispose()
				L_01f9: endfinally 
				L_01fa: ldarg.0 
				L_01fb: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0200: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0205: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_020a: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_MENUITEMCOLOR()
				L_020f: stloc.0 
				L_0210: ldarg.1 
				L_0211: ldloc.0 
				L_0212: ldloca.s V_1
				L_0214: call System.Drawing.Rectangle::Int32 get_Left()
				L_0219: ldc.i4.1 
				L_021a: add 
				L_021b: ldloca.s V_1
				L_021d: call System.Drawing.Rectangle::Int32 get_Top()
				L_0222: ldloca.s V_1
				L_0224: call System.Drawing.Rectangle::Int32 get_Width()
				L_0229: ldc.i4.1 
				L_022a: sub 
				L_022b: ldloca.s V_1
				L_022d: call System.Drawing.Rectangle::Int32 get_Height()
				L_0232: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0237: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_023c: ldarg.1 
				L_023d: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_0242: ldloca.s V_1
				L_0244: call System.Drawing.Rectangle::Int32 get_Left()
				L_0249: ldloca.s V_1
				L_024b: call System.Drawing.Rectangle::Int32 get_Top()
				L_0250: ldloc.s V_9
				L_0252: ldloca.s V_1
				L_0254: call System.Drawing.Rectangle::Int32 get_Height()
				L_0259: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_025e: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0263: ldarg.0 
				L_0264: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0269: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_026e: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0273: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_LEFTBARSTARTCOLOR()
				L_0278: stloc.0 
				L_0279: ldarg.1 
				L_027a: ldloc.0 
				L_027b: ldloca.s V_1
				L_027d: call System.Drawing.Rectangle::Int32 get_Left()
				L_0282: ldloca.s V_1
				L_0284: call System.Drawing.Rectangle::Int32 get_Top()
				L_0289: ldloc.s V_9
				L_028b: ldloca.s V_1
				L_028d: call System.Drawing.Rectangle::Int32 get_Height()
				L_0292: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0297: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_029c: ldarg.1 
				L_029d: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.ImageList xfeae2ed797ae6fbc
				L_02a2: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_02a7: ldc.i4.6 
				L_02a8: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_02ad: ldloc.s V_13
				L_02af: ldloc.s V_14
				L_02b1: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, Int32, Int32)
				L_02b6: ret 
				L_02b7: ldarg.2 
				L_02b8: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x43604484a3deae4f()
				L_02bd: brfalse L_0449
				L_02c2: ldarg.2 
				L_02c3: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xc8dbe008de6aee9e()
				L_02c8: brfalse.s L_0320
				L_02ca: ldarg.0 
				L_02cb: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_02d0: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_02d5: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_02da: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUITEMCOLOR
				L_02df: call System.Windows.Forms.ControlPaint::System.Drawing.Color Dark(System.Drawing.Color)
				L_02e4: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_02e9: stloc.s V_19
				L_02eb: ldarg.1 
				L_02ec: ldloc.s V_19
				L_02ee: ldloca.s V_1
				L_02f0: call System.Drawing.Rectangle::Int32 get_Left()
				L_02f5: ldloca.s V_1
				L_02f7: call System.Drawing.Rectangle::Int32 get_Top()
				L_02fc: ldloca.s V_1
				L_02fe: call System.Drawing.Rectangle::Int32 get_Left()
				L_0303: ldloca.s V_1
				L_0305: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_030a: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_030f: leave L_0b51
				L_0314: ldloc.s V_19
				L_0316: brfalse.s L_031f
				L_0318: ldloc.s V_19
				L_031a: callvirt System.IDisposable::Void Dispose()
				L_031f: endfinally 
				L_0320: ldloca.s V_20
				L_0322: ldloca.s V_1
				L_0324: call System.Drawing.Rectangle::Int32 get_Left()
				L_0329: ldloca.s V_1
				L_032b: call System.Drawing.Rectangle::Int32 get_Top()
				L_0330: ldloc.s V_9
				L_0332: ldloca.s V_1
				L_0334: call System.Drawing.Rectangle::Int32 get_Height()
				L_0339: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_033e: ldarg.1 
				L_033f: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_0344: ldloc.s V_20
				L_0346: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_034b: ldarg.0 
				L_034c: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0351: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0356: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_035b: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARSTARTCOLOR
				L_0360: ldarg.0 
				L_0361: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_0366: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_036b: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0370: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARENDCOLOR
				L_0375: call System.Drawing.Color::Boolean op_Inequality(System.Drawing.Color, System.Drawing.Color)
				L_037a: brfalse.s L_03c8
				L_037c: ldloc.s V_20
				L_037e: ldarg.0 
				L_037f: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_0384: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0389: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_038e: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARSTARTCOLOR
				L_0393: ldarg.0 
				L_0394: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_0399: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_039e: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_03a3: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARENDCOLOR
				L_03a8: ldc.i4.0 
				L_03a9: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Rectangle, System.Drawing.Color, System.Drawing.Color, System.Drawing.Drawing2D.LinearGradientMode)
				L_03ae: stloc.s V_21
				L_03b0: ldarg.1 
				L_03b1: ldloc.s V_21
				L_03b3: ldloc.s V_20
				L_03b5: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_03ba: leave.s L_03e7
				L_03bc: ldloc.s V_21
				L_03be: brfalse.s L_03c7
				L_03c0: ldloc.s V_21
				L_03c2: callvirt System.IDisposable::Void Dispose()
				L_03c7: endfinally 
				L_03c8: ldarg.0 
				L_03c9: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_03ce: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_03d3: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_03d8: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_LEFTBARSTARTCOLOR()
				L_03dd: stloc.0 
				L_03de: ldarg.1 
				L_03df: ldloc.0 
				L_03e0: ldloc.s V_20
				L_03e2: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_03e7: ldc.i4.s 75
				L_03e9: ldarg.0 
				L_03ea: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_03ef: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_03f4: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_03f9: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUITEMFONTCOLOR
				L_03fe: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, System.Drawing.Color)
				L_0403: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0408: stloc.s V_22
				L_040a: ldarg.1 
				L_040b: ldloc.s V_22
				L_040d: ldloca.s V_1
				L_040f: call System.Drawing.Rectangle::Int32 get_Left()
				L_0414: ldloc.s V_9
				L_0416: add 
				L_0417: ldloc.s V_5
				L_0419: add 
				L_041a: ldloca.s V_1
				L_041c: call System.Drawing.Rectangle::Int32 get_Top()
				L_0421: ldc.i4.2 
				L_0422: add 
				L_0423: ldloca.s V_1
				L_0425: call System.Drawing.Rectangle::Int32 get_Right()
				L_042a: ldloca.s V_1
				L_042c: call System.Drawing.Rectangle::Int32 get_Top()
				L_0431: ldc.i4.2 
				L_0432: add 
				L_0433: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0438: leave L_0b51
				L_043d: ldloc.s V_22
				L_043f: brfalse.s L_0448
				L_0441: ldloc.s V_22
				L_0443: callvirt System.IDisposable::Void Dispose()
				L_0448: endfinally 
				L_0449: ldloca.s V_1
				L_044b: call System.Drawing.Rectangle::Int32 get_Left()
				L_0450: ldloc.s V_9
				L_0452: add 
				L_0453: ldloc.s V_5
				L_0455: add 
				L_0456: stloc.s V_23
				L_0458: ldarg.3 
				L_0459: brfalse L_04ef
				L_045e: ldloca.s V_24
				L_0460: ldloca.s V_1
				L_0462: call System.Drawing.Rectangle::Int32 get_Left()
				L_0467: ldc.i4.1 
				L_0468: add 
				L_0469: ldloca.s V_1
				L_046b: call System.Drawing.Rectangle::Int32 get_Top()
				L_0470: ldloca.s V_1
				L_0472: call System.Drawing.Rectangle::Int32 get_Width()
				L_0477: ldc.i4.3 
				L_0478: sub 
				L_0479: ldloca.s V_1
				L_047b: call System.Drawing.Rectangle::Int32 get_Height()
				L_0480: ldc.i4.1 
				L_0481: sub 
				L_0482: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0487: ldloc.3 
				L_0488: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_048d: stloc.s V_25
				L_048f: call System.Drawing.Color::System.Drawing.Color get_White()
				L_0494: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0499: stloc.s V_26
				L_049b: ldarg.1 
				L_049c: ldloc.s V_26
				L_049e: ldloc.s V_24
				L_04a0: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_04a5: leave.s L_04b3
				L_04a7: ldloc.s V_26
				L_04a9: brfalse.s L_04b2
				L_04ab: ldloc.s V_26
				L_04ad: callvirt System.IDisposable::Void Dispose()
				L_04b2: endfinally 
				L_04b3: ldloc.s V_4
				L_04b5: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_04ba: stloc.s V_27
				L_04bc: ldarg.1 
				L_04bd: ldloc.s V_27
				L_04bf: ldloc.s V_24
				L_04c1: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_04c6: ldarg.1 
				L_04c7: ldloc.s V_25
				L_04c9: ldloc.s V_24
				L_04cb: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_04d0: leave.s L_04de
				L_04d2: ldloc.s V_27
				L_04d4: brfalse.s L_04dd
				L_04d6: ldloc.s V_27
				L_04d8: callvirt System.IDisposable::Void Dispose()
				L_04dd: endfinally 
				L_04de: leave L_069e
				L_04e3: ldloc.s V_25
				L_04e5: brfalse.s L_04ee
				L_04e7: ldloc.s V_25
				L_04e9: callvirt System.IDisposable::Void Dispose()
				L_04ee: endfinally 
				L_04ef: ldarg.0 
				L_04f0: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_04f5: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_04fa: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_04ff: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_MENUITEMCOLOR()
				L_0504: stloc.0 
				L_0505: ldarg.1 
				L_0506: ldloc.0 
				L_0507: ldloca.s V_1
				L_0509: call System.Drawing.Rectangle::Int32 get_Left()
				L_050e: ldc.i4.1 
				L_050f: add 
				L_0510: ldloca.s V_1
				L_0512: call System.Drawing.Rectangle::Int32 get_Top()
				L_0517: ldloca.s V_1
				L_0519: call System.Drawing.Rectangle::Int32 get_Width()
				L_051e: ldc.i4.1 
				L_051f: sub 
				L_0520: ldloca.s V_1
				L_0522: call System.Drawing.Rectangle::Int32 get_Height()
				L_0527: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_052c: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0531: ldarg.2 
				L_0532: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x062575979028fd71()
				L_0537: brfalse L_05d7
				L_053c: ldarg.0 
				L_053d: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x604ddcdfda178b5a
				L_0542: brfalse L_05d7
				L_0547: ldarg.1 
				L_0548: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_054d: ldloc.s V_23
				L_054f: ldloca.s V_1
				L_0551: call System.Drawing.Rectangle::Int32 get_Top()
				L_0556: ldloca.s V_1
				L_0558: call System.Drawing.Rectangle::Int32 get_Right()
				L_055d: ldloc.s V_23
				L_055f: sub 
				L_0560: ldloc.s V_5
				L_0562: sub 
				L_0563: ldloca.s V_1
				L_0565: call System.Drawing.Rectangle::Int32 get_Height()
				L_056a: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_056f: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0574: ldarg.0 
				L_0575: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_057a: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_057f: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0584: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUITEMCOLOR
				L_0589: call System.Drawing.Color::System.Drawing.Color get_White()
				L_058e: ldc.i4 150
				L_0593: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Color x898c3842f8dd56e5(System.Drawing.Color, System.Drawing.Color, Int32)
				L_0598: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_059d: stloc.s V_28
				L_059f: ldarg.1 
				L_05a0: ldloc.s V_28
				L_05a2: ldloc.s V_23
				L_05a4: ldloca.s V_1
				L_05a6: call System.Drawing.Rectangle::Int32 get_Top()
				L_05ab: ldloca.s V_1
				L_05ad: call System.Drawing.Rectangle::Int32 get_Right()
				L_05b2: ldloc.s V_23
				L_05b4: sub 
				L_05b5: ldloc.s V_5
				L_05b7: sub 
				L_05b8: ldloca.s V_1
				L_05ba: call System.Drawing.Rectangle::Int32 get_Height()
				L_05bf: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_05c4: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_05c9: leave.s L_05d7
				L_05cb: ldloc.s V_28
				L_05cd: brfalse.s L_05d6
				L_05cf: ldloc.s V_28
				L_05d1: callvirt System.IDisposable::Void Dispose()
				L_05d6: endfinally 
				L_05d7: ldloca.s V_29
				L_05d9: ldloca.s V_1
				L_05db: call System.Drawing.Rectangle::Int32 get_Left()
				L_05e0: ldloca.s V_1
				L_05e2: call System.Drawing.Rectangle::Int32 get_Top()
				L_05e7: ldloc.s V_9
				L_05e9: ldloca.s V_1
				L_05eb: call System.Drawing.Rectangle::Int32 get_Height()
				L_05f0: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_05f5: ldarg.1 
				L_05f6: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_05fb: ldloc.s V_29
				L_05fd: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0602: ldarg.0 
				L_0603: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0608: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_060d: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0612: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARSTARTCOLOR
				L_0617: ldarg.0 
				L_0618: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_061d: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0622: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0627: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARENDCOLOR
				L_062c: call System.Drawing.Color::Boolean op_Inequality(System.Drawing.Color, System.Drawing.Color)
				L_0631: brfalse.s L_067f
				L_0633: ldloc.s V_29
				L_0635: ldarg.0 
				L_0636: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_063b: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0640: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0645: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARSTARTCOLOR
				L_064a: ldarg.0 
				L_064b: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
				L_0650: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0655: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_065a: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_LEFTBARENDCOLOR
				L_065f: ldc.i4.0 
				L_0660: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Rectangle, System.Drawing.Color, System.Drawing.Color, System.Drawing.Drawing2D.LinearGradientMode)
				L_0665: stloc.s V_30
				L_0667: ldarg.1 
				L_0668: ldloc.s V_30
				L_066a: ldloc.s V_29
				L_066c: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0671: leave.s L_069e
				L_0673: ldloc.s V_30
				L_0675: brfalse.s L_067e
				L_0677: ldloc.s V_30
				L_0679: callvirt System.IDisposable::Void Dispose()
				L_067e: endfinally 
				L_067f: ldarg.0 
				L_0680: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0685: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_068a: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_068f: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_LEFTBARSTARTCOLOR()
				L_0694: stloc.0 
				L_0695: ldarg.1 
				L_0696: ldloc.0 
				L_0697: ldloc.s V_29
				L_0699: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_069e: ldloca.s V_31
				L_06a0: ldloc.s V_23
				L_06a2: ldloca.s V_1
				L_06a4: call System.Drawing.Rectangle::Int32 get_Top()
				L_06a9: ldloc.s V_11
				L_06ab: ldloc.s V_23
				L_06ad: sub 
				L_06ae: ldloca.s V_1
				L_06b0: call System.Drawing.Rectangle::Int32 get_Height()
				L_06b5: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_06ba: newobj System.Drawing.StringFormat::Void .ctor()
				L_06bf: stloc.s V_32
				L_06c1: ldloc.s V_32
				L_06c3: ldc.i4 20480
				L_06c8: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_06cd: ldarg.0 
				L_06ce: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_06d3: brfalse.s L_06f4
				L_06d5: ldarg.0 
				L_06d6: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_06db: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_06e0: ldc.i4.1 
				L_06e1: and 
				L_06e2: ldc.i4.1 
				L_06e3: bne.un.s L_06f4
				L_06e5: ldloc.s V_32
				L_06e7: dup 
				L_06e8: callvirt System.Drawing.StringFormat::System.Drawing.StringFormatFlags get_FormatFlags()
				L_06ed: ldc.i4.1 
				L_06ee: or 
				L_06ef: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_06f4: ldarg.0 
				L_06f5: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.RightToLeft x94975a4c4f1d71c4
				L_06fa: ldc.i4.1 
				L_06fb: and 
				L_06fc: ldc.i4.1 
				L_06fd: bne.un.s L_070e
				L_06ff: ldloc.s V_32
				L_0701: dup 
				L_0702: callvirt System.Drawing.StringFormat::System.Drawing.StringFormatFlags get_FormatFlags()
				L_0707: ldc.i4.1 
				L_0708: or 
				L_0709: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_070e: ldloc.s V_32
				L_0710: ldc.i4.0 
				L_0711: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_0716: ldloc.s V_32
				L_0718: ldc.i4.1 
				L_0719: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_071e: ldloc.s V_32
				L_0720: ldc.i4.1 
				L_0721: callvirt System.Drawing.StringFormat::Void set_HotkeyPrefix(System.Drawing.Text.HotkeyPrefix)
				L_0726: ldarg.3 
				L_0727: brfalse.s L_0747
				L_0729: ldarg.0 
				L_072a: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_072f: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0734: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0739: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_SELECTEDMENUFONTCOLOR
				L_073e: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0743: stloc.s V_33
				L_0745: br.s L_0779
				L_0747: ldloc.2 
				L_0748: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Enabled()
				L_074d: brfalse.s L_076d
				L_074f: ldarg.0 
				L_0750: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0755: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_075a: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_075f: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUITEMFONTCOLOR
				L_0764: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0769: stloc.s V_33
				L_076b: br.s L_0779
				L_076d: call System.Drawing.SystemColors::System.Drawing.Color get_GrayText()
				L_0772: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0777: stloc.s V_33
				L_0779: ldloc.s V_31
				L_077b: stloc.s V_34
				L_077d: ldloca.s V_34
				L_077f: ldc.i4.1 
				L_0780: ldc.i4.1 
				L_0781: call System.Drawing.Rectangle::Void Offset(Int32, Int32)
				L_0786: ldarg.1 
				L_0787: ldloc.2 
				L_0788: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_078d: ldarg.0 
				L_078e: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Font xb86af11733e6a799
				L_0793: ldloc.s V_33
				L_0795: ldloc.s V_31
				L_0797: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_079c: ldloc.s V_32
				L_079e: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_07a3: ldloc.2 
				L_07a4: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Shortcut get_Shortcut()
				L_07a9: brfalse.s L_0803
				L_07ab: ldloc.s V_32
				L_07ad: ldc.i4.2 
				L_07ae: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_07b3: ldloc.2 
				L_07b4: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Enabled()
				L_07b9: brfalse.s L_07e0
				L_07bb: ldarg.1 
				L_07bc: ldarg.0 
				L_07bd: ldloc.2 
				L_07be: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Shortcut get_Shortcut()
				L_07c3: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.String x8cf43133d25d686a(System.Windows.Forms.Shortcut)
				L_07c8: ldarg.0 
				L_07c9: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Font xb86af11733e6a799
				L_07ce: ldloc.s V_33
				L_07d0: ldloc.s V_31
				L_07d2: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_07d7: ldloc.s V_32
				L_07d9: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_07de: br.s L_0803
				L_07e0: ldarg.1 
				L_07e1: ldarg.0 
				L_07e2: ldloc.2 
				L_07e3: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Shortcut get_Shortcut()
				L_07e8: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.String x8cf43133d25d686a(System.Windows.Forms.Shortcut)
				L_07ed: ldarg.0 
				L_07ee: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Font xb86af11733e6a799
				L_07f3: ldloc.s V_33
				L_07f5: ldloc.s V_31
				L_07f7: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_07fc: ldloc.s V_32
				L_07fe: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_0803: ldloca.s V_1
				L_0805: call System.Drawing.Rectangle::Int32 get_Top()
				L_080a: ldloca.s V_1
				L_080c: call System.Drawing.Rectangle::Int32 get_Height()
				L_0811: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xd2611dcb50ae5373
				L_0816: sub 
				L_0817: ldc.i4.2 
				L_0818: div 
				L_0819: add 
				L_081a: stloc.s V_35
				L_081c: ldnull 
				L_081d: stloc.s V_36
				L_081f: ldloc.2 
				L_0820: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Checked()
				L_0825: brfalse L_08f5
				L_082a: ldloc.2 
				L_082b: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Enabled()
				L_0830: brfalse.s L_085f
				L_0832: ldloc.3 
				L_0833: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0838: stloc.s V_37
				L_083a: ldc.i4.s 20
				L_083c: ldarg.0 
				L_083d: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0842: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0847: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_084c: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_SELECTEDMENUBORDERCOLOR
				L_0851: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, System.Drawing.Color)
				L_0856: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_085b: stloc.s V_38
				L_085d: br.s L_087e
				L_085f: call System.Drawing.SystemColors::System.Drawing.Color get_GrayText()
				L_0864: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0869: stloc.s V_37
				L_086b: ldc.i4.s 20
				L_086d: call System.Drawing.SystemColors::System.Drawing.Color get_GrayText()
				L_0872: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, System.Drawing.Color)
				L_0877: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_087c: stloc.s V_38
				L_087e: ldloca.s V_39
				L_0880: ldloc.s V_8
				L_0882: ldc.i4.1 
				L_0883: sub 
				L_0884: ldloc.s V_35
				L_0886: ldc.i4.1 
				L_0887: sub 
				L_0888: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xd2611dcb50ae5373
				L_088d: ldc.i4.2 
				L_088e: add 
				L_088f: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb28e4e0b2e9dba92
				L_0894: ldc.i4.2 
				L_0895: add 
				L_0896: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_089b: ldarg.1 
				L_089c: ldloc.s V_38
				L_089e: ldloc.s V_39
				L_08a0: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_08a5: ldarg.1 
				L_08a6: ldloc.s V_37
				L_08a8: ldloc.s V_39
				L_08aa: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_08af: ldloc.s V_37
				L_08b1: callvirt System.Drawing.Pen::Void Dispose()
				L_08b6: ldloc.s V_38
				L_08b8: callvirt System.Drawing.Brush::Void Dispose()
				L_08bd: ldloc.2 
				L_08be: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_RadioCheck()
				L_08c3: brfalse.s L_08dc
				L_08c5: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.ImageList xfeae2ed797ae6fbc
				L_08ca: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_08cf: ldc.i4.1 
				L_08d0: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_08d5: stloc.s V_36
				L_08d7: br L_0947
				L_08dc: ldarg.0 
				L_08dd: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_08e2: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_08e7: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_08ec: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_CHECKEDMENUICON()
				L_08f1: stloc.s V_36
				L_08f3: br.s L_0947
				L_08f5: ldloc.2 
				L_08f6: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Drawing.Image get_Image()
				L_08fb: brfalse.s L_0907
				L_08fd: ldloc.2 
				L_08fe: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Drawing.Image get_Image()
				L_0903: stloc.s V_36
				L_0905: br.s L_0930
				L_0907: ldloc.2 
				L_0908: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.ImageList get_ImageList()
				L_090d: brfalse.s L_0930
				L_090f: ldloc.2 
				L_0910: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Int32 get_ImageIndex()
				L_0915: ldc.i4.0 
				L_0916: blt.s L_0930
				L_0918: ldloc.2 
				L_0919: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.ImageList get_ImageList()
				L_091e: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_0923: ldloc.2 
				L_0924: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Int32 get_ImageIndex()
				L_0929: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_092e: stloc.s V_36
				L_0930: leave.s L_0947
				L_0932: pop 
				L_0933: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.ImageList xfeae2ed797ae6fbc
				L_0938: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_093d: ldc.i4.7 
				L_093e: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_0943: stloc.s V_36
				L_0945: leave.s L_0947
				L_0947: ldloc.s V_36
				L_0949: brfalse L_0af3
				L_094e: ldloc.2 
				L_094f: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Enabled()
				L_0954: brfalse L_0ae2
				L_0959: ldarg.3 
				L_095a: brfalse L_0a0b
				L_095f: ldloc.2 
				L_0960: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Checked()
				L_0965: brtrue L_0a0b
				L_096a: ldloc.s V_36
				L_096c: castclass System.Drawing.Bitmap
				L_0971: newobj System.Drawing.Bitmap::Void .ctor(System.Drawing.Image)
				L_0976: stloc.s V_40
				L_0978: ldc.i4 154
				L_097d: ldc.i4 156
				L_0982: ldc.i4 146
				L_0987: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32)
				L_098c: stloc.s V_41
				L_098e: ldc.i4.0 
				L_098f: ldc.i4.0 
				L_0990: ldc.i4.0 
				L_0991: ldc.i4.0 
				L_0992: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_0997: stloc.s V_42
				L_0999: ldc.i4.0 
				L_099a: stloc.s V_43
				L_099c: br.s L_09db
				L_099e: ldc.i4.0 
				L_099f: stloc.s V_44
				L_09a1: br.s L_09ca
				L_09a3: ldloc.s V_40
				L_09a5: ldloc.s V_43
				L_09a7: ldloc.s V_44
				L_09a9: callvirt System.Drawing.Bitmap::System.Drawing.Color GetPixel(Int32, Int32)
				L_09ae: ldloc.s V_42
				L_09b0: call System.Drawing.Color::Boolean op_Inequality(System.Drawing.Color, System.Drawing.Color)
				L_09b5: brfalse.s L_09c4
				L_09b7: ldloc.s V_40
				L_09b9: ldloc.s V_43
				L_09bb: ldloc.s V_44
				L_09bd: ldloc.s V_41
				L_09bf: callvirt System.Drawing.Bitmap::Void SetPixel(Int32, Int32, System.Drawing.Color)
				L_09c4: ldloc.s V_44
				L_09c6: ldc.i4.1 
				L_09c7: add 
				L_09c8: stloc.s V_44
				L_09ca: ldloc.s V_44
				L_09cc: ldloc.s V_36
				L_09ce: callvirt System.Drawing.Image::Int32 get_Height()
				L_09d3: blt.s L_09a3
				L_09d5: ldloc.s V_43
				L_09d7: ldc.i4.1 
				L_09d8: add 
				L_09d9: stloc.s V_43
				L_09db: ldloc.s V_43
				L_09dd: ldloc.s V_36
				L_09df: callvirt System.Drawing.Image::Int32 get_Width()
				L_09e4: blt.s L_099e
				L_09e6: ldarg.1 
				L_09e7: ldloc.s V_40
				L_09e9: ldloc.s V_8
				L_09eb: ldc.i4.1 
				L_09ec: add 
				L_09ed: ldloc.s V_35
				L_09ef: ldc.i4.1 
				L_09f0: add 
				L_09f1: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, Int32, Int32)
				L_09f6: ldarg.1 
				L_09f7: ldloc.s V_36
				L_09f9: ldloc.s V_8
				L_09fb: ldc.i4.1 
				L_09fc: sub 
				L_09fd: ldloc.s V_35
				L_09ff: ldc.i4.1 
				L_0a00: sub 
				L_0a01: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, Int32, Int32)
				L_0a06: br L_0af3
				L_0a0b: ldloc.s V_36
				L_0a0d: newobj System.Drawing.Bitmap::Void .ctor(System.Drawing.Image)
				L_0a12: stloc.s V_45
				L_0a14: ldc.i4.0 
				L_0a15: ldc.i4.0 
				L_0a16: ldc.i4.0 
				L_0a17: ldc.i4.0 
				L_0a18: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_0a1d: stloc.s V_46
				L_0a1f: ldc.i4.0 
				L_0a20: stloc.s V_47
				L_0a22: br L_0ac6
				L_0a27: ldc.i4.0 
				L_0a28: stloc.s V_48
				L_0a2a: br L_0ab2
				L_0a2f: ldloc.s V_45
				L_0a31: ldloc.s V_47
				L_0a33: ldloc.s V_48
				L_0a35: callvirt System.Drawing.Bitmap::System.Drawing.Color GetPixel(Int32, Int32)
				L_0a3a: stloc.s V_49
				L_0a3c: ldloc.s V_49
				L_0a3e: ldloc.s V_46
				L_0a40: call System.Drawing.Color::Boolean op_Inequality(System.Drawing.Color, System.Drawing.Color)
				L_0a45: brfalse.s L_0aac
				L_0a47: ldloca.s V_49
				L_0a49: call System.Drawing.Color::Byte get_R()
				L_0a4e: ldc.i4.s 76
				L_0a50: add 
				L_0a51: ldloca.s V_49
				L_0a53: call System.Drawing.Color::Byte get_R()
				L_0a58: ldc.i4.s 32
				L_0a5a: add 
				L_0a5b: ldc.i4.s 64
				L_0a5d: div 
				L_0a5e: ldc.i4.s 19
				L_0a60: mul 
				L_0a61: sub 
				L_0a62: ldloca.s V_49
				L_0a64: call System.Drawing.Color::Byte get_G()
				L_0a69: ldc.i4.s 76
				L_0a6b: add 
				L_0a6c: ldloca.s V_49
				L_0a6e: call System.Drawing.Color::Byte get_G()
				L_0a73: ldc.i4.s 32
				L_0a75: add 
				L_0a76: ldc.i4.s 64
				L_0a78: div 
				L_0a79: ldc.i4.s 19
				L_0a7b: mul 
				L_0a7c: sub 
				L_0a7d: ldloca.s V_49
				L_0a7f: call System.Drawing.Color::Byte get_B()
				L_0a84: ldc.i4.s 76
				L_0a86: add 
				L_0a87: ldloca.s V_49
				L_0a89: call System.Drawing.Color::Byte get_B()
				L_0a8e: ldc.i4.s 32
				L_0a90: add 
				L_0a91: ldc.i4.s 64
				L_0a93: div 
				L_0a94: ldc.i4.s 19
				L_0a96: mul 
				L_0a97: sub 
				L_0a98: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32)
				L_0a9d: stloc.s V_50
				L_0a9f: ldloc.s V_45
				L_0aa1: ldloc.s V_47
				L_0aa3: ldloc.s V_48
				L_0aa5: ldloc.s V_50
				L_0aa7: callvirt System.Drawing.Bitmap::Void SetPixel(Int32, Int32, System.Drawing.Color)
				L_0aac: ldloc.s V_48
				L_0aae: ldc.i4.1 
				L_0aaf: add 
				L_0ab0: stloc.s V_48
				L_0ab2: ldloc.s V_48
				L_0ab4: ldloc.s V_36
				L_0ab6: callvirt System.Drawing.Image::Int32 get_Height()
				L_0abb: blt L_0a2f
				L_0ac0: ldloc.s V_47
				L_0ac2: ldc.i4.1 
				L_0ac3: add 
				L_0ac4: stloc.s V_47
				L_0ac6: ldloc.s V_47
				L_0ac8: ldloc.s V_36
				L_0aca: callvirt System.Drawing.Image::Int32 get_Width()
				L_0acf: blt L_0a27
				L_0ad4: ldarg.1 
				L_0ad5: ldloc.s V_45
				L_0ad7: ldloc.s V_8
				L_0ad9: ldloc.s V_35
				L_0adb: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, Int32, Int32)
				L_0ae0: br.s L_0af3
				L_0ae2: ldarg.1 
				L_0ae3: ldloc.s V_36
				L_0ae5: ldloc.s V_8
				L_0ae7: ldloc.s V_35
				L_0ae9: call System.Drawing.SystemColors::System.Drawing.Color get_HighlightText()
				L_0aee: call System.Windows.Forms.ControlPaint::Void DrawImageDisabled(System.Drawing.Graphics, System.Drawing.Image, Int32, Int32, System.Drawing.Color)
				L_0af3: ldarg.2 
				L_0af4: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x649e2ad374251b5f()
				L_0af9: brfalse.s L_0b51
				L_0afb: ldloc.2 
				L_0afc: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Enabled()
				L_0b01: brfalse.s L_0b22
				L_0b03: ldc.i4.2 
				L_0b04: stloc.s V_51
				L_0b06: ldarg.1 
				L_0b07: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.ImageList xfeae2ed797ae6fbc
				L_0b0c: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_0b11: ldloc.s V_51
				L_0b13: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_0b18: ldloc.s V_10
				L_0b1a: ldloc.s V_35
				L_0b1c: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, Int32, Int32)
				L_0b21: ret 
				L_0b22: ldarg.1 
				L_0b23: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.ImageList xfeae2ed797ae6fbc
				L_0b28: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_0b2d: ldc.i4.2 
				L_0b2e: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_0b33: ldloc.s V_10
				L_0b35: ldloc.s V_35
				L_0b37: ldarg.0 
				L_0b38: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0b3d: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0b42: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0b47: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_SELECTEDMENUFONTCOLOR
				L_0b4c: call System.Windows.Forms.ControlPaint::Void DrawImageDisabled(System.Drawing.Graphics, System.Drawing.Image, Int32, Int32, System.Drawing.Color)
				L_0b51: ret 
			*/
			
			
			{
				Brush brush1;
				Rectangle rectangle1;
				x5f4b657f68f87baa x5f4b657f68f87baa1;
				Color color1;
				Color color2;
				int i1;
				int i2;
				int i3;
				int i4;
				int i5;
				int i6;
				int i7;
				Rectangle rectangle2;
				int i8;
				int i9;
				Rectangle rectangle3;
				Rectangle rectangle4;
				int i10;
				Rectangle rectangle5;
				Rectangle rectangle6;
				Rectangle rectangle7;
				StringFormat stringFormat1;
				SolidBrush solidBrush5;
				int i11;
				Image image1;
				Pen pen5;
				Brush brush3;
				Rectangle rectangle9;
				Bitmap bitmap1;
				Color color3;
				Color color4;
				int i12;
				int i13;
				Bitmap bitmap2;
				Color color5;
				int i14;
				int i15;
				Color color6;
				Color color7;
				int i16;
				rectangle1 = xd2a8bb4342ab4ef6.xee63d905da8ff550;
				x5f4b657f68f87baa1 = xd2a8bb4342ab4ef6.x5f4b657f68f87baa;
				Color color8 = ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_SELECTEDMENUCOLOR;
				color1 = ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_SELECTEDMENUBORDERCOLOR;
				color2 = ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_SELECTEDMENUCOLOR;
				i1 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 8];
				i2 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 5];
				i3 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 7];
				i4 = (rectangle1.Left + i2);
				i5 = ((i2 + x902c4aee45bfd906.xb28e4e0b2e9dba92) + i3);
				int i17 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 10];
				int i18 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 11];
				int i19 = x902c4aee45bfd906._x13d4cb8d1bd20347[0, 12];
				i6 = ((rectangle1.Right - x902c4aee45bfd906._x13d4cb8d1bd20347[0, 12]) - x902c4aee45bfd906._x13d4cb8d1bd20347[0, 11]);
				i7 = ((i6 - x902c4aee45bfd906._x13d4cb8d1bd20347[0, 10]) - x902c4aee45bfd906._x13d4cb8d1bd20347[0, 9]);
				if (! xd2a8bb4342ab4ef6.xc1facdb08ad4967a)
				{
					if (! xd2a8bb4342ab4ef6.x43604484a3deae4f)
					{
						i10 = ((rectangle1.Left + i5) + i1);
						if (x15a0329046fb799f)
						{
							rectangle5 = new Rectangle (((int) (rectangle1.Left + 1)), rectangle1.Top, ((int) (rectangle1.Width - 3)), ((int) (rectangle1.Height - 1)));
							using (Pen pen4 = new Pen (color1))
							{
								using (SolidBrush solidBrush3 = new SolidBrush (Color.White))
								{
									x4b101060f4767186.FillRectangle (((Brush) solidBrush3), rectangle5);
								}
								using (SolidBrush solidBrush4 = new SolidBrush (color2))
								{
									x4b101060f4767186.FillRectangle (((Brush) solidBrush4), rectangle5);
									x4b101060f4767186.DrawRectangle (pen4, rectangle5);
								}
								goto L_069E;
							}
						}
						brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_MENUITEMCOLOR;
						x4b101060f4767186.FillRectangle (brush1, new Rectangle (((int) (rectangle1.Left + 1)), rectangle1.Top, ((int) (rectangle1.Width - 1)), rectangle1.Height));
						if (xd2a8bb4342ab4ef6.x062575979028fd71 && this.x604ddcdfda178b5a)
						{
							x4b101060f4767186.FillRectangle (Brushes.White, new Rectangle (i10, rectangle1.Top, ((int) ((rectangle1.Right - i10) - i1)), rectangle1.Height));
							using (Brush brush2 = ((Brush) new SolidBrush (x448fd9ab43628c71.x898c3842f8dd56e5 (((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUITEMCOLOR, Color.White, 150))))
							{
								x4b101060f4767186.FillRectangle (brush2, new Rectangle (i10, rectangle1.Top, ((int) ((rectangle1.Right - i10) - i1)), rectangle1.Height));
							}
						}
						rectangle6 = new Rectangle (rectangle1.Left, rectangle1.Top, i5, rectangle1.Height);
						x4b101060f4767186.FillRectangle (Brushes.White, rectangle6);
						if (((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_LEFTBARSTARTCOLOR != ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_LEFTBARENDCOLOR)
						{
							using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush (rectangle6, ((SkinColors) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Colors).SKIN2_LEFTBARSTARTCOLOR, ((SkinColors) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Colors).SKIN2_LEFTBARENDCOLOR, LinearGradientMode.Horizontal))
							{
								x4b101060f4767186.FillRectangle (((Brush) linearGradientBrush2), rectangle6);
								goto L_069E;
							}
						}
						brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_LEFTBARSTARTCOLOR;
						x4b101060f4767186.FillRectangle (brush1, rectangle6);
						goto L_069E;
					}
					else
					{
						if (xd2a8bb4342ab4ef6.xc8dbe008de6aee9e)
						{
							using (Pen pen2 = new Pen (ControlPaint.Dark (((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUITEMCOLOR)))
							{
								x4b101060f4767186.DrawLine (pen2, rectangle1.Left, rectangle1.Top, rectangle1.Left, rectangle1.Bottom);
								return;
							}
						}
						rectangle4 = new Rectangle (rectangle1.Left, rectangle1.Top, i5, rectangle1.Height);
						x4b101060f4767186.FillRectangle (Brushes.White, rectangle4);
						if (((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_LEFTBARSTARTCOLOR != ((SkinColors) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Colors).SKIN2_LEFTBARENDCOLOR)
						{
							using (LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush (rectangle4, ((SkinColors) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Colors).SKIN2_LEFTBARSTARTCOLOR, ((SkinColors) ((Res) ((SkinEngine) this.xcab6a0e662ada486).Res).Colors).SKIN2_LEFTBARENDCOLOR, LinearGradientMode.Horizontal))
							{
								x4b101060f4767186.FillRectangle (((Brush) linearGradientBrush1), rectangle4);
								goto L_03E7;
							}
						}
						brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_LEFTBARSTARTCOLOR;
						x4b101060f4767186.FillRectangle (brush1, rectangle4);
						goto L_03E7;
					}
				}
				rectangle2 = rectangle1;
				rectangle2.X += i5;
				rectangle2.Width -= i5;
				i8 = (rectangle2.Left + ((rectangle2.Width - x902c4aee45bfd906.xd2611dcb50ae5373) / 2));
				i9 = (rectangle2.Top + ((rectangle2.Height - x902c4aee45bfd906.xd2611dcb50ae5373) / 2));
				if (x15a0329046fb799f)
				{
					rectangle3 = new Rectangle (((int) (rectangle1.Left + 1)), rectangle1.Top, ((int) (rectangle1.Width - 3)), ((int) (rectangle1.Height - 1)));
					using (Pen pen1 = new Pen (color1))
					{
						using (SolidBrush solidBrush1 = new SolidBrush (Color.White))
						{
							x4b101060f4767186.FillRectangle (((Brush) solidBrush1), rectangle3);
						}
						using (SolidBrush solidBrush2 = new SolidBrush (color2))
						{
							x4b101060f4767186.FillRectangle (((Brush) solidBrush2), rectangle3);
							x4b101060f4767186.DrawRectangle (pen1, rectangle3);
						}
						goto L_029C;
					}
				}
				brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_MENUITEMCOLOR;
				x4b101060f4767186.FillRectangle (brush1, new Rectangle (((int) (rectangle1.Left + 1)), rectangle1.Top, ((int) (rectangle1.Width - 1)), rectangle1.Height));
				x4b101060f4767186.FillRectangle (Brushes.White, new Rectangle (rectangle1.Left, rectangle1.Top, i5, rectangle1.Height));
				brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_LEFTBARSTARTCOLOR;
				x4b101060f4767186.FillRectangle (brush1, new Rectangle (rectangle1.Left, rectangle1.Top, i5, rectangle1.Height));
				
			L_029C:
				
				{
				}
				x4b101060f4767186.DrawImage (x902c4aee45bfd906.xfeae2ed797ae6fbc.Images[6], i8, i9);
				return;
				
			L_03E7:
				
				{
				}
				using (Pen pen3 = new Pen (Color.FromArgb (75, ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUITEMFONTCOLOR)))
				{
					x4b101060f4767186.DrawLine (pen3, ((int) ((rectangle1.Left + i5) + i1)), ((int) (rectangle1.Top + 2)), rectangle1.Right, ((int) (rectangle1.Top + 2)));
					return;
				}
				
			L_069E:
				
				{
				}
				rectangle7 = new Rectangle (i10, rectangle1.Top, ((int) (i7 - i10)), rectangle1.Height);
				stringFormat1 = new StringFormat ();
				stringFormat1.FormatFlags = (StringFormatFlags.NoWrap | StringFormatFlags.NoClip);
				if ((this.x37f2fc2a7f30f790 != null) && ((this.x37f2fc2a7f30f790.RightToLeft & RightToLeft.Yes) == RightToLeft.Yes))
				{
					stringFormat1.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
				}
				if ((this.x94975a4c4f1d71c4 & RightToLeft.Yes) == RightToLeft.Yes)
				{
					stringFormat1.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
				}
				stringFormat1.Alignment = StringAlignment.Near;
				stringFormat1.LineAlignment = StringAlignment.Center;
				stringFormat1.HotkeyPrefix = HotkeyPrefix.Show;
				if (x15a0329046fb799f)
				{
					solidBrush5 = new SolidBrush (((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_SELECTEDMENUFONTCOLOR);
				}
				else if (x5f4b657f68f87baa1.Enabled)
				{
					solidBrush5 = new SolidBrush (((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUITEMFONTCOLOR);
				}
				else
				{
					solidBrush5 = new SolidBrush (SystemColors.GrayText);
				}
				rectangle7.Offset (1, 1);
				x4b101060f4767186.DrawString (x5f4b657f68f87baa1.Text, this.xb86af11733e6a799, ((Brush) solidBrush5), ((RectangleF) rectangle7), stringFormat1);
				if (x5f4b657f68f87baa1.Shortcut != Shortcut.None)
				{
					stringFormat1.Alignment = StringAlignment.Far;
					if (! x5f4b657f68f87baa1.Enabled)
					{
						x4b101060f4767186.DrawString (this.x8cf43133d25d686a (x5f4b657f68f87baa1.Shortcut), this.xb86af11733e6a799, ((Brush) solidBrush5), ((RectangleF) rectangle7), stringFormat1);
					}
					else
					{
						x4b101060f4767186.DrawString (this.x8cf43133d25d686a (x5f4b657f68f87baa1.Shortcut), this.xb86af11733e6a799, ((Brush) solidBrush5), ((RectangleF) rectangle7), stringFormat1);
					}
				}
				i11 = (rectangle1.Top + ((rectangle1.Height - x902c4aee45bfd906.xd2611dcb50ae5373) / 2));
				image1 = ((Image) null);
				if (! x5f4b657f68f87baa1.Checked)
				{
					try
					{
						if (x5f4b657f68f87baa1.Image != null)
						{
							image1 = x5f4b657f68f87baa1.Image;
						}
						else if ((x5f4b657f68f87baa1.ImageList != null) && (x5f4b657f68f87baa1.ImageIndex >= 0))
						{
							image1 = x5f4b657f68f87baa1.ImageList.Images[x5f4b657f68f87baa1.ImageIndex];
						}
					}
					catch (Exception)
					{
						image1 = x902c4aee45bfd906.xfeae2ed797ae6fbc.Images[7];
					}
				}
				else
				{
					if (x5f4b657f68f87baa1.Enabled)
					{
						pen5 = new Pen (color1);
						brush3 = ((Brush) new SolidBrush (Color.FromArgb (20, ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_SELECTEDMENUBORDERCOLOR)));
					}
					else
					{
						pen5 = new Pen (SystemColors.GrayText);
						brush3 = ((Brush) new SolidBrush (Color.FromArgb (20, SystemColors.GrayText)));
					}
					rectangle9 = new Rectangle (((int) (i4 - 1)), ((int) (i11 - 1)), ((int) (x902c4aee45bfd906.xd2611dcb50ae5373 + 2)), ((int) (x902c4aee45bfd906.xb28e4e0b2e9dba92 + 2)));
					x4b101060f4767186.FillRectangle (brush3, rectangle9);
					x4b101060f4767186.DrawRectangle (pen5, rectangle9);
					pen5.Dispose ();
					brush3.Dispose ();
					if (x5f4b657f68f87baa1.RadioCheck)
					{
						image1 = x902c4aee45bfd906.xfeae2ed797ae6fbc.Images[1];
					}
					else
					{
						image1 = ((Image) ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_CHECKEDMENUICON);
					}
				}
				if (image1 != null)
				{
					if (! x5f4b657f68f87baa1.Enabled)
					{
						ControlPaint.DrawImageDisabled (x4b101060f4767186, image1, i4, i11, SystemColors.HighlightText);
					}
					else if ((! x15a0329046fb799f) || x5f4b657f68f87baa1.Checked)
					{
						bitmap2 = new Bitmap (image1);
						color5 = Color.FromArgb (0, 0, 0, 0);
						for (i14 = 0; (i14 < image1.Width); i14++)
						{
							for (i15 = 0; (i15 < image1.Height); i15++)
							{
								color6 = bitmap2.GetPixel (i14, i15);
								if (color6 != color5)
								{
									color7 = Color.FromArgb (((int) ((color6.R + 76) - (((color6.R + 32) / 64) * 19))), ((int) ((color6.G + 76) - (((color6.G + 32) / 64) * 19))), ((int) ((color6.B + 76) - (((color6.B + 32) / 64) * 19))));
									bitmap2.SetPixel (i14, i15, color7);
								}
							}
						}
						x4b101060f4767186.DrawImage (((Image) bitmap2), i4, i11);
					}
					else
					{
						bitmap1 = new Bitmap (image1);
						color3 = Color.FromArgb (154, 156, 146);
						color4 = Color.FromArgb (0, 0, 0, 0);
						for (i12 = 0; (i12 < image1.Width); i12++)
						{
							for (i13 = 0; (i13 < image1.Height); i13++)
							{
								if (bitmap1.GetPixel (i12, i13) != color4)
								{
									bitmap1.SetPixel (i12, i13, color3);
								}
							}
						}
						x4b101060f4767186.DrawImage (((Image) bitmap1), ((int) (i4 + 1)), ((int) (i11 + 1)));
						x4b101060f4767186.DrawImage (image1, ((int) (i4 - 1)), ((int) (i11 - 1)));
					}
				}
				if (xd2a8bb4342ab4ef6.x649e2ad374251b5f)
				{
					if (x5f4b657f68f87baa1.Enabled)
					{
						i16 = 2;
						x4b101060f4767186.DrawImage (x902c4aee45bfd906.xfeae2ed797ae6fbc.Images[i16], i6, i11);
					}
					else
					{
						ControlPaint.DrawImageDisabled (x4b101060f4767186, x902c4aee45bfd906.xfeae2ed797ae6fbc.Images[2], i6, i11, ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_SELECTEDMENUFONTCOLOR);
					}
				}
			}
			
			protected void xb97e8a8020dddaac ()
			
			/*
				// Code Size: 71 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_0006: brfalse.s L_0021
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_000e: callvirt System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0013: ldarg.0 
				L_0014: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::UInt32 x325954b88ff83482
				L_0019: ldc.i4.0 
				L_001a: ldc.i4.0 
				L_001b: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_0020: pop 
				L_0021: ldarg.0 
				L_0022: ldnull 
				L_0023: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_0028: ldarg.0 
				L_0029: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_002e: callvirt System.Windows.Forms.Timer::Void Stop()
				L_0033: ldarg.0 
				L_0034: ldc.i4.1 
				L_0035: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_003a: ldarg.0 
				L_003b: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x4139e66e6dfaac52()
				L_0040: ldarg.0 
				L_0041: callvirt System.Windows.Forms.NativeWindow::Void DestroyHandle()
				L_0046: ret 
			*/
			
			
			{
				if (this.x5142fa1a3d9591c8 != null)
				{
					bool b1 = x61467fe65a98f20c.PostMessage (this.x5142fa1a3d9591c8.Handle, this.x325954b88ff83482, uint.MinValue, uint.MinValue);
				}
				this.x4547ebd0fd2a7079 = ((x5f4b657f68f87baa) null);
				this.x420067493d7ebb36.Stop ();
				this.x9a75ed38d1972c87 = true;
				this.x4139e66e6dfaac52 ();
				this.DestroyHandle ();
			}
			
			protected void xbcf8eb07b7e76a62 (ref Message x6088325dec1baa2a)
			
			/*
				// Code Size: 490 Bytes
				.maxstack 13
				.locals (System.Int32 V_0, 
         System.Boolean V_1, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_2, 
         Sunisoft.IrisSkin.x555516122dcc901e+POINT V_3, 
         Sunisoft.IrisSkin.x555516122dcc901e+POINT V_4, 
         System.Int32 V_5, 
         System.Drawing.Rectangle V_6)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_0006: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_000b: stloc.0 
				L_000c: ldarg.1 
				L_000d: call System.Windows.Forms.Message::IntPtr get_LParam()
				L_0012: ldsfld System.IntPtr::IntPtr Zero
				L_0017: call System.IntPtr::Boolean op_Inequality(IntPtr, IntPtr)
				L_001c: stloc.1 
				L_001d: ldarg.0 
				L_001e: ldloc.0 
				L_001f: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xf624f8e86c5ae5f1
				L_0024: ldarg.0 
				L_0025: ldarg.0 
				L_0026: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_002b: newobj Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void .ctor(Sunisoft.IrisSkin.SkinEngine)
				L_0030: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_0035: ldarg.0 
				L_0036: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_003b: ldloc.0 
				L_003c: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0041: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0046: stloc.2 
				L_0047: ldloca.s V_3
				L_0049: ldloc.2 
				L_004a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_004f: stloc.s V_6
				L_0051: ldloca.s V_6
				L_0053: call System.Drawing.Rectangle::Int32 get_Right()
				L_0058: stfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_005d: ldloca.s V_3
				L_005f: ldloc.2 
				L_0060: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_0065: stloc.s V_6
				L_0067: ldloca.s V_6
				L_0069: call System.Drawing.Rectangle::Int32 get_Top()
				L_006e: stfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_0073: ldarg.0 
				L_0074: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0079: ldloca.s V_3
				L_007b: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean ClientToScreen(IntPtr, POINT ByRef)
				L_0080: pop 
				L_0081: ldloca.s V_4
				L_0083: ldloc.2 
				L_0084: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_0089: stloc.s V_6
				L_008b: ldloca.s V_6
				L_008d: call System.Drawing.Rectangle::Int32 get_Left()
				L_0092: stfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0097: ldloca.s V_4
				L_0099: ldloc.2 
				L_009a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_009f: stloc.s V_6
				L_00a1: ldloca.s V_6
				L_00a3: call System.Drawing.Rectangle::Int32 get_Top()
				L_00a8: stfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_00ad: ldarg.0 
				L_00ae: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_00b3: ldloca.s V_4
				L_00b5: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean ClientToScreen(IntPtr, POINT ByRef)
				L_00ba: pop 
				L_00bb: ldarg.0 
				L_00bc: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_00c1: ldarg.0 
				L_00c2: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Font get_xc2d4efc42998d87b()
				L_00c7: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void set_xc2d4efc42998d87b(System.Drawing.Font)
				L_00cc: ldarg.0 
				L_00cd: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_00d2: ldarg.0 
				L_00d3: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced get_x6fd23f8bad2f3ced()
				L_00d8: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void set_x6fd23f8bad2f3ced(Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced)
				L_00dd: ldarg.0 
				L_00de: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_00e3: ldarg.0 
				L_00e4: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x1f5697535eab37b9 get_xa743c350e27e50b4()
				L_00e9: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void set_xa743c350e27e50b4(Sunisoft.IrisSkin.InternalControls.x1f5697535eab37b9)
				L_00ee: ldarg.0 
				L_00ef: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_00f4: ldarg.0 
				L_00f5: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 get_x742a8c15ee195ce2()
				L_00fa: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void set_x742a8c15ee195ce2(Int32)
				L_00ff: ldc.i4.0 
				L_0100: stloc.s V_5
				L_0102: ldarg.0 
				L_0103: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_0108: ldarg.0 
				L_0109: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc316f3c6d490f56e
				L_010e: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void set_x2f5f5a028825ce32(Boolean)
				L_0113: ldarg.0 
				L_0114: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_0119: ldloc.2 
				L_011a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_011f: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0124: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Boolean get_x6f72c846c7dcb042()
				L_0129: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x86c6e3905608c757
				L_012e: ldarg.0 
				L_012f: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_0134: ldarg.0 
				L_0135: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x604ddcdfda178b5a
				L_013a: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void set_x1f045c9de3a60a02(Boolean)
				L_013f: ldloc.2 
				L_0140: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0145: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnPopupStart()
				L_014a: ldarg.0 
				L_014b: ldarg.0 
				L_014c: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_0151: ldloca.s V_3
				L_0153: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0158: ldloca.s V_3
				L_015a: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_015f: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0164: ldloca.s V_4
				L_0166: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_016b: ldloca.s V_4
				L_016d: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_0172: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0177: ldloc.2 
				L_0178: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_017d: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0182: ldarg.0 
				L_0183: ldloc.1 
				L_0184: ldarg.0 
				L_0185: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_018a: ldarg.0 
				L_018b: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xc8609d9b3214b3e7
				L_0190: ldarg.0 
				L_0191: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x8e0eb9fe60b28fae
				L_0196: ldarg.0 
				L_0197: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x20ad2840ee62b6a4
				L_019c: ldloca.s V_5
				L_019e: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x6e4244e25732db7d(System.Drawing.Point, System.Drawing.Point, Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a, Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906, Boolean, Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01, Boolean, Boolean, Boolean, Int32 ByRef)
				L_01a3: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_01a8: ldloc.2 
				L_01a9: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_01ae: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnPopupEnd()
				L_01b3: ldc.i4.m1 
				L_01b4: stloc.0 
				L_01b5: ldarg.0 
				L_01b6: ldnull 
				L_01b7: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_01bc: ldarg.0 
				L_01bd: ldc.i4.0 
				L_01be: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x20ad2840ee62b6a4
				L_01c3: ldarg.0 
				L_01c4: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_01c9: brtrue.s L_01cf
				L_01cb: ldloc.s V_5
				L_01cd: brfalse.s L_01e9
				L_01cf: ldarg.0 
				L_01d0: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_01d5: callvirt System.Windows.Forms.Timer::Void Stop()
				L_01da: ldarg.0 
				L_01db: ldc.i4.1 
				L_01dc: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_01e1: ldarg.0 
				L_01e2: ldloc.s V_5
				L_01e4: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x0cd2bb383a46f073
				L_01e9: ret 
			*/
			
			
			{
				x555516122dcc901e.POINT pOINT1;
				x555516122dcc901e.POINT pOINT2;
				int i1 = ((int) x6088325dec1baa2a.WParam);
				bool b1 = (x6088325dec1baa2a.LParam != IntPtr.Zero);
				this.xf624f8e86c5ae5f1 = i1;
				this.x5142fa1a3d9591c8 = new x902c4aee45bfd906 (this.xdc87e2b99332cd4a);
				x2cc390e9409b0f3f x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[i1] as x2cc390e9409b0f3f);
				pOINT1.x = x2cc390e9409b0f3f1.xee63d905da8ff550.Right;
				pOINT1.y = x2cc390e9409b0f3f1.xee63d905da8ff550.Top;
				bool b2 = x61467fe65a98f20c.ClientToScreen (base.Handle, ref pOINT1);
				pOINT2.x = x2cc390e9409b0f3f1.xee63d905da8ff550.Left;
				pOINT2.y = x2cc390e9409b0f3f1.xee63d905da8ff550.Top;
				bool b3 = x61467fe65a98f20c.ClientToScreen (base.Handle, ref pOINT2);
				this.x5142fa1a3d9591c8.xc2d4efc42998d87b = this.xc2d4efc42998d87b;
				this.x5142fa1a3d9591c8.x6fd23f8bad2f3ced = this.x6fd23f8bad2f3ced;
				this.x5142fa1a3d9591c8.xa743c350e27e50b4 = this.xa743c350e27e50b4;
				this.x5142fa1a3d9591c8.x742a8c15ee195ce2 = this.x742a8c15ee195ce2;
				int i2 = 0;
				this.x5142fa1a3d9591c8.x2f5f5a028825ce32 = this.xc316f3c6d490f56e;
				this.x5142fa1a3d9591c8.x86c6e3905608c757 = x2cc390e9409b0f3f1.x5f4b657f68f87baa.MenuCommands.x6f72c846c7dcb042;
				this.x5142fa1a3d9591c8.x1f045c9de3a60a02 = this.x604ddcdfda178b5a;
				x2cc390e9409b0f3f1.x5f4b657f68f87baa.OnPopupStart ();
				this.x4547ebd0fd2a7079 = this.x5142fa1a3d9591c8.x6e4244e25732db7d (new Point (pOINT1.x, pOINT1.y), new Point (pOINT2.x, pOINT2.y), x2cc390e9409b0f3f1.x5f4b657f68f87baa.MenuCommands, this, b1, this.x37f2fc2a7f30f790, this.xc8609d9b3214b3e7, this.x8e0eb9fe60b28fae, this.x20ad2840ee62b6a4, ref i2);
				x2cc390e9409b0f3f1.x5f4b657f68f87baa.OnPopupEnd ();
				i1 = -1;
				this.x5142fa1a3d9591c8 = ((x902c4aee45bfd906) null);
				this.x20ad2840ee62b6a4 = false;
				if ((this.x4547ebd0fd2a7079 != null) || (i2 != 0))
				{
					this.x420067493d7ebb36.Stop ();
					this.x9a75ed38d1972c87 = true;
					this.x0cd2bb383a46f073 = i2;
				}
			}
			
			protected x902c4aee45bfd906 xcb534454d6825379 (x555516122dcc901e.POINT x0ce73f6cbd7d5515)
			
			/*
				// Code Size: 111 Bytes
				.maxstack 3
				.locals (Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT V_0)
				L_0000: ldloca.s V_0
				L_0002: initobj Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT
				L_0008: ldarg.0 
				L_0009: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_000e: ldloca.s V_0
				L_0010: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetWindowRect(IntPtr, RECT ByRef)
				L_0015: pop 
				L_0016: ldarga.s x0ce73f6cbd7d5515
				L_0018: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_001d: ldloca.s V_0
				L_001f: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0024: blt.s L_0058
				L_0026: ldarga.s x0ce73f6cbd7d5515
				L_0028: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_002d: ldloca.s V_0
				L_002f: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0034: bgt.s L_0058
				L_0036: ldarga.s x0ce73f6cbd7d5515
				L_0038: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_003d: ldloca.s V_0
				L_003f: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0044: blt.s L_0058
				L_0046: ldarga.s x0ce73f6cbd7d5515
				L_0048: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_004d: ldloca.s V_0
				L_004f: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0054: bgt.s L_0058
				L_0056: ldarg.0 
				L_0057: ret 
				L_0058: ldarg.0 
				L_0059: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_005e: brfalse.s L_006d
				L_0060: ldarg.0 
				L_0061: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0066: ldarg.1 
				L_0067: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xcb534454d6825379(POINT)
				L_006c: ret 
				L_006d: ldnull 
				L_006e: ret 
			*/
			
			
			{
				xae4dd1cafd2eb77c.RECT rECT1 = new xae4dd1cafd2eb77c.RECT ();
				bool b1 = x61467fe65a98f20c.GetWindowRect (base.Handle, ref rECT1);
				if ((((x0ce73f6cbd7d5515.x >= rECT1.left) && (x0ce73f6cbd7d5515.x <= rECT1.right)) && (x0ce73f6cbd7d5515.y >= rECT1.top)) && (x0ce73f6cbd7d5515.y <= rECT1.bottom))
				{
					return this;
				}
				else if (this.xb13f2de377f27597 == null)
				{
					return null;
				}
				else
				{
					return this.xb13f2de377f27597.xcb534454d6825379 (x0ce73f6cbd7d5515);
				}
			}
			
			protected void xcea282a46787878f (Graphics x4b101060f4767186, int xa447fc54e41dfe06, int xc941868c59399d3e, int x9b0739496f8b5475, int x4d5aabc7a55b12ba, xf398ffaf32ffe055 x9c9eac3a36336680)
			
			/*
				// Code Size: 322 Bytes
				.maxstack 7
				.locals (System.Drawing.Color V_0, 
         System.Drawing.Color V_1, 
         System.Drawing.Color V_2, 
         System.Drawing.Drawing2D.LinearGradientBrush V_3, 
         System.Drawing.Drawing2D.LinearGradientBrush V_4, 
         System.Drawing.SolidBrush V_5)
				.try L_005e to L_0083 finally L_0083 to L_008d
				.try L_009a to L_00b9 catch System.Object L_00b9 to L_00bc
				.try L_00e8 to L_00f8 finally L_00f8 to L_0104
				.try L_0125 to L_0135 finally L_0135 to L_0141
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xdb6050a2030517f4
				L_0006: brfalse L_0104
				L_000b: ldc.i4.s 64
				L_000d: ldc.i4.0 
				L_000e: ldc.i4.0 
				L_000f: ldc.i4.0 
				L_0010: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_0015: stloc.0 
				L_0016: ldc.i4.s 48
				L_0018: ldc.i4.0 
				L_0019: ldc.i4.0 
				L_001a: ldc.i4.0 
				L_001b: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_0020: stloc.1 
				L_0021: ldc.i4.0 
				L_0022: ldc.i4.0 
				L_0023: ldc.i4.0 
				L_0024: ldc.i4.0 
				L_0025: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_002a: stloc.2 
				L_002b: ldarg.s x9c9eac3a36336680
				L_002d: ldc.i4.1 
				L_002e: beq.s L_008d
				L_0030: ldarg.s x9b0739496f8b5475
				L_0032: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_0037: blt.s L_008d
				L_0039: ldarg.2 
				L_003a: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_003f: add 
				L_0040: ldarg.3 
				L_0041: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_0046: sub 
				L_0047: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_004c: ldarg.2 
				L_004d: ldarg.3 
				L_004e: ldarg.s x4d5aabc7a55b12ba
				L_0050: add 
				L_0051: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0056: ldloc.0 
				L_0057: ldloc.2 
				L_0058: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Point, System.Drawing.Point, System.Drawing.Color, System.Drawing.Color)
				L_005d: stloc.3 
				L_005e: ldarg.1 
				L_005f: ldloc.3 
				L_0060: ldarg.2 
				L_0061: ldarg.3 
				L_0062: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_0067: ldarg.s x4d5aabc7a55b12ba
				L_0069: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_006e: ldarg.2 
				L_006f: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_0074: add 
				L_0075: starg.s xa447fc54e41dfe06
				L_0077: ldarg.s x9b0739496f8b5475
				L_0079: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_007e: sub 
				L_007f: starg.s x9b0739496f8b5475
				L_0081: leave.s L_008d
				L_0083: ldloc.3 
				L_0084: brfalse.s L_008c
				L_0086: ldloc.3 
				L_0087: callvirt System.IDisposable::Void Dispose()
				L_008c: endfinally 
				L_008d: ldarg.s x9c9eac3a36336680
				L_008f: brfalse.s L_00c6
				L_0091: ldarg.s x9b0739496f8b5475
				L_0093: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_0098: blt.s L_00c6
				L_009a: ldarg.1 
				L_009b: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_00a0: ldarg.s x4d5aabc7a55b12ba
				L_00a2: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Bitmap x7ca9c34ba153ef81(Int32, Int32)
				L_00a7: ldarg.2 
				L_00a8: ldarg.s x9b0739496f8b5475
				L_00aa: add 
				L_00ab: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_00b0: sub 
				L_00b1: ldarg.3 
				L_00b2: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_00b7: leave.s L_00bc
				L_00b9: pop 
				L_00ba: leave.s L_00bc
				L_00bc: ldarg.s x9b0739496f8b5475
				L_00be: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_00c3: sub 
				L_00c4: starg.s x9b0739496f8b5475
				L_00c6: ldc.i4 9999
				L_00cb: ldarg.3 
				L_00cc: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_00d1: ldc.i4 9999
				L_00d6: ldarg.3 
				L_00d7: ldarg.s x4d5aabc7a55b12ba
				L_00d9: add 
				L_00da: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_00df: ldloc.1 
				L_00e0: ldloc.2 
				L_00e1: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Point, System.Drawing.Point, System.Drawing.Color, System.Drawing.Color)
				L_00e6: stloc.s V_4
				L_00e8: ldarg.1 
				L_00e9: ldloc.s V_4
				L_00eb: ldarg.2 
				L_00ec: ldarg.3 
				L_00ed: ldarg.s x9b0739496f8b5475
				L_00ef: ldarg.s x4d5aabc7a55b12ba
				L_00f1: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_00f6: leave.s L_0141
				L_00f8: ldloc.s V_4
				L_00fa: brfalse.s L_0103
				L_00fc: ldloc.s V_4
				L_00fe: callvirt System.IDisposable::Void Dispose()
				L_0103: endfinally 
				L_0104: ldarg.0 
				L_0105: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_010a: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_010f: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0114: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUITEMCOLOR
				L_0119: call System.Windows.Forms.ControlPaint::System.Drawing.Color Dark(System.Drawing.Color)
				L_011e: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0123: stloc.s V_5
				L_0125: ldarg.1 
				L_0126: ldloc.s V_5
				L_0128: ldarg.2 
				L_0129: ldarg.3 
				L_012a: ldarg.s x9b0739496f8b5475
				L_012c: ldarg.s x4d5aabc7a55b12ba
				L_012e: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_0133: leave.s L_0141
				L_0135: ldloc.s V_5
				L_0137: brfalse.s L_0140
				L_0139: ldloc.s V_5
				L_013b: callvirt System.IDisposable::Void Dispose()
				L_0140: endfinally 
				L_0141: ret 
			*/
			
			
			{
				Color color1;
				Color color2;
				Color color3;
				if (this.xdb6050a2030517f4)
				{
					color1 = Color.FromArgb (64, 0, 0, 0);
					color2 = Color.FromArgb (48, 0, 0, 0);
					color3 = Color.FromArgb (0, 0, 0, 0);
					if ((x9c9eac3a36336680 != xf398ffaf32ffe055.x419ba17a5322627b) && (x9b0739496f8b5475 >= x902c4aee45bfd906.x36404b43d7b678c8))
					{
						using (LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush (new Point (((int) (xa447fc54e41dfe06 + x902c4aee45bfd906.x36404b43d7b678c8)), ((int) (xc941868c59399d3e - x902c4aee45bfd906.x36404b43d7b678c8))), new Point (xa447fc54e41dfe06, ((int) (xc941868c59399d3e + x4d5aabc7a55b12ba))), color1, color3))
						{
							x4b101060f4767186.FillRectangle (((Brush) linearGradientBrush1), xa447fc54e41dfe06, xc941868c59399d3e, x902c4aee45bfd906.x36404b43d7b678c8, x4d5aabc7a55b12ba);
							xa447fc54e41dfe06 += x902c4aee45bfd906.x36404b43d7b678c8;
							x9b0739496f8b5475 -= x902c4aee45bfd906.x36404b43d7b678c8;
						}
					}
					if ((x9c9eac3a36336680 != xf398ffaf32ffe055.x72d92bd1aff02e37) && (x9b0739496f8b5475 >= x902c4aee45bfd906.x36404b43d7b678c8))
					{
						try
						{
							x4b101060f4767186.DrawImageUnscaled (((Image) x902c4aee45bfd906.x7ca9c34ba153ef81 (x902c4aee45bfd906.x36404b43d7b678c8, x4d5aabc7a55b12ba)), ((int) ((xa447fc54e41dfe06 + x9b0739496f8b5475) - x902c4aee45bfd906.x36404b43d7b678c8)), xc941868c59399d3e);
						}
						catch
						{
						}
						x9b0739496f8b5475 -= x902c4aee45bfd906.x36404b43d7b678c8;
					}
					using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush (new Point (9999, xc941868c59399d3e), new Point (9999, ((int) (xc941868c59399d3e + x4d5aabc7a55b12ba))), color2, color3))
					{
						x4b101060f4767186.FillRectangle (((Brush) linearGradientBrush2), xa447fc54e41dfe06, xc941868c59399d3e, x9b0739496f8b5475, x4d5aabc7a55b12ba);
						return;
					}
				}
				else
				{
					using (SolidBrush solidBrush1 = new SolidBrush (ControlPaint.Dark (((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUITEMCOLOR)))
					{
						x4b101060f4767186.FillRectangle (((Brush) solidBrush1), xa447fc54e41dfe06, xc941868c59399d3e, x9b0739496f8b5475, x4d5aabc7a55b12ba);
					}
				}
			}
			
			protected void xd6cfa3f3f3125e82 (int x75cf7df8c59ffa4d, int xc13ed6de98262a2d)
			
			/*
				// Code Size: 307 Bytes
				.maxstack 6
				.locals (System.Drawing.Point V_0, 
         System.Int32 V_1, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_2, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_3, 
         System.Drawing.Rectangle V_4)
				L_0000: ldarg.1 
				L_0001: ldarg.0 
				L_0002: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0007: call System.Drawing.Point::Int32 get_X()
				L_000c: sub 
				L_000d: starg.s x75cf7df8c59ffa4d
				L_000f: ldarg.2 
				L_0010: ldarg.0 
				L_0011: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0016: call System.Drawing.Point::Int32 get_Y()
				L_001b: sub 
				L_001c: starg.s xc13ed6de98262a2d
				L_001e: ldloca.s V_0
				L_0020: ldarg.1 
				L_0021: ldarg.2 
				L_0022: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0027: ldc.i4.0 
				L_0028: stloc.1 
				L_0029: br.s L_006b
				L_002b: ldarg.0 
				L_002c: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0031: ldloc.1 
				L_0032: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0037: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_003c: stloc.2 
				L_003d: ldloc.2 
				L_003e: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_0043: stloc.s V_4
				L_0045: ldloca.s V_4
				L_0047: ldloc.0 
				L_0048: call System.Drawing.Rectangle::Boolean Contains(System.Drawing.Point)
				L_004d: brfalse.s L_0067
				L_004f: ldarg.0 
				L_0050: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0055: ldloc.1 
				L_0056: beq.s L_0067
				L_0058: ldarg.0 
				L_0059: ldarg.0 
				L_005a: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_005f: ldloc.1 
				L_0060: ldc.i4.0 
				L_0061: ldc.i4.0 
				L_0062: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xeb515a5b77846afe(Int32, Int32, Boolean, Boolean)
				L_0067: ldloc.1 
				L_0068: ldc.i4.1 
				L_0069: add 
				L_006a: stloc.1 
				L_006b: ldloc.1 
				L_006c: ldarg.0 
				L_006d: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0072: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_0077: blt.s L_002b
				L_0079: ldarg.0 
				L_007a: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_007f: ldc.i4.m1 
				L_0080: beq L_0132
				L_0085: ldarg.0 
				L_0086: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_008b: ldarg.0 
				L_008c: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0091: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0096: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_009b: stloc.3 
				L_009c: ldloc.3 
				L_009d: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x649e2ad374251b5f()
				L_00a2: brfalse.s L_00e4
				L_00a4: ldarg.0 
				L_00a5: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xf624f8e86c5ae5f1
				L_00aa: ldarg.0 
				L_00ab: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_00b0: beq L_0132
				L_00b5: ldarg.0 
				L_00b6: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_00bb: brfalse.s L_00d6
				L_00bd: ldarg.0 
				L_00be: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_00c3: callvirt System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_00c8: ldarg.0 
				L_00c9: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::UInt32 x325954b88ff83482
				L_00ce: ldc.i4.0 
				L_00cf: ldc.i4.0 
				L_00d0: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_00d5: pop 
				L_00d6: ldarg.0 
				L_00d7: ldarg.0 
				L_00d8: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_00dd: ldc.i4.0 
				L_00de: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x0760506d6abf77a2(Int32, Boolean)
				L_00e3: ret 
				L_00e4: ldloc.3 
				L_00e5: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xc1facdb08ad4967a()
				L_00ea: brfalse.s L_00f3
				L_00ec: ldarg.0 
				L_00ed: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x057464a452da34b7()
				L_00f2: ret 
				L_00f3: ldarg.0 
				L_00f4: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_00f9: brfalse.s L_0114
				L_00fb: ldarg.0 
				L_00fc: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_0101: callvirt System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0106: ldarg.0 
				L_0107: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::UInt32 x325954b88ff83482
				L_010c: ldc.i4.0 
				L_010d: ldc.i4.0 
				L_010e: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_0113: pop 
				L_0114: ldarg.0 
				L_0115: ldloc.3 
				L_0116: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_011b: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_0120: ldarg.0 
				L_0121: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_0126: callvirt System.Windows.Forms.Timer::Void Stop()
				L_012b: ldarg.0 
				L_012c: ldc.i4.1 
				L_012d: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_0132: ret 
			*/
			
			
			{
				Point point1;
				int i1;
				x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				x75cf7df8c59ffa4d -= this.x6941e4b46c92846d.X;
				xc13ed6de98262a2d -= this.x6941e4b46c92846d.Y;
				point1 = new Point (x75cf7df8c59ffa4d, xc13ed6de98262a2d);
				for (i1 = 0; (i1 < this.xfb5697071ce83988.Count); i1++)
				{
					x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[i1] as x2cc390e9409b0f3f);
					if (x2cc390e9409b0f3f1.xee63d905da8ff550.Contains (point1) && (this.xb266b78561d63b52 != i1))
					{
						this.xeb515a5b77846afe (this.xb266b78561d63b52, i1, false, false);
					}
				}
				if (this.xb266b78561d63b52 == -1)
				{
					return;
				}
				x2cc390e9409b0f3f x2cc390e9409b0f3f2 = (this.xfb5697071ce83988[this.xb266b78561d63b52] as x2cc390e9409b0f3f);
				if (x2cc390e9409b0f3f2.x649e2ad374251b5f)
				{
					if (this.xf624f8e86c5ae5f1 != this.xb266b78561d63b52)
					{
						if (this.x5142fa1a3d9591c8 != null)
						{
							bool b1 = x61467fe65a98f20c.PostMessage (this.x5142fa1a3d9591c8.Handle, this.x325954b88ff83482, uint.MinValue, uint.MinValue);
						}
						this.x0760506d6abf77a2 (this.xb266b78561d63b52, false);
					}
				}
				else if (x2cc390e9409b0f3f2.xc1facdb08ad4967a)
				{
					this.x057464a452da34b7 ();
				}
				else
				{
					if (this.x5142fa1a3d9591c8 != null)
					{
						bool b2 = x61467fe65a98f20c.PostMessage (this.x5142fa1a3d9591c8.Handle, this.x325954b88ff83482, uint.MinValue, uint.MinValue);
					}
					this.x4547ebd0fd2a7079 = x2cc390e9409b0f3f2.x5f4b657f68f87baa;
					this.x420067493d7ebb36.Stop ();
					this.x9a75ed38d1972c87 = true;
				}
			}
			
			protected bool xddec9c21ef58186c (ref Message x6088325dec1baa2a)
			
			/*
				// Code Size: 179 Bytes
				.maxstack 6
				.locals (Sunisoft.IrisSkin.x555516122dcc901e+POINT V_0, 
         Sunisoft.IrisSkin.x555516122dcc901e+POINT V_1)
				L_0000: ldloca.s V_0
				L_0002: ldarg.1 
				L_0003: call System.Windows.Forms.Message::IntPtr get_LParam()
				L_0008: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_000d: ldc.i4 65535
				L_0012: and 
				L_0013: conv.i2 
				L_0014: stfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0019: ldloca.s V_0
				L_001b: ldarg.1 
				L_001c: call System.Windows.Forms.Message::IntPtr get_LParam()
				L_0021: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_0026: ldc.i4 -65536
				L_002b: and 
				L_002c: ldc.i4.s 16
				L_002e: shr.un 
				L_002f: conv.i2 
				L_0030: stfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_0035: ldloca.s V_1
				L_0037: ldarg.0 
				L_0038: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Size x86ef051842f1ae49
				L_003d: call System.Drawing.Size::Int32 get_Width()
				L_0042: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0047: ldc.i4.0 
				L_0048: ldc.i4.s 16
				L_004a: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_004f: sub 
				L_0050: stfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0055: ldloca.s V_1
				L_0057: ldarg.0 
				L_0058: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Size x86ef051842f1ae49
				L_005d: call System.Drawing.Size::Int32 get_Height()
				L_0062: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_0067: ldc.i4.0 
				L_0068: ldc.i4.s 17
				L_006a: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_006f: sub 
				L_0070: stfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_0075: ldarg.0 
				L_0076: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_007b: ldloca.s V_1
				L_007d: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean ClientToScreen(IntPtr, POINT ByRef)
				L_0082: pop 
				L_0083: ldloca.s V_0
				L_0085: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_008a: ldloca.s V_1
				L_008c: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0091: bgt.s L_00a3
				L_0093: ldloca.s V_0
				L_0095: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_009a: ldloca.s V_1
				L_009c: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_00a1: ble.s L_00b1
				L_00a3: ldarg.1 
				L_00a4: ldc.i4.m1 
				L_00a5: call System.IntPtr::IntPtr op_Explicit(Int32)
				L_00aa: call System.Windows.Forms.Message::Void set_Result(IntPtr)
				L_00af: ldc.i4.1 
				L_00b0: ret 
				L_00b1: ldc.i4.0 
				L_00b2: ret 
			*/
			
			
			{
				x555516122dcc901e.POINT pOINT1;
				x555516122dcc901e.POINT pOINT2;
				pOINT1.x = (((int) x6088325dec1baa2a.LParam) & 65535);
				pOINT1.y = ((((int) x6088325dec1baa2a.LParam) & -65536) >> 16);
				pOINT2.x = (this.x86ef051842f1ae49.Width - x902c4aee45bfd906._x13d4cb8d1bd20347[0, 16]);
				pOINT2.y = (this.x86ef051842f1ae49.Height - x902c4aee45bfd906._x13d4cb8d1bd20347[0, 17]);
				bool b1 = x61467fe65a98f20c.ClientToScreen (base.Handle, ref pOINT2);
				if ((pOINT1.x <= pOINT2.x) && (pOINT1.y <= pOINT2.y))
				{
					return false;
				}
				else
				{
					x6088325dec1baa2a.Result = ((IntPtr) (-1));
					return true;
				}
			}
			
			protected void xe145f7beb24da7f5 (Graphics x4b101060f4767186, Rectangle x04a925412b1bb508)
			
			/*
				// Code Size: 372 Bytes
				.maxstack 8
				.locals (System.Drawing.Rectangle V_0, 
         System.Drawing.Brush V_1, 
         System.Boolean V_2, 
         System.Drawing.StringFormat V_3, 
         System.Drawing.Brush V_4, 
         System.Boolean V_5)
				L_0000: ldloca.s V_0
				L_0002: ldarga.s x04a925412b1bb508
				L_0004: call System.Drawing.Rectangle::Int32 get_Left()
				L_0009: ldarga.s x04a925412b1bb508
				L_000b: call System.Drawing.Rectangle::Int32 get_Top()
				L_0010: ldarg.0 
				L_0011: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x3012c20deea55334
				L_0016: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_001b: ldc.i4.0 
				L_001c: ldc.i4.s 20
				L_001e: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0023: sub 
				L_0024: ldarga.s x04a925412b1bb508
				L_0026: call System.Drawing.Rectangle::Int32 get_Height()
				L_002b: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0030: ldnull 
				L_0031: stloc.1 
				L_0032: ldc.i4.1 
				L_0033: stloc.2 
				L_0034: ldarg.0 
				L_0035: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_003a: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Brush get_x9bb803f1a1f3f613()
				L_003f: brfalse.s L_0060
				L_0041: ldarg.0 
				L_0042: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0047: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Brush get_x9bb803f1a1f3f613()
				L_004c: stloc.1 
				L_004d: ldc.i4.0 
				L_004e: stloc.2 
				L_004f: ldloca.s V_0
				L_0051: dup 
				L_0052: call System.Drawing.Rectangle::Int32 get_Width()
				L_0057: ldc.i4.1 
				L_0058: add 
				L_0059: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_005e: br.s L_0071
				L_0060: ldarg.0 
				L_0061: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0066: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Color get_xf66c387eec1b0e74()
				L_006b: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0070: stloc.1 
				L_0071: ldarg.1 
				L_0072: ldloc.1 
				L_0073: ldloc.0 
				L_0074: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0079: ldloc.2 
				L_007a: brfalse.s L_0082
				L_007c: ldloc.1 
				L_007d: callvirt System.Drawing.Brush::Void Dispose()
				L_0082: ldloca.s V_0
				L_0084: dup 
				L_0085: call System.Drawing.Rectangle::Int32 get_X()
				L_008a: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_008f: ldc.i4.0 
				L_0090: ldc.i4.s 18
				L_0092: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0097: add 
				L_0098: call System.Drawing.Rectangle::Void set_X(Int32)
				L_009d: ldloca.s V_0
				L_009f: dup 
				L_00a0: call System.Drawing.Rectangle::Int32 get_Y()
				L_00a5: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_00aa: ldc.i4.0 
				L_00ab: ldc.i4.s 19
				L_00ad: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_00b2: add 
				L_00b3: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_00b8: ldloca.s V_0
				L_00ba: dup 
				L_00bb: call System.Drawing.Rectangle::Int32 get_Width()
				L_00c0: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_00c5: ldc.i4.0 
				L_00c6: ldc.i4.s 18
				L_00c8: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_00cd: ldc.i4.2 
				L_00ce: mul 
				L_00cf: sub 
				L_00d0: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_00d5: ldloca.s V_0
				L_00d7: dup 
				L_00d8: call System.Drawing.Rectangle::Int32 get_Height()
				L_00dd: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_00e2: ldc.i4.0 
				L_00e3: ldc.i4.s 19
				L_00e5: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_00ea: ldc.i4.2 
				L_00eb: mul 
				L_00ec: sub 
				L_00ed: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_00f2: newobj System.Drawing.StringFormat::Void .ctor()
				L_00f7: stloc.3 
				L_00f8: ldloc.3 
				L_00f9: ldc.i4 20482
				L_00fe: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_0103: ldloc.3 
				L_0104: ldc.i4.0 
				L_0105: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_010a: ldloc.3 
				L_010b: ldc.i4.1 
				L_010c: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_0111: ldnull 
				L_0112: stloc.s V_4
				L_0114: ldc.i4.1 
				L_0115: stloc.s V_5
				L_0117: ldarg.0 
				L_0118: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_011d: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Brush get_x0a00a4ce1ac2b818()
				L_0122: brfalse.s L_0136
				L_0124: ldarg.0 
				L_0125: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_012a: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Brush get_x0a00a4ce1ac2b818()
				L_012f: stloc.s V_4
				L_0131: ldc.i4.0 
				L_0132: stloc.s V_5
				L_0134: br.s L_0148
				L_0136: ldarg.0 
				L_0137: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_013c: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Color get_x64752539024e52b4()
				L_0141: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0146: stloc.s V_4
				L_0148: ldarg.1 
				L_0149: ldarg.0 
				L_014a: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_014f: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.String get_x95e21d0daad2a69e()
				L_0154: ldarg.0 
				L_0155: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_015a: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::System.Drawing.Font get_x5af2f9fd52bb2f28()
				L_015f: ldloc.0 
				L_0160: ldloc.s V_4
				L_0162: ldloc.3 
				L_0163: call Sunisoft.IrisSkin.InternalControls.x957e371151765ec5::Void x78fabc70e1eb6bd8(System.Drawing.Graphics, System.String, System.Drawing.Font, System.Drawing.Rectangle, System.Drawing.Brush, System.Drawing.StringFormat)
				L_0168: ldloc.s V_5
				L_016a: brfalse.s L_0173
				L_016c: ldloc.s V_4
				L_016e: callvirt System.Drawing.Brush::Void Dispose()
				L_0173: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Brush brush1;
				Brush brush2;
				rectangle1 = new Rectangle (x04a925412b1bb508.Left, x04a925412b1bb508.Top, ((int) (this.x3012c20deea55334 - x902c4aee45bfd906._x13d4cb8d1bd20347[0, 20])), x04a925412b1bb508.Height);
				bool b1 = true;
				if (this.xf4f555905eaa2330.x9bb803f1a1f3f613 != null)
				{
					brush1 = this.xf4f555905eaa2330.x9bb803f1a1f3f613;
					b1 = false;
					rectangle1.Width++;
				}
				else
				{
					brush1 = ((Brush) new SolidBrush (this.xf4f555905eaa2330.xf66c387eec1b0e74));
				}
				x4b101060f4767186.FillRectangle (brush1, rectangle1);
				if (b1)
				{
					brush1.Dispose ();
				}
				rectangle1.X += x902c4aee45bfd906._x13d4cb8d1bd20347[0, 18];
				rectangle1.Y += x902c4aee45bfd906._x13d4cb8d1bd20347[0, 19];
				rectangle1.Width -= (x902c4aee45bfd906._x13d4cb8d1bd20347[0, 18] * 2);
				rectangle1.Height -= (x902c4aee45bfd906._x13d4cb8d1bd20347[0, 19] * 2);
				StringFormat stringFormat1 = new StringFormat ();
				stringFormat1.FormatFlags = (StringFormatFlags.DirectionVertical | StringFormatFlags.NoWrap | StringFormatFlags.NoClip);
				stringFormat1.Alignment = StringAlignment.Near;
				stringFormat1.LineAlignment = StringAlignment.Center;
				bool b2 = true;
				if (this.xf4f555905eaa2330.x0a00a4ce1ac2b818 != null)
				{
					brush2 = this.xf4f555905eaa2330.x0a00a4ce1ac2b818;
					b2 = false;
				}
				else
				{
					brush2 = ((Brush) new SolidBrush (this.xf4f555905eaa2330.x64752539024e52b4));
				}
				x957e371151765ec5.x78fabc70e1eb6bd8 (x4b101060f4767186, this.xf4f555905eaa2330.x95e21d0daad2a69e, this.xf4f555905eaa2330.x5af2f9fd52bb2f28, rectangle1, brush2, stringFormat1);
				if (b2)
				{
					brush2.Dispose ();
				}
			}
			
			protected void xe75f29bc258e83bf (Graphics x4b101060f4767186, int xa447fc54e41dfe06, int xc941868c59399d3e, int x9b0739496f8b5475, int x4d5aabc7a55b12ba)
			
			/*
				// Code Size: 262 Bytes
				.maxstack 8
				.locals (System.Drawing.Color V_0, 
         System.Drawing.Color V_1, 
         System.Drawing.Color V_2, 
         System.Drawing.Drawing2D.LinearGradientBrush V_3, 
         System.Drawing.Drawing2D.LinearGradientBrush V_4, 
         System.Drawing.SolidBrush V_5)
				.try L_005c to L_0084 finally L_0084 to L_008e
				.try L_00a8 to L_00ba finally L_00ba to L_00c6
				.try L_00e7 to L_00f9 finally L_00f9 to L_0105
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xdb6050a2030517f4
				L_0006: brfalse L_00c6
				L_000b: ldc.i4.s 64
				L_000d: ldc.i4.0 
				L_000e: ldc.i4.0 
				L_000f: ldc.i4.0 
				L_0010: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_0015: stloc.0 
				L_0016: ldc.i4.s 48
				L_0018: ldc.i4.0 
				L_0019: ldc.i4.0 
				L_001a: ldc.i4.0 
				L_001b: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_0020: stloc.1 
				L_0021: ldc.i4.0 
				L_0022: ldc.i4.0 
				L_0023: ldc.i4.0 
				L_0024: ldc.i4.0 
				L_0025: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_002a: stloc.2 
				L_002b: ldarg.s x4d5aabc7a55b12ba
				L_002d: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_0032: blt.s L_008e
				L_0034: ldarg.2 
				L_0035: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_003a: sub 
				L_003b: ldarg.3 
				L_003c: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_0041: add 
				L_0042: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0047: ldarg.2 
				L_0048: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_004d: add 
				L_004e: ldarg.3 
				L_004f: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0054: ldloc.0 
				L_0055: ldloc.2 
				L_0056: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Point, System.Drawing.Point, System.Drawing.Color, System.Drawing.Color)
				L_005b: stloc.3 
				L_005c: ldarg.1 
				L_005d: ldloc.3 
				L_005e: ldarg.2 
				L_005f: ldarg.3 
				L_0060: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_0065: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_006a: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_006f: ldarg.3 
				L_0070: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_0075: add 
				L_0076: starg.s xc941868c59399d3e
				L_0078: ldarg.s x4d5aabc7a55b12ba
				L_007a: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x36404b43d7b678c8
				L_007f: sub 
				L_0080: starg.s x4d5aabc7a55b12ba
				L_0082: leave.s L_008e
				L_0084: ldloc.3 
				L_0085: brfalse.s L_008d
				L_0087: ldloc.3 
				L_0088: callvirt System.IDisposable::Void Dispose()
				L_008d: endfinally 
				L_008e: ldarg.2 
				L_008f: ldc.i4.0 
				L_0090: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0095: ldarg.2 
				L_0096: ldarg.s x9b0739496f8b5475
				L_0098: add 
				L_0099: ldc.i4.0 
				L_009a: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_009f: ldloc.1 
				L_00a0: ldloc.2 
				L_00a1: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Point, System.Drawing.Point, System.Drawing.Color, System.Drawing.Color)
				L_00a6: stloc.s V_4
				L_00a8: ldarg.1 
				L_00a9: ldloc.s V_4
				L_00ab: ldarg.2 
				L_00ac: ldarg.3 
				L_00ad: ldarg.s x9b0739496f8b5475
				L_00af: ldarg.s x4d5aabc7a55b12ba
				L_00b1: ldc.i4.1 
				L_00b2: add 
				L_00b3: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_00b8: leave.s L_0105
				L_00ba: ldloc.s V_4
				L_00bc: brfalse.s L_00c5
				L_00be: ldloc.s V_4
				L_00c0: callvirt System.IDisposable::Void Dispose()
				L_00c5: endfinally 
				L_00c6: ldarg.0 
				L_00c7: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_00cc: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00d1: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_00d6: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUITEMCOLOR
				L_00db: call System.Windows.Forms.ControlPaint::System.Drawing.Color Dark(System.Drawing.Color)
				L_00e0: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_00e5: stloc.s V_5
				L_00e7: ldarg.1 
				L_00e8: ldloc.s V_5
				L_00ea: ldarg.2 
				L_00eb: ldarg.3 
				L_00ec: ldarg.s x9b0739496f8b5475
				L_00ee: ldarg.s x4d5aabc7a55b12ba
				L_00f0: ldc.i4.1 
				L_00f1: add 
				L_00f2: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_00f7: leave.s L_0105
				L_00f9: ldloc.s V_5
				L_00fb: brfalse.s L_0104
				L_00fd: ldloc.s V_5
				L_00ff: callvirt System.IDisposable::Void Dispose()
				L_0104: endfinally 
				L_0105: ret 
			*/
			
			
			{
				Color color1;
				Color color2;
				Color color3;
				if (this.xdb6050a2030517f4)
				{
					color1 = Color.FromArgb (64, 0, 0, 0);
					color2 = Color.FromArgb (48, 0, 0, 0);
					color3 = Color.FromArgb (0, 0, 0, 0);
					if (x4d5aabc7a55b12ba >= x902c4aee45bfd906.x36404b43d7b678c8)
					{
						using (LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush (new Point (((int) (xa447fc54e41dfe06 - x902c4aee45bfd906.x36404b43d7b678c8)), ((int) (xc941868c59399d3e + x902c4aee45bfd906.x36404b43d7b678c8))), new Point (((int) (xa447fc54e41dfe06 + x902c4aee45bfd906.x36404b43d7b678c8)), xc941868c59399d3e), color1, color3))
						{
							x4b101060f4767186.FillRectangle (((Brush) linearGradientBrush1), xa447fc54e41dfe06, xc941868c59399d3e, x902c4aee45bfd906.x36404b43d7b678c8, x902c4aee45bfd906.x36404b43d7b678c8);
							xc941868c59399d3e += x902c4aee45bfd906.x36404b43d7b678c8;
							x4d5aabc7a55b12ba -= x902c4aee45bfd906.x36404b43d7b678c8;
						}
					}
					using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush (new Point (xa447fc54e41dfe06, 0), new Point (((int) (xa447fc54e41dfe06 + x9b0739496f8b5475)), 0), color2, color3))
					{
						x4b101060f4767186.FillRectangle (((Brush) linearGradientBrush2), xa447fc54e41dfe06, xc941868c59399d3e, x9b0739496f8b5475, ((int) (x4d5aabc7a55b12ba + 1)));
						return;
					}
				}
				else
				{
					using (SolidBrush solidBrush1 = new SolidBrush (ControlPaint.Dark (((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUITEMCOLOR)))
					{
						x4b101060f4767186.FillRectangle (((Brush) solidBrush1), xa447fc54e41dfe06, xc941868c59399d3e, x9b0739496f8b5475, ((int) (x4d5aabc7a55b12ba + 1)));
					}
				}
			}
			
			protected void xeb515a5b77846afe (int x5360a38cdebd0e93, int x169940ac3300e3e7, bool xaca68b9c5e07af12, bool xb2ad27288bcb93e7)
			
			/*
				// Code Size: 330 Bytes
				.maxstack 6
				.locals (System.Boolean V_0, 
         System.Drawing.Graphics V_1, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_2, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_3)
				.try L_000e to L_013f finally L_013f to L_0149
				L_0000: ldc.i4.0 
				L_0001: stloc.0 
				L_0002: ldarg.0 
				L_0003: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0008: call System.Drawing.Graphics::System.Drawing.Graphics FromHwnd(IntPtr)
				L_000d: stloc.1 
				L_000e: ldarg.1 
				L_000f: ldc.i4.m1 
				L_0010: beq.s L_005d
				L_0012: ldarg.0 
				L_0013: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0018: ldarg.1 
				L_0019: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_001e: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0023: stloc.2 
				L_0024: ldarg.0 
				L_0025: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xdb6050a2030517f4
				L_002a: brfalse.s L_0030
				L_002c: ldc.i4.1 
				L_002d: stloc.0 
				L_002e: br.s L_0049
				L_0030: ldarg.0 
				L_0031: ldloc.1 
				L_0032: ldarg.0 
				L_0033: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_0038: ldarg.1 
				L_0039: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_003e: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0043: ldc.i4.0 
				L_0044: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xb5a5bdae3ba8936b(System.Drawing.Graphics, Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f, Boolean)
				L_0049: ldloc.2 
				L_004a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_004f: brfalse.s L_005d
				L_0051: ldarg.0 
				L_0052: ldloc.2 
				L_0053: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0058: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void OnDeselected(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_005d: ldarg.2 
				L_005e: ldc.i4.m1 
				L_005f: beq L_0125
				L_0064: ldarg.0 
				L_0065: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_006a: callvirt System.Windows.Forms.Timer::Void Stop()
				L_006f: ldarg.s xb2ad27288bcb93e7
				L_0071: brtrue.s L_0096
				L_0073: ldarg.0 
				L_0074: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_0079: brfalse.s L_0096
				L_007b: ldarg.0 
				L_007c: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_0081: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xf26876fa09ed817e
				L_0086: callvirt System.Windows.Forms.Timer::Void set_Interval(Int32)
				L_008b: ldarg.0 
				L_008c: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_0091: callvirt System.Windows.Forms.Timer::Void Start()
				L_0096: ldarg.0 
				L_0097: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_009c: ldarg.2 
				L_009d: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_00a2: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_00a7: stloc.3 
				L_00a8: ldloc.3 
				L_00a9: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x43604484a3deae4f()
				L_00ae: brtrue L_0122
				L_00b3: ldloc.3 
				L_00b4: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x9f2c0dc847992f03()
				L_00b9: brfalse.s L_0122
				L_00bb: ldarg.0 
				L_00bc: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xdb6050a2030517f4
				L_00c1: brfalse.s L_00c7
				L_00c3: ldc.i4.1 
				L_00c4: stloc.0 
				L_00c5: br.s L_00d0
				L_00c7: ldarg.0 
				L_00c8: ldloc.1 
				L_00c9: ldloc.3 
				L_00ca: ldc.i4.1 
				L_00cb: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xb5a5bdae3ba8936b(System.Drawing.Graphics, Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f, Boolean)
				L_00d0: ldarg.s xb2ad27288bcb93e7
				L_00d2: brtrue.s L_010c
				L_00d4: ldarg.3 
				L_00d5: brfalse.s L_010c
				L_00d7: ldloc.3 
				L_00d8: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xc1facdb08ad4967a()
				L_00dd: brfalse.s L_00f1
				L_00df: ldarg.0 
				L_00e0: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_00e5: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xd046a8db53f32448
				L_00ea: callvirt System.Windows.Forms.Timer::Void set_Interval(Int32)
				L_00ef: br.s L_0101
				L_00f1: ldarg.0 
				L_00f2: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_00f7: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xf26876fa09ed817e
				L_00fc: callvirt System.Windows.Forms.Timer::Void set_Interval(Int32)
				L_0101: ldarg.0 
				L_0102: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_0107: callvirt System.Windows.Forms.Timer::Void Start()
				L_010c: ldloc.3 
				L_010d: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0112: brfalse.s L_0125
				L_0114: ldarg.0 
				L_0115: ldloc.3 
				L_0116: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_011b: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void OnSelected(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0120: br.s L_0125
				L_0122: ldc.i4.m1 
				L_0123: starg.s x169940ac3300e3e7
				L_0125: ldarg.0 
				L_0126: ldarg.2 
				L_0127: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_012c: ldarg.0 
				L_012d: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xdb6050a2030517f4
				L_0132: brfalse.s L_013d
				L_0134: ldloc.0 
				L_0135: brfalse.s L_013d
				L_0137: ldarg.0 
				L_0138: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x9119fce83e4631ad()
				L_013d: leave.s L_0149
				L_013f: ldloc.1 
				L_0140: brfalse.s L_0148
				L_0142: ldloc.1 
				L_0143: callvirt System.IDisposable::Void Dispose()
				L_0148: endfinally 
				L_0149: ret 
			*/
			
			
			{
				x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				x2cc390e9409b0f3f x2cc390e9409b0f3f2;
				bool b1 = false;
				using (Graphics graphics1 = Graphics.FromHwnd (base.Handle))
				{
					if (x5360a38cdebd0e93 != -1)
					{
						x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[x5360a38cdebd0e93] as x2cc390e9409b0f3f);
						if (this.xdb6050a2030517f4)
						{
							b1 = true;
						}
						else
						{
							this.xb5a5bdae3ba8936b (graphics1, (this.xfb5697071ce83988[x5360a38cdebd0e93] as x2cc390e9409b0f3f), false);
						}
						if (x2cc390e9409b0f3f1.x5f4b657f68f87baa != null)
						{
							this.OnDeselected (x2cc390e9409b0f3f1.x5f4b657f68f87baa);
						}
					}
					if (x169940ac3300e3e7 != -1)
					{
						this.x420067493d7ebb36.Stop ();
						if ((! xb2ad27288bcb93e7) && (this.x5142fa1a3d9591c8 != null))
						{
							this.x420067493d7ebb36.Interval = x902c4aee45bfd906.xf26876fa09ed817e;
							this.x420067493d7ebb36.Start ();
						}
						x2cc390e9409b0f3f2 = (this.xfb5697071ce83988[x169940ac3300e3e7] as x2cc390e9409b0f3f);
						if (x2cc390e9409b0f3f2.x43604484a3deae4f || (! x2cc390e9409b0f3f2.x9f2c0dc847992f03))
						{
							x169940ac3300e3e7 = -1;
						}
						else
						{
							if (this.xdb6050a2030517f4)
							{
								b1 = true;
							}
							else
							{
								this.xb5a5bdae3ba8936b (graphics1, x2cc390e9409b0f3f2, true);
							}
							if ((! xb2ad27288bcb93e7) && xaca68b9c5e07af12)
							{
								if (x2cc390e9409b0f3f2.xc1facdb08ad4967a)
								{
									this.x420067493d7ebb36.Interval = x902c4aee45bfd906.xd046a8db53f32448;
								}
								else
								{
									this.x420067493d7ebb36.Interval = x902c4aee45bfd906.xf26876fa09ed817e;
								}
								this.x420067493d7ebb36.Start ();
							}
							if (x2cc390e9409b0f3f2.x5f4b657f68f87baa != null)
							{
								this.OnSelected (x2cc390e9409b0f3f2.x5f4b657f68f87baa);
							}
						}
					}
					this.xb266b78561d63b52 = x169940ac3300e3e7;
					if (this.xdb6050a2030517f4 && b1)
					{
						this.x9119fce83e4631ad ();
					}
				}
			}
			
			protected void xf1420593eaecc724 (bool x789c645a15deb49b)
			
			/*
				// Code Size: 133 Bytes
				.maxstack 5
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Byte V_2, 
         System.DateTime V_3, 
         System.DateTime V_4, 
         System.TimeSpan V_5)
				L_0000: ldarg.0 
				L_0001: ldc.i4.0 
				L_0002: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x9119fce83e4631ad(Byte)
				L_0007: ldarg.0 
				L_0008: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_000d: ldc.i4.4 
				L_000e: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 ShowWindow(IntPtr, Int16)
				L_0013: pop 
				L_0014: ldarg.0 
				L_0015: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x8d677ea3c0d5a202
				L_001a: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x65b69cc23d1d4c9e
				L_001f: div 
				L_0020: stloc.0 
				L_0021: ldc.i4.0 
				L_0022: stloc.1 
				L_0023: br.s L_007c
				L_0025: ldc.i4.s 63
				L_0027: ldc.i4 192
				L_002c: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x65b69cc23d1d4c9e
				L_0031: div 
				L_0032: ldloc.1 
				L_0033: ldc.i4.1 
				L_0034: add 
				L_0035: mul 
				L_0036: add 
				L_0037: conv.u1 
				L_0038: stloc.2 
				L_0039: call System.DateTime::System.DateTime get_Now()
				L_003e: stloc.3 
				L_003f: ldarg.0 
				L_0040: ldloc.2 
				L_0041: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x9119fce83e4631ad(Byte)
				L_0046: call System.DateTime::System.DateTime get_Now()
				L_004b: stloc.s V_4
				L_004d: ldloca.s V_4
				L_004f: ldloc.3 
				L_0050: call System.DateTime::System.TimeSpan Subtract(System.DateTime)
				L_0055: stloc.s V_5
				L_0057: ldarg.0 
				L_0058: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x8d677ea3c0d5a202
				L_005d: ldc.i4.0 
				L_005e: ble.s L_0078
				L_0060: ldloca.s V_5
				L_0062: call System.TimeSpan::Int32 get_Milliseconds()
				L_0067: ldloc.0 
				L_0068: bge.s L_0078
				L_006a: ldloc.0 
				L_006b: ldloca.s V_5
				L_006d: call System.TimeSpan::Int32 get_Milliseconds()
				L_0072: sub 
				L_0073: call System.Threading.Thread::Void Sleep(Int32)
				L_0078: ldloc.1 
				L_0079: ldc.i4.1 
				L_007a: add 
				L_007b: stloc.1 
				L_007c: ldloc.1 
				L_007d: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x65b69cc23d1d4c9e
				L_0082: blt.s L_0025
				L_0084: ret 
			*/
			
			
			{
				int i2;
				byte byte1;
				DateTime dateTime1;
				DateTime dateTime2;
				TimeSpan timeSpan1;
				this.x9119fce83e4631ad (byte.MinValue);
				int i3 = x61467fe65a98f20c.ShowWindow (base.Handle, 4);
				int i1 = (this.x8d677ea3c0d5a202 / x902c4aee45bfd906.x65b69cc23d1d4c9e);
				for (i2 = 0; (i2 < x902c4aee45bfd906.x65b69cc23d1d4c9e); i2++)
				{
					byte1 = ((byte) (63 + ((192 / x902c4aee45bfd906.x65b69cc23d1d4c9e) * (i2 + 1))));
					dateTime1 = DateTime.Now;
					this.x9119fce83e4631ad (byte1);
					dateTime2 = DateTime.Now;
					timeSpan1 = dateTime2.Subtract (dateTime1);
					if ((this.x8d677ea3c0d5a202 > 0) && (timeSpan1.Milliseconds < i1))
					{
						Thread.Sleep (((int) (i1 - timeSpan1.Milliseconds)));
					}
				}
			}
			
			protected x5f4b657f68f87baa xf1c4e2176aec0ad6 (bool xacc37ebdd71fcc44)
			
			/*
				// Code Size: 1607 Bytes
				.maxstack 6
				.locals (System.Boolean V_0, 
         Sunisoft.IrisSkin.x40255b11ef821fa3+MSG V_1, 
         System.Boolean V_2, 
         System.Boolean V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         Sunisoft.IrisSkin.x555516122dcc901e+POINT V_6, 
         Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 V_7, 
         Sunisoft.IrisSkin.x555516122dcc901e+POINT V_8, 
         Sunisoft.IrisSkin.x555516122dcc901e+POINT V_9, 
         Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 V_10, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_11, 
         System.Int32 V_12, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_13, 
         Sunisoft.IrisSkin.x40255b11ef821fa3+MSG V_14, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_15, 
         System.Int32 V_16)
				.try L_0000 to L_063e catch System.Exception L_063e to L_0644
				L_0000: ldarg.0 
				L_0001: ldnull 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_0007: ldarg.0 
				L_0008: ldc.i4.m1 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_000e: ldarg.0 
				L_000f: ldc.i4.0 
				L_0010: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_0015: ldarg.0 
				L_0016: ldc.i4.0 
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x753f06f9b5cd6e0d
				L_001c: ldarg.0 
				L_001d: ldc.i4.0 
				L_001e: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x0cd2bb383a46f073
				L_0023: ldc.i4.0 
				L_0024: stloc.0 
				L_0025: ldarg.0 
				L_0026: ldc.i4.1 
				L_0027: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x20ad2840ee62b6a4
				L_002c: ldarg.0 
				L_002d: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xa1715c5212ff8a33()
				L_0032: ldloca.s V_1
				L_0034: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+MSG
				L_003a: ldarg.1 
				L_003b: brfalse.s L_0044
				L_003d: ldarg.0 
				L_003e: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x5b2e42a68d835b31()
				L_0043: pop 
				L_0044: ldsfld System.IntPtr::IntPtr Zero
				L_0049: ldc.i4 32512
				L_004e: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr LoadCursor(IntPtr, UInt32)
				L_0053: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr SetCursor(IntPtr)
				L_0058: pop 
				L_0059: ldsfld System.IntPtr::IntPtr Zero
				L_005e: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean HideCaret(IntPtr)
				L_0063: stloc.2 
				L_0064: br L_05d8
				L_0069: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean WaitMessage()
				L_006e: brfalse L_05d8
				L_0073: br L_05c0
				L_0078: ldc.i4.0 
				L_0079: stloc.3 
				L_007a: ldarg.0 
				L_007b: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Size x86ef051842f1ae49
				L_0080: call System.Drawing.Size::Int32 get_Width()
				L_0085: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_008a: ldc.i4.0 
				L_008b: ldc.i4.s 16
				L_008d: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_0092: sub 
				L_0093: stloc.s V_4
				L_0095: ldarg.0 
				L_0096: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Size x86ef051842f1ae49
				L_009b: call System.Drawing.Size::Int32 get_Height()
				L_00a0: ldsfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32[,] _x13d4cb8d1bd20347
				L_00a5: ldc.i4.0 
				L_00a6: ldc.i4.s 17
				L_00a8: call System.Int32[,]::Int32 Get(Int32, Int32)
				L_00ad: sub 
				L_00ae: stloc.s V_5
				L_00b0: ldloca.s V_1
				L_00b2: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_00b7: ldc.i4 514
				L_00bc: beq.s L_0123
				L_00be: ldloca.s V_1
				L_00c0: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_00c5: ldc.i4 520
				L_00ca: beq.s L_0123
				L_00cc: ldloca.s V_1
				L_00ce: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_00d3: ldc.i4 517
				L_00d8: beq.s L_0123
				L_00da: ldloca.s V_1
				L_00dc: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_00e1: ldc.i4 524
				L_00e6: beq.s L_0123
				L_00e8: ldloca.s V_1
				L_00ea: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_00ef: ldc.i4 162
				L_00f4: beq.s L_0123
				L_00f6: ldloca.s V_1
				L_00f8: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_00fd: ldc.i4 168
				L_0102: beq.s L_0123
				L_0104: ldloca.s V_1
				L_0106: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_010b: ldc.i4 165
				L_0110: beq.s L_0123
				L_0112: ldloca.s V_1
				L_0114: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0119: ldc.i4 172
				L_011e: bne.un L_01c1
				L_0123: ldarg.0 
				L_0124: ldloc.1 
				L_0125: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::POINT x4b688849d80162f6(MSG)
				L_012a: stloc.s V_6
				L_012c: ldloca.s V_6
				L_012e: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0133: ldarg.0 
				L_0134: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0139: call System.Drawing.Point::Int32 get_X()
				L_013e: blt.s L_019a
				L_0140: ldloca.s V_6
				L_0142: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0147: ldarg.0 
				L_0148: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_014d: call System.Drawing.Point::Int32 get_X()
				L_0152: ldloc.s V_4
				L_0154: add 
				L_0155: bgt.s L_019a
				L_0157: ldloca.s V_6
				L_0159: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_015e: ldarg.0 
				L_015f: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0164: call System.Drawing.Point::Int32 get_Y()
				L_0169: blt.s L_019a
				L_016b: ldloca.s V_6
				L_016d: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_0172: ldarg.0 
				L_0173: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0178: call System.Drawing.Point::Int32 get_Y()
				L_017d: ldloc.s V_5
				L_017f: add 
				L_0180: bgt.s L_019a
				L_0182: ldarg.0 
				L_0183: ldloca.s V_6
				L_0185: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_018a: ldloca.s V_6
				L_018c: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_0191: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xd6cfa3f3f3125e82(Int32, Int32)
				L_0196: ldc.i4.1 
				L_0197: stloc.3 
				L_0198: br.s L_01c1
				L_019a: ldarg.0 
				L_019b: ldloc.s V_6
				L_019d: ldloca.s V_1
				L_019f: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x3c6f7570c20e3f7d(POINT, MSG ByRef)
				L_01a4: stloc.s V_7
				L_01a6: ldloc.s V_7
				L_01a8: brfalse.s L_01c1
				L_01aa: ldloc.s V_7
				L_01ac: ldloca.s V_6
				L_01ae: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_01b3: ldloca.s V_6
				L_01b5: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_01ba: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xd6cfa3f3f3125e82(Int32, Int32)
				L_01bf: ldc.i4.1 
				L_01c0: stloc.3 
				L_01c1: ldloca.s V_1
				L_01c3: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_01c8: ldc.i4 513
				L_01cd: beq.s L_0234
				L_01cf: ldloca.s V_1
				L_01d1: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_01d6: ldc.i4 519
				L_01db: beq.s L_0234
				L_01dd: ldloca.s V_1
				L_01df: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_01e4: ldc.i4 516
				L_01e9: beq.s L_0234
				L_01eb: ldloca.s V_1
				L_01ed: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_01f2: ldc.i4 523
				L_01f7: beq.s L_0234
				L_01f9: ldloca.s V_1
				L_01fb: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0200: ldc.i4 161
				L_0205: beq.s L_0234
				L_0207: ldloca.s V_1
				L_0209: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_020e: ldc.i4 167
				L_0213: beq.s L_0234
				L_0215: ldloca.s V_1
				L_0217: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_021c: ldc.i4 164
				L_0221: beq.s L_0234
				L_0223: ldloca.s V_1
				L_0225: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_022a: ldc.i4 171
				L_022f: bne.un L_02f0
				L_0234: ldarg.0 
				L_0235: ldloc.1 
				L_0236: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::POINT x4b688849d80162f6(MSG)
				L_023b: stloc.s V_8
				L_023d: ldloca.s V_8
				L_023f: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0244: ldarg.0 
				L_0245: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_024a: call System.Drawing.Point::Int32 get_X()
				L_024f: blt.s L_0297
				L_0251: ldloca.s V_8
				L_0253: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0258: ldarg.0 
				L_0259: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_025e: call System.Drawing.Point::Int32 get_X()
				L_0263: ldloc.s V_4
				L_0265: add 
				L_0266: bgt.s L_0297
				L_0268: ldloca.s V_8
				L_026a: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_026f: ldarg.0 
				L_0270: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0275: call System.Drawing.Point::Int32 get_Y()
				L_027a: blt.s L_0297
				L_027c: ldloca.s V_8
				L_027e: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_0283: ldarg.0 
				L_0284: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0289: call System.Drawing.Point::Int32 get_Y()
				L_028e: ldloc.s V_5
				L_0290: add 
				L_0291: bgt.s L_0297
				L_0293: ldc.i4.1 
				L_0294: stloc.3 
				L_0295: br.s L_02f0
				L_0297: ldarg.0 
				L_0298: ldloc.s V_8
				L_029a: ldloca.s V_1
				L_029c: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x3c6f7570c20e3f7d(POINT, MSG ByRef)
				L_02a1: brtrue.s L_02ee
				L_02a3: ldarg.0 
				L_02a4: ldloc.s V_8
				L_02a6: ldloca.s V_1
				L_02a8: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x277ff37e12aff68b(POINT, MSG ByRef)
				L_02ad: brfalse.s L_02c0
				L_02af: ldarg.0 
				L_02b0: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_02b5: ldloc.s V_8
				L_02b7: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x2ea07c3ab5d970d4(POINT)
				L_02bc: ldc.i4.1 
				L_02bd: stloc.3 
				L_02be: br.s L_02f0
				L_02c0: ldarg.0 
				L_02c1: ldc.i4.1 
				L_02c2: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_02c7: ldc.i4.1 
				L_02c8: stloc.0 
				L_02c9: ldarg.0 
				L_02ca: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_02cf: brfalse.s L_02f0
				L_02d1: ldloca.s V_1
				L_02d3: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr hwnd
				L_02d8: ldarg.0 
				L_02d9: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_02de: callvirt System.Windows.Forms.Control::IntPtr get_Handle()
				L_02e3: call System.IntPtr::Boolean op_Equality(IntPtr, IntPtr)
				L_02e8: brfalse.s L_02f0
				L_02ea: ldc.i4.0 
				L_02eb: stloc.0 
				L_02ec: br.s L_02f0
				L_02ee: ldc.i4.1 
				L_02ef: stloc.3 
				L_02f0: ldloca.s V_1
				L_02f2: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_02f7: ldc.i4 512
				L_02fc: bne.un L_03c6
				L_0301: ldarg.0 
				L_0302: ldloc.1 
				L_0303: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::POINT x4b688849d80162f6(MSG)
				L_0308: stloc.s V_9
				L_030a: ldloca.s V_9
				L_030c: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0311: ldarg.0 
				L_0312: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0317: call System.Drawing.Point::Int32 get_X()
				L_031c: blt.s L_0376
				L_031e: ldloca.s V_9
				L_0320: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0325: ldarg.0 
				L_0326: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_032b: call System.Drawing.Point::Int32 get_X()
				L_0330: ldloc.s V_4
				L_0332: add 
				L_0333: bgt.s L_0376
				L_0335: ldloca.s V_9
				L_0337: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_033c: ldarg.0 
				L_033d: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0342: call System.Drawing.Point::Int32 get_Y()
				L_0347: blt.s L_0376
				L_0349: ldloca.s V_9
				L_034b: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_0350: ldarg.0 
				L_0351: ldflda Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Drawing.Point x6941e4b46c92846d
				L_0356: call System.Drawing.Point::Int32 get_Y()
				L_035b: ldloc.s V_5
				L_035d: add 
				L_035e: bgt.s L_0376
				L_0360: ldarg.0 
				L_0361: ldloca.s V_9
				L_0363: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0368: ldloca.s V_9
				L_036a: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_036f: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x136735fdfe6d04ea(Int32, Int32)
				L_0374: br.s L_03c4
				L_0376: ldarg.0 
				L_0377: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x753f06f9b5cd6e0d
				L_037c: brfalse.s L_0384
				L_037e: ldarg.0 
				L_037f: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xa84c74b103039157()
				L_0384: ldarg.0 
				L_0385: ldloc.s V_9
				L_0387: ldloca.s V_1
				L_0389: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x3c6f7570c20e3f7d(POINT, MSG ByRef)
				L_038e: stloc.s V_10
				L_0390: ldloc.s V_10
				L_0392: brfalse.s L_03ab
				L_0394: ldloc.s V_10
				L_0396: ldloca.s V_9
				L_0398: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_039d: ldloca.s V_9
				L_039f: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_03a4: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x136735fdfe6d04ea(Int32, Int32)
				L_03a9: br.s L_03c4
				L_03ab: ldarg.0 
				L_03ac: ldloc.s V_9
				L_03ae: ldloca.s V_1
				L_03b0: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x277ff37e12aff68b(POINT, MSG ByRef)
				L_03b5: brfalse.s L_03c4
				L_03b7: ldarg.0 
				L_03b8: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_03bd: ldloc.s V_9
				L_03bf: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x136735fdfe6d04ea(POINT)
				L_03c4: ldc.i4.1 
				L_03c5: stloc.3 
				L_03c6: ldloca.s V_1
				L_03c8: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_03cd: ldc.i4.s 32
				L_03cf: bne.un.s L_03d9
				L_03d1: ldarg.0 
				L_03d2: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x773209141f430902()
				L_03d7: ldc.i4.1 
				L_03d8: stloc.3 
				L_03d9: ldloca.s V_1
				L_03db: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_03e0: ldc.i4 260
				L_03e5: bne.un.s L_040c
				L_03e7: ldloca.s V_1
				L_03e9: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr wParam
				L_03ee: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_03f3: ldc.i4.s 18
				L_03f5: bne.un.s L_0400
				L_03f7: ldarg.0 
				L_03f8: ldc.i4.1 
				L_03f9: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_03fe: br.s L_040c
				L_0400: ldloca.s V_1
				L_0402: ldc.i4 256
				L_0407: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_040c: ldloca.s V_1
				L_040e: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0413: ldc.i4 256
				L_0418: bne.un L_0543
				L_041d: ldloca.s V_1
				L_041f: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr wParam
				L_0424: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_0429: stloc.s V_16
				L_042b: ldloc.s V_16
				L_042d: ldc.i4.s 13
				L_042f: beq.s L_048e
				L_0431: ldloc.s V_16
				L_0433: ldc.i4.s 27
				L_0435: beq L_04f6
				L_043a: ldloc.s V_16
				L_043c: ldc.i4.s 37
				L_043e: sub 
				L_043f: switch (L_0471, L_0459, L_047c, L_0465)
				L_0454: br L_04ff
				L_0459: ldarg.0 
				L_045a: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x5437d760e9a6340b()
				L_045f: pop 
				L_0460: br L_0543
				L_0465: ldarg.0 
				L_0466: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x5b2e42a68d835b31()
				L_046b: pop 
				L_046c: br L_0543
				L_0471: ldarg.0 
				L_0472: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x0e37e200024f43ba()
				L_0477: br L_0543
				L_047c: ldarg.0 
				L_047d: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean xb2aa7fc859b3d5b7()
				L_0482: brfalse L_0543
				L_0487: ldc.i4.1 
				L_0488: stloc.0 
				L_0489: br L_0543
				L_048e: ldarg.0 
				L_048f: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_0494: ldc.i4.m1 
				L_0495: beq L_0543
				L_049a: ldarg.0 
				L_049b: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_04a0: ldarg.0 
				L_04a1: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_04a6: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_04ab: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_04b0: stloc.s V_11
				L_04b2: ldloc.s V_11
				L_04b4: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x649e2ad374251b5f()
				L_04b9: brfalse.s L_04cf
				L_04bb: ldarg.0 
				L_04bc: ldarg.0 
				L_04bd: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_04c2: ldc.i4.0 
				L_04c3: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x0760506d6abf77a2(Int32, Boolean)
				L_04c8: ldc.i4.1 
				L_04c9: stloc.0 
				L_04ca: br L_0543
				L_04cf: ldloc.s V_11
				L_04d1: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xc1facdb08ad4967a()
				L_04d6: brfalse.s L_04e0
				L_04d8: ldarg.0 
				L_04d9: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x057464a452da34b7()
				L_04de: br.s L_0543
				L_04e0: ldarg.0 
				L_04e1: ldloc.s V_11
				L_04e3: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_04e8: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_04ed: ldarg.0 
				L_04ee: ldc.i4.1 
				L_04ef: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_04f4: br.s L_0543
				L_04f6: ldarg.0 
				L_04f7: ldc.i4.1 
				L_04f8: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_04fd: br.s L_0543
				L_04ff: ldarg.0 
				L_0500: ldloca.s V_1
				L_0502: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr wParam
				L_0507: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_050c: conv.u2 
				L_050d: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 x65c1cc54cc8b0e75(Char)
				L_0512: stloc.s V_12
				L_0514: ldloc.s V_12
				L_0516: ldc.i4.m1 
				L_0517: beq.s L_0543
				L_0519: ldarg.0 
				L_051a: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Collections.ArrayList xfb5697071ce83988
				L_051f: ldloc.s V_12
				L_0521: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0526: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_052b: stloc.s V_13
				L_052d: ldarg.0 
				L_052e: ldloc.s V_13
				L_0530: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0535: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_053a: ldarg.0 
				L_053b: ldc.i4.1 
				L_053c: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_0541: ldc.i4.1 
				L_0542: stloc.0 
				L_0543: ldloca.s V_1
				L_0545: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_054a: ldc.i4 256
				L_054f: beq.s L_057b
				L_0551: ldloca.s V_1
				L_0553: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0558: ldc.i4 257
				L_055d: beq.s L_057b
				L_055f: ldloca.s V_1
				L_0561: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0566: ldc.i4 260
				L_056b: beq.s L_057b
				L_056d: ldloca.s V_1
				L_056f: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0574: ldc.i4 261
				L_0579: bne.un.s L_057d
				L_057b: ldc.i4.1 
				L_057c: stloc.3 
				L_057d: ldloc.3 
				L_057e: brfalse.s L_0599
				L_0580: ldloca.s V_14
				L_0582: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+MSG
				L_0588: ldloca.s V_14
				L_058a: ldsfld System.IntPtr::IntPtr Zero
				L_058f: ldc.i4.0 
				L_0590: ldc.i4.0 
				L_0591: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetMessage(MSG ByRef, IntPtr, UInt32, UInt32)
				L_0596: pop 
				L_0597: br.s L_05c0
				L_0599: ldloc.0 
				L_059a: brtrue.s L_05be
				L_059c: ldloca.s V_1
				L_059e: ldsfld System.IntPtr::IntPtr Zero
				L_05a3: ldc.i4.0 
				L_05a4: ldc.i4.0 
				L_05a5: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetMessage(MSG ByRef, IntPtr, UInt32, UInt32)
				L_05aa: brfalse.s L_05c0
				L_05ac: ldloca.s V_1
				L_05ae: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean TranslateMessage(MSG ByRef)
				L_05b3: pop 
				L_05b4: ldloca.s V_1
				L_05b6: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr DispatchMessage(MSG ByRef)
				L_05bb: pop 
				L_05bc: br.s L_05c0
				L_05be: ldc.i4.0 
				L_05bf: stloc.0 
				L_05c0: ldarg.0 
				L_05c1: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_05c6: brtrue.s L_05d8
				L_05c8: ldloca.s V_1
				L_05ca: ldc.i4.0 
				L_05cb: ldc.i4.0 
				L_05cc: ldc.i4.0 
				L_05cd: ldc.i4.0 
				L_05ce: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PeekMessage(MSG ByRef, Int32, UInt32, UInt32, UInt32)
				L_05d3: brtrue L_0078
				L_05d8: ldarg.0 
				L_05d9: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_05de: brfalse L_0069
				L_05e3: ldloc.2 
				L_05e4: brfalse.s L_05f1
				L_05e6: ldsfld System.IntPtr::IntPtr Zero
				L_05eb: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean ShowCaret(IntPtr)
				L_05f0: pop 
				L_05f1: ldarg.0 
				L_05f2: ldarg.0 
				L_05f3: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Int32 xb266b78561d63b52
				L_05f8: ldc.i4.m1 
				L_05f9: ldc.i4.0 
				L_05fa: ldc.i4.0 
				L_05fb: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xeb515a5b77846afe(Int32, Int32, Boolean, Boolean)
				L_0600: ldarg.0 
				L_0601: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x4139e66e6dfaac52()
				L_0606: ldarg.0 
				L_0607: callvirt System.Windows.Forms.NativeWindow::Void DestroyHandle()
				L_060c: ldarg.0 
				L_060d: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 xb13f2de377f27597
				L_0612: brtrue.s L_0634
				L_0614: ldarg.0 
				L_0615: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_061a: brfalse.s L_0634
				L_061c: ldarg.0 
				L_061d: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x37f2fc2a7f30f790
				L_0622: brtrue.s L_0634
				L_0624: ldarg.0 
				L_0625: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_062a: ldsfld System.EventArgs::System.EventArgs Empty
				L_062f: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnClick(System.EventArgs)
				L_0634: ldarg.0 
				L_0635: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x4547ebd0fd2a7079
				L_063a: stloc.s V_15
				L_063c: leave.s L_0644
				L_063e: pop 
				L_063f: ldnull 
				L_0640: stloc.s V_15
				L_0642: leave.s L_0644
				L_0644: ldloc.s V_15
				L_0646: ret 
			*/
			
			
			{
				bool b1;
				x40255b11ef821fa3.MSG mSG1;
				bool b2;
				bool b3;
				int i1;
				int i2;
				x555516122dcc901e.POINT pOINT1;
				x902c4aee45bfd906 x902c4aee45bfd906_1;
				x555516122dcc901e.POINT pOINT2;
				x555516122dcc901e.POINT pOINT3;
				x902c4aee45bfd906 x902c4aee45bfd906_2;
				x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				int i3;
				x2cc390e9409b0f3f x2cc390e9409b0f3f2;
				x40255b11ef821fa3.MSG mSG2;
				x5f4b657f68f87baa x5f4b657f68f87baa1;
				int i4;
				try
				{
					this.x4547ebd0fd2a7079 = ((x5f4b657f68f87baa) null);
					this.xb266b78561d63b52 = -1;
					this.x9a75ed38d1972c87 = false;
					this.x753f06f9b5cd6e0d = false;
					this.x0cd2bb383a46f073 = 0;
					b1 = false;
					this.x20ad2840ee62b6a4 = true;
					this.xa1715c5212ff8a33 ();
					mSG1 = new x40255b11ef821fa3.MSG ();
					if (xacc37ebdd71fcc44)
					{
						bool b4 = this.x5b2e42a68d835b31 ();
					}
					IntPtr intPtr1 = x61467fe65a98f20c.SetCursor (x61467fe65a98f20c.LoadCursor (IntPtr.Zero, 32512));
					b2 = x61467fe65a98f20c.HideCaret (IntPtr.Zero);
					goto L_05D8;
					
				L_0543:
					
					{
					}
					if ((mSG1.message == 256) || ((mSG1.message == 257) || ((mSG1.message == 260) || (mSG1.message == 261))))
					{
						b3 = true;
					}
					if (b3)
					{
						mSG2 = new x40255b11ef821fa3.MSG ();
						bool b7 = x61467fe65a98f20c.GetMessage (ref mSG2, IntPtr.Zero, uint.MinValue, uint.MinValue);
					}
					else if (b1)
					{
						b1 = false;
					}
					else if (x61467fe65a98f20c.GetMessage (ref mSG1, IntPtr.Zero, uint.MinValue, uint.MinValue))
					{
						bool b8 = x61467fe65a98f20c.TranslateMessage (ref mSG1);
						IntPtr intPtr2 = x61467fe65a98f20c.DispatchMessage (ref mSG1);
					}
					
				L_05C0:
					
					{
					}
					if ((! this.x9a75ed38d1972c87) && x61467fe65a98f20c.PeekMessage (ref mSG1, 0, uint.MinValue, uint.MinValue, uint.MinValue))
					{
						b3 = false;
						i1 = (this.x86ef051842f1ae49.Width - x902c4aee45bfd906._x13d4cb8d1bd20347[0, 16]);
						i2 = (this.x86ef051842f1ae49.Height - x902c4aee45bfd906._x13d4cb8d1bd20347[0, 17]);
						if ((mSG1.message == 514) || ((mSG1.message == 520) || ((mSG1.message == 517) || ((mSG1.message == 524) || ((mSG1.message == 162) || ((mSG1.message == 168) || ((mSG1.message == 165) || (mSG1.message == 172))))))))
						{
							if (((((pOINT1 = this.x4b688849d80162f6 (mSG1)).x < this.x6941e4b46c92846d.X) || (pOINT1.x > (this.x6941e4b46c92846d.X + i1))) || (pOINT1.y < this.x6941e4b46c92846d.Y)) || (pOINT1.y > (this.x6941e4b46c92846d.Y + i2)))
							{
								x902c4aee45bfd906_1 = this.x3c6f7570c20e3f7d (pOINT1, ref mSG1);
								if (x902c4aee45bfd906_1 != null)
								{
									x902c4aee45bfd906_1.xd6cfa3f3f3125e82 (pOINT1.x, pOINT1.y);
									b3 = true;
								}
							}
							else
							{
								this.xd6cfa3f3f3125e82 (pOINT1.x, pOINT1.y);
								b3 = true;
							}
						}
						if ((mSG1.message == 513) || ((mSG1.message == 519) || ((mSG1.message == 516) || ((mSG1.message == 523) || ((mSG1.message == 161) || ((mSG1.message == 167) || ((mSG1.message == 164) || (mSG1.message == 171))))))))
						{
							if (((((pOINT2 = this.x4b688849d80162f6 (mSG1)).x >= this.x6941e4b46c92846d.X) && (pOINT2.x <= (this.x6941e4b46c92846d.X + i1))) && (pOINT2.y >= this.x6941e4b46c92846d.Y)) && (pOINT2.y <= (this.x6941e4b46c92846d.Y + i2)))
							{
								b3 = true;
							}
							else if (this.x3c6f7570c20e3f7d (pOINT2, ref mSG1) != null)
							{
								b3 = true;
							}
							else if (! this.x277ff37e12aff68b (pOINT2, ref mSG1))
							{
								this.x9a75ed38d1972c87 = true;
								b1 = true;
								if ((this.x37f2fc2a7f30f790 != null) && (mSG1.hwnd == this.x37f2fc2a7f30f790.Handle))
								{
									b1 = false;
								}
							}
							else
							{
								this.x37f2fc2a7f30f790.x2ea07c3ab5d970d4 (pOINT2);
								b3 = true;
							}
						}
						if (mSG1.message == 512)
						{
							if (((((pOINT3 = this.x4b688849d80162f6 (mSG1)).x >= this.x6941e4b46c92846d.X) && (pOINT3.x <= (this.x6941e4b46c92846d.X + i1))) && (pOINT3.y >= this.x6941e4b46c92846d.Y)) && (pOINT3.y <= (this.x6941e4b46c92846d.Y + i2)))
							{
								this.x136735fdfe6d04ea (pOINT3.x, pOINT3.y);
							}
							else
							{
								if (this.x753f06f9b5cd6e0d)
								{
									this.xa84c74b103039157 ();
								}
								x902c4aee45bfd906_2 = this.x3c6f7570c20e3f7d (pOINT3, ref mSG1);
								if (x902c4aee45bfd906_2 != null)
								{
									x902c4aee45bfd906_2.x136735fdfe6d04ea (pOINT3.x, pOINT3.y);
								}
								else if (this.x277ff37e12aff68b (pOINT3, ref mSG1))
								{
									this.x37f2fc2a7f30f790.x136735fdfe6d04ea (pOINT3);
								}
							}
							b3 = true;
						}
						if (mSG1.message == 32)
						{
							this.x773209141f430902 ();
							b3 = true;
						}
						if (mSG1.message == 260)
						{
							if (((int) mSG1.wParam) != 18)
							{
								mSG1.message = 256;
							}
							else
							{
								this.x9a75ed38d1972c87 = true;
							}
						}
						if (mSG1.message == 256)
						{
							i4 = ((int) mSG1.wParam);
							if (i4 != 13)
							{
								if (i4 == 27)
								{
									this.x9a75ed38d1972c87 = true;
								}
								else
								{
									switch (i4)
									{
										case 37:
										
										{
												this.x0e37e200024f43ba ();
												goto L_0543;
										}
										case 38:
										
										{
												bool b5 = this.x5437d760e9a6340b ();
												goto L_0543;
										}
										case 39:
										
										{
												if (! this.xb2aa7fc859b3d5b7 ())
												{
													goto L_0543;
												}
												b1 = true;
												goto L_0543;
										}
										case 40:
										
										{
												bool b6 = this.x5b2e42a68d835b31 ();
												goto L_0543;
										}
									}
									i3 = this.x65c1cc54cc8b0e75 (((char) ((UInt16) ((int) mSG1.wParam))));
									if (i3 != -1)
									{
										x2cc390e9409b0f3f2 = (this.xfb5697071ce83988[i3] as x2cc390e9409b0f3f);
										this.x4547ebd0fd2a7079 = x2cc390e9409b0f3f2.x5f4b657f68f87baa;
										this.x9a75ed38d1972c87 = true;
										b1 = true;
									}
								}
							}
							else if (this.xb266b78561d63b52 != -1)
							{
								x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[this.xb266b78561d63b52] as x2cc390e9409b0f3f);
								if (x2cc390e9409b0f3f1.x649e2ad374251b5f)
								{
									this.x0760506d6abf77a2 (this.xb266b78561d63b52, false);
									b1 = true;
								}
								else if (! x2cc390e9409b0f3f1.xc1facdb08ad4967a)
								{
									this.x4547ebd0fd2a7079 = x2cc390e9409b0f3f1.x5f4b657f68f87baa;
									this.x9a75ed38d1972c87 = true;
								}
								else
								{
									this.x057464a452da34b7 ();
								}
							}
						}
						goto L_0543;
					}
					
				L_05D8:
					
					{
					}
					while (! this.x9a75ed38d1972c87)
					{
						if (! x61467fe65a98f20c.WaitMessage ())
						{
							continue;
						}
						goto L_05C0;
					}
					if (b2)
					{
						bool b9 = x61467fe65a98f20c.ShowCaret (IntPtr.Zero);
					}
					this.xeb515a5b77846afe (this.xb266b78561d63b52, -1, false, false);
					this.x4139e66e6dfaac52 ();
					this.DestroyHandle ();
					if (((this.xb13f2de377f27597 == null) && (this.x4547ebd0fd2a7079 != null)) && (this.x37f2fc2a7f30f790 == null))
					{
						this.x4547ebd0fd2a7079.OnClick (EventArgs.Empty);
					}
					x5f4b657f68f87baa1 = this.x4547ebd0fd2a7079;
				}
				catch (Exception)
				{
					x5f4b657f68f87baa1 = ((x5f4b657f68f87baa) null);
				}
				return x5f4b657f68f87baa1;
			}
			
			public void xf2996a13c26d70bb ()
			
			/*
				// Code Size: 82 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0006: ldsfld System.IntPtr::IntPtr Zero
				L_000b: call System.IntPtr::Boolean op_Inequality(IntPtr, IntPtr)
				L_0010: brfalse.s L_0051
				L_0012: ldarg.0 
				L_0013: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::System.Windows.Forms.Timer x420067493d7ebb36
				L_0018: callvirt System.Windows.Forms.Timer::Void Stop()
				L_001d: ldarg.0 
				L_001e: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_0023: brfalse.s L_0030
				L_0025: ldarg.0 
				L_0026: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x5142fa1a3d9591c8
				L_002b: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xf2996a13c26d70bb()
				L_0030: ldarg.0 
				L_0031: ldc.i4.1 
				L_0032: stfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Boolean x9a75ed38d1972c87
				L_0037: ldarg.0 
				L_0038: call Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void x4139e66e6dfaac52()
				L_003d: ldarg.0 
				L_003e: call System.Windows.Forms.NativeWindow::IntPtr get_Handle()
				L_0043: ldarg.0 
				L_0044: ldfld Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::UInt32 x325954b88ff83482
				L_0049: ldc.i4.0 
				L_004a: ldc.i4.0 
				L_004b: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_0050: pop 
				L_0051: ret 
			*/
			
			
			{
				if (base.Handle != IntPtr.Zero)
				{
					this.x420067493d7ebb36.Stop ();
					if (this.x5142fa1a3d9591c8 != null)
					{
						this.x5142fa1a3d9591c8.xf2996a13c26d70bb ();
					}
					this.x9a75ed38d1972c87 = true;
					this.x4139e66e6dfaac52 ();
					bool b1 = x61467fe65a98f20c.PostMessage (base.Handle, this.x325954b88ff83482, uint.MinValue, uint.MinValue);
				}
			}
			
			protected void xfbe050c2d5b2be39 (ArrayList x607ab5024f65c83d, int xc529a6810c5d3b0c)
			
			/*
				// Code Size: 95 Bytes
				.maxstack 7
				.locals (Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_0, 
         System.Drawing.Rectangle V_1, 
         System.Collections.IEnumerator V_2, 
         System.IDisposable V_3)
				.try L_0007 to L_0047 finally L_0047 to L_0058
				L_0000: ldarg.1 
				L_0001: callvirt System.Collections.ArrayList::System.Collections.IEnumerator GetEnumerator()
				L_0006: stloc.2 
				L_0007: br.s L_003d
				L_0009: ldloc.2 
				L_000a: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_000f: castclass Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0014: stloc.0 
				L_0015: ldloc.0 
				L_0016: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_001b: stloc.1 
				L_001c: ldloc.0 
				L_001d: ldloca.s V_1
				L_001f: call System.Drawing.Rectangle::Int32 get_Left()
				L_0024: ldloca.s V_1
				L_0026: call System.Drawing.Rectangle::Int32 get_Top()
				L_002b: ldarg.2 
				L_002c: ldloca.s V_1
				L_002e: call System.Drawing.Rectangle::Int32 get_Height()
				L_0033: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0038: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void set_xee63d905da8ff550(System.Drawing.Rectangle)
				L_003d: ldloc.2 
				L_003e: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0043: brtrue.s L_0009
				L_0045: leave.s L_0058
				L_0047: ldloc.2 
				L_0048: isinst System.IDisposable
				L_004d: stloc.3 
				L_004e: ldloc.3 
				L_004f: brfalse.s L_0057
				L_0051: ldloc.3 
				L_0052: callvirt System.IDisposable::Void Dispose()
				L_0057: endfinally 
				L_0058: ldarg.1 
				L_0059: callvirt System.Collections.ArrayList::Void Clear()
				L_005e: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				foreach (x2cc390e9409b0f3f x2cc390e9409b0f3f1 in x607ab5024f65c83d)
				{
					x2cc390e9409b0f3f1.xee63d905da8ff550 = new Rectangle ((rectangle1 = x2cc390e9409b0f3f1.xee63d905da8ff550).Left, rectangle1.Top, xc529a6810c5d3b0c, rectangle1.Height);
				}
				x607ab5024f65c83d.Clear ();
			}
			
		#endregion
	}
	
}

