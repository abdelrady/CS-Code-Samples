//
// Decompiled with: Decompiler.NET, Version=2.0.0.230, Culture=neutral, PublicKeyToken=null, Version: 2.0.0.230
// Decompilation Started at: 19/12/2006 04:06:10 ?
// Copyright 2003 - 2004, Jungle Creatures, Inc., All Rights Reserved. http://www.junglecreatures.com/
// Written by Jonathan Pierce, Email: support@junglecreatures.com
//

namespace Sunisoft.IrisSkin

{
		
		#region Namespace Import Declarations
		
			using System.Collections;
			using System.ComponentModel;
			using System.Drawing;
			using System.Drawing.Imaging;
			using System.Drawing.Text;
			using System;
			using System.Reflection;
			using System.Runtime.InteropServices;
			using System.Windows.Forms;
			using xb9d8bb5e6df032aa;
			
			
		#endregion
		
	internal class x448fd9ab43628c71
	
	{
		
		#region Fields
			private static bool x02a9729195580525;
			internal static Hashtable x1c12011307e0a753;
			private static Color x27d07b3cbf2c9479;
			public static byte x3258a1f6c09e8dfb;
			public const int x3d3efb7f08b93b8a = 0;
			private static StringFormat x488379a1c8afe803;
			private static Pen x4f0034703b20af0f;
			public static byte x52627eaa7cc46171;
			public const byte x5baf8d4275166d62 = 33;
			private static bool x605ccaa3586218f6;
			private static ImageAttributes x68a7ff53010868dc;
			public static byte x755993ebc8adfbf2;
			private static ImageAttributes xa11b666f50e9398f;
			private static StringFormat xad5d7fbaf75245c8;
			private static ImageAttributes xc7766c1739984987;
			private static StringFormat xd02bd90925d5d5ca;
			public static byte xd57134b167f2732e;
			public const byte xd82c44acd3ab3b2d = 68;
			public const byte xe16cf6fba798e93d = 99;
			private static StringFormat xe8c22659bee459d5;
			public static byte xee58c1cabb6499f1;
		#endregion
		
		#region Constructors
		
			private x448fd9ab43628c71 ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ret 
			*/
			
			static x448fd9ab43628c71 ()
			/*
				// Code Size: 428 Bytes
				.maxstack 4
				L_0000: ldc.i4.s 56
				L_0002: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::Byte x3258a1f6c09e8dfb
				L_0007: ldc.i4.s 51
				L_0009: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::Byte x52627eaa7cc46171
				L_000e: ldc.i4.s 118
				L_0010: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::Byte xee58c1cabb6499f1
				L_0015: ldc.i4 161
				L_001a: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::Byte xd57134b167f2732e
				L_001f: ldc.i4 166
				L_0024: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::Byte x755993ebc8adfbf2
				L_0029: newobj System.Drawing.Imaging.ImageAttributes::Void .ctor()
				L_002e: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes xc7766c1739984987
				L_0033: newobj System.Drawing.Imaging.ImageAttributes::Void .ctor()
				L_0038: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes x68a7ff53010868dc
				L_003d: newobj System.Drawing.Imaging.ImageAttributes::Void .ctor()
				L_0042: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes xa11b666f50e9398f
				L_0047: ldc.i4.0 
				L_0048: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x02a9729195580525
				L_004d: ldc.i4.0 
				L_004e: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x605ccaa3586218f6
				L_0053: ldc.i4 255
				L_0058: ldc.i4.0 
				L_0059: ldc.i4 255
				L_005e: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32)
				L_0063: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Color x27d07b3cbf2c9479
				L_0068: ldc.i4 181
				L_006d: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::Byte x755993ebc8adfbf2
				L_0072: call System.Drawing.Color::System.Drawing.Color get_Black()
				L_0077: ldc.r4 1
				L_007c: newobj System.Drawing.Pen::Void .ctor(System.Drawing.Color, Single)
				L_0081: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Pen x4f0034703b20af0f
				L_0086: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Pen x4f0034703b20af0f
				L_008b: ldc.i4.2 
				L_008c: callvirt System.Drawing.Pen::Void set_DashStyle(System.Drawing.Drawing2D.DashStyle)
				L_0091: newobj System.Drawing.StringFormat::Void .ctor()
				L_0096: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat x488379a1c8afe803
				L_009b: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat x488379a1c8afe803
				L_00a0: ldc.i4.1 
				L_00a1: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00a6: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat x488379a1c8afe803
				L_00ab: ldc.i4.1 
				L_00ac: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_00b1: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat x488379a1c8afe803
				L_00b6: ldc.i4.1 
				L_00b7: callvirt System.Drawing.StringFormat::Void set_HotkeyPrefix(System.Drawing.Text.HotkeyPrefix)
				L_00bc: newobj System.Drawing.StringFormat::Void .ctor()
				L_00c1: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xd02bd90925d5d5ca
				L_00c6: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xd02bd90925d5d5ca
				L_00cb: ldc.i4.0 
				L_00cc: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00d1: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xd02bd90925d5d5ca
				L_00d6: ldc.i4.1 
				L_00d7: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_00dc: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xd02bd90925d5d5ca
				L_00e1: ldc.i4.1 
				L_00e2: callvirt System.Drawing.StringFormat::Void set_HotkeyPrefix(System.Drawing.Text.HotkeyPrefix)
				L_00e7: newobj System.Drawing.StringFormat::Void .ctor()
				L_00ec: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xe8c22659bee459d5
				L_00f1: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xe8c22659bee459d5
				L_00f6: ldc.i4.0 
				L_00f7: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00fc: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xe8c22659bee459d5
				L_0101: ldc.i4.1 
				L_0102: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_0107: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xe8c22659bee459d5
				L_010c: ldc.i4.1 
				L_010d: callvirt System.Drawing.StringFormat::Void set_HotkeyPrefix(System.Drawing.Text.HotkeyPrefix)
				L_0112: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xe8c22659bee459d5
				L_0117: ldc.i4.1 
				L_0118: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_011d: newobj System.Drawing.StringFormat::Void .ctor()
				L_0122: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xad5d7fbaf75245c8
				L_0127: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xad5d7fbaf75245c8
				L_012c: ldc.i4.2 
				L_012d: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_0132: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xad5d7fbaf75245c8
				L_0137: ldc.i4.1 
				L_0138: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_013d: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xad5d7fbaf75245c8
				L_0142: ldc.i4.0 
				L_0143: callvirt System.Drawing.StringFormat::Void set_HotkeyPrefix(System.Drawing.Text.HotkeyPrefix)
				L_0148: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes xc7766c1739984987
				L_014d: ldc.i4.1 
				L_014e: callvirt System.Drawing.Imaging.ImageAttributes::Void SetWrapMode(System.Drawing.Drawing2D.WrapMode)
				L_0153: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes x68a7ff53010868dc
				L_0158: ldc.i4.2 
				L_0159: callvirt System.Drawing.Imaging.ImageAttributes::Void SetWrapMode(System.Drawing.Drawing2D.WrapMode)
				L_015e: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes xa11b666f50e9398f
				L_0163: callvirt System.Drawing.Imaging.ImageAttributes::Void SetNoOp()
				L_0168: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes xa11b666f50e9398f
				L_016d: ldc.i4.3 
				L_016e: callvirt System.Drawing.Imaging.ImageAttributes::Void SetWrapMode(System.Drawing.Drawing2D.WrapMode)
				L_0173: ldc.i4.s 119
				L_0175: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::Byte xee58c1cabb6499f1
				L_017a: ldc.i4.s 68
				L_017c: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::Byte x3258a1f6c09e8dfb
				L_0181: newobj System.Collections.Hashtable::Void .ctor()
				L_0186: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Collections.Hashtable x1c12011307e0a753
				L_018b: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Collections.Hashtable x1c12011307e0a753
				L_0190: ldstr "flcRzsRtDNr2XBiCoY7NrAC352AiFA/4YuLs4nDCyOHZX5xvWtgH/g=="
				L_0195: ldnull 
				L_0196: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_019b: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Collections.Hashtable x1c12011307e0a753
				L_01a0: ldstr "isBx30VBCC0GTnJuOKmQ0jK7I8NqeyOjDigXGIG5v1dN7aw4qc3Ogw=="
				L_01a5: ldnull 
				L_01a6: callvirt System.Collections.Hashtable::Void Add(System.Object, System.Object)
				L_01ab: ret 
			*/
		#endregion
		
		#region Properties
		
			public static Font x0a05657cf1966ee7
			
			{
				get
				
				/*
					// Code Size: 6 Bytes
					.maxstack 9
					L_0000: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Font x357f53120b135506()
					L_0005: ret 
				*/
				
				{
					return x448fd9ab43628c71.x357f53120b135506 ();
				}
			}
			
			
			public static StringFormat x0a56a54f56259220
			
			{
				get
				
				/*
					// Code Size: 6 Bytes
					.maxstack 9
					L_0000: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat x488379a1c8afe803
					L_0005: ret 
				*/
				
				{
					return x448fd9ab43628c71.x488379a1c8afe803;
				}
			}
			
			
			public static StringFormat x0c71f394477b252a
			
			{
				get
				
				/*
					// Code Size: 6 Bytes
					.maxstack 9
					L_0000: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xe8c22659bee459d5
					L_0005: ret 
				*/
				
				{
					return x448fd9ab43628c71.xe8c22659bee459d5;
				}
			}
			
			
			public static StringFormat x33298d8984e76949
			
			{
				get
				
				/*
					// Code Size: 6 Bytes
					.maxstack 9
					L_0000: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xd02bd90925d5d5ca
					L_0005: ret 
				*/
				
				{
					return x448fd9ab43628c71.xd02bd90925d5d5ca;
				}
			}
			
			
			public static ImageAttributes x349935d524988797
			
			{
				get
				
				/*
					// Code Size: 6 Bytes
					.maxstack 9
					L_0000: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes x68a7ff53010868dc
					L_0005: ret 
				*/
				
				{
					return x448fd9ab43628c71.x68a7ff53010868dc;
				}
			}
			
			
			public static StringFormat x5d48aae543c10712
			
			{
				get
				
				/*
					// Code Size: 6 Bytes
					.maxstack 9
					L_0000: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.StringFormat xad5d7fbaf75245c8
					L_0005: ret 
				*/
				
				{
					return x448fd9ab43628c71.xad5d7fbaf75245c8;
				}
			}
			
			
			public static bool x629c43fbef2ee4a7
			
			{
				get
				
				/*
					// Code Size: 52 Bytes
					.maxstack 9
					L_0000: call System.Environment::System.OperatingSystem get_OSVersion()
					L_0005: callvirt System.OperatingSystem::System.PlatformID get_Platform()
					L_000a: ldc.i4.2 
					L_000b: bne.un.s L_0032
					L_000d: call System.Environment::System.OperatingSystem get_OSVersion()
					L_0012: callvirt System.OperatingSystem::System.Version get_Version()
					L_0017: callvirt System.Version::Int32 get_Major()
					L_001c: ldc.i4.6 
					L_001d: bne.un.s L_0032
					L_001f: call System.Environment::System.OperatingSystem get_OSVersion()
					L_0024: callvirt System.OperatingSystem::System.Version get_Version()
					L_0029: callvirt System.Version::Int32 get_Minor()
					L_002e: ldc.i4.0 
					L_002f: ceq 
					L_0031: ret 
					L_0032: ldc.i4.0 
					L_0033: ret 
				*/
				
				{
					if (Environment.OSVersion.Platform != PlatformID.Win32NT)
					{
						return false;
					}
					else if (Environment.OSVersion.Version.Major != 6)
					{
						return false;
					}
					else
					{
						return (Environment.OSVersion.Version.Minor == 0);
					}
				}
			}
			
			
			public static Pen x6ee6589d93f80946
			
			{
				get
				
				/*
					// Code Size: 6 Bytes
					.maxstack 9
					L_0000: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Pen x4f0034703b20af0f
					L_0005: ret 
				*/
				
				{
					return x448fd9ab43628c71.x4f0034703b20af0f;
				}
			}
			
			
			public static ImageAttributes x8da407ebcbbfe204
			
			{
				get
				
				/*
					// Code Size: 6 Bytes
					.maxstack 9
					L_0000: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes xc7766c1739984987
					L_0005: ret 
				*/
				
				{
					return x448fd9ab43628c71.xc7766c1739984987;
				}
			}
			
			
			public static ImageAttributes xa51e2af4ce885d13
			
			{
				get
				
				/*
					// Code Size: 6 Bytes
					.maxstack 9
					L_0000: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes xa11b666f50e9398f
					L_0005: ret 
				*/
				
				{
					return x448fd9ab43628c71.xa11b666f50e9398f;
				}
			}
			
			
			public static Color xca4ac2dff2fb2d2f
			
			{
				get
				
				/*
					// Code Size: 6 Bytes
					.maxstack 9
					L_0000: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Color x27d07b3cbf2c9479
					L_0005: ret 
				*/
				
				{
					return x448fd9ab43628c71.x27d07b3cbf2c9479;
				}
			}
			
			
			public static bool xcc4a67682a2ded8e
			
			{
				get
				
				/*
					// Code Size: 59 Bytes
					.maxstack 3
					.locals (System.String V_0)
					L_0000: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x02a9729195580525
					L_0005: brtrue.s L_0035
					L_0007: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.String x025330efe4d5de1e()
					L_000c: stloc.0 
					L_000d: ldloc.0 
					L_000e: ldstr "1.0.3300.0"
					L_0013: call System.String::Boolean op_Equality(System.String, System.String)
					L_0018: brtrue.s L_0027
					L_001a: ldloc.0 
					L_001b: ldstr "1.0.5000.0"
					L_0020: call System.String::Boolean op_Equality(System.String, System.String)
					L_0025: brfalse.s L_002f
					L_0027: ldc.i4.0 
					L_0028: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x605ccaa3586218f6
					L_002d: br.s L_0035
					L_002f: ldc.i4.1 
					L_0030: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x605ccaa3586218f6
					L_0035: ldsfld Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x605ccaa3586218f6
					L_003a: ret 
				*/
				
				{
					if (x448fd9ab43628c71.x02a9729195580525)
					{
						return x448fd9ab43628c71.x605ccaa3586218f6;
					}
					string string1 = x448fd9ab43628c71.x025330efe4d5de1e ();
					if ((string1 == "1.0.3300.0") || (string1 == "1.0.5000.0"))
					{
						x448fd9ab43628c71.x605ccaa3586218f6 = false;
					}
					else
					{
						x448fd9ab43628c71.x605ccaa3586218f6 = true;
					}
					return x448fd9ab43628c71.x605ccaa3586218f6;
				}
			}
			
		#endregion
		
		#region Methods
		
			public static string x025330efe4d5de1e ()
			
			/*
				// Code Size: 99 Bytes
				.maxstack 5
				.locals (System.Reflection.Assembly V_0, 
         System.String V_1, 
         System.String V_2, 
         System.Int32 V_3, 
         System.Int32 V_4)
				.try L_0050 to L_005e catch System.Object L_005e to L_0061
				L_0000: ldc.i4.1 
				L_0001: stsfld Sunisoft.IrisSkin.x448fd9ab43628c71::Boolean x02a9729195580525
				L_0006: ldtoken System.Windows.Forms.CommonDialog
				L_000b: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_0010: call System.Reflection.Assembly::System.Reflection.Assembly GetAssembly(System.Type)
				L_0015: stloc.0 
				L_0016: ldloc.0 
				L_0017: callvirt System.Reflection.Assembly::System.String get_FullName()
				L_001c: stloc.1 
				L_001d: ldnull 
				L_001e: stloc.2 
				L_001f: ldloc.1 
				L_0020: ldstr "Version="
				L_0025: callvirt System.String::Int32 IndexOf(System.String)
				L_002a: stloc.3 
				L_002b: ldloc.3 
				L_002c: ldc.i4.m1 
				L_002d: beq.s L_0061
				L_002f: ldloc.3 
				L_0030: ldc.i4.8 
				L_0031: add 
				L_0032: stloc.3 
				L_0033: ldloc.1 
				L_0034: ldstr ","
				L_0039: ldloc.3 
				L_003a: callvirt System.String::Int32 IndexOf(System.String, Int32)
				L_003f: stloc.s V_4
				L_0041: ldloc.s V_4
				L_0043: ldc.i4.m1 
				L_0044: bne.un.s L_0050
				L_0046: ldloc.1 
				L_0047: callvirt System.String::Int32 get_Length()
				L_004c: ldc.i4.1 
				L_004d: sub 
				L_004e: stloc.s V_4
				L_0050: ldloc.1 
				L_0051: ldloc.3 
				L_0052: ldloc.s V_4
				L_0054: ldloc.3 
				L_0055: sub 
				L_0056: callvirt System.String::System.String Substring(Int32, Int32)
				L_005b: stloc.2 
				L_005c: leave.s L_0061
				L_005e: pop 
				L_005f: leave.s L_0061
				L_0061: ldloc.2 
				L_0062: ret 
			*/
			
			
			{
				x448fd9ab43628c71.x02a9729195580525 = true;
				Assembly assembly1 = Assembly.GetAssembly (typeof (CommonDialog));
				string string1 = assembly1.FullName;
				string string2 = ((string) null);
				int i1 = string1.IndexOf ("Version0x03d");
				if (i1 == -1)
				{
					return string2;
				}
				i1 += 8;
				int i2 = string1.IndexOf (",", i1);
				if (i2 == -1)
				{
					i2 = (string1.Length - 1);
				}
				try
				{
					string2 = string1.Substring (i1, ((int) (i2 - i1)));
				}
				catch
				{
				}
				return string2;
			}
			
			public static string x0c99d87520d2183f (string xf6987a1745781d6f)
			
			/*
				// Code Size: 118 Bytes
				.maxstack 3
				.locals (System.String V_0, 
         System.Char V_1, 
         System.CharEnumerator V_2, 
         System.Char V_3)
				L_0000: ldarg.0 
				L_0001: callvirt System.String::System.String ToUpper()
				L_0006: starg.s xf6987a1745781d6f
				L_0008: ldstr ""
				L_000d: stloc.0 
				L_000e: ldarg.0 
				L_000f: callvirt System.String::System.CharEnumerator GetEnumerator()
				L_0014: stloc.2 
				L_0015: br.s L_006c
				L_0017: ldloc.2 
				L_0018: callvirt System.CharEnumerator::Char get_Current()
				L_001d: stloc.1 
				L_001e: ldloc.1 
				L_001f: stloc.3 
				L_0020: ldloc.3 
				L_0021: ldc.i4.s 43
				L_0023: beq.s L_004f
				L_0025: ldloc.3 
				L_0026: ldc.i4.s 47
				L_0028: beq.s L_003f
				L_002a: ldloc.3 
				L_002b: ldc.i4.s 61
				L_002d: bne.un.s L_005f
				L_002f: ldloc.0 
				L_0030: ldc.i4.s 90
				L_0032: box System.Char
				L_0037: call System.String::System.String Concat(System.Object, System.Object)
				L_003c: stloc.0 
				L_003d: br.s L_006c
				L_003f: ldloc.0 
				L_0040: ldc.i4.s 70
				L_0042: box System.Char
				L_0047: call System.String::System.String Concat(System.Object, System.Object)
				L_004c: stloc.0 
				L_004d: br.s L_006c
				L_004f: ldloc.0 
				L_0050: ldc.i4.s 74
				L_0052: box System.Char
				L_0057: call System.String::System.String Concat(System.Object, System.Object)
				L_005c: stloc.0 
				L_005d: br.s L_006c
				L_005f: ldloc.0 
				L_0060: ldloc.1 
				L_0061: box System.Char
				L_0066: call System.String::System.String Concat(System.Object, System.Object)
				L_006b: stloc.0 
				L_006c: ldloc.2 
				L_006d: callvirt System.CharEnumerator::Boolean MoveNext()
				L_0072: brtrue.s L_0017
				L_0074: ldloc.0 
				L_0075: ret 
			*/
			
			
			{
				char char1;
				char char2;
				xf6987a1745781d6f = xf6987a1745781d6f.ToUpper ();
				string string1 = "";
				CharEnumerator charEnumerator1 = xf6987a1745781d6f.GetEnumerator ();
				while (charEnumerator1.MoveNext ())
				{
					char1 = charEnumerator1.Current;
					char2 = char1;
					if (char2 == '+')
					{
						string1 = (string1 + 'J'.ToString ());
						continue;
					}
					if (char2 == '\u002F')
					{
						string1 = (string1 + 'F'.ToString ());
						continue;
					}
					if (char2 != '=')
					{
						string1 = (string1 + char1.ToString ());
						continue;
					}
					string1 = (string1 + 'Z'.ToString ());
				}
				return string1;
			}
			
			public static void x0f9835bacc0cb58b (Graphics x4b101060f4767186, int x08db3aeabb253cb1, int x1e218ceaee1bb583, bool x2fef7d841879a711)
			
			/*
				// Code Size: 183 Bytes
				.maxstack 5
				.locals (System.Drawing.Pen V_0, 
         System.Drawing.Brush V_1, 
         System.Drawing.Point[] V_2)
				L_0000: ldc.i4.3 
				L_0001: newarr System.Drawing.Point
				L_0006: stloc.2 
				L_0007: ldarg.3 
				L_0008: brtrue.s L_006a
				L_000a: call System.Drawing.Pens::System.Drawing.Pen get_White()
				L_000f: stloc.0 
				L_0010: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_0015: stloc.1 
				L_0016: ldloc.2 
				L_0017: ldc.i4.0 
				L_0018: ldelema System.Drawing.Point
				L_001d: ldarg.1 
				L_001e: ldc.i4.1 
				L_001f: add 
				L_0020: ldarg.2 
				L_0021: ldc.i4.1 
				L_0022: add 
				L_0023: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0028: ldloc.2 
				L_0029: ldc.i4.1 
				L_002a: ldelema System.Drawing.Point
				L_002f: ldarg.1 
				L_0030: ldc.i4.7 
				L_0031: add 
				L_0032: ldarg.2 
				L_0033: ldc.i4.1 
				L_0034: add 
				L_0035: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_003a: ldloc.2 
				L_003b: ldc.i4.2 
				L_003c: ldelema System.Drawing.Point
				L_0041: ldarg.1 
				L_0042: ldc.i4.4 
				L_0043: add 
				L_0044: ldarg.2 
				L_0045: ldc.i4.2 
				L_0046: sub 
				L_0047: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_004c: ldarg.0 
				L_004d: ldloc.0 
				L_004e: ldloc.2 
				L_004f: callvirt System.Drawing.Graphics::Void DrawPolygon(System.Drawing.Pen, System.Drawing.Point[])
				L_0054: ldarg.0 
				L_0055: ldloc.1 
				L_0056: ldloc.2 
				L_0057: callvirt System.Drawing.Graphics::Void FillPolygon(System.Drawing.Brush, System.Drawing.Point[])
				L_005c: call System.Drawing.Pens::System.Drawing.Pen get_Gray()
				L_0061: stloc.0 
				L_0062: call System.Drawing.Brushes::System.Drawing.Brush get_Gray()
				L_0067: stloc.1 
				L_0068: br.s L_0076
				L_006a: call System.Drawing.Brushes::System.Drawing.Brush get_Black()
				L_006f: stloc.1 
				L_0070: call System.Drawing.Pens::System.Drawing.Pen get_Black()
				L_0075: stloc.0 
				L_0076: ldloc.2 
				L_0077: ldc.i4.0 
				L_0078: ldelema System.Drawing.Point
				L_007d: ldarg.1 
				L_007e: ldarg.2 
				L_007f: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0084: ldloc.2 
				L_0085: ldc.i4.1 
				L_0086: ldelema System.Drawing.Point
				L_008b: ldarg.1 
				L_008c: ldc.i4.6 
				L_008d: add 
				L_008e: ldarg.2 
				L_008f: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0094: ldloc.2 
				L_0095: ldc.i4.2 
				L_0096: ldelema System.Drawing.Point
				L_009b: ldarg.1 
				L_009c: ldc.i4.3 
				L_009d: add 
				L_009e: ldarg.2 
				L_009f: ldc.i4.3 
				L_00a0: sub 
				L_00a1: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_00a6: ldarg.0 
				L_00a7: ldloc.0 
				L_00a8: ldloc.2 
				L_00a9: callvirt System.Drawing.Graphics::Void DrawPolygon(System.Drawing.Pen, System.Drawing.Point[])
				L_00ae: ldarg.0 
				L_00af: ldloc.1 
				L_00b0: ldloc.2 
				L_00b1: callvirt System.Drawing.Graphics::Void FillPolygon(System.Drawing.Brush, System.Drawing.Point[])
				L_00b6: ret 
			*/
			
			
			{
				Pen pen1;
				Brush brush1;
				Point[] pointArray1 = new Point[3];
				if (! x2fef7d841879a711)
				{
					pen1 = Pens.White;
					brush1 = Brushes.White;
					pointArray1[0] = new Point (((int) (x08db3aeabb253cb1 + 1)), ((int) (x1e218ceaee1bb583 + 1)));
					pointArray1[1] = new Point (((int) (x08db3aeabb253cb1 + 7)), ((int) (x1e218ceaee1bb583 + 1)));
					pointArray1[2] = new Point (((int) (x08db3aeabb253cb1 + 4)), ((int) (x1e218ceaee1bb583 - 2)));
					x4b101060f4767186.DrawPolygon (pen1, pointArray1);
					x4b101060f4767186.FillPolygon (brush1, pointArray1);
					pen1 = Pens.Gray;
					brush1 = Brushes.Gray;
				}
				else
				{
					brush1 = Brushes.Black;
					pen1 = Pens.Black;
				}
				pointArray1[0] = new Point (x08db3aeabb253cb1, x1e218ceaee1bb583);
				pointArray1[1] = new Point (((int) (x08db3aeabb253cb1 + 6)), x1e218ceaee1bb583);
				pointArray1[2] = new Point (((int) (x08db3aeabb253cb1 + 3)), ((int) (x1e218ceaee1bb583 - 3)));
				x4b101060f4767186.DrawPolygon (pen1, pointArray1);
				x4b101060f4767186.FillPolygon (brush1, pointArray1);
			}
			
			public static void x17c438d9756b08c0 (Control x43bec302f92080b9)
			
			/*
				// Code Size: 94 Bytes
				.maxstack 3
				.locals (System.Windows.Forms.Button V_0, 
         System.Windows.Forms.Form V_1)
				L_0000: ldarg.0 
				L_0001: brfalse.s L_005d
				L_0003: ldarg.0 
				L_0004: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0009: callvirt System.Windows.Forms.Layout.ArrangedElementCollection::Int32 get_Count()
				L_000e: ldc.i4.0 
				L_000f: ble.s L_005d
				L_0011: ldnull 
				L_0012: stloc.0 
				L_0013: ldarg.0 
				L_0014: callvirt System.Windows.Forms.Control::System.Windows.Forms.Form FindForm()
				L_0019: stloc.1 
				L_001a: ldloc.1 
				L_001b: brfalse.s L_003d
				L_001d: newobj System.Windows.Forms.Button::Void .ctor()
				L_0022: stloc.0 
				L_0023: ldloc.0 
				L_0024: ldc.i4.0 
				L_0025: callvirt System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_002a: ldloc.1 
				L_002b: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0030: ldloc.0 
				L_0031: callvirt System.Windows.Forms.Control+ControlCollection::Void Add(System.Windows.Forms.Control)
				L_0036: ldloc.1 
				L_0037: ldloc.0 
				L_0038: callvirt System.Windows.Forms.ContainerControl::Void set_ActiveControl(System.Windows.Forms.Control)
				L_003d: ldarg.0 
				L_003e: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0043: callvirt System.Windows.Forms.Control+ControlCollection::Void Clear()
				L_0048: ldloc.1 
				L_0049: brfalse.s L_005d
				L_004b: ldloc.0 
				L_004c: callvirt System.ComponentModel.Component::Void Dispose()
				L_0051: ldloc.1 
				L_0052: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0057: ldloc.0 
				L_0058: callvirt System.Windows.Forms.Control+ControlCollection::Void Remove(System.Windows.Forms.Control)
				L_005d: ret 
			*/
			
			
			{
				if ((x43bec302f92080b9 == null) || (x43bec302f92080b9.Controls.Count <= 0))
				{
					return;
				}
				Button button1 = ((Button) null);
				Form form1 = x43bec302f92080b9.FindForm ();
				if (form1 != null)
				{
					button1 = new Button ();
					button1.Visible = false;
					form1.Controls.Add (((Control) button1));
					form1.ActiveControl = ((Control) button1);
				}
				x43bec302f92080b9.Controls.Clear ();
				if (form1 != null)
				{
					button1.Dispose ();
					form1.Controls.Remove (((Control) button1));
				}
			}
			
