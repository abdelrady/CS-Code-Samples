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
			using System.IO;
			using System.Runtime.InteropServices;
			using System.Text;
			
			
		#endregion
		
	internal class x2b13dab2573bcd5e
	
	{
		
		#region Fields
			private static Ixb0f0f2071b49b1cb x05f724456b7f79d1;
			private static Ixb0f0f2071b49b1cb x36ab34a1d2fe3af6;
			private const int x9b3c370aac2bcae3 = 12;
		#endregion
		
		#region Constructors
		
			static x2b13dab2573bcd5e ()
			/*
				// Code Size: 101 Bytes
				.maxstack 7
				.locals (System.Int32 V_0)
				L_0000: ldc.i4.s 15
				L_0002: newobj Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Void .ctor(Int32)
				L_0007: stsfld Sunisoft.IrisSkin.x2b13dab2573bcd5e::Sunisoft.IrisSkin.xb0f0f2071b49b1cb x36ab34a1d2fe3af6
				L_000c: ldsfld Sunisoft.IrisSkin.x2b13dab2573bcd5e::Sunisoft.IrisSkin.xb0f0f2071b49b1cb x36ab34a1d2fe3af6
				L_0011: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] x7d0d65d43fee511e
				L_0016: ldc.i4.0 
				L_0017: ldc.i4 288
				L_001c: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Byte[] xcf1e65d83cd6b794
				L_0021: ldc.i4 257
				L_0026: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Void xda09af88ab899a50(Int32[], Int32, Int32, Byte[], Int32)
				L_002b: ldc.i4.0 
				L_002c: stloc.0 
				L_002d: br.s L_003b
				L_002f: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] x7d0d65d43fee511e
				L_0034: ldloc.0 
				L_0035: ldc.i4.5 
				L_0036: stelem.i4 
				L_0037: ldloc.0 
				L_0038: ldc.i4.1 
				L_0039: add 
				L_003a: stloc.0 
				L_003b: ldloc.0 
				L_003c: ldc.i4.s 32
				L_003e: blt.s L_002f
				L_0040: ldc.i4.s 15
				L_0042: newobj Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Void .ctor(Int32)
				L_0047: stsfld Sunisoft.IrisSkin.x2b13dab2573bcd5e::Sunisoft.IrisSkin.xb0f0f2071b49b1cb x05f724456b7f79d1
				L_004c: ldsfld Sunisoft.IrisSkin.x2b13dab2573bcd5e::Sunisoft.IrisSkin.xb0f0f2071b49b1cb x05f724456b7f79d1
				L_0051: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] x7d0d65d43fee511e
				L_0056: ldc.i4.0 
				L_0057: ldc.i4.s 32
				L_0059: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Byte[] xc9fe980725d32ac6
				L_005e: ldc.i4.0 
				L_005f: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Void xda09af88ab899a50(Int32[], Int32, Int32, Byte[], Int32)
				L_0064: ret 
			*/
			
			public x2b13dab2573bcd5e ()
			/*
				// Code Size: 7 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: call System.Object::Void .ctor()
				L_0006: ret 
			*/
		#endregion
		
		#region Methods
		
			private static int x02995f229cff83b4 (int x10f4d88af727adbc, ref int x67d7b14657e9f9cd, ref int xff1f79a9916b9886, ref int x89682117b5f7515d, byte[] x11e8eb31c2edb458)
			
			/*
				// Code Size: 130 Bytes
				.maxstack 6
				.locals (System.Int32 V_0, 
         System.Int32 V_1)
				L_0000: ldc.i4.0 
				L_0001: stloc.0 
				L_0002: ldarg.0 
				L_0003: ldarg.1 
				L_0004: ldind.i4 
				L_0005: bgt.s L_0026
				L_0007: ldarg.2 
				L_0008: ldind.i4 
				L_0009: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] xd4434a4392e36da6
				L_000e: ldarg.0 
				L_000f: ldc.i4.1 
				L_0010: sub 
				L_0011: ldelem.i4 
				L_0012: and 
				L_0013: stloc.0 
				L_0014: ldarg.2 
				L_0015: ldarg.2 
				L_0016: ldind.i4 
				L_0017: ldarg.0 
				L_0018: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_001d: stind.i4 
				L_001e: ldarg.1 
				L_001f: dup 
				L_0020: ldind.i4 
				L_0021: ldarg.0 
				L_0022: sub 
				L_0023: stind.i4 
				L_0024: br.s L_0080
				L_0026: ldarg.0 
				L_0027: ldarg.1 
				L_0028: ldind.i4 
				L_0029: sub 
				L_002a: stloc.1 
				L_002b: ldarg.2 
				L_002c: ldind.i4 
				L_002d: stloc.0 
				L_002e: ldarg.2 
				L_002f: ldarg.s x11e8eb31c2edb458
				L_0031: ldarg.3 
				L_0032: ldind.i4 
				L_0033: ldelem.u1 
				L_0034: ldarg.s x11e8eb31c2edb458
				L_0036: ldarg.3 
				L_0037: ldind.i4 
				L_0038: ldc.i4.1 
				L_0039: add 
				L_003a: ldelem.u1 
				L_003b: ldc.i4.8 
				L_003c: shl 
				L_003d: add 
				L_003e: ldarg.s x11e8eb31c2edb458
				L_0040: ldarg.3 
				L_0041: ldind.i4 
				L_0042: ldc.i4.2 
				L_0043: add 
				L_0044: ldelem.u1 
				L_0045: ldc.i4.s 16
				L_0047: shl 
				L_0048: add 
				L_0049: ldarg.s x11e8eb31c2edb458
				L_004b: ldarg.3 
				L_004c: ldind.i4 
				L_004d: ldc.i4.3 
				L_004e: add 
				L_004f: ldelem.u1 
				L_0050: ldc.i4.s 24
				L_0052: shl 
				L_0053: add 
				L_0054: stind.i4 
				L_0055: ldarg.3 
				L_0056: dup 
				L_0057: ldind.i4 
				L_0058: ldc.i4.4 
				L_0059: add 
				L_005a: stind.i4 
				L_005b: ldloc.0 
				L_005c: ldarg.2 
				L_005d: ldind.i4 
				L_005e: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] xd4434a4392e36da6
				L_0063: ldloc.1 
				L_0064: ldc.i4.1 
				L_0065: sub 
				L_0066: ldelem.i4 
				L_0067: and 
				L_0068: ldarg.1 
				L_0069: ldind.i4 
				L_006a: ldc.i4.s 31
				L_006c: and 
				L_006d: shl 
				L_006e: add 
				L_006f: stloc.0 
				L_0070: ldarg.2 
				L_0071: ldarg.2 
				L_0072: ldind.i4 
				L_0073: ldloc.1 
				L_0074: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_0079: stind.i4 
				L_007a: ldarg.1 
				L_007b: ldc.i4.s 32
				L_007d: ldloc.1 
				L_007e: sub 
				L_007f: stind.i4 
				L_0080: ldloc.0 
				L_0081: ret 
			*/
			
			
			{
				int i1 = 0;
				if (x10f4d88af727adbc <= x67d7b14657e9f9cd)
				{
					i1 = (xff1f79a9916b9886 & x71589e3f55261426.xd4434a4392e36da6[(x10f4d88af727adbc - 1)]);
					xff1f79a9916b9886 = x2b13dab2573bcd5e.xa52147d0d9c2c73c (xff1f79a9916b9886, x10f4d88af727adbc);
					x67d7b14657e9f9cd -= x10f4d88af727adbc;
					return i1;
				}
				int i2 = (x10f4d88af727adbc - x67d7b14657e9f9cd);
				i1 = xff1f79a9916b9886;
				xff1f79a9916b9886 = ((int) (((x11e8eb31c2edb458[x89682117b5f7515d] + (x11e8eb31c2edb458[(x89682117b5f7515d + 1)] << 8)) + (x11e8eb31c2edb458[(x89682117b5f7515d + 2)] << 16)) + (x11e8eb31c2edb458[(x89682117b5f7515d + 3)] << 24)));
				x89682117b5f7515d += 4;
				i1 += ((int) ((xff1f79a9916b9886 & x71589e3f55261426.xd4434a4392e36da6[(i2 - 1)]) << (x67d7b14657e9f9cd & 31)));
				xff1f79a9916b9886 = x2b13dab2573bcd5e.xa52147d0d9c2c73c (xff1f79a9916b9886, i2);
				x67d7b14657e9f9cd = ((int) (32 - i2));
				return i1;
			}
			
			private static int x19339fe0ba40cd55 (long x50a18ad2656e7181)
			
			/*
				// Code Size: 24 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4 2147483647
				L_0006: conv.i8 
				L_0007: bge.s L_000c
				L_0009: ldarg.0 
				L_000a: conv.i4 
				L_000b: ret 
				L_000c: ldarg.0 
				L_000d: call System.Convert::UInt32 ToUInt32(Int64)
				L_0012: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 x19339fe0ba40cd55(UInt32)
				L_0017: ret 
			*/
			
			
			{
				if (x50a18ad2656e7181 >= ((long) int.MaxValue))
				{
					return x2b13dab2573bcd5e.x19339fe0ba40cd55 (Convert.ToUInt32 (x50a18ad2656e7181));
				}
				else
				{
					return ((int) x50a18ad2656e7181);
				}
			}
			
			private static int x19339fe0ba40cd55 (uint x50a18ad2656e7181)
			
			/*
				// Code Size: 20 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4 2147483647
				L_0006: bge.un.s L_000a
				L_0008: ldarg.0 
				L_0009: ret 
				L_000a: ldc.i4.m1 
				L_000b: ldarg.0 
				L_000c: sub 
				L_000d: conv.u8 
				L_000e: neg 
				L_000f: ldc.i4.1 
				L_0010: conv.i8 
				L_0011: sub 
				L_0012: conv.i4 
				L_0013: ret 
			*/
			
			
			{
				if (x50a18ad2656e7181 >= 2147483647)
				{
					return ((int) ((- ((long) (-1 - ((int) x50a18ad2656e7181)))) - ((long) 1)));
				}
				else
				{
					return ((int) x50a18ad2656e7181);
				}
			}
			
			public static xfba9214ce91902fb x2b37c931ef30afed (Stream xe6d4e9629d861369, string xb07d2e5a1b230779, Stream x5ab6ed99b3041647, string xe8e4b5871d71a79a)
			
			/*
				// Code Size: 2516 Bytes
				.maxstack 25
				.locals (Sunisoft.IrisSkin.xfba9214ce91902fb V_0, 
         System.IO.Stream V_1, 
         System.IO.Stream V_2, 
         System.IO.BinaryReader V_3, 
         System.Int64 V_4, 
         Sunisoft.IrisSkin.xf85cd48011a0ce1f V_5, 
         Sunisoft.IrisSkin.x181df638a52dfd1a V_6, 
         Sunisoft.IrisSkin.x895eb13ee3f5b8cc V_7, 
         System.Byte[] V_8, 
         System.Boolean V_9, 
         System.Int32 V_10, 
         System.UInt32 V_11, 
         System.Int32 V_12, 
         System.Int32 V_13, 
         System.Int32 V_14, 
         System.Int32 V_15, 
         System.Int32 V_16, 
         System.Byte[] V_17, 
         System.Int32 V_18, 
         System.Byte[] V_19, 
         System.Int32 V_20, 
         System.Byte[] V_21, 
         System.Int32 V_22, 
         System.Byte[] V_23, 
         System.Byte[] V_24, 
         System.Int32 V_25, 
         System.Int32 V_26, 
         System.Int32 V_27, 
         System.Int32 V_28, 
         System.Int32 V_29, 
         System.Int32 V_30, 
         System.Int32 V_31, 
         System.Int32 V_32, 
         System.Int32 V_33, 
         System.Int32 V_34, 
         System.Int32 V_35, 
         System.Byte[] V_36, 
         System.Byte[] V_37, 
         System.Int32 V_38, 
         System.Int32 V_39, 
         System.Int32 V_40, 
         System.Int32 V_41, 
         System.Int32 V_42, 
         System.Int32 V_43, 
         System.Int32 V_44, 
         System.Int32 V_45, 
         System.Int32 V_46, 
         System.Int32 V_47, 
         System.Int32 V_48, 
         System.Int32 V_49, 
         System.Int32 V_50, 
         System.Int32 V_51, 
         System.Int32 V_52, 
         System.Int32 V_53, 
         System.Int32 V_54, 
         System.Int32 V_55, 
         System.Int32 V_56, 
         System.Int32 V_57, 
         System.Int32[] V_58, 
         Sunisoft.IrisSkin.xb0f0f2071b49b1cb V_59, 
         Sunisoft.IrisSkin.xb0f0f2071b49b1cb V_60, 
         Sunisoft.IrisSkin.xb0f0f2071b49b1cb V_61, 
         System.ArgumentException V_62, 
         Sunisoft.IrisSkin.xe24cbd369cdd075a V_63)
				.try L_0016 to L_098a catch System.ArgumentException L_098a to L_09a7
				.try L_0016 to L_098a catch System.Object L_09a7 to L_09ac
				L_0000: ldc.i4.0 
				L_0001: stloc.0 
				L_0002: ldnull 
				L_0003: stloc.3 
				L_0004: ldc.i4.0 
				L_0005: conv.i8 
				L_0006: stloc.s V_4
				L_0008: ldloca.s V_6
				L_000a: initobj Sunisoft.IrisSkin.x181df638a52dfd1a
				L_0010: ldc.i4.0 
				L_0011: stloc.s V_9
				L_0013: ldc.i4.0 
				L_0014: stloc.s V_10
				L_0016: ldarg.0 
				L_0017: newobj System.IO.BinaryReader::Void .ctor(System.IO.Stream)
				L_001c: stloc.3 
				L_001d: ldarg.0 
				L_001e: ldc.i4.0 
				L_001f: conv.i8 
				L_0020: ldc.i4.0 
				L_0021: callvirt System.IO.Stream::Int64 Seek(Int64, System.IO.SeekOrigin)
				L_0026: pop 
				L_0027: ldloc.3 
				L_0028: callvirt System.IO.BinaryReader::UInt32 ReadUInt32()
				L_002d: stloc.s V_11
				L_002f: ldloc.s V_11
				L_0031: ldc.i4 65535
				L_0036: and 
				L_0037: ldc.i4 19283
				L_003c: beq.s L_0049
				L_003e: ldstr "not a zip file"
				L_0043: newobj System.Exception::Void .ctor(System.String)
				L_0048: throw 
				L_0049: ldarg.0 
				L_004a: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int64 xd54e92c965f241a7(System.IO.Stream)
				L_004f: stloc.s V_4
				L_0051: ldloc.s V_4
				L_0053: ldc.i4.0 
				L_0054: conv.i8 
				L_0055: bge.s L_0062
				L_0057: ldstr "invalid zip file"
				L_005c: newobj System.Exception::Void .ctor(System.String)
				L_0061: throw 
				L_0062: ldloc.3 
				L_0063: ldtoken Sunisoft.IrisSkin.xf85cd48011a0ce1f
				L_0068: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_006d: ldtoken Sunisoft.IrisSkin.xf85cd48011a0ce1f
				L_0072: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_0077: call System.Runtime.InteropServices.Marshal::Int32 SizeOf(System.Type)
				L_007c: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::System.Object x49cceb88e1b6126e(System.IO.BinaryReader, System.Type, Int32)
				L_0081: unbox Sunisoft.IrisSkin.xf85cd48011a0ce1f
				L_0086: ldobj Sunisoft.IrisSkin.xf85cd48011a0ce1f
				L_008b: stloc.s V_5
				L_008d: ldloca.s V_5
				L_008f: ldfld Sunisoft.IrisSkin.xf85cd48011a0ce1f::Int16 x1096c029cd840ebb
				L_0094: ldc.i4.0 
				L_0095: ble.s L_00a7
				L_0097: ldarg.0 
				L_0098: ldloca.s V_5
				L_009a: ldfld Sunisoft.IrisSkin.xf85cd48011a0ce1f::Int16 x1096c029cd840ebb
				L_009f: conv.i8 
				L_00a0: ldc.i4.0 
				L_00a1: callvirt System.IO.Stream::Int64 Seek(Int64, System.IO.SeekOrigin)
				L_00a6: pop 
				L_00a7: ldarg.0 
				L_00a8: ldloca.s V_5
				L_00aa: ldfld Sunisoft.IrisSkin.xf85cd48011a0ce1f::Int32 xc7e71a29d94c1d16
				L_00af: conv.i8 
				L_00b0: ldc.i4.0 
				L_00b1: callvirt System.IO.Stream::Int64 Seek(Int64, System.IO.SeekOrigin)
				L_00b6: pop 
				L_00b7: br.s L_0116
				L_00b9: ldloc.3 
				L_00ba: ldtoken Sunisoft.IrisSkin.x181df638a52dfd1a
				L_00bf: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_00c4: ldtoken Sunisoft.IrisSkin.x181df638a52dfd1a
				L_00c9: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_00ce: call System.Runtime.InteropServices.Marshal::Int32 SizeOf(System.Type)
				L_00d3: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::System.Object x49cceb88e1b6126e(System.IO.BinaryReader, System.Type, Int32)
				L_00d8: unbox Sunisoft.IrisSkin.x181df638a52dfd1a
				L_00dd: ldobj Sunisoft.IrisSkin.x181df638a52dfd1a
				L_00e2: stloc.s V_6
				L_00e4: ldloc.3 
				L_00e5: ldloca.s V_6
				L_00e7: ldfld Sunisoft.IrisSkin.x181df638a52dfd1a::Int16 x46898d46d844ffad
				L_00ec: callvirt System.IO.BinaryReader::Byte[] ReadBytes(Int32)
				L_00f1: stloc.s V_8
				L_00f3: call System.Text.Encoding::System.Text.Encoding get_Default()
				L_00f8: ldloc.s V_8
				L_00fa: callvirt System.Text.Encoding::System.String GetString(Byte[])
				L_00ff: callvirt System.String::System.String ToUpper()
				L_0104: ldarg.1 
				L_0105: callvirt System.String::System.String ToUpper()
				L_010a: call System.String::Boolean op_Equality(System.String, System.String)
				L_010f: brfalse.s L_0116
				L_0111: ldc.i4.1 
				L_0112: stloc.s V_9
				L_0114: br.s L_0120
				L_0116: ldarg.0 
				L_0117: callvirt System.IO.Stream::Int64 get_Position()
				L_011c: ldloc.s V_4
				L_011e: blt.s L_00b9
				L_0120: ldloc.s V_9
				L_0122: brtrue.s L_012b
				L_0124: ldarg.1 
				L_0125: newobj System.IO.FileNotFoundException::Void .ctor(System.String)
				L_012a: throw 
				L_012b: ldarg.0 
				L_012c: ldloca.s V_6
				L_012e: ldfld Sunisoft.IrisSkin.x181df638a52dfd1a::Int32 x0cced477dfc63bfd
				L_0133: conv.i8 
				L_0134: ldc.i4.0 
				L_0135: callvirt System.IO.Stream::Int64 Seek(Int64, System.IO.SeekOrigin)
				L_013a: pop 
				L_013b: ldloc.3 
				L_013c: ldtoken Sunisoft.IrisSkin.x895eb13ee3f5b8cc
				L_0141: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_0146: ldtoken Sunisoft.IrisSkin.x895eb13ee3f5b8cc
				L_014b: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_0150: call System.Runtime.InteropServices.Marshal::Int32 SizeOf(System.Type)
				L_0155: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::System.Object x49cceb88e1b6126e(System.IO.BinaryReader, System.Type, Int32)
				L_015a: unbox Sunisoft.IrisSkin.x895eb13ee3f5b8cc
				L_015f: ldobj Sunisoft.IrisSkin.x895eb13ee3f5b8cc
				L_0164: stloc.s V_7
				L_0166: ldarg.0 
				L_0167: ldloca.s V_7
				L_0169: ldfld Sunisoft.IrisSkin.x895eb13ee3f5b8cc::Int16 x46898d46d844ffad
				L_016e: conv.i8 
				L_016f: ldc.i4.1 
				L_0170: callvirt System.IO.Stream::Int64 Seek(Int64, System.IO.SeekOrigin)
				L_0175: pop 
				L_0176: ldloca.s V_7
				L_0178: ldfld Sunisoft.IrisSkin.x895eb13ee3f5b8cc::Int16 x14b554dbc9986975
				L_017d: ldc.i4.0 
				L_017e: ble.s L_0190
				L_0180: ldarg.0 
				L_0181: ldloca.s V_7
				L_0183: ldfld Sunisoft.IrisSkin.x895eb13ee3f5b8cc::Int16 x14b554dbc9986975
				L_0188: conv.i8 
				L_0189: ldc.i4.1 
				L_018a: callvirt System.IO.Stream::Int64 Seek(Int64, System.IO.SeekOrigin)
				L_018f: pop 
				L_0190: ldc.i4.0 
				L_0191: stloc.s V_12
				L_0193: ldloca.s V_6
				L_0195: ldfld Sunisoft.IrisSkin.x181df638a52dfd1a::Int16 x07a186fde5854829
				L_019a: ldc.i4.1 
				L_019b: and 
				L_019c: brfalse.s L_01b9
				L_019e: ldarg.3 
				L_019f: brfalse.s L_01ae
				L_01a1: ldarg.3 
				L_01a2: ldstr ""
				L_01a7: call System.String::Boolean op_Equality(System.String, System.String)
				L_01ac: brfalse.s L_01b9
				L_01ae: ldstr "Password"
				L_01b3: newobj System.ArgumentException::Void .ctor(System.String)
				L_01b8: throw 
				L_01b9: ldarg.3 
				L_01ba: brfalse L_0416
				L_01bf: ldarg.3 
				L_01c0: ldstr ""
				L_01c5: call System.String::Boolean op_Inequality(System.String, System.String)
				L_01ca: brfalse L_0416
				L_01cf: ldc.i4 305419896
				L_01d4: stloc.s V_13
				L_01d6: ldc.i4 591751049
				L_01db: stloc.s V_14
				L_01dd: ldc.i4 878082192
				L_01e2: stloc.s V_15
				L_01e4: ldc.i4 134775813
				L_01e9: stloc.s V_16
				L_01eb: ldloc.3 
				L_01ec: ldc.i4.s 12
				L_01ee: callvirt System.IO.BinaryReader::Byte[] ReadBytes(Int32)
				L_01f3: stloc.s V_17
				L_01f5: ldc.i4.1 
				L_01f6: stloc.s V_10
				L_01f8: br L_0283
				L_01fd: ldarg.3 
				L_01fe: ldloc.s V_10
				L_0200: ldc.i4.1 
				L_0201: sub 
				L_0202: callvirt System.String::Char get_Chars(Int32)
				L_0207: call System.Convert::Int32 ToInt32(Char)
				L_020c: stloc.s V_18
				L_020e: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::UInt32[] x6ee31887cc8af8eb
				L_0213: ldloc.s V_13
				L_0215: ldloc.s V_18
				L_0217: xor 
				L_0218: ldc.i4 255
				L_021d: and 
				L_021e: ldelem.u4 
				L_021f: conv.u8 
				L_0220: ldloc.s V_13
				L_0222: ldc.i4.8 
				L_0223: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_0228: ldc.i4 16777215
				L_022d: and 
				L_022e: conv.i8 
				L_022f: xor 
				L_0230: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 x19339fe0ba40cd55(Int64)
				L_0235: stloc.s V_13
				L_0237: ldloc.s V_14
				L_0239: ldloc.s V_13
				L_023b: ldc.i4 255
				L_0240: and 
				L_0241: add 
				L_0242: stloc.s V_14
				L_0244: ldloc.s V_14
				L_0246: ldloc.s V_16
				L_0248: mul 
				L_0249: ldc.i4.1 
				L_024a: add 
				L_024b: stloc.s V_14
				L_024d: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::UInt32[] x6ee31887cc8af8eb
				L_0252: ldloc.s V_15
				L_0254: ldloc.s V_14
				L_0256: ldc.i4.s 24
				L_0258: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_025d: xor 
				L_025e: ldc.i4 255
				L_0263: and 
				L_0264: ldelem.u4 
				L_0265: conv.u8 
				L_0266: ldloc.s V_15
				L_0268: ldc.i4.8 
				L_0269: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_026e: ldc.i4 16777215
				L_0273: and 
				L_0274: conv.i8 
				L_0275: xor 
				L_0276: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 x19339fe0ba40cd55(Int64)
				L_027b: stloc.s V_15
				L_027d: ldloc.s V_10
				L_027f: ldc.i4.1 
				L_0280: add 
				L_0281: stloc.s V_10
				L_0283: ldloc.s V_10
				L_0285: ldarg.3 
				L_0286: callvirt System.String::Int32 get_Length()
				L_028b: ble L_01fd
				L_0290: ldc.i4.s 12
				L_0292: newarr System.Byte
				L_0297: stloc.s V_19
				L_0299: ldc.i4.0 
				L_029a: stloc.s V_10
				L_029c: br L_033e
				L_02a1: ldloc.s V_15
				L_02a3: ldc.i4 65535
				L_02a8: and 
				L_02a9: ldc.i4.2 
				L_02aa: or 
				L_02ab: stloc.s V_12
				L_02ad: ldloc.s V_19
				L_02af: ldloc.s V_10
				L_02b1: ldloc.s V_17
				L_02b3: ldloc.s V_10
				L_02b5: ldelem.u1 
				L_02b6: ldloc.s V_12
				L_02b8: ldloc.s V_12
				L_02ba: ldc.i4.1 
				L_02bb: xor 
				L_02bc: mul 
				L_02bd: ldc.i4.8 
				L_02be: shr 
				L_02bf: xor 
				L_02c0: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Byte x8885d1fc1e00dd5c(Int32)
				L_02c5: stelem.i1 
				L_02c6: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::UInt32[] x6ee31887cc8af8eb
				L_02cb: ldloc.s V_13
				L_02cd: ldloc.s V_19
				L_02cf: ldloc.s V_10
				L_02d1: ldelem.u1 
				L_02d2: xor 
				L_02d3: ldc.i4 255
				L_02d8: and 
				L_02d9: ldelem.u4 
				L_02da: conv.u8 
				L_02db: ldloc.s V_13
				L_02dd: ldc.i4.8 
				L_02de: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_02e3: ldc.i4 16777215
				L_02e8: and 
				L_02e9: conv.i8 
				L_02ea: xor 
				L_02eb: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 x19339fe0ba40cd55(Int64)
				L_02f0: stloc.s V_13
				L_02f2: ldloc.s V_14
				L_02f4: ldloc.s V_13
				L_02f6: ldc.i4 255
				L_02fb: and 
				L_02fc: add 
				L_02fd: stloc.s V_14
				L_02ff: ldloc.s V_14
				L_0301: ldloc.s V_16
				L_0303: mul 
				L_0304: ldc.i4.1 
				L_0305: add 
				L_0306: stloc.s V_14
				L_0308: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::UInt32[] x6ee31887cc8af8eb
				L_030d: ldloc.s V_15
				L_030f: ldloc.s V_14
				L_0311: ldc.i4.s 24
				L_0313: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_0318: xor 
				L_0319: ldc.i4 255
				L_031e: and 
				L_031f: ldelem.u4 
				L_0320: conv.u8 
				L_0321: ldloc.s V_15
				L_0323: ldc.i4.8 
				L_0324: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_0329: ldc.i4 16777215
				L_032e: and 
				L_032f: conv.i8 
				L_0330: xor 
				L_0331: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 x19339fe0ba40cd55(Int64)
				L_0336: stloc.s V_15
				L_0338: ldloc.s V_10
				L_033a: ldc.i4.1 
				L_033b: add 
				L_033c: stloc.s V_10
				L_033e: ldloc.s V_10
				L_0340: ldc.i4.s 12
				L_0342: blt L_02a1
				L_0347: ldc.i4.0 
				L_0348: stloc.s V_20
				L_034a: ldloca.s V_6
				L_034c: ldfld Sunisoft.IrisSkin.x181df638a52dfd1a::Int16 x07a186fde5854829
				L_0351: ldc.i4.8 
				L_0352: and 
				L_0353: ldc.i4.8 
				L_0354: bne.un.s L_0364
				L_0356: ldloca.s V_6
				L_0358: ldfld Sunisoft.IrisSkin.x181df638a52dfd1a::Int16 xbb36eda94c9adabc
				L_035d: ldc.i4.s 16
				L_035f: shl 
				L_0360: stloc.s V_20
				L_0362: br.s L_036d
				L_0364: ldloca.s V_6
				L_0366: ldfld Sunisoft.IrisSkin.x181df638a52dfd1a::Int32 x41fcadcc0506e331
				L_036b: stloc.s V_20
				L_036d: ldloc.s V_20
				L_036f: call Sunisoft.IrisSkin.xe24cbd369cdd075a::Sunisoft.IrisSkin.xe24cbd369cdd075a x544f68ae4f70de0e(Int32)
				L_0374: stloc.s V_63
				L_0376: ldloca.s V_63
				L_0378: ldfld Sunisoft.IrisSkin.xe24cbd369cdd075a::Byte xcb734f8c3043b335
				L_037d: ldloc.s V_19
				L_037f: ldc.i4.s 11
				L_0381: ldelem.u1 
				L_0382: beq.s L_038f
				L_0384: ldstr "Password"
				L_0389: newobj System.ArgumentException::Void .ctor(System.String)
				L_038e: throw 
				L_038f: newobj System.IO.MemoryStream::Void .ctor()
				L_0394: stloc.1 
				L_0395: ldc.i4 1024
				L_039a: newarr System.Byte
				L_039f: stloc.s V_21
				L_03a1: ldarg.0 
				L_03a2: ldloc.s V_21
				L_03a4: ldc.i4.0 
				L_03a5: ldc.i4 1024
				L_03aa: callvirt System.IO.Stream::Int32 Read(Byte[], Int32, Int32)
				L_03af: stloc.s V_22
				L_03b1: br.s L_03e5
				L_03b3: ldloc.s V_21
				L_03b5: ldc.i4 1024
				L_03ba: ldloca.s V_13
				L_03bc: ldloca.s V_14
				L_03be: ldloca.s V_15
				L_03c0: ldloc.s V_16
				L_03c2: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xe12a5d7e190699b3(Byte[], Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32)
				L_03c7: ldloc.1 
				L_03c8: ldloc.s V_21
				L_03ca: ldc.i4.0 
				L_03cb: ldc.i4 1024
				L_03d0: callvirt System.IO.Stream::Void Write(Byte[], Int32, Int32)
				L_03d5: ldarg.0 
				L_03d6: ldloc.s V_21
				L_03d8: ldc.i4.0 
				L_03d9: ldc.i4 1024
				L_03de: callvirt System.IO.Stream::Int32 Read(Byte[], Int32, Int32)
				L_03e3: stloc.s V_22
				L_03e5: ldloc.s V_22
				L_03e7: ldc.i4 1024
				L_03ec: beq.s L_03b3
				L_03ee: ldloc.s V_21
				L_03f0: ldloc.s V_22
				L_03f2: ldloca.s V_13
				L_03f4: ldloca.s V_14
				L_03f6: ldloca.s V_15
				L_03f8: ldloc.s V_16
				L_03fa: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xe12a5d7e190699b3(Byte[], Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32)
				L_03ff: ldloc.1 
				L_0400: ldloc.s V_21
				L_0402: ldc.i4.0 
				L_0403: ldloc.s V_22
				L_0405: callvirt System.IO.Stream::Void Write(Byte[], Int32, Int32)
				L_040a: ldloc.1 
				L_040b: ldc.i4.0 
				L_040c: conv.i8 
				L_040d: callvirt System.IO.Stream::Void set_Position(Int64)
				L_0412: ldloc.1 
				L_0413: stloc.2 
				L_0414: br.s L_0418
				L_0416: ldarg.0 
				L_0417: stloc.2 
				L_0418: ldc.i4 16384
				L_041d: newarr System.Byte
				L_0422: stloc.s V_23
				L_0424: ldc.i4 65794
				L_0429: newarr System.Byte
				L_042e: stloc.s V_24
				L_0430: ldc.i4 65536
				L_0435: stloc.s V_25
				L_0437: ldc.i4.0 
				L_0438: stloc.s V_26
				L_043a: ldc.i4.0 
				L_043b: stloc.s V_35
				L_043d: ldc.i4.0 
				L_043e: stloc.s V_38
				L_0440: ldc.i4.0 
				L_0441: stloc.s V_39
				L_0443: ldc.i4.0 
				L_0444: stloc.s V_40
				L_0446: ldc.i4.0 
				L_0447: stloc.s V_41
				L_0449: ldc.i4.0 
				L_044a: stloc.s V_42
				L_044c: ldc.i4.0 
				L_044d: stloc.s V_43
				L_044f: ldc.i4.0 
				L_0450: stloc.s V_44
				L_0452: ldc.i4.0 
				L_0453: stloc.s V_45
				L_0455: ldc.i4.0 
				L_0456: stloc.s V_46
				L_0458: ldc.i4.0 
				L_0459: stloc.s V_47
				L_045b: ldc.i4.0 
				L_045c: stloc.s V_48
				L_045e: ldc.i4.0 
				L_045f: stloc.s V_49
				L_0461: ldc.i4.0 
				L_0462: stloc.s V_50
				L_0464: ldc.i4.0 
				L_0465: stloc.s V_51
				L_0467: ldc.i4.0 
				L_0468: stloc.s V_52
				L_046a: ldc.i4.0 
				L_046b: stloc.s V_53
				L_046d: ldc.i4.0 
				L_046e: stloc.s V_54
				L_0470: ldc.i4.0 
				L_0471: stloc.s V_55
				L_0473: ldc.i4.0 
				L_0474: stloc.s V_56
				L_0476: ldc.i4.0 
				L_0477: stloc.s V_57
				L_0479: ldc.i4 317
				L_047e: newarr System.Int32
				L_0483: stloc.s V_58
				L_0485: ldc.i4.0 
				L_0486: dup 
				L_0487: stloc.s V_28
				L_0489: dup 
				L_048a: stloc.s V_29
				L_048c: dup 
				L_048d: stloc.s V_30
				L_048f: stloc.s V_27
				L_0491: ldloc.s V_27
				L_0493: brtrue.s L_04db
				L_0495: ldloc.s V_30
				L_0497: ldloc.s V_29
				L_0499: sub 
				L_049a: ldc.i4.4 
				L_049b: bge.s L_04aa
				L_049d: ldloc.2 
				L_049e: ldloc.s V_23
				L_04a0: ldloca.s V_29
				L_04a2: ldloca.s V_30
				L_04a4: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Boolean x573284c529e7b3c9(System.IO.Stream, Byte[], Int32 ByRef, Int32 ByRef)
				L_04a9: pop 
				L_04aa: ldloc.s V_23
				L_04ac: ldloc.s V_29
				L_04ae: ldelem.u1 
				L_04af: ldloc.s V_23
				L_04b1: ldloc.s V_29
				L_04b3: ldc.i4.1 
				L_04b4: add 
				L_04b5: ldelem.u1 
				L_04b6: ldc.i4.8 
				L_04b7: shl 
				L_04b8: add 
				L_04b9: ldloc.s V_23
				L_04bb: ldloc.s V_29
				L_04bd: ldc.i4.2 
				L_04be: add 
				L_04bf: ldelem.u1 
				L_04c0: ldc.i4.s 16
				L_04c2: shl 
				L_04c3: add 
				L_04c4: ldloc.s V_23
				L_04c6: ldloc.s V_29
				L_04c8: ldc.i4.3 
				L_04c9: add 
				L_04ca: ldelem.u1 
				L_04cb: ldc.i4.s 24
				L_04cd: shl 
				L_04ce: add 
				L_04cf: stloc.s V_28
				L_04d1: ldloc.s V_29
				L_04d3: ldc.i4.4 
				L_04d4: add 
				L_04d5: stloc.s V_29
				L_04d7: ldc.i4.s 32
				L_04d9: stloc.s V_27
				L_04db: ldloc.s V_28
				L_04dd: ldc.i4.1 
				L_04de: and 
				L_04df: stloc.s V_31
				L_04e1: ldloc.s V_28
				L_04e3: ldc.i4.1 
				L_04e4: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_04e9: stloc.s V_28
				L_04eb: ldloc.s V_27
				L_04ed: ldc.i4.1 
				L_04ee: sub 
				L_04ef: stloc.s V_27
				L_04f1: ldc.i4.2 
				L_04f2: ldloca.s V_27
				L_04f4: ldloca.s V_28
				L_04f6: ldloca.s V_29
				L_04f8: ldloc.s V_23
				L_04fa: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 x02995f229cff83b4(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_04ff: stloc.s V_12
				L_0501: ldloc.s V_12
				L_0503: brtrue L_069e
				L_0508: ldloc.s V_28
				L_050a: ldloc.s V_27
				L_050c: ldc.i4.8 
				L_050d: rem 
				L_050e: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_0513: stloc.s V_28
				L_0515: ldloc.s V_27
				L_0517: ldloc.s V_27
				L_0519: ldc.i4.8 
				L_051a: rem 
				L_051b: sub 
				L_051c: stloc.s V_27
				L_051e: ldloc.2 
				L_051f: ldloc.s V_35
				L_0521: ldc.i4.4 
				L_0522: ldloc.s V_27
				L_0524: ldloc.s V_28
				L_0526: ldloc.s V_29
				L_0528: ldloc.s V_30
				L_052a: ldloc.s V_23
				L_052c: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xabeeb97aae3dd1a9(System.IO.Stream, Int32, Int32, Int32, Int32, Int32, Int32, Byte[])
				L_0531: ldloc.s V_35
				L_0533: ldc.i4 65535
				L_0538: and 
				L_0539: stloc.s V_32
				L_053b: ldc.i4 16384
				L_0540: newarr System.Byte
				L_0545: stloc.s V_36
				L_0547: br L_0692
				L_054c: ldloc.s V_32
				L_054e: ldc.i4 16384
				L_0553: ble.s L_055e
				L_0555: ldc.i4 16384
				L_055a: stloc.s V_33
				L_055c: br.s L_0562
				L_055e: ldloc.s V_32
				L_0560: stloc.s V_33
				L_0562: ldloc.2 
				L_0563: ldloc.s V_38
				L_0565: ldloc.s V_33
				L_0567: ldloc.s V_27
				L_0569: ldloc.s V_28
				L_056b: ldloc.s V_29
				L_056d: ldloc.s V_30
				L_056f: ldloc.s V_23
				L_0571: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xabeeb97aae3dd1a9(System.IO.Stream, Int32, Int32, Int32, Int32, Int32, Int32, Byte[])
				L_0576: ldloc.s V_33
				L_0578: stloc.s V_39
				L_057a: ldloc.s V_26
				L_057c: ldloc.s V_25
				L_057e: blt L_0692
				L_0583: ldarg.2 
				L_0584: ldloc.s V_24
				L_0586: ldc.i4.0 
				L_0587: ldc.i4 32768
				L_058c: callvirt System.IO.Stream::Void Write(Byte[], Int32, Int32)
				L_0591: ldc.i4 32768
				L_0596: stloc.s V_40
				L_0598: ldc.i4.0 
				L_0599: stloc.s V_10
				L_059b: br.s L_05ad
				L_059d: ldloc.s V_36
				L_059f: ldloc.s V_10
				L_05a1: ldloc.s V_24
				L_05a3: ldloc.s V_10
				L_05a5: ldelem.u1 
				L_05a6: stelem.i1 
				L_05a7: ldloc.s V_10
				L_05a9: ldc.i4.1 
				L_05aa: add 
				L_05ab: stloc.s V_10
				L_05ad: ldloc.s V_10
				L_05af: ldloc.s V_26
				L_05b1: ldloc.s V_40
				L_05b3: sub 
				L_05b4: blt.s L_059d
				L_05b6: ldloc.s V_36
				L_05b8: stloc.s V_37
				L_05ba: ldloc.s V_25
				L_05bc: ldloc.s V_26
				L_05be: sub 
				L_05bf: stloc.s V_34
				L_05c1: ldloc.s V_34
				L_05c3: ldloc.s V_39
				L_05c5: ble.s L_05cb
				L_05c7: ldloc.s V_39
				L_05c9: stloc.s V_34
				L_05cb: ldc.i4.0 
				L_05cc: stloc.s V_10
				L_05ce: br.s L_05e0
				L_05d0: ldloc.s V_37
				L_05d2: ldloc.s V_10
				L_05d4: ldloc.s V_24
				L_05d6: ldloc.s V_26
				L_05d8: ldelem.u1 
				L_05d9: stelem.i1 
				L_05da: ldloc.s V_10
				L_05dc: ldc.i4.1 
				L_05dd: add 
				L_05de: stloc.s V_10
				L_05e0: ldloc.s V_10
				L_05e2: ldloc.s V_34
				L_05e4: blt.s L_05d0
				L_05e6: ldloc.s V_26
				L_05e8: ldloc.s V_34
				L_05ea: add 
				L_05eb: stloc.s V_26
				L_05ed: ldloc.s V_34
				L_05ef: ldloc.s V_39
				L_05f1: sub 
				L_05f2: stloc.s V_34
				L_05f4: ldc.i4.0 
				L_05f5: stloc.s V_41
				L_05f7: br L_0683
				L_05fc: ldloc.s V_41
				L_05fe: ldloc.s V_34
				L_0600: add 
				L_0601: stloc.s V_41
				L_0603: ldarg.2 
				L_0604: ldloc.s V_24
				L_0606: ldc.i4.0 
				L_0607: ldc.i4 32768
				L_060c: callvirt System.IO.Stream::Void Write(Byte[], Int32, Int32)
				L_0611: ldc.i4 32768
				L_0616: stloc.s V_40
				L_0618: ldc.i4.0 
				L_0619: stloc.s V_10
				L_061b: br.s L_0630
				L_061d: ldloc.s V_24
				L_061f: ldloc.s V_10
				L_0621: ldloc.s V_24
				L_0623: ldloc.s V_40
				L_0625: ldloc.s V_10
				L_0627: add 
				L_0628: ldelem.u1 
				L_0629: stelem.i1 
				L_062a: ldloc.s V_10
				L_062c: ldc.i4.1 
				L_062d: add 
				L_062e: stloc.s V_10
				L_0630: ldloc.s V_10
				L_0632: ldloc.s V_26
				L_0634: ldloc.s V_40
				L_0636: sub 
				L_0637: blt.s L_061d
				L_0639: ldloc.s V_26
				L_063b: ldc.i4 32768
				L_0640: sub 
				L_0641: stloc.s V_26
				L_0643: ldloc.s V_25
				L_0645: ldloc.s V_26
				L_0647: sub 
				L_0648: stloc.s V_34
				L_064a: ldloc.s V_34
				L_064c: ldloc.s V_39
				L_064e: ble.s L_0654
				L_0650: ldloc.s V_39
				L_0652: stloc.s V_34
				L_0654: ldc.i4.0 
				L_0655: stloc.s V_10
				L_0657: br.s L_066f
				L_0659: ldloc.s V_24
				L_065b: ldloc.s V_26
				L_065d: ldloc.s V_10
				L_065f: add 
				L_0660: ldloc.s V_37
				L_0662: ldloc.s V_41
				L_0664: ldloc.s V_10
				L_0666: add 
				L_0667: ldelem.u1 
				L_0668: stelem.i1 
				L_0669: ldloc.s V_10
				L_066b: ldc.i4.1 
				L_066c: add 
				L_066d: stloc.s V_10
				L_066f: ldloc.s V_10
				L_0671: ldloc.s V_34
				L_0673: blt.s L_0659
				L_0675: ldloc.s V_26
				L_0677: ldloc.s V_34
				L_0679: add 
				L_067a: stloc.s V_26
				L_067c: ldloc.s V_34
				L_067e: ldloc.s V_39
				L_0680: sub 
				L_0681: stloc.s V_34
				L_0683: ldloc.s V_39
				L_0685: ldc.i4.0 
				L_0686: bgt L_05fc
				L_068b: ldloc.s V_32
				L_068d: ldloc.s V_33
				L_068f: sub 
				L_0690: stloc.s V_32
				L_0692: ldloc.s V_32
				L_0694: brtrue L_054c
				L_0699: br L_0972
				L_069e: ldloc.s V_12
				L_06a0: ldc.i4.2 
				L_06a1: bne.un L_0934
				L_06a6: ldc.i4.5 
				L_06a7: ldloca.s V_27
				L_06a9: ldloca.s V_28
				L_06ab: ldloca.s V_29
				L_06ad: ldloc.s V_23
				L_06af: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 x02995f229cff83b4(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_06b4: ldc.i4 257
				L_06b9: add 
				L_06ba: stloc.s V_55
				L_06bc: ldc.i4.5 
				L_06bd: ldloca.s V_27
				L_06bf: ldloca.s V_28
				L_06c1: ldloca.s V_29
				L_06c3: ldloc.s V_23
				L_06c5: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 x02995f229cff83b4(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_06ca: ldc.i4.1 
				L_06cb: add 
				L_06cc: stloc.s V_56
				L_06ce: ldc.i4.4 
				L_06cf: ldloca.s V_27
				L_06d1: ldloca.s V_28
				L_06d3: ldloca.s V_29
				L_06d5: ldloc.s V_23
				L_06d7: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 x02995f229cff83b4(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_06dc: ldc.i4.4 
				L_06dd: add 
				L_06de: stloc.s V_57
				L_06e0: ldloc.s V_55
				L_06e2: ldc.i4 286
				L_06e7: bgt.s L_06ef
				L_06e9: ldloc.s V_56
				L_06eb: ldc.i4.s 30
				L_06ed: ble.s L_06fa
				L_06ef: ldstr "Unknown error"
				L_06f4: newobj System.Exception::Void .ctor(System.String)
				L_06f9: throw 
				L_06fa: ldc.i4.0 
				L_06fb: stloc.s V_10
				L_06fd: br.s L_070b
				L_06ff: ldloc.s V_58
				L_0701: ldloc.s V_10
				L_0703: ldc.i4.0 
				L_0704: stelem.i4 
				L_0705: ldloc.s V_10
				L_0707: ldc.i4.1 
				L_0708: add 
				L_0709: stloc.s V_10
				L_070b: ldloc.s V_10
				L_070d: ldc.i4.s 19
				L_070f: blt.s L_06ff
				L_0711: ldc.i4.0 
				L_0712: stloc.s V_10
				L_0714: br.s L_0735
				L_0716: ldloc.s V_58
				L_0718: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Byte[] x79346f529f25ee2d
				L_071d: ldloc.s V_10
				L_071f: ldelem.u1 
				L_0720: ldc.i4.3 
				L_0721: ldloca.s V_27
				L_0723: ldloca.s V_28
				L_0725: ldloca.s V_29
				L_0727: ldloc.s V_23
				L_0729: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 x02995f229cff83b4(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_072e: stelem.i4 
				L_072f: ldloc.s V_10
				L_0731: ldc.i4.1 
				L_0732: add 
				L_0733: stloc.s V_10
				L_0735: ldloc.s V_10
				L_0737: ldloc.s V_57
				L_0739: blt.s L_0716
				L_073b: ldc.i4.7 
				L_073c: newobj Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Void .ctor(Int32)
				L_0741: stloc.s V_59
				L_0743: ldloc.s V_59
				L_0745: ldloc.s V_58
				L_0747: ldc.i4.0 
				L_0748: ldc.i4.s 19
				L_074a: ldc.i4.0 
				L_074b: newarr System.Byte
				L_0750: ldc.i4 65535
				L_0755: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Void xda09af88ab899a50(Int32[], Int32, Int32, Byte[], Int32)
				L_075a: ldc.i4.0 
				L_075b: stloc.s V_10
				L_075d: br.s L_076b
				L_075f: ldloc.s V_58
				L_0761: ldloc.s V_10
				L_0763: ldc.i4.0 
				L_0764: stelem.i4 
				L_0765: ldloc.s V_10
				L_0767: ldc.i4.1 
				L_0768: add 
				L_0769: stloc.s V_10
				L_076b: ldloc.s V_10
				L_076d: ldloc.s V_58
				L_076f: ldlen 
				L_0770: conv.i4 
				L_0771: blt.s L_075f
				L_0773: ldc.i4.0 
				L_0774: stloc.s V_42
				L_0776: br L_08b8
				L_077b: ldloc.s V_59
				L_077d: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 get_xc5207dd50e2ff5b4()
				L_0782: ldc.i4.7 
				L_0783: add 
				L_0784: stloc.s V_43
				L_0786: ldloc.2 
				L_0787: ldloca.s V_43
				L_0789: ldloca.s V_27
				L_078b: ldloca.s V_28
				L_078d: ldloca.s V_29
				L_078f: ldloca.s V_30
				L_0791: ldloc.s V_23
				L_0793: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa13f94e29dbd5d94(System.IO.Stream, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_0798: stloc.s V_44
				L_079a: ldloc.s V_44
				L_079c: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] xd4434a4392e36da6
				L_07a1: ldloc.s V_59
				L_07a3: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 get_xc5207dd50e2ff5b4()
				L_07a8: ldc.i4.1 
				L_07a9: sub 
				L_07aa: ldelem.i4 
				L_07ab: and 
				L_07ac: stloc.s V_45
				L_07ae: ldloc.s V_59
				L_07b0: ldloc.s V_45
				L_07b2: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 xf76803be5e9ee2aa(Int32)
				L_07b7: stloc.s V_46
				L_07b9: ldloc.s V_46
				L_07bb: ldc.i4 65535
				L_07c0: and 
				L_07c1: stloc.s V_54
				L_07c3: ldloc.s V_46
				L_07c5: ldc.i4.s 16
				L_07c7: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_07cc: ldc.i4 255
				L_07d1: and 
				L_07d2: stloc.s V_49
				L_07d4: ldloc.s V_54
				L_07d6: ldc.i4.s 15
				L_07d8: bgt.s L_07fb
				L_07da: ldloc.s V_58
				L_07dc: ldloc.s V_42
				L_07de: ldloc.s V_54
				L_07e0: stelem.i4 
				L_07e1: ldloc.s V_42
				L_07e3: ldc.i4.1 
				L_07e4: add 
				L_07e5: stloc.s V_42
				L_07e7: ldloc.s V_49
				L_07e9: ldloca.s V_27
				L_07eb: ldloca.s V_28
				L_07ed: ldloca.s V_29
				L_07ef: ldloc.s V_23
				L_07f1: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xa4bb90c5f325d0af(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_07f6: br L_08b8
				L_07fb: ldloc.s V_54
				L_07fd: ldc.i4.s 16
				L_07ff: bne.un.s L_0852
				L_0801: ldc.i4.3 
				L_0802: ldloc.s V_44
				L_0804: ldloc.s V_49
				L_0806: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_080b: ldc.i4.3 
				L_080c: and 
				L_080d: add 
				L_080e: stloc.s V_50
				L_0810: ldloc.s V_58
				L_0812: ldloc.s V_42
				L_0814: ldc.i4.1 
				L_0815: sub 
				L_0816: ldelem.i4 
				L_0817: stloc.s V_54
				L_0819: ldc.i4.0 
				L_081a: stloc.s V_10
				L_081c: br.s L_082e
				L_081e: ldloc.s V_58
				L_0820: ldloc.s V_42
				L_0822: ldloc.s V_10
				L_0824: add 
				L_0825: ldloc.s V_54
				L_0827: stelem.i4 
				L_0828: ldloc.s V_10
				L_082a: ldc.i4.1 
				L_082b: add 
				L_082c: stloc.s V_10
				L_082e: ldloc.s V_10
				L_0830: ldloc.s V_50
				L_0832: blt.s L_081e
				L_0834: ldloc.s V_42
				L_0836: ldloc.s V_50
				L_0838: add 
				L_0839: stloc.s V_42
				L_083b: ldloc.s V_49
				L_083d: ldc.i4.2 
				L_083e: add 
				L_083f: stloc.s V_43
				L_0841: ldloc.s V_43
				L_0843: ldloca.s V_27
				L_0845: ldloca.s V_28
				L_0847: ldloca.s V_29
				L_0849: ldloc.s V_23
				L_084b: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xa4bb90c5f325d0af(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_0850: br.s L_08b8
				L_0852: ldloc.s V_54
				L_0854: ldc.i4.s 17
				L_0856: bne.un.s L_0885
				L_0858: ldc.i4.3 
				L_0859: ldloc.s V_44
				L_085b: ldloc.s V_49
				L_085d: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_0862: ldc.i4.7 
				L_0863: and 
				L_0864: add 
				L_0865: stloc.s V_50
				L_0867: ldloc.s V_42
				L_0869: ldloc.s V_50
				L_086b: add 
				L_086c: stloc.s V_42
				L_086e: ldloc.s V_49
				L_0870: ldc.i4.3 
				L_0871: add 
				L_0872: stloc.s V_43
				L_0874: ldloc.s V_43
				L_0876: ldloca.s V_27
				L_0878: ldloca.s V_28
				L_087a: ldloca.s V_29
				L_087c: ldloc.s V_23
				L_087e: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xa4bb90c5f325d0af(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_0883: br.s L_08b8
				L_0885: ldloc.s V_54
				L_0887: ldc.i4.s 18
				L_0889: bne.un.s L_08b8
				L_088b: ldc.i4.s 11
				L_088d: ldloc.s V_44
				L_088f: ldloc.s V_49
				L_0891: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_0896: ldc.i4.s 127
				L_0898: and 
				L_0899: add 
				L_089a: stloc.s V_50
				L_089c: ldloc.s V_42
				L_089e: ldloc.s V_50
				L_08a0: add 
				L_08a1: stloc.s V_42
				L_08a3: ldloc.s V_49
				L_08a5: ldc.i4.7 
				L_08a6: add 
				L_08a7: stloc.s V_43
				L_08a9: ldloc.s V_43
				L_08ab: ldloca.s V_27
				L_08ad: ldloca.s V_28
				L_08af: ldloca.s V_29
				L_08b1: ldloc.s V_23
				L_08b3: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xa4bb90c5f325d0af(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_08b8: ldloc.s V_42
				L_08ba: ldloc.s V_55
				L_08bc: ldloc.s V_56
				L_08be: add 
				L_08bf: blt L_077b
				L_08c4: ldc.i4.s 15
				L_08c6: newobj Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Void .ctor(Int32)
				L_08cb: stloc.s V_60
				L_08cd: ldloc.s V_60
				L_08cf: ldloc.s V_58
				L_08d1: ldc.i4.0 
				L_08d2: ldloc.s V_55
				L_08d4: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Byte[] xcf1e65d83cd6b794
				L_08d9: ldc.i4 257
				L_08de: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Void xda09af88ab899a50(Int32[], Int32, Int32, Byte[], Int32)
				L_08e3: ldc.i4.s 15
				L_08e5: newobj Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Void .ctor(Int32)
				L_08ea: stloc.s V_61
				L_08ec: ldloc.s V_61
				L_08ee: ldloc.s V_58
				L_08f0: ldloc.s V_55
				L_08f2: ldloc.s V_56
				L_08f4: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Byte[] xc9fe980725d32ac6
				L_08f9: ldc.i4.0 
				L_08fa: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Void xda09af88ab899a50(Int32[], Int32, Int32, Byte[], Int32)
				L_08ff: ldloc.s V_60
				L_0901: ldloc.s V_61
				L_0903: ldloc.2 
				L_0904: ldarg.2 
				L_0905: ldloca.s V_43
				L_0907: ldloca.s V_27
				L_0909: ldloca.s V_28
				L_090b: ldloca.s V_44
				L_090d: ldloca.s V_45
				L_090f: ldloca.s V_46
				L_0911: ldloca.s V_54
				L_0913: ldloca.s V_49
				L_0915: ldloca.s V_47
				L_0917: ldloca.s V_48
				L_0919: ldloca.s V_51
				L_091b: ldloca.s V_29
				L_091d: ldloca.s V_30
				L_091f: ldloc.s V_23
				L_0921: ldloca.s V_26
				L_0923: ldloca.s V_25
				L_0925: ldloc.s V_24
				L_0927: ldloca.s V_40
				L_0929: ldloca.s V_52
				L_092b: ldloca.s V_53
				L_092d: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xf76803be5e9ee2aa(Sunisoft.IrisSkin.xb0f0f2071b49b1cb, Sunisoft.IrisSkin.xb0f0f2071b49b1cb, System.IO.Stream, System.IO.Stream, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[], Int32 ByRef, Int32 ByRef, Byte[], Int32 ByRef, Int32 ByRef, Int32 ByRef)
				L_0932: br.s L_0972
				L_0934: ldloc.s V_12
				L_0936: ldc.i4.1 
				L_0937: bne.un.s L_0972
				L_0939: ldsfld Sunisoft.IrisSkin.x2b13dab2573bcd5e::Sunisoft.IrisSkin.xb0f0f2071b49b1cb x36ab34a1d2fe3af6
				L_093e: ldsfld Sunisoft.IrisSkin.x2b13dab2573bcd5e::Sunisoft.IrisSkin.xb0f0f2071b49b1cb x05f724456b7f79d1
				L_0943: ldloc.2 
				L_0944: ldarg.2 
				L_0945: ldloca.s V_43
				L_0947: ldloca.s V_27
				L_0949: ldloca.s V_28
				L_094b: ldloca.s V_44
				L_094d: ldloca.s V_45
				L_094f: ldloca.s V_46
				L_0951: ldloca.s V_54
				L_0953: ldloca.s V_49
				L_0955: ldloca.s V_47
				L_0957: ldloca.s V_48
				L_0959: ldloca.s V_51
				L_095b: ldloca.s V_29
				L_095d: ldloca.s V_30
				L_095f: ldloc.s V_23
				L_0961: ldloca.s V_26
				L_0963: ldloca.s V_25
				L_0965: ldloc.s V_24
				L_0967: ldloca.s V_40
				L_0969: ldloca.s V_52
				L_096b: ldloca.s V_53
				L_096d: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xf76803be5e9ee2aa(Sunisoft.IrisSkin.xb0f0f2071b49b1cb, Sunisoft.IrisSkin.xb0f0f2071b49b1cb, System.IO.Stream, System.IO.Stream, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[], Int32 ByRef, Int32 ByRef, Byte[], Int32 ByRef, Int32 ByRef, Int32 ByRef)
				L_0972: ldloc.s V_31
				L_0974: brfalse L_0491
				L_0979: ldloc.s V_26
				L_097b: brfalse.s L_0988
				L_097d: ldarg.2 
				L_097e: ldloc.s V_24
				L_0980: ldc.i4.0 
				L_0981: ldloc.s V_26
				L_0983: callvirt System.IO.Stream::Void Write(Byte[], Int32, Int32)
				L_0988: leave.s L_09ac
				L_098a: stloc.s V_62
				L_098c: ldloc.s V_62
				L_098e: callvirt System.Exception::System.String get_Message()
				L_0993: ldstr "Password"
				L_0998: call System.String::Boolean op_Equality(System.String, System.String)
				L_099d: brfalse.s L_09a3
				L_099f: ldc.i4.2 
				L_09a0: stloc.0 
				L_09a1: br.s L_09a5
				L_09a3: ldc.i4.1 
				L_09a4: stloc.0 
				L_09a5: leave.s L_09ac
				L_09a7: pop 
				L_09a8: ldc.i4.1 
				L_09a9: stloc.0 
				L_09aa: leave.s L_09ac
				L_09ac: ldarg.2 
				L_09ad: brfalse.s L_09d2
				L_09af: ldloc.0 
				L_09b0: brtrue.s L_09d2
				L_09b2: ldarg.2 
				L_09b3: callvirt System.IO.Stream::Int64 get_Length()
				L_09b8: ldc.i4.0 
				L_09b9: conv.i8 
				L_09ba: bne.un.s L_09c0
				L_09bc: ldc.i4.1 
				L_09bd: stloc.0 
				L_09be: br.s L_09d2
				L_09c0: ldarg.2 
				L_09c1: callvirt System.IO.Stream::Int64 get_Length()
				L_09c6: ldloca.s V_6
				L_09c8: ldfld Sunisoft.IrisSkin.x181df638a52dfd1a::Int32 xc49fe6a8d63d6783
				L_09cd: conv.i8 
				L_09ce: beq.s L_09d2
				L_09d0: ldc.i4.2 
				L_09d1: stloc.0 
				L_09d2: ldloc.0 
				L_09d3: ret 
			*/
			
			
			{
				Stream stream1;
				Stream stream2;
				xf85cd48011a0ce1f xf85cd48011a0ce1f1;
				x895eb13ee3f5b8cc x895eb13ee3f5b8cc1;
				byte[] byteArray1;
				uint uInt32_1;
				int i2;
				int i3;
				int i4;
				int i5;
				int i6;
				byte[] byteArray2;
				int i7;
				byte[] byteArray3;
				int i8;
				byte[] byteArray4;
				int i9;
				byte[] byteArray5;
				byte[] byteArray6;
				int i10;
				int i11;
				int i12;
				int i13;
				int i14;
				int i15;
				int i16;
				int i17;
				int i18;
				int i19;
				int i20;
				byte[] byteArray7;
				byte[] byteArray8;
				int i21;
				int i22;
				int i23;
				int i24;
				int i25;
				int i26;
				int i27;
				int i28;
				int i29;
				int i30;
				int i31;
				int i32;
				int i33;
				int i34;
				int i35;
				int i36;
				int i37;
				int i38;
				int i39;
				int i40;
				int[] int32Array1;
				Ixb0f0f2071b49b1cb xb0f0f2071b49b1cb1;
				Ixb0f0f2071b49b1cb xb0f0f2071b49b1cb2;
				Ixb0f0f2071b49b1cb xb0f0f2071b49b1cb3;
				ArgumentException argumentException1;
				xfba9214ce91902fb xfba9214ce91902fb1 = xfba9214ce91902fb.xfbacefb914bc4cc3;
				BinaryReader binaryReader1 = ((BinaryReader) null);
				long int64_1 = 0L;
				x181df638a52dfd1a x181df638a52dfd1a1 = new x181df638a52dfd1a ();
				bool b1 = false;
				int i1 = 0;
				try
				{
					binaryReader1 = new BinaryReader (xe6d4e9629d861369);
					long int64_2 = xe6d4e9629d861369.Seek (0L, SeekOrigin.Begin);
					uInt32_1 = binaryReader1.ReadUInt32 ();
					if ((((int) uInt32_1) & 65535) != 19283)
					{
						throw new Exception ("not a zip file");
					}
					int64_1 = x2b13dab2573bcd5e.xd54e92c965f241a7 (xe6d4e9629d861369);
					if (int64_1 < ((long) 0))
					{
						throw new Exception ("invalid zip file");
					}
					if ((xf85cd48011a0ce1f1 = ((xf85cd48011a0ce1f) x2b13dab2573bcd5e.x49cceb88e1b6126e (binaryReader1, typeof (xf85cd48011a0ce1f), Marshal.SizeOf (typeof (xf85cd48011a0ce1f))))).x1096c029cd840ebb > 0)
					{
						long int64_3 = xe6d4e9629d861369.Seek (((long) xf85cd48011a0ce1f1.x1096c029cd840ebb), SeekOrigin.Begin);
					}
					long int64_4 = xe6d4e9629d861369.Seek (((long) xf85cd48011a0ce1f1.xc7e71a29d94c1d16), SeekOrigin.Begin);
					while (xe6d4e9629d861369.Position < int64_1)
					{
						byteArray1 = binaryReader1.ReadBytes (((int) (x181df638a52dfd1a1 = ((x181df638a52dfd1a) x2b13dab2573bcd5e.x49cceb88e1b6126e (binaryReader1, typeof (x181df638a52dfd1a), Marshal.SizeOf (typeof (x181df638a52dfd1a))))).x46898d46d844ffad));
						if (Encoding.Default.GetString (byteArray1).ToUpper () == xb07d2e5a1b230779.ToUpper ())
						{
							b1 = true;
							break;
						}
					}
					if (! b1)
					{
						throw new FileNotFoundException (xb07d2e5a1b230779);
					}
					long int64_5 = xe6d4e9629d861369.Seek (((long) x181df638a52dfd1a1.x0cced477dfc63bfd), SeekOrigin.Begin);
					long int64_6 = xe6d4e9629d861369.Seek (((long) (x895eb13ee3f5b8cc1 = ((x895eb13ee3f5b8cc) x2b13dab2573bcd5e.x49cceb88e1b6126e (binaryReader1, typeof (x895eb13ee3f5b8cc), Marshal.SizeOf (typeof (x895eb13ee3f5b8cc))))).x46898d46d844ffad), SeekOrigin.Current);
					if (x895eb13ee3f5b8cc1.x14b554dbc9986975 > 0)
					{
						long int64_7 = xe6d4e9629d861369.Seek (((long) x895eb13ee3f5b8cc1.x14b554dbc9986975), SeekOrigin.Current);
					}
					i2 = 0;
					if (((x181df638a52dfd1a1.x07a186fde5854829 & 1) != 0) && ((xe8e4b5871d71a79a == null) || (xe8e4b5871d71a79a == "")))
					{
						throw new ArgumentException ("Password");
					}
					if ((xe8e4b5871d71a79a == null) || (xe8e4b5871d71a79a == ""))
					{
						stream2 = xe6d4e9629d861369;
					}
					else
					{
						i3 = 305419896;
						i4 = 591751049;
						i5 = 878082192;
						i6 = 134775813;
						byteArray2 = binaryReader1.ReadBytes (12);
						for (i1 = 1; (i1 <= xe8e4b5871d71a79a.Length); i1++)
						{
							i7 = Convert.ToInt32 (xe8e4b5871d71a79a[((int) (i1 - 1))]);
							i3 = x2b13dab2573bcd5e.x19339fe0ba40cd55 (((long) (((long) x71589e3f55261426.x6ee31887cc8af8eb[((i3 ^ i7) & 255)]) ^ ((long) (x2b13dab2573bcd5e.xa52147d0d9c2c73c (i3, 8) & 16777215)))));
							i4 += (i3 & 255);
							i4 = ((i4 * i6) + 1);
							i5 = x2b13dab2573bcd5e.x19339fe0ba40cd55 (((long) (((long) x71589e3f55261426.x6ee31887cc8af8eb[((i5 ^ x2b13dab2573bcd5e.xa52147d0d9c2c73c (i4, 24)) & 255)]) ^ ((long) (x2b13dab2573bcd5e.xa52147d0d9c2c73c (i5, 8) & 16777215)))));
						}
						byteArray3 = new byte[12];
						for (i1 = 0; (i1 < 12); i1++)
						{
							i2 = ((i5 & 65535) | 2);
							byteArray3[i1] = x2b13dab2573bcd5e.x8885d1fc1e00dd5c (((int) (((int) byteArray2[i1]) ^ ((i2 * (i2 ^ 1)) >> 8))));
							i3 = x2b13dab2573bcd5e.x19339fe0ba40cd55 (((long) (((long) x71589e3f55261426.x6ee31887cc8af8eb[((i3 ^ ((int) byteArray3[i1])) & 255)]) ^ ((long) (x2b13dab2573bcd5e.xa52147d0d9c2c73c (i3, 8) & 16777215)))));
							i4 += (i3 & 255);
							i4 = ((i4 * i6) + 1);
							i5 = x2b13dab2573bcd5e.x19339fe0ba40cd55 (((long) (((long) x71589e3f55261426.x6ee31887cc8af8eb[((i5 ^ x2b13dab2573bcd5e.xa52147d0d9c2c73c (i4, 24)) & 255)]) ^ ((long) (x2b13dab2573bcd5e.xa52147d0d9c2c73c (i5, 8) & 16777215)))));
						}
						if ((x181df638a52dfd1a1.x07a186fde5854829 & 8) == 8)
						{
							i8 = ((int) (x181df638a52dfd1a1.xbb36eda94c9adabc << 16));
						}
						else
						{
							i8 = x181df638a52dfd1a1.x41fcadcc0506e331;
						}
						if (xe24cbd369cdd075a.x544f68ae4f70de0e (i8).xcb734f8c3043b335 != byteArray3[11])
						{
							throw new ArgumentException ("Password");
						}
						else
						{
							stream1 = ((Stream) new MemoryStream ());
							byteArray4 = new byte[1024];
							for (i9 = xe6d4e9629d861369.Read (byteArray4, 0, 1024); (i9 == 1024); i9 = xe6d4e9629d861369.Read (byteArray4, 0, 1024))
							{
								x2b13dab2573bcd5e.xe12a5d7e190699b3 (byteArray4, 1024, ref i3, ref i4, ref i5, i6);
								stream1.Write (byteArray4, 0, 1024);
							}
							x2b13dab2573bcd5e.xe12a5d7e190699b3 (byteArray4, i9, ref i3, ref i4, ref i5, i6);
							stream1.Write (byteArray4, 0, i9);
							stream1.Position = 0L;
							stream2 = stream1;
						}
					}
					byteArray5 = new byte[16384];
					byteArray6 = new byte[65794];
					i10 = 65536;
					i11 = 0;
					i20 = 0;
					i21 = 0;
					i22 = 0;
					i23 = 0;
					i24 = 0;
					i25 = 0;
					i26 = 0;
					i27 = 0;
					i28 = 0;
					i29 = 0;
					i30 = 0;
					i31 = 0;
					i32 = 0;
					i33 = 0;
					i34 = 0;
					i35 = 0;
					i36 = 0;
					i37 = 0;
					i38 = 0;
					i39 = 0;
					i40 = 0;
					int32Array1 = new int[317];
					i13 = 0;
					i14 = i13;
					i15 = i14;
					i12 = i15;
					
				L_0491:
					
					{
					}
					if (i12 == 0)
					{
						if ((i15 - i14) < 4)
						{
							bool b2 = x2b13dab2573bcd5e.x573284c529e7b3c9 (stream2, byteArray5, ref i14, ref i15);
						}
						i13 = ((int) (((byteArray5[i14] + (byteArray5[(i14 + 1)] << 8)) + (byteArray5[(i14 + 2)] << 16)) + (byteArray5[(i14 + 3)] << 24)));
						i14 += 4;
						i12 = 32;
					}
					i16 = (i13 & 1);
					i13 = x2b13dab2573bcd5e.xa52147d0d9c2c73c (i13, 1);
					i12--;
					i2 = x2b13dab2573bcd5e.x02995f229cff83b4 (2, ref i12, ref i13, ref i14, byteArray5);
					if (i2 == 0)
					{
						i13 = x2b13dab2573bcd5e.xa52147d0d9c2c73c (i13, ((int) (i12 % 8)));
						i12 -= (i12 % 8);
						x2b13dab2573bcd5e.xabeeb97aae3dd1a9 (stream2, i20, 4, i12, i13, i14, i15, byteArray5);
						i17 = (i20 & 65535);
						byteArray7 = new byte[16384];
						while (i17 != 0)
						{
							if (i17 <= 16384)
							{
								i18 = i17;
							}
							else
							{
								i18 = 16384;
							}
							x2b13dab2573bcd5e.xabeeb97aae3dd1a9 (stream2, i21, i18, i12, i13, i14, i15, byteArray5);
							i22 = i18;
							if (i11 >= i10)
							{
								x5ab6ed99b3041647.Write (byteArray6, 0, 32768);
								i23 = 32768;
								for (i1 = 0; (i1 < (i11 - i23)); i1++)
								{
									byteArray7[i1] = byteArray6[i1];
								}
								byteArray8 = byteArray7;
								i19 = (i10 - i11);
								if (i19 > i22)
								{
									i19 = i22;
								}
								for (i1 = 0; (i1 < i19); i1++)
								{
									byteArray8[i1] = byteArray6[i11];
								}
								i11 += i19;
								i19 -= i22;
								i24 = 0;
								while (i22 > 0)
								{
									i24 += i19;
									x5ab6ed99b3041647.Write (byteArray6, 0, 32768);
									i23 = 32768;
									for (i1 = 0; (i1 < (i11 - i23)); i1++)
									{
										byteArray6[i1] = byteArray6[(i23 + i1)];
									}
									i11 -= 32768;
									i19 = (i10 - i11);
									if (i19 > i22)
									{
										i19 = i22;
									}
									for (i1 = 0; (i1 < i19); i1++)
									{
										byteArray6[(i11 + i1)] = byteArray8[(i24 + i1)];
									}
									i11 += i19;
									i19 -= i22;
								}
								i17 -= i18;
							}
						}
					}
					else if (i2 == 2)
					{
						i38 = (x2b13dab2573bcd5e.x02995f229cff83b4 (5, ref i12, ref i13, ref i14, byteArray5) + 257);
						i39 = (x2b13dab2573bcd5e.x02995f229cff83b4 (5, ref i12, ref i13, ref i14, byteArray5) + 1);
						i40 = (x2b13dab2573bcd5e.x02995f229cff83b4 (4, ref i12, ref i13, ref i14, byteArray5) + 4);
						if ((i38 > 286) || (i39 > 30))
						{
							throw new Exception ("Unknown error");
						}
						else
						{
							for (i1 = 0; (i1 < 19); i1++)
							{
								int32Array1[i1] = 0;
							}
							for (i1 = 0; (i1 < i40); i1++)
							{
								int32Array1[((int) x71589e3f55261426.x79346f529f25ee2d[i1])] = x2b13dab2573bcd5e.x02995f229cff83b4 (3, ref i12, ref i13, ref i14, byteArray5);
							}
							xb0f0f2071b49b1cb1 = new xb0f0f2071b49b1cb (7);
							((Ixb0f0f2071b49b1cb) xb0f0f2071b49b1cb1).xda09af88ab899a50 (int32Array1, 0, 19, new byte[0], 65535);
							for (i1 = 0; (i1 < int32Array1.Length); i1++)
							{
								int32Array1[i1] = 0;
							}
							i25 = 0;
							while (i25 < (i38 + i39))
							{
								i26 = (((Ixb0f0f2071b49b1cb) xb0f0f2071b49b1cb1).xc5207dd50e2ff5b4 + 7);
								i27 = x2b13dab2573bcd5e.xa13f94e29dbd5d94 (stream2, ref i26, ref i12, ref i13, ref i14, ref i15, byteArray5);
								i28 = (i27 & x71589e3f55261426.xd4434a4392e36da6[(((Ixb0f0f2071b49b1cb) xb0f0f2071b49b1cb1).xc5207dd50e2ff5b4 - 1)]);
								i29 = ((Ixb0f0f2071b49b1cb) xb0f0f2071b49b1cb1).xf76803be5e9ee2aa (i28);
								i37 = (i29 & 65535);
								i32 = (x2b13dab2573bcd5e.xa52147d0d9c2c73c (i29, 16) & 255);
								if (i37 > 15)
								{
									if (i37 != 16)
									{
										if (i37 != 17)
										{
											if (i37 == 18)
											{
												i33 = ((int) (11 + (x2b13dab2573bcd5e.xa52147d0d9c2c73c (i27, i32) & sbyte.MaxValue)));
												i25 += i33;
												i26 = (i32 + 7);
												x2b13dab2573bcd5e.xa4bb90c5f325d0af (i26, ref i12, ref i13, ref i14, byteArray5);
											}
											continue;
										}
										i33 = (3 + (x2b13dab2573bcd5e.xa52147d0d9c2c73c (i27, i32) & 7));
										i25 += i33;
										i26 = (i32 + 3);
										x2b13dab2573bcd5e.xa4bb90c5f325d0af (i26, ref i12, ref i13, ref i14, byteArray5);
										continue;
									}
									i33 = (3 + (x2b13dab2573bcd5e.xa52147d0d9c2c73c (i27, i32) & 3));
									i37 = int32Array1[(i25 - 1)];
									for (i1 = 0; (i1 < i33); i1++)
									{
										int32Array1[(i25 + i1)] = i37;
									}
									i25 += i33;
									i26 = (i32 + 2);
									x2b13dab2573bcd5e.xa4bb90c5f325d0af (i26, ref i12, ref i13, ref i14, byteArray5);
									continue;
								}
								int32Array1[i25] = i37;
								i25++;
								x2b13dab2573bcd5e.xa4bb90c5f325d0af (i32, ref i12, ref i13, ref i14, byteArray5);
							}
							xb0f0f2071b49b1cb2 = new xb0f0f2071b49b1cb (15);
							((Ixb0f0f2071b49b1cb) xb0f0f2071b49b1cb2).xda09af88ab899a50 (int32Array1, 0, i38, x71589e3f55261426.xcf1e65d83cd6b794, 257);
							xb0f0f2071b49b1cb3 = new xb0f0f2071b49b1cb (15);
							((Ixb0f0f2071b49b1cb) xb0f0f2071b49b1cb3).xda09af88ab899a50 (int32Array1, i38, i39, x71589e3f55261426.xc9fe980725d32ac6, 0);
							x2b13dab2573bcd5e.xf76803be5e9ee2aa (xb0f0f2071b49b1cb2, xb0f0f2071b49b1cb3, stream2, x5ab6ed99b3041647, ref i26, ref i12, ref i13, ref i27, ref i28, ref i29, 
							ref i37, ref i32, ref i30, ref i31, ref i34, ref i14, ref i15, byteArray5, ref i11, ref i10, 
							byteArray6, ref i23, ref i35, ref i36);
						}
					}
					else if (i2 == 1)
					{
						x2b13dab2573bcd5e.xf76803be5e9ee2aa (x2b13dab2573bcd5e.x36ab34a1d2fe3af6, x2b13dab2573bcd5e.x05f724456b7f79d1, stream2, x5ab6ed99b3041647, ref i26, ref i12, ref i13, ref i27, ref i28, ref i29, 
						ref i37, ref i32, ref i30, ref i31, ref i34, ref i14, ref i15, byteArray5, ref i11, ref i10, 
						byteArray6, ref i23, ref i35, ref i36);
					}
					if (i16 == 0)
					{
						goto L_0491;
					}
					else if (i11 != 0)
					{
						x5ab6ed99b3041647.Write (byteArray6, 0, i11);
					}
				}
				catch (ArgumentException argumentException2)
				{
					argumentException1 = argumentException2;
					switch (argumentException1.Message)
					{
						case "Password":
						
						{
								xfba9214ce91902fb1 = xfba9214ce91902fb.x84421b2086fa9771;
								break;
						}
						default:
						
						{
								xfba9214ce91902fb1 = xfba9214ce91902fb.xeaa302427ab12296;
								break;
						}
					}
				}
				catch
				{
					xfba9214ce91902fb1 = xfba9214ce91902fb.xeaa302427ab12296;
				}
				if (x5ab6ed99b3041647 == null)
				{
					return xfba9214ce91902fb1;
				}
				else if (xfba9214ce91902fb1 != xfba9214ce91902fb.xfbacefb914bc4cc3)
				{
					return xfba9214ce91902fb1;
				}
				else if (x5ab6ed99b3041647.Length == ((long) 0))
				{
					return xfba9214ce91902fb.xeaa302427ab12296;
				}
				else if (x5ab6ed99b3041647.Length == ((long) x181df638a52dfd1a1.xc49fe6a8d63d6783))
				{
					return xfba9214ce91902fb1;
				}
				else
				{
					return xfba9214ce91902fb.x84421b2086fa9771;
				}
			}
			
			public static xfba9214ce91902fb x2b37c931ef30afed (string x6724b098c1a1476f, string xd8af4f082c0c05b4, string xf6feaaa024df1fcd, string xa4bc2af2b58881c8)
			
			/*
				// Code Size: 76 Bytes
				.maxstack 5
				.locals (Sunisoft.IrisSkin.xfba9214ce91902fb V_0, 
         System.IO.Stream V_1, 
         System.IO.Stream V_2)
				.try L_0010 to L_0030 catch System.Object L_0030 to L_0035
				.try L_0010 to L_0037 finally L_0037 to L_004a
				L_0000: ldarg.0 
				L_0001: call System.IO.File::Boolean Exists(System.String)
				L_0006: brtrue.s L_000a
				L_0008: ldc.i4.1 
				L_0009: ret 
				L_000a: ldc.i4.0 
				L_000b: stloc.0 
				L_000c: ldnull 
				L_000d: stloc.1 
				L_000e: ldnull 
				L_000f: stloc.2 
				L_0010: ldarg.0 
				L_0011: ldc.i4.3 
				L_0012: ldc.i4.1 
				L_0013: ldc.i4.1 
				L_0014: call System.IO.File::System.IO.FileStream Open(System.String, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)
				L_0019: stloc.1 
				L_001a: ldarg.2 
				L_001b: ldc.i4.2 
				L_001c: ldc.i4.2 
				L_001d: ldc.i4.0 
				L_001e: call System.IO.File::System.IO.FileStream Open(System.String, System.IO.FileMode, System.IO.FileAccess, System.IO.FileShare)
				L_0023: stloc.2 
				L_0024: ldloc.1 
				L_0025: ldarg.1 
				L_0026: ldloc.2 
				L_0027: ldarg.3 
				L_0028: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Sunisoft.IrisSkin.xfba9214ce91902fb x2b37c931ef30afed(System.IO.Stream, System.String, System.IO.Stream, System.String)
				L_002d: stloc.0 
				L_002e: leave.s L_0035
				L_0030: pop 
				L_0031: ldc.i4.1 
				L_0032: stloc.0 
				L_0033: leave.s L_0035
				L_0035: leave.s L_004a
				L_0037: ldloc.1 
				L_0038: brfalse.s L_0040
				L_003a: ldloc.1 
				L_003b: callvirt System.IO.Stream::Void Close()
				L_0040: ldloc.2 
				L_0041: brfalse.s L_0049
				L_0043: ldloc.2 
				L_0044: callvirt System.IO.Stream::Void Close()
				L_0049: endfinally 
				L_004a: ldloc.0 
				L_004b: ret 
			*/
			
			
			{
				if (! File.Exists (x6724b098c1a1476f))
				{
					return xfba9214ce91902fb.xeaa302427ab12296;
				}
				xfba9214ce91902fb xfba9214ce91902fb1 = xfba9214ce91902fb.xfbacefb914bc4cc3;
				Stream stream1 = ((Stream) null);
				Stream stream2 = ((Stream) null);
				try
				{
					try
					{
						stream1 = ((Stream) File.Open (x6724b098c1a1476f, FileMode.Open, FileAccess.Read, FileShare.Read));
						stream2 = ((Stream) File.Open (xf6feaaa024df1fcd, FileMode.Create, FileAccess.Write, FileShare.None));
						xfba9214ce91902fb1 = x2b13dab2573bcd5e.x2b37c931ef30afed (stream1, xd8af4f082c0c05b4, stream2, xa4bc2af2b58881c8);
					}
					catch
					{
						xfba9214ce91902fb1 = xfba9214ce91902fb.xeaa302427ab12296;
					}
				}
				finally
				{
					if (stream1 != null)
					{
						stream1.Close ();
					}
					if (stream2 != null)
					{
						stream2.Close ();
					}
				}
				return xfba9214ce91902fb1;
			}
			
			private static unsafe object x49cceb88e1b6126e (BinaryReader xe134235b3526fa75, Type x43163d22e8cd5a71, int x0ceec69a97f73617)
			
			/*
				// Code Size: 35 Bytes
				.maxstack 3
				.locals (System.Byte[] V_0, 
         System.Object V_1, 
         System.Byte& V_2 Pinned)
				L_0000: ldarg.0 
				L_0001: ldarg.2 
				L_0002: callvirt System.IO.BinaryReader::Byte[] ReadBytes(Int32)
				L_0007: stloc.0 
				L_0008: ldloc.0 
				L_0009: ldc.i4.0 
				L_000a: ldelema System.Byte
				L_000f: stloc.2 
				L_0010: ldloc.2 
				L_0011: conv.i 
				L_0012: call System.IntPtr::IntPtr op_Explicit(Void*)
				L_0017: ldarg.1 
				L_0018: call System.Runtime.InteropServices.Marshal::System.Object PtrToStructure(IntPtr, System.Type)
				L_001d: stloc.1 
				L_001e: ldc.i4.0 
				L_001f: conv.u 
				L_0020: stloc.2 
				L_0021: ldloc.1 
				L_0022: ret 
			*/
			
			
			{
				byte[] byteArray1 = xe134235b3526fa75.ReadBytes (x0ceec69a97f73617);
				fixed (byte* referencedByteAddress1 = byteArray1)
				{
					return Marshal.PtrToStructure (((IntPtr) referencedByteAddress1), x43163d22e8cd5a71);
				}
			}
			
			private static bool x573284c529e7b3c9 (Stream xcf18e5243f8d5fd3, byte[] x11e8eb31c2edb458, ref int x89682117b5f7515d, ref int xdda8a75b25a2876d)
			
			/*
				// Code Size: 111 Bytes
				.maxstack 5
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Int32 V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Int32 V_5)
				L_0000: ldc.i4.0 
				L_0001: stloc.0 
				L_0002: br.s L_0015
				L_0004: ldarg.1 
				L_0005: ldloc.0 
				L_0006: ldarg.1 
				L_0007: ldarg.2 
				L_0008: ldind.i4 
				L_0009: ldelem.u1 
				L_000a: stelem.i1 
				L_000b: ldarg.2 
				L_000c: dup 
				L_000d: ldind.i4 
				L_000e: ldc.i4.1 
				L_000f: add 
				L_0010: stind.i4 
				L_0011: ldloc.0 
				L_0012: ldc.i4.1 
				L_0013: add 
				L_0014: stloc.0 
				L_0015: ldarg.2 
				L_0016: ldind.i4 
				L_0017: ldarg.3 
				L_0018: ldind.i4 
				L_0019: bne.un.s L_0004
				L_001b: ldc.i4.0 
				L_001c: stloc.1 
				L_001d: ldc.i4.0 
				L_001e: stloc.2 
				L_001f: ldc.i4 16384
				L_0024: ldloc.0 
				L_0025: sub 
				L_0026: stloc.3 
				L_0027: ldarg.0 
				L_0028: ldarg.1 
				L_0029: ldloc.0 
				L_002a: ldloc.3 
				L_002b: callvirt System.IO.Stream::Int32 Read(Byte[], Int32, Int32)
				L_0030: stloc.s V_4
				L_0032: ldarg.2 
				L_0033: ldc.i4.0 
				L_0034: stind.i4 
				L_0035: ldarg.3 
				L_0036: ldloc.0 
				L_0037: ldloc.s V_4
				L_0039: add 
				L_003a: stind.i4 
				L_003b: ldarg.3 
				L_003c: ldind.i4 
				L_003d: stloc.1 
				L_003e: ldloc.1 
				L_003f: brtrue.s L_0043
				L_0041: ldc.i4.0 
				L_0042: ret 
				L_0043: ldloc.s V_4
				L_0045: brtrue.s L_006d
				L_0047: ldloc.1 
				L_0048: ldc.i4.4 
				L_0049: rem 
				L_004a: brfalse.s L_006d
				L_004c: ldc.i4.4 
				L_004d: ldloc.1 
				L_004e: ldc.i4.4 
				L_004f: rem 
				L_0050: sub 
				L_0051: stloc.2 
				L_0052: ldc.i4.0 
				L_0053: stloc.s V_5
				L_0055: br.s L_0068
				L_0057: ldarg.1 
				L_0058: ldarg.3 
				L_0059: ldind.i4 
				L_005a: ldc.i4.0 
				L_005b: stelem.i1 
				L_005c: ldarg.3 
				L_005d: dup 
				L_005e: ldind.i4 
				L_005f: ldc.i4.1 
				L_0060: add 
				L_0061: stind.i4 
				L_0062: ldloc.s V_5
				L_0064: ldc.i4.1 
				L_0065: add 
				L_0066: stloc.s V_5
				L_0068: ldloc.s V_5
				L_006a: ldloc.2 
				L_006b: blt.s L_0057
				L_006d: ldc.i4.1 
				L_006e: ret 
			*/
			
			
			{
				int i1;
				int i6;
				for (i1 = 0; (x89682117b5f7515d != xdda8a75b25a2876d); i1++)
				{
					x11e8eb31c2edb458[i1] = x11e8eb31c2edb458[x89682117b5f7515d];
					x89682117b5f7515d++;
				}
				int i4 = (16384 - i1);
				int i5 = xcf18e5243f8d5fd3.Read (x11e8eb31c2edb458, i1, i4);
				x89682117b5f7515d = 0;
				xdda8a75b25a2876d = (i1 + i5);
				int i2 = xdda8a75b25a2876d;
				if (i2 == 0)
				{
					return false;
				}
				if (i5 != 0)
				{
					return true;
				}
				if ((i2 % 4) == 0)
				{
					return true;
				}
				int i3 = (4 - (i2 % 4));
				for (i6 = 0; (i6 < i3); i6++)
				{
					x11e8eb31c2edb458[xdda8a75b25a2876d] = byte.MinValue;
					xdda8a75b25a2876d++;
				}
				return true;
			}
			
			private static byte x8885d1fc1e00dd5c (int x50a18ad2656e7181)
			
			/*
				// Code Size: 9 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4 255
				L_0006: and 
				L_0007: conv.u1 
				L_0008: ret 
			*/
			
			
			{
				return ((byte) (x50a18ad2656e7181 & 255));
			}
			
			private static int xa13f94e29dbd5d94 (Stream xcf18e5243f8d5fd3, ref int xd44988f225497f3a, ref int x4f0818a28ce2934b, ref int x880e0239b007e4f9, ref int xf8894778b712e96d, ref int xfcbc8d697ad1a389, byte[] x5614faf5d2637115)
			
			/*
				// Code Size: 170 Bytes
				.maxstack 6
				.locals (System.Int32 V_0, 
         System.Int32 V_1, 
         System.Int32 V_2)
				L_0000: ldarg.1 
				L_0001: ldind.i4 
				L_0002: ldarg.2 
				L_0003: ldind.i4 
				L_0004: bgt.s L_0019
				L_0006: ldarg.3 
				L_0007: ldind.i4 
				L_0008: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] xd4434a4392e36da6
				L_000d: ldarg.1 
				L_000e: ldind.i4 
				L_000f: ldc.i4.1 
				L_0010: sub 
				L_0011: ldelem.i4 
				L_0012: and 
				L_0013: stloc.2 
				L_0014: br L_00a8
				L_0019: ldarg.1 
				L_001a: ldind.i4 
				L_001b: ldarg.2 
				L_001c: ldind.i4 
				L_001d: sub 
				L_001e: stloc.0 
				L_001f: ldarg.3 
				L_0020: ldind.i4 
				L_0021: stloc.2 
				L_0022: ldarg.s xfcbc8d697ad1a389
				L_0024: ldind.i4 
				L_0025: ldarg.s xf8894778b712e96d
				L_0027: ldind.i4 
				L_0028: sub 
				L_0029: ldc.i4.4 
				L_002a: bge.s L_006a
				L_002c: ldarg.0 
				L_002d: ldarg.s x5614faf5d2637115
				L_002f: ldarg.s xf8894778b712e96d
				L_0031: ldarg.s xfcbc8d697ad1a389
				L_0033: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Boolean x573284c529e7b3c9(System.IO.Stream, Byte[], Int32 ByRef, Int32 ByRef)
				L_0038: brtrue.s L_003e
				L_003a: ldc.i4.0 
				L_003b: stloc.1 
				L_003c: br.s L_0094
				L_003e: ldarg.s x5614faf5d2637115
				L_0040: ldarg.s xf8894778b712e96d
				L_0042: ldind.i4 
				L_0043: ldelem.u1 
				L_0044: ldarg.s x5614faf5d2637115
				L_0046: ldarg.s xf8894778b712e96d
				L_0048: ldind.i4 
				L_0049: ldc.i4.1 
				L_004a: add 
				L_004b: ldelem.u1 
				L_004c: ldc.i4.8 
				L_004d: shl 
				L_004e: add 
				L_004f: ldarg.s x5614faf5d2637115
				L_0051: ldarg.s xf8894778b712e96d
				L_0053: ldind.i4 
				L_0054: ldc.i4.2 
				L_0055: add 
				L_0056: ldelem.u1 
				L_0057: ldc.i4.s 16
				L_0059: shl 
				L_005a: add 
				L_005b: ldarg.s x5614faf5d2637115
				L_005d: ldarg.s xf8894778b712e96d
				L_005f: ldind.i4 
				L_0060: ldc.i4.3 
				L_0061: add 
				L_0062: ldelem.u1 
				L_0063: ldc.i4.s 24
				L_0065: shl 
				L_0066: add 
				L_0067: stloc.1 
				L_0068: br.s L_0094
				L_006a: ldarg.s x5614faf5d2637115
				L_006c: ldarg.s xf8894778b712e96d
				L_006e: ldind.i4 
				L_006f: ldelem.u1 
				L_0070: ldarg.s x5614faf5d2637115
				L_0072: ldarg.s xf8894778b712e96d
				L_0074: ldind.i4 
				L_0075: ldc.i4.1 
				L_0076: add 
				L_0077: ldelem.u1 
				L_0078: ldc.i4.8 
				L_0079: shl 
				L_007a: add 
				L_007b: ldarg.s x5614faf5d2637115
				L_007d: ldarg.s xf8894778b712e96d
				L_007f: ldind.i4 
				L_0080: ldc.i4.2 
				L_0081: add 
				L_0082: ldelem.u1 
				L_0083: ldc.i4.s 16
				L_0085: shl 
				L_0086: add 
				L_0087: ldarg.s x5614faf5d2637115
				L_0089: ldarg.s xf8894778b712e96d
				L_008b: ldind.i4 
				L_008c: ldc.i4.3 
				L_008d: add 
				L_008e: ldelem.u1 
				L_008f: ldc.i4.s 24
				L_0091: shl 
				L_0092: add 
				L_0093: stloc.1 
				L_0094: ldloc.2 
				L_0095: ldloc.1 
				L_0096: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] xd4434a4392e36da6
				L_009b: ldloc.0 
				L_009c: ldc.i4.1 
				L_009d: sub 
				L_009e: ldelem.i4 
				L_009f: and 
				L_00a0: ldarg.2 
				L_00a1: ldind.i4 
				L_00a2: ldc.i4.s 31
				L_00a4: and 
				L_00a5: shl 
				L_00a6: add 
				L_00a7: stloc.2 
				L_00a8: ldloc.2 
				L_00a9: ret 
			*/
			
			
			{
				int i2;
				if (xd44988f225497f3a <= x4f0818a28ce2934b)
				{
					return (x880e0239b007e4f9 & x71589e3f55261426.xd4434a4392e36da6[(xd44988f225497f3a - 1)]);
				}
				int i1 = (xd44988f225497f3a - x4f0818a28ce2934b);
				int i3 = x880e0239b007e4f9;
				if ((xfcbc8d697ad1a389 - xf8894778b712e96d) < 4)
				{
					if (! x2b13dab2573bcd5e.x573284c529e7b3c9 (xcf18e5243f8d5fd3, x5614faf5d2637115, ref xf8894778b712e96d, ref xfcbc8d697ad1a389))
					{
						i2 = 0;
						return (i3 + ((int) ((i2 & x71589e3f55261426.xd4434a4392e36da6[(i1 - 1)]) << (x4f0818a28ce2934b & 31))));
					}
					else
					{
						i2 = ((int) (((x5614faf5d2637115[xf8894778b712e96d] + (x5614faf5d2637115[(xf8894778b712e96d + 1)] << 8)) + (x5614faf5d2637115[(xf8894778b712e96d + 2)] << 16)) + (x5614faf5d2637115[(xf8894778b712e96d + 3)] << 24)));
						return (i3 + ((int) ((i2 & x71589e3f55261426.xd4434a4392e36da6[(i1 - 1)]) << (x4f0818a28ce2934b & 31))));
					}
				}
				i2 = ((int) (((x5614faf5d2637115[xf8894778b712e96d] + (x5614faf5d2637115[(xf8894778b712e96d + 1)] << 8)) + (x5614faf5d2637115[(xf8894778b712e96d + 2)] << 16)) + (x5614faf5d2637115[(xf8894778b712e96d + 3)] << 24)));
				return (i3 + ((int) ((i2 & x71589e3f55261426.xd4434a4392e36da6[(i1 - 1)]) << (x4f0818a28ce2934b & 31))));
			}
			
			private static void xa4bb90c5f325d0af (int xd44988f225497f3a, ref int x4f0818a28ce2934b, ref int x880e0239b007e4f9, ref int xf8894778b712e96d, byte[] x5614faf5d2637115)
			
			/*
				// Code Size: 89 Bytes
				.maxstack 6
				.locals (System.Int32 V_0)
				L_0000: ldarg.0 
				L_0001: ldarg.1 
				L_0002: ldind.i4 
				L_0003: bgt.s L_0016
				L_0005: ldarg.2 
				L_0006: ldarg.2 
				L_0007: ldind.i4 
				L_0008: ldarg.0 
				L_0009: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_000e: stind.i4 
				L_000f: ldarg.1 
				L_0010: dup 
				L_0011: ldind.i4 
				L_0012: ldarg.0 
				L_0013: sub 
				L_0014: stind.i4 
				L_0015: ret 
				L_0016: ldarg.0 
				L_0017: ldarg.1 
				L_0018: ldind.i4 
				L_0019: sub 
				L_001a: stloc.0 
				L_001b: ldarg.2 
				L_001c: ldarg.s x5614faf5d2637115
				L_001e: ldarg.3 
				L_001f: ldind.i4 
				L_0020: ldelem.u1 
				L_0021: ldarg.s x5614faf5d2637115
				L_0023: ldarg.3 
				L_0024: ldind.i4 
				L_0025: ldc.i4.1 
				L_0026: add 
				L_0027: ldelem.u1 
				L_0028: ldc.i4.8 
				L_0029: shl 
				L_002a: add 
				L_002b: ldarg.s x5614faf5d2637115
				L_002d: ldarg.3 
				L_002e: ldind.i4 
				L_002f: ldc.i4.2 
				L_0030: add 
				L_0031: ldelem.u1 
				L_0032: ldc.i4.s 16
				L_0034: shl 
				L_0035: add 
				L_0036: ldarg.s x5614faf5d2637115
				L_0038: ldarg.3 
				L_0039: ldind.i4 
				L_003a: ldc.i4.3 
				L_003b: add 
				L_003c: ldelem.u1 
				L_003d: ldc.i4.s 24
				L_003f: shl 
				L_0040: add 
				L_0041: stind.i4 
				L_0042: ldarg.3 
				L_0043: dup 
				L_0044: ldind.i4 
				L_0045: ldc.i4.4 
				L_0046: add 
				L_0047: stind.i4 
				L_0048: ldarg.2 
				L_0049: ldarg.2 
				L_004a: ldind.i4 
				L_004b: ldloc.0 
				L_004c: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_0051: stind.i4 
				L_0052: ldarg.1 
				L_0053: ldc.i4.s 32
				L_0055: ldloc.0 
				L_0056: sub 
				L_0057: stind.i4 
				L_0058: ret 
			*/
			
			
			{
				if (xd44988f225497f3a <= x4f0818a28ce2934b)
				{
					x880e0239b007e4f9 = x2b13dab2573bcd5e.xa52147d0d9c2c73c (x880e0239b007e4f9, xd44988f225497f3a);
					x4f0818a28ce2934b -= xd44988f225497f3a;
					return;
				}
				int i1 = (xd44988f225497f3a - x4f0818a28ce2934b);
				x880e0239b007e4f9 = ((int) (((x5614faf5d2637115[xf8894778b712e96d] + (x5614faf5d2637115[(xf8894778b712e96d + 1)] << 8)) + (x5614faf5d2637115[(xf8894778b712e96d + 2)] << 16)) + (x5614faf5d2637115[(xf8894778b712e96d + 3)] << 24)));
				xf8894778b712e96d += 4;
				x880e0239b007e4f9 = x2b13dab2573bcd5e.xa52147d0d9c2c73c (x880e0239b007e4f9, i1);
				x4f0818a28ce2934b = ((int) (32 - i1));
			}
			
			private static int xa52147d0d9c2c73c (int x7b28e8a789372508, int x1148d0e8cc982c04)
			
			/*
				// Code Size: 18 Bytes
				.maxstack 9
				L_0000: ldarg.0 
				L_0001: ldc.i4.0 
				L_0002: ble.s L_000b
				L_0004: ldarg.0 
				L_0005: ldarg.1 
				L_0006: ldc.i4.s 31
				L_0008: and 
				L_0009: shr 
				L_000a: ret 
				L_000b: ldarg.0 
				L_000c: ldarg.1 
				L_000d: ldc.i4.s 31
				L_000f: and 
				L_0010: shr.un 
				L_0011: ret 
			*/
			
			
			{
				if (x7b28e8a789372508 <= 0)
				{
					return ((int) (x7b28e8a789372508 >> (x1148d0e8cc982c04 & 31)));
				}
				else
				{
					return ((int) (x7b28e8a789372508 >> (x1148d0e8cc982c04 & 31)));
				}
			}
			
			private static unsafe void xabeeb97aae3dd1a9 (Stream xcf18e5243f8d5fd3, int x1ef26dbdd5d13d24, int x10f4d88af727adbc, int x475641bf9383557d, int xff1f79a9916b9886, int x89682117b5f7515d, int xdda8a75b25a2876d, byte[] x11e8eb31c2edb458)
			
			/*
				// Code Size: 199 Bytes
				.maxstack 5
				.locals (System.Byte* V_0, 
         System.Int32 V_1, 
         System.Int32 V_2, 
         System.Int32 V_3, 
         System.Int32 V_4, 
         System.Int32 V_5)
				L_0000: ldarga.s x1ef26dbdd5d13d24
				L_0002: stloc.0 
				L_0003: ldarg.3 
				L_0004: ldc.i4.0 
				L_0005: ble.s L_0038
				L_0007: ldarg.3 
				L_0008: ldc.i4.8 
				L_0009: div 
				L_000a: stloc.1 
				L_000b: ldc.i4.0 
				L_000c: stloc.3 
				L_000d: br.s L_0030
				L_000f: ldloc.0 
				L_0010: ldarg.s xff1f79a9916b9886
				L_0012: ldc.i4 255
				L_0017: and 
				L_0018: call System.Convert::Byte ToByte(Int32)
				L_001d: stind.i1 
				L_001e: ldloc.0 
				L_001f: ldc.i4.1 
				L_0020: add 
				L_0021: stloc.0 
				L_0022: ldarg.s xff1f79a9916b9886
				L_0024: ldc.i4.8 
				L_0025: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_002a: starg.s xff1f79a9916b9886
				L_002c: ldloc.3 
				L_002d: ldc.i4.1 
				L_002e: add 
				L_002f: stloc.3 
				L_0030: ldloc.3 
				L_0031: ldloc.1 
				L_0032: blt.s L_000f
				L_0034: ldloc.1 
				L_0035: ldarg.2 
				L_0036: sub 
				L_0037: stloc.1 
				L_0038: ldarg.s xdda8a75b25a2876d
				L_003a: ldarg.s x89682117b5f7515d
				L_003c: sub 
				L_003d: stloc.2 
				L_003e: ldarg.2 
				L_003f: ldloc.2 
				L_0040: bgt.s L_0046
				L_0042: ldarg.2 
				L_0043: stloc.1 
				L_0044: br.s L_0048
				L_0046: ldloc.2 
				L_0047: stloc.1 
				L_0048: ldc.i4.0 
				L_0049: stloc.s V_4
				L_004b: br.s L_0060
				L_004d: ldloc.0 
				L_004e: ldloc.s V_4
				L_0050: add 
				L_0051: ldarg.s x11e8eb31c2edb458
				L_0053: ldarg.s x89682117b5f7515d
				L_0055: ldloc.s V_4
				L_0057: add 
				L_0058: ldelem.u1 
				L_0059: stind.i1 
				L_005a: ldloc.s V_4
				L_005c: ldc.i4.1 
				L_005d: add 
				L_005e: stloc.s V_4
				L_0060: ldloc.s V_4
				L_0062: ldloc.1 
				L_0063: blt.s L_004d
				L_0065: ldarg.2 
				L_0066: ldloc.1 
				L_0067: sub 
				L_0068: starg.s x10f4d88af727adbc
				L_006a: ldarg.s x89682117b5f7515d
				L_006c: ldloc.1 
				L_006d: add 
				L_006e: starg.s x89682117b5f7515d
				L_0070: br.s L_00bd
				L_0072: ldloc.0 
				L_0073: ldloc.1 
				L_0074: add 
				L_0075: stloc.0 
				L_0076: ldarg.0 
				L_0077: ldarg.s x11e8eb31c2edb458
				L_0079: ldarga.s x89682117b5f7515d
				L_007b: ldarga.s xdda8a75b25a2876d
				L_007d: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Boolean x573284c529e7b3c9(System.IO.Stream, Byte[], Int32 ByRef, Int32 ByRef)
				L_0082: brtrue.s L_0085
				L_0084: ret 
				L_0085: ldarg.s xdda8a75b25a2876d
				L_0087: ldarg.s x89682117b5f7515d
				L_0089: sub 
				L_008a: stloc.2 
				L_008b: ldarg.2 
				L_008c: ldloc.2 
				L_008d: bgt.s L_0093
				L_008f: ldarg.2 
				L_0090: stloc.1 
				L_0091: br.s L_0095
				L_0093: ldloc.2 
				L_0094: stloc.1 
				L_0095: ldc.i4.0 
				L_0096: stloc.s V_5
				L_0098: br.s L_00ad
				L_009a: ldloc.0 
				L_009b: ldloc.s V_5
				L_009d: add 
				L_009e: ldarg.s x11e8eb31c2edb458
				L_00a0: ldarg.s x89682117b5f7515d
				L_00a2: ldloc.s V_5
				L_00a4: add 
				L_00a5: ldelem.u1 
				L_00a6: stind.i1 
				L_00a7: ldloc.s V_5
				L_00a9: ldc.i4.1 
				L_00aa: add 
				L_00ab: stloc.s V_5
				L_00ad: ldloc.s V_5
				L_00af: ldloc.1 
				L_00b0: blt.s L_009a
				L_00b2: ldarg.2 
				L_00b3: ldloc.1 
				L_00b4: sub 
				L_00b5: starg.s x10f4d88af727adbc
				L_00b7: ldarg.s x89682117b5f7515d
				L_00b9: ldloc.1 
				L_00ba: add 
				L_00bb: starg.s x89682117b5f7515d
				L_00bd: ldarg.2 
				L_00be: brtrue.s L_0072
				L_00c0: ldc.i4.0 
				L_00c1: starg.s xff1f79a9916b9886
				L_00c3: ldc.i4.0 
				L_00c4: starg.s x475641bf9383557d
				L_00c6: ret 
			*/
			
			
			{
				int i1;
				int i3;
				int i4;
				int i5;
				byte* byte_Ptr1 = x1ef26dbdd5d13d24;
				if (x475641bf9383557d > 0)
				{
					i1 = (x475641bf9383557d / 8);
					for (i3 = 0; (i3 < i1); i3++)
					{
						(* byte_Ptr1) = Convert.ToByte (((int) (xff1f79a9916b9886 & 255)));
						byte_Ptr1++;
						xff1f79a9916b9886 = x2b13dab2573bcd5e.xa52147d0d9c2c73c (xff1f79a9916b9886, 8);
					}
					i1 -= x10f4d88af727adbc;
				}
				int i2 = (xdda8a75b25a2876d - x89682117b5f7515d);
				if (x10f4d88af727adbc <= i2)
				{
					i1 = x10f4d88af727adbc;
				}
				else
				{
					i1 = i2;
				}
				for (i4 = 0; (i4 < i1); i4++)
				{
					(* ((byte*) (byte_Ptr1 + i4))) = x11e8eb31c2edb458[(x89682117b5f7515d + i4)];
				}
				x10f4d88af727adbc -= i1;
				x89682117b5f7515d += i1;
				while (x10f4d88af727adbc != 0)
				{
					byte_Ptr1 += i1;
					if (! x2b13dab2573bcd5e.x573284c529e7b3c9 (xcf18e5243f8d5fd3, x11e8eb31c2edb458, ref x89682117b5f7515d, ref xdda8a75b25a2876d))
					{
						return;
					}
					i2 = (xdda8a75b25a2876d - x89682117b5f7515d);
					if (x10f4d88af727adbc > i2)
					{
						i1 = i2;
					}
					else
					{
						i1 = x10f4d88af727adbc;
					}
					for (i5 = 0; (i5 < i1); i5++)
					{
						(* ((byte*) (byte_Ptr1 + i5))) = x11e8eb31c2edb458[(x89682117b5f7515d + i5)];
					}
					x10f4d88af727adbc -= i1;
					x89682117b5f7515d += i1;
				}
				xff1f79a9916b9886 = 0;
				x475641bf9383557d = 0;
			}
			
			private static long xd54e92c965f241a7 (Stream xcf18e5243f8d5fd3)
			
			/*
				// Code Size: 114 Bytes
				.maxstack 4
				.locals (System.Int64 V_0, 
         System.IO.BinaryReader V_1, 
         Sunisoft.IrisSkin.x311a6dc8e19b6c24 V_2)
				L_0000: ldarg.0 
				L_0001: ldtoken Sunisoft.IrisSkin.x311a6dc8e19b6c24
				L_0006: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_000b: call System.Runtime.InteropServices.Marshal::Int32 SizeOf(System.Type)
				L_0010: neg 
				L_0011: conv.i8 
				L_0012: ldc.i4.2 
				L_0013: callvirt System.IO.Stream::Int64 Seek(Int64, System.IO.SeekOrigin)
				L_0018: stloc.0 
				L_0019: ldloc.0 
				L_001a: ldc.i4.0 
				L_001b: conv.i8 
				L_001c: ble.s L_0070
				L_001e: ldarg.0 
				L_001f: newobj System.IO.BinaryReader::Void .ctor(System.IO.Stream)
				L_0024: stloc.1 
				L_0025: ldloc.1 
				L_0026: ldtoken Sunisoft.IrisSkin.x311a6dc8e19b6c24
				L_002b: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_0030: ldtoken Sunisoft.IrisSkin.x311a6dc8e19b6c24
				L_0035: call System.Type::System.Type GetTypeFromHandle(System.RuntimeTypeHandle)
				L_003a: call System.Runtime.InteropServices.Marshal::Int32 SizeOf(System.Type)
				L_003f: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::System.Object x49cceb88e1b6126e(System.IO.BinaryReader, System.Type, Int32)
				L_0044: unbox Sunisoft.IrisSkin.x311a6dc8e19b6c24
				L_0049: ldobj Sunisoft.IrisSkin.x311a6dc8e19b6c24
				L_004e: stloc.2 
				L_004f: ldloca.s V_2
				L_0051: ldfld Sunisoft.IrisSkin.x311a6dc8e19b6c24::Int32 x0e3958fbb53aef8c
				L_0056: ldc.i4 101010256
				L_005b: bne.un.s L_0070
				L_005d: ldloca.s V_2
				L_005f: ldfld Sunisoft.IrisSkin.x311a6dc8e19b6c24::UInt16 x6d332f4d2a1e898a
				L_0064: conv.i4 
				L_0065: brtrue.s L_0070
				L_0067: ldarg.0 
				L_0068: ldloc.0 
				L_0069: ldc.i4.0 
				L_006a: callvirt System.IO.Stream::Int64 Seek(Int64, System.IO.SeekOrigin)
				L_006f: pop 
				L_0070: ldloc.0 
				L_0071: ret 
			*/
			
			
			{
				x311a6dc8e19b6c24 x311a6dc8e19b6c24_1;
				long int64_1 = xcf18e5243f8d5fd3.Seek (((long) (- Marshal.SizeOf (typeof (x311a6dc8e19b6c24)))), SeekOrigin.End);
				if (int64_1 <= ((long) 0))
				{
					return int64_1;
				}
				BinaryReader binaryReader1 = new BinaryReader (xcf18e5243f8d5fd3);
				if (((x311a6dc8e19b6c24_1 = ((x311a6dc8e19b6c24) x2b13dab2573bcd5e.x49cceb88e1b6126e (binaryReader1, typeof (x311a6dc8e19b6c24), Marshal.SizeOf (typeof (x311a6dc8e19b6c24))))).x0e3958fbb53aef8c == 101010256) && (((int) x311a6dc8e19b6c24_1.x6d332f4d2a1e898a) == 0))
				{
					long int64_2 = xcf18e5243f8d5fd3.Seek (int64_1, SeekOrigin.Begin);
				}
				return int64_1;
			}
			
			private static void xe12a5d7e190699b3 (byte[] x1ef26dbdd5d13d24, int x10f4d88af727adbc, ref int xf0b4c3c679d18c3c, ref int x3713ef252be01cf5, ref int xd56b578b5e9b09c0, int xccb1eeef6a33e9aa)
			
			/*
				// Code Size: 157 Bytes
				.maxstack 7
				.locals (System.Int32 V_0, 
         System.Int32 V_1)
				L_0000: ldc.i4.0 
				L_0001: stloc.1 
				L_0002: br L_0095
				L_0007: ldarg.s xd56b578b5e9b09c0
				L_0009: ldind.i4 
				L_000a: ldc.i4 65535
				L_000f: and 
				L_0010: ldc.i4.2 
				L_0011: or 
				L_0012: stloc.0 
				L_0013: ldarg.0 
				L_0014: ldloc.1 
				L_0015: ldarg.0 
				L_0016: ldloc.1 
				L_0017: ldelem.u1 
				L_0018: ldloc.0 
				L_0019: ldloc.0 
				L_001a: ldc.i4.1 
				L_001b: xor 
				L_001c: mul 
				L_001d: ldc.i4.8 
				L_001e: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_0023: xor 
				L_0024: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Byte x8885d1fc1e00dd5c(Int32)
				L_0029: stelem.i1 
				L_002a: ldarg.2 
				L_002b: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::UInt32[] x6ee31887cc8af8eb
				L_0030: ldarg.2 
				L_0031: ldind.i4 
				L_0032: ldarg.0 
				L_0033: ldloc.1 
				L_0034: ldelem.u1 
				L_0035: xor 
				L_0036: ldc.i4 255
				L_003b: and 
				L_003c: ldelem.u4 
				L_003d: conv.u8 
				L_003e: ldarg.2 
				L_003f: ldind.i4 
				L_0040: ldc.i4.8 
				L_0041: shr 
				L_0042: ldc.i4 16777215
				L_0047: and 
				L_0048: conv.i8 
				L_0049: xor 
				L_004a: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 x19339fe0ba40cd55(Int64)
				L_004f: stind.i4 
				L_0050: ldarg.3 
				L_0051: ldarg.3 
				L_0052: ldind.i4 
				L_0053: ldarg.2 
				L_0054: ldind.i4 
				L_0055: ldc.i4 255
				L_005a: and 
				L_005b: add 
				L_005c: stind.i4 
				L_005d: ldarg.3 
				L_005e: ldarg.3 
				L_005f: ldind.i4 
				L_0060: ldarg.s xccb1eeef6a33e9aa
				L_0062: mul 
				L_0063: ldc.i4.1 
				L_0064: add 
				L_0065: stind.i4 
				L_0066: ldarg.s xd56b578b5e9b09c0
				L_0068: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::UInt32[] x6ee31887cc8af8eb
				L_006d: ldarg.s xd56b578b5e9b09c0
				L_006f: ldind.i4 
				L_0070: ldarg.3 
				L_0071: ldind.i4 
				L_0072: ldc.i4.s 24
				L_0074: shr 
				L_0075: xor 
				L_0076: ldc.i4 255
				L_007b: and 
				L_007c: ldelem.u4 
				L_007d: conv.u8 
				L_007e: ldarg.s xd56b578b5e9b09c0
				L_0080: ldind.i4 
				L_0081: ldc.i4.8 
				L_0082: shr 
				L_0083: ldc.i4 16777215
				L_0088: and 
				L_0089: conv.i8 
				L_008a: xor 
				L_008b: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 x19339fe0ba40cd55(Int64)
				L_0090: stind.i4 
				L_0091: ldloc.1 
				L_0092: ldc.i4.1 
				L_0093: add 
				L_0094: stloc.1 
				L_0095: ldloc.1 
				L_0096: ldarg.1 
				L_0097: blt L_0007
				L_009c: ret 
			*/
			
			
			{
				int i1;
				int i2;
				for (i2 = 0; (i2 < x10f4d88af727adbc); i2++)
				{
					i1 = ((xd56b578b5e9b09c0 & 65535) | 2);
					x1ef26dbdd5d13d24[i2] = x2b13dab2573bcd5e.x8885d1fc1e00dd5c (((int) (((int) x1ef26dbdd5d13d24[i2]) ^ x2b13dab2573bcd5e.xa52147d0d9c2c73c (((int) (i1 * (i1 ^ 1))), 8))));
					xf0b4c3c679d18c3c = x2b13dab2573bcd5e.x19339fe0ba40cd55 (((long) (((long) x71589e3f55261426.x6ee31887cc8af8eb[((xf0b4c3c679d18c3c ^ ((int) x1ef26dbdd5d13d24[i2])) & 255)]) ^ ((long) ((xf0b4c3c679d18c3c >> 8) & 16777215)))));
					x3713ef252be01cf5 += (xf0b4c3c679d18c3c & 255);
					x3713ef252be01cf5 = ((x3713ef252be01cf5 * xccb1eeef6a33e9aa) + 1);
					xd56b578b5e9b09c0 = x2b13dab2573bcd5e.x19339fe0ba40cd55 (((long) (((long) x71589e3f55261426.x6ee31887cc8af8eb[((int) ((xd56b578b5e9b09c0 ^ (x3713ef252be01cf5 >> 24)) & 255))]) ^ ((long) ((xd56b578b5e9b09c0 >> 8) & 16777215)))));
				}
			}
			
			private static void xf76803be5e9ee2aa (Ixb0f0f2071b49b1cb xc82e2be11855266c, Ixb0f0f2071b49b1cb xd8260a8082223426, Stream x160656af282c4d7b, Stream x5ab6ed99b3041647, ref int xce53a4f2835cab70, ref int x4f0818a28ce2934b, ref int x880e0239b007e4f9, ref int xea2a21438bfbe03d, ref int xa60661b5d01cbcbc, ref int x42f081a275d72d2c, ref int xe59d6d35c76d70aa, ref int x57922afe7d4d09e0, ref int x5c34e2900c6b80d0, ref int x9b229eba46fd51f3, ref int x58316dde3396e982, ref int xf8894778b712e96d, ref int xfcbc8d697ad1a389, byte[] x5614faf5d2637115, ref int xe2b07c285d73cc12, ref int x971144bb4ad7e504, byte[] x7585f73a99663fd2, ref int x81dfe2898a2fdde1, ref int x4996da61da7808c8, ref int x4cc2dc507646ce1a)
			
			/*
				// Code Size: 900 Bytes
				.maxstack 9
				.locals (System.Int32 V_0)
				L_0000: ldc.i4.0 
				L_0001: stloc.0 
				L_0002: ldarg.s xce53a4f2835cab70
				L_0004: ldarg.0 
				L_0005: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 get_xc5207dd50e2ff5b4()
				L_000a: ldc.i4.5 
				L_000b: add 
				L_000c: stind.i4 
				L_000d: ldarg.s xea2a21438bfbe03d
				L_000f: ldarg.2 
				L_0010: ldarg.s xce53a4f2835cab70
				L_0012: ldarg.s x4f0818a28ce2934b
				L_0014: ldarg.s x880e0239b007e4f9
				L_0016: ldarg.s xf8894778b712e96d
				L_0018: ldarg.s xfcbc8d697ad1a389
				L_001a: ldarg.s x5614faf5d2637115
				L_001c: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa13f94e29dbd5d94(System.IO.Stream, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_0021: stind.i4 
				L_0022: ldarg.s xa60661b5d01cbcbc
				L_0024: ldarg.s xea2a21438bfbe03d
				L_0026: ldind.i4 
				L_0027: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] xd4434a4392e36da6
				L_002c: ldarg.0 
				L_002d: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 get_xc5207dd50e2ff5b4()
				L_0032: ldc.i4.1 
				L_0033: sub 
				L_0034: ldelem.i4 
				L_0035: and 
				L_0036: stind.i4 
				L_0037: ldarg.s x42f081a275d72d2c
				L_0039: ldarg.0 
				L_003a: ldarg.s xa60661b5d01cbcbc
				L_003c: ldind.i4 
				L_003d: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 xf76803be5e9ee2aa(Int32)
				L_0042: stind.i4 
				L_0043: ldarg.s xe59d6d35c76d70aa
				L_0045: ldarg.s x42f081a275d72d2c
				L_0047: ldind.i4 
				L_0048: ldc.i4 65535
				L_004d: and 
				L_004e: stind.i4 
				L_004f: ldarg.s x57922afe7d4d09e0
				L_0051: ldarg.s x42f081a275d72d2c
				L_0053: ldind.i4 
				L_0054: ldc.i4.s 16
				L_0056: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_005b: ldc.i4 255
				L_0060: and 
				L_0061: stind.i4 
				L_0062: br L_0366
				L_0067: ldarg.s xe59d6d35c76d70aa
				L_0069: ldind.i4 
				L_006a: ldc.i4 256
				L_006f: bge.s L_00de
				L_0071: ldarg.s x7585f73a99663fd2
				L_0073: ldarg.s xe2b07c285d73cc12
				L_0075: ldind.i4 
				L_0076: ldarg.s xe59d6d35c76d70aa
				L_0078: ldind.i4 
				L_0079: conv.u1 
				L_007a: stelem.i1 
				L_007b: ldarg.s xe2b07c285d73cc12
				L_007d: dup 
				L_007e: ldind.i4 
				L_007f: ldc.i4.1 
				L_0080: add 
				L_0081: stind.i4 
				L_0082: ldarg.s xe2b07c285d73cc12
				L_0084: ldind.i4 
				L_0085: ldarg.s x971144bb4ad7e504
				L_0087: ldind.i4 
				L_0088: blt.s L_00c9
				L_008a: ldarg.3 
				L_008b: ldarg.s x7585f73a99663fd2
				L_008d: ldc.i4.0 
				L_008e: ldc.i4 32768
				L_0093: callvirt System.IO.Stream::Void Write(Byte[], Int32, Int32)
				L_0098: ldarg.s x81dfe2898a2fdde1
				L_009a: ldc.i4 32768
				L_009f: stind.i4 
				L_00a0: ldc.i4.0 
				L_00a1: stloc.0 
				L_00a2: br.s L_00b4
				L_00a4: ldarg.s x7585f73a99663fd2
				L_00a6: ldloc.0 
				L_00a7: ldarg.s x7585f73a99663fd2
				L_00a9: ldarg.s x81dfe2898a2fdde1
				L_00ab: ldind.i4 
				L_00ac: ldloc.0 
				L_00ad: add 
				L_00ae: ldelem.u1 
				L_00af: stelem.i1 
				L_00b0: ldloc.0 
				L_00b1: ldc.i4.1 
				L_00b2: add 
				L_00b3: stloc.0 
				L_00b4: ldloc.0 
				L_00b5: ldarg.s xe2b07c285d73cc12
				L_00b7: ldind.i4 
				L_00b8: ldarg.s x81dfe2898a2fdde1
				L_00ba: ldind.i4 
				L_00bb: sub 
				L_00bc: blt.s L_00a4
				L_00be: ldarg.s xe2b07c285d73cc12
				L_00c0: dup 
				L_00c1: ldind.i4 
				L_00c2: ldc.i4 32768
				L_00c7: sub 
				L_00c8: stind.i4 
				L_00c9: ldarg.s x57922afe7d4d09e0
				L_00cb: ldind.i4 
				L_00cc: ldarg.s x4f0818a28ce2934b
				L_00ce: ldarg.s x880e0239b007e4f9
				L_00d0: ldarg.s xf8894778b712e96d
				L_00d2: ldarg.s x5614faf5d2637115
				L_00d4: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xa4bb90c5f325d0af(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_00d9: br L_0306
				L_00de: ldarg.s xe59d6d35c76d70aa
				L_00e0: ldind.i4 
				L_00e1: ldc.i4 285
				L_00e6: bne.un.s L_0105
				L_00e8: ldarg.s x5c34e2900c6b80d0
				L_00ea: ldc.i4 258
				L_00ef: stind.i4 
				L_00f0: ldarg.s x57922afe7d4d09e0
				L_00f2: ldind.i4 
				L_00f3: ldarg.s x4f0818a28ce2934b
				L_00f5: ldarg.s x880e0239b007e4f9
				L_00f7: ldarg.s xf8894778b712e96d
				L_00f9: ldarg.s x5614faf5d2637115
				L_00fb: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xa4bb90c5f325d0af(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_0100: br L_0181
				L_0105: ldarg.s x9b229eba46fd51f3
				L_0107: ldarg.s x42f081a275d72d2c
				L_0109: ldind.i4 
				L_010a: ldc.i4.s 24
				L_010c: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_0111: stind.i4 
				L_0112: ldarg.s x9b229eba46fd51f3
				L_0114: ldind.i4 
				L_0115: brtrue.s L_013c
				L_0117: ldarg.s x5c34e2900c6b80d0
				L_0119: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::UInt16[] xf224e2f78df7e606
				L_011e: ldarg.s xe59d6d35c76d70aa
				L_0120: ldind.i4 
				L_0121: ldc.i4 257
				L_0126: sub 
				L_0127: ldelem.u2 
				L_0128: conv.i4 
				L_0129: stind.i4 
				L_012a: ldarg.s x57922afe7d4d09e0
				L_012c: ldind.i4 
				L_012d: ldarg.s x4f0818a28ce2934b
				L_012f: ldarg.s x880e0239b007e4f9
				L_0131: ldarg.s xf8894778b712e96d
				L_0133: ldarg.s x5614faf5d2637115
				L_0135: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xa4bb90c5f325d0af(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_013a: br.s L_0181
				L_013c: ldarg.s x5c34e2900c6b80d0
				L_013e: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::UInt16[] xf224e2f78df7e606
				L_0143: ldarg.s xe59d6d35c76d70aa
				L_0145: ldind.i4 
				L_0146: ldc.i4 257
				L_014b: sub 
				L_014c: ldelem.u2 
				L_014d: conv.i4 
				L_014e: ldarg.s xea2a21438bfbe03d
				L_0150: ldind.i4 
				L_0151: ldarg.s x57922afe7d4d09e0
				L_0153: ldind.i4 
				L_0154: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_0159: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] xd4434a4392e36da6
				L_015e: ldarg.s x9b229eba46fd51f3
				L_0160: ldind.i4 
				L_0161: ldc.i4.1 
				L_0162: sub 
				L_0163: ldelem.i4 
				L_0164: and 
				L_0165: add 
				L_0166: stind.i4 
				L_0167: ldarg.s xce53a4f2835cab70
				L_0169: ldarg.s x57922afe7d4d09e0
				L_016b: ldind.i4 
				L_016c: ldarg.s x9b229eba46fd51f3
				L_016e: ldind.i4 
				L_016f: add 
				L_0170: stind.i4 
				L_0171: ldarg.s xce53a4f2835cab70
				L_0173: ldind.i4 
				L_0174: ldarg.s x4f0818a28ce2934b
				L_0176: ldarg.s x880e0239b007e4f9
				L_0178: ldarg.s xf8894778b712e96d
				L_017a: ldarg.s x5614faf5d2637115
				L_017c: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xa4bb90c5f325d0af(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_0181: ldarg.s xce53a4f2835cab70
				L_0183: ldarg.1 
				L_0184: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 get_xc5207dd50e2ff5b4()
				L_0189: ldc.i4.s 14
				L_018b: add 
				L_018c: stind.i4 
				L_018d: ldarg.s xea2a21438bfbe03d
				L_018f: ldarg.2 
				L_0190: ldarg.s xce53a4f2835cab70
				L_0192: ldarg.s x4f0818a28ce2934b
				L_0194: ldarg.s x880e0239b007e4f9
				L_0196: ldarg.s xf8894778b712e96d
				L_0198: ldarg.s xfcbc8d697ad1a389
				L_019a: ldarg.s x5614faf5d2637115
				L_019c: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa13f94e29dbd5d94(System.IO.Stream, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_01a1: stind.i4 
				L_01a2: ldarg.s xa60661b5d01cbcbc
				L_01a4: ldarg.s xea2a21438bfbe03d
				L_01a6: ldind.i4 
				L_01a7: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] xd4434a4392e36da6
				L_01ac: ldarg.1 
				L_01ad: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 get_xc5207dd50e2ff5b4()
				L_01b2: ldc.i4.1 
				L_01b3: sub 
				L_01b4: ldelem.i4 
				L_01b5: and 
				L_01b6: stind.i4 
				L_01b7: ldarg.s x42f081a275d72d2c
				L_01b9: ldarg.1 
				L_01ba: ldarg.s xa60661b5d01cbcbc
				L_01bc: ldind.i4 
				L_01bd: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 xf76803be5e9ee2aa(Int32)
				L_01c2: stind.i4 
				L_01c3: ldarg.s xe59d6d35c76d70aa
				L_01c5: ldarg.s x42f081a275d72d2c
				L_01c7: ldind.i4 
				L_01c8: ldc.i4 65535
				L_01cd: and 
				L_01ce: stind.i4 
				L_01cf: ldarg.s x57922afe7d4d09e0
				L_01d1: ldarg.s x42f081a275d72d2c
				L_01d3: ldind.i4 
				L_01d4: ldc.i4.s 16
				L_01d6: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_01db: ldc.i4 255
				L_01e0: and 
				L_01e1: stind.i4 
				L_01e2: ldarg.s x9b229eba46fd51f3
				L_01e4: ldarg.s x42f081a275d72d2c
				L_01e6: ldind.i4 
				L_01e7: ldc.i4.s 24
				L_01e9: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_01ee: stind.i4 
				L_01ef: ldarg.s x9b229eba46fd51f3
				L_01f1: ldind.i4 
				L_01f2: brtrue.s L_0213
				L_01f4: ldarg.s x58316dde3396e982
				L_01f6: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::UInt16[] x829fbae11dc19d07
				L_01fb: ldarg.s xe59d6d35c76d70aa
				L_01fd: ldind.i4 
				L_01fe: ldelem.u2 
				L_01ff: conv.i4 
				L_0200: stind.i4 
				L_0201: ldarg.s x57922afe7d4d09e0
				L_0203: ldind.i4 
				L_0204: ldarg.s x4f0818a28ce2934b
				L_0206: ldarg.s x880e0239b007e4f9
				L_0208: ldarg.s xf8894778b712e96d
				L_020a: ldarg.s x5614faf5d2637115
				L_020c: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xa4bb90c5f325d0af(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_0211: br.s L_0252
				L_0213: ldarg.s x58316dde3396e982
				L_0215: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::UInt16[] x829fbae11dc19d07
				L_021a: ldarg.s xe59d6d35c76d70aa
				L_021c: ldind.i4 
				L_021d: ldelem.u2 
				L_021e: conv.i4 
				L_021f: ldarg.s xea2a21438bfbe03d
				L_0221: ldind.i4 
				L_0222: ldarg.s x57922afe7d4d09e0
				L_0224: ldind.i4 
				L_0225: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_022a: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] xd4434a4392e36da6
				L_022f: ldarg.s x9b229eba46fd51f3
				L_0231: ldind.i4 
				L_0232: ldc.i4.1 
				L_0233: sub 
				L_0234: ldelem.i4 
				L_0235: and 
				L_0236: add 
				L_0237: stind.i4 
				L_0238: ldarg.s xce53a4f2835cab70
				L_023a: ldarg.s x57922afe7d4d09e0
				L_023c: ldind.i4 
				L_023d: ldarg.s x9b229eba46fd51f3
				L_023f: ldind.i4 
				L_0240: add 
				L_0241: stind.i4 
				L_0242: ldarg.s xce53a4f2835cab70
				L_0244: ldind.i4 
				L_0245: ldarg.s x4f0818a28ce2934b
				L_0247: ldarg.s x880e0239b007e4f9
				L_0249: ldarg.s xf8894778b712e96d
				L_024b: ldarg.s x5614faf5d2637115
				L_024d: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xa4bb90c5f325d0af(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_0252: ldarg.s x5c34e2900c6b80d0
				L_0254: ldind.i4 
				L_0255: ldarg.s x58316dde3396e982
				L_0257: ldind.i4 
				L_0258: bgt.s L_027e
				L_025a: ldc.i4.0 
				L_025b: stloc.0 
				L_025c: br.s L_0276
				L_025e: ldarg.s x7585f73a99663fd2
				L_0260: ldarg.s xe2b07c285d73cc12
				L_0262: ldind.i4 
				L_0263: ldloc.0 
				L_0264: add 
				L_0265: ldarg.s x7585f73a99663fd2
				L_0267: ldarg.s xe2b07c285d73cc12
				L_0269: ldind.i4 
				L_026a: ldarg.s x58316dde3396e982
				L_026c: ldind.i4 
				L_026d: sub 
				L_026e: ldloc.0 
				L_026f: add 
				L_0270: ldelem.u1 
				L_0271: stelem.i1 
				L_0272: ldloc.0 
				L_0273: ldc.i4.1 
				L_0274: add 
				L_0275: stloc.0 
				L_0276: ldloc.0 
				L_0277: ldarg.s x5c34e2900c6b80d0
				L_0279: ldind.i4 
				L_027a: blt.s L_025e
				L_027c: br.s L_02b6
				L_027e: ldarg.s x4996da61da7808c8
				L_0280: ldarg.s xe2b07c285d73cc12
				L_0282: ldind.i4 
				L_0283: ldarg.s x58316dde3396e982
				L_0285: ldind.i4 
				L_0286: sub 
				L_0287: stind.i4 
				L_0288: ldarg.s x4cc2dc507646ce1a
				L_028a: ldarg.s xe2b07c285d73cc12
				L_028c: ldind.i4 
				L_028d: stind.i4 
				L_028e: ldc.i4.1 
				L_028f: stloc.0 
				L_0290: br.s L_02b0
				L_0292: ldarg.s x7585f73a99663fd2
				L_0294: ldarg.s x4cc2dc507646ce1a
				L_0296: ldind.i4 
				L_0297: ldarg.s x7585f73a99663fd2
				L_0299: ldarg.s x4996da61da7808c8
				L_029b: ldind.i4 
				L_029c: ldelem.u1 
				L_029d: stelem.i1 
				L_029e: ldarg.s x4996da61da7808c8
				L_02a0: dup 
				L_02a1: ldind.i4 
				L_02a2: ldc.i4.1 
				L_02a3: add 
				L_02a4: stind.i4 
				L_02a5: ldarg.s x4cc2dc507646ce1a
				L_02a7: dup 
				L_02a8: ldind.i4 
				L_02a9: ldc.i4.1 
				L_02aa: add 
				L_02ab: stind.i4 
				L_02ac: ldloc.0 
				L_02ad: ldc.i4.1 
				L_02ae: add 
				L_02af: stloc.0 
				L_02b0: ldloc.0 
				L_02b1: ldarg.s x5c34e2900c6b80d0
				L_02b3: ldind.i4 
				L_02b4: ble.s L_0292
				L_02b6: ldarg.s xe2b07c285d73cc12
				L_02b8: dup 
				L_02b9: ldind.i4 
				L_02ba: ldarg.s x5c34e2900c6b80d0
				L_02bc: ldind.i4 
				L_02bd: add 
				L_02be: stind.i4 
				L_02bf: ldarg.s xe2b07c285d73cc12
				L_02c1: ldind.i4 
				L_02c2: ldarg.s x971144bb4ad7e504
				L_02c4: ldind.i4 
				L_02c5: blt.s L_0306
				L_02c7: ldarg.3 
				L_02c8: ldarg.s x7585f73a99663fd2
				L_02ca: ldc.i4.0 
				L_02cb: ldc.i4 32768
				L_02d0: callvirt System.IO.Stream::Void Write(Byte[], Int32, Int32)
				L_02d5: ldarg.s x81dfe2898a2fdde1
				L_02d7: ldc.i4 32768
				L_02dc: stind.i4 
				L_02dd: ldc.i4.0 
				L_02de: stloc.0 
				L_02df: br.s L_02f1
				L_02e1: ldarg.s x7585f73a99663fd2
				L_02e3: ldloc.0 
				L_02e4: ldarg.s x7585f73a99663fd2
				L_02e6: ldarg.s x81dfe2898a2fdde1
				L_02e8: ldind.i4 
				L_02e9: ldloc.0 
				L_02ea: add 
				L_02eb: ldelem.u1 
				L_02ec: stelem.i1 
				L_02ed: ldloc.0 
				L_02ee: ldc.i4.1 
				L_02ef: add 
				L_02f0: stloc.0 
				L_02f1: ldloc.0 
				L_02f2: ldarg.s xe2b07c285d73cc12
				L_02f4: ldind.i4 
				L_02f5: ldarg.s x81dfe2898a2fdde1
				L_02f7: ldind.i4 
				L_02f8: sub 
				L_02f9: blt.s L_02e1
				L_02fb: ldarg.s xe2b07c285d73cc12
				L_02fd: dup 
				L_02fe: ldind.i4 
				L_02ff: ldc.i4 32768
				L_0304: sub 
				L_0305: stind.i4 
				L_0306: ldarg.s xce53a4f2835cab70
				L_0308: ldarg.0 
				L_0309: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 get_xc5207dd50e2ff5b4()
				L_030e: ldc.i4.5 
				L_030f: add 
				L_0310: stind.i4 
				L_0311: ldarg.s xea2a21438bfbe03d
				L_0313: ldarg.2 
				L_0314: ldarg.s xce53a4f2835cab70
				L_0316: ldarg.s x4f0818a28ce2934b
				L_0318: ldarg.s x880e0239b007e4f9
				L_031a: ldarg.s xf8894778b712e96d
				L_031c: ldarg.s xfcbc8d697ad1a389
				L_031e: ldarg.s x5614faf5d2637115
				L_0320: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa13f94e29dbd5d94(System.IO.Stream, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_0325: stind.i4 
				L_0326: ldarg.s xa60661b5d01cbcbc
				L_0328: ldarg.s xea2a21438bfbe03d
				L_032a: ldind.i4 
				L_032b: ldsfld Sunisoft.IrisSkin.x71589e3f55261426::Int32[] xd4434a4392e36da6
				L_0330: ldarg.0 
				L_0331: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 get_xc5207dd50e2ff5b4()
				L_0336: ldc.i4.1 
				L_0337: sub 
				L_0338: ldelem.i4 
				L_0339: and 
				L_033a: stind.i4 
				L_033b: ldarg.s x42f081a275d72d2c
				L_033d: ldarg.0 
				L_033e: ldarg.s xa60661b5d01cbcbc
				L_0340: ldind.i4 
				L_0341: callvirt Sunisoft.IrisSkin.xb0f0f2071b49b1cb::Int32 xf76803be5e9ee2aa(Int32)
				L_0346: stind.i4 
				L_0347: ldarg.s xe59d6d35c76d70aa
				L_0349: ldarg.s x42f081a275d72d2c
				L_034b: ldind.i4 
				L_034c: ldc.i4 65535
				L_0351: and 
				L_0352: stind.i4 
				L_0353: ldarg.s x57922afe7d4d09e0
				L_0355: ldarg.s x42f081a275d72d2c
				L_0357: ldind.i4 
				L_0358: ldc.i4.s 16
				L_035a: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Int32 xa52147d0d9c2c73c(Int32, Int32)
				L_035f: ldc.i4 255
				L_0364: and 
				L_0365: stind.i4 
				L_0366: ldarg.s xe59d6d35c76d70aa
				L_0368: ldind.i4 
				L_0369: ldc.i4 256
				L_036e: bne.un L_0067
				L_0373: ldarg.s x57922afe7d4d09e0
				L_0375: ldind.i4 
				L_0376: ldarg.s x4f0818a28ce2934b
				L_0378: ldarg.s x880e0239b007e4f9
				L_037a: ldarg.s xf8894778b712e96d
				L_037c: ldarg.s x5614faf5d2637115
				L_037e: call Sunisoft.IrisSkin.x2b13dab2573bcd5e::Void xa4bb90c5f325d0af(Int32, Int32 ByRef, Int32 ByRef, Int32 ByRef, Byte[])
				L_0383: ret 
			*/
			
			
			{
				int i1 = 0;
				xce53a4f2835cab70 = (((Ixb0f0f2071b49b1cb) xc82e2be11855266c).xc5207dd50e2ff5b4 + 5);
				xea2a21438bfbe03d = x2b13dab2573bcd5e.xa13f94e29dbd5d94 (x160656af282c4d7b, ref xce53a4f2835cab70, ref x4f0818a28ce2934b, ref x880e0239b007e4f9, ref xf8894778b712e96d, ref xfcbc8d697ad1a389, x5614faf5d2637115);
				xa60661b5d01cbcbc = (xea2a21438bfbe03d & x71589e3f55261426.xd4434a4392e36da6[(((Ixb0f0f2071b49b1cb) xc82e2be11855266c).xc5207dd50e2ff5b4 - 1)]);
				x42f081a275d72d2c = ((Ixb0f0f2071b49b1cb) xc82e2be11855266c).xf76803be5e9ee2aa (xa60661b5d01cbcbc);
				xe59d6d35c76d70aa = (x42f081a275d72d2c & 65535);
				x57922afe7d4d09e0 = (x2b13dab2573bcd5e.xa52147d0d9c2c73c (x42f081a275d72d2c, 16) & 255);
				while (true)
				{
					if (xe59d6d35c76d70aa == 256)
					{
						x2b13dab2573bcd5e.xa4bb90c5f325d0af (x57922afe7d4d09e0, ref x4f0818a28ce2934b, ref x880e0239b007e4f9, ref xf8894778b712e96d, x5614faf5d2637115);
						return;
					}
					if (xe59d6d35c76d70aa < 256)
					{
						x7585f73a99663fd2[xe2b07c285d73cc12] = ((byte) xe59d6d35c76d70aa);
						xe2b07c285d73cc12++;
						if (xe2b07c285d73cc12 >= x971144bb4ad7e504)
						{
							x5ab6ed99b3041647.Write (x7585f73a99663fd2, 0, 32768);
							x81dfe2898a2fdde1 = 32768;
							for (i1 = 0; (i1 < (xe2b07c285d73cc12 - x81dfe2898a2fdde1)); i1++)
							{
								x7585f73a99663fd2[i1] = x7585f73a99663fd2[(x81dfe2898a2fdde1 + i1)];
							}
							xe2b07c285d73cc12 -= 32768;
						}
						x2b13dab2573bcd5e.xa4bb90c5f325d0af (x57922afe7d4d09e0, ref x4f0818a28ce2934b, ref x880e0239b007e4f9, ref xf8894778b712e96d, x5614faf5d2637115);
					}
					else
					{
						if (xe59d6d35c76d70aa != 285)
						{
							x9b229eba46fd51f3 = x2b13dab2573bcd5e.xa52147d0d9c2c73c (x42f081a275d72d2c, 24);
							if (x9b229eba46fd51f3 != 0)
							{
								x5c34e2900c6b80d0 = (((int) x71589e3f55261426.xf224e2f78df7e606[(xe59d6d35c76d70aa - 257)]) + (x2b13dab2573bcd5e.xa52147d0d9c2c73c (xea2a21438bfbe03d, x57922afe7d4d09e0) & x71589e3f55261426.xd4434a4392e36da6[(x9b229eba46fd51f3 - 1)]));
								xce53a4f2835cab70 = (x57922afe7d4d09e0 + x9b229eba46fd51f3);
								x2b13dab2573bcd5e.xa4bb90c5f325d0af (xce53a4f2835cab70, ref x4f0818a28ce2934b, ref x880e0239b007e4f9, ref xf8894778b712e96d, x5614faf5d2637115);
							}
							else
							{
								x5c34e2900c6b80d0 = ((int) x71589e3f55261426.xf224e2f78df7e606[(xe59d6d35c76d70aa - 257)]);
								x2b13dab2573bcd5e.xa4bb90c5f325d0af (x57922afe7d4d09e0, ref x4f0818a28ce2934b, ref x880e0239b007e4f9, ref xf8894778b712e96d, x5614faf5d2637115);
							}
						}
						else
						{
							x5c34e2900c6b80d0 = 258;
							x2b13dab2573bcd5e.xa4bb90c5f325d0af (x57922afe7d4d09e0, ref x4f0818a28ce2934b, ref x880e0239b007e4f9, ref xf8894778b712e96d, x5614faf5d2637115);
						}
						xce53a4f2835cab70 = ((int) (((Ixb0f0f2071b49b1cb) xd8260a8082223426).xc5207dd50e2ff5b4 + 14));
						xea2a21438bfbe03d = x2b13dab2573bcd5e.xa13f94e29dbd5d94 (x160656af282c4d7b, ref xce53a4f2835cab70, ref x4f0818a28ce2934b, ref x880e0239b007e4f9, ref xf8894778b712e96d, ref xfcbc8d697ad1a389, x5614faf5d2637115);
						xa60661b5d01cbcbc = (xea2a21438bfbe03d & x71589e3f55261426.xd4434a4392e36da6[(((Ixb0f0f2071b49b1cb) xd8260a8082223426).xc5207dd50e2ff5b4 - 1)]);
						x42f081a275d72d2c = ((Ixb0f0f2071b49b1cb) xd8260a8082223426).xf76803be5e9ee2aa (xa60661b5d01cbcbc);
						xe59d6d35c76d70aa = (x42f081a275d72d2c & 65535);
						x57922afe7d4d09e0 = (x2b13dab2573bcd5e.xa52147d0d9c2c73c (x42f081a275d72d2c, 16) & 255);
						x9b229eba46fd51f3 = x2b13dab2573bcd5e.xa52147d0d9c2c73c (x42f081a275d72d2c, 24);
						if (x9b229eba46fd51f3 == 0)
						{
							x58316dde3396e982 = ((int) x71589e3f55261426.x829fbae11dc19d07[xe59d6d35c76d70aa]);
							x2b13dab2573bcd5e.xa4bb90c5f325d0af (x57922afe7d4d09e0, ref x4f0818a28ce2934b, ref x880e0239b007e4f9, ref xf8894778b712e96d, x5614faf5d2637115);
						}
						else
						{
							x58316dde3396e982 = (((int) x71589e3f55261426.x829fbae11dc19d07[xe59d6d35c76d70aa]) + (x2b13dab2573bcd5e.xa52147d0d9c2c73c (xea2a21438bfbe03d, x57922afe7d4d09e0) & x71589e3f55261426.xd4434a4392e36da6[(x9b229eba46fd51f3 - 1)]));
							xce53a4f2835cab70 = (x57922afe7d4d09e0 + x9b229eba46fd51f3);
							x2b13dab2573bcd5e.xa4bb90c5f325d0af (xce53a4f2835cab70, ref x4f0818a28ce2934b, ref x880e0239b007e4f9, ref xf8894778b712e96d, x5614faf5d2637115);
						}
						if (x5c34e2900c6b80d0 <= x58316dde3396e982)
						{
							for (i1 = 0; (i1 < x5c34e2900c6b80d0); i1++)
							{
								x7585f73a99663fd2[(xe2b07c285d73cc12 + i1)] = x7585f73a99663fd2[((xe2b07c285d73cc12 - x58316dde3396e982) + i1)];
							}
						}
						else
						{
							x4996da61da7808c8 = (xe2b07c285d73cc12 - x58316dde3396e982);
							x4cc2dc507646ce1a = xe2b07c285d73cc12;
							for (i1 = 1; (i1 <= x5c34e2900c6b80d0); i1++)
							{
								x7585f73a99663fd2[x4cc2dc507646ce1a] = x7585f73a99663fd2[x4996da61da7808c8];
								x4996da61da7808c8++;
								x4cc2dc507646ce1a++;
							}
						}
						xe2b07c285d73cc12 += x5c34e2900c6b80d0;
						if (xe2b07c285d73cc12 >= x971144bb4ad7e504)
						{
							x5ab6ed99b3041647.Write (x7585f73a99663fd2, 0, 32768);
							x81dfe2898a2fdde1 = 32768;
							for (i1 = 0; (i1 < (xe2b07c285d73cc12 - x81dfe2898a2fdde1)); i1++)
							{
								x7585f73a99663fd2[i1] = x7585f73a99663fd2[(x81dfe2898a2fdde1 + i1)];
							}
							xe2b07c285d73cc12 -= 32768;
						}
					}
					xce53a4f2835cab70 = (((Ixb0f0f2071b49b1cb) xc82e2be11855266c).xc5207dd50e2ff5b4 + 5);
					xea2a21438bfbe03d = x2b13dab2573bcd5e.xa13f94e29dbd5d94 (x160656af282c4d7b, ref xce53a4f2835cab70, ref x4f0818a28ce2934b, ref x880e0239b007e4f9, ref xf8894778b712e96d, ref xfcbc8d697ad1a389, x5614faf5d2637115);
					xa60661b5d01cbcbc = (xea2a21438bfbe03d & x71589e3f55261426.xd4434a4392e36da6[(((Ixb0f0f2071b49b1cb) xc82e2be11855266c).xc5207dd50e2ff5b4 - 1)]);
					x42f081a275d72d2c = ((Ixb0f0f2071b49b1cb) xc82e2be11855266c).xf76803be5e9ee2aa (xa60661b5d01cbcbc);
					xe59d6d35c76d70aa = (x42f081a275d72d2c & 65535);
					x57922afe7d4d09e0 = (x2b13dab2573bcd5e.xa52147d0d9c2c73c (x42f081a275d72d2c, 16) & 255);
				}
			}
			
		#endregion
	}
	
}

