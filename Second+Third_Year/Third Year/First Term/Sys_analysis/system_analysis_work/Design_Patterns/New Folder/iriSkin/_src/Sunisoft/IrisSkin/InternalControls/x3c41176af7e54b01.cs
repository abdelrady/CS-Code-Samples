//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin.InternalControls

{
		
		#region Namespace Import Declarations
		
			using Microsoft.Win32;
			using Sunisoft.IrisSkin;
			using System.Collections;
			using System.ComponentModel;
			using System.Drawing;
			using System.Drawing.Drawing2D;
			using System.Drawing.Imaging;
			using System.Drawing.Text;
			using System;
			using System.Windows.Forms;
			using System.Windows.Forms.Layout;
			
			
		#endregion
		
	[ToolboxItemAttribute(false)]
	internal class x3c41176af7e54b01 : ContainerControl, IMessageFilter
	
	{
		
		#region Fields
			protected bool x0544f423fd242fb5;
			protected x5d3356d9dffccb60 x0abc55e6ce1d8aed;
			protected bool x0bd7b802cb5b7f60;
			protected const int x103c8ce5ef1d254b = 3;
			protected const int x14f06f15f879a21b = 3;
			protected const int x1a7fa6ebfd3fbf92 = 4;
			protected bool x20ad2840ee62b6a4;
			protected xdbfa333b4cd503e0 x23e85093ba3a7d1d;
			protected x5d3356d9dffccb60 x26e80f23e22a05ae;
			protected const int x2a07023374a3780a = 0;
			protected x5d3356d9dffccb60 x2c6deb5021c80299;
			protected bool x44d0011ba55ea8a3;
			protected bool x466f602f66763da5;
			private x5f4b657f68f87baa[] x4dedac25f8166fb5;
			protected x3c41176af7e54b01 x5142fa1a3d9591c8;
			protected const int x520c06ceffdd8b71 = 2;
			private x5f4b657f68f87baa x54f4e17b11b07b8c;
			protected int x55f9f93541a6b942;
			protected Form x562fa9742b4f7ed5;
			protected x902c4aee45bfd906 x56be4c3c4c4173b7;
			protected const int x5d78a9cbd24757c2 = 1;
			protected bool x604ddcdfda178b5a;
			protected x5f4b657f68f87baa x63fd40b32f4be51f;
			protected const int x699c345cbebd98c7 = 1;
			protected bool x72c40adab6f1d6f3;
			protected const int x7397ebd1f93bd8d5 = 3;
			protected bool x753f06f9b5cd6e0d;
			protected bool x84eb9aff9c47a6a3;
			protected int x8d677ea3c0d5a202;
			protected bool x9a75ed38d1972c87;
			protected static bool x9c8c46cd7553cd2b;
			protected bool x9f93ebd2ca5601a2;
			protected const int xa0976f1af9b36a0d = 2;
			protected x6fd23f8bad2f3ced xa11bc1c36fce21ec;
			protected const int xa66fabc27b099482 = 16;
			protected x1f5697535eab37b9 xa89034e65472167c;
			public event x26569a56dfbc2c6d xaa7558c320af04eb;
			protected Form xabf8437cf3c2cf0a;
			protected bool xacac6b5ffdf089d3;
			protected int xb266b78561d63b52;
			protected xc69458cec0f3af75 xb774af5110e814a9;
			protected bool xc316f3c6d490f56e;
			private ISkinEngine xcab6a0e662ada486;
			protected const int xd01119114fc2f8ab = 4;
			protected bool xd2893b73a80bf998;
			protected int xd3f2e0aa29e1f6c9;
			public event x26569a56dfbc2c6d xd42ce0324cbc114a;
			protected const int xd4c76c2b501b27be = 2;
			protected IntPtr xd69b8149dec0109a;
			protected readonly uint xd8f9b747f716862a;
			protected const int xdbde68be47237aff = 48;
			protected int xe6d633b23b7c9bfe;
			protected const int xe9eb62cc8276fe1e = 12;
			protected xd53b20b7b4b2a08a xf4f555905eaa2330;
			protected bool xf947c341af20623c;
			protected ArrayList xfb5697071ce83988;
			protected const int xfd183ee3cea1c2de = 15;
			protected static ImageList xfeae2ed797ae6fbc;
		#endregion
		
		#region Constructors
		
			static x3c41176af7e54b01 ()
			/*
				// Code Size: 80 Bytes
				.maxstack 7
				L_0000: ldnull 
				L_0001: stsfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.ImageList xfeae2ed797ae6fbc
				L_0006: ldc.i4.0 
				L_0007: stsfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9c8c46cd7553cd2b
				L_000c: ldstr "Sunisoft.IrisSkin.SkinEngine"
				L_0011: call System.Type::System.Type GetType(System.String)
				L_0016: ldstr "Sunisoft.IrisSkin.ImagesMenuControl.bmp"
				L_001b: ldc.i4.s 16
				L_001d: ldc.i4.s 16
				L_001f: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_0024: ldc.i4.0 
				L_0025: ldc.i4.0 
				L_0026: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_002b: call Sunisoft.IrisSkin.InternalControls.x58dd58a96343fde0::System.Windows.Forms.ImageList xd1601e45c3cc2056(System.Type, System.String, System.Drawing.Size, System.Drawing.Point)
				L_0030: stsfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.ImageList xfeae2ed797ae6fbc
				L_0035: call System.Windows.Forms.OSFeature::System.Windows.Forms.OSFeature get_Feature()
				L_003a: ldsfld System.Windows.Forms.OSFeature::System.Object LayeredWindows
				L_003f: callvirt System.Windows.Forms.FeatureSupport::System.Version GetVersionPresent(System.Object)
				L_0044: ldnull 
				L_0045: call System.Version::Boolean op_Inequality(System.Version, System.Version)
				L_004a: stsfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9c8c46cd7553cd2b
				L_004f: ret 
			*/
			
			public x3c41176af7e54b01 (ISkinEngine engine)
			/*
				// Code Size: 495 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: ldc.i4 1025
				L_0006: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::UInt32 xd8f9b747f716862a
				L_000b: ldarg.0 
				L_000c: ldstr "-"
				L_0011: newobj Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void .ctor(System.String)
				L_0016: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x54f4e17b11b07b8c
				L_001b: ldarg.0 
				L_001c: call System.Windows.Forms.ContainerControl::Void .ctor()
				L_0021: ldarg.0 
				L_0022: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x54f4e17b11b07b8c
				L_0027: ldc.i4.1 
				L_0028: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xb2504b89d66feca9
				L_002d: ldarg.0 
				L_002e: ldarg.1 
				L_002f: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void set_xdc87e2b99332cd4a(Sunisoft.IrisSkin.SkinEngine)
				L_0034: ldarg.0 
				L_0035: ldc.i4.m1 
				L_0036: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_003b: ldarg.0 
				L_003c: ldsfld System.IntPtr::IntPtr Zero
				L_0041: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::IntPtr xd69b8149dec0109a
				L_0046: ldarg.0 
				L_0047: ldnull 
				L_0048: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_004d: ldarg.0 
				L_004e: ldnull 
				L_004f: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0054: ldarg.0 
				L_0055: ldnull 
				L_0056: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_005b: ldarg.0 
				L_005c: ldnull 
				L_005d: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_0062: ldarg.0 
				L_0063: ldnull 
				L_0064: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
				L_0069: ldarg.0 
				L_006a: ldnull 
				L_006b: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_0070: ldarg.0 
				L_0071: ldnull 
				L_0072: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x63fd40b32f4be51f
				L_0077: ldarg.0 
				L_0078: ldc.i4.1 
				L_0079: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x20ad2840ee62b6a4
				L_007e: ldarg.0 
				L_007f: ldc.i4.0 
				L_0080: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9a75ed38d1972c87
				L_0085: ldarg.0 
				L_0086: ldc.i4.0 
				L_0087: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_008c: ldarg.0 
				L_008d: ldc.i4.0 
				L_008e: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x0544f423fd242fb5
				L_0093: ldarg.0 
				L_0094: ldc.i4.0 
				L_0095: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x753f06f9b5cd6e0d
				L_009a: ldarg.0 
				L_009b: ldc.i4.1 
				L_009c: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xacac6b5ffdf089d3
				L_00a1: ldarg.0 
				L_00a2: ldc.i4.0 
				L_00a3: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x44d0011ba55ea8a3
				L_00a8: ldarg.0 
				L_00a9: ldc.i4.0 
				L_00aa: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xf947c341af20623c
				L_00af: ldarg.0 
				L_00b0: ldc.i4.0 
				L_00b1: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x84eb9aff9c47a6a3
				L_00b6: ldarg.0 
				L_00b7: ldc.i4.0 
				L_00b8: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x72c40adab6f1d6f3
				L_00bd: ldarg.0 
				L_00be: ldc.i4.1 
				L_00bf: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x466f602f66763da5
				L_00c4: ldarg.0 
				L_00c5: ldc.i4.1 
				L_00c6: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x0bd7b802cb5b7f60
				L_00cb: ldarg.0 
				L_00cc: ldc.i4.1 
				L_00cd: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xc316f3c6d490f56e
				L_00d2: ldarg.0 
				L_00d3: ldc.i4.1 
				L_00d4: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x604ddcdfda178b5a
				L_00d9: ldarg.0 
				L_00da: ldc.i4.0 
				L_00db: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xd2893b73a80bf998
				L_00e0: ldarg.0 
				L_00e1: ldc.i4.1 
				L_00e2: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_00e7: ldarg.0 
				L_00e8: newobj Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Void .ctor()
				L_00ed: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_00f2: ldarg.0 
				L_00f3: ldc.i4.1 
				L_00f4: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xc69458cec0f3af75 xb774af5110e814a9
				L_00f9: ldarg.0 
				L_00fa: ldc.i4.1 
				L_00fb: callvirt System.Windows.Forms.Control::Void set_Dock(System.Windows.Forms.DockStyle)
				L_0100: ldarg.0 
				L_0101: call System.Windows.Forms.Cursors::System.Windows.Forms.Cursor get_Arrow()
				L_0106: callvirt System.Windows.Forms.Control::Void set_Cursor(System.Windows.Forms.Cursor)
				L_010b: ldarg.0 
				L_010c: ldc.i4.s 100
				L_010e: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 x8d677ea3c0d5a202
				L_0113: ldarg.0 
				L_0114: ldc.i4.2 
				L_0115: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced xa11bc1c36fce21ec
				L_011a: ldarg.0 
				L_011b: ldc.i4 1048576
				L_0120: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x1f5697535eab37b9 xa89034e65472167c
				L_0125: ldarg.0 
				L_0126: ldc.i4 73730
				L_012b: ldc.i4.1 
				L_012c: call System.Windows.Forms.Control::Void SetStyle(System.Windows.Forms.ControlStyles, Boolean)
				L_0131: ldarg.0 
				L_0132: ldc.i4 512
				L_0137: ldc.i4.0 
				L_0138: call System.Windows.Forms.Control::Void SetStyle(System.Windows.Forms.ControlStyles, Boolean)
				L_013d: ldarg.0 
				L_013e: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0143: ldarg.0 
				L_0144: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x4d43bed1b4aede85()
				L_014a: newobj Sunisoft.IrisSkin.InternalControls.x66edf89974942dab::Void .ctor(System.Object, IntPtr)
				L_014f: callvirt Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Void add_xebadb072f5851c44(Sunisoft.IrisSkin.InternalControls.x66edf89974942dab)
				L_0154: ldarg.0 
				L_0155: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_015a: ldarg.0 
				L_015b: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x6b08695ba39cf4ca(Int32, System.Object)
				L_0161: newobj Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c::Void .ctor(System.Object, IntPtr)
				L_0166: callvirt Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Void add_xb1acec69632d2193(Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c)
				L_016b: ldarg.0 
				L_016c: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0171: ldarg.0 
				L_0172: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x5cb0c63a7cf35b53(Int32, System.Object)
				L_0178: newobj Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c::Void .ctor(System.Object, IntPtr)
				L_017d: callvirt Sunisoft.IrisSkin.InternalControls.x81f0e41c32f52159::Void add_xb56f44eae6e354a0(Sunisoft.IrisSkin.InternalControls.x2f6aff803d60b50c)
				L_0182: ldarg.0 
				L_0183: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x288bea726e7cd27e(System.Object, Microsoft.Win32.UserPreferenceChangedEventArgs)
				L_0189: newobj Microsoft.Win32.UserPreferenceChangedEventHandler::Void .ctor(System.Object, IntPtr)
				L_018e: call Microsoft.Win32.SystemEvents::Void add_UserPreferenceChanged(Microsoft.Win32.UserPreferenceChangedEventHandler)
				L_0193: ldarg.0 
				L_0194: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0199: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font get_MenuFont()
				L_019e: brtrue.s L_01ad
				L_01a0: ldarg.0 
				L_01a1: call System.Windows.Forms.SystemInformation::System.Drawing.Font get_MenuFont()
				L_01a6: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x21498b72da0020ba(System.Drawing.Font)
				L_01ab: br.s L_01be
				L_01ad: ldarg.0 
				L_01ae: ldarg.0 
				L_01af: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_01b4: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font get_MenuFont()
				L_01b9: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x21498b72da0020ba(System.Drawing.Font)
				L_01be: ldarg.0 
				L_01bf: ldc.i4.0 
				L_01c0: call System.Windows.Forms.Control::Void set_TabStop(Boolean)
				L_01c5: ldarg.0 
				L_01c6: ldarg.0 
				L_01c7: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xd3f2e0aa29e1f6c9
				L_01cc: call System.Windows.Forms.Control::Void set_Height(Int32)
				L_01d1: ldarg.0 
				L_01d2: call System.Windows.Forms.Application::Void AddMessageFilter(System.Windows.Forms.IMessageFilter)
				L_01d7: ldarg.0 
				L_01d8: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_01dd: ldarg.0 
				L_01de: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x273cbe3cfa28ea94(System.Object, Sunisoft.IrisSkin.SkinChangedEventArgs)
				L_01e4: newobj Sunisoft.IrisSkin.SkinChanged::Void .ctor(System.Object, IntPtr)
				L_01e9: callvirt Sunisoft.IrisSkin.SkinEngine::Void add_CurrentSkinChanged(Sunisoft.IrisSkin.SkinChanged)
				L_01ee: ret 
			*/
		#endregion
		
		#region Properties
		
			public override DockStyle Dock
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: call System.Windows.Forms.Control::System.Windows.Forms.DockStyle get_Dock()
					L_0006: ret 
				*/
				
				{
					return base.Dock;
				}
				set
				
				/*
					// Code Size: 89 Bytes
					.maxstack 3
					.locals (System.Windows.Forms.DockStyle V_0)
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: call System.Windows.Forms.Control::Void set_Dock(System.Windows.Forms.DockStyle)
					L_0007: ldarg.1 
					L_0008: stloc.0 
					L_0009: ldloc.0 
					L_000a: switch (L_0025, L_002e, L_002e, L_003e, L_003e)
					L_0023: br.s L_004c
					L_0025: ldarg.0 
					L_0026: ldc.i4.1 
					L_0027: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
					L_002c: br.s L_004c
					L_002e: ldarg.0 
					L_002f: ldc.i4.0 
					L_0030: call System.Windows.Forms.Control::Void set_Height(Int32)
					L_0035: ldarg.0 
					L_0036: ldc.i4.1 
					L_0037: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
					L_003c: br.s L_004c
					L_003e: ldarg.0 
					L_003f: ldc.i4.0 
					L_0040: call System.Windows.Forms.Control::Void set_Width(Int32)
					L_0045: ldarg.0 
					L_0046: ldc.i4.0 
					L_0047: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
					L_004c: ldarg.0 
					L_004d: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
					L_0052: ldarg.0 
					L_0053: call System.Windows.Forms.Control::Void Invalidate()
					L_0058: ret 
				*/
				
				{
					base.Dock = value;
					DockStyle dockStyle1 = value;
					switch (dockStyle1)
					{
						case DockStyle.None:
						
						{
								this.x23e85093ba3a7d1d = Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da;
								break;
						}
						case DockStyle.Top:
						case DockStyle.Bottom:
						
						{
								base.Height = 0;
								this.x23e85093ba3a7d1d = Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da;
								break;
						}
						case DockStyle.Left:
						case DockStyle.Right:
						
						{
								base.Width = 0;
								this.x23e85093ba3a7d1d = Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x61c108cc44ef385a;
								break;
						}
					}
					this.x39e008704a72ea56 ();
					base.Invalidate ();
				}
			}
			
			
			public override Font Font
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: call System.Windows.Forms.Control::System.Drawing.Font get_Font()
					L_0006: ret 
				*/
				
				{
					return base.Font;
				}
				set
				
				/*
					// Code Size: 43 Bytes
					.maxstack 9
					L_0000: ldarg.1 
					L_0001: ldarg.0 
					L_0002: call System.Windows.Forms.Control::System.Drawing.Font get_Font()
					L_0007: beq.s L_002a
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: call System.Windows.Forms.SystemInformation::System.Drawing.Font get_MenuFont()
					L_0010: ceq 
					L_0012: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xacac6b5ffdf089d3
					L_0017: ldarg.0 
					L_0018: ldarg.1 
					L_0019: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x21498b72da0020ba(System.Drawing.Font)
					L_001e: ldarg.0 
					L_001f: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
					L_0024: ldarg.0 
					L_0025: call System.Windows.Forms.Control::Void Invalidate()
					L_002a: ret 
				*/
				
				{
					if (value != base.Font)
					{
						this.xacac6b5ffdf089d3 = (value == SystemInformation.MenuFont);
						this.x21498b72da0020ba (value);
						this.x39e008704a72ea56 ();
						base.Invalidate ();
					}
				}
			}
			
			
			public bool x0807568b882d7989
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x0544f423fd242fb5
					L_0006: ret 
				*/
				
				{
					return this.x0544f423fd242fb5;
				}
				set
				
				/*
					// Code Size: 29 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x0544f423fd242fb5
					L_0006: ldarg.1 
					L_0007: beq.s L_001c
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x0544f423fd242fb5
					L_0010: ldarg.0 
					L_0011: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
					L_0016: ldarg.0 
					L_0017: call System.Windows.Forms.Control::Void Invalidate()
					L_001c: ret 
				*/
				
				{
					if (this.x0544f423fd242fb5 != value)
					{
						this.x0544f423fd242fb5 = value;
						this.x39e008704a72ea56 ();
						base.Invalidate ();
					}
				}
			}
			
			
			public bool x1f045c9de3a60a02
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x604ddcdfda178b5a
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
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x604ddcdfda178b5a
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
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xc316f3c6d490f56e
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
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xc316f3c6d490f56e
					L_0007: ret 
				*/
				
				{
					this.xc316f3c6d490f56e = value;
				}
			}
			
			
			public bool x58db5498ab76b22e
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x0bd7b802cb5b7f60
					L_0006: ret 
				*/
				
				{
					return this.x0bd7b802cb5b7f60;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x0bd7b802cb5b7f60
					L_0007: ret 
				*/
				
				{
					this.x0bd7b802cb5b7f60 = value;
				}
			}
			
			
			public bool x5e141c724f46f107
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x466f602f66763da5
					L_0006: ret 
				*/
				
				{
					return this.x466f602f66763da5;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x466f602f66763da5
					L_0007: ret 
				*/
				
				{
					this.x466f602f66763da5 = value;
				}
			}
			
			
			public xd53b20b7b4b2a08a x6ef5a4a9a9587cfd
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
					L_0006: ret 
				*/
				
				{
					return this.xf4f555905eaa2330;
				}
			}
			
			
			public x6fd23f8bad2f3ced x6fd23f8bad2f3ced
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced xa11bc1c36fce21ec
					L_0006: ret 
				*/
				
				{
					return this.xa11bc1c36fce21ec;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced xa11bc1c36fce21ec
					L_0007: ret 
				*/
				
				{
					this.xa11bc1c36fce21ec = value;
				}
			}
			
			
			public int x742a8c15ee195ce2
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 x8d677ea3c0d5a202
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
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 x8d677ea3c0d5a202
					L_0007: ret 
				*/
				
				{
					this.x8d677ea3c0d5a202 = value;
				}
			}
			
			
			public bool x995a3e87f95d7473
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x84eb9aff9c47a6a3
					L_0006: ret 
				*/
				
				{
					return this.x84eb9aff9c47a6a3;
				}
				set
				
				/*
					// Code Size: 29 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x84eb9aff9c47a6a3
					L_0006: ldarg.1 
					L_0007: beq.s L_001c
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x84eb9aff9c47a6a3
					L_0010: ldarg.0 
					L_0011: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
					L_0016: ldarg.0 
					L_0017: call System.Windows.Forms.Control::Void Invalidate()
					L_001c: ret 
				*/
				
				{
					if (this.x84eb9aff9c47a6a3 != value)
					{
						this.x84eb9aff9c47a6a3 = value;
						this.x39e008704a72ea56 ();
						base.Invalidate ();
					}
				}
			}
			
			
			public x1f5697535eab37b9 xa743c350e27e50b4
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x1f5697535eab37b9 xa89034e65472167c
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
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x1f5697535eab37b9 xa89034e65472167c
					L_0007: ret 
				*/
				
				{
					this.xa89034e65472167c = value;
				}
			}
			
			
			public xc69458cec0f3af75 xc69458cec0f3af75
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xc69458cec0f3af75 xb774af5110e814a9
					L_0006: ret 
				*/
				
				{
					return this.xb774af5110e814a9;
				}
				set
				
				/*
					// Code Size: 8 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldarg.1 
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xc69458cec0f3af75 xb774af5110e814a9
					L_0007: ret 
				*/
				
				{
					this.xb774af5110e814a9 = value;
				}
			}
			
			
			public Form xd8e8992926cad390
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
					L_0006: ret 
				*/
				
				{
					return this.xabf8437cf3c2cf0a;
				}
				set
				
				/*
					// Code Size: 99 Bytes
					.maxstack 5
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
					L_0006: ldarg.1 
					L_0007: beq.s L_0062
					L_0009: ldarg.0 
					L_000a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
					L_000f: brfalse.s L_002e
					L_0011: ldarg.0 
					L_0012: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
					L_0017: ldarg.0 
					L_0018: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x23daf02978257d54(System.Object, System.EventArgs)
					L_001e: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
					L_0023: callvirt System.Windows.Forms.Form::Void remove_MdiChildActivate(System.EventHandler)
					L_0028: ldarg.0 
					L_0029: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xb73b905145ee3f9f()
					L_002e: ldarg.0 
					L_002f: ldarg.1 
					L_0030: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
					L_0035: ldarg.0 
					L_0036: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
					L_003b: brfalse.s L_0062
					L_003d: ldarg.0 
					L_003e: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x9954cbb39675570d()
					L_0043: ldarg.0 
					L_0044: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
					L_0049: ldarg.0 
					L_004a: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x23daf02978257d54(System.Object, System.EventArgs)
					L_0050: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
					L_0055: callvirt System.Windows.Forms.Form::Void add_MdiChildActivate(System.EventHandler)
					L_005a: ldarg.0 
					L_005b: ldnull 
					L_005c: ldnull 
					L_005d: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x23daf02978257d54(System.Object, System.EventArgs)
					L_0062: ret 
				*/
				
				{
					if (this.xabf8437cf3c2cf0a != value)
					{
						if (this.xabf8437cf3c2cf0a != null)
						{
							this.xabf8437cf3c2cf0a.MdiChildActivate -= new EventHandler (this.x23daf02978257d54);
							this.xb73b905145ee3f9f ();
						}
						this.xabf8437cf3c2cf0a = value;
						if (this.xabf8437cf3c2cf0a != null)
						{
							this.x9954cbb39675570d ();
							this.xabf8437cf3c2cf0a.MdiChildActivate += new EventHandler (this.x23daf02978257d54);
							this.x23daf02978257d54 (null, ((EventArgs) null));
						}
					}
				}
			}
			
			
			public xdbfa333b4cd503e0 xdbfa333b4cd503e0
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
					L_0006: ret 
				*/
				
				{
					return this.x23e85093ba3a7d1d;
				}
				set
				
				/*
					// Code Size: 29 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
					L_0006: ldarg.1 
					L_0007: beq.s L_001c
					L_0009: ldarg.0 
					L_000a: ldarg.1 
					L_000b: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
					L_0010: ldarg.0 
					L_0011: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
					L_0016: ldarg.0 
					L_0017: call System.Windows.Forms.Control::Void Invalidate()
					L_001c: ret 
				*/
				
				{
					if (this.x23e85093ba3a7d1d != value)
					{
						this.x23e85093ba3a7d1d = value;
						this.x39e008704a72ea56 ();
						base.Invalidate ();
					}
				}
			}
			
			
			public ISkinEngine xdc87e2b99332cd4a
			
			{
				get
				
				/*
					// Code Size: 7 Bytes
					.maxstack 9
					L_0000: ldarg.0 
					L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
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
					L_0002: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine xcab6a0e662ada486
					L_0007: ret 
				*/
				
				{
					this.xcab6a0e662ada486 = value;
				}
			}
			
		#endregion
		
		#region Methods
		
			protected override void Dispose (bool disposing)
			
			/*
				// Code Size: 90 Bytes
				.maxstack 5
				L_0000: ldarg.1 
				L_0001: brfalse.s L_0052
				L_0003: ldarg.0 
				L_0004: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x288bea726e7cd27e(System.Object, Microsoft.Win32.UserPreferenceChangedEventArgs)
				L_000a: newobj Microsoft.Win32.UserPreferenceChangedEventHandler::Void .ctor(System.Object, IntPtr)
				L_000f: call Microsoft.Win32.SystemEvents::Void remove_UserPreferenceChanged(Microsoft.Win32.UserPreferenceChangedEventHandler)
				L_0014: ldarg.0 
				L_0015: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
				L_001a: brfalse.s L_0033
				L_001c: ldarg.0 
				L_001d: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
				L_0022: ldarg.0 
				L_0023: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x23daf02978257d54(System.Object, System.EventArgs)
				L_0029: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_002e: callvirt System.Windows.Forms.Form::Void remove_MdiChildActivate(System.EventHandler)
				L_0033: ldarg.0 
				L_0034: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_0039: brfalse.s L_0052
				L_003b: ldarg.0 
				L_003c: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_0041: ldarg.0 
				L_0042: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xfbce0f1d6df984cd(System.Object, System.EventArgs)
				L_0048: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_004d: callvirt System.Windows.Forms.Control::Void remove_SizeChanged(System.EventHandler)
				L_0052: ldarg.0 
				L_0053: ldarg.1 
				L_0054: call System.Windows.Forms.ContainerControl::Void Dispose(Boolean)
				L_0059: ret 
			*/
			
			
			{
				if (disposing)
				{
					SystemEvents.UserPreferenceChanged -= new UserPreferenceChangedEventHandler (this.x288bea726e7cd27e);
					if (this.xabf8437cf3c2cf0a != null)
					{
						this.xabf8437cf3c2cf0a.MdiChildActivate -= new EventHandler (this.x23daf02978257d54);
					}
					if (this.x562fa9742b4f7ed5 != null)
					{
						this.x562fa9742b4f7ed5.SizeChanged -= new EventHandler (this.xfbce0f1d6df984cd);
					}
				}
				base.Dispose (disposing);
			}
			
			public virtual void OnDeselected (x5f4b657f68f87baa mc)
			
			/*
				// Code Size: 21 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d xd42ce0324cbc114a
				L_0006: brfalse.s L_0014
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d xd42ce0324cbc114a
				L_000e: ldarg.1 
				L_000f: callvirt Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d::Void Invoke(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0014: ret 
			*/
			
			
			{
				if (this.xd42ce0324cbc114a != null)
				{
					this.xd42ce0324cbc114a (mc);
				}
			}
			
			protected override void OnEnabledChanged (EventArgs e)
			
			/*
				// Code Size: 81 Bytes
				.maxstack 3
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: call System.Windows.Forms.Control::Void OnEnabledChanged(System.EventArgs)
				L_0007: ldarg.0 
				L_0008: call System.Windows.Forms.Control::Boolean get_Enabled()
				L_000d: brtrue.s L_0044
				L_000f: ldarg.0 
				L_0010: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_0015: brfalse.s L_0044
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_001d: brfalse.s L_0031
				L_001f: ldarg.0 
				L_0020: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0025: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xf2996a13c26d70bb()
				L_002a: ldarg.0 
				L_002b: ldnull 
				L_002c: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0031: ldarg.0 
				L_0032: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xcb97d93f0d5ce4a8()
				L_0037: ldarg.0 
				L_0038: ldc.i4.0 
				L_0039: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xf947c341af20623c
				L_003e: ldarg.0 
				L_003f: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xa23d095e6e52c5f3()
				L_0044: ldarg.0 
				L_0045: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x51ce8d251f940283()
				L_004a: ldarg.0 
				L_004b: call System.Windows.Forms.Control::Void Invalidate()
				L_0050: ret 
			*/
			
			
			{
				base.OnEnabledChanged (e);
				if ((! base.Enabled) && this.x9f93ebd2ca5601a2)
				{
					if (this.x56be4c3c4c4173b7 != null)
					{
						this.x56be4c3c4c4173b7.xf2996a13c26d70bb ();
						this.x56be4c3c4c4173b7 = ((x902c4aee45bfd906) null);
					}
					this.xcb97d93f0d5ce4a8 ();
					this.xf947c341af20623c = false;
					this.xa23d095e6e52c5f3 ();
				}
				this.x51ce8d251f940283 ();
				base.Invalidate ();
			}
			
			protected override void OnMouseDown (MouseEventArgs e)
			
			/*
				// Code Size: 26 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: callvirt System.Windows.Forms.MouseEventArgs::Int32 get_X()
				L_0007: ldarg.1 
				L_0008: callvirt System.Windows.Forms.MouseEventArgs::Int32 get_Y()
				L_000d: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xbcc99f3d02a70fe7(Int32, Int32)
				L_0012: ldarg.0 
				L_0013: ldarg.1 
				L_0014: call System.Windows.Forms.Control::Void OnMouseDown(System.Windows.Forms.MouseEventArgs)
				L_0019: ret 
			*/
			
			
			{
				this.xbcc99f3d02a70fe7 (e.X, e.Y);
				base.OnMouseDown (e);
			}
			
			protected override void OnMouseLeave (EventArgs e)
			
			/*
				// Code Size: 59 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.0 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x753f06f9b5cd6e0d
				L_0007: ldarg.0 
				L_0008: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x44d0011ba55ea8a3
				L_000d: brtrue.s L_0033
				L_000f: ldarg.0 
				L_0010: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0015: ldc.i4.m1 
				L_0016: beq.s L_0033
				L_0018: ldarg.0 
				L_0019: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_001e: brtrue.s L_0033
				L_0020: ldarg.0 
				L_0021: ldarg.0 
				L_0022: ldarg.0 
				L_0023: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0028: ldc.i4.m1 
				L_0029: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xa7cbddf1ec7a27e7(Int32, Int32)
				L_002e: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0033: ldarg.0 
				L_0034: ldarg.1 
				L_0035: call System.Windows.Forms.Control::Void OnMouseLeave(System.EventArgs)
				L_003a: ret 
			*/
			
			
			{
				this.x753f06f9b5cd6e0d = false;
				if (((! this.x44d0011ba55ea8a3) && (this.xb266b78561d63b52 != -1)) && (! this.x9f93ebd2ca5601a2))
				{
					this.xb266b78561d63b52 = this.xa7cbddf1ec7a27e7 (this.xb266b78561d63b52, -1);
				}
				base.OnMouseLeave (e);
			}
			
			protected override void OnMouseMove (MouseEventArgs e)
			
			/*
				// Code Size: 43 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x72c40adab6f1d6f3
				L_0006: brfalse.s L_0011
				L_0008: ldarg.0 
				L_0009: ldc.i4.0 
				L_000a: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x72c40adab6f1d6f3
				L_000f: br.s L_0023
				L_0011: ldarg.0 
				L_0012: ldarg.1 
				L_0013: callvirt System.Windows.Forms.MouseEventArgs::Int32 get_X()
				L_0018: ldarg.1 
				L_0019: callvirt System.Windows.Forms.MouseEventArgs::Int32 get_Y()
				L_001e: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xdd922e6d558c59d4(Int32, Int32)
				L_0023: ldarg.0 
				L_0024: ldarg.1 
				L_0025: call System.Windows.Forms.Control::Void OnMouseMove(System.Windows.Forms.MouseEventArgs)
				L_002a: ret 
			*/
			
			
			{
				if (this.x72c40adab6f1d6f3)
				{
					this.x72c40adab6f1d6f3 = false;
				}
				else
				{
					this.xdd922e6d558c59d4 (e.X, e.Y);
				}
				base.OnMouseMove (e);
			}
			
			protected override void OnMouseUp (MouseEventArgs e)
			
			/*
				// Code Size: 65 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0006: ldc.i4.m1 
				L_0007: beq.s L_0039
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_000f: brfalse.s L_0039
				L_0011: ldarg.0 
				L_0012: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0017: brtrue.s L_0039
				L_0019: ldarg.0 
				L_001a: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xcb97d93f0d5ce4a8()
				L_001f: ldarg.0 
				L_0020: ldc.i4.0 
				L_0021: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xf947c341af20623c
				L_0026: ldarg.0 
				L_0027: ldarg.0 
				L_0028: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_002d: ldc.i4.1 
				L_002e: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x2cc390e9409b0f3f(Int32, Boolean)
				L_0033: ldarg.0 
				L_0034: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xa23d095e6e52c5f3()
				L_0039: ldarg.0 
				L_003a: ldarg.1 
				L_003b: call System.Windows.Forms.Control::Void OnMouseUp(System.Windows.Forms.MouseEventArgs)
				L_0040: ret 
			*/
			
			
			{
				if (((this.xb266b78561d63b52 != -1) && this.x9f93ebd2ca5601a2) && (this.x56be4c3c4c4173b7 == null))
				{
					this.xcb97d93f0d5ce4a8 ();
					this.xf947c341af20623c = false;
					this.x2cc390e9409b0f3f (this.xb266b78561d63b52, true);
					this.xa23d095e6e52c5f3 ();
				}
				base.OnMouseUp (e);
			}
			
			protected override void OnPaint (PaintEventArgs e)
			
			/*
				// Code Size: 330 Bytes
				.maxstack 10
				.locals (System.Drawing.Rectangle V_0, 
         System.Drawing.Bitmap V_1, 
         System.Drawing.Bitmap V_2, 
         System.Drawing.Graphics V_3, 
         System.Drawing.Drawing2D.LinearGradientBrush V_4)
				.try L_00dd to L_00e8 finally L_00e8 to L_00f4
				.try L_0055 to L_0112 finally L_0112 to L_011c
				.try L_004e to L_012c finally L_012c to L_0136
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::Int32 get_Width()
				L_0006: brtrue.s L_0011
				L_0008: ldarg.0 
				L_0009: call System.Windows.Forms.Control::Int32 get_Height()
				L_000e: brtrue.s L_0011
				L_0010: ret 
				L_0011: ldloca.s V_0
				L_0013: ldc.i4.0 
				L_0014: ldc.i4.0 
				L_0015: ldarg.0 
				L_0016: call System.Windows.Forms.Control::Int32 get_Width()
				L_001b: ldarg.0 
				L_001c: call System.Windows.Forms.Control::Int32 get_Height()
				L_0021: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0026: ldarg.0 
				L_0027: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_002c: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0031: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0036: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_MENUBAR()
				L_003b: stloc.1 
				L_003c: ldarg.0 
				L_003d: call System.Windows.Forms.Control::Int32 get_Width()
				L_0042: ldarg.0 
				L_0043: call System.Windows.Forms.Control::Int32 get_Height()
				L_0048: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_004d: stloc.2 
				L_004e: ldloc.2 
				L_004f: call System.Drawing.Graphics::System.Drawing.Graphics FromImage(System.Drawing.Image)
				L_0054: stloc.3 
				L_0055: ldloc.1 
				L_0056: brfalse.s L_0079
				L_0058: ldloc.3 
				L_0059: ldloc.1 
				L_005a: ldloc.0 
				L_005b: ldc.i4.0 
				L_005c: ldc.i4.0 
				L_005d: ldloc.1 
				L_005e: callvirt System.Drawing.Image::Int32 get_Width()
				L_0063: ldloc.1 
				L_0064: callvirt System.Drawing.Image::Int32 get_Height()
				L_0069: ldc.i4.2 
				L_006a: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x349935d524988797()
				L_006f: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_0074: br L_0110
				L_0079: ldarg.0 
				L_007a: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_007f: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0084: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0089: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARSTARTCOLOR
				L_008e: ldarg.0 
				L_008f: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0094: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0099: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_009e: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARENDCOLOR
				L_00a3: call System.Drawing.Color::Boolean op_Inequality(System.Drawing.Color, System.Drawing.Color)
				L_00a8: brfalse.s L_00f4
				L_00aa: ldloc.0 
				L_00ab: ldarg.0 
				L_00ac: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_00b1: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00b6: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_00bb: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARSTARTCOLOR
				L_00c0: ldarg.0 
				L_00c1: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_00c6: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00cb: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_00d0: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARENDCOLOR
				L_00d5: ldc.i4.1 
				L_00d6: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Rectangle, System.Drawing.Color, System.Drawing.Color, System.Drawing.Drawing2D.LinearGradientMode)
				L_00db: stloc.s V_4
				L_00dd: ldloc.3 
				L_00de: ldloc.s V_4
				L_00e0: ldloc.0 
				L_00e1: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_00e6: leave.s L_0110
				L_00e8: ldloc.s V_4
				L_00ea: brfalse.s L_00f3
				L_00ec: ldloc.s V_4
				L_00ee: callvirt System.IDisposable::Void Dispose()
				L_00f3: endfinally 
				L_00f4: ldloc.3 
				L_00f5: ldarg.0 
				L_00f6: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_00fb: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0100: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0105: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_MENUBARSTARTCOLOR()
				L_010a: ldloc.0 
				L_010b: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0110: leave.s L_011c
				L_0112: ldloc.3 
				L_0113: brfalse.s L_011b
				L_0115: ldloc.3 
				L_0116: callvirt System.IDisposable::Void Dispose()
				L_011b: endfinally 
				L_011c: ldarg.1 
				L_011d: callvirt System.Windows.Forms.PaintEventArgs::System.Drawing.Graphics get_Graphics()
				L_0122: ldloc.2 
				L_0123: ldc.i4.0 
				L_0124: ldc.i4.0 
				L_0125: callvirt System.Drawing.Graphics::Void DrawImageUnscaled(System.Drawing.Image, Int32, Int32)
				L_012a: leave.s L_0136
				L_012c: ldloc.2 
				L_012d: brfalse.s L_0135
				L_012f: ldloc.2 
				L_0130: callvirt System.IDisposable::Void Dispose()
				L_0135: endfinally 
				L_0136: ldarg.0 
				L_0137: ldarg.1 
				L_0138: callvirt System.Windows.Forms.PaintEventArgs::System.Drawing.Graphics get_Graphics()
				L_013d: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x05a10b378cdf8119(System.Drawing.Graphics)
				L_0142: ldarg.0 
				L_0143: ldarg.1 
				L_0144: call System.Windows.Forms.Control::Void OnPaint(System.Windows.Forms.PaintEventArgs)
				L_0149: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				if ((base.Width == 0) && (base.Height == 0))
				{
					return;
				}
				rectangle1 = new Rectangle (0, 0, base.Width, base.Height);
				Bitmap bitmap1 = ((SkinBitmaps) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_MENUBAR;
				using (Bitmap bitmap2 = new Bitmap (base.Width, base.Height))
				{
					using (Graphics graphics1 = Graphics.FromImage (((Image) bitmap2)))
					{
						if (bitmap1 != null)
						{
							graphics1.DrawImage (((Image) bitmap1), rectangle1, 0, 0, bitmap1.Width, bitmap1.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x349935d524988797);
						}
						else if (((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARSTARTCOLOR != ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARENDCOLOR)
						{
							using (LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush (rectangle1, ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARSTARTCOLOR, ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARENDCOLOR, LinearGradientMode.Vertical))
							{
								graphics1.FillRectangle (((Brush) linearGradientBrush1), rectangle1);
								goto L_0110;
							}
						}
						else
						{
							graphics1.FillRectangle (((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_MENUBARSTARTCOLOR, rectangle1);
						}
						
					L_0110:
						
						{
						}
					}
					e.Graphics.DrawImageUnscaled (((Image) bitmap2), 0, 0);
				}
				this.x05a10b378cdf8119 (e.Graphics);
				base.OnPaint (e);
			}
			
			protected override void OnResize (EventArgs e)
			
			/*
				// Code Size: 20 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
				L_0006: ldarg.0 
				L_0007: call System.Windows.Forms.Control::Void Invalidate()
				L_000c: ldarg.0 
				L_000d: ldarg.1 
				L_000e: call System.Windows.Forms.Control::Void OnResize(System.EventArgs)
				L_0013: ret 
			*/
			
			
			{
				this.x39e008704a72ea56 ();
				base.Invalidate ();
				base.OnResize (e);
			}
			
			public virtual void OnSelected (x5f4b657f68f87baa mc)
			
			/*
				// Code Size: 21 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d xaa7558c320af04eb
				L_0006: brfalse.s L_0014
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d xaa7558c320af04eb
				L_000e: ldarg.1 
				L_000f: callvirt Sunisoft.IrisSkin.InternalControls.x26569a56dfbc2c6d::Void Invoke(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0014: ret 
			*/
			
			
			{
				if (this.xaa7558c320af04eb != null)
				{
					this.xaa7558c320af04eb (mc);
				}
			}
			
			protected override void OnSystemColorsChanged (EventArgs e)
			
			/*
				// Code Size: 20 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
				L_0006: ldarg.0 
				L_0007: call System.Windows.Forms.Control::Void Invalidate()
				L_000c: ldarg.0 
				L_000d: ldarg.1 
				L_000e: call System.Windows.Forms.Control::Void OnSystemColorsChanged(System.EventArgs)
				L_0013: ret 
			*/
			
			
			{
				this.x39e008704a72ea56 ();
				base.Invalidate ();
				base.OnSystemColorsChanged (e);
			}
			
			public virtual bool PreFilterMessage (ref Message msg)
			
			/*
				// Code Size: 427 Bytes
				.maxstack 5
				.locals (System.Windows.Forms.Form V_0, 
         System.UInt16 V_1, 
         System.UInt16 V_2, 
         System.Int32 V_3, 
         System.Windows.Forms.Shortcut V_4, 
         System.Int32 V_5, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_6, 
         System.Windows.Forms.Shortcut V_7, 
         System.UInt32 V_8)
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::System.Windows.Forms.Form FindForm()
				L_0006: stloc.0 
				L_0007: ldloc.0 
				L_0008: brfalse L_01a9
				L_000d: ldloc.0 
				L_000e: call System.Windows.Forms.Form::System.Windows.Forms.Form get_ActiveForm()
				L_0013: bne.un L_01a9
				L_0018: ldloc.0 
				L_0019: callvirt System.Windows.Forms.Control::Boolean get_ContainsFocus()
				L_001e: brfalse L_01a9
				L_0023: ldarg.1 
				L_0024: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0029: stloc.s V_8
				L_002b: ldloc.s V_8
				L_002d: ldc.i4 256
				L_0032: beq.s L_004e
				L_0034: ldloc.s V_8
				L_0036: ldc.i4 260
				L_003b: sub 
				L_003c: switch (L_0149, L_00ab)
				L_0049: br L_01a9
				L_004e: ldarg.0 
				L_004f: call System.Windows.Forms.Control::Boolean get_Enabled()
				L_0054: brfalse L_01a9
				L_0059: ldc.i4.s 16
				L_005b: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt16 GetKeyState(Int32)
				L_0060: stloc.1 
				L_0061: ldc.i4.s 17
				L_0063: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt16 GetKeyState(Int32)
				L_0068: stloc.2 
				L_0069: ldarg.1 
				L_006a: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_006f: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_0074: stloc.3 
				L_0075: ldloc.1 
				L_0076: conv.i4 
				L_0077: ldc.i4 32768
				L_007c: and 
				L_007d: brfalse.s L_0087
				L_007f: ldloc.3 
				L_0080: ldc.i4 65536
				L_0085: add 
				L_0086: stloc.3 
				L_0087: ldloc.2 
				L_0088: conv.i4 
				L_0089: ldc.i4 32768
				L_008e: and 
				L_008f: brfalse.s L_0099
				L_0091: ldloc.3 
				L_0092: ldc.i4 131072
				L_0097: add 
				L_0098: stloc.3 
				L_0099: ldloc.3 
				L_009a: stloc.s V_4
				L_009c: ldarg.0 
				L_009d: ldloc.s V_4
				L_009f: ldarg.0 
				L_00a0: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_00a5: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x4d7a264852c9d2f3(System.Windows.Forms.Shortcut, Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a)
				L_00aa: ret 
				L_00ab: ldarg.0 
				L_00ac: call System.Windows.Forms.Control::Boolean get_Enabled()
				L_00b1: brfalse L_01a9
				L_00b6: ldarg.1 
				L_00b7: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_00bc: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_00c1: ldc.i4.s 18
				L_00c3: bne.un L_01a9
				L_00c8: ldarg.0 
				L_00c9: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_00ce: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_00d3: ldc.i4.0 
				L_00d4: ble L_0147
				L_00d9: ldarg.0 
				L_00da: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_00df: ldc.i4.m1 
				L_00e0: bne.un.s L_0141
				L_00e2: ldc.i4.0 
				L_00e3: stloc.s V_5
				L_00e5: br.s L_0132
				L_00e7: ldarg.0 
				L_00e8: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_00ed: ldloc.s V_5
				L_00ef: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_00f4: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_00f9: stloc.s V_6
				L_00fb: ldloc.s V_6
				L_00fd: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x43604484a3deae4f()
				L_0102: brtrue.s L_012c
				L_0104: ldloc.s V_6
				L_0106: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_010b: brtrue.s L_011b
				L_010d: ldloc.s V_6
				L_010f: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0114: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Enabled()
				L_0119: brfalse.s L_012c
				L_011b: ldarg.0 
				L_011c: ldarg.0 
				L_011d: ldc.i4.m1 
				L_011e: ldloc.s V_5
				L_0120: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xa7cbddf1ec7a27e7(Int32, Int32)
				L_0125: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_012a: br.s L_0141
				L_012c: ldloc.s V_5
				L_012e: ldc.i4.1 
				L_012f: add 
				L_0130: stloc.s V_5
				L_0132: ldloc.s V_5
				L_0134: ldarg.0 
				L_0135: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_013a: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_013f: blt.s L_00e7
				L_0141: ldarg.0 
				L_0142: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x60cdc457bc0610f8()
				L_0147: ldc.i4.1 
				L_0148: ret 
				L_0149: ldarg.0 
				L_014a: call System.Windows.Forms.Control::Boolean get_Enabled()
				L_014f: brfalse.s L_01a9
				L_0151: ldarg.1 
				L_0152: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_0157: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_015c: ldc.i4.s 18
				L_015e: beq.s L_01a9
				L_0160: ldc.i4 262144
				L_0165: ldarg.1 
				L_0166: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_016b: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_0170: add 
				L_0171: stloc.s V_7
				L_0173: ldarg.0 
				L_0174: ldloc.s V_7
				L_0176: ldarg.0 
				L_0177: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_017c: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x4d7a264852c9d2f3(System.Windows.Forms.Shortcut, Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a)
				L_0181: brfalse.s L_0185
				L_0183: ldc.i4.1 
				L_0184: ret 
				L_0185: ldarg.0 
				L_0186: ldarg.1 
				L_0187: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_018c: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_0191: conv.u2 
				L_0192: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x65c1cc54cc8b0e75(Char)
				L_0197: brfalse.s L_01a9
				L_0199: ldarg.0 
				L_019a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x44d0011ba55ea8a3
				L_019f: brtrue.s L_01a7
				L_01a1: ldarg.0 
				L_01a2: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x60cdc457bc0610f8()
				L_01a7: ldc.i4.1 
				L_01a8: ret 
				L_01a9: ldc.i4.0 
				L_01aa: ret 
			*/
			
			
			{
				Form form1;
				UInt16 uInt16_1;
				UInt16 uInt16_2;
				int i1;
				Shortcut shortcut1;
				int i2;
				Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				Shortcut shortcut2;
				uint uInt32_1;
				form1 = base.FindForm ();
				if (form1 == null)
				{
					return false;
				}
				if (form1 != Form.ActiveForm)
				{
					return false;
				}
				if (! form1.ContainsFocus)
				{
					return false;
				}
				uInt32_1 = ((uint) msg.Msg);
				if (uInt32_1 != 256)
				{
					switch ((int) uInt32_1)
					{
						case 260:
						
						{
								if (! base.Enabled)
								{
									return false;
								}
								if (((int) msg.WParam) == 18)
								{
									return false;
								}
								shortcut2 = ((Shortcut) (262144 + ((int) msg.WParam)));
								if (this.x4d7a264852c9d2f3 (shortcut2, this.xf4f555905eaa2330))
								{
									return true;
								}
								else if (! this.x65c1cc54cc8b0e75 (((char) ((UInt16) ((int) msg.WParam)))))
								{
									return false;
								}
								else
								{
									if (! this.x44d0011ba55ea8a3)
									{
										this.x60cdc457bc0610f8 ();
									}
									return true;
								}
						}
						case 261:
						
						{
								if (! base.Enabled)
								{
									return false;
								}
								if (((int) msg.WParam) != 18)
								{
									return false;
								}
								if (this.xfb5697071ce83988.Count <= 0)
								{
									return true;
								}
								if (this.xb266b78561d63b52 != -1)
								{
									goto L_0141;
								}
								i2 = 0;
								while (i2 < this.xfb5697071ce83988.Count)
								{
									x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[i2] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f);
									if (x2cc390e9409b0f3f1.x43604484a3deae4f || ((! x2cc390e9409b0f3f1.xaa08ea3ba2fe9514) && (! x2cc390e9409b0f3f1.x5f4b657f68f87baa.Enabled)))
									{
										i2++;
										continue;
									}
									this.xb266b78561d63b52 = this.xa7cbddf1ec7a27e7 (-1, i2);
									break;
								}
								goto L_0141;
						}
					}
					return false;
				}
				if (! base.Enabled)
				{
					return false;
				}
				uInt16_1 = x61467fe65a98f20c.GetKeyState (16);
				uInt16_2 = x61467fe65a98f20c.GetKeyState (17);
				i1 = ((int) msg.WParam);
				if ((((int) uInt16_1) & 32768) != 0)
				{
					i1 += 65536;
				}
				if ((((int) uInt16_2) & 32768) != 0)
				{
					i1 += 131072;
				}
				shortcut1 = ((Shortcut) i1);
				return this.x4d7a264852c9d2f3 (shortcut1, this.xf4f555905eaa2330);
				
			L_0141:
				
				{
				}
				this.x60cdc457bc0610f8 ();
				return true;
			}
			
			protected override void WndProc (ref Message m)
			
			/*
				// Code Size: 56 Bytes
				.maxstack 3
				.locals (System.UInt32 V_0)
				L_0000: ldarg.1 
				L_0001: call System.Windows.Forms.Message::Int32 get_Msg()
				L_0006: conv.i8 
				L_0007: ldarg.0 
				L_0008: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::UInt32 xd8f9b747f716862a
				L_000d: conv.u8 
				L_000e: bne.un.s L_0019
				L_0010: ldarg.0 
				L_0011: ldarg.1 
				L_0012: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xa9f9739090793818(System.Windows.Forms.Message ByRef)
				L_0017: br.s L_0030
				L_0019: ldarg.1 
				L_001a: call System.Windows.Forms.Message::Int32 get_Msg()
				L_001f: stloc.0 
				L_0020: ldloc.0 
				L_0021: ldc.i4 135
				L_0026: bne.un.s L_0030
				L_0028: ldarg.0 
				L_0029: ldarg.1 
				L_002a: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x92bcd6bad6f29e72(System.Windows.Forms.Message ByRef)
				L_002f: ret 
				L_0030: ldarg.0 
				L_0031: ldarg.1 
				L_0032: call System.Windows.Forms.ContainerControl::Void WndProc(System.Windows.Forms.Message ByRef)
				L_0037: ret 
			*/
			
			
			{
				if (((long) m.Msg) == ((long) this.xd8f9b747f716862a))
				{
					this.xa9f9739090793818 (ref m);
				}
				else if (((uint) m.Msg) == 135)
				{
					this.x92bcd6bad6f29e72 (ref m);
					return;
				}
				base.WndProc (ref m);
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
				L_0005: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_000a: ldloc.0 
				L_000b: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0010: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0015: stloc.1 
				L_0016: ldarg.0 
				L_0017: ldarg.1 
				L_0018: ldloc.1 
				L_0019: ldloc.0 
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0020: ceq 
				L_0022: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xb5a5bdae3ba8936b(System.Drawing.Graphics, Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f, Boolean)
				L_0027: ldloc.0 
				L_0028: ldc.i4.1 
				L_0029: add 
				L_002a: stloc.0 
				L_002b: ldloc.0 
				L_002c: ldarg.0 
				L_002d: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_0032: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_0037: blt.s L_0004
				L_0039: ret 
			*/
			
			
			{
				int i1;
				Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				for (i1 = 0; (i1 < this.xfb5697071ce83988.Count); i1++)
				{
					x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[i1] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f);
					this.xb5a5bdae3ba8936b (x4b101060f4767186, x2cc390e9409b0f3f1, (i1 == this.xb266b78561d63b52));
				}
			}
			
			internal void x0760506d6abf77a2 (Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f xd2a8bb4342ab4ef6, bool xacc37ebdd71fcc44, bool xec106df5fe2fbc8e)
			
			/*
				// Code Size: 849 Bytes
				.maxstack 11
				.locals (System.Drawing.Rectangle V_0, 
         System.Drawing.Point V_1, 
         System.Drawing.Point V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_5, 
         Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a V_6, 
         System.Boolean V_7, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_8, 
         System.Drawing.Rectangle V_9, 
         System.Collections.IEnumerator V_10, 
         System.IDisposable V_11)
				.try L_01a5 to L_01df finally L_01df to L_01f4
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::Boolean get_IsDisposed()
				L_0006: brfalse.s L_0009
				L_0008: ret 
				L_0009: ldarg.1 
				L_000a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_000f: stloc.0 
				L_0010: ldarg.0 
				L_0011: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_0016: ldc.i4.1 
				L_0017: bne.un.s L_0043
				L_0019: ldarg.0 
				L_001a: ldarg.1 
				L_001b: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_0020: stloc.s V_9
				L_0022: ldloca.s V_9
				L_0024: call System.Drawing.Rectangle::Int32 get_Left()
				L_0029: ldc.i4.1 
				L_002a: add 
				L_002b: ldloca.s V_0
				L_002d: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0032: ldc.i4.3 
				L_0033: sub 
				L_0034: ldc.i4.2 
				L_0035: sub 
				L_0036: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_003b: call System.Windows.Forms.Control::System.Drawing.Point PointToScreen(System.Drawing.Point)
				L_0040: stloc.1 
				L_0041: br.s L_0070
				L_0043: ldarg.0 
				L_0044: ldarg.1 
				L_0045: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_004a: stloc.s V_9
				L_004c: ldloca.s V_9
				L_004e: call System.Drawing.Rectangle::Int32 get_Right()
				L_0053: ldarg.0 
				L_0054: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xe6d633b23b7c9bfe
				L_0059: sub 
				L_005a: ldloca.s V_0
				L_005c: call System.Drawing.Rectangle::Int32 get_Top()
				L_0061: ldc.i4.2 
				L_0062: add 
				L_0063: ldc.i4.1 
				L_0064: sub 
				L_0065: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_006a: call System.Windows.Forms.Control::System.Drawing.Point PointToScreen(System.Drawing.Point)
				L_006f: stloc.1 
				L_0070: ldarg.0 
				L_0071: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_0076: ldc.i4.1 
				L_0077: bne.un.s L_00aa
				L_0079: ldarg.0 
				L_007a: ldarg.1 
				L_007b: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_0080: stloc.s V_9
				L_0082: ldloca.s V_9
				L_0084: call System.Drawing.Rectangle::Int32 get_Left()
				L_0089: ldc.i4.1 
				L_008a: add 
				L_008b: ldloca.s V_0
				L_008d: call System.Drawing.Rectangle::Int32 get_Top()
				L_0092: ldarg.0 
				L_0093: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xe6d633b23b7c9bfe
				L_0098: add 
				L_0099: ldc.i4.3 
				L_009a: add 
				L_009b: ldc.i4.1 
				L_009c: sub 
				L_009d: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_00a2: call System.Windows.Forms.Control::System.Drawing.Point PointToScreen(System.Drawing.Point)
				L_00a7: stloc.2 
				L_00a8: br.s L_00d7
				L_00aa: ldarg.0 
				L_00ab: ldarg.1 
				L_00ac: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_00b1: stloc.s V_9
				L_00b3: ldloca.s V_9
				L_00b5: call System.Drawing.Rectangle::Int32 get_Right()
				L_00ba: ldarg.0 
				L_00bb: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xe6d633b23b7c9bfe
				L_00c0: sub 
				L_00c1: ldloca.s V_0
				L_00c3: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_00c8: ldc.i4.3 
				L_00c9: add 
				L_00ca: ldc.i4.1 
				L_00cb: add 
				L_00cc: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_00d1: call System.Windows.Forms.Control::System.Drawing.Point PointToScreen(System.Drawing.Point)
				L_00d6: stloc.2 
				L_00d7: ldarg.0 
				L_00d8: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_00dd: ldc.i4.1 
				L_00de: bne.un.s L_00f4
				L_00e0: ldarg.1 
				L_00e1: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_00e6: stloc.s V_9
				L_00e8: ldloca.s V_9
				L_00ea: call System.Drawing.Rectangle::Int32 get_Width()
				L_00ef: ldc.i4.2 
				L_00f0: sub 
				L_00f1: stloc.3 
				L_00f2: br.s L_0106
				L_00f4: ldarg.1 
				L_00f5: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_00fa: stloc.s V_9
				L_00fc: ldloca.s V_9
				L_00fe: call System.Drawing.Rectangle::Int32 get_Height()
				L_0103: ldc.i4.2 
				L_0104: sub 
				L_0105: stloc.3 
				L_0106: ldarg.0 
				L_0107: ldarg.0 
				L_0108: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_010d: newobj Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void .ctor(Sunisoft.IrisSkin.SkinEngine)
				L_0112: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0117: ldc.i4.0 
				L_0118: stloc.s V_4
				L_011a: ldnull 
				L_011b: stloc.s V_5
				L_011d: ldarg.0 
				L_011e: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0123: ldarg.0 
				L_0124: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xc316f3c6d490f56e
				L_0129: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void set_x2f5f5a028825ce32(Boolean)
				L_012e: ldarg.0 
				L_012f: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0134: ldarg.0 
				L_0135: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x604ddcdfda178b5a
				L_013a: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void set_x1f045c9de3a60a02(Boolean)
				L_013f: ldarg.0 
				L_0140: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0145: ldarg.0 
				L_0146: call System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_014b: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void set_xc2d4efc42998d87b(System.Drawing.Font)
				L_0150: ldarg.0 
				L_0151: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0156: ldarg.0 
				L_0157: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced xa11bc1c36fce21ec
				L_015c: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void set_x6fd23f8bad2f3ced(Sunisoft.IrisSkin.InternalControls.x6fd23f8bad2f3ced)
				L_0161: ldarg.0 
				L_0162: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0167: ldarg.0 
				L_0168: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x1f5697535eab37b9 xa89034e65472167c
				L_016d: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void set_xa743c350e27e50b4(Sunisoft.IrisSkin.InternalControls.x1f5697535eab37b9)
				L_0172: ldarg.0 
				L_0173: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0178: ldarg.0 
				L_0179: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 x8d677ea3c0d5a202
				L_017e: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void set_x742a8c15ee195ce2(Int32)
				L_0183: ldarg.1 
				L_0184: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_0189: brfalse L_0218
				L_018e: newobj Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Void .ctor()
				L_0193: stloc.s V_6
				L_0195: ldc.i4.0 
				L_0196: stloc.s V_7
				L_0198: ldarg.0 
				L_0199: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_019e: callvirt System.Collections.CollectionBase::System.Collections.IEnumerator GetEnumerator()
				L_01a3: stloc.s V_10
				L_01a5: br.s L_01d4
				L_01a7: ldloc.s V_10
				L_01a9: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_01ae: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_01b3: stloc.s V_8
				L_01b5: ldloc.s V_7
				L_01b7: brtrue.s L_01c6
				L_01b9: ldloc.s V_8
				L_01bb: ldarg.0 
				L_01bc: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x63fd40b32f4be51f
				L_01c1: bne.un.s L_01c6
				L_01c3: ldc.i4.1 
				L_01c4: stloc.s V_7
				L_01c6: ldloc.s V_7
				L_01c8: brfalse.s L_01d4
				L_01ca: ldloc.s V_6
				L_01cc: ldloc.s V_8
				L_01ce: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd6b6ed77479ef68c(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_01d3: pop 
				L_01d4: ldloc.s V_10
				L_01d6: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_01db: brtrue.s L_01a7
				L_01dd: leave.s L_01f4
				L_01df: ldloc.s V_10
				L_01e1: isinst System.IDisposable
				L_01e6: stloc.s V_11
				L_01e8: ldloc.s V_11
				L_01ea: brfalse.s L_01f3
				L_01ec: ldloc.s V_11
				L_01ee: callvirt System.IDisposable::Void Dispose()
				L_01f3: endfinally 
				L_01f4: ldarg.0 
				L_01f5: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_01fa: ldloc.1 
				L_01fb: ldloc.2 
				L_01fc: ldarg.0 
				L_01fd: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_0202: ldloc.s V_6
				L_0204: ldloc.3 
				L_0205: ldarg.2 
				L_0206: ldarg.0 
				L_0207: ldarg.0 
				L_0208: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x20ad2840ee62b6a4
				L_020d: ldloca.s V_4
				L_020f: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x6192996f26aa9421(System.Drawing.Point, System.Drawing.Point, Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0, Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a, Int32, Boolean, Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01, Boolean, Int32 ByRef)
				L_0214: stloc.s V_5
				L_0216: br.s L_0269
				L_0218: ldarg.1 
				L_0219: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_021e: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnPopupStart()
				L_0223: ldarg.0 
				L_0224: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0229: ldarg.1 
				L_022a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_022f: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0234: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Boolean get_x6f72c846c7dcb042()
				L_0239: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void set_x6f72c846c7dcb042(Boolean)
				L_023e: ldarg.0 
				L_023f: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0244: ldloc.1 
				L_0245: ldloc.2 
				L_0246: ldarg.0 
				L_0247: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_024c: ldarg.1 
				L_024d: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0252: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0257: ldloc.3 
				L_0258: ldarg.2 
				L_0259: ldarg.0 
				L_025a: ldarg.0 
				L_025b: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x20ad2840ee62b6a4
				L_0260: ldloca.s V_4
				L_0262: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x6192996f26aa9421(System.Drawing.Point, System.Drawing.Point, Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0, Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a, Int32, Boolean, Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01, Boolean, Int32 ByRef)
				L_0267: stloc.s V_5
				L_0269: ldarg.0 
				L_026a: ldc.i4.0 
				L_026b: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x20ad2840ee62b6a4
				L_0270: ldarg.0 
				L_0271: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x0bd7b802cb5b7f60
				L_0276: brfalse.s L_0293
				L_0278: ldarg.0 
				L_0279: ldarg.0 
				L_027a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_027f: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x35a6958370d758dd(Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a)
				L_0284: brfalse.s L_0293
				L_0286: ldarg.0 
				L_0287: ldarg.0 
				L_0288: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_028d: ldc.i4.1 
				L_028e: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xe8febcf8320c4113(Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a, Boolean)
				L_0293: ldloc.s V_4
				L_0295: brtrue.s L_02f2
				L_0297: ldarg.0 
				L_0298: ldc.i4.0 
				L_0299: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x753f06f9b5cd6e0d
				L_029e: ldarg.0 
				L_029f: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xd2893b73a80bf998
				L_02a4: brtrue.s L_02eb
				L_02a6: ldarg.0 
				L_02a7: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xcb97d93f0d5ce4a8()
				L_02ac: ldarg.0 
				L_02ad: ldc.i4.0 
				L_02ae: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xf947c341af20623c
				L_02b3: ldarg.0 
				L_02b4: call System.Windows.Forms.Control::Boolean get_IsDisposed()
				L_02b9: brtrue.s L_02f2
				L_02bb: ldarg.3 
				L_02bc: brfalse.s L_02d3
				L_02be: ldarg.0 
				L_02bf: ldarg.0 
				L_02c0: ldarg.0 
				L_02c1: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_02c6: ldc.i4.m1 
				L_02c7: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xa7cbddf1ec7a27e7(Int32, Int32)
				L_02cc: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_02d1: br.s L_02f2
				L_02d3: ldarg.0 
				L_02d4: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_02d9: ldc.i4.m1 
				L_02da: beq.s L_02f2
				L_02dc: ldarg.0 
				L_02dd: ldarg.0 
				L_02de: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_02e3: ldc.i4.1 
				L_02e4: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x2cc390e9409b0f3f(Int32, Boolean)
				L_02e9: br.s L_02f2
				L_02eb: ldarg.0 
				L_02ec: ldc.i4.0 
				L_02ed: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xd2893b73a80bf998
				L_02f2: ldarg.1 
				L_02f3: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_02f8: brtrue.s L_0305
				L_02fa: ldarg.1 
				L_02fb: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0300: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnPopupEnd()
				L_0305: call System.Windows.Forms.Application::Void DoEvents()
				L_030a: ldarg.0 
				L_030b: ldnull 
				L_030c: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0311: ldloc.s V_4
				L_0313: brfalse.s L_0332
				L_0315: ldloc.s V_4
				L_0317: ldc.i4.0 
				L_0318: bge.s L_0323
				L_031a: ldarg.0 
				L_031b: ldc.i4.1 
				L_031c: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x58049cd54e5ca4e3(Boolean)
				L_0321: br.s L_032a
				L_0323: ldarg.0 
				L_0324: ldc.i4.1 
				L_0325: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x14014e142c6b152c(Boolean)
				L_032a: ldarg.0 
				L_032b: ldc.i4.1 
				L_032c: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x72c40adab6f1d6f3
				L_0331: ret 
				L_0332: ldloc.s V_5
				L_0334: brfalse.s L_0350
				L_0336: ldarg.0 
				L_0337: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x44d0011ba55ea8a3
				L_033c: brfalse.s L_0344
				L_033e: ldarg.0 
				L_033f: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xa23d095e6e52c5f3()
				L_0344: ldloc.s V_5
				L_0346: ldsfld System.EventArgs::System.EventArgs Empty
				L_034b: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnClick(System.EventArgs)
				L_0350: ret 
			*/
			
			
			{
				Point point1;
				Point point2;
				int i1;
				xd53b20b7b4b2a08a xd53b20b7b4b2a08a1;
				bool b1;
				if (base.IsDisposed)
				{
					return;
				}
				Rectangle rectangle1 = xd2a8bb4342ab4ef6.xee63d905da8ff550;
				if (this.x23e85093ba3a7d1d == Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da)
				{
					point1 = base.PointToScreen (new Point (((int) (xd2a8bb4342ab4ef6.xee63d905da8ff550.Left + 1)), ((int) ((rectangle1.Bottom - 3) - 2))));
				}
				else
				{
					point1 = base.PointToScreen (new Point (((int) (xd2a8bb4342ab4ef6.xee63d905da8ff550.Right - this.xe6d633b23b7c9bfe)), ((int) ((rectangle1.Top + 2) - 1))));
				}
				if (this.x23e85093ba3a7d1d == Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da)
				{
					point2 = base.PointToScreen (new Point (((int) (xd2a8bb4342ab4ef6.xee63d905da8ff550.Left + 1)), ((int) (((rectangle1.Top + this.xe6d633b23b7c9bfe) + 3) - 1))));
				}
				else
				{
					point2 = base.PointToScreen (new Point (((int) (xd2a8bb4342ab4ef6.xee63d905da8ff550.Right - this.xe6d633b23b7c9bfe)), ((int) ((rectangle1.Bottom + 3) + 1))));
				}
				if (this.x23e85093ba3a7d1d == Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da)
				{
					i1 = (xd2a8bb4342ab4ef6.xee63d905da8ff550.Width - 2);
				}
				else
				{
					i1 = (xd2a8bb4342ab4ef6.xee63d905da8ff550.Height - 2);
				}
				this.x56be4c3c4c4173b7 = new x902c4aee45bfd906 (this.xdc87e2b99332cd4a);
				int i2 = 0;
				x5f4b657f68f87baa x5f4b657f68f87baa1 = ((x5f4b657f68f87baa) null);
				this.x56be4c3c4c4173b7.x2f5f5a028825ce32 = this.xc316f3c6d490f56e;
				this.x56be4c3c4c4173b7.x1f045c9de3a60a02 = this.x604ddcdfda178b5a;
				this.x56be4c3c4c4173b7.xc2d4efc42998d87b = base.Font;
				this.x56be4c3c4c4173b7.x6fd23f8bad2f3ced = this.xa11bc1c36fce21ec;
				this.x56be4c3c4c4173b7.xa743c350e27e50b4 = this.xa89034e65472167c;
				this.x56be4c3c4c4173b7.x742a8c15ee195ce2 = this.x8d677ea3c0d5a202;
				if (xd2a8bb4342ab4ef6.xaa08ea3ba2fe9514)
				{
					xd53b20b7b4b2a08a1 = new xd53b20b7b4b2a08a ();
					b1 = false;
					foreach (x5f4b657f68f87baa x5f4b657f68f87baa2 in this.xf4f555905eaa2330)
					{
						if ((! b1) && (x5f4b657f68f87baa2 == this.x63fd40b32f4be51f))
						{
							b1 = true;
						}
						if (b1)
						{
							x5f4b657f68f87baa x5f4b657f68f87baa3 = xd53b20b7b4b2a08a1.xd6b6ed77479ef68c (x5f4b657f68f87baa2);
						}
					}
					x5f4b657f68f87baa1 = this.x56be4c3c4c4173b7.x6192996f26aa9421 (point1, point2, this.x23e85093ba3a7d1d, xd53b20b7b4b2a08a1, i1, xacc37ebdd71fcc44, this, this.x20ad2840ee62b6a4, ref i2);
				}
				else
				{
					xd2a8bb4342ab4ef6.x5f4b657f68f87baa.OnPopupStart ();
					this.x56be4c3c4c4173b7.x6f72c846c7dcb042 = xd2a8bb4342ab4ef6.x5f4b657f68f87baa.MenuCommands.x6f72c846c7dcb042;
					x5f4b657f68f87baa1 = this.x56be4c3c4c4173b7.x6192996f26aa9421 (point1, point2, this.x23e85093ba3a7d1d, xd2a8bb4342ab4ef6.x5f4b657f68f87baa.MenuCommands, i1, xacc37ebdd71fcc44, this, this.x20ad2840ee62b6a4, ref i2);
				}
				this.x20ad2840ee62b6a4 = false;
				if (this.x0bd7b802cb5b7f60 && this.x35a6958370d758dd (this.xf4f555905eaa2330))
				{
					this.xe8febcf8320c4113 (this.xf4f555905eaa2330, true);
				}
				if (i2 == 0)
				{
					this.x753f06f9b5cd6e0d = false;
					if (this.xd2893b73a80bf998)
					{
						this.xd2893b73a80bf998 = false;
					}
					else
					{
						this.xcb97d93f0d5ce4a8 ();
						this.xf947c341af20623c = false;
						if (! base.IsDisposed)
						{
							if (xec106df5fe2fbc8e)
							{
								this.xb266b78561d63b52 = this.xa7cbddf1ec7a27e7 (this.xb266b78561d63b52, -1);
							}
							else if (this.xb266b78561d63b52 != -1)
							{
								this.x2cc390e9409b0f3f (this.xb266b78561d63b52, true);
							}
						}
					}
				}
				if (! xd2a8bb4342ab4ef6.xaa08ea3ba2fe9514)
				{
					xd2a8bb4342ab4ef6.x5f4b657f68f87baa.OnPopupEnd ();
				}
				Application.DoEvents ();
				this.x56be4c3c4c4173b7 = ((x902c4aee45bfd906) null);
				if (i2 == 0)
				{
					if (x5f4b657f68f87baa1 != null)
					{
						if (this.x44d0011ba55ea8a3)
						{
							this.xa23d095e6e52c5f3 ();
						}
						x5f4b657f68f87baa1.OnClick (EventArgs.Empty);
					}
				}
				else
				{
					if (i2 < 0)
					{
						this.x58049cd54e5ca4e3 (true);
					}
					else
					{
						this.x14014e142c6b152c (true);
					}
					this.x72c40adab6f1d6f3 = true;
					return;
					
					/*
						Unreachable Code
						return;
					*/
				}
			}
			
			protected void x0b912a2b95b630ba (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 32 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_0006: brfalse.s L_001f
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_000e: callvirt System.Windows.Forms.Form::Void Close()
				L_0013: ldarg.0 
				L_0014: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
				L_0019: ldarg.0 
				L_001a: call System.Windows.Forms.Control::Void Invalidate()
				L_001f: ret 
			*/
			
			
			{
				if (this.x562fa9742b4f7ed5 != null)
				{
					this.x562fa9742b4f7ed5.Close ();
					this.x39e008704a72ea56 ();
					base.Invalidate ();
				}
			}
			
			internal void x136735fdfe6d04ea (x555516122dcc901e.POINT x0ce73f6cbd7d5515)
			
			/*
				// Code Size: 35 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_0006: ldarga.s x0ce73f6cbd7d5515
				L_0008: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean ScreenToClient(IntPtr, POINT ByRef)
				L_000d: pop 
				L_000e: ldarg.0 
				L_000f: ldarga.s x0ce73f6cbd7d5515
				L_0011: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0016: ldarga.s x0ce73f6cbd7d5515
				L_0018: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_001d: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xdd922e6d558c59d4(Int32, Int32)
				L_0022: ret 
			*/
			
			
			{
				bool b1 = x61467fe65a98f20c.ScreenToClient (base.Handle, ref x0ce73f6cbd7d5515);
				this.xdd922e6d558c59d4 (x0ce73f6cbd7d5515.x, x0ce73f6cbd7d5515.y);
			}
			
			protected void x14014e142c6b152c (bool x651d82357ffa4398)
			
			/*
				// Code Size: 198 Bytes
				.maxstack 5
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_2)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0006: brtrue L_00c5
				L_000b: ldarg.0 
				L_000c: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0011: stloc.0 
				L_0012: ldc.i4.0 
				L_0013: stloc.1 
				L_0014: br L_00b4
				L_0019: ldloc.0 
				L_001a: ldc.i4.1 
				L_001b: add 
				L_001c: stloc.0 
				L_001d: ldloc.0 
				L_001e: ldarg.0 
				L_001f: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_0024: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_0029: blt.s L_002d
				L_002b: ldc.i4.0 
				L_002c: stloc.0 
				L_002d: ldarg.0 
				L_002e: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_0033: ldloc.0 
				L_0034: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0039: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_003e: stloc.2 
				L_003f: ldloc.2 
				L_0040: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x43604484a3deae4f()
				L_0045: brtrue.s L_00b0
				L_0047: ldloc.2 
				L_0048: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_004d: brtrue.s L_005c
				L_004f: ldloc.2 
				L_0050: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0055: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Enabled()
				L_005a: brfalse.s L_00b0
				L_005c: ldloc.0 
				L_005d: ldarg.0 
				L_005e: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0063: beq.s L_00b0
				L_0065: ldarg.0 
				L_0066: ldarg.0 
				L_0067: ldarg.0 
				L_0068: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_006d: ldloc.0 
				L_006e: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xa7cbddf1ec7a27e7(Int32, Int32)
				L_0073: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0078: ldarg.0 
				L_0079: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_007e: brfalse.s L_00c5
				L_0080: ldloc.2 
				L_0081: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_0086: brtrue.s L_009b
				L_0088: ldloc.2 
				L_0089: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_008e: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0093: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_0098: ldc.i4.0 
				L_0099: ble.s L_00c5
				L_009b: ldarg.0 
				L_009c: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_00a1: ldarg.0 
				L_00a2: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::UInt32 xd8f9b747f716862a
				L_00a7: ldc.i4.0 
				L_00a8: ldc.i4.1 
				L_00a9: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_00ae: pop 
				L_00af: ret 
				L_00b0: ldloc.1 
				L_00b1: ldc.i4.1 
				L_00b2: add 
				L_00b3: stloc.1 
				L_00b4: ldloc.1 
				L_00b5: ldarg.0 
				L_00b6: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_00bb: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_00c0: blt L_0019
				L_00c5: ret 
			*/
			
			
			{
				int i2;
				Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				if (this.x56be4c3c4c4173b7 != null)
				{
					return;
				}
				int i1 = this.xb266b78561d63b52;
				for (i2 = 0; (i2 < this.xfb5697071ce83988.Count); i2++)
				{
					i1++;
					if (i1 >= this.xfb5697071ce83988.Count)
					{
						i1 = 0;
					}
					x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[i1] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f);
					if (((! x2cc390e9409b0f3f1.x43604484a3deae4f) && (x2cc390e9409b0f3f1.xaa08ea3ba2fe9514 || x2cc390e9409b0f3f1.x5f4b657f68f87baa.Enabled)) && (i1 != this.xb266b78561d63b52))
					{
						this.xb266b78561d63b52 = this.xa7cbddf1ec7a27e7 (this.xb266b78561d63b52, i1);
						if ((! this.x9f93ebd2ca5601a2) || ((! x2cc390e9409b0f3f1.xaa08ea3ba2fe9514) && (x2cc390e9409b0f3f1.x5f4b657f68f87baa.MenuCommands.Count <= 0)))
						{
							return;
						}
						bool b1 = x61467fe65a98f20c.PostMessage (base.Handle, this.xd8f9b747f716862a, uint.MinValue, 1);
						return;
					}
				}
			}
			
			protected void x199464e739d66b0b (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 33 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_0006: brfalse.s L_0020
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_000e: ldc.i4.1 
				L_000f: callvirt System.Windows.Forms.Form::Void set_WindowState(System.Windows.Forms.FormWindowState)
				L_0014: ldarg.0 
				L_0015: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
				L_001a: ldarg.0 
				L_001b: call System.Windows.Forms.Control::Void Invalidate()
				L_0020: ret 
			*/
			
			
			{
				if (this.x562fa9742b4f7ed5 != null)
				{
					this.x562fa9742b4f7ed5.WindowState = FormWindowState.Minimized;
					this.x39e008704a72ea56 ();
					base.Invalidate ();
				}
			}
			
			private void x1996f82940a97595 ()
			
			/*
				// Code Size: 483 Bytes
				.maxstack 7
				.locals (System.String V_0, 
         System.Boolean V_1, 
         System.Int32 V_2, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_3, 
         System.Collections.ArrayList V_4, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_5, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_6, 
         System.Collections.IEnumerator V_7, 
         System.IDisposable V_8)
				.try L_003b to L_006b catch System.Object L_006b to L_006e
				.try L_00fb to L_0143 finally L_0143 to L_0158
				.try L_017b to L_01c0 finally L_01c0 to L_01d5
				L_0000: ldstr ""
				L_0005: stloc.0 
				L_0006: ldc.i4.0 
				L_0007: stloc.1 
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
				L_000e: brfalse L_00e7
				L_0013: ldarg.0 
				L_0014: ldarg.0 
				L_0015: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
				L_001a: callvirt System.Windows.Forms.Form::System.Windows.Forms.Form[] get_MdiChildren()
				L_001f: ldlen 
				L_0020: conv.i4 
				L_0021: conv.ovf.u4 
				L_0022: newarr Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0027: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa[] x4dedac25f8166fb5
				L_002c: ldc.i4.0 
				L_002d: stloc.2 
				L_002e: br L_00d4
				L_0033: ldstr ""
				L_0038: stloc.0 
				L_0039: ldc.i4.0 
				L_003a: stloc.1 
				L_003b: ldarg.0 
				L_003c: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
				L_0041: callvirt System.Windows.Forms.Form::System.Windows.Forms.Form[] get_MdiChildren()
				L_0046: ldloc.2 
				L_0047: ldelem.ref 
				L_0048: callvirt System.Windows.Forms.Control::System.String get_Text()
				L_004d: stloc.0 
				L_004e: ldarg.0 
				L_004f: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
				L_0054: callvirt System.Windows.Forms.Form::System.Windows.Forms.Form[] get_MdiChildren()
				L_0059: ldloc.2 
				L_005a: ldelem.ref 
				L_005b: ldarg.0 
				L_005c: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
				L_0061: callvirt System.Windows.Forms.Form::System.Windows.Forms.Form get_ActiveMdiChild()
				L_0066: ceq 
				L_0068: stloc.1 
				L_0069: leave.s L_006e
				L_006b: pop 
				L_006c: leave.s L_006e
				L_006e: ldarg.0 
				L_006f: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa[] x4dedac25f8166fb5
				L_0074: ldloc.2 
				L_0075: ldstr "&{0} {1}"
				L_007a: ldloc.2 
				L_007b: ldc.i4.1 
				L_007c: add 
				L_007d: box System.Int32
				L_0082: ldloc.0 
				L_0083: call System.String::System.String Format(System.String, System.Object, System.Object)
				L_0088: ldarg.0 
				L_0089: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x43d97dcf909b3bd3(System.Object, System.EventArgs)
				L_008f: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0094: newobj Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void .ctor(System.String, System.EventHandler)
				L_0099: stelem.ref 
				L_009a: ldarg.0 
				L_009b: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa[] x4dedac25f8166fb5
				L_00a0: ldloc.2 
				L_00a1: ldelem.ref 
				L_00a2: ldloc.1 
				L_00a3: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void set_Checked(Boolean)
				L_00a8: ldarg.0 
				L_00a9: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa[] x4dedac25f8166fb5
				L_00ae: ldloc.2 
				L_00af: ldelem.ref 
				L_00b0: ldarg.0 
				L_00b1: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
				L_00b6: callvirt System.Windows.Forms.Form::System.Windows.Forms.Form[] get_MdiChildren()
				L_00bb: ldloc.2 
				L_00bc: ldelem.ref 
				L_00bd: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Form xb7d28b7a6d50662f
				L_00c2: ldarg.0 
				L_00c3: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa[] x4dedac25f8166fb5
				L_00c8: ldloc.2 
				L_00c9: ldelem.ref 
				L_00ca: ldc.i4.1 
				L_00cb: stfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xb2504b89d66feca9
				L_00d0: ldloc.2 
				L_00d1: ldc.i4.1 
				L_00d2: add 
				L_00d3: stloc.2 
				L_00d4: ldloc.2 
				L_00d5: ldarg.0 
				L_00d6: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
				L_00db: callvirt System.Windows.Forms.Form::System.Windows.Forms.Form[] get_MdiChildren()
				L_00e0: ldlen 
				L_00e1: conv.i4 
				L_00e2: blt L_0033
				L_00e7: newobj System.Collections.ArrayList::Void .ctor()
				L_00ec: stloc.s V_4
				L_00ee: ldarg.0 
				L_00ef: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_00f4: callvirt System.Collections.CollectionBase::System.Collections.IEnumerator GetEnumerator()
				L_00f9: stloc.s V_7
				L_00fb: br.s L_0135
				L_00fd: ldloc.s V_7
				L_00ff: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0104: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0109: stloc.s V_5
				L_010b: ldloc.s V_5
				L_010d: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_MdiList()
				L_0112: brfalse.s L_011c
				L_0114: ldarg.0 
				L_0115: ldloc.s V_5
				L_0117: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xa76c42f3062c6f11(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_011c: ldloc.s V_5
				L_011e: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0123: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_0128: ldc.i4.0 
				L_0129: ble.s L_0135
				L_012b: ldloc.s V_4
				L_012d: ldloc.s V_5
				L_012f: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0134: pop 
				L_0135: ldloc.s V_7
				L_0137: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_013c: brtrue.s L_00fd
				L_013e: leave L_01d5
				L_0143: ldloc.s V_7
				L_0145: isinst System.IDisposable
				L_014a: stloc.s V_8
				L_014c: ldloc.s V_8
				L_014e: brfalse.s L_0157
				L_0150: ldloc.s V_8
				L_0152: callvirt System.IDisposable::Void Dispose()
				L_0157: endfinally 
				L_0158: ldloc.s V_4
				L_015a: ldc.i4.0 
				L_015b: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0160: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0165: stloc.3 
				L_0166: ldloc.s V_4
				L_0168: ldc.i4.0 
				L_0169: callvirt System.Collections.ArrayList::Void RemoveAt(Int32)
				L_016e: ldloc.3 
				L_016f: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0174: callvirt System.Collections.CollectionBase::System.Collections.IEnumerator GetEnumerator()
				L_0179: stloc.s V_7
				L_017b: br.s L_01b5
				L_017d: ldloc.s V_7
				L_017f: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0184: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0189: stloc.s V_6
				L_018b: ldloc.s V_6
				L_018d: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_MdiList()
				L_0192: brfalse.s L_019c
				L_0194: ldarg.0 
				L_0195: ldloc.s V_6
				L_0197: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xa76c42f3062c6f11(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_019c: ldloc.s V_6
				L_019e: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_01a3: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_01a8: ldc.i4.0 
				L_01a9: ble.s L_01b5
				L_01ab: ldloc.s V_4
				L_01ad: ldloc.s V_6
				L_01af: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_01b4: pop 
				L_01b5: ldloc.s V_7
				L_01b7: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_01bc: brtrue.s L_017d
				L_01be: leave.s L_01d5
				L_01c0: ldloc.s V_7
				L_01c2: isinst System.IDisposable
				L_01c7: stloc.s V_8
				L_01c9: ldloc.s V_8
				L_01cb: brfalse.s L_01d4
				L_01cd: ldloc.s V_8
				L_01cf: callvirt System.IDisposable::Void Dispose()
				L_01d4: endfinally 
				L_01d5: ldloc.s V_4
				L_01d7: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_01dc: ldc.i4.0 
				L_01dd: bgt L_0158
				L_01e2: ret 
			*/
			
			
			{
				int i1;
				x5f4b657f68f87baa x5f4b657f68f87baa1;
				string string1 = "";
				bool b1 = false;
				if (this.xabf8437cf3c2cf0a != null)
				{
					this.x4dedac25f8166fb5 = new x5f4b657f68f87baa[((uint) this.xabf8437cf3c2cf0a.MdiChildren.Length)];
					for (i1 = 0; (i1 < this.xabf8437cf3c2cf0a.MdiChildren.Length); i1++)
					{
						string1 = "";
						b1 = false;
						try
						{
							string1 = this.xabf8437cf3c2cf0a.MdiChildren[i1].Text;
							b1 = (this.xabf8437cf3c2cf0a.MdiChildren[i1] == this.xabf8437cf3c2cf0a.ActiveMdiChild);
						}
						catch
						{
						}
						this.x4dedac25f8166fb5[i1] = new x5f4b657f68f87baa (string.Format ("&{0} {1}", (i1 + 1), string1), new EventHandler (this.x43d97dcf909b3bd3));
						this.x4dedac25f8166fb5[i1].Checked = b1;
						this.x4dedac25f8166fb5[i1].xb7d28b7a6d50662f = this.xabf8437cf3c2cf0a.MdiChildren[i1];
						this.x4dedac25f8166fb5[i1].xb2504b89d66feca9 = true;
					}
				}
				ArrayList arrayList1 = new ArrayList ();
				foreach (x5f4b657f68f87baa x5f4b657f68f87baa2 in this.x6ef5a4a9a9587cfd)
				{
					if (x5f4b657f68f87baa2.MdiList)
					{
						this.xa76c42f3062c6f11 (x5f4b657f68f87baa2);
					}
					if (x5f4b657f68f87baa2.MenuCommands.Count > 0)
					{
						int i2 = arrayList1.Add (x5f4b657f68f87baa2);
					}
				}
				while (arrayList1.Count > 0)
				{
					x5f4b657f68f87baa1 = ((x5f4b657f68f87baa) arrayList1[0]);
					arrayList1.RemoveAt (0);
					foreach (x5f4b657f68f87baa x5f4b657f68f87baa3 in x5f4b657f68f87baa1.MenuCommands)
					{
						if (x5f4b657f68f87baa3.MdiList)
						{
							this.xa76c42f3062c6f11 (x5f4b657f68f87baa3);
						}
						if (x5f4b657f68f87baa3.MenuCommands.Count > 0)
						{
							int i3 = arrayList1.Add (x5f4b657f68f87baa3);
						}
					}
				}
			}
			
			protected void x21498b72da0020ba (System.Drawing.Font x978809f7734a0f16)
			
			/*
				// Code Size: 66 Bytes
				.maxstack 6
				.locals (System.Int32 V_0)
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: call System.Windows.Forms.Control::Void set_Font(System.Drawing.Font)
				L_0007: ldarg.0 
				L_0008: ldarg.0 
				L_0009: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_000e: callvirt System.Drawing.Font::Int32 get_Height()
				L_0013: ldc.i4.3 
				L_0014: div 
				L_0015: ldc.i4.1 
				L_0016: add 
				L_0017: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xe6d633b23b7c9bfe
				L_001c: ldarg.0 
				L_001d: ldarg.0 
				L_001e: ldarg.0 
				L_001f: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_0024: callvirt System.Drawing.Font::Int32 get_Height()
				L_0029: ldarg.0 
				L_002a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xe6d633b23b7c9bfe
				L_002f: ldc.i4.2 
				L_0030: mul 
				L_0031: add 
				L_0032: ldc.i4.1 
				L_0033: add 
				L_0034: dup 
				L_0035: stloc.0 
				L_0036: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xd3f2e0aa29e1f6c9
				L_003b: ldloc.0 
				L_003c: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 x55f9f93541a6b942
				L_0041: ret 
			*/
			
			
			{
				int i1;
				base.Font = x978809f7734a0f16;
				this.xe6d633b23b7c9bfe = ((this.Font.Height / 3) + 1);
				this.xd3f2e0aa29e1f6c9 = (i1 = ((this.Font.Height + (this.xe6d633b23b7c9bfe * 2)) + 1));
				this.x55f9f93541a6b942 = i1;
			}
			
			protected void x23daf02978257d54 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 164 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_0006: brfalse.s L_001f
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_000e: ldarg.0 
				L_000f: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xfbce0f1d6df984cd(System.Object, System.EventArgs)
				L_0015: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_001a: callvirt System.Windows.Forms.Control::Void remove_SizeChanged(System.EventHandler)
				L_001f: ldarg.0 
				L_0020: ldarg.0 
				L_0021: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form xabf8437cf3c2cf0a
				L_0026: callvirt System.Windows.Forms.Form::System.Windows.Forms.Form get_ActiveMdiChild()
				L_002b: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_0030: ldarg.0 
				L_0031: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_0036: brfalse.s L_004f
				L_0038: ldarg.0 
				L_0039: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_003e: ldarg.0 
				L_003f: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xfbce0f1d6df984cd(System.Object, System.EventArgs)
				L_0045: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_004a: callvirt System.Windows.Forms.Control::Void add_SizeChanged(System.EventHandler)
				L_004f: ldarg.0 
				L_0050: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x1996f82940a97595()
				L_0055: ldarg.0 
				L_0056: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
				L_005b: ldarg.0 
				L_005c: call System.Windows.Forms.Control::Void Invalidate()
				L_0061: ldarg.0 
				L_0062: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_0067: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_006c: brtrue.s L_009c
				L_006e: ldarg.0 
				L_006f: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_0074: brfalse.s L_0094
				L_0076: ldarg.0 
				L_0077: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_007c: callvirt System.Windows.Forms.Form::System.Windows.Forms.FormWindowState get_WindowState()
				L_0081: ldc.i4.2 
				L_0082: bne.un.s L_008c
				L_0084: ldarg.0 
				L_0085: ldc.i4.1 
				L_0086: call System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_008b: ret 
				L_008c: ldarg.0 
				L_008d: ldc.i4.0 
				L_008e: call System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_0093: ret 
				L_0094: ldarg.0 
				L_0095: ldc.i4.0 
				L_0096: call System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_009b: ret 
				L_009c: ldarg.0 
				L_009d: ldc.i4.1 
				L_009e: call System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_00a3: ret 
			*/
			
			
			{
				if (this.x562fa9742b4f7ed5 != null)
				{
					this.x562fa9742b4f7ed5.SizeChanged -= new EventHandler (this.xfbce0f1d6df984cd);
				}
				this.x562fa9742b4f7ed5 = this.xabf8437cf3c2cf0a.ActiveMdiChild;
				if (this.x562fa9742b4f7ed5 != null)
				{
					this.x562fa9742b4f7ed5.SizeChanged += new EventHandler (this.xfbce0f1d6df984cd);
				}
				this.x1996f82940a97595 ();
				this.x39e008704a72ea56 ();
				base.Invalidate ();
				if (this.x6ef5a4a9a9587cfd.Count != 0)
				{
					base.Visible = true;
				}
				else if (this.x562fa9742b4f7ed5 == null)
				{
					base.Visible = false;
				}
				else if (this.x562fa9742b4f7ed5.WindowState == FormWindowState.Maximized)
				{
					base.Visible = true;
				}
				else
				{
					base.Visible = false;
				}
			}
			
			private void x273cbe3cfa28ea94 (object xe0292b9ed559da7d, ISkinChangedEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 137 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0006: callvirt Sunisoft.IrisSkin.SkinEngine::Boolean get_RealActive()
				L_000b: brfalse L_0088
				L_0010: ldarg.0 
				L_0011: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_0016: brfalse.s L_0038
				L_0018: ldarg.0 
				L_0019: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_001e: ldarg.0 
				L_001f: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0024: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0029: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_002e: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARSTARTCOLOR
				L_0033: callvirt System.Windows.Forms.Control::Void set_BackColor(System.Drawing.Color)
				L_0038: ldarg.0 
				L_0039: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_003e: brfalse.s L_0060
				L_0040: ldarg.0 
				L_0041: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_0046: ldarg.0 
				L_0047: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_004c: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0051: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0056: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARSTARTCOLOR
				L_005b: callvirt System.Windows.Forms.Control::Void set_BackColor(System.Drawing.Color)
				L_0060: ldarg.0 
				L_0061: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_0066: brfalse.s L_0088
				L_0068: ldarg.0 
				L_0069: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_006e: ldarg.0 
				L_006f: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0074: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0079: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_007e: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARSTARTCOLOR
				L_0083: callvirt System.Windows.Forms.Control::Void set_BackColor(System.Drawing.Color)
				L_0088: ret 
			*/
			
			
			{
				if (((SkinEngine) this.xdc87e2b99332cd4a).RealActive)
				{
					if (this.x2c6deb5021c80299 != null)
					{
						this.x2c6deb5021c80299.BackColor = ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARSTARTCOLOR;
					}
					if (this.x0abc55e6ce1d8aed != null)
					{
						this.x0abc55e6ce1d8aed.BackColor = ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARSTARTCOLOR;
					}
					if (this.x26e80f23e22a05ae != null)
					{
						this.x26e80f23e22a05ae.BackColor = ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARSTARTCOLOR;
					}
				}
			}
			
			protected void x288bea726e7cd27e (object xe0292b9ed559da7d, UserPreferenceChangedEventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 64 Bytes
				.maxstack 4
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xacac6b5ffdf089d3
				L_0006: brfalse.s L_003f
				L_0008: ldarg.0 
				L_0009: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_000e: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font get_MenuFont()
				L_0013: brtrue.s L_0022
				L_0015: ldarg.0 
				L_0016: call System.Windows.Forms.SystemInformation::System.Drawing.Font get_MenuFont()
				L_001b: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x21498b72da0020ba(System.Drawing.Font)
				L_0020: br.s L_0033
				L_0022: ldarg.0 
				L_0023: ldarg.0 
				L_0024: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0029: callvirt Sunisoft.IrisSkin.SkinEngine::System.Drawing.Font get_MenuFont()
				L_002e: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x21498b72da0020ba(System.Drawing.Font)
				L_0033: ldarg.0 
				L_0034: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
				L_0039: ldarg.0 
				L_003a: call System.Windows.Forms.Control::Void Invalidate()
				L_003f: ret 
			*/
			
			
			{
				if (this.xacac6b5ffdf089d3)
				{
					if (((SkinEngine) this.xdc87e2b99332cd4a).MenuFont == null)
					{
						this.x21498b72da0020ba (SystemInformation.MenuFont);
					}
					else
					{
						this.x21498b72da0020ba (((SkinEngine) this.xdc87e2b99332cd4a).MenuFont);
					}
					this.x39e008704a72ea56 ();
					base.Invalidate ();
				}
			}
			
			protected void x2b1f4f4697e5ae02 (x5f4b657f68f87baa xccb63ca5f63dc470, x5f4b657f68f87baa.x879a106b0501b9dc x5ca6b6e12a4d9043)
			
			/*
				// Code Size: 13 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
				L_0006: ldarg.0 
				L_0007: call System.Windows.Forms.Control::Void Invalidate()
				L_000c: ret 
			*/
			
			
			{
				this.x39e008704a72ea56 ();
				base.Invalidate ();
			}
			
			protected void x2cc390e9409b0f3f (int x22f50445643d053e, bool x4b9cb2187c13edda)
			
			/*
				// Code Size: 45 Bytes
				.maxstack 6
				.locals (System.Drawing.Graphics V_0)
				.try L_0007 to L_0022 finally L_0022 to L_002c
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::System.Drawing.Graphics CreateGraphics()
				L_0006: stloc.0 
				L_0007: ldarg.0 
				L_0008: ldloc.0 
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_000f: ldarg.1 
				L_0010: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0015: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_001a: ldarg.2 
				L_001b: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xb5a5bdae3ba8936b(System.Drawing.Graphics, Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f, Boolean)
				L_0020: leave.s L_002c
				L_0022: ldloc.0 
				L_0023: brfalse.s L_002b
				L_0025: ldloc.0 
				L_0026: callvirt System.IDisposable::Void Dispose()
				L_002b: endfinally 
				L_002c: ret 
			*/
			
			
			{
				using (Graphics graphics1 = base.CreateGraphics ())
				{
					this.xb5a5bdae3ba8936b (graphics1, (this.xfb5697071ce83988[x22f50445643d053e] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f), x4b9cb2187c13edda);
				}
			}
			
			internal void x2ea07c3ab5d970d4 (x555516122dcc901e.POINT x0ce73f6cbd7d5515)
			
			/*
				// Code Size: 35 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_0006: ldarga.s x0ce73f6cbd7d5515
				L_0008: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean ScreenToClient(IntPtr, POINT ByRef)
				L_000d: pop 
				L_000e: ldarg.0 
				L_000f: ldarga.s x0ce73f6cbd7d5515
				L_0011: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 x
				L_0016: ldarga.s x0ce73f6cbd7d5515
				L_0018: ldfld Sunisoft.IrisSkin.x555516122dcc901e+POINT::Int32 y
				L_001d: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xbcc99f3d02a70fe7(Int32, Int32)
				L_0022: ret 
			*/
			
			
			{
				bool b1 = x61467fe65a98f20c.ScreenToClient (base.Handle, ref x0ce73f6cbd7d5515);
				this.xbcc99f3d02a70fe7 (x0ce73f6cbd7d5515.x, x0ce73f6cbd7d5515.y);
			}
			
			protected void x34de1c54143aa5c7 ()
			
			/*
				// Code Size: 159 Bytes
				.maxstack 5
				.locals (Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_0)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0006: brtrue L_009e
				L_000b: ldarg.0 
				L_000c: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0011: ldc.i4.m1 
				L_0012: beq L_009e
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_001d: brtrue L_009e
				L_0022: ldarg.0 
				L_0023: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_0028: ldarg.0 
				L_0029: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_002e: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0033: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0038: stloc.0 
				L_0039: ldloc.0 
				L_003a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_003f: brtrue.s L_0054
				L_0041: ldloc.0 
				L_0042: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0047: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_004c: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_0051: ldc.i4.0 
				L_0052: blt.s L_009e
				L_0054: ldarg.0 
				L_0055: ldc.i4.1 
				L_0056: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_005b: ldarg.0 
				L_005c: ldc.i4.0 
				L_005d: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xf947c341af20623c
				L_0062: ldarg.0 
				L_0063: ldarg.0 
				L_0064: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0069: ldc.i4.1 
				L_006a: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x2cc390e9409b0f3f(Int32, Boolean)
				L_006f: ldloc.0 
				L_0070: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_0075: brtrue.s L_008a
				L_0077: ldloc.0 
				L_0078: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_007d: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0082: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_0087: ldc.i4.0 
				L_0088: ble.s L_009e
				L_008a: ldarg.0 
				L_008b: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_0090: ldarg.0 
				L_0091: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::UInt32 xd8f9b747f716862a
				L_0096: ldc.i4.0 
				L_0097: ldc.i4.1 
				L_0098: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_009d: pop 
				L_009e: ret 
			*/
			
			
			{
				if (((this.x56be4c3c4c4173b7 != null) || (this.xb266b78561d63b52 == -1)) || this.x9f93ebd2ca5601a2)
				{
					return;
				}
				Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[this.xb266b78561d63b52] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f);
				if (x2cc390e9409b0f3f1.xaa08ea3ba2fe9514 || (x2cc390e9409b0f3f1.x5f4b657f68f87baa.MenuCommands.Count >= 0))
				{
					this.x9f93ebd2ca5601a2 = true;
					this.xf947c341af20623c = false;
					this.x2cc390e9409b0f3f (this.xb266b78561d63b52, true);
					if (x2cc390e9409b0f3f1.xaa08ea3ba2fe9514 || (x2cc390e9409b0f3f1.x5f4b657f68f87baa.MenuCommands.Count > 0))
					{
						bool b1 = x61467fe65a98f20c.PostMessage (base.Handle, this.xd8f9b747f716862a, uint.MinValue, 1);
					}
				}
			}
			
			protected bool x35a6958370d758dd (xd53b20b7b4b2a08a x20e3b25d6d144908)
			
			/*
				// Code Size: 87 Bytes
				.maxstack 4
				.locals (Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_0, 
         System.Boolean V_1, 
         System.Collections.IEnumerator V_2, 
         System.IDisposable V_3)
				.try L_0007 to L_0042 finally L_0042 to L_0053
				L_0000: ldarg.1 
				L_0001: callvirt System.Collections.CollectionBase::System.Collections.IEnumerator GetEnumerator()
				L_0006: stloc.2 
				L_0007: br.s L_0038
				L_0009: ldloc.2 
				L_000a: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_000f: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0014: stloc.0 
				L_0015: ldloc.0 
				L_0016: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_001b: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Boolean get_x6f72c846c7dcb042()
				L_0020: brfalse.s L_0026
				L_0022: ldc.i4.1 
				L_0023: stloc.1 
				L_0024: leave.s L_0055
				L_0026: ldarg.0 
				L_0027: ldloc.0 
				L_0028: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_002d: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x35a6958370d758dd(Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a)
				L_0032: brfalse.s L_0038
				L_0034: ldc.i4.1 
				L_0035: stloc.1 
				L_0036: leave.s L_0055
				L_0038: ldloc.2 
				L_0039: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_003e: brtrue.s L_0009
				L_0040: leave.s L_0053
				L_0042: ldloc.2 
				L_0043: isinst System.IDisposable
				L_0048: stloc.3 
				L_0049: ldloc.3 
				L_004a: brfalse.s L_0052
				L_004c: ldloc.3 
				L_004d: callvirt System.IDisposable::Void Dispose()
				L_0052: endfinally 
				L_0053: ldc.i4.0 
				L_0054: ret 
				L_0055: ldloc.1 
				L_0056: ret 
			*/
			
			
			{
				foreach (x5f4b657f68f87baa x5f4b657f68f87baa1 in x20e3b25d6d144908)
				{
					if (x5f4b657f68f87baa1.MenuCommands.x6f72c846c7dcb042)
					{
						return true;
					}
					else if (this.x35a6958370d758dd (x5f4b657f68f87baa1.MenuCommands))
					{
						return true;
					}
				}
				return false;
			}
			
			internal void x39e008704a72ea56 ()
			
			/*
				// Code Size: 1475 Bytes
				.maxstack 9
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Int32 V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Boolean V_5, 
         System.Int32 V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         System.Int32 V_9, 
         System.Boolean V_10, 
         System.Int32 V_11, 
         System.Drawing.Graphics V_12, 
         System.Int32 V_13, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_14, 
         System.Int32 V_15, 
         System.Drawing.SizeF V_16, 
         System.Drawing.Rectangle V_17, 
         System.Drawing.Rectangle V_18, 
         System.Int32 V_19, 
         System.Int32 V_20, 
         System.Collections.IEnumerator V_21, 
         System.IDisposable V_22)
				.try L_013c to L_042c finally L_042c to L_0441
				.try L_012c to L_0443 finally L_0443 to L_044f
				.try L_0000 to L_05bf catch System.Object L_05bf to L_05c2
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_0006: ldc.i4.1 
				L_0007: bne.un.s L_0012
				L_0009: ldarg.0 
				L_000a: call System.Windows.Forms.Control::Int32 get_Width()
				L_000f: stloc.0 
				L_0010: br.s L_0019
				L_0012: ldarg.0 
				L_0013: call System.Windows.Forms.Control::Int32 get_Height()
				L_0018: stloc.0 
				L_0019: ldloc.0 
				L_001a: ldc.i4.0 
				L_001b: ble L_05bd
				L_0020: ldc.i4.0 
				L_0021: stloc.1 
				L_0022: ldc.i4.0 
				L_0023: stloc.2 
				L_0024: ldarg.0 
				L_0025: newobj System.Collections.ArrayList::Void .ctor()
				L_002a: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_002f: ldc.i4.6 
				L_0030: stloc.3 
				L_0031: ldarg.0 
				L_0032: call System.Windows.Forms.Control::Int32 get_Height()
				L_0037: pop 
				L_0038: ldc.i4.0 
				L_0039: stloc.s V_4
				L_003b: ldloc.0 
				L_003c: ldloc.3 
				L_003d: ldc.i4.s 12
				L_003f: add 
				L_0040: sub 
				L_0041: stloc.0 
				L_0042: ldloc.1 
				L_0043: brtrue.s L_0053
				L_0045: ldarg.0 
				L_0046: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_004b: ldnull 
				L_004c: ceq 
				L_004e: ldc.i4.0 
				L_004f: ceq 
				L_0051: br.s L_0054
				L_0053: ldc.i4.0 
				L_0054: stloc.s V_5
				L_0056: ldloc.s V_5
				L_0058: brfalse.s L_0073
				L_005a: ldarg.0 
				L_005b: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x0544f423fd242fb5
				L_0060: brtrue.s L_0073
				L_0062: ldarg.0 
				L_0063: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_0068: callvirt System.Windows.Forms.Form::System.Windows.Forms.FormWindowState get_WindowState()
				L_006d: ldc.i4.2 
				L_006e: beq.s L_0073
				L_0070: ldc.i4.0 
				L_0071: stloc.s V_5
				L_0073: ldc.i4.0 
				L_0074: stloc.s V_6
				L_0076: ldc.i4.0 
				L_0077: stloc.s V_7
				L_0079: ldc.i4.0 
				L_007a: stloc.s V_8
				L_007c: ldc.i4.0 
				L_007d: stloc.s V_9
				L_007f: ldloc.s V_5
				L_0081: brfalse L_011d
				L_0086: ldarg.0 
				L_0087: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_008c: brfalse L_011d
				L_0091: ldloc.0 
				L_0092: ldc.i4.s 55
				L_0094: sub 
				L_0095: stloc.0 
				L_0096: ldc.i4.1 
				L_0097: stloc.s V_10
				L_0099: ldc.i4.1 
				L_009a: stloc.s V_11
				L_009c: ldarg.0 
				L_009d: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_00a2: ldloc.s V_10
				L_00a4: callvirt Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Void set_x7d7f7b528e13f94c(Boolean)
				L_00a9: ldarg.0 
				L_00aa: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_00af: ldloc.s V_10
				L_00b1: callvirt Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Void set_x7d7f7b528e13f94c(Boolean)
				L_00b6: ldarg.0 
				L_00b7: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_00bc: ldloc.s V_10
				L_00be: callvirt Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Void set_x7d7f7b528e13f94c(Boolean)
				L_00c3: ldarg.0 
				L_00c4: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_00c9: ldloc.s V_11
				L_00cb: callvirt Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Void set_xeae235558dc44397(Int32)
				L_00d0: ldarg.0 
				L_00d1: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_00d6: ldloc.s V_11
				L_00d8: callvirt Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Void set_xeae235558dc44397(Int32)
				L_00dd: ldarg.0 
				L_00de: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_00e3: ldloc.s V_11
				L_00e5: callvirt Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Void set_xeae235558dc44397(Int32)
				L_00ea: ldarg.0 
				L_00eb: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_00f0: ldc.i4.1 
				L_00f1: bne.un.s L_0109
				L_00f3: ldarg.0 
				L_00f4: call System.Windows.Forms.Control::Int32 get_Width()
				L_00f9: ldc.i4.3 
				L_00fa: sub 
				L_00fb: ldc.i4.s 16
				L_00fd: sub 
				L_00fe: stloc.s V_6
				L_0100: ldc.i4.3 
				L_0101: stloc.s V_7
				L_0103: ldc.i4.s -16
				L_0105: stloc.s V_8
				L_0107: br.s L_011d
				L_0109: ldc.i4.3 
				L_010a: stloc.s V_6
				L_010c: ldarg.0 
				L_010d: call System.Windows.Forms.Control::Int32 get_Height()
				L_0112: ldc.i4.3 
				L_0113: sub 
				L_0114: ldc.i4.s 16
				L_0116: sub 
				L_0117: stloc.s V_7
				L_0119: ldc.i4.s -16
				L_011b: stloc.s V_9
				L_011d: ldarg.0 
				L_011e: ldnull 
				L_011f: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x63fd40b32f4be51f
				L_0124: ldarg.0 
				L_0125: call System.Windows.Forms.Control::System.Drawing.Graphics CreateGraphics()
				L_012a: stloc.s V_12
				L_012c: ldc.i4.0 
				L_012d: stloc.s V_13
				L_012f: ldarg.0 
				L_0130: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0135: callvirt System.Collections.CollectionBase::System.Collections.IEnumerator GetEnumerator()
				L_013a: stloc.s V_21
				L_013c: br L_041e
				L_0141: ldloc.s V_21
				L_0143: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0148: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_014d: stloc.s V_14
				L_014f: ldloc.s V_14
				L_0151: ldsfld System.EventArgs::System.EventArgs Empty
				L_0156: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnUpdate(System.EventArgs)
				L_015b: ldloc.s V_14
				L_015d: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Visible()
				L_0162: brfalse L_041e
				L_0167: ldc.i4.0 
				L_0168: stloc.s V_15
				L_016a: ldloc.s V_14
				L_016c: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_0171: ldstr "-"
				L_0176: call System.String::Boolean op_Equality(System.String, System.String)
				L_017b: brfalse.s L_0183
				L_017d: ldc.i4.s 15
				L_017f: stloc.s V_15
				L_0181: br.s L_01a7
				L_0183: ldloc.s V_12
				L_0185: ldloc.s V_14
				L_0187: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_018c: ldarg.0 
				L_018d: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_0192: callvirt System.Drawing.Graphics::System.Drawing.SizeF MeasureString(System.String, System.Drawing.Font)
				L_0197: stloc.s V_16
				L_0199: ldloc.3 
				L_019a: ldloca.s V_16
				L_019c: call System.Drawing.SizeF::Single get_Width()
				L_01a1: conv.i4 
				L_01a2: add 
				L_01a3: ldc.i4.1 
				L_01a4: add 
				L_01a5: stloc.s V_15
				L_01a7: ldarg.0 
				L_01a8: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_01ad: ldc.i4.1 
				L_01ae: bne.un.s L_01cb
				L_01b0: ldloca.s V_17
				L_01b2: ldloc.s V_4
				L_01b4: ldarg.0 
				L_01b5: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xd3f2e0aa29e1f6c9
				L_01ba: ldloc.1 
				L_01bb: mul 
				L_01bc: ldloc.s V_15
				L_01be: ldarg.0 
				L_01bf: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xd3f2e0aa29e1f6c9
				L_01c4: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01c9: br.s L_01e4
				L_01cb: ldloca.s V_17
				L_01cd: ldarg.0 
				L_01ce: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 x55f9f93541a6b942
				L_01d3: ldloc.1 
				L_01d4: mul 
				L_01d5: ldloc.s V_4
				L_01d7: ldarg.0 
				L_01d8: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 x55f9f93541a6b942
				L_01dd: ldloc.s V_15
				L_01df: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01e4: ldloc.s V_4
				L_01e6: ldloc.s V_15
				L_01e8: add 
				L_01e9: stloc.s V_4
				L_01eb: ldloc.2 
				L_01ec: ldc.i4.1 
				L_01ed: add 
				L_01ee: stloc.2 
				L_01ef: ldloc.s V_4
				L_01f1: ldloc.0 
				L_01f2: ble L_0369
				L_01f7: ldloc.2 
				L_01f8: ldc.i4.1 
				L_01f9: ble L_0369
				L_01fe: ldarg.0 
				L_01ff: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x0544f423fd242fb5
				L_0204: brfalse.s L_026b
				L_0206: ldloc.1 
				L_0207: ldc.i4.1 
				L_0208: add 
				L_0209: stloc.1 
				L_020a: ldc.i4.1 
				L_020b: stloc.2 
				L_020c: ldloc.s V_15
				L_020e: stloc.s V_4
				L_0210: ldarg.0 
				L_0211: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_0216: ldc.i4.1 
				L_0217: bne.un.s L_0237
				L_0219: ldloca.s V_17
				L_021b: ldc.i4.0 
				L_021c: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0221: ldloca.s V_17
				L_0223: dup 
				L_0224: call System.Drawing.Rectangle::Int32 get_Y()
				L_0229: ldarg.0 
				L_022a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xd3f2e0aa29e1f6c9
				L_022f: add 
				L_0230: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_0235: br.s L_0253
				L_0237: ldloca.s V_17
				L_0239: dup 
				L_023a: call System.Drawing.Rectangle::Int32 get_X()
				L_023f: ldarg.0 
				L_0240: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 x55f9f93541a6b942
				L_0245: add 
				L_0246: call System.Drawing.Rectangle::Void set_X(Int32)
				L_024b: ldloca.s V_17
				L_024d: ldc.i4.0 
				L_024e: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_0253: ldloc.s V_5
				L_0255: brfalse L_0369
				L_025a: ldloc.1 
				L_025b: ldc.i4.1 
				L_025c: bne.un L_0369
				L_0261: ldloc.0 
				L_0262: ldc.i4.s 51
				L_0264: add 
				L_0265: stloc.0 
				L_0266: br L_0369
				L_026b: ldloc.s V_13
				L_026d: ldarg.0 
				L_026e: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0273: bgt.s L_027b
				L_0275: ldarg.0 
				L_0276: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x51ce8d251f940283()
				L_027b: ldarg.0 
				L_027c: ldloc.s V_14
				L_027e: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x63fd40b32f4be51f
				L_0283: ldarg.0 
				L_0284: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_0289: ldc.i4.1 
				L_028a: bne.un.s L_02cf
				L_028c: ldloca.s V_17
				L_028e: ldc.i4.0 
				L_028f: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_0294: ldloca.s V_17
				L_0296: ldloc.3 
				L_0297: ldc.i4.s 12
				L_0299: add 
				L_029a: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_029f: ldloca.s V_17
				L_02a1: ldarg.0 
				L_02a2: call System.Windows.Forms.Control::Int32 get_Width()
				L_02a7: ldloca.s V_17
				L_02a9: call System.Drawing.Rectangle::Int32 get_Width()
				L_02ae: sub 
				L_02af: call System.Drawing.Rectangle::Void set_X(Int32)
				L_02b4: ldloca.s V_17
				L_02b6: ldarg.0 
				L_02b7: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xd3f2e0aa29e1f6c9
				L_02bc: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_02c1: ldloc.s V_6
				L_02c3: ldloca.s V_17
				L_02c5: call System.Drawing.Rectangle::Int32 get_Width()
				L_02ca: sub 
				L_02cb: stloc.s V_6
				L_02cd: br.s L_030d
				L_02cf: ldloca.s V_17
				L_02d1: ldc.i4.0 
				L_02d2: call System.Drawing.Rectangle::Void set_X(Int32)
				L_02d7: ldloca.s V_17
				L_02d9: ldloc.3 
				L_02da: ldc.i4.s 12
				L_02dc: add 
				L_02dd: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_02e2: ldloca.s V_17
				L_02e4: ldarg.0 
				L_02e5: call System.Windows.Forms.Control::Int32 get_Height()
				L_02ea: ldloc.3 
				L_02eb: ldc.i4.s 12
				L_02ed: add 
				L_02ee: sub 
				L_02ef: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_02f4: ldloca.s V_17
				L_02f6: ldarg.0 
				L_02f7: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 x55f9f93541a6b942
				L_02fc: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0301: ldloc.s V_7
				L_0303: ldloca.s V_17
				L_0305: call System.Drawing.Rectangle::Int32 get_Height()
				L_030a: sub 
				L_030b: stloc.s V_7
				L_030d: ldarg.0 
				L_030e: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_0313: ldc.i4.1 
				L_0314: and 
				L_0315: ldc.i4.1 
				L_0316: bne.un.s L_0351
				L_0318: ldarg.0 
				L_0319: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_031e: ldloc.0 
				L_031f: ldloca.s V_17
				L_0321: call System.Drawing.Rectangle::Int32 get_Right()
				L_0326: sub 
				L_0327: ldloca.s V_17
				L_0329: call System.Drawing.Rectangle::Int32 get_Y()
				L_032e: ldloca.s V_17
				L_0330: call System.Drawing.Rectangle::Int32 get_Width()
				L_0335: ldloca.s V_17
				L_0337: call System.Drawing.Rectangle::Int32 get_Height()
				L_033c: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0341: newobj Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void .ctor(System.Drawing.Rectangle)
				L_0346: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_034b: pop 
				L_034c: br L_042a
				L_0351: ldarg.0 
				L_0352: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_0357: ldloc.s V_17
				L_0359: newobj Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void .ctor(System.Drawing.Rectangle)
				L_035e: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0363: pop 
				L_0364: br L_042a
				L_0369: ldloc.s V_17
				L_036b: stloc.s V_18
				L_036d: ldarg.0 
				L_036e: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_0373: ldc.i4.1 
				L_0374: bne.un.s L_0387
				L_0376: ldloca.s V_18
				L_0378: dup 
				L_0379: call System.Drawing.Rectangle::Int32 get_Height()
				L_037e: ldc.i4.5 
				L_037f: sub 
				L_0380: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_0385: br.s L_039b
				L_0387: ldloca.s V_18
				L_0389: dup 
				L_038a: call System.Drawing.Rectangle::Int32 get_Width()
				L_038f: ldarg.0 
				L_0390: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xe6d633b23b7c9bfe
				L_0395: sub 
				L_0396: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_039b: ldarg.0 
				L_039c: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_03a1: ldc.i4.1 
				L_03a2: and 
				L_03a3: ldc.i4.1 
				L_03a4: bne.un.s L_0401
				L_03a6: ldarg.0 
				L_03a7: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_03ac: ldloc.s V_14
				L_03ae: ldloc.0 
				L_03af: ldloca.s V_17
				L_03b1: call System.Drawing.Rectangle::Int32 get_Right()
				L_03b6: sub 
				L_03b7: ldloca.s V_17
				L_03b9: call System.Drawing.Rectangle::Int32 get_Y()
				L_03be: ldloca.s V_17
				L_03c0: call System.Drawing.Rectangle::Int32 get_Width()
				L_03c5: ldloca.s V_17
				L_03c7: call System.Drawing.Rectangle::Int32 get_Height()
				L_03cc: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_03d1: ldloc.0 
				L_03d2: ldloca.s V_18
				L_03d4: call System.Drawing.Rectangle::Int32 get_Right()
				L_03d9: sub 
				L_03da: ldloca.s V_18
				L_03dc: call System.Drawing.Rectangle::Int32 get_Y()
				L_03e1: ldloca.s V_18
				L_03e3: call System.Drawing.Rectangle::Int32 get_Width()
				L_03e8: ldloca.s V_18
				L_03ea: call System.Drawing.Rectangle::Int32 get_Height()
				L_03ef: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_03f4: newobj Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void .ctor(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa, System.Drawing.Rectangle, System.Drawing.Rectangle)
				L_03f9: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_03fe: pop 
				L_03ff: br.s L_0418
				L_0401: ldarg.0 
				L_0402: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_0407: ldloc.s V_14
				L_0409: ldloc.s V_17
				L_040b: ldloc.s V_18
				L_040d: newobj Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Void .ctor(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa, System.Drawing.Rectangle, System.Drawing.Rectangle)
				L_0412: callvirt System.Collections.ArrayList::Int32 Add(System.Object)
				L_0417: pop 
				L_0418: ldloc.s V_13
				L_041a: ldc.i4.1 
				L_041b: add 
				L_041c: stloc.s V_13
				L_041e: ldloc.s V_21
				L_0420: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0425: brtrue L_0141
				L_042a: leave.s L_0441
				L_042c: ldloc.s V_21
				L_042e: isinst System.IDisposable
				L_0433: stloc.s V_22
				L_0435: ldloc.s V_22
				L_0437: brfalse.s L_0440
				L_0439: ldloc.s V_22
				L_043b: callvirt System.IDisposable::Void Dispose()
				L_0440: endfinally 
				L_0441: leave.s L_044f
				L_0443: ldloc.s V_12
				L_0445: brfalse.s L_044e
				L_0447: ldloc.s V_12
				L_0449: callvirt System.IDisposable::Void Dispose()
				L_044e: endfinally 
				L_044f: ldloc.s V_5
				L_0451: brfalse L_0540
				L_0456: ldarg.0 
				L_0457: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_045c: brfalse L_0540
				L_0461: ldarg.0 
				L_0462: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_0467: callvirt System.Windows.Forms.Form::System.Windows.Forms.FormWindowState get_WindowState()
				L_046c: ldc.i4.2 
				L_046d: bne.un L_0510
				L_0472: ldarg.0 
				L_0473: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_0478: callvirt System.Windows.Forms.Control::Boolean get_Visible()
				L_047d: brtrue.s L_04a0
				L_047f: ldarg.0 
				L_0480: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_0485: callvirt System.Windows.Forms.Control::Void Show()
				L_048a: ldarg.0 
				L_048b: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_0490: callvirt System.Windows.Forms.Control::Void Show()
				L_0495: ldarg.0 
				L_0496: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_049b: callvirt System.Windows.Forms.Control::Void Show()
				L_04a0: ldarg.0 
				L_04a1: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_04a6: ldarg.0 
				L_04a7: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_04ac: callvirt System.Windows.Forms.Form::Boolean get_MinimizeBox()
				L_04b1: callvirt System.Windows.Forms.Control::Void set_Enabled(Boolean)
				L_04b6: ldarg.0 
				L_04b7: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_04bc: ldloc.s V_6
				L_04be: ldloc.s V_7
				L_04c0: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_04c5: callvirt System.Windows.Forms.Control::Void set_Location(System.Drawing.Point)
				L_04ca: ldloc.s V_6
				L_04cc: ldloc.s V_8
				L_04ce: add 
				L_04cf: stloc.s V_6
				L_04d1: ldloc.s V_7
				L_04d3: ldloc.s V_9
				L_04d5: add 
				L_04d6: stloc.s V_7
				L_04d8: ldarg.0 
				L_04d9: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_04de: ldloc.s V_6
				L_04e0: ldloc.s V_7
				L_04e2: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_04e7: callvirt System.Windows.Forms.Control::Void set_Location(System.Drawing.Point)
				L_04ec: ldloc.s V_6
				L_04ee: ldloc.s V_8
				L_04f0: add 
				L_04f1: stloc.s V_6
				L_04f3: ldloc.s V_7
				L_04f5: ldloc.s V_9
				L_04f7: add 
				L_04f8: stloc.s V_7
				L_04fa: ldarg.0 
				L_04fb: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_0500: ldloc.s V_6
				L_0502: ldloc.s V_7
				L_0504: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0509: callvirt System.Windows.Forms.Control::Void set_Location(System.Drawing.Point)
				L_050e: br.s L_0576
				L_0510: ldarg.0 
				L_0511: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_0516: callvirt System.Windows.Forms.Control::Boolean get_Visible()
				L_051b: brfalse.s L_0576
				L_051d: ldarg.0 
				L_051e: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_0523: callvirt System.Windows.Forms.Control::Void Hide()
				L_0528: ldarg.0 
				L_0529: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_052e: callvirt System.Windows.Forms.Control::Void Hide()
				L_0533: ldarg.0 
				L_0534: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_0539: callvirt System.Windows.Forms.Control::Void Hide()
				L_053e: br.s L_0576
				L_0540: ldarg.0 
				L_0541: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_0546: brfalse.s L_0576
				L_0548: ldarg.0 
				L_0549: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_054e: callvirt System.Windows.Forms.Control::Boolean get_Visible()
				L_0553: brfalse.s L_0576
				L_0555: ldarg.0 
				L_0556: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_055b: callvirt System.Windows.Forms.Control::Void Hide()
				L_0560: ldarg.0 
				L_0561: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_0566: callvirt System.Windows.Forms.Control::Void Hide()
				L_056b: ldarg.0 
				L_056c: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_0571: callvirt System.Windows.Forms.Control::Void Hide()
				L_0576: ldarg.0 
				L_0577: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_057c: ldc.i4.1 
				L_057d: bne.un.s L_059f
				L_057f: ldloc.1 
				L_0580: ldc.i4.1 
				L_0581: add 
				L_0582: ldarg.0 
				L_0583: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xd3f2e0aa29e1f6c9
				L_0588: mul 
				L_0589: stloc.s V_19
				L_058b: ldarg.0 
				L_058c: call System.Windows.Forms.Control::Int32 get_Height()
				L_0591: ldloc.s V_19
				L_0593: beq.s L_05bd
				L_0595: ldarg.0 
				L_0596: ldloc.s V_19
				L_0598: call System.Windows.Forms.Control::Void set_Height(Int32)
				L_059d: br.s L_05bd
				L_059f: ldloc.1 
				L_05a0: ldc.i4.1 
				L_05a1: add 
				L_05a2: ldarg.0 
				L_05a3: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 x55f9f93541a6b942
				L_05a8: mul 
				L_05a9: stloc.s V_20
				L_05ab: ldarg.0 
				L_05ac: call System.Windows.Forms.Control::Int32 get_Width()
				L_05b1: ldloc.s V_20
				L_05b3: beq.s L_05bd
				L_05b5: ldarg.0 
				L_05b6: ldloc.s V_20
				L_05b8: call System.Windows.Forms.Control::Void set_Width(Int32)
				L_05bd: leave.s L_05c2
				L_05bf: pop 
				L_05c0: leave.s L_05c2
				L_05c2: ret 
			*/
			
			
			{
				int i1;
				int i2;
				int i3;
				int i4;
				int i5;
				bool b1;
				int i6;
				int i7;
				int i8;
				int i9;
				bool b2;
				int i10;
				int i11;
				x5f4b657f68f87baa x5f4b657f68f87baa1;
				int i12;
				Rectangle rectangle1;
				Rectangle rectangle2;
				int i13;
				int i14;
				IEnumerator iEnumerator1;
				IDisposable iDisposable1;
				try
				{
					if (this.x23e85093ba3a7d1d == Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da)
					{
						i1 = base.Width;
					}
					else
					{
						i1 = base.Height;
					}
					if (i1 > 0)
					{
						i2 = 0;
						i3 = 0;
						this.xfb5697071ce83988 = new ArrayList ();
						i4 = 6;
						int i15 = base.Height;
						i5 = 0;
						i1 -= ((int) (i4 + 12));
						b1 = ((i2 == 0) && (this.x562fa9742b4f7ed5 != null));
						if ((b1 && (! this.x0544f423fd242fb5)) && (this.x562fa9742b4f7ed5.WindowState != FormWindowState.Maximized))
						{
							b1 = false;
						}
						i6 = 0;
						i7 = 0;
						i8 = 0;
						i9 = 0;
						if (b1 && (this.x2c6deb5021c80299 != null))
						{
							i1 -= 55;
							b2 = true;
							i10 = 1;
							this.x2c6deb5021c80299.x7d7f7b528e13f94c = b2;
							this.x0abc55e6ce1d8aed.x7d7f7b528e13f94c = b2;
							this.x26e80f23e22a05ae.x7d7f7b528e13f94c = b2;
							this.x2c6deb5021c80299.xeae235558dc44397 = i10;
							this.x0abc55e6ce1d8aed.xeae235558dc44397 = i10;
							this.x26e80f23e22a05ae.xeae235558dc44397 = i10;
							if (this.x23e85093ba3a7d1d != Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da)
							{
								i6 = 3;
								i7 = ((int) ((base.Height - 3) - 16));
								i9 = -16;
							}
							else
							{
								i6 = ((int) ((base.Width - 3) - 16));
								i7 = 3;
								i8 = -16;
							}
						}
						this.x63fd40b32f4be51f = ((x5f4b657f68f87baa) null);
						using (Graphics graphics1 = base.CreateGraphics ())
						{
							i11 = 0;
							iEnumerator1 = this.xf4f555905eaa2330.GetEnumerator ();
							try
							{
								goto L_041E;
								
							L_01A7:
								
								{
								}
								if (this.x23e85093ba3a7d1d == Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da)
								{
									rectangle1 = new Rectangle (i5, ((int) (this.xd3f2e0aa29e1f6c9 * i2)), i12, this.xd3f2e0aa29e1f6c9);
								}
								else
								{
									rectangle1 = new Rectangle (((int) (this.x55f9f93541a6b942 * i2)), i5, this.x55f9f93541a6b942, i12);
								}
								i5 += i12;
								i3++;
								if ((i5 > i1) && (i3 > 1))
								{
									if (! this.x0544f423fd242fb5)
									{
										if (i11 <= this.xb266b78561d63b52)
										{
											this.x51ce8d251f940283 ();
										}
										this.x63fd40b32f4be51f = x5f4b657f68f87baa1;
										if (this.x23e85093ba3a7d1d != Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da)
										{
											rectangle1.X = 0;
											rectangle1.Height = ((int) (i4 + 12));
											rectangle1.Y = ((int) (base.Height - (i4 + 12)));
											rectangle1.Width = this.x55f9f93541a6b942;
											i7 -= rectangle1.Height;
										}
										else
										{
											rectangle1.Y = 0;
											rectangle1.Width = ((int) (i4 + 12));
											rectangle1.X = (base.Width - rectangle1.Width);
											rectangle1.Height = this.xd3f2e0aa29e1f6c9;
											i6 -= rectangle1.Width;
										}
										if ((this.RightToLeft & System.Windows.Forms.RightToLeft.Yes) == System.Windows.Forms.RightToLeft.Yes)
										{
											int i16 = this.xfb5697071ce83988.Add (new Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f (new Rectangle (((int) (i1 - rectangle1.Right)), rectangle1.Y, rectangle1.Width, rectangle1.Height)));
										}
										else
										{
											int i17 = this.xfb5697071ce83988.Add (new Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f (rectangle1));
										}
										goto L_042A;
									}
									else
									{
										i2++;
										i3 = 1;
										i5 = i12;
										if (this.x23e85093ba3a7d1d == Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da)
										{
											rectangle1.X = 0;
											rectangle1.Y += this.xd3f2e0aa29e1f6c9;
										}
										else
										{
											rectangle1.X += this.x55f9f93541a6b942;
											rectangle1.Y = 0;
										}
										if (b1 && (i2 == 1))
										{
											i1 += 51;
										}
									}
								}
								rectangle2 = rectangle1;
								if (this.x23e85093ba3a7d1d == Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da)
								{
									rectangle2.Height -= 5;
								}
								else
								{
									rectangle2.Width -= this.xe6d633b23b7c9bfe;
								}
								if ((this.RightToLeft & System.Windows.Forms.RightToLeft.Yes) == System.Windows.Forms.RightToLeft.Yes)
								{
									int i18 = this.xfb5697071ce83988.Add (new Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f (x5f4b657f68f87baa1, new Rectangle (((int) (i1 - rectangle1.Right)), rectangle1.Y, rectangle1.Width, rectangle1.Height), new Rectangle (((int) (i1 - rectangle2.Right)), rectangle2.Y, rectangle2.Width, rectangle2.Height)));
								}
								else
								{
									int i19 = this.xfb5697071ce83988.Add (new Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f (x5f4b657f68f87baa1, rectangle1, rectangle2));
								}
								i11++;
								
							L_041E:
								
								{
								}
								while (iEnumerator1.MoveNext ())
								{
									x5f4b657f68f87baa1 = ((x5f4b657f68f87baa) iEnumerator1.Current);
									x5f4b657f68f87baa1.OnUpdate (EventArgs.Empty);
									if (x5f4b657f68f87baa1.Visible)
									{
										i12 = 0;
										if (x5f4b657f68f87baa1.Text != "-")
										{
											i12 = ((i4 + ((int) graphics1.MeasureString (x5f4b657f68f87baa1.Text, this.Font).Width)) + 1);
											goto L_01A7;
										}
										i12 = 15;
										goto L_01A7;
									}
								}
								
							L_042A:
								
								{
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
						}
						if (b1 && (this.x2c6deb5021c80299 != null))
						{
							if (this.x562fa9742b4f7ed5.WindowState == FormWindowState.Maximized)
							{
								if (! this.x2c6deb5021c80299.Visible)
								{
									this.x2c6deb5021c80299.Show ();
									this.x0abc55e6ce1d8aed.Show ();
									this.x26e80f23e22a05ae.Show ();
								}
								this.x2c6deb5021c80299.Enabled = this.x562fa9742b4f7ed5.MinimizeBox;
								this.x26e80f23e22a05ae.Location = new Point (i6, i7);
								i6 += i8;
								i7 += i9;
								this.x0abc55e6ce1d8aed.Location = new Point (i6, i7);
								i6 += i8;
								i7 += i9;
								this.x2c6deb5021c80299.Location = new Point (i6, i7);
							}
							else if (this.x2c6deb5021c80299.Visible)
							{
								this.x2c6deb5021c80299.Hide ();
								this.x0abc55e6ce1d8aed.Hide ();
								this.x26e80f23e22a05ae.Hide ();
							}
						}
						else if ((this.x2c6deb5021c80299 != null) && this.x2c6deb5021c80299.Visible)
						{
							this.x2c6deb5021c80299.Hide ();
							this.x0abc55e6ce1d8aed.Hide ();
							this.x26e80f23e22a05ae.Hide ();
						}
						if (this.x23e85093ba3a7d1d == Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da)
						{
							i13 = ((i2 + 1) * this.xd3f2e0aa29e1f6c9);
							if (base.Height != i13)
							{
								base.Height = i13;
							}
						}
						else
						{
							i14 = ((i2 + 1) * this.x55f9f93541a6b942);
							if (base.Width != i14)
							{
								base.Width = i14;
							}
						}
					}
				}
				catch
				{
				}
			}
			
			private void x43d97dcf909b3bd3 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 30 Bytes
				.maxstack 2
				.try L_0008 to L_001a catch System.Object L_001a to L_001d
				L_0000: ldarg.1 
				L_0001: isinst Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0006: brfalse.s L_001d
				L_0008: ldarg.1 
				L_0009: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_000e: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Form xb7d28b7a6d50662f
				L_0013: callvirt System.Windows.Forms.Form::Void Activate()
				L_0018: leave.s L_001d
				L_001a: pop 
				L_001b: leave.s L_001d
				L_001d: ret 
			*/
			
			
			{
				if (xe0292b9ed559da7d is x5f4b657f68f87baa)
				{
					try
					{
						((x5f4b657f68f87baa) xe0292b9ed559da7d).xb7d28b7a6d50662f.Activate ();
					}
					catch
					{
					}
				}
			}
			
			protected void x4d43bed1b4aede85 ()
			
			/*
				// Code Size: 25 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xcb97d93f0d5ce4a8()
				L_0006: ldarg.0 
				L_0007: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x51ce8d251f940283()
				L_000c: ldarg.0 
				L_000d: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
				L_0012: ldarg.0 
				L_0013: call System.Windows.Forms.Control::Void Invalidate()
				L_0018: ret 
			*/
			
			
			{
				this.xcb97d93f0d5ce4a8 ();
				this.x51ce8d251f940283 ();
				this.x39e008704a72ea56 ();
				base.Invalidate ();
			}
			
			protected bool x4d7a264852c9d2f3 (Shortcut x10364107371ea04e, xd53b20b7b4b2a08a x20e3b25d6d144908)
			
			/*
				// Code Size: 117 Bytes
				.maxstack 5
				.locals (Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_0, 
         System.Boolean V_1, 
         System.Collections.IEnumerator V_2, 
         System.IDisposable V_3)
				.try L_0007 to L_0060 finally L_0060 to L_0071
				L_0000: ldarg.2 
				L_0001: callvirt System.Collections.CollectionBase::System.Collections.IEnumerator GetEnumerator()
				L_0006: stloc.2 
				L_0007: br.s L_0056
				L_0009: ldloc.2 
				L_000a: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_000f: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0014: stloc.0 
				L_0015: ldloc.0 
				L_0016: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Enabled()
				L_001b: brfalse.s L_0035
				L_001d: ldloc.0 
				L_001e: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.Windows.Forms.Shortcut get_Shortcut()
				L_0023: ldarg.1 
				L_0024: bne.un.s L_0035
				L_0026: ldloc.0 
				L_0027: ldsfld System.EventArgs::System.EventArgs Empty
				L_002c: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnClick(System.EventArgs)
				L_0031: ldc.i4.1 
				L_0032: stloc.1 
				L_0033: leave.s L_0073
				L_0035: ldloc.0 
				L_0036: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_003b: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_0040: ldc.i4.0 
				L_0041: ble.s L_0056
				L_0043: ldarg.0 
				L_0044: ldarg.1 
				L_0045: ldloc.0 
				L_0046: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_004b: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x4d7a264852c9d2f3(System.Windows.Forms.Shortcut, Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a)
				L_0050: brfalse.s L_0056
				L_0052: ldc.i4.1 
				L_0053: stloc.1 
				L_0054: leave.s L_0073
				L_0056: ldloc.2 
				L_0057: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_005c: brtrue.s L_0009
				L_005e: leave.s L_0071
				L_0060: ldloc.2 
				L_0061: isinst System.IDisposable
				L_0066: stloc.3 
				L_0067: ldloc.3 
				L_0068: brfalse.s L_0070
				L_006a: ldloc.3 
				L_006b: callvirt System.IDisposable::Void Dispose()
				L_0070: endfinally 
				L_0071: ldc.i4.0 
				L_0072: ret 
				L_0073: ldloc.1 
				L_0074: ret 
			*/
			
			
			{
				foreach (x5f4b657f68f87baa x5f4b657f68f87baa1 in x20e3b25d6d144908)
				{
					if (x5f4b657f68f87baa1.Enabled && (x5f4b657f68f87baa1.Shortcut == x10364107371ea04e))
					{
						x5f4b657f68f87baa1.OnClick (EventArgs.Empty);
						return true;
					}
					else if ((x5f4b657f68f87baa1.MenuCommands.Count > 0) && this.x4d7a264852c9d2f3 (x10364107371ea04e, x5f4b657f68f87baa1.MenuCommands))
					{
						return true;
					}
				}
				return false;
			}
			
			protected void x51ce8d251f940283 ()
			
			/*
				// Code Size: 60 Bytes
				.maxstack 4
				.locals (Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_0)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0006: ldc.i4.m1 
				L_0007: beq.s L_003b
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_000f: ldarg.0 
				L_0010: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0015: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_001a: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_001f: stloc.0 
				L_0020: ldloc.0 
				L_0021: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0026: brfalse.s L_0034
				L_0028: ldarg.0 
				L_0029: ldloc.0 
				L_002a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_002f: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void OnDeselected(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0034: ldarg.0 
				L_0035: ldc.i4.m1 
				L_0036: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_003b: ret 
			*/
			
			
			{
				if (this.xb266b78561d63b52 == -1)
				{
					return;
				}
				Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[this.xb266b78561d63b52] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f);
				if (x2cc390e9409b0f3f1.x5f4b657f68f87baa != null)
				{
					this.OnDeselected (x2cc390e9409b0f3f1.x5f4b657f68f87baa);
				}
				this.xb266b78561d63b52 = -1;
			}
			
			protected void x58049cd54e5ca4e3 (bool x651d82357ffa4398)
			
			/*
				// Code Size: 207 Bytes
				.maxstack 5
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Int32 V_2, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_3)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0006: brtrue L_00ce
				L_000b: ldarg.0 
				L_000c: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0011: stloc.0 
				L_0012: ldloc.0 
				L_0013: stloc.1 
				L_0014: ldc.i4.0 
				L_0015: stloc.2 
				L_0016: br L_00bd
				L_001b: ldloc.0 
				L_001c: ldc.i4.1 
				L_001d: sub 
				L_001e: stloc.0 
				L_001f: ldloc.0 
				L_0020: ldloc.1 
				L_0021: bne.un.s L_0024
				L_0023: ret 
				L_0024: ldloc.0 
				L_0025: ldc.i4.0 
				L_0026: bge.s L_0036
				L_0028: ldarg.0 
				L_0029: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_002e: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_0033: ldc.i4.1 
				L_0034: sub 
				L_0035: stloc.0 
				L_0036: ldarg.0 
				L_0037: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_003c: ldloc.0 
				L_003d: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0042: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0047: stloc.3 
				L_0048: ldloc.3 
				L_0049: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x43604484a3deae4f()
				L_004e: brtrue.s L_00b9
				L_0050: ldloc.3 
				L_0051: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_0056: brtrue.s L_0065
				L_0058: ldloc.3 
				L_0059: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_005e: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Enabled()
				L_0063: brfalse.s L_00b9
				L_0065: ldloc.0 
				L_0066: ldarg.0 
				L_0067: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_006c: beq.s L_00b9
				L_006e: ldarg.0 
				L_006f: ldarg.0 
				L_0070: ldarg.0 
				L_0071: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0076: ldloc.0 
				L_0077: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xa7cbddf1ec7a27e7(Int32, Int32)
				L_007c: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0081: ldarg.0 
				L_0082: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_0087: brfalse.s L_00ce
				L_0089: ldloc.3 
				L_008a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_008f: brtrue.s L_00a4
				L_0091: ldloc.3 
				L_0092: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0097: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_009c: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_00a1: ldc.i4.0 
				L_00a2: ble.s L_00ce
				L_00a4: ldarg.0 
				L_00a5: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_00aa: ldarg.0 
				L_00ab: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::UInt32 xd8f9b747f716862a
				L_00b0: ldc.i4.0 
				L_00b1: ldc.i4.1 
				L_00b2: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_00b7: pop 
				L_00b8: ret 
				L_00b9: ldloc.2 
				L_00ba: ldc.i4.1 
				L_00bb: add 
				L_00bc: stloc.2 
				L_00bd: ldloc.2 
				L_00be: ldarg.0 
				L_00bf: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_00c4: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_00c9: blt L_001b
				L_00ce: ret 
			*/
			
			
			{
				int i3;
				Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				if (this.x56be4c3c4c4173b7 != null)
				{
					return;
				}
				int i1 = this.xb266b78561d63b52;
				int i2 = i1;
				for (i3 = 0; (i3 < this.xfb5697071ce83988.Count); i3++)
				{
					i1--;
					if (i1 == i2)
					{
						return;
					}
					if (i1 < 0)
					{
						i1 = (this.xfb5697071ce83988.Count - 1);
					}
					x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[i1] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f);
					if (((! x2cc390e9409b0f3f1.x43604484a3deae4f) && (x2cc390e9409b0f3f1.xaa08ea3ba2fe9514 || x2cc390e9409b0f3f1.x5f4b657f68f87baa.Enabled)) && (i1 != this.xb266b78561d63b52))
					{
						this.xb266b78561d63b52 = this.xa7cbddf1ec7a27e7 (this.xb266b78561d63b52, i1);
						if ((! this.x9f93ebd2ca5601a2) || ((! x2cc390e9409b0f3f1.xaa08ea3ba2fe9514) && (x2cc390e9409b0f3f1.x5f4b657f68f87baa.MenuCommands.Count <= 0)))
						{
							return;
						}
						bool b1 = x61467fe65a98f20c.PostMessage (base.Handle, this.xd8f9b747f716862a, uint.MinValue, 1);
						return;
					}
				}
			}
			
			protected bool x58b2784e55b43ddd (ref x40255b11ef821fa3.MSG x8a41fbc87a3fb305)
			
			/*
				// Code Size: 770 Bytes
				.maxstack 5
				.locals (System.Boolean V_0, 
         System.Drawing.Point V_1, 
         System.UInt16 V_2, 
         System.UInt16 V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Windows.Forms.Shortcut V_6, 
         System.Windows.Forms.Shortcut V_7, 
         System.UInt32 V_8, 
         System.Drawing.Rectangle V_9)
				L_0000: ldc.i4.0 
				L_0001: stloc.0 
				L_0002: ldarg.1 
				L_0003: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::UInt32 message
				L_0008: stloc.s V_8
				L_000a: ldloc.s V_8
				L_000c: ldc.i4 261
				L_0011: bgt.un.s L_0069
				L_0013: ldloc.s V_8
				L_0015: ldc.i4 164
				L_001a: bgt.un.s L_0036
				L_001c: ldloc.s V_8
				L_001e: ldc.i4 161
				L_0023: beq L_009e
				L_0028: ldloc.s V_8
				L_002a: ldc.i4 164
				L_002f: beq.s L_009e
				L_0031: br L_0300
				L_0036: ldloc.s V_8
				L_0038: ldc.i4 167
				L_003d: beq.s L_009e
				L_003f: ldloc.s V_8
				L_0041: ldc.i4 256
				L_0046: sub 
				L_0047: switch (L_00ea, L_025b, L_0300, L_0300, L_02a2, L_0262)
				L_0064: br L_0300
				L_0069: ldloc.s V_8
				L_006b: ldc.i4 516
				L_0070: bgt.un.s L_0089
				L_0072: ldloc.s V_8
				L_0074: ldc.i4 513
				L_0079: beq.s L_009e
				L_007b: ldloc.s V_8
				L_007d: ldc.i4 516
				L_0082: beq.s L_009e
				L_0084: br L_0300
				L_0089: ldloc.s V_8
				L_008b: ldc.i4 519
				L_0090: beq.s L_009e
				L_0092: ldloc.s V_8
				L_0094: ldc.i4 523
				L_0099: bne.un L_0300
				L_009e: ldloca.s V_1
				L_00a0: ldarg.1 
				L_00a1: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr lParam
				L_00a6: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_00ab: ldc.i4 65535
				L_00b0: and 
				L_00b1: ldarg.1 
				L_00b2: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr lParam
				L_00b7: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_00bc: ldc.i4 -65536
				L_00c1: and 
				L_00c2: ldc.i4.s 16
				L_00c4: shr.un 
				L_00c5: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_00ca: ldarg.0 
				L_00cb: call System.Windows.Forms.Control::System.Drawing.Rectangle get_ClientRectangle()
				L_00d0: stloc.s V_9
				L_00d2: ldloca.s V_9
				L_00d4: ldloc.1 
				L_00d5: call System.Drawing.Rectangle::Boolean Contains(System.Drawing.Point)
				L_00da: brtrue L_0300
				L_00df: ldarg.0 
				L_00e0: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xa23d095e6e52c5f3()
				L_00e5: br L_0300
				L_00ea: ldc.i4.s 16
				L_00ec: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt16 GetKeyState(Int32)
				L_00f1: stloc.2 
				L_00f2: ldc.i4.s 17
				L_00f4: call Sunisoft.IrisSkin.x61467fe65a98f20c::UInt16 GetKeyState(Int32)
				L_00f9: stloc.3 
				L_00fa: ldarg.1 
				L_00fb: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr wParam
				L_0100: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_0105: stloc.s V_4
				L_0107: ldloc.s V_4
				L_0109: stloc.s V_5
				L_010b: ldloc.2 
				L_010c: conv.i4 
				L_010d: ldc.i4 32768
				L_0112: and 
				L_0113: brfalse.s L_011f
				L_0115: ldloc.s V_5
				L_0117: ldc.i4 65536
				L_011c: add 
				L_011d: stloc.s V_5
				L_011f: ldloc.3 
				L_0120: conv.i4 
				L_0121: ldc.i4 32768
				L_0126: and 
				L_0127: brfalse.s L_0133
				L_0129: ldloc.s V_5
				L_012b: ldc.i4 131072
				L_0130: add 
				L_0131: stloc.s V_5
				L_0133: ldloc.s V_5
				L_0135: ldc.i4.s 27
				L_0137: bne.un.s L_016a
				L_0139: ldarg.0 
				L_013a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_013f: ldc.i4.m1 
				L_0140: beq.s L_015d
				L_0142: ldarg.0 
				L_0143: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0148: brtrue.s L_015d
				L_014a: ldarg.0 
				L_014b: ldarg.0 
				L_014c: ldarg.0 
				L_014d: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0152: ldc.i4.m1 
				L_0153: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xa7cbddf1ec7a27e7(Int32, Int32)
				L_0158: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_015d: ldarg.0 
				L_015e: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xa23d095e6e52c5f3()
				L_0163: ldc.i4.1 
				L_0164: stloc.0 
				L_0165: br L_0300
				L_016a: ldloc.s V_5
				L_016c: ldc.i4.s 37
				L_016e: bne.un.s L_0196
				L_0170: ldarg.0 
				L_0171: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_0176: ldc.i4.1 
				L_0177: bne.un.s L_0180
				L_0179: ldarg.0 
				L_017a: ldc.i4.0 
				L_017b: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x58049cd54e5ca4e3(Boolean)
				L_0180: ldarg.0 
				L_0181: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_0186: brfalse.s L_018f
				L_0188: ldarg.0 
				L_0189: ldc.i4.1 
				L_018a: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x72c40adab6f1d6f3
				L_018f: ldc.i4.1 
				L_0190: stloc.0 
				L_0191: br L_0300
				L_0196: ldloc.s V_5
				L_0198: ldc.i4.s 39
				L_019a: bne.un.s L_01ca
				L_019c: ldarg.0 
				L_019d: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_01a2: ldc.i4.1 
				L_01a3: bne.un.s L_01ae
				L_01a5: ldarg.0 
				L_01a6: ldc.i4.0 
				L_01a7: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x14014e142c6b152c(Boolean)
				L_01ac: br.s L_01b4
				L_01ae: ldarg.0 
				L_01af: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x34de1c54143aa5c7()
				L_01b4: ldarg.0 
				L_01b5: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_01ba: brfalse.s L_01c3
				L_01bc: ldarg.0 
				L_01bd: ldc.i4.1 
				L_01be: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x72c40adab6f1d6f3
				L_01c3: ldc.i4.1 
				L_01c4: stloc.0 
				L_01c5: br L_0300
				L_01ca: ldloc.s V_5
				L_01cc: ldc.i4.s 13
				L_01ce: bne.un.s L_01dd
				L_01d0: ldarg.0 
				L_01d1: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x830edbe776f7cc9f()
				L_01d6: ldc.i4.1 
				L_01d7: stloc.0 
				L_01d8: br L_0300
				L_01dd: ldloc.s V_5
				L_01df: ldc.i4.s 40
				L_01e1: bne.un.s L_0202
				L_01e3: ldarg.0 
				L_01e4: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_01e9: ldc.i4.1 
				L_01ea: bne.un.s L_01f4
				L_01ec: ldarg.0 
				L_01ed: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x34de1c54143aa5c7()
				L_01f2: br.s L_01fb
				L_01f4: ldarg.0 
				L_01f5: ldc.i4.0 
				L_01f6: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x14014e142c6b152c(Boolean)
				L_01fb: ldc.i4.1 
				L_01fc: stloc.0 
				L_01fd: br L_0300
				L_0202: ldloc.s V_5
				L_0204: ldc.i4.s 38
				L_0206: bne.un.s L_0216
				L_0208: ldarg.0 
				L_0209: ldc.i4.0 
				L_020a: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x58049cd54e5ca4e3(Boolean)
				L_020f: ldc.i4.1 
				L_0210: stloc.0 
				L_0211: br L_0300
				L_0216: ldloc.s V_5
				L_0218: stloc.s V_6
				L_021a: ldarg.0 
				L_021b: ldloc.s V_6
				L_021d: ldarg.0 
				L_021e: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_0223: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x4d7a264852c9d2f3(System.Windows.Forms.Shortcut, Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a)
				L_0228: brtrue.s L_024e
				L_022a: ldarg.0 
				L_022b: ldarg.1 
				L_022c: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr wParam
				L_0231: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_0236: conv.u2 
				L_0237: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x65c1cc54cc8b0e75(Char)
				L_023c: pop 
				L_023d: ldarg.0 
				L_023e: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_0243: brfalse.s L_0254
				L_0245: ldarg.0 
				L_0246: ldc.i4.1 
				L_0247: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x72c40adab6f1d6f3
				L_024c: br.s L_0254
				L_024e: ldarg.0 
				L_024f: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xa23d095e6e52c5f3()
				L_0254: ldc.i4.1 
				L_0255: stloc.0 
				L_0256: br L_0300
				L_025b: ldc.i4.1 
				L_025c: stloc.0 
				L_025d: br L_0300
				L_0262: ldarg.1 
				L_0263: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr wParam
				L_0268: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_026d: ldc.i4.s 18
				L_026f: bne.un L_0300
				L_0274: ldarg.0 
				L_0275: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_027a: ldc.i4.m1 
				L_027b: beq.s L_0298
				L_027d: ldarg.0 
				L_027e: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0283: brtrue.s L_0298
				L_0285: ldarg.0 
				L_0286: ldarg.0 
				L_0287: ldarg.0 
				L_0288: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_028d: ldc.i4.m1 
				L_028e: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xa7cbddf1ec7a27e7(Int32, Int32)
				L_0293: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0298: ldarg.0 
				L_0299: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xa23d095e6e52c5f3()
				L_029e: ldc.i4.1 
				L_029f: stloc.0 
				L_02a0: br.s L_0300
				L_02a2: ldarg.1 
				L_02a3: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr wParam
				L_02a8: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_02ad: ldc.i4.s 18
				L_02af: beq.s L_0300
				L_02b1: ldc.i4 262144
				L_02b6: ldarg.1 
				L_02b7: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr wParam
				L_02bc: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_02c1: add 
				L_02c2: stloc.s V_7
				L_02c4: ldarg.0 
				L_02c5: ldloc.s V_7
				L_02c7: ldarg.0 
				L_02c8: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_02cd: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x4d7a264852c9d2f3(System.Windows.Forms.Shortcut, Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a)
				L_02d2: brtrue.s L_02f8
				L_02d4: ldarg.0 
				L_02d5: ldarg.1 
				L_02d6: ldfld Sunisoft.IrisSkin.x40255b11ef821fa3+MSG::IntPtr wParam
				L_02db: call System.IntPtr::Int32 op_Explicit(IntPtr)
				L_02e0: conv.u2 
				L_02e1: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x65c1cc54cc8b0e75(Char)
				L_02e6: pop 
				L_02e7: ldarg.0 
				L_02e8: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_02ed: brfalse.s L_02fe
				L_02ef: ldarg.0 
				L_02f0: ldc.i4.1 
				L_02f1: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x72c40adab6f1d6f3
				L_02f6: br.s L_02fe
				L_02f8: ldarg.0 
				L_02f9: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xa23d095e6e52c5f3()
				L_02fe: ldc.i4.1 
				L_02ff: stloc.0 
				L_0300: ldloc.0 
				L_0301: ret 
			*/
			
			
			{
				bool b1;
				Point point1;
				UInt16 uInt16_1;
				UInt16 uInt16_2;
				int i1;
				int i2;
				Shortcut shortcut1;
				Shortcut shortcut2;
				uint uInt32_1;
				b1 = false;
				uInt32_1 = x8a41fbc87a3fb305.message;
				if (uInt32_1 < 261)
				{
					if (uInt32_1 < 164)
					{
						if ((uInt32_1 != 161) && (uInt32_1 != 164))
						{
							return b1;
						}
					}
					else if (uInt32_1 != 167)
					{
						switch ((int) uInt32_1)
						{
							case 256:
							
							{
									uInt16_1 = x61467fe65a98f20c.GetKeyState (16);
									uInt16_2 = x61467fe65a98f20c.GetKeyState (17);
									i1 = ((int) x8a41fbc87a3fb305.wParam);
									i2 = i1;
									if ((((int) uInt16_1) & 32768) == 0)
									{
										goto L_011F;
									}
									i2 += 65536;
									goto L_011F;
							}
							case 257:
							
							{
									return true;
							}
							case 258:
							case 259:
							
							{
									return b1;
							}
							case 260:
							
							{
									if (((int) x8a41fbc87a3fb305.wParam) == 18)
									{
										return b1;
									}
									shortcut2 = ((Shortcut) (262144 + ((int) x8a41fbc87a3fb305.wParam)));
									if (this.x4d7a264852c9d2f3 (shortcut2, this.xf4f555905eaa2330))
									{
										this.xa23d095e6e52c5f3 ();
										return true;
									}
									bool b3 = this.x65c1cc54cc8b0e75 (((char) ((UInt16) ((int) x8a41fbc87a3fb305.wParam))));
									if (! this.x9f93ebd2ca5601a2)
									{
										return true;
									}
									this.x72c40adab6f1d6f3 = true;
									return true;
							}
							case 261:
							
							{
									if (((int) x8a41fbc87a3fb305.wParam) != 18)
									{
										return b1;
									}
									if ((this.xb266b78561d63b52 == -1) || (this.x56be4c3c4c4173b7 != null))
									{
										goto L_0298;
									}
									this.xb266b78561d63b52 = this.xa7cbddf1ec7a27e7 (this.xb266b78561d63b52, -1);
									goto L_0298;
							}
						}
						return b1;
					}
				}
				else if (uInt32_1 < 516)
				{
					if ((uInt32_1 != 513) && (uInt32_1 != 516))
					{
						return b1;
					}
				}
				else if ((uInt32_1 != 519) && (uInt32_1 != 523))
				{
					return b1;
				}
				point1 = new Point (((int) (((int) x8a41fbc87a3fb305.lParam) & 65535)), ((int) ((((int) x8a41fbc87a3fb305.lParam) & -65536) >> 16)));
				if (base.ClientRectangle.Contains (point1))
				{
					return b1;
				}
				this.xa23d095e6e52c5f3 ();
				return b1;
				
			L_011F:
				
				{
				}
				if ((((int) uInt16_2) & 32768) != 0)
				{
					i2 += 131072;
				}
				if (i2 == 27)
				{
					if ((this.xb266b78561d63b52 != -1) && (this.x56be4c3c4c4173b7 == null))
					{
						this.xb266b78561d63b52 = this.xa7cbddf1ec7a27e7 (this.xb266b78561d63b52, -1);
					}
					this.xa23d095e6e52c5f3 ();
					return true;
				}
				if (i2 == 37)
				{
					if (this.x23e85093ba3a7d1d == Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da)
					{
						this.x58049cd54e5ca4e3 (false);
					}
					if (this.x9f93ebd2ca5601a2)
					{
						this.x72c40adab6f1d6f3 = true;
					}
					return true;
				}
				if (i2 != 39)
				{
					if (i2 == 13)
					{
						this.x830edbe776f7cc9f ();
						return true;
					}
					else
					{
						if (i2 != 40)
						{
							if (i2 != 38)
							{
								shortcut1 = ((Shortcut) i2);
								if (this.x4d7a264852c9d2f3 (shortcut1, this.xf4f555905eaa2330))
								{
									this.xa23d095e6e52c5f3 ();
								}
								else
								{
									bool b2 = this.x65c1cc54cc8b0e75 (((char) ((UInt16) ((int) x8a41fbc87a3fb305.wParam))));
									if (this.x9f93ebd2ca5601a2)
									{
										this.x72c40adab6f1d6f3 = true;
									}
								}
								return true;
							}
							else
							{
								this.x58049cd54e5ca4e3 (false);
								return true;
							}
						}
						if (this.x23e85093ba3a7d1d != Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da)
						{
							this.x14014e142c6b152c (false);
						}
						else
						{
							this.x34de1c54143aa5c7 ();
						}
						return true;
					}
				}
				if (this.x23e85093ba3a7d1d == Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da)
				{
					this.x14014e142c6b152c (false);
				}
				else
				{
					this.x34de1c54143aa5c7 ();
				}
				if (this.x9f93ebd2ca5601a2)
				{
					this.x72c40adab6f1d6f3 = true;
				}
				return true;
				
			L_0298:
				
				{
				}
				this.xa23d095e6e52c5f3 ();
				return true;
			}
			
			protected void x5cb0c63a7cf35b53 (int xc0c4c459c6ccbd00, object xbcea506a33cf9111)
			
			/*
				// Code Size: 25 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xcb97d93f0d5ce4a8()
				L_0006: ldarg.0 
				L_0007: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x51ce8d251f940283()
				L_000c: ldarg.0 
				L_000d: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
				L_0012: ldarg.0 
				L_0013: call System.Windows.Forms.Control::Void Invalidate()
				L_0018: ret 
			*/
			
			
			{
				this.xcb97d93f0d5ce4a8 ();
				this.x51ce8d251f940283 ();
				this.x39e008704a72ea56 ();
				base.Invalidate ();
			}
			
			protected void x60cdc457bc0610f8 ()
			
			/*
				// Code Size: 198 Bytes
				.maxstack 6
				.locals (System.Windows.Forms.Form V_0, 
         System.Boolean V_1, 
         Sunisoft.IrisSkin.x40255b11ef821fa3+MSG V_2)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x44d0011ba55ea8a3
				L_0006: brtrue L_00c5
				L_000b: ldarg.0 
				L_000c: ldc.i4.1 
				L_000d: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x44d0011ba55ea8a3
				L_0012: ldarg.0 
				L_0013: ldc.i4.1 
				L_0014: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x20ad2840ee62b6a4
				L_0019: ldarg.0 
				L_001a: call System.Windows.Forms.Control::System.Windows.Forms.Form FindForm()
				L_001f: stloc.0 
				L_0020: ldloc.0 
				L_0021: ldarg.0 
				L_0022: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x92abb6992cd92749(System.Object, System.EventArgs)
				L_0028: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_002d: callvirt System.Windows.Forms.Form::Void add_Deactivate(System.EventHandler)
				L_0032: ldsfld System.IntPtr::IntPtr Zero
				L_0037: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean HideCaret(IntPtr)
				L_003c: stloc.1 
				L_003d: ldloca.s V_2
				L_003f: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+MSG
				L_0045: ldarg.0 
				L_0046: ldc.i4.0 
				L_0047: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9a75ed38d1972c87
				L_004c: br.s L_0096
				L_004e: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean WaitMessage()
				L_0053: brfalse.s L_0096
				L_0055: br.s L_0081
				L_0057: ldloca.s V_2
				L_0059: ldsfld System.IntPtr::IntPtr Zero
				L_005e: ldc.i4.0 
				L_005f: ldc.i4.0 
				L_0060: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean GetMessage(MSG ByRef, IntPtr, UInt32, UInt32)
				L_0065: brfalse.s L_0081
				L_0067: ldarg.0 
				L_0068: ldloca.s V_2
				L_006a: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x58b2784e55b43ddd(MSG ByRef)
				L_006f: brtrue.s L_0081
				L_0071: ldloca.s V_2
				L_0073: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean TranslateMessage(MSG ByRef)
				L_0078: pop 
				L_0079: ldloca.s V_2
				L_007b: call Sunisoft.IrisSkin.x61467fe65a98f20c::IntPtr DispatchMessage(MSG ByRef)
				L_0080: pop 
				L_0081: ldarg.0 
				L_0082: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9a75ed38d1972c87
				L_0087: brtrue.s L_0096
				L_0089: ldloca.s V_2
				L_008b: ldc.i4.0 
				L_008c: ldc.i4.0 
				L_008d: ldc.i4.0 
				L_008e: ldc.i4.0 
				L_008f: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PeekMessage(MSG ByRef, Int32, UInt32, UInt32, UInt32)
				L_0094: brtrue.s L_0057
				L_0096: ldarg.0 
				L_0097: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9a75ed38d1972c87
				L_009c: brfalse.s L_004e
				L_009e: ldloc.0 
				L_009f: ldarg.0 
				L_00a0: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x92abb6992cd92749(System.Object, System.EventArgs)
				L_00a6: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_00ab: callvirt System.Windows.Forms.Form::Void remove_Deactivate(System.EventHandler)
				L_00b0: ldloc.1 
				L_00b1: brfalse.s L_00be
				L_00b3: ldsfld System.IntPtr::IntPtr Zero
				L_00b8: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean ShowCaret(IntPtr)
				L_00bd: pop 
				L_00be: ldarg.0 
				L_00bf: ldc.i4.0 
				L_00c0: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x44d0011ba55ea8a3
				L_00c5: ret 
			*/
			
			
			{
				if (this.x44d0011ba55ea8a3)
				{
					return;
				}
				this.x44d0011ba55ea8a3 = true;
				this.x20ad2840ee62b6a4 = true;
				Form form1 = base.FindForm ();
				form1.Deactivate += new EventHandler (this.x92abb6992cd92749);
				bool b1 = x61467fe65a98f20c.HideCaret (IntPtr.Zero);
				x40255b11ef821fa3.MSG mSG1 = new x40255b11ef821fa3.MSG ();
				this.x9a75ed38d1972c87 = false;
				while (! this.x9a75ed38d1972c87)
				{
					if (x61467fe65a98f20c.WaitMessage ())
					{
						while ((! this.x9a75ed38d1972c87) && x61467fe65a98f20c.PeekMessage (ref mSG1, 0, uint.MinValue, uint.MinValue, uint.MinValue))
						{
							if (x61467fe65a98f20c.GetMessage (ref mSG1, IntPtr.Zero, uint.MinValue, uint.MinValue) && (! this.x58b2784e55b43ddd (ref mSG1)))
							{
								bool b2 = x61467fe65a98f20c.TranslateMessage (ref mSG1);
								IntPtr intPtr1 = x61467fe65a98f20c.DispatchMessage (ref mSG1);
							}
						}
					}
				}
				form1.Deactivate -= new EventHandler (this.x92abb6992cd92749);
				if (b1)
				{
					bool b3 = x61467fe65a98f20c.ShowCaret (IntPtr.Zero);
				}
				this.x44d0011ba55ea8a3 = false;
			}
			
			protected bool x65c1cc54cc8b0e75 (char xba08ce632055a1d9)
			
			/*
				// Code Size: 298 Bytes
				.maxstack 5
				.locals (System.Int32 V_0, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_1, 
         System.Int32 V_2)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_0006: brtrue L_0128
				L_000b: ldc.i4.0 
				L_000c: stloc.0 
				L_000d: br L_0117
				L_0012: ldarg.0 
				L_0013: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_0018: ldloc.0 
				L_0019: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_001e: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0023: stloc.1 
				L_0024: ldloc.1 
				L_0025: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_002a: brfalse L_0113
				L_002f: ldloc.1 
				L_0030: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0035: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Enabled()
				L_003a: brfalse L_0113
				L_003f: ldloc.1 
				L_0040: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0045: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean get_Visible()
				L_004a: brfalse L_0113
				L_004f: ldarg.1 
				L_0050: ldloc.1 
				L_0051: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Char get_x4f86e73709b68aaf()
				L_0056: bne.un L_0113
				L_005b: ldarg.0 
				L_005c: ldc.i4.1 
				L_005d: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_0062: ldarg.0 
				L_0063: ldc.i4.0 
				L_0064: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xf947c341af20623c
				L_0069: ldarg.0 
				L_006a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_006f: ldloc.0 
				L_0070: beq.s L_0087
				L_0072: ldarg.0 
				L_0073: ldarg.0 
				L_0074: ldarg.0 
				L_0075: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_007a: ldloc.0 
				L_007b: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xa7cbddf1ec7a27e7(Int32, Int32)
				L_0080: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0085: br.s L_0094
				L_0087: ldarg.0 
				L_0088: ldarg.0 
				L_0089: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_008e: ldc.i4.1 
				L_008f: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x2cc390e9409b0f3f(Int32, Boolean)
				L_0094: ldloc.1 
				L_0095: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_009a: brtrue.s L_00af
				L_009c: ldloc.1 
				L_009d: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_00a2: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_00a7: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_00ac: ldc.i4.0 
				L_00ad: blt.s L_00e0
				L_00af: ldloc.1 
				L_00b0: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_00b5: brtrue.s L_00ca
				L_00b7: ldloc.1 
				L_00b8: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_00bd: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_00c2: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_00c7: ldc.i4.0 
				L_00c8: ble.s L_00de
				L_00ca: ldarg.0 
				L_00cb: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_00d0: ldarg.0 
				L_00d1: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::UInt32 xd8f9b747f716862a
				L_00d6: ldc.i4.0 
				L_00d7: ldc.i4.1 
				L_00d8: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_00dd: pop 
				L_00de: ldc.i4.1 
				L_00df: ret 
				L_00e0: ldloc.1 
				L_00e1: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_00e6: ldsfld System.EventArgs::System.EventArgs Empty
				L_00eb: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnClick(System.EventArgs)
				L_00f0: ldarg.0 
				L_00f1: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_00f6: stloc.2 
				L_00f7: ldarg.0 
				L_00f8: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x51ce8d251f940283()
				L_00fd: ldarg.0 
				L_00fe: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xcb97d93f0d5ce4a8()
				L_0103: ldarg.0 
				L_0104: ldloc.2 
				L_0105: ldc.i4.0 
				L_0106: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x2cc390e9409b0f3f(Int32, Boolean)
				L_010b: ldarg.0 
				L_010c: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xa23d095e6e52c5f3()
				L_0111: ldc.i4.0 
				L_0112: ret 
				L_0113: ldloc.0 
				L_0114: ldc.i4.1 
				L_0115: add 
				L_0116: stloc.0 
				L_0117: ldloc.0 
				L_0118: ldarg.0 
				L_0119: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_011e: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_0123: blt L_0012
				L_0128: ldc.i4.0 
				L_0129: ret 
			*/
			
			
			{
				int i1;
				Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				int i2;
				if (this.x9f93ebd2ca5601a2)
				{
					return false;
				}
				i1 = 0;
				
			L_0117:
				
				{
				}
				if (i1 >= this.xfb5697071ce83988.Count)
				{
					return false;
				}
				else
				{
					x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[i1] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f);
					if ((((x2cc390e9409b0f3f1.x5f4b657f68f87baa == null) || (! x2cc390e9409b0f3f1.x5f4b657f68f87baa.Enabled)) || (! x2cc390e9409b0f3f1.x5f4b657f68f87baa.Visible)) || (xba08ce632055a1d9 != x2cc390e9409b0f3f1.x4f86e73709b68aaf))
					{
						i1++;
						goto L_0117;
					}
					else
					{
						this.x9f93ebd2ca5601a2 = true;
						this.xf947c341af20623c = false;
						if (this.xb266b78561d63b52 == i1)
						{
							this.x2cc390e9409b0f3f (this.xb266b78561d63b52, true);
						}
						else
						{
							this.xb266b78561d63b52 = this.xa7cbddf1ec7a27e7 (this.xb266b78561d63b52, i1);
						}
						if ((! x2cc390e9409b0f3f1.xaa08ea3ba2fe9514) && (x2cc390e9409b0f3f1.x5f4b657f68f87baa.MenuCommands.Count < 0))
						{
							x2cc390e9409b0f3f1.x5f4b657f68f87baa.OnClick (EventArgs.Empty);
							i2 = this.xb266b78561d63b52;
							this.x51ce8d251f940283 ();
							this.xcb97d93f0d5ce4a8 ();
							this.x2cc390e9409b0f3f (i2, false);
							this.xa23d095e6e52c5f3 ();
							return false;
							
							/*
								Unreachable Code
								goto L_0117;
							*/
						}
						else
						{
							if (x2cc390e9409b0f3f1.xaa08ea3ba2fe9514 || (x2cc390e9409b0f3f1.x5f4b657f68f87baa.MenuCommands.Count > 0))
							{
								bool b1 = x61467fe65a98f20c.PostMessage (base.Handle, this.xd8f9b747f716862a, uint.MinValue, 1);
							}
							return true;
						}
					}
				}
			}
			
			protected void x6b08695ba39cf4ca (int xc0c4c459c6ccbd00, object xbcea506a33cf9111)
			
			/*
				// Code Size: 50 Bytes
				.maxstack 5
				.locals (Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_0)
				L_0000: ldarg.2 
				L_0001: isinst Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0006: stloc.0 
				L_0007: ldloc.0 
				L_0008: ldarg.0 
				L_0009: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x2b1f4f4697e5ae02(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa, x879a106b0501b9dc)
				L_000f: newobj Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa+x5282b9c42ea1abce::Void .ctor(System.Object, IntPtr)
				L_0014: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void add_PropertyChanged(x5282b9c42ea1abce)
				L_0019: ldarg.0 
				L_001a: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xcb97d93f0d5ce4a8()
				L_001f: ldarg.0 
				L_0020: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x51ce8d251f940283()
				L_0025: ldarg.0 
				L_0026: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
				L_002b: ldarg.0 
				L_002c: call System.Windows.Forms.Control::Void Invalidate()
				L_0031: ret 
			*/
			
			
			{
				x5f4b657f68f87baa x5f4b657f68f87baa1 = (xbcea506a33cf9111 as x5f4b657f68f87baa);
				x5f4b657f68f87baa1.PropertyChanged += new x5f4b657f68f87baa.x5282b9c42ea1abce (this.x2b1f4f4697e5ae02);
				this.xcb97d93f0d5ce4a8 ();
				this.x51ce8d251f940283 ();
				this.x39e008704a72ea56 ();
				base.Invalidate ();
			}
			
			protected void x6b3bc391561e756b (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 33 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_0006: brfalse.s L_0020
				L_0008: ldarg.0 
				L_0009: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_000e: ldc.i4.0 
				L_000f: callvirt System.Windows.Forms.Form::Void set_WindowState(System.Windows.Forms.FormWindowState)
				L_0014: ldarg.0 
				L_0015: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
				L_001a: ldarg.0 
				L_001b: call System.Windows.Forms.Control::Void Invalidate()
				L_0020: ret 
			*/
			
			
			{
				if (this.x562fa9742b4f7ed5 != null)
				{
					this.x562fa9742b4f7ed5.WindowState = FormWindowState.Normal;
					this.x39e008704a72ea56 ();
					base.Invalidate ();
				}
			}
			
			protected void x830edbe776f7cc9f ()
			
			/*
				// Code Size: 279 Bytes
				.maxstack 5
				.locals (Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_0, 
         System.Int32 V_1, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_2, 
         System.Int32 V_3)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0006: brtrue L_0116
				L_000b: ldarg.0 
				L_000c: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0011: ldc.i4.m1 
				L_0012: beq L_0116
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_001d: brtrue L_00ce
				L_0022: ldarg.0 
				L_0023: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_0028: ldarg.0 
				L_0029: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_002e: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0033: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0038: stloc.0 
				L_0039: ldloc.0 
				L_003a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_003f: brtrue.s L_0054
				L_0041: ldloc.0 
				L_0042: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0047: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_004c: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_0051: ldc.i4.0 
				L_0052: blt.s L_00a2
				L_0054: ldarg.0 
				L_0055: ldc.i4.1 
				L_0056: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_005b: ldarg.0 
				L_005c: ldc.i4.0 
				L_005d: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xf947c341af20623c
				L_0062: ldarg.0 
				L_0063: ldarg.0 
				L_0064: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0069: ldc.i4.1 
				L_006a: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x2cc390e9409b0f3f(Int32, Boolean)
				L_006f: ldloc.0 
				L_0070: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_0075: brtrue.s L_008d
				L_0077: ldloc.0 
				L_0078: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_007d: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0082: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_0087: ldc.i4.0 
				L_0088: ble L_0116
				L_008d: ldarg.0 
				L_008e: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_0093: ldarg.0 
				L_0094: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::UInt32 xd8f9b747f716862a
				L_0099: ldc.i4.0 
				L_009a: ldc.i4.1 
				L_009b: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_00a0: pop 
				L_00a1: ret 
				L_00a2: ldloc.0 
				L_00a3: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_00a8: ldsfld System.EventArgs::System.EventArgs Empty
				L_00ad: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnClick(System.EventArgs)
				L_00b2: ldarg.0 
				L_00b3: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_00b8: stloc.1 
				L_00b9: ldarg.0 
				L_00ba: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x51ce8d251f940283()
				L_00bf: ldarg.0 
				L_00c0: ldloc.1 
				L_00c1: ldc.i4.0 
				L_00c2: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x2cc390e9409b0f3f(Int32, Boolean)
				L_00c7: ldarg.0 
				L_00c8: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xa23d095e6e52c5f3()
				L_00cd: ret 
				L_00ce: ldarg.0 
				L_00cf: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_00d4: ldarg.0 
				L_00d5: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_00da: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_00df: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_00e4: stloc.2 
				L_00e5: ldloc.2 
				L_00e6: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_00eb: ldsfld System.EventArgs::System.EventArgs Empty
				L_00f0: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void OnClick(System.EventArgs)
				L_00f5: ldarg.0 
				L_00f6: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_00fb: stloc.3 
				L_00fc: ldarg.0 
				L_00fd: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x51ce8d251f940283()
				L_0102: ldarg.0 
				L_0103: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xcb97d93f0d5ce4a8()
				L_0108: ldarg.0 
				L_0109: ldloc.3 
				L_010a: ldc.i4.0 
				L_010b: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x2cc390e9409b0f3f(Int32, Boolean)
				L_0110: ldarg.0 
				L_0111: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xa23d095e6e52c5f3()
				L_0116: ret 
			*/
			
			
			{
				Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				int i1;
				if ((this.x56be4c3c4c4173b7 != null) || (this.xb266b78561d63b52 == -1))
				{
					return;
				}
				if (! this.x9f93ebd2ca5601a2)
				{
					x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[this.xb266b78561d63b52] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f);
					if (x2cc390e9409b0f3f1.xaa08ea3ba2fe9514 || (x2cc390e9409b0f3f1.x5f4b657f68f87baa.MenuCommands.Count >= 0))
					{
						this.x9f93ebd2ca5601a2 = true;
						this.xf947c341af20623c = false;
						this.x2cc390e9409b0f3f (this.xb266b78561d63b52, true);
						if (x2cc390e9409b0f3f1.xaa08ea3ba2fe9514 || (x2cc390e9409b0f3f1.x5f4b657f68f87baa.MenuCommands.Count > 0))
						{
							bool b1 = x61467fe65a98f20c.PostMessage (base.Handle, this.xd8f9b747f716862a, uint.MinValue, 1);
						}
					}
					else
					{
						x2cc390e9409b0f3f1.x5f4b657f68f87baa.OnClick (EventArgs.Empty);
						i1 = this.xb266b78561d63b52;
						this.x51ce8d251f940283 ();
						this.x2cc390e9409b0f3f (i1, false);
						this.xa23d095e6e52c5f3 ();
					}
					return;
				}
				Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f x2cc390e9409b0f3f2 = (this.xfb5697071ce83988[this.xb266b78561d63b52] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f);
				x2cc390e9409b0f3f2.x5f4b657f68f87baa.OnClick (EventArgs.Empty);
				int i2 = this.xb266b78561d63b52;
				this.x51ce8d251f940283 ();
				this.xcb97d93f0d5ce4a8 ();
				this.x2cc390e9409b0f3f (i2, false);
				this.xa23d095e6e52c5f3 ();
			}
			
			private bool x8b3f8f5d533e5ee1 ()
			
			/*
				// Code Size: 17 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: callvirt System.Windows.Forms.Control::System.Drawing.Color get_BackColor()
				L_0006: call System.Drawing.SystemColors::System.Drawing.Color get_Control()
				L_000b: call System.Drawing.Color::Boolean op_Inequality(System.Drawing.Color, System.Drawing.Color)
				L_0010: ret 
			*/
			
			
			{
				return (this.BackColor != SystemColors.Control);
			}
			
			protected void x92abb6992cd92749 (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xa23d095e6e52c5f3()
				L_0006: ret 
			*/
			
			
			{
				this.xa23d095e6e52c5f3 ();
			}
			
			protected void x92bcd6bad6f29e72 (ref Message x6088325dec1baa2a)
			
			/*
				// Code Size: 14 Bytes
				.maxstack 9
				L_0000: ldarg.1 
				L_0001: ldc.i4.4 
				L_0002: conv.i8 
				L_0003: call System.IntPtr::IntPtr op_Explicit(Int64)
				L_0008: call System.Windows.Forms.Message::Void set_Result(IntPtr)
				L_000d: ret 
			*/
			
			
			{
				x6088325dec1baa2a.Result = ((IntPtr) ((long) 4));
			}
			
			protected void x9954cbb39675570d ()
			
			/*
				// Code Size: 383 Bytes
				.maxstack 5
				.locals (System.Windows.Forms.Control[] V_0)
				L_0000: ldarg.0 
				L_0001: ldsfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.ImageList xfeae2ed797ae6fbc
				L_0006: ldc.i4.0 
				L_0007: newobj Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Void .ctor(System.Windows.Forms.ImageList, Int32)
				L_000c: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_0011: ldarg.0 
				L_0012: ldsfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.ImageList xfeae2ed797ae6fbc
				L_0017: ldc.i4.1 
				L_0018: newobj Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Void .ctor(System.Windows.Forms.ImageList, Int32)
				L_001d: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_0022: ldarg.0 
				L_0023: ldsfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.ImageList xfeae2ed797ae6fbc
				L_0028: ldc.i4.2 
				L_0029: newobj Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60::Void .ctor(System.Windows.Forms.ImageList, Int32)
				L_002e: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_0033: ldarg.0 
				L_0034: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_0039: ldarg.0 
				L_003a: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_003f: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0044: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0049: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARSTARTCOLOR
				L_004e: callvirt System.Windows.Forms.Control::Void set_BackColor(System.Drawing.Color)
				L_0053: ldarg.0 
				L_0054: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_0059: ldarg.0 
				L_005a: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_005f: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0064: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0069: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARSTARTCOLOR
				L_006e: callvirt System.Windows.Forms.Control::Void set_BackColor(System.Drawing.Color)
				L_0073: ldarg.0 
				L_0074: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_0079: ldarg.0 
				L_007a: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_007f: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0084: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_0089: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_MENUBARSTARTCOLOR
				L_008e: callvirt System.Windows.Forms.Control::Void set_BackColor(System.Drawing.Color)
				L_0093: ldarg.0 
				L_0094: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_0099: ldc.i4.s 16
				L_009b: ldc.i4.s 16
				L_009d: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_00a2: callvirt System.Windows.Forms.Control::Void set_Size(System.Drawing.Size)
				L_00a7: ldarg.0 
				L_00a8: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_00ad: ldc.i4.s 16
				L_00af: ldc.i4.s 16
				L_00b1: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_00b6: callvirt System.Windows.Forms.Control::Void set_Size(System.Drawing.Size)
				L_00bb: ldarg.0 
				L_00bc: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_00c1: ldc.i4.s 16
				L_00c3: ldc.i4.s 16
				L_00c5: newobj System.Drawing.Size::Void .ctor(Int32, Int32)
				L_00ca: callvirt System.Windows.Forms.Control::Void set_Size(System.Drawing.Size)
				L_00cf: ldarg.0 
				L_00d0: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_00d5: ldc.i4.s -16
				L_00d7: ldc.i4.s -16
				L_00d9: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_00de: callvirt System.Windows.Forms.Control::Void set_Location(System.Drawing.Point)
				L_00e3: ldarg.0 
				L_00e4: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_00e9: ldc.i4.s -16
				L_00eb: ldc.i4.s -16
				L_00ed: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_00f2: callvirt System.Windows.Forms.Control::Void set_Location(System.Drawing.Point)
				L_00f7: ldarg.0 
				L_00f8: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_00fd: ldc.i4.s -16
				L_00ff: ldc.i4.s -16
				L_0101: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0106: callvirt System.Windows.Forms.Control::Void set_Location(System.Drawing.Point)
				L_010b: ldarg.0 
				L_010c: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_0111: ldarg.0 
				L_0112: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x199464e739d66b0b(System.Object, System.EventArgs)
				L_0118: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_011d: callvirt System.Windows.Forms.Control::Void add_Click(System.EventHandler)
				L_0122: ldarg.0 
				L_0123: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_0128: ldarg.0 
				L_0129: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x6b3bc391561e756b(System.Object, System.EventArgs)
				L_012f: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0134: callvirt System.Windows.Forms.Control::Void add_Click(System.EventHandler)
				L_0139: ldarg.0 
				L_013a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_013f: ldarg.0 
				L_0140: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x0b912a2b95b630ba(System.Object, System.EventArgs)
				L_0146: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_014b: callvirt System.Windows.Forms.Control::Void add_Click(System.EventHandler)
				L_0150: ldarg.0 
				L_0151: call System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0156: ldc.i4.3 
				L_0157: newarr System.Windows.Forms.Control
				L_015c: stloc.0 
				L_015d: ldloc.0 
				L_015e: ldc.i4.0 
				L_015f: ldarg.0 
				L_0160: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_0165: stelem.ref 
				L_0166: ldloc.0 
				L_0167: ldc.i4.1 
				L_0168: ldarg.0 
				L_0169: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_016e: stelem.ref 
				L_016f: ldloc.0 
				L_0170: ldc.i4.2 
				L_0171: ldarg.0 
				L_0172: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_0177: stelem.ref 
				L_0178: ldloc.0 
				L_0179: callvirt System.Windows.Forms.Control+ControlCollection::Void AddRange(System.Windows.Forms.Control[])
				L_017e: ret 
			*/
			
			
			{
				this.x2c6deb5021c80299 = new x5d3356d9dffccb60 (x3c41176af7e54b01.xfeae2ed797ae6fbc, 0);
				this.x0abc55e6ce1d8aed = new x5d3356d9dffccb60 (x3c41176af7e54b01.xfeae2ed797ae6fbc, 1);
				this.x26e80f23e22a05ae = new x5d3356d9dffccb60 (x3c41176af7e54b01.xfeae2ed797ae6fbc, 2);
				this.x2c6deb5021c80299.BackColor = ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARSTARTCOLOR;
				this.x0abc55e6ce1d8aed.BackColor = ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARSTARTCOLOR;
				this.x26e80f23e22a05ae.BackColor = ((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_MENUBARSTARTCOLOR;
				this.x2c6deb5021c80299.Size = new System.Drawing.Size (16, 16);
				this.x0abc55e6ce1d8aed.Size = new System.Drawing.Size (16, 16);
				this.x26e80f23e22a05ae.Size = new System.Drawing.Size (16, 16);
				this.x2c6deb5021c80299.Location = new Point (-16, -16);
				this.x0abc55e6ce1d8aed.Location = new Point (-16, -16);
				this.x26e80f23e22a05ae.Location = new Point (-16, -16);
				this.x2c6deb5021c80299.Click += new EventHandler (this.x199464e739d66b0b);
				this.x0abc55e6ce1d8aed.Click += new EventHandler (this.x6b3bc391561e756b);
				this.x26e80f23e22a05ae.Click += new EventHandler (this.x0b912a2b95b630ba);
				Control[] controlArray1 = new Control[] { ((Control) this.x2c6deb5021c80299), ((Control) this.x0abc55e6ce1d8aed), ((Control) this.x26e80f23e22a05ae) };
				base.Controls.AddRange (controlArray1);
			}
			
			protected void xa23d095e6e52c5f3 ()
			
			/*
				// Code Size: 44 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x44d0011ba55ea8a3
				L_0006: brfalse.s L_000f
				L_0008: ldarg.0 
				L_0009: ldc.i4.1 
				L_000a: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9a75ed38d1972c87
				L_000f: ldarg.0 
				L_0010: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0015: ldc.i4.m1 
				L_0016: beq.s L_002b
				L_0018: ldarg.0 
				L_0019: ldarg.0 
				L_001a: ldarg.0 
				L_001b: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0020: ldc.i4.m1 
				L_0021: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xa7cbddf1ec7a27e7(Int32, Int32)
				L_0026: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_002b: ret 
			*/
			
			
			{
				if (this.x44d0011ba55ea8a3)
				{
					this.x9a75ed38d1972c87 = true;
				}
				if (this.xb266b78561d63b52 != -1)
				{
					this.xb266b78561d63b52 = this.xa7cbddf1ec7a27e7 (this.xb266b78561d63b52, -1);
				}
			}
			
			private void xa76c42f3062c6f11 (x5f4b657f68f87baa x61b060a94340c4fc)
			
			/*
				// Code Size: 126 Bytes
				.maxstack 4
				.locals (System.Int32 V_0, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_1, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa[] V_2, 
         System.Int32 V_3)
				L_0000: ldarg.1 
				L_0001: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0006: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_000b: ldc.i4.1 
				L_000c: sub 
				L_000d: stloc.0 
				L_000e: br.s L_0033
				L_0010: ldarg.1 
				L_0011: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0016: ldloc.0 
				L_0017: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_xe6d4b1b411ed94b5(Int32)
				L_001c: ldfld Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Boolean xb2504b89d66feca9
				L_0021: brfalse.s L_002f
				L_0023: ldarg.1 
				L_0024: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0029: ldloc.0 
				L_002a: callvirt System.Collections.CollectionBase::Void RemoveAt(Int32)
				L_002f: ldloc.0 
				L_0030: ldc.i4.1 
				L_0031: sub 
				L_0032: stloc.0 
				L_0033: ldloc.0 
				L_0034: ldc.i4.0 
				L_0035: bge.s L_0010
				L_0037: ldarg.1 
				L_0038: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_003d: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_0042: ldc.i4.0 
				L_0043: ble.s L_0057
				L_0045: ldarg.1 
				L_0046: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_004b: ldarg.0 
				L_004c: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa x54f4e17b11b07b8c
				L_0051: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd6b6ed77479ef68c(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0056: pop 
				L_0057: ldarg.0 
				L_0058: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa[] x4dedac25f8166fb5
				L_005d: stloc.2 
				L_005e: ldc.i4.0 
				L_005f: stloc.3 
				L_0060: br.s L_0077
				L_0062: ldloc.2 
				L_0063: ldloc.3 
				L_0064: ldelem.ref 
				L_0065: stloc.1 
				L_0066: ldarg.1 
				L_0067: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_006c: ldloc.1 
				L_006d: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd6b6ed77479ef68c(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0072: pop 
				L_0073: ldloc.3 
				L_0074: ldc.i4.1 
				L_0075: add 
				L_0076: stloc.3 
				L_0077: ldloc.3 
				L_0078: ldloc.2 
				L_0079: ldlen 
				L_007a: conv.i4 
				L_007b: blt.s L_0062
				L_007d: ret 
			*/
			
			
			{
				int i1;
				for (i1 = (x61b060a94340c4fc.MenuCommands.Count - 1); (i1 >= 0); i1--)
				{
					if (x61b060a94340c4fc.MenuCommands.get_xe6d4b1b411ed94b5 (i1).xb2504b89d66feca9)
					{
						x61b060a94340c4fc.MenuCommands.RemoveAt (i1);
					}
				}
				if (x61b060a94340c4fc.MenuCommands.Count > 0)
				{
					x5f4b657f68f87baa x5f4b657f68f87baa2 = x61b060a94340c4fc.MenuCommands.xd6b6ed77479ef68c (this.x54f4e17b11b07b8c);
				}
				foreach (x5f4b657f68f87baa x5f4b657f68f87baa1 in this.x4dedac25f8166fb5)
				{
					x5f4b657f68f87baa x5f4b657f68f87baa3 = x61b060a94340c4fc.MenuCommands.xd6b6ed77479ef68c (x5f4b657f68f87baa1);
				}
			}
			
			protected int xa7cbddf1ec7a27e7 (int x5360a38cdebd0e93, int x169940ac3300e3e7)
			
			/*
				// Code Size: 188 Bytes
				.maxstack 6
				.locals (System.Drawing.Graphics V_0, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_1, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_2)
				.try L_0007 to L_00ab finally L_00ab to L_00b5
				L_0000: ldarg.0 
				L_0001: call System.Windows.Forms.Control::System.Drawing.Graphics CreateGraphics()
				L_0006: stloc.0 
				L_0007: ldarg.1 
				L_0008: ldc.i4.m1 
				L_0009: beq.s L_004a
				L_000b: ldarg.0 
				L_000c: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_0011: ldarg.1 
				L_0012: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0017: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_001c: stloc.1 
				L_001d: ldarg.0 
				L_001e: ldloc.0 
				L_001f: ldarg.0 
				L_0020: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_0025: ldarg.1 
				L_0026: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_002b: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0030: ldc.i4.0 
				L_0031: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xb5a5bdae3ba8936b(System.Drawing.Graphics, Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f, Boolean)
				L_0036: ldloc.1 
				L_0037: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_003c: brfalse.s L_004a
				L_003e: ldarg.0 
				L_003f: ldloc.1 
				L_0040: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0045: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void OnDeselected(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_004a: ldarg.0 
				L_004b: ldarg.2 
				L_004c: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0051: ldarg.0 
				L_0052: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0057: ldc.i4.m1 
				L_0058: beq.s L_00a3
				L_005a: ldarg.0 
				L_005b: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_0060: ldarg.0 
				L_0061: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0066: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_006b: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0070: stloc.2 
				L_0071: ldarg.0 
				L_0072: ldloc.0 
				L_0073: ldarg.0 
				L_0074: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_0079: ldarg.0 
				L_007a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_007f: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_0084: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0089: ldc.i4.1 
				L_008a: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xb5a5bdae3ba8936b(System.Drawing.Graphics, Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f, Boolean)
				L_008f: ldloc.2 
				L_0090: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0095: brfalse.s L_00a3
				L_0097: ldarg.0 
				L_0098: ldloc.2 
				L_0099: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_009e: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void OnSelected(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_00a3: ldarg.0 
				L_00a4: call System.Windows.Forms.Control::Void Invalidate()
				L_00a9: leave.s L_00b5
				L_00ab: ldloc.0 
				L_00ac: brfalse.s L_00b4
				L_00ae: ldloc.0 
				L_00af: callvirt System.IDisposable::Void Dispose()
				L_00b4: endfinally 
				L_00b5: ldarg.0 
				L_00b6: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_00bb: ret 
			*/
			
			
			{
				Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f x2cc390e9409b0f3f2;
				using (Graphics graphics1 = base.CreateGraphics ())
				{
					if (x5360a38cdebd0e93 != -1)
					{
						x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[x5360a38cdebd0e93] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f);
						this.xb5a5bdae3ba8936b (graphics1, (this.xfb5697071ce83988[x5360a38cdebd0e93] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f), false);
						if (x2cc390e9409b0f3f1.x5f4b657f68f87baa != null)
						{
							this.OnDeselected (x2cc390e9409b0f3f1.x5f4b657f68f87baa);
						}
					}
					this.xb266b78561d63b52 = x169940ac3300e3e7;
					if (this.xb266b78561d63b52 != -1)
					{
						x2cc390e9409b0f3f2 = (this.xfb5697071ce83988[this.xb266b78561d63b52] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f);
						this.xb5a5bdae3ba8936b (graphics1, (this.xfb5697071ce83988[this.xb266b78561d63b52] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f), true);
						if (x2cc390e9409b0f3f2.x5f4b657f68f87baa != null)
						{
							this.OnSelected (x2cc390e9409b0f3f2.x5f4b657f68f87baa);
						}
					}
					base.Invalidate ();
				}
				return this.xb266b78561d63b52;
			}
			
			protected void xa9f9739090793818 (ref Message x6088325dec1baa2a)
			
			/*
				// Code Size: 72 Bytes
				.maxstack 6
				.locals (Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_0)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0006: ldc.i4.m1 
				L_0007: beq.s L_0047
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_000f: ldarg.0 
				L_0010: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0015: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_001a: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_001f: stloc.0 
				L_0020: ldarg.0 
				L_0021: ldloc.0 
				L_0022: ldarg.1 
				L_0023: call System.Windows.Forms.Message::IntPtr get_LParam()
				L_0028: ldsfld System.IntPtr::IntPtr Zero
				L_002d: call System.IntPtr::Boolean op_Inequality(IntPtr, IntPtr)
				L_0032: ldarg.1 
				L_0033: call System.Windows.Forms.Message::IntPtr get_WParam()
				L_0038: ldsfld System.IntPtr::IntPtr Zero
				L_003d: call System.IntPtr::Boolean op_Inequality(IntPtr, IntPtr)
				L_0042: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x0760506d6abf77a2(Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f, Boolean, Boolean)
				L_0047: ret 
			*/
			
			
			{
				if (this.xb266b78561d63b52 == -1)
				{
					return;
				}
				Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[this.xb266b78561d63b52] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f);
				this.x0760506d6abf77a2 (x2cc390e9409b0f3f1, (x6088325dec1baa2a.LParam != IntPtr.Zero), (x6088325dec1baa2a.WParam != IntPtr.Zero));
			}
			
			internal void xb5a5bdae3ba8936b (Graphics x4b101060f4767186, Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f xd2a8bb4342ab4ef6, bool x4b9cb2187c13edda)
			
			/*
				// Code Size: 2042 Bytes
				.maxstack 8
				.locals (System.Drawing.Brush V_0, 
         System.Drawing.Rectangle V_1, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_2, 
         System.Drawing.Rectangle V_3, 
         System.Drawing.Rectangle V_4, 
         System.Drawing.Rectangle V_5, 
         System.Drawing.Color V_6, 
         System.Drawing.Color V_7, 
         System.Drawing.Color V_8, 
         System.Int32 V_9, 
         System.Int32 V_10, 
         System.Drawing.Pen V_11, 
         System.Int32 V_12, 
         System.Int32 V_13, 
         System.Int32 V_14, 
         System.Int32 V_15, 
         System.Int32 V_16, 
         System.Drawing.Brush V_17, 
         System.Drawing.Brush V_18, 
         System.Drawing.Brush V_19, 
         System.Drawing.Brush V_20, 
         System.Drawing.Pen V_21, 
         System.Drawing.Pen V_22, 
         System.Int32 V_23, 
         System.Drawing.Brush V_24, 
         System.Drawing.Drawing2D.LinearGradientBrush V_25, 
         System.Drawing.Pen V_26, 
         System.Int32 V_27, 
         System.Drawing.Brush V_28, 
         System.Drawing.Drawing2D.LinearGradientBrush V_29, 
         System.Drawing.Pen V_30, 
         System.Int32 V_31, 
         System.Int32 V_32, 
         System.Drawing.StringFormat V_33, 
         System.Drawing.Rectangle V_34, 
         System.Drawing.SolidBrush V_35)
				.try L_01ab to L_01b7 finally L_01b7 to L_01c3
				.try L_0364 to L_0370 finally L_0370 to L_037c
				.try L_03d6 to L_03fc finally L_03fc to L_0408
				.try L_043d to L_0458 finally L_0458 to L_0464
				.try L_04fd to L_0523 finally L_0523 to L_052f
				.try L_056b to L_0588 finally L_0588 to L_0594
				.try L_0628 to L_0634 finally L_0634 to L_0640
				.try L_07ce to L_07ed finally L_07ed to L_07f9
				L_0000: ldarg.2 
				L_0001: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xee63d905da8ff550()
				L_0006: stloc.1 
				L_0007: ldarg.2 
				L_0008: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_000d: stloc.2 
				L_000e: ldloc.1 
				L_000f: stloc.3 
				L_0010: ldloca.s V_3
				L_0012: dup 
				L_0013: call System.Drawing.Rectangle::Int32 get_Width()
				L_0018: ldc.i4.4 
				L_0019: add 
				L_001a: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_001f: ldloca.s V_3
				L_0021: dup 
				L_0022: call System.Drawing.Rectangle::Int32 get_Height()
				L_0027: ldc.i4.4 
				L_0028: add 
				L_0029: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_002e: ldarg.2 
				L_002f: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x43604484a3deae4f()
				L_0034: brtrue L_07f9
				L_0039: ldarg.2 
				L_003a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_003f: brfalse.s L_006e
				L_0041: ldloca.s V_4
				L_0043: ldloca.s V_1
				L_0045: call System.Drawing.Rectangle::Int32 get_Left()
				L_004a: ldc.i4.3 
				L_004b: add 
				L_004c: ldloca.s V_1
				L_004e: call System.Drawing.Rectangle::Int32 get_Top()
				L_0053: ldc.i4.1 
				L_0054: add 
				L_0055: ldloca.s V_1
				L_0057: call System.Drawing.Rectangle::Int32 get_Width()
				L_005c: ldc.i4.6 
				L_005d: sub 
				L_005e: ldloca.s V_1
				L_0060: call System.Drawing.Rectangle::Int32 get_Height()
				L_0065: ldc.i4.2 
				L_0066: sub 
				L_0067: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_006c: br.s L_0099
				L_006e: ldloca.s V_4
				L_0070: ldloca.s V_1
				L_0072: call System.Drawing.Rectangle::Int32 get_Left()
				L_0077: ldc.i4.3 
				L_0078: add 
				L_0079: ldloca.s V_1
				L_007b: call System.Drawing.Rectangle::Int32 get_Top()
				L_0080: ldc.i4.3 
				L_0081: add 
				L_0082: ldloca.s V_1
				L_0084: call System.Drawing.Rectangle::Int32 get_Width()
				L_0089: ldc.i4.6 
				L_008a: sub 
				L_008b: ldloca.s V_1
				L_008d: call System.Drawing.Rectangle::Int32 get_Height()
				L_0092: ldc.i4.6 
				L_0093: sub 
				L_0094: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0099: ldarg.2 
				L_009a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x9f2c0dc847992f03()
				L_009f: brfalse L_0640
				L_00a4: ldarg.3 
				L_00a5: brfalse L_0640
				L_00aa: ldarg.0 
				L_00ab: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_00b0: ldc.i4.1 
				L_00b1: bne.un.s L_00e0
				L_00b3: ldloca.s V_5
				L_00b5: ldloca.s V_4
				L_00b7: call System.Drawing.Rectangle::Int32 get_Left()
				L_00bc: ldc.i4.2 
				L_00bd: sub 
				L_00be: ldloca.s V_4
				L_00c0: call System.Drawing.Rectangle::Int32 get_Top()
				L_00c5: ldc.i4.1 
				L_00c6: sub 
				L_00c7: ldloca.s V_4
				L_00c9: call System.Drawing.Rectangle::Int32 get_Width()
				L_00ce: ldc.i4.4 
				L_00cf: add 
				L_00d0: ldloca.s V_4
				L_00d2: call System.Drawing.Rectangle::Int32 get_Height()
				L_00d7: ldc.i4.1 
				L_00d8: add 
				L_00d9: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00de: br.s L_0117
				L_00e0: ldarg.2 
				L_00e1: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_00e6: brtrue.s L_0113
				L_00e8: ldloca.s V_5
				L_00ea: ldloca.s V_4
				L_00ec: call System.Drawing.Rectangle::Int32 get_Left()
				L_00f1: ldloca.s V_4
				L_00f3: call System.Drawing.Rectangle::Int32 get_Top()
				L_00f8: ldc.i4.2 
				L_00f9: sub 
				L_00fa: ldloca.s V_4
				L_00fc: call System.Drawing.Rectangle::Int32 get_Width()
				L_0101: ldc.i4.2 
				L_0102: sub 
				L_0103: ldloca.s V_4
				L_0105: call System.Drawing.Rectangle::Int32 get_Height()
				L_010a: ldc.i4.4 
				L_010b: add 
				L_010c: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0111: br.s L_0117
				L_0113: ldloc.s V_4
				L_0115: stloc.s V_5
				L_0117: ldarg.0 
				L_0118: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_011d: brfalse L_05ef
				L_0122: ldarg.0 
				L_0123: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0128: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_012d: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0132: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOPSELECTEDMENUCOLOR()
				L_0137: stloc.0 
				L_0138: ldarg.1 
				L_0139: ldloc.0 
				L_013a: ldloc.s V_5
				L_013c: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0141: ldc.i4.s 64
				L_0143: ldc.i4.0 
				L_0144: ldc.i4.0 
				L_0145: ldc.i4.0 
				L_0146: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_014b: stloc.s V_6
				L_014d: ldc.i4.s 48
				L_014f: ldc.i4.0 
				L_0150: ldc.i4.0 
				L_0151: ldc.i4.0 
				L_0152: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_0157: stloc.s V_7
				L_0159: ldc.i4.0 
				L_015a: ldc.i4.0 
				L_015b: ldc.i4.0 
				L_015c: ldc.i4.0 
				L_015d: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32, Int32)
				L_0162: stloc.s V_8
				L_0164: ldloca.s V_5
				L_0166: call System.Drawing.Rectangle::Int32 get_Right()
				L_016b: ldc.i4.1 
				L_016c: add 
				L_016d: stloc.s V_9
				L_016f: ldloca.s V_5
				L_0171: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0176: stloc.s V_10
				L_0178: ldarg.0 
				L_0179: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xf947c341af20623c
				L_017e: brfalse L_0348
				L_0183: ldarg.0 
				L_0184: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_0189: ldc.i4.1 
				L_018a: bne.un L_0348
				L_018f: ldarg.0 
				L_0190: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0195: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_019a: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_019f: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TOPSELECTEDMENUBORDERCOLOR
				L_01a4: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_01a9: stloc.s V_11
				L_01ab: ldarg.1 
				L_01ac: ldloc.s V_11
				L_01ae: ldloc.s V_5
				L_01b0: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_01b5: leave.s L_01c3
				L_01b7: ldloc.s V_11
				L_01b9: brfalse.s L_01c2
				L_01bb: ldloc.s V_11
				L_01bd: callvirt System.IDisposable::Void Dispose()
				L_01c2: endfinally 
				L_01c3: ldarg.2 
				L_01c4: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x649e2ad374251b5f()
				L_01c9: brfalse L_0640
				L_01ce: ldloca.s V_5
				L_01d0: call System.Drawing.Rectangle::Int32 get_Top()
				L_01d5: stloc.s V_12
				L_01d7: ldloca.s V_5
				L_01d9: call System.Drawing.Rectangle::Int32 get_Left()
				L_01de: pop 
				L_01df: ldloca.s V_5
				L_01e1: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_01e6: ldc.i4.1 
				L_01e7: add 
				L_01e8: stloc.s V_13
				L_01ea: ldloca.s V_5
				L_01ec: call System.Drawing.Rectangle::Int32 get_Left()
				L_01f1: ldc.i4.4 
				L_01f2: add 
				L_01f3: stloc.s V_14
				L_01f5: ldloca.s V_5
				L_01f7: call System.Drawing.Rectangle::Int32 get_Width()
				L_01fc: ldc.i4.1 
				L_01fd: add 
				L_01fe: stloc.s V_15
				L_0200: ldc.i4.4 
				L_0201: stloc.s V_16
				L_0203: ldsfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9c8c46cd7553cd2b
				L_0208: brfalse L_02ac
				L_020d: ldloc.s V_9
				L_020f: ldc.i4 9999
				L_0214: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0219: ldloc.s V_9
				L_021b: ldc.i4.4 
				L_021c: add 
				L_021d: ldc.i4 9999
				L_0222: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0227: ldloc.s V_7
				L_0229: ldloc.s V_8
				L_022b: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Point, System.Drawing.Point, System.Drawing.Color, System.Drawing.Color)
				L_0230: stloc.s V_17
				L_0232: ldloc.s V_14
				L_0234: ldc.i4.4 
				L_0235: add 
				L_0236: ldloc.s V_13
				L_0238: ldc.i4.4 
				L_0239: sub 
				L_023a: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_023f: ldloc.s V_14
				L_0241: ldloc.s V_13
				L_0243: ldloc.s V_16
				L_0245: add 
				L_0246: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_024b: ldloc.s V_6
				L_024d: ldloc.s V_8
				L_024f: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Point, System.Drawing.Point, System.Drawing.Color, System.Drawing.Color)
				L_0254: stloc.s V_18
				L_0256: ldloc.s V_14
				L_0258: ldloc.s V_15
				L_025a: add 
				L_025b: ldc.i4.4 
				L_025c: sub 
				L_025d: ldc.i4.2 
				L_025e: sub 
				L_025f: ldloc.s V_13
				L_0261: ldc.i4.4 
				L_0262: sub 
				L_0263: ldc.i4.2 
				L_0264: sub 
				L_0265: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_026a: ldloc.s V_14
				L_026c: ldloc.s V_15
				L_026e: add 
				L_026f: ldloc.s V_13
				L_0271: ldloc.s V_16
				L_0273: add 
				L_0274: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0279: ldloc.s V_6
				L_027b: ldloc.s V_8
				L_027d: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Point, System.Drawing.Point, System.Drawing.Color, System.Drawing.Color)
				L_0282: stloc.s V_20
				L_0284: ldc.i4 9999
				L_0289: ldloc.s V_13
				L_028b: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0290: ldc.i4 9999
				L_0295: ldloc.s V_13
				L_0297: ldloc.s V_16
				L_0299: add 
				L_029a: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_029f: ldloc.s V_7
				L_02a1: ldloc.s V_8
				L_02a3: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Point, System.Drawing.Point, System.Drawing.Color, System.Drawing.Color)
				L_02a8: stloc.s V_19
				L_02aa: br.s L_02c4
				L_02ac: call System.Drawing.SystemColors::System.Drawing.Color get_ControlDark()
				L_02b1: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_02b6: stloc.s V_17
				L_02b8: ldloc.s V_17
				L_02ba: stloc.s V_18
				L_02bc: ldloc.s V_17
				L_02be: stloc.s V_19
				L_02c0: ldloc.s V_17
				L_02c2: stloc.s V_20
				L_02c4: ldarg.1 
				L_02c5: ldloc.s V_17
				L_02c7: ldloc.s V_9
				L_02c9: ldloc.s V_12
				L_02cb: ldc.i4.4 
				L_02cc: ldloc.s V_10
				L_02ce: ldloc.s V_12
				L_02d0: sub 
				L_02d1: ldc.i4.1 
				L_02d2: add 
				L_02d3: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_02d8: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_02dd: ldarg.1 
				L_02de: ldloc.s V_18
				L_02e0: ldloc.s V_14
				L_02e2: ldloc.s V_13
				L_02e4: ldc.i4.4 
				L_02e5: ldloc.s V_16
				L_02e7: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_02ec: ldarg.1 
				L_02ed: ldloc.s V_20
				L_02ef: ldloc.s V_14
				L_02f1: ldloc.s V_15
				L_02f3: add 
				L_02f4: ldc.i4.4 
				L_02f5: sub 
				L_02f6: ldloc.s V_13
				L_02f8: ldc.i4.4 
				L_02f9: ldloc.s V_16
				L_02fb: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_0300: ldarg.1 
				L_0301: ldloc.s V_19
				L_0303: ldloc.s V_14
				L_0305: ldc.i4.4 
				L_0306: add 
				L_0307: ldloc.s V_13
				L_0309: ldloc.s V_15
				L_030b: ldc.i4.8 
				L_030c: sub 
				L_030d: ldloc.s V_16
				L_030f: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, Int32, Int32, Int32, Int32)
				L_0314: ldsfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9c8c46cd7553cd2b
				L_0319: brfalse.s L_033c
				L_031b: ldloc.s V_17
				L_031d: callvirt System.Drawing.Brush::Void Dispose()
				L_0322: ldloc.s V_18
				L_0324: callvirt System.Drawing.Brush::Void Dispose()
				L_0329: ldloc.s V_19
				L_032b: callvirt System.Drawing.Brush::Void Dispose()
				L_0330: ldloc.s V_20
				L_0332: callvirt System.Drawing.Brush::Void Dispose()
				L_0337: br L_0640
				L_033c: ldloc.s V_17
				L_033e: callvirt System.Drawing.Brush::Void Dispose()
				L_0343: br L_0640
				L_0348: ldarg.0 
				L_0349: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_034e: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0353: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0358: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOPSELECTEDMENUBORDERCOLOR()
				L_035d: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush)
				L_0362: stloc.s V_21
				L_0364: ldarg.1 
				L_0365: ldloc.s V_21
				L_0367: ldloc.s V_5
				L_0369: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_036e: leave.s L_037c
				L_0370: ldloc.s V_21
				L_0372: brfalse.s L_037b
				L_0374: ldloc.s V_21
				L_0376: callvirt System.IDisposable::Void Dispose()
				L_037b: endfinally 
				L_037c: ldarg.2 
				L_037d: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x649e2ad374251b5f()
				L_0382: brfalse L_0640
				L_0387: ldarg.0 
				L_0388: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_038d: ldc.i4.1 
				L_038e: bne.un L_04ba
				L_0393: ldarg.1 
				L_0394: call System.Drawing.Pens::System.Drawing.Pen get_White()
				L_0399: ldloca.s V_5
				L_039b: call System.Drawing.Rectangle::Int32 get_Left()
				L_03a0: ldloca.s V_5
				L_03a2: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_03a7: ldloca.s V_5
				L_03a9: call System.Drawing.Rectangle::Int32 get_Right()
				L_03ae: ldloca.s V_5
				L_03b0: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_03b5: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_03ba: ldarg.0 
				L_03bb: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_03c0: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_03c5: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_03ca: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOPSELECTEDMENUFONTCOLOR()
				L_03cf: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush)
				L_03d4: stloc.s V_22
				L_03d6: ldarg.1 
				L_03d7: ldloc.s V_22
				L_03d9: ldloca.s V_5
				L_03db: call System.Drawing.Rectangle::Int32 get_Left()
				L_03e0: ldloca.s V_5
				L_03e2: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_03e7: ldloca.s V_5
				L_03e9: call System.Drawing.Rectangle::Int32 get_Right()
				L_03ee: ldloca.s V_5
				L_03f0: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_03f5: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_03fa: leave.s L_0408
				L_03fc: ldloc.s V_22
				L_03fe: brfalse.s L_0407
				L_0400: ldloc.s V_22
				L_0402: callvirt System.IDisposable::Void Dispose()
				L_0407: endfinally 
				L_0408: ldloca.s V_5
				L_040a: call System.Drawing.Rectangle::Int32 get_Top()
				L_040f: ldc.i4.4 
				L_0410: add 
				L_0411: stloc.s V_23
				L_0413: ldsfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9c8c46cd7553cd2b
				L_0418: brfalse.s L_048b
				L_041a: ldloc.s V_9
				L_041c: ldc.i4.4 
				L_041d: sub 
				L_041e: ldloc.s V_23
				L_0420: ldc.i4.4 
				L_0421: add 
				L_0422: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0427: ldloc.s V_9
				L_0429: ldc.i4.4 
				L_042a: add 
				L_042b: ldloc.s V_23
				L_042d: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0432: ldloc.s V_6
				L_0434: ldloc.s V_8
				L_0436: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Point, System.Drawing.Point, System.Drawing.Color, System.Drawing.Color)
				L_043b: stloc.s V_25
				L_043d: ldarg.1 
				L_043e: ldloc.s V_25
				L_0440: ldloc.s V_9
				L_0442: ldloc.s V_23
				L_0444: ldc.i4.4 
				L_0445: ldc.i4.4 
				L_0446: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_044b: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0450: ldloc.s V_23
				L_0452: ldc.i4.4 
				L_0453: add 
				L_0454: stloc.s V_23
				L_0456: leave.s L_0464
				L_0458: ldloc.s V_25
				L_045a: brfalse.s L_0463
				L_045c: ldloc.s V_25
				L_045e: callvirt System.IDisposable::Void Dispose()
				L_0463: endfinally 
				L_0464: ldloc.s V_9
				L_0466: ldc.i4 9999
				L_046b: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0470: ldloc.s V_9
				L_0472: ldc.i4.4 
				L_0473: add 
				L_0474: ldc.i4 9999
				L_0479: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_047e: ldloc.s V_7
				L_0480: ldloc.s V_8
				L_0482: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Point, System.Drawing.Point, System.Drawing.Color, System.Drawing.Color)
				L_0487: stloc.s V_24
				L_0489: br.s L_0497
				L_048b: call System.Drawing.SystemColors::System.Drawing.Color get_ControlDark()
				L_0490: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_0495: stloc.s V_24
				L_0497: ldarg.1 
				L_0498: ldloc.s V_24
				L_049a: ldloc.s V_9
				L_049c: ldloc.s V_23
				L_049e: ldc.i4.4 
				L_049f: ldloc.s V_10
				L_04a1: ldloc.s V_23
				L_04a3: sub 
				L_04a4: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_04a9: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_04ae: ldloc.s V_24
				L_04b0: callvirt System.Drawing.Brush::Void Dispose()
				L_04b5: br L_0640
				L_04ba: ldarg.1 
				L_04bb: call System.Drawing.Pens::System.Drawing.Pen get_White()
				L_04c0: ldloca.s V_5
				L_04c2: call System.Drawing.Rectangle::Int32 get_Right()
				L_04c7: ldloca.s V_5
				L_04c9: call System.Drawing.Rectangle::Int32 get_Top()
				L_04ce: ldloca.s V_5
				L_04d0: call System.Drawing.Rectangle::Int32 get_Right()
				L_04d5: ldloca.s V_5
				L_04d7: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_04dc: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_04e1: ldarg.0 
				L_04e2: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_04e7: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_04ec: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_04f1: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOPSELECTEDMENUFONTCOLOR()
				L_04f6: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Brush)
				L_04fb: stloc.s V_26
				L_04fd: ldarg.1 
				L_04fe: ldloc.s V_26
				L_0500: ldloca.s V_5
				L_0502: call System.Drawing.Rectangle::Int32 get_Right()
				L_0507: ldloca.s V_5
				L_0509: call System.Drawing.Rectangle::Int32 get_Top()
				L_050e: ldloca.s V_5
				L_0510: call System.Drawing.Rectangle::Int32 get_Right()
				L_0515: ldloca.s V_5
				L_0517: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_051c: callvirt System.Drawing.Graphics::Void DrawLine(System.Drawing.Pen, Int32, Int32, Int32, Int32)
				L_0521: leave.s L_052f
				L_0523: ldloc.s V_26
				L_0525: brfalse.s L_052e
				L_0527: ldloc.s V_26
				L_0529: callvirt System.IDisposable::Void Dispose()
				L_052e: endfinally 
				L_052f: ldloca.s V_5
				L_0531: call System.Drawing.Rectangle::Int32 get_Left()
				L_0536: ldc.i4.4 
				L_0537: add 
				L_0538: stloc.s V_27
				L_053a: ldsfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9c8c46cd7553cd2b
				L_053f: brfalse L_05bf
				L_0544: ldloc.s V_27
				L_0546: ldc.i4.4 
				L_0547: add 
				L_0548: ldloc.s V_10
				L_054a: ldc.i4.1 
				L_054b: add 
				L_054c: ldc.i4.4 
				L_054d: sub 
				L_054e: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0553: ldloc.s V_27
				L_0555: ldloc.s V_10
				L_0557: ldc.i4.1 
				L_0558: add 
				L_0559: ldc.i4.4 
				L_055a: add 
				L_055b: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0560: ldloc.s V_6
				L_0562: ldloc.s V_8
				L_0564: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Point, System.Drawing.Point, System.Drawing.Color, System.Drawing.Color)
				L_0569: stloc.s V_29
				L_056b: ldarg.1 
				L_056c: ldloc.s V_29
				L_056e: ldloc.s V_27
				L_0570: ldloc.s V_10
				L_0572: ldc.i4.1 
				L_0573: add 
				L_0574: ldc.i4.4 
				L_0575: ldc.i4.4 
				L_0576: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_057b: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_0580: ldloc.s V_27
				L_0582: ldc.i4.4 
				L_0583: add 
				L_0584: stloc.s V_27
				L_0586: leave.s L_0594
				L_0588: ldloc.s V_29
				L_058a: brfalse.s L_0593
				L_058c: ldloc.s V_29
				L_058e: callvirt System.IDisposable::Void Dispose()
				L_0593: endfinally 
				L_0594: ldc.i4 9999
				L_0599: ldloc.s V_10
				L_059b: ldc.i4.1 
				L_059c: add 
				L_059d: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_05a2: ldc.i4 9999
				L_05a7: ldloc.s V_10
				L_05a9: ldc.i4.1 
				L_05aa: add 
				L_05ab: ldc.i4.4 
				L_05ac: add 
				L_05ad: newobj System.Drawing.Point::Void .ctor(Int32, Int32)
				L_05b2: ldloc.s V_7
				L_05b4: ldloc.s V_8
				L_05b6: newobj System.Drawing.Drawing2D.LinearGradientBrush::Void .ctor(System.Drawing.Point, System.Drawing.Point, System.Drawing.Color, System.Drawing.Color)
				L_05bb: stloc.s V_28
				L_05bd: br.s L_05cb
				L_05bf: call System.Drawing.SystemColors::System.Drawing.Color get_ControlDark()
				L_05c4: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_05c9: stloc.s V_28
				L_05cb: ldarg.1 
				L_05cc: ldloc.s V_28
				L_05ce: ldloc.s V_27
				L_05d0: ldloc.s V_10
				L_05d2: ldc.i4.1 
				L_05d3: add 
				L_05d4: ldloc.s V_10
				L_05d6: ldloc.s V_27
				L_05d8: sub 
				L_05d9: ldc.i4.4 
				L_05da: sub 
				L_05db: ldc.i4.4 
				L_05dc: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_05e1: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_05e6: ldloc.s V_28
				L_05e8: callvirt System.Drawing.Brush::Void Dispose()
				L_05ed: br.s L_0640
				L_05ef: ldarg.1 
				L_05f0: ldarg.0 
				L_05f1: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_05f6: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_05fb: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0600: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOPSELECTEDMENUCOLOR()
				L_0605: ldloc.s V_5
				L_0607: callvirt System.Drawing.Graphics::Void FillRectangle(System.Drawing.Brush, System.Drawing.Rectangle)
				L_060c: ldarg.0 
				L_060d: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0612: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0617: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinColors get_Colors()
				L_061c: ldfld Sunisoft.IrisSkin.SkinColors::System.Drawing.Color SKIN2_TOPSELECTEDMENUBORDERCOLOR
				L_0621: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color)
				L_0626: stloc.s V_30
				L_0628: ldarg.1 
				L_0629: ldloc.s V_30
				L_062b: ldloc.s V_5
				L_062d: callvirt System.Drawing.Graphics::Void DrawRectangle(System.Drawing.Pen, System.Drawing.Rectangle)
				L_0632: leave.s L_0640
				L_0634: ldloc.s V_30
				L_0636: brfalse.s L_063f
				L_0638: ldloc.s V_30
				L_063a: callvirt System.IDisposable::Void Dispose()
				L_063f: endfinally 
				L_0640: ldarg.2 
				L_0641: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_0646: brfalse.s L_0696
				L_0648: ldloca.s V_1
				L_064a: call System.Drawing.Rectangle::Int32 get_Top()
				L_064f: stloc.s V_31
				L_0651: ldloca.s V_1
				L_0653: call System.Drawing.Rectangle::Int32 get_X()
				L_0658: ldloca.s V_1
				L_065a: call System.Drawing.Rectangle::Int32 get_Width()
				L_065f: ldc.i4.s 12
				L_0661: sub 
				L_0662: ldc.i4.2 
				L_0663: div 
				L_0664: add 
				L_0665: stloc.s V_32
				L_0667: ldarg.0 
				L_0668: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_066d: brfalse.s L_067b
				L_066f: ldloc.s V_32
				L_0671: ldc.i4.1 
				L_0672: add 
				L_0673: stloc.s V_32
				L_0675: ldloc.s V_31
				L_0677: ldc.i4.1 
				L_0678: add 
				L_0679: stloc.s V_31
				L_067b: ldarg.1 
				L_067c: ldsfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.ImageList xfeae2ed797ae6fbc
				L_0681: callvirt System.Windows.Forms.ImageList::ImageCollection get_Images()
				L_0686: ldc.i4.3 
				L_0687: callvirt System.Windows.Forms.ImageList+ImageCollection::System.Drawing.Image get_Item(Int32)
				L_068c: ldloc.s V_32
				L_068e: ldloc.s V_31
				L_0690: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, Int32, Int32)
				L_0695: ret 
				L_0696: newobj System.Drawing.StringFormat::Void .ctor()
				L_069b: stloc.s V_33
				L_069d: ldloc.s V_33
				L_069f: ldc.i4 20480
				L_06a4: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_06a9: ldloc.s V_33
				L_06ab: ldc.i4.1 
				L_06ac: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_06b1: ldloc.s V_33
				L_06b3: ldc.i4.1 
				L_06b4: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_06b9: ldloc.s V_33
				L_06bb: ldc.i4.1 
				L_06bc: callvirt System.Drawing.StringFormat::Void set_HotkeyPrefix(System.Drawing.Text.HotkeyPrefix)
				L_06c1: ldarg.0 
				L_06c2: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0 x23e85093ba3a7d1d
				L_06c7: brtrue.s L_06d8
				L_06c9: ldloc.s V_33
				L_06cb: dup 
				L_06cc: callvirt System.Drawing.StringFormat::System.Drawing.StringFormatFlags get_FormatFlags()
				L_06d1: ldc.i4.2 
				L_06d2: or 
				L_06d3: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_06d8: ldarg.2 
				L_06d9: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x9f2c0dc847992f03()
				L_06de: brfalse L_0795
				L_06e3: ldarg.0 
				L_06e4: call System.Windows.Forms.Control::Boolean get_Enabled()
				L_06e9: brfalse L_0795
				L_06ee: ldarg.0 
				L_06ef: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_06f4: brfalse.s L_072c
				L_06f6: ldarg.3 
				L_06f7: brfalse.s L_072c
				L_06f9: ldarg.0 
				L_06fa: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_06ff: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0704: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0709: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOPSELECTEDMENUFONTCOLOR()
				L_070e: stloc.0 
				L_070f: ldarg.1 
				L_0710: ldloc.2 
				L_0711: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_0716: ldarg.0 
				L_0717: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_071c: ldloc.0 
				L_071d: ldloc.s V_4
				L_071f: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_0724: ldloc.s V_33
				L_0726: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_072b: ret 
				L_072c: ldarg.3 
				L_072d: brfalse.s L_0762
				L_072f: ldarg.0 
				L_0730: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0735: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_073a: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_073f: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOPSELECTEDMENUFONTCOLOR()
				L_0744: stloc.0 
				L_0745: ldarg.1 
				L_0746: ldloc.2 
				L_0747: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_074c: ldarg.0 
				L_074d: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_0752: ldloc.0 
				L_0753: ldloc.s V_4
				L_0755: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_075a: ldloc.s V_33
				L_075c: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_0761: ret 
				L_0762: ldarg.0 
				L_0763: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.SkinEngine get_xdc87e2b99332cd4a()
				L_0768: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_076d: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBrushes get_Brushes()
				L_0772: callvirt Sunisoft.IrisSkin.SkinBrushes::System.Drawing.Brush get_SKIN2_TOPMENUFONTCOLOR()
				L_0777: stloc.0 
				L_0778: ldarg.1 
				L_0779: ldloc.2 
				L_077a: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_077f: ldarg.0 
				L_0780: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_0785: ldloc.0 
				L_0786: ldloc.s V_4
				L_0788: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_078d: ldloc.s V_33
				L_078f: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_0794: ret 
				L_0795: ldloc.s V_4
				L_0797: stloc.s V_34
				L_0799: ldloca.s V_34
				L_079b: ldc.i4.1 
				L_079c: ldc.i4.1 
				L_079d: call System.Drawing.Rectangle::Void Offset(Int32, Int32)
				L_07a2: ldarg.1 
				L_07a3: ldloc.2 
				L_07a4: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_07a9: ldarg.0 
				L_07aa: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_07af: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_07b4: ldloc.s V_34
				L_07b6: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_07bb: ldloc.s V_33
				L_07bd: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_07c2: call System.Drawing.SystemColors::System.Drawing.Color get_GrayText()
				L_07c7: newobj System.Drawing.SolidBrush::Void .ctor(System.Drawing.Color)
				L_07cc: stloc.s V_35
				L_07ce: ldarg.1 
				L_07cf: ldloc.2 
				L_07d0: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::System.String get_Text()
				L_07d5: ldarg.0 
				L_07d6: callvirt System.Windows.Forms.Control::System.Drawing.Font get_Font()
				L_07db: ldloc.s V_35
				L_07dd: ldloc.s V_4
				L_07df: call System.Drawing.RectangleF::System.Drawing.RectangleF op_Implicit(System.Drawing.Rectangle)
				L_07e4: ldloc.s V_33
				L_07e6: callvirt System.Drawing.Graphics::Void DrawString(System.String, System.Drawing.Font, System.Drawing.Brush, System.Drawing.RectangleF, System.Drawing.StringFormat)
				L_07eb: leave.s L_07f9
				L_07ed: ldloc.s V_35
				L_07ef: brfalse.s L_07f8
				L_07f1: ldloc.s V_35
				L_07f3: callvirt System.IDisposable::Void Dispose()
				L_07f8: endfinally 
				L_07f9: ret 
			*/
			
			
			{
				Brush brush1;
				Rectangle rectangle3;
				Rectangle rectangle4;
				Color color1;
				Color color2;
				Color color3;
				int i1;
				int i2;
				int i3;
				int i4;
				int i5;
				int i6;
				int i7;
				Brush brush2;
				Brush brush3;
				Brush brush4;
				Brush brush5;
				int i8;
				Brush brush6;
				int i9;
				Brush brush7;
				int i10;
				int i11;
				Rectangle rectangle5;
				Rectangle rectangle1 = xd2a8bb4342ab4ef6.xee63d905da8ff550;
				x5f4b657f68f87baa x5f4b657f68f87baa1 = xd2a8bb4342ab4ef6.x5f4b657f68f87baa;
				Rectangle rectangle2 = rectangle1;
				rectangle2.Width += 4;
				rectangle2.Height += 4;
				if (xd2a8bb4342ab4ef6.x43604484a3deae4f)
				{
					return;
				}
				if (xd2a8bb4342ab4ef6.xaa08ea3ba2fe9514)
				{
					rectangle3 = new Rectangle (((int) (rectangle1.Left + 3)), ((int) (rectangle1.Top + 1)), ((int) (rectangle1.Width - 6)), ((int) (rectangle1.Height - 2)));
				}
				else
				{
					rectangle3 = new Rectangle (((int) (rectangle1.Left + 3)), ((int) (rectangle1.Top + 3)), ((int) (rectangle1.Width - 6)), ((int) (rectangle1.Height - 6)));
				}
				if (xd2a8bb4342ab4ef6.x9f2c0dc847992f03 && x4b9cb2187c13edda)
				{
					if (this.x23e85093ba3a7d1d == Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da)
					{
						rectangle4 = new Rectangle (((int) (rectangle3.Left - 2)), ((int) (rectangle3.Top - 1)), ((int) (rectangle3.Width + 4)), ((int) (rectangle3.Height + 1)));
					}
					else if (! xd2a8bb4342ab4ef6.xaa08ea3ba2fe9514)
					{
						rectangle4 = new Rectangle (rectangle3.Left, ((int) (rectangle3.Top - 2)), ((int) (rectangle3.Width - 2)), ((int) (rectangle3.Height + 4)));
					}
					else
					{
						rectangle4 = rectangle3;
					}
					if (! this.x9f93ebd2ca5601a2)
					{
						x4b101060f4767186.FillRectangle (((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOPSELECTEDMENUCOLOR, rectangle4);
						using (Pen pen5 = new Pen (((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_TOPSELECTEDMENUBORDERCOLOR))
						{
							x4b101060f4767186.DrawRectangle (pen5, rectangle4);
						}
					}
					else
					{
						brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOPSELECTEDMENUCOLOR;
						x4b101060f4767186.FillRectangle (brush1, rectangle4);
						color1 = Color.FromArgb (64, 0, 0, 0);
						color2 = Color.FromArgb (48, 0, 0, 0);
						color3 = Color.FromArgb (0, 0, 0, 0);
						i1 = (rectangle4.Right + 1);
						i2 = rectangle4.Bottom;
						if ((! this.xf947c341af20623c) || (this.x23e85093ba3a7d1d != Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da))
						{
							using (Pen pen2 = new Pen (((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOPSELECTEDMENUBORDERCOLOR))
							{
								x4b101060f4767186.DrawRectangle (pen2, rectangle4);
							}
							if (xd2a8bb4342ab4ef6.x649e2ad374251b5f)
							{
								if (this.x23e85093ba3a7d1d != Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x3bce7c87328df8da)
								{
									x4b101060f4767186.DrawLine (Pens.White, rectangle4.Right, rectangle4.Top, rectangle4.Right, rectangle4.Bottom);
									using (Pen pen4 = new Pen (((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOPSELECTEDMENUFONTCOLOR))
									{
										x4b101060f4767186.DrawLine (pen4, rectangle4.Right, rectangle4.Top, rectangle4.Right, rectangle4.Bottom);
									}
									i9 = (rectangle4.Left + 4);
									if (! x3c41176af7e54b01.x9c8c46cd7553cd2b)
									{
										brush7 = ((Brush) new SolidBrush (SystemColors.ControlDark));
									}
									else
									{
										using (LinearGradientBrush linearGradientBrush2 = new LinearGradientBrush (new Point (((int) (i9 + 4)), ((int) ((i2 + 1) - 4))), new Point (i9, ((int) ((i2 + 1) + 4))), color1, color3))
										{
											x4b101060f4767186.FillRectangle (((Brush) linearGradientBrush2), new Rectangle (i9, ((int) (i2 + 1)), 4, 4));
											i9 += 4;
										}
										brush7 = ((Brush) new LinearGradientBrush (new Point (9999, ((int) (i2 + 1))), new Point (9999, ((int) ((i2 + 1) + 4))), color2, color3));
									}
									x4b101060f4767186.FillRectangle (brush7, new Rectangle (i9, ((int) (i2 + 1)), ((int) ((i2 - i9) - 4)), 4));
									brush7.Dispose ();
								}
								else
								{
									x4b101060f4767186.DrawLine (Pens.White, rectangle4.Left, rectangle4.Bottom, rectangle4.Right, rectangle4.Bottom);
									using (Pen pen3 = new Pen (((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOPSELECTEDMENUFONTCOLOR))
									{
										x4b101060f4767186.DrawLine (pen3, rectangle4.Left, rectangle4.Bottom, rectangle4.Right, rectangle4.Bottom);
									}
									i8 = (rectangle4.Top + 4);
									if (! x3c41176af7e54b01.x9c8c46cd7553cd2b)
									{
										brush6 = ((Brush) new SolidBrush (SystemColors.ControlDark));
									}
									else
									{
										using (LinearGradientBrush linearGradientBrush1 = new LinearGradientBrush (new Point (((int) (i1 - 4)), ((int) (i8 + 4))), new Point (((int) (i1 + 4)), i8), color1, color3))
										{
											x4b101060f4767186.FillRectangle (((Brush) linearGradientBrush1), new Rectangle (i1, i8, 4, 4));
											i8 += 4;
										}
										brush6 = ((Brush) new LinearGradientBrush (new Point (i1, 9999), new Point (((int) (i1 + 4)), 9999), color2, color3));
									}
									x4b101060f4767186.FillRectangle (brush6, new Rectangle (i1, i8, 4, ((int) (i2 - i8))));
									brush6.Dispose ();
								}
							}
						}
						else
						{
							using (Pen pen1 = new Pen (((SkinColors) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Colors).SKIN2_TOPSELECTEDMENUBORDERCOLOR))
							{
								x4b101060f4767186.DrawRectangle (pen1, rectangle4);
							}
							if (xd2a8bb4342ab4ef6.x649e2ad374251b5f)
							{
								i3 = rectangle4.Top;
								int i12 = rectangle4.Left;
								i4 = (rectangle4.Bottom + 1);
								i5 = (rectangle4.Left + 4);
								i6 = (rectangle4.Width + 1);
								i7 = 4;
								if (x3c41176af7e54b01.x9c8c46cd7553cd2b)
								{
									brush2 = ((Brush) new LinearGradientBrush (new Point (i1, 9999), new Point (((int) (i1 + 4)), 9999), color2, color3));
									brush3 = ((Brush) new LinearGradientBrush (new Point (((int) (i5 + 4)), ((int) (i4 - 4))), new Point (i5, ((int) (i4 + i7))), color1, color3));
									brush5 = ((Brush) new LinearGradientBrush (new Point (((int) (((i5 + i6) - 4) - 2)), ((int) ((i4 - 4) - 2))), new Point (((int) (i5 + i6)), ((int) (i4 + i7))), color1, color3));
									brush4 = ((Brush) new LinearGradientBrush (new Point (9999, i4), new Point (9999, ((int) (i4 + i7))), color2, color3));
								}
								else
								{
									brush2 = ((Brush) new SolidBrush (SystemColors.ControlDark));
									brush3 = brush2;
									brush4 = brush2;
									brush5 = brush2;
								}
								x4b101060f4767186.FillRectangle (brush2, new Rectangle (i1, i3, 4, ((int) ((i2 - i3) + 1))));
								x4b101060f4767186.FillRectangle (brush3, i5, i4, 4, i7);
								x4b101060f4767186.FillRectangle (brush5, ((int) ((i5 + i6) - 4)), i4, 4, i7);
								x4b101060f4767186.FillRectangle (brush4, ((int) (i5 + 4)), i4, ((int) (i6 - 8)), i7);
								if (x3c41176af7e54b01.x9c8c46cd7553cd2b)
								{
									brush2.Dispose ();
									brush3.Dispose ();
									brush4.Dispose ();
									brush5.Dispose ();
								}
								else
								{
									brush2.Dispose ();
								}
							}
						}
					}
				}
				if (xd2a8bb4342ab4ef6.xaa08ea3ba2fe9514)
				{
					i10 = rectangle1.Top;
					i11 = ((int) (rectangle1.X + ((rectangle1.Width - 12) / 2)));
					if (this.x9f93ebd2ca5601a2)
					{
						i11++;
						i10++;
					}
					x4b101060f4767186.DrawImage (x3c41176af7e54b01.xfeae2ed797ae6fbc.Images[3], i11, i10);
					return;
				}
				StringFormat stringFormat1 = new StringFormat ();
				stringFormat1.FormatFlags = (StringFormatFlags.NoWrap | StringFormatFlags.NoClip);
				stringFormat1.Alignment = StringAlignment.Center;
				stringFormat1.LineAlignment = StringAlignment.Center;
				stringFormat1.HotkeyPrefix = HotkeyPrefix.Show;
				if (this.x23e85093ba3a7d1d == Sunisoft.IrisSkin.InternalControls.xdbfa333b4cd503e0.x61c108cc44ef385a)
				{
					stringFormat1.FormatFlags |= StringFormatFlags.DirectionVertical;
				}
				if ((! xd2a8bb4342ab4ef6.x9f2c0dc847992f03) || (! base.Enabled))
				{
					(rectangle5 = rectangle3).Offset (1, 1);
					x4b101060f4767186.DrawString (x5f4b657f68f87baa1.Text, this.Font, Brushes.White, ((RectangleF) rectangle5), stringFormat1);
					using (SolidBrush solidBrush1 = new SolidBrush (SystemColors.GrayText))
					{
						x4b101060f4767186.DrawString (x5f4b657f68f87baa1.Text, this.Font, ((Brush) solidBrush1), ((RectangleF) rectangle3), stringFormat1);
					}
				}
				else if (this.x9f93ebd2ca5601a2 && x4b9cb2187c13edda)
				{
					brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOPSELECTEDMENUFONTCOLOR;
					x4b101060f4767186.DrawString (x5f4b657f68f87baa1.Text, this.Font, brush1, ((RectangleF) rectangle3), stringFormat1);
				}
				else if (x4b9cb2187c13edda)
				{
					brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOPSELECTEDMENUFONTCOLOR;
					x4b101060f4767186.DrawString (x5f4b657f68f87baa1.Text, this.Font, brush1, ((RectangleF) rectangle3), stringFormat1);
				}
				else
				{
					brush1 = ((SkinBrushes) ((Res) ((SkinEngine) this.xdc87e2b99332cd4a).Res).Brushes).SKIN2_TOPMENUFONTCOLOR;
					x4b101060f4767186.DrawString (x5f4b657f68f87baa1.Text, this.Font, brush1, ((RectangleF) rectangle3), stringFormat1);
				}
			}
			
			protected void xb73b905145ee3f9f ()
			
			/*
				// Code Size: 175 Bytes
				.maxstack 5
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_0006: ldarg.0 
				L_0007: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x199464e739d66b0b(System.Object, System.EventArgs)
				L_000d: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0012: callvirt System.Windows.Forms.Control::Void remove_Click(System.EventHandler)
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_001d: ldarg.0 
				L_001e: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x6b3bc391561e756b(System.Object, System.EventArgs)
				L_0024: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0029: callvirt System.Windows.Forms.Control::Void remove_Click(System.EventHandler)
				L_002e: ldarg.0 
				L_002f: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_0034: ldarg.0 
				L_0035: ldftn Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x0b912a2b95b630ba(System.Object, System.EventArgs)
				L_003b: newobj System.EventHandler::Void .ctor(System.Object, IntPtr)
				L_0040: callvirt System.Windows.Forms.Control::Void remove_Click(System.EventHandler)
				L_0045: ldarg.0 
				L_0046: call System.Windows.Forms.Control::ControlCollection get_Controls()
				L_004b: ldarg.0 
				L_004c: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_0051: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void xb845cf2a244dd721(ControlCollection, System.Windows.Forms.Control)
				L_0056: ldarg.0 
				L_0057: call System.Windows.Forms.Control::ControlCollection get_Controls()
				L_005c: ldarg.0 
				L_005d: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_0062: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void xb845cf2a244dd721(ControlCollection, System.Windows.Forms.Control)
				L_0067: ldarg.0 
				L_0068: call System.Windows.Forms.Control::ControlCollection get_Controls()
				L_006d: ldarg.0 
				L_006e: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_0073: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void xb845cf2a244dd721(ControlCollection, System.Windows.Forms.Control)
				L_0078: ldarg.0 
				L_0079: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_007e: callvirt System.ComponentModel.Component::Void Dispose()
				L_0083: ldarg.0 
				L_0084: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_0089: callvirt System.ComponentModel.Component::Void Dispose()
				L_008e: ldarg.0 
				L_008f: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_0094: callvirt System.ComponentModel.Component::Void Dispose()
				L_0099: ldarg.0 
				L_009a: ldnull 
				L_009b: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x2c6deb5021c80299
				L_00a0: ldarg.0 
				L_00a1: ldnull 
				L_00a2: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x0abc55e6ce1d8aed
				L_00a7: ldarg.0 
				L_00a8: ldnull 
				L_00a9: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x5d3356d9dffccb60 x26e80f23e22a05ae
				L_00ae: ret 
			*/
			
			
			{
				this.x2c6deb5021c80299.Click -= new EventHandler (this.x199464e739d66b0b);
				this.x0abc55e6ce1d8aed.Click -= new EventHandler (this.x6b3bc391561e756b);
				this.x26e80f23e22a05ae.Click -= new EventHandler (this.x0b912a2b95b630ba);
				x448fd9ab43628c71.xb845cf2a244dd721 (base.Controls, ((Control) this.x2c6deb5021c80299));
				x448fd9ab43628c71.xb845cf2a244dd721 (base.Controls, ((Control) this.x0abc55e6ce1d8aed));
				x448fd9ab43628c71.xb845cf2a244dd721 (base.Controls, ((Control) this.x26e80f23e22a05ae));
				this.x2c6deb5021c80299.Dispose ();
				this.x0abc55e6ce1d8aed.Dispose ();
				this.x26e80f23e22a05ae.Dispose ();
				this.x2c6deb5021c80299 = ((x5d3356d9dffccb60) null);
				this.x0abc55e6ce1d8aed = ((x5d3356d9dffccb60) null);
				this.x26e80f23e22a05ae = ((x5d3356d9dffccb60) null);
			}
			
			protected void xbcc99f3d02a70fe7 (int x75cf7df8c59ffa4d, int xc13ed6de98262a2d)
			
			/*
				// Code Size: 279 Bytes
				.maxstack 5
				.locals (System.Drawing.Point V_0, 
         System.Int32 V_1, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_2, 
         System.Drawing.Rectangle V_3)
				L_0000: ldloca.s V_0
				L_0002: ldarg.1 
				L_0003: ldarg.2 
				L_0004: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0009: ldc.i4.0 
				L_000a: stloc.1 
				L_000b: br L_0105
				L_0010: ldarg.0 
				L_0011: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_0016: ldloc.1 
				L_0017: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_001c: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0021: stloc.2 
				L_0022: ldloc.2 
				L_0023: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xb26619e061f1a4b4()
				L_0028: stloc.3 
				L_0029: ldloca.s V_3
				L_002b: ldloc.0 
				L_002c: call System.Drawing.Rectangle::Boolean Contains(System.Drawing.Point)
				L_0031: brfalse L_0101
				L_0036: ldloc.2 
				L_0037: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x9f2c0dc847992f03()
				L_003c: brfalse L_0101
				L_0041: ldloc.2 
				L_0042: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0047: brfalse.s L_0066
				L_0049: ldloc.2 
				L_004a: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_004f: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0054: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_0059: brtrue.s L_0066
				L_005b: ldloc.2 
				L_005c: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_0061: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Void PerformClick()
				L_0066: ldarg.0 
				L_0067: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_006c: brfalse.s L_0098
				L_006e: ldarg.0 
				L_006f: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0074: ldloc.1 
				L_0075: bne.un L_0116
				L_007a: ldarg.0 
				L_007b: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0080: brfalse L_0116
				L_0085: ldarg.0 
				L_0086: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_008b: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xf2996a13c26d70bb()
				L_0090: ldarg.0 
				L_0091: ldnull 
				L_0092: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_0097: ret 
				L_0098: ldarg.0 
				L_0099: ldc.i4.1 
				L_009a: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_009f: ldarg.0 
				L_00a0: ldc.i4.0 
				L_00a1: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xf947c341af20623c
				L_00a6: ldarg.0 
				L_00a7: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_00ac: ldloc.1 
				L_00ad: beq.s L_00c4
				L_00af: ldarg.0 
				L_00b0: ldarg.0 
				L_00b1: ldarg.0 
				L_00b2: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_00b7: ldloc.1 
				L_00b8: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xa7cbddf1ec7a27e7(Int32, Int32)
				L_00bd: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_00c2: br.s L_00d1
				L_00c4: ldarg.0 
				L_00c5: ldarg.0 
				L_00c6: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_00cb: ldc.i4.1 
				L_00cc: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x2cc390e9409b0f3f(Int32, Boolean)
				L_00d1: ldloc.2 
				L_00d2: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_00d7: brtrue.s L_00ec
				L_00d9: ldloc.2 
				L_00da: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_00df: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_00e4: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_00e9: ldc.i4.0 
				L_00ea: ble.s L_0116
				L_00ec: ldarg.0 
				L_00ed: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_00f2: ldarg.0 
				L_00f3: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::UInt32 xd8f9b747f716862a
				L_00f8: ldc.i4.1 
				L_00f9: ldc.i4.0 
				L_00fa: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_00ff: pop 
				L_0100: ret 
				L_0101: ldloc.1 
				L_0102: ldc.i4.1 
				L_0103: add 
				L_0104: stloc.1 
				L_0105: ldloc.1 
				L_0106: ldarg.0 
				L_0107: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_010c: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_0111: blt L_0010
				L_0116: ret 
			*/
			
			
			{
				Point point1;
				int i1;
				Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				point1 = new Point (x75cf7df8c59ffa4d, xc13ed6de98262a2d);
				i1 = 0;
				
			L_0105:
				
				{
				}
				if (i1 >= this.xfb5697071ce83988.Count)
				{
				}
				else
				{
					x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[i1] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f);
					if ((! x2cc390e9409b0f3f1.xb26619e061f1a4b4.Contains (point1)) || (! x2cc390e9409b0f3f1.x9f2c0dc847992f03))
					{
						i1++;
						goto L_0105;
					}
					else
					{
						if ((x2cc390e9409b0f3f1.x5f4b657f68f87baa != null) && (x2cc390e9409b0f3f1.x5f4b657f68f87baa.MenuCommands.Count == 0))
						{
							x2cc390e9409b0f3f1.x5f4b657f68f87baa.PerformClick ();
						}
						if (! this.x9f93ebd2ca5601a2)
						{
							this.x9f93ebd2ca5601a2 = true;
							this.xf947c341af20623c = false;
							if (this.xb266b78561d63b52 != i1)
							{
								this.xb266b78561d63b52 = this.xa7cbddf1ec7a27e7 (this.xb266b78561d63b52, i1);
							}
							else
							{
								this.x2cc390e9409b0f3f (this.xb266b78561d63b52, true);
							}
							if ((! x2cc390e9409b0f3f1.xaa08ea3ba2fe9514) && (x2cc390e9409b0f3f1.x5f4b657f68f87baa.MenuCommands.Count <= 0))
							{
							}
							else
							{
								bool b1 = x61467fe65a98f20c.PostMessage (base.Handle, this.xd8f9b747f716862a, 1, uint.MinValue);
								return;
								
								/*
									Unreachable Code
									goto L_0105;
								*/
							}
						}
						else if ((this.xb266b78561d63b52 == i1) && (this.x56be4c3c4c4173b7 != null))
						{
							this.x56be4c3c4c4173b7.xf2996a13c26d70bb ();
							this.x56be4c3c4c4173b7 = ((x902c4aee45bfd906) null);
						}
					}
				}
			}
			
			protected void xcb97d93f0d5ce4a8 ()
			
			/*
				// Code Size: 36 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.1 
				L_0002: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x20ad2840ee62b6a4
				L_0007: ldarg.0 
				L_0008: ldc.i4.0 
				L_0009: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_000e: ldarg.0 
				L_000f: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x466f602f66763da5
				L_0014: brfalse.s L_0023
				L_0016: ldarg.0 
				L_0017: ldarg.0 
				L_0018: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a xf4f555905eaa2330
				L_001d: ldc.i4.0 
				L_001e: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xe8febcf8320c4113(Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a, Boolean)
				L_0023: ret 
			*/
			
			
			{
				this.x20ad2840ee62b6a4 = true;
				this.x9f93ebd2ca5601a2 = false;
				if (this.x466f602f66763da5)
				{
					this.xe8febcf8320c4113 (this.xf4f555905eaa2330, false);
				}
			}
			
			internal void xd502a472a14a9c04 ()
			
			/*
				// Code Size: 38 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0006: ldc.i4.m1 
				L_0007: beq.s L_0025
				L_0009: ldarg.0 
				L_000a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_000f: brfalse.s L_0025
				L_0011: ldarg.0 
				L_0012: ldc.i4.1 
				L_0013: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xf947c341af20623c
				L_0018: ldarg.0 
				L_0019: ldarg.0 
				L_001a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_001f: ldc.i4.1 
				L_0020: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x2cc390e9409b0f3f(Int32, Boolean)
				L_0025: ret 
			*/
			
			
			{
				if ((this.xb266b78561d63b52 != -1) && this.x9f93ebd2ca5601a2)
				{
					this.xf947c341af20623c = true;
					this.x2cc390e9409b0f3f (this.xb266b78561d63b52, true);
				}
			}
			
			protected void xdd922e6d558c59d4 (int x75cf7df8c59ffa4d, int xc13ed6de98262a2d)
			
			/*
				// Code Size: 395 Bytes
				.maxstack 5
				.locals (Sunisoft.IrisSkin.x40255b11ef821fa3+TRACKMOUSEEVENTS V_0, 
         System.Windows.Forms.Form V_1, 
         System.Drawing.Point V_2, 
         System.Int32 V_3, 
         Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f V_4, 
         System.Drawing.Rectangle V_5)
				L_0000: ldarg.0 
				L_0001: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x72c40adab6f1d6f3
				L_0006: brfalse.s L_0010
				L_0008: ldarg.0 
				L_0009: ldc.i4.0 
				L_000a: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x72c40adab6f1d6f3
				L_000f: ret 
				L_0010: ldarg.0 
				L_0011: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x753f06f9b5cd6e0d
				L_0016: brtrue.s L_0055
				L_0018: ldloca.s V_0
				L_001a: initobj Sunisoft.IrisSkin.x40255b11ef821fa3+TRACKMOUSEEVENTS
				L_0020: ldloca.s V_0
				L_0022: ldc.i4.s 16
				L_0024: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+TRACKMOUSEEVENTS::UInt32 cbSize
				L_0029: ldloca.s V_0
				L_002b: ldc.i4.2 
				L_002c: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+TRACKMOUSEEVENTS::UInt32 dwFlags
				L_0031: ldloca.s V_0
				L_0033: ldarg.0 
				L_0034: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_0039: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+TRACKMOUSEEVENTS::IntPtr hWnd
				L_003e: ldloca.s V_0
				L_0040: ldc.i4.0 
				L_0041: stfld Sunisoft.IrisSkin.x40255b11ef821fa3+TRACKMOUSEEVENTS::UInt32 dwHoverTime
				L_0046: ldloca.s V_0
				L_0048: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean TrackMouseEvent(TRACKMOUSEEVENTS ByRef)
				L_004d: pop 
				L_004e: ldarg.0 
				L_004f: ldc.i4.1 
				L_0050: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x753f06f9b5cd6e0d
				L_0055: ldarg.0 
				L_0056: call System.Windows.Forms.Control::System.Windows.Forms.Form FindForm()
				L_005b: stloc.1 
				L_005c: ldloc.1 
				L_005d: brfalse L_018a
				L_0062: ldloc.1 
				L_0063: callvirt System.Windows.Forms.Control::Boolean get_ContainsFocus()
				L_0068: brfalse L_018a
				L_006d: ldloca.s V_2
				L_006f: ldarg.1 
				L_0070: ldarg.2 
				L_0071: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0076: ldc.i4.0 
				L_0077: stloc.3 
				L_0078: ldc.i4.0 
				L_0079: stloc.3 
				L_007a: br L_0148
				L_007f: ldarg.0 
				L_0080: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_0085: ldloc.3 
				L_0086: callvirt System.Collections.ArrayList::System.Object get_Item(Int32)
				L_008b: isinst Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f
				L_0090: stloc.s V_4
				L_0092: ldloc.s V_4
				L_0094: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::System.Drawing.Rectangle get_xb26619e061f1a4b4()
				L_0099: stloc.s V_5
				L_009b: ldloca.s V_5
				L_009d: ldloc.2 
				L_009e: call System.Drawing.Rectangle::Boolean Contains(System.Drawing.Point)
				L_00a3: brfalse L_0144
				L_00a8: ldloc.s V_4
				L_00aa: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_x9f2c0dc847992f03()
				L_00af: brfalse L_0144
				L_00b4: ldarg.0 
				L_00b5: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_00ba: ldloc.3 
				L_00bb: beq L_0159
				L_00c0: ldarg.0 
				L_00c1: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_00c6: brfalse.s L_012f
				L_00c8: ldarg.0 
				L_00c9: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_00ce: brfalse.s L_00e9
				L_00d0: ldarg.0 
				L_00d1: ldc.i4.1 
				L_00d2: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xd2893b73a80bf998
				L_00d7: ldarg.0 
				L_00d8: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906 x56be4c3c4c4173b7
				L_00dd: callvirt Sunisoft.IrisSkin.InternalControls.x902c4aee45bfd906::Void xf2996a13c26d70bb()
				L_00e2: ldarg.0 
				L_00e3: ldc.i4.0 
				L_00e4: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean xf947c341af20623c
				L_00e9: ldarg.0 
				L_00ea: ldarg.0 
				L_00eb: ldarg.0 
				L_00ec: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_00f1: ldloc.3 
				L_00f2: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xa7cbddf1ec7a27e7(Int32, Int32)
				L_00f7: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_00fc: ldloc.s V_4
				L_00fe: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Boolean get_xaa08ea3ba2fe9514()
				L_0103: brtrue.s L_0119
				L_0105: ldloc.s V_4
				L_0107: callvirt Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa get_x5f4b657f68f87baa()
				L_010c: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0111: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_0116: ldc.i4.0 
				L_0117: ble.s L_0159
				L_0119: ldarg.0 
				L_011a: call System.Windows.Forms.Control::IntPtr get_Handle()
				L_011f: ldarg.0 
				L_0120: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::UInt32 xd8f9b747f716862a
				L_0125: ldc.i4.1 
				L_0126: ldc.i4.0 
				L_0127: call Sunisoft.IrisSkin.x61467fe65a98f20c::Boolean PostMessage(IntPtr, UInt32, UInt32, UInt32)
				L_012c: pop 
				L_012d: br.s L_0159
				L_012f: ldarg.0 
				L_0130: ldarg.0 
				L_0131: ldarg.0 
				L_0132: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0137: ldloc.3 
				L_0138: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xa7cbddf1ec7a27e7(Int32, Int32)
				L_013d: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_0142: br.s L_0159
				L_0144: ldloc.3 
				L_0145: ldc.i4.1 
				L_0146: add 
				L_0147: stloc.3 
				L_0148: ldloc.3 
				L_0149: ldarg.0 
				L_014a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_014f: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_0154: blt L_007f
				L_0159: ldarg.0 
				L_015a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x9f93ebd2ca5601a2
				L_015f: brtrue.s L_018a
				L_0161: ldloc.3 
				L_0162: ldarg.0 
				L_0163: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Collections.ArrayList xfb5697071ce83988
				L_0168: callvirt System.Collections.ArrayList::Int32 get_Count()
				L_016d: bne.un.s L_018a
				L_016f: ldarg.0 
				L_0170: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Boolean x44d0011ba55ea8a3
				L_0175: brtrue.s L_018a
				L_0177: ldarg.0 
				L_0178: ldarg.0 
				L_0179: ldarg.0 
				L_017a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_017f: ldc.i4.m1 
				L_0180: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xa7cbddf1ec7a27e7(Int32, Int32)
				L_0185: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Int32 xb266b78561d63b52
				L_018a: ret 
			*/
			
			
			{
				x40255b11ef821fa3.TRACKMOUSEEVENTS tRACKMOUSEEVENTS1;
				Point point1;
				Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f x2cc390e9409b0f3f1;
				if (this.x72c40adab6f1d6f3)
				{
					this.x72c40adab6f1d6f3 = false;
					return;
				}
				if (! this.x753f06f9b5cd6e0d)
				{
					tRACKMOUSEEVENTS1 = new x40255b11ef821fa3.TRACKMOUSEEVENTS ();
					tRACKMOUSEEVENTS1.cbSize = 16;
					tRACKMOUSEEVENTS1.dwFlags = 2;
					tRACKMOUSEEVENTS1.hWnd = base.Handle;
					tRACKMOUSEEVENTS1.dwHoverTime = uint.MinValue;
					bool b1 = x61467fe65a98f20c.TrackMouseEvent (ref tRACKMOUSEEVENTS1);
					this.x753f06f9b5cd6e0d = true;
				}
				Form form1 = base.FindForm ();
				if ((form1 == null) || (! form1.ContainsFocus))
				{
					return;
				}
				point1 = new Point (x75cf7df8c59ffa4d, xc13ed6de98262a2d);
				int i1 = 0;
				while (i1 < this.xfb5697071ce83988.Count)
				{
					x2cc390e9409b0f3f1 = (this.xfb5697071ce83988[i1] as Sunisoft.IrisSkin.InternalControls.x2cc390e9409b0f3f);
					if ((! x2cc390e9409b0f3f1.xb26619e061f1a4b4.Contains (point1)) || (! x2cc390e9409b0f3f1.x9f2c0dc847992f03))
					{
						i1++;
						continue;
					}
					if (this.xb266b78561d63b52 != i1)
					{
						if (! this.x9f93ebd2ca5601a2)
						{
							this.xb266b78561d63b52 = this.xa7cbddf1ec7a27e7 (this.xb266b78561d63b52, i1);
							break;
						}
						if (this.x56be4c3c4c4173b7 != null)
						{
							this.xd2893b73a80bf998 = true;
							this.x56be4c3c4c4173b7.xf2996a13c26d70bb ();
							this.xf947c341af20623c = false;
						}
						this.xb266b78561d63b52 = this.xa7cbddf1ec7a27e7 (this.xb266b78561d63b52, i1);
						if (x2cc390e9409b0f3f1.xaa08ea3ba2fe9514 || (x2cc390e9409b0f3f1.x5f4b657f68f87baa.MenuCommands.Count > 0))
						{
							bool b2 = x61467fe65a98f20c.PostMessage (base.Handle, this.xd8f9b747f716862a, 1, uint.MinValue);
						}
					}
					break;
				}
				if (((! this.x9f93ebd2ca5601a2) && (i1 == this.xfb5697071ce83988.Count)) && (! this.x44d0011ba55ea8a3))
				{
					this.xb266b78561d63b52 = this.xa7cbddf1ec7a27e7 (this.xb266b78561d63b52, -1);
				}
			}
			
			protected void xe8febcf8320c4113 (xd53b20b7b4b2a08a x20e3b25d6d144908, bool x789c645a15deb49b)
			
			/*
				// Code Size: 74 Bytes
				.maxstack 4
				.locals (Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_0, 
         System.Collections.IEnumerator V_1, 
         System.IDisposable V_2)
				.try L_0007 to L_0038 finally L_0038 to L_0049
				L_0000: ldarg.1 
				L_0001: callvirt System.Collections.CollectionBase::System.Collections.IEnumerator GetEnumerator()
				L_0006: stloc.1 
				L_0007: br.s L_002e
				L_0009: ldloc.1 
				L_000a: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_000f: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0014: stloc.0 
				L_0015: ldloc.0 
				L_0016: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_001b: ldarg.2 
				L_001c: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Void set_x6f72c846c7dcb042(Boolean)
				L_0021: ldarg.0 
				L_0022: ldloc.0 
				L_0023: callvirt Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_MenuCommands()
				L_0028: ldarg.2 
				L_0029: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void xe8febcf8320c4113(Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a, Boolean)
				L_002e: ldloc.1 
				L_002f: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0034: brtrue.s L_0009
				L_0036: leave.s L_0049
				L_0038: ldloc.1 
				L_0039: isinst System.IDisposable
				L_003e: stloc.2 
				L_003f: ldloc.2 
				L_0040: brfalse.s L_0048
				L_0042: ldloc.2 
				L_0043: callvirt System.IDisposable::Void Dispose()
				L_0048: endfinally 
				L_0049: ret 
			*/
			
			
			{
				foreach (x5f4b657f68f87baa x5f4b657f68f87baa1 in x20e3b25d6d144908)
				{
					x5f4b657f68f87baa1.MenuCommands.x6f72c846c7dcb042 = x789c645a15deb49b;
					this.xe8febcf8320c4113 (x5f4b657f68f87baa1.MenuCommands, x789c645a15deb49b);
				}
			}
			
			protected void xfbce0f1d6df984cd (object xe0292b9ed559da7d, EventArgs xfbf34718e704c6bc)
			
			/*
				// Code Size: 481 Bytes
				.maxstack 3
				.locals (System.Windows.Forms.Form V_0, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_1, 
         System.Windows.Forms.Control V_2, 
         Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa V_3, 
         System.Collections.IEnumerator V_4, 
         System.IDisposable V_5)
				.try L_001f to L_0053 finally L_0053 to L_0068
				.try L_00ce to L_0127 finally L_0127 to L_013c
				.try L_0156 to L_017d finally L_017d to L_0192
				L_0000: ldnull 
				L_0001: stloc.0 
				L_0002: ldarg.0 
				L_0003: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5142fa1a3d9591c8
				L_0008: brfalse L_00ab
				L_000d: ldarg.0 
				L_000e: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5142fa1a3d9591c8
				L_0013: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_0018: callvirt System.Collections.CollectionBase::System.Collections.IEnumerator GetEnumerator()
				L_001d: stloc.s V_4
				L_001f: br.s L_0048
				L_0021: ldloc.s V_4
				L_0023: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_0028: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_002d: stloc.1 
				L_002e: ldarg.0 
				L_002f: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_0034: ldloc.1 
				L_0035: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Boolean x263d579af1d0d43f(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_003a: brfalse.s L_0048
				L_003c: ldarg.0 
				L_003d: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_0042: ldloc.1 
				L_0043: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Void x52b190e626f65140(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0048: ldloc.s V_4
				L_004a: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_004f: brtrue.s L_0021
				L_0051: leave.s L_0068
				L_0053: ldloc.s V_4
				L_0055: isinst System.IDisposable
				L_005a: stloc.s V_5
				L_005c: ldloc.s V_5
				L_005e: brfalse.s L_0067
				L_0060: ldloc.s V_5
				L_0062: callvirt System.IDisposable::Void Dispose()
				L_0067: endfinally 
				L_0068: ldarg.0 
				L_0069: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5142fa1a3d9591c8
				L_006e: callvirt System.Windows.Forms.Control::System.Object get_Tag()
				L_0073: isinst System.Windows.Forms.Form
				L_0078: brfalse.s L_00a4
				L_007a: ldarg.0 
				L_007b: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5142fa1a3d9591c8
				L_0080: callvirt System.Windows.Forms.Control::System.Object get_Tag()
				L_0085: castclass System.Windows.Forms.Form
				L_008a: stloc.0 
				L_008b: ldloc.0 
				L_008c: callvirt System.Windows.Forms.Control::Boolean get_IsDisposed()
				L_0091: brtrue.s L_00a4
				L_0093: ldloc.0 
				L_0094: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0099: ldarg.0 
				L_009a: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5142fa1a3d9591c8
				L_009f: callvirt System.Windows.Forms.Control+ControlCollection::Void Add(System.Windows.Forms.Control)
				L_00a4: ldarg.0 
				L_00a5: ldnull 
				L_00a6: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5142fa1a3d9591c8
				L_00ab: ldarg.0 
				L_00ac: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_00b1: callvirt System.Windows.Forms.Form::System.Windows.Forms.FormWindowState get_WindowState()
				L_00b6: ldc.i4.2 
				L_00b7: bne.un L_019e
				L_00bc: ldarg.0 
				L_00bd: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_00c2: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_00c7: callvirt System.Windows.Forms.Control+ControlCollection::System.Collections.IEnumerator GetEnumerator()
				L_00cc: stloc.s V_4
				L_00ce: br.s L_011c
				L_00d0: ldloc.s V_4
				L_00d2: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_00d7: castclass System.Windows.Forms.Control
				L_00dc: stloc.2 
				L_00dd: ldloc.2 
				L_00de: isinst Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01
				L_00e3: brfalse.s L_0115
				L_00e5: ldarg.0 
				L_00e6: ldloc.2 
				L_00e7: castclass Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01
				L_00ec: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5142fa1a3d9591c8
				L_00f1: ldarg.0 
				L_00f2: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5142fa1a3d9591c8
				L_00f7: ldarg.0 
				L_00f8: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_00fd: callvirt System.Windows.Forms.Control::Void set_Tag(System.Object)
				L_0102: ldarg.0 
				L_0103: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_0108: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_010d: ldloc.2 
				L_010e: callvirt System.Windows.Forms.Control+ControlCollection::Void Remove(System.Windows.Forms.Control)
				L_0113: br.s L_0125
				L_0115: ldarg.0 
				L_0116: ldnull 
				L_0117: stfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5142fa1a3d9591c8
				L_011c: ldloc.s V_4
				L_011e: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0123: brtrue.s L_00d0
				L_0125: leave.s L_013c
				L_0127: ldloc.s V_4
				L_0129: isinst System.IDisposable
				L_012e: stloc.s V_5
				L_0130: ldloc.s V_5
				L_0132: brfalse.s L_013b
				L_0134: ldloc.s V_5
				L_0136: callvirt System.IDisposable::Void Dispose()
				L_013b: endfinally 
				L_013c: ldarg.0 
				L_013d: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5142fa1a3d9591c8
				L_0142: brfalse.s L_0192
				L_0144: ldarg.0 
				L_0145: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01 x5142fa1a3d9591c8
				L_014a: callvirt Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_014f: callvirt System.Collections.CollectionBase::System.Collections.IEnumerator GetEnumerator()
				L_0154: stloc.s V_4
				L_0156: br.s L_0172
				L_0158: ldloc.s V_4
				L_015a: callvirt System.Collections.IEnumerator::System.Object get_Current()
				L_015f: castclass Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa
				L_0164: stloc.3 
				L_0165: ldarg.0 
				L_0166: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_016b: ldloc.3 
				L_016c: callvirt Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a::Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa xd6b6ed77479ef68c(Sunisoft.IrisSkin.InternalControls.x5f4b657f68f87baa)
				L_0171: pop 
				L_0172: ldloc.s V_4
				L_0174: callvirt System.Collections.IEnumerator::Boolean MoveNext()
				L_0179: brtrue.s L_0158
				L_017b: leave.s L_0192
				L_017d: ldloc.s V_4
				L_017f: isinst System.IDisposable
				L_0184: stloc.s V_5
				L_0186: ldloc.s V_5
				L_0188: brfalse.s L_0191
				L_018a: ldloc.s V_5
				L_018c: callvirt System.IDisposable::Void Dispose()
				L_0191: endfinally 
				L_0192: ldarg.0 
				L_0193: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Void x39e008704a72ea56()
				L_0198: ldarg.0 
				L_0199: call System.Windows.Forms.Control::Void Invalidate()
				L_019e: ldarg.0 
				L_019f: call Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::Sunisoft.IrisSkin.InternalControls.xd53b20b7b4b2a08a get_x6ef5a4a9a9587cfd()
				L_01a4: callvirt System.Collections.CollectionBase::Int32 get_Count()
				L_01a9: brtrue.s L_01d9
				L_01ab: ldarg.0 
				L_01ac: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_01b1: brfalse.s L_01d1
				L_01b3: ldarg.0 
				L_01b4: ldfld Sunisoft.IrisSkin.InternalControls.x3c41176af7e54b01::System.Windows.Forms.Form x562fa9742b4f7ed5
				L_01b9: callvirt System.Windows.Forms.Form::System.Windows.Forms.FormWindowState get_WindowState()
				L_01be: ldc.i4.2 
				L_01bf: bne.un.s L_01c9
				L_01c1: ldarg.0 
				L_01c2: ldc.i4.1 
				L_01c3: call System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_01c8: ret 
				L_01c9: ldarg.0 
				L_01ca: ldc.i4.0 
				L_01cb: call System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_01d0: ret 
				L_01d1: ldarg.0 
				L_01d2: ldc.i4.0 
				L_01d3: call System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_01d8: ret 
				L_01d9: ldarg.0 
				L_01da: ldc.i4.1 
				L_01db: call System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_01e0: ret 
			*/
			
			
			{
				Form form1 = ((Form) null);
				if (this.x5142fa1a3d9591c8 != null)
				{
					foreach (x5f4b657f68f87baa x5f4b657f68f87baa1 in this.x5142fa1a3d9591c8.x6ef5a4a9a9587cfd)
					{
						if (this.x6ef5a4a9a9587cfd.x263d579af1d0d43f (x5f4b657f68f87baa1))
						{
							this.x6ef5a4a9a9587cfd.x52b190e626f65140 (x5f4b657f68f87baa1);
						}
					}
					if (this.x5142fa1a3d9591c8.Tag is Form)
					{
						form1 = ((Form) this.x5142fa1a3d9591c8.Tag);
						if (! form1.IsDisposed)
						{
							form1.Controls.Add (((Control) this.x5142fa1a3d9591c8));
						}
					}
					this.x5142fa1a3d9591c8 = ((x3c41176af7e54b01) null);
				}
				if (this.x562fa9742b4f7ed5.WindowState == FormWindowState.Maximized)
				{
					foreach (Control control1 in this.x562fa9742b4f7ed5.Controls)
					{
						if (! (control1 is x3c41176af7e54b01))
						{
							this.x5142fa1a3d9591c8 = ((x3c41176af7e54b01) null);
							continue;
						}
						this.x5142fa1a3d9591c8 = ((x3c41176af7e54b01) control1);
						this.x5142fa1a3d9591c8.Tag = this.x562fa9742b4f7ed5;
						this.x562fa9742b4f7ed5.Controls.Remove (control1);
						break;
					}
					if (this.x5142fa1a3d9591c8 != null)
					{
						foreach (x5f4b657f68f87baa x5f4b657f68f87baa2 in this.x5142fa1a3d9591c8.x6ef5a4a9a9587cfd)
						{
							x5f4b657f68f87baa x5f4b657f68f87baa3 = this.x6ef5a4a9a9587cfd.xd6b6ed77479ef68c (x5f4b657f68f87baa2);
						}
					}
					this.x39e008704a72ea56 ();
					base.Invalidate ();
				}
				if (this.x6ef5a4a9a9587cfd.Count != 0)
				{
					base.Visible = true;
				}
				else if (this.x562fa9742b4f7ed5 == null)
				{
					base.Visible = false;
				}
				else if (this.x562fa9742b4f7ed5.WindowState == FormWindowState.Maximized)
				{
					base.Visible = true;
				}
				else
				{
					base.Visible = false;
				}
			}
			
		#endregion
	}
	
}