			public static Rectangle x323b3762dd22c667 (ContentAlignment x7717e14a55110734, RightToLeft xcb35b7c43d7acd61, Rectangle xb5f74d6870d87190, int x9b0739496f8b5475, int x4d5aabc7a55b12ba, int x6bc9c537127c0a56, int x38f159753ca502dc)
			
			/*
				// Code Size: 638 Bytes
				.maxstack 6
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Drawing.ContentAlignment V_2)
				L_0000: ldarg.s x6bc9c537127c0a56
				L_0002: stloc.0 
				L_0003: ldarg.s x38f159753ca502dc
				L_0005: stloc.1 
				L_0006: ldarg.0 
				L_0007: stloc.2 
				L_0008: ldloc.2 
				L_0009: ldc.i4.s 32
				L_000b: bgt.s L_003a
				L_000d: ldloc.2 
				L_000e: ldc.i4.1 
				L_000f: sub 
				L_0010: switch (L_0075, L_00f1, L_025e, L_00b3)
				L_0025: ldloc.2 
				L_0026: ldc.i4.s 16
				L_0028: beq L_010e
				L_002d: ldloc.2 
				L_002e: ldc.i4.s 32
				L_0030: beq L_0196
				L_0035: br L_025e
				L_003a: ldloc.2 
				L_003b: ldc.i4 256
				L_0040: bgt.s L_005a
				L_0042: ldloc.2 
				L_0043: ldc.i4.s 64
				L_0045: beq L_0152
				L_004a: ldloc.2 
				L_004b: ldc.i4 256
				L_0050: beq L_01b6
				L_0055: br L_025e
				L_005a: ldloc.2 
				L_005b: ldc.i4 512
				L_0060: beq L_023e
				L_0065: ldloc.2 
				L_0066: ldc.i4 1024
				L_006b: beq L_01fa
				L_0070: br L_025e
				L_0075: ldarg.1 
				L_0076: ldc.i4.1 
				L_0077: and 
				L_0078: ldc.i4.1 
				L_0079: bne.un.s L_0098
				L_007b: ldarga.s xb5f74d6870d87190
				L_007d: call System.Drawing.Rectangle::Int32 get_Right()
				L_0082: ldloc.0 
				L_0083: sub 
				L_0084: ldarg.3 
				L_0085: sub 
				L_0086: ldarga.s xb5f74d6870d87190
				L_0088: call System.Drawing.Rectangle::Int32 get_Top()
				L_008d: ldloc.1 
				L_008e: add 
				L_008f: ldarg.3 
				L_0090: ldarg.s x4d5aabc7a55b12ba
				L_0092: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0097: ret 
				L_0098: ldarga.s xb5f74d6870d87190
				L_009a: call System.Drawing.Rectangle::Int32 get_Left()
				L_009f: ldloc.0 
				L_00a0: add 
				L_00a1: ldarga.s xb5f74d6870d87190
				L_00a3: call System.Drawing.Rectangle::Int32 get_Top()
				L_00a8: ldloc.1 
				L_00a9: add 
				L_00aa: ldarg.3 
				L_00ab: ldarg.s x4d5aabc7a55b12ba
				L_00ad: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00b2: ret 
				L_00b3: ldarg.1 
				L_00b4: ldc.i4.1 
				L_00b5: and 
				L_00b6: ldc.i4.1 
				L_00b7: bne.un.s L_00d4
				L_00b9: ldarga.s xb5f74d6870d87190
				L_00bb: call System.Drawing.Rectangle::Int32 get_Left()
				L_00c0: ldloc.0 
				L_00c1: add 
				L_00c2: ldarga.s xb5f74d6870d87190
				L_00c4: call System.Drawing.Rectangle::Int32 get_Top()
				L_00c9: ldloc.1 
				L_00ca: add 
				L_00cb: ldarg.3 
				L_00cc: ldarg.s x4d5aabc7a55b12ba
				L_00ce: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00d3: ret 
				L_00d4: ldarga.s xb5f74d6870d87190
				L_00d6: call System.Drawing.Rectangle::Int32 get_Right()
				L_00db: ldloc.0 
				L_00dc: sub 
				L_00dd: ldarg.3 
				L_00de: sub 
				L_00df: ldarga.s xb5f74d6870d87190
				L_00e1: call System.Drawing.Rectangle::Int32 get_Top()
				L_00e6: ldloc.1 
				L_00e7: add 
				L_00e8: ldarg.3 
				L_00e9: ldarg.s x4d5aabc7a55b12ba
				L_00eb: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00f0: ret 
				L_00f1: ldarga.s xb5f74d6870d87190
				L_00f3: call System.Drawing.Rectangle::Int32 get_Width()
				L_00f8: ldarg.3 
				L_00f9: sub 
				L_00fa: ldc.i4.2 
				L_00fb: div 
				L_00fc: ldarga.s xb5f74d6870d87190
				L_00fe: call System.Drawing.Rectangle::Int32 get_Top()
				L_0103: ldloc.1 
				L_0104: add 
				L_0105: ldarg.3 
				L_0106: ldarg.s x4d5aabc7a55b12ba
				L_0108: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_010d: ret 
				L_010e: ldarg.1 
				L_010f: ldc.i4.1 
				L_0110: and 
				L_0111: ldc.i4.1 
				L_0112: bne.un.s L_0134
				L_0114: ldarga.s xb5f74d6870d87190
				L_0116: call System.Drawing.Rectangle::Int32 get_Right()
				L_011b: ldloc.0 
				L_011c: sub 
				L_011d: ldarg.3 
				L_011e: sub 
				L_011f: ldarga.s xb5f74d6870d87190
				L_0121: call System.Drawing.Rectangle::Int32 get_Height()
				L_0126: ldarg.s x4d5aabc7a55b12ba
				L_0128: sub 
				L_0129: ldc.i4.2 
				L_012a: div 
				L_012b: ldarg.3 
				L_012c: ldarg.s x4d5aabc7a55b12ba
				L_012e: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0133: ret 
				L_0134: ldarga.s xb5f74d6870d87190
				L_0136: call System.Drawing.Rectangle::Int32 get_Left()
				L_013b: ldloc.0 
				L_013c: add 
				L_013d: ldarga.s xb5f74d6870d87190
				L_013f: call System.Drawing.Rectangle::Int32 get_Height()
				L_0144: ldarg.s x4d5aabc7a55b12ba
				L_0146: sub 
				L_0147: ldc.i4.2 
				L_0148: div 
				L_0149: ldarg.3 
				L_014a: ldarg.s x4d5aabc7a55b12ba
				L_014c: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0151: ret 
				L_0152: ldarg.1 
				L_0153: ldc.i4.1 
				L_0154: and 
				L_0155: ldc.i4.1 
				L_0156: bne.un.s L_0176
				L_0158: ldarga.s xb5f74d6870d87190
				L_015a: call System.Drawing.Rectangle::Int32 get_Left()
				L_015f: ldloc.0 
				L_0160: add 
				L_0161: ldarga.s xb5f74d6870d87190
				L_0163: call System.Drawing.Rectangle::Int32 get_Height()
				L_0168: ldarg.s x4d5aabc7a55b12ba
				L_016a: sub 
				L_016b: ldc.i4.2 
				L_016c: div 
				L_016d: ldarg.3 
				L_016e: ldarg.s x4d5aabc7a55b12ba
				L_0170: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0175: ret 
				L_0176: ldarga.s xb5f74d6870d87190
				L_0178: call System.Drawing.Rectangle::Int32 get_Right()
				L_017d: ldloc.0 
				L_017e: sub 
				L_017f: ldarg.3 
				L_0180: sub 
				L_0181: ldarga.s xb5f74d6870d87190
				L_0183: call System.Drawing.Rectangle::Int32 get_Height()
				L_0188: ldarg.s x4d5aabc7a55b12ba
				L_018a: sub 
				L_018b: ldc.i4.2 
				L_018c: div 
				L_018d: ldarg.3 
				L_018e: ldarg.s x4d5aabc7a55b12ba
				L_0190: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0195: ret 
				L_0196: ldarga.s xb5f74d6870d87190
				L_0198: call System.Drawing.Rectangle::Int32 get_Width()
				L_019d: ldarg.3 
				L_019e: sub 
				L_019f: ldc.i4.2 
				L_01a0: div 
				L_01a1: ldarga.s xb5f74d6870d87190
				L_01a3: call System.Drawing.Rectangle::Int32 get_Height()
				L_01a8: ldarg.s x4d5aabc7a55b12ba
				L_01aa: sub 
				L_01ab: ldc.i4.2 
				L_01ac: div 
				L_01ad: ldarg.3 
				L_01ae: ldarg.s x4d5aabc7a55b12ba
				L_01b0: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01b5: ret 
				L_01b6: ldarg.1 
				L_01b7: ldc.i4.1 
				L_01b8: and 
				L_01b9: ldc.i4.1 
				L_01ba: bne.un.s L_01dc
				L_01bc: ldarga.s xb5f74d6870d87190
				L_01be: call System.Drawing.Rectangle::Int32 get_Right()
				L_01c3: ldloc.0 
				L_01c4: sub 
				L_01c5: ldarg.3 
				L_01c6: sub 
				L_01c7: ldarga.s xb5f74d6870d87190
				L_01c9: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_01ce: ldloc.1 
				L_01cf: sub 
				L_01d0: ldarg.s x4d5aabc7a55b12ba
				L_01d2: sub 
				L_01d3: ldarg.3 
				L_01d4: ldarg.s x4d5aabc7a55b12ba
				L_01d6: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01db: ret 
				L_01dc: ldarga.s xb5f74d6870d87190
				L_01de: call System.Drawing.Rectangle::Int32 get_Left()
				L_01e3: ldloc.0 
				L_01e4: add 
				L_01e5: ldarga.s xb5f74d6870d87190
				L_01e7: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_01ec: ldloc.1 
				L_01ed: sub 
				L_01ee: ldarg.s x4d5aabc7a55b12ba
				L_01f0: sub 
				L_01f1: ldarg.3 
				L_01f2: ldarg.s x4d5aabc7a55b12ba
				L_01f4: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01f9: ret 
				L_01fa: ldarg.1 
				L_01fb: ldc.i4.1 
				L_01fc: and 
				L_01fd: ldc.i4.1 
				L_01fe: bne.un.s L_021e
				L_0200: ldarga.s xb5f74d6870d87190
				L_0202: call System.Drawing.Rectangle::Int32 get_Left()
				L_0207: ldloc.0 
				L_0208: add 
				L_0209: ldarga.s xb5f74d6870d87190
				L_020b: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0210: ldloc.1 
				L_0211: sub 
				L_0212: ldarg.s x4d5aabc7a55b12ba
				L_0214: sub 
				L_0215: ldarg.3 
				L_0216: ldarg.s x4d5aabc7a55b12ba
				L_0218: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_021d: ret 
				L_021e: ldarga.s xb5f74d6870d87190
				L_0220: call System.Drawing.Rectangle::Int32 get_Right()
				L_0225: ldloc.0 
				L_0226: sub 
				L_0227: ldarg.3 
				L_0228: sub 
				L_0229: ldarga.s xb5f74d6870d87190
				L_022b: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0230: ldloc.1 
				L_0231: sub 
				L_0232: ldarg.s x4d5aabc7a55b12ba
				L_0234: sub 
				L_0235: ldarg.3 
				L_0236: ldarg.s x4d5aabc7a55b12ba
				L_0238: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_023d: ret 
				L_023e: ldarga.s xb5f74d6870d87190
				L_0240: call System.Drawing.Rectangle::Int32 get_Width()
				L_0245: ldarg.3 
				L_0246: sub 
				L_0247: ldc.i4.2 
				L_0248: div 
				L_0249: ldarga.s xb5f74d6870d87190
				L_024b: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0250: ldloc.1 
				L_0251: sub 
				L_0252: ldarg.s x4d5aabc7a55b12ba
				L_0254: sub 
				L_0255: ldarg.3 
				L_0256: ldarg.s x4d5aabc7a55b12ba
				L_0258: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_025d: ret 
				L_025e: ldarga.s xb5f74d6870d87190
				L_0260: call System.Drawing.Rectangle::Int32 get_Width()
				L_0265: ldarg.3 
				L_0266: sub 
				L_0267: ldc.i4.2 
				L_0268: div 
				L_0269: ldarga.s xb5f74d6870d87190
				L_026b: call System.Drawing.Rectangle::Int32 get_Height()
				L_0270: ldarg.s x4d5aabc7a55b12ba
				L_0272: sub 
				L_0273: ldc.i4.2 
				L_0274: div 
				L_0275: ldarg.3 
				L_0276: ldarg.s x4d5aabc7a55b12ba
				L_0278: newobj System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_027d: ret 
			*/
			
			
			{
				int i1 = x6bc9c537127c0a56;
				int i2 = x38f159753ca502dc;
				ContentAlignment contentAlignment1 = x7717e14a55110734;
				if (contentAlignment1 <= ContentAlignment.MiddleCenter)
				{
					switch (contentAlignment1)
					{
						case ContentAlignment.TopLeft:
						
						{
								if ((xcb35b7c43d7acd61 & RightToLeft.Yes) != RightToLeft.Yes)
								{
									return new Rectangle (((int) (xb5f74d6870d87190.Left + i1)), ((int) (xb5f74d6870d87190.Top + i2)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
								}
								else
								{
									return new Rectangle (((int) ((xb5f74d6870d87190.Right - i1) - x9b0739496f8b5475)), ((int) (xb5f74d6870d87190.Top + i2)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
								}
						}
						case ContentAlignment.TopCenter:
						
						{
								return new Rectangle (((int) ((xb5f74d6870d87190.Width - x9b0739496f8b5475) / 2)), ((int) (xb5f74d6870d87190.Top + i2)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
						}
						case  ((ContentAlignment) 3):
						
						{
								return new Rectangle (((int) ((xb5f74d6870d87190.Width - x9b0739496f8b5475) / 2)), ((int) ((xb5f74d6870d87190.Height - x4d5aabc7a55b12ba) / 2)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
						}
						case ContentAlignment.TopRight:
						
						{
								if ((xcb35b7c43d7acd61 & RightToLeft.Yes) != RightToLeft.Yes)
								{
									return new Rectangle (((int) ((xb5f74d6870d87190.Right - i1) - x9b0739496f8b5475)), ((int) (xb5f74d6870d87190.Top + i2)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
								}
								else
								{
									return new Rectangle (((int) (xb5f74d6870d87190.Left + i1)), ((int) (xb5f74d6870d87190.Top + i2)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
								}
						}
					}
					if (contentAlignment1 == ContentAlignment.MiddleLeft)
					{
						if ((xcb35b7c43d7acd61 & RightToLeft.Yes) != RightToLeft.Yes)
						{
							return new Rectangle (((int) (xb5f74d6870d87190.Left + i1)), ((int) ((xb5f74d6870d87190.Height - x4d5aabc7a55b12ba) / 2)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
						}
						else
						{
							return new Rectangle (((int) ((xb5f74d6870d87190.Right - i1) - x9b0739496f8b5475)), ((int) ((xb5f74d6870d87190.Height - x4d5aabc7a55b12ba) / 2)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
						}
					}
					if (contentAlignment1 == ContentAlignment.MiddleCenter)
					{
						return new Rectangle (((int) ((xb5f74d6870d87190.Width - x9b0739496f8b5475) / 2)), ((int) ((xb5f74d6870d87190.Height - x4d5aabc7a55b12ba) / 2)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
					}
					else
					{
						return new Rectangle (((int) ((xb5f74d6870d87190.Width - x9b0739496f8b5475) / 2)), ((int) ((xb5f74d6870d87190.Height - x4d5aabc7a55b12ba) / 2)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
					}
				}
				if (contentAlignment1 <= ContentAlignment.BottomLeft)
				{
					if (contentAlignment1 == ContentAlignment.MiddleRight)
					{
						if ((xcb35b7c43d7acd61 & RightToLeft.Yes) != RightToLeft.Yes)
						{
							return new Rectangle (((int) ((xb5f74d6870d87190.Right - i1) - x9b0739496f8b5475)), ((int) ((xb5f74d6870d87190.Height - x4d5aabc7a55b12ba) / 2)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
						}
						else
						{
							return new Rectangle (((int) (xb5f74d6870d87190.Left + i1)), ((int) ((xb5f74d6870d87190.Height - x4d5aabc7a55b12ba) / 2)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
						}
					}
					if (contentAlignment1 != ContentAlignment.BottomLeft)
					{
						return new Rectangle (((int) ((xb5f74d6870d87190.Width - x9b0739496f8b5475) / 2)), ((int) ((xb5f74d6870d87190.Height - x4d5aabc7a55b12ba) / 2)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
					}
					else if ((xcb35b7c43d7acd61 & RightToLeft.Yes) != RightToLeft.Yes)
					{
						return new Rectangle (((int) (xb5f74d6870d87190.Left + i1)), ((int) ((xb5f74d6870d87190.Bottom - i2) - x4d5aabc7a55b12ba)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
					}
					else
					{
						return new Rectangle (((int) ((xb5f74d6870d87190.Right - i1) - x9b0739496f8b5475)), ((int) ((xb5f74d6870d87190.Bottom - i2) - x4d5aabc7a55b12ba)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
					}
				}
				if (contentAlignment1 == ContentAlignment.BottomCenter)
				{
					return new Rectangle (((int) ((xb5f74d6870d87190.Width - x9b0739496f8b5475) / 2)), ((int) ((xb5f74d6870d87190.Bottom - i2) - x4d5aabc7a55b12ba)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
				}
				else if (contentAlignment1 != ContentAlignment.BottomRight)
				{
					return new Rectangle (((int) ((xb5f74d6870d87190.Width - x9b0739496f8b5475) / 2)), ((int) ((xb5f74d6870d87190.Height - x4d5aabc7a55b12ba) / 2)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
				}
				else if ((xcb35b7c43d7acd61 & RightToLeft.Yes) != RightToLeft.Yes)
				{
					return new Rectangle (((int) ((xb5f74d6870d87190.Right - i1) - x9b0739496f8b5475)), ((int) ((xb5f74d6870d87190.Bottom - i2) - x4d5aabc7a55b12ba)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
				}
				else
				{
					return new Rectangle (((int) (xb5f74d6870d87190.Left + i1)), ((int) ((xb5f74d6870d87190.Bottom - i2) - x4d5aabc7a55b12ba)), x9b0739496f8b5475, x4d5aabc7a55b12ba);
				}
			}
			
			public static void x323b3762dd22c667 (ContentAlignment x7717e14a55110734, Rectangle xb5f74d6870d87190, RightToLeft xcb35b7c43d7acd61, out Rectangle x26545669838eb36e, out StringFormat x5786461d089b10a0)
			
			/*
				// Code Size: 336 Bytes
				.maxstack 7
				.locals (System.Drawing.ContentAlignment V_0)
				L_0000: ldarg.s x5786461d089b10a0
				L_0002: newobj System.Drawing.StringFormat::Void .ctor()
				L_0007: stind.ref 
				L_0008: ldarg.2 
				L_0009: ldc.i4.1 
				L_000a: bne.un.s L_0015
				L_000c: ldarg.s x5786461d089b10a0
				L_000e: ldind.ref 
				L_000f: ldc.i4.1 
				L_0010: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_0015: ldarg.s x5786461d089b10a0
				L_0017: ldind.ref 
				L_0018: ldc.i4.1 
				L_0019: callvirt System.Drawing.StringFormat::Void set_HotkeyPrefix(System.Drawing.Text.HotkeyPrefix)
				L_001e: ldarg.3 
				L_001f: ldarga.s xb5f74d6870d87190
				L_0021: call System.Drawing.Rectangle::Int32 get_Left()
				L_0026: ldarga.s xb5f74d6870d87190
				L_0028: call System.Drawing.Rectangle::Int32 get_Top()
				L_002d: ldarga.s xb5f74d6870d87190
				L_002f: call System.Drawing.Rectangle::Int32 get_Right()
				L_0034: ldarga.s xb5f74d6870d87190
				L_0036: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_003b: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0040: stobj System.Drawing.Rectangle
				L_0045: ldarg.0 
				L_0046: stloc.0 
				L_0047: ldloc.0 
				L_0048: ldc.i4.s 32
				L_004a: bgt.s L_0076
				L_004c: ldloc.0 
				L_004d: ldc.i4.1 
				L_004e: sub 
				L_004f: switch (L_00a5, L_00de, L_00f1, L_0117)
				L_0064: ldloc.0 
				L_0065: ldc.i4.s 16
				L_0067: beq.s L_00b8
				L_0069: ldloc.0 
				L_006a: ldc.i4.s 32
				L_006c: beq L_00f1
				L_0071: br L_00f1
				L_0076: ldloc.0 
				L_0077: ldc.i4 256
				L_007c: bgt.s L_0090
				L_007e: ldloc.0 
				L_007f: ldc.i4.s 64
				L_0081: beq L_012a
				L_0086: ldloc.0 
				L_0087: ldc.i4 256
				L_008c: beq.s L_00cb
				L_008e: br.s L_00f1
				L_0090: ldloc.0 
				L_0091: ldc.i4 512
				L_0096: beq.s L_0104
				L_0098: ldloc.0 
				L_0099: ldc.i4 1024
				L_009e: beq L_013d
				L_00a3: br.s L_00f1
				L_00a5: ldarg.s x5786461d089b10a0
				L_00a7: ldind.ref 
				L_00a8: ldc.i4.0 
				L_00a9: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00ae: ldarg.s x5786461d089b10a0
				L_00b0: ldind.ref 
				L_00b1: ldc.i4.0 
				L_00b2: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_00b7: ret 
				L_00b8: ldarg.s x5786461d089b10a0
				L_00ba: ldind.ref 
				L_00bb: ldc.i4.0 
				L_00bc: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00c1: ldarg.s x5786461d089b10a0
				L_00c3: ldind.ref 
				L_00c4: ldc.i4.1 
				L_00c5: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_00ca: ret 
				L_00cb: ldarg.s x5786461d089b10a0
				L_00cd: ldind.ref 
				L_00ce: ldc.i4.0 
				L_00cf: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00d4: ldarg.s x5786461d089b10a0
				L_00d6: ldind.ref 
				L_00d7: ldc.i4.2 
				L_00d8: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_00dd: ret 
				L_00de: ldarg.s x5786461d089b10a0
				L_00e0: ldind.ref 
				L_00e1: ldc.i4.1 
				L_00e2: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00e7: ldarg.s x5786461d089b10a0
				L_00e9: ldind.ref 
				L_00ea: ldc.i4.0 
				L_00eb: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_00f0: ret 
				L_00f1: ldarg.s x5786461d089b10a0
				L_00f3: ldind.ref 
				L_00f4: ldc.i4.1 
				L_00f5: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00fa: ldarg.s x5786461d089b10a0
				L_00fc: ldind.ref 
				L_00fd: ldc.i4.1 
				L_00fe: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_0103: ret 
				L_0104: ldarg.s x5786461d089b10a0
				L_0106: ldind.ref 
				L_0107: ldc.i4.1 
				L_0108: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_010d: ldarg.s x5786461d089b10a0
				L_010f: ldind.ref 
				L_0110: ldc.i4.2 
				L_0111: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_0116: ret 
				L_0117: ldarg.s x5786461d089b10a0
				L_0119: ldind.ref 
				L_011a: ldc.i4.2 
				L_011b: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_0120: ldarg.s x5786461d089b10a0
				L_0122: ldind.ref 
				L_0123: ldc.i4.0 
				L_0124: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_0129: ret 
				L_012a: ldarg.s x5786461d089b10a0
				L_012c: ldind.ref 
				L_012d: ldc.i4.2 
				L_012e: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_0133: ldarg.s x5786461d089b10a0
				L_0135: ldind.ref 
				L_0136: ldc.i4.1 
				L_0137: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_013c: ret 
				L_013d: ldarg.s x5786461d089b10a0
				L_013f: ldind.ref 
				L_0140: ldc.i4.2 
				L_0141: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_0146: ldarg.s x5786461d089b10a0
				L_0148: ldind.ref 
				L_0149: ldc.i4.2 
				L_014a: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_014f: ret 
			*/
			
			
			{
				ContentAlignment contentAlignment1;
				x5786461d089b10a0 = new StringFormat ();
				if (xcb35b7c43d7acd61 == RightToLeft.Yes)
				{
					x5786461d089b10a0.FormatFlags = StringFormatFlags.DirectionRightToLeft;
				}
				x5786461d089b10a0.HotkeyPrefix = HotkeyPrefix.Show;
				x26545669838eb36e = Rectangle.FromLTRB (xb5f74d6870d87190.Left, xb5f74d6870d87190.Top, xb5f74d6870d87190.Right, xb5f74d6870d87190.Bottom);
				contentAlignment1 = x7717e14a55110734;
				if (contentAlignment1 <= ContentAlignment.MiddleCenter)
				{
					switch (contentAlignment1)
					{
						case ContentAlignment.TopLeft:
						
						{
								x5786461d089b10a0.Alignment = StringAlignment.Near;
								x5786461d089b10a0.LineAlignment = StringAlignment.Near;
								return;
						}
						case ContentAlignment.TopCenter:
						
						{
								x5786461d089b10a0.Alignment = StringAlignment.Center;
								x5786461d089b10a0.LineAlignment = StringAlignment.Near;
								return;
						}
						case  ((ContentAlignment) 3):
						
						{
								goto L_00F1;
						}
						case ContentAlignment.TopRight:
						
						{
								x5786461d089b10a0.Alignment = StringAlignment.Far;
								x5786461d089b10a0.LineAlignment = StringAlignment.Near;
								return;
						}
					}
					if (contentAlignment1 == ContentAlignment.MiddleLeft)
					{
						x5786461d089b10a0.Alignment = StringAlignment.Near;
						x5786461d089b10a0.LineAlignment = StringAlignment.Center;
						return;
					}
				}
				else if (contentAlignment1 <= ContentAlignment.BottomLeft)
				{
					if (contentAlignment1 == ContentAlignment.MiddleRight)
					{
						x5786461d089b10a0.Alignment = StringAlignment.Far;
						x5786461d089b10a0.LineAlignment = StringAlignment.Center;
						return;
					}
					else if (contentAlignment1 == ContentAlignment.BottomLeft)
					{
						x5786461d089b10a0.Alignment = StringAlignment.Near;
						x5786461d089b10a0.LineAlignment = StringAlignment.Far;
						return;
					}
				}
				else if (contentAlignment1 == ContentAlignment.BottomCenter)
				{
					x5786461d089b10a0.Alignment = StringAlignment.Center;
					x5786461d089b10a0.LineAlignment = StringAlignment.Far;
					return;
				}
				else if (contentAlignment1 == ContentAlignment.BottomRight)
				{
					x5786461d089b10a0.Alignment = StringAlignment.Far;
					x5786461d089b10a0.LineAlignment = StringAlignment.Far;
					return;
				}
				
			L_00F1:
				
				{
				}
				x5786461d089b10a0.Alignment = StringAlignment.Center;
				x5786461d089b10a0.LineAlignment = StringAlignment.Center;
			}
			
			public static Rectangle x323b3762dd22c667 (ContentAlignment x7717e14a55110734, RightToLeft xcb35b7c43d7acd61, Rectangle xb5f74d6870d87190, int x9b0739496f8b5475, int x4d5aabc7a55b12ba)
			
			/*
				// Code Size: 13 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: ldarg.3 
				L_0004: ldarg.s x4d5aabc7a55b12ba
				L_0006: ldc.i4.0 
				L_0007: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Rectangle x323b3762dd22c667(System.Drawing.ContentAlignment, System.Windows.Forms.RightToLeft, System.Drawing.Rectangle, Int32, Int32, Int32)
				L_000c: ret 
			*/
			
			
			{
				return x448fd9ab43628c71.x323b3762dd22c667 (x7717e14a55110734, xcb35b7c43d7acd61, xb5f74d6870d87190, x9b0739496f8b5475, x4d5aabc7a55b12ba, 0);
			}
			
			public static Rectangle x323b3762dd22c667 (ContentAlignment x7717e14a55110734, RightToLeft xcb35b7c43d7acd61, Rectangle xb5f74d6870d87190, int x9b0739496f8b5475, int x4d5aabc7a55b12ba, int xe660adda6738ac8a)
			
			/*
				// Code Size: 16 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: ldarg.3 
				L_0004: ldarg.s x4d5aabc7a55b12ba
				L_0006: ldarg.s xe660adda6738ac8a
				L_0008: ldarg.s xe660adda6738ac8a
				L_000a: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Rectangle x323b3762dd22c667(System.Drawing.ContentAlignment, System.Windows.Forms.RightToLeft, System.Drawing.Rectangle, Int32, Int32, Int32, Int32)
				L_000f: ret 
			*/
			
			
			{
				return x448fd9ab43628c71.x323b3762dd22c667 (x7717e14a55110734, xcb35b7c43d7acd61, xb5f74d6870d87190, x9b0739496f8b5475, x4d5aabc7a55b12ba, xe660adda6738ac8a, xe660adda6738ac8a);
			}
			
			public static Font x357f53120b135506 ()
			
			/*
				// Code Size: 12 Bytes
				.maxstack 9
				L_0000: call System.Windows.Forms.SystemInformation::System.Drawing.Font get_MenuFont()
				L_0005: ldc.i4.1 
				L_0006: newobj System.Drawing.Font::Void .ctor(System.Drawing.Font, System.Drawing.FontStyle)
				L_000b: ret 
			*/
			
			
			{
				return new Font (SystemInformation.MenuFont, FontStyle.Bold);
			}
			
			public static void x3fbffc8bcd27b3c0 (Graphics x4b101060f4767186, int x08db3aeabb253cb1, int x1e218ceaee1bb583, bool x2fef7d841879a711)
			
			/*
				// Code Size: 183 Bytes
				.maxstack 5
				.locals (System.Drawing.Pen V_0, 
         System.Drawing.Brush V_1, 
         System.Drawing.Point[] V_2)
				L_0000: ldc.i4.3 
				L_0001: newarr System.Drawing.Point
				L_0006: stloc.2 
				L_0007: ldarg.3 
				L_0008: brtrue.s L_006a
				L_000a: call System.Drawing.Pens::System.Drawing.Pen get_White()
				L_000f: stloc.0 
				L_0010: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_0015: stloc.1 
				L_0016: ldloc.2 
				L_0017: ldc.i4.0 
				L_0018: ldelema System.Drawing.Point
				L_001d: ldarg.1 
				L_001e: ldc.i4.1 
				L_001f: add 
				L_0020: ldarg.2 
				L_0021: ldc.i4.1 
				L_0022: add 
				L_0023: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0028: ldloc.2 
				L_0029: ldc.i4.1 
				L_002a: ldelema System.Drawing.Point
				L_002f: ldarg.1 
				L_0030: ldc.i4.7 
				L_0031: add 
				L_0032: ldarg.2 
				L_0033: ldc.i4.1 
				L_0034: add 
				L_0035: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_003a: ldloc.2 
				L_003b: ldc.i4.2 
				L_003c: ldelema System.Drawing.Point
				L_0041: ldarg.1 
				L_0042: ldc.i4.4 
				L_0043: add 
				L_0044: ldarg.2 
				L_0045: ldc.i4.4 
				L_0046: add 
				L_0047: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_004c: ldarg.0 
				L_004d: ldloc.0 
				L_004e: ldloc.2 
				L_004f: callvirt System.Drawing.Graphics::Void DrawPolygon(System.Drawing.Pen, System.Drawing.Point[])
				L_0054: ldarg.0 
				L_0055: ldloc.1 
				L_0056: ldloc.2 
				L_0057: callvirt System.Drawing.Graphics::Void FillPolygon(System.Drawing.Brush, System.Drawing.Point[])
				L_005c: call System.Drawing.Pens::System.Drawing.Pen get_Gray()
				L_0061: stloc.0 
				L_0062: call System.Drawing.Brushes::System.Drawing.Brush get_Gray()
				L_0067: stloc.1 
				L_0068: br.s L_0076
				L_006a: call System.Drawing.Brushes::System.Drawing.Brush get_Black()
				L_006f: stloc.1 
				L_0070: call System.Drawing.Pens::System.Drawing.Pen get_Black()
				L_0075: stloc.0 
				L_0076: ldloc.2 
				L_0077: ldc.i4.0 
				L_0078: ldelema System.Drawing.Point
				L_007d: ldarg.1 
				L_007e: ldarg.2 
				L_007f: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0084: ldloc.2 
				L_0085: ldc.i4.1 
				L_0086: ldelema System.Drawing.Point
				L_008b: ldarg.1 
				L_008c: ldc.i4.6 
				L_008d: add 
				L_008e: ldarg.2 
				L_008f: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0094: ldloc.2 
				L_0095: ldc.i4.2 
				L_0096: ldelema System.Drawing.Point
				L_009b: ldarg.1 
				L_009c: ldc.i4.3 
				L_009d: add 
				L_009e: ldarg.2 
				L_009f: ldc.i4.3 
				L_00a0: add 
				L_00a1: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_00a6: ldarg.0 
				L_00a7: ldloc.0 
				L_00a8: ldloc.2 
				L_00a9: callvirt System.Drawing.Graphics::Void DrawPolygon(System.Drawing.Pen, System.Drawing.Point[])
				L_00ae: ldarg.0 
				L_00af: ldloc.1 
				L_00b0: ldloc.2 
				L_00b1: callvirt System.Drawing.Graphics::Void FillPolygon(System.Drawing.Brush, System.Drawing.Point[])
				L_00b6: ret 
			*/
			
			
			{
				Pen pen1;
				Brush brush1;
				Point[] pointArray1 = new Point[3];
				if (! x2fef7d841879a711)
				{
					pen1 = Pens.White;
					brush1 = Brushes.White;
					pointArray1[0] = new Point (((int) (x08db3aeabb253cb1 + 1)), ((int) (x1e218ceaee1bb583 + 1)));
					pointArray1[1] = new Point (((int) (x08db3aeabb253cb1 + 7)), ((int) (x1e218ceaee1bb583 + 1)));
					pointArray1[2] = new Point (((int) (x08db3aeabb253cb1 + 4)), ((int) (x1e218ceaee1bb583 + 4)));
					x4b101060f4767186.DrawPolygon (pen1, pointArray1);
					x4b101060f4767186.FillPolygon (brush1, pointArray1);
					pen1 = Pens.Gray;
					brush1 = Brushes.Gray;
				}
				else
				{
					brush1 = Brushes.Black;
					pen1 = Pens.Black;
				}
				pointArray1[0] = new Point (x08db3aeabb253cb1, x1e218ceaee1bb583);
				pointArray1[1] = new Point (((int) (x08db3aeabb253cb1 + 6)), x1e218ceaee1bb583);
				pointArray1[2] = new Point (((int) (x08db3aeabb253cb1 + 3)), ((int) (x1e218ceaee1bb583 + 3)));
				x4b101060f4767186.DrawPolygon (pen1, pointArray1);
				x4b101060f4767186.FillPolygon (brush1, pointArray1);
			}
			
			public static Color x51184f10084316d2 (Color x154083d58301ef75)
			
			/*
				// Code Size: 210 Bytes
				.maxstack 5
				.locals (System.Drawing.Color V_0, 
         System.Int32 V_1, 
         System.Int32 V_2, 
         System.Int32 V_3)
				L_0000: ldarga.s x154083d58301ef75
				L_0002: call System.Drawing.Color::Byte get_R()
				L_0007: ldc.i4 212
				L_000c: bne.un.s L_0044
				L_000e: ldarga.s x154083d58301ef75
				L_0010: call System.Drawing.Color::Byte get_G()
				L_0015: ldc.i4 208
				L_001a: bne.un.s L_0044
				L_001c: ldarga.s x154083d58301ef75
				L_001e: call System.Drawing.Color::Byte get_B()
				L_0023: ldc.i4 200
				L_0028: bne.un.s L_0044
				L_002a: ldc.i4 247
				L_002f: ldc.i4 243
				L_0034: ldc.i4 233
				L_0039: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32)
				L_003e: stloc.0 
				L_003f: br L_00d0
				L_0044: ldarga.s x154083d58301ef75
				L_0046: call System.Drawing.Color::Byte get_R()
				L_004b: ldc.i4 236
				L_0050: bne.un.s L_0085
				L_0052: ldarga.s x154083d58301ef75
				L_0054: call System.Drawing.Color::Byte get_G()
				L_0059: ldc.i4 233
				L_005e: bne.un.s L_0085
				L_0060: ldarga.s x154083d58301ef75
				L_0062: call System.Drawing.Color::Byte get_B()
				L_0067: ldc.i4 216
				L_006c: bne.un.s L_0085
				L_006e: ldc.i4 255
				L_0073: ldc.i4 251
				L_0078: ldc.i4 233
				L_007d: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32)
				L_0082: stloc.0 
				L_0083: br.s L_00d0
				L_0085: ldc.i4 255
				L_008a: ldc.i4 255
				L_008f: ldarga.s x154083d58301ef75
				L_0091: call System.Drawing.Color::Byte get_R()
				L_0096: sub 
				L_0097: ldc.i4.2 
				L_0098: div 
				L_0099: sub 
				L_009a: stloc.1 
				L_009b: ldc.i4 255
				L_00a0: ldc.i4 255
				L_00a5: ldarga.s x154083d58301ef75
				L_00a7: call System.Drawing.Color::Byte get_G()
				L_00ac: sub 
				L_00ad: ldc.i4.2 
				L_00ae: div 
				L_00af: sub 
				L_00b0: stloc.2 
				L_00b1: ldc.i4 255
				L_00b6: ldc.i4 255
				L_00bb: ldarga.s x154083d58301ef75
				L_00bd: call System.Drawing.Color::Byte get_B()
				L_00c2: sub 
				L_00c3: ldc.i4.2 
				L_00c4: div 
				L_00c5: sub 
				L_00c6: stloc.3 
				L_00c7: ldloc.1 
				L_00c8: ldloc.2 
				L_00c9: ldloc.3 
				L_00ca: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, Int32, Int32)
				L_00cf: stloc.0 
				L_00d0: ldloc.0 
				L_00d1: ret 
			*/
			
			
			{
				if (((x154083d58301ef75.R == 212) && (x154083d58301ef75.G == 208)) && (x154083d58301ef75.B == 200))
				{
					return Color.FromArgb (247, 243, 233);
				}
				if (((x154083d58301ef75.R == 236) && (x154083d58301ef75.G == 233)) && (x154083d58301ef75.B == 216))
				{
					return Color.FromArgb (255, 251, 233);
				}
				int i1 = (255 - ((255 - ((int) x154083d58301ef75.R)) / 2));
				int i2 = (255 - ((255 - ((int) x154083d58301ef75.G)) / 2));
				int i3 = (255 - ((255 - ((int) x154083d58301ef75.B)) / 2));
				return Color.FromArgb (i1, i2, i3);
			}
			
			public static void x5687acd58b1cfaac (Graphics x4b101060f4767186, Bitmap x5ce6bc2fb6fe458d, Rectangle x6b8e154b42d5c1e3, Rectangle x50a18ad2656e7181, int x6b0ad9f73c48ad53)
			
			/*
				// Code Size: 163 Bytes
				.maxstack 7
				.locals (System.Drawing.Rectangle V_0, 
         System.Drawing.Rectangle V_1)
				L_0000: ldloca.s V_0
				L_0002: ldarga.s x50a18ad2656e7181
				L_0004: call System.Drawing.Rectangle::Int32 get_X()
				L_0009: ldarga.s x50a18ad2656e7181
				L_000b: call System.Drawing.Rectangle::Int32 get_Y()
				L_0010: ldarga.s x50a18ad2656e7181
				L_0012: call System.Drawing.Rectangle::Int32 get_Width()
				L_0017: ldarg.s x6b0ad9f73c48ad53
				L_0019: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_001e: ldloca.s V_1
				L_0020: ldarga.s x6b8e154b42d5c1e3
				L_0022: call System.Drawing.Rectangle::Int32 get_X()
				L_0027: ldarga.s x6b8e154b42d5c1e3
				L_0029: call System.Drawing.Rectangle::Int32 get_Y()
				L_002e: ldarga.s x6b8e154b42d5c1e3
				L_0030: call System.Drawing.Rectangle::Int32 get_Width()
				L_0035: ldarg.s x6b0ad9f73c48ad53
				L_0037: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_003c: ldarg.0 
				L_003d: ldarg.1 
				L_003e: ldloc.1 
				L_003f: ldloc.0 
				L_0040: ldc.i4.2 
				L_0041: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0046: ldloca.s V_0
				L_0048: ldarga.s x50a18ad2656e7181
				L_004a: call System.Drawing.Rectangle::Int32 get_X()
				L_004f: ldarga.s x50a18ad2656e7181
				L_0051: call System.Drawing.Rectangle::Int32 get_Y()
				L_0056: ldarg.s x6b0ad9f73c48ad53
				L_0058: add 
				L_0059: ldarga.s x50a18ad2656e7181
				L_005b: call System.Drawing.Rectangle::Int32 get_Width()
				L_0060: ldarga.s x50a18ad2656e7181
				L_0062: call System.Drawing.Rectangle::Int32 get_Height()
				L_0067: ldarg.s x6b0ad9f73c48ad53
				L_0069: sub 
				L_006a: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_006f: ldloca.s V_1
				L_0071: ldarga.s x6b8e154b42d5c1e3
				L_0073: call System.Drawing.Rectangle::Int32 get_X()
				L_0078: ldarga.s x6b8e154b42d5c1e3
				L_007a: call System.Drawing.Rectangle::Int32 get_Y()
				L_007f: ldarg.s x6b0ad9f73c48ad53
				L_0081: add 
				L_0082: ldarga.s x6b8e154b42d5c1e3
				L_0084: call System.Drawing.Rectangle::Int32 get_Width()
				L_0089: ldarga.s x6b8e154b42d5c1e3
				L_008b: call System.Drawing.Rectangle::Int32 get_Height()
				L_0090: ldarg.s x6b0ad9f73c48ad53
				L_0092: sub 
				L_0093: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0098: ldarg.0 
				L_0099: ldarg.1 
				L_009a: ldloc.1 
				L_009b: ldloc.0 
				L_009c: ldc.i4.2 
				L_009d: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_00a2: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Rectangle rectangle2;
				rectangle1 = new Rectangle (x50a18ad2656e7181.X, x50a18ad2656e7181.Y, x50a18ad2656e7181.Width, x6b0ad9f73c48ad53);
				rectangle2 = new Rectangle (x6b8e154b42d5c1e3.X, x6b8e154b42d5c1e3.Y, x6b8e154b42d5c1e3.Width, x6b0ad9f73c48ad53);
				x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), rectangle2, rectangle1, GraphicsUnit.Pixel);
				rectangle1 = new Rectangle (x50a18ad2656e7181.X, ((int) (x50a18ad2656e7181.Y + x6b0ad9f73c48ad53)), x50a18ad2656e7181.Width, ((int) (x50a18ad2656e7181.Height - x6b0ad9f73c48ad53)));
				rectangle2 = new Rectangle (x6b8e154b42d5c1e3.X, ((int) (x6b8e154b42d5c1e3.Y + x6b0ad9f73c48ad53)), x6b8e154b42d5c1e3.Width, ((int) (x6b8e154b42d5c1e3.Height - x6b0ad9f73c48ad53)));
				x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), rectangle2, rectangle1, GraphicsUnit.Pixel);
			}
			
			public static Point x6252079f48f24606 (IntPtr x130fbcecf32fe781)
			
			/*
				// Code Size: 33 Bytes
				.maxstack 5
				.locals (System.Int32 V_0, 
         System.Drawing.Point V_1)
				L_0000: ldarga.s x130fbcecf32fe781
				L_0002: call System.IntPtr::Int32 ToInt32()
				L_0007: stloc.0 
				L_0008: ldloca.s V_1
				L_000a: ldloc.0 
				L_000b: ldc.i4 255
				L_0010: or 
				L_0011: ldloc.0 
				L_0012: ldc.i4 65280
				L_0017: or 
				L_0018: ldc.i4.4 
				L_0019: shr 
				L_001a: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_001f: ldloc.1 
				L_0020: ret 
			*/
			
			
			{
				Point point1;
				int i1 = x130fbcecf32fe781.ToInt32 ();
				point1 = new Point (((int) (i1 | 255)), ((int) ((i1 | 65280) >> 4)));
				return point1;
			}
			
			public static void x6871065fdac2acd2 (Bitmap x5ce6bc2fb6fe458d, Graphics x4b101060f4767186, Rectangle xb55b340ae3a3e4e0, bool x6b1f74d7e9186472)
			
			/*
				// Code Size: 327 Bytes
				.maxstack 11
				.locals (System.Drawing.Rectangle V_0, 
         System.Drawing.Rectangle V_1, 
         System.Int32 V_2)
				L_0000: ldarg.0 
				L_0001: callvirt System.Drawing.Image::Int32 get_Width()
				L_0006: ldc.i4.3 
				L_0007: div 
				L_0008: stloc.2 
				L_0009: ldloc.2 
				L_000a: ldarga.s xb55b340ae3a3e4e0
				L_000c: call System.Drawing.Rectangle::Int32 get_Width()
				L_0011: ble.s L_006e
				L_0013: ldloca.s V_0
				L_0015: ldc.i4.0 
				L_0016: ldc.i4.0 
				L_0017: ldarg.0 
				L_0018: callvirt System.Drawing.Image::Int32 get_Width()
				L_001d: ldarg.0 
				L_001e: callvirt System.Drawing.Image::Int32 get_Height()
				L_0023: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0028: ldarg.2 
				L_0029: stloc.1 
				L_002a: ldarg.1 
				L_002b: ldarg.0 
				L_002c: ldloc.1 
				L_002d: ldloc.0 
				L_002e: ldc.i4.2 
				L_002f: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0034: ldloca.s V_0
				L_0036: ldarg.0 
				L_0037: callvirt System.Drawing.Image::Int32 get_Width()
				L_003c: ldc.i4.2 
				L_003d: sub 
				L_003e: ldc.i4.0 
				L_003f: ldc.i4.2 
				L_0040: ldarg.0 
				L_0041: callvirt System.Drawing.Image::Int32 get_Height()
				L_0046: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_004b: ldloca.s V_1
				L_004d: ldarga.s xb55b340ae3a3e4e0
				L_004f: call System.Drawing.Rectangle::Int32 get_Right()
				L_0054: ldc.i4.2 
				L_0055: sub 
				L_0056: ldc.i4.0 
				L_0057: ldc.i4.2 
				L_0058: ldarg.0 
				L_0059: callvirt System.Drawing.Image::Int32 get_Height()
				L_005e: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0063: ldarg.1 
				L_0064: ldarg.0 
				L_0065: ldloc.1 
				L_0066: ldloc.0 
				L_0067: ldc.i4.2 
				L_0068: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_006d: ret 
				L_006e: ldloca.s V_1
				L_0070: ldarga.s xb55b340ae3a3e4e0
				L_0072: call System.Drawing.Rectangle::Int32 get_X()
				L_0077: ldarga.s xb55b340ae3a3e4e0
				L_0079: call System.Drawing.Rectangle::Int32 get_Y()
				L_007e: ldloc.2 
				L_007f: ldarga.s xb55b340ae3a3e4e0
				L_0081: call System.Drawing.Rectangle::Int32 get_Height()
				L_0086: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_008b: ldloca.s V_0
				L_008d: ldc.i4.0 
				L_008e: ldc.i4.0 
				L_008f: ldloc.2 
				L_0090: ldarg.0 
				L_0091: callvirt System.Drawing.Image::Int32 get_Height()
				L_0096: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_009b: ldarg.1 
				L_009c: ldarg.0 
				L_009d: ldloc.1 
				L_009e: ldloc.0 
				L_009f: ldc.i4.2 
				L_00a0: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_00a5: ldarga.s xb55b340ae3a3e4e0
				L_00a7: call System.Drawing.Rectangle::Int32 get_X()
				L_00ac: ldloc.2 
				L_00ad: add 
				L_00ae: ldarga.s xb55b340ae3a3e4e0
				L_00b0: call System.Drawing.Rectangle::Int32 get_Y()
				L_00b5: ldarga.s xb55b340ae3a3e4e0
				L_00b7: call System.Drawing.Rectangle::Int32 get_Right()
				L_00bc: ldloc.2 
				L_00bd: sub 
				L_00be: ldarga.s xb55b340ae3a3e4e0
				L_00c0: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_00c5: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_00ca: stloc.1 
				L_00cb: ldloca.s V_0
				L_00cd: ldloc.2 
				L_00ce: ldc.i4.0 
				L_00cf: ldloc.2 
				L_00d0: ldarg.0 
				L_00d1: callvirt System.Drawing.Image::Int32 get_Height()
				L_00d6: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00db: ldarg.1 
				L_00dc: ldarg.0 
				L_00dd: ldloc.1 
				L_00de: ldloca.s V_0
				L_00e0: call System.Drawing.Rectangle::Int32 get_X()
				L_00e5: ldloca.s V_0
				L_00e7: call System.Drawing.Rectangle::Int32 get_Y()
				L_00ec: ldloca.s V_0
				L_00ee: call System.Drawing.Rectangle::Int32 get_Width()
				L_00f3: ldloca.s V_0
				L_00f5: call System.Drawing.Rectangle::Int32 get_Height()
				L_00fa: ldc.i4.2 
				L_00fb: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x8da407ebcbbfe204()
				L_0100: ldnull 
				L_0101: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes, DrawImageAbort)
				L_0106: ldloca.s V_1
				L_0108: ldarga.s xb55b340ae3a3e4e0
				L_010a: call System.Drawing.Rectangle::Int32 get_Right()
				L_010f: ldloc.2 
				L_0110: sub 
				L_0111: ldarga.s xb55b340ae3a3e4e0
				L_0113: call System.Drawing.Rectangle::Int32 get_Y()
				L_0118: ldloc.2 
				L_0119: ldarga.s xb55b340ae3a3e4e0
				L_011b: call System.Drawing.Rectangle::Int32 get_Height()
				L_0120: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0125: ldloca.s V_0
				L_0127: ldarg.0 
				L_0128: callvirt System.Drawing.Image::Int32 get_Width()
				L_012d: ldloc.2 
				L_012e: sub 
				L_012f: ldc.i4.0 
				L_0130: ldloc.2 
				L_0131: ldarg.0 
				L_0132: callvirt System.Drawing.Image::Int32 get_Height()
				L_0137: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_013c: ldarg.1 
				L_013d: ldarg.0 
				L_013e: ldloc.1 
				L_013f: ldloc.0 
				L_0140: ldc.i4.2 
				L_0141: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0146: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Rectangle rectangle2;
				int i1 = (x5ce6bc2fb6fe458d.Width / 3);
				if (i1 > xb55b340ae3a3e4e0.Width)
				{
					rectangle1 = new Rectangle (0, 0, x5ce6bc2fb6fe458d.Width, x5ce6bc2fb6fe458d.Height);
					rectangle2 = xb55b340ae3a3e4e0;
					x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), rectangle2, rectangle1, GraphicsUnit.Pixel);
					rectangle1 = new Rectangle (((int) (x5ce6bc2fb6fe458d.Width - 2)), 0, 2, x5ce6bc2fb6fe458d.Height);
					rectangle2 = new Rectangle (((int) (xb55b340ae3a3e4e0.Right - 2)), 0, 2, x5ce6bc2fb6fe458d.Height);
					x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), rectangle2, rectangle1, GraphicsUnit.Pixel);
				}
				else
				{
					rectangle2 = new Rectangle (xb55b340ae3a3e4e0.X, xb55b340ae3a3e4e0.Y, i1, xb55b340ae3a3e4e0.Height);
					rectangle1 = new Rectangle (0, 0, i1, x5ce6bc2fb6fe458d.Height);
					x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), rectangle2, rectangle1, GraphicsUnit.Pixel);
					rectangle2 = Rectangle.FromLTRB (((int) (xb55b340ae3a3e4e0.X + i1)), xb55b340ae3a3e4e0.Y, ((int) (xb55b340ae3a3e4e0.Right - i1)), xb55b340ae3a3e4e0.Bottom);
					rectangle1 = new Rectangle (i1, 0, i1, x5ce6bc2fb6fe458d.Height);
					x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), rectangle2, rectangle1.X, rectangle1.Y, rectangle1.Width, rectangle1.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x8da407ebcbbfe204, ((Graphics.DrawImageAbort) null));
					rectangle2 = new Rectangle (((int) (xb55b340ae3a3e4e0.Right - i1)), xb55b340ae3a3e4e0.Y, i1, xb55b340ae3a3e4e0.Height);
					rectangle1 = new Rectangle (((int) (x5ce6bc2fb6fe458d.Width - i1)), 0, i1, x5ce6bc2fb6fe458d.Height);
					x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), rectangle2, rectangle1, GraphicsUnit.Pixel);
				}
			}
			
			public static string x75256eedb834b2e3 (Shortcut xc0de55fd2ca182a4)
			
			/*
				// Code Size: 141 Bytes
				.maxstack 3
				.locals (System.Char V_0, 
         System.String V_1, 
         System.Int32 V_2)
				L_0000: ldarg.0 
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
				L_0019: ldarg.0 
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
				L_0081: ldarg.0 
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
			
			public static void x779038d721b14f75 (Bitmap x50a18ad2656e7181, Graphics xced75983f07f9b6e, Rectangle x26545669838eb36e)
			
			/*
				// Code Size: 2018 Bytes
				.maxstack 7
				.locals (System.Drawing.Rectangle V_0, 
         System.Drawing.Rectangle V_1, 
         System.Drawing.Rectangle V_2, 
         System.Drawing.Rectangle V_3, 
         System.Drawing.Rectangle V_4, 
         System.Drawing.Rectangle V_5, 
         System.Drawing.Rectangle V_6, 
         System.Int32 V_7, 
         System.Int32 V_8, 
         System.Int32 V_9, 
         System.Int32 V_10)
				L_0000: call System.Drawing.Color::System.Drawing.Color get_Fuchsia()
				L_0005: pop 
				L_0006: ldarga.s x26545669838eb36e
				L_0008: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_000d: ldarga.s x26545669838eb36e
				L_000f: call System.Drawing.Rectangle::Int32 get_Top()
				L_0014: bge.s L_0017
				L_0016: ret 
				L_0017: ldarga.s x26545669838eb36e
				L_0019: call System.Drawing.Rectangle::Int32 get_Width()
				L_001e: stloc.s V_7
				L_0020: ldarga.s x26545669838eb36e
				L_0022: call System.Drawing.Rectangle::Int32 get_Height()
				L_0027: stloc.s V_8
				L_0029: ldloca.s V_3
				L_002b: ldc.i4.0 
				L_002c: ldc.i4.0 
				L_002d: ldc.i4.0 
				L_002e: ldc.i4.0 
				L_002f: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0034: ldloc.3 
				L_0035: stloc.2 
				L_0036: ldloc.3 
				L_0037: stloc.s V_4
				L_0039: ldloc.3 
				L_003a: stloc.s V_5
				L_003c: ldc.i4.0 
				L_003d: ldc.i4.0 
				L_003e: ldarg.0 
				L_003f: callvirt System.Drawing.Image::Int32 get_Width()
				L_0044: ldc.i4.2 
				L_0045: div 
				L_0046: ldarg.0 
				L_0047: callvirt System.Drawing.Image::Int32 get_Height()
				L_004c: ldc.i4.2 
				L_004d: div 
				L_004e: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0053: stloc.0 
				L_0054: ldc.i4.0 
				L_0055: ldc.i4.0 
				L_0056: ldloc.s V_7
				L_0058: ldc.i4.2 
				L_0059: div 
				L_005a: ldloc.s V_8
				L_005c: ldc.i4.2 
				L_005d: div 
				L_005e: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0063: stloc.1 
				L_0064: ldloca.s V_0
				L_0066: call System.Drawing.Rectangle::Int32 get_Width()
				L_006b: ldloca.s V_1
				L_006d: call System.Drawing.Rectangle::Int32 get_Width()
				L_0072: call System.Math::Int32 Min(Int32, Int32)
				L_0077: stloc.s V_9
				L_0079: ldloc.s V_9
				L_007b: ldc.i4.0 
				L_007c: bge.s L_0081
				L_007e: ldc.i4.0 
				L_007f: stloc.s V_9
				L_0081: ldloca.s V_0
				L_0083: call System.Drawing.Rectangle::Int32 get_Height()
				L_0088: ldloca.s V_1
				L_008a: call System.Drawing.Rectangle::Int32 get_Height()
				L_008f: call System.Math::Int32 Min(Int32, Int32)
				L_0094: stloc.s V_10
				L_0096: ldloc.s V_10
				L_0098: ldc.i4.0 
				L_0099: bge.s L_009e
				L_009b: ldc.i4.0 
				L_009c: stloc.s V_10
				L_009e: ldloc.s V_9
				L_00a0: brfalse.s L_00f3
				L_00a2: ldloc.s V_10
				L_00a4: brfalse.s L_00f3
				L_00a6: ldloc.s V_9
				L_00a8: ldloca.s V_0
				L_00aa: call System.Drawing.Rectangle::Int32 get_Width()
				L_00af: bge.s L_00ba
				L_00b1: ldloca.s V_0
				L_00b3: ldloc.s V_9
				L_00b5: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_00ba: ldloc.s V_10
				L_00bc: ldloca.s V_0
				L_00be: call System.Drawing.Rectangle::Int32 get_Height()
				L_00c3: bge.s L_00ce
				L_00c5: ldloca.s V_0
				L_00c7: ldloc.s V_10
				L_00c9: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_00ce: ldloca.s V_6
				L_00d0: ldc.i4.0 
				L_00d1: ldc.i4.0 
				L_00d2: ldloc.s V_9
				L_00d4: ldloc.s V_10
				L_00d6: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00db: ldarg.1 
				L_00dc: ldarg.0 
				L_00dd: ldloc.s V_6
				L_00df: ldloc.0 
				L_00e0: ldc.i4.2 
				L_00e1: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_00e6: ldloca.s V_2
				L_00e8: ldc.i4.0 
				L_00e9: ldc.i4.0 
				L_00ea: ldloc.s V_9
				L_00ec: ldloc.s V_10
				L_00ee: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00f3: ldc.i4.0 
				L_00f4: ldarg.0 
				L_00f5: callvirt System.Drawing.Image::Int32 get_Height()
				L_00fa: ldarg.0 
				L_00fb: callvirt System.Drawing.Image::Int32 get_Height()
				L_0100: ldc.i4.2 
				L_0101: div 
				L_0102: sub 
				L_0103: ldc.i4.1 
				L_0104: add 
				L_0105: ldarg.0 
				L_0106: callvirt System.Drawing.Image::Int32 get_Width()
				L_010b: ldc.i4.2 
				L_010c: div 
				L_010d: ldarg.0 
				L_010e: callvirt System.Drawing.Image::Int32 get_Height()
				L_0113: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0118: stloc.0 
				L_0119: ldc.i4.0 
				L_011a: ldloc.s V_8
				L_011c: ldloc.s V_8
				L_011e: ldc.i4.2 
				L_011f: div 
				L_0120: sub 
				L_0121: ldc.i4.1 
				L_0122: add 
				L_0123: ldloc.s V_7
				L_0125: ldc.i4.2 
				L_0126: div 
				L_0127: ldloc.s V_8
				L_0129: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_012e: stloc.1 
				L_012f: ldloca.s V_1
				L_0131: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0136: ldloca.s V_1
				L_0138: call System.Drawing.Rectangle::Int32 get_Top()
				L_013d: bgt.s L_0140
				L_013f: ret 
				L_0140: ldloca.s V_0
				L_0142: call System.Drawing.Rectangle::Int32 get_Width()
				L_0147: ldloca.s V_1
				L_0149: call System.Drawing.Rectangle::Int32 get_Width()
				L_014e: call System.Math::Int32 Min(Int32, Int32)
				L_0153: stloc.s V_9
				L_0155: ldloc.s V_9
				L_0157: ldc.i4.0 
				L_0158: bge.s L_015d
				L_015a: ldc.i4.0 
				L_015b: stloc.s V_9
				L_015d: ldloca.s V_0
				L_015f: call System.Drawing.Rectangle::Int32 get_Height()
				L_0164: ldloca.s V_1
				L_0166: call System.Drawing.Rectangle::Int32 get_Height()
				L_016b: call System.Math::Int32 Min(Int32, Int32)
				L_0170: stloc.s V_10
				L_0172: ldloc.s V_10
				L_0174: ldc.i4.0 
				L_0175: bge.s L_017a
				L_0177: ldc.i4.0 
				L_0178: stloc.s V_10
				L_017a: ldloc.s V_9
				L_017c: brfalse L_01fd
				L_0181: ldloc.s V_10
				L_0183: brfalse.s L_01fd
				L_0185: ldloc.s V_10
				L_0187: ldloca.s V_0
				L_0189: call System.Drawing.Rectangle::Int32 get_Height()
				L_018e: bge.s L_01b2
				L_0190: ldloca.s V_0
				L_0192: ldloca.s V_0
				L_0194: call System.Drawing.Rectangle::Int32 get_Y()
				L_0199: ldloca.s V_0
				L_019b: call System.Drawing.Rectangle::Int32 get_Height()
				L_01a0: ldloc.s V_10
				L_01a2: sub 
				L_01a3: add 
				L_01a4: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_01a9: ldloca.s V_0
				L_01ab: ldloc.s V_10
				L_01ad: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_01b2: ldloc.s V_9
				L_01b4: ldloca.s V_0
				L_01b6: call System.Drawing.Rectangle::Int32 get_Width()
				L_01bb: bge.s L_01c6
				L_01bd: ldloca.s V_0
				L_01bf: ldloc.s V_9
				L_01c1: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_01c6: ldloca.s V_6
				L_01c8: ldc.i4.0 
				L_01c9: ldarga.s x26545669838eb36e
				L_01cb: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_01d0: ldloc.s V_10
				L_01d2: sub 
				L_01d3: ldloc.s V_9
				L_01d5: ldloc.s V_10
				L_01d7: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01dc: ldarg.1 
				L_01dd: ldarg.0 
				L_01de: ldloc.s V_6
				L_01e0: ldloc.0 
				L_01e1: ldc.i4.2 
				L_01e2: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_01e7: ldloca.s V_3
				L_01e9: ldc.i4.0 
				L_01ea: ldarga.s x26545669838eb36e
				L_01ec: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_01f1: ldloc.s V_10
				L_01f3: sub 
				L_01f4: ldloc.s V_9
				L_01f6: ldloc.s V_10
				L_01f8: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01fd: ldc.i4.0 
				L_01fe: ldarg.0 
				L_01ff: callvirt System.Drawing.Image::Int32 get_Height()
				L_0204: ldc.i4.2 
				L_0205: div 
				L_0206: ldarg.0 
				L_0207: callvirt System.Drawing.Image::Int32 get_Width()
				L_020c: ldc.i4.2 
				L_020d: div 
				L_020e: ldarg.0 
				L_020f: callvirt System.Drawing.Image::Int32 get_Height()
				L_0214: ldarg.0 
				L_0215: callvirt System.Drawing.Image::Int32 get_Height()
				L_021a: ldc.i4.2 
				L_021b: div 
				L_021c: sub 
				L_021d: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0222: stloc.0 
				L_0223: ldc.i4.0 
				L_0224: ldloca.s V_2
				L_0226: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_022b: ldloca.s V_2
				L_022d: call System.Drawing.Rectangle::Int32 get_Right()
				L_0232: ldloca.s V_3
				L_0234: call System.Drawing.Rectangle::Int32 get_Top()
				L_0239: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_023e: stloc.1 
				L_023f: ldloca.s V_1
				L_0241: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0246: ldloca.s V_1
				L_0248: call System.Drawing.Rectangle::Int32 get_Top()
				L_024d: ble.s L_0294
				L_024f: ldloca.s V_1
				L_0251: call System.Drawing.Rectangle::Int32 get_Width()
				L_0256: stloc.s V_9
				L_0258: ldloca.s V_1
				L_025a: call System.Drawing.Rectangle::Int32 get_Height()
				L_025f: stloc.s V_10
				L_0261: ldloc.s V_9
				L_0263: brfalse.s L_0294
				L_0265: ldloc.s V_10
				L_0267: brfalse.s L_0294
				L_0269: ldloc.s V_9
				L_026b: ldloca.s V_0
				L_026d: call System.Drawing.Rectangle::Int32 get_Width()
				L_0272: bge.s L_027d
				L_0274: ldloca.s V_0
				L_0276: ldloc.s V_9
				L_0278: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_027d: ldloca.s V_6
				L_027f: ldc.i4.0 
				L_0280: ldc.i4.0 
				L_0281: ldloc.s V_9
				L_0283: ldloc.s V_10
				L_0285: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_028a: ldarg.1 
				L_028b: ldarg.0 
				L_028c: ldloc.1 
				L_028d: ldloc.0 
				L_028e: ldc.i4.2 
				L_028f: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0294: ldarg.0 
				L_0295: callvirt System.Drawing.Image::Int32 get_Width()
				L_029a: ldarg.0 
				L_029b: callvirt System.Drawing.Image::Int32 get_Width()
				L_02a0: ldc.i4.2 
				L_02a1: div 
				L_02a2: sub 
				L_02a3: ldc.i4.1 
				L_02a4: add 
				L_02a5: ldc.i4.0 
				L_02a6: ldarg.0 
				L_02a7: callvirt System.Drawing.Image::Int32 get_Width()
				L_02ac: ldarg.0 
				L_02ad: callvirt System.Drawing.Image::Int32 get_Height()
				L_02b2: ldc.i4.2 
				L_02b3: div 
				L_02b4: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_02b9: stloc.0 
				L_02ba: ldloc.s V_7
				L_02bc: ldloc.s V_7
				L_02be: ldc.i4.2 
				L_02bf: div 
				L_02c0: sub 
				L_02c1: ldc.i4.1 
				L_02c2: add 
				L_02c3: ldc.i4.0 
				L_02c4: ldloc.s V_7
				L_02c6: ldloc.s V_8
				L_02c8: ldc.i4.2 
				L_02c9: div 
				L_02ca: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_02cf: stloc.1 
				L_02d0: ldloca.s V_1
				L_02d2: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_02d7: ldloca.s V_1
				L_02d9: call System.Drawing.Rectangle::Int32 get_Top()
				L_02de: bgt.s L_02e1
				L_02e0: ret 
				L_02e1: ldloca.s V_0
				L_02e3: call System.Drawing.Rectangle::Int32 get_Width()
				L_02e8: ldloca.s V_1
				L_02ea: call System.Drawing.Rectangle::Int32 get_Width()
				L_02ef: call System.Math::Int32 Min(Int32, Int32)
				L_02f4: stloc.s V_9
				L_02f6: ldloc.s V_9
				L_02f8: ldc.i4.0 
				L_02f9: bge.s L_02fe
				L_02fb: ldc.i4.0 
				L_02fc: stloc.s V_9
				L_02fe: ldloca.s V_0
				L_0300: call System.Drawing.Rectangle::Int32 get_Height()
				L_0305: ldloca.s V_1
				L_0307: call System.Drawing.Rectangle::Int32 get_Height()
				L_030c: call System.Math::Int32 Min(Int32, Int32)
				L_0311: stloc.s V_10
				L_0313: ldloc.s V_10
				L_0315: ldc.i4.0 
				L_0316: bge.s L_031b
				L_0318: ldc.i4.0 
				L_0319: stloc.s V_10
				L_031b: ldloc.s V_10
				L_031d: brfalse L_039e
				L_0322: ldloc.s V_9
				L_0324: brfalse.s L_039e
				L_0326: ldloc.s V_9
				L_0328: ldloca.s V_0
				L_032a: call System.Drawing.Rectangle::Int32 get_Width()
				L_032f: bge.s L_0353
				L_0331: ldloca.s V_0
				L_0333: ldloca.s V_0
				L_0335: call System.Drawing.Rectangle::Int32 get_X()
				L_033a: ldloca.s V_0
				L_033c: call System.Drawing.Rectangle::Int32 get_Width()
				L_0341: ldloc.s V_9
				L_0343: sub 
				L_0344: add 
				L_0345: call System.Drawing.Rectangle::Void set_X(Int32)
				L_034a: ldloca.s V_0
				L_034c: ldloc.s V_9
				L_034e: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0353: ldloc.s V_10
				L_0355: ldloca.s V_0
				L_0357: call System.Drawing.Rectangle::Int32 get_Height()
				L_035c: bge.s L_0367
				L_035e: ldloca.s V_0
				L_0360: ldloc.s V_10
				L_0362: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_0367: ldloca.s V_6
				L_0369: ldarga.s x26545669838eb36e
				L_036b: call System.Drawing.Rectangle::Int32 get_Right()
				L_0370: ldloc.s V_9
				L_0372: sub 
				L_0373: ldc.i4.0 
				L_0374: ldloc.s V_9
				L_0376: ldloc.s V_10
				L_0378: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_037d: ldarg.1 
				L_037e: ldarg.0 
				L_037f: ldloc.s V_6
				L_0381: ldloc.0 
				L_0382: ldc.i4.2 
				L_0383: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0388: ldloca.s V_4
				L_038a: ldarga.s x26545669838eb36e
				L_038c: call System.Drawing.Rectangle::Int32 get_Right()
				L_0391: ldloc.s V_9
				L_0393: sub 
				L_0394: ldc.i4.0 
				L_0395: ldloc.s V_9
				L_0397: ldloc.s V_10
				L_0399: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_039e: ldarg.0 
				L_039f: callvirt System.Drawing.Image::Int32 get_Width()
				L_03a4: ldarg.0 
				L_03a5: callvirt System.Drawing.Image::Int32 get_Width()
				L_03aa: ldc.i4.2 
				L_03ab: div 
				L_03ac: sub 
				L_03ad: ldc.i4.1 
				L_03ae: add 
				L_03af: ldarg.0 
				L_03b0: callvirt System.Drawing.Image::Int32 get_Height()
				L_03b5: ldarg.0 
				L_03b6: callvirt System.Drawing.Image::Int32 get_Height()
				L_03bb: ldc.i4.2 
				L_03bc: div 
				L_03bd: sub 
				L_03be: ldc.i4.1 
				L_03bf: add 
				L_03c0: ldarg.0 
				L_03c1: callvirt System.Drawing.Image::Int32 get_Width()
				L_03c6: ldarg.0 
				L_03c7: callvirt System.Drawing.Image::Int32 get_Height()
				L_03cc: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_03d1: stloc.0 
				L_03d2: ldloc.s V_7
				L_03d4: ldloc.s V_7
				L_03d6: ldc.i4.2 
				L_03d7: div 
				L_03d8: sub 
				L_03d9: ldc.i4.1 
				L_03da: add 
				L_03db: ldloc.s V_8
				L_03dd: ldloc.s V_8
				L_03df: ldc.i4.2 
				L_03e0: div 
				L_03e1: sub 
				L_03e2: ldc.i4.1 
				L_03e3: add 
				L_03e4: ldloc.s V_7
				L_03e6: ldloc.s V_8
				L_03e8: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_03ed: stloc.1 
				L_03ee: ldloca.s V_1
				L_03f0: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_03f5: ldloca.s V_1
				L_03f7: call System.Drawing.Rectangle::Int32 get_Top()
				L_03fc: bgt.s L_03ff
				L_03fe: ret 
				L_03ff: ldloca.s V_0
				L_0401: call System.Drawing.Rectangle::Int32 get_Width()
				L_0406: ldloca.s V_1
				L_0408: call System.Drawing.Rectangle::Int32 get_Width()
				L_040d: call System.Math::Int32 Min(Int32, Int32)
				L_0412: stloc.s V_9
				L_0414: ldloc.s V_9
				L_0416: ldc.i4.0 
				L_0417: bge.s L_041c
				L_0419: ldc.i4.0 
				L_041a: stloc.s V_9
				L_041c: ldloca.s V_0
				L_041e: call System.Drawing.Rectangle::Int32 get_Height()
				L_0423: ldloca.s V_1
				L_0425: call System.Drawing.Rectangle::Int32 get_Height()
				L_042a: call System.Math::Int32 Min(Int32, Int32)
				L_042f: stloc.s V_10
				L_0431: ldloc.s V_10
				L_0433: ldc.i4.0 
				L_0434: bge.s L_0439
				L_0436: ldc.i4.0 
				L_0437: stloc.s V_10
				L_0439: ldloc.s V_9
				L_043b: brfalse L_04ea
				L_0440: ldloc.s V_10
				L_0442: brfalse L_04ea
				L_0447: ldloc.s V_9
				L_0449: ldloca.s V_0
				L_044b: call System.Drawing.Rectangle::Int32 get_Width()
				L_0450: bge.s L_0474
				L_0452: ldloca.s V_0
				L_0454: ldloca.s V_0
				L_0456: call System.Drawing.Rectangle::Int32 get_X()
				L_045b: ldloca.s V_0
				L_045d: call System.Drawing.Rectangle::Int32 get_Width()
				L_0462: ldloc.s V_9
				L_0464: sub 
				L_0465: add 
				L_0466: call System.Drawing.Rectangle::Void set_X(Int32)
				L_046b: ldloca.s V_0
				L_046d: ldloc.s V_9
				L_046f: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0474: ldloc.s V_10
				L_0476: ldloca.s V_0
				L_0478: call System.Drawing.Rectangle::Int32 get_Height()
				L_047d: bge.s L_04a1
				L_047f: ldloca.s V_0
				L_0481: ldloca.s V_0
				L_0483: call System.Drawing.Rectangle::Int32 get_Y()
				L_0488: ldloca.s V_0
				L_048a: call System.Drawing.Rectangle::Int32 get_Height()
				L_048f: ldloc.s V_10
				L_0491: sub 
				L_0492: add 
				L_0493: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_0498: ldloca.s V_0
				L_049a: ldloc.s V_10
				L_049c: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_04a1: ldloca.s V_6
				L_04a3: ldarga.s x26545669838eb36e
				L_04a5: call System.Drawing.Rectangle::Int32 get_Right()
				L_04aa: ldloc.s V_9
				L_04ac: sub 
				L_04ad: ldarga.s x26545669838eb36e
				L_04af: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_04b4: ldloc.s V_10
				L_04b6: sub 
				L_04b7: ldloc.s V_9
				L_04b9: ldloc.s V_10
				L_04bb: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_04c0: ldarg.1 
				L_04c1: ldarg.0 
				L_04c2: ldloc.s V_6
				L_04c4: ldloc.0 
				L_04c5: ldc.i4.2 
				L_04c6: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_04cb: ldloca.s V_5
				L_04cd: ldarga.s x26545669838eb36e
				L_04cf: call System.Drawing.Rectangle::Int32 get_Right()
				L_04d4: ldloc.s V_9
				L_04d6: sub 
				L_04d7: ldarga.s x26545669838eb36e
				L_04d9: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_04de: ldloc.s V_10
				L_04e0: sub 
				L_04e1: ldloc.s V_9
				L_04e3: ldloc.s V_10
				L_04e5: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_04ea: ldarg.0 
				L_04eb: callvirt System.Drawing.Image::Int32 get_Width()
				L_04f0: ldarg.0 
				L_04f1: callvirt System.Drawing.Image::Int32 get_Width()
				L_04f6: ldc.i4.2 
				L_04f7: div 
				L_04f8: sub 
				L_04f9: ldc.i4.1 
				L_04fa: add 
				L_04fb: ldarg.0 
				L_04fc: callvirt System.Drawing.Image::Int32 get_Height()
				L_0501: ldarg.0 
				L_0502: callvirt System.Drawing.Image::Int32 get_Height()
				L_0507: ldc.i4.2 
				L_0508: div 
				L_0509: sub 
				L_050a: ldarg.0 
				L_050b: callvirt System.Drawing.Image::Int32 get_Width()
				L_0510: ldarg.0 
				L_0511: callvirt System.Drawing.Image::Int32 get_Height()
				L_0516: ldc.i4.2 
				L_0517: div 
				L_0518: ldc.i4.2 
				L_0519: add 
				L_051a: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_051f: stloc.0 
				L_0520: ldloca.s V_4
				L_0522: call System.Drawing.Rectangle::Int32 get_Left()
				L_0527: ldloca.s V_4
				L_0529: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_052e: ldloca.s V_4
				L_0530: call System.Drawing.Rectangle::Int32 get_Right()
				L_0535: ldloca.s V_5
				L_0537: call System.Drawing.Rectangle::Int32 get_Top()
				L_053c: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0541: stloc.1 
				L_0542: ldloca.s V_1
				L_0544: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0549: ldloca.s V_1
				L_054b: call System.Drawing.Rectangle::Int32 get_Top()
				L_0550: ble.s L_05bd
				L_0552: ldloca.s V_1
				L_0554: call System.Drawing.Rectangle::Int32 get_Width()
				L_0559: stloc.s V_9
				L_055b: ldloca.s V_1
				L_055d: call System.Drawing.Rectangle::Int32 get_Height()
				L_0562: stloc.s V_10
				L_0564: ldloc.s V_9
				L_0566: brfalse.s L_05bd
				L_0568: ldloc.s V_10
				L_056a: brfalse.s L_05bd
				L_056c: ldloc.s V_9
				L_056e: ldloca.s V_0
				L_0570: call System.Drawing.Rectangle::Int32 get_Width()
				L_0575: bge.s L_0599
				L_0577: ldloca.s V_0
				L_0579: ldloca.s V_0
				L_057b: call System.Drawing.Rectangle::Int32 get_X()
				L_0580: ldloca.s V_0
				L_0582: call System.Drawing.Rectangle::Int32 get_Width()
				L_0587: ldloc.s V_9
				L_0589: sub 
				L_058a: add 
				L_058b: call System.Drawing.Rectangle::Void set_X(Int32)
				L_0590: ldloca.s V_0
				L_0592: ldloc.s V_9
				L_0594: call System.Drawing.Rectangle::Void set_Width(Int32)
				L_0599: ldloca.s V_6
				L_059b: ldloca.s V_1
				L_059d: call System.Drawing.Rectangle::Int32 get_X()
				L_05a2: ldloca.s V_1
				L_05a4: call System.Drawing.Rectangle::Int32 get_Y()
				L_05a9: ldloc.s V_9
				L_05ab: ldloc.s V_10
				L_05ad: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_05b2: ldarg.1 
				L_05b3: ldarg.0 
				L_05b4: ldloc.s V_6
				L_05b6: ldloc.0 
				L_05b7: ldc.i4.2 
				L_05b8: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_05bd: ldarg.0 
				L_05be: callvirt System.Drawing.Image::Int32 get_Width()
				L_05c3: ldc.i4.2 
				L_05c4: div 
				L_05c5: ldc.i4.0 
				L_05c6: ldarg.0 
				L_05c7: callvirt System.Drawing.Image::Int32 get_Width()
				L_05cc: ldarg.0 
				L_05cd: callvirt System.Drawing.Image::Int32 get_Width()
				L_05d2: ldc.i4.2 
				L_05d3: div 
				L_05d4: sub 
				L_05d5: ldc.i4.1 
				L_05d6: add 
				L_05d7: ldarg.0 
				L_05d8: callvirt System.Drawing.Image::Int32 get_Height()
				L_05dd: ldc.i4.2 
				L_05de: div 
				L_05df: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_05e4: stloc.0 
				L_05e5: ldloca.s V_2
				L_05e7: call System.Drawing.Rectangle::Int32 get_Right()
				L_05ec: ldc.i4.0 
				L_05ed: ldloca.s V_4
				L_05ef: call System.Drawing.Rectangle::Int32 get_Left()
				L_05f4: ldloca.s V_2
				L_05f6: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_05fb: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0600: stloc.1 
				L_0601: ldloca.s V_1
				L_0603: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0608: ldloca.s V_1
				L_060a: call System.Drawing.Rectangle::Int32 get_Top()
				L_060f: ble.s L_0663
				L_0611: ldloca.s V_1
				L_0613: call System.Drawing.Rectangle::Int32 get_Width()
				L_0618: stloc.s V_9
				L_061a: ldloca.s V_1
				L_061c: call System.Drawing.Rectangle::Int32 get_Height()
				L_0621: stloc.s V_10
				L_0623: ldloc.s V_9
				L_0625: brfalse.s L_0663
				L_0627: ldloc.s V_10
				L_0629: brfalse.s L_0663
				L_062b: ldloc.s V_10
				L_062d: ldloca.s V_0
				L_062f: call System.Drawing.Rectangle::Int32 get_Height()
				L_0634: bge.s L_063f
				L_0636: ldloca.s V_0
				L_0638: ldloc.s V_10
				L_063a: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_063f: ldloca.s V_6
				L_0641: ldloca.s V_1
				L_0643: call System.Drawing.Rectangle::Int32 get_X()
				L_0648: ldloca.s V_1
				L_064a: call System.Drawing.Rectangle::Int32 get_Y()
				L_064f: ldloc.s V_9
				L_0651: ldloc.s V_10
				L_0653: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0658: ldarg.1 
				L_0659: ldarg.0 
				L_065a: ldloc.s V_6
				L_065c: ldloc.0 
				L_065d: ldc.i4.2 
				L_065e: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0663: ldarg.0 
				L_0664: callvirt System.Drawing.Image::Int32 get_Width()
				L_0669: ldc.i4.2 
				L_066a: div 
				L_066b: ldarg.0 
				L_066c: callvirt System.Drawing.Image::Int32 get_Height()
				L_0671: ldc.i4.2 
				L_0672: div 
				L_0673: ldarg.0 
				L_0674: callvirt System.Drawing.Image::Int32 get_Width()
				L_0679: ldarg.0 
				L_067a: callvirt System.Drawing.Image::Int32 get_Width()
				L_067f: ldc.i4.2 
				L_0680: div 
				L_0681: sub 
				L_0682: ldc.i4.1 
				L_0683: add 
				L_0684: ldarg.0 
				L_0685: callvirt System.Drawing.Image::Int32 get_Height()
				L_068a: ldarg.0 
				L_068b: callvirt System.Drawing.Image::Int32 get_Height()
				L_0690: ldc.i4.2 
				L_0691: div 
				L_0692: sub 
				L_0693: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0698: stloc.0 
				L_0699: ldloca.s V_2
				L_069b: call System.Drawing.Rectangle::Int32 get_Right()
				L_06a0: ldloca.s V_2
				L_06a2: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_06a7: ldloca.s V_4
				L_06a9: call System.Drawing.Rectangle::Int32 get_Left()
				L_06ae: ldloca.s V_5
				L_06b0: call System.Drawing.Rectangle::Int32 get_Top()
				L_06b5: ldc.i4.1 
				L_06b6: sub 
				L_06b7: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_06bc: stloc.1 
				L_06bd: ldloca.s V_1
				L_06bf: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_06c4: ldloca.s V_1
				L_06c6: call System.Drawing.Rectangle::Int32 get_Top()
				L_06cb: ble.s L_070b
				L_06cd: ldloca.s V_1
				L_06cf: call System.Drawing.Rectangle::Int32 get_Width()
				L_06d4: stloc.s V_9
				L_06d6: ldloca.s V_1
				L_06d8: call System.Drawing.Rectangle::Int32 get_Height()
				L_06dd: stloc.s V_10
				L_06df: ldloc.s V_9
				L_06e1: brfalse.s L_070b
				L_06e3: ldloc.s V_9
				L_06e5: brfalse.s L_070b
				L_06e7: ldloca.s V_6
				L_06e9: ldloca.s V_1
				L_06eb: call System.Drawing.Rectangle::Int32 get_X()
				L_06f0: ldloca.s V_1
				L_06f2: call System.Drawing.Rectangle::Int32 get_Y()
				L_06f7: ldloc.s V_9
				L_06f9: ldloc.s V_10
				L_06fb: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0700: ldarg.1 
				L_0701: ldarg.0 
				L_0702: ldloc.s V_6
				L_0704: ldloc.0 
				L_0705: ldc.i4.2 
				L_0706: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_070b: ldarg.0 
				L_070c: callvirt System.Drawing.Image::Int32 get_Width()
				L_0711: ldc.i4.2 
				L_0712: div 
				L_0713: ldarg.0 
				L_0714: callvirt System.Drawing.Image::Int32 get_Height()
				L_0719: ldarg.0 
				L_071a: callvirt System.Drawing.Image::Int32 get_Height()
				L_071f: ldc.i4.2 
				L_0720: div 
				L_0721: sub 
				L_0722: ldarg.0 
				L_0723: callvirt System.Drawing.Image::Int32 get_Width()
				L_0728: ldarg.0 
				L_0729: callvirt System.Drawing.Image::Int32 get_Width()
				L_072e: ldc.i4.2 
				L_072f: div 
				L_0730: sub 
				L_0731: ldc.i4.1 
				L_0732: add 
				L_0733: ldarg.0 
				L_0734: callvirt System.Drawing.Image::Int32 get_Height()
				L_0739: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_073e: stloc.0 
				L_073f: ldloca.s V_2
				L_0741: call System.Drawing.Rectangle::Int32 get_Right()
				L_0746: ldc.i4.1 
				L_0747: sub 
				L_0748: ldloca.s V_3
				L_074a: call System.Drawing.Rectangle::Int32 get_Top()
				L_074f: ldc.i4.1 
				L_0750: sub 
				L_0751: ldloca.s V_5
				L_0753: call System.Drawing.Rectangle::Int32 get_Left()
				L_0758: ldloca.s V_5
				L_075a: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_075f: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0764: stloc.1 
				L_0765: ldloca.s V_1
				L_0767: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_076c: ldloca.s V_1
				L_076e: call System.Drawing.Rectangle::Int32 get_Top()
				L_0773: bgt.s L_0776
				L_0775: ret 
				L_0776: ldloca.s V_1
				L_0778: call System.Drawing.Rectangle::Int32 get_Width()
				L_077d: stloc.s V_9
				L_077f: ldloca.s V_1
				L_0781: call System.Drawing.Rectangle::Int32 get_Height()
				L_0786: stloc.s V_10
				L_0788: ldloc.s V_9
				L_078a: brfalse.s L_07e1
				L_078c: ldloc.s V_10
				L_078e: brfalse.s L_07e1
				L_0790: ldloc.s V_10
				L_0792: ldloca.s V_0
				L_0794: call System.Drawing.Rectangle::Int32 get_Height()
				L_0799: bge.s L_07bd
				L_079b: ldloca.s V_0
				L_079d: ldloca.s V_0
				L_079f: call System.Drawing.Rectangle::Int32 get_Y()
				L_07a4: ldloca.s V_0
				L_07a6: call System.Drawing.Rectangle::Int32 get_Height()
				L_07ab: ldloc.s V_10
				L_07ad: sub 
				L_07ae: add 
				L_07af: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_07b4: ldloca.s V_0
				L_07b6: ldloc.s V_10
				L_07b8: call System.Drawing.Rectangle::Void set_Height(Int32)
				L_07bd: ldloca.s V_6
				L_07bf: ldloca.s V_1
				L_07c1: call System.Drawing.Rectangle::Int32 get_X()
				L_07c6: ldloca.s V_1
				L_07c8: call System.Drawing.Rectangle::Int32 get_Y()
				L_07cd: ldloc.s V_9
				L_07cf: ldloc.s V_10
				L_07d1: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_07d6: ldarg.1 
				L_07d7: ldarg.0 
				L_07d8: ldloc.s V_6
				L_07da: ldloc.0 
				L_07db: ldc.i4.2 
				L_07dc: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_07e1: ret 
			*/
			
			
			{
				Rectangle rectangle2;
				Rectangle rectangle4;
				Rectangle rectangle7;
				Color color1 = Color.Fuchsia;
				if (x26545669838eb36e.Bottom < x26545669838eb36e.Top)
				{
					return;
				}
				int i1 = x26545669838eb36e.Width;
				int i2 = x26545669838eb36e.Height;
				rectangle4 = new Rectangle (0, 0, 0, 0);
				Rectangle rectangle3 = rectangle4;
				Rectangle rectangle5 = rectangle4;
				Rectangle rectangle6 = rectangle4;
				Rectangle rectangle1 = Rectangle.FromLTRB (0, 0, ((int) (x50a18ad2656e7181.Width / 2)), ((int) (x50a18ad2656e7181.Height / 2)));
				int i3 = Math.Min (rectangle1.Width, (rectangle2 = Rectangle.FromLTRB (0, 0, ((int) (i1 / 2)), ((int) (i2 / 2)))).Width);
				if (i3 < 0)
				{
					i3 = 0;
				}
				int i4 = Math.Min (rectangle1.Height, rectangle2.Height);
				if (i4 < 0)
				{
					i4 = 0;
				}
				if ((i3 != 0) && (i4 != 0))
				{
					if (i3 < rectangle1.Width)
					{
						rectangle1.Width = i3;
					}
					if (i4 < rectangle1.Height)
					{
						rectangle1.Height = i4;
					}
					rectangle7 = new Rectangle (0, 0, i3, i4);
					xced75983f07f9b6e.DrawImage (((Image) x50a18ad2656e7181), rectangle7, rectangle1, GraphicsUnit.Pixel);
					rectangle3 = new Rectangle (0, 0, i3, i4);
				}
				rectangle1 = Rectangle.FromLTRB (0, ((int) ((x50a18ad2656e7181.Height - (x50a18ad2656e7181.Height / 2)) + 1)), ((int) (x50a18ad2656e7181.Width / 2)), x50a18ad2656e7181.Height);
				if ((rectangle2 = Rectangle.FromLTRB (0, ((int) ((i2 - (i2 / 2)) + 1)), ((int) (i1 / 2)), i2)).Bottom > rectangle2.Top)
				{
					i3 = Math.Min (rectangle1.Width, rectangle2.Width);
					if (i3 < 0)
					{
						i3 = 0;
					}
					i4 = Math.Min (rectangle1.Height, rectangle2.Height);
					if (i4 < 0)
					{
						i4 = 0;
					}
					if ((i3 != 0) && (i4 != 0))
					{
						if (i4 < rectangle1.Height)
						{
							rectangle1.Y += (rectangle1.Height - i4);
							rectangle1.Height = i4;
						}
						if (i3 < rectangle1.Width)
						{
							rectangle1.Width = i3;
						}
						rectangle7 = new Rectangle (0, ((int) (x26545669838eb36e.Bottom - i4)), i3, i4);
						xced75983f07f9b6e.DrawImage (((Image) x50a18ad2656e7181), rectangle7, rectangle1, GraphicsUnit.Pixel);
						rectangle4 = new Rectangle (0, ((int) (x26545669838eb36e.Bottom - i4)), i3, i4);
					}
					rectangle1 = Rectangle.FromLTRB (0, ((int) (x50a18ad2656e7181.Height / 2)), ((int) (x50a18ad2656e7181.Width / 2)), ((int) (x50a18ad2656e7181.Height - (x50a18ad2656e7181.Height / 2))));
					if ((rectangle2 = Rectangle.FromLTRB (0, rectangle3.Bottom, rectangle3.Right, rectangle4.Top)).Bottom > rectangle2.Top)
					{
						i3 = rectangle2.Width;
						i4 = rectangle2.Height;
						if ((i3 != 0) && (i4 != 0))
						{
							if (i3 < rectangle1.Width)
							{
								rectangle1.Width = i3;
							}
							rectangle7 = new Rectangle (0, 0, i3, i4);
							xced75983f07f9b6e.DrawImage (((Image) x50a18ad2656e7181), rectangle2, rectangle1, GraphicsUnit.Pixel);
						}
					}
					rectangle1 = Rectangle.FromLTRB (((int) ((x50a18ad2656e7181.Width - (x50a18ad2656e7181.Width / 2)) + 1)), 0, x50a18ad2656e7181.Width, ((int) (x50a18ad2656e7181.Height / 2)));
					if ((rectangle2 = Rectangle.FromLTRB (((int) ((i1 - (i1 / 2)) + 1)), 0, i1, ((int) (i2 / 2)))).Bottom > rectangle2.Top)
					{
						i3 = Math.Min (rectangle1.Width, rectangle2.Width);
						if (i3 < 0)
						{
							i3 = 0;
						}
						i4 = Math.Min (rectangle1.Height, rectangle2.Height);
						if (i4 < 0)
						{
							i4 = 0;
						}
						if ((i4 != 0) && (i3 != 0))
						{
							if (i3 < rectangle1.Width)
							{
								rectangle1.X += (rectangle1.Width - i3);
								rectangle1.Width = i3;
							}
							if (i4 < rectangle1.Height)
							{
								rectangle1.Height = i4;
							}
							rectangle7 = new Rectangle (((int) (x26545669838eb36e.Right - i3)), 0, i3, i4);
							xced75983f07f9b6e.DrawImage (((Image) x50a18ad2656e7181), rectangle7, rectangle1, GraphicsUnit.Pixel);
							rectangle5 = new Rectangle (((int) (x26545669838eb36e.Right - i3)), 0, i3, i4);
						}
						rectangle1 = Rectangle.FromLTRB (((int) ((x50a18ad2656e7181.Width - (x50a18ad2656e7181.Width / 2)) + 1)), ((int) ((x50a18ad2656e7181.Height - (x50a18ad2656e7181.Height / 2)) + 1)), x50a18ad2656e7181.Width, x50a18ad2656e7181.Height);
						if ((rectangle2 = Rectangle.FromLTRB (((int) ((i1 - (i1 / 2)) + 1)), ((int) ((i2 - (i2 / 2)) + 1)), i1, i2)).Bottom > rectangle2.Top)
						{
							i3 = Math.Min (rectangle1.Width, rectangle2.Width);
							if (i3 < 0)
							{
								i3 = 0;
							}
							i4 = Math.Min (rectangle1.Height, rectangle2.Height);
							if (i4 < 0)
							{
								i4 = 0;
							}
							if ((i3 != 0) && (i4 != 0))
							{
								if (i3 < rectangle1.Width)
								{
									rectangle1.X += (rectangle1.Width - i3);
									rectangle1.Width = i3;
								}
								if (i4 < rectangle1.Height)
								{
									rectangle1.Y += (rectangle1.Height - i4);
									rectangle1.Height = i4;
								}
								rectangle7 = new Rectangle (((int) (x26545669838eb36e.Right - i3)), ((int) (x26545669838eb36e.Bottom - i4)), i3, i4);
								xced75983f07f9b6e.DrawImage (((Image) x50a18ad2656e7181), rectangle7, rectangle1, GraphicsUnit.Pixel);
								rectangle6 = new Rectangle (((int) (x26545669838eb36e.Right - i3)), ((int) (x26545669838eb36e.Bottom - i4)), i3, i4);
							}
							rectangle1 = Rectangle.FromLTRB (((int) ((x50a18ad2656e7181.Width - (x50a18ad2656e7181.Width / 2)) + 1)), ((int) (x50a18ad2656e7181.Height - (x50a18ad2656e7181.Height / 2))), x50a18ad2656e7181.Width, ((int) ((x50a18ad2656e7181.Height / 2) + 2)));
							if ((rectangle2 = Rectangle.FromLTRB (rectangle5.Left, rectangle5.Bottom, rectangle5.Right, rectangle6.Top)).Bottom > rectangle2.Top)
							{
								i3 = rectangle2.Width;
								i4 = rectangle2.Height;
								if ((i3 != 0) && (i4 != 0))
								{
									if (i3 < rectangle1.Width)
									{
										rectangle1.X += (rectangle1.Width - i3);
										rectangle1.Width = i3;
									}
									rectangle7 = new Rectangle (rectangle2.X, rectangle2.Y, i3, i4);
									xced75983f07f9b6e.DrawImage (((Image) x50a18ad2656e7181), rectangle7, rectangle1, GraphicsUnit.Pixel);
								}
							}
							rectangle1 = Rectangle.FromLTRB (((int) (x50a18ad2656e7181.Width / 2)), 0, ((int) ((x50a18ad2656e7181.Width - (x50a18ad2656e7181.Width / 2)) + 1)), ((int) (x50a18ad2656e7181.Height / 2)));
							if ((rectangle2 = Rectangle.FromLTRB (rectangle3.Right, 0, rectangle5.Left, rectangle3.Bottom)).Bottom > rectangle2.Top)
							{
								i3 = rectangle2.Width;
								i4 = rectangle2.Height;
								if ((i3 != 0) && (i4 != 0))
								{
									if (i4 < rectangle1.Height)
									{
										rectangle1.Height = i4;
									}
									rectangle7 = new Rectangle (rectangle2.X, rectangle2.Y, i3, i4);
									xced75983f07f9b6e.DrawImage (((Image) x50a18ad2656e7181), rectangle7, rectangle1, GraphicsUnit.Pixel);
								}
							}
							rectangle1 = Rectangle.FromLTRB (((int) (x50a18ad2656e7181.Width / 2)), ((int) (x50a18ad2656e7181.Height / 2)), ((int) ((x50a18ad2656e7181.Width - (x50a18ad2656e7181.Width / 2)) + 1)), ((int) (x50a18ad2656e7181.Height - (x50a18ad2656e7181.Height / 2))));
							if ((rectangle2 = Rectangle.FromLTRB (rectangle3.Right, rectangle3.Bottom, rectangle5.Left, ((int) (rectangle6.Top - 1)))).Bottom > rectangle2.Top)
							{
								i3 = rectangle2.Width;
								i4 = rectangle2.Height;
								if ((i3 != 0) && (i3 != 0))
								{
									rectangle7 = new Rectangle (rectangle2.X, rectangle2.Y, i3, i4);
									xced75983f07f9b6e.DrawImage (((Image) x50a18ad2656e7181), rectangle7, rectangle1, GraphicsUnit.Pixel);
								}
							}
							rectangle1 = Rectangle.FromLTRB (((int) (x50a18ad2656e7181.Width / 2)), ((int) (x50a18ad2656e7181.Height - (x50a18ad2656e7181.Height / 2))), ((int) ((x50a18ad2656e7181.Width - (x50a18ad2656e7181.Width / 2)) + 1)), x50a18ad2656e7181.Height);
							if ((rectangle2 = Rectangle.FromLTRB (((int) (rectangle3.Right - 1)), ((int) (rectangle4.Top - 1)), rectangle6.Left, rectangle6.Bottom)).Bottom > rectangle2.Top)
							{
								i3 = rectangle2.Width;
								i4 = rectangle2.Height;
								if ((i3 != 0) && (i4 != 0))
								{
									if (i4 < rectangle1.Height)
									{
										rectangle1.Y += (rectangle1.Height - i4);
										rectangle1.Height = i4;
									}
									rectangle7 = new Rectangle (rectangle2.X, rectangle2.Y, i3, i4);
									xced75983f07f9b6e.DrawImage (((Image) x50a18ad2656e7181), rectangle7, rectangle1, GraphicsUnit.Pixel);
								}
							}
						}
					}
				}
			}
			
			public static void x897356c8698a543c (ref xae4dd1cafd2eb77c.RECT x26545669838eb36e, int xb73c4e7368f9939f, int xd143f88fddaa10ad)
			
			/*
				// Code Size: 57 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: dup 
				L_0002: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_0007: ldarg.1 
				L_0008: add 
				L_0009: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_000e: ldarg.0 
				L_000f: dup 
				L_0010: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_0015: ldarg.1 
				L_0016: add 
				L_0017: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_001c: ldarg.0 
				L_001d: dup 
				L_001e: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_0023: ldarg.2 
				L_0024: add 
				L_0025: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_002a: ldarg.0 
				L_002b: dup 
				L_002c: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0031: ldarg.2 
				L_0032: add 
				L_0033: stfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_0038: ret 
			*/
			
			
			{
				x26545669838eb36e.left += xb73c4e7368f9939f;
				x26545669838eb36e.right += xb73c4e7368f9939f;
				x26545669838eb36e.top += xd143f88fddaa10ad;
				x26545669838eb36e.bottom += xd143f88fddaa10ad;
			}
			
			public static void x897356c8698a543c (ref Rectangle x26545669838eb36e, int xb73c4e7368f9939f, int xd143f88fddaa10ad)
			
			/*
				// Code Size: 29 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: dup 
				L_0002: call System.Drawing.Rectangle::Int32 get_X()
				L_0007: ldarg.1 
				L_0008: add 
				L_0009: call System.Drawing.Rectangle::Void set_X(Int32)
				L_000e: ldarg.0 
				L_000f: dup 
				L_0010: call System.Drawing.Rectangle::Int32 get_Y()
				L_0015: ldarg.2 
				L_0016: add 
				L_0017: call System.Drawing.Rectangle::Void set_Y(Int32)
				L_001c: ret 
			*/
			
			
			{
				x26545669838eb36e.X += xb73c4e7368f9939f;
				x26545669838eb36e.Y += xd143f88fddaa10ad;
			}
			
			public static Color x898c3842f8dd56e5 (Color xfe9df16f7e7c346d, Color x753506715ee62862, int x6ad505c7ef981b0e)
			
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
				L_0005: ldarg.0 
				L_0006: call System.Drawing.Color::System.Drawing.Color FromArgb(Int32, System.Drawing.Color)
				L_000b: stloc.0 
				L_000c: ldc.i4 255
				L_0011: ldarg.1 
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
				L_0053: ldarg.2 
				L_0054: conv.r4 
				L_0055: mul 
				L_0056: ldc.r4 255
				L_005b: div 
				L_005c: ldloc.s V_5
				L_005e: ldc.i4 255
				L_0063: ldarg.2 
				L_0064: sub 
				L_0065: conv.r4 
				L_0066: ldc.r4 255
				L_006b: div 
				L_006c: mul 
				L_006d: add 
				L_006e: stloc.s V_8
				L_0070: ldloc.3 
				L_0071: ldarg.2 
				L_0072: conv.r4 
				L_0073: mul 
				L_0074: ldc.r4 255
				L_0079: div 
				L_007a: ldloc.s V_6
				L_007c: ldc.i4 255
				L_0081: ldarg.2 
				L_0082: sub 
				L_0083: conv.r4 
				L_0084: ldc.r4 255
				L_0089: div 
				L_008a: mul 
				L_008b: add 
				L_008c: stloc.s V_9
				L_008e: ldloc.s V_4
				L_0090: ldarg.2 
				L_0091: conv.r4 
				L_0092: mul 
				L_0093: ldc.r4 255
				L_0098: div 
				L_0099: ldloc.s V_7
				L_009b: ldc.i4 255
				L_00a0: ldarg.2 
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
			
			public static bool x9466a6be27202526 (int x08db3aeabb253cb1, int x1e218ceaee1bb583, Rectangle xb55b340ae3a3e4e0)
			
			/*
				// Code Size: 46 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarga.s xb55b340ae3a3e4e0
				L_0003: call System.Drawing.Rectangle::Int32 get_Left()
				L_0008: blt.s L_002c
				L_000a: ldarg.0 
				L_000b: ldarga.s xb55b340ae3a3e4e0
				L_000d: call System.Drawing.Rectangle::Int32 get_Right()
				L_0012: bgt.s L_002c
				L_0014: ldarg.1 
				L_0015: ldarga.s xb55b340ae3a3e4e0
				L_0017: call System.Drawing.Rectangle::Int32 get_Top()
				L_001c: blt.s L_002c
				L_001e: ldarg.1 
				L_001f: ldarga.s xb55b340ae3a3e4e0
				L_0021: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0026: cgt 
				L_0028: ldc.i4.0 
				L_0029: ceq 
				L_002b: ret 
				L_002c: ldc.i4.0 
				L_002d: ret 
			*/
			
			
			{
				if (x08db3aeabb253cb1 < xb55b340ae3a3e4e0.Left)
				{
					return false;
				}
				else if (x08db3aeabb253cb1 > xb55b340ae3a3e4e0.Right)
				{
					return false;
				}
				else if (x1e218ceaee1bb583 < xb55b340ae3a3e4e0.Top)
				{
					return false;
				}
				else
				{
					return (x1e218ceaee1bb583 <= xb55b340ae3a3e4e0.Bottom);
				}
			}
			
			public static bool x9466a6be27202526 (Point x9c79b5ad7b769b12, Rectangle xb55b340ae3a3e4e0)
			
			/*
				// Code Size: 70 Bytes
				.maxstack 4
				L_0000: ldarga.s x9c79b5ad7b769b12
				L_0002: call System.Drawing.Point::Int32 get_X()
				L_0007: ldarga.s xb55b340ae3a3e4e0
				L_0009: call System.Drawing.Rectangle::Int32 get_Left()
				L_000e: blt.s L_0044
				L_0010: ldarga.s x9c79b5ad7b769b12
				L_0012: call System.Drawing.Point::Int32 get_X()
				L_0017: ldarga.s xb55b340ae3a3e4e0
				L_0019: call System.Drawing.Rectangle::Int32 get_Right()
				L_001e: bgt.s L_0044
				L_0020: ldarga.s x9c79b5ad7b769b12
				L_0022: call System.Drawing.Point::Int32 get_Y()
				L_0027: ldarga.s xb55b340ae3a3e4e0
				L_0029: call System.Drawing.Rectangle::Int32 get_Top()
				L_002e: blt.s L_0044
				L_0030: ldarga.s x9c79b5ad7b769b12
				L_0032: call System.Drawing.Point::Int32 get_Y()
				L_0037: ldarga.s xb55b340ae3a3e4e0
				L_0039: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_003e: cgt 
				L_0040: ldc.i4.0 
				L_0041: ceq 
				L_0043: ret 
				L_0044: ldc.i4.0 
				L_0045: ret 
			*/
			
			
			{
				if (x9c79b5ad7b769b12.X < xb55b340ae3a3e4e0.Left)
				{
					return false;
				}
				else if (x9c79b5ad7b769b12.X > xb55b340ae3a3e4e0.Right)
				{
					return false;
				}
				else if (x9c79b5ad7b769b12.Y < xb55b340ae3a3e4e0.Top)
				{
					return false;
				}
				else
				{
					return (x9c79b5ad7b769b12.Y <= xb55b340ae3a3e4e0.Bottom);
				}
			}
			
			public static bool x9466a6be27202526 (Point x9c79b5ad7b769b12, xae4dd1cafd2eb77c.RECT xb55b340ae3a3e4e0)
			
			/*
				// Code Size: 70 Bytes
				.maxstack 3
				L_0000: ldarga.s x9c79b5ad7b769b12
				L_0002: call System.Drawing.Point::Int32 get_X()
				L_0007: ldarga.s xb55b340ae3a3e4e0
				L_0009: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 left
				L_000e: blt.s L_0044
				L_0010: ldarga.s x9c79b5ad7b769b12
				L_0012: call System.Drawing.Point::Int32 get_X()
				L_0017: ldarga.s xb55b340ae3a3e4e0
				L_0019: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 right
				L_001e: bgt.s L_0044
				L_0020: ldarga.s x9c79b5ad7b769b12
				L_0022: call System.Drawing.Point::Int32 get_Y()
				L_0027: ldarga.s xb55b340ae3a3e4e0
				L_0029: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 top
				L_002e: blt.s L_0044
				L_0030: ldarga.s x9c79b5ad7b769b12
				L_0032: call System.Drawing.Point::Int32 get_Y()
				L_0037: ldarga.s xb55b340ae3a3e4e0
				L_0039: ldfld Sunisoft.IrisSkin.xae4dd1cafd2eb77c+RECT::Int32 bottom
				L_003e: cgt 
				L_0040: ldc.i4.0 
				L_0041: ceq 
				L_0043: ret 
				L_0044: ldc.i4.0 
				L_0045: ret 
			*/
			
			
			{
				if (x9c79b5ad7b769b12.X < xb55b340ae3a3e4e0.left)
				{
					return false;
				}
				else if (x9c79b5ad7b769b12.X > xb55b340ae3a3e4e0.right)
				{
					return false;
				}
				else if (x9c79b5ad7b769b12.Y < xb55b340ae3a3e4e0.top)
				{
					return false;
				}
				else
				{
					return (x9c79b5ad7b769b12.Y <= xb55b340ae3a3e4e0.bottom);
				}
			}
			
			public static void x9b7cda8516f8644e (ISkinEngine xdc87e2b99332cd4a, Graphics x4b101060f4767186, Rectangle xb55b340ae3a3e4e0, bool x5d6aaef53fbe3752)
			
			/*
				// Code Size: 2207 Bytes
				.maxstack 10
				.locals (System.Drawing.Bitmap V_0, 
         System.Drawing.Rectangle V_1, 
         System.Drawing.Rectangle V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Int32 V_5, 
         System.Int32 V_6, 
         System.Int32 V_7)
				L_0000: ldc.i4.0 
				L_0001: stloc.3 
				L_0002: ldarg.3 
				L_0003: brfalse.s L_0009
				L_0005: ldc.i4.0 
				L_0006: stloc.3 
				L_0007: br.s L_000b
				L_0009: ldc.i4.1 
				L_000a: stloc.3 
				L_000b: ldarg.3 
				L_000c: brfalse L_0453
				L_0011: ldarg.0 
				L_0012: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0017: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_001c: callvirt Sunisoft.IrisSkin.ScrollBarRes::Boolean get_IsMacOS()
				L_0021: brfalse.s L_0047
				L_0023: ldarga.s xb55b340ae3a3e4e0
				L_0025: call System.Drawing.Rectangle::Int32 get_Height()
				L_002a: ldc.i4.s 16
				L_002c: ble.s L_0047
				L_002e: ldarg.0 
				L_002f: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0034: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_0039: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_SCROLLBAR()
				L_003e: ldarg.1 
				L_003f: ldarg.2 
				L_0040: ldc.i4.0 
				L_0041: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void xa13cb59a95e21555(System.Drawing.Bitmap, System.Drawing.Graphics, System.Drawing.Rectangle, Boolean)
				L_0046: ret 
				L_0047: ldarg.0 
				L_0048: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_004d: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0052: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_0057: ldloc.3 
				L_0058: ldc.i4.0 
				L_0059: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_005e: stloc.0 
				L_005f: ldarga.s xb55b340ae3a3e4e0
				L_0061: call System.Drawing.Rectangle::Int32 get_Height()
				L_0066: ldloc.0 
				L_0067: callvirt System.Drawing.Image::Int32 get_Height()
				L_006c: ldc.i4.2 
				L_006d: mul 
				L_006e: bgt L_0111
				L_0073: ldloca.s V_1
				L_0075: ldc.i4.0 
				L_0076: ldc.i4.0 
				L_0077: ldloc.0 
				L_0078: callvirt System.Drawing.Image::Int32 get_Width()
				L_007d: ldloc.0 
				L_007e: callvirt System.Drawing.Image::Int32 get_Height()
				L_0083: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0088: ldloca.s V_2
				L_008a: ldarga.s xb55b340ae3a3e4e0
				L_008c: call System.Drawing.Rectangle::Int32 get_Left()
				L_0091: ldarga.s xb55b340ae3a3e4e0
				L_0093: call System.Drawing.Rectangle::Int32 get_Top()
				L_0098: ldarga.s xb55b340ae3a3e4e0
				L_009a: call System.Drawing.Rectangle::Int32 get_Width()
				L_009f: ldarga.s xb55b340ae3a3e4e0
				L_00a1: call System.Drawing.Rectangle::Int32 get_Height()
				L_00a6: ldc.i4.2 
				L_00a7: div 
				L_00a8: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00ad: ldarg.1 
				L_00ae: ldloc.0 
				L_00af: ldloc.2 
				L_00b0: ldloc.1 
				L_00b1: ldc.i4.2 
				L_00b2: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_00b7: ldarg.0 
				L_00b8: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_00bd: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_00c2: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_00c7: ldloc.3 
				L_00c8: ldc.i4.4 
				L_00c9: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_00ce: stloc.0 
				L_00cf: ldloca.s V_1
				L_00d1: ldc.i4.0 
				L_00d2: ldc.i4.0 
				L_00d3: ldloc.0 
				L_00d4: callvirt System.Drawing.Image::Int32 get_Width()
				L_00d9: ldloc.0 
				L_00da: callvirt System.Drawing.Image::Int32 get_Height()
				L_00df: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00e4: ldarga.s xb55b340ae3a3e4e0
				L_00e6: call System.Drawing.Rectangle::Int32 get_Left()
				L_00eb: ldloca.s V_2
				L_00ed: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_00f2: ldarga.s xb55b340ae3a3e4e0
				L_00f4: call System.Drawing.Rectangle::Int32 get_Right()
				L_00f9: ldarga.s xb55b340ae3a3e4e0
				L_00fb: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0100: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0105: stloc.2 
				L_0106: ldarg.1 
				L_0107: ldloc.0 
				L_0108: ldloc.2 
				L_0109: ldloc.1 
				L_010a: ldc.i4.2 
				L_010b: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0110: ret 
				L_0111: ldarga.s xb55b340ae3a3e4e0
				L_0113: call System.Drawing.Rectangle::Int32 get_Height()
				L_0118: ldloc.0 
				L_0119: callvirt System.Drawing.Image::Int32 get_Height()
				L_011e: ldc.i4.2 
				L_011f: mul 
				L_0120: ldarg.0 
				L_0121: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0126: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_012b: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_0130: ldloc.3 
				L_0131: ldc.i4.2 
				L_0132: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_0137: callvirt System.Drawing.Image::Int32 get_Height()
				L_013c: add 
				L_013d: bgt L_0245
				L_0142: ldloca.s V_1
				L_0144: ldc.i4.0 
				L_0145: ldc.i4.0 
				L_0146: ldloc.0 
				L_0147: callvirt System.Drawing.Image::Int32 get_Width()
				L_014c: ldloc.0 
				L_014d: callvirt System.Drawing.Image::Int32 get_Height()
				L_0152: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0157: ldloca.s V_2
				L_0159: ldarga.s xb55b340ae3a3e4e0
				L_015b: call System.Drawing.Rectangle::Int32 get_Left()
				L_0160: ldarga.s xb55b340ae3a3e4e0
				L_0162: call System.Drawing.Rectangle::Int32 get_Top()
				L_0167: ldarga.s xb55b340ae3a3e4e0
				L_0169: call System.Drawing.Rectangle::Int32 get_Width()
				L_016e: ldloc.0 
				L_016f: callvirt System.Drawing.Image::Int32 get_Height()
				L_0174: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0179: ldloca.s V_2
				L_017b: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0180: stloc.s V_4
				L_0182: ldarg.1 
				L_0183: ldloc.0 
				L_0184: ldloc.2 
				L_0185: ldloc.1 
				L_0186: ldc.i4.2 
				L_0187: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_018c: ldarg.0 
				L_018d: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0192: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0197: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_019c: ldloc.3 
				L_019d: ldc.i4.4 
				L_019e: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_01a3: stloc.0 
				L_01a4: ldloca.s V_1
				L_01a6: ldc.i4.0 
				L_01a7: ldc.i4.0 
				L_01a8: ldloc.0 
				L_01a9: callvirt System.Drawing.Image::Int32 get_Width()
				L_01ae: ldloc.0 
				L_01af: callvirt System.Drawing.Image::Int32 get_Height()
				L_01b4: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01b9: ldloca.s V_2
				L_01bb: ldarga.s xb55b340ae3a3e4e0
				L_01bd: call System.Drawing.Rectangle::Int32 get_Left()
				L_01c2: ldarga.s xb55b340ae3a3e4e0
				L_01c4: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_01c9: ldloc.0 
				L_01ca: callvirt System.Drawing.Image::Int32 get_Height()
				L_01cf: sub 
				L_01d0: ldarga.s xb55b340ae3a3e4e0
				L_01d2: call System.Drawing.Rectangle::Int32 get_Width()
				L_01d7: ldloc.0 
				L_01d8: callvirt System.Drawing.Image::Int32 get_Height()
				L_01dd: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_01e2: ldarg.1 
				L_01e3: ldloc.0 
				L_01e4: ldloc.2 
				L_01e5: ldloc.1 
				L_01e6: ldc.i4.2 
				L_01e7: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_01ec: ldloca.s V_2
				L_01ee: call System.Drawing.Rectangle::Int32 get_Top()
				L_01f3: stloc.s V_5
				L_01f5: ldarg.0 
				L_01f6: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_01fb: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0200: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_0205: ldloc.3 
				L_0206: ldc.i4.2 
				L_0207: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_020c: stloc.0 
				L_020d: ldarga.s xb55b340ae3a3e4e0
				L_020f: call System.Drawing.Rectangle::Int32 get_Left()
				L_0214: ldloc.s V_4
				L_0216: ldarga.s xb55b340ae3a3e4e0
				L_0218: call System.Drawing.Rectangle::Int32 get_Right()
				L_021d: ldloc.s V_5
				L_021f: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0224: stloc.2 
				L_0225: ldloca.s V_1
				L_0227: ldc.i4.0 
				L_0228: ldc.i4.0 
				L_0229: ldloc.0 
				L_022a: callvirt System.Drawing.Image::Int32 get_Width()
				L_022f: ldloc.0 
				L_0230: callvirt System.Drawing.Image::Int32 get_Height()
				L_0235: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_023a: ldarg.1 
				L_023b: ldloc.0 
				L_023c: ldloc.2 
				L_023d: ldloc.1 
				L_023e: ldc.i4.2 
				L_023f: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0244: ret 
				L_0245: ldloca.s V_1
				L_0247: ldc.i4.0 
				L_0248: ldc.i4.0 
				L_0249: ldloc.0 
				L_024a: callvirt System.Drawing.Image::Int32 get_Width()
				L_024f: ldloc.0 
				L_0250: callvirt System.Drawing.Image::Int32 get_Height()
				L_0255: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_025a: ldloca.s V_2
				L_025c: ldarga.s xb55b340ae3a3e4e0
				L_025e: call System.Drawing.Rectangle::Int32 get_Left()
				L_0263: ldarga.s xb55b340ae3a3e4e0
				L_0265: call System.Drawing.Rectangle::Int32 get_Top()
				L_026a: ldarga.s xb55b340ae3a3e4e0
				L_026c: call System.Drawing.Rectangle::Int32 get_Width()
				L_0271: ldloc.0 
				L_0272: callvirt System.Drawing.Image::Int32 get_Height()
				L_0277: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_027c: ldloca.s V_2
				L_027e: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0283: stloc.s V_4
				L_0285: ldarg.1 
				L_0286: ldloc.0 
				L_0287: ldloc.2 
				L_0288: ldloc.1 
				L_0289: ldc.i4.2 
				L_028a: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_028f: ldarg.0 
				L_0290: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0295: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_029a: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_029f: ldloc.3 
				L_02a0: ldc.i4.2 
				L_02a1: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_02a6: stloc.0 
				L_02a7: ldloca.s V_1
				L_02a9: ldc.i4.0 
				L_02aa: ldc.i4.0 
				L_02ab: ldloc.0 
				L_02ac: callvirt System.Drawing.Image::Int32 get_Width()
				L_02b1: ldloc.0 
				L_02b2: callvirt System.Drawing.Image::Int32 get_Height()
				L_02b7: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_02bc: ldloca.s V_2
				L_02be: ldarga.s xb55b340ae3a3e4e0
				L_02c0: call System.Drawing.Rectangle::Int32 get_Left()
				L_02c5: ldarga.s xb55b340ae3a3e4e0
				L_02c7: call System.Drawing.Rectangle::Int32 get_Top()
				L_02cc: ldarga.s xb55b340ae3a3e4e0
				L_02ce: call System.Drawing.Rectangle::Int32 get_Height()
				L_02d3: ldloc.0 
				L_02d4: callvirt System.Drawing.Image::Int32 get_Height()
				L_02d9: sub 
				L_02da: ldc.i4.2 
				L_02db: div 
				L_02dc: add 
				L_02dd: ldarga.s xb55b340ae3a3e4e0
				L_02df: call System.Drawing.Rectangle::Int32 get_Width()
				L_02e4: ldloc.0 
				L_02e5: callvirt System.Drawing.Image::Int32 get_Height()
				L_02ea: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_02ef: ldloca.s V_2
				L_02f1: call System.Drawing.Rectangle::Int32 get_Top()
				L_02f6: stloc.s V_5
				L_02f8: ldloca.s V_2
				L_02fa: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_02ff: stloc.s V_6
				L_0301: ldarg.1 
				L_0302: ldloc.0 
				L_0303: ldloc.2 
				L_0304: ldloc.1 
				L_0305: ldc.i4.2 
				L_0306: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_030b: ldarg.0 
				L_030c: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0311: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0316: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_031b: ldloc.3 
				L_031c: ldc.i4.4 
				L_031d: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_0322: stloc.0 
				L_0323: ldloca.s V_1
				L_0325: ldc.i4.0 
				L_0326: ldc.i4.0 
				L_0327: ldloc.0 
				L_0328: callvirt System.Drawing.Image::Int32 get_Width()
				L_032d: ldloc.0 
				L_032e: callvirt System.Drawing.Image::Int32 get_Height()
				L_0333: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0338: ldloca.s V_2
				L_033a: ldarga.s xb55b340ae3a3e4e0
				L_033c: call System.Drawing.Rectangle::Int32 get_Left()
				L_0341: ldarga.s xb55b340ae3a3e4e0
				L_0343: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0348: ldloc.0 
				L_0349: callvirt System.Drawing.Image::Int32 get_Height()
				L_034e: sub 
				L_034f: ldarga.s xb55b340ae3a3e4e0
				L_0351: call System.Drawing.Rectangle::Int32 get_Width()
				L_0356: ldloc.0 
				L_0357: callvirt System.Drawing.Image::Int32 get_Height()
				L_035c: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0361: ldloca.s V_2
				L_0363: call System.Drawing.Rectangle::Int32 get_Top()
				L_0368: stloc.s V_7
				L_036a: ldarg.1 
				L_036b: ldloc.0 
				L_036c: ldloc.2 
				L_036d: ldloc.1 
				L_036e: ldc.i4.2 
				L_036f: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0374: ldarg.0 
				L_0375: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_037a: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_037f: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_0384: ldloc.3 
				L_0385: ldc.i4.1 
				L_0386: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_038b: stloc.0 
				L_038c: ldloca.s V_1
				L_038e: ldc.i4.0 
				L_038f: ldc.i4.0 
				L_0390: ldloc.0 
				L_0391: callvirt System.Drawing.Image::Int32 get_Width()
				L_0396: ldloc.0 
				L_0397: callvirt System.Drawing.Image::Int32 get_Height()
				L_039c: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_03a1: ldarga.s xb55b340ae3a3e4e0
				L_03a3: call System.Drawing.Rectangle::Int32 get_Left()
				L_03a8: ldloc.s V_4
				L_03aa: ldarga.s xb55b340ae3a3e4e0
				L_03ac: call System.Drawing.Rectangle::Int32 get_Right()
				L_03b1: ldloc.s V_5
				L_03b3: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_03b8: stloc.2 
				L_03b9: ldarg.1 
				L_03ba: ldloc.0 
				L_03bb: ldloc.2 
				L_03bc: ldloca.s V_1
				L_03be: call System.Drawing.Rectangle::Int32 get_X()
				L_03c3: ldloca.s V_1
				L_03c5: call System.Drawing.Rectangle::Int32 get_Y()
				L_03ca: ldloca.s V_1
				L_03cc: call System.Drawing.Rectangle::Int32 get_Width()
				L_03d1: ldloca.s V_1
				L_03d3: call System.Drawing.Rectangle::Int32 get_Height()
				L_03d8: ldc.i4.2 
				L_03d9: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x349935d524988797()
				L_03de: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_03e3: ldarg.0 
				L_03e4: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_03e9: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_03ee: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_03f3: ldloc.3 
				L_03f4: ldc.i4.3 
				L_03f5: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_03fa: stloc.0 
				L_03fb: ldloca.s V_1
				L_03fd: ldc.i4.0 
				L_03fe: ldc.i4.0 
				L_03ff: ldloc.0 
				L_0400: callvirt System.Drawing.Image::Int32 get_Width()
				L_0405: ldloc.0 
				L_0406: callvirt System.Drawing.Image::Int32 get_Height()
				L_040b: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0410: ldarga.s xb55b340ae3a3e4e0
				L_0412: call System.Drawing.Rectangle::Int32 get_Left()
				L_0417: ldloc.s V_6
				L_0419: ldarga.s xb55b340ae3a3e4e0
				L_041b: call System.Drawing.Rectangle::Int32 get_Right()
				L_0420: ldloc.s V_7
				L_0422: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0427: stloc.2 
				L_0428: ldarg.1 
				L_0429: ldloc.0 
				L_042a: ldloc.2 
				L_042b: ldloca.s V_1
				L_042d: call System.Drawing.Rectangle::Int32 get_X()
				L_0432: ldloca.s V_1
				L_0434: call System.Drawing.Rectangle::Int32 get_Y()
				L_0439: ldloca.s V_1
				L_043b: call System.Drawing.Rectangle::Int32 get_Width()
				L_0440: ldloca.s V_1
				L_0442: call System.Drawing.Rectangle::Int32 get_Height()
				L_0447: ldc.i4.2 
				L_0448: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x349935d524988797()
				L_044d: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_0452: ret 
				L_0453: ldarg.0 
				L_0454: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0459: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_045e: callvirt Sunisoft.IrisSkin.ScrollBarRes::Boolean get_IsMacOS()
				L_0463: brfalse.s L_0489
				L_0465: ldarga.s xb55b340ae3a3e4e0
				L_0467: call System.Drawing.Rectangle::Int32 get_Width()
				L_046c: ldc.i4.s 16
				L_046e: ble.s L_0489
				L_0470: ldarg.0 
				L_0471: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0476: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.SkinBitmaps get_Bitmaps()
				L_047b: callvirt Sunisoft.IrisSkin.SkinBitmaps::System.Drawing.Bitmap get_SKIN2_SCROLLBAR()
				L_0480: ldarg.1 
				L_0481: ldarg.2 
				L_0482: ldc.i4.0 
				L_0483: call Sunisoft.IrisSkin.x448fd9ab43628c71::Void x6871065fdac2acd2(System.Drawing.Bitmap, System.Drawing.Graphics, System.Drawing.Rectangle, Boolean)
				L_0488: ret 
				L_0489: ldarg.0 
				L_048a: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_048f: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0494: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_0499: ldloc.3 
				L_049a: ldc.i4.0 
				L_049b: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_04a0: stloc.0 
				L_04a1: ldarga.s xb55b340ae3a3e4e0
				L_04a3: call System.Drawing.Rectangle::Int32 get_Width()
				L_04a8: ldloc.0 
				L_04a9: callvirt System.Drawing.Image::Int32 get_Width()
				L_04ae: ldc.i4.2 
				L_04af: mul 
				L_04b0: bgt L_0553
				L_04b5: ldloca.s V_1
				L_04b7: ldc.i4.0 
				L_04b8: ldc.i4.0 
				L_04b9: ldloc.0 
				L_04ba: callvirt System.Drawing.Image::Int32 get_Width()
				L_04bf: ldloc.0 
				L_04c0: callvirt System.Drawing.Image::Int32 get_Height()
				L_04c5: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_04ca: ldloca.s V_2
				L_04cc: ldarga.s xb55b340ae3a3e4e0
				L_04ce: call System.Drawing.Rectangle::Int32 get_Left()
				L_04d3: ldarga.s xb55b340ae3a3e4e0
				L_04d5: call System.Drawing.Rectangle::Int32 get_Top()
				L_04da: ldarga.s xb55b340ae3a3e4e0
				L_04dc: call System.Drawing.Rectangle::Int32 get_Width()
				L_04e1: ldc.i4.2 
				L_04e2: div 
				L_04e3: ldarga.s xb55b340ae3a3e4e0
				L_04e5: call System.Drawing.Rectangle::Int32 get_Height()
				L_04ea: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_04ef: ldarg.1 
				L_04f0: ldloc.0 
				L_04f1: ldloc.2 
				L_04f2: ldloc.1 
				L_04f3: ldc.i4.2 
				L_04f4: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_04f9: ldarg.0 
				L_04fa: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_04ff: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0504: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_0509: ldloc.3 
				L_050a: ldc.i4.4 
				L_050b: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_0510: stloc.0 
				L_0511: ldloca.s V_1
				L_0513: ldc.i4.0 
				L_0514: ldc.i4.0 
				L_0515: ldloc.0 
				L_0516: callvirt System.Drawing.Image::Int32 get_Width()
				L_051b: ldloc.0 
				L_051c: callvirt System.Drawing.Image::Int32 get_Height()
				L_0521: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0526: ldloca.s V_2
				L_0528: call System.Drawing.Rectangle::Int32 get_Right()
				L_052d: ldarga.s xb55b340ae3a3e4e0
				L_052f: call System.Drawing.Rectangle::Int32 get_Top()
				L_0534: ldarga.s xb55b340ae3a3e4e0
				L_0536: call System.Drawing.Rectangle::Int32 get_Right()
				L_053b: ldarga.s xb55b340ae3a3e4e0
				L_053d: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_0542: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0547: stloc.2 
				L_0548: ldarg.1 
				L_0549: ldloc.0 
				L_054a: ldloc.2 
				L_054b: ldloc.1 
				L_054c: ldc.i4.2 
				L_054d: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0552: ret 
				L_0553: ldarga.s xb55b340ae3a3e4e0
				L_0555: call System.Drawing.Rectangle::Int32 get_Width()
				L_055a: ldloc.0 
				L_055b: callvirt System.Drawing.Image::Int32 get_Width()
				L_0560: ldc.i4.2 
				L_0561: mul 
				L_0562: ldarg.0 
				L_0563: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0568: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_056d: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_0572: ldloc.3 
				L_0573: ldc.i4.2 
				L_0574: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_0579: callvirt System.Drawing.Image::Int32 get_Width()
				L_057e: add 
				L_057f: bgt L_0691
				L_0584: ldloca.s V_1
				L_0586: ldc.i4.0 
				L_0587: ldc.i4.0 
				L_0588: ldloc.0 
				L_0589: callvirt System.Drawing.Image::Int32 get_Width()
				L_058e: ldloc.0 
				L_058f: callvirt System.Drawing.Image::Int32 get_Height()
				L_0594: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0599: ldloca.s V_2
				L_059b: ldarga.s xb55b340ae3a3e4e0
				L_059d: call System.Drawing.Rectangle::Int32 get_Left()
				L_05a2: ldarga.s xb55b340ae3a3e4e0
				L_05a4: call System.Drawing.Rectangle::Int32 get_Top()
				L_05a9: ldloc.0 
				L_05aa: callvirt System.Drawing.Image::Int32 get_Width()
				L_05af: ldarga.s xb55b340ae3a3e4e0
				L_05b1: call System.Drawing.Rectangle::Int32 get_Height()
				L_05b6: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_05bb: ldloca.s V_2
				L_05bd: call System.Drawing.Rectangle::Int32 get_Right()
				L_05c2: stloc.s V_4
				L_05c4: ldarg.1 
				L_05c5: ldloc.0 
				L_05c6: ldloc.2 
				L_05c7: ldloc.1 
				L_05c8: ldc.i4.2 
				L_05c9: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_05ce: ldarg.0 
				L_05cf: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_05d4: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_05d9: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_05de: ldloc.3 
				L_05df: ldc.i4.4 
				L_05e0: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_05e5: stloc.0 
				L_05e6: ldloca.s V_1
				L_05e8: ldc.i4.0 
				L_05e9: ldc.i4.0 
				L_05ea: ldloc.0 
				L_05eb: callvirt System.Drawing.Image::Int32 get_Width()
				L_05f0: ldloc.0 
				L_05f1: callvirt System.Drawing.Image::Int32 get_Height()
				L_05f6: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_05fb: ldloca.s V_2
				L_05fd: ldarga.s xb55b340ae3a3e4e0
				L_05ff: call System.Drawing.Rectangle::Int32 get_Right()
				L_0604: ldloc.0 
				L_0605: callvirt System.Drawing.Image::Int32 get_Width()
				L_060a: sub 
				L_060b: ldarga.s xb55b340ae3a3e4e0
				L_060d: call System.Drawing.Rectangle::Int32 get_Top()
				L_0612: ldloc.0 
				L_0613: callvirt System.Drawing.Image::Int32 get_Width()
				L_0618: ldarga.s xb55b340ae3a3e4e0
				L_061a: call System.Drawing.Rectangle::Int32 get_Height()
				L_061f: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0624: ldarg.1 
				L_0625: ldloc.0 
				L_0626: ldloc.2 
				L_0627: ldloc.1 
				L_0628: ldc.i4.2 
				L_0629: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_062e: ldloca.s V_2
				L_0630: call System.Drawing.Rectangle::Int32 get_Left()
				L_0635: stloc.s V_5
				L_0637: ldarg.1 
				L_0638: ldloc.0 
				L_0639: ldloc.2 
				L_063a: ldloc.1 
				L_063b: ldc.i4.2 
				L_063c: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0641: ldarg.0 
				L_0642: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0647: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_064c: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_0651: ldloc.3 
				L_0652: ldc.i4.2 
				L_0653: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_0658: stloc.0 
				L_0659: ldloc.s V_4
				L_065b: ldarga.s xb55b340ae3a3e4e0
				L_065d: call System.Drawing.Rectangle::Int32 get_Top()
				L_0662: ldloc.s V_5
				L_0664: ldarga.s xb55b340ae3a3e4e0
				L_0666: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_066b: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0670: stloc.2 
				L_0671: ldloca.s V_1
				L_0673: ldc.i4.0 
				L_0674: ldc.i4.0 
				L_0675: ldloc.0 
				L_0676: callvirt System.Drawing.Image::Int32 get_Width()
				L_067b: ldloc.0 
				L_067c: callvirt System.Drawing.Image::Int32 get_Height()
				L_0681: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0686: ldarg.1 
				L_0687: ldloc.0 
				L_0688: ldloc.2 
				L_0689: ldloc.1 
				L_068a: ldc.i4.2 
				L_068b: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0690: ret 
				L_0691: ldloca.s V_1
				L_0693: ldc.i4.0 
				L_0694: ldc.i4.0 
				L_0695: ldloc.0 
				L_0696: callvirt System.Drawing.Image::Int32 get_Width()
				L_069b: ldloc.0 
				L_069c: callvirt System.Drawing.Image::Int32 get_Height()
				L_06a1: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_06a6: ldloca.s V_2
				L_06a8: ldarga.s xb55b340ae3a3e4e0
				L_06aa: call System.Drawing.Rectangle::Int32 get_Left()
				L_06af: ldarga.s xb55b340ae3a3e4e0
				L_06b1: call System.Drawing.Rectangle::Int32 get_Top()
				L_06b6: ldloc.0 
				L_06b7: callvirt System.Drawing.Image::Int32 get_Width()
				L_06bc: ldarga.s xb55b340ae3a3e4e0
				L_06be: call System.Drawing.Rectangle::Int32 get_Height()
				L_06c3: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_06c8: ldloca.s V_2
				L_06ca: call System.Drawing.Rectangle::Int32 get_Right()
				L_06cf: stloc.s V_4
				L_06d1: ldarg.1 
				L_06d2: ldloc.0 
				L_06d3: ldloc.2 
				L_06d4: ldloc.1 
				L_06d5: ldc.i4.2 
				L_06d6: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_06db: ldarg.0 
				L_06dc: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_06e1: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_06e6: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_06eb: ldloc.3 
				L_06ec: ldc.i4.2 
				L_06ed: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_06f2: stloc.0 
				L_06f3: ldloca.s V_1
				L_06f5: ldc.i4.0 
				L_06f6: ldc.i4.0 
				L_06f7: ldloc.0 
				L_06f8: callvirt System.Drawing.Image::Int32 get_Width()
				L_06fd: ldloc.0 
				L_06fe: callvirt System.Drawing.Image::Int32 get_Height()
				L_0703: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0708: ldloca.s V_2
				L_070a: ldarga.s xb55b340ae3a3e4e0
				L_070c: call System.Drawing.Rectangle::Int32 get_Left()
				L_0711: ldarga.s xb55b340ae3a3e4e0
				L_0713: call System.Drawing.Rectangle::Int32 get_Width()
				L_0718: ldloc.0 
				L_0719: callvirt System.Drawing.Image::Int32 get_Width()
				L_071e: sub 
				L_071f: ldc.i4.2 
				L_0720: div 
				L_0721: add 
				L_0722: ldarga.s xb55b340ae3a3e4e0
				L_0724: call System.Drawing.Rectangle::Int32 get_Top()
				L_0729: ldloc.0 
				L_072a: callvirt System.Drawing.Image::Int32 get_Width()
				L_072f: ldarga.s xb55b340ae3a3e4e0
				L_0731: call System.Drawing.Rectangle::Int32 get_Height()
				L_0736: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_073b: ldloca.s V_2
				L_073d: call System.Drawing.Rectangle::Int32 get_Left()
				L_0742: stloc.s V_5
				L_0744: ldloca.s V_2
				L_0746: call System.Drawing.Rectangle::Int32 get_Right()
				L_074b: stloc.s V_6
				L_074d: ldarg.1 
				L_074e: ldloc.0 
				L_074f: ldloc.2 
				L_0750: ldloc.1 
				L_0751: ldc.i4.2 
				L_0752: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0757: ldarg.0 
				L_0758: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_075d: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_0762: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_0767: ldloc.3 
				L_0768: ldc.i4.4 
				L_0769: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_076e: stloc.0 
				L_076f: ldloca.s V_1
				L_0771: ldc.i4.0 
				L_0772: ldc.i4.0 
				L_0773: ldloc.0 
				L_0774: callvirt System.Drawing.Image::Int32 get_Width()
				L_0779: ldloc.0 
				L_077a: callvirt System.Drawing.Image::Int32 get_Height()
				L_077f: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0784: ldloca.s V_2
				L_0786: ldarga.s xb55b340ae3a3e4e0
				L_0788: call System.Drawing.Rectangle::Int32 get_Right()
				L_078d: ldloc.0 
				L_078e: callvirt System.Drawing.Image::Int32 get_Width()
				L_0793: sub 
				L_0794: ldarga.s xb55b340ae3a3e4e0
				L_0796: call System.Drawing.Rectangle::Int32 get_Top()
				L_079b: ldloc.0 
				L_079c: callvirt System.Drawing.Image::Int32 get_Width()
				L_07a1: ldarga.s xb55b340ae3a3e4e0
				L_07a3: call System.Drawing.Rectangle::Int32 get_Height()
				L_07a8: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_07ad: ldloca.s V_2
				L_07af: call System.Drawing.Rectangle::Int32 get_Left()
				L_07b4: stloc.s V_7
				L_07b6: ldarg.1 
				L_07b7: ldloc.0 
				L_07b8: ldloc.2 
				L_07b9: ldloc.1 
				L_07ba: ldc.i4.2 
				L_07bb: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_07c0: ldarg.0 
				L_07c1: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_07c6: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_07cb: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_07d0: ldloc.3 
				L_07d1: ldc.i4.1 
				L_07d2: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_07d7: stloc.0 
				L_07d8: ldloca.s V_1
				L_07da: ldc.i4.0 
				L_07db: ldc.i4.0 
				L_07dc: ldloc.0 
				L_07dd: callvirt System.Drawing.Image::Int32 get_Width()
				L_07e2: ldloc.0 
				L_07e3: callvirt System.Drawing.Image::Int32 get_Height()
				L_07e8: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_07ed: ldloc.s V_4
				L_07ef: ldarga.s xb55b340ae3a3e4e0
				L_07f1: call System.Drawing.Rectangle::Int32 get_Top()
				L_07f6: ldloc.s V_5
				L_07f8: ldarga.s xb55b340ae3a3e4e0
				L_07fa: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_07ff: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0804: stloc.2 
				L_0805: ldarg.1 
				L_0806: ldloc.0 
				L_0807: ldloc.2 
				L_0808: ldloca.s V_1
				L_080a: call System.Drawing.Rectangle::Int32 get_X()
				L_080f: ldloca.s V_1
				L_0811: call System.Drawing.Rectangle::Int32 get_Y()
				L_0816: ldloca.s V_1
				L_0818: call System.Drawing.Rectangle::Int32 get_Width()
				L_081d: ldloca.s V_1
				L_081f: call System.Drawing.Rectangle::Int32 get_Height()
				L_0824: ldc.i4.2 
				L_0825: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x8da407ebcbbfe204()
				L_082a: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_082f: ldarg.0 
				L_0830: callvirt Sunisoft.IrisSkin.SkinEngine::Sunisoft.IrisSkin.Res get_Res()
				L_0835: callvirt Sunisoft.IrisSkin.Res::Sunisoft.IrisSkin.ScrollBarRes get_ScrollBarRes()
				L_083a: callvirt Sunisoft.IrisSkin.ScrollBarRes::System.Drawing.Bitmap[,] get_Slider()
				L_083f: ldloc.3 
				L_0840: ldc.i4.3 
				L_0841: call System.Drawing.Bitmap[,]::System.Drawing.Bitmap Get(Int32, Int32)
				L_0846: stloc.0 
				L_0847: ldloca.s V_1
				L_0849: ldc.i4.0 
				L_084a: ldc.i4.0 
				L_084b: ldloc.0 
				L_084c: callvirt System.Drawing.Image::Int32 get_Width()
				L_0851: ldloc.0 
				L_0852: callvirt System.Drawing.Image::Int32 get_Height()
				L_0857: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_085c: ldloc.s V_6
				L_085e: ldarga.s xb55b340ae3a3e4e0
				L_0860: call System.Drawing.Rectangle::Int32 get_Top()
				L_0865: ldloc.s V_7
				L_0867: ldarga.s xb55b340ae3a3e4e0
				L_0869: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_086e: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_0873: stloc.2 
				L_0874: ldarg.1 
				L_0875: ldloc.0 
				L_0876: ldloc.2 
				L_0877: ldloca.s V_1
				L_0879: call System.Drawing.Rectangle::Int32 get_X()
				L_087e: ldloca.s V_1
				L_0880: call System.Drawing.Rectangle::Int32 get_Y()
				L_0885: ldloca.s V_1
				L_0887: call System.Drawing.Rectangle::Int32 get_Width()
				L_088c: ldloca.s V_1
				L_088e: call System.Drawing.Rectangle::Int32 get_Height()
				L_0893: ldc.i4.2 
				L_0894: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x8da407ebcbbfe204()
				L_0899: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes)
				L_089e: ret 
			*/
			
			
			{
				Bitmap bitmap1;
				Rectangle rectangle1;
				Rectangle rectangle2;
				int i1;
				int i2;
				int i3;
				int i4;
				int i5;
				if (x5d6aaef53fbe3752)
				{
					i1 = 0;
				}
				else
				{
					i1 = 1;
				}
				if (x5d6aaef53fbe3752)
				{
					if (((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.IsMacOS && (xb55b340ae3a3e4e0.Height > 16))
					{
						x448fd9ab43628c71.xa13cb59a95e21555 (((SkinBitmaps) ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_SCROLLBAR, x4b101060f4767186, xb55b340ae3a3e4e0, false);
					}
					else
					{
						bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 0];
						if (xb55b340ae3a3e4e0.Height <= (bitmap1.Height * 2))
						{
							rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
							rectangle2 = new Rectangle (xb55b340ae3a3e4e0.Left, xb55b340ae3a3e4e0.Top, xb55b340ae3a3e4e0.Width, ((int) (xb55b340ae3a3e4e0.Height / 2)));
							x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
							bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 4];
							rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
							rectangle2 = Rectangle.FromLTRB (xb55b340ae3a3e4e0.Left, rectangle2.Bottom, xb55b340ae3a3e4e0.Right, xb55b340ae3a3e4e0.Bottom);
							x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
						}
						else if (xb55b340ae3a3e4e0.Height <= ((bitmap1.Height * 2) + ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 2].Height))
						{
							rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
							rectangle2 = new Rectangle (xb55b340ae3a3e4e0.Left, xb55b340ae3a3e4e0.Top, xb55b340ae3a3e4e0.Width, bitmap1.Height);
							i2 = rectangle2.Bottom;
							x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
							bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 4];
							rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
							rectangle2 = new Rectangle (xb55b340ae3a3e4e0.Left, ((int) (xb55b340ae3a3e4e0.Bottom - bitmap1.Height)), xb55b340ae3a3e4e0.Width, bitmap1.Height);
							x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
							i3 = rectangle2.Top;
							bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 2];
							rectangle2 = Rectangle.FromLTRB (xb55b340ae3a3e4e0.Left, i2, xb55b340ae3a3e4e0.Right, i3);
							rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
							x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
						}
						else
						{
							rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
							rectangle2 = new Rectangle (xb55b340ae3a3e4e0.Left, xb55b340ae3a3e4e0.Top, xb55b340ae3a3e4e0.Width, bitmap1.Height);
							i2 = rectangle2.Bottom;
							x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
							bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 2];
							rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
							rectangle2 = new Rectangle (xb55b340ae3a3e4e0.Left, ((int) (xb55b340ae3a3e4e0.Top + ((xb55b340ae3a3e4e0.Height - bitmap1.Height) / 2))), xb55b340ae3a3e4e0.Width, bitmap1.Height);
							i3 = rectangle2.Top;
							i4 = rectangle2.Bottom;
							x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
							bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 4];
							rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
							rectangle2 = new Rectangle (xb55b340ae3a3e4e0.Left, ((int) (xb55b340ae3a3e4e0.Bottom - bitmap1.Height)), xb55b340ae3a3e4e0.Width, bitmap1.Height);
							i5 = rectangle2.Top;
							x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
							bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 1];
							rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
							rectangle2 = Rectangle.FromLTRB (xb55b340ae3a3e4e0.Left, i2, xb55b340ae3a3e4e0.Right, i3);
							x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1.X, rectangle1.Y, rectangle1.Width, rectangle1.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x349935d524988797);
							bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 3];
							rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
							rectangle2 = Rectangle.FromLTRB (xb55b340ae3a3e4e0.Left, i4, xb55b340ae3a3e4e0.Right, i5);
							x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1.X, rectangle1.Y, rectangle1.Width, rectangle1.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x349935d524988797);
						}
					}
				}
				else if (((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.IsMacOS && (xb55b340ae3a3e4e0.Width > 16))
				{
					x448fd9ab43628c71.x6871065fdac2acd2 (((SkinBitmaps) ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).Bitmaps).SKIN2_SCROLLBAR, x4b101060f4767186, xb55b340ae3a3e4e0, false);
				}
				else
				{
					bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 0];
					if (xb55b340ae3a3e4e0.Width <= (bitmap1.Width * 2))
					{
						rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						rectangle2 = new Rectangle (xb55b340ae3a3e4e0.Left, xb55b340ae3a3e4e0.Top, ((int) (xb55b340ae3a3e4e0.Width / 2)), xb55b340ae3a3e4e0.Height);
						x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
						bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 4];
						rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						rectangle2 = Rectangle.FromLTRB (rectangle2.Right, xb55b340ae3a3e4e0.Top, xb55b340ae3a3e4e0.Right, xb55b340ae3a3e4e0.Bottom);
						x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
					}
					else if (xb55b340ae3a3e4e0.Width <= ((bitmap1.Width * 2) + ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 2].Width))
					{
						rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						rectangle2 = new Rectangle (xb55b340ae3a3e4e0.Left, xb55b340ae3a3e4e0.Top, bitmap1.Width, xb55b340ae3a3e4e0.Height);
						i2 = rectangle2.Right;
						x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
						bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 4];
						rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						rectangle2 = new Rectangle (((int) (xb55b340ae3a3e4e0.Right - bitmap1.Width)), xb55b340ae3a3e4e0.Top, bitmap1.Width, xb55b340ae3a3e4e0.Height);
						x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
						i3 = rectangle2.Left;
						x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
						bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 2];
						rectangle2 = Rectangle.FromLTRB (i2, xb55b340ae3a3e4e0.Top, i3, xb55b340ae3a3e4e0.Bottom);
						rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
					}
					else
					{
						rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						rectangle2 = new Rectangle (xb55b340ae3a3e4e0.Left, xb55b340ae3a3e4e0.Top, bitmap1.Width, xb55b340ae3a3e4e0.Height);
						i2 = rectangle2.Right;
						x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
						bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 2];
						rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						rectangle2 = new Rectangle (((int) (xb55b340ae3a3e4e0.Left + ((xb55b340ae3a3e4e0.Width - bitmap1.Width) / 2))), xb55b340ae3a3e4e0.Top, bitmap1.Width, xb55b340ae3a3e4e0.Height);
						i3 = rectangle2.Left;
						i4 = rectangle2.Right;
						x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
						bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 4];
						rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						rectangle2 = new Rectangle (((int) (xb55b340ae3a3e4e0.Right - bitmap1.Width)), xb55b340ae3a3e4e0.Top, bitmap1.Width, xb55b340ae3a3e4e0.Height);
						i5 = rectangle2.Left;
						x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1, GraphicsUnit.Pixel);
						bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 1];
						rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						rectangle2 = Rectangle.FromLTRB (i2, xb55b340ae3a3e4e0.Top, i3, xb55b340ae3a3e4e0.Bottom);
						x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1.X, rectangle1.Y, rectangle1.Width, rectangle1.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x8da407ebcbbfe204);
						bitmap1 = ((Res) ((SkinEngine) xdc87e2b99332cd4a).Res).ScrollBarRes.Slider[i1, 3];
						rectangle1 = new Rectangle (0, 0, bitmap1.Width, bitmap1.Height);
						rectangle2 = Rectangle.FromLTRB (i4, xb55b340ae3a3e4e0.Top, i5, xb55b340ae3a3e4e0.Bottom);
						x4b101060f4767186.DrawImage (((Image) bitmap1), rectangle2, rectangle1.X, rectangle1.Y, rectangle1.Width, rectangle1.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x8da407ebcbbfe204);
					}
				}
			}
			
			public static void x9f15416be9fc7b48 (Graphics x4b101060f4767186, int x08db3aeabb253cb1, int x1e218ceaee1bb583, bool x2fef7d841879a711)
			
			/*
				// Code Size: 149 Bytes
				.maxstack 5
				.locals (System.Drawing.Brush V_0, 
         System.Drawing.Point[] V_1)
				L_0000: ldc.i4.3 
				L_0001: newarr System.Drawing.Point
				L_0006: stloc.1 
				L_0007: ldarg.3 
				L_0008: brtrue.s L_0056
				L_000a: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_000f: stloc.0 
				L_0010: ldloc.1 
				L_0011: ldc.i4.0 
				L_0012: ldelema System.Drawing.Point
				L_0017: ldarg.1 
				L_0018: ldc.i4.1 
				L_0019: add 
				L_001a: ldarg.2 
				L_001b: ldc.i4.1 
				L_001c: add 
				L_001d: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0022: ldloc.1 
				L_0023: ldc.i4.1 
				L_0024: ldelema System.Drawing.Point
				L_0029: ldarg.1 
				L_002a: ldc.i4.1 
				L_002b: add 
				L_002c: ldarg.2 
				L_002d: ldc.i4.7 
				L_002e: add 
				L_002f: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0034: ldloc.1 
				L_0035: ldc.i4.2 
				L_0036: ldelema System.Drawing.Point
				L_003b: ldarg.1 
				L_003c: ldc.i4.4 
				L_003d: add 
				L_003e: ldarg.2 
				L_003f: ldc.i4.4 
				L_0040: add 
				L_0041: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0046: ldarg.0 
				L_0047: ldloc.0 
				L_0048: ldloc.1 
				L_0049: callvirt System.Drawing.Graphics::Void FillPolygon(System.Drawing.Brush, System.Drawing.Point[])
				L_004e: call System.Drawing.Brushes::System.Drawing.Brush get_Gray()
				L_0053: stloc.0 
				L_0054: br.s L_005c
				L_0056: call System.Drawing.Brushes::System.Drawing.Brush get_Black()
				L_005b: stloc.0 
				L_005c: ldloc.1 
				L_005d: ldc.i4.0 
				L_005e: ldelema System.Drawing.Point
				L_0063: ldarg.1 
				L_0064: ldarg.2 
				L_0065: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_006a: ldloc.1 
				L_006b: ldc.i4.1 
				L_006c: ldelema System.Drawing.Point
				L_0071: ldarg.1 
				L_0072: ldarg.2 
				L_0073: ldc.i4.6 
				L_0074: add 
				L_0075: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_007a: ldloc.1 
				L_007b: ldc.i4.2 
				L_007c: ldelema System.Drawing.Point
				L_0081: ldarg.1 
				L_0082: ldc.i4.3 
				L_0083: add 
				L_0084: ldarg.2 
				L_0085: ldc.i4.3 
				L_0086: add 
				L_0087: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_008c: ldarg.0 
				L_008d: ldloc.0 
				L_008e: ldloc.1 
				L_008f: callvirt System.Drawing.Graphics::Void FillPolygon(System.Drawing.Brush, System.Drawing.Point[])
				L_0094: ret 
			*/
			
			
			{
				Brush brush1;
				Point[] pointArray1 = new Point[3];
				if (! x2fef7d841879a711)
				{
					brush1 = Brushes.White;
					pointArray1[0] = new Point (((int) (x08db3aeabb253cb1 + 1)), ((int) (x1e218ceaee1bb583 + 1)));
					pointArray1[1] = new Point (((int) (x08db3aeabb253cb1 + 1)), ((int) (x1e218ceaee1bb583 + 7)));
					pointArray1[2] = new Point (((int) (x08db3aeabb253cb1 + 4)), ((int) (x1e218ceaee1bb583 + 4)));
					x4b101060f4767186.FillPolygon (brush1, pointArray1);
					brush1 = Brushes.Gray;
				}
				else
				{
					brush1 = Brushes.Black;
				}
				pointArray1[0] = new Point (x08db3aeabb253cb1, x1e218ceaee1bb583);
				pointArray1[1] = new Point (x08db3aeabb253cb1, ((int) (x1e218ceaee1bb583 + 6)));
				pointArray1[2] = new Point (((int) (x08db3aeabb253cb1 + 3)), ((int) (x1e218ceaee1bb583 + 3)));
				x4b101060f4767186.FillPolygon (brush1, pointArray1);
			}
			
			public static void xa13cb59a95e21555 (Bitmap x5ce6bc2fb6fe458d, Graphics x4b101060f4767186, Rectangle xb55b340ae3a3e4e0, bool x6b1f74d7e9186472)
			
			/*
				// Code Size: 334 Bytes
				.maxstack 11
				.locals (System.Drawing.Rectangle V_0, 
         System.Drawing.Rectangle V_1, 
         System.Int32 V_2)
				L_0000: ldarg.0 
				L_0001: callvirt System.Drawing.Image::Int32 get_Height()
				L_0006: ldc.i4.3 
				L_0007: div 
				L_0008: stloc.2 
				L_0009: ldloc.2 
				L_000a: ldarga.s xb55b340ae3a3e4e0
				L_000c: call System.Drawing.Rectangle::Int32 get_Height()
				L_0011: ble.s L_0075
				L_0013: ldloca.s V_0
				L_0015: ldc.i4.0 
				L_0016: ldc.i4.0 
				L_0017: ldarg.0 
				L_0018: callvirt System.Drawing.Image::Int32 get_Width()
				L_001d: ldarg.0 
				L_001e: callvirt System.Drawing.Image::Int32 get_Height()
				L_0023: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0028: ldarg.2 
				L_0029: stloc.1 
				L_002a: ldarg.1 
				L_002b: ldarg.0 
				L_002c: ldloc.1 
				L_002d: ldloc.0 
				L_002e: ldc.i4.2 
				L_002f: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0034: ldloca.s V_0
				L_0036: ldc.i4.0 
				L_0037: ldarg.0 
				L_0038: callvirt System.Drawing.Image::Int32 get_Height()
				L_003d: ldc.i4.2 
				L_003e: sub 
				L_003f: ldarg.0 
				L_0040: callvirt System.Drawing.Image::Int32 get_Width()
				L_0045: ldc.i4.2 
				L_0046: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_004b: ldloca.s V_1
				L_004d: ldarga.s xb55b340ae3a3e4e0
				L_004f: call System.Drawing.Rectangle::Int32 get_Left()
				L_0054: ldarga.s xb55b340ae3a3e4e0
				L_0056: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_005b: ldc.i4.2 
				L_005c: sub 
				L_005d: ldarga.s xb55b340ae3a3e4e0
				L_005f: call System.Drawing.Rectangle::Int32 get_Width()
				L_0064: ldc.i4.2 
				L_0065: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_006a: ldarg.1 
				L_006b: ldarg.0 
				L_006c: ldloc.1 
				L_006d: ldloc.0 
				L_006e: ldc.i4.2 
				L_006f: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_0074: ret 
				L_0075: ldloca.s V_1
				L_0077: ldarga.s xb55b340ae3a3e4e0
				L_0079: call System.Drawing.Rectangle::Int32 get_X()
				L_007e: ldarga.s xb55b340ae3a3e4e0
				L_0080: call System.Drawing.Rectangle::Int32 get_Y()
				L_0085: ldarga.s xb55b340ae3a3e4e0
				L_0087: call System.Drawing.Rectangle::Int32 get_Width()
				L_008c: ldloc.2 
				L_008d: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0092: ldloca.s V_0
				L_0094: ldc.i4.0 
				L_0095: ldc.i4.0 
				L_0096: ldarg.0 
				L_0097: callvirt System.Drawing.Image::Int32 get_Width()
				L_009c: ldloc.2 
				L_009d: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00a2: ldarg.1 
				L_00a3: ldarg.0 
				L_00a4: ldloc.1 
				L_00a5: ldloc.0 
				L_00a6: ldc.i4.2 
				L_00a7: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_00ac: ldarga.s xb55b340ae3a3e4e0
				L_00ae: call System.Drawing.Rectangle::Int32 get_X()
				L_00b3: ldarga.s xb55b340ae3a3e4e0
				L_00b5: call System.Drawing.Rectangle::Int32 get_Y()
				L_00ba: ldloc.2 
				L_00bb: add 
				L_00bc: ldarga.s xb55b340ae3a3e4e0
				L_00be: call System.Drawing.Rectangle::Int32 get_Right()
				L_00c3: ldarga.s xb55b340ae3a3e4e0
				L_00c5: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_00ca: ldloc.2 
				L_00cb: sub 
				L_00cc: call System.Drawing.Rectangle::System.Drawing.Rectangle FromLTRB(Int32, Int32, Int32, Int32)
				L_00d1: stloc.1 
				L_00d2: ldloca.s V_0
				L_00d4: ldc.i4.0 
				L_00d5: ldloc.2 
				L_00d6: ldarg.0 
				L_00d7: callvirt System.Drawing.Image::Int32 get_Width()
				L_00dc: ldloc.2 
				L_00dd: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_00e2: ldarg.1 
				L_00e3: ldarg.0 
				L_00e4: ldloc.1 
				L_00e5: ldloca.s V_0
				L_00e7: call System.Drawing.Rectangle::Int32 get_X()
				L_00ec: ldloca.s V_0
				L_00ee: call System.Drawing.Rectangle::Int32 get_Y()
				L_00f3: ldloca.s V_0
				L_00f5: call System.Drawing.Rectangle::Int32 get_Width()
				L_00fa: ldloca.s V_0
				L_00fc: call System.Drawing.Rectangle::Int32 get_Height()
				L_0101: ldc.i4.2 
				L_0102: call Sunisoft.IrisSkin.x448fd9ab43628c71::System.Drawing.Imaging.ImageAttributes get_x8da407ebcbbfe204()
				L_0107: ldnull 
				L_0108: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, Int32, Int32, Int32, Int32, System.Drawing.GraphicsUnit, System.Drawing.Imaging.ImageAttributes, DrawImageAbort)
				L_010d: ldloca.s V_1
				L_010f: ldarga.s xb55b340ae3a3e4e0
				L_0111: call System.Drawing.Rectangle::Int32 get_X()
				L_0116: ldarga.s xb55b340ae3a3e4e0
				L_0118: call System.Drawing.Rectangle::Int32 get_Bottom()
				L_011d: ldloc.2 
				L_011e: sub 
				L_011f: ldarga.s xb55b340ae3a3e4e0
				L_0121: call System.Drawing.Rectangle::Int32 get_Width()
				L_0126: ldloc.2 
				L_0127: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_012c: ldloca.s V_0
				L_012e: ldc.i4.0 
				L_012f: ldarg.0 
				L_0130: callvirt System.Drawing.Image::Int32 get_Height()
				L_0135: ldloc.2 
				L_0136: sub 
				L_0137: ldarg.0 
				L_0138: callvirt System.Drawing.Image::Int32 get_Width()
				L_013d: ldloc.2 
				L_013e: call System.Drawing.Rectangle::Void .ctor(Int32, Int32, Int32, Int32)
				L_0143: ldarg.1 
				L_0144: ldarg.0 
				L_0145: ldloc.1 
				L_0146: ldloc.0 
				L_0147: ldc.i4.2 
				L_0148: callvirt System.Drawing.Graphics::Void DrawImage(System.Drawing.Image, System.Drawing.Rectangle, System.Drawing.Rectangle, System.Drawing.GraphicsUnit)
				L_014d: ret 
			*/
			
			
			{
				Rectangle rectangle1;
				Rectangle rectangle2;
				int i1 = (x5ce6bc2fb6fe458d.Height / 3);
				if (i1 > xb55b340ae3a3e4e0.Height)
				{
					rectangle1 = new Rectangle (0, 0, x5ce6bc2fb6fe458d.Width, x5ce6bc2fb6fe458d.Height);
					rectangle2 = xb55b340ae3a3e4e0;
					x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), rectangle2, rectangle1, GraphicsUnit.Pixel);
					rectangle1 = new Rectangle (0, ((int) (x5ce6bc2fb6fe458d.Height - 2)), x5ce6bc2fb6fe458d.Width, 2);
					rectangle2 = new Rectangle (xb55b340ae3a3e4e0.Left, ((int) (xb55b340ae3a3e4e0.Bottom - 2)), xb55b340ae3a3e4e0.Width, 2);
					x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), rectangle2, rectangle1, GraphicsUnit.Pixel);
				}
				else
				{
					rectangle2 = new Rectangle (xb55b340ae3a3e4e0.X, xb55b340ae3a3e4e0.Y, xb55b340ae3a3e4e0.Width, i1);
					rectangle1 = new Rectangle (0, 0, x5ce6bc2fb6fe458d.Width, i1);
					x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), rectangle2, rectangle1, GraphicsUnit.Pixel);
					rectangle2 = Rectangle.FromLTRB (xb55b340ae3a3e4e0.X, ((int) (xb55b340ae3a3e4e0.Y + i1)), xb55b340ae3a3e4e0.Right, ((int) (xb55b340ae3a3e4e0.Bottom - i1)));
					rectangle1 = new Rectangle (0, i1, x5ce6bc2fb6fe458d.Width, i1);
					x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), rectangle2, rectangle1.X, rectangle1.Y, rectangle1.Width, rectangle1.Height, GraphicsUnit.Pixel, x448fd9ab43628c71.x8da407ebcbbfe204, ((Graphics.DrawImageAbort) null));
					rectangle2 = new Rectangle (xb55b340ae3a3e4e0.X, ((int) (xb55b340ae3a3e4e0.Bottom - i1)), xb55b340ae3a3e4e0.Width, i1);
					rectangle1 = new Rectangle (0, ((int) (x5ce6bc2fb6fe458d.Height - i1)), x5ce6bc2fb6fe458d.Width, i1);
					x4b101060f4767186.DrawImage (((Image) x5ce6bc2fb6fe458d), rectangle2, rectangle1, GraphicsUnit.Pixel);
				}
			}
			
			public static StringFormat xa273b3daf9e47b9b (ContentAlignment x7717e14a55110734, Control x43bec302f92080b9)
			
			/*
				// Code Size: 308 Bytes
				.maxstack 3
				.locals (System.Drawing.StringFormat V_0, 
         System.Drawing.ContentAlignment V_1)
				L_0000: newobj System.Drawing.StringFormat::Void .ctor()
				L_0005: stloc.0 
				L_0006: ldarg.1 
				L_0007: callvirt System.Windows.Forms.Control::System.Windows.Forms.RightToLeft get_RightToLeft()
				L_000c: ldc.i4.1 
				L_000d: and 
				L_000e: ldc.i4.1 
				L_000f: bne.un.s L_0018
				L_0011: ldloc.0 
				L_0012: ldc.i4.1 
				L_0013: callvirt System.Drawing.StringFormat::Void set_FormatFlags(System.Drawing.StringFormatFlags)
				L_0018: ldloc.0 
				L_0019: ldc.i4.1 
				L_001a: callvirt System.Drawing.StringFormat::Void set_HotkeyPrefix(System.Drawing.Text.HotkeyPrefix)
				L_001f: ldarg.0 
				L_0020: stloc.1 
				L_0021: ldloc.1 
				L_0022: ldc.i4.s 32
				L_0024: bgt.s L_0053
				L_0026: ldloc.1 
				L_0027: ldc.i4.1 
				L_0028: sub 
				L_0029: switch (L_008b, L_00b1, L_0124, L_009e)
				L_003e: ldloc.1 
				L_003f: ldc.i4.s 16
				L_0041: beq L_00c4
				L_0046: ldloc.1 
				L_0047: ldc.i4.s 32
				L_0049: beq L_00e4
				L_004e: br L_0124
				L_0053: ldloc.1 
				L_0054: ldc.i4 256
				L_0059: bgt.s L_0070
				L_005b: ldloc.1 
				L_005c: ldc.i4.s 64
				L_005e: beq.s L_00d4
				L_0060: ldloc.1 
				L_0061: ldc.i4 256
				L_0066: beq L_00f4
				L_006b: br L_0124
				L_0070: ldloc.1 
				L_0071: ldc.i4 512
				L_0076: beq L_0114
				L_007b: ldloc.1 
				L_007c: ldc.i4 1024
				L_0081: beq L_0104
				L_0086: br L_0124
				L_008b: ldloc.0 
				L_008c: ldc.i4.0 
				L_008d: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_0092: ldloc.0 
				L_0093: ldc.i4.0 
				L_0094: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_0099: br L_0132
				L_009e: ldloc.0 
				L_009f: ldc.i4.2 
				L_00a0: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00a5: ldloc.0 
				L_00a6: ldc.i4.0 
				L_00a7: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_00ac: br L_0132
				L_00b1: ldloc.0 
				L_00b2: ldc.i4.1 
				L_00b3: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00b8: ldloc.0 
				L_00b9: ldc.i4.0 
				L_00ba: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_00bf: br L_0132
				L_00c4: ldloc.0 
				L_00c5: ldc.i4.0 
				L_00c6: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00cb: ldloc.0 
				L_00cc: ldc.i4.1 
				L_00cd: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_00d2: br.s L_0132
				L_00d4: ldloc.0 
				L_00d5: ldc.i4.2 
				L_00d6: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00db: ldloc.0 
				L_00dc: ldc.i4.1 
				L_00dd: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_00e2: br.s L_0132
				L_00e4: ldloc.0 
				L_00e5: ldc.i4.1 
				L_00e6: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00eb: ldloc.0 
				L_00ec: ldc.i4.1 
				L_00ed: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_00f2: br.s L_0132
				L_00f4: ldloc.0 
				L_00f5: ldc.i4.0 
				L_00f6: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_00fb: ldloc.0 
				L_00fc: ldc.i4.2 
				L_00fd: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_0102: br.s L_0132
				L_0104: ldloc.0 
				L_0105: ldc.i4.2 
				L_0106: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_010b: ldloc.0 
				L_010c: ldc.i4.2 
				L_010d: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_0112: br.s L_0132
				L_0114: ldloc.0 
				L_0115: ldc.i4.1 
				L_0116: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_011b: ldloc.0 
				L_011c: ldc.i4.2 
				L_011d: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_0122: br.s L_0132
				L_0124: ldloc.0 
				L_0125: ldc.i4.1 
				L_0126: callvirt System.Drawing.StringFormat::Void set_Alignment(System.Drawing.StringAlignment)
				L_012b: ldloc.0 
				L_012c: ldc.i4.1 
				L_012d: callvirt System.Drawing.StringFormat::Void set_LineAlignment(System.Drawing.StringAlignment)
				L_0132: ldloc.0 
				L_0133: ret 
			*/
			
			
			{
				StringFormat stringFormat1;
				ContentAlignment contentAlignment1;
				stringFormat1 = new StringFormat ();
				if ((x43bec302f92080b9.RightToLeft & RightToLeft.Yes) == RightToLeft.Yes)
				{
					stringFormat1.FormatFlags = StringFormatFlags.DirectionRightToLeft;
				}
				stringFormat1.HotkeyPrefix = HotkeyPrefix.Show;
				contentAlignment1 = x7717e14a55110734;
				if (contentAlignment1 <= ContentAlignment.MiddleCenter)
				{
					switch (contentAlignment1)
					{
						case ContentAlignment.TopLeft:
						
						{
								stringFormat1.Alignment = StringAlignment.Near;
								stringFormat1.LineAlignment = StringAlignment.Near;
								return stringFormat1;
						}
						case ContentAlignment.TopCenter:
						
						{
								stringFormat1.Alignment = StringAlignment.Center;
								stringFormat1.LineAlignment = StringAlignment.Near;
								return stringFormat1;
						}
						case  ((ContentAlignment) 3):
						
						{
								goto L_0124;
						}
						case ContentAlignment.TopRight:
						
						{
								stringFormat1.Alignment = StringAlignment.Far;
								stringFormat1.LineAlignment = StringAlignment.Near;
								return stringFormat1;
						}
					}
					if (contentAlignment1 == ContentAlignment.MiddleLeft)
					{
						stringFormat1.Alignment = StringAlignment.Near;
						stringFormat1.LineAlignment = StringAlignment.Center;
						return stringFormat1;
					}
					else if (contentAlignment1 == ContentAlignment.MiddleCenter)
					{
						stringFormat1.Alignment = StringAlignment.Center;
						stringFormat1.LineAlignment = StringAlignment.Center;
						return stringFormat1;
					}
				}
				else if (contentAlignment1 <= ContentAlignment.BottomLeft)
				{
					if (contentAlignment1 == ContentAlignment.MiddleRight)
					{
						stringFormat1.Alignment = StringAlignment.Far;
						stringFormat1.LineAlignment = StringAlignment.Center;
						return stringFormat1;
					}
					else if (contentAlignment1 == ContentAlignment.BottomLeft)
					{
						stringFormat1.Alignment = StringAlignment.Near;
						stringFormat1.LineAlignment = StringAlignment.Far;
						return stringFormat1;
					}
				}
				else if (contentAlignment1 == ContentAlignment.BottomCenter)
				{
					stringFormat1.Alignment = StringAlignment.Center;
					stringFormat1.LineAlignment = StringAlignment.Far;
					return stringFormat1;
				}
				else if (contentAlignment1 == ContentAlignment.BottomRight)
				{
					stringFormat1.Alignment = StringAlignment.Far;
					stringFormat1.LineAlignment = StringAlignment.Far;
					return stringFormat1;
				}
				
			L_0124:
				
				{
				}
				stringFormat1.Alignment = StringAlignment.Center;
				stringFormat1.LineAlignment = StringAlignment.Center;
				return stringFormat1;
			}
			
			public static Bitmap xa7e5bb40b33707ca (Bitmap x50a18ad2656e7181)
			
			/*
				// Code Size: 79 Bytes
				.maxstack 7
				.locals (System.Drawing.Bitmap V_0, 
         System.Int32 V_1, 
         System.Int32 V_2)
				L_0000: ldarg.0 
				L_0001: callvirt System.Drawing.Image::Int32 get_Height()
				L_0006: ldarg.0 
				L_0007: callvirt System.Drawing.Image::Int32 get_Width()
				L_000c: newobj System.Drawing.Bitmap::Void .ctor(Int32, Int32)
				L_0011: stloc.0 
				L_0012: ldc.i4.0 
				L_0013: stloc.1 
				L_0014: br.s L_0044
				L_0016: ldc.i4.0 
				L_0017: stloc.2 
				L_0018: br.s L_0037
				L_001a: ldloc.0 
				L_001b: ldloc.1 
				L_001c: ldarg.0 
				L_001d: callvirt System.Drawing.Image::Int32 get_Width()
				L_0022: ldloc.2 
				L_0023: sub 
				L_0024: ldc.i4.1 
				L_0025: sub 
				L_0026: ldarg.0 
				L_0027: ldloc.2 
				L_0028: ldloc.1 
				L_0029: callvirt System.Drawing.Bitmap::System.Drawing.Color GetPixel(Int32, Int32)
				L_002e: callvirt System.Drawing.Bitmap::Void SetPixel(Int32, Int32, System.Drawing.Color)
				L_0033: ldloc.2 
				L_0034: ldc.i4.1 
				L_0035: add 
				L_0036: stloc.2 
				L_0037: ldloc.2 
				L_0038: ldarg.0 
				L_0039: callvirt System.Drawing.Image::Int32 get_Width()
				L_003e: blt.s L_001a
				L_0040: ldloc.1 
				L_0041: ldc.i4.1 
				L_0042: add 
				L_0043: stloc.1 
				L_0044: ldloc.1 
				L_0045: ldarg.0 
				L_0046: callvirt System.Drawing.Image::Int32 get_Height()
				L_004b: blt.s L_0016
				L_004d: ldloc.0 
				L_004e: ret 
			*/
			
			
			{
				int i1;
				int i2;
				Bitmap bitmap1 = new Bitmap (x50a18ad2656e7181.Height, x50a18ad2656e7181.Width);
				for (i1 = 0; (i1 < x50a18ad2656e7181.Height); i1++)
				{
					for (i2 = 0; (i2 < x50a18ad2656e7181.Width); i2++)
					{
						bitmap1.SetPixel (i1, ((int) ((x50a18ad2656e7181.Width - i2) - 1)), x50a18ad2656e7181.GetPixel (i2, i1));
					}
				}
				return bitmap1;
			}
			
			public static Bitmap xb2c919bf91b5f7c6 (Bitmap x337e217cb3ba0627, int x10f4d88af727adbc, int xc0c4c459c6ccbd00)
			
			/*
				// Code Size: 71 Bytes
				.maxstack 6
				.locals (System.Single V_0, 
         System.Single V_1, 
         System.Drawing.RectangleF V_2)
				L_0000: ldarg.0 
				L_0001: brfalse.s L_0006
				L_0003: ldarg.1 
				L_0004: brtrue.s L_0008
				L_0006: ldnull 
				L_0007: ret 
				L_0008: ldarg.0 
				L_0009: callvirt System.Drawing.Image::Int32 get_Width()
				L_000e: conv.r4 
				L_000f: ldarg.1 
				L_0010: conv.r4 
				L_0011: div 
				L_0012: stloc.0 
				L_0013: ldarg.0 
				L_0014: callvirt System.Drawing.Image::Int32 get_Height()
				L_0019: conv.r4 
				L_001a: stloc.1 
				L_001b: ldloca.s V_2
				L_001d: ldloc.0 
				L_001e: ldarg.2 
				L_001f: ldc.i4.1 
				L_0020: sub 
				L_0021: conv.r4 
				L_0022: mul 
				L_0023: ldc.r4 0
				L_0028: newobj System.Drawing.PointF::Void .ctor(Single, Single)
				L_002d: ldloc.0 
				L_002e: ldloc.1 
				L_002f: newobj System.Drawing.SizeF::Void .ctor(Single, Single)
				L_0034: call System.Drawing.RectangleF::Void .ctor(System.Drawing.PointF, System.Drawing.SizeF)
				L_0039: ldarg.0 
				L_003a: ldloc.2 
				L_003b: ldarg.0 
				L_003c: callvirt System.Drawing.Image::System.Drawing.Imaging.PixelFormat get_PixelFormat()
				L_0041: callvirt System.Drawing.Bitmap::System.Drawing.Bitmap Clone(System.Drawing.RectangleF, System.Drawing.Imaging.PixelFormat)
				L_0046: ret 
			*/
			
			
			{
				RectangleF rectangleF1;
				if ((x337e217cb3ba0627 == null) || (x10f4d88af727adbc == 0))
				{
					return null;
				}
				float single1 = (((float) x337e217cb3ba0627.Width) / ((float) x10f4d88af727adbc));
				float single2 = ((float) x337e217cb3ba0627.Height);
				rectangleF1 = new RectangleF (new PointF ((single1 * ((float) (xc0c4c459c6ccbd00 - 1))), 0F), new SizeF (single1, single2));
				return x337e217cb3ba0627.Clone (rectangleF1, x337e217cb3ba0627.PixelFormat);
			}
			
			public static void xb845cf2a244dd721 (Control.ControlCollection x01c8fcfe91402774, Control xccb63ca5f63dc470)
			
			/*
				// Code Size: 79 Bytes
				.maxstack 3
				.locals (System.Windows.Forms.Button V_0, 
         System.Windows.Forms.Form V_1)
				L_0000: ldarg.0 
				L_0001: brfalse.s L_004e
				L_0003: ldarg.1 
				L_0004: brfalse.s L_004e
				L_0006: ldnull 
				L_0007: stloc.0 
				L_0008: ldarg.1 
				L_0009: callvirt System.Windows.Forms.Control::System.Windows.Forms.Form FindForm()
				L_000e: stloc.1 
				L_000f: ldloc.1 
				L_0010: brfalse.s L_0032
				L_0012: newobj System.Windows.Forms.Button::Void .ctor()
				L_0017: stloc.0 
				L_0018: ldloc.0 
				L_0019: ldc.i4.0 
				L_001a: callvirt System.Windows.Forms.Control::Void set_Visible(Boolean)
				L_001f: ldloc.1 
				L_0020: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0025: ldloc.0 
				L_0026: callvirt System.Windows.Forms.Control+ControlCollection::Void Add(System.Windows.Forms.Control)
				L_002b: ldloc.1 
				L_002c: ldloc.0 
				L_002d: callvirt System.Windows.Forms.ContainerControl::Void set_ActiveControl(System.Windows.Forms.Control)
				L_0032: ldarg.0 
				L_0033: ldarg.1 
				L_0034: callvirt System.Windows.Forms.Control+ControlCollection::Void Remove(System.Windows.Forms.Control)
				L_0039: ldloc.1 
				L_003a: brfalse.s L_004e
				L_003c: ldloc.0 
				L_003d: callvirt System.ComponentModel.Component::Void Dispose()
				L_0042: ldloc.1 
				L_0043: callvirt System.Windows.Forms.Control::ControlCollection get_Controls()
				L_0048: ldloc.0 
				L_0049: callvirt System.Windows.Forms.Control+ControlCollection::Void Remove(System.Windows.Forms.Control)
				L_004e: ret 
			*/
			
			
			{
				if ((x01c8fcfe91402774 == null) || (xccb63ca5f63dc470 == null))
				{
					return;
				}
				Button button1 = ((Button) null);
				Form form1 = xccb63ca5f63dc470.FindForm ();
				if (form1 != null)
				{
					button1 = new Button ();
					button1.Visible = false;
					form1.Controls.Add (((Control) button1));
					form1.ActiveControl = ((Control) button1);
				}
				x01c8fcfe91402774.Remove (xccb63ca5f63dc470);
				if (form1 != null)
				{
					button1.Dispose ();
					form1.Controls.Remove (((Control) button1));
				}
			}
			
			public static void xc26de3a2a0579d1d (Graphics x4b101060f4767186, int x08db3aeabb253cb1, int x1e218ceaee1bb583, bool x2fef7d841879a711)
			
			/*
				// Code Size: 151 Bytes
				.maxstack 5
				.locals (System.Drawing.Brush V_0, 
         System.Drawing.Point[] V_1)
				L_0000: ldc.i4.3 
				L_0001: newarr System.Drawing.Point
				L_0006: stloc.1 
				L_0007: ldarg.3 
				L_0008: brtrue.s L_0056
				L_000a: call System.Drawing.Brushes::System.Drawing.Brush get_White()
				L_000f: stloc.0 
				L_0010: ldloc.1 
				L_0011: ldc.i4.0 
				L_0012: ldelema System.Drawing.Point
				L_0017: ldarg.1 
				L_0018: ldc.i4.1 
				L_0019: add 
				L_001a: ldarg.2 
				L_001b: ldc.i4.1 
				L_001c: add 
				L_001d: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0022: ldloc.1 
				L_0023: ldc.i4.1 
				L_0024: ldelema System.Drawing.Point
				L_0029: ldarg.1 
				L_002a: ldc.i4.4 
				L_002b: add 
				L_002c: ldarg.2 
				L_002d: ldc.i4.4 
				L_002e: add 
				L_002f: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0034: ldloc.1 
				L_0035: ldc.i4.2 
				L_0036: ldelema System.Drawing.Point
				L_003b: ldarg.1 
				L_003c: ldc.i4.4 
				L_003d: add 
				L_003e: ldarg.2 
				L_003f: ldc.i4.2 
				L_0040: sub 
				L_0041: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_0046: ldarg.0 
				L_0047: ldloc.0 
				L_0048: ldloc.1 
				L_0049: callvirt System.Drawing.Graphics::Void FillPolygon(System.Drawing.Brush, System.Drawing.Point[])
				L_004e: call System.Drawing.Brushes::System.Drawing.Brush get_Gray()
				L_0053: stloc.0 
				L_0054: br.s L_005c
				L_0056: call System.Drawing.Brushes::System.Drawing.Brush get_Black()
				L_005b: stloc.0 
				L_005c: ldloc.1 
				L_005d: ldc.i4.0 
				L_005e: ldelema System.Drawing.Point
				L_0063: ldarg.1 
				L_0064: ldarg.2 
				L_0065: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_006a: ldloc.1 
				L_006b: ldc.i4.1 
				L_006c: ldelema System.Drawing.Point
				L_0071: ldarg.1 
				L_0072: ldc.i4.3 
				L_0073: add 
				L_0074: ldarg.2 
				L_0075: ldc.i4.3 
				L_0076: add 
				L_0077: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_007c: ldloc.1 
				L_007d: ldc.i4.2 
				L_007e: ldelema System.Drawing.Point
				L_0083: ldarg.1 
				L_0084: ldc.i4.3 
				L_0085: add 
				L_0086: ldarg.2 
				L_0087: ldc.i4.3 
				L_0088: sub 
				L_0089: call System.Drawing.Point::Void .ctor(Int32, Int32)
				L_008e: ldarg.0 
				L_008f: ldloc.0 
				L_0090: ldloc.1 
				L_0091: callvirt System.Drawing.Graphics::Void FillPolygon(System.Drawing.Brush, System.Drawing.Point[])
				L_0096: ret 
			*/
			
			
			{
				Brush brush1;
				Point[] pointArray1 = new Point[3];
				if (! x2fef7d841879a711)
				{
					brush1 = Brushes.White;
					pointArray1[0] = new Point (((int) (x08db3aeabb253cb1 + 1)), ((int) (x1e218ceaee1bb583 + 1)));
					pointArray1[1] = new Point (((int) (x08db3aeabb253cb1 + 4)), ((int) (x1e218ceaee1bb583 + 4)));
					pointArray1[2] = new Point (((int) (x08db3aeabb253cb1 + 4)), ((int) (x1e218ceaee1bb583 - 2)));
					x4b101060f4767186.FillPolygon (brush1, pointArray1);
					brush1 = Brushes.Gray;
				}
				else
				{
					brush1 = Brushes.Black;
				}
				pointArray1[0] = new Point (x08db3aeabb253cb1, x1e218ceaee1bb583);
				pointArray1[1] = new Point (((int) (x08db3aeabb253cb1 + 3)), ((int) (x1e218ceaee1bb583 + 3)));
				pointArray1[2] = new Point (((int) (x08db3aeabb253cb1 + 3)), ((int) (x1e218ceaee1bb583 - 3)));
				x4b101060f4767186.FillPolygon (brush1, pointArray1);
			}
			
			public static string xd770c4dc45b3b54f (Graphics x4b101060f4767186, string xe4115acdf4fbfccc, Font x26094932cf7a9139, int x9b0739496f8b5475)
			
			/*
				// Code Size: 92 Bytes
				.maxstack 4
				.locals (System.String V_0, 
         System.Drawing.Font V_1, 
         System.Int32 V_2, 
         System.Int32 V_3, 
         System.Drawing.SizeF V_4)
				L_0000: ldarg.1 
				L_0001: stloc.0 
				L_0002: ldarg.2 
				L_0003: stloc.1 
				L_0004: ldarg.0 
				L_0005: ldarg.1 
				L_0006: ldloc.1 
				L_0007: callvirt System.Drawing.Graphics::System.Drawing.SizeF MeasureString(System.String, System.Drawing.Font)
				L_000c: stloc.s V_4
				L_000e: ldloca.s V_4
				L_0010: call System.Drawing.SizeF::Single get_Width()
				L_0015: conv.i4 
				L_0016: stloc.2 
				L_0017: ldarg.3 
				L_0018: ldloc.2 
				L_0019: ble.s L_001d
				L_001b: ldloc.0 
				L_001c: ret 
				L_001d: ldc.i4.1 
				L_001e: stloc.3 
				L_001f: br.s L_0051
				L_0021: ldarg.1 
				L_0022: ldc.i4.0 
				L_0023: ldloc.3 
				L_0024: callvirt System.String::System.String Substring(Int32, Int32)
				L_0029: ldstr "..."
				L_002e: call System.String::System.String Concat(System.String, System.String)
				L_0033: stloc.0 
				L_0034: ldarg.0 
				L_0035: ldloc.0 
				L_0036: ldloc.1 
				L_0037: callvirt System.Drawing.Graphics::System.Drawing.SizeF MeasureString(System.String, System.Drawing.Font)
				L_003c: stloc.s V_4
				L_003e: ldloca.s V_4
				L_0040: call System.Drawing.SizeF::Single get_Width()
				L_0045: conv.i4 
				L_0046: stloc.2 
				L_0047: ldloc.2 
				L_0048: ldarg.3 
				L_0049: blt.s L_004d
				L_004b: ldloc.0 
				L_004c: ret 
				L_004d: ldloc.3 
				L_004e: ldc.i4.1 
				L_004f: add 
				L_0050: stloc.3 
				L_0051: ldloc.3 
				L_0052: ldarg.1 
				L_0053: callvirt System.String::Int32 get_Length()
				L_0058: blt.s L_0021
				L_005a: ldarg.1 
				L_005b: ret 
			*/
			
			
			{
				int i2;
				string string1 = xe4115acdf4fbfccc;
				Font font1 = x26094932cf7a9139;
				if (x9b0739496f8b5475 > ((int) x4b101060f4767186.MeasureString (xe4115acdf4fbfccc, font1).Width))
				{
					return string1;
				}
				else
				{
					for (i2 = 1; (i2 < xe4115acdf4fbfccc.Length); i2++)
					{
						string1 = (xe4115acdf4fbfccc.Substring (0, i2) + "...");
						if (((int) x4b101060f4767186.MeasureString (string1, font1).Width) >= x9b0739496f8b5475)
						{
							return string1;
						}
					}
					return xe4115acdf4fbfccc;
				}
			}
			
			public static int xef3eab3fcb924e8b (IntPtr x96e7d32425e52ebf, string x9fc3ee03a439f6f0, string x3c4da2980d043c95, uint x131e93dadea89ec5)
			
			/*
				// Code Size: 10 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldarg.2 
				L_0003: ldarg.3 
				L_0004: call Sunisoft.IrisSkin.x61467fe65a98f20c::Int32 MessageBox(IntPtr, System.String, System.String, UInt32)
				L_0009: ret 
			*/
			
			
			{
				return x61467fe65a98f20c.MessageBox (x96e7d32425e52ebf, x9fc3ee03a439f6f0, x3c4da2980d043c95, x131e93dadea89ec5);
			}
			
			public static void xf4f948f95d7023bb ()
			
			/*
				// Code Size: 61 Bytes
				.maxstack 3
				.locals (System.String V_0)
				L_0000: ldstr "peloagcpofjpfgaapahamfoalffbffmbkedccfkcodbdheidhpodhdgeaenemdefpdlfjccgocjgadahcdhhmnnhkbfiecmidncjfckjlbbkmbikmapklaglkanlbbempalmnpbnhajnhppndpgomknomoepfplpdpcajpjanjabjohbnnobejfcklmcaoddenkdlnbeilienmpeimgfkmnffiegghlgmjchgljhngaidmhigloijlfjbgmjkkdkekkkdkblkjilcfplijgmaknmffengelndjcomijociaplhhpkiopjhfabdmaaidbahkbpgbcogicfhpcdhgdbgndlgeeecleaacfkpif"
				L_0005: ldc.i4 7400187
				L_000a: call xb9d8bb5e6df032aa.x1110bdd110cdcea4::System.String _xaacba899487bce8c(System.String, Int32)
				L_000f: call System.String::System.String Intern(System.String)
				L_0014: stloc.0 
				L_0015: ldloc.0 
				L_0016: ldstr "cmfdlmmdimdebmkeiibfkhifhhpfmlggjlngglehkglhmkcilkjibkajjjhjakojjjfknimkijdlpeklbibmkiimfipmeegnlhnnbieofhlomhcpjhjpogaajghalgoajcfb"
				L_001b: ldc.i4 1100690778
				L_0020: call xb9d8bb5e6df032aa.x1110bdd110cdcea4::System.String _xaacba899487bce8c(System.String, Int32)
				L_0025: call System.String::System.String Intern(System.String)
				L_002a: call System.String::System.String Concat(System.String, System.String)
				L_002f: stloc.0 
				L_0030: ldloc.0 
				L_0031: ldstr " "
				L_0036: call System.Windows.Forms.MessageBox::System.Windows.Forms.DialogResult Show(System.String, System.String)
				L_003b: pop 
				L_003c: ret 
			*/
			
			
			{
				string string1 = string.Intern (x1110bdd110cdcea4._xaacba899487bce8c ("peloagcpofjpfgaapahamfoalffbffmbkedccfkcodbdheidhpodhdgeaenemdefpdlfjccgocjgadah"
				+ "cdhhmnnhkbfiecmidncjfckjlbbkmbikmapklaglkanlbbempalmnpbnhajnhppndpgomknomoepfplp"
				+ "dpcajpjanjabjohbnnobejfcklmcaoddenkdlnbeilienmpeimgfkmnffiegghlgmjchgljhngaidmhi"
				+ "gloijlfjbgmjkkdkekkkdkblkjilcfplijgmaknmffengelndjcomijociaplhhpkiopjhfabdmaaidb"
				+ "ahkbpgbcogicfhpcdhgdbgndlgeeecleaacfkpif", 7400187));
				string1 = (string1 + string.Intern (x1110bdd110cdcea4._xaacba899487bce8c ("cmfdlmmdimdebmkeiibfkhifhhpfmlggjlngglehkglhmkcilkjibkajjjhjakojjjfknimkijdlpekl"
				+ "bibmkiimfipmeegnlhnnbieofhlomhcpjhjpogaajghalgoajcfb", 1100690778)));
				DialogResult dialogResult1 = MessageBox.Show (string1, " ");
			}
			
			public static Font xfc84e4da153943c2 ()
			
			/*
				// Code Size: 6 Bytes
				.maxstack 9
				L_0000: call System.Windows.Forms.SystemInformation::System.Drawing.Font get_MenuFont()
				L_0005: ret 
			*/
			
			
			{
				return SystemInformation.MenuFont;
			}
			
		#endregion
	}
	
}

